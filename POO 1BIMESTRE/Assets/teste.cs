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
        Mustang.setNumero_de_rodas(4);
        Mustang.setPreco(2000.00f);
        Debug.Log("O " + Mustang.getNome() + " é " + Mustang.getCor() + " tem  " + Mustang.getNumerode_Rodas());
        
        fusca.setNome("fusca");
        fusca.setCor("preto");
        fusca.setNumero_de_rodas(4);
        fusca.setPreco(360.00f);
        
        Debug.Log("O " + fusca.getNome() + " é " + fusca.getCor() + " tem  " + fusca.getNumerode_Rodas() + " e custa R$ " + fusca.getpreco());
        
        
    }
    
    
}
