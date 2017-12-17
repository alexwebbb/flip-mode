using UnityEngine;
using System.Runtime.InteropServices;

public class JavascriptTest : MonoBehaviour {

    [DllImport("__Internal")]
    private static extern void Hello();

    [DllImport("__Internal")]
    private static extern void HelloString(string str);



    void OnTriggerEnter(Collider other)
    {

        Hello();

        HelloString("This is a string.");



    }
}
