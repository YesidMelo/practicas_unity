using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ManejadorIndicador : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        capturarElementosDeVista();
    }



    private void capturarElementosDeVista(){
        
        GameObject icono = GameObject.Find(name+"/icono");
        Debug.Log("Nombre : "+name+"/"+icono.name);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            verificaObjetoTocado();
            return ;
        }

        if(Input.GetMouseButtonDown(1)){
            return ;
        }

        if(Input.GetMouseButtonDown(2)){
            return ;
        }

    }

    private void verificaObjetoTocado(){

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(!Physics.Raycast(ray,out hit,100.0f)){ return ; }
        if(hit.transform == null ) return;

        mostrarDialogo();
        Debug.Log("Nombre padre : "+hit.transform.parent.gameObject.name);
        //Debug.Log(hit.transform.gameObject.name);

    }

    

    public GameObject dialogo;
    private void mostrarDialogo(){
        if(LogicaMostrarDetalleComentario.mostrandoDialogoDetalleIndicador){ return ;}

        Instantiate(dialogo, new Vector3(0f,0f,0f),Quaternion.identity);
        LogicaMostrarDetalleComentario.mostrandoDialogoDetalleIndicador = true;
    }
}
