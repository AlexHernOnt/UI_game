using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keep_the_score : MonoBehaviour
{
    static keep_the_score   _isntance;
    public string           _nameMenuScene;

    public navegation       n1;
    public navegation       n2;
    public navegation       n3;
    public navegation       n4;

    public string           s1;
    public string           s2;
    public string           s3;
    public string           s4;


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
        n1._next_scene = s1;
        n2._next_scene = s2;
        n3._next_scene = s3;
        n4._next_scene = s4;
    }
}
