using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class imageTouched : MonoBehaviour, IPointerDownHandler
{
    public bool         clicked;
    // Start is called before the first frame update
    void Start()
    {
        clicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   	public void OnPointerDown (PointerEventData eventData) 
	{
        clicked = true;
	}

}
