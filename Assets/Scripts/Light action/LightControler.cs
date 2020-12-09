using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControler : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;
    public AudioClip breakdown;

    bool isFlickering = false;
    public float timeDelay;

    public MeshRenderer renderer;
    public Material materialOn;
    public Material materialOff;


    float timer = 0f;

    Light spotLight;

    private void Start()
    {
        spotLight = GetComponent<Light>();
    }

    void Update()
    {
        if (isFlickering == false && timer > 0)
        {
            StartCoroutine(FlickeringLight());
        }
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }

    public void StartFlickering(float length)
    {
        timer = length;

        if (source)
        {

            source.volume = 0.1f;
            source.PlayOneShot(breakdown);


        }
            

    }

    public IEnumerator FlickeringLight()
    {
        isFlickering = true;
        spotLight.enabled = false;
        renderer.material = materialOff;
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        spotLight.enabled = true;
        renderer.material = materialOn;
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;

        Turnoff(false);
    }

    public void Turnoff(bool playAudio = true)
    {
        spotLight.enabled = false;
        renderer.material = materialOff;
        if (source && playAudio)
        {
            source.volume = 1f;
            source.PlayOneShot(clip);
        }
            
    }

    public void TurnOn()
    {
        spotLight.enabled = true;
        renderer.material = materialOn;
        if (source)
        {
            source.volume = 1f;
            //source.PlayOneShot(clip);
        }

    }



}
