using System;
using System.Collections.Generic;

namespace AIScript.Monster.TowerDefense._12301;

public class Action : TowerCharacterBaseAI
{
	private int monsterId;

	private List<MonsterAdventureActor> monsters;

	private List<LogicEntity> entities;

	private Dictionary<int, Func<bool>> skillCondition;

	public override Dictionary<int, Func<bool>> SkillCondition
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public unsafe override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public unsafe Action()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 8;
		}
		_ = *(sbyte*)7400258890193968278uL;
		/*Error near IL_000d: Invalid calli metadata token*/;
	}
}
