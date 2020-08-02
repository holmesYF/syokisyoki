using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterData
{
    public int Score { get; private set; }
    public int BlackDepth { get; private set; }
    public float Speed { get; private set; }
    public int Credit { get; private set; }
    
    public ParameterData(int Score, int BlackDepth, float Speed, int Credit)
    {
        this.Score = Score;
        this.BlackDepth = BlackDepth;
        this.Speed = Speed;
        this.Credit = Credit;
    }

    public void Add(ParameterData newParameter)
    {
        this.Score += newParameter.Score;
        this.BlackDepth += newParameter.BlackDepth;
        this.Speed *= newParameter.Speed;
        this.Credit += newParameter.Credit;
    }

}
