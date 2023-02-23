using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TLOU2D.game.pausemenu{
    public class PauseMenuScript : MonoBehaviour
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
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                canvas.SetActive(!canvas.activeSelf);
                World.INSTANCE.pauseWorld(canvas.activeSelf);
            }
        }
    }
}