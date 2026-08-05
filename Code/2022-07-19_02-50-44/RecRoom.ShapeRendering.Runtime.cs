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
public enum KEMCAAFDPAA
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
public static class EOKJOMOLGLD
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<KEMCAAFDPAA> GHKNGMOJMDF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x50CAB30", Offset = "0x50C9B30", VA = "0x1850CAB30")]
	static EOKJOMOLGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x50CAB30", Offset = "0x50C9B30", VA = "0x1850CAB30")]
	[GJDGJMALEID]
	private static void BGKBBGPIDLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x50CAAB0", Offset = "0x50C9AB0", VA = "0x1850CAAB0")]
	public static bool ANCANHNBMOL(this KEMCAAFDPAA EPGCJGJAJPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BDMDEFIEEJG
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
	WORN_WOOD = 29,
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
public enum DFCIELFCMEH
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
public enum BKAOIDAFMDO
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
public enum NOEEDEDMFMA
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
public class DGABAFMNHAH : OBGNDBPLBFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private const byte JLICNAOBFKB = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private byte FOOPLKCACAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<SkinnedShapeRenderer>[] PLBENNDLHLD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OIFPMDJALMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x58CCD0", Offset = "0x58BCD0", VA = "0x18058CCD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60DA10", Offset = "0x60CA10", VA = "0x18060DA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BPENOCFDANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x58CCC0", Offset = "0x58BCC0", VA = "0x18058CCC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E6EB0", Offset = "0x6E5EB0", VA = "0x1806E6EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float LEEGGNFLEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x112A8E0", Offset = "0x11298E0", VA = "0x18112A8E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x112A5D0", Offset = "0x11295D0", VA = "0x18112A5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CELBOCEOABG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xED1610", Offset = "0xED0610", VA = "0x180ED1610", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xED15A0", Offset = "0xED05A0", VA = "0x180ED15A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> NJAIPGGPEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x50CA720", Offset = "0x50C9720", VA = "0x1850CA720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> LGEGPAMEBNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4238DB0", Offset = "0x4237DB0", VA = "0x184238DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject CEOKDDJOCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A30", Offset = "0x5B3A30", VA = "0x1805B4A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C4580", Offset = "0x6C3580", VA = "0x1806C4580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte NKNCFOHMHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x50CA460", Offset = "0x50C9460", VA = "0x1850CA460", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x50CA780", Offset = "0x50C9780", VA = "0x1850CA780")]
	public DGABAFMNHAH(List<CKIGDHBMGBE> DEDFCPPGIDF, List<CKIGDHBMGBE> MBMPCHGDDAH, List<Transform> OBJNBNNPCLI, Material LLPDGMLPHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x50CA4B0", Offset = "0x50C94B0", VA = "0x1850CA4B0")]
	private int HELDKOFHCJG(List<CKIGDHBMGBE> KFPCDODHPJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x50CA5C0", Offset = "0x50C95C0", VA = "0x1850CA5C0")]
	private void NHBJDNOOENE(int PGJFBLJMIMO, bool LLNMBMGHFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x50CA200", Offset = "0x50C9200", VA = "0x1850CA200")]
	public void AIDJCHMELLB(Vector3 ACBFBODHLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50CA330", Offset = "0x50C9330", VA = "0x1850CA330", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x50CA2F0", Offset = "0x50C92F0", VA = "0x1850CA2F0")]
	public void DOKFCLKKJNH(Transform LJEKCENKLML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HJPHNENBIDJ : HCFBEKINFHN, BIECANNHJDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HBGIIOOHHEE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HJPHNENBIDJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69D3E0", Offset = "0x69C3E0", VA = "0x18069D3E0")]
		[DebuggerHidden]
		public HBGIIOOHHEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x50CB6F0", Offset = "0x50CA6F0", VA = "0x1850CB6F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x50CB240", Offset = "0x50CA240", VA = "0x1850CB240", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x50CB870", Offset = "0x50CA870", VA = "0x1850CB870")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x50CB8B0", Offset = "0x50CA8B0", VA = "0x1850CB8B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x50CB900", Offset = "0x50CA900", VA = "0x1850CB900")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x50CB6A0", Offset = "0x50CA6A0", VA = "0x1850CB6A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x50CB600", Offset = "0x50CA600", VA = "0x1850CB600", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x50CB600", Offset = "0x50CA600", VA = "0x1850CB600", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LABNDHGPCGH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HJPHNENBIDJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x69D3E0", Offset = "0x69C3E0", VA = "0x18069D3E0")]
		[DebuggerHidden]
		public LABNDHGPCGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x50D2DA0", Offset = "0x50D1DA0", VA = "0x1850D2DA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x50D2A00", Offset = "0x50D1A00", VA = "0x1850D2A00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x50D2EC0", Offset = "0x50D1EC0", VA = "0x1850D2EC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x50D2F10", Offset = "0x50D1F10", VA = "0x1850D2F10")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x50D2D50", Offset = "0x50D1D50", VA = "0x1850D2D50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x50D2CB0", Offset = "0x50D1CB0", VA = "0x1850D2CB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x50D2CB0", Offset = "0x50D1CB0", VA = "0x1850D2CB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private EAGNOJAPHMM LECJIPBHNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<NHNGAEEMBMA> CMBLBGGNMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<ClusterMeshRenderer> MAFOIJIHLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BatchedMeshRenderer PNPHICAMDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool PMBLCBDGGGA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<NAGGIEMENAF> PPFPJMOCPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BNOKMLLPDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x50CDAB0", Offset = "0x50CCAB0", VA = "0x1850CDAB0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform BJHKNBNEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x50CCCC0", Offset = "0x50CBCC0", VA = "0x1850CCCC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> PHMLMNFLPLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x58D010", Offset = "0x58C010", VA = "0x18058D010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x58D020", Offset = "0x58C020", VA = "0x18058D020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x50CDD30", Offset = "0x50CCD30", VA = "0x1850CDD30")]
	public HJPHNENBIDJ(EAGNOJAPHMM GPELMIMHNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x50CCD10", Offset = "0x50CBD10", VA = "0x1850CCD10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50CDC40", Offset = "0x50CCC40", VA = "0x1850CDC40")]
	public void NJFAMEHLCGO(NHNGAEEMBMA PNNAAABKCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x50CDA40", Offset = "0x50CCA40", VA = "0x1850CDA40")]
	public void INAIIIEHGLD(NHNGAEEMBMA PNNAAABKCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x50CD3E0", Offset = "0x50CC3E0", VA = "0x1850CD3E0", Slot = "4")]
	public void GMJGLJLMPAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x50CCD40", Offset = "0x50CBD40", VA = "0x1850CCD40")]
	public void FCLLPBMAPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x50CDAF0", Offset = "0x50CCAF0", VA = "0x1850CDAF0")]
	private void KONGNCLHGOC(NHNGAEEMBMA PNNAAABKCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x50CCDF0", Offset = "0x50CBDF0", VA = "0x1850CCDF0")]
	public void FDHGEDBICFP(bool PNFMHMICNMD, bool EPDFHMNAPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x50CCB80", Offset = "0x50CBB80", VA = "0x1850CCB80")]
	protected void AHIKHGIKPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x50CD9D0", Offset = "0x50CC9D0", VA = "0x1850CD9D0")]
	[IteratorStateMachine(typeof(HBGIIOOHHEE))]
	public IEnumerable<Renderer> IBCPBJIBLMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x50CD370", Offset = "0x50CC370", VA = "0x1850CD370")]
	[IteratorStateMachine(typeof(LABNDHGPCGH))]
	public IEnumerable<Renderer> FHLPDDAMJEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class KAOIDHJOLNJ : NHNGAEEMBMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private JADBLEPGIBC CIAGLGAAPNB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x50D26B0", Offset = "0x50D16B0", VA = "0x1850D26B0")]
	private NativeList<JKKGJDCBGAA> MDKJDLDMIOJ()
	{
		return default(NativeList<JKKGJDCBGAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x50D04C0", Offset = "0x50CF4C0", VA = "0x1850D04C0")]
	public KAOIDHJOLNJ(HJPHNENBIDJ EIIIPMJKAPH, JADBLEPGIBC GPELMIMHNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x50D2490", Offset = "0x50D1490", VA = "0x1850D2490", Slot = "13")]
	public override int HELDKOFHCJG(BENKDIMFFKF FLHLJFAEENP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x50D2270", Offset = "0x50D1270", VA = "0x1850D2270", Slot = "14")]
	public override int GPMFJLGCHEH(BENKDIMFFKF FLHLJFAEENP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x50D1D40", Offset = "0x50D0D40", VA = "0x1850D1D40", Slot = "15")]
	public override void GJEDJMDFOBN(BENKDIMFFKF FLHLJFAEENP, NFEOGOPBIPA FDGGMGFCKOF, int DILDOENLFPF = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PEFPOMPOOGD : global::BDLKMFLDHDF<PEFPOMPOOGD>, GFCLNMBKJPO, IEquatable<PEFPOMPOOGD>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NBBAFHCPDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84B200", Offset = "0x84A200", VA = "0x18084B200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C57C0", Offset = "0x8C47C0", VA = "0x1808C57C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OPMBFIMNJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84B1E0", Offset = "0x84A1E0", VA = "0x18084B1E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x89EFD0", Offset = "0x89DFD0", VA = "0x18089EFD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x42296E0", Offset = "0x42286E0", VA = "0x1842296E0", Slot = "8")]
	public bool Equals(PEFPOMPOOGD INIEAOGGCLC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x50D3090", Offset = "0x50D2090", VA = "0x1850D3090")]
	public static bool HBGGEKNOIDB(PEFPOMPOOGD NJKEAEPJNIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum KHGOBHIKFCN
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
public interface EAGNOJAPHMM
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform OGEHMCJOIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	KHGOBHIKFCN KKJDOBDFDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NHCIHBABGMF : global::BDLKMFLDHDF<NHCIHBABGMF>, GFCLNMBKJPO, IEquatable<NHCIHBABGMF>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int NBBAFHCPDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x84B200", Offset = "0x84A200", VA = "0x18084B200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8C57C0", Offset = "0x8C47C0", VA = "0x1808C57C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int OPMBFIMNJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84B1E0", Offset = "0x84A1E0", VA = "0x18084B1E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x89EFD0", Offset = "0x89DFD0", VA = "0x18089EFD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x42296E0", Offset = "0x42286E0", VA = "0x1842296E0", Slot = "8")]
	public bool Equals(NHCIHBABGMF INIEAOGGCLC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x50D2F50", Offset = "0x50D1F50", VA = "0x1850D2F50")]
	public static bool HBGGEKNOIDB(NHCIHBABGMF NJKEAEPJNIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MOFEPCFGCLH
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform OGEHMCJOIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float ALGJEFMBOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 IIEOIAABDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	KEMCAAFDPAA LCJKGEDAPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	BDMDEFIEEJG KCIGBCPJHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BDGEAHDNNPJ : MOFEPCFGCLH
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	LCGKELPMOLA EPACODBPIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool BNEMBENKBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JADBLEPGIBC : MOFEPCFGCLH
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool EINGEJGKHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FALPPANJNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float FNKBKKALMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int AKPHMLAFEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool GFKFEALDPGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<JKKGJDCBGAA> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DKNIIBPKHFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKCLLHBHNGH(NHCIHBABGMF PNNAAABKCOB, BKAOIDAFMDO JHFOECGCDMG);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKCLLHBHNGH(PEFPOMPOOGD EIIIPMJKAPH, BKAOIDAFMDO JHFOECGCDMG);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPABMNJKHDP(PEFPOMPOOGD EIIIPMJKAPH);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPABMNJKHDP(NHCIHBABGMF PNNAAABKCOB);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DABLOOMEAGD(PEFPOMPOOGD EIIIPMJKAPH, NOEEDEDMFMA GOKHKCCNGMD);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BBENEDBDBAC(PEFPOMPOOGD EIIIPMJKAPH, Vector3 BDNCBHNNOEN, Vector3 HEEJNABDNBJ, Vector3 GBLCCDPKIMM, float KGJIFKEODOA, float PAIAFNKJHAM, IReadOnlyList<Camera> BDGJGBDHEBC, DFCIELFCMEH EFIKFAKHJFF);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BBENEDBDBAC(KILHHIDMGBC IEGPOGEPECP, Vector3 BDNCBHNNOEN, Vector3 HEEJNABDNBJ, Vector3 GBLCCDPKIMM, float KGJIFKEODOA, float PAIAFNKJHAM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CHKBFOCIIGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEFPOMPOOGD GKHNONJJLIP(EAGNOJAPHMM GPELMIMHNGI);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COOBGJMECHJ(PEFPOMPOOGD EIIIPMJKAPH);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEALPLGFDBP(PEFPOMPOOGD EIIIPMJKAPH);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NHCIHBABGMF DLBPGDDKLHM(PEFPOMPOOGD EIIIPMJKAPH, BDGEAHDNNPJ GPELMIMHNGI);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NHCIHBABGMF HMNNOHLIIGB(PEFPOMPOOGD EIIIPMJKAPH, JADBLEPGIBC GPELMIMHNGI);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ENOLMNPBDHC(NHCIHBABGMF PNNAAABKCOB);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ANFAGHANCHN(NHCIHBABGMF PNNAAABKCOB);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KILHHIDMGBC AHIOACFCICL(CFPBNMPEEPC GPELMIMHNGI);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EJPHCCCJAEA(KILHHIDMGBC IEGPOGEPECP);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DDPBFLPINKD(KILHHIDMGBC IEGPOGEPECP);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DPOMDMFCDCE FAIEMIACPGG(Transform MPBFKPONKMA, IEnumerable<NHCIHBABGMF> CMBLBGGNMNL, int KFKEGJNOEEI);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> HGPCIIGBMOL(PEFPOMPOOGD EIIIPMJKAPH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KILHHIDMGBC : global::BDLKMFLDHDF<KILHHIDMGBC>, GFCLNMBKJPO, IEquatable<KILHHIDMGBC>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int NBBAFHCPDPA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x84B200", Offset = "0x84A200", VA = "0x18084B200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8C57C0", Offset = "0x8C47C0", VA = "0x1808C57C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int OPMBFIMNJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84B1E0", Offset = "0x84A1E0", VA = "0x18084B1E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x89EFD0", Offset = "0x89DFD0", VA = "0x18089EFD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x42296E0", Offset = "0x42286E0", VA = "0x1842296E0", Slot = "8")]
	public bool Equals(KILHHIDMGBC INIEAOGGCLC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x50D2780", Offset = "0x50D1780", VA = "0x1850D2780")]
	public static bool HBGGEKNOIDB(KILHHIDMGBC NJKEAEPJNIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CFPBNMPEEPC
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int DGMLKMGLBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform DLGJOPIBGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool INCHOAAJCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PEFPOMPOOGD GetBone(int JGBFEGOGMCH);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int JGBFEGOGMCH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class IFJMFJMIIFL : NHNGAEEMBMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public BDGEAHDNNPJ ICHODHAONCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int[] DHPMOJIDNBL;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override IMNKKMKDAOC LKICCFINEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x50CFF40", Offset = "0x50CEF40", VA = "0x1850CFF40", Slot = "12")]
		get
		{
			return default(IMNKKMKDAOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 MBBOAKLEBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x50D02E0", Offset = "0x50CF2E0", VA = "0x1850D02E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x50D04C0", Offset = "0x50CF4C0", VA = "0x1850D04C0")]
	public IFJMFJMIIFL(HJPHNENBIDJ EIIIPMJKAPH, BDGEAHDNNPJ GPELMIMHNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x50CEFD0", Offset = "0x50CDFD0", VA = "0x1850CEFD0", Slot = "11")]
	public override bool CFPCLBNLOGP(Transform EIIIPMJKAPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x50CFC20", Offset = "0x50CEC20", VA = "0x1850CFC20", Slot = "13")]
	public override int HELDKOFHCJG(BENKDIMFFKF FLHLJFAEENP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x50CFB80", Offset = "0x50CEB80", VA = "0x1850CFB80", Slot = "14")]
	public override int GPMFJLGCHEH(BENKDIMFFKF FLHLJFAEENP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x50CFCC0", Offset = "0x50CECC0", VA = "0x1850CFCC0")]
	private int HMEAKNGIDHC(BENKDIMFFKF FLHLJFAEENP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x50CF4D0", Offset = "0x50CE4D0", VA = "0x1850CF4D0", Slot = "15")]
	public override void GJEDJMDFOBN(BENKDIMFFKF FLHLJFAEENP, NFEOGOPBIPA FDGGMGFCKOF, int DILDOENLFPF = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GCAFGFPCCJP
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAAFBAJAAIE(NOEEDEDMFMA GOKHKCCNGMD, Renderer EJDINJIJFOD, int BGKLFJAHDBF);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNPLGICIPGE(Renderer EJDINJIJFOD, DFCIELFCMEH EFIKFAKHJFF, Vector3 BDNCBHNNOEN, Vector3 HEEJNABDNBJ, Vector3 GBLCCDPKIMM, float KGJIFKEODOA, float PAIAFNKJHAM, float CIBIANAOOCB = -1f, [Optional] Color? DKGKEIAPEFP, [Optional] IReadOnlyList<Camera> FDNBCOJDMEA);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONFGJILKMEJ(Renderer EJDINJIJFOD, int BGKLFJAHDBF);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OAIJKNOCGJD();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPNOHEMHNPB(int MFHLKNMCCLE, BKAOIDAFMDO GOKHKCCNGMD, Renderer EJDINJIJFOD, int BGKLFJAHDBF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HHDIIGEIBOK : DKNIIBPKHFH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly GCAFGFPCCJP EJPAKNNOFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly KJBAFJBIPDN LFGLBAMIINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MeshRenderer BMKBFCNAAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private IOJEACHMILK HDAMHBMJNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MeshRenderer FGLDHODIPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private IOJEACHMILK FCEFJPJBAKN;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x59F990", Offset = "0x59E990", VA = "0x18059F990")]
	public HHDIIGEIBOK(GCAFGFPCCJP KJLJEJGPBIN, KJBAFJBIPDN LFGLBAMIINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x50CCA30", Offset = "0x50CBA30", VA = "0x1850CCA30", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x50CC5E0", Offset = "0x50CB5E0", VA = "0x1850CC5E0", Slot = "4")]
	public void DKCLLHBHNGH(NHCIHBABGMF PNNAAABKCOB, BKAOIDAFMDO JHFOECGCDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x50CC860", Offset = "0x50CB860", VA = "0x1850CC860", Slot = "5")]
	public void DKCLLHBHNGH(PEFPOMPOOGD EIIIPMJKAPH, BKAOIDAFMDO JHFOECGCDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x50CC2A0", Offset = "0x50CB2A0", VA = "0x1850CC2A0", Slot = "6")]
	public void BPABMNJKHDP(PEFPOMPOOGD EIIIPMJKAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x50CC050", Offset = "0x50CB050", VA = "0x1850CC050", Slot = "7")]
	public void BPABMNJKHDP(NHCIHBABGMF PNNAAABKCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x50CC440", Offset = "0x50CB440", VA = "0x1850CC440", Slot = "8")]
	public void DABLOOMEAGD(PEFPOMPOOGD EIIIPMJKAPH, NOEEDEDMFMA GOKHKCCNGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x50CBD20", Offset = "0x50CAD20", VA = "0x1850CBD20", Slot = "9")]
	public void BBENEDBDBAC(PEFPOMPOOGD EIIIPMJKAPH, Vector3 BDNCBHNNOEN, Vector3 HEEJNABDNBJ, Vector3 GBLCCDPKIMM, float KGJIFKEODOA, float PAIAFNKJHAM, IReadOnlyList<Camera> BDGJGBDHEBC, DFCIELFCMEH EFIKFAKHJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x50CB950", Offset = "0x50CA950", VA = "0x1850CB950", Slot = "10")]
	public void BBENEDBDBAC(KILHHIDMGBC IEGPOGEPECP, Vector3 BDNCBHNNOEN, Vector3 HEEJNABDNBJ, Vector3 GBLCCDPKIMM, float KGJIFKEODOA, float PAIAFNKJHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class NHNGAEEMBMA : IBDGAHOKAMA, NAGGIEMENAF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected Bounds CICBDLFBPLP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public HJPHNENBIDJ CEOKDDJOCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x58C490", Offset = "0x58B490", VA = "0x18058C490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds HEPIOBHJNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x10EF7A0", Offset = "0x10EE7A0", VA = "0x1810EF7A0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual IMNKKMKDAOC LKICCFINEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x50D3000", Offset = "0x50D2000", VA = "0x1850D3000", Slot = "12")]
		get
		{
			return default(IMNKKMKDAOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x50D2F90", Offset = "0x50D1F90", VA = "0x1850D2F90", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x58CEC0", Offset = "0x58BEC0", VA = "0x18058CEC0", Slot = "11")]
	public virtual bool CFPCLBNLOGP(Transform EIIIPMJKAPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int HELDKOFHCJG(BENKDIMFFKF FLHLJFAEENP);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int GPMFJLGCHEH(BENKDIMFFKF FLHLJFAEENP);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void GJEDJMDFOBN(BENKDIMFFKF FLHLJFAEENP, NFEOGOPBIPA FDGGMGFCKOF, int DILDOENLFPF = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	protected NHNGAEEMBMA()
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
		[Cpp2IlInjected.Address(RVA = "0x50D41E0", Offset = "0x50D31E0", VA = "0x1850D41E0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum LCGKELPMOLA
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
public static class PIPAALCBNHM
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PGMDLEKALMJ : IEnumerable<NECNPCBBDHJ>, IEnumerable, IEnumerator<NECNPCBBDHJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private NECNPCBBDHJ <>2__current;

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
		private NECNPCBBDHJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69D3E0", Offset = "0x69C3E0", VA = "0x18069D3E0")]
		[DebuggerHidden]
		public PGMDLEKALMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x50D30D0", Offset = "0x50D20D0", VA = "0x1850D30D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x50D3240", Offset = "0x50D2240", VA = "0x1850D3240", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x50D31B0", Offset = "0x50D21B0", VA = "0x1850D31B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NECNPCBBDHJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x50D31B0", Offset = "0x50D21B0", VA = "0x1850D31B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int GMDOONKGNOM = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static NECNPCBBDHJ[][] EPKJBIBFAJI;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static CLAHMMGCHEK HNKELNFOCEH;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static ShapeRendererConfig OCEGGJAOOFB;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader MMBFIMOKEGH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x50D3530", Offset = "0x50D2530", VA = "0x1850D3530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer HKBCEGJGNOL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x50D32B0", Offset = "0x50D22B0", VA = "0x1850D32B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x50D3320", Offset = "0x50D2320", VA = "0x1850D3320")]
	public static Mesh AKMNIPMALDB(LCGKELPMOLA NIHOHCBFKMN, int FLHLJFAEENP = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x50D4150", Offset = "0x50D3150", VA = "0x1850D4150")]
	public static int NPHGHNICGAK(LCGKELPMOLA NIHOHCBFKMN, int FLHLJFAEENP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x50D33E0", Offset = "0x50D23E0", VA = "0x1850D33E0")]
	public static CLAHMMGCHEK EEEJAENCBFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x50D40F0", Offset = "0x50D30F0", VA = "0x1850D40F0")]
	[IteratorStateMachine(typeof(PGMDLEKALMJ))]
	private static IEnumerable<NECNPCBBDHJ> MLBDKNIPAKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x50D35A0", Offset = "0x50D25A0", VA = "0x1850D35A0")]
	public static NECNPCBBDHJ IGMHOHEIBNH(LCGKELPMOLA NIHOHCBFKMN, int FLHLJFAEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x50D3290", Offset = "0x50D2290", VA = "0x1850D3290")]
	public static bool ABMGKINBLID(this LCGKELPMOLA NIHOHCBFKMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x50D3F30", Offset = "0x50D2F30", VA = "0x1850D3F30")]
	public static void LIGLMOLDEGA(LCGKELPMOLA NIHOHCBFKMN, float3 OIIFOCPNIEM, out HILFMOEGKGK IHFCLGGLDIF, out float3 ONBLDPJALIG, out float MAELMNJCDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x50D3B10", Offset = "0x50D2B10", VA = "0x1850D3B10")]
	public static void JPELBDLKKPP(Vector3 OIIFOCPNIEM, LCGKELPMOLA NIHOHCBFKMN, out Vector3 ONBLDPJALIG, out float MAELMNJCDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x50D38E0", Offset = "0x50D28E0", VA = "0x1850D38E0")]
	[KMMCCHGHBPI(MCCKPBHNINP.ExitingPlayMode, 0)]
	private static void JENFCADFIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x50D38F0", Offset = "0x50D28F0", VA = "0x1850D38F0")]
	[KMMCCHGHBPI(MCCKPBHNINP.ExitingPlayMode, 0)]
	private static void JHKGLLDIOFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LKPLDIKABIL
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool CLCHHABOIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material JFJPAABDFNK();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material LMMLGNAHMFE();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material LGPMACBJKCG();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int ELHDNNFPPBE(KEMCAAFDPAA OIDJHAGPCLN);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NFNMEFABNBP(BDMDEFIEEJG GAJDLLBNBPC);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PGJOOJLMOHO(GameObject OOJKHPLJJMJ);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FPFODCCCJLA(GameObject OOJKHPLJJMJ, bool HNHHFBELFKN);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface KJBAFJBIPDN
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	HJPHNENBIDJ HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	NHNGAEEMBMA HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	JAPBPBEIJPA HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class HOLBAGKOKBB : CHKBFOCIIGO, IDisposable, KJBAFJBIPDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::NJOJIBKOMFJ<PEFPOMPOOGD, HJPHNENBIDJ> JAEEDPPEIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::NJOJIBKOMFJ<NHCIHBABGMF, NHNGAEEMBMA> CMBLBGGNMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly global::NJOJIBKOMFJ<KILHHIDMGBC, JAPBPBEIJPA> IEMNJGMJJKK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static LKPLDIKABIL PJKCLCCFEHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x50CEA60", Offset = "0x50CDA60", VA = "0x1850CEA60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x50CEAA0", Offset = "0x50CDAA0", VA = "0x1850CEAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public HJPHNENBIDJ HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x50CE150", Offset = "0x50CD150", VA = "0x1850CE150", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public NHNGAEEMBMA HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x50CE0F0", Offset = "0x50CD0F0", VA = "0x1850CE0F0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public JAPBPBEIJPA HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x50CE090", Offset = "0x50CD090", VA = "0x1850CE090", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x50CEB60", Offset = "0x50CDB60", VA = "0x1850CEB60")]
	public HOLBAGKOKBB(LKPLDIKABIL KJLJEJGPBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x50CE2A0", Offset = "0x50CD2A0", VA = "0x1850CE2A0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x50CE7D0", Offset = "0x50CD7D0", VA = "0x1850CE7D0", Slot = "4")]
	public PEFPOMPOOGD GKHNONJJLIP(EAGNOJAPHMM GPELMIMHNGI)
	{
		return default(PEFPOMPOOGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x50CDFC0", Offset = "0x50CCFC0", VA = "0x1850CDFC0", Slot = "5")]
	public void COOBGJMECHJ(PEFPOMPOOGD EIIIPMJKAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x50CEAF0", Offset = "0x50CDAF0", VA = "0x1850CEAF0", Slot = "6")]
	public void PEALPLGFDBP(PEFPOMPOOGD EIIIPMJKAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x50CE8B0", Offset = "0x50CD8B0", VA = "0x1850CE8B0", Slot = "15")]
	public IEnumerable<Renderer> HGPCIIGBMOL(PEFPOMPOOGD EIIIPMJKAPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x50CE1B0", Offset = "0x50CD1B0", VA = "0x1850CE1B0", Slot = "7")]
	public NHCIHBABGMF DLBPGDDKLHM(PEFPOMPOOGD EIIIPMJKAPH, BDGEAHDNNPJ GPELMIMHNGI)
	{
		return default(NHCIHBABGMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x50CE970", Offset = "0x50CD970", VA = "0x1850CE970", Slot = "8")]
	public NHCIHBABGMF HMNNOHLIIGB(PEFPOMPOOGD EIIIPMJKAPH, JADBLEPGIBC GPELMIMHNGI)
	{
		return default(NHCIHBABGMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x50CDF50", Offset = "0x50CCF50", VA = "0x1850CDF50", Slot = "10")]
	public void ANFAGHANCHN(NHCIHBABGMF PNNAAABKCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x50CE370", Offset = "0x50CD370", VA = "0x1850CE370", Slot = "9")]
	public void ENOLMNPBDHC(NHCIHBABGMF PNNAAABKCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x50CDDC0", Offset = "0x50CCDC0", VA = "0x1850CDDC0", Slot = "11")]
	public KILHHIDMGBC AHIOACFCICL(CFPBNMPEEPC GPELMIMHNGI)
	{
		return default(KILHHIDMGBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x50CE020", Offset = "0x50CD020", VA = "0x1850CE020", Slot = "13")]
	public void DDPBFLPINKD(KILHHIDMGBC IEGPOGEPECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x50CE310", Offset = "0x50CD310", VA = "0x1850CE310", Slot = "12")]
	public void EJPHCCCJAEA(KILHHIDMGBC IEGPOGEPECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x50CE3D0", Offset = "0x50CD3D0", VA = "0x1850CE3D0", Slot = "14")]
	public DPOMDMFCDCE FAIEMIACPGG(Transform MPBFKPONKMA, IEnumerable<NHCIHBABGMF> CMBLBGGNMNL, int KFKEGJNOEEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JAPBPBEIJPA : HCFBEKINFHN
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class JGGKGOKJPCI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JAPBPBEIJPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x69D3E0", Offset = "0x69C3E0", VA = "0x18069D3E0")]
		[DebuggerHidden]
		public JGGKGOKJPCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x50D1C60", Offset = "0x50D0C60", VA = "0x1850D1C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x50D1980", Offset = "0x50D0980", VA = "0x1850D1980", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x50D1D00", Offset = "0x50D0D00", VA = "0x1850D1D00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x50D1C10", Offset = "0x50D0C10", VA = "0x1850D1C10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x50D1B70", Offset = "0x50D0B70", VA = "0x1850D1B70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x50D1B70", Offset = "0x50D0B70", VA = "0x1850D1B70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly CFPBNMPEEPC JEEHLHEMIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly KJBAFJBIPDN LFGLBAMIINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private DGABAFMNHAH NDHNGJKBBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<CKIGDHBMGBE> GAHLEBBNLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<CKIGDHBMGBE> KDGJIKELJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GameObject NBLMPGDNGFJ;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x50D11D0", Offset = "0x50D01D0", VA = "0x1850D11D0")]
	public static JAPBPBEIJPA NNKBDOEHHMN(CFPBNMPEEPC GPELMIMHNGI, KJBAFJBIPDN LFGLBAMIINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x50D1880", Offset = "0x50D0880", VA = "0x1850D1880")]
	private JAPBPBEIJPA(CFPBNMPEEPC GPELMIMHNGI, KJBAFJBIPDN LFGLBAMIINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x50D1330", Offset = "0x50D0330", VA = "0x1850D1330")]
	public void PKDHKFNAFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x50D1130", Offset = "0x50D0130", VA = "0x1850D1130")]
	[IteratorStateMachine(typeof(JGGKGOKJPCI))]
	public IEnumerable<Renderer> IBCPBJIBLMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x50D06E0", Offset = "0x50CF6E0", VA = "0x1850D06E0", Slot = "4")]
	public void GMJGLJLMPAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x50D11A0", Offset = "0x50D01A0", VA = "0x1850D11A0")]
	private void NFBCPNLMHNJ(Vector3 ACBFBODHLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x50D0510", Offset = "0x50CF510", VA = "0x1850D0510")]
	public void FCLLPBMAPJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CKIGDHBMGBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct AMONGLMLABD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public NFEOGOPBIPA GAFEMKCNOHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform DOBOEALJJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int HNMFDPJDGOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class JJNBOLFGCGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CKIGDHBMGBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public BENKDIMFFKF lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<AMONGLMLABD> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public JJNBOLFGCGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KNPPKOMOFIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public DPOMDMFCDCE combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public JJNBOLFGCGI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public KNPPKOMOFIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x50D27C0", Offset = "0x50D17C0", VA = "0x1850D27C0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x50D2830", Offset = "0x50D1830", VA = "0x1850D2830")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x50D2870", Offset = "0x50D1870", VA = "0x1850D2870")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int[] MDLIENBDIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private JCFNIECFLCO PKJPBJNAPFO;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static Matrix4x4 KNFEPGJEFPI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh NMJCKGDOCLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x58C490", Offset = "0x58B490", VA = "0x18058C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int ANPEPGPDNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x618670", Offset = "0x617670", VA = "0x180618670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6DE610", Offset = "0x6DD610", VA = "0x1806DE610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x50C9B10", Offset = "0x50C8B10", VA = "0x1850C9B10")]
	public void JPKIOCDBLDE(List<Transform> FKOIGIADEGB, Matrix4x4[] APLAOFMDLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x50C91A0", Offset = "0x50C81A0", VA = "0x1850C91A0")]
	public static List<CKIGDHBMGBE> GJHMDGALCIL(List<HJPHNENBIDJ> NKAHFJOADHC, BENKDIMFFKF FLHLJFAEENP, Bounds KIAFMKMBMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x50C9700", Offset = "0x50C8700", VA = "0x1850C9700")]
	private JobHandle JKDDPAEDDFH(DPOMDMFCDCE FFDMNNILFIB, int JDKPFPJHDEF, int KONJKMFAHHE, BENKDIMFFKF FLHLJFAEENP, List<AMONGLMLABD> BIKIIKIOHEC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x50C9020", Offset = "0x50C8020", VA = "0x1850C9020")]
	private void DENGOMLELHC(List<AMONGLMLABD> BIKIIKIOHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x50C9E50", Offset = "0x50C8E50", VA = "0x1850C9E50")]
	private CKIGDHBMGBE(List<AMONGLMLABD> BIKIIKIOHEC, int JDKPFPJHDEF, int KONJKMFAHHE, BENKDIMFFKF FLHLJFAEENP, Bounds KIAFMKMBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x50C9120", Offset = "0x50C8120", VA = "0x1850C9120", Slot = "4")]
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
		private MaterialPropertyBlock JJFAHAHAMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private CKIGDHBMGBE OJDMKGILEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<Transform> OBJNBNNPCLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private RenderTexture JEFOBELKNNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeBuffer GNDNDEFIHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ComputeShader LLLPIECNNDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Matrix4x4[] GFDNHBPGELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int DIAMBFOPOHO;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer EPOLHHFCPAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x58C4A0", Offset = "0x58B4A0", VA = "0x18058C4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int DGMLKMGLBFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x50D4D80", Offset = "0x50D3D80", VA = "0x1850D4D80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x50D4210", Offset = "0x50D3210", VA = "0x1850D4210")]
		public static List<SkinnedShapeRenderer> Create(GameObject EIIIPMJKAPH, List<CKIGDHBMGBE> KFPCDODHPJI, List<Transform> OBJNBNNPCLI, Material LLPDGMLPHEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x50D4420", Offset = "0x50D3420", VA = "0x1850D4420")]
		public void Init(CKIGDHBMGBE OJDMKGILEJO, List<Transform> OBJNBNNPCLI, Material LLPDGMLPHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x50D4CF0", Offset = "0x50D3CF0", VA = "0x1850D4CF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x50D4C60", Offset = "0x50D3C60", VA = "0x1850D4C60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x50D4C20", Offset = "0x50D3C20", VA = "0x1850D4C20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x50D4B90", Offset = "0x50D3B90", VA = "0x1850D4B90")]
		private void LKFDABEPLHM(ScriptableRenderContext HHKNMJJDOAL, Camera[] ADPGLGODMBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x50D4840", Offset = "0x50D3840", VA = "0x1850D4840")]
		private void JPKIOCDBLDE(CommandBuffer LDFPDDDHPCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xDE3E30", Offset = "0xDE2E30", VA = "0x180DE3E30")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FIEGLPKEOLP
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static byte[] KGMNFGCKGCC;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int PACKDELFILO;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int EAEPHMJCION;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static BigInteger BEBMPCAFPLJ;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public FIEGLPKEOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x50CAC50", Offset = "0x50C9C50", VA = "0x1850CAC50")]
	private static string EHOHANMBAEF(byte[] PEAHMNEGGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x50CAD50", Offset = "0x50C9D50", VA = "0x1850CAD50")]
	public static string GFDPFHBIGNB(byte[] KCNDJOGONOI, bool LFHPFEDNDMG)
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
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
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
