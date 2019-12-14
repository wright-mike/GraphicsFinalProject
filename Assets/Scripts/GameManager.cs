using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    public Text Score;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("createSphere");
        StartCoroutine("createCube");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScore(int amount)
    {
        score += amount;
        Score.GetComponent<Text>().text = score.ToString();
    }

    private IEnumerator createSphere()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.4f,1.0f)); // wait half a second
            Instantiate(sphere, new Vector3(Random.Range(-2.5f, 2.5f),10,Random.Range(-0.2f,0.2f)), Quaternion.identity)
            .GetComponent<MeshRenderer>()
            .material
            .SetColor("_Color", Random.ColorHSV());
        }
    }

    private IEnumerator createCube()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.4f, 1.0f)); // wait half a second
            Instantiate(cube, new Vector3(Random.Range(-2.5f, 2.5f), 10, Random.Range(-0.2f, 0.2f)), Quaternion.identity)
                .GetComponent<MeshRenderer>()
                .material
                .SetColor("_Color", Random.ColorHSV());
        }
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}
