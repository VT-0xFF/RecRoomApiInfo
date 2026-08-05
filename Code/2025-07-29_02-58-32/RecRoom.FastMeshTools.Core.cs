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
public static class IHCIJGJKDKI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x82E9730", Offset = "0x82E8130", VA = "0x1882E9730")]
	public static float2 OCLIJIKIBFJ(this CJLKDEEEHDE PIFPLFDEPDM)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CJLKDEEEHDE : byte
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
		[Cpp2IlInjected.Address(RVA = "0x3024C90", Offset = "0x3023690", VA = "0x183024C90")]
		public float2Rect(float2 DDIHIBMHCDH, float2 CGAAPEOHPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82EC360", Offset = "0x82EAD60", VA = "0x1882EC360")]
		public void GNAIPCHGPNM([Out] float2 INADCBCGHFO, [Out] float2 FJAILEFGLDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82EC1B0", Offset = "0x82EABB0", VA = "0x1882EC1B0")]
		public float2 DGKDLAIHMAF(float2 LPGMDMAJBFH)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82EC1E0", Offset = "0x82EABE0", VA = "0x1882EC1E0", Slot = "4")]
		public bool Equals(float2Rect EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82EC260", Offset = "0x82EAC60", VA = "0x1882EC260", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82EC380", Offset = "0x82EAD80", VA = "0x1882EC380", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82EC430", Offset = "0x82EAE30", VA = "0x1882EC430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82EC650", Offset = "0x82EB050", VA = "0x1882EC650", Slot = "5")]
		public string ToString(string NANAIMNHOFH, IFormatProvider JKJEFKEHAOK)
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
		[Cpp2IlInjected.Address(RVA = "0x82ECA90", Offset = "0x82EB490", VA = "0x1882ECA90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82ECA00", Offset = "0x82EB400", VA = "0x1882ECA00", Slot = "6")]
		public string ToString(string NANAIMNHOFH, IFormatProvider JKJEFKEHAOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82EC860", Offset = "0x82EB260", VA = "0x1882EC860", Slot = "4")]
		public bool Equals(floatMinMax EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82EC950", Offset = "0x82EB350", VA = "0x1882EC950", Slot = "5")]
		public bool Equals(float2 EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82EC8A0", Offset = "0x82EB2A0", VA = "0x1882EC8A0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82EC980", Offset = "0x82EB380", VA = "0x1882EC980", Slot = "2")]
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
		private CCOHLPIEHCF cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x82EBF10", Offset = "0x82EA910", VA = "0x1882EBF10")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82EC060", Offset = "0x82EAA60", VA = "0x1882EC060")]
		public LayoutRect(LayoutRect parent, CJLKDEEEHDE parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82EB9D0", Offset = "0x82EA3D0", VA = "0x1882EB9D0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82EB930", Offset = "0x82EA330", VA = "0x1882EB930")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82EB9A0", Offset = "0x82EA3A0", VA = "0x1882EB9A0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82EB940", Offset = "0x82EA340", VA = "0x1882EB940")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x82EBAE0", Offset = "0x82EA4E0", VA = "0x1882EBAE0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82E9A10", Offset = "0x82E8410", VA = "0x1882E9A10")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82EBBE0", Offset = "0x82EA5E0", VA = "0x1882EBBE0")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82EBB90", Offset = "0x82EA590", VA = "0x1882EBB90")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82EBB40", Offset = "0x82EA540", VA = "0x1882EBB40")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82EBC90", Offset = "0x82EA690", VA = "0x1882EBC90")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82EBC40", Offset = "0x82EA640", VA = "0x1882EBC40")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82EBBF0", Offset = "0x82EA5F0", VA = "0x1882EBBF0")]
		public void SetParentAlignment(CJLKDEEEHDE rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82EB9F0", Offset = "0x82EA3F0", VA = "0x1882EB9F0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82EBA50", Offset = "0x82EA450", VA = "0x1882EBA50")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82EB9E0", Offset = "0x82EA3E0", VA = "0x1882EB9E0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82EBD40", Offset = "0x82EA740", VA = "0x1882EBD40")]
		private CCOHLPIEHCF UpdateCache()
		{
			return default(CCOHLPIEHCF);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CCOHLPIEHCF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class KJPOHAKAJFN
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] NBNBEJFHGDN;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82EB4E0", Offset = "0x82E9EE0", VA = "0x1882EB4E0")]
	public static float2Rect AGFMOJHBAOH(Transform JBNJEPBCLIJ, RectTransform IMFCAPGBDGB)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82EB800", Offset = "0x82EA200", VA = "0x1882EB800")]
	public static void COJGGKIPFMP(Vector3[] OPPLGIKKKBI, [Out] float2 OIMFMPLNJEN, [Out] float2 HJDOALAIPGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FMJDBALFOMO
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] FNNCEJFEOPO;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x82E9C90", Offset = "0x82E8690", VA = "0x1882E9C90")]
	public static void NLFABGLADFG([In] int KMMLGDHMPEN, [Out] ushort JPCJEFBMALH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GKPHDGIGOAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IGNGEIFNAIF
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
	[Cpp2IlInjected.Address(RVA = "0x82EA2C0", Offset = "0x82E8CC0", VA = "0x1882EA2C0")]
	public static void DDJFEFAAAPB(float3[] APNCJOFMHEC, [In] float2 NBCEHDJIEMH, [In] float2 FJAILEFGLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x82EA5F0", Offset = "0x82E8FF0", VA = "0x1882EA5F0")]
	public static void EIODLEMPKKB(float2[] CJFBOFGHAMN, [In] float2 AOMNEHOFCME, [In] float2 OJNDGKFMGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x82EA340", Offset = "0x82E8D40", VA = "0x1882EA340")]
	public static void DNDIKKLPLIB(float3[] APNCJOFMHEC, [In] float AFEPOBJPOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x82EA680", Offset = "0x82E9080", VA = "0x1882EA680")]
	public static void FBNLHLPLECF(QuadVertex[] KFAIAMLNEIB, [In] int JPCJEFBMALH, [In] float3[] FLKILGGFOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x82EB3D0", Offset = "0x82E9DD0", VA = "0x1882EB3D0")]
	public static void POCGFHMNJCJ(QuadVertex[] KFAIAMLNEIB, int JPCJEFBMALH, [In] float3[] FLKILGGFOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x82EA110", Offset = "0x82E8B10", VA = "0x1882EA110")]
	public static void CLOFKDILLCA(QuadVertex[] KFAIAMLNEIB, [In] int JPCJEFBMALH, [In] Color32 NODALFLNONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x82EAD70", Offset = "0x82E9770", VA = "0x1882EAD70")]
	public static void LDFHGIPIEID(QuadVertex[] KFAIAMLNEIB, int JPCJEFBMALH, [In] Color32 NODALFLNONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x82EA790", Offset = "0x82E9190", VA = "0x1882EA790")]
	public static void FFAPCEOMIHJ(QuadVertex[] KFAIAMLNEIB, [In] int JPCJEFBMALH, [In] float2[] JILGJAKBANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82EAFB0", Offset = "0x82E99B0", VA = "0x1882EAFB0")]
	public static void MFHKNICLNLF(QuadVertex[] KFAIAMLNEIB, int JPCJEFBMALH, [In] float2[] JILGJAKBANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82EABF0", Offset = "0x82E95F0", VA = "0x1882EABF0")]
	public static void KOHCOFGDNLP(QuadVertex[] KFAIAMLNEIB, int JPCJEFBMALH, [In] float3[] FLKILGGFOAA, [In] Color32 NODALFLNONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x82E9E70", Offset = "0x82E8870", VA = "0x1882E9E70")]
	public static void ALBLIFCLLGH(QuadVertex[] KFAIAMLNEIB, int JPCJEFBMALH, [In] float3[] FLKILGGFOAA, [In] float2[] JILGJAKBANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x82EAE30", Offset = "0x82E9830", VA = "0x1882EAE30")]
	public static void MDINKDDJLMM(QuadVertex[] KFAIAMLNEIB, int JPCJEFBMALH, [In] Color32 NODALFLNONB, [In] float2[] JILGJAKBANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x82EA960", Offset = "0x82E9360", VA = "0x1882EA960")]
	public static void HBHECNNINKD(QuadVertex[] KFAIAMLNEIB, int JPCJEFBMALH, [In] float3[] FLKILGGFOAA, [In] Color32 NODALFLNONB, [In] float2[] JILGJAKBANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x82EA190", Offset = "0x82E8B90", VA = "0x1882EA190")]
	public static void DBINILNILIM(ushort[] JPGBGJKMLPG, int KMMLGDHMPEN, [In] int MGGNLLDJDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x82EADF0", Offset = "0x82E97F0", VA = "0x1882EADF0")]
	public static void LOENHNJDAAM(ushort[] JPGBGJKMLPG, int KMMLGDHMPEN, [In] int MGGNLLDJDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x82E9DE0", Offset = "0x82E87E0", VA = "0x1882E9DE0")]
	public static void ABKNJJPOEJG(ushort[] JPGBGJKMLPG, [In] int KMMLGDHMPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x82EA8A0", Offset = "0x82E92A0", VA = "0x1882EA8A0")]
	public static void FHDBBHLPLDN(ushort[] JPGBGJKMLPG, [In] int KMMLGDHMPEN, [In] int JPCJEFBMALH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x82EA3B0", Offset = "0x82E8DB0", VA = "0x1882EA3B0")]
	public static Bounds DNFNKJAAKIK([In] QuadVertex[] KFAIAMLNEIB, [In] ushort[] JPGBGJKMLPG, [In] int EKFPLOCDJJI)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x82EB0C0", Offset = "0x82E9AC0", VA = "0x1882EB0C0")]
	public static Bounds PHIFAFCBIEG([In] QuadVertex[] KFAIAMLNEIB, [In] ushort[] JPGBGJKMLPG, [In] int EKFPLOCDJJI)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x82EA090", Offset = "0x82E8A90", VA = "0x1882EA090")]
	[CompilerGenerated]
	internal static void BLEGHIHCOBH([In] float3 DJKLMOIIBCG, IGNGEIFNAIF P_1)
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
