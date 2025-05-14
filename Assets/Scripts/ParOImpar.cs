using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ParOImpar : MonoBehaviour
{
    public TextMeshProUGUI resultado;
    public TMP_InputField input;
    int num1;

    // Start is called before the first frame update
    void Start()
    {
        resultado.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EsPar()
    {
        num1 = int.Parse(input.text);
        if (num1 % 2 == 0)
        {
            resultado.text = "El número es par";
        }
        else
        {
            resultado.text = "El número es impar";
        }
    }
}