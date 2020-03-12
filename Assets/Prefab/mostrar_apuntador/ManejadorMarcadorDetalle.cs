using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorMarcadorDetalle : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        capturarElementosDeVista();
    }

    public GameObject icono;
    private void capturarElementosDeVista(){
        
        icono = GameObject.Find(name+"/icono");
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

        GameObject dialogoMostrado = Instantiate(dialogo, new Vector3(0f,0f,0f),Quaternion.identity);
        
        LogicaMostrarDetalleComentario.mostrandoDialogoDetalleIndicador = true;

        if(comentario == null ){ return ;}
        LogicaMostrarDetalleComentario logicaDialogo = (dialogoMostrado.GetComponent("LogicaMostrarDetalleComentario") as LogicaMostrarDetalleComentario);

        logicaDialogo
            .conMensaje(comentario.mensaje)
            .conTitulo(comentario.titulo)
            .ActualizarContenido();

    }

    private Comentario comentario ;
    public ManejadorMarcadorDetalle conComentario(Comentario comentario) {
        this.comentario  = comentario;
        return this;
    }

    public void actualizarVista() {
        if(comentario == null ){ return ;}
        actualizarPocision();
        actualizarIcono();
    }

    private void actualizarPocision(){
        GameObject.Find(name).transform.position = new Vector3(comentario.coordenadas.x,comentario.coordenadas.y,comentario.coordenadas.z);
    }

    private void actualizarIcono(){
        icono.GetComponent<Renderer>().material.mainTexture = comentario.icono.convertirATexture2D();
    }

}
