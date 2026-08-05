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
public static class CMOHDCPGEKL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x75E3420", Offset = "0x75E2620", VA = "0x1875E3420")]
	public static float2 BDGEGMLFBPD(this MDDDOMOFJMH NNOFLLAKNLA)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MDDDOMOFJMH : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2C106A0", Offset = "0x2C0F8A0", VA = "0x182C106A0")]
		public float2Rect(float2 LBPAIJGCICL, float2 IAGJHPFNLHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75E60E0", Offset = "0x75E52E0", VA = "0x1875E60E0")]
		public void LMCCANMANFL([Out] float2 KMGIAAOLJOH, [Out] float2 MJDJFILEKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75E5E80", Offset = "0x75E5080", VA = "0x1875E5E80")]
		public float2 EODNEENLCOM(float2 BMOFAFHOJHC)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x75E5EB0", Offset = "0x75E50B0", VA = "0x1875E5EB0", Slot = "4")]
		public bool Equals(float2Rect LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75E5F30", Offset = "0x75E5130", VA = "0x1875E5F30", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75E6030", Offset = "0x75E5230", VA = "0x1875E6030", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75E6100", Offset = "0x75E5300", VA = "0x1875E6100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75E6320", Offset = "0x75E5520", VA = "0x1875E6320", Slot = "5")]
		public string ToString(string FLMAPKGOONP, IFormatProvider DKKCLFCLIHE)
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
		[Cpp2IlInjected.Address(RVA = "0x75E6770", Offset = "0x75E5970", VA = "0x1875E6770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x75E66E0", Offset = "0x75E58E0", VA = "0x1875E66E0", Slot = "6")]
		public string ToString(string FLMAPKGOONP, IFormatProvider DKKCLFCLIHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75E6540", Offset = "0x75E5740", VA = "0x1875E6540", Slot = "4")]
		public bool Equals(floatMinMax LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x75E6630", Offset = "0x75E5830", VA = "0x1875E6630", Slot = "5")]
		public bool Equals(float2 LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75E6580", Offset = "0x75E5780", VA = "0x1875E6580", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x75E6660", Offset = "0x75E5860", VA = "0x1875E6660", Slot = "2")]
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
		private PKIHLNDMIIJ cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x75E57A0", Offset = "0x75E49A0", VA = "0x1875E57A0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75E58F0", Offset = "0x75E4AF0", VA = "0x1875E58F0")]
		public LayoutRect(LayoutRect parent, MDDDOMOFJMH parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x75E5260", Offset = "0x75E4460", VA = "0x1875E5260")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x75E51C0", Offset = "0x75E43C0", VA = "0x1875E51C0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x75E5230", Offset = "0x75E4430", VA = "0x1875E5230")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x75E51D0", Offset = "0x75E43D0", VA = "0x1875E51D0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75E5370", Offset = "0x75E4570", VA = "0x1875E5370")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75E3520", Offset = "0x75E2720", VA = "0x1875E3520")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75E5470", Offset = "0x75E4670", VA = "0x1875E5470")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x75E5420", Offset = "0x75E4620", VA = "0x1875E5420")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x75E53D0", Offset = "0x75E45D0", VA = "0x1875E53D0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x75E5520", Offset = "0x75E4720", VA = "0x1875E5520")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x75E54D0", Offset = "0x75E46D0", VA = "0x1875E54D0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x75E5480", Offset = "0x75E4680", VA = "0x1875E5480")]
		public void SetParentAlignment(MDDDOMOFJMH rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x75E5280", Offset = "0x75E4480", VA = "0x1875E5280")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x75E52E0", Offset = "0x75E44E0", VA = "0x1875E52E0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x75E5270", Offset = "0x75E4470", VA = "0x1875E5270")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x75E55D0", Offset = "0x75E47D0", VA = "0x1875E55D0")]
		private PKIHLNDMIIJ UpdateCache()
		{
			return default(PKIHLNDMIIJ);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PKIHLNDMIIJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OJMOCOJKJCG
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] AJNIGENOKHA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B00", Offset = "0x75E4D00", VA = "0x1875E5B00")]
	public static float2Rect JEGPPMNPOKE(Transform CGCHMHPGONB, RectTransform CGKPJBPKLPJ)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x75E5A40", Offset = "0x75E4C40", VA = "0x1875E5A40")]
	public static void HMFFLBBKPAN(Vector3[] LIIICNLNLNC, [Out] float2 CDNAEODPMGJ, [Out] float2 PLIBGNKHNME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class IOMIEDDPDAL
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] HCIPBBOCMDF;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75E5080", Offset = "0x75E4280", VA = "0x1875E5080")]
	public static void NLANJMDJEGA([In] int PNIAMFBCHDA, [Out] ushort PCELCFJIMAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AOLMPPKOGIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DPKLDPFDJPF
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
	[Cpp2IlInjected.Address(RVA = "0x75E43C0", Offset = "0x75E35C0", VA = "0x1875E43C0")]
	public static void GPAEFHJKAFC(float3[] IMJIFLBFDEE, [In] float2 PNPJCNFMKMK, [In] float2 MJDJFILEKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x75E4DF0", Offset = "0x75E3FF0", VA = "0x1875E4DF0")]
	public static void NCLLDENFIIL(float2[] GMEKPPCDHFI, [In] float2 BPEAEOOBAEL, [In] float2 JKLEHNCEBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75E39F0", Offset = "0x75E2BF0", VA = "0x1875E39F0")]
	public static void CKIPBAHEJOE(float3[] IMJIFLBFDEE, [In] float CEPOBOMJHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75E4500", Offset = "0x75E3700", VA = "0x1875E4500")]
	public static void IMOKABAMEHJ(QuadVertex[] IILHGIIHMBA, [In] int PCELCFJIMAP, [In] float3[] DHOIMEHOBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x75E4CE0", Offset = "0x75E3EE0", VA = "0x1875E4CE0")]
	public static void MEOLIJMNOMA(QuadVertex[] IILHGIIHMBA, int PCELCFJIMAP, [In] float3[] DHOIMEHOBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x75E48A0", Offset = "0x75E3AA0", VA = "0x1875E48A0")]
	public static void JNHDLIMNEOP(QuadVertex[] IILHGIIHMBA, [In] int PCELCFJIMAP, [In] Color32 MKENALJCLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75E4480", Offset = "0x75E3680", VA = "0x1875E4480")]
	public static void HKNGPKOIPCD(QuadVertex[] IILHGIIHMBA, int PCELCFJIMAP, [In] Color32 MKENALJCLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x75E42B0", Offset = "0x75E34B0", VA = "0x1875E42B0")]
	public static void GMEAPCKBIKB(QuadVertex[] IILHGIIHMBA, [In] int PCELCFJIMAP, [In] float2[] JNLIDKHHCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x75E4020", Offset = "0x75E3220", VA = "0x1875E4020")]
	public static void GDAKBFFJEOO(QuadVertex[] IILHGIIHMBA, int PCELCFJIMAP, [In] float2[] JNLIDKHHCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x75E4130", Offset = "0x75E3330", VA = "0x1875E4130")]
	public static void GDDFOIBFPNF(QuadVertex[] IILHGIIHMBA, int PCELCFJIMAP, [In] float3[] DHOIMEHOBIN, [In] Color32 MKENALJCLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x75E3D70", Offset = "0x75E2F70", VA = "0x1875E3D70")]
	public static void DLFHANMMMHJ(QuadVertex[] IILHGIIHMBA, int PCELCFJIMAP, [In] float3[] DHOIMEHOBIN, [In] float2[] JNLIDKHHCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x75E4B60", Offset = "0x75E3D60", VA = "0x1875E4B60")]
	public static void LJJLKPJLKCK(QuadVertex[] IILHGIIHMBA, int PCELCFJIMAP, [In] Color32 MKENALJCLED, [In] float2[] JNLIDKHHCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x75E4610", Offset = "0x75E3810", VA = "0x1875E4610")]
	public static void JIDOCJHMEHP(QuadVertex[] IILHGIIHMBA, int PCELCFJIMAP, [In] float3[] DHOIMEHOBIN, [In] Color32 MKENALJCLED, [In] float2[] JNLIDKHHCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x75E3840", Offset = "0x75E2A40", VA = "0x1875E3840")]
	public static void ACAFLIOBCEK(ushort[] DDEEHEFMBFD, int PNIAMFBCHDA, [In] int BOAMAIEFKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x75E4440", Offset = "0x75E3640", VA = "0x1875E4440")]
	public static void HCKBCMHHPAN(ushort[] DDEEHEFMBFD, int PNIAMFBCHDA, [In] int BOAMAIEFKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x75E3F90", Offset = "0x75E3190", VA = "0x1875E3F90")]
	public static void FOMBPCHJKKM(ushort[] DDEEHEFMBFD, [In] int PNIAMFBCHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x75E4E80", Offset = "0x75E4080", VA = "0x1875E4E80")]
	public static void POGOOPDLGEK(ushort[] DDEEHEFMBFD, [In] int PNIAMFBCHDA, [In] int PCELCFJIMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x75E4920", Offset = "0x75E3B20", VA = "0x1875E4920")]
	public static Bounds KJICJPNPNHN([In] QuadVertex[] IILHGIIHMBA, [In] ushort[] DDEEHEFMBFD, [In] int GBLNPEPMGGO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x75E3A60", Offset = "0x75E2C60", VA = "0x1875E3A60")]
	public static Bounds DBADFADANBK([In] QuadVertex[] IILHGIIHMBA, [In] ushort[] DDEEHEFMBFD, [In] int GBLNPEPMGGO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x75E3970", Offset = "0x75E2B70", VA = "0x1875E3970")]
	[CompilerGenerated]
	internal static void BLFOJAKENDI([In] float3 FGNDNDOCBOD, DPKLDPFDJPF P_1)
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
