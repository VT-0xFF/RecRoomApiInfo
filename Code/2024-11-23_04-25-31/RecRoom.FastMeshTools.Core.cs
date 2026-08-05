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
public static class MGLKFLFACDP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6DDF7B0", Offset = "0x6DDE1B0", VA = "0x186DDF7B0")]
	public static float2 FFNJGGAFJNP(this KCCLAJLEPBF FCNJBAABHBA)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KCCLAJLEPBF : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2895E40", Offset = "0x2894840", VA = "0x182895E40")]
		public float2Rect(float2 PCPIJKGKPCE, float2 LEGDMNLNDAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DE20F0", Offset = "0x6DE0AF0", VA = "0x186DE20F0")]
		public void KGDOKCMJMKM([Out] float2 JJIMFLOFPMI, [Out] float2 PHBBIKOHIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1E90", Offset = "0x6DE0890", VA = "0x186DE1E90")]
		public float2 EDGGLDPFAEM(float2 CKOBNCLNHDK)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1EC0", Offset = "0x6DE08C0", VA = "0x186DE1EC0", Slot = "4")]
		public bool Equals(float2Rect GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1F40", Offset = "0x6DE0940", VA = "0x186DE1F40", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2040", Offset = "0x6DE0A40", VA = "0x186DE2040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2110", Offset = "0x6DE0B10", VA = "0x186DE2110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2330", Offset = "0x6DE0D30", VA = "0x186DE2330", Slot = "5")]
		public string ToString(string ICABLEDECHB, IFormatProvider GLCEFDMEIJA)
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
		[Cpp2IlInjected.Address(RVA = "0x6DE2770", Offset = "0x6DE1170", VA = "0x186DE2770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE26E0", Offset = "0x6DE10E0", VA = "0x186DE26E0", Slot = "6")]
		public string ToString(string ICABLEDECHB, IFormatProvider GLCEFDMEIJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2540", Offset = "0x6DE0F40", VA = "0x186DE2540", Slot = "4")]
		public bool Equals(floatMinMax GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2630", Offset = "0x6DE1030", VA = "0x186DE2630", Slot = "5")]
		public bool Equals(float2 GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2580", Offset = "0x6DE0F80", VA = "0x186DE2580", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2660", Offset = "0x6DE1060", VA = "0x186DE2660", Slot = "2")]
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
		private HMHHECGHEIM cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1C10", Offset = "0x6DE0610", VA = "0x186DE1C10")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1AC0", Offset = "0x6DE04C0", VA = "0x186DE1AC0")]
		public LayoutRect(LayoutRect parent, KCCLAJLEPBF parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DE15D0", Offset = "0x6DDFFD0", VA = "0x186DE15D0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1530", Offset = "0x6DDFF30", VA = "0x186DE1530")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6DE15A0", Offset = "0x6DDFFA0", VA = "0x186DE15A0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1540", Offset = "0x6DDFF40", VA = "0x186DE1540")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DE16E0", Offset = "0x6DE00E0", VA = "0x186DE16E0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DDF680", Offset = "0x6DDE080", VA = "0x186DDF680")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1790", Offset = "0x6DE0190", VA = "0x186DE1790")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1750", Offset = "0x6DE0150", VA = "0x186DE1750")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1710", Offset = "0x6DE0110", VA = "0x186DE1710")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1840", Offset = "0x6DE0240", VA = "0x186DE1840")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE17A0", Offset = "0x6DE01A0", VA = "0x186DE17A0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DE17E0", Offset = "0x6DE01E0", VA = "0x186DE17E0")]
		public void SetParentAlignment(KCCLAJLEPBF rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6DE15F0", Offset = "0x6DDFFF0", VA = "0x186DE15F0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1650", Offset = "0x6DE0050", VA = "0x186DE1650")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DE15E0", Offset = "0x6DDFFE0", VA = "0x186DE15E0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6DE18F0", Offset = "0x6DE02F0", VA = "0x186DE18F0")]
		private HMHHECGHEIM UpdateCache()
		{
			return default(HMHHECGHEIM);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum HMHHECGHEIM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class DPEOLGKMKMN
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] DBCAMGLLNCP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6DDFAB0", Offset = "0x6DDE4B0", VA = "0x186DDFAB0")]
	public static float2Rect LPCBKBABFLJ(Transform NLJIIBFJCCG, RectTransform PCFKCJNPKCO)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6DDF9F0", Offset = "0x6DDE3F0", VA = "0x186DDF9F0")]
	public static void GBPOFFFEOKG(Vector3[] JGJFMIDMMEL, [Out] float2 LAJFHIPPBIH, [Out] float2 APMEFBMNAML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class PNNKODEDBKI
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] AEGMNFJIKNJ;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1D50", Offset = "0x6DE0750", VA = "0x186DE1D50")]
	public static void BNDJKCGAKPB([In] int AIJEAFOKJLK, [Out] ushort ALEIKIGMKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GHDJMHPPNBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HCLHOCNDCAP
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
	[Cpp2IlInjected.Address(RVA = "0x6DE05D0", Offset = "0x6DDEFD0", VA = "0x186DE05D0")]
	public static void GGGKKLIBHGG(float3[] LIHOPIJOLPP, [In] float2 NBJNFBLGFKH, [In] float2 PHBBIKOHIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1430", Offset = "0x6DDFE30", VA = "0x186DE1430")]
	public static void NOHKBLMHGGD(float2[] ECDCKAMHIJM, [In] float2 ALOJOEMGOPB, [In] float2 CGLLKKHJAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE14C0", Offset = "0x6DDFEC0", VA = "0x186DE14C0")]
	public static void OOFFIFNLIOM(float3[] LIHOPIJOLPP, [In] float FDONNNGIMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0760", Offset = "0x6DDF160", VA = "0x186DE0760")]
	public static void HIHIOEPKKGD(QuadVertex[] GGMIHLDCGIA, [In] int ALEIKIGMKDH, [In] float3[] KBIPAJIFPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0F40", Offset = "0x6DDF940", VA = "0x186DE0F40")]
	public static void MHFLJMINNLM(QuadVertex[] GGMIHLDCGIA, int ALEIKIGMKDH, [In] float3[] KBIPAJIFPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DDFF40", Offset = "0x6DDE940", VA = "0x186DDFF40")]
	public static void ADNCLPNMHIL(QuadVertex[] GGMIHLDCGIA, [In] int ALEIKIGMKDH, [In] Color32 EBCEDIJGCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DE02C0", Offset = "0x6DDECC0", VA = "0x186DE02C0")]
	public static void FFDDLAMFMHF(QuadVertex[] GGMIHLDCGIA, int ALEIKIGMKDH, [In] Color32 EBCEDIJGCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DDFE30", Offset = "0x6DDE830", VA = "0x186DDFE30")]
	public static void ACICKIPDOMG(QuadVertex[] GGMIHLDCGIA, [In] int ALEIKIGMKDH, [In] float2[] FBHDDBLIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0650", Offset = "0x6DDF050", VA = "0x186DE0650")]
	public static void HDLAKAIOEAL(QuadVertex[] GGMIHLDCGIA, int ALEIKIGMKDH, [In] float2[] FBHDDBLIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0AB0", Offset = "0x6DDF4B0", VA = "0x186DE0AB0")]
	public static void LCHMOFECLOB(QuadVertex[] GGMIHLDCGIA, int ALEIKIGMKDH, [In] float3[] KBIPAJIFPOO, [In] Color32 EBCEDIJGCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DE11D0", Offset = "0x6DDFBD0", VA = "0x186DE11D0")]
	public static void NBJIIKPGKHB(QuadVertex[] GGMIHLDCGIA, int ALEIKIGMKDH, [In] float3[] KBIPAJIFPOO, [In] float2[] FBHDDBLIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1050", Offset = "0x6DDFA50", VA = "0x186DE1050")]
	public static void MMDMOPANJBL(QuadVertex[] GGMIHLDCGIA, int ALEIKIGMKDH, [In] Color32 EBCEDIJGCDN, [In] float2[] FBHDDBLIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0340", Offset = "0x6DDED40", VA = "0x186DE0340")]
	public static void FIPOLHOPLJH(QuadVertex[] GGMIHLDCGIA, int ALEIKIGMKDH, [In] float3[] KBIPAJIFPOO, [In] Color32 EBCEDIJGCDN, [In] float2[] FBHDDBLIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DDFFC0", Offset = "0x6DDE9C0", VA = "0x186DDFFC0")]
	public static void ALJHJBNOKNO(ushort[] LBKINELBFHF, int AIJEAFOKJLK, [In] int CBIIPLHGGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6DE13F0", Offset = "0x6DDFDF0", VA = "0x186DE13F0")]
	public static void NHIIGIDJFLM(ushort[] LBKINELBFHF, int AIJEAFOKJLK, [In] int CBIIPLHGGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6DE00F0", Offset = "0x6DDEAF0", VA = "0x186DE00F0")]
	public static void BGAFPKKDHKP(ushort[] LBKINELBFHF, [In] int AIJEAFOKJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0200", Offset = "0x6DDEC00", VA = "0x186DE0200")]
	public static void FBJONOHMBIF(ushort[] LBKINELBFHF, [In] int AIJEAFOKJLK, [In] int ALEIKIGMKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0870", Offset = "0x6DDF270", VA = "0x186DE0870")]
	public static Bounds KJLKIICKNNK([In] QuadVertex[] GGMIHLDCGIA, [In] ushort[] LBKINELBFHF, [In] int ILBNLCDBFEJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0C30", Offset = "0x6DDF630", VA = "0x186DE0C30")]
	public static Bounds LJLGCCFGDND([In] QuadVertex[] GGMIHLDCGIA, [In] ushort[] LBKINELBFHF, [In] int ILBNLCDBFEJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0180", Offset = "0x6DDEB80", VA = "0x186DE0180")]
	[CompilerGenerated]
	internal static void CFLHKCMMBHC([In] float3 CGOKOAJMBEG, HCLHOCNDCAP P_1)
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
