using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Die : MonoBehaviour
{
    public Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }
    //The die I used is wrong, the opposing faces sums do not equal 7, all I had. 
    Dictionary<Vector3, byte> faces = new Dictionary<Vector3, byte>()
    {
        {Vector3.up, 3 },
        {-Vector3.up, 1 },
        {Vector3.forward, 2 },
        {-Vector3.forward, 4 },
        {Vector3.right, 5 },
        {-Vector3.right, 6 },
    };
    
    public byte GetValue() => faces[new Vector3(Mathf.Round(transform.InverseTransformDirection(Vector3.up).x), Mathf.Round(transform.InverseTransformDirection(Vector3.up).y), Mathf.Round(transform.InverseTransformDirection(Vector3.up).z))];

}
