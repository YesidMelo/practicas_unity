using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionesString {

    public static Texture2D convertirATexture2D(this string imagenBase64){
        

        byte [] arregloBits = System.Convert.FromBase64String(imagenBase64);
        

        Texture2D textura = new Texture2D(1,1);
        textura.LoadImage(arregloBits);

        return textura;
    }

    public static T convertirAObjeto<T>(this string json) where T : ModeloBase {
        T objetoFinal = JsonUtility.FromJson<T>(json);
        return objetoFinal;
    }

    public static string convertirAFloat(this string numero) {
        return "";
    }

}