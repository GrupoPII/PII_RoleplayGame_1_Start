public abstract class Enemigo : Personaje
{
    public int VP { get; set; }

    public Enemigo(string nombre, int vidaInicial, int fuerza, int vp)
        : base(nombre, vidaInicial, fuerza)
    {
        VP = vp;
    }
}