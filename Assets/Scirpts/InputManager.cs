using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

	//Time

	public float   start_press;
	public int		in_touch;
	private TouchControls touchControls;

	private void Awake()
	{
		touchControls = new TouchControls();
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
			Debug.Log("thtbawtdfmtidwtlamaaph");
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
		in_touch = 0;
	}
}