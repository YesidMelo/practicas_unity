using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebasConcepto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string marcador = Mocks.Marcador;
        Comentario comentario = marcador.convertirAObjeto<Comentario>();
        Debug.Log(comentario.coordenadas.x);

        ContenedorListaComentarios lista = Mocks.ListaMarcadores.convertirAObjeto<ContenedorListaComentarios>();
        Debug.Log(lista.ListaComentarios.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
