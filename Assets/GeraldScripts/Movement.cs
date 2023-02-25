using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime * Input.GetAxisRaw("Horizontal"));
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical"));

        
    }
}