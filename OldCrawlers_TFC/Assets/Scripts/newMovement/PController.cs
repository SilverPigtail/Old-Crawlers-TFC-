using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PController : MonoBehaviour
{
    private Rigidbody2D cBody;
    private Animator cAnimator;

    [SerializeField]
    private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        cBody = GetComponent<Rigidbody2D>();
        cAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        cBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
        
        cAnimator.SetFloat("moveX", cBody.velocity.x);
        cAnimator.SetFloat("moveY", cBody.velocity.y);

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            cAnimator.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            cAnimator.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
    }
}
