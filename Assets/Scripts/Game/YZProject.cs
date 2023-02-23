using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TLOU2D.game
{
    public class YZProject : MonoBehaviour
    {
        public GameObject obj;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            obj.transform.position =
                new Vector3(obj.transform.position.x, obj.transform.position.y, obj.transform.position.y);
        }
    }
}