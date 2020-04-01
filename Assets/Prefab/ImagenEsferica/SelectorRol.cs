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

    public static Roles RolSeleccionado = Roles.Supervisor; 

    void Start()
    {
        if(instancia == null ){
            instancia = this;
        }
    }

    public void conRol(string rol){
        switch (rol)
        {
            case "1":
                RolSeleccionado = Roles.Supervisor;
                break;
            case "2":
            default:
                RolSeleccionado = Roles.operario;
            break;
        }
    }

    
}
