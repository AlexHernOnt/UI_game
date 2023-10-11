using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class click_on_fingerprint : MonoBehaviour
{
	public GameObject		a;
	public GameObject		b;

	public Animation		_Animation;
	public Animation		_Animation2;

	float			        deadline;
    int                     clicked;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    	if (clicked == 1 && deadline <= Time.time)
            SceneManager.LoadScene("Menu_contactos_dia_1");

    }

    public void ft_go_to_main()
    {
        a.SetActive(true);
        b.SetActive(true);

		_Animation.Play("Waves_anim");
		_Animation2.Play("Waves2_anim");
		deadline = Time.time + 1f;
        clicked = 1;
    }
}
