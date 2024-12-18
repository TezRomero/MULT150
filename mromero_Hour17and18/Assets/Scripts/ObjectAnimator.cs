using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAnimator : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("ColorChangeTrigger");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("ScaleChangeTrigger");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("SpinTrigger");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("HoverTrigger");
        }
    }
}
