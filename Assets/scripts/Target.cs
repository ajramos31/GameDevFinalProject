using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    
    void OnTriggerEnter2D( Collider2D other){
        Destroy(this.gameObject);  
    }
}
