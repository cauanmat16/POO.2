using UnityEngine;

public class Player : MonoBehaviour
{
   private Rigidbody _rigidbody;
   
   public float velocidade = 10;
   
   
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        Vector3 posicao = transform.position;
        
        //esquerda :X-
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log(posicao.x);
            posicao.x = transform.position.x - velocidade * Time.deltaTime;
        }
        
        //direita :X+
        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = transform.position.x + velocidade * Time.deltaTime;
        }
        
        
        //cima Z+ 
        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = transform.position.z - velocidade * Time.deltaTime;
        }
        
        
        
        //baixo Z-
        if(Input.GetKey(KeyCode.S))
        {
            posicao.z = transform.position.z - velocidade * Time.deltaTime;
        }
        
            
        transform.position = posicao;
        
    }
}
