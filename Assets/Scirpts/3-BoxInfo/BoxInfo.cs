using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInfo : MonoBehaviour
{
	// Start is called before the first frame update

	public FlipButtonBoxInfo s_flipButton;
	
	void Start()
	{
		s_flipButton = GameObject.FindGameObjectWithTag("BoxInfo_FlipButton").GetComponent<FlipButtonBoxInfo>();
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void call_fliper()
	{
		s_flipButton.ft_pushBelow();
	} 
}
