using System.Collections.Generic;
using Nova.Hotfix;
using TrueSync;

public abstract class AdventureEffectBase
{
	protected AdventureEffect _effect;

	protected List<AdventureActor> _targets;

	public ExecuteEffectInfo executeEffectInfo;

	protected unsafe AdventureActor _owner
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = ((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			/*Error near IL_0003: Unknown opcode: 0xC0*/;
		}
	}

	protected unsafe AdventureActor _fromActor
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = ((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			/*Error near IL_0003: Unknown opcode: 0xC0*/;
		}
	}

	public unsafe EffectValue effectValueConfig
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = ((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			/*Error near IL_0003: Unknown opcode: 0xC0*/;
		}
	}

	public unsafe FP OrginMaxCd
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = ((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			/*Error near IL_0003: Unknown opcode: 0xC0*/;
		}
	}

	public unsafe long Damage
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = ((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			/*Error near IL_0003: Unknown opcode: 0xC0*/;
		}
	}

	public unsafe FP CD
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = ((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			/*Error near IL_0003: Unknown opcode: 0xC0*/;
		}
		set
		{
			/*Error near IL_0001: Unknown opcode: 0xFD*/;
		}
	}

	public unsafe FP MaxCD
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = ((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			/*Error near IL_0003: Unknown opcode: 0xC0*/;
		}
		set
		{
			/*Error near IL_0001: Unknown opcode: 0xFD*/;
		}
	}

	public unsafe bool Removed
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = ((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			/*Error near IL_0003: Unknown opcode: 0xC0*/;
		}
		set
		{
			/*Error near IL_0001: Unknown opcode: 0xFD*/;
		}
	}

	public void SetEffectTargets(AdventureEffect effect, List<AdventureActor> targets)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public virtual void Execute()
	{
	}

	public virtual void AddListenerer()
	{
	}

	public virtual void PostExecute()
	{
	}

	public virtual void RemoveListener()
	{
	}

	public virtual void InitParams()
	{
	}

	public bool TryParseStringParamToInt(string value, out int intValue, bool allowEmpty = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public bool TryParseStringParamToFloat(string value, out float floatValue, bool allowEmpty = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}

	public bool TryParseStringParamToFDP(string value, out FDP floatValue, bool allowEmpty = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ != checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: stloc 2 (out-of-bounds)*/;
		((object[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (object)/*Error near IL_0008: Stack underflow*/;
		_ = 5;
		/*Error near IL_000a: Unknown opcode: 0xB0*/;
	}

	public bool TryParseStringParamToFP(string value, out FP fpValue, bool allowEmpty = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ != checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: stloc 2 (out-of-bounds)*/;
		if (/*Error near IL_0009: Stack underflow*/ != /*Error near IL_0009: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_000a: Unknown opcode: 0xB0*/;
	}

	public virtual void OnClear()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}
}
