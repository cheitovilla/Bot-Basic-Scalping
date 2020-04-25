using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profit : MonoBehaviour
{
    public InputField priceIn;
    public InputField priceOut;
    public Text textResult;
    public decimal buyIn;
    public decimal sellOut;
    public decimal rest;
    public decimal total, R;
    public int porcentaje;
    // Start is called before the first frame update
   
    public void CalculateProfittotal()
    {
        buyIn = decimal.Parse(priceIn.text);
        sellOut = decimal.Parse(priceOut.text);
        rest = sellOut - buyIn;
        total = rest / buyIn;
        R = total * 100;
        textResult.text =  R.ToString("F2") + "%";
    }

}
