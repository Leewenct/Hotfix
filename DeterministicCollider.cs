using System;
using System.Collections.Generic;
using TrueSync;
using TrueSync.Physics2D;
using UnityEngine;

public class DeterministicCollider : LogicMonoComponent
{
	public int priority;

	private Collider _collider;

	private Vector3 _originUnityColliderCenter;

	private Vector3 _originUnityColliderSize;

	private TrueSyncTransform _tsTransform;

	internal Shape _shape;

	private bool _dirty;

	internal DeterministicColliderShape _colliderShape;

	internal TSVector2 _colliderCenter;

	internal FP _radius;

	internal FP _colliderWidth;

	internal FP _colliderLength;

	internal FP _colliderHeight;

	internal IDeterministicCollisionListener _listener;

	internal bool _ignoreCollision;

	internal AABB _colliderBounds;

	internal DeterministicCollisionQuadTreeNode _quadTreeNode;

	protected List<DeterministicCollider> _collisionInfo;

	protected List<int> _collisionInfoMeta;

	public TrueSyncTransform tsTransform
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public unsafe int layer
	{
		get
		{
			_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xB1*/;
		}
		set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected I8, but got Unknown
			/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
			_003F val = checked(/*Error near IL_0003: Stack underflow*/ + /*Error near IL_0003: Stack underflow*/);
			*(long*)(nint)/*Error near IL_0006: Stack underflow*/ = (long)val;
			_ = ((Array)/*Error near IL_0007: Stack underflow*/).LongLength;
			/*Error near IL_0007: Invalid branch target*/;
		}
	}

	public FP HeightCenter
	{
		get
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
	}

	public DeterministicColliderShape ColliderShape
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			/*Error: Unknown opcode: 0xF0*/;
		}
	}

	public TSVector2 ColliderCenter
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			/*Error: Unknown opcode: 0xF0*/;
		}
	}

	public TSVector2 CenterPosition
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected I4, but got Unknown
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
			}
		}
	}

	public FP Radius
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			/*Error: Unknown opcode: 0xF0*/;
		}
	}

	public FP ColliderWidth
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			/*Error: Unknown opcode: 0xF0*/;
		}
	}

	public FP ColliderLength
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			/*Error: Unknown opcode: 0xF0*/;
		}
	}

	public FP ColliderHeight
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

	public IDeterministicCollisionListener collisionListener
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

	public int CollisionLayerFlag
	{
		get
		{
			/*Error: Unknown opcode: 0xEC*/;
		}
	}

	public bool IgnoreCollision
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = (ushort)((uint[])(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
				/*Error near IL_0004: Unknown opcode: 0xEC*/;
			}
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
				_ = (ulong)/*Error near IL_0007: Stack underflow*/ + 1690958380;
			}
		}
	}

	public Vector3 colliderCenter
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected I4, but got Unknown
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
			}
		}
	}

	public AABB ColliderBounds
	{
		get
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ == 0)
			{
				/*Error near IL_0002: Invalid metadata token*/;
			}
			switch ((int)/*Error near IL_000e: Stack underflow*/)
			{
			default:
				/*Error: End of method reached without returning.*/;
			}
		}
	}

	public Vector3 colliderSize
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected I4, but got Unknown
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
			}
		}
	}

	public Bounds colliderBounds
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected I4, but got Unknown
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
			}
		}
	}

	public void LoadFromUnityCollider(Collider unityCollider, bool applyTransformScale = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	public void ScaleUnityColliderShape(float scale, bool applyScaleToDeterministicCollider, bool applyTransformScale = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected I4, but got Unknown
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
		case 47:
			/*Error: Invalid branch target*/;
		case 48:
			/*Error: Invalid branch target*/;
		case 49:
			/*Error: Invalid branch target*/;
		case 50:
			/*Error: Invalid branch target*/;
		case 51:
			/*Error: Invalid branch target*/;
		case 52:
			/*Error: Invalid branch target*/;
		case 53:
			/*Error: Invalid branch target*/;
		case 54:
			/*Error: Invalid branch target*/;
		case 55:
			/*Error: Invalid branch target*/;
		case 56:
			/*Error: Invalid branch target*/;
		case 57:
			/*Error: Invalid branch target*/;
		case 58:
			/*Error: Invalid branch target*/;
		case 59:
			/*Error: Invalid branch target*/;
		case 60:
			/*Error: Invalid branch target*/;
		case 61:
			/*Error: Invalid branch target*/;
		case 62:
			/*Error: Invalid branch target*/;
		case 63:
			/*Error: Invalid branch target*/;
		case 64:
			/*Error: Invalid branch target*/;
		case 65:
			/*Error: Invalid branch target*/;
		case 66:
			/*Error: Invalid branch target*/;
		case 67:
			/*Error: Invalid branch target*/;
		case 68:
			/*Error: Invalid branch target*/;
		case 69:
			/*Error: Invalid branch target*/;
		case 70:
			/*Error: Invalid branch target*/;
		case 71:
			/*Error: Invalid branch target*/;
		case 72:
			/*Error: Invalid branch target*/;
		case 73:
			/*Error: Invalid branch target*/;
		case 74:
			/*Error: Invalid branch target*/;
		case 75:
			/*Error: Invalid branch target*/;
		case 76:
			/*Error: Invalid branch target*/;
		case 77:
			/*Error: Invalid branch target*/;
		case 78:
			/*Error: Invalid branch target*/;
		case 79:
			/*Error: Invalid branch target*/;
		case 80:
			/*Error: Invalid branch target*/;
		case 81:
			/*Error: Invalid branch target*/;
		case 82:
			/*Error: Invalid branch target*/;
		case 83:
			/*Error: Invalid branch target*/;
		}
	}

	public void UpdateColliderShape()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected I4, but got Unknown
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
		case 47:
			/*Error: Invalid branch target*/;
		case 48:
			/*Error: Invalid branch target*/;
		case 49:
			/*Error: Invalid branch target*/;
		case 50:
			/*Error: Invalid branch target*/;
		case 51:
			/*Error: Invalid branch target*/;
		case 52:
			/*Error: Invalid branch target*/;
		case 53:
			/*Error: Invalid branch target*/;
		case 54:
			/*Error: Invalid branch target*/;
		case 55:
			/*Error: Invalid branch target*/;
		case 56:
			/*Error: Invalid branch target*/;
		case 57:
			/*Error: Invalid branch target*/;
		case 58:
			/*Error: Invalid branch target*/;
		case 59:
			/*Error: Invalid branch target*/;
		case 60:
			/*Error: Invalid branch target*/;
		case 61:
			/*Error: Invalid branch target*/;
		case 62:
			/*Error: Invalid branch target*/;
		case 63:
			/*Error: Invalid branch target*/;
		case 64:
			/*Error: Invalid branch target*/;
		case 65:
			/*Error: Invalid branch target*/;
		case 66:
			/*Error: Invalid branch target*/;
		case 67:
			/*Error: Invalid branch target*/;
		case 68:
			/*Error: Invalid branch target*/;
		case 69:
			/*Error: Invalid branch target*/;
		}
	}

	public void UpdateColliderTransform(bool forceUp = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected I4, but got Unknown
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
		}
	}

	public void ColliderSync()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xCD*/;
	}

	public bool RaycastBounds(ref TSVector2 origin, ref TSVector2 direction, out DeterministicRaycastHit hitInfo, FP maxDistance)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0003: Invalid field token*/;
	}

	public bool Raycast(ref TSVector2 origin, ref TSVector2 direction, out DeterministicRaycastHit hitInfo, FP maxDistance, bool preTest = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0003: Invalid field token*/;
	}

	public bool CheckPointInterior(ref TSVector2 point)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
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
		}
	}

	public bool CheckBoundsOverlap(ref AABB other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((ushort[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
		_ = 1;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public bool CheckOverlap(DeterministicCollider other, bool preTest = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 222 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	internal void ContactWith(int frameCount, DeterministicCollider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected I4, but got Unknown
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
		}
	}

	internal void SeparateWith(int frameCount, DeterministicCollider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I4, but got Unknown
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
		}
	}

	internal void SeparateWithRemaining(int frameCount)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected I4, but got Unknown
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
		}
	}

	protected void DisableCollision()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected I4, but got Unknown
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
		}
	}

	protected override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Unknown opcode: 0xF6*/;
		}
	}

	public override void OnActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected I4, but got Unknown
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
		}
	}

	public override void OnDeactive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
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

	public DeterministicCollider()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Invalid field token*/;
	}
}
