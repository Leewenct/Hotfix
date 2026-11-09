using System.Collections.Generic;
using TrueSync;
using UnityEngine;

[AddComponentMenu("游戏/冒险模块/特殊实体/电球")]
[DisallowMultipleComponent]
public class ElectroBallEntity : LogicEntity, ISpecialEntity, IHitBoxContext
{
	private class ElectroBall
	{
		public AdventureActor owner;

		public FP duration;

		public TSVector2 position;

		public AdventureFXPlayer fxPlayer;

		public int hitDamageId;

		private bool _isInfinite;

		public bool isInfinite
		{
			get
			{
				/*Error: Read out of bounds.*/;
			}
			set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				checked
				{
					if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
					{
						/*Error: Invalid branch target*/;
					}
					_ = (ulong)/*Error near IL_0007: Stack underflow*/ + 1706394668;
				}
			}
		}

		public bool IsFinish
		{
			get
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				checked
				{
					_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
					_ = 0;
					/*Error near IL_0002: Unknown opcode: 0xCE*/;
				}
			}
		}

		public void Init(AdventureActor owner, GameObject fxPrefab, FP duration, int hitDamageId, bool isInfinite = false)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (ulong)/*Error near IL_0007: Stack underflow*/;
				_ = ~(nint)1793980932;
				/*Error near IL_000e: Unknown opcode: 0xE7*/;
			}
		}

		public void SetPosition(TSVector2 position, FP positionY)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (ulong)/*Error near IL_0007: Stack underflow*/ + 1706393620;
			}
		}

		public void Update(FP duration, TSVector2 position, FP positionY)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (ulong)/*Error near IL_0007: Stack underflow*/ * 1709247020;
				/*Error near IL_000e: Unknown opcode: 0xED*/;
			}
		}

		public void Stop(bool forceStop = false)
		{
			/*Error: Read out of bounds.*/;
		}

		private void Clear()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			}
		}
	}

	public FP duration;

	public GameObject fx;

	public FP radius;

	public FP rotateSpeed;

	public FP rotateRadius;

	public int maxCount;

	public int hitDamageId;

	public HitBox.FeatureFlag hitFlags;

	public HitBox.HitBoxFeatureData hitFeatureData;

	public HitBox.HurtAnimType hurtAnimType;

	public GameObject hittedEffectPrefab;

	public bool isHittedEffectScale;

	public bool effectIgnoreTimeScale;

	public FP damageImmuneDuration;

	private HitBox _hitBox;

	private readonly int _hitLayer;

	private AdventureActor _owner;

	private AdventureActor _attackActor;

	private List<ElectroBall> _electroBallPool;

	private List<ElectroBall> _electroBalls;

	protected Dictionary<long, FP> _hitedEntities;

	private bool NeedUpdate
	{
		get
		{
			/*Error: Unknown opcode: 0xF0*/;
		}
	}

	public unsafe int ElectroBallCount
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid field token*/;
		}
	}

	public AdventureActor Owner
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	protected unsafe override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		*(float*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0f;
		checked
		{
			_ = (ushort)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnActive()
	{
		/*Error: Invalid field token*/;
	}

	public void Setup(AdventureActor owner)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Invalid metadata token*/;
	}

	protected override void OnLogicUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public void GenerateElectroBall(AdventureActor owner, int hitDamageId, bool isInfinite = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	public TSVector2 GetFirstElectroBallPosition()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
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

	public TSVector2 FinishElectroBall()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void RefreshAllElectroBall(FP positionY)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected I4, but got Unknown
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
		case 21:
			/*Error: Invalid branch target*/;
		case 22:
			/*Error: Invalid branch target*/;
		case 23:
			/*Error: Invalid branch target*/;
		case 24:
			/*Error: Invalid branch target*/;
		case 25:
			/*Error: Invalid branch target*/;
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		case 35:
			/*Error: Invalid branch target*/;
		case 36:
			/*Error: Invalid branch target*/;
		case 37:
			/*Error: Invalid branch target*/;
		case 38:
			/*Error: Invalid branch target*/;
		case 39:
			/*Error: Invalid branch target*/;
		case 40:
			/*Error: Invalid branch target*/;
		case 41:
			/*Error: Invalid branch target*/;
		case 42:
			/*Error: Invalid branch target*/;
		case 43:
			/*Error: Invalid branch target*/;
		case 44:
			/*Error: Invalid branch target*/;
		case 45:
			/*Error: Invalid branch target*/;
		case 46:
			/*Error: Invalid branch target*/;
		}
	}

	public void Finish()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected unsafe override void OnDeactive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I8, but got I4
		*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0L;
		checked
		{
			_ = (ushort)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public FP QueryHitBoxContextTime()
	{
		/*Error: Invalid field token*/;
	}

	public unsafe TSVector2 QueryHitBoxContextPosition()
	{
		_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}

	public unsafe TSVector2 QueryHitBoxContextDirection()
	{
		_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}

	public bool QueryActorHitedTimeout(long entityId, FP timeout)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I4, but got Unknown
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

	public void SetActorHitedTime(long entityId, FP time)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xF4*/;
	}

	public bool CheckHitable(HitBox hitBox, LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected I4, but got Unknown
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
		}
	}

	public bool OnHitActor(HitBox hitBox, int uniqueAttackId, int onceAttackTargetCount, LogicEntity entity, ref DeterministicRaycastHit raycastHit, out bool damaged, GameObject hurtEffectPrefab, bool isHittedEffectScale, bool effectIgnoreTimeScale = true)
	{
		/*Error: Unknown opcode: 0xE3*/;
	}

	public bool OnHitShield(HitBox hitBox, AdventureWeapon shield, ref DeterministicRaycastHit raycastHit)
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public bool OnHitObstacle(HitBox hitBox, AdventureObstacle obstacle, ref DeterministicRaycastHit raycastHit)
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public unsafe bool OnHitDestructibleObstacle(HitBox hitBox, int uniqueAttackId, int onceAttackTargetCount, LogicEntity actor, ref DeterministicRaycastHit raycastHit, out bool damaged, GameObject hurtEffectPrefab, bool isHittedEffectScale, bool effectIgnoreTimeScale = true)
	{
		//IL_0002: Expected I4, but got I8
		*(short*)(nint)/*Error near IL_0002: Stack underflow*/ = (short)checked((ulong)/*Error near IL_0001: Stack underflow*/);
		*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
		if (/*Error near IL_0004: Stack underflow*/ <= /*Error near IL_0004: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: ldloc 1 (out-of-bounds)*/;
		_ = -1;
		/*Error: End of method reached without returning.*/;
	}

	public ElectroBallEntity()
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
