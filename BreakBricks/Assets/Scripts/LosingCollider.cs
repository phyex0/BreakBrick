using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LosingCollider : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D collision)
    {
       
        SceneManager.LoadScene(2);
        //x müziğini çal
        //text = xyz
       
    }
}
