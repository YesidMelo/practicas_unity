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

    public static void tipoEntrada(this Input entrada,Delegados.escuchadorInput respuesta){
        if(Input.GetMouseButtonDown(0)){
            respuesta(Entrada.CLICK_IZQUIERDO_MOUSE);
            return ;
        }

        if(Input.GetMouseButtonDown(1)){
            respuesta(Entrada.CLICK_DERECHO_MOUSE);
            return ;
        }

        if(Input.GetMouseButtonDown(2)){
            respuesta(Entrada.CLICK_CENTRAL_MOUSE);
            return ;
        }

    }
}