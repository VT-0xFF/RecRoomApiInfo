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
	public static class BENOEYCYYKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x99FD4E0", Offset = "0x99FC2E0", VA = "0x1899FD4E0")]
		public static bool DRMOIOOWLMV(this ShapeColor a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x99FD500", Offset = "0x99FC300", VA = "0x1899FD500")]
		public static bool RUSYLATZRHD(this ShapeColor a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x99FD510", Offset = "0x99FC310", VA = "0x1899FD510")]
		public static bool VUNQSBCGPDO(this ShapeColor a)
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
	public struct RootHandle : FNJCRVJCPDM, IEquatable<RootHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		[CreateProperty]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xF430D0", Offset = "0xF41ED0", VA = "0x180F430D0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x30B62E0", Offset = "0x30B50E0", VA = "0x1830B62E0", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x30B62F0", Offset = "0x30B50F0", VA = "0x1830B62F0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9A00710", Offset = "0x99FF510", VA = "0x189A00710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1424AD0", Offset = "0x14238D0", VA = "0x181424AD0", Slot = "8")]
		public bool Equals(RootHandle other)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x97D7BC0", Offset = "0x97D69C0", VA = "0x1897D7BC0")]
		public static bool ITVTPRNZGNV(RootHandle a, RootHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A00670", Offset = "0x99FF470", VA = "0x189A00670", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF430D0", Offset = "0xF41ED0", VA = "0x180F430D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9A00750", Offset = "0x99FF550", VA = "0x189A00750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ShapeHandle : FNJCRVJCPDM, IEquatable<ShapeHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[CreateProperty]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xF430D0", Offset = "0xF41ED0", VA = "0x180F430D0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x30B62E0", Offset = "0x30B50E0", VA = "0x1830B62E0", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x30B62F0", Offset = "0x30B50F0", VA = "0x1830B62F0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9A00870", Offset = "0x99FF670", VA = "0x189A00870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1424AD0", Offset = "0x14238D0", VA = "0x181424AD0", Slot = "8")]
		public bool Equals(ShapeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9A007D0", Offset = "0x99FF5D0", VA = "0x189A007D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF430D0", Offset = "0xF41ED0", VA = "0x180F430D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A008B0", Offset = "0x99FF6B0", VA = "0x189A008B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SkinnedCostumeHandle : FNJCRVJCPDM, IEquatable<SkinnedCostumeHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xF430D0", Offset = "0xF41ED0", VA = "0x180F430D0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x30B62E0", Offset = "0x30B50E0", VA = "0x1830B62E0", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x30B62F0", Offset = "0x30B50F0", VA = "0x1830B62F0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9A009D0", Offset = "0x99FF7D0", VA = "0x189A009D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1424AD0", Offset = "0x14238D0", VA = "0x181424AD0", Slot = "8")]
		public bool Equals(SkinnedCostumeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A00930", Offset = "0x99FF730", VA = "0x189A00930", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xF430D0", Offset = "0xF41ED0", VA = "0x180F430D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface UECLNUSSBAX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KBWUWPJHBMH(RootHandle a, OutlineEffectType b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KBWUWPJHBMH(ShapeHandle a, OutlineEffectType b);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NUJZNXGZCAB(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XDJTGUYXGSV(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DMGXGTQRPDX();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZVHROTHJFUF(OutlineEffectType a);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZYGWBRZULEG(RootHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void ZYGWBRZULEG(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void LVFVCOZZMGJ(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void QTRLFNHOVJX(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void SWLOGTRHCCF();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void ITTZMBDAYQF();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void LXWLBJCVLTB(RootHandle a, SelectionEffectType b);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void PPNOYWMGOQB(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void XNDTHJZMVBT(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void PDDARXEAQTT();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void MRGTRXHVRSB(SelectionEffectType a);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void HWEKXPHYMNN(RootHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f, IReadOnlyList<Camera> g, IgnoreEffectType h);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void HWEKXPHYMNN(SkinnedCostumeHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface BHNMHOQGZYJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool EGVNOCNLNRU
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RootHandle TDYGBHDSYCE(CGCJIYDJKJG a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RootHandle TDYGBHDSYCE(CGCJIYDJKJG a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PEAYHSAEDRL(RootHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TKQXXGUKMKM(RootHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ShapeHandle VMHZGZNZYQJ(RootHandle a, DCTACMKMUBX b);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ShapeHandle LBXUWQXQIPF(RootHandle a, DPZTBLGRSDV b);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void EBEHFKCMBOK(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void JWYTTELPWQN(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SkinnedCostumeHandle KGLFPHHZHKT(BYSVQDWALNE a);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void ELJOYMQZBLB(SkinnedCostumeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void WHDZEFBWOXM(SkinnedCostumeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task KLGPOANTOMA();

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task ZZAKSZGRECU();

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task CFOIZPZTWKV();

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void DONFOCCVTLK();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "16")]
		IEnumerable<Renderer> DCGGTDMDHGB(RootHandle a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class VOZUINYURPV
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
		public static bool NROVOMFFXFZ;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static long FSBYMIZPLOM;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static bool TQUBQIWQSBZ;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static bool LZHOWQYBKYF;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static bool HTKYYQFUAAQ;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static float USTNCZWRBZF;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public static float HDWIOHXUDLM;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static int FFPYOTSTNET;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static ScalabilityDynamicModeEnum LALIUSCCXWK;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static long UENTUBCGFVJ;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public static float SSKTRHYVHDP;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public static int SQQRWLZICXH;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static int LPNVENZHRPE;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public static int JEMPEXTAHCW;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public static int KKLAIHKWAMM;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static int BTLBHSLXTRZ;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static int IZMSSEQQFNG;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public static int TEJKBMQWIAY;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static int UEOINCCTAMY;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static bool YTAHPFJOITQ;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static int IHOBCPKWFGA;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static int STWLYKCYOPB;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static int BJZULTTTLCF;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static bool KNJEKATQGDG;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static float XTBAETMOJYR;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public static bool PLEDJGURAAU;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public static float NLIQEHHZVKZ;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public static long IDFCXUHBVUC;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static bool FNCTNMKYKCV;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static long OEAITLLMFTM;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static int HTAHQDOWAZZ;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public static bool JEZCDTNKECW;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public static ScalabilityCollapseMetricEnum VKQOWJWDHRW;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public static bool KNODTGWXPUF;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public static bool UIKXUMGSOKN;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public static int GLHLSTLPNUL;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public static int AUMWUPYNGPN;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public static int SIGJRRMSXVV;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public static int FREWHJKBCVC;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public static int LNHSYZUJZRU;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static int YEIGPZELNAE;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public static int TJDYCUMHQJC;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static int YXXVZHZKBWB;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public static float NYKNACZNFTG;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static float MYPZLXNILNM;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public static float UTOAMYZDLVF;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public static float OKIDSZGAMMJ;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public static int NHQOGKCBNAE;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static int VNCJVBIAFIZ;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static int JMPQVPEXPAO;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public static int WXRMNNXMNTQ;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public static bool LELRLDKKXNB;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public static ScalabilityDebugColourEnum ETIXUMTSOIO;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static ScalabilityVertexOverrideEnum VXXRPDMEGJT;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static bool AGJYTZJXUYQ;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static ScalabilityShapeClassificationEnum CZQBHWOOOYQ;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static float OKMRBGOEMSN;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public static float LVIBTVBWVFD;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public static float MMLGFEJWXMH;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static float DOMGRJCPKUI;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static float VUGMIAVCIFY;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static float HCYVIEQXOZH;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static float WWDSQUOGDTC;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public static float YPZSNOTHOPR;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static bool PJAMLEFDEVQ;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static ScalabilityTessellationModeEnum STTUGTMLZHK;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static bool DUQYKHZSBNS;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static float KLVWPIOLOTC;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static float EFCDLBRULUN;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static float AOAVRCSZUNZ;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static float FXCRIBYIXZO;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static float QWRBPJLHAQG;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static bool GZCWSBZWPKH;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static long MWWWYMFCEPW;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static float HRRLXGZOKLO;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static float TNXADHENOEO;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public static float EEQQPSYJOXQ;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static int LXHJTNLKHWC;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static float SBCJULKDVRQ;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static bool TBBCPCCUVVR;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static long TLBYCQLEXBG;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static int GMZXZZIFPVH;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static int IIZSXXAJNWG;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static float AFDSXCSESMM;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static float EXDNWIZFYMX;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static bool EBETJYJLKXG;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static bool FHIJGMNNYRP;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static float HEAKLXWHTOM;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static long BSMFLASSTLF;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static long PPDXCQDLYMC;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static int AZQXUWCFOET;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static bool VOUGQAZFSEJ;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static float WWDWSXZKCRL;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static float JQMLBCESHYC;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public static bool LMCTKCKBQSJ;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static long ZXFYAZIVDYS;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static int QIDWKEEBSTN;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static float4x4 VOWUHLHTPYV;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static float3 BGDXGHSGTNX;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static bool OJAMKWNQXRQ;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static ScalabilityRoomLoadingPhase ZXXYBKQUGYJ;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static long NXHSMUIYTYP;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static int CAZGNXGFULI;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static int YHIWLDDWHYH;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static int VVOWSCXXGDB;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static int YWBILNLXOUF;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static int UPXKYNLFIVD;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static int CDKNPSWZUSA;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static int NNLUIEIJFFM;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static long IMHARNUWWVD;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static int VSDNQCNGDDU;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static int KEQBCAZFKFS;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static int TCIAQJTDAWH;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static long IARIEUAVMFL;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static long OMQAFQAWTHH;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static long MLRCLEPITIW;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static long OLBPECFDHRA;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static int ZRUHPBHPHEE;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static int RPGOMYIUKOO;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static int KHPPLERQTQB;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static int BZVQQHXZNBK;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static int ZSWWJYLEXBQ;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static int[] MXENASILMPV;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static int[] GGHQNAFPGRO;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static int NOORFOCRRUP;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static long UIEMBVAYRMH;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static long WBWSTTFPOCJ;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static int DOKXSACBTSP;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static int MEKTSUDRTQU;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static long KWCKDCMCIUO;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static long UITRQRIBRCW;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static long BAHUQIGYVVT;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static long QMWFXILOXKI;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static long DIGQEQHEVSA;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static long SAMOYYMLARU;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static long CQQHOPRLDRQ;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static long XLSBOVIADFS;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static long SXYHVSUOCXX;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static float VSWEJFRWQSI;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static float XSXTGOAHINY;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static long XLWEUTDXOBL;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static int IORIZAYNZOU;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static long DBUKWVQQVQV;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static long JLZYWGNDYGY;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static float ZWNZBQPCDDS;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static long FQLSHYBFJVS;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static long HBGOXZVWGNL;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static long CQNCYFRIYQF;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static long PLRYIXDZWYL;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static long EKZWPASWEEO;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static long IGVVMIKMCTG;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static long HVVKFBAFIAU;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static long ZACSGQFLSJG;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static long ZRUWGLWMDKF;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static long WGKYTSLBKKO;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static long YNYGHJXHSDJ;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static long KBRNTCHNMBV;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static ScalabilityPresetsEnum HWJMCYQGEQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9A036F0", Offset = "0x9A024F0", VA = "0x189A036F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static long QAXWBPQTTLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9A03750", Offset = "0x9A02550", VA = "0x189A03750")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9A03040", Offset = "0x9A01E40", VA = "0x189A03040")]
		public static void OCTSCXZFWSJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9A01E70", Offset = "0x9A00C70", VA = "0x189A01E70")]
		public static void AAKFGPZUBCC(ScalabilityPresetsEnum a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class ITMELLDGWSH
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
		private static List<PointSrcData> NLGGEATCDUK;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x99FFB90", Offset = "0x99FE990", VA = "0x1899FFB90")]
		public static NativeList<CurvePointData> NKNOQNGHCWK(AZLKMPTKMDC a)
		{
			return default(NativeList<CurvePointData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x99FEA80", Offset = "0x99FD880", VA = "0x1899FEA80")]
		private static bool EFXWTWFXNSL(int a, NativeList<CurvePointData> b, List<PointSrcData> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x99FF930", Offset = "0x99FE730", VA = "0x1899FF930")]
		private static CurvePointData FCPMREQDDLS(int a, List<PointSrcData> b)
		{
			return default(CurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9A000F0", Offset = "0x99FEEF0", VA = "0x189A000F0")]
		private static CurvePointData VGJJWLZFDDN(int a, List<PointSrcData> b)
		{
			return default(CurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99FFAB0", Offset = "0x99FE8B0", VA = "0x1899FFAB0")]
		private static CurvePointData LHJQSYGDNJI(Vector3 a, Quaternion b, float c)
		{
			return default(CurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x99FD5C0", Offset = "0x99FC3C0", VA = "0x1899FD5C0")]
		public static NativeList<CurvePointData> ANZLZZWJVGK(AZLKMPTKMDC a, float b)
		{
			return default(NativeList<CurvePointData>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class UQAYKQHWXJO
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public static Vector3 SSEFFWMUGNJ;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static Vector3 ZBNSVHLVUAT;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public static readonly float THLGLJCUBIZ;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9A01860", Offset = "0x9A00660", VA = "0x189A01860")]
		public static Vector3 SSOZLVZTTHR(Vector3 a, Quaternion b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9A01CF0", Offset = "0x9A00AF0", VA = "0x189A01CF0")]
		public static Vector3 WEFOWFVCHXY(Quaternion a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9A017C0", Offset = "0x9A005C0", VA = "0x189A017C0")]
		public static Vector3 PAWJEXEVIFQ(Quaternion a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9A01AF0", Offset = "0x9A008F0", VA = "0x189A01AF0")]
		public static Quaternion SVMCNBIWFMY(Vector3 a, Vector3 b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9A00E40", Offset = "0x99FFC40", VA = "0x189A00E40")]
		public static Vector3 GKJZBPTRPIT(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9A01030", Offset = "0x99FFE30", VA = "0x189A01030")]
		public static Vector3 ICEQHILOSOB(Vector3 a, Vector3 b, Quaternion c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9A01460", Offset = "0x9A00260", VA = "0x189A01460")]
		public static Quaternion LOVCCOHRXOL(Quaternion a, Vector3 b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9A01B70", Offset = "0x9A00970", VA = "0x189A01B70")]
		public static bool SXZAYAHAXYH(Vector3 a, Vector3 b, [Out] Vector3 c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9A00B50", Offset = "0x99FF950", VA = "0x189A00B50")]
		public static Vector3 CASIBAUPLZA(bool a, [Optional] Quaternion b)
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
		[Cpp2IlInjected.Address(RVA = "0x9A00A10", Offset = "0x99FF810", VA = "0x189A00A10")]
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
	public class BMKQEJWBMLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public Vector2Int FJKBMMOXQGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public float[] QCPMWTQNNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public TerrainPropertyMapPropertyType XIFUWJIDDEF;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x99FD540", Offset = "0x99FC340", VA = "0x1899FD540")]
		public BMKQEJWBMLB(Vector2Int a, TerrainPropertyMapPropertyType b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class YWFYOFTICUJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public float EQQBRTKEGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public float DEKJSMIPWUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public TerrainMaterialLayer[] DLOSTHFYZLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int EDQQYOYFERF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public BMKQEJWBMLB[] VJAARFUHOSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public float DHQDCJMVSJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public int NNOFWWRRFTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public int IQEGLHCOSIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public float UMKWHEADZGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int DNCRRYPSFJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public float PZZGEWHLONK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int BPRXUHZSXWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int JSIECNPREMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public float OESREMGCZIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public int GKJAATTUPZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int ZCXXUTGAQXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int MBIQSPYTORO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public BMKQEJWBMLB[] TDSDUPFGVHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public float EHUSATHSQHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public int WLUKOKSKTHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int STFBIDNGLIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int DDFHSOCDIQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public float HHXWFSOCLYE;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9A044F0", Offset = "0x9A032F0", VA = "0x189A044F0")]
		public YWFYOFTICUJ(Vector2Int a, Vector2Int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface JZAURHYZOEG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		TerrainData GXVENXYJXVM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		GameObject YXWACJPARLH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Vector3 JADHDQZIPMH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		float3 BAWOWEMVTOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		float3 RCXRIUOASPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		TerrainGenerationInfo PUBPVFMXJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		TerrainInfo FOVFEESXLCC
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
	public interface AZLKMPTKMDC
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int PHKVXFMHLZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Vector3 GWQPQYUJYKE(int a);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Quaternion RQCKRCHURUB(int a);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		float VSWPMEUJIPD(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface DPZTBLGRSDV : BHVQPYAGNMJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool JYRNGPRCFXT
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool GSWFJWAUOKB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float BPBFHBWLTHE
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		int EOLIACYLULI
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool NNXOJDEQXZU
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int PZHDYKETOJT
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
	public interface DCTACMKMUBX : BHVQPYAGNMJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		PrimitiveShapeMeshType UPKKXHLGXQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool QCOBLKNKAMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		float3 JLVZVGOTOPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface CGCJIYDJKJG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		RRTransform WNFEIFLAAOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		RootFlags QLBZSADOREE
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "2")]
		void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface BHVQPYAGNMJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool JQSKDVJEUNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool BCRWTPCZTKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		RRTransform WNFEIFLAAOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		UniformTRS EOGMPLWUPZP
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		float GIMVRFFXQRS
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 BUPNMEXUVLP
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		ShapeColor SGBZWBNYVIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		ShapeMaterial EHIQLODQEFN
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
	public interface BYSVQDWALNE
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		int NNVPVLAQKVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Transform SVXKGVCJRPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool XFHFWRSZMOE
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
