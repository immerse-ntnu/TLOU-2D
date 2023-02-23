using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TLOU2D.game.pausemenu
{
    public class PlayButton : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene(1);
        }
    }
}