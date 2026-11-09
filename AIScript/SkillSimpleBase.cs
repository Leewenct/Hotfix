using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AdventureBehaviour;
using AIScript.Utils;
using TrueSync;
using UnityEngine;

namespace AIScript;

public class SkillSimpleBase : AIBase
{
	public struct TempMultiShootParams
	{
		public HitBox.Shape shape;

		public string bulletAlias;

		public AdventureWeapon.MultipleShootStyle multipleShootStyle;

		public bool alignShoot;

		public FP alignShootDelay;

		public int bulletCount;

		public FP duration;

		public TSVector2 shootPosition;

		public FP shootPositionY;

		public TSVector2 multiShootDirection;

		public FP bulletDirectionOffset;

		public AimType aimType;

		public BulletDirectionType bulletDirectionType;

		public TSVector2 targetPosition;

		public LogicEntity target;

		public FP angle;

		public FP width;

		public FP length;

		public FP radius;

		public FP innerRadius;
	}

	protected class HitFeatureData
	{
		private HitBox.FeatureFlag _featureFlag;

		private HitBox.HitBoxFeatureData _featureData;

		public HitBox.FeatureFlag FeatureFlag
		{
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		public HitBox.HitBoxFeatureData FeatureData
		{
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		public HitFeatureData()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = (ushort)0;
				/*Error near IL_0004: Unknown opcode: 0xEC*/;
			}
		}

