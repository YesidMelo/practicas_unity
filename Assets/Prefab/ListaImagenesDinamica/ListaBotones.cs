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
        GameObject item = Instantiate(itemLista,new Vector3(0f,0f,0f),Quaternion.identity);
        item.transform.SetParent(Lista.transform,false);
        
    }

}
