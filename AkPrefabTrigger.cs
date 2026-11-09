using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AK.Wwise;
using UnityEngine;

public class AkPrefabTrigger : MonoBehaviour
{
	public enum EventTriggerType
	{
		onTick,
		onExit,
		onBeginOverlarp,
		onEndOverlarp
	}

	[CompilerGenerated]
	private sealed class _003CtoWaitoRestar_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AkPrefabTrigger _003C_003E4__this;

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
		public _003CtoWaitoRestar_003Ed__33(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected I4, but got Unknown
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

	public string _WiseEvent;

	public string _WwiseStateGroup;

	public string _WwiseStateGroupSate;

	public string[] _swichLs;

	public Event WiseEvent;

	public State WwiseState;

	public List<Switch> WwiseSwitchs = new List<Switch>();

	public EventTriggerType _EventTriggerType;

	public GameObject TargetTiggerObj;

	public string TargetTiggerName;

	public bool FxObjFindOwner;

	public GameObject FxObjOwner;

	public AkAmbientLargeModePositioner[] LargeModePositions;

	public MultiPositionTypeLabel multiPositionType;

	public float _delayTime;

	private AkGameObj _AkGameObj;

	private int triggerIndex;

	private bool iExit;

	public string _rtpcName;

	public int _rtpcValue;

	public int _rtpcDuration;

	public bool _rtpcGloabel;

	public bool saveBankRes;

	private WaitForEndOfFrame wait;

	private AdventureFXPlayer akFx;

	private float _duration;

	private AkPositionArray BuildAkPositionArray()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		List<AkAmbientLargeModePositioner> list = new List<AkAmbientLargeModePositioner>();
		for (int i = 0; i < LargeModePositions.Length; i++)
		{
			if ((Object)(object)LargeModePositions[i] != (Object)null && !list.Contains(LargeModePositions[i]))
			{
				list.Add(LargeModePositions[i]);
			}
		}
		AkPositionArray val = new AkPositionArray((uint)list.Count);
		for (int j = 0; j < list.Count; j++)
		{
			val.Add(AkVector64.op_Implicit(list[j].Position), list[j].Forward, list[j].Up);
		}
		return val;
	}

	private void Awake()
	{
		if ((Object)(object)_AkGameObj == (Object)null)
		{
			_AkGameObj = getAkObj().GetComponent<AkGameObj>();
			if ((Object)(object)_AkGameObj == (Object)null)
			{
				_AkGameObj = getAkObj().AddComponent<AkGameObj>();
			}
		}
	}

