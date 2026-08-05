using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.ClusterLODs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.ShapeRendering;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum EHJKHDJIHDA
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	RRO_MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	RRO_COLORS_COUNT = 61,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	RRO_MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	GENERATED_MIN_VALUE = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	GENERATED_COLORS_BITS_PER_CHANNEL = 8,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	GENERATED_COLORS_COUNT = 16777216,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	GENERATED_MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	LEGACY_GENERATED_COLORS_BITS_PER_CHANNEL = 4,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	LEGACY_GENERATED_COLORS_COUNT = 4096,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	GENERATED_TO_GPU_OFFSET = -939,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PBNLGICEFHP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5720", Offset = "0x5EF4120", VA = "0x185EF5720")]
	public static bool GHKKAJDELLC(this EHJKHDJIHDA PLPACFFGJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5710", Offset = "0x5EF4110", VA = "0x185EF5710")]
	public static bool GEPJCILLCLK(this EHJKHDJIHDA PLPACFFGJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5740", Offset = "0x5EF4140", VA = "0x185EF5740")]
	public static bool JGELPALCMAA(this EHJKHDJIHDA PLPACFFGJIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum AOKPFLMHALA
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	WORN_WOOD = 29,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum GPBFMJAMNPK
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum IIFCEINCIPN
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	PivotHover,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DebugLocate,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	FrozenHover
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JLAKINKJOFH
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class COAAILEKPDB : LDECDLGMDAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte FKGAGFCFAMO = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte IIINPBCMDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] FKFBHIGKFNH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JFDMDIEOIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CF0", Offset = "0x7D26F0", VA = "0x1807D3CF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D4380", Offset = "0x7D2D80", VA = "0x1807D4380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ECALKCLFPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E5910", Offset = "0x7E4310", VA = "0x1807E5910", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E5930", Offset = "0x7E4330", VA = "0x1807E5930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float KOIAEIDLJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBDD1B0", Offset = "0xBDBBB0", VA = "0x180BDD1B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBDD6B0", Offset = "0xBDC0B0", VA = "0x180BDD6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float JOGBFMICNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7E58F0", Offset = "0x7E42F0", VA = "0x1807E58F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E5030", Offset = "0x7E3A30", VA = "0x1807E5030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> DIGOODCILJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EE9870", Offset = "0x5EE8270", VA = "0x185EE9870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> IFALJMEGKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1BBC5E0", Offset = "0x1BBAFE0", VA = "0x181BBC5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject ADLFAHHCAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D2D70", VA = "0x1807D4370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte LFEMMDIHGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5EE9AA0", Offset = "0x5EE84A0", VA = "0x185EE9AA0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9AF0", Offset = "0x5EE84F0", VA = "0x185EE9AF0")]
	public COAAILEKPDB(List<LHILEACLCKE> NEHOOEADFCN, List<LHILEACLCKE> HKJMOEHJJNM, List<CKMNGIKNHCP> MMHGGBDPJHE, Material NCNMCMAJCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9720", Offset = "0x5EE8120", VA = "0x185EE9720")]
	private int CMCHBHKBMIG(List<LHILEACLCKE> GELAGMINEAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5EE95D0", Offset = "0x5EE7FD0", VA = "0x185EE95D0")]
	private void AGNCCGDNKNO(int HKIOHFPMDKF, bool DKMFIFCJODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9A00", Offset = "0x5EE8400", VA = "0x185EE9A00")]
	public void KOJFPODHAJO(Vector3 FFPMBENCDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5EE98D0", Offset = "0x5EE82D0", VA = "0x185EE98D0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9830", Offset = "0x5EE8230", VA = "0x185EE9830")]
	public void DHACHPMDFFD(Transform IBMLGHBALME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PHPKNLKOCDC : LNFIJKJHIPO, FCOKKFPPCMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LIGKPBPBAPA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public PHPKNLKOCDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		[DebuggerHidden]
		public LIGKPBPBAPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0CF0", Offset = "0x5EEF6F0", VA = "0x185EF0CF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF07C0", Offset = "0x5EEF1C0", VA = "0x185EF07C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0DF0", Offset = "0x5EEF7F0", VA = "0x185EF0DF0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0E40", Offset = "0x5EEF840", VA = "0x185EF0E40")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0E90", Offset = "0x5EEF890", VA = "0x185EF0E90")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0CB0", Offset = "0x5EEF6B0", VA = "0x185EF0CB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0C10", Offset = "0x5EEF610", VA = "0x185EF0C10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0C10", Offset = "0x5EEF610", VA = "0x185EF0C10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GDLLAGGMGMD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public PHPKNLKOCDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		[DebuggerHidden]
		public GDLLAGGMGMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5EECAB0", Offset = "0x5EEB4B0", VA = "0x185EECAB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC6F0", Offset = "0x5EEB0F0", VA = "0x185EEC6F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5EECB90", Offset = "0x5EEB590", VA = "0x185EECB90")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5EECBE0", Offset = "0x5EEB5E0", VA = "0x185EECBE0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5EECA70", Offset = "0x5EEB470", VA = "0x185EECA70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC9D0", Offset = "0x5EEB3D0", VA = "0x185EEC9D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC9D0", Offset = "0x5EEB3D0", VA = "0x185EEC9D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly MFFPPJBDNCM CFECPIOHNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<JAADOBPKDCM> HPHNCADMINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> GIDFFLNKOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer COCFHBNKLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool ANEMGEMGIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool KGLBCDBALEE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<CPDJIFKOGOM> ADPJHNMANKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IFOPGABAOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6E30", Offset = "0x5EF5830", VA = "0x185EF6E30", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public CKMNGIKNHCP DDJEKGPKKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6840", Offset = "0x5EF5240", VA = "0x185EF6840", Slot = "7")]
		get
		{
			return default(CKMNGIKNHCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> ACOCKLDOACD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8464B0", Offset = "0x844EB0", VA = "0x1808464B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6560", Offset = "0x5EF4F60", VA = "0x185EF6560")]
	private bool KOEHBIHKFPL(JAADOBPKDCM EJAEDNEHHAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6330", Offset = "0x5EF4D30", VA = "0x185EF6330")]
	private static bool IECDCAEPMJD(JAADOBPKDCM EJAEDNEHHAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6F00", Offset = "0x5EF5900", VA = "0x185EF6F00")]
	public PHPKNLKOCDC(MFFPPJBDNCM MNILNHMNKJK, bool BKBPEEPODNF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5FD0", Offset = "0x5EF49D0", VA = "0x185EF5FD0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6350", Offset = "0x5EF4D50", VA = "0x185EF6350")]
	public void IFPOOIAJHAI(JAADOBPKDCM EJAEDNEHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6200", Offset = "0x5EF4C00", VA = "0x185EF6200")]
	public void HEOHJOBENDL(JAADOBPKDCM EJAEDNEHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5EF57C0", Offset = "0x5EF41C0", VA = "0x185EF57C0", Slot = "4")]
	public void ACKKIAPCMGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6580", Offset = "0x5EF4F80", VA = "0x185EF6580")]
	public void LHJKKDLNDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5DD0", Offset = "0x5EF47D0", VA = "0x185EF5DD0")]
	private void AENJPAKJDJD(List<JAADOBPKDCM> HPHNCADMINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6500", Offset = "0x5EF4F00", VA = "0x185EF6500")]
	private static Material IIFCANFDFNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5D30", Offset = "0x5EF4730", VA = "0x185EF5D30")]
	private void AENJPAKJDJD(JAADOBPKDCM EJAEDNEHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6130", Offset = "0x5EF4B30", VA = "0x185EF6130")]
	private void EBCOFMFAHAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6910", Offset = "0x5EF5310", VA = "0x185EF6910")]
	public void ODBDDEEFAPG(bool HDECLGJHCAP, bool AMBFDMFHENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6E70", Offset = "0x5EF5870", VA = "0x185EF6E70")]
	protected void PMINFKLEDCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5F60", Offset = "0x5EF4960", VA = "0x185EF5F60")]
	[IteratorStateMachine(typeof(LIGKPBPBAPA))]
	public IEnumerable<Renderer> BEJAPPGGLEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF67D0", Offset = "0x5EF51D0", VA = "0x185EF67D0")]
	[IteratorStateMachine(typeof(GDLLAGGMGMD))]
	public IEnumerable<Renderer> MNCMODJHDLC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class MEINEINAJAN : JAADOBPKDCM
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private struct NILFCCMMPGC : KEKCGLGELGN, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private ACPOPPMDKCO OLBANABBMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private JobHandle CJDKHEEAEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private GMCPIEAEFPK ICPAJAGOBMI;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF28B0", Offset = "0x5EF12B0", VA = "0x185EF28B0")]
		public NILFCCMMPGC(ACPOPPMDKCO OLBANABBMBP, JobHandle CJDKHEEAEFK, GMCPIEAEFPK ICPAJAGOBMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xC611F0", Offset = "0xC5FBF0", VA = "0x180C611F0")]
		public bool DBBBFNFEPMK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2880", Offset = "0x5EF1280", VA = "0x185EF2880", Slot = "4")]
		public ACPOPPMDKCO IEOLHNPKHKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2830", Offset = "0x5EF1230", VA = "0x185EF2830", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly AKGGFKEIMDL MOFPKGLBHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private float OIMPMMOFHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Hash128 ICAPGBKIBFF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 OBLCNADNFDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1040", Offset = "0x5EEFA40", VA = "0x185EF1040", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2780", Offset = "0x5EF1180", VA = "0x185EF2780")]
	public MEINEINAJAN(PHPKNLKOCDC MNGLAEJHIMG, AKGGFKEIMDL MNILNHMNKJK, bool BKBPEEPODNF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "16")]
	public override bool FJIIJHFJABG(CKMNGIKNHCP MNGLAEJHIMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1170", Offset = "0x5EEFB70", VA = "0x185EF1170", Slot = "18")]
	public override int CMCHBHKBMIG(JKFPCBLPBIJ BIMLEJNEELL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1EB0", Offset = "0x5EF08B0", VA = "0x185EF1EB0", Slot = "19")]
	public override int LIOLAHMEHHH(JKFPCBLPBIJ BIMLEJNEELL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5EF20A0", Offset = "0x5EF0AA0", VA = "0x185EF20A0", Slot = "20")]
	public override void PFKLAHIHEBI(JKFPCBLPBIJ BIMLEJNEELL, EGKHIBAHBGL MPLGCAEFKEH, int MDONIBIBIDF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1C20", Offset = "0x5EF0620", VA = "0x185EF1C20", Slot = "21")]
	public override CKMNGIKNHCP GEEMINMGLOA()
	{
		return default(CKMNGIKNHCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1CF0", Offset = "0x5EF06F0", VA = "0x185EF1CF0", Slot = "23")]
	public override IALOJJBDPAM KOEBCFJMDCB()
	{
		return default(IALOJJBDPAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1360", Offset = "0x5EEFD60", VA = "0x185EF1360", Slot = "24")]
	public override KEKCGLGELGN COJNNJJMAKP(JKFPCBLPBIJ BIMLEJNEELL, JobHandle CJDKHEEAEFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct MBMDFMFPNAN : global::EIJDEJKCJCH<MBMDFMFPNAN>, LFLEFMNCAPN, IEquatable<MBMDFMFPNAN>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int EOGKCECFNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8650A0", Offset = "0x863AA0", VA = "0x1808650A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	[CreateProperty]
	public int GGPKANELEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x865090", Offset = "0x863A90", VA = "0x180865090", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x865100", Offset = "0x863B00", VA = "0x180865100", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool GGNGOEANAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0F70", Offset = "0x5EEF970", VA = "0x185EF0F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8622F0", Offset = "0x860CF0", VA = "0x1808622F0", Slot = "8")]
	public bool Equals(MBMDFMFPNAN EHBPAFKHADK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1A44B70", Offset = "0x1A43570", VA = "0x181A44B70")]
	public static bool ENMIHMCKBEN(MBMDFMFPNAN MGFKDMJBGAK, MBMDFMFPNAN LPDJCHOFJLE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1A44B90", Offset = "0x1A43590", VA = "0x181A44B90")]
	public static bool IDBOJBLCJLG(MBMDFMFPNAN MGFKDMJBGAK, MBMDFMFPNAN LPDJCHOFJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0EE0", Offset = "0x5EEF8E0", VA = "0x185EF0EE0", Slot = "0")]
	public override bool Equals(object OMHIFHKMIMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0FB0", Offset = "0x5EEF9B0", VA = "0x185EF0FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum DADJGMGAEMD
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MFFPPJBDNCM
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	CKMNGIKNHCP CCKPELKPNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DADJGMGAEMD NEIOLCGDIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct DBOPJIDEMLD : global::EIJDEJKCJCH<DBOPJIDEMLD>, LFLEFMNCAPN, IEquatable<DBOPJIDEMLD>
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int EOGKCECFNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8650A0", Offset = "0x863AA0", VA = "0x1808650A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	[CreateProperty]
	public int GGPKANELEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x865090", Offset = "0x863A90", VA = "0x180865090", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x865100", Offset = "0x863B00", VA = "0x180865100", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool GGNGOEANAEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5EE9F40", Offset = "0x5EE8940", VA = "0x185EE9F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8622F0", Offset = "0x860CF0", VA = "0x1808622F0", Slot = "8")]
	public bool Equals(DBOPJIDEMLD EHBPAFKHADK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1A44B70", Offset = "0x1A43570", VA = "0x181A44B70")]
	public static bool ENMIHMCKBEN(DBOPJIDEMLD MGFKDMJBGAK, DBOPJIDEMLD LPDJCHOFJLE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1A44B90", Offset = "0x1A43590", VA = "0x181A44B90")]
	public static bool IDBOJBLCJLG(DBOPJIDEMLD MGFKDMJBGAK, DBOPJIDEMLD LPDJCHOFJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9EB0", Offset = "0x5EE88B0", VA = "0x185EE9EB0", Slot = "0")]
	public override bool Equals(object OMHIFHKMIMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9F80", Offset = "0x5EE8980", VA = "0x185EE9F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ICJLCABJBDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool CKBCFFKPJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LMKOADIMLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	CKMNGIKNHCP CCKPELKPNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float FEDNPJGIEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 BHBLFJCFCAF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	EHJKHDJIHDA HNOLEECGKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	AOKPFLMHALA ALPHDFLLFBE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NPOGKFDJCMM : ICJLCABJBDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	LHKHGNFOAHF JCFDBFKMOMA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool KMBNMOPDBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AKGGFKEIMDL : ICJLCABJBDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool IHHMLODJNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JHNPPNCLFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	float KAAKBOBKILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int OLGFEMANJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool BGICNNNMKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int NJCNOAOPFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<JJINMCDIMPB> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CPHOOPEMGNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIMLOLEDDGC(MBMDFMFPNAN MNGLAEJHIMG, IIFCEINCIPN BLBGFDOJDFM);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIMLOLEDDGC(DBOPJIDEMLD EJAEDNEHHAO, IIFCEINCIPN BLBGFDOJDFM);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EPGDDKABMIA(DBOPJIDEMLD EJAEDNEHHAO);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LNOHAHACAAF(DBOPJIDEMLD EJAEDNEHHAO);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CNLCEPBEDCM();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NEOMGPOBHGG();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IIOFHDHIFOJ(IIFCEINCIPN EMKINACMDLO);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PIAOEMIDBLF(MBMDFMFPNAN MNGLAEJHIMG);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PIAOEMIDBLF(DBOPJIDEMLD EJAEDNEHHAO);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KLBBLGBIJOD(MBMDFMFPNAN MNGLAEJHIMG, JLAKINKJOFH EMKINACMDLO);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KLBBLGBIJOD(DBOPJIDEMLD EJAEDNEHHAO, JLAKINKJOFH EMKINACMDLO);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ALOLHIOIEAO(DBOPJIDEMLD EJAEDNEHHAO);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BDHNABIPJHD(DBOPJIDEMLD EJAEDNEHHAO);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FNDHIJLAJLE();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KDEMCOEIMPC();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NDMOFGEOANI(JLAKINKJOFH EMKINACMDLO);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BAPIFNPCLBP(MBMDFMFPNAN MNGLAEJHIMG, Vector3 MNIEBIOKGFD, Vector3 LHDNMLNNMGO, Vector3 HEKHBIDDCHO, float JLJCKMDDHAC, float KEGCGNMOBDP, IReadOnlyList<Camera> EOAHNJNHDGD, GPBFMJAMNPK BEEBFFDDHKH);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BAPIFNPCLBP(FJJFPEDBHPI HCDHIDGLLCG, Vector3 MNIEBIOKGFD, Vector3 LHDNMLNNMGO, Vector3 HEKHBIDDCHO, float JLJCKMDDHAC, float KEGCGNMOBDP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public interface APMLJHCGADL
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	PHPKNLKOCDC KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	JAADOBPKDCM KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	KMLCACCIBFD KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ODEPLOLOCLN : APMLJHCGADL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool BEKDCIGKCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MBMDFMFPNAN LOMMLDPFLJI(MFFPPJBDNCM MNILNHMNKJK);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MBMDFMFPNAN LOMMLDPFLJI(MFFPPJBDNCM MNILNHMNKJK, bool OLIKBDKPJCL);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKFAJIPEMFM(MBMDFMFPNAN MNGLAEJHIMG);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NJNBDEOPBPH(MBMDFMFPNAN MNGLAEJHIMG);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DBOPJIDEMLD NAHGKELLIDB(MBMDFMFPNAN MNGLAEJHIMG, NPOGKFDJCMM MNILNHMNKJK);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DBOPJIDEMLD LCPEAKLNODO(MBMDFMFPNAN MNGLAEJHIMG, AKGGFKEIMDL MNILNHMNKJK);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OGKHMONFCEB(DBOPJIDEMLD EJAEDNEHHAO);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HMGJAKKKACD(DBOPJIDEMLD EJAEDNEHHAO);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FJJFPEDBHPI FJACDNHFPCG(BODGOGPJPCI MNILNHMNKJK);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DABJCHDHKDD(FJJFPEDBHPI HCDHIDGLLCG);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AJNABDFLCPI(FJJFPEDBHPI HCDHIDGLLCG);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task IOAFIOMINDF();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task JPFKBNJBFJM();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task JJLCLFINEEJ();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JFBIDGLNNHI();

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	ACPOPPMDKCO NGNFGBGFABP(CKMNGIKNHCP GCPDMFPMPII, IEnumerable<DBOPJIDEMLD> HPHNCADMINP, int LLODPCJCIKF);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerable<Renderer> JMPBKDADJMM(MBMDFMFPNAN MNGLAEJHIMG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FJJFPEDBHPI : global::EIJDEJKCJCH<FJJFPEDBHPI>, LFLEFMNCAPN, IEquatable<FJJFPEDBHPI>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int EOGKCECFNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8650A0", Offset = "0x863AA0", VA = "0x1808650A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int GGPKANELEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x865090", Offset = "0x863A90", VA = "0x180865090", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x865100", Offset = "0x863B00", VA = "0x180865100", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GGNGOEANAEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC6B0", Offset = "0x5EEB0B0", VA = "0x185EEC6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8622F0", Offset = "0x860CF0", VA = "0x1808622F0", Slot = "8")]
	public bool Equals(FJJFPEDBHPI EHBPAFKHADK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1A44B70", Offset = "0x1A43570", VA = "0x181A44B70")]
	public static bool ENMIHMCKBEN(FJJFPEDBHPI MGFKDMJBGAK, FJJFPEDBHPI LPDJCHOFJLE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1A44B90", Offset = "0x1A43590", VA = "0x181A44B90")]
	public static bool IDBOJBLCJLG(FJJFPEDBHPI MGFKDMJBGAK, FJJFPEDBHPI LPDJCHOFJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC620", Offset = "0x5EEB020", VA = "0x185EEC620", Slot = "0")]
	public override bool Equals(object OMHIFHKMIMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BODGOGPJPCI
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	int FMJPBBFHFKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Transform OJBAKBKFFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool GKNAKDEIAFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MBMDFMFPNAN GetBone(int ELHLEGLLBOJ);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int ELHLEGLLBOJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public class ALFLLPMBCNC : ODEPLOLOCLN, APMLJHCGADL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct AHCCNEGCHKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public ALFLLPMBCNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5EE6400", Offset = "0x5EE4E00", VA = "0x185EE6400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9396C0", Offset = "0x9380C0", VA = "0x1809396C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly global::MKPHHDEIJDO<MBMDFMFPNAN, PHPKNLKOCDC> NCONHJDEKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly global::MKPHHDEIJDO<DBOPJIDEMLD, JAADOBPKDCM> HPHNCADMINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly global::MKPHHDEIJDO<FJJFPEDBHPI, KMLCACCIBFD> GFBOBAMACJL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public PHPKNLKOCDC KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5EE6DF0", Offset = "0x5EE57F0", VA = "0x185EE6DF0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public JAADOBPKDCM KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5EE6E50", Offset = "0x5EE5850", VA = "0x185EE6E50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public KMLCACCIBFD KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5EE6D90", Offset = "0x5EE5790", VA = "0x185EE6D90", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool BEKDCIGKCBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x856FD0", Offset = "0x8559D0", VA = "0x180856FD0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x856FE0", Offset = "0x8559E0", VA = "0x180856FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9110", Offset = "0x5EE7B10", VA = "0x185EE9110")]
	public ALFLLPMBCNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6BF0", Offset = "0x5EE55F0", VA = "0x185EE6BF0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7FB0", Offset = "0x5EE69B0", VA = "0x185EE7FB0", Slot = "4")]
	public MBMDFMFPNAN LOMMLDPFLJI(MFFPPJBDNCM MNILNHMNKJK)
	{
		return default(MBMDFMFPNAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7D10", Offset = "0x5EE6710", VA = "0x185EE7D10", Slot = "5")]
	public MBMDFMFPNAN LOMMLDPFLJI(MFFPPJBDNCM MNILNHMNKJK, bool BKBPEEPODNF)
	{
		return default(MBMDFMFPNAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6970", Offset = "0x5EE5370", VA = "0x185EE6970", Slot = "6")]
	public void DKFAJIPEMFM(MBMDFMFPNAN MNGLAEJHIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8B00", Offset = "0x5EE7500", VA = "0x185EE8B00", Slot = "7")]
	public void NJNBDEOPBPH(MBMDFMFPNAN MNGLAEJHIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7FC0", Offset = "0x5EE69C0", VA = "0x185EE7FC0", Slot = "8")]
	public DBOPJIDEMLD NAHGKELLIDB(MBMDFMFPNAN MNGLAEJHIMG, NPOGKFDJCMM MNILNHMNKJK)
	{
		return default(DBOPJIDEMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7800", Offset = "0x5EE6200", VA = "0x185EE7800", Slot = "9")]
	public DBOPJIDEMLD LCPEAKLNODO(MBMDFMFPNAN MNGLAEJHIMG, AKGGFKEIMDL MNILNHMNKJK)
	{
		return default(DBOPJIDEMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6F30", Offset = "0x5EE5930", VA = "0x185EE6F30", Slot = "11")]
	public void HMGJAKKKACD(DBOPJIDEMLD EJAEDNEHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8E90", Offset = "0x5EE7890", VA = "0x185EE8E90", Slot = "10")]
	public void OGKHMONFCEB(DBOPJIDEMLD EJAEDNEHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7630", Offset = "0x5EE6030", VA = "0x185EE7630", Slot = "21")]
	public IEnumerable<Renderer> JMPBKDADJMM(MBMDFMFPNAN MNGLAEJHIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6EB0", Offset = "0x5EE58B0", VA = "0x185EE6EB0", Slot = "12")]
	public FJJFPEDBHPI FJACDNHFPCG(BODGOGPJPCI MNILNHMNKJK)
	{
		return default(FJJFPEDBHPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5EE68A0", Offset = "0x5EE52A0", VA = "0x185EE68A0", Slot = "14")]
	public void AJNABDFLCPI(FJJFPEDBHPI HCDHIDGLLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7330", Offset = "0x5EE5D30", VA = "0x185EE7330", Slot = "16")]
	public Task IOAFIOMINDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5EE76A0", Offset = "0x5EE60A0", VA = "0x185EE76A0", Slot = "17")]
	public Task JPFKBNJBFJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7530", Offset = "0x5EE5F30", VA = "0x185EE7530", Slot = "18")]
	[AsyncStateMachine(typeof(AHCCNEGCHKB))]
	public Task JJLCLFINEEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5EE74A0", Offset = "0x5EE5EA0", VA = "0x185EE74A0", Slot = "19")]
	public void JFBIDGLNNHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6910", Offset = "0x5EE5310", VA = "0x185EE6910", Slot = "13")]
	public void DABJCHDHKDD(FJJFPEDBHPI HCDHIDGLLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5EE84D0", Offset = "0x5EE6ED0", VA = "0x185EE84D0", Slot = "20")]
	public ACPOPPMDKCO NGNFGBGFABP(CKMNGIKNHCP EOBMBNKEPGB, IEnumerable<DBOPJIDEMLD> HPHNCADMINP, int LLODPCJCIKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class FILDFOBIGIE : JAADOBPKDCM
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct FHLMAOGGIHP : KEKCGLGELGN, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private ACPOPPMDKCO OLBANABBMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private JobHandle CJDKHEEAEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private OJFJAPOPGAP ICPAJAGOBMI;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5EEA090", Offset = "0x5EE8A90", VA = "0x185EEA090")]
		public FHLMAOGGIHP(ACPOPPMDKCO OLBANABBMBP, JobHandle CJDKHEEAEFK, OJFJAPOPGAP ICPAJAGOBMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xC611F0", Offset = "0xC5FBF0", VA = "0x180C611F0")]
		public bool DBBBFNFEPMK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5EEA060", Offset = "0x5EE8A60", VA = "0x185EEA060", Slot = "4")]
		public ACPOPPMDKCO IEOLHNPKHKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5EEA010", Offset = "0x5EE8A10", VA = "0x185EEA010", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly NPOGKFDJCMM LAEHDPABEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int[] MIIBLPHCKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private float OIMPMMOFHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Hash128 ICAPGBKIBFF;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override KCCGGBJGOAN OCNKILJEBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB280", Offset = "0x5EE9C80", VA = "0x185EEB280", Slot = "17")]
		get
		{
			return default(KCCGGBJGOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private Vector3 CNOINBMFFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5EEA0E0", Offset = "0x5EE8AE0", VA = "0x185EEA0E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected override Hash128 OBLCNADNFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5EEA430", Offset = "0x5EE8E30", VA = "0x185EEA430", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC390", Offset = "0x5EEAD90", VA = "0x185EEC390")]
	public FILDFOBIGIE(PHPKNLKOCDC MNGLAEJHIMG, NPOGKFDJCMM MNILNHMNKJK, bool NBPBOCDAEDC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAE10", Offset = "0x5EE9810", VA = "0x185EEAE10", Slot = "16")]
	public override bool FJIIJHFJABG(CKMNGIKNHCP MNGLAEJHIMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA560", Offset = "0x5EE8F60", VA = "0x185EEA560", Slot = "18")]
	public override int CMCHBHKBMIG(JKFPCBLPBIJ BIMLEJNEELL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBB70", Offset = "0x5EEA570", VA = "0x185EEBB70", Slot = "19")]
	public override int LIOLAHMEHHH(JKFPCBLPBIJ BIMLEJNEELL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB700", Offset = "0x5EEA100", VA = "0x185EEB700")]
	private int HPCMNGDJMDD(JKFPCBLPBIJ BIMLEJNEELL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBC20", Offset = "0x5EEA620", VA = "0x185EEBC20", Slot = "20")]
	public override void PFKLAHIHEBI(JKFPCBLPBIJ BIMLEJNEELL, EGKHIBAHBGL MPLGCAEFKEH, int MDONIBIBIDF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB630", Offset = "0x5EEA030", VA = "0x185EEB630", Slot = "21")]
	public override CKMNGIKNHCP GEEMINMGLOA()
	{
		return default(CKMNGIKNHCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB9B0", Offset = "0x5EEA3B0", VA = "0x185EEB9B0", Slot = "23")]
	public override IALOJJBDPAM KOEBCFJMDCB()
	{
		return default(IALOJJBDPAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA610", Offset = "0x5EE9010", VA = "0x185EEA610", Slot = "24")]
	public override KEKCGLGELGN COJNNJJMAKP(JKFPCBLPBIJ BIMLEJNEELL, JobHandle CJDKHEEAEFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KINICDOHCJC
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLKIKAOFGLH(JLAKINKJOFH EMKINACMDLO, Renderer HPJIHIPEFOA, int KJFMHLPFANM);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FMBAJFJNKFG(Renderer HPJIHIPEFOA, GPBFMJAMNPK BEEBFFDDHKH, Vector3 MNIEBIOKGFD, Vector3 LHDNMLNNMGO, Vector3 HEKHBIDDCHO, float JLJCKMDDHAC, float KEGCGNMOBDP, float GKFGLEIEALC = -1f, [Optional] Color? CPPINAHFMCO, [Optional] IReadOnlyList<Camera> HAEEBHGGGOL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKKLGACHNAF(Renderer HPJIHIPEFOA, int KJFMHLPFANM);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KMHDHGGIAEL();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BIIBPCPMBNC(int GLMPFEAKGGF, IIFCEINCIPN EMKINACMDLO, Renderer HPJIHIPEFOA, int KJFMHLPFANM);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OINAFENDMMF : CPHOOPEMGNB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class PCFCFLBPOFH : global::OAMIIMJEMLE<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5770", Offset = "0x5EF4170", VA = "0x185EF5770")]
		public PCFCFLBPOFH(string KMEGKECOLPJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly KINICDOHCJC EMJBPFKLPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly APMLJHCGADL GJDLDJDHFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MeshRenderer MDAMLCJDPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private PCFCFLBPOFH CJCJAEKEEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool BLCPKCEHIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MeshRenderer CEPLPPCENDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private PCFCFLBPOFH DEDDOIAHMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool KPNOIKGLJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private MeshRenderer LBMECPEMLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private PCFCFLBPOFH NKJJFCAKONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool ILMLECMLEKB;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x84CDF0", Offset = "0x84B7F0", VA = "0x18084CDF0")]
	public OINAFENDMMF(KINICDOHCJC HJJPBEACJEB, APMLJHCGADL GJDLDJDHFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3AA0", Offset = "0x5EF24A0", VA = "0x185EF3AA0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3780", Offset = "0x5EF2180", VA = "0x185EF3780")]
	private void BBFLPNLDEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5160", Offset = "0x5EF3B60", VA = "0x185EF5160", Slot = "4")]
	public void PIMLOLEDDGC(MBMDFMFPNAN MNGLAEJHIMG, IIFCEINCIPN BLBGFDOJDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4F40", Offset = "0x5EF3940", VA = "0x185EF4F40", Slot = "5")]
	public void PIMLOLEDDGC(DBOPJIDEMLD EJAEDNEHHAO, IIFCEINCIPN BLBGFDOJDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3C70", Offset = "0x5EF2670", VA = "0x185EF3C70", Slot = "6")]
	public void EPGDDKABMIA(DBOPJIDEMLD EJAEDNEHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4590", Offset = "0x5EF2F90", VA = "0x185EF4590", Slot = "7")]
	public void LNOHAHACAAF(DBOPJIDEMLD EJAEDNEHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3A60", Offset = "0x5EF2460", VA = "0x185EF3A60", Slot = "8")]
	public void CNLCEPBEDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x270B8D0", Offset = "0x270A2D0", VA = "0x18270B8D0", Slot = "9")]
	public void NEOMGPOBHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3DE0", Offset = "0x5EF27E0", VA = "0x185EF3DE0", Slot = "10")]
	public void IIOFHDHIFOJ(IIFCEINCIPN BLBGFDOJDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4A40", Offset = "0x5EF3440", VA = "0x185EF4A40", Slot = "11")]
	public void PIAOEMIDBLF(MBMDFMFPNAN MNGLAEJHIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4BF0", Offset = "0x5EF35F0", VA = "0x185EF4BF0", Slot = "12")]
	public void PIAOEMIDBLF(DBOPJIDEMLD EJAEDNEHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3F50", Offset = "0x5EF2950", VA = "0x185EF3F50", Slot = "13")]
	public void KLBBLGBIJOD(MBMDFMFPNAN MNGLAEJHIMG, JLAKINKJOFH EMKINACMDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5EF42D0", Offset = "0x5EF2CD0", VA = "0x185EF42D0", Slot = "14")]
	public void KLBBLGBIJOD(DBOPJIDEMLD EJAEDNEHHAO, JLAKINKJOFH EMKINACMDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3DA0", Offset = "0x5EF27A0", VA = "0x185EF3DA0", Slot = "17")]
	public void FNDHIJLAJLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2F40", Offset = "0x5EF1940", VA = "0x185EF2F40", Slot = "15")]
	public void ALOLHIOIEAO(DBOPJIDEMLD EJAEDNEHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EF39D0", Offset = "0x5EF23D0", VA = "0x185EF39D0", Slot = "16")]
	public void BDHNABIPJHD(DBOPJIDEMLD EJAEDNEHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x20088E0", Offset = "0x20072E0", VA = "0x1820088E0", Slot = "18")]
	public void KDEMCOEIMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4900", Offset = "0x5EF3300", VA = "0x185EF4900", Slot = "19")]
	public void NDMOFGEOANI(JLAKINKJOFH EMKINACMDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5EF46B0", Offset = "0x5EF30B0", VA = "0x185EF46B0")]
	private void MIDOMGOIDPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4110", Offset = "0x5EF2B10", VA = "0x185EF4110")]
	public void KLBBLGBIJOD(DBOPJIDEMLD EJAEDNEHHAO, JLAKINKJOFH EMKINACMDLO, bool NEIBKNJIEGB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5EF44C0", Offset = "0x5EF2EC0", VA = "0x185EF44C0")]
	private void LLKIKAOFGLH(JLAKINKJOFH EMKINACMDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2FE0", Offset = "0x5EF19E0", VA = "0x185EF2FE0", Slot = "20")]
	public void BAPIFNPCLBP(MBMDFMFPNAN MNGLAEJHIMG, Vector3 MNIEBIOKGFD, Vector3 LHDNMLNNMGO, Vector3 HEKHBIDDCHO, float JLJCKMDDHAC, float KEGCGNMOBDP, IReadOnlyList<Camera> EOAHNJNHDGD, GPBFMJAMNPK BEEBFFDDHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3360", Offset = "0x5EF1D60", VA = "0x185EF3360", Slot = "21")]
	public void BAPIFNPCLBP(FJJFPEDBHPI HCDHIDGLLCG, Vector3 MNIEBIOKGFD, Vector3 LHDNMLNNMGO, Vector3 HEKHBIDDCHO, float JLJCKMDDHAC, float KEGCGNMOBDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface OAANIANGCND
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool PJONAPBLHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material GBBMFDJINLO();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material IIFCANFDFNE();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material DMBGKPPLJAL();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OLOCGHIJCIK(EHJKHDJIHDA PLPACFFGJIF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FEHGBKKNMHP(AOKPFLMHALA IDMLJIMLKLH);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JBBHABNCHEP(GameObject OMHIFHKMIMJ);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MIAENIJMJED(GameObject OMHIFHKMIMJ, bool JPAJPOECJKD);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class PNNPLFMILKE
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static OAANIANGCND NPGEFAIHGBA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static bool PJONAPBLHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6FF0", Offset = "0x5EF59F0", VA = "0x185EF6FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7180", Offset = "0x5EF5B80", VA = "0x185EF7180")]
	public static void GMOMFCGDLBG(OAANIANGCND KFPFCOEIENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7120", Offset = "0x5EF5B20", VA = "0x185EF7120")]
	public static Material GBBMFDJINLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6500", Offset = "0x5EF4F00", VA = "0x185EF6500")]
	public static Material IIFCANFDFNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7050", Offset = "0x5EF5A50", VA = "0x185EF7050")]
	public static Material DMBGKPPLJAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7390", Offset = "0x5EF5D90", VA = "0x185EF7390")]
	public static int OLOCGHIJCIK(EHJKHDJIHDA PLPACFFGJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5EF70B0", Offset = "0x5EF5AB0", VA = "0x185EF70B0")]
	public static int FEHGBKKNMHP(AOKPFLMHALA IDMLJIMLKLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5EF71D0", Offset = "0x5EF5BD0", VA = "0x185EF71D0")]
	public static void JBBHABNCHEP(GameObject OMHIFHKMIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5EF72A0", Offset = "0x5EF5CA0", VA = "0x185EF72A0")]
	public static void MIAENIJMJED(GameObject OMHIFHKMIMJ, bool JPAJPOECJKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class JAADOBPKDCM : CNFKNCMNBEH, CPDJIFKOGOM, MHHKJMADKCO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly PHPKNLKOCDC ADLFAHHCAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected Bounds JAAJNBNCBPP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Bounds OBNLNHADKHO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1E361B0", Offset = "0x1E34BB0", VA = "0x181E361B0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public virtual KCCGGBJGOAN OCNKILJEBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDCB0", Offset = "0x5EEC6B0", VA = "0x185EEDCB0", Slot = "17")]
		get
		{
			return default(KCCGGBJGOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool KGLBCDBALEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x83BF80", Offset = "0x83A980", VA = "0x18083BF80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x83BFA0", Offset = "0x83A9A0", VA = "0x18083BFA0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	protected abstract Hash128 OBLCNADNFDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int KDCCIENLLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7373E0", Offset = "0x735DE0", VA = "0x1807373E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AHDBKFGODHG LODKFGMGKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8464B0", Offset = "0x844EB0", VA = "0x1808464B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool AJMPGFDIBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xBFDC70", Offset = "0xBFC670", VA = "0x180BFDC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	protected JAADOBPKDCM(PHPKNLKOCDC MNGLAEJHIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5EEDB50", Offset = "0x5EEC550", VA = "0x185EEDB50", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "16")]
	public virtual bool FJIIJHFJABG(CKMNGIKNHCP MNGLAEJHIMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int CMCHBHKBMIG(JKFPCBLPBIJ BIMLEJNEELL);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int LIOLAHMEHHH(JKFPCBLPBIJ BIMLEJNEELL);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void PFKLAHIHEBI(JKFPCBLPBIJ BIMLEJNEELL, EGKHIBAHBGL MPLGCAEFKEH, int MDONIBIBIDF = -1);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract CKMNGIKNHCP GEEMINMGLOA();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5EEDC80", Offset = "0x5EEC680", VA = "0x185EEDC80", Slot = "11")]
	public Hash128 FJMHHNFKCGC(int BIMLEJNEELL)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract IALOJJBDPAM KOEBCFJMDCB();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract KEKCGLGELGN COJNNJJMAKP(JKFPCBLPBIJ BIMLEJNEELL, JobHandle CJDKHEEAEFK);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEDD40", Offset = "0x5EEC740", VA = "0x185EEDD40", Slot = "10")]
	public KEKCGLGELGN NGNFGBGFABP(int BIMLEJNEELL)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7400", Offset = "0x5EF5E00", VA = "0x185EF7400")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum LHKHGNFOAHF
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	RR_Box,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	RR_Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	RR_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	RR_Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	RR_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	RR_HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	RR_Cone,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	RR_Pipe,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	RR_Donut,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	RR_HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	RR_Diamond,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	ADVANCED_Mound,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	LEGACY_Box,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	ADVANCED_Cube,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	ADVANCED_Sphere,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	ADVANCED_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	ADVANCED_Cone,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	ADVANCED_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	ADVANCED_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	ADVANCED_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	ADVANCED_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	ADVANCED_QuarterPipe,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	ADVANCED_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	ADVANCED_Dodecahedron,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	ADVANCED_Trihedron,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	ADVANCED_Octahedron,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_QuarterCylinder,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RR_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_QuarterSphere,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	ADVANCED_Wedge,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class GGNDOLIHCDE
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class JPLPIIAEFFE : IEnumerable<LKCPKIEMLFF>, IEnumerable, IEnumerator<LKCPKIEMLFF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private LKCPKIEMLFF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private LKCPKIEMLFF System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		[DebuggerHidden]
		public JPLPIIAEFFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDD70", Offset = "0x5EEC770", VA = "0x185EEDD70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDEE0", Offset = "0x5EEC8E0", VA = "0x185EEDEE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDE50", Offset = "0x5EEC850", VA = "0x185EEDE50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LKCPKIEMLFF> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDE50", Offset = "0x5EEC850", VA = "0x185EEDE50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public const int CEHBMNENJLE = 3;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static LKCPKIEMLFF[][] NPNKDKMHKAE;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static PNFHNCHJPCB BGMGJCHCNGC;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static ShapeRendererConfig IONLMCIKPHO;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static ComputeShader ENGBIFHMIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5EED330", Offset = "0x5EEBD30", VA = "0x185EED330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static SkinnedShapeRenderer JBBPPAAHPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5EECCB0", Offset = "0x5EEB6B0", VA = "0x185EECCB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5EED050", Offset = "0x5EEBA50", VA = "0x185EED050")]
	public static Mesh IMMPNDIONEH(LHKHGNFOAHF GFELMDLHNLL, int BIMLEJNEELL = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5EECD20", Offset = "0x5EEB720", VA = "0x185EECD20")]
	public static int GFBJANNFBCD(LHKHGNFOAHF GFELMDLHNLL, int BIMLEJNEELL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5EECEE0", Offset = "0x5EEB8E0", VA = "0x185EECEE0")]
	public static PNFHNCHJPCB HDHMNMMEOLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5EECC30", Offset = "0x5EEB630", VA = "0x185EECC30")]
	[IteratorStateMachine(typeof(JPLPIIAEFFE))]
	private static IEnumerable<LKCPKIEMLFF> ANMMFKFGIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5EED3A0", Offset = "0x5EEBDA0", VA = "0x185EED3A0")]
	public static LKCPKIEMLFF MPCIAHCBEKO(LHKHGNFOAHF GFELMDLHNLL, int BIMLEJNEELL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5EECC90", Offset = "0x5EEB690", VA = "0x185EECC90")]
	public static bool CDNBGPBINFJ(this LHKHGNFOAHF GFELMDLHNLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5EECD30", Offset = "0x5EEB730", VA = "0x185EECD30")]
	public static void GONPMAMINNI(LHKHGNFOAHF GFELMDLHNLL, float3 CNKPMABJJEH, out JNGPAGKAEGI CNPEELPGGNA, out float3 AHENKKMIPIE, out float LMDFAMAKBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5EED700", Offset = "0x5EEC100", VA = "0x185EED700")]
	public static void POLGOCIDOFN(Vector3 CNKPMABJJEH, LHKHGNFOAHF GFELMDLHNLL, out Vector3 AHENKKMIPIE, out float LMDFAMAKBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5EED040", Offset = "0x5EEBA40", VA = "0x185EED040")]
	[PIJCMAPDPIG(MIPMDHCOGFK.ExitingPlayMode, 0)]
	private static void HMABIGLPCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5EED110", Offset = "0x5EEBB10", VA = "0x185EED110")]
	[PIJCMAPDPIG(MIPMDHCOGFK.ExitingPlayMode, 0)]
	private static void JOJNNHANNED()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[DefaultMember("Item")]
	[KEFMDJAGLBH(IGKCNDFEDMC.ShapeRendering)]
	public class ShapeRendererManager : ODEPLOLOCLN, APMLJHCGADL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly global::MKPHHDEIJDO<MBMDFMFPNAN, PHPKNLKOCDC> NCONHJDEKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly global::MKPHHDEIJDO<DBOPJIDEMLD, JAADOBPKDCM> HPHNCADMINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly global::MKPHHDEIJDO<FJJFPEDBHPI, KMLCACCIBFD> GFBOBAMACJL;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public PHPKNLKOCDC KBLKMCBLENC
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x5EF76B0", Offset = "0x5EF60B0", VA = "0x185EF76B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public JAADOBPKDCM KBLKMCBLENC
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x5EF75F0", Offset = "0x5EF5FF0", VA = "0x185EF75F0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public KMLCACCIBFD KBLKMCBLENC
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x5EF7650", Offset = "0x5EF6050", VA = "0x185EF7650", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool BEKDCIGKCBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x856FD0", Offset = "0x8559D0", VA = "0x180856FD0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x856FE0", Offset = "0x8559E0", VA = "0x180856FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8270", Offset = "0x5EF6C70", VA = "0x185EF8270")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7560", Offset = "0x5EF5F60", VA = "0x185EF7560", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7AF0", Offset = "0x5EF64F0", VA = "0x185EF7AF0", Slot = "4")]
		public MBMDFMFPNAN LOMMLDPFLJI(MFFPPJBDNCM MNILNHMNKJK)
		{
			return default(MBMDFMFPNAN);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7AF0", Offset = "0x5EF64F0", VA = "0x185EF7AF0", Slot = "5")]
		public MBMDFMFPNAN LOMMLDPFLJI(MFFPPJBDNCM MNILNHMNKJK, bool BKBPEEPODNF)
		{
			return default(MBMDFMFPNAN);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7500", Offset = "0x5EF5F00", VA = "0x185EF7500", Slot = "6")]
		public void DKFAJIPEMFM(MBMDFMFPNAN MNGLAEJHIMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8140", Offset = "0x5EF6B40", VA = "0x185EF8140", Slot = "7")]
		public void NJNBDEOPBPH(MBMDFMFPNAN MNGLAEJHIMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7C00", Offset = "0x5EF6600", VA = "0x185EF7C00", Slot = "8")]
		public DBOPJIDEMLD NAHGKELLIDB(MBMDFMFPNAN MNGLAEJHIMG, NPOGKFDJCMM MNILNHMNKJK)
		{
			return default(DBOPJIDEMLD);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF79B0", Offset = "0x5EF63B0", VA = "0x185EF79B0", Slot = "9")]
		public DBOPJIDEMLD LCPEAKLNODO(MBMDFMFPNAN MNGLAEJHIMG, AKGGFKEIMDL MNILNHMNKJK)
		{
			return default(DBOPJIDEMLD);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7790", Offset = "0x5EF6190", VA = "0x185EF7790", Slot = "11")]
		public void HMGJAKKKACD(DBOPJIDEMLD EJAEDNEHHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5EF81C0", Offset = "0x5EF6BC0", VA = "0x185EF81C0", Slot = "10")]
		public void OGKHMONFCEB(DBOPJIDEMLD EJAEDNEHHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5EF78E0", Offset = "0x5EF62E0", VA = "0x185EF78E0", Slot = "21")]
		public IEnumerable<Renderer> JMPBKDADJMM(MBMDFMFPNAN MNGLAEJHIMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7710", Offset = "0x5EF6110", VA = "0x185EF7710", Slot = "12")]
		public FJJFPEDBHPI FJACDNHFPCG(BODGOGPJPCI MNILNHMNKJK)
		{
			return default(FJJFPEDBHPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7430", Offset = "0x5EF5E30", VA = "0x185EF7430", Slot = "14")]
		public void AJNABDFLCPI(FJJFPEDBHPI HCDHIDGLLCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7820", Offset = "0x5EF6220", VA = "0x185EF7820", Slot = "16")]
		public Task IOAFIOMINDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7950", Offset = "0x5EF6350", VA = "0x185EF7950", Slot = "17")]
		public Task JPFKBNJBFJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7880", Offset = "0x5EF6280", VA = "0x185EF7880", Slot = "18")]
		public Task JJLCLFINEEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x10BCBB0", Offset = "0x10BB5B0", VA = "0x1810BCBB0", Slot = "19")]
		public void JFBIDGLNNHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5EF74A0", Offset = "0x5EF5EA0", VA = "0x185EF74A0", Slot = "13")]
		public void DABJCHDHKDD(FJJFPEDBHPI HCDHIDGLLCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7D40", Offset = "0x5EF6740", VA = "0x185EF7D40", Slot = "20")]
		public ACPOPPMDKCO NGNFGBGFABP(CKMNGIKNHCP EOBMBNKEPGB, IEnumerable<DBOPJIDEMLD> HPHNCADMINP, int LLODPCJCIKF)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class KMLCACCIBFD : LNFIJKJHIPO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class ONGBOGAJPJB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public KMLCACCIBFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		[DebuggerHidden]
		public ONGBOGAJPJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5640", Offset = "0x5EF4040", VA = "0x185EF5640", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5360", Offset = "0x5EF3D60", VA = "0x185EF5360", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF56C0", Offset = "0x5EF40C0", VA = "0x185EF56C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5600", Offset = "0x5EF4000", VA = "0x185EF5600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5560", Offset = "0x5EF3F60", VA = "0x185EF5560", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5560", Offset = "0x5EF3F60", VA = "0x185EF5560", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly BODGOGPJPCI DMJHDGJOJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly APMLJHCGADL GJDLDJDHFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private COAAILEKPDB JIAOILBMALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private List<LHILEACLCKE> KHGOPPMPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private List<LHILEACLCKE> GDGJCJIEKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private GameObject HDCHAJPKGHE;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEB10", Offset = "0x5EED510", VA = "0x185EEEB10")]
	public static KMLCACCIBFD JJAOEPJHCAC(BODGOGPJPCI MNILNHMNKJK, APMLJHCGADL GJDLDJDHFAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF3A0", Offset = "0x5EEDDA0", VA = "0x185EEF3A0")]
	private KMLCACCIBFD(BODGOGPJPCI MNILNHMNKJK, APMLJHCGADL GJDLDJDHFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEEC0", Offset = "0x5EED8C0", VA = "0x185EEEEC0")]
	public void NOOJKGDANLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEA00", Offset = "0x5EED400", VA = "0x185EEEA00")]
	[IteratorStateMachine(typeof(ONGBOGAJPJB))]
	public IEnumerable<Renderer> BEJAPPGGLEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5EEDF20", Offset = "0x5EEC920", VA = "0x185EEDF20", Slot = "4")]
	public void ACKKIAPCMGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEA70", Offset = "0x5EED470", VA = "0x185EEEA70")]
	private void BKGJIJEOMGE(Vector3 FFPMBENCDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEC80", Offset = "0x5EED680", VA = "0x185EEEC80")]
	public void LHJKKDLNDBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class LHILEACLCKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct IKEEGDCMOMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public EGKHIBAHBGL BAOJAENLAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CKMNGIKNHCP KNAHJCFCHJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int DMGPNDOJPDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FJBJINFGOMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public LHILEACLCKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public JKFPCBLPBIJ lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public List<IKEEGDCMOMC> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public ACPOPPMDKCO combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public FJBJINFGOMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC440", Offset = "0x5EEAE40", VA = "0x185EEC440")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC4A0", Offset = "0x5EEAEA0", VA = "0x185EEC4A0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC4D0", Offset = "0x5EEAED0", VA = "0x185EEC4D0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int[] ICHOHHLDJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private BCDJAFLOJFF EBIDMGICALJ;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static Matrix4x4 FKFCAKGMKHG;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Mesh PBBGMNPICBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7D2880", Offset = "0x7D1280", VA = "0x1807D2880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int OKKGHEPCMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x767550", Offset = "0x765F50", VA = "0x180767550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x767540", Offset = "0x765F40", VA = "0x180767540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0050", Offset = "0x5EEEA50", VA = "0x185EF0050")]
	public void LOFEJKDHKDM(List<CKMNGIKNHCP> MCJLJPLJIAO, Matrix4x4[] ANJJGHLMKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFA20", Offset = "0x5EEE420", VA = "0x185EEFA20")]
	public static List<LHILEACLCKE> KMLFLFAGFOK(List<PHPKNLKOCDC> FFFOKGOHJGN, JKFPCBLPBIJ BIMLEJNEELL, Bounds FPIHAEEIAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF640", Offset = "0x5EEE040", VA = "0x185EEF640")]
	private JobHandle EFDDCHIDJCN(ACPOPPMDKCO MFJKFEBJPBD, int DFLFKJIGGMB, int JJBIKAMAINK, JKFPCBLPBIJ BIMLEJNEELL, List<IKEEGDCMOMC> BDJFFELICBG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF4A0", Offset = "0x5EEDEA0", VA = "0x185EEF4A0")]
	private void CBDOEMKHDLE(List<IKEEGDCMOMC> BDJFFELICBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5EF03B0", Offset = "0x5EEEDB0", VA = "0x185EF03B0")]
	private LHILEACLCKE(List<IKEEGDCMOMC> BDJFFELICBG, int DFLFKJIGGMB, int JJBIKAMAINK, JKFPCBLPBIJ BIMLEJNEELL, Bounds FPIHAEEIAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF5B0", Offset = "0x5EEDFB0", VA = "0x185EEF5B0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private MaterialPropertyBlock DAJEJNPIAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private LHILEACLCKE OLBANABBMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private List<CKMNGIKNHCP> MMHGGBDPJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private RenderTexture BLLNPIJGLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private ComputeBuffer EEBEIDELOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private ComputeShader LGIMAPFHENB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Matrix4x4[] NPOIHFPPJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int CHBBKLCMOKL;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public MeshRenderer FJEIEAHOEFH
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x7D2590", Offset = "0x7D0F90", VA = "0x1807D2590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int FMJPBBFHFKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x5EF92E0", Offset = "0x5EF7CE0", VA = "0x185EF92E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8650", Offset = "0x5EF7050", VA = "0x185EF8650")]
		public static List<SkinnedShapeRenderer> Create(GameObject MNGLAEJHIMG, List<LHILEACLCKE> GELAGMINEAF, List<CKMNGIKNHCP> MMHGGBDPJHE, Material NCNMCMAJCOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8AD0", Offset = "0x5EF74D0", VA = "0x185EF8AD0")]
		public void Init(LHILEACLCKE OLBANABBMBP, List<CKMNGIKNHCP> MMHGGBDPJHE, Material NCNMCMAJCOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9230", Offset = "0x5EF7C30", VA = "0x185EF9230")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9180", Offset = "0x5EF7B80", VA = "0x185EF9180")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9140", Offset = "0x5EF7B40", VA = "0x185EF9140")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5EF88A0", Offset = "0x5EF72A0", VA = "0x185EF88A0")]
		private void HIAINEGFMJD(ScriptableRenderContext BKJKDPLKCNE, Camera[] BCHPPHCMEMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8F80", Offset = "0x5EF7980", VA = "0x185EF8F80")]
		private void LOFEJKDHKDM(CommandBuffer IJJCPCJHFGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	internal class _RRAssemblyIndex : IAAKGJNKLFL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9B70", Offset = "0x5EF8570", VA = "0x185EF9B70", Slot = "4")]
		public sealed override void BGMNFOJPGJK()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2910", Offset = "0x5EF1310", VA = "0x185EF2910")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2A20", Offset = "0x5EF1420", VA = "0x185EF2A20")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
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
