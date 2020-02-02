using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Vector2 targetPosition;
    bool hide = false;
    public GameObject esconder;
    public GameObject escondite1;
    public GameObject escondite2;
    public GameObject escondite3;
    public Vector3 escondido;
    public bool audifono;
    Vector2 escondido1;
    Vector2 escondido2;
    Vector2 escondido3;
    public static bool can_move;
    public GameObject block;
    Vector2 niña;
    public GameObject madre;
    Vector2 madrepoint;
    public AudioClip cristal;
    public AudioSource fuente;
    public AudioClip bajo;
    public AudioClip medio;
    void Awake()
    {
        audifono = true;
    }
    void Start()
    {
        this.transform.position = new Vector3(0,0,-1);
        escondido1 = new Vector2(escondite1.transform.position.x, escondite1.transform.position.y);
        escondido2 = new Vector2(escondite2.transform.position.x, escondite2.transform.position.y);
        escondido3 = new Vector2(escondite3.transform.position.x, escondite3.transform.position.y);
        madrepoint = new Vector2(madre.transform.position.x, madre.transform.position.x);
    }
    // Update is called once per frame
    void Update()
    {
        niña = new Vector2(this.transform.position.x, this.transform.position.y);
        if ((Vector2.Distance(niña, escondido1) < 3) || (Vector2.Distance(niña, madrepoint) < 3))
        {
            fuente.PlayOneShot(medio);
        }
        else fuente.PlayOneShot(bajo);
        Move();
        if (this.transform.position.x > 21 && !audifono)
        {
            SceneManager.LoadScene("Niveles");
        }
    }
    void Move()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if ((Vector2.Distance(targetPosition, escondido1) < 2 || Vector2.Distance(targetPosition, escondido2) < 2 || Vector2.Distance(targetPosition, escondido3) < 2) && audifono)
            {
                esconder.SetActive(true);
                return;
            }
            else if ((Vector2.Distance(targetPosition, escondido1) > 4 && Vector2.Distance(targetPosition, escondido2) > 4 && Vector2.Distance(targetPosition, escondido3) > 4) && esconder.activeSelf == true)
            {
                esconder.SetActive(false);
            }
        }
            targetPosition.y = 0;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);
    }
    public void Hidden()
    {
        Debug.Log("pasa");
        if (audifono) 
        {
            audifono = false;
        }
        
        esconder.SetActive(false);
        Destroy(block);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Espejo")
        {
            fuente.PlayOneShot(cristal);
        }
    }
}