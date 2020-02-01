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
    /// WarriorStatus参照
    /// 今のところ0=Attack,1=Deffence
    /// </summary>
    public int WarriorType = 0;
    /// <summary>
    /// どっちのチームか
    /// 1=1P，2=2P
    /// </summary>
    public int TeamID = 1;

    /// <summary>
    /// 戦士のアニメーターコントローラー
    /// </summary>
    public Animator WarriorAnimator = default;

    /// <summary>
    /// 初期化処理
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// 毎フレーム行う処理
    /// </summary>
    void Update()
    {
        
    }

    /// <summary>
    /// 何かに衝突した時に起きる処理
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        
    }

    /// <summary>
    /// 移動処理（賢者から呼び出し）
    /// </summary>
    public void MoveWarrior()
    {

    }

    /// <summary>
    /// 敵戦士を攻撃する処理
    /// </summary>
    public void AttackWarrior()
    {

    }

    /// <summary>
    /// 敵塔を攻撃する処理
    /// </summary>
    public void AttackTower()
    {

    }

    /// <summary>
    /// 敵戦士からダメージ受ける処理
    /// </summary>
    /// <param name="damage">ダメージ量</param>
    public void Damage(int damage)
    {

    }

    /// <summary>
    /// 賢者から回復受ける処理
    /// </summary>
    /// <param name="repair">回復量</param>
    public void Repair(int repair)
    {

    }

    IEnumerator Death(int respawnTime)
    {
        yield return new WaitForSeconds(respawnTime);
        Respawn();
    }

    public void Respawn()
    {

    }

}
