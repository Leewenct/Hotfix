using System.Collections.Generic;

namespace AIScript.Monster.TowerDefense._14001;

public class Parallel : TowerCharacterParalletBase
{
	private const int perkId_3 = 1400103;

	private int damageTag_P03;

	private int buffId_AttachCrystal;

	private int maxAttachCount;

	private int buffId_Crystallization;

	private int buffId_Stun;

	private int hitDamageId_P03;

	private Dictionary<int, int> _dicPerkCd;

	public override Dictionary<int, int> dicPerkCd
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public override void OnEnable()
	{
		/*Error: Invalid field token*/;
	}

	public override void OnDisable()
	{
		/*Error: Invalid field token*/;
	}

	public override void OnHitPost(AdventureActorReceiveDamageEvent evt, MonsterAdventureActor monster, bool isSelf)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public override void OnPersonalPerkUpdate(AdventureActorPersonalPerkUpdateEvent evt)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public Parallel()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0006: Invalid metadata token*/;
	}
}
