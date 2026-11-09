namespace AIScript.Monster.Soldier._145;

public class Parallel : AIBase
{
	private readonly int _hitTagBullet;

	private readonly string _areaEffectKey;

	private readonly int HitTag_SteelRain;

	private const string AreaEffectKey_Potential3Ex = "AreaEffect_Soldier_145_Support_ex";

	private const int TriggerPercent_Potential3 = 30;

	public void OnEnable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void OnDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private unsafe void OnDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private void OnSteelRainDamage(SoldierActor target)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public Parallel()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0006: Invalid metadata token*/;
	}
}
