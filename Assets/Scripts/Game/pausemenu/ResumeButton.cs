using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TLOU2D.game.pausemenu
{
    public class ResumeButton : MonoBehaviour
    {
        public GameObject canvas;
        public void ResumeGame()
        {
            canvas.SetActive(false);
        }
    }
}