using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.FastMesh.Core;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CDECHOJNFIA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B150", Offset = "0x6D3A550", VA = "0x186D3B150")]
	public static float2 ODOBAONCHOK(this HPLDKOAJNOI JLGGAEGNCNA)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HPLDKOAJNOI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	BottomLeft,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	BottomCenter,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	BottomRight,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	CenterLeft,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Center,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	CenterRight,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TopLeft,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	TopCenter,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	TopRight
}
namespace RecRoom.FastMesh.Core
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct float2Rect : IEquatable<float2Rect>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const int BYTE_SIZE = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public float x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float width;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public float height;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public float2 position;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float2 size;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28543A0", Offset = "0x28537A0", VA = "0x1828543A0")]
		public float2Rect(float2 OGKCMCMHLOD, float2 JKIIGJDNBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6D3DC00", Offset = "0x6D3D000", VA = "0x186D3DC00")]
		public void NKENCEMDNGD([Out] float2 DKPHDKMHKMG, [Out] float2 KNOPDPAALEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D3DBD0", Offset = "0x6D3CFD0", VA = "0x186D3DBD0")]
		public float2 MCONKDIOAGF(float2 FKHAJBHHLKI)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D9A0", Offset = "0x6D3CDA0", VA = "0x186D3D9A0", Slot = "4")]
		public bool Equals(float2Rect OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D3DA20", Offset = "0x6D3CE20", VA = "0x186D3DA20", Slot = "0")]
		public override bool Equals(object FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D3DB20", Offset = "0x6D3CF20", VA = "0x186D3DB20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D3DC20", Offset = "0x6D3D020", VA = "0x186D3DC20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D3DE40", Offset = "0x6D3D240", VA = "0x186D3DE40", Slot = "5")]
		public string ToString(string BEMIADMLHDO, IFormatProvider EDJDDHHBILE)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct floatMinMax : IEquatable<floatMinMax>, IEquatable<float2>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const int BYTE_SIZE = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float max;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float2 value;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E280", Offset = "0x6D3D680", VA = "0x186D3E280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E1F0", Offset = "0x6D3D5F0", VA = "0x186D3E1F0", Slot = "6")]
		public string ToString(string BEMIADMLHDO, IFormatProvider EDJDDHHBILE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E050", Offset = "0x6D3D450", VA = "0x186D3E050", Slot = "4")]
		public bool Equals(floatMinMax OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E140", Offset = "0x6D3D540", VA = "0x186D3E140", Slot = "5")]
		public bool Equals(float2 OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E090", Offset = "0x6D3D490", VA = "0x186D3E090", Slot = "0")]
		public override bool Equals(object FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E170", Offset = "0x6D3D570", VA = "0x186D3E170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct QuadVertex
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Constants
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly VertexAttributeDescriptor[] layout;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Color32 color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float2 uv;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class LayoutRect
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private float2Rect localRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private float2 parentAlignmentNormalized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private LayoutRect parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<LayoutRect> children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private BKDKFPCJBEJ cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D5A0", Offset = "0x6D3C9A0", VA = "0x186D3D5A0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D6F0", Offset = "0x6D3CAF0", VA = "0x186D3D6F0")]
		public LayoutRect(LayoutRect parent, HPLDKOAJNOI parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D0B0", Offset = "0x6D3C4B0", VA = "0x186D3D0B0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D010", Offset = "0x6D3C410", VA = "0x186D3D010")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D080", Offset = "0x6D3C480", VA = "0x186D3D080")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D020", Offset = "0x6D3C420", VA = "0x186D3D020")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D1C0", Offset = "0x6D3C5C0", VA = "0x186D3D1C0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D3B250", Offset = "0x6D3A650", VA = "0x186D3B250")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D270", Offset = "0x6D3C670", VA = "0x186D3D270")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D230", Offset = "0x6D3C630", VA = "0x186D3D230")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D1F0", Offset = "0x6D3C5F0", VA = "0x186D3D1F0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D320", Offset = "0x6D3C720", VA = "0x186D3D320")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D280", Offset = "0x6D3C680", VA = "0x186D3D280")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D2C0", Offset = "0x6D3C6C0", VA = "0x186D3D2C0")]
		public void SetParentAlignment(HPLDKOAJNOI rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D0D0", Offset = "0x6D3C4D0", VA = "0x186D3D0D0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D130", Offset = "0x6D3C530", VA = "0x186D3D130")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D0C0", Offset = "0x6D3C4C0", VA = "0x186D3D0C0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D3D0", Offset = "0x6D3C7D0", VA = "0x186D3D3D0")]
		private BKDKFPCJBEJ UpdateCache()
		{
			return default(BKDKFPCJBEJ);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BKDKFPCJBEJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JJHLLMMOLKD
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] PLFNBEBICMN;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CC80", Offset = "0x6D3C080", VA = "0x186D3CC80")]
	public static float2Rect PEOHGJJFPNH(Transform LEOGDIDBFKJ, RectTransform KLACLBHAHNL)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CBC0", Offset = "0x6D3BFC0", VA = "0x186D3CBC0")]
	public static void BOFKEFOEGMA(Vector3[] OBPDAIMGHEA, [Out] float2 AOFEGKJKMDG, [Out] float2 FBENJJMLPKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NBAKJHIIFLL
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] JKFFNHAKCNH;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D850", Offset = "0x6D3CC50", VA = "0x186D3D850")]
	public static void OPKLLBPAILF([In] int JJNKEHAKEMJ, [Out] ushort IMMEGFGFOIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IOEFCGFDKNC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GCBDLDIEJLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float minX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public float minY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public float minZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public float maxX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public float maxY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public float maxZ;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C390", Offset = "0x6D3B790", VA = "0x186D3C390")]
	public static void LCCNCDILAJI(float3[] DDJJHPJFGLM, [In] float2 POEENJINJEM, [In] float2 KNOPDPAALEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C880", Offset = "0x6D3BC80", VA = "0x186D3C880")]
	public static void OEFHJCNOLLH(float2[] BIEIECGHIEK, [In] float2 JPAAFJOIHOG, [In] float2 HNDDMLHDINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B780", Offset = "0x6D3AB80", VA = "0x186D3B780")]
	public static void DIFDMEKMJHN(float3[] DDJJHPJFGLM, [In] float EJOPAIKLEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BDA0", Offset = "0x6D3B1A0", VA = "0x186D3BDA0")]
	public static void IHNENMDLIEH(QuadVertex[] FGLMDOBFNPP, [In] int IMMEGFGFOIO, [In] float3[] PPFDDJEBKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C280", Offset = "0x6D3B680", VA = "0x186D3C280")]
	public static void KFKBNFPMHBK(QuadVertex[] FGLMDOBFNPP, int IMMEGFGFOIO, [In] float3[] PPFDDJEBKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BA90", Offset = "0x6D3AE90", VA = "0x186D3BA90")]
	public static void GCJNAKFPAGH(QuadVertex[] FGLMDOBFNPP, [In] int IMMEGFGFOIO, [In] Color32 PAPPDJGCJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B700", Offset = "0x6D3AB00", VA = "0x186D3B700")]
	public static void AJIOCHDIMFI(QuadVertex[] FGLMDOBFNPP, int IMMEGFGFOIO, [In] Color32 PAPPDJGCJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BB10", Offset = "0x6D3AF10", VA = "0x186D3BB10")]
	public static void GLHBNAGEKGE(QuadVertex[] FGLMDOBFNPP, [In] int IMMEGFGFOIO, [In] float2[] BNGEIHPJMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C410", Offset = "0x6D3B810", VA = "0x186D3C410")]
	public static void LDIFMOMLLGC(QuadVertex[] FGLMDOBFNPP, int IMMEGFGFOIO, [In] float2[] BNGEIHPJMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BC20", Offset = "0x6D3B020", VA = "0x186D3BC20")]
	public static void IBDFPPIOEPO(QuadVertex[] FGLMDOBFNPP, int IMMEGFGFOIO, [In] float3[] PPFDDJEBKDH, [In] Color32 PAPPDJGCJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B870", Offset = "0x6D3AC70", VA = "0x186D3B870")]
	public static void FCBCGABOEIB(QuadVertex[] FGLMDOBFNPP, int IMMEGFGFOIO, [In] float3[] PPFDDJEBKDH, [In] float2[] BNGEIHPJMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CA40", Offset = "0x6D3BE40", VA = "0x186D3CA40")]
	public static void POECMJMIBNA(QuadVertex[] FGLMDOBFNPP, int IMMEGFGFOIO, [In] Color32 PAPPDJGCJMK, [In] float2[] BNGEIHPJMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C5F0", Offset = "0x6D3B9F0", VA = "0x186D3C5F0")]
	public static void MEEGMGBBFIK(QuadVertex[] FGLMDOBFNPP, int IMMEGFGFOIO, [In] float3[] PPFDDJEBKDH, [In] Color32 PAPPDJGCJMK, [In] float2[] BNGEIHPJMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C910", Offset = "0x6D3BD10", VA = "0x186D3C910")]
	public static void PNPKGJGAJGI(ushort[] EPCKJPFGIAH, int JJNKEHAKEMJ, [In] int FDBGMMEAAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C5B0", Offset = "0x6D3B9B0", VA = "0x186D3C5B0")]
	public static void MCPHIEHMEMN(ushort[] EPCKJPFGIAH, int JJNKEHAKEMJ, [In] int FDBGMMEAAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C520", Offset = "0x6D3B920", VA = "0x186D3C520")]
	public static void LNDNGDBCPDP(ushort[] EPCKJPFGIAH, [In] int JJNKEHAKEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BEB0", Offset = "0x6D3B2B0", VA = "0x186D3BEB0")]
	public static void JFGDEJCDGBA(ushort[] EPCKJPFGIAH, [In] int JJNKEHAKEMJ, [In] int IMMEGFGFOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B4C0", Offset = "0x6D3A8C0", VA = "0x186D3B4C0")]
	public static Bounds ACPDJHGKHME([In] QuadVertex[] FGLMDOBFNPP, [In] ushort[] EPCKJPFGIAH, [In] int OCIHCELABKD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BF70", Offset = "0x6D3B370", VA = "0x186D3BF70")]
	public static Bounds KFHIDPIPGPL([In] QuadVertex[] FGLMDOBFNPP, [In] ushort[] EPCKJPFGIAH, [In] int OCIHCELABKD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B7F0", Offset = "0x6D3ABF0", VA = "0x186D3B7F0")]
	[CompilerGenerated]
	internal static void ELJAIKCCPPK([In] float3 NKKDINBLGEI, GCBDLDIEJLH P_1)
	{
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
