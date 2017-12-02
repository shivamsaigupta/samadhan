using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class change_scene : MonoBehaviour
{
	public string sceneToLoad;

	void Start()
	{
		SceneManager.LoadScene(sceneToLoad);
	}


}