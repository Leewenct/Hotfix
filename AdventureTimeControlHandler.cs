using System;
using System.Runtime.CompilerServices;
using TrueSync;

public class AdventureTimeControlHandler
{
	public enum TimeScaleType
	{
		Normal,
		FreezeFrame
	}

	public bool isLogicTime;

	public FP timeScaleTo;

	public FP transitionIn;

	public FP duration;

	public FP transitionOut;

	public TimeScaleType timeScaleType;

	public FP elapsedTime;

	public Action onFinish;

	private bool _isFinish;

	public FP fullDuration
	{
		get
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
	}

	public FP normalizedTime
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xC5*/;
			}
		}
	}

	public FP timeScale
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool isFinish
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		internal set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (ulong)/*Error near IL_0007: Stack underflow*/ + 1689974828;
			}
		}
	}

	public unsafe void SeekToTransitionIn()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/% *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		this = this;
		/*Error near IL_0005: stloc 0 (out-of-bounds)*/;
		if ((int)/*Error near IL_0008: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0009: Read out of bounds.*/;
	}

	public void SeekToTransitionOut()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/ + 1689971752;
		}
	}

	public void Reset()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public void Update(FP deltaTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xC9*/;
		}
	}

	public void Stop()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xC9*/;
		}
	}
}
