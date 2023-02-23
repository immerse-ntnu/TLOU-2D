using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TLOU2D.mainmenu{
    public class ExitButton : MonoBehaviour
    {
        public void ExitGame()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }
    }
}