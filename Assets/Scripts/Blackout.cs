using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blackout : MonoBehaviour
{
    public LightControler[] lights;
    public ParticleSystem system;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CauseBlackout(3));
    }

    IEnumerator CauseBlackout(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        lights[1].StartFlickering(5);
        yield return new WaitForSeconds(5.1f);
        system.Play();
        StopCoroutine(lights[1].FlickeringLight());
        lights[1].Turnoff();
        yield return new WaitForSeconds(1);
        lights[1].Turnoff();
        lights[0].Turnoff();
        lights[2].Turnoff();
        yield return new WaitForSeconds(1);
        lights[3].Turnoff();
        lights[4].Turnoff();
        lights[5].Turnoff();
        yield return new WaitForSeconds(1);
        lights[6].Turnoff();
        lights[7].Turnoff();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
