using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Nova.Client;
using TrueSync;

public sealed class ActorAdditionalAttrInfo
{
	private Dictionary<int, FDP> attributeWithElementOrDamageTypeDict;

	public AttributeList attributeList
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public unsafe FDP atk
	{
		get
		{
			//IL_0004: Invalid comparison between Unknown and I4
			*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
			if ((int)/*Error near IL_0005: Stack underflow*/ < (int)(short)/*Error near IL_0004: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Read out of bounds.*/;
		}
	}

	public FDP defIgnore
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/| /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP defPenetrate
	{
		get
		{
			_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP suppressRatio
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP normalSuppressRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ < /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP skillSuppressRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ > /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP ultraSuppressRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ <= /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP markSuppressRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ < /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP summonSuppressRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ != /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP projectileSuppressRatio
	{
		get
		{
			/*Error: stloc 2 (out-of-bounds)*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP otherSuppressRatio
	{
		get
		{
			/*Error: stloc 3 (out-of-bounds)*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP normalDmgRatio
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP skillDmgRatio
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP ultraDmgRatio
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(nint)/*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP otherDmgRatio
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0001: Stack underflow*/, /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP intensityRatio
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP critPower
	{
		get
		{
			//IL_0001: Invalid comparison between Unknown and I
			if ((nint)/*Error near IL_0006: Stack underflow*/ != (nint)checked((nuint)/*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			return (FDP)(ulong)/*Error near IL_0007: Stack underflow*/;
		}
	}

	public FDP genDmgRatio
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/& /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP dmgPlus
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP finalDmgRatio
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP finalDmgPlus
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP critRate
	{
		get
		{
			//IL_0001: Invalid comparison between Unknown and I
			if ((nint)/*Error near IL_0006: Stack underflow*/ < (nint)checked((nuint)/*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			return (FDP)(ulong)/*Error near IL_0007: Stack underflow*/;
		}
	}

	public unsafe FDP hitRate
	{
		get
		{
			//IL_0003: Expected Obj, but got I4
			//IL_0004: Invalid comparison between Unknown and I4
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(short*)checked((nuint)/*Error near IL_0001: Stack underflow*/);
			if ((int)/*Error near IL_0005: Stack underflow*/ < (int)(short)/*Error near IL_0004: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Read out of bounds.*/;
		}
	}

	public FDP toughnessDamageRatio
	{
		get
		{
			if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xF7*/;
		}
	}

	public FDP markDmgRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ == /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP summonDmgRatio
	{
		get
		{
			/*Error: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public FDP projectileDmgRatio
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public FDP normalCritRate
	{
		get
		{
			/*Error: Unknown opcode: 0x24*/;
		}
	}

	public FDP skillCritRate
	{
		get
		{
			/*Error: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP ultraCritRate
	{
		get
		{
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP markCritRate
	{
		get
		{
			/*Error: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public FDP summonCritRate
	{
		get
		{
			_ = 545441770;
			/*Error near IL_0006: Unknown opcode: 0xF7*/;
		}
	}

	public FDP projectileCritRate
	{
		get
		{
			_ = 3090585349223794666L;
			/*Error: End of method reached without returning.*/;
		}
	}

	public FDP otherCritRate
	{
		get
		{
			_ = 2.2155149E-19f;
			/*Error near IL_0006: Unknown opcode: 0xF7*/;
		}
	}

	public FDP normalCritPower
	{
		get
		{
			_ = 4.4569466582128736E-102;
			/*Error: End of method reached without returning.*/;
		}
	}

	public FDP skillCritPower
	{
		get
		{
			if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xF7*/;
		}
	}

	public FDP ultraCritPower
	{
		get
		{
			if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xF7*/;
		}
	}

	public FDP markCritPower
	{
		get
		{
			if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xF7*/;
		}
	}

	public FDP summonCritPower
	{
		get
		{
			if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xF7*/;
		}
	}

	public FDP projectileCritPower
	{
		get
		{
			/*Error: Invalid branch target*/;
		}
	}

	public FDP otherCritPower
	{
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xF7*/;
		}
	}

	public FDP skillIntensityRatio
	{
		get
		{
			if (/*Error near IL_0005: Stack underflow*/ == /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xF7*/;
		}
	}

	public unsafe FDP def
	{
		get
		{
			//IL_0003: Expected Obj, but got I8
			//IL_0004: Invalid comparison between Unknown and I4
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(long*)checked((nuint)/*Error near IL_0001: Stack underflow*/);
			if ((int)/*Error near IL_0005: Stack underflow*/ < (int)(short)/*Error near IL_0004: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Read out of bounds.*/;
		}
	}

	public FDP genDmgRcdRatio
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*// /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP evd
	{
		get
		{
			//IL_0003: Expected Obj, but got I4
			//IL_0004: Invalid comparison between Unknown and I4
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)checked((nuint)/*Error near IL_0001: Stack underflow*/);
			if ((int)/*Error near IL_0005: Stack underflow*/ < (int)(short)/*Error near IL_0004: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Read out of bounds.*/;
		}
	}

	public unsafe FDP opposeCritRate
	{
		get
		{
			//IL_0003: Expected Obj, but got I4
			//IL_0004: Invalid comparison between Unknown and I4
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(sbyte*)checked((nuint)/*Error near IL_0001: Stack underflow*/);
			if ((int)/*Error near IL_0005: Stack underflow*/ < (int)(short)/*Error near IL_0004: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Read out of bounds.*/;
		}
	}

	public unsafe FDP normalDmgRcdRatio
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP skillDmgRcdRatio
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP ultraDmgRcdRatio
	{
		get
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP otherDmgRcdRatio
	{
		get
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public unsafe FDP dmgPlusRcd
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP markDmgRcdRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ >= /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP summonDmgRcdRatio
	{
		get
		{
			/*Error: Invalid calli metadata token*/;
		}
	}

	public FDP projectileDmgRcdRatio
	{
		get
		{
			/*Error: Invalid branch target*/;
		}
	}

	public FDP toughnessBrokenDmgRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ >= /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP envAmendRatio
	{
		get
		{
			/*Error: ldarg 234 (out-of-bounds)*/;
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public bool forceCrit
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

	public bool forceMissDamage
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

	public FDP GetAttributeValue(HotfixEnum.effectAttributeType type)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		_003F val = /*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
		_ = ((Array)(/*Error near IL_0006: Stack underflow*/ - val)).LongLength;
		/*Error near IL_0007: Invalid branch target*/;
	}

	public FDP GetAttributeOriginValue(HotfixEnum.effectAttributeType type)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		_003F val = /*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
		_ = ((Array)(/*Error near IL_0006: Stack underflow*/ - val)).LongLength;
		/*Error near IL_0007: Invalid branch target*/;
	}

	private FDP GetAttributePercentAmendValue(HotfixEnum.effectAttributeType type)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	private FDP GetAttributeBaseValue(HotfixEnum.effectAttributeType type)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		_003F val = /*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
		_ = ((Array)(/*Error near IL_0006: Stack underflow*/ - val)).LongLength;
		/*Error near IL_0007: Invalid branch target*/;
	}

	private FDP GetAttributeAbsAmendValue(HotfixEnum.effectAttributeType type)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public FDP GetAttributeValueWithElementOrDamageType(HotfixEnum.effectAttributeType type, HotfixEnum.elementType elementType, HotfixEnum.damageType damageType)
	{
		/*Error: Unknown opcode: 0xEC*/;
	}

	public void CopyFrom(AttributeList list, Dictionary<int, FDP> attributeWithElementOrDamageType)
	{
		//Discarded unreachable code: IL_0022
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xFA*/;
		}
	}

	public void AddFrom(AttributeList list, Dictionary<int, FDP> attributeWithElementOrDamageType)
	{
		//Discarded unreachable code: IL_0017
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xFA*/;
		}
	}

	public void WriteMessage(RepeatedField<Attribute> attributes)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		_003F val = /*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
		_ = ((Array)(/*Error near IL_0006: Stack underflow*/ - val)).LongLength;
		/*Error near IL_0007: Invalid branch target*/;
	}

	public unsafe void WriteSpecialMessage(RepeatedField<SpecialAttribute> attributes)
	{
		//Discarded unreachable code: IL_0009, IL_000c, IL_0012, IL_0013
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0x77*/;
	}

	public void AddAttr(AdventureActor fromActor, List<int> idList, int count = 1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xFA*/;
		}
	}

	public void AddAttr(AdventureActor fromActor, int id, int count = 1)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe void AddAttr(HotfixEnum.effectAttributeType attributeType, HotfixEnum.parameterType parameterType, int value, int count, HotfixEnum.elementType elementType, HotfixEnum.damageType damageType, int valueConfigId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		*(int*)(nint)/*Error near IL_0002: Stack underflow*/ = checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF3*/;
	}

	private bool IsElementCombineAttr(HotfixEnum.effectAttributeType attributeType, HotfixEnum.elementType elementType, int configId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			_ = 4.147680314192482E-276;
			/*Error near IL_000a: Unknown opcode: 0xCE*/;
		}
	}

	private bool IsDamageTypeCombineAttr(HotfixEnum.effectAttributeType attributeType, HotfixEnum.damageType damageType, int configId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 205 (out-of-bounds)*/;
			/*Error near IL_0003: stloc 1 (out-of-bounds)*/;
			/*Error near IL_0004: Not a type handle*/;
		}
	}

	public void Clear()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xFA*/;
		}
	}

	public unsafe ActorAdditionalAttrInfo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = (nuint)(*(nint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}
}
