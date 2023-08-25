using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Joystick js;
    private float xinput, yinput;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xinput = js.Horizontal;
        yinput = js.Vertical;
        rb.velocity = new Vector3(xinput*40, 0f, yinput*40);
    }
}
