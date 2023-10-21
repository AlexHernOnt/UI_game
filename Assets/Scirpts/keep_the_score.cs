using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class keep_the_score : MonoBehaviour
{
    static keep_the_score   _isntance;
    public string           _nameMenuScene;

    public int              clicked_on;

    public navegation       n1;
    public navegation       n2;
    public navegation       n3;
    public navegation       n4;
//
    public string           s1;
    public string           s2;
    public string           s3;
    public string           s4;

    
    public TMP_Text            text_correct;
    public TMP_Text            text_incorrect;


    public int              correct;
    public int              incorrect;


    public int              current_day;
    // Start is called before the first frame update
    void Start()
    {
        current_day = 1;
        if (_isntance != null)
            Destroy(gameObject);
        else
        {
            
            _isntance = this;
            DontDestroyOnLoad(this.gameObject);
            // I don't need any of this at all.
            n1 = GameObject.Find("C1").GetComponent<navegation>();
            n2 = GameObject.Find("C2").GetComponent<navegation>();
            n3 = GameObject.Find("C3").GetComponent<navegation>();
            n4 = GameObject.Find("C4").GetComponent<navegation>();
            start_day_1();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void start_day_1()
    {
        //n1._next_scene = s1;
        //n2._next_scene = s2;
        //n3._next_scene = s3;
        //n4._next_scene = s4;
    }

    public void scene_played(int scene)
    {
        if (scene == 1)
            s1 = " ";
        else if (scene == 2)
            s2 = " ";
        else if (scene == 3)
            s3 = " ";
        else if (scene == 4)
            s4 = " ";
    }

    public void deactivate_notifications()
    {
        if (s1 == " ")
            GameObject.Find("Noti1").SetActive(false);
        if (s2 == " ")
            GameObject.Find("Noti2").SetActive(false);
        if (s3 == " ")
            GameObject.Find("Noti3").SetActive(false);
        if (s4 == " ")
            GameObject.Find("Noti4").SetActive(false);
    }

    public void change_score()
    {
        text_correct = GameObject.Find("Correct_ui").GetComponent<TMP_Text>();
        text_incorrect = GameObject.Find("Incorrect_ui").GetComponent<TMP_Text>();

        text_correct.text = correct.ToString();
        text_incorrect.text = incorrect.ToString();
    }
}
