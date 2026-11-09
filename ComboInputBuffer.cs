using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;

public class ComboInputBuffer
{
	public enum ActionKey
	{
		Nil = -1,
		A = 0,
		B = 1,
		C = 2,
		D = 3,
		E = 4,
		F = 5,
		G = 6,
		H = 7,
		I = 8,
		J = 9,
		K = 10,
		L = 11,
		M = 12,
		N = 13,
		O = 14,
		P = 15,
		Q = 16,
		R = 17,
		S = 18,
		T = 19,
		U = 20,
		V = 21,
		W = 22,
		X = 23,
		Y = 24,
		Z = 25,
		_0 = 90,
		_1 = 91,
		_2 = 92,
		_3 = 93,
		_4 = 94,
		_5 = 95,
		_6 = 96,
		_7 = 97,
		_8 = 98,
		_9 = 99
	}

	public enum InputResult
	{
		Execute,
		Accept,
		NoMatch,
		Invalid
	}

	private bool _keyPerfectMatch;

	public List<ActionKey> inputKeys
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

	public int maxInputCount
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

	public FP timeWindow
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

	public FP lastInputTime
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

	public bool inputBlocked
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

	public unsafe ComboInputBuffer(FP timeWindow, int maxInputCount = -1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (short)(*unchecked((nuint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public bool InputKey(ActionKey key, FP time)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public void FlushKeys(ActionKey[] keys, FP time, bool keyPerfectMatch = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (nuint)0u;
			/*Error near IL_0003: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void CancelKeys(int keyCount)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Unknown opcode: 0xF6*/;
		}
	}

	public unsafe void InputBlock()
	{
		//IL_0004: Invalid comparison between Unknown and I8
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
		if ((long)/*Error near IL_0006: Stack underflow*/ != ((long[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/])
		{
			/*Error: Invalid branch target*/;
		}
		_ = (ulong)/*Error near IL_0007: Stack underflow*/;
	}

	public void InputUnblock(FP time)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public bool IsInputTimeout(FP time)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public bool ValidateKeys(ActionKey[] keys)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 207 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public bool EqualsKeys(ActionKey[] keys)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (nuint)0u;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void ConsumeKeys(int consumeCount)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (nuint)0u;
			/*Error near IL_0003: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void Flush()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (nuint)0u;
			/*Error near IL_0003: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}
}
