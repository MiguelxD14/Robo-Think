using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartScene : MonoBehaviour
{
    void OnMouseDown()
    {
  
     Debug.Log("Restart");
     SceneManager.LoadScene("Sala1"); 

    }
      
    }


