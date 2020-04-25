using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{
    public InputField entrada; // valor ingresado
    public decimal value_decimal; //valor convertido a decimal
    public decimal tp; //tps
    public decimal sl; //StopLess

    public Text[] textTp;
    public Text[] textSL;

    public GameObject Wins;
    public GameObject Losses;
 
    public void CalculateScalping(string value)
    {
        value = entrada.text.ToString();
        value_decimal = decimal.Parse(value);

        Wins.SetActive(true);
        Losses.SetActive(true);

        //tps
        for (int i = 1; i < 10; i++) 
        {
            tp = (value_decimal * i / 100) + value_decimal;
            textTp[i].text = "TP " + i + "% -> " + tp.ToString();

        }

        for (int i = 1; i < 10; i++)
        {
            sl =  (value_decimal * i / 100) - value_decimal ;
            textSL[i].text = "SL " + i + "% -> " + sl.ToString();
        }
    }


}
