using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class ExtencionesArrayList{
    
    public static string convertirAJSON<T>(this T[] lista) where T : ModeloBase{

        Debug.Log("Tamanio de la lista: "+lista.Length);
        string jsonFinal = "[";
        foreach (T item in lista)
        {
            jsonFinal+=  JsonUtility.ToJson(item)+",";
        }
        jsonFinal = jsonFinal.Remove(jsonFinal.Length - 1 );
        jsonFinal+="]";
        Debug.Log("Json: "+jsonFinal);

        return "";
    }


}