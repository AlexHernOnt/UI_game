using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keep_the_score : MonoBehaviour
{
    static keep_the_score   _isntance;


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
            start_day_1();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void start_day_1()
    {
        n1.nextScene = s1;
        n2.nextScene = s2;
        n3.nextScene = s3;
        n4.nextScene = s4;
    }
}
