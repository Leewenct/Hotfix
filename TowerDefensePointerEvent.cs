using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerDefensePointerEvent : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
	public struct TowerDefensePointerEventData
	{
		public Vector3 screenPosition;

		public int index;

		public Vector3 worldPosition;
	}

	public Action<TowerDefensePointerEventData> onDrag;

	public Action<TowerDefensePointerEventData> onDown;

	public Action<TowerDefensePointerEventData> onUp;

	public Action<TowerDefensePointerEventData> onClick;

	public Action<TowerDefensePointerEventData> onEnter;

	public Action<TowerDefensePointerEventData> onExit;

	private TowerDefensePointerEventData data;

	public unsafe int index
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0002: Stack underflow*/- *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xAB*/;
		}
	}

	public void Init(int index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public void OnDrag(PointerEventData eventData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = ((Array)/*Error near IL_0007: Stack underflow*/).LongLength;
		/*Error near IL_0007: Unknown opcode: 0xF6*/;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = ((Array)/*Error near IL_0007: Stack underflow*/).LongLength;
		/*Error near IL_0007: Unknown opcode: 0xF6*/;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = ((Array)/*Error near IL_0007: Stack underflow*/).LongLength;
		/*Error near IL_0007: Unknown opcode: 0xF6*/;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = ((Array)/*Error near IL_0007: Stack underflow*/).LongLength;
		/*Error near IL_0007: Unknown opcode: 0xF6*/;
	}

	public void Clear()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public void OnPointerEnter(PointerEventData eventData)
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

	public void OnPointerExit(PointerEventData eventData)
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

	public TowerDefensePointerEvent()
	{
		/*Error: Invalid field token*/;
	}
}
