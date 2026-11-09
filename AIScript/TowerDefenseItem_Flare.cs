using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nova.Hotfix;
using TrueSync;
using UnityEngine;

namespace AIScript;

public class TowerDefenseItem_Flare : TowerDefenseItemBase
{
	public class FlareEffectData
	{
		public int targetGridIndex;

		public bool isLighthouse;

		public List<int> litGrids;

		public List<int> tempLitGrids;

		public bool invincible;

		public bool forceEnded;

		public unsafe FlareEffectData()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0003: Stack underflow*// (nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDoMainLogic_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TowerDefenseItem_Flare _003C_003E4__this;

		public TSVector2 position;

		private FlareEffectData _003Cdata_003E5__2;

		private Vector3 _003CworldPos_003E5__3;

		private AdventureFXPlayer _003CflareEffect_003E5__4;

		private long _003CflareEffectToken_003E5__5;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CDoMainLogic_003Ed__8(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Expected I4, but got Unknown
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
			case 64:
				/*Error: Invalid branch target*/;
			case 65:
				/*Error: Invalid branch target*/;
			case 66:
				/*Error: Invalid branch target*/;
			case 67:
				/*Error: Invalid branch target*/;
			case 68:
				/*Error: Invalid branch target*/;
			case 69:
				/*Error: Invalid branch target*/;
			case 70:
				/*Error: Invalid branch target*/;
			case 71:
				/*Error: Invalid branch target*/;
			case 72:
				/*Error: Invalid branch target*/;
			case 73:
				/*Error: Invalid branch target*/;
			case 74:
				/*Error: Invalid branch target*/;
			case 75:
				/*Error: Invalid branch target*/;
			case 76:
				/*Error: Invalid branch target*/;
			case 77:
				/*Error: Invalid branch target*/;
			case 78:
				/*Error: Invalid branch target*/;
			case 79:
				/*Error: Invalid branch target*/;
			case 80:
				/*Error: Invalid branch target*/;
			case 81:
				/*Error: Invalid branch target*/;
			case 82:
				/*Error: Invalid branch target*/;
			case 83:
				/*Error: Invalid branch target*/;
			case 84:
				/*Error: Invalid branch target*/;
			case 85:
				/*Error: Invalid branch target*/;
			case 86:
				/*Error: Invalid branch target*/;
			case 87:
				/*Error: Invalid branch target*/;
			case 88:
				/*Error: Invalid branch target*/;
			case 89:
				/*Error: Invalid branch target*/;
			case 90:
				/*Error: Invalid branch target*/;
			case 91:
				/*Error: Invalid branch target*/;
			case 92:
				/*Error: Invalid branch target*/;
			case 93:
				/*Error: Invalid branch target*/;
			case 94:
				/*Error: Invalid branch target*/;
			case 95:
				/*Error: Invalid branch target*/;
			case 96:
				/*Error: Invalid branch target*/;
			case 97:
				/*Error: Invalid branch target*/;
			case 98:
				/*Error: Invalid branch target*/;
			case 99:
				/*Error: Invalid branch target*/;
			case 100:
				/*Error: Invalid branch target*/;
			case 101:
				/*Error: Invalid branch target*/;
			case 102:
				/*Error: Invalid branch target*/;
			case 103:
				/*Error: Invalid branch target*/;
			case 104:
				/*Error: Invalid branch target*/;
			case 105:
				/*Error: Invalid branch target*/;
			case 106:
				/*Error: Invalid branch target*/;
			case 107:
				/*Error: Invalid branch target*/;
			case 108:
				/*Error: Invalid branch target*/;
			case 109:
				/*Error: Invalid branch target*/;
			case 110:
				/*Error: Invalid branch target*/;
			case 111:
				/*Error: Invalid branch target*/;
			case 112:
				/*Error: Invalid branch target*/;
			case 113:
				/*Error: Invalid branch target*/;
			case 114:
				/*Error: Invalid branch target*/;
			case 115:
				/*Error: Invalid branch target*/;
			case 116:
				/*Error: Invalid branch target*/;
			case 117:
				/*Error: Invalid branch target*/;
			case 118:
				/*Error: Invalid branch target*/;
			case 119:
				/*Error: Invalid branch target*/;
			case 120:
				/*Error: Invalid branch target*/;
			case 121:
				/*Error: Invalid branch target*/;
			case 122:
				/*Error: Invalid branch target*/;
			case 123:
				/*Error: Invalid branch target*/;
			case 124:
				/*Error: Invalid branch target*/;
			case 125:
				/*Error: Invalid branch target*/;
			case 126:
				/*Error: Invalid branch target*/;
			case 127:
				/*Error: Invalid branch target*/;
			case 128:
				/*Error: Invalid branch target*/;
			case 129:
				/*Error: Invalid branch target*/;
			case 130:
				/*Error: Invalid branch target*/;
			case 131:
				/*Error: Invalid branch target*/;
			case 132:
				/*Error: Invalid branch target*/;
			case 133:
				/*Error: Invalid branch target*/;
			case 134:
				/*Error: Invalid branch target*/;
			case 135:
				/*Error: Invalid branch target*/;
			case 136:
				/*Error: Invalid branch target*/;
			case 137:
				/*Error: Invalid branch target*/;
			case 138:
				/*Error: Invalid branch target*/;
			case 139:
				/*Error: Invalid branch target*/;
			case 140:
				/*Error: Invalid branch target*/;
			case 141:
				/*Error: Invalid branch target*/;
			case 142:
				/*Error: Invalid branch target*/;
			case 143:
				/*Error: Invalid branch target*/;
			case 144:
				/*Error: Invalid branch target*/;
			case 145:
				/*Error: Invalid branch target*/;
			case 146:
				/*Error: Invalid branch target*/;
			case 147:
				/*Error: Invalid branch target*/;
			case 148:
				/*Error: Invalid branch target*/;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CWait_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FP s;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CWait_003Ed__10(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitOrForceEnd_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FP s;

		public FlareEffectData data;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CWaitOrForceEnd_003Ed__12(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	private const string TOWERDEFENSE_ITEM_FLARE_START = "TOWERDEFENSE_ITEM_FLARE_START";

	private const string TOWERDEFENSE_ITEM_FLARE_END = "TOWERDEFENSE_ITEM_FLARE_END";

	private const string FLARE_EFFECT = "Assets/AssetBundles/FX/TowerDefence/Items/fx_td_item_base_ghost_lamp.prefab";

	private const string FLARE_EFFECT_END = "Assets/AssetBundles/FX/TowerDefence/fx_td_base_ghost_lamp_end.prefab";

	private FP duration;

	private FP invincibleTime;

	public override void InitConfig(TowerDefenseItem itemData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/;
			throw 1685934090;
		}
	}

	[IteratorStateMachine(typeof(_003CDoMainLogic_003Ed__8))]
	protected override IEnumerator DoMainLogic(TSVector2 position)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected CoroutineNode WaitTime(FP s)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003->IL0003: Incompatible stack heights: 1 vs 0
		if ((int)/*Error near IL_0002: Stack underflow*/ == 0)
		{
		}
		_ = /*Error near IL_0004: Stack underflow*/^ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xF3*/;
	}

	[IteratorStateMachine(typeof(_003CWait_003Ed__10))]
	private IEnumerator Wait(FP s)
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_000b: Stack underflow*/ <= /*Error near IL_0005: ldloc 0 (out-of-bounds)*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*OpCode not supported: DebugBreak*/;
		switch (checked((sbyte)/*Error near IL_000d: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		}
	}

	private CoroutineNode WaitTimeOrForceEnd(FP s, FlareEffectData data)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	[IteratorStateMachine(typeof(_003CWaitOrForceEnd_003Ed__12))]
	private IEnumerator WaitOrForceEnd(FP s, FlareEffectData data)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public override bool GridSatisItem_CanUse(TowerDefenseMapData.TowerGrid grid)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public override bool GridSatisItem_TakeEffect(TowerDefenseMapData.TowerGrid grid)
	{
		/*Error: ldarga 247 (out-of-bounds)*/;
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}

	public TowerDefenseItem_Flare()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}
}
