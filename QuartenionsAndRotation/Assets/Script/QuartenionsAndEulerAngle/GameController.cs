using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public CubeRotateManualControl cubes;

    //HUD
    public TextMeshProUGUI txtCubeOneTransform, txtCubeTwoTransform, txtCubeThreeTransform;
    public TextMeshProUGUI txtSliderX, txtSliderY, txtSliderZ;
    public TextMeshProUGUI txtSliderXAuto, txtSliderYAuto, txtSliderZAuto;


    public void SetResetScene()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        SetText();
    }
    public void SetText()
    {
        txtCubeOneTransform.text =
            $"<color=red>x:{cubes.cubeOne.localEulerAngles.x.ToString("F0")}</color>| " +
            $"<color=green>y: {cubes.cubeOne.localEulerAngles.y.ToString("F0")}</color>| " +
            $"<color=blue> z: {cubes.cubeOne.localEulerAngles.z.ToString("F0")}</color>";

        txtCubeTwoTransform.text = cubes.cubeTwo.localRotation.ToString("F2");
        txtCubeThreeTransform.text = cubes.cubeThree.localEulerAngles.ToString("F0");

        txtSliderX.text = cubes.xSlider.value.ToString("F0");
        txtSliderY.text = cubes.ySlider.value.ToString("F0");
        txtSliderZ.text = cubes.zSlider.value.ToString("F0");

        txtSliderXAuto.text = cubes.xSliderAuto.value.ToString("F0");
        txtSliderYAuto.text = cubes.ySliderAuto.value.ToString("F0");
        txtSliderZAuto.text = cubes.zSliderAuto.value.ToString("F0");


    }
}
