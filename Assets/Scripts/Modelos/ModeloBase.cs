using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable] public class ModeloBase{

    public string aJson(){
        return JsonUtility.ToJson(this);
    }
}