using UnityEditor;
using UnityEngine;

public class personagem : MonoBehaviour
{
    private string nome;
    private int energia;   
    private int forca_ataque;
    private float velocidade;
    private int numero_pes;
    private int numero_de_maos;

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
        return this.nome;
    }

    public void setEnergia(int energia)
    {
        this.energia = energia;
    }

    public string Energia()
    {
        return this.Energia();
    }

    public void SetForca_ataque(int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }

    public float Forca_do_pulo()
    {
        return this.Forca_do_pulo();
    }
}

