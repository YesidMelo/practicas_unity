using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegados {

    public delegate void pasarGameObject(GameObject objeto);
    public delegate void pasarFloat(float numeroFloat);

    public delegate void pasarComentario(Comentario comentario);

    public delegate void escuchadorInput(ExtensionesInput.Entrada entrada);
    public delegate void escuchadorItemSeleccionado <T>(T objeto ) where T : ModeloBase;

    public delegate void escuchadorString(string texto);
}
