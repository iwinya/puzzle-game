using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame(){
        SceneManager.LoadSceneAsync("Level1");
    }

    public void QuitGame(){
        Application.Quit();
    }


}


/*
References:

https://www.youtube.com/watch?v=DX7HyN7oJjE
*/