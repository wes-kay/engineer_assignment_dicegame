using TMPro;
using UnityEngine;

public class DiceView : GameValidation
{
    [SerializeField]
    TextMeshProUGUI value1Text, value2Text, valueText;
    byte value1, value2;
    bool setValue = false;

    void Start()
    {
        CheckComponent(value1Text);
        CheckComponent(value2Text);
        GameManager.diceView = this;
    }

    public void SetValue(byte value)
    {
        if(!setValue)
        {
            setValue = true;
            value1 = value;
            value1Text.text = value.ToString(); 
        }
        else
        {
            value2 = value;
            value2Text.text = value.ToString();
            valueText.text = (value1 + value2).ToString();
        }
    }


    public void Reset()
    {
        value1 = 0;
        value2 = 0;
        value1Text.text = "-";
        value2Text.text = "-";
        valueText.text = "";
    }
}
