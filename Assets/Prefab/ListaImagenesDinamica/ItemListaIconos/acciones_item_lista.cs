using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class acciones_item_lista : MonoBehaviour
{

    public RawImage icono;
    public Button boton;
    public Text textoBoton;
    void Start()
    {
        
        ponerEscuchadores();   
    }

    void Update()
    {
        llenarVista(); 
    }

    private void llenarVista(){
        icono.texture = Mocks.icono.convertirATexture2D();
        textoBoton.text = "Item";
    }

    private void ponerEscuchadores(){
        boton.onClick.AddListener(()=>{ 
            Debug.Log("He clicado el boton"); 
            if(detalle == null ){ return; }
            itemSeleccionado(detalle);
        });
    }

    private DetalleIcono detalle;
    public acciones_item_lista conDetalleIcono(DetalleIcono detalle){
        this.detalle = detalle;
        return this;
    }

    private Delegados.escuchadorItemSeleccionado<DetalleIcono> itemSeleccionado;
    public acciones_item_lista conEscuchadorItemSeleccionado(Delegados.escuchadorItemSeleccionado<DetalleIcono> itemSeleccionado){
        this.itemSeleccionado = itemSeleccionado;
        return this;
    }

    public void actualizarDetalleIcono(){
        if(detalle == null ){ return; }
        icono.texture = detalle.icono.convertirATexture2D();
        textoBoton.text = detalle.nombre;
    }

    
}
