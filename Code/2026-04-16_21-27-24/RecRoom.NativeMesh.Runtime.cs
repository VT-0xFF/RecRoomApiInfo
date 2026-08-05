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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98E2830", Offset = "0x98E1630", VA = "0x1898E2830", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal static class TWTHCKJRHRG
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly Log JXMSTRRNVDI;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly Log ZBIFDUEREMD;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly Log REWVETPFOLV;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly Log ZCDDDCREALE;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly Log IZBCPKEBMZZ;
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
		public CompressedNativeMeshStruct ACZXTAXMEIO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int PRHDDAJFSES
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCE5110", Offset = "0xCE3F10", VA = "0x180CE5110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
		internal static class MYBNNQEXGLP
		{
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x98E3A90", Offset = "0x98E2890", VA = "0x1898E3A90")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x98E36C0", Offset = "0x98E24C0", VA = "0x1898E36C0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x98E3840", Offset = "0x98E2640", VA = "0x1898E3840")]
			public unsafe static void Invoke([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int vertexCount, [In] float3 vertMin, [In] float3 vertScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllVerts_0000003D$PostfixBurstDelegate([NoAlias] ushort* dstVerts, [Out] float3 vertMinimum, [Out] float3 vertScale, [In][NoAlias] float3* srcVerts, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal static class YERQXNRIFLZ
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x98EEF40", Offset = "0x98EDD40", VA = "0x1898EEF40")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x98EEB50", Offset = "0x98ED950", VA = "0x1898EEB50")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x98EECD0", Offset = "0x98EDAD0", VA = "0x1898EECD0")]
			public unsafe static void Invoke([NoAlias] ushort* dstVerts, [Out] float3 vertMinimum, [Out] float3 vertScale, [In][NoAlias] float3* srcVerts, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllNormals_0000003F$PostfixBurstDelegate([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class YQCNKYDROAF
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x98EF4C0", Offset = "0x98EE2C0", VA = "0x1898EF4C0")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x98EF0D0", Offset = "0x98EDED0", VA = "0x1898EF0D0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x98EF250", Offset = "0x98EE050", VA = "0x1898EF250")]
			public unsafe static void Invoke([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void GetAllNormals_00000041$PostfixBurstDelegate([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		internal static class HNXSUZQRDBV
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x98DF670", Offset = "0x98DE470", VA = "0x1898DF670")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x98DF270", Offset = "0x98DE070", VA = "0x1898DF270")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x98DF3F0", Offset = "0x98DE1F0", VA = "0x1898DF3F0")]
			public unsafe static void Invoke([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllUVs_00000048$PostfixBurstDelegate([NoAlias] uint* dstUVs, [Out] float2 uvMinimum, [Out] float2 uvScale, [In][NoAlias] float2* srcUVs, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		internal static class MIBMAFIZVPS
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x98E2F50", Offset = "0x98E1D50", VA = "0x1898E2F50")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x98E2B60", Offset = "0x98E1960", VA = "0x1898E2B60")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x98E2CE0", Offset = "0x98E1AE0", VA = "0x1898E2CE0")]
			public unsafe static void Invoke([NoAlias] uint* dstUVs, [Out] float2 uvMinimum, [Out] float2 uvScale, [In][NoAlias] float2* srcUVs, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void GetUV_00000049$PostfixBurstDelegate([Out] float2 ret, uint compressed, [In] float2 uvMin, [In] float2 uvScale);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class ERUPUHMVHBH
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x98D92B0", Offset = "0x98D80B0", VA = "0x1898D92B0")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x98D8EC0", Offset = "0x98D7CC0", VA = "0x1898D8EC0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x98D9040", Offset = "0x98D7E40", VA = "0x1898D9040")]
			public static void Invoke([Out] float2 ret, uint compressed, [In] float2 uvMin, [In] float2 uvScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void GetAllUVs_0000004B$PostfixBurstDelegate([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int vertexCount, [In] float2 uvMin, [In] float2 uvScale);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		internal static class BFUEFZCDGJM
		{
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x98CEB00", Offset = "0x98CD900", VA = "0x1898CEB00")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x98CE6C0", Offset = "0x98CD4C0", VA = "0x1898CE6C0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x98CE840", Offset = "0x98CD640", VA = "0x1898CE840")]
			public unsafe static void Invoke([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int vertexCount, [In] float2 uvMin, [In] float2 uvScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllTangents_00000052$PostfixBurstDelegate([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal static class ARWPDAGVYMJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x98CDD30", Offset = "0x98CCB30", VA = "0x1898CDD30")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x98CD940", Offset = "0x98CC740", VA = "0x1898CD940")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x98CDAC0", Offset = "0x98CC8C0", VA = "0x1898CDAC0")]
			public unsafe static void Invoke([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate ushort SetTangent_00000053$PostfixBurstDelegate([In] float4 newVal);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		internal static class UPWOSJXGRPY
		{
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x98ECE90", Offset = "0x98EBC90", VA = "0x1898ECE90")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x98ECA90", Offset = "0x98EB890", VA = "0x1898ECA90")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x98ECC10", Offset = "0x98EBA10", VA = "0x1898ECC10")]
			public static ushort Invoke([In] float4 newVal)
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void GetAllTangents_00000055$PostfixBurstDelegate([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class NMRJGEDQBTG
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x98E4020", Offset = "0x98E2E20", VA = "0x1898E4020")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x98E3C20", Offset = "0x98E2A20", VA = "0x1898E3C20")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x98E3DA0", Offset = "0x98E2BA0", VA = "0x1898E3DA0")]
			public unsafe static void Invoke([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void GetTangent_0000005B$PostfixBurstDelegate([Out] float4 result, ushort compressed);

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		internal static class WZQVCQRHRBT
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x98EE9C0", Offset = "0x98ED7C0", VA = "0x1898EE9C0")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x98EE590", Offset = "0x98ED390", VA = "0x1898EE590")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x98EE710", Offset = "0x98ED510", VA = "0x1898EE710")]
			public static void Invoke([Out] float4 result, ushort compressed)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void CreateAllMaterialIndices_0000005D$PostfixBurstDelegate([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int numData, [Out] int numRLEs, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		internal static class FVJSKRNJHHD
		{
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x98DD820", Offset = "0x98DC620", VA = "0x1898DD820")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x98DD400", Offset = "0x98DC200", VA = "0x1898DD400")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x98DD580", Offset = "0x98DC380", VA = "0x1898DD580")]
			public unsafe static void Invoke([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int numData, [Out] int numRLEs, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void DecodeMaterialIndices_0000005F$PostfixBurstDelegate([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		internal static class VGIIKTONZUM
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x98ED9D0", Offset = "0x98EC7D0", VA = "0x1898ED9D0")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x98ED540", Offset = "0x98EC340", VA = "0x1898ED540")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x98ED6C0", Offset = "0x98EC4C0", VA = "0x1898ED6C0")]
			public unsafe static void Invoke([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate int EncodeIndices_00000067$PostfixBurstDelegate([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int srcIndexCount);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		internal static class IWCVEQKUIWZ
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x98E0360", Offset = "0x98DF160", VA = "0x1898E0360")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x98DFF20", Offset = "0x98DED20", VA = "0x1898DFF20")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x98E00A0", Offset = "0x98DEEA0", VA = "0x1898E00A0")]
			public unsafe static int Invoke([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int srcIndexCount)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void DecodeIndices_00000069$PostfixBurstDelegate([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int indexCount);

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		internal static class GMZLNHHMTAX
		{
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x98DE440", Offset = "0x98DD240", VA = "0x1898DE440")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x98DE040", Offset = "0x98DCE40", VA = "0x1898DE040")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x98DE1C0", Offset = "0x98DCFC0", VA = "0x1898DE1C0")]
			public unsafe static void Invoke([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int indexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void DecodeNormal_0000006B$PostfixBurstDelegate([Out] float3 ret, ushort compressed);

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		internal static class FWGWBYFGEZA
		{
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x98DDD50", Offset = "0x98DCB50", VA = "0x1898DDD50")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x98DD9B0", Offset = "0x98DC7B0", VA = "0x1898DD9B0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x98DDB30", Offset = "0x98DC930", VA = "0x1898DDB30")]
			public static void Invoke([Out] float3 ret, ushort compressed)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate ushort EncodeNormal_0000006C$PostfixBurstDelegate([In] float3 newVal);

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		internal static class BXAUUORRLIZ
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x98CF020", Offset = "0x98CDE20", VA = "0x1898CF020")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x98CEC90", Offset = "0x98CDA90", VA = "0x1898CEC90")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x98CEE10", Offset = "0x98CDC10", VA = "0x1898CEE10")]
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
		public bool VLZKORUYSFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x98D1AB0", Offset = "0x98D08B0", VA = "0x1898D1AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KJVYGINEXQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x98CF2C0", Offset = "0x98CE0C0", VA = "0x1898CF2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x98D0040", Offset = "0x98CEE40", VA = "0x1898D0040")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x98CF8D0", Offset = "0x98CE6D0", VA = "0x1898CF8D0")]
		public static CompressedNativeMeshStruct Create(Allocator allocator, NativeMesh srcMesh)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x98CF300", Offset = "0x98CE100", VA = "0x1898CF300")]
		public static CompressedNativeMeshStruct Create(Allocator allocator, NativeArray<float3> srcVerts, NativeArray<float3> srcNormals, NativeArray<float2> srcUVs, NativeArray<float4> srcMaterialIndices, bool hasTangents, NativeArray<float4> srcTangents, NativeArray<int> srcIndices, int vertexCount, int firstVertex, int indexCount, int firstIndex)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x98D1660", Offset = "0x98D0460", VA = "0x1898D1660")]
		public void VFLHLVKDMKL(NativeMesh a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x98D14B0", Offset = "0x98D02B0", VA = "0x1898D14B0")]
		public long UIJVQZMXZZN()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x98CF1B0", Offset = "0x98CDFB0", VA = "0x1898CF1B0")]
		public long ABCOLNHPCZW(NativeMesh.UnityMeshFormat a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x98D0BB0", Offset = "0x98CF9B0", VA = "0x1898D0BB0")]
		private void LYOIWODOTAU(int a, int b, Allocator c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x98D0370", Offset = "0x98CF170", VA = "0x1898D0370")]
		private void GEMMPNTTKHQ(NativeArray<float3> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x98D0460", Offset = "0x98CF260", VA = "0x1898D0460")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllVerts_00000036$PostfixBurstDelegate))]
		private unsafe static void GEMMPNTTKHQ([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int a, [In] float3 vertMin, [In] float3 vertScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x98D0180", Offset = "0x98CEF80", VA = "0x1898D0180")]
		private void FCSHCXXPFTY(NativeArray<float3> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x98D0170", Offset = "0x98CEF70", VA = "0x1898D0170")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllVerts_0000003D$PostfixBurstDelegate))]
		private unsafe static void FCSHCXXPFTY([NoAlias] ushort* dstVerts, [Out] float3 a, [Out] float3 b, [In][NoAlias] float3* srcVerts, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x98D08F0", Offset = "0x98CF6F0", VA = "0x1898D08F0")]
		private void LJINWMEYFRA(NativeArray<float3> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x98D09D0", Offset = "0x98CF7D0", VA = "0x1898D09D0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllNormals_0000003F$PostfixBurstDelegate))]
		private unsafe static void LJINWMEYFRA([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x98D0FA0", Offset = "0x98CFDA0", VA = "0x1898D0FA0")]
		private void NYUZIPAIZZM(NativeArray<float3> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x98D1060", Offset = "0x98CFE60", VA = "0x1898D1060")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllNormals_00000041$PostfixBurstDelegate))]
		private unsafe static void NYUZIPAIZZM([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x98D07C0", Offset = "0x98CF5C0", VA = "0x1898D07C0")]
		private void HYKEQFLSOXY(NativeArray<float2> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x98D07B0", Offset = "0x98CF5B0", VA = "0x1898D07B0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllUVs_00000048$PostfixBurstDelegate))]
		private unsafe static void HYKEQFLSOXY([NoAlias] uint* dstUVs, [Out] float2 a, [Out] float2 b, [In][NoAlias] float2* srcUVs, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x98D19A0", Offset = "0x98D07A0", VA = "0x1898D19A0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetUV_00000049$PostfixBurstDelegate))]
		private static void XABTSUYWCZS([Out] float2 a, uint b, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x98D1080", Offset = "0x98CFE80", VA = "0x1898D1080")]
		private void OTUVDWRFVDI(NativeArray<float2> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x98D1070", Offset = "0x98CFE70", VA = "0x1898D1070")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllUVs_0000004B$PostfixBurstDelegate))]
		private unsafe static void OTUVDWRFVDI([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int a, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98D0280", Offset = "0x98CF080", VA = "0x1898D0280")]
		private void FTDEYFTNRMU(NativeArray<float4> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x98D0360", Offset = "0x98CF160", VA = "0x1898D0360")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllTangents_00000052$PostfixBurstDelegate))]
		private unsafe static void FTDEYFTNRMU([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x98D1240", Offset = "0x98D0040", VA = "0x1898D1240")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetTangent_00000053$PostfixBurstDelegate))]
		private static ushort RXSDCIJOBUI([In] float4 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98D0650", Offset = "0x98CF450", VA = "0x1898D0650")]
		private void HKWHWDGZVEI(NativeArray<float4> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98D0640", Offset = "0x98CF440", VA = "0x1898D0640")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllTangents_00000055$PostfixBurstDelegate))]
		private unsafe static void HKWHWDGZVEI([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x98D1230", Offset = "0x98D0030", VA = "0x1898D1230")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetTangent_0000005B$PostfixBurstDelegate))]
		private static void RQJEXLDNUSM([Out] float4 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98CFBB0", Offset = "0x98CE9B0", VA = "0x1898CFBB0")]
		private void DNGXUFFXAJU(Allocator a, NativeArray<float4> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x98D0030", Offset = "0x98CEE30", VA = "0x1898D0030")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.CreateAllMaterialIndices_0000005D$PostfixBurstDelegate))]
		private unsafe static void DNGXUFFXAJU([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int a, [Out] int b, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x98D13B0", Offset = "0x98D01B0", VA = "0x1898D13B0")]
		private static void UEAXNKKIEQX(NativeArray<float4> a, NativeArray<MaterialIndex> b, NativeArray<byte> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x98D13A0", Offset = "0x98D01A0", VA = "0x1898D13A0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeMaterialIndices_0000005F$PostfixBurstDelegate))]
		private unsafe static void UEAXNKKIEQX([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x98D09E0", Offset = "0x98CF7E0", VA = "0x1898D09E0")]
		private void LMSYOAWHUCB(Allocator a, NativeArray<int> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x98D0CE0", Offset = "0x98CFAE0", VA = "0x1898D0CE0")]
		private static NativeArray<byte> NOTFFNSSPAE(Allocator a, NativeArray<int> b, int c)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x98D0F90", Offset = "0x98CFD90", VA = "0x1898D0F90")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.EncodeIndices_00000067$PostfixBurstDelegate))]
		private unsafe static int NOTFFNSSPAE([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x98D0AE0", Offset = "0x98CF8E0", VA = "0x1898D0AE0")]
		private static void LVQGDQJPKFG(NativeArray<int> a, NativeArray<byte> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x98D0BA0", Offset = "0x98CF9A0", VA = "0x1898D0BA0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeIndices_00000069$PostfixBurstDelegate))]
		private unsafe static void LVQGDQJPKFG([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x98D0160", Offset = "0x98CEF60", VA = "0x1898D0160")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeNormal_0000006B$PostfixBurstDelegate))]
		private static void ECDEOYBWPMQ([Out] float3 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x98D0270", Offset = "0x98CF070", VA = "0x1898D0270")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.EncodeNormal_0000006C$PostfixBurstDelegate))]
		private static ushort FPYCSAUEUVK([In] float3 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x98CC460", Offset = "0x98CB260", VA = "0x1898CC460")]
		[BurstCompile]
		internal unsafe static void ONXYUUQVMYV([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int a, [In] float3 vertMin, [In] float3 vertScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98CC800", Offset = "0x98CB600", VA = "0x1898CC800")]
		[BurstCompile]
		internal unsafe static void QEDWNTVEHQV([NoAlias] ushort* dstVerts, [Out] float3 a, [Out] float3 b, [In][NoAlias] float3* srcVerts, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98D0710", Offset = "0x98CF510", VA = "0x1898D0710")]
		[BurstCompile]
		internal unsafe static void HTBDFUAYXXT([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x98D1250", Offset = "0x98D0050", VA = "0x1898D1250")]
		[BurstCompile]
		internal unsafe static void SOXTIJIAZFD([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x98CCC30", Offset = "0x98CBA30", VA = "0x1898CCC30")]
		[BurstCompile]
		internal unsafe static void YFPHCAHSVVX([NoAlias] uint* dstUVs, [Out] float2 a, [Out] float2 b, [In][NoAlias] float2* srcUVs, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98D08B0", Offset = "0x98CF6B0", VA = "0x1898D08B0")]
		[BurstCompile]
		internal static void JQXGJNXULCD([Out] float2 a, uint b, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x98D1AF0", Offset = "0x98D08F0", VA = "0x1898D1AF0")]
		[BurstCompile]
		internal unsafe static void YYNJUNEKOZP([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int a, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x98CF220", Offset = "0x98CE020", VA = "0x1898CF220")]
		[BurstCompile]
		internal unsafe static void AOEAZCGZQTJ([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x98D0470", Offset = "0x98CF270", VA = "0x1898D0470")]
		[BurstCompile]
		internal static ushort GLBHSHORWRZ([In] float4 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x98D15B0", Offset = "0x98D03B0", VA = "0x1898D15B0")]
		[BurstCompile]
		internal unsafe static void UOMYDUFLXXB([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x98D1170", Offset = "0x98CFF70", VA = "0x1898D1170")]
		[BurstCompile]
		internal static void RDXCPHJYVPV([Out] float4 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x98CBF30", Offset = "0x98CAD30", VA = "0x1898CBF30")]
		[BurstCompile]
		internal unsafe static void HPZAAWMOIKZ([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int a, [Out] int b, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x98D0500", Offset = "0x98CF300", VA = "0x1898D0500")]
		[BurstCompile]
		internal unsafe static void GMGVRHYSUGC([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x98D19B0", Offset = "0x98D07B0", VA = "0x1898D19B0")]
		[BurstCompile]
		internal unsafe static int YTPNSAKLHOX([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x98D1300", Offset = "0x98D0100", VA = "0x1898D1300")]
		[BurstCompile]
		internal unsafe static void SQLNNHMOCFV([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x98CC6C0", Offset = "0x98CB4C0", VA = "0x1898CC6C0")]
		[BurstCompile]
		internal static void PBHWAWHWMDF([Out] float3 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x98CCF10", Offset = "0x98CBD10", VA = "0x1898CCF10")]
		[BurstCompile]
		internal static ushort ZLLHSBMEODF([In] float3 newVal)
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
		internal static class BEDPKKEZJTW
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x98CE530", Offset = "0x98CD330", VA = "0x1898CE530")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x98CDEC0", Offset = "0x98CCCC0", VA = "0x1898CDEC0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x98CE040", Offset = "0x98CCE40", VA = "0x1898CE040")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate int FloatToSnorm8_00000083$PostfixBurstDelegate(float x);

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		internal static class TROGNXLADXC
		{
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x98EC6C0", Offset = "0x98EB4C0", VA = "0x1898EC6C0")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x98EC2C0", Offset = "0x98EB0C0", VA = "0x1898EC2C0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x98EC430", Offset = "0x98EB230", VA = "0x1898EC430")]
			public static int Invoke(float x)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate uint FloatToSnorm8_00000084$PostfixBurstDelegate([In] float4 v);

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		internal static class GWUVSDIEQNH
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x98DE9E0", Offset = "0x98DD7E0", VA = "0x1898DE9E0")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x98DE5D0", Offset = "0x98DD3D0", VA = "0x1898DE5D0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x98DE750", Offset = "0x98DD550", VA = "0x1898DE750")]
			public static uint Invoke([In] float4 v)
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate uint FloatToSnorm8_00000085$PostfixBurstDelegate([In] float3 v);

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		internal static class HHRGAWMEPTE
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x98DF0E0", Offset = "0x98DDEE0", VA = "0x1898DF0E0")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x98DECF0", Offset = "0x98DDAF0", VA = "0x1898DECF0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x98DEE70", Offset = "0x98DDC70", VA = "0x1898DEE70")]
			public static uint Invoke([In] float3 v)
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_NormTanSn8MatF16_00000087$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		internal static class TOZRISAAUSA
		{
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x98EC130", Offset = "0x98EAF30", VA = "0x1898EC130")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x98EBBB0", Offset = "0x98EA9B0", VA = "0x1898EBBB0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x98EBD30", Offset = "0x98EAB30", VA = "0x1898EBD30")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_NormTanSn8UvMatF16_00000089$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		internal static class DEXBLKHXCDV
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x98D8650", Offset = "0x98D7450", VA = "0x1898D8650")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x98D80F0", Offset = "0x98D6EF0", VA = "0x1898D80F0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x98D8270", Offset = "0x98D7070", VA = "0x1898D8270")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_NormTanOct8MatUi_0000008C$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		internal static class HPFCLSPBXLY
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x98DFD90", Offset = "0x98DEB90", VA = "0x1898DFD90")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x98DF800", Offset = "0x98DE600", VA = "0x1898DF800")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x98DF980", Offset = "0x98DE780", VA = "0x1898DF980")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_PosFixedPoint16NormTanOct8MatUi_0000008E$PostfixBurstDelegate([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 positionMin, [Out] float3 positionMax);

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		internal static class MNAKBGSOQZB
		{
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x98E3530", Offset = "0x98E2330", VA = "0x1898E3530")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x98E30E0", Offset = "0x98E1EE0", VA = "0x1898E30E0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x98E3260", Offset = "0x98E2060", VA = "0x1898E3260")]
			public unsafe static void Invoke([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 positionMin, [Out] float3 positionMax)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_FastCopyIndices_00000090$PostfixBurstDelegate(int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class QBQYPTHCIAR
		{
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x98EB6B0", Offset = "0x98EA4B0", VA = "0x1898EB6B0")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x98EB320", Offset = "0x98EA120", VA = "0x1898EB320")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x98EB490", Offset = "0x98EA290", VA = "0x1898EB490")]
			public unsafe static void Invoke(int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_FastCopyIndices_00000091$PostfixBurstDelegate(int startIndex, int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class UUDHORZNDIS
		{
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x98ED3C0", Offset = "0x98EC1C0", VA = "0x1898ED3C0")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x98ED020", Offset = "0x98EBE20", VA = "0x1898ED020")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x98ED190", Offset = "0x98EBF90", VA = "0x1898ED190")]
			public unsafe static void Invoke(int startIndex, int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void FastAppendIndices_00000093$PostfixBurstDelegate(int destStart, int sourceCount, int indexOffset, [In][NoAlias] int* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		internal static class NNEDDDMZKFQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x98E4560", Offset = "0x98E3360", VA = "0x1898E4560")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x98E41B0", Offset = "0x98E2FB0", VA = "0x1898E41B0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x98E4320", Offset = "0x98E3120", VA = "0x1898E4320")]
			public unsafe static void Invoke(int destStart, int sourceCount, int indexOffset, [In][NoAlias] int* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void FindBestUnityMeshFormat_Fast_0000009D$PostfixBurstDelegate(int vertexCount, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		internal static class DSWDJOWBUAV
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x98D8BC0", Offset = "0x98D79C0", VA = "0x1898D8BC0")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x98D87E0", Offset = "0x98D75E0", VA = "0x1898D87E0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x98D8950", Offset = "0x98D7750", VA = "0x1898D8950")]
			public unsafe static void Invoke(int vertexCount, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const int KFVWTNKHBFW = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public NativeList<float3> VALVQQTZVOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NativeArray<float3> BMXFSTVLRAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NativeArray<float4> QSTQFKRENYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NativeArray<float4> NDSVZPXIQNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public NativeArray<float2> JWXVQGHFPUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public NativeList<int> VHWAFBZSPMC;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly VertexAttributeDescriptor[][] OTNJYMDVGTY;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static bool PSBALYYGVEN;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static UnityMeshFormatInfo[] RAXPULKKNCU;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static VertexAttributeDescriptor[] JZZVMDWQBNP;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool VLZKORUYSFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x98EA770", Offset = "0x98E9570", VA = "0x1898EA770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int RKAGDTTMNQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x98E5000", Offset = "0x98E3E00", VA = "0x1898E5000")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int HFUCHGQBDSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x98E5770", Offset = "0x98E4570", VA = "0x1898E5770")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool KJVYGINEXQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x98E48A0", Offset = "0x98E36A0", VA = "0x1898E48A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x98E57C0", Offset = "0x98E45C0", VA = "0x1898E57C0")]
		public static VertexFormatKeyword FWXRBMACKUB(UnityMeshFormat a)
		{
			return default(VertexFormatKeyword);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x98E52D0", Offset = "0x98E40D0", VA = "0x1898E52D0")]
		public static void DCFGNGNJLAJ(VertexFormatKeyword a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x98E5670", Offset = "0x98E4470", VA = "0x1898E5670", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x98E6FC0", Offset = "0x98E5DC0", VA = "0x1898E6FC0")]
		public void LYOIWODOTAU(int a, int b, Allocator c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x98E5250", Offset = "0x98E4050", VA = "0x1898E5250")]
		public void CWQFJXMWFDV(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x98E9A30", Offset = "0x98E8830", VA = "0x1898E9A30", Slot = "6")]
		public bool UUCMTKHGOFJ(Mesh a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x98EA260", Offset = "0x98E9060", VA = "0x1898EA260")]
		public bool WHEWUBPOMCI(Mesh a, bool b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x98E9500", Offset = "0x98E8300", VA = "0x1898E9500")]
		public bool UUASDNNMTOQ(Mesh a, NativeMesh b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x98E6370", Offset = "0x98E5170", VA = "0x1898E6370")]
		public bool IKNQFQHFJMH(Mesh a, NativeMesh b, UnityMeshFormat c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x98E5BB0", Offset = "0x98E49B0", VA = "0x1898E5BB0")]
		private void HQFLFZPNYVS(Mesh a, NativeMesh b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x98E5860", Offset = "0x98E4660", VA = "0x1898E5860")]
		public void HQFLFZPNYVS(NativeArray<ushort> a, NativeArray<VertexFormat_NormTanOct8MatUi> b, Mesh c, NativeMesh d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x98E71B0", Offset = "0x98E5FB0", VA = "0x1898E71B0")]
		public void LYQRAVBEOAC(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x98E48E0", Offset = "0x98E36E0", VA = "0x1898E48E0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanMatF16_00000082$PostfixBurstDelegate))]
		private unsafe static void BNNUOJGPHJW([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x98E4880", Offset = "0x98E3680", VA = "0x1898E4880")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000083$PostfixBurstDelegate))]
		public static int ANIKAMPIAJP(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x98E4870", Offset = "0x98E3670", VA = "0x1898E4870")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000084$PostfixBurstDelegate))]
		public static uint ANIKAMPIAJP([In] float4 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x98E4860", Offset = "0x98E3660", VA = "0x1898E4860")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000085$PostfixBurstDelegate))]
		public static uint ANIKAMPIAJP([In] float3 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x98E48F0", Offset = "0x98E36F0", VA = "0x1898E48F0")]
		public void BTDHXQMSXRJ(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x98E5240", Offset = "0x98E4040", VA = "0x1898E5240")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanSn8MatF16_00000087$PostfixBurstDelegate))]
		private unsafe static void CQBZZZBPUBL([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x98E8C60", Offset = "0x98E7A60", VA = "0x1898E8C60")]
		public void UHQJRTCKXZW(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x98E4890", Offset = "0x98E3690", VA = "0x1898E4890")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanSn8UvMatF16_00000089$PostfixBurstDelegate))]
		private unsafe static void AQQEYTRSEYW([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x98EABD0", Offset = "0x98E99D0", VA = "0x1898EABD0")]
		public void ZLVIXIOTDIZ(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x98EA7B0", Offset = "0x98E95B0", VA = "0x1898EA7B0")]
		public void ZLVIXIOTDIZ(NativeArray<ushort> a, NativeArray<VertexFormat_NormTanOct8MatUi> b, Mesh c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x98E6F50", Offset = "0x98E5D50", VA = "0x1898E6F50")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanOct8MatUi_0000008C$PostfixBurstDelegate))]
		public unsafe static void LKAIFDDJAOH([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x98E9A50", Offset = "0x98E8850", VA = "0x1898E9A50")]
		public void UZPKPUXTIWE(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x98E6A10", Offset = "0x98E5810", VA = "0x1898E6A10")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_PosFixedPoint16NormTanOct8MatUi_0000008E$PostfixBurstDelegate))]
		private unsafe static void LITSSPOZORI([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 b, [Out] float3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x98E78C0", Offset = "0x98E66C0", VA = "0x1898E78C0")]
		public void NFSJEERYTTC(Mesh a, UnityMeshFormat b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x98E7970", Offset = "0x98E6770", VA = "0x1898E7970")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_FastCopyIndices_00000090$PostfixBurstDelegate))]
		private unsafe static void NHSJSQXMMNA(int a, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x98E7960", Offset = "0x98E6760", VA = "0x1898E7960")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_FastCopyIndices_00000091$PostfixBurstDelegate))]
		private unsafe static void NHSJSQXMMNA(int a, int b, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x98E7D60", Offset = "0x98E6B60", VA = "0x1898E7D60")]
		public void QNXJNWRYKZL(NativeMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x98E7950", Offset = "0x98E6750", VA = "0x1898E7950")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FastAppendIndices_00000093$PostfixBurstDelegate))]
		private unsafe static void NHOBCXGELCA(int a, int b, int c, [In][NoAlias] int* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x98E66F0", Offset = "0x98E54F0", VA = "0x1898E66F0")]
		public void KJJYOGWKIJW(NativeMesh a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x98E93D0", Offset = "0x98E81D0", VA = "0x1898E93D0")]
		public long UIJVQZMXZZN()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x98E9370", Offset = "0x98E8170", VA = "0x1898E9370")]
		public static long UIJVQZMXZZN(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x98E46E0", Offset = "0x98E34E0", VA = "0x1898E46E0")]
		public static long ABCOLNHPCZW(int a, int b, UnityMeshFormat c)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x98E4780", Offset = "0x98E3580", VA = "0x1898E4780")]
		public long ABCOLNHPCZW(UnityMeshFormat a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x98E7D00", Offset = "0x98E6B00", VA = "0x1898E7D00")]
		public void QGZLUYTEBWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x98E8670", Offset = "0x98E7470", VA = "0x1898E8670")]
		public static void TPMSRKBPNSC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x98E6A20", Offset = "0x98E5820", VA = "0x1898E6A20")]
		public UnityMeshFormat LJPXYOWUMZZ()
		{
			return default(UnityMeshFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x98E8660", Offset = "0x98E7460", VA = "0x1898E8660")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FindBestUnityMeshFormat_Fast_0000009D$PostfixBurstDelegate))]
		private unsafe static void TMFLTMSDQNY(int a, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x98E80C0", Offset = "0x98E6EC0", VA = "0x1898E80C0")]
		public static (int, int) RTMPEBPPYJZ(Mesh a)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x98EA690", Offset = "0x98E9490", VA = "0x1898EA690")]
		public static int WRRWRUYUZZK(Span<VertexAttributeDescriptor> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x98E8430", Offset = "0x98E7230", VA = "0x1898E8430")]
		public static long TBJWLRECLDD(Mesh a, int b, int c)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x98E84A0", Offset = "0x98E72A0", VA = "0x1898E84A0")]
		public static long TBJWLRECLDD(Mesh a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public NativeMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x98E53B0", Offset = "0x98E41B0", VA = "0x1898E53B0")]
		[BurstCompile]
		internal unsafe static void DZUCRVPBAHF([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x98E6580", Offset = "0x98E5380", VA = "0x1898E6580")]
		[BurstCompile]
		internal static int IZRKVEPHMSE(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x98E6630", Offset = "0x98E5430", VA = "0x1898E6630")]
		[BurstCompile]
		internal static uint IZRKVEPHMSE([In] float4 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x98E6500", Offset = "0x98E5300", VA = "0x1898E6500")]
		[BurstCompile]
		internal static uint IZRKVEPHMSE([In] float3 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x98E8220", Offset = "0x98E7020", VA = "0x1898E8220")]
		[BurstCompile]
		internal unsafe static void SFNFTLEWWOI([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x98E5050", Offset = "0x98E3E50", VA = "0x1898E5050")]
		[BurstCompile]
		internal unsafe static void CLZERBMFAGZ([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x98E6810", Offset = "0x98E5610", VA = "0x1898E6810")]
		[BurstCompile]
		internal unsafe static void KSCUKVBZPOK([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x98E7980", Offset = "0x98E6780", VA = "0x1898E7980")]
		[BurstCompile]
		internal unsafe static void QADKCUFNUPT([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 b, [Out] float3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x98E6F90", Offset = "0x98E5D90", VA = "0x1898E6F90")]
		[BurstCompile]
		internal unsafe static void LWPKRVTFCTD(int a, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x98E6F60", Offset = "0x98E5D60", VA = "0x1898E6F60")]
		[BurstCompile]
		internal unsafe static void LWPKRVTFCTD(int a, int b, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x98E5810", Offset = "0x98E4610", VA = "0x1898E5810")]
		[BurstCompile]
		internal unsafe static void HBAWDMRYREL(int a, int b, int c, [In][NoAlias] int* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x98CD0D0", Offset = "0x98CBED0", VA = "0x1898CD0D0")]
		[BurstCompile]
		internal unsafe static void DNRMHXIZLCZ(int a, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
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
	public class JOBQCDJAIKZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static IABYZCDZYMJ IABYZCDZYMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NativeList<PrimitiveShapeData> EHVOQMVSTIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NativeList<MeshPartInfo> PIVWEHOFIVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public NativeList<CurveShapeRootData> MITKWGKTYQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NativeArray<CurvePointData> OWEBLUIJRMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NativeList<MeshPartInfo> WNPDPTZHEIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NativeList<CurvePointOffset> PDVBUDBCACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private List<NativeArray<CurvePointData>> RNYXAYJGVSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private NativeList<OcclusionData> IFHIVMEBZXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeArray<int> BTXNQHAXHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private NativeArray<int> UFEWSKNZYPO;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private static NativeList<ShapeBatch.CollapseEntry> FANTBXDHBJS;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int RKAGDTTMNQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xD0D2B0", Offset = "0xD0C0B0", VA = "0x180D0D2B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x1614BD0", Offset = "0x16139D0", VA = "0x181614BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int HFUCHGQBDSO
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xD0D310", Offset = "0xD0C110", VA = "0x180D0D310")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x1614BA0", Offset = "0x16139A0", VA = "0x181614BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x98E2630", Offset = "0x98E1430", VA = "0x1898E2630")]
		public JOBQCDJAIKZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x98E04F0", Offset = "0x98DF2F0", VA = "0x1898E04F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x98E06C0", Offset = "0x98DF4C0", VA = "0x1898E06C0")]
		public void Dispose(JobHandle jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x98E23A0", Offset = "0x98E11A0", VA = "0x1898E23A0")]
		public void VMHZGZNZYQJ(PrimitiveShapeData a, OcclusionData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x98E0F50", Offset = "0x98DFD50", VA = "0x1898E0F50")]
		public void LBXUWQXQIPF(CurveShapeRootData a, NativeArray<CurvePointData> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x98E1080", Offset = "0x98DFE80", VA = "0x1898E1080")]
		public JobHandle TJDYRSPHKTK(NativeMesh a, UYWIKMRBVOY b, float3 c, quaternion d, float e, bool f, int g = 0, int h = 0)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x98E11A0", Offset = "0x98DFFA0", VA = "0x1898E11A0")]
		public JobHandle TJDYRSPHKTK(NativeMesh a, UYWIKMRBVOY b, NativeList<ShapeBatch.CollapseEntry> c, float3 d, quaternion e, float f, bool g, bool h, int i = 0, int j = 0)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x98E08A0", Offset = "0x98DF6A0", VA = "0x1898E08A0")]
		public static JobHandle EIDSAMURVPX(PrimitiveMeshGeneratorData a, NativeMesh b, NativeArray<int> c, PrimitiveShapeData d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x98E0C60", Offset = "0x98DFA60", VA = "0x1898E0C60")]
		public static JobHandle FJASBLQLTGT(CurveMeshGeneratorData a, NativeMesh b, CurveShapeRootData c, NativeArray<CurvePointData> d, int e, int f, JobHandle g)
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
			public FJFPDBGBICX.MinimalMeshData meshData;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x685EFC0", Offset = "0x685DDC0", VA = "0x18685EFC0")]
			public SingleMeshData(MeshRenderer renderer, FJFPDBGBICX.MinimalMeshData meshData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x98EBB30", Offset = "0x98EA930", VA = "0x1898EBB30")]
			public static implicit operator SingleMeshData((MeshRenderer, FJFPDBGBICX.MinimalMeshData) tuple)
			{
				return default(SingleMeshData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private static readonly ProfilerMarker HWLXEXCALSI;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly ProfilerMarker UFERZPPJDFO;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static readonly ProfilerMarker IVCMMYGGQIT;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly ProfilerMarker FAOXUWEIIOX;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x98D3950", Offset = "0x98D2750", VA = "0x1898D3950")]
		internal void UPJGKFHYRQZ(GameObject a, FJFPDBGBICX.CrowdAABB b, List<SingleMeshData> c, Material d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x98D4F60", Offset = "0x98D3D60", VA = "0x1898D4F60")]
		internal void ZZALLJXWSTH(GameObject a, FJFPDBGBICX.CrowdAABB b, List<SingleMeshData> c, List<LODGroup> d, Material e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x98D2C00", Offset = "0x98D1A00", VA = "0x1898D2C00")]
		private MeshRenderer MPXSYYQMUPM(FJFPDBGBICX.CrowdAABB a, Material b, List<SingleMeshData> c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x98D1D80", Offset = "0x98D0B80", VA = "0x1898D1D80")]
		private List<(List<SingleMeshData>, float)> MMYEFSGEITU(FJFPDBGBICX.CrowdAABB a, List<LODGroup> b, Material c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x98D41A0", Offset = "0x98D2FA0", VA = "0x1898D41A0")]
		private List<List<(List<SingleMeshData>, float)>> VFJTHUOZROD(FJFPDBGBICX.CrowdAABB a, List<LODGroup> b, Material c, [Out] int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public CrowdBatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x98D37E0", Offset = "0x98D25E0", VA = "0x1898D37E0")]
		[CompilerGenerated]
		internal static (float, int) NHFDLCHZMNG(List<List<(List<SingleMeshData> meshList, float lodTransition)>> gathered, int[] a)
		{
			return default((float, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class CrowdOptimizer
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly ProfilerMarker AUZRKYDKATD;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly ProfilerMarker HBGNOBBOBQY;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly ProfilerMarker GKPHILMQQUK;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly ProfilerMarker CAVQPXFORNZ;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static readonly ProfilerMarker LQDXJVYDZWW;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static readonly ProfilerMarker FKYILAJFUAH;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static readonly ProfilerMarker HZDNSOOKVVF;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly Log RKJITRMTEYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private FJFPDBGBICX ZZCERCEJWYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private CrowdBatch TQIJMAYTGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Shader RXRRASTTDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MaterialPropertyBlock SAJYCWLYSVR;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x98D6BF0", Offset = "0x98D59F0", VA = "0x1898D6BF0")]
		public static void IWIINTPYFKL(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x98D6F30", Offset = "0x98D5D30", VA = "0x1898D6F30")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x98D7C10", Offset = "0x98D6A10", VA = "0x1898D7C10")]
		public void XSOGZKEVKYC(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x98D7A90", Offset = "0x98D6890", VA = "0x1898D7A90")]
		private bool XEZVKGVXCEV(MeshRenderer a, [Out] MeshFilter b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x98D7680", Offset = "0x98D6480", VA = "0x1898D7680")]
		private bool OWZDOATCSAE(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x98D7880", Offset = "0x98D6680", VA = "0x1898D7880")]
		private void SCFCWUWDERX(GameObject a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x98D6430", Offset = "0x98D5230", VA = "0x1898D6430")]
		private List<CrowdBatch.SingleMeshData> HFGGSELAVUI(int a, [Out] List<LODGroup> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x98D5EF0", Offset = "0x98D4CF0", VA = "0x1898D5EF0")]
		private List<(int, Material)> FLWHYQNOSJL(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x98D58F0", Offset = "0x98D46F0", VA = "0x1898D58F0")]
		public void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x98D59A0", Offset = "0x98D47A0", VA = "0x1898D59A0")]
		private bool ERFMZGDCOPT(GameObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x98D8090", Offset = "0x98D6E90", VA = "0x1898D8090")]
		public CrowdOptimizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[BurstCompile]
	public class FJFPDBGBICX : IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x98F8D40", Offset = "0x98F7B40", VA = "0x1898F8D40")]
			public CrowdAABB(Bounds bounds)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x98F8C30", Offset = "0x98F7A30", VA = "0x1898F8C30")]
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
			[Cpp2IlInjected.Address(RVA = "0x98FC990", Offset = "0x98FB790", VA = "0x1898FC990")]
			private float NEJQMQUIWKP(CrowdAABB a, CrowdAABB b)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x98FC780", Offset = "0x98FB580", VA = "0x1898FC780", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly ProfilerMarker QTGDVARVBXL;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly ProfilerMarker MMTXGPVWYRP;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static readonly ProfilerMarker RKMPBCVJNST;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static readonly ProfilerMarker UQGAULMQXPY;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly ProfilerMarker QYKEHKDRFYX;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private static readonly ProfilerMarker ZLOXMEXCTVP;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private static readonly ProfilerMarker RTHVROUPXMV;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static readonly ProfilerMarker ZISWDVPDCGR;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static readonly ProfilerMarker KFWVWNIZWPR;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker KDFULRPUSLP;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker MRPDPYCRHSA;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker NMTXZCMANTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NativeArray<Node> JATLOWPFBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public NativeQueue<int> GMMKDQHYJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int UDFNQBNILHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Dictionary<Material, int> DKMJZNCYFEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public List<MinimalMeshData> XOBASUODOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public List<LODGroup> YWILKALXAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Dictionary<int, MeshRenderer> UVOJOQRGKSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Queue<int> IZCSCHTTLWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Shader XIOQLSCFYMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Shader JKPPLBTPDBO;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x98DD090", Offset = "0x98DBE90", VA = "0x1898DD090")]
		public FJFPDBGBICX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x98DABF0", Offset = "0x98D99F0", VA = "0x1898DABF0")]
		private void OZRASXBCKYY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x98DC1F0", Offset = "0x98DAFF0", VA = "0x1898DC1F0")]
		public bool THTKACJEHJS(MeshRenderer a, MeshFilter b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x98DB4C0", Offset = "0x98DA2C0", VA = "0x1898DB4C0")]
		public bool THTKACJEHJS(LODGroup a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x98D9660", Offset = "0x98D8460", VA = "0x1898D9660")]
		private bool Contains(MeshRenderer meshRenderer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x98D99C0", Offset = "0x98D87C0", VA = "0x1898D99C0")]
		private int IJTYVJUYDBI(MeshRenderer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x98DAB30", Offset = "0x98D9930", VA = "0x1898DAB30")]
		private int OCMYOIHEFDE(LODGroup a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x98D9500", Offset = "0x98D8300", VA = "0x1898D9500")]
		private int BOCMGPTJYNL(MeshFilter a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x98DAD60", Offset = "0x98D9B60", VA = "0x1898DAD60")]
		private int RPZZSCFHUAH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x98DC660", Offset = "0x98DB460", VA = "0x1898DC660")]
		private static CrowdAABB UMCAZRPPEKE(CrowdAABB a, CrowdAABB b)
		{
			return default(CrowdAABB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x98D9AE0", Offset = "0x98D88E0", VA = "0x1898D9AE0")]
		private static float KIXGAUGMRLX(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x98D9C00", Offset = "0x98D8A00", VA = "0x1898D9C00")]
		private int MHWPVYENVEP(int a, CrowdAABB b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x98D9790", Offset = "0x98D8590", VA = "0x1898D9790")]
		private void IFQNBSYIFKC(CrowdAABB a, int b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x98D9F10", Offset = "0x98D8D10", VA = "0x1898D9F10")]
		private void MNWGYUNQWPD(CrowdAABB a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x98DA910", Offset = "0x98D9710", VA = "0x1898DA910")]
		private float NEJQMQUIWKP(CrowdAABB a, CrowdAABB b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x98DC980", Offset = "0x98DB780", VA = "0x1898DC980")]
		private void VBJJSSZXXUD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x98DB090", Offset = "0x98D9E90", VA = "0x1898DB090")]
		private void Rotate(int indexA, int indexB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x98DA380", Offset = "0x98D9180", VA = "0x1898DA380")]
		private void MPDYEDMCZCD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x98D96E0", Offset = "0x98D84E0", VA = "0x1898D96E0", Slot = "4")]
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
	public class VSAANAFACEQ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public NativeArray<RingVertex> LTQKCVUNAVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public NativeArray<int> LGSVASRZPEQ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int RKAGDTTMNQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xCED330", Offset = "0xCEC130", VA = "0x180CED330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int HFUCHGQBDSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BE0", Offset = "0xCE79E0", VA = "0x180CE8BE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9903630", Offset = "0x9902430", VA = "0x189903630")]
		public VSAANAFACEQ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x99034F0", Offset = "0x99022F0", VA = "0x1899034F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9903550", Offset = "0x9902350", VA = "0x189903550")]
		public void QNXJNWRYKZL(VSAANAFACEQ a, int b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class BHFEBWBVCGF
	{
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static VSAANAFACEQ TSWETINYHRU;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static NativeList<MeshPartInfo> ORFAMFRUMSY;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static int[] AOXIBNODGLZ;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static bool PVCBCGVUKRV;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private static Dictionary<int, VSAANAFACEQ> ZWFCNPGPIFV;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static Dictionary<int, VSAANAFACEQ> OYHPBINSZHI;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool WMHFJABRSWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x98F0430", Offset = "0x98EF230", VA = "0x1898F0430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static NativeList<MeshPartInfo> DNVWHQPIULI
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x98EFAE0", Offset = "0x98EE8E0", VA = "0x1898EFAE0")]
			get
			{
				return default(NativeList<MeshPartInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static VSAANAFACEQ KVMYRIGMYBA
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x98F0C90", Offset = "0x98EFA90", VA = "0x1898F0C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x98F0630", Offset = "0x98EF430", VA = "0x1898F0630")]
		private static void VYUUCEHYUQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x98EFEB0", Offset = "0x98EECB0", VA = "0x1898EFEB0")]
		public static int GLCYLOXDSSM(bool a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x98F0400", Offset = "0x98EF200", VA = "0x1898F0400")]
		private static int OFZCPOTLGPC(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x98F0420", Offset = "0x98EF220", VA = "0x1898F0420")]
		private static int QABFSNJMZZL(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x98F0370", Offset = "0x98EF170", VA = "0x1898F0370")]
		public static int MQEAETEYKQS(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x98F04B0", Offset = "0x98EF2B0", VA = "0x1898F04B0")]
		public static int RPATHDXDRVT(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x98F02F0", Offset = "0x98EF0F0", VA = "0x1898F02F0")]
		public static int LDGGOOKSIWY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x98EF830", Offset = "0x98EE630", VA = "0x1898EF830")]
		private static int CIGSPMJHWNS(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x98EF810", Offset = "0x98EE610", VA = "0x1898EF810")]
		private static int BYYGTYVBRDV(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x98F0300", Offset = "0x98EF100", VA = "0x1898F0300")]
		public static int MKYWYSWYMVE(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x98F0E40", Offset = "0x98EFC40", VA = "0x1898F0E40")]
		public static int YGDFIPGPZMT(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x98F0D30", Offset = "0x98EFB30", VA = "0x1898F0D30")]
		public static int WCWVFACGQDC(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x98F0D50", Offset = "0x98EFB50", VA = "0x1898F0D50")]
		public static VSAANAFACEQ XGTEMUABOOE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x98EF840", Offset = "0x98EE640", VA = "0x1898EF840")]
		private static VSAANAFACEQ EROYCQZEVLU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x98F0540", Offset = "0x98EF340", VA = "0x1898F0540")]
		public static VSAANAFACEQ SRAAULSDXXV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x98EFB70", Offset = "0x98EE970", VA = "0x1898EFB70")]
		private static VSAANAFACEQ FVAPSNMZDZX(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x98EFEE0", Offset = "0x98EECE0", VA = "0x1898EFEE0")]
		public static void IGKASPCGHIZ()
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
		[Cpp2IlInjected.Address(RVA = "0x98F8FD0", Offset = "0x98F7DD0", VA = "0x1898F8FD0")]
		public CurveMeshGeneratorData(NativeArray<CurvePointData> pointDatas, int size = 1, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x98F8EF0", Offset = "0x98F7CF0", VA = "0x1898F8EF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x98F4910", Offset = "0x98F3710", VA = "0x1898F4910")]
		public CreateNativeMeshFromBatchedCurvesJob(JOBQCDJAIKZ batchedShapeData, NativeMesh destMesh, float3 rootPositionWS, quaternion rootRotationWS, float rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x98F4710", Offset = "0x98F3510", VA = "0x1898F4710")]
		public CreateNativeMeshFromBatchedCurvesJob(CurveMeshGeneratorData batchedShapeData, NativeMesh destMesh, float3 rootPositionWS, quaternion rootRotationWS, float3 rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x98F4190", Offset = "0x98F2F90", VA = "0x1898F4190")]
		private float3 TGNTGDMJZQL(float3 a, Matrix4x4 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x98F3A20", Offset = "0x98F2820", VA = "0x1898F3A20")]
		private float3x3 JVWKGXLVUOY(float3x3 a, float3x3 b)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x98F2780", Offset = "0x98F1580", VA = "0x1898F2780")]
		private float EDBMVXHERJZ(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x98F2790", Offset = "0x98F1590", VA = "0x1898F2790", Slot = "4")]
		public void Execute(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x98F4020", Offset = "0x98F2E20", VA = "0x1898F4020")]
		private void NTUKHBNCEJB(int a, float3 b, float3 c, float3 d, float e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x98F42D0", Offset = "0x98F30D0", VA = "0x1898F42D0")]
		private void WIBNBLSMGAM(CurveShapeRootData a, float3 b, float3x3 c, float d, int e, int f, int g, float h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x98F3AA0", Offset = "0x98F28A0", VA = "0x1898F3AA0")]
		private void LLFFLMFZQGG(int a, int b, CurveShapeRootData c, float3 d, float3x3 e, bool f, float g, int h, int i, int j)
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
		[Cpp2IlInjected.Address(RVA = "0x98FE490", Offset = "0x98FD290", VA = "0x1898FE490")]
		public PrimitiveMeshGeneratorData(int size, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x98FE410", Offset = "0x98FD210", VA = "0x1898FE410", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x98F7AC0", Offset = "0x98F68C0", VA = "0x1898F7AC0")]
		public CreateNativeMeshFromShapeBatchJob(JOBQCDJAIKZ batchedShapeData, NativeMesh destMesh, NativeArray<int> destVertCollapseTargetIn, float3 rootPositionWS, quaternion rootRotationWS, float rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x98F7CD0", Offset = "0x98F6AD0", VA = "0x1898F7CD0")]
		public CreateNativeMeshFromShapeBatchJob(PrimitiveMeshGeneratorData data, NativeMesh destMesh, NativeArray<int> destVertCollapseTargetIn, float3 rootPositionWS, quaternion rootRotationWS, float3 rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x98F64F0", Offset = "0x98F52F0", VA = "0x1898F64F0", Slot = "4")]
		public void Execute(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x98F75F0", Offset = "0x98F63F0", VA = "0x1898F75F0")]
		private void TEVZXKLTGAZ(float4x4 a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x98F7580", Offset = "0x98F6380", VA = "0x1898F7580")]
		private ProjectionAxis QSSJXSUMTOQ(float3 a)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x98F7A70", Offset = "0x98F6870", VA = "0x1898F7A70")]
		private float4 ZBBVNKEFOMM(ProjectionAxis a, int b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x98F7A30", Offset = "0x98F6830", VA = "0x1898F7A30")]
		private float2 UUMXVWINZWI(ProjectionAxis a, float3 b)
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
		[Cpp2IlInjected.Address(RVA = "0x98F5EC0", Offset = "0x98F4CC0", VA = "0x1898F5EC0")]
		private float3 TGNTGDMJZQL(float3 a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x98F5770", Offset = "0x98F4570", VA = "0x1898F5770")]
		private float3x3 JVWKGXLVUOY(float3x3 a)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x98F4AF0", Offset = "0x98F38F0", VA = "0x1898F4AF0")]
		private float EDBMVXHERJZ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x98F4B00", Offset = "0x98F3900", VA = "0x1898F4B00", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x98F5D50", Offset = "0x98F4B50", VA = "0x1898F5D50")]
		private void NTUKHBNCEJB(int a, float3 b, float3 c, float3 d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x98F6000", Offset = "0x98F4E00", VA = "0x1898F6000")]
		private void WIBNBLSMGAM(CurvePointData a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x98F5800", Offset = "0x98F4600", VA = "0x1898F5800")]
		private void LLFFLMFZQGG(int a, int b, float3 c, float3x3 d, bool e, float f, int g, float h)
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
		[Cpp2IlInjected.Address(RVA = "0x98F7ED0", Offset = "0x98F6CD0", VA = "0x1898F7ED0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x98F8900", Offset = "0x98F7700", VA = "0x1898F8900")]
		private void TEVZXKLTGAZ(float4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x98F7580", Offset = "0x98F6380", VA = "0x1898F7580")]
		private ProjectionAxis QSSJXSUMTOQ(float3 a)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x98F7A70", Offset = "0x98F6870", VA = "0x1898F7A70")]
		private float4 ZBBVNKEFOMM(ProjectionAxis a, int b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x98F7A30", Offset = "0x98F6830", VA = "0x1898F7A30")]
		private float2 UUMXVWINZWI(ProjectionAxis a, float3 b)
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
		public bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x98FE1B0", Offset = "0x98FCFB0", VA = "0x1898FE1B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float3 HTTBFXHPWHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x98FDE40", Offset = "0x98FCC40", VA = "0x1898FDE40")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x98FE320", Offset = "0x98FD120", VA = "0x1898FE320")]
		public OcclusionData(float3 position, quaternion rotation, float3 size, OcclusionType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x98FDC20", Offset = "0x98FCA20", VA = "0x1898FDC20")]
		public float EVIHYNVFKTL(float3 a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x98FE1C0", Offset = "0x98FCFC0", VA = "0x1898FE1C0")]
		public bool WBFCTSUOGPN(float3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x98FD950", Offset = "0x98FC750", VA = "0x1898FD950")]
		public void AJXDFOTENPH(float3 a, float3x3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x98FDB00", Offset = "0x98FC900", VA = "0x1898FDB00")]
		private void CJNSBIVMLAG(float3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x98FDF20", Offset = "0x98FCD20", VA = "0x1898FDF20")]
		public void LHIDKUCVKMB()
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
		[Cpp2IlInjected.Address(RVA = "0x98FADE0", Offset = "0x98F9BE0", VA = "0x1898FADE0")]
		public DetectEnclosedTrianglesBatchedJob(NativeMesh mesh, float rootScale, int startIndex, int startVertex, NativeList<OcclusionData> data, NativeArray<int> shapeOcclusionDataIdx, NativeList<MeshPartInfo> shapeDest, UYWIKMRBVOY optimizationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x98FA110", Offset = "0x98F8F10", VA = "0x1898FA110", Slot = "4")]
		public void Execute(int shapeIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x98FAD20", Offset = "0x98F9B20", VA = "0x1898FAD20")]
		private bool XGPCMHAASMM(OcclusionData a, OcclusionData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x98FA9E0", Offset = "0x98F97E0", VA = "0x1898FA9E0")]
		private bool PDXHSLDTYPM(OcclusionData a, int b, int c, int d)
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
		[Cpp2IlInjected.Address(RVA = "0x98FAE70", Offset = "0x98F9C70", VA = "0x1898FAE70", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x98FB600", Offset = "0x98FA400", VA = "0x1898FB600")]
		private bool TMNRUHFSPKO(OcclusionData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x98FB2C0", Offset = "0x98FA0C0", VA = "0x1898FB2C0")]
		private bool PDXHSLDTYPM(OcclusionData a, int b, int c, int d)
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
		[Cpp2IlInjected.Address(RVA = "0x15210E0", Offset = "0x151FEE0", VA = "0x1815210E0")]
		public InitializeCollapseListJob(NativeArray<int> vertCollapseTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x98FD110", Offset = "0x98FBF10", VA = "0x1898FD110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x98FC1D0", Offset = "0x98FAFD0", VA = "0x1898FC1D0")]
		public FinalizeNativeMeshCollapseListJob(NativeList<ShapeBatch.CollapseEntry> destCollapseList, NativeArray<int> srcVertCollapseTarget, int vertexStart = 0, int indexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x98FC120", Offset = "0x98FAF20", VA = "0x1898FC120", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class UYWIKMRBVOY : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public NativeArray<bool> TBTNNIKTYRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public NativeArray<int> KTIDZFQEQVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public NativeArray<bool> EUJMINACARV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public NativeArray<float> HAXPVXNIPSW;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x99033B0", Offset = "0x99021B0", VA = "0x1899033B0")]
		public void LYOIWODOTAU(int a, int b, Allocator c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x99034D0", Offset = "0x99022D0", VA = "0x1899034D0")]
		public static long ZIKMZZJWKYT(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x99032C0", Offset = "0x99020C0", VA = "0x1899032C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x99031D0", Offset = "0x9901FD0", VA = "0x1899031D0")]
		public void Dispose(JobHandle jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public UYWIKMRBVOY()
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
		[Cpp2IlInjected.Address(RVA = "0x98FC700", Offset = "0x98FB500", VA = "0x1898FC700")]
		public FinalizeNativeMeshOptimizationsJob(NativeMesh mesh, UYWIKMRBVOY optimizationData, int vertexStart = 0, int indexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x98FC1F0", Offset = "0x98FAFF0", VA = "0x1898FC1F0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x98FC690", Offset = "0x98FB490", VA = "0x1898FC690")]
		private void TAXPSAVPIIS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class RQEKPKOGALV
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A180", Offset = "0x3E48F80", VA = "0x183E4A180")]
		public static bool TFFKAQBEYFP<T>(NativeArray<T> a, int b, Allocator c, NativeArrayOptions d = NativeArrayOptions.ClearMemory, int e = 3) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A600", Offset = "0x3E49400", VA = "0x183E4A600")]
		public static bool TFFKAQBEYFP<T>(NativeList<T> a, int b, Allocator c) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A550", Offset = "0x3E49350", VA = "0x183E4A550")]
		public static bool TFFKAQBEYFP<T>(NativeQueue<T> a, Allocator b) where T : struct
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
	public interface WAZRGGGQMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EPZVEPTFZMI(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int DLBQBPSNMMY(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RRBounds IWKMUIZEZJW();

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float HTLQNANTEDG();

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BDENLGPIWYQ(SystemLOD a, JOBQCDJAIKZ b, int c = -1);

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		int HMRUVRWOATM(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class YRLFFSNNYBS
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9904490", Offset = "0x9903290", VA = "0x189904490")]
		public static void IGKASPCGHIZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class BWYSXFJXQJQ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public NativeList<float3> VALVQQTZVOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public NativeArray<float3> BMXFSTVLRAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public NativeArray<int> YHJYZQNTJDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public NativeArray<float4> TRZFGJLOCQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public NativeArray<float4> TRTYJCRQTEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public NativeArray<float4> TRORLVXTJTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public NativeArray<int> KGLQVIIWZUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public NativeList<float3> REDYAHCHPXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public NativeList<int> VHWAFBZSPMC;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int RKAGDTTMNQW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x98F1020", Offset = "0x98EFE20", VA = "0x1898F1020")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int HFUCHGQBDSO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x98F1180", Offset = "0x98EFF80", VA = "0x1898F1180")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int OOMZTGTHJOX
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x98F20B0", Offset = "0x98F0EB0", VA = "0x1898F20B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x98F2100", Offset = "0x98F0F00", VA = "0x1898F2100")]
		public BWYSXFJXQJQ(int a, int b, int c, Allocator d = Allocator.Persistent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x98F2420", Offset = "0x98F1220", VA = "0x1898F2420")]
		public BWYSXFJXQJQ(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x98F1070", Offset = "0x98EFE70", VA = "0x1898F1070", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x98F17A0", Offset = "0x98F05A0", VA = "0x1898F17A0")]
		public void QNXJNWRYKZL(BWYSXFJXQJQ a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x98F11D0", Offset = "0x98EFFD0", VA = "0x1898F11D0")]
		private void LGCGYZPASFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x98F1B30", Offset = "0x98F0930", VA = "0x1898F1B30")]
		private void TKUNYBVOHOA()
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
		[Cpp2IlInjected.Address(RVA = "0x2118EB0", Offset = "0x2117CB0", VA = "0x182118EB0")]
		public MeshPartInfo(int startVertex, int vertexCount, int startIndex, int indexCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class IABYZCDZYMJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public NativeList<MeshPartInfo> ATOBOOPPSFH
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return default(NativeList<MeshPartInfo>);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xE7DCE0", Offset = "0xE7CAE0", VA = "0x180E7DCE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public BWYSXFJXQJQ WSNDFSGATGI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x98FCB30", Offset = "0x98FB930", VA = "0x1898FCB30")]
		public IABYZCDZYMJ(IEnumerable<BWYSXFJXQJQ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x98FCAC0", Offset = "0x98FB8C0", VA = "0x1898FCAC0", Slot = "4")]
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
	public static class EPTNAGEUUSU
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static NativeArray<float2> FCUVORDJWOB;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static NativeArray<float3> UZBZCWMBTLW;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static NativeArray<float4> NUWETROJGID;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static NativeArray<int> RYNCLUBWJKK;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x98FBBC0", Offset = "0x98FA9C0", VA = "0x1898FBBC0")]
		public static void IGKASPCGHIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x98FBF00", Offset = "0x98FAD00", VA = "0x1898FBF00")]
		public static NativeArray<float2> WGHIVCHGFXV(NativeArray<float2> a, int b, NativeArray<float2> c, int d)
		{
			return default(NativeArray<float2>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x98FBDF0", Offset = "0x98FABF0", VA = "0x1898FBDF0")]
		public static NativeArray<float3> PZPYMEBDYNY(NativeArray<float3> a, int b, NativeArray<float3> c, int d)
		{
			return default(NativeArray<float3>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x98FBCE0", Offset = "0x98FAAE0", VA = "0x1898FBCE0")]
		public static NativeArray<float4> PNGCMZCHAER(NativeArray<float4> a, int b, NativeArray<float4> c, int d)
		{
			return default(NativeArray<float4>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x98FC010", Offset = "0x98FAE10", VA = "0x1898FC010")]
		public static NativeArray<int> XMSZWTDQNLO(NativeArray<int> a, int b, NativeArray<int> c, int d)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3934950", Offset = "0x3933750", VA = "0x183934950")]
		private static void MJYRWNSFSLY<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x39345A0", Offset = "0x39333A0", VA = "0x1839345A0")]
		private static void ITWHRWWVUWP<b>(NativeArray<b> a, int b, NativeArray<b> c, int d, NativeArray<b> e) where b : struct
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
		public static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9903B00", Offset = "0x9902900", VA = "0x189903B00")]
		public static uint HWQHMBHYQLD(float a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x99038A0", Offset = "0x99026A0", VA = "0x1899038A0")]
		public static void BOGFBFRRLQW(float4 a, float b, [Out] uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x99039B0", Offset = "0x99027B0", VA = "0x1899039B0")]
		public static void BOGFBFRRLQW(float4 a, uint b, [Out] uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9903F80", Offset = "0x9902D80", VA = "0x189903F80")]
		public static void KLXOJOMZSJB(float3 a, float3 b, float4 c, float2 d, float4 e, [Out] NativeMesh.VertexFormat_NormTanOct8MatUi f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9903CC0", Offset = "0x9902AC0", VA = "0x189903CC0")]
		public static void KLXOJOMZSJB(float3 a, float3 b, float4 c, float2 d, float4 e, [Out] NativeMesh.VertexFormat_PosFixedPoint16NormTanOct8MatUi f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9903840", Offset = "0x9902640", VA = "0x189903840")]
		public static byte AIHDZLGAKPB(float a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x9904220", Offset = "0x9903020", VA = "0x189904220")]
		public static ushort MQKHNBXNZGO(float a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x99043D0", Offset = "0x99031D0", VA = "0x1899043D0")]
		public static uint YQMGLDAONNK(float a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x9903A80", Offset = "0x9902880", VA = "0x189903A80")]
		public static float2 DKXUGHWQHUB(float2 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x9904280", Offset = "0x9903080", VA = "0x189904280")]
		public static float2 SXEOAECGARJ(float3 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x99036F0", Offset = "0x99024F0", VA = "0x1899036F0")]
		public static void ABKNOMXIKSU(float3 a, [Out] float3 b, [Out] uint3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x9903B10", Offset = "0x9902910", VA = "0x189903B10")]
		public static CompressedPositionFixedPoint16 JEDEMVAXGIA(float3 a)
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
		public static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private static readonly ProfilerMarker SYTHOQBHVZT;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public static float LGXMECTEACG;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private static void FNPXJIJLQWG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x9902860", Offset = "0x9901660", VA = "0x189902860")]
		public static float AKHWBZDAUDJ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x99029E0", Offset = "0x99017E0", VA = "0x1899029E0")]
		public static long DBMCKMJFAJH(float a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x9902AD0", Offset = "0x99018D0", VA = "0x189902AD0")]
		public static void XBIHRSVFYIE(float a)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Quartermaster
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public interface MNYHSLZRFSB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XBIHRSVFYIE(float a);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		(long, long, int) PIGPKQNLRDX(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public static class DBBYHPELGVA
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
		private class EEEWBFRSTDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public WorkItemTypeEnum XIFUWJIDDEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public BatchedMeshRenderer NBSXNQABLDR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public BatchedMesh WNCTFYAAHMT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public ShapeBatch UXYMIMQCADY;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x98FB6B0", Offset = "0x98FA4B0", VA = "0x1898FB6B0")]
			public void XCHLOJVPVOU([Out] bool a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public EEEWBFRSTDP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private static int XQACIUQNAPD;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private static ObjectPool<EEEWBFRSTDP> COLBNIYAGJH;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x98F9C90", Offset = "0x98F8A90", VA = "0x1898F9C90")]
		static DBBYHPELGVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x98F9730", Offset = "0x98F8530", VA = "0x1898F9730")]
		private static void RPGSYTFLKDM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x98F9900", Offset = "0x98F8700", VA = "0x1898F9900")]
		private static void WZTOPAXJALW([In] QuartermasterWorkItem workItem, [Out] bool a, [Out] bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x98F95A0", Offset = "0x98F83A0", VA = "0x1898F95A0")]
		public static void OSDEUOYMUZC(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x98F9290", Offset = "0x98F8090", VA = "0x1898F9290")]
		public static void FVZMSQRZUYR(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x98F9420", Offset = "0x98F8220", VA = "0x1898F9420")]
		public static void ODTJISLMYYG(BatchedMesh a, BatchedMeshRenderer b, long c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x98F9100", Offset = "0x98F7F00", VA = "0x1898F9100")]
		public static void FJGOJPCBUGS(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x98F99A0", Offset = "0x98F87A0", VA = "0x1898F99A0")]
		private static void ZLNIFQSPEQH(WorkItemTypeEnum a, ShapeBatch b, BatchedMesh c, BatchedMeshRenderer d, long e, long f, float g, bool h, bool i, float j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public static class QuartermasterManager
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly ProfilerMarker LIWPHQYFTGR;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private static readonly ProfilerMarker KJZLOVRHFZC;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private static readonly ProfilerMarker YUTWQTJQTCU;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static readonly ProfilerMarker OUWCRMJIHCS;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public static int RZIDPKUTGOV;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public static int ZMXUCDTZTJH;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public static int WMGAWPITBTJ;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public static long UUIQJGQEOWV;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public static long CUCHWMIPATS;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public static long QXKALDSFOVR;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public static long LYUYCMDHTNG;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public static int ZXORDGOLNKI;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public static float KZKBORDNKUS;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public static bool ZVYODHOTMJX;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public static int NWTQOWVXOTO;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public static int RZXARALTMSW;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public static int QMJILONQUGM;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public static long JRJUDYGKIIF;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public static int CNSBSASCTUI;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public static bool YVQXOPSHZMA;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static uint UTDTLBHQWXI;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private static JXMCQWIHONK NRVKKBATPYE;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static List<uint> ZNCFOYWNUEI;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static List<(QuartermasterWorkItem.Execute, QuartermasterWorkItem.Release)> ZVUXSCEWQMC;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private static MNYHSLZRFSB WNYISUWCNXP;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private static MNYHSLZRFSB LQXFTMGEUXF;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool WCJSEFHCNOR
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x98FE690", Offset = "0x98FD490", VA = "0x1898FE690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private static void NOYWXZWBCCL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private static void FNPXJIJLQWG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private static void NOYWXZWBCCL(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x99022E0", Offset = "0x99010E0", VA = "0x1899022E0")]
		public static void XUWYZCYKLRF(MNYHSLZRFSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x98FFBA0", Offset = "0x98FE9A0", VA = "0x1898FFBA0")]
		public static void RVIPVLMZDMR(MNYHSLZRFSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x98FEB20", Offset = "0x98FD920", VA = "0x1898FEB20")]
		public static (long, long, long, int, int) JOSWOIULFIG(long a)
		{
			return default((long, long, long, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x98FE9D0", Offset = "0x98FD7D0", VA = "0x1898FE9D0")]
		public static void FNXMEMQOXTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x98FFC20", Offset = "0x98FEA20", VA = "0x1898FFC20")]
		public static void XBIHRSVFYIE(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x98FFA00", Offset = "0x98FE800", VA = "0x1898FFA00")]
		public static void RSFAEMMKERI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x98FE6E0", Offset = "0x98FD4E0", VA = "0x1898FE6E0")]
		public static long EYEKQGIWNBP(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x98FEA50", Offset = "0x98FD850", VA = "0x1898FEA50")]
		public static bool HXNEHKHSBFX(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x98FF430", Offset = "0x98FE230", VA = "0x1898FF430")]
		public static bool OOIWYGVWGVE(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x98FF010", Offset = "0x98FDE10", VA = "0x1898FF010")]
		public static float LHPVZPMRLNV(long a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x98FF500", Offset = "0x98FE300", VA = "0x1898FF500")]
		public static (long, long, int) PIGPKQNLRDX(float a)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x98FECF0", Offset = "0x98FDAF0", VA = "0x1898FECF0")]
		public static void KWWBHVSWANN(QuartermasterWorkItem a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x98FE880", Offset = "0x98FD680", VA = "0x1898FE880")]
		public static int FGIVTWQIAWG(QuartermasterWorkItem.Execute a, QuartermasterWorkItem.Release b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x98FF370", Offset = "0x98FE170", VA = "0x1898FF370")]
		public static bool OJRBONBUYAF(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x98FF980", Offset = "0x98FE780", VA = "0x1898FF980")]
		public static void RLDEXPTIMBJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x98FE580", Offset = "0x98FD380", VA = "0x1898FE580")]
		public static bool BXRQQVGVKSM(float a)
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
		[Cpp2IlInjected.Address(RVA = "0x9902840", Offset = "0x9901640", VA = "0x189902840", Slot = "4")]
		private int CJIQHCAUUQM(QuartermasterWorkItem a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x9902830", Offset = "0x9901630", VA = "0x189902830", Slot = "5")]
		private bool BCSKHSDZWHT(QuartermasterWorkItem a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class JXMCQWIHONK
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
			public QuartermasterWorkItem NAVKGUMYYKS
			{
				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0x9910220", Offset = "0x990F020", VA = "0x189910220")]
				get
				{
					return default(QuartermasterWorkItem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x99103A0", Offset = "0x990F1A0", VA = "0x1899103A0")]
			public QuartermasterWorkItemEnumerator(List<QuartermasterWorkItem> instantWorkItems, List<QuartermasterWorkItem> persistentWorkItems)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x99100D0", Offset = "0x990EED0", VA = "0x1899100D0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private List<QuartermasterWorkItem> WPXXGWASIYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private List<QuartermasterWorkItem> JSAKQGYDPMX;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int PUCTPTIOQGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x98FD2D0", Offset = "0x98FC0D0", VA = "0x1898FD2D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x98FD140", Offset = "0x98FBF40", VA = "0x1898FD140")]
		public void Add([In] QuartermasterWorkItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x98FD540", Offset = "0x98FC340", VA = "0x1898FD540")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x98FD230", Offset = "0x98FC030", VA = "0x1898FD230")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x98FD5A0", Offset = "0x98FC3A0", VA = "0x1898FD5A0")]
		public void ZFQVOUWNQLY(IEnumerable<uint> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x98FD360", Offset = "0x98FC160", VA = "0x1898FD360")]
		private static void PVYPWWHRCYN(List<QuartermasterWorkItem> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x98FD430", Offset = "0x98FC230", VA = "0x1898FD430")]
		private void Remove(uint id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x98FD320", Offset = "0x98FC120", VA = "0x1898FD320")]
		public QuartermasterWorkItemEnumerator GetEnumerator()
		{
			return default(QuartermasterWorkItemEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x98FD8A0", Offset = "0x98FC6A0", VA = "0x1898FD8A0")]
		public JXMCQWIHONK()
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
		public static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private static readonly string LGKIOVDBCHX;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static readonly string FEXZFMYWIJU;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private static readonly ProfilerMarker BEAABTSUQVM;

		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private static readonly ProfilerMarker HLFJYBTVZBB;

		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private static readonly ProfilerMarker SYTHOQBHVZT;

		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private static readonly ProfilerMarker FSMOKRMYUVZ;

		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static readonly ProfilerMarker BFVKNAMWIRF;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static readonly ProfilerMarker AYYSPTKMAFU;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly ProfilerMarker YIJTWEJOPJA;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static readonly ProfilerMarker RIOQQEYFAOW;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static readonly ProfilerMarker ZGQTBNXKJVK;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static readonly ProfilerMarker LZJUHVYEGBS;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly ProfilerMarker LZZOZQFWIJT;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static readonly ProfilerMarker LZUICJLYYYK;

		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private static readonly ProfilerMarker LYTZQBQMDTR;

		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private static readonly ProfilerMarker LYOSSUWOUII;

		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private static readonly ProfilerMarker LZENKPEGWQJ;

		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private static readonly ProfilerMarker LYZGNIKJNFA;

		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private static readonly ProfilerMarker LXYYBAOWSAH;

		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private static readonly ProfilerMarker CGVWMYDRJAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		internal readonly List<ShapeBatch> OWTKLQPPOPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private readonly DisposeReminder QWSODCMVYDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private int ITNLQIYTWVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private int FHLZLUYSPFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private bool EXDBUVBPDHM;

		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public const bool DVIUIWFQBSQ = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public bool HJZGDJTWKFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		internal ScalabilityStateMesh ZCNJDCJRRML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		internal int DWZXAKJWSMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		internal int BYLULZMEZMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		internal int BIILGRNQMYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		internal int RTJXBOHKXEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		internal long RXZNXHVJEIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		internal long GFNHXVOZOSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		internal long JDGYJUXCDEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private NativeMesh SETMMCFDCIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private NativeMesh VGEHGDKPWDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private NativeMesh.UnityMeshFormat LEFCBYEKKVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private bool SWQAQXSLQCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private int RXIJERIBAGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private BatchedMeshTessellate QVQNDYOMOGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private float3 GYCKGTWLRTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private float VKEIQUSEGVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private float ALYSOITKDWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private float RWDYGKACVHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private float KVABHVPFION;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private float ZSUIOMFZKVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private float VRKKAHCIJZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private float3 WMMEVAWEAFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private float IHPJTHNPJZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private float PIMJKOZTTEL;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal Mesh WSNDFSGATGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xCE7530", Offset = "0xCE6330", VA = "0x180CE7530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public MeshFilter OFQOETRXRZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xCED340", Offset = "0xCEC140", VA = "0x180CED340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public MeshRenderer JNYBNDBWGVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B50", Offset = "0xCE6950", VA = "0x180CE7B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public List<Material> TXIJSQUOYDE
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A30", Offset = "0xCE6830", VA = "0x180CE7A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xCE8260", Offset = "0xCE7060", VA = "0x180CE8260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int YUOEEDRORJI
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xEFC1E0", Offset = "0xEFAFE0", VA = "0x180EFC1E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int RKAGDTTMNQW
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x990A870", Offset = "0x9909670", VA = "0x18990A870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int HFUCHGQBDSO
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x990AE20", Offset = "0x9909C20", VA = "0x18990AE20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x990AC50", Offset = "0x9909A50", VA = "0x18990AC50")]
		public void DBNNELVBWZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x990B5C0", Offset = "0x990A3C0", VA = "0x18990B5C0")]
		public bool MMNJWOGOQST()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x990B700", Offset = "0x990A500", VA = "0x18990B700")]
		private void NURPETVVINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x990B030", Offset = "0x9909E30", VA = "0x18990B030")]
		private void IBROTWIAAFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x990F4D0", Offset = "0x990E2D0", VA = "0x18990F4D0")]
		public BatchedMesh(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x990ACF0", Offset = "0x9909AF0", VA = "0x18990ACF0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x990B520", Offset = "0x990A320", VA = "0x18990B520")]
		private void KKEXNIOSEPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x990AA60", Offset = "0x9909860", VA = "0x18990AA60")]
		private void CreateNewUnityMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x990DEC0", Offset = "0x990CCC0", VA = "0x18990DEC0")]
		private void VBCAEDJFXKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x990ECD0", Offset = "0x990DAD0", VA = "0x18990ECD0")]
		public Mesh YEMGPJGEXWB(MeshFilter a, Transform b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x990DCE0", Offset = "0x990CAE0", VA = "0x18990DCE0")]
		public void UYSFOSDIATU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x990BC60", Offset = "0x990AA60", VA = "0x18990BC60")]
		private void SCPIVPWYIVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x990B150", Offset = "0x9909F50", VA = "0x18990B150")]
		public void IUVQPNZSJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x990DAF0", Offset = "0x990C8F0", VA = "0x18990DAF0")]
		public void UOXFXRTLWYF(WAZRGGGQMHN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x990BD20", Offset = "0x990AB20", VA = "0x18990BD20")]
		public bool SHLYFZMFNBK(WAZRGGGQMHN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x990A980", Offset = "0x9909780", VA = "0x18990A980")]
		public bool Contains(WAZRGGGQMHN meshGenerator)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x990DF60", Offset = "0x990CD60", VA = "0x18990DF60", Slot = "4")]
		public virtual void VMHFNNFWFFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x990D4D0", Offset = "0x990C2D0", VA = "0x18990D4D0")]
		public void TWOYLGEJXAL(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x990ED40", Offset = "0x990DB40", VA = "0x18990ED40")]
		public bool YTPEZPOQCAI(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x990E070", Offset = "0x990CE70", VA = "0x18990E070")]
		public bool VUKFMNMHXVL(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x990B660", Offset = "0x990A460", VA = "0x18990B660")]
		private void NRNZRYBZSJT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x990E420", Offset = "0x990D220", VA = "0x18990E420")]
		public bool XBIHRSVFYIE([In] float4x4 worldFromLocal, BatchedMeshRenderer a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x990BBB0", Offset = "0x990A9B0", VA = "0x18990BBB0")]
		public bool RBFVAWGCSWO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x990C9D0", Offset = "0x990B7D0", VA = "0x18990C9D0")]
		public bool TTYMRRPLQQH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x990A890", Offset = "0x9909690", VA = "0x18990A890")]
		public void CRSGZNYILRD(NativeMesh a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x990D9F0", Offset = "0x990C7F0", VA = "0x18990D9F0")]
		public (long, long, long) UIJVQZMXZZN()
		{
			return default((long, long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xCE7B40", Offset = "0xCE6940", VA = "0x180CE7B40")]
		public long LGLNPLVCUYL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x990B290", Offset = "0x990A090", VA = "0x18990B290")]
		private void KIWQAFJWDCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x990B9A0", Offset = "0x990A7A0", VA = "0x18990B9A0")]
		public (long, long, int) PIGPKQNLRDX(float a, [In] float4x4 worldFromLocal)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xD5F4A0", Offset = "0xD5E2A0", VA = "0x180D5F4A0")]
		internal void DNRTXJHIUDS(ScalabilityStateMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x990C240", Offset = "0x990B040", VA = "0x18990C240")]
		internal (float, float, float, float) SWAYOODLCWA(float a, [In] float4x4 worldFromLocal)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x990A670", Offset = "0x9909470", VA = "0x18990A670")]
		private void AYYCMZJWYAE(NativeMesh a, NativeMesh.UnityMeshFormat b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x990B7A0", Offset = "0x990A5A0", VA = "0x18990B7A0")]
		private void OXXNUDDXOOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x990E290", Offset = "0x990D090", VA = "0x18990E290")]
		internal bool WHCXEMZBLPH(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x990BE80", Offset = "0x990AC80", VA = "0x18990BE80")]
		private void SIXABXRTEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x990B1F0", Offset = "0x9909FF0", VA = "0x18990B1F0")]
		private void JYSESVKOTXV(NativeMesh.UnityMeshFormat a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x990B7C0", Offset = "0x990A5C0", VA = "0x18990B7C0")]
		private void OYSKGNYNZQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x990AE40", Offset = "0x9909C40", VA = "0x18990AE40")]
		public long EYEKQGIWNBP(long a, int b)
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
			[Cpp2IlInjected.Address(RVA = "0x9910460", Offset = "0x990F260", VA = "0x189910460")]
			public void RKCBVVMJUOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x99103E0", Offset = "0x990F1E0", VA = "0x1899103E0")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private static readonly string LGKIOVDBCHX;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private static readonly string FEXZFMYWIJU;

		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private static readonly ProfilerMarker BEAABTSUQVM;

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private static readonly ProfilerMarker CSKOZXQVXEI;

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private static readonly ProfilerMarker SYTHOQBHVZT;

		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private static readonly ProfilerMarker RHHQSOBGMDE;

		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private static readonly ProfilerMarker FSMOKRMYUVZ;

		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private static readonly ProfilerMarker BFVKNAMWIRF;

		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private static readonly ProfilerMarker AYYSPTKMAFU;

		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private static readonly ProfilerMarker YIJTWEJOPJA;

		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private static readonly ProfilerMarker RIOQQEYFAOW;

		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private static readonly ProfilerMarker HDTTTQPNGCS;

		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private static readonly ProfilerMarker ZGQTBNXKJVK;

		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private static readonly ProfilerMarker NJZTQXGUSOW;

		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private static readonly ProfilerMarker JMEDDTJDXTS;

		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private static readonly ProfilerMarker IWYOMMTRUFF;

		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private static readonly ProfilerMarker NVXTWBAVYTC;

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static readonly ProfilerMarker LZJUHVYEGBS;

		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private static readonly ProfilerMarker LZZOZQFWIJT;

		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private static readonly ProfilerMarker LZUICJLYYYK;

		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private static readonly ProfilerMarker LYTZQBQMDTR;

		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private static readonly ProfilerMarker LYOSSUWOUII;

		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private static readonly ProfilerMarker LZENKPEGWQJ;

		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private static readonly ProfilerMarker LYZGNIKJNFA;

		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private static readonly ProfilerMarker LXYYBAOWSAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		internal readonly List<WAZRGGGQMHN> QXUGJWMLOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		internal BatchedMesh JIEMKQRPAJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private readonly DisposeReminder QWSODCMVYDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		internal int LDADRYKMKDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		internal int HSOURMNQAAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		internal bool CQWQBJWGKYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		internal bool ZRSMBRFIAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		internal ScalabilityStateShapes BMABERVKEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		internal bool AWPSPGABGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		internal float3 ADOMTORNAAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		internal float3 YMHKUTRQMQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		internal float VMCOBAQFDLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		internal int MPFUULJPPLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		internal int YWCIJYZROMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		internal int NOCTNOVJUBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		internal float JBPHMZCYJED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		internal int FGGAMZKWTMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		internal float EROTTTRQIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		internal float WKLIUEDQZNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		internal int HPGADTUKCQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		internal long DXLLPEYVCMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public int ZBUJNCWQZZH;

		[Cpp2IlInjected.Token(Token = "0x4000270")]
		internal const int ZMUQKPZSLZA = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		internal float[] RIWKPBWDGBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		internal int[] WVGVWKHMXDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		internal long[] BFQEXDCWLDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public List<ScaledMesh> JKEHGFWLJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		internal NativeMesh JUXNXRMHYJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		internal long CAKZPNUYTWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		internal int JOKZKZYETCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		internal float VYTEGPCWJAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		internal NativeMesh.UnityMeshFormat WKAYJDQKJSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		internal CompressedNativeMeshStruct ZJXFIBYJFKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		internal int LMWYAOPDKOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		internal float JTGXNNPHFBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		internal long PCJTBWBEMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		internal bool WUNMVDRJEEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		internal ScaleMeshToDesiredTriCountsJob LZCACMYMWJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		internal JobHandle XTTHZIYZRZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		internal NativeList<CollapseEntry> RSMZJHKMWWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		internal NativeArray<long> ZYRIXATRNSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		internal bool SOAMJLDASOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		internal JobHandle IWKDAOUKDXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		internal NativeMesh HHYUWJVMDLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		internal UYWIKMRBVOY UQXFRGOCTWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		internal NativeList<CollapseEntry> SDWSPVZTCYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		internal Transform HFMLEOTIAUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		internal SystemLOD MCIQZBMWWUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		internal long JNHZNDVNMYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		internal long CQEXXVOTIHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		internal long WTFNBZVOHVE;

		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private static bool VNODDHUHFQY;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public List<WAZRGGGQMHN> JWOEKTSQZKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal int RKAGDTTMNQW
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x9910690", Offset = "0x990F490", VA = "0x189910690")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x9911BE0", Offset = "0x99109E0", VA = "0x189911BE0")]
		internal void DBNNELVBWZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x9914E40", Offset = "0x9913C40", VA = "0x189914E40")]
		internal void NURPETVVINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9919BD0", Offset = "0x99189D0", VA = "0x189919BD0")]
		internal ShapeBatch(string name, BatchedMesh parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9911E80", Offset = "0x9910C80", VA = "0x189911E80")]
		internal void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x99154A0", Offset = "0x99142A0", VA = "0x1899154A0")]
		internal void SCPIVPWYIVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9918290", Offset = "0x9917090", VA = "0x189918290")]
		internal void WXZMOYDRDLQ(WAZRGGGQMHN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9912A00", Offset = "0x9911800", VA = "0x189912A00")]
		internal bool HEISXHCVRBX(WAZRGGGQMHN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9912A80", Offset = "0x9911880", VA = "0x189912A80")]
		internal bool HFRFEYBKLZL(WAZRGGGQMHN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9917100", Offset = "0x9915F00", VA = "0x189917100", Slot = "4")]
		internal virtual void VMHFNNFWFFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9914D50", Offset = "0x9913B50", VA = "0x189914D50")]
		public float NUJANVZONHP(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x9910490", Offset = "0x990F290", VA = "0x189910490")]
		public bool AVSOOWPJQDK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9910760", Offset = "0x990F560", VA = "0x189910760")]
		public (CompressedNativeMeshStruct, NativeMesh.UnityMeshFormat) CQRZUCSZBQU()
		{
			return default((CompressedNativeMeshStruct, NativeMesh.UnityMeshFormat));
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x99106B0", Offset = "0x990F4B0", VA = "0x1899106B0")]
		internal long COGYZKFYAPT()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x9912640", Offset = "0x9911440", VA = "0x189912640")]
		internal long FVVMDESIPBK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x99157F0", Offset = "0x99145F0", VA = "0x1899157F0")]
		internal bool SKKACVRFGLV(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9917180", Offset = "0x9915F80", VA = "0x189917180")]
		internal bool VUKFMNMHXVL(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9914930", Offset = "0x9913730", VA = "0x189914930")]
		internal void NRNZRYBZSJT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x99184D0", Offset = "0x99172D0", VA = "0x1899184D0")]
		internal bool XBIHRSVFYIE([In] float4x4 worldFromLocal, BatchedMeshRenderer a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9911BF0", Offset = "0x99109F0", VA = "0x189911BF0")]
		internal bool DUEXNLQOTLU(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9919520", Offset = "0x9918320", VA = "0x189919520")]
		internal void YWHHDXMZGTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9911BB0", Offset = "0x99109B0", VA = "0x189911BB0")]
		internal void CRSGZNYILRD(NativeMesh a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9916E70", Offset = "0x9915C70", VA = "0x189916E70")]
		internal void TWYOSBKUCVG(CompressedNativeMeshStruct a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9913550", Offset = "0x9912350", VA = "0x189913550")]
		internal void KIWQAFJWDCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9915010", Offset = "0x9913E10", VA = "0x189915010")]
		internal (long, long, int) PIGPKQNLRDX(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xCF1010", Offset = "0xCEFE10", VA = "0x180CF1010")]
		internal void DNRTXJHIUDS(ScalabilityStateShapes a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9916520", Offset = "0x9915320", VA = "0x189916520")]
		public static (float, float, float, float) SWAYOODLCWA(float3 a, float3 b, float c, [In] float4x4 worldFromLocal, float d)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9916310", Offset = "0x9915110", VA = "0x189916310")]
		internal (float, float, float, float) SWAYOODLCWA(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x99194F0", Offset = "0x99182F0", VA = "0x1899194F0")]
		private float XYFCNLSEHJP(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9916900", Offset = "0x9915700", VA = "0x189916900")]
		private (int, int, float) TRXVJJOZNOS(float a)
		{
			return default((int, int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9912590", Offset = "0x9911390", VA = "0x189912590")]
		internal static float FNSAVPEWYFY(WAZRGGGQMHN a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9910D90", Offset = "0x990FB90", VA = "0x189910D90")]
		internal void CRSBJZLRKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9914F80", Offset = "0x9913D80", VA = "0x189914F80")]
		internal void OYSKGNYNZQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9917FC0", Offset = "0x9916DC0", VA = "0x189917FC0")]
		internal void WFTWCEFFYYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9911FB0", Offset = "0x9910DB0", VA = "0x189911FB0")]
		internal long EYEKQGIWNBP(long a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9913DA0", Offset = "0x9912BA0", VA = "0x189913DA0")]
		private void NAHGFENENCM(NativeMesh a, NativeList<CollapseEntry> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9912760", Offset = "0x9911560", VA = "0x189912760")]
		internal void GYSZAXRVVRD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9913740", Offset = "0x9912540", VA = "0x189913740")]
		public static void MUGMXJMQZLM(NativeList<CollapseEntry> a, NativeMesh b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x9918200", Offset = "0x9917000", VA = "0x189918200")]
		private float WRJEZCUAROC(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9912AE0", Offset = "0x99118E0", VA = "0x189912AE0")]
		internal void KHJUNMLGDUM(NativeMesh a, CompressedNativeMesh b, int c, int d, float e)
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
		internal static class GLTTGJSHOFL
		{
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x990FF40", Offset = "0x990ED40", VA = "0x18990FF40")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x990FDC0", Offset = "0x990EBC0", VA = "0x18990FDC0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x9908590", Offset = "0x9907390", VA = "0x189908590")]
			public static void Invoke(BatchedMeshTessellateJob bmtj, [In] TriToTessellate tri)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void TessellateQuad_00000271$PostfixBurstDelegate(BatchedMeshTessellateJob bmtj, [In] QuadToTessellate quad);

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		internal static class YRLLDOKVFSS
		{
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x991A450", Offset = "0x9919250", VA = "0x18991A450")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x991A2D0", Offset = "0x99190D0", VA = "0x18991A2D0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x9909180", Offset = "0x9907F80", VA = "0x189909180")]
			public static void Invoke(BatchedMeshTessellateJob bmtj, [In] QuadToTessellate quad)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void BuildNativeMesh_00000274$PostfixBurstDelegate(UnsafeList<int>* resultIndices, UnsafeList<float3>* resultVerts, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* newVerts, UnsafeList<int>* newIndices, UnsafeList<float3>* inMeshVerts, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int numIndices, int numVerts);

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		internal static class DFEQYZGFEKQ
		{
			[Cpp2IlInjected.Token(Token = "0x40002CF")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x990FC30", Offset = "0x990EA30", VA = "0x18990FC30")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x990F760", Offset = "0x990E560", VA = "0x18990F760")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x990F8E0", Offset = "0x990E6E0", VA = "0x18990F8E0")]
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
		public VOZUINYURPV.ScalabilityTessellationModeEnum shapesTessellateMode;

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
		[Cpp2IlInjected.Address(RVA = "0x9907D50", Offset = "0x9906B50", VA = "0x189907D50")]
		private static float OIBIZASAKLJ([In] BatchedMeshTessellateJob bmtj, [In] float3 vertPos, float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9907B20", Offset = "0x9906920", VA = "0x189907B20")]
		private static int GKEZOPKVVBB(BatchedMeshTessellateJob a, [Out] TessVert b, [In] TessVert vert0, [In] TessVert vert1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9908590", Offset = "0x9907390", VA = "0x189908590")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.TessellateTri_00000270$PostfixBurstDelegate))]
		private static void XXADPDEHLHI(BatchedMeshTessellateJob a, [In] TriToTessellate tri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9909180", Offset = "0x9907F80", VA = "0x189909180")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.TessellateQuad_00000271$PostfixBurstDelegate))]
		private static void YZALOEQXMJA(BatchedMeshTessellateJob a, [In] QuadToTessellate quad)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9907B10", Offset = "0x9906910", VA = "0x189907B10", Slot = "4")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x99061F0", Offset = "0x9904FF0", VA = "0x1899061F0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal void BDLNVDZTTOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9907CA0", Offset = "0x9906AA0", VA = "0x189907CA0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.BuildNativeMesh_00000274$PostfixBurstDelegate))]
		internal unsafe static void IOXLRCCTTAV(UnsafeList<int>* a, UnsafeList<float3>* b, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* c, UnsafeList<int>* d, UnsafeList<float3>* e, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int f, int g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x99070A0", Offset = "0x9905EA0", VA = "0x1899070A0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal static void ESLQXMOBERP(BatchedMeshTessellateJob a, [In] TriToTessellate tri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x9908790", Offset = "0x9907590", VA = "0x189908790")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal static void YXDBJHLPKXL(BatchedMeshTessellateJob a, [In] QuadToTessellate quad)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9907DE0", Offset = "0x9906BE0", VA = "0x189907DE0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal unsafe static void VCGTTGNKFKI(UnsafeList<int>* a, UnsafeList<float3>* b, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* c, UnsafeList<int>* d, UnsafeList<float3>* e, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int f, int g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class BatchedMeshTessellate
	{
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private static readonly ProfilerMarker FBFTZBPQBMN;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public const int QRTDJZAYWPU = 2;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private const int QPHULOPVCNW = 1;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private static int OXBACJJUXJO;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private static Stack<BatchedMeshTessellate> GSFAFXVFNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private NativeMesh JJGCKZAWHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private NativeList<TessVert> BFUEGMLDQIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private NativeList<int> BXSDDNBBPUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private NativeList<BatchedMeshTessellateJob.TriToTessellate> QMPSEJPKWRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private NativeList<BatchedMeshTessellateJob.TriToTessellate> QJWRZMFPPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private NativeList<BatchedMeshTessellateJob.QuadToTessellate> MGTIATCEYTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private NativeList<BatchedMeshTessellateJob.QuadToTessellate> KBJRSMIKTVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private BatchedMeshTessellateJob IDUBSUGBSXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private JobHandle NYGNSILPNFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private BatchedMeshTessellateJob.GenerateTessellatedMeshResults CKUHWWJHOBC;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private const int UNIWBEKDRCW = 65530;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x990A4E0", Offset = "0x99092E0", VA = "0x18990A4E0")]
		private BatchedMeshTessellate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x990A050", Offset = "0x9908E50", VA = "0x18990A050")]
		public void ZEVPACBXTCE(NativeMesh a, float3 b, float c, float d, float e, List<ShapeBatch.CollapseEntry> f, Allocator g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9909380", Offset = "0x9908180", VA = "0x189909380")]
		public (bool, NativeMesh, float) DJAJXJMNGJP(List<ShapeBatch.CollapseEntry> a, Allocator b, bool c)
		{
			return default((bool, NativeMesh, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x9909F20", Offset = "0x9908D20", VA = "0x189909F20")]
		public static bool TYONCPMQYTY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x99098E0", Offset = "0x99086E0", VA = "0x1899098E0")]
		public static int HJXHVMPMMJT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9909870", Offset = "0x9908670", VA = "0x189909870")]
		public static int DZRVDJUIOGP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9909C50", Offset = "0x9908A50", VA = "0x189909C50")]
		public static BatchedMeshTessellate TILDQXGUWBS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9909FB0", Offset = "0x9908DB0", VA = "0x189909FB0")]
		internal static void UJCNDDHYOLH(BatchedMeshTessellate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x9909AE0", Offset = "0x99088E0", VA = "0x189909AE0")]
		public static void LSCSJNWOYHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x9909930", Offset = "0x9908730", VA = "0x189909930")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		public static void IGKASPCGHIZ()
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
		[Cpp2IlInjected.Address(RVA = "0x991A280", Offset = "0x9919080", VA = "0x18991A280")]
		public static void Create([Out] TessVert result, int srcIndex, [In] float3 posIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9919F90", Offset = "0x9918D90", VA = "0x189919F90")]
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
			public VOZUINYURPV.ScalabilityCollapseMetricEnum shapesCollapseMetric;

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
			[Cpp2IlInjected.Address(RVA = "0x9925700", Offset = "0x9924500", VA = "0x189925700")]
			public void LYOIWODOTAU(int a, int b, Allocator c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x99258E0", Offset = "0x99246E0", VA = "0x1899258E0")]
			public static NativeMeshJob SORQHWRDWWC(NativeMesh a)
			{
				return default(NativeMeshJob);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x41440A0", Offset = "0x4142EA0", VA = "0x1841440A0")]
			private static void WZDWXGPRCOU<T>(NativeArray<T> a, NativeArray<T> b) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x9925640", Offset = "0x9924440", VA = "0x189925640")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void Setup_FastCopyCollapse_0000028F$PostfixBurstDelegate(int numCollapses, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		internal static class FSNSBEHDNRB
		{
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x9924650", Offset = "0x9923450", VA = "0x189924650")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x99242C0", Offset = "0x99230C0", VA = "0x1899242C0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x9924430", Offset = "0x9923230", VA = "0x189924430")]
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
		[Cpp2IlInjected.Address(RVA = "0x992A130", Offset = "0x9928F30", VA = "0x18992A130")]
		public ScaleMeshToDesiredTriCountsJob([In] List<ShapeBatch.ScaledMesh> meshListIn, NativeList<ShapeBatch.CollapseEntry> collapseListOut, [In] NativeMesh meshSrcIn, [In] NativeList<ShapeBatch.CollapseEntry> collapseListIn, [In] NativeArray<long> scaleMeshJobAbortRequest, float3 bboxMin, float3 bboxMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x9929D60", Offset = "0x9928B60", VA = "0x189929D60")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.Setup_FastCopyCollapse_0000028F$PostfixBurstDelegate))]
		private unsafe static void VDAABGAGSNN(int a, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9927430", Offset = "0x9926230", VA = "0x189927430")]
		public static long HXXHOSMYLXP(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x99273E0", Offset = "0x99261E0", VA = "0x1899273E0", Slot = "4")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9929130", Offset = "0x9927F30", VA = "0x189929130")]
		public void RIEXHOEEDFC(List<ShapeBatch.ScaledMesh> a, [In] ShapeBatch shapeBatchIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x9927190", Offset = "0x9925F90", VA = "0x189927190")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private bool AbortRequested()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x99271B0", Offset = "0x9925FB0", VA = "0x1899271B0")]
		private CompressedNativeMeshStruct CFTSGCFDVQZ(int a, Allocator b)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9927450", Offset = "0x9926250", VA = "0x189927450")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private void QMXFWPGRPZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9928B70", Offset = "0x9927970", VA = "0x189928B70")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private float QSVPHSFBFPB(int a, int b, bool c, bool d, float e, float f, float g, float h, float i, float j, float k)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x9929D70", Offset = "0x9928B70", VA = "0x189929D70")]
		[IgnoreWarning(1371)]
		private ScaledMeshJob ZDMGPRHKGZF([In] ScaledMeshJob scaledMeshJobSrc, int a, [In] NativeArray<int> indices, [In] NativeArray<bool> vertexUsed, NativeArray<int> b)
		{
			return default(ScaledMeshJob);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x9929B80", Offset = "0x9928980", VA = "0x189929B80")]
		public static int SUCKUTAMASH(NativeArray<int> a, NativeArray<int> b, int c, int d, int e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x991A690", Offset = "0x9919490", VA = "0x18991A690")]
		[BurstCompile]
		internal unsafe static void TIJUCOVCXAS(int a, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int b)
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
			public WAZRGGGQMHN shape;

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x9924290", Offset = "0x9923090", VA = "0x189924290")]
			public BoundsShape(RRBounds inBounds, WAZRGGGQMHN inEntry)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		private class YWWAFNDRNHZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public RRBounds BNSBZDVHLYY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			public int PRHDDAJFSES;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public float VMCOBAQFDLS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public List<BoundsShape> JWIMQSBXLXR;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x992AC50", Offset = "0x9929A50", VA = "0x18992AC50")]
			public YWWAFNDRNHZ(RRBounds a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private static readonly ProfilerMarker UYAZKVVWOJD;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private static readonly ProfilerMarker NLEPGUEFXKW;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private static readonly ProfilerMarker UFKVRVEADUE;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static readonly ProfilerMarker SMYPTJDQYGN;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private static readonly ProfilerMarker XFNPUHUIAVN;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static readonly ProfilerMarker AYYSPTKMAFU;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private static readonly ProfilerMarker ZCXABLYQCHR;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		internal const int ZUECMSJPSYY = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		internal static Dictionary<Material, List<Material>> WOPNLVZMDIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private Dictionary<Material, List<BatchedMesh>> GZDYDGQUOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		internal List<BatchedMesh> ZTMMJDFKAHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private List<MeshRenderer> PQRBRTYGTRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private Transform GZAWWSQTFEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private bool HKGPBWRFEJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private bool QIIMWCGZYEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private int GNYJCSQNHWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private BatchedMesh RWMCYOSFXZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Material NZPWDAWGUSH;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private static bool? OVPCLJUCNHP;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private const int VVYBVWOIASM = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private static List<BoundsShape> MDLMBCOICLH;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<MeshRenderer> MWPSONSTCGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int FUZGBYOKBTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x99209A0", Offset = "0x991F7A0", VA = "0x1899209A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private static bool EXLSEFBTAMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x99204B0", Offset = "0x991F2B0", VA = "0x1899204B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private static void NOYWXZWBCCL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private static void NOYWXZWBCCL(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private static void CPKSJUKUHAM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x991A950", Offset = "0x9919750", VA = "0x18991A950")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x991AFF0", Offset = "0x9919DF0", VA = "0x18991AFF0")]
		internal bool FLYGNVPJCCF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x991C820", Offset = "0x991B620", VA = "0x18991C820")]
		private Transform RGSLHDDXNXF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x991C690", Offset = "0x991B490", VA = "0x18991C690")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x991ABE0", Offset = "0x99199E0", VA = "0x18991ABE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x991A6D0", Offset = "0x99194D0", VA = "0x18991A6D0")]
		public BatchedMesh AddToBatchedMesh(WAZRGGGQMHN newMesh, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x991F810", Offset = "0x991E610", VA = "0x18991F810")]
		public void RemoveFromBatchedMesh(WAZRGGGQMHN mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x991AAB0", Offset = "0x99198B0", VA = "0x18991AAB0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x991C6A0", Offset = "0x991B4A0", VA = "0x18991C6A0")]
		private void PGYECBNHHCN(Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x991B6F0", Offset = "0x991A4F0", VA = "0x18991B6F0")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x991B6E0", Offset = "0x991A4E0", VA = "0x18991B6E0")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x991C0A0", Offset = "0x991AEA0", VA = "0x18991C0A0")]
		private void NPGGLIISJRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x991B8C0", Offset = "0x991A6C0", VA = "0x18991B8C0")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x991F950", Offset = "0x991E750", VA = "0x18991F950")]
		private BatchedMesh SDEVJLOJWCQ(WAZRGGGQMHN a, Material b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x991BDC0", Offset = "0x991ABC0", VA = "0x18991BDC0")]
		private BatchedMesh NNPRSYXXKYK(Material a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x991FBE0", Offset = "0x991E9E0", VA = "0x18991FBE0")]
		private BatchedMesh TTEQUYMRJKD(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x991FB50", Offset = "0x991E950", VA = "0x18991FB50")]
		internal void TMODXNJRWLO([Out] float4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x991B050", Offset = "0x9919E50", VA = "0x18991B050")]
		public static List<Material> GenerateVertexFormatVariants(Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x99203B0", Offset = "0x991F1B0", VA = "0x1899203B0")]
		public static void UpdateMaterialVariants(Material parentMaterial, Action<Material> updateFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xF1A710", Offset = "0xF19510", VA = "0x180F1A710")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x991B760", Offset = "0x991A560", VA = "0x18991B760")]
		public void MarkDirty(WAZRGGGQMHN mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x991C720", Offset = "0x991B520", VA = "0x18991C720")]
		[Conditional("CHECK_STATE")]
		private void PVGDUKLTHLT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x991BA20", Offset = "0x991A820", VA = "0x18991BA20")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float scalabilityErrorControl)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x991A980", Offset = "0x9919780", VA = "0x18991A980")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x991E550", Offset = "0x991D350", VA = "0x18991E550")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x991B1C0", Offset = "0x9919FC0", VA = "0x18991B1C0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x991C980", Offset = "0x991B780", VA = "0x18991C980")]
		public void RebatchOptimally(int batchSizeNaughty, int batchSizeNice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x991C8A0", Offset = "0x991B6A0", VA = "0x18991C8A0")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x9920890", Offset = "0x991F690", VA = "0x189920890")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D6FD30", Offset = "0x1D6EB30", VA = "0x181D6FD30")]
			public void LOMLKNASVXH()
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
		private sealed class QOMFUKPHUGP : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			private bool OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			private long UMODRJCYBKR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public long XFOQRHHAYOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private bool SGLYQBGZZSC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public bool TRTDIOSSUZP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			private int IYPDCUCCDEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			private int HNWFECMJEOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			private int INBSYXUYAER;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			private int UZPKWRBXRAV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private List<BatchedMeshRenderer>.Enumerator ULBAVWKNYIR;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool RAZTNGWABOT
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0x131D930", Offset = "0x131C730", VA = "0x18131D930", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x8BFB430", Offset = "0x8BFA230", VA = "0x188BFB430", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x15A3320", Offset = "0x15A2120", VA = "0x1815A3320")]
			[DebuggerHidden]
			public QOMFUKPHUGP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x9926EF0", Offset = "0x9925CF0", VA = "0x189926EF0", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x9925D00", Offset = "0x9924B00", VA = "0x189925D00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x99270A0", Offset = "0x9925EA0", VA = "0x1899270A0")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9927050", Offset = "0x9925E50", VA = "0x189927050")]
			private void RHHWHJORETB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x9927010", Offset = "0x9925E10", VA = "0x189927010", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x99270F0", Offset = "0x9925EF0", VA = "0x1899270F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> WAMYQCFKMKI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x99270F0", Offset = "0x9925EF0", VA = "0x1899270F0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private static readonly ProfilerMarker AYYSPTKMAFU;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly ProfilerMarker MSAFGJVFLTM;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly ProfilerMarker CUSHVDJLJTW;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly ProfilerMarker DEOHGMARLSQ;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static float3 OUEMIYFVOXH;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static int XBOSRCXDHSQ;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static int MOAZTAJIHOX;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static int ITPMHTANUIK;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static int JZFVHZSOATB;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static int ZCGCMPFMNOB;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static float BBGWHFRUPNK;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static float MMXBIHJIKEO;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static float NRMUYTVVVBA;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static float GTINRQKWJNJ;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static float UFUUGLLAMJS;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static float EMKFQGGIMBN;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static float WZUAEHDRJIN;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static float UBTWTEUJULS;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private static List<BatchedMeshRenderer> FOIRDEDVKGF;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private static Stack<NativeMesh> DTEBEYYFICE;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private static Stack<UYWIKMRBVOY> JNTQPDLABMX;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static UECLNUSSBAX IGNMEFXSUOC;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private static FindAndMarkAsFrozenCache MTGSREHPGXY;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static int SFQALEXQTUT;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private static void NOYWXZWBCCL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private static void FNPXJIJLQWG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private static void NOYWXZWBCCL(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x99225F0", Offset = "0x99213F0", VA = "0x1899225F0")]
		public static void RKCBVVMJUOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x9920B60", Offset = "0x991F960", VA = "0x189920B60")]
		public static void EWAYCUSOBLF(BatchedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x9923600", Offset = "0x9922400", VA = "0x189923600")]
		public static void YSTLTUKCYIY(BatchedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9923730", Offset = "0x9922530", VA = "0x189923730")]
		public static void ZYANUYFHBSU(WAZRGGGQMHN a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9921940", Offset = "0x9920740", VA = "0x189921940")]
		public static void GBGAOYIGSPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x99227A0", Offset = "0x99215A0", VA = "0x1899227A0")]
		public static void XBIHRSVFYIE(float a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x9923010", Offset = "0x9921E10", VA = "0x189923010")]
		private static void XPHVNWEBXQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x9920D00", Offset = "0x991FB00", VA = "0x189920D00")]
		public static long EYEKQGIWNBP(int a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9922190", Offset = "0x9920F90", VA = "0x189922190")]
		public static (long, long, int) PIGPKQNLRDX(float a)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x9921F30", Offset = "0x9920D30", VA = "0x189921F30")]
		[IteratorStateMachine(typeof(QOMFUKPHUGP))]
		public static IEnumerable<bool> LOLUWKLQQKG(long a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9921CD0", Offset = "0x9920AD0", VA = "0x189921CD0")]
		public static void GLIGDJPEOPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x99223A0", Offset = "0x99211A0", VA = "0x1899223A0")]
		public static void PYOQSFCAIDI(long a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x99217C0", Offset = "0x99205C0", VA = "0x1899217C0")]
		public static int FHNXLIANMBK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x99209F0", Offset = "0x991F7F0", VA = "0x1899209F0")]
		internal static NativeMesh BWDOUKNXQMS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x9922670", Offset = "0x9921470", VA = "0x189922670")]
		internal static void UJCNDDHYOLH(NativeMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x99234B0", Offset = "0x99222B0", VA = "0x1899234B0")]
		internal static UYWIKMRBVOY XXLHGFPVATL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9922710", Offset = "0x9921510", VA = "0x189922710")]
		internal static void UJCNDDHYOLH(UYWIKMRBVOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9921FB0", Offset = "0x9920DB0", VA = "0x189921FB0")]
		public static void LSCSJNWOYHG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class FMWJFGANWSA<a> : BatchedMesh
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private readonly Dictionary<a, WAZRGGGQMHN> MSSZYLQZPWG;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x62A3FA0", Offset = "0x62A2DA0", VA = "0x1862A3FA0")]
		public FMWJFGANWSA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x62A3E00", Offset = "0x62A2C00", VA = "0x1862A3E00")]
		public void UOXFXRTLWYF(a a, WAZRGGGQMHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x62A3A10", Offset = "0x62A2810", VA = "0x1862A3A10")]
		public bool DMEVWRETLUU(a a, WAZRGGGQMHN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x62A3C70", Offset = "0x62A2A70", VA = "0x1862A3C70")]
		public void LYHTFKYJPNR(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x62A3E50", Offset = "0x62A2C50", VA = "0x1862A3E50", Slot = "4")]
		public override void VMHFNNFWFFE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public static class LZLQZHEJBHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly ProfilerCategory TOLJMWDHNEE;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		internal static readonly ProfilerMarker LHPVZPMRLNV;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		internal static readonly RuntimeMarker XBIHRSVFYIE;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static readonly RuntimeCounterValue<float> OYJVBJHVSQH;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static readonly RuntimeCounterValue<float> GLUTZODMISY;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly RuntimeCounterValue<float> PYQYANDIVXR;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private static readonly RuntimeCounterValue<double> FWUANQXWWLB;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private static readonly RuntimeCounterValue<double> SFLYNRZVPAT;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private static readonly RuntimeCounterValue<double> VYZNIFUESTE;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private static readonly RuntimeCounterValue<double> FNZJQWYJGIW;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private static readonly RuntimeCounterValue<int> BEDRDECJNHQ;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private static readonly RuntimeCounterValue<int> URJXXBGFLPM;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private static readonly RuntimeCounterValue<int> ZAOWDKPOROY;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private static readonly RuntimeCounterValue<int> WOXOTRIMGEB;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private static readonly RuntimeCounterValue<int> UIKYIYXMWAY;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private static readonly RuntimeCounterValue<int> SAFZICRGDJK;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private static readonly RuntimeCounterValue<int> SNRPRFMFPGZ;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private static readonly RuntimeCounterValue<int> SGBPUNUFMWI;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private static readonly RuntimeCounterValue<long> TEGOAPQPJXI;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static readonly RuntimeCounterValue<long> EBJHGNQFUDD;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private static readonly RuntimeCounterValue<long> DUWDBKUMQEY;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private static readonly RuntimeCounterValue<long> MDXXYOOKDWS;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private static readonly RuntimeCounterValue<long> BTSLCVHOLOK;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private static readonly RuntimeCounterValue<long> GLOHYKMMMSH;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x99247D0", Offset = "0x99235D0", VA = "0x1899247D0")]
		public static void QZWUJFHNRRF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2542220493
{
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x992AD00", Offset = "0x9929B00", VA = "0x18992AD00")]
	public static void HARHJNMTRDT()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x992ACF0", Offset = "0x9929AF0", VA = "0x18992ACF0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x992AAF0", Offset = "0x99298F0", VA = "0x18992AAF0")]
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
