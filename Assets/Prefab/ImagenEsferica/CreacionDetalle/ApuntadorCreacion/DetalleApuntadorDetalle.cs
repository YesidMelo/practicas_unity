using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetalleApuntadorDetalle : MonoBehaviour
{

    public Sprite Agua;
    public Sprite Luz;
    public Sprite Gas;
    public Sprite Mantenimiento;
    public Sprite Parabolica;
    public GameObject icono;
    


    private Comentario comentario;
    public DetalleApuntadorDetalle conDetalleApuntador(Comentario comentario){
        this.comentario = comentario;
        return this;
    }

    public void actualizarMarcador(){
        if(comentario == null ){ return; }
        Texture2D textura;
        switch (comentario.icono)
        {
            case "2":
                textura = Luz.convertirATextura2D();
                break;
            case "3":
                textura = Gas.convertirATextura2D();
                break;
            case "4":
                textura = Mantenimiento.convertirATextura2D();
                break;
            case "5":
                textura = Parabolica.convertirATextura2D();
                break;
            case "1":
            default:
            textura = Agua.convertirATextura2D();
            break;
        }
        icono.GetComponent<Renderer>().material.mainTexture = textura;
    }
}
