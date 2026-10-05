public interface IElementoMagico
{
    string Nombre {get; set;}
    int Ataque {get; set;}
    int Defensa {get; set;}
    int ValorAtaque();
    int ValorDefensa();
}