using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swpie : MonoBehaviour
{
    public Sprite           PageImage;
    public List<Sprite>     Numbers;

    private Vector2         startTouchPosition;
    private Vector2         endTouchPosition;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if (endTouchPosition.x < startTouchPosition.x)
            {
                NextPage();

            }




        }
    }
}
