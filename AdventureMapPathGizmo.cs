using System;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class AdventureMapPathGizmo : MonoBehaviour
{
	[Serializable]
	public class AdditionalWayPointData
	{
		public List<string> messages;

		[Space]
		public float waitTime;
	}

	[HideInInspector]
	public CinemachineSmoothPath path;

	public AdditionalWayPointData[] additionalWayPointData;

	private void Awake()
	{
		/*Error near IL_0001: Unknown opcode: 0xEA*/;
	}

	public AdventureMapPathGizmo()
	{
		/*Error: Invalid field token*/;
	}
}
