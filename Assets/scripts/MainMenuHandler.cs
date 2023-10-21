using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Phils yard"); 
    }
    
    public void QuitGame(){
        Application.Quit(); 
    }
}
