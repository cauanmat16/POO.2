using UnityEngine;

public class Movimentoinimigo : MonoBehaviour
{
    private GameObject _player;
    private Rigidbody2D _rigidbody;
    private float velocidade;
    public float raioDeVisao = 20;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        velocidade = gameObject.GetComponent<Inimigo>().Velocidade();
        
        _player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if( Vector3.Distance(transform.position, _player.transform.position) < raioDeVisao)
        {
            transform.LookAt(_player.transform.position);
            transform.position = Vector3. MoveTowards(transform.position, _player.transform.position, velocidade * Time.deltaTime); 
        }
        
        
    }
    
    
}
