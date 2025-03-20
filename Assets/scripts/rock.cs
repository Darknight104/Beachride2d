using System.Collections;
using System.Collections.Generic;
using JetBrains.Rider.Unity.Editor;
using UnityEngine;

public class rock : MonoBehaviour

{
    public GameObject rockexplode;
    private bool hitted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && hitted == false)
        {
            hitted = true;
            jumpcontrol.instance.damage();
            Instantiate(rockexplode, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "laser")
        {
            audiomanager.instance.explode();
            Instantiate(rockexplode, transform.position, Quaternion.identity);

            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
