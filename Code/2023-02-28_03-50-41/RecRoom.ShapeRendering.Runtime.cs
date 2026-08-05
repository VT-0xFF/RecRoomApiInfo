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
public enum DDKNBBHFCED
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
public static class FGNOLMKKKKD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x610C9E0", Offset = "0x610B3E0", VA = "0x18610C9E0")]
	public static bool FAFNJGNNCKC(this DDKNBBHFCED LHGDKNGCBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x610CA00", Offset = "0x610B400", VA = "0x18610CA00")]
	public static bool LNHCKAMCIMB(this DDKNBBHFCED LHGDKNGCBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x610CA10", Offset = "0x610B410", VA = "0x18610CA10")]
	public static bool NENFOFNECKM(this DDKNBBHFCED LHGDKNGCBBH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LCHJADBNMMB
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
public enum NNHKBFMDKML
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
public enum BDFOGDLNFAP
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
public enum ECAGGLGKIMN
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
public class EDIKJNIGGCN : BHAINBDOJGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte OADCLJFANLF = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte KCCGMLKCOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] GADPOMCFPIC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HHBAIOEJPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C1010", Offset = "0x6BFA10", VA = "0x1806C1010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70ACC0", Offset = "0x7096C0", VA = "0x18070ACC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AFDMHCFBEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E1D90", Offset = "0x6E0790", VA = "0x1806E1D90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x859D20", Offset = "0x858720", VA = "0x180859D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float NKNFODJGFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x113B1A0", Offset = "0x1139BA0", VA = "0x18113B1A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x113B1B0", Offset = "0x1139BB0", VA = "0x18113B1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float MMDBPHAEMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x121E5B0", Offset = "0x121CFB0", VA = "0x18121E5B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x16411C0", Offset = "0x163FBC0", VA = "0x1816411C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> FMGCNBNAJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x610C280", Offset = "0x610AC80", VA = "0x18610C280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> GGOMJFIMHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D08A40", Offset = "0x5D07440", VA = "0x185D08A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte BNAAGNAJNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x610C230", Offset = "0x610AC30", VA = "0x18610C230", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x610C620", Offset = "0x610B020", VA = "0x18610C620")]
	public EDIKJNIGGCN(List<NLLLMHMNOLD> KMLCJHGFGHO, List<NLLLMHMNOLD> HJBHNLHEKDB, List<CKMHCCNBJAM> CGKKHILCIKH, Material JLAFBAMDDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x610C380", Offset = "0x610AD80", VA = "0x18610C380")]
	private int HMFDDKEPLBE(List<NLLLMHMNOLD> AHEGEMIDBPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x610C4D0", Offset = "0x610AED0", VA = "0x18610C4D0")]
	private void PAOFPOLAGDH(int KJENGDJHHDA, bool MHJJEDNLELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x610C2E0", Offset = "0x610ACE0", VA = "0x18610C2E0")]
	public void GHJIDIEOMCG(Vector3 NFFAGBMOFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x610C100", Offset = "0x610AB00", VA = "0x18610C100", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x610C490", Offset = "0x610AE90", VA = "0x18610C490")]
	public void IDDCAICCFPJ(Transform GMKGKIDJLGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CGECJNDCAAL : GMAIFHOGFCG, MMCEPMAFHFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NPJBNMBMIEB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public CGECJNDCAAL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
		[DebuggerHidden]
		public NPJBNMBMIEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6113DF0", Offset = "0x61127F0", VA = "0x186113DF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x61138C0", Offset = "0x61122C0", VA = "0x1861138C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6113EF0", Offset = "0x61128F0", VA = "0x186113EF0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6113F40", Offset = "0x6112940", VA = "0x186113F40")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6113F90", Offset = "0x6112990", VA = "0x186113F90")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6113DB0", Offset = "0x61127B0", VA = "0x186113DB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6113D10", Offset = "0x6112710", VA = "0x186113D10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6113D10", Offset = "0x6112710", VA = "0x186113D10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MMKGMIJOHCL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public CGECJNDCAAL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
		[DebuggerHidden]
		public MMKGMIJOHCL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6112420", Offset = "0x6110E20", VA = "0x186112420", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6112060", Offset = "0x6110A60", VA = "0x186112060", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6112500", Offset = "0x6110F00", VA = "0x186112500")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6112550", Offset = "0x6110F50", VA = "0x186112550")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x61123E0", Offset = "0x6110DE0", VA = "0x1861123E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6112340", Offset = "0x6110D40", VA = "0x186112340", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6112340", Offset = "0x6110D40", VA = "0x186112340", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly BCNNEMIIPEA DHGLMOCIHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<GMOGODKGKFK> CBMJLDDPGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> INLACHBHGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer JOAOGDGJKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool NLGEIHHLHCD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<DLKKBAOBHIN> INEDJFMLAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int LCOFKKKGOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6109670", Offset = "0x6108070", VA = "0x186109670", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public CKMHCCNBJAM DBIKMHNAGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6108FA0", Offset = "0x61079A0", VA = "0x186108FA0", Slot = "7")]
		get
		{
			return default(CKMHCCNBJAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> MFCCJGELHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8590", Offset = "0x6C6F90", VA = "0x1806C8590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61099C0", Offset = "0x61083C0", VA = "0x1861099C0")]
	public CGECJNDCAAL(BCNNEMIIPEA NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6108910", Offset = "0x6107310", VA = "0x186108910", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6108800", Offset = "0x6107200", VA = "0x186108800")]
	public void CPLOAHMOJFD(GMOGODKGKFK FJDLFDKNODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6109900", Offset = "0x6108300", VA = "0x186109900")]
	public void OLCIACFECIH(GMOGODKGKFK FJDLFDKNODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6109070", Offset = "0x6107A70", VA = "0x186109070", Slot = "4")]
	public void HJJNCBJPLFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61086E0", Offset = "0x61070E0", VA = "0x1861086E0")]
	public void BBFMMOJDOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61096B0", Offset = "0x61080B0", VA = "0x1861096B0")]
	private void LHBIJMJMFDK(List<GMOGODKGKFK> CBMJLDDPGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6109830", Offset = "0x6108230", VA = "0x186109830")]
	private static Material LHPCIFNBMNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61097E0", Offset = "0x61081E0", VA = "0x1861097E0")]
	private void LHBIJMJMFDK(GMOGODKGKFK FJDLFDKNODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6108ED0", Offset = "0x61078D0", VA = "0x186108ED0")]
	private void GHDCJHNFEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6108940", Offset = "0x6107340", VA = "0x186108940")]
	public void EFCHLOEBBNN(bool FFMALNAGALB, bool EODJIPKCGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61095E0", Offset = "0x6107FE0", VA = "0x1861095E0")]
	protected void IDMLIEPNNLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6108E60", Offset = "0x6107860", VA = "0x186108E60")]
	[IteratorStateMachine(typeof(NPJBNMBMIEB))]
	public IEnumerable<Renderer> EJMNPGICLIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6108790", Offset = "0x6107190", VA = "0x186108790")]
	[IteratorStateMachine(typeof(MMKGMIJOHCL))]
	public IEnumerable<Renderer> CABCEFJMJIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class JHKBLOGLMFF : GMOGODKGKFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly DIDCJOPJLGK OABKDJHJDAF;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x610E3F0", Offset = "0x610CDF0", VA = "0x18610E3F0")]
	public JHKBLOGLMFF(CGECJNDCAAL OFMDHDILEHM, DIDCJOPJLGK NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x610EF70", Offset = "0x610D970", VA = "0x18610EF70", Slot = "13")]
	public override int HMFDDKEPLBE(NLKDANNNGOD KGLBJJDFAOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x610F160", Offset = "0x610DB60", VA = "0x18610F160", Slot = "14")]
	public override int LJIJDGECMFL(NLKDANNNGOD KGLBJJDFAOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x610E840", Offset = "0x610D240", VA = "0x18610E840", Slot = "15")]
	public override void FDMPLBAHBGA(NLKDANNNGOD KGLBJJDFAOB, IAENMLENEKB FEAHDOMPHEC, int NDODMOLMECN = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct LBNMBPFCIDH : global::HFJJIJCEKGL<LBNMBPFCIDH>, HOKCJDBMKAA, IEquatable<LBNMBPFCIDH>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[CreateProperty]
	public int FOHLPAKJEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x772D90", Offset = "0x771790", VA = "0x180772D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int BNNADFINGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x88A590", Offset = "0x888F90", VA = "0x18088A590", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xEA60A0", Offset = "0xEA4AA0", VA = "0x180EA60A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MPANJOCJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x610FB70", Offset = "0x610E570", VA = "0x18610FB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x29575B0", Offset = "0x2955FB0", VA = "0x1829575B0", Slot = "8")]
	public bool Equals(LBNMBPFCIDH DFHJPOKNFFB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xCDFA90", Offset = "0xCDE490", VA = "0x180CDFA90")]
	public static bool NENBKMMGKMN(LBNMBPFCIDH PKEMCIANHMO, LBNMBPFCIDH DLAMIJMLOOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4BADC70", Offset = "0x4BAC670", VA = "0x184BADC70")]
	public static bool HCCIHOFGPHE(LBNMBPFCIDH PKEMCIANHMO, LBNMBPFCIDH DLAMIJMLOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x610FAE0", Offset = "0x610E4E0", VA = "0x18610FAE0", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x610FBB0", Offset = "0x610E5B0", VA = "0x18610FBB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum OENDBHCNMJC
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
public interface BCNNEMIIPEA
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CKMHCCNBJAM ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	OENDBHCNMJC BDOLIJKAKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JIIBLJKCCDF : global::HFJJIJCEKGL<JIIBLJKCCDF>, HOKCJDBMKAA, IEquatable<JIIBLJKCCDF>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	[CreateProperty]
	public int FOHLPAKJEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x772D90", Offset = "0x771790", VA = "0x180772D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int BNNADFINGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x88A590", Offset = "0x888F90", VA = "0x18088A590", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xEA60A0", Offset = "0xEA4AA0", VA = "0x180EA60A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MPANJOCJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x610F3E0", Offset = "0x610DDE0", VA = "0x18610F3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29575B0", Offset = "0x2955FB0", VA = "0x1829575B0", Slot = "8")]
	public bool Equals(JIIBLJKCCDF DFHJPOKNFFB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xCDFA90", Offset = "0xCDE490", VA = "0x180CDFA90")]
	public static bool NENBKMMGKMN(JIIBLJKCCDF PKEMCIANHMO, JIIBLJKCCDF DLAMIJMLOOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4BADC70", Offset = "0x4BAC670", VA = "0x184BADC70")]
	public static bool HCCIHOFGPHE(JIIBLJKCCDF PKEMCIANHMO, JIIBLJKCCDF DLAMIJMLOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x610F350", Offset = "0x610DD50", VA = "0x18610F350", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x610F420", Offset = "0x610DE20", VA = "0x18610F420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HOCLFKAFFGK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	CKMHCCNBJAM ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float LBOHFPFCLLF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 OEBLFDEIIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	DDKNBBHFCED KOMCBDLCMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	LCHJADBNMMB HHPALLLOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NCGODGKFMOD : HOCLFKAFFGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	AICLBGKMGEA DMLPEBNKKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool PJFGCPDIPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DIDCJOPJLGK : HOCLFKAFFGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MHPNOJJDADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool HJNEBIKLADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float HCBHGEOOFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int LNIAPOPCJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JCPIPDBKBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int IPEIOALCEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<EGEAMHKFJFH> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LFGMJEOHHGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLMDCHEOGKK(LBNMBPFCIDH OFMDHDILEHM, BDFOGDLNFAP GIKLJDACLBE);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLMDCHEOGKK(JIIBLJKCCDF FJDLFDKNODB, BDFOGDLNFAP GIKLJDACLBE);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJECILEMOCD(JIIBLJKCCDF FJDLFDKNODB);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AALCIKGNCIE(JIIBLJKCCDF FJDLFDKNODB);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IIIBCFPDJGA();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KCMPMBMKCNJ();

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IDAAPKODGJO(BDFOGDLNFAP MAHAMGBPDNB);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DEJODKCOBFP(LBNMBPFCIDH OFMDHDILEHM);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DEJODKCOBFP(JIIBLJKCCDF FJDLFDKNODB);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OKILCLNFAFJ(LBNMBPFCIDH OFMDHDILEHM, ECAGGLGKIMN MAHAMGBPDNB);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OKILCLNFAFJ(JIIBLJKCCDF FJDLFDKNODB, ECAGGLGKIMN MAHAMGBPDNB);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AJOCCFIEJAM(JIIBLJKCCDF FJDLFDKNODB);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NNHJHGPCGAC(JIIBLJKCCDF FJDLFDKNODB);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FMFFMKFKEDI();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IFAMPBBGPMM();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BNPOMLGNPPL(ECAGGLGKIMN MAHAMGBPDNB);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void COCKKMJJPBP(LBNMBPFCIDH OFMDHDILEHM, Vector3 OAJLJILLHJG, Vector3 IDMEEOIOAOA, Vector3 CJFOOEJGPPE, float KEBOABJPBKO, float GNGFDMALBOI, IReadOnlyList<Camera> KMKPKDLMNOG, NNHKBFMDKML HKENOFJOAAF);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void COCKKMJJPBP(CKOGJMICGMP CNAFNMCFOGP, Vector3 OAJLJILLHJG, Vector3 IDMEEOIOAOA, Vector3 CJFOOEJGPPE, float KEBOABJPBKO, float GNGFDMALBOI);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EBEJFCLDEIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LBNMBPFCIDH GFAJILHOENF(BCNNEMIIPEA NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFHAEMEOPPA(LBNMBPFCIDH OFMDHDILEHM);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFEJHCPIELH(LBNMBPFCIDH OFMDHDILEHM);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JIIBLJKCCDF GFANJIFEIHH(LBNMBPFCIDH OFMDHDILEHM, NCGODGKFMOD NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JIIBLJKCCDF OAJIJIABCJJ(LBNMBPFCIDH OFMDHDILEHM, DIDCJOPJLGK NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDMPBODJAIK(JIIBLJKCCDF FJDLFDKNODB);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KDGBJLJMEHC(JIIBLJKCCDF FJDLFDKNODB);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CKOGJMICGMP GACBIHECAKN(CGGANHAFMBP NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DOFOKIMECNB(CKOGJMICGMP CNAFNMCFOGP);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DBOOCMMLJDF(CKOGJMICGMP CNAFNMCFOGP);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "10")]
	APEFKKOHFNF KHIDEIKBJNE(CKMHCCNBJAM FMJFMKBDFPI, IEnumerable<JIIBLJKCCDF> CBMJLDDPGFC, int MMBAALPDKPB);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> PCPCOEILCFD(LBNMBPFCIDH OFMDHDILEHM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CKOGJMICGMP : global::HFJJIJCEKGL<CKOGJMICGMP>, HOKCJDBMKAA, IEquatable<CKOGJMICGMP>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int FOHLPAKJEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x772D90", Offset = "0x771790", VA = "0x180772D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int BNNADFINGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x88A590", Offset = "0x888F90", VA = "0x18088A590", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xEA60A0", Offset = "0xEA4AA0", VA = "0x180EA60A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MPANJOCJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6109AF0", Offset = "0x61084F0", VA = "0x186109AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x29575B0", Offset = "0x2955FB0", VA = "0x1829575B0", Slot = "8")]
	public bool Equals(CKOGJMICGMP DFHJPOKNFFB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xCDFA90", Offset = "0xCDE490", VA = "0x180CDFA90")]
	public static bool NENBKMMGKMN(CKOGJMICGMP PKEMCIANHMO, CKOGJMICGMP DLAMIJMLOOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4BADC70", Offset = "0x4BAC670", VA = "0x184BADC70")]
	public static bool HCCIHOFGPHE(CKOGJMICGMP PKEMCIANHMO, CKOGJMICGMP DLAMIJMLOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6109A60", Offset = "0x6108460", VA = "0x186109A60", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CGGANHAFMBP
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int HNEDIACNNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform LGLIHKFNJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool JLMOLKCONLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LBNMBPFCIDH GetBone(int FAGECCIHDBG);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int FAGECCIHDBG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class HMDNJFEJDGI : GMOGODKGKFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly NCGODGKFMOD EMKMBIALDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int[] MLOLJDIGPBH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override LDNMMNGAIFL OJIDDGMGLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x610E040", Offset = "0x610CA40", VA = "0x18610E040", Slot = "12")]
		get
		{
			return default(LDNMMNGAIFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 CMGEDINHDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x610DD00", Offset = "0x610C700", VA = "0x18610DD00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x610E3F0", Offset = "0x610CDF0", VA = "0x18610E3F0")]
	public HMDNJFEJDGI(CGECJNDCAAL OFMDHDILEHM, NCGODGKFMOD NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x610D480", Offset = "0x610BE80", VA = "0x18610D480", Slot = "11")]
	public override bool HBEFOFIJOMG(CKMHCCNBJAM OFMDHDILEHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x610D8F0", Offset = "0x610C2F0", VA = "0x18610D8F0", Slot = "13")]
	public override int HMFDDKEPLBE(NLKDANNNGOD KGLBJJDFAOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x610DC50", Offset = "0x610C650", VA = "0x18610DC50", Slot = "14")]
	public override int LJIJDGECMFL(NLKDANNNGOD KGLBJJDFAOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x610D9A0", Offset = "0x610C3A0", VA = "0x18610D9A0")]
	private int KBIEGLMFIKN(NLKDANNNGOD KGLBJJDFAOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x610CBA0", Offset = "0x610B5A0", VA = "0x18610CBA0", Slot = "15")]
	public override void FDMPLBAHBGA(NLKDANNNGOD KGLBJJDFAOB, IAENMLENEKB FEAHDOMPHEC, int NDODMOLMECN = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CJJOPGAANBN
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBLDDDKDCGH(ECAGGLGKIMN MAHAMGBPDNB, Renderer PLHMOEIKNML, int HLBBCODAKAK);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIJEFEJACAC(Renderer PLHMOEIKNML, NNHKBFMDKML HKENOFJOAAF, Vector3 OAJLJILLHJG, Vector3 IDMEEOIOAOA, Vector3 CJFOOEJGPPE, float KEBOABJPBKO, float GNGFDMALBOI, float LCMGFGMMONG = -1f, [Optional] Color? HAAENNGJIPE, [Optional] IReadOnlyList<Camera> OHCBABEFFOP);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHGDOKEJIDC(Renderer PLHMOEIKNML, int HLBBCODAKAK);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EJBFOOMNJGB();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OEPOOIEOEJK(int IBMKECLPCAN, BDFOGDLNFAP MAHAMGBPDNB, Renderer PLHMOEIKNML, int HLBBCODAKAK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MCJOFANGCML : LFGMJEOHHGI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class JAGOJKPOGDO : global::AEJAIIJHCFJ<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x610E440", Offset = "0x610CE40", VA = "0x18610E440")]
		public JAGOJKPOGDO(string ANJJEPIBAGI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly CJJOPGAANBN MCADHHNFDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly AGOIOJBJLNK LNONNPDIPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MeshRenderer OLCHPCABFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private JAGOJKPOGDO KGMDGIJGIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool PDENDIKCPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MeshRenderer GMFOEJKKFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private JAGOJKPOGDO GHOBKACAILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool PHAMMLMDGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MeshRenderer POKEJHPODMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private JAGOJKPOGDO MFAJDANDOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C16E0", Offset = "0x6C00E0", VA = "0x1806C16E0")]
	public MCJOFANGCML(CJJOPGAANBN FPDHKGGCMDB, AGOIOJBJLNK LNONNPDIPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6110BE0", Offset = "0x610F5E0", VA = "0x186110BE0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6110DF0", Offset = "0x610F7F0", VA = "0x186110DF0")]
	private void GLIFEJKJCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6111E60", Offset = "0x6110860", VA = "0x186111E60", Slot = "4")]
	public void OLMDCHEOGKK(LBNMBPFCIDH OFMDHDILEHM, BDFOGDLNFAP GIKLJDACLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6111C40", Offset = "0x6110640", VA = "0x186111C40", Slot = "5")]
	public void OLMDCHEOGKK(JIIBLJKCCDF FJDLFDKNODB, BDFOGDLNFAP GIKLJDACLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61111F0", Offset = "0x610FBF0", VA = "0x1861111F0", Slot = "6")]
	public void JJECILEMOCD(JIIBLJKCCDF FJDLFDKNODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x610FC40", Offset = "0x610E640", VA = "0x18610FC40", Slot = "7")]
	public void AALCIKGNCIE(JIIBLJKCCDF FJDLFDKNODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x61111B0", Offset = "0x610FBB0", VA = "0x1861111B0", Slot = "8")]
	public void IIIBCFPDJGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1645D10", Offset = "0x1644710", VA = "0x181645D10", Slot = "9")]
	public void KCMPMBMKCNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6111040", Offset = "0x610FA40", VA = "0x186111040", Slot = "10")]
	public void IDAAPKODGJO(BDFOGDLNFAP GIKLJDACLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6110A30", Offset = "0x610F430", VA = "0x186110A30", Slot = "11")]
	public void DEJODKCOBFP(LBNMBPFCIDH OFMDHDILEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x61106E0", Offset = "0x610F0E0", VA = "0x1861106E0", Slot = "12")]
	public void DEJODKCOBFP(JIIBLJKCCDF FJDLFDKNODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x61116D0", Offset = "0x61100D0", VA = "0x1861116D0", Slot = "13")]
	public void OKILCLNFAFJ(LBNMBPFCIDH OFMDHDILEHM, ECAGGLGKIMN MAHAMGBPDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6111890", Offset = "0x6110290", VA = "0x186111890", Slot = "14")]
	public void OKILCLNFAFJ(JIIBLJKCCDF FJDLFDKNODB, ECAGGLGKIMN MAHAMGBPDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6110DB0", Offset = "0x610F7B0", VA = "0x186110DB0", Slot = "17")]
	public void FMFFMKFKEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x610FD60", Offset = "0x610E760", VA = "0x18610FD60", Slot = "15")]
	public void AJOCCFIEJAM(JIIBLJKCCDF FJDLFDKNODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6111640", Offset = "0x6110040", VA = "0x186111640", Slot = "16")]
	public void NNHJHGPCGAC(JIIBLJKCCDF FJDLFDKNODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1277020", Offset = "0x1275A20", VA = "0x181277020", Slot = "18")]
	public void IFAMPBBGPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x610FE00", Offset = "0x610E800", VA = "0x18610FE00", Slot = "19")]
	public void BNPOMLGNPPL(ECAGGLGKIMN MAHAMGBPDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61113F0", Offset = "0x610FDF0", VA = "0x1861113F0")]
	private void MHPIPBNOHMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6111A80", Offset = "0x6110480", VA = "0x186111A80")]
	public void OKILCLNFAFJ(JIIBLJKCCDF FJDLFDKNODB, ECAGGLGKIMN MAHAMGBPDNB, bool KKLPGCCOGJP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6111320", Offset = "0x610FD20", VA = "0x186111320")]
	private void LBLDDDKDCGH(ECAGGLGKIMN MAHAMGBPDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x610FF40", Offset = "0x610E940", VA = "0x18610FF40", Slot = "20")]
	public void COCKKMJJPBP(LBNMBPFCIDH OFMDHDILEHM, Vector3 OAJLJILLHJG, Vector3 IDMEEOIOAOA, Vector3 CJFOOEJGPPE, float KEBOABJPBKO, float GNGFDMALBOI, IReadOnlyList<Camera> KMKPKDLMNOG, NNHKBFMDKML HKENOFJOAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x61102C0", Offset = "0x610ECC0", VA = "0x1861102C0", Slot = "21")]
	public void COCKKMJJPBP(CKOGJMICGMP CNAFNMCFOGP, Vector3 OAJLJILLHJG, Vector3 IDMEEOIOAOA, Vector3 CJFOOEJGPPE, float KEBOABJPBKO, float GNGFDMALBOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class GMOGODKGKFK : FGBFMJCGKFM, DLKKBAOBHIN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly CGECJNDCAAL PMIOODBJODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	protected Bounds DHBBJHELFHF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds DAMGLCDOKKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xFF0760", Offset = "0xFEF160", VA = "0x180FF0760", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual LDNMMNGAIFL OJIDDGMGLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x610CB10", Offset = "0x610B510", VA = "0x18610CB10", Slot = "12")]
		get
		{
			return default(LDNMMNGAIFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
	protected GMOGODKGKFK(CGECJNDCAAL OFMDHDILEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x610CA40", Offset = "0x610B440", VA = "0x18610CA40", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "11")]
	public virtual bool HBEFOFIJOMG(CKMHCCNBJAM OFMDHDILEHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int HMFDDKEPLBE(NLKDANNNGOD KGLBJJDFAOB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int LJIJDGECMFL(NLKDANNNGOD KGLBJJDFAOB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void FDMPLBAHBGA(NLKDANNNGOD KGLBJJDFAOB, IAENMLENEKB FEAHDOMPHEC, int NDODMOLMECN = -1);
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
		[Cpp2IlInjected.Address(RVA = "0x6114190", Offset = "0x6112B90", VA = "0x186114190")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum AICLBGKMGEA
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
public static class DNNINDEOOKO
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OBODFLOFPGM : IEnumerable<GFMJPKJGFJB>, IEnumerable, IEnumerator<GFMJPKJGFJB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private GFMJPKJGFJB <>2__current;

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
		private GFMJPKJGFJB System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
		[DebuggerHidden]
		public OBODFLOFPGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6113FE0", Offset = "0x61129E0", VA = "0x186113FE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6114150", Offset = "0x6112B50", VA = "0x186114150", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x61140C0", Offset = "0x6112AC0", VA = "0x1861140C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GFMJPKJGFJB> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x61140C0", Offset = "0x6112AC0", VA = "0x1861140C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int MOLMGBFPNKD = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static GFMJPKJGFJB[][] PKGGFONKOIA;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static IGJJEBIGEEP AKHDEOPDFNH;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static ShapeRendererConfig KOGDCGEFLPG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader CFOJKCFJDJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x610B560", Offset = "0x6109F60", VA = "0x18610B560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer PBPPBPHCOON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x610BFF0", Offset = "0x610A9F0", VA = "0x18610BFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x610B9C0", Offset = "0x610A3C0", VA = "0x18610B9C0")]
	public static Mesh JJEKMDOGMOG(AICLBGKMGEA KLMBNLJMKJC, int KGLBJJDFAOB = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x610BA80", Offset = "0x610A480", VA = "0x18610BA80")]
	public static int JPDPEDHEGOI(AICLBGKMGEA KLMBNLJMKJC, int KGLBJJDFAOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x610B1E0", Offset = "0x6109BE0", VA = "0x18610B1E0")]
	public static IGJJEBIGEEP BLEHNGNIJME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x610B5E0", Offset = "0x6109FE0", VA = "0x18610B5E0")]
	[IteratorStateMachine(typeof(OBODFLOFPGM))]
	private static IEnumerable<GFMJPKJGFJB> FMIICPFECHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x610B640", Offset = "0x610A040", VA = "0x18610B640")]
	public static GFMJPKJGFJB FOGFCEGOFFB(AICLBGKMGEA KLMBNLJMKJC, int KGLBJJDFAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x610B9A0", Offset = "0x610A3A0", VA = "0x18610B9A0")]
	public static bool HPEFNMOJIAP(this AICLBGKMGEA KLMBNLJMKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x610BA90", Offset = "0x610A490", VA = "0x18610BA90")]
	public static void LBHEOEKLOJO(AICLBGKMGEA KLMBNLJMKJC, float3 PMBCDHODEFE, out HHCJEHLNMCM OGHDANNKLCP, out float3 NGBAELBFNGJ, out float CPLOMIGIOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x610BC40", Offset = "0x610A640", VA = "0x18610BC40")]
	public static void MGCELPICGEI(Vector3 PMBCDHODEFE, AICLBGKMGEA KLMBNLJMKJC, out Vector3 NGBAELBFNGJ, out float CPLOMIGIOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x610B5D0", Offset = "0x6109FD0", VA = "0x18610B5D0")]
	[KCBPKDKAKIN(AJCDLBPHHHC.ExitingPlayMode, 0)]
	private static void EJLLEBECILN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x610B340", Offset = "0x6109D40", VA = "0x18610B340")]
	[KCBPKDKAKIN(AJCDLBPHHHC.ExitingPlayMode, 0)]
	private static void DOIEGGKCJGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface OIMNEDEIPBI
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool KBAPNDHNJDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material OANMGKFKMJD();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material LHPCIFNBMNN();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material FNACKJBCJAL();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JHOBCBOMLLF(DDKNBBHFCED LHGDKNGCBBH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int MALAAADBMAP(LCHJADBNMMB APCJMEBNFPO);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JPEEFFNMKKK(GameObject LAFPICAOEAI);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LBGKJIDHELN(GameObject LAFPICAOEAI, bool CFACBPJAIDF);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface AGOIOJBJLNK
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CGECJNDCAAL NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	GMOGODKGKFK NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	DBGIDCALOJI NLCLIBHDEBL
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
	[LOEOGANCBGC(EDPDLGMLNHJ.ShapeRendering)]
	public class ShapeRendererManager : EBEJFCLDEIC, IDisposable, AGOIOJBJLNK
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly global::PMHDFBOBOFM<LBNMBPFCIDH, CGECJNDCAAL> FAFFAHGEOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly global::PMHDFBOBOFM<JIIBLJKCCDF, GMOGODKGKFK> CBMJLDDPGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly global::PMHDFBOBOFM<CKOGJMICGMP, DBGIDCALOJI> MGPFLKIAHLP;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static OIMNEDEIPBI GFKJGOKFGKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x6114DC0", Offset = "0x61137C0", VA = "0x186114DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6114E20", Offset = "0x6113820", VA = "0x186114E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public CGECJNDCAAL NLCLIBHDEBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6114300", Offset = "0x6112D00", VA = "0x186114300", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public GMOGODKGKFK NLCLIBHDEBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x61142A0", Offset = "0x6112CA0", VA = "0x1861142A0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public DBGIDCALOJI NLCLIBHDEBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6114240", Offset = "0x6112C40", VA = "0x186114240", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x61150B0", Offset = "0x6113AB0", VA = "0x1861150B0")]
		public ShapeRendererManager(OIMNEDEIPBI FPDHKGGCMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6114490", Offset = "0x6112E90", VA = "0x186114490", Slot = "16")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x61146C0", Offset = "0x61130C0", VA = "0x1861146C0", Slot = "4")]
		public LBNMBPFCIDH GFAJILHOENF(BCNNEMIIPEA NIPBPKPBPPP)
		{
			return default(LBNMBPFCIDH);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6114360", Offset = "0x6112D60", VA = "0x186114360", Slot = "5")]
		public void BFHAEMEOPPA(LBNMBPFCIDH OFMDHDILEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x61141C0", Offset = "0x6112BC0", VA = "0x1861141C0", Slot = "6")]
		public void AFEJHCPIELH(LBNMBPFCIDH OFMDHDILEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x61147C0", Offset = "0x61131C0", VA = "0x1861147C0", Slot = "7")]
		public JIIBLJKCCDF GFANJIFEIHH(LBNMBPFCIDH OFMDHDILEHM, NCGODGKFMOD NIPBPKPBPPP)
		{
			return default(JIIBLJKCCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6114E90", Offset = "0x6113890", VA = "0x186114E90", Slot = "8")]
		public JIIBLJKCCDF OAJIJIABCJJ(LBNMBPFCIDH OFMDHDILEHM, DIDCJOPJLGK NIPBPKPBPPP)
		{
			return default(JIIBLJKCCDF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6114930", Offset = "0x6113330", VA = "0x186114930", Slot = "10")]
		public void KDGBJLJMEHC(JIIBLJKCCDF FJDLFDKNODB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x61148D0", Offset = "0x61132D0", VA = "0x1861148D0", Slot = "9")]
		public void HDMPBODJAIK(JIIBLJKCCDF FJDLFDKNODB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6114FA0", Offset = "0x61139A0", VA = "0x186114FA0", Slot = "15")]
		public IEnumerable<Renderer> PCPCOEILCFD(LBNMBPFCIDH OFMDHDILEHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6114520", Offset = "0x6112F20", VA = "0x186114520", Slot = "11")]
		public CKOGJMICGMP GACBIHECAKN(CGGANHAFMBP NIPBPKPBPPP)
		{
			return default(CKOGJMICGMP);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x61143C0", Offset = "0x6112DC0", VA = "0x1861143C0", Slot = "13")]
		public void DBOOCMMLJDF(CKOGJMICGMP CNAFNMCFOGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6114430", Offset = "0x6112E30", VA = "0x186114430", Slot = "12")]
		public void DOFOKIMECNB(CKOGJMICGMP CNAFNMCFOGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x61149C0", Offset = "0x61133C0", VA = "0x1861149C0", Slot = "14")]
		public APEFKKOHFNF KHIDEIKBJNE(CKMHCCNBJAM JEODGDOLBOD, IEnumerable<JIIBLJKCCDF> CBMJLDDPGFC, int MMBAALPDKPB)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DBGIDCALOJI : GMAIFHOGFCG
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class JCODCCGBOMM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DBGIDCALOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
		[DebuggerHidden]
		public JCODCCGBOMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x610E770", Offset = "0x610D170", VA = "0x18610E770", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x610E490", Offset = "0x610CE90", VA = "0x18610E490", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x610E7F0", Offset = "0x610D1F0", VA = "0x18610E7F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x610E730", Offset = "0x610D130", VA = "0x18610E730", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x610E690", Offset = "0x610D090", VA = "0x18610E690", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x610E690", Offset = "0x610D090", VA = "0x18610E690", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly CGGANHAFMBP LJIAGJLLOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly AGOIOJBJLNK LNONNPDIPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private EDIKJNIGGCN IKKKGEAKKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private List<NLLLMHMNOLD> OLGKCGLLHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private List<NLLLMHMNOLD> ICGKNEEDCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject AGKCODHPKBI;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x610AF70", Offset = "0x6109970", VA = "0x18610AF70")]
	public static DBGIDCALOJI PLKICMFFOPB(CGGANHAFMBP NIPBPKPBPPP, AGOIOJBJLNK LNONNPDIPBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x610B0E0", Offset = "0x6109AE0", VA = "0x18610B0E0")]
	private DBGIDCALOJI(CGGANHAFMBP NIPBPKPBPPP, AGOIOJBJLNK LNONNPDIPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x610AA90", Offset = "0x6109490", VA = "0x18610AA90")]
	public void JGBMECMGNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6109E70", Offset = "0x6108870", VA = "0x186109E70")]
	[IteratorStateMachine(typeof(JCODCCGBOMM))]
	public IEnumerable<Renderer> EJMNPGICLIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6109EE0", Offset = "0x61088E0", VA = "0x186109EE0", Slot = "4")]
	public void HJJNCBJPLFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6109DD0", Offset = "0x61087D0", VA = "0x186109DD0")]
	private void DPNIKBGJCOA(Vector3 NFFAGBMOFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6109B30", Offset = "0x6108530", VA = "0x186109B30")]
	public void BBFMMOJDOFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NLLLMHMNOLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct FNOLGBAADGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public IAENMLENEKB OCEEBKBNNMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public CKMHCCNBJAM DIAMFEMOIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int APJJIMDONBI;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CANFAEMEFLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public NLLLMHMNOLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public NLKDANNNGOD lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<FNOLGBAADGI> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public APEFKKOHFNF combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public CANFAEMEFLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6108500", Offset = "0x6106F00", VA = "0x186108500")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6108560", Offset = "0x6106F60", VA = "0x186108560")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6108590", Offset = "0x6106F90", VA = "0x186108590")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int[] AOCKLIDHPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private ICHAPIOFHKI ONENAOJLAFE;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static Matrix4x4 ILIPIFCFBML;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh BGNHMDFBFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6DFB30", VA = "0x1806E1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int MFDKOCIJFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x765410", Offset = "0x763E10", VA = "0x180765410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6112A90", Offset = "0x6111490", VA = "0x186112A90")]
	public void DOGCJDHLEOL(List<CKMHCCNBJAM> BIHICPNMMPB, Matrix4x4[] EHAGJKHKLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6112D50", Offset = "0x6111750", VA = "0x186112D50")]
	public static List<NLLLMHMNOLD> GANMJPNFBJN(List<CGECJNDCAAL> CBHCNPLFALD, NLKDANNNGOD KGLBJJDFAOB, Bounds NFOBGIKPBLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x61125A0", Offset = "0x6110FA0", VA = "0x1861125A0")]
	private JobHandle CADOPNIECHO(APEFKKOHFNF KDFBHDMAHMM, int PMKFBBBBGOP, int DCFFGHBFECJ, NLKDANNNGOD KGLBJJDFAOB, List<FNOLGBAADGI> PIHDAJGKHON)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6112980", Offset = "0x6111380", VA = "0x186112980")]
	private void DGCAHOAGNBF(List<FNOLGBAADGI> PIHDAJGKHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x61134B0", Offset = "0x6111EB0", VA = "0x1861134B0")]
	private NLLLMHMNOLD(List<FNOLGBAADGI> PIHDAJGKHON, int PMKFBBBBGOP, int DCFFGHBFECJ, NLKDANNNGOD KGLBJJDFAOB, Bounds NFOBGIKPBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6112CC0", Offset = "0x61116C0", VA = "0x186112CC0", Slot = "4")]
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
		private MaterialPropertyBlock DJINHDPEOFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private NLLLMHMNOLD ADOLPJCBALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<CKMHCCNBJAM> CGKKHILCIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private RenderTexture KGAAKBPDKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private ComputeBuffer GKNIHJEBIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private ComputeShader JJPLCELKKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Matrix4x4[] LELECKNIHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private int HHEEJEOMLEN;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer NGBLAMMLFKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x6E1140", Offset = "0x6DFB40", VA = "0x1806E1140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int HNEDIACNNMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x61162E0", Offset = "0x6114CE0", VA = "0x1861162E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6115880", Offset = "0x6114280", VA = "0x186115880")]
		public static List<SkinnedShapeRenderer> Create(GameObject OFMDHDILEHM, List<NLLLMHMNOLD> AHEGEMIDBPM, List<CKMHCCNBJAM> CGKKHILCIKH, Material JLAFBAMDDLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6115C90", Offset = "0x6114690", VA = "0x186115C90")]
		public void Init(NLLLMHMNOLD ADOLPJCBALB, List<CKMHCCNBJAM> CGKKHILCIKH, Material JLAFBAMDDLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6116230", Offset = "0x6114C30", VA = "0x186116230")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6116180", Offset = "0x6114B80", VA = "0x186116180")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6116140", Offset = "0x6114B40", VA = "0x186116140")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6115650", Offset = "0x6114050", VA = "0x186115650")]
		private void AHKJJIMANML(ScriptableRenderContext CGFEOLDGFLJ, Camera[] IELOPJAMAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6115AD0", Offset = "0x61144D0", VA = "0x186115AD0")]
		private void DOGCJDHLEOL(CommandBuffer PKJJIPAGLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	internal class _RRAssemblyIndex : NMOBLBLJIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6116410", Offset = "0x6114E10", VA = "0x186116410", Slot = "4")]
		public sealed override void DBHAPDCLOEH()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x610F800", Offset = "0x610E200", VA = "0x18610F800")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x610F4B0", Offset = "0x610DEB0", VA = "0x18610F4B0")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
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
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
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
