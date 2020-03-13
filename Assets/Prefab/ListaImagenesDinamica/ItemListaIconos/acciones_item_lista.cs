using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class acciones_item_lista : MonoBehaviour
{

    public RawImage icono;
    public Button boton;
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
    }

    private void ponerEscuchadores(){
        boton.onClick.AddListener(()=>{ Debug.Log("He clicado el boton"); });
    }

    
}
