using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intermedio_actions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        keep_the_score          kts;

        kts = GameObject.Find("Manager_scenes").GetComponent<keep_the_score>();
        kts.change_score();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
