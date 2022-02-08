using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HomeWorkL3 : MonoBehaviour
{
  [Header("числовые переменные  ")]
  [Tooltip("0-255 (1байт)")]
  public byte tempByte = 1;
  public sbyte tempSbyte = 2;             // -+   -128 127                    (1байт)
  public short tempShort = 3;             // -+   -32768 32767                (2байта)
  public ushort tempUshort = 4;           // +    65535                       (2байта)
  public int tempInt = 5;                 // -+                               (4байта)
  public uint tempUint = 6u;              // +    0-4294968295                (4байта)
  public long tempLong = 7L;              // -+                               (8байта)
  public ulong tempUlong = 8ul;           // +                                (8байта)

  [Header("с плавающей точкой  ")]
  public float tempFloat = 1f;            // -+                               (4байта)
  public double tempDouble = 1;           // -+                               (8байта)
  public decimal tempDecimal = 1m;        // -+                               (8байта)


  [Header("строковые переменные  ")]
  public char tempChar = 'a';
  public string tempString = "qwe";


  [Header("логический ")]
  public bool tempBool = true;



  // Start is called before the first frame update
  void Start()
  {
    myFunc();
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void myFunc()
  {
    //Console.WriteLine($"asd");

    double tdouble = 2.5;

    // явное преобразование в int
    int i = (int)tdouble;
    Debug.Log($" {i.GetType()} = {i}");

    // не явное преобразование в ushort
    byte a = 3;
    ushort temp3 = a;
    Debug.Log($"temp3 {temp3.GetType()} = {temp3}");


    // не явное преобразование в string
    string ttt = "text 5";
    ttt += tdouble;
    Debug.Log($" {ttt.GetType()} = {ttt}");


    // явное преобразование 
    bool tbool = Convert.ToBoolean(tdouble);
    Debug.Log($" {tbool.GetType()} = {tbool}");




    string text = " tempByte = " + tempByte +
        ", tempSbyte = " + tempSbyte +
        ", tempShort = " + tempShort +
        ", tempUshort = " + tempUshort +
        ", tempInt = " + tempInt +
        ", tempUint = " + tempUint +
        ", tempUshort = " + tempUshort +
        ", tempLong = " + tempLong +
        ", tempUlong = " + tempUlong +
        ", tempFloat = " + tempFloat +
        ", tempDouble = " + tempDouble +
        ", tempDecimal = " + tempDecimal +
        ", tempChar = " + tempChar +
        ",\n tempString = " + tempString +

        ", tdouble = " + tdouble +
        ", i = " + i +
        ", temp3 = " + temp3 +
        ", ttt = " + ttt +
        ", tbool = " + tbool
        ;

    Debug.Log(text);



    //string path = @"D:\fileHW.txt";
    string path = "fileHW.txt";
    FileInfo fileInf = new FileInfo(path);

    string sss = "";
    if (fileInf.Exists)
    {
      using (StreamReader sr = fileInf.OpenText())
      {
        sss = sr.ReadToEnd();
        Debug.Log(sss);
      }
    }
    sss += text;

    using (StreamWriter sw = File.CreateText(path))
    {
      sw.WriteLine(sss);
    }



  }

}
