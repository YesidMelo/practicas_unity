using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarDetalle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         manejarConTouch();
    }

    private Vector3 puntoDeInicio;
    private const byte numeroToquesMinimo = 0;
    private const byte numeroToquesMaximo = 2;
    private bool puedoMostrarDetalle = false;

    private void manejarConTouch(){
         if( SelectorRol.RolSeleccionado !=  SelectorRol.Roles.operario ){ 
            puedoMostrarDetalle = false;
            return; 
        }

        if(Input.touchCount > numeroToquesMinimo && Input.touchCount < numeroToquesMaximo){

           if(Input.GetTouch(0).phase == TouchPhase.Began){
               puntoDeInicio = Input.GetTouch(0).position;
               puedoMostrarDetalle = true;
               return;
           }

           if(Input.GetTouch(0).phase==TouchPhase.Moved){
               puedoMostrarDetalle = false;
               return;
           }

           if(Input.GetTouch(0).phase==TouchPhase.Ended){
               if(puedoMostrarDetalle){
                   seleccionarAccion();
               }
               return;
           }

        }
    }

     private void seleccionarAccion(){
        if(ManejadorDetalle.estoyMostrandome){ return; }
        if(verDetalleMarcador()){
            return;
        }
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



}
