using System;
using System.Collections.Generic;
using UnityEngine;

public class PerformManager : SceneSingleton<PerformManager>
{
	public const int kCloseupPerformanceLayer = 26;

	private Action<bool> _onPerformFinish;

	private TimelinePerformPlayer _timelinePerformPlayer;

	private SettlementPerformPlayer _settlementPerformPlayer;

	public const string SettlementPerformLoadFinishEvent = "SettlementPerformLoadFinish";

	public bool InPerform
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected I4, but got Unknown
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
	}

	protected void Update()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected I4, but got Unknown
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

	public unsafe void PlaySettlementPerform(string sceneName, string outfitSoundStateName, List<int> performActors, Action<bool> onPerformFinish = null)
	{
		_ = ((uint[])/*Error near IL_0002: Stack underflow*/)[*(short*)(nint)/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Unknown opcode: 0xFC*/;
	}

	public void PlayTimelinePerform(GameObject timelineObj, Action<bool> onPerformFinish = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	public unsafe void PauseTimeLinePerform(bool isPause)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_003F val2 = /*Error near IL_0001: ldloca 220 (out-of-bounds)*/;
		/*OpCode not supported: DebugBreak*/;
		*(short*)(nint)/*Error near IL_0006: Stack underflow*/ = (short)(nint)((IntPtr[])val)[val2];
		((int[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (int)/*Error near IL_0007: Stack underflow*/;
	}

	public void StopTimeLinePerform()
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

	protected void OnPerformEnd(bool seccessed)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
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

	public PerformManager()
	{
		/*Error: Invalid field token*/;
	}
}
