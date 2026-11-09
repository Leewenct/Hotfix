using System.Collections.Generic;
using TrueSync;

namespace AIScript.Monster.TowerDefense._15601;

public class Parallel : TowerCharacterParalletBase
{
	private int hitTag_Boom;

	private FP summonOffset_Skill;

	private int summonedId;

	private SummonCfg summonCfg_Summon;

	private int summonEvt;

	private int hasP3;

	private const int perkId_2 = 1560102;

	private int buffId_2;

	private const int perkId_3 = 1560103;

	private int buffId_3;

	public FP modelScale_Summoned_3;

	private Dictionary<int, int> _dicPerkCd;

	public override Dictionary<int, int> dicPerkCd
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public override void OnHitPost(AdventureActorReceiveDamageEvent evt, MonsterAdventureActor monster, bool isSelf)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public override void OnCustomEvent(AdventureActorCustomEvent evt)
	{
	}

	public override void OnBulletFinish(AdventureBulletFinishEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ > (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = ((ushort[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/];
		/*Error near IL_000a: Unknown opcode: 0xBD*/;
	}

	public unsafe Parallel()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xA7*/;
	}
}
