using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPickup : MonoBehaviour
{

    public GameObject Haslight;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && BrokenLight.lightBulbs == 0)
        {
            BrokenLight.lightBulbs += 1;
            Destroy(gameObject);

            Haslight.gameObject.SetActive(true);

        }



    }
}
