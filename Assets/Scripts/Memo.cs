/*
유닛 상태 패턴 설계

1. FSM을 사용하여, 유닛 상태를 관리 및 변경할 수 있는 각각의 클래스를 생성 필요 (EX : Idle, Move, Attack, Damaged 상태 등) 
2. 각각의 상태에서 연결되는 상태는 대부분 동일 (EX: Idle -> Move, Attack, Damaged, Die 상태로 전환 가능 Move -> Idle, Attack, Damaged, Die 상태로 전환 가능 등)
3. 각각의 상태에서 동작하는 부분은 유닛마다 다를 수 있으므로 상태 별 동작 메서드는 유닛 클래스안에서 구현 하도록 처리 

* Damaged, Die 상태는 어떤 상태에서던지 동작할 수 있는 상태이므로 Animator의 Any State 처럼 상태 머신에서 별도 처리 필요

*/