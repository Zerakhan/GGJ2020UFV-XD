using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Scene3 : MonoBehaviour
{
    public GameObject Imagen1;
    public GameObject Imagen2;
    public GameObject Imagen3;

    bool animationEspejo = false;  

    // Start is called before the first frame update
    void Start()
    {
        Imagen1.gameObject.SetActive(false);
        Imagen2.gameObject.SetActive(false);
        Imagen3.gameObject.SetActive(false);

        StartCoroutine(AnimationEspejo());
    }

    // Update is called once per frame
    void Update()
    {
        
           
        
    }

    IEnumerator AnimationEspejo()
    {
        yield return new WaitForSeconds(4f);
        Imagen1.gameObject.SetActive(true);
        Imagen2.gameObject.SetActive(false);
        Imagen3.gameObject.SetActive(false);
        yield return new WaitForSeconds(4f);
        Imagen1.gameObject.SetActive(false);
        Imagen2.gameObject.SetActive(true);
        Imagen3.gameObject.SetActive(false);
        yield return new WaitForSeconds(8f);
        Imagen1.gameObject.SetActive(false);
        Imagen2.gameObject.SetActive(false);
        Imagen3.gameObject.SetActive(true);
    }
}
