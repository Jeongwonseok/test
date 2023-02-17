using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public MonsterStat stat;

    private void OnEnable()
    {
        Debug.LogWarning("Human=MoveSpeed : " + stat.moveSpeed + " " + "view : " + stat.view);
    }
}
