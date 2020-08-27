using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SuvrunE
{
	public static class HexMetrics
	{
		public const float OuterRadius = 5.1f;
		public const float InnerRadius = OuterRadius * 0.866025404f; // расстоянием от центра до каждого из рёбер является косинус30 * на внешний радиус
		
		public static Vector3[] Corners = {
		new Vector3(0f, 0f, OuterRadius),
		new Vector3(InnerRadius, 0f, 0.5f * OuterRadius),
		new Vector3(InnerRadius, 0f, -0.5f * OuterRadius),
		new Vector3(0f, 0f, -OuterRadius),
		new Vector3(-InnerRadius, 0f, -0.5f * OuterRadius),
		new Vector3(-InnerRadius, 0f, 0.5f * OuterRadius)
	};
	}
}