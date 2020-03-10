using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebasConcepto : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    void Start()
    {
        //crearListaComentarios();
    }

    private void cargarMarcador(){
        string marcador = Mocks.Marcador;
        Comentario comentario = marcador.convertirAObjeto<Comentario>();
        CargarMarcador carga = new CargarMarcador();

        carga
            .conComentario(comentario)
            .conEscuchadorGameObjectGenerado(objetoGenerado => { })
            .cargarMarcador()
            ;

        Debug.Log(comentario.coordenadas.x);

    }

    private void crearListaComentarios(){
        ContenedorListaComentarios lista = Mocks.ListaMarcadores.convertirAObjeto<ContenedorListaComentarios>();
        ManejadorMarcadores manejador = new ManejadorMarcadores();

        manejador
            .conListaMarcadores(lista.ListaComentarios)
            .conPrefabricado(prefab)
            .cargarListaComentarios()
            ;

        Debug.Log(lista.ListaComentarios.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
