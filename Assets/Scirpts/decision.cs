using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decision : MonoBehaviour
{

		// Answer

	public GameObject		correct;
	public GameObject		incorrect;

	public GameObject		manager;
	public InputManager     sc_manager;

	public bool				done;

	// Start is called before the first frame update
	void Start()
	{
		manager = GameObject.Find("Manager");
		sc_manager = manager.GetComponent<InputManager>();
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void ad_is_not_scam() 
	{
		if (done == false)
		{
			keep_the_score kts = GameObject.Find("Manager_scenes").GetComponent<keep_the_score>();
	        kts.scene_played(kts.clicked_on);

			if (sc_manager.its_scam == true)
			{
				incorrect.SetActive(true);
				kts.incorrect++;
			}
			else
			{
				correct.SetActive(true);
				kts.correct++;
			}
			done = true;
		}
	}
	
	public void ad_is_scam()
	{
		if (done == false)
		{
			keep_the_score kts = GameObject.Find("Manager_scenes").GetComponent<keep_the_score>();
	        kts.scene_played(kts.clicked_on);

			if (sc_manager.its_scam == false)
			{
				incorrect.SetActive(true);
				kts.incorrect++;
			}
			else
			{
				correct.SetActive(true);
				kts.correct++;
			}
			done = true;
		}
	}
}
