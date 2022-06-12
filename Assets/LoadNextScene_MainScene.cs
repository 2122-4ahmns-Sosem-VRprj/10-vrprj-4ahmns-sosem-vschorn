using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene_MainScene : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
