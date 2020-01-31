using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour,ICharacter
{
    /// <summary>
    /// 戦士の体力
    /// </summary>
    public int HitPoint = 100;
    /// <summary>
    /// 戦士の攻撃力
    /// </summary>
    public int AttackPower = 10;
    /// <summary>
    /// 戦士の防御力
    /// </summary>
    public int GuardPower = 10;
    /// <summary>
    /// 戦士のタイプ
    /// </summary>
    public string WarriorType = "";
    /// <summary>
    /// どっちのチームか
    /// </summary>
    public int TeamID = 0;

    public void Damage(int damage)
    {
    }

    public void Repair(int repair)
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
