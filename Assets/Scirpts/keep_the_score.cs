using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;




public class keep_the_score : MonoBehaviour
{
	static keep_the_score   _isntance;
	public string           _nameMenuScene;

	public int              clicked_on;


//


	public string           s1;
	public string           s2;
	public string           s3;
	public string           s4;

	
	public TMP_Text         text_correct;
	public TMP_Text         text_incorrect;


	public int              correct;
	public int              incorrect;


	public int              current_day;
	// Start is called before the first frame update
	void Start()
	{
		current_day = 1;
		if (_isntance != null)
			Destroy(gameObject);
		else
		{
			get_new_round();
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
		//n1._next_scene = s1;
		//n2._next_scene = s2;
		//n3._next_scene = s3;
		//n4._next_scene = s4;
	}

	public void scene_played(int scene)
	{
		if (scene == 1)
			s1 = " ";
		else if (scene == 2)
			s2 = " ";
		else if (scene == 3)
			s3 = " ";
		else if (scene == 4)
			s4 = " ";
	}

	private GameObject next_day_obj;

	public void deactivate_notifications()
	{
		next_day_obj = GameObject.Find("next_day");
		next_day_obj.SetActive(false);

		if (s1 == " ")
			GameObject.Find("Noti1").SetActive(false);
		if (s2 == " ")
			GameObject.Find("Noti2").SetActive(false);
		if (s3 == " ")
			GameObject.Find("Noti3").SetActive(false);
		if (s4 == " ")
			GameObject.Find("Noti4").SetActive(false);
		if (s1 == " " && s2 == " " && s3 == " " && s4 == " ")
		{
			next_day_obj.SetActive(true);
		}
	}

	public void change_score()
	{
		text_correct = GameObject.Find("Correct_ui").GetComponent<TMP_Text>();
		text_incorrect = GameObject.Find("Incorrect_ui").GetComponent<TMP_Text>();

		text_correct.text = correct.ToString();
		text_incorrect.text = incorrect.ToString();
	}


	//This gets a new lineup of people's stories
	public int[] 	Antonio		= new int[10];
	public int[] 	Teresa		= new int[10];
	public int[] 	Manuel		= new int[10];
	public int[] 	Laura		= new int[10];
	public int[] 	ManuelC		= new int[10];
	public int[] 	Maria		= new int[10];
	public int[]	Juan		= new int[10];

	public int		Antonio_counter;


	public int get_random()
	{
        System.Random _random = new System.Random();
        return(_random.Next(0, 10));
	}

	public void get_new_round()
	{
		if (Antonio_counter != 10)
		{
			while (true)
			{
				int rn = get_random();
				if (Antonio[rn] == 0)
				{
					s1 = "Antonio" + (rn + 1).ToString();
					Antonio[rn] = 1;
					Antonio_counter++;
					break ;
				}
			}
			while (true)
			{
				int rn = get_random();
				if (Teresa[rn] == 0)
				{
					s2 = "Teresa" + (rn + 1).ToString();
					Teresa[rn] = 1;
					break ;
				}
			}
			while (true)
			{
				int rn = get_random();
				if (Manuel[rn] == 0)
				{
					s3 = "Manuel" + (rn + 1).ToString();
					Manuel[rn] = 1;
					break ;
				}
			}
			while (true)
			{
				int rn = get_random();
				if (Laura[rn] == 0)
				{
					s4 = "Laura" + (rn + 1).ToString();
					Laura[rn] = 1;
					break ;
				}
			}
		}
		else
		{

		}

	}
}
