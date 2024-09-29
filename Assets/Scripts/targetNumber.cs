using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class targetNumber : MonoBehaviour
{
    public Text txtTargetNumber1;
    public Text txtTargetNumber2;
    public Text txtTargetNumber3;
    private int targetNumber1;
    private int targetNumber2;
    private int targetNumber3;
    void Start()
    {
        generateNumber();
    }

    private void generateNumber()
    {
        targetNumber1 = Random.Range(1, 10);
        targetNumber2 = Random.Range(1, 10);
        targetNumber3 = Random.Range(1, 10);
        txtTargetNumber1.text = "x" + targetNumber1.ToString();
        txtTargetNumber2.text = "x" + targetNumber2.ToString();
        txtTargetNumber3.text = "x" + targetNumber3.ToString();
    }
}
