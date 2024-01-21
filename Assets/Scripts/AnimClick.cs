using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class AnimClick : MonoBehaviour
{
    [SerializeField]
    private Camera camera;
    [SerializeField]
    private Animator animator;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if ((Physics.Raycast(ray, out hit)) && (hit.collider.gameObject.name == this.name))
            {
                animator.Play("penguin_atack");


            }
        }
    }
}
