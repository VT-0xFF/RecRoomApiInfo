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
	[Cpp2IlInjected.Address(RVA = "0x5B3DBE0", Offset = "0x5B3C9E0", VA = "0x185B3DBE0")]
	public static bool ACMIEBANKBC(this NKNPGLCGOCA PFMKAIOKFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DC00", Offset = "0x5B3CA00", VA = "0x185B3DC00")]
	public static bool BKBDAAIHNCP(this NKNPGLCGOCA PFMKAIOKFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DC10", Offset = "0x5B3CA10", VA = "0x185B3DC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F190", Offset = "0x64DF90", VA = "0x18064F190", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7047F0", Offset = "0x7035F0", VA = "0x1807047F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ONLCOFMCGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x705FD0", Offset = "0x704DD0", VA = "0x180705FD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x815610", Offset = "0x814410", VA = "0x180815610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float GLEBHCDMLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xCB8220", Offset = "0xCB7020", VA = "0x180CB8220", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xCB8470", Offset = "0xCB7270", VA = "0x180CB8470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float DEFEOLMKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x894FF0", Offset = "0x893DF0", VA = "0x180894FF0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x895120", Offset = "0x893F20", VA = "0x180895120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> JKCOHLMIJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5B3E330", Offset = "0x5B3D130", VA = "0x185B3E330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> DPJFILILJML
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1313C40", Offset = "0x1312A40", VA = "0x181313C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject AJIGMJGLFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C19B0", Offset = "0x6C07B0", VA = "0x1806C19B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte DFPFCOOGKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5B3E2E0", Offset = "0x5B3D0E0", VA = "0x185B3E2E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E4A0", Offset = "0x5B3D2A0", VA = "0x185B3E4A0")]
	public NKGKGDLNGGI(List<FCMNFGJDDMI> DLGBFBIHNEC, List<FCMNFGJDDMI> IMCKHCPPPOI, List<HIHDGKIDBHE> NBLBMCPBOMH, Material KONHLMGGONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E390", Offset = "0x5B3D190", VA = "0x185B3E390")]
	private int OJDKGBIAAHM(List<FCMNFGJDDMI> PHCAOOJFBCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E0B0", Offset = "0x5B3CEB0", VA = "0x185B3E0B0")]
	private void JGOINFOEBDD(int IBFFNFCPGAP, bool FAGHFMDMOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E200", Offset = "0x5B3D000", VA = "0x185B3E200")]
	public void KDMMCJNKPLO(Vector3 MPDELAEIHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DF80", Offset = "0x5B3CD80", VA = "0x185B3DF80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E2A0", Offset = "0x5B3D0A0", VA = "0x185B3E2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
		[DebuggerHidden]
		public BALCEKMILLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5B352A0", Offset = "0x5B340A0", VA = "0x185B352A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5B34D70", Offset = "0x5B33B70", VA = "0x185B34D70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5B353A0", Offset = "0x5B341A0", VA = "0x185B353A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5B353F0", Offset = "0x5B341F0", VA = "0x185B353F0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B35440", Offset = "0x5B34240", VA = "0x185B35440")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5B35260", Offset = "0x5B34060", VA = "0x185B35260", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5B351C0", Offset = "0x5B33FC0", VA = "0x185B351C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5B351C0", Offset = "0x5B33FC0", VA = "0x185B351C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
		[DebuggerHidden]
		public GLBNOBIGCIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5B3ABE0", Offset = "0x5B399E0", VA = "0x185B3ABE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5B3A820", Offset = "0x5B39620", VA = "0x185B3A820", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5B3ACC0", Offset = "0x5B39AC0", VA = "0x185B3ACC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5B3AD10", Offset = "0x5B39B10", VA = "0x185B3AD10")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5B3ABA0", Offset = "0x5B399A0", VA = "0x185B3ABA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5B3AB00", Offset = "0x5B39900", VA = "0x185B3AB00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5B3AB00", Offset = "0x5B39900", VA = "0x185B3AB00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KNLEKKALDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5B3F5C0", Offset = "0x5B3E3C0", VA = "0x185B3F5C0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HIHDGKIDBHE DLMOBPJCBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5B3F480", Offset = "0x5B3E280", VA = "0x185B3F480", Slot = "7")]
		get
		{
			return default(HIHDGKIDBHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> LHAFBFINMCP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x64F720", Offset = "0x64E520", VA = "0x18064F720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6500E0", Offset = "0x64EEE0", VA = "0x1806500E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5B3FCF0", Offset = "0x5B3EAF0", VA = "0x185B3FCF0")]
	public PCJANJHFFJD(BJNHKBMJGLH JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F0F0", Offset = "0x5B3DEF0", VA = "0x185B3F0F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F120", Offset = "0x5B3DF20", VA = "0x185B3F120")]
	public void ELGBPIMHCCH(PLGHJMIEMPO HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F030", Offset = "0x5B3DE30", VA = "0x185B3F030")]
	public void DOHHNJJEEIG(PLGHJMIEMPO HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F6B0", Offset = "0x5B3E4B0", VA = "0x185B3F6B0", Slot = "4")]
	public void MABHDCCBPHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F600", Offset = "0x5B3E400", VA = "0x185B3F600")]
	public void LPIFGEKCIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F280", Offset = "0x5B3E080", VA = "0x185B3F280")]
	private void HGDPIPBIBFC(List<PLGHJMIEMPO> FHBFFNJLJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F3B0", Offset = "0x5B3E1B0", VA = "0x185B3F3B0")]
	private static Material HNDCBGBMMEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F230", Offset = "0x5B3E030", VA = "0x185B3F230")]
	private void HGDPIPBIBFC(PLGHJMIEMPO HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5B3FC20", Offset = "0x5B3EA20", VA = "0x185B3FC20")]
	private void NICGLNPGDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5B3EAA0", Offset = "0x5B3D8A0", VA = "0x185B3EAA0")]
	public void BDNEDFKMEAK(bool BDOMANFBFON, bool LPONIPHNODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5B3EA10", Offset = "0x5B3D810", VA = "0x185B3EA10")]
	protected void AELLLGKHOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F550", Offset = "0x5B3E350", VA = "0x185B3F550")]
	[IteratorStateMachine(typeof(BALCEKMILLM))]
	public IEnumerable<Renderer> JGOEBNEDBMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5B3EFC0", Offset = "0x5B3DDC0", VA = "0x185B3EFC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5B394B0", Offset = "0x5B382B0", VA = "0x185B394B0")]
	public PJGJCLFPPGE(PCJANJHFFJD MHPJOFNEKOG, PIOGPBHPCID JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5B406B0", Offset = "0x5B3F4B0", VA = "0x185B406B0", Slot = "13")]
	public override int OJDKGBIAAHM(BBIMGAEJAFH LDPMEOOMILD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5B3FD90", Offset = "0x5B3EB90", VA = "0x185B3FD90", Slot = "14")]
	public override int AOOHIGMDDNC(BBIMGAEJAFH LDPMEOOMILD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5B3FF80", Offset = "0x5B3ED80", VA = "0x185B3FF80", Slot = "15")]
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
		[Cpp2IlInjected.Address(RVA = "0x6945A0", Offset = "0x6933A0", VA = "0x1806945A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x695E20", Offset = "0x694C20", VA = "0x180695E20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CF8F0", Offset = "0x6CE6F0", VA = "0x1806CF8F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6CF900", Offset = "0x6CE700", VA = "0x1806CF900", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool ILPKKNHIECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5B3AE40", Offset = "0x5B39C40", VA = "0x185B3AE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x11EE150", Offset = "0x11ECF50", VA = "0x1811EE150", Slot = "8")]
	public bool Equals(INFMGJMFHHE MCLIMJFDMCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x11EE640", Offset = "0x11ED440", VA = "0x1811EE640")]
	public static bool IKJLJMIELNH(INFMGJMFHHE LEOEMBMBFBC, INFMGJMFHHE GHDGKPNPOBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x11EE660", Offset = "0x11ED460", VA = "0x1811EE660")]
	public static bool NKIHKFGIBBG(INFMGJMFHHE LEOEMBMBFBC, INFMGJMFHHE GHDGKPNPOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5B3ADB0", Offset = "0x5B39BB0", VA = "0x185B3ADB0", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6945A0", Offset = "0x6933A0", VA = "0x1806945A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5B3AE80", Offset = "0x5B39C80", VA = "0x185B3AE80", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6945A0", Offset = "0x6933A0", VA = "0x1806945A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x695E20", Offset = "0x694C20", VA = "0x180695E20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CF8F0", Offset = "0x6CE6F0", VA = "0x1806CF8F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6CF900", Offset = "0x6CE700", VA = "0x1806CF900", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ILPKKNHIECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5B3DEB0", Offset = "0x5B3CCB0", VA = "0x185B3DEB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x11EE150", Offset = "0x11ECF50", VA = "0x1811EE150", Slot = "8")]
	public bool Equals(NAMHIJGBHBB MCLIMJFDMCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x11EE640", Offset = "0x11ED440", VA = "0x1811EE640")]
	public static bool IKJLJMIELNH(NAMHIJGBHBB LEOEMBMBFBC, NAMHIJGBHBB GHDGKPNPOBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x11EE660", Offset = "0x11ED460", VA = "0x1811EE660")]
	public static bool NKIHKFGIBBG(NAMHIJGBHBB LEOEMBMBFBC, NAMHIJGBHBB GHDGKPNPOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DE20", Offset = "0x5B3CC20", VA = "0x185B3DE20", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6945A0", Offset = "0x6933A0", VA = "0x1806945A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DEF0", Offset = "0x5B3CCF0", VA = "0x185B3DEF0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6945A0", Offset = "0x6933A0", VA = "0x1806945A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x695E20", Offset = "0x694C20", VA = "0x180695E20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int BDCBCEKMBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6CF8F0", Offset = "0x6CE6F0", VA = "0x1806CF8F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6CF900", Offset = "0x6CE700", VA = "0x1806CF900", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool ILPKKNHIECH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5B3AFA0", Offset = "0x5B39DA0", VA = "0x185B3AFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x11EE150", Offset = "0x11ECF50", VA = "0x1811EE150", Slot = "8")]
	public bool Equals(JOIBLDANFMP MCLIMJFDMCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x11EE640", Offset = "0x11ED440", VA = "0x1811EE640")]
	public static bool IKJLJMIELNH(JOIBLDANFMP LEOEMBMBFBC, JOIBLDANFMP GHDGKPNPOBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x11EE660", Offset = "0x11ED460", VA = "0x1811EE660")]
	public static bool NKIHKFGIBBG(JOIBLDANFMP LEOEMBMBFBC, JOIBLDANFMP GHDGKPNPOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5B3AF10", Offset = "0x5B39D10", VA = "0x185B3AF10", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6945A0", Offset = "0x6933A0", VA = "0x1806945A0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B39050", Offset = "0x5B37E50", VA = "0x185B39050", Slot = "12")]
		get
		{
			return default(CNLNAAJIOJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 NGMOMKFOIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5B38A60", Offset = "0x5B37860", VA = "0x185B38A60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5B394B0", Offset = "0x5B382B0", VA = "0x185B394B0")]
	public ELKOICIGKEB(PCJANJHFFJD MHPJOFNEKOG, LCJLMHMGJBH JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5B385F0", Offset = "0x5B373F0", VA = "0x185B385F0", Slot = "11")]
	public override bool FEKEOLEEEJK(HIHDGKIDBHE MHPJOFNEKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5B39400", Offset = "0x5B38200", VA = "0x185B39400", Slot = "13")]
	public override int OJDKGBIAAHM(BBIMGAEJAFH LDPMEOOMILD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5B37C60", Offset = "0x5B36A60", VA = "0x185B37C60", Slot = "14")]
	public override int AOOHIGMDDNC(BBIMGAEJAFH LDPMEOOMILD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5B38DA0", Offset = "0x5B37BA0", VA = "0x185B38DA0")]
	private int LKDIPDOCODG(BBIMGAEJAFH LDPMEOOMILD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5B37D10", Offset = "0x5B36B10", VA = "0x185B37D10", Slot = "15")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B3AD60", Offset = "0x5B39B60", VA = "0x185B3AD60")]
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
	[Cpp2IlInjected.Address(RVA = "0x6EE4A0", Offset = "0x6ED2A0", VA = "0x1806EE4A0")]
	public EGMBMOEOJJA(OKKFOAJCKFN MIAMGGPFAHK, GEKAPEKLKDE CEJIJOFJOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5B35C10", Offset = "0x5B34A10", VA = "0x185B35C10", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5B359C0", Offset = "0x5B347C0", VA = "0x185B359C0")]
	private void AHINONPNKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5B37A60", Offset = "0x5B36860", VA = "0x185B37A60", Slot = "4")]
	public void ONKCGKLFOPF(INFMGJMFHHE MHPJOFNEKOG, BOOPPHGBPBC EKDKGJLNBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5B37840", Offset = "0x5B36640", VA = "0x185B37840", Slot = "5")]
	public void ONKCGKLFOPF(NAMHIJGBHBB HBIKDKNLIBO, BOOPPHGBPBC EKDKGJLNBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5B36030", Offset = "0x5B34E30", VA = "0x185B36030", Slot = "6")]
	public void EPGGOIJPCNP(NAMHIJGBHBB HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5B36160", Offset = "0x5B34F60", VA = "0x185B36160", Slot = "7")]
	public void GMPIEKNJLLA(NAMHIJGBHBB HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5B36310", Offset = "0x5B35110", VA = "0x185B36310", Slot = "8")]
	public void IBNGLJAODPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1C96280", Offset = "0x1C95080", VA = "0x181C96280", Slot = "9")]
	public void FDGNIDDMDLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5B376D0", Offset = "0x5B364D0", VA = "0x185B376D0", Slot = "10")]
	public void OKDBEIDNOOA(BOOPPHGBPBC EKDKGJLNBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5B371D0", Offset = "0x5B35FD0", VA = "0x185B371D0", Slot = "11")]
	public void NEAMIBECMMJ(INFMGJMFHHE MHPJOFNEKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5B37380", Offset = "0x5B36180", VA = "0x185B37380", Slot = "12")]
	public void NEAMIBECMMJ(NAMHIJGBHBB HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5B367D0", Offset = "0x5B355D0", VA = "0x185B367D0", Slot = "13")]
	public void KCAMCBEHIKA(INFMGJMFHHE MHPJOFNEKOG, PNNCPIEILFP BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5B36420", Offset = "0x5B35220", VA = "0x185B36420", Slot = "14")]
	public void KCAMCBEHIKA(NAMHIJGBHBB HBIKDKNLIBO, PNNCPIEILFP BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5B35840", Offset = "0x5B34640", VA = "0x185B35840", Slot = "17")]
	public void AFLLHJAFOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5B36990", Offset = "0x5B35790", VA = "0x185B36990", Slot = "15")]
	public void MPCGMCAPIAP(NAMHIJGBHBB HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5B36280", Offset = "0x5B35080", VA = "0x185B36280", Slot = "16")]
	public void HCJIIDODNPM(NAMHIJGBHBB HBIKDKNLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x184D6A0", Offset = "0x184C4A0", VA = "0x18184D6A0", Slot = "18")]
	public void POGOAILAEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5B35880", Offset = "0x5B34680", VA = "0x185B35880", Slot = "19")]
	public void AGKAJFJMHGL(PNNCPIEILFP BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B34BE0", VA = "0x185B35DE0")]
	private void EIKJJBMFPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5B36610", Offset = "0x5B35410", VA = "0x185B36610")]
	public void KCAMCBEHIKA(NAMHIJGBHBB HBIKDKNLIBO, PNNCPIEILFP BIEGICDMJCM, bool AEMDHBMKCOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5B36350", Offset = "0x5B35150", VA = "0x185B36350")]
	private void IIBDDDGGEHG(PNNCPIEILFP BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5B36E50", Offset = "0x5B35C50", VA = "0x185B36E50", Slot = "20")]
	public void NDFEDPCLINO(INFMGJMFHHE MHPJOFNEKOG, Vector3 JOJMCJDEDJC, Vector3 JLDCKNIDGBL, Vector3 NAKHBOOCHOB, float MPDLFFHDHAF, float FMJCNPKMKPI, IReadOnlyList<Camera> BGAKAANBCDJ, PGLABDHKPPB LAPCLBDEMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5B36A30", Offset = "0x5B35830", VA = "0x185B36A30", Slot = "21")]
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
		[Cpp2IlInjected.Address(RVA = "0x1802D90", Offset = "0x1801B90", VA = "0x181802D90", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual CNLNAAJIOJC BJOPCFJAMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5B40970", Offset = "0x5B3F770", VA = "0x185B40970", Slot = "12")]
		get
		{
			return default(CNLNAAJIOJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
	protected PLGHJMIEMPO(PCJANJHFFJD MHPJOFNEKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5B408A0", Offset = "0x5B3F6A0", VA = "0x185B408A0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B40A00", Offset = "0x5B3F800", VA = "0x185B40A00")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
		[DebuggerHidden]
		public OFDBOONBBIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5B3E860", Offset = "0x5B3D660", VA = "0x185B3E860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5B3E9D0", Offset = "0x5B3D7D0", VA = "0x185B3E9D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5B3E940", Offset = "0x5B3D740", VA = "0x185B3E940", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CCAAKIHOHOO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5B3E940", Offset = "0x5B3D740", VA = "0x185B3E940", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B3BBF0", Offset = "0x5B3A9F0", VA = "0x185B3BBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer PFNKIFMDBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5B3BC60", Offset = "0x5B3AA60", VA = "0x185B3BC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B3BCD0", Offset = "0x5B3AAD0", VA = "0x185B3BCD0")]
	public static Mesh FAEBDPOGOOC(CBJMJDNINPP OCKHFJJIJOF, int LDPMEOOMILD = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C480", Offset = "0x5B3B280", VA = "0x185B3C480")]
	public static int OCKMINJHOKA(CBJMJDNINPP OCKHFJJIJOF, int LDPMEOOMILD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C310", Offset = "0x5B3B110", VA = "0x185B3C310")]
	public static NHGGELIOFFN KMDCDINHIKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5B3BB90", Offset = "0x5B3A990", VA = "0x185B3BB90")]
	[IteratorStateMachine(typeof(OFDBOONBBIG))]
	private static IEnumerable<CCAAKIHOHOO> DEMLKIMAPJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5B3BD90", Offset = "0x5B3AB90", VA = "0x185B3BD90")]
	public static CCAAKIHOHOO FBJACDKJMFB(CBJMJDNINPP OCKHFJJIJOF, int LDPMEOOMILD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B610", Offset = "0x5B3A410", VA = "0x185B3B610")]
	public static bool CFMHAMLEAGE(this CBJMJDNINPP OCKHFJJIJOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B9E0", Offset = "0x5B3A7E0", VA = "0x185B3B9E0")]
	public static void DCECCCLMPOG(CBJMJDNINPP OCKHFJJIJOF, float3 ADJHJDFPGCI, out PCIGKJMOKDA DEBGGPEPNJD, out float3 CBAMFFNLDDN, out float MCFMLLIAGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B630", Offset = "0x5B3A430", VA = "0x185B3B630")]
	public static void CLINLCDOGHM(Vector3 ADJHJDFPGCI, CBJMJDNINPP OCKHFJJIJOF, out Vector3 CBAMFFNLDDN, out float MCFMLLIAGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C470", Offset = "0x5B3B270", VA = "0x185B3C470")]
	[ECPMKACBNFP(JMKOAIIKPBP.ExitingPlayMode, 0)]
	private static void MKCPPBJAGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C0F0", Offset = "0x5B3AEF0", VA = "0x185B3C0F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B416E0", Offset = "0x5B404E0", VA = "0x185B416E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5B415E0", Offset = "0x5B403E0", VA = "0x185B415E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public PCJANJHFFJD OPKHBNOGHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x5B41180", Offset = "0x5B3FF80", VA = "0x185B41180", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public PLGHJMIEMPO OPKHBNOGHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x5B41120", Offset = "0x5B3FF20", VA = "0x185B41120", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public LEOGHOEGLLP OPKHBNOGHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5B411E0", Offset = "0x5B3FFE0", VA = "0x185B411E0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5B41920", Offset = "0x5B40720", VA = "0x185B41920")]
		public ShapeRendererManager(LLBPGHLBBGN MIAMGGPFAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5B41090", Offset = "0x5B3FE90", VA = "0x185B41090", Slot = "16")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5B41240", Offset = "0x5B40040", VA = "0x185B41240", Slot = "4")]
		public INFMGJMFHHE GGKDINNNDLO(BJNHKBMJGLH JLFCOOGLPMP)
		{
			return default(INFMGJMFHHE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5B40C30", Offset = "0x5B3FA30", VA = "0x185B40C30", Slot = "5")]
		public void CAJDEHAAMGP(INFMGJMFHHE MHPJOFNEKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5B41450", Offset = "0x5B40250", VA = "0x185B41450", Slot = "6")]
		public void GPCCBNOPHFC(INFMGJMFHHE MHPJOFNEKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5B41340", Offset = "0x5B40140", VA = "0x185B41340", Slot = "7")]
		public NAMHIJGBHBB GOPBMDJFHLG(INFMGJMFHHE MHPJOFNEKOG, LCJLMHMGJBH JLFCOOGLPMP)
		{
			return default(NAMHIJGBHBB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5B414D0", Offset = "0x5B402D0", VA = "0x185B414D0", Slot = "8")]
		public NAMHIJGBHBB HGFHAOFBKHH(INFMGJMFHHE MHPJOFNEKOG, PIOGPBHPCID JLFCOOGLPMP)
		{
			return default(NAMHIJGBHBB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5B41650", Offset = "0x5B40450", VA = "0x185B41650", Slot = "10")]
		public void IGDFPCLBONG(NAMHIJGBHBB HBIKDKNLIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5B40A30", Offset = "0x5B3F830", VA = "0x185B40A30", Slot = "9")]
		public void AOIKGEECAKL(NAMHIJGBHBB HBIKDKNLIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5B41810", Offset = "0x5B40610", VA = "0x185B41810", Slot = "15")]
		public IEnumerable<Renderer> PGNONKMMLKI(INFMGJMFHHE MHPJOFNEKOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5B40A90", Offset = "0x5B3F890", VA = "0x185B40A90", Slot = "11")]
		public JOIBLDANFMP BBAPHLILIIN(JNCGGIFMBJM JLFCOOGLPMP)
		{
			return default(JOIBLDANFMP);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5B417A0", Offset = "0x5B405A0", VA = "0x185B417A0", Slot = "13")]
		public void NNLHKBNKEIM(JOIBLDANFMP FJPGJGBCAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5B41740", Offset = "0x5B40540", VA = "0x185B41740", Slot = "12")]
		public void KKODDJMLNMH(JOIBLDANFMP FJPGJGBCAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5B40C90", Offset = "0x5B3FA90", VA = "0x185B40C90", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
		[DebuggerHidden]
		public DMLCIKCJCBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5B35770", Offset = "0x5B34570", VA = "0x185B35770", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5B35490", Offset = "0x5B34290", VA = "0x185B35490", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5B357F0", Offset = "0x5B345F0", VA = "0x185B357F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5B35730", Offset = "0x5B34530", VA = "0x185B35730", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5B35690", Offset = "0x5B34490", VA = "0x185B35690", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5B35690", Offset = "0x5B34490", VA = "0x185B35690", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5B3C530", Offset = "0x5B3B330", VA = "0x185B3C530")]
	public static LEOGHOEGLLP CIIDOBLOJGL(JNCGGIFMBJM JLFCOOGLPMP, GEKAPEKLKDE CEJIJOFJOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DAE0", Offset = "0x5B3C8E0", VA = "0x185B3DAE0")]
	private LEOGHOEGLLP(JNCGGIFMBJM JLFCOOGLPMP, GEKAPEKLKDE CEJIJOFJOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5B3D600", Offset = "0x5B3C400", VA = "0x185B3D600")]
	public void OJNONIJIFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C6A0", Offset = "0x5B3B4A0", VA = "0x185B3C6A0")]
	[IteratorStateMachine(typeof(DMLCIKCJCBD))]
	public IEnumerable<Renderer> JGOEBNEDBMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5B3CA50", Offset = "0x5B3B850", VA = "0x185B3CA50", Slot = "4")]
	public void MABHDCCBPHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C710", Offset = "0x5B3B510", VA = "0x185B3C710")]
	private void LKCLDMDGLGJ(Vector3 MPDELAEIHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C7B0", Offset = "0x5B3B5B0", VA = "0x185B3C7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public MODNAHECMCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5B3DC40", Offset = "0x5B3CA40", VA = "0x185B3DC40")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5B3DCA0", Offset = "0x5B3CAA0", VA = "0x185B3DCA0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5B3DCD0", Offset = "0x5B3CAD0", VA = "0x185B3DCD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6507C0", Offset = "0x64F5C0", VA = "0x1806507C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int KAKNHLOKPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x671970", Offset = "0x670770", VA = "0x180671970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7047B0", Offset = "0x7035B0", VA = "0x1807047B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5B39610", Offset = "0x5B38410", VA = "0x185B39610")]
	public void DGGBNEJHNHB(List<HIHDGKIDBHE> HOKOHGOAHLK, Matrix4x4[] FLGJLKFECEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5B398D0", Offset = "0x5B386D0", VA = "0x185B398D0")]
	public static List<FCMNFGJDDMI> GLBIKEOEKPG(List<PCJANJHFFJD> NAFPGNBCLKN, BBIMGAEJAFH LDPMEOOMILD, Bounds BDLOKEMJJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5B39F00", Offset = "0x5B38D00", VA = "0x185B39F00")]
	private JobHandle MKGOMNHLPIJ(NFHFGCGPPAN HIMOFEHEKEL, int NFLJBNAPIME, int JDOAPHIBGNO, BBIMGAEJAFH LDPMEOOMILD, List<OLPOIIMALIC> CKGHNJPCJOM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5B39500", Offset = "0x5B38300", VA = "0x185B39500")]
	private void BCJBJIFOMNN(List<OLPOIIMALIC> CKGHNJPCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5B3A410", Offset = "0x5B39210", VA = "0x185B3A410")]
	private FCMNFGJDDMI(List<OLPOIIMALIC> CKGHNJPCJOM, int NFLJBNAPIME, int JDOAPHIBGNO, BBIMGAEJAFH LDPMEOOMILD, Bounds BDLOKEMJJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5B39840", Offset = "0x5B38640", VA = "0x185B39840", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x65A2C0", Offset = "0x6590C0", VA = "0x18065A2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int CMPHAHGIPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5B42B50", Offset = "0x5B41950", VA = "0x185B42B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5B41EC0", Offset = "0x5B40CC0", VA = "0x185B41EC0")]
		public static List<SkinnedShapeRenderer> Create(GameObject MHPJOFNEKOG, List<FCMNFGJDDMI> PHCAOOJFBCE, List<HIHDGKIDBHE> NBLBMCPBOMH, Material KONHLMGGONG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B41300", VA = "0x185B42500")]
		public void Init(FCMNFGJDDMI KIGAICGDOPA, List<HIHDGKIDBHE> NBLBMCPBOMH, Material KONHLMGGONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5B42AA0", Offset = "0x5B418A0", VA = "0x185B42AA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5B429F0", Offset = "0x5B417F0", VA = "0x185B429F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5B429B0", Offset = "0x5B417B0", VA = "0x185B429B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5B422D0", Offset = "0x5B410D0", VA = "0x185B422D0")]
		private void DIAPCEBFIOC(ScriptableRenderContext EDPENIGJGLF, Camera[] AABKBNFNFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5B42110", Offset = "0x5B40F10", VA = "0x185B42110")]
		private void DGGBNEJHNHB(CommandBuffer LMBGADOHBBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6529C0", Offset = "0x6517C0", VA = "0x1806529C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5B42C80", Offset = "0x5B41A80", VA = "0x185B42C80", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5B3AFE0", Offset = "0x5B39DE0", VA = "0x185B3AFE0")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B0F0", Offset = "0x5B39EF0", VA = "0x185B3B0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
