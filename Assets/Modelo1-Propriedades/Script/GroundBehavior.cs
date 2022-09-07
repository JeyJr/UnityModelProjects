using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundBehavior : MonoBehaviour
{
    private Slider lifeBar;
    [SerializeField] private int _life;
    public int Life
    {
        get { return _life; }
        set {
            _life -= value;
            lifeBar.value = _life;
        }
    }

    private void Start()
    {
        _life = 100;

        //lifeBar Control
        lifeBar = gameObject.GetComponentInChildren<Canvas>().GetComponentInChildren<Slider>();
        lifeBar.maxValue = _life;
        lifeBar.value = lifeBar.maxValue;
    }
}
