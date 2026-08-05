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
public static class OKNBFMMLKPN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C54D30", Offset = "0x6C53F30", VA = "0x186C54D30")]
	public static float2 LEDIFOEDMOP(this AEDALKJOJBN GCNABCGFNKM)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AEDALKJOJBN : byte
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
		[Cpp2IlInjected.Address(RVA = "0x27DF730", Offset = "0x27DE930", VA = "0x1827DF730")]
		public float2Rect(float2 FJFKFIAGEPM, float2 JAICOMOJIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C57410", Offset = "0x6C56610", VA = "0x186C57410")]
		public void BINADAOPODH([Out] float2 KKJOEDCBGPG, [Out] float2 CAFMGHMPBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C575B0", Offset = "0x6C567B0", VA = "0x186C575B0")]
		public float2 GGNBEGCPBBN(float2 HDPJDJDBEJH)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C57430", Offset = "0x6C56630", VA = "0x186C57430", Slot = "4")]
		public bool Equals(float2Rect KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6C574B0", Offset = "0x6C566B0", VA = "0x186C574B0", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C575E0", Offset = "0x6C567E0", VA = "0x186C575E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C57690", Offset = "0x6C56890", VA = "0x186C57690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6C578B0", Offset = "0x6C56AB0", VA = "0x186C578B0", Slot = "5")]
		public string ToString(string EAJPHFGLPOO, IFormatProvider GPKMPBOEKMF)
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
		[Cpp2IlInjected.Address(RVA = "0x6C57CF0", Offset = "0x6C56EF0", VA = "0x186C57CF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C57C60", Offset = "0x6C56E60", VA = "0x186C57C60", Slot = "6")]
		public string ToString(string EAJPHFGLPOO, IFormatProvider GPKMPBOEKMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C57AC0", Offset = "0x6C56CC0", VA = "0x186C57AC0", Slot = "4")]
		public bool Equals(floatMinMax KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C57BB0", Offset = "0x6C56DB0", VA = "0x186C57BB0", Slot = "5")]
		public bool Equals(float2 KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C57B00", Offset = "0x6C56D00", VA = "0x186C57B00", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C57BE0", Offset = "0x6C56DE0", VA = "0x186C57BE0", Slot = "2")]
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
		private OEFNAGHPPNH cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C55A90", Offset = "0x6C54C90", VA = "0x186C55A90")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C55940", Offset = "0x6C54B40", VA = "0x186C55940")]
		public LayoutRect(LayoutRect parent, AEDALKJOJBN parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C55450", Offset = "0x6C54650", VA = "0x186C55450")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C553B0", Offset = "0x6C545B0", VA = "0x186C553B0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C55420", Offset = "0x6C54620", VA = "0x186C55420")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C553C0", Offset = "0x6C545C0", VA = "0x186C553C0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C55560", Offset = "0x6C54760", VA = "0x186C55560")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C54C00", Offset = "0x6C53E00", VA = "0x186C54C00")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C55610", Offset = "0x6C54810", VA = "0x186C55610")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C555D0", Offset = "0x6C547D0", VA = "0x186C555D0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C55590", Offset = "0x6C54790", VA = "0x186C55590")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6C556C0", Offset = "0x6C548C0", VA = "0x186C556C0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C55680", Offset = "0x6C54880", VA = "0x186C55680")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6C55620", Offset = "0x6C54820", VA = "0x186C55620")]
		public void SetParentAlignment(AEDALKJOJBN rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C55470", Offset = "0x6C54670", VA = "0x186C55470")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C554D0", Offset = "0x6C546D0", VA = "0x186C554D0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C55460", Offset = "0x6C54660", VA = "0x186C55460")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C55770", Offset = "0x6C54970", VA = "0x186C55770")]
		private OEFNAGHPPNH UpdateCache()
		{
			return default(OEFNAGHPPNH);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OEFNAGHPPNH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HHEEEIAHBPG
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] CPFJHNCANPN;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C55030", Offset = "0x6C54230", VA = "0x186C55030")]
	public static float2Rect HPDDDDACJNG(Transform DHPMKPBHFAE, RectTransform LCMBJJGJCLO)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C54F70", Offset = "0x6C54170", VA = "0x186C54F70")]
	public static void DNGIIIPALIB(Vector3[] KMKJBBOEEHG, [Out] float2 LGOHHHLPLHB, [Out] float2 KBKIMKNFKDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NFJLBHFKHFK
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] CKDAJCEFKHC;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C55BD0", Offset = "0x6C54DD0", VA = "0x186C55BD0")]
	public static void CBKPHAJAKEI([In] int LEKEIDABGOI, [Out] ushort PFNIDKMGBPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PKANCEHMHII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JAAKBAHKLJM
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
	[Cpp2IlInjected.Address(RVA = "0x6C563D0", Offset = "0x6C555D0", VA = "0x186C563D0")]
	public static void CJBLACBMJBE(float3[] DLFICKILCHJ, [In] float2 PNFINOEBDBN, [In] float2 CAFMGHMPBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C569D0", Offset = "0x6C55BD0", VA = "0x186C569D0")]
	public static void FNBEJOICBDO(float2[] MFJAEOAIHDC, [In] float2 CLJHJNPACBL, [In] float2 OKEJBEMJONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C56050", Offset = "0x6C55250", VA = "0x186C56050")]
	public static void BIPKJOBJONP(float3[] DLFICKILCHJ, [In] float ANPEGNGLMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C57050", Offset = "0x6C56250", VA = "0x186C57050")]
	public static void MEJEHCFILJJ(QuadVertex[] OKEOMDMDCDI, [In] int PFNIDKMGBPD, [In] float3[] EHEDMMBMDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C57160", Offset = "0x6C56360", VA = "0x186C57160")]
	public static void MKKODCKHHCA(QuadVertex[] OKEOMDMDCDI, int PFNIDKMGBPD, [In] float3[] EHEDMMBMDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C56FD0", Offset = "0x6C561D0", VA = "0x186C56FD0")]
	public static void MCIOGJOCKPJ(QuadVertex[] OKEOMDMDCDI, [In] int PFNIDKMGBPD, [In] Color32 HHDOELJCCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C567A0", Offset = "0x6C559A0", VA = "0x186C567A0")]
	public static void EKHDAOJPEPE(QuadVertex[] OKEOMDMDCDI, int PFNIDKMGBPD, [In] Color32 HHDOELJCCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C57270", Offset = "0x6C56470", VA = "0x186C57270")]
	public static void OOOJLNIPEPE(QuadVertex[] OKEOMDMDCDI, [In] int PFNIDKMGBPD, [In] float2[] KMOMHENFCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C56CA0", Offset = "0x6C55EA0", VA = "0x186C56CA0")]
	public static void KNNBNBIAEDN(QuadVertex[] OKEOMDMDCDI, int PFNIDKMGBPD, [In] float2[] KMOMHENFCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C55E90", Offset = "0x6C55090", VA = "0x186C55E90")]
	public static void AIOIEPOHOPM(QuadVertex[] OKEOMDMDCDI, int PFNIDKMGBPD, [In] float3[] EHEDMMBMDIB, [In] Color32 HHDOELJCCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C56DB0", Offset = "0x6C55FB0", VA = "0x186C56DB0")]
	public static void LIBCGOMGAKJ(QuadVertex[] OKEOMDMDCDI, int PFNIDKMGBPD, [In] float3[] EHEDMMBMDIB, [In] float2[] KMOMHENFCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C55D10", Offset = "0x6C54F10", VA = "0x186C55D10")]
	public static void AFAFNJINGCL(QuadVertex[] OKEOMDMDCDI, int PFNIDKMGBPD, [In] Color32 HHDOELJCCHC, [In] float2[] KMOMHENFCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C56450", Offset = "0x6C55650", VA = "0x186C56450")]
	public static void DLDMINOJMMO(QuadVertex[] OKEOMDMDCDI, int PFNIDKMGBPD, [In] float3[] EHEDMMBMDIB, [In] Color32 HHDOELJCCHC, [In] float2[] KMOMHENFCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C56820", Offset = "0x6C55A20", VA = "0x186C56820")]
	public static void ELLJHIKGCHB(ushort[] KOABHCJLKEI, int LEKEIDABGOI, [In] int NOAKPBPHKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C56010", Offset = "0x6C55210", VA = "0x186C56010")]
	public static void AIOJDJDJPHL(ushort[] KOABHCJLKEI, int LEKEIDABGOI, [In] int NOAKPBPHKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C57380", Offset = "0x6C56580", VA = "0x186C57380")]
	public static void OPMOEMBGPEG(ushort[] KOABHCJLKEI, [In] int LEKEIDABGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C566E0", Offset = "0x6C558E0", VA = "0x186C566E0")]
	public static void EALOCEJKEEM(ushort[] KOABHCJLKEI, [In] int LEKEIDABGOI, [In] int PFNIDKMGBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C56A60", Offset = "0x6C55C60", VA = "0x186C56A60")]
	public static Bounds HFGEAFKGNND([In] QuadVertex[] OKEOMDMDCDI, [In] ushort[] KOABHCJLKEI, [In] int DBBBLJLDOHG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C560C0", Offset = "0x6C552C0", VA = "0x186C560C0")]
	public static Bounds CINBNNBHCML([In] QuadVertex[] OKEOMDMDCDI, [In] ushort[] KOABHCJLKEI, [In] int DBBBLJLDOHG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C56950", Offset = "0x6C55B50", VA = "0x186C56950")]
	[CompilerGenerated]
	internal static void FDMDFBABOFP([In] float3 HBNAJMHMLJE, JAAKBAHKLJM P_1)
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
