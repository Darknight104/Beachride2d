using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundscroll : MonoBehaviour
{
    private Renderer rend;
    public float speed = 0.6f;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0f);
        rend.material.mainTextureOffset = offset;
    }
}
