using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AIScript.Character._13401;

public class SkillScript_NormalAttack : SkillAdvancedBase
{
	private List<string> _curComboTagList;

	private int _stage;

	private string _comboTag;

	protected bool IsStrength
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	protected override void OnSkillEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		((short[])/*Error near IL_0003: Stack underflow*/)[val] = 0;
		_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected virtual void UpdateStrengthState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			if (!float.IsFinite((int)unchecked((long)checked((ulong)/*Error near IL_0007: Stack underflow*/))))
			{
				throw new ArithmeticException();
			}
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	protected virtual List<string> GetComboTagList()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F8, but got I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected Obj, but got Unknown
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = 0u;
		/*Error near IL_0003: starg 237 (out-of-bounds)*/;
		((double[])/*Error near IL_0007: Stack underflow*/)[val] = 4.0;
		return (List<string>)(/*Error near IL_0008: Stack underflow*/ | /*Error near IL_0008: Stack underflow*/);
	}

	protected virtual int GetStage()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F8, but got I4
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = 0u;
		/*Error near IL_0003: starg 237 (out-of-bounds)*/;
		((double[])/*Error near IL_0007: Stack underflow*/)[val] = 4.0;
		/*Error near IL_0007: Unknown opcode: 0xF1*/;
	}

	public void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected I4, but got Unknown
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
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		}
	}

	private unsafe void OnBeforeHit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (byte)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	protected virtual void OnBeforeNormalAttackHit(AdventureActorReceiveDamageBeforeHitEvent beforeHitEvent)
	{
	}

	protected virtual void OnBeforeStrengthNormalAttackHit(AdventureActorReceiveDamageBeforeHitEvent beforeHitEvent)
	{
	}

	private unsafe void OnCustomEvent(string eventName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*/% *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Unknown opcode: 0xA7*/;
	}

	protected virtual int GetConsumeAmmo()
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	protected virtual void RecordStage(int nextStage)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F8, but got I4
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = 0u;
		/*Error near IL_0003: starg 237 (out-of-bounds)*/;
		((double[])/*Error near IL_0007: Stack underflow*/)[val] = 4.0;
		_ = (ushort)/*Error near IL_0008: Stack underflow*/;
		/*Error near IL_0008: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0009: Unknown opcode: 0xF6*/;
	}

	public void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	private void UpdateRootMotionState()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected virtual void OnNormalAttackFinish()
	{
	}

	protected virtual void OnStrengthNormalAttackFinish()
	{
	}

	protected override void OnReceiveDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Invalid metadata token*/;
		}
		/*Error near IL_0014: Unknown opcode: 0xEE*/;
	}

	private void OnFinish()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	private void OnInterrupt()
	{
		/*Error: Read out of bounds.*/;
	}

	protected override void OnSkillDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		((sbyte[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public SkillScript_NormalAttack()
	{
		/*Error: Invalid field token*/;
	}
}
