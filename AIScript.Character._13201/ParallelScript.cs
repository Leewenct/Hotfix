using AdventureBehaviour;
using TrueSync;

namespace AIScript.Character._13201;

public class ParallelScript : ParallelBase
{
	protected const int buffId_LightMark = 3011;

	protected static readonly int damageTag_LightMark;

	protected static readonly int damageTag_UltraSkill;

	private const int ultraSkillId_Default = 13240000;

	private const int perkId_41 = 513241;

	private const int ultraSkillId_P41 = 13244100;

	private const int additionalAttrId_P41 = 13241001;

	private const int perkId_42 = 513242;

	private const int additionalAttrId_P42 = 13242001;

	public const int buffId_D1 = 13296111;

	public const int buffId_D2 = 13296211;

	public static readonly int damageTag_Trigger_D3;

	public const int buffId_D3 = 13296311;

	public const int buffId_D4 = 13296411;

	public const int additionalAttrId_D5 = 13296511;

	private FP _triggerTime_D1;

	private PlayFX _playFX_D1;

	public override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void OnCastSkill(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnReceiveAttack(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (int)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	protected virtual void OnSelfAttacked(AdventureActorReceiveAttackEvent attackEvent)
	{
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

	private unsafe void OnReceiveDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	protected virtual void OnPlayerBeforeHit(AdventureActorReceiveDamageBeforeHitEvent beforeHitEvent)
	{
	}

	protected virtual void OnSelfBeforeHit(AdventureActorReceiveDamageBeforeHitEvent beforeHitEvent)
	{
	}

	protected virtual void OnPlayerDamaged(AdventureActorReceiveDamageEvent damageEvent)
	{
	}

	protected virtual void OnSelfDamaged(AdventureActorReceiveDamageEvent damageEvent)
	{
	}

	protected virtual void TryTriggerLightMark(AdventureActorReceiveDamageEvent damageEvent)
	{
	}

	private unsafe void OnElementMarkTrigger(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: ldarg 3 (out-of-bounds)*/;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0004: Stack underflow*/+ ((sbyte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public ParallelScript()
	{
		/*Error: Invalid field token*/;
	}

	unsafe static ParallelScript()
	{
		checked
		{
			_ = (nuint)unchecked((int)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}
}
