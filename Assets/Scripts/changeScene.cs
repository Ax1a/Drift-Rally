using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void btn_Change_Scene(string scene_name){
        SceneManager.LoadScene(scene_name);
    }
}
