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
public enum JLHLKDMLBPK
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
public static class MKKJGHOJDMO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x58273D0", Offset = "0x58265D0", VA = "0x1858273D0")]
	public static bool ENLHJMCHFGH(this JLHLKDMLBPK JGFCLDGKBAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x58273C0", Offset = "0x58265C0", VA = "0x1858273C0")]
	public static bool DLEIHAOGPJN(this JLHLKDMLBPK JGFCLDGKBAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x58273F0", Offset = "0x58265F0", VA = "0x1858273F0")]
	public static bool GLEEOMNIPEE(this JLHLKDMLBPK JGFCLDGKBAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MJGMBIJIKFH
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
public enum HGILLFNKECL
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
public enum LMKFOACECEG
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
public enum PPKCAMHKMLL
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
public class IMFGPJFNFDF : NOBPGLFLPBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte KGDIDCKPCPA = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte FAICMIFNGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] KPBFGIFOHDO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JKJLPHCNKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FB720", Offset = "0x6FA920", VA = "0x1806FB720", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4A0", Offset = "0x6FA6A0", VA = "0x1806FB4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GOIGICDGBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x827270", Offset = "0x826470", VA = "0x180827270", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE40", Offset = "0xB9A040", VA = "0x180B9AE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float JIECGLMGGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x975470", Offset = "0x974670", VA = "0x180975470", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xEC6450", Offset = "0xEC5650", VA = "0x180EC6450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float OINKAKMPAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCC7F00", Offset = "0xCC7100", VA = "0x180CC7F00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCC7F90", Offset = "0xCC7190", VA = "0x180CC7F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> BFOLDJLPKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5824060", Offset = "0x5823260", VA = "0x185824060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> ELOIDGMIEAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5823CF0", Offset = "0x5822EF0", VA = "0x185823CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject CFHDLGEGDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B43F0", Offset = "0x7B35F0", VA = "0x1807B43F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte DEHICILLBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5824010", Offset = "0x5823210", VA = "0x185824010", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5824250", Offset = "0x5823450", VA = "0x185824250")]
	public IMFGPJFNFDF(List<LOIHCKHKAGJ> IMAJMHFGLIL, List<LOIHCKHKAGJ> GCPOLJDPJFM, List<NCANNFMMHDJ> BLBKONLFICB, Material PMPDPBDKGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5823F00", Offset = "0x5823100", VA = "0x185823F00")]
	private int KDFNJKEIKLH(List<LOIHCKHKAGJ> OCBLEIOLAGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5824100", Offset = "0x5823300", VA = "0x185824100")]
	private void MNMEPBALGNJ(int JDAOPAAEIGA, bool FBHDABEFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5823E60", Offset = "0x5823060", VA = "0x185823E60")]
	public void GNMEDPDKAAH(Vector3 AHFDHJEGKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5823D30", Offset = "0x5822F30", VA = "0x185823D30", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x58240C0", Offset = "0x58232C0", VA = "0x1858240C0")]
	public void MLPGONLGIDE(Transform IIPJBKNHCJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JPNEHBHNENF : OFEBMEHKFCL, FOOHGKPDIJI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class ALIPMPEEFGE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JPNEHBHNENF <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x873910", Offset = "0x872B10", VA = "0x180873910")]
		[DebuggerHidden]
		public ALIPMPEEFGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x581AD30", Offset = "0x5819F30", VA = "0x18581AD30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x581A800", Offset = "0x5819A00", VA = "0x18581A800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x581AE30", Offset = "0x581A030", VA = "0x18581AE30")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x581AE80", Offset = "0x581A080", VA = "0x18581AE80")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x581AED0", Offset = "0x581A0D0", VA = "0x18581AED0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x581ACF0", Offset = "0x5819EF0", VA = "0x18581ACF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x581AC50", Offset = "0x5819E50", VA = "0x18581AC50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x581AC50", Offset = "0x5819E50", VA = "0x18581AC50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OJIHOODPDLF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JPNEHBHNENF <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x873910", Offset = "0x872B10", VA = "0x180873910")]
		[DebuggerHidden]
		public OJIHOODPDLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x58281C0", Offset = "0x58273C0", VA = "0x1858281C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5827E00", Offset = "0x5827000", VA = "0x185827E00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x58282A0", Offset = "0x58274A0", VA = "0x1858282A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x58282F0", Offset = "0x58274F0", VA = "0x1858282F0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5828180", Offset = "0x5827380", VA = "0x185828180", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x58280E0", Offset = "0x58272E0", VA = "0x1858280E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x58280E0", Offset = "0x58272E0", VA = "0x1858280E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly PBDPGFFMMPF IMDAGNMLCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<EOJEFCLFNIB> IHLJHIFFNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> EEMNOOPOGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer GINNJCPJICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool EHPJGLODCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool DFAEONGAEDD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<LPABJIKDONC> KCHNPMODJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NEFODMNJHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x58259B0", Offset = "0x5824BB0", VA = "0x1858259B0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NCANNFMMHDJ JLBNELNPGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5825010", Offset = "0x5824210", VA = "0x185825010", Slot = "7")]
		get
		{
			return default(NCANNFMMHDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> NHBLADLHPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x814E40", Offset = "0x814040", VA = "0x180814E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x58257D0", Offset = "0x58249D0", VA = "0x1858257D0")]
	private bool JBDACEGEFMI(EOJEFCLFNIB NBGOLMPJOHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5824E40", Offset = "0x5824040", VA = "0x185824E40")]
	private static bool CFAOMIPLFIA(EOJEFCLFNIB NBGOLMPJOHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5825CF0", Offset = "0x5824EF0", VA = "0x185825CF0")]
	public JPNEHBHNENF(PBDPGFFMMPF PCPEJHIMHJJ, bool HMLJEEKDHOE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x58250E0", Offset = "0x58242E0", VA = "0x1858250E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5824E60", Offset = "0x5824060", VA = "0x185824E60")]
	public void CPCILMEHKPA(EOJEFCLFNIB NBGOLMPJOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5825880", Offset = "0x5824A80", VA = "0x185825880")]
	public void MILDLLFOGOM(EOJEFCLFNIB NBGOLMPJOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5824610", Offset = "0x5823810", VA = "0x185824610", Slot = "4")]
	public void AEDDFPKFNHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5824BF0", Offset = "0x5823DF0", VA = "0x185824BF0")]
	public void CDJHKCNAIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x58259F0", Offset = "0x5824BF0", VA = "0x1858259F0")]
	private void PHFDMAFHEFJ(List<EOJEFCLFNIB> IHLJHIFFNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x581B0C0", Offset = "0x581A2C0", VA = "0x18581B0C0")]
	private static Material FILPMLFEMFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5825B80", Offset = "0x5824D80", VA = "0x185825B80")]
	private void PHFDMAFHEFJ(EOJEFCLFNIB NBGOLMPJOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5825C20", Offset = "0x5824E20", VA = "0x185825C20")]
	private void PNOCFDNEPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x58252B0", Offset = "0x58244B0", VA = "0x1858252B0")]
	public void IPFABAIGKEC(bool MFBIHOPNNIA, bool AGEEFMHOFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x58257F0", Offset = "0x58249F0", VA = "0x1858257F0")]
	protected void KKDJBGHBLGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5824B80", Offset = "0x5823D80", VA = "0x185824B80")]
	[IteratorStateMachine(typeof(ALIPMPEEFGE))]
	public IEnumerable<Renderer> CDGLEPOMJBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5825240", Offset = "0x5824440", VA = "0x185825240")]
	[IteratorStateMachine(typeof(OJIHOODPDLF))]
	public IEnumerable<Renderer> GMIGFKIKKGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class FNDIGINKKLL : EOJEFCLFNIB
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private struct EOIDOGONFDP : NJEDFBECIAA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private HHEDHPOIFFL AAKOJGEOGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private JobHandle KBGHJIGDKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private KLNDJIBJOLF CFNLJNHODOG;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5820CB0", Offset = "0x581FEB0", VA = "0x185820CB0")]
		public EOIDOGONFDP(HHEDHPOIFFL AAKOJGEOGGC, JobHandle KBGHJIGDKDL, KLNDJIBJOLF CFNLJNHODOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xB42B00", Offset = "0xB41D00", VA = "0x180B42B00")]
		public bool OEPEEFKGKGF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5820C30", Offset = "0x581FE30", VA = "0x185820C30", Slot = "4")]
		public HHEDHPOIFFL ANFOOJOGONB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5820C60", Offset = "0x581FE60", VA = "0x185820C60", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly KJIDJIBAPJP PPDEODGNACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private float FMMFPFDDAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Hash128 MONOIKNAJOK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 DEOHCCLBAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5820F30", Offset = "0x5820130", VA = "0x185820F30", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5822670", Offset = "0x5821870", VA = "0x185822670")]
	public FNDIGINKKLL(JPNEHBHNENF KPDGHDGLMHO, KJIDJIBAPJP PCPEJHIMHJJ, bool HMLJEEKDHOE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "16")]
	public override bool FAOBBLADJHH(NCANNFMMHDJ KPDGHDGLMHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5822480", Offset = "0x5821680", VA = "0x185822480", Slot = "18")]
	public override int KDFNJKEIKLH(AALGJAMKLGC EMMLNOGJBFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5822290", Offset = "0x5821490", VA = "0x185822290", Slot = "19")]
	public override int JNAHFPAOIEG(AALGJAMKLGC EMMLNOGJBFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5821AE0", Offset = "0x5820CE0", VA = "0x185821AE0", Slot = "20")]
	public override void HNOKHEFCDBM(AALGJAMKLGC EMMLNOGJBFM, MMJCAEIIBHK LDMIAAGFHOD, int MALCMIEOCBE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x58221C0", Offset = "0x58213C0", VA = "0x1858221C0", Slot = "21")]
	public override NCANNFMMHDJ IPMPHFIAIJC()
	{
		return default(NCANNFMMHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5821920", Offset = "0x5820B20", VA = "0x185821920", Slot = "23")]
	public override DNBBPLLNHIA HFJHLPIPLLA()
	{
		return default(DNBBPLLNHIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5821060", Offset = "0x5820260", VA = "0x185821060", Slot = "24")]
	public override NJEDFBECIAA GJBPHJHHPMG(AALGJAMKLGC EMMLNOGJBFM, JobHandle KBGHJIGDKDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct MDAFPBCOHEN : global::ECNPNPKOHHG<MDAFPBCOHEN>, ONMCCIDPEOK, IEquatable<MDAFPBCOHEN>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int BCGMDEIHEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x865EA0", Offset = "0x8650A0", VA = "0x180865EA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	[CreateProperty]
	public int OLGKJALIAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x18C79E0", Offset = "0x18C6BE0", VA = "0x1818C79E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x18C7A20", Offset = "0x18C6C20", VA = "0x1818C7A20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool PJAJGNFHPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5827260", Offset = "0x5826460", VA = "0x185827260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x22FC980", Offset = "0x22FBB80", VA = "0x1822FC980", Slot = "8")]
	public bool Equals(MDAFPBCOHEN HNPEBINPOBO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1152FF0", Offset = "0x11521F0", VA = "0x181152FF0")]
	public static bool IGOCGGBJBII(MDAFPBCOHEN NNMPJECKECI, MDAFPBCOHEN EFNJCAIBDLA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4A27E10", Offset = "0x4A27010", VA = "0x184A27E10")]
	public static bool BHBKJCPJNJN(MDAFPBCOHEN NNMPJECKECI, MDAFPBCOHEN EFNJCAIBDLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x58272A0", Offset = "0x58264A0", VA = "0x1858272A0", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5827330", Offset = "0x5826530", VA = "0x185827330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum EEJKGDBGCCI
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
public interface PBDPGFFMMPF
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	NCANNFMMHDJ DHGHIDOLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	EEJKGDBGCCI ICMOKDAEGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KEMJGOAMALL : global::ECNPNPKOHHG<KEMJGOAMALL>, ONMCCIDPEOK, IEquatable<KEMJGOAMALL>
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int BCGMDEIHEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x865EA0", Offset = "0x8650A0", VA = "0x180865EA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	[CreateProperty]
	public int OLGKJALIAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x18C79E0", Offset = "0x18C6BE0", VA = "0x1818C79E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x18C7A20", Offset = "0x18C6C20", VA = "0x1818C7A20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool PJAJGNFHPGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5825DE0", Offset = "0x5824FE0", VA = "0x185825DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x22FC980", Offset = "0x22FBB80", VA = "0x1822FC980", Slot = "8")]
	public bool Equals(KEMJGOAMALL HNPEBINPOBO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1152FF0", Offset = "0x11521F0", VA = "0x181152FF0")]
	public static bool IGOCGGBJBII(KEMJGOAMALL NNMPJECKECI, KEMJGOAMALL EFNJCAIBDLA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4A27E10", Offset = "0x4A27010", VA = "0x184A27E10")]
	public static bool BHBKJCPJNJN(KEMJGOAMALL NNMPJECKECI, KEMJGOAMALL EFNJCAIBDLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5825E20", Offset = "0x5825020", VA = "0x185825E20", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5825EB0", Offset = "0x58250B0", VA = "0x185825EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AIJBBHFFACK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JMFOGHHPOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool OABGMLFLFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	NCANNFMMHDJ DHGHIDOLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float IBPLKHGDLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 JCOMNCFCBKA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	JLHLKDMLBPK AMPGIIDMALC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	MJGMBIJIKFH NHPDOMIOODD
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
public interface IFLALHAKIBA : AIJBBHFFACK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	OPIHLMHICGM OBFLIFIOMKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool KPNHDIKCELP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KJIDJIBAPJP : AIJBBHFFACK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool EHPJDEDLIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NBPIFMAHMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	float HJDELCHHGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int KBPJJIGLDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool MCIPIEPFNJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int FEHFLCHIDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<EMHDJKIGAGH> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PLKCJIPEDIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCDJHCNFAKO(MDAFPBCOHEN KPDGHDGLMHO, LMKFOACECEG IEMMIFODLAI);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCDJHCNFAKO(KEMJGOAMALL NBGOLMPJOHO, LMKFOACECEG IEMMIFODLAI);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENFAFBLBFDD(KEMJGOAMALL NBGOLMPJOHO);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKFLPGCJACE(KEMJGOAMALL NBGOLMPJOHO);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AFOLJNGDOHG();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGCHFCMBFKD();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EGJOELBOCNE(LMKFOACECEG NIFOGEBEDNG);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MAAKJABOLMJ(MDAFPBCOHEN KPDGHDGLMHO);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MAAKJABOLMJ(KEMJGOAMALL NBGOLMPJOHO);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GCKEDODOPMP(MDAFPBCOHEN KPDGHDGLMHO, PPKCAMHKMLL NIFOGEBEDNG);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GCKEDODOPMP(KEMJGOAMALL NBGOLMPJOHO, PPKCAMHKMLL NIFOGEBEDNG);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NJLINEOCAJC(KEMJGOAMALL NBGOLMPJOHO);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NNFBAHDEPCI(KEMJGOAMALL NBGOLMPJOHO);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EICLEFKEKGI();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BOGCEIFGFFP();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OAANHIMENAK(PPKCAMHKMLL NIFOGEBEDNG);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KJKJCOJMFLI(MDAFPBCOHEN KPDGHDGLMHO, Vector3 JOFBEGDENCK, Vector3 KGHKNCFKKMB, Vector3 OFKIOHHAEAC, float HNBOEPGMOJB, float EIGIKPJOLPF, IReadOnlyList<Camera> HFEBOPAJBLM, HGILLFNKECL MDILDPALOMC);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KJKJCOJMFLI(AMEFHJFMPIO BCDCKDKBNFP, Vector3 JOFBEGDENCK, Vector3 KGHKNCFKKMB, Vector3 OFKIOHHAEAC, float HNBOEPGMOJB, float EIGIKPJOLPF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public interface EMFALLMFGNA
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	JPNEHBHNENF POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	EOJEFCLFNIB POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	HKNPLOPDMCG POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AJPGDEKAKGN : EMFALLMFGNA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool EJMPMEKNMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MDAFPBCOHEN KAKHGFCFPJF(PBDPGFFMMPF PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MDAFPBCOHEN KAKHGFCFPJF(PBDPGFFMMPF PCPEJHIMHJJ, bool HJMIFAKDJHC);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDOEMAOMOJP(MDAFPBCOHEN KPDGHDGLMHO);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DLCMANLNGDI(MDAFPBCOHEN KPDGHDGLMHO);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KEMJGOAMALL AAIDPAMPIMK(MDAFPBCOHEN KPDGHDGLMHO, IFLALHAKIBA PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KEMJGOAMALL BPCLHMOOEOH(MDAFPBCOHEN KPDGHDGLMHO, KJIDJIBAPJP PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MABBADAOIEP(KEMJGOAMALL NBGOLMPJOHO);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LGAKMPLFDHM(KEMJGOAMALL NBGOLMPJOHO);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AMEFHJFMPIO LNOAMGAGHPI(BDLODHHJLKM PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ELNMJJJKEKJ(AMEFHJFMPIO BCDCKDKBNFP);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NAKBKBKDNCF(AMEFHJFMPIO BCDCKDKBNFP);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task EAMKMOENFBK();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task JNCAIECLLKB();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task JIKBLFOLHLG();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ANDGAJBFDAI();

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HHEDHPOIFFL DMPDDNLLNAH(NCANNFMMHDJ PFDJLJHJKAC, IEnumerable<KEMJGOAMALL> IHLJHIFFNPM, int PEFBLDIAEHF);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerable<Renderer> AILAELCODEG(MDAFPBCOHEN KPDGHDGLMHO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct AMEFHJFMPIO : global::ECNPNPKOHHG<AMEFHJFMPIO>, ONMCCIDPEOK, IEquatable<AMEFHJFMPIO>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int BCGMDEIHEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x865EA0", Offset = "0x8650A0", VA = "0x180865EA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int OLGKJALIAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x18C79E0", Offset = "0x18C6BE0", VA = "0x1818C79E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x18C7A20", Offset = "0x18C6C20", VA = "0x1818C7A20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool PJAJGNFHPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x581AF20", Offset = "0x581A120", VA = "0x18581AF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x22FC980", Offset = "0x22FBB80", VA = "0x1822FC980", Slot = "8")]
	public bool Equals(AMEFHJFMPIO HNPEBINPOBO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1152FF0", Offset = "0x11521F0", VA = "0x181152FF0")]
	public static bool IGOCGGBJBII(AMEFHJFMPIO NNMPJECKECI, AMEFHJFMPIO EFNJCAIBDLA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4A27E10", Offset = "0x4A27010", VA = "0x184A27E10")]
	public static bool BHBKJCPJNJN(AMEFHJFMPIO NNMPJECKECI, AMEFHJFMPIO EFNJCAIBDLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x581AF60", Offset = "0x581A160", VA = "0x18581AF60", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BDLODHHJLKM
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	int GJECGLAMFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Transform LJIAPAFHAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool BHOKKBGLLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MDAFPBCOHEN GetBone(int ODCMHGAKLKH);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int ODCMHGAKLKH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public class CJHGMEBINGI : AJPGDEKAKGN, EMFALLMFGNA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct EJGBGMGDIPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public CJHGMEBINGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5820790", Offset = "0x581F990", VA = "0x185820790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x87A5F0", Offset = "0x8797F0", VA = "0x18087A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly global::LCFJEOPKOJK<MDAFPBCOHEN, JPNEHBHNENF> AKOIOBGGCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly global::LCFJEOPKOJK<KEMJGOAMALL, EOJEFCLFNIB> IHLJHIFFNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly global::LCFJEOPKOJK<AMEFHJFMPIO, HKNPLOPDMCG> KOHNIJBPAFI;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public JPNEHBHNENF POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5820090", Offset = "0x581F290", VA = "0x185820090", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public EOJEFCLFNIB POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5820030", Offset = "0x581F230", VA = "0x185820030", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HKNPLOPDMCG POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x581FFD0", Offset = "0x581F1D0", VA = "0x18581FFD0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool EJMPMEKNMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAD84D0", Offset = "0xAD76D0", VA = "0x180AD84D0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7B00", VA = "0x180AD8900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x58200F0", Offset = "0x581F2F0", VA = "0x1858200F0")]
	public CJHGMEBINGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x581EFE0", Offset = "0x581E1E0", VA = "0x18581EFE0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x581F850", Offset = "0x581EA50", VA = "0x18581F850", Slot = "4")]
	public MDAFPBCOHEN KAKHGFCFPJF(PBDPGFFMMPF PCPEJHIMHJJ)
	{
		return default(MDAFPBCOHEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x581F5B0", Offset = "0x581E7B0", VA = "0x18581F5B0", Slot = "5")]
	public MDAFPBCOHEN KAKHGFCFPJF(PBDPGFFMMPF PCPEJHIMHJJ, bool HMLJEEKDHOE)
	{
		return default(MDAFPBCOHEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x581DE90", Offset = "0x581D090", VA = "0x18581DE90", Slot = "6")]
	public void BDOEMAOMOJP(MDAFPBCOHEN KPDGHDGLMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x581E620", Offset = "0x581D820", VA = "0x18581E620", Slot = "7")]
	public void DLCMANLNGDI(MDAFPBCOHEN KPDGHDGLMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x581D880", Offset = "0x581CA80", VA = "0x18581D880", Slot = "8")]
	public KEMJGOAMALL AAIDPAMPIMK(MDAFPBCOHEN KPDGHDGLMHO, IFLALHAKIBA PCPEJHIMHJJ)
	{
		return default(KEMJGOAMALL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x581E110", Offset = "0x581D310", VA = "0x18581E110", Slot = "9")]
	public KEMJGOAMALL BPCLHMOOEOH(MDAFPBCOHEN KPDGHDGLMHO, KJIDJIBAPJP PCPEJHIMHJJ)
	{
		return default(KEMJGOAMALL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x581F860", Offset = "0x581EA60", VA = "0x18581F860", Slot = "11")]
	public void LGAKMPLFDHM(KEMJGOAMALL NBGOLMPJOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x581FCE0", Offset = "0x581EEE0", VA = "0x18581FCE0", Slot = "10")]
	public void MABBADAOIEP(KEMJGOAMALL NBGOLMPJOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x581DD90", Offset = "0x581CF90", VA = "0x18581DD90", Slot = "21")]
	public IEnumerable<Renderer> AILAELCODEG(MDAFPBCOHEN KPDGHDGLMHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x581FC60", Offset = "0x581EE60", VA = "0x18581FC60", Slot = "12")]
	public AMEFHJFMPIO LNOAMGAGHPI(BDLODHHJLKM PCPEJHIMHJJ)
	{
		return default(AMEFHJFMPIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x581FF60", Offset = "0x581F160", VA = "0x18581FF60", Slot = "14")]
	public void NAKBKBKDNCF(AMEFHJFMPIO BCDCKDKBNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x581F180", Offset = "0x581E380", VA = "0x18581F180", Slot = "16")]
	public Task EAMKMOENFBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x581F450", Offset = "0x581E650", VA = "0x18581F450", Slot = "17")]
	public Task JNCAIECLLKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x581F350", Offset = "0x581E550", VA = "0x18581F350", Slot = "18")]
	[AsyncStateMachine(typeof(EJGBGMGDIPP))]
	public Task JIKBLFOLHLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x581DE00", Offset = "0x581D000", VA = "0x18581DE00", Slot = "19")]
	public void ANDGAJBFDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x581F2F0", Offset = "0x581E4F0", VA = "0x18581F2F0", Slot = "13")]
	public void ELNMJJJKEKJ(AMEFHJFMPIO BCDCKDKBNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x581E9B0", Offset = "0x581DBB0", VA = "0x18581E9B0", Slot = "20")]
	public HHEDHPOIFFL DMPDDNLLNAH(NCANNFMMHDJ GDHKDDJOENB, IEnumerable<KEMJGOAMALL> IHLJHIFFNPM, int PEFBLDIAEHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class PGHBGJCEIFD : EOJEFCLFNIB
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct PAFKIFBHMNP : NJEDFBECIAA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private HHEDHPOIFFL AAKOJGEOGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private JobHandle KBGHJIGDKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private LOACFOJNCBB CFNLJNHODOG;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x58283C0", Offset = "0x58275C0", VA = "0x1858283C0")]
		public PAFKIFBHMNP(HHEDHPOIFFL AAKOJGEOGGC, JobHandle KBGHJIGDKDL, LOACFOJNCBB CFNLJNHODOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xB42B00", Offset = "0xB41D00", VA = "0x180B42B00")]
		public bool OEPEEFKGKGF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5828340", Offset = "0x5827540", VA = "0x185828340", Slot = "4")]
		public HHEDHPOIFFL ANFOOJOGONB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5828370", Offset = "0x5827570", VA = "0x185828370", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly IFLALHAKIBA OOJPBADIODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int[] JCLMDGBDJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private float FMMFPFDDAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Hash128 MONOIKNAJOK;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override KDBLGDKADGC LKINBHOLEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x582A060", Offset = "0x5829260", VA = "0x18582A060", Slot = "17")]
		get
		{
			return default(KDBLGDKADGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private Vector3 FDPLPOABBEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5829D10", Offset = "0x5828F10", VA = "0x185829D10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected override Hash128 DEOHCCLBAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5828410", Offset = "0x5827610", VA = "0x185828410", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x582A6C0", Offset = "0x58298C0", VA = "0x18582A6C0")]
	public PGHBGJCEIFD(JPNEHBHNENF KPDGHDGLMHO, IFLALHAKIBA PCPEJHIMHJJ, bool GOJONHGKLOD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5828540", Offset = "0x5827740", VA = "0x185828540", Slot = "16")]
	public override bool FAOBBLADJHH(NCANNFMMHDJ KPDGHDGLMHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5829C60", Offset = "0x5828E60", VA = "0x185829C60", Slot = "18")]
	public override int KDFNJKEIKLH(AALGJAMKLGC EMMLNOGJBFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5829BB0", Offset = "0x5828DB0", VA = "0x185829BB0", Slot = "19")]
	public override int JNAHFPAOIEG(AALGJAMKLGC EMMLNOGJBFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x582A410", Offset = "0x5829610", VA = "0x18582A410")]
	private int OILMEONFEKF(AALGJAMKLGC EMMLNOGJBFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5829370", Offset = "0x5828570", VA = "0x185829370", Slot = "20")]
	public override void HNOKHEFCDBM(AALGJAMKLGC EMMLNOGJBFM, MMJCAEIIBHK LDMIAAGFHOD, int MALCMIEOCBE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5829AE0", Offset = "0x5828CE0", VA = "0x185829AE0", Slot = "21")]
	public override NCANNFMMHDJ IPMPHFIAIJC()
	{
		return default(NCANNFMMHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x58291B0", Offset = "0x58283B0", VA = "0x1858291B0", Slot = "23")]
	public override DNBBPLLNHIA HFJHLPIPLLA()
	{
		return default(DNBBPLLNHIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x58289B0", Offset = "0x5827BB0", VA = "0x1858289B0", Slot = "24")]
	public override NJEDFBECIAA GJBPHJHHPMG(AALGJAMKLGC EMMLNOGJBFM, JobHandle KBGHJIGDKDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface PFAGKNDKBKO
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCFDNLJLHMC(PPKCAMHKMLL NIFOGEBEDNG, Renderer LPCBHIEOFOB, int FIKBGLGGDGP);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOHAGKGHAMM(Renderer LPCBHIEOFOB, HGILLFNKECL MDILDPALOMC, Vector3 JOFBEGDENCK, Vector3 KGHKNCFKKMB, Vector3 OFKIOHHAEAC, float HNBOEPGMOJB, float EIGIKPJOLPF, float DFGADKANOHD = -1f, [Optional] Color? HMCAFGCGFJF, [Optional] IReadOnlyList<Camera> GPODDNLCBNL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBBIBKAHDLH(Renderer LPCBHIEOFOB, int FIKBGLGGDGP);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GONCGMBBEMC();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIJJGLJJIAA(int NCCOJICAPLM, LMKFOACECEG NIFOGEBEDNG, Renderer LPCBHIEOFOB, int FIKBGLGGDGP);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BKEFBKEDFEO : PLKCJIPEDIM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class HMIIFKJKFOA : global::ACIAIMGPLGI<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5823CA0", Offset = "0x5822EA0", VA = "0x185823CA0")]
		public HMIIFKJKFOA(string KNOPFGAGMCN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly PFAGKNDKBKO JKNKNCPKDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly EMFALLMFGNA KPIGEEGAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MeshRenderer DPENEJOCIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private HMIIFKJKFOA FDHBBPJBFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool CFPENKCNODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MeshRenderer MFPAOBHEPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private HMIIFKJKFOA OOOGECICNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool HLJMAMDELMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private MeshRenderer HJPHIHEPHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private HMIIFKJKFOA EJHDLDGAMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool KBDIBPJIHNN;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7086F0", Offset = "0x7078F0", VA = "0x1807086F0")]
	public BKEFBKEDFEO(PFAGKNDKBKO JCIANALDNNO, EMFALLMFGNA KPIGEEGAKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x581B4A0", Offset = "0x581A6A0", VA = "0x18581B4A0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x581D3C0", Offset = "0x581C5C0", VA = "0x18581D3C0")]
	private void NAPOCBEGOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x581B950", Offset = "0x581AB50", VA = "0x18581B950", Slot = "4")]
	public void GCDJHCNFAKO(MDAFPBCOHEN KPDGHDGLMHO, LMKFOACECEG IEMMIFODLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x581BB50", Offset = "0x581AD50", VA = "0x18581BB50", Slot = "5")]
	public void GCDJHCNFAKO(KEMJGOAMALL NBGOLMPJOHO, LMKFOACECEG IEMMIFODLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x581B820", Offset = "0x581AA20", VA = "0x18581B820", Slot = "6")]
	public void ENFAFBLBFDD(KEMJGOAMALL NBGOLMPJOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x581CA80", Offset = "0x581BC80", VA = "0x18581CA80", Slot = "7")]
	public void KKFLPGCJACE(KEMJGOAMALL NBGOLMPJOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x581B460", Offset = "0x581A660", VA = "0x18581B460", Slot = "8")]
	public void AFOLJNGDOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xBFD7C0", Offset = "0xBFC9C0", VA = "0x180BFD7C0", Slot = "9")]
	public void EGCHFCMBFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x581B670", Offset = "0x581A870", VA = "0x18581B670", Slot = "10")]
	public void EGJOELBOCNE(LMKFOACECEG IEMMIFODLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x581CEC0", Offset = "0x581C0C0", VA = "0x18581CEC0", Slot = "11")]
	public void MAAKJABOLMJ(MDAFPBCOHEN KPDGHDGLMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x581D070", Offset = "0x581C270", VA = "0x18581D070", Slot = "12")]
	public void MAAKJABOLMJ(KEMJGOAMALL NBGOLMPJOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x581C120", Offset = "0x581B320", VA = "0x18581C120", Slot = "13")]
	public void GCKEDODOPMP(MDAFPBCOHEN KPDGHDGLMHO, PPKCAMHKMLL NIFOGEBEDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x581BD70", Offset = "0x581AF70", VA = "0x18581BD70", Slot = "14")]
	public void GCKEDODOPMP(KEMJGOAMALL NBGOLMPJOHO, PPKCAMHKMLL NIFOGEBEDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x581B7E0", Offset = "0x581A9E0", VA = "0x18581B7E0", Slot = "17")]
	public void EICLEFKEKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x581D610", Offset = "0x581C810", VA = "0x18581D610", Slot = "15")]
	public void NJLINEOCAJC(KEMJGOAMALL NBGOLMPJOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x581D6B0", Offset = "0x581C8B0", VA = "0x18581D6B0", Slot = "16")]
	public void NNFBAHDEPCI(KEMJGOAMALL NBGOLMPJOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x100CB00", Offset = "0x100BD00", VA = "0x18100CB00", Slot = "18")]
	public void BOGCEIFGFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x581D740", Offset = "0x581C940", VA = "0x18581D740", Slot = "19")]
	public void OAANHIMENAK(PPKCAMHKMLL NIFOGEBEDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x581CBA0", Offset = "0x581BDA0", VA = "0x18581CBA0")]
	private void KKKPCGLJMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x581BF60", Offset = "0x581B160", VA = "0x18581BF60")]
	public void GCKEDODOPMP(KEMJGOAMALL NBGOLMPJOHO, PPKCAMHKMLL NIFOGEBEDNG, bool DFIHINEPJBN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x581CDF0", Offset = "0x581BFF0", VA = "0x18581CDF0")]
	private void LCFDNLJLHMC(PPKCAMHKMLL NIFOGEBEDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x581C700", Offset = "0x581B900", VA = "0x18581C700", Slot = "20")]
	public void KJKJCOJMFLI(MDAFPBCOHEN KPDGHDGLMHO, Vector3 JOFBEGDENCK, Vector3 KGHKNCFKKMB, Vector3 OFKIOHHAEAC, float HNBOEPGMOJB, float EIGIKPJOLPF, IReadOnlyList<Camera> HFEBOPAJBLM, HGILLFNKECL MDILDPALOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x581C2E0", Offset = "0x581B4E0", VA = "0x18581C2E0", Slot = "21")]
	public void KJKJCOJMFLI(AMEFHJFMPIO BCDCKDKBNFP, Vector3 JOFBEGDENCK, Vector3 KGHKNCFKKMB, Vector3 OFKIOHHAEAC, float HNBOEPGMOJB, float EIGIKPJOLPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface ICJKFFECCMP
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool EILEHPKCHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material MFCNLPBPLMH();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material FILPMLFEMFD();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material JAEIBJDFJAC();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KADOAMKHALN(JLHLKDMLBPK JGFCLDGKBAO);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int GCNKFKDPHGN(MJGMBIJIKFH PLHDLMBFDHN);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void COMMNJGHNPO(GameObject ICHBECDKHOJ);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OBICAOLFLCM(GameObject ICHBECDKHOJ, bool PDLKBHIDLJN);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class ANLCFCDIKIG
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static ICJKFFECCMP IDCNELICAAG;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static bool EILEHPKCHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x581B400", Offset = "0x581A600", VA = "0x18581B400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x581B1F0", Offset = "0x581A3F0", VA = "0x18581B1F0")]
	public static void JOKEEOPJEAJ(ICJKFFECCMP JNHLKMBMPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x581B2B0", Offset = "0x581A4B0", VA = "0x18581B2B0")]
	public static Material MFCNLPBPLMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x581B0C0", Offset = "0x581A2C0", VA = "0x18581B0C0")]
	public static Material FILPMLFEMFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x581B190", Offset = "0x581A390", VA = "0x18581B190")]
	public static Material JAEIBJDFJAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x581B240", Offset = "0x581A440", VA = "0x18581B240")]
	public static int KADOAMKHALN(JLHLKDMLBPK JGFCLDGKBAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x581B120", Offset = "0x581A320", VA = "0x18581B120")]
	public static int GCNKFKDPHGN(MJGMBIJIKFH PLHDLMBFDHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x581AFF0", Offset = "0x581A1F0", VA = "0x18581AFF0")]
	public static void COMMNJGHNPO(GameObject ICHBECDKHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x581B310", Offset = "0x581A510", VA = "0x18581B310")]
	public static void OBICAOLFLCM(GameObject ICHBECDKHOJ, bool PDLKBHIDLJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class EOJEFCLFNIB : CLIMFANGAMH, LPABJIKDONC, MIALJFIBAAB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly JPNEHBHNENF CFHDLGEGDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected Bounds COPLOIFPKHL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Bounds OPAFFPMLMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9D1870", Offset = "0x9D0A70", VA = "0x1809D1870", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public virtual KDBLGDKADGC LKINBHOLEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5820EA0", Offset = "0x58200A0", VA = "0x185820EA0", Slot = "17")]
		get
		{
			return default(KDBLGDKADGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool DFAEONGAEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x96D880", Offset = "0x96CA80", VA = "0x18096D880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xEDA1C0", Offset = "0xED93C0", VA = "0x180EDA1C0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	protected abstract Hash128 DEOHCCLBAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int ECPELAMIKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7A7AA0", Offset = "0x7A6CA0", VA = "0x1807A7AA0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public JILKDMBCEHG AGKMHKBBAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x814E40", Offset = "0x814040", VA = "0x180814E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool BLMEMBJEHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9F0", Offset = "0x6FEBF0", VA = "0x1806FF9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	protected EOJEFCLFNIB(JPNEHBHNENF KPDGHDGLMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5820D40", Offset = "0x581FF40", VA = "0x185820D40", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "16")]
	public virtual bool FAOBBLADJHH(NCANNFMMHDJ KPDGHDGLMHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int KDFNJKEIKLH(AALGJAMKLGC EMMLNOGJBFM);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int JNAHFPAOIEG(AALGJAMKLGC EMMLNOGJBFM);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void HNOKHEFCDBM(AALGJAMKLGC EMMLNOGJBFM, MMJCAEIIBHK LDMIAAGFHOD, int MALCMIEOCBE = -1);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract NCANNFMMHDJ IPMPHFIAIJC();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5820E70", Offset = "0x5820070", VA = "0x185820E70", Slot = "11")]
	public Hash128 IGIIPHJGADD(int EMMLNOGJBFM)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract DNBBPLLNHIA HFJHLPIPLLA();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract NJEDFBECIAA GJBPHJHHPMG(AALGJAMKLGC EMMLNOGJBFM, JobHandle KBGHJIGDKDL);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5820D10", Offset = "0x581FF10", VA = "0x185820D10", Slot = "10")]
	public NJEDFBECIAA DMPDDNLLNAH(int EMMLNOGJBFM)
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
		[Cpp2IlInjected.Address(RVA = "0x582A770", Offset = "0x5829970", VA = "0x18582A770")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum OPIHLMHICGM
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
public static class AKKIIKCJICN
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class AADECLJMEOF : IEnumerable<PNJOGEKBEPN>, IEnumerable, IEnumerator<PNJOGEKBEPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private PNJOGEKBEPN <>2__current;

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
		private PNJOGEKBEPN System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x873910", Offset = "0x872B10", VA = "0x180873910")]
		[DebuggerHidden]
		public AADECLJMEOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5819730", Offset = "0x5818930", VA = "0x185819730", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x58198A0", Offset = "0x5818AA0", VA = "0x1858198A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5819810", Offset = "0x5818A10", VA = "0x185819810", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PNJOGEKBEPN> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5819810", Offset = "0x5818A10", VA = "0x185819810", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public const int BJFLDJOIECN = 3;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static PNJOGEKBEPN[][] HMKEJMEPFGK;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static JODKCFEDGJD EOEAJJEMAHM;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static ShapeRendererConfig DACBLCCBDPG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static ComputeShader FLEJLBPHFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5819FB0", Offset = "0x58191B0", VA = "0x185819FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static SkinnedShapeRenderer KDCOKIBADAC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5819C40", Offset = "0x5818E40", VA = "0x185819C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5819CB0", Offset = "0x5818EB0", VA = "0x185819CB0")]
	public static Mesh DBIHCLEIDBO(OPIHLMHICGM EILJFFFKPNI, int EMMLNOGJBFM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x581A030", Offset = "0x5819230", VA = "0x18581A030")]
	public static int LLPAKFJHBAB(OPIHLMHICGM EILJFFFKPNI, int EMMLNOGJBFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x581A040", Offset = "0x5819240", VA = "0x18581A040")]
	public static JODKCFEDGJD MOHFOCPKOLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x581A700", Offset = "0x5819900", VA = "0x18581A700")]
	[IteratorStateMachine(typeof(AADECLJMEOF))]
	private static IEnumerable<PNJOGEKBEPN> OOLIOGNIFJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x58198E0", Offset = "0x5818AE0", VA = "0x1858198E0")]
	public static PNJOGEKBEPN AMIFBJLNLGK(OPIHLMHICGM EILJFFFKPNI, int EMMLNOGJBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5819F90", Offset = "0x5819190", VA = "0x185819F90")]
	public static bool GCHEFAIPMOL(this OPIHLMHICGM EILJFFFKPNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x581A1A0", Offset = "0x58193A0", VA = "0x18581A1A0")]
	public static void NGIDLFNCJCC(OPIHLMHICGM EILJFFFKPNI, float3 DMIMHPJMEPO, out PDPMCPOHCAB MGKCOBIHMCM, out float3 CBEPHPIADBJ, out float CKLKLIGDAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x581A350", Offset = "0x5819550", VA = "0x18581A350")]
	public static void ONGAKIPMLCO(Vector3 DMIMHPJMEPO, OPIHLMHICGM EILJFFFKPNI, out Vector3 CBEPHPIADBJ, out float CKLKLIGDAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x581A020", Offset = "0x5819220", VA = "0x18581A020")]
	[HBJMIOFCGBI(OJDMGNCPNKA.ExitingPlayMode, 0)]
	private static void INMLFLDOIJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5819D70", Offset = "0x5818F70", VA = "0x185819D70")]
	[HBJMIOFCGBI(OJDMGNCPNKA.ExitingPlayMode, 0)]
	private static void DHGEHKMJLJK()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[DefaultMember("Item")]
	[CGDKNMKPKIP(OOBCCNCEGNI.ShapeRendering)]
	public class ShapeRendererManager : AJPGDEKAKGN, EMFALLMFGNA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly global::LCFJEOPKOJK<MDAFPBCOHEN, JPNEHBHNENF> AKOIOBGGCLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly global::LCFJEOPKOJK<KEMJGOAMALL, EOJEFCLFNIB> IHLJHIFFNPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly global::LCFJEOPKOJK<AMEFHJFMPIO, HKNPLOPDMCG> KOHNIJBPAFI;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public JPNEHBHNENF POFBPBHJKPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x582B470", Offset = "0x582A670", VA = "0x18582B470", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public EOJEFCLFNIB POFBPBHJKPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x582B4D0", Offset = "0x582A6D0", VA = "0x18582B4D0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public HKNPLOPDMCG POFBPBHJKPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x582B530", Offset = "0x582A730", VA = "0x18582B530", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool EJMPMEKNMGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAD84D0", Offset = "0xAD76D0", VA = "0x180AD84D0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7B00", VA = "0x180AD8900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x582B5E0", Offset = "0x582A7E0", VA = "0x18582B5E0")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x582AF70", Offset = "0x582A170", VA = "0x18582AF70", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x582B180", Offset = "0x582A380", VA = "0x18582B180", Slot = "4")]
		public MDAFPBCOHEN KAKHGFCFPJF(PBDPGFFMMPF PCPEJHIMHJJ)
		{
			return default(MDAFPBCOHEN);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x582B180", Offset = "0x582A380", VA = "0x18582B180", Slot = "5")]
		public MDAFPBCOHEN KAKHGFCFPJF(PBDPGFFMMPF PCPEJHIMHJJ, bool HMLJEEKDHOE)
		{
			return default(MDAFPBCOHEN);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x582A950", Offset = "0x5829B50", VA = "0x18582A950", Slot = "6")]
		public void BDOEMAOMOJP(MDAFPBCOHEN KPDGHDGLMHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x582AAF0", Offset = "0x5829CF0", VA = "0x18582AAF0", Slot = "7")]
		public void DLCMANLNGDI(MDAFPBCOHEN KPDGHDGLMHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x582A7A0", Offset = "0x58299A0", VA = "0x18582A7A0", Slot = "8")]
		public KEMJGOAMALL AAIDPAMPIMK(MDAFPBCOHEN KPDGHDGLMHO, IFLALHAKIBA PCPEJHIMHJJ)
		{
			return default(KEMJGOAMALL);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x582A9B0", Offset = "0x5829BB0", VA = "0x18582A9B0", Slot = "9")]
		public KEMJGOAMALL BPCLHMOOEOH(MDAFPBCOHEN KPDGHDGLMHO, KJIDJIBAPJP PCPEJHIMHJJ)
		{
			return default(KEMJGOAMALL);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x582B290", Offset = "0x582A490", VA = "0x18582B290", Slot = "11")]
		public void LGAKMPLFDHM(KEMJGOAMALL NBGOLMPJOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x582B3A0", Offset = "0x582A5A0", VA = "0x18582B3A0", Slot = "10")]
		public void MABBADAOIEP(KEMJGOAMALL NBGOLMPJOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x582A8E0", Offset = "0x5829AE0", VA = "0x18582A8E0", Slot = "21")]
		public IEnumerable<Renderer> AILAELCODEG(MDAFPBCOHEN KPDGHDGLMHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x582B320", Offset = "0x582A520", VA = "0x18582B320", Slot = "12")]
		public AMEFHJFMPIO LNOAMGAGHPI(BDLODHHJLKM PCPEJHIMHJJ)
		{
			return default(AMEFHJFMPIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x582B400", Offset = "0x582A600", VA = "0x18582B400", Slot = "14")]
		public void NAKBKBKDNCF(AMEFHJFMPIO BCDCKDKBNFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x582B000", Offset = "0x582A200", VA = "0x18582B000", Slot = "16")]
		public Task EAMKMOENFBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x582B120", Offset = "0x582A320", VA = "0x18582B120", Slot = "17")]
		public Task JNCAIECLLKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x582B0C0", Offset = "0x582A2C0", VA = "0x18582B0C0", Slot = "18")]
		public Task JIKBLFOLHLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2C63AC0", Offset = "0x2C62CC0", VA = "0x182C63AC0", Slot = "19")]
		public void ANDGAJBFDAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x582B060", Offset = "0x582A260", VA = "0x18582B060", Slot = "13")]
		public void ELNMJJJKEKJ(AMEFHJFMPIO BCDCKDKBNFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x582AB70", Offset = "0x5829D70", VA = "0x18582AB70", Slot = "20")]
		public HHEDHPOIFFL DMPDDNLLNAH(NCANNFMMHDJ GDHKDDJOENB, IEnumerable<KEMJGOAMALL> IHLJHIFFNPM, int PEFBLDIAEHF)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HKNPLOPDMCG : OFEBMEHKFCL
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class NHCPIKONFCP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HKNPLOPDMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x873910", Offset = "0x872B10", VA = "0x180873910")]
		[DebuggerHidden]
		public NHCPIKONFCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5827D30", Offset = "0x5826F30", VA = "0x185827D30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5827A50", Offset = "0x5826C50", VA = "0x185827A50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5827DB0", Offset = "0x5826FB0", VA = "0x185827DB0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5827CF0", Offset = "0x5826EF0", VA = "0x185827CF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5827C50", Offset = "0x5826E50", VA = "0x185827C50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5827C50", Offset = "0x5826E50", VA = "0x185827C50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly BDLODHHJLKM DGIOFCCFGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly EMFALLMFGNA KPIGEEGAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private IMFGPJFNFDF DEHPEHCIDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private List<LOIHCKHKAGJ> KBEFPIHEHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private List<LOIHCKHKAGJ> DHNPJMGODOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private GameObject LOIBFCJNIGD;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5823A30", Offset = "0x5822C30", VA = "0x185823A30")]
	public static HKNPLOPDMCG KCIHLCIFMIL(BDLODHHJLKM PCPEJHIMHJJ, EMFALLMFGNA KPIGEEGAKIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5823BA0", Offset = "0x5822DA0", VA = "0x185823BA0")]
	private HKNPLOPDMCG(BDLODHHJLKM PCPEJHIMHJJ, EMFALLMFGNA KPIGEEGAKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5823200", Offset = "0x5822400", VA = "0x185823200")]
	public void AFELIDKEEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x58236E0", Offset = "0x58228E0", VA = "0x1858236E0")]
	[IteratorStateMachine(typeof(NHCPIKONFCP))]
	public IEnumerable<Renderer> CDGLEPOMJBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5822720", Offset = "0x5821920", VA = "0x185822720", Slot = "4")]
	public void AEDDFPKFNHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5823990", Offset = "0x5822B90", VA = "0x185823990")]
	private void FNCJGDPPJLH(Vector3 AHFDHJEGKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5823750", Offset = "0x5822950", VA = "0x185823750")]
	public void CDJHKCNAIKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class LOIHCKHKAGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct CGCHHMGFLNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public MMJCAEIIBHK BDEGLKHHAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public NCANNFMMHDJ DAHEAHIBEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int GAEKLAECCGF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CLFOMEEGMDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public LOIHCKHKAGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public AALGJAMKLGC lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public List<CGCHHMGFLNF> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public HHEDHPOIFFL combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public CLFOMEEGMDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x58205B0", Offset = "0x581F7B0", VA = "0x1858205B0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5820610", Offset = "0x581F810", VA = "0x185820610")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5820640", Offset = "0x581F840", VA = "0x185820640")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int[] IBDMKMDGICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private BLHPIJFHHHC PPJJPDLMPAJ;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static Matrix4x4 OGFOKLOFPBN;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Mesh NNEMJIHPJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x82F780", Offset = "0x82E980", VA = "0x18082F780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int EGMOJDNHOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBF0", Offset = "0x7DDDF0", VA = "0x1807DEBF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x908F90", Offset = "0x908190", VA = "0x180908F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x58269E0", Offset = "0x5825BE0", VA = "0x1858269E0")]
	public void OALPNMBJMNO(List<NCANNFMMHDJ> JGFKGFJFPEC, Matrix4x4[] OLLGNOBBPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x58263B0", Offset = "0x58255B0", VA = "0x1858263B0")]
	public static List<LOIHCKHKAGJ> GPGHDDABLEF(List<JPNEHBHNENF> JENFGOOPGAC, AALGJAMKLGC EMMLNOGJBFM, Bounds DBPFJELGIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5825FD0", Offset = "0x58251D0", VA = "0x185825FD0")]
	private JobHandle FAMLDPLAFJC(HHEDHPOIFFL PAAPMMECEFG, int DDKMIBANAFL, int ICPBDIMNGOJ, AALGJAMKLGC EMMLNOGJBFM, List<CGCHHMGFLNF> MDKHPCEDHOF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5826C10", Offset = "0x5825E10", VA = "0x185826C10")]
	private void PPNGMIJAIEB(List<CGCHHMGFLNF> MDKHPCEDHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5826E50", Offset = "0x5826050", VA = "0x185826E50")]
	private LOIHCKHKAGJ(List<CGCHHMGFLNF> MDKHPCEDHOF, int DDKMIBANAFL, int ICPBDIMNGOJ, AALGJAMKLGC EMMLNOGJBFM, Bounds DBPFJELGIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5825F40", Offset = "0x5825140", VA = "0x185825F40", Slot = "4")]
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
		private MaterialPropertyBlock APJGLDPNCLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private LOIHCKHKAGJ AAKOJGEOGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private List<NCANNFMMHDJ> BLBKONLFICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private RenderTexture EODPFJABBEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private ComputeBuffer HLOHCFICPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private ComputeShader GAIIDFJDICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Matrix4x4[] CIIBCPNIBGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int AHAPMOGAFCJ;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public MeshRenderer HKLMPCKALHF
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6FFB00", Offset = "0x6FED00", VA = "0x1806FFB00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int GJECGLAMFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x582C650", Offset = "0x582B850", VA = "0x18582C650")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x582BBF0", Offset = "0x582ADF0", VA = "0x18582BBF0")]
		public static List<SkinnedShapeRenderer> Create(GameObject KPDGHDGLMHO, List<LOIHCKHKAGJ> OCBLEIOLAGM, List<NCANNFMMHDJ> BLBKONLFICB, Material PMPDPBDKGPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x582BE40", Offset = "0x582B040", VA = "0x18582BE40")]
		public void Init(LOIHCKHKAGJ AAKOJGEOGGC, List<NCANNFMMHDJ> BLBKONLFICB, Material PMPDPBDKGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x582C5A0", Offset = "0x582B7A0", VA = "0x18582C5A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x582C4F0", Offset = "0x582B6F0", VA = "0x18582C4F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x582C4B0", Offset = "0x582B6B0", VA = "0x18582C4B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x582B9C0", Offset = "0x582ABC0", VA = "0x18582B9C0")]
		private void CHLGOILINLM(ScriptableRenderContext DELCOFCGDFF, Camera[] IHFAPCEAHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x582C2F0", Offset = "0x582B4F0", VA = "0x18582C2F0")]
		private void OALPNMBJMNO(CommandBuffer DLPDGBIHCIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	internal class _RRAssemblyIndex : HDLOHLLNPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x582CEE0", Offset = "0x582C0E0", VA = "0x18582CEE0", Slot = "4")]
		public sealed override void GAJKJBJLBCF()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5827420", Offset = "0x5826620", VA = "0x185827420")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5827530", Offset = "0x5826730", VA = "0x185827530")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
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
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
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
