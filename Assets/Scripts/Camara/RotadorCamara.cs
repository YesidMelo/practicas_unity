using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotadorCamara : MonoBehaviour
{
    
    public Camera camera;
    // Update is called once per frame
    void Update()
    {
        rotarConTeclado();
    }

    private void rotarConTeclado(){
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            camera.transform.Rotate(01.0f,0.0f,0.0f,Space.World);
            return;
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            camera.transform.Rotate(0.0f,-01.0f,0.0f,Space.World);
            return;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            camera.transform.Rotate(0.0f,01.0f,0.0f,Space.World);
            return;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            camera.transform.Rotate(-01.0f,0.0f,0.0f,Space.World);
            return;
        }
    }

    
}
