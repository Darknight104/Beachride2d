using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu : MonoBehaviour
{
    public GameObject controls, spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startgame()
    {
        controls.SetActive(true);
        spawn.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
