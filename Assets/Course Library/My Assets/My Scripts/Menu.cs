using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
   public void OnPlayButton(){
      // System.Threading.Thread.Sleep(1000);
      SceneManager.LoadScene(1, LoadSceneMode.Single);
      Debug.Log("Play button pressed");
   }

   public void OnQuitButton(){
      Debug.Log("Quit button pressed");
    Application.Quit();
   }
   
}
