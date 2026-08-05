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
public enum DMBEBKDKNBO
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
public static class NHIEPIADBLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5849930", Offset = "0x5848130", VA = "0x185849930")]
	public static bool EAIEGBMPMPL(this DMBEBKDKNBO ACKCLCGBOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5849950", Offset = "0x5848150", VA = "0x185849950")]
	public static bool HFDOEDBCBEB(this DMBEBKDKNBO ACKCLCGBOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5849960", Offset = "0x5848160", VA = "0x185849960")]
	public static bool LGKKAMNILLB(this DMBEBKDKNBO ACKCLCGBOIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IMLBBKFCDOI
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
public enum OJDIIHFMAMI
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
public enum PBIKJFDGJLJ
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
public enum EBHLOKBBIHI
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
public class PDFDPAHLIKE : BGDNJDKNIFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte ENAGBODDNAM = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte IALDPFJEKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] IAHGJFHBODC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AJEOPDAGMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D5010", Offset = "0x6D3810", VA = "0x1806D5010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71ED10", Offset = "0x71D510", VA = "0x18071ED10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ABGMBOBBKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D90", Offset = "0x6F4590", VA = "0x1806F5D90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86DCE0", Offset = "0x86C4E0", VA = "0x18086DCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float JNIEFOKAFCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x139CAA0", Offset = "0x139B2A0", VA = "0x18139CAA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x15BE8A0", Offset = "0x15BD0A0", VA = "0x1815BE8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float PCBINNONPLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x10D0450", Offset = "0x10CEC50", VA = "0x1810D0450", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1920CF0", Offset = "0x191F4F0", VA = "0x181920CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> INKCBMDLLJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5849E90", Offset = "0x5848690", VA = "0x185849E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> ECDACKBBJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5849E50", Offset = "0x5848650", VA = "0x185849E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject GOKJGEHOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x76DB00", Offset = "0x76C300", VA = "0x18076DB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte IFLDFKJGMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5849A70", Offset = "0x5848270", VA = "0x185849A70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5849EF0", Offset = "0x58486F0", VA = "0x185849EF0")]
	public PDFDPAHLIKE(List<EKJCJGJOJCC> HHMGDIBPEOJ, List<EKJCJGJOJCC> IAEAMBGIIND, List<GNOFIMAGKIC> JNHJIHHGGKN, Material IOFAEFNPIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5849D40", Offset = "0x5848540", VA = "0x185849D40")]
	private int ELNAGBLMPPB(List<EKJCJGJOJCC> IEALKEJFNLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5849AC0", Offset = "0x58482C0", VA = "0x185849AC0")]
	private void DKIDEDFDBEC(int MKHJJEKGEKN, bool NBJFHLJMABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5849990", Offset = "0x5848190", VA = "0x185849990")]
	public void ACFNIBLJOHF(Vector3 JNBMJLNGOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5849C10", Offset = "0x5848410", VA = "0x185849C10", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5849A30", Offset = "0x5848230", VA = "0x185849A30")]
	public void CGBPAEKDNLN(Transform LNFDBFPNJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LMKFAMLIINE : PBJEDJAKNOC, DPPPOICKCAK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FLCJLEAILJM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LMKFAMLIINE <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8B0110", Offset = "0x8AE910", VA = "0x1808B0110")]
		[DebuggerHidden]
		public FLCJLEAILJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x583F5A0", Offset = "0x583DDA0", VA = "0x18583F5A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x583F070", Offset = "0x583D870", VA = "0x18583F070", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x583F6A0", Offset = "0x583DEA0", VA = "0x18583F6A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x583F6F0", Offset = "0x583DEF0", VA = "0x18583F6F0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x583F740", Offset = "0x583DF40", VA = "0x18583F740")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x583F560", Offset = "0x583DD60", VA = "0x18583F560", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x583F4C0", Offset = "0x583DCC0", VA = "0x18583F4C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x583F4C0", Offset = "0x583DCC0", VA = "0x18583F4C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KNMOFJFOIFL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LMKFAMLIINE <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B0110", Offset = "0x8AE910", VA = "0x1808B0110")]
		[DebuggerHidden]
		public KNMOFJFOIFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5843B20", Offset = "0x5842320", VA = "0x185843B20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5843760", Offset = "0x5841F60", VA = "0x185843760", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5843C00", Offset = "0x5842400", VA = "0x185843C00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5843C50", Offset = "0x5842450", VA = "0x185843C50")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5843AE0", Offset = "0x58422E0", VA = "0x185843AE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5843A40", Offset = "0x5842240", VA = "0x185843A40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5843A40", Offset = "0x5842240", VA = "0x185843A40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly MHKPGKEAEHE GJOJHJJLDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<HFLPNJCMFLL> PPNPFANHEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> JCFICEBOJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer PGBHGINLHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool DIPCMIAHJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool DAIDJFEEIIA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<BBEGNJBFPNC> OHNCHOAJFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EFIFLCOCEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5845280", Offset = "0x5843A80", VA = "0x185845280", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GNOFIMAGKIC CMFHABDLBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5844CD0", Offset = "0x58434D0", VA = "0x185844CD0", Slot = "7")]
		get
		{
			return default(GNOFIMAGKIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> MAIKALFDOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6DC590", Offset = "0x6DAD90", VA = "0x1806DC590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5845040", Offset = "0x5843840", VA = "0x185845040")]
	private bool KILOFEPDGGO(HFLPNJCMFLL FHKEOGEMJLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5844790", Offset = "0x5842F90", VA = "0x185844790")]
	private static bool CKEFGOMEEPH(HFLPNJCMFLL FHKEOGEMJLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x58458C0", Offset = "0x58440C0", VA = "0x1858458C0")]
	public LMKFAMLIINE(MHKPGKEAEHE LBEMEOBAAJI, bool OHJHHIGDKGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5844DA0", Offset = "0x58435A0", VA = "0x185844DA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x58450D0", Offset = "0x58438D0", VA = "0x1858450D0")]
	public void LGCDELLOPGJ(HFLPNJCMFLL FHKEOGEMJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x58441E0", Offset = "0x58429E0", VA = "0x1858441E0")]
	public void ALIFOBNBCOA(HFLPNJCMFLL FHKEOGEMJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5845350", Offset = "0x5843B50", VA = "0x185845350", Slot = "4")]
	public void OOOALJOLDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5844540", Offset = "0x5842D40", VA = "0x185844540")]
	public void CEKLEBHDAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x58443B0", Offset = "0x5842BB0", VA = "0x1858443B0")]
	private void BHBBDAGLFEF(List<HFLPNJCMFLL> PPNPFANHEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5844040", Offset = "0x5842840", VA = "0x185844040")]
	private static Material ICJJIGHCDDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5844310", Offset = "0x5842B10", VA = "0x185844310")]
	private void BHBBDAGLFEF(HFLPNJCMFLL FHKEOGEMJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5844F70", Offset = "0x5843770", VA = "0x185844F70")]
	private void HCMMNDBOLHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x58447B0", Offset = "0x5842FB0", VA = "0x1858447B0")]
	public void CLNIPJBDEAA(bool PDNBIIOMDAI, bool DCLGJKNPJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x58452C0", Offset = "0x5843AC0", VA = "0x1858452C0")]
	protected void NALDGNGGHKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5844F00", Offset = "0x5843700", VA = "0x185844F00")]
	[IteratorStateMachine(typeof(FLCJLEAILJM))]
	public IEnumerable<Renderer> HAOADCKANEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5845060", Offset = "0x5843860", VA = "0x185845060")]
	[IteratorStateMachine(typeof(KNMOFJFOIFL))]
	public IEnumerable<Renderer> LCHOKDABLMP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class DLPDJKFHBLC : HFLPNJCMFLL
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private struct DCELOLFKMFN : GCNFDEAMGJL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private LOJLFJAMGGP AGOOLBLGOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private JobHandle DOPBMBDFIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private IAHMPKIHKOG APLABNLFNEK;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x583C670", Offset = "0x583AE70", VA = "0x18583C670")]
		public DCELOLFKMFN(LOJLFJAMGGP AGOOLBLGOGP, JobHandle DOPBMBDFIJE, IAHMPKIHKOG APLABNLFNEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5B0", Offset = "0x8F8DB0", VA = "0x1808FA5B0")]
		public bool IMLDPEBIIKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x583C640", Offset = "0x583AE40", VA = "0x18583C640", Slot = "4")]
		public LOJLFJAMGGP MNPDJHGOCNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x583C5F0", Offset = "0x583ADF0", VA = "0x18583C5F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly MOKDLNGCAFN CGJMHOKHCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private float FNPJBEDBGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Hash128 PAIJIGNOCBJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 LEHLPPIKIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x583CA80", Offset = "0x583B280", VA = "0x18583CA80", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x583DC50", Offset = "0x583C450", VA = "0x18583DC50")]
	public DLPDJKFHBLC(LMKFAMLIINE FECENBBKPOP, MOKDLNGCAFN LBEMEOBAAJI, bool OHJHHIGDKGO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "16")]
	public override bool BOMOLNELLGA(GNOFIMAGKIC FECENBBKPOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x583C890", Offset = "0x583B090", VA = "0x18583C890", Slot = "18")]
	public override int ELNAGBLMPPB(HOBLAAJGECK GFJLMBJPDAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x583DA60", Offset = "0x583C260", VA = "0x18583DA60", Slot = "19")]
	public override int POOADLDFLNC(HOBLAAJGECK GFJLMBJPDAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x583CC80", Offset = "0x583B480", VA = "0x18583CC80", Slot = "20")]
	public override void JLJFKDEACFC(HOBLAAJGECK GFJLMBJPDAG, OACFEHDCOAB ILFHILHBDNE, int DNGPOJJFEDI = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x583CBB0", Offset = "0x583B3B0", VA = "0x18583CBB0", Slot = "21")]
	public override GNOFIMAGKIC ILPEICCBMJP()
	{
		return default(GNOFIMAGKIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x583C6D0", Offset = "0x583AED0", VA = "0x18583C6D0", Slot = "23")]
	public override KCEPHBLMBIH CEHFBEDKILP()
	{
		return default(KCEPHBLMBIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x583D360", Offset = "0x583BB60", VA = "0x18583D360", Slot = "24")]
	public override GCNFDEAMGJL MOCFFCGAOEI(HOBLAAJGECK GFJLMBJPDAG, JobHandle DOPBMBDFIJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct KBJCGONDJDK : global::DOCOAIDEBOB<KBJCGONDJDK>, NHMOKLKPBCB, IEquatable<KBJCGONDJDK>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int FPGJPBIHINK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x786E40", Offset = "0x785640", VA = "0x180786E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x786DB0", Offset = "0x7855B0", VA = "0x180786DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	[CreateProperty]
	public int JAFPKKDIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x89E550", Offset = "0x89CD50", VA = "0x18089E550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xDD7530", Offset = "0xDD5D30", VA = "0x180DD7530", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool HOFMIBPEMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x583F9B0", Offset = "0x583E1B0", VA = "0x18583F9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x276AFD0", Offset = "0x27697D0", VA = "0x18276AFD0", Slot = "8")]
	public bool Equals(KBJCGONDJDK HAKPJJGEGOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xCF3A50", Offset = "0xCF2250", VA = "0x180CF3A50")]
	public static bool GLPMECKCBFF(KBJCGONDJDK HDPOKDCLGGE, KBJCGONDJDK JBKIIGINOKM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4C7A540", Offset = "0x4C78D40", VA = "0x184C7A540")]
	public static bool PKJGEKBKGNO(KBJCGONDJDK HDPOKDCLGGE, KBJCGONDJDK JBKIIGINOKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x583F9F0", Offset = "0x583E1F0", VA = "0x18583F9F0", Slot = "0")]
	public override bool Equals(object BFHAMCLNCKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x786E40", Offset = "0x785640", VA = "0x180786E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x583FA80", Offset = "0x583E280", VA = "0x18583FA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum EFBKLPLINHO
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
public interface MHKPGKEAEHE
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	GNOFIMAGKIC DMMBNEDLFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	EFBKLPLINHO CLIHOGGLCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MAIPNBCAHBP : global::DOCOAIDEBOB<MAIPNBCAHBP>, NHMOKLKPBCB, IEquatable<MAIPNBCAHBP>
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int FPGJPBIHINK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x786E40", Offset = "0x785640", VA = "0x180786E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x786DB0", Offset = "0x7855B0", VA = "0x180786DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	[CreateProperty]
	public int JAFPKKDIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x89E550", Offset = "0x89CD50", VA = "0x18089E550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xDD7530", Offset = "0xDD5D30", VA = "0x180DD7530", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool HOFMIBPEMEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x58459B0", Offset = "0x58441B0", VA = "0x1858459B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x276AFD0", Offset = "0x27697D0", VA = "0x18276AFD0", Slot = "8")]
	public bool Equals(MAIPNBCAHBP HAKPJJGEGOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xCF3A50", Offset = "0xCF2250", VA = "0x180CF3A50")]
	public static bool GLPMECKCBFF(MAIPNBCAHBP HDPOKDCLGGE, MAIPNBCAHBP JBKIIGINOKM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4C7A540", Offset = "0x4C78D40", VA = "0x184C7A540")]
	public static bool PKJGEKBKGNO(MAIPNBCAHBP HDPOKDCLGGE, MAIPNBCAHBP JBKIIGINOKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x58459F0", Offset = "0x58441F0", VA = "0x1858459F0", Slot = "0")]
	public override bool Equals(object BFHAMCLNCKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x786E40", Offset = "0x785640", VA = "0x180786E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5845A80", Offset = "0x5844280", VA = "0x185845A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface INJNAFOHOOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool CDBKKHIFNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool IMGIAHGOAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	GNOFIMAGKIC DMMBNEDLFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float DAIIGNNFFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 ICOPFGCJHCB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	DMBEBKDKNBO AEMLAKHCEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IMLBBKFCDOI IEGHFJJGFMO
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
public interface HLMEIPBJKBL : INJNAFOHOOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	KBGBECBBHLF NHODBDHNHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool FBBGEHNPPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MOKDLNGCAFN : INJNAFOHOOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool BGBFOLIDPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool HKFOOKNIHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	float FJOEOFIPPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int EKLEDHMBACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool AFAAILFOFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int ONMGOLMODPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<PEAJILJIMBO> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HNOCPMFAEGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMCPNFONDJJ(KBJCGONDJDK FECENBBKPOP, PBIKJFDGJLJ KMBBOGPNPJD);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMCPNFONDJJ(MAIPNBCAHBP FHKEOGEMJLP, PBIKJFDGJLJ KMBBOGPNPJD);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGFJKBMKGEG(MAIPNBCAHBP FHKEOGEMJLP);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBJIIABMDDI(MAIPNBCAHBP FHKEOGEMJLP);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLCBCAIEFOD();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NODJPPLEGHN();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ICMMBPLJPOP(PBIKJFDGJLJ EHPFPOFFCEJ);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MHHGNDFALOC(KBJCGONDJDK FECENBBKPOP);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MHHGNDFALOC(MAIPNBCAHBP FHKEOGEMJLP);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GEEFMCLMOJH(KBJCGONDJDK FECENBBKPOP, EBHLOKBBIHI EHPFPOFFCEJ);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GEEFMCLMOJH(MAIPNBCAHBP FHKEOGEMJLP, EBHLOKBBIHI EHPFPOFFCEJ);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DPIIHDGLCOE(MAIPNBCAHBP FHKEOGEMJLP);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NEJHPAADNON(MAIPNBCAHBP FHKEOGEMJLP);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PNGCGCNGCML();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IIPNDIJJLKG();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MBCEDEIFMPK(EBHLOKBBIHI EHPFPOFFCEJ);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DONBCKOEOHL(KBJCGONDJDK FECENBBKPOP, Vector3 HCPFFBPADNN, Vector3 PFDFEONAMDE, Vector3 BIOMIHDPBGK, float KJLCDNLHEOL, float LKJNNPBLJDG, IReadOnlyList<Camera> CBBANAOEBJF, OJDIIHFMAMI IAIFILNHNNN);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DONBCKOEOHL(KOCFLEJAJKP DDJKFFNDNDL, Vector3 HCPFFBPADNN, Vector3 PFDFEONAMDE, Vector3 BIOMIHDPBGK, float KJLCDNLHEOL, float LKJNNPBLJDG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public interface CGMDPBMIELI
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	LMKFAMLIINE IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	HFLPNJCMFLL IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NFOEJLEHNKE IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FOFCNOLJMKI : CGMDPBMIELI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool IKFLFNHMGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KBJCGONDJDK NEDIGHFDAGB(MHKPGKEAEHE LBEMEOBAAJI);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KBJCGONDJDK NEDIGHFDAGB(MHKPGKEAEHE LBEMEOBAAJI, bool DDBALMHIIHH);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIFMKGJHCHO(KBJCGONDJDK FECENBBKPOP);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IBELBLBPKDO(KBJCGONDJDK FECENBBKPOP);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MAIPNBCAHBP CCIAENIEADE(KBJCGONDJDK FECENBBKPOP, HLMEIPBJKBL LBEMEOBAAJI);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MAIPNBCAHBP DMHLPODLNBN(KBJCGONDJDK FECENBBKPOP, MOKDLNGCAFN LBEMEOBAAJI);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MLCCELLHEDN(MAIPNBCAHBP FHKEOGEMJLP);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AGLLBENNNBN(MAIPNBCAHBP FHKEOGEMJLP);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KOCFLEJAJKP NPFBOAHFPOJ(OHONFCBGPDJ LBEMEOBAAJI);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HBBGAMCFNBP(KOCFLEJAJKP DDJKFFNDNDL);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PMHHKPNNEFB(KOCFLEJAJKP DDJKFFNDNDL);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task JKOJJCKBIFO();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task NEEDBEAGNHO();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task CPDPHBGJDIL();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AFKOFNDKBPL();

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	LOJLFJAMGGP CBBPOPKMMGM(GNOFIMAGKIC MAPHAHHOKFG, IEnumerable<MAIPNBCAHBP> PPNPFANHEHH, int KFBHMGBJHKG);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerable<Renderer> DONDLKHEEKG(KBJCGONDJDK FECENBBKPOP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KOCFLEJAJKP : global::DOCOAIDEBOB<KOCFLEJAJKP>, NHMOKLKPBCB, IEquatable<KOCFLEJAJKP>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int FPGJPBIHINK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x786E40", Offset = "0x785640", VA = "0x180786E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x786DB0", Offset = "0x7855B0", VA = "0x180786DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int JAFPKKDIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x89E550", Offset = "0x89CD50", VA = "0x18089E550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xDD7530", Offset = "0xDD5D30", VA = "0x180DD7530", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HOFMIBPEMEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5843CA0", Offset = "0x58424A0", VA = "0x185843CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x276AFD0", Offset = "0x27697D0", VA = "0x18276AFD0", Slot = "8")]
	public bool Equals(KOCFLEJAJKP HAKPJJGEGOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCF3A50", Offset = "0xCF2250", VA = "0x180CF3A50")]
	public static bool GLPMECKCBFF(KOCFLEJAJKP HDPOKDCLGGE, KOCFLEJAJKP JBKIIGINOKM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4C7A540", Offset = "0x4C78D40", VA = "0x184C7A540")]
	public static bool PKJGEKBKGNO(KOCFLEJAJKP HDPOKDCLGGE, KOCFLEJAJKP JBKIIGINOKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5843CE0", Offset = "0x58424E0", VA = "0x185843CE0", Slot = "0")]
	public override bool Equals(object BFHAMCLNCKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x786E40", Offset = "0x785640", VA = "0x180786E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OHONFCBGPDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	int GHCMPOKLKGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Transform BDGLNGNIJJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool LNMEIMICEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KBJCGONDJDK GetBone(int GHPFAMAMJED);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int GHPFAMAMJED);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public class KCMBIOCMGHP : FOFCNOLJMKI, CGMDPBMIELI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct PFPOJKPHEAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public KCMBIOCMGHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x584A8E0", Offset = "0x58490E0", VA = "0x18584A8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6DD320", Offset = "0x6DBB20", VA = "0x1806DD320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly global::NMAGGNFKDKP<KBJCGONDJDK, LMKFAMLIINE> JEHMHBGGJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly global::NMAGGNFKDKP<MAIPNBCAHBP, HFLPNJCMFLL> PPNPFANHEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly global::NMAGGNFKDKP<KOCFLEJAJKP, NFOEJLEHNKE> DOFBCKFJKCH;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LMKFAMLIINE IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5842230", Offset = "0x5840A30", VA = "0x185842230", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public HFLPNJCMFLL IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x58421D0", Offset = "0x58409D0", VA = "0x1858421D0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NFOEJLEHNKE IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5842170", Offset = "0x5840970", VA = "0x185842170", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool IKFLFNHMGLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FA0", Offset = "0x7C47A0", VA = "0x1807C5FA0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x78F190", Offset = "0x78D990", VA = "0x18078F190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5842380", Offset = "0x5840B80", VA = "0x185842380")]
	public KCMBIOCMGHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x58413E0", Offset = "0x583FBE0", VA = "0x1858413E0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5842000", Offset = "0x5840800", VA = "0x185842000", Slot = "4")]
	public KBJCGONDJDK NEDIGHFDAGB(MHKPGKEAEHE LBEMEOBAAJI)
	{
		return default(KBJCGONDJDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5841D60", Offset = "0x5840560", VA = "0x185841D60", Slot = "5")]
	public KBJCGONDJDK NEDIGHFDAGB(MHKPGKEAEHE LBEMEOBAAJI, bool OHJHHIGDKGO)
	{
		return default(KBJCGONDJDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x583FFA0", Offset = "0x583E7A0", VA = "0x18583FFA0", Slot = "6")]
	public void BIFMKGJHCHO(KBJCGONDJDK FECENBBKPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x58415E0", Offset = "0x583FDE0", VA = "0x1858415E0", Slot = "7")]
	public void IBELBLBPKDO(KBJCGONDJDK FECENBBKPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5840850", Offset = "0x583F050", VA = "0x185840850", Slot = "8")]
	public MAIPNBCAHBP CCIAENIEADE(KBJCGONDJDK FECENBBKPOP, HLMEIPBJKBL LBEMEOBAAJI)
	{
		return default(MAIPNBCAHBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5840E60", Offset = "0x583F660", VA = "0x185840E60", Slot = "9")]
	public MAIPNBCAHBP DMHLPODLNBN(KBJCGONDJDK FECENBBKPOP, MOKDLNGCAFN LBEMEOBAAJI)
	{
		return default(MAIPNBCAHBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x583FBA0", Offset = "0x583E3A0", VA = "0x18583FBA0", Slot = "11")]
	public void AGLLBENNNBN(MAIPNBCAHBP FHKEOGEMJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5841AE0", Offset = "0x58402E0", VA = "0x185841AE0", Slot = "10")]
	public void MLCCELLHEDN(MAIPNBCAHBP FHKEOGEMJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5841370", Offset = "0x583FB70", VA = "0x185841370", Slot = "21")]
	public IEnumerable<Renderer> DONDLKHEEKG(KBJCGONDJDK FECENBBKPOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5842290", Offset = "0x5840A90", VA = "0x185842290", Slot = "12")]
	public KOCFLEJAJKP NPFBOAHFPOJ(OHONFCBGPDJ LBEMEOBAAJI)
	{
		return default(KOCFLEJAJKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5842310", Offset = "0x5840B10", VA = "0x185842310", Slot = "14")]
	public void PMHHKPNNEFB(KOCFLEJAJKP DDJKFFNDNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5841970", Offset = "0x5840170", VA = "0x185841970", Slot = "16")]
	public Task JKOJJCKBIFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5842010", Offset = "0x5840810", VA = "0x185842010", Slot = "17")]
	public Task NEEDBEAGNHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5840D60", Offset = "0x583F560", VA = "0x185840D60", Slot = "18")]
	[AsyncStateMachine(typeof(PFPOJKPHEAO))]
	public Task CPDPHBGJDIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x583FB10", Offset = "0x583E310", VA = "0x18583FB10", Slot = "19")]
	public void AFKOFNDKBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5841580", Offset = "0x583FD80", VA = "0x185841580", Slot = "13")]
	public void HBBGAMCFNBP(KOCFLEJAJKP DDJKFFNDNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5840220", Offset = "0x583EA20", VA = "0x185840220", Slot = "20")]
	public LOJLFJAMGGP CBBPOPKMMGM(GNOFIMAGKIC FPGHGBHIIDF, IEnumerable<MAIPNBCAHBP> PPNPFANHEHH, int KFBHMGBJHKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class PMAMBEGILPJ : HFLPNJCMFLL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct NHBHEFIPIFF : GCNFDEAMGJL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private LOJLFJAMGGP AGOOLBLGOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private JobHandle DOPBMBDFIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private ELBBMIHADPH APLABNLFNEK;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x58498E0", Offset = "0x58480E0", VA = "0x1858498E0")]
		public NHBHEFIPIFF(LOJLFJAMGGP AGOOLBLGOGP, JobHandle DOPBMBDFIJE, ELBBMIHADPH APLABNLFNEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5B0", Offset = "0x8F8DB0", VA = "0x1808FA5B0")]
		public bool IMLDPEBIIKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x58498B0", Offset = "0x58480B0", VA = "0x1858498B0", Slot = "4")]
		public LOJLFJAMGGP MNPDJHGOCNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5849860", Offset = "0x5848060", VA = "0x185849860", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly HLMEIPBJKBL GDEADNDOKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int[] CGCPBCDNKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private float FNPJBEDBGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Hash128 PAIJIGNOCBJ;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override NFPCMOIALIP LBLOGKNBAGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x584C120", Offset = "0x584A920", VA = "0x18584C120", Slot = "17")]
		get
		{
			return default(NFPCMOIALIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private Vector3 PINAIJMOMAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x584AD80", Offset = "0x5849580", VA = "0x18584AD80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected override Hash128 LEHLPPIKIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x584B7B0", Offset = "0x5849FB0", VA = "0x18584B7B0", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x584CE30", Offset = "0x584B630", VA = "0x18584CE30")]
	public PMAMBEGILPJ(LMKFAMLIINE FECENBBKPOP, HLMEIPBJKBL LBEMEOBAAJI, bool JMFODPFKHHK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x584B0D0", Offset = "0x58498D0", VA = "0x18584B0D0", Slot = "16")]
	public override bool BOMOLNELLGA(GNOFIMAGKIC FECENBBKPOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x584B700", Offset = "0x5849F00", VA = "0x18584B700", Slot = "18")]
	public override int ELNAGBLMPPB(HOBLAAJGECK GFJLMBJPDAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x584CD80", Offset = "0x584B580", VA = "0x18584CD80", Slot = "19")]
	public override int POOADLDFLNC(HOBLAAJGECK GFJLMBJPDAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x584CAD0", Offset = "0x584B2D0", VA = "0x18584CAD0")]
	private int ODCANLMLFJG(HOBLAAJGECK GFJLMBJPDAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x584B9B0", Offset = "0x584A1B0", VA = "0x18584B9B0", Slot = "20")]
	public override void JLJFKDEACFC(HOBLAAJGECK GFJLMBJPDAG, OACFEHDCOAB ILFHILHBDNE, int DNGPOJJFEDI = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x584B8E0", Offset = "0x584A0E0", VA = "0x18584B8E0", Slot = "21")]
	public override GNOFIMAGKIC ILPEICCBMJP()
	{
		return default(GNOFIMAGKIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x584B540", Offset = "0x5849D40", VA = "0x18584B540", Slot = "23")]
	public override KCEPHBLMBIH CEHFBEDKILP()
	{
		return default(KCEPHBLMBIH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x584C4D0", Offset = "0x584ACD0", VA = "0x18584C4D0", Slot = "24")]
	public override GCNFDEAMGJL MOCFFCGAOEI(HOBLAAJGECK GFJLMBJPDAG, JobHandle DOPBMBDFIJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AMLCPDHDMKH
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOAOOENKGHA(EBHLOKBBIHI EHPFPOFFCEJ, Renderer KCFPMLMHLJL, int JOEOFDLFGEF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EDODGPJAKBB(Renderer KCFPMLMHLJL, OJDIIHFMAMI IAIFILNHNNN, Vector3 HCPFFBPADNN, Vector3 PFDFEONAMDE, Vector3 BIOMIHDPBGK, float KJLCDNLHEOL, float LKJNNPBLJDG, float OKCEMJBCGJE = -1f, [Optional] Color? LCCPJBCAOGP, [Optional] IReadOnlyList<Camera> GFOBHMMJLBO);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFCHIGBBPKL(Renderer KCFPMLMHLJL, int JOEOFDLFGEF);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OENCKKMFOOA();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MKBAGMJLHPD(int JIMGBOMGJNF, PBIKJFDGJLJ EHPFPOFFCEJ, Renderer KCFPMLMHLJL, int JOEOFDLFGEF);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MMAMLPFIDNA : HNOCPMFAEGI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class EPDMAPNFGLD : global::BBNEDILFCDH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x583F020", Offset = "0x583D820", VA = "0x18583F020")]
		public EPDMAPNFGLD(string LOIAMCEJAFO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly AMLCPDHDMKH FPEEBNBBNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly CGMDPBMIELI ENOFJOHOCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MeshRenderer LMBCEFOHAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private EPDMAPNFGLD CMCMEAIPMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool GMEDEEGEIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MeshRenderer NJNLGPNDDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private EPDMAPNFGLD FKFOOBDDKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool DCNIHIAOMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private MeshRenderer IIMJEENFJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private EPDMAPNFGLD ACEEINEBCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool KFGNFGMLOIE;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6D56E0", Offset = "0x6D3EE0", VA = "0x1806D56E0")]
	public MMAMLPFIDNA(AMLCPDHDMKH GOCCJCEPNBI, CGMDPBMIELI ENOFJOHOCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5846D20", Offset = "0x5845520", VA = "0x185846D20", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5848050", Offset = "0x5846850", VA = "0x185848050")]
	private void OHNJCCJHNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5845FF0", Offset = "0x58447F0", VA = "0x185845FF0", Slot = "4")]
	public void BMCPNFONDJJ(KBJCGONDJDK FECENBBKPOP, PBIKJFDGJLJ KMBBOGPNPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x58461F0", Offset = "0x58449F0", VA = "0x1858461F0", Slot = "5")]
	public void BMCPNFONDJJ(MAIPNBCAHBP FHKEOGEMJLP, PBIKJFDGJLJ KMBBOGPNPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5845EC0", Offset = "0x58446C0", VA = "0x185845EC0", Slot = "6")]
	public void BGFJKBMKGEG(MAIPNBCAHBP FHKEOGEMJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x58479A0", Offset = "0x58461A0", VA = "0x1858479A0", Slot = "7")]
	public void MBJIIABMDDI(MAIPNBCAHBP FHKEOGEMJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5847140", Offset = "0x5845940", VA = "0x185847140", Slot = "8")]
	public void FLCBCAIEFOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x18079C0", Offset = "0x18061C0", VA = "0x1818079C0", Slot = "9")]
	public void NODJPPLEGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x58476F0", Offset = "0x5845EF0", VA = "0x1858476F0", Slot = "10")]
	public void ICMMBPLJPOP(PBIKJFDGJLJ KMBBOGPNPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5847E10", Offset = "0x5846610", VA = "0x185847E10", Slot = "11")]
	public void MHHGNDFALOC(KBJCGONDJDK FECENBBKPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5847AC0", Offset = "0x58462C0", VA = "0x185847AC0", Slot = "12")]
	public void MHHGNDFALOC(MAIPNBCAHBP FHKEOGEMJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5847370", Offset = "0x5845B70", VA = "0x185847370", Slot = "13")]
	public void GEEFMCLMOJH(KBJCGONDJDK FECENBBKPOP, EBHLOKBBIHI EHPFPOFFCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5847180", Offset = "0x5845980", VA = "0x185847180", Slot = "14")]
	public void GEEFMCLMOJH(MAIPNBCAHBP FHKEOGEMJLP, EBHLOKBBIHI EHPFPOFFCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x58482A0", Offset = "0x5846AA0", VA = "0x1858482A0", Slot = "17")]
	public void PNGCGCNGCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5846C80", Offset = "0x5845480", VA = "0x185846C80", Slot = "15")]
	public void DPIIHDGLCOE(MAIPNBCAHBP FHKEOGEMJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5847FC0", Offset = "0x58467C0", VA = "0x185847FC0", Slot = "16")]
	public void NEJHPAADNON(MAIPNBCAHBP FHKEOGEMJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x10E4BF0", Offset = "0x10E33F0", VA = "0x1810E4BF0", Slot = "18")]
	public void IIPNDIJJLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5847860", Offset = "0x5846060", VA = "0x185847860", Slot = "19")]
	public void MBCEDEIFMPK(EBHLOKBBIHI EHPFPOFFCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5846EF0", Offset = "0x58456F0", VA = "0x185846EF0")]
	private void FCOCELMHOEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5847530", Offset = "0x5845D30", VA = "0x185847530")]
	public void GEEFMCLMOJH(MAIPNBCAHBP FHKEOGEMJLP, EBHLOKBBIHI EHPFPOFFCEJ, bool HHCAECEHGIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5846410", Offset = "0x5844C10", VA = "0x185846410")]
	private void BOAOOENKGHA(EBHLOKBBIHI EHPFPOFFCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5846900", Offset = "0x5845100", VA = "0x185846900", Slot = "20")]
	public void DONBCKOEOHL(KBJCGONDJDK FECENBBKPOP, Vector3 HCPFFBPADNN, Vector3 PFDFEONAMDE, Vector3 BIOMIHDPBGK, float KJLCDNLHEOL, float LKJNNPBLJDG, IReadOnlyList<Camera> CBBANAOEBJF, OJDIIHFMAMI IAIFILNHNNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x58464E0", Offset = "0x5844CE0", VA = "0x1858464E0", Slot = "21")]
	public void DONBCKOEOHL(KOCFLEJAJKP DDJKFFNDNDL, Vector3 HCPFFBPADNN, Vector3 PFDFEONAMDE, Vector3 BIOMIHDPBGK, float KJLCDNLHEOL, float LKJNNPBLJDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KELEFCIIEMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool GDPGJPIBAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material BBCKDGFNFNB();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material ICJJIGHCDDG();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material AECGHKEHPML();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NHMDBMOGMLP(DMBEBKDKNBO ACKCLCGBOIC);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IHELPKOEKNM(IMLBBKFCDOI JDLJINGJKCK);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EGEEPBLPCGD(GameObject BFHAMCLNCKB);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ELBLBBNLLEP(GameObject BFHAMCLNCKB, bool AHNGCOMIDPA);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KODBJDOLKDE
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static KELEFCIIEMJ GFNHGDEEEEL;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static bool GDPGJPIBAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5844110", Offset = "0x5842910", VA = "0x185844110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5843E30", Offset = "0x5842630", VA = "0x185843E30")]
	public static void DPNHMLPABKL(KELEFCIIEMJ GMMDMKJFEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5843DD0", Offset = "0x58425D0", VA = "0x185843DD0")]
	public static Material BBCKDGFNFNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5844040", Offset = "0x5842840", VA = "0x185844040")]
	public static Material ICJJIGHCDDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5843D70", Offset = "0x5842570", VA = "0x185843D70")]
	public static Material AECGHKEHPML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5844170", Offset = "0x5842970", VA = "0x185844170")]
	public static int NHMDBMOGMLP(DMBEBKDKNBO ACKCLCGBOIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x58440A0", Offset = "0x58428A0", VA = "0x1858440A0")]
	public static int IHELPKOEKNM(IMLBBKFCDOI JDLJINGJKCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5843E80", Offset = "0x5842680", VA = "0x185843E80")]
	public static void EGEEPBLPCGD(GameObject BFHAMCLNCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5843F50", Offset = "0x5842750", VA = "0x185843F50")]
	public static void ELBLBBNLLEP(GameObject BFHAMCLNCKB, bool AHNGCOMIDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class HFLPNJCMFLL : HAINLABEMAM, BBEGNJBFPNC, HEAPKFIAFGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly LMKFAMLIINE GOKJGEHOFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected Bounds DLIAJIEJMNH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Bounds PNPPFNDFBDF
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xFD8070", Offset = "0xFD6870", VA = "0x180FD8070", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public virtual NFPCMOIALIP LBLOGKNBAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x583F920", Offset = "0x583E120", VA = "0x18583F920", Slot = "17")]
		get
		{
			return default(NFPCMOIALIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool DAIDJFEEIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6D5030", Offset = "0x6D3830", VA = "0x1806D5030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA3F830", Offset = "0xA3E030", VA = "0x180A3F830")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	protected abstract Hash128 LEHLPPIKIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int LBGGMFNADAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAA0", Offset = "0x6FA2A0", VA = "0x1806FBAA0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public KHPGENGNGCO PMMMHKDKIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6DC590", Offset = "0x6DAD90", VA = "0x1806DC590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool AFIMMOFGLLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x775C20", Offset = "0x774420", VA = "0x180775C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F40", Offset = "0x6D4740", VA = "0x1806D5F40")]
	protected HFLPNJCMFLL(LMKFAMLIINE FECENBBKPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x583F7F0", Offset = "0x583DFF0", VA = "0x18583F7F0", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "16")]
	public virtual bool BOMOLNELLGA(GNOFIMAGKIC FECENBBKPOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int ELNAGBLMPPB(HOBLAAJGECK GFJLMBJPDAG);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int POOADLDFLNC(HOBLAAJGECK GFJLMBJPDAG);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void JLJFKDEACFC(HOBLAAJGECK GFJLMBJPDAG, OACFEHDCOAB ILFHILHBDNE, int DNGPOJJFEDI = -1);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract GNOFIMAGKIC ILPEICCBMJP();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x583F790", Offset = "0x583DF90", VA = "0x18583F790", Slot = "11")]
	public Hash128 ADMLGJLKNKN(int GFJLMBJPDAG)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract KCEPHBLMBIH CEHFBEDKILP();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract GCNFDEAMGJL MOCFFCGAOEI(HOBLAAJGECK GFJLMBJPDAG, JobHandle DOPBMBDFIJE);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x583F7C0", Offset = "0x583DFC0", VA = "0x18583F7C0", Slot = "10")]
	public GCNFDEAMGJL CBBPOPKMMGM(int GFJLMBJPDAG)
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
		[Cpp2IlInjected.Address(RVA = "0x584CEE0", Offset = "0x584B6E0", VA = "0x18584CEE0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum KBGBECBBHLF
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
public static class KNLPHEJEHAH
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class BNJHAIHOIOP : IEnumerable<IDBKFLIOGEP>, IEnumerable, IEnumerator<IDBKFLIOGEP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private IDBKFLIOGEP <>2__current;

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
		private IDBKFLIOGEP System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8B0110", Offset = "0x8AE910", VA = "0x1808B0110")]
		[DebuggerHidden]
		public BNJHAIHOIOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x583C260", Offset = "0x583AA60", VA = "0x18583C260", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x583C3D0", Offset = "0x583ABD0", VA = "0x18583C3D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x583C340", Offset = "0x583AB40", VA = "0x18583C340", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IDBKFLIOGEP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x583C340", Offset = "0x583AB40", VA = "0x18583C340", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public const int CDFJONBNLNC = 3;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static IDBKFLIOGEP[][] FPIFGAPPJOA;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static PLHJEAINKAK CEIFIKPHBDJ;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static ShapeRendererConfig NHAEHKJINFH;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static ComputeShader FBCMBEADJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5842920", Offset = "0x5841120", VA = "0x185842920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static SkinnedShapeRenderer CHMCAAGFGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5842D20", Offset = "0x5841520", VA = "0x185842D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5842840", Offset = "0x5841040", VA = "0x185842840")]
	public static Mesh CODIBLNKDKE(KBGBECBBHLF PAINJGCCHGN, int GFJLMBJPDAG = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5842900", Offset = "0x5841100", VA = "0x185842900")]
	public static int DICMPICEFAH(KBGBECBBHLF PAINJGCCHGN, int GFJLMBJPDAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5842BC0", Offset = "0x58413C0", VA = "0x185842BC0")]
	public static PLHJEAINKAK JNLKGACAAHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x58429B0", Offset = "0x58411B0", VA = "0x1858429B0")]
	[IteratorStateMachine(typeof(BNJHAIHOIOP))]
	private static IEnumerable<IDBKFLIOGEP> GDCAIIJFBPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5843360", Offset = "0x5841B60", VA = "0x185843360")]
	public static IDBKFLIOGEP PLBGNLBOPMB(KBGBECBBHLF PAINJGCCHGN, int GFJLMBJPDAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5842990", Offset = "0x5841190", VA = "0x185842990")]
	public static bool FDJOJGKAPGH(this KBGBECBBHLF PAINJGCCHGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5842A10", Offset = "0x5841210", VA = "0x185842A10")]
	public static void HPCCHGIDCNA(KBGBECBBHLF PAINJGCCHGN, float3 OODKEKJGCNG, out FEBEGOIMMDM AJOOPNHJAMA, out float3 HBAFHGGCAME, out float INCHKLCJLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5842FB0", Offset = "0x58417B0", VA = "0x185842FB0")]
	public static void NHFNINMAKOO(Vector3 OODKEKJGCNG, KBGBECBBHLF PAINJGCCHGN, out Vector3 HBAFHGGCAME, out float INCHKLCJLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5842910", Offset = "0x5841110", VA = "0x185842910")]
	[GHKHCFMPNPN(HCEJJADFNPJ.ExitingPlayMode, 0)]
	private static void EEODDPBBMNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5842D90", Offset = "0x5841590", VA = "0x185842D90")]
	[GHKHCFMPNPN(HCEJJADFNPJ.ExitingPlayMode, 0)]
	private static void NCCIAJCGCBD()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[DefaultMember("Item")]
	[IECCMKJMAAC(LAEALBOAPLI.ShapeRendering)]
	public class ShapeRendererManager : FOFCNOLJMKI, CGMDPBMIELI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly global::NMAGGNFKDKP<KBJCGONDJDK, LMKFAMLIINE> JEHMHBGGJOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly global::NMAGGNFKDKP<MAIPNBCAHBP, HFLPNJCMFLL> PPNPFANHEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly global::NMAGGNFKDKP<KOCFLEJAJKP, NFOEJLEHNKE> DOFBCKFJKCH;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public LMKFAMLIINE IOEJBJHPAFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x584DB50", Offset = "0x584C350", VA = "0x18584DB50", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public HFLPNJCMFLL IOEJBJHPAFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x584DBB0", Offset = "0x584C3B0", VA = "0x18584DBB0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public NFOEJLEHNKE IOEJBJHPAFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x584DAF0", Offset = "0x584C2F0", VA = "0x18584DAF0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool IKFLFNHMGLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x7C5FA0", Offset = "0x7C47A0", VA = "0x1807C5FA0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x78F190", Offset = "0x78D990", VA = "0x18078F190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x584DD50", Offset = "0x584C550", VA = "0x18584DD50")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x584D750", Offset = "0x584BF50", VA = "0x18584D750", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x584D980", Offset = "0x584C180", VA = "0x18584D980", Slot = "4")]
		public KBJCGONDJDK NEDIGHFDAGB(MHKPGKEAEHE LBEMEOBAAJI)
		{
			return default(KBJCGONDJDK);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x584D980", Offset = "0x584C180", VA = "0x18584D980", Slot = "5")]
		public KBJCGONDJDK NEDIGHFDAGB(MHKPGKEAEHE LBEMEOBAAJI, bool OHJHHIGDKGO)
		{
			return default(KBJCGONDJDK);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x584CFA0", Offset = "0x584B7A0", VA = "0x18584CFA0", Slot = "6")]
		public void BIFMKGJHCHO(KBJCGONDJDK FECENBBKPOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x584D840", Offset = "0x584C040", VA = "0x18584D840", Slot = "7")]
		public void IBELBLBPKDO(KBJCGONDJDK FECENBBKPOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x584D400", Offset = "0x584BC00", VA = "0x18584D400", Slot = "8")]
		public MAIPNBCAHBP CCIAENIEADE(KBJCGONDJDK FECENBBKPOP, HLMEIPBJKBL LBEMEOBAAJI)
		{
			return default(MAIPNBCAHBP);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x584D5A0", Offset = "0x584BDA0", VA = "0x18584D5A0", Slot = "9")]
		public MAIPNBCAHBP DMHLPODLNBN(KBJCGONDJDK FECENBBKPOP, MOKDLNGCAFN LBEMEOBAAJI)
		{
			return default(MAIPNBCAHBP);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x584CF10", Offset = "0x584B710", VA = "0x18584CF10", Slot = "11")]
		public void AGLLBENNNBN(MAIPNBCAHBP FHKEOGEMJLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x584D920", Offset = "0x584C120", VA = "0x18584D920", Slot = "10")]
		public void MLCCELLHEDN(MAIPNBCAHBP FHKEOGEMJLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x584D6E0", Offset = "0x584BEE0", VA = "0x18584D6E0", Slot = "21")]
		public IEnumerable<Renderer> DONDLKHEEKG(KBJCGONDJDK FECENBBKPOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x584DC10", Offset = "0x584C410", VA = "0x18584DC10", Slot = "12")]
		public KOCFLEJAJKP NPFBOAHFPOJ(OHONFCBGPDJ LBEMEOBAAJI)
		{
			return default(KOCFLEJAJKP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x584DC90", Offset = "0x584C490", VA = "0x18584DC90", Slot = "14")]
		public void PMHHKPNNEFB(KOCFLEJAJKP DDJKFFNDNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x584D8C0", Offset = "0x584C0C0", VA = "0x18584D8C0", Slot = "16")]
		public Task JKOJJCKBIFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x584DA90", Offset = "0x584C290", VA = "0x18584DA90", Slot = "17")]
		public Task NEEDBEAGNHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x584D540", Offset = "0x584BD40", VA = "0x18584D540", Slot = "18")]
		public Task CPDPHBGJDIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2D40A40", Offset = "0x2D3F240", VA = "0x182D40A40", Slot = "19")]
		public void AFKOFNDKBPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x584D7E0", Offset = "0x584BFE0", VA = "0x18584D7E0", Slot = "13")]
		public void HBBGAMCFNBP(KOCFLEJAJKP DDJKFFNDNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x584D000", Offset = "0x584B800", VA = "0x18584D000", Slot = "20")]
		public LOJLFJAMGGP CBBPOPKMMGM(GNOFIMAGKIC FPGHGBHIIDF, IEnumerable<MAIPNBCAHBP> PPNPFANHEHH, int KFBHMGBJHKG)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NFOEJLEHNKE : PBJEDJAKNOC
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class MHAJGLEGHOP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public NFOEJLEHNKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8B0110", Offset = "0x8AE910", VA = "0x1808B0110")]
		[DebuggerHidden]
		public MHAJGLEGHOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5845DF0", Offset = "0x58445F0", VA = "0x185845DF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5845B10", Offset = "0x5844310", VA = "0x185845B10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5845E70", Offset = "0x5844670", VA = "0x185845E70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5845DB0", Offset = "0x58445B0", VA = "0x185845DB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5845D10", Offset = "0x5844510", VA = "0x185845D10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5845D10", Offset = "0x5844510", VA = "0x185845D10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly OHONFCBGPDJ GBBJPPOLMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly CGMDPBMIELI ENOFJOHOCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private PDFDPAHLIKE EDOHOLCBLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private List<EKJCJGJOJCC> FOLFFFBCCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private List<EKJCJGJOJCC> EGLOBOAEMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private GameObject PHKMHIDPHKD;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x58495F0", Offset = "0x5847DF0", VA = "0x1858495F0")]
	public static NFOEJLEHNKE PFGKIIFHIBE(OHONFCBGPDJ LBEMEOBAAJI, CGMDPBMIELI ENOFJOHOCFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5849760", Offset = "0x5847F60", VA = "0x185849760")]
	private NFOEJLEHNKE(OHONFCBGPDJ LBEMEOBAAJI, CGMDPBMIELI ENOFJOHOCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5848630", Offset = "0x5846E30", VA = "0x185848630")]
	public void IPHJFMDKADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x58485C0", Offset = "0x5846DC0", VA = "0x1858485C0")]
	[IteratorStateMachine(typeof(MHAJGLEGHOP))]
	public IEnumerable<Renderer> HAOADCKANEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5848B10", Offset = "0x5847310", VA = "0x185848B10", Slot = "4")]
	public void OOOALJOLDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5848520", Offset = "0x5846D20", VA = "0x185848520")]
	private void FCGIHNOKADO(Vector3 JNBMJLNGOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x58482E0", Offset = "0x5846AE0", VA = "0x1858482E0")]
	public void CEKLEBHDAHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EKJCJGJOJCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct LNFANALLEAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public OACFEHDCOAB GGKIBJNIINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public GNOFIMAGKIC FJKHGOILFGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int PHALMBJPHJM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CHCPEIKHEFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public EKJCJGJOJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public HOBLAAJGECK lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public List<LNFANALLEAA> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public LOJLFJAMGGP combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public CHCPEIKHEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x583C410", Offset = "0x583AC10", VA = "0x18583C410")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x583C470", Offset = "0x583AC70", VA = "0x18583C470")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x583C4A0", Offset = "0x583ACA0", VA = "0x18583C4A0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int[] BIGACJPLHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private CECGACLIODI KLPIGDFAPGO;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static Matrix4x4 MGBBGEOMBNA;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Mesh KANKEOPJECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6F5130", Offset = "0x6F3930", VA = "0x1806F5130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int FBCBMLBLFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BD0", Offset = "0x6D53D0", VA = "0x1806D6BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x779430", Offset = "0x777C30", VA = "0x180779430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x583DEA0", Offset = "0x583C6A0", VA = "0x18583DEA0")]
	public void EIMGJPHNHEF(List<GNOFIMAGKIC> BHGBKMEPCPB, Matrix4x4[] CPKIDKAPKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x583E4B0", Offset = "0x583CCB0", VA = "0x18583E4B0")]
	public static List<EKJCJGJOJCC> OJONNLHFKNA(List<LMKFAMLIINE> GDHLDFHDCOJ, HOBLAAJGECK GFJLMBJPDAG, Bounds PALKMIEPCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x583E0D0", Offset = "0x583C8D0", VA = "0x18583E0D0")]
	private JobHandle HLKPPLALMKK(LOJLFJAMGGP KNBPBFFCNDI, int CNANFHDELPC, int JMDDMOHCBFJ, HOBLAAJGECK GFJLMBJPDAG, List<LNFANALLEAA> FOIPINOLHBA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x583DD00", Offset = "0x583C500", VA = "0x18583DD00")]
	private void CKNHELGMLGG(List<LNFANALLEAA> FOIPINOLHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x583EC10", Offset = "0x583D410", VA = "0x18583EC10")]
	private EKJCJGJOJCC(List<LNFANALLEAA> FOIPINOLHBA, int CNANFHDELPC, int JMDDMOHCBFJ, HOBLAAJGECK GFJLMBJPDAG, Bounds PALKMIEPCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x583DE10", Offset = "0x583C610", VA = "0x18583DE10", Slot = "4")]
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
		private MaterialPropertyBlock AMMAAFAGDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private EKJCJGJOJCC AGOOLBLGOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private List<GNOFIMAGKIC> JNHJIHHGGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private RenderTexture FHNNADCLMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private ComputeBuffer APGDLEJHFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private ComputeShader JGBLNKKHBGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Matrix4x4[] FBBANEBAABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int EBBICDGNDHE;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public MeshRenderer NDGFLCNNPGI
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6F5140", Offset = "0x6F3940", VA = "0x1806F5140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int GHCMPOKLKGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x584EDC0", Offset = "0x584D5C0", VA = "0x18584EDC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x584E130", Offset = "0x584C930", VA = "0x18584E130")]
		public static List<SkinnedShapeRenderer> Create(GameObject FECENBBKPOP, List<EKJCJGJOJCC> IEALKEJFNLL, List<GNOFIMAGKIC> JNHJIHHGGKN, Material IOFAEFNPIJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x584E770", Offset = "0x584CF70", VA = "0x18584E770")]
		public void Init(EKJCJGJOJCC AGOOLBLGOGP, List<GNOFIMAGKIC> JNHJIHHGGKN, Material IOFAEFNPIJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x584ED10", Offset = "0x584D510", VA = "0x18584ED10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x584EC60", Offset = "0x584D460", VA = "0x18584EC60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x584EC20", Offset = "0x584D420", VA = "0x18584EC20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x584E540", Offset = "0x584CD40", VA = "0x18584E540")]
		private void HCMOAFJNOJN(ScriptableRenderContext CDBJCAAPIOD, Camera[] MBPELJADCMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x584E380", Offset = "0x584CB80", VA = "0x18584E380")]
		private void EIMGJPHNHEF(CommandBuffer CDHGKAAAIIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	internal class _RRAssemblyIndex : PMFBNHDKHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x584F650", Offset = "0x584DE50", VA = "0x18584F650", Slot = "4")]
		public sealed override void JBLIKMGAHBK()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x584A600", Offset = "0x5848E00", VA = "0x18584A600")]
	private static string FEOGEGMPIMJ(byte[] JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x584A2B0", Offset = "0x5848AB0", VA = "0x18584A2B0")]
	public static string CIDKAEMCDOH(byte[] EBBNNMNMLOE, bool IGCCOAIPDPG)
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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
