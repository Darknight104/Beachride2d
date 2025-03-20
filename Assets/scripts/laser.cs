using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0f, 0f, 90f);
        Destroy(gameObject,15f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
