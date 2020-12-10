using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointS : MonoBehaviour {
    public GameObject myParticle;
    float tall;
    Vector3 scle;
    ButtonUI btnui;
    Point point;
    Cannon cannon;
    Text Scoretxt;
    // Use this for initialization
    void Start () {
        btnui = GameObject.Find("UIManager").GetComponent<ButtonUI>();
        point = GameObject.Find("ObjectFloor").GetComponent<Point>();
        cannon = GameObject.Find("cannon").GetComponent<Cannon>();
        Scoretxt = GameObject.Find("Score").GetComponent<Text>();
        tall = Random.Range(1f, 3f);
        scle = new Vector3(tall, 0.05f, tall);
        transform.localScale = scle;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet") && cannon.trigger)
        {
            GameObject particleObj = Instantiate(myParticle) as GameObject;
            particleObj.transform.position = transform.position;
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Destroy(particleObj, 1f);
            point.i -= 1;
            btnui.Cu_Src += transform.GetChild(0).GetComponent<PointTxt>().ran;
            Scoretxt.text = "점수:" + btnui.Cu_Src.ToString();
            Debug.Log(btnui.Cu_Src);
            cannon.trigger = false;
            btnui.Break = true;
            btnui.Check();
        }
    }
}
