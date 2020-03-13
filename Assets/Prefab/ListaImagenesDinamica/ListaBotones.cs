using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ListaBotones : MonoBehaviour
{
    public GameObject Lista;
    public GameObject itemLista;

    // Start is called before the first frame update
    void Start()
    {
        cargarListaIconos();
    }

    private void cargarListaIconos(){
        int numeroItemsMock = 3;
        float posicionX = 0;
        float posicionY = 0;

        for(int contador = 0; contador < numeroItemsMock ; contador ++ ){
            RectTransform objectTransform = crearItemListaIcono(posicionX,posicionY).transform as RectTransform ;
            posicionY -= objectTransform.rect.height;
        }
        Debug.Log("Alto final "+posicionY);
    }

    private GameObject crearItemListaIcono(float posicionX = 0f,float posicionY = 0f) {
        GameObject item = Instantiate(itemLista,new Vector3(posicionX,posicionY,0f),Quaternion.identity);
        item.transform.SetParent(Lista.transform,false);
        return item;
    }

}
