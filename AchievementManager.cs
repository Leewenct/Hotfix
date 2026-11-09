using System;
using System.Collections.Generic;

public class AchievementManager : SceneSingleton<AchievementManager>
{
	public struct AchievementDataDic
	{
		public Dictionary<int, Dictionary<int, int>> DamageDataDic;

		public Dictionary<int, Dictionary<int, int>> killDataDic;

		public Dictionary<int, int> OnceSkillKillCountDic;

		public Dictionary<int, int> CritCountData;

		public Dictionary<int, int> PrefectDodgeData;

		public long MaxDamageValue;

		public Dictionary<int, int> MarkTriggerData;

		public float MainActorHpPrec;

		public Dictionary<int, int> CastSkillData;

		public Dictionary<int, int> EventData;

		public Dictionary<int, int> specialBattleData;
	}

	public Dictionary<int, Dictionary<int, int>> DamageData;

	public Dictionary<int, Dictionary<int, int>> killData;

	private Dictionary<long, Dictionary<int, int>> tmpSkillKillCount;

	private Dictionary<int, int> critCountData;

	private Dictionary<int, int> prefectDodgeData;

	private long maxDamageValue;

	private Dictionary<int, int> markTriggerData;

	private Dictionary<int, int> castSkillData;

	private Dictionary<int, int> eventData;

	private Dictionary<int, int> specialBattleData;

	private void Start()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xCF*/;
		}
	}

	private unsafe bool isPlayerEntity(LogicEntity logicEntity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private void ClearData()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
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
		}
	}

	private void OnLevelStart(IEvent evt)
	{
		/*Error: Invalid field token*/;
	}

	private unsafe void OnDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private unsafe void ActorDied(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((byte[])/*Error near IL_0003: Stack underflow*/)[*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnReceiveCrit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void OnPrefectDodge(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xFB*/;
	}

	private unsafe void OnElementMarkTrigger(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: ldarg 3 (out-of-bounds)*/;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private unsafe void OnCastSkill(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void TriggerEvent(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xFC*/;
	}

	private unsafe void SpecialBattleData(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xCB*/;
	}

	public AchievementDataDic GetAchievementData()
	{
		//Discarded unreachable code: IL_0037, IL_0050, IL_0143
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unknown opcode: 0xE7*/;
	}

	public unsafe AchievementManager()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I
		if ((nint)/*Error near IL_0004: Stack underflow*/ > (nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)))
		{
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}
}
