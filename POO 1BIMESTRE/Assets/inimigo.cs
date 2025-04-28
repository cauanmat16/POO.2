using UnityEngine;

public class Inimigo : personagem
{
    [SerializeField]
    private string armadura;
    [SerializeField]
    private string arma;

    public void SetArmadura(string armadura)
    {
        this.armadura = armadura;
    }

    public string Armadura()
    {
        return armadura;
    }
    
    public void SetArma(string arma)
    {
        this.arma = arma;
    }

    public string Arma()
    {
        return arma;
    }

    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (arma)
        {
            case "ESPADA":
                dano = forca_ataque() + 10;
                break;
            case "MACHADO":
                dano = forca_ataque() + 18;
                break;
            case "ADAGA":
                dano = forca_ataque() + 5;
                break; 
                
        }
        
        //dano do ataque com a arma
        return 0;
    }
}
 

