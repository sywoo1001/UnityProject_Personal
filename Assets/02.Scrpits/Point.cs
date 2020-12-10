using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Point : MonoBehaviour {
    public GameObject Points;
    public Transform PointSet;
    public int i;
    float ranx;
    float ranz;
    // Use this for initialization
    void Start () {
        for(i=0; i<15; i++)
        {
            ranx = Random.Range(-13.5f, 13.5f);
            ranz = Random.Range(-13.5f, 13.5f);
            PointSet.position = new Vector3(ranx, 0.1f, ranz);
            Instantiate(Points, PointSet.position, PointSet.rotation);
            
        }
	}
	
	// Update is called once per frame
	void Update () {
        if(i < 15)
        {
            while(i < 15)
            {
                ranx = Random.Range(-13.5f, 13.5f);
                ranz = Random.Range(-13.5f, 13.5f);
                PointSet.position = new Vector3(ranx, 0.1f, ranz);
                Instantiate(Points, PointSet.position, PointSet.rotation);
                i++;
            }
        }
	}

}
