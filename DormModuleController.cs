using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

public class DormModuleController : ModuleController<DormModuleController>, IEventDispatcher
{
	[CompilerGenerated]
	private sealed class _003CDelayCallBack_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action callBack;

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
		public _003CDelayCallBack_003Ed__57(int _003C_003E1__state)
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
			//IL_0041: Expected I4, but got Unknown
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

	private Logger _logger;

	private AIAdapter _levelManagerAdapter;

	private StandaloneLockStepManager _lockStepManager;

	internal const long INVALID_UID = -1L;

	private long _uidCounter;

	private bool _lockEntitiesListUpdate;

	private List<DynamicSimpleEntity> _delayDespawnEntities;

	private Dictionary<long, DynamicSimpleEntity> _entityIDMap;

	private const string DORM_LEVEL_STATE_CHANGED = "DORM_LEVEL_STATE_CHANGED";

	private const string DORM_LEVEL_FINISH = "DORM_LEVEL_FINISH";

	private EventDispatcher _dispatcher;

	protected readonly Dictionary<string, List<BaseAdventureEvent>> _eventPool;

	private readonly string _levelManagerTypeStr;

	private GameObject dynamicLevelControllerContent;

	private AdventureTimeControlManager _globalTimeControlManager;

	private List<DynamicSimpleEntity> entities
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public List<DynamicSimpleEntity> ActorEntities
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xF7*/;
			}
		}
	}

	private DynamicLevelController _levelInstance
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public DynamicLevelController levelInstance
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	protected AdventureTimeControlManager globalTimeControlManager
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected I4, but got Unknown
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
	}

	protected override void Awake()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) & 0;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	private void OnEnable()
	{
		/*Error: Invalid field token*/;
	}

	private unsafe void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if ((int)/*Error near IL_0005: Stack underflow*/ < *(int*)(nint)/*Error near IL_0004: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: Read out of bounds.*/;
	}

	public unsafe override void OnEnter(Action flowCallback)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = (ulong)/*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xCF*/;
	}

	public override void OnBeforeExit()
	{
		/*Error: Invalid field token*/;
	}

	public override void OnExit(Action flowCallback)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void EnsureLockStepManager()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void ReleaseLockStepManager()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
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
		}
	}

	public DynamicSimpleEntity QueryEntityByID(long id)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected I4, but got Unknown
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
		}
	}

	public void RegisterEntity(DynamicSimpleEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xF7*/;
		}
	}

	public void UnRegisterEntity(DynamicSimpleEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xF7*/;
		}
	}

	private void UpdateEntitiesList()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void RegisterEventListeners()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private unsafe void LevelStateChanged(IEvent iEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (int)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public bool AddEventListener(string aEventName_string, EventDelegate aEventDelegate)
	{
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldarg 3 (out-of-bounds)*/;
			/*Error near IL_0002: Unknown opcode: 0xE1*/;
		}
	}

	public bool AddEventListener(string aEventName_string, EventDelegate aEventDelegate, EventDispatchMode aEventDispatchMode)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public bool HasEventListener(string aEventName_string, EventDelegate aEventDelegate)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xFA*/;
	}

	public bool RemoveEventListener(string aEventName_string, EventDelegate aEventDelegate)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xFA*/;
	}

	public bool RemoveAllEventListeners()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public T GenerateEvent<T>(string eventType) where T : BaseAdventureEvent, new()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected I4, but got Unknown
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

	public void ReleaseEvent(BaseAdventureEvent aEvent)
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

	public bool DispatchEvent(BaseAdventureEvent aEvent)
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

	public bool DispatchEvent(IEvent aIEvent)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public bool DispatchEventWithData(string type, object sender, object data)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public bool DispatchEventWithReturnData(string type, object sender, object data, out int returnInt, out object returnData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I4, but got Unknown
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

	public DynamicLevelController InitDynamicLevelControllerContent(Type levelController)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	private void InitModuleLevel()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xF7*/;
		}
	}

	public unsafe void LoadLevel(Action flowCallback = null)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Not a type handle*/;
	}

	protected void UnloadLevel(bool levelFinish, Action callback)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	private void LevelStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xF7*/;
		}
	}

	[IteratorStateMachine(typeof(_003CDelayCallBack_003Ed__57))]
	private IEnumerator DelayCallBack(Action callBack)
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_0008: Stack underflow*/ < /*Error near IL_0005: ldloc 0 (out-of-bounds)*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public void LevelStateChanged(bool isLevelFinish, float fadeTime)
	{
		_ = (long)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCE*/;
	}

	private unsafe void LevelEnd(bool isLevelFinish, float fadeTime = 0f)
	{
		//IL_0002: Expected I8, but got I4
		((long[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}

	protected void LevelFinish()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xF7*/;
		}
	}

	private void InitModule()
	{
		/*Error: Invalid field token*/;
	}

	protected unsafe void ModuleLogicInit()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xF4*/;
	}

	protected void TimeControlUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected I4, but got Unknown
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
		}
	}

	public void TimeControlReset()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected I4, but got Unknown
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

	public AdventureTimeControlHandler FreezeFrame(FP timeScale, FP duration, Action onFinish = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 2;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public AdventureTimeControlHandler LogicTimeScale(FP timeScale, FP duration = default(FP), Action onFinish = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 2;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public bool InGlobalFreezeFrame()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public unsafe DormModuleController()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ~(nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: ldloca 236 (out-of-bounds)*/;
		_ = 0;
		/*Error near IL_0006: Unknown opcode: 0xF0*/;
	}
}
