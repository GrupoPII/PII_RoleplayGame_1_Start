using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public class Enano
{
    public string Nombre {get; set;}
    public int VidaActual{get; set;}
    public List<dynamic> Elementos {get; set;}
    public int Fuerza {get; set;}
    public int Resistencia {get; set;}
    public Enano(string nombre, int vidaActual, int fuerza, int resistencia)
    {
        Nombre=nombre;
        VidaActual=vidaActual;
        Fuerza=fuerza;
        Resistencia=resistencia;
        Elementos= new List<dynamic>();
    }
    public void AgregarElemento(Escudo escudo)
    {
        Elementos.Add(escudo);
    }
    public void AgregarElemento(Martillo martillo)
    {
        Elementos.Add(martillo);
    }
}