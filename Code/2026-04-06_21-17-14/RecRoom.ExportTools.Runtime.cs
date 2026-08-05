using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.ProgressV2;
using RecRoom.Protobuf;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using SharpGLTF.Scenes;
using SharpGLTF.Schema2;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x99952C0", Offset = "0x99942C0", VA = "0x1899952C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ExportTools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct BevelConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public bool BevelSizeBasedOnLargestPossibleDimension;
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct ColorRGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly float R;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly float G;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly float B;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E9F0", Offset = "0x2B6D9F0", VA = "0x182B6E9F0")]
		public ColorRGB(float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class YZLTSXCXHCR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public string ALWALAWXEVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public MaterialColorUsage VFURDPAAQDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public ColorRGB QCPSMOLDSTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ColorRGB EFDXRQEPLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ColorRGB VUVDAJQVGYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public float DXIMRAMCTQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public LIZCZREWZCH? SUFDHVQSJSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public LIZCZREWZCH? KGJUTVYJXOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public LIZCZREWZCH? CXMQQKNREAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public LIZCZREWZCH? ZACFMUAOFSS;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x999B410", Offset = "0x999A410", VA = "0x18999B410")]
		public YZLTSXCXHCR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal readonly struct MaterialExportKey : IEquatable<MaterialExportKey>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly ShapeColor ShapeColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly ShapeMaterial ShapeMaterial;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
		public MaterialExportKey(ShapeColor shapeColor, ShapeMaterial shapeMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1434D00", Offset = "0x1433D00", VA = "0x181434D00", Slot = "4")]
		public bool Equals(MaterialExportKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9994D60", Offset = "0x9993D60", VA = "0x189994D60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9994DF0", Offset = "0x9993DF0", VA = "0x189994DF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal readonly struct MeshBuilderCacheKey : IEquatable<MeshBuilderCacheKey>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly PrimitiveShapeMeshType MeshType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly MaterialExportKey Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly float3 BevelScalingRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly float BevelAuthoredRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly float3 WorldScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly bool DynamicProjection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly float ContainerScaleX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly float UvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly float3 UvOffset;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9995250", Offset = "0x9994250", VA = "0x189995250")]
		public MeshBuilderCacheKey(PrimitiveShapeMeshType meshType, MaterialExportKey material, [Optional] float3 bevelScalingRatio, float bevelAuthoredRatio = 0f, [Optional] float3 worldScale, bool dynamicProjection = false, float containerScaleX = 0f, float uvScale = 0f, [Optional] float3 uvOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9994E60", Offset = "0x9993E60", VA = "0x189994E60", Slot = "4")]
		public bool Equals(MeshBuilderCacheKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9994FF0", Offset = "0x9993FF0", VA = "0x189994FF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99950B0", Offset = "0x99940B0", VA = "0x1899950B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class HEFXQWGYROP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public float3[] JSDECOZCYZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int[] MUTNACFCWWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public float3[] THVPKUTLFHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float2[]? UGPPSBEAKQK;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x112D620", Offset = "0x112C620", VA = "0x18112D620")]
		public HEFXQWGYROP(float3[] a, int[] b, float3[] c, [Optional] float2[]? uvs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class LIZCZREWZCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public string RFVYVCXEVKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public ImageBuilder? SMUGTKSNDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float2 HHSVCYRNGMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public float2 ZNEFDMSKVKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public TextureWrapMode DOOHDZVPPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TextureWrapMode DPEBVUDHRJP;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9994D10", Offset = "0x9993D10", VA = "0x189994D10")]
		public LIZCZREWZCH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum MaterialColorUsage
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		ALBEDO = 1,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		EMISSIVE = 2,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		SPECULAR = 4,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		HOLOGRAPHIC = 8
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum PrimitiveShapeMeshType
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		RR_Box,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		RR_Sphere,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		RR_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		RR_Wedge,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		RR_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		RR_HalfSphere,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		RR_Cone,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		RR_Pipe,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		RR_Donut,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		RR_HalfPipe,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		RR_Diamond,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		ADVANCED_Mound,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		LEGACY_Box,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		ADVANCED_Cube,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		ADVANCED_Sphere,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		ADVANCED_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		ADVANCED_Cone,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		ADVANCED_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		ADVANCED_Octagon,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		ADVANCED_Triangle,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		ADVANCED_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		ADVANCED_QuarterPipe,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		ADVANCED_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		ADVANCED_Dodecahedron,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		ADVANCED_Trihedron,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		ADVANCED_Octahedron,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		RR_QuarterCylinder,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		RR_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		RR_QuarterSphere,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		ADVANCED_Wedge,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		RR_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		RR_Octagon,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		RR_Triangle,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum ShapeColor
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		RED = 0,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		ORANGE = 1,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		YELLOW = 2,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		GREEN = 3,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		DARK_GREEN = 4,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		CYAN = 5,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		BLUE = 6,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		DARK_BLUE = 7,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		PURPLE = 8,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		PINK = 9,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		BROWN = 10,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		WHITE = 11,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		GREY = 12,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		BLACK = 13,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		DARK_ORANGE = 14,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		LIME = 15,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		LIGHT_GREEN = 16,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		AQUAMARINE = 17,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		LIGHT_BLUE = 18,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		LAVENDER = 19,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		MAGENTA = 20,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		SALMON = 21,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		TAN = 22,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		CREAM = 23,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		LIGHT_GREY = 24,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		DARK_GREY = 25,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		NEW_COLOR_0 = 26,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		NEW_COLOR_1 = 27,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		NEW_COLOR_2 = 28,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		NEW_COLOR_3 = 29,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		NEW_COLOR_4 = 30,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		NEW_COLOR_5 = 31,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		NEW_COLOR_6 = 32,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		UNUSED_SEE_COMMENT = 33,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		NEW_COLOR_7 = 34,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		NEW_COLOR_8 = 35,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		NEW_COLOR_9 = 36,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		NEW_COLOR_10 = 37,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		NEW_COLOR_11 = 38,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		NEW_COLOR_12 = 39,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		NEW_COLOR_13 = 40,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		NEW_COLOR_14 = 41,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		NEW_COLOR_15 = 42,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		NEW_COLOR_16 = 43,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		NEW_COLOR_17 = 44,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		NEW_COLOR_18 = 45,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		NEW_COLOR_19 = 46,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		NEW_COLOR_20 = 47,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		NEW_COLOR_21 = 48,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		NEW_COLOR_22 = 49,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		NEW_COLOR_23 = 50,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		NEW_COLOR_24 = 51,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		NEW_COLOR_25 = 52,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		NEW_COLOR_26 = 53,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		NEW_COLOR_27 = 54,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		NEW_COLOR_28 = 55,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		NEW_COLOR_29 = 56,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		NEW_COLOR_30 = 57,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		NEW_COLOR_31 = 58,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		NEW_COLOR_32 = 59,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		NEW_COLOR_33 = 60,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		GENERATED_COLOR_START = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum ShapeMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		INVALID = -1,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		CARDBOARD = 0,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		METAL = 1,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		RUBBER = 2,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		PLASTIC = 3,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		NEON = 4,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		WOOD = 5,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		GLASS = 6,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		ROCK = 7,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		ICE = 8,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		GOLD = 9,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		SAND = 10,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		LEATHER = 11,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		GRID = 12,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		TILE = 13,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		GRASS = 14,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		BARK = 15,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		CONCRETE = 16,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		SNOW = 17,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		CARPET = 18,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		FABRIC = 19,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		FOIL = 20,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		FLESH = 21,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		GALAXY = 22,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		LAVA = 23,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		WATER = 24,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		CANDY = 25,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		FUR = 26,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		CHAIN_MAIL = 27,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		PLACEHOLDER_14 = 28,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		PLACEHOLDER_15 = 29,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		PLACEHOLDER_16 = 30,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		PLACEHOLDER_18 = 31,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		MAX_VALUE = 31,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		COUNT = 32,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum ShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		CURVE_Tube = 0,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		CURVE_Ribbon = 1,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		LegacyBox = 2,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		RR_Sphere = 3,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		RR_Cylinder = 4,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		LEGACY_Wedge = 5,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		LEGACY_Pyramid = 6,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		LEGACY_TriggerVolumeBox = 7,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		RR_Box = 8,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		LEGACY_RoundedBox = 9,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		RR_Wedge = 10,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		RR_Pyramid = 11,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		RR_HalfSphere = 12,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		RR_Cone = 13,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		RR_Pipe = 14,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		RR_Donut = 15,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		RR_HalfPipe = 16,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		RR_Diamond = 17,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		ADVANCED_Mound = 18,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		ADVANCED_Cube = 19,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		ADVANCED_Sphere = 20,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		ADVANCED_Cylinder = 21,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		ADVANCED_Cone = 22,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		ADVANCED_Pyramid = 23,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		ADVANCED_Octagon = 24,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		ADVANCED_Triangle = 25,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		ADVANCED_Hexagon = 26,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		ADVANCED_QuarterPipe = 27,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		ADVANCED_Pentagon = 28,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		ADVANCED_Dodecahedron = 29,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		ADVANCED_Trihedron = 30,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		ADVANCED_Octahedron = 31,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		RR_QuarterCylinder = 32,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		RR_Pentagon = 33,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		RR_QuarterSphere = 34,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		ADVANCED_Wedge = 35,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		RR_Hexagon = 36,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		RR_Octagon = 37,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		RR_Triangle = 38,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		COUNT = 39,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		MAX_VALUE = 38
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum TextureWrapMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Repeat,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Clamp,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		Other
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class EHZMEDOZXAF
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct ProfileSession : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private readonly string? _outputPath;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9995350", Offset = "0x9994350", VA = "0x189995350")]
			internal ProfileSession(string? outputPath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal struct ProfileSection : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private readonly string? _name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly int _depth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly long _startTicks;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9995340", Offset = "0x9994340", VA = "0x189995340")]
			internal ProfileSection(string name)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210")]
		public static ProfileSession FACRFPUWRCL(string? a)
		{
			return default(ProfileSession);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1827710", Offset = "0x1826710", VA = "0x181827710")]
		internal static ProfileSection Section(string name)
		{
			return default(ProfileSection);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ADOHUXVGQNZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string? PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int? WFAXLYTIUFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xE01B00", Offset = "0xE00B00", VA = "0x180E01B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public ADOHUXVGQNZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface ITTJCCLXRJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		HEFXQWGYROP? RVBHUTKYCBY(PrimitiveShapeMeshType a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BevelConfig IJCHKFHSLFW();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		YZLTSXCXHCR? GetMaterialExportData(ShapeColor shapeColor, ShapeMaterial shapeMaterial);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class UQMMEQQRCNB
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private readonly struct ExportContext
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public readonly SceneBuilder SceneBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public readonly ITTJCCLXRJK Dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public readonly BevelConfig BevelConfig;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public readonly Dictionary<string, int> NodeNameToCountMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public readonly Dictionary<MaterialExportKey, MaterialBuilder> MaterialCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public readonly Dictionary<PrimitiveShapeMeshType, HEFXQWGYROP?> PrimitiveMeshCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public readonly Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> MeshBuilderCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public readonly FSVMLMUQAGK? Progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public readonly ZWOSQNFQINT TimedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public readonly CancellationToken CancellationToken;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x998FC50", Offset = "0x998EC50", VA = "0x18998FC50")]
			private ExportContext(SceneBuilder sceneBuilder, ITTJCCLXRJK dependencies, BevelConfig bevelConfig, Dictionary<string, int> nodeNameToCountMap, Dictionary<MaterialExportKey, MaterialBuilder> materialCache, Dictionary<PrimitiveShapeMeshType, HEFXQWGYROP?> primitiveMeshCache, Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> meshBuilderCache, FSVMLMUQAGK? progress, ZWOSQNFQINT timedYielder, CancellationToken cancellationToken)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x998F8F0", Offset = "0x998E8F0", VA = "0x18998F8F0")]
			public static ExportContext New(ITTJCCLXRJK dependencies, FSVMLMUQAGK? progress, CancellationToken cancellationToken)
			{
				return default(ExportContext);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private struct <BuildR1GlbModel>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public RWNYJETRKPC[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public ITTJCCLXRJK dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public FSVMLMUQAGK progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private EHZMEDOZXAF.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private RWNYJETRKPC[] <views>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private ExportContext <ctx>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private NodeBuilder <shapeRootNode>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private EHZMEDOZXAF.ProfileSection <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private int <index>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private object <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9995B80", Offset = "0x9994B80", VA = "0x189995B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9996A00", Offset = "0x9995A00", VA = "0x189996A00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private struct <BuildR2GlbModel>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public RWNYJETRKPC[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public ITTJCCLXRJK dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public FSVMLMUQAGK progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public ADOHUXVGQNZ[] nodeInfos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private EHZMEDOZXAF.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private RWNYJETRKPC[] <views>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private ExportContext <ctx>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private NodeBuilder[] <allNodes>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			private bool[] <created>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private EHZMEDOZXAF.ProfileSection <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private NodeBuilder <shapeRootNode>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private bool <madeProgress>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private int <i>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private object <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9996A70", Offset = "0x9995A70", VA = "0x189996A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9998550", Offset = "0x9997550", VA = "0x189998550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct <ProcessShapesForNode>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public int index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public RWNYJETRKPC pv;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public int totalViewCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public ExportContext ctx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public NodeBuilder containerNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private EHZMEDOZXAF.ProfileSection <_containerProfile>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private int <shapeCountInContainer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private float3 <containerScale>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private string <baseProgressMessage>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private int <shapeIndex>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x99985C0", Offset = "0x99975C0", VA = "0x1899985C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9999570", Offset = "0x9998570", VA = "0x189999570", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private struct <WriteGlbModel>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public FSVMLMUQAGK progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public ModelRoot model;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public Stream output;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x99995D0", Offset = "0x99985D0", VA = "0x1899995D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9999940", Offset = "0x9998940", VA = "0x189999940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x999A9F0", Offset = "0x99999F0", VA = "0x18999A9F0")]
		[AsyncStateMachine(typeof(<BuildR1GlbModel>d__0))]
		public static Task<ModelRoot> OEFPLHLOFIL(RWNYJETRKPC[] a, ITTJCCLXRJK b, [Optional] FSVMLMUQAGK? progress, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x999A870", Offset = "0x9999870", VA = "0x18999A870")]
		[AsyncStateMachine(typeof(<BuildR2GlbModel>d__1))]
		public static Task<ModelRoot> MLDPVYNZAXQ(RWNYJETRKPC[] a, ADOHUXVGQNZ[] b, ITTJCCLXRJK c, [Optional] FSVMLMUQAGK? progress, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x999B300", Offset = "0x999A300", VA = "0x18999B300")]
		[AsyncStateMachine(typeof(<WriteGlbModel>d__2))]
		public static Task WriteGlbModel(ModelRoot model, Stream output, [Optional] FSVMLMUQAGK? progress)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x999A700", Offset = "0x9999700", VA = "0x18999A700")]
		[AsyncStateMachine(typeof(<ProcessShapesForNode>d__3))]
		private static Task IIABNQHRXEI(NodeBuilder a, RWNYJETRKPC b, int c, int d, ExportContext e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99999A0", Offset = "0x99989A0", VA = "0x1899999A0")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> BRGFREICCUC(PrimitiveShapeMeshType a, string b, ShapeColor c, ShapeMaterial d, float e, float3 f, bool g, float h, float3 i, ExportContext j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9999FA0", Offset = "0x9998FA0", VA = "0x189999FA0")]
		private static MaterialBuilder DNYBMDLXJRQ(ShapeColor a, ShapeMaterial b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x999A670", Offset = "0x9999670", VA = "0x18999A670")]
		private static float FTIGBJDCAKK(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x999AB50", Offset = "0x9999B50", VA = "0x18999AB50")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> RQTAHYMYNSX(string a, HEFXQWGYROP b, MaterialBuilder c, [Optional] float2[]? perCornerUvs)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal static class SWSJWDVPYNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99957A0", Offset = "0x99947A0", VA = "0x1899957A0")]
		public static bool MBELVYJKANR(PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99954A0", Offset = "0x99944A0", VA = "0x1899954A0")]
		public static void LKRYPMVBJEP(PrimitiveShapeMeshType a, float3 b, BevelConfig c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x99957C0", Offset = "0x99947C0", VA = "0x1899957C0")]
		public static HEFXQWGYROP XKTXNKUWIHQ(HEFXQWGYROP a, PrimitiveShapeMeshType b, float3 c, float d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class DRBEHPYATTO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x998ECA0", Offset = "0x998DCA0", VA = "0x18998ECA0")]
		public static Vector3 NEYWEWCCXKC(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x998ED90", Offset = "0x998DD90", VA = "0x18998ED90")]
		public static Quaternion PNSWDGUOQBN(quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8D86B80", Offset = "0x8D85B80", VA = "0x188D86B80")]
		public static Vector3 RHFXVVCSKZH(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x998ECA0", Offset = "0x998DCA0", VA = "0x18998ECA0")]
		public static Vector3 GLEHEXCPTHQ(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x998ECE0", Offset = "0x998DCE0", VA = "0x18998ECE0")]
		public static quaternion OVRSSMGCDHH(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x998EDE0", Offset = "0x998DDE0", VA = "0x18998EDE0")]
		public static quaternion VTILBANITIA(TransformData a)
		{
			return default(quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class BKEVTGXOLCN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x998EB10", Offset = "0x998DB10", VA = "0x18998EB10")]
		public static Guid HWQWHWEPMBH(ByteString? a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x998EC40", Offset = "0x998DC40", VA = "0x18998EC40")]
		public static string YTKYJVJYOBR(ByteString? self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class SBNONNBLMLB
	{
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly PrimitiveShapeMeshType[] QHYODSLGLZW;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9995360", Offset = "0x9994360", VA = "0x189995360")]
		public static PrimitiveShapeMeshType AGPRETOEVDL(ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class SYHOEOOJXPF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9995AA0", Offset = "0x9994AA0", VA = "0x189995AA0")]
		public static string RGTKEUAYSEW(string a, Dictionary<string, int> b)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.ShapeExport
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class HWXXOBUAVSM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x99946B0", Offset = "0x99936B0", VA = "0x1899946B0")]
		public static HEFXQWGYROP SREHIAKZIWS(PrimitiveShapeMeshType a, float3 b, float c, ITTJCCLXRJK d, Dictionary<PrimitiveShapeMeshType, HEFXQWGYROP?> primitiveMeshCache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9994850", Offset = "0x9993850", VA = "0x189994850")]
		public static float2[] VUGAIEPSSIS(HEFXQWGYROP a, float3 b, bool c, float d, float e, float3 f)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.CurveExport
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class AGCASHVGZHF
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly float3 FKBMMJPJEVU;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly float3 WWVQSYAZZDS;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x998E070", Offset = "0x998D070", VA = "0x18998E070")]
		public static float3 SMESOOTBUVD(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x998D430", Offset = "0x998C430", VA = "0x18998D430")]
		public static float3 GGOLVJEHMJR(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x998E630", Offset = "0x998D630", VA = "0x18998E630")]
		public static quaternion VXPTQCMXQWN(float3 a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x998D5E0", Offset = "0x998C5E0", VA = "0x18998D5E0")]
		public static float GGRRWVBILYT(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x998DF20", Offset = "0x998CF20", VA = "0x18998DF20")]
		public static float QSTJYMUMESV(float3 a, float3 b, float3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x998E220", Offset = "0x998D220", VA = "0x18998E220")]
		public static float3 UDQOVGHWXSA(float3 a, float3 b, float3 c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x998D8E0", Offset = "0x998C8E0", VA = "0x18998D8E0")]
		public static quaternion OYDTTGZUDYM(quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x998D780", Offset = "0x998C780", VA = "0x18998D780")]
		public static bool JXAHWPSLTVQ(float3 a, float3 b, [Out] float3 c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x998E6B0", Offset = "0x998D6B0", VA = "0x18998E6B0")]
		public static float3 WXEIYLZDQBZ(bool a, [Optional] quaternion b)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class HSFLARKVWZV
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9993770", Offset = "0x9992770", VA = "0x189993770")]
		public static HEFXQWGYROP QRHSDGHPHCY(CurveShapeData a, ShapeType b, int c, float d, float3 e, float f, float g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9993660", Offset = "0x9992660", VA = "0x189993660")]
		private static void LCAWMEZWRGA(float3[] a, float3[] b, float2[] c, int d, float3 e, float3 f, float3 g, float h, bool i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9992BD0", Offset = "0x9991BD0", VA = "0x189992BD0")]
		private static void AUUVUWDCCCF(ExportCurvePointData a, ExportRingSegment b, float3[] c, float3[] d, float2[] e, int f, float g, float h, float i, float3 j, float k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9993010", Offset = "0x9992010", VA = "0x189993010")]
		private static void IXJSZYPZQUH(ExportRingSegment a, float3[] b, float3[] c, float2[] d, int[] e, int f, int g, float3 h, float3x3 i, bool j, float k, int l, bool m, float n, float o, float3 p, float q)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal struct ExportCurvePointData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public float3x3 Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public float Radius;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class GYKWHTMZQQC
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private struct PointSrcData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public float3 Position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public quaternion Rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public float Radius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public quaternion BlendedRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public float BendAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public float BendRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public float DistanceToNext;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x998FE70", Offset = "0x998EE70", VA = "0x18998FE70")]
		public static List<ExportCurvePointData> Generate(IReadOnlyList<float3> positions, IReadOnlyList<float3> normals, IReadOnlyList<float> radii, int configFlags, float heightScale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9992520", Offset = "0x9991520", VA = "0x189992520")]
		private static void USWQBDUFJVP(IReadOnlyList<float3> a, float3[] b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99905A0", Offset = "0x998F5A0", VA = "0x1899905A0")]
		private static float3 LMATYHVRSPX(IReadOnlyList<float3> a, float3[] b, int c, int d, bool e, bool f, quaternion g)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9991540", Offset = "0x9990540", VA = "0x189991540")]
		private static List<ExportCurvePointData> NLSDRYTGTZP(List<PointSrcData> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9991880", Offset = "0x9990880", VA = "0x189991880")]
		private static bool QVTLWBWDXFG(int a, List<ExportCurvePointData> b, List<PointSrcData> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9992640", Offset = "0x9991640", VA = "0x189992640")]
		private static ExportCurvePointData XTJVHWXQPFS(int a, List<PointSrcData> b)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9990830", Offset = "0x998F830", VA = "0x189990830")]
		private static List<ExportCurvePointData> LYPNWIZDNFB(List<PointSrcData> a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x998FDB0", Offset = "0x998EDB0", VA = "0x18998FDB0")]
		private static ExportCurvePointData FAQFESKZVUY(PointSrcData a)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x998FD20", Offset = "0x998ED20", VA = "0x18998FD20")]
		private static ExportCurvePointData CDIHVEKKGDD(float3 a, quaternion b, float c)
		{
			return default(ExportCurvePointData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ExportRingVertex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public float2 Offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public float2 Normal;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct ExportRingSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public ExportRingVertex[] RingVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public int[] RingIndices;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class DRCSPQTUFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x998F4F0", Offset = "0x998E4F0", VA = "0x18998F4F0")]
		public static ExportRingSegment QGCTRNOMJTF(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x998EF40", Offset = "0x998DF40", VA = "0x18998EF40")]
		public static ExportRingSegment HTILFTATTVG(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x998EF10", Offset = "0x998DF10", VA = "0x18998EF10")]
		public static ExportRingSegment BWMWPHTUPMZ()
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x998F490", Offset = "0x998E490", VA = "0x18998F490")]
		public static int NUQEFEACNTV(int a, int b, bool c, bool d, bool e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x998F8A0", Offset = "0x998E8A0", VA = "0x18998F8A0")]
		public static int VVQDLUFUFQJ(int a, int b, bool c, bool d, bool e)
		{
			return default(int);
		}
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
