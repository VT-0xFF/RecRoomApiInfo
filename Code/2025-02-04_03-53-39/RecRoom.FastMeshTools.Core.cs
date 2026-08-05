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
public static class NCDCFGPGAKE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x726B650", Offset = "0x726A450", VA = "0x18726B650")]
	public static float2 CKIMKOACGJI(this POFCFICPDGK GIHEFEEIHHM)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum POFCFICPDGK : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2B6F2F0", Offset = "0x2B6E0F0", VA = "0x182B6F2F0")]
		public float2Rect(float2 AKEODPFBHJE, float2 IECADCKMGOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x726DD70", Offset = "0x726CB70", VA = "0x18726DD70")]
		public void AHAOIMLDBFI([Out] float2 DLANCEJJGDE, [Out] float2 JOEBPOBPNDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x726DD90", Offset = "0x726CB90", VA = "0x18726DD90")]
		public float2 EJBHEPLIHDA(float2 BGFLFJNCDLE)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x726DDC0", Offset = "0x726CBC0", VA = "0x18726DDC0", Slot = "4")]
		public bool Equals(float2Rect LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x726DE40", Offset = "0x726CC40", VA = "0x18726DE40", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x726DF40", Offset = "0x726CD40", VA = "0x18726DF40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x726DFF0", Offset = "0x726CDF0", VA = "0x18726DFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x726E210", Offset = "0x726D010", VA = "0x18726E210", Slot = "5")]
		public string ToString(string IKCALPFNNBN, IFormatProvider AGOGDECGFFH)
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
		[Cpp2IlInjected.Address(RVA = "0x726E660", Offset = "0x726D460", VA = "0x18726E660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x726E5D0", Offset = "0x726D3D0", VA = "0x18726E5D0", Slot = "6")]
		public string ToString(string IKCALPFNNBN, IFormatProvider AGOGDECGFFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x726E430", Offset = "0x726D230", VA = "0x18726E430", Slot = "4")]
		public bool Equals(floatMinMax LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x726E520", Offset = "0x726D320", VA = "0x18726E520", Slot = "5")]
		public bool Equals(float2 LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x726E470", Offset = "0x726D270", VA = "0x18726E470", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x726E550", Offset = "0x726D350", VA = "0x18726E550", Slot = "2")]
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
		private NGFGOFNOGCA cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x726DAC0", Offset = "0x726C8C0", VA = "0x18726DAC0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x726DC10", Offset = "0x726CA10", VA = "0x18726DC10")]
		public LayoutRect(LayoutRect parent, POFCFICPDGK parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x726D5D0", Offset = "0x726C3D0", VA = "0x18726D5D0")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x726D530", Offset = "0x726C330", VA = "0x18726D530")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x726D5A0", Offset = "0x726C3A0", VA = "0x18726D5A0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x726D540", Offset = "0x726C340", VA = "0x18726D540")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x726D6E0", Offset = "0x726C4E0", VA = "0x18726D6E0")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x726B520", Offset = "0x726A320", VA = "0x18726B520")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x726D790", Offset = "0x726C590", VA = "0x18726D790")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x726D750", Offset = "0x726C550", VA = "0x18726D750")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x726D710", Offset = "0x726C510", VA = "0x18726D710")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x726D840", Offset = "0x726C640", VA = "0x18726D840")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x726D800", Offset = "0x726C600", VA = "0x18726D800")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x726D7A0", Offset = "0x726C5A0", VA = "0x18726D7A0")]
		public void SetParentAlignment(POFCFICPDGK rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x726D5F0", Offset = "0x726C3F0", VA = "0x18726D5F0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x726D650", Offset = "0x726C450", VA = "0x18726D650")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x726D5E0", Offset = "0x726C3E0", VA = "0x18726D5E0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x726D8F0", Offset = "0x726C6F0", VA = "0x18726D8F0")]
		private NGFGOFNOGCA UpdateCache()
		{
			return default(NGFGOFNOGCA);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NGFGOFNOGCA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AKKFGOBINEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] PCJFPGAMCNI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x726B750", Offset = "0x726A550", VA = "0x18726B750")]
	public static float2Rect EDAGHMDONGA(Transform KPJKACDPMAA, RectTransform OBIPBFFAILK)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x726BA70", Offset = "0x726A870", VA = "0x18726BA70")]
	public static void NLAHLPOEMNM(Vector3[] LBOEEAGHLBO, [Out] float2 KGJBAAHPLAG, [Out] float2 GAMKMEIMNNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EKMGHOMKIEC
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] OAEJJPFNAFP;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x726BCE0", Offset = "0x726AAE0", VA = "0x18726BCE0")]
	public static void CDKBJEICJDB([In] int LLDHPAEGKDM, [Out] ushort DEFAPLEEAGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GCENJHMDDAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PFMEECDDDHD
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
	[Cpp2IlInjected.Address(RVA = "0x726C590", Offset = "0x726B390", VA = "0x18726C590")]
	public static void DHEJHNAEEEN(float3[] CEJANMAHLOP, [In] float2 NBGIHGCAFJO, [In] float2 JOEBPOBPNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x726BF40", Offset = "0x726AD40", VA = "0x18726BF40")]
	public static void BMHDLKAFMKG(float2[] FLGKMBLIPKA, [In] float2 CGKGIACPMHA, [In] float2 LKPLCLMLHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x726D430", Offset = "0x726C230", VA = "0x18726D430")]
	public static void OHMJKFCMHGO(float3[] CEJANMAHLOP, [In] float IDGAIPNBNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x726BFD0", Offset = "0x726ADD0", VA = "0x18726BFD0")]
	public static void CAEEIEKNBIG(QuadVertex[] DIOMMLECLAC, [In] int DEFAPLEEAGL, [In] float3[] BIBEJDCHGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x726C610", Offset = "0x726B410", VA = "0x18726C610")]
	public static void DNPJPCMAMKA(QuadVertex[] DIOMMLECLAC, int DEFAPLEEAGL, [In] float3[] BIBEJDCHGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x726D0A0", Offset = "0x726BEA0", VA = "0x18726D0A0")]
	public static void MHGBMACIAJB(QuadVertex[] DIOMMLECLAC, [In] int DEFAPLEEAGL, [In] Color32 KAOFHCPGOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x726C9A0", Offset = "0x726B7A0", VA = "0x18726C9A0")]
	public static void FJFDIOHDKAM(QuadVertex[] DIOMMLECLAC, int DEFAPLEEAGL, [In] Color32 KAOFHCPGOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x726BE30", Offset = "0x726AC30", VA = "0x18726BE30")]
	public static void AKENOFMLKLO(QuadVertex[] DIOMMLECLAC, [In] int DEFAPLEEAGL, [In] float2[] PHDEOJBKMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x726CB50", Offset = "0x726B950", VA = "0x18726CB50")]
	public static void GEJCLKICPMD(QuadVertex[] DIOMMLECLAC, int DEFAPLEEAGL, [In] float2[] PHDEOJBKMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x726C720", Offset = "0x726B520", VA = "0x18726C720")]
	public static void ECLPLAJMPAP(QuadVertex[] DIOMMLECLAC, int DEFAPLEEAGL, [In] float3[] BIBEJDCHGJJ, [In] Color32 KAOFHCPGOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x726C370", Offset = "0x726B170", VA = "0x18726C370")]
	public static void COCJCINACCC(QuadVertex[] DIOMMLECLAC, int DEFAPLEEAGL, [In] float3[] BIBEJDCHGJJ, [In] float2[] PHDEOJBKMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x726CC60", Offset = "0x726BA60", VA = "0x18726CC60")]
	public static void GLCPMNFOFHN(QuadVertex[] DIOMMLECLAC, int DEFAPLEEAGL, [In] Color32 KAOFHCPGOPM, [In] float2[] PHDEOJBKMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x726C0E0", Offset = "0x726AEE0", VA = "0x18726C0E0")]
	public static void CHEPFCEPGGJ(QuadVertex[] DIOMMLECLAC, int DEFAPLEEAGL, [In] float3[] BIBEJDCHGJJ, [In] Color32 KAOFHCPGOPM, [In] float2[] PHDEOJBKMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x726CA20", Offset = "0x726B820", VA = "0x18726CA20")]
	public static void FMLBIKFEODH(ushort[] IKCDIGOLMBF, int LLDHPAEGKDM, [In] int CKEOGKIAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x726C960", Offset = "0x726B760", VA = "0x18726C960")]
	public static void EMPAEMNDOGL(ushort[] IKCDIGOLMBF, int LLDHPAEGKDM, [In] int CKEOGKIAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x726D4A0", Offset = "0x726C2A0", VA = "0x18726D4A0")]
	public static void PPBHFBFGIBL(ushort[] IKCDIGOLMBF, [In] int LLDHPAEGKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x726C8A0", Offset = "0x726B6A0", VA = "0x18726C8A0")]
	public static void EGHCJKOEGCA(ushort[] IKCDIGOLMBF, [In] int LLDHPAEGKDM, [In] int DEFAPLEEAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x726CE60", Offset = "0x726BC60", VA = "0x18726CE60")]
	public static Bounds MBBLFJJDAHJ([In] QuadVertex[] DIOMMLECLAC, [In] ushort[] IKCDIGOLMBF, [In] int MDMEFHBPPNI)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x726D120", Offset = "0x726BF20", VA = "0x18726D120")]
	public static Bounds NLPKBDALJGB([In] QuadVertex[] DIOMMLECLAC, [In] ushort[] IKCDIGOLMBF, [In] int MDMEFHBPPNI)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x726CDE0", Offset = "0x726BBE0", VA = "0x18726CDE0")]
	[CompilerGenerated]
	internal static void ICICOJFAGOE([In] float3 HLIJNINJIMK, PFMEECDDDHD P_1)
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
