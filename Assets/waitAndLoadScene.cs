using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class waitAndLoadScene : MonoBehaviour
{
    public string sceneToLoad;
    public int durationToWait;

    void Start()
    {
        StartCoroutine(WaitAndLoad());
    }

    IEnumerator WaitAndLoad()
    {
        print(Time.time);
        yield return new WaitForSeconds(durationToWait);
        print(Time.time);
        SceneManager.LoadScene(sceneToLoad);
    }

}