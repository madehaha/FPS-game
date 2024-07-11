using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LaptopScript
{
public class Laptop : MonoBehaviour
{
    public bool openMonitor;
    public Camera childCamera;
        public RawImage monitorDisplay;
        // Start is called before the first frame update
        void Start()
    {
        childCamera = GetComponentInChildren<Camera>();
        openMonitor = false;
        childCamera.enabled = openMonitor;
            monitorDisplay.enabled = openMonitor;
        }

    // Update is called once per frame


    public void Open()
    { 
        openMonitor = true;
        childCamera.enabled = openMonitor;
            monitorDisplay.enabled = openMonitor;
        }

    public void Close()
    {
        openMonitor = false;
            childCamera.enabled = openMonitor;
            monitorDisplay.enabled = openMonitor;
        }
    
     
}
}

