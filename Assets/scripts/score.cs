using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class score : MonoBehaviour
{
    public TMP_Text Score ;
    private int _Score;
    public static score instance;
    public Image life;
    public Sprite[] lives;
    public GameObject endpanel;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    // Update is called once per frame
   public void UpdateScore(int num)
    {
        _Score += num;
        Score.text = "Score:" + _Score;
    }
    public void update_life(int n)
    {
        life.sprite = lives[n]; 
    }
    public void showendpanel()
    {
        endpanel.SetActive(true);
        audiomanager.instance.gameover();
    }
    public void retrygame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}