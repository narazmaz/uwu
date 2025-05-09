using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField]float VectorX ;
    [SerializeField]float VectorY = 0;
    [SerializeField]float VectorZ;
    [SerializeField]float Speed = 20 ;
    [SerializeField] InputAction actionJump;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        actionJump.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        VectorX = Input.GetAxis("Horizontal");
        VectorZ = Input.GetAxis("Vertical");
        transform.Translate(VectorX * Time.deltaTime * Speed, VectorY, VectorZ * Time.deltaTime * Speed);
    }
    private void FixedUpdate()
    {
        if (actionJump.IsPressed())
        {
            rb.AddForce(Vector3.up * 1000 * Time.fixedDeltaTime);
        }
    }
}
