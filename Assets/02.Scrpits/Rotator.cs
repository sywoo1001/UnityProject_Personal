using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
    float rotSpeedM = 1.0f;
    float rotSpeedK = 15.0f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float MouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * rotSpeedM * MouseX);

        if (Input.GetKey(KeyCode.A) == true)
        {
            transform.Rotate(Vector3.down * rotSpeedK * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.Rotate(Vector3.up * rotSpeedK * Time.deltaTime);
        }
    }
}
