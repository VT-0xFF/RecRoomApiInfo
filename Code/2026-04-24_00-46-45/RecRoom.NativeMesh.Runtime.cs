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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A684E0", Offset = "0x9A66EE0", VA = "0x189A684E0", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal static class IAFQKVILCOT
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly Log PHYFQCHNHDF;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly Log CKCHFLRWIKO;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly Log ONMXXMIQFAA;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly Log NJTSPVDMUZV;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly Log ISLRILDOECU;
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
		public CompressedNativeMeshStruct TVGLYEFVUSL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int SEQAWKKQLNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
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
		internal static class DWIEXRNQFEO
		{
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9A62260", Offset = "0x9A60C60", VA = "0x189A62260")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9A623F0", Offset = "0x9A60DF0", VA = "0x189A623F0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9A62010", Offset = "0x9A60A10", VA = "0x189A62010")]
			public unsafe static void Invoke([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int vertexCount, [In] float3 vertMin, [In] float3 vertScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllVerts_0000003D$PostfixBurstDelegate([NoAlias] ushort* dstVerts, [Out] float3 vertMinimum, [Out] float3 vertScale, [In][NoAlias] float3* srcVerts, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal static class FLDIVQXMJYM
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9A63530", Offset = "0x9A61F30", VA = "0x189A63530")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9A636C0", Offset = "0x9A620C0", VA = "0x189A636C0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9A632C0", Offset = "0x9A61CC0", VA = "0x189A632C0")]
			public unsafe static void Invoke([NoAlias] ushort* dstVerts, [Out] float3 vertMinimum, [Out] float3 vertScale, [In][NoAlias] float3* srcVerts, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllNormals_0000003F$PostfixBurstDelegate([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class YIFNQQYPUCK
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9A78D50", Offset = "0x9A77750", VA = "0x189A78D50")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9A78EE0", Offset = "0x9A778E0", VA = "0x189A78EE0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9A78AE0", Offset = "0x9A774E0", VA = "0x189A78AE0")]
			public unsafe static void Invoke([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void GetAllNormals_00000041$PostfixBurstDelegate([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		internal static class NFSWPEGMVVW
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9A68FF0", Offset = "0x9A679F0", VA = "0x189A68FF0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9A69180", Offset = "0x9A67B80", VA = "0x189A69180")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9A68D70", Offset = "0x9A67770", VA = "0x189A68D70")]
			public unsafe static void Invoke([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllUVs_00000048$PostfixBurstDelegate([NoAlias] uint* dstUVs, [Out] float2 uvMinimum, [Out] float2 uvScale, [In][NoAlias] float2* srcUVs, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		internal static class WIFSYHKRFFF
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9A787D0", Offset = "0x9A771D0", VA = "0x189A787D0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9A78960", Offset = "0x9A77360", VA = "0x189A78960")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9A78560", Offset = "0x9A76F60", VA = "0x189A78560")]
			public unsafe static void Invoke([NoAlias] uint* dstUVs, [Out] float2 uvMinimum, [Out] float2 uvScale, [In][NoAlias] float2* srcUVs, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void GetUV_00000049$PostfixBurstDelegate([Out] float2 ret, uint compressed, [In] float2 uvMin, [In] float2 uvScale);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class PAETYCOKOAO
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9A718A0", Offset = "0x9A702A0", VA = "0x189A718A0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9A71A30", Offset = "0x9A70430", VA = "0x189A71A30")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9A71640", Offset = "0x9A70040", VA = "0x189A71640")]
			public static void Invoke([Out] float2 ret, uint compressed, [In] float2 uvMin, [In] float2 uvScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void GetAllUVs_0000004B$PostfixBurstDelegate([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int vertexCount, [In] float2 uvMin, [In] float2 uvScale);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		internal static class RFEZMJDXSBD
		{
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9A762F0", Offset = "0x9A74CF0", VA = "0x189A762F0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9A76480", Offset = "0x9A74E80", VA = "0x189A76480")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9A76030", Offset = "0x9A74A30", VA = "0x189A76030")]
			public unsafe static void Invoke([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int vertexCount, [In] float2 uvMin, [In] float2 uvScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllTangents_00000052$PostfixBurstDelegate([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal static class UCSEIGELDFK
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9A77250", Offset = "0x9A75C50", VA = "0x189A77250")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9A773E0", Offset = "0x9A75DE0", VA = "0x189A773E0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9A76FE0", Offset = "0x9A759E0", VA = "0x189A76FE0")]
			public unsafe static void Invoke([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate ushort SetTangent_00000053$PostfixBurstDelegate([In] float4 newVal);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		internal static class FLBNBNTADXN
		{
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9A62FB0", Offset = "0x9A619B0", VA = "0x189A62FB0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9A63140", Offset = "0x9A61B40", VA = "0x189A63140")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9A62D30", Offset = "0x9A61730", VA = "0x189A62D30")]
			public static ushort Invoke([In] float4 newVal)
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void GetAllTangents_00000055$PostfixBurstDelegate([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class NMWWKYXNYYR
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9A69580", Offset = "0x9A67F80", VA = "0x189A69580")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9A69710", Offset = "0x9A68110", VA = "0x189A69710")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9A69300", Offset = "0x9A67D00", VA = "0x189A69300")]
			public unsafe static void Invoke([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void GetTangent_0000005B$PostfixBurstDelegate([Out] float4 result, ushort compressed);

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		internal static class RYXASUASZVS
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9A768B0", Offset = "0x9A752B0", VA = "0x189A768B0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9A76A40", Offset = "0x9A75440", VA = "0x189A76A40")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9A76600", Offset = "0x9A75000", VA = "0x189A76600")]
			public static void Invoke([Out] float4 result, ushort compressed)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void CreateAllMaterialIndices_0000005D$PostfixBurstDelegate([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int numData, [Out] int numRLEs, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		internal static class ZRAXYMEFECE
		{
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9A79920", Offset = "0x9A78320", VA = "0x189A79920")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9A79AB0", Offset = "0x9A784B0", VA = "0x189A79AB0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9A79680", Offset = "0x9A78080", VA = "0x189A79680")]
			public unsafe static void Invoke([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int numData, [Out] int numRLEs, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void DecodeMaterialIndices_0000005F$PostfixBurstDelegate([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		internal static class ZLTIZYUGRRR
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9A79370", Offset = "0x9A77D70", VA = "0x189A79370")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9A79500", Offset = "0x9A77F00", VA = "0x189A79500")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9A79060", Offset = "0x9A77A60", VA = "0x189A79060")]
			public unsafe static void Invoke([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate int EncodeIndices_00000067$PostfixBurstDelegate([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int srcIndexCount);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		internal static class VPVTQCLJYWK
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9A77820", Offset = "0x9A76220", VA = "0x189A77820")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9A779B0", Offset = "0x9A763B0", VA = "0x189A779B0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9A77560", Offset = "0x9A75F60", VA = "0x189A77560")]
			public unsafe static int Invoke([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int srcIndexCount)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void DecodeIndices_00000069$PostfixBurstDelegate([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int indexCount);

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		internal static class AZICSTQTXME
		{
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9A58890", Offset = "0x9A57290", VA = "0x189A58890")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x9A58A20", Offset = "0x9A57420", VA = "0x189A58A20")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9A58610", Offset = "0x9A57010", VA = "0x189A58610")]
			public unsafe static void Invoke([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int indexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void DecodeNormal_0000006B$PostfixBurstDelegate([Out] float3 ret, ushort compressed);

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		internal static class HNZKYAJVOQP
		{
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9A64450", Offset = "0x9A62E50", VA = "0x189A64450")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9A645E0", Offset = "0x9A62FE0", VA = "0x189A645E0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9A64230", Offset = "0x9A62C30", VA = "0x189A64230")]
			public static void Invoke([Out] float3 ret, ushort compressed)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate ushort EncodeNormal_0000006C$PostfixBurstDelegate([In] float3 newVal);

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		internal static class BMGVBUAQYDC
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9A58DB0", Offset = "0x9A577B0", VA = "0x189A58DB0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9A58F40", Offset = "0x9A57940", VA = "0x189A58F40")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9A58BA0", Offset = "0x9A575A0", VA = "0x189A58BA0")]
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
		public bool RQLJIMEKAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9A5A140", Offset = "0x9A58B40", VA = "0x189A5A140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool NBXDKLZNESA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9A5B760", Offset = "0x9A5A160", VA = "0x189A5B760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A3E0", Offset = "0x9A58DE0", VA = "0x189A5A3E0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A59E60", Offset = "0x9A58860", VA = "0x189A59E60")]
		public static CompressedNativeMeshStruct Create(Allocator allocator, NativeMesh srcMesh)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9A59890", Offset = "0x9A58290", VA = "0x189A59890")]
		public static CompressedNativeMeshStruct Create(Allocator allocator, NativeArray<float3> srcVerts, NativeArray<float3> srcNormals, NativeArray<float2> srcUVs, NativeArray<float4> srcMaterialIndices, bool hasTangents, NativeArray<float4> srcTangents, NativeArray<int> srcIndices, int vertexCount, int firstVertex, int indexCount, int firstIndex)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9A5B7A0", Offset = "0x9A5A1A0", VA = "0x189A5B7A0")]
		public void XBDFMWFXVQE(NativeMesh a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9A5AFB0", Offset = "0x9A599B0", VA = "0x189A5AFB0")]
		public long NQPPCRJNOYC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A8F0", Offset = "0x9A592F0", VA = "0x189A5A8F0")]
		public long JOHSUPZLSTJ(NativeMesh.UnityMeshFormat a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A5ADD0", Offset = "0x9A597D0", VA = "0x189A5ADD0")]
		private void NBBRSPDMQGL(int a, int b, Allocator c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A980", Offset = "0x9A59380", VA = "0x189A5A980")]
		private void KJYGOGWYXSP(NativeArray<float3> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A970", Offset = "0x9A59370", VA = "0x189A5A970")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllVerts_00000036$PostfixBurstDelegate))]
		private unsafe static void KJYGOGWYXSP([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int a, [In] float3 vertMin, [In] float3 vertScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9A59310", Offset = "0x9A57D10", VA = "0x189A59310")]
		private void CSBLKAGJFZN(NativeArray<float3> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9A59300", Offset = "0x9A57D00", VA = "0x189A59300")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllVerts_0000003D$PostfixBurstDelegate))]
		private unsafe static void CSBLKAGJFZN([NoAlias] ushort* dstVerts, [Out] float3 a, [Out] float3 b, [In][NoAlias] float3* srcVerts, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9A5AA90", Offset = "0x9A59490", VA = "0x189A5AA90")]
		private void LQDVBWPSCCH(NativeArray<float3> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A5AA80", Offset = "0x9A59480", VA = "0x189A5AA80")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllNormals_0000003F$PostfixBurstDelegate))]
		private unsafe static void LQDVBWPSCCH([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A5B690", Offset = "0x9A5A090", VA = "0x189A5B690")]
		private void VJOBPNBANVB(NativeArray<float3> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9A5B750", Offset = "0x9A5A150", VA = "0x189A5B750")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllNormals_00000041$PostfixBurstDelegate))]
		private unsafe static void VJOBPNBANVB([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9A59210", Offset = "0x9A57C10", VA = "0x189A59210")]
		private void CJSOIVGKULF(NativeArray<float2> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9A59200", Offset = "0x9A57C00", VA = "0x189A59200")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllUVs_00000048$PostfixBurstDelegate))]
		private unsafe static void CJSOIVGKULF([NoAlias] uint* dstUVs, [Out] float2 a, [Out] float2 b, [In][NoAlias] float2* srcUVs, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A590C0", Offset = "0x9A57AC0", VA = "0x189A590C0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetUV_00000049$PostfixBurstDelegate))]
		private static void AFUWMZURFKR([Out] float2 a, uint b, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A6C0", Offset = "0x9A590C0", VA = "0x189A5A6C0")]
		private void IZXBQBEYBGX(NativeArray<float2> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A6B0", Offset = "0x9A590B0", VA = "0x189A5A6B0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllUVs_0000004B$PostfixBurstDelegate))]
		private unsafe static void IZXBQBEYBGX([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int a, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A180", Offset = "0x9A58B80", VA = "0x189A5A180")]
		private void DEMKSPAZUDN(NativeArray<float4> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A260", Offset = "0x9A58C60", VA = "0x189A5A260")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllTangents_00000052$PostfixBurstDelegate))]
		private unsafe static void DEMKSPAZUDN([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9A5B150", Offset = "0x9A59B50", VA = "0x189A5B150")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetTangent_00000053$PostfixBurstDelegate))]
		private static ushort PXXRXGPFJJZ([In] float4 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9A5B160", Offset = "0x9A59B60", VA = "0x189A5B160")]
		private void QCUICCEZMOL(NativeArray<float4> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A5B220", Offset = "0x9A59C20", VA = "0x189A5B220")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllTangents_00000055$PostfixBurstDelegate))]
		private unsafe static void QCUICCEZMOL([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A960", Offset = "0x9A59360", VA = "0x189A5A960")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetTangent_0000005B$PostfixBurstDelegate))]
		private static void KAKREWKOVIX([Out] float4 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A59400", Offset = "0x9A57E00", VA = "0x189A59400")]
		private void CXWDFNOJMDT(Allocator a, NativeArray<float4> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9A59880", Offset = "0x9A58280", VA = "0x189A59880")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.CreateAllMaterialIndices_0000005D$PostfixBurstDelegate))]
		private unsafe static void CXWDFNOJMDT([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int a, [Out] int b, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A5ACB0", Offset = "0x9A596B0", VA = "0x189A5ACB0")]
		private static void MFROIIMJOAO(NativeArray<float4> a, NativeArray<MaterialIndex> b, NativeArray<byte> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9A5ADB0", Offset = "0x9A597B0", VA = "0x189A5ADB0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeMaterialIndices_0000005F$PostfixBurstDelegate))]
		private unsafe static void MFROIIMJOAO([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A5B0", Offset = "0x9A58FB0", VA = "0x189A5A5B0")]
		private void EWPWSKMPNJY(Allocator a, NativeArray<int> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9A5B240", Offset = "0x9A59C40", VA = "0x189A5B240")]
		private static NativeArray<byte> QVXUJXFTWLL(Allocator a, NativeArray<int> b, int c)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9A5B230", Offset = "0x9A59C30", VA = "0x189A5B230")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.EncodeIndices_00000067$PostfixBurstDelegate))]
		private unsafe static int QVXUJXFTWLL([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A310", Offset = "0x9A58D10", VA = "0x189A5A310")]
		private static void DKLSSLRZMBT(NativeArray<int> a, NativeArray<byte> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A3D0", Offset = "0x9A58DD0", VA = "0x189A5A3D0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeIndices_00000069$PostfixBurstDelegate))]
		private unsafe static void DKLSSLRZMBT([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9A5AA70", Offset = "0x9A59470", VA = "0x189A5AA70")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeNormal_0000006B$PostfixBurstDelegate))]
		private static void LHZFQDYLCAL([Out] float3 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9A5ADC0", Offset = "0x9A597C0", VA = "0x189A5ADC0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.EncodeNormal_0000006C$PostfixBurstDelegate))]
		private static ushort MWXKWEDREYX([In] float3 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9A57450", Offset = "0x9A55E50", VA = "0x189A57450")]
		[BurstCompile]
		internal unsafe static void XSXLAXMIPKG([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int a, [In] float3 vertMin, [In] float3 vertScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9A57020", Offset = "0x9A55A20", VA = "0x189A57020")]
		[BurstCompile]
		internal unsafe static void RKBNKZGODQG([NoAlias] ushort* dstVerts, [Out] float3 a, [Out] float3 b, [In][NoAlias] float3* srcVerts, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A270", Offset = "0x9A58C70", VA = "0x189A5A270")]
		[BurstCompile]
		internal unsafe static void DJKSVGVLGLU([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A500", Offset = "0x9A58F00", VA = "0x189A5A500")]
		[BurstCompile]
		internal unsafe static void EWJGJFNQRPE([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9A56D40", Offset = "0x9A55740", VA = "0x189A56D40")]
		[BurstCompile]
		internal unsafe static void PZXHKXKRZBM([NoAlias] uint* dstUVs, [Out] float2 a, [Out] float2 b, [In][NoAlias] float2* srcUVs, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A8B0", Offset = "0x9A592B0", VA = "0x189A5A8B0")]
		[BurstCompile]
		internal static void JGOHIRANZWA([Out] float2 a, uint b, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9A5B4F0", Offset = "0x9A59EF0", VA = "0x189A5B4F0")]
		[BurstCompile]
		internal unsafe static void TAVKIWHEEXY([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int a, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9A59160", Offset = "0x9A57B60", VA = "0x189A59160")]
		[BurstCompile]
		internal unsafe static void BWECCVLBFYG([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9A590D0", Offset = "0x9A57AD0", VA = "0x189A590D0")]
		[BurstCompile]
		internal static ushort BANRHFTVGDI([In] float4 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A5AF00", Offset = "0x9A59900", VA = "0x189A5AF00")]
		[BurstCompile]
		internal unsafe static void NLSMOSZBVMS([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9A5B5D0", Offset = "0x9A59FD0", VA = "0x189A5B5D0")]
		[BurstCompile]
		internal static void TCDBWLCRPGK([Out] float4 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9A56510", Offset = "0x9A54F10", VA = "0x189A56510")]
		[BurstCompile]
		internal unsafe static void FTEOFTAXQFG([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int a, [Out] int b, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9A5AB70", Offset = "0x9A59570", VA = "0x189A5AB70")]
		[BurstCompile]
		internal unsafe static void LZXWDVWFBHD([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9A5A7B0", Offset = "0x9A591B0", VA = "0x189A5A7B0")]
		[BurstCompile]
		internal unsafe static int JFSIYZIQSQI([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9A5B0B0", Offset = "0x9A59AB0", VA = "0x189A5B0B0")]
		[BurstCompile]
		internal unsafe static void PCFBECCCHEQ([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9A56C00", Offset = "0x9A55600", VA = "0x189A56C00")]
		[BurstCompile]
		internal static void HKBAQQIGPXI([Out] float3 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9A56A40", Offset = "0x9A55440", VA = "0x189A56A40")]
		[BurstCompile]
		internal static ushort HJUUMTXZTQS([In] float3 newVal)
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
		internal static class KLRUMIMCKEX
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x9A681D0", Offset = "0x9A66BD0", VA = "0x189A681D0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x9A68360", Offset = "0x9A66D60", VA = "0x189A68360")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x9A67CE0", Offset = "0x9A666E0", VA = "0x189A67CE0")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate int FloatToSnorm8_00000083$PostfixBurstDelegate(float x);

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		internal static class PIRSDDUZXNF
		{
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x9A71E40", Offset = "0x9A70840", VA = "0x189A71E40")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9A71FC0", Offset = "0x9A709C0", VA = "0x189A71FC0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9A71BB0", Offset = "0x9A705B0", VA = "0x189A71BB0")]
			public static int Invoke(float x)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate uint FloatToSnorm8_00000084$PostfixBurstDelegate([In] float4 v);

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		internal static class KBXBBYQGYYS
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9A673F0", Offset = "0x9A65DF0", VA = "0x189A673F0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9A67580", Offset = "0x9A65F80", VA = "0x189A67580")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9A67160", Offset = "0x9A65B60", VA = "0x189A67160")]
			public static uint Invoke([In] float4 v)
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate uint FloatToSnorm8_00000085$PostfixBurstDelegate([In] float3 v);

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		internal static class EKDLDMMQFEB
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9A62960", Offset = "0x9A61360", VA = "0x189A62960")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9A62AF0", Offset = "0x9A614F0", VA = "0x189A62AF0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9A626F0", Offset = "0x9A610F0", VA = "0x189A626F0")]
			public static uint Invoke([In] float3 v)
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_NormTanSn8MatF16_00000087$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		internal static class HLILZMBDMIN
		{
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9A63F20", Offset = "0x9A62920", VA = "0x189A63F20")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x9A640B0", Offset = "0x9A62AB0", VA = "0x189A640B0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x9A63B20", Offset = "0x9A62520", VA = "0x189A63B20")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_NormTanSn8UvMatF16_00000089$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		internal static class AMZKVIBJEDM
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x9A58300", Offset = "0x9A56D00", VA = "0x189A58300")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9A58490", Offset = "0x9A56E90", VA = "0x189A58490")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9A57F20", Offset = "0x9A56920", VA = "0x189A57F20")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_NormTanOct8MatUi_0000008C$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		internal static class OBLCCYWODYT
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x9A70E00", Offset = "0x9A6F800", VA = "0x189A70E00")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x9A70F90", Offset = "0x9A6F990", VA = "0x189A70F90")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9A709F0", Offset = "0x9A6F3F0", VA = "0x189A709F0")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_PosFixedPoint16NormTanOct8MatUi_0000008E$PostfixBurstDelegate([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 positionMin, [Out] float3 positionMax);

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		internal static class KJOZHGKQWIE
		{
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x9A679D0", Offset = "0x9A663D0", VA = "0x189A679D0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x9A67B60", Offset = "0x9A66560", VA = "0x189A67B60")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x9A67700", Offset = "0x9A66100", VA = "0x189A67700")]
			public unsafe static void Invoke([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 positionMin, [Out] float3 positionMax)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_FastCopyIndices_00000090$PostfixBurstDelegate(int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class JGCRIWKQZFQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x9A64B30", Offset = "0x9A63530", VA = "0x189A64B30")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x9A64CB0", Offset = "0x9A636B0", VA = "0x189A64CB0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9A64910", Offset = "0x9A63310", VA = "0x189A64910")]
			public unsafe static void Invoke(int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_FastCopyIndices_00000091$PostfixBurstDelegate(int startIndex, int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class NVTYCHYNUCV
		{
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x9A69AC0", Offset = "0x9A684C0", VA = "0x189A69AC0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x9A69C40", Offset = "0x9A68640", VA = "0x189A69C40")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x9A69890", Offset = "0x9A68290", VA = "0x189A69890")]
			public unsafe static void Invoke(int startIndex, int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void FastAppendIndices_00000093$PostfixBurstDelegate(int destStart, int sourceCount, int indexOffset, [In][NoAlias] int* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		internal static class OPGJJHDMSFP
		{
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9A71350", Offset = "0x9A6FD50", VA = "0x189A71350")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9A714D0", Offset = "0x9A6FED0", VA = "0x189A714D0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x9A71110", Offset = "0x9A6FB10", VA = "0x189A71110")]
			public unsafe static void Invoke(int destStart, int sourceCount, int indexOffset, [In][NoAlias] int* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void FindBestUnityMeshFormat_Fast_0000009D$PostfixBurstDelegate(int vertexCount, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		internal static class MAUXQQEIHIA
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x9A68A80", Offset = "0x9A67480", VA = "0x189A68A80")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9A68C00", Offset = "0x9A67600", VA = "0x189A68C00")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x9A68810", Offset = "0x9A67210", VA = "0x189A68810")]
			public unsafe static void Invoke(int vertexCount, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const int KOIQPNJLAHJ = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public NativeList<float3> NPXWPSISKMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NativeArray<float3> RQCBSRLUQSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NativeArray<float4> MRVUGQJMTTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NativeArray<float4> TSZGJGAMITC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public NativeArray<float2> QNNNXDNUCES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public NativeList<int> NMZIGINVPSL;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly VertexAttributeDescriptor[][] SDVYLFUWNET;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static bool TRUIYKIQAZU;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static UnityMeshFormatInfo[] CFIREMHUKAN;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static VertexAttributeDescriptor[] MYIPLZFYZGI;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool RQLJIMEKAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9A69DC0", Offset = "0x9A687C0", VA = "0x189A69DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int MMMFHYRJPPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9A6F690", Offset = "0x9A6E090", VA = "0x189A6F690")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int FOHTCWKJUNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9A6D9C0", Offset = "0x9A6C3C0", VA = "0x189A6D9C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NBXDKLZNESA
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x9A6F870", Offset = "0x9A6E270", VA = "0x189A6F870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9A6F8B0", Offset = "0x9A6E2B0", VA = "0x189A6F8B0")]
		public static VertexFormatKeyword WBZYHXWJRIK(UnityMeshFormat a)
		{
			return default(VertexFormatKeyword);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9A6EC50", Offset = "0x9A6D650", VA = "0x189A6EC50")]
		public static void QXOTQWOKDMW(VertexFormatKeyword a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9A6A630", Offset = "0x9A69030", VA = "0x189A6A630", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9A6CE70", Offset = "0x9A6B870", VA = "0x189A6CE70")]
		public void NBBRSPDMQGL(int a, int b, Allocator c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C380", Offset = "0x9A6AD80", VA = "0x189A6C380")]
		public void JZNJFSVAMBO(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B9D0", Offset = "0x9A6A3D0", VA = "0x189A6B9D0", Slot = "6")]
		public bool JJJQPYZOMUW(Mesh a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A6D580", Offset = "0x9A6BF80", VA = "0x189A6D580")]
		public bool OIBMHDSNDAR(Mesh a, bool b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C400", Offset = "0x9A6AE00", VA = "0x189A6C400")]
		public bool LPDTYKECMGR(Mesh a, NativeMesh b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9A6F6E0", Offset = "0x9A6E0E0", VA = "0x189A6F6E0")]
		public bool UWCSDZPWKYC(Mesh a, NativeMesh b, UnityMeshFormat c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9A6E490", Offset = "0x9A6CE90", VA = "0x189A6E490")]
		private void PCDQFGNXAMP(Mesh a, NativeMesh b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9A6E140", Offset = "0x9A6CB40", VA = "0x189A6E140")]
		public void PCDQFGNXAMP(NativeArray<ushort> a, NativeArray<VertexFormat_NormTanOct8MatUi> b, Mesh c, NativeMesh d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B2C0", Offset = "0x9A69CC0", VA = "0x189A6B2C0")]
		public void JAWLJWPMOAP(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9A6D9B0", Offset = "0x9A6C3B0", VA = "0x189A6D9B0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanMatF16_00000082$PostfixBurstDelegate))]
		private unsafe static void OIKOAPJJSRX([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9A6A850", Offset = "0x9A69250", VA = "0x189A6A850")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000083$PostfixBurstDelegate))]
		public static int FCBYRLNZHXK(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9A6A870", Offset = "0x9A69270", VA = "0x189A6A870")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000084$PostfixBurstDelegate))]
		public static uint FCBYRLNZHXK([In] float4 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9A6A860", Offset = "0x9A69260", VA = "0x189A6A860")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000085$PostfixBurstDelegate))]
		public static uint FCBYRLNZHXK([In] float3 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DA10", Offset = "0x9A6C410", VA = "0x189A6DA10")]
		public void ONJWUOIZLVK(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9A6AF30", Offset = "0x9A69930", VA = "0x189A6AF30")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanSn8MatF16_00000087$PostfixBurstDelegate))]
		private unsafe static void GTJVQHXEJJA([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9A6F9E0", Offset = "0x9A6E3E0", VA = "0x189A6F9E0")]
		public void XBNJBYOVVHV(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9A6CE60", Offset = "0x9A6B860", VA = "0x189A6CE60")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanSn8UvMatF16_00000089$PostfixBurstDelegate))]
		private unsafe static void NASTRSKKBJL([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9A6A220", Offset = "0x9A68C20", VA = "0x189A6A220")]
		public void DOEFZGISQZA(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9A69E00", Offset = "0x9A68800", VA = "0x189A69E00")]
		public void DOEFZGISQZA(NativeArray<ushort> a, NativeArray<VertexFormat_NormTanOct8MatUi> b, Mesh c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9A6F320", Offset = "0x9A6DD20", VA = "0x189A6F320")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanOct8MatUi_0000008C$PostfixBurstDelegate))]
		public unsafe static void RPWDNMFGGBG([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9A6BB70", Offset = "0x9A6A570", VA = "0x189A6BB70")]
		public void JSVBCHIOFBH(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9A69DB0", Offset = "0x9A687B0", VA = "0x189A69DB0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_PosFixedPoint16NormTanOct8MatUi_0000008E$PostfixBurstDelegate))]
		private unsafe static void AXOVZEIHCNF([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 b, [Out] float3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9A700F0", Offset = "0x9A6EAF0", VA = "0x189A700F0")]
		public void XQNUWPSKYEF(Mesh a, UnityMeshFormat b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9A6E130", Offset = "0x9A6CB30", VA = "0x189A6E130")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_FastCopyIndices_00000090$PostfixBurstDelegate))]
		private unsafe static void PBMJARBKGEH(int a, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9A6E120", Offset = "0x9A6CB20", VA = "0x189A6E120")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_FastCopyIndices_00000091$PostfixBurstDelegate))]
		private unsafe static void PBMJARBKGEH(int a, int b, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9A6F330", Offset = "0x9A6DD30", VA = "0x189A6F330")]
		public void TTAWVIMBXXQ(NativeMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9A6CC50", Offset = "0x9A6B650", VA = "0x189A6CC50")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FastAppendIndices_00000093$PostfixBurstDelegate))]
		private unsafe static void MJTCZWTBXSZ(int a, int b, int c, [In][NoAlias] int* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9A6A730", Offset = "0x9A69130", VA = "0x189A6A730")]
		public void EJHTUPDLIHB(NativeMesh a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9A6D060", Offset = "0x9A6BA60", VA = "0x189A6D060")]
		public long NQPPCRJNOYC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9A6D190", Offset = "0x9A6BB90", VA = "0x189A6D190")]
		public static long NQPPCRJNOYC(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9A6BAD0", Offset = "0x9A6A4D0", VA = "0x189A6BAD0")]
		public static long JOHSUPZLSTJ(int a, int b, UnityMeshFormat c)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B9F0", Offset = "0x9A6A3F0", VA = "0x189A6B9F0")]
		public long JOHSUPZLSTJ(UnityMeshFormat a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9A6A8D0", Offset = "0x9A692D0", VA = "0x189A6A8D0")]
		public void FUGSQTELDFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9A6ED30", Offset = "0x9A6D730", VA = "0x189A6ED30")]
		public static void RAPANUQKBRF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9A70180", Offset = "0x9A6EB80", VA = "0x189A70180")]
		public UnityMeshFormat YPURPSANROS()
		{
			return default(UnityMeshFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9A6AF20", Offset = "0x9A69920", VA = "0x189A6AF20")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FindBestUnityMeshFormat_Fast_0000009D$PostfixBurstDelegate))]
		private unsafe static void GPOYMCJXVYN(int a, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9A6D1F0", Offset = "0x9A6BBF0", VA = "0x189A6D1F0")]
		public static (int, int) OBYORRFBGQQ(Mesh a)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9A6F900", Offset = "0x9A6E300", VA = "0x189A6F900")]
		public static int WLZFPXNOLPT(Span<VertexAttributeDescriptor> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9A6D350", Offset = "0x9A6BD50", VA = "0x189A6D350")]
		public static long ODARHZPIHLC(Mesh a, int b, int c)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9A6D3C0", Offset = "0x9A6BDC0", VA = "0x189A6D3C0")]
		public static long ODARHZPIHLC(Mesh a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public NativeMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C990", Offset = "0x9A6B390", VA = "0x189A6C990")]
		[BurstCompile]
		internal unsafe static void MBAPXTUFHGI([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9A6AD30", Offset = "0x9A69730", VA = "0x189A6AD30")]
		[BurstCompile]
		internal static int GNNWCIHKAAT(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9A6ADE0", Offset = "0x9A697E0", VA = "0x189A6ADE0")]
		[BurstCompile]
		internal static uint GNNWCIHKAAT([In] float4 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9A6AEA0", Offset = "0x9A698A0", VA = "0x189A6AEA0")]
		[BurstCompile]
		internal static uint GNNWCIHKAAT([In] float3 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9A6A930", Offset = "0x9A69330", VA = "0x189A6A930")]
		[BurstCompile]
		internal unsafe static void FXHZQVIVJWN([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9A6AB40", Offset = "0x9A69540", VA = "0x189A6AB40")]
		[BurstCompile]
		internal unsafe static void GNHXUVSVCQA([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9A6CC60", Offset = "0x9A6B660", VA = "0x189A6CC60")]
		[BurstCompile]
		internal unsafe static void MLQQTXWHZGX([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9A6AF40", Offset = "0x9A69940", VA = "0x189A6AF40")]
		[BurstCompile]
		internal unsafe static void HNWQWOSERNY([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 b, [Out] float3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C960", Offset = "0x9A6B360", VA = "0x189A6C960")]
		[BurstCompile]
		internal unsafe static void LYIOCUFCEZE(int a, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C930", Offset = "0x9A6B330", VA = "0x189A6C930")]
		[BurstCompile]
		internal unsafe static void LYIOCUFCEZE(int a, int b, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9A6A880", Offset = "0x9A69280", VA = "0x189A6A880")]
		[BurstCompile]
		internal unsafe static void FEIUPXTXKQI(int a, int b, int c, [In][NoAlias] int* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9A57A30", Offset = "0x9A56430", VA = "0x189A57A30")]
		[BurstCompile]
		internal unsafe static void WQHAYODNMOM(int a, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
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
	public class JWLFCSSJZIO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static FTZIXOUXSTQ FTZIXOUXSTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NativeList<PrimitiveShapeData> QVDQXJXYORC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NativeList<MeshPartInfo> GULSMLTXKRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public NativeList<CurveShapeRootData> LDDYZRCPYQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NativeArray<CurvePointData> EXRWMXOXYYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NativeList<MeshPartInfo> ORFXHKWWLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NativeList<CurvePointOffset> FFFNPOFLSNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private List<NativeArray<CurvePointData>> UUZHPTGRUSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private NativeList<OcclusionData> IYFBVTVOUGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeArray<int> OXKLJWKHCZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private NativeArray<int> IUJHUCNYMJJ;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private static NativeList<ShapeBatch.CollapseEntry> IITOPSQQECR;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int MMMFHYRJPPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xD38350", Offset = "0xD36D50", VA = "0x180D38350")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x164C0A0", Offset = "0x164AAA0", VA = "0x18164C0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int FOHTCWKJUNP
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xD383B0", Offset = "0xD36DB0", VA = "0x180D383B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x164D690", Offset = "0x164C090", VA = "0x18164D690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9A66F60", Offset = "0x9A65960", VA = "0x189A66F60")]
		public JWLFCSSJZIO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9A651E0", Offset = "0x9A63BE0", VA = "0x189A651E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9A653B0", Offset = "0x9A63DB0", VA = "0x189A653B0")]
		public void Dispose(JobHandle jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9A65590", Offset = "0x9A63F90", VA = "0x189A65590")]
		public void NARGQPDDUQW(PrimitiveShapeData a, OcclusionData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9A65820", Offset = "0x9A64220", VA = "0x189A65820")]
		public void NSDIUBLGEZS(CurveShapeRootData a, NativeArray<CurvePointData> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9A66B50", Offset = "0x9A65550", VA = "0x189A66B50")]
		public JobHandle RALCVBITIDN(NativeMesh a, IDMERDOGXHB b, float3 c, quaternion d, float e, bool f, int g = 0, int h = 0)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9A65950", Offset = "0x9A64350", VA = "0x189A65950")]
		public JobHandle RALCVBITIDN(NativeMesh a, IDMERDOGXHB b, NativeList<ShapeBatch.CollapseEntry> c, float3 d, quaternion e, float f, bool g, bool h, int i = 0, int j = 0)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9A64E20", Offset = "0x9A63820", VA = "0x189A64E20")]
		public static JobHandle BNSHEKODIMI(PrimitiveMeshGeneratorData a, NativeMesh b, NativeArray<int> c, PrimitiveShapeData d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9A66C70", Offset = "0x9A65670", VA = "0x189A66C70")]
		public static JobHandle SAXEQMRTXKS(CurveMeshGeneratorData a, NativeMesh b, CurveShapeRootData c, NativeArray<CurvePointData> d, int e, int f, JobHandle g)
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
			public QNFAKVYEUUU.MinimalMeshData meshData;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x68B8540", Offset = "0x68B6F40", VA = "0x1868B8540")]
			public SingleMeshData(MeshRenderer renderer, QNFAKVYEUUU.MinimalMeshData meshData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x9A76EC0", Offset = "0x9A758C0", VA = "0x189A76EC0")]
			public static implicit operator SingleMeshData((MeshRenderer, QNFAKVYEUUU.MinimalMeshData) tuple)
			{
				return default(SingleMeshData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private static readonly ProfilerMarker OORBTHFUWLP;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly ProfilerMarker NYZSMCXMRGB;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static readonly ProfilerMarker XAMKPRPBONU;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly ProfilerMarker VSYYVNQJLYI;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9A5DA50", Offset = "0x9A5C450", VA = "0x189A5DA50")]
		internal void LBLCXBSQVUY(GameObject a, QNFAKVYEUUU.CrowdAABB b, List<SingleMeshData> c, Material d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9A5EE80", Offset = "0x9A5D880", VA = "0x189A5EE80")]
		internal void YVLIKOXCYAK(GameObject a, QNFAKVYEUUU.CrowdAABB b, List<SingleMeshData> c, List<LODGroup> d, Material e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9A5E2A0", Offset = "0x9A5CCA0", VA = "0x189A5E2A0")]
		private MeshRenderer PVUFVQQFUML(QNFAKVYEUUU.CrowdAABB a, Material b, List<SingleMeshData> c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9A5BC90", Offset = "0x9A5A690", VA = "0x189A5BC90")]
		private List<(List<SingleMeshData>, float)> CHAQHRZLFHZ(QNFAKVYEUUU.CrowdAABB a, List<LODGroup> b, Material c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9A5CC90", Offset = "0x9A5B690", VA = "0x189A5CC90")]
		private List<List<(List<SingleMeshData>, float)>> JRYNDSFHFAW(QNFAKVYEUUU.CrowdAABB a, List<LODGroup> b, Material c, [Out] int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public CrowdBatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9A5CB20", Offset = "0x9A5B520", VA = "0x189A5CB20")]
		[CompilerGenerated]
		internal static (float, int) ECZYJOZCPDJ(List<List<(List<SingleMeshData> meshList, float lodTransition)>> gathered, int[] a)
		{
			return default((float, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class CrowdOptimizer
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly ProfilerMarker GANTFBBYXPI;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly ProfilerMarker WAZXJZQSVLR;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly ProfilerMarker UIQIQDVCMYX;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly ProfilerMarker RYDWLVYVAQG;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static readonly ProfilerMarker UINSUDSOOHZ;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static readonly ProfilerMarker STKHGGMKZKO;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static readonly ProfilerMarker BLERUMAKJLU;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly Log XOKYAEWVTPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private QNFAKVYEUUU ASNEQIGBYHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private CrowdBatch IXPEALCFHZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Shader IJNGTIOGULW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MaterialPropertyBlock RHMBPEYXPKG;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9A61140", Offset = "0x9A5FB40", VA = "0x189A61140")]
		public static void SJLFYJJJEHQ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9A5FAE0", Offset = "0x9A5E4E0", VA = "0x189A5FAE0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9A5F8C0", Offset = "0x9A5E2C0", VA = "0x189A5F8C0")]
		public void FEACKIPQAZD(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9A61BD0", Offset = "0x9A605D0", VA = "0x189A61BD0")]
		private bool ZZGEENICNOI(MeshRenderer a, [Out] MeshFilter b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9A619D0", Offset = "0x9A603D0", VA = "0x189A619D0")]
		private bool ZYYGNYSLZCN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9A60770", Offset = "0x9A5F170", VA = "0x189A60770")]
		private void LMWRUIITCJK(GameObject a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9A60980", Offset = "0x9A5F380", VA = "0x189A60980")]
		private List<CrowdBatch.SingleMeshData> NDEGHZBJJSZ(int a, [Out] List<LODGroup> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9A60230", Offset = "0x9A5EC30", VA = "0x189A60230")]
		private List<(int, Material)> KBGEXLYGSAQ(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9A5F810", Offset = "0x9A5E210", VA = "0x189A5F810")]
		public void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9A61480", Offset = "0x9A5FE80", VA = "0x189A61480")]
		private bool WPULMGLMSLS(GameObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9A61FB0", Offset = "0x9A609B0", VA = "0x189A61FB0")]
		public CrowdOptimizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[BurstCompile]
	public class QNFAKVYEUUU : IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9A802B0", Offset = "0x9A7ECB0", VA = "0x189A802B0")]
			public CrowdAABB(Bounds bounds)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x9A80460", Offset = "0x9A7EE60", VA = "0x189A80460")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A82BF0", Offset = "0x9A815F0", VA = "0x189A82BF0")]
			private float NBBJWXJHIWY(CrowdAABB a, CrowdAABB b)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9A829E0", Offset = "0x9A813E0", VA = "0x189A829E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly ProfilerMarker NVHGMNDUZYS;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly ProfilerMarker MNKUGJYLZGG;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static readonly ProfilerMarker VHEWIOWVPMM;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static readonly ProfilerMarker BGPGVHQKRZF;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly ProfilerMarker TFKPUJSWNMG;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private static readonly ProfilerMarker RTGZAWKSHCG;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private static readonly ProfilerMarker FIJFKJDWSGI;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static readonly ProfilerMarker PJVWPJPHHUG;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static readonly ProfilerMarker HENVOLWTGRK;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker TROWXZMPUMI;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker STWFVBYYQGX;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker UVOGAZXEFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NativeArray<Node> HYBNUYXSDWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public NativeQueue<int> QBSYORIZXEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int LVMNZZDFESV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Dictionary<Material, int> CTEBFQNFILW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public List<MinimalMeshData> GPVTKUYFMPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public List<LODGroup> GAEWTUGNSCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Dictionary<int, MeshRenderer> DRNKZZFDJID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Queue<int> VVSLBVBDHWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Shader SAJZYLETTDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Shader DVCSTVHEQUL;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9A75CC0", Offset = "0x9A746C0", VA = "0x189A75CC0")]
		public QNFAKVYEUUU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9A72130", Offset = "0x9A70B30", VA = "0x189A72130")]
		private void BHYDUZMDLGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9A734D0", Offset = "0x9A71ED0", VA = "0x189A734D0")]
		public bool GOVFBPWBSZT(MeshRenderer a, MeshFilter b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9A727A0", Offset = "0x9A711A0", VA = "0x189A727A0")]
		public bool GOVFBPWBSZT(LODGroup a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9A725B0", Offset = "0x9A70FB0", VA = "0x189A725B0")]
		private bool Contains(MeshRenderer meshRenderer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9A758B0", Offset = "0x9A742B0", VA = "0x189A758B0")]
		private int ZLYGAZERUKX(MeshRenderer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9A72630", Offset = "0x9A71030", VA = "0x189A72630")]
		private int DSUUYRUJBLJ(LODGroup a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9A75750", Offset = "0x9A74150", VA = "0x189A75750")]
		private int ZIRURMJMDAQ(MeshFilter a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9A73A60", Offset = "0x9A72460", VA = "0x189A73A60")]
		private int HSXYNLOCDUC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9A74650", Offset = "0x9A73050", VA = "0x189A74650")]
		private static CrowdAABB QWANFYHHVIZ(CrowdAABB a, CrowdAABB b)
		{
			return default(CrowdAABB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9A73940", Offset = "0x9A72340", VA = "0x189A73940")]
		private static float HFCFVFQOOJK(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9A722A0", Offset = "0x9A70CA0", VA = "0x189A722A0")]
		private int CEPJQLLMTYG(int a, CrowdAABB b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9A73D90", Offset = "0x9A72790", VA = "0x189A73D90")]
		private void MIMKNKKIAGP(CrowdAABB a, int b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9A741E0", Offset = "0x9A72BE0", VA = "0x189A741E0")]
		private void QJQSLZYYKQS(CrowdAABB a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9A73FC0", Offset = "0x9A729C0", VA = "0x189A73FC0")]
		private float NBBJWXJHIWY(CrowdAABB a, CrowdAABB b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9A75330", Offset = "0x9A73D30", VA = "0x189A75330")]
		private void WUZJBHYVGGS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9A74970", Offset = "0x9A73370", VA = "0x189A74970")]
		private void Rotate(int indexA, int indexB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9A74DA0", Offset = "0x9A737A0", VA = "0x189A74DA0")]
		private void SEOPAUIPLRG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9A726F0", Offset = "0x9A710F0", VA = "0x189A726F0", Slot = "4")]
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
	public class KZAWJCVPCGR : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public NativeArray<RingVertex> CBPCIIQFNII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public NativeArray<int> KRNWPSRTTOB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int MMMFHYRJPPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int FOHTCWKJUNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xD1B440", Offset = "0xD19E40", VA = "0x180D1B440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9A83300", Offset = "0x9A81D00", VA = "0x189A83300")]
		public KZAWJCVPCGR(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9A831C0", Offset = "0x9A81BC0", VA = "0x189A831C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9A83220", Offset = "0x9A81C20", VA = "0x189A83220")]
		public void TTAWVIMBXXQ(KZAWJCVPCGR a, int b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class MQDUJVJMOUM
	{
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static KZAWJCVPCGR PAJCTWZOFVR;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static NativeList<MeshPartInfo> QPEIYICWYSL;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static int[] LIYLNMZALSC;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static bool DLZSDXKVKWM;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private static Dictionary<int, KZAWJCVPCGR> TQLJJCILQAI;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static Dictionary<int, KZAWJCVPCGR> CXVUTFLGCOV;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool FKWLJURYGUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x9A83D30", Offset = "0x9A82730", VA = "0x189A83D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static NativeList<MeshPartInfo> TXRAYGXDYCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x9A83CA0", Offset = "0x9A826A0", VA = "0x189A83CA0")]
			get
			{
				return default(NativeList<MeshPartInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static KZAWJCVPCGR FLKTEDCLIBV
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x9A84490", Offset = "0x9A82E90", VA = "0x189A84490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9A833C0", Offset = "0x9A81DC0", VA = "0x189A833C0")]
		private static void ACCZIORJLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9A84670", Offset = "0x9A83070", VA = "0x189A84670")]
		public static int WGWTLIYXECR(bool a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9A84470", Offset = "0x9A82E70", VA = "0x189A84470")]
		private static int QLFHOKUDGBX(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9A841C0", Offset = "0x9A82BC0", VA = "0x189A841C0")]
		private static int MMGOEXGJUMU(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9A84530", Offset = "0x9A82F30", VA = "0x189A84530")]
		public static int RSRGKKZLOFX(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9A846B0", Offset = "0x9A830B0", VA = "0x189A846B0")]
		public static int ZLUCWDHLUOC(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9A83A20", Offset = "0x9A82420", VA = "0x189A83A20")]
		public static int CUINNXJDERR(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9A846A0", Offset = "0x9A830A0", VA = "0x189A846A0")]
		private static int XLDPWFVBLZZ(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9A84650", Offset = "0x9A83050", VA = "0x189A84650")]
		private static int VGJFFGPAPOI(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9A845E0", Offset = "0x9A82FE0", VA = "0x189A845E0")]
		public static int UWHSFNRGQKL(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9A83A30", Offset = "0x9A82430", VA = "0x189A83A30")]
		public static int CWJTBJLXXPI(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9A845C0", Offset = "0x9A82FC0", VA = "0x189A845C0")]
		public static int SRFNDJXQOHL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9A83AC0", Offset = "0x9A824C0", VA = "0x189A83AC0")]
		public static KZAWJCVPCGR FRSZJSKDHZJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9A841D0", Offset = "0x9A82BD0", VA = "0x189A841D0")]
		private static KZAWJCVPCGR NZSKLWKYMLJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9A83BB0", Offset = "0x9A825B0", VA = "0x189A83BB0")]
		public static KZAWJCVPCGR IQLWBSLNSPW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9A84740", Offset = "0x9A83140", VA = "0x189A84740")]
		private static KZAWJCVPCGR ZQXYOIWFJNO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9A83DB0", Offset = "0x9A827B0", VA = "0x189A83DB0")]
		public static void MISXSDFTVGW()
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
		[Cpp2IlInjected.Address(RVA = "0x9A80650", Offset = "0x9A7F050", VA = "0x189A80650")]
		public CurveMeshGeneratorData(NativeArray<CurvePointData> pointDatas, int size = 1, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9A80570", Offset = "0x9A7EF70", VA = "0x189A80570", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A7BF80", Offset = "0x9A7A980", VA = "0x189A7BF80")]
		public CreateNativeMeshFromBatchedCurvesJob(JWLFCSSJZIO batchedShapeData, NativeMesh destMesh, float3 rootPositionWS, quaternion rootRotationWS, float rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9A7BD80", Offset = "0x9A7A780", VA = "0x189A7BD80")]
		public CreateNativeMeshFromBatchedCurvesJob(CurveMeshGeneratorData batchedShapeData, NativeMesh destMesh, float3 rootPositionWS, quaternion rootRotationWS, float3 rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A370", Offset = "0x9A78D70", VA = "0x189A7A370")]
		private float3 EGUDRNSRDQA(float3 a, Matrix4x4 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9A7BCF0", Offset = "0x9A7A6F0", VA = "0x189A7BCF0")]
		private float3x3 LNTUYBZITUL(float3x3 a, float3x3 b)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9A7BD70", Offset = "0x9A7A770", VA = "0x189A7BD70")]
		private float NUNVSPPUQNK(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A620", Offset = "0x9A79020", VA = "0x189A7A620", Slot = "4")]
		public void Execute(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A4B0", Offset = "0x9A78EB0", VA = "0x189A7A4B0")]
		private void EOSDVDFDDHW(int a, float3 b, float3 c, float3 d, float e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9A7B8B0", Offset = "0x9A7A2B0", VA = "0x189A7B8B0")]
		private void JGXQXMBXFCR(CurveShapeRootData a, float3 b, float3x3 c, float d, int e, int f, int g, float h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9A79DF0", Offset = "0x9A787F0", VA = "0x189A79DF0")]
		private void DXSCVRVYOXJ(int a, int b, CurveShapeRootData c, float3 d, float3x3 e, bool f, float g, int h, int i, int j)
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
		[Cpp2IlInjected.Address(RVA = "0x9A85C20", Offset = "0x9A84620", VA = "0x189A85C20")]
		public PrimitiveMeshGeneratorData(int size, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9A85BA0", Offset = "0x9A845A0", VA = "0x189A85BA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A7F330", Offset = "0x9A7DD30", VA = "0x189A7F330")]
		public CreateNativeMeshFromShapeBatchJob(JWLFCSSJZIO batchedShapeData, NativeMesh destMesh, NativeArray<int> destVertCollapseTargetIn, float3 rootPositionWS, quaternion rootRotationWS, float rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9A7F130", Offset = "0x9A7DB30", VA = "0x189A7F130")]
		public CreateNativeMeshFromShapeBatchJob(PrimitiveMeshGeneratorData data, NativeMesh destMesh, NativeArray<int> destVertCollapseTargetIn, float3 rootPositionWS, quaternion rootRotationWS, float3 rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9A7E010", Offset = "0x9A7CA10", VA = "0x189A7E010", Slot = "4")]
		public void Execute(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9A7DBD0", Offset = "0x9A7C5D0", VA = "0x189A7DBD0")]
		private void DXICLPZWYVK(float4x4 a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9A7DB60", Offset = "0x9A7C560", VA = "0x189A7DB60")]
		private ProjectionAxis DUHZKVRRKXH(float3 a)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9A7F0E0", Offset = "0x9A7DAE0", VA = "0x189A7F0E0")]
		private float4 WHFGVUDCDCH(ProjectionAxis a, int b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9A7F0A0", Offset = "0x9A7DAA0", VA = "0x189A7F0A0")]
		private float2 OHABVCKIKYV(ProjectionAxis a, float3 b)
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
		[Cpp2IlInjected.Address(RVA = "0x9A7C6B0", Offset = "0x9A7B0B0", VA = "0x189A7C6B0")]
		private float3 EGUDRNSRDQA(float3 a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9A7DAC0", Offset = "0x9A7C4C0", VA = "0x189A7DAC0")]
		private float3x3 LNTUYBZITUL(float3x3 a)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9A7DB50", Offset = "0x9A7C550", VA = "0x189A7DB50")]
		private float NUNVSPPUQNK(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9A7C960", Offset = "0x9A7B360", VA = "0x189A7C960", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9A7C7F0", Offset = "0x9A7B1F0", VA = "0x189A7C7F0")]
		private void EOSDVDFDDHW(int a, float3 b, float3 c, float3 d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9A7D5D0", Offset = "0x9A7BFD0", VA = "0x189A7D5D0")]
		private void JGXQXMBXFCR(CurvePointData a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9A7C160", Offset = "0x9A7AB60", VA = "0x189A7C160")]
		private void DXSCVRVYOXJ(int a, int b, float3 c, float3x3 d, bool e, float f, int g, float h)
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
		[Cpp2IlInjected.Address(RVA = "0x9A7F870", Offset = "0x9A7E270", VA = "0x189A7F870", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9A7F540", Offset = "0x9A7DF40", VA = "0x189A7F540")]
		private void DXICLPZWYVK(float4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9A7DB60", Offset = "0x9A7C560", VA = "0x189A7DB60")]
		private ProjectionAxis DUHZKVRRKXH(float3 a)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9A7F0E0", Offset = "0x9A7DAE0", VA = "0x189A7F0E0")]
		private float4 WHFGVUDCDCH(ProjectionAxis a, int b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9A7F0A0", Offset = "0x9A7DAA0", VA = "0x189A7F0A0")]
		private float2 OHABVCKIKYV(ProjectionAxis a, float3 b)
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
		public bool FGCJYTKVFEA
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9A851D0", Offset = "0x9A83BD0", VA = "0x189A851D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float3 RRXYUOOQTQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9A85620", Offset = "0x9A84020", VA = "0x189A85620")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9A85AB0", Offset = "0x9A844B0", VA = "0x189A85AB0")]
		public OcclusionData(float3 position, quaternion rotation, float3 size, OcclusionType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9A85820", Offset = "0x9A84220", VA = "0x189A85820")]
		public float YAFNBQTNJHO(float3 a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9A850E0", Offset = "0x9A83AE0", VA = "0x189A850E0")]
		public bool HICCKHZXRKM(float3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9A85470", Offset = "0x9A83E70", VA = "0x189A85470")]
		public void PXLYWTGXVDU(float3 a, float3x3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9A85700", Offset = "0x9A84100", VA = "0x189A85700")]
		private void QHIXCPCLTMZ(float3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x9A851E0", Offset = "0x9A83BE0", VA = "0x189A851E0")]
		public void PRYGNCSLPFO()
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
		[Cpp2IlInjected.Address(RVA = "0x9A81450", Offset = "0x9A7FE50", VA = "0x189A81450")]
		public DetectEnclosedTrianglesBatchedJob(NativeMesh mesh, float rootScale, int startIndex, int startVertex, NativeList<OcclusionData> data, NativeArray<int> shapeOcclusionDataIdx, NativeList<MeshPartInfo> shapeDest, IDMERDOGXHB optimizationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9A80780", Offset = "0x9A7F180", VA = "0x189A80780", Slot = "4")]
		public void Execute(int shapeIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9A81390", Offset = "0x9A7FD90", VA = "0x189A81390")]
		private bool YFIWXHXNAON(OcclusionData a, OcclusionData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9A81050", Offset = "0x9A7FA50", VA = "0x189A81050")]
		private bool QTQTHXPWCFX(OcclusionData a, int b, int c, int d)
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
		[Cpp2IlInjected.Address(RVA = "0x9A81590", Offset = "0x9A7FF90", VA = "0x189A81590", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9A814E0", Offset = "0x9A7FEE0", VA = "0x189A814E0")]
		private bool DFSHSLURVGT(OcclusionData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9A819E0", Offset = "0x9A803E0", VA = "0x189A819E0")]
		private bool QTQTHXPWCFX(OcclusionData a, int b, int c, int d)
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
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		public InitializeCollapseListJob(NativeArray<int> vertCollapseTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9A83190", Offset = "0x9A81B90", VA = "0x189A83190", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A82430", Offset = "0x9A80E30", VA = "0x189A82430")]
		public FinalizeNativeMeshCollapseListJob(NativeList<ShapeBatch.CollapseEntry> destCollapseList, NativeArray<int> srcVertCollapseTarget, int vertexStart = 0, int indexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A82380", Offset = "0x9A80D80", VA = "0x189A82380", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class IDMERDOGXHB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public NativeArray<bool> MCWIUPNDYJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public NativeArray<int> NQTNTMRSGHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public NativeArray<bool> QGMOPRYYAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public NativeArray<float> KUWTUGBPWEN;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9A83070", Offset = "0x9A81A70", VA = "0x189A83070")]
		public void NBBRSPDMQGL(int a, int b, Allocator c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x9A83050", Offset = "0x9A81A50", VA = "0x189A83050")]
		public static long GGFFMGHZJOG(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x9A82E70", Offset = "0x9A81870", VA = "0x189A82E70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9A82F60", Offset = "0x9A81960", VA = "0x189A82F60")]
		public void Dispose(JobHandle jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public IDMERDOGXHB()
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
		[Cpp2IlInjected.Address(RVA = "0x9A82960", Offset = "0x9A81360", VA = "0x189A82960")]
		public FinalizeNativeMeshOptimizationsJob(NativeMesh mesh, IDMERDOGXHB optimizationData, int vertexStart = 0, int indexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x9A82450", Offset = "0x9A80E50", VA = "0x189A82450", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x9A828F0", Offset = "0x9A812F0", VA = "0x189A828F0")]
		private void SVJDTMWMRRT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class AKNYWDKPSVU
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x33A3FE0", Offset = "0x33A29E0", VA = "0x1833A3FE0")]
		public static bool EGFDWVTGNWY<T>(NativeArray<T> a, int b, Allocator c, NativeArrayOptions d = NativeArrayOptions.ClearMemory, int e = 3) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x33A43B0", Offset = "0x33A2DB0", VA = "0x1833A43B0")]
		public static bool EGFDWVTGNWY<T>(NativeList<T> a, int b, Allocator c) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x33A4300", Offset = "0x33A2D00", VA = "0x1833A4300")]
		public static bool EGFDWVTGNWY<T>(NativeQueue<T> a, Allocator b) where T : struct
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
	public interface MINJGALAJOY
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DKNPCGGOGNN(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int FHDZBSFPXMR(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RRBounds WQXSICQRBJL();

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float CONJTODHEUD();

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OGJTSPDCCGH(SystemLOD a, JWLFCSSJZIO b, int c = -1);

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		int LICKLOKGWTL(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class IBNGZTHXFSJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9A82D20", Offset = "0x9A81720", VA = "0x189A82D20")]
		public static void MISXSDFTVGW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class VBBBIWSKPYV : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public NativeList<float3> NPXWPSISKMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public NativeArray<float3> RQCBSRLUQSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public NativeArray<int> ORNCMERFZVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public NativeArray<float4> FHLITSRJJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public NativeArray<float4> FHQPQZLGSTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public NativeArray<float4> FHVWOGFECES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public NativeArray<int> SUIDYNVAOJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public NativeList<float3> HWOQTJXRUWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public NativeList<int> NMZIGINVPSL;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int MMMFHYRJPPZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x9A8C1A0", Offset = "0x9A8ABA0", VA = "0x189A8C1A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int FOHTCWKJUNP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x9A8BDC0", Offset = "0x9A8A7C0", VA = "0x189A8BDC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int WVKMXXPEUDA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x9A8C1F0", Offset = "0x9A8ABF0", VA = "0x189A8C1F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9A8C5A0", Offset = "0x9A8AFA0", VA = "0x189A8C5A0")]
		public VBBBIWSKPYV(int a, int b, int c, Allocator d = Allocator.Persistent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9A8C240", Offset = "0x9A8AC40", VA = "0x189A8C240")]
		public VBBBIWSKPYV(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9A8B6F0", Offset = "0x9A8A0F0", VA = "0x189A8B6F0", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x9A8BE10", Offset = "0x9A8A810", VA = "0x189A8BE10")]
		public void TTAWVIMBXXQ(VBBBIWSKPYV a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9A8B800", Offset = "0x9A8A200", VA = "0x189A8B800")]
		private void LXLWQYOZSJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9A8B170", Offset = "0x9A89B70", VA = "0x189A8B170")]
		private void BEDVVIWUPLX()
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
		[Cpp2IlInjected.Address(RVA = "0x2152500", Offset = "0x2150F00", VA = "0x182152500")]
		public MeshPartInfo(int startVertex, int vertexCount, int startIndex, int indexCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class FTZIXOUXSTQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public NativeList<MeshPartInfo> QBWRVVZCGOY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return default(NativeList<MeshPartInfo>);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xEDA670", Offset = "0xED9070", VA = "0x180EDA670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public VBBBIWSKPYV GQBKHMYYRID
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x9A81D90", Offset = "0x9A80790", VA = "0x189A81D90")]
		public FTZIXOUXSTQ(IEnumerable<VBBBIWSKPYV> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9A81D20", Offset = "0x9A80720", VA = "0x189A81D20", Slot = "4")]
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
	public static class ZFIABEXRPVH
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static NativeArray<float2> OIXCSZHBFDS;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static NativeArray<float3> ACUVGSUHIYJ;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static NativeArray<float4> TULIPXFZNYW;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static NativeArray<int> PGYQXNNKKCF;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x9A8E680", Offset = "0x9A8D080", VA = "0x189A8E680")]
		public static void MISXSDFTVGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9A8E8B0", Offset = "0x9A8D2B0", VA = "0x189A8E8B0")]
		public static NativeArray<float2> RBUHKACBDXK(NativeArray<float2> a, int b, NativeArray<float2> c, int d)
		{
			return default(NativeArray<float2>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9A8E7A0", Offset = "0x9A8D1A0", VA = "0x189A8E7A0")]
		public static NativeArray<float3> QICSOMKAULL(NativeArray<float3> a, int b, NativeArray<float3> c, int d)
		{
			return default(NativeArray<float3>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9A8EAD0", Offset = "0x9A8D4D0", VA = "0x189A8EAD0")]
		public static NativeArray<float4> ZZXGOVOPFVM(NativeArray<float4> a, int b, NativeArray<float4> c, int d)
		{
			return default(NativeArray<float4>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9A8E9C0", Offset = "0x9A8D3C0", VA = "0x189A8E9C0")]
		public static NativeArray<int> WKPYLYGULQN(NativeArray<int> a, int b, NativeArray<int> c, int d)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4171C90", Offset = "0x4170690", VA = "0x184171C90")]
		private static void AZHLUUGJJPV<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4171F90", Offset = "0x4170990", VA = "0x184171F90")]
		private static void COVYDVCKIOE<b>(NativeArray<b> a, int b, NativeArray<b> c, int d, NativeArray<b> e) where b : struct
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
		public static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9A8E5E0", Offset = "0x9A8CFE0", VA = "0x189A8E5E0")]
		public static uint YXYPFXOEDJM(float a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x9A8E190", Offset = "0x9A8CB90", VA = "0x189A8E190")]
		public static void UQQBZFONRYX(float4 a, float b, [Out] uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x9A8E2A0", Offset = "0x9A8CCA0", VA = "0x189A8E2A0")]
		public static void UQQBZFONRYX(float4 a, uint b, [Out] uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9A8DAE0", Offset = "0x9A8C4E0", VA = "0x189A8DAE0")]
		public static void PJYRJDXAGTO(float3 a, float3 b, float4 c, float2 d, float4 e, [Out] NativeMesh.VertexFormat_NormTanOct8MatUi f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9A8DD80", Offset = "0x9A8C780", VA = "0x189A8DD80")]
		public static void PJYRJDXAGTO(float3 a, float3 b, float4 c, float2 d, float4 e, [Out] NativeMesh.VertexFormat_PosFixedPoint16NormTanOct8MatUi f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9A8E370", Offset = "0x9A8CD70", VA = "0x189A8E370")]
		public static byte WEIQQSDCFFE(float a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x9A8E580", Offset = "0x9A8CF80", VA = "0x189A8E580")]
		public static ushort XRRTXVLZNLP(float a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x9A8DA30", Offset = "0x9A8C430", VA = "0x189A8DA30")]
		public static uint JJGTWZNNFHF(float a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x9A8DA60", Offset = "0x9A8C460", VA = "0x189A8DA60")]
		public static float2 JYCLXPYMJTG(float2 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x9A8D8E0", Offset = "0x9A8C2E0", VA = "0x189A8D8E0")]
		public static float2 DBXWVDPNSBU(float3 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x9A8E040", Offset = "0x9A8CA40", VA = "0x189A8E040")]
		public static void SLSOMQMCUOD(float3 a, [Out] float3 b, [Out] uint3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x9A8E3D0", Offset = "0x9A8CDD0", VA = "0x189A8E3D0")]
		public static CompressedPositionFixedPoint16 WJVKYLHCXBZ(float3 a)
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
		public static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private static readonly ProfilerMarker UCAHKNCYNOW;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public static float PODJKCQUGFB;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void AYUSUVGBQYF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x9A8A0E0", Offset = "0x9A88AE0", VA = "0x189A8A0E0")]
		public static float JGVPEDAEDAM(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x9A89FF0", Offset = "0x9A889F0", VA = "0x189A89FF0")]
		public static long DFFOWSPHHQS(float a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x9A8A260", Offset = "0x9A88C60", VA = "0x189A8A260")]
		public static void OKJYCSYOTQR(float a)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Quartermaster
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public interface HQNRTUSUOHY
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OKJYCSYOTQR(float a);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		(long, long, int) TFPGJXEQWQS(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public static class VVTKCTKJFEP
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
		private class NQFLCRGSTFW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public WorkItemTypeEnum ONBAXEIQBBQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public BatchedMeshRenderer DEGKTKHCQNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public BatchedMesh LFBHETUVPVI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public ShapeBatch VXTRYDRFDHD;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9A84BD0", Offset = "0x9A835D0", VA = "0x189A84BD0")]
			public void SSIYIMJVZWF([Out] bool a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public NQFLCRGSTFW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private static int KVTZNTPKJQC;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private static ObjectPool<NQFLCRGSTFW> EWFEWFLANCS;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x9A8D460", Offset = "0x9A8BE60", VA = "0x189A8D460")]
		static VVTKCTKJFEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x9A8CE00", Offset = "0x9A8B800", VA = "0x189A8CE00")]
		private static void PWDXBHWMTYN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x9A8CA40", Offset = "0x9A8B440", VA = "0x189A8CA40")]
		private static void DHMSJXAXEVJ([In] QuartermasterWorkItem workItem, [Out] bool a, [Out] bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x9A8CAE0", Offset = "0x9A8B4E0", VA = "0x189A8CAE0")]
		public static void ODOAXKGYRMD(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x9A8CC70", Offset = "0x9A8B670", VA = "0x189A8CC70")]
		public static void OIPXULKIQNM(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x9A8C8C0", Offset = "0x9A8B2C0", VA = "0x189A8C8C0")]
		public static void CLYQBSECXVV(BatchedMesh a, BatchedMeshRenderer b, long c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x9A8CFE0", Offset = "0x9A8B9E0", VA = "0x189A8CFE0")]
		public static void SEEHVJXDSIZ(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9A8D170", Offset = "0x9A8BB70", VA = "0x189A8D170")]
		private static void YLSHFXQSVWI(WorkItemTypeEnum a, ShapeBatch b, BatchedMesh c, BatchedMeshRenderer d, long e, long f, float g, bool h, bool i, float j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public static class QuartermasterManager
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly ProfilerMarker UNAYCSHDCDM;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private static readonly ProfilerMarker NBGTXKDDBKJ;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private static readonly ProfilerMarker VGWROFVERVL;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static readonly ProfilerMarker PRAFXSZVLBF;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public static int ZTQVVSMJZKY;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public static int QQHRRPZPLTS;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public static int VGKEXFAWLAQ;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public static long YRTMJXZRMMC;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public static long BIHGHECAKOD;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public static long FIFDJNRMGOS;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public static long QMOYBFQYOQL;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public static int PCQAWZZTEAB;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public static float MHBAYHZVCXT;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public static bool XHBBZMAPSVC;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public static int EBXLUHINGKB;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public static int FFCPBMOOFQB;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public static int XIXZAMSBXGP;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public static long RDAFYOMRBTQ;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public static int IYTEJPEGHGR;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public static bool RKOANCAVYWX;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static uint ZOPJMURVGGN;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private static UKEVQJJNOHX ZOGYHVJKIDX;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static List<uint> LWQMUUGEJOL;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static List<(QuartermasterWorkItem.Execute, QuartermasterWorkItem.Release)> MPJZEFAPNAF;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private static HQNRTUSUOHY RPHXLHXCUNC;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private static HQNRTUSUOHY DLEHBKMTFPC;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool WTSOIRLSOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x9A85F30", Offset = "0x9A84930", VA = "0x189A85F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void SLJETIWVYTO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void AYUSUVGBQYF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void SLJETIWVYTO(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x9A85F80", Offset = "0x9A84980", VA = "0x189A85F80")]
		public static void JCLEQCFIYOC(HQNRTUSUOHY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9A86000", Offset = "0x9A84A00", VA = "0x189A86000")]
		public static void KDUDMLZQHVQ(HQNRTUSUOHY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9A88890", Offset = "0x9A87290", VA = "0x189A88890")]
		public static (long, long, long, int, int) PCWKLTUQAWJ(long a)
		{
			return default((long, long, long, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x9A85D10", Offset = "0x9A84710", VA = "0x189A85D10")]
		public static void ANSPNPKHHBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9A861D0", Offset = "0x9A84BD0", VA = "0x189A861D0")]
		public static void OKJYCSYOTQR(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9A88D10", Offset = "0x9A87710", VA = "0x189A88D10")]
		public static void RHJEUFTEHBX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9A88A60", Offset = "0x9A87460", VA = "0x189A88A60")]
		public static long PNIGEDZFUTI(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9A85E60", Offset = "0x9A84860", VA = "0x189A85E60")]
		public static bool GPBXMLNDSFS(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9A85D90", Offset = "0x9A84790", VA = "0x189A85D90")]
		public static bool GDMJGTCZAZT(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x9A88F30", Offset = "0x9A87930", VA = "0x189A88F30")]
		public static float TCOQMFJPKBM(long a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x9A89350", Offset = "0x9A87D50", VA = "0x189A89350")]
		public static (long, long, int) TFPGJXEQWQS(float a)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x9A897D0", Offset = "0x9A881D0", VA = "0x189A897D0")]
		public static void VLONYQJTXNE(QuartermasterWorkItem a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9A86080", Offset = "0x9A84A80", VA = "0x189A86080")]
		public static int OAMLTYFOOLZ(QuartermasterWorkItem.Execute a, QuartermasterWorkItem.Release b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9A89290", Offset = "0x9A87C90", VA = "0x189A89290")]
		public static bool TDIHWWQCCTS(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9A88EB0", Offset = "0x9A878B0", VA = "0x189A88EB0")]
		public static void SHHNXMISMPG(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9A88C00", Offset = "0x9A87600", VA = "0x189A88C00")]
		public static bool PPRNSJUANDD(float a)
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
		[Cpp2IlInjected.Address(RVA = "0x9A89FC0", Offset = "0x9A889C0", VA = "0x189A89FC0", Slot = "4")]
		private int EYVSLGIKVOJ(QuartermasterWorkItem a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x9A89FE0", Offset = "0x9A889E0", VA = "0x189A89FE0", Slot = "5")]
		private bool TZQPSFTFRTW(QuartermasterWorkItem a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class UKEVQJJNOHX
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
			public QuartermasterWorkItem UZNORYBBYVN
			{
				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0x9A9A720", Offset = "0x9A99120", VA = "0x189A9A720")]
				get
				{
					return default(QuartermasterWorkItem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A8A0", Offset = "0x9A992A0", VA = "0x189A9A8A0")]
			public QuartermasterWorkItemEnumerator(List<QuartermasterWorkItem> instantWorkItems, List<QuartermasterWorkItem> persistentWorkItems)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A5D0", Offset = "0x9A98FD0", VA = "0x189A9A5D0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private List<QuartermasterWorkItem> PONNQABDXSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private List<QuartermasterWorkItem> JQPEJBSNJBM;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int DJHUXMLNUTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x9A8B070", Offset = "0x9A89A70", VA = "0x189A8B070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x9A8A960", Offset = "0x9A89360", VA = "0x189A8A960")]
		public void Add([In] QuartermasterWorkItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x9A8B010", Offset = "0x9A89A10", VA = "0x189A8B010")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9A8AA50", Offset = "0x9A89450", VA = "0x189A8AA50")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x9A8AB30", Offset = "0x9A89530", VA = "0x189A8AB30")]
		public void LZEKMOGLGMX(IEnumerable<uint> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9A8AE30", Offset = "0x9A89830", VA = "0x189A8AE30")]
		private static void PXEMADGRIGI(List<QuartermasterWorkItem> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x9A8AF00", Offset = "0x9A89900", VA = "0x189A8AF00")]
		private void Remove(uint id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x9A8AAF0", Offset = "0x9A894F0", VA = "0x189A8AAF0")]
		public QuartermasterWorkItemEnumerator GetEnumerator()
		{
			return default(QuartermasterWorkItemEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x9A8B0C0", Offset = "0x9A89AC0", VA = "0x189A8B0C0")]
		public UKEVQJJNOHX()
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
		public static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private static readonly string RZJNYATECXC;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static readonly string QRIQBRAPQDB;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private static readonly ProfilerMarker YGXFUBBHLAN;

		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private static readonly ProfilerMarker VKNVKVHUNIO;

		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private static readonly ProfilerMarker UCAHKNCYNOW;

		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private static readonly ProfilerMarker UNGMGWFMRTG;

		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static readonly ProfilerMarker INDEQYXXBAQ;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static readonly ProfilerMarker TNKUHFKZKDN;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly ProfilerMarker RSJSOUMHFMR;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static readonly ProfilerMarker CKHFZBLFFVV;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static readonly ProfilerMarker LYMMAXOKOBH;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static readonly ProfilerMarker WANVQCTKZRJ;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly ProfilerMarker WATCNJNIJCS;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static readonly ProfilerMarker WAYJKQHFSOB;

		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private static readonly ProfilerMarker VZNNDUXYEMQ;

		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private static readonly ProfilerMarker VZSUBBRVNXZ;

		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private static readonly ProfilerMarker VZYAYILSXJI;

		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private static readonly ProfilerMarker WADHVPFQGUR;

		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private static readonly ProfilerMarker VYSLOTWISTG;

		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private static readonly ProfilerMarker BCKAXLIFUAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		internal readonly List<ShapeBatch> YKGBESHAXDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private readonly DisposeReminder NNDCOQGASCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private int ZZQRRCFBDHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private int IZSDSKCXRIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private bool KJQBQFMTUHZ;

		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public const bool DDLXIRWISUD = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public bool XPINCXAJSDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		internal ScalabilityStateMesh VBMEFKUOYFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		internal int PJHDHSXCHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		internal int ZUYHBPKPRUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		internal int QXNEZEJAHMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		internal int TLLMHDHRHKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		internal long OXGUZRGQKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		internal long EVJAVAVRSIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		internal long MBRLHEEEBXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private NativeMesh SOFTBPALMUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private NativeMesh SPSUEMDYTGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private NativeMesh.UnityMeshFormat ECCKSHJEPLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private bool XRGBWCETASJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private int WVLKUKHAMZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private BatchedMeshTessellate SNYLFMFEMHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private float3 ALUVLOTVREJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private float JQRKDDICHQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private float USKETXFAIPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private float NHBCREWWUDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private float IWLILTYLLHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private float KUHHYMZKUDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private float QHNBVGPOAEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private float3 MWOEBLVFSLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private float QFUXMHWTAFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private float SJCRFTEHTRY;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal Mesh GQBKHMYYRID
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xD12070", Offset = "0xD10A70", VA = "0x180D12070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public MeshFilter PLXCBIAJCQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xD11BA0", Offset = "0xD105A0", VA = "0x180D11BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public MeshRenderer ODNAXYHNNUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xD15990", Offset = "0xD14390", VA = "0x180D15990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public List<Material> VRPCSBRJVUB
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xD15950", Offset = "0xD14350", VA = "0x180D15950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int DYOJMVCEIEP
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xF39480", Offset = "0xF37E80", VA = "0x180F39480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int MMMFHYRJPPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x9A98D70", Offset = "0x9A97770", VA = "0x189A98D70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int FOHTCWKJUNP
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x9A982B0", Offset = "0x9A96CB0", VA = "0x189A982B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x9A98AB0", Offset = "0x9A974B0", VA = "0x189A98AB0")]
		public void TPMRJWKYYQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x9A984C0", Offset = "0x9A96EC0", VA = "0x189A984C0")]
		public bool QMHNISJBDPQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x9A98B70", Offset = "0x9A97570", VA = "0x189A98B70")]
		private void UGRNJGBVFZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x9A94B70", Offset = "0x9A93570", VA = "0x189A94B70")]
		private void BVQXKDOALKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x9A999D0", Offset = "0x9A983D0", VA = "0x189A999D0")]
		public BatchedMesh(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9A95DE0", Offset = "0x9A947E0", VA = "0x189A95DE0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x9A94C90", Offset = "0x9A93690", VA = "0x189A94C90")]
		private void CKNYUFSPLOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x9A95960", Offset = "0x9A94360", VA = "0x189A95960")]
		private void CreateNewUnityMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x9A96A10", Offset = "0x9A95410", VA = "0x189A96A10")]
		private void EEFIXAZXUIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x9A95B50", Offset = "0x9A94550", VA = "0x189A95B50")]
		public Mesh DHFTVNFJVQI(MeshFilter a, Transform b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x9A970C0", Offset = "0x9A95AC0", VA = "0x189A970C0")]
		public void KYNDFVHZJCZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x9A972A0", Offset = "0x9A95CA0", VA = "0x189A972A0")]
		private void LGLMOUTARWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9A96CA0", Offset = "0x9A956A0", VA = "0x189A96CA0")]
		public void FLKOMDELGWA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9A96AB0", Offset = "0x9A954B0", VA = "0x189A96AB0")]
		public void EXNGROUQKPW(MINJGALAJOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9A98C10", Offset = "0x9A97610", VA = "0x189A98C10")]
		public bool UNYJRBTRIPV(MINJGALAJOY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9A95880", Offset = "0x9A94280", VA = "0x189A95880")]
		public bool Contains(MINJGALAJOY meshGenerator)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9A98D90", Offset = "0x9A97790", VA = "0x189A98D90", Slot = "4")]
		public virtual void VJPSWFJMWWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9A98EA0", Offset = "0x9A978A0", VA = "0x189A98EA0")]
		public void YMXXUUIMMNG(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x9A976D0", Offset = "0x9A960D0", VA = "0x189A976D0")]
		public bool NARFZEJLRML(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9A95BC0", Offset = "0x9A945C0", VA = "0x189A95BC0")]
		public bool DJOVBWHXCXE(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9A98560", Offset = "0x9A96F60", VA = "0x189A98560")]
		private void SPXNOOEGYVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x9A97A00", Offset = "0x9A96400", VA = "0x189A97A00")]
		public bool OKJYCSYOTQR([In] float4x4 worldFromLocal, BatchedMeshRenderer a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x9A993C0", Offset = "0x9A97DC0", VA = "0x189A993C0")]
		public bool ZGRNWXWEYMD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x9A95F10", Offset = "0x9A94910", VA = "0x189A95F10")]
		public bool ECCKITFOSMM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x9A96D40", Offset = "0x9A95740", VA = "0x189A96D40")]
		public void GVRHMQCWWII(NativeMesh a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x9A97900", Offset = "0x9A96300", VA = "0x189A97900")]
		public (long, long, long) NQPPCRJNOYC()
		{
			return default((long, long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xD14200", Offset = "0xD12C00", VA = "0x180D14200")]
		public long ZITCBANMHZE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9A96E30", Offset = "0x9A95830", VA = "0x189A96E30")]
		private void HIAQNSFLTCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9A98600", Offset = "0x9A97000", VA = "0x189A98600")]
		public (long, long, int) TFPGJXEQWQS(float a, [In] float4x4 worldFromLocal)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xD8A750", Offset = "0xD89150", VA = "0x180D8A750")]
		internal void AJWDPBEQAPF(ScalabilityStateMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x9A950F0", Offset = "0x9A93AF0", VA = "0x189A950F0")]
		internal (float, float, float, float) CTVNSZUVMNF(float a, [In] float4x4 worldFromLocal)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x9A98810", Offset = "0x9A97210", VA = "0x189A98810")]
		private void TGXIVBRIJGL(NativeMesh a, NativeMesh.UnityMeshFormat b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x9A98B50", Offset = "0x9A97550", VA = "0x189A98B50")]
		private void TVVKZHDJWCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x9A97360", Offset = "0x9A95D60", VA = "0x189A97360")]
		internal bool LRKEEZNURSS(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x9A94D30", Offset = "0x9A93730", VA = "0x189A94D30")]
		private void CSRHCZZLKEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x9A98A10", Offset = "0x9A97410", VA = "0x189A98A10")]
		private void TKLYKBZUXEU(NativeMesh.UnityMeshFormat a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9A974F0", Offset = "0x9A95EF0", VA = "0x189A974F0")]
		private void MYSJIRAMGNZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9A982D0", Offset = "0x9A96CD0", VA = "0x189A982D0")]
		public long PNIGEDZFUTI(long a, int b)
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
			[Cpp2IlInjected.Address(RVA = "0x9A9A960", Offset = "0x9A99360", VA = "0x189A9A960")]
			public void SRPDLCJVRSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A8E0", Offset = "0x9A992E0", VA = "0x189A9A8E0")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private static readonly string RZJNYATECXC;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private static readonly string QRIQBRAPQDB;

		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private static readonly ProfilerMarker YGXFUBBHLAN;

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private static readonly ProfilerMarker OAJKNUGFJWX;

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private static readonly ProfilerMarker UCAHKNCYNOW;

		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private static readonly ProfilerMarker IRRVVNYRPTT;

		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private static readonly ProfilerMarker UNGMGWFMRTG;

		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private static readonly ProfilerMarker INDEQYXXBAQ;

		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private static readonly ProfilerMarker TNKUHFKZKDN;

		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private static readonly ProfilerMarker RSJSOUMHFMR;

		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private static readonly ProfilerMarker CKHFZBLFFVV;

		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private static readonly ProfilerMarker LQEWQGRRDOT;

		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private static readonly ProfilerMarker LYMMAXOKOBH;

		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private static readonly ProfilerMarker ZHALALFYCEH;

		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private static readonly ProfilerMarker PECPETSXTEN;

		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private static readonly ProfilerMarker BTFATUIHFYC;

		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private static readonly ProfilerMarker RJOMFLOHQQX;

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static readonly ProfilerMarker WANVQCTKZRJ;

		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private static readonly ProfilerMarker WATCNJNIJCS;

		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private static readonly ProfilerMarker WAYJKQHFSOB;

		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private static readonly ProfilerMarker VZNNDUXYEMQ;

		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private static readonly ProfilerMarker VZSUBBRVNXZ;

		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private static readonly ProfilerMarker VZYAYILSXJI;

		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private static readonly ProfilerMarker WADHVPFQGUR;

		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private static readonly ProfilerMarker VYSLOTWISTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		internal readonly List<MINJGALAJOY> IPPCTJYFWCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		internal BatchedMesh HWSLTMBADHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private readonly DisposeReminder NNDCOQGASCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		internal int PSRGQQICMQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		internal int XRZSPPFJDBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		internal bool VLRBRSZEEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		internal bool FVYJBCLHPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		internal ScalabilityStateShapes IUQWEIZPJVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		internal bool JPKTYVGYSZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		internal float3 UIHPNPGUCRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		internal float3 SOPIVRCDGBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		internal float NYTKEPLMVQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		internal int ORGTFTDRPDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		internal int IASRXTCXPAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		internal int AOMEDQMVSOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		internal float HPBCRELOAEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		internal int YSCVMMMJYWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		internal float OJLFRBWANKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		internal float KUCONUAUVUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		internal int OLSBYDWSVZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		internal long NUOEUXHNYSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public int CLCWTSEYCWA;

		[Cpp2IlInjected.Token(Token = "0x4000270")]
		internal const int GNASOTUTZTV = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		internal float[] LNHJBQGAIZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		internal int[] FAXVUDEVXOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		internal long[] QUWAWRMMYQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public List<ScaledMesh> MRSNLKYTATL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		internal NativeMesh QFJWPDDLFIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		internal long NWMJWYAYNFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		internal int CJBGSYYKDCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		internal float FPOOKJGINHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		internal NativeMesh.UnityMeshFormat SKIBEXQRWAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		internal CompressedNativeMeshStruct MLUFZJYXASF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		internal int VLKKAKSNBAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		internal float SSRHWWXVVNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		internal long FTCYMLHWRKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		internal bool GPKHPHSZLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		internal ScaleMeshToDesiredTriCountsJob RXLDEWGXLTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		internal JobHandle BGYNWMAQDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		internal NativeList<CollapseEntry> LDBPGAYEPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		internal NativeArray<long> NKQRLWEMFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		internal bool MIANCHSRWGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		internal JobHandle KDLKJIZNOEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		internal NativeMesh OCBRXCSYVZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		internal IDMERDOGXHB IBWYLTHCJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		internal NativeList<CollapseEntry> LIUOGHIFIQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		internal Transform QZVJDUUCUSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		internal SystemLOD TEHLYGMPCMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		internal long ZQXIIZTLBWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		internal long DGLCOTAYSGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		internal long LYJRFYJRBMB;

		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private static bool BVVLURXZKVD;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public List<MINJGALAJOY> ZVHCQWZTCTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal int MMMFHYRJPPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x9AA2C40", Offset = "0x9AA1640", VA = "0x189AA2C40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x9AA2A60", Offset = "0x9AA1460", VA = "0x189AA2A60")]
		internal void TPMRJWKYYQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x9AA2A70", Offset = "0x9AA1470", VA = "0x189AA2A70")]
		internal void UGRNJGBVFZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA40E0", Offset = "0x9AA2AE0", VA = "0x189AA40E0")]
		internal ShapeBatch(string name, BatchedMesh parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9A9D780", Offset = "0x9A9C180", VA = "0x189A9D780")]
		internal void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F3A0", Offset = "0x9A9DDA0", VA = "0x189A9F3A0")]
		internal void LGLMOUTARWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9A9EEB0", Offset = "0x9A9D8B0", VA = "0x189A9EEB0")]
		internal void JNOISSBRFTP(MINJGALAJOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9A9DF10", Offset = "0x9A9C910", VA = "0x189A9DF10")]
		internal bool FSLZHIRYLIM(MINJGALAJOY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F100", Offset = "0x9A9DB00", VA = "0x189A9F100")]
		internal bool JXIXKNILYZO(MINJGALAJOY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9AA2C60", Offset = "0x9AA1660", VA = "0x189AA2C60", Slot = "4")]
		internal virtual void VJPSWFJMWWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9AA20C0", Offset = "0x9AA0AC0", VA = "0x189AA20C0")]
		public float RCZFDRFXQMU(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F700", Offset = "0x9A9E100", VA = "0x189A9F700")]
		public bool MGVVATUKQBF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B7B0", Offset = "0x9A9A1B0", VA = "0x189A9B7B0")]
		public (CompressedNativeMeshStruct, NativeMesh.UnityMeshFormat) BINRTRXTETT()
		{
			return default((CompressedNativeMeshStruct, NativeMesh.UnityMeshFormat));
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9AA0C70", Offset = "0x9A9F670", VA = "0x189AA0C70")]
		internal long OUWYYDCZSSU()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x9AA2CE0", Offset = "0x9AA16E0", VA = "0x189AA2CE0")]
		internal long WSMZBKGDGIV()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x9AA15A0", Offset = "0x9A9FFA0", VA = "0x189AA15A0")]
		internal bool QRHUYYRNZTC(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9A9C940", Offset = "0x9A9B340", VA = "0x189A9C940")]
		internal bool DJOVBWHXCXE(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9AA21B0", Offset = "0x9AA0BB0", VA = "0x189AA21B0")]
		internal void SPXNOOEGYVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F9C0", Offset = "0x9A9E3C0", VA = "0x189A9F9C0")]
		internal bool OKJYCSYOTQR([In] float4x4 worldFromLocal, BatchedMeshRenderer a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA09E0", Offset = "0x9A9F3E0", VA = "0x189AA09E0")]
		internal bool OQSSNJGPVHN(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F6F0", Offset = "0x9A9E0F0", VA = "0x189A9F6F0")]
		internal void LVCBTXCDNCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9A9EA00", Offset = "0x9A9D400", VA = "0x189A9EA00")]
		internal void GVRHMQCWWII(NativeMesh a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9A9EC20", Offset = "0x9A9D620", VA = "0x189A9EC20")]
		internal void JDJXMUJKRRP(CompressedNativeMeshStruct a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9A9EA30", Offset = "0x9A9D430", VA = "0x189A9EA30")]
		internal void HIAQNSFLTCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9AA25D0", Offset = "0x9AA0FD0", VA = "0x189AA25D0")]
		internal (long, long, int) TFPGJXEQWQS(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xD1A690", Offset = "0xD19090", VA = "0x180D1A690")]
		internal void AJWDPBEQAPF(ScalabilityStateShapes a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9A9C350", Offset = "0x9A9AD50", VA = "0x189A9C350")]
		public static (float, float, float, float) CTVNSZUVMNF(float3 a, float3 b, float c, [In] float4x4 worldFromLocal, float d)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9A9C730", Offset = "0x9A9B130", VA = "0x189A9C730")]
		internal (float, float, float, float) CTVNSZUVMNF(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F990", Offset = "0x9A9E390", VA = "0x189A9F990")]
		private float NMVNWNCSVCO(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BDE0", Offset = "0x9A9A7E0", VA = "0x189A9BDE0")]
		private (int, int, float) CMHOULZYUVJ(float a)
		{
			return default((int, int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3990", Offset = "0x9AA2390", VA = "0x189AA3990")]
		internal static float YWENHVRPVKZ(MINJGALAJOY a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A990", Offset = "0x9A99390", VA = "0x189A9A990")]
		internal void ACXKIXVROQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F900", Offset = "0x9A9E300", VA = "0x189A9F900")]
		internal void MYSJIRAMGNZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F160", Offset = "0x9A9DB60", VA = "0x189A9F160")]
		internal void LDZVUOHNBAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA0FC0", Offset = "0x9A9F9C0", VA = "0x189AA0FC0")]
		internal long PNIGEDZFUTI(long a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA2E00", Offset = "0x9AA1800", VA = "0x189AA2E00")]
		private void YBELABIQNON(NativeMesh a, NativeList<CollapseEntry> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA0D20", Offset = "0x9A9F720", VA = "0x189AA0D20")]
		internal void PCKIGEJRRGU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9A9D8B0", Offset = "0x9A9C2B0", VA = "0x189A9D8B0")]
		public static void ERSDOZQNKXT(NativeList<CollapseEntry> a, NativeMesh b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x9AA2BB0", Offset = "0x9AA15B0", VA = "0x189AA2BB0")]
		private float UPCTEXLXMBN(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9A9DF90", Offset = "0x9A9C990", VA = "0x189A9DF90")]
		internal void FZOJWPUSCMZ(NativeMesh a, CompressedNativeMesh b, int c, int d, float e)
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
		internal static class HIYOZDIBPRE
		{
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A2C0", Offset = "0x9A98CC0", VA = "0x189A9A2C0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A450", Offset = "0x9A98E50", VA = "0x189A9A450")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x9A90F00", Offset = "0x9A8F900", VA = "0x189A90F00")]
			public static void Invoke(BatchedMeshTessellateJob bmtj, [In] TriToTessellate tri)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void TessellateQuad_00000271$PostfixBurstDelegate(BatchedMeshTessellateJob bmtj, [In] QuadToTessellate quad);

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		internal static class VKSWQNCTHZN
		{
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x9AA47E0", Offset = "0x9AA31E0", VA = "0x189AA47E0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4970", Offset = "0x9AA3370", VA = "0x189AA4970")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x9A92770", Offset = "0x9A91170", VA = "0x189A92770")]
			public static void Invoke(BatchedMeshTessellateJob bmtj, [In] QuadToTessellate quad)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void BuildNativeMesh_00000274$PostfixBurstDelegate(UnsafeList<int>* resultIndices, UnsafeList<float3>* resultVerts, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* newVerts, UnsafeList<int>* newIndices, UnsafeList<float3>* inMeshVerts, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int numIndices, int numVerts);

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		internal static class CYNUERRSJIT
		{
			[Cpp2IlInjected.Token(Token = "0x40002CF")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x9A99FB0", Offset = "0x9A989B0", VA = "0x189A99FB0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A140", Offset = "0x9A98B40", VA = "0x189A9A140")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x9A99C60", Offset = "0x9A98660", VA = "0x189A99C60")]
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
		public UVZGWPAKVAU.ScalabilityTessellationModeEnum shapesTessellateMode;

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
		[Cpp2IlInjected.Address(RVA = "0x9A92630", Offset = "0x9A91030", VA = "0x189A92630")]
		private static float RAYRTCUWYLI([In] BatchedMeshTessellateJob bmtj, [In] float3 vertPos, float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9A91100", Offset = "0x9A8FB00", VA = "0x189A91100")]
		private static int GUTRWFRFXUM(BatchedMeshTessellateJob a, [Out] TessVert b, [In] TessVert vert0, [In] TessVert vert1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9A90F00", Offset = "0x9A8F900", VA = "0x189A90F00")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.TessellateTri_00000270$PostfixBurstDelegate))]
		private static void FIPNTAGYMKP(BatchedMeshTessellateJob a, [In] TriToTessellate tri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9A92770", Offset = "0x9A91170", VA = "0x189A92770")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.TessellateQuad_00000271$PostfixBurstDelegate))]
		private static void UCDZOTICFCB(BatchedMeshTessellateJob a, [In] QuadToTessellate quad)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9A90EF0", Offset = "0x9A8F8F0", VA = "0x189A90EF0", Slot = "4")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9A92970", Offset = "0x9A91370", VA = "0x189A92970")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal void XVLWWNHIKPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9A926C0", Offset = "0x9A910C0", VA = "0x189A926C0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.BuildNativeMesh_00000274$PostfixBurstDelegate))]
		internal unsafe static void TRVYIHNPASM(UnsafeList<int>* a, UnsafeList<float3>* b, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* c, UnsafeList<int>* d, UnsafeList<float3>* e, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int f, int g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C80", Offset = "0x9A90680", VA = "0x189A91C80")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal static void IEJMAJHLJSS(BatchedMeshTessellateJob a, [In] TriToTessellate tri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x9A91280", Offset = "0x9A8FC80", VA = "0x189A91280")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal static void HRLFNUJBDJS(BatchedMeshTessellateJob a, [In] QuadToTessellate quad)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9A90740", Offset = "0x9A8F140", VA = "0x189A90740")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal unsafe static void AICUGPZDDZB(UnsafeList<int>* a, UnsafeList<float3>* b, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* c, UnsafeList<int>* d, UnsafeList<float3>* e, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int f, int g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class BatchedMeshTessellate
	{
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private static readonly ProfilerMarker NAPGQVLNEKI;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public const int SMAZFMQTXTT = 2;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private const int KSQHPNDERCD = 1;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private static int JLDQBKJIPNT;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private static Stack<BatchedMeshTessellate> TFRPLXCAQCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private NativeMesh MXCJOXSPMRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private NativeList<TessVert> DHFDCSGTXNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private NativeList<int> CRLYSTCTHTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private NativeList<BatchedMeshTessellateJob.TriToTessellate> ZRJKIEULCAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private NativeList<BatchedMeshTessellateJob.TriToTessellate> HODXTEYWIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private NativeList<BatchedMeshTessellateJob.QuadToTessellate> ZXWGGJXOKAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private NativeList<BatchedMeshTessellateJob.QuadToTessellate> PQVJPUNKBFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private BatchedMeshTessellateJob ETENOEOCYEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private JobHandle MJOEAOJBRKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private BatchedMeshTessellateJob.GenerateTessellatedMeshResults GLOKVJFVQMF;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private const int XNQVEBSDRBH = 65530;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x9A949E0", Offset = "0x9A933E0", VA = "0x189A949E0")]
		private BatchedMeshTessellate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9A94490", Offset = "0x9A92E90", VA = "0x189A94490")]
		public void TNHIEIDTGNV(NativeMesh a, float3 b, float c, float d, float e, List<ShapeBatch.CollapseEntry> f, Allocator g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9A93B60", Offset = "0x9A92560", VA = "0x189A93B60")]
		public (bool, NativeMesh, float) PHOGCIWGGZY(List<ShapeBatch.CollapseEntry> a, Allocator b, bool c)
		{
			return default((bool, NativeMesh, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x9A93880", Offset = "0x9A92280", VA = "0x189A93880")]
		public static bool CTCLIUQSTDD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x9A94840", Offset = "0x9A93240", VA = "0x189A94840")]
		public static int WGPXBZQYDHE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9A94890", Offset = "0x9A93290", VA = "0x189A94890")]
		public static int XVZLLWKVPDW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9A94050", Offset = "0x9A92A50", VA = "0x189A94050")]
		public static BatchedMeshTessellate QLAXEKUCHWB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9A93910", Offset = "0x9A92310", VA = "0x189A93910")]
		internal static void LKTMVJNBSHE(BatchedMeshTessellate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x9A94320", Offset = "0x9A92D20", VA = "0x189A94320")]
		public static void THBOBQEHMEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x9A939B0", Offset = "0x9A923B0", VA = "0x189A939B0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		public static void MISXSDFTVGW()
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
		[Cpp2IlInjected.Address(RVA = "0x9AA4790", Offset = "0x9AA3190", VA = "0x189AA4790")]
		public static void Create([Out] TessVert result, int srcIndex, [In] float3 posIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9AA44A0", Offset = "0x9AA2EA0", VA = "0x189AA44A0")]
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
			public UVZGWPAKVAU.ScalabilityCollapseMetricEnum shapesCollapseMetric;

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
			[Cpp2IlInjected.Address(RVA = "0x9AAECC0", Offset = "0x9AAD6C0", VA = "0x189AAECC0")]
			public void NBBRSPDMQGL(int a, int b, Allocator c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x9AAE8A0", Offset = "0x9AAD2A0", VA = "0x189AAE8A0")]
			public static NativeMeshJob EBGMJXHFTPJ(NativeMesh a)
			{
				return default(NativeMeshJob);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x419C050", Offset = "0x419AA50", VA = "0x18419C050")]
			private static void YETFPIJXVKD<T>(NativeArray<T> a, NativeArray<T> b) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x9AAE7E0", Offset = "0x9AAD1E0", VA = "0x189AAE7E0")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void Setup_FastCopyCollapse_0000028F$PostfixBurstDelegate(int numCollapses, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		internal static class QFGOLKCYRLY
		{
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x9AAF0C0", Offset = "0x9AADAC0", VA = "0x189AAF0C0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x9AAF240", Offset = "0x9AADC40", VA = "0x189AAF240")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x9AAEEA0", Offset = "0x9AAD8A0", VA = "0x189AAEEA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AB31C0", Offset = "0x9AB1BC0", VA = "0x189AB31C0")]
		public ScaleMeshToDesiredTriCountsJob([In] List<ShapeBatch.ScaledMesh> meshListIn, NativeList<ShapeBatch.CollapseEntry> collapseListOut, [In] NativeMesh meshSrcIn, [In] NativeList<ShapeBatch.CollapseEntry> collapseListIn, [In] NativeArray<long> scaleMeshJobAbortRequest, float3 bboxMin, float3 bboxMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0240", Offset = "0x9AAEC40", VA = "0x189AB0240")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.Setup_FastCopyCollapse_0000028F$PostfixBurstDelegate))]
		private unsafe static void CAAWCQXKWTG(int a, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9AB2C00", Offset = "0x9AB1600", VA = "0x189AB2C00")]
		public static long SFVBSGSPMCE(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1970", Offset = "0x9AB0370", VA = "0x189AB1970", Slot = "4")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1BF0", Offset = "0x9AB05F0", VA = "0x189AB1BF0")]
		public void NWGNJUWWZNV(List<ShapeBatch.ScaledMesh> a, [In] ShapeBatch shapeBatchIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0220", Offset = "0x9AAEC20", VA = "0x189AB0220")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private bool AbortRequested()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x9AB19C0", Offset = "0x9AB03C0", VA = "0x189AB19C0")]
		private CompressedNativeMeshStruct JIGZPOYSZTW(int a, Allocator b)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0250", Offset = "0x9AAEC50", VA = "0x189AB0250")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private void EFMINFQEAUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9AB2640", Offset = "0x9AB1040", VA = "0x189AB2640")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private float QNQQOUWBUZE(int a, int b, bool c, bool d, float e, float f, float g, float h, float i, float j, float k)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x9AB2C20", Offset = "0x9AB1620", VA = "0x189AB2C20")]
		[IgnoreWarning(1371)]
		private ScaledMeshJob SIQGOWWTFII([In] ScaledMeshJob scaledMeshJobSrc, int a, [In] NativeArray<int> indices, [In] NativeArray<bool> vertexUsed, NativeArray<int> b)
		{
			return default(ScaledMeshJob);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x9AB2F40", Offset = "0x9AB1940", VA = "0x189AB2F40")]
		public static int WTCLXNOWMPS(NativeArray<int> a, NativeArray<int> b, int c, int d, int e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4BA0", Offset = "0x9AA35A0", VA = "0x189AA4BA0")]
		[BurstCompile]
		internal unsafe static void IFIOHQQNETV(int a, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int b)
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
			public MINJGALAJOY shape;

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x9AAE710", Offset = "0x9AAD110", VA = "0x189AAE710")]
			public BoundsShape(RRBounds inBounds, MINJGALAJOY inEntry)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		private class DSNAREHVOXS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public RRBounds AEBEGMSKUHZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			public int SEQAWKKQLNV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public float NYTKEPLMVQF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public List<BoundsShape> IZCQSECXPLW;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x9AAE740", Offset = "0x9AAD140", VA = "0x189AAE740")]
			public DSNAREHVOXS(RRBounds a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private static readonly ProfilerMarker WKCUQXSSEAO;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private static readonly ProfilerMarker SIIIJZINEJR;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private static readonly ProfilerMarker WPAMVPKAMAD;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static readonly ProfilerMarker HNTSFHSSGVU;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private static readonly ProfilerMarker SOYDGSHZHNW;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static readonly ProfilerMarker TNKUHFKZKDN;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private static readonly ProfilerMarker BTDICUHACZO;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		internal const int DMGTZPSSCLJ = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		internal static Dictionary<Material, List<Material>> BZBUSZHVVOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private Dictionary<Material, List<BatchedMesh>> UNPPGEHHDVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		internal List<BatchedMesh> JBNCDDVGOZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private List<MeshRenderer> JZLDVJPQJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private Transform FMJMKQPLQXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private bool LPNMWMDBBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private bool QAXAIQFFOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private int HLVKFWYNOVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private BatchedMesh HZGNAISWIHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Material JGVNGIDOLES;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private static bool? YJWEFFVFHUW;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private const int EQXQMBVNKNZ = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private static List<BoundsShape> RIUDIBPHDJC;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<MeshRenderer> KKLQEUQKLTH
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int PNGOUXBYUBY
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x9AAAE60", Offset = "0x9AA9860", VA = "0x189AAAE60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private static bool YXCNHVJCGNI
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6690", Offset = "0x9AA5090", VA = "0x189AA6690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void SLJETIWVYTO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void SLJETIWVYTO(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void IQHNTOIBVZB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4E00", Offset = "0x9AA3800", VA = "0x189AA4E00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9AAAA30", Offset = "0x9AA9430", VA = "0x189AAAA30")]
		internal bool XCIDNWYRMPU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9AAA9B0", Offset = "0x9AA93B0", VA = "0x189AAA9B0")]
		private Transform VYNLNBLHANG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6E10", Offset = "0x9AA5810", VA = "0x189AA6E10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5090", Offset = "0x9AA3A90", VA = "0x189AA5090", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4BE0", Offset = "0x9AA35E0", VA = "0x189AA4BE0")]
		public BatchedMesh AddToBatchedMesh(MINJGALAJOY newMesh, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x9AAA5F0", Offset = "0x9AA8FF0", VA = "0x189AAA5F0")]
		public void RemoveFromBatchedMesh(MINJGALAJOY mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4F60", Offset = "0x9AA3960", VA = "0x189AA4F60")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9AAA830", Offset = "0x9AA9230", VA = "0x189AAA830")]
		private void UEFVSRCAEUY(Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6620", Offset = "0x9AA5020", VA = "0x189AA6620")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6610", Offset = "0x9AA5010", VA = "0x189AA6610")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5E20", Offset = "0x9AA4820", VA = "0x189AA5E20")]
		private void HJROJDHKSCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6910", Offset = "0x9AA5310", VA = "0x189AA6910")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6410", Offset = "0x9AA4E10", VA = "0x189AA6410")]
		private BatchedMesh IDQIDKTDEOR(MINJGALAJOY a, Material b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x9AA54A0", Offset = "0x9AA3EA0", VA = "0x189AA54A0")]
		private BatchedMesh FJOAFEJNOPL(Material a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6E20", Offset = "0x9AA5820", VA = "0x189AA6E20")]
		private BatchedMesh PXQCMVEIFOE(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x9AA75F0", Offset = "0x9AA5FF0", VA = "0x189AA75F0")]
		internal void QACLQANWIQZ([Out] float4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5780", Offset = "0x9AA4180", VA = "0x189AA5780")]
		public static List<Material> GenerateVertexFormatVariants(Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x9AAA8B0", Offset = "0x9AA92B0", VA = "0x189AAA8B0")]
		public static void UpdateMaterialVariants(Material parentMaterial, Action<Material> updateFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xF5A8D0", Offset = "0xF592D0", VA = "0x180F5A8D0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x9AA67B0", Offset = "0x9AA51B0", VA = "0x189AA67B0")]
		public void MarkDirty(MINJGALAJOY mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x9AAA730", Offset = "0x9AA9130", VA = "0x189AAA730")]
		[Conditional("CHECK_STATE")]
		private void TXPUMDUEFZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6A70", Offset = "0x9AA5470", VA = "0x189AA6A70")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float scalabilityErrorControl)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4E30", Offset = "0x9AA3830", VA = "0x189AA4E30")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9AA9330", Offset = "0x9AA7D30", VA = "0x189AA9330")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5900", Offset = "0x9AA4300", VA = "0x189AA5900")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7760", Offset = "0x9AA6160", VA = "0x189AA7760")]
		public void RebatchOptimally(int batchSizeNaughty, int batchSizeNice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7680", Offset = "0x9AA6080", VA = "0x189AA7680")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x9AAAD50", Offset = "0x9AA9750", VA = "0x189AAAD50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1DA98A0", Offset = "0x1DA82A0", VA = "0x181DA98A0")]
			public void UPOEXJDPLHW()
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
		private sealed class WZONCZLIYRE : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			private bool RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			private long CBQHLXSURLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public long MKASFOMNINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private bool KQXXNJMBVYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public bool BFRUEHDFIPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			private int SYPSIWPCUGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			private int QKCDQNHQVJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			private int FHBOXFNAGVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			private int KTIDDFHGUBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private List<BatchedMeshRenderer>.Enumerator ISAOQXGSLPY;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool OAUQQSGBVCY
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0x137EFD0", Offset = "0x137D9D0", VA = "0x18137EFD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x8D82680", Offset = "0x8D81080", VA = "0x188D82680", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x15E64E0", Offset = "0x15E4EE0", VA = "0x1815E64E0")]
			[DebuggerHidden]
			public WZONCZLIYRE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x9AB3D80", Offset = "0x9AB2780", VA = "0x189AB3D80", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x9AB3EE0", Offset = "0x9AB28E0", VA = "0x189AB3EE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x9AB50D0", Offset = "0x9AB3AD0", VA = "0x189AB50D0")]
			private void XNJKRYGWMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9AB5120", Offset = "0x9AB3B20", VA = "0x189AB5120")]
			private void XNORPFATVNY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x9AB3EA0", Offset = "0x9AB28A0", VA = "0x189AB3EA0", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x9AB3CE0", Offset = "0x9AB26E0", VA = "0x189AB3CE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> BOOZYDDTOCT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x9AB3CE0", Offset = "0x9AB26E0", VA = "0x189AB3CE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private static readonly ProfilerMarker TNKUHFKZKDN;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly ProfilerMarker ZJVLIHGSDSH;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly ProfilerMarker TQJBJOIYZVL;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly ProfilerMarker NSJZYVFAIIP;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static float3 DKJXJUQIZJE;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static int SFXZSDWGTDF;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static int IPEVYUPJNVC;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static int OYLZEVDVAVF;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static int SXXMVINLHBS;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static int SSDDEUYPTKM;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static float EVBLUHDVYKN;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static float EXTUFONMOJN;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static float YJROZCTFORZ;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static float HKORIJJPFKK;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static float CLDZCFZQQXJ;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static float HIJCSQZAXPA;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static float GRPXDSNDETY;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static float AWYNLUORYOB;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private static List<BatchedMeshRenderer> UMVSJSYEMMK;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private static Stack<NativeMesh> AQVSCIOSHPR;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private static Stack<IDMERDOGXHB> ZUVHYCSLUSA;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static ZLNHNDJSHXI YGIVYEAQLLT;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private static FindAndMarkAsFrozenCache XTFSXOFABYF;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static int CXFTVETLTDM;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void SLJETIWVYTO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void AYUSUVGBQYF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void SLJETIWVYTO(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x9AADD50", Offset = "0x9AAC750", VA = "0x189AADD50")]
		public static void SRPDLCJVRSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x9AAAEB0", Offset = "0x9AA98B0", VA = "0x189AAAEB0")]
		public static void APJJCSDMXXS(BatchedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x9AABEE0", Offset = "0x9AAA8E0", VA = "0x189AABEE0")]
		public static void HRSVNSTQJWZ(BatchedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9AAB2E0", Offset = "0x9AA9CE0", VA = "0x189AAB2E0")]
		public static void FUIOPPPDJGR(MINJGALAJOY a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9AAD9C0", Offset = "0x9AAC3C0", VA = "0x189AAD9C0")]
		public static void RLBZPJEIODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x9AAC420", Offset = "0x9AAAE20", VA = "0x189AAC420")]
		public static void OKJYCSYOTQR(float a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x9AABA40", Offset = "0x9AAA440", VA = "0x189AABA40")]
		private static void GZXEFYWLWRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x9AACC90", Offset = "0x9AAB690", VA = "0x189AACC90")]
		public static long PNIGEDZFUTI(int a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9AADDD0", Offset = "0x9AAC7D0", VA = "0x189AADDD0")]
		public static (long, long, int) TFPGJXEQWQS(float a)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x9AAC010", Offset = "0x9AAAA10", VA = "0x189AAC010")]
		[IteratorStateMachine(typeof(WZONCZLIYRE))]
		public static IEnumerable<bool> JEFXSJBJCCJ(long a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9AAC1C0", Offset = "0x9AAABC0", VA = "0x189AAC1C0")]
		public static void MCAWLGIEGWR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9AAD750", Offset = "0x9AAC150", VA = "0x189AAD750")]
		public static void RIBARUFWOQL(long a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x9AAB160", Offset = "0x9AA9B60", VA = "0x189AAB160")]
		public static int DIJGBSGHNGR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9AAAFF0", Offset = "0x9AA99F0", VA = "0x189AAAFF0")]
		internal static NativeMesh CATWWTOULRR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x9AAC120", Offset = "0x9AAAB20", VA = "0x189AAC120")]
		internal static void LKTMVJNBSHE(NativeMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9AAE1C0", Offset = "0x9AACBC0", VA = "0x189AAE1C0")]
		internal static IDMERDOGXHB XLOWXJWHUCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9AAC090", Offset = "0x9AAAA90", VA = "0x189AAC090")]
		internal static void LKTMVJNBSHE(IDMERDOGXHB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9AADFE0", Offset = "0x9AAC9E0", VA = "0x189AADFE0")]
		public static void THBOBQEHMEV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class LXOEYMKBHWP<a> : BatchedMesh
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private readonly Dictionary<a, MINJGALAJOY> GQZLBGKUTLX;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x68F7ED0", Offset = "0x68F68D0", VA = "0x1868F7ED0")]
		public LXOEYMKBHWP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x68F7720", Offset = "0x68F6120", VA = "0x1868F7720")]
		public void EXNGROUQKPW(a a, MINJGALAJOY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x68F7AD0", Offset = "0x68F64D0", VA = "0x1868F7AD0")]
		public bool LCSHAKSPEOX(a a, MINJGALAJOY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x68F7880", Offset = "0x68F6280", VA = "0x1868F7880")]
		public void HSIRKPNDPRM(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x68F7D70", Offset = "0x68F6770", VA = "0x1868F7D70", Slot = "4")]
		public override void VJPSWFJMWWN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public static class QSJJZSWRJHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly ProfilerCategory NBPYZCTQXDX;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		internal static readonly ProfilerMarker TCOQMFJPKBM;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		internal static readonly RuntimeMarker OKJYCSYOTQR;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static readonly RuntimeCounterValue<float> OFJQRJBBFTO;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static readonly RuntimeCounterValue<float> NOOBPNWGXRV;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly RuntimeCounterValue<float> MWUHVZKUBYW;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private static readonly RuntimeCounterValue<double> WGLJJVKDWHG;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private static readonly RuntimeCounterValue<double> DJZEUTKYDDS;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private static readonly RuntimeCounterValue<double> EYYWFXNAOTD;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private static readonly RuntimeCounterValue<double> JWSIMIWFDJT;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private static readonly RuntimeCounterValue<int> HSDHMCVICFN;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private static readonly RuntimeCounterValue<int> PIKYVGLMOZX;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private static readonly RuntimeCounterValue<int> SZIJWCTMOZR;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private static readonly RuntimeCounterValue<int> XJHSVMIMQFK;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private static readonly RuntimeCounterValue<int> KGVAGKLYNZF;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private static readonly RuntimeCounterValue<int> ZBQSAHWNNTZ;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private static readonly RuntimeCounterValue<int> ZONNIDYHMPG;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private static readonly RuntimeCounterValue<int> GXHPOFKRFCX;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private static readonly RuntimeCounterValue<long> VIRBOMBNXWL;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static readonly RuntimeCounterValue<long> PKXHUMGPGAC;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private static readonly RuntimeCounterValue<long> BNDHIMMVLFN;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private static readonly RuntimeCounterValue<long> GXTOBFXKQJT;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private static readonly RuntimeCounterValue<long> SUSAWEUTOGL;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private static readonly RuntimeCounterValue<long> IDAJAYHKZCS;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x9AAF3B0", Offset = "0x9AADDB0", VA = "0x189AAF3B0")]
		public static void VJKFRKPMZGK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__4117313021
{
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x9AB5180", Offset = "0x9AB3B80", VA = "0x189AB5180")]
	public static void WMDBIFXPSXO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x9AB5170", Offset = "0x9AB3B70", VA = "0x189AB5170")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x9AB3B80", Offset = "0x9AB2580", VA = "0x189AB3B80")]
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