		public void ParseData(HitBox.FeatureFlag featureFlag, FP KnockBackForce, FP KnockBackDistance, bool UseAtttackForward, bool UseHitBoxPosition, FP KnockOutForce, string oldAreaTag, GameObject newAreaEffectPrefab, FP StiffDuration, FP FreezeFrameWhenDamage, FP FreezeFrameTimeScaleWhenDamage, FP FreezeFrameWhenCrit, FP FreezeFrameTimeScaleWhenCrit, FP FreezeFrameWhenToughnessBroken, FP FreezeFrameTimeScaleWhenToughnessBroken, FP FreezeFrameWhenKill, FP FreezeFrameTimeScaleWhenKill, List<int> buffIdsForSelf, List<int> buffIdsForTarget, List<int> removeBuffIdsForSelf, List<int> removeBuffIdsForTarget, FP hitStrenth)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_003F val = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				if (/*Error near IL_0006: Stack underflow*/ > val)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (ulong)/*Error near IL_0007: Stack underflow*/ + 1707910404;
			}
		}

		public unsafe void Clear()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0002: Unknown opcode: 0xF7*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CChangeModelScale_003Ed__382 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FP duration;

		public SkillSimpleBase _003C_003E4__this;

		public FP targetValue;

		private FP _003CchangeSpeed_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CChangeModelScale_003Ed__382(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CContinueAimAtMonsterTarget_003Ed__157 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public FP limitAngle;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CContinueAimAtMonsterTarget_003Ed__157(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CContinueAimAtPosition_003Ed__153 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TSVector2 position;

		public SkillSimpleBase _003C_003E4__this;

		public FP limitAngle;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CContinueAimAtPosition_003Ed__153(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDoMainLogic_003Ed__299 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CDoMainLogic_003Ed__299(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected I4, but got Unknown
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

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDynamicTransparentCor_003Ed__378 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public FP minDistance;

		public FP durationTransparent;

		public FP fadeTime;

		public FP maxDistance;

		private int _003Ctype_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CDynamicTransparentCor_003Ed__378(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CExecute_003Ed__295 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CExecute_003Ed__295(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected I4, but got Unknown
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

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CLinkFXAutoFinish_003Ed__296 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CLinkFXAutoFinish_003Ed__296(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoopDashWithAcc_003Ed__167 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public int index;

		public string key;

		public bool useComboSpd;

		public FP initialComboSpd;

		public FP acceleration;

		public FP initialVelocity;

		public FP maxVelocity;

		public FP distance;

		public FP angleLimit;

		public bool comboWithAttack;

		public bool isAngle;

		public bool notChangeForward;

		public bool triggerObstacleStop;

		public bool triggerEnemyStop;

		public bool triggerFriendStop;

		public FP minDashTime;

		public FP step;

		public FP maxComboSpd;

		private FP _003CtotleTime_003E5__2;

		private FP _003CelapsedTime_003E5__3;

		private FP _003CstepTime_003E5__4;

		private bool _003Cinterrupt_003E5__5;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CLoopDashWithAcc_003Ed__167(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Expected I4, but got Unknown
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
			case 84:
				/*Error: Invalid branch target*/;
			case 85:
				/*Error: Invalid branch target*/;
			case 86:
				/*Error: Invalid branch target*/;
			case 87:
				/*Error: Invalid branch target*/;
			case 88:
				/*Error: Invalid branch target*/;
			case 89:
				/*Error: Invalid branch target*/;
			case 90:
				/*Error: Invalid branch target*/;
			case 91:
				/*Error: Invalid branch target*/;
			case 92:
				/*Error: Invalid branch target*/;
			case 93:
				/*Error: Invalid branch target*/;
			case 94:
				/*Error: Invalid branch target*/;
			case 95:
				/*Error: Invalid branch target*/;
			case 96:
				/*Error: Invalid branch target*/;
			case 97:
				/*Error: Invalid branch target*/;
			case 98:
				/*Error: Invalid branch target*/;
			case 99:
				/*Error: Invalid branch target*/;
			case 100:
				/*Error: Invalid branch target*/;
			case 101:
				/*Error: Invalid branch target*/;
			case 102:
				/*Error: Invalid branch target*/;
			case 103:
				/*Error: Invalid branch target*/;
			case 104:
				/*Error: Invalid branch target*/;
			case 105:
				/*Error: Invalid branch target*/;
			case 106:
				/*Error: Invalid branch target*/;
			case 107:
				/*Error: Invalid branch target*/;
			case 108:
				/*Error: Invalid branch target*/;
			case 109:
				/*Error: Invalid branch target*/;
			case 110:
				/*Error: Invalid branch target*/;
			case 111:
				/*Error: Invalid branch target*/;
			case 112:
				/*Error: Invalid branch target*/;
			case 113:
				/*Error: Invalid branch target*/;
			case 114:
				/*Error: Invalid branch target*/;
			case 115:
				/*Error: Invalid branch target*/;
			case 116:
				/*Error: Invalid branch target*/;
			case 117:
				/*Error: Invalid branch target*/;
			case 118:
				/*Error: Invalid branch target*/;
			case 119:
				/*Error: Invalid branch target*/;
			case 120:
				/*Error: Invalid branch target*/;
			case 121:
				/*Error: Invalid branch target*/;
			case 122:
				/*Error: Invalid branch target*/;
			case 123:
				/*Error: Invalid branch target*/;
			case 124:
				/*Error: Invalid branch target*/;
			case 125:
				/*Error: Invalid branch target*/;
			case 126:
				/*Error: Invalid branch target*/;
			case 127:
				/*Error: Invalid branch target*/;
			case 128:
				/*Error: Invalid branch target*/;
			case 129:
				/*Error: Invalid branch target*/;
			case 130:
				/*Error: Invalid branch target*/;
			case 131:
				/*Error: Invalid branch target*/;
			case 132:
				/*Error: Invalid branch target*/;
			case 133:
				/*Error: Invalid branch target*/;
			case 134:
				/*Error: Invalid branch target*/;
			case 135:
				/*Error: Invalid branch target*/;
			case 136:
				/*Error: Invalid branch target*/;
			case 137:
				/*Error: Invalid branch target*/;
			case 138:
				/*Error: Invalid branch target*/;
			case 139:
				/*Error: Invalid branch target*/;
			case 140:
				/*Error: Invalid branch target*/;
			case 141:
				/*Error: Invalid branch target*/;
			case 142:
				/*Error: Invalid branch target*/;
			case 143:
				/*Error: Invalid branch target*/;
			case 144:
				/*Error: Invalid branch target*/;
			case 145:
				/*Error: Invalid branch target*/;
			case 146:
				/*Error: Invalid branch target*/;
			case 147:
				/*Error: Invalid branch target*/;
			case 148:
				/*Error: Invalid branch target*/;
			case 149:
				/*Error: Invalid branch target*/;
			case 150:
				/*Error: Invalid branch target*/;
			case 151:
				/*Error: Invalid branch target*/;
			case 152:
				/*Error: Invalid branch target*/;
			case 153:
				/*Error: Invalid branch target*/;
			case 154:
				/*Error: Invalid branch target*/;
			case 155:
				/*Error: Invalid branch target*/;
			case 156:
				/*Error: Invalid branch target*/;
			case 157:
				/*Error: Invalid branch target*/;
			case 158:
				/*Error: Invalid branch target*/;
			case 159:
				/*Error: Invalid branch target*/;
			case 160:
				/*Error: Invalid branch target*/;
			case 161:
				/*Error: Invalid branch target*/;
			case 162:
				/*Error: Invalid branch target*/;
			case 163:
				/*Error: Invalid branch target*/;
			case 164:
				/*Error: Invalid branch target*/;
			case 165:
				/*Error: Invalid branch target*/;
			case 166:
				/*Error: Invalid branch target*/;
			case 167:
				/*Error: Invalid branch target*/;
			case 168:
				/*Error: Invalid branch target*/;
			case 169:
				/*Error: Invalid branch target*/;
			case 170:
				/*Error: Invalid branch target*/;
			case 171:
				/*Error: Invalid branch target*/;
			case 172:
				/*Error: Invalid branch target*/;
			case 173:
				/*Error: Invalid branch target*/;
			case 174:
				/*Error: Invalid branch target*/;
			case 175:
				/*Error: Invalid branch target*/;
			case 176:
				/*Error: Invalid branch target*/;
			case 177:
				/*Error: Invalid branch target*/;
			case 178:
				/*Error: Invalid branch target*/;
			case 179:
				/*Error: Invalid branch target*/;
			case 180:
				/*Error: Invalid branch target*/;
			case 181:
				/*Error: Invalid branch target*/;
			case 182:
				/*Error: Invalid branch target*/;
			case 183:
				/*Error: Invalid branch target*/;
			case 184:
				/*Error: Invalid branch target*/;
			case 185:
				/*Error: Invalid branch target*/;
			case 186:
				/*Error: Invalid branch target*/;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CRotatePlayFXCor_003Ed__241 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public long fxPlayerToken;

		public FP rotateSpeed;

		public FP rotateAngle;

		private PlayFX _003CplayFX_003E5__2;

		private FP _003CrotateTime_003E5__3;

		private FP _003CsignRotateSpeed_003E5__4;

		private AdventureFXPlayer _003Cfx_003E5__5;

		private TSVector2 _003Cforward_003E5__6;

		private TSVector2 _003CtargetForward_003E5__7;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CRotatePlayFXCor_003Ed__241(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Expected I4, but got Unknown
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
			case 84:
				/*Error: Invalid branch target*/;
			case 85:
				/*Error: Invalid branch target*/;
			case 86:
				/*Error: Invalid branch target*/;
			case 87:
				/*Error: Invalid branch target*/;
			case 88:
				/*Error: Invalid branch target*/;
			case 89:
				/*Error: Invalid branch target*/;
			case 90:
				/*Error: Invalid branch target*/;
			case 91:
				/*Error: Invalid branch target*/;
			case 92:
				/*Error: Invalid branch target*/;
			case 93:
				/*Error: Invalid branch target*/;
			case 94:
				/*Error: Invalid branch target*/;
			case 95:
				/*Error: Invalid branch target*/;
			case 96:
				/*Error: Invalid branch target*/;
			case 97:
				/*Error: Invalid branch target*/;
			case 98:
				/*Error: Invalid branch target*/;
			case 99:
				/*Error: Invalid branch target*/;
			case 100:
				/*Error: Invalid branch target*/;
			case 101:
				/*Error: Invalid branch target*/;
			case 102:
				/*Error: Invalid branch target*/;
			case 103:
				/*Error: Invalid branch target*/;
			case 104:
				/*Error: Invalid branch target*/;
			case 105:
				/*Error: Invalid branch target*/;
			case 106:
				/*Error: Invalid branch target*/;
			case 107:
				/*Error: Invalid branch target*/;
			case 108:
				/*Error: Invalid branch target*/;
			case 109:
				/*Error: Invalid branch target*/;
			case 110:
				/*Error: Invalid branch target*/;
			case 111:
				/*Error: Invalid branch target*/;
			case 112:
				/*Error: Invalid branch target*/;
			case 113:
				/*Error: Invalid branch target*/;
			case 114:
				/*Error: Invalid branch target*/;
			case 115:
				/*Error: Invalid branch target*/;
			case 116:
				/*Error: Invalid branch target*/;
			case 117:
				/*Error: Invalid branch target*/;
			case 118:
				/*Error: Invalid branch target*/;
			case 119:
				/*Error: Invalid branch target*/;
			case 120:
				/*Error: Invalid branch target*/;
			case 121:
				/*Error: Invalid branch target*/;
			case 122:
				/*Error: Invalid branch target*/;
			case 123:
				/*Error: Invalid branch target*/;
			case 124:
				/*Error: Invalid branch target*/;
			case 125:
				/*Error: Invalid branch target*/;
			case 126:
				/*Error: Invalid branch target*/;
			case 127:
				/*Error: Invalid branch target*/;
			case 128:
				/*Error: Invalid branch target*/;
			case 129:
				/*Error: Invalid branch target*/;
			case 130:
				/*Error: Invalid branch target*/;
			case 131:
				/*Error: Invalid branch target*/;
			case 132:
				/*Error: Invalid branch target*/;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitBezierPathMoveStatus_003Ed__204 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public BaseNormalStatus status;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CWaitBezierPathMoveStatus_003Ed__204(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected I4, but got Unknown
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

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_waitCombo_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public ComboAttackType comboAttackType;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003C_waitCombo_003Ed__21(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
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

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_waitDash_003Ed__176 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public DashStatus dashStatus;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003C_waitDash_003Ed__176(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
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

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_waitMove_003Ed__186 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public BaseNormalStatus normalStatus;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003C_waitMove_003Ed__186(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected I4, but got Unknown
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

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_waitShoot_003Ed__368 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public BaseNormalStatus normalStatus;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003C_waitShoot_003Ed__368(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected I4, but got Unknown
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

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_waitTrace_003Ed__194 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003C_waitTrace_003Ed__194(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CbeginLookAt_003Ed__332 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public LogicEntity target;

		public FP duration;

		public FP rotateSpeed;

		public FP stopAngle;

		public bool ignoreActorTimeScale;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CbeginLookAt_003Ed__332(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CbeginLookAt_003Ed__333 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FP duration;

		public SkillSimpleBase _003C_003E4__this;

		public FP rotateSpeed;

		public FP stopAngle;

		public bool ignoreActorTimeScale;

		private LogicEntity _003ClastTarget_003E5__2;

		private FP _003CcurTime_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CbeginLookAt_003Ed__333(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected I4, but got Unknown
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
			case 84:
				/*Error: Invalid branch target*/;
			case 85:
				/*Error: Invalid branch target*/;
			case 86:
				/*Error: Invalid branch target*/;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CbeginLookAtByDir_003Ed__331 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public TSVector2 dir;

		public FP duration;

		public FP rotateSpeed;

		public bool ignoreActorTimeScale;

		public FP stopAngle;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CbeginLookAtByDir_003Ed__331(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CbeginLookAtByPos_003Ed__334 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public TSVector2 targetPos;

		public FP duration;

		public FP rotateSpeed;

		public bool ignoreActorTimeScale;

		public FP stopAngle;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CbeginLookAtByPos_003Ed__334(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CbeginRotateAngle_003Ed__330 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public FP angle;

		public FP rotateSpeed;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CbeginRotateAngle_003Ed__330(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cblink_003Ed__349 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ComboInputBuffer.ActionKey[] hideKeys;

		public SkillSimpleBase _003C_003E4__this;

		public string blinkBeginFx;

		public FP blinkHideDelay;

		public TSVector2 blinkPosition;

		public bool checkPositionReachable;

		public FP blinkDuration;

		public LogicEntity target;

		public string blinkFinishFx;

		public FP blinkShowDelay;

		public ComboInputBuffer.ActionKey[] showKeys;

		public int showCombWaitIndex;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003Cblink_003Ed__349(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Expected I4, but got Unknown
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
			case 84:
				/*Error: Invalid branch target*/;
			case 85:
				/*Error: Invalid branch target*/;
			case 86:
				/*Error: Invalid branch target*/;
			case 87:
				/*Error: Invalid branch target*/;
			case 88:
				/*Error: Invalid branch target*/;
			case 89:
				/*Error: Invalid branch target*/;
			case 90:
				/*Error: Invalid branch target*/;
			case 91:
				/*Error: Invalid branch target*/;
			case 92:
				/*Error: Invalid branch target*/;
			case 93:
				/*Error: Invalid branch target*/;
			case 94:
				/*Error: Invalid branch target*/;
			case 95:
				/*Error: Invalid branch target*/;
			case 96:
				/*Error: Invalid branch target*/;
			case 97:
				/*Error: Invalid branch target*/;
			case 98:
				/*Error: Invalid branch target*/;
			case 99:
				/*Error: Invalid branch target*/;
			case 100:
				/*Error: Invalid branch target*/;
			case 101:
				/*Error: Invalid branch target*/;
			case 102:
				/*Error: Invalid branch target*/;
			case 103:
				/*Error: Invalid branch target*/;
			case 104:
				/*Error: Invalid branch target*/;
			case 105:
				/*Error: Invalid branch target*/;
			case 106:
				/*Error: Invalid branch target*/;
			case 107:
				/*Error: Invalid branch target*/;
			case 108:
				/*Error: Invalid branch target*/;
			case 109:
				/*Error: Invalid branch target*/;
			case 110:
				/*Error: Invalid branch target*/;
			case 111:
				/*Error: Invalid branch target*/;
			case 112:
				/*Error: Invalid branch target*/;
			case 113:
				/*Error: Invalid branch target*/;
			case 114:
				/*Error: Invalid branch target*/;
			case 115:
				/*Error: Invalid branch target*/;
			case 116:
				/*Error: Invalid branch target*/;
			case 117:
				/*Error: Invalid branch target*/;
			case 118:
				/*Error: Invalid branch target*/;
			case 119:
				/*Error: Invalid branch target*/;
			case 120:
				/*Error: Invalid branch target*/;
			case 121:
				/*Error: Invalid branch target*/;
			case 122:
				/*Error: Invalid branch target*/;
			case 123:
				/*Error: Invalid branch target*/;
			case 124:
				/*Error: Invalid branch target*/;
			case 125:
				/*Error: Invalid branch target*/;
			case 126:
				/*Error: Invalid branch target*/;
			case 127:
				/*Error: Invalid branch target*/;
			case 128:
				/*Error: Invalid branch target*/;
			case 129:
				/*Error: Invalid branch target*/;
			case 130:
				/*Error: Invalid branch target*/;
			case 131:
				/*Error: Invalid branch target*/;
			case 132:
				/*Error: Invalid branch target*/;
			case 133:
				/*Error: Invalid branch target*/;
			case 134:
				/*Error: Invalid branch target*/;
			case 135:
				/*Error: Invalid branch target*/;
			case 136:
				/*Error: Invalid branch target*/;
			case 137:
				/*Error: Invalid branch target*/;
			case 138:
				/*Error: Invalid branch target*/;
			case 139:
				/*Error: Invalid branch target*/;
			case 140:
				/*Error: Invalid branch target*/;
			case 141:
				/*Error: Invalid branch target*/;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CcrossJump_003Ed__351 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public TSVector2 targetPosition;

		public FP speed;

		public FP duration;

		public bool comboWithAttack;

		public bool forbiddenHeight;

		public bool checkPositionReachable;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CcrossJump_003Ed__351(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CwaitCustomEvent_003Ed__313 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CwaitCustomEvent_003Ed__313(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected I4, but got Unknown
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

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CwaitLookAt_003Ed__335 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FP rotateSpd;

		public LogicEntity target;

		public FP rotateTime;

		public SkillSimpleBase _003C_003E4__this;

		private bool _003ClookAtActivedPlayerActor_003E5__2;

		private FP _003CcurTime_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CwaitLookAt_003Ed__335(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CwaitMoveDuration_003Ed__182 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSimpleBase _003C_003E4__this;

		public FP _maxDuration;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CwaitMoveDuration_003Ed__182(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected I4, but got Unknown
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
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	protected static readonly string TurnEvent;

	protected static readonly string StopTurnEvent;

	protected static readonly string ShootEvent;

	protected static readonly string AttackEvent;

	protected static readonly string DashEvent;

	private Dictionary<SpecialState, int> _specialStateDict;

	private CoroutineNode aimAtPositionCor;

	private CoroutineNode aimAtMonsterTargetCor;

	private LogicEntity aimTarget;

	private static int evt_DashEnd;

	private RequestDefaultState moveReq;

	private CoroutineNode waitDurationCorNode;

	protected TraceTarget _traceTarget;

	private RequestTrace traceReq;

	private RequestBezierPathMove _bezierPathMoveReq;

	private BezierPathMove _bezierPathMove;

	private List<PlayFX> _playFXList;

	private List<AdventureFXPlayer> _adFxList;

	private Dictionary<long, CoroutineNode> _rotateFXCorDic;

	private List<int> summonMonsterIds;

	private bool _isReceiveSkillTakeEffect;

	protected bool _isDisableByLostControl;

	private CoroutineNode executeCoroutineNode;

	private CoroutineNode logicCoroutineNode;

	private CoroutineNode linkFXCoroutineNode;

	private List<CoroutineNode> coroutineNodeList;

	private int waitComboIndex;

	private string waitEventName;

	private bool waitEvent;

	private List<string> receiveCustomEventNames;

	protected ComboAttack comboAttack;

	private RequestComboAttack requestComboAttack;

	private LookAtTarget lookAtTarget;

	public bool inLookAtState;

	private CoroutineNode corRotate;

	private PlayFX playFx;

	private List<PlayFX> playFXList;

	private List<PlayFX> playLinkFXList;

	private PlayMonsterTimeline _playMonsterTimeline;

	private PlayableDirectorConfig _directorConfig;

	private bool _isTimelinePlaying;

	private Dash dash;

	private RequestDash dashReq;

	private bool _inCrossJump;

	private bool needTryShootAgain;

	private int onceShootSuccessCount;

	private bool tryShootAgainFinish;

	private TempMultiShootParams tShootParams;

	private FP tryAnglePerStep;

	private int tryShootTimes;

	private int currentTryShootTimes;

	private RequestDefaultState shootReq;

	private readonly List<long> _bulletIdList;

	private List<LogicEntity> _searchTargets;

	private CommomAreaHitConfig _areaHitConfig;

	private HitFeatureData _hitFeatureData;

	private CoroutineNode _dynamicTransparentCor;

	private CoroutineNode _changeModelScaleCor;

	private Dictionary<MonsterEventType, MonsterEventParams> _monsterEventDict;

	protected HitFeatureData GetHitFeatureData(HitBox.FeatureFlag featureFlag = HitBox.FeatureFlag.None, FP KnockBackForce = default(FP), FP KnockBackDistance = default(FP), bool UseAtttackForward = false, FP KnockOutForce = default(FP), string oldAreaTag = null, GameObject newAreaEffectPrefab = null, FP StiffDuration = default(FP), FP FreezeFrameWhenDamage = default(FP), FP FreezeFrameTimeScaleWhenDamage = default(FP), FP FreezeFrameWhenCrit = default(FP), FP FreezeFrameTimeScaleWhenCrit = default(FP), FP FreezeFrameWhenToughnessBroken = default(FP), FP FreezeFrameTimeScaleWhenToughnessBroken = default(FP), FP FreezeFrameWhenKill = default(FP), FP FreezeFrameTimeScaleWhenKill = default(FP), List<int> buffIdsForSelf = null, List<int> buffIdsForTarget = null, List<int> removeBuffIdsForSelf = null, List<int> removeBuffIdsForTarget = null, FP hitStrenth = default(FP), bool UseHitBoxPosition = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected I4, but got Unknown
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
		}
	}

	protected int AreaHit_Simple(LogicEntity entity, DeterministicShape shape, HitFeatureData hitFeatureData, int hitDamageId, FP damageImmuneDuration, HitBox.HurtAnimType hurtAnimType, string hittedEffectAlias = "")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 215 (out-of-bounds)*/;
		}
		if ((int)/*Error near IL_0008: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = 0;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	protected long PlayAreaEffect(string fxAlias, TSVector2 position = default(TSVector2), FP rotation = default(FP))
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

	protected AreaEffectEntity GetAreaEffect(long id)
	{
		/*Error: Invalid field token*/;
	}

	protected void StopAreaEffect(long id)
	{
		/*Error: Invalid field token*/;
	}

	protected unsafe void DirectDamage(LogicEntity toActor, int damage, string tag, bool showHud = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = ref this;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected unsafe void DirectHeal(LogicEntity toActor, int value, bool showHud = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = ref this;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected unsafe long PlayLineAreaWeapon(string fxAlias, bool isFixedEntitySource = false, TSVector2 sourcePosition = default(TSVector2), FP sourcePositionY = default(FP), LogicEntity sourceEntity = null, TSVector2 sourceOffset = default(TSVector2), bool isFixedEntityTarget = false, TSVector2 targetPosition = default(TSVector2), FP targetPositionY = default(FP), LogicEntity targetEntity = null, TSVector2 targetOffset = default(TSVector2), long overrideLineAreaWeaponId = 0L)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_0009: Stack underflow*/ <= /*Error near IL_0009: Stack underflow*/)
		{
			_ = *(float*)(nint)(~checked(/*Error near IL_000b: Stack underflow*/ * (nint)/*Error near IL_000a: Stack underflow*/));
			/*Error near IL_000d: Unknown opcode: 0x77*/;
		}
		_ = ((IntPtr[])/*Error near IL_0084: Stack underflow*/)[/*Error near IL_0084: Stack underflow*/];
		/*Error near IL_0084: Unknown opcode: 0xF2*/;
	}

	protected void StopLineAreaWeapon(long id)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	protected void AddBuffToTarget(LogicEntity target, int buffID, int num = 1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	protected void RemoveBuffFromTarget(LogicEntity target, int buffID = 0, int buffGroupID = 0, int buffTag = 0)
	{
		/*Error: Invalid metadata token*/;
	}

	protected void RemoveBuffByNumFromTarget(LogicEntity target, int buffId, int removeNum)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected int GetBuffNum(LogicEntity target, int buffID)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected void AddShieldToTarget(LogicEntity target, int shieldId)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004->IL0004: Incompatible stack heights: 1 vs 0
		if (/*Error near IL_0002: Stack underflow*/ <= /*Error near IL_0002: Stack underflow*/)
		{
			_ = /*Error near IL_0004: Stack underflow*/^ this;
		}
		throw /*Error near IL_0005: Stack underflow*/;
	}

	protected unsafe List<BuffEntity> GetBuffFromTarget(LogicEntity target, int buffID = 0, int buffGroupID = 0, int buffTag = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = ref this;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected unsafe void RemoveShieldById(LogicEntity target, int shieldId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = ref this;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected RequestComboAttack BeginAttack(int keyIndex, ComboInputBuffer.ActionKey[] keys, bool flushInputedKeys = false, bool forceInterruptAttack = false, bool autoLookAtTarget = false, LogicEntity attackTarget = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected I4, but got Unknown
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
		}
	}

	protected RequestComboAttack BeginAttack(int keyIndex, string actionKey, bool flushInputedKeys = false, bool forceInterruptAttack = false, bool autoLookAtTarget = false, LogicEntity attackTarget = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected I4, but got Unknown
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
		}
	}

	protected void CancelAttack()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected void InterruptAttack()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected CoroutineNode WaitCombo(ComboAttackType comboAttackType)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
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
		}
	}

	[IteratorStateMachine(typeof(_003C_waitCombo_003Ed__21))]
	private IEnumerator _waitCombo(ComboAttackType comboAttackType)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected object WaitCustomEvent(string eventName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected I4, but got Unknown
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

	protected virtual void OnCustomEvent(int comboIndex, string eventName)
	{
	}

	protected virtual void OnComboLoop(int comboIndex)
	{
	}

	protected void SummonMonster(int summonActorID, int summonGroupID, TSVector2 spawnPosition, TSVector2 spawnDirection)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	protected void SummonTeammate(int index, TSVector2 spawnPosition, TSVector2 spawnDirection, int maxAmount = 0)
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

	protected void KillActors(List<LogicEntity> entities)
	{
		/*Error: Invalid field token*/;
	}

	protected void ClearActors(List<LogicEntity> entities)
	{
		/*Error: Invalid field token*/;
	}

	protected void UseMonsterCloneActorCastSkill(int skillId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void Idle()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected I4, but got Unknown
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
		}
	}

	protected void Action()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		throw /*Error near IL_0003: Stack underflow*/;
	}

	protected void CircleMultipleShoot(string bulletAlias, AdventureWeapon.MultipleShootStyle multipleShootStyle, bool alignShoot, FP alignShootDelay, int bulletCount, FP duration, TSVector2 shootPosition, FP shootPositionY, TSVector2 multiShootDirection, FP bulletDirectionOffset, AimType aimType, BulletDirectionType bulletDirectionType, FP radius, FP innerRadius, TSVector2 targetPosition = default(TSVector2), LogicEntity target = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	protected void FanMultipleShoot(string bulletAlias, AdventureWeapon.MultipleShootStyle multipleShootStyle, bool alignShoot, FP alignShootDelay, int bulletCount, FP duration, TSVector2 shootPosition, FP shootPositionY, TSVector2 multiShootDirection, FP bulletDirectionOffset, AimType aimType, BulletDirectionType bulletDirectionType, FP angle, FP radius, FP innerRadius, TSVector2 targetPosition = default(TSVector2), LogicEntity target = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xCE*/;
		}
	}

	protected void RectangleMultipleShoot(string bulletAlias, AdventureWeapon.MultipleShootStyle multipleShootStyle, bool alignShoot, FP alignShootDelay, bool awaitShootCompletion, int bulletCount, FP duration, TSVector2 shootPosition, FP shootPositionY, TSVector2 multiShootDirection, FP bulletDirectionOffset, AimType aimType, BulletDirectionType bulletDirectionType, FP width, FP length, TSVector2 targetPosition = default(TSVector2), LogicEntity target = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	protected long Shoot(string bulletAlias, TSVector2 position, FP positionY, FP range, TSVector2 shootDirection = default(TSVector2), AimType aimType = AimType.Default, BulletDirectionType bulletDirectionType = BulletDirectionType.ActorToBullet, TSVector2 targetPosition = default(TSVector2), LogicEntity target = null)
	{
		/*Error: Unknown opcode: 0xE3*/;
	}

	protected long ShootWeapon(string weaponAlias, TSVector2 position, FP positionY, TSVector2 shootDirection = default(TSVector2), LogicEntity target = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I8
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((long)/*Error near IL_000c: Stack underflow*/ != (long)checked((ulong)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		checked
		{
			_ = /*Error near IL_000d: Stack underflow*/* /*Error near IL_000d: Stack underflow*/;
			/*Error near IL_000d: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	protected CoroutineNode WaitShootStatus()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
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
		}
	}

	protected List<long> GetShootBulletIdList()
	{
		/*Error: Invalid field token*/;
	}

	protected void ClearShootBulletIdList()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected TSVector2 GetBulletPosition(long bulletId)
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

	protected AdventureBulletBase GetBulletByID(long bulletId)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected TSVector2 GetBulletDirection(long bulletId)
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

	protected unsafe void ClearOwnerBullet()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xED*/;
	}

	protected void ClearOwnerWeapon()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void FinishBullet(long bulletId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
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
		}
	}

	protected void FinishWeapon(long weaponId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void EnableSpecialState(SpecialState state)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
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

	private void DisableSpecialState(SpecialState state)
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

	private void ClearSpecialState()
	{
		//Discarded unreachable code: IL_001b
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected I4, but got Unknown
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
		case 84:
			/*Error: Invalid branch target*/;
		case 85:
			/*Error: Invalid branch target*/;
		case 86:
			/*Error: Invalid branch target*/;
		case 87:
			/*Error: Invalid branch target*/;
		case 88:
			/*Error: Invalid branch target*/;
		case 89:
			/*Error: Invalid branch target*/;
		case 90:
			/*Error: Invalid branch target*/;
		case 91:
			/*Error: Invalid branch target*/;
		case 92:
			/*Error: Invalid branch target*/;
		case 93:
			/*Error: Invalid branch target*/;
		case 94:
			/*Error: Invalid branch target*/;
		case 95:
			/*Error: Invalid branch target*/;
		case 96:
			/*Error: Invalid branch target*/;
		case 97:
			/*Error: Invalid branch target*/;
		case 98:
			/*Error: Invalid branch target*/;
		case 99:
			/*Error: Invalid branch target*/;
		case 100:
			/*Error: Invalid branch target*/;
		case 101:
			/*Error: Invalid branch target*/;
		case 102:
			/*Error: Invalid branch target*/;
		case 103:
			/*Error: Invalid branch target*/;
		case 104:
			/*Error: Invalid branch target*/;
		case 105:
			/*Error: Invalid branch target*/;
		case 106:
			/*Error: Invalid branch target*/;
		case 107:
			/*Error: Invalid branch target*/;
		case 108:
			/*Error: Invalid branch target*/;
		case 109:
			/*Error: Invalid branch target*/;
		case 110:
			/*Error: Invalid branch target*/;
		case 111:
			/*Error: Invalid branch target*/;
		case 112:
			/*Error: Invalid branch target*/;
		case 113:
			/*Error: Invalid branch target*/;
		case 114:
			/*Error: Invalid branch target*/;
		case 115:
			/*Error: Invalid branch target*/;
		case 116:
			/*Error: Invalid branch target*/;
		case 117:
			/*Error: Invalid branch target*/;
		case 118:
			/*Error: Invalid branch target*/;
		case 119:
			/*Error: Invalid branch target*/;
		case 120:
			/*Error: Invalid branch target*/;
		case 121:
			/*Error: Invalid branch target*/;
		case 122:
			/*Error: Invalid branch target*/;
		case 123:
			/*Error: Invalid branch target*/;
		case 124:
			/*Error: Invalid branch target*/;
		case 125:
			/*Error: Invalid branch target*/;
		case 126:
			/*Error: Invalid branch target*/;
		case 127:
			/*Error: Invalid branch target*/;
		case 128:
			/*Error: Invalid branch target*/;
		case 129:
			/*Error: Invalid branch target*/;
		case 130:
			/*Error: Invalid branch target*/;
		case 131:
			/*Error: Invalid branch target*/;
		case 132:
			/*Error: Invalid branch target*/;
		case 133:
			/*Error: Invalid branch target*/;
		case 134:
			/*Error: Invalid branch target*/;
		case 135:
			/*Error: Invalid branch target*/;
		case 136:
			/*Error: Invalid branch target*/;
		case 137:
			/*Error: Invalid branch target*/;
		case 138:
			/*Error: Invalid branch target*/;
		}
	}

	protected void SetSuperArmorEnable(bool autoDisableWhenSkillDisable = true)
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

	protected void SetSuperArmorDisable(bool resetCount = true)
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

	protected unsafe void InterruptSuperArmor()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void SetImmuneControlEnable(bool autoDisableWhenSkillDisable = true)
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

	protected void SetImmuneControlDisable(bool resetCount = true)
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

	public unsafe void InterruptImmuneControl()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void SetInvincibleEnable(bool autoDisableWhenSkillDisable = true)
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

	protected void SetInvincibleDisable(bool resetCount = true)
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

	public unsafe void InterruptInvincible()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void SetSearchedImmunityEnable(bool autoDisableWhenSkillDisable = true)
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

	protected void SetSearchedImmunityDisable(bool resetCount = true)
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

	public unsafe void InterruptSearchedImmunity()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void SetCloseBlockEnable(bool autoDisableWhenSkillDisable = true)
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

	protected void SetCloseBlockDisable(bool resetCount = true)
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

	protected unsafe void InterruptCloseBlock()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void SetHideModelEnable(bool autoDisableWhenSkillDisable = true)
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

	protected void SetHideModelDisable(bool resetCount = true)
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

	protected unsafe void InterruptHideModel()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void SetSneakEnable(bool autoDisableWhenSkillDisable = true)
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

	protected void SetSneakDisable(bool resetCount = true)
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

	protected void EnterSneakWithDynamicTransparentByDistance(FP minDistance, FP maxDistance, FP durationTransparent, FP fadeTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	protected void ExitSneakWithDynamicTransparentByDistance()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/>> (int)((byte[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0006: Unknown opcode: 0xB0*/;
	}

	protected void InterruptSneak()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0004: Stack underflow*/+ checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) / 0;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected void SetHideOutEnable(bool autoDisableWhenSkillDisable = true)
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

	protected void SetHideOutDisable(bool resetCount = true)
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

	protected unsafe void InterruptHideOut()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void SetBattleOutEnable(bool autoDisableWhenSkillDisable = true)
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

	protected void SetBattleOutDisable(bool resetCount = true)
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

	protected unsafe void InterruptBattleOut()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void SetUnparalleledEnable(bool autoDisableWhenSkillDisable = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
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

	protected void SetUnparalleledDisable(bool resetCount = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
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

	protected unsafe void InterruptUnparalleled()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void SetLockHpAbsEnable(bool isAbs, FP hp, bool autoDisableWhenSkillDisable = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_003F val2 = /*Error near IL_0001: ldloca 223 (out-of-bounds)*/;
		/*OpCode not supported: DebugBreak*/;
		_ = ~(nint)((IntPtr[])val)[val2];
		/*Error near IL_0006: Unknown opcode: 0xED*/;
	}

	protected void SetLockHpDisable(bool resetCount = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
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

	protected void SetLockToughnessEnable(bool autoDisableWhenSkillDisable = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected I4, but got Unknown
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

	protected void SetLockToughnessDisable(bool resetCount = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected I4, but got Unknown
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

	protected void InterruptLockToughness()
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

	protected void SetBlockPriorityToStatic(bool autoDisableWhenSkillDisable = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
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

	protected void ResetBlockPriority(bool resetCount = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
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

	protected bool GetLogicTagToggleValue(LogicEntity entity, string tagName)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected string GetLogicTagStringValue(LogicEntity entity, string tagName)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected FP GetLogicTagFpValue(LogicEntity entity, string tagName)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected TSVector2 GetLogicTagTSVector2Value(LogicEntity entity, string tagName)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected void SetLogicTagToggleValue(LogicEntity entity, string tagName, bool value)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected void SetLogicTagStringValue(LogicEntity entity, string tagName, string value)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected void SetLogicTagFpValue(LogicEntity entity, string tagName, FP value)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected void SetLogicTagTSVector2Value(LogicEntity entity, string tagName, TSVector2 value)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected void SetLogicTagListTSVector2Value(LogicEntity entity, string tagName, List<TSVector2> value)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected void SetLogicTagDicIntTSVector2Value(LogicEntity entity, string tagName, Dictionary<int, TSVector2> value)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected void SetLogicTagDicTSVector2LongValue(LogicEntity entity, string tagName, Dictionary<TSVector2, long> value)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected void SetLogicTagListLongValue(LogicEntity entity, string tagName, List<long> value)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected List<TSVector2> GetLogicTagListTSVector2Value(LogicEntity entity, string tagName)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected Dictionary<int, TSVector2> GetLogicTagDicIntTSVector2Value(LogicEntity entity, string tagName)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected Dictionary<TSVector2, long> GetLogicTagDicTSVector2LongValue(LogicEntity entity, string tagName)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected List<long> GetLogicTagListLongValue(LogicEntity entity, string tagName)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected DeterministicShape GetShapeData(DeterministicShape.ShapeType shapeT = DeterministicShape.ShapeType.Circle, TSVector2 position = default(TSVector2), FP width = default(FP), FP length = default(FP), FP radius = default(FP), FP innerRadius = default(FP), FP angle = default(FP), FP rotation = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/!= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (uint)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	protected int randomWeight(int[] rdmWeights)
	{
		/*Error: Invalid field token*/;
	}

	protected FP GetRandomValue(FP minValue, FP maxValue, bool isInt = false)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected TSVector2 GetShapeRandomPoint(DeterministicShape shape, LogicEntity entity, bool isReachable = false)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected FP Distance(TSVector2 value1, TSVector2 value2)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected TSVector2 GetTSVector2(FP x, FP y)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected FP GetTSVectToAngle(TSVector2 value, FP angle)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected TSVector2 TransLocalPosToWorldPos(TSVector2 csOrigin, TSVector2 csForward, TSVector2 relativePoint)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected TSVector2 RotateTo(TSVector2 from, FP angle)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected FP AngleBetween2TSVector(TSVector2 from, TSVector2 to, bool signed)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected void SetCanPerfectDodgeEnable(bool resetCount = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
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

	protected void SetCanPerfectDodgeDisable(bool autoEnableWhenSkillDisable = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
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

	protected unsafe void InterruptSkill()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF4*/;
	}

	protected void PlayWwiseSound(string _event, LogicEntity _owner = null)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		throw /*Error near IL_0003: Stack underflow*/;
	}

	protected void TriggerOpLisener(string _triggerOpIDN)
	{
		/*Error: Invalid field token*/;
	}

	protected bool MonsterInState(int state)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected I4, but got Unknown
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

	protected unsafe void SendDeclareDeadEvent()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void DispatchCustomEvent(string eventName, bool isSelfEvent = true)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void DispatchCustomEvent(int eventNameHash, bool isSelfEvent = true)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void DropItem(int itemId, TSVector2 position = default(TSVector2), FP posY = default(FP))
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void BossEnergyValueChage(int value, LogicEntity target)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void EnergyHudShow(bool isShow, long showId, int initValue, int initState)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected CoroutineNode WaitTime(FP waitSeconds)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I8
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((long)/*Error near IL_0009: Stack underflow*/ > (long)checked((ulong)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0009: stloc 103 (out-of-bounds)*/;
		checked
		{
			_ = (ulong)(/*Error near IL_000d: Stack underflow*/ * (/*Error near IL_000c: Stack underflow*/ >> unchecked((int)/*Error near IL_000c: Stack underflow*/)));
			/*Error near IL_000e: Invalid metadata token*/;
		}
	}

	protected unsafe CoroutineNode WaitFrame(int frameCount)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I8, but got Unknown
		*(long*)(nint)/*Error near IL_0002: Stack underflow*/ = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xED*/;
	}

	protected CoroutineNode WaitUntil(Func<bool> predicate)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I8
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((long)/*Error near IL_0009: Stack underflow*/ > (long)checked((ulong)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		checked
		{
			_ = (ulong)(/*Error near IL_000d: Stack underflow*/ * (/*Error near IL_000c: Stack underflow*/ >> 1));
			/*Error near IL_000e: Invalid metadata token*/;
		}
	}

	protected CoroutineNode BeginRotateAngle(FP angle, FP rotateSpeed)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_000b: Stack underflow*/ > /*Error near IL_000b: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = (sbyte)/*Error near IL_000b: ldarga 211 (out-of-bounds)*/;
		/*Error near IL_000e: Unknown opcode: 0xEF*/;
	}

	protected void BeginRotateAngle_NotWait(FP angle, FP rotateSpeed)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
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

	protected void BeginLookAtCameraDir_NotWait(DirectionType dirType, FP duration = default(FP), FP rotateSpeed = default(FP), FP stopAngle = default(FP))
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected CoroutineNode BeginLookAtCameraDir(DirectionType dirType, FP duration = default(FP), FP rotateSpeed = default(FP), FP stopAngle = default(FP))
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void BeginLookAtByDir_NotWait(TSVector2 targetDir, FP duration = default(FP), FP rotateSpeed = default(FP), FP stopAngle = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected I4, but got Unknown
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
		}
	}

	protected CoroutineNode BeginLookAtByDir(TSVector2 targetDir, FP duration = default(FP), FP rotateSpeed = default(FP), FP stopAngle = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			if (unchecked((int)/*Error near IL_000c: Stack underflow*/) != (short)/*Error near IL_0007: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)(/*Error near IL_000d: Stack underflow*/ * /*Error near IL_000d: Stack underflow*/);
			/*Error near IL_000e: Invalid metadata token*/;
		}
	}

	protected void BeginLookAtByPos_NotWait(TSVector2 targetPos, FP duration = default(FP), FP rotateSpeed = default(FP), FP stopAngle = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected I4, but got Unknown
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
		}
	}

	protected CoroutineNode BeginLookAtByPos(TSVector2 targetPos, FP duration = default(FP), FP rotateSpeed = default(FP), FP stopAngle = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			if (unchecked((int)/*Error near IL_000c: Stack underflow*/) != (short)/*Error near IL_0007: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)(/*Error near IL_000d: Stack underflow*/ * /*Error near IL_000d: Stack underflow*/);
			/*Error near IL_000e: Invalid metadata token*/;
		}
	}

	protected CoroutineNode BeginLookAt(LogicEntity target, FP duration = default(FP), FP rotateSpeed = default(FP), FP stopAngle = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			if (unchecked((int)/*Error near IL_000c: Stack underflow*/) != (short)/*Error near IL_0007: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)(/*Error near IL_000d: Stack underflow*/ * /*Error near IL_000d: Stack underflow*/);
			/*Error near IL_000e: Invalid metadata token*/;
		}
	}

	protected void BeginLookAt_NotWait(LogicEntity target, FP duration = default(FP), FP rotateSpeed = default(FP), FP stopAngle = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	protected unsafe CoroutineNode WaitLookAt(LogicEntity target, FP rotateTime, FP rotateSpd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = checked((ulong)/*Error near IL_0007: Stack underflow*/) >> (int)(*(double*)(-1934358352));
		/*Error near IL_000e: Unknown opcode: 0xE5*/;
	}

	protected void WaitLookAt_NoWait(LogicEntity target, FP rotateTime, FP rotateSpd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	protected CoroutineNode BeginLookAtMonsterTarget(FP duration = default(FP), FP rotateSpeed = default(FP), FP stopAngle = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	protected void StopWaitLookAt()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected I4, but got Unknown
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
		}
	}

	protected void AimAtTarget(LogicEntity target, FP limtAngle = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	protected void AimAtPosition(TSVector2 position, FP limitAngle = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = checked((ulong)/*Error near IL_0007: Stack underflow*/) >> (int)checked((sbyte)1188497408u);
		/*Error near IL_000e: Unknown opcode: 0xE3*/;
	}

	[IteratorStateMachine(typeof(_003CContinueAimAtPosition_003Ed__153))]
	private IEnumerator ContinueAimAtPosition(TSVector2 position, FP limitAngle)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected void AimAtMonsterTarget(FP limitAngle = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/ >> 328421382;
			/*Error near IL_000e: Unknown opcode: 0xCD*/;
		}
	}

	[IteratorStateMachine(typeof(_003CContinueAimAtMonsterTarget_003Ed__157))]
	private IEnumerator ContinueAimAtMonsterTarget(FP limitAngle)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected void AimDirection(TSVector2 direction, FP limitAngle = default(FP))
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		throw /*Error near IL_0003: Stack underflow*/;
	}

	protected unsafe void CancelAim()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected F8, but got Obj
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		*(double*)checked((sbyte)(ulong)/*Error near IL_0007: Stack underflow*/) = (double)null;
		/*Error near IL_000a: Unknown opcode: 0xAF*/;
	}

	protected void Blink_NotWait(ComboInputBuffer.ActionKey[] hideKeys, TSVector2 blinkPosition, FP blinkDuration, string blinkBeginFx, FP blinkHideDelay, string blinkFinishFx, FP blinkShowDelay, LogicEntity target = null, ComboInputBuffer.ActionKey[] showKeys = null, int showCombWaitIndex = 1, bool checkPositionReachable = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
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
		}
	}

	protected CoroutineNode Blink(ComboInputBuffer.ActionKey[] hideKeys, TSVector2 blinkPosition, FP blinkDuration, string blinkBeginFx, FP blinkHideDelay, string blinkFinishFx, FP blinkShowDelay, LogicEntity target = null, ComboInputBuffer.ActionKey[] showKeys = null, int showCombWaitIndex = 1, bool checkPositionReachable = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			_ = (short)/*Error near IL_0008: ldarg 28 (out-of-bounds)*/;
			/*Error near IL_000b: Read out of bounds.*/;
		}
	}

	protected void Teleport(TSVector2 targetPosition, bool checkPositionReachable = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 219 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xEE*/;
		}
	}

	protected Dash BeginDash(int index, TSVector2 direction, FP speed, FP distance, FP angleLimit, bool comboWithAttack = false, bool isAngle = false, bool notChangeForward = false, bool triggerObstacleStop = true, bool triggerEnemyStop = true, bool triggerFriendStop = true, FP minDashTime = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected I4, but got Unknown
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
		}
	}

	protected Dash BeginDashActorForward(int index, FP speed, FP distance, FP angleLimit, bool comboWithAttack = false, bool isAngle = false, bool notChangeForward = false, bool triggerObstacleStop = true, bool triggerEnemyStop = true, bool triggerFriendStop = true, FP minDashTime = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected I4, but got Unknown
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
		}
	}

	protected CoroutineNode BeginDashWithAcc(int index, string key, FP acceleration, FP initialVelocity, FP maxVelocity, bool useComboSpd, FP initialComboSpd, FP maxComboSpd, FP step, FP distance, FP angleLimit, bool comboWithAttack = false, bool isAngle = false, bool notChangeForward = false, bool triggerObstacleStop = true, bool triggerEnemyStop = true, bool triggerFriendStop = true, FP minDashTime = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			_ = (short)/*Error near IL_0008: ldarg 28 (out-of-bounds)*/;
			/*Error near IL_000b: Read out of bounds.*/;
		}
	}

	[IteratorStateMachine(typeof(_003CLoopDashWithAcc_003Ed__167))]
	protected IEnumerator LoopDashWithAcc(int index, string key, FP acceleration, FP initialVelocity, FP maxVelocity, bool useComboSpd, FP initialComboSpd, FP maxComboSpd, FP step, FP distance, FP angleLimit, bool comboWithAttack = false, bool isAngle = false, bool notChangeForward = false, bool triggerObstacleStop = true, bool triggerEnemyStop = true, bool triggerFriendStop = true, FP minDashTime = default(FP))
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void DashFinish()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
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
		}
	}

	private void DashFinishByActor()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected I4, but got Unknown
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
		}
	}

	private void DashFinishByObstacle()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
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
		}
	}

	protected virtual void OnDashFinish(int index)
	{
	}

	protected virtual void DashFinishByActor(int index)
	{
	}

	protected virtual void DashFinishByFriend(int index)
	{
	}

	protected virtual void DashFinishByObstacle(int index)
	{
	}

	protected CoroutineNode WaitDashFinish(DashStatus dashStatus = DashStatus.Running)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
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
		}
	}

	[IteratorStateMachine(typeof(_003C_waitDash_003Ed__176))]
	private IEnumerator _waitDash(DashStatus dashStatus)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected void StopDash()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected I4, but got Unknown
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

	protected bool CheckHitPlayer()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
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

	protected void MoveToPosition(TSVector2 position, FP stopDistance, AdventureActor.MovementMode moveMode = AdventureActor.MovementMode.Run, FP _maxDuration = default(FP), bool _stopDisIgnoreRadius = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected I4, but got Unknown
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
		}
	}

	[IteratorStateMachine(typeof(_003CwaitMoveDuration_003Ed__182))]
	private IEnumerator waitMoveDuration(FP _maxDuration)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void MoveFinish()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
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

	protected void StopMove()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected I4, but got Unknown
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
		}
	}

	protected CoroutineNode WaitMoveStatus(BaseNormalStatus moveStatus = BaseNormalStatus.Complete)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
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
		}
	}

	[IteratorStateMachine(typeof(_003C_waitMove_003Ed__186))]
	private IEnumerator _waitMove(BaseNormalStatus normalStatus)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected void BeginTrace(LogicEntity target, FP stopDistance, FP cancelDistance, FP cancelTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected I4, but got Unknown
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
		}
	}

	protected void StopTrace()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I4, but got Unknown
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

	private void traceFinish()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	private void traceCancel(bool targetDied, bool isInterrupt, bool isTimeout, bool isDistanceOut)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected CoroutineNode WaitTraceFinish()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
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
		}
	}

	[IteratorStateMachine(typeof(_003C_waitTrace_003Ed__194))]
	private IEnumerator _waitTrace()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_000b: Stack underflow*/ < /*Error near IL_0005: ldloc 0 (out-of-bounds)*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*OpCode not supported: DebugBreak*/;
		switch (checked((sbyte)/*Error near IL_000d: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		}
	}

	public unsafe TraceStatus GetTraceStatus()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = *(sbyte*)4;
		return (TraceStatus)/*Error near IL_0005: ldarg 2 (out-of-bounds)*/;
	}

	protected CoroutineNode CrossJump(TSVector2 targetPosition, FP speed, FP duration, bool checkPositionReachable = true)
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

	protected void BeginBezierPathMove(int indexId, TSVector2 targetPosition, FP controlPointXOffsetRatio, FP controlPointYOffsetRatio, bool comboWithAttack = false, FP moveSpeedRatioAbsAmend = default(FP), AdventureActor.MovementMode movementMode = AdventureActor.MovementMode.Run, int moveStep = 80, FP _maxDuration = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected I4, but got Unknown
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
		}
	}

	private void BezierPathMoveFinishCallback(bool reachTerminal)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
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
		}
	}

	protected virtual void OnBezierPathMoveFinish(int index, bool reachTerminal)
	{
	}

	protected unsafe void CancelBezierPathMove()
	{
		//IL_0002: Expected F8, but got I4
		//IL_0003: Expected native int or pointer, but got Obj
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		//IL_000a: Invalid comparison between Unknown and I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		sbyte b = *(sbyte*)unchecked((nint)null);
		((object[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = checked(b + /*Error near IL_0005: ldarg 2 (out-of-bounds)*/);
		if ((int)/*Error near IL_000c: Stack underflow*/ >= (int)checked((uint)/*Error near IL_000a: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error: End of method reached without returning.*/;
	}

	protected CoroutineNode WaitBezierPathMoveFinish()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
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
		}
	}

	[IteratorStateMachine(typeof(_003CWaitBezierPathMoveStatus_003Ed__204))]
	private IEnumerator WaitBezierPathMoveStatus(BaseNormalStatus status = BaseNormalStatus.Complete)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected void ShowBlood(bool isShow)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected I4, but got Unknown
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
		}
	}

	protected void ShowCenterHpBar()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
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
		}
	}

	protected void RefreshCenterHpBar()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void ModelNodeShow(string nodeName, bool isShow)
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

	protected void ReplaceAnimationGroup(int index = 0)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		throw /*Error near IL_0003: Stack underflow*/;
	}

	protected void PlayFeedbackEffect(string alias, TSVector2 blurPosition = default(TSVector2))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		this = (SkillSimpleBase)/*Error near IL_0009: Stack underflow*/;
	}

	protected void PlayTimeline(int index = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected I4, but got Unknown
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

	protected unsafe bool IsTimelineFinish()
	{
		//IL_0003: Expected F8, but got I
		nuint num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
		*(double*)(nint)/*Error near IL_0003: Stack underflow*/ = (nint)num;
		if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: Unknown opcode: 0xE9*/;
	}

	protected void AttackHintShow()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected void AttackHintHide()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected void AttackHint()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected void AttackHintCancel()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected void AttackHintEnd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected void SwitchCameraSetting(bool active, string cameraName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 216 (out-of-bounds)*/;
			_ = null;
			/*Error near IL_0004: Unknown opcode: 0xAA*/;
		}
	}

	protected void FireStateValueChange(int state)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void FireHotValueChange(int value)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void FireHudShow(bool isShow, long showId, int initValue, int initState)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void TransparentFadeIn(float transparency, float duration)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		throw /*Error near IL_0003: Stack underflow*/;
	}

	protected void TransparentFadeOut(float transparency = -1f, float duration = 0.5f)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		throw /*Error near IL_0003: Stack underflow*/;
	}

	protected void ChangeModelScale(bool setAbsValue = false, FP value = default(FP), FP duration = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected I4, but got Unknown
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
		}
	}

	protected void TransformByModelName(string modelName, bool changeColliderScale = false, FP colliderScale = default(FP), bool changeAnimationGroup = false, int animationGroupIndex = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
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
		}
	}

	protected void ReturnToDefaultModel()
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

	protected void SetStrengthOverride(FP overrideValue)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected long PlayEffect(string fxAlias, float playbackSpeed = 1f, FP fxPositionY = default(FP), TSVector2 position = default(TSVector2), FP angle = default(FP), float spawnSize = 1f, bool actorScale = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xFB*/;
		}
	}

	protected unsafe long PlaySceneEffect(string fxAlias, float playbackSpeed = 1f, FP fxPositionY = default(FP), TSVector2 position = default(TSVector2), FP angle = default(FP), float spawnSize = 1f)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I4, but got Unknown
		_003F val;
		checked
		{
			val = /*Error near IL_0003: Stack underflow*/- *unchecked((byte*)(nint)/*Error near IL_0001: Stack underflow*/);
		}
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)(int)val;
		_ = -1;
		/*Error near IL_0007: Unknown opcode: 0xCE*/;
	}

	protected long PlayLinkEffect(string fxAlias, bool useCustomSource, LogicEntity source = null, TSVector2 sourcePosition = default(TSVector2), FP sourcePositionY = default(FP), LogicEntity target = null, TSVector2 targetPosition = default(TSVector2), FP targetPositionY = default(FP), bool breakWhenLostSourceOrTarget = true, float spawnSize = 1f, bool actorScale = false, float playbackSpeed = 1f)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected I4, but got Unknown
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
		}
	}

	protected long PlayEarlyWarningEffect(string fxAlias, float duration, FP fxPositionY = default(FP), TSVector2 position = default(TSVector2), FP angle = default(FP), float spawnSize = 1f, bool actorScale = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xFB*/;
		}
	}

	protected void CompleteEarlyWarningEffect(long id)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected void StopEffect(long id, bool stopSubFx = false)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected void BeginRotateEffect(long id, FP rotateAngle, FP rotateSpeed)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 214 (out-of-bounds)*/;
		}
		if ((int)/*Error near IL_0008: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
	}

	protected void StopRotateEffect(long id)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
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
		}
	}

	protected unsafe void ModifyEffectPosition(long id, TSVector2 targetPosition = default(TSVector2), FP targetPositionY = default(FP), LogicEntity targetEntity = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		if (/*Error near IL_000d: Stack underflow*/ > /*Error near IL_000d: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		float num = *(float*)(sbyte)/*Error near IL_000e: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_0011: Stack underflow*/- num;
			/*Error near IL_0011: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0014: Unknown opcode: 0xEA*/;
		}
	}

	public void PlayMovableFx(string fxAlias, Vector3 startPosition, Vector3 targetPosition, float speed, Action finishCallback = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I4, but got Unknown
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

	[IteratorStateMachine(typeof(_003CRotatePlayFXCor_003Ed__241))]
	private IEnumerator RotatePlayFXCor(long fxPlayerToken, FP rotateAngle, FP rotateSpeed)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private PlayFX GetPlayFXByToken(long fxPlayerToken)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 205 (out-of-bounds)*/;
		}
		int num = (int)/*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Not a type handle*/;
	}

	private PlayFX GeneratePlayFX()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	private void ClearFx()
	{
		//Discarded unreachable code: IL_0011
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected I4, but got Unknown
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
		}
	}

	protected bool AreaCheckObstacle(DeterministicShape shape, bool checkHeight = false, HeightClass heightClass = HeightClass.Medium)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected bool QueryPositionReachable(LogicEntity entity, TSVector2 position)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	protected bool CheckTargetIsValid(LogicEntity target)
	{
		/*Error: Invalid field token*/;
	}

	protected bool AreaCheckMonsterTarget(DeterministicShape shape)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected unsafe bool CheckBossTag(LogicEntity target, string tag)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = 8;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected long GetTargetID(LogicEntity actor = null)
	{
		/*Error: Invalid field token*/;
	}

	[Obsolete("请使用GetEntityPosition(LogicEntity entity)")]
	protected TSVector2 GetEntityPositionObsoleted(LogicEntity entity)
	{
		/*Error: Invalid field token*/;
	}

	protected TSVector2 GetEntityPosition(LogicEntity entity)
	{
		/*Error near IL_0001: Unknown opcode: 0xEA*/;
	}

	protected TSVector2 GetEntityForward(LogicEntity entity)
	{
		/*Error: Invalid field token*/;
	}

	protected FP GetEntityAngle(LogicEntity entity)
	{
		/*Error: Invalid field token*/;
	}

	protected unsafe FP GetRotSpdInSkill()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected unsafe TSVector2 GetPosition()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected unsafe TSVector2 GetForward()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected unsafe FP GetRotation()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected LogicEntity GetCurrentPlayer()
	{
		_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Unknown opcode: 0xE6*/;
	}

	protected int GetMonsterSummonNum(LogicEntity actor, int monsterID = -1, bool iAlive = true)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected FP GetDistanceWithTarget(bool calcDistanceWithoutEntityRadius)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected LogicEntity GetAttackTarget(bool isUpToDate = false)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected LogicEntity GetAttackTargetWithOwnerTauntFrom(long ownerId)
	{
		/*Error: Invalid field token*/;
	}

	protected FP CalcAngleBetweenSelfAndAttackTarget(bool isSingleAngle = false)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected TSVector2 GetPlaceHolderPosition(string name)
	{
		/*Error: Invalid field token*/;
	}

	protected int GetMonsterSummonNumWithTeammateIndex(LogicEntity actor, int teammateIndex = -1, bool iAlive = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0003: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Not a type handle*/;
	}

	protected int GetTeammateIdByIndex(int index)
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

	protected unsafe TSVector2 GetAreaEffectPosition(long areaEffectId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) = 0L;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected unsafe TSVector2 GetAreaEffectForward(long areaEffectId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) = 0L;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected AdventureActor GetMonsterCloner()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected I4, but got Unknown
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

	protected unsafe int GetPlayerJobType(AdventureActor player)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected unsafe string GetMonsterTagValue(AdventureActor actor, int tagIndex)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = 8;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected bool EntityInSkill(LogicEntity entity = null, int skillId = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) != 0;
	}

	protected List<LogicEntity> GetTargetsByLogicTag(LogicTagType logicType, string logicStr, List<LogicEntity> entities = null, bool value1 = false, FP value2 = default(FP), string value3 = null, TSVector2 value4 = default(TSVector2))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/!= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (long)unchecked((nint)checked((uint)/*Error near IL_0007: Stack underflow*/));
			_ = (ushort)6;
			/*Error near IL_000b: Not a type handle*/;
		}
	}

	protected List<LogicEntity> GetTargetsFromShape(DeterministicShape shape, List<LogicEntity> entities = null, bool includeSelf = false, LogicEntity targetEntity = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected LogicEntity GetTargetNearOrFar(bool iNear, List<LogicEntity> entities)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		throw /*Error near IL_0003: Stack underflow*/;
	}

	protected List<LogicEntity> GetTargetsByFaction(bool isFriend)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected LogicEntity GetTargetHp(bool hpMin, List<LogicEntity> entities, bool isAbs)
	{
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCF*/;
	}

	protected List<LogicEntity> GetTargetByDataID(int dataID, List<LogicEntity> entities = null)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected LogicEntity GetTargetByID(long id, List<LogicEntity> entities = null)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected unsafe List<LogicEntity> GetTargetByDataIDs(List<int> dataIDs)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		*(int*)(nint)/*Error near IL_0002: Stack underflow*/ = (int)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
		_ = /*Error near IL_0005: Stack underflow*/| checked((ulong)/*Error near IL_0004: Stack underflow*/);
		/*Error near IL_0005: Read out of bounds.*/;
	}

	protected List<LogicEntity> GetTargetByBuffID(int BuffID, List<LogicEntity> entities = null)
	{
		//IL_0002: Expected Obj, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected List<LogicEntity> GetTargetByTeammateIndex(int index, List<LogicEntity> entities = null)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected List<LogicEntity> GetTargetByTeammateIndexes(List<int> indexes, List<LogicEntity> entities = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected I4, but got Unknown
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
		}
	}

	public void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Unknown opcode: 0xF6*/;
		}
	}

	public unsafe void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		if ((int)/*Error near IL_0004: Stack underflow*/ == 0)
		{
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
		_ = (float)(nint)/*Error near IL_005d: Stack underflow*/;
		/*Error near IL_005e: Unknown opcode: 0xEF*/;
	}

	public void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)unchecked((long)checked((ulong)unchecked((long)checked((ulong)/*Error near IL_0007: Stack underflow*/ * 1683995176))));
			/*Error near IL_0011: Invalid branch target*/;
		}
	}

	[IteratorStateMachine(typeof(_003CExecute_003Ed__295))]
	private IEnumerator Execute()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_000b: Stack underflow*/ < /*Error near IL_0005: ldloc 0 (out-of-bounds)*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*OpCode not supported: DebugBreak*/;
		switch (checked((sbyte)/*Error near IL_000d: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		}
	}

	[IteratorStateMachine(typeof(_003CLinkFXAutoFinish_003Ed__296))]
	private IEnumerator LinkFXAutoFinish()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_000b: Stack underflow*/ < /*Error near IL_0005: ldloc 0 (out-of-bounds)*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*OpCode not supported: DebugBreak*/;
		switch (checked((sbyte)/*Error near IL_000d: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		}
	}

	private bool checkTargetLost(GameObject target)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected virtual void OnSkillEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CDoMainLogic_003Ed__299))]
	protected virtual IEnumerator DoMainLogic()
	{
		/*Error: Unknown opcode: 0xB1*/;
	}

	protected virtual void OnSkillDisable()
	{
	}

	protected virtual void OnClear()
	{
	}

	private void onAnticipationEnd(int comboIndex)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	private void onActivationEnd(int comboIndex)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	private void onComboLoop(int comboIndex)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	private void onRecoveryBegin(int comboIndex)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	private void onComboFinish(int comboIndex)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	private void onCustomEvent(int comboIndex, string eventName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected I4, but got Unknown
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
		}
	}

	private void onInterrupt(int comboIndex)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	[IteratorStateMachine(typeof(_003CwaitCustomEvent_003Ed__313))]
	private IEnumerator waitCustomEvent()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_000b: Stack underflow*/ < /*Error near IL_0005: ldloc 0 (out-of-bounds)*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*OpCode not supported: DebugBreak*/;
		switch (checked((sbyte)/*Error near IL_000d: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		}
	}

	private void ClearWaitEvent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected I4, but got Unknown
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

	private void ClearWait()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) < 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private void onAnticipationEnd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
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
		}
	}

	private void onActivationEnd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
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
		}
	}

	private void onComboLoop()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = ~(int)unchecked((long)checked((ulong)/*Error near IL_0007: Stack underflow*/));
			/*Error near IL_0009: Unknown opcode: 0xC0*/;
		}
	}

	private void onRecoveryBegin()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
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
		}
	}

	private void onCustomEvent(string eventName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (int)unchecked((long)checked((ulong)/*Error near IL_0007: Stack underflow*/));
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	private unsafe void onSendSkillTakeEffect()
	{
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	private void onComboFinish()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
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
		}
	}

	private void onInterrupt()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected I4, but got Unknown
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
		}
	}

	private void ClearAttack()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
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

	[IteratorStateMachine(typeof(_003CbeginRotateAngle_003Ed__330))]
	private IEnumerator beginRotateAngle(FP angle, FP rotateSpeed)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[IteratorStateMachine(typeof(_003CbeginLookAtByDir_003Ed__331))]
	private IEnumerator beginLookAtByDir(TSVector2 dir, FP duration = default(FP), FP rotateSpeed = default(FP), bool ignoreActorTimeScale = false, FP stopAngle = default(FP))
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[IteratorStateMachine(typeof(_003CbeginLookAt_003Ed__332))]
	private IEnumerator beginLookAt(LogicEntity target, FP duration = default(FP), FP rotateSpeed = default(FP), bool ignoreActorTimeScale = false, FP stopAngle = default(FP))
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[IteratorStateMachine(typeof(_003CbeginLookAt_003Ed__333))]
	private IEnumerator beginLookAt(FP duration = default(FP), FP rotateSpeed = default(FP), bool ignoreActorTimeScale = false, FP stopAngle = default(FP))
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[IteratorStateMachine(typeof(_003CbeginLookAtByPos_003Ed__334))]
	private IEnumerator beginLookAtByPos(TSVector2 targetPos, FP duration = default(FP), FP rotateSpeed = default(FP), bool ignoreActorTimeScale = false, FP stopAngle = default(FP))
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[IteratorStateMachine(typeof(_003CwaitLookAt_003Ed__335))]
	private IEnumerator waitLookAt(LogicEntity target, FP rotateTime, FP rotateSpd)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void RotateToTargetBySpeed(LogicEntity target, FP rotateSpd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	private void onLookAtComplete()
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

	private void onLookAtClear()
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

	protected void ClearLookAt()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
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

	private void ClearPlayFx()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected I4, but got Unknown
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
		}
	}

	[IteratorStateMachine(typeof(_003Cblink_003Ed__349))]
	protected IEnumerator blink(ComboInputBuffer.ActionKey[] hideKeys, TSVector2 blinkPosition, FP blinkDuration, string blinkBeginFx, FP blinkHideDelay, string blinkFinishFx, FP blinkShowDelay, LogicEntity target = null, ComboInputBuffer.ActionKey[] showKeys = null, int showCombWaitIndex = 1, bool checkPositionReachable = true)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[IteratorStateMachine(typeof(_003CcrossJump_003Ed__351))]
	private IEnumerator crossJump(TSVector2 targetPosition, FP speed, FP duration, bool comboWithAttack = false, bool forbiddenHeight = false, bool checkPositionReachable = true)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private unsafe void onCrossJumpFinish()
	{
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void ClearMove()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
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
		}
	}

	protected void HideSelf()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
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
		}
	}

	protected void ShowSelf()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
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
		}
	}

	private unsafe void MultipleShoot(HitBox.Shape shape, string bulletAlias, AdventureWeapon.MultipleShootStyle multipleShootStyle, bool alignShoot, FP alignShootDelay, int bulletCount, FP duration, TSVector2 shootPosition, FP shootPositionY, TSVector2 multiShootDirection, FP bulletDirectionOffset, AimType aimType, BulletDirectionType bulletDirectionType, TSVector2 targetPosition, LogicEntity target, FP angle, FP width, FP length, FP radius, FP innerRadius, bool isTryShootAgain = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(nint)/*Error near IL_0008: Stack underflow*/);
	}

	private void OnShootBulletBorn(long bulletId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	[IteratorStateMachine(typeof(_003C_waitShoot_003Ed__368))]
	private IEnumerator _waitShoot(BaseNormalStatus normalStatus)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void ShootFinish()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected I4, but got Unknown
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

	private void ClearShoot()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	private void ClearSearchTarget()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	private void StartDynamicTransparent(FP minDistance, FP maxDistance, FP durationTransparent, FP fadeTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	[IteratorStateMachine(typeof(_003CDynamicTransparentCor_003Ed__378))]
	private IEnumerator DynamicTransparentCor(FP minDistance, FP maxDistance, FP durationTransparent, FP fadeTime)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void TransparentFade(FP from, FP to, FP duration)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected I4, but got Unknown
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

	private void StopDynamicTransparent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected I4, but got Unknown
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

	[IteratorStateMachine(typeof(_003CChangeModelScale_003Ed__382))]
	private IEnumerator ChangeModelScale(FP targetValue, FP duration)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected CoroutineNode StartCor(IEnumerator enumerator)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0009: Unknown opcode: 0xF6*/;
	}

	protected void StartCor(ref CoroutineNode cor, IEnumerator enumerator)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = (ulong)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void StopCor(CoroutineNode cor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 223 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xEF*/;
		}
	}

	public void DirectDamage(AdventureActor toActor, int damage, string tag, bool showHud = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	protected virtual void OnActorDied(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
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

	protected virtual void OnActorLostControl(IEvent evt)
	{
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

	protected virtual void OnActorBeControlled(IEvent evt)
	{
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

	protected virtual void OnAnticipationEnd(int comboIndex)
	{
	}

	protected virtual void OnActivationEnd(int comboIndex)
	{
	}

	protected virtual void OnRecoveryBegin(int comboIndex)
	{
	}

	protected virtual void OnComboFinish(int comboIndex)
	{
	}

	protected virtual void OnInterrupt(int comboIndex)
	{
	}

	protected virtual void OnLookAtComplete()
	{
	}

	protected virtual void OnLookAtClear()
	{
	}

	protected void StopLookAt()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected int AreaHit(DeterministicShape shape, HitBox.FeatureFlag hitFlags, HitBox.HitBoxFeatureData hitFeatureData, string hittedEffectPrefabAlias, float fxPositionY, float fxPlaybackSpeed, float fxScale, bool actorScale, TSVector2 fxPosition, TSVector2 fxDirection, HitBox.HurtAnimType hurtAnimType, int hitDamageId, FP damageImmuneDuration)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected I4, but got Unknown
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
		}
	}

	protected virtual void SetListenEvents()
	{
	}

	protected void InitListenEvent(MonsterEventType type, bool active, Action<IEvent> operation)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I4, but got Unknown
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

	protected void InitListenEvent(MonsterEventType type, bool active, Action<IEvent> operation, params int[] eventParams)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected I4, but got Unknown
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

	protected void InitListenEvent(MonsterEventType type, bool active, Action<IEvent> operation, params string[] eventParams)
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

	private void AddListenEvent(MonsterEventParams eventParams)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
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
		case 84:
			/*Error: Invalid branch target*/;
		case 85:
			/*Error: Invalid branch target*/;
		case 86:
			/*Error: Invalid branch target*/;
		case 87:
			/*Error: Invalid branch target*/;
		case 88:
			/*Error: Invalid branch target*/;
		case 89:
			/*Error: Invalid branch target*/;
		case 90:
			/*Error: Invalid branch target*/;
		case 91:
			/*Error: Invalid branch target*/;
		case 92:
			/*Error: Invalid branch target*/;
		case 93:
			/*Error: Invalid branch target*/;
		case 94:
			/*Error: Invalid branch target*/;
		case 95:
			/*Error: Invalid branch target*/;
		case 96:
			/*Error: Invalid branch target*/;
		case 97:
			/*Error: Invalid branch target*/;
		case 98:
			/*Error: Invalid branch target*/;
		case 99:
			/*Error: Invalid branch target*/;
		case 100:
			/*Error: Invalid branch target*/;
		case 101:
			/*Error: Invalid branch target*/;
		case 102:
			/*Error: Invalid branch target*/;
		case 103:
			/*Error: Invalid branch target*/;
		case 104:
			/*Error: Invalid branch target*/;
		case 105:
			/*Error: Invalid branch target*/;
		}
	}

	private void RemoveListenEvent(MonsterEventParams eventParams)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
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
		case 84:
			/*Error: Invalid branch target*/;
		case 85:
			/*Error: Invalid branch target*/;
		case 86:
			/*Error: Invalid branch target*/;
		case 87:
			/*Error: Invalid branch target*/;
		case 88:
			/*Error: Invalid branch target*/;
		case 89:
			/*Error: Invalid branch target*/;
		case 90:
			/*Error: Invalid branch target*/;
		case 91:
			/*Error: Invalid branch target*/;
		case 92:
			/*Error: Invalid branch target*/;
		case 93:
			/*Error: Invalid branch target*/;
		case 94:
			/*Error: Invalid branch target*/;
		case 95:
			/*Error: Invalid branch target*/;
		case 96:
			/*Error: Invalid branch target*/;
		case 97:
			/*Error: Invalid branch target*/;
		case 98:
			/*Error: Invalid branch target*/;
		case 99:
			/*Error: Invalid branch target*/;
		case 100:
			/*Error: Invalid branch target*/;
		case 101:
			/*Error: Invalid branch target*/;
		case 102:
			/*Error: Invalid branch target*/;
		case 103:
			/*Error: Invalid branch target*/;
		case 104:
			/*Error: Invalid branch target*/;
		case 105:
			/*Error: Invalid branch target*/;
		}
	}

	private void RemoveListenEvents()
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

	private unsafe void OnReceiveDamage(IEvent iEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private unsafe void OnDamage(IEvent iEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private void OnMonsterDie(IEvent iEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void OnMonsterSpawnFinish(IEvent iEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private unsafe void OnMonsterBeControlled(IEvent iEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		((IntPtr[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (IntPtr)(*(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnBulletSpawn(IEvent iEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xB0*/;
	}

	private unsafe void OnBulletFinish(IEvent iEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xB1*/;
	}

	private unsafe void OnToughnessStateChange(IEvent iEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void OnHpChange(IEvent iEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (short)(*unchecked((int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private void OnBattleLevelChanged(IEvent iEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	protected void PlayFx(string fxAlias, float playbackSpeed, FP fxPositionY, TSVector2 position, FP angle, Transform parent = null, float spawnSize = 1f, bool actorScale = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I4, but got Unknown
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

	protected unsafe PlayFX PlayFxForNeedStop(string fxAlias, float playbackSpeed, FP fxPositionY, TSVector2 position, FP angle, Transform parent = null, float spawnSize = 1f, bool actorScale = false)
	{
		_ = (double)(uint)(~(*(short*)(nint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0004: Unknown opcode: 0xEA*/;
	}

	protected PlayFX PlayLinkFX(string fxAlias, bool useCustomSource, GameObject source, TSVector sourcePosition, FP sourcePositionY, GameObject targetObj, TSVector targetPosition, FP targetPositionY, bool breakWhenLostSourceOrTarget = true, float spawnSize = 1f, bool actorScale = false, float playbackSpeed = 1f)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected I4, but got Unknown
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
		}
	}

	protected long PlayLoopFx(string fxAlias, float playbackSpeed, Vector3 spawnPosition, Quaternion spawnRotation, Transform parent = null, float spawnSize = 1f)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected I4, but got Unknown
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
		}
	}

	protected void StopLoopFx(long token, bool dontPlaySubFX = false)
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

	public unsafe SkillSimpleBase()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected F4, but got I4
		((float[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (int)(byte)(*(nint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	unsafe static SkillSimpleBase()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xE8*/;
	}
}
