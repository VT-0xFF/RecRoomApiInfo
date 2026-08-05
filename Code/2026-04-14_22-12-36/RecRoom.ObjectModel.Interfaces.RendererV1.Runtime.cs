using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.Mathematics;
using RecRoom.Foundation.Transforms;
using RecRoom.RendererV1.DataProviders;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum IgnoreEffectType
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Ghost = 0,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		GhostSkinned = 50,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		ShadowsOnly = 100,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		ShadowsOnlySkinned = 150,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Hide = 200
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum OutlineEffectType
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Hover,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Tutorial,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Teleport,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Menu,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		CircuitNode,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		ExtrusionHover,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		CornerMove,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		CornerMoveWarning,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Configure,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		NearbyContextual,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		HoverXRay,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		ContainerHover,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		PivotHover,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		DebugLocate,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		FrozenHover,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		ManipulateCollision
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum PrimitiveShapeMeshType
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		RR_Box,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		RR_Sphere,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		RR_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		RR_Wedge,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		RR_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		RR_HalfSphere,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		RR_Cone,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		RR_Pipe,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		RR_Donut,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		RR_HalfPipe,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		RR_Diamond,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		ADVANCED_Mound,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		LEGACY_Box,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		ADVANCED_Cube,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		ADVANCED_Sphere,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		ADVANCED_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		ADVANCED_Cone,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		ADVANCED_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		ADVANCED_Octagon,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		ADVANCED_Triangle,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		ADVANCED_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		ADVANCED_QuarterPipe,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		ADVANCED_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		ADVANCED_Dodecahedron,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		ADVANCED_Trihedron,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		ADVANCED_Octahedron,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		RR_QuarterCylinder,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		RR_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		RR_QuarterSphere,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		ADVANCED_Wedge,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		RR_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		RR_Octagon,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		RR_Triangle,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum RootFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Selected,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		SkinnedBone
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum SelectionEffectType
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Shape,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		CornerMove,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Container,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Pivot
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum ShapeColor
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		INVALID = -1,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		RRO_MIN_VALUE = 0,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		RED = 0,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		ORANGE = 1,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		YELLOW = 2,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		LIGHT_GREEN = 3,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		BLUE = 4,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		LIGHT_BLUE = 5,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		TEAL = 6,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		GREEN = 7,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		PURPLE = 8,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		LIGHT_PINK = 9,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		PINK = 10,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		BROWN = 11,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		TAN = 12,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		WHITE = 13,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		GREY = 14,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		DARK_GREY = 15,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		DARK_BROWN = 16,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		LIGHT_BROWN = 17,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		LIGHT_GREY = 18,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		BLACK = 19,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		DARK_RED = 20,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		DARK_ORANGE = 21,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		DARK_YELLOW = 22,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		DARK_GREEN = 23,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		DARK_TEAL = 24,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		DARK_BLUE = 25,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		DARK_PURPLE = 26,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		DARK_PINK = 27,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		LIGHT_RED = 28,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		LIGHT_ORANGE = 29,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		LIGHT_YELLOW = 30,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		CYAN = 31,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		LIGHT_PURPLE = 32,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		UNUSED_SEE_COMMENT = 33,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		NEW_COLOR_1 = 34,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		NEW_COLOR_2 = 35,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		NEW_COLOR_3 = 36,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		NEW_COLOR_4 = 37,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		NEW_COLOR_5 = 38,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		NEW_COLOR_6 = 39,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		NEW_COLOR_7 = 40,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		NEW_COLOR_8 = 41,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		NEW_COLOR_9 = 42,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		NEW_COLOR_10 = 43,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		NEW_COLOR_11 = 44,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		NEW_COLOR_12 = 45,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		NEW_COLOR_13 = 46,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		NEW_COLOR_14 = 47,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		NEW_COLOR_15 = 48,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		NEW_COLOR_16 = 49,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		NEW_COLOR_17 = 50,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		NEW_COLOR_18 = 51,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		NEW_COLOR_19 = 52,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		NEW_COLOR_20 = 53,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		NEW_COLOR_21 = 54,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		NEW_COLOR_22 = 55,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		NEW_COLOR_23 = 56,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		NEW_COLOR_24 = 57,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		NEW_COLOR_25 = 58,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		NEW_COLOR_26 = 59,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		NEW_COLOR_27 = 60,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		RRO_COLORS_COUNT = 61,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		RRO_MAX_VALUE = 60,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		GENERATED_MIN_VALUE = 1000,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		GENERATED_COLORS_BITS_PER_CHANNEL = 8,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		GENERATED_COLORS_COUNT = 16777216,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		GENERATED_MAX_VALUE = 16778215,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		LEGACY_GENERATED_COLORS_BITS_PER_CHANNEL = 4,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		LEGACY_GENERATED_COLORS_COUNT = 4096,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		GENERATED_TO_GPU_OFFSET = -939,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		MIN_VALUE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		MAX_VALUE = 16778215,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class FNHTFIFOZAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9A196E0", Offset = "0x9A182E0", VA = "0x189A196E0")]
		public static bool JVONRTPTZRG(this ShapeColor a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9A19700", Offset = "0x9A18300", VA = "0x189A19700")]
		public static bool OTVNPIIBFSU(this ShapeColor a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9A196B0", Offset = "0x9A182B0", VA = "0x189A196B0")]
		public static bool FGUNMYAAWSB(this ShapeColor a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum ShapeMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		INVALID = -1,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		CARDBOARD = 0,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		NEON = 1,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		BRICK = 2,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		CARPET = 3,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		DIRT = 4,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		GRASS = 5,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		METAL_REFLECTIVE = 6,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		CONCRETE = 7,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		LINOLEUM = 8,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		PLASTER = 9,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		WOOD_LOGS = 10,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		WOOD_BOARDS = 11,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		WOOD_GRAIN = 12,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		WOOD_FLOOR = 13,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		SAND = 14,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		GLOSSY_PLASTIC = 15,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		CLOTH = 16,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		RUBBER_FLOOR = 17,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		METAL_FLOOR_TREAD = 18,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		PAINTED_BRICK = 19,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		CRASHPAD = 20,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		PAINTED_WOOD = 21,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		GRIP_TAPE = 22,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		GALVANIZED_METAL = 23,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		PARTICLE_BOARD = 24,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		CHECKERED_FLOOR = 25,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		SPARKLY_VINYL = 26,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		GRAVEL = 27,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		ROCK = 28,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		WORN_WOOD = 29,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		PLACEHOLDER_17 = 30,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		PLACEHOLDER_18 = 31,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		MIN_VALUE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		MAX_VALUE = 31,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		COUNT = 32,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct RootHandle : QLTKPKJZZYR, IEquatable<RootHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		[CreateProperty]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[CreateProperty]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x30BE910", Offset = "0x30BD510", VA = "0x1830BE910", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x30BE920", Offset = "0x30BD520", VA = "0x1830BE920", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9A1ABD0", Offset = "0x9A197D0", VA = "0x189A1ABD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x142DAD0", Offset = "0x142C6D0", VA = "0x18142DAD0", Slot = "8")]
		public bool Equals(RootHandle other)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x97F06A0", Offset = "0x97EF2A0", VA = "0x1897F06A0")]
		public static bool IQJYWSDTJLC(RootHandle a, RootHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AAB0", Offset = "0x9A196B0", VA = "0x189A1AAB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AB50", Offset = "0x9A19750", VA = "0x189A1AB50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ShapeHandle : QLTKPKJZZYR, IEquatable<ShapeHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[CreateProperty]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		[CreateProperty]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x30BE910", Offset = "0x30BD510", VA = "0x1830BE910", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x30BE920", Offset = "0x30BD520", VA = "0x1830BE920", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9A1AD30", Offset = "0x9A19930", VA = "0x189A1AD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x142DAD0", Offset = "0x142C6D0", VA = "0x18142DAD0", Slot = "8")]
		public bool Equals(ShapeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AC10", Offset = "0x9A19810", VA = "0x189A1AC10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A1ACB0", Offset = "0x9A198B0", VA = "0x189A1ACB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SkinnedCostumeHandle : QLTKPKJZZYR, IEquatable<SkinnedCostumeHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x30BE910", Offset = "0x30BD510", VA = "0x1830BE910", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x30BE920", Offset = "0x30BD520", VA = "0x1830BE920", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9A1AE10", Offset = "0x9A19A10", VA = "0x189A1AE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x142DAD0", Offset = "0x142C6D0", VA = "0x18142DAD0", Slot = "8")]
		public bool Equals(SkinnedCostumeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AD70", Offset = "0x9A19970", VA = "0x189A1AD70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface CGMZJKGSGAM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SBMMPYOUFUW(RootHandle a, OutlineEffectType b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SBMMPYOUFUW(ShapeHandle a, OutlineEffectType b);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GPQVUVKKHJU(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IWSVVCHYSAA(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AVMSRAHBEQI();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SXWJJFNJMFW(OutlineEffectType a);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void FLCZPKMVMQT(RootHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void FLCZPKMVMQT(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void REXMUCTEHHA(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void KGDTPYEJNMM(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void KTVEJBJJKZC();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void CVEOBCKESSM();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void OOTCRLQTXZE(RootHandle a, SelectionEffectType b);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void BDUENISLUPM(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void SWAAZTRVNJK(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void PPWOMASTPPO();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void ZXJYEUPOKJW(SelectionEffectType a);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void YQZILCJSJME(RootHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f, IReadOnlyList<Camera> g, IgnoreEffectType h);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void YQZILCJSJME(SkinnedCostumeHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface ZINHPKXEDYG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool NQMIADYIXRH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RootHandle KLYJKVRGHYT(WUDEGVQXEMP a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RootHandle KLYJKVRGHYT(WUDEGVQXEMP a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CWZDPGRFEFW(RootHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JKIWDNRYGLD(RootHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ShapeHandle FZFZNMMPCMY(RootHandle a, YCZVDCDHUII b);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ShapeHandle XRWCDVCRBAG(RootHandle a, TUWPYUQVNOS b);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LHWILQFGPEZ(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void LGDWADOGDPQ(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SkinnedCostumeHandle FHJCYTNTQHU(HXRMYEJHMZX a);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void PHNNGETPWRQ(SkinnedCostumeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void TQTNZAWCJDB(SkinnedCostumeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task KHGJJGUBFDT();

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task VJVVOMJBSHJ();

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task VXVZCRLBIHE();

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void KTOABTNUOQN();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "16")]
		IEnumerable<Renderer> DZQJXSSNQQO(RootHandle a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class ZIYYYUKYOYS
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum ScalabilityCollapseMetricEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			Distance,
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			DistanceAttributes,
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			DistanceAttributesArea
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum ScalabilityShapeClassificationEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			AllNaughty,
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			NaughtyAndNice,
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			AllNice
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public enum ScalabilityDebugColourEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			ShowNoLods,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ActualError,
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			LodColour,
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			VertexFormatColour,
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			ContainerColour,
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			MaterialColour,
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			MeshColour,
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			BatchColour,
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			TriangleColour,
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			RefreshShapesBatchColour,
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			RefreshBatchedMeshColour
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public enum ScalabilityVertexOverrideEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			Disable_NormTanMatF16,
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			Disable_NormTanSn8MatF16,
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			Disable_NormTanSn8UvMatF16,
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			Disable_NormTanOct8MatUi,
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			Disable_PosFixedPoint16NormTanOct8MatUi,
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			Force_FullFloat32,
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			Force_NormTanMatF16,
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			Force_NormTanSn8MatF16,
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			Force_NormTanSn8UvMatF16,
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			Force_NormTanOct8MatUi,
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			Force_PosFixedPoint16NormTanOct8MatUi
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public enum ScalabilityRoomLoadingPhase
		{
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			StartOfLevelPlay,
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			LoadingStarted,
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			LoadingShapesFinished,
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			ShapeMeshesGenerated,
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			RunningGame
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum ScalabilityDynamicModeEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			TriCount,
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			FixedError,
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			FixedBudget,
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			CheckAtRoomLoad,
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			CheckPassive,
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			CheckOften,
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			SimulatedLimit
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public enum ScalabilityTessellationModeEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			Linear,
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			Sqrt
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public enum ScalabilityPresetsEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			GameConfigSetting = 0,
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			Off = 1,
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			FullDetail = 2,
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			Imperceptible = 3,
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			PC_High = 4,
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			PC_Mid = 5,
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			PC_Low = 6,
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			MajorStress = 7,
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			OutOfMemory = 8,
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			Mobile_High = 9,
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			Mobile_Mid = 10,
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			Mobile_Low = 11,
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			PS4 = 12,
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			PS5 = 13,
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			XboxOne = 14,
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			XboxSeries = 15,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			Switch1 = 16,
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			Quest2 = 17,
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			Quest3 = 18,
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			MemoryBuild = 19,
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			PS4VR = 20,
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			FourRoomsDemo = 100,
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			JustAvatarMeshLod = 101,
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			LowQualityHighSpeed = 102,
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			SpreadsheetSettings = 103
		}

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public static bool JLNVEFLRVSY;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static long OZQMNTMZYSF;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static bool BVWYFXGLCWK;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static bool YTFQJMPETEA;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static bool IHVAKNBKXTF;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static float JOGSHJLMPIU;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public static float TNUETCEKRZL;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static int ZUTFNEDXMXE;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static ScalabilityDynamicModeEnum XILGWOXHQHH;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static long ZFSCFJMQEMU;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public static float MVBMWUJIASQ;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public static int BHRNQXRBGYU;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static int JFBXIXNPSRJ;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public static int PIJBSQGMLET;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public static int UKNYJQNRHNP;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static int UIDTEJCQPFU;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static int WDWJNSJSDRP;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public static int BTWDUFCZNQN;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static int AXDLWIDSJGV;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static bool NBFOGJVQQIJ;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static int BPGSAEJCXRL;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static int TPMQFWMWXOM;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static int UGTHGTFTZOQ;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static bool NZRPPEUWNQP;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static float OAZSDIISTMG;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public static bool MXROUEAENBR;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public static float PCDHAWEVDCQ;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public static long WJWXWYYJGEV;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static bool GFONZSEUCDM;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static long QDUQICCBYXB;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static int OICKCCMJLWC;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public static bool DPJHGJCTERL;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public static ScalabilityCollapseMetricEnum CJHGGBARLZT;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public static bool OXIXQKECAWG;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public static bool GVYKAAGCWFS;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public static int HIJSAYDYQAU;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public static int OVLZXVKRTWG;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public static int MBKZQZXCURQ;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public static int PXOQWXSUGQR;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public static int TAAQXVPHXWB;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static int YEHHVVYGXXH;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public static int ZOQUNTBABCL;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static int UXUYSMUVTMA;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public static float SHEGLKHOVGN;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static float PRHHZAIEBQR;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public static float SAKVBZNPHWU;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public static float PYNBYMLXQFC;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public static int UDAHTNGKVPF;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static int WSTKUCQALUY;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static int YSFQLDICRYX;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public static int ULLODVBFLVJ;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public static bool JFHUWHFTFSQ;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public static ScalabilityDebugColourEnum IHDPEIURQDX;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static ScalabilityVertexOverrideEnum QWPTFADSCXC;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static bool UITGXOARFER;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static ScalabilityShapeClassificationEnum CALRFWUUXKR;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static float YVMYHSIYQBU;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public static float YQNTDCBSSVU;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public static float ZOJDHQSZJQQ;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static float XMUEZPQKXDT;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static float KHLAXNNLBUF;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static float WBFPDENKLJI;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static float HTYSKFPKQBF;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public static float PLIYMNHYYBK;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static bool NISNLRNVCCB;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static ScalabilityTessellationModeEnum PIZEFDPPRNP;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static bool SWURLLTHNZH;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static float TSUVFXVYUFJ;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static float DCSVBNUZOSW;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static float TBPTOTDSJZQ;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static float RGZLRQTFEGP;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static float LCDGZVDZMOX;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static bool AUUSWWONQWA;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static long DGSPZMZHLJJ;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static float RXCESSOQNMZ;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static float MFZSITPZZHF;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public static float UZUOKHAYTVN;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static int WWUFSFRLDWT;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static float WEWJFXGJSEJ;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static bool EZQRUMNRGLU;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static long HFCYGOKZGGB;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static int VUDMCDFYOVC;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static int BRZBBFXUOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static float VOGMTCPCXHX;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static float TXGOCWEJRZK;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static bool ZDKUGRYYIEH;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static bool WRDWGWASEVQ;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static float DDAFAYBRURR;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static long VOVCSRAAKKK;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static long QFUNOZVLHIX;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static int MLOAWJMPOVK;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static bool QCKADETHXOK;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static float EBKXMRDJXRI;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static float EDGCXAKKERH;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public static bool VRRSKIBJELQ;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static long TMNBTQVKKZD;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static int LCQSFJJDHMI;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static float4x4 FEJPBILIQHU;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static float3 XXHNVHLKNMA;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static bool MQFLOQIUCHH;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static ScalabilityRoomLoadingPhase LVHEWVKJZSI;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static long OBERGTBHJIQ;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static int CUJQGMGYWNL;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static int NLJQVPOIVCW;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static int IDASUUOWCIQ;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static int WSUOAHHRQVQ;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static int OGQJIWGQGGI;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static int JJUWWTLOLAX;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static int FACIABMBGZB;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static long YSQGVTKCDXO;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static int XGHXGRTFZBH;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static int SMDGFBJXVZN;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static int NPGMDSYFBWQ;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static long NLGSSRNRBLI;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static long ESVBDNIKCQU;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static long RZUEDGWKYKD;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static long NPDSTVLIDVT;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static int HKICENQTAJL;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static int LACTEPKWPZP;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static int AVTAMFRUCOQ;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static int ZNOHEZPMTLN;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static int QFKKHCZENHB;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static int[] UTDCWMNNBJK;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static int[] YZNULCMHORF;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static int LCDDZNJOTXM;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static long MVJCNYLUMKO;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static long JBUYVKJCSBW;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static int OBRQGUKQKMQ;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static int ZUIZVMIBVCL;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static long JZYBPDRZCGL;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static long MKUYIFLUWUJ;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static long ALKIUXBMOKM;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static long VCTYWDBUEOX;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static long HJFJNJMOWED;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static long VKENUDROTYH;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static long CEILPXUPOGB;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static long QPKOVBTHKBJ;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static long MBBYASYJZTY;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static float BBKMKKWNWAP;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static float ETPWTIVFNXT;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static long OQXOCJJVAJG;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static int KKOVUQTNAYD;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static long GBQIKGQCCPG;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static long QGTGEQYMOQJ;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static float OJAKXRMUTFT;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static long CIWYEQNEYWN;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static long HOHQKWLEGOK;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static long ZDMGVVBWZBQ;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static long NJUBYQJVUZE;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static long TJFUDZXXMNJ;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static long VDKAXRQZQOD;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static long LYJMMBONDKR;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static long ZBWBIJTDLAP;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static long RDWVMAKYWSK;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static long RQCQSNLGTRD;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static long RUUPFULKYNM;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static long WOAOHGCWMCO;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static ScalabilityPresetsEnum BFGGYHZAZYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9A1CA60", Offset = "0x9A1B660", VA = "0x189A1CA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static long HKJFLEOSYGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9A1CAC0", Offset = "0x9A1B6C0", VA = "0x189A1CAC0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C3B0", Offset = "0x9A1AFB0", VA = "0x189A1C3B0")]
		public static void KKRXXRLJINQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9A1B1E0", Offset = "0x9A19DE0", VA = "0x189A1B1E0")]
		public static void DCJVYPRPZOD(ScalabilityPresetsEnum a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class DTGEPFVBSMM
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private struct PointSrcData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public Vector3 Position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public Quaternion Rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public float Radius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public Quaternion BlendedRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public float BendAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public float BendRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public float DistanceToNext;
		}

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static List<PointSrcData> YASMGRYXIIZ;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9A190C0", Offset = "0x9A17CC0", VA = "0x189A190C0")]
		public static NativeList<CurvePointData> TBRDPPNTEWT(ILHFYBTISUH a)
		{
			return default(NativeList<CurvePointData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9A16600", Offset = "0x9A15200", VA = "0x189A16600")]
		private static bool DMNLFUGWFNA(int a, NativeList<CurvePointData> b, List<PointSrcData> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9A18970", Offset = "0x9A17570", VA = "0x189A18970")]
		private static CurvePointData GOWBTVKPBBB(int a, List<PointSrcData> b)
		{
			return default(CurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9A18BD0", Offset = "0x9A177D0", VA = "0x189A18BD0")]
		private static CurvePointData QGTNFAFUVWC(int a, List<PointSrcData> b)
		{
			return default(CurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9A18AF0", Offset = "0x9A176F0", VA = "0x189A18AF0")]
		private static CurvePointData MKYDPLSBSCL(Vector3 a, Quaternion b, float c)
		{
			return default(CurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9A174B0", Offset = "0x9A160B0", VA = "0x189A174B0")]
		public static NativeList<CurvePointData> FNVXLRAROPD(ILHFYBTISUH a, float b)
		{
			return default(NativeList<CurvePointData>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class OACPPCXNIRN
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public static Vector3 ESSEHLULBVC;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static Vector3 DAQNWSZRZKO;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public static readonly float QOEYKRQRIOI;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9A19A20", Offset = "0x9A18620", VA = "0x189A19A20")]
		public static Vector3 HASMNPWNQPE(Vector3 a, Quaternion b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A640", Offset = "0x9A19240", VA = "0x189A1A640")]
		public static Vector3 VWBQSCWJRYR(Quaternion a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9A19980", Offset = "0x9A18580", VA = "0x189A19980")]
		public static Vector3 EBATBZZFJZR(Quaternion a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A190", Offset = "0x9A18D90", VA = "0x189A1A190")]
		public static Quaternion SSZKZXZMHVJ(Vector3 a, Vector3 b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9A19790", Offset = "0x9A18390", VA = "0x189A19790")]
		public static Vector3 BLDVZUBNIWW(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A210", Offset = "0x9A18E10", VA = "0x189A1A210")]
		public static Vector3 TJQWIKUZXGQ(Vector3 a, Vector3 b, Quaternion c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9A19E30", Offset = "0x9A18A30", VA = "0x189A19E30")]
		public static Quaternion JIBTHYVGJLM(Quaternion a, Vector3 b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9A19CB0", Offset = "0x9A188B0", VA = "0x189A19CB0")]
		public static bool JGEVFYCWHPS(Vector3 a, Vector3 b, [Out] Vector3 c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A6E0", Offset = "0x9A192E0", VA = "0x189A1A6E0")]
		public static Vector3 XQIKHMDPCQR(bool a, [Optional] Quaternion b)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.RendererV1.Terrain
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct TerrainMaterialLayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public float heightCutoff;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public float effectiveHeightCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public float slopeCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public Color topColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public ShapeMaterial topMaterialInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public Color slopeColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public ShapeMaterial slopeMaterialInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct TerrainWaterProperties
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public bool waterEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public float waterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public float waterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public Color waterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public Color deepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public float emissiveStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public float alpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public TerrainWaterMaterial waterMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public WaterOverrides overrides;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class TerrainGenerationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public TerrainLayerRoughness baseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public float baseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public float baseTerrainScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public TerrainGenerationLayer[] additionalLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public TerrainMaterialLayer[] materialLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public bool normalizeLayerHeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public TerrainPlayAreaShape playArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public float playAreaOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public TerrainWaterProperties globalWaterProperties;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AE50", Offset = "0x9A19A50", VA = "0x189A1AE50")]
		public TerrainGenerationInfo()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct TerrainInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public float GroundHeight;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public enum TerrainPropertyMapPropertyType
	{
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		Height,
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		Strata,
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class NCNNCMHDUZQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public Vector2Int FUFLACEBJRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public float[] OQIWLEHREZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public TerrainPropertyMapPropertyType MGNXNPFUFWI;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9A19710", Offset = "0x9A18310", VA = "0x189A19710")]
		public NCNNCMHDUZQ(Vector2Int a, TerrainPropertyMapPropertyType b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class YSXJMXWGJQS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public float RDOJJZQGZTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public float SFFEEIXCOKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public TerrainMaterialLayer[] QTRDLXWDFAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int VVATPAGRROQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public NCNNCMHDUZQ[] NPTDARZGMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public float BFTIIVXCSSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public int OOBWSRIUDSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public int WWSGRYUETLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public float RHPNPHTHPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int ICJGSJENEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public float DEYOAYELRAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int OTUUUCYPJDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int ILQWISFXJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public float MWMQJQAKHSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public int JQREBNZIIAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int YGLCKYRRBPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int UGYLWOCHZZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public NCNNCMHDUZQ[] LTAIZHGZHZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public float XYEXIMFRNSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public int SZKGLGOEGFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int GELTJHZDIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int JZHVJKXDMQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public float DCZTFURPLCD;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AF90", Offset = "0x9A19B90", VA = "0x189A1AF90")]
		public YSXJMXWGJQS(Vector2Int a, Vector2Int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface DIVIHVIWHMB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		TerrainData BGJGNLAOGQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		GameObject JXYAQRIGJES
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Vector3 SLKZPTGQDEM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		float3 VMUZQQVDIXU
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		float3 VCCLCDCKSQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		TerrainGenerationInfo SEPQRQCGQWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		TerrainInfo AGGAMEBQOWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<bool> Generate(uint seed, bool randomize = true, bool spawnProps = true, bool animate = true, [Optional] TerrainGenerationInfo info, TerrainColorMode colorMode = TerrainColorMode.Default, [Optional] float3? spawnPosition, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Destroy(bool cleanupProps);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void UpdateMaterial(Action<Material> updateFunction);
	}
}
namespace RecRoom.RendererV1.DataProviders
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct CurvePointData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public float3x3 Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public float Radius;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface ILHFYBTISUH
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int VTOQGPWKBUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Vector3 HVDPJFLDYLH(int a);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Quaternion XRWEIASFMEA(int a);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		float GHVKSCFXWWE(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface TUWPYUQVNOS : EGSKEKMBXOM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool IPQBAZDNXSI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool SBAJEMJWSNO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float UVQLYSMCQLP
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		int YSCZYCLUVZR
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool VLURESVZGVV
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int ZIWYEOXAYLU
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		NativeArray<CurvePointData> GetNativeCurvePoints();
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface YCZVDCDHUII : EGSKEKMBXOM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		PrimitiveShapeMeshType ZSCESOZTSPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool XVNIIQJRSSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		float3 CDKIPYHKHMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface WUDEGVQXEMP
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		RRTransform IBGMOBEIUDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		RootFlags SBLRJXWBLOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "2")]
		void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface EGSKEKMBXOM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool NJAMPXRKUHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool MASLFZFVFGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		RRTransform IBGMOBEIUDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		UniformTRS MYEXBCJRIQU
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		float SVFPOYRRLZF
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 UKUIDNUTOUA
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		ShapeColor NMXBVNSYRRK
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		ShapeMaterial BVSEXEQMUGE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Hash128 ComputeHash();
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface HXRMYEJHMZX
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		int ICYIIVAIBSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Transform IJJHKCEEWTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool AVWSZGEIUQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RootHandle GetBone(int idx);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IsPartOfFirstPersonSkin(int idx);
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
