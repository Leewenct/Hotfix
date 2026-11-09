using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nova.Hotfix;
using TrueSync;

public class SoldierLevelController : AdventureLevelController, ICoroutineOwner
{
	public struct SoldierMsg
	{
		public int nSoldierId;

		public bool nBattleRole;

		public int boardIndex;

		public int nSoldierLv;

		public SoldierAttr soldierAttr;

		public SoldierMsg(int nSoldierId, bool nBattleRole, int boardIndex, int nSoldierLv, SoldierAttr soldierAttr)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			}
			_ = -(nint)2061761028;
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}
	}

	public struct SoldierLevelMsg
	{
		public List<SoldierMsg> SoldierData;

		public Dictionary<int, List<int>> PartnerArrDic;

		public int nHarvestCount;

		public List<int> buffEffectList;

		public unsafe SoldierLevelMsg(int a)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Expected Obj, but got F4
			((object[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (float)(*(nint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}

		public void AddPartner(int partnerId, int[] soldiers)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected I4, but got Unknown
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
			}
		}

		public unsafe string ToJson()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Expected native int or pointer, but got F8
			//IL_0004: Expected Obj, but got I8
			_ = ((Array)(*(long*)(nint)(*(double*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)))).LongLength;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public struct SoldierAttr
	{
		public int Hp;

		public int HpMax;

		public int Atk;

		public int Def;

		public int CritRate;

		public int CritResistance;

		public int CritPower;

		public int HitRate;

		public int Evd;

		public int DefPierce;

		public int DefIgnore;

		public int Suppress;

		public int Energy;

		public int InitialEnergy;

		public float Recovery;

		public int ATKSPD_P;
	}

	public class SoldierSummonData
	{
		public SoldierActor summoner;

		public SoldierActor summoned;

		public long summonerId;

		public long entityId;

		public int dataID;

		public bool isEnemyCamp;

		public bool isAlive;
	}

	[CompilerGenerated]
	private sealed class _003CyieldBattleStart_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SoldierLevelController _003C_003E4__this;

		private FP _003CwaitSeconds_003E5__2;

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
		public _003CyieldBattleStart_003Ed__53(int _003C_003E1__state)
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
			//IL_0126: Expected I4, but got Unknown
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

	private bool isStartTime;

	private FP timeing;

	private int totalTime;

	private int levelTotalTime;

	private bool isDpsCheckStage;

	private long dpsCheckStageTotalDamage;

	private bool isBothAddBuff;

	private SoldierFloor soldierFloor;

	private FP supportAttackCD;

	protected const string ZoomFreezeKey = "ZoomFreeze";

	protected const string ZoomDurationTimeKey = "ZoomInDurationTime";

	private float _zoomFreeze;

	private float _zoomDurationTime;

	private bool isSettlement;

	private FP ourLastSupportCastTime;

	private int ourLastSupportCastActorId;

	private FP enemyLastSupportCastTime;

	private int enemyLastSupportCastActorId;

	private List<SoldierSpawnPoint> listEnemyCamp;

	private Dictionary<int, SoldierSpawnPoint> dicOurSide;

	private List<SoldierActor> ourBattleActors;

	private List<SoldierActor> ourSupportActors;

	private List<SoldierActor> enemyBattleActors;

	private List<SoldierActor> enemySupportActors;

	private long enemyBattleTotalHP;

	private List<long> enemyBattleActorsUid;

	private SoldierActor _ourMainControlActor;

	private SoldierActor _enemyMainControlActor;

	private int _ourAliveBattleCount;

	private int _enemyAliveBattleCount;

	private Dictionary<int, int> PartnerLvList;

	public Dictionary<int, List<int>> PartnerDic;

	public Dictionary<int, SoldierMsg> dicSoldierMsg;

	public Dictionary<int, SoldierAttr> dicSoldierAttr;

	private readonly List<AIAdapter> _partnerScripts;

	private AIAdapter _bossPassiveScripts;

	private Dictionary<long, long> ourSoldierDamage;

	private int EnemyCampLv;

	public int EnemyAmendLv;

	public int RatioStage;

	private int BossTemPlateId;

	private SoldierLevelMsg soldierMsg;

	public int shopLv;

	private readonly List<SoldierSummonData> soldierSummons;

	public SoldierActor mainControlActor
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected I4, but got Unknown
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
			}
		}
	}

	public SoldierActor enemyMainControlActor
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected I4, but got Unknown
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
			}
		}
	}

	public SoldierActor GetMainControlActor(bool isEnemyCamp)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 210 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xC4*/;
		}
	}

	private SoldierActor PickMainControlActor(List<SoldierActor> battle)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public override void Load(AdventureModuleLevelLoadParams param = null, Action callback = null)
	{
		//Discarded unreachable code: IL_0102
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got I
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/;
		}
		_ = -1968634372;
		/*Error near IL_000e: Unknown opcode: 0xE7*/;
	}

	protected override void LevelLoadComplete(string sceneName)
	{
		//Discarded unreachable code: IL_0199
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I8
		//IL_0011: Invalid comparison between Unknown and I4
		if ((long)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) > 5357313835286072314L)
		{
			/*Error: Invalid branch target*/;
		}
		if ((int)/*Error near IL_0013: Stack underflow*/ < (int)checked((ushort)unchecked((uint)checked((sbyte)/*Error near IL_0010: Stack underflow*/))))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0013: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0014: Unknown opcode: 0xE6*/;
	}

	public override void LevelStart(Action callback = null)
	{
		//Discarded unreachable code: IL_014c, IL_0188, IL_01b1
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			SoldierPositionEffect soldierPositionEffect = (SoldierPositionEffect)/*Error near IL_000a: Stack underflow*/;
		}
		/*Error near IL_000a: Unknown opcode: 0xB2*/;
	}

	[IteratorStateMachine(typeof(_003CyieldBattleStart_003Ed__53))]
	private IEnumerator yieldBattleStart()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_0008: Stack underflow*/ != /*Error near IL_0005: ldloc 0 (out-of-bounds)*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public override void UpdateLogic(FP logicDeltaTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)((nuint)/*Error near IL_0007: Stack underflow*/ * 1692873986);
			/*Error near IL_000e: Unknown opcode: 0xCD*/;
		}
	}

	public unsafe override void LevelEnd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		*(float*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0f;
		/*Error near IL_0003: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private void EnableAIAdapterScripts()
	{
		//Discarded unreachable code: IL_0010
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void DisableAIAdapterScripts()
	{
		//Discarded unreachable code: IL_000c
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected I4, but got Unknown
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
		}
	}

	private void UpdateAIAdapterScripts()
	{
		//Discarded unreachable code: IL_000c
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected I4, but got Unknown
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

	public void NotifySupportPromoted(SoldierActor actor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	private void ApplyBothAddBuff(SoldierActor actor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	private void ApplyBothAddBuffToList(List<SoldierActor> list)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I4, but got Unknown
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

	private void DispatchSupportCastRequests()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)(ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0009: Invalid metadata token*/;
		}
	}

	private void DispatchSupportCastForCamp(List<SoldierActor> supports)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public bool CanCastSupportSkill(int actorId, bool isEnemyCamp)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 211 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			_ = ((IntPtr[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/];
			/*Error near IL_0005: Unknown opcode: 0xAF*/;
		}
	}

	public void MarkSupportCast(int actorId, bool isEnemyCamp)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 222 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xC4*/;
		}
	}

	private SoldierActor SpawnChess(SoldierSpawnPoint point)
	{
		/*Error: Unknown opcode: 0xEC*/;
	}

	public SoldierActor SpawnSupport(int chessId, int potentialLv, int enemyCampLv, bool isEnemyCamp = false, TSVector2 position = default(TSVector2), FP rotation = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	private SoldierActor SpawnChessInternal(int chessId, int potentialLv, int enemyCampLv, SoldierActor.SoldierRole role, bool isEnemyCamp, TSVector2 position, FP rotation, SoldierActor summoner = null, bool inheritAttr = true)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void SetSoldierTechEffect(SoldierActor actor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Unknown opcode: 0xF6*/;
	}

	public SoldierLevelMsg DecodeData(string str)
	{
		//Discarded unreachable code: IL_0010
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	public bool IsCoroutineAlive()
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public bool IsCoroutineRunning()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public FP GetCoroutineDeltaTime()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = -1;
		/*Error: End of method reached without returning.*/;
	}

	public CoroutineNode StartLogicCoroutine(IEnumerator routine, bool runImmediately = false)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void StopLogicCoroutine(CoroutineNode coroutine)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void SetSoldierDamageID(long uId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected I4, but got Unknown
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
		}
	}

	protected void MonsterDied(IEvent ievent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	protected unsafe void LevelStateChangedCall(HotfixEnum.levelState levelState)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xA9*/;
	}

	private bool BelongsTo(List<SoldierActor> list, long entityId)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private unsafe void OnActorReceiveDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private void OnActorReceiveDirectDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void OnActorReceiveDotDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void OnActorReceiveKillDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((sbyte[])/*Error near IL_0003: Stack underflow*/)[*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0003: Invalid field token*/;
	}

	private long ResolveDamageAttributionId(long fromId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected I4, but got Unknown
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
		}
	}

	private void SetSoldierDamageValue(long uId, long damageValue)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
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
		}
	}

	private void SetEnemyBattleHp(long uId, long damageValue)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected I4, but got Unknown
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
		}
	}

	public List<SoldierActor> GetBattleActors(AdventureActor self, List<SoldierActor> buffer = null)
	{
		/*Error: Invalid metadata token*/;
	}

	public List<SoldierActor> GetSupportActors(AdventureActor self, List<SoldierActor> buffer = null)
	{
		/*Error: Invalid metadata token*/;
	}

	public List<SoldierActor> GetAllActors(AdventureActor self, List<SoldierActor> buffer = null)
	{
		/*Error: Invalid metadata token*/;
	}

	public List<SoldierActor> GetAllActorsAllCamp(List<SoldierActor> buffer = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 212 (out-of-bounds)*/;
			if (unchecked((int)/*Error near IL_000a: Stack underflow*/) == ((sbyte[])/*Error near IL_0005: Stack underflow*/)[(long)/*Error near IL_0004: Stack underflow*/])
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_000d: Not a type handle*/;
		}
	}

	private List<SoldierActor> CollectAlive(AdventureActor self, bool includeBattle, bool includeSupport, List<SoldierActor> buffer)
	{
		/*Error: Unknown opcode: 0xE3*/;
	}

	private void AppendAlive(List<SoldierActor> source, List<SoldierActor> dest)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public int GetBattlePartnerCount(AdventureActor self, HotfixEnum.ChessPartnerType type)
	{
		/*Error: Invalid metadata token*/;
	}

	public int GetSupportPartnerCount(AdventureActor self, HotfixEnum.ChessPartnerType type)
	{
		/*Error: Invalid metadata token*/;
	}

	public int GetAllPartnerCount(AdventureActor self, HotfixEnum.ChessPartnerType type)
	{
		/*Error: Invalid metadata token*/;
	}

	private unsafe int CountPartner(AdventureActor self, HotfixEnum.ChessPartnerType type, bool includeBattle, bool includeSupport)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private int CountPartnerInList(List<SoldierActor> source, HotfixEnum.ChessPartnerType type)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public int GetPartnerLv(HotfixEnum.ChessPartnerType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected I4, but got Unknown
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
		}
	}

	public SoldierPartner GetSoldierPartner(HotfixEnum.ChessPartnerType type, int lv)
	{
		//Discarded unreachable code: IL_0010
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void AddItem(int itemId, int itemCount)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe int GetHarvestCount()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0007: Stack underflow*/ != /*Error near IL_0002: Stack underflow*/- *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Unknown opcode: 0xE9*/;
	}

	public SoldierActor SpawnSoldierSummon(SoldierActor summoner, int chessId, TSVector2 position, FP rotation = default(FP), bool isClearSelf = true, bool inheritAttr = true, SoldierActor.SoldierRole role = SoldierActor.SoldierRole.Battle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 205 (out-of-bounds)*/;
		}
		bool flag = (byte)/*Error near IL_0004: Stack underflow*/ != 0;
		/*Error near IL_0004: Not a type handle*/;
	}

	public void AddSoldierSummon(SoldierActor summoner, SoldierActor summoned, long entityId, int dataId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	public void AddSoldierSummon(SoldierActor summoner, SoldierActor summoned)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	public void MarkSoldierSummonDead(long entityId)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void RemoveSoldierSummon(long entityId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
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

	public void RemoveSoldierSummonsBySummoner(long summonerId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
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

	public int GetSoldierSummonCount(long summonerId, int dataId = -1, bool aliveOnly = true)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public List<SoldierSummonData> GetSoldierSummonInfos()
	{
		/*Error: Invalid field token*/;
	}

	public unsafe void ClearSoldierSummonData()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		if (/*Error near IL_0007: Stack underflow*/ > /*Error near IL_0007: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Invalid field token*/;
	}

	public SoldierLevelController()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}
}
