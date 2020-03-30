using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PonerNuevoMarcador : MonoBehaviour
{
    
    public Canvas dialogo;

    void Update()
    {
        manejarConTouch();
    }
    
    private Vector3 puntoDeInicio;
    private const byte numeroToquesMinimo = 0;
    private const byte numeroToquesMaximo = 2;
    private bool puedoPonerMarcador = false;

    private void manejarConTouch(){
        if( SelectorRol.RolSeleccionado !=  SelectorRol.Roles.Supervisor ){ 
            puedoPonerMarcador = false;
            return; 
        }

        if(Input.touchCount > numeroToquesMinimo && Input.touchCount < numeroToquesMaximo){

           if(Input.GetTouch(0).phase == TouchPhase.Began){
               puntoDeInicio = Input.GetTouch(0).position;
               puedoPonerMarcador = true;
               return;
           }

           if(Input.GetTouch(0).phase==TouchPhase.Moved){
               puedoPonerMarcador = false;
               return;
           }

           if(Input.GetTouch(0).phase==TouchPhase.Ended){
               if(puedoPonerMarcador){
                   seleccionarAccion();
               }
               return;
           }

        }

    }

    private void seleccionarAccion(){
        if(ManejadorDialogoCreacion.estoyMostrandome){ return; }
        if(verDetalleMarcador()){
            return;
        }
        ponerMarcador();
    }

    private bool verDetalleMarcador(){
        
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit hit;
        GameObject apuntadorSeleccionado = null ;

        if(Physics.Raycast(ray, out hit))
         {
            if (hit.collider != null) {       
                apuntadorSeleccionado = hit.transform.gameObject.transform.parent.gameObject;
                apuntadorSeleccionado.GetComponent<DetalleApuntadorDetalle>().mostrarDialogo();
            }
         }


        return apuntadorSeleccionado != null ;
    }

    private ArrayList listaMarcadores = new ArrayList(); 
    private void ponerMarcador(){
        
        puntoDeInicio.z = 20;
        puntoDeInicio = Camera.main.ScreenToWorldPoint(puntoDeInicio);
        Canvas dialogoCreador = Instantiate(dialogo,new Vector2 (0, 0), Quaternion.identity);
        dialogoCreador
            .GetComponent<ManejadorDialogoCreacion>()
            .conCoordenadas(puntoDeInicio)
            .conEscuchadorMarcadorCreado((GameObject marcadorCreado) => {
                listaMarcadores.Add(marcadorCreado);

                traerListaComentarios();
            });
        
    }

    public string traerListaComentarios(){
        Comentario[] listaComentarios = new Comentario[listaMarcadores.Count];
        int contador = 0;
        foreach(GameObject marcador in listaMarcadores){
            Comentario comentario = marcador.GetComponent<DetalleApuntadorDetalle>().getComentario();
            listaComentarios[contador] = comentario;
            contador++;
        }

        Debug.Log("Lista comentarios "+listaComentarios.convertirAJSON());
        return "";
    }
    
}
