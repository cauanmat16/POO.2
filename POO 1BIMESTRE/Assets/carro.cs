using Unity.VisualScripting;
using UnityEngine;

public class carro
{
    private string nome;
    private int numero_de_rodas;
    private string cor;
    private float preco;

    public string getNome()
    {
        return nome;
    }

    public void setNome(string nome)

    {
        this.nome = nome;
    }

    public string getCor()
    {
        return this.cor;
    }

    public void setCor(string cor)
    {
        this.cor = cor;
    }

    public int getNumerode_Rodas()
    {
        return this.numero_de_rodas;
    }

    public void setNumero_de_rodas(int numero_rodas)
    {
        this.numero_de_rodas = numero_rodas;
    }

    public float getpreco()
    {
        return preco;
    }

    public void setPreco(float preco)
    {
        this.preco = preco;
    }

    public bool ComparePreco(carro carro)
        {

        if (this.preco > carro.getpreco())
        {
            return true;
        }
        
        return false;
    }
    
}

