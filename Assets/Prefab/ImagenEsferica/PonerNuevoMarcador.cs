﻿using System.Collections;
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
                   ponerMarcador();
               }
               return;
           }

        }

    }

     private void ponerMarcador(){
        if(ManejadorDialogoCreacion.estoyMostrandome){ return; }

        puntoDeInicio.z = 20;
        puntoDeInicio = Camera.main.ScreenToWorldPoint(puntoDeInicio);
        Canvas dialogoCreador = Instantiate(dialogo,new Vector2 (0, 0), Quaternion.identity);
        dialogoCreador.GetComponent<ManejadorDialogoCreacion>().conCoordenadas(puntoDeInicio);
        /*
        Ray ray = new Ray(puntoDeInicio, Vector3.down);
        RaycastHit hit;*/
        //Debug.Log(pos);

        //Instantiate(marcador,puntoDeInicio,Quaternion.identity);
        
        /*
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = puntoDeInicio;
        cube.transform.LookAt(Camera.main.transform);
        */
        
    }
    
}
