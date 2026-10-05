public abstract class Elemento
{
    string Name {get; set;}
    int Ataque {get; set;}
    int Defensa {get; set;}
    int ValorAtaque();
    int ValorDefensa();

}