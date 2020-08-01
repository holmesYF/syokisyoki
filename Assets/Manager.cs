using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Manager: MonoBehaviour 
{
    #region Field
    public int AllCredit { get; private set; }
    public int HasCredit { get; }
    public Timer ElapsedTime = new Timer(1000); // 1秒ごとに関数を実行
    public int TermCounter { get; private set; } = 1;
    #endregion
    

    public static Manager Instance { get; private set; } = new Manager();
    private Manager()
    {
        ElapsedTime.Elapsed += new ElapsedEventHandler(CreateScene);
    }

    private void CreateScene(object sender, ElapsedEventArgs e)
    {
        TermCounter++;

    }

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void NotifyOnTouch(ParameterData parameterData)
    {
        
    }

}

