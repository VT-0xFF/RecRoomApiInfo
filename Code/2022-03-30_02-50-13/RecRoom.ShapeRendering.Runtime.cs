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
public enum PCCANOKPHGF
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
public enum AENBAKEDHJM
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
public enum DPCKEIIGBOL
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
public enum HBHGMACKFFN
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
public enum DEMEDGAMDIE
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
public class CMALPIDONDC : IGDJNEFBHIA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private const byte FJIIDBHBMPG = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private byte NDFMNJBAPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly List<SkinnedShapeRenderer>[] MAEPAJMOEFI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CPDKPKAIIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x520CD0", Offset = "0x51F2D0", VA = "0x180520CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x54C3A0", Offset = "0x54A9A0", VA = "0x18054C3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GIOAEJBPEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x520CC0", Offset = "0x51F2C0", VA = "0x180520CC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x603010", Offset = "0x601610", VA = "0x180603010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float GANOHEMHPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB05F80", Offset = "0xB04580", VA = "0x180B05F80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1021F50", Offset = "0x1020550", VA = "0x181021F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float BPOJKHMMNAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA20", Offset = "0xA7D020", VA = "0x180A7EA20", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xABD160", Offset = "0xABB760", VA = "0x180ABD160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> EHJNDNFLHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4A2C7C0", Offset = "0x4A2ADC0", VA = "0x184A2C7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GameObject JLJGCJNJJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x54C380", Offset = "0x54A980", VA = "0x18054C380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E0570", Offset = "0x5DEB70", VA = "0x1805E0570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public byte MIOKGNAMFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4A2C820", Offset = "0x4A2AE20", VA = "0x184A2C820", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A2C980", Offset = "0x4A2AF80", VA = "0x184A2C980")]
	public CMALPIDONDC(List<HGBDFOGNIDF> LGCJLJBCDKN, List<HGBDFOGNIDF> AJMBNFAIOAI, List<Transform> PABECNLEFEK, Material GIFGGOJOEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A2C870", Offset = "0x4A2AE70", VA = "0x184A2C870")]
	private int PGJLJNJMLKB(List<HGBDFOGNIDF> OGNHIFANJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4A2C4A0", Offset = "0x4A2AAA0", VA = "0x184A2C4A0")]
	private void ABFIBJHBIGJ(int FMBCNCGEOOF, bool LFLACNGENBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4A2C600", Offset = "0x4A2AC00", VA = "0x184A2C600")]
	public void BMFHHBKPBAL(Vector3 EENLFCPFHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4A2C6F0", Offset = "0x4A2ACF0", VA = "0x184A2C6F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4A2C780", Offset = "0x4A2AD80", VA = "0x184A2C780")]
	public void GFBIIKJODPC(Transform AJLCPDGIDMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HGDEPOGOOGP : DPLBJALAIHO, ADIHLDKDOKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GGAKPHMGPNF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HGDEPOGOOGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5DBEE0", Offset = "0x5DA4E0", VA = "0x1805DBEE0")]
		[DebuggerHidden]
		public GGAKPHMGPNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4A2EF10", Offset = "0x4A2D510", VA = "0x184A2EF10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4A2EA60", Offset = "0x4A2D060", VA = "0x184A2EA60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4A2F090", Offset = "0x4A2D690", VA = "0x184A2F090")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4A2F0D0", Offset = "0x4A2D6D0", VA = "0x184A2F0D0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4A2F120", Offset = "0x4A2D720", VA = "0x184A2F120")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4A2EEC0", Offset = "0x4A2D4C0", VA = "0x184A2EEC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4A2EE20", Offset = "0x4A2D420", VA = "0x184A2EE20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4A2EE20", Offset = "0x4A2D420", VA = "0x184A2EE20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private FKDHLNPNHAO JGCBGCJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private List<BEHMHJPBNJE> ABCJBDOMNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private List<ClusterMeshRenderer> CHHILDALOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private BatchedMeshRenderer LFGDPACCBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool JKBKIOEEFGK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IEnumerable<EOJDPKDJPOM> DAANDMNHMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int PKMCCEGIOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4A312B0", Offset = "0x4A2F8B0", VA = "0x184A312B0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform HFEMOAPLLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4A306F0", Offset = "0x4A2ECF0", VA = "0x184A306F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4A312F0", Offset = "0x4A2F8F0", VA = "0x184A312F0")]
	public HGDEPOGOOGP(FKDHLNPNHAO KEJFCMNCPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4A305C0", Offset = "0x4A2EBC0", VA = "0x184A305C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4A30740", Offset = "0x4A2ED40", VA = "0x184A30740")]
	public void KNBMMGKPMNM(BEHMHJPBNJE DNJCPJAKDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4A31240", Offset = "0x4A2F840", VA = "0x184A31240")]
	public void OKJFIGBMPNL(BEHMHJPBNJE DNJCPJAKDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4A30CF0", Offset = "0x4A2F2F0", VA = "0x184A30CF0", Slot = "4")]
	public void LKOJDAOLAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4A305F0", Offset = "0x4A2EBF0", VA = "0x184A305F0")]
	public void ELGGEIDNLDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4A30330", Offset = "0x4A2E930", VA = "0x184A30330")]
	private void AIEJJMAEDKA(BEHMHJPBNJE DNJCPJAKDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A30810", Offset = "0x4A2EE10", VA = "0x184A30810")]
	public void LBFHOBIHKHE(bool GOLEEPEGKMJ, bool CMGAJNFOFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4A30480", Offset = "0x4A2EA80", VA = "0x184A30480")]
	protected void CMCIFBHFPOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4A30680", Offset = "0x4A2EC80", VA = "0x184A30680")]
	[IteratorStateMachine(typeof(GGAKPHMGPNF))]
	public IEnumerable<Renderer> JKENDNOIBAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class KCBMBFCOJGL : BEHMHJPBNJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private HMJLBBPLKKF BCBLHAMGKPE;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4A32730", Offset = "0x4A30D30", VA = "0x184A32730")]
	private NativeList<INFIMAALHHB> KMAPHIJEEOI()
	{
		return default(NativeList<INFIMAALHHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4A2C450", Offset = "0x4A2AA50", VA = "0x184A2C450")]
	public KCBMBFCOJGL(HGDEPOGOOGP LKGACHNFEHO, HMJLBBPLKKF KEJFCMNCPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4A32D30", Offset = "0x4A31330", VA = "0x184A32D30", Slot = "13")]
	public override int PGJLJNJMLKB(EJDOKGPECCP HPMCIOMIFLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4A32510", Offset = "0x4A30B10", VA = "0x184A32510", Slot = "14")]
	public override int IGNJNFJJKMP(EJDOKGPECCP HPMCIOMIFLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4A32800", Offset = "0x4A30E00", VA = "0x184A32800", Slot = "15")]
	public override void NFFDEFEBGDJ(EJDOKGPECCP HPMCIOMIFLO, PGMFCEPEFHN BNDCBPIMNIM, int CGAOLPOFHLB = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PPGJIEDBCNE : global::NMBDKBPBKJH<PPGJIEDBCNE>, FBPDNPPGGEH, IEquatable<PPGJIEDBCNE>
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int NFBJLKNIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D20", Offset = "0x6B5320", VA = "0x1806B6D20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x71A8B0", Offset = "0x718EB0", VA = "0x18071A8B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DLLCIKOMAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D00", Offset = "0x6B5300", VA = "0x1806B6D00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x70AB90", Offset = "0x709190", VA = "0x18070AB90", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3C27160", Offset = "0x3C25760", VA = "0x183C27160", Slot = "8")]
	public bool Equals(PPGJIEDBCNE OKCILNENDLC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4A351B0", Offset = "0x4A337B0", VA = "0x184A351B0")]
	public static bool MBDBDKGNMOG(PPGJIEDBCNE BPMOBDFOFGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum JFPNIOKBMAI
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FKDHLNPNHAO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform KLMCHDOAKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	JFPNIOKBMAI HNDOLCANDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct AEPILOJNFPN : global::NMBDKBPBKJH<AEPILOJNFPN>, FBPDNPPGGEH, IEquatable<AEPILOJNFPN>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NFBJLKNIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D20", Offset = "0x6B5320", VA = "0x1806B6D20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x71A8B0", Offset = "0x718EB0", VA = "0x18071A8B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DLLCIKOMAKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D00", Offset = "0x6B5300", VA = "0x1806B6D00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x70AB90", Offset = "0x709190", VA = "0x18070AB90", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3C27160", Offset = "0x3C25760", VA = "0x183C27160", Slot = "8")]
	public bool Equals(AEPILOJNFPN OKCILNENDLC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4A2AE60", Offset = "0x4A29460", VA = "0x184A2AE60")]
	public static bool MBDBDKGNMOG(AEPILOJNFPN BPMOBDFOFGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IBEFNGAELAO
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform KLMCHDOAKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float CLIDEELBDOF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Vector3 HJNFBPCDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	PCCANOKPHGF DJNOIDCGOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	AENBAKEDHJM BMJFMGBGELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NOCBLLPLFCD : IBEFNGAELAO
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	CGHNFDCEOAM MFCFADAIBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LDMBALACDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HMJLBBPLKKF : IBEFNGAELAO
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool FDKODJJCOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool BLFEFDIIOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	float NNOBPGAFEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int MMAFDFEDJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool DPHOCKFEIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<INFIMAALHHB> KMAPHIJEEOI();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PEOAJDENIFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGNFEDJFCMD(AEPILOJNFPN DNJCPJAKDBL, HBHGMACKFFN HAMAKHCPAHB);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGNFEDJFCMD(PPGJIEDBCNE LKGACHNFEHO, HBHGMACKFFN HAMAKHCPAHB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGJPHBBFNCP(PPGJIEDBCNE LKGACHNFEHO);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DGJPHBBFNCP(AEPILOJNFPN DNJCPJAKDBL);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJJECOPHDGE(PPGJIEDBCNE LKGACHNFEHO, DEMEDGAMDIE IPLFCJCEGLD);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JOABHNOJDDF(PPGJIEDBCNE LKGACHNFEHO, Vector3 MEOHENNMCGE, Vector3 OLJGEKNMEGD, Vector3 EGLHHEAMGLG, float HINGEDAKHAM, float JNFCLMKIFDH, IReadOnlyList<Camera> EAPMLEBFPJO, DPCKEIIGBOL OMHCINEHPKP);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JOABHNOJDDF(HCNCPMFEMLE HHFJKIFCFMC, Vector3 MEOHENNMCGE, Vector3 OLJGEKNMEGD, Vector3 EGLHHEAMGLG, float HINGEDAKHAM, float JNFCLMKIFDH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NNNMELCEINL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PPGJIEDBCNE EKBNJFGIAPF(FKDHLNPNHAO KEJFCMNCPAK);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLAGLCBMCJN(PPGJIEDBCNE LKGACHNFEHO);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELHELEJGKJP(PPGJIEDBCNE LKGACHNFEHO);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AEPILOJNFPN AMGCEKCDIKE(PPGJIEDBCNE LKGACHNFEHO, NOCBLLPLFCD KEJFCMNCPAK);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AEPILOJNFPN MCBACEMGAJJ(PPGJIEDBCNE LKGACHNFEHO, HMJLBBPLKKF KEJFCMNCPAK);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JBGCPNFJLFD(AEPILOJNFPN DNJCPJAKDBL);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PIKHBNAOCLE(AEPILOJNFPN DNJCPJAKDBL);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HCNCPMFEMLE KNEFANJCJDF(ICNGCCMFEBO KEJFCMNCPAK);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GPCOCGGFDKC(HCNCPMFEMLE HHFJKIFCFMC);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MIHBCNKGLKD(HCNCPMFEMLE HHFJKIFCFMC);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JAJOOMHGIEJ BFLCMNFIIFB(Transform JLOLIHJAGAP, IEnumerable<AEPILOJNFPN> ABCJBDOMNPJ, int MCJIIFKDMHN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> LMBCNDENNCC(PPGJIEDBCNE LKGACHNFEHO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HCNCPMFEMLE : global::NMBDKBPBKJH<HCNCPMFEMLE>, FBPDNPPGGEH, IEquatable<HCNCPMFEMLE>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int NFBJLKNIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D20", Offset = "0x6B5320", VA = "0x1806B6D20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x71A8B0", Offset = "0x718EB0", VA = "0x18071A8B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DLLCIKOMAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D00", Offset = "0x6B5300", VA = "0x1806B6D00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x70AB90", Offset = "0x709190", VA = "0x18070AB90", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3C27160", Offset = "0x3C25760", VA = "0x183C27160", Slot = "8")]
	public bool Equals(HCNCPMFEMLE OKCILNENDLC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4A2F170", Offset = "0x4A2D770", VA = "0x184A2F170")]
	public static bool MBDBDKGNMOG(HCNCPMFEMLE BPMOBDFOFGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ICNGCCMFEBO
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int MCNDJIOIFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform IGJOOCEFLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool OHOBFDAMNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PPGJIEDBCNE GetBone(int EMBNDJFKFNG);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int EMBNDJFKFNG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class CGMEAICDABL : BEHMHJPBNJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public NOCBLLPLFCD LGCPKAKFDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int[] HOLEONGEFNO;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public override OOMPAIAHFMI PNBHKOLMFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4A2AFA0", Offset = "0x4A295A0", VA = "0x184A2AFA0", Slot = "12")]
		get
		{
			return default(OOMPAIAHFMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Vector3 DJHHGGPEBFF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4A2B8E0", Offset = "0x4A29EE0", VA = "0x184A2B8E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4A2C450", Offset = "0x4A2AA50", VA = "0x184A2C450")]
	public CGMEAICDABL(HGDEPOGOOGP LKGACHNFEHO, NOCBLLPLFCD KEJFCMNCPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4A2B3E0", Offset = "0x4A299E0", VA = "0x184A2B3E0", Slot = "11")]
	public override bool IOALIIALJOH(Transform LKGACHNFEHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4A2C170", Offset = "0x4A2A770", VA = "0x184A2C170", Slot = "13")]
	public override int PGJLJNJMLKB(EJDOKGPECCP HPMCIOMIFLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4A2B340", Offset = "0x4A29940", VA = "0x184A2B340", Slot = "14")]
	public override int IGNJNFJJKMP(EJDOKGPECCP HPMCIOMIFLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4A2C210", Offset = "0x4A2A810", VA = "0x184A2C210")]
	private int PMDOOCBGAMI(EJDOKGPECCP HPMCIOMIFLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4A2BAC0", Offset = "0x4A2A0C0", VA = "0x184A2BAC0", Slot = "15")]
	public override void NFFDEFEBGDJ(EJDOKGPECCP HPMCIOMIFLO, PGMFCEPEFHN BNDCBPIMNIM, int CGAOLPOFHLB = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JANENHHMMCN
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOIPDPMHLGM(DEMEDGAMDIE IPLFCJCEGLD, Renderer AMMFOMNLPIH, int CKDGJLHDIKB);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEPMGMJADNP(Renderer AMMFOMNLPIH, DPCKEIIGBOL OMHCINEHPKP, Vector3 MEOHENNMCGE, Vector3 OLJGEKNMEGD, Vector3 EGLHHEAMGLG, float HINGEDAKHAM, float JNFCLMKIFDH, float JKEPOKBNOBP = -1f, [Optional] Color? DFDOBLLNNLC, [Optional] IReadOnlyList<Camera> MLINOMMEMDF);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADMJKHAIKJN(Renderer AMMFOMNLPIH, int CKDGJLHDIKB);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MPONDNOAPIK();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DFADPAIIGMN(int JIFLOAIOIFG, HBHGMACKFFN IPLFCJCEGLD, Renderer AMMFOMNLPIH, int CKDGJLHDIKB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ENBJCIOMBMG : PEOAJDENIFB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly JANENHHMMCN LCBBCKHJCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly DFELEIDDHJE GBMABMNCDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private MeshRenderer CDKNBLLLHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private LIGHHAHHOFA CLINLMBFGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private MeshRenderer KJGANEIBMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private LIGHHAHHOFA FNBBIGLALLK;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x533990", Offset = "0x531F90", VA = "0x180533990")]
	public ENBJCIOMBMG(JANENHHMMCN DMEHIKJCAPD, DFELEIDDHJE GBMABMNCDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4A2D620", Offset = "0x4A2BC20", VA = "0x184A2D620", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E1E0", Offset = "0x4A2C7E0", VA = "0x184A2E1E0", Slot = "4")]
	public void NGNFEDJFCMD(AEPILOJNFPN DNJCPJAKDBL, HBHGMACKFFN HAMAKHCPAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E010", Offset = "0x4A2C610", VA = "0x184A2E010", Slot = "5")]
	public void NGNFEDJFCMD(PPGJIEDBCNE LKGACHNFEHO, HBHGMACKFFN HAMAKHCPAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4A2D480", Offset = "0x4A2BA80", VA = "0x184A2D480", Slot = "6")]
	public void DGJPHBBFNCP(PPGJIEDBCNE LKGACHNFEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4A2D230", Offset = "0x4A2B830", VA = "0x184A2D230", Slot = "7")]
	public void DGJPHBBFNCP(AEPILOJNFPN DNJCPJAKDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4A2DE70", Offset = "0x4A2C470", VA = "0x184A2DE70", Slot = "8")]
	public void KJJECOPHDGE(PPGJIEDBCNE LKGACHNFEHO, DEMEDGAMDIE IPLFCJCEGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4A2DB40", Offset = "0x4A2C140", VA = "0x184A2DB40", Slot = "9")]
	public void JOABHNOJDDF(PPGJIEDBCNE LKGACHNFEHO, Vector3 MEOHENNMCGE, Vector3 OLJGEKNMEGD, Vector3 EGLHHEAMGLG, float HINGEDAKHAM, float JNFCLMKIFDH, IReadOnlyList<Camera> EAPMLEBFPJO, DPCKEIIGBOL OMHCINEHPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4A2D770", Offset = "0x4A2BD70", VA = "0x184A2D770", Slot = "10")]
	public void JOABHNOJDDF(HCNCPMFEMLE HHFJKIFCFMC, Vector3 MEOHENNMCGE, Vector3 OLJGEKNMEGD, Vector3 EGLHHEAMGLG, float HINGEDAKHAM, float JNFCLMKIFDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class BEHMHJPBNJE : NOGMKPHNPLB, EOJDPKDJPOM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	protected Bounds KIEPJJBHENG;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HGDEPOGOOGP JLJGCJNJJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x520490", Offset = "0x51EA90", VA = "0x180520490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Bounds NDGLKBLPIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xD69150", Offset = "0xD67750", VA = "0x180D69150", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public virtual OOMPAIAHFMI PNBHKOLMFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4A2AF10", Offset = "0x4A29510", VA = "0x184A2AF10", Slot = "12")]
		get
		{
			return default(OOMPAIAHFMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4A2AEA0", Offset = "0x4A294A0", VA = "0x184A2AEA0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x520EC0", Offset = "0x51F4C0", VA = "0x180520EC0", Slot = "11")]
	public virtual bool IOALIIALJOH(Transform LKGACHNFEHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int PGJLJNJMLKB(EJDOKGPECCP HPMCIOMIFLO);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int IGNJNFJJKMP(EJDOKGPECCP HPMCIOMIFLO);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void NFFDEFEBGDJ(EJDOKGPECCP HPMCIOMIFLO, PGMFCEPEFHN BNDCBPIMNIM, int CGAOLPOFHLB = -1);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
	protected BEHMHJPBNJE()
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
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4A351F0", Offset = "0x4A337F0", VA = "0x184A351F0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum CGHNFDCEOAM
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KEEPPNHAMMN
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class OFJFFBLLIPI : IEnumerable<JDJCHMOMHPJ>, IEnumerable, IEnumerator<JDJCHMOMHPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private JDJCHMOMHPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private JDJCHMOMHPJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5DBEE0", Offset = "0x5DA4E0", VA = "0x1805DBEE0")]
		[DebuggerHidden]
		public OFJFFBLLIPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4A34FF0", Offset = "0x4A335F0", VA = "0x184A34FF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4A35160", Offset = "0x4A33760", VA = "0x184A35160", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4A350D0", Offset = "0x4A336D0", VA = "0x184A350D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JDJCHMOMHPJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4A350D0", Offset = "0x4A336D0", VA = "0x184A350D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int IHPMGJHKKEJ = 3;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static JDJCHMOMHPJ[][] IBIFNNEMMMF;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static KKNDFGNKFFC KCEHBAMABOP;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static ShapeRendererConfig KMFIDIMGINH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static ComputeShader JPJHIDBNGDP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4A33DA0", Offset = "0x4A323A0", VA = "0x184A33DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static SkinnedShapeRenderer CEGKPNNLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4A33AE0", Offset = "0x4A320E0", VA = "0x184A33AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4A32F50", Offset = "0x4A31550", VA = "0x184A32F50")]
	public static Mesh BEDKNLEPCDP(CGHNFDCEOAM FPAPLPFMGGL, int HPMCIOMIFLO = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4A33E10", Offset = "0x4A32410", VA = "0x184A33E10")]
	public static int NAPFPONMHKI(CGHNFDCEOAM FPAPLPFMGGL, int HPMCIOMIFLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4A33770", Offset = "0x4A31D70", VA = "0x184A33770")]
	public static KKNDFGNKFFC DOAMICCACKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4A33D30", Offset = "0x4A32330", VA = "0x184A33D30")]
	[IteratorStateMachine(typeof(OFJFFBLLIPI))]
	private static IEnumerable<JDJCHMOMHPJ> KHEIAHCJDLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4A33430", Offset = "0x4A31A30", VA = "0x184A33430")]
	public static JDJCHMOMHPJ CEFCGEIGHNC(CGHNFDCEOAM FPAPLPFMGGL, int HPMCIOMIFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4A33D10", Offset = "0x4A32310", VA = "0x184A33D10")]
	public static bool HFAFEJKMLLI(this CGHNFDCEOAM FPAPLPFMGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4A33B50", Offset = "0x4A32150", VA = "0x184A33B50")]
	public static void FNHAELMKGLN(CGHNFDCEOAM FPAPLPFMGGL, float3 MGMIFGICHCA, out BCEBKJMDCPK EOIKAJFEEFB, out float3 PDAGNBGNKOJ, out float LDNIDOKKEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4A33010", Offset = "0x4A31610", VA = "0x184A33010")]
	public static void BNNBIEHGIAL(Vector3 MGMIFGICHCA, CGHNFDCEOAM FPAPLPFMGGL, out Vector3 PDAGNBGNKOJ, out float LDNIDOKKEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4A33D90", Offset = "0x4A32390", VA = "0x184A33D90")]
	[BFFCGBPBDIO(MHIIHFJKCKA.ExitingPlayMode, 0)]
	private static void KLBCHFGHJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4A338C0", Offset = "0x4A31EC0", VA = "0x184A338C0")]
	[BFFCGBPBDIO(MHIIHFJKCKA.ExitingPlayMode, 0)]
	private static void EEPFCIEIIBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CDEMIKCPBDF
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool CFOGCLIEMMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material GILKHBPLEMA();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material OLDCDDHHNLJ();

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material NDBKHMPIECH();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IHHMGIJDJCG(PCCANOKPHGF EJIPMPBEFKH);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int AAMKBOJFBIA(AENBAKEDHJM HPNPGGBOOOL);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HPKCIODGDLC(GameObject GPAMIINBFCH);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KKOJCMKEBCL(GameObject GPAMIINBFCH, bool OPGHKKAJEEP);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public interface DFELEIDDHJE
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HGDEPOGOOGP HOGHGDFMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	BEHMHJPBNJE HOGHGDFMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	MBOBAPNFELA HOGHGDFMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public class JKKEFNMAPFG : NNNMELCEINL, IDisposable, DFELEIDDHJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly global::IKAHPKIAKCL<PPGJIEDBCNE, HGDEPOGOOGP> MOLIEBKBAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly global::IKAHPKIAKCL<AEPILOJNFPN, BEHMHJPBNJE> ABCJBDOMNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly global::IKAHPKIAKCL<HCNCPMFEMLE, MBOBAPNFELA> JFHNNMDEOLO;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static CDEMIKCPBDF EJKEMMOEGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4A31F90", Offset = "0x4A30590", VA = "0x184A31F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4A31D20", Offset = "0x4A30320", VA = "0x184A31D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HGDEPOGOOGP HOGHGDFMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4A31440", Offset = "0x4A2FA40", VA = "0x184A31440", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public BEHMHJPBNJE HOGHGDFMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4A313E0", Offset = "0x4A2F9E0", VA = "0x184A313E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MBOBAPNFELA HOGHGDFMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4A31380", Offset = "0x4A2F980", VA = "0x184A31380", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4A320A0", Offset = "0x4A306A0", VA = "0x184A320A0")]
	public JKKEFNMAPFG(CDEMIKCPBDF DMEHIKJCAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4A31990", Offset = "0x4A2FF90", VA = "0x184A31990", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A31A00", Offset = "0x4A30000", VA = "0x184A31A00", Slot = "4")]
	public PPGJIEDBCNE EKBNJFGIAPF(FKDHLNPNHAO KEJFCMNCPAK)
	{
		return default(PPGJIEDBCNE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4A31FD0", Offset = "0x4A305D0", VA = "0x184A31FD0", Slot = "5")]
	public void OLAGLCBMCJN(PPGJIEDBCNE LKGACHNFEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4A31AE0", Offset = "0x4A300E0", VA = "0x184A31AE0", Slot = "6")]
	public void ELHELEJGKJP(PPGJIEDBCNE LKGACHNFEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4A31D70", Offset = "0x4A30370", VA = "0x184A31D70", Slot = "15")]
	public IEnumerable<Renderer> LMBCNDENNCC(PPGJIEDBCNE LKGACHNFEHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4A314A0", Offset = "0x4A2FAA0", VA = "0x184A314A0", Slot = "7")]
	public AEPILOJNFPN AMGCEKCDIKE(PPGJIEDBCNE LKGACHNFEHO, NOCBLLPLFCD KEJFCMNCPAK)
	{
		return default(AEPILOJNFPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4A31E30", Offset = "0x4A30430", VA = "0x184A31E30", Slot = "8")]
	public AEPILOJNFPN MCBACEMGAJJ(PPGJIEDBCNE LKGACHNFEHO, HMJLBBPLKKF KEJFCMNCPAK)
	{
		return default(AEPILOJNFPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4A32030", Offset = "0x4A30630", VA = "0x184A32030", Slot = "10")]
	public void PIKHBNAOCLE(AEPILOJNFPN DNJCPJAKDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4A31BB0", Offset = "0x4A301B0", VA = "0x184A31BB0", Slot = "9")]
	public void JBGCPNFJLFD(AEPILOJNFPN DNJCPJAKDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4A31C10", Offset = "0x4A30210", VA = "0x184A31C10", Slot = "11")]
	public HCNCPMFEMLE KNEFANJCJDF(ICNGCCMFEBO KEJFCMNCPAK)
	{
		return default(HCNCPMFEMLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4A31F20", Offset = "0x4A30520", VA = "0x184A31F20", Slot = "13")]
	public void MIHBCNKGLKD(HCNCPMFEMLE HHFJKIFCFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4A31B50", Offset = "0x4A30150", VA = "0x184A31B50", Slot = "12")]
	public void GPCOCGGFDKC(HCNCPMFEMLE HHFJKIFCFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4A31590", Offset = "0x4A2FB90", VA = "0x184A31590", Slot = "14")]
	public JAJOOMHGIEJ BFLCMNFIIFB(Transform JLOLIHJAGAP, IEnumerable<AEPILOJNFPN> ABCJBDOMNPJ, int MCJIIFKDMHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class MBOBAPNFELA : DPLBJALAIHO
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FOFFCAFHDOO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public MBOBAPNFELA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5DBEE0", Offset = "0x5DA4E0", VA = "0x1805DBEE0")]
		[DebuggerHidden]
		public FOFFCAFHDOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4A2E980", Offset = "0x4A2CF80", VA = "0x184A2E980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4A2E6A0", Offset = "0x4A2CCA0", VA = "0x184A2E6A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4A2EA20", Offset = "0x4A2D020", VA = "0x184A2EA20")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4A2E930", Offset = "0x4A2CF30", VA = "0x184A2E930", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4A2E890", Offset = "0x4A2CE90", VA = "0x184A2E890", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4A2E890", Offset = "0x4A2CE90", VA = "0x184A2E890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly ICNGCCMFEBO PJHMLIDGGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly DFELEIDDHJE GBMABMNCDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private CMALPIDONDC JPFMANGHJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private List<HGBDFOGNIDF> OKKJCPCLKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private List<HGBDFOGNIDF> LJFOFNGHCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private GameObject JMLFHPOBHBN;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4A34E80", Offset = "0x4A33480", VA = "0x184A34E80")]
	public static MBOBAPNFELA NENJIHHKBHA(ICNGCCMFEBO KEJFCMNCPAK, DFELEIDDHJE GBMABMNCDDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4A34F60", Offset = "0x4A33560", VA = "0x184A34F60")]
	private MBOBAPNFELA(ICNGCCMFEBO KEJFCMNCPAK, DFELEIDDHJE GBMABMNCDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A33EA0", Offset = "0x4A324A0", VA = "0x184A33EA0")]
	public void BOLNPHFANNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A344C0", Offset = "0x4A32AC0", VA = "0x184A344C0")]
	[IteratorStateMachine(typeof(FOFFCAFHDOO))]
	public IEnumerable<Renderer> JKENDNOIBAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4A34530", Offset = "0x4A32B30", VA = "0x184A34530", Slot = "4")]
	public void LKOJDAOLAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4A34490", Offset = "0x4A32A90", VA = "0x184A34490")]
	private void IOBEHCLKONG(Vector3 EENLFCPFHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4A342C0", Offset = "0x4A328C0", VA = "0x184A342C0")]
	public void ELGGEIDNLDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class HGBDFOGNIDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct ANJBALDMOII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public PGMFCEPEFHN JAMNKAJEPCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Transform IIANHNIGLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int IDEADOLEFKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class EBHCOPDKGPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public HGBDFOGNIDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public EJDOKGPECCP lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public List<ANJBALDMOII> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
		public EBHCOPDKGPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class FNMGANOBHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public JAJOOMHGIEJ combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public EBHCOPDKGPK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
		public FNMGANOBHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4A2E460", Offset = "0x4A2CA60", VA = "0x184A2E460")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4A2E4D0", Offset = "0x4A2CAD0", VA = "0x184A2E4D0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4A2E510", Offset = "0x4A2CB10", VA = "0x184A2E510")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private int[] DDKAPPIKJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private IIIGMJBIDON EPOBDKADGHL;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static Matrix4x4 OOLIDACJPLC;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Mesh KKPKLPFPIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x520490", Offset = "0x51EA90", VA = "0x180520490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int ILIHBDBGJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x557080", Offset = "0x555680", VA = "0x180557080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5FA740", Offset = "0x5F8D40", VA = "0x1805FA740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4A2FB40", Offset = "0x4A2E140", VA = "0x184A2FB40")]
	public void LIDNHIKCMNG(List<Transform> LMLBLFIGNFK, Matrix4x4[] NNBIOPEGION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4A2F530", Offset = "0x4A2DB30", VA = "0x184A2F530")]
	public static List<HGBDFOGNIDF> DBFOOEAJHCK(List<ADIHLDKDOKA> OCAHPOHNDAG, EJDOKGPECCP HPMCIOMIFLO, Bounds DDMIHMKBOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4A2F1B0", Offset = "0x4A2D7B0", VA = "0x184A2F1B0")]
	private JobHandle CCGNDFPJMPF(JAJOOMHGIEJ KCCPJJKDLIO, int LNLCAGBOLEC, int PCFHBFBFCHH, EJDOKGPECCP HPMCIOMIFLO, List<ANJBALDMOII> LFFABNHKNNB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4A2FD40", Offset = "0x4A2E340", VA = "0x184A2FD40")]
	private void OIIHCHNKFLL(List<ANJBALDMOII> LFFABNHKNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4A2FF80", Offset = "0x4A2E580", VA = "0x184A2FF80")]
	private HGBDFOGNIDF(List<ANJBALDMOII> LFFABNHKNNB, int LNLCAGBOLEC, int PCFHBFBFCHH, EJDOKGPECCP HPMCIOMIFLO, Bounds DDMIHMKBOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4A2FAC0", Offset = "0x4A2E0C0", VA = "0x184A2FAC0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private MaterialPropertyBlock BPAIJEEDDIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private HGBDFOGNIDF APPECPLMDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private List<Transform> PABECNLEFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private RenderTexture KCJNJBBPOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private ComputeBuffer CNEGFKECEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private ComputeShader MFECLIHCBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private Matrix4x4[] IJAMBEGNEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int BAJJFKPIOIF;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public MeshRenderer ANNPGMEGOPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x5204A0", Offset = "0x51EAA0", VA = "0x1805204A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int MCNDJIOIFCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x4A35D90", Offset = "0x4A34390", VA = "0x184A35D90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4A352B0", Offset = "0x4A338B0", VA = "0x184A352B0")]
		public static List<SkinnedShapeRenderer> Create(GameObject LKGACHNFEHO, List<HGBDFOGNIDF> OGNHIFANJOJ, List<Transform> PABECNLEFEK, Material GIFGGOJOEEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4A354C0", Offset = "0x4A33AC0", VA = "0x184A354C0")]
		public void Init(HGBDFOGNIDF APPECPLMDCP, List<Transform> PABECNLEFEK, Material GIFGGOJOEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4A35D00", Offset = "0x4A34300", VA = "0x184A35D00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4A35C70", Offset = "0x4A34270", VA = "0x184A35C70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4A35C30", Offset = "0x4A34230", VA = "0x184A35C30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4A35220", Offset = "0x4A33820", VA = "0x184A35220")]
		private void AJGLNGOHKKA(ScriptableRenderContext POJPEFNIBPF, Camera[] MENLDBPCACO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4A358E0", Offset = "0x4A33EE0", VA = "0x184A358E0")]
		private void LIDNHIKCMNG(CommandBuffer OEIJOIGHLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9E59B0", Offset = "0x9E3FB0", VA = "0x1809E59B0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class EEDIADJHOAL
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static byte[] GGHPKOFMNIO;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static int KCKCMMJGOCO;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static int BOFMOMDGGBC;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static BigInteger PJEPEPBBIPN;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
	public EEDIADJHOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4A2CF70", Offset = "0x4A2B570", VA = "0x184A2CF70")]
	private static string IAEECNCONGN(byte[] KFLJJIMMFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4A2CC40", Offset = "0x4A2B240", VA = "0x184A2CC40")]
	public static string AGDFJGHALKO(byte[] MOPADMGKCOG, bool CNBJECBCBOC)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
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
