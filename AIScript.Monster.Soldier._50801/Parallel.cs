namespace AIScript.Monster.Soldier._50801;

public class Parallel : AIBase
{
	private const int giftBoxItemId_1 = 40;

	private const int giftBoxItemId_3 = 40;

	private const int giftBoxCountMin_1 = 1;

	private const int giftBoxCountMax_1 = 2;

	private const int giftBoxCountMin_3 = 5;

	private const int giftBoxCountMax_3 = 10;

	private int _potentialLv;

	private bool _supportRewardGranted;

	private unsafe SoldierActor soldierActor
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xF7*/;
		}
	}

	public void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_000c: Stack underflow*/ >= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		checked
		{
			_ = (ulong)(/*Error near IL_000d: Stack underflow*/ * /*Error near IL_000d: Stack underflow*/);
			/*Error near IL_000e: Unknown opcode: 0xE6*/;
		}
	}

	public void OnDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private unsafe void OnActorDied(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((byte[])/*Error near IL_0003: Stack underflow*/)[*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0003: Invalid field token*/;
	}

	public Parallel()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Invalid metadata token*/;
	}
}
