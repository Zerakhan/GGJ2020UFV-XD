using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class School : MonoBehaviour
{
    public GameObject mochila;
    public GameObject llave;
    public GameObject manager;
    bool haribo = false;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SceneEnder()
    {
        manager.GetComponent<GameManager>().Changer2(haribo);
        SceneManager.LoadScene("Niveles");
    }
}
