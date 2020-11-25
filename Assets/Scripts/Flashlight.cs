using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 public class Flashlight : MonoBehaviour
{
    public AudioSource source;
    public Slider Chargeslider;
    public Light flashlight;

    public float decreaseRate;
    public AudioClip FlashOn;
    public AudioClip FlashOff;

    public GameObject offphonescreen;





    void Start()
    {
        Chargeslider.maxValue = 100f;
        Chargeslider.minValue = 0f;
        Chargeslider.value = Chargeslider.maxValue;


    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlight.enabled = !flashlight.enabled;

            source.volume = 1f;
            source.PlayOneShot(FlashOn);

            //offphonescreen.gameObject.SetActive(false);
        }




        if (Chargeslider.value <= 0 && flashlight.enabled == true)
        {
          
            flashlight.enabled = false;

            source.volume = 1f;
            source.PlayOneShot(FlashOff);

            offphonescreen.gameObject.SetActive(true);

        }




        if (flashlight.enabled)
        {

            Chargeslider.value -= Time.deltaTime * decreaseRate;


        }


    }
}
