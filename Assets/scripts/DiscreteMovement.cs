using UnityEngine;

public class DiscreteMovement : MonoBehaviour
{
    [SerializeField] float speed = 1; 
    Rigidbody2D rb; 

    void Awake(){
        rb = GetComponent<Rigidbody2D>(); 
    }
    public void MoveTransform(Vector3 vel){
            transform.position += vel * speed * Time.deltaTime; 
    }
    public void MoveRB( Vector3 vel){
        rb.velocity = vel * speed; 
        //rb.MovePosition(transform.position + (vel * Time.fixedDeltaTime)); 
        //rb.AddForce(vel); 
    }
}
