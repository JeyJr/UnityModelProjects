using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAttributes : MonoBehaviour
{

    public Material[] _material;
    public MeshRenderer _meshRenderer;

    [SerializeField] private int _life ;
    [SerializeField] private int _power ;

    private void Start()
    {
        _life = Random.Range(1, 11);
        _power = Random.Range(1, 11);

        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.material = _material[0];
    }


    public int life
    {
        get { return _life; }
        set { _life = value; }
    }
    public int power
    {
        get { return _power; }
        set { _power = value; }
    }
    public Material meshRenderer
    {
        get
        {
            return _meshRenderer.material;
        }
        set
        {
            _meshRenderer.material = value;
        }
    }

}
