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
public enum NKAPCBBPHFN
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
public static class NLIFGDJOKBA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF9B0", Offset = "0x3FEE1B0", VA = "0x183FEF9B0")]
	public static bool PMDHGNJEFOE(this NKAPCBBPHFN NEELEPEAPAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF970", Offset = "0x3FEE170", VA = "0x183FEF970")]
	public static bool HPCPCJCADFN(this NKAPCBBPHFN NEELEPEAPAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF980", Offset = "0x3FEE180", VA = "0x183FEF980")]
	public static bool KGNCBKADFJG(this NKAPCBBPHFN NEELEPEAPAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum INACIJIAAHE
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
public enum CLIKFAAOGDC
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
public enum IGFMCOLGPHP
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
	ScopeRoot,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	PivotHover
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum MOIAKKPEEBP
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MKJFFAPOADO : OADNLLMNKKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const byte GJKJINIIAOL = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private byte KEICGKINANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<SkinnedShapeRenderer>[] CJDNABIENHM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NIJEEBNCCDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x653E50", Offset = "0x652650", VA = "0x180653E50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC10", Offset = "0x6FD410", VA = "0x1806FEC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NLCLFHGBEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6C1960", Offset = "0x6C0160", VA = "0x1806C1960", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD244E0", Offset = "0xD22CE0", VA = "0x180D244E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float BLKIOFMDDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x771B20", Offset = "0x770320", VA = "0x180771B20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B9320", Offset = "0x7B7B20", VA = "0x1807B9320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float DAODOECDLCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE090", Offset = "0x6FC890", VA = "0x1806FE090", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xF15C80", Offset = "0xF14480", VA = "0x180F15C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> JOOBNAELBGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3FEE560", Offset = "0x3FECD60", VA = "0x183FEE560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> PLFLLIKGCNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C170", Offset = "0x2F0A970", VA = "0x182F0C170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject FMFDBHIKOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x638B30", Offset = "0x637330", VA = "0x180638B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x671B60", Offset = "0x670360", VA = "0x180671B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte MKFIDJMKDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3FEE5C0", Offset = "0x3FECDC0", VA = "0x183FEE5C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3FEEAE0", Offset = "0x3FED2E0", VA = "0x183FEEAE0")]
	public MKJFFAPOADO(List<ONFNDHNIGKO> GNGOBNCJIPA, List<ONFNDHNIGKO> EHNBKKPMGGK, List<KAKBADJGMGN> IMNFLGCLHHE, Material EKGAFHMHOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE8E0", Offset = "0x3FED0E0", VA = "0x183FEE8E0")]
	private int JMDEOFIIOAJ(List<ONFNDHNIGKO> OINHIBDGMGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE780", Offset = "0x3FECF80", VA = "0x183FEE780")]
	private void IIMFFOPCEFK(int PELJIHMJKED, bool NIJAIOIBGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE9F0", Offset = "0x3FED1F0", VA = "0x183FEE9F0")]
	public void JOMJGMKFOCC(Vector3 CGKCDCOICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE610", Offset = "0x3FECE10", VA = "0x183FEE610", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE740", Offset = "0x3FECF40", VA = "0x183FEE740")]
	public void EFJGOMCEMKE(Transform APINFOGMKGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GNNGOKENKPG : DFPCHAAPCIO, PIKJPLDFGJH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class ENNICGAKEHB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public GNNGOKENKPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x61A260", Offset = "0x618A60", VA = "0x18061A260")]
		[DebuggerHidden]
		public ENNICGAKEHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8360", Offset = "0x3FE6B60", VA = "0x183FE8360", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7EB0", Offset = "0x3FE66B0", VA = "0x183FE7EB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3FE84E0", Offset = "0x3FE6CE0", VA = "0x183FE84E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8520", Offset = "0x3FE6D20", VA = "0x183FE8520")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8570", Offset = "0x3FE6D70", VA = "0x183FE8570")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8310", Offset = "0x3FE6B10", VA = "0x183FE8310", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8270", Offset = "0x3FE6A70", VA = "0x183FE8270", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8270", Offset = "0x3FE6A70", VA = "0x183FE8270", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DFDHMOBDADB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GNNGOKENKPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x61A260", Offset = "0x618A60", VA = "0x18061A260")]
		[DebuggerHidden]
		public DFDHMOBDADB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7AC0", Offset = "0x3FE62C0", VA = "0x183FE7AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7720", Offset = "0x3FE5F20", VA = "0x183FE7720", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7BE0", Offset = "0x3FE63E0", VA = "0x183FE7BE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7C30", Offset = "0x3FE6430", VA = "0x183FE7C30")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7A70", Offset = "0x3FE6270", VA = "0x183FE7A70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3FE79D0", Offset = "0x3FE61D0", VA = "0x183FE79D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3FE79D0", Offset = "0x3FE61D0", VA = "0x183FE79D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly EEGCOOOFOPL FIDHGCNCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<CCCPHHLILFJ> KJOJEDGKAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<ClusterMeshRenderer> BLHPHEFMFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private BatchedMeshRenderer ILLLPFBFCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool NKAPLINGOAA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<ECCCEBCEPGB> MIGJHEGGONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CCHLFJEPOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3FEA160", Offset = "0x3FE8960", VA = "0x183FEA160", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public KAKBADJGMGN NEPJDELKBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3FE9930", Offset = "0x3FE8130", VA = "0x183FE9930", Slot = "7")]
		get
		{
			return default(KAKBADJGMGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> PJPINLBGLIO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5F99A0", Offset = "0x5F81A0", VA = "0x1805F99A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6440", Offset = "0x6D4C40", VA = "0x1806D6440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3FEAA90", Offset = "0x3FE9290", VA = "0x183FEAA90")]
	public GNNGOKENKPG(EEGCOOOFOPL DMDONNOOOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9A70", Offset = "0x3FE8270", VA = "0x183FE9A70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA9A0", Offset = "0x3FE91A0", VA = "0x183FEA9A0")]
	public void NLKJJINIDJF(CCCPHHLILFJ OJJBNOGLDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA7B0", Offset = "0x3FE8FB0", VA = "0x183FEA7B0")]
	public void NHIAFFMKOAF(CCCPHHLILFJ OJJBNOGLDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9B80", Offset = "0x3FE8380", VA = "0x183FE9B80", Slot = "4")]
	public void ILLEJEMGBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9880", Offset = "0x3FE8080", VA = "0x183FE9880")]
	public void APPMGKEFBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA820", Offset = "0x3FE9020", VA = "0x183FEA820")]
	private void NLADIEFPHEJ(List<CCCPHHLILFJ> KJOJEDGKAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9A00", Offset = "0x3FE8200", VA = "0x183FE9A00")]
	private static Material DGAOGDOMLLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA950", Offset = "0x3FE9150", VA = "0x183FEA950")]
	private void NLADIEFPHEJ(CCCPHHLILFJ OJJBNOGLDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA090", Offset = "0x3FE8890", VA = "0x183FEA090")]
	private void JFJAOCMIOEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA230", Offset = "0x3FE8A30", VA = "0x183FEA230")]
	public void NDEKFEKNIIC(bool GOHFEOLFGDJ, bool DEODMBGENEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA1A0", Offset = "0x3FE89A0", VA = "0x183FEA1A0")]
	protected void KIABMGEKGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9B10", Offset = "0x3FE8310", VA = "0x183FE9B10")]
	[IteratorStateMachine(typeof(ENNICGAKEHB))]
	public IEnumerable<Renderer> IIHLLDBOPBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9AA0", Offset = "0x3FE82A0", VA = "0x183FE9AA0")]
	[IteratorStateMachine(typeof(DFDHMOBDADB))]
	public IEnumerable<Renderer> HAADHCKGKOB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class NBFIPOHFAIC : CCCPHHLILFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly JJGDCGCAHCL GMLBPGNHOCA;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC400", Offset = "0x3FEAC00", VA = "0x183FEC400")]
	public NBFIPOHFAIC(GNNGOKENKPG JLGIFIFDIOJ, JJGDCGCAHCL DMDONNOOOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3FEEE10", Offset = "0x3FED610", VA = "0x183FEEE10", Slot = "13")]
	public override int JMDEOFIIOAJ(HNKOBDJPCKI NELKFHKGKDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF6C0", Offset = "0x3FEDEC0", VA = "0x183FEF6C0", Slot = "14")]
	public override int OPENOLFFFMM(HNKOBDJPCKI NELKFHKGKDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3FEEFF0", Offset = "0x3FED7F0", VA = "0x183FEEFF0", Slot = "15")]
	public override void OHKHCAHJJLJ(HNKOBDJPCKI NELKFHKGKDN, AEKAKDEBMEA CGHDGNPAENF, int PHBINMHOLHI = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NFCOJNJHDMK : global::KDFMKIHLJFP<NFCOJNJHDMK>, ECOGJIGKDHI, IEquatable<NFCOJNJHDMK>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PDGADEKDACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E86C0", VA = "0x1807E9EC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x825F70", Offset = "0x824770", VA = "0x180825F70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JLICIKJPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xECE690", Offset = "0xECCE90", VA = "0x180ECE690", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xF35920", Offset = "0xF34120", VA = "0x180F35920", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool CPNLIKCPMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF8A0", Offset = "0x3FEE0A0", VA = "0x183FEF8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2EFCA90", Offset = "0x2EFB290", VA = "0x182EFCA90", Slot = "8")]
	public bool Equals(NFCOJNJHDMK ALBOAABJIJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xFA8350", Offset = "0xFA6B50", VA = "0x180FA8350")]
	public static bool LLPKNBIICCC(NFCOJNJHDMK DKLHMFCLOAB, NFCOJNJHDMK FLEBMPFFCAA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1C8BD70", Offset = "0x1C8A570", VA = "0x181C8BD70")]
	public static bool PNNBKKFLHKP(NFCOJNJHDMK DKLHMFCLOAB, NFCOJNJHDMK FLEBMPFFCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF8E0", Offset = "0x3FEE0E0", VA = "0x183FEF8E0", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E86C0", VA = "0x1807E9EC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum KKIDDOEMLOJ
{
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EEGCOOOFOPL
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	KAKBADJGMGN NBJIGELBGDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	KKIDDOEMLOJ NCMOPOMNKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FIMCPCGNAEE : global::KDFMKIHLJFP<FIMCPCGNAEE>, ECOGJIGKDHI, IEquatable<FIMCPCGNAEE>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int PDGADEKDACK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E86C0", VA = "0x1807E9EC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x825F70", Offset = "0x824770", VA = "0x180825F70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JLICIKJPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xECE690", Offset = "0xECCE90", VA = "0x180ECE690", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xF35920", Offset = "0xF34120", VA = "0x180F35920", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CPNLIKCPMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3FE85C0", Offset = "0x3FE6DC0", VA = "0x183FE85C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2EFCA90", Offset = "0x2EFB290", VA = "0x182EFCA90", Slot = "8")]
	public bool Equals(FIMCPCGNAEE ALBOAABJIJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xFA8350", Offset = "0xFA6B50", VA = "0x180FA8350")]
	public static bool LLPKNBIICCC(FIMCPCGNAEE DKLHMFCLOAB, FIMCPCGNAEE FLEBMPFFCAA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1C8BD70", Offset = "0x1C8A570", VA = "0x181C8BD70")]
	public static bool PNNBKKFLHKP(FIMCPCGNAEE DKLHMFCLOAB, FIMCPCGNAEE FLEBMPFFCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3FE8600", Offset = "0x3FE6E00", VA = "0x183FE8600", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E86C0", VA = "0x1807E9EC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DNHAAPFOONG
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	KAKBADJGMGN NBJIGELBGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float LBKDLLLCPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 BMHIPIBNNJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	NKAPCBBPHFN BJNPOAENNPL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	INACIJIAAHE IDLOLJBPCMN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AEPCJDEHMGE : DNHAAPFOONG
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	AEMGFECCNEB NHCNADGAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool IJKKCKGACPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JJGDCGCAHCL : DNHAAPFOONG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool PNNFKLNJGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool OCIMFHAGIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float BFFADGGLCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int LIJNGFMKKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool FCDKMCNCKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int KCMCKPBJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<MMOJNBNBLJK> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HIIKCJJCMCG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCINNLNPPCD(NFCOJNJHDMK JLGIFIFDIOJ, IGFMCOLGPHP INBPHFALNCP);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCINNLNPPCD(FIMCPCGNAEE OJJBNOGLDMN, IGFMCOLGPHP INBPHFALNCP);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNLMFJLMFFC(FIMCPCGNAEE OJJBNOGLDMN);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMODNODIGKF(FIMCPCGNAEE OJJBNOGLDMN);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMDAKBHACCF();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFAJJPFOCDA();

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EHIHOAHFFPM(IGFMCOLGPHP BKDBLJPNPPJ);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DLJPLFKMFHP(NFCOJNJHDMK JLGIFIFDIOJ);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DLJPLFKMFHP(FIMCPCGNAEE OJJBNOGLDMN);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ADMFKODMDKI(NFCOJNJHDMK JLGIFIFDIOJ, MOIAKKPEEBP BKDBLJPNPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ADMFKODMDKI(FIMCPCGNAEE OJJBNOGLDMN, MOIAKKPEEBP BKDBLJPNPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ODJBABIINAG(FIMCPCGNAEE OJJBNOGLDMN);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GGODLAEPJJM(FIMCPCGNAEE OJJBNOGLDMN);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LIBELBHPNGG();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IOIKIDLOOPI();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BDNFHHGNBKM(MOIAKKPEEBP BKDBLJPNPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OCHCBENBBHP(NFCOJNJHDMK JLGIFIFDIOJ, Vector3 LLBCHDAKBHH, Vector3 ENJPMILPGGL, Vector3 MOEEMEAPCHN, float FINFKHGMCDL, float OGCEEDDOEND, IReadOnlyList<Camera> DNNEPFFKCOD, CLIKFAAOGDC JILLKAFHNDL);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OCHCBENBBHP(PIMLGEDBMOP FABGEOBEGBH, Vector3 LLBCHDAKBHH, Vector3 ENJPMILPGGL, Vector3 MOEEMEAPCHN, float FINFKHGMCDL, float OGCEEDDOEND);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BPHIMPPJCDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NFCOJNJHDMK AOPBBFLPHHI(EEGCOOOFOPL DMDONNOOOJK);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNDIIFPLEHE(NFCOJNJHDMK JLGIFIFDIOJ);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKJDBMGODNO(NFCOJNJHDMK JLGIFIFDIOJ);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FIMCPCGNAEE CCGNEALLAOC(NFCOJNJHDMK JLGIFIFDIOJ, AEPCJDEHMGE DMDONNOOOJK);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FIMCPCGNAEE PIJLAMDOILM(NFCOJNJHDMK JLGIFIFDIOJ, JJGDCGCAHCL DMDONNOOOJK);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void POPIKLHHADN(FIMCPCGNAEE OJJBNOGLDMN);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PKMLEKAAMBN(FIMCPCGNAEE OJJBNOGLDMN);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PIMLGEDBMOP GANKBIDIPJB(GLLCNFMKEFM DMDONNOOOJK);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HCEBKBGMLDD(PIMLGEDBMOP FABGEOBEGBH);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DKJLOBJCFPB(PIMLGEDBMOP FABGEOBEGBH);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DKINPLPBHJG PLGDKDNHNKI(KAKBADJGMGN CELEFPDHPFN, IEnumerable<FIMCPCGNAEE> KJOJEDGKAEL, int IIAKOFGBBPM);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> BGJKFCAHEHP(NFCOJNJHDMK JLGIFIFDIOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct PIMLGEDBMOP : global::KDFMKIHLJFP<PIMLGEDBMOP>, ECOGJIGKDHI, IEquatable<PIMLGEDBMOP>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int PDGADEKDACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E86C0", VA = "0x1807E9EC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x825F70", Offset = "0x824770", VA = "0x180825F70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int JLICIKJPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xECE690", Offset = "0xECCE90", VA = "0x180ECE690", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xF35920", Offset = "0xF34120", VA = "0x180F35920", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CPNLIKCPMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3FF39D0", Offset = "0x3FF21D0", VA = "0x183FF39D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2EFCA90", Offset = "0x2EFB290", VA = "0x182EFCA90", Slot = "8")]
	public bool Equals(PIMLGEDBMOP ALBOAABJIJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xFA8350", Offset = "0xFA6B50", VA = "0x180FA8350")]
	public static bool LLPKNBIICCC(PIMLGEDBMOP DKLHMFCLOAB, PIMLGEDBMOP FLEBMPFFCAA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1C8BD70", Offset = "0x1C8A570", VA = "0x181C8BD70")]
	public static bool PNNBKKFLHKP(PIMLGEDBMOP DKLHMFCLOAB, PIMLGEDBMOP FLEBMPFFCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3FF3A10", Offset = "0x3FF2210", VA = "0x183FF3A10", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E86C0", VA = "0x1807E9EC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GLLCNFMKEFM
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int KEAIOJBAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform LICENNODDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool PKKEODEMACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NFCOJNJHDMK GetBone(int NIJBEKDMAGD);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int NIJBEKDMAGD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class JCNODNDBIJK : CCCPHHLILFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly AEPCJDEHMGE MNKMGBKNCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int[] AIPKLELFNGG;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override BDOFOPAKEHF ONBFABJMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3FEAB20", Offset = "0x3FE9320", VA = "0x183FEAB20", Slot = "12")]
		get
		{
			return default(BDOFOPAKEHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 CCMLEACHFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3FEAF20", Offset = "0x3FE9720", VA = "0x183FEAF20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC400", Offset = "0x3FEAC00", VA = "0x183FEC400")]
	public JCNODNDBIJK(GNNGOKENKPG JLGIFIFDIOJ, AEPCJDEHMGE DMDONNOOOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB5C0", Offset = "0x3FE9DC0", VA = "0x183FEB5C0", Slot = "11")]
	public override bool NABIEKAFMMI(KAKBADJGMGN JLGIFIFDIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB2A0", Offset = "0x3FE9AA0", VA = "0x183FEB2A0", Slot = "13")]
	public override int JMDEOFIIOAJ(HNKOBDJPCKI NELKFHKGKDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC360", Offset = "0x3FEAB60", VA = "0x183FEC360", Slot = "14")]
	public override int OPENOLFFFMM(HNKOBDJPCKI NELKFHKGKDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB340", Offset = "0x3FE9B40", VA = "0x183FEB340")]
	private int LNJGPEPAOKN(HNKOBDJPCKI NELKFHKGKDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3FEBAA0", Offset = "0x3FEA2A0", VA = "0x183FEBAA0", Slot = "15")]
	public override void OHKHCAHJJLJ(HNKOBDJPCKI NELKFHKGKDN, AEKAKDEBMEA CGHDGNPAENF, int PHBINMHOLHI = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GIPELEEBJIL
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMMJOBGKMJH(MOIAKKPEEBP BKDBLJPNPPJ, Renderer JMJBPNKDLMN, int NGPJAFMJMGB);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBDFDMFGEHO(Renderer JMJBPNKDLMN, CLIKFAAOGDC JILLKAFHNDL, Vector3 LLBCHDAKBHH, Vector3 ENJPMILPGGL, Vector3 MOEEMEAPCHN, float FINFKHGMCDL, float OGCEEDDOEND, float EAPAKMKJEBN = -1f, [Optional] Color? NDEHEJIJFDM, [Optional] IReadOnlyList<Camera> GMBPAPOEFBL);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOPDONAFHEK(Renderer JMJBPNKDLMN, int NGPJAFMJMGB);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HOKLCFGJIGC();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KAMCNIAEBHP(int OGMLAFEEMIC, IGFMCOLGPHP BKDBLJPNPPJ, Renderer JMJBPNKDLMN, int NGPJAFMJMGB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KJFIKJNJMBG : HIIKCJJCMCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class CBNLMHHNEKC : global::BPFPOPAPLIG<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3FE75D0", Offset = "0x3FE5DD0", VA = "0x183FE75D0")]
		public CBNLMHHNEKC(string JNAACNJBHOF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly GIPELEEBJIL OJEDENCPLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly EOOHDIPKCFL HJKGGEDNJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private MeshRenderer KFJKOPFLELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private CBNLMHHNEKC KJJJKEPDIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool AJIFHDPMJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private MeshRenderer HIOLHEBNKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private CBNLMHHNEKC HENAICOFDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool DEKMLGLKKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private MeshRenderer OCPJPBILBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private CBNLMHHNEKC OPLELCPNNEP;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAF0", Offset = "0x6FD2F0", VA = "0x1806FEAF0")]
	public KJFIKJNJMBG(GIPELEEBJIL LNKFBDBGOME, EOOHDIPKCFL HJKGGEDNJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3FED690", Offset = "0x3FEBE90", VA = "0x183FED690", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3FEDAE0", Offset = "0x3FEC2E0", VA = "0x183FEDAE0")]
	private void IANBOCJCLMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3FED0A0", Offset = "0x3FEB8A0", VA = "0x183FED0A0", Slot = "4")]
	public void CCINNLNPPCD(NFCOJNJHDMK JLGIFIFDIOJ, IGFMCOLGPHP INBPHFALNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3FECED0", Offset = "0x3FEB6D0", VA = "0x183FECED0", Slot = "5")]
	public void CCINNLNPPCD(FIMCPCGNAEE OJJBNOGLDMN, IGFMCOLGPHP INBPHFALNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3FECDD0", Offset = "0x3FEB5D0", VA = "0x183FECDD0", Slot = "6")]
	public void BNLMFJLMFFC(FIMCPCGNAEE OJJBNOGLDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3FEDCD0", Offset = "0x3FEC4D0", VA = "0x183FEDCD0", Slot = "7")]
	public void LMODNODIGKF(FIMCPCGNAEE OJJBNOGLDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3FECAF0", Offset = "0x3FEB2F0", VA = "0x183FECAF0", Slot = "8")]
	public void AMDAKBHACCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x87A4D0", Offset = "0x878CD0", VA = "0x18087A4D0", Slot = "9")]
	public void CFAJJPFOCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3FED860", Offset = "0x3FEC060", VA = "0x183FED860", Slot = "10")]
	public void EHIHOAHFFPM(IGFMCOLGPHP INBPHFALNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3FED4F0", Offset = "0x3FEBCF0", VA = "0x183FED4F0", Slot = "11")]
	public void DLJPLFKMFHP(NFCOJNJHDMK JLGIFIFDIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3FED270", Offset = "0x3FEBA70", VA = "0x183FED270", Slot = "12")]
	public void DLJPLFKMFHP(FIMCPCGNAEE OJJBNOGLDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC950", Offset = "0x3FEB150", VA = "0x183FEC950", Slot = "13")]
	public void ADMFKODMDKI(NFCOJNJHDMK JLGIFIFDIOJ, MOIAKKPEEBP BKDBLJPNPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC7B0", Offset = "0x3FEAFB0", VA = "0x183FEC7B0", Slot = "14")]
	public void ADMFKODMDKI(FIMCPCGNAEE OJJBNOGLDMN, MOIAKKPEEBP BKDBLJPNPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3FEDC90", Offset = "0x3FEC490", VA = "0x183FEDC90", Slot = "17")]
	public void LIBELBHPNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE4C0", Offset = "0x3FECCC0", VA = "0x183FEE4C0", Slot = "15")]
	public void ODJBABIINAG(FIMCPCGNAEE OJJBNOGLDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3FEDA50", Offset = "0x3FEC250", VA = "0x183FEDA50", Slot = "16")]
	public void GGODLAEPJJM(FIMCPCGNAEE OJJBNOGLDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x18BA010", Offset = "0x18B8810", VA = "0x1818BA010", Slot = "18")]
	public void IOIKIDLOOPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3FECB30", Offset = "0x3FEB330", VA = "0x183FECB30", Slot = "19")]
	public void BDNFHHGNBKM(MOIAKKPEEBP BKDBLJPNPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3FECC20", Offset = "0x3FEB420", VA = "0x183FECC20")]
	private void BNDDHCHNMJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC610", Offset = "0x3FEAE10", VA = "0x183FEC610")]
	public void ADMFKODMDKI(FIMCPCGNAEE OJJBNOGLDMN, MOIAKKPEEBP BKDBLJPNPPJ, bool BALLDGNNICN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3FED990", Offset = "0x3FEC190", VA = "0x183FED990")]
	private void FMMJOBGKMJH(MOIAKKPEEBP BKDBLJPNPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE190", Offset = "0x3FEC990", VA = "0x183FEE190", Slot = "20")]
	public void OCHCBENBBHP(NFCOJNJHDMK JLGIFIFDIOJ, Vector3 LLBCHDAKBHH, Vector3 ENJPMILPGGL, Vector3 MOEEMEAPCHN, float FINFKHGMCDL, float OGCEEDDOEND, IReadOnlyList<Camera> DNNEPFFKCOD, CLIKFAAOGDC JILLKAFHNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3FEDDC0", Offset = "0x3FEC5C0", VA = "0x183FEDDC0", Slot = "21")]
	public void OCHCBENBBHP(PIMLGEDBMOP FABGEOBEGBH, Vector3 LLBCHDAKBHH, Vector3 ENJPMILPGGL, Vector3 MOEEMEAPCHN, float FINFKHGMCDL, float OGCEEDDOEND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class CCCPHHLILFJ : BKMLOGCMLGK, ECCCEBCEPGB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly GNNGOKENKPG FMFDBHIKOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	protected Bounds JEDHGFJIDKK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds KIDOCIHJLII
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xECAF20", Offset = "0xEC9720", VA = "0x180ECAF20", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual BDOFOPAKEHF ONBFABJMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7620", Offset = "0x3FE5E20", VA = "0x183FE7620", Slot = "12")]
		get
		{
			return default(BDOFOPAKEHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x60E9F0", Offset = "0x60D1F0", VA = "0x18060E9F0")]
	protected CCCPHHLILFJ(GNNGOKENKPG JLGIFIFDIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3FE76B0", Offset = "0x3FE5EB0", VA = "0x183FE76B0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "11")]
	public virtual bool NABIEKAFMMI(KAKBADJGMGN JLGIFIFDIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int JMDEOFIIOAJ(HNKOBDJPCKI NELKFHKGKDN);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int OPENOLFFFMM(HNKOBDJPCKI NELKFHKGKDN);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void OHKHCAHJJLJ(HNKOBDJPCKI NELKFHKGKDN, AEKAKDEBMEA CGHDGNPAENF, int PHBINMHOLHI = -1);
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
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3AA0", Offset = "0x3FF22A0", VA = "0x183FF3AA0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum AEMGFECCNEB
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class OLKAJGEDMAN
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JEGAJGADPME : IEnumerable<PGKPKIHNDBE>, IEnumerable, IEnumerator<PGKPKIHNDBE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private PGKPKIHNDBE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private PGKPKIHNDBE System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x61A260", Offset = "0x618A60", VA = "0x18061A260")]
		[DebuggerHidden]
		public JEGAJGADPME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC450", Offset = "0x3FEAC50", VA = "0x183FEC450", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC5C0", Offset = "0x3FEADC0", VA = "0x183FEC5C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC530", Offset = "0x3FEAD30", VA = "0x183FEC530", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PGKPKIHNDBE> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC530", Offset = "0x3FEAD30", VA = "0x183FEC530", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const int NCACDMOKGJE = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static PGKPKIHNDBE[][] CCIBDOHOJBD;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static KDJLPPFHPAI ODNFJCMDGOD;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static ShapeRendererConfig PNHOFDGIMPO;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader KMHNLFBLFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3FF08A0", Offset = "0x3FEF0A0", VA = "0x183FF08A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer FGCHAKFMAMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3FF0B30", Offset = "0x3FEF330", VA = "0x183FF0B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0BA0", Offset = "0x3FEF3A0", VA = "0x183FF0BA0")]
	public static Mesh OMDIJHAPIGN(AEMGFECCNEB HOBICBJOAEM, int NELKFHKGKDN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3FF02F0", Offset = "0x3FEEAF0", VA = "0x183FF02F0")]
	public static int CANKEOMBFGJ(AEMGFECCNEB HOBICBJOAEM, int NELKFHKGKDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0320", Offset = "0x3FEEB20", VA = "0x183FF0320")]
	public static KDJLPPFHPAI DDEHEFJNICE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0910", Offset = "0x3FEF110", VA = "0x183FF0910")]
	[IteratorStateMachine(typeof(JEGAJGADPME))]
	private static IEnumerable<PGKPKIHNDBE> LPGFCCLIILD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3FEFD90", Offset = "0x3FEE590", VA = "0x183FEFD90")]
	public static PGKPKIHNDBE AJBDHBDCMCI(AEMGFECCNEB HOBICBJOAEM, int NELKFHKGKDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0300", Offset = "0x3FEEB00", VA = "0x183FF0300")]
	public static bool CFBBAELFKHO(this AEMGFECCNEB HOBICBJOAEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0970", Offset = "0x3FEF170", VA = "0x183FF0970")]
	public static void MJKPHLMLBNH(AEMGFECCNEB HOBICBJOAEM, float3 ECHBPLHNGAF, out DBFBGLBFEKN HOOGAHGBOEC, out float3 LIOAFGENJJG, out float PPMKGIHCGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0470", Offset = "0x3FEEC70", VA = "0x183FF0470")]
	public static void EMCPIIFLLLI(Vector3 ECHBPLHNGAF, AEMGFECCNEB HOBICBJOAEM, out Vector3 LIOAFGENJJG, out float PPMKGIHCGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0890", Offset = "0x3FEF090", VA = "0x183FF0890")]
	[ENAJMPNKNEO(BGCJOGMHLOH.ExitingPlayMode, 0)]
	private static void GPFIAKCGGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3FF00D0", Offset = "0x3FEE8D0", VA = "0x183FF00D0")]
	[ENAJMPNKNEO(BGCJOGMHLOH.ExitingPlayMode, 0)]
	private static void BAKMCLBIBBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FDALFLKLPKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool EJCCEFFNINF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material GDPOIGKCBDP();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material DGAOGDOMLLB();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material CDEOHOGGPOP();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MNHPBJIABCD(NKAPCBBPHFN NEELEPEAPAK);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ECAONKIHJMC(INACIJIAAHE LIPIBBMMHIE);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PPBNJFMCPFJ(GameObject DEGGOOGCHFA);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LNHHGMINMAL(GameObject DEGGOOGCHFA, bool GPIMMCFAOBO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface EOOHDIPKCFL
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GNNGOKENKPG NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CCCPHHLILFJ NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OPBEKGFHJOE NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class FOGMHBNIHFJ : BPHIMPPJCDN, IDisposable, EOOHDIPKCFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly global::NBHCCKKMIHD<NFCOJNJHDMK, GNNGOKENKPG> ADKILKBFBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly global::NBHCCKKMIHD<FIMCPCGNAEE, CCCPHHLILFJ> KJOJEDGKAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly global::NBHCCKKMIHD<PIMLGEDBMOP, OPBEKGFHJOE> DACEKMKPHBG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static FDALFLKLPKJ LFHHPNCLGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8E40", Offset = "0x3FE7640", VA = "0x183FE8E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8D90", Offset = "0x3FE7590", VA = "0x183FE8D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public GNNGOKENKPG NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8750", Offset = "0x3FE6F50", VA = "0x183FE8750", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public CCCPHHLILFJ NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8690", Offset = "0x3FE6E90", VA = "0x183FE8690", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public OPBEKGFHJOE NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3FE86F0", Offset = "0x3FE6EF0", VA = "0x183FE86F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9410", Offset = "0x3FE7C10", VA = "0x183FE9410")]
	public FOGMHBNIHFJ(FDALFLKLPKJ LNKFBDBGOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3FE8B90", Offset = "0x3FE7390", VA = "0x183FE8B90", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3FE8830", Offset = "0x3FE7030", VA = "0x183FE8830", Slot = "4")]
	public NFCOJNJHDMK AOPBBFLPHHI(EEGCOOOFOPL DMDONNOOOJK)
	{
		return default(NFCOJNJHDMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3FE89D0", Offset = "0x3FE71D0", VA = "0x183FE89D0", Slot = "5")]
	public void BNDIIFPLEHE(NFCOJNJHDMK JLGIFIFDIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3FE87B0", Offset = "0x3FE6FB0", VA = "0x183FE87B0", Slot = "6")]
	public void AKJDBMGODNO(NFCOJNJHDMK JLGIFIFDIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3FE8910", Offset = "0x3FE7110", VA = "0x183FE8910", Slot = "15")]
	public IEnumerable<Renderer> BGJKFCAHEHP(NFCOJNJHDMK JLGIFIFDIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3FE8A30", Offset = "0x3FE7230", VA = "0x183FE8A30", Slot = "7")]
	public FIMCPCGNAEE CCGNEALLAOC(NFCOJNJHDMK JLGIFIFDIOJ, AEPCJDEHMGE DMDONNOOOJK)
	{
		return default(FIMCPCGNAEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3FE8E80", Offset = "0x3FE7680", VA = "0x183FE8E80", Slot = "8")]
	public FIMCPCGNAEE PIJLAMDOILM(NFCOJNJHDMK JLGIFIFDIOJ, JJGDCGCAHCL DMDONNOOOJK)
	{
		return default(FIMCPCGNAEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3FE8F70", Offset = "0x3FE7770", VA = "0x183FE8F70", Slot = "10")]
	public void PKMLEKAAMBN(FIMCPCGNAEE OJJBNOGLDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3FE93B0", Offset = "0x3FE7BB0", VA = "0x183FE93B0", Slot = "9")]
	public void POPIKLHHADN(FIMCPCGNAEE OJJBNOGLDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3FE8C00", Offset = "0x3FE7400", VA = "0x183FE8C00", Slot = "11")]
	public PIMLGEDBMOP GANKBIDIPJB(GLLCNFMKEFM DMDONNOOOJK)
	{
		return default(PIMLGEDBMOP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3FE8B20", Offset = "0x3FE7320", VA = "0x183FE8B20", Slot = "13")]
	public void DKJLOBJCFPB(PIMLGEDBMOP FABGEOBEGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3FE8DE0", Offset = "0x3FE75E0", VA = "0x183FE8DE0", Slot = "12")]
	public void HCEBKBGMLDD(PIMLGEDBMOP FABGEOBEGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3FE8FE0", Offset = "0x3FE77E0", VA = "0x183FE8FE0", Slot = "14")]
	public DKINPLPBHJG PLGDKDNHNKI(KAKBADJGMGN CELEFPDHPFN, IEnumerable<FIMCPCGNAEE> KJOJEDGKAEL, int IIAKOFGBBPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OPBEKGFHJOE : DFPCHAAPCIO
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class NMIOAMJKPJP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public OPBEKGFHJOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x61A260", Offset = "0x618A60", VA = "0x18061A260")]
		[DebuggerHidden]
		public NMIOAMJKPJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3FEFCB0", Offset = "0x3FEE4B0", VA = "0x183FEFCB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF9D0", Offset = "0x3FEE1D0", VA = "0x183FEF9D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3FEFD50", Offset = "0x3FEE550", VA = "0x183FEFD50")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3FEFC60", Offset = "0x3FEE460", VA = "0x183FEFC60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3FEFBC0", Offset = "0x3FEE3C0", VA = "0x183FEFBC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3FEFBC0", Offset = "0x3FEE3C0", VA = "0x183FEFBC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly GLLCNFMKEFM POACOAHDCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly EOOHDIPKCFL HJKGGEDNJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private MKJFFAPOADO MHMMJJBJKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private List<ONFNDHNIGKO> HBNLDIBCINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private List<ONFNDHNIGKO> OBKBFMCPGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private GameObject DBPPNHBLMNE;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2C00", Offset = "0x3FF1400", VA = "0x183FF2C00")]
	public static OPBEKGFHJOE KANOIDJHAAO(GLLCNFMKEFM DMDONNOOOJK, EOOHDIPKCFL HJKGGEDNJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3FF32E0", Offset = "0x3FF1AE0", VA = "0x183FF32E0")]
	private OPBEKGFHJOE(GLLCNFMKEFM DMDONNOOOJK, EOOHDIPKCFL HJKGGEDNJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2D60", Offset = "0x3FF1560", VA = "0x183FF2D60")]
	public void KFAGLIPHBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2120", Offset = "0x3FF0920", VA = "0x183FF2120")]
	[IteratorStateMachine(typeof(NMIOAMJKPJP))]
	public IEnumerable<Renderer> IIHLLDBOPBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2190", Offset = "0x3FF0990", VA = "0x183FF2190", Slot = "4")]
	public void ILLEJEMGBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3FF32B0", Offset = "0x3FF1AB0", VA = "0x183FF32B0")]
	private void KMHMCPFDNGH(Vector3 CGKCDCOICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3FF1EF0", Offset = "0x3FF06F0", VA = "0x183FF1EF0")]
	public void APPMGKEFBBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class ONFNDHNIGKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct KLPIPNCMLIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public AEKAKDEBMEA FLMNGFOOHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public KAKBADJGMGN KPGLHGAEMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int KBDGLDAOLCM;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MNEBLJIFECP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public ONFNDHNIGKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public HNKOBDJPCKI lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public List<KLPIPNCMLIN> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public MNEBLJIFECP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class DPNLAHIEFJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public DKINPLPBHJG combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public MNEBLJIFECP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public DPNLAHIEFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7C70", Offset = "0x3FE6470", VA = "0x183FE7C70")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7CE0", Offset = "0x3FE64E0", VA = "0x183FE7CE0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7D20", Offset = "0x3FE6520", VA = "0x183FE7D20")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private int[] OJDCGNHKGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private CCDBKJCBFMN BNJHPMOABNF;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static Matrix4x4 EAFEFMHEEEP;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh LCLNLFIBKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6790", Offset = "0x5F4F90", VA = "0x1805F6790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int LCDDAMOOHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB50", Offset = "0x6EE350", VA = "0x1806EFB50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xBAAFF0", Offset = "0xBA97F0", VA = "0x180BAAFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3FF13F0", Offset = "0x3FEFBF0", VA = "0x183FF13F0")]
	public void OPMIAPACHDJ(List<KAKBADJGMGN> ICOLEBIGCNO, Matrix4x4[] HBJCAEJEAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0CE0", Offset = "0x3FEF4E0", VA = "0x183FF0CE0")]
	public static List<ONFNDHNIGKO> BHNJDAHDLKD(List<GNNGOKENKPG> IBEPOFFCFKA, HNKOBDJPCKI NELKFHKGKDN, Bounds ENJDOAHDOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3FF1620", Offset = "0x3FEFE20", VA = "0x183FF1620")]
	private JobHandle PCMEHLDBPCA(DKINPLPBHJG OHKOFMAGOFA, int BHONPJHNEGN, int LENNFGJPOJD, HNKOBDJPCKI NELKFHKGKDN, List<KLPIPNCMLIN> HIHLLLLMBJH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3FF12F0", Offset = "0x3FEFAF0", VA = "0x183FF12F0")]
	private void JAMEOIPFGLD(List<KLPIPNCMLIN> HIHLLLLMBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3FF1B40", Offset = "0x3FF0340", VA = "0x183FF1B40")]
	private ONFNDHNIGKO(List<KLPIPNCMLIN> HIHLLLLMBJH, int BHONPJHNEGN, int LENNFGJPOJD, HNKOBDJPCKI NELKFHKGKDN, Bounds ENJDOAHDOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3FF1270", Offset = "0x3FEFA70", VA = "0x183FF1270", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private MaterialPropertyBlock CNFFOPOEDOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private ONFNDHNIGKO IPHBKPGNMFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private List<KAKBADJGMGN> IMNFLGCLHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private RenderTexture GPPBIPIKNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private ComputeBuffer GDCGOLNFJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private ComputeShader LICFNILBLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private Matrix4x4[] FEMCJAAGDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int FFFEPOLLIKD;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer PNDCMPMGNMF
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x643F60", Offset = "0x642760", VA = "0x180643F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int KEAIOJBAOMI
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4620", Offset = "0x3FF2E20", VA = "0x183FF4620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3AD0", Offset = "0x3FF22D0", VA = "0x183FF3AD0")]
		public static List<SkinnedShapeRenderer> Create(GameObject JLGIFIFDIOJ, List<ONFNDHNIGKO> OINHIBDGMGG, List<KAKBADJGMGN> IMNFLGCLHHE, Material EKGAFHMHOCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3CE0", Offset = "0x3FF24E0", VA = "0x183FF3CE0")]
		public void Init(ONFNDHNIGKO IPHBKPGNMFN, List<KAKBADJGMGN> IMNFLGCLHHE, Material EKGAFHMHOCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4380", Offset = "0x3FF2B80", VA = "0x183FF4380")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3FF42F0", Offset = "0x3FF2AF0", VA = "0x183FF42F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3FF42B0", Offset = "0x3FF2AB0", VA = "0x183FF42B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4410", Offset = "0x3FF2C10", VA = "0x183FF4410")]
		private void PAJFNGFEPIP(ScriptableRenderContext ALLCABKLNNG, Camera[] NMOGLNLLDJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4100", Offset = "0x3FF2900", VA = "0x183FF4100")]
		private void OPMIAPACHDJ(CommandBuffer EKHMBPMABBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class PGKFNNKCMAN
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static byte[] EGKMOPGLIPA;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static int JGABFFAEPHC;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static int OCNADIFHHML;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static BigInteger GACCCDCMEHO;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PGKFNNKCMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3FF33E0", Offset = "0x3FF1BE0", VA = "0x183FF33E0")]
	private static string HDJAHDEMDDI(byte[] FLEBMPFFCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3FF34E0", Offset = "0x3FF1CE0", VA = "0x183FF34E0")]
	public static string OMJPKAOBENG(byte[] FCDIIMLAMIO, bool PCFPPGPONLG)
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
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
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
