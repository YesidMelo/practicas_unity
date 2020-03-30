using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorRol : MonoBehaviour
{

    private static SelectorRol instancia;
    public static SelectorRol getInstancia(){
        return instancia;
    }

    public enum Roles {
        Supervisor = 1,
        operario = 2,
    }

    public static Roles RolSeleccionado = Roles.operario; 

    void Start()
    {
        if(instancia == null ){
            instancia = this;
        }
    }

    
}
