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
public static class JAJFOMHHDHM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x84DA160", Offset = "0x84D8B60", VA = "0x1884DA160")]
	public static float2 DCENJPHDOBJ(this IMHJJGEKAEJ LLNKLHLPOBN)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum IMHJJGEKAEJ : byte
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
		[Cpp2IlInjected.Address(RVA = "0x3101A80", Offset = "0x3100480", VA = "0x183101A80")]
		public float2Rect(float2 KFJFDPLEJOD, float2 BCAJFCGHDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84DCE40", Offset = "0x84DB840", VA = "0x1884DCE40")]
		public void ODNAGOAKDMJ([Out] float2 DILMEJKOHAJ, [Out] float2 IKGIJEEKJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84DCBE0", Offset = "0x84DB5E0", VA = "0x1884DCBE0")]
		public float2 AGHKDNODMJO(float2 CMDPLHPBONN)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84DCC10", Offset = "0x84DB610", VA = "0x1884DCC10", Slot = "4")]
		public bool Equals(float2Rect GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84DCC90", Offset = "0x84DB690", VA = "0x1884DCC90", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84DCD90", Offset = "0x84DB790", VA = "0x1884DCD90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84DCE60", Offset = "0x84DB860", VA = "0x1884DCE60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84DD080", Offset = "0x84DBA80", VA = "0x1884DD080", Slot = "5")]
		public string ToString(string JBHFIGLCFLB, IFormatProvider ALDFMPMDBHO)
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
		[Cpp2IlInjected.Address(RVA = "0x84DD4C0", Offset = "0x84DBEC0", VA = "0x1884DD4C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84DD430", Offset = "0x84DBE30", VA = "0x1884DD430", Slot = "6")]
		public string ToString(string JBHFIGLCFLB, IFormatProvider ALDFMPMDBHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84DD290", Offset = "0x84DBC90", VA = "0x1884DD290", Slot = "4")]
		public bool Equals(floatMinMax GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84DD380", Offset = "0x84DBD80", VA = "0x1884DD380", Slot = "5")]
		public bool Equals(float2 GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84DD2D0", Offset = "0x84DBCD0", VA = "0x1884DD2D0", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84DD3B0", Offset = "0x84DBDB0", VA = "0x1884DD3B0", Slot = "2")]
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
		private MOINGPGFLLD cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84DC940", Offset = "0x84DB340", VA = "0x1884DC940")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84DCA90", Offset = "0x84DB490", VA = "0x1884DCA90")]
		public LayoutRect(LayoutRect parent, IMHJJGEKAEJ parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84DC400", Offset = "0x84DAE00", VA = "0x1884DC400")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84DC360", Offset = "0x84DAD60", VA = "0x1884DC360")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84DC3D0", Offset = "0x84DADD0", VA = "0x1884DC3D0")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84DC370", Offset = "0x84DAD70", VA = "0x1884DC370")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84DC510", Offset = "0x84DAF10", VA = "0x1884DC510")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84DA440", Offset = "0x84D8E40", VA = "0x1884DA440")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84DC610", Offset = "0x84DB010", VA = "0x1884DC610")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84DC5C0", Offset = "0x84DAFC0", VA = "0x1884DC5C0")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84DC570", Offset = "0x84DAF70", VA = "0x1884DC570")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84DC6C0", Offset = "0x84DB0C0", VA = "0x1884DC6C0")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84DC670", Offset = "0x84DB070", VA = "0x1884DC670")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84DC620", Offset = "0x84DB020", VA = "0x1884DC620")]
		public void SetParentAlignment(IMHJJGEKAEJ rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84DC420", Offset = "0x84DAE20", VA = "0x1884DC420")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84DC480", Offset = "0x84DAE80", VA = "0x1884DC480")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84DC410", Offset = "0x84DAE10", VA = "0x1884DC410")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84DC770", Offset = "0x84DB170", VA = "0x1884DC770")]
		private MOINGPGFLLD UpdateCache()
		{
			return default(MOINGPGFLLD);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MOINGPGFLLD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Clean,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Dirty
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BMAOOLPLMAM
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly Vector3[] EOLABBOMOEA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84DA640", Offset = "0x84D9040", VA = "0x1884DA640")]
	public static float2Rect KGFALBABGHF(Transform ACBHHPFIJGL, RectTransform JFBLIPHGGPK)
	{
		return default(float2Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84DA580", Offset = "0x84D8F80", VA = "0x1884DA580")]
	public static void FPHNLCCJFCO(Vector3[] AKJDNEJHKGM, [Out] float2 EPMJNJEPCMJ, [Out] float2 JOEBEKPOHKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JLLLNEJPDLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly int[] LCIJIEBGCFG;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84DC210", Offset = "0x84DAC10", VA = "0x1884DC210")]
	public static void ABNBKIDJEBG([In] int LPFDJNIEHFA, [Out] ushort KPDNPEEDMML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FMGDKFOEELH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NAIHNIKDEKF
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
	[Cpp2IlInjected.Address(RVA = "0x84DAFB0", Offset = "0x84D99B0", VA = "0x1884DAFB0")]
	public static void DKNBMAPNEGK(float3[] FDCFAGKFJEG, [In] float2 LJNMMLBGBNP, [In] float2 IKGIJEEKJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84DB700", Offset = "0x84DA100", VA = "0x1884DB700")]
	public static void GHHCPGHHGJK(float2[] HODCHJHHHAO, [In] float2 DEFMEFMGODM, [In] float2 LECCFMHMJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84DBA60", Offset = "0x84DA460", VA = "0x1884DBA60")]
	public static void HIJEGDAJIDI(float3[] FDCFAGKFJEG, [In] float HBNCJIPDAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84DBC10", Offset = "0x84DA610", VA = "0x1884DBC10")]
	public static void JHCGHFGKIGE(QuadVertex[] NNLEMDDOHPP, [In] int KPDNPEEDMML, [In] float3[] PCPKFKNEMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84DAEA0", Offset = "0x84D98A0", VA = "0x1884DAEA0")]
	public static void CIPNECBBLJP(QuadVertex[] NNLEMDDOHPP, int KPDNPEEDMML, [In] float3[] PCPKFKNEMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84DB680", Offset = "0x84DA080", VA = "0x1884DB680")]
	public static void GBENFGGFNDH(QuadVertex[] NNLEMDDOHPP, [In] int KPDNPEEDMML, [In] Color32 NKAIBJCPGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84DAE20", Offset = "0x84D9820", VA = "0x1884DAE20")]
	public static void AOIJHGLEOPB(QuadVertex[] NNLEMDDOHPP, int KPDNPEEDMML, [In] Color32 NKAIBJCPGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84DB440", Offset = "0x84D9E40", VA = "0x1884DB440")]
	public static void EODPHHJHCLD(QuadVertex[] NNLEMDDOHPP, [In] int KPDNPEEDMML, [In] float2[] IENLMKEPJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84DBD20", Offset = "0x84DA720", VA = "0x1884DBD20")]
	public static void KIGPMIJFEDL(QuadVertex[] NNLEMDDOHPP, int KPDNPEEDMML, [In] float2[] IENLMKEPJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84DB030", Offset = "0x84D9A30", VA = "0x1884DB030")]
	public static void EENBFBBGBAE(QuadVertex[] NNLEMDDOHPP, int KPDNPEEDMML, [In] float3[] PCPKFKNEMGL, [In] Color32 NKAIBJCPGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84DBE30", Offset = "0x84DA830", VA = "0x1884DBE30")]
	public static void NHLLALKMKEL(QuadVertex[] NNLEMDDOHPP, int KPDNPEEDMML, [In] float3[] PCPKFKNEMGL, [In] float2[] IENLMKEPJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84DC090", Offset = "0x84DAA90", VA = "0x1884DC090")]
	public static void NOMNDKKGCJJ(QuadVertex[] NNLEMDDOHPP, int KPDNPEEDMML, [In] Color32 NKAIBJCPGMF, [In] float2[] IENLMKEPJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84DB1B0", Offset = "0x84D9BB0", VA = "0x1884DB1B0")]
	public static void ELIEDEIPGKJ(QuadVertex[] NNLEMDDOHPP, int KPDNPEEDMML, [In] float3[] PCPKFKNEMGL, [In] Color32 NKAIBJCPGMF, [In] float2[] IENLMKEPJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84DB550", Offset = "0x84D9F50", VA = "0x1884DB550")]
	public static void FFOHCDLIGKF(ushort[] NNIKLEEHAIB, int LPFDJNIEHFA, [In] int KEACLBFIHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x84DC050", Offset = "0x84DAA50", VA = "0x1884DC050")]
	public static void NKFCCMOJJGN(ushort[] NNIKLEEHAIB, int LPFDJNIEHFA, [In] int KEACLBFIHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x84DB790", Offset = "0x84DA190", VA = "0x1884DB790")]
	public static void GIKCLCGMCOH(ushort[] NNIKLEEHAIB, [In] int LPFDJNIEHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84DBAD0", Offset = "0x84DA4D0", VA = "0x1884DBAD0")]
	public static void IJGJMEBJHAJ(ushort[] NNIKLEEHAIB, [In] int LPFDJNIEHFA, [In] int KPDNPEEDMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84DB820", Offset = "0x84DA220", VA = "0x1884DB820")]
	public static Bounds HEHKPDDDIMK([In] QuadVertex[] NNLEMDDOHPP, [In] ushort[] NNIKLEEHAIB, [In] int DABEDPLMPGP)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x84DAB10", Offset = "0x84D9510", VA = "0x1884DAB10")]
	public static Bounds ANGIIBGLLIB([In] QuadVertex[] NNLEMDDOHPP, [In] ushort[] NNIKLEEHAIB, [In] int DABEDPLMPGP)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84DBB90", Offset = "0x84DA590", VA = "0x1884DBB90")]
	[CompilerGenerated]
	internal static void JADDJFAEAJO([In] float3 BNAMGIMJGIC, NAIHNIKDEKF P_1)
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
