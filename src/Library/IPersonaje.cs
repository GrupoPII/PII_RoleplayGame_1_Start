using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

public interface IPersonaje
{
    public string Nombre {get; set}
    public int VidaInicial {get; set;}
    public int VidaActual {get; set;}
    public int Fuerza {get; set; }
    public List<IElemento> Elementos {get; set}
    public void AgregarElemento( IElemento elemento);
    public void QuitarElemento (IElemento elemento);
    public void CambiarElemento (IElemento elemento);
    public int AtaqueTota();
    public int DefensaTotal();
    public void Atacar(IPersonaje personaje);
    public void Curar();


}