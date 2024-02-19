using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{

	//Time

	public float			start_press;
	public int				in_touch;
	public TouchControls	touchControls;
	public bool				in_select;

	public GameObject		ad;
	public imageTouched		ad_script;

	public GameObject		wrong;
	public GameObject		right;
	public GameObject		background_on_Select;

	public decision			_descision;


//change scense

	public string		zoom_scene;



	public bool				its_phising;


	private void Awake()
	{
		touchControls = new TouchControls();
		
		in_select = false;
		if ((ad = GameObject.Find("Ad")) != null)
			ad_script = ad.GetComponent<imageTouched>();
	}

	private void OnEnable()
	{
		touchControls.Enable();
	}

	private void Update()
	{
		if (in_select == true && in_touch == 1 && _descision.done == true)
		{
			background_on_Select.SetActive(false);
			wrong.SetActive(false);
			right.SetActive(false);
			in_select = false;
		}

		if (Time.time >= start_press && in_touch == 1)
		{
			in_touch = 0;

			if (ad_script.clicked == true)
			{
				Debug.Log("options");
				ad_script.clicked = false;

				if(in_select == false)
				{

					if (_descision.done == false)
					{
						background_on_Select.SetActive(true);
						wrong.SetActive(true);
						right.SetActive(true);
					}

					in_select = true;
				}
			}
		}
	}

	private void OnDisable()
	{
		touchControls.Disable();        
	}

	private void Start()
	{
		touchControls.Touch.TouchPress.started += ctx => StartTouch(ctx);
		touchControls.Touch.TouchPress.canceled += ctx => EndTouch(ctx);
	}

	private void StartTouch(InputAction.CallbackContext context)
	{
		start_press = Time.time + 0.3f;
		in_touch = 1;
	}

	private void EndTouch(InputAction.CallbackContext context)
	{
		if (Time.time <= start_press && in_touch == 1)
		{
			if (ad_script.clicked == true)
			{
				Debug.Log("zoom");
				ad_script.clicked = false;
		        SceneManager.LoadScene(zoom_scene);
			}
			in_touch = 0;
		}
		in_touch = 0;
	}
}