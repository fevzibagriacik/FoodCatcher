using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countScore : MonoBehaviour
{
    public int score;
    public Text txtScore;
    public spawnFood spawnFood;
    public spawnTargetFood targetFood;
    public spawnTargetFood targetFood2;
    public spawnTargetFood targetFood3;
    void Start()
    {
        //spawnFood = GetComponent<spawnFood>();
        //targetFood = GetComponent<spawnTargetFood>();
        //targetFood2 = GetComponent<spawnTargetFood>();
        //targetFood3 = GetComponent<spawnTargetFood>();

        score = 0;
        txtScore.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);

        ScoreUp();

        if (other.gameObject.tag == "targetFood")
        {
            ScoreUp();
        }
        else if (other.gameObject.tag == "targetFood2")
        {
            ScoreUp();
        }
        else if (other.gameObject.tag == "targetFood3")
        {
            ScoreUp();
        }
        else
        {
            ScoreDown();
        }
    }

    void ScoreUp()
    {
        score++;
        txtScore.text = score.ToString();
    }

    void ScoreDown()
    {
        score--;
        txtScore.text = score.ToString();
    }

    //bool IsDesiredFood(Sprite targetFoodTag)
    //{
    //    foreach(Sprite targetFood in spawnFood.foods)
    //    {
    //        if(targetFoodTag == targetFood || targetFoodTag == targetFood2 || targetFoodTag == targetFood3)
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}
}
