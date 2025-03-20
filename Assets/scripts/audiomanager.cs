using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    private AudioSource jumpaudio, hitaudio, shootaudio, eataudio, gameoveraudio, explodeaudio;
    public AudioClip jumpaudioClip,hitclip,shootclip,eataudioClip,gameoveraudioClip,explodeaudioClip;
    public static audiomanager instance;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        jumpaudio = gameObject.AddComponent<AudioSource>();
        hitaudio = gameObject.AddComponent<AudioSource>();
        shootaudio = gameObject.AddComponent<AudioSource>();
        eataudio = gameObject.AddComponent<AudioSource>();
        gameoveraudio = gameObject.AddComponent<AudioSource>();
        explodeaudio = gameObject.AddComponent<AudioSource>();
        jumpaudio.clip = jumpaudioClip;
        hitaudio.clip = hitclip;
        shootaudio.clip = shootclip;
        eataudio.clip = eataudioClip;
        gameoveraudio.clip = gameoveraudioClip;
        explodeaudio.clip = explodeaudioClip;   
        

    }

    // Update is called once per frame
    public void playgame()
    {
        jumpaudio.Play();
    }    public void hit()
    {
        hitaudio.Play();
    }    public void shoot()
    {
        shootaudio.Play();
    }    public void eat()
    {
        eataudio.Play();
    }    public void gameover()
    {
        gameoveraudio.Play();
    }    public void explode()
    {
        explodeaudio.Play();
    }
}
