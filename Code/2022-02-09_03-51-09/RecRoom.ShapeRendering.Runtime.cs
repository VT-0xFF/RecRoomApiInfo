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
public enum HGFLMLGEMKL
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
public enum BACHIKIBIKM
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
public enum LMPPPJKMDGL
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
public enum HMMFJFBFJBJ
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
public enum HALJAKOALAN
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
public class LGHEOADDJBH : IPDCIPDPFFD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private const byte MECJICFJMMM = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private byte KDKNPDPDECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly List<SkinnedShapeRenderer>[] NIIAHGFKHLF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NGHDKGBNFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4E9CD0", Offset = "0x4E8AD0", VA = "0x1804E9CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5C6700", Offset = "0x5C5500", VA = "0x1805C6700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LGINHLBKPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4E9CC0", Offset = "0x4E8AC0", VA = "0x1804E9CC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D1040", Offset = "0x5CFE40", VA = "0x1805D1040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float NGOAMDJFFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xF3BC00", Offset = "0xF3AA00", VA = "0x180F3BC00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1139100", Offset = "0x1137F00", VA = "0x181139100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float OPMALGKPBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE46EE0", Offset = "0xE45CE0", VA = "0x180E46EE0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE46EF0", Offset = "0xE45CF0", VA = "0x180E46EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> DEPNENHBLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4637D90", Offset = "0x4636B90", VA = "0x184637D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GameObject KAKHKOLAJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x511A30", Offset = "0x510830", VA = "0x180511A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5AE660", Offset = "0x5AD460", VA = "0x1805AE660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public byte EPIEMBBKMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4637EE0", Offset = "0x4636CE0", VA = "0x184637EE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4638080", Offset = "0x4636E80", VA = "0x184638080")]
	public LGHEOADDJBH(List<IAMPBALMBLK> NHEDDJMKGAL, List<IAMPBALMBLK> INOFABLMEPJ, List<Transform> AKFHKLNDJGL, Material IIDNGJABNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4637F30", Offset = "0x4636D30", VA = "0x184637F30")]
	private int PJFMKOGOLPM(List<IAMPBALMBLK> JHFHLNPNJOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4637BA0", Offset = "0x46369A0", VA = "0x184637BA0")]
	private void DJPIMLECFBG(int ALAFHGPIKPP, bool BFKELIMBODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4637DF0", Offset = "0x4636BF0", VA = "0x184637DF0")]
	public void MKIJMDOGDNA(Vector3 NEHIFDOIBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4637D00", Offset = "0x4636B00", VA = "0x184637D00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4638040", Offset = "0x4636E40", VA = "0x184638040")]
	public void PJGPPMHAELC(Transform OOLFOBHMKJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IDPEPEOGAJD : LLOIPHHJNLM, AAKOHCJNEAA, PIKBJDPEGAO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class MDJLFJJNEBC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public IDPEPEOGAJD <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89D2C0", Offset = "0x89C0C0", VA = "0x18089D2C0")]
		[DebuggerHidden]
		public MDJLFJJNEBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4639740", Offset = "0x4638540", VA = "0x184639740", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4639290", Offset = "0x4638090", VA = "0x184639290", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x46398C0", Offset = "0x46386C0", VA = "0x1846398C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4639900", Offset = "0x4638700", VA = "0x184639900")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4639950", Offset = "0x4638750", VA = "0x184639950")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x46396F0", Offset = "0x46384F0", VA = "0x1846396F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4639650", Offset = "0x4638450", VA = "0x184639650", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4639650", Offset = "0x4638450", VA = "0x184639650", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private PDGIJFCIFKF JHMJDCBFEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private List<MHIPEHKCHLE> HIENGLIGKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private List<ClusterMeshRenderer> LONBKOPKPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private BatchedMeshRenderer CHNKGOIIMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool EOOIIMOKEKL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IEnumerable<KJPKDAMLGIJ> EJIJCAOOMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int EPDNOOEHAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4636140", Offset = "0x4634F40", VA = "0x184636140", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform KJPJPJKMLJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x46360F0", Offset = "0x4634EF0", VA = "0x1846360F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal override IDPEPEOGAJD DJOMPJKNBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x57EB30", Offset = "0x57D930", VA = "0x18057EB30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4636700", Offset = "0x4635500", VA = "0x184636700")]
	public IDPEPEOGAJD(PDGIJFCIFKF EFJLNJBKBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4635A00", Offset = "0x4634800", VA = "0x184635A00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4635A30", Offset = "0x4634830", VA = "0x184635A30")]
	public void EFHDBFNBKGH(MHIPEHKCHLE OCPACFIOOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4636180", Offset = "0x4634F80", VA = "0x184636180")]
	public void KGKIHAGANBK(MHIPEHKCHLE OCPACFIOOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x46361F0", Offset = "0x4634FF0", VA = "0x1846361F0", Slot = "5")]
	public void KJEIKKKDNLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4635970", Offset = "0x4634770", VA = "0x184635970")]
	public void CNIMBBBDAOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x46357B0", Offset = "0x46345B0", VA = "0x1846357B0")]
	private void BAEDINIANII(MHIPEHKCHLE OCPACFIOOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4635B00", Offset = "0x4634900", VA = "0x184635B00")]
	public void ELIOENOBANM(bool NLAKDPHMLCO, bool LIHOAFHEGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4635FE0", Offset = "0x4634DE0", VA = "0x184635FE0")]
	protected void FHPMCHAHLGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4635900", Offset = "0x4634700", VA = "0x184635900")]
	[IteratorStateMachine(typeof(MDJLFJJNEBC))]
	public IEnumerable<Renderer> BCCIELKNHCD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class BHDDLKPLMLD : MHIPEHKCHLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private LEEELAHCPHJ KFINJHKKLOH;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4630B50", Offset = "0x462F950", VA = "0x184630B50")]
	private NativeList<AMOONGBLJID> MEPLLJDOBII()
	{
		return default(NativeList<AMOONGBLJID>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4630E40", Offset = "0x462FC40", VA = "0x184630E40")]
	public BHDDLKPLMLD(IDPEPEOGAJD ILMCIJGNPKB, LEEELAHCPHJ EFJLNJBKBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4630C20", Offset = "0x462FA20", VA = "0x184630C20", Slot = "14")]
	public override int PJFMKOGOLPM(DMMEFAOHKAI KPEFNKLAHLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4630930", Offset = "0x462F730", VA = "0x184630930", Slot = "15")]
	public override int JLKAPNGJFDI(DMMEFAOHKAI KPEFNKLAHLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4630400", Offset = "0x462F200", VA = "0x184630400", Slot = "16")]
	public override void GMAFPOMEJFG(DMMEFAOHKAI KPEFNKLAHLE, OFGFGEDIPGM LGIBOCGIBCG, int KJHFIIEBDOC = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class LLOIPHHJNLM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	internal virtual IDPEPEOGAJD DJOMPJKNBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x516E80", Offset = "0x515C80", VA = "0x180516E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
	protected LLOIPHHJNLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum FMPPJJIDPGJ
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
public interface PDGIJFCIFKF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform OHMKNFIPACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	FMPPJJIDPGJ EODDLPBDCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class ANNPCDKICFM
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal virtual MHIPEHKCHLE JNNDIOMCHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x516E80", Offset = "0x515C80", VA = "0x180516E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
	protected ANNPCDKICFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CCONJJNJOIP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform OHMKNFIPACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float ICAGCKKEHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Vector3 PLCDFFHAIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	HGFLMLGEMKL BIDBJPPIKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	BACHIKIBIKM IBCIDIAFECI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LIEPOBOICIJ : CCONJJNJOIP
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IFBJNLNCKAO IHCALKNDCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EENJEDBADEF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LEEELAHCPHJ : CCONJJNJOIP
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KNBLHMKJBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool ADKJFDKPHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float AGIAPLBGDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	int MFKIMPOHNJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool ECJBEMGFLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<AMOONGBLJID> MEPLLJDOBII();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NBADLNGACJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABGJBIKKAEN(ANNPCDKICFM OCPACFIOOGI, HMMFJFBFJBJ BIELOLCNFDH);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABGJBIKKAEN(LLOIPHHJNLM ILMCIJGNPKB, HMMFJFBFJBJ BIELOLCNFDH);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBCPCHJHNDD(LLOIPHHJNLM ILMCIJGNPKB);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PJNCDGMKKJD(LLOIPHHJNLM ILMCIJGNPKB, HALJAKOALAN FKELJAJFEHC);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FBONFIIOLII(LLOIPHHJNLM ILMCIJGNPKB, Vector3 NAAJBLAFEBI, Vector3 PEJHLBKALJM, Vector3 FDCMEBKCLBO, float IJDKDPHEHIE, float IIENMDAEALP, IReadOnlyList<Camera> ABLNNBJFLBG, LMPPPJKMDGL PNDGGHDAJKE);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FBONFIIOLII(KHBPHLILJAC FEEDNCPFJPB, object JCOMGNANHDM, object NBOADNLJOEJ, float JENGCJDKMLI, Color? MPHOPFLBFBH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HJDFPFNJDBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LLOIPHHJNLM HMNKKKNNBNA(PDGIJFCIFKF EFJLNJBKBMJ);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNPNFDEINDN(LLOIPHHJNLM ILMCIJGNPKB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HAODGLBFFGF(LLOIPHHJNLM ILMCIJGNPKB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ANNPCDKICFM AOIBKCCKHOO(LLOIPHHJNLM ILMCIJGNPKB, LIEPOBOICIJ EFJLNJBKBMJ);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ANNPCDKICFM DCJFANGEDMH(LLOIPHHJNLM ILMCIJGNPKB, LEEELAHCPHJ EFJLNJBKBMJ);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ICPABNFLNDC(ANNPCDKICFM OCPACFIOOGI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PDKIKFAOIBL(ANNPCDKICFM OCPACFIOOGI);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KHBPHLILJAC FJFLEEENEMD(NCKOGMFAOFP EFJLNJBKBMJ);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PILIDBILPDK(KHBPHLILJAC FEEDNCPFJPB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OACMKJNKMNC(KHBPHLILJAC FEEDNCPFJPB);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BPHOGJLMOEJ NFMCMOGBKLA(Transform LMLAPAAHGLE, IEnumerable<ANNPCDKICFM> HIENGLIGKDG, int DKEBBJLAMKO);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> LGECLHAHMOI(LLOIPHHJNLM ILMCIJGNPKB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class KHBPHLILJAC
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal virtual EBCNCEGFCON HLHKFLJAPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x516E80", Offset = "0x515C80", VA = "0x180516E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
	protected KHBPHLILJAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NCKOGMFAOFP
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int EPPGINKLOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	Transform NCPAHNNLKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool KIIJAAMEHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LLOIPHHJNLM GetBone(int BKHJEJHDFJJ);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int BKHJEJHDFJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class FBDLHDCCGGL : MHIPEHKCHLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public LIEPOBOICIJ NMMAAPGDHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int[] CCKAJFACHLP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public override AAPODEOBBEG KGOAMHEECIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x46324F0", Offset = "0x46312F0", VA = "0x1846324F0", Slot = "13")]
		get
		{
			return default(AAPODEOBBEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private Vector3 LICDBADPGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4632310", Offset = "0x4631110", VA = "0x184632310")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4630E40", Offset = "0x462FC40", VA = "0x184630E40")]
	public FBDLHDCCGGL(IDPEPEOGAJD ILMCIJGNPKB, LIEPOBOICIJ EFJLNJBKBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4632890", Offset = "0x4631690", VA = "0x184632890", Slot = "12")]
	public override bool FJLMDLNPKGP(Transform ILMCIJGNPKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4633720", Offset = "0x4632520", VA = "0x184633720", Slot = "14")]
	public override int PJFMKOGOLPM(DMMEFAOHKAI KPEFNKLAHLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4633680", Offset = "0x4632480", VA = "0x184633680", Slot = "15")]
	public override int JLKAPNGJFDI(DMMEFAOHKAI KPEFNKLAHLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4633440", Offset = "0x4632240", VA = "0x184633440")]
	private int IHKLMDACKMC(DMMEFAOHKAI KPEFNKLAHLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4632D90", Offset = "0x4631B90", VA = "0x184632D90", Slot = "16")]
	public override void GMAFPOMEJFG(DMMEFAOHKAI KPEFNKLAHLE, OFGFGEDIPGM LGIBOCGIBCG, int KJHFIIEBDOC = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PJJALMPDJJO
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKGPGCNLBNG(HALJAKOALAN FKELJAJFEHC, Renderer EGLKLFNMLLF, int DFBEDJMHPMN);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILOOMECPNFP(Renderer EGLKLFNMLLF, LMPPPJKMDGL PNDGGHDAJKE, Vector3 NAAJBLAFEBI, Vector3 PEJHLBKALJM, Vector3 FDCMEBKCLBO, float IJDKDPHEHIE, float IIENMDAEALP, float JENGCJDKMLI = -1f, [Optional] Color? MPHOPFLBFBH, [Optional] IReadOnlyList<Camera> EGADDBFDHIL);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILOOMECPNFP(Renderer EGLKLFNMLLF, object JCOMGNANHDM, object NBOADNLJOEJ, bool NJBJGNHCLCI, float JENGCJDKMLI, Color? MPHOPFLBFBH, bool JIEJNBEGABB = false);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MONAKEGEPKE(Renderer EGLKLFNMLLF, int DFBEDJMHPMN);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int MCLEHBKNNAE();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IOFNOMFMKBH(int DHHFIJCJOLA, HMMFJFBFJBJ FKELJAJFEHC, Renderer EGLKLFNMLLF, int DFBEDJMHPMN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JCOLEONJANE : NBADLNGACJA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private PJJALMPDJJO DFEKPOAOBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private MeshRenderer FGACPIOEAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private NDMBADCMPEA PFBKPPIIOKO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5AB430", Offset = "0x5AA230", VA = "0x1805AB430")]
	public JCOLEONJANE(PJJALMPDJJO IGCCEOJHAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4636BD0", Offset = "0x46359D0", VA = "0x184636BD0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4636960", Offset = "0x4635760", VA = "0x184636960", Slot = "4")]
	public void ABGJBIKKAEN(ANNPCDKICFM OCPACFIOOGI, HMMFJFBFJBJ BIELOLCNFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4636790", Offset = "0x4635590", VA = "0x184636790", Slot = "5")]
	public void ABGJBIKKAEN(LLOIPHHJNLM ILMCIJGNPKB, HMMFJFBFJBJ BIELOLCNFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4637280", Offset = "0x4636080", VA = "0x184637280", Slot = "6")]
	public void KBCPCHJHNDD(LLOIPHHJNLM ILMCIJGNPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4637410", Offset = "0x4636210", VA = "0x184637410", Slot = "7")]
	public void PJNCDGMKKJD(LLOIPHHJNLM ILMCIJGNPKB, HALJAKOALAN FKELJAJFEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4636C70", Offset = "0x4635A70", VA = "0x184636C70", Slot = "8")]
	public void FBONFIIOLII(LLOIPHHJNLM ILMCIJGNPKB, Vector3 NAAJBLAFEBI, Vector3 PEJHLBKALJM, Vector3 FDCMEBKCLBO, float IJDKDPHEHIE, float IIENMDAEALP, IReadOnlyList<Camera> ABLNNBJFLBG, LMPPPJKMDGL PNDGGHDAJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4636FA0", Offset = "0x4635DA0", VA = "0x184636FA0", Slot = "9")]
	public void FBONFIIOLII(KHBPHLILJAC FEEDNCPFJPB, object JCOMGNANHDM, object NBOADNLJOEJ, float JENGCJDKMLI, Color? MPHOPFLBFBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class MHIPEHKCHLE : ANNPCDKICFM, KPCAGAHCJHB, KJPKDAMLGIJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected Bounds ANFOBCDPNGN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IDPEPEOGAJD KAKHKOLAJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4E91D0", Offset = "0x4E7FD0", VA = "0x1804E91D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4E9490", Offset = "0x4E8290", VA = "0x1804E9490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	internal override MHIPEHKCHLE JNNDIOMCHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x57EB30", Offset = "0x57D930", VA = "0x18057EB30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Bounds KHDAJPHDFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xE1ACF0", Offset = "0xE19AF0", VA = "0x180E1ACF0", Slot = "5")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public virtual AAPODEOBBEG KGOAMHEECIG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x46399A0", Offset = "0x46387A0", VA = "0x1846399A0", Slot = "13")]
		get
		{
			return default(AAPODEOBBEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EC0", Offset = "0x4E8CC0", VA = "0x1804E9EC0", Slot = "12")]
	public virtual bool FJLMDLNPKGP(Transform ILMCIJGNPKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int PJFMKOGOLPM(DMMEFAOHKAI KPEFNKLAHLE);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract int JLKAPNGJFDI(DMMEFAOHKAI KPEFNKLAHLE);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract void GMAFPOMEJFG(DMMEFAOHKAI KPEFNKLAHLE, OFGFGEDIPGM LGIBOCGIBCG, int KJHFIIEBDOC = -1);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
	protected MHIPEHKCHLE()
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
		[Cpp2IlInjected.Address(RVA = "0x4639BF0", Offset = "0x46389F0", VA = "0x184639BF0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum IFBJNLNCKAO
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
public static class LIOAMOIKGNC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PAAMHMAPPNJ : IEnumerable<BDDJGBMAJEK>, IEnumerable, IEnumerator<BDDJGBMAJEK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private BDDJGBMAJEK <>2__current;

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
		private BDDJGBMAJEK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x89D2C0", Offset = "0x89C0C0", VA = "0x18089D2C0")]
		[DebuggerHidden]
		public PAAMHMAPPNJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4639A30", Offset = "0x4638830", VA = "0x184639A30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4639BA0", Offset = "0x46389A0", VA = "0x184639BA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4639B10", Offset = "0x4638910", VA = "0x184639B10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BDDJGBMAJEK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4639B10", Offset = "0x4638910", VA = "0x184639B10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const int PHEGGLEPNPE = 3;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static BDDJGBMAJEK[][] LBHKACJHBMA;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static NAOBMEFLKHC HLKGNELBMPH;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public static ShapeRendererConfig EJPLKMHFAHH;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static ComputeShader MOFCPOJGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x46387D0", Offset = "0x46375D0", VA = "0x1846387D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static SkinnedShapeRenderer EGKAIOHLMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x46391A0", Offset = "0x4637FA0", VA = "0x1846391A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4638B70", Offset = "0x4637970", VA = "0x184638B70")]
	public static Mesh IMAGAANHLIK(IFBJNLNCKAO GHPBLJIODBF, int KPEFNKLAHLE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4638C30", Offset = "0x4637A30", VA = "0x184638C30")]
	public static int JNKJILFPFNF(IFBJNLNCKAO GHPBLJIODBF, int KPEFNKLAHLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4638A20", Offset = "0x4637820", VA = "0x184638A20")]
	public static NAOBMEFLKHC HDIMCBJIPFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4638340", Offset = "0x4637140", VA = "0x184638340")]
	[IteratorStateMachine(typeof(PAAMHMAPPNJ))]
	private static IEnumerable<BDDJGBMAJEK> ACKGEAEHEEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4638E60", Offset = "0x4637C60", VA = "0x184638E60")]
	public static BDDJGBMAJEK MNHKPAHPNDI(IFBJNLNCKAO GHPBLJIODBF, int KPEFNKLAHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4638A00", Offset = "0x4637800", VA = "0x184638A00")]
	public static bool DPEJDADCHIK(this IFBJNLNCKAO GHPBLJIODBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4638840", Offset = "0x4637640", VA = "0x184638840")]
	public static void DADKJDIFIFC(IFBJNLNCKAO GHPBLJIODBF, float3 FIABNBDODMA, out POBNCAKLCHE AENFJDMOGAL, out float3 HPKBOLLJILE, out float MANFBNNCOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x46383B0", Offset = "0x46371B0", VA = "0x1846383B0")]
	public static void BDJBNJMCPFG(Vector3 FIABNBDODMA, IFBJNLNCKAO GHPBLJIODBF, out Vector3 HPKBOLLJILE, out float MANFBNNCOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x46383A0", Offset = "0x46371A0", VA = "0x1846383A0")]
	[JCLDHOBNPEL(PBHFHEIAOOM.ExitingPlayMode, 0)]
	private static void ACPBGHPCKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4638C40", Offset = "0x4637A40", VA = "0x184638C40")]
	[JCLDHOBNPEL(PBHFHEIAOOM.ExitingPlayMode, 0)]
	private static void MBMJPEGFHCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface PNEKNFPJBFK
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool AGHNADCPDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material HBBICLEOCGM();

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material FMINNMDEGLA();

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material EMGAHKGCKIH();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FIKKLPJKOCM(HGFLMLGEMKL CLLJFKPELOP);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FFEAAHEKPPN(BACHIKIBIKM EMPPDCAJBAB);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HHDBNOJPLPA(GameObject OBJNDDPFMFI);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DFGKPKPPGIP(GameObject OBJNDDPFMFI, bool DJGALJDHIDK);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GLKCFAPDMGC : HJDFPFNJDBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static PNEKNFPJBFK LGAAMFLEBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4633D10", Offset = "0x4632B10", VA = "0x184633D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4633A60", Offset = "0x4632860", VA = "0x184633A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4634220", Offset = "0x4633020", VA = "0x184634220")]
	public GLKCFAPDMGC(PNEKNFPJBFK IGCCEOJHAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4633AB0", Offset = "0x46328B0", VA = "0x184633AB0", Slot = "4")]
	public LLOIPHHJNLM HMNKKKNNBNA(PDGIJFCIFKF EFJLNJBKBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4633C10", Offset = "0x4632A10", VA = "0x184633C10", Slot = "5")]
	public void KNPNFDEINDN(LLOIPHHJNLM ILMCIJGNPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4633A20", Offset = "0x4632820", VA = "0x184633A20", Slot = "6")]
	public void HAODGLBFFGF(LLOIPHHJNLM ILMCIJGNPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4633C70", Offset = "0x4632A70", VA = "0x184633C70", Slot = "15")]
	public IEnumerable<Renderer> LGECLHAHMOI(LLOIPHHJNLM ILMCIJGNPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x46337C0", Offset = "0x46325C0", VA = "0x1846337C0", Slot = "7")]
	public ANNPCDKICFM AOIBKCCKHOO(LLOIPHHJNLM ILMCIJGNPKB, LIEPOBOICIJ EFJLNJBKBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4633890", Offset = "0x4632690", VA = "0x184633890", Slot = "8")]
	public ANNPCDKICFM DCJFANGEDMH(LLOIPHHJNLM ILMCIJGNPKB, LEEELAHCPHJ EFJLNJBKBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4633B60", Offset = "0x4632960", VA = "0x184633B60", Slot = "9")]
	public void ICPABNFLNDC(ANNPCDKICFM OCPACFIOOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4634190", Offset = "0x4632F90", VA = "0x184634190", Slot = "10")]
	public void PDKIKFAOIBL(ANNPCDKICFM OCPACFIOOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4633960", Offset = "0x4632760", VA = "0x184633960", Slot = "11")]
	public KHBPHLILJAC FJFLEEENEMD(NCKOGMFAOFP EFJLNJBKBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x46341E0", Offset = "0x4632FE0", VA = "0x1846341E0", Slot = "12")]
	public void PILIDBILPDK(KHBPHLILJAC FEEDNCPFJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4634150", Offset = "0x4632F50", VA = "0x184634150", Slot = "13")]
	public void OACMKJNKMNC(KHBPHLILJAC FEEDNCPFJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4633D50", Offset = "0x4632B50", VA = "0x184633D50", Slot = "14")]
	public BPHOGJLMOEJ NFMCMOGBKLA(Transform LMLAPAAHGLE, IEnumerable<ANNPCDKICFM> HIENGLIGKDG, int DKEBBJLAMKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EBCNCEGFCON : KHBPHLILJAC, AAKOHCJNEAA
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DJGHCGPPPEL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EBCNCEGFCON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x89D2C0", Offset = "0x89C0C0", VA = "0x18089D2C0")]
		[DebuggerHidden]
		public DJGHCGPPPEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4631170", Offset = "0x462FF70", VA = "0x184631170", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4630E90", Offset = "0x462FC90", VA = "0x184630E90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4631210", Offset = "0x4630010", VA = "0x184631210")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4631120", Offset = "0x462FF20", VA = "0x184631120", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4631080", Offset = "0x462FE80", VA = "0x184631080", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4631080", Offset = "0x462FE80", VA = "0x184631080", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private NCKOGMFAOFP NKHCELCPEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private LGHEOADDJBH GGCLCKNPNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private List<IAMPBALMBLK> LIEEHJGIFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private List<IAMPBALMBLK> KOBMOGCDGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private GameObject JEOLJIDGKHK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	internal override EBCNCEGFCON HLHKFLJAPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x57EB30", Offset = "0x57D930", VA = "0x18057EB30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4631250", Offset = "0x4630050", VA = "0x184631250")]
	public static EBCNCEGFCON ALFNAEMCJIA(NCKOGMFAOFP EFJLNJBKBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4632290", Offset = "0x4631090", VA = "0x184632290")]
	private EBCNCEGFCON(NCKOGMFAOFP EFJLNJBKBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4631550", Offset = "0x4630350", VA = "0x184631550")]
	public void DGIEOJPLMLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4631310", Offset = "0x4630110", VA = "0x184631310")]
	[IteratorStateMachine(typeof(DJGHCGPPPEL))]
	public IEnumerable<Renderer> BCCIELKNHCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4631970", Offset = "0x4630770", VA = "0x184631970", Slot = "5")]
	public void KJEIKKKDNLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4632260", Offset = "0x4631060", VA = "0x184632260")]
	private void NIHIMCGEOCO(Vector3 NEHIFDOIBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4631380", Offset = "0x4630180", VA = "0x184631380")]
	public void CNIMBBBDAOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class IAMPBALMBLK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct OOMPDIGFDOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public OFGFGEDIPGM MJCKDHNILGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Transform HONNCODFJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int KGFLHDNLIDK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class OEKALLLBDAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public IAMPBALMBLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public DMMEFAOHKAI lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public List<OOMPDIGFDOG> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
		public OEKALLLBDAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class HKHDHJJDAIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public BPHOGJLMOEJ combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public OEKALLLBDAE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
		public HKHDHJJDAIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x46343F0", Offset = "0x46331F0", VA = "0x1846343F0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4634460", Offset = "0x4633260", VA = "0x184634460")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x46344A0", Offset = "0x46332A0", VA = "0x1846344A0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private int[] EMPBHJCDINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private BECMBNIGMIH NNMPGFNOCGO;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static Matrix4x4 GLGCFCBAGGJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Mesh OOAPAKOLCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4E91D0", Offset = "0x4E7FD0", VA = "0x1804E91D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4E9490", Offset = "0x4E8290", VA = "0x1804E9490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int CNGFLIDKNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x570BE0", Offset = "0x56F9E0", VA = "0x180570BE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5C8790", Offset = "0x5C7590", VA = "0x1805C8790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x46350C0", Offset = "0x4633EC0", VA = "0x1846350C0")]
	public void PFFEHAAIFMP(List<Transform> LAMDJPJMPKB, Matrix4x4[] EFJCIGPKIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4634B30", Offset = "0x4633930", VA = "0x184634B30")]
	public static List<IAMPBALMBLK> MEJCIEELJNL(List<PIKBJDPEGAO> HGCPNDKKCBM, DMMEFAOHKAI KPEFNKLAHLE, Bounds NLBALGBILIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x46347B0", Offset = "0x46335B0", VA = "0x1846347B0")]
	private JobHandle LOKEHELHMAP(BPHOGJLMOEJ HDDAIIPCLBM, int NGFOJHNCJGM, int EAAKFIPDOGE, DMMEFAOHKAI KPEFNKLAHLE, List<OOMPDIGFDOG> MEIPIHMJBDP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x46346B0", Offset = "0x46334B0", VA = "0x1846346B0")]
	private void KBIOEHJFLJC(List<OOMPDIGFDOG> MEIPIHMJBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4635400", Offset = "0x4634200", VA = "0x184635400")]
	private IAMPBALMBLK(List<OOMPDIGFDOG> MEIPIHMJBDP, int NGFOJHNCJGM, int EAAKFIPDOGE, DMMEFAOHKAI KPEFNKLAHLE, Bounds NLBALGBILIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4634630", Offset = "0x4633430", VA = "0x184634630", Slot = "4")]
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
		private MaterialPropertyBlock AHIHNEIICMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private IAMPBALMBLK LBIDBAEJDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private List<Transform> AKFHKLNDJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private RenderTexture IOHIGJDNPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private ComputeBuffer KPKLLLAHAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private ComputeShader HFFDCGPPGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Matrix4x4[] EOPPKEKNPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int AKIIFLNAMCA;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MeshRenderer KAMEDGCNAGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x4E94A0", Offset = "0x4E82A0", VA = "0x1804E94A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int EPPGINKLOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x463A790", Offset = "0x4639590", VA = "0x18463A790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4639CB0", Offset = "0x4638AB0", VA = "0x184639CB0")]
		public static List<SkinnedShapeRenderer> Create(GameObject ILMCIJGNPKB, List<IAMPBALMBLK> JHFHLNPNJOM, List<Transform> AKFHKLNDJGL, Material IIDNGJABNHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4639EC0", Offset = "0x4638CC0", VA = "0x184639EC0")]
		public void Init(IAMPBALMBLK LBIDBAEJDLB, List<Transform> AKFHKLNDJGL, Material IIDNGJABNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x463A3B0", Offset = "0x46391B0", VA = "0x18463A3B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x463A320", Offset = "0x4639120", VA = "0x18463A320")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x463A2E0", Offset = "0x46390E0", VA = "0x18463A2E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4639C20", Offset = "0x4638A20", VA = "0x184639C20")]
		private void AGNJCHDOGON(ScriptableRenderContext HIKLIFLDMDD, Camera[] GNIAKHGOMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x463A440", Offset = "0x4639240", VA = "0x18463A440")]
		private void PFFEHAAIFMP(CommandBuffer FIPKOINNBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xC67C20", Offset = "0xC66A20", VA = "0x180C67C20")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KBKCNEEIGLD
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static byte[] HKOBKFJLJAG;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static int ADAIBBEDLAL;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static int PDJAKEHAIFF;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static BigInteger NCCPNIBEFHO;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
	public KBKCNEEIGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x46378E0", Offset = "0x46366E0", VA = "0x1846378E0")]
	private static string PLNBGBJHHON(byte[] DPEJHFONKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x46375B0", Offset = "0x46363B0", VA = "0x1846375B0")]
	public static string GFPOJAMMFIA(byte[] EMAHDMOPMEP, bool FCMNFAHODMM)
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
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
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
