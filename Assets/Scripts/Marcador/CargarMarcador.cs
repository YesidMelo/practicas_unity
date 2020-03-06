using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarMarcador {


    private  Comentario comentario;
    public CargarMarcador conComentario(Comentario comentario){
        this.comentario = comentario;
        return this;
    }

    private Delgados.pasarGameObject escuchadorDeGameObjects;
    public CargarMarcador conEscuchadorGameObjectGenerado(Delgados.pasarGameObject escuchadorDeGameObjects){
        this.escuchadorDeGameObjects = escuchadorDeGameObjects;
        return this;
    }

    public void cargarMarcador(){
        GameObject Quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
        Quad.GetComponent<Renderer>().material.mainTexture = comentario.icono.convertirATexture2D();
        Quad.transform.position = new Vector3(comentario.coordenadas.x,comentario.coordenadas.y,comentario.coordenadas.z);
    }
}
