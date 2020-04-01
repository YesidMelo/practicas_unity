using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManejadorImagenShader : MonoBehaviour
{
    Shader imagenEsferica;
    Renderer render;
    public Texture imagenFondo;
    private string imagenBase64;

    void Start()
    {
        render = GetComponent<Renderer>();    
        actualizaVista();
    }


    private void conImagen(string imagenBase64){
        this.imagenBase64 = imagenBase64;
    }

    public void actualizaVista(){
        if(imagenBase64 == null){
            render.material.SetTexture("_MainTex",imagenFondo);
            return;
        }
        
        render.material.SetTexture("_MainTex",imagenBase64.convertirATexture2D());

    }


        
}
