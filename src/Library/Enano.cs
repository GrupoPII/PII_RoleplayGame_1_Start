using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public class Enano
{
    public string Nombre {get; set;}
    public int Vida {get; set;}
    public int Fuerza {get; set;}
    public int Resistencia {get; set;}
    public List <IElemento> Elementos = new List<IElemento>():
    public Enano(string nombre, int vida, int fuerza, int resistencia)
    {
        this.Nombre = nombre;
        this.Vida = vida;
        this.Fuerza = fuerza;
        this.Resistencia = resistencia;   
    }

    public void AgregarElemento(IElemento elemento)
    {
        this.Elementos.Add(elemento);
    }
    public void RemoveElemento(IElemento elemento)
    {
        this.Elementos.Remove(elemento);
    }
    public void CambiarElemento( IElemento anterior, IElemento nuevo )
    {
        
    }
    public int AtaqueTotal()
    {
        
    }
        public int DefensaTotal()
    {
        
    }
    public void Atacar(Ipersonaje, objetivo)
    {
        
    } 
}