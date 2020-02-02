using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void Scene1 (){
        SceneManager.LoadScene("Scene-1");
        }
    public void Scene2 (){
        SceneManager.LoadScene("Scene-2");
    }
    public void Scene3 ()
    {
        SceneManager.LoadScene("Scene-3");
    }
}
