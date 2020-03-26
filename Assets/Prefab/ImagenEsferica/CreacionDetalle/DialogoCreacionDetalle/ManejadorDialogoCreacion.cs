using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ManejadorDialogoCreacion : MonoBehaviour
{
    public Image Agua;
    public Image Luz;
    public Image Gas;
    public Image Mantenimiento;
    public Image Parabolica;

    public Image ImagenSeleccionada;
    private Sprite spriteSeleccionado;

    private void Start() {
        poneEscuchadores();
    }

    private void poneEscuchadores(){

        Agua.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            spriteSeleccionado = Agua.GetComponent<Image>().sprite;
            ImagenSeleccionada.GetComponent<Image>().sprite = spriteSeleccionado;
        });

        Luz.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            spriteSeleccionado = Luz.GetComponent<Image>().sprite;
            ImagenSeleccionada.GetComponent<Image>().sprite = spriteSeleccionado;
        });

        Gas.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            spriteSeleccionado = Gas.GetComponent<Image>().sprite;
            ImagenSeleccionada.GetComponent<Image>().sprite = spriteSeleccionado;
        });

        Mantenimiento.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            spriteSeleccionado = Mantenimiento.GetComponent<Image>().sprite;
            ImagenSeleccionada.GetComponent<Image>().sprite = spriteSeleccionado;
        });

        Parabolica.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            spriteSeleccionado = Parabolica.GetComponent<Image>().sprite;
            ImagenSeleccionada.GetComponent<Image>().sprite = spriteSeleccionado;
        });


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake() {
        
    }

   
}
