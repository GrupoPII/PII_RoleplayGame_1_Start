using System.Collections.Generic;

public interface IPersonaje
{
    string Nombre { get; set; }
    int VidaInicial { get; set; }
    int VidaActual { get; set; }
    int Fuerza { get; set; }
    List<IElemento> Elementos { get; set; }

    void AgregarElemento(IElemento elemento);
    void QuitarElemento(IElemento elemento);
    void CambiarElemento(IElemento anterior, IElemento nuevo);

    int AtaqueTotal();
    int DefensaTotal();
    void Atacar(IPersonaje personaje);
    void Curar();
}
