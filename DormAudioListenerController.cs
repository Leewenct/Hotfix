using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DormAudioListenerController : SceneSingleton<DormAudioListenerController>
{
	public enum Mode
	{
		Default,
		DefaultWithFocus,
		View,
		ViewWithFocus,
		Edit,
		Visitor,
		SwitchActor
	}

	public DormAudioListenerConfigData modeConfigDefault;

	public DormAudioListenerConfigData modeConfigDefaultWithFocus;

	public DormAudioListenerConfigData modeConfigView;

	public DormAudioListenerConfigData modeConfigViewWithFocus;

	public DormAudioListenerConfigData modeConfigEdit;

	public DormAudioListenerConfigData modeConfigVisitor;

	public DormAudioListenerConfigData modeConfigSwitchActor;

	[Space]
	public Vector3 listenerTargetPositionOffset;

	public float modeSwitchSmoothTime;

	[Space]
	public GameObject audioTriggerAgent;

	private Transform _cameraTrans;

	private Mode _mode;

	private float _curForwardOffset;

	private bool _transitionActive;

	private float _transitionElapsed;

	private float _transitionStartForwardOffset;

	private Vector3 _transitionStartListenerPosition;

	private Vector3 _transitionStartAgentPosition;

	private void Start()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			((sbyte[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/] = 0;
			_ = (sbyte)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private void LateUpdate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void SwitchDormMode(DormActor.DormMode dormMode)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid field token*/;
		}
	}

	public void NotifyEnterFocus()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
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

	public void NotifyExitFocus()
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

	private DormAudioListenerConfigData GetModeConfig(Mode mode)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid field token*/;
		}
	}

	private void BeginTransition()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and Obj
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_003F val = /*Error near IL_0008: Stack underflow*/+ (ulong)/*Error near IL_0007: Stack underflow*/;
			if (System.Runtime.CompilerServices.Unsafe.As<_003F, UIntPtr>(ref val) <= System.Runtime.CompilerServices.Unsafe.As<DormAudioListenerController, UIntPtr>(ref this))
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)unchecked((nint)checked((nuint)unchecked((short)/*Error near IL_000c: Stack underflow*/)));
			/*Error near IL_000e: Unknown opcode: 0xCD*/;
		}
	}

	public DormAudioListenerController()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
		_ = -6;
		/*Error near IL_0003: Unknown opcode: 0xCC*/;
	}
}
