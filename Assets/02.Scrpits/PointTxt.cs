using UnityEngine;
using System.Collections;

public class PointTxt : MonoBehaviour {
    TextMesh txt_mesh;
    public int ran;
    // Use this for initialization
    void Start () {
        txt_mesh = GetComponent<TextMesh>();
        ran = Random.Range(10, 100) / 10 * 10;
        txt_mesh.text = ran.ToString();
        if(ran == 100)
        {
            this.transform.position = new Vector3(this.transform.position.x - 0.15f, this.transform.position.y, this.transform.position.z);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
