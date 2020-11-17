using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class Handpresence : MonoBehaviour
{
    public List<GameObject> controllerPrefabs;
    public GameObject handModelPrefab;
    private GameObject spawnedModelPrefab;
    private InputDevice targetDevice;
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        foreach (var item in devices)
        {
           Debug.Log(item.name + item.characteristics);
        }
    
        if(devices.Count > 0)
        {
            targetDevice = devices[0];



            spawnedModelPrefab = Instantiate(handModelPrefab, transform);
        }
    
    
    
    
    }

    // Update is called once per frame
    void Update()
    {

    }
}