using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

public interface Ipersonaje
{
    public string Nombre {get; set}
    public int Vida {get; set;}
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