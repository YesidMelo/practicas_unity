using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarMarcadores : MonoBehaviour
{

    public GameObject Apuntador;
    // Start is called before the first frame update
    void Start()
    {
        cargarListaComentarios(Mocks.arregloMarcadores);
    }

    public void cargarListaComentarios(string jsonComentarios){
        Comentario [] comentarios= jsonComentarios.convertirAArreglosObjetos<Comentario>();
        foreach (var comentario in comentarios)
        {
            GameObject nuevoApuntador = Instantiate(Apuntador,new Vector3(0,0,0),Quaternion.identity);   
            nuevoApuntador
                .GetComponent<DetalleApuntadorDetalle>()
                .conDetalleApuntador(comentario)
                .actualizarMarcador();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
