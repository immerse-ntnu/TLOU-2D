using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TLOU2D.game.pausemenu
{
    public class ExitButton : MonoBehaviour
    {
        public void Exit()
        {
            SceneManager.LoadScene(0);
        }
    }
}