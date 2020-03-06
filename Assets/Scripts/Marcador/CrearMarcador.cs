using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  CrearMarcador {

    private float posisionX ;
    public CrearMarcador posicionX(float X = 0.0f){
        posisionX = X;
        return this;
    }

    private float posisionY ;
    public CrearMarcador posicionY(float Y = 0.0f){
        posisionY = Y;
        return this;
    }

    private Delgados.pasarGameObject escuchador;
    public CrearMarcador escuchadorObjetoCreado(Delgados.pasarGameObject esc){
        escuchador = esc;
        return this;
    }

    public void crearGameobject(){
        GameObject objeto = GameObject.CreatePrimitive(PrimitiveType.Quad);
        objeto.transform.position = new Vector3(posisionX,posisionY,5);
        escuchador(objeto);

    }

}
