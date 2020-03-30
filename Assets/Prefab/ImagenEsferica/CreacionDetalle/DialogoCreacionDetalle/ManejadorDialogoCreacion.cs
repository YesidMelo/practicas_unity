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
    public InputField TextoEntrada;
    

    private void Start() {
        secuenciaInicio();
    }


    private void secuenciaInicio(){
        estoyMostrandome = true;
        poneEscuchadoresImagenes();
        poneEscuchadoresBotones();
    }

    private void poneEscuchadoresImagenes(){

        Agua.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            asignarIconoAsignado("1");
        });

        Luz.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            asignarIconoAsignado("2");
        });

        Gas.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            asignarIconoAsignado("3");
        });

        Mantenimiento.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            asignarIconoAsignado("4");
        });

        Parabolica.GetComponent<ManejadorClickIcono>().conEscuchador((string nombre)=>{ 
            asignarIconoAsignado("5");
        });


    }

    private void asignarIconoAsignado(string identificador){

        identificadorImagenSeleccionada = identificador;
        spriteSeleccionado = SelectorImagenes.getInstancia().buscarSpriteConID(identificadorImagenSeleccionada);
        ImagenSeleccionada.GetComponent<Image>().sprite = spriteSeleccionado;
        
    }

    private void poneEscuchadoresBotones(){
        boton_aceptar.onClick.AddListener( ()=>{ 
            if(comentario == null){
                crearApuntador();
                destruirme();
                return;
            }
            escuchadorComentario(generarComentario());
            destruirme();
        });

        boton_cancelar.onClick.AddListener( ()=>{ 
                destruirme();
        });
    }

    
    private void crearApuntador(){
        GameObject marcadorCreado = Instantiate(marcador,coordenadas,Quaternion.identity);

        marcadorCreado
        .GetComponent<DetalleApuntadorDetalle>()
        .conDetalleApuntador(generarComentario())
        .actualizarMarcador();

        if(escuchadorGameObject == null ){ return; }
        escuchadorGameObject(marcadorCreado);

    }

    private Comentario generarComentario(){
        
        if(comentario == null ){
            comentario = new Comentario();
        }        

        comentario.icono = identificadorImagenSeleccionada;
        comentario.mensaje = TextoEntrada.text;
        return comentario;
    }

    private Delegados.pasarGameObject escuchadorGameObject;
    public ManejadorDialogoCreacion conEscuchadorMarcadorCreado(Delegados.pasarGameObject escuchadorGameObject){
        this.escuchadorGameObject = escuchadorGameObject;
        return this;
    }  

    private void destruirme(){
                
        GameObject dialogoAEliminar = GameObject.Find(name); 
        Destroy(dialogoAEliminar);
    }

    private void OnDestroy() {
        estoyMostrandome = false;
    }

    private Vector3 coordenadas;
    public ManejadorDialogoCreacion conCoordenadas(Vector3 coordenadas){
        this.coordenadas = coordenadas;
        return this;
    }

    private Comentario comentario;
    public ManejadorDialogoCreacion conComentario(Comentario comentario){
        this.comentario = comentario ;
        return this;
    }
    
    private Delegados.pasarComentario escuchadorComentario;
    public ManejadorDialogoCreacion conEscuchadorComentario(Delegados.pasarComentario escuchadorComentario){
        this.escuchadorComentario = escuchadorComentario;
        return this;
    }

    public void actualizaVista(){
        if(comentario == null ){ return; }
        ponerIconoSeleccionado();
        poneTexto();
    }

    private void ponerIconoSeleccionado(){
        spriteSeleccionado = SelectorImagenes.getInstancia().buscarSpriteConID(comentario.icono);
        ImagenSeleccionada.GetComponent<Image>().sprite = spriteSeleccionado;
    }

    private void poneTexto(){
        TextoEntrada.text = comentario.mensaje;
    }

}
