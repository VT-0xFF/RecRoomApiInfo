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
public enum LBIJLLBELJH
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
public static class DFCGFOLPPCI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x58B1C60", Offset = "0x58B0A60", VA = "0x1858B1C60")]
	public static bool EAEHAMDAGHG(this LBIJLLBELJH EJHBLDNJNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x58B1C80", Offset = "0x58B0A80", VA = "0x1858B1C80")]
	public static bool FBDBEJDDAJK(this LBIJLLBELJH EJHBLDNJNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x58B1C90", Offset = "0x58B0A90", VA = "0x1858B1C90")]
	public static bool MGIIFGHGCOP(this LBIJLLBELJH EJHBLDNJNCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NELEAKGOPNB
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
public enum ECMPNDFFGLH
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
public enum MAKIJPKOCCA
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
public enum MNJIAAJBDBC
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
public class IIKGLPAOOPA : IHCPNPJBNNO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte CEEEBILPNMA = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte LFANJHDPPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] KDHPOKPNJBO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IHHFNEMHOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F68E0", Offset = "0x6F56E0", VA = "0x1806F68E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B3FE0", Offset = "0x7B2DE0", VA = "0x1807B3FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GOGAGNOLANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B57D0", Offset = "0x7B45D0", VA = "0x1807B57D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A7610", Offset = "0x8A6410", VA = "0x1808A7610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float OLJIAFAILMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9022E0", Offset = "0x9010E0", VA = "0x1809022E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9027E0", Offset = "0x9015E0", VA = "0x1809027E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float HBMHCGBEAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8EA460", Offset = "0x8E9260", VA = "0x1808EA460", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8EA470", Offset = "0x8E9270", VA = "0x1808EA470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> GLAFBGCPKDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x58B8820", Offset = "0x58B7620", VA = "0x1858B8820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> JFFFAOCPAJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x58B8750", Offset = "0x58B7550", VA = "0x1858B8750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject CAHHKGJGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x763EF0", VA = "0x1807650F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte BAEPJIAOPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x58B8790", Offset = "0x58B7590", VA = "0x1858B8790", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x58B8880", Offset = "0x58B7680", VA = "0x1858B8880")]
	public IIKGLPAOOPA(List<GFFAKKBNBMI> GGPFMIMCGHC, List<GFFAKKBNBMI> ALDKHDJLJID, List<MCIOIOFPDFL> MKIMOHADGDP, Material LOCCEEIOOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x58B8320", Offset = "0x58B7120", VA = "0x1858B8320")]
	private int ANHOKDNAKKK(List<GFFAKKBNBMI> FBLHLFIHHNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x58B84D0", Offset = "0x58B72D0", VA = "0x1858B84D0")]
	private void CNCGOJAGBAJ(int ADCJKHMEEKC, bool KOFABCECKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x58B8430", Offset = "0x58B7230", VA = "0x1858B8430")]
	public void CFIJCANGBKJ(Vector3 HAODALHLFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x58B8620", Offset = "0x58B7420", VA = "0x1858B8620", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x58B87E0", Offset = "0x58B75E0", VA = "0x1858B87E0")]
	public void OAJNNPOOMBA(Transform AGNPKKPHLAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AMGPFEOAJAJ : EHJLDPDJAEP, EBNCAOHEHMH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NDAKIKEENMA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public AMGPFEOAJAJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x793410", Offset = "0x792210", VA = "0x180793410")]
		[DebuggerHidden]
		public NDAKIKEENMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x58BBBF0", Offset = "0x58BA9F0", VA = "0x1858BBBF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x58BB6C0", Offset = "0x58BA4C0", VA = "0x1858BB6C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x58BBCF0", Offset = "0x58BAAF0", VA = "0x1858BBCF0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x58BBD40", Offset = "0x58BAB40", VA = "0x1858BBD40")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x58BBD90", Offset = "0x58BAB90", VA = "0x1858BBD90")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x58BBBB0", Offset = "0x58BA9B0", VA = "0x1858BBBB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x58BBB10", Offset = "0x58BA910", VA = "0x1858BBB10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x58BBB10", Offset = "0x58BA910", VA = "0x1858BBB10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LPFJMEJBJEH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public AMGPFEOAJAJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x793410", Offset = "0x792210", VA = "0x180793410")]
		[DebuggerHidden]
		public LPFJMEJBJEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x58BB130", Offset = "0x58B9F30", VA = "0x1858BB130", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x58BAD70", Offset = "0x58B9B70", VA = "0x1858BAD70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x58BB210", Offset = "0x58BA010", VA = "0x1858BB210")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x58BB260", Offset = "0x58BA060", VA = "0x1858BB260")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x58BB0F0", Offset = "0x58B9EF0", VA = "0x1858BB0F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x58BB050", Offset = "0x58B9E50", VA = "0x1858BB050", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x58BB050", Offset = "0x58B9E50", VA = "0x1858BB050", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CCCBIEDCGAI CMCBGOOHMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<IGHOKCPMJBC> JFIEAHBGPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> NCDLKLALJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer DNKNEHGJGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool BKKIJELIBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool FGOOAJNDKME;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<PHHKHDHCLGL> IOKEMHJAFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MJELDHBMDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x58AEBD0", Offset = "0x58AD9D0", VA = "0x1858AEBD0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MCIOIOFPDFL KNHPOAAIDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x58B0240", Offset = "0x58AF040", VA = "0x1858B0240", Slot = "7")]
		get
		{
			return default(MCIOIOFPDFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> JOKNHOOCCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7830", Offset = "0x6F6630", VA = "0x1806F7830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x58B0220", Offset = "0x58AF020", VA = "0x1858B0220")]
	private bool PIEHNBFHOOE(IGHOKCPMJBC KCOKCMMPFBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x58AFC70", Offset = "0x58AEA70", VA = "0x1858AFC70")]
	private static bool IOCHHGJGAFF(IGHOKCPMJBC KCOKCMMPFBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x58B0310", Offset = "0x58AF110", VA = "0x1858B0310")]
	public AMGPFEOAJAJ(CCCBIEDCGAI PHAPMEHMHAK, bool CLCBMCNBNJD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x58AF1E0", Offset = "0x58ADFE0", VA = "0x1858AF1E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x58AED70", Offset = "0x58ADB70", VA = "0x1858AED70")]
	public void AHKNMMEAEHA(IGHOKCPMJBC KCOKCMMPFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x58AF910", Offset = "0x58AE710", VA = "0x1858AF910")]
	public void IHKCCNMHHEB(IGHOKCPMJBC KCOKCMMPFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x58AF3A0", Offset = "0x58AE1A0", VA = "0x1858AF3A0", Slot = "4")]
	public void HAGEHGKKBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x58AEF20", Offset = "0x58ADD20", VA = "0x1858AEF20")]
	public void CAMMFFCGHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x58AFAE0", Offset = "0x58AE8E0", VA = "0x1858AFAE0")]
	private void IJCGLHBOOAG(List<IGHOKCPMJBC> JFIEAHBGPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x58AF340", Offset = "0x58AE140", VA = "0x1858AF340")]
	private static Material FIPMEOCFLCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x58AFA40", Offset = "0x58AE840", VA = "0x1858AFA40")]
	private void IJCGLHBOOAG(IGHOKCPMJBC KCOKCMMPFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x58AECA0", Offset = "0x58ADAA0", VA = "0x1858AECA0")]
	private void AHDIDAOIHGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x58AFD00", Offset = "0x58AEB00", VA = "0x1858AFD00")]
	public void LDBGIEANEOF(bool IPGHLNCJBJD, bool PCFEIIHNAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x58AEC10", Offset = "0x58ADA10", VA = "0x1858AEC10")]
	protected void AALDBDHIANG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x58AF170", Offset = "0x58ADF70", VA = "0x1858AF170")]
	[IteratorStateMachine(typeof(NDAKIKEENMA))]
	public IEnumerable<Renderer> CBGOGFBBIDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x58AFC90", Offset = "0x58AEA90", VA = "0x1858AFC90")]
	[IteratorStateMachine(typeof(LPFJMEJBJEH))]
	public IEnumerable<Renderer> LAFOHPGAJAP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class BPLIEPDFILO : IGHOKCPMJBC
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private struct HPLCMGNODOO : AFGLMFJIDHM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private GHDHHNDLKIN DPOJLBHHPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private JobHandle FMCMEMBCJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private MEJGHHLIEEO PFHCBOLENHN;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x58B5F40", Offset = "0x58B4D40", VA = "0x1858B5F40")]
		public HPLCMGNODOO(GHDHHNDLKIN DPOJLBHHPEO, JobHandle FMCMEMBCJOJ, MEJGHHLIEEO PFHCBOLENHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x944F20", Offset = "0x943D20", VA = "0x180944F20")]
		public bool AMFLHOGACPG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x58B5F10", Offset = "0x58B4D10", VA = "0x1858B5F10", Slot = "4")]
		public GHDHHNDLKIN EMMGNHCOPMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x58B5EC0", Offset = "0x58B4CC0", VA = "0x1858B5EC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly AEFKAFHFDMD MDDGLHEDGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private float MKNPNLAGLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Hash128 MIHNGALGEDA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 NNNMKHFMAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x58B12B0", Offset = "0x58B00B0", VA = "0x1858B12B0", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x58B1AE0", Offset = "0x58B08E0", VA = "0x1858B1AE0")]
	public BPLIEPDFILO(AMGPFEOAJAJ DCJJENKGKJB, AEFKAFHFDMD PHAPMEHMHAK, bool CLCBMCNBNJD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "16")]
	public override bool OJIOIHECIHF(MCIOIOFPDFL DCJJENKGKJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x58B0560", Offset = "0x58AF360", VA = "0x1858B0560", Slot = "18")]
	public override int ANHOKDNAKKK(NNCAOIFLNAP NJPOLOKEGLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x58B09E0", Offset = "0x58AF7E0", VA = "0x1858B09E0", Slot = "19")]
	public override int ECGGLFKKIHO(NNCAOIFLNAP NJPOLOKEGLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x58B0BD0", Offset = "0x58AF9D0", VA = "0x1858B0BD0", Slot = "20")]
	public override void EDNGPAEMOMJ(NNCAOIFLNAP NJPOLOKEGLO, HJIHHAKMHAF AFHHJDDLHFP, int EPONHLONMOH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x58B0910", Offset = "0x58AF710", VA = "0x1858B0910", Slot = "21")]
	public override MCIOIOFPDFL BMNKFDJOEBA()
	{
		return default(MCIOIOFPDFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x58B0750", Offset = "0x58AF550", VA = "0x1858B0750", Slot = "23")]
	public override AKOEJLBFINE BEILNAPNBBI()
	{
		return default(AKOEJLBFINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x58B13E0", Offset = "0x58B01E0", VA = "0x1858B13E0", Slot = "24")]
	public override AFGLMFJIDHM PCGJEHNLJHC(NNCAOIFLNAP NJPOLOKEGLO, JobHandle FMCMEMBCJOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BFDJKPKHKDA : global::IODKAPMFEOL<BFDJKPKHKDA>, MNGNANHHIDL, IEquatable<BFDJKPKHKDA>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int HGGIJKLHICO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x73BCB0", Offset = "0x73AAB0", VA = "0x18073BCB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x73D530", Offset = "0x73C330", VA = "0x18073D530", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	[CreateProperty]
	public int LFENOMEJLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x795660", Offset = "0x794460", VA = "0x180795660", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x795670", Offset = "0x794470", VA = "0x180795670", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool FFNEOGDCCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x58B0490", Offset = "0x58AF290", VA = "0x1858B0490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x11265E0", Offset = "0x11253E0", VA = "0x1811265E0", Slot = "8")]
	public bool Equals(BFDJKPKHKDA ONICAEEHHFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xE53810", Offset = "0xE52610", VA = "0x180E53810")]
	public static bool LHMNPGMNIAC(BFDJKPKHKDA FEIPFLDEPBD, BFDJKPKHKDA MIECAKFJHNF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xE538A0", Offset = "0xE526A0", VA = "0x180E538A0")]
	public static bool NGBHPPLJJAJ(BFDJKPKHKDA FEIPFLDEPBD, BFDJKPKHKDA MIECAKFJHNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x58B0400", Offset = "0x58AF200", VA = "0x1858B0400", Slot = "0")]
	public override bool Equals(object BLIKPCIFNNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x73BCB0", Offset = "0x73AAB0", VA = "0x18073BCB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x58B04D0", Offset = "0x58AF2D0", VA = "0x1858B04D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum IBDIPILGJGH
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
public interface CCCBIEDCGAI
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	MCIOIOFPDFL OBACKBELLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	IBDIPILGJGH NPOEGFLPPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HCKICCDKCEO : global::IODKAPMFEOL<HCKICCDKCEO>, MNGNANHHIDL, IEquatable<HCKICCDKCEO>
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int HGGIJKLHICO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x73BCB0", Offset = "0x73AAB0", VA = "0x18073BCB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x73D530", Offset = "0x73C330", VA = "0x18073D530", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	[CreateProperty]
	public int LFENOMEJLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x795660", Offset = "0x794460", VA = "0x180795660", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x795670", Offset = "0x794470", VA = "0x180795670", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FFNEOGDCCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x58B5DA0", Offset = "0x58B4BA0", VA = "0x1858B5DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x11265E0", Offset = "0x11253E0", VA = "0x1811265E0", Slot = "8")]
	public bool Equals(HCKICCDKCEO ONICAEEHHFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xE53810", Offset = "0xE52610", VA = "0x180E53810")]
	public static bool LHMNPGMNIAC(HCKICCDKCEO FEIPFLDEPBD, HCKICCDKCEO MIECAKFJHNF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xE538A0", Offset = "0xE526A0", VA = "0x180E538A0")]
	public static bool NGBHPPLJJAJ(HCKICCDKCEO FEIPFLDEPBD, HCKICCDKCEO MIECAKFJHNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x58B5D10", Offset = "0x58B4B10", VA = "0x1858B5D10", Slot = "0")]
	public override bool Equals(object BLIKPCIFNNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x73BCB0", Offset = "0x73AAB0", VA = "0x18073BCB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x58B5DE0", Offset = "0x58B4BE0", VA = "0x1858B5DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GFKCGMNKEFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LLEPEKBOKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool MNEMALJBMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	MCIOIOFPDFL OBACKBELLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float KKOOLFOGDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 FCNCDDACINM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	LBIJLLBELJH NLCGBLKIOGB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	NELEAKGOPNB LJFNBOMOMGP
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
public interface OACDPFEEFFM : GFKCGMNKEFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	GOLKODHAGHB ELEMEJHJFAH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool HPOKIOKMIPO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AEFKAFHFDMD : GFKCGMNKEFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool MCMJAILEHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool CBLHDDKIAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	float GDOBLLHJAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int DNHLOAICMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool MABDOMOCJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int EDHOGHMCGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<KJNGKNEKMCI> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MGOJCFBMPIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FALIPHFJKDG(BFDJKPKHKDA DCJJENKGKJB, MAKIJPKOCCA FCFGABEKNGB);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FALIPHFJKDG(HCKICCDKCEO KCOKCMMPFBD, MAKIJPKOCCA FCFGABEKNGB);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KOMOGAFNNLF(HCKICCDKCEO KCOKCMMPFBD);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MODHIEOMIJF(HCKICCDKCEO KCOKCMMPFBD);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODJPOHKBFFH();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HBPLPIFPFPC();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IPODOAAOFAM(MAKIJPKOCCA MAIOHDHBGKE);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LMAIGONMPAC(BFDJKPKHKDA DCJJENKGKJB);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LMAIGONMPAC(HCKICCDKCEO KCOKCMMPFBD);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IBINGIHJABG(BFDJKPKHKDA DCJJENKGKJB, MNJIAAJBDBC MAIOHDHBGKE);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IBINGIHJABG(HCKICCDKCEO KCOKCMMPFBD, MNJIAAJBDBC MAIOHDHBGKE);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DKEOAJGCCCI(HCKICCDKCEO KCOKCMMPFBD);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GEKEJNEFPAE(HCKICCDKCEO KCOKCMMPFBD);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DFHFCPAKAHA();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IPKCNFEEENI();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KMCGNIPMJPI(MNJIAAJBDBC MAIOHDHBGKE);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EOAHMKIBJOG(BFDJKPKHKDA DCJJENKGKJB, Vector3 PEEEIKKODFL, Vector3 BBNDBFFBGFH, Vector3 CBGKOLHFKKF, float LEGGLBNBIHN, float ABIMLPEMKPF, IReadOnlyList<Camera> JMPONEDPIFP, ECMPNDFFGLH FNBCEOKGCFD);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EOAHMKIBJOG(DCIICICAEFC JOHOCEAAAEE, Vector3 PEEEIKKODFL, Vector3 BBNDBFFBGFH, Vector3 CBGKOLHFKKF, float LEGGLBNBIHN, float ABIMLPEMKPF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public interface AJFGIMDDKOA
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	AMGPFEOAJAJ MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	IGHOKCPMJBC MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NFEAKLKJGLE MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NLDDHBHLADK : AJFGIMDDKOA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool IIKNONNALOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFDJKPKHKDA NKNCCPJAIPM(CCCBIEDCGAI PHAPMEHMHAK);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BFDJKPKHKDA NKNCCPJAIPM(CCCBIEDCGAI PHAPMEHMHAK, bool PMEJPOMBFMN);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HJFIOLICGDB(BFDJKPKHKDA DCJJENKGKJB);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNLCEJLCJMJ(BFDJKPKHKDA DCJJENKGKJB);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HCKICCDKCEO DKMBIFADFPN(BFDJKPKHKDA DCJJENKGKJB, OACDPFEEFFM PHAPMEHMHAK);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HCKICCDKCEO MIANLECLGDN(BFDJKPKHKDA DCJJENKGKJB, AEFKAFHFDMD PHAPMEHMHAK);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DADOCPBHOOK(HCKICCDKCEO KCOKCMMPFBD);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BHEDAHOMPPL(HCKICCDKCEO KCOKCMMPFBD);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DCIICICAEFC PKCDGGGBBGM(OAMIOGINHII PHAPMEHMHAK);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KKKDMAMPGJN(DCIICICAEFC JOHOCEAAAEE);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OCIDKCPHFBC(DCIICICAEFC JOHOCEAAAEE);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task APCIGICIKHF();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task IANKCGPALBM();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task CAAFNNHHHDO();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MHDGJOIOIKH();

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	GHDHHNDLKIN DBBDAECGKAG(MCIOIOFPDFL ANLLMACALFD, IEnumerable<HCKICCDKCEO> JFIEAHBGPCJ, int EJIFJDIILDE);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerable<Renderer> FHFDKNODEBH(BFDJKPKHKDA DCJJENKGKJB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DCIICICAEFC : global::IODKAPMFEOL<DCIICICAEFC>, MNGNANHHIDL, IEquatable<DCIICICAEFC>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int HGGIJKLHICO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x73BCB0", Offset = "0x73AAB0", VA = "0x18073BCB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x73D530", Offset = "0x73C330", VA = "0x18073D530", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int LFENOMEJLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x795660", Offset = "0x794460", VA = "0x180795660", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x795670", Offset = "0x794470", VA = "0x180795670", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FFNEOGDCCGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x58B1C20", Offset = "0x58B0A20", VA = "0x1858B1C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x11265E0", Offset = "0x11253E0", VA = "0x1811265E0", Slot = "8")]
	public bool Equals(DCIICICAEFC ONICAEEHHFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xE53810", Offset = "0xE52610", VA = "0x180E53810")]
	public static bool LHMNPGMNIAC(DCIICICAEFC FEIPFLDEPBD, DCIICICAEFC MIECAKFJHNF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xE538A0", Offset = "0xE526A0", VA = "0x180E538A0")]
	public static bool NGBHPPLJJAJ(DCIICICAEFC FEIPFLDEPBD, DCIICICAEFC MIECAKFJHNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x58B1B90", Offset = "0x58B0990", VA = "0x1858B1B90", Slot = "0")]
	public override bool Equals(object BLIKPCIFNNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x73BCB0", Offset = "0x73AAB0", VA = "0x18073BCB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OAMIOGINHII
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	int HOFDANGGLJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Transform JBDIFKCCGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool ODOLCNLAEJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BFDJKPKHKDA GetBone(int BOKNKNHPOPL);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int BOKNKNHPOPL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public class GHALCJCNDEG : NLDDHBHLADK, AJFGIMDDKOA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct LIDLPHMNJDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public GHALCJCNDEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x58BA8D0", Offset = "0x58B96D0", VA = "0x1858BA8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x14868C0", Offset = "0x14856C0", VA = "0x1814868C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly global::LHIFGMDEFMC<BFDJKPKHKDA, AMGPFEOAJAJ> JDMLFNGHGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly global::LHIFGMDEFMC<HCKICCDKCEO, IGHOKCPMJBC> JFIEAHBGPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly global::LHIFGMDEFMC<DCIICICAEFC, NFEAKLKJGLE> PJBIOIKHHND;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public AMGPFEOAJAJ MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x58B3650", Offset = "0x58B2450", VA = "0x1858B3650", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IGHOKCPMJBC MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x58B3710", Offset = "0x58B2510", VA = "0x1858B3710", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NFEAKLKJGLE MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x58B36B0", Offset = "0x58B24B0", VA = "0x1858B36B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool IIKNONNALOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x82D580", Offset = "0x82C380", VA = "0x18082D580", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x82D600", Offset = "0x82C400", VA = "0x18082D600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x58B5850", Offset = "0x58B4650", VA = "0x1858B5850")]
	public GHALCJCNDEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x58B48C0", Offset = "0x58B36C0", VA = "0x1858B48C0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x58B5750", Offset = "0x58B4550", VA = "0x1858B5750", Slot = "4")]
	public BFDJKPKHKDA NKNCCPJAIPM(CCCBIEDCGAI PHAPMEHMHAK)
	{
		return default(BFDJKPKHKDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x58B54B0", Offset = "0x58B42B0", VA = "0x1858B54B0", Slot = "5")]
	public BFDJKPKHKDA NKNCCPJAIPM(CCCBIEDCGAI PHAPMEHMHAK, bool CLCBMCNBNJD)
	{
		return default(BFDJKPKHKDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x58B4AD0", Offset = "0x58B38D0", VA = "0x1858B4AD0", Slot = "6")]
	public void HJFIOLICGDB(BFDJKPKHKDA DCJJENKGKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x58B4530", Offset = "0x58B3330", VA = "0x1858B4530", Slot = "7")]
	public void DNLCEJLCJMJ(BFDJKPKHKDA DCJJENKGKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x58B4020", Offset = "0x58B2E20", VA = "0x1858B4020", Slot = "8")]
	public HCKICCDKCEO DKMBIFADFPN(BFDJKPKHKDA DCJJENKGKJB, OACDPFEEFFM PHAPMEHMHAK)
	{
		return default(HCKICCDKCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x58B4FA0", Offset = "0x58B3DA0", VA = "0x1858B4FA0", Slot = "9")]
	public HCKICCDKCEO MIANLECLGDN(BFDJKPKHKDA DCJJENKGKJB, AEFKAFHFDMD PHAPMEHMHAK)
	{
		return default(HCKICCDKCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x58B3150", Offset = "0x58B1F50", VA = "0x1858B3150", Slot = "11")]
	public void BHEDAHOMPPL(HCKICCDKCEO KCOKCMMPFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x58B3770", Offset = "0x58B2570", VA = "0x1858B3770", Slot = "10")]
	public void DADOCPBHOOK(HCKICCDKCEO KCOKCMMPFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x58B4A60", Offset = "0x58B3860", VA = "0x1858B4A60", Slot = "21")]
	public IEnumerable<Renderer> FHFDKNODEBH(BFDJKPKHKDA DCJJENKGKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x58B57D0", Offset = "0x58B45D0", VA = "0x1858B57D0", Slot = "12")]
	public DCIICICAEFC PKCDGGGBBGM(OAMIOGINHII PHAPMEHMHAK)
	{
		return default(DCIICICAEFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x58B5760", Offset = "0x58B4560", VA = "0x1858B5760", Slot = "14")]
	public void OCIDKCPHFBC(DCIICICAEFC JOHOCEAAAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x58B2FE0", Offset = "0x58B1DE0", VA = "0x1858B2FE0", Slot = "16")]
	public Task APCIGICIKHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x58B4D50", Offset = "0x58B3B50", VA = "0x1858B4D50", Slot = "17")]
	public Task IANKCGPALBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x58B3550", Offset = "0x58B2350", VA = "0x1858B3550", Slot = "18")]
	[AsyncStateMachine(typeof(LIDLPHMNJDD))]
	public Task CAAFNNHHHDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x58B4F10", Offset = "0x58B3D10", VA = "0x1858B4F10", Slot = "19")]
	public void MHDGJOIOIKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x58B4EB0", Offset = "0x58B3CB0", VA = "0x1858B4EB0", Slot = "13")]
	public void KKKDMAMPGJN(DCIICICAEFC JOHOCEAAAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x58B39F0", Offset = "0x58B27F0", VA = "0x1858B39F0", Slot = "20")]
	public GHDHHNDLKIN DBBDAECGKAG(MCIOIOFPDFL PDOKGEDOHHO, IEnumerable<HCKICCDKCEO> JFIEAHBGPCJ, int EJIFJDIILDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class IIHDHFJBKLL : IGHOKCPMJBC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct PFNKPFCEHDG : AFGLMFJIDHM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private GHDHHNDLKIN DPOJLBHHPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private JobHandle FMCMEMBCJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private ODAIHOKOFBB PFHCBOLENHN;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x58BF800", Offset = "0x58BE600", VA = "0x1858BF800")]
		public PFNKPFCEHDG(GHDHHNDLKIN DPOJLBHHPEO, JobHandle FMCMEMBCJOJ, ODAIHOKOFBB PFHCBOLENHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x944F20", Offset = "0x943D20", VA = "0x180944F20")]
		public bool AMFLHOGACPG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x58BF7D0", Offset = "0x58BE5D0", VA = "0x1858BF7D0", Slot = "4")]
		public GHDHHNDLKIN EMMGNHCOPMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x58BF780", Offset = "0x58BE580", VA = "0x1858BF780", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly OACDPFEEFFM JAJACAKHBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int[] KFPCCEHFLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private float MKNPNLAGLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Hash128 MIHNGALGEDA;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override MPLDDCIADOK NJJPGGJPFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x58B7450", Offset = "0x58B6250", VA = "0x1858B7450", Slot = "17")]
		get
		{
			return default(MPLDDCIADOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private Vector3 DNGBHMKGMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x58B61C0", Offset = "0x58B4FC0", VA = "0x1858B61C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected override Hash128 NNNMKHFMAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x58B7320", Offset = "0x58B6120", VA = "0x1858B7320", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x58B8270", Offset = "0x58B7070", VA = "0x1858B8270")]
	public IIHDHFJBKLL(AMGPFEOAJAJ DCJJENKGKJB, OACDPFEEFFM PHAPMEHMHAK, bool PBMIKEHOJGE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x58B7800", Offset = "0x58B6600", VA = "0x1858B7800", Slot = "16")]
	public override bool OJIOIHECIHF(MCIOIOFPDFL DCJJENKGKJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x58B6510", Offset = "0x58B5310", VA = "0x1858B6510", Slot = "18")]
	public override int ANHOKDNAKKK(NNCAOIFLNAP NJPOLOKEGLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x58B6B00", Offset = "0x58B5900", VA = "0x1858B6B00", Slot = "19")]
	public override int ECGGLFKKIHO(NNCAOIFLNAP NJPOLOKEGLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x58B6850", Offset = "0x58B5650", VA = "0x1858B6850")]
	private int DPHKPAJFKLL(NNCAOIFLNAP NJPOLOKEGLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x58B6BB0", Offset = "0x58B59B0", VA = "0x1858B6BB0", Slot = "20")]
	public override void EDNGPAEMOMJ(NNCAOIFLNAP NJPOLOKEGLO, HJIHHAKMHAF AFHHJDDLHFP, int EPONHLONMOH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x58B6780", Offset = "0x58B5580", VA = "0x1858B6780", Slot = "21")]
	public override MCIOIOFPDFL BMNKFDJOEBA()
	{
		return default(MCIOIOFPDFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x58B65C0", Offset = "0x58B53C0", VA = "0x1858B65C0", Slot = "23")]
	public override AKOEJLBFINE BEILNAPNBBI()
	{
		return default(AKOEJLBFINE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x58B7C70", Offset = "0x58B6A70", VA = "0x1858B7C70", Slot = "24")]
	public override AFGLMFJIDHM PCGJEHNLJHC(NNCAOIFLNAP NJPOLOKEGLO, JobHandle FMCMEMBCJOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface MMDGCPEKILH
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEIPJFJKKHF(MNJIAAJBDBC MAIOHDHBGKE, Renderer KDGFFBEDMIA, int BEDJGOBBDIG);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLHFCHAFFHF(Renderer KDGFFBEDMIA, ECMPNDFFGLH FNBCEOKGCFD, Vector3 PEEEIKKODFL, Vector3 BBNDBFFBGFH, Vector3 CBGKOLHFKKF, float LEGGLBNBIHN, float ABIMLPEMKPF, float DLBLGNBBCCG = -1f, [Optional] Color? HCHGJCCJIHO, [Optional] IReadOnlyList<Camera> EJJBEJILLFG);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIFPHGOBEAF(Renderer KDGFFBEDMIA, int BEDJGOBBDIG);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IMKCFCLAGKE();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GLKGPAGCLDJ(int PLKKBLKALEF, MAKIJPKOCCA MAIOHDHBGKE, Renderer KDGFFBEDMIA, int BEDJGOBBDIG);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OFOLCIACAHD : MGOJCFBMPIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class HIBNOGNPBAA : global::OAALLDDIGDP<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x58B5E70", Offset = "0x58B4C70", VA = "0x1858B5E70")]
		public HIBNOGNPBAA(string EOPECGOILOC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly MMDGCPEKILH EBMJEPNBHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly AJFGIMDDKOA ODGBACODPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MeshRenderer BAHNMAOHCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private HIBNOGNPBAA MKFBAPAPGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool NCFFIDFIGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MeshRenderer OKKADCDLJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private HIBNOGNPBAA OBLBPNBJPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool POPBBLAIJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private MeshRenderer KPDMLELLHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private HIBNOGNPBAA OCOKJADDIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool LKLAHNKMKAI;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x87BC00", Offset = "0x87AA00", VA = "0x18087BC00")]
	public OFOLCIACAHD(MMDGCPEKILH GGIJIFDHMIL, AJFGIMDDKOA ODGBACODPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x58BD440", Offset = "0x58BC240", VA = "0x1858BD440", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x58BEA10", Offset = "0x58BD810", VA = "0x1858BEA10")]
	private void KJPAKEFIDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x58BDFD0", Offset = "0x58BCDD0", VA = "0x1858BDFD0", Slot = "4")]
	public void FALIPHFJKDG(BFDJKPKHKDA DCJJENKGKJB, MAKIJPKOCCA FCFGABEKNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x58BDDB0", Offset = "0x58BCBB0", VA = "0x1858BDDB0", Slot = "5")]
	public void FALIPHFJKDG(HCKICCDKCEO KCOKCMMPFBD, MAKIJPKOCCA FCFGABEKNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x58BEDA0", Offset = "0x58BDBA0", VA = "0x1858BEDA0", Slot = "6")]
	public void KOMOGAFNNLF(HCKICCDKCEO KCOKCMMPFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x58BF3D0", Offset = "0x58BE1D0", VA = "0x1858BF3D0", Slot = "7")]
	public void MODHIEOMIJF(HCKICCDKCEO KCOKCMMPFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x58BF4F0", Offset = "0x58BE2F0", VA = "0x1858BF4F0", Slot = "8")]
	public void ODJPOHKBFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x17672E0", Offset = "0x17660E0", VA = "0x1817672E0", Slot = "9")]
	public void HBPLPIFPFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x58BE8A0", Offset = "0x58BD6A0", VA = "0x1858BE8A0", Slot = "10")]
	public void IPODOAAOFAM(MAKIJPKOCCA FCFGABEKNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x58BF220", Offset = "0x58BE020", VA = "0x1858BF220", Slot = "11")]
	public void LMAIGONMPAC(BFDJKPKHKDA DCJJENKGKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x58BEED0", Offset = "0x58BDCD0", VA = "0x1858BEED0", Slot = "12")]
	public void LMAIGONMPAC(HCKICCDKCEO KCOKCMMPFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x58BE330", Offset = "0x58BD130", VA = "0x1858BE330", Slot = "13")]
	public void IBINGIHJABG(BFDJKPKHKDA DCJJENKGKJB, MNJIAAJBDBC MAIOHDHBGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x58BE4F0", Offset = "0x58BD2F0", VA = "0x1858BE4F0", Slot = "14")]
	public void IBINGIHJABG(HCKICCDKCEO KCOKCMMPFBD, MNJIAAJBDBC MAIOHDHBGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x58BD360", Offset = "0x58BC160", VA = "0x1858BD360", Slot = "17")]
	public void DFHFCPAKAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x58BD3A0", Offset = "0x58BC1A0", VA = "0x1858BD3A0", Slot = "15")]
	public void DKEOAJGCCCI(HCKICCDKCEO KCOKCMMPFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x58BE2A0", Offset = "0x58BD0A0", VA = "0x1858BE2A0", Slot = "16")]
	public void GEKEJNEFPAE(HCKICCDKCEO KCOKCMMPFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x13C9970", Offset = "0x13C8770", VA = "0x1813C9970", Slot = "18")]
	public void IPKCNFEEENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x58BEC60", Offset = "0x58BDA60", VA = "0x1858BEC60", Slot = "19")]
	public void KMCGNIPMJPI(MNJIAAJBDBC MAIOHDHBGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x58BF530", Offset = "0x58BE330", VA = "0x1858BF530")]
	private void PNOMHPEKEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x58BE6E0", Offset = "0x58BD4E0", VA = "0x1858BE6E0")]
	public void IBINGIHJABG(HCKICCDKCEO KCOKCMMPFBD, MNJIAAJBDBC MAIOHDHBGKE, bool HDMMANGKFKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x58BE1D0", Offset = "0x58BCFD0", VA = "0x1858BE1D0")]
	private void FEIPJFJKKHF(MNJIAAJBDBC MAIOHDHBGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x58BD610", Offset = "0x58BC410", VA = "0x1858BD610", Slot = "20")]
	public void EOAHMKIBJOG(BFDJKPKHKDA DCJJENKGKJB, Vector3 PEEEIKKODFL, Vector3 BBNDBFFBGFH, Vector3 CBGKOLHFKKF, float LEGGLBNBIHN, float ABIMLPEMKPF, IReadOnlyList<Camera> JMPONEDPIFP, ECMPNDFFGLH FNBCEOKGCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x58BD990", Offset = "0x58BC790", VA = "0x1858BD990", Slot = "21")]
	public void EOAHMKIBJOG(DCIICICAEFC JOHOCEAAAEE, Vector3 PEEEIKKODFL, Vector3 BBNDBFFBGFH, Vector3 CBGKOLHFKKF, float LEGGLBNBIHN, float ABIMLPEMKPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IMBDELDBEHK
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool EHCLGIAIEFP
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material MJGNODOCJFC();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material FIPMEOCFLCB();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material JJICMPOCOIH();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DLNOOENGBMG(LBIJLLBELJH EJHBLDNJNCF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FJDKOGNGEAB(NELEAKGOPNB MKFMGJIONDE);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JIHOHBGNCKB(GameObject BLIKPCIFNNO);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IJNBNFNIPBA(GameObject BLIKPCIFNNO, bool MDIDEHIIEJM);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MPPINMKBPCN
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static IMBDELDBEHK HLKJMHJNLMO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static bool EHCLGIAIEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x58BB660", Offset = "0x58BA460", VA = "0x1858BB660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x58BB2B0", Offset = "0x58BA0B0", VA = "0x1858BB2B0")]
	public static void AFBCOHIMGKD(IMBDELDBEHK IGDBFIHINLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x58BB600", Offset = "0x58BA400", VA = "0x1858BB600")]
	public static Material MJGNODOCJFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x58AF340", Offset = "0x58AE140", VA = "0x1858AF340")]
	public static Material FIPMEOCFLCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x58BB5A0", Offset = "0x58BA3A0", VA = "0x1858BB5A0")]
	public static Material JJICMPOCOIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x58BB300", Offset = "0x58BA100", VA = "0x1858BB300")]
	public static int DLNOOENGBMG(LBIJLLBELJH EJHBLDNJNCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x58BB370", Offset = "0x58BA170", VA = "0x1858BB370")]
	public static int FJDKOGNGEAB(NELEAKGOPNB MKFMGJIONDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x58BB4D0", Offset = "0x58BA2D0", VA = "0x1858BB4D0")]
	public static void JIHOHBGNCKB(GameObject BLIKPCIFNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x58BB3E0", Offset = "0x58BA1E0", VA = "0x1858BB3E0")]
	public static void IJNBNFNIPBA(GameObject BLIKPCIFNNO, bool MDIDEHIIEJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class IGHOKCPMJBC : MHPDBOENDNG, PHHKHDHCLGL, CFDMKBJEMLE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly AMGPFEOAJAJ CAHHKGJGOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected Bounds OKDAOGEOPPB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Bounds MOHJHGJIALD
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1575FB0", Offset = "0x1574DB0", VA = "0x181575FB0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public virtual MPLDDCIADOK NJJPGGJPFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x58B6130", Offset = "0x58B4F30", VA = "0x1858B6130", Slot = "17")]
		get
		{
			return default(MPLDDCIADOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FGOOAJNDKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x894FC0", Offset = "0x893DC0", VA = "0x180894FC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x944F40", Offset = "0x943D40", VA = "0x180944F40")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	protected abstract Hash128 NNNMKHFMAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int HAFEGFALDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7FC980", Offset = "0x7FB780", VA = "0x1807FC980", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public OANIFPDPCIH KEDHOFCBMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6F7830", Offset = "0x6F6630", VA = "0x1806F7830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool LMLNOBCHHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x922DE0", Offset = "0x921BE0", VA = "0x180922DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x76B3B0", Offset = "0x76A1B0", VA = "0x18076B3B0")]
	protected IGHOKCPMJBC(AMGPFEOAJAJ DCJJENKGKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x58B5FD0", Offset = "0x58B4DD0", VA = "0x1858B5FD0", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "16")]
	public virtual bool OJIOIHECIHF(MCIOIOFPDFL DCJJENKGKJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int ANHOKDNAKKK(NNCAOIFLNAP NJPOLOKEGLO);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int ECGGLFKKIHO(NNCAOIFLNAP NJPOLOKEGLO);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void EDNGPAEMOMJ(NNCAOIFLNAP NJPOLOKEGLO, HJIHHAKMHAF AFHHJDDLHFP, int EPONHLONMOH = -1);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract MCIOIOFPDFL BMNKFDJOEBA();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x58B6100", Offset = "0x58B4F00", VA = "0x1858B6100", Slot = "11")]
	public Hash128 IGFEJHFOFJM(int NJPOLOKEGLO)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract AKOEJLBFINE BEILNAPNBBI();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract AFGLMFJIDHM PCGJEHNLJHC(NNCAOIFLNAP NJPOLOKEGLO, JobHandle FMCMEMBCJOJ);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x58B5FA0", Offset = "0x58B4DA0", VA = "0x1858B5FA0", Slot = "10")]
	public AFGLMFJIDHM DBBDAECGKAG(int NJPOLOKEGLO)
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
		[Cpp2IlInjected.Address(RVA = "0x58BF850", Offset = "0x58BE650", VA = "0x1858BF850")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum GOLKODHAGHB
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
public static class KLDADADCOGC
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KLHCLLHJKIO : IEnumerable<NPDMEDDNALH>, IEnumerable, IEnumerator<NPDMEDDNALH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private NPDMEDDNALH <>2__current;

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
		private NPDMEDDNALH System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x793410", Offset = "0x792210", VA = "0x180793410")]
		[DebuggerHidden]
		public KLHCLLHJKIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x58BA0F0", Offset = "0x58B8EF0", VA = "0x1858BA0F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x58BA260", Offset = "0x58B9060", VA = "0x1858BA260", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x58BA1D0", Offset = "0x58B8FD0", VA = "0x1858BA1D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NPDMEDDNALH> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x58BA1D0", Offset = "0x58B8FD0", VA = "0x1858BA1D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public const int CGBBFEJOCJF = 3;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static NPDMEDDNALH[][] ONEPHPCELOB;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static JPCBEJOLAAK LAAKDJAODBJ;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static ShapeRendererConfig GDCDAHAKNKD;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static ComputeShader BKDPPKAHACH
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x58B9E20", Offset = "0x58B8C20", VA = "0x1858B9E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static SkinnedShapeRenderer EBFCAAFLJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x58B9C30", Offset = "0x58B8A30", VA = "0x1858B9C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x58B9B10", Offset = "0x58B8910", VA = "0x1858B9B10")]
	public static Mesh EHEALMDHGHO(GOLKODHAGHB JIPPHHDPANM, int NJPOLOKEGLO = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x58B97A0", Offset = "0x58B85A0", VA = "0x1858B97A0")]
	public static int CGHLMHJNKII(GOLKODHAGHB JIPPHHDPANM, int NJPOLOKEGLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x58B9CA0", Offset = "0x58B8AA0", VA = "0x1858B9CA0")]
	public static JPCBEJOLAAK LHLDCBDJGDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x58B9BD0", Offset = "0x58B89D0", VA = "0x1858B9BD0")]
	[IteratorStateMachine(typeof(KLHCLLHJKIO))]
	private static IEnumerable<NPDMEDDNALH> FDGNJLJDNBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x58B97B0", Offset = "0x58B85B0", VA = "0x1858B97B0")]
	public static NPDMEDDNALH CPFKEIJCBKP(GOLKODHAGHB JIPPHHDPANM, int NJPOLOKEGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x58B9E00", Offset = "0x58B8C00", VA = "0x1858B9E00")]
	public static bool LJDIDABCIME(this GOLKODHAGHB JIPPHHDPANM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x58B9E90", Offset = "0x58B8C90", VA = "0x1858B9E90")]
	public static void MFMLNHPEBCE(GOLKODHAGHB JIPPHHDPANM, float3 EFEIAJPGMDM, out INNPPMLGCBK DCFGLMDDGCL, out float3 CFNOCFNCIPA, out float FLJFPLNOCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x58B91D0", Offset = "0x58B7FD0", VA = "0x1858B91D0")]
	public static void APJLEHACAGN(Vector3 EFEIAJPGMDM, GOLKODHAGHB JIPPHHDPANM, out Vector3 CFNOCFNCIPA, out float FLJFPLNOCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x58BA040", Offset = "0x58B8E40", VA = "0x1858BA040")]
	[PONPKGMPDGG(ELCDPILLABI.ExitingPlayMode, 0)]
	private static void OCBJLHMDOAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x58B9580", Offset = "0x58B8380", VA = "0x1858B9580")]
	[PONPKGMPDGG(ELCDPILLABI.ExitingPlayMode, 0)]
	private static void BMCBAKNLGDD()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[DefaultMember("Item")]
	[IDOCBBAEIFB(JHEANMHFGAO.ShapeRendering)]
	public class ShapeRendererManager : NLDDHBHLADK, AJFGIMDDKOA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly global::LHIFGMDEFMC<BFDJKPKHKDA, AMGPFEOAJAJ> JDMLFNGHGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly global::LHIFGMDEFMC<HCKICCDKCEO, IGHOKCPMJBC> JFIEAHBGPCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly global::LHIFGMDEFMC<DCIICICAEFC, NFEAKLKJGLE> PJBIOIKHHND;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public AMGPFEOAJAJ MJCFBIMFFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x58BFA90", Offset = "0x58BE890", VA = "0x1858BFA90", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public IGHOKCPMJBC MJCFBIMFFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x58BFA30", Offset = "0x58BE830", VA = "0x1858BFA30", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public NFEAKLKJGLE MJCFBIMFFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x58BF9D0", Offset = "0x58BE7D0", VA = "0x1858BF9D0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool IIKNONNALOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x82D580", Offset = "0x82C380", VA = "0x18082D580", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x82D600", Offset = "0x82C400", VA = "0x18082D600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x58C06C0", Offset = "0x58BF4C0", VA = "0x1858C06C0")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x58C0110", Offset = "0x58BEF10", VA = "0x1858C0110", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x58C0470", Offset = "0x58BF270", VA = "0x1858C0470", Slot = "4")]
		public BFDJKPKHKDA NKNCCPJAIPM(CCCBIEDCGAI PHAPMEHMHAK)
		{
			return default(BFDJKPKHKDA);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x58C0470", Offset = "0x58BF270", VA = "0x1858C0470", Slot = "5")]
		public BFDJKPKHKDA NKNCCPJAIPM(CCCBIEDCGAI PHAPMEHMHAK, bool CLCBMCNBNJD)
		{
			return default(BFDJKPKHKDA);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x58C0210", Offset = "0x58BF010", VA = "0x1858C0210", Slot = "6")]
		public void HJFIOLICGDB(BFDJKPKHKDA DCJJENKGKJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x58C0090", Offset = "0x58BEE90", VA = "0x1858C0090", Slot = "7")]
		public void DNLCEJLCJMJ(BFDJKPKHKDA DCJJENKGKJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x58BFF50", Offset = "0x58BED50", VA = "0x1858BFF50", Slot = "8")]
		public HCKICCDKCEO DKMBIFADFPN(BFDJKPKHKDA DCJJENKGKJB, OACDPFEEFFM PHAPMEHMHAK)
		{
			return default(HCKICCDKCEO);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x58C0330", Offset = "0x58BF130", VA = "0x1858C0330", Slot = "9")]
		public HCKICCDKCEO MIANLECLGDN(BFDJKPKHKDA DCJJENKGKJB, AEFKAFHFDMD PHAPMEHMHAK)
		{
			return default(HCKICCDKCEO);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x58BF8E0", Offset = "0x58BE6E0", VA = "0x1858BF8E0", Slot = "11")]
		public void BHEDAHOMPPL(HCKICCDKCEO KCOKCMMPFBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x58BFAF0", Offset = "0x58BE8F0", VA = "0x1858BFAF0", Slot = "10")]
		public void DADOCPBHOOK(HCKICCDKCEO KCOKCMMPFBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x58C01A0", Offset = "0x58BEFA0", VA = "0x1858C01A0", Slot = "21")]
		public IEnumerable<Renderer> FHFDKNODEBH(BFDJKPKHKDA DCJJENKGKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x58C05F0", Offset = "0x58BF3F0", VA = "0x1858C05F0", Slot = "12")]
		public DCIICICAEFC PKCDGGGBBGM(OAMIOGINHII PHAPMEHMHAK)
		{
			return default(DCIICICAEFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x58C0580", Offset = "0x58BF380", VA = "0x1858C0580", Slot = "14")]
		public void OCIDKCPHFBC(DCIICICAEFC JOHOCEAAAEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x58BF880", Offset = "0x58BE680", VA = "0x1858BF880", Slot = "16")]
		public Task APCIGICIKHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x58C0270", Offset = "0x58BF070", VA = "0x1858C0270", Slot = "17")]
		public Task IANKCGPALBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x58BF970", Offset = "0x58BE770", VA = "0x1858BF970", Slot = "18")]
		public Task CAAFNNHHHDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xBBD5B0", Offset = "0xBBC3B0", VA = "0x180BBD5B0", Slot = "19")]
		public void MHDGJOIOIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x58C02D0", Offset = "0x58BF0D0", VA = "0x1858C02D0", Slot = "13")]
		public void KKKDMAMPGJN(DCIICICAEFC JOHOCEAAAEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x58BFB50", Offset = "0x58BE950", VA = "0x1858BFB50", Slot = "20")]
		public GHDHHNDLKIN DBBDAECGKAG(MCIOIOFPDFL PDOKGEDOHHO, IEnumerable<HCKICCDKCEO> JFIEAHBGPCJ, int EJIFJDIILDE)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NFEAKLKJGLE : EHJLDPDJAEP
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class JBDNNIGDBLK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public NFEAKLKJGLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x793410", Offset = "0x792210", VA = "0x180793410")]
		[DebuggerHidden]
		public JBDNNIGDBLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x58B8F20", Offset = "0x58B7D20", VA = "0x1858B8F20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x58B8C40", Offset = "0x58B7A40", VA = "0x1858B8C40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x58B8FA0", Offset = "0x58B7DA0", VA = "0x1858B8FA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x58B8EE0", Offset = "0x58B7CE0", VA = "0x1858B8EE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x58B8E40", Offset = "0x58B7C40", VA = "0x1858B8E40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x58B8E40", Offset = "0x58B7C40", VA = "0x1858B8E40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly OAMIOGINHII COEGPJLDHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly AJFGIMDDKOA ODGBACODPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private IIKGLPAOOPA JAHDAEECHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private List<GFFAKKBNBMI> LKDCKFOFJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private List<GFFAKKBNBMI> GJJEJFPGNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private GameObject GEHBFJLFNIL;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x58BBDE0", Offset = "0x58BABE0", VA = "0x1858BBDE0")]
	public static NFEAKLKJGLE APEKNEILPOL(OAMIOGINHII PHAPMEHMHAK, AJFGIMDDKOA ODGBACODPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x58BD260", Offset = "0x58BC060", VA = "0x1858BD260")]
	private NFEAKLKJGLE(OAMIOGINHII PHAPMEHMHAK, AJFGIMDDKOA ODGBACODPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x58BCD80", Offset = "0x58BBB80", VA = "0x1858BCD80")]
	public void HNJHICBJAJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x58BC230", Offset = "0x58BB030", VA = "0x1858BC230")]
	[IteratorStateMachine(typeof(JBDNNIGDBLK))]
	public IEnumerable<Renderer> CBGOGFBBIDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x58BC2A0", Offset = "0x58BB0A0", VA = "0x1858BC2A0", Slot = "4")]
	public void HAGEHGKKBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x58BBF50", Offset = "0x58BAD50", VA = "0x1858BBF50")]
	private void CAHEFKHCDJC(Vector3 HAODALHLFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x58BBFF0", Offset = "0x58BADF0", VA = "0x1858BBFF0")]
	public void CAMMFFCGHBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GFFAKKBNBMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct GCIBMOALHIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public HJIHHAKMHAF IOKPNBDFJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public MCIOIOFPDFL NEHKFPFANIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int JIMFCNJLDPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class JKDDHPGKKFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public GFFAKKBNBMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public NNCAOIFLNAP lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public List<GCIBMOALHIO> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public GHDHHNDLKIN combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public JKDDHPGKKFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x58B8FF0", Offset = "0x58B7DF0", VA = "0x1858B8FF0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x58B9050", Offset = "0x58B7E50", VA = "0x1858B9050")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x58B9080", Offset = "0x58B7E80", VA = "0x1858B9080")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int[] OHIFCCDGLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private ACMIDHDFHFJ ACCEKKAHPFI;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static Matrix4x4 ICIKOALAAKF;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Mesh CHIKAFEPNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int NEJAHCIMIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x719080", Offset = "0x717E80", VA = "0x180719080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x76DC00", Offset = "0x76CA00", VA = "0x18076DC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x58B2380", Offset = "0x58B1180", VA = "0x1858B2380")]
	public void HEFHEKGIDOL(List<MCIOIOFPDFL> PGBEELFFOHM, Matrix4x4[] HEOMOBEONDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x58B1D50", Offset = "0x58B0B50", VA = "0x1858B1D50")]
	public static List<GFFAKKBNBMI> FBMANFCLCAO(List<AMGPFEOAJAJ> ODOLFJMEIHL, NNCAOIFLNAP NJPOLOKEGLO, Bounds KHDGHDAJIBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x58B26C0", Offset = "0x58B14C0", VA = "0x1858B26C0")]
	private JobHandle MOILCPBJIMD(GHDHHNDLKIN PEBPDFEECNI, int ACEFEHEMPCI, int MGPDNCMNPFL, NNCAOIFLNAP NJPOLOKEGLO, List<GCIBMOALHIO> KLAOHPPMOKM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x58B25B0", Offset = "0x58B13B0", VA = "0x1858B25B0")]
	private void JJKNLDEHBNF(List<GCIBMOALHIO> KLAOHPPMOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x58B2BD0", Offset = "0x58B19D0", VA = "0x1858B2BD0")]
	private GFFAKKBNBMI(List<GCIBMOALHIO> KLAOHPPMOKM, int ACEFEHEMPCI, int MGPDNCMNPFL, NNCAOIFLNAP NJPOLOKEGLO, Bounds KHDGHDAJIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x58B1CC0", Offset = "0x58B0AC0", VA = "0x1858B1CC0", Slot = "4")]
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
		private MaterialPropertyBlock GPCCGDDOCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private GFFAKKBNBMI DPOJLBHHPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private List<MCIOIOFPDFL> MKIMOHADGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private RenderTexture DAILKIALMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private ComputeBuffer LNPIIPONMFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private ComputeShader EOOIEPBEFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Matrix4x4[] MNGMFAHHJND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int NKDMOHGDDGA;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public MeshRenderer ADABNIAJMFK
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x701A00", Offset = "0x700800", VA = "0x180701A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int HOFDANGGLJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x58C1730", Offset = "0x58C0530", VA = "0x1858C1730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x58C0AA0", Offset = "0x58BF8A0", VA = "0x1858C0AA0")]
		public static List<SkinnedShapeRenderer> Create(GameObject DCJJENKGKJB, List<GFFAKKBNBMI> FBLHLFIHHNB, List<MCIOIOFPDFL> MKIMOHADGDP, Material LOCCEEIOOPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x58C0EB0", Offset = "0x58BFCB0", VA = "0x1858C0EB0")]
		public void Init(GFFAKKBNBMI DPOJLBHHPEO, List<MCIOIOFPDFL> MKIMOHADGDP, Material LOCCEEIOOPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x58C1680", Offset = "0x58C0480", VA = "0x1858C1680")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x58C15D0", Offset = "0x58C03D0", VA = "0x1858C15D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x58C1590", Offset = "0x58C0390", VA = "0x1858C1590")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x58C1360", Offset = "0x58C0160", VA = "0x1858C1360")]
		private void ODALEFKDOLO(ScriptableRenderContext KPEPJOHCOMD, Camera[] HPADHCNHLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x58C0CF0", Offset = "0x58BFAF0", VA = "0x1858C0CF0")]
		private void HEFHEKGIDOL(CommandBuffer FBOENGCEDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	internal class _RRAssemblyIndex : GIHBEMJPMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x58C1FC0", Offset = "0x58C0DC0", VA = "0x1858C1FC0", Slot = "4")]
		public sealed override void HLFKGNEPEFG()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x58BA2A0", Offset = "0x58B90A0", VA = "0x1858BA2A0")]
	private static string NKHPLDDEAIA(byte[] MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x58BA3B0", Offset = "0x58B91B0", VA = "0x1858BA3B0")]
	public static string OEIELDLCBEJ(byte[] NJGGJPEFKKD, bool NCDJBNMKDFA)
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
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
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
