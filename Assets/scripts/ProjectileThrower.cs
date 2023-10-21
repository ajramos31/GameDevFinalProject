using UnityEngine;

public class ProjectileThrower : MonoBehaviour
{
    public GameObject projectilePreFab; 
    [SerializeField] float speed = 5f; 
    [SerializeField] AudioClip clip; 
 
    public void Throw(Vector3 targetPosition){
        Rigidbody2D newProjectileRB = Instantiate(projectilePreFab, transform.position,Quaternion.identity).GetComponent<Rigidbody2D>(); 
        //newProjectileRB.velocity = new Vector3(0,5,0);
        targetPosition.z = 0; 
        newProjectileRB.velocity = (targetPosition - transform.position).normalized * speed; 
        GetComponent<AudioSource>().Play(); 
        //GetComponenet<AudioSource>().PlayOneShot(); 
    }
}
