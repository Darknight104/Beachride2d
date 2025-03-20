using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burger : MonoBehaviour
{
    private bool hitted=false;
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
        if (other.gameObject.tag == "Player" && hitted==false)
        {

            audiomanager.instance.eat();
            hitted = true;
            score.instance.UpdateScore(1);
            Destroy(gameObject);
        }
    }
}
