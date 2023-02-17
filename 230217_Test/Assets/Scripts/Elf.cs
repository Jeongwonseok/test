using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : MonoBehaviour
{
    public MonsterStat stat;

    private void OnEnable()
    {
        Debug.LogWarning("Elf=MoveSpeed : " + stat.moveSpeed + " " + "view : " + stat.view);
    }
}
