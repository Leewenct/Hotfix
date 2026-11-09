using TrueSync;
using UnityEngine;
using UnityEngine.Serialization;

[AddComponentMenu("Game/Adventure/Gizmo/Spawn Group")]
public class SpawnGroupGizmo : MonoBehaviour
{
	[FormerlySerializedAs("_enableDelayActiveCondition")]
	public bool enableDelayActiveCondition;

	[FormerlySerializedAs("_delaySpawnDuration")]
	public FP delaySpawnDuration;

	[Range(0f, 10f)]
	public float radius;

	public bool isActivated;

	public int allMonsterCount;

	public int waveIndex;

	public int groupIndex;

	public void Initialize(int waveIndex, int groupIndex)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public void LogicUpdate()
	{
	}

	public SpawnGroupGizmo()
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
