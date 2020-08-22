using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeStateManager
{
    public static string GetCurrentGrade(int term)
    {
        string result;
        if (term < 12)
        {
            result = "本科 " + (term / 2).ToString() + "年";

        }
        else if (term < 16)
        {
            result = "専攻科 " + ((term - 10) / 2).ToString() + "年";
        }
        else
            throw new System.Exception();

        if (term % 2 == 0)
        {
            result += " 前期";
        }
        else
            result += " 後期";

        return result ; 
    }

    public static int GetCreditLimit(int term)
    {
        if (term / 2 == 1)
            return 3;
        else if (term / 2 == 2)
            return 4;
        else if (term / 2 == 3)
            return 5;
        else if (term / 2 == 4)
            return 6;
        else if (term / 2 == 5)
            return 2;
        else if (term / 2 == 6)
            return 7;
        else if (term / 2 == 7)
            return 3;
        else
            throw new System.Exception();

    }
}

