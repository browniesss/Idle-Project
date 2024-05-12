using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [Header("Unit Status")] 
    [SerializeField] protected int hp;
    [SerializeField] protected float moveSpeed = 1f;
    [SerializeField] protected float attackSpeed = 1f;
    [SerializeField] protected float attackRange = 5f;

    [Header("Other Info")]
    [SerializeField] protected GameObject target;
    
    public State state;

    protected StateMachine stateMachine;
    
    /// <summary>
    /// 공격시 호출
    /// </summary>
    public abstract void Attack();
    
    /// <summary>
    /// 피격시 호출
    /// </summary>
    public abstract void Damaged();

    /// <summary>
    /// 공격할 타겟 탐색
    /// </summary>
    public abstract bool SearchTarget();

    /// <summary>
    /// 이동 처리
    /// </summary>
    public abstract void Move();
    
    /// <summary>
    /// 타겟이 공격 범위안으로 들어왔는지 여부 반환
    /// </summary>
    public abstract bool IsTargetInRange();

    /// <summary>
    /// Die 처리 여부 반환
    /// </summary>
    public virtual bool IsDie()
    {
        return hp <= 0;
    }
}
