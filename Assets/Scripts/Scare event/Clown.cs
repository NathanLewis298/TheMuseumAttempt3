using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clown : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clownScream;
    public GameObject clown;
    public Camera mirror;
    public LayerMask withclown;
    public LayerMask withoutclown;

    private HeartBreaker Clownspawn;

    public LightControler Clownlight;
    public bool blackout = false;

    bool completed = false;

    bool triggered = false;


    private void Start()
    {
        Clownspawn = FindObjectOfType<HeartBreaker>();
    }




    private void OnTriggerEnter(Collider other)
    {

        blackout = FindObjectOfType<HeartBreaker>().blackout;


        if (blackout == true && completed == true && triggered == false)
        {
            clown.SetActive(true);

            mirror.cullingMask = withclown;

            StartCoroutine(ActivateClown(4f));

            Clownspawn.currenHeartRate += 20f;

            triggered = true;
        }



    }

    IEnumerator ActivateClown(float length)
    {
        source.volume = 0.5f;
        source.PlayOneShot(clownScream);

        Clownlight.StartFlickering(length);
        yield return new WaitForSeconds(length + 0.1f);
        clown.SetActive(false);
        Clownlight.Turnoff();
    }

    private void OnTriggerExit(Collider other)
    {
        clown.SetActive(false);

        mirror.cullingMask = withoutclown;

        completed = true;
    }


}
