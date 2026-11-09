using UnityEngine;

[AddComponentMenu("触发器结果/玩家事件/主控角色释放指定槽位技能", 1)]
public class Task_PlayerCastSkill : TaskCellBase
{
	public enum SkillType
	{
		[InspectorName("技能")]
		skill,
		[InspectorName("大招")]
		ultimate
	}

	public SkillType skillType;

	protected override void OnExecute()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public Task_PlayerCastSkill()
	{
		/*Error: Invalid field token*/;
	}
}
