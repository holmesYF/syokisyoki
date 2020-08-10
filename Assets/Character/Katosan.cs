using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Katosan : MonoBehaviour
{
    public ParameterData ParameterData { get; private set; } = new ParameterData(0,0,0.3f,0);
    public static Katosan Instance { get; } = new Katosan();
    private Strategy strategy;


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
        strategy.set_pos(this.gameObject.transform.position);
        strategy.set_paramater(this.ParameterData);
        this.transform.position = strategy.get_pos();

    }

    public void set_strategy(Strategy strategy)
    {
        this.strategy = strategy;
    }
}
