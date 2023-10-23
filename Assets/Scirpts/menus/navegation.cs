using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class navegation : MonoBehaviour
{
    public int              order;
    public string           _next_scene;
    
    void Start()
    {
        keep_the_score          kts;

        kts = GameObject.Find("Manager_scenes").GetComponent<keep_the_score>();
        if (order == 1)
        {

		    kts.deactivate_notifications();
            kts.change_score();

        }

        if (order == 1)
            _next_scene = kts.s1;
        if (order == 2)
            _next_scene = kts.s2;
        if (order == 3)
            _next_scene = kts.s3;
        if (order == 4)
            _next_scene = kts.s4;
    }

// Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSceneFromMenu()
    {
        keep_the_score          kts;

        kts = GameObject.Find("Manager_scenes").GetComponent<keep_the_score>();
        kts.clicked_on = order;

        if (order == 1)
            SceneManager.LoadScene(kts.s1);
        if (order == 2)
            SceneManager.LoadScene(kts.s2);
        if (order == 3)
            SceneManager.LoadScene(kts.s3);
        if (order == 4)
            SceneManager.LoadScene(kts.s4);
        
    }

    public void go_back()
    {
        GameObject          _manager_scenes = GameObject.Find("Manager_scenes");
        string              str = _manager_scenes.GetComponent<keep_the_score>()._nameMenuScene;

        SceneManager.LoadScene(str);
    }
   public void go_back_new_day()
    {
        keep_the_score          kts;
        kts = GameObject.Find("Manager_scenes").GetComponent<keep_the_score>();

        kts.get_new_round();
        SceneManager.LoadScene(kts._nameMenuScene);
    }
    public void load_jefa()
    {
        SceneManager.LoadScene("Jefa");
    }


    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void playAnimationFromCode(string sceneName)
    {
    }
    public void nextDay()
    {
        SceneManager.LoadScene("Intermedio");
    }

}
