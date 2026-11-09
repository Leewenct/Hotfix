using System;
using TrueSync;
using UnityEngine;

public class RandomMonsterSpawnPointGizmo : BaseSpawnPointGizmo
{
	public float pointRadius;

	public int monsterID;

	public Action<long, bool> spawnCallback;

	[HideInInspector]
	public bool enterActionWhenSpawned;

	private long spawnMonsterUniqueID;

	private bool isRep;

	public int callSpawnSrc;

	public MonsterStrollSchemes.MonsterStrollScheme strollScheme;

	public int indexOfSpawnWave;

	public void SetSpawnCallback(Action<long, bool> spawnCallbackTemp, bool isRepTemp)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public override void ExecuteSpawnLogic(AdventureActor summoner = null)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected ActorSpawnInfo GetMonsterSpawnInfo(bool callbackImmediately = false)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	protected TSVector2 randomPos()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public override void KillAllSummoners()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public override bool IsSpwanState()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public RandomMonsterSpawnPointGizmo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}
}
