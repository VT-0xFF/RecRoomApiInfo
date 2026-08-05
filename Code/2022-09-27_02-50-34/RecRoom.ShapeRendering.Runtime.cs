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
public enum OHDENDODHPH
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
public static class BKPKIKGANOL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2647130", Offset = "0x2646330", VA = "0x182647130")]
	public static bool ENALNLEDKJD(this OHDENDODHPH FBBODBMEGFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2647180", Offset = "0x2646380", VA = "0x182647180")]
	public static bool NEJFOJPLGNH(this OHDENDODHPH FBBODBMEGFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2647150", Offset = "0x2646350", VA = "0x182647150")]
	public static bool NDDKKEPEENK(this OHDENDODHPH FBBODBMEGFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IPGBLALGAAD
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
public enum JJHLFIBMHFI
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
public enum ECKPOKBEEJN
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
public enum FBGNKJBBMDL
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
public class IJKFMFNKMAK : MFIIJNEPLGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const byte FLCKDBCMFAA = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private byte AONLAPEJOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<SkinnedShapeRenderer>[] HAOAFPDBDGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CPFKHMCHMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x610600", Offset = "0x60F800", VA = "0x180610600", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0F0", Offset = "0x7CE2F0", VA = "0x1807CF0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int IJAHBHPHAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D80", Offset = "0x7E8F80", VA = "0x1807E9D80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x96D550", Offset = "0x96C750", VA = "0x18096D550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float HBJBKMIJEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA82520", Offset = "0xA81720", VA = "0x180A82520", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA82A10", Offset = "0xA81C10", VA = "0x180A82A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float JEMINIOJINE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA82510", Offset = "0xA81710", VA = "0x180A82510", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA82A00", Offset = "0xA81C00", VA = "0x180A82A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> HPFPEPEDMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x264FFB0", Offset = "0x264F1B0", VA = "0x18264FFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> OPALKIDDLNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2014700", Offset = "0x2013900", VA = "0x182014700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject CKGIOFEICDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x734270", Offset = "0x733470", VA = "0x180734270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D6460", Offset = "0x7D5660", VA = "0x1807D6460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte MFBMAFMJJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x264FBE0", Offset = "0x264EDE0", VA = "0x18264FBE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2650050", Offset = "0x264F250", VA = "0x182650050")]
	public IJKFMFNKMAK(List<FOHPAEJHIGI> IEJIPDNOJCK, List<FOHPAEJHIGI> CAFOJGFILDM, List<CBGKELEJBJC> MFJGMOCJCGH, Material CEMALPIHFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x264FAD0", Offset = "0x264ECD0", VA = "0x18264FAD0")]
	private int CJINNNDEEPA(List<FOHPAEJHIGI> DOMDGLHBAEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x264FE50", Offset = "0x264F050", VA = "0x18264FE50")]
	private void MAECKPDJHCD(int KHCGAJOPCAB, bool EAMGOFONHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x264FD60", Offset = "0x264EF60", VA = "0x18264FD60")]
	public void JFDOEBOFEPF(Vector3 MIHOHOIGFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x264FC30", Offset = "0x264EE30", VA = "0x18264FC30", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2650010", Offset = "0x264F210", VA = "0x182650010")]
	public void OEIHJDPHEPK(Transform PGJDMKJCHMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GOHMNJAJBON : NKAGJKLMMJG, KAKFFKFHJLL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class OJELPDNHJEL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GOHMNJAJBON <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x612CF0", Offset = "0x611EF0", VA = "0x180612CF0")]
		[DebuggerHidden]
		public OJELPDNHJEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2652EE0", Offset = "0x26520E0", VA = "0x182652EE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2652A30", Offset = "0x2651C30", VA = "0x182652A30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2653060", Offset = "0x2652260", VA = "0x182653060")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x26530A0", Offset = "0x26522A0", VA = "0x1826530A0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x26530F0", Offset = "0x26522F0", VA = "0x1826530F0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2652E90", Offset = "0x2652090", VA = "0x182652E90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2652DF0", Offset = "0x2651FF0", VA = "0x182652DF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2652DF0", Offset = "0x2651FF0", VA = "0x182652DF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JAKHIPNEMDH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GOHMNJAJBON <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x612CF0", Offset = "0x611EF0", VA = "0x180612CF0")]
		[DebuggerHidden]
		public JAKHIPNEMDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2650D10", Offset = "0x264FF10", VA = "0x182650D10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2650970", Offset = "0x264FB70", VA = "0x182650970", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2650E30", Offset = "0x2650030", VA = "0x182650E30")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2650E80", Offset = "0x2650080", VA = "0x182650E80")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2650CC0", Offset = "0x264FEC0", VA = "0x182650CC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2650C20", Offset = "0x264FE20", VA = "0x182650C20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2650C20", Offset = "0x264FE20", VA = "0x182650C20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly LGALAPNOPHM COFNGFCNCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<ABFCPDNHKHD> AMCGOEBPKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<ClusterMeshRenderer> CEKPPFIPKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private BatchedMeshRenderer FPOOPIGMNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool HNDJIADPLJB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<MKKHEKFHCDH> IOIEHPFCKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CLMNELBOECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x264ED70", Offset = "0x264DF70", VA = "0x18264ED70", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public CBGKELEJBJC DNMLMNAIBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x264EBF0", Offset = "0x264DDF0", VA = "0x18264EBF0", Slot = "7")]
		get
		{
			return default(CBGKELEJBJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> NHCIJGPEDBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6FCDA0", Offset = "0x6FBFA0", VA = "0x1806FCDA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD080", Offset = "0x6FC280", VA = "0x1806FD080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x264F6E0", Offset = "0x264E8E0", VA = "0x18264F6E0")]
	public GOHMNJAJBON(LGALAPNOPHM ADIGGFBANFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x264E5D0", Offset = "0x264D7D0", VA = "0x18264E5D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x264F2C0", Offset = "0x264E4C0", VA = "0x18264F2C0")]
	public void KAGEPJABGKM(ABFCPDNHKHD NNPDJADMBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x264E560", Offset = "0x264D760", VA = "0x18264E560")]
	public void CEDMIKNCMLN(ABFCPDNHKHD NNPDJADMBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x264EDB0", Offset = "0x264DFB0", VA = "0x18264EDB0", Slot = "4")]
	public void JJPOEFLFKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x264ECC0", Offset = "0x264DEC0", VA = "0x18264ECC0")]
	public void HGBIKKNOCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x264F400", Offset = "0x264E600", VA = "0x18264F400")]
	private void LAKGBMACLJN(List<ABFCPDNHKHD> AMCGOEBPKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x264F530", Offset = "0x264E730", VA = "0x18264F530")]
	private static Material MPNIKDGLNNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x264F3B0", Offset = "0x264E5B0", VA = "0x18264F3B0")]
	private void LAKGBMACLJN(ABFCPDNHKHD NNPDJADMBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x264F610", Offset = "0x264E810", VA = "0x18264F610")]
	private void OIAINMOJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x264E670", Offset = "0x264D870", VA = "0x18264E670")]
	public void FGGHJAHJMCL(bool JBCOONHPCHF, bool FGDIGJOCPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x264E4D0", Offset = "0x264D6D0", VA = "0x18264E4D0")]
	protected void BFHPLJLHFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x264F5A0", Offset = "0x264E7A0", VA = "0x18264F5A0")]
	[IteratorStateMachine(typeof(OJELPDNHJEL))]
	public IEnumerable<Renderer> OGOMDADLEIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x264E600", Offset = "0x264D800", VA = "0x18264E600")]
	[IteratorStateMachine(typeof(JAKHIPNEMDH))]
	public IEnumerable<Renderer> EJMELJPKKOL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class GAIHPANPJAB : ABFCPDNHKHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly EKDJNHKNFJN DDJOPJFHLBD;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x264E480", Offset = "0x264D680", VA = "0x18264E480")]
	public GAIHPANPJAB(GOHMNJAJBON LPCFHOPAELK, EKDJNHKNFJN ADIGGFBANFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x264DBD0", Offset = "0x264CDD0", VA = "0x18264DBD0", Slot = "13")]
	public override int CJINNNDEEPA(DDAFJOJEIDO ENNIGHKJGKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x264D9F0", Offset = "0x264CBF0", VA = "0x18264D9F0", Slot = "14")]
	public override int ABCECKOEKNH(DDAFJOJEIDO ENNIGHKJGKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x264DDB0", Offset = "0x264CFB0", VA = "0x18264DDB0", Slot = "15")]
	public override void CLPHJCIHLKF(DDAFJOJEIDO ENNIGHKJGKP, HBEJALPEJBN AJEGKIENOEL, int MFFJLFEJEEM = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct KMEEEMGNPGC : global::FMOBBOIANPF<KMEEEMGNPGC>, AMBNOAMFBPJ, IEquatable<KMEEEMGNPGC>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int CCIFACONDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6FD360", Offset = "0x6FC560", VA = "0x1806FD360", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6FD370", Offset = "0x6FC570", VA = "0x1806FD370", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IDFONEJIHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x881B10", Offset = "0x880D10", VA = "0x180881B10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x881B00", Offset = "0x880D00", VA = "0x180881B00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MJFCPIFHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2650F50", Offset = "0x2650150", VA = "0x182650F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2005020", Offset = "0x2004220", VA = "0x182005020", Slot = "8")]
	public bool Equals(KMEEEMGNPGC GHOINNFPLDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x13975E0", Offset = "0x13967E0", VA = "0x1813975E0")]
	public static bool OBFGCGKAGJG(KMEEEMGNPGC PJIOBOBOEGF, KMEEEMGNPGC KLGGEDCBMPK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x139A7F0", Offset = "0x13999F0", VA = "0x18139A7F0")]
	public static bool IHGNJAHCODI(KMEEEMGNPGC PJIOBOBOEGF, KMEEEMGNPGC KLGGEDCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2650EC0", Offset = "0x26500C0", VA = "0x182650EC0", Slot = "0")]
	public override bool Equals(object PBKPNJLDBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD360", Offset = "0x6FC560", VA = "0x1806FD360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum HENJKCEICCM
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
public interface LGALAPNOPHM
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CBGKELEJBJC GCLPOBBJDLI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	HENJKCEICCM DGHOGGIJPMB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HIJPEKIGEHF : global::FMOBBOIANPF<HIJPEKIGEHF>, AMBNOAMFBPJ, IEquatable<HIJPEKIGEHF>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int CCIFACONDAF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD360", Offset = "0x6FC560", VA = "0x1806FD360", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6FD370", Offset = "0x6FC570", VA = "0x1806FD370", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int IDFONEJIHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x881B10", Offset = "0x880D10", VA = "0x180881B10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x881B00", Offset = "0x880D00", VA = "0x180881B00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MJFCPIFHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x264F800", Offset = "0x264EA00", VA = "0x18264F800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2005020", Offset = "0x2004220", VA = "0x182005020", Slot = "8")]
	public bool Equals(HIJPEKIGEHF GHOINNFPLDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x13975E0", Offset = "0x13967E0", VA = "0x1813975E0")]
	public static bool OBFGCGKAGJG(HIJPEKIGEHF PJIOBOBOEGF, HIJPEKIGEHF KLGGEDCBMPK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x139A7F0", Offset = "0x13999F0", VA = "0x18139A7F0")]
	public static bool IHGNJAHCODI(HIJPEKIGEHF PJIOBOBOEGF, HIJPEKIGEHF KLGGEDCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x264F770", Offset = "0x264E970", VA = "0x18264F770", Slot = "0")]
	public override bool Equals(object PBKPNJLDBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6FD360", Offset = "0x6FC560", VA = "0x1806FD360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BIJKLCIDBBF
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	CBGKELEJBJC GCLPOBBJDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float FPIBEHIMKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 OMOPGEDNIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	OHDENDODHPH JOPAMDLKPPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IPGBLALGAAD MGFNLLFCPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OBDNHHKCEJJ : BIJKLCIDBBF
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	OKCCHAEHLLC LHPPMCFBHKD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HKLFLCOAMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EKDJNHKNFJN : BIJKLCIDBBF
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NNHKBFKOIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MCBGGEDBKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float KFJPMKCGIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int BLNAMCJPOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool FLNPPLGHNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int JFPIOLHJBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<KMKPHCINLAN> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BPEPKFNFHGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMALHJIABPC(KMEEEMGNPGC LPCFHOPAELK, ECKPOKBEEJN GHFAGECDDKJ);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMALHJIABPC(HIJPEKIGEHF NNPDJADMBPK, ECKPOKBEEJN GHFAGECDDKJ);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEBJFKKOHII(HIJPEKIGEHF NNPDJADMBPK);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GENFDFBLFMO(HIJPEKIGEHF NNPDJADMBPK);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EFOLILFAANL();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DIKEDGGAGGC();

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EACPGCOLGBG(ECKPOKBEEJN BGMCKNGNOJI);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NCAOBMNFMNM(KMEEEMGNPGC LPCFHOPAELK);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NCAOBMNFMNM(HIJPEKIGEHF NNPDJADMBPK);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NAOMGOCCDDH(KMEEEMGNPGC LPCFHOPAELK, FBGNKJBBMDL BGMCKNGNOJI);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NAOMGOCCDDH(HIJPEKIGEHF NNPDJADMBPK, FBGNKJBBMDL BGMCKNGNOJI);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IDKLCMLJLII(HIJPEKIGEHF NNPDJADMBPK);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void INAOKPHNDCG(HIJPEKIGEHF NNPDJADMBPK);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CHOFKHDFNHD();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JCFDDHGJGJD();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LPALLOHOJJE(FBGNKJBBMDL BGMCKNGNOJI);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ECEENAHLAEA(KMEEEMGNPGC LPCFHOPAELK, Vector3 LAHBKJELKFL, Vector3 BIJONDLJINK, Vector3 MCBKIGFFENJ, float FDDKFHCKPHL, float FDEHNLPGKBC, IReadOnlyList<Camera> KBJAMPFHFBG, JJHLFIBMHFI EGENHHPLECO);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ECEENAHLAEA(CAPIIDGHAPN INOFMOPIJFC, Vector3 LAHBKJELKFL, Vector3 BIJONDLJINK, Vector3 MCBKIGFFENJ, float FDDKFHCKPHL, float FDEHNLPGKBC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GHIACJCEGCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KMEEEMGNPGC NLDHBPMCAHP(LGALAPNOPHM ADIGGFBANFM);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHIAAPHPDPI(KMEEEMGNPGC LPCFHOPAELK);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHJJOMKEFME(KMEEEMGNPGC LPCFHOPAELK);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HIJPEKIGEHF DDBNBEINCOL(KMEEEMGNPGC LPCFHOPAELK, OBDNHHKCEJJ ADIGGFBANFM);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HIJPEKIGEHF JIHJNJLIEEP(KMEEEMGNPGC LPCFHOPAELK, EKDJNHKNFJN ADIGGFBANFM);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OEAMMAHKFAE(HIJPEKIGEHF NNPDJADMBPK);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EADJHKPCAEE(HIJPEKIGEHF NNPDJADMBPK);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CAPIIDGHAPN JGPKPPHMAPD(BDKKGHOHDDA ADIGGFBANFM);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PHABPHBCOGL(CAPIIDGHAPN INOFMOPIJFC);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OEBMDJCCAAK(CAPIIDGHAPN INOFMOPIJFC);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PDOFANKIOIP OAPNJDBDNBF(CBGKELEJBJC LEIHADOJCKG, IEnumerable<HIJPEKIGEHF> AMCGOEBPKLN, int MALNNHMNOED);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> EGPMHCCGBBE(KMEEEMGNPGC LPCFHOPAELK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CAPIIDGHAPN : global::FMOBBOIANPF<CAPIIDGHAPN>, AMBNOAMFBPJ, IEquatable<CAPIIDGHAPN>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int CCIFACONDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6FD360", Offset = "0x6FC560", VA = "0x1806FD360", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6FD370", Offset = "0x6FC570", VA = "0x1806FD370", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int IDFONEJIHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x881B10", Offset = "0x880D10", VA = "0x180881B10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x881B00", Offset = "0x880D00", VA = "0x180881B00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MJFCPIFHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2649170", Offset = "0x2648370", VA = "0x182649170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2005020", Offset = "0x2004220", VA = "0x182005020", Slot = "8")]
	public bool Equals(CAPIIDGHAPN GHOINNFPLDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x13975E0", Offset = "0x13967E0", VA = "0x1813975E0")]
	public static bool OBFGCGKAGJG(CAPIIDGHAPN PJIOBOBOEGF, CAPIIDGHAPN KLGGEDCBMPK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x139A7F0", Offset = "0x13999F0", VA = "0x18139A7F0")]
	public static bool IHGNJAHCODI(CAPIIDGHAPN PJIOBOBOEGF, CAPIIDGHAPN KLGGEDCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x26490E0", Offset = "0x26482E0", VA = "0x1826490E0", Slot = "0")]
	public override bool Equals(object PBKPNJLDBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD360", Offset = "0x6FC560", VA = "0x1806FD360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BDKKGHOHDDA
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int MAFCEHNCEOI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform AKEOAPAIOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool HDBCFBLOHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KMEEEMGNPGC GetBone(int PBHKOJIKFGJ);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int PBHKOJIKFGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class MJKNJGGAILL : ABFCPDNHKHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly OBDNHHKCEJJ JLLGJJBPJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int[] FNOPJBKABPD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override MNIALFGOFCP DJMILMNFFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x26511F0", Offset = "0x26503F0", VA = "0x1826511F0", Slot = "12")]
		get
		{
			return default(MNIALFGOFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 NINNMGDPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2651F50", Offset = "0x2651150", VA = "0x182651F50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x264E480", Offset = "0x264D680", VA = "0x18264E480")]
	public MJKNJGGAILL(GOHMNJAJBON LPCFHOPAELK, OBDNHHKCEJJ ADIGGFBANFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2652550", Offset = "0x2651750", VA = "0x182652550", Slot = "11")]
	public override bool LNEOMAOABGO(CBGKELEJBJC LPCFHOPAELK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x26515F0", Offset = "0x26507F0", VA = "0x1826515F0", Slot = "13")]
	public override int CJINNNDEEPA(DDAFJOJEIDO ENNIGHKJGKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2651150", Offset = "0x2650350", VA = "0x182651150", Slot = "14")]
	public override int ABCECKOEKNH(DDAFJOJEIDO ENNIGHKJGKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x26522D0", Offset = "0x26514D0", VA = "0x1826522D0")]
	private int GKIBGBNMKII(DDAFJOJEIDO ENNIGHKJGKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2651690", Offset = "0x2650890", VA = "0x182651690", Slot = "15")]
	public override void CLPHJCIHLKF(DDAFJOJEIDO ENNIGHKJGKP, HBEJALPEJBN AJEGKIENOEL, int MFFJLFEJEEM = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IDLBHDFOIHO
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLELFBGMIDE(FBGNKJBBMDL BGMCKNGNOJI, Renderer KJOPNCBPHEJ, int PBEKOLCCLBK);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEHADJBFPLK(Renderer KJOPNCBPHEJ, JJHLFIBMHFI EGENHHPLECO, Vector3 LAHBKJELKFL, Vector3 BIJONDLJINK, Vector3 MCBKIGFFENJ, float FDDKFHCKPHL, float FDEHNLPGKBC, float PPKDFIKPHGH = -1f, [Optional] Color? JGDHNJNCLMJ, [Optional] IReadOnlyList<Camera> LGELNCFCDDJ);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GELPEGBAAEE(Renderer KJOPNCBPHEJ, int PBEKOLCCLBK);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NOMBFHIFMGJ();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KOFPBNLKKMD(int NKEEBJBPCOL, ECKPOKBEEJN BGMCKNGNOJI, Renderer KJOPNCBPHEJ, int PBEKOLCCLBK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BPNDGKOGJHI : BPEPKFNFHGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class IGOLAFEEEEC : global::GMICFHNOJAH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x264FA80", Offset = "0x264EC80", VA = "0x18264FA80")]
		public IGOLAFEEEEC(string JFLKGPEABBP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly IDLBHDFOIHO KKABMEBIHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly GDAMOELPBAL IHBNLFPPLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private MeshRenderer DIJGLLCNAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private IGOLAFEEEEC CBBJKCLOLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool EAHOAFJOLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private MeshRenderer KKBLKKPCNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private IGOLAFEEEEC LNBDDOODINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool HKOAHNGOBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private MeshRenderer IBKBGMMEKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private IGOLAFEEEEC KIEDNGIFPOK;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7FC900", Offset = "0x7FBB00", VA = "0x1807FC900")]
	public BPNDGKOGJHI(IDLBHDFOIHO OCHCILKJJII, GDAMOELPBAL IHBNLFPPLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2647570", Offset = "0x2646770", VA = "0x182647570", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2648390", Offset = "0x2647590", VA = "0x182648390")]
	private void JCDFBIEFFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2647360", Offset = "0x2646560", VA = "0x182647360", Slot = "4")]
	public void AMALHJIABPC(KMEEEMGNPGC LPCFHOPAELK, ECKPOKBEEJN GHFAGECDDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2647190", Offset = "0x2646390", VA = "0x182647190", Slot = "5")]
	public void AMALHJIABPC(HIJPEKIGEHF NNPDJADMBPK, ECKPOKBEEJN GHFAGECDDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2647F70", Offset = "0x2647170", VA = "0x182647F70", Slot = "6")]
	public void EEBJFKKOHII(HIJPEKIGEHF NNPDJADMBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2648170", Offset = "0x2647370", VA = "0x182648170", Slot = "7")]
	public void GENFDFBLFMO(HIJPEKIGEHF NNPDJADMBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2648070", Offset = "0x2647270", VA = "0x182648070", Slot = "8")]
	public void EFOLILFAANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x15FD0F0", Offset = "0x15FC2F0", VA = "0x1815FD0F0", Slot = "9")]
	public void DIKEDGGAGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2647740", Offset = "0x2646940", VA = "0x182647740", Slot = "10")]
	public void EACPGCOLGBG(ECKPOKBEEJN GHFAGECDDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2648F40", Offset = "0x2648140", VA = "0x182648F40", Slot = "11")]
	public void NCAOBMNFMNM(KMEEEMGNPGC LPCFHOPAELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2648CC0", Offset = "0x2647EC0", VA = "0x182648CC0", Slot = "12")]
	public void NCAOBMNFMNM(HIJPEKIGEHF NNPDJADMBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2648B20", Offset = "0x2647D20", VA = "0x182648B20", Slot = "13")]
	public void NAOMGOCCDDH(KMEEEMGNPGC LPCFHOPAELK, FBGNKJBBMDL BGMCKNGNOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2648980", Offset = "0x2647B80", VA = "0x182648980", Slot = "14")]
	public void NAOMGOCCDDH(HIJPEKIGEHF NNPDJADMBPK, FBGNKJBBMDL BGMCKNGNOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2647530", Offset = "0x2646730", VA = "0x182647530", Slot = "17")]
	public void CHOFKHDFNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2648260", Offset = "0x2647460", VA = "0x182648260", Slot = "15")]
	public void IDKLCMLJLII(HIJPEKIGEHF NNPDJADMBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2648300", Offset = "0x2647500", VA = "0x182648300", Slot = "16")]
	public void INAOKPHNDCG(HIJPEKIGEHF NNPDJADMBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x112C7D0", Offset = "0x112B9D0", VA = "0x18112C7D0", Slot = "18")]
	public void JCFDDHGJGJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x26486F0", Offset = "0x26478F0", VA = "0x1826486F0", Slot = "19")]
	public void LPALLOHOJJE(FBGNKJBBMDL BGMCKNGNOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2648540", Offset = "0x2647740", VA = "0x182648540")]
	private void LFDACINEIJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x26487E0", Offset = "0x26479E0", VA = "0x1826487E0")]
	public void NAOMGOCCDDH(HIJPEKIGEHF NNPDJADMBPK, FBGNKJBBMDL BGMCKNGNOJI, bool GNMFBBLBIHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x26480B0", Offset = "0x26472B0", VA = "0x1826480B0")]
	private void FLELFBGMIDE(FBGNKJBBMDL BGMCKNGNOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2647C40", Offset = "0x2646E40", VA = "0x182647C40", Slot = "20")]
	public void ECEENAHLAEA(KMEEEMGNPGC LPCFHOPAELK, Vector3 LAHBKJELKFL, Vector3 BIJONDLJINK, Vector3 MCBKIGFFENJ, float FDDKFHCKPHL, float FDEHNLPGKBC, IReadOnlyList<Camera> KBJAMPFHFBG, JJHLFIBMHFI EGENHHPLECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2647870", Offset = "0x2646A70", VA = "0x182647870", Slot = "21")]
	public void ECEENAHLAEA(CAPIIDGHAPN INOFMOPIJFC, Vector3 LAHBKJELKFL, Vector3 BIJONDLJINK, Vector3 MCBKIGFFENJ, float FDDKFHCKPHL, float FDEHNLPGKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ABFCPDNHKHD : EMHADCNPLEF, MKKHEKFHCDH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly GOHMNJAJBON CKGIOFEICDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	protected Bounds GJJOJPMGEMF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds KOGOAGAEFMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xBC6900", Offset = "0xBC5B00", VA = "0x180BC6900", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual MNIALFGOFCP DJMILMNFFDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2646C70", Offset = "0x2645E70", VA = "0x182646C70", Slot = "12")]
		get
		{
			return default(MNIALFGOFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6270A0", Offset = "0x6262A0", VA = "0x1806270A0")]
	protected ABFCPDNHKHD(GOHMNJAJBON LPCFHOPAELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2646D00", Offset = "0x2645F00", VA = "0x182646D00", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "11")]
	public virtual bool LNEOMAOABGO(CBGKELEJBJC LPCFHOPAELK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int CJINNNDEEPA(DDAFJOJEIDO ENNIGHKJGKP);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int ABCECKOEKNH(DDAFJOJEIDO ENNIGHKJGKP);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void CLPHJCIHLKF(DDAFJOJEIDO ENNIGHKJGKP, HBEJALPEJBN AJEGKIENOEL, int MFFJLFEJEEM = -1);
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
		[Cpp2IlInjected.Address(RVA = "0x2653140", Offset = "0x2652340", VA = "0x182653140")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum OKCCHAEHLLC
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
public static class EECENBFMAMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MFKBNGMBDBA : IEnumerable<AILCBLLDEOL>, IEnumerable, IEnumerator<AILCBLLDEOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private AILCBLLDEOL <>2__current;

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
		private AILCBLLDEOL System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x612CF0", Offset = "0x611EF0", VA = "0x180612CF0")]
		[DebuggerHidden]
		public MFKBNGMBDBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2650F90", Offset = "0x2650190", VA = "0x182650F90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2651100", Offset = "0x2650300", VA = "0x182651100", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2651070", Offset = "0x2650270", VA = "0x182651070", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AILCBLLDEOL> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2651070", Offset = "0x2650270", VA = "0x182651070", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const int KIGALPKCKBO = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static AILCBLLDEOL[][] GEADHKDHGCH;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static MHBBIOHOAEN LODHOHKIELJ;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static ShapeRendererConfig KFINKJECOEO;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader OAAHJMNLLIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2649950", Offset = "0x2648B50", VA = "0x182649950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer JADCAFLLMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x26499C0", Offset = "0x2648BC0", VA = "0x1826499C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2649A90", Offset = "0x2648C90", VA = "0x182649A90")]
	public static Mesh HEGMBAJMAOH(OKCCHAEHLLC ILNAEBHMJBJ, int ENNIGHKJGKP = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2649500", Offset = "0x2648700", VA = "0x182649500")]
	public static int BKBFOIBMLJJ(OKCCHAEHLLC ILNAEBHMJBJ, int ENNIGHKJGKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2649B50", Offset = "0x2648D50", VA = "0x182649B50")]
	public static MHBBIOHOAEN HMEDLJILIIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2649A30", Offset = "0x2648C30", VA = "0x182649A30")]
	[IteratorStateMachine(typeof(MFKBNGMBDBA))]
	private static IEnumerable<AILCBLLDEOL> GAEDBFJNLBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x26491C0", Offset = "0x26483C0", VA = "0x1826491C0")]
	public static AILCBLLDEOL ALANPMENFAM(OKCCHAEHLLC ILNAEBHMJBJ, int ENNIGHKJGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2649510", Offset = "0x2648710", VA = "0x182649510")]
	public static bool DGHJIFJIGBC(this OKCCHAEHLLC ILNAEBHMJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2649CA0", Offset = "0x2648EA0", VA = "0x182649CA0")]
	public static void NGGKFAKNMLC(OKCCHAEHLLC ILNAEBHMJBJ, float3 JAKIHGPGPEG, out CILCICJNGBL NEFNOJDDIKG, out float3 DNFCBHMBBDL, out float GMJEKALNDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2649530", Offset = "0x2648730", VA = "0x182649530")]
	public static void EALDGPNNFIE(Vector3 JAKIHGPGPEG, OKCCHAEHLLC ILNAEBHMJBJ, out Vector3 DNFCBHMBBDL, out float GMJEKALNDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x26491B0", Offset = "0x26483B0", VA = "0x1826491B0")]
	[FJGCJGIINCP(DMLMBCGCBMP.ExitingPlayMode, 0)]
	private static void ACHAGDKJPMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2649E60", Offset = "0x2649060", VA = "0x182649E60")]
	[FJGCJGIINCP(DMLMBCGCBMP.ExitingPlayMode, 0)]
	private static void PNPLFAHOMEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NMIIMOIGLIO
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool FEDKNJANAJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material KOLGMMJHHOH();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material MPNIKDGLNNA();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material DKILKBAKFAB();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PCAOAHINGON(OHDENDODHPH FBBODBMEGFI);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int GBNDMLBACNB(IPGBLALGAAD INBHPPGIGBG);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ANGGJGCEJOC(GameObject PBKPNJLDBOM);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PLKDFFBOKEL(GameObject PBKPNJLDBOM, bool HLNFOBIJPLG);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface GDAMOELPBAL
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GOHMNJAJBON LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ABFCPDNHKHD LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	EMKKFCKMCFA LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class FLJGNAALPNL : GHIACJCEGCA, IDisposable, GDAMOELPBAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly global::OKHLJPIHHFM<KMEEEMGNPGC, GOHMNJAJBON> OJBAJHHDMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly global::OKHLJPIHHFM<HIJPEKIGEHF, ABFCPDNHKHD> AMCGOEBPKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly global::OKHLJPIHHFM<CAPIIDGHAPN, EMKKFCKMCFA> FPCCEHDELMJ;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static NMIIMOIGLIO EIEEOGPBFEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x264B5F0", Offset = "0x264A7F0", VA = "0x18264B5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x264B800", Offset = "0x264AA00", VA = "0x18264B800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public GOHMNJAJBON LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x264C120", Offset = "0x264B320", VA = "0x18264C120", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public ABFCPDNHKHD LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x264C180", Offset = "0x264B380", VA = "0x18264C180", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public EMKKFCKMCFA LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x264C1E0", Offset = "0x264B3E0", VA = "0x18264C1E0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x264C370", Offset = "0x264B570", VA = "0x18264C370")]
	public FLJGNAALPNL(NMIIMOIGLIO OCHCILKJJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x264B720", Offset = "0x264A920", VA = "0x18264B720", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x264BC70", Offset = "0x264AE70", VA = "0x18264BC70", Slot = "4")]
	public KMEEEMGNPGC NLDHBPMCAHP(LGALAPNOPHM ADIGGFBANFM)
	{
		return default(KMEEEMGNPGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x264BC10", Offset = "0x264AE10", VA = "0x18264BC10", Slot = "5")]
	public void LHIAAPHPDPI(KMEEEMGNPGC LPCFHOPAELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x264B910", Offset = "0x264AB10", VA = "0x18264B910", Slot = "6")]
	public void EHJJOMKEFME(KMEEEMGNPGC LPCFHOPAELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x264B850", Offset = "0x264AA50", VA = "0x18264B850", Slot = "15")]
	public IEnumerable<Renderer> EGPMHCCGBBE(KMEEEMGNPGC LPCFHOPAELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x264B630", Offset = "0x264A830", VA = "0x18264B630", Slot = "7")]
	public HIJPEKIGEHF DDBNBEINCOL(KMEEEMGNPGC LPCFHOPAELK, OBDNHHKCEJJ ADIGGFBANFM)
	{
		return default(HIJPEKIGEHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x264BB20", Offset = "0x264AD20", VA = "0x18264BB20", Slot = "8")]
	public HIJPEKIGEHF JIHJNJLIEEP(KMEEEMGNPGC LPCFHOPAELK, EKDJNHKNFJN ADIGGFBANFM)
	{
		return default(HIJPEKIGEHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x264B790", Offset = "0x264A990", VA = "0x18264B790", Slot = "10")]
	public void EADJHKPCAEE(HIJPEKIGEHF NNPDJADMBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x264C240", Offset = "0x264B440", VA = "0x18264C240", Slot = "9")]
	public void OEAMMAHKFAE(HIJPEKIGEHF NNPDJADMBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x264B990", Offset = "0x264AB90", VA = "0x18264B990", Slot = "11")]
	public CAPIIDGHAPN JGPKPPHMAPD(BDKKGHOHDDA ADIGGFBANFM)
	{
		return default(CAPIIDGHAPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x264C2A0", Offset = "0x264B4A0", VA = "0x18264C2A0", Slot = "13")]
	public void OEBMDJCCAAK(CAPIIDGHAPN INOFMOPIJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x264C310", Offset = "0x264B510", VA = "0x18264C310", Slot = "12")]
	public void PHABPHBCOGL(CAPIIDGHAPN INOFMOPIJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x264BD50", Offset = "0x264AF50", VA = "0x18264BD50", Slot = "14")]
	public PDOFANKIOIP OAPNJDBDNBF(CBGKELEJBJC LEIHADOJCKG, IEnumerable<HIJPEKIGEHF> AMCGOEBPKLN, int MALNNHMNOED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class EMKKFCKMCFA : NKAGJKLMMJG
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BEGAGNDENOC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EMKKFCKMCFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x612CF0", Offset = "0x611EF0", VA = "0x180612CF0")]
		[DebuggerHidden]
		public BEGAGNDENOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2647050", Offset = "0x2646250", VA = "0x182647050", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2646D70", Offset = "0x2645F70", VA = "0x182646D70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x26470F0", Offset = "0x26462F0", VA = "0x1826470F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2647000", Offset = "0x2646200", VA = "0x182647000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2646F60", Offset = "0x2646160", VA = "0x182646F60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2646F60", Offset = "0x2646160", VA = "0x182646F60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly BDKKGHOHDDA ELOPNCEEEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly GDAMOELPBAL IHBNLFPPLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private IJKFMFNKMAK OFDOOMPFEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private List<FOHPAEJHIGI> NLGIHHCLIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private List<FOHPAEJHIGI> MDNLMIKCBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private GameObject ONALGOHOHOF;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x264B320", Offset = "0x264A520", VA = "0x18264B320")]
	public static EMKKFCKMCFA LPPFBHDOCFB(BDKKGHOHDDA ADIGGFBANFM, GDAMOELPBAL IHBNLFPPLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x264B4F0", Offset = "0x264A6F0", VA = "0x18264B4F0")]
	private EMKKFCKMCFA(BDKKGHOHDDA ADIGGFBANFM, GDAMOELPBAL IHBNLFPPLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x264A130", Offset = "0x2649330", VA = "0x18264A130")]
	public void DIPAICNNLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x264B480", Offset = "0x264A680", VA = "0x18264B480")]
	[IteratorStateMachine(typeof(BEGAGNDENOC))]
	public IEnumerable<Renderer> OGOMDADLEIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x264A8B0", Offset = "0x2649AB0", VA = "0x18264A8B0", Slot = "4")]
	public void JJPOEFLFKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x264A100", Offset = "0x2649300", VA = "0x18264A100")]
	private void DAHJEAACDED(Vector3 MIHOHOIGFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x264A680", Offset = "0x2649880", VA = "0x18264A680")]
	public void HGBIKKNOCLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class FOHPAEJHIGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct GKFBEEBMEEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public HBEJALPEJBN HMCGOHIBOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CBGKELEJBJC OEDIJMGOECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int PAEKABCEPGA;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DIMLIICPDOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public FOHPAEJHIGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public DDAFJOJEIDO lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public List<GKFBEEBMEEI> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DIMLIICPDOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class HPDKMKFHBBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public PDOFANKIOIP combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public DIMLIICPDOC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public HPDKMKFHBBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x264F840", Offset = "0x264EA40", VA = "0x18264F840")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x264F8B0", Offset = "0x264EAB0", VA = "0x18264F8B0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x264F8F0", Offset = "0x264EAF0", VA = "0x18264F8F0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private int[] JKGEPNHAKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private AFNAAHGFJIL HGKNJOPIHLN;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static Matrix4x4 EPADIPGOOGG;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh GJBHPMDMPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE480", Offset = "0x6ED680", VA = "0x1806EE480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int FJBKCCGNMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD60", Offset = "0x6FEF60", VA = "0x1806FFD60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD70", Offset = "0x6FEF70", VA = "0x1806FFD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x264D1D0", Offset = "0x264C3D0", VA = "0x18264D1D0")]
	public void OPEMPEAEPFB(List<CBGKELEJBJC> GNMEEHCFIDF, Matrix4x4[] AMGAOMDBEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x264CBC0", Offset = "0x264BDC0", VA = "0x18264CBC0")]
	public static List<FOHPAEJHIGI> CNOGLGNGFED(List<GOHMNJAJBON> MIJDGAJNJFG, DDAFJOJEIDO ENNIGHKJGKP, Bounds AKHPMMFMJMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x264C7E0", Offset = "0x264B9E0", VA = "0x18264C7E0")]
	private JobHandle CIECJMGKANI(PDOFANKIOIP MIPCGPKJFGL, int BJCPGDNACIP, int FNEGKCBANIF, DDAFJOJEIDO ENNIGHKJGKP, List<GKFBEEBMEEI> CAHMCGJMJAA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x264D400", Offset = "0x264C600", VA = "0x18264D400")]
	private void PICFDLIHNHN(List<GKFBEEBMEEI> CAHMCGJMJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x264D640", Offset = "0x264C840", VA = "0x18264D640")]
	private FOHPAEJHIGI(List<GKFBEEBMEEI> CAHMCGJMJAA, int BJCPGDNACIP, int FNEGKCBANIF, DDAFJOJEIDO ENNIGHKJGKP, Bounds AKHPMMFMJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x264D150", Offset = "0x264C350", VA = "0x18264D150", Slot = "4")]
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
		private MaterialPropertyBlock LBIPGCJBGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private FOHPAEJHIGI EICLBLAAFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private List<CBGKELEJBJC> MFJGMOCJCGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private RenderTexture DCNPIIPNHEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private ComputeBuffer PMBBMHKLDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private ComputeShader DKJDPDHHCKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private Matrix4x4[] PHDEHMKMJHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int MAMDIBCCPOG;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer IFKHLLEOMKI
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x623BB0", Offset = "0x622DB0", VA = "0x180623BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int MAFCEHNCEOI
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2653CC0", Offset = "0x2652EC0", VA = "0x182653CC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2653380", Offset = "0x2652580", VA = "0x182653380")]
		public static List<SkinnedShapeRenderer> Create(GameObject LPCFHOPAELK, List<FOHPAEJHIGI> DOMDGLHBAEA, List<CBGKELEJBJC> MFJGMOCJCGH, Material CEMALPIHFNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2653590", Offset = "0x2652790", VA = "0x182653590")]
		public void Init(FOHPAEJHIGI EICLBLAAFOL, List<CBGKELEJBJC> MFJGMOCJCGH, Material CEMALPIHFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2653C30", Offset = "0x2652E30", VA = "0x182653C30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2653BA0", Offset = "0x2652DA0", VA = "0x182653BA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2653B60", Offset = "0x2652D60", VA = "0x182653B60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2653170", Offset = "0x2652370", VA = "0x182653170")]
		private void CCJIKJFPBKG(ScriptableRenderContext JAEDJGBMHAP, Camera[] LCMPHBLAMII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x26539B0", Offset = "0x2652BB0", VA = "0x1826539B0")]
		private void OPEMPEAEPFB(CommandBuffer GFMBMPHMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class INAFFMAFPID
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static byte[] JIMOKIHBHOH;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static int FMDPFNLECKI;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static int AONCPEEEHKG;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static BigInteger ILKJFGLFAMB;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public INAFFMAFPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x26506B0", Offset = "0x264F8B0", VA = "0x1826506B0")]
	private static string JBPNMHMEPIE(byte[] KLGGEDCBMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2650380", Offset = "0x264F580", VA = "0x182650380")]
	public static string HDPEGNHHKLG(byte[] FAOJAOEJLMO, bool CGIGAMOFOGM)
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
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
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
