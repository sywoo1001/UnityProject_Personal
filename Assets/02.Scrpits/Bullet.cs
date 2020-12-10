using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    ButtonUI btnui;
    float power = 17.0f;
    // Use this for initialization
    void Start()
    {
        btnui = GameObject.Find("UIManager").GetComponent<ButtonUI>();
        Vector3 velocity = transform.forward * power;
        GetComponent<Rigidbody>().AddForce(velocity * power);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (transform.position.y < 0f)
        {
            Destroy(this.gameObject, 1.5f);
            btnui.Break = true;
            btnui.Check();
        }
    }
}
