using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebasConcepto : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject apuntador;
    void Start()
    {
        //crearListaComentarios();
        //cargarMarcador();
    }

    private void cargarMarcador(){
        string marcador = Mocks.Marcador;
        Comentario comentario = marcador.convertirAObjeto<Comentario>();
        GameObject apun = Instantiate(apuntador,new Vector3(0f,0f,0f),Quaternion.identity);

        ManejadorMarcadorDetalle manejador = apun.GetComponent("ManejadorIndicador") as ManejadorMarcadorDetalle;
        manejador.conComentario(comentario).actualizarVista();

        Debug.Log(comentario.coordenadas.x);

    }

    private void crearListaComentarios(){
        /*
        ContenedorListaComentarios lista = Mocks.ListaMarcadores.convertirAObjeto<ContenedorListaComentarios>();
        ManejadorMarcadores manejador = new ManejadorMarcadores();

        manejador
            .conListaMarcadores(lista.ListaComentarios)
            .conPrefabricado(apuntador)
            .cargarListaComentarios()
            ;

        Debug.Log(lista.ListaComentarios.Length);
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
