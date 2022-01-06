using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public GameObject sfx;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Die());
        Instantiate(sfx);
    }
    IEnumerator Die()
    {
        yield return new WaitForSeconds(0.75f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
