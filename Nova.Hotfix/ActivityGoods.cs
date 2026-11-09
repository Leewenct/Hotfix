using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class ActivityGoods : IMessage<ActivityGoods>, IMessage, IEquatable<ActivityGoods>, IDeepCloneable<ActivityGoods>
{
	private static readonly MessageParser<ActivityGoods> _parser;

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int NameFieldNumber = 2;

	private string name_;

	public const int DescFieldNumber = 3;

	private string desc_;

	public const int ShopIdFieldNumber = 4;

	private int shopId_;

	public const int SaleNumberFieldNumber = 5;

	private int saleNumber_;

	public const int ItemIdFieldNumber = 6;

	private int itemId_;

	public const int ItemQuantityFieldNumber = 7;

	private int itemQuantity_;

	public const int MaximumLimitFieldNumber = 8;

	private int maximumLimit_;

	public const int PriceFieldNumber = 9;

	private int price_;

	public const int AppearCondTypeFieldNumber = 10;

	private int appearCondType_;

	public const int AppearCondParamsFieldNumber = 11;

	private string appearCondParams_;

	public const int PurchaseCondTypeFieldNumber = 12;

	private int purchaseCondType_;

	public const int PurchaseCondParamsFieldNumber = 13;

	private string purchaseCondParams_;

	public const int UnlockPurchaseTimeFieldNumber = 14;

	private string unlockPurchaseTime_;

	public const int DisplayModeFieldNumber = 15;

	private int displayMode_;

	[DebuggerNonUserCode]
	public static MessageParser<ActivityGoods> Parser
	{
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		get
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
	}

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor
	{
		get
		{
			checked
			{
				_ = (nint)unchecked((int)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]);
				/*Error near IL_0002: Read out of bounds.*/;
			}
		}
	}

	[DebuggerNonUserCode]
	public int Id
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	[DebuggerNonUserCode]
	public string Name
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xFD*/;
		}
	}

	[DebuggerNonUserCode]
	public string Desc
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xFD*/;
		}
	}

	[DebuggerNonUserCode]
	public int ShopId
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	[DebuggerNonUserCode]
	public int SaleNumber
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	[DebuggerNonUserCode]
	public int ItemId
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	[DebuggerNonUserCode]
	public int ItemQuantity
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	[DebuggerNonUserCode]
	public int MaximumLimit
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	[DebuggerNonUserCode]
	public int Price
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	[DebuggerNonUserCode]
	public int AppearCondType
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	[DebuggerNonUserCode]
	public string AppearCondParams
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xFD*/;
		}
	}

	[DebuggerNonUserCode]
	public int PurchaseCondType
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	[DebuggerNonUserCode]
	public string PurchaseCondParams
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xFD*/;
		}
	}

	[DebuggerNonUserCode]
	public string UnlockPurchaseTime
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xFD*/;
		}
	}

	[DebuggerNonUserCode]
	public int DisplayMode
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	[DebuggerNonUserCode]
	public unsafe ActivityGoods()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xA7*/;
	}

	[DebuggerNonUserCode]
	public unsafe ActivityGoods(ActivityGoods other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = (IntPtr)0;
		((long[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (long)/*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	[DebuggerNonUserCode]
	public ActivityGoods Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(ActivityGoods other)
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

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		/*Error: Unknown opcode: 0xEC*/;
	}

	[DebuggerNonUserCode]
	public override string ToString()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xE2*/;
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(ActivityGoods other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xEF*/;
		}
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: Unknown opcode: 0xA9*/;
	}

	unsafe static ActivityGoods()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xC1*/;
	}
}
