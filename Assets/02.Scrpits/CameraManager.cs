using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {
    ButtonUI btnui;
    public GameObject m;
    public GameObject s;
    public bool check;
	// Use this for initialization
	void Start () {
        check = false;
        btnui = GameObject.Find("UIManager").GetComponent<ButtonUI>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.K) == true && check && btnui.Break)
        {
            btnui.Break = false;
            check = false;
            sCamera();
            Invoke("mCamera", 1);
            btnui.Break = true;
        }

    }

    public void mCamera()
    {
        m.GetComponent<Camera>().enabled = true;
        s.GetComponent<Camera>().enabled = false;
    }

    public void sCamera()
    {
        s.GetComponent<Camera>().enabled = true;
        m.GetComponent<Camera>().enabled = false;
    }
}
