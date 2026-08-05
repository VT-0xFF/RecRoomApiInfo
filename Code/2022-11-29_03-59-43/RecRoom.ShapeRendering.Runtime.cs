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
public enum NKNPGLCGOCA
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
public static class MHBKFOFGEJH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1FB0", Offset = "0x5CD0BB0", VA = "0x185CD1FB0")]
	public static bool ACMIEBANKBC(this NKNPGLCGOCA PFMKAIOKFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1FD0", Offset = "0x5CD0BD0", VA = "0x185CD1FD0")]
	public static bool BKBDAAIHNCP(this NKNPGLCGOCA PFMKAIOKFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1FE0", Offset = "0x5CD0BE0", VA = "0x185CD1FE0")]
	public static bool NNEBFFBKJOE(this NKNPGLCGOCA PFMKAIOKFDE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JPGEOOLAGJI
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
public enum PGLABDHKPPB
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
public enum BOOPPHGBPBC
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
public enum PNNCPIEILFP
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
public class NKGKGDLNGGI : KMJKLEFLOJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte LJHPLMEHPNC = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte APBNHDAFNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] MOCAHJOFKME;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HAMADIJDDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x677010", Offset = "0x675C10", VA = "0x180677010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CC0", Offset = "0x6BF8C0", VA = "0x1806C0CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ONLCOFMCGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x697D90", Offset = "0x696990", VA = "0x180697D90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x849EB0", Offset = "0x848AB0", VA = "0x180849EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float GLEBHCDMLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x10CBB80", Offset = "0x10CA780", VA = "0x1810CBB80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x141B0A0", Offset = "0x1419CA0", VA = "0x18141B0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float DEFEOLMKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x10CBB70", Offset = "0x10CA770", VA = "0x1810CBB70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1569920", Offset = "0x1568520", VA = "0x181569920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> JKCOHLMIJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2700", Offset = "0x5CD1300", VA = "0x185CD2700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> DPJFILILJML
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x58AAEB0", Offset = "0x58A9AB0", VA = "0x1858AAEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject AJIGMJGLFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E6E0", VA = "0x18070FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte DFPFCOOGKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CD26B0", Offset = "0x5CD12B0", VA = "0x185CD26B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2870", Offset = "0x5CD1470", VA = "0x185CD2870")]
	public NKGKGDLNGGI(List<FCMNFGJDDMI> DLGBFBIHNEC, List<FCMNFGJDDMI> IMCKHCPPPOI, List<HIHDGKIDBHE> NBLBMCPBOMH, Material KONHLMGGONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2760", Offset = "0x5CD1360", VA = "0x185CD2760")]
	private int OJDKGBIAAHM(List<FCMNFGJDDMI> PHCAOOJFBCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2480", Offset = "0x5CD1080", VA = "0x185CD2480")]
	private void JGOINFOEBDD(int IBFFNFCPGAP, bool FAGHFMDMOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CD25D0", Offset = "0x5CD11D0", VA = "0x185CD25D0")]
	public void KDMMCJNKPLO(Vector3 MPDELAEIHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2350", Offset = "0x5CD0F50", VA = "0x185CD2350", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2670", Offset = "0x5CD1270", VA = "0x185CD2670")]
	public void NAENOOALGGP(Transform JMGHKKNLNJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PCJANJHFFJD : FCDLGAIDMKC, DMFEHGDIJAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BALCEKMILLM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PCJANJHFFJD <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E8010", VA = "0x1808E9410")]
		[DebuggerHidden]
		public BALCEKMILLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9670", Offset = "0x5CC8270", VA = "0x185CC9670", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9140", Offset = "0x5CC7D40", VA = "0x185CC9140", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9770", Offset = "0x5CC8370", VA = "0x185CC9770")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC97C0", Offset = "0x5CC83C0", VA = "0x185CC97C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9810", Offset = "0x5CC8410", VA = "0x185CC9810")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9630", Offset = "0x5CC8230", VA = "0x185CC9630", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9590", Offset = "0x5CC8190", VA = "0x185CC9590", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9590", Offset = "0x5CC8190", VA = "0x185CC9590", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GLBNOBIGCIL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PCJANJHFFJD <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E8010", VA = "0x1808E9410")]
		[DebuggerHidden]
		public GLBNOBIGCIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5CCEFB0", Offset = "0x5CCDBB0", VA = "0x185CCEFB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5CCEBF0", Offset = "0x5CCD7F0", VA = "0x185CCEBF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF090", Offset = "0x5CCDC90", VA = "0x185CCF090")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF0E0", Offset = "0x5CCDCE0", VA = "0x185CCF0E0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5CCEF70", Offset = "0x5CCDB70", VA = "0x185CCEF70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5CCEED0", Offset = "0x5CCDAD0", VA = "0x185CCEED0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5CCEED0", Offset = "0x5CCDAD0", VA = "0x185CCEED0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly BJNHKBMJGLH IMIALNIDFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<PLGHJMIEMPO> FHBFFNJLJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> LANFFPAKECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer DBIGPCFCIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool KCNOBGCIEMA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<IMMGCKBFCDB> JGEPHCOPENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KNLEKKALDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5CD3990", Offset = "0x5CD2590", VA = "0x185CD3990", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HIHDGKIDBHE DLMOBPJCBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5CD3850", Offset = "0x5CD2450", VA = "0x185CD3850", Slot = "7")]
		get
		{
			return default(HIHDGKIDBHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> LHAFBFINMCP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67D170", VA = "0x18067E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67E590", Offset = "0x67D190", VA = "0x18067E590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD40C0", Offset = "0x5CD2CC0", VA = "0x185CD40C0")]
	public PCJANJHFFJD(BJNHKBMJGLH JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD34C0", Offset = "0x5CD20C0", VA = "0x185CD34C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD34F0", Offset = "0x5CD20F0", VA = "0x185CD34F0")]
	public void ELGBPIMHCCH(PLGHJMIEMPO HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3400", Offset = "0x5CD2000", VA = "0x185CD3400")]
	public void DOHHNJJEEIG(PLGHJMIEMPO HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3A80", Offset = "0x5CD2680", VA = "0x185CD3A80", Slot = "4")]
	public void MABHDCCBPHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CD39D0", Offset = "0x5CD25D0", VA = "0x185CD39D0")]
	public void LPIFGEKCIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3650", Offset = "0x5CD2250", VA = "0x185CD3650")]
	private void HGDPIPBIBFC(List<PLGHJMIEMPO> FHBFFNJLJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3780", Offset = "0x5CD2380", VA = "0x185CD3780")]
	private static Material HNDCBGBMMEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3600", Offset = "0x5CD2200", VA = "0x185CD3600")]
	private void HGDPIPBIBFC(PLGHJMIEMPO HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3FF0", Offset = "0x5CD2BF0", VA = "0x185CD3FF0")]
	private void NICGLNPGDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2E70", Offset = "0x5CD1A70", VA = "0x185CD2E70")]
	public void BDNEDFKMEAK(bool BDOMANFBFON, bool LPONIPHNODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2DE0", Offset = "0x5CD19E0", VA = "0x185CD2DE0")]
	protected void AELLLGKHOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3920", Offset = "0x5CD2520", VA = "0x185CD3920")]
	[IteratorStateMachine(typeof(BALCEKMILLM))]
	public IEnumerable<Renderer> JGOEBNEDBMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3390", Offset = "0x5CD1F90", VA = "0x185CD3390")]
	[IteratorStateMachine(typeof(GLBNOBIGCIL))]
	public IEnumerable<Renderer> DMOEGGGHJFK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class PJGJCLFPPGE : PLGHJMIEMPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly PIOGPBHPCID PDBBGKNPIGM;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD880", Offset = "0x5CCC480", VA = "0x185CCD880")]
	public PJGJCLFPPGE(PCJANJHFFJD MHPJOFNEKOG, PIOGPBHPCID JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4A80", Offset = "0x5CD3680", VA = "0x185CD4A80", Slot = "13")]
	public override int OJDKGBIAAHM(BBIMGAEJAFH LDPMEOOMILD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4160", Offset = "0x5CD2D60", VA = "0x185CD4160", Slot = "14")]
	public override int AOOHIGMDDNC(BBIMGAEJAFH LDPMEOOMILD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4350", Offset = "0x5CD2F50", VA = "0x185CD4350", Slot = "15")]
	public override void APMGONIGJJF(BBIMGAEJAFH LDPMEOOMILD, OHBJADHEDAF AMJMNCKBDPB, int LEABJDADMHB = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct INFMGJMFHHE : global::LHEMAHBEHEJ<INFMGJMFHHE>, MKBPDIMFNJC, IEquatable<INFMGJMFHHE>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[CreateProperty]
	public int OMNKALCAHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727A20", VA = "0x180728E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x728D90", Offset = "0x727990", VA = "0x180728D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int BDCBCEKMBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B60", Offset = "0x8B4760", VA = "0x1808B5B60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xEC96C0", Offset = "0xEC82C0", VA = "0x180EC96C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool ILPKKNHIECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF210", Offset = "0x5CCDE10", VA = "0x185CCF210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x294DD30", Offset = "0x294C930", VA = "0x18294DD30", Slot = "8")]
	public bool Equals(INFMGJMFHHE MCLIMJFDMCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xDBD370", Offset = "0xDBBF70", VA = "0x180DBD370")]
	public static bool IKJLJMIELNH(INFMGJMFHHE LEOEMBMBFBC, INFMGJMFHHE GHDGKPNPOBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x48C9040", Offset = "0x48C7C40", VA = "0x1848C9040")]
	public static bool NKIHKFGIBBG(INFMGJMFHHE LEOEMBMBFBC, INFMGJMFHHE GHDGKPNPOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF180", Offset = "0x5CCDD80", VA = "0x185CCF180", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727A20", VA = "0x180728E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF250", Offset = "0x5CCDE50", VA = "0x185CCF250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum PBLBMOLPKEG
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
public interface BJNHKBMJGLH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	HIHDGKIDBHE BBMIHJJDCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	PBLBMOLPKEG NKAFFNLLFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NAMHIJGBHBB : global::LHEMAHBEHEJ<NAMHIJGBHBB>, MKBPDIMFNJC, IEquatable<NAMHIJGBHBB>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	[CreateProperty]
	public int OMNKALCAHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727A20", VA = "0x180728E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x728D90", Offset = "0x727990", VA = "0x180728D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int BDCBCEKMBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B60", Offset = "0x8B4760", VA = "0x1808B5B60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xEC96C0", Offset = "0xEC82C0", VA = "0x180EC96C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ILPKKNHIECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2280", Offset = "0x5CD0E80", VA = "0x185CD2280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x294DD30", Offset = "0x294C930", VA = "0x18294DD30", Slot = "8")]
	public bool Equals(NAMHIJGBHBB MCLIMJFDMCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xDBD370", Offset = "0xDBBF70", VA = "0x180DBD370")]
	public static bool IKJLJMIELNH(NAMHIJGBHBB LEOEMBMBFBC, NAMHIJGBHBB GHDGKPNPOBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x48C9040", Offset = "0x48C7C40", VA = "0x1848C9040")]
	public static bool NKIHKFGIBBG(NAMHIJGBHBB LEOEMBMBFBC, NAMHIJGBHBB GHDGKPNPOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CD21F0", Offset = "0x5CD0DF0", VA = "0x185CD21F0", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727A20", VA = "0x180728E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD22C0", Offset = "0x5CD0EC0", VA = "0x185CD22C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DCPAILAPFEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	HIHDGKIDBHE BBMIHJJDCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float EBPBJEOPHFF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 LPMJEECAMGK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	NKNPGLCGOCA PLEJPEKBPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	JPGEOOLAGJI DMBOLHEOFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LCJLMHMGJBH : DCPAILAPFEJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	CBJMJDNINPP EIMBCECGFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool ELPDAAJEOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PIOGPBHPCID : DCPAILAPFEJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool GIBJCFBFFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool OMPJPOPAEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float HLJDKLDBFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int JADJDDEOHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LPAFCBFKNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int BFOGCFOOMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<CNBPCHAPPCB> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KNBJJJIONJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONKCGKLFOPF(INFMGJMFHHE MHPJOFNEKOG, BOOPPHGBPBC EKDKGJLNBIJ);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONKCGKLFOPF(NAMHIJGBHBB HBIKDKNLIBO, BOOPPHGBPBC EKDKGJLNBIJ);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EPGGOIJPCNP(NAMHIJGBHBB HBIKDKNLIBO);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GMPIEKNJLLA(NAMHIJGBHBB HBIKDKNLIBO);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBNGLJAODPE();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FDGNIDDMDLP();

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OKDBEIDNOOA(BOOPPHGBPBC BIEGICDMJCM);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NEAMIBECMMJ(INFMGJMFHHE MHPJOFNEKOG);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NEAMIBECMMJ(NAMHIJGBHBB HBIKDKNLIBO);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KCAMCBEHIKA(INFMGJMFHHE MHPJOFNEKOG, PNNCPIEILFP BIEGICDMJCM);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KCAMCBEHIKA(NAMHIJGBHBB HBIKDKNLIBO, PNNCPIEILFP BIEGICDMJCM);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MPCGMCAPIAP(NAMHIJGBHBB HBIKDKNLIBO);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HCJIIDODNPM(NAMHIJGBHBB HBIKDKNLIBO);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AFLLHJAFOPP();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void POGOAILAEGD();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AGKAJFJMHGL(PNNCPIEILFP BIEGICDMJCM);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NDFEDPCLINO(INFMGJMFHHE MHPJOFNEKOG, Vector3 JOJMCJDEDJC, Vector3 JLDCKNIDGBL, Vector3 NAKHBOOCHOB, float MPDLFFHDHAF, float FMJCNPKMKPI, IReadOnlyList<Camera> BGAKAANBCDJ, PGLABDHKPPB LAPCLBDEMJJ);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NDFEDPCLINO(JOIBLDANFMP FJPGJGBCAFL, Vector3 JOJMCJDEDJC, Vector3 JLDCKNIDGBL, Vector3 NAKHBOOCHOB, float MPDLFFHDHAF, float FMJCNPKMKPI);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MHIAMMHAEHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	INFMGJMFHHE GGKDINNNDLO(BJNHKBMJGLH JLFCOOGLPMP);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CAJDEHAAMGP(INFMGJMFHHE MHPJOFNEKOG);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GPCCBNOPHFC(INFMGJMFHHE MHPJOFNEKOG);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NAMHIJGBHBB GOPBMDJFHLG(INFMGJMFHHE MHPJOFNEKOG, LCJLMHMGJBH JLFCOOGLPMP);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NAMHIJGBHBB HGFHAOFBKHH(INFMGJMFHHE MHPJOFNEKOG, PIOGPBHPCID JLFCOOGLPMP);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AOIKGEECAKL(NAMHIJGBHBB HBIKDKNLIBO);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IGDFPCLBONG(NAMHIJGBHBB HBIKDKNLIBO);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JOIBLDANFMP BBAPHLILIIN(JNCGGIFMBJM JLFCOOGLPMP);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KKODDJMLNMH(JOIBLDANFMP FJPGJGBCAFL);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NNLHKBNKEIM(JOIBLDANFMP FJPGJGBCAFL);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NFHFGCGPPAN DLEOGENLFBN(HIHDGKIDBHE KKCKBHHGHIJ, IEnumerable<NAMHIJGBHBB> FHBFFNJLJMA, int FNLPGDFPLCP);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> PGNONKMMLKI(INFMGJMFHHE MHPJOFNEKOG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct JOIBLDANFMP : global::LHEMAHBEHEJ<JOIBLDANFMP>, MKBPDIMFNJC, IEquatable<JOIBLDANFMP>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int OMNKALCAHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727A20", VA = "0x180728E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x728D90", Offset = "0x727990", VA = "0x180728D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int BDCBCEKMBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B60", Offset = "0x8B4760", VA = "0x1808B5B60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xEC96C0", Offset = "0xEC82C0", VA = "0x180EC96C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool ILPKKNHIECH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF370", Offset = "0x5CCDF70", VA = "0x185CCF370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x294DD30", Offset = "0x294C930", VA = "0x18294DD30", Slot = "8")]
	public bool Equals(JOIBLDANFMP MCLIMJFDMCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xDBD370", Offset = "0xDBBF70", VA = "0x180DBD370")]
	public static bool IKJLJMIELNH(JOIBLDANFMP LEOEMBMBFBC, JOIBLDANFMP GHDGKPNPOBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x48C9040", Offset = "0x48C7C40", VA = "0x1848C9040")]
	public static bool NKIHKFGIBBG(JOIBLDANFMP LEOEMBMBFBC, JOIBLDANFMP GHDGKPNPOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF2E0", Offset = "0x5CCDEE0", VA = "0x185CCF2E0", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727A20", VA = "0x180728E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JNCGGIFMBJM
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int CMPHAHGIPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform BPFNHICCNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool OPOAIMMIODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	INFMGJMFHHE GetBone(int HBDOIMGEBIP);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int HBDOIMGEBIP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class ELKOICIGKEB : PLGHJMIEMPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly LCJLMHMGJBH PEDANLNGBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int[] LEBKMNLMEBP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override CNLNAAJIOJC BJOPCFJAMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5CCD420", Offset = "0x5CCC020", VA = "0x185CCD420", Slot = "12")]
		get
		{
			return default(CNLNAAJIOJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 NGMOMKFOIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5CCCE30", Offset = "0x5CCBA30", VA = "0x185CCCE30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD880", Offset = "0x5CCC480", VA = "0x185CCD880")]
	public ELKOICIGKEB(PCJANJHFFJD MHPJOFNEKOG, LCJLMHMGJBH JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC9C0", Offset = "0x5CCB5C0", VA = "0x185CCC9C0", Slot = "11")]
	public override bool FEKEOLEEEJK(HIHDGKIDBHE MHPJOFNEKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD7D0", Offset = "0x5CCC3D0", VA = "0x185CCD7D0", Slot = "13")]
	public override int OJDKGBIAAHM(BBIMGAEJAFH LDPMEOOMILD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC030", Offset = "0x5CCAC30", VA = "0x185CCC030", Slot = "14")]
	public override int AOOHIGMDDNC(BBIMGAEJAFH LDPMEOOMILD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD170", Offset = "0x5CCBD70", VA = "0x185CCD170")]
	private int LKDIPDOCODG(BBIMGAEJAFH LDPMEOOMILD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC0E0", Offset = "0x5CCACE0", VA = "0x185CCC0E0", Slot = "15")]
	public override void APMGONIGJJF(BBIMGAEJAFH LDPMEOOMILD, OHBJADHEDAF AMJMNCKBDPB, int LEABJDADMHB = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OKKFOAJCKFN
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIBDDDGGEHG(PNNCPIEILFP BIEGICDMJCM, Renderer OBNFGCJIKHN, int MPHGGBFPFBF);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FOIFBKDHBKL(Renderer OBNFGCJIKHN, PGLABDHKPPB LAPCLBDEMJJ, Vector3 JOJMCJDEDJC, Vector3 JLDCKNIDGBL, Vector3 NAKHBOOCHOB, float MPDLFFHDHAF, float FMJCNPKMKPI, float HHEEDOMEHOF = -1f, [Optional] Color? OJAMOJPMLEB, [Optional] IReadOnlyList<Camera> IEKJPODJEMO);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFCCCBNKHHL(Renderer OBNFGCJIKHN, int MPHGGBFPFBF);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NFOLCOKIDDP();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABGJMDDAGIF(int JELAPHGNPCI, BOOPPHGBPBC BIEGICDMJCM, Renderer OBNFGCJIKHN, int MPHGGBFPFBF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EGMBMOEOJJA : KNBJJJIONJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class HBCKHBEHMDK : global::GPNMKLHNKDM<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF130", Offset = "0x5CCDD30", VA = "0x185CCF130")]
		public HBCKHBEHMDK(string NLCIGFDKGEE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly OKKFOAJCKFN FMJOGHIJHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly GEKAPEKLKDE CEJIJOFJOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MeshRenderer OBMJAGAAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private HBCKHBEHMDK BEADDINJIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool FKHDGBNLCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MeshRenderer DEGJILLJIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private HBCKHBEHMDK PEBDAKODLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool AOAMKOPPPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MeshRenderer OMDMKLMBHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private HBCKHBEHMDK CADIPGOAEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6776E0", Offset = "0x6762E0", VA = "0x1806776E0")]
	public EGMBMOEOJJA(OKKFOAJCKFN MIAMGGPFAHK, GEKAPEKLKDE CEJIJOFJOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9FE0", Offset = "0x5CC8BE0", VA = "0x185CC9FE0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9D90", Offset = "0x5CC8990", VA = "0x185CC9D90")]
	private void AHINONPNKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBE30", Offset = "0x5CCAA30", VA = "0x185CCBE30", Slot = "4")]
	public void ONKCGKLFOPF(INFMGJMFHHE MHPJOFNEKOG, BOOPPHGBPBC EKDKGJLNBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBC10", Offset = "0x5CCA810", VA = "0x185CCBC10", Slot = "5")]
	public void ONKCGKLFOPF(NAMHIJGBHBB HBIKDKNLIBO, BOOPPHGBPBC EKDKGJLNBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA400", Offset = "0x5CC9000", VA = "0x185CCA400", Slot = "6")]
	public void EPGGOIJPCNP(NAMHIJGBHBB HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA530", Offset = "0x5CC9130", VA = "0x185CCA530", Slot = "7")]
	public void GMPIEKNJLLA(NAMHIJGBHBB HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA6E0", Offset = "0x5CC92E0", VA = "0x185CCA6E0", Slot = "8")]
	public void IBNGLJAODPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1722400", Offset = "0x1721000", VA = "0x181722400", Slot = "9")]
	public void FDGNIDDMDLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBAA0", Offset = "0x5CCA6A0", VA = "0x185CCBAA0", Slot = "10")]
	public void OKDBEIDNOOA(BOOPPHGBPBC EKDKGJLNBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB5A0", Offset = "0x5CCA1A0", VA = "0x185CCB5A0", Slot = "11")]
	public void NEAMIBECMMJ(INFMGJMFHHE MHPJOFNEKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB750", Offset = "0x5CCA350", VA = "0x185CCB750", Slot = "12")]
	public void NEAMIBECMMJ(NAMHIJGBHBB HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5CCABA0", Offset = "0x5CC97A0", VA = "0x185CCABA0", Slot = "13")]
	public void KCAMCBEHIKA(INFMGJMFHHE MHPJOFNEKOG, PNNCPIEILFP BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA7F0", Offset = "0x5CC93F0", VA = "0x185CCA7F0", Slot = "14")]
	public void KCAMCBEHIKA(NAMHIJGBHBB HBIKDKNLIBO, PNNCPIEILFP BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9C10", Offset = "0x5CC8810", VA = "0x185CC9C10", Slot = "17")]
	public void AFLLHJAFOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAD60", Offset = "0x5CC9960", VA = "0x185CCAD60", Slot = "15")]
	public void MPCGMCAPIAP(NAMHIJGBHBB HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA650", Offset = "0x5CC9250", VA = "0x185CCA650", Slot = "16")]
	public void HCJIIDODNPM(NAMHIJGBHBB HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x12679A0", Offset = "0x12665A0", VA = "0x1812679A0", Slot = "18")]
	public void POGOAILAEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9C50", Offset = "0x5CC8850", VA = "0x185CC9C50", Slot = "19")]
	public void AGKAJFJMHGL(PNNCPIEILFP BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA1B0", Offset = "0x5CC8DB0", VA = "0x185CCA1B0")]
	private void EIKJJBMFPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA9E0", Offset = "0x5CC95E0", VA = "0x185CCA9E0")]
	public void KCAMCBEHIKA(NAMHIJGBHBB HBIKDKNLIBO, PNNCPIEILFP BIEGICDMJCM, bool AEMDHBMKCOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA720", Offset = "0x5CC9320", VA = "0x185CCA720")]
	private void IIBDDDGGEHG(PNNCPIEILFP BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB220", Offset = "0x5CC9E20", VA = "0x185CCB220", Slot = "20")]
	public void NDFEDPCLINO(INFMGJMFHHE MHPJOFNEKOG, Vector3 JOJMCJDEDJC, Vector3 JLDCKNIDGBL, Vector3 NAKHBOOCHOB, float MPDLFFHDHAF, float FMJCNPKMKPI, IReadOnlyList<Camera> BGAKAANBCDJ, PGLABDHKPPB LAPCLBDEMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAE00", Offset = "0x5CC9A00", VA = "0x185CCAE00", Slot = "21")]
	public void NDFEDPCLINO(JOIBLDANFMP FJPGJGBCAFL, Vector3 JOJMCJDEDJC, Vector3 JLDCKNIDGBL, Vector3 NAKHBOOCHOB, float MPDLFFHDHAF, float FMJCNPKMKPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class PLGHJMIEMPO : JIJHDMJKEEF, IMMGCKBFCDB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly PCJANJHFFJD AJIGMJGLFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	protected Bounds KEOFNAIEOOF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds BOCKBBIHPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x166B1A0", Offset = "0x1669DA0", VA = "0x18166B1A0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual CNLNAAJIOJC BJOPCFJAMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4D40", Offset = "0x5CD3940", VA = "0x185CD4D40", Slot = "12")]
		get
		{
			return default(CNLNAAJIOJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676B40", VA = "0x180677F40")]
	protected PLGHJMIEMPO(PCJANJHFFJD MHPJOFNEKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4C70", Offset = "0x5CD3870", VA = "0x185CD4C70", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679900", VA = "0x18067AD00", Slot = "11")]
	public virtual bool FEKEOLEEEJK(HIHDGKIDBHE MHPJOFNEKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int OJDKGBIAAHM(BBIMGAEJAFH LDPMEOOMILD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int AOOHIGMDDNC(BBIMGAEJAFH LDPMEOOMILD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void APMGONIGJJF(BBIMGAEJAFH LDPMEOOMILD, OHBJADHEDAF AMJMNCKBDPB, int LEABJDADMHB = -1);
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
		[Cpp2IlInjected.Address(RVA = "0x5CD4DD0", Offset = "0x5CD39D0", VA = "0x185CD4DD0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum CBJMJDNINPP
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
public static class LEKODJMGKCB
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OFDBOONBBIG : IEnumerable<CCAAKIHOHOO>, IEnumerable, IEnumerator<CCAAKIHOHOO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private CCAAKIHOHOO <>2__current;

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
		private CCAAKIHOHOO System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E8010", VA = "0x1808E9410")]
		[DebuggerHidden]
		public OFDBOONBBIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2C30", Offset = "0x5CD1830", VA = "0x185CD2C30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2DA0", Offset = "0x5CD19A0", VA = "0x185CD2DA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2D10", Offset = "0x5CD1910", VA = "0x185CD2D10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CCAAKIHOHOO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2D10", Offset = "0x5CD1910", VA = "0x185CD2D10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int GBIGJEGFGOH = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static CCAAKIHOHOO[][] IECBEBCDBFI;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static NHGGELIOFFN FMGANFHDHBE;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static ShapeRendererConfig OLHIIOOJJIM;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader FPIAHFOHJOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFFC0", Offset = "0x5CCEBC0", VA = "0x185CCFFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer PFNKIFMDBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0030", Offset = "0x5CCEC30", VA = "0x185CD0030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5CD00A0", Offset = "0x5CCECA0", VA = "0x185CD00A0")]
	public static Mesh FAEBDPOGOOC(CBJMJDNINPP OCKHFJJIJOF, int LDPMEOOMILD = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0850", Offset = "0x5CCF450", VA = "0x185CD0850")]
	public static int OCKMINJHOKA(CBJMJDNINPP OCKHFJJIJOF, int LDPMEOOMILD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5CD06E0", Offset = "0x5CCF2E0", VA = "0x185CD06E0")]
	public static NHGGELIOFFN KMDCDINHIKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFF60", Offset = "0x5CCEB60", VA = "0x185CCFF60")]
	[IteratorStateMachine(typeof(OFDBOONBBIG))]
	private static IEnumerable<CCAAKIHOHOO> DEMLKIMAPJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0160", Offset = "0x5CCED60", VA = "0x185CD0160")]
	public static CCAAKIHOHOO FBJACDKJMFB(CBJMJDNINPP OCKHFJJIJOF, int LDPMEOOMILD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF9E0", Offset = "0x5CCE5E0", VA = "0x185CCF9E0")]
	public static bool CFMHAMLEAGE(this CBJMJDNINPP OCKHFJJIJOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFDB0", Offset = "0x5CCE9B0", VA = "0x185CCFDB0")]
	public static void DCECCCLMPOG(CBJMJDNINPP OCKHFJJIJOF, float3 ADJHJDFPGCI, out PCIGKJMOKDA DEBGGPEPNJD, out float3 CBAMFFNLDDN, out float MCFMLLIAGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFA00", Offset = "0x5CCE600", VA = "0x185CCFA00")]
	public static void CLINLCDOGHM(Vector3 ADJHJDFPGCI, CBJMJDNINPP OCKHFJJIJOF, out Vector3 CBAMFFNLDDN, out float MCFMLLIAGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0840", Offset = "0x5CCF440", VA = "0x185CD0840")]
	[ECPMKACBNFP(JMKOAIIKPBP.ExitingPlayMode, 0)]
	private static void MKCPPBJAGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CD04C0", Offset = "0x5CCF0C0", VA = "0x185CD04C0")]
	[ECPMKACBNFP(JMKOAIIKPBP.ExitingPlayMode, 0)]
	private static void GAKFPILDBBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LLBPGHLBBGN
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool PANBCJCNOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material CBMENOLMFBE();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material HNDCBGBMMEA();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material GFNLNGCCKCH();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NBNGFNCMAOE(NKNPGLCGOCA PFMKAIOKFDE);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KGBMLHMDGKE(JPGEOOLAGJI DFEJOOMDNDF);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HOOJPIJIGBD(GameObject KMFLGGMLFJA);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FFKJFEJPLON(GameObject KMFLGGMLFJA, bool OCLMKAJKDIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface GEKAPEKLKDE
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	PCJANJHFFJD OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	PLGHJMIEMPO OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	LEOGHOEGLLP OPKHBNOGHCE
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
	[HFIGNCEGOKM(DDEOJCINOPG.ShapeRendering)]
	public class ShapeRendererManager : MHIAMMHAEHO, IDisposable, GEKAPEKLKDE
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly global::LDNHPEHKDFI<INFMGJMFHHE, PCJANJHFFJD> CHJMGPIMDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly global::LDNHPEHKDFI<NAMHIJGBHBB, PLGHJMIEMPO> FHBFFNJLJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly global::LDNHPEHKDFI<JOIBLDANFMP, LEOGHOEGLLP> FCKMFFBFPAA;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static LLBPGHLBBGN EJLHBNLEKLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5CD5AB0", Offset = "0x5CD46B0", VA = "0x185CD5AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5CD59B0", Offset = "0x5CD45B0", VA = "0x185CD59B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public PCJANJHFFJD OPKHBNOGHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x5CD5550", Offset = "0x5CD4150", VA = "0x185CD5550", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public PLGHJMIEMPO OPKHBNOGHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x5CD54F0", Offset = "0x5CD40F0", VA = "0x185CD54F0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public LEOGHOEGLLP OPKHBNOGHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5CD55B0", Offset = "0x5CD41B0", VA = "0x185CD55B0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5CF0", Offset = "0x5CD48F0", VA = "0x185CD5CF0")]
		public ShapeRendererManager(LLBPGHLBBGN MIAMGGPFAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5460", Offset = "0x5CD4060", VA = "0x185CD5460", Slot = "16")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5610", Offset = "0x5CD4210", VA = "0x185CD5610", Slot = "4")]
		public INFMGJMFHHE GGKDINNNDLO(BJNHKBMJGLH JLFCOOGLPMP)
		{
			return default(INFMGJMFHHE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5000", Offset = "0x5CD3C00", VA = "0x185CD5000", Slot = "5")]
		public void CAJDEHAAMGP(INFMGJMFHHE MHPJOFNEKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5820", Offset = "0x5CD4420", VA = "0x185CD5820", Slot = "6")]
		public void GPCCBNOPHFC(INFMGJMFHHE MHPJOFNEKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5710", Offset = "0x5CD4310", VA = "0x185CD5710", Slot = "7")]
		public NAMHIJGBHBB GOPBMDJFHLG(INFMGJMFHHE MHPJOFNEKOG, LCJLMHMGJBH JLFCOOGLPMP)
		{
			return default(NAMHIJGBHBB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5CD58A0", Offset = "0x5CD44A0", VA = "0x185CD58A0", Slot = "8")]
		public NAMHIJGBHBB HGFHAOFBKHH(INFMGJMFHHE MHPJOFNEKOG, PIOGPBHPCID JLFCOOGLPMP)
		{
			return default(NAMHIJGBHBB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5A20", Offset = "0x5CD4620", VA = "0x185CD5A20", Slot = "10")]
		public void IGDFPCLBONG(NAMHIJGBHBB HBIKDKNLIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4E00", Offset = "0x5CD3A00", VA = "0x185CD4E00", Slot = "9")]
		public void AOIKGEECAKL(NAMHIJGBHBB HBIKDKNLIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5BE0", Offset = "0x5CD47E0", VA = "0x185CD5BE0", Slot = "15")]
		public IEnumerable<Renderer> PGNONKMMLKI(INFMGJMFHHE MHPJOFNEKOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4E60", Offset = "0x5CD3A60", VA = "0x185CD4E60", Slot = "11")]
		public JOIBLDANFMP BBAPHLILIIN(JNCGGIFMBJM JLFCOOGLPMP)
		{
			return default(JOIBLDANFMP);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5B70", Offset = "0x5CD4770", VA = "0x185CD5B70", Slot = "13")]
		public void NNLHKBNKEIM(JOIBLDANFMP FJPGJGBCAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5B10", Offset = "0x5CD4710", VA = "0x185CD5B10", Slot = "12")]
		public void KKODDJMLNMH(JOIBLDANFMP FJPGJGBCAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5060", Offset = "0x5CD3C60", VA = "0x185CD5060", Slot = "14")]
		public NFHFGCGPPAN DLEOGENLFBN(HIHDGKIDBHE ICFDLHANCHH, IEnumerable<NAMHIJGBHBB> FHBFFNJLJMA, int FNLPGDFPLCP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LEOGHOEGLLP : FCDLGAIDMKC
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class DMLCIKCJCBD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LEOGHOEGLLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E8010", VA = "0x1808E9410")]
		[DebuggerHidden]
		public DMLCIKCJCBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9B40", Offset = "0x5CC8740", VA = "0x185CC9B40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9860", Offset = "0x5CC8460", VA = "0x185CC9860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9BC0", Offset = "0x5CC87C0", VA = "0x185CC9BC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9B00", Offset = "0x5CC8700", VA = "0x185CC9B00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9A60", Offset = "0x5CC8660", VA = "0x185CC9A60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9A60", Offset = "0x5CC8660", VA = "0x185CC9A60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly JNCGGIFMBJM CHBAFLENILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly GEKAPEKLKDE CEJIJOFJOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NKGKGDLNGGI APIHEPAALBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private List<FCMNFGJDDMI> ALKNJAALKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private List<FCMNFGJDDMI> BDMFMFINEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject NOGOPBCBIEF;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0900", Offset = "0x5CCF500", VA = "0x185CD0900")]
	public static LEOGHOEGLLP CIIDOBLOJGL(JNCGGIFMBJM JLFCOOGLPMP, GEKAPEKLKDE CEJIJOFJOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1EB0", Offset = "0x5CD0AB0", VA = "0x185CD1EB0")]
	private LEOGHOEGLLP(JNCGGIFMBJM JLFCOOGLPMP, GEKAPEKLKDE CEJIJOFJOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5CD19D0", Offset = "0x5CD05D0", VA = "0x185CD19D0")]
	public void OJNONIJIFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0A70", Offset = "0x5CCF670", VA = "0x185CD0A70")]
	[IteratorStateMachine(typeof(DMLCIKCJCBD))]
	public IEnumerable<Renderer> JGOEBNEDBMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0E20", Offset = "0x5CCFA20", VA = "0x185CD0E20", Slot = "4")]
	public void MABHDCCBPHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0AE0", Offset = "0x5CCF6E0", VA = "0x185CD0AE0")]
	private void LKCLDMDGLGJ(Vector3 MPDELAEIHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0B80", Offset = "0x5CCF780", VA = "0x185CD0B80")]
	public void LPIFGEKCIOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class FCMNFGJDDMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct OLPOIIMALIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public OHBJADHEDAF GANEBLAAPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public HIHDGKIDBHE OLKGIKHJGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int GILMJCHFNCI;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MODNAHECMCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public FCMNFGJDDMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public BBIMGAEJAFH lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<OLPOIIMALIC> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public NFHFGCGPPAN combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public MODNAHECMCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2010", Offset = "0x5CD0C10", VA = "0x185CD2010")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2070", Offset = "0x5CD0C70", VA = "0x185CD2070")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5CD20A0", Offset = "0x5CD0CA0", VA = "0x185CD20A0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int[] CEFAFMOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private CICJIOMPGJM KDBHDAGPKOO;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static Matrix4x4 HNLDCJHKDGH;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh JBGPNHNENMB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695D30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int KAKNHLOKPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6777D0", VA = "0x180678BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x71B410", Offset = "0x71A010", VA = "0x18071B410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD9E0", Offset = "0x5CCC5E0", VA = "0x185CCD9E0")]
	public void DGGBNEJHNHB(List<HIHDGKIDBHE> HOKOHGOAHLK, Matrix4x4[] FLGJLKFECEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDCA0", Offset = "0x5CCC8A0", VA = "0x185CCDCA0")]
	public static List<FCMNFGJDDMI> GLBIKEOEKPG(List<PCJANJHFFJD> NAFPGNBCLKN, BBIMGAEJAFH LDPMEOOMILD, Bounds BDLOKEMJJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE2D0", Offset = "0x5CCCED0", VA = "0x185CCE2D0")]
	private JobHandle MKGOMNHLPIJ(NFHFGCGPPAN HIMOFEHEKEL, int NFLJBNAPIME, int JDOAPHIBGNO, BBIMGAEJAFH LDPMEOOMILD, List<OLPOIIMALIC> CKGHNJPCJOM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD8D0", Offset = "0x5CCC4D0", VA = "0x185CCD8D0")]
	private void BCJBJIFOMNN(List<OLPOIIMALIC> CKGHNJPCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE7E0", Offset = "0x5CCD3E0", VA = "0x185CCE7E0")]
	private FCMNFGJDDMI(List<OLPOIIMALIC> CKGHNJPCJOM, int NFLJBNAPIME, int JDOAPHIBGNO, BBIMGAEJAFH LDPMEOOMILD, Bounds BDLOKEMJJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDC10", Offset = "0x5CCC810", VA = "0x185CCDC10", Slot = "4")]
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
		private MaterialPropertyBlock LHDEGJEOEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private FCMNFGJDDMI KIGAICGDOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<HIHDGKIDBHE> NBLBMCPBOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private RenderTexture LDKEHDGDFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private ComputeBuffer HLOPFBGJLOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private ComputeShader JEGICGIPKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Matrix4x4[] AHNGJLBKNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private int GJHNNKHLDOC;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer PNLMEELOKMO
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695D40", VA = "0x180697140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int CMPHAHGIPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5CD6F20", Offset = "0x5CD5B20", VA = "0x185CD6F20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6290", Offset = "0x5CD4E90", VA = "0x185CD6290")]
		public static List<SkinnedShapeRenderer> Create(GameObject MHPJOFNEKOG, List<FCMNFGJDDMI> PHCAOOJFBCE, List<HIHDGKIDBHE> NBLBMCPBOMH, Material KONHLMGGONG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5CD68D0", Offset = "0x5CD54D0", VA = "0x185CD68D0")]
		public void Init(FCMNFGJDDMI KIGAICGDOPA, List<HIHDGKIDBHE> NBLBMCPBOMH, Material KONHLMGGONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6E70", Offset = "0x5CD5A70", VA = "0x185CD6E70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6DC0", Offset = "0x5CD59C0", VA = "0x185CD6DC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6D80", Offset = "0x5CD5980", VA = "0x185CD6D80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5CD66A0", Offset = "0x5CD52A0", VA = "0x185CD66A0")]
		private void DIAPCEBFIOC(ScriptableRenderContext EDPENIGJGLF, Camera[] AABKBNFNFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5CD64E0", Offset = "0x5CD50E0", VA = "0x185CD64E0")]
		private void DGGBNEJHNHB(CommandBuffer LMBGADOHBBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xF03490", Offset = "0xF02090", VA = "0x180F03490")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	internal class _RRAssemblyIndex : OJPIMOLMMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5CD7050", Offset = "0x5CD5C50", VA = "0x185CD7050", Slot = "4")]
		public sealed override void LHIOLPAIHGM()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KEJBIFLOMJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] POAMPPAGKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int DNBFJGDJLJG;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int JPELDCGMMIM;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger LIKOKONEDPL;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF3B0", Offset = "0x5CCDFB0", VA = "0x185CCF3B0")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF4C0", Offset = "0x5CCE0C0", VA = "0x185CCF4C0")]
	public static string HPJOPLJIOMI(byte[] EHAMCGPFFID, bool BLMJHFAPIFG)
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
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
