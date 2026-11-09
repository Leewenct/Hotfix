using System.Runtime.CompilerServices;
using UnityEngine;

public class AdventureFXHandler : MonoBehaviour
{
	public enum DestroyMode
	{
		Destroy,
		DespawnToPool,
		Disable
	}

	public string fxTag;

	[Tooltip("例如: 连线轨迹在播放时间缩放变慢的情况下(由于粒子喷射速度变慢等原因)拖尾出来的轨迹不太美观时使用")]
	public bool disableTimeScale;

	protected float _timeScale;

	protected int _hidenRC;

	public long token
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		internal set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public DestroyMode destroyMode
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		internal set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool isIndependentUpdate
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public float timeScale
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Invalid field token*/;
		}
	}

	public bool ignoreTimeScale
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	internal float finalTimeScale
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xA8*/;
			}
		}
	}

	public float deltaTime
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Invalid metadata token*/;
			}
		}
	}

	public bool isHidden
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				nuint num = (nuint)/*Error near IL_0001: Stack underflow*/;
				_ = /*Error near IL_0003: Stack underflow*/- num;
				/*Error near IL_0003: ldarg 80 (out-of-bounds)*/;
				/*Error near IL_0005: Unknown opcode: 0xE9*/;
			}
		}
	}

	protected unsafe static Transform SpawnInstance(GameObject prefab, Vector3 spawnPosition, Quaternion spawnRotation, Vector3 spawnScale, bool isPreloadSpawn, out DestroyMode destroyMode)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (byte)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xE6*/;
		}
	}

	protected unsafe static void DestroyInstance(AdventureFXHandler instance)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
		_ = 2;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected virtual void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (byte)0;
			_ = 2;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected virtual void OnDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public virtual void DoUpdate()
	{
	}

	public virtual void DoLateUpdate()
	{
	}

	public virtual void SetIndependentUpdate(bool value)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public virtual void OnTimeScaleChanged()
	{
	}

	public void Hide()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	protected virtual void OnHide()
	{
	}

	public void Visible()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	protected virtual void OnVisible()
	{
	}

	public virtual void SetRenderLayer(int layer)
	{
	}

	public virtual void ResetRenderLayer()
	{
	}

	public static bool ActiveValidate(AdventureFXHandler instance, long compareToken = 0L)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0;
	}

	public AdventureFXHandler()
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
