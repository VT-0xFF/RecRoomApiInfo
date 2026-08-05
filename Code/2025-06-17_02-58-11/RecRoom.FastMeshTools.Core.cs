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
public static class JOCJJHLICDG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7D2F7E0", Offset = "0x7D2E1E0", VA = "0x187D2F7E0")]
	public static float2 MFNCHFEHOOK(this HCCCLMOGDOO HIFPKCDEAIE)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HCCCLMOGDOO : byte
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
		[Cpp2IlInjected.Address(RVA = "0x2FDA7B0", Offset = "0x2FD91B0", VA = "0x182FDA7B0")]
		public float2Rect(float2 JFMEMBGKAOB, float2 OPKPFANIILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D32060", Offset = "0x7D30A60", VA = "0x187D32060")]
		public void AJIECABKDHF([Out] float2 BBALEHLLOON, [Out] float2 IBFJMOMAEHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D32080", Offset = "0x7D30A80", VA = "0x187D32080")]
		public float2 COBPPALOPJC(float2 ICKOBKNIKMG)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D320B0", Offset = "0x7D30AB0", VA = "0x187D320B0", Slot = "4")]
		public bool Equals(float2Rect NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D32130", Offset = "0x7D30B30", VA = "0x187D32130", Slot = "0")]
		public override bool Equals(object OJDHMKOBKLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7D32230", Offset = "0x7D30C30", VA = "0x187D32230", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D322E0", Offset = "0x7D30CE0", VA = "0x187D322E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D32500", Offset = "0x7D30F00", VA = "0x187D32500", Slot = "5")]
		public string ToString(string DFJIALHJPBA, IFormatProvider FGDNBAHEDKA)
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
		[Cpp2IlInjected.Address(RVA = "0x7D32950", Offset = "0x7D31350", VA = "0x187D32950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D328C0", Offset = "0x7D312C0", VA = "0x187D328C0", Slot = "6")]
		public string ToString(string DFJIALHJPBA, IFormatProvider FGDNBAHEDKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D32720", Offset = "0x7D31120", VA = "0x187D32720", Slot = "4")]
		public bool Equals(floatMinMax NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D32810", Offset = "0x7D31210", VA = "0x187D32810", Slot = "5")]
		public bool Equals(float2 NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7D32760", Offset = "0x7D31160", VA = "0x187D32760", Slot = "0")]
		public override bool Equals(object OJDHMKOBKLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D32840", Offset = "0x7D31240", VA = "0x187D32840", Slot = "2")]
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
		private IMAMLEBEOGJ cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D31C80", Offset = "0x7D30680", VA = "0x187D31C80")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D31DD0", Offset = "0x7D307D0", VA = "0x187D31DD0")]
		public LayoutRect(LayoutRect parent, HCCCLMOGDOO parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D31740", Offset = "0x7D30140", VA = "0x187D31740")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7D316A0", Offset = "0x7D300A0", VA = "0x187D316A0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7D31710", Offset = "0x7D30110", VA = "0x187D31710")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D316B0", Offset = "0x7D300B0", VA = "0x187D316B0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D31850", Offset = "0x7D30250", VA = "0x187D31850")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F8E0", Offset = "0x7D2E2E0", VA = "0x187D2F8E0")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7D31950", Offset = "0x7D30350", VA = "0x187D31950")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7D31900", Offset = "0x7D30300", VA = "0x187D31900")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7D318B0", Offset = "0x7D302B0", VA = "0x187D318B0")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7D31A00", Offset = "0x7D30400", VA = "0x187D31A00")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7D319B0", Offset = "0x7D303B0", VA = "0x187D319B0")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7D31960", Offset = "0x7D30360", VA = "0x187D31960")]
		public void SetParentAlignment(HCCCLMOGDOO rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7D31760", Offset = "0x7D30160", VA = "0x187D31760")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7D317C0", Offset = "0x7D301C0", VA = "0x187D317C0")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7D31750", Offset = "0x7D30150", VA = "0x187D31750")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7D31AB0", Offset = "0x7D304B0", VA = "0x187D31AB0")]
		private IMAMLEBEOGJ UpdateCache()
		{
			return default(IMAMLEBEOGJ);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum IMAMLEBEOGJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class IKKPEKLHMHP
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] FPNDGBEPOOI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D31320", Offset = "0x7D2FD20", VA = "0x187D31320")]
	public static float2Rect PEMHJKOKHIG(Transform FGPPOPBMCEE, RectTransform DKLAGICAOGN)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D31260", Offset = "0x7D2FC60", VA = "0x187D31260")]
	public static void CEGKNADMEGC(Vector3[] KOJNGNKLBAL, [Out] float2 FABCOJIGKOI, [Out] float2 EOFJEGBKIJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NOOHPKDMPHD
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] CKBNIBCELAG;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D31F20", Offset = "0x7D30920", VA = "0x187D31F20")]
	public static void JOPDAGLEGOG([In] int FILEHHCPALO, [Out] ushort AHJEGLNIPKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EFGFJKOCLAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PNAALGHAAFP
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
	[Cpp2IlInjected.Address(RVA = "0x7D304E0", Offset = "0x7D2EEE0", VA = "0x187D304E0")]
	public static void JFKMLBKAPMG(float3[] CLGLDNGCPKK, [In] float2 PFHGJEMKDJN, [In] float2 IBFJMOMAEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D30E40", Offset = "0x7D2F840", VA = "0x187D30E40")]
	public static void NDFMAPHOLIO(float2[] AHDIBGNKGPB, [In] float2 KNMFALLECFF, [In] float2 LFIBKDLKJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D2FE20", Offset = "0x7D2E820", VA = "0x187D2FE20")]
	public static void DCNIAHLPBEH(float3[] CLGLDNGCPKK, [In] float FIPCEAHBFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D30920", Offset = "0x7D2F320", VA = "0x187D30920")]
	public static void KMMIDGHMJJE(QuadVertex[] PCJNKJNHHLD, [In] int AHJEGLNIPKM, [In] float3[] CCGKPPAPIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D30560", Offset = "0x7D2EF60", VA = "0x187D30560")]
	public static void JGMBFLPFGIJ(QuadVertex[] PCJNKJNHHLD, int AHJEGLNIPKM, [In] float3[] CCGKPPAPIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D2FE90", Offset = "0x7D2E890", VA = "0x187D2FE90")]
	public static void DFBJMENPGAC(QuadVertex[] PCJNKJNHHLD, [In] int AHJEGLNIPKM, [In] Color32 MKFFJIFDKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D2FF10", Offset = "0x7D2E910", VA = "0x187D2FF10")]
	public static void ENBJJLGMPEO(QuadVertex[] PCJNKJNHHLD, int AHJEGLNIPKM, [In] Color32 MKFFJIFDKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D31110", Offset = "0x7D2FB10", VA = "0x187D31110")]
	public static void PCKMDMNCDPM(QuadVertex[] PCJNKJNHHLD, [In] int AHJEGLNIPKM, [In] float2[] HPEDHEDMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D30ED0", Offset = "0x7D2F8D0", VA = "0x187D30ED0")]
	public static void OBFMDLJIILF(QuadVertex[] PCJNKJNHHLD, int AHJEGLNIPKM, [In] float2[] HPEDHEDMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D302A0", Offset = "0x7D2ECA0", VA = "0x187D302A0")]
	public static void IAAOMNEOEAI(QuadVertex[] PCJNKJNHHLD, int AHJEGLNIPKM, [In] float3[] CCGKPPAPIMN, [In] Color32 MKFFJIFDKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7D30670", Offset = "0x7D2F070", VA = "0x187D30670")]
	public static void JODDNFKIBEF(QuadVertex[] PCJNKJNHHLD, int AHJEGLNIPKM, [In] float3[] CCGKPPAPIMN, [In] float2[] HPEDHEDMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D30A30", Offset = "0x7D2F430", VA = "0x187D30A30")]
	public static void MHECIPHMBOK(QuadVertex[] PCJNKJNHHLD, int AHJEGLNIPKM, [In] Color32 MKFFJIFDKIC, [In] float2[] HPEDHEDMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D30BB0", Offset = "0x7D2F5B0", VA = "0x187D30BB0")]
	public static void MHGBPHFBKKJ(QuadVertex[] PCJNKJNHHLD, int AHJEGLNIPKM, [In] float3[] CCGKPPAPIMN, [In] Color32 MKFFJIFDKIC, [In] float2[] HPEDHEDMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D30FE0", Offset = "0x7D2F9E0", VA = "0x187D30FE0")]
	public static void PBONEKNNKPC(ushort[] GPMLJCJGMHL, int FILEHHCPALO, [In] int ABOMACJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D31220", Offset = "0x7D2FC20", VA = "0x187D31220")]
	public static void PGKOPDNNOFL(ushort[] GPMLJCJGMHL, int FILEHHCPALO, [In] int ABOMACJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7D30890", Offset = "0x7D2F290", VA = "0x187D30890")]
	public static void KGMAGDMIOND(ushort[] GPMLJCJGMHL, [In] int FILEHHCPALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7D30420", Offset = "0x7D2EE20", VA = "0x187D30420")]
	public static void JEGNHJKKBKM(ushort[] GPMLJCJGMHL, [In] int FILEHHCPALO, [In] int AHJEGLNIPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D2FB60", Offset = "0x7D2E560", VA = "0x187D2FB60")]
	public static Bounds AJAGPIDADKG([In] QuadVertex[] PCJNKJNHHLD, [In] ushort[] GPMLJCJGMHL, [In] int CGOOPKMGOME)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7D2FF90", Offset = "0x7D2E990", VA = "0x187D2FF90")]
	public static Bounds FHDLMBABLCE([In] QuadVertex[] PCJNKJNHHLD, [In] ushort[] GPMLJCJGMHL, [In] int CGOOPKMGOME)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D2FDA0", Offset = "0x7D2E7A0", VA = "0x187D2FDA0")]
	[CompilerGenerated]
	internal static void DCKIJGACNPP([In] float3 ADAFNPDOCGP, PNAALGHAAFP P_1)
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
