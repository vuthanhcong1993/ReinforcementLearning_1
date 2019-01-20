using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Serialization;


public class Test : MonoBehaviour
{
    [FormerlySerializedAs("gg")]
    public float health = 50;

    public float gg = 6;
    public Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        // Sets the rotation so that the transform's y-axis goes along the z-axis
        

    }
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.FromToRotation(transform.up, cube.forward);
    }
    [MenuItem("gg/tt")]
    static void Mama()
    {
        Debug.Log("xx");
    }
}
