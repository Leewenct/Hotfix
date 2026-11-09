using System;
using System.Collections.Generic;
using TrueSync;

namespace AIScript.Monster.TowerDefense;

public class TowerMonsterSkillBase : SkillSimpleBase
{
	private Action<MonsterRecGridInfo> recGridInfoCallback;

	private Action<MonsterRecGridInfo> recNextNGridInfoCallback;

	private Action<List<GridInfoData>> recGridInfosCallback;

	private Action<GridInfoData> recGridInfoByPosCallback;

	private Action<List<GridInfoData>> recItemGridInfosCallback;

	protected override void OnSkillEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (sbyte)0;
			/*Error near IL_005e: Unknown opcode: 0xEF*/;
		}
	}

	protected unsafe override void OnSkillDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		if (0 == 0)
		{
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
		_ = *(IntPtr*)checked(unchecked((ulong)(long)checked(/*Error near IL_005d: Stack underflow*/ * val)) - 5uL);
		/*Error near IL_0062: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0064: Unknown opcode: 0xEC*/;
	}

	protected unsafe void Dispatch_GetNextGridInfo(Action<MonsterRecGridInfo> callback)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(uint*)checked((sbyte)(ulong)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_000a: Unknown opcode: 0xAF*/;
	}

	private unsafe void Rec_GetNextGridInfo(IEvent iEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (int)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected void Dispatch_GetNextNGridInfo(int step, Action<MonsterRecGridInfo> callback)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/!= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = ((ushort[])/*Error near IL_0009: Stack underflow*/)[(sbyte)(ulong)/*Error near IL_0007: Stack underflow*/];
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	private unsafe void Rec_GetNextNGridInfo(IEvent iEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (int)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected void Dispatch_CreateGrass(int gridIndex)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void Dispatch_ClearGrass(int gridIndex)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void Dispatch_GetGridsInfoInCircle(TSVector2 center, FP range, bool preferNonFlame, Action<List<GridInfoData>> callback)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0003: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0003: Unknown opcode: 0xBE*/;
	}

	private unsafe void Rec_GetGridInfoInCircle(IEvent iEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (int)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected void Dispatch_CreateFire(int gridIndex)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void Dispatch_GetGridInfoByPosition(TSVector2 position, Action<GridInfoData> callback)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/!= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)(ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0008: Unknown opcode: 0xA7*/;
		}
	}

	private unsafe void Rec_GetGridInfoByPos(IEvent iEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (int)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected void Dispatch_DarkenItemGrid(int itemGridIndex)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void Dispatch_DarkenRoleGrid(int roleDataID)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void Dispatch_DarkenLighthouse(int lighthouseGridIndex)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void Dispatch_DarkenLightSourcesInRange(TSVector2 center, FP range)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected unsafe void Dispatch_GetItemGridInfo(Action<List<GridInfoData>> callback)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(uint*)checked((sbyte)(ulong)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_000a: Unknown opcode: 0xAF*/;
	}

	private unsafe void Rec_GetItemGridInfo(IEvent iEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (int)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public TowerMonsterSkillBase()
	{
		/*Error: Invalid field token*/;
	}
}