	private void OnEnable()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		if ((int)multiPositionType == 1)
		{
			if (LargeModePositions.Length != 0)
			{
				((Behaviour)_AkGameObj).enabled = false;
			}
		}
		else if ((int)multiPositionType == 2)
		{
			((Behaviour)_AkGameObj).enabled = false;
			if (AkAmbient.multiPosEventTree.TryGetValue(getId(), out var value))
			{
				if (!value.listObj.Contains(((Component)this).gameObject))
				{
					value.listObj.Add(((Component)this).gameObject);
				}
			}
			else
			{
				value = new AkMultiPosEvent();
				value.listObj.Add(((Component)this).gameObject);
				AkAmbient.multiPosEventTree.Add(getId(), value);
			}
			AkPositionArray val = BuildMultiDirectionArray(value);
			AkSoundEngine.SetMultiplePositions(value.listObj[0], val, (ushort)val.Count, (AkMultiPositionType)2);
		}
		_duration = 0f;
		OnTick();
	}

	public AkPositionArray BuildMultiDirectionArray(AkMultiPosEvent eventPosList)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		AkPositionArray val = new AkPositionArray((uint)eventPosList.list.Count);
		for (int i = 0; i < eventPosList.list.Count; i++)
		{
			val.Add(AkVector64.op_Implicit(((Component)eventPosList.list[i]).transform.position), ((Component)eventPosList.list[i]).transform.forward, ((Component)eventPosList.list[i]).transform.up);
		}
		return val;
	}

	private void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) - 0;
		/*Error near IL_0003: starg 236 (out-of-bounds)*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	private bool haveAkGameObj()
	{
		if ((Object)(object)_AkGameObj != (Object)null)
		{
			return true;
		}
		_AkGameObj = getAkObj().GetComponent<AkGameObj>();
		return (Object)(object)_AkGameObj != (Object)null;
	}

	[IteratorStateMachine(typeof(_003CtoWaitoRestar_003Ed__33))]
	private IEnumerator toWaitoRestar()
	{
		//yield-return decompiler failed: Could not find currentField
		return new _003CtoWaitoRestar_003Ed__33(0)
		{
			_003C_003E4__this = this
		};
	}

	private bool CheckDelayExcute()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)(ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0008: Read out of bounds.*/;
		}
	}

	private GameObject getAkObj()
	{
		if ((Object)(object)FxObjOwner != (Object)null)
		{
			return FxObjOwner;
		}
		if (FxObjFindOwner)
		{
			AdventureFXPlayer component = ((Component)this).GetComponent<AdventureFXPlayer>();
			if ((Object)(object)component != (Object)null && (Object)(object)component.owner != (Object)null)
			{
				return component.owner;
			}
		}
		return ((Component)this).gameObject;
	}

	private RTPC_MonsterType GetRTPC_Type()
	{
		AdventureFXPlayer component = ((Component)this).GetComponent<AdventureFXPlayer>();
		if ((Object)(object)component != (Object)null && (component.bindActor != null || (Object)(object)component.owner != (Object)null))
		{
			if (component.ownerActor is MonsterAdventureActor monsterAdventureActor)
			{
				if (monsterAdventureActor.monsterInfo.originEpicType != HotfixEnum.monsterEpicType.LEADER)
				{
					return (RTPC_MonsterType)1;
				}
				return (RTPC_MonsterType)2;
			}
			if (component.bindActor is MonsterAdventureActor monsterAdventureActor2)
			{
				if (monsterAdventureActor2.monsterInfo.originEpicType != HotfixEnum.monsterEpicType.LEADER)
				{
					return (RTPC_MonsterType)1;
				}
				return (RTPC_MonsterType)2;
			}
		}
		return (RTPC_MonsterType)0;
	}

	public void toPostSet()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Invalid comparison between Unknown and I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		if ((int)multiPositionType == 1 && LargeModePositions.Length != 0)
		{
			((Behaviour)_AkGameObj).enabled = false;
			AkPositionArray val = BuildAkPositionArray();
			AkSoundEngine.SetMultiplePositions(((Component)this).gameObject, val, (ushort)val.Count, (AkMultiPositionType)2);
		}
		if (!string.IsNullOrEmpty(_WwiseStateGroup) && !string.IsNullOrEmpty(_WwiseStateGroupSate))
		{
			WwiseAudioManager instance = MonoSingleton<WwiseAudioManager>.Instance;
			if (instance != null)
			{
				instance.SetState_Custom(_WwiseStateGroup, _WwiseStateGroupSate);
			}
		}
		else
		{
			WwiseAudioManager instance2 = MonoSingleton<WwiseAudioManager>.Instance;
			if (instance2 != null)
			{
				instance2.SetState_Custom(WwiseState);
			}
		}
		if (_swichLs != null && _swichLs.Length > 1)
		{
			for (int i = 0; i < _swichLs.Length / 2; i++)
			{
				WwiseAudioManager instance3 = MonoSingleton<WwiseAudioManager>.Instance;
				if (instance3 != null)
				{
					instance3.SetSwicth(_swichLs[2 * i], _swichLs[2 * i + 1], getAkObj());
				}
			}
		}
		else if (WwiseSwitchs.Count > 0)
		{
			for (int j = 0; j < WwiseSwitchs.Count; j++)
			{
				WwiseAudioManager instance4 = MonoSingleton<WwiseAudioManager>.Instance;
				if (instance4 != null)
				{
					instance4.SetSwicth(WwiseSwitchs[j], getAkObj());
				}
			}
		}
		if (!string.IsNullOrEmpty(_WiseEvent) || (WiseEvent != null && !string.IsNullOrEmpty(((BaseType)WiseEvent).Name)))
		{
			if ((int)multiPositionType == 2)
			{
				AkMultiPosEvent val2 = AkAmbient.multiPosEventTree[getId()];
				if (!AdventureStateProxy.IsLoadingLevel)
				{
					GameObject val3 = val2.listObj[0];
					WwiseAudioManager instance5 = MonoSingleton<WwiseAudioManager>.Instance;
					if (instance5 != null)
					{
						instance5.PlaySound(GetWwiseName(), val3, !saveBankRes, GetRTPC_Type());
					}
				}
			}
			else if (!AdventureStateProxy.IsLoadingLevel)
			{
				WwiseAudioManager instance6 = MonoSingleton<WwiseAudioManager>.Instance;
				if (instance6 != null)
				{
					instance6.PlaySound(GetWwiseName(), getAkObj(), !saveBankRes, GetRTPC_Type());
				}
			}
		}
		if (!string.IsNullOrEmpty(_rtpcName))
		{
			AkSoundEngine.SetRTPCValue(_rtpcName, (float)_rtpcValue, _rtpcGloabel ? null : getAkObj(), _rtpcDuration);
		}
	}

	public string GetWwiseName()
	{
		if (!string.IsNullOrEmpty(_WiseEvent))
		{
			return _WiseEvent;
		}
		return ((BaseType)WiseEvent).Name;
	}

	private uint getId()
	{
		if (!string.IsNullOrEmpty(_WiseEvent))
		{
			WwiseObjectReference wwiseObjBankRef = AllWwiseScriptableObject.Instance.GetWwiseObjBankRef(_WiseEvent);
			if (!((Object)(object)wwiseObjBankRef != (Object)null))
			{
				return 0u;
			}
			return wwiseObjBankRef.Id;
		}
		if (WiseEvent != null)
		{
			return ((BaseType)WiseEvent).Id;
		}
		return 0u;
	}

	private void OnTick()
	{
		iExit = false;
		triggerIndex++;
		if (_EventTriggerType != EventTriggerType.onExit && haveAkGameObj())
		{
			_AkGameObj.SetPosition();
		}
		if (_EventTriggerType == EventTriggerType.onTick)
		{
			if (!FxObjFindOwner && _delayTime <= 0f && triggerIndex < 2)
			{
				toPostSet();
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(toWaitoRestar());
			}
		}
	}

	public void OnExit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
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

	private void OnTriggerEnter(Collider other)
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

	private void OnTriggerExit(Collider other)
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
}
