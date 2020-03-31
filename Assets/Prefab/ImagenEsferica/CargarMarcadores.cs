using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarMarcadores : MonoBehaviour
{

    public static ArrayList listaMarcadores = new ArrayList();
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

            listaMarcadores.Add(nuevoApuntador);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string traerListaComentarios(){
        Comentario[] listaComentarios = new Comentario[CargarMarcadores.listaMarcadores.Count];
        int contador = 0;
        foreach(GameObject marcador in CargarMarcadores.listaMarcadores){
            Comentario comentario = marcador.GetComponent<DetalleApuntadorDetalle>().getComentario();
            listaComentarios[contador] = comentario;
            contador++;
        }
        return listaComentarios.convertirAJSON();
    }
}
