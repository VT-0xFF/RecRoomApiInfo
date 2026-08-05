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
public enum BMOEILFIHJP
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
public static class GOMCNNELCPM
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<BMOEILFIHJP> KEAHOGGMJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x56C66A0", Offset = "0x56C52A0", VA = "0x1856C66A0")]
	static GOMCNNELCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x56C66A0", Offset = "0x56C52A0", VA = "0x1856C66A0")]
	[FJLKHABBCIM]
	private static void CMEOLNMPNEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x56C6620", Offset = "0x56C5220", VA = "0x1856C6620")]
	public static bool AIJPEGFAJKM(this BMOEILFIHJP PJGKAHJGLIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DPANBBAKMDL
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
	WORN_WOOD = 29,
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
public enum MLGPJHFBDKK
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
public enum OGNGNPGEEPO
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
	ScopeRoot,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	PivotHover
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum OOEHAPFDLKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MFMEPDCGIME : LJODKMHJJIF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const byte NHPEJPFBBDN = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private byte LFCGODGHEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<SkinnedShapeRenderer>[] AGNFKMBJBFM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int INHEOBDHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CD0", Offset = "0x5E38D0", VA = "0x1805E4CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x665A10", Offset = "0x664610", VA = "0x180665A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LOCLBPDNOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CC0", Offset = "0x5E38C0", VA = "0x1805E4CC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73F1B0", Offset = "0x73DDB0", VA = "0x18073F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float FPHOBJEANEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x151B9A0", Offset = "0x151A5A0", VA = "0x18151B9A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x151B7B0", Offset = "0x151A3B0", VA = "0x18151B7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float EKDOFFGBNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x10954D0", Offset = "0x10940D0", VA = "0x1810954D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x174D4B0", Offset = "0x174C0B0", VA = "0x18174D4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> EDCKGHKLMHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x56C96E0", Offset = "0x56C82E0", VA = "0x1856C96E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> MBPLPODEBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4551A40", Offset = "0x4550640", VA = "0x184551A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject KBKNGMOBLAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60CA30", Offset = "0x60B630", VA = "0x18060CA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x71C880", Offset = "0x71B480", VA = "0x18071C880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte EGPBKIHIEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x56C9BD0", Offset = "0x56C87D0", VA = "0x1856C9BD0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x56C9C20", Offset = "0x56C8820", VA = "0x1856C9C20")]
	public MFMEPDCGIME(List<HIBHHPJGHKA> CFNFMOPCMHJ, List<HIBHHPJGHKA> AALCNKKLLGC, List<LMMBNFLDKGF> HIMMDCCPMGF, Material MLMEKJLFCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x56C9870", Offset = "0x56C8470", VA = "0x1856C9870")]
	private int FKLOHFOBCBN(List<HIBHHPJGHKA> LCAJNOPHELH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x56C9980", Offset = "0x56C8580", VA = "0x1856C9980")]
	private void LIAHPMKHJJK(int PNABKIICAJB, bool IBNFCBHHOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x56C9AE0", Offset = "0x56C86E0", VA = "0x1856C9AE0")]
	public void OKOOFOJGJEB(Vector3 CFJDFEALBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x56C9740", Offset = "0x56C8340", VA = "0x1856C9740", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x56C96A0", Offset = "0x56C82A0", VA = "0x1856C96A0")]
	public void DAIOBBDHOGL(Transform MMNIJAKCDAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JAOMAGGCEIE : EGDDKOFJHME, OIJAKEPJFAB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KOOMBLJAGHI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public JAOMAGGCEIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F53E0", Offset = "0x6F3FE0", VA = "0x1806F53E0")]
		[DebuggerHidden]
		public KOOMBLJAGHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x56C9440", Offset = "0x56C8040", VA = "0x1856C9440", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x56C8F90", Offset = "0x56C7B90", VA = "0x1856C8F90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x56C95C0", Offset = "0x56C81C0", VA = "0x1856C95C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x56C9600", Offset = "0x56C8200", VA = "0x1856C9600")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x56C9650", Offset = "0x56C8250", VA = "0x1856C9650")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x56C93F0", Offset = "0x56C7FF0", VA = "0x1856C93F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x56C9350", Offset = "0x56C7F50", VA = "0x1856C9350", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x56C9350", Offset = "0x56C7F50", VA = "0x1856C9350", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ECFKOBHKPHH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public JAOMAGGCEIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F53E0", Offset = "0x6F3FE0", VA = "0x1806F53E0")]
		[DebuggerHidden]
		public ECFKOBHKPHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x56C4F30", Offset = "0x56C3B30", VA = "0x1856C4F30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x56C4B90", Offset = "0x56C3790", VA = "0x1856C4B90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x56C5050", Offset = "0x56C3C50", VA = "0x1856C5050")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x56C50A0", Offset = "0x56C3CA0", VA = "0x1856C50A0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x56C4EE0", Offset = "0x56C3AE0", VA = "0x1856C4EE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x56C4E40", Offset = "0x56C3A40", VA = "0x1856C4E40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x56C4E40", Offset = "0x56C3A40", VA = "0x1856C4E40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly BLBOCCNKIPE KFAEJBLFIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly List<PCCFDOJOJDG> PHLKNFKLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private List<ClusterMeshRenderer> DLELCGECCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private BatchedMeshRenderer OFAJPHKJGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool GAMIGMKFGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<IJAEOFCEPOA> CLGGIFEIICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IOPPHHOALHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x56C8820", Offset = "0x56C7420", VA = "0x1856C8820", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LMMBNFLDKGF DOBAHNBBJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x56C89E0", Offset = "0x56C75E0", VA = "0x1856C89E0", Slot = "7")]
		get
		{
			return default(LMMBNFLDKGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> OCNCMEFIDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5010", Offset = "0x5E3C10", VA = "0x1805E5010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5020", Offset = "0x5E3C20", VA = "0x1805E5020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x56C8BF0", Offset = "0x56C77F0", VA = "0x1856C8BF0")]
	public JAOMAGGCEIE(BLBOCCNKIPE CEECNJJKNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x56C8010", Offset = "0x56C6C10", VA = "0x1856C8010", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x56C80B0", Offset = "0x56C6CB0", VA = "0x1856C80B0")]
	public void JNIPLPDFDNO(PCCFDOJOJDG FAJJDHLHNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x56C81A0", Offset = "0x56C6DA0", VA = "0x1856C81A0")]
	public void MAHLOMNJIKK(PCCFDOJOJDG FAJJDHLHNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x56C7A80", Offset = "0x56C6680", VA = "0x1856C7A80", Slot = "4")]
	public void BIKNGNMBDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x56C79D0", Offset = "0x56C65D0", VA = "0x1856C79D0")]
	public void ADGIMOCDCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x56C8860", Offset = "0x56C7460", VA = "0x1856C8860")]
	private void NMIEHDKPPAM(List<PCCFDOJOJDG> PHLKNFKLEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x56C8040", Offset = "0x56C6C40", VA = "0x1856C8040")]
	private static Material EGDMPJBKIAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x56C8990", Offset = "0x56C7590", VA = "0x1856C8990")]
	private void NMIEHDKPPAM(PCCFDOJOJDG FAJJDHLHNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x56C8AB0", Offset = "0x56C76B0", VA = "0x1856C8AB0")]
	private void PJEICEOGLGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x56C8210", Offset = "0x56C6E10", VA = "0x1856C8210")]
	public void MAJLMEFNCDM(bool HPOLHDPDCLG, bool EMNEBHLLAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x56C8790", Offset = "0x56C7390", VA = "0x1856C8790")]
	protected void MFNACPPDOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x56C8B80", Offset = "0x56C7780", VA = "0x1856C8B80")]
	[IteratorStateMachine(typeof(KOOMBLJAGHI))]
	public IEnumerable<Renderer> POMKHGAHLJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x56C7FA0", Offset = "0x56C6BA0", VA = "0x1856C7FA0")]
	[IteratorStateMachine(typeof(ECFKOBHKPHH))]
	public IEnumerable<Renderer> DDIPLCOKBNK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class DLFMLHLIEFH : PCCFDOJOJDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly JCIFAILOKAO CEDGKJOIHMD;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x56C3EF0", Offset = "0x56C2AF0", VA = "0x1856C3EF0")]
	public DLFMLHLIEFH(JAOMAGGCEIE FEKJACABLNO, JCIFAILOKAO CEECNJJKNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x56C3F40", Offset = "0x56C2B40", VA = "0x1856C3F40", Slot = "13")]
	public override int FKLOHFOBCBN(NADLMEPLBLH HCCNHCAJIKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x56C47F0", Offset = "0x56C33F0", VA = "0x1856C47F0", Slot = "14")]
	public override int MIMOAMFENPA(NADLMEPLBLH HCCNHCAJIKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x56C4120", Offset = "0x56C2D20", VA = "0x1856C4120", Slot = "15")]
	public override void LNMNJEAKCOI(NADLMEPLBLH HCCNHCAJIKB, NONPADBMJOO MOJPAKJHKFI, int GFKEGBDLGNM = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CMPJNDPOACO : global::DGMLBDFJNFE<CMPJNDPOACO>, NINKJOKNHPH, IEquatable<CMPJNDPOACO>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LEADIMEMNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2100", VA = "0x1808A3500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x91DAC0", Offset = "0x91C6C0", VA = "0x18091DAC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DBOCDBJDJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8A34E0", Offset = "0x8A20E0", VA = "0x1808A34E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8F72D0", Offset = "0x8F5ED0", VA = "0x1808F72D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MLPCDHELIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x56C24D0", Offset = "0x56C10D0", VA = "0x1856C24D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4542390", Offset = "0x4540F90", VA = "0x184542390", Slot = "8")]
	public bool Equals(CMPJNDPOACO LPEBOAHCFNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xD6A5F0", Offset = "0xD691F0", VA = "0x180D6A5F0")]
	public static bool GPLOOKALJBH(CMPJNDPOACO GBHOMBFJPAG, CMPJNDPOACO DBJNEGCCKCM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x33BD6C0", Offset = "0x33BC2C0", VA = "0x1833BD6C0")]
	public static bool EGNPDGHOPNA(CMPJNDPOACO GBHOMBFJPAG, CMPJNDPOACO DBJNEGCCKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x56C2510", Offset = "0x56C1110", VA = "0x1856C2510", Slot = "0")]
	public override bool Equals(object HLJJNKOAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2100", VA = "0x1808A3500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum IEGLCOKJOLH
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BLBOCCNKIPE
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LMMBNFLDKGF CGNEMPAMBLA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	IEGLCOKJOLH BDOBOEJGGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JHNPAHOFJND : global::DGMLBDFJNFE<JHNPAHOFJND>, NINKJOKNHPH, IEquatable<JHNPAHOFJND>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int LEADIMEMNFB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2100", VA = "0x1808A3500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x91DAC0", Offset = "0x91C6C0", VA = "0x18091DAC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int DBOCDBJDJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8A34E0", Offset = "0x8A20E0", VA = "0x1808A34E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8F72D0", Offset = "0x8F5ED0", VA = "0x1808F72D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MLPCDHELIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x56C8EC0", Offset = "0x56C7AC0", VA = "0x1856C8EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4542390", Offset = "0x4540F90", VA = "0x184542390", Slot = "8")]
	public bool Equals(JHNPAHOFJND LPEBOAHCFNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xD6A5F0", Offset = "0xD691F0", VA = "0x180D6A5F0")]
	public static bool GPLOOKALJBH(JHNPAHOFJND GBHOMBFJPAG, JHNPAHOFJND DBJNEGCCKCM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x33BD6C0", Offset = "0x33BC2C0", VA = "0x1833BD6C0")]
	public static bool EGNPDGHOPNA(JHNPAHOFJND GBHOMBFJPAG, JHNPAHOFJND DBJNEGCCKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x56C8F00", Offset = "0x56C7B00", VA = "0x1856C8F00", Slot = "0")]
	public override bool Equals(object HLJJNKOAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2100", VA = "0x1808A3500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface COOIOEIAAOB
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	LMMBNFLDKGF CGNEMPAMBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float PHAOEIOFGJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 AAKLKDNPMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	BMOEILFIHJP LAKOBOCKEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	DPANBBAKMDL MPJNDIOLMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JGIENIGGMIN : COOIOEIAAOB
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	KODIEEBLFLF GLIAIFIMHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool EDJGCODNLNM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JCIFAILOKAO : COOIOEIAAOB
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool OKILHNGFPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FDKKOCBFLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float INOPDGDPAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int BAACNCIHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool ONPEAMILNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int CBDEMKMKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<DACMAJGNCFF> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NMGBENFFOBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGBAOJGMHAH(CMPJNDPOACO FEKJACABLNO, OGNGNPGEEPO AFPKMECFOAC);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGBAOJGMHAH(JHNPAHOFJND FAJJDHLHNBK, OGNGNPGEEPO AFPKMECFOAC);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBJBFCGLEHK(JHNPAHOFJND FAJJDHLHNBK);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KEOOCIPLBMI(JHNPAHOFJND FAJJDHLHNBK);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKEJHFIDDCB();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HMOJEGKLGKA();

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FFPFOIDEBJI(OGNGNPGEEPO HCPDGKICMEB);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MEJOCPAPOLJ(CMPJNDPOACO FEKJACABLNO);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MEJOCPAPOLJ(JHNPAHOFJND FAJJDHLHNBK);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KEIBODILNDJ(CMPJNDPOACO FEKJACABLNO, OOEHAPFDLKJ HCPDGKICMEB);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KEIBODILNDJ(JHNPAHOFJND FAJJDHLHNBK, OOEHAPFDLKJ HCPDGKICMEB);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HIJLGDFDGMG(JHNPAHOFJND FAJJDHLHNBK);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void APEPJDAHFHE(JHNPAHOFJND FAJJDHLHNBK);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EGBOCHGIHOI();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PIKILENLJMP();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KMEHDCBPCPH(OOEHAPFDLKJ HCPDGKICMEB);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HMMHJIIIGOK(CMPJNDPOACO FEKJACABLNO, Vector3 MHMOPLAGMMM, Vector3 NLPOHEBMCAB, Vector3 KLJKHGOKCJF, float KOBAMLKFGLK, float FLFBAFBDDKB, IReadOnlyList<Camera> KAFBICGGHJN, MLGPJHFBDKK JCCJAIKEGMN);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HMMHJIIIGOK(NPGKDJALCAI FEIHIPBAAHB, Vector3 MHMOPLAGMMM, Vector3 NLPOHEBMCAB, Vector3 KLJKHGOKCJF, float KOBAMLKFGLK, float FLFBAFBDDKB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EMDEHPHDHBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMPJNDPOACO IABNIDPKGIF(BLBOCCNKIPE CEECNJJKNFO);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEOPAFLJFEE(CMPJNDPOACO FEKJACABLNO);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOPBDGHOJNJ(CMPJNDPOACO FEKJACABLNO);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JHNPAHOFJND JBLHHLFGHFA(CMPJNDPOACO FEKJACABLNO, JGIENIGGMIN CEECNJJKNFO);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JHNPAHOFJND KHHFJFPGMLG(CMPJNDPOACO FEKJACABLNO, JCIFAILOKAO CEECNJJKNFO);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OFEPKCNPKGN(JHNPAHOFJND FAJJDHLHNBK);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IKIOKKEIDDB(JHNPAHOFJND FAJJDHLHNBK);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NPGKDJALCAI MDHAIKOIOCD(LPJBOKONKED CEECNJJKNFO);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EAAKLMGMOGM(NPGKDJALCAI FEIHIPBAAHB);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LDIIIFIKBOJ(NPGKDJALCAI FEIHIPBAAHB);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JOMACKCFBMO JDGJGDEFMKM(LMMBNFLDKGF AFJLPAFJGKD, IEnumerable<JHNPAHOFJND> PHLKNFKLEML, int IMBOBPBOMDK);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> EJDJHDKCJEA(CMPJNDPOACO FEKJACABLNO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NPGKDJALCAI : global::DGMLBDFJNFE<NPGKDJALCAI>, NINKJOKNHPH, IEquatable<NPGKDJALCAI>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int LEADIMEMNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2100", VA = "0x1808A3500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x91DAC0", Offset = "0x91C6C0", VA = "0x18091DAC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int DBOCDBJDJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A34E0", Offset = "0x8A20E0", VA = "0x1808A34E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8F72D0", Offset = "0x8F5ED0", VA = "0x1808F72D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MLPCDHELIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x56C9F50", Offset = "0x56C8B50", VA = "0x1856C9F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4542390", Offset = "0x4540F90", VA = "0x184542390", Slot = "8")]
	public bool Equals(NPGKDJALCAI LPEBOAHCFNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xD6A5F0", Offset = "0xD691F0", VA = "0x180D6A5F0")]
	public static bool GPLOOKALJBH(NPGKDJALCAI GBHOMBFJPAG, NPGKDJALCAI DBJNEGCCKCM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x33BD6C0", Offset = "0x33BC2C0", VA = "0x1833BD6C0")]
	public static bool EGNPDGHOPNA(NPGKDJALCAI GBHOMBFJPAG, NPGKDJALCAI DBJNEGCCKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x56C9F90", Offset = "0x56C8B90", VA = "0x1856C9F90", Slot = "0")]
	public override bool Equals(object HLJJNKOAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2100", VA = "0x1808A3500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LPJBOKONKED
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int GBEHNGAIAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform BNCGEFEPLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool MEBHHHNEDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CMPJNDPOACO GetBone(int LMJFJHPJJJA);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int LMJFJHPJJJA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class DKLHLPMIBGI : PCCFDOJOJDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly JGIENIGGMIN OAADPMHPDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int[] ONPAFABBJFP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override LKJAONLPEHC CHCMIBHNCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x56C3AF0", Offset = "0x56C26F0", VA = "0x1856C3AF0", Slot = "12")]
		get
		{
			return default(LKJAONLPEHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 FBLLEMFIKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x56C2E10", Offset = "0x56C1A10", VA = "0x1856C2E10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x56C3EF0", Offset = "0x56C2AF0", VA = "0x1856C3EF0")]
	public DKLHLPMIBGI(JAOMAGGCEIE FEKJACABLNO, JGIENIGGMIN CEECNJJKNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x56C2820", Offset = "0x56C1420", VA = "0x1856C2820", Slot = "11")]
	public override bool ECCDOOJJOAI(LMMBNFLDKGF FEKJACABLNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x56C2D70", Offset = "0x56C1970", VA = "0x1856C2D70", Slot = "13")]
	public override int FKLOHFOBCBN(NADLMEPLBLH HCCNHCAJIKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x56C3A50", Offset = "0x56C2650", VA = "0x1856C3A50", Slot = "14")]
	public override int MIMOAMFENPA(NADLMEPLBLH HCCNHCAJIKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x56C25A0", Offset = "0x56C11A0", VA = "0x1856C25A0")]
	private int DPKIPLCKAFL(NADLMEPLBLH HCCNHCAJIKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x56C3190", Offset = "0x56C1D90", VA = "0x1856C3190", Slot = "15")]
	public override void LNMNJEAKCOI(NADLMEPLBLH HCCNHCAJIKB, NONPADBMJOO MOJPAKJHKFI, int GFKEGBDLGNM = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KCGPFGGEIHP
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHNMKJKCMDI(OOEHAPFDLKJ HCPDGKICMEB, Renderer DEMNDDPIFOG, int OFELDDLIJML);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAEHJNCBGBE(Renderer DEMNDDPIFOG, MLGPJHFBDKK JCCJAIKEGMN, Vector3 MHMOPLAGMMM, Vector3 NLPOHEBMCAB, Vector3 KLJKHGOKCJF, float KOBAMLKFGLK, float FLFBAFBDDKB, float FLOIFIEJOKM = -1f, [Optional] Color? GOKDGJHFBBA, [Optional] IReadOnlyList<Camera> JIGCPLEOPKD);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIDMOEKEKDN(Renderer DEMNDDPIFOG, int OFELDDLIJML);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CHALJNKFIBO();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGHPDEMNJPB(int IPNKNMDAEJD, OGNGNPGEEPO HCPDGKICMEB, Renderer DEMNDDPIFOG, int OFELDDLIJML);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PIBFKMKCEGN : NMGBENFFOBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class PMCJCCDBLKF : global::PPCMFHGDDJF<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x56CD260", Offset = "0x56CBE60", VA = "0x1856CD260")]
		public PMCJCCDBLKF(string AMDKCMALAFD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly KCGPFGGEIHP EMNCNFJGCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly IBEGMOPHOKO NCMBKIEBNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private MeshRenderer BLNLBAEJLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private PMCJCCDBLKF KJBILKGEBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool NBCPPBBNGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private MeshRenderer EKILPNMALBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private PMCJCCDBLKF PLGLLCFLACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool PHPKJMIHMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private MeshRenderer DNACLHBEMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private PMCJCCDBLKF BFMIIKPMDED;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5F7990", Offset = "0x5F6590", VA = "0x1805F7990")]
	public PIBFKMKCEGN(KCGPFGGEIHP LGHEEBFGNDG, IBEGMOPHOKO NCMBKIEBNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x56CB740", Offset = "0x56CA340", VA = "0x1856CB740", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x56CB910", Offset = "0x56CA510", VA = "0x1856CB910")]
	private void EBEEGOAAMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x56CB3A0", Offset = "0x56C9FA0", VA = "0x1856CB3A0", Slot = "4")]
	public void BGBAOJGMHAH(CMPJNDPOACO FEKJACABLNO, OGNGNPGEEPO AFPKMECFOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x56CB570", Offset = "0x56CA170", VA = "0x1856CB570", Slot = "5")]
	public void BGBAOJGMHAH(JHNPAHOFJND FAJJDHLHNBK, OGNGNPGEEPO AFPKMECFOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x56CBEE0", Offset = "0x56CAAE0", VA = "0x1856CBEE0", Slot = "6")]
	public void GBJBFCGLEHK(JHNPAHOFJND FAJJDHLHNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x56CCC60", Offset = "0x56CB860", VA = "0x1856CCC60", Slot = "7")]
	public void KEOOCIPLBMI(JHNPAHOFJND FAJJDHLHNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x56CBBC0", Offset = "0x56CA7C0", VA = "0x1856CBBC0", Slot = "8")]
	public void EKEJHFIDDCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xF05DD0", Offset = "0xF049D0", VA = "0x180F05DD0", Slot = "9")]
	public void HMOJEGKLGKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x56CBC00", Offset = "0x56CA800", VA = "0x1856CBC00", Slot = "10")]
	public void FFPFOIDEBJI(OGNGNPGEEPO AFPKMECFOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x56CCE40", Offset = "0x56CBA40", VA = "0x1856CCE40", Slot = "11")]
	public void MEJOCPAPOLJ(CMPJNDPOACO FEKJACABLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x56CCFE0", Offset = "0x56CBBE0", VA = "0x1856CCFE0", Slot = "12")]
	public void MEJOCPAPOLJ(JHNPAHOFJND FAJJDHLHNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x56CCAC0", Offset = "0x56CB6C0", VA = "0x1856CCAC0", Slot = "13")]
	public void KEIBODILNDJ(CMPJNDPOACO FEKJACABLNO, OOEHAPFDLKJ HCPDGKICMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x56CC780", Offset = "0x56CB380", VA = "0x1856CC780", Slot = "14")]
	public void KEIBODILNDJ(JHNPAHOFJND FAJJDHLHNBK, OOEHAPFDLKJ HCPDGKICMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x56CBAC0", Offset = "0x56CA6C0", VA = "0x1856CBAC0", Slot = "17")]
	public void EGBOCHGIHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x56CBFE0", Offset = "0x56CABE0", VA = "0x1856CBFE0", Slot = "15")]
	public void HIJLGDFDGMG(JHNPAHOFJND FAJJDHLHNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x56CB310", Offset = "0x56C9F10", VA = "0x1856CB310", Slot = "16")]
	public void APEPJDAHFHE(JHNPAHOFJND FAJJDHLHNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x108D6F0", Offset = "0x108C2F0", VA = "0x18108D6F0", Slot = "18")]
	public void PIKILENLJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x56CCD50", Offset = "0x56CB950", VA = "0x1856CCD50", Slot = "19")]
	public void KMEHDCBPCPH(OOEHAPFDLKJ HCPDGKICMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x56CBD30", Offset = "0x56CA930", VA = "0x1856CBD30")]
	private void FPFPKPDNKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x56CC920", Offset = "0x56CB520", VA = "0x1856CC920")]
	public void KEIBODILNDJ(JHNPAHOFJND FAJJDHLHNBK, OOEHAPFDLKJ HCPDGKICMEB, bool BJOEHGDHLMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x56CBB00", Offset = "0x56CA700", VA = "0x1856CBB00")]
	private void EHNMKJKCMDI(OOEHAPFDLKJ HCPDGKICMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x56CC450", Offset = "0x56CB050", VA = "0x1856CC450", Slot = "20")]
	public void HMMHJIIIGOK(CMPJNDPOACO FEKJACABLNO, Vector3 MHMOPLAGMMM, Vector3 NLPOHEBMCAB, Vector3 KLJKHGOKCJF, float KOBAMLKFGLK, float FLFBAFBDDKB, IReadOnlyList<Camera> KAFBICGGHJN, MLGPJHFBDKK JCCJAIKEGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x56CC080", Offset = "0x56CAC80", VA = "0x1856CC080", Slot = "21")]
	public void HMMHJIIIGOK(NPGKDJALCAI FEIHIPBAAHB, Vector3 MHMOPLAGMMM, Vector3 NLPOHEBMCAB, Vector3 KLJKHGOKCJF, float KOBAMLKFGLK, float FLFBAFBDDKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class PCCFDOJOJDG : BEOIEFPIHPF, IJAEOFCEPOA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly JAOMAGGCEIE KBKNGMOBLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	protected Bounds JBBHFGHANPM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds EEFMBIGMEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1AE18A0", Offset = "0x1AE04A0", VA = "0x181AE18A0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual LKJAONLPEHC CHCMIBHNCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x56CB280", Offset = "0x56C9E80", VA = "0x1856CB280", Slot = "12")]
		get
		{
			return default(LKJAONLPEHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x719660", Offset = "0x718260", VA = "0x180719660")]
	protected PCCFDOJOJDG(JAOMAGGCEIE FEKJACABLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x56CB210", Offset = "0x56C9E10", VA = "0x1856CB210", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "11")]
	public virtual bool ECCDOOJJOAI(LMMBNFLDKGF FEKJACABLNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int FKLOHFOBCBN(NADLMEPLBLH HCCNHCAJIKB);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int MIMOAMFENPA(NADLMEPLBLH HCCNHCAJIKB);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void LNMNJEAKCOI(NADLMEPLBLH HCCNHCAJIKB, NONPADBMJOO MOJPAKJHKFI, int GFKEGBDLGNM = -1);
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
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x56CD2B0", Offset = "0x56CBEB0", VA = "0x1856CD2B0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum KODIEEBLFLF
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class EKIAGPMMANB
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ECBODMJPDBI : IEnumerable<JDCPEGGMDLO>, IEnumerable, IEnumerator<JDCPEGGMDLO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private JDCPEGGMDLO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private JDCPEGGMDLO System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F53E0", Offset = "0x6F3FE0", VA = "0x1806F53E0")]
		[DebuggerHidden]
		public ECBODMJPDBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x56C49D0", Offset = "0x56C35D0", VA = "0x1856C49D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x56C4B40", Offset = "0x56C3740", VA = "0x1856C4B40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x56C4AB0", Offset = "0x56C36B0", VA = "0x1856C4AB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JDCPEGGMDLO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x56C4AB0", Offset = "0x56C36B0", VA = "0x1856C4AB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const int OAPANOINOEC = 3;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static JDCPEGGMDLO[][] NBMFILDFDND;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static INMMPFAAJID HANAMFJJCOE;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static ShapeRendererConfig MLLHCDMMPOK;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader BBEOOENDHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x56C5570", Offset = "0x56C4170", VA = "0x1856C5570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer PKGDBLPHJND
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x56C5F40", Offset = "0x56C4B40", VA = "0x1856C5F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x56C5670", Offset = "0x56C4270", VA = "0x1856C5670")]
	public static Mesh IOIFIDHIECC(KODIEEBLFLF GMDLFABFHKF, int HCCNHCAJIKB = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x56C5F30", Offset = "0x56C4B30", VA = "0x1856C5F30")]
	public static int MLLBPHFPADG(KODIEEBLFLF GMDLFABFHKF, int HCCNHCAJIKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x56C5420", Offset = "0x56C4020", VA = "0x1856C5420")]
	public static INMMPFAAJID EBONCMHFHEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x56C55F0", Offset = "0x56C41F0", VA = "0x1856C55F0")]
	[IteratorStateMachine(typeof(ECBODMJPDBI))]
	private static IEnumerable<JDCPEGGMDLO> ICFDOLBGDDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x56C50E0", Offset = "0x56C3CE0", VA = "0x1856C50E0")]
	public static JDCPEGGMDLO CHLAHPPLAGB(KODIEEBLFLF GMDLFABFHKF, int HCCNHCAJIKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x56C5650", Offset = "0x56C4250", VA = "0x1856C5650")]
	public static bool IOEBMJBCMON(this KODIEEBLFLF GMDLFABFHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x56C5B50", Offset = "0x56C4750", VA = "0x1856C5B50")]
	public static void LAAFAIOIBGL(KODIEEBLFLF GMDLFABFHKF, float3 GGPFLCCNMAH, out IKOCBEIOLPC OICEBHAODAJ, out float3 OJFAIJCJBOJ, out float CHAIMONFNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x56C5730", Offset = "0x56C4330", VA = "0x1856C5730")]
	public static void JJKFPMCOPEF(Vector3 GGPFLCCNMAH, KODIEEBLFLF GMDLFABFHKF, out Vector3 OJFAIJCJBOJ, out float CHAIMONFNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x56C55E0", Offset = "0x56C41E0", VA = "0x1856C55E0")]
	[MLLBDNCHPEI(LJIBMCNOLHI.ExitingPlayMode, 0)]
	private static void GKEEBJIFJHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x56C5D10", Offset = "0x56C4910", VA = "0x1856C5D10")]
	[MLLBDNCHPEI(LJIBMCNOLHI.ExitingPlayMode, 0)]
	private static void MHJJFGJGDEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IOGEDFODJKH
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool GHGKLPABKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material IEPPOFFDOLJ();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material EGDMPJBKIAB();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material BGEPCAKNNPH();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CDGCAOOCCAA(BMOEILFIHJP CFFANFHCACB);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BIHGLAKOKDM(DPANBBAKMDL CMJPNOPPKBE);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OLBNMMPMANI(GameObject HLJJNKOAONN);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GODHHLHMNDG(GameObject HLJJNKOAONN, bool NEGNKHHPPDA);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface IBEGMOPHOKO
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JAOMAGGCEIE LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	PCCFDOJOJDG LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CGNPKFJCOLC LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class OEBAJHOKOEK : EMDEHPHDHBH, IDisposable, IBEGMOPHOKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly global::MPMDJDCFKAB<CMPJNDPOACO, JAOMAGGCEIE> EHNLGDHEENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly global::MPMDJDCFKAB<JHNPAHOFJND, PCCFDOJOJDG> PHLKNFKLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly global::MPMDJDCFKAB<NPGKDJALCAI, CGNPKFJCOLC> LKNHILODEDF;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static IOGEDFODJKH MPIPGKEAFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x56CA8F0", Offset = "0x56C94F0", VA = "0x1856CA8F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x56CA210", Offset = "0x56C8E10", VA = "0x1856CA210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public JAOMAGGCEIE LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x56CAA80", Offset = "0x56C9680", VA = "0x1856CAA80", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public PCCFDOJOJDG LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x56CAA20", Offset = "0x56C9620", VA = "0x1856CAA20", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public CGNPKFJCOLC LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x56CAAE0", Offset = "0x56C96E0", VA = "0x1856CAAE0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x56CADA0", Offset = "0x56C99A0", VA = "0x1856CADA0")]
	public OEBAJHOKOEK(IOGEDFODJKH LGHEEBFGNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x56CA080", Offset = "0x56C8C80", VA = "0x1856CA080", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x56CA2E0", Offset = "0x56C8EE0", VA = "0x1856CA2E0", Slot = "4")]
	public CMPJNDPOACO IABNIDPKGIF(BLBOCCNKIPE CEECNJJKNFO)
	{
		return default(CMPJNDPOACO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x56CA020", Offset = "0x56C8C20", VA = "0x1856CA020", Slot = "5")]
	public void DEOPAFLJFEE(CMPJNDPOACO FEKJACABLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x56CA260", Offset = "0x56C8E60", VA = "0x1856CA260", Slot = "6")]
	public void FOPBDGHOJNJ(CMPJNDPOACO FEKJACABLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x56CA150", Offset = "0x56C8D50", VA = "0x1856CA150", Slot = "15")]
	public IEnumerable<Renderer> EJDJHDKCJEA(CMPJNDPOACO FEKJACABLNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x56CA430", Offset = "0x56C9030", VA = "0x1856CA430", Slot = "7")]
	public JHNPAHOFJND JBLHHLFGHFA(CMPJNDPOACO FEKJACABLNO, JGIENIGGMIN CEECNJJKNFO)
	{
		return default(JHNPAHOFJND);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x56CA930", Offset = "0x56C9530", VA = "0x1856CA930", Slot = "8")]
	public JHNPAHOFJND KHHFJFPGMLG(CMPJNDPOACO FEKJACABLNO, JCIFAILOKAO CEECNJJKNFO)
	{
		return default(JHNPAHOFJND);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x56CA3C0", Offset = "0x56C8FC0", VA = "0x1856CA3C0", Slot = "10")]
	public void IKIOKKEIDDB(JHNPAHOFJND FAJJDHLHNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x56CAD40", Offset = "0x56C9940", VA = "0x1856CAD40", Slot = "9")]
	public void OFEPKCNPKGN(JHNPAHOFJND FAJJDHLHNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x56CABB0", Offset = "0x56C97B0", VA = "0x1856CABB0", Slot = "11")]
	public NPGKDJALCAI MDHAIKOIOCD(LPJBOKONKED CEECNJJKNFO)
	{
		return default(NPGKDJALCAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x56CAB40", Offset = "0x56C9740", VA = "0x1856CAB40", Slot = "13")]
	public void LDIIIFIKBOJ(NPGKDJALCAI FEIHIPBAAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x56CA0F0", Offset = "0x56C8CF0", VA = "0x1856CA0F0", Slot = "12")]
	public void EAAKLMGMOGM(NPGKDJALCAI FEIHIPBAAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x56CA520", Offset = "0x56C9120", VA = "0x1856CA520", Slot = "14")]
	public JOMACKCFBMO JDGJGDEFMKM(LMMBNFLDKGF AFJLPAFJGKD, IEnumerable<JHNPAHOFJND> PHLKNFKLEML, int IMBOBPBOMDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CGNPKFJCOLC : EGDDKOFJHME
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class AFBEAHHEGEK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public CGNPKFJCOLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6F53E0", Offset = "0x6F3FE0", VA = "0x1806F53E0")]
		[DebuggerHidden]
		public AFBEAHHEGEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x56C0F00", Offset = "0x56BFB00", VA = "0x1856C0F00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x56C0C20", Offset = "0x56BF820", VA = "0x1856C0C20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x56C0FA0", Offset = "0x56BFBA0", VA = "0x1856C0FA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x56C0EB0", Offset = "0x56BFAB0", VA = "0x1856C0EB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x56C0E10", Offset = "0x56BFA10", VA = "0x1856C0E10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x56C0E10", Offset = "0x56BFA10", VA = "0x1856C0E10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly LPJBOKONKED EBAOEBCKDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly IBEGMOPHOKO NCMBKIEBNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private MFMEPDCGIME AINMIMBOLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private List<HIBHHPJGHKA> OOBNEDKAEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private List<HIBHHPJGHKA> EDEMHHOLDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private GameObject OMKOEMCIANI;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x56C1CB0", Offset = "0x56C08B0", VA = "0x1856C1CB0")]
	public static CGNPKFJCOLC IJFDGNPJLBL(LPJBOKONKED CEECNJJKNFO, IBEGMOPHOKO NCMBKIEBNCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x56C23D0", Offset = "0x56C0FD0", VA = "0x1856C23D0")]
	private CGNPKFJCOLC(LPJBOKONKED CEECNJJKNFO, IBEGMOPHOKO NCMBKIEBNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x56C1E10", Offset = "0x56C0A10", VA = "0x1856C1E10")]
	public void KHFNNCAMANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x56C2360", Offset = "0x56C0F60", VA = "0x1856C2360")]
	[IteratorStateMachine(typeof(AFBEAHHEGEK))]
	public IEnumerable<Renderer> POMKHGAHLJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x56C1240", Offset = "0x56BFE40", VA = "0x1856C1240", Slot = "4")]
	public void BIKNGNMBDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x56C1210", Offset = "0x56BFE10", VA = "0x1856C1210")]
	private void BEGPOAKDIAA(Vector3 CFJDFEALBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x56C0FE0", Offset = "0x56BFBE0", VA = "0x1856C0FE0")]
	public void ADGIMOCDCAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HIBHHPJGHKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct OCNKGGIOHLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public NONPADBMJOO KKJHBEMMKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public LMMBNFLDKGF JMHDELAGFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int EFGFAJDNGDL;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class HFMCNBOGMIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public HIBHHPJGHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public NADLMEPLBLH lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public List<OCNKGGIOHLC> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public HFMCNBOGMIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JCJJEGHDLKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public JOMACKCFBMO combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public HFMCNBOGMIH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public JCJJEGHDLKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x56C8C80", Offset = "0x56C7880", VA = "0x1856C8C80")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x56C8CF0", Offset = "0x56C78F0", VA = "0x1856C8CF0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x56C8D30", Offset = "0x56C7930", VA = "0x1856C8D30")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int[] NHOEKOGJAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private DOPIMEHNIEO NLNDANFFAJO;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static Matrix4x4 DPKNNJIOKPD;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh HKMJNJLAEFB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5E4490", Offset = "0x5E3090", VA = "0x1805E4490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int ONDDCMIODEL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x670670", Offset = "0x66F270", VA = "0x180670670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x736910", Offset = "0x735510", VA = "0x180736910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x56C6840", Offset = "0x56C5440", VA = "0x1856C6840")]
	public void EHFFDIJKNAD(List<LMMBNFLDKGF> KOKOFPJJPME, Matrix4x4[] OBNGCPBMHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x56C6F50", Offset = "0x56C5B50", VA = "0x1856C6F50")]
	public static List<HIBHHPJGHKA> NEKFKHFNPIG(List<JAOMAGGCEIE> APHNBBNEDJF, NADLMEPLBLH HCCNHCAJIKB, Bounds IPEPCLOOLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x56C6A70", Offset = "0x56C5670", VA = "0x1856C6A70")]
	private JobHandle EJJOICNIDNE(JOMACKCFBMO DEFNNFNADJG, int NAHDGAIABDG, int EKGKKDAMCKN, NADLMEPLBLH HCCNHCAJIKB, List<OCNKGGIOHLC> PLLGBKGAMBL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x56C6E50", Offset = "0x56C5A50", VA = "0x1856C6E50")]
	private void FAOCMHICHLC(List<OCNKGGIOHLC> PLLGBKGAMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x56C7620", Offset = "0x56C6220", VA = "0x1856C7620")]
	private HIBHHPJGHKA(List<OCNKGGIOHLC> PLLGBKGAMBL, int NAHDGAIABDG, int EKGKKDAMCKN, NADLMEPLBLH HCCNHCAJIKB, Bounds IPEPCLOOLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x56C67C0", Offset = "0x56C53C0", VA = "0x1856C67C0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private MaterialPropertyBlock DJPNFPDPFFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private HIBHHPJGHKA GIJGPGKFDMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private List<LMMBNFLDKGF> HIMMDCCPMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private RenderTexture HEALBGCCAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private ComputeBuffer DIDNKIDHPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private ComputeShader BFALJBAGEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private Matrix4x4[] LBPPFFEGJKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int PHKMLFJCBAH;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer EPBFFCJAEHH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x5E44A0", Offset = "0x5E30A0", VA = "0x1805E44A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int GBEHNGAIAOG
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x56CDE30", Offset = "0x56CCA30", VA = "0x1856CDE30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x56CD2E0", Offset = "0x56CBEE0", VA = "0x1856CD2E0")]
		public static List<SkinnedShapeRenderer> Create(GameObject FEKJACABLNO, List<HIBHHPJGHKA> LCAJNOPHELH, List<LMMBNFLDKGF> HIMMDCCPMGF, Material MLMEKJLFCPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x56CD8B0", Offset = "0x56CC4B0", VA = "0x1856CD8B0")]
		public void Init(HIBHHPJGHKA GIJGPGKFDMC, List<LMMBNFLDKGF> HIMMDCCPMGF, Material MLMEKJLFCPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x56CDDA0", Offset = "0x56CC9A0", VA = "0x1856CDDA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x56CDD10", Offset = "0x56CC910", VA = "0x1856CDD10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x56CDCD0", Offset = "0x56CC8D0", VA = "0x1856CDCD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x56CD6A0", Offset = "0x56CC2A0", VA = "0x1856CD6A0")]
		private void FBFIBFGHILA(ScriptableRenderContext BGDHIGEIIHJ, Camera[] CEOKNNLCJIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x56CD4F0", Offset = "0x56CC0F0", VA = "0x1856CD4F0")]
		private void EHFFDIJKNAD(CommandBuffer CANEEIGIOFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class FFJPKCHAMHH
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static byte[] JNJHEFFMOCP;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int IPFMGPPGOLG;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int LHFIEOGDAOP;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static BigInteger AMDHHIFBNAO;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FFJPKCHAMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x56C6360", Offset = "0x56C4F60", VA = "0x1856C6360")]
	private static string OFIDAIMKACA(byte[] DBJNEGCCKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x56C6030", Offset = "0x56C4C30", VA = "0x1856C6030")]
	public static string MOEDIEOHEKO(byte[] DNJADMBKFKK, bool KBNEPACBOAE)
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

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
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
