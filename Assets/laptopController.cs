using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LaptopOpenScript
{

    public class laptopController : MonoBehaviour
    {
        public float DistanceOpen = 4;
        public float DistanceClose = 5;
        public GameObject text;
        public bool READY;
        public Camera childCamera;
        public bool isInteracting = false;
    private LaptopScript.Laptop laptop;
        private LaptopScript.Laptop currentLaptop;
        // Start is called before the first frame update
        void Start()
        {
            laptop = null;
            text.SetActive(false);
            childCamera = GetComponentInChildren<Camera>();
        }

        // Update is called once per frame
        void Update()
        {
            RaycastHit hit;
            if (Physics.Raycast(childCamera.transform.position, childCamera.transform.forward, out hit, DistanceOpen))
            {
                laptop = hit.transform.GetComponent<LaptopScript.Laptop>();
                if (laptop != null)
                {
                    text.SetActive(true);
                 
                        
                    READY = true;
                    if (Input.GetKeyDown(KeyCode.E))
                        laptop.Open();
                    if (Input.GetKeyDown(KeyCode.F))
                        laptop.Close();
                }
                else
                {
                    text.SetActive(false);
                  
                }
            }
            else
            {   
             
                
                text.SetActive(false);
            }
            if (laptop != null)
            {
                if (Vector3.Distance(transform.position, laptop.transform.position)>DistanceClose)
                {
                    laptop.Close();
                    laptop = null;
                }
            }

            
        }
    }
}
