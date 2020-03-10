using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotadorHaciaCamara : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Coordenadas : x "+transform.position.x+" y : "+transform.position.y+" z : "+transform.position.z);    
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform);
    }
}
