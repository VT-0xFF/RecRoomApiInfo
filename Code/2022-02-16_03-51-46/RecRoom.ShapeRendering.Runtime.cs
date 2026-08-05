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
public enum NMNAIMAJNEK
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
public enum CMAKHAAHCFH
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
public enum NFPJKHCPMJI
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
public enum CHKDECKGNMG
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
	NearbyContextual
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CNDIMDCDMGJ
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CornerMove
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FGKPPGHEKIJ : BFDKHAKAPFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private const byte ONHDPCNCONF = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private byte IOKBHMEGNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly List<SkinnedShapeRenderer>[] FLPHDFEBFLO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FJEBBNOBILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x52F6C0", Offset = "0x52DEC0", VA = "0x18052F6C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61F570", Offset = "0x61DD70", VA = "0x18061F570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NCJPBNMPMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x52F6B0", Offset = "0x52DEB0", VA = "0x18052F6B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6EC890", Offset = "0x6EB090", VA = "0x1806EC890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float CABGHMCKOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6633F0", Offset = "0x661BF0", VA = "0x1806633F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6638D0", Offset = "0x6620D0", VA = "0x1806638D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float DBEKBPDCFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6633E0", Offset = "0x661BE0", VA = "0x1806633E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6638C0", Offset = "0x6620C0", VA = "0x1806638C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> FAIFBFEOOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1A8C7F0", Offset = "0x1A8AFF0", VA = "0x181A8C7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GameObject JLLLOONDCPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x50A9E0", Offset = "0x5091E0", VA = "0x18050A9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C33B0", Offset = "0x5C1BB0", VA = "0x1805C33B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public byte EDAEPKFJOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1A8C7A0", Offset = "0x1A8AFA0", VA = "0x181A8C7A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1A8CBF0", Offset = "0x1A8B3F0", VA = "0x181A8CBF0")]
	public FGKPPGHEKIJ(List<ELBAJEMILBG> FEBHOILEDDG, List<ELBAJEMILBG> DNJGLCGDCFJ, List<Transform> BKAIAHFBAGA, Material JINDGNNOMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1A8C940", Offset = "0x1A8B140", VA = "0x181A8C940")]
	private int OOKDBLJACML(List<ELBAJEMILBG> PHBOMLNFLLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1A8CA90", Offset = "0x1A8B290", VA = "0x181A8CA90")]
	private void PKGPICAOPPP(int OOGOCGEECGL, bool PONFKDJGMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1A8C850", Offset = "0x1A8B050", VA = "0x181A8C850")]
	public void LCDKIJBNLCA(Vector3 LFMJMMOFNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1A8C710", Offset = "0x1A8AF10", VA = "0x181A8C710", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1A8CA50", Offset = "0x1A8B250", VA = "0x181A8CA50")]
	public void OOKLDEIKHJK(Transform IHHMLJNOCNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ENLJHNKPCNH : OEHGPJGALPA, PHIICEBDCDP, JCNALHHENIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HJOHLIAFICA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public ENLJHNKPCNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78C260", Offset = "0x78AA60", VA = "0x18078C260")]
		[DebuggerHidden]
		public HJOHLIAFICA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D520", Offset = "0x1A8BD20", VA = "0x181A8D520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D070", Offset = "0x1A8B870", VA = "0x181A8D070", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D6A0", Offset = "0x1A8BEA0", VA = "0x181A8D6A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D6E0", Offset = "0x1A8BEE0", VA = "0x181A8D6E0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D730", Offset = "0x1A8BF30", VA = "0x181A8D730")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D4D0", Offset = "0x1A8BCD0", VA = "0x181A8D4D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D430", Offset = "0x1A8BC30", VA = "0x181A8D430", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D430", Offset = "0x1A8BC30", VA = "0x181A8D430", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private EGKMMMEDNNG JAAEMAEDFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private List<PCPPELIEPPL> GMPHNNLMOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private List<ClusterMeshRenderer> BIAKENEJABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private BatchedMeshRenderer PNHFCHCCCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool NNJICIBDLGH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IEnumerable<GEJPNAHJOCC> JHODDIJCALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int EMCCAMJGKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1A8A280", Offset = "0x1A88A80", VA = "0x181A8A280", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform BNJBIPNKOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1A8ABA0", Offset = "0x1A893A0", VA = "0x181A8ABA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal override ENLJHNKPCNH MOGBAGPMBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCD0", Offset = "0x5CE4D0", VA = "0x1805CFCD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1A8B1D0", Offset = "0x1A899D0", VA = "0x181A8B1D0")]
	public ENLJHNKPCNH(EGKMMMEDNNG IACPDDKLBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1A8A2C0", Offset = "0x1A88AC0", VA = "0x181A8A2C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1A8ABF0", Offset = "0x1A893F0", VA = "0x181A8ABF0")]
	public void MFDJFDLHFHG(PCPPELIEPPL KNKEOOBFONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1A8A400", Offset = "0x1A88C00", VA = "0x181A8A400")]
	public void EHAJBJDJBJH(PCPPELIEPPL KNKEOOBFONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1A8ACC0", Offset = "0x1A894C0", VA = "0x181A8ACC0", Slot = "5")]
	public void MPAILAEPEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1A8A9C0", Offset = "0x1A891C0", VA = "0x181A8A9C0")]
	public void GMABKAMPIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1A8AA50", Offset = "0x1A89250", VA = "0x181A8AA50")]
	private void IGNPMCFICEH(PCPPELIEPPL KNKEOOBFONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1A8A470", Offset = "0x1A88C70", VA = "0x181A8A470")]
	public void FDGBHJHBHFE(bool AINOCIPEFGN, bool AMGGIHEKJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1A8A2F0", Offset = "0x1A88AF0", VA = "0x181A8A2F0")]
	protected void EEOBBCEEPHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1A8A950", Offset = "0x1A89150", VA = "0x181A8A950")]
	[IteratorStateMachine(typeof(HJOHLIAFICA))]
	public IEnumerable<Renderer> FJDBGIDJHBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class EJGKFPFOBFI : PCPPELIEPPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private PAIDDIFPJOB HDDNFKAKGPI;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1A88DC0", Offset = "0x1A875C0", VA = "0x181A88DC0")]
	private NativeList<NNJGFOCGEMF> LNCEKHGGCBF()
	{
		return default(NativeList<NNJGFOCGEMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1A890B0", Offset = "0x1A878B0", VA = "0x181A890B0")]
	public EJGKFPFOBFI(ENLJHNKPCNH MIBMGGCCOAE, PAIDDIFPJOB IACPDDKLBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1A88E90", Offset = "0x1A87690", VA = "0x181A88E90", Slot = "14")]
	public override int OOKDBLJACML(NLJOEGOODPP GAKEOHNAFFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1A88BA0", Offset = "0x1A873A0", VA = "0x181A88BA0", Slot = "15")]
	public override int JOKFPNCGLEK(NLJOEGOODPP GAKEOHNAFFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1A88670", Offset = "0x1A86E70", VA = "0x181A88670", Slot = "16")]
	public override void COPHFCAFBBM(NLJOEGOODPP GAKEOHNAFFD, HKBINMDMLII GMKBNFKFIKL, int LOEPDAJAABD = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class OEHGPJGALPA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	internal virtual ENLJHNKPCNH MOGBAGPMBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x517640", Offset = "0x515E40", VA = "0x180517640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	protected OEHGPJGALPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum BJNAPNKLMID
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EGKMMMEDNNG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform BCCKAGGGDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	BJNAPNKLMID NNBEBKDKKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class PGGEHKMOPBB
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal virtual PCPPELIEPPL GCCNMBIDPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x517640", Offset = "0x515E40", VA = "0x180517640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	protected PGGEHKMOPBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IFIKPMGFHJE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform BCCKAGGGDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float EGCBILJBMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Vector3 FCLCLJNIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	NMNAIMAJNEK CCBJLCADENJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	CMAKHAAHCFH EIGHEHPCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CHDMNOIHNGE : IFIKPMGFHJE
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	OLENHHMBJNA IAFNBANPBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LAMKHFCKIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PAIDDIFPJOB : IFIKPMGFHJE
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MMOJGEGMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JOELDEKNLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float FPFPEPGKBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	int IMIGIMCFNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool ELCBOMJHDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<NNJGFOCGEMF> LNCEKHGGCBF();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FIGMIKCGCEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODBKNMDIFOH(PGGEHKMOPBB KNKEOOBFONA, CHKDECKGNMG MEDFKMEIPMM);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODBKNMDIFOH(OEHGPJGALPA MIBMGGCCOAE, CHKDECKGNMG MEDFKMEIPMM);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CJLGJELDNHP(OEHGPJGALPA MIBMGGCCOAE);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KMIGMJFBFBN(OEHGPJGALPA MIBMGGCCOAE, CNDIMDCDMGJ BJNLFFPNEBC);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KFABMCFMDEM(OEHGPJGALPA MIBMGGCCOAE, Vector3 EONKHFBPAOH, Vector3 CFOPCMIHOAE, Vector3 JOJAEPAENEC, float PLKAJEEAGIE, float BPFIKADOENN, IReadOnlyList<Camera> GHGCADMHHLN, NFPJKHCPMJI OCBLMBELBFA);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFABMCFMDEM(MKDIEHBAGEG KDNEBGHOCKI, object PKEIBFNHIEB, object BFAACDKIIGH, float EJOCHLIGEJI, Color? PHACDDLFKKF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BLKAEABDGOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OEHGPJGALPA BKAPKNDCMPE(EGKMMMEDNNG IACPDDKLBCL);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGOPFMJNLFG(OEHGPJGALPA MIBMGGCCOAE);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIBDFBALGKC(OEHGPJGALPA MIBMGGCCOAE);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PGGEHKMOPBB OMECPMBOAMP(OEHGPJGALPA MIBMGGCCOAE, CHDMNOIHNGE IACPDDKLBCL);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PGGEHKMOPBB PKJMMIPOJIB(OEHGPJGALPA MIBMGGCCOAE, PAIDDIFPJOB IACPDDKLBCL);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IJNFKMMMFDD(PGGEHKMOPBB KNKEOOBFONA);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GNOMMHLBDDI(PGGEHKMOPBB KNKEOOBFONA);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MKDIEHBAGEG FGGDLGPNKFF(KONKIJAGMCL IACPDDKLBCL);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NAPCGHNMJCB(MKDIEHBAGEG KDNEBGHOCKI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OIPPNDJMPLE(MKDIEHBAGEG KDNEBGHOCKI);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PHCNKNNAIOD DMDOFAKMKDJ(Transform NDFGBDJCFKI, IEnumerable<PGGEHKMOPBB> GMPHNNLMOCM, int ANHOICFFFBF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> PHMNIJCEHLB(OEHGPJGALPA MIBMGGCCOAE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class MKDIEHBAGEG
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal virtual MLIEEMCGBLF BICGDDJDGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x517640", Offset = "0x515E40", VA = "0x180517640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	protected MKDIEHBAGEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KONKIJAGMCL
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int POEBFKJDAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	Transform NMCHPJIFDKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool AJHHOPNFMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OEHGPJGALPA GetBone(int NLAANMDHJKC);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int NLAANMDHJKC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class FDALLGLOCOA : PCPPELIEPPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public CHDMNOIHNGE IFBCDCBFABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int[] LIJFLPNCPAJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public override LLOBECALIDD FILCKEBHMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1A8B910", Offset = "0x1A8A110", VA = "0x181A8B910", Slot = "13")]
		get
		{
			return default(LLOBECALIDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private Vector3 AIHFLMOKLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1A8BCB0", Offset = "0x1A8A4B0", VA = "0x181A8BCB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1A890B0", Offset = "0x1A878B0", VA = "0x181A890B0")]
	public FDALLGLOCOA(ENLJHNKPCNH MIBMGGCCOAE, CHDMNOIHNGE IACPDDKLBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1A8C170", Offset = "0x1A8A970", VA = "0x181A8C170", Slot = "12")]
	public override bool NLENJKPEJIL(Transform MIBMGGCCOAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1A8C670", Offset = "0x1A8AE70", VA = "0x181A8C670", Slot = "14")]
	public override int OOKDBLJACML(NLJOEGOODPP GAKEOHNAFFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1A8C0D0", Offset = "0x1A8A8D0", VA = "0x181A8C0D0", Slot = "15")]
	public override int JOKFPNCGLEK(NLJOEGOODPP GAKEOHNAFFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1A8BE90", Offset = "0x1A8A690", VA = "0x181A8BE90")]
	private int JCAJHBJFJCL(NLJOEGOODPP GAKEOHNAFFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1A8B260", Offset = "0x1A89A60", VA = "0x181A8B260", Slot = "16")]
	public override void COPHFCAFBBM(NLJOEGOODPP GAKEOHNAFFD, HKBINMDMLII GMKBNFKFIKL, int LOEPDAJAABD = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DECPEPOJMFI
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKLEBEBLMIF(CNDIMDCDMGJ BJNLFFPNEBC, Renderer NEHKICKCFKG, int FIIBICNFFLH);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKNFHPCAEOO(Renderer NEHKICKCFKG, NFPJKHCPMJI OCBLMBELBFA, Vector3 EONKHFBPAOH, Vector3 CFOPCMIHOAE, Vector3 JOJAEPAENEC, float PLKAJEEAGIE, float BPFIKADOENN, float EJOCHLIGEJI = -1f, [Optional] Color? PHACDDLFKKF, [Optional] IReadOnlyList<Camera> JEMAPJPMDJF);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKNFHPCAEOO(Renderer NEHKICKCFKG, object PKEIBFNHIEB, object BFAACDKIIGH, bool FEKGGKFKJFM, float EJOCHLIGEJI, Color? PHACDDLFKKF, bool LEGOFDBGICI = false);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KMNDHBDKNDN(Renderer NEHKICKCFKG, int FIIBICNFFLH);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JPNNIMAEBDA();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KPHCLEFGHEK(int DANDBECLBFO, CHKDECKGNMG BJNLFFPNEBC, Renderer NEHKICKCFKG, int FIIBICNFFLH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NKMIHCCIDJH : FIGMIKCGCEK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private DECPEPOJMFI MBDHJMEKKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private MeshRenderer OPPHGDFNJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private KIOCFGKPEHF DFJNFKILDJK;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6B5950", Offset = "0x6B4150", VA = "0x1806B5950")]
	public NKMIHCCIDJH(DECPEPOJMFI DMHJBBCOPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1A8F240", Offset = "0x1A8DA40", VA = "0x181A8F240", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1A8FC60", Offset = "0x1A8E460", VA = "0x181A8FC60", Slot = "4")]
	public void ODBKNMDIFOH(PGGEHKMOPBB KNKEOOBFONA, CHKDECKGNMG MEDFKMEIPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1A8FA90", Offset = "0x1A8E290", VA = "0x181A8FA90", Slot = "5")]
	public void ODBKNMDIFOH(OEHGPJGALPA MIBMGGCCOAE, CHKDECKGNMG MEDFKMEIPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1A8F0B0", Offset = "0x1A8D8B0", VA = "0x181A8F0B0", Slot = "6")]
	public void CJLGJELDNHP(OEHGPJGALPA MIBMGGCCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1A8F8F0", Offset = "0x1A8E0F0", VA = "0x181A8F8F0", Slot = "7")]
	public void KMIGMJFBFBN(OEHGPJGALPA MIBMGGCCOAE, CNDIMDCDMGJ BJNLFFPNEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1A8F2E0", Offset = "0x1A8DAE0", VA = "0x181A8F2E0", Slot = "8")]
	public void KFABMCFMDEM(OEHGPJGALPA MIBMGGCCOAE, Vector3 EONKHFBPAOH, Vector3 CFOPCMIHOAE, Vector3 JOJAEPAENEC, float PLKAJEEAGIE, float BPFIKADOENN, IReadOnlyList<Camera> GHGCADMHHLN, NFPJKHCPMJI OCBLMBELBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1A8F610", Offset = "0x1A8DE10", VA = "0x181A8F610", Slot = "9")]
	public void KFABMCFMDEM(MKDIEHBAGEG KDNEBGHOCKI, object PKEIBFNHIEB, object BFAACDKIIGH, float EJOCHLIGEJI, Color? PHACDDLFKKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class PCPPELIEPPL : PGGEHKMOPBB, DDLDJJBOBFK, GEJPNAHJOCC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected Bounds PPDGFPHBGDP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ENLJHNKPCNH JLLLOONDCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x52EE90", Offset = "0x52D690", VA = "0x18052EE90")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	internal override PCPPELIEPPL GCCNMBIDPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCD0", Offset = "0x5CE4D0", VA = "0x1805CFCD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Bounds CEEOGGIHEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1A90B00", Offset = "0x1A8F300", VA = "0x181A90B00", Slot = "5")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public virtual LLOBECALIDD FILCKEBHMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1A90B20", Offset = "0x1A8F320", VA = "0x181A90B20", Slot = "13")]
		get
		{
			return default(LLOBECALIDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x52F8A0", Offset = "0x52E0A0", VA = "0x18052F8A0", Slot = "12")]
	public virtual bool NLENJKPEJIL(Transform MIBMGGCCOAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int OOKDBLJACML(NLJOEGOODPP GAKEOHNAFFD);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract int JOKFPNCGLEK(NLJOEGOODPP GAKEOHNAFFD);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract void COPHFCAFBBM(NLJOEGOODPP GAKEOHNAFFD, HKBINMDMLII GMKBNFKFIKL, int LOEPDAJAABD = -1);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	protected PCPPELIEPPL()
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
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1A90BB0", Offset = "0x1A8F3B0", VA = "0x181A90BB0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum OLENHHMBJNA
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class EFFECACIBHO
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FOLMDCPGDCK : IEnumerable<GJIGFPKNNMC>, IEnumerable, IEnumerator<GJIGFPKNNMC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private GJIGFPKNNMC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private GJIGFPKNNMC System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x78C260", Offset = "0x78AA60", VA = "0x18078C260")]
		[DebuggerHidden]
		public FOLMDCPGDCK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1A8CEB0", Offset = "0x1A8B6B0", VA = "0x181A8CEB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D020", Offset = "0x1A8B820", VA = "0x181A8D020", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1A8CF90", Offset = "0x1A8B790", VA = "0x181A8CF90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GJIGFPKNNMC> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1A8CF90", Offset = "0x1A8B790", VA = "0x181A8CF90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const int MPFKHGCNHOB = 3;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static GJIGFPKNNMC[][] PCPCNCIKGCJ;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static IMPGOHGGPLH NHIJCBCKHNJ;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public static ShapeRendererConfig GFBPENOIDBK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static ComputeShader LGACOEKLACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1A88210", Offset = "0x1A86A10", VA = "0x181A88210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static SkinnedShapeRenderer ONDNLHGNIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1A88440", Offset = "0x1A86C40", VA = "0x181A88440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1A884B0", Offset = "0x1A86CB0", VA = "0x181A884B0")]
	public static Mesh MMOHPAJFNGH(OLENHHMBJNA HKKOIINEOCC, int GAKEOHNAFFD = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1A88200", Offset = "0x1A86A00", VA = "0x181A88200")]
	public static int EDDIJOHIPFG(OLENHHMBJNA HKKOIINEOCC, int GAKEOHNAFFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1A87C80", Offset = "0x1A86480", VA = "0x181A87C80")]
	public static IMPGOHGGPLH DPHECIDCAAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1A88570", Offset = "0x1A86D70", VA = "0x181A88570")]
	[IteratorStateMachine(typeof(FOLMDCPGDCK))]
	private static IEnumerable<GJIGFPKNNMC> MONFBEBLAPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1A87940", Offset = "0x1A86140", VA = "0x181A87940")]
	public static GJIGFPKNNMC DEHDADCBJBO(OLENHHMBJNA HKKOIINEOCC, int GAKEOHNAFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1A885D0", Offset = "0x1A86DD0", VA = "0x181A885D0")]
	public static bool NCGHBNFHFJM(this OLENHHMBJNA HKKOIINEOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1A88280", Offset = "0x1A86A80", VA = "0x181A88280")]
	public static void HEJMFFHMDHF(OLENHHMBJNA HKKOIINEOCC, float3 HBCMHKBOJBP, out IFHAHJFPGGJ GKNIEDAMCAL, out float3 CPDDCFGMBMJ, out float BPJBGGMHOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1A87DD0", Offset = "0x1A865D0", VA = "0x181A87DD0")]
	public static void EBEJICPLKFO(Vector3 HBCMHKBOJBP, OLENHHMBJNA HKKOIINEOCC, out Vector3 CPDDCFGMBMJ, out float BPJBGGMHOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1A881F0", Offset = "0x1A869F0", VA = "0x181A881F0")]
	[IHAEEOOOIEN(HNJFJNMDEKM.ExitingPlayMode, 0)]
	private static void EBLEFIGEPKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1A87720", Offset = "0x1A85F20", VA = "0x181A87720")]
	[IHAEEOOOIEN(HNJFJNMDEKM.ExitingPlayMode, 0)]
	private static void CBODGFPEEPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EGHPCIPFPNP
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool FHIFGKIDAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material LILLNAGPIED();

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material FJKJFMJHEPC();

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material KBPHOJBCADC();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EGNNEONMCIL(NMNAIMAJNEK JJKGFCHMIOP);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IJBFHKNMCGE(CMAKHAAHCFH LIEIGKFCMEK);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PLNAKADAIPB(GameObject JGHAOGLDGDA);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BIMCJLMENMB(GameObject JGHAOGLDGDA, bool MGPCNHCLMKE);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NPKLKGKCHLP : BLKAEABDGOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static EGHPCIPFPNP AJPCMHKAPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1A90820", Offset = "0x1A8F020", VA = "0x181A90820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1A905E0", Offset = "0x1A8EDE0", VA = "0x181A905E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1A90930", Offset = "0x1A8F130", VA = "0x181A90930")]
	public NPKLKGKCHLP(EGHPCIPFPNP DMHJBBCOPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1A8FF10", Offset = "0x1A8E710", VA = "0x181A8FF10", Slot = "4")]
	public OEHGPJGALPA BKAPKNDCMPE(EGKMMMEDNNG IACPDDKLBCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1A903C0", Offset = "0x1A8EBC0", VA = "0x181A903C0", Slot = "5")]
	public void EGOPFMJNLFG(OEHGPJGALPA MIBMGGCCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1A8FED0", Offset = "0x1A8E6D0", VA = "0x181A8FED0", Slot = "6")]
	public void BIBDFBALGKC(OEHGPJGALPA MIBMGGCCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1A90780", Offset = "0x1A8EF80", VA = "0x181A90780", Slot = "15")]
	public IEnumerable<Renderer> PHMNIJCEHLB(OEHGPJGALPA MIBMGGCCOAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1A906B0", Offset = "0x1A8EEB0", VA = "0x181A906B0", Slot = "7")]
	public PGGEHKMOPBB OMECPMBOAMP(OEHGPJGALPA MIBMGGCCOAE, CHDMNOIHNGE IACPDDKLBCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1A90860", Offset = "0x1A8F060", VA = "0x181A90860", Slot = "8")]
	public PGGEHKMOPBB PKJMMIPOJIB(OEHGPJGALPA MIBMGGCCOAE, PAIDDIFPJOB IACPDDKLBCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1A90530", Offset = "0x1A8ED30", VA = "0x181A90530", Slot = "9")]
	public void IJNFKMMMFDD(PGGEHKMOPBB KNKEOOBFONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1A904E0", Offset = "0x1A8ECE0", VA = "0x181A904E0", Slot = "10")]
	public void GNOMMHLBDDI(PGGEHKMOPBB KNKEOOBFONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1A90420", Offset = "0x1A8EC20", VA = "0x181A90420", Slot = "11")]
	public MKDIEHBAGEG FGGDLGPNKFF(KONKIJAGMCL IACPDDKLBCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1A90630", Offset = "0x1A8EE30", VA = "0x181A90630", Slot = "12")]
	public void NAPCGHNMJCB(MKDIEHBAGEG KDNEBGHOCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1A90670", Offset = "0x1A8EE70", VA = "0x181A90670", Slot = "13")]
	public void OIPPNDJMPLE(MKDIEHBAGEG KDNEBGHOCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1A8FFC0", Offset = "0x1A8E7C0", VA = "0x181A8FFC0", Slot = "14")]
	public PHCNKNNAIOD DMDOFAKMKDJ(Transform NDFGBDJCFKI, IEnumerable<PGGEHKMOPBB> GMPHNNLMOCM, int ANHOICFFFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MLIEEMCGBLF : MKDIEHBAGEG, PHIICEBDCDP
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class APOODNAKIMO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public MLIEEMCGBLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x78C260", Offset = "0x78AA60", VA = "0x18078C260")]
		[DebuggerHidden]
		public APOODNAKIMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1A87640", Offset = "0x1A85E40", VA = "0x181A87640", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1A87360", Offset = "0x1A85B60", VA = "0x181A87360", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1A876E0", Offset = "0x1A85EE0", VA = "0x181A876E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1A875F0", Offset = "0x1A85DF0", VA = "0x181A875F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1A87550", Offset = "0x1A85D50", VA = "0x181A87550", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1A87550", Offset = "0x1A85D50", VA = "0x181A87550", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private KONKIJAGMCL GAFPELCBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private FGKPPGHEKIJ FPICJBMNCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private List<ELBAJEMILBG> EKBONCMLCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private List<ELBAJEMILBG> NHAJPELBAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private GameObject ACHMELFAHDP;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	internal override MLIEEMCGBLF BICGDDJDGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCD0", Offset = "0x5CE4D0", VA = "0x1805CFCD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1A8EF70", Offset = "0x1A8D770", VA = "0x181A8EF70")]
	public static MLIEEMCGBLF PIDAKADNEBC(KONKIJAGMCL IACPDDKLBCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1A8F030", Offset = "0x1A8D830", VA = "0x181A8F030")]
	private MLIEEMCGBLF(KONKIJAGMCL IACPDDKLBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1A8E230", Offset = "0x1A8CA30", VA = "0x181A8E230")]
	public void MIJAAKNMDAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1A8DFF0", Offset = "0x1A8C7F0", VA = "0x181A8DFF0")]
	[IteratorStateMachine(typeof(APOODNAKIMO))]
	public IEnumerable<Renderer> FJDBGIDJHBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1A8E650", Offset = "0x1A8CE50", VA = "0x181A8E650", Slot = "5")]
	public void MPAILAEPEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1A8EF40", Offset = "0x1A8D740", VA = "0x181A8EF40")]
	private void OJCMOMFKPEG(Vector3 LFMJMMOFNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1A8E060", Offset = "0x1A8C860", VA = "0x181A8E060")]
	public void GMABKAMPIOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ELBAJEMILBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct LJEKFEGGLAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public HKBINMDMLII IDFJKCDKILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Transform DAGDKPOCNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int LIAIDGIAGCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class BLJMLMJKJNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ELBAJEMILBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public NLJOEGOODPP lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public List<LJEKFEGGLAK> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public BLJMLMJKJNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class ILHMPFDFKPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public PHCNKNNAIOD combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public BLJMLMJKJNL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public ILHMPFDFKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1A8DDB0", Offset = "0x1A8C5B0", VA = "0x181A8DDB0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1A8DE20", Offset = "0x1A8C620", VA = "0x181A8DE20")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1A8DE60", Offset = "0x1A8C660", VA = "0x181A8DE60")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private int[] LIAAKOJKPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private MKAALACOFDE ICAABGHCPBM;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static Matrix4x4 IIEIBAJNNCJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Mesh OHAKDFDIABA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x52EE90", Offset = "0x52D690", VA = "0x18052EE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int OFBGIIBCJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x50B440", Offset = "0x509C40", VA = "0x18050B440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5C71C0", Offset = "0x5C59C0", VA = "0x1805C71C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1A89B90", Offset = "0x1A88390", VA = "0x181A89B90")]
	public void PPPMKMLFFGM(List<Transform> MPHCJOHIHNP, Matrix4x4[] MELJCGAFFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1A89600", Offset = "0x1A87E00", VA = "0x181A89600")]
	public static List<ELBAJEMILBG> OALNFBLCHMK(List<JCNALHHENIP> CBCGBDGGEAE, NLJOEGOODPP GAKEOHNAFFD, Bounds MKNDOOPGPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1A89180", Offset = "0x1A87980", VA = "0x181A89180")]
	private JobHandle HIADNLDHEBG(PHCNKNNAIOD AGNCFMJHFLO, int NFLLPDHDGCP, int GIJEFCNLFIB, NLJOEGOODPP GAKEOHNAFFD, List<LJEKFEGGLAK> DEGNFBOJOEN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A89500", Offset = "0x1A87D00", VA = "0x181A89500")]
	private void LDEKEHKIONA(List<LJEKFEGGLAK> DEGNFBOJOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1A89ED0", Offset = "0x1A886D0", VA = "0x181A89ED0")]
	private ELBAJEMILBG(List<LJEKFEGGLAK> DEGNFBOJOEN, int NFLLPDHDGCP, int GIJEFCNLFIB, NLJOEGOODPP GAKEOHNAFFD, Bounds MKNDOOPGPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1A89100", Offset = "0x1A87900", VA = "0x181A89100", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private MaterialPropertyBlock GEENJCOEGEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private ELBAJEMILBG NMCFIAPNHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private List<Transform> BKAIAHFBAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private RenderTexture ADAIBPFBPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private ComputeBuffer GHOFKCNKADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private ComputeShader OIBCOHMNMBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Matrix4x4[] NKKPBOMNLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int OIKNLPFELEJ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MeshRenderer IEMINALAPNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x50E430", Offset = "0x50CC30", VA = "0x18050E430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int POEBFKJDAOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1A91750", Offset = "0x1A8FF50", VA = "0x181A91750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1A90BE0", Offset = "0x1A8F3E0", VA = "0x181A90BE0")]
		public static List<SkinnedShapeRenderer> Create(GameObject MIBMGGCCOAE, List<ELBAJEMILBG> PHBOMLNFLLE, List<Transform> BKAIAHFBAGA, Material JINDGNNOMND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1A90E80", Offset = "0x1A8F680", VA = "0x181A90E80")]
		public void Init(ELBAJEMILBG NMCFIAPNHNL, List<Transform> BKAIAHFBAGA, Material JINDGNNOMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1A91370", Offset = "0x1A8FB70", VA = "0x181A91370")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1A912E0", Offset = "0x1A8FAE0", VA = "0x181A912E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1A912A0", Offset = "0x1A8FAA0", VA = "0x181A912A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1A90DF0", Offset = "0x1A8F5F0", VA = "0x181A90DF0")]
		private void HGHDDLHNADD(ScriptableRenderContext OJAOPEPLKMN, Camera[] HMJGABOAGGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1A91400", Offset = "0x1A8FC00", VA = "0x181A91400")]
		private void PPPMKMLFFGM(CommandBuffer LFKOIAKFNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x507A60", Offset = "0x506260", VA = "0x180507A60")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class IAGGKLCNKGJ
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static byte[] LHMKKNGADDJ;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static int MGOKGGCOJHO;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static int FHPCKBOKGPL;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static BigInteger KMAGGJIIKDL;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public IAGGKLCNKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1A8DAB0", Offset = "0x1A8C2B0", VA = "0x181A8DAB0")]
	private static string POIGIBFCCMB(byte[] LANKPNEAHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1A8D780", Offset = "0x1A8BF80", VA = "0x181A8D780")]
	public static string MHKKELLNKIL(byte[] OCICGABDCEM, bool MDIDJMNJINP)
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

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
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
