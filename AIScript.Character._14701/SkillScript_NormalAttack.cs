using System;
using System.Collections.Generic;

namespace AIScript.Character._14701;

public class SkillScript_NormalAttack : SkillAdvancedBase
{
	private readonly Dictionary<int, string> dicKey;

	private string key_P1;

	private string evt_shoot1;

	private string evt_shoot2;

	private string evt_shoot3;

	private string evt_shoot4;

	private string evt_shoot5;

	private string evt_shoot6;

	private string evt_shoot7;

	private List<string> bullets;

	private SlotType slotType;

	private int resetNormal;

	private const int perkId_1 = 514701;

	private const int perkId_2 = 514702;

	private int buff_2;

	private const int perkId_5 = 514705;

	private int buff_5;

	private int atkIndex;

	protected override void OnSkillEnable()
	{
		/*Error: Invalid field token*/;
	}

	protected override void OnSkillDisable()
	{
		/*Error: Invalid field token*/;
	}

	public void OnStart()
	{
		/*Error: Read out of bounds.*/;
	}

	protected void OnFinish()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected void OnInterrupt()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
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

	private unsafe void DoMainLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected F4, but got I4
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			*unchecked((float*)(nint)/*Error near IL_0009: Stack underflow*/) = (int)unchecked((long)checked((ulong)/*Error near IL_0007: Stack underflow*/));
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	private void onCustomEvent(string evt)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private bool GetPerkLv(int perkId, out int lv)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe SkillScript_NormalAttack()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected F4, but got Unknown
		IntPtr intPtr = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_003F val = /*Error near IL_0002: ldarg 3 (out-of-bounds)*/;
		((float[])/*Error near IL_0004: Stack underflow*/)[(nint)intPtr] = (float)val;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}
}
