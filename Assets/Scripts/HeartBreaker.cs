using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeartBreaker : MonoBehaviour
{
    public float currenHeartRate = 61f;

    public Flashlight flashlight;

    public float maxHearRate = 121f;

    public float minHeartRate = 61f;

    public float hrIncrease = 1f;

    public Text currentHeartDisplay;

    public  bool isOffice = true;
    public bool blackout = false;

    float variation = 0f;
    public float variationSpeed = 1f;

    void Start()
    {

        InvokeRepeating("SelectRandom", 0.5f, variationSpeed);



    }

    void SelectRandom()
    {
        variation = Random.Range(-1, 1);
    }

    
    void Update()
    {

        

        if (isOffice == false && blackout && !FindObjectOfType<Flashlight>().flashlight.enabled)
        {
            currenHeartRate += Time.deltaTime * hrIncrease;
        }

        else if (isOffice == true)
        {
            currenHeartRate -= Time.deltaTime;
            FindObjectOfType<Flashlight>().Chargeslider.value += Time.deltaTime * 5;
            flashlight.offphonescreen.gameObject.SetActive(false);
        }

        currenHeartRate = Mathf.Clamp(currenHeartRate, minHeartRate, maxHearRate);

        currentHeartDisplay.text = ((int)(currenHeartRate + variation)).ToString();


        if (currenHeartRate >= maxHearRate)
        {
            SceneManager.LoadScene("Death");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        isOffice = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isOffice = false;
    }
}
