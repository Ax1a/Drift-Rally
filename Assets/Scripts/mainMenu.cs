using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void btn_Change_Scene(string scene_name){
        SceneManager.LoadScene(scene_name);
    }

    public void quitGame(){
        Application.Quit();
    }
}
