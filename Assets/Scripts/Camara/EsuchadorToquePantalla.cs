using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsuchadorToquePantalla : MonoBehaviour
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
            
            return true;
        }

        if(Input.GetMouseButtonDown(1)){
            Debug.Log("Click mouse derecho");
            return true;
        }

        if(Input.GetMouseButtonDown(2)){
            Debug.Log("Click mouse centro");
            return true;
        }

        return false;
    }


    private void crearMarcador(float x = 5.5f,float y = 5.5f){
        CrearMarcador apuntador = new CrearMarcador();

        apuntador.posicionX(x)
        .posicionY(y)
        .escuchadorObjetoCreado(ponerObjetoEnEscenario)
        .crearGameobject();
        
    }

    public void ponerObjetoEnEscenario(GameObject objeto){

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
