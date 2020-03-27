using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;


public class ManejadorDialogoCreacion : MonoBehaviour
{
    public static bool estoyMostrandome = false;

    public Image Agua; // 1
    public Image Luz; // 2
    public Image Gas; // 3
    public Image Mantenimiento; // 4
    public Image Parabolica; // 5

    public Image ImagenSeleccionada;
    private Sprite spriteSeleccionado;
    private string identificadorImagenSeleccionada = "1";

    public Button boton_aceptar;
    public Button boton_cancelar;
    public GameObject marcador;
    

    private void Start() {
        estoyMostrandome = true;
        poneEscuchadoresImagenes();
        poneEscuchadoresBotones();
    }

    private void poneEscuchadoresImagenes(){

        Agua.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            spriteSeleccionado = Agua.GetComponent<Image>().sprite;
            ImagenSeleccionada.GetComponent<Image>().sprite = spriteSeleccionado;
            identificadorImagenSeleccionada = "1";
        });

        Luz.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            spriteSeleccionado = Luz.GetComponent<Image>().sprite;
            ImagenSeleccionada.GetComponent<Image>().sprite = spriteSeleccionado;
            identificadorImagenSeleccionada = "2";
        });

        Gas.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            spriteSeleccionado = Gas.GetComponent<Image>().sprite;
            ImagenSeleccionada.GetComponent<Image>().sprite = spriteSeleccionado;
            identificadorImagenSeleccionada = "3";
        });

        Mantenimiento.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            spriteSeleccionado = Mantenimiento.GetComponent<Image>().sprite;
            ImagenSeleccionada.GetComponent<Image>().sprite = spriteSeleccionado;
            identificadorImagenSeleccionada = "4";
        });

        Parabolica.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            spriteSeleccionado = Parabolica.GetComponent<Image>().sprite;
            ImagenSeleccionada.GetComponent<Image>().sprite = spriteSeleccionado;
            identificadorImagenSeleccionada = "5";
        });


    }

    private void poneEscuchadoresBotones(){
        boton_aceptar.onClick.AddListener( ()=>{ 
                GameObject marcadorCreado = Instantiate(marcador,coordenadas,Quaternion.identity);
                marcadorCreado.GetComponent<DetalleApuntadorDetalle>().conDetalleApuntador(generarComentario()).actualizarMarcador();
                destruirme();
        });
        boton_cancelar.onClick.AddListener( ()=>{ 
                destruirme();
        });
    }

    private Comentario generarComentario(){
        Comentario comentario = new Comentario();
        comentario.icono = identificadorImagenSeleccionada;
        return comentario;
    }

    private Vector3 coordenadas;
    public ManejadorDialogoCreacion conCoordenadas(Vector3 coordenadas){
        this.coordenadas = coordenadas;
        return this;
    }   

    private void destruirme(){
                
        GameObject dialogoAEliminar = GameObject.Find(name); 
        Destroy(dialogoAEliminar);
    }

    private void OnDestroy() {
        estoyMostrandome = false;
    }


}
