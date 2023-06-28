using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {
    //GoToScene allows for when button clicked go to differen scene
    public void GoToScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
    
    //quits when you press the "quit" button
    public void QuitApp() {
#if UNITY_EDITOR
        //application.editor won't work in the editor so the false
        //needs to be set to end the game.
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

     }
}
