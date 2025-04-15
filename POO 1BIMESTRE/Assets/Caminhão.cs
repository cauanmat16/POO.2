using UnityEngine;

public class Caminhão : carro
{
    private string tipo_de_carroceria;

    public void AtribuirTipoDeCarroceria(string tipo_de_carroceria)
    {
        this.tipo_de_carroceria = tipo_de_carroceria;
    }

    public string getTipoDeCarroceria()
    {
        return this.tipo_de_carroceria;
    }
}
