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
public enum PPBIKBDFNFA
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
	DARK_TAN = 33,
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
public enum BOCKLHIBOCH
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	PLACEHOLDER_16 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HBFFDFODKKE
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OGLIEHCMGPE
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	HoverXRay
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LHFDKPIDJMM
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	CornerMove
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HMDFHMHNPLJ : FNHDKLIIJDB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private const byte ALIKMIKCEHF = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private byte PGKKKLOKDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly List<SkinnedShapeRenderer>[] KKOKEKBMENO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BKCJHOKKIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x58BAD0", Offset = "0x58A0D0", VA = "0x18058BAD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x58BAE0", Offset = "0x58A0E0", VA = "0x18058BAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FNLNAGHIBDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x624C20", Offset = "0x623220", VA = "0x180624C20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B84F0", Offset = "0x6B6AF0", VA = "0x1806B84F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float BEOKMGEKBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83A820", Offset = "0x838E20", VA = "0x18083A820", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83AD00", Offset = "0x839300", VA = "0x18083AD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float EMDOCBPLCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83A810", Offset = "0x838E10", VA = "0x18083A810", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83ACF0", Offset = "0x8392F0", VA = "0x18083ACF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> EIGINFFBEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4A38790", Offset = "0x4A36D90", VA = "0x184A38790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GameObject KDOCDFLBPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x534830", Offset = "0x532E30", VA = "0x180534830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x534510", Offset = "0x532B10", VA = "0x180534510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public byte PHBOJCABLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4A386B0", Offset = "0x4A36CB0", VA = "0x184A386B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A38B50", Offset = "0x4A37150", VA = "0x184A38B50")]
	public HMDFHMHNPLJ(List<IMHGEGKKHGC> DJMDJEMNLAJ, List<IMHGEGKKHGC> EKKOGNJGOAF, List<Transform> ONPDLBIHAIL, Material CPONOIMFNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A388E0", Offset = "0x4A36EE0", VA = "0x184A388E0")]
	private int NBADLNBNIHF(List<IMHGEGKKHGC> AGJFHCGFMGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4A389F0", Offset = "0x4A36FF0", VA = "0x184A389F0")]
	private void PBJGKFPDKKO(int LFLLHNBLCKM, bool BNINELFDJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4A387F0", Offset = "0x4A36DF0", VA = "0x184A387F0")]
	public void IHBBCFMLJOM(Vector3 CJPEBCALHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4A38700", Offset = "0x4A36D00", VA = "0x184A38700", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4A38670", Offset = "0x4A36C70", VA = "0x184A38670")]
	public void BEHIMEAHDMH(Transform BONJHNKFCKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DABMPCIAIHJ : OHKHLEFHIDE, NKEECDBBFHO, AIBHJFBKJDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class MELHBJDNBIP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DABMPCIAIHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x792C00", Offset = "0x791200", VA = "0x180792C00")]
		[DebuggerHidden]
		public MELHBJDNBIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4A3BAF0", Offset = "0x4A3A0F0", VA = "0x184A3BAF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4A3B640", Offset = "0x4A39C40", VA = "0x184A3B640", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4A3BC70", Offset = "0x4A3A270", VA = "0x184A3BC70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4A3BCB0", Offset = "0x4A3A2B0", VA = "0x184A3BCB0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4A3BD00", Offset = "0x4A3A300", VA = "0x184A3BD00")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4A3BAA0", Offset = "0x4A3A0A0", VA = "0x184A3BAA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4A3BA00", Offset = "0x4A3A000", VA = "0x184A3BA00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4A3BA00", Offset = "0x4A3A000", VA = "0x184A3BA00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private ABFDAGKEOMI IKFOOOIHFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private List<ONBLFEIIBJI> ANOICGMNMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private List<ClusterMeshRenderer> KAOLGPHLFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private BatchedMeshRenderer NFNFINAGHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool FFLAMHIMKJL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IEnumerable<DHBPPONOPHL> MFJCGKOFOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int GDOIFMLDFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4A372D0", Offset = "0x4A358D0", VA = "0x184A372D0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform LFJHAFCFLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4A37340", Offset = "0x4A35940", VA = "0x184A37340", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal override DABMPCIAIHJ COANBLAMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647020", VA = "0x180648A20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4A38220", Offset = "0x4A36820", VA = "0x184A38220")]
	public DABMPCIAIHJ(ABFDAGKEOMI LBKGGGPNBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4A37310", Offset = "0x4A35910", VA = "0x184A37310", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4A37610", Offset = "0x4A35C10", VA = "0x184A37610")]
	public void MEEOIBACLCF(ONBLFEIIBJI CFPAMBNFPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4A37390", Offset = "0x4A35990", VA = "0x184A37390")]
	public void FJHOKKOHPIB(ONBLFEIIBJI CFPAMBNFPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4A376E0", Offset = "0x4A35CE0", VA = "0x184A376E0", Slot = "5")]
	public void MGJMGNBNOED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4A37580", Offset = "0x4A35B80", VA = "0x184A37580")]
	public void LHCLGJALOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A380D0", Offset = "0x4A366D0", VA = "0x184A380D0")]
	private void OEMJKIGNJOG(ONBLFEIIBJI CFPAMBNFPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4A37BF0", Offset = "0x4A361F0", VA = "0x184A37BF0")]
	public void NMDOJFDDMFM(bool ENPAFGACIFC, bool GFCBECALOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4A37470", Offset = "0x4A35A70", VA = "0x184A37470")]
	protected void JPLDEBFAEDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4A37400", Offset = "0x4A35A00", VA = "0x184A37400")]
	[IteratorStateMachine(typeof(MELHBJDNBIP))]
	public IEnumerable<Renderer> HLBOEJBJNIP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class NINEHMHBDMP : ONBLFEIIBJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private JNGKFHEJLNE LOFGDOPNCPM;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C280", Offset = "0x4A3A880", VA = "0x184A3C280")]
	private NativeList<AAOIJFFPJPD> DOCHFFLEBBC()
	{
		return default(NativeList<AAOIJFFPJPD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4A36E80", Offset = "0x4A35480", VA = "0x184A36E80")]
	public NINEHMHBDMP(DABMPCIAIHJ HLALHACAGEL, JNGKFHEJLNE LBKGGGPNBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C570", Offset = "0x4A3AB70", VA = "0x184A3C570", Slot = "14")]
	public override int NBADLNBNIHF(AIFPIFCMLEF NDFHABBPPKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C350", Offset = "0x4A3A950", VA = "0x184A3C350", Slot = "15")]
	public override int EEOFMCMLJNC(AIFPIFCMLEF NDFHABBPPKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4A3BD50", Offset = "0x4A3A350", VA = "0x184A3BD50", Slot = "16")]
	public override void BBDJALPNJHJ(AIFPIFCMLEF NDFHABBPPKD, BBOMJFBCLGN PICIJPFPNPJ, int GOELMEEBFDG = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class OHKHLEFHIDE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	internal virtual DABMPCIAIHJ COANBLAMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5489D0", Offset = "0x546FD0", VA = "0x1805489D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	protected OHKHLEFHIDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum OMNIELMMHCF
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ABFDAGKEOMI
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform INNKKHOBMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	OMNIELMMHCF NFFLCCDKJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class JIEFCMEHCNO
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal virtual ONBLFEIIBJI NNGLNNLMKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5489D0", Offset = "0x546FD0", VA = "0x1805489D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	protected JIEFCMEHCNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MKHJHAOLOND
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform INNKKHOBMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float KJACHIKLMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Vector3 DHONLOIMAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	PPBIKBDFNFA DHNNLNFBDBN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	BOCKLHIBOCH JNOLKGFPAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OGDEKPLPFHF : MKHJHAOLOND
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	JIGGBLJGBGK BNLDPMGMJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LICPDNNHNGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JNGKFHEJLNE : MKHJHAOLOND
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BLHLEEECPGB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GLMHGELNPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float ADCADOMPKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	int GNKJLBJPBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool OAGCEJHGICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<AAOIJFFPJPD> DOCHFFLEBBC();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface APPEEODPEJI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OADNNDDDJAD(JIEFCMEHCNO CFPAMBNFPAN, OGLIEHCMGPE IANGIAGLIOB);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OADNNDDDJAD(OHKHLEFHIDE HLALHACAGEL, OGLIEHCMGPE IANGIAGLIOB);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBJBPPLIIAH(OHKHLEFHIDE HLALHACAGEL);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PBJBPPLIIAH(JIEFCMEHCNO CFPAMBNFPAN);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GLDEGHMHNBM(OHKHLEFHIDE HLALHACAGEL, LHFDKPIDJMM FFNKIDPAEGE);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IGEOIBEHINH(OHKHLEFHIDE HLALHACAGEL, Vector3 PNDJJOAGIHM, Vector3 MNCBBKMDAIE, Vector3 PIJIOPLNNIP, float NCPNBACFOGA, float KFGMOADHGEJ, IReadOnlyList<Camera> KEAKAPJKIFK, HBFFDFODKKE AHGOJPOMHFO);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IGEOIBEHINH(NGIKFBLCPNJ GAPBBMOMKGH, object DFOBEHELKMJ, object CFMCFMMHCJG, float AKKPPHJBGBH, Color? HINAOEJCJGA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PLLHMCFPDHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OHKHLEFHIDE BHIJGKCKMAJ(ABFDAGKEOMI LBKGGGPNBDF);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBDMGKBLGAA(OHKHLEFHIDE HLALHACAGEL);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPGEFLEKGGD(OHKHLEFHIDE HLALHACAGEL);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JIEFCMEHCNO FIJIMFPAOHG(OHKHLEFHIDE HLALHACAGEL, OGDEKPLPFHF LBKGGGPNBDF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JIEFCMEHCNO IJDGBPMPPIJ(OHKHLEFHIDE HLALHACAGEL, JNGKFHEJLNE LBKGGGPNBDF);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AAALNBBAIFK(JIEFCMEHCNO CFPAMBNFPAN);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NKEGJGIHKKG(JIEFCMEHCNO CFPAMBNFPAN);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NGIKFBLCPNJ NCNNFEKNPPC(BDACADPPEBK LBKGGGPNBDF);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DJLEMMIJMCL(NGIKFBLCPNJ GAPBBMOMKGH);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GADCPFENJOE(NGIKFBLCPNJ GAPBBMOMKGH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ALPJLPHKHND JNLAPCPAHHD(Transform PBJLGECDKLG, IEnumerable<JIEFCMEHCNO> ANOICGMNMBB, int FPODMPMDCII);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> GDIJCGPANOD(OHKHLEFHIDE HLALHACAGEL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class NGIKFBLCPNJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal virtual KNDPHKOOFEA CHFJKFFPABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5489D0", Offset = "0x546FD0", VA = "0x1805489D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	protected NGIKFBLCPNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BDACADPPEBK
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int HJKPBHMPKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	Transform AFAJFMMFDNH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MNNPKNGECCB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OHKHLEFHIDE GetBone(int DNNLPCNHCPD);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int DNNLPCNHCPD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class ABIOOKDLJGH : ONBLFEIIBJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public OGDEKPLPFHF DGJAMJEGLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int[] ACLGHAFLAFJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public override FCCFFKGIEDF GEEOOIOEJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4A36AE0", Offset = "0x4A350E0", VA = "0x184A36AE0", Slot = "13")]
		get
		{
			return default(FCCFFKGIEDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private Vector3 IBPKLKPADBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4A36860", Offset = "0x4A34E60", VA = "0x184A36860")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4A36E80", Offset = "0x4A35480", VA = "0x184A36E80")]
	public ABIOOKDLJGH(DABMPCIAIHJ HLALHACAGEL, OGDEKPLPFHF LBKGGGPNBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4A36080", Offset = "0x4A34680", VA = "0x184A36080", Slot = "12")]
	public override bool BNJHFJAGJPD(Transform HLALHACAGEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4A36A40", Offset = "0x4A35040", VA = "0x184A36A40", Slot = "14")]
	public override int NBADLNBNIHF(AIFPIFCMLEF NDFHABBPPKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4A367C0", Offset = "0x4A34DC0", VA = "0x184A367C0", Slot = "15")]
	public override int EEOFMCMLJNC(AIFPIFCMLEF NDFHABBPPKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4A36580", Offset = "0x4A34B80", VA = "0x184A36580")]
	private int DGMKBEIEIJC(AIFPIFCMLEF NDFHABBPPKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4A359D0", Offset = "0x4A33FD0", VA = "0x184A359D0", Slot = "16")]
	public override void BBDJALPNJHJ(AIFPIFCMLEF NDFHABBPPKD, BBOMJFBCLGN PICIJPFPNPJ, int GOELMEEBFDG = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DDDIILCICLL
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOKFJDLENCM(LHFDKPIDJMM FFNKIDPAEGE, Renderer AKGDPIDCHCB, int GPELJFNGAEC);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNEDFDFEOHO(Renderer AKGDPIDCHCB, HBFFDFODKKE AHGOJPOMHFO, Vector3 PNDJJOAGIHM, Vector3 MNCBBKMDAIE, Vector3 PIJIOPLNNIP, float NCPNBACFOGA, float KFGMOADHGEJ, float AKKPPHJBGBH = -1f, [Optional] Color? HINAOEJCJGA, [Optional] IReadOnlyList<Camera> LFHGDNGGKKL);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNEDFDFEOHO(Renderer AKGDPIDCHCB, object DFOBEHELKMJ, object CFMCFMMHCJG, bool DPGJDCADKIC, float AKKPPHJBGBH, Color? HINAOEJCJGA, bool HEGKHDHOAKD = false);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MJCMJDEABMM(Renderer AKGDPIDCHCB, int GPELJFNGAEC);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FFKDJEKKCPP();

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLLPMLCFCML(int LIHOFLGLEBL, OGLIEHCMGPE FFNKIDPAEGE, Renderer AKGDPIDCHCB, int GPELJFNGAEC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OKLMOHCPBPG : APPEEODPEJI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private DDDIILCICLL MKDCKGKPMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private MeshRenderer HIKFFHLNKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private CDCMKIEELAC LKPLCDMBJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private MeshRenderer ECFIIPOFGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private CDCMKIEELAC IMNAPALJNJC;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x57A1E0", Offset = "0x5787E0", VA = "0x18057A1E0")]
	public OKLMOHCPBPG(DDDIILCICLL NOAPPMGKOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4A3D6E0", Offset = "0x4A3BCE0", VA = "0x184A3D6E0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4A3E1B0", Offset = "0x4A3C7B0", VA = "0x184A3E1B0", Slot = "4")]
	public void OADNNDDDJAD(JIEFCMEHCNO CFPAMBNFPAN, OGLIEHCMGPE IANGIAGLIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4A3DFE0", Offset = "0x4A3C5E0", VA = "0x184A3DFE0", Slot = "5")]
	public void OADNNDDDJAD(OHKHLEFHIDE HLALHACAGEL, OGLIEHCMGPE IANGIAGLIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4A3E420", Offset = "0x4A3CA20", VA = "0x184A3E420", Slot = "6")]
	public void PBJBPPLIIAH(OHKHLEFHIDE HLALHACAGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4A3E5B0", Offset = "0x4A3CBB0", VA = "0x184A3E5B0", Slot = "7")]
	public void PBJBPPLIIAH(JIEFCMEHCNO CFPAMBNFPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4A3D830", Offset = "0x4A3BE30", VA = "0x184A3D830", Slot = "8")]
	public void GLDEGHMHNBM(OHKHLEFHIDE HLALHACAGEL, LHFDKPIDJMM FFNKIDPAEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4A3D9D0", Offset = "0x4A3BFD0", VA = "0x184A3D9D0", Slot = "9")]
	public void IGEOIBEHINH(OHKHLEFHIDE HLALHACAGEL, Vector3 PNDJJOAGIHM, Vector3 MNCBBKMDAIE, Vector3 PIJIOPLNNIP, float NCPNBACFOGA, float KFGMOADHGEJ, IReadOnlyList<Camera> KEAKAPJKIFK, HBFFDFODKKE AHGOJPOMHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4A3DD00", Offset = "0x4A3C300", VA = "0x184A3DD00", Slot = "10")]
	public void IGEOIBEHINH(NGIKFBLCPNJ GAPBBMOMKGH, object DFOBEHELKMJ, object CFMCFMMHCJG, float AKKPPHJBGBH, Color? HINAOEJCJGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class ONBLFEIIBJI : JIEFCMEHCNO, KNNBPHMCEBH, DHBPPONOPHL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	protected Bounds OLLGKPIMFFL;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public DABMPCIAIHJ KDOCDFLBPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x513000", Offset = "0x511600", VA = "0x180513000")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	internal override ONBLFEIIBJI NNGLNNLMKPF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647020", VA = "0x180648A20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Bounds KBCCFICONPM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9CF660", Offset = "0x9CDC60", VA = "0x1809CF660", Slot = "5")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public virtual FCCFFKGIEDF GEEOOIOEJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4A3E800", Offset = "0x4A3CE00", VA = "0x184A3E800", Slot = "13")]
		get
		{
			return default(FCCFFKGIEDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x570FF0", Offset = "0x56F5F0", VA = "0x180570FF0", Slot = "12")]
	public virtual bool BNJHFJAGJPD(Transform HLALHACAGEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int NBADLNBNIHF(AIFPIFCMLEF NDFHABBPPKD);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract int EEOFMCMLJNC(AIFPIFCMLEF NDFHABBPPKD);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract void BBDJALPNJHJ(AIFPIFCMLEF NDFHABBPPKD, BBOMJFBCLGN PICIJPFPNPJ, int GOELMEEBFDG = -1);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	protected ONBLFEIIBJI()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4A3F4C0", Offset = "0x4A3DAC0", VA = "0x184A3F4C0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum JIGGBLJGBGK
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class OACLJEGGOLL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CDKALODNHNN : IEnumerable<KJFIDGGKKLM>, IEnumerable, IEnumerator<KJFIDGGKKLM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private KJFIDGGKKLM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private KJFIDGGKKLM System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x792C00", Offset = "0x791200", VA = "0x180792C00")]
		[DebuggerHidden]
		public CDKALODNHNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4A37110", Offset = "0x4A35710", VA = "0x184A37110", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4A37280", Offset = "0x4A35880", VA = "0x184A37280", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4A371F0", Offset = "0x4A357F0", VA = "0x184A371F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KJFIDGGKKLM> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4A371F0", Offset = "0x4A357F0", VA = "0x184A371F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const int DEINIKGODBL = 3;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static KJFIDGGKKLM[][] NCHHKCPJKKJ;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static LHHFEBNCFLF EMJBNKGFNDK;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public static ShapeRendererConfig JBPLCGHOENJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static ComputeShader CJGODOGIILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4A3D140", Offset = "0x4A3B740", VA = "0x184A3D140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static SkinnedShapeRenderer GDNHCFDIOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4A3D5E0", Offset = "0x4A3BBE0", VA = "0x184A3D5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4A3CE40", Offset = "0x4A3B440", VA = "0x184A3CE40")]
	public static Mesh CKILJBBJPDJ(JIGGBLJGBGK IGNIBCBENIK, int NDFHABBPPKD = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4A3D650", Offset = "0x4A3BC50", VA = "0x184A3D650")]
	public static int OCAMDGIFMLP(JIGGBLJGBGK IGNIBCBENIK, int NDFHABBPPKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C950", Offset = "0x4A3AF50", VA = "0x184A3C950")]
	public static LHHFEBNCFLF BIBBOLNDKKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4A3CDE0", Offset = "0x4A3B3E0", VA = "0x184A3CDE0")]
	[IteratorStateMachine(typeof(CDKALODNHNN))]
	private static IEnumerable<KJFIDGGKKLM> CHLBFEDHELA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4A3CAA0", Offset = "0x4A3B0A0", VA = "0x184A3CAA0")]
	public static KJFIDGGKKLM BNIOIDCLBBN(JIGGBLJGBGK IGNIBCBENIK, int NDFHABBPPKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4A3CF00", Offset = "0x4A3B500", VA = "0x184A3CF00")]
	public static bool DPIKOLJLLDM(this JIGGBLJGBGK IGNIBCBENIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C790", Offset = "0x4A3AD90", VA = "0x184A3C790")]
	public static void BDGLGAEIAHL(JIGGBLJGBGK IGNIBCBENIK, float3 HJJJJIIEHID, out LBKGMCAJIEN DKKEEAJGOFM, out float3 ODLOGLNGGAC, out float JDKKPCOIHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4A3D1C0", Offset = "0x4A3B7C0", VA = "0x184A3D1C0")]
	public static void IMLHKKKHHDG(Vector3 HJJJJIIEHID, JIGGBLJGBGK IGNIBCBENIK, out Vector3 ODLOGLNGGAC, out float JDKKPCOIHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4A3D1B0", Offset = "0x4A3B7B0", VA = "0x184A3D1B0")]
	[OOPBCBLKHLO(BLHLEKHDLFO.ExitingPlayMode, 0)]
	private static void FMHLGAPJOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4A3CF20", Offset = "0x4A3B520", VA = "0x184A3CF20")]
	[OOPBCBLKHLO(BLHLEKHDLFO.ExitingPlayMode, 0)]
	private static void EDANINKLIKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface LMDKHBDPHKI
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool ENHPIMJCBDF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material AGCOPENMLGE();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material LJKEJIDHPHK();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material CDNPHOFBBIP();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JIKMBMLPJBB(PPBIKBDFNFA CPHKAEOFHPE);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KKCKFHKIAJK(BOCKLHIBOCH HAEJFDDNBDI);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HCFLIOMKEAM(GameObject AIHPMIAHIBA);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HLPMOEPEOLP(GameObject AIHPMIAHIBA, bool EMIDHCFDHKG);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PEDNLFEILIC : PLLHMCFPDHH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static LMDKHBDPHKI NNDOFBOEHBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4A3E9F0", Offset = "0x4A3CFF0", VA = "0x184A3E9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x4A3EA30", Offset = "0x4A3D030", VA = "0x184A3EA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4A3F2F0", Offset = "0x4A3D8F0", VA = "0x184A3F2F0")]
	public PEDNLFEILIC(LMDKHBDPHKI NOAPPMGKOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4A3E940", Offset = "0x4A3CF40", VA = "0x184A3E940", Slot = "4")]
	public OHKHLEFHIDE BHIJGKCKMAJ(ABFDAGKEOMI LBKGGGPNBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4A3ED40", Offset = "0x4A3D340", VA = "0x184A3ED40", Slot = "5")]
	public void JBDMGKBLGAA(OHKHLEFHIDE HLALHACAGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4A3F1A0", Offset = "0x4A3D7A0", VA = "0x184A3F1A0", Slot = "6")]
	public void LPGEFLEKGGD(OHKHLEFHIDE HLALHACAGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4A3EBD0", Offset = "0x4A3D1D0", VA = "0x184A3EBD0", Slot = "15")]
	public IEnumerable<Renderer> GDIJCGPANOD(OHKHLEFHIDE HLALHACAGEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4A3EAC0", Offset = "0x4A3D0C0", VA = "0x184A3EAC0", Slot = "7")]
	public JIEFCMEHCNO FIJIMFPAOHG(OHKHLEFHIDE HLALHACAGEL, OGDEKPLPFHF LBKGGGPNBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4A3EC70", Offset = "0x4A3D270", VA = "0x184A3EC70", Slot = "8")]
	public JIEFCMEHCNO IJDGBPMPPIJ(OHKHLEFHIDE HLALHACAGEL, JNGKFHEJLNE LBKGGGPNBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4A3E890", Offset = "0x4A3CE90", VA = "0x184A3E890", Slot = "9")]
	public void AAALNBBAIFK(JIEFCMEHCNO CFPAMBNFPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4A3F2A0", Offset = "0x4A3D8A0", VA = "0x184A3F2A0", Slot = "10")]
	public void NKEGJGIHKKG(JIEFCMEHCNO CFPAMBNFPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4A3F1E0", Offset = "0x4A3D7E0", VA = "0x184A3F1E0", Slot = "11")]
	public NGIKFBLCPNJ NCNNFEKNPPC(BDACADPPEBK LBKGGGPNBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4A3EA80", Offset = "0x4A3D080", VA = "0x184A3EA80", Slot = "12")]
	public void DJLEMMIJMCL(NGIKFBLCPNJ GAPBBMOMKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4A3EB90", Offset = "0x4A3D190", VA = "0x184A3EB90", Slot = "13")]
	public void GADCPFENJOE(NGIKFBLCPNJ GAPBBMOMKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4A3EDA0", Offset = "0x4A3D3A0", VA = "0x184A3EDA0", Slot = "14")]
	public ALPJLPHKHND JNLAPCPAHHD(Transform PBJLGECDKLG, IEnumerable<JIEFCMEHCNO> ANOICGMNMBB, int FPODMPMDCII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KNDPHKOOFEA : NGIKFBLCPNJ, NKEECDBBFHO
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EDIKIDFCPAI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public KNDPHKOOFEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x792C00", Offset = "0x791200", VA = "0x180792C00")]
		[DebuggerHidden]
		public EDIKIDFCPAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4A38590", Offset = "0x4A36B90", VA = "0x184A38590", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4A382B0", Offset = "0x4A368B0", VA = "0x184A382B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4A38630", Offset = "0x4A36C30", VA = "0x184A38630")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4A38540", Offset = "0x4A36B40", VA = "0x184A38540", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4A384A0", Offset = "0x4A36AA0", VA = "0x184A384A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4A384A0", Offset = "0x4A36AA0", VA = "0x184A384A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private BDACADPPEBK KMHOFNFNCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private HMDFHMHNPLJ BGBOCAHMKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private List<IMHGEGKKHGC> EKHDGKPJAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private List<IMHGEGKKHGC> MFBOECLBPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private GameObject LLALPBEBHBA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	internal override KNDPHKOOFEA CHFJKFFPABB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647020", VA = "0x180648A20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A580", Offset = "0x4A38B80", VA = "0x184A3A580")]
	public static KNDPHKOOFEA DBDGOJJEGLJ(BDACADPPEBK LBKGGGPNBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B5C0", Offset = "0x4A39BC0", VA = "0x184A3B5C0")]
	private KNDPHKOOFEA(BDACADPPEBK LBKGGGPNBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B1A0", Offset = "0x4A397A0", VA = "0x184A3B1A0")]
	public void OJJBINEMABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A670", Offset = "0x4A38C70", VA = "0x184A3A670")]
	[IteratorStateMachine(typeof(EDIKIDFCPAI))]
	public IEnumerable<Renderer> HLBOEJBJNIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A8B0", Offset = "0x4A38EB0", VA = "0x184A3A8B0", Slot = "5")]
	public void MGJMGNBNOED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A640", Offset = "0x4A38C40", VA = "0x184A3A640")]
	private void GCAOHIAOJGL(Vector3 CJPEBCALHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A6E0", Offset = "0x4A38CE0", VA = "0x184A3A6E0")]
	public void LHCLGJALOHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class IMHGEGKKHGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct FJJCEOAJANM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public BBOMJFBCLGN IMPFNHFEMFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Transform DHENNDFGAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int LAOCFBDPINH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class IKBKKPKAAFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public IMHGEGKKHGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public AIFPIFCMLEF lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<FJJCEOAJANM> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public IKBKKPKAAFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class ALHIAPFKDDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public ALPJLPHKHND combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public IKBKKPKAAFI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public ALHIAPFKDDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4A36ED0", Offset = "0x4A354D0", VA = "0x184A36ED0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4A36F40", Offset = "0x4A35540", VA = "0x184A36F40")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4A36F80", Offset = "0x4A35580", VA = "0x184A36F80")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int[] ELBEAAPFNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private BCFFFEFAFHK AJKBMCCLIOC;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static Matrix4x4 CJICIDGCGGI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Mesh JBBAKKGLLMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x513000", Offset = "0x511600", VA = "0x180513000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int KLAECICHFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x535300", Offset = "0x533900", VA = "0x180535300")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x58E110", Offset = "0x58C710", VA = "0x18058E110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A38E10", Offset = "0x4A37410", VA = "0x184A38E10")]
	public void CGIAJBHEGNI(List<Transform> KFGGCLEIIDF, Matrix4x4[] PONKJNOONGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4A39090", Offset = "0x4A37690", VA = "0x184A39090")]
	public static List<IMHGEGKKHGC> GMAHEMAIIFF(List<AIBHJFBKJDP> FKPBGGINHFJ, AIFPIFCMLEF NDFHABBPPKD, Bounds OEAENKHFGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4A39620", Offset = "0x4A37C20", VA = "0x184A39620")]
	private JobHandle GMJBOMLKBHE(ALPJLPHKHND ENMHCOJEPFN, int LJDKKPNFOEJ, int MJBFAPCDONL, AIFPIFCMLEF NDFHABBPPKD, List<FJJCEOAJANM> JGPHFIKOENB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4A399A0", Offset = "0x4A37FA0", VA = "0x184A399A0")]
	private void NKFDJGEHGNF(List<FJJCEOAJANM> JGPHFIKOENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4A39BE0", Offset = "0x4A381E0", VA = "0x184A39BE0")]
	private IMHGEGKKHGC(List<FJJCEOAJANM> JGPHFIKOENB, int LJDKKPNFOEJ, int MJBFAPCDONL, AIFPIFCMLEF NDFHABBPPKD, Bounds OEAENKHFGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4A39010", Offset = "0x4A37610", VA = "0x184A39010", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private MaterialPropertyBlock CPNLAHKJMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private IMHGEGKKHGC PEINLHOIDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private List<Transform> ONPDLBIHAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private RenderTexture MJGPBAJOHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private ComputeBuffer JGLFLNCIENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private ComputeShader HAMPMIEMEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private Matrix4x4[] JFJJLFHJKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int FHJJKBAAPHG;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MeshRenderer FNGBPOFOIJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x5898D0", Offset = "0x587ED0", VA = "0x1805898D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int HJKPBHMPKEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x4A40060", Offset = "0x4A3E660", VA = "0x184A40060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4A3F840", Offset = "0x4A3DE40", VA = "0x184A3F840")]
		public static List<SkinnedShapeRenderer> Create(GameObject HLALHACAGEL, List<IMHGEGKKHGC> AGJFHCGFMGC, List<Transform> ONPDLBIHAIL, Material CPONOIMFNKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4A3FAE0", Offset = "0x4A3E0E0", VA = "0x184A3FAE0")]
		public void Init(IMHGEGKKHGC PEINLHOIDLL, List<Transform> ONPDLBIHAIL, Material CPONOIMFNKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4A3FFD0", Offset = "0x4A3E5D0", VA = "0x184A3FFD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4A3FF40", Offset = "0x4A3E540", VA = "0x184A3FF40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4A3FF00", Offset = "0x4A3E500", VA = "0x184A3FF00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4A3FA50", Offset = "0x4A3E050", VA = "0x184A3FA50")]
		private void FEABBAGBLPG(ScriptableRenderContext FBKBDIMBGGH, Camera[] EGLDGMFOPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4A3F4F0", Offset = "0x4A3DAF0", VA = "0x184A3F4F0")]
		private void CGIAJBHEGNI(CommandBuffer AINAKEGMJFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x517B90", Offset = "0x516190", VA = "0x180517B90")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KKINEKHOKMG
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static byte[] DOJNIBDEPHD;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static int KFPMCEOFNHF;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static int FPHJGLDCBHD;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static BigInteger HMCNEAFPECA;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	public KKINEKHOKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A2C0", Offset = "0x4A388C0", VA = "0x184A3A2C0")]
	private static string IOLHAJOLOLL(byte[] CGENIFKMPBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4A39F90", Offset = "0x4A38590", VA = "0x184A39F90")]
	public static string FFHDEGOGLMA(byte[] LDGCJAPEANM, bool ONIHJAEONNB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
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
