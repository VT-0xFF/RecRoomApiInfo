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
public enum DBLKKJFLHGJ
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
public static class ODACNHJLFDD
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<DBLKKJFLHGJ> JFPLJIIALPD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x50C0980", Offset = "0x50BF980", VA = "0x1850C0980")]
	static ODACNHJLFDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x50C0980", Offset = "0x50BF980", VA = "0x1850C0980")]
	[JEBLFEFHMIE]
	private static void JMPIMFJAEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x50C0900", Offset = "0x50BF900", VA = "0x1850C0900")]
	public static bool ABIGOEOIFMD(this DBLKKJFLHGJ LHMJPNBBIID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum ICGMCBHHBBK
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
public enum KIJOAEAOHCF
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
public enum KLGFCMEHJKJ
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
public enum MLEKEKDHEFO
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
public class EDBBMFKJGOA : HIOMNALHGCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private const byte HNNBCPJODJB = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private byte ACJHOLPKMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<SkinnedShapeRenderer>[] FJDKADLNJFK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LDGFLPEDANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x58DCD0", Offset = "0x58CCD0", VA = "0x18058DCD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60EA10", Offset = "0x60DA10", VA = "0x18060EA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HAMCJLOIKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x58DCC0", Offset = "0x58CCC0", VA = "0x18058DCC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E7EB0", Offset = "0x6E6EB0", VA = "0x1806E7EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float BCDGBGGICDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x11211D0", Offset = "0x11201D0", VA = "0x1811211D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1120F50", Offset = "0x111FF50", VA = "0x181120F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float FAFOAFCBHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xFE3550", Offset = "0xFE2550", VA = "0x180FE3550", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xFE3560", Offset = "0xFE2560", VA = "0x180FE3560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> FIAAHBIAJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x50BB210", Offset = "0x50BA210", VA = "0x1850BB210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> LOBNPAKPFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x42B6360", Offset = "0x42B5360", VA = "0x1842B6360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject EFDCOHOBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5B5A30", Offset = "0x5B4A30", VA = "0x1805B5A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C5580", Offset = "0x6C4580", VA = "0x1806C5580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte CJCOKBIAALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x50BB5E0", Offset = "0x50BA5E0", VA = "0x1850BB5E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x50BB790", Offset = "0x50BA790", VA = "0x1850BB790")]
	public EDBBMFKJGOA(List<CCKOAAJGNFF> DEHMDOBHNBI, List<CCKOAAJGNFF> GCCNMHACLCJ, List<Transform> DFKBDOPDBJP, Material ECDFJLALJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x50BB4D0", Offset = "0x50BA4D0", VA = "0x1850BB4D0")]
	private int NCGBDNJKJLE(List<CCKOAAJGNFF> EBDCCCPCKEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x50BB630", Offset = "0x50BA630", VA = "0x1850BB630")]
	private void PPMCEFLGBGN(int NBIICDOJAAA, bool MIJGBGDJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x50BB270", Offset = "0x50BA270", VA = "0x1850BB270")]
	public void AEGHIAIIOCM(Vector3 LGAAMBJLKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50BB360", Offset = "0x50BA360", VA = "0x1850BB360", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x50BB490", Offset = "0x50BA490", VA = "0x1850BB490")]
	public void IAALFACLADG(Transform AJHKCMCHGPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FJLGMIDOHGI : GBGHNHEOIEM, DCADADIGNOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GKFGJAEHJCA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public FJLGMIDOHGI <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69E3E0", Offset = "0x69D3E0", VA = "0x18069E3E0")]
		[DebuggerHidden]
		public GKFGJAEHJCA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x50BD1B0", Offset = "0x50BC1B0", VA = "0x1850BD1B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x50BCD00", Offset = "0x50BBD00", VA = "0x1850BCD00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x50BD330", Offset = "0x50BC330", VA = "0x1850BD330")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x50BD370", Offset = "0x50BC370", VA = "0x1850BD370")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x50BD3C0", Offset = "0x50BC3C0", VA = "0x1850BD3C0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x50BD160", Offset = "0x50BC160", VA = "0x1850BD160", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x50BD0C0", Offset = "0x50BC0C0", VA = "0x1850BD0C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x50BD0C0", Offset = "0x50BC0C0", VA = "0x1850BD0C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DDKKNCMNJBE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public FJLGMIDOHGI <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x69E3E0", Offset = "0x69D3E0", VA = "0x18069E3E0")]
		[DebuggerHidden]
		public DDKKNCMNJBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x50BA110", Offset = "0x50B9110", VA = "0x1850BA110", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x50B9D70", Offset = "0x50B8D70", VA = "0x1850B9D70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x50BA230", Offset = "0x50B9230", VA = "0x1850BA230")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x50BA280", Offset = "0x50B9280", VA = "0x1850BA280")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x50BA0C0", Offset = "0x50B90C0", VA = "0x1850BA0C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x50BA020", Offset = "0x50B9020", VA = "0x1850BA020", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x50BA020", Offset = "0x50B9020", VA = "0x1850BA020", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private OGAOLBILBOL DJDKEPIBBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<BNHLGODHLKP> HDADHLECBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<ClusterMeshRenderer> NHDHCJBEAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BatchedMeshRenderer MEPIMMOKPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool IEMAOKLOBAE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<FOFLFNAHCCB> BIMCGFPFCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MFBNEPDHEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x50BBF30", Offset = "0x50BAF30", VA = "0x1850BBF30", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform GLAJJILHLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x50BC560", Offset = "0x50BB560", VA = "0x1850BC560", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> HKIBHCODFMK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x58E010", Offset = "0x58D010", VA = "0x18058E010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x58E020", Offset = "0x58D020", VA = "0x18058E020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x50BCC70", Offset = "0x50BBC70", VA = "0x1850BCC70")]
	public FJLGMIDOHGI(OGAOLBILBOL MPLJOBCIMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x50BBC20", Offset = "0x50BAC20", VA = "0x1850BBC20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50BBAC0", Offset = "0x50BAAC0", VA = "0x1850BBAC0")]
	public void CGEJAMCGIKA(BNHLGODHLKP HGFEBDCCIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x50BBE50", Offset = "0x50BAE50", VA = "0x1850BBE50")]
	public void IDBFDJDECBI(BNHLGODHLKP HGFEBDCCIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x50BBF70", Offset = "0x50BAF70", VA = "0x1850BBF70", Slot = "4")]
	public void KNNKOCNFNPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x50BBDA0", Offset = "0x50BADA0", VA = "0x1850BBDA0")]
	public void HFCDGCMEJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x50BBC50", Offset = "0x50BAC50", VA = "0x1850BBC50")]
	private void HDHFLOGMPEE(BNHLGODHLKP HGFEBDCCIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x50BC6F0", Offset = "0x50BB6F0", VA = "0x1850BC6F0")]
	public void OBEBKBOBCPJ(bool BIBDCJNELLF, bool OOIIMBOPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x50BC5B0", Offset = "0x50BB5B0", VA = "0x1850BC5B0")]
	protected void MKJEELFLMDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x50BBEC0", Offset = "0x50BAEC0", VA = "0x1850BBEC0")]
	[IteratorStateMachine(typeof(GKFGJAEHJCA))]
	public IEnumerable<Renderer> JCHGMDGPNAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x50BBBB0", Offset = "0x50BABB0", VA = "0x1850BBBB0")]
	[IteratorStateMachine(typeof(DDKKNCMNJBE))]
	public IEnumerable<Renderer> DLLPFAIAJDL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class DBKFALBNOID : BNHLGODHLKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private LOIDMEOKDBN IBFCDBOCAFP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x50B92A0", Offset = "0x50B82A0", VA = "0x1850B92A0")]
	private NativeList<KAFOGFJBGOM> ABGFDGHCEMG()
	{
		return default(NativeList<KAFOGFJBGOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x50B9CE0", Offset = "0x50B8CE0", VA = "0x1850B9CE0")]
	public DBKFALBNOID(FJLGMIDOHGI BHOMFIKIJGC, LOIDMEOKDBN MPLJOBCIMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x50B9AC0", Offset = "0x50B8AC0", VA = "0x1850B9AC0", Slot = "13")]
	public override int NCGBDNJKJLE(AKFHINCIBPA ALIDALOFAHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x50B98A0", Offset = "0x50B88A0", VA = "0x1850B98A0", Slot = "14")]
	public override int LPNPJFFMBHG(AKFHINCIBPA ALIDALOFAHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x50B9370", Offset = "0x50B8370", VA = "0x1850B9370", Slot = "15")]
	public override void IFKBEEFINBC(AKFHINCIBPA ALIDALOFAHA, IILPOOCCDCP OKCDBLCAEMA, int CBGDHLJEIJC = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OHOKAFJPPEE : global::GPCILPKKCNI<OHOKAFJPPEE>, JKOGMDEMBMB, IEquatable<OHOKAFJPPEE>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LDLBNOKJCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84C200", Offset = "0x84B200", VA = "0x18084C200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C67C0", Offset = "0x8C57C0", VA = "0x1808C67C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HAAADPKHDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84C1E0", Offset = "0x84B1E0", VA = "0x18084C1E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x89FFD0", Offset = "0x89EFD0", VA = "0x18089FFD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4291000", Offset = "0x4290000", VA = "0x184291000", Slot = "8")]
	public bool Equals(OHOKAFJPPEE GOAJJPLEOBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x50C0AA0", Offset = "0x50BFAA0", VA = "0x1850C0AA0")]
	public static bool EAIJFFIDGAK(OHOKAFJPPEE OCDKENKCLFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum BHDAOFBGLCA
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
public interface OGAOLBILBOL
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform BDOOIJEOIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BHDAOFBGLCA CNLBDBCIBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DCBNMGFMIFI : global::GPCILPKKCNI<DCBNMGFMIFI>, JKOGMDEMBMB, IEquatable<DCBNMGFMIFI>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LDLBNOKJCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x84C200", Offset = "0x84B200", VA = "0x18084C200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8C67C0", Offset = "0x8C57C0", VA = "0x1808C67C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int HAAADPKHDFO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84C1E0", Offset = "0x84B1E0", VA = "0x18084C1E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x89FFD0", Offset = "0x89EFD0", VA = "0x18089FFD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4291000", Offset = "0x4290000", VA = "0x184291000", Slot = "8")]
	public bool Equals(DCBNMGFMIFI GOAJJPLEOBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x50B9D30", Offset = "0x50B8D30", VA = "0x1850B9D30")]
	public static bool EAIJFFIDGAK(DCBNMGFMIFI OCDKENKCLFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FLENIMIBDFK
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform BDOOIJEOIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float DHACHAKPPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 KJNOPNDEGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	DBLKKJFLHGJ CFLDPLKHENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	ICGMCBHHBBK JEKOEBMKCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DJGKJGIFFEL : FLENIMIBDFK
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	KIGAMCOGFND LAFBDIJBBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool NJEKJNOIFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LOIDMEOKDBN : FLENIMIBDFK
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool EMAAAHMHIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool AHICOJBABBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float HGAMLJAKDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int KMMAALOHFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool FKAGKCFMBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<KAFOGFJBGOM> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BDOHLJCOBNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAIIGIFFCIN(DCBNMGFMIFI HGFEBDCCIHA, KLGFCMEHJKJ FGFABPELFHO);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CAIIGIFFCIN(OHOKAFJPPEE BHOMFIKIJGC, KLGFCMEHJKJ FGFABPELFHO);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DHLMJHAFFHI(OHOKAFJPPEE BHOMFIKIJGC);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DHLMJHAFFHI(DCBNMGFMIFI HGFEBDCCIHA);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JJOECJLPHIG(OHOKAFJPPEE BHOMFIKIJGC, MLEKEKDHEFO JFEPPDBLNIJ);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGGKHJKGONB(OHOKAFJPPEE BHOMFIKIJGC, Vector3 PFBOPBBLOGF, Vector3 OLIGOKNLEED, Vector3 IMICHLCLPBG, float FCHCLKDJOAB, float FFPKAIFMECO, IReadOnlyList<Camera> OOBADEMOFBF, KIJOAEAOHCF OLEHPODBENJ);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FGGKHJKGONB(HLAHLODANGI KEDGEGKNBIN, Vector3 PFBOPBBLOGF, Vector3 OLIGOKNLEED, Vector3 IMICHLCLPBG, float FCHCLKDJOAB, float FFPKAIFMECO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ACCJPLMNDBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OHOKAFJPPEE AABNKBJNBCM(OGAOLBILBOL MPLJOBCIMCD);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKIAACHOHME(OHOKAFJPPEE BHOMFIKIJGC);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGOBPHOMADF(OHOKAFJPPEE BHOMFIKIJGC);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DCBNMGFMIFI NCCGIFOEJBC(OHOKAFJPPEE BHOMFIKIJGC, DJGKJGIFFEL MPLJOBCIMCD);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DCBNMGFMIFI OJAFPAKNKBB(OHOKAFJPPEE BHOMFIKIJGC, LOIDMEOKDBN MPLJOBCIMCD);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LALGEGLJOHH(DCBNMGFMIFI HGFEBDCCIHA);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BOMBFBHEHID(DCBNMGFMIFI HGFEBDCCIHA);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HLAHLODANGI ADIEOLICIGH(EAKLLMOMGEB MPLJOBCIMCD);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NIEILCOFDPD(HLAHLODANGI KEDGEGKNBIN);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GOAFEFNONGP(HLAHLODANGI KEDGEGKNBIN);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HMKPBFCADBK CGAFNMHOGFA(Transform OEGFCPLCGDJ, IEnumerable<DCBNMGFMIFI> HDADHLECBEO, int LAHICBCGOBB);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> DFIMADKEOPC(OHOKAFJPPEE BHOMFIKIJGC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct HLAHLODANGI : global::GPCILPKKCNI<HLAHLODANGI>, JKOGMDEMBMB, IEquatable<HLAHLODANGI>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int LDLBNOKJCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x84C200", Offset = "0x84B200", VA = "0x18084C200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8C67C0", Offset = "0x8C57C0", VA = "0x1808C67C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int HAAADPKHDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84C1E0", Offset = "0x84B1E0", VA = "0x18084C1E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x89FFD0", Offset = "0x89EFD0", VA = "0x18089FFD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4291000", Offset = "0x4290000", VA = "0x184291000", Slot = "8")]
	public bool Equals(HLAHLODANGI GOAJJPLEOBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x50BD410", Offset = "0x50BC410", VA = "0x1850BD410")]
	public static bool EAIJFFIDGAK(HLAHLODANGI OCDKENKCLFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EAKLLMOMGEB
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int PIGILHECHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform JNJLACCHBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool AAOBPINDBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OHOKAFJPPEE GetBone(int HGBOCLJCLFN);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int HGBOCLJCLFN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class LPLPOPIKINJ : BNHLGODHLKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public DJGKJGIFFEL BFAKBGFOMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int[] HIKDHFFNBEP;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override MIHKDLJLIKO AAOLLNKPJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x50C0320", Offset = "0x50BF320", VA = "0x1850C0320", Slot = "12")]
		get
		{
			return default(MIHKDLJLIKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 NKJMFMCIGLP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x50BF1D0", Offset = "0x50BE1D0", VA = "0x1850BF1D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x50B9CE0", Offset = "0x50B8CE0", VA = "0x1850B9CE0")]
	public LPLPOPIKINJ(FJLGMIDOHGI BHOMFIKIJGC, DJGKJGIFFEL MPLJOBCIMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x50BFB00", Offset = "0x50BEB00", VA = "0x1850BFB00", Slot = "11")]
	public override bool MNIEJDFGBHE(Transform BHOMFIKIJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x50C0280", Offset = "0x50BF280", VA = "0x1850C0280", Slot = "13")]
	public override int NCGBDNJKJLE(AKFHINCIBPA ALIDALOFAHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x50BFA60", Offset = "0x50BEA60", VA = "0x1850BFA60", Slot = "14")]
	public override int LPNPJFFMBHG(AKFHINCIBPA ALIDALOFAHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x50C0000", Offset = "0x50BF000", VA = "0x1850C0000")]
	private int MOELLCJBCKL(AKFHINCIBPA ALIDALOFAHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x50BF3B0", Offset = "0x50BE3B0", VA = "0x1850BF3B0", Slot = "15")]
	public override void IFKBEEFINBC(AKFHINCIBPA ALIDALOFAHA, IILPOOCCDCP OKCDBLCAEMA, int CBGDHLJEIJC = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DFAKINAAONN
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AILKJCDKHHN(MLEKEKDHEFO JFEPPDBLNIJ, Renderer KFECFJFDJPO, int MHODJIDHDCG);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHOMJEDKNID(Renderer KFECFJFDJPO, KIJOAEAOHCF OLEHPODBENJ, Vector3 PFBOPBBLOGF, Vector3 OLIGOKNLEED, Vector3 IMICHLCLPBG, float FCHCLKDJOAB, float FFPKAIFMECO, float LIFNAKFOFFI = -1f, [Optional] Color? OPIICEOPPKJ, [Optional] IReadOnlyList<Camera> NBKBLNLGOCC);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBMJECDJEKD(Renderer KFECFJFDJPO, int MHODJIDHDCG);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OLMEHMBPENI();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OEMLKFDJGCP(int PEAKLLNMHGL, KLGFCMEHJKJ JFEPPDBLNIJ, Renderer KFECFJFDJPO, int MHODJIDHDCG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CBJGNIEPCDF : BDOHLJCOBNB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly DFAKINAAONN DHKAECINBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CFJADAHMCNH PHDLAPHNJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MeshRenderer LFCCHNJPLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private OFAAKMABAMM BPAGDGEOBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MeshRenderer DNKLODMPEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private OFAAKMABAMM GHFDNHIIMAO;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5A0990", Offset = "0x59F990", VA = "0x1805A0990")]
	public CBJGNIEPCDF(DFAKINAAONN INIOKOEDBOK, CFJADAHMCNH PHDLAPHNJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x50B76D0", Offset = "0x50B66D0", VA = "0x1850B76D0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x50B6E90", Offset = "0x50B5E90", VA = "0x1850B6E90", Slot = "4")]
	public void CAIIGIFFCIN(DCBNMGFMIFI HGFEBDCCIHA, KLGFCMEHJKJ FGFABPELFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x50B7110", Offset = "0x50B6110", VA = "0x1850B7110", Slot = "5")]
	public void CAIIGIFFCIN(OHOKAFJPPEE BHOMFIKIJGC, KLGFCMEHJKJ FGFABPELFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x50B7530", Offset = "0x50B6530", VA = "0x1850B7530", Slot = "6")]
	public void DHLMJHAFFHI(OHOKAFJPPEE BHOMFIKIJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x50B72E0", Offset = "0x50B62E0", VA = "0x1850B72E0", Slot = "7")]
	public void DHLMJHAFFHI(DCBNMGFMIFI HGFEBDCCIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x50B7F20", Offset = "0x50B6F20", VA = "0x1850B7F20", Slot = "8")]
	public void JJOECJLPHIG(OHOKAFJPPEE BHOMFIKIJGC, MLEKEKDHEFO JFEPPDBLNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x50B7820", Offset = "0x50B6820", VA = "0x1850B7820", Slot = "9")]
	public void FGGKHJKGONB(OHOKAFJPPEE BHOMFIKIJGC, Vector3 PFBOPBBLOGF, Vector3 OLIGOKNLEED, Vector3 IMICHLCLPBG, float FCHCLKDJOAB, float FFPKAIFMECO, IReadOnlyList<Camera> OOBADEMOFBF, KIJOAEAOHCF OLEHPODBENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x50B7B50", Offset = "0x50B6B50", VA = "0x1850B7B50", Slot = "10")]
	public void FGGKHJKGONB(HLAHLODANGI KEDGEGKNBIN, Vector3 PFBOPBBLOGF, Vector3 OLIGOKNLEED, Vector3 IMICHLCLPBG, float FCHCLKDJOAB, float FFPKAIFMECO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class BNHLGODHLKP : PODFIHAJEEM, FOFLFNAHCCB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected Bounds KOMEGJEAHOE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public FJLGMIDOHGI EFDCOHOBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x58D490", Offset = "0x58C490", VA = "0x18058D490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds HGBDALCBGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x10D4210", Offset = "0x10D3210", VA = "0x1810D4210", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual MIHKDLJLIKO AAOLLNKPJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x50B6E00", Offset = "0x50B5E00", VA = "0x1850B6E00", Slot = "12")]
		get
		{
			return default(MIHKDLJLIKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x50B6D90", Offset = "0x50B5D90", VA = "0x1850B6D90", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x58DEC0", Offset = "0x58CEC0", VA = "0x18058DEC0", Slot = "11")]
	public virtual bool MNIEJDFGBHE(Transform BHOMFIKIJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int NCGBDNJKJLE(AKFHINCIBPA ALIDALOFAHA);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int LPNPJFFMBHG(AKFHINCIBPA ALIDALOFAHA);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void IFKBEEFINBC(AKFHINCIBPA ALIDALOFAHA, IILPOOCCDCP OKCDBLCAEMA, int CBGDHLJEIJC = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	protected BNHLGODHLKP()
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
		[Cpp2IlInjected.Address(RVA = "0x50C0AE0", Offset = "0x50BFAE0", VA = "0x1850C0AE0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum KIGAMCOGFND
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
public static class DFLJIKGPFNI
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class JBKOCKBGLHI : IEnumerable<NNDLDBACGBN>, IEnumerable, IEnumerator<NNDLDBACGBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private NNDLDBACGBN <>2__current;

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
		private NNDLDBACGBN System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69E3E0", Offset = "0x69D3E0", VA = "0x18069E3E0")]
		[DebuggerHidden]
		public JBKOCKBGLHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x50BDA40", Offset = "0x50BCA40", VA = "0x1850BDA40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x50BDBB0", Offset = "0x50BCBB0", VA = "0x1850BDBB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x50BDB20", Offset = "0x50BCB20", VA = "0x1850BDB20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NNDLDBACGBN> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x50BDB20", Offset = "0x50BCB20", VA = "0x1850BDB20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int BIKEENIGFIO = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static NNDLDBACGBN[][] IECPBOHGHIL;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static DKJEICNIOMM BPBAENEBEJK;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static ShapeRendererConfig BBGCNACIFLK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader JHDHNMNBMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x50BB0B0", Offset = "0x50BA0B0", VA = "0x1850BB0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer NBALCKAPIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x50BAA20", Offset = "0x50B9A20", VA = "0x1850BAA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x50BACB0", Offset = "0x50B9CB0", VA = "0x1850BACB0")]
	public static Mesh HLOHGAAOKDK(KIGAMCOGFND CIGAJDJNKHE, int ALIDALOFAHA = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x50BA9F0", Offset = "0x50B99F0", VA = "0x1850BA9F0")]
	public static int DDODJBAGNAF(KIGAMCOGFND CIGAJDJNKHE, int ALIDALOFAHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x50BA8A0", Offset = "0x50B98A0", VA = "0x1850BA8A0")]
	public static DKJEICNIOMM CPGOEAIFNOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x50BB120", Offset = "0x50BA120", VA = "0x1850BB120")]
	[IteratorStateMachine(typeof(JBKOCKBGLHI))]
	private static IEnumerable<NNDLDBACGBN> LFDKCEBJEOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x50BAD70", Offset = "0x50B9D70", VA = "0x1850BAD70")]
	public static NNDLDBACGBN IALHANHEAEI(KIGAMCOGFND CIGAJDJNKHE, int ALIDALOFAHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x50BAA00", Offset = "0x50B9A00", VA = "0x1850BAA00")]
	public static bool DLGJCLLHFLJ(this KIGAMCOGFND CIGAJDJNKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x50BA2C0", Offset = "0x50B92C0", VA = "0x1850BA2C0")]
	public static void AMGEEPFDDEB(KIGAMCOGFND CIGAJDJNKHE, float3 DJODPGIGANO, out ILIOCAEEDDP OJFHLLILFBE, out float3 PAJMEAEFHBD, out float MBCCOCGHFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x50BA480", Offset = "0x50B9480", VA = "0x1850BA480")]
	public static void BIMNGNFCACE(Vector3 DJODPGIGANO, KIGAMCOGFND CIGAJDJNKHE, out Vector3 PAJMEAEFHBD, out float MBCCOCGHFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x50BB180", Offset = "0x50BA180", VA = "0x1850BB180")]
	[LEDBAOJCIJA(NOJCFKMJDIB.ExitingPlayMode, 0)]
	private static void MEKLPAOKEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x50BAA90", Offset = "0x50B9A90", VA = "0x1850BAA90")]
	[LEDBAOJCIJA(NOJCFKMJDIB.ExitingPlayMode, 0)]
	private static void GNCOEDKNFGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OCGCLJABCJG
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool NDBPDCLEFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material PKONNGFAEBI();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material IIFBBKDFLIG();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material LDLLHOPDEJI();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LGOKDCLMBAF(DBLKKJFLHGJ AFHANAPJEEA);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int GEMGGLGJNJC(ICGMCBHHBBK EPJLDHCKJNF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DNJKEPGOOBP(GameObject NHBCHHMAJOK);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PKOPHGMBMLD(GameObject NHBCHHMAJOK, bool AAOCBHPLGAH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface CFJADAHMCNH
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	FJLGMIDOHGI PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	BNHLGODHLKP PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	BCKDIFDDCHJ PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class KOJOCEAIJAH : ACCJPLMNDBH, IDisposable, CFJADAHMCNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::LJENNEAPDNP<OHOKAFJPPEE, FJLGMIDOHGI> DPBFPGNGLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::LJENNEAPDNP<DCBNMGFMIFI, BNHLGODHLKP> HDADHLECBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly global::LJENNEAPDNP<HLAHLODANGI, BCKDIFDDCHJ> GDIAKGLNAPC;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static OCGCLJABCJG EDPEDHPLKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x50BE760", Offset = "0x50BD760", VA = "0x1850BE760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x50BEA10", Offset = "0x50BDA10", VA = "0x1850BEA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public FJLGMIDOHGI PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x50BE880", Offset = "0x50BD880", VA = "0x1850BE880", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public BNHLGODHLKP PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x50BE8E0", Offset = "0x50BD8E0", VA = "0x1850BE8E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public BCKDIFDDCHJ PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x50BE940", Offset = "0x50BD940", VA = "0x1850BE940", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x50BED60", Offset = "0x50BDD60", VA = "0x1850BED60")]
	public KOJOCEAIJAH(OCGCLJABCJG INIOKOEDBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x50BE7A0", Offset = "0x50BD7A0", VA = "0x1850BE7A0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x50BDFC0", Offset = "0x50BCFC0", VA = "0x1850BDFC0", Slot = "4")]
	public OHOKAFJPPEE AABNKBJNBCM(OGAOLBILBOL MPLJOBCIMCD)
	{
		return default(OHOKAFJPPEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x50BEAC0", Offset = "0x50BDAC0", VA = "0x1850BEAC0", Slot = "5")]
	public void MKIAACHOHME(OHOKAFJPPEE BHOMFIKIJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x50BE9A0", Offset = "0x50BD9A0", VA = "0x1850BE9A0", Slot = "6")]
	public void JGOBPHOMADF(OHOKAFJPPEE BHOMFIKIJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x50BE6A0", Offset = "0x50BD6A0", VA = "0x1850BE6A0", Slot = "15")]
	public IEnumerable<Renderer> DFIMADKEOPC(OHOKAFJPPEE BHOMFIKIJGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x50BEB20", Offset = "0x50BDB20", VA = "0x1850BEB20", Slot = "7")]
	public DCBNMGFMIFI NCCGIFOEJBC(OHOKAFJPPEE BHOMFIKIJGC, DJGKJGIFFEL MPLJOBCIMCD)
	{
		return default(DCBNMGFMIFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x50BEC70", Offset = "0x50BDC70", VA = "0x1850BEC70", Slot = "8")]
	public DCBNMGFMIFI OJAFPAKNKBB(OHOKAFJPPEE BHOMFIKIJGC, LOIDMEOKDBN MPLJOBCIMCD)
	{
		return default(DCBNMGFMIFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x50BE230", Offset = "0x50BD230", VA = "0x1850BE230", Slot = "10")]
	public void BOMBFBHEHID(DCBNMGFMIFI HGFEBDCCIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x50BEA60", Offset = "0x50BDA60", VA = "0x1850BEA60", Slot = "9")]
	public void LALGEGLJOHH(DCBNMGFMIFI HGFEBDCCIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x50BE0A0", Offset = "0x50BD0A0", VA = "0x1850BE0A0", Slot = "11")]
	public HLAHLODANGI ADIEOLICIGH(EAKLLMOMGEB MPLJOBCIMCD)
	{
		return default(HLAHLODANGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x50BE810", Offset = "0x50BD810", VA = "0x1850BE810", Slot = "13")]
	public void GOAFEFNONGP(HLAHLODANGI KEDGEGKNBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x50BEC10", Offset = "0x50BDC10", VA = "0x1850BEC10", Slot = "12")]
	public void NIEILCOFDPD(HLAHLODANGI KEDGEGKNBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x50BE2A0", Offset = "0x50BD2A0", VA = "0x1850BE2A0", Slot = "14")]
	public HMKPBFCADBK CGAFNMHOGFA(Transform OEGFCPLCGDJ, IEnumerable<DCBNMGFMIFI> HDADHLECBEO, int LAHICBCGOBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BCKDIFDDCHJ : GBGHNHEOIEM
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class KBDILKNHMFK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BCKDIFDDCHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x69E3E0", Offset = "0x69D3E0", VA = "0x18069E3E0")]
		[DebuggerHidden]
		public KBDILKNHMFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x50BDEE0", Offset = "0x50BCEE0", VA = "0x1850BDEE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x50BDC00", Offset = "0x50BCC00", VA = "0x1850BDC00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x50BDF80", Offset = "0x50BCF80", VA = "0x1850BDF80")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x50BDE90", Offset = "0x50BCE90", VA = "0x1850BDE90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x50BDDF0", Offset = "0x50BCDF0", VA = "0x1850BDDF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x50BDDF0", Offset = "0x50BCDF0", VA = "0x1850BDDF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly EAKLLMOMGEB CBDIMEOFHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly CFJADAHMCNH PHDLAPHNJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private EDBBMFKJGOA HPNCBLCDEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<CCKOAAJGNFF> JNNEGLNBLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<CCKOAAJGNFF> LBIKONHBMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GameObject LMNFLEEDNDP;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x50B6B30", Offset = "0x50B5B30", VA = "0x1850B6B30")]
	public static BCKDIFDDCHJ NFIDJINOJAF(EAKLLMOMGEB MPLJOBCIMCD, CFJADAHMCNH PHDLAPHNJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x50B6C90", Offset = "0x50B5C90", VA = "0x1850B6C90")]
	private BCKDIFDDCHJ(EAKLLMOMGEB MPLJOBCIMCD, CFJADAHMCNH PHDLAPHNJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x50B5920", Offset = "0x50B4920", VA = "0x1850B5920")]
	public void ALEEKPJPLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x50B6040", Offset = "0x50B5040", VA = "0x1850B6040")]
	[IteratorStateMachine(typeof(KBDILKNHMFK))]
	public IEnumerable<Renderer> JCHGMDGPNAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x50B60E0", Offset = "0x50B50E0", VA = "0x1850B60E0", Slot = "4")]
	public void KNNKOCNFNPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x50B60B0", Offset = "0x50B50B0", VA = "0x1850B60B0")]
	private void KEJHCDNKKEE(Vector3 LGAAMBJLKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x50B5E70", Offset = "0x50B4E70", VA = "0x1850B5E70")]
	public void HFCDGCMEJPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CCKOAAJGNFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct KGCBDMBNBEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public IILPOOCCDCP CJLBGNABJHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform GNKMJMDANEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int OJBHAHOCMGN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KBHCBOIAPIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CCKOAAJGNFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AKFHINCIBPA lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<KGCBDMBNBEO> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public KBHCBOIAPIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class OAHMGJBBCJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public HMKPBFCADBK combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public KBHCBOIAPIN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public OAHMGJBBCJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x50C06C0", Offset = "0x50BF6C0", VA = "0x1850C06C0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x50C0730", Offset = "0x50BF730", VA = "0x1850C0730")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x50C0770", Offset = "0x50BF770", VA = "0x1850C0770")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int[] PGCNMADACDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private DKKFBKGLPKH GOGCKCHKFKD;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static Matrix4x4 AMKNCOJDCMF;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh DNNMMLMCPCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x58D490", Offset = "0x58C490", VA = "0x18058D490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int CFBOHNDNLFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x619670", Offset = "0x618670", VA = "0x180619670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6DF610", Offset = "0x6DE610", VA = "0x1806DF610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x50B8650", Offset = "0x50B7650", VA = "0x1850B8650")]
	public void EIPBDEKOMDO(List<Transform> GPBMPFKPMPO, Matrix4x4[] EMDKOHLAOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x50B8850", Offset = "0x50B7850", VA = "0x1850B8850")]
	public static List<CCKOAAJGNFF> NPKHJENBLIG(List<FJLGMIDOHGI> JCOIFKFNNCC, AKFHINCIBPA ALIDALOFAHA, Bounds FIHIKEAJCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x50B80C0", Offset = "0x50B70C0", VA = "0x1850B80C0")]
	private JobHandle CAHGPNCPOJC(HMKPBFCADBK KAJFKDLLPFI, int EDADINJFDBL, int IMBKMEKELPJ, AKFHINCIBPA ALIDALOFAHA, List<KGCBDMBNBEO> GPLJDGLIGFO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x50B84D0", Offset = "0x50B74D0", VA = "0x1850B84D0")]
	private void CCCEDMKAJKE(List<KGCBDMBNBEO> GPLJDGLIGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x50B8EF0", Offset = "0x50B7EF0", VA = "0x1850B8EF0")]
	private CCKOAAJGNFF(List<KGCBDMBNBEO> GPLJDGLIGFO, int EDADINJFDBL, int IMBKMEKELPJ, AKFHINCIBPA ALIDALOFAHA, Bounds FIHIKEAJCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x50B85D0", Offset = "0x50B75D0", VA = "0x1850B85D0", Slot = "4")]
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
		private MaterialPropertyBlock MNNHEJBNADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private CCKOAAJGNFF HEEINMMNNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<Transform> DFKBDOPDBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private RenderTexture OMKLNEAMNAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeBuffer JIAACADBIHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ComputeShader JGJACLNKKED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Matrix4x4[] PGCLMALKJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int OHNAMMGEEKH;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer MCPFJCBNANJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x58D4A0", Offset = "0x58C4A0", VA = "0x18058D4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int PIGILHECHAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x50C1680", Offset = "0x50C0680", VA = "0x1850C1680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x50C0BA0", Offset = "0x50BFBA0", VA = "0x1850C0BA0")]
		public static List<SkinnedShapeRenderer> Create(GameObject BHOMFIKIJGC, List<CCKOAAJGNFF> EBDCCCPCKEF, List<Transform> DFKBDOPDBJP, Material ECDFJLALJFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x50C1100", Offset = "0x50C0100", VA = "0x1850C1100")]
		public void Init(CCKOAAJGNFF HEEINMMNNBJ, List<Transform> DFKBDOPDBJP, Material ECDFJLALJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x50C15F0", Offset = "0x50C05F0", VA = "0x1850C15F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x50C1560", Offset = "0x50C0560", VA = "0x1850C1560")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x50C1520", Offset = "0x50C0520", VA = "0x1850C1520")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x50C0B10", Offset = "0x50BFB10", VA = "0x1850C0B10")]
		private void AAKOLHMCEBH(ScriptableRenderContext NPAGOMGBIJA, Camera[] DOJENGFMNDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x50C0DB0", Offset = "0x50BFDB0", VA = "0x1850C0DB0")]
		private void EIPBDEKOMDO(CommandBuffer NLJDOPPJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class IPBFNGMPFEA
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static byte[] FDFKLIHCMDI;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int IKEJBHOADAH;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int BADMEAGLBCG;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static BigInteger LKFKJFPDNAJ;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public IPBFNGMPFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x50BD450", Offset = "0x50BC450", VA = "0x1850BD450")]
	private static string OJNKOKJGCOH(byte[] BMEGDOGJIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x50BD550", Offset = "0x50BC550", VA = "0x1850BD550")]
	public static string PLNHDMOHEMF(byte[] LNCIHJHIBKD, bool PDPJHLLFJEO)
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
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
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
