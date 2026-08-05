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
public enum MDMEDPHADCD
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MJKCIEMGDGK
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<MDMEDPHADCD> HDGBPPAGDDJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4D6B8F0", Offset = "0x4D69EF0", VA = "0x184D6B8F0")]
	static MJKCIEMGDGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D6B8F0", Offset = "0x4D69EF0", VA = "0x184D6B8F0")]
	[FNKKLKDKNIM]
	private static void EDEIJCODOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D6B870", Offset = "0x4D69E70", VA = "0x184D6B870")]
	public static bool DOEKDMIKJLF(this MDMEDPHADCD MHFKJEDKOOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OOBOACMIFFP
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	PLACEHOLDER_16 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum BMJBCLIHHJC
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CLGAJAKBJCM
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	HoverXRay
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FHAKBFDBEAL
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CornerMove
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DMLFGDPLHJB : CPIKDOKDLIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private const byte BBPDEEDFECK = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private byte FGFPLKDFEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<SkinnedShapeRenderer>[] HHJOHCLMPNN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FHAKFKCCDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x560CD0", Offset = "0x55F2D0", VA = "0x180560CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A10", Offset = "0x5E0010", VA = "0x1805E1A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PLFDHIHAMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x560CC0", Offset = "0x55F2C0", VA = "0x180560CC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C4AD0", Offset = "0x6C30D0", VA = "0x1806C4AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float LJPKGLLODMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDA7BA0", Offset = "0xDA61A0", VA = "0x180DA7BA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF6BDA0", Offset = "0xF6A3A0", VA = "0x180F6BDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float MIDHLNAJEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDB6BB0", Offset = "0xDB51B0", VA = "0x180DB6BB0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDB6EC0", Offset = "0xDB54C0", VA = "0x180DB6EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> MFMCFEEDJKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4D63EC0", Offset = "0x4D624C0", VA = "0x184D63EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> HFLIIOCFDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4023E40", Offset = "0x4022440", VA = "0x184023E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject MPLJPEEIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x588A30", Offset = "0x587030", VA = "0x180588A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6818D0", Offset = "0x67FED0", VA = "0x1806818D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte JHBFPHJOBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4D63D80", Offset = "0x4D62380", VA = "0x184D63D80", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D641D0", Offset = "0x4D627D0", VA = "0x184D641D0")]
	public DMLFGDPLHJB(List<CIBJNAMBILP> ELNOACLDGIH, List<CIBJNAMBILP> KGKKFONFNEI, List<Transform> EFANHFEDCHD, Material AHGGGHMLBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D63F20", Offset = "0x4D62520", VA = "0x184D63F20")]
	private int LGDNDEGFFDD(List<CIBJNAMBILP> PENAIAKJMGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4D64030", Offset = "0x4D62630", VA = "0x184D64030")]
	private void LKLOEIFGALD(int DHLJLJOMMFE, bool JPIKEMPPNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4D63DD0", Offset = "0x4D623D0", VA = "0x184D63DD0")]
	public void HMOLIJGCJJG(Vector3 EFIAJFLJHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D63C50", Offset = "0x4D62250", VA = "0x184D63C50", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D64190", Offset = "0x4D62790", VA = "0x184D64190")]
	public void PHMBLABBLHN(Transform JIKFLPLBAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MJLMAMKLBNH : JMNHOLDFBHG, OFGEPPCCBIN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class CMJHOEEFBGA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public MJLMAMKLBNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6713E0", Offset = "0x66F9E0", VA = "0x1806713E0")]
		[DebuggerHidden]
		public CMJHOEEFBGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4D639F0", Offset = "0x4D61FF0", VA = "0x184D639F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4D63540", Offset = "0x4D61B40", VA = "0x184D63540", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4D63B70", Offset = "0x4D62170", VA = "0x184D63B70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4D63BB0", Offset = "0x4D621B0", VA = "0x184D63BB0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4D63C00", Offset = "0x4D62200", VA = "0x184D63C00")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4D639A0", Offset = "0x4D61FA0", VA = "0x184D639A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4D63900", Offset = "0x4D61F00", VA = "0x184D63900", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4D63900", Offset = "0x4D61F00", VA = "0x184D63900", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NFEDKMKHFDN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public MJLMAMKLBNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6713E0", Offset = "0x66F9E0", VA = "0x1806713E0")]
		[DebuggerHidden]
		public NFEDKMKHFDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4D6CFF0", Offset = "0x4D6B5F0", VA = "0x184D6CFF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4D6CC50", Offset = "0x4D6B250", VA = "0x184D6CC50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4D6D110", Offset = "0x4D6B710", VA = "0x184D6D110")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4D6D160", Offset = "0x4D6B760", VA = "0x184D6D160")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4D6CFA0", Offset = "0x4D6B5A0", VA = "0x184D6CFA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4D6CF00", Offset = "0x4D6B500", VA = "0x184D6CF00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4D6CF00", Offset = "0x4D6B500", VA = "0x184D6CF00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private GDHHBCMGLPO GDAEBHAOMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<CMGNCFFFFNC> KCFNPIJOPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<ClusterMeshRenderer> KONILIGENLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BatchedMeshRenderer ALLENBAGPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool LOJPHDFCKIP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<EHLGKNDONGG> KCMPFMOHGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int LDGGKMJKKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4D6C6D0", Offset = "0x4D6ACD0", VA = "0x184D6C6D0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform GMLHDOPDNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4D6CB70", Offset = "0x4D6B170", VA = "0x184D6CB70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> FOFAJGFHNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x561010", Offset = "0x55F610", VA = "0x180561010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x561020", Offset = "0x55F620", VA = "0x180561020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4D6CBC0", Offset = "0x4D6B1C0", VA = "0x184D6CBC0")]
	public MJLMAMKLBNH(GDHHBCMGLPO OGNHKENMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C000", Offset = "0x4D6A600", VA = "0x184D6C000", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C8C0", Offset = "0x4D6AEC0", VA = "0x184D6C8C0")]
	public void NENJMCKJAJO(CMGNCFFFFNC JDDNANEMMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C850", Offset = "0x4D6AE50", VA = "0x184D6C850")]
	public void MNHCGCIEOKP(CMGNCFFFFNC JDDNANEMMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4D6BA10", Offset = "0x4D6A010", VA = "0x184D6BA10", Slot = "4")]
	public void BBLAHAODIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C620", Offset = "0x4D6AC20", VA = "0x184D6C620")]
	public void IFFNNMKLCCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4D6CA20", Offset = "0x4D6B020", VA = "0x184D6CA20")]
	private void NJLOIJCCFLO(CMGNCFFFFNC JDDNANEMMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C030", Offset = "0x4D6A630", VA = "0x184D6C030")]
	public void GFNCLGHGPOM(bool ADBKENFHJIK, bool LIAIAEJJGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C710", Offset = "0x4D6AD10", VA = "0x184D6C710")]
	protected void LOPFGCJNAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C5B0", Offset = "0x4D6ABB0", VA = "0x184D6C5B0")]
	[IteratorStateMachine(typeof(CMJHOEEFBGA))]
	public IEnumerable<Renderer> GPGFKAAFKMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C9B0", Offset = "0x4D6AFB0", VA = "0x184D6C9B0")]
	[IteratorStateMachine(typeof(NFEDKMKHFDN))]
	public IEnumerable<Renderer> NHMIMBDLLKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class LMINLDBFGEG : CMGNCFFFFNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private HJPOEMPMIEB PBGJIKKOAME;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4D6AC30", Offset = "0x4D69230", VA = "0x184D6AC30")]
	private NativeList<FFAFDDFIOOO> CEIBAAGPJII()
	{
		return default(NativeList<FFAFDDFIOOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4D6ABE0", Offset = "0x4D691E0", VA = "0x184D6ABE0")]
	public LMINLDBFGEG(MJLMAMKLBNH PFOHKHPLBFI, HJPOEMPMIEB OGNHKENMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4D6AF20", Offset = "0x4D69520", VA = "0x184D6AF20", Slot = "13")]
	public override int LGDNDEGFFDD(POMHGFHEEKJ AILOIIHNAGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4D6AD00", Offset = "0x4D69300", VA = "0x184D6AD00", Slot = "14")]
	public override int FPNAABLPKDL(POMHGFHEEKJ AILOIIHNAGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4D6B140", Offset = "0x4D69740", VA = "0x184D6B140", Slot = "15")]
	public override void NJDCCNCOOHC(POMHGFHEEKJ AILOIIHNAGP, MINNFNFMJEB PPCPOJNGOMJ, int PEPKJOMFLHN = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MGGFNBAAJBD : global::IBNHPOIIGBN<MGGFNBAAJBD>, HIOBFMFHHNO, IEquatable<MGGFNBAAJBD>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int OOODCJOIDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7D1460", Offset = "0x7CFA60", VA = "0x1807D1460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x862070", Offset = "0x860670", VA = "0x180862070", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int BGIBIINMANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7D1440", Offset = "0x7CFA40", VA = "0x1807D1440", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83B920", Offset = "0x839F20", VA = "0x18083B920", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x40015F0", Offset = "0x3FFFBF0", VA = "0x1840015F0", Slot = "8")]
	public bool Equals(MGGFNBAAJBD GJPJDOANCNK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4D6B830", Offset = "0x4D69E30", VA = "0x184D6B830")]
	public static bool CCMDEBEFBPF(MGGFNBAAJBD JDOONLDLMNB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum IJDHNBDJMGO
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GDHHBCMGLPO
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform DNMPFDDOBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IJDHNBDJMGO LDGLGOOJDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FDFMPNMADLL : global::IBNHPOIIGBN<FDFMPNMADLL>, HIOBFMFHHNO, IEquatable<FDFMPNMADLL>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int OOODCJOIDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7D1460", Offset = "0x7CFA60", VA = "0x1807D1460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x862070", Offset = "0x860670", VA = "0x180862070", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int BGIBIINMANG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7D1440", Offset = "0x7CFA40", VA = "0x1807D1440", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83B920", Offset = "0x839F20", VA = "0x18083B920", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x40015F0", Offset = "0x3FFFBF0", VA = "0x1840015F0", Slot = "8")]
	public bool Equals(FDFMPNMADLL GJPJDOANCNK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4D65450", Offset = "0x4D63A50", VA = "0x184D65450")]
	public static bool CCMDEBEFBPF(FDFMPNMADLL JDOONLDLMNB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GNCHJBOBKMP
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform DNMPFDDOBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float CKMFBIALHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 MHGEIEEONHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	MDMEDPHADCD MOKCDEPHAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	OOBOACMIFFP ELMOAPMJAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LHLENFMIHMK : GNCHJBOBKMP
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	NFBOPMLKIDD EONJEFHNDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool MCPMNPGPGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HJPOEMPMIEB : GNCHJBOBKMP
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool OLMBPMODDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LDCHEAFKMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float ICBFDFJJAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int JMLNGAAAINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool JNFLGNFMCMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<FFAFDDFIOOO> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JOJAMDMACPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INFEBKGPLDA(FDFMPNMADLL JDDNANEMMMB, CLGAJAKBJCM IGLJFGEGDCN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INFEBKGPLDA(MGGFNBAAJBD PFOHKHPLBFI, CLGAJAKBJCM IGLJFGEGDCN);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KDMNEFBFMHH(MGGFNBAAJBD PFOHKHPLBFI);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KDMNEFBFMHH(FDFMPNMADLL JDDNANEMMMB);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLGEJLCMEJM(MGGFNBAAJBD PFOHKHPLBFI, FHAKBFDBEAL ONIHNDBDHGC);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GBDGKEACBKJ(MGGFNBAAJBD PFOHKHPLBFI, Vector3 IBCKOAFGOCP, Vector3 EJMBOCNNGIH, Vector3 HPIIABMGNDA, float CAEILLNLJLA, float OIBBHNBDDIG, IReadOnlyList<Camera> EGPCHJFDELM, BMJBCLIHHJC KDJEJBCHBPG);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GBDGKEACBKJ(AHPODLIMMMI DCICLKBHFGM, Vector3 IBCKOAFGOCP, Vector3 EJMBOCNNGIH, Vector3 HPIIABMGNDA, float CAEILLNLJLA, float OIBBHNBDDIG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JCHFADBFBCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MGGFNBAAJBD KCOEIGABOHM(GDHHBCMGLPO OGNHKENMEGF);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLGIGABJIKL(MGGFNBAAJBD PFOHKHPLBFI);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIKGIEPOAGG(MGGFNBAAJBD PFOHKHPLBFI);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FDFMPNMADLL IDBBHIDEPFI(MGGFNBAAJBD PFOHKHPLBFI, LHLENFMIHMK OGNHKENMEGF);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FDFMPNMADLL EPKJEKAMEIE(MGGFNBAAJBD PFOHKHPLBFI, HJPOEMPMIEB OGNHKENMEGF);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFMPOKPLKDA(FDFMPNMADLL JDDNANEMMMB);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NKPDNAIMJCL(FDFMPNMADLL JDDNANEMMMB);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AHPODLIMMMI ELCGFDKBNNC(FLLJFANGMHM OGNHKENMEGF);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HHDHHDIEDNA(AHPODLIMMMI DCICLKBHFGM);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AEFKNGMGNLN(AHPODLIMMMI DCICLKBHFGM);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GMPJPDMCHBE IADKMCLCKAD(Transform FOMIJDEBKKL, IEnumerable<FDFMPNMADLL> KCFNPIJOPDA, int FKCHKCKLDIP);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> BKIABBPHGGM(MGGFNBAAJBD PFOHKHPLBFI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct AHPODLIMMMI : global::IBNHPOIIGBN<AHPODLIMMMI>, HIOBFMFHHNO, IEquatable<AHPODLIMMMI>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int OOODCJOIDPB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7D1460", Offset = "0x7CFA60", VA = "0x1807D1460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x862070", Offset = "0x860670", VA = "0x180862070", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int BGIBIINMANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7D1440", Offset = "0x7CFA40", VA = "0x1807D1440", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83B920", Offset = "0x839F20", VA = "0x18083B920", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x40015F0", Offset = "0x3FFFBF0", VA = "0x1840015F0", Slot = "8")]
	public bool Equals(AHPODLIMMMI GJPJDOANCNK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4D62220", Offset = "0x4D60820", VA = "0x184D62220")]
	public static bool CCMDEBEFBPF(AHPODLIMMMI JDOONLDLMNB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FLLJFANGMHM
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int OIGPOHKMJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform IEPEBBMIFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool OMDNBNBIKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MGGFNBAAJBD GetBone(int DNNJPGCJGFN);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int DNNJPGCJGFN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class KCKAGADPEDC : CMGNCFFFFNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public LHLENFMIHMK LAKEGFBHHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int[] DMICPNPGFDJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override DHPPIAAJBJB ACOBFGEFEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4D6A190", Offset = "0x4D68790", VA = "0x184D6A190", Slot = "12")]
		get
		{
			return default(DHPPIAAJBJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 DEHDIAJLKKF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4D69C90", Offset = "0x4D68290", VA = "0x184D69C90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4D6ABE0", Offset = "0x4D691E0", VA = "0x184D6ABE0")]
	public KCKAGADPEDC(MJLMAMKLBNH PFOHKHPLBFI, LHLENFMIHMK OGNHKENMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4D69790", Offset = "0x4D67D90", VA = "0x184D69790", Slot = "11")]
	public override bool GAJKCKPJPEC(Transform PFOHKHPLBFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4D69E70", Offset = "0x4D68470", VA = "0x184D69E70", Slot = "13")]
	public override int LGDNDEGFFDD(POMHGFHEEKJ AILOIIHNAGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4D696F0", Offset = "0x4D67CF0", VA = "0x184D696F0", Slot = "14")]
	public override int FPNAABLPKDL(POMHGFHEEKJ AILOIIHNAGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4D69F10", Offset = "0x4D68510", VA = "0x184D69F10")]
	private int LLIICOBKLMB(POMHGFHEEKJ AILOIIHNAGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4D6A530", Offset = "0x4D68B30", VA = "0x184D6A530", Slot = "15")]
	public override void NJDCCNCOOHC(POMHGFHEEKJ AILOIIHNAGP, MINNFNFMJEB PPCPOJNGOMJ, int PEPKJOMFLHN = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BJIFCLCMNCK
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCPBOJMPJKD(FHAKBFDBEAL ONIHNDBDHGC, Renderer AFDHGOACOAH, int LJCBLOJLFPM);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MCAJEDFLELP(Renderer AFDHGOACOAH, BMJBCLIHHJC KDJEJBCHBPG, Vector3 IBCKOAFGOCP, Vector3 EJMBOCNNGIH, Vector3 HPIIABMGNDA, float CAEILLNLJLA, float OIBBHNBDDIG, float KJIMFLPOLAE = -1f, [Optional] Color? FGMFNEFEEBG, [Optional] IReadOnlyList<Camera> POLNJLOBMGF);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPMJMGLFPHC(Renderer AFDHGOACOAH, int LJCBLOJLFPM);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int ADCALMJJGNN();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DCBHGIJMBAH(int OBJFNMFCMNA, CLGAJAKBJCM ONIHNDBDHGC, Renderer AFDHGOACOAH, int LJCBLOJLFPM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JAOGNJLMJCD : JOJAMDMACPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly BJIFCLCMNCK EPEIHIEIGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly LOAAPCIFGCE NACJKAPLBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MeshRenderer JGLCFHBAANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private LIELMAFJFLK JBHJMDFJADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MeshRenderer MDCEDGGJACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private LIELMAFJFLK GFGCLOAPOFP;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x573990", Offset = "0x571F90", VA = "0x180573990")]
	public JAOGNJLMJCD(BJIFCLCMNCK OLFMMEHJAEN, LOAAPCIFGCE NACJKAPLBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4D68660", Offset = "0x4D66C60", VA = "0x184D68660", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4D69080", Offset = "0x4D67680", VA = "0x184D69080", Slot = "4")]
	public void INFEBKGPLDA(FDFMPNMADLL JDDNANEMMMB, CLGAJAKBJCM IGLJFGEGDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4D68EB0", Offset = "0x4D674B0", VA = "0x184D68EB0", Slot = "5")]
	public void INFEBKGPLDA(MGGFNBAAJBD PFOHKHPLBFI, CLGAJAKBJCM IGLJFGEGDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4D69550", Offset = "0x4D67B50", VA = "0x184D69550", Slot = "6")]
	public void KDMNEFBFMHH(MGGFNBAAJBD PFOHKHPLBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4D69300", Offset = "0x4D67900", VA = "0x184D69300", Slot = "7")]
	public void KDMNEFBFMHH(FDFMPNMADLL JDDNANEMMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4D684C0", Offset = "0x4D66AC0", VA = "0x184D684C0", Slot = "8")]
	public void BLGEJLCMEJM(MGGFNBAAJBD PFOHKHPLBFI, FHAKBFDBEAL ONIHNDBDHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4D687B0", Offset = "0x4D66DB0", VA = "0x184D687B0", Slot = "9")]
	public void GBDGKEACBKJ(MGGFNBAAJBD PFOHKHPLBFI, Vector3 IBCKOAFGOCP, Vector3 EJMBOCNNGIH, Vector3 HPIIABMGNDA, float CAEILLNLJLA, float OIBBHNBDDIG, IReadOnlyList<Camera> EGPCHJFDELM, BMJBCLIHHJC KDJEJBCHBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4D68AE0", Offset = "0x4D670E0", VA = "0x184D68AE0", Slot = "10")]
	public void GBDGKEACBKJ(AHPODLIMMMI DCICLKBHFGM, Vector3 IBCKOAFGOCP, Vector3 EJMBOCNNGIH, Vector3 HPIIABMGNDA, float CAEILLNLJLA, float OIBBHNBDDIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class CMGNCFFFFNC : LBKOJFHLGEN, EHLGKNDONGG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected Bounds DMHGOKMJPMN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public MJLMAMKLBNH MPLJPEEIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x560490", Offset = "0x55EA90", VA = "0x180560490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds GODKIDCOFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xFE3120", Offset = "0xFE1720", VA = "0x180FE3120", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual DHPPIAAJBJB ACOBFGEFEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4D634B0", Offset = "0x4D61AB0", VA = "0x184D634B0", Slot = "12")]
		get
		{
			return default(DHPPIAAJBJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4D63440", Offset = "0x4D61A40", VA = "0x184D63440", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x560EC0", Offset = "0x55F4C0", VA = "0x180560EC0", Slot = "11")]
	public virtual bool GAJKCKPJPEC(Transform PFOHKHPLBFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int LGDNDEGFFDD(POMHGFHEEKJ AILOIIHNAGP);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int FPNAABLPKDL(POMHGFHEEKJ AILOIIHNAGP);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void NJDCCNCOOHC(POMHGFHEEKJ AILOIIHNAGP, MINNFNFMJEB PPCPOJNGOMJ, int PEPKJOMFLHN = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	protected CMGNCFFFFNC()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4D6D1A0", Offset = "0x4D6B7A0", VA = "0x184D6D1A0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum NFBOPMLKIDD
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class EMHLHKKDALD
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class LPMIBMFKNKG : IEnumerable<KPEMFMICPIL>, IEnumerable, IEnumerator<KPEMFMICPIL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private KPEMFMICPIL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private KPEMFMICPIL System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6713E0", Offset = "0x66F9E0", VA = "0x1806713E0")]
		[DebuggerHidden]
		public LPMIBMFKNKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4D6B670", Offset = "0x4D69C70", VA = "0x184D6B670", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4D6B7E0", Offset = "0x4D69DE0", VA = "0x184D6B7E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4D6B750", Offset = "0x4D69D50", VA = "0x184D6B750", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KPEMFMICPIL> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4D6B750", Offset = "0x4D69D50", VA = "0x184D6B750", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int LHIFCGDHOII = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static KPEMFMICPIL[][] ENIGKCEFHCF;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static EONAGJHILJH MHJCAFHGJCP;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static ShapeRendererConfig NJMCFPBHPFJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader PMCILHDFDHL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4D64650", Offset = "0x4D62C50", VA = "0x184D64650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer AJOJHJAMJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4D65340", Offset = "0x4D63940", VA = "0x184D65340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4D64EE0", Offset = "0x4D634E0", VA = "0x184D64EE0")]
	public static Mesh KDGCFPEFHLL(NFBOPMLKIDD KAOMJCDBALC, int AILOIIHNAGP = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4D646C0", Offset = "0x4D62CC0", VA = "0x184D646C0")]
	public static int BIMLDPDMJLD(NFBOPMLKIDD KAOMJCDBALC, int AILOIIHNAGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4D64500", Offset = "0x4D62B00", VA = "0x184D64500")]
	public static EONAGJHILJH BFKKLGJKPDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4D652E0", Offset = "0x4D638E0", VA = "0x184D652E0")]
	[IteratorStateMachine(typeof(LPMIBMFKNKG))]
	private static IEnumerable<KPEMFMICPIL> MOHCPIPPHMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4D64FA0", Offset = "0x4D635A0", VA = "0x184D64FA0")]
	public static KPEMFMICPIL MFMPALHFPCG(NFBOPMLKIDD KAOMJCDBALC, int AILOIIHNAGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4D653B0", Offset = "0x4D639B0", VA = "0x184D653B0")]
	public static bool PPHFEJCGJCO(this NFBOPMLKIDD KAOMJCDBALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4D646D0", Offset = "0x4D62CD0", VA = "0x184D646D0")]
	public static void BNDAHIAPELE(NFBOPMLKIDD KAOMJCDBALC, float3 CFDPFNIDMJG, out PLLJEKBDBKH GIADMAIJKNN, out float3 MDIDLBAOOJI, out float OIFCIEFHAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4D64890", Offset = "0x4D62E90", VA = "0x184D64890")]
	public static void DMBGHGOFCEN(Vector3 CFDPFNIDMJG, NFBOPMLKIDD KAOMJCDBALC, out Vector3 MDIDLBAOOJI, out float OIFCIEFHAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4D64CB0", Offset = "0x4D632B0", VA = "0x184D64CB0")]
	[NAOLMNKNAMK(DKCHBDLNPEE.ExitingPlayMode, 0)]
	private static void HHPBPGJKHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4D64CC0", Offset = "0x4D632C0", VA = "0x184D64CC0")]
	[NAOLMNKNAMK(DKCHBDLNPEE.ExitingPlayMode, 0)]
	private static void IDGKHIDKGOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CALJOHDLHGB
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool GKADFCAELIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material OIPOLOMFOEB();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material HFIMLCPLJBC();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material GFIFCDEKOPD();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MPAMDJABEGI(MDMEDPHADCD PCPNJFHNNIN);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int HMNANOHBLMG(OOBOACMIFFP BCFFLJONKDF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JEBLJLPCIHM(GameObject FIEDOLNFNLH);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BKNEKILJPNB(GameObject FIEDOLNFNLH, bool FIKFPPNPACM);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface LOAAPCIFGCE
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	MJLMAMKLBNH NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CMGNCFFFFNC NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IMHLGACAEAG NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class HOGKPDLNLFH : JCHFADBFBCE, IDisposable, LOAAPCIFGCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::NGOAGBPGLJE<MGGFNBAAJBD, MJLMAMKLBNH> KHOLNMFOAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::NGOAGBPGLJE<FDFMPNMADLL, CMGNCFFFFNC> KCFNPIJOPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly global::NGOAGBPGLJE<AHPODLIMMMI, IMHLGACAEAG> BIANKNBPBLK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static CALJOHDLHGB KHLDGOFPILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4D65F70", Offset = "0x4D64570", VA = "0x184D65F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4D66300", Offset = "0x4D64900", VA = "0x184D66300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MJLMAMKLBNH NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4D66A50", Offset = "0x4D65050", VA = "0x184D66A50", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public CMGNCFFFFNC NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4D66AB0", Offset = "0x4D650B0", VA = "0x184D66AB0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IMHLGACAEAG NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4D66B10", Offset = "0x4D65110", VA = "0x184D66B10", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4D66BE0", Offset = "0x4D651E0", VA = "0x184D66BE0")]
	public HOGKPDLNLFH(CALJOHDLHGB OLFMMEHJAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4D65FB0", Offset = "0x4D645B0", VA = "0x184D65FB0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4D66900", Offset = "0x4D64F00", VA = "0x184D66900", Slot = "4")]
	public MGGFNBAAJBD KCOEIGABOHM(GDHHBCMGLPO OGNHKENMEGF)
	{
		return default(MGGFNBAAJBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4D662A0", Offset = "0x4D648A0", VA = "0x184D662A0", Slot = "5")]
	public void FLGIGABJIKL(MGGFNBAAJBD PFOHKHPLBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4D66B70", Offset = "0x4D65170", VA = "0x184D66B70", Slot = "6")]
	public void PIKGIEPOAGG(MGGFNBAAJBD PFOHKHPLBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D65EB0", Offset = "0x4D644B0", VA = "0x184D65EB0", Slot = "15")]
	public IEnumerable<Renderer> BKIABBPHGGM(MGGFNBAAJBD PFOHKHPLBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4D667B0", Offset = "0x4D64DB0", VA = "0x184D667B0", Slot = "7")]
	public FDFMPNMADLL IDBBHIDEPFI(MGGFNBAAJBD PFOHKHPLBFI, LHLENFMIHMK OGNHKENMEGF)
	{
		return default(FDFMPNMADLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D661B0", Offset = "0x4D647B0", VA = "0x184D661B0", Slot = "8")]
	public FDFMPNMADLL EPKJEKAMEIE(MGGFNBAAJBD PFOHKHPLBFI, HJPOEMPMIEB OGNHKENMEGF)
	{
		return default(FDFMPNMADLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4D669E0", Offset = "0x4D64FE0", VA = "0x184D669E0", Slot = "10")]
	public void NKPDNAIMJCL(FDFMPNMADLL JDDNANEMMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4D668A0", Offset = "0x4D64EA0", VA = "0x184D668A0", Slot = "9")]
	public void IFMPOKPLKDA(FDFMPNMADLL JDDNANEMMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4D66020", Offset = "0x4D64620", VA = "0x184D66020", Slot = "11")]
	public AHPODLIMMMI ELCGFDKBNNC(FLLJFANGMHM OGNHKENMEGF)
	{
		return default(AHPODLIMMMI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4D65E40", Offset = "0x4D64440", VA = "0x184D65E40", Slot = "13")]
	public void AEFKNGMGNLN(AHPODLIMMMI DCICLKBHFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4D66350", Offset = "0x4D64950", VA = "0x184D66350", Slot = "12")]
	public void HHDHHDIEDNA(AHPODLIMMMI DCICLKBHFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4D663B0", Offset = "0x4D649B0", VA = "0x184D663B0", Slot = "14")]
	public GMPJPDMCHBE IADKMCLCKAD(Transform FOMIJDEBKKL, IEnumerable<FDFMPNMADLL> KCFNPIJOPDA, int FKCHKCKLDIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class IMHLGACAEAG : JMNHOLDFBHG
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class HBHBFJPPPKD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public IMHLGACAEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6713E0", Offset = "0x66F9E0", VA = "0x1806713E0")]
		[DebuggerHidden]
		public HBHBFJPPPKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4D65770", Offset = "0x4D63D70", VA = "0x184D65770", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4D65490", Offset = "0x4D63A90", VA = "0x184D65490", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4D65810", Offset = "0x4D63E10", VA = "0x184D65810")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4D65720", Offset = "0x4D63D20", VA = "0x184D65720", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4D65680", Offset = "0x4D63C80", VA = "0x184D65680", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4D65680", Offset = "0x4D63C80", VA = "0x184D65680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly FLLJFANGMHM LDBAPMHPINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly LOAAPCIFGCE NACJKAPLBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private DMLFGDPLHJB MKKBGKBNKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<CIBJNAMBILP> PBCDCKCKAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<CIBJNAMBILP> DKJGJBIDPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GameObject JEDBLLCAHNO;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4D67AA0", Offset = "0x4D660A0", VA = "0x184D67AA0")]
	public static IMHLGACAEAG BFDJFBGHOBJ(FLLJFANGMHM OGNHKENMEGF, LOAAPCIFGCE NACJKAPLBAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4D683C0", Offset = "0x4D669C0", VA = "0x184D683C0")]
	private IMHLGACAEAG(FLLJFANGMHM OGNHKENMEGF, LOAAPCIFGCE NACJKAPLBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4D67C70", Offset = "0x4D66270", VA = "0x184D67C70")]
	public void HLHLNLIFMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4D67C00", Offset = "0x4D66200", VA = "0x184D67C00")]
	[IteratorStateMachine(typeof(HBHBFJPPPKD))]
	public IEnumerable<Renderer> GPGFKAAFKMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4D67050", Offset = "0x4D65650", VA = "0x184D67050", Slot = "4")]
	public void BBLAHAODIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4D68390", Offset = "0x4D66990", VA = "0x184D68390")]
	private void NFFDAFLDOKA(Vector3 EFIAJFLJHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4D681C0", Offset = "0x4D667C0", VA = "0x184D681C0")]
	public void IFFNNMKLCCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CIBJNAMBILP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct PHGDHCHIIOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public MINNFNFMJEB LIDBIKAFGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform KIAAKNAOIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int LKLFDBNICAP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class FBIFECLFOGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CIBJNAMBILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public POMHGFHEEKJ lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<PHGDHCHIIOL> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public FBIFECLFOGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class AEDFNNKMPDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GMPJPDMCHBE combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public FBIFECLFOGN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public AEDFNNKMPDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4D61FE0", Offset = "0x4D605E0", VA = "0x184D61FE0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4D62050", Offset = "0x4D60650", VA = "0x184D62050")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4D62090", Offset = "0x4D60690", VA = "0x184D62090")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int[] LAKMABLNCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private FKMPEFALPCD NKJNMCHHBIJ;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static Matrix4x4 KIHDGAPEEAH;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh PDKMCKDACHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x560490", Offset = "0x55EA90", VA = "0x180560490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int LKBEPKDJHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5EC670", Offset = "0x5EAC70", VA = "0x1805EC670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6BC230", Offset = "0x6BA830", VA = "0x1806BC230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4D62260", Offset = "0x4D60860", VA = "0x184D62260")]
	public void AFLGCODOBPP(List<Transform> DALFDNJKEFP, Matrix4x4[] ACENBGIICNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4D624E0", Offset = "0x4D60AE0", VA = "0x184D624E0")]
	public static List<CIBJNAMBILP> GPCBEJLMGEM(List<MJLMAMKLBNH> IEBNGLKCCHN, POMHGFHEEKJ AILOIIHNAGP, Bounds LKAHHEMJOBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4D62A40", Offset = "0x4D61040", VA = "0x184D62A40")]
	private JobHandle JKLBKJBKPDC(GMPJPDMCHBE CMGPCGFIKPE, int AAHILPIFDDB, int DDDKIEOJEJK, POMHGFHEEKJ AILOIIHNAGP, List<PHGDHCHIIOL> FDAMKFKMMAL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D62E50", Offset = "0x4D61450", VA = "0x184D62E50")]
	private void NIILJKNHBOD(List<PHGDHCHIIOL> FDAMKFKMMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4D63090", Offset = "0x4D61690", VA = "0x184D63090")]
	private CIBJNAMBILP(List<PHGDHCHIIOL> FDAMKFKMMAL, int AAHILPIFDDB, int DDDKIEOJEJK, POMHGFHEEKJ AILOIIHNAGP, Bounds LKAHHEMJOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4D62460", Offset = "0x4D60A60", VA = "0x184D62460", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private MaterialPropertyBlock PNBHGOAKALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private CIBJNAMBILP FCHIEFHJLOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<Transform> EFANHFEDCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private RenderTexture DDNCFGHLIIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeBuffer JFEKLMMOPEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ComputeShader ILOGKJPFGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Matrix4x4[] DFLMMKKJHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int HCGCDMOPEJO;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer IKGLOPJLNNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5604A0", Offset = "0x55EAA0", VA = "0x1805604A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int OIGPOHKMJMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4D6DD40", Offset = "0x4D6C340", VA = "0x184D6DD40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4D6D5B0", Offset = "0x4D6BBB0", VA = "0x184D6D5B0")]
		public static List<SkinnedShapeRenderer> Create(GameObject PFOHKHPLBFI, List<CIBJNAMBILP> PENAIAKJMGN, List<Transform> EFANHFEDCHD, Material AHGGGHMLBKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4D6D7C0", Offset = "0x4D6BDC0", VA = "0x184D6D7C0")]
		public void Init(CIBJNAMBILP FCHIEFHJLOJ, List<Transform> EFANHFEDCHD, Material AHGGGHMLBKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4D6DCB0", Offset = "0x4D6C2B0", VA = "0x184D6DCB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4D6DC20", Offset = "0x4D6C220", VA = "0x184D6DC20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4D6DBE0", Offset = "0x4D6C1E0", VA = "0x184D6DBE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4D6D520", Offset = "0x4D6BB20", VA = "0x184D6D520")]
		private void BJNIMHOLDCM(ScriptableRenderContext GCLGODGIPBD, Camera[] LEMIHBFMIOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4D6D1D0", Offset = "0x4D6B7D0", VA = "0x184D6D1D0")]
		private void AFLGCODOBPP(CommandBuffer ONMNHBANAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xCE3700", Offset = "0xCE1D00", VA = "0x180CE3700")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HGPPKMCDCLL
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static byte[] PIDGMPFPDGI;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int CONMIAOECKG;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int PDHBFKNINGO;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static BigInteger EDLLKHJPMCN;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public HGPPKMCDCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4D65850", Offset = "0x4D63E50", VA = "0x184D65850")]
	private static string CKGLFMJKOPM(byte[] IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4D65950", Offset = "0x4D63F50", VA = "0x184D65950")]
	public static string IOHOBOIOFIG(byte[] KFCJKMJDFKE, bool OLNJLDMOIJP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
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
