using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    
        // Start is called before the first frame update
        void Start()
        {
            canvas.SetActive(false);
        }

        public GameObject canvas;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                canvas.SetActive(!canvas.activeSelf);
            }
        }
    }
