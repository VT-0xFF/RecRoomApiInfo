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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87BC0A0", Offset = "0x87BB0A0", VA = "0x1887BC0A0", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal static class PEPMDKOCEQM
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly Log OBDZUIPTHOK;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly Log OEMIBIYFWLN;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly Log LRTWRPOLHYX;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly Log LNXOIRPBFPY;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly Log LSAUEUJZJEP;
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
		public CompressedNativeMeshStruct UEEBFMBLURE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int SRSILWCWOZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
		public unsafe delegate void GetAllVerts_00000036$PostfixBurstDelegate([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int vertexCount, [In] float3 vertMin, [In] float3 vertScale);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal static class WAQTQUILZPD
		{
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x87C9F30", Offset = "0x87C8F30", VA = "0x1887C9F30")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x87C9DB0", Offset = "0x87C8DB0", VA = "0x1887C9DB0")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x87CA0C0", Offset = "0x87C90C0", VA = "0x1887CA0C0")]
			public unsafe static void Invoke([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int vertexCount, [In] float3 vertMin, [In] float3 vertScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetAllVerts_0000003D$PostfixBurstDelegate([NoAlias] ushort* dstVerts, [Out] float3 vertMinimum, [Out] float3 vertScale, [In][NoAlias] float3* srcVerts, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal static class YDENHWHRKOX
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x87CAF50", Offset = "0x87C9F50", VA = "0x1887CAF50")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x87CADD0", Offset = "0x87C9DD0", VA = "0x1887CADD0")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x87CB0E0", Offset = "0x87CA0E0", VA = "0x1887CB0E0")]
			public unsafe static void Invoke([NoAlias] ushort* dstVerts, [Out] float3 vertMinimum, [Out] float3 vertScale, [In][NoAlias] float3* srcVerts, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetAllNormals_0000003F$PostfixBurstDelegate([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class BAHRPECIISJ
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x87AA790", Offset = "0x87A9790", VA = "0x1887AA790")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x87AA610", Offset = "0x87A9610", VA = "0x1887AA610")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x87AA920", Offset = "0x87A9920", VA = "0x1887AA920")]
			public unsafe static void Invoke([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void GetAllNormals_00000041$PostfixBurstDelegate([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		internal static class YLPLXQXYWFB
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x87CB4D0", Offset = "0x87CA4D0", VA = "0x1887CB4D0")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x87CB350", Offset = "0x87CA350", VA = "0x1887CB350")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x87CB660", Offset = "0x87CA660", VA = "0x1887CB660")]
			public unsafe static void Invoke([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetAllUVs_00000048$PostfixBurstDelegate([NoAlias] uint* dstUVs, [Out] float2 uvMinimum, [Out] float2 uvScale, [In][NoAlias] float2* srcUVs, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		internal static class KXGKTFOHIVS
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x87BBCA0", Offset = "0x87BACA0", VA = "0x1887BBCA0")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x87BBB20", Offset = "0x87BAB20", VA = "0x1887BBB20")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x87BBE30", Offset = "0x87BAE30", VA = "0x1887BBE30")]
			public unsafe static void Invoke([NoAlias] uint* dstUVs, [Out] float2 uvMinimum, [Out] float2 uvScale, [In][NoAlias] float2* srcUVs, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void GetUV_00000049$PostfixBurstDelegate([Out] float2 ret, uint compressed, [In] float2 uvMin, [In] float2 uvScale);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class KOAZGFAFREJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x87BB200", Offset = "0x87BA200", VA = "0x1887BB200")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x87BB080", Offset = "0x87BA080", VA = "0x1887BB080")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x87BB390", Offset = "0x87BA390", VA = "0x1887BB390")]
			public static void Invoke([Out] float2 ret, uint compressed, [In] float2 uvMin, [In] float2 uvScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void GetAllUVs_0000004B$PostfixBurstDelegate([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int vertexCount, [In] float2 uvMin, [In] float2 uvScale);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		internal static class IUYHUFVDEUO
		{
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x87B9FE0", Offset = "0x87B8FE0", VA = "0x1887B9FE0")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x87B9E60", Offset = "0x87B8E60", VA = "0x1887B9E60")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x87BA170", Offset = "0x87B9170", VA = "0x1887BA170")]
			public unsafe static void Invoke([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int vertexCount, [In] float2 uvMin, [In] float2 uvScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetAllTangents_00000052$PostfixBurstDelegate([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal static class YVKAPCONHDP
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x87CBA60", Offset = "0x87CAA60", VA = "0x1887CBA60")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x87CB8E0", Offset = "0x87CA8E0", VA = "0x1887CB8E0")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x87CBBF0", Offset = "0x87CABF0", VA = "0x1887CBBF0")]
			public unsafe static void Invoke([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ushort SetTangent_00000053$PostfixBurstDelegate([In] float4 newVal);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		internal static class ICDZYAVHPJM
		{
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x87B7710", Offset = "0x87B6710", VA = "0x1887B7710")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x87B7590", Offset = "0x87B6590", VA = "0x1887B7590")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x87B78A0", Offset = "0x87B68A0", VA = "0x1887B78A0")]
			public static ushort Invoke([In] float4 newVal)
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void GetAllTangents_00000055$PostfixBurstDelegate([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class VKTSRDDAQAQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x87C8A40", Offset = "0x87C7A40", VA = "0x1887C8A40")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x87C88C0", Offset = "0x87C78C0", VA = "0x1887C88C0")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x87C8BD0", Offset = "0x87C7BD0", VA = "0x1887C8BD0")]
			public unsafe static void Invoke([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void GetTangent_0000005B$PostfixBurstDelegate([Out] float4 result, ushort compressed);

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		internal static class DDXVBKMRLMF
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x87B4D90", Offset = "0x87B3D90", VA = "0x1887B4D90")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x87B4C10", Offset = "0x87B3C10", VA = "0x1887B4C10")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x87B4F20", Offset = "0x87B3F20", VA = "0x1887B4F20")]
			public static void Invoke([Out] float4 result, ushort compressed)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void CreateAllMaterialIndices_0000005D$PostfixBurstDelegate([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int numData, [Out] int numRLEs, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		internal static class DPXJPOAWFGF
		{
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x87B5E40", Offset = "0x87B4E40", VA = "0x1887B5E40")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x87B5CC0", Offset = "0x87B4CC0", VA = "0x1887B5CC0")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x87B5FD0", Offset = "0x87B4FD0", VA = "0x1887B5FD0")]
			public unsafe static void Invoke([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int numData, [Out] int numRLEs, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void DecodeMaterialIndices_0000005F$PostfixBurstDelegate([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		internal static class BCUNHEMLOYY
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x87AAD10", Offset = "0x87A9D10", VA = "0x1887AAD10")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x87AAB90", Offset = "0x87A9B90", VA = "0x1887AAB90")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x87AAEA0", Offset = "0x87A9EA0", VA = "0x1887AAEA0")]
			public unsafe static void Invoke([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate int EncodeIndices_00000067$PostfixBurstDelegate([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int srcIndexCount);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		internal static class QLSDAJXLMOJ
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x87C3B40", Offset = "0x87C2B40", VA = "0x1887C3B40")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x87C39C0", Offset = "0x87C29C0", VA = "0x1887C39C0")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x87C3CD0", Offset = "0x87C2CD0", VA = "0x1887C3CD0")]
			public unsafe static int Invoke([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int srcIndexCount)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void DecodeIndices_00000069$PostfixBurstDelegate([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int indexCount);

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		internal static class CUOJQVZXVGT
		{
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x87AB8B0", Offset = "0x87AA8B0", VA = "0x1887AB8B0")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x87AB730", Offset = "0x87AA730", VA = "0x1887AB730")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x87ABA40", Offset = "0x87AAA40", VA = "0x1887ABA40")]
			public unsafe static void Invoke([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int indexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DecodeNormal_0000006B$PostfixBurstDelegate([Out] float3 ret, ushort compressed);

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		internal static class VOKAKNCDPJE
		{
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x87C8FD0", Offset = "0x87C7FD0", VA = "0x1887C8FD0")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x87C8E50", Offset = "0x87C7E50", VA = "0x1887C8E50")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x87C9160", Offset = "0x87C8160", VA = "0x1887C9160")]
			public static void Invoke([Out] float3 ret, ushort compressed)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ushort EncodeNormal_0000006C$PostfixBurstDelegate([In] float3 newVal);

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		internal static class KOYIXNGQTPT
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x87BB780", Offset = "0x87BA780", VA = "0x1887BB780")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x87BB600", Offset = "0x87BA600", VA = "0x1887BB600")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x87BB910", Offset = "0x87BA910", VA = "0x1887BB910")]
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
		public bool TECFEJJOIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x87AE2E0", Offset = "0x87AD2E0", VA = "0x1887AE2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DXNGYSTQDOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x87ABDC0", Offset = "0x87AADC0", VA = "0x1887ABDC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87AC770", Offset = "0x87AB770", VA = "0x1887AC770")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x87AC490", Offset = "0x87AB490", VA = "0x1887AC490")]
		public static CompressedNativeMeshStruct Create(Allocator allocator, NativeMesh srcMesh)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x87ABEC0", Offset = "0x87AAEC0", VA = "0x1887ABEC0")]
		public static CompressedNativeMeshStruct Create(Allocator allocator, NativeArray<float3> srcVerts, NativeArray<float3> srcNormals, NativeArray<float2> srcUVs, NativeArray<float4> srcMaterialIndices, bool hasTangents, NativeArray<float4> srcTangents, NativeArray<int> srcIndices, int vertexCount, int firstVertex, int indexCount, int firstIndex)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x87ADD40", Offset = "0x87ACD40", VA = "0x1887ADD40")]
		public void TDIEAIXLJSP(NativeMesh a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x87ABCC0", Offset = "0x87AACC0", VA = "0x1887ABCC0")]
		public long ATZKFLPGEBR()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x87AE170", Offset = "0x87AD170", VA = "0x1887AE170")]
		public long TPYMVTCNYZG(NativeMesh.UnityMeshFormat a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87AD240", Offset = "0x87AC240", VA = "0x1887AD240")]
		private void KIRZLIOHNJC(int a, int b, Allocator c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x87AE1F0", Offset = "0x87AD1F0", VA = "0x1887AE1F0")]
		private void VRVLKETHYXQ(NativeArray<float3> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x87AE1E0", Offset = "0x87AD1E0", VA = "0x1887AE1E0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllVerts_00000036$PostfixBurstDelegate))]
		private unsafe static void VRVLKETHYXQ([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int a, [In] float3 vertMin, [In] float3 vertScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x87AD040", Offset = "0x87AC040", VA = "0x1887AD040")]
		private void JMVVNPXGMEC(NativeArray<float3> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x87AD130", Offset = "0x87AC130", VA = "0x1887AD130")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllVerts_0000003D$PostfixBurstDelegate))]
		private unsafe static void JMVVNPXGMEC([NoAlias] ushort* dstVerts, [Out] float3 a, [Out] float3 b, [In][NoAlias] float3* srcVerts, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x87ACDC0", Offset = "0x87ABDC0", VA = "0x1887ACDC0")]
		private void HUNNWPAQDKW(NativeArray<float3> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x87ACDB0", Offset = "0x87ABDB0", VA = "0x1887ACDB0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllNormals_0000003F$PostfixBurstDelegate))]
		private unsafe static void HUNNWPAQDKW([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x87ACEA0", Offset = "0x87ABEA0", VA = "0x1887ACEA0")]
		private void IVKZRQRBASG(NativeArray<float3> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x87ACF60", Offset = "0x87ABF60", VA = "0x1887ACF60")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllNormals_00000041$PostfixBurstDelegate))]
		private unsafe static void IVKZRQRBASG([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x87ACBB0", Offset = "0x87ABBB0", VA = "0x1887ACBB0")]
		private void HRVBGPPXNBI(NativeArray<float2> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x87ACBA0", Offset = "0x87ABBA0", VA = "0x1887ACBA0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllUVs_00000048$PostfixBurstDelegate))]
		private unsafe static void HRVBGPPXNBI([NoAlias] uint* dstUVs, [Out] float2 a, [Out] float2 b, [In][NoAlias] float2* srcUVs, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x87AC9A0", Offset = "0x87AB9A0", VA = "0x1887AC9A0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetUV_00000049$PostfixBurstDelegate))]
		private static void FHNHSGZVNQA([Out] float2 a, uint b, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x87AE320", Offset = "0x87AD320", VA = "0x1887AE320")]
		private void YSZZWKUBTCS(NativeArray<float2> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x87AE410", Offset = "0x87AD410", VA = "0x1887AE410")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllUVs_0000004B$PostfixBurstDelegate))]
		private unsafe static void YSZZWKUBTCS([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int a, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x87AE090", Offset = "0x87AD090", VA = "0x1887AE090")]
		private void TFJWHENNRTG(NativeArray<float4> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87AE080", Offset = "0x87AD080", VA = "0x1887AE080")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllTangents_00000052$PostfixBurstDelegate))]
		private unsafe static void TFJWHENNRTG([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x87AD790", Offset = "0x87AC790", VA = "0x1887AD790")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetTangent_00000053$PostfixBurstDelegate))]
		private static ushort PFNPBIKLHSU([In] float4 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x87AC8E0", Offset = "0x87AB8E0", VA = "0x1887AC8E0")]
		private void FCVYDGMJEDO(NativeArray<float4> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x87AC8D0", Offset = "0x87AB8D0", VA = "0x1887AC8D0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllTangents_00000055$PostfixBurstDelegate))]
		private unsafe static void FCVYDGMJEDO([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x87AD400", Offset = "0x87AC400", VA = "0x1887AD400")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetTangent_0000005B$PostfixBurstDelegate))]
		private static void LBLJRLMGTGY([Out] float4 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87AD8B0", Offset = "0x87AC8B0", VA = "0x1887AD8B0")]
		private void PYUFIXLMFEC(Allocator a, NativeArray<float4> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x87AD8A0", Offset = "0x87AC8A0", VA = "0x1887AD8A0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.CreateAllMaterialIndices_0000005D$PostfixBurstDelegate))]
		private unsafe static void PYUFIXLMFEC([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int a, [Out] int b, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x87ACCB0", Offset = "0x87ABCB0", VA = "0x1887ACCB0")]
		private static void HSVNJELSYWT(NativeArray<float4> a, NativeArray<MaterialIndex> b, NativeArray<byte> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x87ACCA0", Offset = "0x87ABCA0", VA = "0x1887ACCA0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeMaterialIndices_0000005F$PostfixBurstDelegate))]
		private unsafe static void HSVNJELSYWT([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x87AD140", Offset = "0x87AC140", VA = "0x1887AD140")]
		private void JOMBDIPWTKF(Allocator a, NativeArray<int> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x87AE420", Offset = "0x87AD420", VA = "0x1887AE420")]
		private static NativeArray<byte> ZXFVEQEOTJS(Allocator a, NativeArray<int> b, int c)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87AE6D0", Offset = "0x87AD6D0", VA = "0x1887AE6D0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.EncodeIndices_00000067$PostfixBurstDelegate))]
		private unsafe static int ZXFVEQEOTJS([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x87ACF80", Offset = "0x87ABF80", VA = "0x1887ACF80")]
		private static void JCPCWMRUOIY(NativeArray<int> a, NativeArray<byte> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x87ACF70", Offset = "0x87ABF70", VA = "0x1887ACF70")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeIndices_00000069$PostfixBurstDelegate))]
		private unsafe static void JCPCWMRUOIY([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x87ADD30", Offset = "0x87ACD30", VA = "0x1887ADD30")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeNormal_0000006B$PostfixBurstDelegate))]
		private static void SQFMLMVAXBW([Out] float3 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x87AD6E0", Offset = "0x87AC6E0", VA = "0x1887AD6E0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.EncodeNormal_0000006C$PostfixBurstDelegate))]
		private static ushort NQAGQZGMSOQ([In] float3 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x87A8BD0", Offset = "0x87A7BD0", VA = "0x1887A8BD0")]
		[BurstCompile]
		public unsafe static void BRFKPMIPUXH([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int a, [In] float3 vertMin, [In] float3 vertScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x87A9800", Offset = "0x87A8800", VA = "0x1887A9800")]
		[BurstCompile]
		public unsafe static void LFDPTHPRYYB([NoAlias] ushort* dstVerts, [Out] float3 a, [Out] float3 b, [In][NoAlias] float3* srcVerts, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x87AC9B0", Offset = "0x87AB9B0", VA = "0x1887AC9B0")]
		[BurstCompile]
		public unsafe static void GFJMGVZQGCR([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x87AD630", Offset = "0x87AC630", VA = "0x1887AD630")]
		[BurstCompile]
		public unsafe static void NLRAITUXJUN([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x87A9520", Offset = "0x87A8520", VA = "0x1887A9520")]
		[BurstCompile]
		public unsafe static void KYXHYGLRJSF([NoAlias] uint* dstUVs, [Out] float2 a, [Out] float2 b, [In][NoAlias] float2* srcUVs, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x87AC890", Offset = "0x87AB890", VA = "0x1887AC890")]
		[BurstCompile]
		public static void EHYSXGAAPCL([Out] float2 a, uint b, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x87AD410", Offset = "0x87AC410", VA = "0x1887AD410")]
		[BurstCompile]
		public unsafe static void LZSWGCYLHFT([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int a, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x87ACA50", Offset = "0x87ABA50", VA = "0x1887ACA50")]
		[BurstCompile]
		public unsafe static void HEPNMDMEXNJ([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x87AD370", Offset = "0x87AC370", VA = "0x1887AD370")]
		[BurstCompile]
		public static ushort KTWMUKBHMNB([In] float4 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x87ACAF0", Offset = "0x87ABAF0", VA = "0x1887ACAF0")]
		[BurstCompile]
		public unsafe static void HRNLUKKKRZV([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x87ABE00", Offset = "0x87AAE00", VA = "0x1887ABE00")]
		[BurstCompile]
		public static void CYXPPDTDYEH([Out] float4 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x87A8FF0", Offset = "0x87A7FF0", VA = "0x1887A8FF0")]
		[BurstCompile]
		public unsafe static void KTPDMWBCTTL([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int a, [Out] int b, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x87AD4F0", Offset = "0x87AC4F0", VA = "0x1887AD4F0")]
		[BurstCompile]
		public unsafe static void MZRPIBOFLMK([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x87AD7A0", Offset = "0x87AC7A0", VA = "0x1887AD7A0")]
		[BurstCompile]
		public unsafe static int PNWPWNCNGWT([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x87AD6F0", Offset = "0x87AC6F0", VA = "0x1887AD6F0")]
		[BurstCompile]
		public unsafe static void OKUMAQFQUXB([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x87A9C30", Offset = "0x87A8C30", VA = "0x1887A9C30")]
		[BurstCompile]
		public static void LQVAFOJFHKT([Out] float3 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87A8E30", Offset = "0x87A7E30", VA = "0x1887A8E30")]
		[BurstCompile]
		public static ushort JYDHZAWGHUP([In] float3 newVal)
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
		public unsafe delegate void SetupVertices_NormTanMatF16_00000082$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		internal static class OXOQEJMSNDG
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x87C3190", Offset = "0x87C2190", VA = "0x1887C3190")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x87C3010", Offset = "0x87C2010", VA = "0x1887C3010")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x87C3320", Offset = "0x87C2320", VA = "0x1887C3320")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int FloatToSnorm8_00000083$PostfixBurstDelegate(float x);

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		internal static class CPACXXTZRQA
		{
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x87AB320", Offset = "0x87AA320", VA = "0x1887AB320")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x87AB1B0", Offset = "0x87AA1B0", VA = "0x1887AB1B0")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x87AB4A0", Offset = "0x87AA4A0", VA = "0x1887AB4A0")]
			public static int Invoke(float x)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate uint FloatToSnorm8_00000084$PostfixBurstDelegate([In] float4 v);

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		internal static class WTMIHPLMMYR
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x87CA9B0", Offset = "0x87C99B0", VA = "0x1887CA9B0")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x87CA830", Offset = "0x87C9830", VA = "0x1887CA830")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x87CAB40", Offset = "0x87C9B40", VA = "0x1887CAB40")]
			public static uint Invoke([In] float4 v)
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate uint FloatToSnorm8_00000085$PostfixBurstDelegate([In] float3 v);

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		internal static class ZHRZADADVKG
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x87CBFE0", Offset = "0x87CAFE0", VA = "0x1887CBFE0")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x87CBE60", Offset = "0x87CAE60", VA = "0x1887CBE60")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x87CC170", Offset = "0x87CB170", VA = "0x1887CC170")]
			public static uint Invoke([In] float3 v)
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetupVertices_NormTanSn8MatF16_00000087$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		internal static class HVYXJXUDWAM
		{
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x87B7000", Offset = "0x87B6000", VA = "0x1887B7000")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x87B6E80", Offset = "0x87B5E80", VA = "0x1887B6E80")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x87B7190", Offset = "0x87B6190", VA = "0x1887B7190")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetupVertices_NormTanSn8UvMatF16_00000089$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		internal static class EFPLWHHXREH
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x87B6570", Offset = "0x87B5570", VA = "0x1887B6570")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x87B63F0", Offset = "0x87B53F0", VA = "0x1887B63F0")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x87B6700", Offset = "0x87B5700", VA = "0x1887B6700")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetupVertices_NormTanOct8MatUi_0000008C$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		internal static class JYBTEPFVGDU
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x87BA5B0", Offset = "0x87B95B0", VA = "0x1887BA5B0")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x87BA430", Offset = "0x87B9430", VA = "0x1887BA430")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x87BA740", Offset = "0x87B9740", VA = "0x1887BA740")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetupVertices_PosFixedPoint16NormTanOct8MatUi_0000008E$PostfixBurstDelegate([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 positionMin, [Out] float3 positionMax);

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		internal static class DFJPVVAEFTR
		{
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x87B5350", Offset = "0x87B4350", VA = "0x1887B5350")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x87B51D0", Offset = "0x87B41D0", VA = "0x1887B51D0")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x87B54E0", Offset = "0x87B44E0", VA = "0x1887B54E0")]
			public unsafe static void Invoke([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 positionMin, [Out] float3 positionMax)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetupVertices_FastCopyIndices_00000090$PostfixBurstDelegate(int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class DHBECPVOEXT
		{
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x87B5920", Offset = "0x87B4920", VA = "0x1887B5920")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x87B57B0", Offset = "0x87B47B0", VA = "0x1887B57B0")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x87B5AA0", Offset = "0x87B4AA0", VA = "0x1887B5AA0")]
			public unsafe static void Invoke(int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetupVertices_FastCopyIndices_00000091$PostfixBurstDelegate(int startIndex, int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class WCZEWBULAIG
		{
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x87CA480", Offset = "0x87C9480", VA = "0x1887CA480")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x87CA310", Offset = "0x87C9310", VA = "0x1887CA310")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x87CA600", Offset = "0x87C9600", VA = "0x1887CA600")]
			public unsafe static void Invoke(int startIndex, int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void FastAppendIndices_00000093$PostfixBurstDelegate(int destStart, int sourceCount, int indexOffset, [In][NoAlias] int* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		internal static class KAGTTANWOQC
		{
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x87BACC0", Offset = "0x87B9CC0", VA = "0x1887BACC0")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x87BAB50", Offset = "0x87B9B50", VA = "0x1887BAB50")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x87BAE40", Offset = "0x87B9E40", VA = "0x1887BAE40")]
			public unsafe static void Invoke(int destStart, int sourceCount, int indexOffset, [In][NoAlias] int* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void FindBestUnityMeshFormat_Fast_0000009D$PostfixBurstDelegate(int vertexCount, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		internal static class QMHUKZRBYGB
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x87C4100", Offset = "0x87C3100", VA = "0x1887C4100")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x87C3F90", Offset = "0x87C2F90", VA = "0x1887C3F90")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x87C4280", Offset = "0x87C3280", VA = "0x1887C4280")]
			public unsafe static void Invoke(int vertexCount, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const int QNJFEOHLVTS = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public NativeList<float3> GABPYANKQCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NativeArray<float3> PTRFOZHBHKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NativeArray<float4> BHKUSHOJSWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NativeArray<float4> SAJQWRATEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public NativeArray<float2> SIUPHAWJHAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public NativeList<int> PQLRKEAAEDA;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly VertexAttributeDescriptor[][] JTRCSLJTIKC;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static bool QEIMNPKARFL;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static UnityMeshFormatInfo[] FJYDRMPORCM;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static VertexAttributeDescriptor[] MGBLLVNLHER;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool TECFEJJOIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x87C22F0", Offset = "0x87C12F0", VA = "0x1887C22F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int JJVIXLXPMBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x87BF980", Offset = "0x87BE980", VA = "0x1887BF980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int HOTWJAZHXQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x87C0830", Offset = "0x87BF830", VA = "0x1887C0830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool DXNGYSTQDOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x87BE820", Offset = "0x87BD820", VA = "0x1887BE820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x87C2C80", Offset = "0x87C1C80", VA = "0x1887C2C80")]
		public static VertexFormatKeyword ZAJHZVZMWLD(UnityMeshFormat a)
		{
			return default(VertexFormatKeyword);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x87C1000", Offset = "0x87C0000", VA = "0x1887C1000")]
		public static void RGKWTQMMIVT(VertexFormatKeyword a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x87BECD0", Offset = "0x87BDCD0", VA = "0x1887BECD0", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x87BFC50", Offset = "0x87BEC50", VA = "0x1887BFC50")]
		public void KIRZLIOHNJC(int a, int b, Allocator c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x87C1D10", Offset = "0x87C0D10", VA = "0x1887C1D10")]
		public void UYICLATCQEH(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x87BF9D0", Offset = "0x87BE9D0", VA = "0x1887BF9D0", Slot = "6")]
		public bool IIMYILNFIHN(Mesh a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x87C2850", Offset = "0x87C1850", VA = "0x1887C2850")]
		public bool YXMWMHJVDUI(Mesh a, bool b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x87C1DC0", Offset = "0x87C0DC0", VA = "0x1887C1DC0")]
		public bool WFMSVIWZSOU(Mesh a, NativeMesh b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x87C0E70", Offset = "0x87BFE70", VA = "0x1887C0E70")]
		public bool QVUWLRXBUKH(Mesh a, NativeMesh b, UnityMeshFormat c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x87BD8F0", Offset = "0x87BC8F0", VA = "0x1887BD8F0")]
		private void BGDPHMNIUMM(Mesh a, NativeMesh b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x87BD5A0", Offset = "0x87BC5A0", VA = "0x1887BD5A0")]
		public void BGDPHMNIUMM(NativeArray<ushort> a, NativeArray<VertexFormat_NormTanOct8MatUi> b, Mesh c, NativeMesh d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x87C10E0", Offset = "0x87C00E0", VA = "0x1887C10E0")]
		public void RJTFTFWKQTE(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x87C1D90", Offset = "0x87C0D90", VA = "0x1887C1D90")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanMatF16_00000082$PostfixBurstDelegate))]
		private unsafe static void VERFBOLVEKQ([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x87BFC40", Offset = "0x87BEC40", VA = "0x1887BFC40")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000083$PostfixBurstDelegate))]
		public static int JALGACJHNDH(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x87BFC20", Offset = "0x87BEC20", VA = "0x1887BFC20")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000084$PostfixBurstDelegate))]
		public static uint JALGACJHNDH([In] float4 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x87BFC30", Offset = "0x87BEC30", VA = "0x1887BFC30")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000085$PostfixBurstDelegate))]
		public static uint JALGACJHNDH([In] float3 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x87BE0B0", Offset = "0x87BD0B0", VA = "0x1887BE0B0")]
		public void BWPVULYEBVR(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x87C2520", Offset = "0x87C1520", VA = "0x1887C2520")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanSn8MatF16_00000087$PostfixBurstDelegate))]
		private unsafe static void XEPNDVHKDAJ([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x87BEDD0", Offset = "0x87BDDD0", VA = "0x1887BEDD0")]
		public void FHOSYQVNMHW(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x87C2840", Offset = "0x87C1840", VA = "0x1887C2840")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanSn8UvMatF16_00000089$PostfixBurstDelegate))]
		private unsafe static void YVEUZUGAXKO([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x87BCBE0", Offset = "0x87BBBE0", VA = "0x1887BCBE0")]
		public void AQCOBBYNCWZ(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x87BCFF0", Offset = "0x87BBFF0", VA = "0x1887BCFF0")]
		public void AQCOBBYNCWZ(NativeArray<ushort> a, NativeArray<VertexFormat_NormTanOct8MatUi> b, Mesh c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x87BFE40", Offset = "0x87BEE40", VA = "0x1887BFE40")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanOct8MatUi_0000008C$PostfixBurstDelegate))]
		public unsafe static void KMSSRVVRJZN([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x87BC3D0", Offset = "0x87BB3D0", VA = "0x1887BC3D0")]
		public void ACLTHMFRPEU(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x87C1D00", Offset = "0x87C0D00", VA = "0x1887C1D00")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_PosFixedPoint16NormTanOct8MatUi_0000008E$PostfixBurstDelegate))]
		private unsafe static void TRRJNNSVPKS([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 b, [Out] float3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x87C0270", Offset = "0x87BF270", VA = "0x1887C0270")]
		public void OQTGDYEQGKI(Mesh a, UnityMeshFormat b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x87C1DA0", Offset = "0x87C0DA0", VA = "0x1887C1DA0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_FastCopyIndices_00000090$PostfixBurstDelegate))]
		private unsafe static void VQLQJGSUDKK(int a, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x87C1DB0", Offset = "0x87C0DB0", VA = "0x1887C1DB0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_FastCopyIndices_00000091$PostfixBurstDelegate))]
		private unsafe static void VQLQJGSUDKK(int a, int b, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x87BF620", Offset = "0x87BE620", VA = "0x1887BF620")]
		public void IAWSEDTHGMN(NativeMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x87C0060", Offset = "0x87BF060", VA = "0x1887C0060")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FastAppendIndices_00000093$PostfixBurstDelegate))]
		private unsafe static void MDWJQHQMZLW(int a, int b, int c, [In][NoAlias] int* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x87BEBB0", Offset = "0x87BDBB0", VA = "0x1887BEBB0")]
		public void DNISLBPYJRK(NativeMesh a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x87BD470", Offset = "0x87BC470", VA = "0x1887BD470")]
		public long ATZKFLPGEBR()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x87BD410", Offset = "0x87BC410", VA = "0x1887BD410")]
		public static long ATZKFLPGEBR(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x87C1B80", Offset = "0x87C0B80", VA = "0x1887C1B80")]
		public static long TPYMVTCNYZG(int a, int b, UnityMeshFormat c)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x87C1C20", Offset = "0x87C0C20", VA = "0x1887C1C20")]
		public long TPYMVTCNYZG(UnityMeshFormat a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x87BE7C0", Offset = "0x87BD7C0", VA = "0x1887BE7C0")]
		public void CKHIQOKFRYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x87C0880", Offset = "0x87BF880", VA = "0x1887C0880")]
		public static void QKXRGUEPHJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x87C0300", Offset = "0x87BF300", VA = "0x1887C0300")]
		public UnityMeshFormat QBPXDCVWWLF()
		{
			return default(UnityMeshFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x87C1B70", Offset = "0x87C0B70", VA = "0x1887C1B70")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FindBestUnityMeshFormat_Fast_0000009D$PostfixBurstDelegate))]
		private unsafe static void TJWNHCZVOIK(int a, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x87BE860", Offset = "0x87BD860", VA = "0x1887BE860")]
		public static (int, int) DBGZETHSXDZ(Mesh a)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x87BF540", Offset = "0x87BE540", VA = "0x1887BF540")]
		public static int HYSPQZWVRNS(Span<VertexAttributeDescriptor> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x87BFBB0", Offset = "0x87BEBB0", VA = "0x1887BFBB0")]
		public static long IPAWPAUGDPD(Mesh a, int b, int c)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x87BF9F0", Offset = "0x87BE9F0", VA = "0x1887BF9F0")]
		public static long IPAWPAUGDPD(Mesh a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public NativeMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x87C2580", Offset = "0x87C1580", VA = "0x1887C2580")]
		[BurstCompile]
		public unsafe static void YDBLGSNPRMH([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x87BE9C0", Offset = "0x87BD9C0", VA = "0x1887BE9C0")]
		[BurstCompile]
		public static int DHBCRDNZUJW(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x87BEA70", Offset = "0x87BDA70", VA = "0x1887BEA70")]
		[BurstCompile]
		public static uint DHBCRDNZUJW([In] float4 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x87BEB30", Offset = "0x87BDB30", VA = "0x1887BEB30")]
		[BurstCompile]
		public static uint DHBCRDNZUJW([In] float3 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x87BFE50", Offset = "0x87BEE50", VA = "0x1887BFE50")]
		[BurstCompile]
		public unsafe static void LGMTAHHCJSM([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x87C2330", Offset = "0x87C1330", VA = "0x1887C2330")]
		[BurstCompile]
		public unsafe static void XCZKQLVKIHP([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x87C0070", Offset = "0x87BF070", VA = "0x1887C0070")]
		[BurstCompile]
		public unsafe static void MYWDKFTDKLU([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x87C17F0", Offset = "0x87C07F0", VA = "0x1887C17F0")]
		[BurstCompile]
		public unsafe static void TJJJIFQKEGN([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 b, [Out] float3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x87BF4E0", Offset = "0x87BE4E0", VA = "0x1887BF4E0")]
		[BurstCompile]
		public unsafe static void HSXJLYASEKF(int a, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x87BF510", Offset = "0x87BE510", VA = "0x1887BF510")]
		[BurstCompile]
		public unsafe static void HSXJLYASEKF(int a, int b, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x87C2530", Offset = "0x87C1530", VA = "0x1887C2530")]
		[BurstCompile]
		public unsafe static void XKENWNCBNAT(int a, int b, int c, [In][NoAlias] int* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x87A9D70", Offset = "0x87A8D70", VA = "0x1887A9D70")]
		[BurstCompile]
		public unsafe static void GYKBXHEUSOF(int a, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
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
	public class IITTZSITPUJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static HFFUJNUKSUR HFFUJNUKSUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NativeList<PrimitiveShapeData> RNOHSITYRJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NativeList<MeshPartInfo> GHQMMGTCQFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public NativeList<CurveShapeRootData> OSZSJGFVOKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NativeArray<CurvePointData> XOVTCOOFIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NativeList<MeshPartInfo> MRGBCNVESQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NativeList<CurvePointOffset> CCKRCPLXVSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private List<NativeArray<CurvePointData>> TMQFXKFIDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private NativeList<OcclusionData> VYOCMFVSMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeArray<int> HJOKXXCKNJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private NativeArray<int> HCMXMPIDHVO;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private static NativeList<ShapeBatch.CollapseEntry> JPLNMMCYWCU;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int JJVIXLXPMBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAF5BF0", Offset = "0xAF4BF0", VA = "0x180AF5BF0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x16BB480", Offset = "0x16BA480", VA = "0x1816BB480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int HOTWJAZHXQK
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xAF5C50", Offset = "0xAF4C50", VA = "0x180AF5C50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x16B9E60", Offset = "0x16B8E60", VA = "0x1816B9E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x87B9C60", Offset = "0x87B8C60", VA = "0x1887B9C60")]
		public IITTZSITPUJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x87B8E40", Offset = "0x87B7E40", VA = "0x1887B8E40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x87B9010", Offset = "0x87B8010", VA = "0x1887B9010")]
		public void Dispose(JobHandle jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x87B91F0", Offset = "0x87B81F0", VA = "0x1887B91F0")]
		public void JGRFCCBFTSR(PrimitiveShapeData a, OcclusionData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x87B9840", Offset = "0x87B8840", VA = "0x1887B9840")]
		public void PHRJDCRPMQL(CurveShapeRootData a, NativeArray<CurvePointData> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x87B7B20", Offset = "0x87B6B20", VA = "0x1887B7B20")]
		public JobHandle AGPDRGRUWLK(NativeMesh a, UTJUCHVGRAU b, float3 c, quaternion d, float e, bool f, int g = 0, int h = 0)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x87B7C40", Offset = "0x87B6C40", VA = "0x1887B7C40")]
		public JobHandle AGPDRGRUWLK(NativeMesh a, UTJUCHVGRAU b, NativeList<ShapeBatch.CollapseEntry> c, float3 d, quaternion e, float f, bool g, bool h, int i = 0, int j = 0)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x87B9480", Offset = "0x87B8480", VA = "0x1887B9480")]
		public static JobHandle MKLWDFLXZLH(PrimitiveMeshGeneratorData a, NativeMesh b, NativeArray<int> c, PrimitiveShapeData d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x87B9970", Offset = "0x87B8970", VA = "0x1887B9970")]
		public static JobHandle VVSOYWRPZTR(CurveMeshGeneratorData a, NativeMesh b, CurveShapeRootData c, NativeArray<CurvePointData> d, int e, int f, JobHandle g)
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
			public QYHXMNXAJST.MinimalMeshData meshData;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x55C06B0", Offset = "0x55BF6B0", VA = "0x1855C06B0")]
			public SingleMeshData(MeshRenderer renderer, QYHXMNXAJST.MinimalMeshData meshData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x87C87A0", Offset = "0x87C77A0", VA = "0x1887C87A0")]
			public static implicit operator SingleMeshData((MeshRenderer, QYHXMNXAJST.MinimalMeshData) tuple)
			{
				return default(SingleMeshData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private static readonly ProfilerMarker RSYBUTZGLVC;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly ProfilerMarker VOXLNRLUBVG;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static readonly ProfilerMarker EDVJLYMXHWL;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly ProfilerMarker LNYZAUCRYBZ;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x87B0B20", Offset = "0x87AFB20", VA = "0x1887B0B20")]
		internal void KTDDZQBREZD(GameObject a, QYHXMNXAJST.CrowdAABB b, List<SingleMeshData> c, Material d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x87AF720", Offset = "0x87AE720", VA = "0x1887AF720")]
		internal void BRXSWENSZGV(GameObject a, QYHXMNXAJST.CrowdAABB b, List<SingleMeshData> c, List<LODGroup> d, Material e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x87AFF40", Offset = "0x87AEF40", VA = "0x1887AFF40")]
		private MeshRenderer GMWFUEVZFGC(QYHXMNXAJST.CrowdAABB a, Material b, List<SingleMeshData> c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x87AE890", Offset = "0x87AD890", VA = "0x1887AE890")]
		private List<(List<SingleMeshData>, float)> APYJLAIJVRU(QYHXMNXAJST.CrowdAABB a, List<LODGroup> b, Material c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x87B14E0", Offset = "0x87B04E0", VA = "0x1887B14E0")]
		private List<List<(List<SingleMeshData>, float)>> QKOLLBWVABB(QYHXMNXAJST.CrowdAABB a, List<LODGroup> b, Material c, [Out] int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public CrowdBatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x87B1370", Offset = "0x87B0370", VA = "0x1887B1370")]
		[CompilerGenerated]
		internal static (float, int) KXZCKLDRJEU(List<List<(List<SingleMeshData> meshList, float lodTransition)>> gathered, int[] a)
		{
			return default((float, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class CrowdOptimizer
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly ProfilerMarker MEJJURBZXEN;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly ProfilerMarker OPFBVTYBUIM;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly ProfilerMarker UABDDXCDKMS;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly ProfilerMarker QGDOTNSHCNF;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static readonly ProfilerMarker JAQBEJBZOQG;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static readonly ProfilerMarker XOWWXMPYPBR;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static readonly ProfilerMarker NATCXZWOIML;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly Log HUNVRFSGAZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private QYHXMNXAJST XFLJXQINSGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private CrowdBatch PAFWNJTMNCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Shader RIACLVSUCNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MaterialPropertyBlock PUMMGJVWZSL;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x87B4200", Offset = "0x87B3200", VA = "0x1887B4200")]
		public static void WEOBEOIOHGT(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x87B2640", Offset = "0x87B1640", VA = "0x1887B2640")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x87B3AA0", Offset = "0x87B2AA0", VA = "0x1887B3AA0")]
		public void UIRGVSRVKFY(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x87B24C0", Offset = "0x87B14C0", VA = "0x1887B24C0")]
		private bool DFPCQHLNBAZ(MeshRenderer a, [Out] MeshFilter b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x87B4750", Offset = "0x87B3750", VA = "0x1887B4750")]
		private bool ZOWSNXVCEFC(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x87B4540", Offset = "0x87B3540", VA = "0x1887B4540")]
		private void XKBDDXBKWLL(GameObject a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x87B2D90", Offset = "0x87B1D90", VA = "0x1887B2D90")]
		private List<CrowdBatch.SingleMeshData> MIZPGGSZLGM(int a, [Out] List<LODGroup> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x87B3CC0", Offset = "0x87B2CC0", VA = "0x1887B3CC0")]
		private List<(int, Material)> VIJYDCAPWWZ(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x87B2410", Offset = "0x87B1410", VA = "0x1887B2410")]
		public void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x87B3550", Offset = "0x87B2550", VA = "0x1887B3550")]
		private bool RZTIIIHEPCZ(GameObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x87B4BB0", Offset = "0x87B3BB0", VA = "0x1887B4BB0")]
		public CrowdOptimizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[BurstCompile]
	public class QYHXMNXAJST : IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x87D2B60", Offset = "0x87D1B60", VA = "0x1887D2B60")]
			public CrowdAABB(Bounds bounds)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x87D2A50", Offset = "0x87D1A50", VA = "0x1887D2A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x87D6690", Offset = "0x87D5690", VA = "0x1887D6690")]
			private float ZZLPTNJPJQX(CrowdAABB a, CrowdAABB b)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x87D6480", Offset = "0x87D5480", VA = "0x1887D6480", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly ProfilerMarker JLSDVGXBNNH;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly ProfilerMarker SEIXCIIGGNX;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static readonly ProfilerMarker RVJAICQHXLZ;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static readonly ProfilerMarker PWPKIXNVXLA;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly ProfilerMarker VSPHFPRJAGX;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private static readonly ProfilerMarker YLFBIDCWQRL;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private static readonly ProfilerMarker FXIUYNNGBYV;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static readonly ProfilerMarker ROAMXUSBUCJ;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static readonly ProfilerMarker PUXRNGSRRQT;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker THJFATEVPUB;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker UBVAJWYZQYY;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker ZYQZCFFPOWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NativeArray<Node> OJVSWUBEABE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public NativeQueue<int> VQVQOICRXUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int DTWCNWULUVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Dictionary<Material, int> EWTUIOCLDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public List<MinimalMeshData> KNYJHDFEOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public List<LODGroup> JEGDKVMMXLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Dictionary<int, MeshRenderer> GDEWTKJJSYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Queue<int> XPSMEUCWYUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Shader XFNRAXPWWRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Shader YTOGNCQJBHS;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x87C8080", Offset = "0x87C7080", VA = "0x1887C8080")]
		public QYHXMNXAJST(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x87C5AC0", Offset = "0x87C4AC0", VA = "0x1887C5AC0")]
		private void LDPMUETCBCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x87C6440", Offset = "0x87C5440", VA = "0x1887C6440")]
		public bool TTBWQXOBGTS(MeshRenderer a, MeshFilter b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x87C68B0", Offset = "0x87C58B0", VA = "0x1887C68B0")]
		public bool TTBWQXOBGTS(LODGroup a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x87C4DC0", Offset = "0x87C3DC0", VA = "0x1887C4DC0")]
		private bool Contains(MeshRenderer meshRenderer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x87C4CA0", Offset = "0x87C3CA0", VA = "0x1887C4CA0")]
		private int CNDRLAEWSDQ(MeshRenderer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x87C5F50", Offset = "0x87C4F50", VA = "0x1887C5F50")]
		private int RWGNAVJBKXI(LODGroup a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x87C4720", Offset = "0x87C3720", VA = "0x1887C4720")]
		private int BCRPNYKEDEZ(MeshFilter a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x87C5480", Offset = "0x87C4480", VA = "0x1887C5480")]
		private int JSWMWFQRAQP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x87C5C30", Offset = "0x87C4C30", VA = "0x1887C5C30")]
		private static CrowdAABB OODRQJHLPOI(CrowdAABB a, CrowdAABB b)
		{
			return default(CrowdAABB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x87C5360", Offset = "0x87C4360", VA = "0x1887C5360")]
		private static float IWKCAXGEMSN(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x87C57B0", Offset = "0x87C47B0", VA = "0x1887C57B0")]
		private int JTANFOJCHCL(int a, CrowdAABB b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x87C44F0", Offset = "0x87C34F0", VA = "0x1887C44F0")]
		private void AUEHQTUUERY(CrowdAABB a, int b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x87C4EF0", Offset = "0x87C3EF0", VA = "0x1887C4EF0")]
		private void HBNFQEWHLND(CrowdAABB a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x87C7B70", Offset = "0x87C6B70", VA = "0x1887C7B70")]
		private float ZZLPTNJPJQX(CrowdAABB a, CrowdAABB b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x87C4880", Offset = "0x87C3880", VA = "0x1887C4880")]
		private void BRDGMOQXLNB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x87C6010", Offset = "0x87C5010", VA = "0x1887C6010")]
		private void Rotate(int indexA, int indexB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x87C75E0", Offset = "0x87C65E0", VA = "0x1887C75E0")]
		private void ULBXCBJEYZZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x87C4E40", Offset = "0x87C3E40", VA = "0x1887C4E40", Slot = "4")]
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
	public class GAWTJUXZGMA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public NativeArray<RingVertex> NATNATTOECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public NativeArray<int> AZBILIFXQRS;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int JJVIXLXPMBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int HOTWJAZHXQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xAD13C0", Offset = "0xAD03C0", VA = "0x180AD13C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x87D63C0", Offset = "0x87D53C0", VA = "0x1887D63C0")]
		public GAWTJUXZGMA(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x87D6280", Offset = "0x87D5280", VA = "0x1887D6280", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x87D62E0", Offset = "0x87D52E0", VA = "0x1887D62E0")]
		public void IAWSEDTHGMN(GAWTJUXZGMA a, int b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class VTMPCMPZNBD
	{
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static GAWTJUXZGMA EZDSLXKZGBI;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static NativeList<MeshPartInfo> TJQLSZFFJAI;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static int[] CBDJGRCGWYX;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static bool EIQOHBAWXGX;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private static Dictionary<int, GAWTJUXZGMA> ALQGYSGMWGD;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static Dictionary<int, GAWTJUXZGMA> EBGQPDCOAJA;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool FAYIQESDJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x87DDA30", Offset = "0x87DCA30", VA = "0x1887DDA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static NativeList<MeshPartInfo> LTDUJGINLGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x87DDB30", Offset = "0x87DCB30", VA = "0x1887DDB30")]
			get
			{
				return default(NativeList<MeshPartInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static GAWTJUXZGMA BDNGYHBBGPM
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x87DE860", Offset = "0x87DD860", VA = "0x1887DE860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x87DDD00", Offset = "0x87DCD00", VA = "0x1887DDD00")]
		private static void KDORHOROSOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x87DD760", Offset = "0x87DC760", VA = "0x1887DD760")]
		public static int BIWTCMMEXSY(bool a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x87DDC50", Offset = "0x87DCC50", VA = "0x1887DDC50")]
		private static int FXUAOMOIRPW(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x87DE790", Offset = "0x87DD790", VA = "0x1887DE790")]
		private static int NWNWLGMBYEB(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x87DDC70", Offset = "0x87DCC70", VA = "0x1887DDC70")]
		public static int JSHTDGCNVNE(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x87DE7D0", Offset = "0x87DD7D0", VA = "0x1887DE7D0")]
		public static int XESBUBOADEV(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x87DE7C0", Offset = "0x87DD7C0", VA = "0x1887DE7C0")]
		public static int WDHRVAJWCBK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x87DDB20", Offset = "0x87DCB20", VA = "0x1887DDB20")]
		private static int EMWIFHBNWXG(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x87DE900", Offset = "0x87DD900", VA = "0x1887DE900")]
		private static int ZTGGSRISSRF(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x87DDAB0", Offset = "0x87DCAB0", VA = "0x1887DDAB0")]
		public static int EBLNIJIVGOS(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x87DDBC0", Offset = "0x87DCBC0", VA = "0x1887DDBC0")]
		public static int FSSBCJIHIDZ(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x87DE7A0", Offset = "0x87DD7A0", VA = "0x1887DE7A0")]
		public static int QUFNIYOBRLO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x87DE6A0", Offset = "0x87DD6A0", VA = "0x1887DE6A0")]
		public static GAWTJUXZGMA NTFQHWLYTKY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x87DD790", Offset = "0x87DC790", VA = "0x1887DD790")]
		private static GAWTJUXZGMA BQYGALOPRYC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x87DE920", Offset = "0x87DD920", VA = "0x1887DE920")]
		public static GAWTJUXZGMA ZZWBCVUNTHN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x87DE360", Offset = "0x87DD360", VA = "0x1887DE360")]
		private static GAWTJUXZGMA NDGZUKLQDGF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x87DD350", Offset = "0x87DC350", VA = "0x1887DD350")]
		public static void BCRRCNMCFTL()
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
		[Cpp2IlInjected.Address(RVA = "0x87D2DF0", Offset = "0x87D1DF0", VA = "0x1887D2DF0")]
		public CurveMeshGeneratorData(NativeArray<CurvePointData> pointDatas, int size = 1, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x87D2D10", Offset = "0x87D1D10", VA = "0x1887D2D10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x87CE730", Offset = "0x87CD730", VA = "0x1887CE730")]
		public CreateNativeMeshFromBatchedCurvesJob(IITTZSITPUJ batchedShapeData, NativeMesh destMesh, float3 rootPositionWS, quaternion rootRotationWS, float rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x87CE530", Offset = "0x87CD530", VA = "0x1887CE530")]
		public CreateNativeMeshFromBatchedCurvesJob(CurveMeshGeneratorData batchedShapeData, NativeMesh destMesh, float3 rootPositionWS, quaternion rootRotationWS, float3 rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x87CDE70", Offset = "0x87CCE70", VA = "0x1887CDE70")]
		private float3 TLQFAPYSQIP(float3 a, Matrix4x4 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x87CC5A0", Offset = "0x87CB5A0", VA = "0x1887CC5A0")]
		private float3x3 AYRVCZEJDPK(float3x3 a, float3x3 b)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x87CDE60", Offset = "0x87CCE60", VA = "0x1887CDE60")]
		private float QFHJADYHCRV(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x87CCBD0", Offset = "0x87CBBD0", VA = "0x1887CCBD0", Slot = "4")]
		public void Execute(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x87CCA60", Offset = "0x87CBA60", VA = "0x1887CCA60")]
		private void EMZJMKFIQDF(int a, float3 b, float3 c, float3 d, float e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x87CC620", Offset = "0x87CB620", VA = "0x1887CC620")]
		private void BLKYAUMFVYA(CurveShapeRootData a, float3 b, float3x3 c, float d, int e, int f, int g, float h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x87CDFB0", Offset = "0x87CCFB0", VA = "0x1887CDFB0")]
		private void XHOBBVBCOSG(int a, int b, CurveShapeRootData c, float3 d, float3x3 e, bool f, float g, int h, int i, int j)
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
		[Cpp2IlInjected.Address(RVA = "0x87D7AE0", Offset = "0x87D6AE0", VA = "0x1887D7AE0")]
		public PrimitiveMeshGeneratorData(int size, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x87D7A60", Offset = "0x87D6A60", VA = "0x1887D7A60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x87D1AE0", Offset = "0x87D0AE0", VA = "0x1887D1AE0")]
		public CreateNativeMeshFromShapeBatchJob(IITTZSITPUJ batchedShapeData, NativeMesh destMesh, NativeArray<int> destVertCollapseTargetIn, float3 rootPositionWS, quaternion rootRotationWS, float rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x87D18E0", Offset = "0x87D08E0", VA = "0x1887D18E0")]
		public CreateNativeMeshFromShapeBatchJob(PrimitiveMeshGeneratorData data, NativeMesh destMesh, NativeArray<int> destVertCollapseTargetIn, float3 rootPositionWS, quaternion rootRotationWS, float3 rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x87D0360", Offset = "0x87CF360", VA = "0x1887D0360", Slot = "4")]
		public void Execute(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x87D13F0", Offset = "0x87D03F0", VA = "0x1887D13F0")]
		private void LUSKGHKFMFH(float4x4 a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x87D1830", Offset = "0x87D0830", VA = "0x1887D1830")]
		private ProjectionAxis NFOAPZZVPXG(float3 a)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x87D0310", Offset = "0x87CF310", VA = "0x1887D0310")]
		private float4 AEEDVLENMAE(ProjectionAxis a, int b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x87D18A0", Offset = "0x87D08A0", VA = "0x1887D18A0")]
		private float2 WXTYHNHLBXW(ProjectionAxis a, float3 b)
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
		[Cpp2IlInjected.Address(RVA = "0x87CFC80", Offset = "0x87CEC80", VA = "0x1887CFC80")]
		private float3 TLQFAPYSQIP(float3 a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x87CE910", Offset = "0x87CD910", VA = "0x1887CE910")]
		private float3x3 AYRVCZEJDPK(float3x3 a)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x87CFC70", Offset = "0x87CEC70", VA = "0x1887CFC70")]
		private float QFHJADYHCRV(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x87CF000", Offset = "0x87CE000", VA = "0x1887CF000", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x87CEE90", Offset = "0x87CDE90", VA = "0x1887CEE90")]
		private void EMZJMKFIQDF(int a, float3 b, float3 c, float3 d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x87CE9A0", Offset = "0x87CD9A0", VA = "0x1887CE9A0")]
		private void BLKYAUMFVYA(CurvePointData a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x87CFDC0", Offset = "0x87CEDC0", VA = "0x1887CFDC0")]
		private void XHOBBVBCOSG(int a, int b, float3 c, float3x3 d, bool e, float f, int g, float h)
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
		[Cpp2IlInjected.Address(RVA = "0x87D1CF0", Offset = "0x87D0CF0", VA = "0x1887D1CF0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x87D2720", Offset = "0x87D1720", VA = "0x1887D2720")]
		private void LUSKGHKFMFH(float4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x87D1830", Offset = "0x87D0830", VA = "0x1887D1830")]
		private ProjectionAxis NFOAPZZVPXG(float3 a)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x87D0310", Offset = "0x87CF310", VA = "0x1887D0310")]
		private float4 AEEDVLENMAE(ProjectionAxis a, int b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x87D18A0", Offset = "0x87D08A0", VA = "0x1887D18A0")]
		private float2 WXTYHNHLBXW(ProjectionAxis a, float3 b)
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
		public bool ZRJXSFPYKWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x87D78F0", Offset = "0x87D68F0", VA = "0x1887D78F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float3 TVXEZBUSGRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x87D7270", Offset = "0x87D6270", VA = "0x1887D7270")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x87D7970", Offset = "0x87D6970", VA = "0x1887D7970")]
		public OcclusionData(float3 position, quaternion rotation, float3 size, OcclusionType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x87D75E0", Offset = "0x87D65E0", VA = "0x1887D75E0")]
		public float RJERDMFVCWV(float3 a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x87D7800", Offset = "0x87D6800", VA = "0x1887D7800")]
		public bool RXXEBLKILTZ(float3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x87D70C0", Offset = "0x87D60C0", VA = "0x1887D70C0")]
		public void EUMVCJTSEKV(float3 a, float3x3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x87D6FA0", Offset = "0x87D5FA0", VA = "0x1887D6FA0")]
		private void DLTYBVYFHUO(float3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x87D7350", Offset = "0x87D6350", VA = "0x1887D7350")]
		public void ODKGTVSWGEB()
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
		[Cpp2IlInjected.Address(RVA = "0x87D3BF0", Offset = "0x87D2BF0", VA = "0x1887D3BF0")]
		public DetectEnclosedTrianglesBatchedJob(NativeMesh mesh, float rootScale, int startIndex, int startVertex, NativeList<OcclusionData> data, NativeArray<int> shapeOcclusionDataIdx, NativeList<MeshPartInfo> shapeDest, UTJUCHVGRAU optimizationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x87D2F20", Offset = "0x87D1F20", VA = "0x1887D2F20", Slot = "4")]
		public void Execute(int shapeIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x87D3B30", Offset = "0x87D2B30", VA = "0x1887D3B30")]
		private bool TAAWLJNLEPW(OcclusionData a, OcclusionData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x87D37F0", Offset = "0x87D27F0", VA = "0x1887D37F0")]
		private bool JYTZYNYSOXE(OcclusionData a, int b, int c, int d)
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
		[Cpp2IlInjected.Address(RVA = "0x87D3C80", Offset = "0x87D2C80", VA = "0x1887D3C80", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x87D4410", Offset = "0x87D3410", VA = "0x1887D4410")]
		private bool SMLDHYBAUQG(OcclusionData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x87D40D0", Offset = "0x87D30D0", VA = "0x1887D40D0")]
		private bool JYTZYNYSOXE(OcclusionData a, int b, int c, int d)
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
		[Cpp2IlInjected.Address(RVA = "0x15E4F60", Offset = "0x15E3F60", VA = "0x1815E4F60")]
		public InitializeCollapseListJob(NativeArray<int> vertCollapseTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x87D6E20", Offset = "0x87D5E20", VA = "0x1887D6E20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x87D5CD0", Offset = "0x87D4CD0", VA = "0x1887D5CD0")]
		public FinalizeNativeMeshCollapseListJob(NativeList<ShapeBatch.CollapseEntry> destCollapseList, NativeArray<int> srcVertCollapseTarget, int vertexStart = 0, int indexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x87D5C20", Offset = "0x87D4C20", VA = "0x1887D5C20", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class UTJUCHVGRAU : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public NativeArray<bool> FOIXYCRJJCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public NativeArray<int> VSMOKVIIPIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public NativeArray<bool> LSKIWZOUOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public NativeArray<float> EDXUIPHZNRY;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x87DD230", Offset = "0x87DC230", VA = "0x1887DD230")]
		public void KIRZLIOHNJC(int a, int b, Allocator c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x87DD030", Offset = "0x87DC030", VA = "0x1887DD030")]
		public static long CFVKJURAUUL(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x87DD140", Offset = "0x87DC140", VA = "0x1887DD140", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x87DD050", Offset = "0x87DC050", VA = "0x1887DD050")]
		public void Dispose(JobHandle jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public UTJUCHVGRAU()
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
		[Cpp2IlInjected.Address(RVA = "0x87D6200", Offset = "0x87D5200", VA = "0x1887D6200")]
		public FinalizeNativeMeshOptimizationsJob(NativeMesh mesh, UTJUCHVGRAU optimizationData, int vertexStart = 0, int indexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x87D5CF0", Offset = "0x87D4CF0", VA = "0x1887D5CF0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x87D6190", Offset = "0x87D5190", VA = "0x1887D6190")]
		private void FPMGZYLOIZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class LJSQCVZTPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C5A0", Offset = "0x3A5B5A0", VA = "0x183A5C5A0")]
		public static bool SQQXANOHHFT<T>(NativeArray<T> a, int b, Allocator c, NativeArrayOptions d = NativeArrayOptions.ClearMemory, int e = 3) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3A5CA20", Offset = "0x3A5BA20", VA = "0x183A5CA20")]
		public static bool SQQXANOHHFT<T>(NativeList<T> a, int b, Allocator c) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C970", Offset = "0x3A5B970", VA = "0x183A5C970")]
		public static bool SQQXANOHHFT<T>(NativeQueue<T> a, Allocator b) where T : struct
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
	public interface BQZFHYWXUWH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ASZBFYKLFEA(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int CJOUORZTPOA(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RRBounds BOVIAZRPQMM();

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float MNETCROYUCQ();

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LMTYXUFBSIQ(SystemLOD a, IITTZSITPUJ b, int c = -1);

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		int MKNQOGTIEPM(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class OKTWIDDMMHW
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x87D6E50", Offset = "0x87D5E50", VA = "0x1887D6E50")]
		public static void BCRRCNMCFTL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class FIEGGFHRHQG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public NativeList<float3> GABPYANKQCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public NativeArray<float3> PTRFOZHBHKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public NativeArray<int> CMQMPEEKKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public NativeArray<float4> MIPHLZRSIFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public NativeArray<float4> MIKAOSXUYUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public NativeArray<float4> MIETRMDXPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public NativeArray<int> TMHUSUJYBPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public NativeList<float3> ZTPZOCXSOWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public NativeList<int> PQLRKEAAEDA;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int JJVIXLXPMBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x87D4960", Offset = "0x87D3960", VA = "0x1887D4960")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int HOTWJAZHXQK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x87D4FD0", Offset = "0x87D3FD0", VA = "0x1887D4FD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int QLYTHJHFFXF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x87D49B0", Offset = "0x87D39B0", VA = "0x1887D49B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x87D5900", Offset = "0x87D4900", VA = "0x1887D5900")]
		public FIEGGFHRHQG(int a, int b, int c, Allocator d = Allocator.Persistent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x87D55A0", Offset = "0x87D45A0", VA = "0x1887D55A0")]
		public FIEGGFHRHQG(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x87D44C0", Offset = "0x87D34C0", VA = "0x1887D44C0", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x87D45D0", Offset = "0x87D35D0", VA = "0x1887D45D0")]
		public void IAWSEDTHGMN(FIEGGFHRHQG a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x87D4A00", Offset = "0x87D3A00", VA = "0x1887D4A00")]
		private void KEJSBEGCBUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x87D5020", Offset = "0x87D4020", VA = "0x1887D5020")]
		private void ZBITAZTROOE()
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
		[Cpp2IlInjected.Address(RVA = "0x23ACF00", Offset = "0x23ABF00", VA = "0x1823ACF00")]
		public MeshPartInfo(int startVertex, int vertexCount, int startIndex, int indexCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class HFFUJNUKSUR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public NativeList<MeshPartInfo> FNBYQOZBBZL
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			[CompilerGenerated]
			get
			{
				return default(NativeList<MeshPartInfo>);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xF79B00", Offset = "0xF78B00", VA = "0x180F79B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public FIEGGFHRHQG QEBAODMDIBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x87D6830", Offset = "0x87D5830", VA = "0x1887D6830")]
		public HFFUJNUKSUR(IEnumerable<FIEGGFHRHQG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x87D67C0", Offset = "0x87D57C0", VA = "0x1887D67C0", Slot = "4")]
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
	public static class YEXIYTYPRJK
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static NativeArray<float2> BCGLZZBZJYJ;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static NativeArray<float3> QHYRKEVBSMI;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static NativeArray<float4> IWIQUYLZOHF;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static NativeArray<int> RPNMUNVEHKK;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x87DF900", Offset = "0x87DE900", VA = "0x1887DF900")]
		public static void BCRRCNMCFTL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x87DFB30", Offset = "0x87DEB30", VA = "0x1887DFB30")]
		public static NativeArray<float2> RRECGFYOXXV(NativeArray<float2> a, int b, NativeArray<float2> c, int d)
		{
			return default(NativeArray<float2>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x87DFA20", Offset = "0x87DEA20", VA = "0x1887DFA20")]
		public static NativeArray<float3> JULPIWLSGEK(NativeArray<float3> a, int b, NativeArray<float3> c, int d)
		{
			return default(NativeArray<float3>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x87DFD50", Offset = "0x87DED50", VA = "0x1887DFD50")]
		public static NativeArray<float4> VAIDEGTBONH(NativeArray<float4> a, int b, NativeArray<float4> c, int d)
		{
			return default(NativeArray<float4>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x87DFC40", Offset = "0x87DEC40", VA = "0x1887DFC40")]
		public static NativeArray<int> RZCHOPZQYPC(NativeArray<int> a, int b, NativeArray<int> c, int d)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F64D20", Offset = "0x3F63D20", VA = "0x183F64D20")]
		private static void KSYWXKTKDJI<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3F65020", Offset = "0x3F64020", VA = "0x183F65020")]
		private static void ZNMRBZSYOBJ<b>(NativeArray<b> a, int b, NativeArray<b> c, int d, NativeArray<b> e) where b : struct
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
		public static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x87DF300", Offset = "0x87DE300", VA = "0x1887DF300")]
		public static uint IQYBLMKMWJH(float a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x87DEC30", Offset = "0x87DDC30", VA = "0x1887DEC30")]
		public static void BPLFOZJTPCK(float4 a, float b, [Out] uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x87DEB60", Offset = "0x87DDB60", VA = "0x1887DEB60")]
		public static void BPLFOZJTPCK(float4 a, uint b, [Out] uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x87DF060", Offset = "0x87DE060", VA = "0x1887DF060")]
		public static void GFPODTLWZMX(float3 a, float3 b, float4 c, float2 d, float4 e, [Out] NativeMesh.VertexFormat_NormTanOct8MatUi f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x87DEDA0", Offset = "0x87DDDA0", VA = "0x1887DEDA0")]
		public static void GFPODTLWZMX(float3 a, float3 b, float4 c, float2 d, float4 e, [Out] NativeMesh.VertexFormat_PosFixedPoint16NormTanOct8MatUi f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x87DF6C0", Offset = "0x87DE6C0", VA = "0x1887DF6C0")]
		public static byte UQFDWYGQXSH(float a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x87DED40", Offset = "0x87DDD40", VA = "0x1887DED40")]
		public static ushort DSOLCYSTNCO(float a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x87DF690", Offset = "0x87DE690", VA = "0x1887DF690")]
		public static uint RQJSHDMWUYY(float a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x87DF610", Offset = "0x87DE610", VA = "0x1887DF610")]
		public static float2 QBZJPQZGSOZ(float2 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x87DF310", Offset = "0x87DE310", VA = "0x1887DF310")]
		public static float2 LHFHKJILPLJ(float3 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x87DF720", Offset = "0x87DE720", VA = "0x1887DF720")]
		public static void XRRNJFRQIWM(float3 a, [Out] float3 b, [Out] uint3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x87DF460", Offset = "0x87DE460", VA = "0x1887DF460")]
		public static CompressedPositionFixedPoint16 LMGCKZYYWYQ(float3 a)
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
		public static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private static readonly ProfilerMarker UQQMUNANZHP;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public static float JYMJYNIWIZI;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void LNFOQCVVMFI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x87DC7B0", Offset = "0x87DB7B0", VA = "0x1887DC7B0")]
		public static float LVXNTXUHJIT(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x87DC6C0", Offset = "0x87DB6C0", VA = "0x1887DC6C0")]
		public static long LQMOSCGBKKN(float a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x87DC930", Offset = "0x87DB930", VA = "0x1887DC930")]
		public static void ZNXHBPNTHLC(float a)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Quartermaster
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public interface JEXPPLGJTBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZNXHBPNTHLC(float a);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		(long, long, int) TGDZRRJYMIZ(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public static class ZKFLOJHDYFQ
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
		private class ZVQGLVFZWZX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public WorkItemTypeEnum DCVVHWLTKKV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public BatchedMeshRenderer ZTYIVAPZVJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public BatchedMesh BVKSQOWKULR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public ShapeBatch IAJJQSFNQAG;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x87E0E80", Offset = "0x87DFE80", VA = "0x1887E0E80")]
			public void RQVZPYQVOCQ([Out] bool a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public ZVQGLVFZWZX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private static int TQBEADRNZDP;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private static ObjectPool<ZVQGLVFZWZX> HLVEPGMFBAV;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x87E0A00", Offset = "0x87DFA00", VA = "0x1887E0A00")]
		static ZKFLOJHDYFQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x87E0150", Offset = "0x87DF150", VA = "0x1887E0150")]
		private static void JNAQHGHXBRM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x87E04C0", Offset = "0x87DF4C0", VA = "0x1887E04C0")]
		private static void MDSFZHDUWQM([In] QuartermasterWorkItem workItem, [Out] bool a, [Out] bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x87E0330", Offset = "0x87DF330", VA = "0x1887E0330")]
		public static void JOKHFCLNZAI(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x87E0870", Offset = "0x87DF870", VA = "0x1887E0870")]
		public static void ZWZQQAFQGON(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x87E06F0", Offset = "0x87DF6F0", VA = "0x1887E06F0")]
		public static void TUBEEUUXGKK(BatchedMesh a, BatchedMeshRenderer b, long c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x87E0560", Offset = "0x87DF560", VA = "0x1887E0560")]
		public static void TOSCGQJOPBI(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x87DFE60", Offset = "0x87DEE60", VA = "0x1887DFE60")]
		private static void HISDBFVNLLV(WorkItemTypeEnum a, ShapeBatch b, BatchedMesh c, BatchedMeshRenderer d, long e, long f, float g, bool h, bool i, float j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public static class QuartermasterManager
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly ProfilerMarker JLRJCKTTIBX;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private static readonly ProfilerMarker IOQIBKWOQYQ;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private static readonly ProfilerMarker CHBLVBYTZLC;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static readonly ProfilerMarker YPAQHCQBIQS;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public static int ZQCAIOHPVHH;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public static int HEZYIWIPRAR;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public static int TWLIVYCKPIP;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public static long JIXTKPOJGBH;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public static long SQJIFTXSIBG;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public static long ANTGWRKJUQT;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public static long APQTRDDHXEI;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public static int CMLOEBSQJEU;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public static float FLGUTDZGAVQ;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public static bool BOKJATSOGMB;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public static int SMFVPEODBII;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public static int PORUJICVSPE;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public static int XGPMGBAQADC;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public static long EEKPVOJBWWB;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public static int RHDELNALUDO;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public static bool INRSWDGJACQ;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static uint HMAIUKOTCJU;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private static RMHKCWYHSKQ WSLIVVQTAMQ;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static List<uint> GXAQHNKZOGE;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static List<(QuartermasterWorkItem.Execute, QuartermasterWorkItem.Release)> XFUVLRYAGVI;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private static JEXPPLGJTBL TSQHURFJWDD;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private static JEXPPLGJTBL RMTDZSPCOFZ;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool TWDFBEFYSZH
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x87D8170", Offset = "0x87D7170", VA = "0x1887D8170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void LPVWHVNVMOD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void LNFOQCVVMFI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void LPVWHVNVMOD(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x87D7F20", Offset = "0x87D6F20", VA = "0x1887D7F20")]
		public static void LIHTVPSGLDZ(JEXPPLGJTBL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x87D7D60", Offset = "0x87D6D60", VA = "0x1887D7D60")]
		public static void HEXROPWNHZH(JEXPPLGJTBL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x87D7FA0", Offset = "0x87D6FA0", VA = "0x1887D7FA0")]
		public static (long, long, long, int, int) LKTENKNTXQG(long a)
		{
			return default((long, long, long, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x87D7BD0", Offset = "0x87D6BD0", VA = "0x1887D7BD0")]
		public static void ACBMJCFARSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x87D92F0", Offset = "0x87D82F0", VA = "0x1887D92F0")]
		public static void ZNXHBPNTHLC(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x87D8960", Offset = "0x87D7960", VA = "0x1887D8960")]
		public static void TXDXTXGPFBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x87D8FB0", Offset = "0x87D7FB0", VA = "0x1887D8FB0")]
		public static long WRWVTHDNNKF(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x87D9150", Offset = "0x87D8150", VA = "0x1887D9150")]
		public static bool XPYBEOFEUOZ(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x87D9220", Offset = "0x87D8220", VA = "0x1887D9220")]
		public static bool YTUZKDXVPOG(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x87D8B00", Offset = "0x87D7B00", VA = "0x1887D8B00")]
		public static float UJIGQEMTXRF(long a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x87D84E0", Offset = "0x87D74E0", VA = "0x1887D84E0")]
		public static (long, long, int) TGDZRRJYMIZ(float a)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x87D81C0", Offset = "0x87D71C0", VA = "0x1887D81C0")]
		public static void SRMMAJBROWL(QuartermasterWorkItem a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x87D8E60", Offset = "0x87D7E60", VA = "0x1887D8E60")]
		public static int VVUZFFVZXXQ(QuartermasterWorkItem.Execute a, QuartermasterWorkItem.Release b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x87D7DE0", Offset = "0x87D6DE0", VA = "0x1887D7DE0")]
		public static bool JTBLSJMFMXP(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x87D7EA0", Offset = "0x87D6EA0", VA = "0x1887D7EA0")]
		public static void LHTUZLCUMBB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x87D7C50", Offset = "0x87D6C50", VA = "0x1887D7C50")]
		public static bool EKAUXWVUPOA(float a)
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
		[Cpp2IlInjected.Address(RVA = "0x87DBE90", Offset = "0x87DAE90", VA = "0x1887DBE90", Slot = "4")]
		private int WBSGEFTHXDC(QuartermasterWorkItem a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x87DBE80", Offset = "0x87DAE80", VA = "0x1887DBE80", Slot = "5")]
		private bool QPWKRJVONJT(QuartermasterWorkItem a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class RMHKCWYHSKQ
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
			public QuartermasterWorkItem NHMTQMXSIMG
			{
				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0x87EC6F0", Offset = "0x87EB6F0", VA = "0x1887EC6F0")]
				get
				{
					return default(QuartermasterWorkItem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x87EC9C0", Offset = "0x87EB9C0", VA = "0x1887EC9C0")]
			public QuartermasterWorkItemEnumerator(List<QuartermasterWorkItem> instantWorkItems, List<QuartermasterWorkItem> persistentWorkItems)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x87EC870", Offset = "0x87EB870", VA = "0x1887EC870")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private List<QuartermasterWorkItem> KHUFMOQPDUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private List<QuartermasterWorkItem> RPIPCFZSIOP;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int ZRHYXWVKFWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x87DC040", Offset = "0x87DB040", VA = "0x1887DC040")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x87DBEB0", Offset = "0x87DAEB0", VA = "0x1887DBEB0")]
		public void Add([In] QuartermasterWorkItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x87DC5B0", Offset = "0x87DB5B0", VA = "0x1887DC5B0")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x87DBFA0", Offset = "0x87DAFA0", VA = "0x1887DBFA0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x87DC0D0", Offset = "0x87DB0D0", VA = "0x1887DC0D0")]
		public void HRFKEIDRCVU(IEnumerable<uint> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x87DC3D0", Offset = "0x87DB3D0", VA = "0x1887DC3D0")]
		private static void KJOPGSWTNPT(List<QuartermasterWorkItem> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x87DC4A0", Offset = "0x87DB4A0", VA = "0x1887DC4A0")]
		private void Remove(uint id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x87DC090", Offset = "0x87DB090", VA = "0x1887DC090")]
		public QuartermasterWorkItemEnumerator GetEnumerator()
		{
			return default(QuartermasterWorkItemEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x87DC610", Offset = "0x87DB610", VA = "0x1887DC610")]
		public RMHKCWYHSKQ()
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
		public static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private static readonly string PEIWZDJSSNL;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static readonly string HNJWXWAJCLI;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private static readonly ProfilerMarker WZVZCBWJRMS;

		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private static readonly ProfilerMarker RJVRERVDFKP;

		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private static readonly ProfilerMarker UQQMUNANZHP;

		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private static readonly ProfilerMarker XHXTIJLEXVV;

		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static readonly ProfilerMarker IDIECFBQXUD;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static readonly ProfilerMarker ZUBVJINKKXQ;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly ProfilerMarker EKQIOBSBDAK;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static readonly ProfilerMarker LSOAGOGXLWC;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static readonly ProfilerMarker YBYJKUHRZUU;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static readonly ProfilerMarker AKOINZSQEHW;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly ProfilerMarker ALEDFUAIGPX;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static readonly ProfilerMarker AKYWINGKXEO;

		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private static readonly ProfilerMarker AJYNWFKYBZV;

		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private static readonly ProfilerMarker AJTGYYRASOM;

		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private static readonly ProfilerMarker AKJBQSYSUWN;

		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private static readonly ProfilerMarker AKDUTMEVLLE;

		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private static readonly ProfilerMarker AMJSPIPSLFZ;

		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private static readonly ProfilerMarker EIDWHICSEIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		internal readonly List<ShapeBatch> SDVDJSMOSAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private readonly DisposeReminder ONQWMWCTGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private int HLQTQHUTFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private int DXAPEBECJUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private bool STIUXZPAVZQ;

		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public const bool LKALSIFGQEY = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public bool KOCVMMAIOFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		internal ScalabilityStateMesh LJNFWXPRCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		internal int WTHSQVAYLAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		internal int UTVBWFOAVHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		internal int NTTYBRVVDBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		internal int FPSWSSLICWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		internal long CEESTTPDGYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		internal long KXXMYESHRLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		internal long MYNHPZQISIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private NativeMesh ZMUVXQMJXJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private NativeMesh YRWTWKMGZCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private NativeMesh.UnityMeshFormat CGTCPZDBXFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private bool QXWDSNQDHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private int OWJCUPPLZRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private BatchedMeshTessellate MSXLCTSUDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private float3 ANLFSKHPGUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private float SSOADGQKDDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private float XEOKJDLLATF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private float WUXMNACZRBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private float PTFNRLROFSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private float JVTALYOQIYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private float UDCCAFMAKVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private float3 WQXUMIFWPAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private float YZCHUMDYKKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private float TRSINJTMUFN;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal Mesh QEBAODMDIBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xACFB20", Offset = "0xACEB20", VA = "0x180ACFB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public MeshFilter JONSMZOYXTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DC0", Offset = "0xACFDC0", VA = "0x180AD0DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public MeshRenderer NBNSLHKMJMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xAD8F70", Offset = "0xAD7F70", VA = "0x180AD8F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public List<Material> EGYLNRPTNOS
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xACFFA0", Offset = "0xACEFA0", VA = "0x180ACFFA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xACFF40", Offset = "0xACEF40", VA = "0x180ACFF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int DLPNLERQWKC
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xFD7160", Offset = "0xFD6160", VA = "0x180FD7160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int JJVIXLXPMBQ
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x87E8E90", Offset = "0x87E7E90", VA = "0x1887E8E90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int HOTWJAZHXQK
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x87E97E0", Offset = "0x87E87E0", VA = "0x1887E97E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x87E9630", Offset = "0x87E8630", VA = "0x1887E9630")]
		public void OUHPQPOBZKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x87E7F90", Offset = "0x87E6F90", VA = "0x1887E7F90")]
		public bool AVWQXMOPJFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x87EA440", Offset = "0x87E9440", VA = "0x1887EA440")]
		private void UTEOJQQUVDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x87E8490", Offset = "0x87E7490", VA = "0x1887E8490")]
		private void DVKBLTXGVIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x87EC150", Offset = "0x87EB150", VA = "0x1887EC150")]
		public BatchedMesh(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x87E85B0", Offset = "0x87E75B0", VA = "0x1887E85B0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x87E9230", Offset = "0x87E8230", VA = "0x1887E9230")]
		private void MSTLRKGEEWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x87E82A0", Offset = "0x87E72A0", VA = "0x1887E82A0")]
		private void CreateNewUnityMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x87EA3A0", Offset = "0x87E93A0", VA = "0x1887EA3A0")]
		private void UGGQKRJVVJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x87E9D20", Offset = "0x87E8D20", VA = "0x1887E9D20")]
		public Mesh RHMDVRTKPYV(MeshFilter a, Transform b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x87E9D90", Offset = "0x87E8D90", VA = "0x1887E9D90")]
		public void SWRTDLTJSRQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x87EA2E0", Offset = "0x87E92E0", VA = "0x1887EA2E0")]
		private void TZZBJWKLSLW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x87E72F0", Offset = "0x87E62F0", VA = "0x1887E72F0")]
		public void AALNAAUPBDR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x87E8AA0", Offset = "0x87E7AA0", VA = "0x1887E8AA0")]
		public void EOZBXFZLRIR(BQZFHYWXUWH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x87E9F70", Offset = "0x87E8F70", VA = "0x1887E9F70")]
		public bool SZBDJLYJLTG(BQZFHYWXUWH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x87E81C0", Offset = "0x87E71C0", VA = "0x1887E81C0")]
		public bool Contains(BQZFHYWXUWH meshGenerator)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x87E96D0", Offset = "0x87E86D0", VA = "0x1887E96D0", Slot = "4")]
		public virtual void PUOXTCRLBYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x87E9800", Offset = "0x87E8800", VA = "0x1887E9800")]
		public void QTRCCFRVTZZ(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x87EA790", Offset = "0x87E9790", VA = "0x1887EA790")]
		public bool WPPNBYGGUYI(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x87E9410", Offset = "0x87E8410", VA = "0x1887E9410")]
		public bool OTDOBCPLSEB(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x87E9370", Offset = "0x87E8370", VA = "0x1887E9370")]
		private void OQAWYWCCDBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x87EABB0", Offset = "0x87E9BB0", VA = "0x1887EABB0")]
		public bool ZNXHBPNTHLC([In] float4x4 worldFromLocal, BatchedMeshRenderer a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x87E8EB0", Offset = "0x87E7EB0", VA = "0x1887E8EB0")]
		public bool JBXBBBATRPY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x87E7390", Offset = "0x87E6390", VA = "0x1887E7390")]
		public bool ACPIYZFWWMX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x87E8F60", Offset = "0x87E7F60", VA = "0x1887E8F60")]
		public void LKPRGZXYWTL(NativeMesh a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x87E7E90", Offset = "0x87E6E90", VA = "0x1887E7E90")]
		public (long, long, long) ATZKFLPGEBR()
		{
			return default((long, long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xACEBE0", Offset = "0xACDBE0", VA = "0x180ACEBE0")]
		public long WKDEQZATLWD()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x87EA4E0", Offset = "0x87E94E0", VA = "0x1887EA4E0")]
		private void VKAIHJHUAXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x87EA0D0", Offset = "0x87E90D0", VA = "0x1887EA0D0")]
		public (long, long, int) TGDZRRJYMIZ(float a, [In] float4x4 worldFromLocal)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x10B6990", Offset = "0x10B5990", VA = "0x1810B6990")]
		internal void IGMYXEUACHK(ScalabilityStateMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x87EB460", Offset = "0x87EA460", VA = "0x1887EB460")]
		internal (float, float, float, float) ZZRBCZUDHCM(float a, [In] float4x4 worldFromLocal)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x87E8C90", Offset = "0x87E7C90", VA = "0x1887E8C90")]
		private void GFXDSZXNEFC(NativeMesh a, NativeMesh.UnityMeshFormat b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x87EA770", Offset = "0x87E9770", VA = "0x1887EA770")]
		private void WMROXQZOTSO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x87E8030", Offset = "0x87E7030", VA = "0x1887E8030")]
		internal bool CTIWIVMEVXP(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x87E86E0", Offset = "0x87E76E0", VA = "0x1887E86E0")]
		private void EIHQWVOGQSX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x87E92D0", Offset = "0x87E82D0", VA = "0x1887E92D0")]
		private void NECZXAOEVRB(NativeMesh.UnityMeshFormat a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x87E9050", Offset = "0x87E8050", VA = "0x1887E9050")]
		private void LKUUEFRQLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x87EA9C0", Offset = "0x87E99C0", VA = "0x1887EA9C0")]
		public long WRWVTHDNNKF(long a, int b)
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
			[Cpp2IlInjected.Address(RVA = "0x87ECA80", Offset = "0x87EBA80", VA = "0x1887ECA80")]
			public void RTFNZEQTDKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x87ECA00", Offset = "0x87EBA00", VA = "0x1887ECA00")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private static readonly string PEIWZDJSSNL;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private static readonly string HNJWXWAJCLI;

		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private static readonly ProfilerMarker WZVZCBWJRMS;

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private static readonly ProfilerMarker ELXZUGKITPK;

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private static readonly ProfilerMarker UQQMUNANZHP;

		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private static readonly ProfilerMarker FOTQRYSCRDI;

		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private static readonly ProfilerMarker XHXTIJLEXVV;

		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private static readonly ProfilerMarker IDIECFBQXUD;

		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private static readonly ProfilerMarker ZUBVJINKKXQ;

		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private static readonly ProfilerMarker EKQIOBSBDAK;

		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private static readonly ProfilerMarker LSOAGOGXLWC;

		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private static readonly ProfilerMarker YXATHVOQXDE;

		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private static readonly ProfilerMarker YBYJKUHRZUU;

		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private static readonly ProfilerMarker XQQDDDWTQYK;

		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private static readonly ProfilerMarker KAWUEKDNOWQ;

		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private static readonly ProfilerMarker NPFMFZOPBNJ;

		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private static readonly ProfilerMarker LAVILOOKRYM;

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static readonly ProfilerMarker AKOINZSQEHW;

		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private static readonly ProfilerMarker ALEDFUAIGPX;

		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private static readonly ProfilerMarker AKYWINGKXEO;

		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private static readonly ProfilerMarker AJYNWFKYBZV;

		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private static readonly ProfilerMarker AJTGYYRASOM;

		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private static readonly ProfilerMarker AKJBQSYSUWN;

		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private static readonly ProfilerMarker AKDUTMEVLLE;

		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private static readonly ProfilerMarker AMJSPIPSLFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		internal readonly List<BQZFHYWXUWH> RHUVEBCXLOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		internal BatchedMesh PHYSXXTDCUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private readonly DisposeReminder ONQWMWCTGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		internal int SNRTRVHDPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		internal int OATTWIURFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		internal bool INZNBPVHCVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		internal bool DNWUIJEMGYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		internal ScalabilityStateShapes NPTRQIUZUKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		internal bool GEWAKVDATYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		internal float3 FBYOGNYTUFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		internal float3 GVQUYMDKQWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		internal float JPMDXOFMIAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		internal int XXNCTZMJYTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		internal int DDYZCAWXRQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		internal int SFPYEOSLBNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		internal float QVJHEFCSCSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		internal int AXARKUFKJSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		internal float POQRGMAPWUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		internal float WBISXZICBQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		internal int NFYVKKFJAEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		internal long SZJYCQNHWTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public int QCYTYBDBZSN;

		[Cpp2IlInjected.Token(Token = "0x4000270")]
		internal const int MTPOMPFCKGK = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		internal float[] SAGIAODULKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		internal int[] NRISQMINFBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		internal long[] NPSBJUXUOHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public List<ScaledMesh> ZWJQKCCJBVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		internal NativeMesh IAOAMIHCFNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		internal long NXMBTHBGEIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		internal int ASSPJPIACVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		internal float YXWBNOGOVNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		internal NativeMesh.UnityMeshFormat EQMSLEIZVHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		internal CompressedNativeMeshStruct CMMSVEVSVIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		internal int KPYJCINTWZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		internal float OXAWNOUPRUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		internal long KRHOQDFEBTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		internal bool PBHKHCYIXEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		internal ScaleMeshToDesiredTriCountsJob YFZRNICBKFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		internal JobHandle APJJUMINQNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		internal NativeList<CollapseEntry> KJTUZJNQGSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		internal NativeArray<long> QNFPXRBJCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		internal bool JWKRZTTBOQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		internal JobHandle PTFEPXCOBVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		internal NativeMesh AEMOQVSBZJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		internal UTJUCHVGRAU XUNXUNBOJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		internal NativeList<CollapseEntry> KLOHBQJVPZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		internal Transform QXSWQGVMNEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		internal SystemLOD FIBIAYVWKTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		internal long AOCLPWPWHRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		internal long KCXDBAWTTZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		internal long QECRDYZGRNE;

		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private static bool WXPMQSWCJZO;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public List<BQZFHYWXUWH> WKIELAODWPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal int JJVIXLXPMBQ
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x87EF8D0", Offset = "0x87EE8D0", VA = "0x1887EF8D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x87F1F40", Offset = "0x87F0F40", VA = "0x1887F1F40")]
		internal void OUHPQPOBZKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x87F3330", Offset = "0x87F2330", VA = "0x1887F3330")]
		internal void UTEOJQQUVDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x87F6210", Offset = "0x87F5210", VA = "0x1887F6210")]
		internal ShapeBatch(string name, BatchedMesh parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x87EE970", Offset = "0x87ED970", VA = "0x1887EE970")]
		internal void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x87F2FE0", Offset = "0x87F1FE0", VA = "0x1887F2FE0")]
		internal void TZZBJWKLSLW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x87EF600", Offset = "0x87EE600", VA = "0x1887EF600")]
		internal void GNFVUUKEBNE(BQZFHYWXUWH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x87EF850", Offset = "0x87EE850", VA = "0x1887EF850")]
		internal bool HBQCKJBWQJL(BQZFHYWXUWH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x87F2280", Offset = "0x87F1280", VA = "0x1887F2280")]
		internal bool SOQDPJAMCYB(BQZFHYWXUWH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x87F2150", Offset = "0x87F1150", VA = "0x1887F2150", Slot = "4")]
		internal virtual void PUOXTCRLBYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x87EF510", Offset = "0x87EE510", VA = "0x1887EF510")]
		public float FEHOTHTRORH(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x87F1F50", Offset = "0x87F0F50", VA = "0x1887F1F50")]
		public bool PKQTUTOWHNK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x87F22E0", Offset = "0x87F12E0", VA = "0x1887F22E0")]
		public (CompressedNativeMeshStruct, NativeMesh.UnityMeshFormat) SPYYHBHQVLW()
		{
			return default((CompressedNativeMeshStruct, NativeMesh.UnityMeshFormat));
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x87F21D0", Offset = "0x87F11D0", VA = "0x1887F21D0")]
		internal long RPEITZERDHH()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x87F3470", Offset = "0x87F2470", VA = "0x1887F3470")]
		internal long UYBEKFDSQKE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x87ECAE0", Offset = "0x87EBAE0", VA = "0x1887ECAE0")]
		internal bool AGOSRQFFCFZ(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x87F1100", Offset = "0x87F0100", VA = "0x1887F1100")]
		internal bool OTDOBCPLSEB(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x87F0CE0", Offset = "0x87EFCE0", VA = "0x1887F0CE0")]
		internal void OQAWYWCCDBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x87F4560", Offset = "0x87F3560", VA = "0x1887F4560")]
		internal bool ZNXHBPNTHLC([In] float4x4 worldFromLocal, BatchedMeshRenderer a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x87EE430", Offset = "0x87ED430", VA = "0x1887EE430")]
		internal bool BKSYNLMDKWK(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x87EE960", Offset = "0x87ED960", VA = "0x1887EE960")]
		internal void CZXTSIPDNEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x87EFF50", Offset = "0x87EEF50", VA = "0x1887EFF50")]
		internal void LKPRGZXYWTL(NativeMesh a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x87F42D0", Offset = "0x87F32D0", VA = "0x1887F42D0")]
		internal void YLEAEFTLUDC(CompressedNativeMeshStruct a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x87F3590", Offset = "0x87F2590", VA = "0x1887F3590")]
		internal void VKAIHJHUAXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x87F2910", Offset = "0x87F1910", VA = "0x1887F2910")]
		internal (long, long, int) TGDZRRJYMIZ(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xACFF80", Offset = "0xACEF80", VA = "0x180ACFF80")]
		internal void IGMYXEUACHK(ScalabilityStateShapes a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x87F5790", Offset = "0x87F4790", VA = "0x1887F5790")]
		public static (float, float, float, float) ZZRBCZUDHCM(float3 a, float3 b, float c, [In] float4x4 worldFromLocal, float d)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x87F5580", Offset = "0x87F4580", VA = "0x1887F5580")]
		internal (float, float, float, float) ZZRBCZUDHCM(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x87ECAB0", Offset = "0x87EBAB0", VA = "0x1887ECAB0")]
		private float AAOGFSOBVUZ(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x87F3D60", Offset = "0x87F2D60", VA = "0x1887F3D60")]
		private (int, int, float) XKIKHICTKMK(float a)
		{
			return default((int, int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x87F0C30", Offset = "0x87EFC30", VA = "0x1887F0C30")]
		internal static float NMYHUJDCTSS(BQZFHYWXUWH a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x87ED600", Offset = "0x87EC600", VA = "0x1887ED600")]
		internal void BGYWZUMHPXO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x87EFF80", Offset = "0x87EEF80", VA = "0x1887EFF80")]
		internal void LKUUEFRQLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x87F2DA0", Offset = "0x87F1DA0", VA = "0x1887F2DA0")]
		internal void TOMFDTOSWXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x87F3780", Offset = "0x87F2780", VA = "0x1887F3780")]
		internal long WRWVTHDNNKF(long a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x87F00A0", Offset = "0x87EF0A0", VA = "0x1887F00A0")]
		private void NKGGILGOHBG(NativeMesh a, NativeList<CollapseEntry> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x87EE6C0", Offset = "0x87ED6C0", VA = "0x1887EE6C0")]
		internal void CHDUDCMPWWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x87EF8F0", Offset = "0x87EE8F0", VA = "0x1887EF8F0")]
		public static void IMFNDUATRFI(NativeList<CollapseEntry> a, NativeMesh b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x87F0010", Offset = "0x87EF010", VA = "0x1887F0010")]
		private float MSVDPTTNGFY(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x87EEAA0", Offset = "0x87EDAA0", VA = "0x1887EEAA0")]
		internal void ECAWXPTVTDG(NativeMesh a, CompressedNativeMesh b, int c, int d, float e)
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
		public delegate void TessellateTri_00000270$PostfixBurstDelegate(BatchedMeshTessellateJob bmtj, [In] TriToTessellate tri);

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		internal static class UAZBKIZCTEB
		{
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x87F6A90", Offset = "0x87F5A90", VA = "0x1887F6A90")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x87F6910", Offset = "0x87F5910", VA = "0x1887F6910")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x87E5D50", Offset = "0x87E4D50", VA = "0x1887E5D50")]
			public static void Invoke(BatchedMeshTessellateJob bmtj, [In] TriToTessellate tri)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void TessellateQuad_00000271$PostfixBurstDelegate(BatchedMeshTessellateJob bmtj, [In] QuadToTessellate quad);

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		internal static class HWJEHDBDRPI
		{
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x87EC560", Offset = "0x87EB560", VA = "0x1887EC560")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x87EC3E0", Offset = "0x87EB3E0", VA = "0x1887EC3E0")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x87E2EF0", Offset = "0x87E1EF0", VA = "0x1887E2EF0")]
			public static void Invoke(BatchedMeshTessellateJob bmtj, [In] QuadToTessellate quad)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void BuildNativeMesh_00000274$PostfixBurstDelegate(UnsafeList<int>* resultIndices, UnsafeList<float3>* resultVerts, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* newVerts, UnsafeList<int>* newIndices, UnsafeList<float3>* inMeshVerts, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int numIndices, int numVerts);

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		internal static class XQQEKWHQACQ
		{
			[Cpp2IlInjected.Token(Token = "0x40002CF")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x87F6DA0", Offset = "0x87F5DA0", VA = "0x1887F6DA0")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x87F6C20", Offset = "0x87F5C20", VA = "0x1887F6C20")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x87F6F30", Offset = "0x87F5F30", VA = "0x1887F6F30")]
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
		public YPZIHIMDJVZ.ScalabilityTessellationModeEnum shapesTessellateMode;

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
		[Cpp2IlInjected.Address(RVA = "0x87E4630", Offset = "0x87E3630", VA = "0x1887E4630")]
		private static float RLSDCIMDXGH([In] BatchedMeshTessellateJob bmtj, [In] float3 vertPos, float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x87E3B00", Offset = "0x87E2B00", VA = "0x1887E3B00")]
		private static int HVRBTUWDSWT(BatchedMeshTessellateJob a, [Out] TessVert b, [In] TessVert vert0, [In] TessVert vert1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x87E5D50", Offset = "0x87E4D50", VA = "0x1887E5D50")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.TessellateTri_00000270$PostfixBurstDelegate))]
		private static void UCCKUOUFFXY(BatchedMeshTessellateJob a, [In] TriToTessellate tri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x87E2EF0", Offset = "0x87E1EF0", VA = "0x1887E2EF0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.TessellateQuad_00000271$PostfixBurstDelegate))]
		private static void CAIGUGCDUKO(BatchedMeshTessellateJob a, [In] QuadToTessellate quad)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x87E3AF0", Offset = "0x87E2AF0", VA = "0x1887E3AF0", Slot = "4")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x87E4E70", Offset = "0x87E3E70", VA = "0x1887E4E70")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal void SYMSROSCDFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x87E5F50", Offset = "0x87E4F50", VA = "0x1887E5F50")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.BuildNativeMesh_00000274$PostfixBurstDelegate))]
		internal unsafe static void VZJHCJCJXSZ(UnsafeList<int>* a, UnsafeList<float3>* b, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* c, UnsafeList<int>* d, UnsafeList<float3>* e, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int f, int g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x87E3C80", Offset = "0x87E2C80", VA = "0x1887E3C80")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public static void QXLFIACTQNP(BatchedMeshTessellateJob a, [In] TriToTessellate tri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x87E30F0", Offset = "0x87E20F0", VA = "0x1887E30F0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public static void CQAVSDHIVLH(BatchedMeshTessellateJob a, [In] QuadToTessellate quad)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x87E46C0", Offset = "0x87E36C0", VA = "0x1887E46C0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public unsafe static void ROIVZMLDKFW(UnsafeList<int>* a, UnsafeList<float3>* b, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* c, UnsafeList<int>* d, UnsafeList<float3>* e, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int f, int g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class BatchedMeshTessellate
	{
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private static readonly ProfilerMarker BQGMLISOSHT;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public const int VIHDXRMMUUS = 2;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private const int KLETSCWGDVS = 1;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private static int HTGHEAAHSXW;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private static Stack<BatchedMeshTessellate> TUTOVYVCDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private NativeMesh MVWBSNIPTTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private NativeList<TessVert> AYPBYATVAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private NativeList<int> RVRRVEDYLZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private NativeList<BatchedMeshTessellateJob.TriToTessellate> SWOALZLYBSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private NativeList<BatchedMeshTessellateJob.TriToTessellate> THMPNRRTGOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private NativeList<BatchedMeshTessellateJob.QuadToTessellate> VQWBIIJUABZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private NativeList<BatchedMeshTessellateJob.QuadToTessellate> XRBBACVSYQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private BatchedMeshTessellateJob JHMXMHDLKGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private JobHandle WSFKUVXDQPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private BatchedMeshTessellateJob.GenerateTessellatedMeshResults ELXWKHTQVBG;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private const int FRARBEYIIGC = 65530;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x87E7160", Offset = "0x87E6160", VA = "0x1887E7160")]
		private BatchedMeshTessellate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x87E6790", Offset = "0x87E5790", VA = "0x1887E6790")]
		public void WAEMFYJKESA(NativeMesh a, float3 b, float c, float d, float e, List<ShapeBatch.CollapseEntry> f, Allocator g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x87E6B40", Offset = "0x87E5B40", VA = "0x1887E6B40")]
		public (bool, NativeMesh, float) XAMTXMNHZIF(List<ShapeBatch.CollapseEntry> a, Allocator b, bool c)
		{
			return default((bool, NativeMesh, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x87E61B0", Offset = "0x87E51B0", VA = "0x1887E61B0")]
		public static bool MLFCAYMWXJI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x87E7030", Offset = "0x87E6030", VA = "0x1887E7030")]
		public static int XIOYOZYZICJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x87E6510", Offset = "0x87E5510", VA = "0x1887E6510")]
		public static int SWJLGAPBNKL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x87E6240", Offset = "0x87E5240", VA = "0x1887E6240")]
		public static BatchedMeshTessellate NTVJKBECQWQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x87E6580", Offset = "0x87E5580", VA = "0x1887E6580")]
		internal static void UMKZUVCFIBD(BatchedMeshTessellate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x87E6620", Offset = "0x87E5620", VA = "0x1887E6620")]
		public static void VNMVIQAEUAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x87E6000", Offset = "0x87E5000", VA = "0x1887E6000")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		public static void BCRRCNMCFTL()
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
		[Cpp2IlInjected.Address(RVA = "0x87F68C0", Offset = "0x87F58C0", VA = "0x1887F68C0")]
		public static void Create([Out] TessVert result, int srcIndex, [In] float3 posIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x87F65D0", Offset = "0x87F55D0", VA = "0x1887F65D0")]
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
			public YPZIHIMDJVZ.ScalabilityCollapseMetricEnum shapesCollapseMetric;

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
			[Cpp2IlInjected.Address(RVA = "0x88037A0", Offset = "0x88027A0", VA = "0x1888037A0")]
			public void KIRZLIOHNJC(int a, int b, Allocator c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x8803980", Offset = "0x8802980", VA = "0x188803980")]
			public static NativeMeshJob QZMZUJCMGBE(NativeMesh a)
			{
				return default(NativeMeshJob);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x3F9E730", Offset = "0x3F9D730", VA = "0x183F9E730")]
			private static void RFGWBTEKWFO<T>(NativeArray<T> a, NativeArray<T> b) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x88036E0", Offset = "0x88026E0", VA = "0x1888036E0")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void Setup_FastCopyCollapse_0000028F$PostfixBurstDelegate(int numCollapses, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		internal static class CUTCSOGQKNF
		{
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8801040", Offset = "0x8800040", VA = "0x188801040")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x8800ED0", Offset = "0x87FFED0", VA = "0x188800ED0")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x88011C0", Offset = "0x88001C0", VA = "0x1888011C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8806DE0", Offset = "0x8805DE0", VA = "0x188806DE0")]
		public ScaleMeshToDesiredTriCountsJob([In] List<ShapeBatch.ScaledMesh> meshListIn, NativeList<ShapeBatch.CollapseEntry> collapseListOut, [In] NativeMesh meshSrcIn, [In] NativeList<ShapeBatch.CollapseEntry> collapseListIn, [In] NativeArray<long> scaleMeshJobAbortRequest, float3 bboxMin, float3 bboxMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x88053C0", Offset = "0x88043C0", VA = "0x1888053C0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.Setup_FastCopyCollapse_0000028F$PostfixBurstDelegate))]
		private unsafe static void MDXFXOJTPUT(int a, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x88053D0", Offset = "0x88043D0", VA = "0x1888053D0")]
		public static long UYAHRCKXHIF(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8804E70", Offset = "0x8803E70", VA = "0x188804E70", Slot = "4")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8803E40", Offset = "0x8802E40", VA = "0x188803E40")]
		public void AOJLOXJJZWQ(List<ShapeBatch.ScaledMesh> a, [In] ShapeBatch shapeBatchIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8804890", Offset = "0x8803890", VA = "0x188804890")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private bool AbortRequested()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x88053F0", Offset = "0x88043F0", VA = "0x1888053F0")]
		private CompressedNativeMeshStruct VTFENADWPHL(int a, Allocator b)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8805620", Offset = "0x8804620", VA = "0x188805620")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private void YIHOLJCXJMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x88048B0", Offset = "0x88038B0", VA = "0x1888048B0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private float EFOEQRQEFVF(int a, int b, bool c, bool d, float e, float f, float g, float h, float i, float j, float k)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x88050A0", Offset = "0x88040A0", VA = "0x1888050A0")]
		[IgnoreWarning(1371)]
		private ScaledMeshJob JAEDBODHZFB([In] ScaledMeshJob scaledMeshJobSrc, int a, [In] NativeArray<int> indices, [In] NativeArray<bool> vertexUsed, NativeArray<int> b)
		{
			return default(ScaledMeshJob);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x8804EC0", Offset = "0x8803EC0", VA = "0x188804EC0")]
		public static int HZJEUJACYDV(NativeArray<int> a, NativeArray<int> b, int c, int d, int e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x87F7330", Offset = "0x87F6330", VA = "0x1887F7330")]
		[BurstCompile]
		public unsafe static void CAKDEYRLUBU(int a, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int b)
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
			public BQZFHYWXUWH shape;

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x8800EA0", Offset = "0x87FFEA0", VA = "0x188800EA0")]
			public BoundsShape(RRBounds inBounds, BQZFHYWXUWH inEntry)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		private class RZBXLLVTXMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public RRBounds UXZIMJVBKGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			public int SRSILWCWOZQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public float JPMDXOFMIAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public List<BoundsShape> DEAHIFZQFBV;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x8803DA0", Offset = "0x8802DA0", VA = "0x188803DA0")]
			public RZBXLLVTXMH(RRBounds a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private static readonly ProfilerMarker ELCEPTFARBP;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private static readonly ProfilerMarker ZJIYAALZDIC;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private static readonly ProfilerMarker AMCTHSVDUXS;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static readonly ProfilerMarker DUSVLSLGGCV;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private static readonly ProfilerMarker QHTHYSLUWMH;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static readonly ProfilerMarker ZUBVJINKKXQ;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private static readonly ProfilerMarker DHQWLNGJFQL;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		internal const int BMKCOHZSQOE = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		internal static Dictionary<Material, List<Material>> YMNYEQUKPXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private Dictionary<Material, List<BatchedMesh>> HEWVLXHANMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		internal List<BatchedMesh> QIYEVRPXYPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private List<MeshRenderer> LQRQDRRWGEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private Transform BGKZGOSZLJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private bool BXHJKKTBOKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private bool CZOQJGOOCUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private int HMFINTYNJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private BatchedMesh AWXTBQMZUVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Material DCSJVMCSTPB;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private static bool? PIBZFJCSQFP;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private const int IYBDGVEIGEI = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private static List<BoundsShape> OTYENLELRXT;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<MeshRenderer> ATRKAXMEEOY
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int JBJZPFYSHST
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x87FD5F0", Offset = "0x87FC5F0", VA = "0x1887FD5F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private static bool CIDCGBGOJKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x87F95F0", Offset = "0x87F85F0", VA = "0x1887F95F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void LPVWHVNVMOD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void LPVWHVNVMOD(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void PXMSUFRQQOE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x87F7590", Offset = "0x87F6590", VA = "0x1887F7590")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x87FCBD0", Offset = "0x87FBBD0", VA = "0x1887FCBD0")]
		internal bool YUSXDHHLYON()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x87FCB50", Offset = "0x87FBB50", VA = "0x1887FCB50")]
		private Transform XHUPFMIGGSD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x87F9710", Offset = "0x87F8710", VA = "0x1887F9710")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x87F8080", Offset = "0x87F7080", VA = "0x1887F8080", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x87F7370", Offset = "0x87F6370", VA = "0x1887F7370")]
		public BatchedMesh AddToBatchedMesh(BQZFHYWXUWH newMesh, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x87FC690", Offset = "0x87FB690", VA = "0x1887FC690")]
		public void RemoveFromBatchedMesh(BQZFHYWXUWH mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x87F7F50", Offset = "0x87F6F50", VA = "0x1887F7F50")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x87FCAD0", Offset = "0x87FBAD0", VA = "0x1887FCAD0")]
		private void WJNYOBWNHFX(Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x87F8E20", Offset = "0x87F7E20", VA = "0x1887F8E20")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x87F8E10", Offset = "0x87F7E10", VA = "0x1887F8E10")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x87FCC30", Offset = "0x87FBC30", VA = "0x1887FCC30")]
		private void ZHSDAGENYBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x87F90F0", Offset = "0x87F80F0", VA = "0x1887F90F0")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x87FC7D0", Offset = "0x87FB7D0", VA = "0x1887FC7D0")]
		private BatchedMesh SYLUHNYKHTC(BQZFHYWXUWH a, Material b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x87F8B30", Offset = "0x87F7B30", VA = "0x1887F8B30")]
		private BatchedMesh IQPYUGWILDY(Material a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x87F7650", Offset = "0x87F6650", VA = "0x1887F7650")]
		private BatchedMesh CIGVNJICTJV(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x87F75C0", Offset = "0x87F65C0", VA = "0x1887F75C0")]
		internal void BJCAFVAJNCU([Out] float4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x87F8490", Offset = "0x87F7490", VA = "0x1887F8490")]
		public static List<Material> GenerateVertexFormatVariants(Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x87FC9D0", Offset = "0x87FB9D0", VA = "0x1887FC9D0")]
		public static void UpdateMaterialVariants(Material parentMaterial, Action<Material> updateFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xFF3810", Offset = "0xFF2810", VA = "0x180FF3810")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x87F8F90", Offset = "0x87F7F90", VA = "0x1887F8F90")]
		public void MarkDirty(BQZFHYWXUWH mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x87F8E90", Offset = "0x87F7E90", VA = "0x1887F8E90")]
		[Conditional("CHECK_STATE")]
		private void MHDDJJNRDNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x87F9250", Offset = "0x87F8250", VA = "0x1887F9250")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float scalabilityErrorControl)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x87F7E20", Offset = "0x87F6E20", VA = "0x1887F7E20")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x87FB3D0", Offset = "0x87FA3D0", VA = "0x1887FB3D0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x87F8610", Offset = "0x87F7610", VA = "0x1887F8610")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x87F9800", Offset = "0x87F8800", VA = "0x1887F9800")]
		public void RebatchOptimally(int batchSizeNaughty, int batchSizeNice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x87F9720", Offset = "0x87F8720", VA = "0x1887F9720")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x87FD4E0", Offset = "0x87FC4E0", VA = "0x1887FD4E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1DEBD80", Offset = "0x1DEAD80", VA = "0x181DEBD80")]
			public void ATGQBVJSYFX()
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
		private sealed class HVSFMJFCGGX : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			private bool IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			private int FMHFHEECSRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			private long TQHUEXHKDGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public long RLHAJHSYNZO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private bool PPYAARGUXMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public bool DNKOJMORFLX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			private int PERVKQLZFVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			private int QWHNDBIRBHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			private int CGYPOPRIAZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			private int OVXVSJIQTSJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private List<BatchedMeshRenderer>.Enumerator WDOEHGTYMPL;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool TNDQMXWIQZB
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0x1401F40", Offset = "0x1400F40", VA = "0x181401F40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x7ABCE00", Offset = "0x7ABBE00", VA = "0x187ABCE00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x16507C0", Offset = "0x164F7C0", VA = "0x1816507C0")]
			[DebuggerHidden]
			public HVSFMJFCGGX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x88026B0", Offset = "0x88016B0", VA = "0x1888026B0", Slot = "7")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x88014C0", Offset = "0x88004C0", VA = "0x1888014C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8802820", Offset = "0x8801820", VA = "0x188802820")]
			private void ZLAPFDWYPLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x88027D0", Offset = "0x88017D0", VA = "0x1888027D0")]
			private void ZKVIHXDBGAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x88013E0", Offset = "0x88003E0", VA = "0x1888013E0", Slot = "10")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8801420", Offset = "0x8800420", VA = "0x188801420", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> WGFMXANJAAM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8801420", Offset = "0x8800420", VA = "0x188801420", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator JZJZEHYLQOE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private static readonly ProfilerMarker ZUBVJINKKXQ;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly ProfilerMarker GHSESTEMDVI;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly ProfilerMarker VQIANBDXJBC;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly ProfilerMarker WFGRDXUCACM;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static float3 IGFBIEUXELP;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static int BYKVAJVFRSQ;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static int MRDBAUEAQGL;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static int FOSQTGYNJQO;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static int IKEZVRKURNR;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static int FJDVOSGXMWF;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static float EKQNVJJSVHG;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static float EXOWMSICCKK;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static float MSLIIAJQLPM;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static float FARWSXBEZBJ;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static float MUOYMELKBSM;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static float NVTOLSPXBDF;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static float ZIOKAMOMWPD;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static float GAMIXZDFKIA;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private static List<BatchedMeshRenderer> BJYPAPDMCVP;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private static Stack<NativeMesh> HFYUUIIHEIA;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private static Stack<UTJUCHVGRAU> RLEHPTAZHUP;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static QBBFYVTXZOL IVAWGFLSGIO;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private static FindAndMarkAsFrozenCache HGLJEPXFKTY;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static int AQPIXDWPYIH;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void LPVWHVNVMOD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void LNFOQCVVMFI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void LPVWHVNVMOD(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x87FE550", Offset = "0x87FD550", VA = "0x1887FE550")]
		public static void RTFNZEQTDKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x87FDEF0", Offset = "0x87FCEF0", VA = "0x1887FDEF0")]
		public static void DBMKFPVJLRB(BatchedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x87FE420", Offset = "0x87FD420", VA = "0x1887FE420")]
		public static void MKMOZIKHIXC(BatchedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x87FD790", Offset = "0x87FC790", VA = "0x1887FD790")]
		public static void CCSMSVXROJS(BQZFHYWXUWH a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x87FEA40", Offset = "0x87FDA40", VA = "0x1887FEA40")]
		public static void TXHLGDVQUUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8800230", Offset = "0x87FF230", VA = "0x188800230")]
		public static void ZNXHBPNTHLC(float a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x87FFC20", Offset = "0x87FEC20", VA = "0x1887FFC20")]
		private static void XOJRAFQPNTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x87FF160", Offset = "0x87FE160", VA = "0x1887FF160")]
		public static long WRWVTHDNNKF(int a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x87FE830", Offset = "0x87FD830", VA = "0x1887FE830")]
		public static (long, long, int) TGDZRRJYMIZ(float a)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x87FF0E0", Offset = "0x87FE0E0", VA = "0x1887FF0E0")]
		[IteratorStateMachine(typeof(HVSFMJFCGGX))]
		public static IEnumerable<bool> VOBINCHBGMK(long a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x87FE5D0", Offset = "0x87FD5D0", VA = "0x1887FE5D0")]
		public static void RVHICXFKOKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x87FE030", Offset = "0x87FD030", VA = "0x1887FE030")]
		public static void GJOPRMPZPHE(long a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x87FE2A0", Offset = "0x87FD2A0", VA = "0x1887FE2A0")]
		public static int JHLTSPEAFSM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x88000C0", Offset = "0x87FF0C0", VA = "0x1888000C0")]
		internal static NativeMesh YVEETCZZWHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x87FEDD0", Offset = "0x87FDDD0", VA = "0x1887FEDD0")]
		internal static void UMKZUVCFIBD(NativeMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x87FD640", Offset = "0x87FC640", VA = "0x1887FD640")]
		internal static UTJUCHVGRAU ARQIAJONWVH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x87FEE70", Offset = "0x87FDE70", VA = "0x1887FEE70")]
		internal static void UMKZUVCFIBD(UTJUCHVGRAU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x87FEF00", Offset = "0x87FDF00", VA = "0x1887FEF00")]
		public static void VNMVIQAEUAE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class WTRJGMOCPBG<a> : BatchedMesh
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private readonly Dictionary<a, BQZFHYWXUWH> AQYRPMAJJAS;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A61B60", Offset = "0x6A60B60", VA = "0x186A61B60")]
		public WTRJGMOCPBG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A617E0", Offset = "0x6A607E0", VA = "0x186A617E0")]
		public void EOZBXFZLRIR(a a, BQZFHYWXUWH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A618B0", Offset = "0x6A608B0", VA = "0x186A618B0")]
		public bool WGSXSALXCEA(a a, BQZFHYWXUWH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x6A61460", Offset = "0x6A60460", VA = "0x186A61460")]
		public void EAVKWBYCWIX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x6A61830", Offset = "0x6A60830", VA = "0x186A61830", Slot = "4")]
		public override void PUOXTCRLBYG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public static class JNNYQOUUZUZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly ProfilerCategory DONDUBZQYJW;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		internal static readonly ProfilerMarker UJIGQEMTXRF;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		internal static readonly RuntimeMarker ZNXHBPNTHLC;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static readonly RuntimeCounterValue<float> MJEZBOAFGMH;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static readonly RuntimeCounterValue<float> JSXPRVUEGJS;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly RuntimeCounterValue<float> MEZBQWTZBPB;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private static readonly RuntimeCounterValue<double> TBMVISPNFLV;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private static readonly RuntimeCounterValue<double> YCZWRAWGGZN;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private static readonly RuntimeCounterValue<double> HGHRPQKREEC;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private static readonly RuntimeCounterValue<double> CNDGDEDIZDM;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private static readonly RuntimeCounterValue<int> CDQVDWZNRBU;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private static readonly RuntimeCounterValue<int> CXFVCPMWJKG;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private static readonly RuntimeCounterValue<int> VSWJWMZFRWY;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private static readonly RuntimeCounterValue<int> RQUCZHHSOPL;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private static readonly RuntimeCounterValue<int> XUBYLEWDBPG;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private static readonly RuntimeCounterValue<int> GOZCDZDTLTG;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private static readonly RuntimeCounterValue<int> BESNETAVICF;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private static readonly RuntimeCounterValue<int> YFBXAJHCAIU;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private static readonly RuntimeCounterValue<long> ESIOFEZIQEK;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static readonly RuntimeCounterValue<long> VMTUWFOXXMV;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private static readonly RuntimeCounterValue<long> FZMHXBWLBAM;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private static readonly RuntimeCounterValue<long> QWBKQURRLXY;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private static readonly RuntimeCounterValue<long> AZCUWCTIJHA;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private static readonly RuntimeCounterValue<long> VORNPUUYUAD;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8802870", Offset = "0x8801870", VA = "0x188802870")]
		public static void FWIGYNHOLLJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3152872234
{
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8807910", Offset = "0x8806910", VA = "0x188807910")]
	public static void YCMHZVKAXHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8807900", Offset = "0x8806900", VA = "0x188807900")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x88077A0", Offset = "0x88067A0", VA = "0x1888077A0")]
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
