using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class navegation : MonoBehaviour
{

    public string       nextScene;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

       public void ChangeSceneFromMenu()
    {
        SceneManager.LoadScene(nextScene);
    }


    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void playAnimationFromCode(string sceneName)
    {
    }

}
