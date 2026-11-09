using System;
using UnityEngine;

public class InfinityTowerMonsterSpawnPointGizmo : BaseSpawnPointGizmo
{
	[Space]
	public int pointIndex;

	public int monsterID;

	public int levelChange;

	private long spawnMonsterUniqueID;

	[HideInInspector]
	public bool enterActionWhenSpawned;

	public Action<long> spawnCallback;

	public void SetSpawnCallback(Action<long> spawnCallback)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public override void ExecuteSpawnLogic(AdventureActor summoner = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected I4, but got Unknown
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

	protected ActorSpawnInfo GetMonsterSpawnInfo(bool callbackImmediately = false)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public InfinityTowerMonsterSpawnPointGizmo()
	{
		/*Error: Invalid field token*/;
	}
}
