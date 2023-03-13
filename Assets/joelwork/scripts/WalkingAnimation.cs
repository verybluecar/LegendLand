using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingAnimation : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("PushUp", true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("PushUp", false);
        }
        if (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown(KeyCode.S) || (Input.GetKeyDown(KeyCode.A)))))
        {
            anim.SetBool("isWalking", true);
        }

        if (Input.GetKeyUp(KeyCode.W) || (Input.GetKeyUp(KeyCode.D) || (Input.GetKeyUp(KeyCode.S) || (Input.GetKeyUp(KeyCode.A)))))
        {
            anim.SetBool("isWalking", false);
        }
    }
}
