using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectorImagenes : MonoBehaviour
{

    private static SelectorImagenes instancia;

    public static SelectorImagenes getInstancia(){
        return instancia;
    }

    private void Start() {
        if(instancia == null){
            instancia = this;
        }
        
    }

    public Sprite Agua; // 1
    public Sprite Luz; // 2
    public Sprite Gas; // 3
    public Sprite Mantenimiento; // 4
    public Sprite Parabolica; // 5


    public Texture2D buscarTexturaConID(string id){
        
        
        Texture2D textura = null;
        switch (id)
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
        return textura;
    }

     public Sprite buscarSpriteConID(string id){
        
        switch (id)
        {
            case "2":
                 return Luz;
            case "3":
                 return Gas;
            case "4":
                 return Mantenimiento;
            case "5":
                 return Parabolica;
            case "1":
            default:
                return Agua;
            
        }
        
    }

    
    
}
