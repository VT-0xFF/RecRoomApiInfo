using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.ClusterLODs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.ShapeRendering;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HJJAPKBOODA
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IFDMLBOHIBH
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<HJJAPKBOODA> ALOEIEELDNG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4BE3CA0", Offset = "0x4BE2CA0", VA = "0x184BE3CA0")]
	static IFDMLBOHIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4BE3CA0", Offset = "0x4BE2CA0", VA = "0x184BE3CA0")]
	[KPKNGEGAIEI]
	private static void EMFGCIHFDBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4BE3DC0", Offset = "0x4BE2DC0", VA = "0x184BE3DC0")]
	public static bool GKILKEJENKN(this HJJAPKBOODA AEMKABJHBHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MLDBBNIDEKG
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	PLACEHOLDER_16 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum GKNCGEAOFKL
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DNPIEFKPOLP
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	HoverXRay
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum HOGIOMDECBL
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CornerMove
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FDPEIDPHNAG : LHCHHDLHEJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private const byte OOOIJFBHCPD = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private byte KDHMMPOBOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<SkinnedShapeRenderer>[] PKDJKEKGFAE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GFPNILNEEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E40F0", Offset = "0x7E30F0", VA = "0x1807E40F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E3FD0", Offset = "0x7E2FD0", VA = "0x1807E3FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KACGGCOMFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84D6F0", Offset = "0x84C6F0", VA = "0x18084D6F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84D710", Offset = "0x84C710", VA = "0x18084D710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float DBGDBJACMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C50", Offset = "0x7E2C50", VA = "0x1807E3C50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E3AA0", Offset = "0x7E2AA0", VA = "0x1807E3AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CHINNIMMFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x73C2A0", Offset = "0x73B2A0", VA = "0x18073C2A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x73C290", Offset = "0x73B290", VA = "0x18073C290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> ACBMDCCKDNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4BE12C0", Offset = "0x4BE02C0", VA = "0x184BE12C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> GLCMDMIGMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6880", Offset = "0x3DD5880", VA = "0x183DD6880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject APMCDMMCIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6768A0", Offset = "0x6758A0", VA = "0x1806768A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x561BD0", Offset = "0x560BD0", VA = "0x180561BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte PJADPOLFFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4BE14E0", Offset = "0x4BE04E0", VA = "0x184BE14E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4BE17A0", Offset = "0x4BE07A0", VA = "0x184BE17A0")]
	public FDPEIDPHNAG(List<KJPJKFJGFKG> AJJCBCBIDFC, List<KJPJKFJGFKG> EFKPEFEEMFB, List<Transform> JJGJHNLEIMO, Material LLCIFIIKFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1530", Offset = "0x4BE0530", VA = "0x184BE1530")]
	private int JFMFJCOGOHB(List<KJPJKFJGFKG> MAGEDIOBFKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1640", Offset = "0x4BE0640", VA = "0x184BE1640")]
	private void PMAGEFJONAI(int GKJFDEMLFIA, bool NFOGJPFOBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4BE13F0", Offset = "0x4BE03F0", VA = "0x184BE13F0")]
	public void GBKCBALCLCM(Vector3 GOLLHPLLPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1320", Offset = "0x4BE0320", VA = "0x184BE1320", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4BE13B0", Offset = "0x4BE03B0", VA = "0x184BE13B0")]
	public void FINMFEJBHDG(Transform DBLPPJNENOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KKHCIFBNEJF : NMEAKKDPDIG, JAJIGDHNMEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DNFKNMNONEI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KKHCIFBNEJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EB910", Offset = "0x5EA910", VA = "0x1805EB910")]
		[DebuggerHidden]
		public DNFKNMNONEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4BE0EA0", Offset = "0x4BDFEA0", VA = "0x184BE0EA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4BE09F0", Offset = "0x4BDF9F0", VA = "0x184BE09F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4BE1020", Offset = "0x4BE0020", VA = "0x184BE1020")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4BE1060", Offset = "0x4BE0060", VA = "0x184BE1060")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4BE10B0", Offset = "0x4BE00B0", VA = "0x184BE10B0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4BE0E50", Offset = "0x4BDFE50", VA = "0x184BE0E50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4BE0DB0", Offset = "0x4BDFDB0", VA = "0x184BE0DB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4BE0DB0", Offset = "0x4BDFDB0", VA = "0x184BE0DB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KLKPJPNBKAP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public KKHCIFBNEJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5EB910", Offset = "0x5EA910", VA = "0x1805EB910")]
		[DebuggerHidden]
		public KLKPJPNBKAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4BE64F0", Offset = "0x4BE54F0", VA = "0x184BE64F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4BE6150", Offset = "0x4BE5150", VA = "0x184BE6150", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4BE6610", Offset = "0x4BE5610", VA = "0x184BE6610")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4BE6660", Offset = "0x4BE5660", VA = "0x184BE6660")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4BE64A0", Offset = "0x4BE54A0", VA = "0x184BE64A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4BE6400", Offset = "0x4BE5400", VA = "0x184BE6400", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4BE6400", Offset = "0x4BE5400", VA = "0x184BE6400", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private DFPMHFFAGFL ACDDFBBOOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<JANKJBEEDPG> NHLOJJNIELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<ClusterMeshRenderer> OBGGMHPANAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BatchedMeshRenderer PPPCHFCEEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool BMFKLBAMLPN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<PABLPJMAJCM> HHIMBFOAPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int AGMMPGOCFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4BE57D0", Offset = "0x4BE47D0", VA = "0x184BE57D0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform IABLAMADKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4BE5230", Offset = "0x4BE4230", VA = "0x184BE5230", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> ONMCAIKMLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D8550", Offset = "0x5D7550", VA = "0x1805D8550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D84D0", Offset = "0x5D74D0", VA = "0x1805D84D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4BE60C0", Offset = "0x4BE50C0", VA = "0x184BE60C0")]
	public KKHCIFBNEJF(DFPMHFFAGFL JIJMHNDPFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4BE5120", Offset = "0x4BE4120", VA = "0x184BE5120", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4BE5810", Offset = "0x4BE4810", VA = "0x184BE5810")]
	public void IONNJMGFDPB(JANKJBEEDPG DBGDLOALBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4BE58E0", Offset = "0x4BE48E0", VA = "0x184BE58E0")]
	public void JPAMCOIJOBL(JANKJBEEDPG DBGDLOALBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4BE5280", Offset = "0x4BE4280", VA = "0x184BE5280", Slot = "4")]
	public void GNOHBPNCEAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4BE5090", Offset = "0x4BE4090", VA = "0x184BE5090")]
	public void ADBHOPCDBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4BE5A90", Offset = "0x4BE4A90", VA = "0x184BE5A90")]
	private void OHOFHCJGIOH(JANKJBEEDPG DBGDLOALBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4BE5BE0", Offset = "0x4BE4BE0", VA = "0x184BE5BE0")]
	public void PBGFHDKNGJP(bool EMOACMHLHGE, bool OOGPGELDONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4BE5950", Offset = "0x4BE4950", VA = "0x184BE5950")]
	protected void MOMOEMAGMPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4BE51C0", Offset = "0x4BE41C0", VA = "0x184BE51C0")]
	[IteratorStateMachine(typeof(DNFKNMNONEI))]
	public IEnumerable<Renderer> GJEBCJMEMAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4BE5150", Offset = "0x4BE4150", VA = "0x184BE5150")]
	[IteratorStateMachine(typeof(KLKPJPNBKAP))]
	public IEnumerable<Renderer> FJADLHCONHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class GCNGLCHOABH : JANKJBEEDPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private IPFPEDNIODL NIBMGBIOBJF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1C80", Offset = "0x4BE0C80", VA = "0x184BE1C80")]
	private NativeList<JIJEBGFCFPK> HFMOIDCJNOP()
	{
		return default(NativeList<JIJEBGFCFPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4BDFA50", Offset = "0x4BDEA50", VA = "0x184BDFA50")]
	public GCNGLCHOABH(KKHCIFBNEJF FFGCFPCOLFD, IPFPEDNIODL JIJMHNDPFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1D50", Offset = "0x4BE0D50", VA = "0x184BE1D50", Slot = "13")]
	public override int JFMFJCOGOHB(GMFMCAOCJOB FJMMOCNCCBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1A60", Offset = "0x4BE0A60", VA = "0x184BE1A60", Slot = "14")]
	public override int BDEHGAJBGCO(GMFMCAOCJOB FJMMOCNCCBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1F70", Offset = "0x4BE0F70", VA = "0x184BE1F70", Slot = "15")]
	public override void LEDBKMAFOMD(GMFMCAOCJOB FJMMOCNCCBH, HEEPHPELEBO LEHANDPMPPM, int EPNNCKJAFLP = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MCBKKOBEEDE : global::OINIFKJKGPO<MCBKKOBEEDE>, ONPIFBCILPJ, IEquatable<MCBKKOBEEDE>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int MPBCIHFGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5BBD80", Offset = "0x5BAD80", VA = "0x1805BBD80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5BBDA0", Offset = "0x5BADA0", VA = "0x1805BBDA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JJMKFDIMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6BDD40", Offset = "0x6BCD40", VA = "0x1806BDD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1B28B40", Offset = "0x1B27B40", VA = "0x181B28B40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DB06A0", Offset = "0x3DAF6A0", VA = "0x183DB06A0", Slot = "8")]
	public bool Equals(MCBKKOBEEDE GKBKHIIEFAH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4BE7E20", Offset = "0x4BE6E20", VA = "0x184BE7E20")]
	public static bool AIKMOHENPEH(MCBKKOBEEDE FJNPOOOECPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum NDKGIDGMIKH
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DFPMHFFAGFL
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform JJLBACLEIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NDKGIDGMIKH PAIAENPOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NJLHPJJNMBH : global::OINIFKJKGPO<NJLHPJJNMBH>, ONPIFBCILPJ, IEquatable<NJLHPJJNMBH>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int MPBCIHFGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5BBD80", Offset = "0x5BAD80", VA = "0x1805BBD80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5BBDA0", Offset = "0x5BADA0", VA = "0x1805BBDA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int JJMKFDIMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6BDD40", Offset = "0x6BCD40", VA = "0x1806BDD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1B28B40", Offset = "0x1B27B40", VA = "0x181B28B40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3DB06A0", Offset = "0x3DAF6A0", VA = "0x183DB06A0", Slot = "8")]
	public bool Equals(NJLHPJJNMBH GKBKHIIEFAH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4BE7EA0", Offset = "0x4BE6EA0", VA = "0x184BE7EA0")]
	public static bool AIKMOHENPEH(NJLHPJJNMBH FJNPOOOECPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NJNJCAMHFEN
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform JJLBACLEIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float BIHENIEOFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 FBNIGGNGHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	HJJAPKBOODA DNOPDDPACOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MLDBBNIDEKG PKDMBMEMPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LFMGCBIEOMF : NJNJCAMHFEN
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	FBJLLDPAKON CAPFDGPLLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EIIBLFAFCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IPFPEDNIODL : NJNJCAMHFEN
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool IBNDEMMHKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool COBODMJJOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float NJEDACBNPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int HANCIIEOBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool NAAAFEENOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<JIJEBGFCFPK> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CHGADNDLAEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEKIOKIPFJG(NJLHPJJNMBH DBGDLOALBPN, DNPIEFKPOLP IGHLGHODIDD);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEKIOKIPFJG(MCBKKOBEEDE FFGCFPCOLFD, DNPIEFKPOLP IGHLGHODIDD);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FIKOJNOBAKP(MCBKKOBEEDE FFGCFPCOLFD);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FIKOJNOBAKP(NJLHPJJNMBH DBGDLOALBPN);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FJFKIMGDDAI(MCBKKOBEEDE FFGCFPCOLFD, HOGIOMDECBL DMBEFJIHONB);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MPBAFEGHIHO(MCBKKOBEEDE FFGCFPCOLFD, Vector3 PIKKPPHIPOC, Vector3 DJKHGLCLMKE, Vector3 NJOIELNHJOA, float CCPOLABDPMJ, float ABLIMNDKJMC, IReadOnlyList<Camera> KIACIHDHCPB, GKNCGEAOFKL PEKCNIKCJKL);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MPBAFEGHIHO(NBCDHEIDBOE JCBPKNJFMMA, Vector3 PIKKPPHIPOC, Vector3 DJKHGLCLMKE, Vector3 NJOIELNHJOA, float CCPOLABDPMJ, float ABLIMNDKJMC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MKJLIPOLKKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MCBKKOBEEDE GEPNEHNOOIE(DFPMHFFAGFL JIJMHNDPFCA);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHIHBNNDLEL(MCBKKOBEEDE FFGCFPCOLFD);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPDAAJCAFBN(MCBKKOBEEDE FFGCFPCOLFD);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NJLHPJJNMBH PHHCBOBEBMF(MCBKKOBEEDE FFGCFPCOLFD, LFMGCBIEOMF JIJMHNDPFCA);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NJLHPJJNMBH FJDDHCKNIKD(MCBKKOBEEDE FFGCFPCOLFD, IPFPEDNIODL JIJMHNDPFCA);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PMHPKPEKDFA(NJLHPJJNMBH DBGDLOALBPN);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IAKMGDOIGCH(NJLHPJJNMBH DBGDLOALBPN);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NBCDHEIDBOE JMEJCCEMLEN(PPBJAFOFDCF JIJMHNDPFCA);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HCNEOPOGDOP(NBCDHEIDBOE JCBPKNJFMMA);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LMHIOJNDCFB(NBCDHEIDBOE JCBPKNJFMMA);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HEHFIMBCOJI PMODMFEICNM(Transform NGPLIOECNKM, IEnumerable<NJLHPJJNMBH> NHLOJJNIELN, int DNDBBNEHKJE);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> PNKGBHAGELE(MCBKKOBEEDE FFGCFPCOLFD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NBCDHEIDBOE : global::OINIFKJKGPO<NBCDHEIDBOE>, ONPIFBCILPJ, IEquatable<NBCDHEIDBOE>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MPBCIHFGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5BBD80", Offset = "0x5BAD80", VA = "0x1805BBD80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5BBDA0", Offset = "0x5BADA0", VA = "0x1805BBDA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int JJMKFDIMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6BDD40", Offset = "0x6BCD40", VA = "0x1806BDD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1B28B40", Offset = "0x1B27B40", VA = "0x181B28B40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3DB06A0", Offset = "0x3DAF6A0", VA = "0x183DB06A0", Slot = "8")]
	public bool Equals(NBCDHEIDBOE GKBKHIIEFAH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4BE7E60", Offset = "0x4BE6E60", VA = "0x184BE7E60")]
	public static bool AIKMOHENPEH(NBCDHEIDBOE FJNPOOOECPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PPBJAFOFDCF
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int IDMNLJKCFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform FILPHEJNLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JHHAOICDHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MCBKKOBEEDE GetBone(int CPDLKGDIAIE);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int CPDLKGDIAIE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class ABFAHMAFPDD : JANKJBEEDPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public LFMGCBIEOMF DMKBLGIMOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int[] PMCJELCKHFA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override CEHABHFAEKI HPKIDHLMPPK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4BDE880", Offset = "0x4BDD880", VA = "0x184BDE880", Slot = "12")]
		get
		{
			return default(CEHABHFAEKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 HACCKDPPGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4BDF370", Offset = "0x4BDE370", VA = "0x184BDF370")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4BDFA50", Offset = "0x4BDEA50", VA = "0x184BDFA50")]
	public ABFAHMAFPDD(KKHCIFBNEJF FFGCFPCOLFD, LFMGCBIEOMF JIJMHNDPFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4BDF550", Offset = "0x4BDE550", VA = "0x184BDF550", Slot = "11")]
	public override bool PMEOKPIGKIH(Transform FFGCFPCOLFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4BDEC20", Offset = "0x4BDDC20", VA = "0x184BDEC20", Slot = "13")]
	public override int JFMFJCOGOHB(GMFMCAOCJOB FJMMOCNCCBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE5A0", Offset = "0x4BDD5A0", VA = "0x184BDE5A0", Slot = "14")]
	public override int BDEHGAJBGCO(GMFMCAOCJOB FJMMOCNCCBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE640", Offset = "0x4BDD640", VA = "0x184BDE640")]
	private int BMPLAAMKMPA(GMFMCAOCJOB FJMMOCNCCBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4BDECC0", Offset = "0x4BDDCC0", VA = "0x184BDECC0", Slot = "15")]
	public override void LEDBKMAFOMD(GMFMCAOCJOB FJMMOCNCCBH, HEEPHPELEBO LEHANDPMPPM, int EPNNCKJAFLP = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HMIPIAJLBPL
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNAMEBFHCPL(HOGIOMDECBL DMBEFJIHONB, Renderer ALFJGJIMIDK, int JCNNLPOLIEI);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPDMHHCOHEA(Renderer ALFJGJIMIDK, GKNCGEAOFKL PEKCNIKCJKL, Vector3 PIKKPPHIPOC, Vector3 DJKHGLCLMKE, Vector3 NJOIELNHJOA, float CCPOLABDPMJ, float ABLIMNDKJMC, float HIOENAHADNM = -1f, [Optional] Color? NJHACKAPJOO, [Optional] IReadOnlyList<Camera> BMIADKKIEBB);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMGEFLCPCNK(Renderer ALFJGJIMIDK, int JCNNLPOLIEI);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MAHCILIGCON();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BJLLIONBFNL(int HJOOCAGMOJG, DNPIEFKPOLP DMBEFJIHONB, Renderer ALFJGJIMIDK, int JCNNLPOLIEI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PMIACOPHHGD : CHGADNDLAEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly HMIPIAJLBPL LOGIONAOBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly NMLJINKIENI JLNGPFEKKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MeshRenderer BODKOLAIGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private MGCCKKHHPIN JGEJDHODICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MeshRenderer JEMJCMFKDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private MGCCKKHHPIN HKDGBOLAPNM;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x555BE0", Offset = "0x554BE0", VA = "0x180555BE0")]
	public PMIACOPHHGD(HMIPIAJLBPL BKNKBCIBHGO, NMLJINKIENI JLNGPFEKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8330", Offset = "0x4BE7330", VA = "0x184BE8330", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4BE7EE0", Offset = "0x4BE6EE0", VA = "0x184BE7EE0", Slot = "4")]
	public void BEKIOKIPFJG(NJLHPJJNMBH DBGDLOALBPN, DNPIEFKPOLP IGHLGHODIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8160", Offset = "0x4BE7160", VA = "0x184BE8160", Slot = "5")]
	public void BEKIOKIPFJG(MCBKKOBEEDE FFGCFPCOLFD, DNPIEFKPOLP IGHLGHODIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4BE86D0", Offset = "0x4BE76D0", VA = "0x184BE86D0", Slot = "6")]
	public void FIKOJNOBAKP(MCBKKOBEEDE FFGCFPCOLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8480", Offset = "0x4BE7480", VA = "0x184BE8480", Slot = "7")]
	public void FIKOJNOBAKP(NJLHPJJNMBH DBGDLOALBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8870", Offset = "0x4BE7870", VA = "0x184BE8870", Slot = "8")]
	public void FJFKIMGDDAI(MCBKKOBEEDE FFGCFPCOLFD, HOGIOMDECBL DMBEFJIHONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8DE0", Offset = "0x4BE7DE0", VA = "0x184BE8DE0", Slot = "9")]
	public void MPBAFEGHIHO(MCBKKOBEEDE FFGCFPCOLFD, Vector3 PIKKPPHIPOC, Vector3 DJKHGLCLMKE, Vector3 NJOIELNHJOA, float CCPOLABDPMJ, float ABLIMNDKJMC, IReadOnlyList<Camera> KIACIHDHCPB, GKNCGEAOFKL PEKCNIKCJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8A10", Offset = "0x4BE7A10", VA = "0x184BE8A10", Slot = "10")]
	public void MPBAFEGHIHO(NBCDHEIDBOE JCBPKNJFMMA, Vector3 PIKKPPHIPOC, Vector3 DJKHGLCLMKE, Vector3 NJOIELNHJOA, float CCPOLABDPMJ, float ABLIMNDKJMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class JANKJBEEDPG : OOELDOIPJKM, PABLPJMAJCM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected Bounds PDDHINPENOG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public KKHCIFBNEJF APMCDMMCIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551490", VA = "0x180552490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds MOGOMPMIDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xB8FF70", Offset = "0xB8EF70", VA = "0x180B8FF70", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual CEHABHFAEKI HPKIDHLMPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4BE3EB0", Offset = "0x4BE2EB0", VA = "0x184BE3EB0", Slot = "12")]
		get
		{
			return default(CEHABHFAEKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4BE3E40", Offset = "0x4BE2E40", VA = "0x184BE3E40", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x555AF0", Offset = "0x554AF0", VA = "0x180555AF0", Slot = "11")]
	public virtual bool PMEOKPIGKIH(Transform FFGCFPCOLFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int JFMFJCOGOHB(GMFMCAOCJOB FJMMOCNCCBH);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int BDEHGAJBGCO(GMFMCAOCJOB FJMMOCNCCBH);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void LEDBKMAFOMD(GMFMCAOCJOB FJMMOCNCCBH, HEEPHPELEBO LEHANDPMPPM, int EPNNCKJAFLP = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	protected JANKJBEEDPG()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4BE9110", Offset = "0x4BE8110", VA = "0x184BE9110")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum FBJLLDPAKON
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class DCCJCKFODOP
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EBIDPEFBOFI : IEnumerable<CHIDKPEJMNC>, IEnumerable, IEnumerator<CHIDKPEJMNC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private CHIDKPEJMNC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private CHIDKPEJMNC System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5EB910", Offset = "0x5EA910", VA = "0x1805EB910")]
		[DebuggerHidden]
		public EBIDPEFBOFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4BE1100", Offset = "0x4BE0100", VA = "0x184BE1100", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4BE1270", Offset = "0x4BE0270", VA = "0x184BE1270", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4BE11E0", Offset = "0x4BE01E0", VA = "0x184BE11E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CHIDKPEJMNC> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4BE11E0", Offset = "0x4BE01E0", VA = "0x184BE11E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int MALHBCDHMLN = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static CHIDKPEJMNC[][] CBKCIBMPILG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static HECMHNJFHKO EIBDHFDIBPG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static ShapeRendererConfig FAPOOAGCJMN;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader EFFKNOFLBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4BDFEA0", Offset = "0x4BDEEA0", VA = "0x184BDFEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer NFNPCFGAHID
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4BDFAA0", Offset = "0x4BDEAA0", VA = "0x184BDFAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4BE08A0", Offset = "0x4BDF8A0", VA = "0x184BE08A0")]
	public static Mesh PFNIAMMOLBM(FBJLLDPAKON DDFDBAFJANE, int FJMMOCNCCBH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4BE0960", Offset = "0x4BDF960", VA = "0x184BE0960")]
	public static int PIPJLBDLAJK(FBJLLDPAKON DDFDBAFJANE, int FJMMOCNCCBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4BDFD30", Offset = "0x4BDED30", VA = "0x184BDFD30")]
	public static HECMHNJFHKO DKCICJALFME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4BE0680", Offset = "0x4BDF680", VA = "0x184BE0680")]
	[IteratorStateMachine(typeof(EBIDPEFBOFI))]
	private static IEnumerable<CHIDKPEJMNC> MDCIFNIFBDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4BE0340", Offset = "0x4BDF340", VA = "0x184BE0340")]
	public static CHIDKPEJMNC JEIIFFEEJCD(FBJLLDPAKON DDFDBAFJANE, int FJMMOCNCCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4BDFE80", Offset = "0x4BDEE80", VA = "0x184BDFE80")]
	public static bool FAFGPKDPMEH(this FBJLLDPAKON DDFDBAFJANE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4BE06E0", Offset = "0x4BDF6E0", VA = "0x184BE06E0")]
	public static void NHCPNMKOGIG(FBJLLDPAKON DDFDBAFJANE, float3 NOGHPDEIIJI, out OBBOONDINNF FAKJHODGBOC, out float3 FHJHJJJPLKL, out float BNPEIILNHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4BDFF20", Offset = "0x4BDEF20", VA = "0x184BDFF20")]
	public static void HHDOOHACNJI(Vector3 NOGHPDEIIJI, FBJLLDPAKON DDFDBAFJANE, out Vector3 FHJHJJJPLKL, out float BNPEIILNHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4BDFF10", Offset = "0x4BDEF10", VA = "0x184BDFF10")]
	[OMDJHDHMGFL(MFFCDMKLBEG.ExitingPlayMode, 0)]
	private static void GOHLIDDBIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4BDFB10", Offset = "0x4BDEB10", VA = "0x184BDFB10")]
	[OMDJHDHMGFL(MFFCDMKLBEG.ExitingPlayMode, 0)]
	private static void COGNHHDEKIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BBMHEHMJLJB
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool EIJAIOLCAMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material KONOJPFNBJC();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material OICFPHKMBHP();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material MKIMADICMAG();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OMMOGCBCILJ(HJJAPKBOODA LJIAGIABFIH);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int AKPCEEMBHAK(MLDBBNIDEKG HHBJJKAMFHF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void APOBAHDLPNO(GameObject OMILIKJDDEJ);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MMPPLPLMONB(GameObject OMILIKJDDEJ, bool FLFGEIJBOMF);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface NMLJINKIENI
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	KKHCIFBNEJF PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	JANKJBEEDPG PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	GFNJBLEAIAB PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class MAIBMEEIFFO : MKJLIPOLKKP, IDisposable, NMLJINKIENI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::EIIKLAMBHDF<MCBKKOBEEDE, KKHCIFBNEJF> PBHFIGBOFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::EIIKLAMBHDF<NJLHPJJNMBH, JANKJBEEDPG> NHLOJJNIELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly global::EIIKLAMBHDF<NBCDHEIDBOE, GFNJBLEAIAB> GILEEECBNDP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static BBMHEHMJLJB NBKGMPBAGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4BE7240", Offset = "0x4BE6240", VA = "0x184BE7240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4BE6C90", Offset = "0x4BE5C90", VA = "0x184BE6C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KKHCIFBNEJF PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4BE7490", Offset = "0x4BE6490", VA = "0x184BE7490", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public JANKJBEEDPG PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4BE73D0", Offset = "0x4BE63D0", VA = "0x184BE73D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public GFNJBLEAIAB PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4BE7430", Offset = "0x4BE6430", VA = "0x184BE7430", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4BE79B0", Offset = "0x4BE69B0", VA = "0x184BE79B0")]
	public MAIBMEEIFFO(BBMHEHMJLJB BKNKBCIBHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4BE6CE0", Offset = "0x4BE5CE0", VA = "0x184BE6CE0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4BE6EA0", Offset = "0x4BE5EA0", VA = "0x184BE6EA0", Slot = "4")]
	public MCBKKOBEEDE GEPNEHNOOIE(DFPMHFFAGFL JIJMHNDPFCA)
	{
		return default(MCBKKOBEEDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4BE6D50", Offset = "0x4BE5D50", VA = "0x184BE6D50", Slot = "5")]
	public void EHIHBNNDLEL(MCBKKOBEEDE FFGCFPCOLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4BE7160", Offset = "0x4BE6160", VA = "0x184BE7160", Slot = "6")]
	public void JPDAAJCAFBN(MCBKKOBEEDE FFGCFPCOLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4BE78F0", Offset = "0x4BE68F0", VA = "0x184BE78F0", Slot = "15")]
	public IEnumerable<Renderer> PNKGBHAGELE(MCBKKOBEEDE FFGCFPCOLFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4BE7280", Offset = "0x4BE6280", VA = "0x184BE7280", Slot = "7")]
	public NJLHPJJNMBH PHHCBOBEBMF(MCBKKOBEEDE FFGCFPCOLFD, LFMGCBIEOMF JIJMHNDPFCA)
	{
		return default(NJLHPJJNMBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4BE6DB0", Offset = "0x4BE5DB0", VA = "0x184BE6DB0", Slot = "8")]
	public NJLHPJJNMBH FJDDHCKNIKD(MCBKKOBEEDE FFGCFPCOLFD, IPFPEDNIODL JIJMHNDPFCA)
	{
		return default(NJLHPJJNMBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4BE6FE0", Offset = "0x4BE5FE0", VA = "0x184BE6FE0", Slot = "10")]
	public void IAKMGDOIGCH(NJLHPJJNMBH DBGDLOALBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4BE7370", Offset = "0x4BE6370", VA = "0x184BE7370", Slot = "9")]
	public void PMHPKPEKDFA(NJLHPJJNMBH DBGDLOALBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4BE7050", Offset = "0x4BE6050", VA = "0x184BE7050", Slot = "11")]
	public NBCDHEIDBOE JMEJCCEMLEN(PPBJAFOFDCF JIJMHNDPFCA)
	{
		return default(NBCDHEIDBOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4BE71D0", Offset = "0x4BE61D0", VA = "0x184BE71D0", Slot = "13")]
	public void LMHIOJNDCFB(NBCDHEIDBOE JCBPKNJFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4BE6F80", Offset = "0x4BE5F80", VA = "0x184BE6F80", Slot = "12")]
	public void HCNEOPOGDOP(NBCDHEIDBOE JCBPKNJFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4BE74F0", Offset = "0x4BE64F0", VA = "0x184BE74F0", Slot = "14")]
	public HEHFIMBCOJI PMODMFEICNM(Transform NGPLIOECNKM, IEnumerable<NJLHPJJNMBH> NHLOJJNIELN, int DNDBBNEHKJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GFNJBLEAIAB : NMEAKKDPDIG
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class HHFCKHOJOAB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public GFNJBLEAIAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5EB910", Offset = "0x5EA910", VA = "0x1805EB910")]
		[DebuggerHidden]
		public HHFCKHOJOAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4BE3BC0", Offset = "0x4BE2BC0", VA = "0x184BE3BC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4BE38E0", Offset = "0x4BE28E0", VA = "0x184BE38E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4BE3C60", Offset = "0x4BE2C60", VA = "0x184BE3C60")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4BE3B70", Offset = "0x4BE2B70", VA = "0x184BE3B70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4BE3AD0", Offset = "0x4BE2AD0", VA = "0x184BE3AD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4BE3AD0", Offset = "0x4BE2AD0", VA = "0x184BE3AD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly PPBJAFOFDCF BKDBPGIBELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly NMLJINKIENI JLNGPFEKKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FDPEIDPHNAG CCKJNAOCEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<KJPJKFJGFKG> NFJLHAAECAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<KJPJKFJGFKG> JJCFFAIKOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GameObject FLIKAGKCFFG;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4BE3530", Offset = "0x4BE2530", VA = "0x184BE3530")]
	public static GFNJBLEAIAB OHMBBNDLLOE(PPBJAFOFDCF JIJMHNDPFCA, NMLJINKIENI JLNGPFEKKJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4BE3610", Offset = "0x4BE2610", VA = "0x184BE3610")]
	private GFNJBLEAIAB(PPBJAFOFDCF JIJMHNDPFCA, NMLJINKIENI JLNGPFEKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4BE30E0", Offset = "0x4BE20E0", VA = "0x184BE30E0")]
	public void GPGHDCEFFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4BE2670", Offset = "0x4BE1670", VA = "0x184BE2670")]
	[IteratorStateMachine(typeof(HHFCKHOJOAB))]
	public IEnumerable<Renderer> GJEBCJMEMAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4BE26E0", Offset = "0x4BE16E0", VA = "0x184BE26E0", Slot = "4")]
	public void GNOHBPNCEAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4BE3500", Offset = "0x4BE2500", VA = "0x184BE3500")]
	private void LAFKNIDOKFF(Vector3 GOLLHPLLPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4BE24A0", Offset = "0x4BE14A0", VA = "0x184BE24A0")]
	public void ADBHOPCDBIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KJPJKFJGFKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct FCCOOGDDHCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public HEEPHPELEBO KLHPKDLBEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform OEGKAHIHOBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int KODKEKAKGGJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class HGADAPCFCCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public KJPJKFJGFKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public GMFMCAOCJOB lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<FCCOOGDDHCK> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public HGADAPCFCCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class GLALAHOKDNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public HEHFIMBCOJI combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public HGADAPCFCCO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public GLALAHOKDNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4BE36A0", Offset = "0x4BE26A0", VA = "0x184BE36A0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4BE3710", Offset = "0x4BE2710", VA = "0x184BE3710")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4BE3750", Offset = "0x4BE2750", VA = "0x184BE3750")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int[] CKKEEJJKKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private LECOGMKDAFL FILAGPMMJEO;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static Matrix4x4 BGNIHGOELJI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh FLOCMKDBCLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551490", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int DKNAPJEHCKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5BBD70", Offset = "0x5BAD70", VA = "0x1805BBD70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5BBD90", Offset = "0x5BAD90", VA = "0x1805BBD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4BE4040", Offset = "0x4BE3040", VA = "0x184BE4040")]
	public void CIJCGPILDPM(List<Transform> LCIPNBKODML, Matrix4x4[] LMLMHHIMAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4BE4640", Offset = "0x4BE3640", VA = "0x184BE4640")]
	public static List<KJPJKFJGFKG> JHOEBDGEJAE(List<KKHCIFBNEJF> NOGIAGLIBJI, GMFMCAOCJOB FJMMOCNCCBH, Bounds IMMOIOCNOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4BE42C0", Offset = "0x4BE32C0", VA = "0x184BE42C0")]
	private JobHandle GFEKBINHDNJ(HEHFIMBCOJI DPLIMDEEHIG, int IOLIAJJECFM, int IOLKGOCEIDO, GMFMCAOCJOB FJMMOCNCCBH, List<FCCOOGDDHCK> GJCHIDLOBJJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4BE3F40", Offset = "0x4BE2F40", VA = "0x184BE3F40")]
	private void BEPODBDOPFH(List<FCCOOGDDHCK> GJCHIDLOBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4BE4CE0", Offset = "0x4BE3CE0", VA = "0x184BE4CE0")]
	private KJPJKFJGFKG(List<FCCOOGDDHCK> GJCHIDLOBJJ, int IOLIAJJECFM, int IOLKGOCEIDO, GMFMCAOCJOB FJMMOCNCCBH, Bounds IMMOIOCNOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4BE4240", Offset = "0x4BE3240", VA = "0x184BE4240", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private MaterialPropertyBlock ANBHHNHFMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private KJPJKFJGFKG ACEMLDCDLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<Transform> JJGJHNLEIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private RenderTexture JHHKIFLNANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeBuffer OFGEIGBNFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ComputeShader AOOEOCPGPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Matrix4x4[] IDEMEACCBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int DHELIJEOOJE;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer NHNNHEMHLDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x595030", Offset = "0x594030", VA = "0x180595030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int IDMNLJKCFOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4BE9CB0", Offset = "0x4BE8CB0", VA = "0x184BE9CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4BE9490", Offset = "0x4BE8490", VA = "0x184BE9490")]
		public static List<SkinnedShapeRenderer> Create(GameObject FFGCFPCOLFD, List<KJPJKFJGFKG> MAGEDIOBFKO, List<Transform> JJGJHNLEIMO, Material LLCIFIIKFDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4BE96A0", Offset = "0x4BE86A0", VA = "0x184BE96A0")]
		public void Init(KJPJKFJGFKG ACEMLDCDLCF, List<Transform> JJGJHNLEIMO, Material LLCIFIIKFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4BE9C20", Offset = "0x4BE8C20", VA = "0x184BE9C20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4BE9B90", Offset = "0x4BE8B90", VA = "0x184BE9B90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4BE9B50", Offset = "0x4BE8B50", VA = "0x184BE9B50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4BE9AC0", Offset = "0x4BE8AC0", VA = "0x184BE9AC0")]
		private void NAAICBBFOJP(ScriptableRenderContext OLNEIJPLPKF, Camera[] EHILDGMNOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4BE9140", Offset = "0x4BE8140", VA = "0x184BE9140")]
		private void CIJCGPILDPM(CommandBuffer FHNMLCKMKHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LCEEBCMBKCD
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static byte[] FOBLDOOIPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int MKBJJHBJLOC;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int IFDBKDIOMPI;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static BigInteger GDKMPNMIOJK;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public LCEEBCMBKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4BE66A0", Offset = "0x4BE56A0", VA = "0x184BE66A0")]
	private static string AFJLFGLOHPO(byte[] FMMAACMCILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4BE67A0", Offset = "0x4BE57A0", VA = "0x184BE67A0")]
	public static string CAJPNALAKAJ(byte[] JNPIAJHKCKB, bool GKIDOBEBBAE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
