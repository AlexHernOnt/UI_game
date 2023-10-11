using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class navegation : MonoBehaviour
{
    public int           order;
    public string           _next_scene;

    void Start()
    {
        if (order == 1) 
            _next_scene = GameObject.Find("Manager_scenes").GetComponent<keep_the_score>().s1;
        if (order == 2)
            _next_scene = GameObject.Find("Manager_scenes").GetComponent<keep_the_score>().s2;
        if (order == 3)
            _next_scene = GameObject.Find("Manager_scenes").GetComponent<keep_the_score>().s3;
        if (order == 4)
            _next_scene = GameObject.Find("Manager_scenes").GetComponent<keep_the_score>().s4;
    }

// Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSceneFromMenu()
    {
        SceneManager.LoadScene(_next_scene);
    }

    public void go_back()
    {
        GameObject          _manager_scenes = GameObject.Find("Manager_scenes");
        string              str = _manager_scenes.GetComponent<keep_the_score>()._nameMenuScene;

        SceneManager.LoadScene(str);
    }


    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void playAnimationFromCode(string sceneName)
    {
    }

}
