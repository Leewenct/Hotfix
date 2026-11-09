using System;
using UnityEngine;

[AddComponentMenu("触发器结果/表现事件/播放简单动画", 4)]
public class Task_PlayAnimator : TaskCellBase
{
	public enum AnimatorType
	{
		[InspectorName("动画引用")]
		instance,
		[InspectorName("动画路径")]
		path
	}

	public AnimatorType animatorType;

	public Animator animator;

	public string animatorPath;

	public string stateName;

	public float fadeTime;

	public bool suspendPlayer;

	public bool enableCinemaMode;

	public bool waitUntilFinish;

	private bool _played;

	private Animator _animator;

	protected override void OnExecute()
	{
		/*Error: Unknown opcode: 0xEC*/;
	}

	protected override void LogicUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected I4, but got Unknown
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

	protected override void OnStop(bool success)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_003F val2 = /*Error near IL_0001: ldloca 239 (out-of-bounds)*/;
		/*OpCode not supported: DebugBreak*/;
		((IntPtr[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (nint)checked((sbyte)unchecked((nuint)(nint)((IntPtr[])val)[val2]));
		_ = 88L;
		/*Error near IL_000b: Not a type handle*/;
	}

	protected void SetupAndPlay()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
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
		}
	}

	public Task_PlayAnimator()
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
