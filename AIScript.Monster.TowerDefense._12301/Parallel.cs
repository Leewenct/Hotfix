using System.Collections.Generic;
using TrueSync;

namespace AIScript.Monster.TowerDefense._12301;

public class Parallel : TowerCharacterParalletBase
{
	private int hitTag_Normal;

	private int hitTag_Normal_P3;

	private int interval_Count;

	private string areaEffect_Base;

	private FP _leftTime;

	private int monsterId;

	private TSVector2 offsetBorn;

	private int perkId_1;

	private string areaEffect_1;

	private int perkId_2;

	private int buffId_2;

	private int perkId_3;

	private string areaEffect_3;

	private int perkId_4;

	private List<int> perkList;

	private Dictionary<int, int> _dicPerkCd;

	private bool triggerFirstHit;

	private int summonEvt;

	private List<int> buffList;

	private List<MonsterAdventureActor> summmons;

	private Dictionary<long, int> dicHitCount;

	public override Dictionary<int, int> dicPerkCd
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public unsafe override void OnEnable()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/>> (int)(*(short*)(nint)/*Error near IL_0003: Stack underflow*/);
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0006: Unknown opcode: 0xFD*/;
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = null;
			/*Error near IL_0003: Unknown opcode: 0xFEEC*/;
		}
	}

	public override void OnCastSkill(AdventureActorCastSkillEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ > (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_000a: Stack underflow*// /*Error near IL_000a: Stack underflow*/;
		/*Error near IL_000a: Unknown opcode: 0xBD*/;
	}

	public override void OnHitPost(AdventureActorReceiveDamageEvent evt, MonsterAdventureActor monster, bool isSelf)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		string text = default;
		_ = checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/) + text;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public override void OnCustomEvent(AdventureActorCustomEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		case 4:
			/*Error: Invalid branch target*/;
		case 5:
			/*Error: Invalid branch target*/;
		case 6:
			/*Error: Invalid branch target*/;
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		case 12:
			/*Error: Invalid branch target*/;
		case 13:
			/*Error: Invalid branch target*/;
		case 14:
			/*Error: Invalid branch target*/;
		case 15:
			/*Error: Invalid branch target*/;
		case 16:
			/*Error: Invalid branch target*/;
		case 17:
			/*Error: Invalid branch target*/;
		case 18:
			/*Error: Invalid branch target*/;
		case 19:
			/*Error: Invalid branch target*/;
		case 20:
			/*Error: Invalid branch target*/;
		case 21:
			/*Error: Invalid branch target*/;
		case 22:
			/*Error: Invalid branch target*/;
		case 23:
			/*Error: Invalid branch target*/;
		case 24:
			/*Error: Invalid branch target*/;
		case 25:
			/*Error: Invalid branch target*/;
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		case 35:
			/*Error: Invalid branch target*/;
		}
	}

	public override void OnPersonalPerkUpdate(AdventureActorPersonalPerkUpdateEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Unknown opcode: 0xA8*/;
		}
		/*Error near IL_0042: Unknown opcode: 0xF3*/;
	}

	public unsafe Parallel()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}
}
