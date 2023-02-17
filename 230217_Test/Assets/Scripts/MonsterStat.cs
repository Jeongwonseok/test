using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterStat", menuName = "Scriptable Object Asset/MonsterStat")]
public class MonsterStat : ScriptableObject
{
    public int moveSpeed = 10;
    public int view = 20;
}
