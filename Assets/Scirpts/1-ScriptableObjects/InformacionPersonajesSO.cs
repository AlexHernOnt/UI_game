using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Informacion Personajes", fileName = "InformacionPersonajesSO")]
public class InformacionPersonajesSO : ScriptableObject
{   
	public Sprite		imagenDePerfil;
	public string		nombreDelPersonaje = "Nombre del personaje";
	public string		estadoCivil = "Estado civil e hijos";
	public string		entidadBancoria = "Banco y numero (*1234)";
	public string		gustosPersonaje = "Entre 2 y 3 gustos con una palabra";
	
	public List<int>					performanceHistory = new List<int>();

}
