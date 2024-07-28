namespace Records.Example.App.Test;
public record Person(string Nombre, string Apeliido,
    string Direccion, int Edad, string Sexo)
{
    private string _nombre = EsNombreValido(Nombre);
    public string Nombre
    {
        get => _nombre;
        init => _nombre = EsNombreValido(value);
    }

    private static string EsNombreValido(string nombre)
    {
        if(nombre.Length > 10)
            throw new Exception();
        return nombre;
    }
}