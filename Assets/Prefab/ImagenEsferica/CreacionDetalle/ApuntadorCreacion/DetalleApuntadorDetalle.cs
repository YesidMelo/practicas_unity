using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetalleApuntadorDetalle : MonoBehaviour
{

    public GameObject icono;
    public Canvas DialogoCreacion;
    public Canvas DialogoMostrarDetalle;
    


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

        if( SelectorRol.RolSeleccionado ==  SelectorRol.Roles.Supervisor ){
            mostrarDialogoEdicion();
            return ;
        }

        if(SelectorRol.RolSeleccionado ==  SelectorRol.Roles.operario ){
            mostrarDialogoDetalle();
            return;
        }
        
    }

    private void mostrarDialogoEdicion(){
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

    private void mostrarDialogoDetalle(){
         Canvas dialogoDetalle = Instantiate(DialogoMostrarDetalle,new Vector2 (0, 0), Quaternion.identity);

        dialogoDetalle
            .GetComponent<ManejadorDetalle>()
            .conComentario(comentario)
            .actualizarVista();
    }

    public Comentario getComentario(){
        return comentario;
    }
}
