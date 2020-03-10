using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorMarcadores 
{
    
    private Comentario [] ListaComentarios;
    public ManejadorMarcadores conListaMarcadores( Comentario [] ListaComentarios ){
        this.ListaComentarios = ListaComentarios;
        return this;
    }

    private GameObject prefab;
    public ManejadorMarcadores conPrefabricado(GameObject prefab){
        this.prefab = prefab;
        return this;
    }

    public void cargarListaComentarios(){
        
        if(ListaComentarios == null ){ return; }
        if(ListaComentarios.Length == 0 ){ return; }

        CargarMarcador carga = new CargarMarcador();
        carga
            .conPrefab(prefab)
            .conComentario(ListaComentarios[0])
            .conEscuchadorGameObjectGenerado(objeto => { })
            .conEscuchadorComentarioSeleccionado(comentario => {})
            .cargarMarcador()
            ;
    }


}
