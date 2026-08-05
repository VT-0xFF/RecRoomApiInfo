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
public enum CBCOJFBBCBN
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
public static class KPJLADHNPOG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F3F9F0", Offset = "0x1F3E7F0", VA = "0x181F3F9F0")]
	public static bool GBECOAJLCPE(this CBCOJFBBCBN NHHMOGAOJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1F3FA40", Offset = "0x1F3E840", VA = "0x181F3FA40")]
	public static bool HLJIDCDMBPI(this CBCOJFBBCBN NHHMOGAOJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1F3FA10", Offset = "0x1F3E810", VA = "0x181F3FA10")]
	public static bool HCPAPCMFEHB(this CBCOJFBBCBN NHHMOGAOJKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LEOIFFHCOFE
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
public enum GLENBAPBFIN
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
public enum NKMOLDEJHMN
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
public enum KLMNKJONEDM
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
public class FLAPAFIBENI : JAGLBOEJJFD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte KKABBGKAGCM = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte JCHPNELNCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] HPFFIKPFKLJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KMLCCMNFHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x749E00", Offset = "0x748C00", VA = "0x180749E00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85DB60", Offset = "0x85C960", VA = "0x18085DB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HJLCBCAPDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71D070", Offset = "0x71BE70", VA = "0x18071D070", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xBF5B70", Offset = "0xBF4970", VA = "0x180BF5B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float GNCEKKFIJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC50720", Offset = "0xC4F520", VA = "0x180C50720", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC50C20", Offset = "0xC4FA20", VA = "0x180C50C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float NDMMNDNEIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D10", Offset = "0x6C4B10", VA = "0x1806C5D10", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC38920", Offset = "0xC37720", VA = "0x180C38920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> HBGGPNKJPOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1F3C8D0", Offset = "0x1F3B6D0", VA = "0x181F3C8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> BEGJADGJKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1E5C330", Offset = "0x1E5B130", VA = "0x181E5C330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject FPNNOFOGMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BD0", Offset = "0x6CF9D0", VA = "0x1806D0BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte BPEFFIKIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1F3C650", Offset = "0x1F3B450", VA = "0x181F3C650", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F3C930", Offset = "0x1F3B730", VA = "0x181F3C930")]
	public FLAPAFIBENI(List<PBIJFMLLBIJ> MIGOEMDGKLL, List<PBIJFMLLBIJ> DACBBNLODMK, List<IBPFMLOPCID> GKGMCKIADEJ, Material FCLHIFDODHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1F3C410", Offset = "0x1F3B210", VA = "0x181F3C410")]
	private int AGMFOKIDCFO(List<PBIJFMLLBIJ> GJCOBOCCCLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F3C6A0", Offset = "0x1F3B4A0", VA = "0x181F3C6A0")]
	private void FJNDLMBGKLG(int EKEILLABDGF, bool MLLDIDGDNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F3C7F0", Offset = "0x1F3B5F0", VA = "0x181F3C7F0")]
	public void JMNNJKALLMD(Vector3 PGFPOLGNKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1F3C520", Offset = "0x1F3B320", VA = "0x181F3C520", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1F3C890", Offset = "0x1F3B690", VA = "0x181F3C890")]
	public void PKFEEOKMEFI(Transform OHPJPAMGPDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PJHOMEBHNCK : OJHGLMMOJBI, IDMECPFODDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DLIHJPHGIOP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PJHOMEBHNCK <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC10", Offset = "0x8EEA10", VA = "0x1808EFC10")]
		[DebuggerHidden]
		public DLIHJPHGIOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1F3B180", Offset = "0x1F39F80", VA = "0x181F3B180", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1F3AC50", Offset = "0x1F39A50", VA = "0x181F3AC50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1F3B280", Offset = "0x1F3A080", VA = "0x181F3B280")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1F3B2D0", Offset = "0x1F3A0D0", VA = "0x181F3B2D0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1F3B320", Offset = "0x1F3A120", VA = "0x181F3B320")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1F3B140", Offset = "0x1F39F40", VA = "0x181F3B140", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1F3B0A0", Offset = "0x1F39EA0", VA = "0x181F3B0A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1F3B0A0", Offset = "0x1F39EA0", VA = "0x181F3B0A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EOGDOOPEBIB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PJHOMEBHNCK <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC10", Offset = "0x8EEA10", VA = "0x1808EFC10")]
		[DebuggerHidden]
		public EOGDOOPEBIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1F3C290", Offset = "0x1F3B090", VA = "0x181F3C290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1F3BED0", Offset = "0x1F3ACD0", VA = "0x181F3BED0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1F3C370", Offset = "0x1F3B170", VA = "0x181F3C370")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1F3C3C0", Offset = "0x1F3B1C0", VA = "0x181F3C3C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1F3C250", Offset = "0x1F3B050", VA = "0x181F3C250", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1F3C1B0", Offset = "0x1F3AFB0", VA = "0x181F3C1B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1F3C1B0", Offset = "0x1F3AFB0", VA = "0x181F3C1B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly IKHCGABOAIN HIANJLADBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<JHEDIKNJHPE> PGGIKKNEIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> DGLDDPNJNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer LEEAODIJLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool JJNNMDJHBCA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<IDDBHMGDLJB> LCAPIGMDKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EFBHMIBLEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1F43F40", Offset = "0x1F42D40", VA = "0x181F43F40", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IBPFMLOPCID HGGIKFNBKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1F43760", Offset = "0x1F42560", VA = "0x181F43760", Slot = "7")]
		get
		{
			return default(IBPFMLOPCID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> MIICJOMIKEA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D4450", Offset = "0x6D3250", VA = "0x1806D4450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D4470", Offset = "0x6D3270", VA = "0x1806D4470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1F44040", Offset = "0x1F42E40", VA = "0x181F44040")]
	public PJHOMEBHNCK(IKHCGABOAIN CPLKBCGCHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1F434C0", Offset = "0x1F422C0", VA = "0x181F434C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1F434F0", Offset = "0x1F422F0", VA = "0x181F434F0")]
	public void EKGLGHAFJEH(JHEDIKNJHPE HLDAFADKLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1F43F80", Offset = "0x1F42D80", VA = "0x181F43F80")]
	public void PPEAGPDBOCM(JHEDIKNJHPE HLDAFADKLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F42F50", Offset = "0x1F41D50", VA = "0x181F42F50", Slot = "4")]
	public void BNJIKEMPMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F43DC0", Offset = "0x1F42BC0", VA = "0x181F43DC0")]
	public void KMEGEMCDFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1F42E20", Offset = "0x1F41C20", VA = "0x181F42E20")]
	private void BHOHDKOODON(List<JHEDIKNJHPE> PGGIKKNEIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1F43E70", Offset = "0x1F42C70", VA = "0x181F43E70")]
	private static Material NCODKKBGIMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1F42DD0", Offset = "0x1F41BD0", VA = "0x181F42DD0")]
	private void BHOHDKOODON(JHEDIKNJHPE HLDAFADKLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1F43600", Offset = "0x1F42400", VA = "0x181F43600")]
	private void GFDHKHLPOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1F438A0", Offset = "0x1F426A0", VA = "0x181F438A0")]
	public void KGEIBMEONHP(bool LGPNJHBFIND, bool KKDHAPGBAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1F436D0", Offset = "0x1F424D0", VA = "0x181F436D0")]
	protected void GNKMMEDHMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1F42D60", Offset = "0x1F41B60", VA = "0x181F42D60")]
	[IteratorStateMachine(typeof(DLIHJPHGIOP))]
	public IEnumerable<Renderer> ANIBAEIENNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1F43830", Offset = "0x1F42630", VA = "0x181F43830")]
	[IteratorStateMachine(typeof(EOGDOOPEBIB))]
	public IEnumerable<Renderer> IOJJFCJCHKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class EIABECMNCHJ : JHEDIKNJHPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly ODPHKIJMLNH CDCDPINIGMI;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1F3BE80", Offset = "0x1F3AC80", VA = "0x181F3BE80")]
	public EIABECMNCHJ(PJHOMEBHNCK OJIIPOMCHKP, ODPHKIJMLNH CPLKBCGCHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1F3B370", Offset = "0x1F3A170", VA = "0x181F3B370", Slot = "13")]
	public override int AGMFOKIDCFO(MHLJBECPMPN EFELDHJGAJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1F3B560", Offset = "0x1F3A360", VA = "0x181F3B560", Slot = "14")]
	public override int IBMGIADIMLK(MHLJBECPMPN EFELDHJGAJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1F3B750", Offset = "0x1F3A550", VA = "0x181F3B750", Slot = "15")]
	public override void KDJPMBCHDIP(MHLJBECPMPN EFELDHJGAJI, FFPHKBAPEFF LCAIFILALOH, int BMJIKBCENDE = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JPBOKADKFJM : global::DPOFMDICJLA<JPBOKADKFJM>, GHFDCEBDMDI, IEquatable<JPBOKADKFJM>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[CreateProperty]
	public int NCHPHHOHCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x804EE0", Offset = "0x803CE0", VA = "0x180804EE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA40", Offset = "0x6EE840", VA = "0x1806EFA40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int NPFJJNLPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D1B90", VA = "0x1808D2D90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D30", Offset = "0x8D1B30", VA = "0x1808D2D30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GLKFOIMGEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1F3F920", Offset = "0x1F3E720", VA = "0x181F3F920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8D4990", Offset = "0x8D3790", VA = "0x1808D4990", Slot = "8")]
	public bool Equals(JPBOKADKFJM BNIMMCIKNIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16ED010", Offset = "0x16EBE10", VA = "0x1816ED010")]
	public static bool EKDLGPJCFAN(JPBOKADKFJM EFBCPNIKEHB, JPBOKADKFJM BFLEMGIJKLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x16ED0A0", Offset = "0x16EBEA0", VA = "0x1816ED0A0")]
	public static bool OBFGMGBJCFC(JPBOKADKFJM EFBCPNIKEHB, JPBOKADKFJM BFLEMGIJKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1F3F890", Offset = "0x1F3E690", VA = "0x181F3F890", Slot = "0")]
	public override bool Equals(object LOPIEGGIDMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x804EE0", Offset = "0x803CE0", VA = "0x180804EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1F3F960", Offset = "0x1F3E760", VA = "0x181F3F960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum ANLLLJIGFOC
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
public interface IKHCGABOAIN
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IBPFMLOPCID GKNELKJBCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	ANLLLJIGFOC PBKGNNBANPB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MJHNFFCHOAC : global::DPOFMDICJLA<MJHNFFCHOAC>, GHFDCEBDMDI, IEquatable<MJHNFFCHOAC>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	[CreateProperty]
	public int NCHPHHOHCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x804EE0", Offset = "0x803CE0", VA = "0x180804EE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA40", Offset = "0x6EE840", VA = "0x1806EFA40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int NPFJJNLPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D1B90", VA = "0x1808D2D90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D30", Offset = "0x8D1B30", VA = "0x1808D2D30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool GLKFOIMGEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1F3FAE0", Offset = "0x1F3E8E0", VA = "0x181F3FAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8D4990", Offset = "0x8D3790", VA = "0x1808D4990", Slot = "8")]
	public bool Equals(MJHNFFCHOAC BNIMMCIKNIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x16ED010", Offset = "0x16EBE10", VA = "0x1816ED010")]
	public static bool EKDLGPJCFAN(MJHNFFCHOAC EFBCPNIKEHB, MJHNFFCHOAC BFLEMGIJKLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x16ED0A0", Offset = "0x16EBEA0", VA = "0x1816ED0A0")]
	public static bool OBFGMGBJCFC(MJHNFFCHOAC EFBCPNIKEHB, MJHNFFCHOAC BFLEMGIJKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F3FA50", Offset = "0x1F3E850", VA = "0x181F3FA50", Slot = "0")]
	public override bool Equals(object LOPIEGGIDMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x804EE0", Offset = "0x803CE0", VA = "0x180804EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1F3FB20", Offset = "0x1F3E920", VA = "0x181F3FB20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BINAPGKHHJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	IBPFMLOPCID GKNELKJBCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float KJLOHGBOKKD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 NGNBPBGLNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	CBCOJFBBCBN IKAKHBGKMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	LEOIFFHCOFE ABOHDBGOKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface COLEOEKFNAK : BINAPGKHHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	EPPDJLOPCHC BMMHPCLNFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FDIGKGOFLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ODPHKIJMLNH : BINAPGKHHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BLFJJHGMMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool DHKGKMANMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float NMAMPCILHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int HMBAGDCBKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool HJFLLDHNBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int MFODGHKHELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<AMMBOOOBONH> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GJGBAOJHADB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDDJPIJIMPO(JPBOKADKFJM OJIIPOMCHKP, NKMOLDEJHMN KJBGNDOMAJI);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDDJPIJIMPO(MJHNFFCHOAC HLDAFADKLPI, NKMOLDEJHMN KJBGNDOMAJI);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KAGDLOCIFIN(MJHNFFCHOAC HLDAFADKLPI);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PIJDJELEAGL(MJHNFFCHOAC HLDAFADKLPI);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODOOGGDJOIO();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JOGMJOINKIN();

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EINCGNKOKHI(NKMOLDEJHMN LAKBKKJKBPK);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DLJNCLPNNDD(JPBOKADKFJM OJIIPOMCHKP);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DLJNCLPNNDD(MJHNFFCHOAC HLDAFADKLPI);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FNMMNBGBEJC(JPBOKADKFJM OJIIPOMCHKP, KLMNKJONEDM LAKBKKJKBPK);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FNMMNBGBEJC(MJHNFFCHOAC HLDAFADKLPI, KLMNKJONEDM LAKBKKJKBPK);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FEDIHMOMKPG(MJHNFFCHOAC HLDAFADKLPI);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void INIBFNMJGOC(MJHNFFCHOAC HLDAFADKLPI);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ECPECALJJHG();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DOHPLLFIKJA();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BNKAMCNOONN(KLMNKJONEDM LAKBKKJKBPK);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CIKFMLGOJEJ(JPBOKADKFJM OJIIPOMCHKP, Vector3 KANAAFAOPPH, Vector3 INGBAALBIKG, Vector3 GPMFLLHAFGD, float OBCDEIDHACD, float GIOECMJJMAK, IReadOnlyList<Camera> NGBPIMEPCCO, GLENBAPBFIN EIOKBGLOKND);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CIKFMLGOJEJ(IPOAFPICKLN NFMBFLAOHOA, Vector3 KANAAFAOPPH, Vector3 INGBAALBIKG, Vector3 GPMFLLHAFGD, float OBCDEIDHACD, float GIOECMJJMAK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FNLNKGOIDCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPBOKADKFJM MIKAIDFLLDE(IKHCGABOAIN CPLKBCGCHAN);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PADPFJPCEKJ(JPBOKADKFJM OJIIPOMCHKP);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEGJGHHOGCF(JPBOKADKFJM OJIIPOMCHKP);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MJHNFFCHOAC JMLOGJKHBMM(JPBOKADKFJM OJIIPOMCHKP, COLEOEKFNAK CPLKBCGCHAN);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MJHNFFCHOAC KODCNDPBEKN(JPBOKADKFJM OJIIPOMCHKP, ODPHKIJMLNH CPLKBCGCHAN);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LGEGIIOKAGC(MJHNFFCHOAC HLDAFADKLPI);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BNHEDGFKABF(MJHNFFCHOAC HLDAFADKLPI);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IPOAFPICKLN KIOFHCEPIIH(KCLBONLGPIH CPLKBCGCHAN);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MLFBHOOMBJO(IPOAFPICKLN NFMBFLAOHOA);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HGKPEFEOLKM(IPOAFPICKLN NFMBFLAOHOA);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IDNKHAOLAID FCPPAPENJNI(IBPFMLOPCID PJBKAAGKDNI, IEnumerable<MJHNFFCHOAC> PGGIKKNEIMD, int DJDLDBGIMJF);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> JPDBCLEHLAL(JPBOKADKFJM OJIIPOMCHKP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IPOAFPICKLN : global::DPOFMDICJLA<IPOAFPICKLN>, GHFDCEBDMDI, IEquatable<IPOAFPICKLN>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int NCHPHHOHCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x804EE0", Offset = "0x803CE0", VA = "0x180804EE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA40", Offset = "0x6EE840", VA = "0x1806EFA40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int NPFJJNLPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D1B90", VA = "0x1808D2D90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D30", Offset = "0x8D1B30", VA = "0x1808D2D30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool GLKFOIMGEAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1F3F6D0", Offset = "0x1F3E4D0", VA = "0x181F3F6D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8D4990", Offset = "0x8D3790", VA = "0x1808D4990", Slot = "8")]
	public bool Equals(IPOAFPICKLN BNIMMCIKNIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x16ED010", Offset = "0x16EBE10", VA = "0x1816ED010")]
	public static bool EKDLGPJCFAN(IPOAFPICKLN EFBCPNIKEHB, IPOAFPICKLN BFLEMGIJKLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x16ED0A0", Offset = "0x16EBEA0", VA = "0x1816ED0A0")]
	public static bool OBFGMGBJCFC(IPOAFPICKLN EFBCPNIKEHB, IPOAFPICKLN BFLEMGIJKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1F3F640", Offset = "0x1F3E440", VA = "0x181F3F640", Slot = "0")]
	public override bool Equals(object LOPIEGGIDMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x804EE0", Offset = "0x803CE0", VA = "0x180804EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KCLBONLGPIH
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int POFILPBHMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform JBFBBIOLIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool FEMACDDPJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JPBOKADKFJM GetBone(int EKGLANNGNHE);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int EKGLANNGNHE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class HMPNNKPMLJF : JHEDIKNJHPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly COLEOEKFNAK NABFHNKLBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int[] IJBMKMMBLKF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override FIDFOPFECGN OKGOANNPGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1F3D600", Offset = "0x1F3C400", VA = "0x181F3D600", Slot = "12")]
		get
		{
			return default(FIDFOPFECGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 LKEFAHEAACP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1F3D210", Offset = "0x1F3C010", VA = "0x181F3D210")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1F3BE80", Offset = "0x1F3AC80", VA = "0x181F3BE80")]
	public HMPNNKPMLJF(PJHOMEBHNCK OJIIPOMCHKP, COLEOEKFNAK CPLKBCGCHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1F3CDA0", Offset = "0x1F3BBA0", VA = "0x181F3CDA0", Slot = "11")]
	public override bool GKOJJFHJMCO(IBPFMLOPCID OJIIPOMCHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1F3CCF0", Offset = "0x1F3BAF0", VA = "0x181F3CCF0", Slot = "13")]
	public override int AGMFOKIDCFO(MHLJBECPMPN EFELDHJGAJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1F3D550", Offset = "0x1F3C350", VA = "0x181F3D550", Slot = "14")]
	public override int IBMGIADIMLK(MHLJBECPMPN EFELDHJGAJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E290", Offset = "0x1F3D090", VA = "0x181F3E290")]
	private int PPIBBFCDIDD(MHLJBECPMPN EFELDHJGAJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1F3D9B0", Offset = "0x1F3C7B0", VA = "0x181F3D9B0", Slot = "15")]
	public override void KDJPMBCHDIP(MHLJBECPMPN EFELDHJGAJI, FFPHKBAPEFF LCAIFILALOH, int BMJIKBCENDE = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AENOMAEOHEA
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLCCLLNNKHG(KLMNKJONEDM LAKBKKJKBPK, Renderer KOOGIGDIOFD, int GHALHOGJCML);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFICNCGDAGO(Renderer KOOGIGDIOFD, GLENBAPBFIN EIOKBGLOKND, Vector3 KANAAFAOPPH, Vector3 INGBAALBIKG, Vector3 GPMFLLHAFGD, float OBCDEIDHACD, float GIOECMJJMAK, float LIDOOBOLAEB = -1f, [Optional] Color? IPFDGHGEEEN, [Optional] IReadOnlyList<Camera> BBJDDHIIGJF);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGADHMCFMJM(Renderer KOOGIGDIOFD, int GHALHOGJCML);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BAKBDEIKHBG();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GCBEKEGPPKL(int IIEBCPJEBPM, NKMOLDEJHMN LAKBKKJKBPK, Renderer KOOGIGDIOFD, int GHALHOGJCML);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BACEEGDNLKD : GJGBAOJHADB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class BMBCADIIBPK : global::MHHLKFENHAE<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1F3AC00", Offset = "0x1F39A00", VA = "0x181F3AC00")]
		public BMBCADIIBPK(string CCEKFDNIAPD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly AENOMAEOHEA IOHHMEIPICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly DEHDDCJLCAC HDJKCKEKNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MeshRenderer FPCKIIAJCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private BMBCADIIBPK LIGKMDKLNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool NANHONNBHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MeshRenderer BCMKGBGGAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private BMBCADIIBPK JCMKKCODKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool GCPAHIEIOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MeshRenderer LNAGEMDHOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private BMBCADIIBPK NGGEACPJMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool DNDEJBANJLE;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8FC090", Offset = "0x8FAE90", VA = "0x1808FC090")]
	public BACEEGDNLKD(AENOMAEOHEA HKOMEKNDPHN, DEHDDCJLCAC HDJKCKEKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1F39450", Offset = "0x1F38250", VA = "0x181F39450", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1F397D0", Offset = "0x1F385D0", VA = "0x181F397D0")]
	private void FEAAOIDOAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F3A530", Offset = "0x1F39330", VA = "0x181F3A530", Slot = "4")]
	public void PDDJPIJIMPO(JPBOKADKFJM OJIIPOMCHKP, NKMOLDEJHMN KJBGNDOMAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1F3A310", Offset = "0x1F39110", VA = "0x181F3A310", Slot = "5")]
	public void PDDJPIJIMPO(MJHNFFCHOAC HLDAFADKLPI, NKMOLDEJHMN KJBGNDOMAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1F3A1A0", Offset = "0x1F38FA0", VA = "0x181F3A1A0", Slot = "6")]
	public void KAGDLOCIFIN(MJHNFFCHOAC HLDAFADKLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1F3A730", Offset = "0x1F39530", VA = "0x181F3A730", Slot = "7")]
	public void PIJDJELEAGL(MJHNFFCHOAC HLDAFADKLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1F3A2D0", Offset = "0x1F390D0", VA = "0x181F3A2D0", Slot = "8")]
	public void ODOOGGDJOIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1F3A190", Offset = "0x1F38F90", VA = "0x181F3A190", Slot = "9")]
	public void JOGMJOINKIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1F39660", Offset = "0x1F38460", VA = "0x181F39660", Slot = "10")]
	public void EINCGNKOKHI(NKMOLDEJHMN KJBGNDOMAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1F392A0", Offset = "0x1F380A0", VA = "0x181F392A0", Slot = "11")]
	public void DLJNCLPNNDD(JPBOKADKFJM OJIIPOMCHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1F38F50", Offset = "0x1F37D50", VA = "0x181F38F50", Slot = "12")]
	public void DLJNCLPNNDD(MJHNFFCHOAC HLDAFADKLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1F39D80", Offset = "0x1F38B80", VA = "0x181F39D80", Slot = "13")]
	public void FNMMNBGBEJC(JPBOKADKFJM OJIIPOMCHKP, KLMNKJONEDM LAKBKKJKBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1F39B90", Offset = "0x1F38990", VA = "0x181F39B90", Slot = "14")]
	public void FNMMNBGBEJC(MJHNFFCHOAC HLDAFADKLPI, KLMNKJONEDM LAKBKKJKBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1F39620", Offset = "0x1F38420", VA = "0x181F39620", Slot = "17")]
	public void ECPECALJJHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1F39A20", Offset = "0x1F38820", VA = "0x181F39A20", Slot = "15")]
	public void FEDIHMOMKPG(MJHNFFCHOAC HLDAFADKLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1F3A100", Offset = "0x1F38F00", VA = "0x181F3A100", Slot = "16")]
	public void INIBFNMJGOC(MJHNFFCHOAC HLDAFADKLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x802930", Offset = "0x801730", VA = "0x180802930", Slot = "18")]
	public void DOHPLLFIKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1F38420", Offset = "0x1F37220", VA = "0x181F38420", Slot = "19")]
	public void BNKAMCNOONN(KLMNKJONEDM LAKBKKJKBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1F38D00", Offset = "0x1F37B00", VA = "0x181F38D00")]
	private void CNDENJMDHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F39F40", Offset = "0x1F38D40", VA = "0x181F39F40")]
	public void FNMMNBGBEJC(MJHNFFCHOAC HLDAFADKLPI, KLMNKJONEDM LAKBKKJKBPK, bool COJJLGPPMOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1F39AC0", Offset = "0x1F388C0", VA = "0x181F39AC0")]
	private void FLCCLLNNKHG(KLMNKJONEDM LAKBKKJKBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1F38560", Offset = "0x1F37360", VA = "0x181F38560", Slot = "20")]
	public void CIKFMLGOJEJ(JPBOKADKFJM OJIIPOMCHKP, Vector3 KANAAFAOPPH, Vector3 INGBAALBIKG, Vector3 GPMFLLHAFGD, float OBCDEIDHACD, float GIOECMJJMAK, IReadOnlyList<Camera> NGBPIMEPCCO, GLENBAPBFIN EIOKBGLOKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1F388E0", Offset = "0x1F376E0", VA = "0x181F388E0", Slot = "21")]
	public void CIKFMLGOJEJ(IPOAFPICKLN NFMBFLAOHOA, Vector3 KANAAFAOPPH, Vector3 INGBAALBIKG, Vector3 GPMFLLHAFGD, float OBCDEIDHACD, float GIOECMJJMAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class JHEDIKNJHPE : MPDNMBEGDAL, IDDBHMGDLJB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly PJHOMEBHNCK FPNNOFOGMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	protected Bounds DDHPKFKOPLE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds DJBIMNIELFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1F3F710", Offset = "0x1F3E510", VA = "0x181F3F710", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual FIDFOPFECGN OKGOANNPGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1F3F800", Offset = "0x1F3E600", VA = "0x181F3F800", Slot = "12")]
		get
		{
			return default(FIDFOPFECGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA10", Offset = "0x8AE810", VA = "0x1808AFA10")]
	protected JHEDIKNJHPE(PJHOMEBHNCK OJIIPOMCHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F3F730", Offset = "0x1F3E530", VA = "0x181F3F730", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E5BE0", Offset = "0x6E49E0", VA = "0x1806E5BE0", Slot = "11")]
	public virtual bool GKOJJFHJMCO(IBPFMLOPCID OJIIPOMCHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int AGMFOKIDCFO(MHLJBECPMPN EFELDHJGAJI);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int IBMGIADIMLK(MHLJBECPMPN EFELDHJGAJI);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void KDJPMBCHDIP(MHLJBECPMPN EFELDHJGAJI, FFPHKBAPEFF LCAIFILALOH, int BMJIKBCENDE = -1);
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
		[Cpp2IlInjected.Address(RVA = "0x1F440E0", Offset = "0x1F42EE0", VA = "0x181F440E0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum EPPDJLOPCHC
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
public static class IKFDGNLPGLF
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MLDJGIGDDJJ : IEnumerable<KHFAACEDNMB>, IEnumerable, IEnumerator<KHFAACEDNMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private KHFAACEDNMB <>2__current;

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
		private KHFAACEDNMB System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC10", Offset = "0x8EEA10", VA = "0x1808EFC10")]
		[DebuggerHidden]
		public MLDJGIGDDJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1F3FBB0", Offset = "0x1F3E9B0", VA = "0x181F3FBB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1F3FD20", Offset = "0x1F3EB20", VA = "0x181F3FD20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1F3FC90", Offset = "0x1F3EA90", VA = "0x181F3FC90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KHFAACEDNMB> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1F3FC90", Offset = "0x1F3EA90", VA = "0x181F3FC90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int OMAMKCDMMND = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static KHFAACEDNMB[][] BHOOIOFHAMK;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static HMMJLHPFCMI KIGDEKOKHJE;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static ShapeRendererConfig PLJEBCECCMI;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader MFHLFKADDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1F3F1D0", Offset = "0x1F3DFD0", VA = "0x181F3F1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer NHCDBDLGPCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E950", Offset = "0x1F3D750", VA = "0x181F3E950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E720", Offset = "0x1F3D520", VA = "0x181F3E720")]
	public static Mesh CLJHHKOIKFF(EPPDJLOPCHC PFGBJGHEHMB, int EFELDHJGAJI = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E7E0", Offset = "0x1F3D5E0", VA = "0x181F3E7E0")]
	public static int CPAMBGBFIHL(EPPDJLOPCHC PFGBJGHEHMB, int EFELDHJGAJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E7F0", Offset = "0x1F3D5F0", VA = "0x181F3E7F0")]
	public static HMMJLHPFCMI EGEGDAGHJMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E9C0", Offset = "0x1F3D7C0", VA = "0x181F3E9C0")]
	[IteratorStateMachine(typeof(MLDJGIGDDJJ))]
	private static IEnumerable<KHFAACEDNMB> JCNIIIAHEMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1F3F240", Offset = "0x1F3E040", VA = "0x181F3F240")]
	public static KHFAACEDNMB OGLJBHKDKFL(EPPDJLOPCHC PFGBJGHEHMB, int EFELDHJGAJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F3F1B0", Offset = "0x1F3DFB0", VA = "0x181F3F1B0")]
	public static bool KLNPAKANNLP(this EPPDJLOPCHC PFGBJGHEHMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F3EC40", Offset = "0x1F3DA40", VA = "0x181F3EC40")]
	public static void JOKEBENJFIE(EPPDJLOPCHC PFGBJGHEHMB, float3 KBNEDGJGILF, out DPBLDKABEAH NCAHJIHKLDM, out float3 HIOOCPEAHGA, out float HLOPPLKJOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F3EDF0", Offset = "0x1F3DBF0", VA = "0x181F3EDF0")]
	public static void KDOIAFAHKMN(Vector3 KBNEDGJGILF, EPPDJLOPCHC PFGBJGHEHMB, out Vector3 HIOOCPEAHGA, out float HLOPPLKJOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F3F1A0", Offset = "0x1F3DFA0", VA = "0x181F3F1A0")]
	[PHHAPANKJKM(AJLNLJAJGIO.ExitingPlayMode, 0)]
	private static void KJPAMLMGHPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F3EA20", Offset = "0x1F3D820", VA = "0x181F3EA20")]
	[PHHAPANKJKM(AJLNLJAJGIO.ExitingPlayMode, 0)]
	private static void JDFHJONKBCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GLMHIJCACCE
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool AOLAKGBHHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material CBFELOGNLIE();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material NCODKKBGIMA();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material DPEOGOHLJAN();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NPKEEFNNMKO(CBCOJFBBCBN NHHMOGAOJKC);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CELGJCBGJGO(LEOIFFHCOFE NFBAEAFFCOI);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GADGEBNOADC(GameObject LOPIEGGIDMF);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LGDFMCMBDDP(GameObject LOPIEGGIDMF, bool JCJNAALBBMB);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface DEHDDCJLCAC
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	PJHOMEBHNCK BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	JHEDIKNJHPE BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OIGMJKALGLF BADELHLICNG
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
	[KNPMBINOPIG(MLNJOBCAIAM.ShapeRendering)]
	public class ShapeRendererManager : FNLNKGOIDCC, IDisposable, DEHDDCJLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly global::ABEGEKCKNMO<JPBOKADKFJM, PJHOMEBHNCK> CLJCMNJBJPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly global::ABEGEKCKNMO<MJHNFFCHOAC, JHEDIKNJHPE> PGGIKKNEIMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly global::ABEGEKCKNMO<IPOAFPICKLN, OIGMJKALGLF> BKHIEKDAHAA;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static GLMHIJCACCE AKLGDPAOEMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1F44720", Offset = "0x1F43520", VA = "0x181F44720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1F44F40", Offset = "0x1F43D40", VA = "0x181F44F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public PJHOMEBHNCK BADELHLICNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F44DC0", Offset = "0x1F43BC0", VA = "0x181F44DC0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public JHEDIKNJHPE BADELHLICNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x1F44E80", Offset = "0x1F43C80", VA = "0x181F44E80", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public OIGMJKALGLF BADELHLICNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x1F44E20", Offset = "0x1F43C20", VA = "0x181F44E20", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1F45000", Offset = "0x1F43E00", VA = "0x181F45000")]
		public ShapeRendererManager(GLMHIJCACCE HKOMEKNDPHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1F441A0", Offset = "0x1F42FA0", VA = "0x181F441A0", Slot = "16")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1F44C60", Offset = "0x1F43A60", VA = "0x181F44C60", Slot = "4")]
		public JPBOKADKFJM MIKAIDFLLDE(IKHCGABOAIN CPLKBCGCHAN)
		{
			return default(JPBOKADKFJM);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1F44EE0", Offset = "0x1F43CE0", VA = "0x181F44EE0", Slot = "5")]
		public void PADPFJPCEKJ(JPBOKADKFJM OJIIPOMCHKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1F44230", Offset = "0x1F43030", VA = "0x181F44230", Slot = "6")]
		public void EEGJGHHOGCF(JPBOKADKFJM OJIIPOMCHKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1F44780", Offset = "0x1F43580", VA = "0x181F44780", Slot = "7")]
		public MJHNFFCHOAC JMLOGJKHBMM(JPBOKADKFJM OJIIPOMCHKP, COLEOEKFNAK CPLKBCGCHAN)
		{
			return default(MJHNFFCHOAC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F44AF0", Offset = "0x1F438F0", VA = "0x181F44AF0", Slot = "8")]
		public MJHNFFCHOAC KODCNDPBEKN(JPBOKADKFJM OJIIPOMCHKP, ODPHKIJMLNH CPLKBCGCHAN)
		{
			return default(MJHNFFCHOAC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1F44110", Offset = "0x1F42F10", VA = "0x181F44110", Slot = "10")]
		public void BNHEDGFKABF(MJHNFFCHOAC HLDAFADKLPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1F44C00", Offset = "0x1F43A00", VA = "0x181F44C00", Slot = "9")]
		public void LGEGIIOKAGC(MJHNFFCHOAC HLDAFADKLPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1F44890", Offset = "0x1F43690", VA = "0x181F44890", Slot = "15")]
		public IEnumerable<Renderer> JPDBCLEHLAL(JPBOKADKFJM OJIIPOMCHKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1F44950", Offset = "0x1F43750", VA = "0x181F44950", Slot = "11")]
		public IPOAFPICKLN KIOFHCEPIIH(KCLBONLGPIH CPLKBCGCHAN)
		{
			return default(IPOAFPICKLN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1F446B0", Offset = "0x1F434B0", VA = "0x181F446B0", Slot = "13")]
		public void HGKPEFEOLKM(IPOAFPICKLN NFMBFLAOHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1F44D60", Offset = "0x1F43B60", VA = "0x181F44D60", Slot = "12")]
		public void MLFBHOOMBJO(IPOAFPICKLN NFMBFLAOHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F442B0", Offset = "0x1F430B0", VA = "0x181F442B0", Slot = "14")]
		public IDNKHAOLAID FCPPAPENJNI(IBPFMLOPCID FPIDEAGFKEM, IEnumerable<MJHNFFCHOAC> PGGIKKNEIMD, int DJDLDBGIMJF)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OIGMJKALGLF : OJHGLMMOJBI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BECGJKMGKJP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public OIGMJKALGLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC10", Offset = "0x8EEA10", VA = "0x1808EFC10")]
		[DebuggerHidden]
		public BECGJKMGKJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1F3AB30", Offset = "0x1F39930", VA = "0x181F3AB30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1F3A850", Offset = "0x1F39650", VA = "0x181F3A850", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1F3ABB0", Offset = "0x1F399B0", VA = "0x181F3ABB0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1F3AAF0", Offset = "0x1F398F0", VA = "0x181F3AAF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1F3AA50", Offset = "0x1F39850", VA = "0x181F3AA50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1F3AA50", Offset = "0x1F39850", VA = "0x181F3AA50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly KCLBONLGPIH PMIIFJBELJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly DEHDDCJLCAC HDJKCKEKNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private FLAPAFIBENI IDCBCOEAKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private List<PBIJFMLLBIJ> PMBKKKLLMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private List<PBIJFMLLBIJ> MJENLEIBCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject MHHPLIJIEBE;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1F41050", Offset = "0x1F3FE50", VA = "0x181F41050")]
	public static OIGMJKALGLF GDFDJNGIKFK(KCLBONLGPIH CPLKBCGCHAN, DEHDDCJLCAC HDJKCKEKNLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F41940", Offset = "0x1F40740", VA = "0x181F41940")]
	private OIGMJKALGLF(KCLBONLGPIH CPLKBCGCHAN, DEHDDCJLCAC HDJKCKEKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1F41460", Offset = "0x1F40260", VA = "0x181F41460")]
	public void LFLAMKKDLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1F40390", Offset = "0x1F3F190", VA = "0x181F40390")]
	[IteratorStateMachine(typeof(BECGJKMGKJP))]
	public IEnumerable<Renderer> ANIBAEIENNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1F40400", Offset = "0x1F3F200", VA = "0x181F40400", Slot = "4")]
	public void BNJIKEMPMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1F40FB0", Offset = "0x1F3FDB0", VA = "0x181F40FB0")]
	private void GBCOBPMAMHJ(Vector3 PGFPOLGNKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1F411C0", Offset = "0x1F3FFC0", VA = "0x181F411C0")]
	public void KMEGEMCDFBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class PBIJFMLLBIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct OLMDGJDBLDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public FFPHKBAPEFF FJBDIDAFJAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public IBPFMLOPCID DNELDMPMNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int ILGGBNFALDK;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class IKDJANOINLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public PBIJFMLLBIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public MHLJBECPMPN lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<OLMDGJDBLDK> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public IDNKHAOLAID combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public IKDJANOINLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E540", Offset = "0x1F3D340", VA = "0x181F3E540")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E5A0", Offset = "0x1F3D3A0", VA = "0x181F3E5A0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E5D0", Offset = "0x1F3D3D0", VA = "0x181F3E5D0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int[] NNJLDMGECOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private NFABICILGEG PEDDFKOCDIH;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static Matrix4x4 PJHDNBAMLNJ;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh CDCLNBIOOFC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F00", Offset = "0x6E5D00", VA = "0x1806E6F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int JGBJHBFDPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x770E30", Offset = "0x76FC30", VA = "0x180770E30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x804EF0", Offset = "0x803CF0", VA = "0x180804EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1F41E20", Offset = "0x1F40C20", VA = "0x181F41E20")]
	public void CKFBHJKNENG(List<IBPFMLOPCID> LCHPDJNBJMA, Matrix4x4[] IGFFAFFJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1F42050", Offset = "0x1F40E50", VA = "0x181F42050")]
	public static List<PBIJFMLLBIJ> DIMOBFAICBM(List<PJHOMEBHNCK> BLMBBCGHDLO, MHLJBECPMPN EFELDHJGAJI, Bounds EIJJIFHMJFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1F41A40", Offset = "0x1F40840", VA = "0x181F41A40")]
	private JobHandle CADEBMOPDEP(IDNKHAOLAID INBIPAHLOOO, int NEDALCMKNNP, int IAGJOCBDLGC, MHLJBECPMPN EFELDHJGAJI, List<OLMDGJDBLDK> HBDAODCJMON)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x1F42710", Offset = "0x1F41510", VA = "0x181F42710")]
	private void KPCOPJCIMGP(List<OLMDGJDBLDK> HBDAODCJMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1F42950", Offset = "0x1F41750", VA = "0x181F42950")]
	private PBIJFMLLBIJ(List<OLMDGJDBLDK> HBDAODCJMON, int NEDALCMKNNP, int IAGJOCBDLGC, MHLJBECPMPN EFELDHJGAJI, Bounds EIJJIFHMJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1F42680", Offset = "0x1F41480", VA = "0x181F42680", Slot = "4")]
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
		private MaterialPropertyBlock PPHBGMIEBCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private PBIJFMLLBIJ KMIFLOHLDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<IBPFMLOPCID> GKGMCKIADEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private RenderTexture MJFIJEOEJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private ComputeBuffer HCBCIOFIKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private ComputeShader MPCDELJKHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Matrix4x4[] NHAPCCECGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private int EKJJNNPDGND;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer ABJKEMEMDEN
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7011D0", Offset = "0x6FFFD0", VA = "0x1807011D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int POFILPBHMKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x1F46230", Offset = "0x1F45030", VA = "0x181F46230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1F45760", Offset = "0x1F44560", VA = "0x181F45760")]
		public static List<SkinnedShapeRenderer> Create(GameObject OJIIPOMCHKP, List<PBIJFMLLBIJ> GJCOBOCCCLC, List<IBPFMLOPCID> GKGMCKIADEJ, Material FCLHIFDODHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1F459B0", Offset = "0x1F447B0", VA = "0x181F459B0")]
		public void Init(PBIJFMLLBIJ KMIFLOHLDEH, List<IBPFMLOPCID> GKGMCKIADEJ, Material FCLHIFDODHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1F46180", Offset = "0x1F44F80", VA = "0x181F46180")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1F460D0", Offset = "0x1F44ED0", VA = "0x181F460D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1F46090", Offset = "0x1F44E90", VA = "0x181F46090")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1F45E60", Offset = "0x1F44C60", VA = "0x181F45E60")]
		private void NNINNELMJGK(ScriptableRenderContext IEGGGFEMEIG, Camera[] ELOJKNNKGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1F455A0", Offset = "0x1F443A0", VA = "0x181F455A0")]
		private void CKFBHJKNENG(CommandBuffer NCLPBGBLJFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	internal class _RRAssemblyIndex : IFFEHGABMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1F46360", Offset = "0x1F45160", VA = "0x181F46360", Slot = "4")]
		public sealed override void EAJHEFOPBGE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1F400B0", Offset = "0x1F3EEB0", VA = "0x181F400B0")]
	private static string NEFLGCBJNIO(byte[] BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1F3FD60", Offset = "0x1F3EB60", VA = "0x181F3FD60")]
	public static string BMCDLAKFGCG(byte[] GACPBGKAIDC, bool DFCFJJAKINH)
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
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
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
