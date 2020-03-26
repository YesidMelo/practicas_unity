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
    private void manejarConTouch(){
        if(Input.touchCount > 0){

           if(Input.GetTouch(0).phase == TouchPhase.Began){
               puntoDeInicio = Input.GetTouch(0).position;
               Debug.Log("Punto Inicial:"+puntoDeInicio);
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

    


    private void ponerEscuchadores(){
        /*
        mirarArriba.onClick.AddListener(()=>{ 
            Camera.main.transform.Rotate(-velocidadRotacion*Time.deltaTime,0f,0f);
         });

        mirarAbajo.onClick.AddListener(()=>{ 
            Camera.main.transform.Rotate(velocidadRotacion*Time.deltaTime,0f,0f);
         });

        mirarIzquierda.onClick.AddListener(()=>{ 
            ContenedorCamara.transform.Rotate(0f,-velocidadRotacion*Time.deltaTime,0f);
         });

        mirarDerecha.onClick.AddListener(()=>{ 
            ContenedorCamara.transform.Rotate(0f,velocidadRotacion*Time.deltaTime,0f);
         });
         */
    }

    
    
}
