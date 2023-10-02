using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class imageTouched : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   	public void OnPointerDown (PointerEventData eventData) 
	{
		Debug.Log (this.gameObject.name + " Was Clicked.");
        Destroy(gameObject);
	}

}
