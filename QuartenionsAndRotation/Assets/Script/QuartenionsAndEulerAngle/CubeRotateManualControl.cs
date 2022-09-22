using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeRotateManualControl : MonoBehaviour
{
    public Transform cubeOne, cubeTwo, cubeThree, cubeOrbitalYellowOne, cubeOrbitalYellowTwo;
    public Slider xSlider, ySlider, zSlider;
    public Slider xSliderAuto, ySliderAuto, zSliderAuto;


    private void Start()
    {
        xSlider.maxValue = 360;
        ySlider.maxValue = 360;
        zSlider.maxValue = 360;

        xSliderAuto.maxValue = 10;
        ySliderAuto.maxValue = 10;
        zSliderAuto.maxValue = 10;
    }

    private void Update()
    {
        cubeThree.Rotate(new Vector3(xSliderAuto.value, ySliderAuto.value, zSliderAuto.value), Space.Self);

        cubeOrbitalYellowOne.RotateAround(cubeOne.transform.position, Vector3.up, 55f * Time.deltaTime);
        cubeOrbitalYellowOne.LookAt(cubeOne.transform.position);

        cubeOrbitalYellowTwo.RotateAround(cubeOne.transform.position, Vector3.left, 55f * Time.deltaTime);
        
    }

    public void SetRotacaoManual()
    {
        //Sem diferença entre EulerAngles e Quaternion.Euler
        cubeOne.localEulerAngles = new Vector3(xSlider.value, ySlider.value, zSlider.value);
        cubeTwo.localRotation = Quaternion.Euler(xSlider.value, ySlider.value, zSlider.value);
    }


}
