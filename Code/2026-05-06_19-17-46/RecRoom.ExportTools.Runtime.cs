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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x983F850", Offset = "0x983E250", VA = "0x18983F850")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9838950", Offset = "0x9837350", VA = "0x189838950")]
		public static ModelRoot BuildAvatarGlbModel(string sceneName, SYRLWHXBZIK[] nodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x983A000", Offset = "0x9838A00", VA = "0x18983A000")]
		private static MaterialBuilder TCRQZLVRAYG(UQAZPMKTWBU? matData, Dictionary<UQAZPMKTWBU, MaterialBuilder> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9838F80", Offset = "0x9837980", VA = "0x189838F80")]
		private static ImageBuilder? EBHYVEMMZAT(byte[]? a, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x983A810", Offset = "0x9839210", VA = "0x18983A810")]
		private static float WGXWLAXBASK(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9839890", Offset = "0x9838290", VA = "0x189839890")]
		private static IMeshBuilder<MaterialBuilder> KAFSKVXRQGD(string a, SIQLDCGEZQD b, MaterialBuilder c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9838FE0", Offset = "0x98379E0", VA = "0x189838FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98456A0", Offset = "0x98440A0", VA = "0x1898456A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9841810", Offset = "0x9840210", VA = "0x189841810")]
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
			[Cpp2IlInjected.Address(RVA = "0x9838420", Offset = "0x9836E20", VA = "0x189838420")]
			get
			{
				return default(ColorRGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static ColorRGB QKIQGGAEXJL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x103B640", Offset = "0x103A040", VA = "0x18103B640")]
			get
			{
				return default(ColorRGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B710F0", Offset = "0x2B6FAF0", VA = "0x182B710F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x984A250", Offset = "0x9848C50", VA = "0x18984A250")]
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
		[Cpp2IlInjected.Address(RVA = "0xEAEB30", Offset = "0xEAD530", VA = "0x180EAEB30")]
		public MaterialExportKey(ShapeColor shapeColor, ShapeMaterial shapeMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x141B360", Offset = "0x1419D60", VA = "0x18141B360", Slot = "4")]
		public bool Equals(MaterialExportKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x983F300", Offset = "0x983DD00", VA = "0x18983F300", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x983F390", Offset = "0x983DD90", VA = "0x18983F390", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x983F7E0", Offset = "0x983E1E0", VA = "0x18983F7E0")]
		public MeshBuilderCacheKey(PrimitiveShapeMeshType meshType, MaterialExportKey material, [Optional] float3 bevelScalingRatio, float bevelAuthoredRatio = 0f, [Optional] float3 worldScale, bool dynamicProjection = false, float containerScaleX = 0f, float uvScale = 0f, [Optional] float3 uvOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x983F400", Offset = "0x983DE00", VA = "0x18983F400", Slot = "4")]
		public bool Equals(MeshBuilderCacheKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x983F590", Offset = "0x983DF90", VA = "0x18983F590", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x983F640", Offset = "0x983E040", VA = "0x18983F640", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A214A0", Offset = "0x8A1FEA0", VA = "0x188A214A0")]
		public SIQLDCGEZQD(float3[] a, int[] b, float3[] c, [Optional] float2[]? uv0s, [Optional] float2[]? uv1s)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class WWHDCNGHEQQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string EREWIERIFZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float3 OXYBJKKQMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public quaternion RGSBHVDCEST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float3 UASRRBTTTFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public SIQLDCGEZQD QLORZUMUMRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public UQAZPMKTWBU? EEQKTWQVTXB;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9847FD0", Offset = "0x98469D0", VA = "0x189847FD0")]
		public WWHDCNGHEQQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class UMCDBUXBQDR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public string DZYAJQDXZSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public ImageBuilder? MVRGWIALGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public float2 GVPRWZNHLDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float2 XOJMVANENPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TextureWrapMode EWTRZRRWOZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TextureWrapMode EXJMRLZORHD;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9845650", Offset = "0x9844050", VA = "0x189845650")]
		public UMCDBUXBQDR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum MaterialColorUsage
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		ALBEDO = 1,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		EMISSIVE = 2,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		SPECULAR = 4,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		HOLOGRAPHIC = 8
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum PrimitiveShapeMeshType
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		RR_Box,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		RR_Sphere,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		RR_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		RR_Wedge,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		RR_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		RR_HalfSphere,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		RR_Cone,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		RR_Pipe,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		RR_Donut,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		RR_HalfPipe,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		RR_Diamond,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		ADVANCED_Mound,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		LEGACY_Box,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		ADVANCED_Cube,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		ADVANCED_Sphere,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		ADVANCED_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		ADVANCED_Cone,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		ADVANCED_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		ADVANCED_Octagon,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		ADVANCED_Triangle,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		ADVANCED_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		ADVANCED_QuarterPipe,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		ADVANCED_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		ADVANCED_Dodecahedron,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		ADVANCED_Trihedron,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		ADVANCED_Octahedron,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		RR_QuarterCylinder,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		RR_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		RR_QuarterSphere,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		ADVANCED_Wedge,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		RR_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		RR_Octagon,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		RR_Triangle,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum ShapeColor
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		RED = 0,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		ORANGE = 1,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		YELLOW = 2,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		GREEN = 3,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		DARK_GREEN = 4,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		CYAN = 5,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		BLUE = 6,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		DARK_BLUE = 7,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		PURPLE = 8,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		PINK = 9,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		BROWN = 10,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		WHITE = 11,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		GREY = 12,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		BLACK = 13,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		DARK_ORANGE = 14,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		LIME = 15,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		LIGHT_GREEN = 16,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		AQUAMARINE = 17,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		LIGHT_BLUE = 18,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		LAVENDER = 19,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		MAGENTA = 20,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		SALMON = 21,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		TAN = 22,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		CREAM = 23,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		LIGHT_GREY = 24,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		DARK_GREY = 25,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		NEW_COLOR_0 = 26,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		NEW_COLOR_1 = 27,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		NEW_COLOR_2 = 28,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		NEW_COLOR_3 = 29,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		NEW_COLOR_4 = 30,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		NEW_COLOR_5 = 31,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		NEW_COLOR_6 = 32,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		UNUSED_SEE_COMMENT = 33,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		NEW_COLOR_7 = 34,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		NEW_COLOR_8 = 35,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		NEW_COLOR_9 = 36,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		NEW_COLOR_10 = 37,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		NEW_COLOR_11 = 38,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		NEW_COLOR_12 = 39,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		NEW_COLOR_13 = 40,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		NEW_COLOR_14 = 41,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		NEW_COLOR_15 = 42,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		NEW_COLOR_16 = 43,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		NEW_COLOR_17 = 44,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		NEW_COLOR_18 = 45,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		NEW_COLOR_19 = 46,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		NEW_COLOR_20 = 47,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		NEW_COLOR_21 = 48,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		NEW_COLOR_22 = 49,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		NEW_COLOR_23 = 50,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		NEW_COLOR_24 = 51,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		NEW_COLOR_25 = 52,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		NEW_COLOR_26 = 53,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		NEW_COLOR_27 = 54,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		NEW_COLOR_28 = 55,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		NEW_COLOR_29 = 56,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		NEW_COLOR_30 = 57,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		NEW_COLOR_31 = 58,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		NEW_COLOR_32 = 59,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		NEW_COLOR_33 = 60,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		GENERATED_COLOR_START = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum ShapeMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		INVALID = -1,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		CARDBOARD = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		METAL = 1,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		RUBBER = 2,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		PLASTIC = 3,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		NEON = 4,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		WOOD = 5,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		GLASS = 6,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		ROCK = 7,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICE = 8,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		GOLD = 9,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		SAND = 10,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		LEATHER = 11,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		GRID = 12,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		TILE = 13,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		GRASS = 14,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		BARK = 15,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		CONCRETE = 16,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		SNOW = 17,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		CARPET = 18,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		FABRIC = 19,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		FOIL = 20,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		FLESH = 21,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		GALAXY = 22,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		LAVA = 23,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		WATER = 24,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		CANDY = 25,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		FUR = 26,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		CHAIN_MAIL = 27,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		PLACEHOLDER_14 = 28,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		PLACEHOLDER_15 = 29,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		PLACEHOLDER_16 = 30,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		PLACEHOLDER_18 = 31,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		MAX_VALUE = 31,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		COUNT = 32,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum ShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		CURVE_Tube = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		CURVE_Ribbon = 1,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		LegacyBox = 2,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		RR_Sphere = 3,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		RR_Cylinder = 4,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		LEGACY_Wedge = 5,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		LEGACY_Pyramid = 6,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		LEGACY_TriggerVolumeBox = 7,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		RR_Box = 8,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		LEGACY_RoundedBox = 9,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		RR_Wedge = 10,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		RR_Pyramid = 11,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		RR_HalfSphere = 12,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		RR_Cone = 13,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		RR_Pipe = 14,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		RR_Donut = 15,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		RR_HalfPipe = 16,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		RR_Diamond = 17,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		ADVANCED_Mound = 18,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		ADVANCED_Cube = 19,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		ADVANCED_Sphere = 20,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		ADVANCED_Cylinder = 21,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		ADVANCED_Cone = 22,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		ADVANCED_Pyramid = 23,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		ADVANCED_Octagon = 24,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		ADVANCED_Triangle = 25,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		ADVANCED_Hexagon = 26,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		ADVANCED_QuarterPipe = 27,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		ADVANCED_Pentagon = 28,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		ADVANCED_Dodecahedron = 29,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		ADVANCED_Trihedron = 30,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		ADVANCED_Octahedron = 31,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		RR_QuarterCylinder = 32,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		RR_Pentagon = 33,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		RR_QuarterSphere = 34,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		ADVANCED_Wedge = 35,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		RR_Hexagon = 36,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		RR_Octagon = 37,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		RR_Triangle = 38,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		COUNT = 39,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		MAX_VALUE = 38
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum TextureWrapMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Repeat,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		Clamp,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		Other
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class YIOJPLAXMNH
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public struct ProfileSession : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private readonly string? _outputPath;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x983F8E0", Offset = "0x983E2E0", VA = "0x18983F8E0")]
			internal ProfileSession(string? outputPath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal struct ProfileSection : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private readonly string? _name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private readonly int _depth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private readonly long _startTicks;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x983F8D0", Offset = "0x983E2D0", VA = "0x18983F8D0")]
			internal ProfileSection(string name)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0")]
		public static ProfileSession GYMJYDCNRDR(string? a)
		{
			return default(ProfileSession);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x181AFF0", Offset = "0x18199F0", VA = "0x18181AFF0")]
		internal static ProfileSection Section(string name)
		{
			return default(ProfileSection);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class HMDHSOJSCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string? EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int? CWMVPFDJJHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xDF2400", Offset = "0xDF0E00", VA = "0x180DF2400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public HMDHSOJSCFJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface ZVMBXFNFHDW
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		SIQLDCGEZQD? HQAATRQPZGK(PrimitiveShapeMeshType a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BevelConfig CNTWWSUEDAA();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ZZBUQWVONEV? GetMaterialExportData(ShapeColor shapeColor, ShapeMaterial shapeMaterial);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool AUYCTLZINWU(Guid a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface NPAUVFPBVDQ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<WWHDCNGHEQQ>> QYRZHIAWXFN(SpawnableTemplateData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class WLGDZPBLGOP
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class UPZJURSHWPT
		{
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class RYHPXVYNJRL
			{
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public static readonly Guid PZFZDUBQCIF;

				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public static readonly Guid YCFDAYZJJUH;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private readonly struct ExportContext
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public readonly SceneBuilder SceneBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public readonly ZVMBXFNFHDW Dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public readonly BevelConfig BevelConfig;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public readonly Dictionary<string, int> NodeNameToCountMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public readonly Dictionary<MaterialExportKey, MaterialBuilder> MaterialCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public readonly Dictionary<PrimitiveShapeMeshType, SIQLDCGEZQD?> PrimitiveMeshCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public readonly Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> MeshBuilderCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public readonly RWDDBETBFKO? Progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public readonly OFVQWEIMDZX TimedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public readonly CancellationToken CancellationToken;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9838880", Offset = "0x9837280", VA = "0x189838880")]
			private ExportContext(SceneBuilder sceneBuilder, ZVMBXFNFHDW dependencies, BevelConfig bevelConfig, Dictionary<string, int> nodeNameToCountMap, Dictionary<MaterialExportKey, MaterialBuilder> materialCache, Dictionary<PrimitiveShapeMeshType, SIQLDCGEZQD?> primitiveMeshCache, Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> meshBuilderCache, RWDDBETBFKO? progress, OFVQWEIMDZX timedYielder, CancellationToken cancellationToken)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9838520", Offset = "0x9836F20", VA = "0x189838520")]
			public static ExportContext New(ZVMBXFNFHDW dependencies, RWDDBETBFKO? progress, CancellationToken cancellationToken)
			{
				return default(ExportContext);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <BuildR1GlbModel>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public TEAIRTFLUOM[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public ZVMBXFNFHDW dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public RWDDBETBFKO progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private YIOJPLAXMNH.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private ExportContext <ctx>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Queue<(NodeBuilder parentNode, TEAIRTFLUOM data)> <queue>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private TEAIRTFLUOM <pv>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private NodeBuilder <node>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private int <childViewCount>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private object <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9841860", Offset = "0x9840260", VA = "0x189841860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9842810", Offset = "0x9841210", VA = "0x189842810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <BuildR2GlbModel>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public TEAIRTFLUOM[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public ZVMBXFNFHDW dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public RWDDBETBFKO progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public HMDHSOJSCFJ[] nodeInfos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			private YIOJPLAXMNH.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private TEAIRTFLUOM[] <views>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			private ExportContext <ctx>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private NodeBuilder[] <allNodes>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private bool[] <created>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private YIOJPLAXMNH.ProfileSection <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private NodeBuilder <shapeRootNode>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			private bool <madeProgress>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private int <i>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private object <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9842880", Offset = "0x9841280", VA = "0x189842880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9844340", Offset = "0x9842D40", VA = "0x189844340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private struct <ProcessShapesForNode>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public TEAIRTFLUOM pv;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public ExportContext ctx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public NodeBuilder containerNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private int <shapeCountInContainer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private float3 <containerScale>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private int <shapeIndex>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x98443B0", Offset = "0x9842DB0", VA = "0x1898443B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9844F60", Offset = "0x9843960", VA = "0x189844F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <WriteGlbModel>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public RWDDBETBFKO progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public ModelRoot model;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Stream output;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9845280", Offset = "0x9843C80", VA = "0x189845280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x98455F0", Offset = "0x9843FF0", VA = "0x1898455F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9845730", Offset = "0x9844130", VA = "0x189845730")]
		public static bool CVEQUTMETFN(TEAIRTFLUOM? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9845D70", Offset = "0x9844770", VA = "0x189845D70")]
		public static bool HXJORJIICHV(TEAIRTFLUOM? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9847850", Offset = "0x9846250", VA = "0x189847850")]
		private static bool ZTVQQULSKBF(TEAIRTFLUOM? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x98457F0", Offset = "0x98441F0", VA = "0x1898457F0")]
		[AsyncStateMachine(typeof(<BuildR1GlbModel>d__3))]
		public static Task<ModelRoot> DDRXOQMIZRJ(TEAIRTFLUOM[] a, ZVMBXFNFHDW b, [Optional] RWDDBETBFKO? progress, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9846860", Offset = "0x9845260", VA = "0x189846860")]
		[AsyncStateMachine(typeof(<BuildR2GlbModel>d__5))]
		public static Task<ModelRoot> SYZSQMOGJJY(TEAIRTFLUOM[] a, HMDHSOJSCFJ[] b, ZVMBXFNFHDW c, [Optional] RWDDBETBFKO? progress, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9847740", Offset = "0x9846140", VA = "0x189847740")]
		[AsyncStateMachine(typeof(<WriteGlbModel>d__6))]
		public static Task WriteGlbModel(ModelRoot model, Stream output, [Optional] RWDDBETBFKO? progress)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9845F60", Offset = "0x9844960", VA = "0x189845F60")]
		[AsyncStateMachine(typeof(<ProcessShapesForNode>d__7))]
		private static Task JPGQXPHOMFK(NodeBuilder a, TEAIRTFLUOM b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x98470B0", Offset = "0x9845AB0", VA = "0x1898470B0")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> WDRNNOPBKSW(PrimitiveShapeMeshType a, string b, ShapeColor c, ShapeMaterial d, float e, float3 f, bool g, float h, float3 i, ExportContext j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x98469E0", Offset = "0x98453E0", VA = "0x1898469E0")]
		private static MaterialBuilder TCRQZLVRAYG(ShapeColor a, ShapeMaterial b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98476B0", Offset = "0x98460B0", VA = "0x1898476B0")]
		private static float WGXWLAXBASK(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x98460B0", Offset = "0x9844AB0", VA = "0x1898460B0")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> KAFSKVXRQGD(string a, SIQLDCGEZQD b, MaterialBuilder c, [Optional] float2[]? perCornerUvs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9845950", Offset = "0x9844350", VA = "0x189845950")]
		[CompilerGenerated]
		internal static NodeBuilder FONQJAONVGQ(ExportContext a, NodeBuilder b, TEAIRTFLUOM c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class SPJTAWDWMWL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <WriteGlbModel>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public ModelRoot model;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Stream output;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9844FC0", Offset = "0x98439C0", VA = "0x189844FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9845220", Offset = "0x9843C20", VA = "0x189845220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9840150", Offset = "0x983EB50", VA = "0x189840150")]
		public static ModelRoot BuildGlbModel(string sceneName, IReadOnlyList<WWHDCNGHEQQ> meshExports)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9841720", Offset = "0x9840120", VA = "0x189841720")]
		[AsyncStateMachine(typeof(<WriteGlbModel>d__1))]
		public static Task WriteGlbModel(ModelRoot model, Stream output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9840FD0", Offset = "0x983F9D0", VA = "0x189840FD0")]
		private static MaterialBuilder TCRQZLVRAYG(UQAZPMKTWBU? matData, Dictionary<UQAZPMKTWBU, MaterialBuilder> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9838F80", Offset = "0x9837980", VA = "0x189838F80")]
		private static ImageBuilder? EBHYVEMMZAT(byte[]? a, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9841690", Offset = "0x9840090", VA = "0x189841690")]
		private static float WGXWLAXBASK(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9840770", Offset = "0x983F170", VA = "0x189840770")]
		private static IMeshBuilder<MaterialBuilder> KAFSKVXRQGD(string a, SIQLDCGEZQD b, MaterialBuilder c)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class SKZPNAGPZMW
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x983FE30", Offset = "0x983E830", VA = "0x18983FE30")]
		public static bool TAYHYMCBOJR(PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x983FB30", Offset = "0x983E530", VA = "0x18983FB30")]
		public static void AHASFUVLKGP(PrimitiveShapeMeshType a, float3 b, BevelConfig c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x983FE50", Offset = "0x983E850", VA = "0x18983FE50")]
		public static SIQLDCGEZQD TIRLMHOFJIC(SIQLDCGEZQD a, PrimitiveShapeMeshType b, float3 c, float d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal static class MPMZYAGMSMA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x983F270", Offset = "0x983DC70", VA = "0x18983F270")]
		public static Vector3 XETBGZLOEKG(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x983F2B0", Offset = "0x983DCB0", VA = "0x18983F2B0")]
		public static Quaternion XFPQPCYRQFF(quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8C36D90", Offset = "0x8C35790", VA = "0x188C36D90")]
		public static Vector3 YFGBYKXUVMF(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x983F270", Offset = "0x983DC70", VA = "0x18983F270")]
		public static Vector3 PXKVNLWRVSS(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x983F1C0", Offset = "0x983DBC0", VA = "0x18983F1C0")]
		public static quaternion PDPGMADYVSZ(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x983F090", Offset = "0x983DA90", VA = "0x18983F090")]
		public static quaternion GCQEZHVAANS(TransformData a)
		{
			return default(quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class ZSOATIYMVMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9848A00", Offset = "0x9847400", VA = "0x189848A00")]
		public static Guid MHITTWJTFKB(ByteString? a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9848B30", Offset = "0x9847530", VA = "0x189848B30")]
		public static string UAXHSPDVWTN(ByteString? self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class QOAOTEHDRLF
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly PrimitiveShapeMeshType[] HYOKTVZVBEQ;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x983F8F0", Offset = "0x983E2F0", VA = "0x18983F8F0")]
		public static PrimitiveShapeMeshType TNSHCHBJXTD(ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class DGXOOBAJTPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9838440", Offset = "0x9836E40", VA = "0x189838440")]
		public static string XSHYPAQYGSS(string a, Dictionary<string, int> b)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.ShapeExport
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class WNPSTJEKDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9847E30", Offset = "0x9846830", VA = "0x189847E30")]
		public static SIQLDCGEZQD TRMZDWDYPQC(PrimitiveShapeMeshType a, float3 b, float c, ZVMBXFNFHDW d, Dictionary<PrimitiveShapeMeshType, SIQLDCGEZQD?> primitiveMeshCache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9847970", Offset = "0x9846370", VA = "0x189847970")]
		public static float2[] NIROSTVTAAK(SIQLDCGEZQD a, float3 b, bool c, float d, float e, float3 f)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.CurveExport
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class ZVRHYTOIGEX
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly float3 NTOFCEUKASS;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly float3 ABPYQWVYGLO;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9849750", Offset = "0x9848150", VA = "0x189849750")]
		public static float3 POMYMMWFYRT(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9849B90", Offset = "0x9848590", VA = "0x189849B90")]
		public static float3 TNSRLZLPNGD(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x984A150", Offset = "0x9848B50", VA = "0x18984A150")]
		public static quaternion UVMQRNWVURX(float3 a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x98491D0", Offset = "0x9847BD0", VA = "0x1898491D0")]
		public static float FWSQQEYAHBB(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9849A40", Offset = "0x9848440", VA = "0x189849A40")]
		public static float SNDFMLQLHIN(float3 a, float3 b, float3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9849D40", Offset = "0x9848740", VA = "0x189849D40")]
		public static float3 TPRDBYUBCOM(float3 a, float3 b, float3 c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9848B90", Offset = "0x9847590", VA = "0x189848B90")]
		public static quaternion BNVPXVJHBJK(quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9849900", Offset = "0x9848300", VA = "0x189849900")]
		public static bool RFTDDPWKDHM(float3 a, float3 b, [Out] float3 c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9849370", Offset = "0x9847D70", VA = "0x189849370")]
		public static float3 JWNHOAAARPZ(bool a, [Optional] quaternion b)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class LAAQBXHAHVZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x983D5C0", Offset = "0x983BFC0", VA = "0x18983D5C0")]
		public static SIQLDCGEZQD CGNBFFRLGYI(CurveShapeData a, ShapeType b, int c, float d, float3 e, float f, float g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x983E930", Offset = "0x983D330", VA = "0x18983E930")]
		private static void SKEULYXTIUY(float3[] a, float3[] b, float2[] c, int d, float3 e, float3 f, float3 g, float h, bool i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x983E4F0", Offset = "0x983CEF0", VA = "0x18983E4F0")]
		private static void OPJVQCHHLEN(ExportCurvePointData a, ExportRingSegment b, float3[] c, float3[] d, float2[] e, int f, float g, float h, float i, float3 j, float k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x983EA40", Offset = "0x983D440", VA = "0x18983EA40")]
		private static void ZBTBKFANVHN(ExportRingSegment a, float3[] b, float3[] c, float2[] d, int[] e, int f, int g, float3 h, float3x3 i, bool j, float k, int l, bool m, float n, float o, float3 p, float q)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal struct ExportCurvePointData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public float3x3 Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public float Radius;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal static class HDSUVNPSPUO
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private struct PointSrcData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public float3 Position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public quaternion Rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public float Radius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public quaternion BlendedRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public float BendAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public float BendRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public float DistanceToNext;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x983AB90", Offset = "0x9839590", VA = "0x18983AB90")]
		public static List<ExportCurvePointData> Generate(IReadOnlyList<float3> positions, IReadOnlyList<float3> normals, IReadOnlyList<float> radii, int configFlags, float heightScale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x983A8A0", Offset = "0x98392A0", VA = "0x18983A8A0")]
		private static float3[] DDBTFPXQUYF(IReadOnlyList<float3> a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x983D170", Offset = "0x983BB70", VA = "0x18983D170")]
		private static List<ExportCurvePointData> NPBXJFVBMVD(List<PointSrcData> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x983C4D0", Offset = "0x983AED0", VA = "0x18983C4D0")]
		private static bool LWLLUAYORGE(int a, List<ExportCurvePointData> b, List<PointSrcData> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x983B230", Offset = "0x9839C30", VA = "0x18983B230")]
		private static ExportCurvePointData KMFFIGCDTOY(int a, List<PointSrcData> b)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x983B7C0", Offset = "0x983A1C0", VA = "0x18983B7C0")]
		private static List<ExportCurvePointData> LLCJVQZTQFN(List<PointSrcData> a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x983D500", Offset = "0x983BF00", VA = "0x18983D500")]
		private static ExportCurvePointData PKANOUDOAVC(PointSrcData a)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x983B1A0", Offset = "0x9839BA0", VA = "0x18983B1A0")]
		private static ExportCurvePointData ILRWZSYXCRX(float3 a, quaternion b, float c)
		{
			return default(ExportCurvePointData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal struct ExportRingVertex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public float2 Offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public float2 Normal;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal struct ExportRingSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public ExportRingVertex[] RingVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int[] RingIndices;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal static class WXOSEULSLRW
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9848020", Offset = "0x9846A20", VA = "0x189848020")]
		public static ExportRingSegment EEUGGLGKTZJ(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9848400", Offset = "0x9846E00", VA = "0x189848400")]
		public static ExportRingSegment NXSJZMISMYE(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x98483D0", Offset = "0x9846DD0", VA = "0x1898483D0")]
		public static ExportRingSegment MJXTKNQNFWN()
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x98489A0", Offset = "0x98473A0", VA = "0x1898489A0")]
		public static int YEEZYEDMBHV(int a, int b, bool c, bool d, bool e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9848950", Offset = "0x9847350", VA = "0x189848950")]
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
