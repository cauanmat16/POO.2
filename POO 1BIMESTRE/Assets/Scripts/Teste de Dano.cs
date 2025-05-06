using UnityEngine;

public class TesteDeDano : MonoBehaviour
{
    Personagem personagem  = new Personagem();
    private void OnCollisionEnter(Collision colisao)
    {
        Debug.Log("fffff");
        
        if (colisao.gameObject.CompareTag("Inimigo"))
        {
            int energia_atual = personagem.Energia() - colisao.gameObject.GetComponent<Inimigo>().DanoDoInimigo();
         
            personagem.SetEnergia(energia_atual);
            
            Debug.Log(personagem.Energia());
        }
    }
    
 
    void Start()
    {
        personagem = gameObject.GetComponent<Personagem>();
    }

   
    void Update()
    {
        
    }
}