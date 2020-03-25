using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManejadorNavegacion : MonoBehaviour
{
    
    public GameObject ContenedorCamara;
    public GameObject Camara;
    public Button mirarArriba;
    public Button mirarAbajo;
    public Button mirarIzquierda;
    public Button mirarDerecha;

    private const float velocidadRotacion = 1f;

    private void ponerEscuchadores(){
        mirarArriba.onClick.AddListener(()=>{ 
            Camara.transform.Rotate(-velocidadRotacion*Time.deltaTime,0f,0f);
         });

        mirarAbajo.onClick.AddListener(()=>{ 
            Camara.transform.Rotate(velocidadRotacion*Time.deltaTime,0f,0f);
         });

        mirarIzquierda.onClick.AddListener(()=>{ 
            ContenedorCamara.transform.Rotate(0f,-velocidadRotacion*Time.deltaTime,0f);
         });

        mirarDerecha.onClick.AddListener(()=>{ 
            ContenedorCamara.transform.Rotate(0f,velocidadRotacion*Time.deltaTime,0f);
         });
    }

    // Update is called once per frame
    void Update()
    {
        ponerEscuchadores();
    }

    
}
