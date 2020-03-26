using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ManejadorClickIcono : MonoBehaviour,IPointerClickHandler
{

    private Delegados.escuchadorString escuchador;
    public ManejadorClickIcono conEscuchador(Delegados.escuchadorString escuchador){
        this.escuchador = escuchador;
        return this;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        escuchador(name);
    }
}
