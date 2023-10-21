using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 2; 
    Rigidbody2D rb; 

    void Awake(){
        rb = GetComponent<Rigidbody2D>(); 
    }

    public void MoveRB( Vector3 vel ){
        rb.velocity = vel; 
    }
}
