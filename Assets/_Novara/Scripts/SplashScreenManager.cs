using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreenManager : MonoBehaviour
{
    [Header("Transition Settings")]
    public string nextSceneName = "MainGame";
    public float waitTime = 3.0f;

    void Start()
    {
        StartCoroutine(WaitAndLoad());
    }

    private IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(waitTime);
        // This will load the scene you named "MainGame"
        SceneManager.LoadScene(nextSceneName);
    }
}