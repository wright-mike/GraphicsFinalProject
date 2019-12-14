using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube : MonoBehaviour
{
    private bool clicked;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        Destroy(gameObject);
        GameObject.Find("GameManager").GetComponent<GameManager>().ChangeScore(1);
        clicked = true;
    }

    void OnBecameInvisible()
    {
        if (!clicked)
        {
            Destroy(gameObject);
            GameObject.Find("GameManager").GetComponent<GameManager>().ChangeScore(-1);
        }
    }

}
