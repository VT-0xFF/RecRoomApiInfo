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
			[Cpp2IlInjected.Address(RVA = "0xB02F20", Offset = "0xB02320", VA = "0x180B02F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string releaseNotes
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB02F10", Offset = "0xB02310", VA = "0x180B02F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x10E720", Offset = "0x10DB20", VA = "0x18010E720")]
		public ChangelogEntry(pb_VersionInfo version, string releaseNotes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1628D90", Offset = "0x1628190", VA = "0x181628D90", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x16291A0", Offset = "0x16285A0", VA = "0x1816291A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1628F40", Offset = "0x1628340", VA = "0x181628F40")]
		public Changelog(string log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1628E00", Offset = "0x1628200", VA = "0x181628E00")]
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
			[Cpp2IlInjected.Address(RVA = "0x1629380", Offset = "0x1628780", VA = "0x181629380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static pb_ActionResult NoSelection
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1629320", Offset = "0x1628720", VA = "0x181629320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static pb_ActionResult UserCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x16293E0", Offset = "0x16287E0", VA = "0x1816293E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x180D40", Offset = "0x180140", VA = "0x180180D40")]
		public pb_ActionResult(Status status, string notification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1629440", Offset = "0x1628840", VA = "0x181629440")]
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
		[Cpp2IlInjected.Address(RVA = "0x162A580", Offset = "0x1629980", VA = "0x18162A580")]
		public pb_BezierPoint(Vector3 position, Vector3 tangentIn, Vector3 tangentOut, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1629B10", Offset = "0x1628F10", VA = "0x181629B10")]
		public void EnforceTangentMode(pb_BezierTangentDirection master, pb_BezierTangentMode mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x162A3D0", Offset = "0x16297D0", VA = "0x18162A3D0")]
		public void SetPosition(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x162A540", Offset = "0x1629940", VA = "0x18162A540")]
		public void SetTangentIn(Vector3 tangent, pb_BezierTangentMode mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x162A560", Offset = "0x1629960", VA = "0x18162A560")]
		public void SetTangentOut(Vector3 tangent, pb_BezierTangentMode mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x162A2F0", Offset = "0x16296F0", VA = "0x18162A2F0")]
		public static Vector3 QuadraticPosition(pb_BezierPoint a, pb_BezierPoint b, float t)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1629460", Offset = "0x1628860", VA = "0x181629460")]
		public static Vector3 CubicPosition(pb_BezierPoint a, pb_BezierPoint b, float t)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1629B20", Offset = "0x1628F20", VA = "0x181629B20")]
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
			[Cpp2IlInjected.Address(RVA = "0x162AA10", Offset = "0x1629E10", VA = "0x18162AA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6D1F0", Offset = "0x6C5F0", VA = "0x18006D1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x162A990", Offset = "0x1629D90", VA = "0x18162A990")]
		public pb_BezierShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x162A5C0", Offset = "0x16299C0", VA = "0x18162A5C0")]
		public void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x162A8C0", Offset = "0x1629CC0", VA = "0x18162A8C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x162D160", Offset = "0x162C560", VA = "0x18162D160")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x162D180", Offset = "0x162C580", VA = "0x18162D180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector2 extents
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xB03780", Offset = "0xB02B80", VA = "0x180B03780")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Vector2[] corners
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x162CFB0", Offset = "0x162C3B0", VA = "0x18162CFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x162C4F0", Offset = "0x162B8F0", VA = "0x18162C4F0")]
		public pb_Bounds2D()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x162BD10", Offset = "0x162B110", VA = "0x18162BD10")]
		public pb_Bounds2D(Vector2 center, Vector2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x162C5B0", Offset = "0x162B9B0", VA = "0x18162C5B0")]
		public pb_Bounds2D(Vector2[] points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x162C400", Offset = "0x162B800", VA = "0x18162C400")]
		public pb_Bounds2D(Vector2[] points, int[] indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x162C690", Offset = "0x162BA90", VA = "0x18162C690")]
		public pb_Bounds2D(Vector2[] points, pb_Edge[] edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x162BE30", Offset = "0x162B230", VA = "0x18162BE30")]
		internal pb_Bounds2D(Vector3[] points, pb_Edge[] edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x162CC20", Offset = "0x162C020", VA = "0x18162CC20")]
		public pb_Bounds2D(Vector2[] points, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x162ACE0", Offset = "0x162A0E0", VA = "0x18162ACE0")]
		public bool ContainsPoint(Vector2 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x162AD40", Offset = "0x162A140", VA = "0x18162AD40")]
		public bool IntersectsLineSegment(Vector2 lineStart, Vector2 lineEnd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x162B090", Offset = "0x162A490", VA = "0x18162B090")]
		public bool Intersects(pb_Bounds2D bounds)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x162B200", Offset = "0x162A600", VA = "0x18162B200")]
		public bool Intersects(Rect rect)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x162B7D0", Offset = "0x162ABD0", VA = "0x18162B7D0")]
		public void SetWithPoints(IList<Vector2> points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x162B360", Offset = "0x162A760", VA = "0x18162B360")]
		public void SetWithPoints(IList<Vector2> points, IList<int> indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x162ABE0", Offset = "0x1629FE0", VA = "0x18162ABE0")]
		public static Vector2 Center(Vector2[] points, int length = -1)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x162AAA0", Offset = "0x1629EA0", VA = "0x18162AAA0")]
		public static Vector2 Center(Vector2[] points, int[] indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x162BA90", Offset = "0x162AE90", VA = "0x18162BA90", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x162D390", Offset = "0x162C790", VA = "0x18162D390")]
		private static OutCode ComputeOutCode(Rect rect, float x, float y)
		{
			return default(OutCode);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x162D420", Offset = "0x162C820", VA = "0x18162D420")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A850", Offset = "0x149C50", VA = "0x18014A850")]
		public pb_ColliderBehaviour()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x162D7B0", Offset = "0x162CBB0", VA = "0x18162D7B0", Slot = "4")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x162DA70", Offset = "0x162CE70", VA = "0x18162DA70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x162E1C0", Offset = "0x162D5C0", VA = "0x18162E1C0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x162E240", Offset = "0x162D640", VA = "0x18162E240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x162E170", Offset = "0x162D570", VA = "0x18162E170")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x162E140", Offset = "0x162D540", VA = "0x18162E140")]
		public pb_ColorPalette()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x162DB80", Offset = "0x162CF80", VA = "0x18162DB80", Slot = "4")]
		public void SetDefaultValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x162DB00", Offset = "0x162CF00", VA = "0x18162DB00")]
		public void CopyTo(pb_ColorPalette target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xE3F20", Offset = "0xE3320", VA = "0x1800E3F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x162D340", Offset = "0x162C740", VA = "0x18162D340")]
		public pb_HsvColor(float h, float s, float v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x164BBE0", Offset = "0x164AFE0", VA = "0x18164BBE0")]
		public pb_HsvColor(float h, float s, float v, float sv_modifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x164BA80", Offset = "0x164AE80", VA = "0x18164BA80")]
		public static pb_HsvColor FromRGB(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x164BB30", Offset = "0x164AF30", VA = "0x18164BB30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x164BAE0", Offset = "0x164AEE0", VA = "0x18164BAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x162D340", Offset = "0x162C740", VA = "0x18162D340")]
		public pb_XYZ_Color(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x201EB40", Offset = "0x201DF40", VA = "0x18201EB40")]
		public static pb_XYZ_Color FromRGB(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x201EAB0", Offset = "0x201DEB0", VA = "0x18201EAB0")]
		public static pb_XYZ_Color FromRGB(float R, float G, float B)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x201EBA0", Offset = "0x201DFA0", VA = "0x18201EBA0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x162D340", Offset = "0x162C740", VA = "0x18162D340")]
		public pb_CIE_Lab_Color(float L, float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x162D230", Offset = "0x162C630", VA = "0x18162D230")]
		public static pb_CIE_Lab_Color FromXYZ(pb_XYZ_Color xyz)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x162D1C0", Offset = "0x162C5C0", VA = "0x18162D1C0")]
		public static pb_CIE_Lab_Color FromRGB(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x162D290", Offset = "0x162C690", VA = "0x18162D290", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1644850", Offset = "0x1643C50", VA = "0x181644850")]
		private static bool approx(float lhs, float rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x162EA90", Offset = "0x162DE90", VA = "0x18162EA90")]
		public static pb_XYZ_Color RGBToXYZ(Color col)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x162EB00", Offset = "0x162DF00", VA = "0x18162EB00")]
		public static pb_XYZ_Color RGBToXYZ(float r, float g, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x162EFA0", Offset = "0x162E3A0", VA = "0x18162EFA0")]
		public static pb_CIE_Lab_Color XYZToCIE_Lab(pb_XYZ_Color xyz)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x162E340", Offset = "0x162D740", VA = "0x18162E340")]
		public static float DeltaE(pb_CIE_Lab_Color lhs, pb_CIE_Lab_Color rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x162E6F0", Offset = "0x162DAF0", VA = "0x18162E6F0")]
		public static Color HSVtoRGB(pb_HsvColor hsv)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x162E8F0", Offset = "0x162DCF0", VA = "0x18162E8F0")]
		public static Color HSVtoRGB(float h, float s, float v)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x162ED10", Offset = "0x162E110", VA = "0x18162ED10")]
		public static pb_HsvColor RGBtoHSV(Color color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x162E440", Offset = "0x162D840", VA = "0x18162E440")]
		public static string GetColorName(Color InColor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x162E2B0", Offset = "0x162D6B0", VA = "0x18162E2B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1644A50", Offset = "0x1643E50", VA = "0x181644A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DFC10", Offset = "0x6DF010", VA = "0x1806DFC10")]
		public pb_Edge(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1646580", Offset = "0x1645980", VA = "0x181646580")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x16468B0", Offset = "0x1645CB0", VA = "0x1816468B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x16464F0", Offset = "0x16458F0", VA = "0x1816464F0", Slot = "4")]
		public bool Equals(pb_Edge edge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x16463F0", Offset = "0x16457F0", VA = "0x1816463F0", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1646550", Offset = "0x1645950", VA = "0x181646550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1646930", Offset = "0x1645D30", VA = "0x181646930")]
		public static pb_Edge operator +(pb_Edge a, pb_Edge b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1646A20", Offset = "0x1645E20", VA = "0x181646A20")]
		public static pb_Edge operator -(pb_Edge a, pb_Edge b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1646910", Offset = "0x1645D10", VA = "0x181646910")]
		public static pb_Edge operator +(pb_Edge a, int b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1646A40", Offset = "0x1645E40", VA = "0x181646A40")]
		public static pb_Edge operator -(pb_Edge a, int b)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1646950", Offset = "0x1645D50", VA = "0x181646950")]
		public static bool operator ==(pb_Edge a, pb_Edge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1646980", Offset = "0x1645D80", VA = "0x181646980")]
		public static bool operator !=(pb_Edge a, pb_Edge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x16465A0", Offset = "0x16459A0", VA = "0x1816465A0")]
		public int[] ToArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1646320", Offset = "0x1645720", VA = "0x181646320")]
		public bool Equals(pb_Edge b, Dictionary<int, int> lookup)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1646230", Offset = "0x1645630", VA = "0x181646230")]
		public bool Contains(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x16460D0", Offset = "0x16454D0", VA = "0x1816460D0")]
		public bool Contains(pb_Edge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1646100", Offset = "0x1645500", VA = "0x181646100")]
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
			[Cpp2IlInjected.Address(RVA = "0x1644E90", Offset = "0x1644290", VA = "0x181644E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x10E720", Offset = "0x10DB20", VA = "0x18010E720")]
		public pb_EdgeConnection(pb_Face face, List<pb_Edge> edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1644CE0", Offset = "0x16440E0", VA = "0x181644CE0", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1644CB0", Offset = "0x16440B0", VA = "0x181644CB0", Slot = "4")]
		public bool Equals(pb_EdgeConnection fc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x456A70", Offset = "0x455E70", VA = "0x180456A70")]
		public static explicit operator pb_Face(pb_EdgeConnection fc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1644DF0", Offset = "0x16441F0", VA = "0x181644DF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1644E00", Offset = "0x1644200", VA = "0x181644E00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1644A60", Offset = "0x1643E60", VA = "0x181644A60")]
		public static List<int> AllTriangles(List<pb_EdgeConnection> ec)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class pb_EdgeExtension
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x16453B0", Offset = "0x16447B0", VA = "0x1816453B0")]
		public static pb_Edge[] GetUniversalEdges(pb_Edge[] edges, Dictionary<int, int> sharedIndicesLookup)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x16454E0", Offset = "0x16448E0", VA = "0x1816454E0")]
		public static pb_Edge[] GetUniversalEdges(pb_Edge[] edges, pb_IntArray[] sharedIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x16452F0", Offset = "0x16446F0", VA = "0x1816452F0")]
		internal static pb_Edge GetLocalEdgeFast(pb_Edge edge, pb_IntArray[] sharedIndices)
		{
			return default(pb_Edge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1645750", Offset = "0x1644B50", VA = "0x181645750")]
		public static bool ValidateEdge(pb_Object pb, pb_Edge edge, out pb_Tuple<pb_Face, pb_Edge> validEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1644EE0", Offset = "0x16442E0", VA = "0x181644EE0")]
		internal static pb_Edge[] AllEdges(pb_Face[] faces)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1645270", Offset = "0x1644670", VA = "0x181645270")]
		internal static bool Contains(this pb_Edge[] edges, pb_Edge edge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x16451D0", Offset = "0x16445D0", VA = "0x1816451D0")]
		internal static bool Contains(this pb_Edge[] edges, int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1645620", Offset = "0x1644A20", VA = "0x181645620")]
		internal static int IndexOf(this IList<pb_Edge> edges, pb_Edge edge, Dictionary<int, int> lookup)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1644FC0", Offset = "0x16443C0", VA = "0x181644FC0")]
		internal static int[] AllTriangles(this pb_Edge[] edges)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x16450E0", Offset = "0x16444E0", VA = "0x1816450E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1646090", Offset = "0x1645490", VA = "0x181646090")]
		public pb_EdgeLookup(pb_Edge common, pb_Edge local)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1646020", Offset = "0x1645420", VA = "0x181646020")]
		public pb_EdgeLookup(int cx, int cy, int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1645AD0", Offset = "0x1644ED0", VA = "0x181645AD0", Slot = "4")]
		public bool Equals(pb_EdgeLookup b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1645B90", Offset = "0x1644F90", VA = "0x181645B90", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1645F60", Offset = "0x1645360", VA = "0x181645F60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1645F90", Offset = "0x1645390", VA = "0x181645F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1645EA0", Offset = "0x16452A0", VA = "0x181645EA0")]
		public static IEnumerable<pb_EdgeLookup> GetEdgeLookup(IEnumerable<pb_Edge> edges, Dictionary<int, int> lookup)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1645C60", Offset = "0x1645060", VA = "0x181645C60")]
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
			[Cpp2IlInjected.Address(RVA = "0xB03570", Offset = "0xB02970", VA = "0x180B03570")]
			get
			{
				return default(EntityType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x68C30", Offset = "0x68030", VA = "0x180068C30")]
		public pb_Entity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1646BC0", Offset = "0x1645FC0", VA = "0x181646BC0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xDF4B0", Offset = "0xDE8B0", VA = "0x1800DF4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A850", Offset = "0x149C50", VA = "0x18014A850")]
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
		[Cpp2IlInjected.Address(RVA = "0x1646A60", Offset = "0x1645E60", VA = "0x181646A60")]
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
			[Cpp2IlInjected.Address(RVA = "0xB02F20", Offset = "0xB02320", VA = "0x180B02F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int[] distinctIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x1649340", Offset = "0x1648740", VA = "0x181649340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public pb_Edge[] edges
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1649360", Offset = "0x1648760", VA = "0x181649360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int smoothingGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB03770", Offset = "0xB02B70", VA = "0x180B03770")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1D6440", Offset = "0x1D5840", VA = "0x1801D6440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material material
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB04530", Offset = "0xB03930", VA = "0x180B04530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6D1F0", Offset = "0x6C5F0", VA = "0x18006D1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public pb_UV uv
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xB0CD10", Offset = "0xB0C110", VA = "0x180B0CD10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x72C10", Offset = "0x72010", VA = "0x180072C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x137BCB0", Offset = "0x137B0B0", VA = "0x18137BCB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1649270", Offset = "0x1648670", VA = "0x181649270")]
		public pb_Face()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x16491D0", Offset = "0x16485D0", VA = "0x1816491D0")]
		public pb_Face(int[] i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1649280", Offset = "0x1648680", VA = "0x181649280")]
		public pb_Face(int[] i, Material m, pb_UV u, int smoothingGroup, int textureGroup, int elementGroup, bool manualUV)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x16490B0", Offset = "0x16484B0", VA = "0x1816490B0")]
		public pb_Face(pb_Face face)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1647860", Offset = "0x1646C60", VA = "0x181647860")]
		public void CopyFrom(pb_Face other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1648340", Offset = "0x1647740", VA = "0x181648340")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1647960", Offset = "0x1646D60", VA = "0x181647960")]
		public pb_Edge[] GetAllEdges()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x16483C0", Offset = "0x16477C0", VA = "0x1816483C0")]
		public void SetIndices(int[] i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x16485D0", Offset = "0x16479D0", VA = "0x1816485D0")]
		public void ShiftIndices(int offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1648640", Offset = "0x1647A40", VA = "0x181648640")]
		public int SmallestIndexValue()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x16483F0", Offset = "0x16477F0", VA = "0x1816483F0")]
		public void ShiftIndicesToZero()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1648390", Offset = "0x1647790", VA = "0x181648390")]
		public void ReverseIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1648370", Offset = "0x1647770", VA = "0x181648370")]
		public void RebuildCaches()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x16474C0", Offset = "0x16468C0", VA = "0x1816474C0")]
		private pb_Edge[] CacheEdges()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1647420", Offset = "0x1646820", VA = "0x181647420")]
		private int[] CacheDistinctIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1647710", Offset = "0x1646B10", VA = "0x181647710")]
		public bool Contains(int[] triangle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1647340", Offset = "0x1646740", VA = "0x181647340")]
		internal static int[] AllTriangles(pb_Face[] q)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x16486D0", Offset = "0x1647AD0", VA = "0x1816486D0")]
		public MeshTopology ToQuadOrTriangles(out int[] quadOrTris)
		{
			return default(MeshTopology);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x16487E0", Offset = "0x1647BE0", VA = "0x1816487E0")]
		public int[] ToQuad()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1648810", Offset = "0x1647C10", VA = "0x181648810")]
		public bool ToQuad(out int[] quad)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1647BA0", Offset = "0x1646FA0", VA = "0x181647BA0")]
		public static int GetMeshIndices(pb_Face[] faces, out pb_Submesh[] submeshes, MeshTopology preferredTopology = MeshTopology.Triangles)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1648EA0", Offset = "0x16482A0", VA = "0x181648EA0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1647330", Offset = "0x1646730", VA = "0x181647330")]
		public pb_FaceRebuildData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1647290", Offset = "0x1646690", VA = "0x181647290")]
		public int Offset()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x16472A0", Offset = "0x16466A0", VA = "0x1816472A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1646C70", Offset = "0x1646070", VA = "0x181646C70")]
		public static void Apply(IEnumerable<pb_FaceRebuildData> newFaces, pb_Object pb, [Optional] List<pb_Vertex> vertices, [Optional] List<pb_Face> faces, [Optional] Dictionary<int, int> lookup, [Optional] Dictionary<int, int> lookupUV)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1646E30", Offset = "0x1646230", VA = "0x181646E30")]
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
		[Cpp2IlInjected.Address(RVA = "0xEBCB0", Offset = "0xEB0B0", VA = "0x1800EBCB0")]
		public pb_HandleConstraint2D(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1649560", Offset = "0x1648960", VA = "0x181649560")]
		public pb_HandleConstraint2D Inverse()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x16495E0", Offset = "0x16489E0", VA = "0x1816495E0")]
		public Vector2 Mask(Vector2 v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1649510", Offset = "0x1648910", VA = "0x181649510")]
		public Vector2 InverseMask(Vector2 v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x16498E0", Offset = "0x1648CE0", VA = "0x1816498E0")]
		public static bool operator ==(pb_HandleConstraint2D a, pb_HandleConstraint2D b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1649920", Offset = "0x1648D20", VA = "0x181649920")]
		public static bool operator !=(pb_HandleConstraint2D a, pb_HandleConstraint2D b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1644DF0", Offset = "0x16441F0", VA = "0x181644DF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1649380", Offset = "0x1648780", VA = "0x181649380", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1649610", Offset = "0x1648A10", VA = "0x181649610", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x164B6A0", Offset = "0x164AAA0", VA = "0x18164B6A0")]
		public static Vector3 ScreenToGuiPoint(this Camera camera, Vector3 point, float pixelsPerPoint)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x164AB20", Offset = "0x1649F20", VA = "0x18164AB20")]
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out pb_RaycastHit hit, [Optional] HashSet<pb_Face> ignore)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1649960", Offset = "0x1648D60", VA = "0x181649960")]
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out pb_RaycastHit hit, float distance, pb_Culling cullingMode, [Optional] HashSet<pb_Face> ignore)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x164A220", Offset = "0x1649620", VA = "0x18164A220")]
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out List<pb_RaycastHit> hits, float distance, pb_Culling cullingMode, [Optional] HashSet<pb_Face> ignore)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x164AB80", Offset = "0x1649F80", VA = "0x18164AB80")]
		public static Ray InverseTransformRay(this Transform transform, Ray InWorldRay)
		{
			return default(Ray);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x164B730", Offset = "0x164AB30", VA = "0x18164B730")]
		public static bool WorldRaycast(Ray InWorldRay, Transform transform, Vector3[] vertices, int[] triangles, out pb_RaycastHit hit, float distance = float.PositiveInfinity, pb_Culling cullingMode = pb_Culling.Front)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x164B130", Offset = "0x164A530", VA = "0x18164B130")]
		public static bool MeshRaycast(Ray InRay, Vector3[] vertices, int[] triangles, out pb_RaycastHit hit, float distance = float.PositiveInfinity, pb_Culling cullingMode = pb_Culling.Front)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x164B430", Offset = "0x164A830", VA = "0x18164B430")]
		internal static bool PointIsOccluded(Camera cam, pb_Object pb, Vector3 worldPoint)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x164AE90", Offset = "0x164A290", VA = "0x18164AE90")]
		internal static bool IsOccluded(Camera cam, pb_Object pb, pb_Face face)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal class ProGridsNoSnapAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xB5CD0", Offset = "0xB50D0", VA = "0x1800B5CD0")]
		public ProGridsNoSnapAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class ProGridsConditionalSnapAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xB5CD0", Offset = "0xB50D0", VA = "0x1800B5CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x137BCB0", Offset = "0x137B0B0", VA = "0x18137BCB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x164E4F0", Offset = "0x164D8F0", VA = "0x18164E4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA5F310", Offset = "0xA5E710", VA = "0x180A5F310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x86F80", Offset = "0x86380", VA = "0x180086F80")]
		public pb_IntArray(int[] intArray)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x164E3E0", Offset = "0x164D7E0", VA = "0x18164E3E0")]
		public pb_IntArray(pb_IntArray intArray)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x164E330", Offset = "0x164D730", VA = "0x18164E330")]
		internal List<int> ToList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x456A70", Offset = "0x455E70", VA = "0x180456A70")]
		public static implicit operator int[](pb_IntArray intArr)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x164E490", Offset = "0x164D890", VA = "0x18164E490")]
		public static explicit operator pb_IntArray(int[] arr)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x164E390", Offset = "0x164D790", VA = "0x18164E390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x164E220", Offset = "0x164D620", VA = "0x18164E220")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x164E240", Offset = "0x164D640", VA = "0x18164E240")]
		public static void RemoveEmptyOrNull(ref pb_IntArray[] val)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class pb_IntArrayUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x164D3F0", Offset = "0x164C7F0", VA = "0x18164D3F0")]
		public static int[][] ToArray(this pb_IntArray[] val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x164D510", Offset = "0x164C910", VA = "0x18164D510")]
		public static Dictionary<int, int> ToDictionary(this pb_IntArray[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x164D920", Offset = "0x164CD20", VA = "0x18164D920")]
		public static pb_IntArray[] ToSharedIndices(this IEnumerable<KeyValuePair<int, int>> lookup)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x164D7D0", Offset = "0x164CBD0", VA = "0x18164D7D0")]
		public static pb_IntArray[] ToPbIntArray(this int[][] val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x164D660", Offset = "0x164CA60", VA = "0x18164D660")]
		public static pb_IntArray[] ToPbIntArray(this List<List<int>> val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x164C790", Offset = "0x164BB90", VA = "0x18164C790")]
		public static int IndexOf(this pb_IntArray[] intArray, int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x164BE90", Offset = "0x164B290", VA = "0x18164BE90")]
		public static List<int> AllIndicesWithValues(this pb_IntArray[] pbIntArr, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x164BFB0", Offset = "0x164B3B0", VA = "0x18164BFB0")]
		public static List<int> AllIndicesWithValues(this pb_IntArray[] pbIntArr, Dictionary<int, int> lookup, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x164DE60", Offset = "0x164D260", VA = "0x18164DE60")]
		internal static List<int> UniqueIndicesWithValues(this pb_IntArray[] pbIntArr, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x164C6A0", Offset = "0x164BAA0", VA = "0x18164C6A0")]
		internal static HashSet<int> GetCommonIndices(this pb_IntArray[] pbIntArr, IEnumerable<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x164C4B0", Offset = "0x164B8B0", VA = "0x18164C4B0")]
		internal static HashSet<int> GetCommonIndices(Dictionary<int, int> lookup, IEnumerable<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x164C6D0", Offset = "0x164BAD0", VA = "0x18164C6D0")]
		[Obsolete]
		internal static IEnumerable<int> GetIndicesWithCommon(this pb_IntArray[] pbIntArr, IEnumerable<int> common)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x164C0C0", Offset = "0x164B4C0", VA = "0x18164C0C0")]
		public static pb_IntArray[] ExtractSharedIndices(Vector3[] v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x164CA60", Offset = "0x164BE60", VA = "0x18164CA60")]
		internal static int MergeSharedIndices(ref pb_IntArray[] sharedIndices, int[] indices)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x164C850", Offset = "0x164BC50", VA = "0x18164C850")]
		internal static void MergeSharedIndices(ref pb_IntArray[] sharedIndices, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x164BD50", Offset = "0x164B150", VA = "0x18164BD50")]
		internal static int AddValueAtIndex(ref pb_IntArray[] sharedIndices, int sharedIndex, int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x164BC50", Offset = "0x164B050", VA = "0x18164BC50")]
		internal static int AddRangeAtIndex(ref pb_IntArray[] sharedIndices, int sharedIndex, int[] indices)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x164D270", Offset = "0x164C670", VA = "0x18164D270")]
		internal static void RemoveValues(ref pb_IntArray[] sharedIndices, int[] remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x164CE60", Offset = "0x164C260", VA = "0x18164CE60")]
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
			[Cpp2IlInjected.Address(RVA = "0xB12FD0", Offset = "0xB123D0", VA = "0x180B12FD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float y
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1589E50", Offset = "0x1589250", VA = "0x181589E50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float z
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xB12FF0", Offset = "0xB123F0", VA = "0x180B12FF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x11BC480", Offset = "0x11BB880", VA = "0x1811BC480")]
		public pb_IntVec3(Vector3 vector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x164EBB0", Offset = "0x164DFB0", VA = "0x18164EBB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x164EC60", Offset = "0x164E060", VA = "0x18164EC60")]
		public static bool operator ==(pb_IntVec3 a, pb_IntVec3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x164ECB0", Offset = "0x164E0B0", VA = "0x18164ECB0")]
		public static bool operator !=(pb_IntVec3 a, pb_IntVec3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x164E930", Offset = "0x164DD30", VA = "0x18164E930", Slot = "4")]
		public bool Equals(pb_IntVec3 p)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x164EB20", Offset = "0x164DF20", VA = "0x18164EB20")]
		public bool Equals(Vector3 p)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x164E650", Offset = "0x164DA50", VA = "0x18164E650", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x164EB80", Offset = "0x164DF80", VA = "0x18164EB80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x164ED00", Offset = "0x164E100", VA = "0x18164ED00")]
		private static int round(float v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x164EC90", Offset = "0x164E090", VA = "0x18164EC90")]
		public static implicit operator Vector3(pb_IntVec3 p)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x164EC90", Offset = "0x164E090", VA = "0x18164EC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x164F8E0", Offset = "0x164ECE0", VA = "0x18164F8E0")]
		public pb_LineRenderer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x164F2B0", Offset = "0x164E6B0", VA = "0x18164F2B0")]
		private static Mesh MeshConstructor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x164F520", Offset = "0x164E920", VA = "0x18164F520", Slot = "5")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x164F4D0", Offset = "0x164E8D0", VA = "0x18164F4D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x164F0E0", Offset = "0x164E4E0", VA = "0x18164F0E0", Slot = "4")]
		public override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x164F330", Offset = "0x164E730", VA = "0x18164F330")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x164ED70", Offset = "0x164E170", VA = "0x18164ED70")]
		public void AddLineSegments(Vector3[] segments, Color[] colors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x164F1F0", Offset = "0x164E5F0", VA = "0x18164F1F0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x164F620", Offset = "0x164EA20", VA = "0x18164F620")]
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
		[Cpp2IlInjected.Address(RVA = "0x1650210", Offset = "0x164F610", VA = "0x181650210")]
		public static void PushLogLevel(pb_LogLevel level)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x164FE00", Offset = "0x164F200", VA = "0x18164FE00")]
		public static void PopLogLevel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1650300", Offset = "0x164F700", VA = "0x181650300")]
		public static void SetLogLevel(pb_LogLevel level)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1650360", Offset = "0x164F760", VA = "0x181650360")]
		public static void SetOutput(pb_LogOutput output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x16502A0", Offset = "0x164F6A0", VA = "0x1816502A0")]
		public static void SetLogFile(string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x87520", Offset = "0x86920", VA = "0x180087520")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public static void Debug<T>(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x164FA00", Offset = "0x164EE00", VA = "0x18164FA00")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public static void Debug(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x87520", Offset = "0x86920", VA = "0x180087520")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		public static void Debug(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x164FC80", Offset = "0x164F080", VA = "0x18164FC80")]
		public static void Info(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x164FD70", Offset = "0x164F170", VA = "0x18164FD70")]
		public static void Info(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1650450", Offset = "0x164F850", VA = "0x181650450")]
		public static void Warning(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x16503C0", Offset = "0x164F7C0", VA = "0x1816503C0")]
		public static void Warning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x164FB70", Offset = "0x164EF70", VA = "0x18164FB70")]
		public static void Error(string format, params object[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x164FBF0", Offset = "0x164EFF0", VA = "0x18164FBF0")]
		public static void Error(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xD66F60", Offset = "0xD66360", VA = "0x180D66F60")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0xFFFFFFFE7FFFFFFF", Offset = "0x0")]
		internal static void Watch<T, K>(T key, K value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x164FA60", Offset = "0x164EE60", VA = "0x18164FA60")]
		private static void DoPrint(string message, LogType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x164FF60", Offset = "0x164F360", VA = "0x18164FF60")]
		private static void PrintToFile(string message, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x164F950", Offset = "0x164ED50", VA = "0x18164F950")]
		public static void ClearLogFile()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x164FE80", Offset = "0x164F280", VA = "0x18164FE80")]
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
			[Cpp2IlInjected.Address(RVA = "0x1650D00", Offset = "0x1650100", VA = "0x181650D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static Material DefaultMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x16506A0", Offset = "0x164FAA0", VA = "0x1816506A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal static Material FacePickerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x1650AA0", Offset = "0x164FEA0", VA = "0x181650AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal static Material VertexPickerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x1651190", Offset = "0x1650590", VA = "0x181651190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		internal static Material EdgePickerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x16508D0", Offset = "0x164FCD0", VA = "0x1816508D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal static Material TriggerMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x1650DA0", Offset = "0x16501A0", VA = "0x181650DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal static Material ColliderMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x16505E0", Offset = "0x164F9E0", VA = "0x1816505E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1650C40", Offset = "0x1650040", VA = "0x181650C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal static Material UnityDefaultDiffuse
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x1650E60", Offset = "0x1650260", VA = "0x181650E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		internal static Material UnlitVertexColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x1651060", Offset = "0x1650460", VA = "0x181651060")]
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
		[Cpp2IlInjected.Address(RVA = "0x1655A90", Offset = "0x1654E90", VA = "0x181655A90")]
		public static Vector2 PointInCircumference(float radius, float angleInDegrees, Vector2 origin)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x16562A0", Offset = "0x16556A0", VA = "0x1816562A0")]
		internal static Vector3 PointInSphere(float radius, float latitudeAngle, float longitudeAngle)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1657600", Offset = "0x1656A00", VA = "0x181657600")]
		public static float SignedAngle(Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1657890", Offset = "0x1656C90", VA = "0x181657890")]
		public static float SqrDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1657D70", Offset = "0x1657170", VA = "0x181657D70")]
		public static float TriangleArea(Vector3 x, Vector3 y, Vector3 z)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x16563D0", Offset = "0x16557D0", VA = "0x1816563D0")]
		internal static float PolygonArea(Vector3[] vertices, int[] indices)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x16573F0", Offset = "0x16567F0", VA = "0x1816573F0")]
		internal static Vector2 RotateAroundPoint(this Vector2 v, Vector2 origin, float theta)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x16574E0", Offset = "0x16568E0", VA = "0x1816574E0")]
		public static Vector2 ScaleAroundPoint(this Vector2 v, Vector2 origin, Vector2 scale)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x16559E0", Offset = "0x1654DE0", VA = "0x1816559E0")]
		internal static Vector2 Perpendicular(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1655A40", Offset = "0x1654E40", VA = "0x181655A40")]
		public static Vector2 Perpendicular(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1657210", Offset = "0x1656610", VA = "0x181657210")]
		public static Vector2 ReflectPoint(Vector2 point, Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1652D60", Offset = "0x1652160", VA = "0x181652D60")]
		public static float DistancePointLineSegment(Vector2 p, Vector2 v, Vector2 w)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1652F70", Offset = "0x1652370", VA = "0x181652F70")]
		public static float DistancePointLineSegment(Vector3 p, Vector3 v, Vector3 w)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1653530", Offset = "0x1652930", VA = "0x181653530")]
		public static Vector3 GetNearestPointRayRay(Vector3 ao, Vector3 ad, Vector3 bo, Vector3 bd)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1653390", Offset = "0x1652790", VA = "0x181653390")]
		internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, ref Vector2 intersect)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x16532A0", Offset = "0x16526A0", VA = "0x1816532A0")]
		internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1655B50", Offset = "0x1654F50", VA = "0x181655B50")]
		internal static bool PointInPolygon(Vector2[] polygon, Vector2 point, [Optional] int[] indices)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x1655EE0", Offset = "0x16552E0", VA = "0x181655EE0")]
		internal static bool PointInPolygon(Vector2[] positions, pb_Bounds2D polyBounds, pb_Edge[] edges, Vector2 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1656070", Offset = "0x1655470", VA = "0x181656070")]
		internal static bool PointInPolygon(Vector3[] positions, pb_Bounds2D polyBounds, pb_Edge[] edges, Vector2 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x16571B0", Offset = "0x16565B0", VA = "0x1816571B0")]
		internal static bool RectIntersectsLineSegment(Rect rect, Vector2 a, Vector2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1657160", Offset = "0x1656560", VA = "0x181657160")]
		internal static bool RectIntersectsLineSegment(Rect rect, Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1656C40", Offset = "0x1656040", VA = "0x181656C40")]
		public static bool RayIntersectsTriangle(Ray InRay, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, out float OutDistance, out Vector3 OutPoint)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1656700", Offset = "0x1655B00", VA = "0x181656700")]
		internal static bool RayIntersectsTriangle2(Vector3 origin, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, ref float distance, ref Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1657590", Offset = "0x1656990", VA = "0x181657590")]
		public static float Secant(float x)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1654A10", Offset = "0x1653E10", VA = "0x181654A10")]
		public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1654F80", Offset = "0x1654380", VA = "0x181654F80")]
		internal static Vector3 Normal(IList<pb_Vertex> vertices, [Optional] IList<int> indices)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1654C00", Offset = "0x1654000", VA = "0x181654C00")]
		public static Vector3 Normal(pb_Object pb, pb_Face face)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1655490", Offset = "0x1654890", VA = "0x181655490")]
		public static Vector3 Normal(IList<Vector3> p)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1653E30", Offset = "0x1653230", VA = "0x181653E30")]
		public static void NormalTangentBitangent(pb_Object pb, pb_Face face, out Vector3 normal, out Vector3 tangent, out Vector3 bitangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1653990", Offset = "0x1652D90", VA = "0x181653990")]
		internal static bool IsCardinalAxis(Vector3 v, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x68E4C0", Offset = "0x68D8C0", VA = "0x18068E4C0")]
		internal static T Max<T>(T[] array) where T : IComparable<T>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x68E640", Offset = "0x68DA40", VA = "0x18068E640")]
		internal static T Min<T>(T[] array) where T : IComparable<T>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1653C00", Offset = "0x1653000", VA = "0x181653C00")]
		internal static float LargestValue(Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1653C30", Offset = "0x1653030", VA = "0x181653C30")]
		internal static float LargestValue(Vector2 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x16576B0", Offset = "0x1656AB0", VA = "0x1816576B0")]
		internal static Vector2 SmallestVector2(Vector2[] v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1657760", Offset = "0x1656B60", VA = "0x181657760")]
		internal static Vector2 SmallestVector2(Vector2[] v, int[] indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1653D80", Offset = "0x1653180", VA = "0x181653D80")]
		internal static Vector2 LargestVector2(Vector2[] v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1653C50", Offset = "0x1653050", VA = "0x181653C50")]
		internal static Vector2 LargestVector2(Vector2[] v, int[] indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1652850", Offset = "0x1651C50", VA = "0x181652850")]
		internal static Vector3 BoundsCenter(Vector3[] verts)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1651CD0", Offset = "0x16510D0", VA = "0x181651CD0")]
		public static Vector2 Average(IList<Vector2> v, [Optional] IList<int> indices)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1651EE0", Offset = "0x16512E0", VA = "0x181651EE0")]
		public static Vector3 Average(IList<Vector3> v, [Optional] IList<int> indices)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xBEFAD0", Offset = "0xBEEED0", VA = "0x180BEFAD0")]
		public static Vector3 Average<T>(this IList<T> v, Func<T, Vector3> selector, [Optional] IList<int> indices)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x16525C0", Offset = "0x16519C0", VA = "0x1816525C0")]
		internal static Vector4 Average(IList<Vector4> v, [Optional] IList<int> indices)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1651940", Offset = "0x1650D40", VA = "0x181651940")]
		internal static Color Average(IList<Color> c, [Optional] IList<int> indices)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1651420", Offset = "0x1650820", VA = "0x181651420")]
		public static bool Approx2(this Vector2 v, Vector2 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x16514F0", Offset = "0x16508F0", VA = "0x1816514F0")]
		public static bool Approx3(this Vector3 v, Vector3 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1651600", Offset = "0x1650A00", VA = "0x181651600")]
		public static bool Approx4(this Vector4 v, Vector4 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1651750", Offset = "0x1650B50", VA = "0x181651750")]
		internal static bool ApproxC(this Color a, Color b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x16518A0", Offset = "0x1650CA0", VA = "0x1816518A0")]
		internal static bool Approx(this float a, float b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x1657F30", Offset = "0x1657330", VA = "0x181657F30")]
		internal static int Wrap(int value, int lowerBound, int upperBound)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1652C10", Offset = "0x1652010", VA = "0x181652C10")]
		public static int Clamp(int value, int lowerBound, int upperBound)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1657A90", Offset = "0x1656E90", VA = "0x181657A90")]
		internal static Vector2 ToMask(this Vector2 vec, float delta = float.Epsilon)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x1657910", Offset = "0x1656D10", VA = "0x181657910")]
		internal static Vector3 ToMask(this Vector3 vec, float delta = float.Epsilon)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1657B90", Offset = "0x1656F90", VA = "0x181657B90")]
		internal static Vector3 ToSignedMask(this Vector3 vec, float delta = float.Epsilon)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1651360", Offset = "0x1650760", VA = "0x181651360")]
		internal static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x1653900", Offset = "0x1652D00", VA = "0x181653900")]
		internal static int IntSum(this Vector3 mask)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x1652C30", Offset = "0x1652030", VA = "0x181652C30")]
		internal static void Cross(Vector3 a, Vector3 b, ref float x, ref float y, ref float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x1652D00", Offset = "0x1652100", VA = "0x181652D00")]
		internal static void Cross(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1652C90", Offset = "0x1652090", VA = "0x181652C90")]
		internal static void Cross(float ax, float ay, float az, float bx, float by, float bz, ref float x, ref float y, ref float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x16578D0", Offset = "0x1656CD0", VA = "0x1816578D0")]
		internal static void Subtract(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class pb_MeshCompiler
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1315200", Offset = "0x1314600", VA = "0x181315200")]
		public static void Compile(pb_Object pb, ref Mesh target, out Material[] materials, MeshTopology preferredTopology = MeshTopology.Triangles)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x13155E0", Offset = "0x13149E0", VA = "0x1813155E0")]
		internal static Vector2[] GetUVs(pb_Object pb)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class pb_MeshUtility
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x87240", Offset = "0x86640", VA = "0x180087240")]
		public pb_MeshUtility()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x1316F90", Offset = "0x1316390", VA = "0x181316F90")]
		public static pb_Vertex[] GeneratePerTriangleMesh(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1315F80", Offset = "0x1315380", VA = "0x181315F80")]
		public static void CollapseSharedVertices(Mesh m, [Optional] pb_Vertex[] vertices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x1317340", Offset = "0x1316740", VA = "0x181317340")]
		public static void GenerateTangent(ref Mesh InMesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1316820", Offset = "0x1315C20", VA = "0x181316820")]
		public static Mesh DeepCopy(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x13163D0", Offset = "0x13157D0", VA = "0x1813163D0")]
		public static void CopyTo(Mesh source, Mesh destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x1316880", Offset = "0x1315C80", VA = "0x181316880")]
		public static Vector3[] GenerateNormals(pb_Object pb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1319680", Offset = "0x1318A80", VA = "0x181319680")]
		public static void SmoothNormals(pb_Object pb, ref Vector3[] normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x68E7C0", Offset = "0x68DBC0", VA = "0x18068E7C0")]
		public static T GetMeshAttribute<T>(GameObject go, Func<Mesh, T> attributeGetter) where T : IList
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x1318000", Offset = "0x1317400", VA = "0x181318000")]
		public static string Print(Mesh m)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x1317E50", Offset = "0x1317250", VA = "0x181317E50")]
		public static uint GetIndexCount(Mesh m)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x1317F10", Offset = "0x1317310", VA = "0x181317F10")]
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
			[Cpp2IlInjected.Address(RVA = "0xFC96B0", Offset = "0xFC8AB0", VA = "0x180FC96B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static T nullableInstance
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xFC98D0", Offset = "0xFC8CD0", VA = "0x180FC98D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x786EF0", Offset = "0x7862F0", VA = "0x180786EF0")]
		public pb_MonoBehaviourSingleton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xFC9610", Offset = "0xFC8A10", VA = "0x180FC9610")]
		public static bool Valid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xFC94E0", Offset = "0xFC88E0", VA = "0x180FC94E0", Slot = "4")]
		public virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xFC95D0", Offset = "0xFC89D0", VA = "0x180FC95D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1320650", Offset = "0x131FA50", VA = "0x181320650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x13208F0", Offset = "0x131FCF0", VA = "0x1813208F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public pb_Face[] faces
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xB02F10", Offset = "0xB02310", VA = "0x180B02F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public pb_IntArray[] sharedIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xB02F30", Offset = "0xB02330", VA = "0x180B02F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public pb_IntArray[] sharedIndicesUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x13206A0", Offset = "0x131FAA0", VA = "0x1813206A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int id
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1320620", Offset = "0x131FA20", VA = "0x181320620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3[] vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xB02F00", Offset = "0xB02300", VA = "0x180B02F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Color[] colors
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x1320430", Offset = "0x131F830", VA = "0x181320430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2[] uv
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xB0CD10", Offset = "0xB0C110", VA = "0x180B0CD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool hasUv2
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x1320450", Offset = "0x131F850", VA = "0x181320450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool hasUv3
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x1320540", Offset = "0x131F940", VA = "0x181320540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool hasUv4
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x13205B0", Offset = "0x131F9B0", VA = "0x1813205B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public List<Vector4> uv3
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xB04530", Offset = "0xB03930", VA = "0x180B04530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public List<Vector4> uv4
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xB24070", Offset = "0xB23470", VA = "0x180B24070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int faceCount
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1320440", Offset = "0x131F840", VA = "0x181320440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int vertexCount
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x1320780", Offset = "0x131FB80", VA = "0x181320780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int triangleCount
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x13206B0", Offset = "0x131FAB0", VA = "0x1813206B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public pb_Face[] SelectedFaces
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x13203C0", Offset = "0x131F7C0", VA = "0x1813203C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public int SelectedFaceCount
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x13203A0", Offset = "0x131F7A0", VA = "0x1813203A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int[] SelectedTriangles
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xB29560", Offset = "0xB28960", VA = "0x180B29560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int SelectedTriangleCount
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1320410", Offset = "0x131F810", VA = "0x181320410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public pb_Edge[] SelectedEdges
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xB29520", Offset = "0xB28920", VA = "0x180B29520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int SelectedEdgeCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x1320380", Offset = "0x131F780", VA = "0x181320380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action<pb_Object> onDestroyObject
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x1320220", Offset = "0x131F620", VA = "0x181320220")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x1320790", Offset = "0x131FB90", VA = "0x181320790")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		internal static event Action<pb_Object> onElementSelectionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x13202D0", Offset = "0x131F6D0", VA = "0x1813202D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x1320840", Offset = "0x131FC40", VA = "0x181320840")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1320120", Offset = "0x131F520", VA = "0x181320120")]
		public pb_Object()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x131B1F0", Offset = "0x131A5F0", VA = "0x18131B1F0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x131BD20", Offset = "0x131B120", VA = "0x18131BD20")]
		public Vector3[] GetNormals()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x131C030", Offset = "0x131B430", VA = "0x18131C030")]
		public pb_IntArray[] GetSharedIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x131BE30", Offset = "0x131B230", VA = "0x18131BE30")]
		public pb_IntArray[] GetSharedIndicesUV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x131AF10", Offset = "0x131A310", VA = "0x18131AF10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x131CC80", Offset = "0x131C080", VA = "0x18131CC80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x131C5E0", Offset = "0x131B9E0", VA = "0x18131C5E0")]
		public static pb_Object InitWithObject(pb_Object pb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x131B680", Offset = "0x131AA80", VA = "0x18131B680")]
		internal static pb_Object CreateInstanceWithPoints(Vector3[] vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x131B790", Offset = "0x131AB90", VA = "0x18131B790")]
		public static pb_Object CreateInstanceWithVerticesFaces(Vector3[] v, pb_Face[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x131B360", Offset = "0x131A760", VA = "0x18131B360")]
		internal static pb_Object CreateInstanceWithElements(Vector3[] v, Vector2[] u, Color[] c, pb_Face[] f, pb_IntArray[] si, pb_IntArray[] si_uv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x131B490", Offset = "0x131A890", VA = "0x18131B490")]
		public static pb_Object CreateInstanceWithElements(pb_Vertex[] vertices, pb_Face[] faces, [Optional] pb_IntArray[] si)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x131AE90", Offset = "0x131A290", VA = "0x18131AE90")]
		internal void AddToFaceSelection(pb_Face face)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x131F010", Offset = "0x131E410", VA = "0x18131F010")]
		internal void SetSelectedFaces(IEnumerable<pb_Face> selected)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x131F200", Offset = "0x131E600", VA = "0x18131F200")]
		internal void SetSelectedFaces(IEnumerable<int> selected)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x131EF50", Offset = "0x131E350", VA = "0x18131EF50")]
		internal void SetSelectedEdges(IEnumerable<pb_Edge> edges)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x131F3C0", Offset = "0x131E7C0", VA = "0x18131F3C0")]
		internal void SetSelectedTriangles(int[] tris)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x131EA80", Offset = "0x131DE80", VA = "0x18131EA80")]
		internal void RemoveFromFaceSelectionAtIndex(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x131EAE0", Offset = "0x131DEE0", VA = "0x18131EAE0")]
		internal void RemoveFromFaceSelection(pb_Face face)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x131B150", Offset = "0x131A550", VA = "0x18131B150")]
		internal void ClearSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x72C00", Offset = "0x72000", VA = "0x180072C00")]
		public void SetVertices(Vector3[] v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x131F6A0", Offset = "0x131EAA0", VA = "0x18131F6A0")]
		public void SetVertices(IList<pb_Vertex> vertices, bool applyMesh = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x72C10", Offset = "0x72010", VA = "0x180072C10")]
		public void SetUV(Vector2[] uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x131EDB0", Offset = "0x131E1B0", VA = "0x18131EDB0")]
		public void SetFaces(IEnumerable<pb_Face> newFaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x76730", Offset = "0x75B30", VA = "0x180076730")]
		public void SetSharedIndices(pb_IntArray[] si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x131F4D0", Offset = "0x131E8D0", VA = "0x18131F4D0")]
		public void SetSharedIndices(IEnumerable<KeyValuePair<int, int>> si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x195D20", Offset = "0x195120", VA = "0x180195D20")]
		internal void SetSharedIndicesUV(pb_IntArray[] si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x131F4B0", Offset = "0x131E8B0", VA = "0x18131F4B0")]
		internal void SetSharedIndicesUV(IEnumerable<KeyValuePair<int, int>> si)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x131B840", Offset = "0x131AC40", VA = "0x18131B840")]
		private void GeometryWithPoints(Vector3[] v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x131BC50", Offset = "0x131B050", VA = "0x18131BC50")]
		public void GeometryWithVerticesFaces(Vector3[] v, pb_Face[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x131FE70", Offset = "0x131F270", VA = "0x18131FE70")]
		public MeshRebuildReason Verify()
		{
			return default(MeshRebuildReason);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x131FCB0", Offset = "0x131F0B0", VA = "0x18131FCB0")]
		public void ToMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x131F910", Offset = "0x131ED10", VA = "0x18131F910")]
		public void ToMesh(MeshTopology preferredTopology)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x131C990", Offset = "0x131BD90", VA = "0x18131C990")]
		internal void MakeUnique()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x131E7D0", Offset = "0x131DBD0", VA = "0x18131E7D0")]
		public void Refresh(RefreshMask mask = RefreshMask.All)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x131CD80", Offset = "0x131C180", VA = "0x18131CD80")]
		private void RefreshCollisions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x131C4C0", Offset = "0x131B8C0", VA = "0x18131C4C0")]
		internal int GetUnusedTextureGroup(int i = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x131FD50", Offset = "0x131F150", VA = "0x18131FD50")]
		internal int UnusedElementGroup(int i = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x131C230", Offset = "0x131B630", VA = "0x18131C230")]
		public void GetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x131F560", Offset = "0x131E960", VA = "0x18131F560")]
		public void SetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x131D910", Offset = "0x131CD10", VA = "0x18131D910")]
		private void RefreshUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x131D920", Offset = "0x131CD20", VA = "0x18131D920")]
		internal void RefreshUV(IEnumerable<pb_Face> facesToRefresh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x131ED30", Offset = "0x131E130", VA = "0x18131ED30")]
		public void SetFaceMaterial(pb_Face[] facesToApply, Material mat)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x131F4F0", Offset = "0x131E8F0", VA = "0x18131F4F0")]
		public void SetUV2(Vector2[] v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x131D670", Offset = "0x131CA70", VA = "0x18131D670")]
		private void RefreshColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x131EB60", Offset = "0x131DF60", VA = "0x18131EB60")]
		public void SetColors(Color[] InColors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x131EC10", Offset = "0x131E010", VA = "0x18131EC10")]
		public void SetFaceColor(pb_Face face, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x18AA80", Offset = "0x189E80", VA = "0x18018AA80")]
		public void SetTangents(Vector4[] tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x131D750", Offset = "0x131CB50", VA = "0x18131D750")]
		private void RefreshNormals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x131D870", Offset = "0x131CC70", VA = "0x18131D870")]
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
		[Cpp2IlInjected.Address(RVA = "0xFC9EC0", Offset = "0xFC92C0", VA = "0x180FC9EC0")]
		public pb_ObjectPool(int initialSize, int desiredSize, Func<T> constructor, Action<T> destructor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xFC9C80", Offset = "0xFC9080", VA = "0x180FC9C80")]
		public T Get()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xFC9E10", Offset = "0xFC9210", VA = "0x180FC9E10")]
		public void Put(T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xFC9B40", Offset = "0xFC8F40", VA = "0x180FC9B40")]
		public void Empty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xFC9AE0", Offset = "0xFC8EE0", VA = "0x180FC9AE0")]
		private static void DestroyObject(T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xFC9DE0", Offset = "0xFC91E0", VA = "0x180FC9DE0")]
		private void OnDestroy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class pb_ObjectUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x131AD50", Offset = "0x131A150", VA = "0x18131AD50")]
		public static Vector3[] VerticesInWorldSpace(this pb_Object pb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x131AC30", Offset = "0x131A030", VA = "0x18131AC30")]
		public static Vector3[] VerticesInWorldSpace(this pb_Object pb, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x131A9E0", Offset = "0x1319DE0", VA = "0x18131A9E0")]
		public static void TranslateVertices_World(this pb_Object pb, int[] selectedTriangles, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x131A310", Offset = "0x1319710", VA = "0x18131A310")]
		public static void TranslateVertices_World(this pb_Object pb, int[] selectedTriangles, Vector3 offset, float snapValue, bool snapAxisOnly, Dictionary<int, int> lookup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x131AA30", Offset = "0x1319E30", VA = "0x18131AA30")]
		public static void TranslateVertices(this pb_Object pb, int[] selectedTriangles, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1319FA0", Offset = "0x13193A0", VA = "0x181319FA0")]
		public static void SetSharedVertexPosition(this pb_Object pb, int sharedIndex, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x131A0E0", Offset = "0x13194E0", VA = "0x18131A0E0")]
		public static void SetSharedVertexValues(this pb_Object pb, int sharedIndex, pb_Vertex vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1319E10", Offset = "0x1319210", VA = "0x181319E10")]
		public static bool FaceWithTriangle(this pb_Object pb, int[] tri, out pb_Face face)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1319EF0", Offset = "0x13192F0", VA = "0x181319EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x13209B0", Offset = "0x131FDB0", VA = "0x1813209B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1322480", Offset = "0x1321880", VA = "0x181322480")]
		public static Dictionary<pb_Object, HashSet<int>> PickVerticesInRect(Camera cam, Rect rect, IList<pb_Object> selectable, pb_PickerOptions options, float pixelsPerPoint = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x13212D0", Offset = "0x13206D0", VA = "0x1813212D0")]
		public static Dictionary<pb_Object, HashSet<pb_Face>> PickFacesInRect(Camera cam, Rect rect, IList<pb_Object> selectable, pb_PickerOptions options, float pixelsPerPoint = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1320A10", Offset = "0x131FE10", VA = "0x181320A10")]
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
			[Cpp2IlInjected.Address(RVA = "0x13229A0", Offset = "0x1321DA0", VA = "0x1813229A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x7AEB0", Offset = "0x7A2B0", VA = "0x18007AEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1322930", Offset = "0x1321D30", VA = "0x181322930")]
		public pb_PolyShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xB13150", Offset = "0xB12550", VA = "0x180B13150")]
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
		[Cpp2IlInjected.Address(RVA = "0x1323C00", Offset = "0x1323000", VA = "0x181323C00")]
		public pb_PreferenceDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x13234B0", Offset = "0x13228B0", VA = "0x1813234B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1323090", Offset = "0x1322490", VA = "0x181323090", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1323890", Offset = "0x1322C90", VA = "0x181323890", Slot = "6")]
		public void SetDefaultValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1322F90", Offset = "0x1322390", VA = "0x181322F90")]
		public bool HasKey(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x783290", Offset = "0x782690", VA = "0x180783290")]
		public bool HasKey<T>(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1322AD0", Offset = "0x1321ED0", VA = "0x181322AD0")]
		public void DeleteKey(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x68E9E0", Offset = "0x68DDE0", VA = "0x18068E9E0")]
		public T Get<T>(string key, [Optional] T fallback)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xD67020", Offset = "0xD66420", VA = "0x180D67020")]
		public void Set<T>(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1322C70", Offset = "0x1322070", VA = "0x181322C70")]
		public bool GetBool(string key, bool fallback = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1322E10", Offset = "0x1322210", VA = "0x181322E10")]
		public int GetInt(string key, int fallback = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1322D90", Offset = "0x1322190", VA = "0x181322D90")]
		public float GetFloat(string key, float fallback = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x1322F10", Offset = "0x1322310", VA = "0x181322F10")]
		public string GetString(string key, [Optional] string fallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x1322CF0", Offset = "0x13220F0", VA = "0x181322CF0")]
		public Color GetColor(string key, [Optional] Color fallback)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x1322E90", Offset = "0x1322290", VA = "0x181322E90")]
		public Material GetMaterial(string key, [Optional] Material fallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x1323720", Offset = "0x1322B20", VA = "0x181323720")]
		public void SetBool(string key, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x13239F0", Offset = "0x1322DF0", VA = "0x1813239F0")]
		public void SetInt(string key, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x1323940", Offset = "0x1322D40", VA = "0x181323940")]
		public void SetFloat(string key, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1323B50", Offset = "0x1322F50", VA = "0x181323B50")]
		public void SetString(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x13237D0", Offset = "0x1322BD0", VA = "0x1813237D0")]
		public void SetColor(string key, Color value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1323AA0", Offset = "0x1322EA0", VA = "0x181323AA0")]
		public void SetMaterial(string key, Material value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xB02F10", Offset = "0xB02310", VA = "0x180B02F10")]
		public Dictionary<string, bool> GetBoolDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xB02F30", Offset = "0xB02330", VA = "0x180B02F30")]
		public Dictionary<string, int> GetIntDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xB02F00", Offset = "0xB02300", VA = "0x180B02F00")]
		public Dictionary<string, float> GetFloatDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xB0CD10", Offset = "0xB0C110", VA = "0x180B0CD10")]
		public Dictionary<string, string> GetStringDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xB04530", Offset = "0xB03930", VA = "0x180B04530")]
		public Dictionary<string, Color> GetColorDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xB24070", Offset = "0xB23470", VA = "0x180B24070")]
		public Dictionary<string, Material> GetMaterialDictionary()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1322A30", Offset = "0x1321E30", VA = "0x181322A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x1324E20", Offset = "0x1324220", VA = "0x181324E20")]
		public static Vector2[] PlanarProject(IEnumerable<Vector3> verts, Vector3 planeNormal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1324A60", Offset = "0x1323E60", VA = "0x181324A60")]
		internal static Vector2[] PlanarProject(pb_Object pb, pb_Face face)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1324B70", Offset = "0x1323F70", VA = "0x181324B70")]
		internal static Vector2[] PlanarProject(IList<pb_Vertex> vertices, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1324680", Offset = "0x1323A80", VA = "0x181324680")]
		internal static Vector2[] PlanarProject(Vector3[] verts, Vector3 planeNormal, ProjectionAxis projectionAxis, [Optional] int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x13242C0", Offset = "0x13236C0", VA = "0x1813242C0")]
		internal static void PlanarProject(Vector3[] verts, Vector2[] uvs, int[] indices, Vector3 planeNormal, ProjectionAxis projectionAxis)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x13254B0", Offset = "0x13248B0", VA = "0x1813254B0")]
		internal static Vector2[] SphericalProject(IList<Vector3> vertices, [Optional] IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x13250E0", Offset = "0x13244E0", VA = "0x1813250E0")]
		internal static IList<Vector2> Sort(IList<Vector2> verts, SortMethod method = SortMethod.CounterClockwise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1324EE0", Offset = "0x13242E0", VA = "0x181324EE0")]
		internal static Vector3 ProjectionAxisToVector(ProjectionAxis axis)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1325850", Offset = "0x1324C50", VA = "0x181325850")]
		internal static ProjectionAxis VectorToProjectionAxis(Vector3 plane)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xBEFE40", Offset = "0xBEF240", VA = "0x180BEFE40")]
		internal static Plane FindBestPlane<T>(IList<T> points, Func<T, Vector3> selector, [Optional] IList<int> indices)
		{
			return default(Plane);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1323D10", Offset = "0x1323110", VA = "0x181323D10")]
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
		[Cpp2IlInjected.Address(RVA = "0x1325A40", Offset = "0x1324E40", VA = "0x181325A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x75730", Offset = "0x74B30", VA = "0x180075730")]
		public pb_Renderable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1325B90", Offset = "0x1324F90", VA = "0x181325B90")]
		public static pb_Renderable CreateInstance(Mesh InMesh, Material InMaterial, [Optional] Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1325AB0", Offset = "0x1324EB0", VA = "0x181325AB0")]
		public static pb_Renderable CreateInstance()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1325C00", Offset = "0x1325000", VA = "0x181325C00")]
		public static void DestroyInstance(UnityEngine.Object ren)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x1325C60", Offset = "0x1325060", VA = "0x181325C60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1325D00", Offset = "0x1325100", VA = "0x181325D00")]
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
			[Cpp2IlInjected.Address(RVA = "0x1329E50", Offset = "0x1329250", VA = "0x181329E50")]
			get
			{
				return default(RenderTextureFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private static TextureFormat textureFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x132A070", Offset = "0x1329470", VA = "0x18132A070")]
			get
			{
				return default(TextureFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1328690", Offset = "0x1327A90", VA = "0x181328690")]
		public static Dictionary<pb_Object, HashSet<pb_Face>> PickFacesInRect(Camera camera, Rect pickerRect, IList<pb_Object> selection, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1328CE0", Offset = "0x13280E0", VA = "0x181328CE0")]
		public static Dictionary<pb_Object, HashSet<int>> PickVerticesInRect(Camera camera, Rect pickerRect, IList<pb_Object> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x1328000", Offset = "0x1327400", VA = "0x181328000")]
		public static Dictionary<pb_Object, HashSet<pb_Edge>> PickEdgesInRect(Camera camera, Rect pickerRect, IList<pb_Object> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1329470", Offset = "0x1328870", VA = "0x181329470")]
		private static Texture2D RenderSelectionPickerTexture(Camera camera, IList<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, pb_Face>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x1329620", Offset = "0x1328A20", VA = "0x181329620")]
		private static Texture2D RenderSelectionPickerTexture(Camera camera, IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, int>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x13291E0", Offset = "0x13285E0", VA = "0x1813291E0")]
		private static Texture2D RenderSelectionPickerTexture(Camera camera, IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, pb_Edge>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1327650", Offset = "0x1326A50", VA = "0x181327650")]
		private static GameObject[] GenerateFacePickingObjects(IList<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, pb_Face>> map)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1327B60", Offset = "0x1326F60", VA = "0x181327B60")]
		private static void GenerateVertexPickingObjects(IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, int>> map, out GameObject[] depthObjects, out GameObject[] pickerObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x13271B0", Offset = "0x13265B0", VA = "0x1813271B0")]
		private static void GenerateEdgePickingObjects(IList<pb_Object> selection, bool doDepthTest, out Dictionary<uint, pb_Tuple<pb_Object, pb_Edge>> map, out GameObject[] depthObjects, out GameObject[] pickerObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x13264E0", Offset = "0x13258E0", VA = "0x1813264E0")]
		private static Mesh BuildVertexMesh(pb_Object pb, Dictionary<uint, pb_Tuple<pb_Object, int>> map, ref uint index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1325F60", Offset = "0x1325360", VA = "0x181325F60")]
		private static Mesh BuildEdgeMesh(pb_Object pb, Dictionary<uint, pb_Tuple<pb_Object, pb_Edge>> map, ref uint index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1327080", Offset = "0x1326480", VA = "0x181327080")]
		public static uint DecodeRGBA(Color32 color)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1327110", Offset = "0x1326510", VA = "0x181327110")]
		public static Color32 EncodeRGBA(uint hash)
		{
			return default(Color32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x13298B0", Offset = "0x1328CB0", VA = "0x1813298B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x132BE30", Offset = "0x132B230", VA = "0x18132BE30")]
		public static pb_Object CreateShape(pb_ShapeType shape)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1333170", Offset = "0x1332570", VA = "0x181333170")]
		public static pb_Object StairGenerator(Vector3 size, int steps, bool buildSides)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x132C720", Offset = "0x132BB20", VA = "0x18132C720")]
		public static pb_Object CurvedStairGenerator(float stairWidth, float height, float innerRadius, float circumference, int steps, bool buildSides)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1334530", Offset = "0x1333930", VA = "0x181334530")]
		public static pb_Object StairGenerator(int steps, float width, float height, float depth, bool sidesGoToFloor, bool generateBack, bool platformsOnly)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x132C490", Offset = "0x132B890", VA = "0x18132C490")]
		public static pb_Object CubeGenerator(Vector3 size)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x132E210", Offset = "0x132D610", VA = "0x18132E210")]
		public static pb_Object CylinderGenerator(int axisDivisions, float radius, float height, int heightCuts, int smoothing = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1332410", Offset = "0x1331810", VA = "0x181332410")]
		public static pb_Object PrismGenerator(Vector3 size)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x132F0E0", Offset = "0x132E4E0", VA = "0x18132F0E0")]
		public static pb_Object DoorGenerator(float totalWidth, float totalHeight, float ledgeHeight, float legWidth, float depth)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1332390", Offset = "0x1331790", VA = "0x181332390")]
		[Obsolete]
		public static pb_Object PlaneGenerator(float _width, float _height, int widthCuts, int heightCuts, Axis axis, bool smooth)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1331A10", Offset = "0x1330E10", VA = "0x181331A10")]
		public static pb_Object PlaneGenerator(float _width, float _height, int widthCuts, int heightCuts, Axis axis)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1330DD0", Offset = "0x13301D0", VA = "0x181330DD0")]
		public static pb_Object PipeGenerator(float radius, float height, float thickness, int subdivAxis, int subdivHeight)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x132B7A0", Offset = "0x132ABA0", VA = "0x18132B7A0")]
		public static pb_Object ConeGenerator(float radius, float height, int subdivAxis)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x132A080", Offset = "0x1329480", VA = "0x18132A080")]
		public static pb_Object ArchGenerator(float angle, float radius, float width, float depth, int radialCuts, bool insideFaces, bool outsideFaces, bool frontFaces, bool backFaces, bool endCaps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1330580", Offset = "0x132F980", VA = "0x181330580")]
		public static pb_Object IcosahedronGenerator(float radius, int subdivisions, bool weldVertices = true, bool manualUvs = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x1334E70", Offset = "0x1334270", VA = "0x181334E70")]
		private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x132B070", Offset = "0x132A470", VA = "0x18132B070")]
		private static Vector3[] CircleVertices(int segments, float radius, float circumference, Quaternion rotation, float offset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x13355C0", Offset = "0x13349C0", VA = "0x1813355C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1337450", Offset = "0x1336850", VA = "0x181337450")]
		public pb_Shortcut(string a, string d, KeyCode k, EventModifiers e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x1337260", Offset = "0x1336660", VA = "0x181337260")]
		public pb_Shortcut(string str)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x1336990", Offset = "0x1335D90", VA = "0x181336990")]
		public bool Matches(KeyCode key, EventModifiers modifiers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x13368F0", Offset = "0x1335CF0", VA = "0x1813368F0")]
		public static int IndexOf(pb_Shortcut[] shortcuts, KeyCode k, EventModifiers e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x1336460", Offset = "0x1335860", VA = "0x181336460")]
		public static IEnumerable<pb_Shortcut> DefaultShortcuts()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x13369B0", Offset = "0x1335DB0", VA = "0x1813369B0")]
		public static IEnumerable<pb_Shortcut> ParseShortcuts(string str)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1336FF0", Offset = "0x13363F0", VA = "0x181336FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1336B70", Offset = "0x1335F70", VA = "0x181336B70")]
		public string Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1336F20", Offset = "0x1336320", VA = "0x181336F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1337E90", Offset = "0x1337290", VA = "0x181337E90")]
		public static int GetUnusedSmoothingGroup(pb_Object pb)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x1337E10", Offset = "0x1337210", VA = "0x181337E10")]
		private static int GetNextUnusedSmoothingGroup(int start, HashSet<int> used)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x1337FE0", Offset = "0x13373E0", VA = "0x181337FE0")]
		public static bool IsSmooth(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x13374A0", Offset = "0x13368A0", VA = "0x1813374A0")]
		public static void ApplySmoothingGroups(pb_Object pb, IEnumerable<pb_Face> faces, float angleThreshold, [Optional] Vector3[] normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1337B90", Offset = "0x1336F90", VA = "0x181337B90")]
		private static bool FindSoftEdgesRecursive(Vector3[] normals, pb_WingedEdge wing, float angleThreshold, HashSet<pb_Face> processed)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x1338000", Offset = "0x1337400", VA = "0x181338000")]
		private static bool IsSoftEdge(Vector3[] normals, pb_EdgeLookup left, pb_EdgeLookup right, float threshold)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class pb_Snap
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1338360", Offset = "0x1337760", VA = "0x181338360")]
		public static Vector3 SnapValue(Vector3 vertex, float snpVal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1338460", Offset = "0x1337860", VA = "0x181338460")]
		public static float SnapValue(float val, float snpVal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x13384D0", Offset = "0x13378D0", VA = "0x1813384D0")]
		public static Vector3 SnapValue(Vector3 vertex, Vector3 snap)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class pb_Spline
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x1339A20", Offset = "0x1338E20", VA = "0x181339A20")]
		internal static pb_Object Extrude(IList<pb_BezierPoint> points, float radius = 0.5f, int columns = 32, int rows = 16, bool closeLoop = false, bool smooth = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1339940", Offset = "0x1338D40", VA = "0x181339940")]
		internal static void Extrude(IList<pb_BezierPoint> bezierPoints, float radius, int columns, int rows, bool closeLoop, bool smooth, ref pb_Object target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1339B10", Offset = "0x1338F10", VA = "0x181339B10")]
		internal static List<Vector3> GetControlPoints(IList<pb_BezierPoint> bezierPoints, int subdivisionsPerSegment, bool closeLoop, List<Quaternion> rotations)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x13386E0", Offset = "0x1337AE0", VA = "0x1813386E0")]
		internal static void Extrude(IList<Vector3> points, float radius, int radiusRows, bool closeLoop, bool smooth, ref pb_Object target, [Optional] IList<Quaternion> pointRotations)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1339EA0", Offset = "0x13392A0", VA = "0x181339EA0")]
		private static Quaternion GetRingRotation(IList<Vector3> points, int i, bool closeLoop, out float secant)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x133A410", Offset = "0x1339810", VA = "0x18133A410")]
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
		[Cpp2IlInjected.Address(RVA = "0x133A930", Offset = "0x1339D30", VA = "0x18133A930")]
		public pb_Submesh(Material material, MeshTopology topology, int[] indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x133A980", Offset = "0x1339D80", VA = "0x18133A980")]
		public pb_Submesh(Mesh mesh, int subMeshIndex, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x133A7F0", Offset = "0x1339BF0", VA = "0x18133A7F0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x133AE30", Offset = "0x133A230", VA = "0x18133AE30")]
		public pb_Transform2D(Vector2 position, float rotation, Vector2 scale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x133AD50", Offset = "0x133A150", VA = "0x18133AD50")]
		public Vector2 TransformPoint(Vector2 p)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x133A9F0", Offset = "0x1339DF0", VA = "0x18133A9F0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x133AFE0", Offset = "0x133A3E0", VA = "0x18133AFE0")]
		public static void UnparentChildren(Transform t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x133AE90", Offset = "0x133A290", VA = "0x18133AE90")]
		public static void ReparentChildren(Transform t)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[DisallowMultipleComponent]
	internal class pb_TriggerBehaviour : pb_EntityBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FF0", Offset = "0x2D23F0", VA = "0x1802D2FF0")]
		public pb_TriggerBehaviour()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x133B1B0", Offset = "0x133A5B0", VA = "0x18133B1B0", Slot = "4")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x133B2F0", Offset = "0x133A6F0", VA = "0x18133B2F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x729B60", Offset = "0x728F60", VA = "0x180729B60")]
		public pb_Tuple()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xFCA360", Offset = "0xFC9760", VA = "0x180FCA360")]
		public pb_Tuple(T1 item1, T2 item2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xFCA0E0", Offset = "0xFC94E0", VA = "0x180FCA0E0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x729B60", Offset = "0x728F60", VA = "0x180729B60")]
		public pb_Tuple()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xFCA470", Offset = "0xFC9870", VA = "0x180FCA470")]
		public pb_Tuple(T1 item1, T2 item2, T3 item3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xFCA3B0", Offset = "0xFC97B0", VA = "0x180FCA3B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x729B60", Offset = "0x728F60", VA = "0x180729B60")]
		public pb_Tuple()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xFCA720", Offset = "0xFC9B20", VA = "0x180FCA720")]
		public pb_Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xFCA4D0", Offset = "0xFC98D0", VA = "0x180FCA4D0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x133CE80", Offset = "0x133C280", VA = "0x18133CE80")]
		public pb_UnwrapParameters()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x133CE60", Offset = "0x133C260", VA = "0x18133CE60")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DFC10", Offset = "0x6DF010", VA = "0x1806DFC10")]
			public SearchRange(int begin, int end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x1315160", Offset = "0x1314560", VA = "0x181315160")]
			public bool Valid()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x1314E30", Offset = "0x1314230", VA = "0x181314E30")]
			public int Center()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x1315140", Offset = "0x1314540", VA = "0x181315140", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xBF0B20", Offset = "0xBEFF20", VA = "0x180BF0B20")]
		public static T[] GetComponents<T>(this IEnumerable<GameObject> gameObjects) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xBF0AE0", Offset = "0xBEFEE0", VA = "0x180BF0AE0")]
		public static T[] GetComponents<T>(GameObject go) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xBF08E0", Offset = "0xBEFCE0", VA = "0x180BF08E0")]
		public static T[] GetComponents<T>(this IEnumerable<Transform> transforms) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x133D570", Offset = "0x133C970", VA = "0x18133D570")]
		public static Vector3[] ToWorldSpace(this Transform t, Vector3[] v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x133D040", Offset = "0x133C440", VA = "0x18133D040")]
		public static GameObject EmptyGameObjectWithTransform(Transform t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xBF1270", Offset = "0xBF0670", VA = "0x180BF1270")]
		public static T[] ValuesWithIndices<T>(this T[] arr, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x64D800", Offset = "0x64CC00", VA = "0x18064D800")]
		public static List<T> ValuesWithIndices<T>(this List<T> arr, IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x68EEE0", Offset = "0x68E2E0", VA = "0x18068EEE0")]
		public static T NextEnumValue<T>(this T current) where T : IConvertible
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x783790", Offset = "0x782B90", VA = "0x180783790")]
		public static bool IsEqual<T>(T[] a, T[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xBF0410", Offset = "0xBEF810", VA = "0x180BF0410")]
		public static T[] Add<T>(this T[] arr, T val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xBF02A0", Offset = "0xBEF6A0", VA = "0x180BF02A0")]
		public static T[] AddRange<T>(this T[] arr, T[] val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xBF1040", Offset = "0xBF0440", VA = "0x180BF1040")]
		public static T[] Remove<T>(this T[] arr, T val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xBF1010", Offset = "0xBF0410", VA = "0x180BF1010")]
		public static T[] Remove<T>(this T[] arr, IEnumerable<T> val)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xBF0EB0", Offset = "0xBF02B0", VA = "0x180BF0EB0")]
		public static T[] RemoveAt<T>(this T[] arr, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xBF0E10", Offset = "0xBF0210", VA = "0x180BF0E10")]
		public static T[] RemoveAt<T>(this IList<T> list, IEnumerable<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xBF10E0", Offset = "0xBF04E0", VA = "0x180BF10E0")]
		public static T[] SortedRemoveAt<T>(this IList<T> list, IList<int> sorted_indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8112E0", Offset = "0x8106E0", VA = "0x1808112E0")]
		public static int NearestIndexPriorToValue<T>(IList<T> sorted_list, T value) where T : IComparable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xBF07A0", Offset = "0xBEFBA0", VA = "0x180BF07A0")]
		public static T[] Fill<T>(T val, int length)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x64D740", Offset = "0x64CB40", VA = "0x18064D740")]
		public static List<T> Fill<T>(Func<int, T> ctor, int length)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xBF0850", Offset = "0xBEFC50", VA = "0x180BF0850")]
		public static T[] FilledArray<T>(T val, int length)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x783700", Offset = "0x782B00", VA = "0x180783700")]
		public static bool ContainsMatch<T>(this T[] a, T[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x783650", Offset = "0x782A50", VA = "0x180783650")]
		public static bool ContainsMatch<T>(this T[] a, T[] b, out int index_a, out int index_b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xBF04C0", Offset = "0xBEF8C0", VA = "0x180BF04C0")]
		public static T[] Concat<T>(this T[] x, T[] y)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x811000", Offset = "0x810400", VA = "0x180811000")]
		public static int IndexOf<T>(this List<List<T>> InList, T InValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xBF06E0", Offset = "0xBEFAE0", VA = "0x180BF06E0")]
		public static T[] Fill<T>(int count, Func<int, T> ctor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xD673F0", Offset = "0xD667F0", VA = "0x180D673F0")]
		public static void AddOrAppend<T, K>(this Dictionary<T, List<K>> dictionary, T key, K value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xD67350", Offset = "0xD66750", VA = "0x180D67350")]
		public static void AddOrAppendRange<T, K>(this Dictionary<T, List<K>> dictionary, T key, List<K> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x4A2C00", Offset = "0x4A2000", VA = "0x1804A2C00")]
		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xF4EC50", Offset = "0xF4E050", VA = "0x180F4EC50")]
		[Obsolete]
		public static string ToFormattedString<T>(this T[] t, string _delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xF4EA00", Offset = "0xF4DE00", VA = "0x180F4EA00")]
		[Obsolete]
		public static string ToFormattedString<T>(this T[] t, string _delimiter, int entriesPerLine, int maxEntries)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xF4E9B0", Offset = "0xF4DDB0", VA = "0x180F4E9B0")]
		[Obsolete]
		public static string ToFormattedString<T>(this List<T> t, string _delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xF4E970", Offset = "0xF4DD70", VA = "0x180F4E970")]
		[Obsolete]
		public static string ToFormattedString<T>(this HashSet<T> t, string _delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xF4ED50", Offset = "0xF4E150", VA = "0x180F4ED50")]
		public static string ToString<TKey, TValue>(this Dictionary<TKey, TValue> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xF4F020", Offset = "0xF4E420", VA = "0x180F4F020")]
		public static string ToString<T>(this IEnumerable<T> arr, string separator = ", ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x133CEF0", Offset = "0x133C2F0", VA = "0x18133CEF0")]
		public static string ControlKeyString(char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x133CEB0", Offset = "0x133C2B0", VA = "0x18133CEB0")]
		[Obsolete]
		public static bool ColorWithString(string value, out Color col)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x133D6A0", Offset = "0x133CAA0", VA = "0x18133D6A0")]
		public static bool TryParseColor(string value, ref Color col)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x133D180", Offset = "0x133C580", VA = "0x18133D180")]
		public static Vector3[] StringToVector3Array(string str)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x133CF90", Offset = "0x133C390", VA = "0x18133CF90")]
		public static Vector2 DivideBy(this Vector2 v, Vector2 o)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x133CFE0", Offset = "0x133C3E0", VA = "0x18133CFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x133CD30", Offset = "0x133C130", VA = "0x18133CD30")]
		public pb_UV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x133CDD0", Offset = "0x133C1D0", VA = "0x18133CDD0")]
		public pb_UV(pb_UV uvs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x133C390", Offset = "0x133B790", VA = "0x18133C390")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x133C430", Offset = "0x133B830", VA = "0x18133C430", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x133C050", Offset = "0x133B450", VA = "0x18133C050")]
		public static void PlanarMap2(Vector3[] verts, Vector2[] uvs, int[] indices, pb_UV uvSettings, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x133B700", Offset = "0x133AB00", VA = "0x18133B700")]
		private static void ApplyUVSettings(Vector2[] uvs, int[] indices, pb_UV uvSettings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x133C160", Offset = "0x133B560", VA = "0x18133C160")]
		private static Vector2[] StretchUVs(Vector2[] uvs, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x133BE60", Offset = "0x133B260", VA = "0x18133BE60")]
		private static Vector2[] NormalizeUVs(Vector2[] uvs, int[] indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x133BC40", Offset = "0x133B040", VA = "0x18133BC40")]
		[Obsolete]
		private static Vector2[] JustifyUVs(Vector2[] uvs, pb_UV.Justify j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x133B380", Offset = "0x133A780", VA = "0x18133B380")]
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
		[Cpp2IlInjected.Address(RVA = "0x133DC40", Offset = "0x133D040", VA = "0x18133DC40")]
		private static int HashFloat(float f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x133DB80", Offset = "0x133CF80", VA = "0x18133DB80")]
		public static int GetHashCode(Vector2 v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x133DA70", Offset = "0x133CE70", VA = "0x18133DA70")]
		public static int GetHashCode(Vector3 v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x133D910", Offset = "0x133CD10", VA = "0x18133D910")]
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
			[Cpp2IlInjected.Address(RVA = "0xB056C0", Offset = "0xB04AC0", VA = "0x180B056C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int minor
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x133F070", Offset = "0x133E470", VA = "0x18133F070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int patch
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xB03570", Offset = "0xB02970", VA = "0x180B03570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int build
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xB090B0", Offset = "0xB084B0", VA = "0x180B090B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public VersionType type
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xB23950", Offset = "0xB22D50", VA = "0x180B23950")]
			get
			{
				return default(VersionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string metadata
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xB02F00", Offset = "0xB02300", VA = "0x180B02F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string date
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xB0CD10", Offset = "0xB0C110", VA = "0x180B0CD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public pb_VersionInfo MajorMinorPatch
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x133EF50", Offset = "0x133E350", VA = "0x18133EF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x133ED80", Offset = "0x133E180", VA = "0x18133ED80")]
		public pb_VersionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x133EEA0", Offset = "0x133E2A0", VA = "0x18133EEA0")]
		public pb_VersionInfo(string formatted, [Optional] string date)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x133EDA0", Offset = "0x133E1A0", VA = "0x18133EDA0")]
		public pb_VersionInfo(int major, int minor, int patch, int build = -1, VersionType type = VersionType.Missing, string date = "", string metadata = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x133E430", Offset = "0x133D830", VA = "0x18133E430")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x133DF80", Offset = "0x133D380", VA = "0x18133DF80", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x133E110", Offset = "0x133D510", VA = "0x18133E110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x133DE70", Offset = "0x133D270", VA = "0x18133DE70", Slot = "4")]
		public bool Equals(pb_VersionInfo version)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x133DCA0", Offset = "0x133D0A0", VA = "0x18133DCA0", Slot = "6")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x133ED70", Offset = "0x133E170", VA = "0x18133ED70")]
		private static int WrapNoValue(int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x133DD30", Offset = "0x133D130", VA = "0x18133DD30", Slot = "5")]
		public int CompareTo(pb_VersionInfo version)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x133F080", Offset = "0x133E480", VA = "0x18133F080")]
		public static bool operator ==(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x133F0D0", Offset = "0x133E4D0", VA = "0x18133F0D0")]
		public static bool operator !=(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x133F110", Offset = "0x133E510", VA = "0x18133F110")]
		public static bool operator <(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x133F0A0", Offset = "0x133E4A0", VA = "0x18133F0A0")]
		public static bool operator >(pb_VersionInfo left, pb_VersionInfo right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x133E450", Offset = "0x133D850", VA = "0x18133E450")]
		public string ToString(string format)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x133E760", Offset = "0x133DB60", VA = "0x18133E760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x133E7A0", Offset = "0x133DBA0", VA = "0x18133E7A0")]
		public static bool TryGetVersionInfo(string input, out pb_VersionInfo version)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x133E270", Offset = "0x133D670", VA = "0x18133E270")]
		private static VersionType GetVersionType(string input)
		{
			return default(VersionType);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x133E060", Offset = "0x133D460", VA = "0x18133E060")]
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
		[Cpp2IlInjected.Address(RVA = "0x201CAE0", Offset = "0x201BEE0", VA = "0x18201CAE0")]
		public pb_Vertex(bool hasAllValues = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x201CB30", Offset = "0x201BF30", VA = "0x18201CB30")]
		public pb_Vertex(pb_Vertex v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x2019FC0", Offset = "0x20193C0", VA = "0x182019FC0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x201A270", Offset = "0x2019670", VA = "0x18201A270", Slot = "4")]
		public bool Equals(pb_Vertex other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x201AAD0", Offset = "0x2019ED0", VA = "0x18201AAD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x201CC10", Offset = "0x201C010", VA = "0x18201CC10")]
		public static pb_Vertex operator +(pb_Vertex a, pb_Vertex b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x2019260", Offset = "0x2018660", VA = "0x182019260")]
		public void Add(pb_Vertex b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x201CD90", Offset = "0x201C190", VA = "0x18201CD90")]
		public static pb_Vertex operator -(pb_Vertex a, pb_Vertex b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x201C810", Offset = "0x201BC10", VA = "0x18201C810")]
		public void Subtract(pb_Vertex b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x201CD10", Offset = "0x201C110", VA = "0x18201CD10")]
		public static pb_Vertex operator *(pb_Vertex a, float value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x201C340", Offset = "0x201B740", VA = "0x18201C340")]
		public void Multiply(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x201CC90", Offset = "0x201C090", VA = "0x18201CC90")]
		public static pb_Vertex operator /(pb_Vertex a, float value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x2019D90", Offset = "0x2019190", VA = "0x182019D90")]
		public void Divide(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x201C570", Offset = "0x201B970", VA = "0x18201C570")]
		public void Normalize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x201CAD0", Offset = "0x201BED0", VA = "0x18201CAD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x201AB60", Offset = "0x2019F60", VA = "0x18201AB60")]
		public static pb_Vertex[] GetVertices(pb_Object pb, [Optional] IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x201B440", Offset = "0x201A840", VA = "0x18201B440")]
		public static pb_Vertex[] GetVertices(Mesh m)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x201A4A0", Offset = "0x20198A0", VA = "0x18201A4A0")]
		public static void GetArrays(IList<pb_Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x201A510", Offset = "0x2019910", VA = "0x18201A510")]
		public static void GetArrays(IList<pb_Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4, AttributeType attributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x201C640", Offset = "0x201BA40", VA = "0x18201C640")]
		public static void SetMesh(Mesh m, IList<pb_Vertex> vertices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2019520", Offset = "0x2018920", VA = "0x182019520")]
		public static pb_Vertex Average(IList<pb_Vertex> vertices, [Optional] IList<int> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x201BCD0", Offset = "0x201B0D0", VA = "0x18201BCD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2019210", Offset = "0x2018610", VA = "0x182019210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x10E720", Offset = "0x10DB20", VA = "0x18010E720")]
		public pb_VertexConnection(pb_Face face, List<int> indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2018FE0", Offset = "0x20183E0", VA = "0x182018FE0")]
		public pb_VertexConnection Distinct(pb_IntArray[] sharedIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2019070", Offset = "0x2018470", VA = "0x182019070", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1644CB0", Offset = "0x16440B0", VA = "0x181644CB0", Slot = "4")]
		public bool Equals(pb_VertexConnection vc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x456A70", Offset = "0x455E70", VA = "0x180456A70")]
		public static implicit operator pb_Face(pb_VertexConnection vc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1644DF0", Offset = "0x16441F0", VA = "0x181644DF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2019180", Offset = "0x2018580", VA = "0x182019180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2018F10", Offset = "0x2018310", VA = "0x182018F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x87240", Offset = "0x86640", VA = "0x180087240")]
		public pb_WingedEdge()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x201CF40", Offset = "0x201C340", VA = "0x18201CF40", Slot = "4")]
		public bool Equals(pb_WingedEdge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x201CF80", Offset = "0x201C380", VA = "0x18201CF80", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x201D190", Offset = "0x201C590", VA = "0x18201D190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x201D120", Offset = "0x201C520", VA = "0x18201D120", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x201D120", Offset = "0x201C520", VA = "0x18201D120")]
		public pb_WingedEdgeEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x201CF00", Offset = "0x201C300", VA = "0x18201CF00")]
		public int Count()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x201E820", Offset = "0x201DC20", VA = "0x18201E820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x201DAE0", Offset = "0x201CEE0", VA = "0x18201DAE0")]
		public static int[] MakeQuad(pb_WingedEdge left, pb_WingedEdge right)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x201D090", Offset = "0x201C490", VA = "0x18201D090")]
		public pb_WingedEdge GetAdjacentEdgeWithCommonIndex(int common)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x201E640", Offset = "0x201DA40", VA = "0x18201E640")]
		public static List<pb_Edge> SortEdgesByAdjacency(pb_Face face)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x201E6C0", Offset = "0x201DAC0", VA = "0x18201E6C0")]
		public static List<pb_Edge> SortEdgesByAdjacency(List<pb_Edge> edges)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x201D1C0", Offset = "0x201C5C0", VA = "0x18201D1C0")]
		public static Dictionary<int, List<pb_WingedEdge>> GetSpokes(List<pb_WingedEdge> wings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x201E420", Offset = "0x201D820", VA = "0x18201E420")]
		public static List<int> SortCommonIndicesByAdjacency(List<pb_WingedEdge> wings, HashSet<int> common)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x201D460", Offset = "0x201C860", VA = "0x18201D460")]
		public static List<pb_WingedEdge> GetWingedEdges(pb_Object pb, bool oneWingPerFace = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x201D4B0", Offset = "0x201C8B0", VA = "0x18201D4B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x201CE40", Offset = "0x201C240", VA = "0x18201CE40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public pb_WingedEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x201CE90", Offset = "0x201C290", VA = "0x18201CE90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x201CE50", Offset = "0x201C250", VA = "0x18201CE50")]
		public pb_WingedEdgeEnumerator(pb_WingedEdge start)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x201CE10", Offset = "0x201C210", VA = "0x18201CE10", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x1281300", Offset = "0x1280700", VA = "0x181281300", Slot = "6")]
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
