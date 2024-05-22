using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody PlayerRB;
    [SerializeField]
    float speed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal")/2);
    }

    private void FixedUpdate()
    {
        PlayerRB.velocity = Input.GetAxis("Vertical") * transform.forward * speed* (PlayerRB.position.y + 1.45f);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {

            PlayerRB.AddForce(new Vector3(0, 3000, 0));
        }
    }
}
