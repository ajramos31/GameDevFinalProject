using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] Movement movement; 
    [SerializeField] PointsHandler pointsHandler; 
    [SerializeField] ProjectileThrower projectileThrower; 
    void Awake(){
        //pointsHandler = GameObject.FindGameObjectWithTag("PointsHandler" ).GetComponent<PointsHandler>(); 
       // GameObject.Find("PointsHandler").GetComponent<PointsHandler>(); 
       projectileThrower = GetComponent<ProjectileThrower>(); 
    }
    void Start(){
        pointsHandler = PointsHandler.singleton; // the second fastes option
    }
    void FixedUpdate(){
         Vector3 vel = Vector3.zero; 

        if(Input.GetKey(KeyCode.W)){
            vel.y = 5; 
        }if(Input.GetKey(KeyCode.D)){
            vel.x = 5; 
        }if(Input.GetKey(KeyCode.S)){
            vel.y = -5;
        }if(Input.GetKey(KeyCode.A)){
            vel.x = -5; 
        }
        movement.MoveRB(vel); 
        pointsHandler.AddDistance( vel.magnitude * Time.deltaTime); 

        
    }
    void Update()
    {
        //projectiles 
        if( Input.GetKeyDown( KeyCode.Q)){
            projectileThrower.Throw(Camera.main.ScreenToWorldPoint(Input.mousePosition)); 
        }
    }
}
