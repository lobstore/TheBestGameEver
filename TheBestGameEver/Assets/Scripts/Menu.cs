using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    public void Restar()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
