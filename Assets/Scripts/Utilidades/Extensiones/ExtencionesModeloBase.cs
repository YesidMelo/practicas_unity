using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtencionesModeloBase{

    public static string convertirAJSON<T>(this T  objeto) where T : ModeloBase{
        return JsonUtility.ToJson(objeto);
    }

}