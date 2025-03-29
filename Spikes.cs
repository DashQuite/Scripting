using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Spikes : MonoBehaviour
{

    //Имя сцены, которую нужно перезапустить
    public string sceneName;

    void OnTriggerEnter()      
    {
        EditorSceneManager.LoadScene(sceneName);    
    }

}
