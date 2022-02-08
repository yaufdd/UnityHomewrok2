using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HomeWorkL3 : MonoBehaviour
{
  [Header("�������� ����������  ")]
  [Tooltip("0-255 (1����)")]
  public byte tempByte = 1;
  public sbyte tempSbyte = 2;             // -+   -128 127                    (1����)
  public short tempShort = 3;             // -+   -32768 32767                (2�����)
  public ushort tempUshort = 4;           // +    65535                       (2�����)
  public int tempInt = 5;                 // -+                               (4�����)
  public uint tempUint = 6u;              // +    0-4294968295                (4�����)
  public long tempLong = 7L;              // -+                               (8�����)
  public ulong tempUlong = 8ul;           // +                                (8�����)

  [Header("� ��������� ������  ")]
  public float tempFloat = 1f;            // -+                               (4�����)
  public double tempDouble = 1;           // -+                               (8�����)
  public decimal tempDecimal = 1m;        // -+                               (8�����)


  [Header("��������� ����������  ")]
  public char tempChar = 'a';
  public string tempString = "qwe";


  [Header("���������� ")]
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

    // ����� �������������� � int
    int i = (int)tdouble;
    Debug.Log($" {i.GetType()} = {i}");

    // �� ����� �������������� � ushort
    byte a = 3;
    ushort temp3 = a;
    Debug.Log($"temp3 {temp3.GetType()} = {temp3}");


    // �� ����� �������������� � string
    string ttt = "text 5";
    ttt += tdouble;
    Debug.Log($" {ttt.GetType()} = {ttt}");


    // ����� �������������� 
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
