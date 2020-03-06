using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebasConcepto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        cargarMarcador();
    }

    private void cargarMarcador(){
        string marcador = Mocks.Marcador;
        Comentario comentario = marcador.convertirAObjeto<Comentario>();
        CargarMarcador carga = new CargarMarcador();

        carga
            .conComentario(comentario)
            .conEscuchadorGameObjectGenerado(marcadorGenerado)
            .cargarMarcador()
            ;

        Debug.Log(comentario.coordenadas.x);

    }

    private void marcadorGenerado(GameObject objeto){

    }

    private void crearListaComentarios(){
        ContenedorListaComentarios lista = Mocks.ListaMarcadores.convertirAObjeto<ContenedorListaComentarios>();
        Debug.Log(lista.ListaComentarios.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
