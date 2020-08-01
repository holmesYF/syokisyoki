using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katosan : MonoBehaviour
{
    public ParameterData ParameterData { get; private set; } = new ParameterData(0,0,0,0);
    public static Katosan Instance { get; } = new Katosan();

    private Katosan()
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
        // 油布の担当場所
        // Parameter.Speedの速度で、左右に動く
    }
}
