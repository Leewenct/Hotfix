using System;
using System.Collections.Generic;
using TrueSync;

namespace AIScript.Monster.TowerDefense._10701;

public class Parallel : TowerCharacterParalletBase
{
	private int shieldTag_hit;

	public const string shieldKey_monster = "Bullet_107_Shield_ToMonster";

	private readonly string shieldKey_player;

	private int buffId_player;

	public const int perkId_1 = 1070101;

	public static readonly FP time_1;

	private const int perkId_2 = 1070102;

	private const int buff_2 = 801070020;

	public const int perkId_3 = 1070103;

	public const string aoe_3 = "AreaEffect_107_BuffArea";

	public const int perkId_4 = 1070104;

	public const int count_5 = 5;

	private Dictionary<int, int> _dicPerkCd;

	public static List<long> bulletIds;

	private List<LogicEntity> targets;

	public static FP norPlus_t;

	public List<long> bulletIds_toPlayer;

	public override Dictionary<int, int> dicPerkCd
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: stloc 254 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public override void OnDisable()
	{
		/*Error: Invalid field token*/;
	}

	public override void OnReceiveAttack(AdventureActorReceiveAttackEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Unknown opcode: 0xE7*/;
		}
		_ = (short)/*Error near IL_002f: Stack underflow*/;
		/*Error near IL_002f: Unknown opcode: 0xF0*/;
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

	public override void OnBulletFinish(AdventureBulletFinishEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Unknown opcode: 0xE7*/;
		}
	}

	public unsafe Parallel()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((IntPtr[])/*Error near IL_0003: Stack underflow*/)[*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static Parallel()
	{
		/*Error: Unknown opcode: 0xF3*/;
	}
}
