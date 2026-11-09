using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;

public class ActorShieldOld : LogicMonoComponent
{
	public delegate void ShieldChangedHandle(int oneValueC, int oneValueM);

	[CompilerGenerated]
	private ShieldChangedHandle m_shieldChangedEvent;

	private AdventureActor _actor;

	private bool iInit;

	private AttributeList attributeList;

	private SpecialAttributeList specialAttributeList;

	public long shiledValue
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected I4, but got Unknown
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
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Invalid metadata token*/;
			}
		}
	}

	public long maxShieldValue
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

	public event ShieldChangedHandle shieldChangedEvent
	{
		[CompilerGenerated]
		add
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
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
			}
		}
		[CompilerGenerated]
		remove
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
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
			}
		}
	}

	protected override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ushort)((object[])(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnShutdown()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			((sbyte[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/] = 0;
			_ = (ushort)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private void OnAttributeValueChanged(HotfixEnum.effectAttributeType attributeType, HotfixEnum.parameterType parameterType, FDP old, FDP diff)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			_ = ~(short)61218218088765943L;
			/*Error near IL_000c: Unknown opcode: 0xFB*/;
		}
	}

	private void OnSpecialValueChanged(HotfixEnum.specialAttributeType attributeType, HotfixEnum.parameterType parameterType, FDP old, FDP current)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public unsafe override void OnActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(byte*)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Not a type handle*/;
	}

	private void resetUIshieldValues()
	{
		/*Error near IL_0001: Unknown opcode: 0xE1*/;
	}

	public int DamageToShield(int damageValue, HotfixEnum.elementType elementType = HotfixEnum.elementType.NONE, LogicEntity from = null, IList<int> attackTag = null)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void UpdateShieldValue()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
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
		}
	}

	public void RemoveAllShield()
	{
		/*Error near IL_0001: Unknown opcode: 0xE1*/;
	}

	public unsafe override void OnDeactive()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
		_ = /*Error near IL_0004: Stack underflow*/>> (int)/*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		_ = ~6;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	private void SetOriginIntValue(HotfixEnum.effectAttributeType type, int val, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected I4, but got Unknown
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
		}
	}

	public void SetOwnerValue(ActorShield owner, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	public ActorShieldOld()
	{
		/*Error: Invalid field token*/;
	}
}
