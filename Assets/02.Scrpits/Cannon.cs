using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Cannon : MonoBehaviour {
    public GameObject bullet;
    public Transform firePos;
    ButtonUI btnui;
    CameraManager cmManager;
    Text Turntxt;
    float rotSpeedM = 1.0f;
    float rotSpeedK = 15.0f;
    public bool trigger;
    // Use this for initialization
    void Start () {
        btnui = GameObject.Find("UIManager").GetComponent<ButtonUI>();
        cmManager = GameObject.Find("CameraManager").GetComponent<CameraManager>();
        Turntxt = GameObject.Find("Turn").GetComponent<Text>();
        Turntxt.text = "남은 턴:" + btnui.Count.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        float MouseX = Input.GetAxis("Mouse X");
        float MouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.up * rotSpeedM * MouseX);
        firePos.Rotate(Vector3.up * rotSpeedM * MouseX);
        transform.Rotate(Vector3.left * rotSpeedM * MouseY);
        firePos.Rotate(Vector3.left * rotSpeedM * MouseY);
        if (Input.GetKey(KeyCode.W) == true)
        {
            transform.Rotate(Vector3.left * rotSpeedK * Time.deltaTime);
            firePos.Rotate(Vector3.left * rotSpeedK * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            transform.Rotate(Vector3.down * rotSpeedK * Time.deltaTime);
            firePos.Rotate(Vector3.down * rotSpeedK * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            transform.Rotate(Vector3.right * rotSpeedK * Time.deltaTime);
            firePos.Rotate(Vector3.right * rotSpeedK * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.Rotate(Vector3.up * rotSpeedK * Time.deltaTime);
            firePos.Rotate(Vector3.up * rotSpeedK * Time.deltaTime);
        }

        if ((Input.GetButtonUp("Fire1") || Input.GetKeyUp(KeyCode.Space)) && btnui.Break)
        {
            trigger = true;
            btnui.Break = false;
            Instantiate(bullet, firePos.position, firePos.rotation);
            btnui.Count -= 1;
            cmManager.check = true;
            Turntxt.text = "남은 턴:" + btnui.Count.ToString();
        }
    }
}
