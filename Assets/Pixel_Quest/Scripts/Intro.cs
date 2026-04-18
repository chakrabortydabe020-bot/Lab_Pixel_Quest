using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public string startScene;
    // Start is called before the first frame update

    public void Start() { }
    

       public void LoadStartScene()
        {
            SceneManager.LoadScene(startScene);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
}



