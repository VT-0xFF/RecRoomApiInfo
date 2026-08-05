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
public static class NBBNKMIJPOE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1760", Offset = "0x6DD0B60", VA = "0x186DD1760")]
	public static float2 FHAIDLLBJBB(this DKJCKLHNEDL FKOMOGAMMAI)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DKJCKLHNEDL : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2805F60", Offset = "0x2805360", VA = "0x182805F60")]
		public float2Rect(float2 MBJNFCDOKCE, float2 MFKKELONDCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3E40", Offset = "0x6DD3240", VA = "0x186DD3E40")]
		public void CPFOJCEKBFH([Out] float2 JNFFDGPOIBE, [Out] float2 NDEGAJDEEDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4090", Offset = "0x6DD3490", VA = "0x186DD4090")]
		public float2 PFDICMHOPML(float2 HAHNFDMNEFF)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3E60", Offset = "0x6DD3260", VA = "0x186DD3E60", Slot = "4")]
		public bool Equals(float2Rect OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3EE0", Offset = "0x6DD32E0", VA = "0x186DD3EE0", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3FE0", Offset = "0x6DD33E0", VA = "0x186DD3FE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6DD40C0", Offset = "0x6DD34C0", VA = "0x186DD40C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DD42E0", Offset = "0x6DD36E0", VA = "0x186DD42E0", Slot = "5")]
		public string ToString(string BJFFNJGHPDD, IFormatProvider MGNHNPKAOFE)
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
		[Cpp2IlInjected.Address(RVA = "0x6DD4730", Offset = "0x6DD3B30", VA = "0x186DD4730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6DD46A0", Offset = "0x6DD3AA0", VA = "0x186DD46A0", Slot = "6")]
		public string ToString(string BJFFNJGHPDD, IFormatProvider MGNHNPKAOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4500", Offset = "0x6DD3900", VA = "0x186DD4500", Slot = "4")]
		public bool Equals(floatMinMax OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6DD45F0", Offset = "0x6DD39F0", VA = "0x186DD45F0", Slot = "5")]
		public bool Equals(float2 OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4540", Offset = "0x6DD3940", VA = "0x186DD4540", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4620", Offset = "0x6DD3A20", VA = "0x186DD4620", Slot = "2")]
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
		private IFGNAKGKCFE cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3BB0", Offset = "0x6DD2FB0", VA = "0x186DD3BB0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3CF0", Offset = "0x6DD30F0", VA = "0x186DD3CF0")]
		public LayoutRect(LayoutRect parent, DKJCKLHNEDL parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DD36C0", Offset = "0x6DD2AC0", VA = "0x186DD36C0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3620", Offset = "0x6DD2A20", VA = "0x186DD3620")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3690", Offset = "0x6DD2A90", VA = "0x186DD3690")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3630", Offset = "0x6DD2A30", VA = "0x186DD3630")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DD37D0", Offset = "0x6DD2BD0", VA = "0x186DD37D0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DD1630", Offset = "0x6DD0A30", VA = "0x186DD1630")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3880", Offset = "0x6DD2C80", VA = "0x186DD3880")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3840", Offset = "0x6DD2C40", VA = "0x186DD3840")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3800", Offset = "0x6DD2C00", VA = "0x186DD3800")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3930", Offset = "0x6DD2D30", VA = "0x186DD3930")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6DD38F0", Offset = "0x6DD2CF0", VA = "0x186DD38F0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3890", Offset = "0x6DD2C90", VA = "0x186DD3890")]
		public void SetParentAlignment(DKJCKLHNEDL rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6DD36E0", Offset = "0x6DD2AE0", VA = "0x186DD36E0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3740", Offset = "0x6DD2B40", VA = "0x186DD3740")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DD36D0", Offset = "0x6DD2AD0", VA = "0x186DD36D0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6DD39E0", Offset = "0x6DD2DE0", VA = "0x186DD39E0")]
		private IFGNAKGKCFE UpdateCache()
		{
			return default(IFGNAKGKCFE);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum IFGNAKGKCFE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HGNJNGHLHPO
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] GKLMBKDOEEE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6DD19A0", Offset = "0x6DD0DA0", VA = "0x186DD19A0")]
	public static float2Rect HEGFIAHNCIK(Transform KPGNNEMIHME, RectTransform ANHPPPBDANF)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1CB0", Offset = "0x6DD10B0", VA = "0x186DD1CB0")]
	public static void JBCCMJLEIJK(Vector3[] JPMOKLEHKKO, [Out] float2 GOCGGGCOOLH, [Out] float2 GGBNJANNJDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class ICNACBKEKEA
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] FBFHBDOJDIP;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1DE0", Offset = "0x6DD11E0", VA = "0x186DD1DE0")]
	public static void LMIKAPCOKBC([In] int LCCEHFLDACF, [Out] ushort DLIILJJFKGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JEIJBPDJGOC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MAACIMCOCFA
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
	[Cpp2IlInjected.Address(RVA = "0x6DD2E30", Offset = "0x6DD2230", VA = "0x186DD2E30")]
	public static void MCHMMNLLJNF(float3[] IJKPFBNMMOP, [In] float2 CCPLABNBPGL, [In] float2 NDEGAJDEEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2C90", Offset = "0x6DD2090", VA = "0x186DD2C90")]
	public static void KEGAAFGKFMC(float2[] DOPBJMEHJHD, [In] float2 OHEKICMKFBC, [In] float2 GNOPFJEKDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD20D0", Offset = "0x6DD14D0", VA = "0x186DD20D0")]
	public static void BOAGMNJJPCA(float3[] IJKPFBNMMOP, [In] float CDAHNFONPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2D20", Offset = "0x6DD2120", VA = "0x186DD2D20")]
	public static void LJOFGGHKPCA(QuadVertex[] DCIOBOIGAHN, [In] int DLIILJJFKGH, [In] float3[] EKNJJOIOIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2140", Offset = "0x6DD1540", VA = "0x186DD2140")]
	public static void CCCHPFGLNBD(QuadVertex[] DCIOBOIGAHN, int DLIILJJFKGH, [In] float3[] EKNJJOIOIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2C10", Offset = "0x6DD2010", VA = "0x186DD2C10")]
	public static void JIPNCKCFBMB(QuadVertex[] DCIOBOIGAHN, [In] int DLIILJJFKGH, [In] Color32 KENCNPBNGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2050", Offset = "0x6DD1450", VA = "0x186DD2050")]
	public static void AKBHICCCECF(QuadVertex[] DCIOBOIGAHN, int DLIILJJFKGH, [In] Color32 KENCNPBNGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2A70", Offset = "0x6DD1E70", VA = "0x186DD2A70")]
	public static void HBOAGBJDKFJ(QuadVertex[] DCIOBOIGAHN, [In] int DLIILJJFKGH, [In] float2[] BJGILMMONOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DD31C0", Offset = "0x6DD25C0", VA = "0x186DD31C0")]
	public static void MPMFAGIBNDB(QuadVertex[] DCIOBOIGAHN, int DLIILJJFKGH, [In] float2[] BJGILMMONOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DD26D0", Offset = "0x6DD1AD0", VA = "0x186DD26D0")]
	public static void FGGAMCLLKHK(QuadVertex[] DCIOBOIGAHN, int DLIILJJFKGH, [In] float3[] EKNJJOIOIDN, [In] Color32 KENCNPBNGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2850", Offset = "0x6DD1C50", VA = "0x186DD2850")]
	public static void GBJFICGOJNJ(QuadVertex[] DCIOBOIGAHN, int DLIILJJFKGH, [In] float3[] EKNJJOIOIDN, [In] float2[] BJGILMMONOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2250", Offset = "0x6DD1650", VA = "0x186DD2250")]
	public static void CMJFFEHDEDL(QuadVertex[] DCIOBOIGAHN, int DLIILJJFKGH, [In] Color32 KENCNPBNGIG, [In] float2[] BJGILMMONOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3390", Offset = "0x6DD2790", VA = "0x186DD3390")]
	public static void OLMDFENLKGK(QuadVertex[] DCIOBOIGAHN, int DLIILJJFKGH, [In] float3[] EKNJJOIOIDN, [In] Color32 KENCNPBNGIG, [In] float2[] BJGILMMONOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1F20", Offset = "0x6DD1320", VA = "0x186DD1F20")]
	public static void AJHNIJKNLCK(ushort[] BDBKCBFCDKK, int LCCEHFLDACF, [In] int OKNGCKAACJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3350", Offset = "0x6DD2750", VA = "0x186DD3350")]
	public static void OKFEGEMAPOM(ushort[] BDBKCBFCDKK, int LCCEHFLDACF, [In] int OKNGCKAACJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2B80", Offset = "0x6DD1F80", VA = "0x186DD2B80")]
	public static void JDKPDEPKDOK(ushort[] BDBKCBFCDKK, [In] int LCCEHFLDACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2610", Offset = "0x6DD1A10", VA = "0x186DD2610")]
	public static void ELBANEBGBAM(ushort[] BDBKCBFCDKK, [In] int LCCEHFLDACF, [In] int DLIILJJFKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6DD23D0", Offset = "0x6DD17D0", VA = "0x186DD23D0")]
	public static Bounds EDLBDCNBFLL([In] QuadVertex[] DCIOBOIGAHN, [In] ushort[] BDBKCBFCDKK, [In] int LACHCOLEOHJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2EB0", Offset = "0x6DD22B0", VA = "0x186DD2EB0")]
	public static Bounds MJNHLPKBEFH([In] QuadVertex[] DCIOBOIGAHN, [In] ushort[] BDBKCBFCDKK, [In] int LACHCOLEOHJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD32D0", Offset = "0x6DD26D0", VA = "0x186DD32D0")]
	[CompilerGenerated]
	internal static void NKOJCNAJKJE([In] float3 EDLBBMLDLIP, MAACIMCOCFA P_1)
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
