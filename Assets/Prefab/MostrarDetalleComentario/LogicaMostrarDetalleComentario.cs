using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaMostrarDetalleComentario : MonoBehaviour
{
    

    // Start is called before the first frame update
    public static bool mostrandoDialogoDetalleIndicador = false;

    public RawImage fondo_detalle_comentario;
    public Text contenedor_texto;
    public Button Cerrar;

    public GameObject ScrollArea;

    public GameObject ContenedorPrincipal;

    


     void Start(){
         conEscuchadores();
     }

     private void conEscuchadores(){
         Cerrar.onClick.AddListener(cerrarVentana);
     }

     private void cerrarVentana(){
             Destroy(ContenedorPrincipal);
             mostrandoDialogoDetalleIndicador = false;             
     }

     private string titulo;
     public LogicaMostrarDetalleComentario conTitulo(string titulo){
         this.titulo = titulo;
         return this;
     }
     private string mensaje;
    public LogicaMostrarDetalleComentario conMensaje(string mensaje){
        this.mensaje = mensaje;
        return this;
    }

    public void ActualizarContenido(){
        contenedor_texto.text = mensaje;
    }


}
