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
public static class BCKEFGFOBHG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x80A1920", Offset = "0x80A0720", VA = "0x1880A1920")]
	public static float2 IBHMIFLPEMM(this ECEFDJKOOJB EPJACIAHMHA)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ECEFDJKOOJB : byte
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
		[Cpp2IlInjected.Address(RVA = "0x30BFEB0", Offset = "0x30BECB0", VA = "0x1830BFEB0")]
		public float2Rect(float2 EMECBHNHILC, float2 DFCCCGNJINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x80A43A0", Offset = "0x80A31A0", VA = "0x1880A43A0")]
		public void DNJKCOADEJJ([Out] float2 GOGJKAFDALD, [Out] float2 IBBHFOFCBBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80A45F0", Offset = "0x80A33F0", VA = "0x1880A45F0")]
		public float2 HNMAPJIJILK(float2 DMKANLDDCPJ)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80A43C0", Offset = "0x80A31C0", VA = "0x1880A43C0", Slot = "4")]
		public bool Equals(float2Rect LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80A4440", Offset = "0x80A3240", VA = "0x1880A4440", Slot = "0")]
		public override bool Equals(object MKPNGAKJFMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80A4540", Offset = "0x80A3340", VA = "0x1880A4540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80A4620", Offset = "0x80A3420", VA = "0x1880A4620", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80A4840", Offset = "0x80A3640", VA = "0x1880A4840", Slot = "5")]
		public string ToString(string PEIENLIDFFI, IFormatProvider NJDAMFPAAIO)
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
		[Cpp2IlInjected.Address(RVA = "0x80A4C90", Offset = "0x80A3A90", VA = "0x1880A4C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80A4C00", Offset = "0x80A3A00", VA = "0x1880A4C00", Slot = "6")]
		public string ToString(string PEIENLIDFFI, IFormatProvider NJDAMFPAAIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80A4A60", Offset = "0x80A3860", VA = "0x1880A4A60", Slot = "4")]
		public bool Equals(floatMinMax LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80A4B50", Offset = "0x80A3950", VA = "0x1880A4B50", Slot = "5")]
		public bool Equals(float2 LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80A4AA0", Offset = "0x80A38A0", VA = "0x1880A4AA0", Slot = "0")]
		public override bool Equals(object MKPNGAKJFMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x80A4B80", Offset = "0x80A3980", VA = "0x1880A4B80", Slot = "2")]
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
		private KGJEBCDEDDO cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80A4100", Offset = "0x80A2F00", VA = "0x1880A4100")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80A3FB0", Offset = "0x80A2DB0", VA = "0x1880A3FB0")]
		public LayoutRect(LayoutRect parent, ECEFDJKOOJB parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80A3A70", Offset = "0x80A2870", VA = "0x1880A3A70")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80A39D0", Offset = "0x80A27D0", VA = "0x1880A39D0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x80A3A40", Offset = "0x80A2840", VA = "0x1880A3A40")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80A39E0", Offset = "0x80A27E0", VA = "0x1880A39E0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80A3B80", Offset = "0x80A2980", VA = "0x1880A3B80")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80A1C00", Offset = "0x80A0A00", VA = "0x1880A1C00")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80A3C80", Offset = "0x80A2A80", VA = "0x1880A3C80")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x80A3C30", Offset = "0x80A2A30", VA = "0x1880A3C30")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x80A3BE0", Offset = "0x80A29E0", VA = "0x1880A3BE0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x80A3D30", Offset = "0x80A2B30", VA = "0x1880A3D30")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x80A3CE0", Offset = "0x80A2AE0", VA = "0x1880A3CE0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x80A3C90", Offset = "0x80A2A90", VA = "0x1880A3C90")]
		public void SetParentAlignment(ECEFDJKOOJB rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80A3A90", Offset = "0x80A2890", VA = "0x1880A3A90")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80A3AF0", Offset = "0x80A28F0", VA = "0x1880A3AF0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x80A3A80", Offset = "0x80A2880", VA = "0x1880A3A80")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80A3DE0", Offset = "0x80A2BE0", VA = "0x1880A3DE0")]
		private KGJEBCDEDDO UpdateCache()
		{
			return default(KGJEBCDEDDO);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KGJEBCDEDDO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class IGCLKCLEIEP
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] FGJLADKHIPG;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80A3640", Offset = "0x80A2440", VA = "0x1880A3640")]
	public static float2Rect LIOIELOPGHM(Transform DKLIMBDAGFL, RectTransform IMBAOPHEODM)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x80A3580", Offset = "0x80A2380", VA = "0x1880A3580")]
	public static void HDGKPCKHECA(Vector3[] EDKEJFIBCIO, [Out] float2 IIEOAHPEFEA, [Out] float2 PFNOCLOHBOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OLFPGCACKCB
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] NKKGGJBFIMA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x80A4250", Offset = "0x80A3050", VA = "0x1880A4250")]
	public static void LHMNAOBBFBF([In] int IJDNIFCFLNE, [Out] ushort NCAKCDBODFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GIIGHPPGBOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LCFEFPPKFEA
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
	[Cpp2IlInjected.Address(RVA = "0x80A2470", Offset = "0x80A1270", VA = "0x1880A2470")]
	public static void GGCNPDDBBBF(float3[] BGBOEPIOIOC, [In] float2 DPBKLEOPLAG, [In] float2 IBBHFOFCBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x80A34F0", Offset = "0x80A22F0", VA = "0x1880A34F0")]
	public static void PJAMFLMIDLD(float2[] NDPPEGFIMPH, [In] float2 ADBKPFNPBEJ, [In] float2 PPFCNINGOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80A21F0", Offset = "0x80A0FF0", VA = "0x1880A21F0")]
	public static void BNCLOJMNIFE(float3[] BGBOEPIOIOC, [In] float FANJNKJPJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x80A2890", Offset = "0x80A1690", VA = "0x1880A2890")]
	public static void JPPHEOEPJHB(QuadVertex[] MIBKEBNCOCD, [In] int NCAKCDBODFH, [In] float3[] OPLEILLPHBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x80A22E0", Offset = "0x80A10E0", VA = "0x1880A22E0")]
	public static void CKJBLOELHKN(QuadVertex[] MIBKEBNCOCD, int NCAKCDBODFH, [In] float3[] OPLEILLPHBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x80A23F0", Offset = "0x80A11F0", VA = "0x1880A23F0")]
	public static void EEEOOLAGOCK(QuadVertex[] MIBKEBNCOCD, [In] int NCAKCDBODFH, [In] Color32 GIEEFBCNGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80A2780", Offset = "0x80A1580", VA = "0x1880A2780")]
	public static void HLGKGGOFNKD(QuadVertex[] MIBKEBNCOCD, int NCAKCDBODFH, [In] Color32 GIEEFBCNGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80A20E0", Offset = "0x80A0EE0", VA = "0x1880A20E0")]
	public static void BDJOPDAGDNL(QuadVertex[] MIBKEBNCOCD, [In] int NCAKCDBODFH, [In] float2[] BGJDOIIMGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80A30D0", Offset = "0x80A1ED0", VA = "0x1880A30D0")]
	public static void NNJIPKHKJHF(QuadVertex[] MIBKEBNCOCD, int NCAKCDBODFH, [In] float2[] BGJDOIIMGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x80A2C50", Offset = "0x80A1A50", VA = "0x1880A2C50")]
	public static void KMJOLEEPGIN(QuadVertex[] MIBKEBNCOCD, int NCAKCDBODFH, [In] float3[] OPLEILLPHBM, [In] Color32 GIEEFBCNGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x80A1E80", Offset = "0x80A0C80", VA = "0x1880A1E80")]
	public static void ABMKGLHHHOP(QuadVertex[] MIBKEBNCOCD, int NCAKCDBODFH, [In] float3[] OPLEILLPHBM, [In] float2[] BGJDOIIMGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x80A29A0", Offset = "0x80A17A0", VA = "0x1880A29A0")]
	public static void KAHMHOAOPCN(QuadVertex[] MIBKEBNCOCD, int NCAKCDBODFH, [In] Color32 GIEEFBCNGHN, [In] float2[] BGJDOIIMGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x80A24F0", Offset = "0x80A12F0", VA = "0x1880A24F0")]
	public static void GPBPGJDJMGN(QuadVertex[] MIBKEBNCOCD, int NCAKCDBODFH, [In] float3[] OPLEILLPHBM, [In] Color32 GIEEFBCNGHN, [In] float2[] BGJDOIIMGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x80A2B20", Offset = "0x80A1920", VA = "0x1880A2B20")]
	public static void KHHFKNJGMNE(ushort[] NLOFJPGHMAK, int IJDNIFCFLNE, [In] int KMGCCGPKIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x80A20A0", Offset = "0x80A0EA0", VA = "0x1880A20A0")]
	public static void APFLEFMOBFG(ushort[] NLOFJPGHMAK, int IJDNIFCFLNE, [In] int KMGCCGPKIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x80A2800", Offset = "0x80A1600", VA = "0x1880A2800")]
	public static void IJCDPJBPHBF(ushort[] NLOFJPGHMAK, [In] int IJDNIFCFLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x80A3010", Offset = "0x80A1E10", VA = "0x1880A3010")]
	public static void NLMGEGDMJOF(ushort[] NLOFJPGHMAK, [In] int IJDNIFCFLNE, [In] int NCAKCDBODFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x80A2DD0", Offset = "0x80A1BD0", VA = "0x1880A2DD0")]
	public static Bounds NLBECFOGAMO([In] QuadVertex[] MIBKEBNCOCD, [In] ushort[] NLOFJPGHMAK, [In] int EPHJHIMMIBD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x80A31E0", Offset = "0x80A1FE0", VA = "0x1880A31E0")]
	public static Bounds PBCKJNCFPLG([In] QuadVertex[] MIBKEBNCOCD, [In] ushort[] NLOFJPGHMAK, [In] int EPHJHIMMIBD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x80A2260", Offset = "0x80A1060", VA = "0x1880A2260")]
	[CompilerGenerated]
	internal static void CIHIMGNMABH([In] float3 JEDAAEHCPKE, LCFEFPPKFEA P_1)
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
