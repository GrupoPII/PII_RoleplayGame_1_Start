using System.Collections.Generic;

public class Elfo : IPersonaje
{
    public string Nombre { get; set; }
    public int VidaInicial { get; set; }
    public int VidaActual { get; set; }
    public List<IElemento> Elementos { get; set; }
    public int Fuerza { get; set; }
    public int Resistencia { get; set; }
    public bool AyudarAOtros { get; set; }

    public Elfo(string nombre, int vidaInicial, int fuerza, int resistencia, bool ayudarAOtros)
    {
        Nombre = nombre;
        VidaInicial = vidaInicial;
        VidaActual = vidaInicial; // al inicio la vida actual = inicial
        Fuerza = fuerza;
        Resistencia = resistencia;
        AyudarAOtros = ayudarAOtros;
        Elementos = new List<IElemento>();
    }

    public void AgregarElemento(IElemento elemento)
    {
        Elementos.Add(elemento);
    }

    public void QuitarElemento(IElemento elemento)
    {
        Elementos.Remove(elemento);
    }

    public void CambiarElemento(IElemento anterior, IElemento nuevo)
    {
        int index = Elementos.IndexOf(anterior);
        if (index != -1)
        {
            Elementos[index] = nuevo;
        }
    }

    public int AtaqueTotal()
    {
        return Fuerza;
    }

    public int DefensaTotal()
    {
        return Resistencia;
    }

    public void Curar()
    {
        VidaActual = VidaInicial;
    }

    public void Atacar(IPersonaje personaje)
    {
        int daño = this.AtaqueTotal() - personaje.DefensaTotal();
        if (daño < 0) daño = 0;
        personaje.VidaActual -= daño;
        if (personaje.VidaActual < 0) personaje.VidaActual = 0;
    }

    public void Ayudar(IPersonaje aliado)
    {
        if (AyudarAOtros)
        {
            aliado.VidaActual += 10; // ejemplo: cura 10 puntos
            if (aliado.VidaActual > aliado.VidaInicial)
                aliado.VidaActual = aliado.VidaInicial;
        }
    }
}
