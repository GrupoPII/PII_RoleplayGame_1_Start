public class Elfo : Heroe
{
    public int Resistencia { get; set; }
    public bool AyudarAOtros { get; set; }

    public Elfo(
        string nombre,
        int vidaInicial,
        int fuerza,
        int resistencia,
        bool ayudarAOtros)
        : base(nombre, vidaInicial, fuerza)
    {
        Resistencia = resistencia;
        AyudarAOtros = ayudarAOtros;
    }

    public override int AtaqueTotal()
    {
        return Fuerza;
    }

    public override int DefensaTotal()
    {
        return Resistencia;
    }

    public void Ayudar(Personaje aliado)
    {
        if (AyudarAOtros)
        {
            aliado.VidaActual += 10;

            if (aliado.VidaActual > aliado.VidaInicial)
            {
                aliado.VidaActual = aliado.VidaInicial;
            }
        }
    }
}