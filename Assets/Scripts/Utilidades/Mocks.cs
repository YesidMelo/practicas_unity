using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mocks 
{
    private const string icono = "data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iaXNvLTg4NTktMSI/Pg0KPCEtLSBHZW5lcmF0b3I6IEFkb2JlIElsbHVzdHJhdG9yIDE5LjAuMCwgU1ZHIEV4cG9ydCBQbHVnLUluIC4gU1ZHIFZlcnNpb246IDYuMDAgQnVpbGQgMCkgIC0tPg0KPHN2ZyB2ZXJzaW9uPSIxLjEiIGlkPSJDYXBhXzEiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHg9IjBweCIgeT0iMHB4Ig0KCSB2aWV3Qm94PSIwIDAgNDQ4LjAxMSA0NDguMDExIiBzdHlsZT0iZW5hYmxlLWJhY2tncm91bmQ6bmV3IDAgMCA0NDguMDExIDQ0OC4wMTE7IiB4bWw6c3BhY2U9InByZXNlcnZlIj4NCjxnPg0KCTxnPg0KCQk8cGF0aCBkPSJNNDM4LjczMSwyMDkuNDYzbC00MTYtMTkyYy02LjYyNC0zLjAwOC0xNC41MjgtMS4yMTYtMTkuMTM2LDQuNDhjLTQuNjQsNS42OTYtNC44LDEzLjc5Mi0wLjM4NCwxOS42NDhsMTM2LjgsMTgyLjQNCgkJCWwtMTM2LjgsMTgyLjRjLTQuNDE2LDUuODU2LTQuMjU2LDEzLjk4NCwwLjM1MiwxOS42NDhjMy4xMDQsMy44NzIsNy43NDQsNS45NTIsMTIuNDQ4LDUuOTUyYzIuMjcyLDAsNC41NDQtMC40OCw2LjY4OC0xLjQ3Mg0KCQkJbDQxNi0xOTJjNS42OTYtMi42MjQsOS4zMTItOC4yODgsOS4zMTItMTQuNTI4UzQ0NC4zOTUsMjEyLjA4Nyw0MzguNzMxLDIwOS40NjN6Ii8+DQoJPC9nPg0KPC9nPg0KPGc+DQo8L2c+DQo8Zz4NCjwvZz4NCjxnPg0KPC9nPg0KPGc+DQo8L2c+DQo8Zz4NCjwvZz4NCjxnPg0KPC9nPg0KPGc+DQo8L2c+DQo8Zz4NCjwvZz4NCjxnPg0KPC9nPg0KPGc+DQo8L2c+DQo8Zz4NCjwvZz4NCjxnPg0KPC9nPg0KPGc+DQo8L2c+DQo8Zz4NCjwvZz4NCjxnPg0KPC9nPg0KPC9zdmc+DQo=";
    private const string coordenadas = "{\"x\" : \"0\",\"y\" : \"0\",\"z\" : \"10\"}";
    public const string Marcador = "{\"titulo\" : \"Luz\",\"mensaje\" : \"Algo que pasa en la vida\",\"coordenadas\" : "+coordenadas+",\"icono\" :\""+icono+"\"}";

    public const string ListaMarcadores = "{ \"ListaComentarios\" : ["+Marcador+","+Marcador+","+Marcador+","+Marcador+","+Marcador+","+Marcador+"] }";
}
