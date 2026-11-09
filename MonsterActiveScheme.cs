using System.Runtime.CompilerServices;

public class MonsterActiveScheme : LogicComponent
{
	private enum MonsterActiveState
	{
		UnRef,
		Ref,
		Deactive,
		Active
	}

	private bool _deactived;

	private MonsterActiveState state;

	private bool forceActive;

	private unsafe MonsterAdventureActor _actor
	{
		get
		{
			_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xB1*/;
		}
	}

	public unsafe override void OnActive()
	{
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	public void UpdateLogic(LogicEntity activePlayerActor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (short)0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void ActiveActor(bool forceActive = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			throw 1722415620;
		}
	}

	private unsafe void DeactiveActor()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
		_ = *(short*)(nint)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Invalid field token*/;
	}

	private void DespawnActor()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public MonsterActiveScheme()
	{
		/*Error: Invalid field token*/;
	}
}
