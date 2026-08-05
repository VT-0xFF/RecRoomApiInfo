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
			[Cpp2IlInjected.Address(RVA = "0xE698C0", Offset = "0xE68CC0", VA = "0x180E698C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string releaseNotes
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xE698B0", Offset = "0xE68CB0", VA = "0x180E698B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1ED210", Offset = "0x1EC610", VA = "0x1801ED210")]
		public ChangelogEntry(pb_VersionInfo version, string releaseNotes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1943250", Offset = "0x1942650", VA = "0x181943250", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x1943660", Offset = "0x1942A60", VA = "0x181943660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1943400", Offset = "0x1942800", VA = "0x181943400")]
		public Changelog(string log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x19432C0", Offset = "0x19426C0", VA = "0x1819432C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1943840", Offset = "0x1942C40", VA = "0x181943840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static pb_ActionResult NoSelection
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x19437E0", Offset = "0x1942BE0", VA = "0x1819437E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static pb_ActionResult UserCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x19438A0", Offset = "0x1942CA0", VA = "0x1819438A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3537C0", Offset = "0x352BC0", VA = "0x1803537C0")]
		public pb_ActionResult(Status status, string notification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1943900", Offset = "0x1942D00", VA = "0x181943900")]
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
		[Cpp2IlInjected.Address(RVA = "0x1944A40", Offset = "0x1943E40", VA = "0x181944A40")]
		public pb_BezierPoint(Vector3 position, Vector3 tangentIn, Vector3 tangentOut, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1943FD0", Offset = "0x19433D0", VA = "0x181943FD0")]
		public void EnforceTangentMode(pb_BezierTangentDirection master, pb_BezierTangentMode mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1944890", Offset = "0x1943C90", VA = "0x181944890")]
		public void SetPosition(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1944A00", Offset = "0x1943E00", VA = "0x181944A00")]
		public void SetTangentIn(Vector3 tangent, pb_BezierTangentMode mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1944A20", Offset = "0x1943E20", VA = "0x181944A20")]
		public void SetTangentOut(Vector3 tangent, pb_BezierTangentMode mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x19447B0", Offset = "0x1943BB0", VA = "0x1819447B0")]
		public static Vector3 QuadraticPosition(pb_BezierPoint a, pb_BezierPoint b, float t)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1943920", Offset = "0x1942D20", VA = "0x181943920")]
		public static Vector3 CubicPosition(pb_BezierPoint a, pb_BezierPoint b, float t)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1943FE0", Offset = "0x19433E0", VA = "0x181943FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1944ED0", Offset = "0x19442D0", VA = "0x181944ED0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x1252A0", Offset = "0x1246A0", VA = "0x1801252A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1944E50", Offset = "0x1944250", VA = "0x181944E50")]
		public pb_BezierShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1944A80", Offset = "0x1943E80", VA = "0x181944A80")]
		public void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1944D80", Offset = "0x1944180", VA = "0x181944D80")]
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
			[Cpp2IlInjected.Address(RVA = "0x1947620", Offset = "0x1946A20", VA = "0x181947620")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1947640", Offset = "0x1946A40", VA = "0x181947640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector2 extents
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE6A120", Offset = "0xE69520", VA = "0x180E6A120")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Vector2[] corners
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1947470", Offset = "0x1946870", VA = "0x181947470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x19469B0", Offset = "0x1945DB0", VA = "0x1819469B0")]
		public pb_Bounds2D()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x19461D0", Offset = "0x19455D0", VA = "0x1819461D0")]
		public pb_Bounds2D(Vector2 center, Vector2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1946A70", Offset = "0x1945E70", VA = "0x181946A70")]
		public pb_Bounds2D(Vector2[] points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x19468C0", Offset = "0x1945CC0", VA = "0x1819468C0")]
		public pb_Bounds2D(Vector2[] points, int[] indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1946B50", Offset = "0x1945F50", VA = "0x181946B50")]
		public pb_Bounds2D(Vector2[] points, pb_Edge[] edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x19462F0", Offset = "0x19456F0", VA = "0x1819462F0")]
		internal pb_Bounds2D(Vector3[] points, pb_Edge[] edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x19470E0", Offset = "0x19464E0", VA = "0x1819470E0")]
		public pb_Bounds2D(Vector2[] points, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x19451A0", Offset = "0x19445A0", VA = "0x1819451A0")]
		public bool ContainsPoint(Vector2 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1945200", Offset = "0x1944600", VA = "0x181945200")]
		public bool IntersectsLineSegment(Vector2 lineStart, Vector2 lineEnd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1945550", Offset = "0x1944950", VA = "0x181945550")]
		public bool Intersects(pb_Bounds2D bounds)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x19456C0", Offset = "0x1944AC0", VA = "0x1819456C0")]
		public bool Intersects(Rect rect)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1945C90", Offset = "0x1945090", VA = "0x181945C90")]
		public void SetWithPoints(IList<Vector2> points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1945820", Offset = "0x1944C20", VA = "0x181945820")]
		public void SetWithPoints(IList<Vector2> points, IList<int> indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x19450A0", Offset = "0x19444A0", VA = "0x1819450A0")]
		public static Vector2 Center(Vector2[] points, int length = -1)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1944F60", Offset = "0x1944360", VA = "0x181944F60")]
		public static Vector2 Center(Vector2[] points, int[] indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1945F50", Offset = "0x1945350", VA = "0x181945F50", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1947850", Offset = "0x1946C50", VA = "0x181947850")]
		private static OutCode ComputeOutCode(Rect rect, float x, float y)
		{
			return default(OutCode);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x19478E0", Offset = "0x1946CE0", VA = "0x1819478E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x164230", Offset = "0x163630", VA = "0x180164230")]
		public pb_ColliderBehaviour()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1947C70", Offset = "0x1947070", VA = "0x181947C70", Slot = "4")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1947F30", Offset = "0x1947330", VA = "0x181947F30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1948680", Offset = "0x1947A80", VA = "0x181948680")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1948700", Offset = "0x1947B00", VA = "0x181948700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1948630", Offset = "0x1947A30", VA = "0x181948630")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1948600", Offset = "0x1947A00", VA = "0x181948600")]
		public pb_ColorPalette()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1948040", Offset = "0x1947440", VA = "0x181948040", Slot = "4")]
		public void SetDefaultValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1947FC0", Offset = "0x19473C0", VA = "0x181947FC0")]
		public void CopyTo(pb_ColorPalette target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2547D0", Offset = "0x253BD0", VA = "0x1802547D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1947800", Offset = "0x1946C00", VA = "0x181947800")]
		public pb_HsvColor(float h, float s, float v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x19660A0", Offset = "0x19654A0", VA = "0x1819660A0")]
		public pb_HsvColor(float h, float s, float v, float sv_modifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1965F40", Offset = "0x1965340", VA = "0x181965F40")]
		public static pb_HsvColor FromRGB(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1965FF0", Offset = "0x19653F0", VA = "0x181965FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1965FA0", Offset = "0x19653A0", VA = "0x181965FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1947800", Offset = "0x1946C00", VA = "0x181947800")]
		public pb_XYZ_Color(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2332490", Offset = "0x2331890", VA = "0x182332490")]
		public static pb_XYZ_Color FromRGB(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2332400", Offset = "0x2331800", VA = "0x182332400")]
		public static pb_XYZ_Color FromRGB(float R, float G, float B)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x23324F0", Offset = "0x23318F0", VA = "0x1823324F0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1947800", Offset = "0x1946C00", VA = "0x181947800")]
		public pb_CIE_Lab_Color(float L, float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x19476F0", Offset = "0x1946AF0", VA = "0x1819476F0")]
		public static pb_CIE_Lab_Color FromXYZ(pb_XYZ_Color xyz)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1947680", Offset = "0x1946A80", VA = "0x181947680")]
		public static pb_CIE_Lab_Color FromRGB(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1947750", Offset = "0x1946B50", VA = "0x181947750", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x195ED10", Offset = "0x195E110", VA = "0x18195ED10")]
		private static bool approx(float lhs, float rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1948F50", Offset = "0x1948350", VA = "0x181948F50")]
		public static pb_XYZ_Color RGBToXYZ(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1948FC0", Offset = "0x19483C0", VA = "0x181948FC0")]
		public static pb_XYZ_Color RGBToXYZ(float r, float g, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1949460", Offset = "0x1948860", VA = "0x181949460")]
		public static pb_CIE_Lab_Color XYZToCIE_Lab(pb_XYZ_Color xyz)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1948800", Offset = "0x1947C00", VA = "0x181948800")]
		public static float DeltaE(pb_CIE_Lab_Color lhs, pb_CIE_Lab_Color rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1948BB0", Offset = "0x1947FB0", VA = "0x181948BB0")]
		public static Color HSVtoRGB(pb_HsvColor hsv)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1948DB0", Offset = "0x19481B0", VA = "0x181948DB0")]
		public static Color HSVtoRGB(float h, float s, float v)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x19491D0", Offset = "0x19485D0", VA = "0x1819491D0")]
		public static pb_HsvColor RGBtoHSV(Color color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1948900", Offset = "0x1947D00", VA = "0x181948900")]
		public static string GetColorName(Color InColor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1948770", Offset = "0x1947B70", VA = "0x181948770")]
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
			[Cpp2IlInjected.Address(RVA = "0x195EF10", Offset = "0x195E310", VA = "0x18195EF10")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C24C0", Offset = "0x1C18C0", VA = "0x1801C24C0")]
		public pb_Edge(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1960A40", Offset = "0x195FE40", VA = "0x181960A40")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1960D70", Offset = "0x1960170", VA = "0x181960D70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x19609B0", Offset = "0x195FDB0", VA = "0x1819609B0", Slot = "4")]
		public bool Equals(pb_Edge edge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x19608B0", Offset = "0x195FCB0", VA = "0x1819608B0", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1960A10", Offset = "0x195FE10", VA = "0x181960A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1960DF0", Offset = "0x19601F0", VA = "0x181960DF0")]
		public static pb_Edge operator +(pb_Edge a, pb_Edge b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1960EE0", Offset = "0x19602E0", VA = "0x181960EE0")]
		public static pb_Edge operator -(pb_Edge a, pb_Edge b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1960DD0", Offset = "0x19601D0", VA = "0x181960DD0")]
		public static pb_Edge operator +(pb_Edge a, int b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1960F00", Offset = "0x1960300", VA = "0x181960F00")]
		public static pb_Edge operator -(pb_Edge a, int b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1960E10", Offset = "0x1960210", VA = "0x181960E10")]
		public static bool operator ==(pb_Edge a, pb_Edge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1960E40", Offset = "0x1960240", VA = "0x181960E40")]
		public static bool operator !=(pb_Edge a, pb_Edge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1960A60", Offset = "0x195FE60", VA = "0x181960A60")]
		public int[] ToArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x19607E0", Offset = "0x195FBE0", VA = "0x1819607E0")]
		public bool Equals(pb_Edge b, Dictionary<int, int> lookup)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x19606F0", Offset = "0x195FAF0", VA = "0x1819606F0")]
		public bool Contains(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1960590", Offset = "0x195F990", VA = "0x181960590")]
		public bool Contains(pb_Edge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x19605C0", Offset = "0x195F9C0", VA = "0x1819605C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x195F350", Offset = "0x195E750", VA = "0x18195F350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1ED210", Offset = "0x1EC610", VA = "0x1801ED210")]
		public pb_EdgeConnection(pb_Face face, List<pb_Edge> edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x195F1A0", Offset = "0x195E5A0", VA = "0x18195F1A0", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x195F170", Offset = "0x195E570", VA = "0x18195F170", Slot = "4")]
		public bool Equals(pb_EdgeConnection fc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4DCE80", Offset = "0x4DC280", VA = "0x1804DCE80")]
		public static explicit operator pb_Face(pb_EdgeConnection fc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x195F2B0", Offset = "0x195E6B0", VA = "0x18195F2B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x195F2C0", Offset = "0x195E6C0", VA = "0x18195F2C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x195EF20", Offset = "0x195E320", VA = "0x18195EF20")]
		public static List<int> AllTriangles(List<pb_EdgeConnection> ec)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class pb_EdgeExtension
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x195F870", Offset = "0x195EC70", VA = "0x18195F870")]
		public static pb_Edge[] GetUniversalEdges(pb_Edge[] edges, Dictionary<int, int> sharedIndicesLookup)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x195F9A0", Offset = "0x195EDA0", VA = "0x18195F9A0")]
		public static pb_Edge[] GetUniversalEdges(pb_Edge[] edges, pb_IntArray[] sharedIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x195F7B0", Offset = "0x195EBB0", VA = "0x18195F7B0")]
		internal static pb_Edge GetLocalEdgeFast(pb_Edge edge, pb_IntArray[] sharedIndices)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x195FC10", Offset = "0x195F010", VA = "0x18195FC10")]
		public static bool ValidateEdge(pb_Object pb, pb_Edge edge, out pb_Tuple<pb_Face, pb_Edge> validEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x195F3A0", Offset = "0x195E7A0", VA = "0x18195F3A0")]
		internal static pb_Edge[] AllEdges(pb_Face[] faces)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x195F730", Offset = "0x195EB30", VA = "0x18195F730")]
		internal static bool Contains(this pb_Edge[] edges, pb_Edge edge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x195F690", Offset = "0x195EA90", VA = "0x18195F690")]
		internal static bool Contains(this pb_Edge[] edges, int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x195FAE0", Offset = "0x195EEE0", VA = "0x18195FAE0")]
		internal static int IndexOf(this IList<pb_Edge> edges, pb_Edge edge, Dictionary<int, int> lookup)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x195F480", Offset = "0x195E880", VA = "0x18195F480")]
		internal static int[] AllTriangles(this pb_Edge[] edges)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x195F5A0", Offset = "0x195E9A0", VA = "0x18195F5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1960550", Offset = "0x195F950", VA = "0x181960550")]
		public pb_EdgeLookup(pb_Edge common, pb_Edge local)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x19604E0", Offset = "0x195F8E0", VA = "0x1819604E0")]
		public pb_EdgeLookup(int cx, int cy, int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x195FF90", Offset = "0x195F390", VA = "0x18195FF90", Slot = "4")]
		public bool Equals(pb_EdgeLookup b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1960050", Offset = "0x195F450", VA = "0x181960050", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1960420", Offset = "0x195F820", VA = "0x181960420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1960450", Offset = "0x195F850", VA = "0x181960450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1960360", Offset = "0x195F760", VA = "0x181960360")]
		public static IEnumerable<pb_EdgeLookup> GetEdgeLookup(IEnumerable<pb_Edge> edges, Dictionary<int, int> lookup)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1960120", Offset = "0x195F520", VA = "0x181960120")]
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
			[Cpp2IlInjected.Address(RVA = "0xE69F10", Offset = "0xE69310", VA = "0x180E69F10")]
			get
			{
				return default(EntityType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xBD060", Offset = "0xBC460", VA = "0x1800BD060")]
		public pb_Entity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1961080", Offset = "0x1960480", VA = "0x181961080")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1C2440", Offset = "0x1C1840", VA = "0x1801C2440")]
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
		[Cpp2IlInjected.Address(RVA = "0x164230", Offset = "0x163630", VA = "0x180164230")]
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
		[Cpp2IlInjected.Address(RVA = "0x1960F20", Offset = "0x1960320", VA = "0x181960F20")]
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
			[Cpp2IlInjected.Address(RVA = "0xE698C0", Offset = "0xE68CC0", VA = "0x180E698C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int[] distinctIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x1963800", Offset = "0x1962C00", VA = "0x181963800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public pb_Edge[] edges
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1963820", Offset = "0x1962C20", VA = "0x181963820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int smoothingGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE69510", VA = "0x180E6A110")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x2B1070", Offset = "0x2B0470", VA = "0x1802B1070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material material
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xE6AED0", Offset = "0xE6A2D0", VA = "0x180E6AED0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x1252A0", Offset = "0x1246A0", VA = "0x1801252A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public pb_UV uv
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xE736A0", Offset = "0xE72AA0", VA = "0x180E736A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x10F220", Offset = "0x10E620", VA = "0x18010F220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x151CDF0", Offset = "0x151C1F0", VA = "0x18151CDF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1963730", Offset = "0x1962B30", VA = "0x181963730")]
		public pb_Face()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1963690", Offset = "0x1962A90", VA = "0x181963690")]
		public pb_Face(int[] i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1963740", Offset = "0x1962B40", VA = "0x181963740")]
		public pb_Face(int[] i, Material m, pb_UV u, int smoothingGroup, int textureGroup, int elementGroup, bool manualUV)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1963570", Offset = "0x1962970", VA = "0x181963570")]
		public pb_Face(pb_Face face)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1961D20", Offset = "0x1961120", VA = "0x181961D20")]
		public void CopyFrom(pb_Face other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1962800", Offset = "0x1961C00", VA = "0x181962800")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1961E20", Offset = "0x1961220", VA = "0x181961E20")]
		public pb_Edge[] GetAllEdges()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1962880", Offset = "0x1961C80", VA = "0x181962880")]
		public void SetIndices(int[] i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1962A90", Offset = "0x1961E90", VA = "0x181962A90")]
		public void ShiftIndices(int offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1962B00", Offset = "0x1961F00", VA = "0x181962B00")]
		public int SmallestIndexValue()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x19628B0", Offset = "0x1961CB0", VA = "0x1819628B0")]
		public void ShiftIndicesToZero()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1962850", Offset = "0x1961C50", VA = "0x181962850")]
		public void ReverseIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1962830", Offset = "0x1961C30", VA = "0x181962830")]
		public void RebuildCaches()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1961980", Offset = "0x1960D80", VA = "0x181961980")]
		private pb_Edge[] CacheEdges()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x19618E0", Offset = "0x1960CE0", VA = "0x1819618E0")]
		private int[] CacheDistinctIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1961BD0", Offset = "0x1960FD0", VA = "0x181961BD0")]
		public bool Contains(int[] triangle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1961800", Offset = "0x1960C00", VA = "0x181961800")]
		internal static int[] AllTriangles(pb_Face[] q)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1962B90", Offset = "0x1961F90", VA = "0x181962B90")]
		public MeshTopology ToQuadOrTriangles(out int[] quadOrTris)
		{
			return default(MeshTopology);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1962CA0", Offset = "0x19620A0", VA = "0x181962CA0")]
		public int[] ToQuad()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1962CD0", Offset = "0x19620D0", VA = "0x181962CD0")]
		public bool ToQuad(out int[] quad)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1962060", Offset = "0x1961460", VA = "0x181962060")]
		public static int GetMeshIndices(pb_Face[] faces, out pb_Submesh[] submeshes, MeshTopology preferredTopology = MeshTopology.Triangles)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1963360", Offset = "0x1962760", VA = "0x181963360", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x19617F0", Offset = "0x1960BF0", VA = "0x1819617F0")]
		public pb_FaceRebuildData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1961750", Offset = "0x1960B50", VA = "0x181961750")]
		public int Offset()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1961760", Offset = "0x1960B60", VA = "0x181961760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1961130", Offset = "0x1960530", VA = "0x181961130")]
		public static void Apply(IEnumerable<pb_FaceRebuildData> newFaces, pb_Object pb, [Optional] List<pb_Vertex> vertices, [Optional] List<pb_Face> faces, [Optional] Dictionary<int, int> lookup, [Optional] Dictionary<int, int> lookupUV)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x19612F0", Offset = "0x19606F0", VA = "0x1819612F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x25C560", Offset = "0x25B960", VA = "0x18025C560")]
		public pb_HandleConstraint2D(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1963A20", Offset = "0x1962E20", VA = "0x181963A20")]
		public pb_HandleConstraint2D Inverse()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x1963AA0", Offset = "0x1962EA0", VA = "0x181963AA0")]
		public Vector2 Mask(Vector2 v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x19639D0", Offset = "0x1962DD0", VA = "0x1819639D0")]
		public Vector2 InverseMask(Vector2 v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1963DA0", Offset = "0x19631A0", VA = "0x181963DA0")]
		public static bool operator ==(pb_HandleConstraint2D a, pb_HandleConstraint2D b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1963DE0", Offset = "0x19631E0", VA = "0x181963DE0")]
		public static bool operator !=(pb_HandleConstraint2D a, pb_HandleConstraint2D b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x195F2B0", Offset = "0x195E6B0", VA = "0x18195F2B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1963840", Offset = "0x1962C40", VA = "0x181963840", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1963AD0", Offset = "0x1962ED0", VA = "0x181963AD0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1965B60", Offset = "0x1964F60", VA = "0x181965B60")]
		public static Vector3 ScreenToGuiPoint(this Camera camera, Vector3 point, float pixelsPerPoint)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1964FE0", Offset = "0x19643E0", VA = "0x181964FE0")]
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out pb_RaycastHit hit, [Optional] HashSet<pb_Face> ignore)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1963E20", Offset = "0x1963220", VA = "0x181963E20")]
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out pb_RaycastHit hit, float distance, pb_Culling cullingMode, [Optional] HashSet<pb_Face> ignore)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x19646E0", Offset = "0x1963AE0", VA = "0x1819646E0")]
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out List<pb_RaycastHit> hits, float distance, pb_Culling cullingMode, [Optional] HashSet<pb_Face> ignore)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1965040", Offset = "0x1964440", VA = "0x181965040")]
		public static Ray InverseTransformRay(this Transform transform, Ray InWorldRay)
		{
			return default(Ray);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1965BF0", Offset = "0x1964FF0", VA = "0x181965BF0")]
		public static bool WorldRaycast(Ray InWorldRay, Transform transform, Vector3[] vertices, int[] triangles, out pb_RaycastHit hit, float distance = float.PositiveInfinity, pb_Culling cullingMode = pb_Culling.Front)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x19655F0", Offset = "0x19649F0", VA = "0x1819655F0")]
		public static bool MeshRaycast(Ray InRay, Vector3[] vertices, int[] triangles, out pb_RaycastHit hit, float distance = float.PositiveInfinity, pb_Culling cullingMode = pb_Culling.Front)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x19658F0", Offset = "0x1964CF0", VA = "0x1819658F0")]
		internal static bool PointIsOccluded(Camera cam, pb_Object pb, Vector3 worldPoint)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1965350", Offset = "0x1964750", VA = "0x181965350")]
		internal static bool IsOccluded(Camera cam, pb_Object pb, pb_Face face)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal class ProGridsNoSnapAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xCD180", Offset = "0xCC580", VA = "0x1800CD180")]
		public ProGridsNoSnapAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class ProGridsConditionalSnapAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xCD180", Offset = "0xCC580", VA = "0x1800CD180")]
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
			[Cpp2IlInjected.Address(RVA = "0x151CDF0", Offset = "0x151C1F0", VA = "0x18151CDF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x19689B0", Offset = "0x1967DB0", VA = "0x1819689B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xD9EE30", Offset = "0xD9E230", VA = "0x180D9EE30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1CE980", Offset = "0x1CDD80", VA = "0x1801CE980")]
		public pb_IntArray(int[] intArray)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x19688A0", Offset = "0x1967CA0", VA = "0x1819688A0")]
		public pb_IntArray(pb_IntArray intArray)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x19687F0", Offset = "0x1967BF0", VA = "0x1819687F0")]
		internal List<int> ToList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4DCE80", Offset = "0x4DC280", VA = "0x1804DCE80")]
		public static implicit operator int[](pb_IntArray intArr)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1968950", Offset = "0x1967D50", VA = "0x181968950")]
		public static explicit operator pb_IntArray(int[] arr)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1968850", Offset = "0x1967C50", VA = "0x181968850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x19686E0", Offset = "0x1967AE0", VA = "0x1819686E0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1968700", Offset = "0x1967B00", VA = "0x181968700")]
		public static void RemoveEmptyOrNull(ref pb_IntArray[] val)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class pb_IntArrayUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x19678B0", Offset = "0x1966CB0", VA = "0x1819678B0")]
		public static int[][] ToArray(this pb_IntArray[] val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x19679D0", Offset = "0x1966DD0", VA = "0x1819679D0")]
		public static Dictionary<int, int> ToDictionary(this pb_IntArray[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1967DE0", Offset = "0x19671E0", VA = "0x181967DE0")]
		public static pb_IntArray[] ToSharedIndices(this IEnumerable<KeyValuePair<int, int>> lookup)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1967C90", Offset = "0x1967090", VA = "0x181967C90")]
		public static pb_IntArray[] ToPbIntArray(this int[][] val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1967B20", Offset = "0x1966F20", VA = "0x181967B20")]
		public static pb_IntArray[] ToPbIntArray(this List<List<int>> val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1966C50", Offset = "0x1966050", VA = "0x181966C50")]
		public static int IndexOf(this pb_IntArray[] intArray, int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1966350", Offset = "0x1965750", VA = "0x181966350")]
		public static List<int> AllIndicesWithValues(this pb_IntArray[] pbIntArr, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1966470", Offset = "0x1965870", VA = "0x181966470")]
		public static List<int> AllIndicesWithValues(this pb_IntArray[] pbIntArr, Dictionary<int, int> lookup, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1968320", Offset = "0x1967720", VA = "0x181968320")]
		internal static List<int> UniqueIndicesWithValues(this pb_IntArray[] pbIntArr, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1966B60", Offset = "0x1965F60", VA = "0x181966B60")]
		internal static HashSet<int> GetCommonIndices(this pb_IntArray[] pbIntArr, IEnumerable<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1966970", Offset = "0x1965D70", VA = "0x181966970")]
		internal static HashSet<int> GetCommonIndices(Dictionary<int, int> lookup, IEnumerable<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1966B90", Offset = "0x1965F90", VA = "0x181966B90")]
		[Obsolete]
		internal static IEnumerable<int> GetIndicesWithCommon(this pb_IntArray[] pbIntArr, IEnumerable<int> common)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1966580", Offset = "0x1965980", VA = "0x181966580")]
		public static pb_IntArray[] ExtractSharedIndices(Vector3[] v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1966F20", Offset = "0x1966320", VA = "0x181966F20")]
		internal static int MergeSharedIndices(ref pb_IntArray[] sharedIndices, int[] indices)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1966D10", Offset = "0x1966110", VA = "0x181966D10")]
		internal static void MergeSharedIndices(ref pb_IntArray[] sharedIndices, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1966210", Offset = "0x1965610", VA = "0x181966210")]
		internal static int AddValueAtIndex(ref pb_IntArray[] sharedIndices, int sharedIndex, int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1966110", Offset = "0x1965510", VA = "0x181966110")]
		internal static int AddRangeAtIndex(ref pb_IntArray[] sharedIndices, int sharedIndex, int[] indices)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1967730", Offset = "0x1966B30", VA = "0x181967730")]
		internal static void RemoveValues(ref pb_IntArray[] sharedIndices, int[] remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1967320", Offset = "0x1966720", VA = "0x181967320")]
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
			[Cpp2IlInjected.Address(RVA = "0xE79960", Offset = "0xE78D60", VA = "0x180E79960")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float y
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x18A4330", Offset = "0x18A3730", VA = "0x1818A4330")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float z
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xE79980", Offset = "0xE78D80", VA = "0x180E79980")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x14B31D0", Offset = "0x14B25D0", VA = "0x1814B31D0")]
		public pb_IntVec3(Vector3 vector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1969070", Offset = "0x1968470", VA = "0x181969070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1969120", Offset = "0x1968520", VA = "0x181969120")]
		public static bool operator ==(pb_IntVec3 a, pb_IntVec3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1969170", Offset = "0x1968570", VA = "0x181969170")]
		public static bool operator !=(pb_IntVec3 a, pb_IntVec3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1968DF0", Offset = "0x19681F0", VA = "0x181968DF0", Slot = "4")]
		public bool Equals(pb_IntVec3 p)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1968FE0", Offset = "0x19683E0", VA = "0x181968FE0")]
		public bool Equals(Vector3 p)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1968B10", Offset = "0x1967F10", VA = "0x181968B10", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1969040", Offset = "0x1968440", VA = "0x181969040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x19691C0", Offset = "0x19685C0", VA = "0x1819691C0")]
		private static int round(float v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1969150", Offset = "0x1968550", VA = "0x181969150")]
		public static implicit operator Vector3(pb_IntVec3 p)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1969150", Offset = "0x1968550", VA = "0x181969150")]
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
		[Cpp2IlInjected.Address(RVA = "0x1969DA0", Offset = "0x19691A0", VA = "0x181969DA0")]
		public pb_LineRenderer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1969770", Offset = "0x1968B70", VA = "0x181969770")]
		private static Mesh MeshConstructor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x19699E0", Offset = "0x1968DE0", VA = "0x1819699E0", Slot = "5")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1969990", Offset = "0x1968D90", VA = "0x181969990")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x19695A0", Offset = "0x19689A0", VA = "0x1819695A0", Slot = "4")]
		public override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x19697F0", Offset = "0x1968BF0", VA = "0x1819697F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1969230", Offset = "0x1968630", VA = "0x181969230")]
		public void AddLineSegments(Vector3[] segments, Color[] colors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x19696B0", Offset = "0x1968AB0", VA = "0x1819696B0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1969AE0", Offset = "0x1968EE0", VA = "0x181969AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x196A6D0", Offset = "0x1969AD0", VA = "0x18196A6D0")]
		public static void PushLogLevel(pb_LogLevel level)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x196A2C0", Offset = "0x19696C0", VA = "0x18196A2C0")]
		public static void PopLogLevel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x196A7C0", Offset = "0x1969BC0", VA = "0x18196A7C0")]
		public static void SetLogLevel(pb_LogLevel level)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x196A820", Offset = "0x1969C20", VA = "0x18196A820")]
		public static void SetOutput(pb_LogOutput output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x196A760", Offset = "0x1969B60", VA = "0x18196A760")]
		public static void SetLogFile(string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xBC220", Offset = "0xBB620", VA = "0x1800BC220")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public static void Debug<T>(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1969EC0", Offset = "0x19692C0", VA = "0x181969EC0")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public static void Debug(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xBC220", Offset = "0xBB620", VA = "0x1800BC220")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public static void Debug(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x196A140", Offset = "0x1969540", VA = "0x18196A140")]
		public static void Info(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x196A230", Offset = "0x1969630", VA = "0x18196A230")]
		public static void Info(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x196A910", Offset = "0x1969D10", VA = "0x18196A910")]
		public static void Warning(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x196A880", Offset = "0x1969C80", VA = "0x18196A880")]
		public static void Warning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x196A030", Offset = "0x1969430", VA = "0x18196A030")]
		public static void Error(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x196A0B0", Offset = "0x19694B0", VA = "0x18196A0B0")]
		public static void Error(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x10ABBC0", Offset = "0x10AAFC0", VA = "0x1810ABBC0")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		internal static void Watch<T, K>(T key, K value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1969F20", Offset = "0x1969320", VA = "0x181969F20")]
		private static void DoPrint(string message, LogType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x196A420", Offset = "0x1969820", VA = "0x18196A420")]
		private static void PrintToFile(string message, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1969E10", Offset = "0x1969210", VA = "0x181969E10")]
		public static void ClearLogFile()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x196A340", Offset = "0x1969740", VA = "0x18196A340")]
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
			[Cpp2IlInjected.Address(RVA = "0x196B1C0", Offset = "0x196A5C0", VA = "0x18196B1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static Material DefaultMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x196AB60", Offset = "0x1969F60", VA = "0x18196AB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal static Material FacePickerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x196AF60", Offset = "0x196A360", VA = "0x18196AF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal static Material VertexPickerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x196B650", Offset = "0x196AA50", VA = "0x18196B650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		internal static Material EdgePickerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x196AD90", Offset = "0x196A190", VA = "0x18196AD90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal static Material TriggerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x196B260", Offset = "0x196A660", VA = "0x18196B260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal static Material ColliderMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x196AAA0", Offset = "0x1969EA0", VA = "0x18196AAA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x196B100", Offset = "0x196A500", VA = "0x18196B100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal static Material UnityDefaultDiffuse
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x196B320", Offset = "0x196A720", VA = "0x18196B320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		internal static Material UnlitVertexColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x196B520", Offset = "0x196A920", VA = "0x18196B520")]
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
		[Cpp2IlInjected.Address(RVA = "0x196FF50", Offset = "0x196F350", VA = "0x18196FF50")]
		public static Vector2 PointInCircumference(float radius, float angleInDegrees, Vector2 origin)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1970760", Offset = "0x196FB60", VA = "0x181970760")]
		internal static Vector3 PointInSphere(float radius, float latitudeAngle, float longitudeAngle)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1971AC0", Offset = "0x1970EC0", VA = "0x181971AC0")]
		public static float SignedAngle(Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1971D50", Offset = "0x1971150", VA = "0x181971D50")]
		public static float SqrDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1972230", Offset = "0x1971630", VA = "0x181972230")]
		public static float TriangleArea(Vector3 x, Vector3 y, Vector3 z)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1970890", Offset = "0x196FC90", VA = "0x181970890")]
		internal static float PolygonArea(Vector3[] vertices, int[] indices)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x19718B0", Offset = "0x1970CB0", VA = "0x1819718B0")]
		internal static Vector2 RotateAroundPoint(this Vector2 v, Vector2 origin, float theta)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x19719A0", Offset = "0x1970DA0", VA = "0x1819719A0")]
		public static Vector2 ScaleAroundPoint(this Vector2 v, Vector2 origin, Vector2 scale)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x196FEA0", Offset = "0x196F2A0", VA = "0x18196FEA0")]
		internal static Vector2 Perpendicular(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x196FF00", Offset = "0x196F300", VA = "0x18196FF00")]
		public static Vector2 Perpendicular(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x19716D0", Offset = "0x1970AD0", VA = "0x1819716D0")]
		public static Vector2 ReflectPoint(Vector2 point, Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x196D220", Offset = "0x196C620", VA = "0x18196D220")]
		public static float DistancePointLineSegment(Vector2 p, Vector2 v, Vector2 w)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x196D430", Offset = "0x196C830", VA = "0x18196D430")]
		public static float DistancePointLineSegment(Vector3 p, Vector3 v, Vector3 w)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x196D9F0", Offset = "0x196CDF0", VA = "0x18196D9F0")]
		public static Vector3 GetNearestPointRayRay(Vector3 ao, Vector3 ad, Vector3 bo, Vector3 bd)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x196D850", Offset = "0x196CC50", VA = "0x18196D850")]
		internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, ref Vector2 intersect)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x196D760", Offset = "0x196CB60", VA = "0x18196D760")]
		internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1970010", Offset = "0x196F410", VA = "0x181970010")]
		internal static bool PointInPolygon(Vector2[] polygon, Vector2 point, [Optional] int[] indices)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x19703A0", Offset = "0x196F7A0", VA = "0x1819703A0")]
		internal static bool PointInPolygon(Vector2[] positions, pb_Bounds2D polyBounds, pb_Edge[] edges, Vector2 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1970530", Offset = "0x196F930", VA = "0x181970530")]
		internal static bool PointInPolygon(Vector3[] positions, pb_Bounds2D polyBounds, pb_Edge[] edges, Vector2 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1971670", Offset = "0x1970A70", VA = "0x181971670")]
		internal static bool RectIntersectsLineSegment(Rect rect, Vector2 a, Vector2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1971620", Offset = "0x1970A20", VA = "0x181971620")]
		internal static bool RectIntersectsLineSegment(Rect rect, Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1971100", Offset = "0x1970500", VA = "0x181971100")]
		public static bool RayIntersectsTriangle(Ray InRay, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, out float OutDistance, out Vector3 OutPoint)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1970BC0", Offset = "0x196FFC0", VA = "0x181970BC0")]
		internal static bool RayIntersectsTriangle2(Vector3 origin, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, ref float distance, ref Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1971A50", Offset = "0x1970E50", VA = "0x181971A50")]
		public static float Secant(float x)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x196EED0", Offset = "0x196E2D0", VA = "0x18196EED0")]
		public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x196F440", Offset = "0x196E840", VA = "0x18196F440")]
		internal static Vector3 Normal(IList<pb_Vertex> vertices, [Optional] IList<int> indices)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x196F0C0", Offset = "0x196E4C0", VA = "0x18196F0C0")]
		public static Vector3 Normal(pb_Object pb, pb_Face face)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x196F950", Offset = "0x196ED50", VA = "0x18196F950")]
		public static Vector3 Normal(IList<Vector3> p)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x196E2F0", Offset = "0x196D6F0", VA = "0x18196E2F0")]
		public static void NormalTangentBitangent(pb_Object pb, pb_Face face, out Vector3 normal, out Vector3 tangent, out Vector3 bitangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x196DE50", Offset = "0x196D250", VA = "0x18196DE50")]
		internal static bool IsCardinalAxis(Vector3 v, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9A25E0", Offset = "0x9A19E0", VA = "0x1809A25E0")]
		internal static T Max<T>(T[] array) where T : IComparable<T>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9A2760", Offset = "0x9A1B60", VA = "0x1809A2760")]
		internal static T Min<T>(T[] array) where T : IComparable<T>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x196E0C0", Offset = "0x196D4C0", VA = "0x18196E0C0")]
		internal static float LargestValue(Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x196E0F0", Offset = "0x196D4F0", VA = "0x18196E0F0")]
		internal static float LargestValue(Vector2 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1971B70", Offset = "0x1970F70", VA = "0x181971B70")]
		internal static Vector2 SmallestVector2(Vector2[] v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1971C20", Offset = "0x1971020", VA = "0x181971C20")]
		internal static Vector2 SmallestVector2(Vector2[] v, int[] indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x196E240", Offset = "0x196D640", VA = "0x18196E240")]
		internal static Vector2 LargestVector2(Vector2[] v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x196E110", Offset = "0x196D510", VA = "0x18196E110")]
		internal static Vector2 LargestVector2(Vector2[] v, int[] indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x196CD10", Offset = "0x196C110", VA = "0x18196CD10")]
		internal static Vector3 BoundsCenter(Vector3[] verts)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x196C190", Offset = "0x196B590", VA = "0x18196C190")]
		public static Vector2 Average(IList<Vector2> v, [Optional] IList<int> indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x196C3A0", Offset = "0x196B7A0", VA = "0x18196C3A0")]
		public static Vector3 Average(IList<Vector3> v, [Optional] IList<int> indices)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xE39880", Offset = "0xE38C80", VA = "0x180E39880")]
		public static Vector3 Average<T>(this IList<T> v, Func<T, Vector3> selector, [Optional] IList<int> indices)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x196CA80", Offset = "0x196BE80", VA = "0x18196CA80")]
		internal static Vector4 Average(IList<Vector4> v, [Optional] IList<int> indices)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x196BE00", Offset = "0x196B200", VA = "0x18196BE00")]
		internal static Color Average(IList<Color> c, [Optional] IList<int> indices)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x196B8E0", Offset = "0x196ACE0", VA = "0x18196B8E0")]
		public static bool Approx2(this Vector2 v, Vector2 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x196B9B0", Offset = "0x196ADB0", VA = "0x18196B9B0")]
		public static bool Approx3(this Vector3 v, Vector3 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x196BAC0", Offset = "0x196AEC0", VA = "0x18196BAC0")]
		public static bool Approx4(this Vector4 v, Vector4 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x196BC10", Offset = "0x196B010", VA = "0x18196BC10")]
		internal static bool ApproxC(this Color a, Color b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x196BD60", Offset = "0x196B160", VA = "0x18196BD60")]
		internal static bool Approx(this float a, float b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x19723F0", Offset = "0x19717F0", VA = "0x1819723F0")]
		internal static int Wrap(int value, int lowerBound, int upperBound)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x196D0D0", Offset = "0x196C4D0", VA = "0x18196D0D0")]
		public static int Clamp(int value, int lowerBound, int upperBound)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1971F50", Offset = "0x1971350", VA = "0x181971F50")]
		internal static Vector2 ToMask(this Vector2 vec, float delta = float.Epsilon)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x1971DD0", Offset = "0x19711D0", VA = "0x181971DD0")]
		internal static Vector3 ToMask(this Vector3 vec, float delta = float.Epsilon)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1972050", Offset = "0x1971450", VA = "0x181972050")]
		internal static Vector3 ToSignedMask(this Vector3 vec, float delta = float.Epsilon)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x196B820", Offset = "0x196AC20", VA = "0x18196B820")]
		internal static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x196DDC0", Offset = "0x196D1C0", VA = "0x18196DDC0")]
		internal static int IntSum(this Vector3 mask)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x196D0F0", Offset = "0x196C4F0", VA = "0x18196D0F0")]
		internal static void Cross(Vector3 a, Vector3 b, ref float x, ref float y, ref float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x196D1C0", Offset = "0x196C5C0", VA = "0x18196D1C0")]
		internal static void Cross(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x196D150", Offset = "0x196C550", VA = "0x18196D150")]
		internal static void Cross(float ax, float ay, float az, float bx, float by, float bz, ref float x, ref float y, ref float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x1971D90", Offset = "0x1971190", VA = "0x181971D90")]
		internal static void Subtract(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class pb_MeshCompiler
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1640C50", Offset = "0x1640050", VA = "0x181640C50")]
		public static void Compile(pb_Object pb, ref Mesh target, out Material[] materials, MeshTopology preferredTopology = MeshTopology.Triangles)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1641030", Offset = "0x1640430", VA = "0x181641030")]
		internal static Vector2[] GetUVs(pb_Object pb)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class pb_MeshUtility
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xBCB20", Offset = "0xBBF20", VA = "0x1800BCB20")]
		public pb_MeshUtility()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x16429E0", Offset = "0x1641DE0", VA = "0x1816429E0")]
		public static pb_Vertex[] GeneratePerTriangleMesh(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x16419D0", Offset = "0x1640DD0", VA = "0x1816419D0")]
		public static void CollapseSharedVertices(Mesh m, [Optional] pb_Vertex[] vertices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x1642D90", Offset = "0x1642190", VA = "0x181642D90")]
		public static void GenerateTangent(ref Mesh InMesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1642270", Offset = "0x1641670", VA = "0x181642270")]
		public static Mesh DeepCopy(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1641E20", Offset = "0x1641220", VA = "0x181641E20")]
		public static void CopyTo(Mesh source, Mesh destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x16422D0", Offset = "0x16416D0", VA = "0x1816422D0")]
		public static Vector3[] GenerateNormals(pb_Object pb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x16450D0", Offset = "0x16444D0", VA = "0x1816450D0")]
		public static void SmoothNormals(pb_Object pb, ref Vector3[] normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9A28E0", Offset = "0x9A1CE0", VA = "0x1809A28E0")]
		public static T GetMeshAttribute<T>(GameObject go, Func<Mesh, T> attributeGetter) where T : IList
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x1643A50", Offset = "0x1642E50", VA = "0x181643A50")]
		public static string Print(Mesh m)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x16438A0", Offset = "0x1642CA0", VA = "0x1816438A0")]
		public static uint GetIndexCount(Mesh m)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x1643960", Offset = "0x1642D60", VA = "0x181643960")]
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
			[Cpp2IlInjected.Address(RVA = "0x12C6660", Offset = "0x12C5A60", VA = "0x1812C6660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static T nullableInstance
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x12C6880", Offset = "0x12C5C80", VA = "0x1812C6880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xAA9F00", Offset = "0xAA9300", VA = "0x180AA9F00")]
		public pb_MonoBehaviourSingleton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x12C65C0", Offset = "0x12C59C0", VA = "0x1812C65C0")]
		public static bool Valid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x12C6490", Offset = "0x12C5890", VA = "0x1812C6490", Slot = "4")]
		public virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x12C6580", Offset = "0x12C5980", VA = "0x1812C6580", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x164C0A0", Offset = "0x164B4A0", VA = "0x18164C0A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x164C340", Offset = "0x164B740", VA = "0x18164C340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public pb_Face[] faces
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xE698B0", Offset = "0xE68CB0", VA = "0x180E698B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public pb_IntArray[] sharedIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xE698D0", Offset = "0xE68CD0", VA = "0x180E698D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public pb_IntArray[] sharedIndicesUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x164C0F0", Offset = "0x164B4F0", VA = "0x18164C0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int id
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x164C070", Offset = "0x164B470", VA = "0x18164C070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3[] vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xE698A0", Offset = "0xE68CA0", VA = "0x180E698A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Color[] colors
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x164BE80", Offset = "0x164B280", VA = "0x18164BE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2[] uv
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xE736A0", Offset = "0xE72AA0", VA = "0x180E736A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool hasUv2
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x164BEA0", Offset = "0x164B2A0", VA = "0x18164BEA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool hasUv3
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x164BF90", Offset = "0x164B390", VA = "0x18164BF90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool hasUv4
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x164C000", Offset = "0x164B400", VA = "0x18164C000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public List<Vector4> uv3
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xE6AED0", Offset = "0xE6A2D0", VA = "0x180E6AED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public List<Vector4> uv4
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xE8AA00", Offset = "0xE89E00", VA = "0x180E8AA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int faceCount
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x164BE90", Offset = "0x164B290", VA = "0x18164BE90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int vertexCount
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x164C1D0", Offset = "0x164B5D0", VA = "0x18164C1D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int triangleCount
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x164C100", Offset = "0x164B500", VA = "0x18164C100")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public pb_Face[] SelectedFaces
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x164BE10", Offset = "0x164B210", VA = "0x18164BE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public int SelectedFaceCount
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x164BDF0", Offset = "0x164B1F0", VA = "0x18164BDF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int[] SelectedTriangles
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xE8FEF0", Offset = "0xE8F2F0", VA = "0x180E8FEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int SelectedTriangleCount
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x164BE60", Offset = "0x164B260", VA = "0x18164BE60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public pb_Edge[] SelectedEdges
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xE8FEB0", Offset = "0xE8F2B0", VA = "0x180E8FEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int SelectedEdgeCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x164BDD0", Offset = "0x164B1D0", VA = "0x18164BDD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action<pb_Object> onDestroyObject
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x164BC70", Offset = "0x164B070", VA = "0x18164BC70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x164C1E0", Offset = "0x164B5E0", VA = "0x18164C1E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		internal static event Action<pb_Object> onElementSelectionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x164BD20", Offset = "0x164B120", VA = "0x18164BD20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x164C290", Offset = "0x164B690", VA = "0x18164C290")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x164BB70", Offset = "0x164AF70", VA = "0x18164BB70")]
		public pb_Object()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x1646C40", Offset = "0x1646040", VA = "0x181646C40")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1647770", Offset = "0x1646B70", VA = "0x181647770")]
		public Vector3[] GetNormals()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1647A80", Offset = "0x1646E80", VA = "0x181647A80")]
		public pb_IntArray[] GetSharedIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1647880", Offset = "0x1646C80", VA = "0x181647880")]
		public pb_IntArray[] GetSharedIndicesUV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1646960", Offset = "0x1645D60", VA = "0x181646960")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x16486D0", Offset = "0x1647AD0", VA = "0x1816486D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x1648030", Offset = "0x1647430", VA = "0x181648030")]
		public static pb_Object InitWithObject(pb_Object pb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x16470D0", Offset = "0x16464D0", VA = "0x1816470D0")]
		internal static pb_Object CreateInstanceWithPoints(Vector3[] vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x16471E0", Offset = "0x16465E0", VA = "0x1816471E0")]
		public static pb_Object CreateInstanceWithVerticesFaces(Vector3[] v, pb_Face[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1646DB0", Offset = "0x16461B0", VA = "0x181646DB0")]
		internal static pb_Object CreateInstanceWithElements(Vector3[] v, Vector2[] u, Color[] c, pb_Face[] f, pb_IntArray[] si, pb_IntArray[] si_uv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1646EE0", Offset = "0x16462E0", VA = "0x181646EE0")]
		public static pb_Object CreateInstanceWithElements(pb_Vertex[] vertices, pb_Face[] faces, [Optional] pb_IntArray[] si)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x16468E0", Offset = "0x1645CE0", VA = "0x1816468E0")]
		internal void AddToFaceSelection(pb_Face face)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x164AA60", Offset = "0x1649E60", VA = "0x18164AA60")]
		internal void SetSelectedFaces(IEnumerable<pb_Face> selected)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x164AC50", Offset = "0x164A050", VA = "0x18164AC50")]
		internal void SetSelectedFaces(IEnumerable<int> selected)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x164A9A0", Offset = "0x1649DA0", VA = "0x18164A9A0")]
		internal void SetSelectedEdges(IEnumerable<pb_Edge> edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x164AE10", Offset = "0x164A210", VA = "0x18164AE10")]
		internal void SetSelectedTriangles(int[] tris)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x164A4D0", Offset = "0x16498D0", VA = "0x18164A4D0")]
		internal void RemoveFromFaceSelectionAtIndex(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x164A530", Offset = "0x1649930", VA = "0x18164A530")]
		internal void RemoveFromFaceSelection(pb_Face face)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1646BA0", Offset = "0x1645FA0", VA = "0x181646BA0")]
		internal void ClearSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xF04D0", Offset = "0xEF8D0", VA = "0x1800F04D0")]
		public void SetVertices(Vector3[] v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x164B0F0", Offset = "0x164A4F0", VA = "0x18164B0F0")]
		public void SetVertices(IList<pb_Vertex> vertices, bool applyMesh = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x10F220", Offset = "0x10E620", VA = "0x18010F220")]
		public void SetUV(Vector2[] uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x164A800", Offset = "0x1649C00", VA = "0x18164A800")]
		public void SetFaces(IEnumerable<pb_Face> newFaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xF04C0", Offset = "0xEF8C0", VA = "0x1800F04C0")]
		public void SetSharedIndices(pb_IntArray[] si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x164AF20", Offset = "0x164A320", VA = "0x18164AF20")]
		public void SetSharedIndices(IEnumerable<KeyValuePair<int, int>> si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x163DA0", Offset = "0x1631A0", VA = "0x180163DA0")]
		internal void SetSharedIndicesUV(pb_IntArray[] si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x164AF00", Offset = "0x164A300", VA = "0x18164AF00")]
		internal void SetSharedIndicesUV(IEnumerable<KeyValuePair<int, int>> si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x1647290", Offset = "0x1646690", VA = "0x181647290")]
		private void GeometryWithPoints(Vector3[] v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x16476A0", Offset = "0x1646AA0", VA = "0x1816476A0")]
		public void GeometryWithVerticesFaces(Vector3[] v, pb_Face[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x164B8C0", Offset = "0x164ACC0", VA = "0x18164B8C0")]
		public MeshRebuildReason Verify()
		{
			return default(MeshRebuildReason);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x164B700", Offset = "0x164AB00", VA = "0x18164B700")]
		public void ToMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x164B360", Offset = "0x164A760", VA = "0x18164B360")]
		public void ToMesh(MeshTopology preferredTopology)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x16483E0", Offset = "0x16477E0", VA = "0x1816483E0")]
		internal void MakeUnique()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x164A220", Offset = "0x1649620", VA = "0x18164A220")]
		public void Refresh(RefreshMask mask = RefreshMask.All)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x16487D0", Offset = "0x1647BD0", VA = "0x1816487D0")]
		private void RefreshCollisions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1647F10", Offset = "0x1647310", VA = "0x181647F10")]
		internal int GetUnusedTextureGroup(int i = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x164B7A0", Offset = "0x164ABA0", VA = "0x18164B7A0")]
		internal int UnusedElementGroup(int i = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1647C80", Offset = "0x1647080", VA = "0x181647C80")]
		public void GetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x164AFB0", Offset = "0x164A3B0", VA = "0x18164AFB0")]
		public void SetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x1649360", Offset = "0x1648760", VA = "0x181649360")]
		private void RefreshUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1649370", Offset = "0x1648770", VA = "0x181649370")]
		internal void RefreshUV(IEnumerable<pb_Face> facesToRefresh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x164A780", Offset = "0x1649B80", VA = "0x18164A780")]
		public void SetFaceMaterial(pb_Face[] facesToApply, Material mat)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x164AF40", Offset = "0x164A340", VA = "0x18164AF40")]
		public void SetUV2(Vector2[] v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x16490C0", Offset = "0x16484C0", VA = "0x1816490C0")]
		private void RefreshColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x164A5B0", Offset = "0x16499B0", VA = "0x18164A5B0")]
		public void SetColors(Color[] InColors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x164A660", Offset = "0x1649A60", VA = "0x18164A660")]
		public void SetFaceColor(pb_Face face, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x15A660", Offset = "0x159A60", VA = "0x18015A660")]
		public void SetTangents(Vector4[] tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x16491A0", Offset = "0x16485A0", VA = "0x1816491A0")]
		private void RefreshNormals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x16492C0", Offset = "0x16486C0", VA = "0x1816492C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x12C6E70", Offset = "0x12C6270", VA = "0x1812C6E70")]
		public pb_ObjectPool(int initialSize, int desiredSize, Func<T> constructor, Action<T> destructor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x12C6C30", Offset = "0x12C6030", VA = "0x1812C6C30")]
		public T Get()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x12C6DC0", Offset = "0x12C61C0", VA = "0x1812C6DC0")]
		public void Put(T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x12C6AF0", Offset = "0x12C5EF0", VA = "0x1812C6AF0")]
		public void Empty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x12C6A90", Offset = "0x12C5E90", VA = "0x1812C6A90")]
		private static void DestroyObject(T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x12C6D90", Offset = "0x12C6190", VA = "0x1812C6D90")]
		private void OnDestroy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class pb_ObjectUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x16467A0", Offset = "0x1645BA0", VA = "0x1816467A0")]
		public static Vector3[] VerticesInWorldSpace(this pb_Object pb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1646680", Offset = "0x1645A80", VA = "0x181646680")]
		public static Vector3[] VerticesInWorldSpace(this pb_Object pb, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1646430", Offset = "0x1645830", VA = "0x181646430")]
		public static void TranslateVertices_World(this pb_Object pb, int[] selectedTriangles, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1645D60", Offset = "0x1645160", VA = "0x181645D60")]
		public static void TranslateVertices_World(this pb_Object pb, int[] selectedTriangles, Vector3 offset, float snapValue, bool snapAxisOnly, Dictionary<int, int> lookup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1646480", Offset = "0x1645880", VA = "0x181646480")]
		public static void TranslateVertices(this pb_Object pb, int[] selectedTriangles, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x16459F0", Offset = "0x1644DF0", VA = "0x1816459F0")]
		public static void SetSharedVertexPosition(this pb_Object pb, int sharedIndex, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1645B30", Offset = "0x1644F30", VA = "0x181645B30")]
		public static void SetSharedVertexValues(this pb_Object pb, int sharedIndex, pb_Vertex vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1645860", Offset = "0x1644C60", VA = "0x181645860")]
		public static bool FaceWithTriangle(this pb_Object pb, int[] tri, out pb_Face face)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1645940", Offset = "0x1644D40", VA = "0x181645940")]
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
			[Cpp2IlInjected.Address(RVA = "0x164C400", Offset = "0x164B800", VA = "0x18164C400")]
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
		[Cpp2IlInjected.Address(RVA = "0x164DED0", Offset = "0x164D2D0", VA = "0x18164DED0")]
		public static Dictionary<pb_Object, HashSet<int>> PickVerticesInRect(Camera cam, Rect rect, IList<pb_Object> selectable, pb_PickerOptions options, float pixelsPerPoint = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x164CD20", Offset = "0x164C120", VA = "0x18164CD20")]
		public static Dictionary<pb_Object, HashSet<pb_Face>> PickFacesInRect(Camera cam, Rect rect, IList<pb_Object> selectable, pb_PickerOptions options, float pixelsPerPoint = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x164C460", Offset = "0x164B860", VA = "0x18164C460")]
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
			[Cpp2IlInjected.Address(RVA = "0x164E3F0", Offset = "0x164D7F0", VA = "0x18164E3F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xBCC60", Offset = "0xBC060", VA = "0x1800BCC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x164E380", Offset = "0x164D780", VA = "0x18164E380")]
		public pb_PolyShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xE79AE0", Offset = "0xE78EE0", VA = "0x180E79AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x164F650", Offset = "0x164EA50", VA = "0x18164F650")]
		public pb_PreferenceDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x164EF00", Offset = "0x164E300", VA = "0x18164EF00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x164EAE0", Offset = "0x164DEE0", VA = "0x18164EAE0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x164F2E0", Offset = "0x164E6E0", VA = "0x18164F2E0", Slot = "6")]
		public void SetDefaultValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x164E9E0", Offset = "0x164DDE0", VA = "0x18164E9E0")]
		public bool HasKey(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xAA62B0", Offset = "0xAA56B0", VA = "0x180AA62B0")]
		public bool HasKey<T>(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x164E520", Offset = "0x164D920", VA = "0x18164E520")]
		public void DeleteKey(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B00", Offset = "0x9A1F00", VA = "0x1809A2B00")]
		public T Get<T>(string key, [Optional] T fallback)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x10ABC80", Offset = "0x10AB080", VA = "0x1810ABC80")]
		public void Set<T>(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x164E6C0", Offset = "0x164DAC0", VA = "0x18164E6C0")]
		public bool GetBool(string key, bool fallback = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x164E860", Offset = "0x164DC60", VA = "0x18164E860")]
		public int GetInt(string key, int fallback = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x164E7E0", Offset = "0x164DBE0", VA = "0x18164E7E0")]
		public float GetFloat(string key, float fallback = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x164E960", Offset = "0x164DD60", VA = "0x18164E960")]
		public string GetString(string key, [Optional] string fallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x164E740", Offset = "0x164DB40", VA = "0x18164E740")]
		public Color GetColor(string key, [Optional] Color fallback)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x164E8E0", Offset = "0x164DCE0", VA = "0x18164E8E0")]
		public Material GetMaterial(string key, [Optional] Material fallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x164F170", Offset = "0x164E570", VA = "0x18164F170")]
		public void SetBool(string key, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x164F440", Offset = "0x164E840", VA = "0x18164F440")]
		public void SetInt(string key, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x164F390", Offset = "0x164E790", VA = "0x18164F390")]
		public void SetFloat(string key, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x164F5A0", Offset = "0x164E9A0", VA = "0x18164F5A0")]
		public void SetString(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x164F220", Offset = "0x164E620", VA = "0x18164F220")]
		public void SetColor(string key, Color value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x164F4F0", Offset = "0x164E8F0", VA = "0x18164F4F0")]
		public void SetMaterial(string key, Material value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xE698B0", Offset = "0xE68CB0", VA = "0x180E698B0")]
		public Dictionary<string, bool> GetBoolDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xE698D0", Offset = "0xE68CD0", VA = "0x180E698D0")]
		public Dictionary<string, int> GetIntDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xE698A0", Offset = "0xE68CA0", VA = "0x180E698A0")]
		public Dictionary<string, float> GetFloatDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xE736A0", Offset = "0xE72AA0", VA = "0x180E736A0")]
		public Dictionary<string, string> GetStringDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xE6AED0", Offset = "0xE6A2D0", VA = "0x180E6AED0")]
		public Dictionary<string, Color> GetColorDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xE8AA00", Offset = "0xE89E00", VA = "0x180E8AA00")]
		public Dictionary<string, Material> GetMaterialDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x164E480", Offset = "0x164D880", VA = "0x18164E480")]
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
		[Cpp2IlInjected.Address(RVA = "0x1650870", Offset = "0x164FC70", VA = "0x181650870")]
		public static Vector2[] PlanarProject(IEnumerable<Vector3> verts, Vector3 planeNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x16504B0", Offset = "0x164F8B0", VA = "0x1816504B0")]
		internal static Vector2[] PlanarProject(pb_Object pb, pb_Face face)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x16505C0", Offset = "0x164F9C0", VA = "0x1816505C0")]
		internal static Vector2[] PlanarProject(IList<pb_Vertex> vertices, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x16500D0", Offset = "0x164F4D0", VA = "0x1816500D0")]
		internal static Vector2[] PlanarProject(Vector3[] verts, Vector3 planeNormal, ProjectionAxis projectionAxis, [Optional] int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x164FD10", Offset = "0x164F110", VA = "0x18164FD10")]
		internal static void PlanarProject(Vector3[] verts, Vector2[] uvs, int[] indices, Vector3 planeNormal, ProjectionAxis projectionAxis)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x1650F00", Offset = "0x1650300", VA = "0x181650F00")]
		internal static Vector2[] SphericalProject(IList<Vector3> vertices, [Optional] IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x1650B30", Offset = "0x164FF30", VA = "0x181650B30")]
		internal static IList<Vector2> Sort(IList<Vector2> verts, SortMethod method = SortMethod.CounterClockwise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1650930", Offset = "0x164FD30", VA = "0x181650930")]
		internal static Vector3 ProjectionAxisToVector(ProjectionAxis axis)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x16512A0", Offset = "0x16506A0", VA = "0x1816512A0")]
		internal static ProjectionAxis VectorToProjectionAxis(Vector3 plane)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xE39BF0", Offset = "0xE38FF0", VA = "0x180E39BF0")]
		internal static Plane FindBestPlane<T>(IList<T> points, Func<T, Vector3> selector, [Optional] IList<int> indices)
		{
			return default(Plane);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x164F760", Offset = "0x164EB60", VA = "0x18164F760")]
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
		[Cpp2IlInjected.Address(RVA = "0x1651490", Offset = "0x1650890", VA = "0x181651490")]
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
		[Cpp2IlInjected.Address(RVA = "0x12D860", Offset = "0x12CC60", VA = "0x18012D860")]
		public pb_Renderable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x16515E0", Offset = "0x16509E0", VA = "0x1816515E0")]
		public static pb_Renderable CreateInstance(Mesh InMesh, Material InMaterial, [Optional] Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1651500", Offset = "0x1650900", VA = "0x181651500")]
		public static pb_Renderable CreateInstance()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1651650", Offset = "0x1650A50", VA = "0x181651650")]
		public static void DestroyInstance(UnityEngine.Object ren)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x16516B0", Offset = "0x1650AB0", VA = "0x1816516B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1651750", Offset = "0x1650B50", VA = "0x181651750")]
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
			[Cpp2IlInjected.Address(RVA = "0x16558A0", Offset = "0x1654CA0", VA = "0x1816558A0")]
			get
			{
				return default(RenderTextureFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private static TextureFormat textureFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1655AC0", Offset = "0x1654EC0", VA = "0x181655AC0")]
			get
			{
				return default(TextureFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x16540E0", Offset = "0x16534E0", VA = "0x1816540E0")]
		public static Dictionary<pb_Object, HashSet<pb_Face>> PickFacesInRect(Camera camera, Rect pickerRect, IList<pb_Object> selection, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1654730", Offset = "0x1653B30", VA = "0x181654730")]
		public static Dictionary<pb_Object, HashSet<int>> PickVerticesInRect(Camera camera, Rect pickerRect, IList<pb_Object> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x1653A50", Offset = "0x1652E50", VA = "0x181653A50")]
		public static Dictionary<pb_Object, HashSet<pb_Edge>> PickEdgesInRect(Camera camera, Rect pickerRect, IList<pb_Object> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1654EC0", Offset = "0x16542C0", VA = "0x181654EC0")]
		private static Texture2D RenderSelectionPickerTexture(Camera camera, IList<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, pb_Face>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x1655070", Offset = "0x1654470", VA = "0x181655070")]
		private static Texture2D RenderSelectionPickerTexture(Camera camera, IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, int>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x1654C30", Offset = "0x1654030", VA = "0x181654C30")]
		private static Texture2D RenderSelectionPickerTexture(Camera camera, IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, pb_Edge>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x16530A0", Offset = "0x16524A0", VA = "0x1816530A0")]
		private static GameObject[] GenerateFacePickingObjects(IList<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, pb_Face>> map)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x16535B0", Offset = "0x16529B0", VA = "0x1816535B0")]
		private static void GenerateVertexPickingObjects(IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, int>> map, out GameObject[] depthObjects, out GameObject[] pickerObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1652C00", Offset = "0x1652000", VA = "0x181652C00")]
		private static void GenerateEdgePickingObjects(IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, pb_Edge>> map, out GameObject[] depthObjects, out GameObject[] pickerObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1651F30", Offset = "0x1651330", VA = "0x181651F30")]
		private static Mesh BuildVertexMesh(pb_Object pb, Dictionary<uint, pb_Tuple<pb_Object, int>> map, ref uint index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x16519B0", Offset = "0x1650DB0", VA = "0x1816519B0")]
		private static Mesh BuildEdgeMesh(pb_Object pb, Dictionary<uint, pb_Tuple<pb_Object, pb_Edge>> map, ref uint index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1652AD0", Offset = "0x1651ED0", VA = "0x181652AD0")]
		public static uint DecodeRGBA(Color32 color)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1652B60", Offset = "0x1651F60", VA = "0x181652B60")]
		public static Color32 EncodeRGBA(uint hash)
		{
			return default(Color32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x1655300", Offset = "0x1654700", VA = "0x181655300")]
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
		[Cpp2IlInjected.Address(RVA = "0x1657880", Offset = "0x1656C80", VA = "0x181657880")]
		public static pb_Object CreateShape(pb_ShapeType shape)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x165EBC0", Offset = "0x165DFC0", VA = "0x18165EBC0")]
		public static pb_Object StairGenerator(Vector3 size, int steps, bool buildSides)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1658170", Offset = "0x1657570", VA = "0x181658170")]
		public static pb_Object CurvedStairGenerator(float stairWidth, float height, float innerRadius, float circumference, int steps, bool buildSides)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x165FF80", Offset = "0x165F380", VA = "0x18165FF80")]
		public static pb_Object StairGenerator(int steps, float width, float height, float depth, bool sidesGoToFloor, bool generateBack, bool platformsOnly)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1657EE0", Offset = "0x16572E0", VA = "0x181657EE0")]
		public static pb_Object CubeGenerator(Vector3 size)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1659C60", Offset = "0x1659060", VA = "0x181659C60")]
		public static pb_Object CylinderGenerator(int axisDivisions, float radius, float height, int heightCuts, int smoothing = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x165DE60", Offset = "0x165D260", VA = "0x18165DE60")]
		public static pb_Object PrismGenerator(Vector3 size)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x165AB30", Offset = "0x1659F30", VA = "0x18165AB30")]
		public static pb_Object DoorGenerator(float totalWidth, float totalHeight, float ledgeHeight, float legWidth, float depth)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x165DDE0", Offset = "0x165D1E0", VA = "0x18165DDE0")]
		[Obsolete]
		public static pb_Object PlaneGenerator(float _width, float _height, int widthCuts, int heightCuts, Axis axis, bool smooth)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x165D460", Offset = "0x165C860", VA = "0x18165D460")]
		public static pb_Object PlaneGenerator(float _width, float _height, int widthCuts, int heightCuts, Axis axis)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x165C820", Offset = "0x165BC20", VA = "0x18165C820")]
		public static pb_Object PipeGenerator(float radius, float height, float thickness, int subdivAxis, int subdivHeight)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x16571F0", Offset = "0x16565F0", VA = "0x1816571F0")]
		public static pb_Object ConeGenerator(float radius, float height, int subdivAxis)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1655AD0", Offset = "0x1654ED0", VA = "0x181655AD0")]
		public static pb_Object ArchGenerator(float angle, float radius, float width, float depth, int radialCuts, bool insideFaces, bool outsideFaces, bool frontFaces, bool backFaces, bool endCaps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x165BFD0", Offset = "0x165B3D0", VA = "0x18165BFD0")]
		public static pb_Object IcosahedronGenerator(float radius, int subdivisions, bool weldVertices = true, bool manualUvs = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x16608C0", Offset = "0x165FCC0", VA = "0x1816608C0")]
		private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1656AC0", Offset = "0x1655EC0", VA = "0x181656AC0")]
		private static Vector3[] CircleVertices(int segments, float radius, float circumference, Quaternion rotation, float offset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1661010", Offset = "0x1660410", VA = "0x181661010")]
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
		[Cpp2IlInjected.Address(RVA = "0x1662EA0", Offset = "0x16622A0", VA = "0x181662EA0")]
		public pb_Shortcut(string a, string d, KeyCode k, EventModifiers e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x1662CB0", Offset = "0x16620B0", VA = "0x181662CB0")]
		public pb_Shortcut(string str)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x16623E0", Offset = "0x16617E0", VA = "0x1816623E0")]
		public bool Matches(KeyCode key, EventModifiers modifiers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x1662340", Offset = "0x1661740", VA = "0x181662340")]
		public static int IndexOf(pb_Shortcut[] shortcuts, KeyCode k, EventModifiers e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x1661EB0", Offset = "0x16612B0", VA = "0x181661EB0")]
		public static IEnumerable<pb_Shortcut> DefaultShortcuts()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x1662400", Offset = "0x1661800", VA = "0x181662400")]
		public static IEnumerable<pb_Shortcut> ParseShortcuts(string str)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1662A40", Offset = "0x1661E40", VA = "0x181662A40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x16625C0", Offset = "0x16619C0", VA = "0x1816625C0")]
		public string Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1662970", Offset = "0x1661D70", VA = "0x181662970")]
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
		[Cpp2IlInjected.Address(RVA = "0x16638E0", Offset = "0x1662CE0", VA = "0x1816638E0")]
		public static int GetUnusedSmoothingGroup(pb_Object pb)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x1663860", Offset = "0x1662C60", VA = "0x181663860")]
		private static int GetNextUnusedSmoothingGroup(int start, HashSet<int> used)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x1663A30", Offset = "0x1662E30", VA = "0x181663A30")]
		public static bool IsSmooth(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1662EF0", Offset = "0x16622F0", VA = "0x181662EF0")]
		public static void ApplySmoothingGroups(pb_Object pb, IEnumerable<pb_Face> faces, float angleThreshold, [Optional] Vector3[] normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x16635E0", Offset = "0x16629E0", VA = "0x1816635E0")]
		private static bool FindSoftEdgesRecursive(Vector3[] normals, pb_WingedEdge wing, float angleThreshold, HashSet<pb_Face> processed)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x1663A50", Offset = "0x1662E50", VA = "0x181663A50")]
		private static bool IsSoftEdge(Vector3[] normals, pb_EdgeLookup left, pb_EdgeLookup right, float threshold)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class pb_Snap
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1663DB0", Offset = "0x16631B0", VA = "0x181663DB0")]
		public static Vector3 SnapValue(Vector3 vertex, float snpVal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1663EB0", Offset = "0x16632B0", VA = "0x181663EB0")]
		public static float SnapValue(float val, float snpVal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1663F20", Offset = "0x1663320", VA = "0x181663F20")]
		public static Vector3 SnapValue(Vector3 vertex, Vector3 snap)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class pb_Spline
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x1665470", Offset = "0x1664870", VA = "0x181665470")]
		internal static pb_Object Extrude(IList<pb_BezierPoint> points, float radius = 0.5f, int columns = 32, int rows = 16, bool closeLoop = false, bool smooth = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1665390", Offset = "0x1664790", VA = "0x181665390")]
		internal static void Extrude(IList<pb_BezierPoint> bezierPoints, float radius, int columns, int rows, bool closeLoop, bool smooth, ref pb_Object target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1665560", Offset = "0x1664960", VA = "0x181665560")]
		internal static List<Vector3> GetControlPoints(IList<pb_BezierPoint> bezierPoints, int subdivisionsPerSegment, bool closeLoop, List<Quaternion> rotations)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1664130", Offset = "0x1663530", VA = "0x181664130")]
		internal static void Extrude(IList<Vector3> points, float radius, int radiusRows, bool closeLoop, bool smooth, ref pb_Object target, [Optional] IList<Quaternion> pointRotations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x16658F0", Offset = "0x1664CF0", VA = "0x1816658F0")]
		private static Quaternion GetRingRotation(IList<Vector3> points, int i, bool closeLoop, out float secant)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1665E60", Offset = "0x1665260", VA = "0x181665E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x1666380", Offset = "0x1665780", VA = "0x181666380")]
		public pb_Submesh(Material material, MeshTopology topology, int[] indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x16663D0", Offset = "0x16657D0", VA = "0x1816663D0")]
		public pb_Submesh(Mesh mesh, int subMeshIndex, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1666240", Offset = "0x1665640", VA = "0x181666240", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1666880", Offset = "0x1665C80", VA = "0x181666880")]
		public pb_Transform2D(Vector2 position, float rotation, Vector2 scale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x16667A0", Offset = "0x1665BA0", VA = "0x1816667A0")]
		public Vector2 TransformPoint(Vector2 p)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1666440", Offset = "0x1665840", VA = "0x181666440", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1666A30", Offset = "0x1665E30", VA = "0x181666A30")]
		public static void UnparentChildren(Transform t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x16668E0", Offset = "0x1665CE0", VA = "0x1816668E0")]
		public static void ReparentChildren(Transform t)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[DisallowMultipleComponent]
	internal class pb_TriggerBehaviour : pb_EntityBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x343A90", Offset = "0x342E90", VA = "0x180343A90")]
		public pb_TriggerBehaviour()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1666C00", Offset = "0x1666000", VA = "0x181666C00", Slot = "4")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1666D40", Offset = "0x1666140", VA = "0x181666D40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6A3F0", Offset = "0xA697F0", VA = "0x180A6A3F0")]
		public pb_Tuple()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x12C7310", Offset = "0x12C6710", VA = "0x1812C7310")]
		public pb_Tuple(T1 item1, T2 item2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x12C7090", Offset = "0x12C6490", VA = "0x1812C7090", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6A3F0", Offset = "0xA697F0", VA = "0x180A6A3F0")]
		public pb_Tuple()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x12C7420", Offset = "0x12C6820", VA = "0x1812C7420")]
		public pb_Tuple(T1 item1, T2 item2, T3 item3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x12C7360", Offset = "0x12C6760", VA = "0x1812C7360", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6A3F0", Offset = "0xA697F0", VA = "0x180A6A3F0")]
		public pb_Tuple()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x12C76D0", Offset = "0x12C6AD0", VA = "0x1812C76D0")]
		public pb_Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x12C7480", Offset = "0x12C6880", VA = "0x1812C7480", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x16688D0", Offset = "0x1667CD0", VA = "0x1816688D0")]
		public pb_UnwrapParameters()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x16688B0", Offset = "0x1667CB0", VA = "0x1816688B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1C24C0", Offset = "0x1C18C0", VA = "0x1801C24C0")]
			public SearchRange(int begin, int end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x1640BB0", Offset = "0x163FFB0", VA = "0x181640BB0")]
			public bool Valid()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x1640880", Offset = "0x163FC80", VA = "0x181640880")]
			public int Center()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x1640B90", Offset = "0x163FF90", VA = "0x181640B90", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xE3A8D0", Offset = "0xE39CD0", VA = "0x180E3A8D0")]
		public static T[] GetComponents<T>(this IEnumerable<GameObject> gameObjects) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xE3A890", Offset = "0xE39C90", VA = "0x180E3A890")]
		public static T[] GetComponents<T>(GameObject go) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xE3A690", Offset = "0xE39A90", VA = "0x180E3A690")]
		public static T[] GetComponents<T>(this IEnumerable<Transform> transforms) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1668FC0", Offset = "0x16683C0", VA = "0x181668FC0")]
		public static Vector3[] ToWorldSpace(this Transform t, Vector3[] v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1668A90", Offset = "0x1667E90", VA = "0x181668A90")]
		public static GameObject EmptyGameObjectWithTransform(Transform t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xE3B020", Offset = "0xE3A420", VA = "0x180E3B020")]
		public static T[] ValuesWithIndices<T>(this T[] arr, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8F7080", Offset = "0x8F6480", VA = "0x1808F7080")]
		public static List<T> ValuesWithIndices<T>(this List<T> arr, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9A3000", Offset = "0x9A2400", VA = "0x1809A3000")]
		public static T NextEnumValue<T>(this T current) where T : IConvertible
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAA67B0", Offset = "0xAA5BB0", VA = "0x180AA67B0")]
		public static bool IsEqual<T>(T[] a, T[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xE3A1C0", Offset = "0xE395C0", VA = "0x180E3A1C0")]
		public static T[] Add<T>(this T[] arr, T val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xE3A050", Offset = "0xE39450", VA = "0x180E3A050")]
		public static T[] AddRange<T>(this T[] arr, T[] val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xE3ADF0", Offset = "0xE3A1F0", VA = "0x180E3ADF0")]
		public static T[] Remove<T>(this T[] arr, T val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xE3ADC0", Offset = "0xE3A1C0", VA = "0x180E3ADC0")]
		public static T[] Remove<T>(this T[] arr, IEnumerable<T> val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xE3AC60", Offset = "0xE3A060", VA = "0x180E3AC60")]
		public static T[] RemoveAt<T>(this T[] arr, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xE3ABC0", Offset = "0xE39FC0", VA = "0x180E3ABC0")]
		public static T[] RemoveAt<T>(this IList<T> list, IEnumerable<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xE3AE90", Offset = "0xE3A290", VA = "0x180E3AE90")]
		public static T[] SortedRemoveAt<T>(this IList<T> list, IList<int> sorted_indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xB11CC0", Offset = "0xB110C0", VA = "0x180B11CC0")]
		public static int NearestIndexPriorToValue<T>(IList<T> sorted_list, T value) where T : IComparable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xE3A550", Offset = "0xE39950", VA = "0x180E3A550")]
		public static T[] Fill<T>(T val, int length)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8F6FC0", Offset = "0x8F63C0", VA = "0x1808F6FC0")]
		public static List<T> Fill<T>(Func<int, T> ctor, int length)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xE3A600", Offset = "0xE39A00", VA = "0x180E3A600")]
		public static T[] FilledArray<T>(T val, int length)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6720", Offset = "0xAA5B20", VA = "0x180AA6720")]
		public static bool ContainsMatch<T>(this T[] a, T[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6670", Offset = "0xAA5A70", VA = "0x180AA6670")]
		public static bool ContainsMatch<T>(this T[] a, T[] b, out int index_a, out int index_b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xE3A270", Offset = "0xE39670", VA = "0x180E3A270")]
		public static T[] Concat<T>(this T[] x, T[] y)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xB119E0", Offset = "0xB10DE0", VA = "0x180B119E0")]
		public static int IndexOf<T>(this List<List<T>> InList, T InValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xE3A490", Offset = "0xE39890", VA = "0x180E3A490")]
		public static T[] Fill<T>(int count, Func<int, T> ctor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x10AC050", Offset = "0x10AB450", VA = "0x1810AC050")]
		public static void AddOrAppend<T, K>(this Dictionary<T, List<K>> dictionary, T key, K value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x10ABFB0", Offset = "0x10AB3B0", VA = "0x1810ABFB0")]
		public static void AddOrAppendRange<T, K>(this Dictionary<T, List<K>> dictionary, T key, List<K> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x793C30", Offset = "0x793030", VA = "0x180793C30")]
		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x1360180", Offset = "0x135F580", VA = "0x181360180")]
		[Obsolete]
		public static string ToFormattedString<T>(this T[] t, string _delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x135FF30", Offset = "0x135F330", VA = "0x18135FF30")]
		[Obsolete]
		public static string ToFormattedString<T>(this T[] t, string _delimiter, int entriesPerLine, int maxEntries)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x135FEE0", Offset = "0x135F2E0", VA = "0x18135FEE0")]
		[Obsolete]
		public static string ToFormattedString<T>(this List<T> t, string _delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x135FEA0", Offset = "0x135F2A0", VA = "0x18135FEA0")]
		[Obsolete]
		public static string ToFormattedString<T>(this HashSet<T> t, string _delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1360280", Offset = "0x135F680", VA = "0x181360280")]
		public static string ToString<TKey, TValue>(this Dictionary<TKey, TValue> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x1360550", Offset = "0x135F950", VA = "0x181360550")]
		public static string ToString<T>(this IEnumerable<T> arr, string separator = ", ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x1668940", Offset = "0x1667D40", VA = "0x181668940")]
		public static string ControlKeyString(char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x1668900", Offset = "0x1667D00", VA = "0x181668900")]
		[Obsolete]
		public static bool ColorWithString(string value, out Color col)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x16690F0", Offset = "0x16684F0", VA = "0x1816690F0")]
		public static bool TryParseColor(string value, ref Color col)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1668BD0", Offset = "0x1667FD0", VA = "0x181668BD0")]
		public static Vector3[] StringToVector3Array(string str)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x16689E0", Offset = "0x1667DE0", VA = "0x1816689E0")]
		public static Vector2 DivideBy(this Vector2 v, Vector2 o)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1668A30", Offset = "0x1667E30", VA = "0x181668A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x1668780", Offset = "0x1667B80", VA = "0x181668780")]
		public pb_UV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1668820", Offset = "0x1667C20", VA = "0x181668820")]
		public pb_UV(pb_UV uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1667DE0", Offset = "0x16671E0", VA = "0x181667DE0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1667E80", Offset = "0x1667280", VA = "0x181667E80", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1667AA0", Offset = "0x1666EA0", VA = "0x181667AA0")]
		public static void PlanarMap2(Vector3[] verts, Vector2[] uvs, int[] indices, pb_UV uvSettings, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1667150", Offset = "0x1666550", VA = "0x181667150")]
		private static void ApplyUVSettings(Vector2[] uvs, int[] indices, pb_UV uvSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1667BB0", Offset = "0x1666FB0", VA = "0x181667BB0")]
		private static Vector2[] StretchUVs(Vector2[] uvs, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x16678B0", Offset = "0x1666CB0", VA = "0x1816678B0")]
		private static Vector2[] NormalizeUVs(Vector2[] uvs, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1667690", Offset = "0x1666A90", VA = "0x181667690")]
		[Obsolete]
		private static Vector2[] JustifyUVs(Vector2[] uvs, pb_UV.Justify j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1666DD0", Offset = "0x16661D0", VA = "0x181666DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1669690", Offset = "0x1668A90", VA = "0x181669690")]
		private static int HashFloat(float f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x16695D0", Offset = "0x16689D0", VA = "0x1816695D0")]
		public static int GetHashCode(Vector2 v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x16694C0", Offset = "0x16688C0", VA = "0x1816694C0")]
		public static int GetHashCode(Vector3 v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1669360", Offset = "0x1668760", VA = "0x181669360")]
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
			[Cpp2IlInjected.Address(RVA = "0xE6C060", Offset = "0xE6B460", VA = "0x180E6C060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int minor
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x166AAC0", Offset = "0x1669EC0", VA = "0x18166AAC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int patch
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xE69F10", Offset = "0xE69310", VA = "0x180E69F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int build
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xE6FA40", Offset = "0xE6EE40", VA = "0x180E6FA40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public VersionType type
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xE8A2E0", Offset = "0xE896E0", VA = "0x180E8A2E0")]
			get
			{
				return default(VersionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string metadata
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xE698A0", Offset = "0xE68CA0", VA = "0x180E698A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string date
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xE736A0", Offset = "0xE72AA0", VA = "0x180E736A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public pb_VersionInfo MajorMinorPatch
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x166A9A0", Offset = "0x1669DA0", VA = "0x18166A9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x166A7D0", Offset = "0x1669BD0", VA = "0x18166A7D0")]
		public pb_VersionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x166A8F0", Offset = "0x1669CF0", VA = "0x18166A8F0")]
		public pb_VersionInfo(string formatted, [Optional] string date)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x166A7F0", Offset = "0x1669BF0", VA = "0x18166A7F0")]
		public pb_VersionInfo(int major, int minor, int patch, int build = -1, VersionType type = VersionType.Missing, string date = "", string metadata = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1669E80", Offset = "0x1669280", VA = "0x181669E80")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x16699D0", Offset = "0x1668DD0", VA = "0x1816699D0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x1669B60", Offset = "0x1668F60", VA = "0x181669B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x16698C0", Offset = "0x1668CC0", VA = "0x1816698C0", Slot = "4")]
		public bool Equals(pb_VersionInfo version)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x16696F0", Offset = "0x1668AF0", VA = "0x1816696F0", Slot = "6")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x166A7C0", Offset = "0x1669BC0", VA = "0x18166A7C0")]
		private static int WrapNoValue(int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1669780", Offset = "0x1668B80", VA = "0x181669780", Slot = "5")]
		public int CompareTo(pb_VersionInfo version)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x166AAD0", Offset = "0x1669ED0", VA = "0x18166AAD0")]
		public static bool operator ==(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x166AB20", Offset = "0x1669F20", VA = "0x18166AB20")]
		public static bool operator !=(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x166AB60", Offset = "0x1669F60", VA = "0x18166AB60")]
		public static bool operator <(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x166AAF0", Offset = "0x1669EF0", VA = "0x18166AAF0")]
		public static bool operator >(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1669EA0", Offset = "0x16692A0", VA = "0x181669EA0")]
		public string ToString(string format)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x166A1B0", Offset = "0x16695B0", VA = "0x18166A1B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x166A1F0", Offset = "0x16695F0", VA = "0x18166A1F0")]
		public static bool TryGetVersionInfo(string input, out pb_VersionInfo version)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1669CC0", Offset = "0x16690C0", VA = "0x181669CC0")]
		private static VersionType GetVersionType(string input)
		{
			return default(VersionType);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1669AB0", Offset = "0x1668EB0", VA = "0x181669AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2330430", Offset = "0x232F830", VA = "0x182330430")]
		public pb_Vertex(bool hasAllValues = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2330480", Offset = "0x232F880", VA = "0x182330480")]
		public pb_Vertex(pb_Vertex v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x232D910", Offset = "0x232CD10", VA = "0x18232D910", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x232DBC0", Offset = "0x232CFC0", VA = "0x18232DBC0", Slot = "4")]
		public bool Equals(pb_Vertex other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x232E420", Offset = "0x232D820", VA = "0x18232E420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x2330560", Offset = "0x232F960", VA = "0x182330560")]
		public static pb_Vertex operator +(pb_Vertex a, pb_Vertex b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x232CBB0", Offset = "0x232BFB0", VA = "0x18232CBB0")]
		public void Add(pb_Vertex b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x23306E0", Offset = "0x232FAE0", VA = "0x1823306E0")]
		public static pb_Vertex operator -(pb_Vertex a, pb_Vertex b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x2330160", Offset = "0x232F560", VA = "0x182330160")]
		public void Subtract(pb_Vertex b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x2330660", Offset = "0x232FA60", VA = "0x182330660")]
		public static pb_Vertex operator *(pb_Vertex a, float value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x232FC90", Offset = "0x232F090", VA = "0x18232FC90")]
		public void Multiply(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x23305E0", Offset = "0x232F9E0", VA = "0x1823305E0")]
		public static pb_Vertex operator /(pb_Vertex a, float value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x232D6E0", Offset = "0x232CAE0", VA = "0x18232D6E0")]
		public void Divide(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x232FEC0", Offset = "0x232F2C0", VA = "0x18232FEC0")]
		public void Normalize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x2330420", Offset = "0x232F820", VA = "0x182330420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x232E4B0", Offset = "0x232D8B0", VA = "0x18232E4B0")]
		public static pb_Vertex[] GetVertices(pb_Object pb, [Optional] IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x232ED90", Offset = "0x232E190", VA = "0x18232ED90")]
		public static pb_Vertex[] GetVertices(Mesh m)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x232DDF0", Offset = "0x232D1F0", VA = "0x18232DDF0")]
		public static void GetArrays(IList<pb_Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x232DE60", Offset = "0x232D260", VA = "0x18232DE60")]
		public static void GetArrays(IList<pb_Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4, AttributeType attributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x232FF90", Offset = "0x232F390", VA = "0x18232FF90")]
		public static void SetMesh(Mesh m, IList<pb_Vertex> vertices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x232CE70", Offset = "0x232C270", VA = "0x18232CE70")]
		public static pb_Vertex Average(IList<pb_Vertex> vertices, [Optional] IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x232F620", Offset = "0x232EA20", VA = "0x18232F620")]
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
			[Cpp2IlInjected.Address(RVA = "0x232CB60", Offset = "0x232BF60", VA = "0x18232CB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1ED210", Offset = "0x1EC610", VA = "0x1801ED210")]
		public pb_VertexConnection(pb_Face face, List<int> indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x232C930", Offset = "0x232BD30", VA = "0x18232C930")]
		public pb_VertexConnection Distinct(pb_IntArray[] sharedIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x232C9C0", Offset = "0x232BDC0", VA = "0x18232C9C0", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x195F170", Offset = "0x195E570", VA = "0x18195F170", Slot = "4")]
		public bool Equals(pb_VertexConnection vc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x4DCE80", Offset = "0x4DC280", VA = "0x1804DCE80")]
		public static implicit operator pb_Face(pb_VertexConnection vc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x195F2B0", Offset = "0x195E6B0", VA = "0x18195F2B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x232CAD0", Offset = "0x232BED0", VA = "0x18232CAD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x232C860", Offset = "0x232BC60", VA = "0x18232C860")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCB20", Offset = "0xBBF20", VA = "0x1800BCB20")]
		public pb_WingedEdge()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2330890", Offset = "0x232FC90", VA = "0x182330890", Slot = "4")]
		public bool Equals(pb_WingedEdge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x23308D0", Offset = "0x232FCD0", VA = "0x1823308D0", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2330AE0", Offset = "0x232FEE0", VA = "0x182330AE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2330A70", Offset = "0x232FE70", VA = "0x182330A70", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2330A70", Offset = "0x232FE70", VA = "0x182330A70")]
		public pb_WingedEdgeEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2330850", Offset = "0x232FC50", VA = "0x182330850")]
		public int Count()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x2332170", Offset = "0x2331570", VA = "0x182332170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x2331430", Offset = "0x2330830", VA = "0x182331430")]
		public static int[] MakeQuad(pb_WingedEdge left, pb_WingedEdge right)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x23309E0", Offset = "0x232FDE0", VA = "0x1823309E0")]
		public pb_WingedEdge GetAdjacentEdgeWithCommonIndex(int common)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x2331F90", Offset = "0x2331390", VA = "0x182331F90")]
		public static List<pb_Edge> SortEdgesByAdjacency(pb_Face face)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x2332010", Offset = "0x2331410", VA = "0x182332010")]
		public static List<pb_Edge> SortEdgesByAdjacency(List<pb_Edge> edges)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x2330B10", Offset = "0x232FF10", VA = "0x182330B10")]
		public static Dictionary<int, List<pb_WingedEdge>> GetSpokes(List<pb_WingedEdge> wings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x2331D70", Offset = "0x2331170", VA = "0x182331D70")]
		public static List<int> SortCommonIndicesByAdjacency(List<pb_WingedEdge> wings, HashSet<int> common)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2330DB0", Offset = "0x23301B0", VA = "0x182330DB0")]
		public static List<pb_WingedEdge> GetWingedEdges(pb_Object pb, bool oneWingPerFace = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x2330E00", Offset = "0x2330200", VA = "0x182330E00")]
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
			[Cpp2IlInjected.Address(RVA = "0x2330790", Offset = "0x232FB90", VA = "0x182330790", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public pb_WingedEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x23307E0", Offset = "0x232FBE0", VA = "0x1823307E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x23307A0", Offset = "0x232FBA0", VA = "0x1823307A0")]
		public pb_WingedEdgeEnumerator(pb_WingedEdge start)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2330760", Offset = "0x232FB60", VA = "0x182330760", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x158F910", Offset = "0x158ED10", VA = "0x18158F910", Slot = "6")]
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
