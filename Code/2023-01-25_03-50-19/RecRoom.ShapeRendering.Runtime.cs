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
public enum MHHFNFHDGIG
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
public static class HHEBGFNPJFN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D33EC0", Offset = "0x5D32EC0", VA = "0x185D33EC0")]
	public static bool CCADKADHEJM(this MHHFNFHDGIG PBDKOPGIDIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D33EE0", Offset = "0x5D32EE0", VA = "0x185D33EE0")]
	public static bool FLALIPGEMHN(this MHHFNFHDGIG PBDKOPGIDIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D33E90", Offset = "0x5D32E90", VA = "0x185D33E90")]
	public static bool CAKNJGKEMJL(this MHHFNFHDGIG PBDKOPGIDIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OIDLICMIMPF
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
public enum NHMGKKKMIFG
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
public enum BLKLDEDCCPH
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
public enum OHNLEEOCOPK
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
public class LIGGAKDGDHA : KEAODLAOGFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte KOANAOBMHKF = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte DFLNMPHCGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] GHKCPMCHGAK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MJFLJCIEDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67E010", Offset = "0x67D010", VA = "0x18067E010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CC0", Offset = "0x6C6CC0", VA = "0x1806C7CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int OECNMEFLDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69ED90", Offset = "0x69DD90", VA = "0x18069ED90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8139D0", Offset = "0x8129D0", VA = "0x1808139D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float GCOMHMEACPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xEC5C90", Offset = "0xEC4C90", VA = "0x180EC5C90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x15E44D0", Offset = "0x15E34D0", VA = "0x1815E44D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float HJMOFEINKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE56B60", Offset = "0xE55B60", VA = "0x180E56B60", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x15E44C0", Offset = "0x15E34C0", VA = "0x1815E44C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> OGBEEGENKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D38060", Offset = "0x5D37060", VA = "0x185D38060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> NOJKNBOLLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x590D2D0", Offset = "0x590C2D0", VA = "0x18590D2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject GHOIKAHCODP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x716AE0", Offset = "0x715AE0", VA = "0x180716AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte DIEAJHAAPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D380C0", Offset = "0x5D370C0", VA = "0x185D380C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D38220", Offset = "0x5D37220", VA = "0x185D38220")]
	public LIGGAKDGDHA(List<EFELGCKLPJM> MBCMKIEDEDB, List<EFELGCKLPJM> KMFJEIBCGHE, List<BPHMPHDMJMJ> FGBLCHBPPFG, Material FNBKMDAGGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D38110", Offset = "0x5D37110", VA = "0x185D38110")]
	private int MLLFDCEFGKP(List<EFELGCKLPJM> GCELFLGKONE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D37F10", Offset = "0x5D36F10", VA = "0x185D37F10")]
	private void GOOHCGCFCPA(int OCKAKBGHAPC, bool FLGLFAGJDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D37D00", Offset = "0x5D36D00", VA = "0x185D37D00")]
	public void BFFNBGCGNIL(Vector3 JKNLCGKMCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D37DA0", Offset = "0x5D36DA0", VA = "0x185D37DA0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D37ED0", Offset = "0x5D36ED0", VA = "0x185D37ED0")]
	public void EOIEGHJPIMH(Transform ILLOHFNHBPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class ELLLBMBMEID : LIELAELGJMI, FIADMLCONMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LCJPLOEDEEI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public ELLLBMBMEID <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
		[DebuggerHidden]
		public LCJPLOEDEEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5D37B10", Offset = "0x5D36B10", VA = "0x185D37B10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5D375E0", Offset = "0x5D365E0", VA = "0x185D375E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5D37C10", Offset = "0x5D36C10", VA = "0x185D37C10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D37C60", Offset = "0x5D36C60", VA = "0x185D37C60")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D37CB0", Offset = "0x5D36CB0", VA = "0x185D37CB0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5D37AD0", Offset = "0x5D36AD0", VA = "0x185D37AD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D37A30", Offset = "0x5D36A30", VA = "0x185D37A30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D37A30", Offset = "0x5D36A30", VA = "0x185D37A30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JGKGNIFFJGJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public ELLLBMBMEID <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
		[DebuggerHidden]
		public JGKGNIFFJGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5D35400", Offset = "0x5D34400", VA = "0x185D35400", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5D35040", Offset = "0x5D34040", VA = "0x185D35040", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5D354E0", Offset = "0x5D344E0", VA = "0x185D354E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5D35530", Offset = "0x5D34530", VA = "0x185D35530")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5D353C0", Offset = "0x5D343C0", VA = "0x185D353C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5D35320", Offset = "0x5D34320", VA = "0x185D35320", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5D35320", Offset = "0x5D34320", VA = "0x185D35320", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly GNDPCPPCPDC AFECGMOBLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<EANBBOJBOJN> KHEGBNANOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> GPCPCBEHKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer BHGDHDCCIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool HGGEJEPBBGN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<DBEHKDPLJGC> BONCDINEEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KJBKNGLKNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5D32310", Offset = "0x5D31310", VA = "0x185D32310", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BPHMPHDMJMJ JOPDCDIOOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5D320C0", Offset = "0x5D310C0", VA = "0x185D320C0", Slot = "7")]
		get
		{
			return default(BPHMPHDMJMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> JOFJJDBIJDA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x685570", Offset = "0x684570", VA = "0x180685570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x685590", Offset = "0x684590", VA = "0x180685590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D33240", Offset = "0x5D32240", VA = "0x185D33240")]
	public ELLLBMBMEID(GNDPCPPCPDC FILAKGLBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D31FD0", Offset = "0x5D30FD0", VA = "0x185D31FD0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D32350", Offset = "0x5D31350", VA = "0x185D32350")]
	public void HMNAIPBHJIK(EANBBOJBOJN NIEICLFNAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D32000", Offset = "0x5D31000", VA = "0x185D32000")]
	public void FAHLDBEBGON(EANBBOJBOJN NIEICLFNAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D324D0", Offset = "0x5D314D0", VA = "0x185D324D0", Slot = "4")]
	public void JBHLEMLNGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D33190", Offset = "0x5D32190", VA = "0x185D33190")]
	public void PGLCEDHDGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D321E0", Offset = "0x5D311E0", VA = "0x185D321E0")]
	private void GKDIDLBOPNE(List<EANBBOJBOJN> KHEGBNANOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D330C0", Offset = "0x5D320C0", VA = "0x185D330C0")]
	private static Material ONGFNDHOFJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D32190", Offset = "0x5D31190", VA = "0x185D32190")]
	private void GKDIDLBOPNE(EANBBOJBOJN NIEICLFNAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D32F60", Offset = "0x5D31F60", VA = "0x185D32F60")]
	private void LNHMHFMBHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D32A40", Offset = "0x5D31A40", VA = "0x185D32A40")]
	public void KPKKABFAPLK(bool NENBNADJDDI, bool NGBKLCJFOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D33030", Offset = "0x5D32030", VA = "0x185D33030")]
	protected void OMBLACNMDNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D32460", Offset = "0x5D31460", VA = "0x185D32460")]
	[IteratorStateMachine(typeof(LCJPLOEDEEI))]
	public IEnumerable<Renderer> JAPPJAABBPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D31F60", Offset = "0x5D30F60", VA = "0x185D31F60")]
	[IteratorStateMachine(typeof(JGKGNIFFJGJ))]
	public IEnumerable<Renderer> DPPJCPMNJLP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class GBINPNKIOOG : EANBBOJBOJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly ALGGMLKKMEA MJGGEADIGOO;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D33DF0", Offset = "0x5D32DF0", VA = "0x185D33DF0")]
	public GBINPNKIOOG(ELLLBMBMEID JMLKLPJONJN, ALGGMLKKMEA FILAKGLBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D332E0", Offset = "0x5D322E0", VA = "0x185D332E0", Slot = "13")]
	public override int MLLFDCEFGKP(EMIGCLLBDMK ODPKNMDNFOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D33C00", Offset = "0x5D32C00", VA = "0x185D33C00", Slot = "14")]
	public override int PFEFMIHFLEH(EMIGCLLBDMK ODPKNMDNFOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D334D0", Offset = "0x5D324D0", VA = "0x185D334D0", Slot = "15")]
	public override void MPJAGFEFCFK(EMIGCLLBDMK ODPKNMDNFOK, IMOFINHDIEB PHIPMIDBJBP, int MEPFPFOOANO = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OOEPEGONKCC : global::GAMKFLDBKPP<OOEPEGONKCC>, BCAIPGNNKGO, IEquatable<OOEPEGONKCC>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[CreateProperty]
	public int EBAKNIMBLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x72FE20", Offset = "0x72EE20", VA = "0x18072FE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x72FD90", Offset = "0x72ED90", VA = "0x18072FD90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int DKBOPEOPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8441E0", Offset = "0x8431E0", VA = "0x1808441E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xDED3C0", Offset = "0xDEC3C0", VA = "0x180DED3C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool DOFAOAHKOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5D38BD0", Offset = "0x5D37BD0", VA = "0x185D38BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E80", Offset = "0x3CB5E80", VA = "0x183CB6E80", Slot = "8")]
	public bool Equals(OOEPEGONKCC KICLNADFIEK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xC516A0", Offset = "0xC506A0", VA = "0x180C516A0")]
	public static bool FHCNBCDBOFI(OOEPEGONKCC NCNGLFNLPAG, OOEPEGONKCC OPGAGDBKIDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x47E6040", Offset = "0x47E5040", VA = "0x1847E6040")]
	public static bool LIEIJOJMABA(OOEPEGONKCC NCNGLFNLPAG, OOEPEGONKCC OPGAGDBKIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5D38B40", Offset = "0x5D37B40", VA = "0x185D38B40", Slot = "0")]
	public override bool Equals(object GKCPJCKCENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72FE20", Offset = "0x72EE20", VA = "0x18072FE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5D38C10", Offset = "0x5D37C10", VA = "0x185D38C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum HDACGDAINOK
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
public interface GNDPCPPCPDC
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BPHMPHDMJMJ DNKMJKOCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	HDACGDAINOK BMEIKELBKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JANJPDEKEAG : global::GAMKFLDBKPP<JANJPDEKEAG>, BCAIPGNNKGO, IEquatable<JANJPDEKEAG>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	[CreateProperty]
	public int EBAKNIMBLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x72FE20", Offset = "0x72EE20", VA = "0x18072FE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x72FD90", Offset = "0x72ED90", VA = "0x18072FD90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int DKBOPEOPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8441E0", Offset = "0x8431E0", VA = "0x1808441E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xDED3C0", Offset = "0xDEC3C0", VA = "0x180DED3C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DOFAOAHKOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5D34050", Offset = "0x5D33050", VA = "0x185D34050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E80", Offset = "0x3CB5E80", VA = "0x183CB6E80", Slot = "8")]
	public bool Equals(JANJPDEKEAG KICLNADFIEK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xC516A0", Offset = "0xC506A0", VA = "0x180C516A0")]
	public static bool FHCNBCDBOFI(JANJPDEKEAG NCNGLFNLPAG, JANJPDEKEAG OPGAGDBKIDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x47E6040", Offset = "0x47E5040", VA = "0x1847E6040")]
	public static bool LIEIJOJMABA(JANJPDEKEAG NCNGLFNLPAG, JANJPDEKEAG OPGAGDBKIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5D33FC0", Offset = "0x5D32FC0", VA = "0x185D33FC0", Slot = "0")]
	public override bool Equals(object GKCPJCKCENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x72FE20", Offset = "0x72EE20", VA = "0x18072FE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D34090", Offset = "0x5D33090", VA = "0x185D34090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DJKKCHIODKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	BPHMPHDMJMJ DNKMJKOCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float PNDEOLGEBGO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 FLGHEOOPMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	MHHFNFHDGIG HMCCLKHELMB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	OIDLICMIMPF LDNJDFJOCIO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JJOCBLHACBI : DJKKCHIODKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NJODPNAHKFJ AAANDBNGIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LINOOCPCKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ALGGMLKKMEA : DJKKCHIODKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool PNECNHKMFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MNOAIHFNAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float GOKGBGOHDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int PHKECKNHOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool HLALCMDLOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int LALPGCEIFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<FCNOKCLINJC> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MFNNHGECPHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOEGCIBDLJK(OOEPEGONKCC JMLKLPJONJN, BLKLDEDCCPH CNJHNDCFNII);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOEGCIBDLJK(JANJPDEKEAG NIEICLFNAGN, BLKLDEDCCPH CNJHNDCFNII);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJKEANHNGNK(JANJPDEKEAG NIEICLFNAGN);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EBIDFPEPHBG(JANJPDEKEAG NIEICLFNAGN);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MJONOJEECHF();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GOJLPEPDPHE();

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GBBDBGOJKKG(BLKLDEDCCPH IGEIBCJNCHF);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FGLFMPIAEOP(OOEPEGONKCC JMLKLPJONJN);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FGLFMPIAEOP(JANJPDEKEAG NIEICLFNAGN);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AGMCMMOPHNH(OOEPEGONKCC JMLKLPJONJN, OHNLEEOCOPK IGEIBCJNCHF);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AGMCMMOPHNH(JANJPDEKEAG NIEICLFNAGN, OHNLEEOCOPK IGEIBCJNCHF);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JBLBHLPPMJH(JANJPDEKEAG NIEICLFNAGN);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EOIKIJFHIII(JANJPDEKEAG NIEICLFNAGN);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KNFNFPKFJPO();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BJPMLHILICM();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OCKGMPDLFAB(OHNLEEOCOPK IGEIBCJNCHF);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FPEDBANOGFA(OOEPEGONKCC JMLKLPJONJN, Vector3 IEPBKJNEFOA, Vector3 DAAJEJJIDHA, Vector3 BJNKBFJAKAF, float DJNDFJAHCAN, float IKANDDKHKDL, IReadOnlyList<Camera> DBJMPIPMMOD, NHMGKKKMIFG KFPHPHGOLJG);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FPEDBANOGFA(ICPDNPHKNME EPABCCHJNFF, Vector3 IEPBKJNEFOA, Vector3 DAAJEJJIDHA, Vector3 BJNKBFJAKAF, float DJNDFJAHCAN, float IKANDDKHKDL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EKOODLEGPDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OOEPEGONKCC MACGFIHPKEB(GNDPCPPCPDC FILAKGLBGGA);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBDMEOCBIFF(OOEPEGONKCC JMLKLPJONJN);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGMCMLDKJHL(OOEPEGONKCC JMLKLPJONJN);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JANJPDEKEAG FPDGDNAAGIO(OOEPEGONKCC JMLKLPJONJN, JJOCBLHACBI FILAKGLBGGA);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JANJPDEKEAG KGIHIDDFNIK(OOEPEGONKCC JMLKLPJONJN, ALGGMLKKMEA FILAKGLBGGA);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LEEKMAOPFEG(JANJPDEKEAG NIEICLFNAGN);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FOIAMELBCBN(JANJPDEKEAG NIEICLFNAGN);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ICPDNPHKNME NCFIHFEDGAL(BCDPKAMINDA FILAKGLBGGA);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FLNMABDEFCD(ICPDNPHKNME EPABCCHJNFF);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OFNEOAIOCLO(ICPDNPHKNME EPABCCHJNFF);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MOEGNMBENPD IGLCIDCGNFA(BPHMPHDMJMJ OEOEPJKOKPE, IEnumerable<JANJPDEKEAG> KHEGBNANOHP, int EJBBANMNNID);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> KJDDJNIGKFC(OOEPEGONKCC JMLKLPJONJN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ICPDNPHKNME : global::GAMKFLDBKPP<ICPDNPHKNME>, BCAIPGNNKGO, IEquatable<ICPDNPHKNME>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int EBAKNIMBLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x72FE20", Offset = "0x72EE20", VA = "0x18072FE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x72FD90", Offset = "0x72ED90", VA = "0x18072FD90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int DKBOPEOPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8441E0", Offset = "0x8431E0", VA = "0x1808441E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xDED3C0", Offset = "0xDEC3C0", VA = "0x180DED3C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DOFAOAHKOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5D33F80", Offset = "0x5D32F80", VA = "0x185D33F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E80", Offset = "0x3CB5E80", VA = "0x183CB6E80", Slot = "8")]
	public bool Equals(ICPDNPHKNME KICLNADFIEK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xC516A0", Offset = "0xC506A0", VA = "0x180C516A0")]
	public static bool FHCNBCDBOFI(ICPDNPHKNME NCNGLFNLPAG, ICPDNPHKNME OPGAGDBKIDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x47E6040", Offset = "0x47E5040", VA = "0x1847E6040")]
	public static bool LIEIJOJMABA(ICPDNPHKNME NCNGLFNLPAG, ICPDNPHKNME OPGAGDBKIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D33EF0", Offset = "0x5D32EF0", VA = "0x185D33EF0", Slot = "0")]
	public override bool Equals(object GKCPJCKCENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x72FE20", Offset = "0x72EE20", VA = "0x18072FE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BCDPKAMINDA
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int HHFHLAHBMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform CIMEBPJPGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool HJGJKFCJIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OOEPEGONKCC GetBone(int FKACDCPHPKI);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int FKACDCPHPKI);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class JNINGDENEOI : EANBBOJBOJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly JJOCBLHACBI BJEGJENJPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int[] EAGFPEHHPOA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override IABEBNPMKFK GAIFLNPEBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D36430", Offset = "0x5D35430", VA = "0x185D36430", Slot = "12")]
		get
		{
			return default(IABEBNPMKFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 BJJDJAPPAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5D35760", Offset = "0x5D34760", VA = "0x185D35760")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5D33DF0", Offset = "0x5D32DF0", VA = "0x185D33DF0")]
	public JNINGDENEOI(ELLLBMBMEID JMLKLPJONJN, JJOCBLHACBI FILAKGLBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5D367E0", Offset = "0x5D357E0", VA = "0x185D367E0", Slot = "11")]
	public override bool OLIJEDGGPAI(BPHMPHDMJMJ JMLKLPJONJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5D35AA0", Offset = "0x5D34AA0", VA = "0x185D35AA0", Slot = "13")]
	public override int MLLFDCEFGKP(EMIGCLLBDMK ODPKNMDNFOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D36C50", Offset = "0x5D35C50", VA = "0x185D36C50", Slot = "14")]
	public override int PFEFMIHFLEH(EMIGCLLBDMK ODPKNMDNFOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5D36D00", Offset = "0x5D35D00", VA = "0x185D36D00")]
	private int PKEGMADABOE(EMIGCLLBDMK ODPKNMDNFOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D35B50", Offset = "0x5D34B50", VA = "0x185D35B50", Slot = "15")]
	public override void MPJAGFEFCFK(EMIGCLLBDMK ODPKNMDNFOK, IMOFINHDIEB PHIPMIDBJBP, int MEPFPFOOANO = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BIMPFAPBJCI
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFGEEIBGPKN(OHNLEEOCOPK IGEIBCJNCHF, Renderer DFMHBBMMLOP, int ACLMDBEAKCF);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNKAMKKBOPK(Renderer DFMHBBMMLOP, NHMGKKKMIFG KFPHPHGOLJG, Vector3 IEPBKJNEFOA, Vector3 DAAJEJJIDHA, Vector3 BJNKBFJAKAF, float DJNDFJAHCAN, float IKANDDKHKDL, float MBLGPHOAGJD = -1f, [Optional] Color? OEGNINEOMFI, [Optional] IReadOnlyList<Camera> JNGNELCOACG);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJMMGBABCOO(Renderer DFMHBBMMLOP, int ACLMDBEAKCF);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int POGNNPJLKGG();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFCBAMHAJLK(int KAOLDHMOMKM, BLKLDEDCCPH IGEIBCJNCHF, Renderer DFMHBBMMLOP, int ACLMDBEAKCF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BFJICIAJLFK : MFNNHGECPHF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class GFOGPJEJPOJ : global::MNGCFKPHCLM<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5D33E40", Offset = "0x5D32E40", VA = "0x185D33E40")]
		public GFOGPJEJPOJ(string IADPDEAGFAB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly BIMPFAPBJCI LCFMMMHILAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly IIMFHIEKOPL BJAPLHIMMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MeshRenderer KMIFPMCBHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private GFOGPJEJPOJ FHALNGOOBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool FABJGKDJAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MeshRenderer PDBIMNHGAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private GFOGPJEJPOJ NJJDEBEKCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool ADFBOCHAGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MeshRenderer AANIDLMOILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private GFOGPJEJPOJ EDADFDAGNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x67E6E0", Offset = "0x67D6E0", VA = "0x18067E6E0")]
	public BFJICIAJLFK(BIMPFAPBJCI BONFJIFIPKN, IIMFHIEKOPL BJAPLHIMMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EC30", Offset = "0x5D2DC30", VA = "0x185D2EC30", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5D30890", Offset = "0x5D2F890", VA = "0x185D30890")]
	private void PBMLLPBEBFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D300E0", Offset = "0x5D2F0E0", VA = "0x185D300E0", Slot = "4")]
	public void HOEGCIBDLJK(OOEPEGONKCC JMLKLPJONJN, BLKLDEDCCPH CNJHNDCFNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D302E0", Offset = "0x5D2F2E0", VA = "0x185D302E0", Slot = "5")]
	public void HOEGCIBDLJK(JANJPDEKEAG NIEICLFNAGN, BLKLDEDCCPH CNJHNDCFNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D305A0", Offset = "0x5D2F5A0", VA = "0x185D305A0", Slot = "6")]
	public void KJKEANHNGNK(JANJPDEKEAG NIEICLFNAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EE00", Offset = "0x5D2DE00", VA = "0x185D2EE00", Slot = "7")]
	public void EBIDFPEPHBG(JANJPDEKEAG NIEICLFNAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D30710", Offset = "0x5D2F710", VA = "0x185D30710", Slot = "8")]
	public void MJONOJEECHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x10F94B0", Offset = "0x10F84B0", VA = "0x1810F94B0", Slot = "9")]
	public void GOJLPEPDPHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FC50", Offset = "0x5D2EC50", VA = "0x185D2FC50", Slot = "10")]
	public void GBBDBGOJKKG(BLKLDEDCCPH CNJHNDCFNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F300", Offset = "0x5D2E300", VA = "0x185D2F300", Slot = "11")]
	public void FGLFMPIAEOP(OOEPEGONKCC JMLKLPJONJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EFB0", Offset = "0x5D2DFB0", VA = "0x185D2EFB0", Slot = "12")]
	public void FGLFMPIAEOP(JANJPDEKEAG NIEICLFNAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EA70", Offset = "0x5D2DA70", VA = "0x185D2EA70", Slot = "13")]
	public void AGMCMMOPHNH(OOEPEGONKCC JMLKLPJONJN, OHNLEEOCOPK IGEIBCJNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E880", Offset = "0x5D2D880", VA = "0x185D2E880", Slot = "14")]
	public void AGMCMMOPHNH(JANJPDEKEAG NIEICLFNAGN, OHNLEEOCOPK IGEIBCJNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5D306D0", Offset = "0x5D2F6D0", VA = "0x185D306D0", Slot = "17")]
	public void KNFNFPKFJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D30500", Offset = "0x5D2F500", VA = "0x185D30500", Slot = "15")]
	public void JBLBHLPPMJH(JANJPDEKEAG NIEICLFNAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EF20", Offset = "0x5D2DF20", VA = "0x185D2EF20", Slot = "16")]
	public void EOIKIJFHIII(JANJPDEKEAG NIEICLFNAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x14320B0", Offset = "0x14310B0", VA = "0x1814320B0", Slot = "18")]
	public void BJPMLHILICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D30750", Offset = "0x5D2F750", VA = "0x185D30750", Slot = "19")]
	public void OCKGMPDLFAB(OHNLEEOCOPK IGEIBCJNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FDC0", Offset = "0x5D2EDC0", VA = "0x185D2FDC0")]
	private void HBKANLCICAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E6C0", Offset = "0x5D2D6C0", VA = "0x185D2E6C0")]
	public void AGMCMMOPHNH(JANJPDEKEAG NIEICLFNAGN, OHNLEEOCOPK IGEIBCJNCHF, bool MNIABILJAHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D30010", Offset = "0x5D2F010", VA = "0x185D30010")]
	private void HFGEEIBGPKN(OHNLEEOCOPK IGEIBCJNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F4B0", Offset = "0x5D2E4B0", VA = "0x185D2F4B0", Slot = "20")]
	public void FPEDBANOGFA(OOEPEGONKCC JMLKLPJONJN, Vector3 IEPBKJNEFOA, Vector3 DAAJEJJIDHA, Vector3 BJNKBFJAKAF, float DJNDFJAHCAN, float IKANDDKHKDL, IReadOnlyList<Camera> DBJMPIPMMOD, NHMGKKKMIFG KFPHPHGOLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F830", Offset = "0x5D2E830", VA = "0x185D2F830", Slot = "21")]
	public void FPEDBANOGFA(ICPDNPHKNME EPABCCHJNFF, Vector3 IEPBKJNEFOA, Vector3 DAAJEJJIDHA, Vector3 BJNKBFJAKAF, float DJNDFJAHCAN, float IKANDDKHKDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class EANBBOJBOJN : CPMCFLLKKGE, DBEHKDPLJGC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly ELLLBMBMEID GHOIKAHCODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	protected Bounds LEOKKBIDBJG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds JKJNHAOHNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1140320", Offset = "0x113F320", VA = "0x181140320", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual IABEBNPMKFK GAIFLNPEBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5D30BB0", Offset = "0x5D2FBB0", VA = "0x185D30BB0", Slot = "12")]
		get
		{
			return default(IABEBNPMKFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x67EF40", Offset = "0x67DF40", VA = "0x18067EF40")]
	protected EANBBOJBOJN(ELLLBMBMEID JMLKLPJONJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D30AE0", Offset = "0x5D2FAE0", VA = "0x185D30AE0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "11")]
	public virtual bool OLIJEDGGPAI(BPHMPHDMJMJ JMLKLPJONJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int MLLFDCEFGKP(EMIGCLLBDMK ODPKNMDNFOK);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int PFEFMIHFLEH(EMIGCLLBDMK ODPKNMDNFOK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void MPJAGFEFCFK(EMIGCLLBDMK ODPKNMDNFOK, IMOFINHDIEB PHIPMIDBJBP, int MEPFPFOOANO = -1);
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
		[Cpp2IlInjected.Address(RVA = "0x5D3A350", Offset = "0x5D39350", VA = "0x185D3A350")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NJODPNAHKFJ
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
public static class JBJCIHIEEHE
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MGLBPLPBFDE : IEnumerable<PIDKGDHLOBO>, IEnumerable, IEnumerator<PIDKGDHLOBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private PIDKGDHLOBO <>2__current;

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
		private PIDKGDHLOBO System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
		[DebuggerHidden]
		public MGLBPLPBFDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D385E0", Offset = "0x5D375E0", VA = "0x185D385E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D38750", Offset = "0x5D37750", VA = "0x185D38750", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D386C0", Offset = "0x5D376C0", VA = "0x185D386C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PIDKGDHLOBO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D386C0", Offset = "0x5D376C0", VA = "0x185D386C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int BJMPPGJCHKM = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static PIDKGDHLOBO[][] PEJNFIJHFID;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static MKBOJKOABPH MHEMKJLNNHI;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static ShapeRendererConfig FLAKIFCILAN;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader MFBFPNMKMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D34570", Offset = "0x5D33570", VA = "0x185D34570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer HEJGCCOKPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D34F30", Offset = "0x5D33F30", VA = "0x185D34F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D34120", Offset = "0x5D33120", VA = "0x185D34120")]
	public static Mesh AJPCEFEEBEC(NJODPNAHKFJ PODGMMOJNDN, int ODPKNMDNFOK = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D34BA0", Offset = "0x5D33BA0", VA = "0x185D34BA0")]
	public static int HIFDEOAKLHP(NJODPNAHKFJ PODGMMOJNDN, int ODPKNMDNFOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D34400", Offset = "0x5D33400", VA = "0x185D34400")]
	public static MKBOJKOABPH BGGPGIINFEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D34990", Offset = "0x5D33990", VA = "0x185D34990")]
	[IteratorStateMachine(typeof(MGLBPLPBFDE))]
	private static IEnumerable<PIDKGDHLOBO> FGJBBHJKGFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5D34BB0", Offset = "0x5D33BB0", VA = "0x185D34BB0")]
	public static PIDKGDHLOBO HJMJEPMLIMM(NJODPNAHKFJ PODGMMOJNDN, int ODPKNMDNFOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5D34F10", Offset = "0x5D33F10", VA = "0x185D34F10")]
	public static bool MKECLEBIJGB(this NJODPNAHKFJ PODGMMOJNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5D349F0", Offset = "0x5D339F0", VA = "0x185D349F0")]
	public static void GLHAJLEAPCG(NJODPNAHKFJ PODGMMOJNDN, float3 ICFDANDLIPL, out NHJOILBEGGG GNLFJCKLHGN, out float3 PFFBJDCEBGF, out float KBCHIIHMHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D345E0", Offset = "0x5D335E0", VA = "0x185D345E0")]
	public static void FFAECJPKPFL(Vector3 ICFDANDLIPL, NJODPNAHKFJ PODGMMOJNDN, out Vector3 PFFBJDCEBGF, out float KBCHIIHMHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D34560", Offset = "0x5D33560", VA = "0x185D34560")]
	[CIBCLNKDGPH(MOOMEKEKHGD.ExitingPlayMode, 0)]
	private static void BNHJBEFPGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D341E0", Offset = "0x5D331E0", VA = "0x185D341E0")]
	[CIBCLNKDGPH(MOOMEKEKHGD.ExitingPlayMode, 0)]
	private static void AOPCJBBHJNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BBOHLLFFLIC
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool NHAAJMEJANB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material AENFBEGINIJ();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material ONGFNDHOFJH();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material FCFFAPNBJEC();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int AEMMBMCOJHM(MHHFNFHDGIG PBDKOPGIDIH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KKEKJGJEHPH(OIDLICMIMPF BOFJGONMIEI);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EHMJNHBKJBH(GameObject GKCPJCKCENH);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MHDMLGDEEHH(GameObject GKCPJCKCENH, bool JFILCHGNHPO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface IIMFHIEKOPL
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	ELLLBMBMEID PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	EANBBOJBOJN PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	POGIDCECLAO PGMGPNCDKFC
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
	[LMNMHFHDONH(IPKPBIMLPOB.ShapeRendering)]
	public class ShapeRendererManager : EKOODLEGPDN, IDisposable, IIMFHIEKOPL
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly global::JAGKIEIPGFG<OOEPEGONKCC, ELLLBMBMEID> NNNAHLEFPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly global::JAGKIEIPGFG<JANJPDEKEAG, EANBBOJBOJN> KHEGBNANOHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly global::JAGKIEIPGFG<ICPDNPHKNME, POGIDCECLAO> OOMPFGCBKMC;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static BBOHLLFFLIC BANJBACOHFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5D3B1C0", Offset = "0x5D3A1C0", VA = "0x185D3B1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5D3A380", Offset = "0x5D39380", VA = "0x185D3A380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public ELLLBMBMEID PGMGPNCDKFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x5D3A3F0", Offset = "0x5D393F0", VA = "0x185D3A3F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public EANBBOJBOJN PGMGPNCDKFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x5D3A4B0", Offset = "0x5D394B0", VA = "0x185D3A4B0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public POGIDCECLAO PGMGPNCDKFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5D3A450", Offset = "0x5D39450", VA = "0x185D3A450", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5D3B270", Offset = "0x5D3A270", VA = "0x185D3B270")]
		public ShapeRendererManager(BBOHLLFFLIC BONFJIFIPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A510", Offset = "0x5D39510", VA = "0x185D3A510", Slot = "16")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5D3AEB0", Offset = "0x5D39EB0", VA = "0x185D3AEB0", Slot = "4")]
		public OOEPEGONKCC MACGFIHPKEB(GNDPCPPCPDC FILAKGLBGGA)
		{
			return default(OOEPEGONKCC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A5A0", Offset = "0x5D395A0", VA = "0x185D3A5A0", Slot = "5")]
		public void FBDMEOCBIFF(OOEPEGONKCC JMLKLPJONJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A600", Offset = "0x5D39600", VA = "0x185D3A600", Slot = "6")]
		public void FGMCMLDKJHL(OOEPEGONKCC JMLKLPJONJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A770", Offset = "0x5D39770", VA = "0x185D3A770", Slot = "7")]
		public JANJPDEKEAG FPDGDNAAGIO(OOEPEGONKCC JMLKLPJONJN, JJOCBLHACBI FILAKGLBGGA)
		{
			return default(JANJPDEKEAG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D3AC80", Offset = "0x5D39C80", VA = "0x185D3AC80", Slot = "8")]
		public JANJPDEKEAG KGIHIDDFNIK(OOEPEGONKCC JMLKLPJONJN, ALGGMLKKMEA FILAKGLBGGA)
		{
			return default(JANJPDEKEAG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A6E0", Offset = "0x5D396E0", VA = "0x185D3A6E0", Slot = "10")]
		public void FOIAMELBCBN(JANJPDEKEAG NIEICLFNAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D3AE50", Offset = "0x5D39E50", VA = "0x185D3AE50", Slot = "9")]
		public void LEEKMAOPFEG(JANJPDEKEAG NIEICLFNAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D3AD90", Offset = "0x5D39D90", VA = "0x185D3AD90", Slot = "15")]
		public IEnumerable<Renderer> KJDDJNIGKFC(OOEPEGONKCC JMLKLPJONJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5D3AFB0", Offset = "0x5D39FB0", VA = "0x185D3AFB0", Slot = "11")]
		public ICPDNPHKNME NCFIHFEDGAL(BCDPKAMINDA FILAKGLBGGA)
		{
			return default(ICPDNPHKNME);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D3B150", Offset = "0x5D3A150", VA = "0x185D3B150", Slot = "13")]
		public void OFNEOAIOCLO(ICPDNPHKNME EPABCCHJNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A680", Offset = "0x5D39680", VA = "0x185D3A680", Slot = "12")]
		public void FLNMABDEFCD(ICPDNPHKNME EPABCCHJNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A880", Offset = "0x5D39880", VA = "0x185D3A880", Slot = "14")]
		public MOEGNMBENPD IGLCIDCGNFA(BPHMPHDMJMJ DDGBAKGLHDK, IEnumerable<JANJPDEKEAG> KHEGBNANOHP, int EJBBANMNNID)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class POGIDCECLAO : LIELAELGJMI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class OBDMBAJPJEI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public POGIDCECLAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
		[DebuggerHidden]
		public OBDMBAJPJEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5D38A70", Offset = "0x5D37A70", VA = "0x185D38A70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5D38790", Offset = "0x5D37790", VA = "0x185D38790", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5D38AF0", Offset = "0x5D37AF0", VA = "0x185D38AF0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5D38A30", Offset = "0x5D37A30", VA = "0x185D38A30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5D38990", Offset = "0x5D37990", VA = "0x185D38990", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5D38990", Offset = "0x5D37990", VA = "0x185D38990", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly BCDPKAMINDA HNCOLAIPOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly IIMFHIEKOPL BJAPLHIMMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private LIGGAKDGDHA HHIHEKJPDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private List<EFELGCKLPJM> MBBMOCMIFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private List<EFELGCKLPJM> MDHFJEAKOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject NKEGONKMLLG;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D39E40", Offset = "0x5D38E40", VA = "0x185D39E40")]
	public static POGIDCECLAO LNELPPLOKNM(BCDPKAMINDA FILAKGLBGGA, IIMFHIEKOPL BJAPLHIMMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D3A250", Offset = "0x5D39250", VA = "0x185D3A250")]
	private POGIDCECLAO(BCDPKAMINDA FILAKGLBGGA, IIMFHIEKOPL BJAPLHIMMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5D39960", Offset = "0x5D38960", VA = "0x185D39960")]
	public void KKDFCIPLDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5D38D40", Offset = "0x5D37D40", VA = "0x185D38D40")]
	[IteratorStateMachine(typeof(OBDMBAJPJEI))]
	public IEnumerable<Renderer> JAPPJAABBPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5D38DB0", Offset = "0x5D37DB0", VA = "0x185D38DB0", Slot = "4")]
	public void JBHLEMLNGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5D38CA0", Offset = "0x5D37CA0", VA = "0x185D38CA0")]
	private void AGMEBJOMAHO(Vector3 JKNLCGKMCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5D39FB0", Offset = "0x5D38FB0", VA = "0x185D39FB0")]
	public void PGLCEDHDGGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EFELGCKLPJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct MBEKFEJEMHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public IMOFINHDIEB IAFHANCJHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public BPHMPHDMJMJ DDLNLCHDCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int JONMKFAGMBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class JGMOKKMKFOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public EFELGCKLPJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public EMIGCLLBDMK lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<MBEKFEJEMHI> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public MOEGNMBENPD combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public JGMOKKMKFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5D35580", Offset = "0x5D34580", VA = "0x185D35580")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5D355E0", Offset = "0x5D345E0", VA = "0x185D355E0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5D35610", Offset = "0x5D34610", VA = "0x185D35610")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int[] BDCOECDBHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private DPCPBJAKAFE CIKJCPADIGK;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static Matrix4x4 GBIEGBBLLPP;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh PNOIAMAKCNC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x69E130", Offset = "0x69D130", VA = "0x18069E130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int GDHEFHDMGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x67FBD0", Offset = "0x67EBD0", VA = "0x18067FBD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x722410", Offset = "0x721410", VA = "0x180722410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5D30C40", Offset = "0x5D2FC40", VA = "0x185D30C40")]
	public void DKKPCNHGBAL(List<BPHMPHDMJMJ> IOPMBMGHLDG, Matrix4x4[] EJFCBJIAGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5D30F00", Offset = "0x5D2FF00", VA = "0x185D30F00")]
	public static List<EFELGCKLPJM> HJNGNBALKKN(List<ELLLBMBMEID> GBOKJJGHEBP, EMIGCLLBDMK ODPKNMDNFOK, Bounds HJIDIDOFHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5D31530", Offset = "0x5D30530", VA = "0x185D31530")]
	private JobHandle OJGDEMENIMD(MOEGNMBENPD KPHDFMBDPEB, int NLBCPDCCONI, int DOANMKOGMNO, EMIGCLLBDMK ODPKNMDNFOK, List<MBEKFEJEMHI> LPHKIBAKJLD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5D31910", Offset = "0x5D30910", VA = "0x185D31910")]
	private void PHIDEIOLOBJ(List<MBEKFEJEMHI> LPHKIBAKJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5D31B50", Offset = "0x5D30B50", VA = "0x185D31B50")]
	private EFELGCKLPJM(List<MBEKFEJEMHI> LPHKIBAKJLD, int NLBCPDCCONI, int DOANMKOGMNO, EMIGCLLBDMK ODPKNMDNFOK, Bounds HJIDIDOFHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D30E70", Offset = "0x5D2FE70", VA = "0x185D30E70", Slot = "4")]
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
		private MaterialPropertyBlock FIPMJBEBBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private EFELGCKLPJM BACPNBLOLFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<BPHMPHDMJMJ> FGBLCHBPPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private RenderTexture ABLOMELEJGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private ComputeBuffer PIJDOLIDDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private ComputeShader PGNNCBCNCKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Matrix4x4[] AJEGBIMAMCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private int HEFCOINNDJC;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer MKOOBEAMBML
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x69E140", Offset = "0x69D140", VA = "0x18069E140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int HHFHLAHBMCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5D3C4A0", Offset = "0x5D3B4A0", VA = "0x185D3C4A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5D3B810", Offset = "0x5D3A810", VA = "0x185D3B810")]
		public static List<SkinnedShapeRenderer> Create(GameObject JMLKLPJONJN, List<EFELGCKLPJM> GCELFLGKONE, List<BPHMPHDMJMJ> FGBLCHBPPFG, Material FNBKMDAGGIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5D3BE50", Offset = "0x5D3AE50", VA = "0x185D3BE50")]
		public void Init(EFELGCKLPJM BACPNBLOLFL, List<BPHMPHDMJMJ> FGBLCHBPPFG, Material FNBKMDAGGIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5D3C3F0", Offset = "0x5D3B3F0", VA = "0x185D3C3F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5D3C340", Offset = "0x5D3B340", VA = "0x185D3C340")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5D3C300", Offset = "0x5D3B300", VA = "0x185D3C300")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5D3BC20", Offset = "0x5D3AC20", VA = "0x185D3BC20")]
		private void HJKPLHPNCLI(ScriptableRenderContext KPJEGNGKPOH, Camera[] NPEPEEIDKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5D3BA60", Offset = "0x5D3AA60", VA = "0x185D3BA60")]
		private void DKKPCNHGBAL(CommandBuffer FDGPBDCCHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	internal class _RRAssemblyIndex : GDNMPNNPIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5D3C5D0", Offset = "0x5D3B5D0", VA = "0x185D3C5D0", Slot = "4")]
		public sealed override void JJOFCNGHIKE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5D37300", Offset = "0x5D36300", VA = "0x185D37300")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5D36FB0", Offset = "0x5D35FB0", VA = "0x185D36FB0")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
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
