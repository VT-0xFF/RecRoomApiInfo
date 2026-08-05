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
using Unity.Properties;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum OLELJDEAPDP
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
public static class COAHAOPODDG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3C50", Offset = "0x5CE3050", VA = "0x185CE3C50")]
	public static bool OEHNBGALFHD(this OLELJDEAPDP DODHFBCIJNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3C10", Offset = "0x5CE3010", VA = "0x185CE3C10")]
	public static bool DAFJMDHOHIH(this OLELJDEAPDP DODHFBCIJNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3C20", Offset = "0x5CE3020", VA = "0x185CE3C20")]
	public static bool GGEEDDBPCJI(this OLELJDEAPDP DODHFBCIJNA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HLOGBEBOFNF
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
public enum MLHBLOGGBCP
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
public enum GDLEFAKDPDM
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
public enum GMLHEDAKMID
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
public class EECHDCAFDMD : FILIANMEFMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte PHPDIAAEPFH = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte DJJMPKNJIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] HJOJIMNIIAL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HANFMIMELAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x678010", Offset = "0x677410", VA = "0x180678010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C1CC0", Offset = "0x6C10C0", VA = "0x1806C1CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GLMKFMBKCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x698D90", Offset = "0x698190", VA = "0x180698D90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84AEB0", Offset = "0x84A2B0", VA = "0x18084AEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float PAHANEDKMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1089140", Offset = "0x1088540", VA = "0x181089140", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1088B10", Offset = "0x1087F10", VA = "0x181088B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CKHPDILKJJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1088B20", Offset = "0x1087F20", VA = "0x181088B20", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1088780", Offset = "0x1087B80", VA = "0x181088780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> KJDKNBMJFID
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE5880", Offset = "0x5CE4C80", VA = "0x185CE5880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> JLHJLFMIHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x58CF5C0", Offset = "0x58CE9C0", VA = "0x1858CF5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject OGEOEBLKHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x710AE0", Offset = "0x70FEE0", VA = "0x180710AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte DBJEDMENECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CE5B20", Offset = "0x5CE4F20", VA = "0x185CE5B20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5DA0", Offset = "0x5CE51A0", VA = "0x185CE5DA0")]
	public EECHDCAFDMD(List<APDFELFFFAP> EPOGONKCAAF, List<APDFELFFFAP> GGLNAEGBHGH, List<AABFENMDIGP> FNCCIKDLAHO, Material ONLGHNANNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CE58E0", Offset = "0x5CE4CE0", VA = "0x185CE58E0")]
	private int CNHLOKEEMIK(List<APDFELFFFAP> CGMOCIEBKOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5C10", Offset = "0x5CE5010", VA = "0x185CE5C10")]
	private void MFHKGGHBNKE(int MGFJBEIOOGJ, bool BNMAEDNLOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5B70", Offset = "0x5CE4F70", VA = "0x185CE5B70")]
	public void ILGCDIJIKCB(Vector3 PPJMFAOKKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CE59F0", Offset = "0x5CE4DF0", VA = "0x185CE59F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5D60", Offset = "0x5CE5160", VA = "0x185CE5D60")]
	public void NKJDIKBKLCK(Transform CJBHMFIBOJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OHDCFONLBPP : CAMBLIMJENI, FKHDEIEKOAK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FOGALJIIMMB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public OHDCFONLBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
		[DebuggerHidden]
		public FOGALJIIMMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7F30", Offset = "0x5CE7330", VA = "0x185CE7F30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7A00", Offset = "0x5CE6E00", VA = "0x185CE7A00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8030", Offset = "0x5CE7430", VA = "0x185CE8030")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8080", Offset = "0x5CE7480", VA = "0x185CE8080")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE80D0", Offset = "0x5CE74D0", VA = "0x185CE80D0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7EF0", Offset = "0x5CE72F0", VA = "0x185CE7EF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7E50", Offset = "0x5CE7250", VA = "0x185CE7E50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7E50", Offset = "0x5CE7250", VA = "0x185CE7E50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CBAEBALMILG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public OHDCFONLBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
		[DebuggerHidden]
		public CBAEBALMILG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3A90", Offset = "0x5CE2E90", VA = "0x185CE3A90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5CE36D0", Offset = "0x5CE2AD0", VA = "0x185CE36D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3B70", Offset = "0x5CE2F70", VA = "0x185CE3B70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3BC0", Offset = "0x5CE2FC0", VA = "0x185CE3BC0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3A50", Offset = "0x5CE2E50", VA = "0x185CE3A50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE39B0", Offset = "0x5CE2DB0", VA = "0x185CE39B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE39B0", Offset = "0x5CE2DB0", VA = "0x185CE39B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly BAEDIJMILGG JFDFJHNEKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<KIOGIFALECH> INCNJPLPBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> LLMDAJJMGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer LJBKCFGHPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool KDEGPBJEKKH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<EIFPGAOKLKM> NCJFMFOLHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DICGBFNCPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBDA0", Offset = "0x5CEB1A0", VA = "0x185CEBDA0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AABFENMDIGP CHFBKJMNHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5CECE10", Offset = "0x5CEC210", VA = "0x185CECE10", Slot = "7")]
		get
		{
			return default(AABFENMDIGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> DJFFODNPHCB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67F570", Offset = "0x67E970", VA = "0x18067F570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67F590", Offset = "0x67E990", VA = "0x18067F590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CED080", Offset = "0x5CEC480", VA = "0x185CED080")]
	public OHDCFONLBPP(BAEDIJMILGG PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CECB90", Offset = "0x5CEBF90", VA = "0x185CECB90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBDE0", Offset = "0x5CEB1E0", VA = "0x185CEBDE0")]
	public void AKBMAMDKLNI(KIOGIFALECH KCJDLCBHDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CECCE0", Offset = "0x5CEC0E0", VA = "0x185CECCE0")]
	public void GKDAOIMBAHJ(KIOGIFALECH KCJDLCBHDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBF80", Offset = "0x5CEB380", VA = "0x185CEBF80", Slot = "4")]
	public void CMGIIONHBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CECC30", Offset = "0x5CEC030", VA = "0x185CECC30")]
	public void FHBKGIAODCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CECA10", Offset = "0x5CEBE10", VA = "0x185CECA10")]
	private void DOJMMAJKIMP(List<KIOGIFALECH> INCNJPLPBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CECEE0", Offset = "0x5CEC2E0", VA = "0x185CECEE0")]
	private static Material MABLNLIBKFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CECB40", Offset = "0x5CEBF40", VA = "0x185CECB40")]
	private void DOJMMAJKIMP(KIOGIFALECH KCJDLCBHDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CECFB0", Offset = "0x5CEC3B0", VA = "0x185CECFB0")]
	private void PADJEONLBIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC4F0", Offset = "0x5CEB8F0", VA = "0x185CEC4F0")]
	public void COMLIBPCNAL(bool INKINBEEEFH, bool GAIHALIFFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBEF0", Offset = "0x5CEB2F0", VA = "0x185CEBEF0")]
	protected void BCLAMOJHEIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CECDA0", Offset = "0x5CEC1A0", VA = "0x185CECDA0")]
	[IteratorStateMachine(typeof(FOGALJIIMMB))]
	public IEnumerable<Renderer> LCHDBEAICHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CECBC0", Offset = "0x5CEBFC0", VA = "0x185CECBC0")]
	[IteratorStateMachine(typeof(CBAEBALMILG))]
	public IEnumerable<Renderer> EDCHDKIGGPI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class OCFPEKPHPEH : KIOGIFALECH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly BPCGJHFILPK MMIHCFLLBDP;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE79B0", Offset = "0x5CE6DB0", VA = "0x185CE79B0")]
	public OCFPEKPHPEH(OHDCFONLBPP NMIIAOIKHMI, BPCGJHFILPK PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB9C0", Offset = "0x5CEADC0", VA = "0x185CEB9C0", Slot = "13")]
	public override int CNHLOKEEMIK(NFCKEIODPAP ANFOFNJCGIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBBB0", Offset = "0x5CEAFB0", VA = "0x185CEBBB0", Slot = "14")]
	public override int KFHNHKAMBDJ(NFCKEIODPAP ANFOFNJCGIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB290", Offset = "0x5CEA690", VA = "0x185CEB290", Slot = "15")]
	public override void ANOHAOILEFC(NFCKEIODPAP ANFOFNJCGIO, OBACPNECNCI GFPDCOJMHIA, int KBHJGNDGJAB = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NLGAGNEGCOI : global::GPFPNOKLPCO<NLGAGNEGCOI>, PIEOKMGFPCE, IEquatable<NLGAGNEGCOI>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[CreateProperty]
	public int IJHDILKKDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x729E20", Offset = "0x729220", VA = "0x180729E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x729D90", Offset = "0x729190", VA = "0x180729D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int BBEGHBAAMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B6B60", Offset = "0x8B5F60", VA = "0x1808B6B60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xEAA170", Offset = "0xEA9570", VA = "0x180EAA170", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool EFFOACKHLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA920", Offset = "0x5CE9D20", VA = "0x185CEA920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B760", Offset = "0x2A7AB60", VA = "0x182A7B760", Slot = "8")]
	public bool Equals(NLGAGNEGCOI EPJIAIAEMFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xD9DDE0", Offset = "0xD9D1E0", VA = "0x180D9DDE0")]
	public static bool LPAHFDMKICD(NLGAGNEGCOI GHJDMBPGMHF, NLGAGNEGCOI IKDBBHHKFLJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x486AAA0", Offset = "0x4869EA0", VA = "0x18486AAA0")]
	public static bool AFMDFHOMNJI(NLGAGNEGCOI GHJDMBPGMHF, NLGAGNEGCOI IKDBBHHKFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA960", Offset = "0x5CE9D60", VA = "0x185CEA960", Slot = "0")]
	public override bool Equals(object JLBINKLPHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x729E20", Offset = "0x729220", VA = "0x180729E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA9F0", Offset = "0x5CE9DF0", VA = "0x185CEA9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum PDBGNGPBIPI
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BAEDIJMILGG
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	AABFENMDIGP ELOLOIEDCOD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	PDBGNGPBIPI DKCNJAEKKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DPCKKGDFEIB : global::GPFPNOKLPCO<DPCKKGDFEIB>, PIEOKMGFPCE, IEquatable<DPCKKGDFEIB>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	[CreateProperty]
	public int IJHDILKKDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x729E20", Offset = "0x729220", VA = "0x180729E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x729D90", Offset = "0x729190", VA = "0x180729D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int BBEGHBAAMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B6B60", Offset = "0x8B5F60", VA = "0x1808B6B60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xEAA170", Offset = "0xEA9570", VA = "0x180EAA170", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool EFFOACKHLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3CC0", Offset = "0x5CE30C0", VA = "0x185CE3CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B760", Offset = "0x2A7AB60", VA = "0x182A7B760", Slot = "8")]
	public bool Equals(DPCKKGDFEIB EPJIAIAEMFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xD9DDE0", Offset = "0xD9D1E0", VA = "0x180D9DDE0")]
	public static bool LPAHFDMKICD(DPCKKGDFEIB GHJDMBPGMHF, DPCKKGDFEIB IKDBBHHKFLJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x486AAA0", Offset = "0x4869EA0", VA = "0x18486AAA0")]
	public static bool AFMDFHOMNJI(DPCKKGDFEIB GHJDMBPGMHF, DPCKKGDFEIB IKDBBHHKFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3D00", Offset = "0x5CE3100", VA = "0x185CE3D00", Slot = "0")]
	public override bool Equals(object JLBINKLPHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x729E20", Offset = "0x729220", VA = "0x180729E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3D90", Offset = "0x5CE3190", VA = "0x185CE3D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BOCFILOJGCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	AABFENMDIGP ELOLOIEDCOD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float IEJCKNJLCPD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 LCJFBPECKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	OLELJDEAPDP KOMHAAABLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	HLOGBEBOFNF DPLKONFCDON
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ALFJIOBDEGA : BOCFILOJGCK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	FNAMCNBHJCB PCPHJDEHOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NMBEFEAAEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BPCGJHFILPK : BOCFILOJGCK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool JKDLFMOAPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IKMAKFGBCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float MPDNAHBGHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int JCDBJKPDBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool BMJLMMODHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int KECFCCJIPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<LMECFCJKAOH> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KPPJBJKEPBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKCKGCPPPJI(NLGAGNEGCOI NMIIAOIKHMI, GDLEFAKDPDM GOOEICGHIME);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKCKGCPPPJI(DPCKKGDFEIB KCJDLCBHDFK, GDLEFAKDPDM GOOEICGHIME);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CMKDKMLPIIG(DPCKKGDFEIB KCJDLCBHDFK);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HJIHODJKAKP(DPCKKGDFEIB KCJDLCBHDFK);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGOMBEFHMJF();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FPPKHPIBMFO();

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FJLDOOMLJNA(GDLEFAKDPDM FPPBLNEEHBP);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LAFAFGPKGNK(NLGAGNEGCOI NMIIAOIKHMI);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LAFAFGPKGNK(DPCKKGDFEIB KCJDLCBHDFK);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DCIBKMIHELI(NLGAGNEGCOI NMIIAOIKHMI, GMLHEDAKMID FPPBLNEEHBP);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DCIBKMIHELI(DPCKKGDFEIB KCJDLCBHDFK, GMLHEDAKMID FPPBLNEEHBP);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PPAGHDINLAO(DPCKKGDFEIB KCJDLCBHDFK);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GGFKHFLDIMM(DPCKKGDFEIB KCJDLCBHDFK);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NIBLNOPHEDI();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DPDMIHNPNIO();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LMDBFMPMLKO(GMLHEDAKMID FPPBLNEEHBP);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IKJJGKEILEN(NLGAGNEGCOI NMIIAOIKHMI, Vector3 BOCGJBKNHMG, Vector3 CPFKBJEKLPC, Vector3 FDHENPDJFHG, float KIHGNKIGNCO, float EFECKKIODBD, IReadOnlyList<Camera> FJFFJMGBLIE, MLHBLOGGBCP FPKBOCLCHNC);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IKJJGKEILEN(HCLOHMBFCCA PNIFCGEIJGM, Vector3 BOCGJBKNHMG, Vector3 CPFKBJEKLPC, Vector3 FDHENPDJFHG, float KIHGNKIGNCO, float EFECKKIODBD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PHOLIOOJGPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NLGAGNEGCOI NHCBNMEDMFB(BAEDIJMILGG PNMIIEJFOON);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPPNADEEALN(NLGAGNEGCOI NMIIAOIKHMI);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCHBINEBOJP(NLGAGNEGCOI NMIIAOIKHMI);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DPCKKGDFEIB IOIACOAFOHE(NLGAGNEGCOI NMIIAOIKHMI, ALFJIOBDEGA PNMIIEJFOON);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPCKKGDFEIB GBDOCMLCAAC(NLGAGNEGCOI NMIIAOIKHMI, BPCGJHFILPK PNMIIEJFOON);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGLAGNGHDCD(DPCKKGDFEIB KCJDLCBHDFK);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CIBIDLOINKB(DPCKKGDFEIB KCJDLCBHDFK);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HCLOHMBFCCA BLJBGANCIOA(JHKCGGNBCED PNMIIEJFOON);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HKFDNHOCIMJ(HCLOHMBFCCA PNIFCGEIJGM);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OFIMAFMGAME(HCLOHMBFCCA PNIFCGEIJGM);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FCGAAGMJLHP FKPIHBLLHOI(AABFENMDIGP EHNCPPMONGH, IEnumerable<DPCKKGDFEIB> INCNJPLPBDF, int JOMLDACJNKB);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> EAOAFIGILLF(NLGAGNEGCOI NMIIAOIKHMI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct HCLOHMBFCCA : global::GPFPNOKLPCO<HCLOHMBFCCA>, PIEOKMGFPCE, IEquatable<HCLOHMBFCCA>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int IJHDILKKDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x729E20", Offset = "0x729220", VA = "0x180729E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x729D90", Offset = "0x729190", VA = "0x180729D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int BBEGHBAAMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8B6B60", Offset = "0x8B5F60", VA = "0x1808B6B60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xEAA170", Offset = "0xEA9570", VA = "0x180EAA170", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool EFFOACKHLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE82D0", Offset = "0x5CE76D0", VA = "0x185CE82D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B760", Offset = "0x2A7AB60", VA = "0x182A7B760", Slot = "8")]
	public bool Equals(HCLOHMBFCCA EPJIAIAEMFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xD9DDE0", Offset = "0xD9D1E0", VA = "0x180D9DDE0")]
	public static bool LPAHFDMKICD(HCLOHMBFCCA GHJDMBPGMHF, HCLOHMBFCCA IKDBBHHKFLJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x486AAA0", Offset = "0x4869EA0", VA = "0x18486AAA0")]
	public static bool AFMDFHOMNJI(HCLOHMBFCCA GHJDMBPGMHF, HCLOHMBFCCA IKDBBHHKFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8310", Offset = "0x5CE7710", VA = "0x185CE8310", Slot = "0")]
	public override bool Equals(object JLBINKLPHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x729E20", Offset = "0x729220", VA = "0x180729E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JHKCGGNBCED
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int INIFPCLHEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform IPJBOKDAMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool IANGOKJOOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NLGAGNEGCOI GetBone(int AMDLLNEHJMF);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int AMDLLNEHJMF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class EGDNDPGHDHH : KIOGIFALECH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly ALFJIOBDEGA HEPLIACNMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int[] KJDBCPJKCKL;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override PBCCEGGLBEI AALELBKPCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6A40", Offset = "0x5CE5E40", VA = "0x185CE6A40", Slot = "12")]
		get
		{
			return default(PBCCEGGLBEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 EOMNPNKFKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7200", Offset = "0x5CE6600", VA = "0x185CE7200")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5CE79B0", Offset = "0x5CE6DB0", VA = "0x185CE79B0")]
	public EGDNDPGHDHH(OHDCFONLBPP NMIIAOIKHMI, ALFJIOBDEGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7540", Offset = "0x5CE6940", VA = "0x185CE7540", Slot = "11")]
	public override bool NHEMGGELFIJ(AABFENMDIGP NMIIAOIKHMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6DF0", Offset = "0x5CE61F0", VA = "0x185CE6DF0", Slot = "13")]
	public override int CNHLOKEEMIK(NFCKEIODPAP ANFOFNJCGIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7150", Offset = "0x5CE6550", VA = "0x185CE7150", Slot = "14")]
	public override int KFHNHKAMBDJ(NFCKEIODPAP ANFOFNJCGIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6EA0", Offset = "0x5CE62A0", VA = "0x185CE6EA0")]
	private int GHDDOBHMAKL(NFCKEIODPAP ANFOFNJCGIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6160", Offset = "0x5CE5560", VA = "0x185CE6160", Slot = "15")]
	public override void ANOHAOILEFC(NFCKEIODPAP ANFOFNJCGIO, OBACPNECNCI GFPDCOJMHIA, int KBHJGNDGJAB = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BABHEHBHGPC
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKOCPCNLEAB(GMLHEDAKMID FPPBLNEEHBP, Renderer GEOPDBJFILC, int KMBCLCMBCNB);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKPCIPNFFJK(Renderer GEOPDBJFILC, MLHBLOGGBCP FPKBOCLCHNC, Vector3 BOCGJBKNHMG, Vector3 CPFKBJEKLPC, Vector3 FDHENPDJFHG, float KIHGNKIGNCO, float EFECKKIODBD, float PGGJMBMNCON = -1f, [Optional] Color? CNDGCCPDGDM, [Optional] IReadOnlyList<Camera> CCOCNEPPEHG);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PANEOBDJPIL(Renderer GEOPDBJFILC, int KMBCLCMBCNB);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IGDONMBDNBM();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HIBDJOJLCPB(int IFPNGMOAGON, GDLEFAKDPDM FPPBLNEEHBP, Renderer GEOPDBJFILC, int KMBCLCMBCNB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MOHIKNIFPJK : KPPJBJKEPBE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class CODHGBFBPEE : global::GCBNNDCGLLB<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3C70", Offset = "0x5CE3070", VA = "0x185CE3C70")]
		public CODHGBFBPEE(string DHKKANIEGMN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly BABHEHBHGPC KOFJAICJBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly ELHIHCPKHCA AEBMKBHKMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MeshRenderer IEHBNJMEBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private CODHGBFBPEE INLJMDEMJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool LPKNHHAJMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MeshRenderer ECILALKMAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private CODHGBFBPEE CPCOEAJGCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool HCCLKAABOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MeshRenderer KLDOEGPGECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private CODHGBFBPEE NBDPHPOBDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6786E0", Offset = "0x677AE0", VA = "0x1806786E0")]
	public MOHIKNIFPJK(BABHEHBHGPC MMIKMGGBPIK, ELHIHCPKHCA AEBMKBHKMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8BE0", Offset = "0x5CE7FE0", VA = "0x185CE8BE0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8DB0", Offset = "0x5CE81B0", VA = "0x185CE8DB0")]
	private void EBNIDLKCBBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA350", Offset = "0x5CE9750", VA = "0x185CEA350", Slot = "4")]
	public void MKCKGCPPPJI(NLGAGNEGCOI NMIIAOIKHMI, GDLEFAKDPDM GOOEICGHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA550", Offset = "0x5CE9950", VA = "0x185CEA550", Slot = "5")]
	public void MKCKGCPPPJI(DPCKKGDFEIB KCJDLCBHDFK, GDLEFAKDPDM GOOEICGHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8540", Offset = "0x5CE7940", VA = "0x185CE8540", Slot = "6")]
	public void CMKDKMLPIIG(DPCKKGDFEIB KCJDLCBHDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9450", Offset = "0x5CE8850", VA = "0x185CE9450", Slot = "7")]
	public void HJIHODJKAKP(DPCKKGDFEIB KCJDLCBHDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8500", Offset = "0x5CE7900", VA = "0x185CE8500", Slot = "8")]
	public void AGOMBEFHMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1741650", Offset = "0x1740A50", VA = "0x181741650", Slot = "9")]
	public void FPPKHPIBMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9000", Offset = "0x5CE8400", VA = "0x185CE9000", Slot = "10")]
	public void FJLDOOMLJNA(GDLEFAKDPDM GOOEICGHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA060", Offset = "0x5CE9460", VA = "0x185CEA060", Slot = "11")]
	public void LAFAFGPKGNK(NLGAGNEGCOI NMIIAOIKHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9D10", Offset = "0x5CE9110", VA = "0x185CE9D10", Slot = "12")]
	public void LAFAFGPKGNK(DPCKKGDFEIB KCJDLCBHDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8830", Offset = "0x5CE7C30", VA = "0x185CE8830", Slot = "13")]
	public void DCIBKMIHELI(NLGAGNEGCOI NMIIAOIKHMI, GMLHEDAKMID FPPBLNEEHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5CE89F0", Offset = "0x5CE7DF0", VA = "0x185CE89F0", Slot = "14")]
	public void DCIBKMIHELI(DPCKKGDFEIB KCJDLCBHDFK, GMLHEDAKMID FPPBLNEEHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA770", Offset = "0x5CE9B70", VA = "0x185CEA770", Slot = "17")]
	public void NIBLNOPHEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA880", Offset = "0x5CE9C80", VA = "0x185CEA880", Slot = "15")]
	public void PPAGHDINLAO(DPCKKGDFEIB KCJDLCBHDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9170", Offset = "0x5CE8570", VA = "0x185CE9170", Slot = "16")]
	public void GGFKHFLDIMM(DPCKKGDFEIB KCJDLCBHDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1372C00", Offset = "0x1372000", VA = "0x181372C00", Slot = "18")]
	public void DPDMIHNPNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA210", Offset = "0x5CE9610", VA = "0x185CEA210", Slot = "19")]
	public void LMDBFMPMLKO(GMLHEDAKMID FPPBLNEEHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9200", Offset = "0x5CE8600", VA = "0x185CE9200")]
	private void GOMNNBBOAKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8670", Offset = "0x5CE7A70", VA = "0x185CE8670")]
	public void DCIBKMIHELI(DPCKKGDFEIB KCJDLCBHDFK, GMLHEDAKMID FPPBLNEEHBP, bool AFOJNAADCMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA7B0", Offset = "0x5CE9BB0", VA = "0x185CEA7B0")]
	private void NKOCPCNLEAB(GMLHEDAKMID FPPBLNEEHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9990", Offset = "0x5CE8D90", VA = "0x185CE9990", Slot = "20")]
	public void IKJJGKEILEN(NLGAGNEGCOI NMIIAOIKHMI, Vector3 BOCGJBKNHMG, Vector3 CPFKBJEKLPC, Vector3 FDHENPDJFHG, float KIHGNKIGNCO, float EFECKKIODBD, IReadOnlyList<Camera> FJFFJMGBLIE, MLHBLOGGBCP FPKBOCLCHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9570", Offset = "0x5CE8970", VA = "0x185CE9570", Slot = "21")]
	public void IKJJGKEILEN(HCLOHMBFCCA PNIFCGEIJGM, Vector3 BOCGJBKNHMG, Vector3 CPFKBJEKLPC, Vector3 FDHENPDJFHG, float KIHGNKIGNCO, float EFECKKIODBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class KIOGIFALECH : KPGICJKFGEC, EIFPGAOKLKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly OHDCFONLBPP OGEOEBLKHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	protected Bounds BCKIEAKKPPK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds CPAJLJJDBPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x16BB9E0", Offset = "0x16BADE0", VA = "0x1816BB9E0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual PBCCEGGLBEI AALELBKPCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5CE83A0", Offset = "0x5CE77A0", VA = "0x185CE83A0", Slot = "12")]
		get
		{
			return default(PBCCEGGLBEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x678F40", Offset = "0x678340", VA = "0x180678F40")]
	protected KIOGIFALECH(OHDCFONLBPP NMIIAOIKHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8430", Offset = "0x5CE7830", VA = "0x185CE8430", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "11")]
	public virtual bool NHEMGGELFIJ(AABFENMDIGP NMIIAOIKHMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int CNHLOKEEMIK(NFCKEIODPAP ANFOFNJCGIO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int KFHNHKAMBDJ(NFCKEIODPAP ANFOFNJCGIO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void ANOHAOILEFC(NFCKEIODPAP ANFOFNJCGIO, OBACPNECNCI GFPDCOJMHIA, int KBHJGNDGJAB = -1);
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5CED120", Offset = "0x5CEC520", VA = "0x185CED120")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum FNAMCNBHJCB
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class APBOOMMJIIC
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GDBMCCFIFBG : IEnumerable<FLOGBMAOONA>, IEnumerable, IEnumerator<FLOGBMAOONA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private FLOGBMAOONA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private FLOGBMAOONA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
		[DebuggerHidden]
		public GDBMCCFIFBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8120", Offset = "0x5CE7520", VA = "0x185CE8120", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8290", Offset = "0x5CE7690", VA = "0x185CE8290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8200", Offset = "0x5CE7600", VA = "0x185CE8200", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FLOGBMAOONA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8200", Offset = "0x5CE7600", VA = "0x185CE8200", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int DAFKCJPHFPA = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static FLOGBMAOONA[][] BJODIGCABKA;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static NDLDLLFGKBG NOKKFLLDFJJ;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static ShapeRendererConfig JGLMONPIOMA;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader JDONEGMCDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2280", Offset = "0x5CE1680", VA = "0x185CE2280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer BFLAFENOPDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5CE14A0", Offset = "0x5CE08A0", VA = "0x185CE14A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5CE21C0", Offset = "0x5CE15C0", VA = "0x185CE21C0")]
	public static Mesh LEFBBIAFEDO(FNAMCNBHJCB AHAAILCGBMF, int ANFOFNJCGIO = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1B40", Offset = "0x5CE0F40", VA = "0x185CE1B40")]
	public static int IPEFMGBIOBO(FNAMCNBHJCB AHAAILCGBMF, int ANFOFNJCGIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2060", Offset = "0x5CE1460", VA = "0x185CE2060")]
	public static NDLDLLFGKBG KFPNLHKDIHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1AE0", Offset = "0x5CE0EE0", VA = "0x185CE1AE0")]
	[IteratorStateMachine(typeof(GDBMCCFIFBG))]
	private static IEnumerable<FLOGBMAOONA> HELCFBOLHIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1B50", Offset = "0x5CE0F50", VA = "0x185CE1B50")]
	public static FLOGBMAOONA JCMIDFPJJCO(FNAMCNBHJCB AHAAILCGBMF, int ANFOFNJCGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5CE22F0", Offset = "0x5CE16F0", VA = "0x185CE22F0")]
	public static bool NICBBJDBMMP(this FNAMCNBHJCB AHAAILCGBMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1EB0", Offset = "0x5CE12B0", VA = "0x185CE1EB0")]
	public static void JMIBCMENIBG(FNAMCNBHJCB AHAAILCGBMF, float3 MBPEOEJHIKA, out JLEBMKCKNNN OHEFMIKEDGN, out float3 EJHECJBKCEL, out float AJOBKILJNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1510", Offset = "0x5CE0910", VA = "0x185CE1510")]
	public static void DNCGLHEBICF(Vector3 MBPEOEJHIKA, FNAMCNBHJCB AHAAILCGBMF, out Vector3 EJHECJBKCEL, out float AJOBKILJNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1490", Offset = "0x5CE0890", VA = "0x185CE1490")]
	[BPHOCBKBMCO(JFHBHDNAPPN.ExitingPlayMode, 0)]
	private static void BAIJIHODCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CE18C0", Offset = "0x5CE0CC0", VA = "0x185CE18C0")]
	[BPHOCBKBMCO(JFHBHDNAPPN.ExitingPlayMode, 0)]
	private static void FFAFMCDKNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface APFLEKPNPMK
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool MBHCDFNGIPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material NJBBDCBCHMJ();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material MABLNLIBKFJ();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material MGCODHCOOLG();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MAHKFDJCPGM(OLELJDEAPDP DODHFBCIJNA);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NLJGDOGPAPM(HLOGBEBOFNF DJIOIBKCAKB);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IOGPEHEDEGE(GameObject JLBINKLPHKJ);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EMMOLNLAOIJ(GameObject JLBINKLPHKJ, bool BAENNCJONLL);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface ELHIHCPKHCA
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	OHDCFONLBPP HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	KIOGIFALECH HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	EABNPMDGHFA HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[DefaultMember("Item")]
	[JLJFNDDLCBO(CBGNDNDJKHL.ShapeRendering)]
	public class ShapeRendererManager : PHOLIOOJGPC, IDisposable, ELHIHCPKHCA
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly global::HBNFHFECEEB<NLGAGNEGCOI, OHDCFONLBPP> IFOLEICFMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly global::HBNFHFECEEB<DPCKKGDFEIB, KIOGIFALECH> INCNJPLPBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly global::HBNFHFECEEB<HCLOHMBFCCA, EABNPMDGHFA> IJNKFKGJLMI;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static APFLEKPNPMK NHHKAFICIOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5CEDDB0", Offset = "0x5CED1B0", VA = "0x185CEDDB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5CEDF10", Offset = "0x5CED310", VA = "0x185CEDF10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public OHDCFONLBPP HIMPFAAIFFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x5CEDB20", Offset = "0x5CECF20", VA = "0x185CEDB20", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public KIOGIFALECH HIMPFAAIFFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x5CEDB80", Offset = "0x5CECF80", VA = "0x185CEDB80", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public EABNPMDGHFA HIMPFAAIFFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5CEDAC0", Offset = "0x5CECEC0", VA = "0x185CEDAC0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE040", Offset = "0x5CED440", VA = "0x185CEE040")]
		public ShapeRendererManager(APFLEKPNPMK MMIKMGGBPIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5CED460", Offset = "0x5CEC860", VA = "0x185CED460", Slot = "16")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5CEDE10", Offset = "0x5CED210", VA = "0x185CEDE10", Slot = "4")]
		public NLGAGNEGCOI NHCBNMEDMFB(BAEDIJMILGG PNMIIEJFOON)
		{
			return default(NLGAGNEGCOI);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5CEDD50", Offset = "0x5CED150", VA = "0x185CEDD50", Slot = "5")]
		public void KPPNADEEALN(NLGAGNEGCOI NMIIAOIKHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5CED350", Offset = "0x5CEC750", VA = "0x185CED350", Slot = "6")]
		public void CCHBINEBOJP(NLGAGNEGCOI NMIIAOIKHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5CEDC40", Offset = "0x5CED040", VA = "0x185CEDC40", Slot = "7")]
		public DPCKKGDFEIB IOIACOAFOHE(NLGAGNEGCOI NMIIAOIKHMI, ALFJIOBDEGA PNMIIEJFOON)
		{
			return default(DPCKKGDFEIB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5CED9B0", Offset = "0x5CECDB0", VA = "0x185CED9B0", Slot = "8")]
		public DPCKKGDFEIB GBDOCMLCAAC(NLGAGNEGCOI NMIIAOIKHMI, BPCGJHFILPK PNMIIEJFOON)
		{
			return default(DPCKKGDFEIB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5CED3D0", Offset = "0x5CEC7D0", VA = "0x185CED3D0", Slot = "10")]
		public void CIBIDLOINKB(DPCKKGDFEIB KCJDLCBHDFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5CED150", Offset = "0x5CEC550", VA = "0x185CED150", Slot = "9")]
		public void AGLAGNGHDCD(DPCKKGDFEIB KCJDLCBHDFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5CED4F0", Offset = "0x5CEC8F0", VA = "0x185CED4F0", Slot = "15")]
		public IEnumerable<Renderer> EAOAFIGILLF(NLGAGNEGCOI NMIIAOIKHMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5CED1B0", Offset = "0x5CEC5B0", VA = "0x185CED1B0", Slot = "11")]
		public HCLOHMBFCCA BLJBGANCIOA(JHKCGGNBCED PNMIIEJFOON)
		{
			return default(HCLOHMBFCCA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5CEDF80", Offset = "0x5CED380", VA = "0x185CEDF80", Slot = "13")]
		public void OFIMAFMGAME(HCLOHMBFCCA PNIFCGEIJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5CEDBE0", Offset = "0x5CECFE0", VA = "0x185CEDBE0", Slot = "12")]
		public void HKFDNHOCIMJ(HCLOHMBFCCA PNIFCGEIJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5CED5B0", Offset = "0x5CEC9B0", VA = "0x185CED5B0", Slot = "14")]
		public FCGAAGMJLHP FKPIHBLLHOI(AABFENMDIGP PJHBEJCOEPD, IEnumerable<DPCKKGDFEIB> INCNJPLPBDF, int JOMLDACJNKB)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class EABNPMDGHFA : CAMBLIMJENI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ECEOLOCNLAO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public EABNPMDGHFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
		[DebuggerHidden]
		public ECEOLOCNLAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5CE57B0", Offset = "0x5CE4BB0", VA = "0x185CE57B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5CE54D0", Offset = "0x5CE48D0", VA = "0x185CE54D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5CE5830", Offset = "0x5CE4C30", VA = "0x185CE5830")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5CE5770", Offset = "0x5CE4B70", VA = "0x185CE5770", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE56D0", Offset = "0x5CE4AD0", VA = "0x185CE56D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE56D0", Offset = "0x5CE4AD0", VA = "0x185CE56D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly JHKCGGNBCED FKODGICPBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly ELHIHCPKHCA AEBMKBHKMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private EECHDCAFDMD NIIOMOMBHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private List<APDFELFFFAP> KEBHDCMFEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private List<APDFELFFFAP> KCMIIFIAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject JLMIDIMMCLK;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4D80", Offset = "0x5CE4180", VA = "0x185CE4D80")]
	public static EABNPMDGHFA MMPIAIAFGDF(JHKCGGNBCED PNMIIEJFOON, ELHIHCPKHCA AEBMKBHKMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5CE53D0", Offset = "0x5CE47D0", VA = "0x185CE53D0")]
	private EABNPMDGHFA(JHKCGGNBCED PNMIIEJFOON, ELHIHCPKHCA AEBMKBHKMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4EF0", Offset = "0x5CE42F0", VA = "0x185CE4EF0")]
	public void NPNFNKBABCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4D10", Offset = "0x5CE4110", VA = "0x185CE4D10")]
	[IteratorStateMachine(typeof(ECEOLOCNLAO))]
	public IEnumerable<Renderer> LCHDBEAICHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3E20", Offset = "0x5CE3220", VA = "0x185CE3E20", Slot = "4")]
	public void CMGIIONHBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5CE49D0", Offset = "0x5CE3DD0", VA = "0x185CE49D0")]
	private void DLICOJOOHNK(Vector3 PPJMFAOKKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4A70", Offset = "0x5CE3E70", VA = "0x185CE4A70")]
	public void FHBKGIAODCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class APDFELFFFAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct FKDENFINPDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public OBACPNECNCI NKODHEKFFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AABFENMDIGP NCKNHAHPBDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int KBLIEGMCFMG;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class OBPEHHKMMJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public APDFELFFFAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public NFCKEIODPAP lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<FKDENFINPDP> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public FCGAAGMJLHP combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public OBPEHHKMMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB0B0", Offset = "0x5CEA4B0", VA = "0x185CEB0B0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB110", Offset = "0x5CEA510", VA = "0x185CEB110")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB140", Offset = "0x5CEA540", VA = "0x185CEB140")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int[] KGDIHOKDNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private GIMLDHCFNJM KICMMJEMGJE;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static Matrix4x4 CLAMHMNJCDO;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh MMIPGENHFBK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x697530", VA = "0x180698130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int PFOBHIOGACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x679BD0", Offset = "0x678FD0", VA = "0x180679BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x71C410", Offset = "0x71B810", VA = "0x18071C410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2F60", Offset = "0x5CE2360", VA = "0x185CE2F60")]
	public void FPKFDGDENED(List<AABFENMDIGP> CAONCMNNOBC, Matrix4x4[] LLAOJHIMLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2930", Offset = "0x5CE1D30", VA = "0x185CE2930")]
	public static List<APDFELFFFAP> FNICMNFMKAL(List<OHDCFONLBPP> JEBOJKFHJOE, NFCKEIODPAP ANFOFNJCGIO, Bounds HGOHIFPNOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5CE24C0", Offset = "0x5CE18C0", VA = "0x185CE24C0")]
	private JobHandle AKMENEPNBBG(FCGAAGMJLHP PMHJLABDAAM, int EKPBKIFPKMO, int OOGHICPIHLB, NFCKEIODPAP ANFOFNJCGIO, List<FKDENFINPDP> IKHADANGBOE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5CE23B0", Offset = "0x5CE17B0", VA = "0x185CE23B0")]
	private void AKBODINIKIO(List<FKDENFINPDP> IKHADANGBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5CE32C0", Offset = "0x5CE26C0", VA = "0x185CE32C0")]
	private APDFELFFFAP(List<FKDENFINPDP> IKHADANGBOE, int EKPBKIFPKMO, int OOGHICPIHLB, NFCKEIODPAP ANFOFNJCGIO, Bounds HGOHIFPNOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5CE28A0", Offset = "0x5CE1CA0", VA = "0x185CE28A0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private MaterialPropertyBlock HNIBBLELMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private APDFELFFFAP GCPBPIFAIBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<AABFENMDIGP> FNCCIKDLAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private RenderTexture PPNLHENLEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private ComputeBuffer LLOHOHGGOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private ComputeShader CGNGCGLCKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Matrix4x4[] DGIEMDLPLDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private int FBCFGBNCFLC;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer ODGAJBOIHDD
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x697540", VA = "0x180698140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int INIFPCLHEDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5CEF270", Offset = "0x5CEE670", VA = "0x185CEF270")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE5E0", Offset = "0x5CED9E0", VA = "0x185CEE5E0")]
		public static List<SkinnedShapeRenderer> Create(GameObject NMIIAOIKHMI, List<APDFELFFFAP> CGMOCIEBKOD, List<AABFENMDIGP> FNCCIKDLAHO, Material ONLGHNANNOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE9F0", Offset = "0x5CEDDF0", VA = "0x185CEE9F0")]
		public void Init(APDFELFFFAP GCPBPIFAIBI, List<AABFENMDIGP> FNCCIKDLAHO, Material ONLGHNANNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF1C0", Offset = "0x5CEE5C0", VA = "0x185CEF1C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF110", Offset = "0x5CEE510", VA = "0x185CEF110")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF0D0", Offset = "0x5CEE4D0", VA = "0x185CEF0D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5CEEEA0", Offset = "0x5CEE2A0", VA = "0x185CEEEA0")]
		private void KGPJLHLIPFN(ScriptableRenderContext GKMHGIGLKCO, Camera[] NJPCPAHNLHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE830", Offset = "0x5CEDC30", VA = "0x185CEE830")]
		private void FPKFDGDENED(CommandBuffer IFHMGGLAKKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	internal class _RRAssemblyIndex : JAMCEJDIEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF3A0", Offset = "0x5CEE7A0", VA = "0x185CEF3A0", Slot = "4")]
		public sealed override void PJNICPDDEAL()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class NLJAGALCJKH
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] JCLCDCCNAPM;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int BKAHGFCDIKL;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int GJMNCFGIJLO;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger MOEAOMJCPNL;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NLJAGALCJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAA80", Offset = "0x5CE9E80", VA = "0x185CEAA80")]
	private static string EMKPABEMONO(byte[] IKDBBHHKFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAB90", Offset = "0x5CE9F90", VA = "0x185CEAB90")]
	public static string NJEIEMNKMPN(byte[] EEMDNKKFCBK, bool DIMJIPPBEJB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
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
