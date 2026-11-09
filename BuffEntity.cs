using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nova.Hotfix;
using TrueSync;

public class BuffEntity
{
	private Dictionary<int, List<int>> buffUidLs;

	private Dictionary<int, AdventureActor> fromActors;

	private FP configBuffTime;

	private FP buffLeftTime;

	public FP inputReduceTime;

	public Buff buffConfig;

	public BuffValue buffValueConfig;

	private BuffCom _buffCom;

	private int buffNum;

	private AdventureBuffFXHandler adventureBuffFx;

	private int exceptNum;

	private bool inPool;

	private FP exceptTime;

	private bool removed;

	public bool InPool
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public List<int> Tags
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public FP LeftTime
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public bool Removed
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public void InitBuff(Buff _buffConfig, BuffValue _buffValueConfig, BuffCom bfC, AdventureActor fromActor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public int GetUid()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
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
		}
	}

	public bool AddBuffNum(AdventureActor fromActor = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = -5668892696671228922L;
			/*Error near IL_000b: Not a type handle*/;
		}
	}

	public void ReduceNum(int num)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public int GetBuffNum()
	{
		/*Error: Invalid field token*/;
	}

	public FP GetBuffLeftTime()
	{
		/*Error: Invalid field token*/;
	}

	public void InitTime(bool addNum = false, bool iRefresh = false, AdventureActor fromActor = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected I4, but got Unknown
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
		case 62:
			/*Error: Invalid branch target*/;
		case 63:
			/*Error: Invalid branch target*/;
		}
	}

	public bool CheckBuffTag(int _tag)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
		_ = (uint)((sbyte[])0)[-5596846097749578746L];
		/*Error near IL_000d: Unknown opcode: 0x77*/;
	}

	public bool CheckBuffFrom(AdventureActor fromA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = -5596632792493790202L;
			/*Error near IL_000b: Unknown opcode: 0x78*/;
		}
	}

	public void BuffExcute(BuffManager.BuffAddType addType, AdventureActor fromActor = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = (ushort)unchecked((nuint)checked((nint)unchecked((nuint)6723885310202801158uL)));
			/*Error near IL_0010: Unknown opcode: 0xE1*/;
		}
	}

	public int GetMaxNum()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
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

	public void AdjustNum(int num)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
		}
		_ = -(-2592382265059513338L);
		/*Error near IL_000c: Unknown opcode: 0xFD*/;
	}

	public void SetTime(FP time)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public void AjustTime(FP value, int percent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Not a type handle*/;
	}

	public void AddLeftTime(FP time)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I8
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((long)/*Error near IL_0009: Stack underflow*/ > (long)checked((ulong)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((long[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = (long)/*Error near IL_000a: Stack underflow*/;
		/*Error near IL_000a: Unknown opcode: 0xAF*/;
	}

	public void AddExceptLeftTime(FP time)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I8
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((long)/*Error near IL_0009: Stack underflow*/ > (long)checked((ulong)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((long[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = (long)/*Error near IL_000a: Stack underflow*/;
		/*Error near IL_000a: Unknown opcode: 0xAF*/;
	}

	public unsafe List<AdventureEffect> GetBuffAllActiveEffects()
	{
		//Discarded unreachable code: IL_0017
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xAE*/;
	}

	public void OnUpdate(FP deltaTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if (0L <= 3027544920922188806L)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0010: Unknown opcode: 0xE3*/;
		}
	}

	public unsafe void UpdateLeftTime(FP deltaTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I8
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((long)/*Error near IL_0009: Stack underflow*/ > (long)checked((ulong)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(long*)(nint)/*Error near IL_000a: Stack underflow*/;
		/*Error near IL_000a: Unknown opcode: 0xB0*/;
	}

	public void BuffEnd(BuffManager.BuffRemoveType removeType)
	{
		//Discarded unreachable code: IL_0050
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = -4178206786289210362L;
			/*Error near IL_000b: Unknown opcode: 0xE1*/;
		}
	}

	public void OnClear()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	private void SetUid(int _buffUid)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
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
		}
	}

	private void BuffReduceTime(bool add = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 212 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xC4*/;
		}
	}

	private unsafe bool ReduceNum()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected I, but got I8
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			*(IntPtr*)null = unchecked((nint)(-5668898194229367802L));
			/*Error near IL_000c: Unknown opcode: 0xAF*/;
		}
	}

	private void BuffScenceEffect(bool iAjustNum)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if (0L > 3027544920922188806L)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0010: Unknown opcode: 0x78*/;
		}
	}

	private void EffectExcute(int uid, AdventureActor fromActor, BuffManager.BuffAddType addType = BuffManager.BuffAddType.Normal)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if (0L < 3027544920922188806L)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0010: Unknown opcode: 0xE6*/;
		}
	}

	private unsafe void BuffEffectExcute(AdventureActor _from, int buffUid)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I, but got Unknown
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		if (0L <= 3027544920922188806L)
		{
			/*Error: Invalid branch target*/;
		}
		*(IntPtr*)(nint)/*Error near IL_0011: Stack underflow*/ = (IntPtr)val;
		_ = *(long*)(nint)/*Error near IL_0012: Stack underflow*/;
		/*Error near IL_0012: Unknown opcode: 0xB1*/;
	}

	private void DispatchAddBuffEvent(BuffManager.BuffAddType addType, AdventureActor fromActor = null)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void DispatchRemoveBuffEvent(BuffManager.BuffRemoveType removeType, int uid = 0)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe BuffEntity()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*// (nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}
}
