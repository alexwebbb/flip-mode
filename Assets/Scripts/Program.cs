using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Program : MonoBehaviour {

    public bool debugMode = false;
    public Scene debugScene;
    public List<Scene> scenes = new List<Scene>();

	// Use this for initialization
	void Start () {
        Reset();
	}


    private void Reset() {
        
        if(debugMode)
        {
            SceneManager.LoadScene(debugScene.buildIndex);
        }



    }
}
