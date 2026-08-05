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
public static class DMNLGFDPBBE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x74EB210", Offset = "0x74E9810", VA = "0x1874EB210")]
	public static float2 JODIPIFKIAJ(this NBKGMFGBKHL MBFGAPMKIIG)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NBKGMFGBKHL : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2BCE740", Offset = "0x2BCCD40", VA = "0x182BCE740")]
		public float2Rect(float2 NDADPNJPMFO, float2 IBMHAIHIDJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74EDEF0", Offset = "0x74EC4F0", VA = "0x1874EDEF0")]
		public void JNMBAPLKJHM([Out] float2 DMKHJOBNCJC, [Out] float2 JMDLDEHAFMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x74EDEC0", Offset = "0x74EC4C0", VA = "0x1874EDEC0")]
		public float2 JFHDPAGDEKG(float2 FJFCMMJFMHH)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74EDC90", Offset = "0x74EC290", VA = "0x1874EDC90", Slot = "4")]
		public bool Equals(float2Rect OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74EDD10", Offset = "0x74EC310", VA = "0x1874EDD10", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74EDE10", Offset = "0x74EC410", VA = "0x1874EDE10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74EDF10", Offset = "0x74EC510", VA = "0x1874EDF10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x74EE130", Offset = "0x74EC730", VA = "0x1874EE130", Slot = "5")]
		public string ToString(string HGFLLJFOAAE, IFormatProvider FFBJJPHCNIA)
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
		[Cpp2IlInjected.Address(RVA = "0x74EE580", Offset = "0x74ECB80", VA = "0x1874EE580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x74EE4F0", Offset = "0x74ECAF0", VA = "0x1874EE4F0", Slot = "6")]
		public string ToString(string HGFLLJFOAAE, IFormatProvider FFBJJPHCNIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74EE350", Offset = "0x74EC950", VA = "0x1874EE350", Slot = "4")]
		public bool Equals(floatMinMax OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74EE440", Offset = "0x74ECA40", VA = "0x1874EE440", Slot = "5")]
		public bool Equals(float2 OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74EE390", Offset = "0x74EC990", VA = "0x1874EE390", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74EE470", Offset = "0x74ECA70", VA = "0x1874EE470", Slot = "2")]
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
		private MBGOGKNJMGL cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x74ED6F0", Offset = "0x74EBCF0", VA = "0x1874ED6F0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x74ED5A0", Offset = "0x74EBBA0", VA = "0x1874ED5A0")]
		public LayoutRect(LayoutRect parent, NBKGMFGBKHL parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x74ED060", Offset = "0x74EB660", VA = "0x1874ED060")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x74ECFC0", Offset = "0x74EB5C0", VA = "0x1874ECFC0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x74ED030", Offset = "0x74EB630", VA = "0x1874ED030")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74ECFD0", Offset = "0x74EB5D0", VA = "0x1874ECFD0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74ED170", Offset = "0x74EB770", VA = "0x1874ED170")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74EB4F0", Offset = "0x74E9AF0", VA = "0x1874EB4F0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x74ED270", Offset = "0x74EB870", VA = "0x1874ED270")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x74ED220", Offset = "0x74EB820", VA = "0x1874ED220")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x74ED1D0", Offset = "0x74EB7D0", VA = "0x1874ED1D0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x74ED320", Offset = "0x74EB920", VA = "0x1874ED320")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x74ED2D0", Offset = "0x74EB8D0", VA = "0x1874ED2D0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x74ED280", Offset = "0x74EB880", VA = "0x1874ED280")]
		public void SetParentAlignment(NBKGMFGBKHL rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x74ED080", Offset = "0x74EB680", VA = "0x1874ED080")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x74ED0E0", Offset = "0x74EB6E0", VA = "0x1874ED0E0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74ED070", Offset = "0x74EB670", VA = "0x1874ED070")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74ED3D0", Offset = "0x74EB9D0", VA = "0x1874ED3D0")]
		private MBGOGKNJMGL UpdateCache()
		{
			return default(MBGOGKNJMGL);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MBGOGKNJMGL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OAKEBGOOAFM
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] LEJAPPJNHDC;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74ED840", Offset = "0x74EBE40", VA = "0x1874ED840")]
	public static float2Rect FAKNMCGBNHN(Transform CMEACAFNGIE, RectTransform MOCLCNOAHKF)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x74EDB60", Offset = "0x74EC160", VA = "0x1874EDB60")]
	public static void ONINPEHFAAO(Vector3[] KFLAKNIFHGM, [Out] float2 CDIPILBCKFB, [Out] float2 HCEBABCAMLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JIHEDCHBDCP
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] HHLOHDCEHBI;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x74EB770", Offset = "0x74E9D70", VA = "0x1874EB770")]
	public static void JPBHPNMOEPE([In] int LLPGLADCDJP, [Out] ushort LMEHBDIKNMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KGJDLNOIHOJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HAFPOLFCJHO
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
	[Cpp2IlInjected.Address(RVA = "0x74ECF40", Offset = "0x74EB540", VA = "0x1874ECF40")]
	public static void NFPHNMNGELD(float3[] GLNKKPCLHKJ, [In] float2 HEFEPHBKPLP, [In] float2 JMDLDEHAFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x74EC020", Offset = "0x74EA620", VA = "0x1874EC020")]
	public static void DBIEMDMGFJJ(float2[] HBOAOKMGCAB, [In] float2 EJGMPPPNFFA, [In] float2 FKDJPOFHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x74ECE10", Offset = "0x74EB410", VA = "0x1874ECE10")]
	public static void MGJNNLPACJI(float3[] GLNKKPCLHKJ, [In] float OAPLHGGBBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x74EC0B0", Offset = "0x74EA6B0", VA = "0x1874EC0B0")]
	public static void DEKPJMEGAHG(QuadVertex[] PHDCDBDEDFM, [In] int LMEHBDIKNMD, [In] float3[] NFDLHDNPMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x74EC240", Offset = "0x74EA840", VA = "0x1874EC240")]
	public static void GNNFOKGAIMC(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] float3[] NFDLHDNPMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x74ECC80", Offset = "0x74EB280", VA = "0x1874ECC80")]
	public static void KKHMHHPHEAK(QuadVertex[] PHDCDBDEDFM, [In] int LMEHBDIKNMD, [In] Color32 JONBAOFIJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x74EC640", Offset = "0x74EAC40", VA = "0x1874EC640")]
	public static void IHPBCMHLHBO(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] Color32 JONBAOFIJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x74ECD00", Offset = "0x74EB300", VA = "0x1874ECD00")]
	public static void LCBANIBJFBH(QuadVertex[] PHDCDBDEDFM, [In] int LMEHBDIKNMD, [In] float2[] HCDPEHGDABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x74EC6C0", Offset = "0x74EACC0", VA = "0x1874EC6C0")]
	public static void IONPAPIIJNI(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] float2[] HCDPEHGDABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74EC4C0", Offset = "0x74EAAC0", VA = "0x1874EC4C0")]
	public static void IBKMIONBNBC(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] float3[] NFDLHDNPMJN, [In] Color32 JONBAOFIJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x74EC7D0", Offset = "0x74EADD0", VA = "0x1874EC7D0")]
	public static void JPBMCLOFJPH(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] float3[] NFDLHDNPMJN, [In] float2[] HCDPEHGDABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x74EBC60", Offset = "0x74EA260", VA = "0x1874EBC60")]
	public static void BIACMDPMPAA(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] Color32 JONBAOFIJIC, [In] float2[] HCDPEHGDABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x74EC9F0", Offset = "0x74EAFF0", VA = "0x1874EC9F0")]
	public static void KBLNKDFAJOF(QuadVertex[] PHDCDBDEDFM, int LMEHBDIKNMD, [In] float3[] NFDLHDNPMJN, [In] Color32 JONBAOFIJIC, [In] float2[] HCDPEHGDABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x74EC350", Offset = "0x74EA950", VA = "0x1874EC350")]
	public static void HEKMJGBMMHE(ushort[] EEPKNOKHHND, int LLPGLADCDJP, [In] int HCGIJEHJHEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x74EC480", Offset = "0x74EAA80", VA = "0x1874EC480")]
	public static void HPALPECAPCE(ushort[] EEPKNOKHHND, int LLPGLADCDJP, [In] int HCGIJEHJHEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x74EBBD0", Offset = "0x74EA1D0", VA = "0x1874EBBD0")]
	public static void APCOOKEGMOP(ushort[] EEPKNOKHHND, [In] int LLPGLADCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x74ECE80", Offset = "0x74EB480", VA = "0x1874ECE80")]
	public static void MJFKEKELBGH(ushort[] EEPKNOKHHND, [In] int LLPGLADCDJP, [In] int LMEHBDIKNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x74EBDE0", Offset = "0x74EA3E0", VA = "0x1874EBDE0")]
	public static Bounds CPFOCDODKLA([In] QuadVertex[] PHDCDBDEDFM, [In] ushort[] EEPKNOKHHND, [In] int JMPFMJBCKFB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x74EB8C0", Offset = "0x74E9EC0", VA = "0x1874EB8C0")]
	public static Bounds AJLHHGFHEMF([In] QuadVertex[] PHDCDBDEDFM, [In] ushort[] EEPKNOKHHND, [In] int JMPFMJBCKFB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x74EC1C0", Offset = "0x74EA7C0", VA = "0x1874EC1C0")]
	[CompilerGenerated]
	internal static void DMEHIAEBHNO([In] float3 FCEAHINHNGO, HAFPOLFCJHO P_1)
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
