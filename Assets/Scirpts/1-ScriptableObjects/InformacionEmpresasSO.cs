using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Informacion Empresa", fileName = "InformacionEmpresasSO")]
public class InformacionEmpresasSO : ScriptableObject
{   
    public Sprite imagenDePerfilEmpresa;
    public string nombreDeLaEmpresa = "Nombre de la empresa";
    public string contactoEmpresa = "mail, tlfo, fax...";
    public string reclamoEmpresa = "Qué ofrece esa empresa";
    public string urlsEmpresa = "Dominios web de la emrpesa";
}
