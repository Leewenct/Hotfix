using System.Collections.Generic;
using Nova.Hotfix;
using TrueSync;

public class BuffManager : Singleton<BuffManager>
{
	public struct InheritBuffInfo
	{
		public int id;

		public int num;

		public FP leftTime;
	}

	public enum BuffAddType
	{
		Normal,
		BuffNum,
		GroupIdBySort,
		BuffInstanceLimit
	}

	public enum BuffAddFailType
	{
		PrimeState,
		GroupIdBySort,
		BuffInstanceLimit
	}

	public enum BuffRemoveType
	{
		Normal,
		ReycleClear,
		BuffNum,
		TimeFinish,
		PrimeState,
		GroupIdBySort,
		BuffInstanceLimit
	}

	public enum ImmunityBuffType
	{
		Add_Imm,
		Remove_Imm
	}

	private int buffUid;

	public AdventureActorReceiveDamageEvent _evt;

	public readonly List<InheritBuffInfo> _inheritBuffs;

	protected readonly Stack<BuffEntity> _buffPoolDatas;

	public int _reduceCount;

	public readonly List<BuffCom> reduceTimeList;

	public bool CanReduceBuffTime
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected I4, but got Unknown
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
			}
		}
	}

	public BuffEntity GetBuffEntity(Buff buffConfig, BuffValue buffValueConfig, BuffCom buffc, AdventureActor fromActor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected I4, but got Unknown
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
		}
	}

	public void EnterBuffPool(BuffEntity buffEn)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xEF*/;
		}
	}

	public void ClearBuffDatas()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public int CreateBuffUid()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Not a type handle*/;
	}

	public void AddBuffReduceTime(BuffCom bfc)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public void RemoveBuffReduceTime(BuffCom bfc)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xE8*/;
	}

	public void SetInhertBuff(BuffEntity _entity)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public void InhertBuff(BuffCom _buffC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected I4, but got Unknown
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
		}
	}

	public void AddBufftoGroup(int buffID, AdventureActor fromActor, int num = 1)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void RemoveBufftoGroup(int buffID)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void SetBuffNumtoGroup(int buffID, int num, AdventureActor fromActor = null)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void AddBuffToTarget(int id = 0, int groupID = 0)
	{
		//Discarded unreachable code: IL_0030
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	private void AddbuffByTarget(AddBuffAction _data)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xC4*/;
		}
	}

	public BuffManager()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_003F val = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if (val <= val)
			{
				/*Error: Invalid branch target*/;
			}
			_ = /*Error near IL_0008: Stack underflow*/+ /*Error near IL_0008: Stack underflow*/;
			_ = 14;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}
}
