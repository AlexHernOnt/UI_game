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
		if ((manager = GameObject.Find("Manager")) != null)
			sc_manager = manager.GetComponent<InputManager>();
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void EsPhishing() 
	{
		print("tururu");
		if (done == false)
		{
			keep_the_score kts = GameObject.Find("Manager_scenes").GetComponent<keep_the_score>();
	        kts.scene_played(kts.clicked_on);

			if (sc_manager.its_phising == false)
			{
				print("abs");
				incorrect.SetActive(true);
				kts.incorrect++;
			}
			else
			{
				print("abs2");
				correct.SetActive(true);
				kts.correct++;
			}
			done = true;
		}
	}
	
	public void EsAutentico()
	{
		print("cuscus");
		if (done == false)
		{
			keep_the_score kts = GameObject.Find("Manager_scenes").GetComponent<keep_the_score>();
	        kts.scene_played(kts.clicked_on);

			if (sc_manager.its_phising == true)
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
