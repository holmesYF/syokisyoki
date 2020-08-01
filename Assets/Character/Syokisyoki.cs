using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syokisyoki : MonoBehaviour
{
    public Syokisyoki Instance { get; } = new Syokisyoki();
    public ParameterData ParameterData { get; private set; } = new ParameterData(0,0,0,0);


    private Syokisyoki()
    {

    }

    public void UpdateParameterData(ParameterData parameterData)
    {
        this.ParameterData.Add(parameterData);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
