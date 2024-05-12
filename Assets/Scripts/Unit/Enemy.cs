using UnityEngine;

public class Enemy : Unit
{
    /// <summary>
    /// 시작 시 상태 머신 생성 및 설정
    /// </summary>
    private void Start()
    {
        stateMachine = new StateMachine(this);
    }

    /// <summary>
    /// 공격 처리
    /// </summary>
    public override void Attack()
    {
        
    }

    /// <summary>
    /// 피격 처리
    /// </summary>
    public override void Damaged()
    {
        
    }

    /// <summary>
    /// 타겟 탐색
    /// </summary>
    public override bool SearchTarget()
    {
        // TODO : 아래 부분 Find 사용하지 않도록 이후에 개선 필요
        var players = GameObject.FindGameObjectsWithTag("Player");
        float closestDistance = Mathf.Infinity;
        GameObject closestPlayer = null;

        foreach (var player in players)
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestPlayer = player;
            }
        }

        target = closestPlayer;

        return target != null;
    }
    
    /// <summary>
    /// 타겟이 공격 범위 안으로 들어왔는지 체크
    /// </summary>
    public override bool IsTargetInRange()
    {
        return Vector3.Distance(transform.position, target.transform.position) <= attackRange;
    }
    
    /// <summary>
    /// 이동 처리
    /// </summary>
    public override void Move()
    {
        // 타겟 위치로 이동
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
    }

    private void Update()
    {
        if (stateMachine != null)
        {
            stateMachine.PlayMachine();
        }
    }
}
