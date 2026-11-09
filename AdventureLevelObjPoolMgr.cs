using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AdventureLevelObjPoolMgr : SceneSingleton<AdventureLevelObjPoolMgr>
{
	public enum PoolType
	{
		Actor,
		Monster,
		Environment,
		SkillTemplate,
		SkillFS,
		FX,
		Timeline,
		Bullet
	}

	public enum PoolState
	{
		AssetEmpty,
		GameObjectEmpty,
		GameObjectUnUsing,
		GameObjectPrepare2Use,
		GameObjectUsing
	}

	public class PoolBase
	{
		public Transform defaultParentNode
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			protected set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public Action<PoolBase> callback
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			protected set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public string loadPath
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			protected set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public PoolBase(Action<PoolBase> callback, string loadPath, Transform defaultParentNode)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = (ushort)0;
				/*Error near IL_0004: Unknown opcode: 0xEC*/;
			}
		}

		public virtual void Instantiate(Object asset)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
			}
		}

		public virtual void EnPool()
		{
			/*Error: Unknown opcode: 0xF0*/;
		}

		public virtual void Enabled(bool enable)
		{
		}

		public virtual void Clean()
		{
		}

		public void Reset(Action<PoolBase> callback)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		}

		public virtual void Preload(int num = 1)
		{
		}

		public virtual void Clear()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			}
		}
	}

	public class PoolObj : PoolBase
	{
		public GameObject gameObject
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			protected set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public PoolObj(Action<PoolBase> callback, string loadPath, Transform defaultParentNode)
		{
			checked
			{
				_ = (nuint)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0002: Unknown opcode: 0xE1*/;
			}
		}

		public override void Instantiate(Object asset)
		{
			/*Error: Unknown opcode: 0xE9*/;
		}

		public override void EnPool()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xE2*/;
			}
		}

		public override void Enabled(bool enable)
		{
			/*Error: Unknown opcode: 0xE9*/;
		}

		public override void Clear()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xE7*/;
			}
		}
	}

	public class PoolContainer
	{
		protected Transform defaultParentNode;

		protected Object asset;

		protected Queue<PoolBase> pool2Init;

		protected Queue<PoolBase> pool2Get;

		protected PoolType poolType;

		public string loadPath
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			protected set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			}
		}

		public bool IsEmpty
		{
			get
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0030: Expected I4, but got Unknown
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

		public int Count
		{
			get
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected I4, but got Unknown
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
				}
			}
		}

		public int AllCount
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

		public PoolContainer(PoolType poolType, string loadPath, int capacity, Transform defaultParentNode, Object prefab = null)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = (ushort)0;
				/*Error near IL_0004: Unknown opcode: 0xEC*/;
			}
		}

		public unsafe void EnPool(PoolBase poolObj)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Expected Obj, but got Unknown
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0002: Unknown opcode: 0xE2*/;
		}

		protected PoolBase GetPoolBase(Action<PoolBase> callback = null)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1706319987;
				return (PoolBase)/*OpCode not supported: Nop*/;
			}
		}

		public PoolBase DePool()
		{
			/*Error: Unknown opcode: 0xE9*/;
		}

		public void DePool(Action<PoolBase> callback)
		{
			/*Error: Unknown opcode: 0xE9*/;
		}

		public PoolBase Peek()
		{
			if (pool2Init == null || pool2Init.Count == 0)
			{
				return null;
			}
			return pool2Init.Dequeue();
		}

		public void Instantiate(PoolBase poolBase)
		{
			poolBase.Instantiate(asset);
		}

		public void Preload(int num = 1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected I4, but got Unknown
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
			}
		}

		public void Clean()
		{
		}

		public void Clear()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			}
		}
	}

	public class Pool
	{
		protected int updateFrame;

		protected int frameUpdateCount = 1;

		protected int capacity = 1;

		protected int runtimeCapacity = 1;

		protected Dictionary<string, PoolContainer> pool;

		protected PoolType poolType = PoolType.Environment;

		protected Transform defaultParentNode;

		public int Count
		{
			get
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected I4, but got Unknown
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
				}
			}
		}

		public PoolContainer this[string key]
		{
			get
			{
				/*Error: Unknown opcode: 0xE9*/;
			}
		}

		public Pool(PoolType poolType, int capacity, int frameUpdateCount, Transform defaultParentNode)
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			this.poolType = poolType;
			this.frameUpdateCount = frameUpdateCount;
			this.capacity = capacity;
			pool = new Dictionary<string, PoolContainer>(capacity);
			runtimeCapacity = this.capacity;
			this.defaultParentNode = new GameObject(poolType.ToString()).transform;
			this.defaultParentNode.SetParent(defaultParentNode);
			this.defaultParentNode.localScale = Vector3.one;
			this.defaultParentNode.localPosition = Vector3.zero;
		}

		protected void Expend()
		{
			/*Error: Unknown opcode: 0xF0*/;
		}

		public unsafe void EnPool(List<PoolBase> poolBases)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Expected Obj, but got Unknown
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
			_ = /*Error near IL_0003: Stack underflow*// /*Error near IL_0003: Stack underflow*/;
			/*Error near IL_0003: ldarg 2 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}

		public void EnPool(PoolBase poolBase)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			PoolContainer poolContainer = default;
			_ = checked((sbyte)(nuint)/*Error near IL_0007: Stack underflow*/) << (int)poolContainer;
			/*Error near IL_000a: Unknown opcode: 0xB0*/;
		}

		public int GetPoolObjNum(string loadPath)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Expected F4, but got I
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
			PoolContainer poolContainer = default;
			_ = /*Error near IL_000a: Stack underflow*/* poolContainer;
			/*Error near IL_000a: Unknown opcode: 0xB1*/;
		}

		public unsafe PoolBase DePool(string loadPath)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Expected F4, but got I
			//IL_0014: Expected Obj, but got I4
			if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
			if ((int)/*Error near IL_000d: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (uint)(sbyte)/*Error near IL_000e: Stack underflow*/;
			/*Error near IL_000f: starg 217 (out-of-bounds)*/;
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0012: Stack underflow*/, /*Error near IL_0012: Stack underflow*/);
			((object[])/*Error near IL_0014: Stack underflow*/)[/*Error near IL_0014: Stack underflow*/] = *(int*)(nint)/*Error near IL_0013: Stack underflow*/;
			/*Error near IL_0014: Unknown opcode: 0xEC*/;
		}

		public unsafe void DePool(string loadPath, Action<PoolBase> callback)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Expected F4, but got I
			//IL_0014: Expected Obj, but got I4
			if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
			if ((int)/*Error near IL_000d: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (uint)(sbyte)/*Error near IL_000e: Stack underflow*/;
			/*Error near IL_000f: starg 217 (out-of-bounds)*/;
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0012: Stack underflow*/, /*Error near IL_0012: Stack underflow*/);
			((object[])/*Error near IL_0014: Stack underflow*/)[/*Error near IL_0014: Stack underflow*/] = *(int*)(nint)/*Error near IL_0013: Stack underflow*/;
			/*Error near IL_0014: Unknown opcode: 0xEC*/;
		}

		protected PoolContainer Peek(string loadPath)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Invalid comparison between Unknown and I4
			if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) >= 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0007: Unknown opcode: 0xC1*/;
		}

		public void Preload(int num = 1)
		{
			//Discarded unreachable code: IL_001a
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected I4, but got Unknown
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
			}
		}

		public void Preload(PoolBase poolBase, int num)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected I4, but got Unknown
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
			}
		}

		public void Preload(string loadPath, int num, GameObject prefab = null)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected I4, but got Unknown
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
			}
		}

		public void Clean()
		{
			//Discarded unreachable code: IL_0020
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected I4, but got Unknown
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
			}
		}

		public void Clear()
		{
			//Discarded unreachable code: IL_001a
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected I4, but got Unknown
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
			}
		}

		public void Unload()
		{
		}

		public void Update()
		{
			int num = 0;
			foreach (PoolContainer value in pool.Values)
			{
				PoolBase poolBase = value.Peek();
				if (poolBase != null)
				{
					value.Instantiate(poolBase);
					num++;
				}
				if (num >= frameUpdateCount)
				{
					break;
				}
			}
		}
	}

	protected int dynamicLoad_SceneObjFrameUpdateNum = 5;

	protected int dynamicLoad_PlayerFrameUpdateNum = 1;

	protected int dynamicLoad_MonsterFrameUpdateNum = 1;

	protected int dynamicLoad_FlowScriptUpdateNum = 1;

	protected int dynamicLoad_SkillTempleteUpdateNum = 1;

	protected int dynamicLoad_BulletUpdateNum = 1;

	public const int INITCAPACITY_ENV = 128;

	public const int INITCAPACITY_PLAYER = 1;

	public const int INITCAPACITY_MONSTER = 8;

	public const int INITCAPACITY_FS = 8;

	public const int INITCAPACITY_BULLET = 32;

	public const int INITCAPACITY_SKILLTEMPLETE = 16;

	protected Pool pool_player;

	protected Pool pool_monster;

	protected Pool pool_env;

	protected Pool pool_st;

	protected Pool pool_bullet;

	protected override void Awake()
	{
		base.Awake();
		Initialize();
	}

	public void Initialize()
	{
		pool_player = new Pool(PoolType.Actor, 1, dynamicLoad_PlayerFrameUpdateNum, ((Component)this).transform);
		pool_monster = new Pool(PoolType.Monster, 8, dynamicLoad_MonsterFrameUpdateNum, ((Component)this).transform);
		pool_env = new Pool(PoolType.Environment, 128, dynamicLoad_SceneObjFrameUpdateNum, ((Component)this).transform);
		pool_st = new Pool(PoolType.SkillTemplate, 16, dynamicLoad_SkillTempleteUpdateNum, ((Component)this).transform);
		pool_bullet = new Pool(PoolType.Bullet, 32, dynamicLoad_BulletUpdateNum, ((Component)this).transform);
	}

	public void Preload_SceneObject(int num = 1)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public void Preload_Monster(int num = 1)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public unsafe void Preload_Monster(PoolBase poolBase, int num)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/>> (int)(*(float*)(nint)/*Error near IL_0003: Stack underflow*/);
		checked
		{
			nint num2 = (nint)(num + /*Error near IL_0006: ldloca 116 (out-of-bounds)*/);
			/*OpCode not supported: DebugBreak*/;
			switch ((short)num2)
			{
			default:
				/*Error: End of method reached without returning.*/;
			}
		}
	}

	public void Preload_Bullet(GameObject prefab, int num, string loadPath)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public PoolBase De_Bullet(string loadPath)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public PoolBase De_SceneObject(string loadPath)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = -542026734;
		_ = -5.959785E-39f;
		/*Error near IL_0011: Unknown opcode: 0xF1*/;
	}

	public unsafe void De_SceneObject(string loadPath, Action<PoolBase> callback)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/>> (int)(*(double*)(nint)/*Error near IL_0003: Stack underflow*/);
		checked
		{
			nint num = (nint)System.Runtime.CompilerServices.Unsafe.Read<object>(unchecked((void*)(nint)checked(callback + /*Error near IL_0006: ldloca 116 (out-of-bounds)*/)));
			/*OpCode not supported: DebugBreak*/;
			switch ((short)num)
			{
			default:
				/*Error: End of method reached without returning.*/;
			}
		}
	}

	public void En_SceneObject(List<PoolBase> poolBases)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xEE*/;
		}
	}

	public void En_SceneObject(PoolBase poolBase)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public PoolBase De_Player(string loadPath)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public unsafe void De_Player(string loadPath, Action<PoolBase> callback)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/>> (int)(nint)(*(IntPtr*)(nint)/*Error near IL_0003: Stack underflow*/);
		checked
		{
			nint num = (nint)System.Runtime.CompilerServices.Unsafe.Read<object>(unchecked((void*)(nint)checked(callback + /*Error near IL_0006: ldloca 116 (out-of-bounds)*/)));
			/*OpCode not supported: DebugBreak*/;
			switch ((short)num)
			{
			default:
				/*Error: End of method reached without returning.*/;
			}
		}
	}

	public void En_Player(PoolBase poolBase)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public int GetCount_Monster(string loadPath)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public PoolBase De_Monster(string loadPath)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public unsafe void De_Monster(string loadPath, Action<PoolBase> callback)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/>> (int)(*(float*)(nint)/*Error near IL_0003: Stack underflow*/);
		checked
		{
			nint num = (nint)System.Runtime.CompilerServices.Unsafe.Read<object>(unchecked((void*)(nint)checked(callback + /*Error near IL_0006: ldloca 116 (out-of-bounds)*/)));
			/*OpCode not supported: DebugBreak*/;
			switch ((short)num)
			{
			default:
				/*Error: End of method reached without returning.*/;
			}
		}
	}

	public void En_Monster(PoolBase poolBase)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public PoolBase De_SkillTemplate(string loadPath)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public unsafe void De_SkillTemplate(string loadPath, Action<PoolBase> callback)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/>> (int)System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(nint)/*Error near IL_0003: Stack underflow*/);
		checked
		{
			nint num = (nint)System.Runtime.CompilerServices.Unsafe.Read<object>(unchecked((void*)(nint)checked(callback + /*Error near IL_0006: ldloca 116 (out-of-bounds)*/)));
			/*OpCode not supported: DebugBreak*/;
			switch ((short)num)
			{
			default:
				/*Error: End of method reached without returning.*/;
			}
		}
	}

	public void En_SkillTemplete(PoolBase poolBase)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public void Clear()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected I4, but got Unknown
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
		}
	}

	public unsafe void ClearPlayer()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xC0*/;
	}

	public unsafe void ClearMonster()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		if (!float.IsFinite(/*Error near IL_0003: Stack underflow*/))
		{
			throw new ArithmeticException();
		}
		_ = 1527867070113252352L;
		/*Error: End of method reached without returning.*/;
	}

	public unsafe void ClearSkillTemplete()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Invalid branch target*/;
	}

	public unsafe void UnloadPlayerAssets()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xC0*/;
	}

	public unsafe void UnloadMonsterAssets()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		if (!float.IsFinite(/*Error near IL_0003: Stack underflow*/))
		{
			throw new ArithmeticException();
		}
		_ = 1527867070381687808L;
		/*Error: End of method reached without returning.*/;
	}

	public void Unload()
	{
	}

	protected void Update()
	{
		pool_env?.Update();
		pool_player?.Update();
		pool_monster?.Update();
		pool_st?.Update();
	}
}
