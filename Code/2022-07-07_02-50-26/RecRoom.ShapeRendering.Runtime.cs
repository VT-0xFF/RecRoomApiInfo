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
public enum NEPCPIMEFBL
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
public static class OONIMGFFCPO
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<NEPCPIMEFBL> OHCAINIABLN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x50B2F60", Offset = "0x50B2160", VA = "0x1850B2F60")]
	static OONIMGFFCPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x50B2F60", Offset = "0x50B2160", VA = "0x1850B2F60")]
	[HEGIKGGFNID]
	private static void INKIGOFOFOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x50B2EE0", Offset = "0x50B20E0", VA = "0x1850B2EE0")]
	public static bool AFIIKLGNCJN(this NEPCPIMEFBL GPMPKDMOMMA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IFFABHEDCFK
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
public enum DKNAFONGAED
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
public enum OMDMNOOEFIB
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
public enum FADHNFIBCOI
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
public class KKKHHKBHPBB : IPOLLILAOHE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private const byte GILHIPEFDIP = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private byte BGOMAOJJELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<SkinnedShapeRenderer>[] DPLENFHKBOO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ABCNFAJOPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x58ACD0", Offset = "0x589ED0", VA = "0x18058ACD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60BA10", Offset = "0x60AC10", VA = "0x18060BA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FEJDNIBPOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x58ACC0", Offset = "0x589EC0", VA = "0x18058ACC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E4EB0", Offset = "0x6E40B0", VA = "0x1806E4EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float MFFNNINEFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE136D0", Offset = "0xE128D0", VA = "0x180E136D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE136F0", Offset = "0xE128F0", VA = "0x180E136F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float DGFCJPKJJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE13990", Offset = "0xE12B90", VA = "0x180E13990", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE13690", Offset = "0xE12890", VA = "0x180E13690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> GAGGEOEIOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x50B16B0", Offset = "0x50B08B0", VA = "0x1850B16B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> IAEMAPKJLCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x42D4080", Offset = "0x42D3280", VA = "0x1842D4080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject FKEBKHEAMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5B2A30", Offset = "0x5B1C30", VA = "0x1805B2A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2580", Offset = "0x6C1780", VA = "0x1806C2580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte AKJCFFICPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x50B1750", Offset = "0x50B0950", VA = "0x1850B1750", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x50B17A0", Offset = "0x50B09A0", VA = "0x1850B17A0")]
	public KKKHHKBHPBB(List<EDFMOBMLKBI> PNJCKCFDFGB, List<EDFMOBMLKBI> AGBCJDNJGOM, List<Transform> FOGODFLCMPG, Material IFJGEGBFEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x50B14B0", Offset = "0x50B06B0", VA = "0x1850B14B0")]
	private int JMOLJGPOBAB(List<EDFMOBMLKBI> IKFOPDEGFMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x50B1220", Offset = "0x50B0420", VA = "0x1850B1220")]
	private void CJOFGBGDJGP(int NIAMGBLAOEM, bool AHHIIFACKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x50B15C0", Offset = "0x50B07C0", VA = "0x1850B15C0")]
	public void MEOLEBJODED(Vector3 MGENHDELLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50B1380", Offset = "0x50B0580", VA = "0x1850B1380", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x50B1710", Offset = "0x50B0910", VA = "0x1850B1710")]
	public void NACKJGLGEAN(Transform POJADLEMJJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DFMOCFBBICA : KGNFNGMAALG, FLKBEBPGKGM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BFNOHNOGHHG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DFMOCFBBICA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69B3E0", Offset = "0x69A5E0", VA = "0x18069B3E0")]
		[DebuggerHidden]
		public BFNOHNOGHHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x50AA030", Offset = "0x50A9230", VA = "0x1850AA030", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x50A9B80", Offset = "0x50A8D80", VA = "0x1850A9B80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x50AA1B0", Offset = "0x50A93B0", VA = "0x1850AA1B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x50AA1F0", Offset = "0x50A93F0", VA = "0x1850AA1F0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x50AA240", Offset = "0x50A9440", VA = "0x1850AA240")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x50A9FE0", Offset = "0x50A91E0", VA = "0x1850A9FE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x50A9F40", Offset = "0x50A9140", VA = "0x1850A9F40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x50A9F40", Offset = "0x50A9140", VA = "0x1850A9F40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class COAHCBJCDNC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DFMOCFBBICA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x69B3E0", Offset = "0x69A5E0", VA = "0x18069B3E0")]
		[DebuggerHidden]
		public COAHCBJCDNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x50AA9B0", Offset = "0x50A9BB0", VA = "0x1850AA9B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x50AA610", Offset = "0x50A9810", VA = "0x1850AA610", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x50AAAD0", Offset = "0x50A9CD0", VA = "0x1850AAAD0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x50AAB20", Offset = "0x50A9D20", VA = "0x1850AAB20")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x50AA960", Offset = "0x50A9B60", VA = "0x1850AA960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x50AA8C0", Offset = "0x50A9AC0", VA = "0x1850AA8C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x50AA8C0", Offset = "0x50A9AC0", VA = "0x1850AA8C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private JFJICIBGLMG MAIMOFMKIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<CMCFCEMGEPF> JJELDNFCHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<ClusterMeshRenderer> HGCJDPEFCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BatchedMeshRenderer BENHGHFMDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool BGDOMGBHDBE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<DGJNGOLEOOP> AKNLBEIGNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JLCJJLPHLJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x50AB670", Offset = "0x50AA870", VA = "0x1850AB670", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform OGGJJCDBDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x50AB4D0", Offset = "0x50AA6D0", VA = "0x1850AB4D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> LBHMGMBNGKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x58B010", Offset = "0x58A210", VA = "0x18058B010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x58B020", Offset = "0x58A220", VA = "0x18058B020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x50ABD10", Offset = "0x50AAF10", VA = "0x1850ABD10")]
	public DFMOCFBBICA(JFJICIBGLMG GPKKCJEFIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x50AB3B0", Offset = "0x50AA5B0", VA = "0x1850AB3B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50AB3E0", Offset = "0x50AA5E0", VA = "0x1850AB3E0")]
	public void FKEGKEHNDJG(CMCFCEMGEPF INILILBGIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x50AB200", Offset = "0x50AA400", VA = "0x1850AB200")]
	public void CDCPBPNLMGM(CMCFCEMGEPF INILILBGIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x50AAB60", Offset = "0x50A9D60", VA = "0x1850AAB60", Slot = "4")]
	public void BGCCCLGMBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x50AB150", Offset = "0x50AA350", VA = "0x1850AB150")]
	public void BLLHJLKIHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x50AB520", Offset = "0x50AA720", VA = "0x1850AB520")]
	private void KILMAAEFMKH(CMCFCEMGEPF INILILBGIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x50AB790", Offset = "0x50AA990", VA = "0x1850AB790")]
	public void OMHDIKMMDCA(bool EKLFCPBLAMN, bool PCELFCBGKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x50AB270", Offset = "0x50AA470", VA = "0x1850AB270")]
	protected void COEDKFCLDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x50AB720", Offset = "0x50AA920", VA = "0x1850AB720")]
	[IteratorStateMachine(typeof(BFNOHNOGHHG))]
	public IEnumerable<Renderer> OLFMBHLFHDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x50AB6B0", Offset = "0x50AA8B0", VA = "0x1850AB6B0")]
	[IteratorStateMachine(typeof(COAHCBJCDNC))]
	public IEnumerable<Renderer> MDAJFALHFBI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class AGFDEELAGKK : CMCFCEMGEPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private NJMLGJECHMD JFJAGNCCCED;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x50A9A60", Offset = "0x50A8C60", VA = "0x1850A9A60")]
	private NativeList<PDGOKHEBIBK> OCDGMJEODCI()
	{
		return default(NativeList<PDGOKHEBIBK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x50A9B30", Offset = "0x50A8D30", VA = "0x1850A9B30")]
	public AGFDEELAGKK(DFMOCFBBICA EEOPLFIHJMP, NJMLGJECHMD GPKKCJEFIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x50A9840", Offset = "0x50A8A40", VA = "0x1850A9840", Slot = "13")]
	public override int JMOLJGPOBAB(PBLEBGNGJLE AANPEADJFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x50A90F0", Offset = "0x50A82F0", VA = "0x1850A90F0", Slot = "14")]
	public override int ALGBKFFKCHF(PBLEBGNGJLE AANPEADJFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x50A9310", Offset = "0x50A8510", VA = "0x1850A9310", Slot = "15")]
	public override void BDPHHLLLCLJ(PBLEBGNGJLE AANPEADJFEH, MLIGOIFAFLC KMFDNNABODK, int KCKFFAFEEBE = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct FJCBEFPNBIL : global::EMFMIACAOHB<FJCBEFPNBIL>, ABPBGICCMKA, IEquatable<FJCBEFPNBIL>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int AJKNHICCIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x849200", Offset = "0x848400", VA = "0x180849200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C37C0", Offset = "0x8C29C0", VA = "0x1808C37C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DEHBMHFAMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8491E0", Offset = "0x8483E0", VA = "0x1808491E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x89CFD0", Offset = "0x89C1D0", VA = "0x18089CFD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x42C49B0", Offset = "0x42C3BB0", VA = "0x1842C49B0", Slot = "8")]
	public bool Equals(FJCBEFPNBIL MKCNOIKIBCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x50AE830", Offset = "0x50ADA30", VA = "0x1850AE830")]
	public static bool OOPNKNBDLCB(FJCBEFPNBIL DFDBDIGAGLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum GHGIFLCHNPK
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
public interface JFJICIBGLMG
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform BOPOGOLEIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GHGIFLCHNPK BDAKBBDDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BKCFACONHGE : global::EMFMIACAOHB<BKCFACONHGE>, ABPBGICCMKA, IEquatable<BKCFACONHGE>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int AJKNHICCIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x849200", Offset = "0x848400", VA = "0x180849200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8C37C0", Offset = "0x8C29C0", VA = "0x1808C37C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int DEHBMHFAMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8491E0", Offset = "0x8483E0", VA = "0x1808491E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x89CFD0", Offset = "0x89C1D0", VA = "0x18089CFD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x42C49B0", Offset = "0x42C3BB0", VA = "0x1842C49B0", Slot = "8")]
	public bool Equals(BKCFACONHGE MKCNOIKIBCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x50AA4D0", Offset = "0x50A96D0", VA = "0x1850AA4D0")]
	public static bool OOPNKNBDLCB(BKCFACONHGE DFDBDIGAGLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ODCEDLPDLAK
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform BOPOGOLEIJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float LEFJBMBDJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 INCPDMLDENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	NEPCPIMEFBL GNIGCIOGAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	IFFABHEDCFK FGJGBCBCCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PMNOPKIANAA : ODCEDLPDLAK
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	ACMKLALBKOI IKAHCDMMKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool HOAINFFHEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NJMLGJECHMD : ODCEDLPDLAK
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool NNOGDNPFGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool DBHLJGJJPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float KNHDFHGCAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int HGGIMJPJGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DBEKIEMGBEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<PDGOKHEBIBK> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BBADGFBBLMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLCOKBJDDLF(BKCFACONHGE INILILBGIIG, OMDMNOOEFIB KMGGGDGIBNM);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLCOKBJDDLF(FJCBEFPNBIL EEOPLFIHJMP, OMDMNOOEFIB KMGGGDGIBNM);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJPBCDKMCFP(FJCBEFPNBIL EEOPLFIHJMP);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJPBCDKMCFP(BKCFACONHGE INILILBGIIG);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GGGECLPLGLP(FJCBEFPNBIL EEOPLFIHJMP, FADHNFIBCOI ALJEFDPBPKG);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AAMODMBOEGO(FJCBEFPNBIL EEOPLFIHJMP, Vector3 JCOKHBJFDAE, Vector3 AOPDFGDOIHC, Vector3 FDOANLLABML, float KOOEGFGPEMO, float HCIEDCHABBJ, IReadOnlyList<Camera> CCCCGIEAEOP, DKNAFONGAED BKKBENCHMDJ);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AAMODMBOEGO(OKLGFPIMPLA PILPOMBGDCD, Vector3 JCOKHBJFDAE, Vector3 AOPDFGDOIHC, Vector3 FDOANLLABML, float KOOEGFGPEMO, float HCIEDCHABBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JBBJMFFGLMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FJCBEFPNBIL MGLFLLLLMKA(JFJICIBGLMG GPKKCJEFIHI);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMMIENIBNMM(FJCBEFPNBIL EEOPLFIHJMP);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KNIACMGFGFA(FJCBEFPNBIL EEOPLFIHJMP);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BKCFACONHGE KCMBPIBOLHM(FJCBEFPNBIL EEOPLFIHJMP, PMNOPKIANAA GPKKCJEFIHI);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BKCFACONHGE JCOEBOMGAJB(FJCBEFPNBIL EEOPLFIHJMP, NJMLGJECHMD GPKKCJEFIHI);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LHIIPIBBIJP(BKCFACONHGE INILILBGIIG);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PLFAJEMGKAA(BKCFACONHGE INILILBGIIG);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OKLGFPIMPLA FGLPLOBPLBF(KDMMNAPJAJF GPKKCJEFIHI);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IOKDLBGLCLJ(OKLGFPIMPLA PILPOMBGDCD);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KIDAGODKMCE(OKLGFPIMPLA PILPOMBGDCD);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AINOOEILHOK JEBMPIFDPME(Transform CINJMMKBPOH, IEnumerable<BKCFACONHGE> JJELDNFCHBB, int DAOJAGKKNIG);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> DKFAFGAGJIN(FJCBEFPNBIL EEOPLFIHJMP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OKLGFPIMPLA : global::EMFMIACAOHB<OKLGFPIMPLA>, ABPBGICCMKA, IEquatable<OKLGFPIMPLA>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int AJKNHICCIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x849200", Offset = "0x848400", VA = "0x180849200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8C37C0", Offset = "0x8C29C0", VA = "0x1808C37C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int DEHBMHFAMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8491E0", Offset = "0x8483E0", VA = "0x1808491E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x89CFD0", Offset = "0x89C1D0", VA = "0x18089CFD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x42C49B0", Offset = "0x42C3BB0", VA = "0x1842C49B0", Slot = "8")]
	public bool Equals(OKLGFPIMPLA MKCNOIKIBCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x50B2CE0", Offset = "0x50B1EE0", VA = "0x1850B2CE0")]
	public static bool OOPNKNBDLCB(OKLGFPIMPLA DFDBDIGAGLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KDMMNAPJAJF
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int IJOJNGDNOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform DILIHIPPOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool OHIDFOJCCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FJCBEFPNBIL GetBone(int KMDPOACIOBM);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int KMDPOACIOBM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class DKHCOCPEDON : CMCFCEMGEPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public PMNOPKIANAA PEJBFMLBADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int[] AJDJBAOBFFP;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override EBPPBOFHNAF ILFLNHNOFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x50AC8B0", Offset = "0x50ABAB0", VA = "0x1850AC8B0", Slot = "12")]
		get
		{
			return default(EBPPBOFHNAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 MNPKGLCHGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x50AD470", Offset = "0x50AC670", VA = "0x1850AD470")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x50A9B30", Offset = "0x50A8D30", VA = "0x1850A9B30")]
	public DKHCOCPEDON(DFMOCFBBICA EEOPLFIHJMP, PMNOPKIANAA GPKKCJEFIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x50ACF70", Offset = "0x50AC170", VA = "0x1850ACF70", Slot = "11")]
	public override bool MCCJHMOEHPA(Transform EEOPLFIHJMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x50ACED0", Offset = "0x50AC0D0", VA = "0x1850ACED0", Slot = "13")]
	public override int JMOLJGPOBAB(PBLEBGNGJLE AANPEADJFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x50AC160", Offset = "0x50AB360", VA = "0x1850AC160", Slot = "14")]
	public override int ALGBKFFKCHF(PBLEBGNGJLE AANPEADJFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x50ACC50", Offset = "0x50ABE50", VA = "0x1850ACC50")]
	private int DHBHKBLFBAA(PBLEBGNGJLE AANPEADJFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x50AC200", Offset = "0x50AB400", VA = "0x1850AC200", Slot = "15")]
	public override void BDPHHLLLCLJ(PBLEBGNGJLE AANPEADJFEH, MLIGOIFAFLC KMFDNNABODK, int KCKFFAFEEBE = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BHLKPFDADJE
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKLPOCLGGII(FADHNFIBCOI ALJEFDPBPKG, Renderer GDDBKPIFNHM, int OEKKHJNNDCO);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECACBJCEEJM(Renderer GDDBKPIFNHM, DKNAFONGAED BKKBENCHMDJ, Vector3 JCOKHBJFDAE, Vector3 AOPDFGDOIHC, Vector3 FDOANLLABML, float KOOEGFGPEMO, float HCIEDCHABBJ, float ILKPJGJAIDA = -1f, [Optional] Color? HNBBMICLPEF, [Optional] IReadOnlyList<Camera> JIDCHMAFAMA);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMBMNPGDEIC(Renderer GDDBKPIFNHM, int OEKKHJNNDCO);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IPNCOBJCGFL();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCNJAPIJDPI(int CHCHIDNDHJD, OMDMNOOEFIB ALJEFDPBPKG, Renderer GDDBKPIFNHM, int OEKKHJNNDCO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PLEBBDKDPLA : BBADGFBBLMF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly BHLKPFDADJE FKHHCPLPFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly GLFIAPKINIG JLJFBGFKAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MeshRenderer AJDAOFMBOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private HBADIGHOEDD CNBDEPBKOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MeshRenderer IKJPGELBDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private HBADIGHOEDD CCGACEJGJNK;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x59D990", Offset = "0x59CB90", VA = "0x18059D990")]
	public PLEBBDKDPLA(BHLKPFDADJE OONNMEKLIOB, GLFIAPKINIG JLJFBGFKAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x50B3780", Offset = "0x50B2980", VA = "0x1850B3780", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x50B3E60", Offset = "0x50B3060", VA = "0x1850B3E60", Slot = "4")]
	public void LLCOKBJDDLF(BKCFACONHGE INILILBGIIG, OMDMNOOEFIB KMGGGDGIBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x50B40E0", Offset = "0x50B32E0", VA = "0x1850B40E0", Slot = "5")]
	public void LLCOKBJDDLF(FJCBEFPNBIL EEOPLFIHJMP, OMDMNOOEFIB KMGGGDGIBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x50B3A70", Offset = "0x50B2C70", VA = "0x1850B3A70", Slot = "6")]
	public void JJPBCDKMCFP(FJCBEFPNBIL EEOPLFIHJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x50B3C10", Offset = "0x50B2E10", VA = "0x1850B3C10", Slot = "7")]
	public void JJPBCDKMCFP(BKCFACONHGE INILILBGIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x50B38D0", Offset = "0x50B2AD0", VA = "0x1850B38D0", Slot = "8")]
	public void GGGECLPLGLP(FJCBEFPNBIL EEOPLFIHJMP, FADHNFIBCOI ALJEFDPBPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x50B3450", Offset = "0x50B2650", VA = "0x1850B3450", Slot = "9")]
	public void AAMODMBOEGO(FJCBEFPNBIL EEOPLFIHJMP, Vector3 JCOKHBJFDAE, Vector3 AOPDFGDOIHC, Vector3 FDOANLLABML, float KOOEGFGPEMO, float HCIEDCHABBJ, IReadOnlyList<Camera> CCCCGIEAEOP, DKNAFONGAED BKKBENCHMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x50B3080", Offset = "0x50B2280", VA = "0x1850B3080", Slot = "10")]
	public void AAMODMBOEGO(OKLGFPIMPLA PILPOMBGDCD, Vector3 JCOKHBJFDAE, Vector3 AOPDFGDOIHC, Vector3 FDOANLLABML, float KOOEGFGPEMO, float HCIEDCHABBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class CMCFCEMGEPF : LLBFEANFNCJ, DGJNGOLEOOP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected Bounds FLKABIIDELL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public DFMOCFBBICA FKEBKHEAMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x58A490", Offset = "0x589690", VA = "0x18058A490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds FAMJCOLHLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1853BD0", Offset = "0x1852DD0", VA = "0x181853BD0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual EBPPBOFHNAF ILFLNHNOFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x50AA510", Offset = "0x50A9710", VA = "0x1850AA510", Slot = "12")]
		get
		{
			return default(EBPPBOFHNAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x50AA5A0", Offset = "0x50A97A0", VA = "0x1850AA5A0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x58AEC0", Offset = "0x58A0C0", VA = "0x18058AEC0", Slot = "11")]
	public virtual bool MCCJHMOEHPA(Transform EEOPLFIHJMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int JMOLJGPOBAB(PBLEBGNGJLE AANPEADJFEH);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int ALGBKFFKCHF(PBLEBGNGJLE AANPEADJFEH);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void BDPHHLLLCLJ(PBLEBGNGJLE AANPEADJFEH, MLIGOIFAFLC KMFDNNABODK, int KCKFFAFEEBE = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	protected CMCFCEMGEPF()
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
		[Cpp2IlInjected.Address(RVA = "0x50B42B0", Offset = "0x50B34B0", VA = "0x1850B42B0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum ACMKLALBKOI
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
public static class IOBNEHBBPMP
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OLBONBFDMHP : IEnumerable<FJEENENKDDK>, IEnumerable, IEnumerator<FJEENENKDDK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private FJEENENKDDK <>2__current;

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
		private FJEENENKDDK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69B3E0", Offset = "0x69A5E0", VA = "0x18069B3E0")]
		[DebuggerHidden]
		public OLBONBFDMHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x50B2D20", Offset = "0x50B1F20", VA = "0x1850B2D20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x50B2E90", Offset = "0x50B2090", VA = "0x1850B2E90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x50B2E00", Offset = "0x50B2000", VA = "0x1850B2E00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FJEENENKDDK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x50B2E00", Offset = "0x50B2000", VA = "0x1850B2E00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int ENLOJAINHAJ = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static FJEENENKDDK[][] ICOKOCPAENC;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static PMOCHFAOJND GGFJDDNNKKJ;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static ShapeRendererConfig NECHFJEIEJF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader AGOGICMBAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x50AFD50", Offset = "0x50AEF50", VA = "0x1850AFD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer IIAOABFHCDG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x50B02D0", Offset = "0x50AF4D0", VA = "0x1850B02D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x50B06D0", Offset = "0x50AF8D0", VA = "0x1850B06D0")]
	public static Mesh NJOJIBLADJI(ACMKLALBKOI MHGDFKDNKEI, int AANPEADJFEH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x50B02C0", Offset = "0x50AF4C0", VA = "0x1850B02C0")]
	public static int LKANPDPFLKA(ACMKLALBKOI MHGDFKDNKEI, int AANPEADJFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x50B0340", Offset = "0x50AF540", VA = "0x1850B0340")]
	public static PMOCHFAOJND MDJIKCMDCPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x50AFCE0", Offset = "0x50AEEE0", VA = "0x1850AFCE0")]
	[IteratorStateMachine(typeof(OLBONBFDMHP))]
	private static IEnumerable<FJEENENKDDK> AAMFAHMPKAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x50AFF80", Offset = "0x50AF180", VA = "0x1850AFF80")]
	public static FJEENENKDDK KEHPCPLANMM(ACMKLALBKOI MHGDFKDNKEI, int AANPEADJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x50B0490", Offset = "0x50AF690", VA = "0x1850B0490")]
	public static bool NHKCFOHAOPH(this ACMKLALBKOI MHGDFKDNKEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x50AFDC0", Offset = "0x50AEFC0", VA = "0x1850AFDC0")]
	public static void CMPKAMBBMKC(ACMKLALBKOI MHGDFKDNKEI, float3 LMDAEBIIIJG, out JFGOJBDCONI DOJOHFNGCLJ, out float3 IPBIHHOAPOO, out float NCPJEDAKOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x50B0790", Offset = "0x50AF990", VA = "0x1850B0790")]
	public static void NKIMFMDHIIN(Vector3 LMDAEBIIIJG, ACMKLALBKOI MHGDFKDNKEI, out Vector3 IPBIHHOAPOO, out float NCPJEDAKOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x50AFD40", Offset = "0x50AEF40", VA = "0x1850AFD40")]
	[NOEEOAFKPPH(PDHPLIPHFDE.ExitingPlayMode, 0)]
	private static void AOAPJPOKFAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x50B04B0", Offset = "0x50AF6B0", VA = "0x1850B04B0")]
	[NOEEOAFKPPH(PDHPLIPHFDE.ExitingPlayMode, 0)]
	private static void NHKCKMMFAKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DCJDPJDNIJH
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool JBAFAGEGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material ODCBKMJDAFO();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material LFMLJCENKAE();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material KFCCAFAFHHI();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HFMGDCMPKKN(NEPCPIMEFBL OHPJAGHCDLI);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OCCHLGBBPLD(IFFABHEDCFK NKOIMIPLMGJ);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HHECKFELMOG(GameObject ANFJLMLDELH);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KNPMEMHEGGL(GameObject ANFJLMLDELH, bool MEPBFAIKBMM);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface GLFIAPKINIG
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	DFMOCFBBICA NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CMCFCEMGEPF NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HJNJAMBGIBF NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class MFGCMJEPPLN : JBBJMFFGLMO, IDisposable, GLFIAPKINIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::CIOGIJMFBGJ<FJCBEFPNBIL, DFMOCFBBICA> MJPMCKHGNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::CIOGIJMFBGJ<BKCFACONHGE, CMCFCEMGEPF> JJELDNFCHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly global::CIOGIJMFBGJ<OKLGFPIMPLA, HJNJAMBGIBF> HDKFBHIBLBH;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static DCJDPJDNIJH HIKNMGCJLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x50B2680", Offset = "0x50B1880", VA = "0x1850B2680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x50B2460", Offset = "0x50B1660", VA = "0x1850B2460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DFMOCFBBICA NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x50B1DF0", Offset = "0x50B0FF0", VA = "0x1850B1DF0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public CMCFCEMGEPF NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x50B1E50", Offset = "0x50B1050", VA = "0x1850B1E50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public HJNJAMBGIBF NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x50B1EB0", Offset = "0x50B10B0", VA = "0x1850B1EB0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x50B2870", Offset = "0x50B1A70", VA = "0x1850B2870")]
	public MFGCMJEPPLN(DCJDPJDNIJH OONNMEKLIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x50B1BF0", Offset = "0x50B0DF0", VA = "0x1850B1BF0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x50B2720", Offset = "0x50B1920", VA = "0x1850B2720", Slot = "4")]
	public FJCBEFPNBIL MGLFLLLLMKA(JFJICIBGLMG GPKKCJEFIHI)
	{
		return default(FJCBEFPNBIL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x50B1AD0", Offset = "0x50B0CD0", VA = "0x1850B1AD0", Slot = "5")]
	public void BMMIENIBNMM(FJCBEFPNBIL EEOPLFIHJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x50B2610", Offset = "0x50B1810", VA = "0x1850B2610", Slot = "6")]
	public void KNIACMGFGFA(FJCBEFPNBIL EEOPLFIHJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x50B1B30", Offset = "0x50B0D30", VA = "0x1850B1B30", Slot = "15")]
	public IEnumerable<Renderer> DKFAFGAGJIN(FJCBEFPNBIL EEOPLFIHJMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x50B24B0", Offset = "0x50B16B0", VA = "0x1850B24B0", Slot = "7")]
	public BKCFACONHGE KCMBPIBOLHM(FJCBEFPNBIL EEOPLFIHJMP, PMNOPKIANAA GPKKCJEFIHI)
	{
		return default(BKCFACONHGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x50B1F70", Offset = "0x50B1170", VA = "0x1850B1F70", Slot = "8")]
	public BKCFACONHGE JCOEBOMGAJB(FJCBEFPNBIL EEOPLFIHJMP, NJMLGJECHMD GPKKCJEFIHI)
	{
		return default(BKCFACONHGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x50B2800", Offset = "0x50B1A00", VA = "0x1850B2800", Slot = "10")]
	public void PLFAJEMGKAA(BKCFACONHGE INILILBGIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x50B26C0", Offset = "0x50B18C0", VA = "0x1850B26C0", Slot = "9")]
	public void LHIIPIBBIJP(BKCFACONHGE INILILBGIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x50B1C60", Offset = "0x50B0E60", VA = "0x1850B1C60", Slot = "11")]
	public OKLGFPIMPLA FGLPLOBPLBF(KDMMNAPJAJF GPKKCJEFIHI)
	{
		return default(OKLGFPIMPLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x50B25A0", Offset = "0x50B17A0", VA = "0x1850B25A0", Slot = "13")]
	public void KIDAGODKMCE(OKLGFPIMPLA PILPOMBGDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x50B1F10", Offset = "0x50B1110", VA = "0x1850B1F10", Slot = "12")]
	public void IOKDLBGLCLJ(OKLGFPIMPLA PILPOMBGDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x50B2060", Offset = "0x50B1260", VA = "0x1850B2060", Slot = "14")]
	public AINOOEILHOK JEBMPIFDPME(Transform CINJMMKBPOH, IEnumerable<BKCFACONHGE> JJELDNFCHBB, int DAOJAGKKNIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class HJNJAMBGIBF : KGNFNGMAALG
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class DGJOLJMODKN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HJNJAMBGIBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x69B3E0", Offset = "0x69A5E0", VA = "0x18069B3E0")]
		[DebuggerHidden]
		public DGJOLJMODKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x50AC080", Offset = "0x50AB280", VA = "0x1850AC080", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x50ABDA0", Offset = "0x50AAFA0", VA = "0x1850ABDA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x50AC120", Offset = "0x50AB320", VA = "0x1850AC120")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x50AC030", Offset = "0x50AB230", VA = "0x1850AC030", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x50ABF90", Offset = "0x50AB190", VA = "0x1850ABF90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x50ABF90", Offset = "0x50AB190", VA = "0x1850ABF90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly KDMMNAPJAJF CJHHMBAHBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly GLFIAPKINIG JLJFBGFKAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private KKKHHKBHPBB CHODNGBFJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<EDFMOBMLKBI> HHEJKMFOFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<EDFMOBMLKBI> MLPFKBANEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GameObject FPFDFLIDFAJ;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x50AFA10", Offset = "0x50AEC10", VA = "0x1850AFA10")]
	public static HJNJAMBGIBF NEIJFMFNGOK(KDMMNAPJAJF GPKKCJEFIHI, GLFIAPKINIG JLJFBGFKAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x50AFBE0", Offset = "0x50AEDE0", VA = "0x1850AFBE0")]
	private HJNJAMBGIBF(KDMMNAPJAJF GPKKCJEFIHI, GLFIAPKINIG JLJFBGFKAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x50AF490", Offset = "0x50AE690", VA = "0x1850AF490")]
	public void HDNJGCNGFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x50AFB70", Offset = "0x50AED70", VA = "0x1850AFB70")]
	[IteratorStateMachine(typeof(DGJOLJMODKN))]
	public IEnumerable<Renderer> OLFMBHLFHDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x50AE870", Offset = "0x50ADA70", VA = "0x1850AE870", Slot = "4")]
	public void BGCCCLGMBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x50AF9E0", Offset = "0x50AEBE0", VA = "0x1850AF9E0")]
	private void KJJEDPCFGID(Vector3 MGENHDELLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x50AF2C0", Offset = "0x50AE4C0", VA = "0x1850AF2C0")]
	public void BLLHJLKIHHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EDFMOBMLKBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct KMDPCFLLNAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public MLIGOIFAFLC NDELGBAAJAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform FEIDAHLOEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int JFPNHLCIOLE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class NNDKCMEDOJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public EDFMOBMLKBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public PBLEBGNGJLE lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<KMDPCFLLNAH> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public NNDKCMEDOJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class BGDPOCFJJFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AINOOEILHOK combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public NNDKCMEDOJP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public BGDPOCFJJFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x50AA290", Offset = "0x50A9490", VA = "0x1850AA290")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x50AA300", Offset = "0x50A9500", VA = "0x1850AA300")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x50AA340", Offset = "0x50A9540", VA = "0x1850AA340")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int[] IHDPFHDEDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private MBGNCEFJJMK EDOGEPLJMCP;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static Matrix4x4 DPEABMGFCOD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh NOFGMLIGJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x58A490", Offset = "0x589690", VA = "0x18058A490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int GILHFJNAKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x616670", Offset = "0x615870", VA = "0x180616670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6DC610", Offset = "0x6DB810", VA = "0x1806DC610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x50AD7D0", Offset = "0x50AC9D0", VA = "0x1850AD7D0")]
	public void LDKGKCHDPCM(List<Transform> DHNGPMDOPLC, Matrix4x4[] JLLJEEBIAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x50AD9D0", Offset = "0x50ACBD0", VA = "0x1850AD9D0")]
	public static List<EDFMOBMLKBI> MFDAKPCHIOJ(List<DFMOCFBBICA> IAPFNINCKPJ, PBLEBGNGJLE AANPEADJFEH, Bounds BONGFHPONPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x50ADF30", Offset = "0x50AD130", VA = "0x1850ADF30")]
	private JobHandle PMIGJCBMCLL(AINOOEILHOK EOCHLIOPHOH, int CJFFGOIFLLD, int DLKHAKLBCHN, PBLEBGNGJLE AANPEADJFEH, List<KMDPCFLLNAH> OHAELEHLCGL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x50AD650", Offset = "0x50AC850", VA = "0x1850AD650")]
	private void CJJFNMCLGHI(List<KMDPCFLLNAH> OHAELEHLCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x50AE480", Offset = "0x50AD680", VA = "0x1850AE480")]
	private EDFMOBMLKBI(List<KMDPCFLLNAH> OHAELEHLCGL, int CJFFGOIFLLD, int DLKHAKLBCHN, PBLEBGNGJLE AANPEADJFEH, Bounds BONGFHPONPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x50AD750", Offset = "0x50AC950", VA = "0x1850AD750", Slot = "4")]
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
		private MaterialPropertyBlock CPHEGDEIOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private EDFMOBMLKBI KFPLOEFPOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<Transform> FOGODFLCMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private RenderTexture KPOIOJBFBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeBuffer LPBILEOOBNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ComputeShader JDOIENAGFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Matrix4x4[] CBJJINHEHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int OJDNDHFEMKD;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer ACEEDEAADLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x58A4A0", Offset = "0x5896A0", VA = "0x18058A4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int IJOJNGDNOBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x50B4E50", Offset = "0x50B4050", VA = "0x1850B4E50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x50B42E0", Offset = "0x50B34E0", VA = "0x1850B42E0")]
		public static List<SkinnedShapeRenderer> Create(GameObject EEOPLFIHJMP, List<EDFMOBMLKBI> IKFOPDEGFMG, List<Transform> FOGODFLCMPG, Material IFJGEGBFEDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x50B4580", Offset = "0x50B3780", VA = "0x1850B4580")]
		public void Init(EDFMOBMLKBI KFPLOEFPOGB, List<Transform> FOGODFLCMPG, Material IFJGEGBFEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x50B4DC0", Offset = "0x50B3FC0", VA = "0x1850B4DC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x50B4D30", Offset = "0x50B3F30", VA = "0x1850B4D30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x50B4CF0", Offset = "0x50B3EF0", VA = "0x1850B4CF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x50B44F0", Offset = "0x50B36F0", VA = "0x1850B44F0")]
		private void IIOPCJJFIBB(ScriptableRenderContext FFACCLDEOCL, Camera[] NEIPFGHFHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x50B49A0", Offset = "0x50B3BA0", VA = "0x1850B49A0")]
		private void LDKGKCHDPCM(CommandBuffer ADOMCIPONHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xDD9CF0", Offset = "0xDD8EF0", VA = "0x180DD9CF0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JABMDOENCKP
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static byte[] CDGDAHNLLDM;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int FDPMPGKGLAJ;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int LAEDHJMCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static BigInteger CJEJEKHBKEN;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public JABMDOENCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x50B0F60", Offset = "0x50B0160", VA = "0x1850B0F60")]
	private static string DMHFLPDODAP(byte[] DLFOEJDCAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x50B0C30", Offset = "0x50AFE30", VA = "0x1850B0C30")]
	public static string AJIDJKNPAKB(byte[] NGIBJOEMFPL, bool MFLHBEHGGNL)
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
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
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
