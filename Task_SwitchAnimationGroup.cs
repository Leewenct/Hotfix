using UnityEngine;

[AddComponentMenu("触发器结果/玩家事件/角色切換动画组", 0)]
public class Task_SwitchAnimationGroup : TaskCellBase
{
	public int animGroupIndex;

	public int actorId;

	public AnimationClip switchClip;

	public AnimationClip resetClip;

	protected override void OnExecute()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public Task_SwitchAnimationGroup()
	{
		/*Error: Invalid field token*/;
	}
}
