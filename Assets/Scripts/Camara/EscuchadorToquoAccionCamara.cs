using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscuchadorToquoAccionCamara : MonoBehaviour
{

    public Camera camera;
   
    void Update()
    {
        if(escuchadorToqueCursor()){ return ;}
        if(escuchadorToquePantalla()) { return; }
    }

    private bool escuchadorToqueCursor(){

        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Click mouse izquierdo ");
            inicializaElementosDePosicion();
            //verificaPosisionMouse();
            return true;
        }

        if(Input.GetMouseButtonDown(1)){
            //Debug.Log("Click mouse derecho");
            return true;
        }

        if(Input.GetMouseButtonDown(2)){
            //Debug.Log("Click mouse centro");
            return true;
        }

        return false;
    }
    Vector3 worldPosition;

    private void inicializaElementosDePosicion(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;

        if(Physics.Raycast(ray, out hitData, 1000))
        {
            worldPosition = hitData.point;
            Debug.Log("Posicion en el mundo");
        }

    }
    private void verificaPosisionMouse(){
        Debug.Log("Entro a verificar posicion mouse");
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit,1000))
        {
            /*
            Convert the position of the game tile found on the Main Camera to a 
            screen space position on the Screen Camera
            */
            Debug.Log("Hola no mas");
        }
    }

    private bool escuchadorToquePantalla(){
        if(Input.touchCount > 0){
            Touch toque = Input.GetTouch(0);
            Debug.Log("Toque la pantalla");
            return true;
        }
        return false;
    }

    

}