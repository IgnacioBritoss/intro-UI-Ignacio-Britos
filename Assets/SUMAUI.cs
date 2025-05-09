using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SUMAUI : MonoBehaviour
{

    public TextMeshProUGUI txtresultado;
    public TMP_InputField inputnum1;
    public TMP_InputField inputnum2;
    int num1;
    int num2;

    // Start is called before the first frame update
    void Start()
    {
        txtresultado.text = "";
    }

   public void SumaryMostrar()
    {
        num1 = int.Parse( inputnum1.text);
        num2 = int.Parse(inputnum2.text);
        txtresultado.text =  (num1 + num2).ToString();
    }
}
