using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class jumpcontrol : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpforce;
    private bool isgrounded;
    [SerializeField]
    private GameObject Laser;
    private int player_Damage =3;
    public static jumpcontrol instance;
     void Awake()
    {
        instance = this;        
    }

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void jumpRider()
    {
        if (isgrounded) {
            audiomanager.instance.playgame();
            rb.freezeRotation = true;
            rb.AddForce(new Vector2(0f, jumpforce));
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag=="ground")
        {
            isgrounded = true; 
        }
    }
    public void OnCollisionExit2D(Collision2D other)

    {
        if (other.gameObject.tag == "ground")
        {
            isgrounded = false;
        }
    }
   public void Shoot()
    {
        audiomanager.instance.shoot();
        Vector3 pos= new Vector3(1f,0f,0f);
        Instantiate(Laser,transform.position+pos,Quaternion.identity);
    }
    public void damage()
    {
        audiomanager.instance.hit();
        player_Damage = player_Damage - 1;
        score.instance.update_life(player_Damage);
        if (player_Damage == 0)
        {
            score.instance.showendpanel();gameObject.SetActive(false);
        }
    }
}
