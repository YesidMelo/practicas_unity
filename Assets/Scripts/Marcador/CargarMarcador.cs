using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarMarcador {
    
    private GameObject prefab;
    public CargarMarcador conPrefab(GameObject prefab){
        this.prefab = prefab;
        return this;
    }
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

    public Delgados.pasarComentario escuchadorComentario;
    public CargarMarcador conEscuchadorComentarioSeleccionado(Delgados.pasarComentario escuchadorComentario){
        this.escuchadorComentario = escuchadorComentario;
        return this;
    }

    public void cargarMarcador(){
        GameObject Quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
        Quad.GetComponent<Renderer>().material.mainTexture = comentario.icono.convertirATexture2D();
        Quad.transform.position = new Vector3(comentario.coordenadas.x,comentario.coordenadas.y,comentario.coordenadas.z);
    }
}
