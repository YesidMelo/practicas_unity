using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ManejadorNavegacion : MonoBehaviour
{
    

    public GameObject ContenedorCamara;
    private const float factorMultiplicacion = 5f;
    private const float velocidadRotacion = 10f * factorMultiplicacion;

    

    // Update is called once per frame
    void Update()
    {
        manejarConTouch();
    }

    private Vector3 puntoDeInicio;
    private Vector3 puntoFinal;
    private const byte numeroToquesMinimo = 0;
    private const byte numeroToquesMaximo = 2;
    private void manejarConTouch(){
        if(ManejadorDialogoCreacion.estoyMostrandome || ManejadorDetalle.estoyMostrandome ){ return ; }
        if(Input.touchCount > numeroToquesMinimo && Input.touchCount < numeroToquesMaximo){

           if(Input.GetTouch(0).phase == TouchPhase.Began){
               puntoDeInicio = Input.GetTouch(0).position;
               return;
           }

           if(Input.GetTouch(0).phase==TouchPhase.Moved){
               puntoFinal = Input.GetTouch(0).position;
               Vector3 temporal = puntoFinal-puntoDeInicio;
               rotarCamaraVertical(temporal.y);
               rotarCamaraHorizontal(temporal.x);
               
              return; 
           }

        }
        
    }

    private void rotarCamaraVertical(float movimiento){
        if(movimiento == 0){ return; }

        if(movimiento < 0){
            Camera.main.transform.Rotate(velocidadRotacion*Time.deltaTime,0f,0f);
            return;
        }

        Camera.main.transform.Rotate(-velocidadRotacion*Time.deltaTime,0f,0f);
    }

    private void rotarCamaraHorizontal(float movimiento){
        if(movimiento == 0){ return; }

        if(movimiento < 0){
            ContenedorCamara.transform.Rotate(0f,-velocidadRotacion*Time.deltaTime,0f);
            return;
        }

        ContenedorCamara.transform.Rotate(0f,velocidadRotacion*Time.deltaTime,0f);
    }    
    
}
