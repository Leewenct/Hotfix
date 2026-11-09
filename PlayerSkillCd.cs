using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;

public class PlayerSkillCd : LogicComponent
{
	public delegate void SkillBindHandle(ActionKey actionKey, int skillId, int actorId);

	public delegate void SkillResidentHintHandle(int skillId, bool isShow);

	public delegate void SyncSkillBtnToLuaHandle(float[] SyncData, bool bLocking, bool bBeginResume, bool bCanUseAssitSkill);

	[CompilerGenerated]
	private SkillBindHandle m_SkillBindEvent;

	[CompilerGenerated]
	private SkillResidentHintHandle m_SkillResidentHintEvent;

	[CompilerGenerated]
	private SyncSkillBtnToLuaHandle m_SyncSkillBtnToLua;

	private readonly Dictionary<ActionKey, int> _skillIdBindDict;

	private int _actorId;

	private AdventureActor _actor;

	private bool _isFastResume;

	private readonly Dictionary<int, SkillEnergyInfo> dicSkillEnergy;

	protected int _unableRecoverEnergyRC;

	private bool bNeedSyncToLua;

	private readonly float[] arrSyncData;

	public List<SkillInfo> skillInfos
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public Dictionary<ActionKey, int> SkillSlotBaseLvBindDict
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public Dictionary<ActionKey, int> SkillSlotAmendLvBindDict
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public unsafe bool unableRecoverEnergy
	{
		get
		{
			_ = *(float*)checked((nuint)/*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public event SkillBindHandle SkillBindEvent
	{
		[CompilerGenerated]
		add
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
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
			}
		}
		[CompilerGenerated]
		remove
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
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
			}
		}
	}

	public event SkillResidentHintHandle SkillResidentHintEvent
	{
		[CompilerGenerated]
		add
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
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
			}
		}
		[CompilerGenerated]
		remove
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
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
			}
		}
	}

	public event SyncSkillBtnToLuaHandle SyncSkillBtnToLua
	{
		[CompilerGenerated]
		add
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
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
			}
		}
		[CompilerGenerated]
		remove
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
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
			}
		}
	}

	protected unsafe override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F8, but got I
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		*(double*)(nint)/*Error near IL_0008: Stack underflow*/ = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Unknown opcode: 0xA8*/;
	}

	public void SetActorId(int id)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public void SetFastResume(bool active)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public int GetSkillSection(int skillId)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public bool CanUseCD(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (int)unchecked((nint)checked((nuint)/*Error near IL_0007: Stack underflow*/));
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	public bool CheckCD(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (int)unchecked((nint)checked((nuint)/*Error near IL_0007: Stack underflow*/));
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	public ActionKey GetCurrentActionKey(int skillId)
	{
		//Discarded unreachable code: IL_0011
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected I4, but got Unknown
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
		}
	}

	public SkillInfo GetSkillCD(ActionKey actionKey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0009: stloc 2 (out-of-bounds)*/;
		checked
		{
			_ = /*Error near IL_000b: Stack underflow*/+ /*Error near IL_000b: Stack underflow*/;
			/*Error near IL_000b: Unknown opcode: 0xE2*/;
		}
	}

	public SkillInfo GetSkillCD(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = 1858294795;
		/*Error near IL_000c: Unknown opcode: 0xE9*/;
	}

	public void SetSkillUseTimeHint(int skillId, FP useTimeHint, FP currentUseTimeHint)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void CloseSkillUseTimeHint(int skillId)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public FP GetSkillUseTimeHint(int skillId)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public int GetSkillLevel(ActionKey actionKey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) < 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = 2360838190274895370L;
		/*Error near IL_0010: Unknown opcode: 0xFD*/;
	}

	public void AddSkillSlotLevel(ActionKey actionKey, int amend)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_000c: Stack underflow*/ != /*Error near IL_000c: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_000c: Invalid branch target*/;
	}

	public (bool valid, int oldLevel) SetSkillSlotBaseLevel(ActionKey actionKey, int level)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void SetSkillSlotBaseLevelForBootConfig(ActionKey actionKey, int level)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) < 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_000c: Stack underflow*/ != /*Error near IL_000c: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_000c: Invalid branch target*/;
	}

	public void BindSkillIdToButton(ActionKey actionKey, int skillId, bool resetSection = false)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public int GetCurrentBindSkillId(ActionKey actionKey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	public SkillEnergyInfo GetSkillEnergyInfo(int skillId)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public void ChangeSkillGetEnergyLimit(int skillId, FP getEnergyLimit)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public void ResetSkillGetEnergyLimit(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public void AddSkillEnergyPool(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public void SetSkillEnergyMaxEnergy(int skillId, FP maxEnergy)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public void ReduceSkillSection(int skillId, bool beginResume = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Unknown opcode: 0xC7*/;
	}

	public void AddSkillSection(ActionKey actionKey, int amount = 1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public void SetSkillTotalSection(ActionKey actionKey, int totalAmount = 1, bool forceMaxSection = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public void AddSkillTotalSection(ActionKey actionKey, int addAmount)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		_ = /*Error near IL_000a: Stack underflow*/* /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_000a: Unknown opcode: 0xB0*/;
	}

	public void ResetSkillTotalSection(ActionKey actionKey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public void SetSkillBeginResume(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public void SetSkillStopResume(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		_ = /*Error near IL_000a: Stack underflow*/* 0;
		/*Error near IL_000a: Unknown opcode: 0xB0*/;
	}

	private FP GetCurrentSectionResumeTime(SkillInfo info)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected I4, but got Unknown
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
		case 36:
			/*Error: Invalid branch target*/;
		case 37:
			/*Error: Invalid branch target*/;
		case 38:
			/*Error: Invalid branch target*/;
		case 39:
			/*Error: Invalid branch target*/;
		case 40:
			/*Error: Invalid branch target*/;
		case 41:
			/*Error: Invalid branch target*/;
		case 42:
			/*Error: Invalid branch target*/;
		case 43:
			/*Error: Invalid branch target*/;
		case 44:
			/*Error: Invalid branch target*/;
		case 45:
			/*Error: Invalid branch target*/;
		case 46:
			/*Error: Invalid branch target*/;
		case 47:
			/*Error: Invalid branch target*/;
		case 48:
			/*Error: Invalid branch target*/;
		case 49:
			/*Error: Invalid branch target*/;
		case 50:
			/*Error: Invalid branch target*/;
		case 51:
			/*Error: Invalid branch target*/;
		case 52:
			/*Error: Invalid branch target*/;
		case 53:
			/*Error: Invalid branch target*/;
		case 54:
			/*Error: Invalid branch target*/;
		case 55:
			/*Error: Invalid branch target*/;
		case 56:
			/*Error: Invalid branch target*/;
		case 57:
			/*Error: Invalid branch target*/;
		case 58:
			/*Error: Invalid branch target*/;
		case 59:
			/*Error: Invalid branch target*/;
		case 60:
			/*Error: Invalid branch target*/;
		case 61:
			/*Error: Invalid branch target*/;
		}
	}

	public void ReturnSkillResumeTime(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		_ = /*Error near IL_000a: Stack underflow*/+ checked((sbyte)/*Error near IL_0009: Stack underflow*/);
		/*Error near IL_000a: Unknown opcode: 0xED*/;
	}

	public void ResetUseInterval(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		SkillInfo skillInfo = default;
		_ = /*Error near IL_000a: Stack underflow*/* skillInfo;
		/*Error near IL_000a: Unknown opcode: 0xB0*/;
	}

	public void ModifyResumeTimePercent(int resumeTimePercent, ActionKey actionKey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/| /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public void ModifyResumeTimeAbs(FP resumeTimeAbs, ActionKey actionKey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/| /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public void ModifySectionResumeTimePercentAmend(int sectionResumeTimePercentAmend, ActionKey actionKey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/| /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public void ResetSectionResumeTimePercentAmend(ActionKey actionKey)
	{
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldarg 3 (out-of-bounds)*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public void ModifySectionResumeTimeAmend(FP sectionResumeTimeAmend, ActionKey actionKey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	public void ModifySectionResumeTimeAmend(FP sectionResumeTimeAmend, int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/| /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public void ResetSectionResumeTimeAmend(ActionKey actionKey)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ == 0)
		{
			/*Error near IL_0002: Invalid metadata token*/;
		}
		switch ((int)/*Error near IL_000e: Stack underflow*/)
		{
		default:
			/*Error: End of method reached without returning.*/;
		}
	}

	public void ResetSectionResumeTimeAmend(int skillId)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ == 0)
		{
			/*Error near IL_0002: Invalid metadata token*/;
		}
		switch ((int)/*Error near IL_000e: Stack underflow*/)
		{
		default:
			/*Error: End of method reached without returning.*/;
		}
	}

	public void ModifyOriginalSectionResumeTime(ActionKey actionKey, FP originalResumeTimeAmend)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/| /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public void ResetAllSkillCD()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/| /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_0008: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public void ResetSkillCD(ActionKey actionKey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0009: stloc 2 (out-of-bounds)*/;
		int num = default;
		_ = /*Error near IL_000e: Stack underflow*/>> checked(/*Error near IL_000b: Stack underflow*/ + /*Error near IL_000b: Stack underflow*/- num);
		/*Error near IL_000e: Unknown opcode: 0xE3*/;
	}

	public void ResetSkillCD(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		_ = /*Error near IL_000a: Stack underflow*/* 0;
		/*Error near IL_000a: Unknown opcode: 0xB0*/;
	}

	public void ResetUseTimeHint(ActionKey actionKey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0009: stloc 2 (out-of-bounds)*/;
		_ = /*Error near IL_000e: Stack underflow*/>> checked(/*Error near IL_000b: Stack underflow*/ + /*Error near IL_000b: Stack underflow*/- /*Error near IL_000b: ldloc 2 (out-of-bounds)*/);
		/*Error near IL_000e: Unknown opcode: 0xE3*/;
	}

	public void ResetUseTimeHint(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/| /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public void ResetSkillInfo(int skillId, long cd, int sectionAmount, long sectionResumeTime, long useTimeHint, long energy)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/| /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public bool ModifyResumeAbsByEffect(FP resumeTimeAbs, string actionKey, string skillId)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public bool ModifyResumeTimePercentByEffect(FP resumeTimePercent, string actionKey, string skillId)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void AddSectionAmountByEffect(int amount, string actionKey, string skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/| /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public void ResumeSectionAmountByEffect(string actionKey, string skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/| /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	private bool checkSkillByActionkOrId(SkillInfo skillInfo, string checkActionKey, string checkSkillId)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void EnterUnableRecoverEnergyState()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public void ExitUnableRecoverEnergyState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Not a type handle*/;
	}

	public void AddEnergy(FDP energy)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected I4, but got Unknown
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
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		}
	}

	public void ClearEnergy()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0x24*/;
		}
	}

	public void SetEnergy(FDP energy)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0x24*/;
		}
	}

	public void OnSetEnergy(FDP old_energy, FDP energy)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0x24*/;
		}
	}

	public unsafe FDP GetEnergy()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Not a type handle*/;
	}

	public int GetTotalEnergy()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public FDP GetEnergyPercent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	private void OnEnergyChange(SkillInfo info, bool isReset = false)
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

	public void DoSyncSkillBtnToLua(SkillInfo info)
	{
		/*Error: Unknown opcode: 0xF7*/;
	}

	public void UpdateSkillCD(FP deltaTime)
	{
		//Discarded unreachable code: IL_0213
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/| /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public void LockSkillCD(ActionKey actionKey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Unknown opcode: 0xC5*/;
	}

	public void LockSkillCD(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Unknown opcode: 0xC5*/;
	}

	public void UnLockSkillCD(ActionKey actionKey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Unknown opcode: 0xC5*/;
	}

	public void UnLockSkillCD(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Unknown opcode: 0xC5*/;
	}

	public bool CheckSkillIsLocking(int skillId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Unknown opcode: 0xC5*/;
	}

	public unsafe void Clear()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) <= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(float*)(nint)/*Error near IL_0008: Stack underflow*/;
		checked
		{
			List<SkillInfo>.Enumerator enumerator = default;
			_ = (long)enumerator;
			try
			{
				/*Error near IL_000c: Unknown opcode: 0xFE64*/;
			}
			finally
			{
				/*Error near IL_002a: Unknown opcode: 0xC1*/;
			}
		}
	}

	public unsafe PlayerSkillCd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (byte)(*unchecked((nint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Not a type handle*/;
		}
	}
}
