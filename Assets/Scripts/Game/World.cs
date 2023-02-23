using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TLOU2D.game
{

    public class World : MonoBehaviour
    {

        public static World INSTANCE
        {
            get;
            private set;
        }

        // Start is called before the first frame update
        void Start()
        {
            INSTANCE = this;
            Time.timeScale = 1;
        }

        public void pauseWorld(bool val)
        {
            Time.timeScale = val ? 0 : 1;
            Debug.Log(Time.timeScale);
        }
    }
}