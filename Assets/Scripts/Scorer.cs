using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    public GameObject[] score_objects;
    public GameObject game_score_object;
    int score = 0;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit")
        {
            score ++;
            Debug.Log($"Score: {score}");
        }
    }
    void Start()
    {
        score_objects = GameObject.FindGameObjectsWithTag("Scoreboard");
        game_score_object = score_objects[0];
        
    }
    void Update()
    {
        game_score_object.GetComponent<Text>().text = score.ToString();
    }
}
