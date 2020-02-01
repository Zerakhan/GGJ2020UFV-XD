using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int levelOfTrauma = 0;
    public bool scene1 = true;
    public bool scene2 = true;
    public bool scene3 = true;
    public GameObject traumButton1;
    public GameObject traumButton2;
    public GameObject traumButton3;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void Scene1()
    {
        if (scene1) traumButton1.SetActive(true);
        else traumButton1.SetActive(false);

    }
    public void Scene2()
    {
        if (scene2) traumButton2.SetActive(true);
        else traumButton2.SetActive(false);

    }
    public void Scene3()
    {
        if (scene3) traumButton3.SetActive(true);
        else traumButton3.SetActive(false);
    }
    public void Changer1(bool change)
    {
        scene1 = change;
    }
    public void Changer2(bool change)
    {
        scene2 = change;
    }
    public void Changer3(bool change)
    {
        scene3 = change;
    }
}
