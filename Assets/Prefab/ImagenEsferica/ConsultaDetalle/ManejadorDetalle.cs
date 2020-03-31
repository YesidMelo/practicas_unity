using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManejadorDetalle : MonoBehaviour
{

    public static bool estoyMostrandome = false;
    public Button botonCerrar;
    public Text Detalle;
    public Image imgenSeleccionada;
    
    private void Start() {
        botonCerrar.onClick.AddListener(()=>{ 
            destruirme();
         });
    }

    private Comentario comentario;
    public ManejadorDetalle conComentario(Comentario comentario){
        this.comentario = comentario;
        return this;
    }

    public void actualizarVista(){
        Debug.Log("Mostrar elementos");
        if(this.comentario == null ){ return ; }
        ponerIcono();
        ponerTexto();
        estoyMostrandome = true;
    }

    private void ponerIcono(){
        imgenSeleccionada.sprite = SelectorImagenes.getInstancia().buscarSpriteConID(comentario.icono);
    }

    private void ponerTexto(){
        Detalle.text =  comentario.mensaje;
    }

    private void OnDestroy() {
        estoyMostrandome = false;
    }

    
    private void destruirme(){
        GameObject dialogoAEliminar = GameObject.Find(name); 
        Destroy(dialogoAEliminar);
    }
}
