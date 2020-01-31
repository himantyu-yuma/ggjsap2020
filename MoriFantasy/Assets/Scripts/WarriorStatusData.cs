using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class WarriorStatusData : ScriptableObject
{
    //ListステータスのList
    public List<WarriorStatus> EnemyStatusList = new List<WarriorStatus>();
}

/// <summary>
/// 戦士のパラメータのクラス
/// </summary>
[System.Serializable]
public class WarriorStatus
{
    /// <summary>
    /// 攻撃型などの戦士のタイプ
    /// </summary>
    public string Name = "タイプ";
    /// <summary>
    /// 体力，攻撃力，防御力
    /// </summary>
    public int HP = 100,Atk = 15, Def = 15;
}