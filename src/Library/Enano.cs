public class Enano : Heroe
{
    public int Resistencia { get; set; }

    public Enano(
        string nombre,
        int vidaInicial,
        int fuerza,
        int resistencia)
        : base(nombre, vidaInicial, fuerza)
    {
        Resistencia = resistencia;
    }

    public override int AtaqueTotal()
    {
        return Fuerza;
    }

    public override int DefensaTotal()
    {
        return Resistencia;
    }

    public void Combatir()
    {
        // comportamiento propio del enano
    }
}