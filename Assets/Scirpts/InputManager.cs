using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

	//Time

	public float			start_press;
	public int				in_touch;
	private TouchControls	touchControls;

	private GameObject		ad;
	private imageTouched	ad_script;

	public GameObject		wrong;
	public GameObject		right;


	private void Awake()
	{
		touchControls = new TouchControls();
		
		ad = GameObject.Find("Ad");
		ad_script = ad.GetComponent<imageTouched>();

	}

	private void OnEnable()
	{
		touchControls.Enable();
	}
	private void Update()
	{
		if (Time.time >= start_press && in_touch == 1)
		{
			in_touch = 0;
			if (ad_script.clicked == true)
			{
				Debug.Log("options");
				ad_script.clicked = false;
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
		start_press = Time.time + 0.5f;
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
			}
			in_touch = 0;
		}
		in_touch = 0;
	}
}