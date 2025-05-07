using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class SumaManager : MonoBehaviour
{
    public TextMeshProUGUI Resultado;
    public TMP_InputField num1;
    public TMP_InputField num2;

    // Start is called before the first frame update
    void Start()
    {
        Resultado.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Sumar()
    {
        int n1 = int.Parse(num1.text);
        int n2 = int.Parse(num2.text);
        int resultado = n1 + n2;
        Resultado.text = resultado.ToString();
    }
}