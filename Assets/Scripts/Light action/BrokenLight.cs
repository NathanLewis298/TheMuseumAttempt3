using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenLight : MonoBehaviour
{
    public static bool isBroken = false;
    public static int lightBulbs = 0;
    public GameObject Haslight;
    public AudioSource source;
    public AudioClip Backon;



    private void OnTriggerStay(Collider other)
    {
        if(lightBulbs > 0 && Input.GetKeyDown(KeyCode.E) && isBroken)
        {
            var lights = FindObjectsOfType<LightControler>();
            foreach(var light in lights)
            {
                light.TurnOn();
            }

            lightBulbs -= 1;

            source.volume = 1f;
            source.PlayOneShot(Backon);

            FindObjectOfType<Blackout>().TriggerNewBlackout(60);
            FindObjectOfType<HeartBreaker>().blackout = false;

            Haslight.gameObject.SetActive(false);

        }
    }
}
