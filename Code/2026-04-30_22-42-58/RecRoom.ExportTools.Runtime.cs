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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9777AA0", Offset = "0x9776EA0", VA = "0x189777AA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ExportTools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class FIEXATVQDET
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9770BA0", Offset = "0x976FFA0", VA = "0x189770BA0")]
		public static ModelRoot BuildAvatarGlbModel(string sceneName, SYRLWHXBZIK[] nodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9772250", Offset = "0x9771650", VA = "0x189772250")]
		private static MaterialBuilder TCRQZLVRAYG(UQAZPMKTWBU? matData, Dictionary<UQAZPMKTWBU, MaterialBuilder> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x97711D0", Offset = "0x97705D0", VA = "0x1897711D0")]
		private static ImageBuilder? EBHYVEMMZAT(byte[]? a, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9772A60", Offset = "0x9771E60", VA = "0x189772A60")]
		private static float WGXWLAXBASK(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9771AE0", Offset = "0x9770EE0", VA = "0x189771AE0")]
		private static IMeshBuilder<MaterialBuilder> KAFSKVXRQGD(string a, SIQLDCGEZQD b, MaterialBuilder c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9771230", Offset = "0x9770630", VA = "0x189771230")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture2, VertexEmpty> FFBQOGPZVVI(string a, SIQLDCGEZQD b, MaterialBuilder c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class UQAZPMKTWBU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string EREWIERIFZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public ColorRGB SNZWPXGLHDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public float EFURHGUAPKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public byte[]? QRDMHZMBNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int SQMLAEYLMOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public bool UZQZUXGMJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public byte[]? VSYRKOCBKXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float FSDAWCLVRIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public ColorRGB IABIKFKVRAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public byte[]? DNNYPKVHTYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float ZESKFIPJFLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float SDQJRPOXSLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public byte[]? OPLNJPZFCVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public bool DNFDGMMMIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float? HTHGBPGSNEH;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x977BF30", Offset = "0x977B330", VA = "0x18977BF30")]
		public UQAZPMKTWBU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class SYRLWHXBZIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public string EREWIERIFZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float3 OXYBJKKQMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public quaternion RGSBHVDCEST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float3 UASRRBTTTFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public SIQLDCGEZQD QLORZUMUMRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public UQAZPMKTWBU? EEQKTWQVTXB;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9778380", Offset = "0x9777780", VA = "0x189778380")]
		public SYRLWHXBZIK()
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
		public static ColorRGB KLNPIKZEQNR
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9770670", Offset = "0x976FA70", VA = "0x189770670")]
			get
			{
				return default(ColorRGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static ColorRGB QKIQGGAEXJL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x1051130", Offset = "0x1050530", VA = "0x181051130")]
			get
			{
				return default(ColorRGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B71600", Offset = "0x2B70A00", VA = "0x182B71600")]
		public ColorRGB(float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ZZBUQWVONEV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string IHPMWMULMXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MaterialColorUsage ICNGBCLUKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ColorRGB QIJJLCKYUIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ColorRGB IABIKFKVRAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public ColorRGB LGKOIDOGZPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public float TNXHQNADXTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public UMCDBUXBQDR? IYBDHAYEGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public UMCDBUXBQDR? DEKTFGYZSQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public UMCDBUXBQDR? SIZLCRXBFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public UMCDBUXBQDR? YYMHSPJWQLE;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9780A70", Offset = "0x977FE70", VA = "0x189780A70")]
		public ZZBUQWVONEV()
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
		[Cpp2IlInjected.Address(RVA = "0xEC94D0", Offset = "0xEC88D0", VA = "0x180EC94D0")]
		public MaterialExportKey(ShapeColor shapeColor, ShapeMaterial shapeMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x142E350", Offset = "0x142D750", VA = "0x18142E350", Slot = "4")]
		public bool Equals(MaterialExportKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9777550", Offset = "0x9776950", VA = "0x189777550", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x97775E0", Offset = "0x97769E0", VA = "0x1897775E0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x9777A30", Offset = "0x9776E30", VA = "0x189777A30")]
		public MeshBuilderCacheKey(PrimitiveShapeMeshType meshType, MaterialExportKey material, [Optional] float3 bevelScalingRatio, float bevelAuthoredRatio = 0f, [Optional] float3 worldScale, bool dynamicProjection = false, float containerScaleX = 0f, float uvScale = 0f, [Optional] float3 uvOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9777650", Offset = "0x9776A50", VA = "0x189777650", Slot = "4")]
		public bool Equals(MeshBuilderCacheKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x97777E0", Offset = "0x9776BE0", VA = "0x1897777E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9777890", Offset = "0x9776C90", VA = "0x189777890", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SIQLDCGEZQD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float3[] VUVIKIFHLUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int[] NFBAUQHNUAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float3[] AFUMAEGDQUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float2[]? DVMMNQTOHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float2[]? VWCYLFBVKJL;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x896D2A0", Offset = "0x896C6A0", VA = "0x18896D2A0")]
		public SIQLDCGEZQD(float3[] a, int[] b, float3[] c, [Optional] float2[]? uv0s, [Optional] float2[]? uv1s)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UMCDBUXBQDR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string DZYAJQDXZSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public ImageBuilder? MVRGWIALGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public float2 GVPRWZNHLDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float2 XOJMVANENPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public TextureWrapMode EWTRZRRWOZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public TextureWrapMode EXJMRLZORHD;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x977BEE0", Offset = "0x977B2E0", VA = "0x18977BEE0")]
		public UMCDBUXBQDR()
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
	public static class YIOJPLAXMNH
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public struct ProfileSession : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly string? _outputPath;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9777B30", Offset = "0x9776F30", VA = "0x189777B30")]
			internal ProfileSession(string? outputPath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9777B20", Offset = "0x9776F20", VA = "0x189777B20")]
			internal ProfileSection(string name)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0")]
		public static ProfileSession GYMJYDCNRDR(string? a)
		{
			return default(ProfileSession);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x182A530", Offset = "0x1829930", VA = "0x18182A530")]
		internal static ProfileSection Section(string name)
		{
			return default(ProfileSection);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class HMDHSOJSCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string? EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int? CWMVPFDJJHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xDE68A0", Offset = "0xDE5CA0", VA = "0x180DE68A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public HMDHSOJSCFJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface ZVMBXFNFHDW
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		SIQLDCGEZQD? HQAATRQPZGK(PrimitiveShapeMeshType a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BevelConfig CNTWWSUEDAA();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ZZBUQWVONEV? GetMaterialExportData(ShapeColor shapeColor, ShapeMaterial shapeMaterial);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool AUYCTLZINWU(Guid a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class WLGDZPBLGOP
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class UPZJURSHWPT
		{
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public static class RYHPXVYNJRL
			{
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public static readonly Guid PZFZDUBQCIF;

				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public static readonly Guid YCFDAYZJJUH;
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
			public readonly ZVMBXFNFHDW Dependencies;

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
			public readonly Dictionary<PrimitiveShapeMeshType, SIQLDCGEZQD?> PrimitiveMeshCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public readonly Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> MeshBuilderCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public readonly RWDDBETBFKO? Progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public readonly OFVQWEIMDZX TimedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public readonly CancellationToken CancellationToken;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9770AD0", Offset = "0x976FED0", VA = "0x189770AD0")]
			private ExportContext(SceneBuilder sceneBuilder, ZVMBXFNFHDW dependencies, BevelConfig bevelConfig, Dictionary<string, int> nodeNameToCountMap, Dictionary<MaterialExportKey, MaterialBuilder> materialCache, Dictionary<PrimitiveShapeMeshType, SIQLDCGEZQD?> primitiveMeshCache, Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> meshBuilderCache, RWDDBETBFKO? progress, OFVQWEIMDZX timedYielder, CancellationToken cancellationToken)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9770770", Offset = "0x976FB70", VA = "0x189770770")]
			public static ExportContext New(ZVMBXFNFHDW dependencies, RWDDBETBFKO? progress, CancellationToken cancellationToken)
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
			public TEAIRTFLUOM[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public ZVMBXFNFHDW dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public RWDDBETBFKO progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private YIOJPLAXMNH.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private ExportContext <ctx>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private Queue<(NodeBuilder parentNode, TEAIRTFLUOM data)> <queue>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			private TEAIRTFLUOM <pv>5__5;

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
			[Cpp2IlInjected.Address(RVA = "0x97783D0", Offset = "0x97777D0", VA = "0x1897783D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9779380", Offset = "0x9778780", VA = "0x189779380", Slot = "5")]
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
			public TEAIRTFLUOM[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public ZVMBXFNFHDW dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public RWDDBETBFKO progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public HMDHSOJSCFJ[] nodeInfos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private YIOJPLAXMNH.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private TEAIRTFLUOM[] <views>5__3;

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
			private YIOJPLAXMNH.ProfileSection <>7__wrap6;

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
			[Cpp2IlInjected.Address(RVA = "0x97793F0", Offset = "0x97787F0", VA = "0x1897793F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x977AEB0", Offset = "0x977A2B0", VA = "0x18977AEB0", Slot = "5")]
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
			public TEAIRTFLUOM pv;

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
			[Cpp2IlInjected.Address(RVA = "0x977AF20", Offset = "0x977A320", VA = "0x18977AF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x977BAC0", Offset = "0x977AEC0", VA = "0x18977BAC0", Slot = "5")]
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
			public RWDDBETBFKO progress;

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
			[Cpp2IlInjected.Address(RVA = "0x977BB20", Offset = "0x977AF20", VA = "0x18977BB20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x977BE80", Offset = "0x977B280", VA = "0x18977BE80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x977BFC0", Offset = "0x977B3C0", VA = "0x18977BFC0")]
		public static bool CVEQUTMETFN(TEAIRTFLUOM? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x977C600", Offset = "0x977BA00", VA = "0x18977C600")]
		public static bool HXJORJIICHV(TEAIRTFLUOM? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x977E0E0", Offset = "0x977D4E0", VA = "0x18977E0E0")]
		private static bool ZTVQQULSKBF(TEAIRTFLUOM? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x977C080", Offset = "0x977B480", VA = "0x18977C080")]
		[AsyncStateMachine(typeof(<BuildR1GlbModel>d__3))]
		public static Task<ModelRoot> DDRXOQMIZRJ(TEAIRTFLUOM[] a, ZVMBXFNFHDW b, [Optional] RWDDBETBFKO? progress, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x977D0F0", Offset = "0x977C4F0", VA = "0x18977D0F0")]
		[AsyncStateMachine(typeof(<BuildR2GlbModel>d__5))]
		public static Task<ModelRoot> SYZSQMOGJJY(TEAIRTFLUOM[] a, HMDHSOJSCFJ[] b, ZVMBXFNFHDW c, [Optional] RWDDBETBFKO? progress, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x977DFD0", Offset = "0x977D3D0", VA = "0x18977DFD0")]
		[AsyncStateMachine(typeof(<WriteGlbModel>d__6))]
		public static Task WriteGlbModel(ModelRoot model, Stream output, [Optional] RWDDBETBFKO? progress)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x977C7F0", Offset = "0x977BBF0", VA = "0x18977C7F0")]
		[AsyncStateMachine(typeof(<ProcessShapesForNode>d__7))]
		private static Task JPGQXPHOMFK(NodeBuilder a, TEAIRTFLUOM b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x977D940", Offset = "0x977CD40", VA = "0x18977D940")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> WDRNNOPBKSW(PrimitiveShapeMeshType a, string b, ShapeColor c, ShapeMaterial d, float e, float3 f, bool g, float h, float3 i, ExportContext j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x977D270", Offset = "0x977C670", VA = "0x18977D270")]
		private static MaterialBuilder TCRQZLVRAYG(ShapeColor a, ShapeMaterial b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x977DF40", Offset = "0x977D340", VA = "0x18977DF40")]
		private static float WGXWLAXBASK(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x977C940", Offset = "0x977BD40", VA = "0x18977C940")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> KAFSKVXRQGD(string a, SIQLDCGEZQD b, MaterialBuilder c, [Optional] float2[]? perCornerUvs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x977C1E0", Offset = "0x977B5E0", VA = "0x18977C1E0")]
		[CompilerGenerated]
		internal static NodeBuilder FONQJAONVGQ(ExportContext a, NodeBuilder b, TEAIRTFLUOM c)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class SKZPNAGPZMW
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9778060", Offset = "0x9777460", VA = "0x189778060")]
		public static bool TAYHYMCBOJR(PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9777D60", Offset = "0x9777160", VA = "0x189777D60")]
		public static void AHASFUVLKGP(PrimitiveShapeMeshType a, float3 b, BevelConfig c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9778080", Offset = "0x9777480", VA = "0x189778080")]
		public static SIQLDCGEZQD TIRLMHOFJIC(SIQLDCGEZQD a, PrimitiveShapeMeshType b, float3 c, float d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class MPMZYAGMSMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x97774C0", Offset = "0x97768C0", VA = "0x1897774C0")]
		public static Vector3 XETBGZLOEKG(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9777500", Offset = "0x9776900", VA = "0x189777500")]
		public static Quaternion XFPQPCYRQFF(quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8B805A0", Offset = "0x8B7F9A0", VA = "0x188B805A0")]
		public static Vector3 YFGBYKXUVMF(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x97774C0", Offset = "0x97768C0", VA = "0x1897774C0")]
		public static Vector3 PXKVNLWRVSS(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9777410", Offset = "0x9776810", VA = "0x189777410")]
		public static quaternion PDPGMADYVSZ(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x97772E0", Offset = "0x97766E0", VA = "0x1897772E0")]
		public static quaternion GCQEZHVAANS(TransformData a)
		{
			return default(quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class ZSOATIYMVMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x977F230", Offset = "0x977E630", VA = "0x18977F230")]
		public static Guid MHITTWJTFKB(ByteString? a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x977F360", Offset = "0x977E760", VA = "0x18977F360")]
		public static string UAXHSPDVWTN(ByteString? self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class QOAOTEHDRLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly PrimitiveShapeMeshType[] HYOKTVZVBEQ;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9777B40", Offset = "0x9776F40", VA = "0x189777B40")]
		public static PrimitiveShapeMeshType TNSHCHBJXTD(ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class DGXOOBAJTPN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9770690", Offset = "0x976FA90", VA = "0x189770690")]
		public static string XSHYPAQYGSS(string a, Dictionary<string, int> b)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.ShapeExport
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal static class WNPSTJEKDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x977E6B0", Offset = "0x977DAB0", VA = "0x18977E6B0")]
		public static SIQLDCGEZQD TRMZDWDYPQC(PrimitiveShapeMeshType a, float3 b, float c, ZVMBXFNFHDW d, Dictionary<PrimitiveShapeMeshType, SIQLDCGEZQD?> primitiveMeshCache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x977E1F0", Offset = "0x977D5F0", VA = "0x18977E1F0")]
		public static float2[] NIROSTVTAAK(SIQLDCGEZQD a, float3 b, bool c, float d, float e, float3 f)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.CurveExport
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class ZVRHYTOIGEX
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly float3 NTOFCEUKASS;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly float3 ABPYQWVYGLO;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x977FF80", Offset = "0x977F380", VA = "0x18977FF80")]
		public static float3 POMYMMWFYRT(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x97803C0", Offset = "0x977F7C0", VA = "0x1897803C0")]
		public static float3 TNSRLZLPNGD(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9780980", Offset = "0x977FD80", VA = "0x189780980")]
		public static quaternion UVMQRNWVURX(float3 a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x977FA00", Offset = "0x977EE00", VA = "0x18977FA00")]
		public static float FWSQQEYAHBB(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9780270", Offset = "0x977F670", VA = "0x189780270")]
		public static float SNDFMLQLHIN(float3 a, float3 b, float3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9780570", Offset = "0x977F970", VA = "0x189780570")]
		public static float3 TPRDBYUBCOM(float3 a, float3 b, float3 c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x977F3C0", Offset = "0x977E7C0", VA = "0x18977F3C0")]
		public static quaternion BNVPXVJHBJK(quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9780130", Offset = "0x977F530", VA = "0x189780130")]
		public static bool RFTDDPWKDHM(float3 a, float3 b, [Out] float3 c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x977FBA0", Offset = "0x977EFA0", VA = "0x18977FBA0")]
		public static float3 JWNHOAAARPZ(bool a, [Optional] quaternion b)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class LAAQBXHAHVZ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9775810", Offset = "0x9774C10", VA = "0x189775810")]
		public static SIQLDCGEZQD CGNBFFRLGYI(CurveShapeData a, ShapeType b, int c, float d, float3 e, float f, float g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9776B80", Offset = "0x9775F80", VA = "0x189776B80")]
		private static void SKEULYXTIUY(float3[] a, float3[] b, float2[] c, int d, float3 e, float3 f, float3 g, float h, bool i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9776740", Offset = "0x9775B40", VA = "0x189776740")]
		private static void OPJVQCHHLEN(ExportCurvePointData a, ExportRingSegment b, float3[] c, float3[] d, float2[] e, int f, float g, float h, float i, float3 j, float k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9776C90", Offset = "0x9776090", VA = "0x189776C90")]
		private static void ZBTBKFANVHN(ExportRingSegment a, float3[] b, float3[] c, float2[] d, int[] e, int f, int g, float3 h, float3x3 i, bool j, float k, int l, bool m, float n, float o, float3 p, float q)
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
	internal static class HDSUVNPSPUO
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
		[Cpp2IlInjected.Address(RVA = "0x9772DE0", Offset = "0x97721E0", VA = "0x189772DE0")]
		public static List<ExportCurvePointData> Generate(IReadOnlyList<float3> positions, IReadOnlyList<float3> normals, IReadOnlyList<float> radii, int configFlags, float heightScale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9772AF0", Offset = "0x9771EF0", VA = "0x189772AF0")]
		private static float3[] DDBTFPXQUYF(IReadOnlyList<float3> a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x97753C0", Offset = "0x97747C0", VA = "0x1897753C0")]
		private static List<ExportCurvePointData> NPBXJFVBMVD(List<PointSrcData> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9774720", Offset = "0x9773B20", VA = "0x189774720")]
		private static bool LWLLUAYORGE(int a, List<ExportCurvePointData> b, List<PointSrcData> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9773480", Offset = "0x9772880", VA = "0x189773480")]
		private static ExportCurvePointData KMFFIGCDTOY(int a, List<PointSrcData> b)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9773A10", Offset = "0x9772E10", VA = "0x189773A10")]
		private static List<ExportCurvePointData> LLCJVQZTQFN(List<PointSrcData> a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9775750", Offset = "0x9774B50", VA = "0x189775750")]
		private static ExportCurvePointData PKANOUDOAVC(PointSrcData a)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x97733F0", Offset = "0x97727F0", VA = "0x1897733F0")]
		private static ExportCurvePointData ILRWZSYXCRX(float3 a, quaternion b, float c)
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
	internal static class WXOSEULSLRW
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x977E850", Offset = "0x977DC50", VA = "0x18977E850")]
		public static ExportRingSegment EEUGGLGKTZJ(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x977EC30", Offset = "0x977E030", VA = "0x18977EC30")]
		public static ExportRingSegment NXSJZMISMYE(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x977EC00", Offset = "0x977E000", VA = "0x18977EC00")]
		public static ExportRingSegment MJXTKNQNFWN()
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x977F1D0", Offset = "0x977E5D0", VA = "0x18977F1D0")]
		public static int YEEZYEDMBHV(int a, int b, bool c, bool d, bool e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x977F180", Offset = "0x977E580", VA = "0x18977F180")]
		public static int XSEKNEDEVIB(int a, int b, bool c, bool d, bool e)
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
