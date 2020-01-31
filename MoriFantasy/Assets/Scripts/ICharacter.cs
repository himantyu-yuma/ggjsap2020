public interface ICharacter
{
    /// <summary>
    /// ダメージ受けたときに呼び出される関数
    /// </summary>
    /// <param name="damage">ダメージ量</param>
    void Damage(int damage);
    /// <summary>
    /// 回復されるときに呼び出される関数
    /// </summary>
    /// <param name="repair">回復量</param>
    void Repair(int repair);
}
