using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Block : MonoBehaviour
{
    // Start is called before the first frame update

    static int score= 0;

    private void Start() {
        score = 0;
    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
        Object.Destroy(gameObject , 0.0f);
        score++;
        Debug.Log(score);
        if(score == 64)
            SceneManager.LoadScene(3);
            
    }

}
