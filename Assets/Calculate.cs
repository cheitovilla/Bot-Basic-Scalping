﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{
    public InputField entrada; // valor ingresado
    public decimal value_decimal; //valor convertido a decimal
    public decimal tp; //tps
    public decimal sl; //StopLess

    public void CalculateScalping(string value)
    {
        value = entrada.text.ToString();
        value_decimal = decimal.Parse(value);
        Debug.Log("Valaor decimal: " + value_decimal);

        //tps
        for (int i = 1; i < 100; i++) 
        {
            tp = (value_decimal * i / 100) + value_decimal;
            Debug.Log("tp" + i + "% -> " + tp);
        }

        for (int i = 1; i < 100; i++)
        {
            sl = (value_decimal * i / 100) - value_decimal;
            Debug.Log("Stop Less" + i + "% -> " + sl);
        }
    }


}
