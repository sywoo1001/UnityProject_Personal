using UnityEngine;
using System.Collections;

public class EndButton : MonoBehaviour {
    ButtonUI btnui;
	// Use this for initialization
	void Start () {
        btnui = GameObject.Find("UIManager").GetComponent<ButtonUI>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RestartE()
    {
        btnui.Restart();
    }

    public void TitleE()
    {
        btnui.Title();
    }
    public void ExitE()
    {
        btnui.Exit();
    }
}
