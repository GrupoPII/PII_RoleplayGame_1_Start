public interface IElemento
{
    string Nombre { get; set; }
    bool EsMagico { get; }
}

public interface IArma : IElemento
{
    int ValorAtaque { get; set; }
}

public interface IDefensa : IElemento
{
    int ValorDefensa { get; set; }
}

//valor ataq y valor def van separados 

public interface IElementoMagico : IElemento
{
    //solo utilizable por magos
    
}

public interface IHechizo
{
    string Nombre { get; set; }
    int Poder { get; set; }
}

public interface ILibroDeHechizos : IElemento, IElementoMagico
{
    List<IHechizo> Hechizos { get; set; }
    void AgregarHechizo(IHechizo hechizo);
    void QuitarHechizo(IHechizo hechizo);
    int PoderTotal(); // contar hechizos que contiene
}