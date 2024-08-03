using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Informacion Mensajes", fileName = "InformacionMensajesSO")]
public class InformacionMensajesSO : ScriptableObject
{
    public bool phising;
    public Sprite imagenDePerfilEmpresa;
    public string emisorDelMensajes = "Nombre de la empresa";
    public string contenidoMensajes = "Contenido del mensaje";
    public bool tieneLink;
    public string linkDelMensaje = "url del link de la empresa";
    public bool tieneDocumento;
    public Sprite documentoDelMensaje;    
}
