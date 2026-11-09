using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ActorGroupManager : SceneSingleton<ActorGroupManager>
{
	protected Logger _logger;

	protected readonly Stack<AdventureActor.MoveFeatureData> _moveFeatureDatas;

	public Dictionary<string, AdventureEntityGroup> entityGroups
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	protected override void Awake()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xF3*/;
		}
	}

	protected void Start()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void OnLevelStop(IEvent evt)
	{
		/*Error: Invalid field token*/;
	}

	public void UpdateActorGroups()
	{
		/*Error: Invalid metadata token*/;
	}

	public unsafe void ClearActorGroups()
	{
		_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}

	public AdventureEntityGroup AddOrGetEntityGroup(string groupID)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		_ = /*Error near IL_000a: Stack underflow*/+ groupID;
		/*Error near IL_000a: Unknown opcode: 0xB1*/;
	}

	public AdventureEntityGroup QueryEntityGroupByID(string groupID)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0011: Invalid comparison between I8 and Unknown
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (-2479403310195739132L <= (long)/*Error near IL_0010: ldloc 1 (out-of-bounds)*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0016: Invalid metadata token*/;
	}

	public AdventureActor.MoveFeatureData PopMoveFData()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
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

	public unsafe void PushMoveFData(AdventureActor.MoveFeatureData moveData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xC9*/;
	}

	public ActorGroupManager()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f->IL000a: Incompatible stack heights: 0 vs 2
		checked
		{
			_003F val = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			while (true)
			{
				_ = /*Error near IL_000d: Stack underflow*/+ (val >> unchecked((int)checked((sbyte)6341807753159031258L)));
			}
		}
	}
}
