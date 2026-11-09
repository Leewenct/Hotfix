using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

public class AdventurePlayerIndependentImpulseListener : MonoBehaviour
{
	[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
	[CinemachineImpulseChannelProperty]
	public int m_ChannelMask;

	[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
	public float m_Gain;

	[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
	public bool m_Use2DDistance;

	[Tooltip("This controls the secondary reaction of the listener to the incoming impulse.  The impulse might be for example a sharp shock, and the secondary reaction could be a vibration whose amplitude and duration is controlled by the size of the original impulse.  This allows different listeners to respond in different ways to the same impulse signal.")]
	public ImpulseReaction m_ReactionSettings;

	public Vector3 impulsePosLastFrame
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

	public Quaternion impulseRotLastFrame
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

	private void Reset()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	private void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	public bool DoUpdate(float deltaTime, Transform transform = null)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public AdventurePlayerIndependentImpulseListener()
	{
		/*Error: Invalid field token*/;
	}
}
