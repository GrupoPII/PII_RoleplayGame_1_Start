public class Mago : Heroe
{
    public int PoderMagico { get; set; }

    public Mago(
        string nombre,
        int vidaInicial,
        int fuerza,
        int poderMagico)
        : base(nombre, vidaInicial, fuerza)
    {
        PoderMagico = poderMagico;
    }

    public override int AtaqueTotal()
    {
        return Fuerza + PoderMagico;
    }

    public override int DefensaTotal()
    {
        return PoderMagico;
    }

    public void EstudiarMagia()
    {
        PoderMagico += 10;
    }
}