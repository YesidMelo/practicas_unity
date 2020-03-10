using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarDetalle : MonoBehaviour
{
    
    
    void Start()
    {
        buscarElementosVista();
    }

    private GameObject icono;
    private void buscarElementosVista(){
        Debug.Log("Nombre : "+name);
        icono = GameObject.Find(name+"/icono");
    }

    private Comentario comentario;
    public CargarDetalle conMarcador(Comentario comentario) {
        this.comentario = comentario;
        return this;
    }

    public void actualizarVista(){
        transform.position = new Vector3(comentario.coordenadas.x,comentario.coordenadas.y,comentario.coordenadas.z);
    }

    public Comentario traerComentario(){
        return comentario;
    }
}
