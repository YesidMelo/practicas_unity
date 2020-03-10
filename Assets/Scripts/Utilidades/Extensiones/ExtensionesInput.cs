using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionesInput {
    public enum Entrada{
        CLICK_IZQUIERDO_MOUSE,
        CLICK_DERECHO_MOUSE,
        CLICK_CENTRAL_MOUSE,
        TOQUE_PANTALLA_CELULAR
    }

    public static void tipoEntrada(this Input entrada,Delgados.escuchadorInput respuesta){
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Click mouse izquierdo ");
            respuesta(Entrada.CLICK_IZQUIERDO_MOUSE);
            return ;
        }

        if(Input.GetMouseButtonDown(1)){
            Debug.Log("Click mouse derecho");
            respuesta(Entrada.CLICK_DERECHO_MOUSE);
            return ;
        }

        if(Input.GetMouseButtonDown(2)){
            Debug.Log("Click mouse centro");
            respuesta(Entrada.CLICK_CENTRAL_MOUSE);
            return ;
        }

    }
}