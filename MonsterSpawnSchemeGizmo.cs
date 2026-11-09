using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnSchemeGizmo : BaseSpawnPointGizmo
{
	[HideInInspector]
	public bool isElite;

	public bool enableRoguelikeFloorCondition;

	public int activeMinFloor;

	public int activeMaxFloor;

	public MonsterSpawnSchemeGizmo preRefreshScheme;

	public void OnValueChanged()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public override void EnableSpawnLogic()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/>> 3;
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		_ = (sbyte)null;
		_ = 35;
		/*Error near IL_000a: Unknown opcode: 0xF1*/;
	}

	public override void ResetSpawnState()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/>> 5;
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		_ = ~null;
		_ = 35;
		/*Error near IL_000a: Unknown opcode: 0xF1*/;
	}

	public override bool CheckActiveConditions()
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public override bool IsAllActivedAndDied()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/+ 0;
			/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public override bool IsAllActivedAndDied_NoSummons()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/+ 0;
			/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public override List<long> GetSpawnedEntities()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected Obj, but got I
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			List<long> list = (List<long>)(nint)0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public MonsterSpawnSchemeGizmo()
	{
		/*Error: Invalid field token*/;
	}
}
