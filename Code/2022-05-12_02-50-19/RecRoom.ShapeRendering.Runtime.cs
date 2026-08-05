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
public enum GDBJIIGELBF
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
public static class EMDBFCNDJFI
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<GDBJIIGELBF> FOAMLFFIACC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4CB1FF0", Offset = "0x4CB13F0", VA = "0x184CB1FF0")]
	static EMDBFCNDJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4CB1FF0", Offset = "0x4CB13F0", VA = "0x184CB1FF0")]
	[LOHNPEDAEGK]
	private static void JBPGKBOBEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4CB1F70", Offset = "0x4CB1370", VA = "0x184CB1F70")]
	public static bool CJNIFIAGNNO(this GDBJIIGELBF OOIIGOFDOPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BGPALJFCKME
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
public enum MALKCFMPGNK
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
public enum KBKPMMGIAEF
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
public enum AACFLJELPEB
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
public class AHBDAPFFNOE : DMIJKLOADGM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private const byte OPIFNENDKHP = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private byte JHKNNLEEJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<SkinnedShapeRenderer>[] DFHPKLGGLPI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int COOAGPHLBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x552CD0", Offset = "0x5520D0", VA = "0x180552CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A10", Offset = "0x5D2E10", VA = "0x1805D3A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int IALPOKHJMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x552CC0", Offset = "0x5520C0", VA = "0x180552CC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D9590", Offset = "0x6D8990", VA = "0x1806D9590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float NKALBPNNCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x10A96D0", Offset = "0x10A8AD0", VA = "0x1810A96D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x10A9650", Offset = "0x10A8A50", VA = "0x1810A9650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float LJJOFBJLJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xF95F00", Offset = "0xF95300", VA = "0x180F95F00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xF95CE0", Offset = "0xF950E0", VA = "0x180F95CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> CKJDMFHIALF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4CAE380", Offset = "0x4CAD780", VA = "0x184CAE380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> OLEEJNJMKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3F7C960", Offset = "0x3F7BD60", VA = "0x183F7C960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject CGAFANNDMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x57AA30", Offset = "0x579E30", VA = "0x18057AA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6963A0", Offset = "0x6957A0", VA = "0x1806963A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte DMCOOEHPMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4CAE5E0", Offset = "0x4CAD9E0", VA = "0x184CAE5E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4CAE630", Offset = "0x4CADA30", VA = "0x184CAE630")]
	public AHBDAPFFNOE(List<HKEGEDDKLCE> GBLPPCMEFBI, List<HKEGEDDKLCE> GKIMIMJJIBH, List<Transform> EAGFLFJHBDK, Material CAGCNPHDPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4CAE4D0", Offset = "0x4CAD8D0", VA = "0x184CAE4D0")]
	private int PBLDBHMICNC(List<HKEGEDDKLCE> ACIKEDBNEON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4CAE220", Offset = "0x4CAD620", VA = "0x184CAE220")]
	private void IBEICLHGOBF(int PDIJDGACECA, bool JEECLOADAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4CAE3E0", Offset = "0x4CAD7E0", VA = "0x184CAE3E0")]
	public void OFHMEMDGPOK(Vector3 FMAEIHEJDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4CAE190", Offset = "0x4CAD590", VA = "0x184CAE190", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4CAE150", Offset = "0x4CAD550", VA = "0x184CAE150")]
	public void AJAGFMBPLHC(Transform JAOGAMHNOFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LJDOPHPAACO : AINNHCDNCMM, LFCBCFKBGJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class OPFIIJCDOLM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LJDOPHPAACO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6633E0", Offset = "0x6627E0", VA = "0x1806633E0")]
		[DebuggerHidden]
		public OPFIIJCDOLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8A60", Offset = "0x4CB7E60", VA = "0x184CB8A60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4CB85B0", Offset = "0x4CB79B0", VA = "0x184CB85B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8BE0", Offset = "0x4CB7FE0", VA = "0x184CB8BE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8C20", Offset = "0x4CB8020", VA = "0x184CB8C20")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8C70", Offset = "0x4CB8070", VA = "0x184CB8C70")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8A10", Offset = "0x4CB7E10", VA = "0x184CB8A10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8970", Offset = "0x4CB7D70", VA = "0x184CB8970", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8970", Offset = "0x4CB7D70", VA = "0x184CB8970", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OJIEADPKGNF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LJDOPHPAACO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6633E0", Offset = "0x6627E0", VA = "0x1806633E0")]
		[DebuggerHidden]
		public OJIEADPKGNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8400", Offset = "0x4CB7800", VA = "0x184CB8400", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8060", Offset = "0x4CB7460", VA = "0x184CB8060", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8520", Offset = "0x4CB7920", VA = "0x184CB8520")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8570", Offset = "0x4CB7970", VA = "0x184CB8570")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4CB83B0", Offset = "0x4CB77B0", VA = "0x184CB83B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8310", Offset = "0x4CB7710", VA = "0x184CB8310", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8310", Offset = "0x4CB7710", VA = "0x184CB8310", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private DBMFGKIIPCJ BAOCGGJNLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<DOJFBAHJMOA> NDICLLKLBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<ClusterMeshRenderer> IEBHMONBANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BatchedMeshRenderer NHGOFLNAHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool NIAFGDPHOCN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<ALEIHAPCDEM> IEODPKJLKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FHGBINAGMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4CB70E0", Offset = "0x4CB64E0", VA = "0x184CB70E0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform JMJFHNBMAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4CB7120", Offset = "0x4CB6520", VA = "0x184CB7120", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> GEHKIAGFODM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x553010", Offset = "0x552410", VA = "0x180553010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x553020", Offset = "0x552420", VA = "0x180553020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4CB7350", Offset = "0x4CB6750", VA = "0x184CB7350")]
	public LJDOPHPAACO(DBMFGKIIPCJ GGALGOABPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4CB6460", Offset = "0x4CB5860", VA = "0x184CB6460", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4CB6FA0", Offset = "0x4CB63A0", VA = "0x184CB6FA0")]
	public void KCLLGEJMGAB(DOJFBAHJMOA CLCKFBNHOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4CB6490", Offset = "0x4CB5890", VA = "0x184CB6490")]
	public void EPGMMIBEDJL(DOJFBAHJMOA CLCKFBNHOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4CB69E0", Offset = "0x4CB5DE0", VA = "0x184CB69E0", Slot = "4")]
	public void JGIJBONPFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4CB72C0", Offset = "0x4CB66C0", VA = "0x184CB72C0")]
	public void PKNIMKAHKBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4CB7170", Offset = "0x4CB6570", VA = "0x184CB7170")]
	private void OGDHEJOKMHL(DOJFBAHJMOA CLCKFBNHOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4CB6500", Offset = "0x4CB5900", VA = "0x184CB6500")]
	public void GLKIOKPJKMP(bool GLNKNFJJJJE, bool EEKABEMHHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4CB6320", Offset = "0x4CB5720", VA = "0x184CB6320")]
	protected void AMPFGKPNIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4CB7070", Offset = "0x4CB6470", VA = "0x184CB7070")]
	[IteratorStateMachine(typeof(OPFIIJCDOLM))]
	public IEnumerable<Renderer> LBGMFAGFPPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4CB6F30", Offset = "0x4CB6330", VA = "0x184CB6F30")]
	[IteratorStateMachine(typeof(OJIEADPKGNF))]
	public IEnumerable<Renderer> JLAFLPLLJKM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class MCNMKPIDNGH : DOJFBAHJMOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private JNHHNEHKIDK JPNPCMCIIPB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4CB7600", Offset = "0x4CB6A00", VA = "0x184CB7600")]
	private NativeList<NMLKAKBGPME> LDIKPBPAEMI()
	{
		return default(NativeList<NMLKAKBGPME>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4CB62D0", Offset = "0x4CB56D0", VA = "0x184CB62D0")]
	public MCNMKPIDNGH(LJDOPHPAACO PGMAAINPEGN, JNHHNEHKIDK GGALGOABPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4CB7C00", Offset = "0x4CB7000", VA = "0x184CB7C00", Slot = "13")]
	public override int PBLDBHMICNC(CKOBBCCFDDO EAENLCOCJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4CB73E0", Offset = "0x4CB67E0", VA = "0x184CB73E0", Slot = "14")]
	public override int GJOLGMBMGCA(CKOBBCCFDDO EAENLCOCJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4CB76D0", Offset = "0x4CB6AD0", VA = "0x184CB76D0", Slot = "15")]
	public override void LJMDJONNCIJ(CKOBBCCFDDO EAENLCOCJLC, OJPIEEFGLNM GPOGJDEILFE, int CGMOAFBDHFN = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct ILPEMICCAHJ : global::EKIGKPCJPCI<ILPEMICCAHJ>, FPGNOEEIOFL, IEquatable<ILPEMICCAHJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int EEKKOADMDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4F0", Offset = "0x7FD8F0", VA = "0x1807FE4F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4C0", Offset = "0x8AD8C0", VA = "0x1808AE4C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OACAMHLIHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4D0", Offset = "0x7FD8D0", VA = "0x1807FE4D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x887D70", Offset = "0x887170", VA = "0x180887D70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3F44B80", Offset = "0x3F43F80", VA = "0x183F44B80", Slot = "8")]
	public bool Equals(ILPEMICCAHJ OGCBGOIPCGM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4CB3890", Offset = "0x4CB2C90", VA = "0x184CB3890")]
	public static bool CKDNMNCPBHO(ILPEMICCAHJ HBMKOKCEHDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum OGDIOOFAKJO
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
public interface DBMFGKIIPCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform GDPJCCPFCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OGDIOOFAKJO JMOIONOMMFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EJMJFBBDFHH : global::EKIGKPCJPCI<EJMJFBBDFHH>, FPGNOEEIOFL, IEquatable<EJMJFBBDFHH>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int EEKKOADMDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4F0", Offset = "0x7FD8F0", VA = "0x1807FE4F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4C0", Offset = "0x8AD8C0", VA = "0x1808AE4C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int OACAMHLIHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4D0", Offset = "0x7FD8D0", VA = "0x1807FE4D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x887D70", Offset = "0x887170", VA = "0x180887D70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3F44B80", Offset = "0x3F43F80", VA = "0x183F44B80", Slot = "8")]
	public bool Equals(EJMJFBBDFHH OGCBGOIPCGM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4CB1F30", Offset = "0x4CB1330", VA = "0x184CB1F30")]
	public static bool CKDNMNCPBHO(EJMJFBBDFHH HBMKOKCEHDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OOGCALEAEFC
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform GDPJCCPFCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float CNMGCMIJKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 CIJNOLDOHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GDBJIIGELBF LJBGCDNIMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	BGPALJFCKME NBKAEGJDIKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HJAJHBJFGIO : OOGCALEAEFC
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	KJAPMPNOIHF NAJLDFJFMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool FIDIFPKMKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JNHHNEHKIDK : OOGCALEAEFC
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool DPBBFAOECJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NJOHAFDEFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float AOLBOCPGAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int FKELKHKJEOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool CHMHLIOHEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<NMLKAKBGPME> LDIKPBPAEMI();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EILNMJCLHCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGCPNCOEFKH(EJMJFBBDFHH CLCKFBNHOPI, KBKPMMGIAEF HPBLGCLPNED);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGCPNCOEFKH(ILPEMICCAHJ PGMAAINPEGN, KBKPMMGIAEF HPBLGCLPNED);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCADEMDIEIM(ILPEMICCAHJ PGMAAINPEGN);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DCADEMDIEIM(EJMJFBBDFHH CLCKFBNHOPI);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BAOLPIKLBKB(ILPEMICCAHJ PGMAAINPEGN, AACFLJELPEB HHDFIJECABM);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OENHBFCMLNC(ILPEMICCAHJ PGMAAINPEGN, Vector3 PCIELJMMPGA, Vector3 PMHJLAAHLBA, Vector3 CJEACCLCKAA, float IALPLMFJOHO, float GEFBBMKBNFK, IReadOnlyList<Camera> KKPDGIOMFJG, MALKCFMPGNK BIKBCGHBAMJ);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OENHBFCMLNC(IIGHBBJIBLJ POBODOJHCOM, Vector3 PCIELJMMPGA, Vector3 PMHJLAAHLBA, Vector3 CJEACCLCKAA, float IALPLMFJOHO, float GEFBBMKBNFK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LAKKNBHGIID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILPEMICCAHJ MOECAJEFNFD(DBMFGKIIPCJ GGALGOABPMH);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCKCLKGDAEG(ILPEMICCAHJ PGMAAINPEGN);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMMFFNKJPGM(ILPEMICCAHJ PGMAAINPEGN);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EJMJFBBDFHH KPEFMFNOHEJ(ILPEMICCAHJ PGMAAINPEGN, HJAJHBJFGIO GGALGOABPMH);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EJMJFBBDFHH PADIPAGCGOG(ILPEMICCAHJ PGMAAINPEGN, JNHHNEHKIDK GGALGOABPMH);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPOMOCOAKFA(EJMJFBBDFHH CLCKFBNHOPI);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JLNPHLJIAGF(EJMJFBBDFHH CLCKFBNHOPI);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IIGHBBJIBLJ JOIKOHAOPIO(GEFJJOLIOKB GGALGOABPMH);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OJPGAFAPDKE(IIGHBBJIBLJ POBODOJHCOM);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IONIBIDHCJN(IIGHBBJIBLJ POBODOJHCOM);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LJCGODPDPOD EALFODCAKMF(Transform LPEKHAHIKAH, IEnumerable<EJMJFBBDFHH> NDICLLKLBNE, int AOLPFAJLKCE);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> NIFNEJHADFM(ILPEMICCAHJ PGMAAINPEGN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IIGHBBJIBLJ : global::EKIGKPCJPCI<IIGHBBJIBLJ>, FPGNOEEIOFL, IEquatable<IIGHBBJIBLJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EEKKOADMDBE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4F0", Offset = "0x7FD8F0", VA = "0x1807FE4F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4C0", Offset = "0x8AD8C0", VA = "0x1808AE4C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int OACAMHLIHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4D0", Offset = "0x7FD8D0", VA = "0x1807FE4D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x887D70", Offset = "0x887170", VA = "0x180887D70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3F44B80", Offset = "0x3F43F80", VA = "0x183F44B80", Slot = "8")]
	public bool Equals(IIGHBBJIBLJ OGCBGOIPCGM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4CB3850", Offset = "0x4CB2C50", VA = "0x184CB3850")]
	public static bool CKDNMNCPBHO(IIGHBBJIBLJ HBMKOKCEHDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GEFJJOLIOKB
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int LEMOIBDLPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform CDFLNHACLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool HEBJDGEOGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ILPEMICCAHJ GetBone(int EGIMPHGOEAK);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int EGIMPHGOEAK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class KHCMCNEALHP : DOJFBAHJMOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public HJAJHBJFGIO OMGLLEANLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int[] LFAKKHENPKF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override OEDOMAIFGLJ POOLNAEKKME
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4CB53C0", Offset = "0x4CB47C0", VA = "0x184CB53C0", Slot = "12")]
		get
		{
			return default(OEDOMAIFGLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 LMCNJAJFAMH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4CB5760", Offset = "0x4CB4B60", VA = "0x184CB5760")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4CB62D0", Offset = "0x4CB56D0", VA = "0x184CB62D0")]
	public KHCMCNEALHP(LJDOPHPAACO PGMAAINPEGN, HJAJHBJFGIO GGALGOABPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4CB4E20", Offset = "0x4CB4220", VA = "0x184CB4E20", Slot = "11")]
	public override bool GCJMEKOJEIA(Transform PGMAAINPEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4CB5FF0", Offset = "0x4CB53F0", VA = "0x184CB5FF0", Slot = "13")]
	public override int PBLDBHMICNC(CKOBBCCFDDO EAENLCOCJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4CB5320", Offset = "0x4CB4720", VA = "0x184CB5320", Slot = "14")]
	public override int GJOLGMBMGCA(CKOBBCCFDDO EAENLCOCJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4CB6090", Offset = "0x4CB5490", VA = "0x184CB6090")]
	private int POFBHJJMAOG(CKOBBCCFDDO EAENLCOCJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4CB5940", Offset = "0x4CB4D40", VA = "0x184CB5940", Slot = "15")]
	public override void LJMDJONNCIJ(CKOBBCCFDDO EAENLCOCJLC, OJPIEEFGLNM GPOGJDEILFE, int CGMOAFBDHFN = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FDNJEGDJIBN
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGNKCDOLLDO(AACFLJELPEB HHDFIJECABM, Renderer GOOIHCLNPGJ, int JBAPDGIGDAI);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKGJMGOJDJC(Renderer GOOIHCLNPGJ, MALKCFMPGNK BIKBCGHBAMJ, Vector3 PCIELJMMPGA, Vector3 PMHJLAAHLBA, Vector3 CJEACCLCKAA, float IALPLMFJOHO, float GEFBBMKBNFK, float OPIDIPJEIAL = -1f, [Optional] Color? EHNHJILBGGB, [Optional] IReadOnlyList<Camera> CGOCICMJOLH);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEIGKAJGNKK(Renderer GOOIHCLNPGJ, int JBAPDGIGDAI);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GHHHNAPCKDG();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MLCBPPDFCAH(int EIFPOOIIOLK, KBKPMMGIAEF HHDFIJECABM, Renderer GOOIHCLNPGJ, int JBAPDGIGDAI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BMNMNKHAHIN : EILNMJCLHCA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly FDNJEGDJIBN NOGNKGBDCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly LCEEOBMLHNN AOJHONAJMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MeshRenderer KMIPBAINHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private BCHPOKMHCEB EBMLBKBNBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MeshRenderer LHHAKBGCJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private BCHPOKMHCEB GNCFAHCGCIN;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x565990", Offset = "0x564D90", VA = "0x180565990")]
	public BMNMNKHAHIN(FDNJEGDJIBN HNBIBDMFHFI, LCEEOBMLHNN AOJHONAJMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4CB0240", Offset = "0x4CAF640", VA = "0x184CB0240", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4CB0560", Offset = "0x4CAF960", VA = "0x184CB0560", Slot = "4")]
	public void HGCPNCOEFKH(EJMJFBBDFHH CLCKFBNHOPI, KBKPMMGIAEF HPBLGCLPNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4CB0390", Offset = "0x4CAF790", VA = "0x184CB0390", Slot = "5")]
	public void HGCPNCOEFKH(ILPEMICCAHJ PGMAAINPEGN, KBKPMMGIAEF HPBLGCLPNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4CAFE50", Offset = "0x4CAF250", VA = "0x184CAFE50", Slot = "6")]
	public void DCADEMDIEIM(ILPEMICCAHJ PGMAAINPEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4CAFFF0", Offset = "0x4CAF3F0", VA = "0x184CAFFF0", Slot = "7")]
	public void DCADEMDIEIM(EJMJFBBDFHH CLCKFBNHOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4CAFCB0", Offset = "0x4CAF0B0", VA = "0x184CAFCB0", Slot = "8")]
	public void BAOLPIKLBKB(ILPEMICCAHJ PGMAAINPEGN, AACFLJELPEB HHDFIJECABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4CB0BB0", Offset = "0x4CAFFB0", VA = "0x184CB0BB0", Slot = "9")]
	public void OENHBFCMLNC(ILPEMICCAHJ PGMAAINPEGN, Vector3 PCIELJMMPGA, Vector3 PMHJLAAHLBA, Vector3 CJEACCLCKAA, float IALPLMFJOHO, float GEFBBMKBNFK, IReadOnlyList<Camera> KKPDGIOMFJG, MALKCFMPGNK BIKBCGHBAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4CB07E0", Offset = "0x4CAFBE0", VA = "0x184CB07E0", Slot = "10")]
	public void OENHBFCMLNC(IIGHBBJIBLJ POBODOJHCOM, Vector3 PCIELJMMPGA, Vector3 PMHJLAAHLBA, Vector3 CJEACCLCKAA, float IALPLMFJOHO, float GEFBBMKBNFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class DOJFBAHJMOA : JOJKPIPHDPJ, ALEIHAPCDEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected Bounds EKIAFCLKENG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public LJDOPHPAACO CGAFANNDMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551890", VA = "0x180552490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds EPJNBENNCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1A40800", Offset = "0x1A3FC00", VA = "0x181A40800", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual OEDOMAIFGLJ POOLNAEKKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4CB1EA0", Offset = "0x4CB12A0", VA = "0x184CB1EA0", Slot = "12")]
		get
		{
			return default(OEDOMAIFGLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4CB1E30", Offset = "0x4CB1230", VA = "0x184CB1E30", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x552EC0", Offset = "0x5522C0", VA = "0x180552EC0", Slot = "11")]
	public virtual bool GCJMEKOJEIA(Transform PGMAAINPEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int PBLDBHMICNC(CKOBBCCFDDO EAENLCOCJLC);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int GJOLGMBMGCA(CKOBBCCFDDO EAENLCOCJLC);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void LJMDJONNCIJ(CKOBBCCFDDO EAENLCOCJLC, OJPIEEFGLNM GPOGJDEILFE, int CGMOAFBDHFN = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	protected DOJFBAHJMOA()
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
		[Cpp2IlInjected.Address(RVA = "0x4CB8CC0", Offset = "0x4CB80C0", VA = "0x184CB8CC0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum KJAPMPNOIHF
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
public static class CFFPCPFPIFI
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AOHPBIGJEGM : IEnumerable<DLEEBHOIDID>, IEnumerable, IEnumerator<DLEEBHOIDID>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private DLEEBHOIDID <>2__current;

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
		private DLEEBHOIDID System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6633E0", Offset = "0x6627E0", VA = "0x1806633E0")]
		[DebuggerHidden]
		public AOHPBIGJEGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4CAE8F0", Offset = "0x4CADCF0", VA = "0x184CAE8F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4CAEA60", Offset = "0x4CADE60", VA = "0x184CAEA60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4CAE9D0", Offset = "0x4CADDD0", VA = "0x184CAE9D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DLEEBHOIDID> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4CAE9D0", Offset = "0x4CADDD0", VA = "0x184CAE9D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int OLGKFIFKIOI = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static DLEEBHOIDID[][] MJNFENLCIEI;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static HNPKGCIPJKK EBFHFOLKDHD;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static ShapeRendererConfig FKPOPGJLAPO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader KIOPAHJBFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4CB1D20", Offset = "0x4CB1120", VA = "0x184CB1D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer MAOBFHJLCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4CB14B0", Offset = "0x4CB08B0", VA = "0x184CB14B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4CB1C60", Offset = "0x4CB1060", VA = "0x184CB1C60")]
	public static Mesh MNDJJIIKDNI(KJAPMPNOIHF HOHEPCJOGKM, int EAENLCOCJLC = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4CB0EE0", Offset = "0x4CB02E0", VA = "0x184CB0EE0")]
	public static int BKLDJPNPBDP(KJAPMPNOIHF HOHEPCJOGKM, int EAENLCOCJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4CB1B00", Offset = "0x4CB0F00", VA = "0x184CB1B00")]
	public static HNPKGCIPJKK JHCAPCMFGEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4CB0EF0", Offset = "0x4CB02F0", VA = "0x184CB0EF0")]
	[IteratorStateMachine(typeof(AOHPBIGJEGM))]
	private static IEnumerable<DLEEBHOIDID> DNDMAAHOMPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4CB0F50", Offset = "0x4CB0350", VA = "0x184CB0F50")]
	public static DLEEBHOIDID GGMJFAMGKPO(KJAPMPNOIHF HOHEPCJOGKM, int EAENLCOCJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4CB1D90", Offset = "0x4CB1190", VA = "0x184CB1D90")]
	public static bool PNEOEKPLDBA(this KJAPMPNOIHF HOHEPCJOGKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4CB1520", Offset = "0x4CB0920", VA = "0x184CB1520")]
	public static void HKBMPDENCLO(KJAPMPNOIHF HOHEPCJOGKM, float3 NNDJBCAMEHI, out GBNEOECLGGD NIHACGGJDCP, out float3 IPPCLOJHGJI, out float JGJJGLOODMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4CB16E0", Offset = "0x4CB0AE0", VA = "0x184CB16E0")]
	public static void JELGFKDNGHC(Vector3 NNDJBCAMEHI, KJAPMPNOIHF HOHEPCJOGKM, out Vector3 IPPCLOJHGJI, out float JGJJGLOODMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4CB1C50", Offset = "0x4CB1050", VA = "0x184CB1C50")]
	[KLMIIILDGMA(LHKHIKFHCPH.ExitingPlayMode, 0)]
	private static void LPJNLIJKCEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4CB1290", Offset = "0x4CB0690", VA = "0x184CB1290")]
	[KLMIIILDGMA(LHKHIKFHCPH.ExitingPlayMode, 0)]
	private static void GNDELCBBLAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DDABIAKNIEF
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool LMEBBAFMJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material BBPJJMCNMDP();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material DDEDILIDKCE();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material OAGFNKDJAKP();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PIDEPPFAHNN(GDBJIIGELBF CPOJLHBDJDC);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FJHKBOIEGNF(BGPALJFCKME ILAPNPKBPJH);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EHKPMNGONGK(GameObject CMGFKLKICHP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NKMPBHGOKOL(GameObject CMGFKLKICHP, bool LKNCPKFACDN);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface LCEEOBMLHNN
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	LJDOPHPAACO DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	DOJFBAHJMOA DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	BCDHDCFHAKH DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class JAODJMPPFEB : LAKKNBHGIID, IDisposable, LCEEOBMLHNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::EGHOEMDNMHG<ILPEMICCAHJ, LJDOPHPAACO> CGMPFNPIEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::EGHOEMDNMHG<EJMJFBBDFHH, DOJFBAHJMOA> NDICLLKLBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly global::EGHOEMDNMHG<IIGHBBJIBLJ, BCDHDCFHAKH> KFBMHJHBNAC;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static DDABIAKNIEF CMFBKDKKCEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4CB40B0", Offset = "0x4CB34B0", VA = "0x184CB40B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4CB3EE0", Offset = "0x4CB32E0", VA = "0x184CB3EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LJDOPHPAACO DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4CB4440", Offset = "0x4CB3840", VA = "0x184CB4440", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DOJFBAHJMOA DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4CB43E0", Offset = "0x4CB37E0", VA = "0x184CB43E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public BCDHDCFHAKH DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4CB4380", Offset = "0x4CB3780", VA = "0x184CB4380", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4CB45F0", Offset = "0x4CB39F0", VA = "0x184CB45F0")]
	public JAODJMPPFEB(DDABIAKNIEF HNBIBDMFHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4CB39A0", Offset = "0x4CB2DA0", VA = "0x184CB39A0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4CB41E0", Offset = "0x4CB35E0", VA = "0x184CB41E0", Slot = "4")]
	public ILPEMICCAHJ MOECAJEFNFD(DBMFGKIIPCJ GGALGOABPMH)
	{
		return default(ILPEMICCAHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4CB3E10", Offset = "0x4CB3210", VA = "0x184CB3E10", Slot = "5")]
	public void FCKCLKGDAEG(ILPEMICCAHJ PGMAAINPEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4CB38D0", Offset = "0x4CB2CD0", VA = "0x184CB38D0", Slot = "6")]
	public void AMMFFNKJPGM(ILPEMICCAHJ PGMAAINPEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4CB42C0", Offset = "0x4CB36C0", VA = "0x184CB42C0", Slot = "15")]
	public IEnumerable<Renderer> NIFNEJHADFM(ILPEMICCAHJ PGMAAINPEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4CB40F0", Offset = "0x4CB34F0", VA = "0x184CB40F0", Slot = "7")]
	public EJMJFBBDFHH KPEFMFNOHEJ(ILPEMICCAHJ PGMAAINPEGN, HJAJHBJFGIO GGALGOABPMH)
	{
		return default(EJMJFBBDFHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4CB4500", Offset = "0x4CB3900", VA = "0x184CB4500", Slot = "8")]
	public EJMJFBBDFHH PADIPAGCGOG(ILPEMICCAHJ PGMAAINPEGN, JNHHNEHKIDK GGALGOABPMH)
	{
		return default(EJMJFBBDFHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4CB3F30", Offset = "0x4CB3330", VA = "0x184CB3F30", Slot = "10")]
	public void JLNPHLJIAGF(EJMJFBBDFHH CLCKFBNHOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4CB3940", Offset = "0x4CB2D40", VA = "0x184CB3940", Slot = "9")]
	public void BPOMOCOAKFA(EJMJFBBDFHH CLCKFBNHOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4CB3FA0", Offset = "0x4CB33A0", VA = "0x184CB3FA0", Slot = "11")]
	public IIGHBBJIBLJ JOIKOHAOPIO(GEFJJOLIOKB GGALGOABPMH)
	{
		return default(IIGHBBJIBLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4CB3E70", Offset = "0x4CB3270", VA = "0x184CB3E70", Slot = "13")]
	public void IONIBIDHCJN(IIGHBBJIBLJ POBODOJHCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4CB44A0", Offset = "0x4CB38A0", VA = "0x184CB44A0", Slot = "12")]
	public void OJPGAFAPDKE(IIGHBBJIBLJ POBODOJHCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4CB3A10", Offset = "0x4CB2E10", VA = "0x184CB3A10", Slot = "14")]
	public LJCGODPDPOD EALFODCAKMF(Transform LPEKHAHIKAH, IEnumerable<EJMJFBBDFHH> NDICLLKLBNE, int AOLPFAJLKCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BCDHDCFHAKH : AINNHCDNCMM
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class JMCADOHKGJA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BCDHDCFHAKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6633E0", Offset = "0x6627E0", VA = "0x1806633E0")]
		[DebuggerHidden]
		public JMCADOHKGJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4CB4D40", Offset = "0x4CB4140", VA = "0x184CB4D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4CB4A60", Offset = "0x4CB3E60", VA = "0x184CB4A60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4CB4DE0", Offset = "0x4CB41E0", VA = "0x184CB4DE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4CB4CF0", Offset = "0x4CB40F0", VA = "0x184CB4CF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4CB4C50", Offset = "0x4CB4050", VA = "0x184CB4C50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4CB4C50", Offset = "0x4CB4050", VA = "0x184CB4C50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly GEFJJOLIOKB FNFNHGFFFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly LCEEOBMLHNN AOJHONAJMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private AHBDAPFFNOE CJDOGJPICIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<HKEGEDDKLCE> MGFAMAPGMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<HKEGEDDKLCE> NBIECJBIHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GameObject MJJHLAIEIEK;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4CAEAE0", Offset = "0x4CADEE0", VA = "0x184CAEAE0")]
	public static BCDHDCFHAKH EDKIEJAFKKA(GEFJJOLIOKB GGALGOABPMH, LCEEOBMLHNN AOJHONAJMEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4CAFC20", Offset = "0x4CAF020", VA = "0x184CAFC20")]
	private BCDHDCFHAKH(GEFJJOLIOKB GGALGOABPMH, LCEEOBMLHNN AOJHONAJMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4CAEBC0", Offset = "0x4CADFC0", VA = "0x184CAEBC0")]
	public void HBDDIHGACID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4CAF9E0", Offset = "0x4CAEDE0", VA = "0x184CAF9E0")]
	[IteratorStateMachine(typeof(JMCADOHKGJA))]
	public IEnumerable<Renderer> LBGMFAGFPPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4CAEFE0", Offset = "0x4CAE3E0", VA = "0x184CAEFE0", Slot = "4")]
	public void JGIJBONPFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4CAEAB0", Offset = "0x4CADEB0", VA = "0x184CAEAB0")]
	private void AHAAEFECFCL(Vector3 FMAEIHEJDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4CAFA50", Offset = "0x4CAEE50", VA = "0x184CAFA50")]
	public void PKNIMKAHKBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HKEGEDDKLCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct KFLKLCMANHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public OJPIEEFGLNM NDEJHNNMHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform FPGMEFBFOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int FKLLPEOPHPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class MMILILPEOIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public HKEGEDDKLCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public CKOBBCCFDDO lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<KFLKLCMANHH> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public MMILILPEOIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MOCGBAAJMDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public LJCGODPDPOD combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public MMILILPEOIA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public MOCGBAAJMDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4CB7E20", Offset = "0x4CB7220", VA = "0x184CB7E20")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4CB7E90", Offset = "0x4CB7290", VA = "0x184CB7E90")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4CB7ED0", Offset = "0x4CB72D0", VA = "0x184CB7ED0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int[] GGKHGFJGJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private FNEPLGJKHLE IPKLIBKACLI;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static Matrix4x4 KEDENFNNMCD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh JKMPGAJJDAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551890", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int ODCIGNHPIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE670", Offset = "0x5DDA70", VA = "0x1805DE670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D0CF0", Offset = "0x6D00F0", VA = "0x1806D0CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4CB3160", Offset = "0x4CB2560", VA = "0x184CB3160")]
	public void PHBJJAAGKBC(List<Transform> FKFGAPHBPLO, Matrix4x4[] FGDODBKDGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2800", Offset = "0x4CB1C00", VA = "0x184CB2800")]
	public static List<HKEGEDDKLCE> DDAMABLPPOO(List<LJDOPHPAACO> PHMBEMHBJOJ, CKOBBCCFDDO EAENLCOCJLC, Bounds PPDOGEAJJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2DE0", Offset = "0x4CB21E0", VA = "0x184CB2DE0")]
	private JobHandle FCODNDJGEEN(LJCGODPDPOD FJBEGKMNNDD, int LPFHOLPFMJN, int IPBBHAOFOMI, CKOBBCCFDDO EAENLCOCJLC, List<KFLKLCMANHH> BPLEAKOEHPI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2700", Offset = "0x4CB1B00", VA = "0x184CB2700")]
	private void BALONEDGKEA(List<KFLKLCMANHH> BPLEAKOEHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4CB34A0", Offset = "0x4CB28A0", VA = "0x184CB34A0")]
	private HKEGEDDKLCE(List<KFLKLCMANHH> BPLEAKOEHPI, int LPFHOLPFMJN, int IPBBHAOFOMI, CKOBBCCFDDO EAENLCOCJLC, Bounds PPDOGEAJJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2D60", Offset = "0x4CB2160", VA = "0x184CB2D60", Slot = "4")]
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
		private MaterialPropertyBlock KJCCOKLJJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private HKEGEDDKLCE HGKBCBNOCFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<Transform> EAGFLFJHBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private RenderTexture NHBGAMPNHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeBuffer FAJCIKGNPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ComputeShader AEAKDOFGMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Matrix4x4[] DIOHCCHEPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int PDGIOAECOAC;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer BADJDNDEGHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5524A0", Offset = "0x5518A0", VA = "0x1805524A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int LEMOIBDLPLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4CB9860", Offset = "0x4CB8C60", VA = "0x184CB9860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8CF0", Offset = "0x4CB80F0", VA = "0x184CB8CF0")]
		public static List<SkinnedShapeRenderer> Create(GameObject PGMAAINPEGN, List<HKEGEDDKLCE> ACIKEDBNEON, List<Transform> EAGFLFJHBDK, Material CAGCNPHDPML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8F90", Offset = "0x4CB8390", VA = "0x184CB8F90")]
		public void Init(HKEGEDDKLCE HGKBCBNOCFB, List<Transform> EAGFLFJHBDK, Material CAGCNPHDPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4CB9480", Offset = "0x4CB8880", VA = "0x184CB9480")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4CB93F0", Offset = "0x4CB87F0", VA = "0x184CB93F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4CB93B0", Offset = "0x4CB87B0", VA = "0x184CB93B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8F00", Offset = "0x4CB8300", VA = "0x184CB8F00")]
		private void GICLDIKFKEB(ScriptableRenderContext IJBCJIEGGIM, Camera[] ILEMNECEMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4CB9510", Offset = "0x4CB8910", VA = "0x184CB9510")]
		private void PHBJJAAGKBC(CommandBuffer FGEIDJPCHPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD9EBF0", Offset = "0xD9DFF0", VA = "0x180D9EBF0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HAEMGHNAAMP
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static byte[] AOHONNKPCGG;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int JJMCEBLKFDI;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int GDGIIBGHMLJ;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static BigInteger PODBKFNIFLC;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public HAEMGHNAAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2110", Offset = "0x4CB1510", VA = "0x184CB2110")]
	private static string BJIMPFHNNLK(byte[] FFOHEAHJJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2210", Offset = "0x4CB1610", VA = "0x184CB2210")]
	public static string LFJGIPFBMOM(byte[] MFCIHENGNMD, bool MBOLNOOKBJO)
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
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
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
