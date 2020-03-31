using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetalleApuntadorDetalle : MonoBehaviour
{

    public GameObject icono;
    public Canvas DialogoCreacion;
    


    private Comentario comentario;
    public DetalleApuntadorDetalle conDetalleApuntador(Comentario comentario){
        this.comentario = comentario;
        return this;
    }

    public void actualizarMarcador(){
        if(comentario == null ){ return; }
        actualizarIcono();
        actualizarPocicion();
    }

    private void actualizarIcono(){
        Texture2D textura = SelectorImagenes.getInstancia().buscarTexturaConID(comentario.icono);
        icono.GetComponent<Renderer>().material.mainTexture = textura;
    }

    private void actualizarPocicion(){
        transform.position = new Vector3(comentario.coordenadas.x,comentario.coordenadas.y,comentario.coordenadas.z);
    }

    public void mostrarDialogo(){
        Canvas dialogoCreador = Instantiate(DialogoCreacion,new Vector2 (0, 0), Quaternion.identity);

        dialogoCreador
            .GetComponent<ManejadorDialogoCreacion>()
            .conComentario(comentario)
            .conEscuchadorComentario((Comentario comentario) =>{
                this.comentario = comentario;
                actualizarMarcador();
                })
            .actualizaVista();
    }

    public Comentario getComentario(){
        return comentario;
    }
}
