using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeStateManager
{
    public static string GetCurrentGrade(int term)
    {
        string result;
        if(term > 15)
        {
            throw new System.Exception();
        }
        else if (term  < 12)
        { 
            result = "本科 " + (term/2).ToString() + "年";

        }
        else
        {
            result = "専攻科 " + ((term-10)/2).ToString() + "年";
        }

        if (term % 2 == 0)
        {
            result += " 前期";
        }
        else
            result += " 後期";

        return result ; 
    }
}

