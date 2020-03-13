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
        actualizarTamanioDeLista();
    }

    private float posicionY = 0;
    private float posicionX = 0;
    private void cargarListaIconos(){
        int numeroItemsMock = 10;
        RectTransform listt = Lista.transform as RectTransform;
        posicionX = listt.rect.width;

        for(int contador = 0; contador < numeroItemsMock ; contador ++ ){
            RectTransform objectTransform = crearItemListaIcono(posicionX,posicionY).transform as RectTransform ;
            posicionY -= objectTransform.rect.height;
        }
        Debug.Log("Alto final "+posicionY);
    }

    private GameObject crearItemListaIcono(float posicionX = 0f,float posicionY = 0f) {
        GameObject item = Instantiate(itemLista,new Vector3(0f,posicionY,0f),Quaternion.identity);
        item.transform.SetParent(Lista.transform,false);
        return item;
    }

    private void actualizarTamanioDeLista(){
        //Lista.transform.sizeDelta = new Vector2(posicionX,posicionY);
        var rectTransform = Lista.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(0f, 0f);
    }

}
