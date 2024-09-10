using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SwipeDeMensajes : MonoBehaviour, IDragHandler, IEndDragHandler
{

	/*
	**	
	**  _                          _    _          
	** (_|   |_/          o       | |  | |         
	**   |   | __,   ,_       __, | |  | |  _   ,  
	**   |   |/  |  /  |  |  /  | |/ \_|/  |/  / \_
	**    \_/ \_/|_/   |_/|_/\_/|_/\_/ |__/|__/ \/ 
	**                                             
	*/


	/*
	**      Refs
	*/

	public GameManager			_gameManager;


	private RectTransform		rectTransform;
	public Image				image;
	private Vector2				startPos;
	private Color				originalColor;

	/*
	**      Asthethics of the Swiping
	*/

	public float				rotationAngle = 25f;
	public float				swipeThreshold = 200f;
	public float				minAlpha = 0.5f; // Transparencia m�nima
	public float				colorBlendFactor = 0.5f; // Factor de mezcla del color (0.0 = original, 1.0 = completamente tintado)







	/*
	**			 ______                                           
	**			 (_) |                         o                   
	**			    _|_         _  _    __ _|_     __   _  _    ,  
	**			   / | ||   |  / |/ |  /    |  |  /  \_/ |/ |  / \_
	**			  (_/    \_/|_/  |  |_/\___/|_/|_/\__/   |  |_/ \/ 
	**
	*/	


	void Start()
	{
		ft_getReferences();

		startPos = rectTransform.anchoredPosition;
		originalColor = image.color;
	}


	/*
	**	SwipeDeMensajes Functions
	*/

	void ft_getReferences()
	{
		rectTransform = GetComponent<RectTransform>();
		_gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}

	public void OnDrag(PointerEventData eventData)
	{
		Vector2 pos = rectTransform.anchoredPosition;
		pos.x += eventData.delta.x;
		rectTransform.anchoredPosition = pos;

		float rotation = Mathf.Lerp(0, rotationAngle, Mathf.Abs(pos.x) / swipeThreshold);
		rectTransform.rotation = Quaternion.Euler(0, 0, pos.x > 0 ? -rotation : rotation);

		float alpha = Mathf.Lerp(1f, minAlpha, Mathf.Abs(pos.x) / swipeThreshold);

		// Determina el color basado en la direcci�n del deslizamiento
		Color targetColor = pos.x > 0 ? Color.green : Color.red;
		Color blendedColor = Color.Lerp(originalColor, targetColor, colorBlendFactor);
		image.color = new Color(blendedColor.r, blendedColor.g, blendedColor.b, alpha);
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		Vector2 pos = rectTransform.anchoredPosition;

		if (Mathf.Abs(pos.x) >= swipeThreshold)
		{
			// Aqu� puedes manejar la acci�n de "descarte", por ejemplo, moviendo la imagen fuera de la pantalla.
			_gameManager.swiped(pos);
            pos.x = pos.x > 0 ? Screen.width : -Screen.width;
		}
		else
		{
			// Devuelve la imagen a su posici�n original
			pos = startPos;
		}

		rectTransform.anchoredPosition = pos;
		rectTransform.rotation = Quaternion.identity; // Resetea la rotaci�n
		image.color = originalColor; // Resetea la transparencia y el color
	}
}
