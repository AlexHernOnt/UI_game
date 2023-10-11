using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moreInfo : MonoBehaviour
{
	Animator		_Animator;
	int  			shoulgGoUp = 0;
	float			deadline;

	// Start is called before the first frame update
	void Start()
	{
		_Animator = gameObject.GetComponent<Animator>();

	}

	public void ft_move()
	{
		if (shoulgGoUp == 0 && deadline <= Time.time)
		{
			_Animator.Play("mas_info_down");
			shoulgGoUp = 1;
			deadline = Time.time + 1.4f;
		}
    	else if (deadline <= Time.time)
		{
    		_Animator.Play("mas_info_up");
			shoulgGoUp = 0;
			deadline = Time.time + 1.4f;

		}
	}
}
