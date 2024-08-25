using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipButtonBoxInfo : MonoBehaviour
{
	public Animator BoxBusiness;
	public Animator BoxPerson;

	public bool BoxPersonShowing = true;

	// Start is called before the first frame update
	void Start()
	{
		BoxBusiness = GameObject.FindGameObjectWithTag("Boxinfo_Business").GetComponent<Animator>();
		BoxPerson = GameObject.FindGameObjectWithTag("Boxinfo_Person").GetComponent<Animator>();
	}


	public void ft_pushBelow()
	{
		GameObject BoxToFlip;

		if (BoxPersonShowing == true)
			BoxToFlip = GameObject.FindGameObjectWithTag("Boxinfo_Business");
		else
			BoxToFlip = GameObject.FindGameObjectWithTag("Boxinfo_Person");

		BoxToFlip.transform.SetSiblingIndex(BoxToFlip.transform.GetSiblingIndex() - 1);
	}

	public void ft_flip()
	{
		if (BoxPersonShowing == true)
			BoxPerson.Play("FilipAnim");
		else
			BoxBusiness.Play("FilipAnim");
		
		BoxPersonShowing = BoxPersonShowing ? false : true;
	}    
}
