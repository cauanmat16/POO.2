using Unity.VisualScripting;
using UnityEngine;

public class teste : MonoBehaviour
{
    carro Mustang = new carro();
    carro fusca = new carro();

    void Start()
    {
        Mustang.setNome("GT 500");
        Mustang.setCor("amarelo");


        Debug.Log("O "+ Mustang.getNome() + " é " + Mustang.getCor());
    }
    
    
    
}
