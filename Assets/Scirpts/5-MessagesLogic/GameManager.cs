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
	public InformacionEmpresasSO[]		B = new InformacionEmpresasSO[3];




	/*
	**	Messages Arrays
	*/
	
	public InformacionMensajesSO[]		M_P1 = new InformacionMensajesSO[6];
	public InformacionMensajesSO[]		M_P2 = new InformacionMensajesSO[6];
	public InformacionMensajesSO[]		M_P3 = new InformacionMensajesSO[6];
	public InformacionMensajesSO[]		M_P4 = new InformacionMensajesSO[6];
	public InformacionMensajesSO[]		M_P5 = new InformacionMensajesSO[6];




	/*
	**	Objects in Scene
	*/

	public BoxInfoFillInfo BoxPerson;
	public BoxInfoFillInfo BoxBusiness;
	public MessageFillInfo BoxMessage;




	/*
	**	Current Index showing
	*/

	public	int							currentCharacter;
	public	int							currentMessage;
	InformacionMensajesSO				messageAux;

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
		BoxMessage = GameObject.FindGameObjectWithTag("Message").GetComponent<MessageFillInfo>();
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
	
		BoxPerson.boxSprite.sprite = P[currentCharacter].imagenDePerfil;
	} 


	void ft_fillMessageAndBusiness()
	{
		/*
		Select random message, now there is only 1
		*/


		currentMessage = Random.Range(0, 5);

		switch (currentCharacter)
		{
			case 0:
				messageAux = M_P1[currentMessage];
				break;
			case 1:
				messageAux = M_P2[currentMessage];
				break;
			case 2:
				messageAux = M_P3[currentMessage];
				break;
			case 3:
				messageAux = M_P4[currentMessage];
				break;
			case 4:
				messageAux = M_P5[currentMessage];
				break;
			default:
				messageAux = null;
				break;
		}




		/*
		**	Fill the Message Card below
		*/

		BoxMessage.NameBusinessText.text = messageAux.emisorDelMensajes;
		BoxMessage.MessageText.text = messageAux.contenidoMensajes;
		BoxMessage.BusinessImage.sprite = messageAux.empresaPrefab.imagenDePerfilEmpresa;
		
		/*
		**	Fill the Business Card above
		*/
		
		BoxBusiness.boxA.text = messageAux.empresaPrefab.nombreDeLaEmpresa;
		BoxBusiness.boxB.text = messageAux.empresaPrefab.contactoEmpresa;
		BoxBusiness.boxC.text = messageAux.empresaPrefab.reclamoEmpresa;
		BoxBusiness.boxD.text = messageAux.empresaPrefab.urlsEmpresa;
		BoxBusiness.boxSprite.sprite = messageAux.empresaPrefab.imagenDePerfilEmpresa;


	}


	
	public void swiped(Vector2 pos)
	{
		if (messageAux.phising == true)
		{
			if (pos.x > 0)
			{
				P[currentCharacter].performanceHistory.Add(0);
				print("Era Phising. Fallaste");
			}
			else
			{
				P[currentCharacter].performanceHistory.Add(1);
				print("Era Phising. Acertaste");
			}
		}
		else
		{
			if (messageAux.phising == false)
			{
				if (pos.x > 0)
				{
					print("No era Phising. Acertaste");
					P[currentCharacter].performanceHistory.Add(1);
				}
				else
				{
					print("No era Phising. Fallaste");
					P[currentCharacter].performanceHistory.Add(0);
				}
			}
		}
		ft_chooseCharacter();
		ft_fillCharacterInfo();
		ft_fillMessageAndBusiness();
	}
}
