using TrueSync;

namespace AIScript;

public class TowerDefenseItemChargeBase
{
	private const string TOWERDEFENSE_UPDATE_ITEM_CARD = "TOWERDEFENSE_UPDATE_ITEM_CARD";

	private const string TOWERDEFENSE_UPDATE_ITEM_ENERGY = "TOWERDEFENSE_UPDATE_ITEM_ENERGY";

	private const string TOWERDEFENSE_SHOW_ITEM_ENERGY = "TOWERDEFENSE_SHOW_ITEM_ENERGY";

	private int itemID;

	protected int amount;

	protected int p1;

	protected int p2;

	protected int p3;

	public int curItemNum;

	protected bool startLogc;

	private bool showEnergy;

	public virtual void InitConfig(int id, int amount, int p1, int p2, int p3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
		}
		_ = -(-927204860);
		/*Error near IL_000e: Unknown opcode: 0xE7*/;
	}

	public unsafe virtual void StartLogic()
	{
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void ShowEnergy()
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

	protected void CloseEnergy()
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

	protected void UpdateEnergy(FP value)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public virtual void UpdateLogic()
	{
	}

	private void UpdateItemCardNum()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void AddItemCardNum(int num = 1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I8
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((long)/*Error near IL_0009: Stack underflow*/ <= (long)checked((ulong)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Unknown opcode: 0xFA*/;
		}
		checked
		{
			_ = (long)/*Error near IL_000e: Stack underflow*/;
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}
	}

	public void MinusItemCardNum(int num = 1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I8
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((long)/*Error near IL_0009: Stack underflow*/ <= (long)checked((ulong)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Unknown opcode: 0xFA*/;
		}
		checked
		{
			_ = (ulong)/*Error near IL_000e: Stack underflow*/;
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}
	}
}
