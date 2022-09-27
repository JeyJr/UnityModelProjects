using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public PlayerAttributes playerAttributes;
    public Slider sliderAtkPower, sliderCritRange, sliderCritMult;
    public Text textAtkPower, textCritRange, textCritMult;

    private void Start()
    {
        sliderAtkPower.maxValue = 1000;
        sliderAtkPower.minValue = 1;

        sliderCritRange.maxValue = 100;
        sliderCritMult.maxValue = 10;
    }

    private void Update()
    {
        playerAttributes.AtkPower = Mathf.RoundToInt(sliderAtkPower.value);
        playerAttributes.CritRange = Mathf.RoundToInt(sliderCritRange.value);
        playerAttributes.CritMult = Mathf.RoundToInt(sliderCritMult.value);

        textAtkPower.text = $"Atk Power: {playerAttributes.AtkPower}";
        textCritRange.text = $"Crit Range: {playerAttributes.CritRange}";
        textCritMult.text = $"Crit Mult: {playerAttributes.CritMult}";
    }

    public void BtnAction()
    {
        playerAttributes.IsAtk = !playerAttributes.IsAtk;
        playerAttributes.anim.SetBool("isAtk", playerAttributes.IsAtk);
    }
}
