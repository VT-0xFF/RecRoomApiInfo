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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x99A4E90", Offset = "0x99A3890", VA = "0x1899A4E90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ExportTools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class FIUIDDCBJBZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x999EFC0", Offset = "0x999D9C0", VA = "0x18999EFC0")]
		public static ModelRoot BuildAvatarGlbModel(string sceneName, ZACFJYIVMOK[] nodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x999F680", Offset = "0x999E080", VA = "0x18999F680")]
		private static MaterialBuilder NBNFETWFLAC(WTOODUSZUQO? matData, Dictionary<WTOODUSZUQO, MaterialBuilder> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x999EF60", Offset = "0x999D960", VA = "0x18999EF60")]
		private static ImageBuilder? BRLTUCPTAHB(byte[]? a, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x999F5F0", Offset = "0x999DFF0", VA = "0x18999F5F0")]
		private static float KZXPZFECODY(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x999FE90", Offset = "0x999E890", VA = "0x18999FE90")]
		private static IMeshBuilder<MaterialBuilder> OJZQKXVXMNV(string a, ORFSMVEOKQH b, MaterialBuilder c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99A0600", Offset = "0x999F000", VA = "0x1899A0600")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture2, VertexEmpty> UELNSWOGPWG(string a, ORFSMVEOKQH b, MaterialBuilder c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class WTOODUSZUQO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string EDJPGUEQTOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public ColorRGB GDWNZKYYUHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public float QLCKDMVZTWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public byte[]? LTJCNQPBXDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int YPJZKAVCAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public bool KTJABZALZXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public byte[]? IKNVMGNIXXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float NLLBXTIPSMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public ColorRGB FXAXWBCQXKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public byte[]? PZGPNIEKJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float PGKMEOQRKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float NTECVMWSURC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public byte[]? CSZBQSITUOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public bool MJVDPRFDYEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float? SZZWNGDWCXN;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99ACE90", Offset = "0x99AB890", VA = "0x1899ACE90")]
		public WTOODUSZUQO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ZACFJYIVMOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public string EDJPGUEQTOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float3 UAQIHVSIKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public quaternion UBMXPZFLWJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float3 VRHJFIVLQON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public ORFSMVEOKQH GQBKHMYYRID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public WTOODUSZUQO? HSIUGFJSEDV;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99AEC60", Offset = "0x99AD660", VA = "0x1899AEC60")]
		public ZACFJYIVMOK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct BevelConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public bool BevelSizeBasedOnLargestPossibleDimension;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct ColorRGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly float R;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly float G;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly float B;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static ColorRGB MHXDGQUEXMH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x999EB10", Offset = "0x999D510", VA = "0x18999EB10")]
			get
			{
				return default(ColorRGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static ColorRGB TJDDFPSIDUF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x1076230", Offset = "0x1074C30", VA = "0x181076230")]
			get
			{
				return default(ColorRGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4440", Offset = "0x2BA2E40", VA = "0x182BA4440")]
		public ColorRGB(float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class FVWOFGTHNDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string YUURIMMXEQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MaterialColorUsage JXQGMGIAPHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ColorRGB OFSZYAJRPTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ColorRGB FXAXWBCQXKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public ColorRGB IEATOQYWNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public float OACRXDDLAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MRZQOCMGYPZ? FKXYXMQEKXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public MRZQOCMGYPZ? SOHCXCSTELK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public MRZQOCMGYPZ? OKKHXKAJJJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public MRZQOCMGYPZ? HSDAUOTGXPI;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99A0EB0", Offset = "0x999F8B0", VA = "0x1899A0EB0")]
		public FVWOFGTHNDP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal readonly struct MaterialExportKey : IEquatable<MaterialExportKey>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly ShapeColor ShapeColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly ShapeMaterial ShapeMaterial;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
		public MaterialExportKey(ShapeColor shapeColor, ShapeMaterial shapeMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1452F40", Offset = "0x1451940", VA = "0x181452F40", Slot = "4")]
		public bool Equals(MaterialExportKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99A4930", Offset = "0x99A3330", VA = "0x1899A4930", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x99A49C0", Offset = "0x99A33C0", VA = "0x1899A49C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal readonly struct MeshBuilderCacheKey : IEquatable<MeshBuilderCacheKey>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly PrimitiveShapeMeshType MeshType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly MaterialExportKey Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly float3 BevelScalingRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly float BevelAuthoredRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly float3 WorldScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly bool DynamicProjection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly float ContainerScaleX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly float UvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly float3 UvOffset;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99A4E20", Offset = "0x99A3820", VA = "0x1899A4E20")]
		public MeshBuilderCacheKey(PrimitiveShapeMeshType meshType, MaterialExportKey material, [Optional] float3 bevelScalingRatio, float bevelAuthoredRatio = 0f, [Optional] float3 worldScale, bool dynamicProjection = false, float containerScaleX = 0f, float uvScale = 0f, [Optional] float3 uvOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99A4A30", Offset = "0x99A3430", VA = "0x1899A4A30", Slot = "4")]
		public bool Equals(MeshBuilderCacheKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99A4BC0", Offset = "0x99A35C0", VA = "0x1899A4BC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99A4C80", Offset = "0x99A3680", VA = "0x1899A4C80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ORFSMVEOKQH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float3[] JHVWMZHTVMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int[] WFSPUJBKSLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float3[] RQCBSRLUQSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float2[]? YAANEBHNFEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float2[]? SAMWCFNVFYR;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B87870", Offset = "0x8B86270", VA = "0x188B87870")]
		public ORFSMVEOKQH(float3[] a, int[] b, float3[] c, [Optional] float2[]? uv0s, [Optional] float2[]? uv1s)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MRZQOCMGYPZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string UEKBVMDJFNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public ImageBuilder? YLQECQBRHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public float2 UGICJWZXTTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float2 OHFXQNDZZMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public TextureWrapMode OJUFZEVULQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public TextureWrapMode OKKAQZDMNYR;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99A48E0", Offset = "0x99A32E0", VA = "0x1899A48E0")]
		public MRZQOCMGYPZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[Flags]
	public enum MaterialColorUsage
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		ALBEDO = 1,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		EMISSIVE = 2,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		SPECULAR = 4,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		HOLOGRAPHIC = 8
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum PrimitiveShapeMeshType
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		RR_Box,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		RR_Sphere,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		RR_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		RR_Wedge,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		RR_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		RR_HalfSphere,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		RR_Cone,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		RR_Pipe,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		RR_Donut,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		RR_HalfPipe,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		RR_Diamond,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		ADVANCED_Mound,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		LEGACY_Box,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		ADVANCED_Cube,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		ADVANCED_Sphere,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		ADVANCED_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		ADVANCED_Cone,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		ADVANCED_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		ADVANCED_Octagon,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		ADVANCED_Triangle,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		ADVANCED_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		ADVANCED_QuarterPipe,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		ADVANCED_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		ADVANCED_Dodecahedron,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		ADVANCED_Trihedron,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		ADVANCED_Octahedron,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		RR_QuarterCylinder,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		RR_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		RR_QuarterSphere,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		ADVANCED_Wedge,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		RR_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		RR_Octagon,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		RR_Triangle,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum ShapeColor
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		RED = 0,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ORANGE = 1,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		YELLOW = 2,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		GREEN = 3,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		DARK_GREEN = 4,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		CYAN = 5,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		BLUE = 6,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		DARK_BLUE = 7,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		PURPLE = 8,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		PINK = 9,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		BROWN = 10,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		WHITE = 11,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		GREY = 12,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		BLACK = 13,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		DARK_ORANGE = 14,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		LIME = 15,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		LIGHT_GREEN = 16,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		AQUAMARINE = 17,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		LIGHT_BLUE = 18,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		LAVENDER = 19,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		MAGENTA = 20,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		SALMON = 21,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		TAN = 22,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		CREAM = 23,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		LIGHT_GREY = 24,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		DARK_GREY = 25,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		NEW_COLOR_0 = 26,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		NEW_COLOR_1 = 27,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		NEW_COLOR_2 = 28,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		NEW_COLOR_3 = 29,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		NEW_COLOR_4 = 30,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		NEW_COLOR_5 = 31,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		NEW_COLOR_6 = 32,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		UNUSED_SEE_COMMENT = 33,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		NEW_COLOR_7 = 34,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		NEW_COLOR_8 = 35,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		NEW_COLOR_9 = 36,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		NEW_COLOR_10 = 37,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		NEW_COLOR_11 = 38,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		NEW_COLOR_12 = 39,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		NEW_COLOR_13 = 40,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		NEW_COLOR_14 = 41,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		NEW_COLOR_15 = 42,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		NEW_COLOR_16 = 43,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		NEW_COLOR_17 = 44,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		NEW_COLOR_18 = 45,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		NEW_COLOR_19 = 46,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		NEW_COLOR_20 = 47,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		NEW_COLOR_21 = 48,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		NEW_COLOR_22 = 49,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		NEW_COLOR_23 = 50,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		NEW_COLOR_24 = 51,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		NEW_COLOR_25 = 52,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		NEW_COLOR_26 = 53,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		NEW_COLOR_27 = 54,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		NEW_COLOR_28 = 55,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		NEW_COLOR_29 = 56,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		NEW_COLOR_30 = 57,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		NEW_COLOR_31 = 58,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		NEW_COLOR_32 = 59,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		NEW_COLOR_33 = 60,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		GENERATED_COLOR_START = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum ShapeMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		INVALID = -1,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		CARDBOARD = 0,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		METAL = 1,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		RUBBER = 2,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		PLASTIC = 3,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		NEON = 4,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		WOOD = 5,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		GLASS = 6,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		ROCK = 7,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		ICE = 8,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		GOLD = 9,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		SAND = 10,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		LEATHER = 11,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		GRID = 12,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		TILE = 13,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		GRASS = 14,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		BARK = 15,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		CONCRETE = 16,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		SNOW = 17,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		CARPET = 18,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		FABRIC = 19,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		FOIL = 20,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		FLESH = 21,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		GALAXY = 22,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		LAVA = 23,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		WATER = 24,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		CANDY = 25,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		FUR = 26,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		CHAIN_MAIL = 27,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		PLACEHOLDER_14 = 28,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		PLACEHOLDER_15 = 29,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		PLACEHOLDER_16 = 30,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		PLACEHOLDER_18 = 31,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		MAX_VALUE = 31,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		COUNT = 32,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum ShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		CURVE_Tube = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		CURVE_Ribbon = 1,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		LegacyBox = 2,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		RR_Sphere = 3,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		RR_Cylinder = 4,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		LEGACY_Wedge = 5,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		LEGACY_Pyramid = 6,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		LEGACY_TriggerVolumeBox = 7,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		RR_Box = 8,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		LEGACY_RoundedBox = 9,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		RR_Wedge = 10,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		RR_Pyramid = 11,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		RR_HalfSphere = 12,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		RR_Cone = 13,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		RR_Pipe = 14,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		RR_Donut = 15,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		RR_HalfPipe = 16,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		RR_Diamond = 17,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		ADVANCED_Mound = 18,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		ADVANCED_Cube = 19,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		ADVANCED_Sphere = 20,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		ADVANCED_Cylinder = 21,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		ADVANCED_Cone = 22,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		ADVANCED_Pyramid = 23,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		ADVANCED_Octagon = 24,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		ADVANCED_Triangle = 25,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		ADVANCED_Hexagon = 26,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		ADVANCED_QuarterPipe = 27,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		ADVANCED_Pentagon = 28,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		ADVANCED_Dodecahedron = 29,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		ADVANCED_Trihedron = 30,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		ADVANCED_Octahedron = 31,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		RR_QuarterCylinder = 32,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		RR_Pentagon = 33,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		RR_QuarterSphere = 34,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		ADVANCED_Wedge = 35,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		RR_Hexagon = 36,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		RR_Octagon = 37,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		RR_Triangle = 38,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		COUNT = 39,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		MAX_VALUE = 38
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum TextureWrapMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Repeat,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Clamp,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Other
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class DGYVTUXRHEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public struct ProfileSession : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly string? _outputPath;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x99A5A00", Offset = "0x99A4400", VA = "0x1899A5A00")]
			internal ProfileSession(string? outputPath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal struct ProfileSection : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly string? _name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly int _depth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly long _startTicks;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x99A59F0", Offset = "0x99A43F0", VA = "0x1899A59F0")]
			internal ProfileSection(string name)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160")]
		public static ProfileSession JPMHDBJTTOT(string? a)
		{
			return default(ProfileSession);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1852730", Offset = "0x1851130", VA = "0x181852730")]
		internal static ProfileSection Section(string name)
		{
			return default(ProfileSection);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class CDVWGRGHTVF
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string? EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int? JLCTWNRYJGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xDF7E20", Offset = "0xDF6820", VA = "0x180DF7E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public CDVWGRGHTVF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface KGZAGFPSONW
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ORFSMVEOKQH? XORAKTNINKS(PrimitiveShapeMeshType a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BevelConfig JMCAEFUFNQI();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FVWOFGTHNDP? GetMaterialExportData(ShapeColor shapeColor, ShapeMaterial shapeMaterial);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool EVXELVPCFWM(Guid a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class HOCWOEDNJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class HGPKJRXKZAN
		{
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public static class PHNZRRBHUEZ
			{
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public static readonly Guid MVTXDAVAAXP;

				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public static readonly Guid CVXPHZXEXTJ;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private readonly struct ExportContext
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public readonly SceneBuilder SceneBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public readonly KGZAGFPSONW Dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public readonly BevelConfig BevelConfig;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public readonly Dictionary<string, int> NodeNameToCountMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public readonly Dictionary<MaterialExportKey, MaterialBuilder> MaterialCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public readonly Dictionary<PrimitiveShapeMeshType, ORFSMVEOKQH?> PrimitiveMeshCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public readonly Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> MeshBuilderCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public readonly UHOBUPPHWTY? Progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public readonly NVNLSDBNUUF TimedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public readonly CancellationToken CancellationToken;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x999EE90", Offset = "0x999D890", VA = "0x18999EE90")]
			private ExportContext(SceneBuilder sceneBuilder, KGZAGFPSONW dependencies, BevelConfig bevelConfig, Dictionary<string, int> nodeNameToCountMap, Dictionary<MaterialExportKey, MaterialBuilder> materialCache, Dictionary<PrimitiveShapeMeshType, ORFSMVEOKQH?> primitiveMeshCache, Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> meshBuilderCache, UHOBUPPHWTY? progress, NVNLSDBNUUF timedYielder, CancellationToken cancellationToken)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x999EB30", Offset = "0x999D530", VA = "0x18999EB30")]
			public static ExportContext New(KGZAGFPSONW dependencies, UHOBUPPHWTY? progress, CancellationToken cancellationToken)
			{
				return default(ExportContext);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private struct <BuildR1GlbModel>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public FKWMEATAMCU[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public KGZAGFPSONW dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public UHOBUPPHWTY progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private DGYVTUXRHEN.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private ExportContext <ctx>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private Queue<(NodeBuilder parentNode, FKWMEATAMCU data)> <queue>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			private FKWMEATAMCU <pv>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			private NodeBuilder <node>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private int <childViewCount>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private object <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x99A9360", Offset = "0x99A7D60", VA = "0x1899A9360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x99AA310", Offset = "0x99A8D10", VA = "0x1899AA310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private struct <BuildR2GlbModel>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public FKWMEATAMCU[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public KGZAGFPSONW dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public UHOBUPPHWTY progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public CDVWGRGHTVF[] nodeInfos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private DGYVTUXRHEN.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private FKWMEATAMCU[] <views>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private ExportContext <ctx>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private NodeBuilder[] <allNodes>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private bool[] <created>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			private DGYVTUXRHEN.ProfileSection <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			private NodeBuilder <shapeRootNode>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private bool <madeProgress>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			private int <i>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private object <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x99AA380", Offset = "0x99A8D80", VA = "0x1899AA380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x99ABE40", Offset = "0x99AA840", VA = "0x1899ABE40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <ProcessShapesForNode>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public FKWMEATAMCU pv;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public ExportContext ctx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public NodeBuilder containerNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private int <shapeCountInContainer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			private float3 <containerScale>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private int <shapeIndex>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x99ABEB0", Offset = "0x99AA8B0", VA = "0x1899ABEB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x99ACA60", Offset = "0x99AB460", VA = "0x1899ACA60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <WriteGlbModel>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public UHOBUPPHWTY progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public ModelRoot model;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Stream output;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x99ACAC0", Offset = "0x99AB4C0", VA = "0x1899ACAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x99ACE30", Offset = "0x99AB830", VA = "0x1899ACE30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99A2C10", Offset = "0x99A1610", VA = "0x1899A2C10")]
		public static bool JKSYIPHNWOX(FKWMEATAMCU? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99A45E0", Offset = "0x99A2FE0", VA = "0x1899A45E0")]
		public static bool TCUCCTJWDNN(FKWMEATAMCU? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99A2D60", Offset = "0x99A1760", VA = "0x1899A2D60")]
		private static bool MXILGFXFVCP(FKWMEATAMCU? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99A4480", Offset = "0x99A2E80", VA = "0x1899A4480")]
		[AsyncStateMachine(typeof(<BuildR1GlbModel>d__3))]
		public static Task<ModelRoot> SNSGLZYMDCP(FKWMEATAMCU[] a, KGZAGFPSONW b, [Optional] UHOBUPPHWTY? progress, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99A3550", Offset = "0x99A1F50", VA = "0x1899A3550")]
		[AsyncStateMachine(typeof(<BuildR2GlbModel>d__5))]
		public static Task<ModelRoot> NFDXCBRQLTU(FKWMEATAMCU[] a, CDVWGRGHTVF[] b, KGZAGFPSONW c, [Optional] UHOBUPPHWTY? progress, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99A47D0", Offset = "0x99A31D0", VA = "0x1899A47D0")]
		[AsyncStateMachine(typeof(<WriteGlbModel>d__6))]
		public static Task WriteGlbModel(ModelRoot model, Stream output, [Optional] UHOBUPPHWTY? progress)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x99A2AC0", Offset = "0x99A14C0", VA = "0x1899A2AC0")]
		[AsyncStateMachine(typeof(<ProcessShapesForNode>d__7))]
		private static Task JBVCMVCLVEQ(NodeBuilder a, FKWMEATAMCU b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99A3E80", Offset = "0x99A2880", VA = "0x1899A3E80")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> ONMMIXHOELU(PrimitiveShapeMeshType a, string b, ShapeColor c, ShapeMaterial d, float e, float3 f, bool g, float h, float3 i, ExportContext j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99A2E80", Offset = "0x99A1880", VA = "0x1899A2E80")]
		private static MaterialBuilder NBNFETWFLAC(ShapeColor a, ShapeMaterial b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x99A2CD0", Offset = "0x99A16D0", VA = "0x1899A2CD0")]
		private static float KZXPZFECODY(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x99A36D0", Offset = "0x99A20D0", VA = "0x1899A36D0")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> OJZQKXVXMNV(string a, ORFSMVEOKQH b, MaterialBuilder c, [Optional] float2[]? perCornerUvs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x99A26A0", Offset = "0x99A10A0", VA = "0x1899A26A0")]
		[CompilerGenerated]
		internal static NodeBuilder BTXYAFEKJKY(ExportContext a, NodeBuilder b, FKWMEATAMCU c)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class SEUFDMCOUHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x99A8CE0", Offset = "0x99A76E0", VA = "0x1899A8CE0")]
		public static bool XGHYBLUUJIP(PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x99A86E0", Offset = "0x99A70E0", VA = "0x1899A86E0")]
		public static void EHQLSKXJFHR(PrimitiveShapeMeshType a, float3 b, BevelConfig c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x99A89E0", Offset = "0x99A73E0", VA = "0x1899A89E0")]
		public static ORFSMVEOKQH EQNNZOKDWKC(ORFSMVEOKQH a, PrimitiveShapeMeshType b, float3 c, float d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class YDLUNCNLAXK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x99AEAA0", Offset = "0x99AD4A0", VA = "0x1899AEAA0")]
		public static Vector3 RIGXLHWWTVU(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x99AEC10", Offset = "0x99AD610", VA = "0x1899AEC10")]
		public static Quaternion NWVLDOXAVWX(quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8D9AF20", Offset = "0x8D99920", VA = "0x188D9AF20")]
		public static Vector3 LNUMZXHYFVD(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x99AEAA0", Offset = "0x99AD4A0", VA = "0x1899AEAA0")]
		public static Vector3 IIHJATCOCGW(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x99AE9F0", Offset = "0x99AD3F0", VA = "0x1899AE9F0")]
		public static quaternion BIZKDGGIBQV(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x99AEAE0", Offset = "0x99AD4E0", VA = "0x1899AEAE0")]
		public static quaternion MICJSIATPII(TransformData a)
		{
			return default(quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class CSIOSRVGPIB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x999E9E0", Offset = "0x999D3E0", VA = "0x18999E9E0")]
		public static Guid UKSKFAXXGBP(ByteString? a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x999E980", Offset = "0x999D380", VA = "0x18999E980")]
		public static string QBRUEIXFJYH(ByteString? self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class ZJQLEOWLHWH
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly PrimitiveShapeMeshType[] UUHMOXXXHUA;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99AECB0", Offset = "0x99AD6B0", VA = "0x1899AECB0")]
		public static PrimitiveShapeMeshType AOTIRDKNGVL(ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class GXVBPXMAETR
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99A25C0", Offset = "0x99A0FC0", VA = "0x1899A25C0")]
		public static string YLIWBPDMFJY(string a, Dictionary<string, int> b)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.ShapeExport
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal static class SSZRERLXQSY
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99A8D00", Offset = "0x99A7700", VA = "0x1899A8D00")]
		public static ORFSMVEOKQH RIFIJEVDAPI(PrimitiveShapeMeshType a, float3 b, float c, KGZAGFPSONW d, Dictionary<PrimitiveShapeMeshType, ORFSMVEOKQH?> primitiveMeshCache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99A8EA0", Offset = "0x99A78A0", VA = "0x1899A8EA0")]
		public static float2[] YAHBGPLLCJQ(ORFSMVEOKQH a, float3 b, bool c, float d, float e, float3 f)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.CurveExport
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class GHFKYATJYTZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly float3 MEDIRTLHHMC;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly float3 PCKIPBNQLOE;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99A2090", Offset = "0x99A0A90", VA = "0x1899A2090")]
		public static float3 VPHBWLPDDHD(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x99A2390", Offset = "0x99A0D90", VA = "0x1899A2390")]
		public static float3 ZWDUEJJOHXR(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99A0F00", Offset = "0x999F900", VA = "0x1899A0F00")]
		public static quaternion BQIHIHZIJPH(float3 a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99A1B10", Offset = "0x99A0510", VA = "0x1899A1B10")]
		public static float LBRLDOQPKGD(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x99A2240", Offset = "0x99A0C40", VA = "0x1899A2240")]
		public static float XWYCZSMWYSV(float3 a, float3 b, float3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x99A0F80", Offset = "0x999F980", VA = "0x1899A0F80")]
		public static float3 FYUGJJCKHTW(float3 a, float3 b, float3 c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99A14D0", Offset = "0x999FED0", VA = "0x1899A14D0")]
		public static quaternion KLGUNARMZTW(quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x99A1390", Offset = "0x999FD90", VA = "0x1899A1390")]
		public static bool GPJIEWDUUIG(float3 a, float3 b, [Out] float3 c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x99A1CB0", Offset = "0x99A06B0", VA = "0x1899A1CB0")]
		public static float3 LHSUMVYNZRV(bool a, [Optional] quaternion b)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class XTXLZRXWQIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x99ADAC0", Offset = "0x99AC4C0", VA = "0x1899ADAC0")]
		public static ORFSMVEOKQH KYEBEOOSARG(CurveShapeData a, ShapeType b, int c, float d, float3 e, float f, float g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x99AD570", Offset = "0x99ABF70", VA = "0x1899AD570")]
		private static void EOSDVDFDDHW(float3[] a, float3[] b, float2[] c, int d, float3 e, float3 f, float3 g, float h, bool i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x99AD680", Offset = "0x99AC080", VA = "0x1899AD680")]
		private static void JGXQXMBXFCR(ExportCurvePointData a, ExportRingSegment b, float3[] c, float3[] d, float2[] e, int f, float g, float h, float i, float3 j, float k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x99ACF20", Offset = "0x99AB920", VA = "0x1899ACF20")]
		private static void DXSCVRVYOXJ(ExportRingSegment a, float3[] b, float3[] c, float2[] d, int[] e, int f, int g, float3 h, float3x3 i, bool j, float k, int l, bool m, float n, float o, float3 p, float q)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal struct ExportCurvePointData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public float3x3 Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public float Radius;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class QDHXQACOWIS
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private struct PointSrcData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public float3 Position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public quaternion Rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public float Radius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public quaternion BlendedRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public float BendAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public float BendRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public float DistanceToNext;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x99A5A10", Offset = "0x99A4410", VA = "0x1899A5A10")]
		public static List<ExportCurvePointData> Generate(IReadOnlyList<float3> positions, IReadOnlyList<float3> normals, IReadOnlyList<float> radii, int configFlags, float heightScale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x99A7DA0", Offset = "0x99A67A0", VA = "0x1899A7DA0")]
		private static float3[] SJSNWTCQWNT(IReadOnlyList<float3> a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x99A6020", Offset = "0x99A4A20", VA = "0x1899A6020")]
		private static List<ExportCurvePointData> JVPMRRJREZT(List<PointSrcData> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x99A7100", Offset = "0x99A5B00", VA = "0x1899A7100")]
		private static bool RIDCFTBEPBW(int a, List<ExportCurvePointData> b, List<PointSrcData> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x99A8090", Offset = "0x99A6A90", VA = "0x1899A8090")]
		private static ExportCurvePointData SOTNGTFNVFS(int a, List<PointSrcData> b)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x99A6360", Offset = "0x99A4D60", VA = "0x1899A6360")]
		private static List<ExportCurvePointData> LPWDOVCXMOL(List<PointSrcData> a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x99A8620", Offset = "0x99A7020", VA = "0x1899A8620")]
		private static ExportCurvePointData XUBVPBFLILW(PointSrcData a)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x99A7070", Offset = "0x99A5A70", VA = "0x1899A7070")]
		private static ExportCurvePointData NZWHMIXEUKV(float3 a, quaternion b, float c)
		{
			return default(ExportCurvePointData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal struct ExportRingVertex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public float2 Offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float2 Normal;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal struct ExportRingSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public ExportRingVertex[] RingVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int[] RingIndices;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal static class OYWTZWOVHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99A4FF0", Offset = "0x99A39F0", VA = "0x1899A4FF0")]
		public static ExportRingSegment NZSKLWKYMLJ(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x99A53A0", Offset = "0x99A3DA0", VA = "0x1899A53A0")]
		public static ExportRingSegment ZQXYOIWFJNO(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x99A4F70", Offset = "0x99A3970", VA = "0x1899A4F70")]
		public static ExportRingSegment EXRQVZJCOYV()
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x99A4F10", Offset = "0x99A3910", VA = "0x1899A4F10")]
		public static int DKNPCGGOGNN(int a, int b, bool c, bool d, bool e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x99A4FA0", Offset = "0x99A39A0", VA = "0x1899A4FA0")]
		public static int FHDZBSFPXMR(int a, int b, bool c, bool d, bool e)
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
