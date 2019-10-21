using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyoheiTest : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;
    private Vector3 velocity;

    [SerializeField]
    private float freq = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        velocity.x = speed * Mathf.Cos(2 * Mathf.PI * Time.time / freq) * Time.deltaTime;
        transform.position += velocity;
    }
}
