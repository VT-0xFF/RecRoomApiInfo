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
			[Cpp2IlInjected.Address(RVA = "0xE1F870", Offset = "0xE1EC70", VA = "0x180E1F870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string releaseNotes
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xE1F860", Offset = "0xE1EC60", VA = "0x180E1F860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x249D00", Offset = "0x249100", VA = "0x180249D00")]
		public ChangelogEntry(pb_VersionInfo version, string releaseNotes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x18B6E30", Offset = "0x18B6230", VA = "0x1818B6E30", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x18B7240", Offset = "0x18B6640", VA = "0x1818B7240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x18B6FE0", Offset = "0x18B63E0", VA = "0x1818B6FE0")]
		public Changelog(string log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x18B6EA0", Offset = "0x18B62A0", VA = "0x1818B6EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18B7420", Offset = "0x18B6820", VA = "0x1818B7420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static pb_ActionResult NoSelection
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x18B73C0", Offset = "0x18B67C0", VA = "0x1818B73C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static pb_ActionResult UserCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x18B7480", Offset = "0x18B6880", VA = "0x1818B7480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x261210", Offset = "0x260610", VA = "0x180261210")]
		public pb_ActionResult(Status status, string notification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x18B74E0", Offset = "0x18B68E0", VA = "0x1818B74E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x18B8620", Offset = "0x18B7A20", VA = "0x1818B8620")]
		public pb_BezierPoint(Vector3 position, Vector3 tangentIn, Vector3 tangentOut, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x18B7BB0", Offset = "0x18B6FB0", VA = "0x1818B7BB0")]
		public void EnforceTangentMode(pb_BezierTangentDirection master, pb_BezierTangentMode mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x18B8470", Offset = "0x18B7870", VA = "0x1818B8470")]
		public void SetPosition(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x18B85E0", Offset = "0x18B79E0", VA = "0x1818B85E0")]
		public void SetTangentIn(Vector3 tangent, pb_BezierTangentMode mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x18B8600", Offset = "0x18B7A00", VA = "0x1818B8600")]
		public void SetTangentOut(Vector3 tangent, pb_BezierTangentMode mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x18B8390", Offset = "0x18B7790", VA = "0x1818B8390")]
		public static Vector3 QuadraticPosition(pb_BezierPoint a, pb_BezierPoint b, float t)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x18B7500", Offset = "0x18B6900", VA = "0x1818B7500")]
		public static Vector3 CubicPosition(pb_BezierPoint a, pb_BezierPoint b, float t)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x18B7BC0", Offset = "0x18B6FC0", VA = "0x1818B7BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18B8AB0", Offset = "0x18B7EB0", VA = "0x1818B8AB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xEA6C0", Offset = "0xE9AC0", VA = "0x1800EA6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x18B8A30", Offset = "0x18B7E30", VA = "0x1818B8A30")]
		public pb_BezierShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x18B8660", Offset = "0x18B7A60", VA = "0x1818B8660")]
		public void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x18B8960", Offset = "0x18B7D60", VA = "0x1818B8960")]
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
			[Cpp2IlInjected.Address(RVA = "0x181A260", Offset = "0x1819660", VA = "0x18181A260")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x18BB200", Offset = "0x18BA600", VA = "0x1818BB200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector2 extents
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE200D0", Offset = "0xE1F4D0", VA = "0x180E200D0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Vector2[] corners
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x18BB050", Offset = "0x18BA450", VA = "0x1818BB050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x18BA590", Offset = "0x18B9990", VA = "0x1818BA590")]
		public pb_Bounds2D()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x18B9DB0", Offset = "0x18B91B0", VA = "0x1818B9DB0")]
		public pb_Bounds2D(Vector2 center, Vector2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x18BA650", Offset = "0x18B9A50", VA = "0x1818BA650")]
		public pb_Bounds2D(Vector2[] points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x18BA4A0", Offset = "0x18B98A0", VA = "0x1818BA4A0")]
		public pb_Bounds2D(Vector2[] points, int[] indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x18BA730", Offset = "0x18B9B30", VA = "0x1818BA730")]
		public pb_Bounds2D(Vector2[] points, pb_Edge[] edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x18B9ED0", Offset = "0x18B92D0", VA = "0x1818B9ED0")]
		internal pb_Bounds2D(Vector3[] points, pb_Edge[] edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x18BACC0", Offset = "0x18BA0C0", VA = "0x1818BACC0")]
		public pb_Bounds2D(Vector2[] points, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x18B8D80", Offset = "0x18B8180", VA = "0x1818B8D80")]
		public bool ContainsPoint(Vector2 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x18B8DE0", Offset = "0x18B81E0", VA = "0x1818B8DE0")]
		public bool IntersectsLineSegment(Vector2 lineStart, Vector2 lineEnd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x18B9130", Offset = "0x18B8530", VA = "0x1818B9130")]
		public bool Intersects(pb_Bounds2D bounds)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x18B92A0", Offset = "0x18B86A0", VA = "0x1818B92A0")]
		public bool Intersects(Rect rect)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x18B9870", Offset = "0x18B8C70", VA = "0x1818B9870")]
		public void SetWithPoints(IList<Vector2> points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x18B9400", Offset = "0x18B8800", VA = "0x1818B9400")]
		public void SetWithPoints(IList<Vector2> points, IList<int> indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x18B8C80", Offset = "0x18B8080", VA = "0x1818B8C80")]
		public static Vector2 Center(Vector2[] points, int length = -1)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x18B8B40", Offset = "0x18B7F40", VA = "0x1818B8B40")]
		public static Vector2 Center(Vector2[] points, int[] indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x18B9B30", Offset = "0x18B8F30", VA = "0x1818B9B30", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x18BB410", Offset = "0x18BA810", VA = "0x1818BB410")]
		private static OutCode ComputeOutCode(Rect rect, float x, float y)
		{
			return default(OutCode);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x18BB4A0", Offset = "0x18BA8A0", VA = "0x1818BB4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A6D30", Offset = "0x2A6130", VA = "0x1802A6D30")]
		public pb_ColliderBehaviour()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x18BB830", Offset = "0x18BAC30", VA = "0x1818BB830", Slot = "4")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x18BBAF0", Offset = "0x18BAEF0", VA = "0x1818BBAF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x18BC240", Offset = "0x18BB640", VA = "0x1818BC240")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x18BC2C0", Offset = "0x18BB6C0", VA = "0x1818BC2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x18BC1F0", Offset = "0x18BB5F0", VA = "0x1818BC1F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x18BC1C0", Offset = "0x18BB5C0", VA = "0x1818BC1C0")]
		public pb_ColorPalette()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x18BBC00", Offset = "0x18BB000", VA = "0x1818BBC00", Slot = "4")]
		public void SetDefaultValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x18BBB80", Offset = "0x18BAF80", VA = "0x1818BBB80")]
		public void CopyTo(pb_ColorPalette target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2C5CC0", Offset = "0x2C50C0", VA = "0x1802C5CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x18BB3C0", Offset = "0x18BA7C0", VA = "0x1818BB3C0")]
		public pb_HsvColor(float h, float s, float v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x18D9C80", Offset = "0x18D9080", VA = "0x1818D9C80")]
		public pb_HsvColor(float h, float s, float v, float sv_modifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x18D9B20", Offset = "0x18D8F20", VA = "0x1818D9B20")]
		public static pb_HsvColor FromRGB(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x18D9BD0", Offset = "0x18D8FD0", VA = "0x1818D9BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x18D9B80", Offset = "0x18D8F80", VA = "0x1818D9B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x18BB3C0", Offset = "0x18BA7C0", VA = "0x1818BB3C0")]
		public pb_XYZ_Color(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x225DFF0", Offset = "0x225D3F0", VA = "0x18225DFF0")]
		public static pb_XYZ_Color FromRGB(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x225DF60", Offset = "0x225D360", VA = "0x18225DF60")]
		public static pb_XYZ_Color FromRGB(float R, float G, float B)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x225E050", Offset = "0x225D450", VA = "0x18225E050", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x18BB3C0", Offset = "0x18BA7C0", VA = "0x1818BB3C0")]
		public pb_CIE_Lab_Color(float L, float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x18BB2B0", Offset = "0x18BA6B0", VA = "0x1818BB2B0")]
		public static pb_CIE_Lab_Color FromXYZ(pb_XYZ_Color xyz)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x18BB240", Offset = "0x18BA640", VA = "0x1818BB240")]
		public static pb_CIE_Lab_Color FromRGB(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x18BB310", Offset = "0x18BA710", VA = "0x1818BB310", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x18D28D0", Offset = "0x18D1CD0", VA = "0x1818D28D0")]
		private static bool approx(float lhs, float rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x18BCB10", Offset = "0x18BBF10", VA = "0x1818BCB10")]
		public static pb_XYZ_Color RGBToXYZ(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x18BCB80", Offset = "0x18BBF80", VA = "0x1818BCB80")]
		public static pb_XYZ_Color RGBToXYZ(float r, float g, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x18BD020", Offset = "0x18BC420", VA = "0x1818BD020")]
		public static pb_CIE_Lab_Color XYZToCIE_Lab(pb_XYZ_Color xyz)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x18BC3C0", Offset = "0x18BB7C0", VA = "0x1818BC3C0")]
		public static float DeltaE(pb_CIE_Lab_Color lhs, pb_CIE_Lab_Color rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x18BC770", Offset = "0x18BBB70", VA = "0x1818BC770")]
		public static Color HSVtoRGB(pb_HsvColor hsv)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x18BC970", Offset = "0x18BBD70", VA = "0x1818BC970")]
		public static Color HSVtoRGB(float h, float s, float v)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x18BCD90", Offset = "0x18BC190", VA = "0x1818BCD90")]
		public static pb_HsvColor RGBtoHSV(Color color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x18BC4C0", Offset = "0x18BB8C0", VA = "0x1818BC4C0")]
		public static string GetColorName(Color InColor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x18BC330", Offset = "0x18BB730", VA = "0x1818BC330")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D2AD0", Offset = "0x18D1ED0", VA = "0x1818D2AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x394930", Offset = "0x393D30", VA = "0x180394930")]
		public pb_Edge(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x18D45F0", Offset = "0x18D39F0", VA = "0x1818D45F0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x18D4920", Offset = "0x18D3D20", VA = "0x1818D4920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x18D4560", Offset = "0x18D3960", VA = "0x1818D4560", Slot = "4")]
		public bool Equals(pb_Edge edge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x18D4460", Offset = "0x18D3860", VA = "0x1818D4460", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x18D45C0", Offset = "0x18D39C0", VA = "0x1818D45C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x18D49A0", Offset = "0x18D3DA0", VA = "0x1818D49A0")]
		public static pb_Edge operator +(pb_Edge a, pb_Edge b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x18D4A90", Offset = "0x18D3E90", VA = "0x1818D4A90")]
		public static pb_Edge operator -(pb_Edge a, pb_Edge b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x18D4980", Offset = "0x18D3D80", VA = "0x1818D4980")]
		public static pb_Edge operator +(pb_Edge a, int b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x18D4AB0", Offset = "0x18D3EB0", VA = "0x1818D4AB0")]
		public static pb_Edge operator -(pb_Edge a, int b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x18D49C0", Offset = "0x18D3DC0", VA = "0x1818D49C0")]
		public static bool operator ==(pb_Edge a, pb_Edge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x18D49F0", Offset = "0x18D3DF0", VA = "0x1818D49F0")]
		public static bool operator !=(pb_Edge a, pb_Edge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x18D4610", Offset = "0x18D3A10", VA = "0x1818D4610")]
		public int[] ToArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x18D4390", Offset = "0x18D3790", VA = "0x1818D4390")]
		public bool Equals(pb_Edge b, Dictionary<int, int> lookup)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x18D42A0", Offset = "0x18D36A0", VA = "0x1818D42A0")]
		public bool Contains(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x18D4140", Offset = "0x18D3540", VA = "0x1818D4140")]
		public bool Contains(pb_Edge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x18D4170", Offset = "0x18D3570", VA = "0x1818D4170")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D2F00", Offset = "0x18D2300", VA = "0x1818D2F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x249D00", Offset = "0x249100", VA = "0x180249D00")]
		public pb_EdgeConnection(pb_Face face, List<pb_Edge> edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x18D2D60", Offset = "0x18D2160", VA = "0x1818D2D60", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x18D2D30", Offset = "0x18D2130", VA = "0x1818D2D30", Slot = "4")]
		public bool Equals(pb_EdgeConnection fc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x437950", Offset = "0x436D50", VA = "0x180437950")]
		public static explicit operator pb_Face(pb_EdgeConnection fc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x180CFA0", Offset = "0x180C3A0", VA = "0x18180CFA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x18D2E70", Offset = "0x18D2270", VA = "0x1818D2E70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x18D2AE0", Offset = "0x18D1EE0", VA = "0x1818D2AE0")]
		public static List<int> AllTriangles(List<pb_EdgeConnection> ec)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class pb_EdgeExtension
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x18D3420", Offset = "0x18D2820", VA = "0x1818D3420")]
		public static pb_Edge[] GetUniversalEdges(pb_Edge[] edges, Dictionary<int, int> sharedIndicesLookup)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x18D3550", Offset = "0x18D2950", VA = "0x1818D3550")]
		public static pb_Edge[] GetUniversalEdges(pb_Edge[] edges, pb_IntArray[] sharedIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x18D3360", Offset = "0x18D2760", VA = "0x1818D3360")]
		internal static pb_Edge GetLocalEdgeFast(pb_Edge edge, pb_IntArray[] sharedIndices)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x18D37C0", Offset = "0x18D2BC0", VA = "0x1818D37C0")]
		public static bool ValidateEdge(pb_Object pb, pb_Edge edge, out pb_Tuple<pb_Face, pb_Edge> validEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x18D2F50", Offset = "0x18D2350", VA = "0x1818D2F50")]
		internal static pb_Edge[] AllEdges(pb_Face[] faces)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x18D32E0", Offset = "0x18D26E0", VA = "0x1818D32E0")]
		internal static bool Contains(this pb_Edge[] edges, pb_Edge edge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x18D3240", Offset = "0x18D2640", VA = "0x1818D3240")]
		internal static bool Contains(this pb_Edge[] edges, int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x18D3690", Offset = "0x18D2A90", VA = "0x1818D3690")]
		internal static int IndexOf(this IList<pb_Edge> edges, pb_Edge edge, Dictionary<int, int> lookup)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x18D3030", Offset = "0x18D2430", VA = "0x1818D3030")]
		internal static int[] AllTriangles(this pb_Edge[] edges)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x18D3150", Offset = "0x18D2550", VA = "0x1818D3150")]
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
		[Cpp2IlInjected.Address(RVA = "0x18D4100", Offset = "0x18D3500", VA = "0x1818D4100")]
		public pb_EdgeLookup(pb_Edge common, pb_Edge local)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x18D4090", Offset = "0x18D3490", VA = "0x1818D4090")]
		public pb_EdgeLookup(int cx, int cy, int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x18D3B40", Offset = "0x18D2F40", VA = "0x1818D3B40", Slot = "4")]
		public bool Equals(pb_EdgeLookup b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x18D3C00", Offset = "0x18D3000", VA = "0x1818D3C00", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x18D3FD0", Offset = "0x18D33D0", VA = "0x1818D3FD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x18D4000", Offset = "0x18D3400", VA = "0x1818D4000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x18D3F10", Offset = "0x18D3310", VA = "0x1818D3F10")]
		public static IEnumerable<pb_EdgeLookup> GetEdgeLookup(IEnumerable<pb_Edge> edges, Dictionary<int, int> lookup)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x18D3CD0", Offset = "0x18D30D0", VA = "0x1818D3CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE1FEC0", Offset = "0xE1F2C0", VA = "0x180E1FEC0")]
			get
			{
				return default(EntityType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xC4E80", Offset = "0xC4280", VA = "0x1800C4E80")]
		public pb_Entity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x18D4C30", Offset = "0x18D4030", VA = "0x1818D4C30")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x151C20", Offset = "0x151020", VA = "0x180151C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A6D30", Offset = "0x2A6130", VA = "0x1802A6D30")]
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
		[Cpp2IlInjected.Address(RVA = "0x18D4AD0", Offset = "0x18D3ED0", VA = "0x1818D4AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE1F870", Offset = "0xE1EC70", VA = "0x180E1F870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int[] distinctIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x18D73E0", Offset = "0x18D67E0", VA = "0x1818D73E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public pb_Edge[] edges
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x18D7400", Offset = "0x18D6800", VA = "0x1818D7400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int smoothingGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xE200C0", Offset = "0xE1F4C0", VA = "0x180E200C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x28E370", Offset = "0x28D770", VA = "0x18028E370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material material
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xE20E80", Offset = "0xE20280", VA = "0x180E20E80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xEA6C0", Offset = "0xE9AC0", VA = "0x1800EA6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public pb_UV uv
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xE29670", Offset = "0xE28A70", VA = "0x180E29670")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD3950", Offset = "0xD2D50", VA = "0x1800D3950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x18D73A0", Offset = "0x18D67A0", VA = "0x1818D73A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x18D72D0", Offset = "0x18D66D0", VA = "0x1818D72D0")]
		public pb_Face()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x18D7230", Offset = "0x18D6630", VA = "0x1818D7230")]
		public pb_Face(int[] i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x18D72E0", Offset = "0x18D66E0", VA = "0x1818D72E0")]
		public pb_Face(int[] i, Material m, pb_UV u, int smoothingGroup, int textureGroup, int elementGroup, bool manualUV)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x18D7110", Offset = "0x18D6510", VA = "0x1818D7110")]
		public pb_Face(pb_Face face)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x18D58C0", Offset = "0x18D4CC0", VA = "0x1818D58C0")]
		public void CopyFrom(pb_Face other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x18D63A0", Offset = "0x18D57A0", VA = "0x1818D63A0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x18D59C0", Offset = "0x18D4DC0", VA = "0x1818D59C0")]
		public pb_Edge[] GetAllEdges()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x18D6420", Offset = "0x18D5820", VA = "0x1818D6420")]
		public void SetIndices(int[] i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x18D6630", Offset = "0x18D5A30", VA = "0x1818D6630")]
		public void ShiftIndices(int offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x18D66A0", Offset = "0x18D5AA0", VA = "0x1818D66A0")]
		public int SmallestIndexValue()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x18D6450", Offset = "0x18D5850", VA = "0x1818D6450")]
		public void ShiftIndicesToZero()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x18D63F0", Offset = "0x18D57F0", VA = "0x1818D63F0")]
		public void ReverseIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x18D63D0", Offset = "0x18D57D0", VA = "0x1818D63D0")]
		public void RebuildCaches()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x18D5520", Offset = "0x18D4920", VA = "0x1818D5520")]
		private pb_Edge[] CacheEdges()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x18D5480", Offset = "0x18D4880", VA = "0x1818D5480")]
		private int[] CacheDistinctIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x18D5770", Offset = "0x18D4B70", VA = "0x1818D5770")]
		public bool Contains(int[] triangle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x18D53A0", Offset = "0x18D47A0", VA = "0x1818D53A0")]
		internal static int[] AllTriangles(pb_Face[] q)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x18D6730", Offset = "0x18D5B30", VA = "0x1818D6730")]
		public MeshTopology ToQuadOrTriangles(out int[] quadOrTris)
		{
			return default(MeshTopology);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x18D6840", Offset = "0x18D5C40", VA = "0x1818D6840")]
		public int[] ToQuad()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x18D6870", Offset = "0x18D5C70", VA = "0x1818D6870")]
		public bool ToQuad(out int[] quad)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x18D5C00", Offset = "0x18D5000", VA = "0x1818D5C00")]
		public static int GetMeshIndices(pb_Face[] faces, out pb_Submesh[] submeshes, MeshTopology preferredTopology = MeshTopology.Triangles)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x18D6F00", Offset = "0x18D6300", VA = "0x1818D6F00", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x18D5390", Offset = "0x18D4790", VA = "0x1818D5390")]
		public pb_FaceRebuildData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x181C790", Offset = "0x181BB90", VA = "0x18181C790")]
		public int Offset()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x18D5300", Offset = "0x18D4700", VA = "0x1818D5300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x18D4CE0", Offset = "0x18D40E0", VA = "0x1818D4CE0")]
		public static void Apply(IEnumerable<pb_FaceRebuildData> newFaces, pb_Object pb, [Optional] List<pb_Vertex> vertices, [Optional] List<pb_Face> faces, [Optional] Dictionary<int, int> lookup, [Optional] Dictionary<int, int> lookupUV)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x18D4EA0", Offset = "0x18D42A0", VA = "0x1818D4EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CB970", Offset = "0x2CAD70", VA = "0x1802CB970")]
		public pb_HandleConstraint2D(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x18D7600", Offset = "0x18D6A00", VA = "0x1818D7600")]
		public pb_HandleConstraint2D Inverse()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x18D7680", Offset = "0x18D6A80", VA = "0x1818D7680")]
		public Vector2 Mask(Vector2 v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x18D75B0", Offset = "0x18D69B0", VA = "0x1818D75B0")]
		public Vector2 InverseMask(Vector2 v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x18D7980", Offset = "0x18D6D80", VA = "0x1818D7980")]
		public static bool operator ==(pb_HandleConstraint2D a, pb_HandleConstraint2D b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x18D79C0", Offset = "0x18D6DC0", VA = "0x1818D79C0")]
		public static bool operator !=(pb_HandleConstraint2D a, pb_HandleConstraint2D b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x180CFA0", Offset = "0x180C3A0", VA = "0x18180CFA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x18D7420", Offset = "0x18D6820", VA = "0x1818D7420", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x18D76B0", Offset = "0x18D6AB0", VA = "0x1818D76B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x18D9740", Offset = "0x18D8B40", VA = "0x1818D9740")]
		public static Vector3 ScreenToGuiPoint(this Camera camera, Vector3 point, float pixelsPerPoint)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x18D8BC0", Offset = "0x18D7FC0", VA = "0x1818D8BC0")]
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out pb_RaycastHit hit, [Optional] HashSet<pb_Face> ignore)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x18D7A00", Offset = "0x18D6E00", VA = "0x1818D7A00")]
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out pb_RaycastHit hit, float distance, pb_Culling cullingMode, [Optional] HashSet<pb_Face> ignore)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x18D82C0", Offset = "0x18D76C0", VA = "0x1818D82C0")]
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out List<pb_RaycastHit> hits, float distance, pb_Culling cullingMode, [Optional] HashSet<pb_Face> ignore)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x18D8C20", Offset = "0x18D8020", VA = "0x1818D8C20")]
		public static Ray InverseTransformRay(this Transform transform, Ray InWorldRay)
		{
			return default(Ray);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x18D97D0", Offset = "0x18D8BD0", VA = "0x1818D97D0")]
		public static bool WorldRaycast(Ray InWorldRay, Transform transform, Vector3[] vertices, int[] triangles, out pb_RaycastHit hit, float distance = float.PositiveInfinity, pb_Culling cullingMode = pb_Culling.Front)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x18D91D0", Offset = "0x18D85D0", VA = "0x1818D91D0")]
		public static bool MeshRaycast(Ray InRay, Vector3[] vertices, int[] triangles, out pb_RaycastHit hit, float distance = float.PositiveInfinity, pb_Culling cullingMode = pb_Culling.Front)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x18D94D0", Offset = "0x18D88D0", VA = "0x1818D94D0")]
		internal static bool PointIsOccluded(Camera cam, pb_Object pb, Vector3 worldPoint)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x18D8F30", Offset = "0x18D8330", VA = "0x1818D8F30")]
		internal static bool IsOccluded(Camera cam, pb_Object pb, pb_Face face)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal class ProGridsNoSnapAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x116F60", Offset = "0x116360", VA = "0x180116F60")]
		public ProGridsNoSnapAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class ProGridsConditionalSnapAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x116F60", Offset = "0x116360", VA = "0x180116F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D73A0", Offset = "0x18D67A0", VA = "0x1818D73A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x18DC590", Offset = "0x18DB990", VA = "0x1818DC590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xD6AA70", Offset = "0xD69E70", VA = "0x180D6AA70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x104620", Offset = "0x103A20", VA = "0x180104620")]
		public pb_IntArray(int[] intArray)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x18DC480", Offset = "0x18DB880", VA = "0x1818DC480")]
		public pb_IntArray(pb_IntArray intArray)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x18DC3D0", Offset = "0x18DB7D0", VA = "0x1818DC3D0")]
		internal List<int> ToList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x437950", Offset = "0x436D50", VA = "0x180437950")]
		public static implicit operator int[](pb_IntArray intArr)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x18DC530", Offset = "0x18DB930", VA = "0x1818DC530")]
		public static explicit operator pb_IntArray(int[] arr)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x18DC430", Offset = "0x18DB830", VA = "0x1818DC430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x18DC2C0", Offset = "0x18DB6C0", VA = "0x1818DC2C0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x18DC2E0", Offset = "0x18DB6E0", VA = "0x1818DC2E0")]
		public static void RemoveEmptyOrNull(ref pb_IntArray[] val)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class pb_IntArrayUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x18DB490", Offset = "0x18DA890", VA = "0x1818DB490")]
		public static int[][] ToArray(this pb_IntArray[] val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x18DB5B0", Offset = "0x18DA9B0", VA = "0x1818DB5B0")]
		public static Dictionary<int, int> ToDictionary(this pb_IntArray[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x18DB9C0", Offset = "0x18DADC0", VA = "0x1818DB9C0")]
		public static pb_IntArray[] ToSharedIndices(this IEnumerable<KeyValuePair<int, int>> lookup)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x18DB870", Offset = "0x18DAC70", VA = "0x1818DB870")]
		public static pb_IntArray[] ToPbIntArray(this int[][] val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x18DB700", Offset = "0x18DAB00", VA = "0x1818DB700")]
		public static pb_IntArray[] ToPbIntArray(this List<List<int>> val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x18DA830", Offset = "0x18D9C30", VA = "0x1818DA830")]
		public static int IndexOf(this pb_IntArray[] intArray, int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x18D9F30", Offset = "0x18D9330", VA = "0x1818D9F30")]
		public static List<int> AllIndicesWithValues(this pb_IntArray[] pbIntArr, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x18DA050", Offset = "0x18D9450", VA = "0x1818DA050")]
		public static List<int> AllIndicesWithValues(this pb_IntArray[] pbIntArr, Dictionary<int, int> lookup, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x18DBF00", Offset = "0x18DB300", VA = "0x1818DBF00")]
		internal static List<int> UniqueIndicesWithValues(this pb_IntArray[] pbIntArr, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x18DA740", Offset = "0x18D9B40", VA = "0x1818DA740")]
		internal static HashSet<int> GetCommonIndices(this pb_IntArray[] pbIntArr, IEnumerable<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x18DA550", Offset = "0x18D9950", VA = "0x1818DA550")]
		internal static HashSet<int> GetCommonIndices(Dictionary<int, int> lookup, IEnumerable<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x18DA770", Offset = "0x18D9B70", VA = "0x1818DA770")]
		[Obsolete]
		internal static IEnumerable<int> GetIndicesWithCommon(this pb_IntArray[] pbIntArr, IEnumerable<int> common)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x18DA160", Offset = "0x18D9560", VA = "0x1818DA160")]
		public static pb_IntArray[] ExtractSharedIndices(Vector3[] v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x18DAB00", Offset = "0x18D9F00", VA = "0x1818DAB00")]
		internal static int MergeSharedIndices(ref pb_IntArray[] sharedIndices, int[] indices)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x18DA8F0", Offset = "0x18D9CF0", VA = "0x1818DA8F0")]
		internal static void MergeSharedIndices(ref pb_IntArray[] sharedIndices, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x18D9DF0", Offset = "0x18D91F0", VA = "0x1818D9DF0")]
		internal static int AddValueAtIndex(ref pb_IntArray[] sharedIndices, int sharedIndex, int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x18D9CF0", Offset = "0x18D90F0", VA = "0x1818D9CF0")]
		internal static int AddRangeAtIndex(ref pb_IntArray[] sharedIndices, int sharedIndex, int[] indices)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x18DB310", Offset = "0x18DA710", VA = "0x1818DB310")]
		internal static void RemoveValues(ref pb_IntArray[] sharedIndices, int[] remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x18DAF00", Offset = "0x18DA300", VA = "0x1818DAF00")]
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
			[Cpp2IlInjected.Address(RVA = "0xE2F930", Offset = "0xE2ED30", VA = "0x180E2F930")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float y
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x181A2F0", Offset = "0x18196F0", VA = "0x18181A2F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float z
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xE2F950", Offset = "0xE2ED50", VA = "0x180E2F950")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x10CA8D0", Offset = "0x10C9CD0", VA = "0x1810CA8D0")]
		public pb_IntVec3(Vector3 vector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x18DCC50", Offset = "0x18DC050", VA = "0x1818DCC50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x18DCD00", Offset = "0x18DC100", VA = "0x1818DCD00")]
		public static bool operator ==(pb_IntVec3 a, pb_IntVec3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x18DCD50", Offset = "0x18DC150", VA = "0x1818DCD50")]
		public static bool operator !=(pb_IntVec3 a, pb_IntVec3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x18DC9D0", Offset = "0x18DBDD0", VA = "0x1818DC9D0", Slot = "4")]
		public bool Equals(pb_IntVec3 p)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x18DCBC0", Offset = "0x18DBFC0", VA = "0x1818DCBC0")]
		public bool Equals(Vector3 p)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x18DC6F0", Offset = "0x18DBAF0", VA = "0x1818DC6F0", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x18DCC20", Offset = "0x18DC020", VA = "0x1818DCC20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x18DCDA0", Offset = "0x18DC1A0", VA = "0x1818DCDA0")]
		private static int round(float v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x18DCD30", Offset = "0x18DC130", VA = "0x1818DCD30")]
		public static implicit operator Vector3(pb_IntVec3 p)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x18DCD30", Offset = "0x18DC130", VA = "0x1818DCD30")]
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
		[Cpp2IlInjected.Address(RVA = "0x18DD980", Offset = "0x18DCD80", VA = "0x1818DD980")]
		public pb_LineRenderer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x18DD350", Offset = "0x18DC750", VA = "0x1818DD350")]
		private static Mesh MeshConstructor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x18DD5C0", Offset = "0x18DC9C0", VA = "0x1818DD5C0", Slot = "5")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x18DD570", Offset = "0x18DC970", VA = "0x1818DD570")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x18DD180", Offset = "0x18DC580", VA = "0x1818DD180", Slot = "4")]
		public override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x18DD3D0", Offset = "0x18DC7D0", VA = "0x1818DD3D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x18DCE10", Offset = "0x18DC210", VA = "0x1818DCE10")]
		public void AddLineSegments(Vector3[] segments, Color[] colors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x18DD290", Offset = "0x18DC690", VA = "0x1818DD290")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x18DD6C0", Offset = "0x18DCAC0", VA = "0x1818DD6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x18DE2B0", Offset = "0x18DD6B0", VA = "0x1818DE2B0")]
		public static void PushLogLevel(pb_LogLevel level)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x18DDEA0", Offset = "0x18DD2A0", VA = "0x1818DDEA0")]
		public static void PopLogLevel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x18DE3A0", Offset = "0x18DD7A0", VA = "0x1818DE3A0")]
		public static void SetLogLevel(pb_LogLevel level)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x18DE400", Offset = "0x18DD800", VA = "0x1818DE400")]
		public static void SetOutput(pb_LogOutput output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x18DE340", Offset = "0x18DD740", VA = "0x1818DE340")]
		public static void SetLogFile(string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xBC9D0", Offset = "0xBBDD0", VA = "0x1800BC9D0")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public static void Debug<T>(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x18DDAA0", Offset = "0x18DCEA0", VA = "0x1818DDAA0")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public static void Debug(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xBC9D0", Offset = "0xBBDD0", VA = "0x1800BC9D0")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public static void Debug(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x18DDD20", Offset = "0x18DD120", VA = "0x1818DDD20")]
		public static void Info(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x18DDE10", Offset = "0x18DD210", VA = "0x1818DDE10")]
		public static void Info(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x18DE4F0", Offset = "0x18DD8F0", VA = "0x1818DE4F0")]
		public static void Warning(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x18DE460", Offset = "0x18DD860", VA = "0x1818DE460")]
		public static void Warning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x18DDC10", Offset = "0x18DD010", VA = "0x1818DDC10")]
		public static void Error(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x18DDC90", Offset = "0x18DD090", VA = "0x1818DDC90")]
		public static void Error(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xB51340", Offset = "0xB50740", VA = "0x180B51340")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		internal static void Watch<T, K>(T key, K value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x18DDB00", Offset = "0x18DCF00", VA = "0x1818DDB00")]
		private static void DoPrint(string message, LogType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x18DE000", Offset = "0x18DD400", VA = "0x1818DE000")]
		private static void PrintToFile(string message, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x18DD9F0", Offset = "0x18DCDF0", VA = "0x1818DD9F0")]
		public static void ClearLogFile()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x18DDF20", Offset = "0x18DD320", VA = "0x1818DDF20")]
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
			[Cpp2IlInjected.Address(RVA = "0x18DEDA0", Offset = "0x18DE1A0", VA = "0x1818DEDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static Material DefaultMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x18DE740", Offset = "0x18DDB40", VA = "0x1818DE740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal static Material FacePickerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x18DEB40", Offset = "0x18DDF40", VA = "0x1818DEB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal static Material VertexPickerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x18DF230", Offset = "0x18DE630", VA = "0x1818DF230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		internal static Material EdgePickerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x18DE970", Offset = "0x18DDD70", VA = "0x1818DE970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal static Material TriggerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x18DEE40", Offset = "0x18DE240", VA = "0x1818DEE40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal static Material ColliderMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x18DE680", Offset = "0x18DDA80", VA = "0x1818DE680")]
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
			[Cpp2IlInjected.Address(RVA = "0x18DECE0", Offset = "0x18DE0E0", VA = "0x1818DECE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal static Material UnityDefaultDiffuse
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x18DEF00", Offset = "0x18DE300", VA = "0x1818DEF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		internal static Material UnlitVertexColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x18DF100", Offset = "0x18DE500", VA = "0x1818DF100")]
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
		[Cpp2IlInjected.Address(RVA = "0x18E3B30", Offset = "0x18E2F30", VA = "0x1818E3B30")]
		public static Vector2 PointInCircumference(float radius, float angleInDegrees, Vector2 origin)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x18E4340", Offset = "0x18E3740", VA = "0x1818E4340")]
		internal static Vector3 PointInSphere(float radius, float latitudeAngle, float longitudeAngle)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x18E56A0", Offset = "0x18E4AA0", VA = "0x1818E56A0")]
		public static float SignedAngle(Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x18E5930", Offset = "0x18E4D30", VA = "0x1818E5930")]
		public static float SqrDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x18E5E10", Offset = "0x18E5210", VA = "0x1818E5E10")]
		public static float TriangleArea(Vector3 x, Vector3 y, Vector3 z)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x18E4470", Offset = "0x18E3870", VA = "0x1818E4470")]
		internal static float PolygonArea(Vector3[] vertices, int[] indices)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x18E5490", Offset = "0x18E4890", VA = "0x1818E5490")]
		internal static Vector2 RotateAroundPoint(this Vector2 v, Vector2 origin, float theta)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x18E5580", Offset = "0x18E4980", VA = "0x1818E5580")]
		public static Vector2 ScaleAroundPoint(this Vector2 v, Vector2 origin, Vector2 scale)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x18E3A80", Offset = "0x18E2E80", VA = "0x1818E3A80")]
		internal static Vector2 Perpendicular(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x18E3AE0", Offset = "0x18E2EE0", VA = "0x1818E3AE0")]
		public static Vector2 Perpendicular(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x18E52B0", Offset = "0x18E46B0", VA = "0x1818E52B0")]
		public static Vector2 ReflectPoint(Vector2 point, Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x18E0E00", Offset = "0x18E0200", VA = "0x1818E0E00")]
		public static float DistancePointLineSegment(Vector2 p, Vector2 v, Vector2 w)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x18E1010", Offset = "0x18E0410", VA = "0x1818E1010")]
		public static float DistancePointLineSegment(Vector3 p, Vector3 v, Vector3 w)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x18E15D0", Offset = "0x18E09D0", VA = "0x1818E15D0")]
		public static Vector3 GetNearestPointRayRay(Vector3 ao, Vector3 ad, Vector3 bo, Vector3 bd)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x18E1430", Offset = "0x18E0830", VA = "0x1818E1430")]
		internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, ref Vector2 intersect)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x18E1340", Offset = "0x18E0740", VA = "0x1818E1340")]
		internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x18E3BF0", Offset = "0x18E2FF0", VA = "0x1818E3BF0")]
		internal static bool PointInPolygon(Vector2[] polygon, Vector2 point, [Optional] int[] indices)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x18E3F80", Offset = "0x18E3380", VA = "0x1818E3F80")]
		internal static bool PointInPolygon(Vector2[] positions, pb_Bounds2D polyBounds, pb_Edge[] edges, Vector2 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x18E4110", Offset = "0x18E3510", VA = "0x1818E4110")]
		internal static bool PointInPolygon(Vector3[] positions, pb_Bounds2D polyBounds, pb_Edge[] edges, Vector2 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x18E5250", Offset = "0x18E4650", VA = "0x1818E5250")]
		internal static bool RectIntersectsLineSegment(Rect rect, Vector2 a, Vector2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x18E5200", Offset = "0x18E4600", VA = "0x1818E5200")]
		internal static bool RectIntersectsLineSegment(Rect rect, Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x18E4CE0", Offset = "0x18E40E0", VA = "0x1818E4CE0")]
		public static bool RayIntersectsTriangle(Ray InRay, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, out float OutDistance, out Vector3 OutPoint)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x18E47A0", Offset = "0x18E3BA0", VA = "0x1818E47A0")]
		internal static bool RayIntersectsTriangle2(Vector3 origin, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, ref float distance, ref Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x18E5630", Offset = "0x18E4A30", VA = "0x1818E5630")]
		public static float Secant(float x)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x18E2AB0", Offset = "0x18E1EB0", VA = "0x1818E2AB0")]
		public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x18E3020", Offset = "0x18E2420", VA = "0x1818E3020")]
		internal static Vector3 Normal(IList<pb_Vertex> vertices, [Optional] IList<int> indices)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x18E2CA0", Offset = "0x18E20A0", VA = "0x1818E2CA0")]
		public static Vector3 Normal(pb_Object pb, pb_Face face)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x18E3530", Offset = "0x18E2930", VA = "0x1818E3530")]
		public static Vector3 Normal(IList<Vector3> p)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x18E1ED0", Offset = "0x18E12D0", VA = "0x1818E1ED0")]
		public static void NormalTangentBitangent(pb_Object pb, pb_Face face, out Vector3 normal, out Vector3 tangent, out Vector3 bitangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x18E1A30", Offset = "0x18E0E30", VA = "0x1818E1A30")]
		internal static bool IsCardinalAxis(Vector3 v, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x97F890", Offset = "0x97EC90", VA = "0x18097F890")]
		internal static T Max<T>(T[] array) where T : IComparable<T>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x97FA10", Offset = "0x97EE10", VA = "0x18097FA10")]
		internal static T Min<T>(T[] array) where T : IComparable<T>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x18E1CA0", Offset = "0x18E10A0", VA = "0x1818E1CA0")]
		internal static float LargestValue(Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x18E1CD0", Offset = "0x18E10D0", VA = "0x1818E1CD0")]
		internal static float LargestValue(Vector2 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x18E5750", Offset = "0x18E4B50", VA = "0x1818E5750")]
		internal static Vector2 SmallestVector2(Vector2[] v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x18E5800", Offset = "0x18E4C00", VA = "0x1818E5800")]
		internal static Vector2 SmallestVector2(Vector2[] v, int[] indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x18E1E20", Offset = "0x18E1220", VA = "0x1818E1E20")]
		internal static Vector2 LargestVector2(Vector2[] v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x18E1CF0", Offset = "0x18E10F0", VA = "0x1818E1CF0")]
		internal static Vector2 LargestVector2(Vector2[] v, int[] indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x18E08F0", Offset = "0x18DFCF0", VA = "0x1818E08F0")]
		internal static Vector3 BoundsCenter(Vector3[] verts)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x18DFD70", Offset = "0x18DF170", VA = "0x1818DFD70")]
		public static Vector2 Average(IList<Vector2> v, [Optional] IList<int> indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x18DFF80", Offset = "0x18DF380", VA = "0x1818DFF80")]
		public static Vector3 Average(IList<Vector3> v, [Optional] IList<int> indices)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2242020", Offset = "0x2241420", VA = "0x182242020")]
		public static Vector3 Average<T>(this IList<T> v, Func<T, Vector3> selector, [Optional] IList<int> indices)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x18E0660", Offset = "0x18DFA60", VA = "0x1818E0660")]
		internal static Vector4 Average(IList<Vector4> v, [Optional] IList<int> indices)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x18DF9E0", Offset = "0x18DEDE0", VA = "0x1818DF9E0")]
		internal static Color Average(IList<Color> c, [Optional] IList<int> indices)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x18DF4C0", Offset = "0x18DE8C0", VA = "0x1818DF4C0")]
		public static bool Approx2(this Vector2 v, Vector2 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x18DF590", Offset = "0x18DE990", VA = "0x1818DF590")]
		public static bool Approx3(this Vector3 v, Vector3 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x18DF6A0", Offset = "0x18DEAA0", VA = "0x1818DF6A0")]
		public static bool Approx4(this Vector4 v, Vector4 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x18DF7F0", Offset = "0x18DEBF0", VA = "0x1818DF7F0")]
		internal static bool ApproxC(this Color a, Color b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x18DF940", Offset = "0x18DED40", VA = "0x1818DF940")]
		internal static bool Approx(this float a, float b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x18E5FD0", Offset = "0x18E53D0", VA = "0x1818E5FD0")]
		internal static int Wrap(int value, int lowerBound, int upperBound)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x18E0CB0", Offset = "0x18E00B0", VA = "0x1818E0CB0")]
		public static int Clamp(int value, int lowerBound, int upperBound)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x18E5B30", Offset = "0x18E4F30", VA = "0x1818E5B30")]
		internal static Vector2 ToMask(this Vector2 vec, float delta = float.Epsilon)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x18E59B0", Offset = "0x18E4DB0", VA = "0x1818E59B0")]
		internal static Vector3 ToMask(this Vector3 vec, float delta = float.Epsilon)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x18E5C30", Offset = "0x18E5030", VA = "0x1818E5C30")]
		internal static Vector3 ToSignedMask(this Vector3 vec, float delta = float.Epsilon)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x18DF400", Offset = "0x18DE800", VA = "0x1818DF400")]
		internal static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x18E19A0", Offset = "0x18E0DA0", VA = "0x1818E19A0")]
		internal static int IntSum(this Vector3 mask)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x18E0CD0", Offset = "0x18E00D0", VA = "0x1818E0CD0")]
		internal static void Cross(Vector3 a, Vector3 b, ref float x, ref float y, ref float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x18E0DA0", Offset = "0x18E01A0", VA = "0x1818E0DA0")]
		internal static void Cross(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x18E0D30", Offset = "0x18E0130", VA = "0x1818E0D30")]
		internal static void Cross(float ax, float ay, float az, float bx, float by, float bz, ref float x, ref float y, ref float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x18E5970", Offset = "0x18E4D70", VA = "0x1818E5970")]
		internal static void Subtract(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class pb_MeshCompiler
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x15B6E40", Offset = "0x15B6240", VA = "0x1815B6E40")]
		public static void Compile(pb_Object pb, ref Mesh target, out Material[] materials, MeshTopology preferredTopology = MeshTopology.Triangles)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x15B7220", Offset = "0x15B6620", VA = "0x1815B7220")]
		internal static Vector2[] GetUVs(pb_Object pb)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class pb_MeshUtility
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xB9650", Offset = "0xB8A50", VA = "0x1800B9650")]
		public pb_MeshUtility()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x15B8BD0", Offset = "0x15B7FD0", VA = "0x1815B8BD0")]
		public static pb_Vertex[] GeneratePerTriangleMesh(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x15B7BC0", Offset = "0x15B6FC0", VA = "0x1815B7BC0")]
		public static void CollapseSharedVertices(Mesh m, [Optional] pb_Vertex[] vertices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x15B8F80", Offset = "0x15B8380", VA = "0x1815B8F80")]
		public static void GenerateTangent(ref Mesh InMesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x15B8460", Offset = "0x15B7860", VA = "0x1815B8460")]
		public static Mesh DeepCopy(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x15B8010", Offset = "0x15B7410", VA = "0x1815B8010")]
		public static void CopyTo(Mesh source, Mesh destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x15B84C0", Offset = "0x15B78C0", VA = "0x1815B84C0")]
		public static Vector3[] GenerateNormals(pb_Object pb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x15BB2C0", Offset = "0x15BA6C0", VA = "0x1815BB2C0")]
		public static void SmoothNormals(pb_Object pb, ref Vector3[] normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x97FB90", Offset = "0x97EF90", VA = "0x18097FB90")]
		public static T GetMeshAttribute<T>(GameObject go, Func<Mesh, T> attributeGetter) where T : IList
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x15B9C40", Offset = "0x15B9040", VA = "0x1815B9C40")]
		public static string Print(Mesh m)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x15B9A90", Offset = "0x15B8E90", VA = "0x1815B9A90")]
		public static uint GetIndexCount(Mesh m)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x15B9B50", Offset = "0x15B8F50", VA = "0x1815B9B50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1CF9930", Offset = "0x1CF8D30", VA = "0x181CF9930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static T nullableInstance
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x1CF9B50", Offset = "0x1CF8F50", VA = "0x181CF9B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA2D630", Offset = "0xA2CA30", VA = "0x180A2D630")]
		public pb_MonoBehaviourSingleton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9890", Offset = "0x1CF8C90", VA = "0x181CF9890")]
		public static bool Valid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9760", Offset = "0x1CF8B60", VA = "0x181CF9760", Slot = "4")]
		public virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9850", Offset = "0x1CF8C50", VA = "0x181CF9850", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x15C2290", Offset = "0x15C1690", VA = "0x1815C2290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x15C2530", Offset = "0x15C1930", VA = "0x1815C2530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public pb_Face[] faces
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xE1F860", Offset = "0xE1EC60", VA = "0x180E1F860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public pb_IntArray[] sharedIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xE1F880", Offset = "0xE1EC80", VA = "0x180E1F880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public pb_IntArray[] sharedIndicesUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x15C22E0", Offset = "0x15C16E0", VA = "0x1815C22E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int id
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x15C2260", Offset = "0x15C1660", VA = "0x1815C2260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3[] vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xE1F850", Offset = "0xE1EC50", VA = "0x180E1F850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Color[] colors
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x15C2070", Offset = "0x15C1470", VA = "0x1815C2070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2[] uv
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xE29670", Offset = "0xE28A70", VA = "0x180E29670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool hasUv2
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x15C2090", Offset = "0x15C1490", VA = "0x1815C2090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool hasUv3
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x15C2180", Offset = "0x15C1580", VA = "0x1815C2180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool hasUv4
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x15C21F0", Offset = "0x15C15F0", VA = "0x1815C21F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public List<Vector4> uv3
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xE20E80", Offset = "0xE20280", VA = "0x180E20E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public List<Vector4> uv4
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xE409D0", Offset = "0xE3FDD0", VA = "0x180E409D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int faceCount
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x15C2080", Offset = "0x15C1480", VA = "0x1815C2080")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int vertexCount
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x15C23C0", Offset = "0x15C17C0", VA = "0x1815C23C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int triangleCount
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x15C22F0", Offset = "0x15C16F0", VA = "0x1815C22F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public pb_Face[] SelectedFaces
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x15C2000", Offset = "0x15C1400", VA = "0x1815C2000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public int SelectedFaceCount
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x15C1FE0", Offset = "0x15C13E0", VA = "0x1815C1FE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int[] SelectedTriangles
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xE45EB0", Offset = "0xE452B0", VA = "0x180E45EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int SelectedTriangleCount
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x15C2050", Offset = "0x15C1450", VA = "0x1815C2050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public pb_Edge[] SelectedEdges
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xE45E70", Offset = "0xE45270", VA = "0x180E45E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int SelectedEdgeCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x15C1FC0", Offset = "0x15C13C0", VA = "0x1815C1FC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action<pb_Object> onDestroyObject
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x15C1E60", Offset = "0x15C1260", VA = "0x1815C1E60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x15C23D0", Offset = "0x15C17D0", VA = "0x1815C23D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		internal static event Action<pb_Object> onElementSelectionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x15C1F10", Offset = "0x15C1310", VA = "0x1815C1F10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x15C2480", Offset = "0x15C1880", VA = "0x1815C2480")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x15C1D60", Offset = "0x15C1160", VA = "0x1815C1D60")]
		public pb_Object()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x15BCE30", Offset = "0x15BC230", VA = "0x1815BCE30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x15BD960", Offset = "0x15BCD60", VA = "0x1815BD960")]
		public Vector3[] GetNormals()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x15BDC70", Offset = "0x15BD070", VA = "0x1815BDC70")]
		public pb_IntArray[] GetSharedIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x15BDA70", Offset = "0x15BCE70", VA = "0x1815BDA70")]
		public pb_IntArray[] GetSharedIndicesUV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x15BCB50", Offset = "0x15BBF50", VA = "0x1815BCB50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x15BE8C0", Offset = "0x15BDCC0", VA = "0x1815BE8C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x15BE220", Offset = "0x15BD620", VA = "0x1815BE220")]
		public static pb_Object InitWithObject(pb_Object pb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x15BD2C0", Offset = "0x15BC6C0", VA = "0x1815BD2C0")]
		internal static pb_Object CreateInstanceWithPoints(Vector3[] vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x15BD3D0", Offset = "0x15BC7D0", VA = "0x1815BD3D0")]
		public static pb_Object CreateInstanceWithVerticesFaces(Vector3[] v, pb_Face[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x15BCFA0", Offset = "0x15BC3A0", VA = "0x1815BCFA0")]
		internal static pb_Object CreateInstanceWithElements(Vector3[] v, Vector2[] u, Color[] c, pb_Face[] f, pb_IntArray[] si, pb_IntArray[] si_uv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x15BD0D0", Offset = "0x15BC4D0", VA = "0x1815BD0D0")]
		public static pb_Object CreateInstanceWithElements(pb_Vertex[] vertices, pb_Face[] faces, [Optional] pb_IntArray[] si)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x15BCAD0", Offset = "0x15BBED0", VA = "0x1815BCAD0")]
		internal void AddToFaceSelection(pb_Face face)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x15C0C50", Offset = "0x15C0050", VA = "0x1815C0C50")]
		internal void SetSelectedFaces(IEnumerable<pb_Face> selected)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x15C0E40", Offset = "0x15C0240", VA = "0x1815C0E40")]
		internal void SetSelectedFaces(IEnumerable<int> selected)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x15C0B90", Offset = "0x15BFF90", VA = "0x1815C0B90")]
		internal void SetSelectedEdges(IEnumerable<pb_Edge> edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x15C1000", Offset = "0x15C0400", VA = "0x1815C1000")]
		internal void SetSelectedTriangles(int[] tris)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x15C06C0", Offset = "0x15BFAC0", VA = "0x1815C06C0")]
		internal void RemoveFromFaceSelectionAtIndex(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x15C0720", Offset = "0x15BFB20", VA = "0x1815C0720")]
		internal void RemoveFromFaceSelection(pb_Face face)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x15BCD90", Offset = "0x15BC190", VA = "0x1815BCD90")]
		internal void ClearSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xEFDC0", Offset = "0xEF1C0", VA = "0x1800EFDC0")]
		public void SetVertices(Vector3[] v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x15C12E0", Offset = "0x15C06E0", VA = "0x1815C12E0")]
		public void SetVertices(IList<pb_Vertex> vertices, bool applyMesh = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xD3950", Offset = "0xD2D50", VA = "0x1800D3950")]
		public void SetUV(Vector2[] uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x15C09F0", Offset = "0x15BFDF0", VA = "0x1815C09F0")]
		public void SetFaces(IEnumerable<pb_Face> newFaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xF38D0", Offset = "0xF2CD0", VA = "0x1800F38D0")]
		public void SetSharedIndices(pb_IntArray[] si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x15C1110", Offset = "0x15C0510", VA = "0x1815C1110")]
		public void SetSharedIndices(IEnumerable<KeyValuePair<int, int>> si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x149250", Offset = "0x148650", VA = "0x180149250")]
		internal void SetSharedIndicesUV(pb_IntArray[] si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x15C10F0", Offset = "0x15C04F0", VA = "0x1815C10F0")]
		internal void SetSharedIndicesUV(IEnumerable<KeyValuePair<int, int>> si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x15BD480", Offset = "0x15BC880", VA = "0x1815BD480")]
		private void GeometryWithPoints(Vector3[] v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x15BD890", Offset = "0x15BCC90", VA = "0x1815BD890")]
		public void GeometryWithVerticesFaces(Vector3[] v, pb_Face[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x15C1AB0", Offset = "0x15C0EB0", VA = "0x1815C1AB0")]
		public MeshRebuildReason Verify()
		{
			return default(MeshRebuildReason);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x15C18F0", Offset = "0x15C0CF0", VA = "0x1815C18F0")]
		public void ToMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x15C1550", Offset = "0x15C0950", VA = "0x1815C1550")]
		public void ToMesh(MeshTopology preferredTopology)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x15BE5D0", Offset = "0x15BD9D0", VA = "0x1815BE5D0")]
		internal void MakeUnique()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x15C0410", Offset = "0x15BF810", VA = "0x1815C0410")]
		public void Refresh(RefreshMask mask = RefreshMask.All)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x15BE9C0", Offset = "0x15BDDC0", VA = "0x1815BE9C0")]
		private void RefreshCollisions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x15BE100", Offset = "0x15BD500", VA = "0x1815BE100")]
		internal int GetUnusedTextureGroup(int i = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x15C1990", Offset = "0x15C0D90", VA = "0x1815C1990")]
		internal int UnusedElementGroup(int i = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x15BDE70", Offset = "0x15BD270", VA = "0x1815BDE70")]
		public void GetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x15C11A0", Offset = "0x15C05A0", VA = "0x1815C11A0")]
		public void SetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x15BF550", Offset = "0x15BE950", VA = "0x1815BF550")]
		private void RefreshUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x15BF560", Offset = "0x15BE960", VA = "0x1815BF560")]
		internal void RefreshUV(IEnumerable<pb_Face> facesToRefresh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x15C0970", Offset = "0x15BFD70", VA = "0x1815C0970")]
		public void SetFaceMaterial(pb_Face[] facesToApply, Material mat)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x15C1130", Offset = "0x15C0530", VA = "0x1815C1130")]
		public void SetUV2(Vector2[] v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x15BF2B0", Offset = "0x15BE6B0", VA = "0x1815BF2B0")]
		private void RefreshColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x15C07A0", Offset = "0x15BFBA0", VA = "0x1815C07A0")]
		public void SetColors(Color[] InColors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x15C0850", Offset = "0x15BFC50", VA = "0x1815C0850")]
		public void SetFaceColor(pb_Face face, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x14CD20", Offset = "0x14C120", VA = "0x18014CD20")]
		public void SetTangents(Vector4[] tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x15BF390", Offset = "0x15BE790", VA = "0x1815BF390")]
		private void RefreshNormals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x15BF4B0", Offset = "0x15BE8B0", VA = "0x1815BF4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CFA140", Offset = "0x1CF9540", VA = "0x181CFA140")]
		public pb_ObjectPool(int initialSize, int desiredSize, Func<T> constructor, Action<T> destructor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9F00", Offset = "0x1CF9300", VA = "0x181CF9F00")]
		public T Get()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1CFA090", Offset = "0x1CF9490", VA = "0x181CFA090")]
		public void Put(T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9DC0", Offset = "0x1CF91C0", VA = "0x181CF9DC0")]
		public void Empty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9D60", Offset = "0x1CF9160", VA = "0x181CF9D60")]
		private static void DestroyObject(T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1CFA060", Offset = "0x1CF9460", VA = "0x181CFA060")]
		private void OnDestroy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class pb_ObjectUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x15BC990", Offset = "0x15BBD90", VA = "0x1815BC990")]
		public static Vector3[] VerticesInWorldSpace(this pb_Object pb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x15BC870", Offset = "0x15BBC70", VA = "0x1815BC870")]
		public static Vector3[] VerticesInWorldSpace(this pb_Object pb, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x15BC620", Offset = "0x15BBA20", VA = "0x1815BC620")]
		public static void TranslateVertices_World(this pb_Object pb, int[] selectedTriangles, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x15BBF50", Offset = "0x15BB350", VA = "0x1815BBF50")]
		public static void TranslateVertices_World(this pb_Object pb, int[] selectedTriangles, Vector3 offset, float snapValue, bool snapAxisOnly, Dictionary<int, int> lookup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x15BC670", Offset = "0x15BBA70", VA = "0x1815BC670")]
		public static void TranslateVertices(this pb_Object pb, int[] selectedTriangles, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x15BBBE0", Offset = "0x15BAFE0", VA = "0x1815BBBE0")]
		public static void SetSharedVertexPosition(this pb_Object pb, int sharedIndex, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x15BBD20", Offset = "0x15BB120", VA = "0x1815BBD20")]
		public static void SetSharedVertexValues(this pb_Object pb, int sharedIndex, pb_Vertex vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x15BBA50", Offset = "0x15BAE50", VA = "0x1815BBA50")]
		public static bool FaceWithTriangle(this pb_Object pb, int[] tri, out pb_Face face)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x15BBB30", Offset = "0x15BAF30", VA = "0x1815BBB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x15C25F0", Offset = "0x15C19F0", VA = "0x1815C25F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15C40C0", Offset = "0x15C34C0", VA = "0x1815C40C0")]
		public static Dictionary<pb_Object, HashSet<int>> PickVerticesInRect(Camera cam, Rect rect, IList<pb_Object> selectable, pb_PickerOptions options, float pixelsPerPoint = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x15C2F10", Offset = "0x15C2310", VA = "0x1815C2F10")]
		public static Dictionary<pb_Object, HashSet<pb_Face>> PickFacesInRect(Camera cam, Rect rect, IList<pb_Object> selectable, pb_PickerOptions options, float pixelsPerPoint = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x15C2650", Offset = "0x15C1A50", VA = "0x1815C2650")]
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
			[Cpp2IlInjected.Address(RVA = "0x15C45E0", Offset = "0x15C39E0", VA = "0x1815C45E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xF8030", Offset = "0xF7430", VA = "0x1800F8030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x15C4570", Offset = "0x15C3970", VA = "0x1815C4570")]
		public pb_PolyShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xE2FAB0", Offset = "0xE2EEB0", VA = "0x180E2FAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15C5840", Offset = "0x15C4C40", VA = "0x1815C5840")]
		public pb_PreferenceDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x15C50F0", Offset = "0x15C44F0", VA = "0x1815C50F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x15C4CD0", Offset = "0x15C40D0", VA = "0x1815C4CD0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x15C54D0", Offset = "0x15C48D0", VA = "0x1815C54D0", Slot = "6")]
		public void SetDefaultValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x15C4BD0", Offset = "0x15C3FD0", VA = "0x1815C4BD0")]
		public bool HasKey(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xAB3760", Offset = "0xAB2B60", VA = "0x180AB3760")]
		public bool HasKey<T>(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x15C4710", Offset = "0x15C3B10", VA = "0x1815C4710")]
		public void DeleteKey(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x97FDB0", Offset = "0x97F1B0", VA = "0x18097FDB0")]
		public T Get<T>(string key, [Optional] T fallback)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xB51400", Offset = "0xB50800", VA = "0x180B51400")]
		public void Set<T>(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x15C48B0", Offset = "0x15C3CB0", VA = "0x1815C48B0")]
		public bool GetBool(string key, bool fallback = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x15C4A50", Offset = "0x15C3E50", VA = "0x1815C4A50")]
		public int GetInt(string key, int fallback = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x15C49D0", Offset = "0x15C3DD0", VA = "0x1815C49D0")]
		public float GetFloat(string key, float fallback = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x15C4B50", Offset = "0x15C3F50", VA = "0x1815C4B50")]
		public string GetString(string key, [Optional] string fallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x15C4930", Offset = "0x15C3D30", VA = "0x1815C4930")]
		public Color GetColor(string key, [Optional] Color fallback)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x15C4AD0", Offset = "0x15C3ED0", VA = "0x1815C4AD0")]
		public Material GetMaterial(string key, [Optional] Material fallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x15C5360", Offset = "0x15C4760", VA = "0x1815C5360")]
		public void SetBool(string key, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x15C5630", Offset = "0x15C4A30", VA = "0x1815C5630")]
		public void SetInt(string key, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x15C5580", Offset = "0x15C4980", VA = "0x1815C5580")]
		public void SetFloat(string key, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x15C5790", Offset = "0x15C4B90", VA = "0x1815C5790")]
		public void SetString(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x15C5410", Offset = "0x15C4810", VA = "0x1815C5410")]
		public void SetColor(string key, Color value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x15C56E0", Offset = "0x15C4AE0", VA = "0x1815C56E0")]
		public void SetMaterial(string key, Material value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xE1F860", Offset = "0xE1EC60", VA = "0x180E1F860")]
		public Dictionary<string, bool> GetBoolDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xE1F880", Offset = "0xE1EC80", VA = "0x180E1F880")]
		public Dictionary<string, int> GetIntDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xE1F850", Offset = "0xE1EC50", VA = "0x180E1F850")]
		public Dictionary<string, float> GetFloatDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xE29670", Offset = "0xE28A70", VA = "0x180E29670")]
		public Dictionary<string, string> GetStringDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xE20E80", Offset = "0xE20280", VA = "0x180E20E80")]
		public Dictionary<string, Color> GetColorDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xE409D0", Offset = "0xE3FDD0", VA = "0x180E409D0")]
		public Dictionary<string, Material> GetMaterialDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x15C4670", Offset = "0x15C3A70", VA = "0x1815C4670")]
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
		[Cpp2IlInjected.Address(RVA = "0x15C6A60", Offset = "0x15C5E60", VA = "0x1815C6A60")]
		public static Vector2[] PlanarProject(IEnumerable<Vector3> verts, Vector3 planeNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x15C66A0", Offset = "0x15C5AA0", VA = "0x1815C66A0")]
		internal static Vector2[] PlanarProject(pb_Object pb, pb_Face face)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x15C67B0", Offset = "0x15C5BB0", VA = "0x1815C67B0")]
		internal static Vector2[] PlanarProject(IList<pb_Vertex> vertices, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x15C62C0", Offset = "0x15C56C0", VA = "0x1815C62C0")]
		internal static Vector2[] PlanarProject(Vector3[] verts, Vector3 planeNormal, ProjectionAxis projectionAxis, [Optional] int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x15C5F00", Offset = "0x15C5300", VA = "0x1815C5F00")]
		internal static void PlanarProject(Vector3[] verts, Vector2[] uvs, int[] indices, Vector3 planeNormal, ProjectionAxis projectionAxis)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x15C70F0", Offset = "0x15C64F0", VA = "0x1815C70F0")]
		internal static Vector2[] SphericalProject(IList<Vector3> vertices, [Optional] IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x15C6D20", Offset = "0x15C6120", VA = "0x1815C6D20")]
		internal static IList<Vector2> Sort(IList<Vector2> verts, SortMethod method = SortMethod.CounterClockwise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x15C6B20", Offset = "0x15C5F20", VA = "0x1815C6B20")]
		internal static Vector3 ProjectionAxisToVector(ProjectionAxis axis)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x15C7490", Offset = "0x15C6890", VA = "0x1815C7490")]
		internal static ProjectionAxis VectorToProjectionAxis(Vector3 plane)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2242390", Offset = "0x2241790", VA = "0x182242390")]
		internal static Plane FindBestPlane<T>(IList<T> points, Func<T, Vector3> selector, [Optional] IList<int> indices)
		{
			return default(Plane);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x15C5950", Offset = "0x15C4D50", VA = "0x1815C5950")]
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
		[Cpp2IlInjected.Address(RVA = "0x15C7680", Offset = "0x15C6A80", VA = "0x1815C7680")]
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
		[Cpp2IlInjected.Address(RVA = "0xF28D0", Offset = "0xF1CD0", VA = "0x1800F28D0")]
		public pb_Renderable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x15C77D0", Offset = "0x15C6BD0", VA = "0x1815C77D0")]
		public static pb_Renderable CreateInstance(Mesh InMesh, Material InMaterial, [Optional] Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x15C76F0", Offset = "0x15C6AF0", VA = "0x1815C76F0")]
		public static pb_Renderable CreateInstance()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x15C7840", Offset = "0x15C6C40", VA = "0x1815C7840")]
		public static void DestroyInstance(UnityEngine.Object ren)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x15C78A0", Offset = "0x15C6CA0", VA = "0x1815C78A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x15C7940", Offset = "0x15C6D40", VA = "0x1815C7940")]
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
			[Cpp2IlInjected.Address(RVA = "0x15CBA90", Offset = "0x15CAE90", VA = "0x1815CBA90")]
			get
			{
				return default(RenderTextureFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private static TextureFormat textureFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x15CBCB0", Offset = "0x15CB0B0", VA = "0x1815CBCB0")]
			get
			{
				return default(TextureFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x15CA2D0", Offset = "0x15C96D0", VA = "0x1815CA2D0")]
		public static Dictionary<pb_Object, HashSet<pb_Face>> PickFacesInRect(Camera camera, Rect pickerRect, IList<pb_Object> selection, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x15CA920", Offset = "0x15C9D20", VA = "0x1815CA920")]
		public static Dictionary<pb_Object, HashSet<int>> PickVerticesInRect(Camera camera, Rect pickerRect, IList<pb_Object> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x15C9C40", Offset = "0x15C9040", VA = "0x1815C9C40")]
		public static Dictionary<pb_Object, HashSet<pb_Edge>> PickEdgesInRect(Camera camera, Rect pickerRect, IList<pb_Object> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x15CB0B0", Offset = "0x15CA4B0", VA = "0x1815CB0B0")]
		private static Texture2D RenderSelectionPickerTexture(Camera camera, IList<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, pb_Face>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x15CB260", Offset = "0x15CA660", VA = "0x1815CB260")]
		private static Texture2D RenderSelectionPickerTexture(Camera camera, IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, int>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x15CAE20", Offset = "0x15CA220", VA = "0x1815CAE20")]
		private static Texture2D RenderSelectionPickerTexture(Camera camera, IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, pb_Edge>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x15C9290", Offset = "0x15C8690", VA = "0x1815C9290")]
		private static GameObject[] GenerateFacePickingObjects(IList<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, pb_Face>> map)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x15C97A0", Offset = "0x15C8BA0", VA = "0x1815C97A0")]
		private static void GenerateVertexPickingObjects(IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, int>> map, out GameObject[] depthObjects, out GameObject[] pickerObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x15C8DF0", Offset = "0x15C81F0", VA = "0x1815C8DF0")]
		private static void GenerateEdgePickingObjects(IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, pb_Edge>> map, out GameObject[] depthObjects, out GameObject[] pickerObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x15C8120", Offset = "0x15C7520", VA = "0x1815C8120")]
		private static Mesh BuildVertexMesh(pb_Object pb, Dictionary<uint, pb_Tuple<pb_Object, int>> map, ref uint index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x15C7BA0", Offset = "0x15C6FA0", VA = "0x1815C7BA0")]
		private static Mesh BuildEdgeMesh(pb_Object pb, Dictionary<uint, pb_Tuple<pb_Object, pb_Edge>> map, ref uint index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x15C8CC0", Offset = "0x15C80C0", VA = "0x1815C8CC0")]
		public static uint DecodeRGBA(Color32 color)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x15C8D50", Offset = "0x15C8150", VA = "0x1815C8D50")]
		public static Color32 EncodeRGBA(uint hash)
		{
			return default(Color32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x15CB4F0", Offset = "0x15CA8F0", VA = "0x1815CB4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15CDA70", Offset = "0x15CCE70", VA = "0x1815CDA70")]
		public static pb_Object CreateShape(pb_ShapeType shape)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x15D4DB0", Offset = "0x15D41B0", VA = "0x1815D4DB0")]
		public static pb_Object StairGenerator(Vector3 size, int steps, bool buildSides)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x15CE360", Offset = "0x15CD760", VA = "0x1815CE360")]
		public static pb_Object CurvedStairGenerator(float stairWidth, float height, float innerRadius, float circumference, int steps, bool buildSides)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x15D6170", Offset = "0x15D5570", VA = "0x1815D6170")]
		public static pb_Object StairGenerator(int steps, float width, float height, float depth, bool sidesGoToFloor, bool generateBack, bool platformsOnly)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x15CE0D0", Offset = "0x15CD4D0", VA = "0x1815CE0D0")]
		public static pb_Object CubeGenerator(Vector3 size)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x15CFE50", Offset = "0x15CF250", VA = "0x1815CFE50")]
		public static pb_Object CylinderGenerator(int axisDivisions, float radius, float height, int heightCuts, int smoothing = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x15D4050", Offset = "0x15D3450", VA = "0x1815D4050")]
		public static pb_Object PrismGenerator(Vector3 size)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x15D0D20", Offset = "0x15D0120", VA = "0x1815D0D20")]
		public static pb_Object DoorGenerator(float totalWidth, float totalHeight, float ledgeHeight, float legWidth, float depth)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x15D3FD0", Offset = "0x15D33D0", VA = "0x1815D3FD0")]
		[Obsolete]
		public static pb_Object PlaneGenerator(float _width, float _height, int widthCuts, int heightCuts, Axis axis, bool smooth)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x15D3650", Offset = "0x15D2A50", VA = "0x1815D3650")]
		public static pb_Object PlaneGenerator(float _width, float _height, int widthCuts, int heightCuts, Axis axis)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x15D2A10", Offset = "0x15D1E10", VA = "0x1815D2A10")]
		public static pb_Object PipeGenerator(float radius, float height, float thickness, int subdivAxis, int subdivHeight)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x15CD3E0", Offset = "0x15CC7E0", VA = "0x1815CD3E0")]
		public static pb_Object ConeGenerator(float radius, float height, int subdivAxis)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x15CBCC0", Offset = "0x15CB0C0", VA = "0x1815CBCC0")]
		public static pb_Object ArchGenerator(float angle, float radius, float width, float depth, int radialCuts, bool insideFaces, bool outsideFaces, bool frontFaces, bool backFaces, bool endCaps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x15D21C0", Offset = "0x15D15C0", VA = "0x1815D21C0")]
		public static pb_Object IcosahedronGenerator(float radius, int subdivisions, bool weldVertices = true, bool manualUvs = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x15D6AB0", Offset = "0x15D5EB0", VA = "0x1815D6AB0")]
		private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x15CCCB0", Offset = "0x15CC0B0", VA = "0x1815CCCB0")]
		private static Vector3[] CircleVertices(int segments, float radius, float circumference, Quaternion rotation, float offset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x15D7200", Offset = "0x15D6600", VA = "0x1815D7200")]
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
		[Cpp2IlInjected.Address(RVA = "0x15D9090", Offset = "0x15D8490", VA = "0x1815D9090")]
		public pb_Shortcut(string a, string d, KeyCode k, EventModifiers e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x15D8EA0", Offset = "0x15D82A0", VA = "0x1815D8EA0")]
		public pb_Shortcut(string str)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x15D85D0", Offset = "0x15D79D0", VA = "0x1815D85D0")]
		public bool Matches(KeyCode key, EventModifiers modifiers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x15D8530", Offset = "0x15D7930", VA = "0x1815D8530")]
		public static int IndexOf(pb_Shortcut[] shortcuts, KeyCode k, EventModifiers e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x15D80A0", Offset = "0x15D74A0", VA = "0x1815D80A0")]
		public static IEnumerable<pb_Shortcut> DefaultShortcuts()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x15D85F0", Offset = "0x15D79F0", VA = "0x1815D85F0")]
		public static IEnumerable<pb_Shortcut> ParseShortcuts(string str)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x15D8C30", Offset = "0x15D8030", VA = "0x1815D8C30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x15D87B0", Offset = "0x15D7BB0", VA = "0x1815D87B0")]
		public string Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x15D8B60", Offset = "0x15D7F60", VA = "0x1815D8B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x15D9AD0", Offset = "0x15D8ED0", VA = "0x1815D9AD0")]
		public static int GetUnusedSmoothingGroup(pb_Object pb)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x15D9A50", Offset = "0x15D8E50", VA = "0x1815D9A50")]
		private static int GetNextUnusedSmoothingGroup(int start, HashSet<int> used)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x15D9C20", Offset = "0x15D9020", VA = "0x1815D9C20")]
		public static bool IsSmooth(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x15D90E0", Offset = "0x15D84E0", VA = "0x1815D90E0")]
		public static void ApplySmoothingGroups(pb_Object pb, IEnumerable<pb_Face> faces, float angleThreshold, [Optional] Vector3[] normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x15D97D0", Offset = "0x15D8BD0", VA = "0x1815D97D0")]
		private static bool FindSoftEdgesRecursive(Vector3[] normals, pb_WingedEdge wing, float angleThreshold, HashSet<pb_Face> processed)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x15D9C40", Offset = "0x15D9040", VA = "0x1815D9C40")]
		private static bool IsSoftEdge(Vector3[] normals, pb_EdgeLookup left, pb_EdgeLookup right, float threshold)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class pb_Snap
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x15D9FA0", Offset = "0x15D93A0", VA = "0x1815D9FA0")]
		public static Vector3 SnapValue(Vector3 vertex, float snpVal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x15DA0A0", Offset = "0x15D94A0", VA = "0x1815DA0A0")]
		public static float SnapValue(float val, float snpVal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x15DA110", Offset = "0x15D9510", VA = "0x1815DA110")]
		public static Vector3 SnapValue(Vector3 vertex, Vector3 snap)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class pb_Spline
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x15DB660", Offset = "0x15DAA60", VA = "0x1815DB660")]
		internal static pb_Object Extrude(IList<pb_BezierPoint> points, float radius = 0.5f, int columns = 32, int rows = 16, bool closeLoop = false, bool smooth = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x15DB580", Offset = "0x15DA980", VA = "0x1815DB580")]
		internal static void Extrude(IList<pb_BezierPoint> bezierPoints, float radius, int columns, int rows, bool closeLoop, bool smooth, ref pb_Object target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x15DB750", Offset = "0x15DAB50", VA = "0x1815DB750")]
		internal static List<Vector3> GetControlPoints(IList<pb_BezierPoint> bezierPoints, int subdivisionsPerSegment, bool closeLoop, List<Quaternion> rotations)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x15DA320", Offset = "0x15D9720", VA = "0x1815DA320")]
		internal static void Extrude(IList<Vector3> points, float radius, int radiusRows, bool closeLoop, bool smooth, ref pb_Object target, [Optional] IList<Quaternion> pointRotations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x15DBAE0", Offset = "0x15DAEE0", VA = "0x1815DBAE0")]
		private static Quaternion GetRingRotation(IList<Vector3> points, int i, bool closeLoop, out float secant)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x15DC050", Offset = "0x15DB450", VA = "0x1815DC050")]
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
		[Cpp2IlInjected.Address(RVA = "0x15DC570", Offset = "0x15DB970", VA = "0x1815DC570")]
		public pb_Submesh(Material material, MeshTopology topology, int[] indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x15DC5C0", Offset = "0x15DB9C0", VA = "0x1815DC5C0")]
		public pb_Submesh(Mesh mesh, int subMeshIndex, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x15DC430", Offset = "0x15DB830", VA = "0x1815DC430", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x15DCA70", Offset = "0x15DBE70", VA = "0x1815DCA70")]
		public pb_Transform2D(Vector2 position, float rotation, Vector2 scale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x15DC990", Offset = "0x15DBD90", VA = "0x1815DC990")]
		public Vector2 TransformPoint(Vector2 p)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x15DC630", Offset = "0x15DBA30", VA = "0x1815DC630", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x15DCC20", Offset = "0x15DC020", VA = "0x1815DCC20")]
		public static void UnparentChildren(Transform t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x15DCAD0", Offset = "0x15DBED0", VA = "0x1815DCAD0")]
		public static void ReparentChildren(Transform t)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[DisallowMultipleComponent]
	internal class pb_TriggerBehaviour : pb_EntityBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x290BA0", Offset = "0x28FFA0", VA = "0x180290BA0")]
		public pb_TriggerBehaviour()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x15DCDF0", Offset = "0x15DC1F0", VA = "0x1815DCDF0", Slot = "4")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x15DCF30", Offset = "0x15DC330", VA = "0x1815DCF30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3C060", Offset = "0xA3B460", VA = "0x180A3C060")]
		public pb_Tuple()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1B5D310", Offset = "0x1B5C710", VA = "0x181B5D310")]
		public pb_Tuple(T1 item1, T2 item2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1CFA360", Offset = "0x1CF9760", VA = "0x181CFA360", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3C060", Offset = "0xA3B460", VA = "0x180A3C060")]
		public pb_Tuple()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x192A830", Offset = "0x1929C30", VA = "0x18192A830")]
		public pb_Tuple(T1 item1, T2 item2, T3 item3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1CFA590", Offset = "0x1CF9990", VA = "0x181CFA590", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3C060", Offset = "0xA3B460", VA = "0x180A3C060")]
		public pb_Tuple()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x1B60150", Offset = "0x1B5F550", VA = "0x181B60150")]
		public pb_Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1CFA650", Offset = "0x1CF9A50", VA = "0x181CFA650", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x15DEAC0", Offset = "0x15DDEC0", VA = "0x1815DEAC0")]
		public pb_UnwrapParameters()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x15DEAA0", Offset = "0x15DDEA0", VA = "0x1815DEAA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x394930", Offset = "0x393D30", VA = "0x180394930")]
			public SearchRange(int begin, int end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x15B6DA0", Offset = "0x15B61A0", VA = "0x1815B6DA0")]
			public bool Valid()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x15B6A70", Offset = "0x15B5E70", VA = "0x1815B6A70")]
			public int Center()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x15B6D80", Offset = "0x15B6180", VA = "0x1815B6D80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x99F570", Offset = "0x99E970", VA = "0x18099F570")]
		public static T[] GetComponents<T>(this IEnumerable<GameObject> gameObjects) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x99F530", Offset = "0x99E930", VA = "0x18099F530")]
		public static T[] GetComponents<T>(GameObject go) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x99F330", Offset = "0x99E730", VA = "0x18099F330")]
		public static T[] GetComponents<T>(this IEnumerable<Transform> transforms) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x15DF1B0", Offset = "0x15DE5B0", VA = "0x1815DF1B0")]
		public static Vector3[] ToWorldSpace(this Transform t, Vector3[] v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x15DEC80", Offset = "0x15DE080", VA = "0x1815DEC80")]
		public static GameObject EmptyGameObjectWithTransform(Transform t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x99FCC0", Offset = "0x99F0C0", VA = "0x18099FCC0")]
		public static T[] ValuesWithIndices<T>(this T[] arr, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xB70190", Offset = "0xB6F590", VA = "0x180B70190")]
		public static List<T> ValuesWithIndices<T>(this List<T> arr, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9802B0", Offset = "0x97F6B0", VA = "0x1809802B0")]
		public static T NextEnumValue<T>(this T current) where T : IConvertible
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAB3C60", Offset = "0xAB3060", VA = "0x180AB3C60")]
		public static bool IsEqual<T>(T[] a, T[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x99EE60", Offset = "0x99E260", VA = "0x18099EE60")]
		public static T[] Add<T>(this T[] arr, T val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x99ECF0", Offset = "0x99E0F0", VA = "0x18099ECF0")]
		public static T[] AddRange<T>(this T[] arr, T[] val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x99FA90", Offset = "0x99EE90", VA = "0x18099FA90")]
		public static T[] Remove<T>(this T[] arr, T val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x99FA60", Offset = "0x99EE60", VA = "0x18099FA60")]
		public static T[] Remove<T>(this T[] arr, IEnumerable<T> val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x99F900", Offset = "0x99ED00", VA = "0x18099F900")]
		public static T[] RemoveAt<T>(this T[] arr, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x99F860", Offset = "0x99EC60", VA = "0x18099F860")]
		public static T[] RemoveAt<T>(this IList<T> list, IEnumerable<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x99FB30", Offset = "0x99EF30", VA = "0x18099FB30")]
		public static T[] SortedRemoveAt<T>(this IList<T> list, IList<int> sorted_indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xBE2D30", Offset = "0xBE2130", VA = "0x180BE2D30")]
		public static int NearestIndexPriorToValue<T>(IList<T> sorted_list, T value) where T : IComparable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x99F1F0", Offset = "0x99E5F0", VA = "0x18099F1F0")]
		public static T[] Fill<T>(T val, int length)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xB700D0", Offset = "0xB6F4D0", VA = "0x180B700D0")]
		public static List<T> Fill<T>(Func<int, T> ctor, int length)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x99F2A0", Offset = "0x99E6A0", VA = "0x18099F2A0")]
		public static T[] FilledArray<T>(T val, int length)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xAB3BD0", Offset = "0xAB2FD0", VA = "0x180AB3BD0")]
		public static bool ContainsMatch<T>(this T[] a, T[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2F20", VA = "0x180AB3B20")]
		public static bool ContainsMatch<T>(this T[] a, T[] b, out int index_a, out int index_b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x99EF10", Offset = "0x99E310", VA = "0x18099EF10")]
		public static T[] Concat<T>(this T[] x, T[] y)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xBE2A50", Offset = "0xBE1E50", VA = "0x180BE2A50")]
		public static int IndexOf<T>(this List<List<T>> InList, T InValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x99F130", Offset = "0x99E530", VA = "0x18099F130")]
		public static T[] Fill<T>(int count, Func<int, T> ctor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xB517D0", Offset = "0xB50BD0", VA = "0x180B517D0")]
		public static void AddOrAppend<T, K>(this Dictionary<T, List<K>> dictionary, T key, K value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xB51730", Offset = "0xB50B30", VA = "0x180B51730")]
		public static void AddOrAppendRange<T, K>(this Dictionary<T, List<K>> dictionary, T key, List<K> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x5476D0", Offset = "0x546AD0", VA = "0x1805476D0")]
		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x10F24F0", Offset = "0x10F18F0", VA = "0x1810F24F0")]
		[Obsolete]
		public static string ToFormattedString<T>(this T[] t, string _delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x10F22A0", Offset = "0x10F16A0", VA = "0x1810F22A0")]
		[Obsolete]
		public static string ToFormattedString<T>(this T[] t, string _delimiter, int entriesPerLine, int maxEntries)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x10F2250", Offset = "0x10F1650", VA = "0x1810F2250")]
		[Obsolete]
		public static string ToFormattedString<T>(this List<T> t, string _delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x10F2210", Offset = "0x10F1610", VA = "0x1810F2210")]
		[Obsolete]
		public static string ToFormattedString<T>(this HashSet<T> t, string _delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x10F25F0", Offset = "0x10F19F0", VA = "0x1810F25F0")]
		public static string ToString<TKey, TValue>(this Dictionary<TKey, TValue> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x10F28C0", Offset = "0x10F1CC0", VA = "0x1810F28C0")]
		public static string ToString<T>(this IEnumerable<T> arr, string separator = ", ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x15DEB30", Offset = "0x15DDF30", VA = "0x1815DEB30")]
		public static string ControlKeyString(char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x15DEAF0", Offset = "0x15DDEF0", VA = "0x1815DEAF0")]
		[Obsolete]
		public static bool ColorWithString(string value, out Color col)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x15DF2E0", Offset = "0x15DE6E0", VA = "0x1815DF2E0")]
		public static bool TryParseColor(string value, ref Color col)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x15DEDC0", Offset = "0x15DE1C0", VA = "0x1815DEDC0")]
		public static Vector3[] StringToVector3Array(string str)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x15DEBD0", Offset = "0x15DDFD0", VA = "0x1815DEBD0")]
		public static Vector2 DivideBy(this Vector2 v, Vector2 o)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x15DEC20", Offset = "0x15DE020", VA = "0x1815DEC20")]
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
		[Cpp2IlInjected.Address(RVA = "0x15DE970", Offset = "0x15DDD70", VA = "0x1815DE970")]
		public pb_UV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x15DEA10", Offset = "0x15DDE10", VA = "0x1815DEA10")]
		public pb_UV(pb_UV uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x15DDFD0", Offset = "0x15DD3D0", VA = "0x1815DDFD0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x15DE070", Offset = "0x15DD470", VA = "0x1815DE070", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x15DDC90", Offset = "0x15DD090", VA = "0x1815DDC90")]
		public static void PlanarMap2(Vector3[] verts, Vector2[] uvs, int[] indices, pb_UV uvSettings, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x15DD340", Offset = "0x15DC740", VA = "0x1815DD340")]
		private static void ApplyUVSettings(Vector2[] uvs, int[] indices, pb_UV uvSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x15DDDA0", Offset = "0x15DD1A0", VA = "0x1815DDDA0")]
		private static Vector2[] StretchUVs(Vector2[] uvs, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x15DDAA0", Offset = "0x15DCEA0", VA = "0x1815DDAA0")]
		private static Vector2[] NormalizeUVs(Vector2[] uvs, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x15DD880", Offset = "0x15DCC80", VA = "0x1815DD880")]
		[Obsolete]
		private static Vector2[] JustifyUVs(Vector2[] uvs, pb_UV.Justify j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x15DCFC0", Offset = "0x15DC3C0", VA = "0x1815DCFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15DF880", Offset = "0x15DEC80", VA = "0x1815DF880")]
		private static int HashFloat(float f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x15DF7C0", Offset = "0x15DEBC0", VA = "0x1815DF7C0")]
		public static int GetHashCode(Vector2 v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x15DF6B0", Offset = "0x15DEAB0", VA = "0x1815DF6B0")]
		public static int GetHashCode(Vector3 v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x15DF550", Offset = "0x15DE950", VA = "0x1815DF550")]
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
			[Cpp2IlInjected.Address(RVA = "0xE22010", Offset = "0xE21410", VA = "0x180E22010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int minor
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x15E0CB0", Offset = "0x15E00B0", VA = "0x1815E0CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int patch
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xE1FEC0", Offset = "0xE1F2C0", VA = "0x180E1FEC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int build
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xE25A10", Offset = "0xE24E10", VA = "0x180E25A10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public VersionType type
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xE402B0", Offset = "0xE3F6B0", VA = "0x180E402B0")]
			get
			{
				return default(VersionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string metadata
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xE1F850", Offset = "0xE1EC50", VA = "0x180E1F850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string date
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xE29670", Offset = "0xE28A70", VA = "0x180E29670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public pb_VersionInfo MajorMinorPatch
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x15E0B90", Offset = "0x15DFF90", VA = "0x1815E0B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x15E09C0", Offset = "0x15DFDC0", VA = "0x1815E09C0")]
		public pb_VersionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x15E0AE0", Offset = "0x15DFEE0", VA = "0x1815E0AE0")]
		public pb_VersionInfo(string formatted, [Optional] string date)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x15E09E0", Offset = "0x15DFDE0", VA = "0x1815E09E0")]
		public pb_VersionInfo(int major, int minor, int patch, int build = -1, VersionType type = VersionType.Missing, string date = "", string metadata = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x15E0070", Offset = "0x15DF470", VA = "0x1815E0070")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x15DFBC0", Offset = "0x15DEFC0", VA = "0x1815DFBC0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x15DFD50", Offset = "0x15DF150", VA = "0x1815DFD50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x15DFAB0", Offset = "0x15DEEB0", VA = "0x1815DFAB0", Slot = "4")]
		public bool Equals(pb_VersionInfo version)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x15DF8E0", Offset = "0x15DECE0", VA = "0x1815DF8E0", Slot = "6")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x15E09B0", Offset = "0x15DFDB0", VA = "0x1815E09B0")]
		private static int WrapNoValue(int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x15DF970", Offset = "0x15DED70", VA = "0x1815DF970", Slot = "5")]
		public int CompareTo(pb_VersionInfo version)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x15E0CC0", Offset = "0x15E00C0", VA = "0x1815E0CC0")]
		public static bool operator ==(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x15E0D10", Offset = "0x15E0110", VA = "0x1815E0D10")]
		public static bool operator !=(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x15E0D50", Offset = "0x15E0150", VA = "0x1815E0D50")]
		public static bool operator <(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x15E0CE0", Offset = "0x15E00E0", VA = "0x1815E0CE0")]
		public static bool operator >(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x15E0090", Offset = "0x15DF490", VA = "0x1815E0090")]
		public string ToString(string format)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x15E03A0", Offset = "0x15DF7A0", VA = "0x1815E03A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x15E03E0", Offset = "0x15DF7E0", VA = "0x1815E03E0")]
		public static bool TryGetVersionInfo(string input, out pb_VersionInfo version)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x15DFEB0", Offset = "0x15DF2B0", VA = "0x1815DFEB0")]
		private static VersionType GetVersionType(string input)
		{
			return default(VersionType);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x15DFCA0", Offset = "0x15DF0A0", VA = "0x1815DFCA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x225BF90", Offset = "0x225B390", VA = "0x18225BF90")]
		public pb_Vertex(bool hasAllValues = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x225BFE0", Offset = "0x225B3E0", VA = "0x18225BFE0")]
		public pb_Vertex(pb_Vertex v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x2259470", Offset = "0x2258870", VA = "0x182259470", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x2259720", Offset = "0x2258B20", VA = "0x182259720", Slot = "4")]
		public bool Equals(pb_Vertex other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x2259F80", Offset = "0x2259380", VA = "0x182259F80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x225C0C0", Offset = "0x225B4C0", VA = "0x18225C0C0")]
		public static pb_Vertex operator +(pb_Vertex a, pb_Vertex b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x2258710", Offset = "0x2257B10", VA = "0x182258710")]
		public void Add(pb_Vertex b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x225C240", Offset = "0x225B640", VA = "0x18225C240")]
		public static pb_Vertex operator -(pb_Vertex a, pb_Vertex b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x225BCC0", Offset = "0x225B0C0", VA = "0x18225BCC0")]
		public void Subtract(pb_Vertex b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x225C1C0", Offset = "0x225B5C0", VA = "0x18225C1C0")]
		public static pb_Vertex operator *(pb_Vertex a, float value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x225B7F0", Offset = "0x225ABF0", VA = "0x18225B7F0")]
		public void Multiply(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x225C140", Offset = "0x225B540", VA = "0x18225C140")]
		public static pb_Vertex operator /(pb_Vertex a, float value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x2259240", Offset = "0x2258640", VA = "0x182259240")]
		public void Divide(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x225BA20", Offset = "0x225AE20", VA = "0x18225BA20")]
		public void Normalize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x225BF80", Offset = "0x225B380", VA = "0x18225BF80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x225A010", Offset = "0x2259410", VA = "0x18225A010")]
		public static pb_Vertex[] GetVertices(pb_Object pb, [Optional] IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x225A8F0", Offset = "0x2259CF0", VA = "0x18225A8F0")]
		public static pb_Vertex[] GetVertices(Mesh m)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x2259950", Offset = "0x2258D50", VA = "0x182259950")]
		public static void GetArrays(IList<pb_Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x22599C0", Offset = "0x2258DC0", VA = "0x1822599C0")]
		public static void GetArrays(IList<pb_Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4, AttributeType attributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x225BAF0", Offset = "0x225AEF0", VA = "0x18225BAF0")]
		public static void SetMesh(Mesh m, IList<pb_Vertex> vertices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x22589D0", Offset = "0x2257DD0", VA = "0x1822589D0")]
		public static pb_Vertex Average(IList<pb_Vertex> vertices, [Optional] IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x225B180", Offset = "0x225A580", VA = "0x18225B180")]
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
			[Cpp2IlInjected.Address(RVA = "0x22586C0", Offset = "0x2257AC0", VA = "0x1822586C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x249D00", Offset = "0x249100", VA = "0x180249D00")]
		public pb_VertexConnection(pb_Face face, List<int> indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2258490", Offset = "0x2257890", VA = "0x182258490")]
		public pb_VertexConnection Distinct(pb_IntArray[] sharedIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2258520", Offset = "0x2257920", VA = "0x182258520", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x18D2D30", Offset = "0x18D2130", VA = "0x1818D2D30", Slot = "4")]
		public bool Equals(pb_VertexConnection vc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x437950", Offset = "0x436D50", VA = "0x180437950")]
		public static implicit operator pb_Face(pb_VertexConnection vc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x180CFA0", Offset = "0x180C3A0", VA = "0x18180CFA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2258630", Offset = "0x2257A30", VA = "0x182258630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x22583C0", Offset = "0x22577C0", VA = "0x1822583C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB9650", Offset = "0xB8A50", VA = "0x1800B9650")]
		public pb_WingedEdge()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x225C3F0", Offset = "0x225B7F0", VA = "0x18225C3F0", Slot = "4")]
		public bool Equals(pb_WingedEdge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x225C430", Offset = "0x225B830", VA = "0x18225C430", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x225C640", Offset = "0x225BA40", VA = "0x18225C640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x225C5D0", Offset = "0x225B9D0", VA = "0x18225C5D0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x225C5D0", Offset = "0x225B9D0", VA = "0x18225C5D0")]
		public pb_WingedEdgeEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x225C3B0", Offset = "0x225B7B0", VA = "0x18225C3B0")]
		public int Count()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x225DCD0", Offset = "0x225D0D0", VA = "0x18225DCD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x225CF90", Offset = "0x225C390", VA = "0x18225CF90")]
		public static int[] MakeQuad(pb_WingedEdge left, pb_WingedEdge right)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x225C540", Offset = "0x225B940", VA = "0x18225C540")]
		public pb_WingedEdge GetAdjacentEdgeWithCommonIndex(int common)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x225DAF0", Offset = "0x225CEF0", VA = "0x18225DAF0")]
		public static List<pb_Edge> SortEdgesByAdjacency(pb_Face face)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x225DB70", Offset = "0x225CF70", VA = "0x18225DB70")]
		public static List<pb_Edge> SortEdgesByAdjacency(List<pb_Edge> edges)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x225C670", Offset = "0x225BA70", VA = "0x18225C670")]
		public static Dictionary<int, List<pb_WingedEdge>> GetSpokes(List<pb_WingedEdge> wings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x225D8D0", Offset = "0x225CCD0", VA = "0x18225D8D0")]
		public static List<int> SortCommonIndicesByAdjacency(List<pb_WingedEdge> wings, HashSet<int> common)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x225C910", Offset = "0x225BD10", VA = "0x18225C910")]
		public static List<pb_WingedEdge> GetWingedEdges(pb_Object pb, bool oneWingPerFace = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x225C960", Offset = "0x225BD60", VA = "0x18225C960")]
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
			[Cpp2IlInjected.Address(RVA = "0x225C2F0", Offset = "0x225B6F0", VA = "0x18225C2F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public pb_WingedEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x225C340", Offset = "0x225B740", VA = "0x18225C340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x225C300", Offset = "0x225B700", VA = "0x18225C300")]
		public pb_WingedEdgeEnumerator(pb_WingedEdge start)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x225C2C0", Offset = "0x225B6C0", VA = "0x18225C2C0", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x146CF10", Offset = "0x146C310", VA = "0x18146CF10", Slot = "6")]
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
