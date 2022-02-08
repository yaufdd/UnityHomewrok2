using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System;

public class Lesson4 : MonoBehaviour
{
  float[] squareMas = new float[] { 2, 2, 3, 4, 5, 6, 7 };
  bool check = true;
  float number = 7;
  void Start()
  {

    Task123();
    Task4(number);
    Task5(ref number);
    Debug.Log($"ref number = {number}");
    Task6(out number);
    Debug.Log($"out number = {number}");


  }



  void Task123()
  {
    if (check)
    {
      for (int i = 1; i < 7; i++)
      {
        squareMas[i] = Mathf.Pow(squareMas[i - 1], 2);
        Debug.Log(squareMas[i]);
      }
    }
    Debug.LogWarning("task 123 done");
  }
    void Task4(float number)
  {
    squareMas[0] = number;

    for (int i = 1; i < 7; i++)
    {
      squareMas[i] = Mathf.Pow(squareMas[i - 1], 2);
      Debug.Log(squareMas[i]);
    }
    number = (int)squareMas[2];
    Debug.LogWarning($"task 4 done number = {number}");
  }



  void Task5(ref float num)
  {
    squareMas[0] = num;

    for (int i = 1; i < 7; i++)
    {
      squareMas[i] = Mathf.Pow(squareMas[i - 1], 2);
      Debug.Log(squareMas[i]);
    }
    num = squareMas[4];
    Debug.LogWarning($"task 5 done number = {num}");

  }
  void Task6(out float num)
  {
    num = 0;
    squareMas[0] = num;

    for (int i = 1; i < 7; i++)
    {
      squareMas[i] = Mathf.Pow(squareMas[i - 1], 2);
      Debug.Log(squareMas[i]);
    }
    num = squareMas[4];
    Debug.LogWarning($"task 6 done number = {num}");

  }
}
