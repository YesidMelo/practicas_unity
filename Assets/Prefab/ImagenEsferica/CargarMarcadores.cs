using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarMarcadores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        cargarListaComentarios(Mocks.arregloMarcadores);
    }

    public void cargarListaComentarios(string jsonComentarios){
        Comentario [] comentarios= jsonComentarios.convertirAArreglosObjetos<Comentario>();
        Debug.Log("Numero de comentarios "+comentarios.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
