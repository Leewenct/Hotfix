using System;
using System.Collections.Generic;
using TrueSync;

namespace AIScript.Disc;

public class Disc_213018 : DiscScriptBase
{
	private const int discId = 213018;

	private List<int> skillId_s1;

	private const int num_sc = 4021000;

	private const int power_sc = 4021001;

	private const int cd_sc = 4021002;

	private List<int> skillId_s2;

	private const int onceID = 4021100;

	private const int onceID2 = 4021101;

	private int skill1_level;

	private int skill2_level;

	private FP power_value;

	private FP cd_value;

	private int num_value;

	private int currntNum;

	private readonly Dictionary<long, FP> _personTriggerTimeDic;

	public bool CheckPersonCd(long uid, FP Cd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	protected override void OnDiscEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 1u;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnDiscDisable()
	{
		/*Error: Invalid field token*/;
	}

	protected unsafe override void OnPlayerActorKill(PlayerAdventureActor actor, MonsterAdventureActor target, AdventureActorDiedEvent diedEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(long*)(nint)/*Error near IL_0007: Stack underflow*/;
	}

	protected unsafe override void OnBeforePlayerActorHit(PlayerAdventureActor actor, MonsterAdventureActor target, AdventureActorReceiveDamageBeforeHitEvent damageEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(long*)(nint)/*Error near IL_0007: Stack underflow*/;
	}

	public unsafe Disc_213018()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*// (nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}
}
