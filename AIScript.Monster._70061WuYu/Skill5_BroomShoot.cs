using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.Monster._70061WuYu;

public class Skill5_BroomShoot : SkillSimpleBase
{
	private struct SpawnPoint
	{
		public TSVector2 position;

		public TSVector2 direction;
	}

	[CompilerGenerated]
	private sealed class _003CDoMainLogic_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Skill5_BroomShoot _003C_003E4__this;

		private int _003Cphase_003E5__2;

		private TSVector2 _003CbossPos_003E5__3;

		private TSVector2 _003CplayerPos_003E5__4;

		private List<SpawnPoint> _003CspawnList_003E5__5;

		private FP _003CstartFxDelay_003E5__6;

		private FP _003CstartFxSize_003E5__7;

		private FP _003CstartFxSpeed_003E5__8;

		private FP _003CsummonInterval_003E5__9;

		private int _003Ci_003E5__10;

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
		public _003CDoMainLogic_003Ed__31(int _003C_003E1__state)
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
			//IL_025e: Expected I4, but got Unknown
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
			case 149:
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
	private sealed class _003CShootBulletSequence_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int phase;

		public Skill5_BroomShoot _003C_003E4__this;

		public TSVector2 bossPos;

		public TSVector2 playerPos;

		public SpawnPoint spawnPoint;

		public FP startFxSpeed;

		public FP startFxSize;

		public FP startFxDelay;

		private TSVector2 _003CaimPos_003E5__2;

		private TSVector2 _003CshootDir_003E5__3;

		private long _003CstartFxId_003E5__4;

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
		public _003CShootBulletSequence_003Ed__32(int _003C_003E1__state)
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
			//IL_021b: Expected I4, but got Unknown
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

	private const string ComboKeyP1 = "Skill5_1_BroomShoot";

	private const string ComboKeyP2 = "Skill5_1_BroomShoot_Plus";

	private const string ComboKeyP3 = "Skill5_3_BroomShoot_Fly";

	private const string SummonBroomEvent = "SummonBroom";

	private const string BroomBulletAliasP1 = "Weapon_70061WuYu_Skill5_BroomBullet";

	private const string BroomBulletAliasP2 = "Weapon_70061WuYu_Skill5_BroomBullet_Big";

	private const string BroomBulletAliasP3 = "Weapon_70061WuYu_Skill5_BroomBullet_Big";

	private const string BroomStartFxAlias = "fx_70061WuYu_base_Attack13_broom_start";

	private static readonly FP BulletShootHeight;

	private static readonly FP BroomStartFxDelayP1;

	private static readonly FP BroomStartFxSpawnSizeP1;

	private static readonly FP BroomStartFxSpeedP1;

	private static readonly FP BroomStartFxDelayP23;

	private static readonly FP BroomStartFxSpawnSizeP23;

	private static readonly FP BroomStartFxSpeedP23;

	private static readonly FP SpawnOffset;

	private static readonly FP SummonIntervalP1;

	private const int SummonCountP1 = 2;

	private const int SummonCountP2 = 1;

	private static readonly FP SideAngle;

	private static readonly FP HalfFieldSplitAngle;

	public const string SideAreaFx_Phase2 = "AreaEffect_70061WuYu_Skill5_BroomBulletArea";

	public static readonly FP LayInterval_Phase2;

	public static readonly FP LaySideOffset_Phase2;

	public const string TrailAreaFx_Phase3 = "AreaEffect_70061WuYu_Skill5_BroomBulletArea";

	public static readonly FP LayInterval_Phase3;

	private const string BulletWarningFxAliasP3 = "fx_warning_dash_3x23";

	private static readonly FP BulletWarningDurationP3;

	public const string LayBulletEventName = "WuYu_Skill5_RegisterLayBullet";

	private readonly List<SpawnPoint> _spawnPointList;

	private static readonly FP FarProbe;

	[IteratorStateMachine(typeof(_003CDoMainLogic_003Ed__31))]
	protected override IEnumerator DoMainLogic()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		throw /*Error near IL_0007: Stack underflow*/| /*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
	}

	[IteratorStateMachine(typeof(_003CShootBulletSequence_003Ed__32))]
	private IEnumerator ShootBulletSequence(int phase, SpawnPoint spawnPoint, TSVector2 bossPos, TSVector2 playerPos, FP startFxDelay, FP startFxSize, FP startFxSpeed)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private List<SpawnPoint> CalcSpawnPoints(int phase, TSVector2 bossPos, TSVector2 playerPos)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected I4, but got Unknown
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
		}
	}

	private TSVector2 GetArenaEdge(TSVector2 center, TSVector2 dir)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/!= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (float)(sbyte)(ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	private void AddSpawnPoint(List<SpawnPoint> list, TSVector2 pos, TSVector2 playerPos)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/!= 0)
			{
				/*Error: Invalid branch target*/;
			}
			ushort num = (ushort)/*Error near IL_0007: Stack underflow*/;
			((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = unchecked((int)num);
			_ = /*Error near IL_000b: Stack underflow*/+ /*Error near IL_000b: Stack underflow*/;
			_ = (nint)3;
			/*Error near IL_000d: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public Skill5_BroomShoot()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0007: Stack underflow*/ <= /*Error near IL_0007: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = /*Error near IL_0008: Stack underflow*/+ /*Error near IL_0008: Stack underflow*/;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	static Skill5_BroomShoot()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}
}
