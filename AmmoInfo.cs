using System.Runtime.CompilerServices;
using Nova.Hotfix;
using TrueSync;
using UnityEngine;

public class AmmoInfo : LogicComponent
{
	public delegate void AmmoChangedHandle(int ammo, int ammoMax);

	[CompilerGenerated]
	private AmmoChangedHandle m_AmmoChangedEvent;

	private readonly AmmoEntry[] ammoEnties;

	public HotfixEnum.AmmoType ammoType;

	public HotfixEnum.bulletType bulletT;

	public static readonly bool useValued;

	public static int countUpper;

	public static int maxUpper;

	public int originAmmoCountMax;

	public FP originAmmoRatio;

	[Space]
	public bool forceReloadAmmo;

	[Space]
	public bool isNoCostAmmo;

	public int ammoCountMax
	{
		get
		{
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public int ammoCount
	{
		get
		{
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (ulong)/*Error near IL_0007: Stack underflow*/;
				/*Error near IL_0007: Unknown opcode: 0xF1*/;
			}
		}
	}

	public FP ammoCountPercentage
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Invalid comparison between Unknown and I4
			if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0007: Unknown opcode: 0xB0*/;
		}
	}

	public event AmmoChangedHandle AmmoChangedEvent
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

	public int GetAmmoCount(HotfixEnum.AmmoType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public int GetAmmoMax(HotfixEnum.AmmoType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public void ChangeValue(HotfixEnum.AmmoType type, HotfixEnum.ammoParameterType subType, FP val)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public void RefreshAmmoCost(int adjustNum)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected I4, but got Unknown
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

	public void SetOriginIntValue(HotfixEnum.AmmoType type, int val, FP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public void SetOriginAttributeData(Character attributeConfig, FP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = /*Error near IL_0008: Stack underflow*/+ (nuint)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	public AmmoInfo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	static AmmoInfo()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}
}
