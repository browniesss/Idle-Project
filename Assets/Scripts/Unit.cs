using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    /// <summary>
    /// 공격시 호출
    /// </summary>
    public abstract void Attack();
    
    /// <summary>
    /// 피격시 호출
    /// </summary>
    public abstract void Damaged();
}
