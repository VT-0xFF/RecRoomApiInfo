using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core.Creation.Shapes;
using RecRoom.Foundation.Mathematics;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Profiling;
using RecRoom.RendererV1;
using RecRoom.RendererV1.DataProviders;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_NativeMesh_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85C08E0", Offset = "0x85BF6E0", VA = "0x1885C08E0", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal static class ZCGVEQIYGMV
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly Log VCZHBCOZIND;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly Log AROOTMJGHSM;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly Log PRGLOAPXIKO;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly Log CUUKNAYVVAN;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly Log WDUEOMNNYYG;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[BurstCompile]
	public class CompressedNativeMesh
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public CompressedNativeMeshStruct ODXFRGQBPGB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int UYVJPCKIDEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAC6110", Offset = "0xAC4F10", VA = "0x180AC6110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public CompressedNativeMesh()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[BurstCompile]
	public struct CompressedNativeMeshStruct
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct MaterialIndex
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public half textureScale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public ushort colourIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public byte textureIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void GetAllVerts_00000036$PostfixBurstDelegate([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int vertexCount, [In] float3 vertMin, [In] float3 vertScale);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal static class FHZISJHKOOM
		{
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x85BACB0", Offset = "0x85B9AB0", VA = "0x1885BACB0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x85BAE40", Offset = "0x85B9C40", VA = "0x1885BAE40")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x85BAA60", Offset = "0x85B9860", VA = "0x1885BAA60")]
			public unsafe static void Invoke([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int vertexCount, [In] float3 vertMin, [In] float3 vertScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllVerts_0000003D$PostfixBurstDelegate([NoAlias] ushort* dstVerts, [Out] float3 vertMinimum, [Out] float3 vertScale, [In][NoAlias] float3* srcVerts, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal static class ANGYLJUKGXM
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x85AF740", Offset = "0x85AE540", VA = "0x1885AF740")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x85AF8D0", Offset = "0x85AE6D0", VA = "0x1885AF8D0")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x85AF4D0", Offset = "0x85AE2D0", VA = "0x1885AF4D0")]
			public unsafe static void Invoke([NoAlias] ushort* dstVerts, [Out] float3 vertMinimum, [Out] float3 vertScale, [In][NoAlias] float3* srcVerts, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllNormals_0000003F$PostfixBurstDelegate([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class WPCPMGLZYDK
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x85CC8D0", Offset = "0x85CB6D0", VA = "0x1885CC8D0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x85CCA60", Offset = "0x85CB860", VA = "0x1885CCA60")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x85CC660", Offset = "0x85CB460", VA = "0x1885CC660")]
			public unsafe static void Invoke([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void GetAllNormals_00000041$PostfixBurstDelegate([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		internal static class DHLLKYKSXAS
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x85B8C00", Offset = "0x85B7A00", VA = "0x1885B8C00")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x85B8D90", Offset = "0x85B7B90", VA = "0x1885B8D90")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x85B8980", Offset = "0x85B7780", VA = "0x1885B8980")]
			public unsafe static void Invoke([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllUVs_00000048$PostfixBurstDelegate([NoAlias] uint* dstUVs, [Out] float2 uvMinimum, [Out] float2 uvScale, [In][NoAlias] float2* srcUVs, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		internal static class RNLIHPZQYMV
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x85C96C0", Offset = "0x85C84C0", VA = "0x1885C96C0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x85C9850", Offset = "0x85C8650", VA = "0x1885C9850")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x85C9450", Offset = "0x85C8250", VA = "0x1885C9450")]
			public unsafe static void Invoke([NoAlias] uint* dstUVs, [Out] float2 uvMinimum, [Out] float2 uvScale, [In][NoAlias] float2* srcUVs, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void GetUV_00000049$PostfixBurstDelegate([Out] float2 ret, uint compressed, [In] float2 uvMin, [In] float2 uvScale);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class OGPKNWWHJZG
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x85C8650", Offset = "0x85C7450", VA = "0x1885C8650")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x85C87E0", Offset = "0x85C75E0", VA = "0x1885C87E0")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x85C83E0", Offset = "0x85C71E0", VA = "0x1885C83E0")]
			public static void Invoke([Out] float2 ret, uint compressed, [In] float2 uvMin, [In] float2 uvScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void GetAllUVs_0000004B$PostfixBurstDelegate([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int vertexCount, [In] float2 uvMin, [In] float2 uvScale);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		internal static class HRXIFIACFUX
		{
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x85BC4C0", Offset = "0x85BB2C0", VA = "0x1885BC4C0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x85BC650", Offset = "0x85BB450", VA = "0x1885BC650")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x85BC200", Offset = "0x85BB000", VA = "0x1885BC200")]
			public unsafe static void Invoke([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int vertexCount, [In] float2 uvMin, [In] float2 uvScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllTangents_00000052$PostfixBurstDelegate([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal static class VVQNQZGFBPY
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x85CB920", Offset = "0x85CA720", VA = "0x1885CB920")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x85CBAB0", Offset = "0x85CA8B0", VA = "0x1885CBAB0")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x85CB6B0", Offset = "0x85CA4B0", VA = "0x1885CB6B0")]
			public unsafe static void Invoke([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate ushort SetTangent_00000053$PostfixBurstDelegate([In] float4 newVal);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		internal static class DKOGFOKXGVT
		{
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x85B9190", Offset = "0x85B7F90", VA = "0x1885B9190")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x85B9320", Offset = "0x85B8120", VA = "0x1885B9320")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x85B8F10", Offset = "0x85B7D10", VA = "0x1885B8F10")]
			public static ushort Invoke([In] float4 newVal)
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void GetAllTangents_00000055$PostfixBurstDelegate([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class JQTFNJOMNGX
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x85BED90", Offset = "0x85BDB90", VA = "0x1885BED90")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x85BEF20", Offset = "0x85BDD20", VA = "0x1885BEF20")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x85BEB10", Offset = "0x85BD910", VA = "0x1885BEB10")]
			public unsafe static void Invoke([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void GetTangent_0000005B$PostfixBurstDelegate([Out] float4 result, ushort compressed);

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		internal static class MKBOPIBKLJQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x85C0EC0", Offset = "0x85BFCC0", VA = "0x1885C0EC0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x85C1050", Offset = "0x85BFE50", VA = "0x1885C1050")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x85C0C10", Offset = "0x85BFA10", VA = "0x1885C0C10")]
			public static void Invoke([Out] float4 result, ushort compressed)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void CreateAllMaterialIndices_0000005D$PostfixBurstDelegate([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int numData, [Out] int numRLEs, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		internal static class KODINXWQMKO
		{
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x85BFA60", Offset = "0x85BE860", VA = "0x1885BFA60")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x85BFBF0", Offset = "0x85BE9F0", VA = "0x1885BFBF0")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x85BF7C0", Offset = "0x85BE5C0", VA = "0x1885BF7C0")]
			public unsafe static void Invoke([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int numData, [Out] int numRLEs, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void DecodeMaterialIndices_0000005F$PostfixBurstDelegate([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		internal static class SPQFGAXTLJL
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x85C9CE0", Offset = "0x85C8AE0", VA = "0x1885C9CE0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x85C9E70", Offset = "0x85C8C70", VA = "0x1885C9E70")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x85C99D0", Offset = "0x85C87D0", VA = "0x1885C99D0")]
			public unsafe static void Invoke([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate int EncodeIndices_00000067$PostfixBurstDelegate([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int srcIndexCount);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		internal static class KQYEZSMMCWQ
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x85C0030", Offset = "0x85BEE30", VA = "0x1885C0030")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x85C01C0", Offset = "0x85BEFC0", VA = "0x1885C01C0")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x85BFD70", Offset = "0x85BEB70", VA = "0x1885BFD70")]
			public unsafe static int Invoke([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int srcIndexCount)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void DecodeIndices_00000069$PostfixBurstDelegate([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int indexCount);

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		internal static class RKEBLNKXYEO
		{
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x85C9140", Offset = "0x85C7F40", VA = "0x1885C9140")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x85C92D0", Offset = "0x85C80D0", VA = "0x1885C92D0")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x85C8EC0", Offset = "0x85C7CC0", VA = "0x1885C8EC0")]
			public unsafe static void Invoke([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int indexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void DecodeNormal_0000006B$PostfixBurstDelegate([Out] float3 ret, ushort compressed);

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		internal static class GZGCVTKCVDT
		{
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x85BB850", Offset = "0x85BA650", VA = "0x1885BB850")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x85BB9E0", Offset = "0x85BA7E0", VA = "0x1885BB9E0")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x85BB630", Offset = "0x85BA430", VA = "0x1885BB630")]
			public static void Invoke([Out] float3 ret, ushort compressed)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate ushort EncodeNormal_0000006C$PostfixBurstDelegate([In] float3 newVal);

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		internal static class URDKTVUSIAS
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x85CAE20", Offset = "0x85C9C20", VA = "0x1885CAE20")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x85CAFB0", Offset = "0x85C9DB0", VA = "0x1885CAFB0")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x85CAC10", Offset = "0x85C9A10", VA = "0x1885CAC10")]
			public static ushort Invoke([In] float3 newVal)
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ProfilerMarker markerSetupMeshFormat;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker markerCreate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int vertexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int indexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NativeArray<ushort> verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public NativeArray<ushort> normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public NativeArray<ushort> tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NativeArray<uint> uvs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public NativeArray<MaterialIndex> materialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public NativeArray<byte> materialIndexRLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NativeArray<byte> indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float3 vertMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float3 vertScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float2 uvMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float2 uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static long totalIndicesUncompressedBytes;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static long totalIndicesCompressedBytes;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static float averageCompressionRatio;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static bool warnedAboutInefficientIndices;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool SBSQVTEZLGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x85B0790", Offset = "0x85AF590", VA = "0x1885B0790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool AYFFGJINJYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x85B1010", Offset = "0x85AFE10", VA = "0x1885B1010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85B05D0", Offset = "0x85AF3D0", VA = "0x1885B05D0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85B02F0", Offset = "0x85AF0F0", VA = "0x1885B02F0")]
		public static CompressedNativeMeshStruct Create(Allocator allocator, NativeMesh srcMesh)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85AFD20", Offset = "0x85AEB20", VA = "0x1885AFD20")]
		public static CompressedNativeMeshStruct Create(Allocator allocator, NativeArray<float3> srcVerts, NativeArray<float3> srcNormals, NativeArray<float2> srcUVs, NativeArray<float4> srcMaterialIndices, bool hasTangents, NativeArray<float4> srcTangents, NativeArray<int> srcIndices, int vertexCount, int firstVertex, int indexCount, int firstIndex)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85B1E40", Offset = "0x85B0C40", VA = "0x1885B1E40")]
		public void XQUFQTOWCVY(NativeMesh a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85AFB00", Offset = "0x85AE900", VA = "0x1885AFB00")]
		public long BDQGGYODUVK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85B1C20", Offset = "0x85B0A20", VA = "0x1885B1C20")]
		public long UEZJECZDDNT(NativeMesh.UnityMeshFormat a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85B07D0", Offset = "0x85AF5D0", VA = "0x1885B07D0")]
		private void EVCVCFHUUWJ(int a, int b, Allocator c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x85B0C90", Offset = "0x85AFA90", VA = "0x1885B0C90")]
		private void LHAJAOVVVQJ(NativeArray<float3> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85B0C80", Offset = "0x85AFA80", VA = "0x1885B0C80")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllVerts_00000036$PostfixBurstDelegate))]
		private unsafe static void LHAJAOVVVQJ([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int a, [In] float3 vertMin, [In] float3 vertScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85B0A50", Offset = "0x85AF850", VA = "0x1885B0A50")]
		private void ILCJQRSJZIV(NativeArray<float3> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85B0A40", Offset = "0x85AF840", VA = "0x1885B0A40")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllVerts_0000003D$PostfixBurstDelegate))]
		private unsafe static void ILCJQRSJZIV([NoAlias] ushort* dstVerts, [Out] float3 a, [Out] float3 b, [In][NoAlias] float3* srcVerts, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x85B17B0", Offset = "0x85B05B0", VA = "0x1885B17B0")]
		private void RXDBSZPCZHL(NativeArray<float3> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85B17A0", Offset = "0x85B05A0", VA = "0x1885B17A0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllNormals_0000003F$PostfixBurstDelegate))]
		private unsafe static void RXDBSZPCZHL([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85B16D0", Offset = "0x85B04D0", VA = "0x1885B16D0")]
		private void RQVPGLRXMVX(NativeArray<float3> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85B1790", Offset = "0x85B0590", VA = "0x1885B1790")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllNormals_00000041$PostfixBurstDelegate))]
		private unsafe static void RQVPGLRXMVX([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85B0F10", Offset = "0x85AFD10", VA = "0x1885B0F10")]
		private void OKCQPYGWNLT(NativeArray<float2> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85B1000", Offset = "0x85AFE00", VA = "0x1885B1000")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllUVs_00000048$PostfixBurstDelegate))]
		private unsafe static void OKCQPYGWNLT([NoAlias] uint* dstUVs, [Out] float2 a, [Out] float2 b, [In][NoAlias] float2* srcUVs, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85B0D80", Offset = "0x85AFB80", VA = "0x1885B0D80")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetUV_00000049$PostfixBurstDelegate))]
		private static void MBXTOTQWLHN([Out] float2 a, uint b, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85B1D40", Offset = "0x85B0B40", VA = "0x1885B1D40")]
		private void WYPTRIOMNMV(NativeArray<float2> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85B1E30", Offset = "0x85B0C30", VA = "0x1885B1E30")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllUVs_0000004B$PostfixBurstDelegate))]
		private unsafe static void WYPTRIOMNMV([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int a, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85B15B0", Offset = "0x85B03B0", VA = "0x1885B15B0")]
		private void PZSOLCAIXTH(NativeArray<float4> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85B15A0", Offset = "0x85B03A0", VA = "0x1885B15A0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllTangents_00000052$PostfixBurstDelegate))]
		private unsafe static void PZSOLCAIXTH([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85AFD10", Offset = "0x85AEB10", VA = "0x1885AFD10")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetTangent_00000053$PostfixBurstDelegate))]
		private static ushort CYZMEEJGYGF([In] float4 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85B0D90", Offset = "0x85AFB90", VA = "0x1885B0D90")]
		private void NHBBMCXMLRP(NativeArray<float4> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85B0E50", Offset = "0x85AFC50", VA = "0x1885B0E50")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllTangents_00000055$PostfixBurstDelegate))]
		private unsafe static void NHBBMCXMLRP([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85AFD00", Offset = "0x85AEB00", VA = "0x1885AFD00")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetTangent_0000005B$PostfixBurstDelegate))]
		private static void CBZADUMEJAR([Out] float4 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85B1050", Offset = "0x85AFE50", VA = "0x1885B1050")]
		private void PNVFHZQKVXZ(Allocator a, NativeArray<float4> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85B14D0", Offset = "0x85B02D0", VA = "0x1885B14D0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.CreateAllMaterialIndices_0000005D$PostfixBurstDelegate))]
		private unsafe static void PNVFHZQKVXZ([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int a, [Out] int b, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85B2360", Offset = "0x85B1160", VA = "0x1885B2360")]
		private static void ZIFKHEDAPTS(NativeArray<float4> a, NativeArray<MaterialIndex> b, NativeArray<byte> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85B2460", Offset = "0x85B1260", VA = "0x1885B2460")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeMaterialIndices_0000005F$PostfixBurstDelegate))]
		private unsafe static void ZIFKHEDAPTS([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85B2180", Offset = "0x85B0F80", VA = "0x1885B2180")]
		private void XRAAMYXTPTC(Allocator a, NativeArray<int> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85B18A0", Offset = "0x85B06A0", VA = "0x1885B18A0")]
		private static NativeArray<byte> TGSGYMRMZLV(Allocator a, NativeArray<int> b, int c)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85B1890", Offset = "0x85B0690", VA = "0x1885B1890")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.EncodeIndices_00000067$PostfixBurstDelegate))]
		private unsafe static int TGSGYMRMZLV([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85B1B50", Offset = "0x85B0950", VA = "0x1885B1B50")]
		private static void TPJUCNAOOTZ(NativeArray<int> a, NativeArray<byte> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85B1C10", Offset = "0x85B0A10", VA = "0x1885B1C10")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeIndices_00000069$PostfixBurstDelegate))]
		private unsafe static void TPJUCNAOOTZ([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85B0A30", Offset = "0x85AF830", VA = "0x1885B0A30")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeNormal_0000006B$PostfixBurstDelegate))]
		private static void GWCAUGBCEKF([Out] float3 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85B0E60", Offset = "0x85AFC60", VA = "0x1885B0E60")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.EncodeNormal_0000006C$PostfixBurstDelegate))]
		private static ushort NHUBZVHBCJH([In] float3 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85AE5B0", Offset = "0x85AD3B0", VA = "0x1885AE5B0")]
		[BurstCompile]
		internal unsafe static void UWQWBRWGUXO([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int a, [In] float3 vertMin, [In] float3 vertScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85ADA90", Offset = "0x85AC890", VA = "0x1885ADA90")]
		[BurstCompile]
		internal unsafe static void DMGFNXJWQRO([NoAlias] ushort* dstVerts, [Out] float3 a, [Out] float3 b, [In][NoAlias] float3* srcVerts, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85B0E70", Offset = "0x85AFC70", VA = "0x1885B0E70")]
		[BurstCompile]
		internal unsafe static void NZOOIJXMDKU([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85B1C90", Offset = "0x85B0A90", VA = "0x1885B1C90")]
		[BurstCompile]
		internal unsafe static void VCIYHIBCMVW([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85AE810", Offset = "0x85AD610", VA = "0x1885AE810")]
		[BurstCompile]
		internal unsafe static void WDOZPSOIIHO([NoAlias] uint* dstUVs, [Out] float2 a, [Out] float2 b, [In][NoAlias] float2* srcUVs, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85B1690", Offset = "0x85B0490", VA = "0x1885B1690")]
		[BurstCompile]
		internal static void QQXGUKGOLRQ([Out] float2 a, uint b, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85B2280", Offset = "0x85B1080", VA = "0x1885B2280")]
		[BurstCompile]
		internal unsafe static void ZBRVFZHMJGI([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int a, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85B0990", Offset = "0x85AF790", VA = "0x1885B0990")]
		[BurstCompile]
		internal unsafe static void GIKTLZFESGU([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85B0900", Offset = "0x85AF700", VA = "0x1885B0900")]
		[BurstCompile]
		internal static ushort GCXJWUETUJG([In] float4 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85AFA50", Offset = "0x85AE850", VA = "0x1885AFA50")]
		[BurstCompile]
		internal unsafe static void ARMKWPUFZMQ([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85B14E0", Offset = "0x85B02E0", VA = "0x1885B14E0")]
		[BurstCompile]
		internal static void PTNMRTCALKU([Out] float4 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85ADEC0", Offset = "0x85ACCC0", VA = "0x1885ADEC0")]
		[BurstCompile]
		internal unsafe static void PZHFOZUDUIK([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int a, [Out] int b, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85B0B40", Offset = "0x85AF940", VA = "0x1885B0B40")]
		[BurstCompile]
		internal unsafe static void IMRYVYWUNCT([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85AFC00", Offset = "0x85AEA00", VA = "0x1885AFC00")]
		[BurstCompile]
		internal unsafe static int BZGEUCOPUZM([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85B06F0", Offset = "0x85AF4F0", VA = "0x1885B06F0")]
		[BurstCompile]
		internal unsafe static void EDVUFDDBOFE([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85AEAF0", Offset = "0x85AD8F0", VA = "0x1885AEAF0")]
		[BurstCompile]
		internal static void YZLHAWLGMOE([Out] float3 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85AE3F0", Offset = "0x85AD1F0", VA = "0x1885AE3F0")]
		[BurstCompile]
		internal static ushort SKQKMPVIHDO([In] float3 newVal)
		{
			return default(ushort);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[BurstCompile]
	public class NativeMesh : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum UnityMeshFormat
		{
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			FullFloat32,
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			NormTanMatF16,
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			NormTanSn8MatF16,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			NormTanSn8UvMatF16,
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			NormTanOct8MatUi,
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			PosFixedPoint16NormTanOct8MatUi,
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			LAST
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum VertexFormatKeyword
		{
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			_,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			_VERTEX_FORMAT_NORMTANOCT8_MATUINT,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			_VERTEX_FORMAT_POSFIXED16_NORMTANOCT8_MATUINT,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			LAST
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public struct UnityMeshFormatInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public UnityMeshFormat format;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public bool validOnThisPlatform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public int sizeInBytes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[BurstCompile]
		public struct VertexFormat_FullFloat32
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public float3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public float3 normal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public float4 tangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public float2 texUVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float4 materialIndices;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[BurstCompile]
		public struct VertexFormat_NormTanMatF16
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public float3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public half4 normal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public half4 tangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public float2 texUVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public half4 materialIndices;

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[BurstCompile]
		public struct VertexFormat_NormTanSn8MatF16
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public float3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public uint normal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public uint tangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float2 texUVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public half4 materialIndices;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[BurstCompile]
		public struct VertexFormat_NormTanSn8UvMatF16
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public uint normal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public uint tangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public half2 texUVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public half4 materialIndices;

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[BurstCompile]
		public struct VertexFormat_NormTanOct8MatUi
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public uint normalTangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float2 texUVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public uint colorMaterialScaleBitangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public uint bone;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[BurstCompile]
		public struct VertexFormat_PosFixedPoint16NormTanOct8MatUi
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public VertexCompressor.CompressedPositionFixedPoint16 positionBone;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public uint normalTangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float2 texUVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public uint colorMaterialScaleBitangent;

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_NormTanMatF16_00000082$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		internal static class UGMRLWVTJXP
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x85CA900", Offset = "0x85C9700", VA = "0x1885CA900")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x85CAA90", Offset = "0x85C9890", VA = "0x1885CAA90")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x85CA410", Offset = "0x85C9210", VA = "0x1885CA410")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate int FloatToSnorm8_00000083$PostfixBurstDelegate(float x);

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		internal static class VSDGXVLDMSN
		{
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x85CB3C0", Offset = "0x85CA1C0", VA = "0x1885CB3C0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x85CB540", Offset = "0x85CA340", VA = "0x1885CB540")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x85CB130", Offset = "0x85C9F30", VA = "0x1885CB130")]
			public static int Invoke(float x)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate uint FloatToSnorm8_00000084$PostfixBurstDelegate([In] float4 v);

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		internal static class LJXEVWPENLS
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x85C05D0", Offset = "0x85BF3D0", VA = "0x1885C05D0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x85C0760", Offset = "0x85BF560", VA = "0x1885C0760")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x85C0340", Offset = "0x85BF140", VA = "0x1885C0340")]
			public static uint Invoke([In] float4 v)
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate uint FloatToSnorm8_00000085$PostfixBurstDelegate([In] float3 v);

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		internal static class EZAUOKKPTRR
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x85BA690", Offset = "0x85B9490", VA = "0x1885BA690")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x85BA820", Offset = "0x85B9620", VA = "0x1885BA820")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x85BA420", Offset = "0x85B9220", VA = "0x1885BA420")]
			public static uint Invoke([In] float3 v)
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_NormTanSn8MatF16_00000087$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		internal static class EXOEEJWYRTZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x85BA110", Offset = "0x85B8F10", VA = "0x1885BA110")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x85BA2A0", Offset = "0x85B90A0", VA = "0x1885BA2A0")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x85B9D10", Offset = "0x85B8B10", VA = "0x1885B9D10")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_NormTanSn8UvMatF16_00000089$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		internal static class DTSWJFQHDTG
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x85B9880", Offset = "0x85B8680", VA = "0x1885B9880")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x85B9A10", Offset = "0x85B8810", VA = "0x1885B9A10")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x85B94A0", Offset = "0x85B82A0", VA = "0x1885B94A0")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_NormTanOct8MatUi_0000008C$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		internal static class JXUDAMUFVSV
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x85BF4B0", Offset = "0x85BE2B0", VA = "0x1885BF4B0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x85BF640", Offset = "0x85BE440", VA = "0x1885BF640")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x85BF0A0", Offset = "0x85BDEA0", VA = "0x1885BF0A0")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_PosFixedPoint16NormTanOct8MatUi_0000008E$PostfixBurstDelegate([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 positionMin, [Out] float3 positionMax);

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		internal static class ODIUHTJTWSO
		{
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x85C80D0", Offset = "0x85C6ED0", VA = "0x1885C80D0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x85C8260", Offset = "0x85C7060", VA = "0x1885C8260")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x85C7E00", Offset = "0x85C6C00", VA = "0x1885C7E00")]
			public unsafe static void Invoke([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 positionMin, [Out] float3 positionMax)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_FastCopyIndices_00000090$PostfixBurstDelegate(int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class FUFOJGDUZTO
		{
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x85BB1E0", Offset = "0x85B9FE0", VA = "0x1885BB1E0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x85BB360", Offset = "0x85BA160", VA = "0x1885BB360")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x85BAFC0", Offset = "0x85B9DC0", VA = "0x1885BAFC0")]
			public unsafe static void Invoke(int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_FastCopyIndices_00000091$PostfixBurstDelegate(int startIndex, int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class HIJETSEHFAP
		{
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x85BBF10", Offset = "0x85BAD10", VA = "0x1885BBF10")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x85BC090", Offset = "0x85BAE90", VA = "0x1885BC090")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x85BBCE0", Offset = "0x85BAAE0", VA = "0x1885BBCE0")]
			public unsafe static void Invoke(int startIndex, int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void FastAppendIndices_00000093$PostfixBurstDelegate(int destStart, int sourceCount, int indexOffset, [In][NoAlias] int* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		internal static class ZEHDJTCFJJF
		{
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x85D0EE0", Offset = "0x85CFCE0", VA = "0x1885D0EE0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x85D1060", Offset = "0x85CFE60", VA = "0x1885D1060")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x85D0CA0", Offset = "0x85CFAA0", VA = "0x1885D0CA0")]
			public unsafe static void Invoke(int destStart, int sourceCount, int indexOffset, [In][NoAlias] int* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void FindBestUnityMeshFormat_Fast_0000009D$PostfixBurstDelegate(int vertexCount, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		internal static class QMRCNWGZGCS
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x85C8BD0", Offset = "0x85C79D0", VA = "0x1885C8BD0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x85C8D50", Offset = "0x85C7B50", VA = "0x1885C8D50")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x85C8960", Offset = "0x85C7760", VA = "0x1885C8960")]
			public unsafe static void Invoke(int vertexCount, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const int SQLFSGBQCEF = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public NativeList<float3> BWGQVYQBCMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NativeArray<float3> YRRPDDAUQEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NativeArray<float4> TKJKGRLVIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NativeArray<float4> FZTFNXVSSMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public NativeArray<float2> HZRQUJSZKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public NativeList<int> JUKGHIDUBLD;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly VertexAttributeDescriptor[][] UDLNUOXJKYN;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static bool ZJIYCJMAQLK;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static UnityMeshFormatInfo[] PTUOQTXWSFZ;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static VertexAttributeDescriptor[] ZLPSJWGPWCC;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool SBSQVTEZLGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x85C19E0", Offset = "0x85C07E0", VA = "0x1885C19E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int PMEIJCAKRNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x85C7A70", Offset = "0x85C6870", VA = "0x1885C7A70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int YPFNAQAQQSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x85C1E80", Offset = "0x85C0C80", VA = "0x1885C1E80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AYFFGJINJYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x85C3A20", Offset = "0x85C2820", VA = "0x1885C3A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85C1990", Offset = "0x85C0790", VA = "0x1885C1990")]
		public static VertexFormatKeyword EBCKOOLKNFS(UnityMeshFormat a)
		{
			return default(VertexFormatKeyword);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85C6210", Offset = "0x85C5010", VA = "0x1885C6210")]
		public static void UHPPLXTAQXO(VertexFormatKeyword a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x85C1890", Offset = "0x85C0690", VA = "0x1885C1890", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x85C1A20", Offset = "0x85C0820", VA = "0x1885C1A20")]
		public void EVCVCFHUUWJ(int a, int b, Allocator c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85C1E00", Offset = "0x85C0C00", VA = "0x1885C1E00")]
		public void FUUHBNHZIGC(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85C3410", Offset = "0x85C2210", VA = "0x1885C3410", Slot = "6")]
		public bool MASNUYLYSOI(Mesh a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x85C1460", Offset = "0x85C0260", VA = "0x1885C1460")]
		public bool DYJHQAURQML(Mesh a, bool b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x85C6860", Offset = "0x85C5660", VA = "0x1885C6860")]
		public bool XHPLWTWOPTJ(Mesh a, NativeMesh b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x85C3AC0", Offset = "0x85C28C0", VA = "0x1885C3AC0")]
		public bool QPMOWWAGIJS(Mesh a, NativeMesh b, UnityMeshFormat c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x85C6F50", Offset = "0x85C5D50", VA = "0x1885C6F50")]
		private void ZLGEDSCZKBD(Mesh a, NativeMesh b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x85C7710", Offset = "0x85C6510", VA = "0x1885C7710")]
		public void ZLGEDSCZKBD(NativeArray<ushort> a, NativeArray<VertexFormat_NormTanOct8MatUi> b, Mesh c, NativeMesh d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85C5980", Offset = "0x85C4780", VA = "0x1885C5980")]
		public void TZVUOOTOGNP(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85C1440", Offset = "0x85C0240", VA = "0x1885C1440")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanMatF16_00000082$PostfixBurstDelegate))]
		private unsafe static void BNJFZSQZFKH([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85C6DC0", Offset = "0x85C5BC0", VA = "0x1885C6DC0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000083$PostfixBurstDelegate))]
		public static int YHXYHFPWWSS(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x85C6DE0", Offset = "0x85C5BE0", VA = "0x1885C6DE0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000084$PostfixBurstDelegate))]
		public static uint YHXYHFPWWSS([In] float4 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x85C6DD0", Offset = "0x85C5BD0", VA = "0x1885C6DD0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000085$PostfixBurstDelegate))]
		public static uint YHXYHFPWWSS([In] float3 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x85C4CF0", Offset = "0x85C3AF0", VA = "0x1885C4CF0")]
		public void SQRQOHTIQAG(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85C7A60", Offset = "0x85C6860", VA = "0x1885C7A60")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanSn8MatF16_00000087$PostfixBurstDelegate))]
		private unsafe static void ZNDMOWSTWSM([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85C1ED0", Offset = "0x85C0CD0", VA = "0x1885C1ED0")]
		public void IANLGVHYBAN(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x85C5400", Offset = "0x85C4200", VA = "0x1885C5400")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanSn8UvMatF16_00000089$PostfixBurstDelegate))]
		private unsafe static void SRPPHZTCXOP([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x85C44C0", Offset = "0x85C32C0", VA = "0x1885C44C0")]
		public void RKURPSNRCMI(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x85C48D0", Offset = "0x85C36D0", VA = "0x1885C48D0")]
		public void RKURPSNRCMI(NativeArray<ushort> a, NativeArray<VertexFormat_NormTanOct8MatUi> b, Mesh c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x85C3140", Offset = "0x85C1F40", VA = "0x1885C3140")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanOct8MatUi_0000008C$PostfixBurstDelegate))]
		public unsafe static void KUKIOPXDZSK([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85C3C50", Offset = "0x85C2A50", VA = "0x1885C3C50")]
		public void REMWTSDMTKP(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x85C3A10", Offset = "0x85C2810", VA = "0x1885C3A10")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_PosFixedPoint16NormTanOct8MatUi_0000008E$PostfixBurstDelegate))]
		private unsafe static void OTOTYHECJJX([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 b, [Out] float3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x85C11D0", Offset = "0x85BFFD0", VA = "0x1885C11D0")]
		public void AQIJWBHWJRB(Mesh a, UnityMeshFormat b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x85C6D90", Offset = "0x85C5B90", VA = "0x1885C6D90")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_FastCopyIndices_00000090$PostfixBurstDelegate))]
		private unsafe static void XJQMMOCJNKZ(int a, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x85C6DA0", Offset = "0x85C5BA0", VA = "0x1885C6DA0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_FastCopyIndices_00000091$PostfixBurstDelegate))]
		private unsafe static void XJQMMOCJNKZ(int a, int b, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x85C5620", Offset = "0x85C4420", VA = "0x1885C5620")]
		public void TOTPUJODERO(NativeMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x85C1450", Offset = "0x85C0250", VA = "0x1885C1450")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FastAppendIndices_00000093$PostfixBurstDelegate))]
		private unsafe static void CIWYSZOHTTV(int a, int b, int c, [In][NoAlias] int* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x85C2E20", Offset = "0x85C1C20", VA = "0x1885C2E20")]
		public void JBAYMXLOBWV(NativeMesh a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x85C12B0", Offset = "0x85C00B0", VA = "0x1885C12B0")]
		public long BDQGGYODUVK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85C13E0", Offset = "0x85C01E0", VA = "0x1885C13E0")]
		public static long BDQGGYODUVK(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x85C6090", Offset = "0x85C4E90", VA = "0x1885C6090")]
		public static long UEZJECZDDNT(int a, int b, UnityMeshFormat c)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x85C6130", Offset = "0x85C4F30", VA = "0x1885C6130")]
		public long UEZJECZDDNT(UnityMeshFormat a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x85C4460", Offset = "0x85C3260", VA = "0x1885C4460")]
		public void RGGGTLAVUTB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x85C3430", Offset = "0x85C2230", VA = "0x1885C3430")]
		public static void ONKJMQOXASF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x85C26C0", Offset = "0x85C14C0", VA = "0x1885C26C0")]
		public UnityMeshFormat IRTJGTDHEXO()
		{
			return default(UnityMeshFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85C6DB0", Offset = "0x85C5BB0", VA = "0x1885C6DB0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FindBestUnityMeshFormat_Fast_0000009D$PostfixBurstDelegate))]
		private unsafe static void XKSKPXOBNAX(int a, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x85C6DF0", Offset = "0x85C5BF0", VA = "0x1885C6DF0")]
		public static (int, int) ZCAPODTPVVA(Mesh a)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85C25E0", Offset = "0x85C13E0", VA = "0x1885C25E0")]
		public static int IOIKRCIRPOH(Span<VertexAttributeDescriptor> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x85C2BF0", Offset = "0x85C19F0", VA = "0x1885C2BF0")]
		public static long IYSSHMCSDYW(Mesh a, int b, int c)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x85C2C60", Offset = "0x85C1A60", VA = "0x1885C2C60")]
		public static long IYSSHMCSDYW(Mesh a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public NativeMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x85C3150", Offset = "0x85C1F50", VA = "0x1885C3150")]
		[BurstCompile]
		internal unsafe static void LHLWEPCUNEC([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x85C6730", Offset = "0x85C5530", VA = "0x1885C6730")]
		[BurstCompile]
		internal static int WBGGCTNTEXH(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x85C6670", Offset = "0x85C5470", VA = "0x1885C6670")]
		[BurstCompile]
		internal static uint WBGGCTNTEXH([In] float4 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x85C67E0", Offset = "0x85C55E0", VA = "0x1885C67E0")]
		[BurstCompile]
		internal static uint WBGGCTNTEXH([In] float3 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x85C5410", Offset = "0x85C4210", VA = "0x1885C5410")]
		[BurstCompile]
		internal unsafe static void THWGXRHZRBB([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x85C1C10", Offset = "0x85C0A10", VA = "0x1885C1C10")]
		[BurstCompile]
		internal unsafe static void FKXQTFWLPSG([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x85C2F40", Offset = "0x85C1D40", VA = "0x1885C2F40")]
		[BurstCompile]
		internal unsafe static void JJFMSTCQWDT([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x85C62F0", Offset = "0x85C50F0", VA = "0x1885C62F0")]
		[BurstCompile]
		internal unsafe static void VRAMPEANDJG([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 b, [Out] float3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85C3A90", Offset = "0x85C2890", VA = "0x1885C3A90")]
		[BurstCompile]
		internal unsafe static void QPIJBOTTKTC(int a, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x85C3A60", Offset = "0x85C2860", VA = "0x1885C3A60")]
		[BurstCompile]
		internal unsafe static void QPIJBOTTKTC(int a, int b, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x85C1260", Offset = "0x85C0060", VA = "0x1885C1260")]
		[BurstCompile]
		internal unsafe static void BAAZKYPGCIG(int a, int b, int c, [In][NoAlias] int* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x85AEC30", Offset = "0x85ADA30", VA = "0x1885AEC30")]
		[BurstCompile]
		internal unsafe static void IRAIKWIEOEC(int a, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct PrimitiveShapeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int PrimitiveMeshIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float3 PositionWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public quaternion RotationWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public float3 SizeWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int Bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public float UVScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public float3 UVOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool DynamicProjection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public BevelScalingMode ScalingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float3 ScalingRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float AuthoredBevelRatio;
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class JCDQRFWUBJO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static OAXZEIEXIZW OAXZEIEXIZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NativeList<PrimitiveShapeData> TUOARYVOPDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NativeList<MeshPartInfo> JAGBAECZGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public NativeList<CurveShapeRootData> OVQXXLNQQGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NativeArray<CurvePointData> HHFDRXTTEDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NativeList<MeshPartInfo> TBTJTBFSOHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NativeList<CurvePointOffset> JTEZQBCZOYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private List<NativeArray<CurvePointData>> NSKUEFQMWCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private NativeList<OcclusionData> CDBGQOQVQIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeArray<int> OZTYHQULLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private NativeArray<int> ILWJEHZULUR;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private static NativeList<ShapeBatch.CollapseEntry> EMUKSWDUPVV;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int PMEIJCAKRNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAEEC70", Offset = "0xAEDA70", VA = "0x180AEEC70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x13F37C0", Offset = "0x13F25C0", VA = "0x1813F37C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int YPFNAQAQQSH
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xAEECD0", Offset = "0xAEDAD0", VA = "0x180AEECD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x13F2A10", Offset = "0x13F1810", VA = "0x1813F2A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x85BE910", Offset = "0x85BD710", VA = "0x1885BE910")]
		public JCDQRFWUBJO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x85BC7D0", Offset = "0x85BB5D0", VA = "0x1885BC7D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x85BC9A0", Offset = "0x85BB7A0", VA = "0x1885BC9A0")]
		public void Dispose(JobHandle jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x85BD360", Offset = "0x85BC160", VA = "0x1885BD360")]
		public void UEDNGIDYAWM(PrimitiveShapeData a, OcclusionData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x85BCB80", Offset = "0x85BB980", VA = "0x1885BCB80")]
		public void EIHPEJMMWWG(CurveShapeRootData a, NativeArray<CurvePointData> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x85BE7F0", Offset = "0x85BD5F0", VA = "0x1885BE7F0")]
		public JobHandle ZTHTFFLTSZT(NativeMesh a, YOSWIQSKRWV b, float3 c, quaternion d, float e, bool f, int g = 0, int h = 0)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x85BD5F0", Offset = "0x85BC3F0", VA = "0x1885BD5F0")]
		public JobHandle ZTHTFFLTSZT(NativeMesh a, YOSWIQSKRWV b, NativeList<ShapeBatch.CollapseEntry> c, float3 d, quaternion e, float f, bool g, bool h, int i = 0, int j = 0)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x85BCCB0", Offset = "0x85BBAB0", VA = "0x1885BCCB0")]
		public static JobHandle EOTKUPUSZAS(PrimitiveMeshGeneratorData a, NativeMesh b, NativeArray<int> c, PrimitiveShapeData d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x85BD070", Offset = "0x85BBE70", VA = "0x1885BD070")]
		public static JobHandle HWHIVLDPPEY(CurveMeshGeneratorData a, NativeMesh b, CurveShapeRootData c, NativeArray<CurvePointData> d, int e, int f, JobHandle g)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class CrowdBatch
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal struct SingleMeshData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public MeshRenderer renderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public YGDZZDVWPJE.MinimalMeshData meshData;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x543B490", Offset = "0x543A290", VA = "0x18543B490")]
			public SingleMeshData(MeshRenderer renderer, YGDZZDVWPJE.MinimalMeshData meshData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x85CA2F0", Offset = "0x85C90F0", VA = "0x1885CA2F0")]
			public static implicit operator SingleMeshData((MeshRenderer, YGDZZDVWPJE.MinimalMeshData) tuple)
			{
				return default(SingleMeshData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private static readonly ProfilerMarker UGQCROIRURF;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly ProfilerMarker MYRQENPOJDV;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static readonly ProfilerMarker IZEKVAOUZRK;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly ProfilerMarker DHRZCITQOWC;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x85B2620", Offset = "0x85B1420", VA = "0x1885B2620")]
		internal void GNKPJYWGQZA(GameObject a, YGDZZDVWPJE.CrowdAABB b, List<SingleMeshData> c, Material d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C20", Offset = "0x85B3A20", VA = "0x1885B4C20")]
		internal void QANVPRELWAI(GameObject a, YGDZZDVWPJE.CrowdAABB b, List<SingleMeshData> c, List<LODGroup> d, Material e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x85B5430", Offset = "0x85B4230", VA = "0x1885B5430")]
		private MeshRenderer TDIWYUBDPXH(YGDZZDVWPJE.CrowdAABB a, Material b, List<SingleMeshData> c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x85B2FD0", Offset = "0x85B1DD0", VA = "0x1885B2FD0")]
		private List<(List<SingleMeshData>, float)> LSZPOFWWYYN(YGDZZDVWPJE.CrowdAABB a, List<LODGroup> b, Material c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x85B3E60", Offset = "0x85B2C60", VA = "0x1885B3E60")]
		private List<List<(List<SingleMeshData>, float)>> NZFILWHBCLO(YGDZZDVWPJE.CrowdAABB a, List<LODGroup> b, Material c, [Out] int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public CrowdBatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x85B2E60", Offset = "0x85B1C60", VA = "0x1885B2E60")]
		[CompilerGenerated]
		internal static (float, int) GUAAOUNSYFP(List<List<(List<SingleMeshData> meshList, float lodTransition)>> gathered, int[] a)
		{
			return default((float, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class CrowdOptimizer
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly ProfilerMarker AIWMRPHKRUM;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly ProfilerMarker AXSYKVEQUCN;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly ProfilerMarker WEYBFSIJTYF;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly ProfilerMarker NVXTHDADIWE;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static readonly ProfilerMarker ZYAGRHGCCCR;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static readonly ProfilerMarker HEHLZAKMMQE;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static readonly ProfilerMarker OYRPNXJAUVK;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly Log GXUPZKYLVER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YGDZZDVWPJE LCRAHUAQQRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private CrowdBatch FGIGMRWLBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Shader AGSVFSZWNFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MaterialPropertyBlock TIYWSYRXVWY;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x85B79B0", Offset = "0x85B67B0", VA = "0x1885B79B0")]
		public static void SMUDTABBNOA(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x85B6D20", Offset = "0x85B5B20", VA = "0x1885B6D20")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x85B6850", Offset = "0x85B5650", VA = "0x1885B6850")]
		public void CGFCAFSPZFJ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x85B6180", Offset = "0x85B4F80", VA = "0x1885B6180")]
		private bool AXMYAKCPBRE(MeshRenderer a, [Out] MeshFilter b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x85B6B20", Offset = "0x85B5920", VA = "0x1885B6B20")]
		private bool GSXZUXLGBVN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x85B7CF0", Offset = "0x85B6AF0", VA = "0x1885B7CF0")]
		private void SXLNITAXFFU(GameObject a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x85B7F00", Offset = "0x85B6D00", VA = "0x1885B7F00")]
		private List<CrowdBatch.SingleMeshData> ZFXYZTYGOVB(int a, [Out] List<LODGroup> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x85B7470", Offset = "0x85B6270", VA = "0x1885B7470")]
		private List<(int, Material)> KJQSXXUIYZY(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x85B6A70", Offset = "0x85B5870", VA = "0x1885B6A70")]
		public void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x85B6300", Offset = "0x85B5100", VA = "0x1885B6300")]
		private bool BPPYVDRDDSC(GameObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x85B8920", Offset = "0x85B7720", VA = "0x1885B8920")]
		public CrowdOptimizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[BurstCompile]
	public class YGDZZDVWPJE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[GenerateTestsForBurstCompatibility]
		public struct CrowdAABB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public float3 max;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public float3 min;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public float surfaceArea;

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x85D7960", Offset = "0x85D6760", VA = "0x1885D7960")]
			public CrowdAABB(Bounds bounds)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x85D7850", Offset = "0x85D6650", VA = "0x1885D7850")]
			public CrowdAABB(float3 max, float3 min)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[GenerateTestsForBurstCompatibility]
		public struct Node
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public CrowdAABB boundingBox;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int meshRendererIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int meshDataIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public float fitScore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public int numVerts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int lodDataIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public int parentIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public int child1Index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public int child2Index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public bool isLeaf;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public struct MinimalMeshData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public Mesh Mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public Matrix4x4 WorldFromLocalMatrix;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public int SubMeshIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[BurstCompile]
		private struct GatherSADeltaJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			[ReadOnly]
			public NativeArray<Node> nodes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			[WriteOnly]
			public NativeArray<float> output;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public int startingIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public CrowdAABB bounds;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x85DA8A0", Offset = "0x85D96A0", VA = "0x1885DA8A0")]
			private float IUNDEYWIAVE(CrowdAABB a, CrowdAABB b)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x85DA690", Offset = "0x85D9490", VA = "0x1885DA690", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly ProfilerMarker DJFHVACZHUI;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly ProfilerMarker OEZWOPPHUMI;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static readonly ProfilerMarker CATDFKJSKDA;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static readonly ProfilerMarker BLILQUHCUZH;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly ProfilerMarker TXMNTOJSRTW;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private static readonly ProfilerMarker VILPWWZCAQM;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private static readonly ProfilerMarker QKSDPRSEOXI;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static readonly ProfilerMarker RRYZISHXYEQ;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static readonly ProfilerMarker EXATKIETDYK;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker BVRNVORPDYO;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker CTZEJYPIHQF;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker CMEKXOJGZRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NativeArray<Node> TCLQQTNODJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public NativeQueue<int> PLAYSXQFRLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int TKOFHYKPDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Dictionary<Material, int> NTWQGUZEXTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public List<MinimalMeshData> QUMQDZNNNHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public List<LODGroup> ZXBDPHQYNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Dictionary<int, MeshRenderer> OVGBZFYUQQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Queue<int> QBAOTHXDQVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Shader KQPRLSDEZBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Shader OOIQCTYJEKN;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x85D0780", Offset = "0x85CF580", VA = "0x1885D0780")]
		public YGDZZDVWPJE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x85CD030", Offset = "0x85CBE30", VA = "0x1885CD030")]
		private void CNRQYDIBTWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x85CFD00", Offset = "0x85CEB00", VA = "0x1885CFD00")]
		public bool VMNYHJRBUFZ(MeshRenderer a, MeshFilter b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x85CEFC0", Offset = "0x85CDDC0", VA = "0x1885CEFC0")]
		public bool VMNYHJRBUFZ(LODGroup a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x85CD610", Offset = "0x85CC410", VA = "0x1885CD610")]
		private bool Contains(MeshRenderer meshRenderer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x85CCF10", Offset = "0x85CBD10", VA = "0x1885CCF10")]
		private int BXODDCDJEWB(MeshRenderer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x85CDB60", Offset = "0x85CC960", VA = "0x1885CDB60")]
		private int GSGJPWUXGGF(LODGroup a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x85CE070", Offset = "0x85CCE70", VA = "0x1885CE070")]
		private int IXIYSXZQDTU(MeshFilter a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x85CCBE0", Offset = "0x85CB9E0", VA = "0x1885CCBE0")]
		private int BGAVERMKGWE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x85D0170", Offset = "0x85CEF70", VA = "0x1885D0170")]
		private static CrowdAABB WJXGITIYLRZ(CrowdAABB a, CrowdAABB b)
		{
			return default(CrowdAABB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x85CE1D0", Offset = "0x85CCFD0", VA = "0x1885CE1D0")]
		private static float KJODEFUALWG(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x85CE2F0", Offset = "0x85CD0F0", VA = "0x1885CE2F0")]
		private int RGMUSCZGYWU(int a, CrowdAABB b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x85CDC20", Offset = "0x85CCA20", VA = "0x1885CDC20")]
		private void HZUBXONDKNT(CrowdAABB a, int b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x85CD1A0", Offset = "0x85CBFA0", VA = "0x1885CD1A0")]
		private void CSGIIFOXZBS(CrowdAABB a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x85CDE50", Offset = "0x85CCC50", VA = "0x1885CDE50")]
		private float IUNDEYWIAVE(CrowdAABB a, CrowdAABB b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x85CD740", Offset = "0x85CC540", VA = "0x1885CD740")]
		private void EOYEHUHJKRS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x85CEB90", Offset = "0x85CD990", VA = "0x1885CEB90")]
		private void Rotate(int indexA, int indexB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x85CE600", Offset = "0x85CD400", VA = "0x1885CE600")]
		private void RWXZHUYNDCW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x85CD690", Offset = "0x85CC490", VA = "0x1885CD690", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct RingVertex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float2 Offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public float2 Normal;
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class NFWRESHRIOP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public NativeArray<RingVertex> AOUFBSRLMQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public NativeArray<int> NAAHZQSUYKD;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int PMEIJCAKRNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xAD4260", Offset = "0xAD3060", VA = "0x180AD4260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int YPFNAQAQQSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xAD3AA0", Offset = "0xAD28A0", VA = "0x180AD3AA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x85DAB40", Offset = "0x85D9940", VA = "0x1885DAB40")]
		public NFWRESHRIOP(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x85DAA00", Offset = "0x85D9800", VA = "0x1885DAA00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x85DAA60", Offset = "0x85D9860", VA = "0x1885DAA60")]
		public void TOTPUJODERO(NFWRESHRIOP a, int b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class QZVPENFDRLY
	{
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static NFWRESHRIOP FTVUDRPGIJX;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static NativeList<MeshPartInfo> LMPHMMHGOFX;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static int[] LXIOZQOQVVW;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static bool JIVZOMCPFGW;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private static Dictionary<int, NFWRESHRIOP> ITAOSAVXNNU;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static Dictionary<int, NFWRESHRIOP> GBLITOLOIYD;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool CFXYEXCYRXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x85DD7C0", Offset = "0x85DC5C0", VA = "0x1885DD7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static NativeList<MeshPartInfo> FUQXSJGJUVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x85DE4D0", Offset = "0x85DD2D0", VA = "0x1885DE4D0")]
			get
			{
				return default(NativeList<MeshPartInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static NFWRESHRIOP JLUWNGUQWIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x85DD360", Offset = "0x85DC160", VA = "0x1885DD360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x85DDE40", Offset = "0x85DCC40", VA = "0x1885DDE40")]
		private static void VLHZMLCDVFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x85DE4A0", Offset = "0x85DD2A0", VA = "0x1885DE4A0")]
		public static int XVUPCIKIDRN(bool a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x85DD400", Offset = "0x85DC200", VA = "0x1885DD400")]
		private static int KXCKQZJPEMX(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x85DD330", Offset = "0x85DC130", VA = "0x1885DD330")]
		private static int ELSYPBDNSTM(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x85DD420", Offset = "0x85DC220", VA = "0x1885DD420")]
		public static int LDHOOCWRRWX(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x85DD4B0", Offset = "0x85DC2B0", VA = "0x1885DD4B0")]
		public static int LRGIQQUPPII(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x85DD6C0", Offset = "0x85DC4C0", VA = "0x1885DD6C0")]
		public static int OYQOYYJVCQB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x85DE560", Offset = "0x85DD360", VA = "0x1885DE560")]
		private static int ZDJKMGSRFDD(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x85DDAE0", Offset = "0x85DC8E0", VA = "0x1885DDAE0")]
		private static int TABCEAHXQZE(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x85DCEB0", Offset = "0x85DBCB0", VA = "0x1885DCEB0")]
		public static int AGCMNKFEAXP(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x85DD630", Offset = "0x85DC430", VA = "0x1885DD630")]
		public static int NKPAIRBIIXS(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x85DD340", Offset = "0x85DC140", VA = "0x1885DD340")]
		public static int GIFOWBOVNNZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x85DD540", Offset = "0x85DC340", VA = "0x1885DD540")]
		public static NFWRESHRIOP MHERVESWBLH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x85DD840", Offset = "0x85DC640", VA = "0x1885DD840")]
		private static NFWRESHRIOP RNVMJUIMDQV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x85DD6D0", Offset = "0x85DC4D0", VA = "0x1885DD6D0")]
		public static NFWRESHRIOP PMPAEJVIFVI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x85DDB00", Offset = "0x85DC900", VA = "0x1885DDB00")]
		private static NFWRESHRIOP TEPEOAKTIWS(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x85DCF20", Offset = "0x85DBD20", VA = "0x1885DCF20")]
		public static void EHCHBPBKVFS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct CurveShapeRootData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int RingTypeIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public float3 PositionWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public quaternion RotationWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public float SizeWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public float HeightScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public int Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int Bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public bool Rounded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public bool Ribbon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public float UVScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public float3 UVOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public bool OldEndCaps;
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct CurvePointOffset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int StartPointIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int PointCount;
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct CurveMeshGeneratorData : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public NativeList<CurveShapeRootData> curveDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public NativeArray<CurvePointData> pointDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public NativeArray<MeshPartInfo> curveDests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public NativeArray<CurvePointOffset> curvePointOffsets;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x85D7BF0", Offset = "0x85D69F0", VA = "0x1885D7BF0")]
		public CurveMeshGeneratorData(NativeArray<CurvePointData> pointDatas, int size = 1, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x85D7B10", Offset = "0x85D6910", VA = "0x1885D7B10", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[BurstCompile]
	public struct CreateNativeMeshFromBatchedCurvesJob : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[ReadOnly]
		private NativeArray<RingVertex> ringVertsBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[ReadOnly]
		private NativeArray<int> ringIndicesBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[ReadOnly]
		private NativeList<MeshPartInfo> ringParts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[ReadOnly]
		private NativeList<CurveShapeRootData> curveDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[ReadOnly]
		private NativeArray<CurvePointData> pointDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[ReadOnly]
		private NativeArray<MeshPartInfo> curveDests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[ReadOnly]
		public NativeArray<CurvePointOffset> curvePointOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[ReadOnly]
		private int destIndexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[ReadOnly]
		private int destVertexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[ReadOnly]
		private float3 rootScaleWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[ReadOnly]
		private quaternion rootRotWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[ReadOnly]
		private float3 rootPosWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float2> destUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> destIndices;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x85D3520", Offset = "0x85D2320", VA = "0x1885D3520")]
		public CreateNativeMeshFromBatchedCurvesJob(JCDQRFWUBJO batchedShapeData, NativeMesh destMesh, float3 rootPositionWS, quaternion rootRotationWS, float rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x85D3320", Offset = "0x85D2120", VA = "0x1885D3320")]
		public CreateNativeMeshFromBatchedCurvesJob(CurveMeshGeneratorData batchedShapeData, NativeMesh destMesh, float3 rootPositionWS, quaternion rootRotationWS, float3 rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x85D31E0", Offset = "0x85D1FE0", VA = "0x1885D31E0")]
		private float3 XSAZDYLATPM(float3 a, Matrix4x4 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x85D2BB0", Offset = "0x85D19B0", VA = "0x1885D2BB0")]
		private float3x3 JTGIPDAAWBH(float3x3 a, float3x3 b)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x85D1910", Offset = "0x85D0710", VA = "0x1885D1910")]
		private float EQZFDSWTFZI(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x85D1920", Offset = "0x85D0720", VA = "0x1885D1920", Slot = "4")]
		public void Execute(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x85D2C30", Offset = "0x85D1A30", VA = "0x1885D2C30")]
		private void OHYTRJFBNCW(int a, float3 b, float3 c, float3 d, float e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x85D2DA0", Offset = "0x85D1BA0", VA = "0x1885D2DA0")]
		private void VTSFOGUMPQH(CurveShapeRootData a, float3 b, float3x3 c, float d, int e, int f, int g, float h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x85D1390", Offset = "0x85D0190", VA = "0x1885D1390")]
		private void BYUADTVAUZL(int a, int b, CurveShapeRootData c, float3 d, float3x3 e, bool f, float g, int h, int i, int j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct PrimitiveMeshGeneratorData : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public NativeList<PrimitiveShapeData> shapeData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public NativeList<MeshPartInfo> shapeDest;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x85DCDC0", Offset = "0x85DBBC0", VA = "0x1885DCDC0")]
		public PrimitiveMeshGeneratorData(int size, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x85DCD40", Offset = "0x85DBB40", VA = "0x1885DCD40", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[BurstCompile]
	public struct CreateNativeMeshFromShapeBatchJob : IJobFor
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		private enum ProjectionAxis
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			X,
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			Y,
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			Z
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[ReadOnly]
		private NativeList<float3> srcVertsBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[ReadOnly]
		private NativeArray<float3> srcNormalsBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[ReadOnly]
		private NativeList<int> srcIndicesBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[ReadOnly]
		private NativeArray<int> srcFaceIndicesBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[ReadOnly]
		private NativeArray<float4> srcTangentsXBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[ReadOnly]
		private NativeArray<float4> srcTangentsYBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[ReadOnly]
		private NativeArray<float4> srcTangentsZBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[ReadOnly]
		private NativeArray<int> srcVertCollapseTargetBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[ReadOnly]
		private NativeList<float3> srcFaceNormalsBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[ReadOnly]
		private NativeList<MeshPartInfo> srcInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[ReadOnly]
		private NativeList<PrimitiveShapeData> shapeData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[ReadOnly]
		private NativeList<MeshPartInfo> shapeDest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[ReadOnly]
		private int destIndexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[ReadOnly]
		private int destVertexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float2> destUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> destVertCollapseTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> destIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[ReadOnly]
		private float3 rootPosWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[ReadOnly]
		private quaternion rootRotWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[ReadOnly]
		private float3 rootScaleWS;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x85D68D0", Offset = "0x85D56D0", VA = "0x1885D68D0")]
		public CreateNativeMeshFromShapeBatchJob(JCDQRFWUBJO batchedShapeData, NativeMesh destMesh, NativeArray<int> destVertCollapseTargetIn, float3 rootPositionWS, quaternion rootRotationWS, float rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x85D66D0", Offset = "0x85D54D0", VA = "0x1885D66D0")]
		public CreateNativeMeshFromShapeBatchJob(PrimitiveMeshGeneratorData data, NativeMesh destMesh, NativeArray<int> destVertCollapseTargetIn, float3 rootPositionWS, quaternion rootRotationWS, float3 rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x85D55B0", Offset = "0x85D43B0", VA = "0x1885D55B0", Slot = "4")]
		public void Execute(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x85D5100", Offset = "0x85D3F00", VA = "0x1885D5100")]
		private void AZUZKRLYBMW(float4x4 a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x85D5540", Offset = "0x85D4340", VA = "0x1885D5540")]
		private ProjectionAxis COALSCABTXB(float3 a)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x85D6680", Offset = "0x85D5480", VA = "0x1885D6680")]
		private float4 QWPGSKVYBBT(ProjectionAxis a, int b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x85D6640", Offset = "0x85D5440", VA = "0x1885D6640")]
		private float2 QARDRZCIXAP(ProjectionAxis a, float3 b)
		{
			return default(float2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct CurveData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public float HeightScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public float4 MaterialAndColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int RingPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public bool Rounded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public bool Ribbon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public float UVScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public float3 UVOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public bool OldEndCaps;
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct CreateNativeMeshFromCurveJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[ReadOnly]
		private NativeArray<RingVertex> ringVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[ReadOnly]
		private NativeArray<int> ringIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[ReadOnly]
		private NativeList<CurvePointData> pointData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[ReadOnly]
		private CurveData curveData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[ReadOnly]
		private float rootScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[ReadOnly]
		private float3x3 rootRot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[ReadOnly]
		private float3 rootPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[ReadOnly]
		private Matrix4x4 curveToRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[ReadOnly]
		private float3x3 curveToRootRot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[ReadOnly]
		private float curveToRootScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[ReadOnly]
		private int destStartVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[ReadOnly]
		private int destStartIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float2> destUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> destIndices;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x85D4FC0", Offset = "0x85D3DC0", VA = "0x1885D4FC0")]
		private float3 XSAZDYLATPM(float3 a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x85D48D0", Offset = "0x85D36D0", VA = "0x1885D48D0")]
		private float3x3 JTGIPDAAWBH(float3x3 a)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x85D3C50", Offset = "0x85D2A50", VA = "0x1885D3C50")]
		private float EQZFDSWTFZI(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x85D3C60", Offset = "0x85D2A60", VA = "0x1885D3C60", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x85D4960", Offset = "0x85D3760", VA = "0x1885D4960")]
		private void OHYTRJFBNCW(int a, float3 b, float3 c, float3 d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x85D4AD0", Offset = "0x85D38D0", VA = "0x1885D4AD0")]
		private void VTSFOGUMPQH(CurvePointData a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x85D3700", Offset = "0x85D2500", VA = "0x1885D3700")]
		private void BYUADTVAUZL(int a, int b, float3 c, float3x3 d, bool e, float f, int g, float h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct CreateNativeMeshFromShapeJob : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		private enum ProjectionAxis
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			X,
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			Y,
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			Z
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[ReadOnly]
		private NativeList<float3> srcVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[ReadOnly]
		private NativeArray<float3> srcNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[ReadOnly]
		private NativeList<int> srcIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[ReadOnly]
		private NativeArray<int> srcFaceIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[ReadOnly]
		private NativeArray<float4> srcTangentsX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[ReadOnly]
		private NativeArray<float4> srcTangentsY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[ReadOnly]
		private NativeArray<float4> srcTangentsZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[ReadOnly]
		private NativeArray<int> srcVertCollapseTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[ReadOnly]
		public NativeList<float3> srcFaceNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[ReadOnly]
		private ShapeInstanceData srcShapeData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[ReadOnly]
		private int destStartVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[ReadOnly]
		private int destStartIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float2> destUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> destVertCollapseTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> destIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[ReadOnly]
		private float3 rootPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[ReadOnly]
		private float3x3 rootRot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[ReadOnly]
		private float rootScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[ReadOnly]
		private float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[ReadOnly]
		private quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[ReadOnly]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x85D6E10", Offset = "0x85D5C10", VA = "0x1885D6E10", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x85D6AE0", Offset = "0x85D58E0", VA = "0x1885D6AE0")]
		private void AZUZKRLYBMW(float4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x85D5540", Offset = "0x85D4340", VA = "0x1885D5540")]
		private ProjectionAxis COALSCABTXB(float3 a)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x85D6680", Offset = "0x85D5480", VA = "0x1885D6680")]
		private float4 QWPGSKVYBBT(ProjectionAxis a, int b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x85D6640", Offset = "0x85D5440", VA = "0x1885D6640")]
		private float2 QARDRZCIXAP(ProjectionAxis a, float3 b)
		{
			return default(float2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct OcclusionData
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public enum OcclusionType
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			Box,
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			Sphere
		}

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static OcclusionData Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public float3x3 Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public float3 Size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public OcclusionType Type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public float3 MinPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float3 MaxPos;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool CDREJRHTSIC
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x85DCAF0", Offset = "0x85DB8F0", VA = "0x1885DCAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float3 BOHBFOCQWDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x85DCB00", Offset = "0x85DB900", VA = "0x1885DCB00")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x85DCC50", Offset = "0x85DBA50", VA = "0x1885DCC50")]
		public OcclusionData(float3 position, quaternion rotation, float3 size, OcclusionType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x85DC8D0", Offset = "0x85DB6D0", VA = "0x1885DC8D0")]
		public float PJSXZUGDDVQ(float3 a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x85DC280", Offset = "0x85DB080", VA = "0x1885DC280")]
		public bool BHTUWGWNOYC(float3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x85DC720", Offset = "0x85DB520", VA = "0x1885DC720")]
		public void LBYCJWYBTOY(float3 a, float3x3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x85DC370", Offset = "0x85DB170", VA = "0x1885DC370")]
		private void BRABHVJLFAP(float3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x85DC490", Offset = "0x85DB290", VA = "0x1885DC490")]
		public void KZESJSBXHVY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct DetectEnclosedTrianglesBatchedJob : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[ReadOnly]
		private NativeList<OcclusionData> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[ReadOnly]
		private NativeList<float3> verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[ReadOnly]
		private NativeList<int> indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> shapeOcclusionDataIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[ReadOnly]
		private NativeList<MeshPartInfo> shapeDest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[ReadOnly]
		private int srcIndexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[ReadOnly]
		private int srcVertexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[ReadOnly]
		private float maxOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[ReadOnly]
		private float minOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<bool> triangleRemoved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<bool> vertexUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float> distance;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x85D89F0", Offset = "0x85D77F0", VA = "0x1885D89F0")]
		public DetectEnclosedTrianglesBatchedJob(NativeMesh mesh, float rootScale, int startIndex, int startVertex, NativeList<OcclusionData> data, NativeArray<int> shapeOcclusionDataIdx, NativeList<MeshPartInfo> shapeDest, YOSWIQSKRWV optimizationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x85D7D20", Offset = "0x85D6B20", VA = "0x1885D7D20", Slot = "4")]
		public void Execute(int shapeIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x85D85F0", Offset = "0x85D73F0", VA = "0x1885D85F0")]
		private bool PIFFSOGUXEL(OcclusionData a, OcclusionData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x85D86B0", Offset = "0x85D74B0", VA = "0x1885D86B0")]
		private bool UMVNSDHKKUX(OcclusionData a, int b, int c, int d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[BurstCompile]
	public struct DetectEnclosedTrianglesJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[ReadOnly]
		private NativeList<OcclusionData> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[ReadOnly]
		private NativeList<float3> verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[ReadOnly]
		private NativeList<int> indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[ReadOnly]
		private int startIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[ReadOnly]
		private int indexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[ReadOnly]
		private int startVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[ReadOnly]
		private int vertexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[ReadOnly]
		private float maxOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[ReadOnly]
		private float minOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[ReadOnly]
		private float3 selfPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[ReadOnly]
		private float3 selfSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[ReadOnly]
		private OcclusionData.OcclusionType selfType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<bool> triangleRemoved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<bool> vertexUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float> distance;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x85D8B30", Offset = "0x85D7930", VA = "0x1885D8B30", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x85D8A80", Offset = "0x85D7880", VA = "0x1885D8A80")]
		private bool BRJAFAAPQFH(OcclusionData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x85D8F80", Offset = "0x85D7D80", VA = "0x1885D8F80")]
		private bool UMVNSDHKKUX(OcclusionData a, int b, int c, int d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[BurstCompile]
	public struct InitializeCollapseListJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private NativeArray<int> vertCollapseTarget;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x1300B60", Offset = "0x12FF960", VA = "0x181300B60")]
		public InitializeCollapseListJob(NativeArray<int> vertCollapseTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x85DA9D0", Offset = "0x85D97D0", VA = "0x1885DA9D0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[BurstCompile]
	public struct FinalizeNativeMeshCollapseListJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private NativeList<ShapeBatch.CollapseEntry> destCollapseList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[ReadOnly]
		private NativeArray<int> srcVertCollapseTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[ReadOnly]
		private int indexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[ReadOnly]
		private int vertexStart;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x85D9370", Offset = "0x85D8170", VA = "0x1885D9370")]
		public FinalizeNativeMeshCollapseListJob(NativeList<ShapeBatch.CollapseEntry> destCollapseList, NativeArray<int> srcVertCollapseTarget, int vertexStart = 0, int indexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x85D92C0", Offset = "0x85D80C0", VA = "0x1885D92C0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class YOSWIQSKRWV : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public NativeArray<bool> LIWZICEPQJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public NativeArray<int> TYNPUTQSMVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public NativeArray<bool> PJNFYCPAPWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public NativeArray<float> IJKEWGEUYLF;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x85E47C0", Offset = "0x85E35C0", VA = "0x1885E47C0")]
		public void EVCVCFHUUWJ(int a, int b, Allocator c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x85E47A0", Offset = "0x85E35A0", VA = "0x1885E47A0")]
		public static long EFADLKDNDBK(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x85E46B0", Offset = "0x85E34B0", VA = "0x1885E46B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x85E45C0", Offset = "0x85E33C0", VA = "0x1885E45C0")]
		public void Dispose(JobHandle jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public YOSWIQSKRWV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[BurstCompile]
	public struct FinalizeNativeMeshOptimizationsJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private NativeList<float3> verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private NativeArray<float3> normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private NativeArray<float4> materialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private NativeArray<float2> uvs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private NativeList<int> indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private NativeArray<int> mapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[ReadOnly]
		private NativeArray<bool> triangleRemoved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[ReadOnly]
		private NativeArray<bool> vertexUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[ReadOnly]
		private int indexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[ReadOnly]
		private int vertexStart;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x85D98A0", Offset = "0x85D86A0", VA = "0x1885D98A0")]
		public FinalizeNativeMeshOptimizationsJob(NativeMesh mesh, YOSWIQSKRWV optimizationData, int vertexStart = 0, int indexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x85D9390", Offset = "0x85D8190", VA = "0x1885D9390", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x85D9830", Offset = "0x85D8630", VA = "0x1885D9830")]
		private void IVIRYISWKPV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class LSOBDTTOXMY
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x384D040", Offset = "0x384BE40", VA = "0x18384D040")]
		public static bool ZXIXSFGXOHM<T>(NativeArray<T> a, int b, Allocator c, NativeArrayOptions d = NativeArrayOptions.ClearMemory, int e = 3) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x384D360", Offset = "0x384C160", VA = "0x18384D360")]
		public static bool ZXIXSFGXOHM<T>(NativeList<T> a, int b, Allocator c) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x384D430", Offset = "0x384C230", VA = "0x18384D430")]
		public static bool ZXIXSFGXOHM<T>(NativeQueue<T> a, Allocator b) where T : struct
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public enum SystemLOD
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		Near,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Far,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Force0,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		Force1,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Force2,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		AllOfThem
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public interface ETBTAFPVNAW
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HGGOQWBPRJT(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int RXLYRFNGEVN(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RRBounds MVCHAGPMVNR();

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float ALNVHGRDZYV();

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FXFMSTEEJGN(SystemLOD a, JCDQRFWUBJO b, int c = -1);

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		int HRNBNWMJWXV(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class ZJUXGBFCDAX
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x85E6030", Offset = "0x85E4E30", VA = "0x1885E6030")]
		public static void EHCHBPBKVFS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class YTDFHYODQIT : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public NativeList<float3> BWGQVYQBCMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public NativeArray<float3> YRRPDDAUQEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public NativeArray<int> KGWDTRLYWDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public NativeArray<float4> RGYYWMFKNFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public NativeArray<float4> RHEFTSZHWRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public NativeArray<float4> RGOLBYRPUJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public NativeArray<int> MMGYJAQCGTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public NativeList<float3> MPGUYIGWYVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public NativeList<int> JUKGHIDUBLD;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int PMEIJCAKRNP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x85E53A0", Offset = "0x85E41A0", VA = "0x1885E53A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int YPFNAQAQQSH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x85E49F0", Offset = "0x85E37F0", VA = "0x1885E49F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int URQHFFMBWBW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x85E4FC0", Offset = "0x85E3DC0", VA = "0x1885E4FC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x85E59B0", Offset = "0x85E47B0", VA = "0x1885E59B0")]
		public YTDFHYODQIT(int a, int b, int c, Allocator d = Allocator.Persistent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x85E5CD0", Offset = "0x85E4AD0", VA = "0x1885E5CD0")]
		public YTDFHYODQIT(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x85E48E0", Offset = "0x85E36E0", VA = "0x1885E48E0", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x85E5010", Offset = "0x85E3E10", VA = "0x1885E5010")]
		public void TOTPUJODERO(YTDFHYODQIT a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x85E53F0", Offset = "0x85E41F0", VA = "0x1885E53F0")]
		private void ZZVOUGHTRHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x85E4A40", Offset = "0x85E3840", VA = "0x1885E4A40")]
		private void HAJBJEPEDNF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct MeshPartInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int StartVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public int VertexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public int StartIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public int IndexCount;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1EF4F30", Offset = "0x1EF3D30", VA = "0x181EF4F30")]
		public MeshPartInfo(int startVertex, int vertexCount, int startIndex, int indexCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class OAXZEIEXIZW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public NativeList<MeshPartInfo> KVHTDCNORAG
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return default(NativeList<MeshPartInfo>);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xC607C0", Offset = "0xC5F5C0", VA = "0x180C607C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public YTDFHYODQIT IOTWTOZJGBT
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xACC810", Offset = "0xACB610", VA = "0x180ACC810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x85DBCA0", Offset = "0x85DAAA0", VA = "0x1885DBCA0")]
		public OAXZEIEXIZW(IEnumerable<YTDFHYODQIT> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x85DBC30", Offset = "0x85DAA30", VA = "0x1885DBC30", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum BevelScalingMode
	{
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		Pyramid
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public struct ShapeInstanceData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public float4 MaterialAndColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public float UVScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public float3 UVOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public bool DynamicProjection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public BevelScalingMode ScalingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public float3 ScalingRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public float AuthoredBevelRatio;
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public static class GBCTTAEWKXN
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static NativeArray<float2> LGUUIHIKDWO;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static NativeArray<float3> EVMOINAXUAL;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static NativeArray<float4> DQXZITOLJFK;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static NativeArray<int> JDTIDBKOWKL;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x85D9920", Offset = "0x85D8720", VA = "0x1885D9920")]
		public static void EHCHBPBKVFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x85D9A40", Offset = "0x85D8840", VA = "0x1885D9A40")]
		public static NativeArray<float2> GTUSJXSQPYS(NativeArray<float2> a, int b, NativeArray<float2> c, int d)
		{
			return default(NativeArray<float2>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x85D9D70", Offset = "0x85D8B70", VA = "0x1885D9D70")]
		public static NativeArray<float3> RBIFSBHLZUX(NativeArray<float3> a, int b, NativeArray<float3> c, int d)
		{
			return default(NativeArray<float3>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x85D9B50", Offset = "0x85D8950", VA = "0x1885D9B50")]
		public static NativeArray<float4> LSARCGSBIMA(NativeArray<float4> a, int b, NativeArray<float4> c, int d)
		{
			return default(NativeArray<float4>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x85D9C60", Offset = "0x85D8A60", VA = "0x1885D9C60")]
		public static NativeArray<int> QPUEENPFFRZ(NativeArray<int> a, int b, NativeArray<int> c, int d)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x377D1A0", Offset = "0x377BFA0", VA = "0x18377D1A0")]
		private static void SCOYISUMPMB<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x377D4A0", Offset = "0x377C2A0", VA = "0x18377D4A0")]
		private static void WDVKQXYNJAC<b>(NativeArray<b> a, int b, NativeArray<b> c, int d, NativeArray<b> e) where b : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[BurstCompile]
	public class VertexCompressor
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct CompressedPositionFixedPoint16
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public ushort x;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public ushort y;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public ushort z;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public ushort window;
		}

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x85E3700", Offset = "0x85E2500", VA = "0x1885E3700")]
		public static uint LKLHVPUZDLO(float a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x85E3310", Offset = "0x85E2110", VA = "0x1885E3310")]
		public static void EABNPCLQYYB(float4 a, float b, [Out] uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x85E3420", Offset = "0x85E2220", VA = "0x1885E3420")]
		public static void EABNPCLQYYB(float4 a, uint b, [Out] uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x85E3890", Offset = "0x85E2690", VA = "0x1885E3890")]
		public static void RMLNOJISGPE(float3 a, float3 b, float4 c, float2 d, float4 e, [Out] NativeMesh.VertexFormat_NormTanOct8MatUi f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x85E3B30", Offset = "0x85E2930", VA = "0x1885E3B30")]
		public static void RMLNOJISGPE(float3 a, float3 b, float4 c, float2 d, float4 e, [Out] NativeMesh.VertexFormat_PosFixedPoint16NormTanOct8MatUi f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x85E3F40", Offset = "0x85E2D40", VA = "0x1885E3F40")]
		public static byte YVWMZIEYZXW(float a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x85E36A0", Offset = "0x85E24A0", VA = "0x1885E36A0")]
		public static ushort KDEUTAFCUBN(float a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x85E3710", Offset = "0x85E2510", VA = "0x1885E3710")]
		public static uint LVFKURTZVLD(float a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x85E3FA0", Offset = "0x85E2DA0", VA = "0x1885E3FA0")]
		public static float2 ZJWWHIOYNYS(float2 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x85E3740", Offset = "0x85E2540", VA = "0x1885E3740")]
		public static float2 MJFXNCBONDW(float3 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x85E3DF0", Offset = "0x85E2BF0", VA = "0x1885E3DF0")]
		public static void SILPNUSEOGN(float3 a, [Out] float3 b, [Out] uint3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x85E34F0", Offset = "0x85E22F0", VA = "0x1885E34F0")]
		public static CompressedPositionFixedPoint16 HEHHNJZTFQB(float3 a)
		{
			return default(CompressedPositionFixedPoint16);
		}
	}
}
namespace RecRoom.Core.Creation.Textures
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public static class TextureScalability
	{
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private static readonly ProfilerMarker AJECDJVOKQU;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public static float SJAIZLOOMHD;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void JCEKUXXRPPF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x85E2E60", Offset = "0x85E1C60", VA = "0x1885E2E60")]
		public static float PQVKTUPNCDM(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x85E2FE0", Offset = "0x85E1DE0", VA = "0x1885E2FE0")]
		public static long XWVONALOJVC(float a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x85E29A0", Offset = "0x85E17A0", VA = "0x1885E29A0")]
		public static void BBVXYDYWCNN(float a)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Quartermaster
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public interface SEQTIKZHKJW
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BBVXYDYWCNN(float a);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		(long, long, int) JNXCIHELTMU(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public static class NUTDYMIKYFT
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		private enum WorkItemTypeEnum
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			ShapesStartTreeGeneration,
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			ShapesTreeRefresh,
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			ShapesUploadMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			ShapesLod012Error
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private class WBGCMJCBYNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public WorkItemTypeEnum QROGATZCDZK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public BatchedMeshRenderer ZZGQULEIDCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public BatchedMesh FFJNLRARJMU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public ShapeBatch ZATTDVPBDWT;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x85E40B0", Offset = "0x85E2EB0", VA = "0x1885E40B0")]
			public void KCTUMKXHGXB([Out] bool a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public WBGCMJCBYNM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private static int AZWTRSILCEA;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private static ObjectPool<WBGCMJCBYNM> GUFLJQOGNCE;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x85DB7B0", Offset = "0x85DA5B0", VA = "0x1885DB7B0")]
		static NUTDYMIKYFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x85DB5D0", Offset = "0x85DA3D0", VA = "0x1885DB5D0")]
		private static void WQPSLFKHCFN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x85DAC00", Offset = "0x85D9A00", VA = "0x1885DAC00")]
		private static void ACRUIHLHOCB([In] QuartermasterWorkItem workItem, [Out] bool a, [Out] bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x85DB2C0", Offset = "0x85DA0C0", VA = "0x1885DB2C0")]
		public static void RQTJMINCTAF(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x85DB130", Offset = "0x85D9F30", VA = "0x1885DB130")]
		public static void OBCZQAATMAM(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x85DB450", Offset = "0x85DA250", VA = "0x1885DB450")]
		public static void WGVBKCELEWN(BatchedMesh a, BatchedMeshRenderer b, long c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x85DAFA0", Offset = "0x85D9DA0", VA = "0x1885DAFA0")]
		public static void KBDKPAIRLWD(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x85DACB0", Offset = "0x85D9AB0", VA = "0x1885DACB0")]
		private static void FTCQLKYZIAC(WorkItemTypeEnum a, ShapeBatch b, BatchedMesh c, BatchedMeshRenderer d, long e, long f, float g, bool h, bool i, float j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public static class QuartermasterManager
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly ProfilerMarker BOWDWNCNKUE;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private static readonly ProfilerMarker BWPNXBBADID;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private static readonly ProfilerMarker OLBIEKWSFPZ;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static readonly ProfilerMarker ZZSVPIETCUF;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public static int TAIYOUFYNWW;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public static int PBMSITXPAWC;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public static int XYVIOHUCMLA;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public static long BOOAYWOQYEE;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public static long SZIZKGKLEHD;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public static long QLWVVADZLBS;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public static long BWFPPUYSQVL;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public static int CZVEKXQLEUL;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public static float TQZYBLOXIYT;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public static bool EJYPBHWCJUK;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public static int BUBZPESWIUH;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public static int HUVOIWBGPDZ;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public static int VAPSXQTHISF;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public static long GQZZHDRXGWU;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public static int NRPANIHRGFR;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public static bool NRGTHJKJNKF;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static uint QDNJIVEXOET;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private static GDQGOBAQJLV XMKUDIULMEP;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static List<uint> IHDFDSZDSSF;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static List<(QuartermasterWorkItem.Execute, QuartermasterWorkItem.Release)> WSZYNKTWKFF;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private static SEQTIKZHKJW VXOTTETMZJI;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private static SEQTIKZHKJW WHTXHAIEGSS;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool IGDRLTXNNOU
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x85E13B0", Offset = "0x85E01B0", VA = "0x1885E13B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void WWIVLVLHKVY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void JCEKUXXRPPF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void WWIVLVLHKVY(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x85E1F60", Offset = "0x85E0D60", VA = "0x1885E1F60")]
		public static void VCMOFTLSWOE(SEQTIKZHKJW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x85E1E10", Offset = "0x85E0C10", VA = "0x1885E1E10")]
		public static void RXIVWSQFPPG(SEQTIKZHKJW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x85E11E0", Offset = "0x85DFFE0", VA = "0x1885E11E0")]
		public static (long, long, long, int, int) GAIEHWAPQPN(long a)
		{
			return default((long, long, long, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x85E1160", Offset = "0x85DFF60", VA = "0x1885E1160")]
		public static void FNZLHYFMUSJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x85DE6C0", Offset = "0x85DD4C0", VA = "0x1885DE6C0")]
		public static void BBVXYDYWCNN(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x85E1FE0", Offset = "0x85E0DE0", VA = "0x1885E1FE0")]
		public static void XNZAFHPYWBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x85E1940", Offset = "0x85E0740", VA = "0x1885E1940")]
		public static long MNYKGOMDLAU(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x85E1E90", Offset = "0x85E0C90", VA = "0x1885E1E90")]
		public static bool SLVAFHCDADI(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x85E1AE0", Offset = "0x85E08E0", VA = "0x1885E1AE0")]
		public static bool PXWOMSHOLXF(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x85E0D80", Offset = "0x85DFB80", VA = "0x1885E0D80")]
		public static float BDTTICTDRWA(long a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x85E1400", Offset = "0x85E0200", VA = "0x1885E1400")]
		public static (long, long, int) JNXCIHELTMU(float a)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x85E2180", Offset = "0x85E0F80", VA = "0x1885E2180")]
		public static void ZXPIBIFUDOE(QuartermasterWorkItem a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x85E1BB0", Offset = "0x85E09B0", VA = "0x1885E1BB0")]
		public static int QQXFYNXNPYB(QuartermasterWorkItem.Execute a, QuartermasterWorkItem.Release b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x85E1880", Offset = "0x85E0680", VA = "0x1885E1880")]
		public static bool KTLIMVBZYXA(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x85E10E0", Offset = "0x85DFEE0", VA = "0x1885E10E0")]
		public static void DVEUMZSMHAC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x85E1D00", Offset = "0x85E0B00", VA = "0x1885E1D00")]
		public static bool RIWMODTLQBV(float a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public enum WorkItemContinuityEnum : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		Instant,
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		Persistent
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public struct QuartermasterWorkItem : IComparable<QuartermasterWorkItem>, IEquatable<QuartermasterWorkItem>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate void Execute([In] QuartermasterWorkItem workItem, [Out] bool taskDone, [Out] bool memoryAndClocksAccountingDone);

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate void Release(object userData);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public WorkItemContinuityEnum continuity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public long bytesNeededToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public long bytesNetIncrease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public float mainThreadClocksNeeded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public bool createsLongJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public bool createsJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public object userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		internal uint id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		internal int workTypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		internal Release release;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public float Priority;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x85E2980", Offset = "0x85E1780", VA = "0x1885E2980", Slot = "4")]
		private int DOVKEVNHOPV(QuartermasterWorkItem a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x85E2970", Offset = "0x85E1770", VA = "0x1885E2970", Slot = "5")]
		private bool DISJSNZEQFI(QuartermasterWorkItem a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class GDQGOBAQJLV
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		public struct QuartermasterWorkItemEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			private List<QuartermasterWorkItem> instantWorkItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private List<QuartermasterWorkItem> persistentWorkItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			private int instantIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			private int persistentIndex;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public QuartermasterWorkItem EPETBDEBHAJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0x85F1FD0", Offset = "0x85F0DD0", VA = "0x1885F1FD0")]
				get
				{
					return default(QuartermasterWorkItem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x85F2150", Offset = "0x85F0F50", VA = "0x1885F2150")]
			public QuartermasterWorkItemEnumerator(List<QuartermasterWorkItem> instantWorkItems, List<QuartermasterWorkItem> persistentWorkItems)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x85F1E80", Offset = "0x85F0C80", VA = "0x1885F1E80")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private List<QuartermasterWorkItem> CMGSSINMUHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private List<QuartermasterWorkItem> DAACIGIBGSI;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int GREWHVQIKRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x85DA120", Offset = "0x85D8F20", VA = "0x1885DA120")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x85D9E80", Offset = "0x85D8C80", VA = "0x1885D9E80")]
		public void Add([In] QuartermasterWorkItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x85DA580", Offset = "0x85D9380", VA = "0x1885DA580")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x85D9F70", Offset = "0x85D8D70", VA = "0x1885D9F70")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x85DA170", Offset = "0x85D8F70", VA = "0x1885DA170")]
		public void JWQIASNRTDX(IEnumerable<uint> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x85DA010", Offset = "0x85D8E10", VA = "0x1885DA010")]
		private static void DPTZUNLWUUK(List<QuartermasterWorkItem> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x85DA470", Offset = "0x85D9270", VA = "0x1885DA470")]
		private void Remove(uint id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x85DA0E0", Offset = "0x85D8EE0", VA = "0x1885DA0E0")]
		public QuartermasterWorkItemEnumerator GetEnumerator()
		{
			return default(QuartermasterWorkItemEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x85DA5E0", Offset = "0x85D93E0", VA = "0x1885DA5E0")]
		public GDQGOBAQJLV()
		{
		}
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class BatchedMesh
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		internal enum ScalabilityStateMesh
		{
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			UninitImmediate,
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			UninitAsync,
			[Cpp2IlInjected.Token(Token = "0x400023B")]
			NoMeshRefresh,
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			Mesh,
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			MeshFrozen,
			[Cpp2IlInjected.Token(Token = "0x400023E")]
			MeshRefresh,
			[Cpp2IlInjected.Token(Token = "0x400023F")]
			LAST_VALUE
		}

		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private static readonly string CEUIBTRLVDM;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static readonly string BZJPCSRINTD;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private static readonly ProfilerMarker JOMXEVCHBNZ;

		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private static readonly ProfilerMarker PKPDASTUWYY;

		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private static readonly ProfilerMarker AJECDJVOKQU;

		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private static readonly ProfilerMarker FOEUDSFXKJE;

		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static readonly ProfilerMarker FJKDNNEBQIS;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static readonly ProfilerMarker JBHOEQNMLZD;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly ProfilerMarker EHRKLXYAKGT;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static readonly ProfilerMarker JIVYQRQJBCR;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static readonly ProfilerMarker SFVGOYDQMRZ;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static readonly ProfilerMarker QGDHPVIWXRP;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly ProfilerMarker QFNMYBBEVJO;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static readonly ProfilerMarker QFSTVHVCEUX;

		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private static readonly ProfilerMarker QFCZDNNKCMW;

		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private static readonly ProfilerMarker QFIGAUHHLYF;

		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private static readonly ProfilerMarker QESLIZZPJQE;

		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private static readonly ProfilerMarker QEXSGGTMTBN;

		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private static readonly ProfilerMarker QHODWQSELTA;

		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private static readonly ProfilerMarker GKEDLCOWAEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		internal readonly List<ShapeBatch> WFJSKIEDKEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private readonly DisposeReminder EUDUBBFREAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private int GLLBVJQTLFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private int FARNREJRLSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private bool USSWSIETWPH;

		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public const bool HDXVCFZFPIN = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public bool DRDAWQSUTIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		internal ScalabilityStateMesh FZKWGXDZJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		internal int HZAPLROHENV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		internal int QBPLSKVXUDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		internal int MTBYZXFTXGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		internal int SEQLLYPKZCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		internal long NSGOULQYKBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		internal long INVRYFJUWVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		internal long VFKENCZJTGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private NativeMesh ODORLYSYYEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private NativeMesh ZQROAEDUQPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private NativeMesh.UnityMeshFormat HBEDKGWNQTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private bool JWEZYHVVIZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private int TVEKMYASBWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private BatchedMeshTessellate ITUSJDSDGZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private float3 IYRQYQVQGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private float PEQCCGNZGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private float EMFRRXTSLRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private float PSQRDGMUYFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private float XOENFNXDLFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private float SJBBNXKGDNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private float EUTFQJMRAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private float3 IISXAHIYWEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private float UCYETBDPZEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private float KDFLXKSTESM;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal Mesh IOTWTOZJGBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C40", Offset = "0xAC7A40", VA = "0x180AC8C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public MeshFilter MDJHQVQBWDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xAD0080", Offset = "0xACEE80", VA = "0x180AD0080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public MeshRenderer PMKDFGNUNFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xACC8A0", Offset = "0xACB6A0", VA = "0x180ACC8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public List<Material> AENLCHKTJNV
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xACC890", Offset = "0xACB690", VA = "0x180ACC890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int HAMMNFQRXDD
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xCE3BB0", Offset = "0xCE29B0", VA = "0x180CE3BB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int PMEIJCAKRNP
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x85EFCC0", Offset = "0x85EEAC0", VA = "0x1885EFCC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int YPFNAQAQQSH
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x85ED710", Offset = "0x85EC510", VA = "0x1885ED710")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x85ED8F0", Offset = "0x85EC6F0", VA = "0x1885ED8F0")]
		public void ICQXHTGYGBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x85ED850", Offset = "0x85EC650", VA = "0x1885ED850")]
		public bool HRETGMQRAAY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x85ED5D0", Offset = "0x85EC3D0", VA = "0x1885ED5D0")]
		private void GHGUMJYZSZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x85ED730", Offset = "0x85EC530", VA = "0x1885ED730")]
		private void HLWTLVZZNYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x85F0F70", Offset = "0x85EFD70", VA = "0x1885F0F70")]
		public BatchedMesh(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x85ED3E0", Offset = "0x85EC1E0", VA = "0x1885ED3E0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x85EF8B0", Offset = "0x85EE6B0", VA = "0x1885EF8B0")]
		private void XSPROZTUBVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x85ED1F0", Offset = "0x85EBFF0", VA = "0x1885ED1F0")]
		private void CreateNewUnityMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x85EFCE0", Offset = "0x85EEAE0", VA = "0x1885EFCE0")]
		private void ZPJHNEQBORO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x85ECAC0", Offset = "0x85EB8C0", VA = "0x1885ECAC0")]
		public Mesh BUBQTXKDDTI(MeshFilter a, Transform b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x85EEC50", Offset = "0x85EDA50", VA = "0x1885EEC50")]
		public void SRTTNCBVBUD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x85ED510", Offset = "0x85EC310", VA = "0x1885ED510")]
		private void GDVALSIKGYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x85EE3F0", Offset = "0x85ED1F0", VA = "0x1885EE3F0")]
		public void KKDXTXQHYDQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x85EFAD0", Offset = "0x85EE8D0", VA = "0x1885EFAD0")]
		public void ZLGWJHBAGFU(ETBTAFPVNAW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x85EF950", Offset = "0x85EE750", VA = "0x1885EF950")]
		public bool YRROEOYVQHH(ETBTAFPVNAW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x85ED110", Offset = "0x85EBF10", VA = "0x1885ED110")]
		public bool Contains(ETBTAFPVNAW meshGenerator)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x85EF5C0", Offset = "0x85EE3C0", VA = "0x1885EF5C0", Slot = "4")]
		public virtual void VCTPIERYSOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x85ED990", Offset = "0x85EC790", VA = "0x1885ED990")]
		public void IRKEFYJPAFA(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x85EE880", Offset = "0x85ED680", VA = "0x1885EE880")]
		public bool PJBFPTAQVAF(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x85ECB30", Offset = "0x85EB930", VA = "0x1885ECB30")]
		public bool CCXDEWODOWQ(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x85EE350", Offset = "0x85ED150", VA = "0x1885EE350")]
		private void KFSNPOBKPSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x85EC110", Offset = "0x85EAF10", VA = "0x1885EC110")]
		public bool BBVXYDYWCNN([In] float4x4 worldFromLocal, BatchedMeshRenderer a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x85EEBA0", Offset = "0x85ED9A0", VA = "0x1885EEBA0")]
		public bool QNOMWUSSBKR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x85EFD80", Offset = "0x85EEB80", VA = "0x1885EFD80")]
		public bool ZVETHUEMGTU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x85EEAB0", Offset = "0x85ED8B0", VA = "0x1885EEAB0")]
		public void QMFXTYVYNXI(NativeMesh a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x85EC9C0", Offset = "0x85EB7C0", VA = "0x1885EC9C0")]
		public (long, long, long) BDQGGYODUVK()
		{
			return default((long, long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAC6130", Offset = "0xAC4F30", VA = "0x180AC6130")]
		public long DREQVKONWQA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x85EE0C0", Offset = "0x85ECEC0", VA = "0x1885EE0C0")]
		private void KCZUWRJOSKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x85EDEB0", Offset = "0x85ECCB0", VA = "0x1885EDEB0")]
		public (long, long, int) JNXCIHELTMU(float a, [In] float4x4 worldFromLocal)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xB40750", Offset = "0xB3F550", VA = "0x180B40750")]
		internal void DZLADKMKBAZ(ScalabilityStateMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x85EEE30", Offset = "0x85EDC30", VA = "0x1885EEE30")]
		internal (float, float, float, float) UKVAEXSUSJL(float a, [In] float4x4 worldFromLocal)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x85EE680", Offset = "0x85ED480", VA = "0x1885EE680")]
		private void OLBEANGKLWB(NativeMesh a, NativeMesh.UnityMeshFormat b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x85EFAB0", Offset = "0x85EE8B0", VA = "0x1885EFAB0")]
		private void YWGWWFPQAAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x85F0880", Offset = "0x85EF680", VA = "0x1885F0880")]
		internal bool ZZYUVSUZPZK(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x85ECD50", Offset = "0x85EBB50", VA = "0x1885ECD50")]
		private void CZIVQJGOBZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x85ED670", Offset = "0x85EC470", VA = "0x1885ED670")]
		private void GQDHSCCBQTU(NativeMesh.UnityMeshFormat a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x85EF6D0", Offset = "0x85EE4D0", VA = "0x1885EF6D0")]
		private void XNCBIEEQHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x85EE490", Offset = "0x85ED290", VA = "0x1885EE490")]
		public long MNYKGOMDLAU(long a, int b)
		{
			return default(long);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class ShapeBatch
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		internal enum ScalabilityStateShapes
		{
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			UninitImmediate,
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			UninitImmediateInJob,
			[Cpp2IlInjected.Token(Token = "0x4000291")]
			UninitAsync,
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			NoMeshLodDataRefresh,
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			NoMeshLodDataInJob,
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			MeshNoData,
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			MeshNoDataFrozen,
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			MeshNoDataRefresh,
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			MeshLodData,
			[Cpp2IlInjected.Token(Token = "0x4000298")]
			MeshLodDataRefresh,
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			MeshLodDataInJob,
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			MeshAllData,
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			MeshAllDataRefresh,
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			MeshAllDataInJob,
			[Cpp2IlInjected.Token(Token = "0x400029D")]
			MeshAllDataInJob2,
			[Cpp2IlInjected.Token(Token = "0x400029E")]
			LAST_VALUE
		}

		[Cpp2IlInjected.Token(Token = "0x200008C")]
		public struct CollapseEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400029F")]
			public int from;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002A0")]
			public int to;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			public float cost;
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		public struct ScaledMesh
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			public CompressedNativeMeshStruct mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			public int triCountGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			public int triCountActual;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			public long memoryBytesUnity;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			public long memoryBytesLocal;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			public float errorActualLocalMeters;

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x85F2210", Offset = "0x85F1010", VA = "0x1885F2210")]
			public void NRKVJJKJWDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x85F2190", Offset = "0x85F0F90", VA = "0x1885F2190")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private static readonly string CEUIBTRLVDM;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private static readonly string BZJPCSRINTD;

		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private static readonly ProfilerMarker JOMXEVCHBNZ;

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private static readonly ProfilerMarker KZOXJIFWLLD;

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private static readonly ProfilerMarker AJECDJVOKQU;

		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private static readonly ProfilerMarker YFGOHRPCXYH;

		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private static readonly ProfilerMarker FOEUDSFXKJE;

		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private static readonly ProfilerMarker FJKDNNEBQIS;

		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private static readonly ProfilerMarker JBHOEQNMLZD;

		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private static readonly ProfilerMarker EHRKLXYAKGT;

		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private static readonly ProfilerMarker JIVYQRQJBCR;

		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private static readonly ProfilerMarker HLKSTLPONUJ;

		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private static readonly ProfilerMarker SFVGOYDQMRZ;

		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private static readonly ProfilerMarker DXWEJDPXFQN;

		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private static readonly ProfilerMarker RBCVKFFJMOP;

		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private static readonly ProfilerMarker VQHWETMWRCQ;

		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private static readonly ProfilerMarker UGCORLRQZRX;

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static readonly ProfilerMarker QGDHPVIWXRP;

		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private static readonly ProfilerMarker QFNMYBBEVJO;

		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private static readonly ProfilerMarker QFSTVHVCEUX;

		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private static readonly ProfilerMarker QFCZDNNKCMW;

		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private static readonly ProfilerMarker QFIGAUHHLYF;

		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private static readonly ProfilerMarker QESLIZZPJQE;

		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private static readonly ProfilerMarker QEXSGGTMTBN;

		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private static readonly ProfilerMarker QHODWQSELTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		internal readonly List<ETBTAFPVNAW> PKLNDBFCIZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		internal BatchedMesh HMOMVWSEJWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private readonly DisposeReminder EUDUBBFREAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		internal int UFKVJIXJIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		internal int TXAKLOUCEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		internal bool WZUKAULSARL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		internal bool DEFKQXESQWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		internal ScalabilityStateShapes DSJIYKXBFGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		internal bool YPUOJAVPVVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		internal float3 TEXRPZYYQUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		internal float3 UWZVDWAKPXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		internal float MXBKKPUFAVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		internal int KHECFEPHASI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		internal int MQJALLYSJIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		internal int JCCIZOTFYZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		internal float AQEFLWAJDEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		internal int HNCFSVBOEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		internal float XXGISLTTGVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		internal float FNEKWDIBWIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		internal int KDPHOJLNEUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		internal long RSQQALDDVTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public int WGOOVDZOKJI;

		[Cpp2IlInjected.Token(Token = "0x4000270")]
		internal const int EIEEQIZKDUF = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		internal float[] LKRPINKUXII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		internal int[] BHKGIKVBILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		internal long[] SVNFTIUAWVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public List<ScaledMesh> IFRCFVZDOYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		internal NativeMesh MRBHUIBIDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		internal long HENZSJKQYRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		internal int MREMIAZOXPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		internal float UJHYWCQYTDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		internal NativeMesh.UnityMeshFormat YOUEWDTGAZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		internal CompressedNativeMeshStruct SFGARSREQPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		internal int KHUWFLINQFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		internal float MBTGPMEDFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		internal long PLARYXCWTYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		internal bool HFGRMNPANRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		internal ScaleMeshToDesiredTriCountsJob DUMODDGNGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		internal JobHandle QOFRFDUSYNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		internal NativeList<CollapseEntry> GIMZTNQGWZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		internal NativeArray<long> WOXKVPMWFTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		internal bool XFIVDULGFQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		internal JobHandle SSLWXGJQIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		internal NativeMesh QBGTARPHFKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		internal YOSWIQSKRWV RILWGUZHDET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		internal NativeList<CollapseEntry> OCMIWCNPOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		internal Transform MUYGYAOKBTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		internal SystemLOD ESAQMIOVWBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		internal long NAHFHGYAZRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		internal long ZQZDNUUYPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		internal long BCRNYTGUYNV;

		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private static bool QFGCOHAWLJJ;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public List<ETBTAFPVNAW> VUEBPTKOMET
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal int PMEIJCAKRNP
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x85FB2D0", Offset = "0x85FA0D0", VA = "0x1885FB2D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x85F5470", Offset = "0x85F4270", VA = "0x1885F5470")]
		internal void ICQXHTGYGBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x85F4890", Offset = "0x85F3690", VA = "0x1885F4890")]
		internal void GHGUMJYZSZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x85FB990", Offset = "0x85FA790", VA = "0x1885FB990")]
		internal ShapeBatch(string name, BatchedMesh parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x85F4410", Offset = "0x85F3210", VA = "0x1885F4410")]
		internal void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x85F4540", Offset = "0x85F3340", VA = "0x1885F4540")]
		internal void GDVALSIKGYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x85F41C0", Offset = "0x85F2FC0", VA = "0x1885F41C0")]
		internal void CJXRCTQYREX(ETBTAFPVNAW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x85FB250", Offset = "0x85FA050", VA = "0x1885FB250")]
		internal bool YUTQPJNZHFM(ETBTAFPVNAW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x85F7420", Offset = "0x85F6220", VA = "0x1885F7420")]
		internal bool LILNAGUVAPI(ETBTAFPVNAW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x85F8FE0", Offset = "0x85F7DE0", VA = "0x1885F8FE0", Slot = "4")]
		internal virtual void VCTPIERYSOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x85F8850", Offset = "0x85F7650", VA = "0x1885F8850")]
		public float SMBIGCVEOXU(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x85F8620", Offset = "0x85F7420", VA = "0x1885F8620")]
		public bool PCUEOIKQWCZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x85F6730", Offset = "0x85F5530", VA = "0x1885F6730")]
		public (CompressedNativeMeshStruct, NativeMesh.UnityMeshFormat) JUTPTHPAMDV()
		{
			return default((CompressedNativeMeshStruct, NativeMesh.UnityMeshFormat));
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x85F8F30", Offset = "0x85F7D30", VA = "0x1885F8F30")]
		internal long USMAIVFASTU()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x85F3260", Offset = "0x85F2060", VA = "0x1885F3260")]
		internal long BKUGKUMSNFB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x85F7B00", Offset = "0x85F6900", VA = "0x1885F7B00")]
		internal bool OUESJQBUGJY(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x85F3380", Offset = "0x85F2180", VA = "0x1885F3380")]
		internal bool CCXDEWODOWQ(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x85F6F50", Offset = "0x85F5D50", VA = "0x1885F6F50")]
		internal void KFSNPOBKPSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x85F2240", Offset = "0x85F1040", VA = "0x1885F2240")]
		internal bool BBVXYDYWCNN([In] float4x4 worldFromLocal, BatchedMeshRenderer a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x85F49D0", Offset = "0x85F37D0", VA = "0x1885F49D0")]
		internal bool GHVFFAKSGTX(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x85F7A60", Offset = "0x85F6860", VA = "0x1885F7A60")]
		internal void NGUJOOSWBJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x85F8820", Offset = "0x85F7620", VA = "0x1885F8820")]
		internal void QMFXTYVYNXI(NativeMesh a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x85FA960", Offset = "0x85F9760", VA = "0x1885FA960")]
		internal void YDXFCKNQSCH(CompressedNativeMeshStruct a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x85F6D60", Offset = "0x85F5B60", VA = "0x1885F6D60")]
		internal void KCZUWRJOSKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x85F62A0", Offset = "0x85F50A0", VA = "0x1885F62A0")]
		internal (long, long, int) JNXCIHELTMU(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xACE320", Offset = "0xACD120", VA = "0x180ACE320")]
		internal void DZLADKMKBAZ(ScalabilityStateShapes a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x85F8940", Offset = "0x85F7740", VA = "0x1885F8940")]
		public static (float, float, float, float) UKVAEXSUSJL(float3 a, float3 b, float c, [In] float4x4 worldFromLocal, float d)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x85F8D20", Offset = "0x85F7B20", VA = "0x1885F8D20")]
		internal (float, float, float, float) UKVAEXSUSJL(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x85F9E30", Offset = "0x85F8C30", VA = "0x1885F9E30")]
		private float XCOTAJGOVUM(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x85F4C60", Offset = "0x85F3A60", VA = "0x1885F4C60")]
		private (int, int, float) HNHGMKTZJVT(float a)
		{
			return default((int, int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x85F7370", Offset = "0x85F6170", VA = "0x1885F7370")]
		internal static float LCBSHZQDOOX(ETBTAFPVNAW a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x85F5480", Offset = "0x85F4280", VA = "0x1885F5480")]
		internal void INKOKTOFZGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x85FA8D0", Offset = "0x85F96D0", VA = "0x1885FA8D0")]
		internal void XNCBIEEQHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x85F9BF0", Offset = "0x85F89F0", VA = "0x1885F9BF0")]
		internal void WTZCPEQXQPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x85F7480", Offset = "0x85F6280", VA = "0x1885F7480")]
		internal long MNYKGOMDLAU(long a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x85F9060", Offset = "0x85F7E60", VA = "0x1885F9060")]
		private void WIYLMHXVYFJ(NativeMesh a, NativeList<CollapseEntry> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x85F51D0", Offset = "0x85F3FD0", VA = "0x1885F51D0")]
		internal void HPDGDHDPCJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x85FABF0", Offset = "0x85F99F0", VA = "0x1885FABF0")]
		public static void YFBAWSNEANJ(NativeList<CollapseEntry> a, NativeMesh b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x85F7A70", Offset = "0x85F6870", VA = "0x1885F7A70")]
		private float NPKAJRBLIKZ(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x85F9E60", Offset = "0x85F8C60", VA = "0x1885F9E60")]
		internal void XGLAAXMYDVR(NativeMesh a, CompressedNativeMesh b, int c, int d, float e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[BurstCompile]
	internal struct BatchedMeshTessellateJob : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct TriToTessellate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			public int ind0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			public int ind1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			public int ind2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40002BD")]
			public float length01;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002BE")]
			public float length12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002BF")]
			public float length20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002C0")]
			public float edgeLengthScalerCorrected;
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		internal struct QuadToTessellate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public int ind0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public int ind1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			public int ind2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40002C4")]
			public int ind3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public float length01;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public float length12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public float length23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public float length30;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			public float edgeLengthScalerCorrected;
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public struct GenerateTessellatedMeshResults
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public int completedNumVerts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public int completedNumIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public float longestPreTessellatedEdgeLength;
		}

		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void TessellateTri_00000270$PostfixBurstDelegate(BatchedMeshTessellateJob bmtj, [In] TriToTessellate tri);

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		internal static class ODDPFOFTTCE
		{
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x85F1B70", Offset = "0x85F0970", VA = "0x1885F1B70")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x85F1D00", Offset = "0x85F0B00", VA = "0x1885F1D00")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x85E9560", Offset = "0x85E8360", VA = "0x1885E9560")]
			public static void Invoke(BatchedMeshTessellateJob bmtj, [In] TriToTessellate tri)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void TessellateQuad_00000271$PostfixBurstDelegate(BatchedMeshTessellateJob bmtj, [In] QuadToTessellate quad);

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		internal static class JBFJWUQUQGJ
		{
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x85F1860", Offset = "0x85F0660", VA = "0x1885F1860")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x85F19F0", Offset = "0x85F07F0", VA = "0x1885F19F0")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x85E7CE0", Offset = "0x85E6AE0", VA = "0x1885E7CE0")]
			public static void Invoke(BatchedMeshTessellateJob bmtj, [In] QuadToTessellate quad)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void BuildNativeMesh_00000274$PostfixBurstDelegate(UnsafeList<int>* resultIndices, UnsafeList<float3>* resultVerts, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* newVerts, UnsafeList<int>* newIndices, UnsafeList<float3>* inMeshVerts, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int numIndices, int numVerts);

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		internal static class FIIODBJNPQR
		{
			[Cpp2IlInjected.Token(Token = "0x40002CF")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x85F1550", Offset = "0x85F0350", VA = "0x1885F1550")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x85F16E0", Offset = "0x85F04E0", VA = "0x1885F16E0")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x85F1200", Offset = "0x85F0000", VA = "0x1885F1200")]
			public unsafe static void Invoke(UnsafeList<int>* resultIndices, UnsafeList<float3>* resultVerts, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* newVerts, UnsafeList<int>* newIndices, UnsafeList<float3>* inMeshVerts, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int numIndices, int numVerts)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public float3 cameraInLocalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public float localToWorldScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public float desiredFactorLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public float minimumEdgeLengthLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public YFTREGURNSC.ScalabilityTessellationModeEnum shapesTessellateMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public bool shapesTessellateAllowQuads;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<TessVert>* newVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<int>* newIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<TriToTessellate>* trisToTessellateCurrent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<TriToTessellate>* trisToTessellateNew;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<QuadToTessellate>* quadsToTessellateCurrent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<QuadToTessellate>* quadsToTessellateNew;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public int numInVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int numInTris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public int maxVertexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public unsafe float3* inMeshVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public unsafe int* inMeshIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public unsafe GenerateTessellatedMeshResults* results;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x85E8070", Offset = "0x85E6E70", VA = "0x1885E8070")]
		private static float FLUDUWKGALC([In] BatchedMeshTessellateJob bmtj, [In] float3 vertPos, float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x85E7EE0", Offset = "0x85E6CE0", VA = "0x1885E7EE0")]
		private static int ELRMEWMNEBI(BatchedMeshTessellateJob a, [Out] TessVert b, [In] TessVert vert0, [In] TessVert vert1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x85E9560", Offset = "0x85E8360", VA = "0x1885E9560")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.TessellateTri_00000270$PostfixBurstDelegate))]
		private static void PWNCHQZNAIF(BatchedMeshTessellateJob a, [In] TriToTessellate tri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x85E7CE0", Offset = "0x85E6AE0", VA = "0x1885E7CE0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.TessellateQuad_00000271$PostfixBurstDelegate))]
		private static void DJIQXVBTCKX(BatchedMeshTessellateJob a, [In] QuadToTessellate quad)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x85E8060", Offset = "0x85E6E60", VA = "0x1885E8060", Slot = "4")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x85E9760", Offset = "0x85E8560", VA = "0x1885E9760")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal void QDGGDTEOHWZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x85E94B0", Offset = "0x85E82B0", VA = "0x1885E94B0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.BuildNativeMesh_00000274$PostfixBurstDelegate))]
		internal unsafe static void NLQBEQOSOLQ(UnsafeList<int>* a, UnsafeList<float3>* b, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* c, UnsafeList<int>* d, UnsafeList<float3>* e, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int f, int g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x85E8B00", Offset = "0x85E7900", VA = "0x1885E8B00")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal static void NAUJUETLCCI(BatchedMeshTessellateJob a, [In] TriToTessellate tri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x85E8100", Offset = "0x85E6F00", VA = "0x1885E8100")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal static void HPSHMHEEQHU(BatchedMeshTessellateJob a, [In] QuadToTessellate quad)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x85EA670", Offset = "0x85E9470", VA = "0x1885EA670")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal unsafe static void ZKGEPAMHZAB(UnsafeList<int>* a, UnsafeList<float3>* b, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* c, UnsafeList<int>* d, UnsafeList<float3>* e, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int f, int g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class BatchedMeshTessellate
	{
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private static readonly ProfilerMarker QHELFUQPFLU;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public const int EZLSJHEVWPZ = 2;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private const int PXFCGYURFSF = 1;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private static int MUANOMIWDIL;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private static Stack<BatchedMeshTessellate> WKXGFDVKUPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private NativeMesh OMLCJKOINRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private NativeList<TessVert> XXWWQGWPBWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private NativeList<int> PUWWCLTMCKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private NativeList<BatchedMeshTessellateJob.TriToTessellate> VQWYJFTDLFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private NativeList<BatchedMeshTessellateJob.TriToTessellate> BPLAUJUEZFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private NativeList<BatchedMeshTessellateJob.QuadToTessellate> XEJYJZSYJCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private NativeList<BatchedMeshTessellateJob.QuadToTessellate> BCSETCANMAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private BatchedMeshTessellateJob KULYHOHREGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private JobHandle HFXKFSCXBIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private BatchedMeshTessellateJob.GenerateTessellatedMeshResults WARPUUBFVVZ;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private const int NWUXQSMWSDF = 65530;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x85EBF80", Offset = "0x85EAD80", VA = "0x1885EBF80")]
		private BatchedMeshTessellate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x85EBAF0", Offset = "0x85EA8F0", VA = "0x1885EBAF0")]
		public void QUJGVBANPXL(NativeMesh a, float3 b, float c, float d, float e, List<ShapeBatch.CollapseEntry> f, Allocator g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x85EB600", Offset = "0x85EA400", VA = "0x1885EB600")]
		public (bool, NativeMesh, float) PDYBFHMHQQE(List<ShapeBatch.CollapseEntry> a, Allocator b, bool c)
		{
			return default((bool, NativeMesh, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x85EAFD0", Offset = "0x85E9DD0", VA = "0x1885EAFD0")]
		public static bool FLULSLQAHUL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x85EB5B0", Offset = "0x85EA3B0", VA = "0x1885EB5B0")]
		public static int OLQCJZJQJPS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x85EB100", Offset = "0x85E9F00", VA = "0x1885EB100")]
		public static int GWEDCFEEDRI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x85EB2E0", Offset = "0x85EA0E0", VA = "0x1885EB2E0")]
		public static BatchedMeshTessellate MEAHXMUFKST()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x85EB060", Offset = "0x85E9E60", VA = "0x1885EB060")]
		internal static void GPQRMOWHBAY(BatchedMeshTessellate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x85EB170", Offset = "0x85E9F70", VA = "0x1885EB170")]
		public static void JTUMCFFYYJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x85EAE20", Offset = "0x85E9C20", VA = "0x1885EAE20")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		public static void EHCHBPBKVFS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[BurstCompile]
	internal struct TessVert
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public float3 pos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int srcIndex0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public int srcIndex1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public int srcIndex2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public float srcWeight1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public float srcWeight2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int nextIndex;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x85FC040", Offset = "0x85FAE40", VA = "0x1885FC040")]
		public static void Create([Out] TessVert result, int srcIndex, [In] float3 posIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x85FBD50", Offset = "0x85FAB50", VA = "0x1885FBD50")]
		[IgnoreWarning(1371)]
		public static void Create([Out] TessVert result, [In] TessVert v1, [In] TessVert v2)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[BurstCompile]
	internal struct ScaleMeshToDesiredTriCountsJob : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private struct ScaledMeshJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			public int firstVertexNum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			public int firstIndexNum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			public int countVertex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			public int countIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			public int maxCountVertex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			public int maxCountIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			public int triCountGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			public int triCountActual;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			public float errorActual;
		}

		[Cpp2IlInjected.Token(Token = "0x200009C")]
		private struct ScaledMeshJobStaticValues
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public YFTREGURNSC.ScalabilityCollapseMetricEnum shapesCollapseMetric;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public float shapesCollapseScaleNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public float shapesCollapseScaleUv;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			public float shapesCollapseScaleColourId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public float shapesCollapseScaleTextureId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public float shapesCollapseScaleCoincident;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public float shapesCollapseScaleGuideAccum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public float shapesCollapseScaleLod012;
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		private struct NativeMeshJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public NativeArray<float3> Verts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			public NativeArray<float3> Normals;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public NativeArray<float4> Tangents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public NativeArray<float4> MaterialIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public NativeArray<float2> UVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public NativeArray<int> Indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public bool hasTangents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			public int VertexCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			public int IndexCount;

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x8607210", Offset = "0x8606010", VA = "0x188607210")]
			public void EVCVCFHUUWJ(int a, int b, Allocator c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x86073F0", Offset = "0x86061F0", VA = "0x1886073F0")]
			public static NativeMeshJob NNQFQHRBPKZ(NativeMesh a)
			{
				return default(NativeMeshJob);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x3CD9E20", Offset = "0x3CD8C20", VA = "0x183CD9E20")]
			private static void IEVVAXZFAMJ<T>(NativeArray<T> a, NativeArray<T> b) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8607150", Offset = "0x8605F50", VA = "0x188607150")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void Setup_FastCopyCollapse_0000028F$PostfixBurstDelegate(int numCollapses, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		internal static class WYAGPDWKYHK
		{
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x860C400", Offset = "0x860B200", VA = "0x18860C400")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x860C580", Offset = "0x860B380", VA = "0x18860C580")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x860C1E0", Offset = "0x860AFE0", VA = "0x18860C1E0")]
			public unsafe static void Invoke(int numCollapses, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private static readonly ProfilerMarker markerFinishAndDispose;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private static readonly ProfilerMarker markerCheckConsistency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private NativeArray<ScaledMeshJob> scaledMeshList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private NativeMeshJob scaledMeshListContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private NativeMeshJob meshSrc;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private float3 shapeBatch_bboxMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private float3 shapeBatch_bboxMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private ScaledMeshJobStaticValues staticValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly long* scaleMeshJobAbortRequestRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private NativeArray<ShapeBatch.CollapseEntry> collapseListSrc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private NativeList<ShapeBatch.CollapseEntry> collapseListDst;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private NativeArray<int> newIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private NativeArray<bool> vertexUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private NativeArray<int> mapVertSrcToDst;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private NativeArray<int> vertexLowestToVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private NativeArray<float> vertexLowestToError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private NativeArray<int> vertexCollapseListToVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private NativeArray<float> vertexCollapseListToErrorMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private NativeArray<int> vertexCollapseListToRefCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private NativeArray<int> vertexLowestCoincidentToVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private NativeArray<float> vertexAccumulatedError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private NativeArray<float> vertexArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private NativeArray<int> vertexCoincidentLink;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x860A7B0", Offset = "0x86095B0", VA = "0x18860A7B0")]
		public ScaleMeshToDesiredTriCountsJob([In] List<ShapeBatch.ScaledMesh> meshListIn, NativeList<ShapeBatch.CollapseEntry> collapseListOut, [In] NativeMesh meshSrcIn, [In] NativeList<ShapeBatch.CollapseEntry> collapseListIn, [In] NativeArray<long> scaleMeshJobAbortRequest, float3 bboxMin, float3 bboxMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8607A80", Offset = "0x8606880", VA = "0x188607A80")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.Setup_FastCopyCollapse_0000028F$PostfixBurstDelegate))]
		private unsafe static void IQNZAVAAIGG(int a, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8607880", Offset = "0x8606680", VA = "0x188607880")]
		public static long FKVAZMDLNSK(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8607830", Offset = "0x8606630", VA = "0x188607830", Slot = "4")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8607A90", Offset = "0x8606890", VA = "0x188607A90")]
		public void LCARDOBNSGV(List<ShapeBatch.ScaledMesh> a, [In] ShapeBatch shapeBatchIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8607810", Offset = "0x8606610", VA = "0x188607810")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private bool AbortRequested()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8608AA0", Offset = "0x86078A0", VA = "0x188608AA0")]
		private CompressedNativeMeshStruct RRGDHCZTHCG(int a, Allocator b)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8608FF0", Offset = "0x8607DF0", VA = "0x188608FF0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private void WSECLFGZBTD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x86084E0", Offset = "0x86072E0", VA = "0x1886084E0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private float LLTRTNYWPEQ(int a, int b, bool c, bool d, float e, float f, float g, float h, float i, float j, float k)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8608CD0", Offset = "0x8607AD0", VA = "0x188608CD0")]
		[IgnoreWarning(1371)]
		private ScaledMeshJob VZUEDEXCIOC([In] ScaledMeshJob scaledMeshJobSrc, int a, [In] NativeArray<int> indices, [In] NativeArray<bool> vertexUsed, NativeArray<int> b)
		{
			return default(ScaledMeshJob);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x86078A0", Offset = "0x86066A0", VA = "0x1886078A0")]
		public static int IGOXKLSMMJA(NativeArray<int> a, NativeArray<int> b, int c, int d, int e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x85FC140", Offset = "0x85FAF40", VA = "0x1885FC140")]
		[BurstCompile]
		internal unsafe static void GUTLITOARPX(int a, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public class BatchedMeshRenderer : MonoBehaviour, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		private struct BoundsShape
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public long spatialIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public RRBounds bounds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public ETBTAFPVNAW shape;

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x8605C90", Offset = "0x8604A90", VA = "0x188605C90")]
			public BoundsShape(RRBounds inBounds, ETBTAFPVNAW inEntry)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		private class WLNWBYAZPLQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public RRBounds JRTYELQPBPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			public int UYVJPCKIDEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public float MXBKKPUFAVF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public List<BoundsShape> FPZDUTBRAJI;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x860C140", Offset = "0x860AF40", VA = "0x18860C140")]
			public WLNWBYAZPLQ(RRBounds a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private static readonly ProfilerMarker QMYGGPFTPIE;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private static readonly ProfilerMarker SHSFIEETCSN;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private static readonly ProfilerMarker KJQFDLWNAIF;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static readonly ProfilerMarker AQODEISRWYA;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private static readonly ProfilerMarker XVGLMNXDVNA;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static readonly ProfilerMarker JBHOEQNMLZD;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private static readonly ProfilerMarker KSRCMAEEWBU;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		internal const int GQNDMRGXZPT = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		internal static Dictionary<Material, List<Material>> BDXWCLJKYKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private Dictionary<Material, List<BatchedMesh>> RAFYCNQRDEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		internal List<BatchedMesh> BOGGVMSRVYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private List<MeshRenderer> HYZJYUGEBRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private Transform USOPKZZNRGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private bool JWPNZCWUBYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private bool RJOITTUQPVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private int VCEYSGIRVAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private BatchedMesh ICWDRXMCKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Material ABSKKFRGXKY;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private static bool? VTMYPNURCXS;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private const int MXNGCTAAXOJ = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private static List<BoundsShape> HBOFIROEYTI;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<MeshRenderer> EJUNXMGIJED
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int ETSKQDTRPDG
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x8602400", Offset = "0x8601200", VA = "0x188602400")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private static bool UGSQCLOAZFS
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x85FC630", Offset = "0x85FB430", VA = "0x1885FC630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void WWIVLVLHKVY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void WWIVLVLHKVY(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void BFCWICPCIWJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x85FC3A0", Offset = "0x85FB1A0", VA = "0x1885FC3A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x85FCBF0", Offset = "0x85FB9F0", VA = "0x1885FCBF0")]
		internal bool EIVSFCFZPCI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8601CD0", Offset = "0x8600AD0", VA = "0x188601CD0")]
		private Transform XQXAVJBEXJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x85FE1A0", Offset = "0x85FCFA0", VA = "0x1885FE1A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x85FC750", Offset = "0x85FB550", VA = "0x1885FC750", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x85FC180", Offset = "0x85FAF80", VA = "0x1885FC180")]
		public BatchedMesh AddToBatchedMesh(ETBTAFPVNAW newMesh, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x86014A0", Offset = "0x86002A0", VA = "0x1886014A0")]
		public void RemoveFromBatchedMesh(ETBTAFPVNAW mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x85FC500", Offset = "0x85FB300", VA = "0x1885FC500")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x85FE4B0", Offset = "0x85FD2B0", VA = "0x1885FE4B0")]
		private void QXNTVLNHFMK(Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x85FD300", Offset = "0x85FC100", VA = "0x1885FD300")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x85FD2F0", Offset = "0x85FC0F0", VA = "0x1885FD2F0")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x86016E0", Offset = "0x86004E0", VA = "0x1886016E0")]
		private void VQDVKUMMNKS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x85FDCA0", Offset = "0x85FCAA0", VA = "0x1885FDCA0")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x85FE2B0", Offset = "0x85FD0B0", VA = "0x1885FE2B0")]
		private BatchedMesh QQLCHMOKPYD(ETBTAFPVNAW a, Material b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8601D50", Offset = "0x8600B50", VA = "0x188601D50")]
		private BatchedMesh ZEGDPWDBPET(Material a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x85FD370", Offset = "0x85FC170", VA = "0x1885FD370")]
		private BatchedMesh LLAQSDFDFFM(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x85FCB60", Offset = "0x85FB960", VA = "0x1885FCB60")]
		internal void EDCNEXMQLXZ([Out] float4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x85FCC50", Offset = "0x85FBA50", VA = "0x1885FCC50")]
		public static List<Material> GenerateVertexFormatVariants(Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x86015E0", Offset = "0x86003E0", VA = "0x1886015E0")]
		public static void UpdateMaterialVariants(Material parentMaterial, Action<Material> updateFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xCF03D0", Offset = "0xCEF1D0", VA = "0x180CF03D0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x85FDB40", Offset = "0x85FC940", VA = "0x1885FDB40")]
		public void MarkDirty(ETBTAFPVNAW mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x85FE1B0", Offset = "0x85FCFB0", VA = "0x1885FE1B0")]
		[Conditional("CHECK_STATE")]
		private void QDOEUDMPERW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x85FDE00", Offset = "0x85FCC00", VA = "0x1885FDE00")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float scalabilityErrorControl)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x85FC3D0", Offset = "0x85FB1D0", VA = "0x1885FC3D0")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x86001E0", Offset = "0x85FEFE0", VA = "0x1886001E0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x85FCDD0", Offset = "0x85FBBD0", VA = "0x1885FCDD0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x85FE610", Offset = "0x85FD410", VA = "0x1885FE610")]
		public void RebatchOptimally(int batchSizeNaughty, int batchSizeNice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x85FE530", Offset = "0x85FD330", VA = "0x1885FE530")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x86022F0", Offset = "0x86010F0", VA = "0x1886022F0")]
		public BatchedMeshRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public static class BatchedMeshScalabilityManager
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		private struct FindAndMarkAsFrozenCache
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public BatchedMeshRenderer renderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public BatchedMesh mesh;

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x1B4CEB0", Offset = "0x1B4BCB0", VA = "0x181B4CEB0")]
			public void PALMUPZNLTM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		private struct BatchedMeshSortedItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public float pixelsOfError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public BatchedMesh bm;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class CUFJTQKINLC : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			private bool LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			private long XVNZBUAVGJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public long IUODCRZGNVH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private bool HSFXZDJEKZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public bool ZAYKBCXXGOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			private int FUWRLBKDXPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			private int VSOAAYJPNJZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			private int CBTOMZFIUZS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			private int ZDFIQZPFPHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private List<BatchedMeshRenderer>.Enumerator NVLKRCHTYJS;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool PLMQPQGBWPM
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0x10FF5A0", Offset = "0x10FE3A0", VA = "0x1810FF5A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x7917350", Offset = "0x7916150", VA = "0x187917350", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x138C8D0", Offset = "0x138B6D0", VA = "0x18138C8D0")]
			[DebuggerHidden]
			public CUFJTQKINLC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8606FF0", Offset = "0x8605DF0", VA = "0x188606FF0", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x8605E00", Offset = "0x8604C00", VA = "0x188605E00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8605D10", Offset = "0x8604B10", VA = "0x188605D10")]
			private void GWSJMPTZZMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x8605CC0", Offset = "0x8604AC0", VA = "0x188605CC0")]
			private void GWCOUVMHXEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8607110", Offset = "0x8605F10", VA = "0x188607110", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8605D60", Offset = "0x8604B60", VA = "0x188605D60", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> IGTEHEEICGF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8605D60", Offset = "0x8604B60", VA = "0x188605D60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private static readonly ProfilerMarker JBHOEQNMLZD;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly ProfilerMarker OOLYUHXVZCV;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly ProfilerMarker HXDKCGVHZUL;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly ProfilerMarker KLEHJXFJFCJ;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static float3 PEEJOQENKCQ;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static int LOMPIMHVUYN;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static int OUGPVTRLCPM;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static int GCVHNRGYDFL;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static int ZYEHSFWNLSW;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static int TGTZIYLSUMG;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static float QTUNMPCCTCH;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static float IIQNFIRFUEF;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static float NQXFTAQSFPX;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static float KIEMDKTSPCA;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static float OCZGFIFVCDT;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static float CMYNGDMPCJG;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static float MYSIPZRWCBO;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static float YEIWQSDJFFF;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private static List<BatchedMeshRenderer> UCFCUNJUSWA;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private static Stack<NativeMesh> PLGXPBXHWGN;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private static Stack<YOSWIQSKRWV> AEFECYKVSAW;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static DQOPNYHMTEI BDYMICFHTIP;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private static FindAndMarkAsFrozenCache VICEVLSYLMD;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static int UEWEZSBMWVK;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void WWIVLVLHKVY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void JCEKUXXRPPF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void WWIVLVLHKVY(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8604940", Offset = "0x8603740", VA = "0x188604940")]
		public static void NRKVJJKJWDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8605290", Offset = "0x8604090", VA = "0x188605290")]
		public static void YZIRRCFNTYG(BatchedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x8605760", Offset = "0x8604560", VA = "0x188605760")]
		public static void ZRIJQPRECKL(BatchedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x86049C0", Offset = "0x86037C0", VA = "0x1886049C0")]
		public static void XOXGZQLFGQD(ETBTAFPVNAW a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x86053D0", Offset = "0x86041D0", VA = "0x1886053D0")]
		public static void ZCEUMUNKPSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x86024D0", Offset = "0x86012D0", VA = "0x1886024D0")]
		public static void BBVXYDYWCNN(float a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8602D40", Offset = "0x8601B40", VA = "0x188602D40")]
		private static void EONNADMILAQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8603D30", Offset = "0x8602B30", VA = "0x188603D30")]
		public static long MNYKGOMDLAU(int a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8603940", Offset = "0x8602740", VA = "0x188603940")]
		public static (long, long, int) JNXCIHELTMU(float a)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8602450", Offset = "0x8601250", VA = "0x188602450")]
		[IteratorStateMachine(typeof(CUFJTQKINLC))]
		public static IEnumerable<bool> AZLCAACWBKD(long a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8603560", Offset = "0x8602360", VA = "0x188603560")]
		public static void HAGFZEVDORR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x86031E0", Offset = "0x8601FE0", VA = "0x1886031E0")]
		public static void EPKKATHKKKB(long a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x86037C0", Offset = "0x86025C0", VA = "0x1886037C0")]
		public static int IYXGFKGLQYH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8605120", Offset = "0x8603F20", VA = "0x188605120")]
		internal static NativeMesh YFJTKCORJHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x86034C0", Offset = "0x86022C0", VA = "0x1886034C0")]
		internal static void GPQRMOWHBAY(NativeMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x86047F0", Offset = "0x86035F0", VA = "0x1886047F0")]
		internal static YOSWIQSKRWV NBCAGBYYEHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8603430", Offset = "0x8602230", VA = "0x188603430")]
		internal static void GPQRMOWHBAY(YOSWIQSKRWV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8603B50", Offset = "0x8602950", VA = "0x188603B50")]
		public static void JTUMCFFYYJB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class BXUFFBZWZKB<a> : BatchedMesh
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private readonly Dictionary<a, ETBTAFPVNAW> IJTBQJSGCSL;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x714DF10", Offset = "0x714CD10", VA = "0x18714DF10")]
		public BXUFFBZWZKB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x714DEC0", Offset = "0x714CCC0", VA = "0x18714DEC0")]
		public void ZLGWJHBAGFU(a a, ETBTAFPVNAW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x714DB10", Offset = "0x714C910", VA = "0x18714DB10")]
		public bool XVZSRGGAHZX(a a, ETBTAFPVNAW b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x714DA70", Offset = "0x714C870", VA = "0x18714DA70")]
		public void WBBSOJINPZG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x714D880", Offset = "0x714C680", VA = "0x18714D880", Slot = "4")]
		public override void VCTPIERYSOH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public static class UUEZONKBYQO
	{
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly ProfilerCategory UOGFBTJHBHJ;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		internal static readonly ProfilerMarker BDTTICTDRWA;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		internal static readonly RuntimeMarker BBVXYDYWCNN;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static readonly RuntimeCounterValue<float> MRYGULRIJKS;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static readonly RuntimeCounterValue<float> SWUWIWANFOV;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly RuntimeCounterValue<float> VHYKCTJKXAA;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private static readonly RuntimeCounterValue<double> TGRABZGOVSW;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private static readonly RuntimeCounterValue<double> YIVKCYQPQVA;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private static readonly RuntimeCounterValue<double> UHTJPHEVUBV;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private static readonly RuntimeCounterValue<double> LSNANJRILNN;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private static readonly RuntimeCounterValue<int> RZAKAQTGGNH;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private static readonly RuntimeCounterValue<int> OXDIHBAITAT;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private static readonly RuntimeCounterValue<int> ZHXHCZCXWBD;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private static readonly RuntimeCounterValue<int> OGCIQVRYCKG;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private static readonly RuntimeCounterValue<int> BLKRZYBRLHD;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private static readonly RuntimeCounterValue<int> ZYJNTWIASEB;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private static readonly RuntimeCounterValue<int> AMVTYLFBUZA;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private static readonly RuntimeCounterValue<int> JAGEBHSIYGB;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private static readonly RuntimeCounterValue<long> FIYOYLQJOLX;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static readonly RuntimeCounterValue<long> JIWJAOJMIBK;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private static readonly RuntimeCounterValue<long> XULDWVGAETP;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private static readonly RuntimeCounterValue<long> EBNUDSDKBNZ;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private static readonly RuntimeCounterValue<long> TFZLFTKPGWV;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private static readonly RuntimeCounterValue<long> DCEDEAAFBTC;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x860B2D0", Offset = "0x860A0D0", VA = "0x18860B2D0")]
		public static void MVELNNCKQNG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3817239846
{
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x860C700", Offset = "0x860B500", VA = "0x18860C700")]
	public static void UVBMKKQUWLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x860C6F0", Offset = "0x860B4F0", VA = "0x18860C6F0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x860B170", Offset = "0x8609F70", VA = "0x18860B170")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
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
