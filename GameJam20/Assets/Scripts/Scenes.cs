using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public bool scene1 = true;
    public bool scene2 = true;
    public bool scene3 = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Scene1()
    {
        if (scene1)
        {
            SceneManager.LoadScene("Scene-1");
        }

    }
    public void Scene2()
    {
        if (scene2)
        {
            SceneManager.LoadScene("Scene-2");
        }

    }
    public void Scene3()
    {
        if (scene3)
        {
            SceneManager.LoadScene("Scene-3");
        }

    }
}

   
