using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartScene : MonoBehaviour
{
    void OnMouseDown()
    {
            SceneManager.LoadScene("Sala1");
            Debug.Log("Restart");
            
    }
      
   }


