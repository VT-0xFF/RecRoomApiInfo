using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace ProBuilder.Core
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	internal class ChangelogEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private pb_VersionInfo m_VersionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private string m_ReleaseNotes;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public pb_VersionInfo versionInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xC44460", Offset = "0xC43860", VA = "0x180C44460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string releaseNotes
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xC44450", Offset = "0xC43850", VA = "0x180C44450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x154F80", Offset = "0x154380", VA = "0x180154F80")]
		public ChangelogEntry(pb_VersionInfo version, string releaseNotes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x244FC80", Offset = "0x244F080", VA = "0x18244FC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal class Changelog
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const string k_ChangelogEntryPattern = "(##\\s\\[[0-9]+\\.[0-9]+\\.[0-9]+(\\-[a-zA-Z]+(\\.[0-9]+)*)*\\])";

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string k_VersionInfoPattern = "(?<=##\\s\\[).*(?=\\])";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string k_VersionDatePattern = "(?<=##\\s\\[.*\\]\\s-\\s)[0-9-]*";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private List<ChangelogEntry> m_Entries;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ReadOnlyCollection<ChangelogEntry> entries
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2450090", Offset = "0x244F490", VA = "0x182450090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x244FE30", Offset = "0x244F230", VA = "0x18244FE30")]
		public Changelog(string log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x244FCF0", Offset = "0x244F0F0", VA = "0x18244FCF0")]
		private ChangelogEntry CreateEntry(string version, string contents)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum Status
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Failure,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Canceled,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		NoChange
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class pb_ActionResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public Status status;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public string notification;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static pb_ActionResult Success
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2450270", Offset = "0x244F670", VA = "0x182450270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static pb_ActionResult NoSelection
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2450210", Offset = "0x244F610", VA = "0x182450210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static pb_ActionResult UserCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x24502D0", Offset = "0x244F6D0", VA = "0x1824502D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA8B9E0", Offset = "0xA8ADE0", VA = "0x180A8B9E0")]
		public pb_ActionResult(Status status, string notification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2450330", Offset = "0x244F730", VA = "0x182450330")]
		public static implicit operator bool(pb_ActionResult res)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal enum pb_BezierTangentMode
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Free,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		Aligned,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Mirrored
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal enum pb_BezierTangentDirection
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		In,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Out
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 52)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct pb_BezierPoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Vector3 tangentIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Vector3 tangentOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Quaternion rotation;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2451470", Offset = "0x2450870", VA = "0x182451470")]
		public pb_BezierPoint(Vector3 position, Vector3 tangentIn, Vector3 tangentOut, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2450A00", Offset = "0x244FE00", VA = "0x182450A00")]
		public void EnforceTangentMode(pb_BezierTangentDirection master, pb_BezierTangentMode mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x24512C0", Offset = "0x24506C0", VA = "0x1824512C0")]
		public void SetPosition(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2451430", Offset = "0x2450830", VA = "0x182451430")]
		public void SetTangentIn(Vector3 tangent, pb_BezierTangentMode mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2451450", Offset = "0x2450850", VA = "0x182451450")]
		public void SetTangentOut(Vector3 tangent, pb_BezierTangentMode mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x24511E0", Offset = "0x24505E0", VA = "0x1824511E0")]
		public static Vector3 QuadraticPosition(pb_BezierPoint a, pb_BezierPoint b, float t)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2450350", Offset = "0x244F750", VA = "0x182450350")]
		public static Vector3 CubicPosition(pb_BezierPoint a, pb_BezierPoint b, float t)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2450A10", Offset = "0x244FE10", VA = "0x182450A10")]
		public static Vector3 GetLookDirection(IList<pb_BezierPoint> points, int index, int previous, int next)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	[Cpp2IlInjected.Attribute(Name = "AddComponentMenu", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	internal class pb_BezierShape : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public List<pb_BezierPoint> m_Points;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public bool m_CloseLoop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public float m_Radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int m_Rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int m_Columns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public bool m_Smooth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public bool m_IsEditing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private pb_Object m_Mesh;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public pb_Object mesh
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2451900", Offset = "0x2450D00", VA = "0x182451900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA2170", Offset = "0xA1570", VA = "0x1800A2170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2451880", Offset = "0x2450C80", VA = "0x182451880")]
		public pb_BezierShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x24514B0", Offset = "0x24508B0", VA = "0x1824514B0")]
		public void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x24517B0", Offset = "0x2450BB0", VA = "0x1824517B0")]
		public void Refresh()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class pb_Bounds2D
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private Vector2 _size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private Vector2 _extents;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Vector2 size
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1F90D50", Offset = "0x1F90150", VA = "0x181F90D50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2454050", Offset = "0x2453450", VA = "0x182454050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector2 extents
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xC44CC0", Offset = "0xC440C0", VA = "0x180C44CC0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Vector2[] corners
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2453EA0", Offset = "0x24532A0", VA = "0x182453EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x24533E0", Offset = "0x24527E0", VA = "0x1824533E0")]
		public pb_Bounds2D()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2452C00", Offset = "0x2452000", VA = "0x182452C00")]
		public pb_Bounds2D(Vector2 center, Vector2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x24534A0", Offset = "0x24528A0", VA = "0x1824534A0")]
		public pb_Bounds2D(Vector2[] points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x24532F0", Offset = "0x24526F0", VA = "0x1824532F0")]
		public pb_Bounds2D(Vector2[] points, int[] indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2453580", Offset = "0x2452980", VA = "0x182453580")]
		public pb_Bounds2D(Vector2[] points, pb_Edge[] edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2452D20", Offset = "0x2452120", VA = "0x182452D20")]
		internal pb_Bounds2D(Vector3[] points, pb_Edge[] edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2453B10", Offset = "0x2452F10", VA = "0x182453B10")]
		public pb_Bounds2D(Vector2[] points, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2451BD0", Offset = "0x2450FD0", VA = "0x182451BD0")]
		public bool ContainsPoint(Vector2 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2451C30", Offset = "0x2451030", VA = "0x182451C30")]
		public bool IntersectsLineSegment(Vector2 lineStart, Vector2 lineEnd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2451F80", Offset = "0x2451380", VA = "0x182451F80")]
		public bool Intersects(pb_Bounds2D bounds)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x24520F0", Offset = "0x24514F0", VA = "0x1824520F0")]
		public bool Intersects(Rect rect)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x24526C0", Offset = "0x2451AC0", VA = "0x1824526C0")]
		public void SetWithPoints(IList<Vector2> points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2452250", Offset = "0x2451650", VA = "0x182452250")]
		public void SetWithPoints(IList<Vector2> points, IList<int> indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2451AD0", Offset = "0x2450ED0", VA = "0x182451AD0")]
		public static Vector2 Center(Vector2[] points, int length = -1)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2451990", Offset = "0x2450D90", VA = "0x182451990")]
		public static Vector2 Center(Vector2[] points, int[] indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2452980", Offset = "0x2451D80", VA = "0x182452980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class pb_Clipping
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[Flags]
		private enum OutCode
		{
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			INSIDE = 0,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			LEFT = 1,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			RIGHT = 2,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			BOTTOM = 4,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			TOP = 8
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2454210", Offset = "0x2453610", VA = "0x182454210")]
		private static OutCode ComputeOutCode(Rect rect, float x, float y)
		{
			return default(OutCode);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x24542A0", Offset = "0x24536A0", VA = "0x1824542A0")]
		internal static bool RectContainsLineSegment(Rect rect, float x0, float y0, float x1, float y1)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleComponent]
	internal class pb_ColliderBehaviour : pb_EntityBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xED180", Offset = "0xEC580", VA = "0x1800ED180")]
		public pb_ColliderBehaviour()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2454630", Offset = "0x2453A30", VA = "0x182454630", Slot = "4")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x24548F0", Offset = "0x2453CF0", VA = "0x1824548F0", Slot = "5")]
		public override void OnEnterPlayMode()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class pb_ColorPalette : ScriptableObject, pb_IHasDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Color current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public List<Color> colors;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Color Item
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2455040", Offset = "0x2454440", VA = "0x182455040")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x24550C0", Offset = "0x24544C0", VA = "0x1824550C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2454FF0", Offset = "0x24543F0", VA = "0x182454FF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2454FC0", Offset = "0x24543C0", VA = "0x182454FC0")]
		public pb_ColorPalette()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2454A00", Offset = "0x2453E00", VA = "0x182454A00", Slot = "4")]
		public void SetDefaultValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2454980", Offset = "0x2453D80", VA = "0x182454980")]
		public void CopyTo(pb_ColorPalette target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x12A6E0", Offset = "0x129AE0", VA = "0x18012A6E0")]
		public static implicit operator List<Color>(pb_ColorPalette palette)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class pb_HsvColor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public float h;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public float s;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float v;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1F545A0", Offset = "0x1F539A0", VA = "0x181F545A0")]
		public pb_HsvColor(float h, float s, float v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2472A10", Offset = "0x2471E10", VA = "0x182472A10")]
		public pb_HsvColor(float h, float s, float v, float sv_modifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x24728B0", Offset = "0x2471CB0", VA = "0x1824728B0")]
		public static pb_HsvColor FromRGB(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2472960", Offset = "0x2471D60", VA = "0x182472960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2472910", Offset = "0x2471D10", VA = "0x182472910")]
		public float SqrDistance(pb_HsvColor InColor)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class pb_XYZ_Color
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float z;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1F545A0", Offset = "0x1F539A0", VA = "0x181F545A0")]
		public pb_XYZ_Color(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1F54490", Offset = "0x1F53890", VA = "0x181F54490")]
		public static pb_XYZ_Color FromRGB(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1F54400", Offset = "0x1F53800", VA = "0x181F54400")]
		public static pb_XYZ_Color FromRGB(float R, float G, float B)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1F544F0", Offset = "0x1F538F0", VA = "0x181F544F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class pb_CIE_Lab_Color
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float L;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float b;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1F545A0", Offset = "0x1F539A0", VA = "0x181F545A0")]
		public pb_CIE_Lab_Color(float L, float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2454100", Offset = "0x2453500", VA = "0x182454100")]
		public static pb_CIE_Lab_Color FromXYZ(pb_XYZ_Color xyz)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2454090", Offset = "0x2453490", VA = "0x182454090")]
		public static pb_CIE_Lab_Color FromRGB(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2454160", Offset = "0x2453560", VA = "0x182454160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class pb_ColorUtil
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly Dictionary<string, pb_CIE_Lab_Color> ColorNameLookup;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x246B6D0", Offset = "0x246AAD0", VA = "0x18246B6D0")]
		private static bool approx(float lhs, float rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2455910", Offset = "0x2454D10", VA = "0x182455910")]
		public static pb_XYZ_Color RGBToXYZ(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2455980", Offset = "0x2454D80", VA = "0x182455980")]
		public static pb_XYZ_Color RGBToXYZ(float r, float g, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2455E20", Offset = "0x2455220", VA = "0x182455E20")]
		public static pb_CIE_Lab_Color XYZToCIE_Lab(pb_XYZ_Color xyz)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x24551C0", Offset = "0x24545C0", VA = "0x1824551C0")]
		public static float DeltaE(pb_CIE_Lab_Color lhs, pb_CIE_Lab_Color rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2455570", Offset = "0x2454970", VA = "0x182455570")]
		public static Color HSVtoRGB(pb_HsvColor hsv)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2455770", Offset = "0x2454B70", VA = "0x182455770")]
		public static Color HSVtoRGB(float h, float s, float v)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2455B90", Offset = "0x2454F90", VA = "0x182455B90")]
		public static pb_HsvColor RGBtoHSV(Color color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x24552C0", Offset = "0x24546C0", VA = "0x1824552C0")]
		public static string GetColorName(Color InColor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2455130", Offset = "0x2454530", VA = "0x182455130")]
		private static pb_CIE_Lab_Color CIELabFromRGB(float R, float G, float B, float Scale)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class pb_Constant
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string PRODUCT_NAME = "ProBuilder";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal const HideFlags k_EditorHideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal const float k_MaxPointDistanceFromControl = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		internal const char DEGREE_SYMBOL = '°';

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		internal const char CMD_SUPER = '⌘';

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		internal const char CMD_SHIFT = '⇧';

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		internal const char CMD_OPTION = '⌥';

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		internal const char CMD_ALT = '⎇';

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		internal const char CMD_DELETE = '⌫';

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		internal const string pbDefaultEditLevel = "pbDefaultEditLevel";

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		internal const string pbDefaultSelectionMode = "pbDefaultSelectionMode";

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		internal const string pbHandleAlignment = "pbHandleAlignment";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal const string pbVertexColorTool = "pbVertexColorTool";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal const string pbToolbarLocation = "pbToolbarLocation";

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal const string pbDefaultEntity = "pbDefaultEntity";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal const string pbExtrudeMethod = "pbExtrudeMethod";

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal const string pbDefaultStaticFlags = "pbDefaultStaticFlags";

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal const string pbSelectedFaceColor = "pbDefaultFaceColor";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal const string pbWireframeColor = "pbDefaultEdgeColor";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal const string pbUnselectedEdgeColor = "pbUnselectedEdgeColor";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal const string pbSelectedEdgeColor = "pbSelectedEdgeColor";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal const string pbSelectedVertexColor = "pbDefaultSelectedVertexColor";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal const string pbUnselectedVertexColor = "pbDefaultVertexColor";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal const string pbPreselectionColor = "pbPreselectionColor";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal const string pbDefaultOpenInDockableWindow = "pbDefaultOpenInDockableWindow";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal const string pbEditorPrefVersion = "pbEditorPrefVersion";

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal const string pbEditorShortcutsVersion = "pbEditorShortcutsVersion";

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal const string pbDefaultCollider = "pbDefaultCollider";

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal const string pbForceConvex = "pbForceConvex";

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal const string pbVertexColorPrefs = "pbVertexColorPrefs";

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal const string pbShowEditorNotifications = "pbShowEditorNotifications";

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Obsolete]
		internal const string pbDragCheckLimit = "pbDragCheckLimit";

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal const string pbForceVertexPivot = "pbForceVertexPivot";

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		internal const string pbForceGridPivot = "pbForceGridPivot";

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal const string pbManifoldEdgeExtrusion = "pbManifoldEdgeExtrusion";

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal const string pbPerimeterEdgeBridgeOnly = "pbPerimeterEdgeBridgeOnly";

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		internal const string pbPBOSelectionOnly = "pbPBOSelectionOnly";

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal const string pbCloseShapeWindow = "pbCloseShapeWindow";

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal const string pbUVEditorFloating = "pbUVEditorFloating";

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		internal const string pbUVMaterialPreview = "pbUVMaterialPreview";

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Obsolete]
		internal const string pbShowSceneToolbar = "pbShowSceneToolbar";

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		internal const string pbNormalizeUVsOnPlanarProjection = "pbNormalizeUVsOnPlanarProjection";

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		internal const string pbStripProBuilderOnBuild = "pbStripProBuilderOnBuild";

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		internal const string pbDisableAutoUV2Generation = "pbDisableAutoUV2Generation";

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		internal const string pbShowSceneInfo = "pbShowSceneInfo";

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		internal const string pbEnableBackfaceSelection = "pbEnableBackfaceSelection";

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		internal const string pbVertexPaletteDockable = "pbVertexPaletteDockable";

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal const string pbExtrudeAsGroup = "pbExtrudeAsGroup";

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		internal const string pbUniqueModeShortcuts = "pbUniqueModeShortcuts";

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		internal const string pbMaterialEditorFloating = "pbMaterialEditorFloating";

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal const string pbShapeWindowFloating = "pbShapeWindowFloating";

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal const string pbIconGUI = "pbIconGUI";

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		internal const string pbShiftOnlyTooltips = "pbShiftOnlyTooltips";

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Obsolete]
		internal const string pbDrawAxisLines = "pbDrawAxisLines";

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		internal const string pbCollapseVertexToFirst = "pbCollapseVertexToFirst";

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		internal const string pbMeshesAreAssets = "pbMeshesAreAssets";

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		internal const string pbElementSelectIsHamFisted = "pbElementSelectIsHamFisted";

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		internal const string pbFillHoleSelectsEntirePath = "pbFillHoleSelectsEntirePath";

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		internal const string pbDetachToNewObject = "pbDetachToNewObject";

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Obsolete]
		internal const string pbPreserveFaces = "pbPreserveFaces";

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Obsolete]
		internal const string pbDragSelectWholeElement = "pbDragSelectWholeElement";

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		internal const string pbRectSelectMode = "pbRectSelectMode";

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal const string pbDragSelectMode = "pbDragSelectMode";

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		internal const string pbShadowCastingMode = "pbShadowCastingMode";

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal const string pbEnableExperimental = "pbEnableExperimental";

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		internal const string pbCheckForProBuilderUpdates = "pbCheckForProBuilderUpdates";

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		internal const string pbManageLightmappingStaticFlag = "pbManageLightmappingStaticFlag";

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		internal const string pbShowMissingLightmapUvWarning = "pb_Lightmapping::showMissingLightmapUvWarning";

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		internal const string pbSelectedFaceDither = "pbSelectedFaceDither";

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		internal const string pbUseUnityColors = "pbUseUnityColors";

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		internal const string pbVertexHandleSize = "pbVertexHandleSize";

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		internal const string pbUVGridSnapValue = "pbUVGridSnapValue";

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		internal const string pbUVWeldDistance = "pbUVWeldDistance";

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		internal const string pbLineHandleSize = "pbLineHandleSize";

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		internal const string pbWireframeSize = "pbWireframeSize";

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		internal const string pbWeldDistance = "pbWeldDistance";

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		internal const string pbExtrudeDistance = "pbExtrudeDistance";

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		internal const string pbBevelAmount = "pbBevelAmount";

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		internal const string pbEdgeSubdivisions = "pbEdgeSubdivisions";

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		internal const string pbDefaultShortcuts = "pbDefaultShortcuts";

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		internal const string pbDefaultMaterial = "pbDefaultMaterial";

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal const string pbCurrentMaterialPalette = "pbCurrentMaterialPalette";

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal const string pbGrowSelectionUsingAngle = "pbGrowSelectionUsingAngle";

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal const string pbGrowSelectionAngle = "pbGrowSelectionAngle";

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal const string pbGrowSelectionAngleIterative = "pbGrowSelectionAngleIterative";

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal const string pbShowDetail = "pbShowDetail";

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		internal const string pbShowOccluder = "pbShowOccluder";

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		internal const string pbShowMover = "pbShowMover";

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		internal const string pbShowCollider = "pbShowCollider";

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal const string pbShowTrigger = "pbShowTrigger";

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal const string pbShowNoDraw = "pbShowNoDraw";

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		internal static readonly Rect RectZero;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		internal static Color ProBuilderBlue;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		internal static Color ProBuilderLightGray;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		internal static Color ProBuilderDarkGray;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public const int MENU_ABOUT = 0;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public const int MENU_EDITOR = 100;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public const int MENU_SELECTION = 200;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public const int MENU_GEOMETRY = 200;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public const int MENU_ACTIONS = 300;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public const int MENU_MATERIAL_COLORS = 400;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public const int MENU_VERTEX_COLORS = 400;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public const int MENU_REPAIR = 600;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public const int MENU_MISC = 600;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public const int MENU_EXPORT = 800;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public static Material DefaultMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x246B8D0", Offset = "0x246ACD0", VA = "0x18246B8D0")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct pb_Edge : IEquatable<pb_Edge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int y;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly pb_Edge Empty;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC0", Offset = "0x8D2C0", VA = "0x18008DEC0")]
		public pb_Edge(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x246D3C0", Offset = "0x246C7C0", VA = "0x18246D3C0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x246D6F0", Offset = "0x246CAF0", VA = "0x18246D6F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x246D330", Offset = "0x246C730", VA = "0x18246D330", Slot = "4")]
		public bool Equals(pb_Edge edge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x246D230", Offset = "0x246C630", VA = "0x18246D230", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x246D390", Offset = "0x246C790", VA = "0x18246D390", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x246D770", Offset = "0x246CB70", VA = "0x18246D770")]
		public static pb_Edge operator +(pb_Edge a, pb_Edge b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x246D860", Offset = "0x246CC60", VA = "0x18246D860")]
		public static pb_Edge operator -(pb_Edge a, pb_Edge b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x246D750", Offset = "0x246CB50", VA = "0x18246D750")]
		public static pb_Edge operator +(pb_Edge a, int b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x246D880", Offset = "0x246CC80", VA = "0x18246D880")]
		public static pb_Edge operator -(pb_Edge a, int b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x246D790", Offset = "0x246CB90", VA = "0x18246D790")]
		public static bool operator ==(pb_Edge a, pb_Edge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x246D7C0", Offset = "0x246CBC0", VA = "0x18246D7C0")]
		public static bool operator !=(pb_Edge a, pb_Edge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x246D3E0", Offset = "0x246C7E0", VA = "0x18246D3E0")]
		public int[] ToArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x246D160", Offset = "0x246C560", VA = "0x18246D160")]
		public bool Equals(pb_Edge b, Dictionary<int, int> lookup)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x246D070", Offset = "0x246C470", VA = "0x18246D070")]
		public bool Contains(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x246CF10", Offset = "0x246C310", VA = "0x18246CF10")]
		public bool Contains(pb_Edge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x246CF40", Offset = "0x246C340", VA = "0x18246CF40")]
		internal bool Contains(int a, pb_IntArray[] sharedIndices)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[Obsolete]
	internal class pb_EdgeConnection : IEquatable<pb_EdgeConnection>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public pb_Face face;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public List<pb_Edge> edges;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool isValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x246BCD0", Offset = "0x246B0D0", VA = "0x18246BCD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x154F80", Offset = "0x154380", VA = "0x180154F80")]
		public pb_EdgeConnection(pb_Face face, List<pb_Edge> edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x246BB30", Offset = "0x246AF30", VA = "0x18246BB30", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F4E990", Offset = "0x1F4DD90", VA = "0x181F4E990", Slot = "4")]
		public bool Equals(pb_EdgeConnection fc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x365230", Offset = "0x364630", VA = "0x180365230")]
		public static explicit operator pb_Face(pb_EdgeConnection fc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x15515C0", Offset = "0x15509C0", VA = "0x1815515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x246BC40", Offset = "0x246B040", VA = "0x18246BC40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x246B8E0", Offset = "0x246ACE0", VA = "0x18246B8E0")]
		public static List<int> AllTriangles(List<pb_EdgeConnection> ec)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class pb_EdgeExtension
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x246C1F0", Offset = "0x246B5F0", VA = "0x18246C1F0")]
		public static pb_Edge[] GetUniversalEdges(pb_Edge[] edges, Dictionary<int, int> sharedIndicesLookup)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x246C320", Offset = "0x246B720", VA = "0x18246C320")]
		public static pb_Edge[] GetUniversalEdges(pb_Edge[] edges, pb_IntArray[] sharedIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x246C130", Offset = "0x246B530", VA = "0x18246C130")]
		internal static pb_Edge GetLocalEdgeFast(pb_Edge edge, pb_IntArray[] sharedIndices)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x246C590", Offset = "0x246B990", VA = "0x18246C590")]
		public static bool ValidateEdge(pb_Object pb, pb_Edge edge, out pb_Tuple<pb_Face, pb_Edge> validEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x246BD20", Offset = "0x246B120", VA = "0x18246BD20")]
		internal static pb_Edge[] AllEdges(pb_Face[] faces)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x246C0B0", Offset = "0x246B4B0", VA = "0x18246C0B0")]
		internal static bool Contains(this pb_Edge[] edges, pb_Edge edge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x246C010", Offset = "0x246B410", VA = "0x18246C010")]
		internal static bool Contains(this pb_Edge[] edges, int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x246C460", Offset = "0x246B860", VA = "0x18246C460")]
		internal static int IndexOf(this IList<pb_Edge> edges, pb_Edge edge, Dictionary<int, int> lookup)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x246BE00", Offset = "0x246B200", VA = "0x18246BE00")]
		internal static int[] AllTriangles(this pb_Edge[] edges)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x246BF20", Offset = "0x246B320", VA = "0x18246BF20")]
		internal static List<int> AllTriangles(this List<pb_Edge> edges)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class pb_EdgeLookup : IEquatable<pb_EdgeLookup>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public pb_Edge local;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public pb_Edge common;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x246CED0", Offset = "0x246C2D0", VA = "0x18246CED0")]
		public pb_EdgeLookup(pb_Edge common, pb_Edge local)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x246CE60", Offset = "0x246C260", VA = "0x18246CE60")]
		public pb_EdgeLookup(int cx, int cy, int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x246C910", Offset = "0x246BD10", VA = "0x18246C910", Slot = "4")]
		public bool Equals(pb_EdgeLookup b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x246C9D0", Offset = "0x246BDD0", VA = "0x18246C9D0", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x246CDA0", Offset = "0x246C1A0", VA = "0x18246CDA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x246CDD0", Offset = "0x246C1D0", VA = "0x18246CDD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x246CCE0", Offset = "0x246C0E0", VA = "0x18246CCE0")]
		public static IEnumerable<pb_EdgeLookup> GetEdgeLookup(IEnumerable<pb_Edge> edges, Dictionary<int, int> lookup)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x246CAA0", Offset = "0x246BEA0", VA = "0x18246CAA0")]
		public static HashSet<pb_EdgeLookup> GetEdgeLookupHashSet(IEnumerable<pb_Edge> edges, Dictionary<int, int> lookup)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[DisallowMultipleComponent]
	[Cpp2IlInjected.Attribute(Name = "AddComponentMenu", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class pb_Entity : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		[HideInInspector]
		private EntityType _entityType;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public EntityType entityType
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xC44AB0", Offset = "0xC43EB0", VA = "0x180C44AB0")]
			get
			{
				return default(EntityType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x70760", Offset = "0x6FB60", VA = "0x180070760")]
		public pb_Entity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x246DA00", Offset = "0x246CE00", VA = "0x18246DA00")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8DE30", Offset = "0x8D230", VA = "0x18008DE30")]
		public void SetEntity(EntityType t)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class pb_EntityBehaviour : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Cpp2IlInjected.Attribute(Name = "TooltipAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public bool manageVisibility;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xED180", Offset = "0xEC580", VA = "0x1800ED180")]
		protected pb_EntityBehaviour()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void OnEnterPlayMode();

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x246D8A0", Offset = "0x246CCA0", VA = "0x18246D8A0")]
		protected void SetMaterial(Material material)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Flags]
	public enum SelectMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		Vertex = 0,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		Edge = 1,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		Face = 2
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[Flags]
	public enum EditLevel
	{
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		Top = 0,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		Geometry = 1,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		Texture = 2,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		Plugin = 4
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum EntityType
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		Detail,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		Occluder,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		Trigger,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		Collider,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		Mover
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal enum ColliderType
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		BoxCollider,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		MeshCollider
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public enum ProjectionAxis
	{
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		X,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		Z,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		X_Negative,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		Y_Negative,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		Z_Negative
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Obsolete]
	internal enum Shape
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		Cube,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Stair,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Prism,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		Cylinder,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		Plane,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		Door,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		Pipe,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Cone,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Sprite,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Arch,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		Icosahedron,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Torus,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Custom
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum Axis
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Right,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Up,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Down,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Forward,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Backward
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum WindingOrder
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		Clockwise,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		CounterClockwise
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum SortMethod
	{
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Clockwise,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		CounterClockwise
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[Obsolete]
	public enum Culling
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Back,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Front,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		FrontBack
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[Flags]
	public enum pb_Culling
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Back = 1,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Front = 2,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		FrontBack = 3
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum pb_RectSelectMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		Partial,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		Complete
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum MeshRebuildReason
	{
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Null,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		InstanceIDMismatch,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		Lightmap,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		None
	}
	[StructLayout((LayoutKind)3, Size = 2)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[Flags]
	public enum AttributeType : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Position = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		UV0 = 2,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		UV1 = 4,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		UV2 = 8,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		UV3 = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Color = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		Normal = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Tangent = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		All = 0xFF
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal enum IndexFormat
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Local,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Common,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Both
	}
	[StructLayout((LayoutKind)3, Size = 2)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[Flags]
	public enum RefreshMask : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		All = 0xFF,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		UV = 1,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		Colors = 2,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Normals = 4,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		Tangents = 8,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		Collisions = 0x10
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum ExtrudeMethod
	{
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		IndividualFaces,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		VertexNormal,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		FaceNormal
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class pb_Face
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[SerializeField]
		private int[] _indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		private int[] _distinctIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private pb_Edge[] _edges;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[SerializeField]
		private int _smoothingGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[SerializeField]
		private pb_UV _uv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeField]
		private Material _mat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public bool manualUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		internal int elementGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int textureGroup;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int[] indices
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xC44460", Offset = "0xC43860", VA = "0x180C44460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int[] distinctIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2470170", Offset = "0x246F570", VA = "0x182470170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public pb_Edge[] edges
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2470190", Offset = "0x246F590", VA = "0x182470190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int smoothingGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC44CB0", Offset = "0xC440B0", VA = "0x180C44CB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1D0660", Offset = "0x1CFA60", VA = "0x1801D0660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material material
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xC45A90", Offset = "0xC44E90", VA = "0x180C45A90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA2170", Offset = "0xA1570", VA = "0x1800A2170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public pb_UV uv
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xC4E290", Offset = "0xC4D690", VA = "0x180C4E290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7BA10", Offset = "0x7AE10", VA = "0x18007BA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x17B1160", Offset = "0x17B0560", VA = "0x1817B1160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x24700A0", Offset = "0x246F4A0", VA = "0x1824700A0")]
		public pb_Face()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2470000", Offset = "0x246F400", VA = "0x182470000")]
		public pb_Face(int[] i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x24700B0", Offset = "0x246F4B0", VA = "0x1824700B0")]
		public pb_Face(int[] i, Material m, pb_UV u, int smoothingGroup, int textureGroup, int elementGroup, bool manualUV)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x246FEE0", Offset = "0x246F2E0", VA = "0x18246FEE0")]
		public pb_Face(pb_Face face)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x246E690", Offset = "0x246DA90", VA = "0x18246E690")]
		public void CopyFrom(pb_Face other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x246F170", Offset = "0x246E570", VA = "0x18246F170")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x246E790", Offset = "0x246DB90", VA = "0x18246E790")]
		public pb_Edge[] GetAllEdges()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x246F1F0", Offset = "0x246E5F0", VA = "0x18246F1F0")]
		public void SetIndices(int[] i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x246F400", Offset = "0x246E800", VA = "0x18246F400")]
		public void ShiftIndices(int offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x246F470", Offset = "0x246E870", VA = "0x18246F470")]
		public int SmallestIndexValue()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x246F220", Offset = "0x246E620", VA = "0x18246F220")]
		public void ShiftIndicesToZero()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x246F1C0", Offset = "0x246E5C0", VA = "0x18246F1C0")]
		public void ReverseIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x246F1A0", Offset = "0x246E5A0", VA = "0x18246F1A0")]
		public void RebuildCaches()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x246E2F0", Offset = "0x246D6F0", VA = "0x18246E2F0")]
		private pb_Edge[] CacheEdges()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x246E250", Offset = "0x246D650", VA = "0x18246E250")]
		private int[] CacheDistinctIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x246E540", Offset = "0x246D940", VA = "0x18246E540")]
		public bool Contains(int[] triangle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x246E170", Offset = "0x246D570", VA = "0x18246E170")]
		internal static int[] AllTriangles(pb_Face[] q)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x246F500", Offset = "0x246E900", VA = "0x18246F500")]
		public MeshTopology ToQuadOrTriangles(out int[] quadOrTris)
		{
			return default(MeshTopology);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x246F610", Offset = "0x246EA10", VA = "0x18246F610")]
		public int[] ToQuad()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x246F640", Offset = "0x246EA40", VA = "0x18246F640")]
		public bool ToQuad(out int[] quad)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x246E9D0", Offset = "0x246DDD0", VA = "0x18246E9D0")]
		public static int GetMeshIndices(pb_Face[] faces, out pb_Submesh[] submeshes, MeshTopology preferredTopology = MeshTopology.Triangles)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x246FCD0", Offset = "0x246F0D0", VA = "0x18246FCD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal class pb_FaceRebuildData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public pb_Face face;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public List<pb_Vertex> vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public List<int> sharedIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public List<int> sharedIndicesUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private int _appliedOffset;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x246E160", Offset = "0x246D560", VA = "0x18246E160")]
		public pb_FaceRebuildData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1560BC0", Offset = "0x155FFC0", VA = "0x181560BC0")]
		public int Offset()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x246E0D0", Offset = "0x246D4D0", VA = "0x18246E0D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x246DAB0", Offset = "0x246CEB0", VA = "0x18246DAB0")]
		public static void Apply(IEnumerable<pb_FaceRebuildData> newFaces, pb_Object pb, [Optional] List<pb_Vertex> vertices, [Optional] List<pb_Face> faces, [Optional] Dictionary<int, int> lookup, [Optional] Dictionary<int, int> lookupUV)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x246DC70", Offset = "0x246D070", VA = "0x18246DC70")]
		public static void Apply(IEnumerable<pb_FaceRebuildData> newFaces, List<pb_Vertex> vertices, List<pb_Face> faces, Dictionary<int, int> sharedIndices, [Optional] Dictionary<int, int> sharedIndicesUV)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal class pb_HandleConstraint2D
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int y;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static readonly pb_HandleConstraint2D None;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x132470", Offset = "0x131870", VA = "0x180132470")]
		public pb_HandleConstraint2D(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2470390", Offset = "0x246F790", VA = "0x182470390")]
		public pb_HandleConstraint2D Inverse()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2470410", Offset = "0x246F810", VA = "0x182470410")]
		public Vector2 Mask(Vector2 v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2470340", Offset = "0x246F740", VA = "0x182470340")]
		public Vector2 InverseMask(Vector2 v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2470710", Offset = "0x246FB10", VA = "0x182470710")]
		public static bool operator ==(pb_HandleConstraint2D a, pb_HandleConstraint2D b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2470750", Offset = "0x246FB50", VA = "0x182470750")]
		public static bool operator !=(pb_HandleConstraint2D a, pb_HandleConstraint2D b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x15515C0", Offset = "0x15509C0", VA = "0x1815515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x24701B0", Offset = "0x246F5B0", VA = "0x1824701B0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2470440", Offset = "0x246F840", VA = "0x182470440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class pb_HandleUtility
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private const float MAX_EDGE_SELECT_DISTANCE = 20f;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x24724D0", Offset = "0x24718D0", VA = "0x1824724D0")]
		public static Vector3 ScreenToGuiPoint(this Camera camera, Vector3 point, float pixelsPerPoint)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2471950", Offset = "0x2470D50", VA = "0x182471950")]
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out pb_RaycastHit hit, [Optional] HashSet<pb_Face> ignore)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2470790", Offset = "0x246FB90", VA = "0x182470790")]
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out pb_RaycastHit hit, float distance, pb_Culling cullingMode, [Optional] HashSet<pb_Face> ignore)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2471050", Offset = "0x2470450", VA = "0x182471050")]
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out List<pb_RaycastHit> hits, float distance, pb_Culling cullingMode, [Optional] HashSet<pb_Face> ignore)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x24719B0", Offset = "0x2470DB0", VA = "0x1824719B0")]
		public static Ray InverseTransformRay(this Transform transform, Ray InWorldRay)
		{
			return default(Ray);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2472560", Offset = "0x2471960", VA = "0x182472560")]
		public static bool WorldRaycast(Ray InWorldRay, Transform transform, Vector3[] vertices, int[] triangles, out pb_RaycastHit hit, float distance = float.PositiveInfinity, pb_Culling cullingMode = pb_Culling.Front)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2471F60", Offset = "0x2471360", VA = "0x182471F60")]
		public static bool MeshRaycast(Ray InRay, Vector3[] vertices, int[] triangles, out pb_RaycastHit hit, float distance = float.PositiveInfinity, pb_Culling cullingMode = pb_Culling.Front)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2472260", Offset = "0x2471660", VA = "0x182472260")]
		internal static bool PointIsOccluded(Camera cam, pb_Object pb, Vector3 worldPoint)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2471CC0", Offset = "0x24710C0", VA = "0x182471CC0")]
		internal static bool IsOccluded(Camera cam, pb_Object pb, pb_Face face)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal class ProGridsNoSnapAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xFE1E0", Offset = "0xFD5E0", VA = "0x1800FE1E0")]
		public ProGridsNoSnapAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class ProGridsConditionalSnapAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xFE1E0", Offset = "0xFD5E0", VA = "0x1800FE1E0")]
		public ProGridsConditionalSnapAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal interface pb_IHasDefault
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetDefaultValues();
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class pb_IntArray
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int[] array;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x17B1160", Offset = "0x17B0560", VA = "0x1817B1160")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x2475320", Offset = "0x2474720", VA = "0x182475320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xB6BAA0", Offset = "0xB6AEA0", VA = "0x180B6BAA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9A670", Offset = "0x99A70", VA = "0x18009A670")]
		public pb_IntArray(int[] intArray)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2475210", Offset = "0x2474610", VA = "0x182475210")]
		public pb_IntArray(pb_IntArray intArray)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2475160", Offset = "0x2474560", VA = "0x182475160")]
		internal List<int> ToList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x365230", Offset = "0x364630", VA = "0x180365230")]
		public static implicit operator int[](pb_IntArray intArr)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x24752C0", Offset = "0x24746C0", VA = "0x1824752C0")]
		public static explicit operator pb_IntArray(int[] arr)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x24751C0", Offset = "0x24745C0", VA = "0x1824751C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2475050", Offset = "0x2474450", VA = "0x182475050")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2475070", Offset = "0x2474470", VA = "0x182475070")]
		public static void RemoveEmptyOrNull(ref pb_IntArray[] val)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class pb_IntArrayUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2474220", Offset = "0x2473620", VA = "0x182474220")]
		public static int[][] ToArray(this pb_IntArray[] val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2474340", Offset = "0x2473740", VA = "0x182474340")]
		public static Dictionary<int, int> ToDictionary(this pb_IntArray[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2474750", Offset = "0x2473B50", VA = "0x182474750")]
		public static pb_IntArray[] ToSharedIndices(this IEnumerable<KeyValuePair<int, int>> lookup)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2474600", Offset = "0x2473A00", VA = "0x182474600")]
		public static pb_IntArray[] ToPbIntArray(this int[][] val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2474490", Offset = "0x2473890", VA = "0x182474490")]
		public static pb_IntArray[] ToPbIntArray(this List<List<int>> val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x24735C0", Offset = "0x24729C0", VA = "0x1824735C0")]
		public static int IndexOf(this pb_IntArray[] intArray, int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2472CC0", Offset = "0x24720C0", VA = "0x182472CC0")]
		public static List<int> AllIndicesWithValues(this pb_IntArray[] pbIntArr, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2472DE0", Offset = "0x24721E0", VA = "0x182472DE0")]
		public static List<int> AllIndicesWithValues(this pb_IntArray[] pbIntArr, Dictionary<int, int> lookup, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2474C90", Offset = "0x2474090", VA = "0x182474C90")]
		internal static List<int> UniqueIndicesWithValues(this pb_IntArray[] pbIntArr, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x24734D0", Offset = "0x24728D0", VA = "0x1824734D0")]
		internal static HashSet<int> GetCommonIndices(this pb_IntArray[] pbIntArr, IEnumerable<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x24732E0", Offset = "0x24726E0", VA = "0x1824732E0")]
		internal static HashSet<int> GetCommonIndices(Dictionary<int, int> lookup, IEnumerable<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2473500", Offset = "0x2472900", VA = "0x182473500")]
		[Obsolete]
		internal static IEnumerable<int> GetIndicesWithCommon(this pb_IntArray[] pbIntArr, IEnumerable<int> common)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2472EF0", Offset = "0x24722F0", VA = "0x182472EF0")]
		public static pb_IntArray[] ExtractSharedIndices(Vector3[] v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2473890", Offset = "0x2472C90", VA = "0x182473890")]
		internal static int MergeSharedIndices(ref pb_IntArray[] sharedIndices, int[] indices)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2473680", Offset = "0x2472A80", VA = "0x182473680")]
		internal static void MergeSharedIndices(ref pb_IntArray[] sharedIndices, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2472B80", Offset = "0x2471F80", VA = "0x182472B80")]
		internal static int AddValueAtIndex(ref pb_IntArray[] sharedIndices, int sharedIndex, int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2472A80", Offset = "0x2471E80", VA = "0x182472A80")]
		internal static int AddRangeAtIndex(ref pb_IntArray[] sharedIndices, int sharedIndex, int[] indices)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x24740A0", Offset = "0x24734A0", VA = "0x1824740A0")]
		internal static void RemoveValues(ref pb_IntArray[] sharedIndices, int[] remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2473C90", Offset = "0x2473090", VA = "0x182473C90")]
		internal static void RemoveValuesAndShift(ref pb_IntArray[] sharedIndices, IEnumerable<int> remove)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 12)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal struct pb_IntVec3 : IEquatable<pb_IntVec3>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Vector3 vec;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public const float RESOLUTION = 1000f;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float x
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xC54550", Offset = "0xC53950", VA = "0x180C54550")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float y
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1484040", Offset = "0x1483440", VA = "0x181484040")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float z
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xC54570", Offset = "0xC53970", VA = "0x180C54570")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x14858C0", Offset = "0x1484CC0", VA = "0x1814858C0")]
		public pb_IntVec3(Vector3 vector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x24759E0", Offset = "0x2474DE0", VA = "0x1824759E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2475A90", Offset = "0x2474E90", VA = "0x182475A90")]
		public static bool operator ==(pb_IntVec3 a, pb_IntVec3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2475AE0", Offset = "0x2474EE0", VA = "0x182475AE0")]
		public static bool operator !=(pb_IntVec3 a, pb_IntVec3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2475760", Offset = "0x2474B60", VA = "0x182475760", Slot = "4")]
		public bool Equals(pb_IntVec3 p)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2475950", Offset = "0x2474D50", VA = "0x182475950")]
		public bool Equals(Vector3 p)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2475480", Offset = "0x2474880", VA = "0x182475480", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x24759B0", Offset = "0x2474DB0", VA = "0x1824759B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2475B30", Offset = "0x2474F30", VA = "0x182475B30")]
		private static int round(float v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2475AC0", Offset = "0x2474EC0", VA = "0x182475AC0")]
		public static implicit operator Vector3(pb_IntVec3 p)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2475AC0", Offset = "0x2474EC0", VA = "0x182475AC0")]
		public static implicit operator pb_IntVec3(Vector3 p)
		{
			return default(pb_IntVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[ExecuteInEditMode]
	[Cpp2IlInjected.Attribute(Name = "AddComponentMenu", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	internal class pb_LineRenderer : pb_MonoBehaviourSingleton<pb_LineRenderer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private HideFlags SceneCameraHideFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private pb_ObjectPool<Mesh> pool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[HideInInspector]
		public List<Mesh> gizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[HideInInspector]
		public Material mat;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2476710", Offset = "0x2475B10", VA = "0x182476710")]
		public pb_LineRenderer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x24760E0", Offset = "0x24754E0", VA = "0x1824760E0")]
		private static Mesh MeshConstructor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2476350", Offset = "0x2475750", VA = "0x182476350", Slot = "5")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2476300", Offset = "0x2475700", VA = "0x182476300")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2475F10", Offset = "0x2475310", VA = "0x182475F10", Slot = "4")]
		public override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2476160", Offset = "0x2475560", VA = "0x182476160")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2475BA0", Offset = "0x2474FA0", VA = "0x182475BA0")]
		public void AddLineSegments(Vector3[] segments, Color[] colors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2476020", Offset = "0x2475420", VA = "0x182476020")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2476450", Offset = "0x2475850", VA = "0x182476450")]
		private void OnRenderObject()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[Flags]
	public enum pb_LogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Error = 1,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Warning = 2,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Info = 4,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		Default = 3,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		All = 0xFF
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Flags]
	public enum pb_LogOutput
	{
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Console = 1,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		File = 2
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class pb_Log
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public const string DEFAULT_LOG_PATH = "ProBuilderLog.txt";

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static Stack<pb_LogLevel> m_logStack;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static pb_LogLevel m_LogLevel;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static pb_LogOutput m_Output;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private static string m_LogFilePath;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2477040", Offset = "0x2476440", VA = "0x182477040")]
		public static void PushLogLevel(pb_LogLevel level)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2476C30", Offset = "0x2476030", VA = "0x182476C30")]
		public static void PopLogLevel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2477130", Offset = "0x2476530", VA = "0x182477130")]
		public static void SetLogLevel(pb_LogLevel level)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2477190", Offset = "0x2476590", VA = "0x182477190")]
		public static void SetOutput(pb_LogOutput output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x24770D0", Offset = "0x24764D0", VA = "0x1824770D0")]
		public static void SetLogFile(string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x69B90", Offset = "0x68F90", VA = "0x180069B90")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public static void Debug<T>(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2476830", Offset = "0x2475C30", VA = "0x182476830")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public static void Debug(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x69B90", Offset = "0x68F90", VA = "0x180069B90")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public static void Debug(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2476AB0", Offset = "0x2475EB0", VA = "0x182476AB0")]
		public static void Info(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2476BA0", Offset = "0x2475FA0", VA = "0x182476BA0")]
		public static void Info(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2477280", Offset = "0x2476680", VA = "0x182477280")]
		public static void Warning(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x24771F0", Offset = "0x24765F0", VA = "0x1824771F0")]
		public static void Warning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x24769A0", Offset = "0x2475DA0", VA = "0x1824769A0")]
		public static void Error(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2476A20", Offset = "0x2475E20", VA = "0x182476A20")]
		public static void Error(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5CFEB0", Offset = "0x5CF2B0", VA = "0x1805CFEB0")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		internal static void Watch<T, K>(T key, K value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2476890", Offset = "0x2475C90", VA = "0x182476890")]
		private static void DoPrint(string message, LogType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2476D90", Offset = "0x2476190", VA = "0x182476D90")]
		private static void PrintToFile(string message, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2476780", Offset = "0x2475B80", VA = "0x182476780")]
		public static void ClearLogFile()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2476CB0", Offset = "0x24760B0", VA = "0x182476CB0")]
		private static void PrintToConsole(string message, LogType type = LogType.Log)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class pb_Material
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private static Shader s_SelectionPickerShader;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static Material s_DefaultMaterial;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static Material s_FacePickerMaterial;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private static Material s_VertexPickerMaterial;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private static Material s_EdgePickerMaterial;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private static Material s_UnityDefaultDiffuse;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static Material s_UnlitVertexColorMaterial;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal static Shader SelectionPickerShader
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2477B30", Offset = "0x2476F30", VA = "0x182477B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static Material DefaultMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x24774D0", Offset = "0x24768D0", VA = "0x1824774D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal static Material FacePickerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x24778D0", Offset = "0x2476CD0", VA = "0x1824778D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal static Material VertexPickerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x2477FC0", Offset = "0x24773C0", VA = "0x182477FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		internal static Material EdgePickerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2477700", Offset = "0x2476B00", VA = "0x182477700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal static Material TriggerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2477BD0", Offset = "0x2476FD0", VA = "0x182477BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal static Material ColliderMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2477410", Offset = "0x2476810", VA = "0x182477410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		[Obsolete]
		internal static Material NoDrawMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2477A70", Offset = "0x2476E70", VA = "0x182477A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal static Material UnityDefaultDiffuse
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2477C90", Offset = "0x2477090", VA = "0x182477C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		internal static Material UnlitVertexColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2477E90", Offset = "0x2477290", VA = "0x182477E90")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class pb_Math
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public const float PHI = 1.618034f;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public const float FLT_EPSILON = float.Epsilon;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public const float FLT_COMPARE_EPSILON = 0.0001f;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public const float HANDLE_EPSILON = 0.0001f;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private static Vector3 tv1;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static Vector3 tv2;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static Vector3 tv3;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static Vector3 tv4;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x247C8C0", Offset = "0x247BCC0", VA = "0x18247C8C0")]
		public static Vector2 PointInCircumference(float radius, float angleInDegrees, Vector2 origin)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x247D0D0", Offset = "0x247C4D0", VA = "0x18247D0D0")]
		internal static Vector3 PointInSphere(float radius, float latitudeAngle, float longitudeAngle)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x247E430", Offset = "0x247D830", VA = "0x18247E430")]
		public static float SignedAngle(Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x247E6C0", Offset = "0x247DAC0", VA = "0x18247E6C0")]
		public static float SqrDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x247EBA0", Offset = "0x247DFA0", VA = "0x18247EBA0")]
		public static float TriangleArea(Vector3 x, Vector3 y, Vector3 z)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x247D200", Offset = "0x247C600", VA = "0x18247D200")]
		internal static float PolygonArea(Vector3[] vertices, int[] indices)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x247E220", Offset = "0x247D620", VA = "0x18247E220")]
		internal static Vector2 RotateAroundPoint(this Vector2 v, Vector2 origin, float theta)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x247E310", Offset = "0x247D710", VA = "0x18247E310")]
		public static Vector2 ScaleAroundPoint(this Vector2 v, Vector2 origin, Vector2 scale)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x247C810", Offset = "0x247BC10", VA = "0x18247C810")]
		internal static Vector2 Perpendicular(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x247C870", Offset = "0x247BC70", VA = "0x18247C870")]
		public static Vector2 Perpendicular(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x247E040", Offset = "0x247D440", VA = "0x18247E040")]
		public static Vector2 ReflectPoint(Vector2 point, Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2479B90", Offset = "0x2478F90", VA = "0x182479B90")]
		public static float DistancePointLineSegment(Vector2 p, Vector2 v, Vector2 w)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2479DA0", Offset = "0x24791A0", VA = "0x182479DA0")]
		public static float DistancePointLineSegment(Vector3 p, Vector3 v, Vector3 w)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x247A360", Offset = "0x2479760", VA = "0x18247A360")]
		public static Vector3 GetNearestPointRayRay(Vector3 ao, Vector3 ad, Vector3 bo, Vector3 bd)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x247A1C0", Offset = "0x24795C0", VA = "0x18247A1C0")]
		internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, ref Vector2 intersect)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x247A0D0", Offset = "0x24794D0", VA = "0x18247A0D0")]
		internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x247C980", Offset = "0x247BD80", VA = "0x18247C980")]
		internal static bool PointInPolygon(Vector2[] polygon, Vector2 point, [Optional] int[] indices)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x247CD10", Offset = "0x247C110", VA = "0x18247CD10")]
		internal static bool PointInPolygon(Vector2[] positions, pb_Bounds2D polyBounds, pb_Edge[] edges, Vector2 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x247CEA0", Offset = "0x247C2A0", VA = "0x18247CEA0")]
		internal static bool PointInPolygon(Vector3[] positions, pb_Bounds2D polyBounds, pb_Edge[] edges, Vector2 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x247DFE0", Offset = "0x247D3E0", VA = "0x18247DFE0")]
		internal static bool RectIntersectsLineSegment(Rect rect, Vector2 a, Vector2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x247DF90", Offset = "0x247D390", VA = "0x18247DF90")]
		internal static bool RectIntersectsLineSegment(Rect rect, Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x247DA70", Offset = "0x247CE70", VA = "0x18247DA70")]
		public static bool RayIntersectsTriangle(Ray InRay, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, out float OutDistance, out Vector3 OutPoint)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x247D530", Offset = "0x247C930", VA = "0x18247D530")]
		internal static bool RayIntersectsTriangle2(Vector3 origin, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, ref float distance, ref Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x247E3C0", Offset = "0x247D7C0", VA = "0x18247E3C0")]
		public static float Secant(float x)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x247B840", Offset = "0x247AC40", VA = "0x18247B840")]
		public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x247BDB0", Offset = "0x247B1B0", VA = "0x18247BDB0")]
		internal static Vector3 Normal(IList<pb_Vertex> vertices, [Optional] IList<int> indices)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x247BA30", Offset = "0x247AE30", VA = "0x18247BA30")]
		public static Vector3 Normal(pb_Object pb, pb_Face face)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x247C2C0", Offset = "0x247B6C0", VA = "0x18247C2C0")]
		public static Vector3 Normal(IList<Vector3> p)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x247AC60", Offset = "0x247A060", VA = "0x18247AC60")]
		public static void NormalTangentBitangent(pb_Object pb, pb_Face face, out Vector3 normal, out Vector3 tangent, out Vector3 bitangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x247A7C0", Offset = "0x2479BC0", VA = "0x18247A7C0")]
		internal static bool IsCardinalAxis(Vector3 v, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x950FE0", Offset = "0x9503E0", VA = "0x180950FE0")]
		internal static T Max<T>(T[] array) where T : IComparable<T>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x951160", Offset = "0x950560", VA = "0x180951160")]
		internal static T Min<T>(T[] array) where T : IComparable<T>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x247AA30", Offset = "0x2479E30", VA = "0x18247AA30")]
		internal static float LargestValue(Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x247AA60", Offset = "0x2479E60", VA = "0x18247AA60")]
		internal static float LargestValue(Vector2 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x247E4E0", Offset = "0x247D8E0", VA = "0x18247E4E0")]
		internal static Vector2 SmallestVector2(Vector2[] v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x247E590", Offset = "0x247D990", VA = "0x18247E590")]
		internal static Vector2 SmallestVector2(Vector2[] v, int[] indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x247ABB0", Offset = "0x2479FB0", VA = "0x18247ABB0")]
		internal static Vector2 LargestVector2(Vector2[] v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x247AA80", Offset = "0x2479E80", VA = "0x18247AA80")]
		internal static Vector2 LargestVector2(Vector2[] v, int[] indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2479680", Offset = "0x2478A80", VA = "0x182479680")]
		internal static Vector3 BoundsCenter(Vector3[] verts)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2478B00", Offset = "0x2477F00", VA = "0x182478B00")]
		public static Vector2 Average(IList<Vector2> v, [Optional] IList<int> indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2478D10", Offset = "0x2478110", VA = "0x182478D10")]
		public static Vector3 Average(IList<Vector3> v, [Optional] IList<int> indices)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1F917A0", Offset = "0x1F90BA0", VA = "0x181F917A0")]
		public static Vector3 Average<T>(this IList<T> v, Func<T, Vector3> selector, [Optional] IList<int> indices)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x24793F0", Offset = "0x24787F0", VA = "0x1824793F0")]
		internal static Vector4 Average(IList<Vector4> v, [Optional] IList<int> indices)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2478770", Offset = "0x2477B70", VA = "0x182478770")]
		internal static Color Average(IList<Color> c, [Optional] IList<int> indices)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2478250", Offset = "0x2477650", VA = "0x182478250")]
		public static bool Approx2(this Vector2 v, Vector2 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2478320", Offset = "0x2477720", VA = "0x182478320")]
		public static bool Approx3(this Vector3 v, Vector3 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2478430", Offset = "0x2477830", VA = "0x182478430")]
		public static bool Approx4(this Vector4 v, Vector4 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2478580", Offset = "0x2477980", VA = "0x182478580")]
		internal static bool ApproxC(this Color a, Color b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x24786D0", Offset = "0x2477AD0", VA = "0x1824786D0")]
		internal static bool Approx(this float a, float b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x247ED60", Offset = "0x247E160", VA = "0x18247ED60")]
		internal static int Wrap(int value, int lowerBound, int upperBound)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2479A40", Offset = "0x2478E40", VA = "0x182479A40")]
		public static int Clamp(int value, int lowerBound, int upperBound)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x247E8C0", Offset = "0x247DCC0", VA = "0x18247E8C0")]
		internal static Vector2 ToMask(this Vector2 vec, float delta = float.Epsilon)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x247E740", Offset = "0x247DB40", VA = "0x18247E740")]
		internal static Vector3 ToMask(this Vector3 vec, float delta = float.Epsilon)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x247E9C0", Offset = "0x247DDC0", VA = "0x18247E9C0")]
		internal static Vector3 ToSignedMask(this Vector3 vec, float delta = float.Epsilon)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2478190", Offset = "0x2477590", VA = "0x182478190")]
		internal static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x247A730", Offset = "0x2479B30", VA = "0x18247A730")]
		internal static int IntSum(this Vector3 mask)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2479A60", Offset = "0x2478E60", VA = "0x182479A60")]
		internal static void Cross(Vector3 a, Vector3 b, ref float x, ref float y, ref float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2479B30", Offset = "0x2478F30", VA = "0x182479B30")]
		internal static void Cross(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2479AC0", Offset = "0x2478EC0", VA = "0x182479AC0")]
		internal static void Cross(float ax, float ay, float az, float bx, float by, float bz, ref float x, ref float y, ref float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x247E700", Offset = "0x247DB00", VA = "0x18247E700")]
		internal static void Subtract(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class pb_MeshCompiler
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2425C70", Offset = "0x2425070", VA = "0x182425C70")]
		public static void Compile(pb_Object pb, ref Mesh target, out Material[] materials, MeshTopology preferredTopology = MeshTopology.Triangles)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2426050", Offset = "0x2425450", VA = "0x182426050")]
		internal static Vector2[] GetUVs(pb_Object pb)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class pb_MeshUtility
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x66AE0", Offset = "0x65EE0", VA = "0x180066AE0")]
		public pb_MeshUtility()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2427A00", Offset = "0x2426E00", VA = "0x182427A00")]
		public static pb_Vertex[] GeneratePerTriangleMesh(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x24269F0", Offset = "0x2425DF0", VA = "0x1824269F0")]
		public static void CollapseSharedVertices(Mesh m, [Optional] pb_Vertex[] vertices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2427DB0", Offset = "0x24271B0", VA = "0x182427DB0")]
		public static void GenerateTangent(ref Mesh InMesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2427290", Offset = "0x2426690", VA = "0x182427290")]
		public static Mesh DeepCopy(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2426E40", Offset = "0x2426240", VA = "0x182426E40")]
		public static void CopyTo(Mesh source, Mesh destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x24272F0", Offset = "0x24266F0", VA = "0x1824272F0")]
		public static Vector3[] GenerateNormals(pb_Object pb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x242A0F0", Offset = "0x24294F0", VA = "0x18242A0F0")]
		public static void SmoothNormals(pb_Object pb, ref Vector3[] normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9512E0", Offset = "0x9506E0", VA = "0x1809512E0")]
		public static T GetMeshAttribute<T>(GameObject go, Func<Mesh, T> attributeGetter) where T : IList
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2428A70", Offset = "0x2427E70", VA = "0x182428A70")]
		public static string Print(Mesh m)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x24288C0", Offset = "0x2427CC0", VA = "0x1824288C0")]
		public static uint GetIndexCount(Mesh m)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2428980", Offset = "0x2427D80", VA = "0x182428980")]
		public static uint GetTriangleCount(Mesh m)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class pb_MonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static MonoBehaviour m_Instance;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static T instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x125D340", Offset = "0x125C740", VA = "0x18125D340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static T nullableInstance
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x125D560", Offset = "0x125C960", VA = "0x18125D560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x773280", Offset = "0x772680", VA = "0x180773280")]
		public pb_MonoBehaviourSingleton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x125D2A0", Offset = "0x125C6A0", VA = "0x18125D2A0")]
		public static bool Valid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x125D170", Offset = "0x125C570", VA = "0x18125D170", Slot = "4")]
		public virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x125D260", Offset = "0x125C660", VA = "0x18125D260", Slot = "5")]
		public virtual void OnEnable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[Cpp2IlInjected.Attribute(Name = "AddComponentMenu", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	[Cpp2IlInjected.Attribute(Name = "RequireComponent", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	[Cpp2IlInjected.Attribute(Name = "RequireComponent", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class pb_Object : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private pb_Face[] _quads;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private pb_IntArray[] _sharedIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private Vector3[] _vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		private Vector2[] _uv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private List<Vector4> _uv3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private List<Vector4> _uv4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private Vector4[] _tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private pb_IntArray[] _sharedIndicesUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Color[] _colors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public bool userCollisions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public bool isSelectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public pb_UnwrapParameters unwrapParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		internal string asset_guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public bool dontDestroyMeshOnDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private int[] m_selectedFaces;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		private pb_Edge[] m_SelectedEdges;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private int[] m_selectedTriangles;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal Mesh msh
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x24310B0", Offset = "0x24304B0", VA = "0x1824310B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x2431340", Offset = "0x2430740", VA = "0x182431340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public pb_Face[] faces
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xC44450", Offset = "0xC43850", VA = "0x180C44450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public pb_IntArray[] sharedIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xC44470", Offset = "0xC43870", VA = "0x180C44470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public pb_IntArray[] sharedIndicesUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x151A080", Offset = "0x1519480", VA = "0x18151A080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int id
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x2431080", Offset = "0x2430480", VA = "0x182431080")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3[] vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xC44440", Offset = "0xC43840", VA = "0x180C44440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Color[] colors
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x1A5F840", Offset = "0x1A5EC40", VA = "0x181A5F840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2[] uv
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xC4E290", Offset = "0xC4D690", VA = "0x180C4E290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool hasUv2
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x2430EB0", Offset = "0x24302B0", VA = "0x182430EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool hasUv3
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x2430FA0", Offset = "0x24303A0", VA = "0x182430FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool hasUv4
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x2431010", Offset = "0x2430410", VA = "0x182431010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public List<Vector4> uv3
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xC45A90", Offset = "0xC44E90", VA = "0x180C45A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public List<Vector4> uv4
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xC655F0", Offset = "0xC649F0", VA = "0x180C655F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int faceCount
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2430EA0", Offset = "0x24302A0", VA = "0x182430EA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int vertexCount
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x24311D0", Offset = "0x24305D0", VA = "0x1824311D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int triangleCount
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x2431100", Offset = "0x2430500", VA = "0x182431100")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public pb_Face[] SelectedFaces
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x2430E30", Offset = "0x2430230", VA = "0x182430E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public int SelectedFaceCount
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x2430E10", Offset = "0x2430210", VA = "0x182430E10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int[] SelectedTriangles
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xC6AAF0", Offset = "0xC69EF0", VA = "0x180C6AAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int SelectedTriangleCount
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x2430E80", Offset = "0x2430280", VA = "0x182430E80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public pb_Edge[] SelectedEdges
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xC6AAB0", Offset = "0xC69EB0", VA = "0x180C6AAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int SelectedEdgeCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x2430DF0", Offset = "0x24301F0", VA = "0x182430DF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action<pb_Object> onDestroyObject
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x2430C90", Offset = "0x2430090", VA = "0x182430C90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x24311E0", Offset = "0x24305E0", VA = "0x1824311E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		internal static event Action<pb_Object> onElementSelectionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x2430D40", Offset = "0x2430140", VA = "0x182430D40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x2431290", Offset = "0x2430690", VA = "0x182431290")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2430B90", Offset = "0x242FF90", VA = "0x182430B90")]
		public pb_Object()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x242BC60", Offset = "0x242B060", VA = "0x18242BC60")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x242C790", Offset = "0x242BB90", VA = "0x18242C790")]
		public Vector3[] GetNormals()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x242CAA0", Offset = "0x242BEA0", VA = "0x18242CAA0")]
		public pb_IntArray[] GetSharedIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x242C8A0", Offset = "0x242BCA0", VA = "0x18242C8A0")]
		public pb_IntArray[] GetSharedIndicesUV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x242B980", Offset = "0x242AD80", VA = "0x18242B980")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x242D6F0", Offset = "0x242CAF0", VA = "0x18242D6F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x242D050", Offset = "0x242C450", VA = "0x18242D050")]
		public static pb_Object InitWithObject(pb_Object pb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x242C0F0", Offset = "0x242B4F0", VA = "0x18242C0F0")]
		internal static pb_Object CreateInstanceWithPoints(Vector3[] vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x242C200", Offset = "0x242B600", VA = "0x18242C200")]
		public static pb_Object CreateInstanceWithVerticesFaces(Vector3[] v, pb_Face[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x242BDD0", Offset = "0x242B1D0", VA = "0x18242BDD0")]
		internal static pb_Object CreateInstanceWithElements(Vector3[] v, Vector2[] u, Color[] c, pb_Face[] f, pb_IntArray[] si, pb_IntArray[] si_uv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x242BF00", Offset = "0x242B300", VA = "0x18242BF00")]
		public static pb_Object CreateInstanceWithElements(pb_Vertex[] vertices, pb_Face[] faces, [Optional] pb_IntArray[] si)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x242B900", Offset = "0x242AD00", VA = "0x18242B900")]
		internal void AddToFaceSelection(pb_Face face)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x242FA80", Offset = "0x242EE80", VA = "0x18242FA80")]
		internal void SetSelectedFaces(IEnumerable<pb_Face> selected)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x242FC70", Offset = "0x242F070", VA = "0x18242FC70")]
		internal void SetSelectedFaces(IEnumerable<int> selected)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x242F9C0", Offset = "0x242EDC0", VA = "0x18242F9C0")]
		internal void SetSelectedEdges(IEnumerable<pb_Edge> edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x242FE30", Offset = "0x242F230", VA = "0x18242FE30")]
		internal void SetSelectedTriangles(int[] tris)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x242F4F0", Offset = "0x242E8F0", VA = "0x18242F4F0")]
		internal void RemoveFromFaceSelectionAtIndex(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x242F550", Offset = "0x242E950", VA = "0x18242F550")]
		internal void RemoveFromFaceSelection(pb_Face face)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x242BBC0", Offset = "0x242AFC0", VA = "0x18242BBC0")]
		internal void ClearSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x125210", Offset = "0x124610", VA = "0x180125210")]
		public void SetVertices(Vector3[] v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2430110", Offset = "0x242F510", VA = "0x182430110")]
		public void SetVertices(IList<pb_Vertex> vertices, bool applyMesh = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7BA10", Offset = "0x7AE10", VA = "0x18007BA10")]
		public void SetUV(Vector2[] uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x242F820", Offset = "0x242EC20", VA = "0x18242F820")]
		public void SetFaces(IEnumerable<pb_Face> newFaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE40", Offset = "0x8D240", VA = "0x18008DE40")]
		public void SetSharedIndices(pb_IntArray[] si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x242FF40", Offset = "0x242F340", VA = "0x18242FF40")]
		public void SetSharedIndices(IEnumerable<KeyValuePair<int, int>> si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA2160", Offset = "0xA1560", VA = "0x1800A2160")]
		internal void SetSharedIndicesUV(pb_IntArray[] si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x242FF20", Offset = "0x242F320", VA = "0x18242FF20")]
		internal void SetSharedIndicesUV(IEnumerable<KeyValuePair<int, int>> si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x242C2B0", Offset = "0x242B6B0", VA = "0x18242C2B0")]
		private void GeometryWithPoints(Vector3[] v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x242C6C0", Offset = "0x242BAC0", VA = "0x18242C6C0")]
		public void GeometryWithVerticesFaces(Vector3[] v, pb_Face[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x24308E0", Offset = "0x242FCE0", VA = "0x1824308E0")]
		public MeshRebuildReason Verify()
		{
			return default(MeshRebuildReason);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2430720", Offset = "0x242FB20", VA = "0x182430720")]
		public void ToMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x2430380", Offset = "0x242F780", VA = "0x182430380")]
		public void ToMesh(MeshTopology preferredTopology)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x242D400", Offset = "0x242C800", VA = "0x18242D400")]
		internal void MakeUnique()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x242F240", Offset = "0x242E640", VA = "0x18242F240")]
		public void Refresh(RefreshMask mask = RefreshMask.All)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x242D7F0", Offset = "0x242CBF0", VA = "0x18242D7F0")]
		private void RefreshCollisions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x242CF30", Offset = "0x242C330", VA = "0x18242CF30")]
		internal int GetUnusedTextureGroup(int i = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x24307C0", Offset = "0x242FBC0", VA = "0x1824307C0")]
		internal int UnusedElementGroup(int i = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x242CCA0", Offset = "0x242C0A0", VA = "0x18242CCA0")]
		public void GetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x242FFD0", Offset = "0x242F3D0", VA = "0x18242FFD0")]
		public void SetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x242E380", Offset = "0x242D780", VA = "0x18242E380")]
		private void RefreshUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x242E390", Offset = "0x242D790", VA = "0x18242E390")]
		internal void RefreshUV(IEnumerable<pb_Face> facesToRefresh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x242F7A0", Offset = "0x242EBA0", VA = "0x18242F7A0")]
		public void SetFaceMaterial(pb_Face[] facesToApply, Material mat)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x242FF60", Offset = "0x242F360", VA = "0x18242FF60")]
		public void SetUV2(Vector2[] v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x242E0E0", Offset = "0x242D4E0", VA = "0x18242E0E0")]
		private void RefreshColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x242F5D0", Offset = "0x242E9D0", VA = "0x18242F5D0")]
		public void SetColors(Color[] InColors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x242F680", Offset = "0x242EA80", VA = "0x18242F680")]
		public void SetFaceColor(pb_Face face, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xE36D0", Offset = "0xE2AD0", VA = "0x1800E36D0")]
		public void SetTangents(Vector4[] tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x242E1C0", Offset = "0x242D5C0", VA = "0x18242E1C0")]
		private void RefreshNormals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x242E2E0", Offset = "0x242D6E0", VA = "0x18242E2E0")]
		private void RefreshTangents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class pb_ObjectPool<T> where T : UnityEngine.Object, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int desiredSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public Func<T> constructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public Action<T> destructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private Queue pool;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x125DB50", Offset = "0x125CF50", VA = "0x18125DB50")]
		public pb_ObjectPool(int initialSize, int desiredSize, Func<T> constructor, Action<T> destructor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x125D910", Offset = "0x125CD10", VA = "0x18125D910")]
		public T Get()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x125DAA0", Offset = "0x125CEA0", VA = "0x18125DAA0")]
		public void Put(T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x125D7D0", Offset = "0x125CBD0", VA = "0x18125D7D0")]
		public void Empty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x125D770", Offset = "0x125CB70", VA = "0x18125D770")]
		private static void DestroyObject(T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x125DA70", Offset = "0x125CE70", VA = "0x18125DA70")]
		private void OnDestroy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class pb_ObjectUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x242B7C0", Offset = "0x242ABC0", VA = "0x18242B7C0")]
		public static Vector3[] VerticesInWorldSpace(this pb_Object pb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x242B6A0", Offset = "0x242AAA0", VA = "0x18242B6A0")]
		public static Vector3[] VerticesInWorldSpace(this pb_Object pb, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x242B450", Offset = "0x242A850", VA = "0x18242B450")]
		public static void TranslateVertices_World(this pb_Object pb, int[] selectedTriangles, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x242AD80", Offset = "0x242A180", VA = "0x18242AD80")]
		public static void TranslateVertices_World(this pb_Object pb, int[] selectedTriangles, Vector3 offset, float snapValue, bool snapAxisOnly, Dictionary<int, int> lookup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x242B4A0", Offset = "0x242A8A0", VA = "0x18242B4A0")]
		public static void TranslateVertices(this pb_Object pb, int[] selectedTriangles, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x242AA10", Offset = "0x2429E10", VA = "0x18242AA10")]
		public static void SetSharedVertexPosition(this pb_Object pb, int sharedIndex, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x242AB50", Offset = "0x2429F50", VA = "0x18242AB50")]
		public static void SetSharedVertexValues(this pb_Object pb, int sharedIndex, pb_Vertex vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x242A880", Offset = "0x2429C80", VA = "0x18242A880")]
		public static bool FaceWithTriangle(this pb_Object pb, int[] tri, out pb_Face face)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x242A960", Offset = "0x2429D60", VA = "0x18242A960")]
		public static bool FaceWithTriangle(this pb_Object pb, int[] tri, out int face)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)0, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct pb_PickerOptions
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public bool depthTest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public pb_RectSelectMode rectSelectMode;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly pb_PickerOptions k_Default;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static pb_PickerOptions Default
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2431400", Offset = "0x2430800", VA = "0x182431400")]
			get
			{
				return default(pb_PickerOptions);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class pb_Picking
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2432ED0", Offset = "0x24322D0", VA = "0x182432ED0")]
		public static Dictionary<pb_Object, HashSet<int>> PickVerticesInRect(Camera cam, Rect rect, IList<pb_Object> selectable, pb_PickerOptions options, float pixelsPerPoint = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2431D20", Offset = "0x2431120", VA = "0x182431D20")]
		public static Dictionary<pb_Object, HashSet<pb_Face>> PickFacesInRect(Camera cam, Rect rect, IList<pb_Object> selectable, pb_PickerOptions options, float pixelsPerPoint = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2431460", Offset = "0x2430860", VA = "0x182431460")]
		public static Dictionary<pb_Object, HashSet<pb_Edge>> PickEdgesInRect(Camera cam, Rect rect, IList<pb_Object> selectable, pb_PickerOptions options, float pixelsPerPoint = 1f)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[DisallowMultipleComponent]
	[ProGridsConditionalSnap]
	[Cpp2IlInjected.Attribute(Name = "AddComponentMenu", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
	public class pb_PolyShape : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public enum PolyEditMode
		{
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			Path,
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			Height,
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			Edit
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private pb_Object m_Mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public List<Vector3> points;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public float extrude;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public PolyEditMode polyEditMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public bool flipNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public bool isOnGrid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Material material;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public pb_Object mesh
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x24333F0", Offset = "0x24327F0", VA = "0x1824333F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x89E30", Offset = "0x89230", VA = "0x180089E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2433380", Offset = "0x2432780", VA = "0x182433380")]
		public pb_PolyShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xC546D0", Offset = "0xC53AD0", VA = "0x180C546D0")]
		private bool IsSnapEnabled()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal class pb_PreferenceDictionary : ScriptableObject, ISerializationCallbackReceiver, pb_IHasDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private Dictionary<string, bool> m_Bool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private Dictionary<string, int> m_Int;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private Dictionary<string, float> m_Float;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private Dictionary<string, string> m_String;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private Dictionary<string, Color> m_Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private Dictionary<string, Material> m_Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private List<string> m_Bool_keys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private List<string> m_Int_keys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private List<string> m_Float_keys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private List<string> m_String_keys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		private List<string> m_Color_keys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		private List<string> m_Material_keys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		private List<bool> m_Bool_values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		private List<int> m_Int_values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		private List<float> m_Float_values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		private List<string> m_String_values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		private List<Color> m_Color_values;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		private List<Material> m_Material_values;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2434650", Offset = "0x2433A50", VA = "0x182434650")]
		public pb_PreferenceDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2433F00", Offset = "0x2433300", VA = "0x182433F00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2433AE0", Offset = "0x2432EE0", VA = "0x182433AE0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x24342E0", Offset = "0x24336E0", VA = "0x1824342E0", Slot = "6")]
		public void SetDefaultValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x24339E0", Offset = "0x2432DE0", VA = "0x1824339E0")]
		public bool HasKey(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x9C79F0", Offset = "0x9C6DF0", VA = "0x1809C79F0")]
		public bool HasKey<T>(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2433520", Offset = "0x2432920", VA = "0x182433520")]
		public void DeleteKey(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x951500", Offset = "0x950900", VA = "0x180951500")]
		public T Get<T>(string key, [Optional] T fallback)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5CFF70", Offset = "0x5CF370", VA = "0x1805CFF70")]
		public void Set<T>(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x24336C0", Offset = "0x2432AC0", VA = "0x1824336C0")]
		public bool GetBool(string key, bool fallback = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2433860", Offset = "0x2432C60", VA = "0x182433860")]
		public int GetInt(string key, int fallback = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x24337E0", Offset = "0x2432BE0", VA = "0x1824337E0")]
		public float GetFloat(string key, float fallback = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2433960", Offset = "0x2432D60", VA = "0x182433960")]
		public string GetString(string key, [Optional] string fallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2433740", Offset = "0x2432B40", VA = "0x182433740")]
		public Color GetColor(string key, [Optional] Color fallback)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x24338E0", Offset = "0x2432CE0", VA = "0x1824338E0")]
		public Material GetMaterial(string key, [Optional] Material fallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2434170", Offset = "0x2433570", VA = "0x182434170")]
		public void SetBool(string key, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2434440", Offset = "0x2433840", VA = "0x182434440")]
		public void SetInt(string key, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2434390", Offset = "0x2433790", VA = "0x182434390")]
		public void SetFloat(string key, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x24345A0", Offset = "0x24339A0", VA = "0x1824345A0")]
		public void SetString(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2434220", Offset = "0x2433620", VA = "0x182434220")]
		public void SetColor(string key, Color value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x24344F0", Offset = "0x24338F0", VA = "0x1824344F0")]
		public void SetMaterial(string key, Material value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xC44450", Offset = "0xC43850", VA = "0x180C44450")]
		public Dictionary<string, bool> GetBoolDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xC44470", Offset = "0xC43870", VA = "0x180C44470")]
		public Dictionary<string, int> GetIntDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xC44440", Offset = "0xC43840", VA = "0x180C44440")]
		public Dictionary<string, float> GetFloatDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xC4E290", Offset = "0xC4D690", VA = "0x180C4E290")]
		public Dictionary<string, string> GetStringDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xC45A90", Offset = "0xC44E90", VA = "0x180C45A90")]
		public Dictionary<string, Color> GetColorDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xC655F0", Offset = "0xC649F0", VA = "0x180C655F0")]
		public Dictionary<string, Material> GetMaterialDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2433480", Offset = "0x2432880", VA = "0x182433480")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class pb_Projection
	{
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static Vector3 t_uaxis;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static Vector3 t_vaxis;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2435870", Offset = "0x2434C70", VA = "0x182435870")]
		public static Vector2[] PlanarProject(IEnumerable<Vector3> verts, Vector3 planeNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x24354B0", Offset = "0x24348B0", VA = "0x1824354B0")]
		internal static Vector2[] PlanarProject(pb_Object pb, pb_Face face)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x24355C0", Offset = "0x24349C0", VA = "0x1824355C0")]
		internal static Vector2[] PlanarProject(IList<pb_Vertex> vertices, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x24350D0", Offset = "0x24344D0", VA = "0x1824350D0")]
		internal static Vector2[] PlanarProject(Vector3[] verts, Vector3 planeNormal, ProjectionAxis projectionAxis, [Optional] int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2434D10", Offset = "0x2434110", VA = "0x182434D10")]
		internal static void PlanarProject(Vector3[] verts, Vector2[] uvs, int[] indices, Vector3 planeNormal, ProjectionAxis projectionAxis)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2435F00", Offset = "0x2435300", VA = "0x182435F00")]
		internal static Vector2[] SphericalProject(IList<Vector3> vertices, [Optional] IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2435B30", Offset = "0x2434F30", VA = "0x182435B30")]
		internal static IList<Vector2> Sort(IList<Vector2> verts, SortMethod method = SortMethod.CounterClockwise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x2435930", Offset = "0x2434D30", VA = "0x182435930")]
		internal static Vector3 ProjectionAxisToVector(ProjectionAxis axis)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x24362A0", Offset = "0x24356A0", VA = "0x1824362A0")]
		internal static ProjectionAxis VectorToProjectionAxis(Vector3 plane)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x96F460", Offset = "0x96E860", VA = "0x18096F460")]
		internal static Plane FindBestPlane<T>(IList<T> points, Func<T, Vector3> selector, [Optional] IList<int> indices)
		{
			return default(Plane);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2434760", Offset = "0x2433B60", VA = "0x182434760")]
		internal static Plane FindBestPlane(Vector3[] points, [Optional] int[] indices)
		{
			return default(Plane);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	internal class pb_RaycastHit
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public float distance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public Vector3 point;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Vector3 normal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int face;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x2436490", Offset = "0x2435890", VA = "0x182436490")]
		public pb_RaycastHit(float InDistance, Vector3 InPoint, Vector3 InNormal, int InFaceIndex)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal class pb_Renderable : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public Mesh mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Transform transform;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xB72D0", Offset = "0xB66D0", VA = "0x1800B72D0")]
		public pb_Renderable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x24365E0", Offset = "0x24359E0", VA = "0x1824365E0")]
		public static pb_Renderable CreateInstance(Mesh InMesh, Material InMaterial, [Optional] Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2436500", Offset = "0x2435900", VA = "0x182436500")]
		public static pb_Renderable CreateInstance()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2436650", Offset = "0x2435A50", VA = "0x182436650")]
		public static void DestroyInstance(UnityEngine.Object ren)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x24366B0", Offset = "0x2435AB0", VA = "0x1824366B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2436750", Offset = "0x2435B50", VA = "0x182436750")]
		public void Render()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	internal static class pb_SelectionPicker
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private const string k_FacePickerOcclusionTintUniform = "_Tint";

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly Color k_Blackf;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly Color k_Whitef;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private const uint k_PickerHashNone = 0u;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private const uint k_PickerHashMin = 1u;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private const uint k_PickerHashMax = 16777215u;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private const uint k_MinEdgePixelsForValidSelection = 1u;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private static bool s_Initialized;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private static RenderTextureFormat s_RenderTextureFormat;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private static RenderTextureFormat[] s_PreferredFormats;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private static RenderTextureFormat renderTextureFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x243A8A0", Offset = "0x2439CA0", VA = "0x18243A8A0")]
			get
			{
				return default(RenderTextureFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private static TextureFormat textureFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x243AAC0", Offset = "0x2439EC0", VA = "0x18243AAC0")]
			get
			{
				return default(TextureFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x24390E0", Offset = "0x24384E0", VA = "0x1824390E0")]
		public static Dictionary<pb_Object, HashSet<pb_Face>> PickFacesInRect(Camera camera, Rect pickerRect, IList<pb_Object> selection, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2439730", Offset = "0x2438B30", VA = "0x182439730")]
		public static Dictionary<pb_Object, HashSet<int>> PickVerticesInRect(Camera camera, Rect pickerRect, IList<pb_Object> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2438A50", Offset = "0x2437E50", VA = "0x182438A50")]
		public static Dictionary<pb_Object, HashSet<pb_Edge>> PickEdgesInRect(Camera camera, Rect pickerRect, IList<pb_Object> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2439EC0", Offset = "0x24392C0", VA = "0x182439EC0")]
		private static Texture2D RenderSelectionPickerTexture(Camera camera, IList<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, pb_Face>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x243A070", Offset = "0x2439470", VA = "0x18243A070")]
		private static Texture2D RenderSelectionPickerTexture(Camera camera, IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, int>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2439C30", Offset = "0x2439030", VA = "0x182439C30")]
		private static Texture2D RenderSelectionPickerTexture(Camera camera, IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, pb_Edge>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x24380A0", Offset = "0x24374A0", VA = "0x1824380A0")]
		private static GameObject[] GenerateFacePickingObjects(IList<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, pb_Face>> map)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x24385B0", Offset = "0x24379B0", VA = "0x1824385B0")]
		private static void GenerateVertexPickingObjects(IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, int>> map, out GameObject[] depthObjects, out GameObject[] pickerObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2437C00", Offset = "0x2437000", VA = "0x182437C00")]
		private static void GenerateEdgePickingObjects(IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, pb_Edge>> map, out GameObject[] depthObjects, out GameObject[] pickerObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2436F30", Offset = "0x2436330", VA = "0x182436F30")]
		private static Mesh BuildVertexMesh(pb_Object pb, Dictionary<uint, pb_Tuple<pb_Object, int>> map, ref uint index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x24369B0", Offset = "0x2435DB0", VA = "0x1824369B0")]
		private static Mesh BuildEdgeMesh(pb_Object pb, Dictionary<uint, pb_Tuple<pb_Object, pb_Edge>> map, ref uint index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2437AD0", Offset = "0x2436ED0", VA = "0x182437AD0")]
		public static uint DecodeRGBA(Color32 color)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2437B60", Offset = "0x2436F60", VA = "0x182437B60")]
		public static Color32 EncodeRGBA(uint hash)
		{
			return default(Color32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x243A300", Offset = "0x2439700", VA = "0x18243A300")]
		private static Texture2D RenderWithReplacementShader(Camera camera, Shader shader, string tag, int width = -1, int height = -1)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum pb_ShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Cube,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		Stair,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		CurvedStair,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		Prism,
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		Cylinder,
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		Plane,
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		Door,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		Pipe,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		Cone,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		Sprite,
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		Arch,
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		Icosahedron,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		Torus
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class pb_ShapeGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private static readonly Vector3[] k_IcosphereVertices;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private static readonly int[] k_IcosphereTriangles;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private static readonly Vector3[] k_CubeVertices;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private static readonly int[] k_CubeTriangles;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x243C880", Offset = "0x243BC80", VA = "0x18243C880")]
		public static pb_Object CreateShape(pb_ShapeType shape)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2443BC0", Offset = "0x2442FC0", VA = "0x182443BC0")]
		public static pb_Object StairGenerator(Vector3 size, int steps, bool buildSides)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x243D170", Offset = "0x243C570", VA = "0x18243D170")]
		public static pb_Object CurvedStairGenerator(float stairWidth, float height, float innerRadius, float circumference, int steps, bool buildSides)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2444F80", Offset = "0x2444380", VA = "0x182444F80")]
		public static pb_Object StairGenerator(int steps, float width, float height, float depth, bool sidesGoToFloor, bool generateBack, bool platformsOnly)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x243CEE0", Offset = "0x243C2E0", VA = "0x18243CEE0")]
		public static pb_Object CubeGenerator(Vector3 size)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x243EC60", Offset = "0x243E060", VA = "0x18243EC60")]
		public static pb_Object CylinderGenerator(int axisDivisions, float radius, float height, int heightCuts, int smoothing = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2442E60", Offset = "0x2442260", VA = "0x182442E60")]
		public static pb_Object PrismGenerator(Vector3 size)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x243FB30", Offset = "0x243EF30", VA = "0x18243FB30")]
		public static pb_Object DoorGenerator(float totalWidth, float totalHeight, float ledgeHeight, float legWidth, float depth)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2442DE0", Offset = "0x24421E0", VA = "0x182442DE0")]
		[Obsolete]
		public static pb_Object PlaneGenerator(float _width, float _height, int widthCuts, int heightCuts, Axis axis, bool smooth)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2442460", Offset = "0x2441860", VA = "0x182442460")]
		public static pb_Object PlaneGenerator(float _width, float _height, int widthCuts, int heightCuts, Axis axis)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2441820", Offset = "0x2440C20", VA = "0x182441820")]
		public static pb_Object PipeGenerator(float radius, float height, float thickness, int subdivAxis, int subdivHeight)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x243C1F0", Offset = "0x243B5F0", VA = "0x18243C1F0")]
		public static pb_Object ConeGenerator(float radius, float height, int subdivAxis)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x243AAD0", Offset = "0x2439ED0", VA = "0x18243AAD0")]
		public static pb_Object ArchGenerator(float angle, float radius, float width, float depth, int radialCuts, bool insideFaces, bool outsideFaces, bool frontFaces, bool backFaces, bool endCaps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2440FD0", Offset = "0x24403D0", VA = "0x182440FD0")]
		public static pb_Object IcosahedronGenerator(float radius, int subdivisions, bool weldVertices = true, bool manualUvs = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x24458C0", Offset = "0x2444CC0", VA = "0x1824458C0")]
		private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x243BAC0", Offset = "0x243AEC0", VA = "0x18243BAC0")]
		private static Vector3[] CircleVertices(int segments, float radius, float circumference, Quaternion rotation, float offset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2446010", Offset = "0x2445410", VA = "0x182446010")]
		public static pb_Object TorusGenerator(int InRows, int InColumns, float InRadius, float InTubeRadius, bool InSmooth, float InHorizontalCircumference, float InVerticalCircumference, bool manualUvs = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal class pb_Shortcut
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public KeyCode key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public EventModifiers eventModifiers;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2447EA0", Offset = "0x24472A0", VA = "0x182447EA0")]
		public pb_Shortcut(string a, string d, KeyCode k, EventModifiers e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2447CB0", Offset = "0x24470B0", VA = "0x182447CB0")]
		public pb_Shortcut(string str)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x24473E0", Offset = "0x24467E0", VA = "0x1824473E0")]
		public bool Matches(KeyCode key, EventModifiers modifiers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2447340", Offset = "0x2446740", VA = "0x182447340")]
		public static int IndexOf(pb_Shortcut[] shortcuts, KeyCode k, EventModifiers e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2446EB0", Offset = "0x24462B0", VA = "0x182446EB0")]
		public static IEnumerable<pb_Shortcut> DefaultShortcuts()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2447400", Offset = "0x2446800", VA = "0x182447400")]
		public static IEnumerable<pb_Shortcut> ParseShortcuts(string str)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2447A40", Offset = "0x2446E40", VA = "0x182447A40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x24475C0", Offset = "0x24469C0", VA = "0x1824475C0")]
		public string Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2447970", Offset = "0x2446D70", VA = "0x182447970")]
		public static string ShortcutsToString(pb_Shortcut[] shortcuts)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class pb_Smoothing
	{
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public const int SMOOTHING_GROUP_NONE = 0;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public const int SMOOTH_RANGE_MIN = 1;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public const int SMOOTH_RANGE_MAX = 24;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public const int HARD_RANGE_MIN = 25;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public const int HARD_RANGE_MAX = 42;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x24488E0", Offset = "0x2447CE0", VA = "0x1824488E0")]
		public static int GetUnusedSmoothingGroup(pb_Object pb)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2448860", Offset = "0x2447C60", VA = "0x182448860")]
		private static int GetNextUnusedSmoothingGroup(int start, HashSet<int> used)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2448A30", Offset = "0x2447E30", VA = "0x182448A30")]
		public static bool IsSmooth(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2447EF0", Offset = "0x24472F0", VA = "0x182447EF0")]
		public static void ApplySmoothingGroups(pb_Object pb, IEnumerable<pb_Face> faces, float angleThreshold, [Optional] Vector3[] normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x24485E0", Offset = "0x24479E0", VA = "0x1824485E0")]
		private static bool FindSoftEdgesRecursive(Vector3[] normals, pb_WingedEdge wing, float angleThreshold, HashSet<pb_Face> processed)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2448A50", Offset = "0x2447E50", VA = "0x182448A50")]
		private static bool IsSoftEdge(Vector3[] normals, pb_EdgeLookup left, pb_EdgeLookup right, float threshold)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class pb_Snap
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2448DB0", Offset = "0x24481B0", VA = "0x182448DB0")]
		public static Vector3 SnapValue(Vector3 vertex, float snpVal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2448EB0", Offset = "0x24482B0", VA = "0x182448EB0")]
		public static float SnapValue(float val, float snpVal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2448F20", Offset = "0x2448320", VA = "0x182448F20")]
		public static Vector3 SnapValue(Vector3 vertex, Vector3 snap)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class pb_Spline
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x244A470", Offset = "0x2449870", VA = "0x18244A470")]
		internal static pb_Object Extrude(IList<pb_BezierPoint> points, float radius = 0.5f, int columns = 32, int rows = 16, bool closeLoop = false, bool smooth = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x244A390", Offset = "0x2449790", VA = "0x18244A390")]
		internal static void Extrude(IList<pb_BezierPoint> bezierPoints, float radius, int columns, int rows, bool closeLoop, bool smooth, ref pb_Object target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x244A560", Offset = "0x2449960", VA = "0x18244A560")]
		internal static List<Vector3> GetControlPoints(IList<pb_BezierPoint> bezierPoints, int subdivisionsPerSegment, bool closeLoop, List<Quaternion> rotations)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2449130", Offset = "0x2448530", VA = "0x182449130")]
		internal static void Extrude(IList<Vector3> points, float radius, int radiusRows, bool closeLoop, bool smooth, ref pb_Object target, [Optional] IList<Quaternion> pointRotations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x244A8F0", Offset = "0x2449CF0", VA = "0x18244A8F0")]
		private static Quaternion GetRingRotation(IList<Vector3> points, int i, bool closeLoop, out float secant)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x244AE60", Offset = "0x244A260", VA = "0x18244AE60")]
		private static Vector3[] VertexRing(Quaternion orientation, Vector3 offset, float radius, int segments)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class pb_Submesh
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int[] indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public MeshTopology topology;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public Material material;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x244B380", Offset = "0x244A780", VA = "0x18244B380")]
		public pb_Submesh(Material material, MeshTopology topology, int[] indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x244B3D0", Offset = "0x244A7D0", VA = "0x18244B3D0")]
		public pb_Submesh(Mesh mesh, int subMeshIndex, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x244B240", Offset = "0x244A640", VA = "0x18244B240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal class pb_Transform2D
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public Vector2 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public float rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public Vector2 scale;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x244B880", Offset = "0x244AC80", VA = "0x18244B880")]
		public pb_Transform2D(Vector2 position, float rotation, Vector2 scale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x244B7A0", Offset = "0x244ABA0", VA = "0x18244B7A0")]
		public Vector2 TransformPoint(Vector2 p)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x244B440", Offset = "0x244A840", VA = "0x18244B440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class pb_TransformUtil
	{
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private static Dictionary<Transform, Transform[]> _childrenStack;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x244BA30", Offset = "0x244AE30", VA = "0x18244BA30")]
		public static void UnparentChildren(Transform t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x244B8E0", Offset = "0x244ACE0", VA = "0x18244B8E0")]
		public static void ReparentChildren(Transform t)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[DisallowMultipleComponent]
	internal class pb_TriggerBehaviour : pb_EntityBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1D2E10", Offset = "0x1D2210", VA = "0x1801D2E10")]
		public pb_TriggerBehaviour()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x244BC00", Offset = "0x244B000", VA = "0x18244BC00", Slot = "4")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x244BD40", Offset = "0x244B140", VA = "0x18244BD40", Slot = "5")]
		public override void OnEnterPlayMode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class pb_Tuple<T1, T2>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public T1 Item1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public T2 Item2;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x77E8C0", Offset = "0x77DCC0", VA = "0x18077E8C0")]
		public pb_Tuple()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x125DFF0", Offset = "0x125D3F0", VA = "0x18125DFF0")]
		public pb_Tuple(T1 item1, T2 item2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x125DD70", Offset = "0x125D170", VA = "0x18125DD70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class pb_Tuple<T1, T2, T3>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public T1 Item1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public T2 Item2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public T3 Item3;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x77E8C0", Offset = "0x77DCC0", VA = "0x18077E8C0")]
		public pb_Tuple()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x125E100", Offset = "0x125D500", VA = "0x18125E100")]
		public pb_Tuple(T1 item1, T2 item2, T3 item3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x125E040", Offset = "0x125D440", VA = "0x18125E040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class pb_Tuple<T1, T2, T3, T4>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public T1 Item1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public T2 Item2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public T3 Item3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public T4 Item4;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x77E8C0", Offset = "0x77DCC0", VA = "0x18077E8C0")]
		public pb_Tuple()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x125E3B0", Offset = "0x125D7B0", VA = "0x18125E3B0")]
		public pb_Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x125E160", Offset = "0x125D560", VA = "0x18125E160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class pb_UnwrapParameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[Cpp2IlInjected.Attribute(Name = "TooltipAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public float hardAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[Cpp2IlInjected.Attribute(Name = "TooltipAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public float packMargin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[Cpp2IlInjected.Attribute(Name = "TooltipAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public float angleError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[Cpp2IlInjected.Attribute(Name = "TooltipAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public float areaError;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x244D8D0", Offset = "0x244CCD0", VA = "0x18244D8D0")]
		public pb_UnwrapParameters()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x244D8B0", Offset = "0x244CCB0", VA = "0x18244D8B0")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class pb_Util
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private struct SearchRange
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public int begin;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public int end;

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC0", Offset = "0x8D2C0", VA = "0x18008DEC0")]
			public SearchRange(int begin, int end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x2425BD0", Offset = "0x2424FD0", VA = "0x182425BD0")]
			public bool Valid()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x24258A0", Offset = "0x2424CA0", VA = "0x1824258A0")]
			public int Center()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x2425BB0", Offset = "0x2424FB0", VA = "0x182425BB0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x970140", Offset = "0x96F540", VA = "0x180970140")]
		public static T[] GetComponents<T>(this IEnumerable<GameObject> gameObjects) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x970100", Offset = "0x96F500", VA = "0x180970100")]
		public static T[] GetComponents<T>(GameObject go) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x96FF00", Offset = "0x96F300", VA = "0x18096FF00")]
		public static T[] GetComponents<T>(this IEnumerable<Transform> transforms) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x244DFC0", Offset = "0x244D3C0", VA = "0x18244DFC0")]
		public static Vector3[] ToWorldSpace(this Transform t, Vector3[] v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x244DA90", Offset = "0x244CE90", VA = "0x18244DA90")]
		public static GameObject EmptyGameObjectWithTransform(Transform t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x970890", Offset = "0x96FC90", VA = "0x180970890")]
		public static T[] ValuesWithIndices<T>(this T[] arr, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5B8BC0", Offset = "0x5B7FC0", VA = "0x1805B8BC0")]
		public static List<T> ValuesWithIndices<T>(this List<T> arr, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x951A00", Offset = "0x950E00", VA = "0x180951A00")]
		public static T NextEnumValue<T>(this T current) where T : IConvertible
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9C7EF0", Offset = "0x9C72F0", VA = "0x1809C7EF0")]
		public static bool IsEqual<T>(T[] a, T[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x96FA30", Offset = "0x96EE30", VA = "0x18096FA30")]
		public static T[] Add<T>(this T[] arr, T val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x96F8C0", Offset = "0x96ECC0", VA = "0x18096F8C0")]
		public static T[] AddRange<T>(this T[] arr, T[] val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x970660", Offset = "0x96FA60", VA = "0x180970660")]
		public static T[] Remove<T>(this T[] arr, T val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x970630", Offset = "0x96FA30", VA = "0x180970630")]
		public static T[] Remove<T>(this T[] arr, IEnumerable<T> val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9704D0", Offset = "0x96F8D0", VA = "0x1809704D0")]
		public static T[] RemoveAt<T>(this T[] arr, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x970430", Offset = "0x96F830", VA = "0x180970430")]
		public static T[] RemoveAt<T>(this IList<T> list, IEnumerable<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x970700", Offset = "0x96FB00", VA = "0x180970700")]
		public static T[] SortedRemoveAt<T>(this IList<T> list, IList<int> sorted_indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xAC1C00", Offset = "0xAC1000", VA = "0x180AC1C00")]
		public static int NearestIndexPriorToValue<T>(IList<T> sorted_list, T value) where T : IComparable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x96FDC0", Offset = "0x96F1C0", VA = "0x18096FDC0")]
		public static T[] Fill<T>(T val, int length)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x5B8B00", Offset = "0x5B7F00", VA = "0x1805B8B00")]
		public static List<T> Fill<T>(Func<int, T> ctor, int length)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x96FE70", Offset = "0x96F270", VA = "0x18096FE70")]
		public static T[] FilledArray<T>(T val, int length)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x9C7E60", Offset = "0x9C7260", VA = "0x1809C7E60")]
		public static bool ContainsMatch<T>(this T[] a, T[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9C7DB0", Offset = "0x9C71B0", VA = "0x1809C7DB0")]
		public static bool ContainsMatch<T>(this T[] a, T[] b, out int index_a, out int index_b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x96FAE0", Offset = "0x96EEE0", VA = "0x18096FAE0")]
		public static T[] Concat<T>(this T[] x, T[] y)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xAC1920", Offset = "0xAC0D20", VA = "0x180AC1920")]
		public static int IndexOf<T>(this List<List<T>> InList, T InValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x96FD00", Offset = "0x96F100", VA = "0x18096FD00")]
		public static T[] Fill<T>(int count, Func<int, T> ctor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5D0340", Offset = "0x5CF740", VA = "0x1805D0340")]
		public static void AddOrAppend<T, K>(this Dictionary<T, List<K>> dictionary, T key, K value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5D02A0", Offset = "0x5CF6A0", VA = "0x1805D02A0")]
		public static void AddOrAppendRange<T, K>(this Dictionary<T, List<K>> dictionary, T key, List<K> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x661EF0", Offset = "0x6612F0", VA = "0x180661EF0")]
		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xEFAAA0", Offset = "0xEF9EA0", VA = "0x180EFAAA0")]
		[Obsolete]
		public static string ToFormattedString<T>(this T[] t, string _delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xEFA850", Offset = "0xEF9C50", VA = "0x180EFA850")]
		[Obsolete]
		public static string ToFormattedString<T>(this T[] t, string _delimiter, int entriesPerLine, int maxEntries)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xEFA800", Offset = "0xEF9C00", VA = "0x180EFA800")]
		[Obsolete]
		public static string ToFormattedString<T>(this List<T> t, string _delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xEFA7C0", Offset = "0xEF9BC0", VA = "0x180EFA7C0")]
		[Obsolete]
		public static string ToFormattedString<T>(this HashSet<T> t, string _delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xEFABA0", Offset = "0xEF9FA0", VA = "0x180EFABA0")]
		public static string ToString<TKey, TValue>(this Dictionary<TKey, TValue> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xEFAE70", Offset = "0xEFA270", VA = "0x180EFAE70")]
		public static string ToString<T>(this IEnumerable<T> arr, string separator = ", ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x244D940", Offset = "0x244CD40", VA = "0x18244D940")]
		public static string ControlKeyString(char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x244D900", Offset = "0x244CD00", VA = "0x18244D900")]
		[Obsolete]
		public static bool ColorWithString(string value, out Color col)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x244E0F0", Offset = "0x244D4F0", VA = "0x18244E0F0")]
		public static bool TryParseColor(string value, ref Color col)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x244DBD0", Offset = "0x244CFD0", VA = "0x18244DBD0")]
		public static Vector3[] StringToVector3Array(string str)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x244D9E0", Offset = "0x244CDE0", VA = "0x18244D9E0")]
		public static Vector2 DivideBy(this Vector2 v, Vector2 o)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x244DA30", Offset = "0x244CE30", VA = "0x18244DA30")]
		public static Vector3 DivideBy(this Vector3 v, Vector3 o)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class pb_UV
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[Obsolete]
		public enum Justify
		{
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			Right,
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			Left,
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			Top,
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			Center,
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			Bottom,
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			None
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public enum Anchor
		{
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			UpperLeft,
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			UpperCenter,
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			UpperRight,
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			MiddleLeft,
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			MiddleCenter,
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			MiddleRight,
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			LowerLeft,
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			LowerCenter,
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			LowerRight,
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			None
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public enum Fill
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			Fit,
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			Tile,
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			Stretch
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public bool useWorldSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public bool flipU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public bool flipV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public bool swapUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public Fill fill;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public Vector2 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public float rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[Obsolete]
		public Justify justify;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public Vector2 localPivot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[Obsolete]
		public Vector2 localSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public Anchor anchor;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x244D780", Offset = "0x244CB80", VA = "0x18244D780")]
		public pb_UV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x244D820", Offset = "0x244CC20", VA = "0x18244D820")]
		public pb_UV(pb_UV uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x244CDE0", Offset = "0x244C1E0", VA = "0x18244CDE0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x244CE80", Offset = "0x244C280", VA = "0x18244CE80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class pb_UVUtility
	{
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private static Vector2 tvec2;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x244CAA0", Offset = "0x244BEA0", VA = "0x18244CAA0")]
		public static void PlanarMap2(Vector3[] verts, Vector2[] uvs, int[] indices, pb_UV uvSettings, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x244C150", Offset = "0x244B550", VA = "0x18244C150")]
		private static void ApplyUVSettings(Vector2[] uvs, int[] indices, pb_UV uvSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x244CBB0", Offset = "0x244BFB0", VA = "0x18244CBB0")]
		private static Vector2[] StretchUVs(Vector2[] uvs, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x244C8B0", Offset = "0x244BCB0", VA = "0x18244C8B0")]
		private static Vector2[] NormalizeUVs(Vector2[] uvs, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x244C690", Offset = "0x244BA90", VA = "0x18244C690")]
		[Obsolete]
		private static Vector2[] JustifyUVs(Vector2[] uvs, pb_UV.Justify j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x244BDD0", Offset = "0x244B1D0", VA = "0x18244BDD0")]
		private static void ApplyUVAnchor(Vector2[] uvs, int[] indices, pb_UV.Anchor anchor)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal static class pb_Vector
	{
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public const float FLT_COMPARE_RESOLUTION = 1000f;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x244E690", Offset = "0x244DA90", VA = "0x18244E690")]
		private static int HashFloat(float f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x244E5D0", Offset = "0x244D9D0", VA = "0x18244E5D0")]
		public static int GetHashCode(Vector2 v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x244E4C0", Offset = "0x244D8C0", VA = "0x18244E4C0")]
		public static int GetHashCode(Vector3 v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x244E360", Offset = "0x244D760", VA = "0x18244E360")]
		public static int GetHashCode(Vector4 v)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class pb_Version
	{
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public static readonly pb_VersionInfo Current;
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum VersionType
	{
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		Missing = -1,
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		Development,
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		Patch,
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		Alpha,
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		Beta,
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		Final
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class pb_VersionInfo : IEquatable<pb_VersionInfo>, IComparable<pb_VersionInfo>, IComparable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private int m_Major;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private int m_Minor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private int m_Patch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private int m_Build;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private VersionType m_Type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private string m_Metadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private string m_Date;

		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public const string DefaultStringFormat = "M.m.p-t.b";

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int major
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xC46C20", Offset = "0xC46020", VA = "0x180C46C20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int minor
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x1392A50", Offset = "0x1391E50", VA = "0x181392A50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int patch
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xC44AB0", Offset = "0xC43EB0", VA = "0x180C44AB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int build
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xC4A630", Offset = "0xC49A30", VA = "0x180C4A630")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public VersionType type
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xC64ED0", Offset = "0xC642D0", VA = "0x180C64ED0")]
			get
			{
				return default(VersionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string metadata
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xC44440", Offset = "0xC43840", VA = "0x180C44440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string date
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xC4E290", Offset = "0xC4D690", VA = "0x180C4E290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public pb_VersionInfo MajorMinorPatch
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x244F9A0", Offset = "0x244EDA0", VA = "0x18244F9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x244F7D0", Offset = "0x244EBD0", VA = "0x18244F7D0")]
		public pb_VersionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x244F8F0", Offset = "0x244ECF0", VA = "0x18244F8F0")]
		public pb_VersionInfo(string formatted, [Optional] string date)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x244F7F0", Offset = "0x244EBF0", VA = "0x18244F7F0")]
		public pb_VersionInfo(int major, int minor, int patch, int build = -1, VersionType type = VersionType.Missing, string date = "", string metadata = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x244EE80", Offset = "0x244E280", VA = "0x18244EE80")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x244E9D0", Offset = "0x244DDD0", VA = "0x18244E9D0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x244EB60", Offset = "0x244DF60", VA = "0x18244EB60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x244E8C0", Offset = "0x244DCC0", VA = "0x18244E8C0", Slot = "4")]
		public bool Equals(pb_VersionInfo version)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x244E6F0", Offset = "0x244DAF0", VA = "0x18244E6F0", Slot = "6")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x244F7C0", Offset = "0x244EBC0", VA = "0x18244F7C0")]
		private static int WrapNoValue(int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x244E780", Offset = "0x244DB80", VA = "0x18244E780", Slot = "5")]
		public int CompareTo(pb_VersionInfo version)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x244FAC0", Offset = "0x244EEC0", VA = "0x18244FAC0")]
		public static bool operator ==(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x244FB10", Offset = "0x244EF10", VA = "0x18244FB10")]
		public static bool operator !=(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x244FB50", Offset = "0x244EF50", VA = "0x18244FB50")]
		public static bool operator <(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x244FAE0", Offset = "0x244EEE0", VA = "0x18244FAE0")]
		public static bool operator >(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x244EEA0", Offset = "0x244E2A0", VA = "0x18244EEA0")]
		public string ToString(string format)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x244F1B0", Offset = "0x244E5B0", VA = "0x18244F1B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x244F1F0", Offset = "0x244E5F0", VA = "0x18244F1F0")]
		public static bool TryGetVersionInfo(string input, out pb_VersionInfo version)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x244ECC0", Offset = "0x244E0C0", VA = "0x18244ECC0")]
		private static VersionType GetVersionType(string input)
		{
			return default(VersionType);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x244EAB0", Offset = "0x244DEB0", VA = "0x18244EAB0")]
		private static int GetBuildNumber(string input)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class pb_Vertex : IEquatable<pb_Vertex>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public Vector3 normal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Vector4 tangent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public Vector2 uv0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public Vector2 uv2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public Vector4 uv3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public Vector4 uv4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public bool hasPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public bool hasColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public bool hasNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7B")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public bool hasTangent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public bool hasUv0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7D")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public bool hasUv2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7E")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public bool hasUv3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7F")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public bool hasUv4;

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x1F52430", Offset = "0x1F51830", VA = "0x181F52430")]
		public pb_Vertex(bool hasAllValues = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1F52480", Offset = "0x1F51880", VA = "0x181F52480")]
		public pb_Vertex(pb_Vertex v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x1F4F910", Offset = "0x1F4ED10", VA = "0x181F4F910", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1F4FBC0", Offset = "0x1F4EFC0", VA = "0x181F4FBC0", Slot = "4")]
		public bool Equals(pb_Vertex other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x1F50420", Offset = "0x1F4F820", VA = "0x181F50420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x1F52560", Offset = "0x1F51960", VA = "0x181F52560")]
		public static pb_Vertex operator +(pb_Vertex a, pb_Vertex b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x1F4EBB0", Offset = "0x1F4DFB0", VA = "0x181F4EBB0")]
		public void Add(pb_Vertex b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x1F526E0", Offset = "0x1F51AE0", VA = "0x181F526E0")]
		public static pb_Vertex operator -(pb_Vertex a, pb_Vertex b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F52160", Offset = "0x1F51560", VA = "0x181F52160")]
		public void Subtract(pb_Vertex b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x1F52660", Offset = "0x1F51A60", VA = "0x181F52660")]
		public static pb_Vertex operator *(pb_Vertex a, float value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x1F51C90", Offset = "0x1F51090", VA = "0x181F51C90")]
		public void Multiply(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x1F525E0", Offset = "0x1F519E0", VA = "0x181F525E0")]
		public static pb_Vertex operator /(pb_Vertex a, float value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1F4F6E0", Offset = "0x1F4EAE0", VA = "0x181F4F6E0")]
		public void Divide(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x1F51EC0", Offset = "0x1F512C0", VA = "0x181F51EC0")]
		public void Normalize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1F52420", Offset = "0x1F51820", VA = "0x181F52420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x1F504B0", Offset = "0x1F4F8B0", VA = "0x181F504B0")]
		public static pb_Vertex[] GetVertices(pb_Object pb, [Optional] IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1F50D90", Offset = "0x1F50190", VA = "0x181F50D90")]
		public static pb_Vertex[] GetVertices(Mesh m)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1F4FDF0", Offset = "0x1F4F1F0", VA = "0x181F4FDF0")]
		public static void GetArrays(IList<pb_Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x1F4FE60", Offset = "0x1F4F260", VA = "0x181F4FE60")]
		public static void GetArrays(IList<pb_Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4, AttributeType attributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x1F51F90", Offset = "0x1F51390", VA = "0x181F51F90")]
		public static void SetMesh(Mesh m, IList<pb_Vertex> vertices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1F4EE70", Offset = "0x1F4E270", VA = "0x181F4EE70")]
		public static pb_Vertex Average(IList<pb_Vertex> vertices, [Optional] IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1F51620", Offset = "0x1F50A20", VA = "0x181F51620")]
		public static pb_Vertex Mix(pb_Vertex x, pb_Vertex y, float a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal class pb_VertexConnection : IEquatable<pb_VertexConnection>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public pb_Face face;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public List<int> indices;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool isValid
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x1F4EB60", Offset = "0x1F4DF60", VA = "0x181F4EB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x154F80", Offset = "0x154380", VA = "0x180154F80")]
		public pb_VertexConnection(pb_Face face, List<int> indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1F4E900", Offset = "0x1F4DD00", VA = "0x181F4E900")]
		public pb_VertexConnection Distinct(pb_IntArray[] sharedIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1F4E9C0", Offset = "0x1F4DDC0", VA = "0x181F4E9C0", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1F4E990", Offset = "0x1F4DD90", VA = "0x181F4E990", Slot = "4")]
		public bool Equals(pb_VertexConnection vc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x365230", Offset = "0x364630", VA = "0x180365230")]
		public static implicit operator pb_Face(pb_VertexConnection vc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x15515C0", Offset = "0x15509C0", VA = "0x1815515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1F4EAD0", Offset = "0x1F4DED0", VA = "0x181F4EAD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1F4E830", Offset = "0x1F4DC30", VA = "0x181F4E830")]
		public static List<int> AllTriangles(List<pb_VertexConnection> vcs)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class pb_WingedEdge : IEquatable<pb_WingedEdge>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public pb_EdgeLookup edge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public pb_Face face;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public pb_WingedEdge next;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public pb_WingedEdge previous;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public pb_WingedEdge opposite;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x66AE0", Offset = "0x65EE0", VA = "0x180066AE0")]
		public pb_WingedEdge()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1F52890", Offset = "0x1F51C90", VA = "0x181F52890", Slot = "4")]
		public bool Equals(pb_WingedEdge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1F528D0", Offset = "0x1F51CD0", VA = "0x181F528D0", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1F52AE0", Offset = "0x1F51EE0", VA = "0x181F52AE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x1F52A70", Offset = "0x1F51E70", VA = "0x181F52A70", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1F52A70", Offset = "0x1F51E70", VA = "0x181F52A70")]
		public pb_WingedEdgeEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1F52850", Offset = "0x1F51C50", VA = "0x181F52850")]
		public int Count()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1F54170", Offset = "0x1F53570", VA = "0x181F54170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1F53430", Offset = "0x1F52830", VA = "0x181F53430")]
		public static int[] MakeQuad(pb_WingedEdge left, pb_WingedEdge right)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1F529E0", Offset = "0x1F51DE0", VA = "0x181F529E0")]
		public pb_WingedEdge GetAdjacentEdgeWithCommonIndex(int common)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x1F53F90", Offset = "0x1F53390", VA = "0x181F53F90")]
		public static List<pb_Edge> SortEdgesByAdjacency(pb_Face face)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1F54010", Offset = "0x1F53410", VA = "0x181F54010")]
		public static List<pb_Edge> SortEdgesByAdjacency(List<pb_Edge> edges)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x1F52B10", Offset = "0x1F51F10", VA = "0x181F52B10")]
		public static Dictionary<int, List<pb_WingedEdge>> GetSpokes(List<pb_WingedEdge> wings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1F53D70", Offset = "0x1F53170", VA = "0x181F53D70")]
		public static List<int> SortCommonIndicesByAdjacency(List<pb_WingedEdge> wings, HashSet<int> common)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x1F52DB0", Offset = "0x1F521B0", VA = "0x181F52DB0")]
		public static List<pb_WingedEdge> GetWingedEdges(pb_Object pb, bool oneWingPerFace = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x1F52E00", Offset = "0x1F52200", VA = "0x181F52E00")]
		public static List<pb_WingedEdge> GetWingedEdges(pb_Object pb, IEnumerable<pb_Face> faces, bool oneWingPerFace = false, [Optional] Dictionary<int, int> sharedIndexLookup)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class pb_WingedEdgeEnumerator : IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private pb_WingedEdge _start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private pb_WingedEdge _current;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x1F52790", Offset = "0x1F51B90", VA = "0x181F52790", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public pb_WingedEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F527E0", Offset = "0x1F51BE0", VA = "0x181F527E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x1F527A0", Offset = "0x1F51BA0", VA = "0x181F527A0")]
		public pb_WingedEdgeEnumerator(pb_WingedEdge start)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x1F52760", Offset = "0x1F51B60", VA = "0x181F52760", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x118FCF0", Offset = "0x118F0F0", VA = "0x18118FCF0", Slot = "6")]
		public void Reset()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
