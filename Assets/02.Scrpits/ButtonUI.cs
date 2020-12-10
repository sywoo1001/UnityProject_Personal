using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonUI : MonoBehaviour {
    public int Score;
    public int Count;
    public int Cu_Src;
    public bool Break;
    public GameObject BtnUi;
    int save_sc;
    int save_ct;
    // Use this for initialization
    void Start () {
        Score = 10;
        Count = 0;
        Cu_Src = 0;
        Break = true;
        DontDestroyOnLoad(BtnUi);
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void Check()
    {
        if (Cu_Src == Score && Count >= 0 && Break)
        {
            Invoke("Win", 2);
        }

        if(Cu_Src > Score || (Cu_Src < Score && Count == 0 && Break))
        {
            Invoke("Lose", 2);
        }
    }
    
    void Win()
    {
        SceneManager.LoadScene("Win");
    }

    void Lose()
    {
        SceneManager.LoadScene("Lose");
    }

    public void GameScene()
    {
        save_sc = Score;
        save_ct = Count;
        SceneManager.LoadScene("Game");
    }

    public void Restart()
    {
        Score = save_sc;
        Count = save_ct;
        Cu_Src = 0;
        SceneManager.LoadScene("Game");
    }

    public void Title()
    {
        SceneManager.LoadScene("Main");
    }

    public void Exit()
    {
            Application.Quit();
    }
}
