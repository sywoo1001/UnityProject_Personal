using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LobbyTxt : MonoBehaviour {
    public InputField iptfld_S;
    public InputField iptfld_T;
    ButtonUI btnui;
    int s;
    int c;
	// Use this for initialization
	void Start () {
        btnui = GameObject.Find("UIManager").GetComponent<ButtonUI>();
        s = 0;
        c = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(s != int.Parse(iptfld_S.text))
        {
            btnui.Score = int.Parse(iptfld_S.text);
            s = btnui.Score;
        }
        if(c != int.Parse(iptfld_T.text))
        {
            btnui.Count = int.Parse(iptfld_T.text);
            c = btnui.Count;
        }
	}
}
