using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : MonoBehaviour
{
    public OrcMonsterStat stat;

    private void OnEnable()
    {
        Debug.LogWarning("Orc=MoveSpeed : " + stat.moveSpeed + " " + "view : " + stat.view + " " + "atk : " + stat.atk);
    }
}
