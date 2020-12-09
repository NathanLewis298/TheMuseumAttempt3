using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Keys : MonoBehaviour

{
    public AudioSource source;
    public AudioClip keyssound;
    public Text currentkeysDisplay;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Lockandkey.currentkeyAmount++;

            currentkeysDisplay.text = Lockandkey.currentkeyAmount.ToString();

            source.volume = 1f;
            other.GetComponent<AudioSource>().PlayOneShot(keyssound);


            Destroy(gameObject);



        }



    }




}
