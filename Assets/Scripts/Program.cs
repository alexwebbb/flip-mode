using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Program : MonoBehaviour {

    // currently the role of this script is just to reset 
    // gameobjects that get registered with it
    // TODO rename script???

    public bool debugMode = false;
    public bool resetInitialized = false;
    public List<GameObject> resettableItems = new List<GameObject>();

    List<Transform> transformQueue = new List<Transform>();
    List<Vector3> originalVector = new List<Vector3>();
    List<Quaternion> originalRot = new List<Quaternion>();
    List<Rigidbody> rbQueue = new List<Rigidbody>();

	// Use this for initialization
	void Start () {
        Reset();
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
            Debug.Log("reset");
        }
    }


    private void Reset() {

        if (!debugMode) return;


        if (!resetInitialized)
        {
            
            for (int i = 0; i < resettableItems.Count; i++)
            {
                Transform[] temp = resettableItems[i].GetComponentsInChildren<Transform>();

                for (int j = 0; j < temp.Length; j++)
                {
                    transformQueue.Add(temp[j]);
                    originalVector.Add(temp[j].position);
                    originalRot.Add(temp[j].rotation);
                }

                Rigidbody[] temp2 = resettableItems[i].GetComponentsInChildren<Rigidbody>();

                foreach (var item in temp2)
                {
                    rbQueue.Add(item);
                }
            }

            resetInitialized = true;
        }


        foreach (var item in rbQueue)
        {
            item.velocity = item.angularVelocity = Vector3.zero;
            
        }

        for (int k = 0; k < transformQueue.Count; k++)
        {   
            transformQueue[k].position = originalVector[k];
            transformQueue[k].rotation = originalRot[k];
        }



    }
}
