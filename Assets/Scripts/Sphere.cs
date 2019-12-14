using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
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
        GameObject.Find("GameManager").GetComponent<GameManager>().ChangeScore(-1);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
