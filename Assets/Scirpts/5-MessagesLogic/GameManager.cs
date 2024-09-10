using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
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
	**		References
	*/

	static GameManager  instance;


	public int wins;
	public InformacionPersonajesSO[]	P = new InformacionPersonajesSO[5];
	public InformacionEmpresasSO[]		B = new InformacionEmpresasSO[1];




	/*
	**	Messages Arrays
	*/
	
	public InformacionMensajesSO[]		M_P1 = new InformacionMensajesSO[1];
	public InformacionMensajesSO[]		M_P2 = new InformacionMensajesSO[1];
	public InformacionMensajesSO[]		M_P3 = new InformacionMensajesSO[1];
	public InformacionMensajesSO[]		M_P4 = new InformacionMensajesSO[1];
	public InformacionMensajesSO[]		M_P5 = new InformacionMensajesSO[1];




	/*
	**	Objects in Scene
	*/

	public BoxInfoFillInfo BoxPerson;
	public BoxInfoFillInfo BoxBusiness;
	public MessageFillInfo Message;




	/*
	**	Current Index showing
	*/

	public	int							currentCharacter;
	public	int							currentMessage;

	public	List<int>					charactersPlayedToday = new List<int>();





	/*
	**			 ______                                           
	**			 (_) |                         o                   
	**			    _|_         _  _    __ _|_     __   _  _    ,  
	**			   / | ||   |  / |/ |  /    |  |  /  \_/ |/ |  / \_
	**			  (_/    \_/|_/  |  |_/\___/|_/|_/\__/   |  |_/ \/ 
	**
	*/	




	// Start is called before the first frame update
	void Start()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}        
		else
		{
			instance = this;
			DontDestroyOnLoad(this.gameObject);

			ft_getReferences();
			ft_chooseCharacter();
			ft_fillCharacterInfo();
			ft_fillMessageAndBusiness();
		}
	}

	/*
	**	Game Managment Functions
	*/

	void ft_getReferences()
	{
		BoxPerson = GameObject.FindGameObjectWithTag("Boxinfo_Person").GetComponent<BoxInfoFillInfo>();
		BoxBusiness = GameObject.FindGameObjectWithTag("Boxinfo_Business").GetComponent<BoxInfoFillInfo>();
		Message = GameObject.FindGameObjectWithTag("Message").GetComponent<MessageFillInfo>();
	}
                 
	void ft_chooseCharacter()
	{
		currentCharacter = Random.Range(0, 5);
		charactersPlayedToday.Add(currentCharacter);
	}


	/*
	**	UI Functions
	*/


	void ft_fillCharacterInfo()
	{
		BoxPerson.boxA.text = P[currentCharacter].nombreDelPersonaje;
		BoxPerson.boxB.text = P[currentCharacter].estadoCivil;
		BoxPerson.boxC.text = P[currentCharacter].entidadBancoria;
		BoxPerson.boxD.text = P[currentCharacter].gustosPersonaje;
	} 


	void ft_fillMessageAndBusiness()
	{
		/*
		Select random message, now there is only 1
		*/

		Message.NameBusinessText.text = M_P1[currentMessage].emisorDelMensajes;
		Message.MessageText.text = M_P1[currentMessage].contenidoMensajes;
		//Message.BusinessImage = M_P1[currentMessage].empresaPrefab.imagenDePerfilEmpresa;		// This casting may not work ❗

		
		BoxBusiness.boxSprite = M_P1[currentMessage].empresaPrefab.imagenDePerfilEmpresa;		// This casting may not work ❗
		BoxBusiness.boxA.text = M_P1[currentMessage].empresaPrefab.nombreDeLaEmpresa;
		BoxBusiness.boxB.text = M_P1[currentMessage].empresaPrefab.contactoEmpresa;
		BoxBusiness.boxC.text = M_P1[currentMessage].empresaPrefab.reclamoEmpresa;
		BoxBusiness.boxD.text = M_P1[currentMessage].empresaPrefab.urlsEmpresa;

	}


	
	public void swiped(Vector2 pos)
	{
		if (M_P1[currentMessage].phising == true)
		{
			if (pos.x > 0)
			{
				P[currentCharacter].performanceHistory.Add(1);
				print("Era Phising. Acertaste");
			}
			else
			{
				P[currentCharacter].performanceHistory.Add(0);
				print("Era Phising. Fallaste");
			}
		}
		else
		{
			if (M_P1[currentMessage].phising == false)
			{
				if (pos.x > 0)
				{
					print("No era Phising. Fallaste");
					P[currentCharacter].performanceHistory.Add(0);
				}
				else
				{
					print("No era Phising. Acertaste");
					P[currentCharacter].performanceHistory.Add(1);
				}
			}
		}
	}
}
