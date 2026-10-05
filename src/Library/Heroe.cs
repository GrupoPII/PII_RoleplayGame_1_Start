public abstract class Heroe : Personaje
{
    public int VP { get; set; }

    public Heroe(string nombre, int vidaInicial, int fuerza)
        : base(nombre, vidaInicial, fuerza)
    {
        VP = 0;
    }

    public void GanarVP(int puntos)
    {
        VP += puntos;
    }
}