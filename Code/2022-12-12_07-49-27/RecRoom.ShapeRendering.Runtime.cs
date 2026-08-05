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
public enum PNHEPEPIAIB
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
public static class OKMPDGEKFOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1B4E530", Offset = "0x1B4CB30", VA = "0x181B4E530")]
	public static bool NGKLMPNEFNC(this PNHEPEPIAIB EAOJIIGPCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1B4E550", Offset = "0x1B4CB50", VA = "0x181B4E550")]
	public static bool ODOJIPDIKAJ(this PNHEPEPIAIB EAOJIIGPCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1B4E500", Offset = "0x1B4CB00", VA = "0x181B4E500")]
	public static bool EPIGGCGEMNE(this PNHEPEPIAIB EAOJIIGPCJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CGPECFOKHIA
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
public enum KENMDMAPGJH
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
public enum DOMDBMMMBEC
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
public enum CMOGLFKICML
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
public class CDAGKHAHNNH : KELFHHFIOKJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte IDOBHKALGGN = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte LIFLEOGBOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] HGNJFLDAKKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DHPKFHLGMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x70F350", Offset = "0x70D950", VA = "0x18070F350", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83C660", Offset = "0x83AC60", VA = "0x18083C660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int OJJKJKEPHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83C670", Offset = "0x83AC70", VA = "0x18083C670", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83C680", Offset = "0x83AC80", VA = "0x18083C680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float JBANAOOBFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA7F710", Offset = "0xA7DD10", VA = "0x180A7F710", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA7FC10", Offset = "0xA7E210", VA = "0x180A7FC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float PIAGAJCHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA678C0", Offset = "0xA65EC0", VA = "0x180A678C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA678D0", Offset = "0xA65ED0", VA = "0x180A678D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> JKAACNKELJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1B45D00", Offset = "0x1B44300", VA = "0x181B45D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> ALLDCJJOFHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1A4FAB0", Offset = "0x1A4E0B0", VA = "0x181A4FAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D70", Offset = "0x7E4370", VA = "0x1807E5D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte BAHKENMIBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1B46080", Offset = "0x1B44680", VA = "0x181B46080", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1B46220", Offset = "0x1B44820", VA = "0x181B46220")]
	public CDAGKHAHNNH(List<DEIHFKJPLLP> NMKLCIJFLDG, List<DEIHFKJPLLP> BOPPBIBCPMA, List<IJAKDKFOKND> IPLNCKBMNFG, Material IFICCBFPMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1B45F70", Offset = "0x1B44570", VA = "0x181B45F70")]
	private int GBAIGLCLLJJ(List<DEIHFKJPLLP> PHPAOBGEMEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1B460D0", Offset = "0x1B446D0", VA = "0x181B460D0")]
	private void MEMOPPNFOAI(int HKJBMNCKLLH, bool IBCMFFCNBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1B45D60", Offset = "0x1B44360", VA = "0x181B45D60")]
	public void CGJJHPKACAA(Vector3 LPOAIGHPCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1B45E40", Offset = "0x1B44440", VA = "0x181B45E40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1B45E00", Offset = "0x1B44400", VA = "0x181B45E00")]
	public void DHGJLIJFLDJ(Transform PFBGHBKBKBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LHBNMPCDNCO : JNNAADKIGND, BCEPEADNDLO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IAMGJAAPHAL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LHBNMPCDNCO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
		[DebuggerHidden]
		public IAMGJAAPHAL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1B49240", Offset = "0x1B47840", VA = "0x181B49240", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1B48D10", Offset = "0x1B47310", VA = "0x181B48D10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1B49340", Offset = "0x1B47940", VA = "0x181B49340")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1B49390", Offset = "0x1B47990", VA = "0x181B49390")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1B493E0", Offset = "0x1B479E0", VA = "0x181B493E0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1B49200", Offset = "0x1B47800", VA = "0x181B49200", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1B49160", Offset = "0x1B47760", VA = "0x181B49160", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1B49160", Offset = "0x1B47760", VA = "0x181B49160", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IDODEHPEIAM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LHBNMPCDNCO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
		[DebuggerHidden]
		public IDODEHPEIAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1B497F0", Offset = "0x1B47DF0", VA = "0x181B497F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1B49430", Offset = "0x1B47A30", VA = "0x181B49430", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1B498D0", Offset = "0x1B47ED0", VA = "0x181B498D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1B49920", Offset = "0x1B47F20", VA = "0x181B49920")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1B497B0", Offset = "0x1B47DB0", VA = "0x181B497B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1B49710", Offset = "0x1B47D10", VA = "0x181B49710", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1B49710", Offset = "0x1B47D10", VA = "0x181B49710", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly GEJMHNGBAAL NIPGALMGDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<KPDMDMHAMJN> KJEOOIJBCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> HBOMLBDJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer IIKKEJNCKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool JMDFNOMCAMG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<ECHJHMPELIO> JNDCDHHAHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CBDNOIPIOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1B4BEB0", Offset = "0x1B4A4B0", VA = "0x181B4BEB0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IJAKDKFOKND BCHAIOLIPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1B4BEF0", Offset = "0x1B4A4F0", VA = "0x181B4BEF0", Slot = "7")]
		get
		{
			return default(IJAKDKFOKND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> KGHNFDJNALL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x722690", Offset = "0x720C90", VA = "0x180722690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1B4C780", Offset = "0x1B4AD80", VA = "0x181B4C780")]
	public LHBNMPCDNCO(GEJMHNGBAAL JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1B4BA90", Offset = "0x1B4A090", VA = "0x181B4BA90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1B4BFC0", Offset = "0x1B4A5C0", VA = "0x181B4BFC0")]
	public void MFMCNFFMIAP(KPDMDMHAMJN IJKPNKMHDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1B4BCB0", Offset = "0x1B4A2B0", VA = "0x181B4BCB0")]
	public void EMIFMEAGDDE(KPDMDMHAMJN IJKPNKMHDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1B4C1A0", Offset = "0x1B4A7A0", VA = "0x181B4C1A0", Slot = "4")]
	public void OMDNAEADOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1B4BE00", Offset = "0x1B4A400", VA = "0x181B4BE00")]
	public void LJKNPIDDPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1B4BB80", Offset = "0x1B4A180", VA = "0x181B4BB80")]
	private void EJLCLFMPMFB(List<KPDMDMHAMJN> KJEOOIJBCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1B4B4A0", Offset = "0x1B49AA0", VA = "0x181B4B4A0")]
	private static Material CDNNDIGEFIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1B4BB30", Offset = "0x1B4A130", VA = "0x181B4BB30")]
	private void EJLCLFMPMFB(KPDMDMHAMJN IJKPNKMHDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1B4C0D0", Offset = "0x1B4A6D0", VA = "0x181B4C0D0")]
	private void OGFCLBJNCAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1B4B570", Offset = "0x1B49B70", VA = "0x181B4B570")]
	public void DANNKDMBOEI(bool JMGDDKLMDFJ, bool LHDJPFDPPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1B4BD70", Offset = "0x1B4A370", VA = "0x181B4BD70")]
	protected void FAPLNDFDHEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1B4C710", Offset = "0x1B4AD10", VA = "0x181B4C710")]
	[IteratorStateMachine(typeof(IAMGJAAPHAL))]
	public IEnumerable<Renderer> PGJFEDBDDMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1B4BAC0", Offset = "0x1B4A0C0", VA = "0x181B4BAC0")]
	[IteratorStateMachine(typeof(IDODEHPEIAM))]
	public IEnumerable<Renderer> EEJHPLKJFME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class AGLOJGBOKMI : KPDMDMHAMJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly PAPIIIEPCGC BJMOMMCPJNG;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1B437B0", Offset = "0x1B41DB0", VA = "0x181B437B0")]
	public AGLOJGBOKMI(LHBNMPCDNCO COMPFMNMPEI, PAPIIIEPCGC JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1B42CA0", Offset = "0x1B412A0", VA = "0x181B42CA0", Slot = "13")]
	public override int GBAIGLCLLJJ(AJNEPMAAFBC IGNANJPOBFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1B42E90", Offset = "0x1B41490", VA = "0x181B42E90", Slot = "14")]
	public override int HPOLILMMJJK(AJNEPMAAFBC IGNANJPOBFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1B43080", Offset = "0x1B41680", VA = "0x181B43080", Slot = "15")]
	public override void KEOLOEGHBGO(AJNEPMAAFBC IGNANJPOBFO, KLMKFNMBJPM GHGHKLCEDDA, int BNHOMNFNKAB = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JPMIIEKGMMM : global::LAJFKAIBBBL<JPMIIEKGMMM>, LDGEBNEMAMI, IEquatable<JPMIIEKGMMM>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[CreateProperty]
	public int DNFPKCNMAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x792CD0", Offset = "0x7912D0", VA = "0x180792CD0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x794540", Offset = "0x792B40", VA = "0x180794540", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int HOBPJIMDIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C20", Offset = "0x7F2220", VA = "0x1807F3C20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C30", Offset = "0x7F2230", VA = "0x1807F3C30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool DEHMHJNDOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1B49970", Offset = "0x1B47F70", VA = "0x181B49970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE50", Offset = "0x7DB450", VA = "0x1807DCE50", Slot = "8")]
	public bool Equals(JPMIIEKGMMM OANENNOJEBB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x18EA6B0", Offset = "0x18E8CB0", VA = "0x1818EA6B0")]
	public static bool GBIPOJBPNDJ(JPMIIEKGMMM IKAMJBDPPHG, JPMIIEKGMMM LKLEFAIICIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x18EA6D0", Offset = "0x18E8CD0", VA = "0x1818EA6D0")]
	public static bool EOCJAGBGMLJ(JPMIIEKGMMM IKAMJBDPPHG, JPMIIEKGMMM LKLEFAIICIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1B499B0", Offset = "0x1B47FB0", VA = "0x181B499B0", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x792CD0", Offset = "0x7912D0", VA = "0x180792CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1B49A40", Offset = "0x1B48040", VA = "0x181B49A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum NOKCMKGJEOJ
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
public interface GEJMHNGBAAL
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IJAKDKFOKND DACDPJCIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	NOKCMKGJEOJ NLAGJEDJEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GGFDLHEEICN : global::LAJFKAIBBBL<GGFDLHEEICN>, LDGEBNEMAMI, IEquatable<GGFDLHEEICN>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	[CreateProperty]
	public int DNFPKCNMAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x792CD0", Offset = "0x7912D0", VA = "0x180792CD0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x794540", Offset = "0x792B40", VA = "0x180794540", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int HOBPJIMDIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C20", Offset = "0x7F2220", VA = "0x1807F3C20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C30", Offset = "0x7F2230", VA = "0x1807F3C30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DEHMHJNDOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1B47C90", Offset = "0x1B46290", VA = "0x181B47C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE50", Offset = "0x7DB450", VA = "0x1807DCE50", Slot = "8")]
	public bool Equals(GGFDLHEEICN OANENNOJEBB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x18EA6B0", Offset = "0x18E8CB0", VA = "0x1818EA6B0")]
	public static bool GBIPOJBPNDJ(GGFDLHEEICN IKAMJBDPPHG, GGFDLHEEICN LKLEFAIICIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x18EA6D0", Offset = "0x18E8CD0", VA = "0x1818EA6D0")]
	public static bool EOCJAGBGMLJ(GGFDLHEEICN IKAMJBDPPHG, GGFDLHEEICN LKLEFAIICIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1B47CD0", Offset = "0x1B462D0", VA = "0x181B47CD0", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x792CD0", Offset = "0x7912D0", VA = "0x180792CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1B47D60", Offset = "0x1B46360", VA = "0x181B47D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ILLKFFMDALA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	IJAKDKFOKND DACDPJCIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float NCOFBLBDEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 NMECHHDJKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	PNHEPEPIAIB MMLPBEEBPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	CGPECFOKHIA BKPKJFNLGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MEJAAPGLDOP : ILLKFFMDALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	AJNNDHOPPOC FGNLMOGLLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LOFEMILDFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PAPIIIEPCGC : ILLKFFMDALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BEENBIKMLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool OBCEGAHANBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float BJPKMEJMKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int IJPDEAFOBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool MDBBPKMDCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int FKBDNFMLNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<BBLAAEFFMNC> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LOECDKKBEJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDBLMAJBFDK(JPMIIEKGMMM COMPFMNMPEI, DOMDBMMMBEC DHLAOFCNOPA);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDBLMAJBFDK(GGFDLHEEICN IJKPNKMHDDL, DOMDBMMMBEC DHLAOFCNOPA);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GFBPEDMCDKC(GGFDLHEEICN IJKPNKMHDDL);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CIOECAMAPEN(GGFDLHEEICN IJKPNKMHDDL);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PHAKDHCKHGM();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AMGFLEIMMOK();

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KAOILLIFINA(DOMDBMMMBEC MCLMFJEAHEC);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EJICALFFDHM(JPMIIEKGMMM COMPFMNMPEI);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EJICALFFDHM(GGFDLHEEICN IJKPNKMHDDL);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PAKFLGIJCOD(JPMIIEKGMMM COMPFMNMPEI, CMOGLFKICML MCLMFJEAHEC);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PAKFLGIJCOD(GGFDLHEEICN IJKPNKMHDDL, CMOGLFKICML MCLMFJEAHEC);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void COHDJFOIHII(GGFDLHEEICN IJKPNKMHDDL);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LBBKEFICGAB(GGFDLHEEICN IJKPNKMHDDL);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JGOMAIPHAHH();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NGCBAGHEKJL();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OGHDNLNJMLN(CMOGLFKICML MCLMFJEAHEC);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JDGKIDMLHDF(JPMIIEKGMMM COMPFMNMPEI, Vector3 HMANOPHPKCC, Vector3 OLLIMFEIJHB, Vector3 CJGDKAICMFD, float DCBMGFEHNAA, float NLGGCJPCGFD, IReadOnlyList<Camera> AOPPLLPIOGD, KENMDMAPGJH ODEFPDFHJPP);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JDGKIDMLHDF(ANCPCBKNGNF GPMGEJHKILK, Vector3 HMANOPHPKCC, Vector3 OLLIMFEIJHB, Vector3 CJGDKAICMFD, float DCBMGFEHNAA, float NLGGCJPCGFD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KBGBFEFMINL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPMIIEKGMMM CCLFGKILKFL(GEJMHNGBAAL JIHCLPECHIB);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGANPBAEEKG(JPMIIEKGMMM COMPFMNMPEI);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIHIMCEPCEK(JPMIIEKGMMM COMPFMNMPEI);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GGFDLHEEICN CFHFDMLAKIO(JPMIIEKGMMM COMPFMNMPEI, MEJAAPGLDOP JIHCLPECHIB);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GGFDLHEEICN AJINFHBIHCD(JPMIIEKGMMM COMPFMNMPEI, PAPIIIEPCGC JIHCLPECHIB);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFAJPAEIADL(GGFDLHEEICN IJKPNKMHDDL);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LMKKJMKPIKC(GGFDLHEEICN IJKPNKMHDDL);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ANCPCBKNGNF LONKBKAMPBI(IECGJOJLNML JIHCLPECHIB);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KGIIDADKACM(ANCPCBKNGNF GPMGEJHKILK);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IGGBEBABIJB(ANCPCBKNGNF GPMGEJHKILK);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KDHJDHBAIJA MOEKMINBMBB(IJAKDKFOKND CNNALHNMONG, IEnumerable<GGFDLHEEICN> KJEOOIJBCKK, int NJCOCAOJPCD);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> CMMLPDMHECM(JPMIIEKGMMM COMPFMNMPEI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ANCPCBKNGNF : global::LAJFKAIBBBL<ANCPCBKNGNF>, LDGEBNEMAMI, IEquatable<ANCPCBKNGNF>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int DNFPKCNMAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x792CD0", Offset = "0x7912D0", VA = "0x180792CD0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x794540", Offset = "0x792B40", VA = "0x180794540", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int HOBPJIMDIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C20", Offset = "0x7F2220", VA = "0x1807F3C20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C30", Offset = "0x7F2230", VA = "0x1807F3C30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DEHMHJNDOKD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1B43800", Offset = "0x1B41E00", VA = "0x181B43800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE50", Offset = "0x7DB450", VA = "0x1807DCE50", Slot = "8")]
	public bool Equals(ANCPCBKNGNF OANENNOJEBB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x18EA6B0", Offset = "0x18E8CB0", VA = "0x1818EA6B0")]
	public static bool GBIPOJBPNDJ(ANCPCBKNGNF IKAMJBDPPHG, ANCPCBKNGNF LKLEFAIICIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x18EA6D0", Offset = "0x18E8CD0", VA = "0x1818EA6D0")]
	public static bool EOCJAGBGMLJ(ANCPCBKNGNF IKAMJBDPPHG, ANCPCBKNGNF LKLEFAIICIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1B43840", Offset = "0x1B41E40", VA = "0x181B43840", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x792CD0", Offset = "0x7912D0", VA = "0x180792CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IECGJOJLNML
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int DNJJOLDFNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform OMNCLEAPDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool IBFEGMLGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JPMIIEKGMMM GetBone(int DAOLGKEEPHP);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int DAOLGKEEPHP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class KFLGDLEKMCN : KPDMDMHAMJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly MEJAAPGLDOP NAFFLJHMBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int[] PHAACBNOIHA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override MAJBIGGANLB MOPPKMLOIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1B4AC30", Offset = "0x1B49230", VA = "0x181B4AC30", Slot = "12")]
		get
		{
			return default(MAJBIGGANLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 FHKJLMIIEKP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1B4AFE0", Offset = "0x1B495E0", VA = "0x181B4AFE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1B437B0", Offset = "0x1B41DB0", VA = "0x181B437B0")]
	public KFLGDLEKMCN(LHBNMPCDNCO COMPFMNMPEI, MEJAAPGLDOP JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1B49C30", Offset = "0x1B48230", VA = "0x181B49C30", Slot = "11")]
	public override bool KDGLIDFBFDN(IJAKDKFOKND COMPFMNMPEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1B49AD0", Offset = "0x1B480D0", VA = "0x181B49AD0", Slot = "13")]
	public override int GBAIGLCLLJJ(AJNEPMAAFBC IGNANJPOBFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1B49B80", Offset = "0x1B48180", VA = "0x181B49B80", Slot = "14")]
	public override int HPOLILMMJJK(AJNEPMAAFBC IGNANJPOBFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1B4A980", Offset = "0x1B48F80", VA = "0x181B4A980")]
	private int LGDPLAHMPOO(AJNEPMAAFBC IGNANJPOBFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1B4A0A0", Offset = "0x1B486A0", VA = "0x181B4A0A0", Slot = "15")]
	public override void KEOLOEGHBGO(AJNEPMAAFBC IGNANJPOBFO, KLMKFNMBJPM GHGHKLCEDDA, int BNHOMNFNKAB = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NOPBNOCELKB
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BILBCCKAGJO(CMOGLFKICML MCLMFJEAHEC, Renderer KBINLHMFDOK, int EMJLIIHANFD);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INGPGOGLAFG(Renderer KBINLHMFDOK, KENMDMAPGJH ODEFPDFHJPP, Vector3 HMANOPHPKCC, Vector3 OLLIMFEIJHB, Vector3 CJGDKAICMFD, float DCBMGFEHNAA, float NLGGCJPCGFD, float CBLKFEDPNIL = -1f, [Optional] Color? GCBELIJEOPF, [Optional] IReadOnlyList<Camera> FIJKKFOADBK);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIGDBJPAKOB(Renderer KBINLHMFDOK, int EMJLIIHANFD);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NFKNLHIGCJE();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DCBDMFPIGGP(int MOFOCJGGCIG, DOMDBMMMBEC MCLMFJEAHEC, Renderer KBINLHMFDOK, int EMJLIIHANFD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CBHPCDBELEM : LOECDKKBEJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class PHIAIJDLEGO : global::FDNHAKELDLF<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1B4E560", Offset = "0x1B4CB60", VA = "0x181B4E560")]
		public PHIAIJDLEGO(string NBODBMLPNJA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly NOPBNOCELKB DIAEAIMIANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly ALGEOLBNGIG CJMCALJOEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MeshRenderer OBODCHKDGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private PHIAIJDLEGO NODNPNGKAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool NOCBCCAPLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MeshRenderer LOIBPEJODJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private PHIAIJDLEGO PMPFEIKHFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool DKDGCMJJJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MeshRenderer NCNKJJBDFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private PHIAIJDLEGO BFCKBKOCAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x729000", Offset = "0x727600", VA = "0x180729000")]
	public CBHPCDBELEM(NOPBNOCELKB AGPIMODKDLN, ALGEOLBNGIG CJMCALJOEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1B43DC0", Offset = "0x1B423C0", VA = "0x181B43DC0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1B43AD0", Offset = "0x1B420D0", VA = "0x181B43AD0")]
	private void CKPJAADIKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1B445C0", Offset = "0x1B42BC0", VA = "0x181B445C0", Slot = "4")]
	public void JDBLMAJBFDK(JPMIIEKGMMM COMPFMNMPEI, DOMDBMMMBEC DHLAOFCNOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1B447C0", Offset = "0x1B42DC0", VA = "0x181B447C0", Slot = "5")]
	public void JDBLMAJBFDK(GGFDLHEEICN IJKPNKMHDDL, DOMDBMMMBEC DHLAOFCNOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1B44490", Offset = "0x1B42A90", VA = "0x181B44490", Slot = "6")]
	public void GFBPEDMCDKC(GGFDLHEEICN IJKPNKMHDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1B439B0", Offset = "0x1B41FB0", VA = "0x181B439B0", Slot = "7")]
	public void CIOECAMAPEN(GGFDLHEEICN IJKPNKMHDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1B45CC0", Offset = "0x1B442C0", VA = "0x181B45CC0", Slot = "8")]
	public void PHAKDHCKHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1B438D0", Offset = "0x1B41ED0", VA = "0x181B438D0", Slot = "9")]
	public void AMGFLEIMMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1B451C0", Offset = "0x1B437C0", VA = "0x181B451C0", Slot = "10")]
	public void KAOILLIFINA(DOMDBMMMBEC DHLAOFCNOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1B43F90", Offset = "0x1B42590", VA = "0x181B43F90", Slot = "11")]
	public void EJICALFFDHM(JPMIIEKGMMM COMPFMNMPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1B44140", Offset = "0x1B42740", VA = "0x181B44140", Slot = "12")]
	public void EJICALFFDHM(GGFDLHEEICN IJKPNKMHDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1B45B00", Offset = "0x1B44100", VA = "0x181B45B00", Slot = "13")]
	public void PAKFLGIJCOD(JPMIIEKGMMM COMPFMNMPEI, CMOGLFKICML MCLMFJEAHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1B45910", Offset = "0x1B43F10", VA = "0x181B45910", Slot = "14")]
	public void PAKFLGIJCOD(GGFDLHEEICN IJKPNKMHDDL, CMOGLFKICML MCLMFJEAHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1B45180", Offset = "0x1B43780", VA = "0x181B45180", Slot = "17")]
	public void JGOMAIPHAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1B43D20", Offset = "0x1B42320", VA = "0x181B43D20", Slot = "15")]
	public void COHDJFOIHII(GGFDLHEEICN IJKPNKMHDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1B45330", Offset = "0x1B43930", VA = "0x181B45330", Slot = "16")]
	public void LBBKEFICGAB(GGFDLHEEICN IJKPNKMHDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1498D80", Offset = "0x1497380", VA = "0x181498D80", Slot = "18")]
	public void NGCBAGHEKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1B45610", Offset = "0x1B43C10", VA = "0x181B45610", Slot = "19")]
	public void OGHDNLNJMLN(CMOGLFKICML MCLMFJEAHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1B453C0", Offset = "0x1B439C0", VA = "0x181B453C0")]
	private void NKFALHJBJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1B45750", Offset = "0x1B43D50", VA = "0x181B45750")]
	public void PAKFLGIJCOD(GGFDLHEEICN IJKPNKMHDDL, CMOGLFKICML MCLMFJEAHEC, bool MJLEHIALJAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1B438E0", Offset = "0x1B41EE0", VA = "0x181B438E0")]
	private void BILBCCKAGJO(CMOGLFKICML MCLMFJEAHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1B44E00", Offset = "0x1B43400", VA = "0x181B44E00", Slot = "20")]
	public void JDGKIDMLHDF(JPMIIEKGMMM COMPFMNMPEI, Vector3 HMANOPHPKCC, Vector3 OLLIMFEIJHB, Vector3 CJGDKAICMFD, float DCBMGFEHNAA, float NLGGCJPCGFD, IReadOnlyList<Camera> AOPPLLPIOGD, KENMDMAPGJH ODEFPDFHJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1B449E0", Offset = "0x1B42FE0", VA = "0x181B449E0", Slot = "21")]
	public void JDGKIDMLHDF(ANCPCBKNGNF GPMGEJHKILK, Vector3 HMANOPHPKCC, Vector3 OLLIMFEIJHB, Vector3 CJGDKAICMFD, float DCBMGFEHNAA, float NLGGCJPCGFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class KPDMDMHAMJN : NHFPGMKJPDG, ECHJHMPELIO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly LHBNMPCDNCO AMKPOIHFDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	protected Bounds NKIBKADOLCH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds CDNPPLDCDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1B4B3F0", Offset = "0x1B499F0", VA = "0x181B4B3F0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual MAJBIGGANLB MOPPKMLOIBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1B4B410", Offset = "0x1B49A10", VA = "0x181B4B410", Slot = "12")]
		get
		{
			return default(MAJBIGGANLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
	protected KPDMDMHAMJN(LHBNMPCDNCO COMPFMNMPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1B4B320", Offset = "0x1B49920", VA = "0x181B4B320", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "11")]
	public virtual bool KDGLIDFBFDN(IJAKDKFOKND COMPFMNMPEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int GBAIGLCLLJJ(AJNEPMAAFBC IGNANJPOBFO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int HPOLILMMJJK(AJNEPMAAFBC IGNANJPOBFO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void KEOLOEGHBGO(AJNEPMAAFBC IGNANJPOBFO, KLMKFNMBJPM GHGHKLCEDDA, int BNHOMNFNKAB = -1);
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
		[Cpp2IlInjected.Address(RVA = "0x1B4E5B0", Offset = "0x1B4CBB0", VA = "0x181B4E5B0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum AJNNDHOPPOC
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
public static class HLJIFCNECBE
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FEIDMIBJPAP : IEnumerable<HHHIEGBJAGG>, IEnumerable, IEnumerator<HHHIEGBJAGG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private HHHIEGBJAGG <>2__current;

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
		private HHHIEGBJAGG System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
		[DebuggerHidden]
		public FEIDMIBJPAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1B47AE0", Offset = "0x1B460E0", VA = "0x181B47AE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1B47C50", Offset = "0x1B46250", VA = "0x181B47C50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1B47BC0", Offset = "0x1B461C0", VA = "0x181B47BC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HHHIEGBJAGG> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1B47BC0", Offset = "0x1B461C0", VA = "0x181B47BC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int AJMMLNCOKAK = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static HHHIEGBJAGG[][] LMLPMAEMKNO;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static OEHOEIGFLJN BBGMNKDDFFB;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static ShapeRendererConfig ECNOKLDBOOH;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader KBMDFKNLNOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1B47DF0", Offset = "0x1B463F0", VA = "0x181B47DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer CKFKKKOBBLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1B48220", Offset = "0x1B46820", VA = "0x181B48220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1B48290", Offset = "0x1B46890", VA = "0x181B48290")]
	public static Mesh EBFMDBBFIMG(AJNNDHOPPOC IHLBCGIIFIH, int IGNANJPOBFO = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1B47E60", Offset = "0x1B46460", VA = "0x181B47E60")]
	public static int BOOLBHELHOG(AJNNDHOPPOC IHLBCGIIFIH, int IGNANJPOBFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1B485A0", Offset = "0x1B46BA0", VA = "0x181B485A0")]
	public static OEHOEIGFLJN LMHBDHCNMLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1B48700", Offset = "0x1B46D00", VA = "0x181B48700")]
	[IteratorStateMachine(typeof(FEIDMIBJPAP))]
	private static IEnumerable<HHHIEGBJAGG> MOGFBBFPMPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1B48910", Offset = "0x1B46F10", VA = "0x181B48910")]
	public static HHHIEGBJAGG PCAEJANOGME(AJNNDHOPPOC IHLBCGIIFIH, int IGNANJPOBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1B48580", Offset = "0x1B46B80", VA = "0x181B48580")]
	public static bool LINKEPLGADK(this AJNNDHOPPOC IHLBCGIIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1B48760", Offset = "0x1B46D60", VA = "0x181B48760")]
	public static void OEGLPNHBEMH(AJNNDHOPPOC IHLBCGIIFIH, float3 OKICIOPHOLI, out BJBMJPBJONE KNLCPODCGKK, out float3 CDNBPGEDCFG, out float JJMOFEJFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1B47E70", Offset = "0x1B46470", VA = "0x181B47E70")]
	public static void COOIHEIDDHE(Vector3 OKICIOPHOLI, AJNNDHOPPOC IHLBCGIIFIH, out Vector3 CDNBPGEDCFG, out float JJMOFEJFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1B48570", Offset = "0x1B46B70", VA = "0x181B48570")]
	[IIADNJEBFGG(NKLKDILCDDO.ExitingPlayMode, 0)]
	private static void KPIIJBAILEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1B48350", Offset = "0x1B46950", VA = "0x181B48350")]
	[IIADNJEBFGG(NKLKDILCDDO.ExitingPlayMode, 0)]
	private static void FBLAKEBGBGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AOMIJGMGEAC
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool BDHIINJMPDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material FDKBPIJCEFB();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material CDNNDIGEFIE();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material LCLLJIPBDJJ();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FLKJHLNHNKN(PNHEPEPIAIB EAOJIIGPCJK);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int PKILPCMHLEA(CGPECFOKHIA DBABFIKDMFI);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DDHIOHNDOPO(GameObject LGKNNMGLNIA);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EELPOEPHABE(GameObject LGKNNMGLNIA, bool CNPCFIDMOAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface ALGEOLBNGIG
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LHBNMPCDNCO EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	KPDMDMHAMJN EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	NFHABIMHEDC EAAIOELEIIM
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
	[DAINLFLPADL(OHEDAGNNHJA.ShapeRendering)]
	public class ShapeRendererManager : KBGBFEFMINL, IDisposable, ALGEOLBNGIG
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly global::MCPCGCNIBLF<JPMIIEKGMMM, LHBNMPCDNCO> EBBPNAKFEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly global::MCPCGCNIBLF<GGFDLHEEICN, KPDMDMHAMJN> KJEOOIJBCKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly global::MCPCGCNIBLF<ANCPCBKNGNF, NFHABIMHEDC> CHIOHGHKANF;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static AOMIJGMGEAC COHFOABCADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1B4ED90", Offset = "0x1B4D390", VA = "0x181B4ED90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1B4ED20", Offset = "0x1B4D320", VA = "0x181B4ED20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public LHBNMPCDNCO EAAIOELEIIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1B4EAB0", Offset = "0x1B4D0B0", VA = "0x181B4EAB0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public KPDMDMHAMJN EAAIOELEIIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x1B4EB10", Offset = "0x1B4D110", VA = "0x181B4EB10", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public NFHABIMHEDC EAAIOELEIIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x1B4EB70", Offset = "0x1B4D170", VA = "0x181B4EB70", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1B4F4D0", Offset = "0x1B4DAD0", VA = "0x181B4F4D0")]
		public ShapeRendererManager(AOMIJGMGEAC AGPIMODKDLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1B4EA20", Offset = "0x1B4D020", VA = "0x181B4EA20", Slot = "16")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1B4E750", Offset = "0x1B4CD50", VA = "0x181B4E750", Slot = "4")]
		public JPMIIEKGMMM CCLFGKILKFL(GEJMHNGBAAL JIHCLPECHIB)
		{
			return default(JPMIIEKGMMM);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1B4E5E0", Offset = "0x1B4CBE0", VA = "0x181B4E5E0", Slot = "5")]
		public void AGANPBAEEKG(JPMIIEKGMMM COMPFMNMPEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1B4ECA0", Offset = "0x1B4D2A0", VA = "0x181B4ECA0", Slot = "6")]
		public void IIHIMCEPCEK(JPMIIEKGMMM COMPFMNMPEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1B4E850", Offset = "0x1B4CE50", VA = "0x181B4E850", Slot = "7")]
		public GGFDLHEEICN CFHFDMLAKIO(JPMIIEKGMMM COMPFMNMPEI, MEJAAPGLDOP JIHCLPECHIB)
		{
			return default(GGFDLHEEICN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1B4E640", Offset = "0x1B4CC40", VA = "0x181B4E640", Slot = "8")]
		public GGFDLHEEICN AJINFHBIHCD(JPMIIEKGMMM COMPFMNMPEI, PAPIIIEPCGC JIHCLPECHIB)
		{
			return default(GGFDLHEEICN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1B4EE50", Offset = "0x1B4D450", VA = "0x181B4EE50", Slot = "10")]
		public void LMKKJMKPIKC(GGFDLHEEICN IJKPNKMHDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1B4EBD0", Offset = "0x1B4D1D0", VA = "0x181B4EBD0", Slot = "9")]
		public void IFAJPAEIADL(GGFDLHEEICN IJKPNKMHDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1B4E960", Offset = "0x1B4CF60", VA = "0x181B4E960", Slot = "15")]
		public IEnumerable<Renderer> CMMLPDMHECM(JPMIIEKGMMM COMPFMNMPEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1B4EEE0", Offset = "0x1B4D4E0", VA = "0x181B4EEE0", Slot = "11")]
		public ANCPCBKNGNF LONKBKAMPBI(IECGJOJLNML JIHCLPECHIB)
		{
			return default(ANCPCBKNGNF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1B4EC30", Offset = "0x1B4D230", VA = "0x181B4EC30", Slot = "13")]
		public void IGGBEBABIJB(ANCPCBKNGNF GPMGEJHKILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1B4EDF0", Offset = "0x1B4D3F0", VA = "0x181B4EDF0", Slot = "12")]
		public void KGIIDADKACM(ANCPCBKNGNF GPMGEJHKILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1B4F080", Offset = "0x1B4D680", VA = "0x181B4F080", Slot = "14")]
		public KDHJDHBAIJA MOEKMINBMBB(IJAKDKFOKND AKJOHFKAIKM, IEnumerable<GGFDLHEEICN> KJEOOIJBCKK, int NJCOCAOJPCD)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NFHABIMHEDC : JNNAADKIGND
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ADPJMOHPKGD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public NFHABIMHEDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
		[DebuggerHidden]
		public ADPJMOHPKGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1B42BD0", Offset = "0x1B411D0", VA = "0x181B42BD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1B428F0", Offset = "0x1B40EF0", VA = "0x181B428F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1B42C50", Offset = "0x1B41250", VA = "0x181B42C50")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1B42B90", Offset = "0x1B41190", VA = "0x181B42B90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1B42AF0", Offset = "0x1B410F0", VA = "0x181B42AF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1B42AF0", Offset = "0x1B410F0", VA = "0x181B42AF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly IECGJOJLNML CPIJEPFCIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly ALGEOLBNGIG CJMCALJOEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private CDAGKHAHNNH BGDMHFABLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private List<DEIHFKJPLLP> GGNAPEIACOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private List<DEIHFKJPLLP> OFBBACHDGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject GMIBKMOPABA;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1B4D3D0", Offset = "0x1B4B9D0", VA = "0x181B4D3D0")]
	public static NFHABIMHEDC HBHAIMKCJEC(IECGJOJLNML JIHCLPECHIB, ALGEOLBNGIG CJMCALJOEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1B4E400", Offset = "0x1B4CA00", VA = "0x181B4E400")]
	private NFHABIMHEDC(IECGJOJLNML JIHCLPECHIB, ALGEOLBNGIG CJMCALJOEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1B4CEF0", Offset = "0x1B4B4F0", VA = "0x181B4CEF0")]
	public void BOHBKACNFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1B4E390", Offset = "0x1B4C990", VA = "0x181B4E390")]
	[IteratorStateMachine(typeof(ADPJMOHPKGD))]
	public IEnumerable<Renderer> PGJFEDBDDMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1B4D7E0", Offset = "0x1B4BDE0", VA = "0x181B4D7E0", Slot = "4")]
	public void OMDNAEADOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1B4CE50", Offset = "0x1B4B450", VA = "0x181B4CE50")]
	private void ANOBCBKHPLH(Vector3 LPOAIGHPCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1B4D540", Offset = "0x1B4BB40", VA = "0x181B4D540")]
	public void LJKNPIDDPEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DEIHFKJPLLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct DCKBCKGLNJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public KLMKFNMBJPM GDGEGJALODA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public IJAKDKFOKND KCCJLDMOOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int NGCHLGFBEGK;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DDKHFLFHALL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public DEIHFKJPLLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public AJNEPMAAFBC lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<DCKBCKGLNJF> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public KDHJDHBAIJA combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public DDKHFLFHALL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1B465E0", Offset = "0x1B44BE0", VA = "0x181B465E0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1B46640", Offset = "0x1B44C40", VA = "0x181B46640")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1B46670", Offset = "0x1B44C70", VA = "0x181B46670")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int[] LFBMFDBJLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private LCPHIGAOKJA DFGBFBAPJCD;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static Matrix4x4 KILHPAJGAOC;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh NNOGDCHBAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x71E880", Offset = "0x71CE80", VA = "0x18071E880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int FCHBGIOMOPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6BA610", Offset = "0x6B8C10", VA = "0x1806BA610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1B467C0", Offset = "0x1B44DC0", VA = "0x181B467C0")]
	public void BGFLEILEJEF(List<IJAKDKFOKND> DAMKONIAFFP, Matrix4x4[] BPGPEDDODLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1B469F0", Offset = "0x1B44FF0", VA = "0x181B469F0")]
	public static List<DEIHFKJPLLP> CBFHJGEFJHE(List<LHBNMPCDNCO> GLGHPLKEBGL, AJNEPMAAFBC IGNANJPOBFO, Bounds KLBNFOIEKGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1B470B0", Offset = "0x1B456B0", VA = "0x181B470B0")]
	private JobHandle HCGEMGLAIGD(KDHJDHBAIJA CCAHJKPAEEH, int ECMJCALGKBM, int KANFMGAIAME, AJNEPMAAFBC IGNANJPOBFO, List<DCKBCKGLNJF> BFPHCGJOILB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x1B47490", Offset = "0x1B45A90", VA = "0x181B47490")]
	private void JOEBOODDCEA(List<DCKBCKGLNJF> BFPHCGJOILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1B476D0", Offset = "0x1B45CD0", VA = "0x181B476D0")]
	private DEIHFKJPLLP(List<DCKBCKGLNJF> BFPHCGJOILB, int ECMJCALGKBM, int KANFMGAIAME, AJNEPMAAFBC IGNANJPOBFO, Bounds KLBNFOIEKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1B47020", Offset = "0x1B45620", VA = "0x181B47020", Slot = "4")]
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
		private MaterialPropertyBlock ADOHFPKKDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private DEIHFKJPLLP LGOCCDPBILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<IJAKDKFOKND> IPLNCKBMNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private RenderTexture EEJCDLPIBEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private ComputeBuffer GJHCLAFHPNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private ComputeShader GIIOOGFIPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Matrix4x4[] EFMOFJGKCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private int PLNJHAIIDPE;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer HMLFCIEIBCG
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x728F30", Offset = "0x727530", VA = "0x180728F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int DNJJOLDFNAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x1B50700", Offset = "0x1B4ED00", VA = "0x181B50700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1B4FC30", Offset = "0x1B4E230", VA = "0x181B4FC30")]
		public static List<SkinnedShapeRenderer> Create(GameObject COMPFMNMPEI, List<DEIHFKJPLLP> PHPAOBGEMEE, List<IJAKDKFOKND> IPLNCKBMNFG, Material IFICCBFPMAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1B4FE80", Offset = "0x1B4E480", VA = "0x181B4FE80")]
		public void Init(DEIHFKJPLLP LGOCCDPBILM, List<IJAKDKFOKND> IPLNCKBMNFG, Material IFICCBFPMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1B50650", Offset = "0x1B4EC50", VA = "0x181B50650")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1B505A0", Offset = "0x1B4EBA0", VA = "0x181B505A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1B50560", Offset = "0x1B4EB60", VA = "0x181B50560")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1B50330", Offset = "0x1B4E930", VA = "0x181B50330")]
		private void MCJFFKGDONO(ScriptableRenderContext JOOJGLPIMBB, Camera[] LDANBAPGAND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1B4FA70", Offset = "0x1B4E070", VA = "0x181B4FA70")]
		private void BGFLEILEJEF(CommandBuffer HLLEJHBPAPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	internal class _RRAssemblyIndex : AHAHNEIKLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1B50830", Offset = "0x1B4EE30", VA = "0x181B50830", Slot = "4")]
		public sealed override void GBDHAHIIBFE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1B4CB70", Offset = "0x1B4B170", VA = "0x181B4CB70")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1B4C820", Offset = "0x1B4AE20", VA = "0x181B4C820")]
	public static string FCKPDHOJNPG(byte[] PPJLGCLGPJE, bool KMFFDGBHCMI)
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
