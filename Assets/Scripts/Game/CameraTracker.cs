using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TLOU2D.game
{
    public class CameraTracker : MonoBehaviour
    {
        [SerializeField] private Transform player;

        // Update is called once per frame
        private void Update()
        {
            transform.position = new Vector3(player.position.x, player.position.y, player.position.z - 10);
        }
    }
}