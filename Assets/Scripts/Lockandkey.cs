using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Lockandkey : MonoBehaviour
{


    public int totalkeyAmount = 6;
    public static int currentkeyAmount = 0;
   

    public GameObject exitDoor;



    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && totalkeyAmount == currentkeyAmount)
        {
            SceneManager.LoadScene("End");
        }
        
    }


    void Start()
    {




    }

    
    void Update()
    {
        
    }
}
