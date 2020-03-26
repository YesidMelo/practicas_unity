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

    private void Start() {
        poneEscuchadores();
    }

    private void poneEscuchadores(){

        Agua.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ Debug.Log(nombre); });
        Luz.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ Debug.Log(nombre); });
        Gas.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ Debug.Log(nombre); });
        Mantenimiento.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ Debug.Log(nombre); });
        Parabolica.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ Debug.Log(nombre); });
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake() {
        
    }

   
}
