using System.Collections;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField] GameObject boxPrefab; 

    void Start(){
        SpawnBoxesOverTime(); 
    }

    void SpawnBoxesOverTime(){

        StartCoroutine( SpawnBoxesOverTimeRoutine() ); 
        IEnumerator SpawnBoxesOverTimeRoutine(){
            while( true ){
                yield return new WaitForSeconds(1); // always include this statement or the game/editor will crash 
                GameObject newBox = Instantiate(boxPrefab, new Vector3(Random.Range(-10,10), Random.Range(-10,10), 0), Quaternion.identity); 
                Destroy( newBox, 5 ); 
            }
            yield return null;   // waits for a single frame

        }
    }
}
