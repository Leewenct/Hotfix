using UnityEngine;

[CreateAssetMenu]
public class HUDNumberConfig : ScriptableObject
{
	[Space]
	public AnimationCurve fadeOutTranslateCurve;

	public float fadeOutTranslateCurveScale;

	public AnimationCurve fadeOutScaleCurve;

	public float fadeOutScaleCurveScale;

	public Gradient fadeOutGradient;

	[Space]
	public float continueTimeMin;

	public float continueTimeMax;

	public AnimationCurve translateCurveX;

	public float translateCurveScaleX;

	public AnimationCurve translateCurveY;

	public float translateCurveScaleY;

	public AnimationCurve scaleCurve;

	public float scaleCurveScale;

	public Gradient texGradient;

	[Header("xStarPos:")]
	public Vector2 starPosXRange;

	[Header("yStarPos:")]
	public Vector2 starPosYRange;

	public HUDNumberConfig()
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
