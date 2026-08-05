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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AAAF70", Offset = "0x8AA9B70", VA = "0x188AAAF70", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal static class TVCEVWYDIUI
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly Log JOKYXJUTVHE;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly Log IFYKANJAVED;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly Log VSMNBXVEJKX;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly Log CLJMZIGMHVA;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly Log RDMWYDVPBOX;
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
		public CompressedNativeMeshStruct HYBRGVPMGAK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int RNWXKCRXZMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
		internal static class XKANFIZXCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8AB6FD0", Offset = "0x8AB5BD0", VA = "0x188AB6FD0")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8AB7160", Offset = "0x8AB5D60", VA = "0x188AB7160")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8AB6D80", Offset = "0x8AB5980", VA = "0x188AB6D80")]
			public unsafe static void Invoke([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int vertexCount, [In] float3 vertMin, [In] float3 vertScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetAllVerts_0000003D$PostfixBurstDelegate([NoAlias] ushort* dstVerts, [Out] float3 vertMinimum, [Out] float3 vertScale, [In][NoAlias] float3* srcVerts, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal static class GBXXOKKGQEX
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5B00", Offset = "0x8AA4700", VA = "0x188AA5B00")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5C90", Offset = "0x8AA4890", VA = "0x188AA5C90")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5890", Offset = "0x8AA4490", VA = "0x188AA5890")]
			public unsafe static void Invoke([NoAlias] ushort* dstVerts, [Out] float3 vertMinimum, [Out] float3 vertScale, [In][NoAlias] float3* srcVerts, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetAllNormals_0000003F$PostfixBurstDelegate([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class SDSFHGMUUSN
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4DA0", Offset = "0x8AB39A0", VA = "0x188AB4DA0")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4F30", Offset = "0x8AB3B30", VA = "0x188AB4F30")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4B30", Offset = "0x8AB3730", VA = "0x188AB4B30")]
			public unsafe static void Invoke([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void GetAllNormals_00000041$PostfixBurstDelegate([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		internal static class YUUSKSYNLBZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8AB81A0", Offset = "0x8AB6DA0", VA = "0x188AB81A0")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8AB8330", Offset = "0x8AB6F30", VA = "0x188AB8330")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8AB7F20", Offset = "0x8AB6B20", VA = "0x188AB7F20")]
			public unsafe static void Invoke([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetAllUVs_00000048$PostfixBurstDelegate([NoAlias] uint* dstUVs, [Out] float2 uvMinimum, [Out] float2 uvScale, [In][NoAlias] float2* srcUVs, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		internal static class PAFXLVHXQEA
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8AB2AB0", Offset = "0x8AB16B0", VA = "0x188AB2AB0")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8AB2C40", Offset = "0x8AB1840", VA = "0x188AB2C40")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8AB2840", Offset = "0x8AB1440", VA = "0x188AB2840")]
			public unsafe static void Invoke([NoAlias] uint* dstUVs, [Out] float2 uvMinimum, [Out] float2 uvScale, [In][NoAlias] float2* srcUVs, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void GetUV_00000049$PostfixBurstDelegate([Out] float2 ret, uint compressed, [In] float2 uvMin, [In] float2 uvScale);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class GKILARILPIF
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8AA6080", Offset = "0x8AA4C80", VA = "0x188AA6080")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8AA6210", Offset = "0x8AA4E10", VA = "0x188AA6210")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5E10", Offset = "0x8AA4A10", VA = "0x188AA5E10")]
			public static void Invoke([Out] float2 ret, uint compressed, [In] float2 uvMin, [In] float2 uvScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void GetAllUVs_0000004B$PostfixBurstDelegate([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int vertexCount, [In] float2 uvMin, [In] float2 uvScale);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		internal static class LCGGCNWATFM
		{
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8AAAC60", Offset = "0x8AA9860", VA = "0x188AAAC60")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8AAADF0", Offset = "0x8AA99F0", VA = "0x188AAADF0")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8AAA9A0", Offset = "0x8AA95A0", VA = "0x188AAA9A0")]
			public unsafe static void Invoke([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int vertexCount, [In] float2 uvMin, [In] float2 uvScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetAllTangents_00000052$PostfixBurstDelegate([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal static class EJJHVVUKECZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8AA4F10", Offset = "0x8AA3B10", VA = "0x188AA4F10")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8AA50A0", Offset = "0x8AA3CA0", VA = "0x188AA50A0")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8AA4CA0", Offset = "0x8AA38A0", VA = "0x188AA4CA0")]
			public unsafe static void Invoke([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ushort SetTangent_00000053$PostfixBurstDelegate([In] float4 newVal);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		internal static class ETFYBLLZRYK
		{
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8AA54C0", Offset = "0x8AA40C0", VA = "0x188AA54C0")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5650", Offset = "0x8AA4250", VA = "0x188AA5650")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5220", Offset = "0x8AA3E20", VA = "0x188AA5220")]
			public static ushort Invoke([In] float4 newVal)
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void GetAllTangents_00000055$PostfixBurstDelegate([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class MRXPNPVDOPW
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8AAB520", Offset = "0x8AAA120", VA = "0x188AAB520")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8AAB6B0", Offset = "0x8AAA2B0", VA = "0x188AAB6B0")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8AAB2A0", Offset = "0x8AA9EA0", VA = "0x188AAB2A0")]
			public unsafe static void Invoke([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void GetTangent_0000005B$PostfixBurstDelegate([Out] float4 result, ushort compressed);

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		internal static class XHBDOIEZCKB
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8AB6A70", Offset = "0x8AB5670", VA = "0x188AB6A70")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8AB6C00", Offset = "0x8AB5800", VA = "0x188AB6C00")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8AB67C0", Offset = "0x8AB53C0", VA = "0x188AB67C0")]
			public static void Invoke([Out] float4 result, ushort compressed)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void CreateAllMaterialIndices_0000005D$PostfixBurstDelegate([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int numData, [Out] int numRLEs, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		internal static class YQHVMNIQNAF
		{
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8AB7580", Offset = "0x8AB6180", VA = "0x188AB7580")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8AB7710", Offset = "0x8AB6310", VA = "0x188AB7710")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8AB72E0", Offset = "0x8AB5EE0", VA = "0x188AB72E0")]
			public unsafe static void Invoke([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int numData, [Out] int numRLEs, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void DecodeMaterialIndices_0000005F$PostfixBurstDelegate([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		internal static class YTYPJJSGKHG
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8AB7C10", Offset = "0x8AB6810", VA = "0x188AB7C10")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8AB7DA0", Offset = "0x8AB69A0", VA = "0x188AB7DA0")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8AB7890", Offset = "0x8AB6490", VA = "0x188AB7890")]
			public unsafe static void Invoke([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate int EncodeIndices_00000067$PostfixBurstDelegate([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int srcIndexCount);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		internal static class ZTCBZSUMVOJ
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8AB8D20", Offset = "0x8AB7920", VA = "0x188AB8D20")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8AB8EB0", Offset = "0x8AB7AB0", VA = "0x188AB8EB0")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8AB8A30", Offset = "0x8AB7630", VA = "0x188AB8A30")]
			public unsafe static int Invoke([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int srcIndexCount)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void DecodeIndices_00000069$PostfixBurstDelegate([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int indexCount);

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		internal static class PJINWTPZQYX
		{
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8AB3080", Offset = "0x8AB1C80", VA = "0x188AB3080")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8AB3210", Offset = "0x8AB1E10", VA = "0x188AB3210")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8AB2DC0", Offset = "0x8AB19C0", VA = "0x188AB2DC0")]
			public unsafe static void Invoke([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int indexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DecodeNormal_0000006B$PostfixBurstDelegate([Out] float3 ret, ushort compressed);

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		internal static class REAIPQPYWLA
		{
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4820", Offset = "0x8AB3420", VA = "0x188AB4820")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8AB49B0", Offset = "0x8AB35B0", VA = "0x188AB49B0")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4600", Offset = "0x8AB3200", VA = "0x188AB4600")]
			public static void Invoke([Out] float3 ret, ushort compressed)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ushort EncodeNormal_0000006C$PostfixBurstDelegate([In] float3 newVal);

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		internal static class AXNEGWOWGMZ
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8A97F10", Offset = "0x8A96B10", VA = "0x188A97F10")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8A980A0", Offset = "0x8A96CA0", VA = "0x188A980A0")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8A97D00", Offset = "0x8A96900", VA = "0x188A97D00")]
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
		public bool HJSDDFNTWQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8A9CC40", Offset = "0x8A9B840", VA = "0x188A9CC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DIXKDRCPLSB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8A9BD70", Offset = "0x8A9A970", VA = "0x188A9BD70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void IWUVYCBEDFN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B2A0", Offset = "0x8A99EA0", VA = "0x188A9B2A0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9AFC0", Offset = "0x8A99BC0", VA = "0x188A9AFC0")]
		public static CompressedNativeMeshStruct Create(Allocator allocator, NativeMesh srcMesh)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9AA80", Offset = "0x8A99680", VA = "0x188A9AA80")]
		public static CompressedNativeMeshStruct Create(Allocator allocator, NativeArray<float3> srcVerts, NativeArray<float3> srcNormals, NativeArray<float2> srcUVs, NativeArray<float4> srcMaterialIndices, bool hasTangents, NativeArray<float4> srcTangents, NativeArray<int> srcIndices, int vertexCount, int firstVertex, int indexCount, int firstIndex)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A9C4C0", Offset = "0x8A9B0C0", VA = "0x188A9C4C0")]
		public void PWMBWOMWPCL(NativeMesh a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B5C0", Offset = "0x8A9A1C0", VA = "0x188A9B5C0")]
		public long FPXFLKNPMRV()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D4C0", Offset = "0x8A9C0C0", VA = "0x188A9D4C0")]
		public long UQRZWISDCFS(NativeMesh.UnityMeshFormat a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A9BDB0", Offset = "0x8A9A9B0", VA = "0x188A9BDB0")]
		private void LGCZUKOKWZK(int a, int b, Allocator c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D3D0", Offset = "0x8A9BFD0", VA = "0x188A9D3D0")]
		private void UOFCWNIEHRE(NativeArray<float3> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D4B0", Offset = "0x8A9C0B0", VA = "0x188A9D4B0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllVerts_00000036$PostfixBurstDelegate))]
		private unsafe static void UOFCWNIEHRE([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int a, [In] float3 vertMin, [In] float3 vertScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A9CAA0", Offset = "0x8A9B6A0", VA = "0x188A9CAA0")]
		private void QVRQZBTAJBA(NativeArray<float3> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8A9CA90", Offset = "0x8A9B690", VA = "0x188A9CA90")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllVerts_0000003D$PostfixBurstDelegate))]
		private unsafe static void QVRQZBTAJBA([NoAlias] ushort* dstVerts, [Out] float3 a, [Out] float3 b, [In][NoAlias] float3* srcVerts, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8A9C190", Offset = "0x8A9AD90", VA = "0x188A9C190")]
		private void PDJESYBDBAG(NativeArray<float3> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8A9C270", Offset = "0x8A9AE70", VA = "0x188A9C270")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllNormals_0000003F$PostfixBurstDelegate))]
		private unsafe static void PDJESYBDBAG([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A9B0", Offset = "0x8A995B0", VA = "0x188A9A9B0")]
		private void CYHEDEEOTEC(NativeArray<float3> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A9AA70", Offset = "0x8A99670", VA = "0x188A9AA70")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllNormals_00000041$PostfixBurstDelegate))]
		private unsafe static void CYHEDEEOTEC([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D550", Offset = "0x8A9C150", VA = "0x188A9D550")]
		private void VSYBLSNVIYS(NativeArray<float2> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D640", Offset = "0x8A9C240", VA = "0x188A9D640")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllUVs_00000048$PostfixBurstDelegate))]
		private unsafe static void VSYBLSNVIYS([NoAlias] uint* dstUVs, [Out] float2 a, [Out] float2 b, [In][NoAlias] float2* srcUVs, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9DF60", Offset = "0x8A9CB60", VA = "0x188A9DF60")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetUV_00000049$PostfixBurstDelegate))]
		private static void ZYRNPMLQSFG([Out] float2 a, uint b, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9BC70", Offset = "0x8A9A870", VA = "0x188A9BC70")]
		private void JUJHWBJYBEC(NativeArray<float2> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8A9BD60", Offset = "0x8A9A960", VA = "0x188A9BD60")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllUVs_0000004B$PostfixBurstDelegate))]
		private unsafe static void JUJHWBJYBEC([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int a, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A640", Offset = "0x8A99240", VA = "0x188A9A640")]
		private void BSERCTDICIM(NativeArray<float4> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A740", Offset = "0x8A99340", VA = "0x188A9A740")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllTangents_00000052$PostfixBurstDelegate))]
		private unsafe static void BSERCTDICIM([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A9DBB0", Offset = "0x8A9C7B0", VA = "0x188A9DBB0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetTangent_00000053$PostfixBurstDelegate))]
		private static ushort XZPAHIYUSEA([In] float4 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D310", Offset = "0x8A9BF10", VA = "0x188A9D310")]
		private void SUXCUGBKYPK(NativeArray<float4> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D300", Offset = "0x8A9BF00", VA = "0x188A9D300")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllTangents_00000055$PostfixBurstDelegate))]
		private unsafe static void SUXCUGBKYPK([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B4E0", Offset = "0x8A9A0E0", VA = "0x188A9B4E0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetTangent_0000005B$PostfixBurstDelegate))]
		private static void EQGUZXGWGIE([Out] float4 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8A9CC80", Offset = "0x8A9B880", VA = "0x188A9CC80")]
		private void RSVQJGXMSJA(Allocator a, NativeArray<float4> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D080", Offset = "0x8A9BC80", VA = "0x188A9D080")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.CreateAllMaterialIndices_0000005D$PostfixBurstDelegate))]
		private unsafe static void RSVQJGXMSJA([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int a, [Out] int b, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B3E0", Offset = "0x8A99FE0", VA = "0x188A9B3E0")]
		private static void EHPHFYGMQGP(NativeArray<float4> a, NativeArray<MaterialIndex> b, NativeArray<byte> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B3D0", Offset = "0x8A99FD0", VA = "0x188A9B3D0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeMaterialIndices_0000005F$PostfixBurstDelegate))]
		private unsafe static void EHPHFYGMQGP([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A520", Offset = "0x8A99120", VA = "0x188A9A520")]
		private void ADQKEZVLYYB(Allocator a, NativeArray<int> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9DBC0", Offset = "0x8A9C7C0", VA = "0x188A9DBC0")]
		private static NativeArray<byte> YNROXEWTVYY(Allocator a, NativeArray<int> b, int c)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9DE70", Offset = "0x8A9CA70", VA = "0x188A9DE70")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.EncodeIndices_00000067$PostfixBurstDelegate))]
		private unsafe static int YNROXEWTVYY([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D090", Offset = "0x8A9BC90", VA = "0x188A9D090")]
		private static void RZXNSPEUOTW(NativeArray<int> a, NativeArray<byte> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D150", Offset = "0x8A9BD50", VA = "0x188A9D150")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeIndices_00000069$PostfixBurstDelegate))]
		private unsafe static void RZXNSPEUOTW([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B3C0", Offset = "0x8A99FC0", VA = "0x188A9B3C0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeNormal_0000006B$PostfixBurstDelegate))]
		private static void ECGDRTCPOPS([Out] float3 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D160", Offset = "0x8A9BD60", VA = "0x188A9D160")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.EncodeNormal_0000006C$PostfixBurstDelegate))]
		private static ushort SBPNRIXQDYU([In] float3 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A97090", Offset = "0x8A95C90", VA = "0x188A97090")]
		[BurstCompile]
		public unsafe static void TAMKIXRLDDH([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int a, [In] float3 vertMin, [In] float3 vertScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B6C0", Offset = "0x8A9A2C0", VA = "0x188A9B6C0")]
		[BurstCompile]
		public unsafe static void GVNOYOHWSYN([NoAlias] ushort* dstVerts, [Out] float3 a, [Out] float3 b, [In][NoAlias] float3* srcVerts, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8A9C0F0", Offset = "0x8A9ACF0", VA = "0x188A9C0F0")]
		[BurstCompile]
		public unsafe static void OWCMAIMCROR([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8A9BA90", Offset = "0x8A9A690", VA = "0x188A9BA90")]
		[BurstCompile]
		public unsafe static void HLJPXHPKMIN([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8A9C800", Offset = "0x8A9B400", VA = "0x188A9C800")]
		[BurstCompile]
		public unsafe static void QKNJAGYJBSJ([NoAlias] uint* dstUVs, [Out] float2 a, [Out] float2 b, [In][NoAlias] float2* srcUVs, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8A9BEE0", Offset = "0x8A9AAE0", VA = "0x188A9BEE0")]
		[BurstCompile]
		public static void NPHBZXFBOCD([Out] float2 a, uint b, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8A9DE80", Offset = "0x8A9CA80", VA = "0x188A9DE80")]
		[BurstCompile]
		public unsafe static void ZFQQVQAWNIB([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int a, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D170", Offset = "0x8A9BD70", VA = "0x188A9D170")]
		[BurstCompile]
		public unsafe static void SIFVYTVKMNR([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B4F0", Offset = "0x8A9A0F0", VA = "0x188A9B4F0")]
		[BurstCompile]
		public static ushort ETEGAHJOKLR([In] float4 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9CB90", Offset = "0x8A9B790", VA = "0x188A9CB90")]
		[BurstCompile]
		public unsafe static void RBMAGVGJOIH([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A750", Offset = "0x8A99350", VA = "0x188A9A750")]
		[BurstCompile]
		public static void BZCDEHPLHAH([Out] float4 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D650", Offset = "0x8A9C250", VA = "0x188A9D650")]
		[BurstCompile]
		public unsafe static void VWZPQKRPJGZ([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int a, [Out] int b, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9BF20", Offset = "0x8A9AB20", VA = "0x188A9BF20")]
		[BurstCompile]
		public unsafe static void OTMZJYIVHNU([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A9BB40", Offset = "0x8A9A740", VA = "0x188A9BB40")]
		[BurstCompile]
		public unsafe static int IOGPQDIZUNJ([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D210", Offset = "0x8A9BE10", VA = "0x188A9D210")]
		[BurstCompile]
		public unsafe static void SKVRAKBBCED([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A810", Offset = "0x8A99410", VA = "0x188A9A810")]
		[BurstCompile]
		public static void CTUANUTBAKD([Out] float3 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A9C280", Offset = "0x8A9AE80", VA = "0x188A9C280")]
		[BurstCompile]
		public static ushort PINSMYWSPBB([In] float3 newVal)
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
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			FullFloat32,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			NormTanMatF16,
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			NormTanSn8MatF16,
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			NormTanSn8UvMatF16,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			NormTanOct8MatUi,
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			PosFixedPoint16NormTanOct8MatUi,
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			LAST
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum VertexFormatKeyword
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			_,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			_VERTEX_FORMAT_NORMTANOCT8_MATUINT,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			_VERTEX_FORMAT_POSFIXED16_NORMTANOCT8_MATUINT,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			LAST
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public struct UnityMeshFormatInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public UnityMeshFormat format;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool validOnThisPlatform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public int sizeInBytes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[BurstCompile]
		public struct VertexFormat_FullFloat32
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public float3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public float3 normal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public float4 tangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public float2 texUVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public float4 materialIndices;

			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[BurstCompile]
		public struct VertexFormat_NormTanMatF16
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public float3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public half4 normal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public half4 tangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float2 texUVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public half4 materialIndices;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[BurstCompile]
		public struct VertexFormat_NormTanSn8MatF16
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public uint normal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public uint tangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float2 texUVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public half4 materialIndices;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[BurstCompile]
		public struct VertexFormat_NormTanSn8UvMatF16
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public float3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public uint normal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public uint tangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public half2 texUVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public half4 materialIndices;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[BurstCompile]
		public struct VertexFormat_NormTanOct8MatUi
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public uint normalTangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float2 texUVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public uint colorMaterialScaleBitangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public uint bone;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[BurstCompile]
		public struct VertexFormat_PosFixedPoint16NormTanOct8MatUi
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public VertexCompressor.CompressedPositionFixedPoint16 positionBone;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public uint normalTangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public float2 texUVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public uint colorMaterialScaleBitangent;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly VertexAttributeDescriptor[] vertexLayout;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int FloatToSnorm8_00000082$PostfixBurstDelegate(float x);

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		internal static class JWQQYHVNKMD
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8AA67A0", Offset = "0x8AA53A0", VA = "0x188AA67A0")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8AA6920", Offset = "0x8AA5520", VA = "0x188AA6920")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x8AA6510", Offset = "0x8AA5110", VA = "0x188AA6510")]
			public static int Invoke(float x)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate uint FloatToSnorm8_00000083$PostfixBurstDelegate([In] float4 v);

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		internal static class PZFYARLOMIQ
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x8AB3D10", Offset = "0x8AB2910", VA = "0x188AB3D10")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x8AB3EA0", Offset = "0x8AB2AA0", VA = "0x188AB3EA0")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8AB3A80", Offset = "0x8AB2680", VA = "0x188AB3A80")]
			public static uint Invoke([In] float4 v)
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate uint FloatToSnorm8_00000084$PostfixBurstDelegate([In] float3 v);

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		internal static class YYCJYQNDSCZ
		{
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x8AB8720", Offset = "0x8AB7320", VA = "0x188AB8720")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8AB88B0", Offset = "0x8AB74B0", VA = "0x188AB88B0")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8AB84B0", Offset = "0x8AB70B0", VA = "0x188AB84B0")]
			public static uint Invoke([In] float3 v)
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetupVertices_NormTanSn8MatF16_00000086$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		internal static class WPUMLLLOAFR
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x8AB64B0", Offset = "0x8AB50B0", VA = "0x188AB64B0")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8AB6640", Offset = "0x8AB5240", VA = "0x188AB6640")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8AB60B0", Offset = "0x8AB4CB0", VA = "0x188AB60B0")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetupVertices_NormTanSn8UvMatF16_00000088$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		internal static class PMJPZOZIXHS
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8AB3770", Offset = "0x8AB2370", VA = "0x188AB3770")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8AB3900", Offset = "0x8AB2500", VA = "0x188AB3900")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8AB3390", Offset = "0x8AB1F90", VA = "0x188AB3390")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetupVertices_NormTanOct8MatUi_0000008B$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		internal static class DUQGZBWOHLX
		{
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8AA4810", Offset = "0x8AA3410", VA = "0x188AA4810")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8AA49A0", Offset = "0x8AA35A0", VA = "0x188AA49A0")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8AA4400", Offset = "0x8AA3000", VA = "0x188AA4400")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetupVertices_PosFixedPoint16NormTanOct8MatUi_0000008D$PostfixBurstDelegate([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 positionMin, [Out] float3 positionMax);

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		internal static class QUXAFUHAGHO
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8AB42F0", Offset = "0x8AB2EF0", VA = "0x188AB42F0")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4480", Offset = "0x8AB3080", VA = "0x188AB4480")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4020", Offset = "0x8AB2C20", VA = "0x188AB4020")]
			public unsafe static void Invoke([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 positionMin, [Out] float3 positionMax)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const int GIZYOKWXSFW = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public NativeList<float3> VLKCTEZMDAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NativeArray<float3> SXLDFZGZQTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NativeArray<float4> XPBGGBLKWBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NativeArray<float4> SSLBWSZZEJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public NativeArray<float2> NFSIZFUUOVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public NativeList<int> ZHIHIFSTFVU;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly VertexAttributeDescriptor[][] YUVIMYQMCHU;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static bool OYTMAQGCDYZ;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static UnityMeshFormatInfo[] ZCEACKYFYFW;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool HJSDDFNTWQO
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFA00", Offset = "0x8AAE600", VA = "0x188AAFA00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int AHEYVLULPIK
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1790", Offset = "0x8AB0390", VA = "0x188AB1790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int BVPSOKKTXZM
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8AAB900", Offset = "0x8AAA500", VA = "0x188AAB900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool DIXKDRCPLSB
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8AAC900", Offset = "0x8AAB500", VA = "0x188AAC900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void IWUVYCBEDFN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void IWUVYCBEDFN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void KFKCZHYVWEG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void KFKCZHYVWEG(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8AB0930", Offset = "0x8AAF530", VA = "0x188AB0930")]
		public static VertexFormatKeyword TXSELGGWQHP(UnityMeshFormat a)
		{
			return default(VertexFormatKeyword);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8AB0800", Offset = "0x8AAF400", VA = "0x188AB0800")]
		public static void TSZZDDAODXX(VertexFormatKeyword a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8AAB9B0", Offset = "0x8AAA5B0", VA = "0x188AAB9B0", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC940", Offset = "0x8AAB540", VA = "0x188AAC940")]
		public void LGCZUKOKWZK(int a, int b, Allocator c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFBE0", Offset = "0x8AAE7E0", VA = "0x188AAFBE0")]
		public void SFXICMODZUH(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8AB0910", Offset = "0x8AAF510", VA = "0x188AB0910", Slot = "6")]
		public bool TUXQAQOYRBR(Mesh a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8AB09D0", Offset = "0x8AAF5D0", VA = "0x188AB09D0")]
		public bool UCINBZJRGVO(Mesh a, bool b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8AAE4D0", Offset = "0x8AAD0D0", VA = "0x188AAE4D0")]
		public bool PIGKLDFYKCA(Mesh a, NativeMesh b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8AB22D0", Offset = "0x8AB0ED0", VA = "0x188AB22D0")]
		public bool WYFAYMIRUGL(Mesh a, NativeMesh b, UnityMeshFormat c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8AAEF90", Offset = "0x8AADB90", VA = "0x188AAEF90")]
		private void QEROPGJUOMA(Mesh a, NativeMesh b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8AAEC00", Offset = "0x8AAD800", VA = "0x188AAEC00")]
		public void QEROPGJUOMA(NativeArray<ushort> a, NativeArray<VertexFormat_NormTanOct8MatUi> b, Mesh c, NativeMesh d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8AB17F0", Offset = "0x8AB03F0", VA = "0x188AB17F0")]
		public void VVAMIHVZONU(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC600", Offset = "0x8AAB200", VA = "0x188AAC600")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000082$PostfixBurstDelegate))]
		public static int GMZKLXUFMRD(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC610", Offset = "0x8AAB210", VA = "0x188AAC610")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000083$PostfixBurstDelegate))]
		public static uint GMZKLXUFMRD([In] float4 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC5F0", Offset = "0x8AAB1F0", VA = "0x188AAC5F0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000084$PostfixBurstDelegate))]
		public static uint GMZKLXUFMRD([In] float3 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8AADD90", Offset = "0x8AAC990", VA = "0x188AADD90")]
		public void ONEZBUESDJF(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC260", Offset = "0x8AAAE60", VA = "0x188AAC260")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanSn8MatF16_00000086$PostfixBurstDelegate))]
		private unsafe static void FWQTHBJRILT([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8AACDD0", Offset = "0x8AAB9D0", VA = "0x188AACDD0")]
		public void LZJIGUEXIFO(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8AAF7E0", Offset = "0x8AAE3E0", VA = "0x188AAF7E0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanSn8UvMatF16_00000088$PostfixBurstDelegate))]
		private unsafe static void RCRCKYXIUZY([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD970", Offset = "0x8AAC570", VA = "0x188AAD970")]
		public void NDZWLBCEGSN(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD510", Offset = "0x8AAC110", VA = "0x188AAD510")]
		public void NDZWLBCEGSN(NativeArray<ushort> a, NativeArray<VertexFormat_NormTanOct8MatUi> b, Mesh c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8AB17E0", Offset = "0x8AB03E0", VA = "0x188AB17E0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanOct8MatUi_0000008B$PostfixBurstDelegate))]
		public unsafe static void VFNGAJDNXBZ([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFF90", Offset = "0x8AAEB90", VA = "0x188AAFF90")]
		public void TORGFGRIJII(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC8F0", Offset = "0x8AAB4F0", VA = "0x188AAC8F0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_PosFixedPoint16NormTanOct8MatUi_0000008D$PostfixBurstDelegate))]
		private unsafe static void KVKYSVVWYIW([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 b, [Out] float3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFCC0", Offset = "0x8AAE8C0", VA = "0x188AAFCC0")]
		public void SIGYAHYSGZG(Mesh a, UnityMeshFormat b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8AACAF0", Offset = "0x8AAB6F0", VA = "0x188AACAF0")]
		public void LXGOPHQEQBX(NativeMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFE70", Offset = "0x8AAEA70", VA = "0x188AAFE70")]
		public void SUSWBABGPQA(NativeMesh a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC0D0", Offset = "0x8AAACD0", VA = "0x188AAC0D0")]
		public long FPXFLKNPMRV()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC200", Offset = "0x8AAAE00", VA = "0x188AAC200")]
		public static long FPXFLKNPMRV(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1610", Offset = "0x8AB0210", VA = "0x188AB1610")]
		public static long UQRZWISDCFS(int a, int b, UnityMeshFormat c)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8AB16B0", Offset = "0x8AB02B0", VA = "0x188AB16B0")]
		public long UQRZWISDCFS(UnityMeshFormat a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8AAB950", Offset = "0x8AAA550", VA = "0x188AAB950")]
		public void DLAZCMIUUZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8AABAB0", Offset = "0x8AAA6B0", VA = "0x188AABAB0")]
		public static void EGTKLROMWNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8AB0E40", Offset = "0x8AAFA40", VA = "0x188AB0E40")]
		public UnityMeshFormat UODERVTGEMP()
		{
			return default(UnityMeshFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8AAB830", Offset = "0x8AAA430", VA = "0x188AAB830")]
		public static (int, int) ARBJJMIRJKX(Mesh a)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC620", Offset = "0x8AAB220", VA = "0x188AAC620")]
		public static int HQBZQRMGCVS(VertexAttributeDescriptor[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFA40", Offset = "0x8AAE640", VA = "0x188AAFA40")]
		public static long RTEINUCKUIJ(Mesh a, int b, int c)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFAB0", Offset = "0x8AAE6B0", VA = "0x188AAFAB0")]
		public static long RTEINUCKUIJ(Mesh a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public NativeMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8AB20E0", Offset = "0x8AB0CE0", VA = "0x188AB20E0")]
		[BurstCompile]
		public static int WOMKVFMCRLS(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8AB2210", Offset = "0x8AB0E10", VA = "0x188AB2210")]
		[BurstCompile]
		public static uint WOMKVFMCRLS([In] float4 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8AB2190", Offset = "0x8AB0D90", VA = "0x188AB2190")]
		[BurstCompile]
		public static uint WOMKVFMCRLS([In] float3 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8AAF7F0", Offset = "0x8AAE3F0", VA = "0x188AAF7F0")]
		[BurstCompile]
		public unsafe static void RRTYESBSWNG([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC700", Offset = "0x8AAB300", VA = "0x188AAC700")]
		[BurstCompile]
		public unsafe static void JXJPBHLRWEJ([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8AAEA00", Offset = "0x8AAD600", VA = "0x188AAEA00")]
		[BurstCompile]
		public unsafe static void QENXQECEFZA([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC270", Offset = "0x8AAAE70", VA = "0x188AAC270")]
		[BurstCompile]
		public unsafe static void GFJNXNOZPHT([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 b, [Out] float3 c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct PrimitiveShapeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int PrimitiveMeshIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public float3 PositionWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public quaternion RotationWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public float3 SizeWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int Bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float UVScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float3 UVOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public bool DynamicProjection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public BevelScalingMode ScalingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public float3 ScalingRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public float AuthoredBevelRatio;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class BAEZTLIQVHX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public static GUXUNCBORUZ GUXUNCBORUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NativeList<PrimitiveShapeData> JNZHLXUEJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public NativeList<MeshPartInfo> YZXDFEMWIRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public NativeList<CurveShapeRootData> IXOBSQBVOTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public NativeArray<CurvePointData> JCUDVGLSTYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NativeList<MeshPartInfo> DUGZVJGPBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public NativeList<CurvePointOffset> MJMNHIGADPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private List<NativeArray<CurvePointData>> FXEHUYMJBBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private NativeList<OcclusionData> XAAGJDZWKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private NativeArray<int> QIPYQFECGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private NativeArray<int> BJUYJRTIIAY;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static NativeList<ShapeBatch.CollapseEntry> QPGJOTIWYOQ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int AHEYVLULPIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xB3B690", Offset = "0xB3A290", VA = "0x180B3B690")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x16D8450", Offset = "0x16D7050", VA = "0x1816D8450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int BVPSOKKTXZM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xB3B6F0", Offset = "0xB3A2F0", VA = "0x180B3B6F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x16D8440", Offset = "0x16D7040", VA = "0x1816D8440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A320", Offset = "0x8A98F20", VA = "0x188A9A320")]
		public BAEZTLIQVHX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A98400", Offset = "0x8A97000", VA = "0x188A98400", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A98220", Offset = "0x8A96E20", VA = "0x188A98220")]
		public void Dispose(JobHandle jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A090", Offset = "0x8A98C90", VA = "0x188A9A090")]
		public void WJUHWXYIICJ(PrimitiveShapeData a, OcclusionData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A98990", Offset = "0x8A97590", VA = "0x188A98990")]
		public void ODEUBIVPJWH(CurveShapeRootData a, NativeArray<CurvePointData> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8A98DB0", Offset = "0x8A979B0", VA = "0x188A98DB0")]
		public JobHandle VDLHARPHTWE(NativeMesh a, MWSUROXMZRO b, float3 c, quaternion d, float e, bool f, int g = 0, int h = 0)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8A98ED0", Offset = "0x8A97AD0", VA = "0x188A98ED0")]
		public JobHandle VDLHARPHTWE(NativeMesh a, MWSUROXMZRO b, NativeList<ShapeBatch.CollapseEntry> c, float3 d, quaternion e, float f, bool g, bool h, int i = 0, int j = 0)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8A985D0", Offset = "0x8A971D0", VA = "0x188A985D0")]
		public static JobHandle MXISIUTDIJT(PrimitiveMeshGeneratorData a, NativeMesh b, NativeArray<int> c, PrimitiveShapeData d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8A98AC0", Offset = "0x8A976C0", VA = "0x188A98AC0")]
		public static JobHandle OMUKUMAYWGD(CurveMeshGeneratorData a, NativeMesh b, CurveShapeRootData c, NativeArray<CurvePointData> d, int e, int f, JobHandle g)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class CrowdBatch
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal struct SingleMeshData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public MeshRenderer renderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public KZVKLBVBMAH.MinimalMeshData meshData;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x59725E0", Offset = "0x59711E0", VA = "0x1859725E0")]
			public SingleMeshData(MeshRenderer renderer, KZVKLBVBMAH.MinimalMeshData meshData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8AB53B0", Offset = "0x8AB3FB0", VA = "0x188AB53B0")]
			public static implicit operator SingleMeshData((MeshRenderer, KZVKLBVBMAH.MinimalMeshData) tuple)
			{
				return default(SingleMeshData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly ProfilerMarker QPXABYOYFNG;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly ProfilerMarker RVBYRXRGWFO;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static readonly ProfilerMarker IJGGZFFYMUH;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly ProfilerMarker NHYONWIMPDN;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8A9E120", Offset = "0x8A9CD20", VA = "0x188A9E120")]
		internal void DIIUMVZLOQZ(GameObject a, KZVKLBVBMAH.CrowdAABB b, List<SingleMeshData> c, Material d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8A9E970", Offset = "0x8A9D570", VA = "0x188A9E970")]
		internal void DMKYJWBWLTH(GameObject a, KZVKLBVBMAH.CrowdAABB b, List<SingleMeshData> c, List<LODGroup> d, Material e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8AA0010", Offset = "0x8A9EC10", VA = "0x188AA0010")]
		private MeshRenderer URVTYXQVSLY(KZVKLBVBMAH.CrowdAABB a, Material b, List<SingleMeshData> c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F190", Offset = "0x8A9DD90", VA = "0x188A9F190")]
		private List<(List<SingleMeshData>, float)> ICAMOLROQLY(KZVKLBVBMAH.CrowdAABB a, List<LODGroup> b, Material c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8AA0CD0", Offset = "0x8A9F8D0", VA = "0x188AA0CD0")]
		private List<List<(List<SingleMeshData>, float)>> ZMIGOFIZTJR(KZVKLBVBMAH.CrowdAABB a, List<LODGroup> b, Material c, [Out] int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public CrowdBatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8AA0B60", Offset = "0x8A9F760", VA = "0x188AA0B60")]
		[CompilerGenerated]
		internal static (float, int) VTUJFONTWLW(List<List<(List<SingleMeshData> meshList, float lodTransition)>> gathered, int[] a)
		{
			return default((float, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class CrowdOptimizer
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly ProfilerMarker EABGVXBZAEN;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static readonly ProfilerMarker UZPVFOZHQLS;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly ProfilerMarker MNPAAAHKPHU;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly ProfilerMarker UUVOSKHKTPZ;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly ProfilerMarker EEYCPZWDJHI;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static readonly ProfilerMarker NJBADKCOLTZ;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly ProfilerMarker VOAWLVCITQL;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly Log DDTXKXBXKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private KZVKLBVBMAH YLJBBGXEMTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private CrowdBatch ESWSJWGLJDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Shader JJSBFXIZCUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private MaterialPropertyBlock KVKBUTASJRJ;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2470", Offset = "0x8AA1070", VA = "0x188AA2470")]
		public static void FJTPAYHZOUX(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8AA29D0", Offset = "0x8AA15D0", VA = "0x188AA29D0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8AA27B0", Offset = "0x8AA13B0", VA = "0x188AA27B0")]
		public void ITMISAFYGPQ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8AA3330", Offset = "0x8AA1F30", VA = "0x188AA3330")]
		private bool OPLBNVJGMLD(MeshRenderer a, [Out] MeshFilter b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8AA39F0", Offset = "0x8AA25F0", VA = "0x188AA39F0")]
		private bool RLOLXDYUQHK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8AA3120", Offset = "0x8AA1D20", VA = "0x188AA3120")]
		private void JQBBHTVNUKZ(GameObject a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8AA1C00", Offset = "0x8AA0800", VA = "0x188AA1C00")]
		private List<CrowdBatch.SingleMeshData> BRMOEBUFOQA(int a, [Out] List<LODGroup> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8AA34B0", Offset = "0x8AA20B0", VA = "0x188AA34B0")]
		private List<(int, Material)> QHLFXGYUKIJ(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8AA23C0", Offset = "0x8AA0FC0", VA = "0x188AA23C0")]
		public void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8AA3BF0", Offset = "0x8AA27F0", VA = "0x188AA3BF0")]
		private bool ZTOKBPOSMUV(GameObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8AA43A0", Offset = "0x8AA2FA0", VA = "0x188AA43A0")]
		public CrowdOptimizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[BurstCompile]
	public class KZVKLBVBMAH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[GenerateTestsForBurstCompatibility]
		public struct CrowdAABB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public float3 max;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public float3 min;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public float surfaceArea;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8AC1400", Offset = "0x8AC0000", VA = "0x188AC1400")]
			public CrowdAABB(Bounds bounds)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8AC12F0", Offset = "0x8ABFEF0", VA = "0x188AC12F0")]
			public CrowdAABB(float3 max, float3 min)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[GenerateTestsForBurstCompatibility]
		public struct Node
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public CrowdAABB boundingBox;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public int meshRendererIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int meshDataIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public float fitScore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int numVerts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public int lodDataIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public int parentIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int child1Index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int child2Index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public bool isLeaf;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct MinimalMeshData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public Mesh Mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public Matrix4x4 WorldFromLocalMatrix;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public int SubMeshIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[BurstCompile]
		private struct GatherSADeltaJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			[ReadOnly]
			public NativeArray<Node> nodes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			[WriteOnly]
			public NativeArray<float> output;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public int startingIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public CrowdAABB bounds;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8AC3C30", Offset = "0x8AC2830", VA = "0x188AC3C30")]
			private float NPVQKIKIKGT(CrowdAABB a, CrowdAABB b)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8AC3A20", Offset = "0x8AC2620", VA = "0x188AC3A20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly ProfilerMarker BBULVXINVSJ;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static readonly ProfilerMarker SXVCFLGHFDT;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly ProfilerMarker BBFSZMOFELJ;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static readonly ProfilerMarker CLHNXGMJVAS;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly ProfilerMarker NQSLUBYQFTV;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly ProfilerMarker YRXMDABXNGR;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly ProfilerMarker MNKQCZQXOOR;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly ProfilerMarker ACHZGZUFZJD;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static readonly ProfilerMarker PXOYEXVDAMD;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static readonly ProfilerMarker AOSZYEZLSJH;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly ProfilerMarker HVAPMWOBCZK;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private static readonly ProfilerMarker IFERJRFMQYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public NativeArray<Node> EHSPZGOOVLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public NativeQueue<int> QNYTFAASTEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public int XGIVZOSEHIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Dictionary<Material, int> TGWTBLEZVJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public List<MinimalMeshData> HIIYWFEQYNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public List<LODGroup> PKWUDTMVEUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Dictionary<int, MeshRenderer> LCAQONTVEXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private Queue<int> WSSPSNKMTUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private Shader FHCWZOISZMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Shader CLNTPOTHRTO;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8AAA630", Offset = "0x8AA9230", VA = "0x188AAA630")]
		public KZVKLBVBMAH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8AA7210", Offset = "0x8AA5E10", VA = "0x188AA7210")]
		private void HNULMDLVSIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8AA8030", Offset = "0x8AA6C30", VA = "0x188AA8030")]
		public bool SCPHTHRESPO(MeshRenderer a, MeshFilter b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8AA84A0", Offset = "0x8AA70A0", VA = "0x188AA84A0")]
		public bool SCPHTHRESPO(LODGroup a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8AA6B50", Offset = "0x8AA5750", VA = "0x188AA6B50")]
		private bool Contains(MeshRenderer meshRenderer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8AA76C0", Offset = "0x8AA62C0", VA = "0x188AA76C0")]
		private int OUQOVWMHZQO(MeshRenderer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8AA6A90", Offset = "0x8AA5690", VA = "0x188AA6A90")]
		private int CWUDJYLPCBQ(LODGroup a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8AAA1E0", Offset = "0x8AA8DE0", VA = "0x188AAA1E0")]
		private int ZJUDVWNUHHX(MeshFilter a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8AA94F0", Offset = "0x8AA80F0", VA = "0x188AA94F0")]
		private int SYOIUDIBMBZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8AA9820", Offset = "0x8AA8420", VA = "0x188AA9820")]
		private static CrowdAABB VQLJGSTVWEM(CrowdAABB a, CrowdAABB b)
		{
			return default(CrowdAABB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8AA7380", Offset = "0x8AA5F80", VA = "0x188AA7380")]
		private static float IVYDKBVPMMN(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8AA91E0", Offset = "0x8AA7DE0", VA = "0x188AA91E0")]
		private int SJILHWJHYBN(int a, CrowdAABB b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8AA9FB0", Offset = "0x8AA8BB0", VA = "0x188AA9FB0")]
		private void ZFYBKWMQCUO(CrowdAABB a, int b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8AA9B40", Offset = "0x8AA8740", VA = "0x188AA9B40")]
		private void VZWXXSRQQSJ(CrowdAABB a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8AA74A0", Offset = "0x8AA60A0", VA = "0x188AA74A0")]
		private float NPVQKIKIKGT(CrowdAABB a, CrowdAABB b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8AA77E0", Offset = "0x8AA63E0", VA = "0x188AA77E0")]
		private void REKMPRTLQRJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8AA7C00", Offset = "0x8AA6800", VA = "0x188AA7C00")]
		private void Rotate(int indexA, int indexB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8AA6C80", Offset = "0x8AA5880", VA = "0x188AA6C80")]
		private void GLHSMZBMZFJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8AA6BD0", Offset = "0x8AA57D0", VA = "0x188AA6BD0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct RingVertex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float2 Offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public float2 Normal;
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class OXNPXNSLYNK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public NativeArray<RingVertex> SENXPGGQWKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public NativeArray<int> TLFUDJKONNC;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int AHEYVLULPIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int BVPSOKKTXZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB30", Offset = "0xB1E730", VA = "0x180B1FB30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4310", Offset = "0x8AC2F10", VA = "0x188AC4310")]
		public OXNPXNSLYNK(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8AC41D0", Offset = "0x8AC2DD0", VA = "0x188AC41D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4230", Offset = "0x8AC2E30", VA = "0x188AC4230")]
		public void LXGOPHQEQBX(OXNPXNSLYNK a, int b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class YNYZVHQBWGZ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static OXNPXNSLYNK QGUSNMZDLXM;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static NativeList<MeshPartInfo> WFOCMHCJBHG;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static int[] MGMHUIIEOVR;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static bool JWMDYIHNCPF;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static Dictionary<int, OXNPXNSLYNK> UHHPOKRZFIP;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static Dictionary<int, OXNPXNSLYNK> IXLNYNTOMNU;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool AWYVHQAKNJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8ACCE80", Offset = "0x8ACBA80", VA = "0x188ACCE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static NativeList<MeshPartInfo> PVULWJBMAJY
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8ACC440", Offset = "0x8ACB040", VA = "0x188ACC440")]
			get
			{
				return default(NativeList<MeshPartInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static OXNPXNSLYNK DPWVWEDJBPU
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x8ACCF90", Offset = "0x8ACBB90", VA = "0x188ACCF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACC4D0", Offset = "0x8ACB0D0", VA = "0x188ACC4D0")]
		private static void BUSCYFJGJOS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8ACDAD0", Offset = "0x8ACC6D0", VA = "0x188ACDAD0")]
		public static int YYVRFJTGCXO(bool a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACD0C0", Offset = "0x8ACBCC0", VA = "0x188ACD0C0")]
		private static int LWEICKPSNTK(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8ACCE60", Offset = "0x8ACBA60", VA = "0x188ACCE60")]
		private static int EVGPQXKHGGJ(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8ACCF00", Offset = "0x8ACBB00", VA = "0x188ACCF00")]
		public static int GRIVTUNDISS(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8ACD030", Offset = "0x8ACBC30", VA = "0x188ACD030")]
		public static int KEMZSVNYFPT(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8ACDAC0", Offset = "0x8ACC6C0", VA = "0x188ACDAC0")]
		public static int XCYGZKUQDHG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8ACCE70", Offset = "0x8ACBA70", VA = "0x188ACCE70")]
		private static int FSUVZIZCAKU(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8ACD8A0", Offset = "0x8ACC4A0", VA = "0x188ACD8A0")]
		private static int QDEIKYELBRF(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8ACD4F0", Offset = "0x8ACC0F0", VA = "0x188ACD4F0")]
		public static int NBNDQTFWJHQ(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8ACCDD0", Offset = "0x8ACB9D0", VA = "0x188ACCDD0")]
		public static int EEXLJBSBOAT(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8ACD8C0", Offset = "0x8ACC4C0", VA = "0x188ACD8C0")]
		public static int SQLKVZEIBYQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8ACD8E0", Offset = "0x8ACC4E0", VA = "0x188ACD8E0")]
		public static OXNPXNSLYNK VHRMVWLDRXS(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACCB30", Offset = "0x8ACB730", VA = "0x188ACCB30")]
		private static OXNPXNSLYNK EAQLVXJDTDA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8ACD9D0", Offset = "0x8ACC5D0", VA = "0x188ACD9D0")]
		public static OXNPXNSLYNK WCMHFXORFAP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8ACD560", Offset = "0x8ACC160", VA = "0x188ACD560")]
		private static OXNPXNSLYNK OKQTJTUSISV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACD0E0", Offset = "0x8ACBCE0", VA = "0x188ACD0E0")]
		public static void MQSDZVFKBNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct CurveShapeRootData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int RingTypeIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float3 PositionWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public quaternion RotationWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float SizeWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public float HeightScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int Bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public bool Rounded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public bool Ribbon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public float UVScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public float3 UVOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public bool OldEndCaps;
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct CurvePointOffset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int StartPointIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int PointCount;
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct CurveMeshGeneratorData : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public NativeList<CurveShapeRootData> curveDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public NativeArray<CurvePointData> pointDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public NativeArray<MeshPartInfo> curveDests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public NativeArray<CurvePointOffset> curvePointOffsets;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1690", Offset = "0x8AC0290", VA = "0x188AC1690")]
		public CurveMeshGeneratorData(NativeArray<CurvePointData> pointDatas, int size = 1, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8AC15B0", Offset = "0x8AC01B0", VA = "0x188AC15B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[BurstCompile]
	public struct CreateNativeMeshFromBatchedCurvesJob : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[ReadOnly]
		private NativeArray<RingVertex> ringVertsBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[ReadOnly]
		private NativeArray<int> ringIndicesBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[ReadOnly]
		private NativeList<MeshPartInfo> ringParts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[ReadOnly]
		private NativeList<CurveShapeRootData> curveDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[ReadOnly]
		private NativeArray<CurvePointData> pointDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[ReadOnly]
		private NativeArray<MeshPartInfo> curveDests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[ReadOnly]
		public NativeArray<CurvePointOffset> curvePointOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[ReadOnly]
		private int destIndexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[ReadOnly]
		private int destVertexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[ReadOnly]
		private float3 rootScaleWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[ReadOnly]
		private quaternion rootRotWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[ReadOnly]
		private float3 rootPosWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float2> destUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> destIndices;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCFC0", Offset = "0x8ABBBC0", VA = "0x188ABCFC0")]
		public CreateNativeMeshFromBatchedCurvesJob(BAEZTLIQVHX batchedShapeData, NativeMesh destMesh, float3 rootPositionWS, quaternion rootRotationWS, float rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCDC0", Offset = "0x8ABB9C0", VA = "0x188ABCDC0")]
		public CreateNativeMeshFromBatchedCurvesJob(CurveMeshGeneratorData batchedShapeData, NativeMesh destMesh, float3 rootPositionWS, quaternion rootRotationWS, float3 rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC0C0", Offset = "0x8ABACC0", VA = "0x188ABC0C0")]
		private float3 IMVVZQOOBMP(float3 a, Matrix4x4 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCD40", Offset = "0x8ABB940", VA = "0x188ABCD40")]
		private float3x3 ZHAWMQXOOXK(float3x3 a, float3x3 b)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCD30", Offset = "0x8ABB930", VA = "0x188ABCD30")]
		private float YKYSXRUSGOP(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8ABAE30", Offset = "0x8AB9A30", VA = "0x188ABAE30", Slot = "4")]
		public void Execute(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC780", Offset = "0x8ABB380", VA = "0x188ABC780")]
		private void NPSQNNQOFHF(int a, float3 b, float3 c, float3 d, float e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC8F0", Offset = "0x8ABB4F0", VA = "0x188ABC8F0")]
		private void QTWWZWKJGFG(CurveShapeRootData a, float3 b, float3x3 c, float d, int e, int f, int g, float h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC200", Offset = "0x8ABAE00", VA = "0x188ABC200")]
		private void JVALAGCCPHE(int a, int b, CurveShapeRootData c, float3 d, float3x3 e, bool f, float g, int h, int i, int j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct PrimitiveMeshGeneratorData : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public NativeList<PrimitiveShapeData> shapeData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public NativeList<MeshPartInfo> shapeDest;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4F10", Offset = "0x8AC3B10", VA = "0x188AC4F10")]
		public PrimitiveMeshGeneratorData(int size, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4E90", Offset = "0x8AC3A90", VA = "0x188AC4E90", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[BurstCompile]
	public struct CreateNativeMeshFromShapeBatchJob : IJobFor
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private enum ProjectionAxis
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			X,
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			Y,
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			Z
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[ReadOnly]
		private NativeList<float3> srcVertsBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[ReadOnly]
		private NativeArray<float3> srcNormalsBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ReadOnly]
		private NativeList<int> srcIndicesBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[ReadOnly]
		private NativeArray<int> srcFaceIndicesBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[ReadOnly]
		private NativeArray<float4> srcTangentsXBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[ReadOnly]
		private NativeArray<float4> srcTangentsYBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[ReadOnly]
		private NativeArray<float4> srcTangentsZBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[ReadOnly]
		private NativeArray<int> srcVertCollapseTargetBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[ReadOnly]
		private NativeList<float3> srcFaceNormalsBatched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[ReadOnly]
		private NativeList<MeshPartInfo> srcInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[ReadOnly]
		private NativeList<PrimitiveShapeData> shapeData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[ReadOnly]
		private NativeList<MeshPartInfo> shapeDest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[ReadOnly]
		private int destIndexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[ReadOnly]
		private int destVertexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float2> destUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> destVertCollapseTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> destIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[ReadOnly]
		private float3 rootPosWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[ReadOnly]
		private quaternion rootRotWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ReadOnly]
		private float3 rootScaleWS;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0170", Offset = "0x8ABED70", VA = "0x188AC0170")]
		public CreateNativeMeshFromShapeBatchJob(BAEZTLIQVHX batchedShapeData, NativeMesh destMesh, NativeArray<int> destVertCollapseTargetIn, float3 rootPositionWS, quaternion rootRotationWS, float rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0380", Offset = "0x8ABEF80", VA = "0x188AC0380")]
		public CreateNativeMeshFromShapeBatchJob(PrimitiveMeshGeneratorData data, NativeMesh destMesh, NativeArray<int> destVertCollapseTargetIn, float3 rootPositionWS, quaternion rootRotationWS, float3 rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEBA0", Offset = "0x8ABD7A0", VA = "0x188ABEBA0", Slot = "4")]
		public void Execute(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFC70", Offset = "0x8ABE870", VA = "0x188ABFC70")]
		private void SNNYQXNMMRT(float4x4 a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0100", Offset = "0x8ABED00", VA = "0x188AC0100")]
		private ProjectionAxis VGNOINCSQAU(float3 a)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8AC00B0", Offset = "0x8ABECB0", VA = "0x188AC00B0")]
		private float4 VGKQHGMTGZO(ProjectionAxis a, int b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFC30", Offset = "0x8ABE830", VA = "0x188ABFC30")]
		private float2 MJGGMIECPTS(ProjectionAxis a, float3 b)
		{
			return default(float2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct CurveData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public float HeightScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public float4 MaterialAndColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int RingPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public bool Rounded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public bool Ribbon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public float UVScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public float3 UVOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public bool OldEndCaps;
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[BurstCompile]
	public struct CreateNativeMeshFromCurveJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[ReadOnly]
		private NativeArray<RingVertex> ringVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[ReadOnly]
		private NativeArray<int> ringIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[ReadOnly]
		private NativeList<CurvePointData> pointData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[ReadOnly]
		private CurveData curveData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[ReadOnly]
		private float rootScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[ReadOnly]
		private float3x3 rootRot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[ReadOnly]
		private float3 rootPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[ReadOnly]
		private Matrix4x4 curveToRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[ReadOnly]
		private float3x3 curveToRootRot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[ReadOnly]
		private float curveToRootScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[ReadOnly]
		private int destStartVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[ReadOnly]
		private int destStartIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float2> destUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> destIndices;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8ABDE10", Offset = "0x8ABCA10", VA = "0x188ABDE10")]
		private float3 IMVVZQOOBMP(float3 a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEB10", Offset = "0x8ABD710", VA = "0x188ABEB10")]
		private float3x3 ZHAWMQXOOXK(float3x3 a)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEB00", Offset = "0x8ABD700", VA = "0x188ABEB00")]
		private float YKYSXRUSGOP(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD1A0", Offset = "0x8ABBDA0", VA = "0x188ABD1A0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE4A0", Offset = "0x8ABD0A0", VA = "0x188ABE4A0")]
		private void NPSQNNQOFHF(int a, float3 b, float3 c, float3 d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE610", Offset = "0x8ABD210", VA = "0x188ABE610")]
		private void QTWWZWKJGFG(CurvePointData a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8ABDF50", Offset = "0x8ABCB50", VA = "0x188ABDF50")]
		private void JVALAGCCPHE(int a, int b, float3 c, float3x3 d, bool e, float f, int g, float h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[BurstCompile]
	public struct CreateNativeMeshFromShapeJob : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		private enum ProjectionAxis
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			X,
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			Y,
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			Z
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[ReadOnly]
		private NativeList<float3> srcVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[ReadOnly]
		private NativeArray<float3> srcNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[ReadOnly]
		private NativeList<int> srcIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[ReadOnly]
		private NativeArray<int> srcFaceIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[ReadOnly]
		private NativeArray<float4> srcTangentsX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[ReadOnly]
		private NativeArray<float4> srcTangentsY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[ReadOnly]
		private NativeArray<float4> srcTangentsZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[ReadOnly]
		private NativeArray<int> srcVertCollapseTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[ReadOnly]
		public NativeList<float3> srcFaceNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[ReadOnly]
		private ShapeInstanceData srcShapeData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[ReadOnly]
		private int destStartVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[ReadOnly]
		private int destStartIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float3> destNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> destMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float2> destUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> destVertCollapseTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> destIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[ReadOnly]
		private float3 rootPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[ReadOnly]
		private float3x3 rootRot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[ReadOnly]
		private float rootScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[ReadOnly]
		private float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[ReadOnly]
		private quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[ReadOnly]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0580", Offset = "0x8ABF180", VA = "0x188AC0580", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0FC0", Offset = "0x8ABFBC0", VA = "0x188AC0FC0")]
		private void SNNYQXNMMRT(float4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0100", Offset = "0x8ABED00", VA = "0x188AC0100")]
		private ProjectionAxis VGNOINCSQAU(float3 a)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8AC00B0", Offset = "0x8ABECB0", VA = "0x188AC00B0")]
		private float4 VGKQHGMTGZO(ProjectionAxis a, int b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFC30", Offset = "0x8ABE830", VA = "0x188ABFC30")]
		private float2 MJGGMIECPTS(ProjectionAxis a, float3 b)
		{
			return default(float2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct OcclusionData
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public enum OcclusionType
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			Box,
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			Sphere
		}

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static OcclusionData Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float3x3 Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float3 Size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public OcclusionType Type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public float3 MinPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public float3 MaxPos;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool SNDHVNFTAHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x8AC44B0", Offset = "0x8AC30B0", VA = "0x188AC44B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float3 KLWNBIZPXOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8AC43D0", Offset = "0x8AC2FD0", VA = "0x188AC43D0")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4DA0", Offset = "0x8AC39A0", VA = "0x188AC4DA0")]
		public OcclusionData(float3 position, quaternion rotation, float3 size, OcclusionType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4900", Offset = "0x8AC3500", VA = "0x188AC4900")]
		public float KWPEOBTXSIF(float3 a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4B20", Offset = "0x8AC3720", VA = "0x188AC4B20")]
		public bool SIEYOPORSPZ(float3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8AC44C0", Offset = "0x8AC30C0", VA = "0x188AC44C0")]
		public void GUDCGIQYJFX(float3 a, float3x3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4C10", Offset = "0x8AC3810", VA = "0x188AC4C10")]
		private void SVESKBOADBQ(float3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4670", Offset = "0x8AC3270", VA = "0x188AC4670")]
		public void HYBGBOKMKFD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[BurstCompile]
	public struct DetectEnclosedTrianglesBatchedJob : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[ReadOnly]
		private NativeList<OcclusionData> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[ReadOnly]
		private NativeList<float3> verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[ReadOnly]
		private NativeList<int> indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> shapeOcclusionDataIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[ReadOnly]
		private NativeList<MeshPartInfo> shapeDest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[ReadOnly]
		private int srcIndexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[ReadOnly]
		private int srcVertexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[ReadOnly]
		private float maxOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[ReadOnly]
		private float minOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<bool> triangleRemoved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<bool> vertexUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float> distance;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2490", Offset = "0x8AC1090", VA = "0x188AC2490")]
		public DetectEnclosedTrianglesBatchedJob(NativeMesh mesh, float rootScale, int startIndex, int startVertex, NativeList<OcclusionData> data, NativeArray<int> shapeOcclusionDataIdx, NativeList<MeshPartInfo> shapeDest, MWSUROXMZRO optimizationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1B00", Offset = "0x8AC0700", VA = "0x188AC1B00", Slot = "4")]
		public void Execute(int shapeIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8AC23D0", Offset = "0x8AC0FD0", VA = "0x188AC23D0")]
		private bool KGLAVEVYXZK(OcclusionData a, OcclusionData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8AC17C0", Offset = "0x8AC03C0", VA = "0x188AC17C0")]
		private bool DITEAIRYBRI(OcclusionData a, int b, int c, int d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[BurstCompile]
	public struct DetectEnclosedTrianglesJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[ReadOnly]
		private NativeList<OcclusionData> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[ReadOnly]
		private NativeList<float3> verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[ReadOnly]
		private NativeList<int> indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[ReadOnly]
		private int startIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[ReadOnly]
		private int indexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[ReadOnly]
		private int startVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[ReadOnly]
		private int vertexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[ReadOnly]
		private float maxOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[ReadOnly]
		private float minOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[ReadOnly]
		private float3 selfPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[ReadOnly]
		private float3 selfSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[ReadOnly]
		private OcclusionData.OcclusionType selfType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<bool> triangleRemoved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<bool> vertexUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float> distance;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2910", Offset = "0x8AC1510", VA = "0x188AC2910", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2860", Offset = "0x8AC1460", VA = "0x188AC2860")]
		private bool ERKXHESEWTU(OcclusionData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2520", Offset = "0x8AC1120", VA = "0x188AC2520")]
		private bool DITEAIRYBRI(OcclusionData a, int b, int c, int d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[BurstCompile]
	public struct FinalizeNativeMeshCollapseListJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private NativeList<ShapeBatch.CollapseEntry> destCollapseList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[ReadOnly]
		private NativeArray<int> srcVertCollapseTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[ReadOnly]
		private int indexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[ReadOnly]
		private int vertexStart;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2E10", Offset = "0x8AC1A10", VA = "0x188AC2E10")]
		public FinalizeNativeMeshCollapseListJob(NativeList<ShapeBatch.CollapseEntry> destCollapseList, NativeArray<int> srcVertCollapseTarget, int vertexStart = 0, int indexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2D60", Offset = "0x8AC1960", VA = "0x188AC2D60", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class MWSUROXMZRO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public NativeArray<bool> DYFAILKJBYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public NativeArray<int> QATUZTFCKBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public NativeArray<bool> OTGJKJFATRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public NativeArray<float> BWSRMPWPLVM;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4090", Offset = "0x8AC2C90", VA = "0x188AC4090")]
		public void LGCZUKOKWZK(int a, int b, Allocator c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8AC41B0", Offset = "0x8AC2DB0", VA = "0x188AC41B0")]
		public static long ZOBMFBANCXR(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3FA0", Offset = "0x8AC2BA0", VA = "0x188AC3FA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3EB0", Offset = "0x8AC2AB0", VA = "0x188AC3EB0")]
		public void Dispose(JobHandle jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public MWSUROXMZRO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[BurstCompile]
	public struct FinalizeNativeMeshOptimizationsJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private NativeList<float3> verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private NativeArray<float3> normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private NativeArray<float4> materialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private NativeArray<float2> uvs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private NativeList<int> indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<float4> tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private NativeArray<int> mapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[ReadOnly]
		private NativeArray<bool> triangleRemoved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[ReadOnly]
		private NativeArray<bool> vertexUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[ReadOnly]
		private int indexStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[ReadOnly]
		private int vertexStart;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3340", Offset = "0x8AC1F40", VA = "0x188AC3340")]
		public FinalizeNativeMeshOptimizationsJob(NativeMesh mesh, MWSUROXMZRO optimizationData, int vertexStart = 0, int indexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2E30", Offset = "0x8AC1A30", VA = "0x188AC2E30", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8AC32D0", Offset = "0x8AC1ED0", VA = "0x188AC32D0")]
		private void WEHHKYWBNWO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class RZHZDLTAWDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3FB7440", Offset = "0x3FB6040", VA = "0x183FB7440")]
		public static bool ISHWWVXXTTT<T>(NativeArray<T> a, int b, Allocator c, NativeArrayOptions d = NativeArrayOptions.ClearMemory, int e = 3) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3FB7760", Offset = "0x3FB6360", VA = "0x183FB7760")]
		public static bool ISHWWVXXTTT<T>(NativeList<T> a, int b, Allocator c) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3FB78E0", Offset = "0x3FB64E0", VA = "0x183FB78E0")]
		public static bool ISHWWVXXTTT<T>(NativeQueue<T> a, Allocator b) where T : struct
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public enum SystemLOD
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		Near,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		Far,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Force0,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		Force1,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		Force2,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		AllOfThem
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public interface WUIPFZRTCEH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IFRGRGSHWVO(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int LTZOIAMCXRG(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RRBounds ELOOWYTVOWM();

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float ZTIUICFMEYI();

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EDPWXWTKRJG(SystemLOD a, BAEZTLIQVHX b, int c = -1);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "5")]
		int BJDVAZLFPHE(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public static class KZUBKJKTQFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3D60", Offset = "0x8AC2960", VA = "0x188AC3D60")]
		public static void MQSDZVFKBNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class CDCRHGIRCXA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public NativeList<float3> VLKCTEZMDAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public NativeArray<float3> SXLDFZGZQTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public NativeArray<int> QUMAUHNDUQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public NativeArray<float4> UVYNWWDWAFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NativeArray<float4> UVTGZPJYQUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public NativeArray<float4> UVOACIQBHIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NativeArray<int> DYWTBWAKHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public NativeList<float3> RLJDDSYJWPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public NativeList<int> ZHIHIFSTFVU;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int AHEYVLULPIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA760", Offset = "0x8AB9360", VA = "0x188ABA760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int BVPSOKKTXZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9730", Offset = "0x8AB8330", VA = "0x188AB9730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int YXMYIACMVNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8AB96E0", Offset = "0x8AB82E0", VA = "0x188AB96E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8ABA7B0", Offset = "0x8AB93B0", VA = "0x188ABA7B0")]
		public CDCRHGIRCXA(int a, int b, int c, Allocator d = Allocator.Persistent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8ABAAD0", Offset = "0x8AB96D0", VA = "0x188ABAAD0")]
		public CDCRHGIRCXA(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9D00", Offset = "0x8AB8900", VA = "0x188AB9D00", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8ABA3D0", Offset = "0x8AB8FD0", VA = "0x188ABA3D0")]
		public void LXGOPHQEQBX(CDCRHGIRCXA a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9E10", Offset = "0x8AB8A10", VA = "0x188AB9E10")]
		private void KOIHXXPFYYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9780", Offset = "0x8AB8380", VA = "0x188AB9780")]
		private void DRRQKASVJKE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct MeshPartInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int StartVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int VertexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int StartIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int IndexCount;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x25C05C0", Offset = "0x25BF1C0", VA = "0x1825C05C0")]
		public MeshPartInfo(int startVertex, int vertexCount, int startIndex, int indexCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class GUXUNCBORUZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public NativeList<MeshPartInfo> DSFEQWSGYHP
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return default(NativeList<MeshPartInfo>);
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xF09A30", Offset = "0xF08630", VA = "0x180F09A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public CDCRHGIRCXA TZGQPRMHTPC
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3430", Offset = "0x8AC2030", VA = "0x188AC3430")]
		public GUXUNCBORUZ(IEnumerable<CDCRHGIRCXA> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8AC33C0", Offset = "0x8AC1FC0", VA = "0x188AC33C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum BevelScalingMode
	{
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		Pyramid
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct ShapeInstanceData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public float4 MaterialAndColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public float UVScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public float3 UVOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public bool DynamicProjection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public BevelScalingMode ScalingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public float3 ScalingRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public float AuthoredBevelRatio;
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class AIALUXPQAQM
	{
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private static NativeArray<float2> NBRYNXTNBXP;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private static NativeArray<float3> AEMJOAUFGZS;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private static NativeArray<float4> PGZEPCSJLHF;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static NativeArray<int> QWSFQRFQAQO;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8AB93A0", Offset = "0x8AB7FA0", VA = "0x188AB93A0")]
		public static void MQSDZVFKBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8AB94C0", Offset = "0x8AB80C0", VA = "0x188AB94C0")]
		public static NativeArray<float2> OWRNSDPLJYP(NativeArray<float2> a, int b, NativeArray<float2> c, int d)
		{
			return default(NativeArray<float2>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9180", Offset = "0x8AB7D80", VA = "0x188AB9180")]
		public static NativeArray<float3> CWXNEYFNANU(NativeArray<float3> a, int b, NativeArray<float3> c, int d)
		{
			return default(NativeArray<float3>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9290", Offset = "0x8AB7E90", VA = "0x188AB9290")]
		public static NativeArray<float4> JZPVZLGQSZD(NativeArray<float4> a, int b, NativeArray<float4> c, int d)
		{
			return default(NativeArray<float4>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8AB95D0", Offset = "0x8AB81D0", VA = "0x188AB95D0")]
		public static NativeArray<int> SLIWMGSLFMQ(NativeArray<int> a, int b, NativeArray<int> c, int d)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3559100", Offset = "0x3557D00", VA = "0x183559100")]
		private static void CRJAKPBPQFA<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3559400", Offset = "0x3558000", VA = "0x183559400")]
		private static void MUYOHOJSZOP<b>(NativeArray<b> a, int b, NativeArray<b> c, int d, NativeArray<b> e) where b : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[BurstCompile]
	public class VertexCompressor
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public struct CompressedPositionFixedPoint16
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public ushort x;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public ushort y;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public ushort z;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public ushort window;
		}

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB7D0", Offset = "0x8ACA3D0", VA = "0x188ACB7D0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("DEBUG")]
		private static void IWUVYCBEDFN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB340", Offset = "0x8AC9F40", VA = "0x188ACB340")]
		public static uint CZVPDUVEWLH(float a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB750", Offset = "0x8ACA350", VA = "0x188ACB750")]
		public static void FNGZIPNRLLE(float4 a, float b, [Out] uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB4A0", Offset = "0x8ACA0A0", VA = "0x188ACB4A0")]
		public static void FNGZIPNRLLE(float4 a, uint b, [Out] uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8ACBFE0", Offset = "0x8ACABE0", VA = "0x188ACBFE0")]
		public static void SMYEYGPFPHF(float3 a, float3 b, float4 c, float2 d, float4 e, [Out] NativeMesh.VertexFormat_NormTanOct8MatUi f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8ACBC70", Offset = "0x8ACA870", VA = "0x188ACBC70")]
		public static void SMYEYGPFPHF(float3 a, float3 b, float4 c, float2 d, float4 e, [Out] NativeMesh.VertexFormat_PosFixedPoint16NormTanOct8MatUi f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8ACBA40", Offset = "0x8ACA640", VA = "0x188ACBA40")]
		public static byte OFLWOAJPYPV(float a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB9E0", Offset = "0x8ACA5E0", VA = "0x188ACB9E0")]
		public static ushort LNYATKEARYG(float a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8ACC2C0", Offset = "0x8ACAEC0", VA = "0x188ACC2C0")]
		public static uint TNXSHJNUNZO(float a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8ACBAA0", Offset = "0x8ACA6A0", VA = "0x188ACBAA0")]
		public static float2 OFXLEHLSZHH(float2 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB350", Offset = "0x8AC9F50", VA = "0x188ACB350")]
		public static float2 EDMIQPXJNJJ(float3 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8ACBB20", Offset = "0x8ACA720", VA = "0x188ACBB20")]
		public static void RHESDTGCSQE(float3 a, [Out] float3 b, [Out] uint3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB830", Offset = "0x8ACA430", VA = "0x188ACB830")]
		public static CompressedPositionFixedPoint16 JSSWJGGEVOE(float3 a)
		{
			return default(CompressedPositionFixedPoint16);
		}
	}
}
namespace RecRoom.Core.Creation.Textures
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public static class TextureScalability
	{
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly ProfilerMarker SLRMGIWYBOF;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public static float PPKFKXFZROG;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAB50", Offset = "0x8AC9750", VA = "0x188ACAB50")]
		private static void KFKCZHYVWEG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8ACABE0", Offset = "0x8AC97E0", VA = "0x188ACABE0")]
		public static float QFXMNQGQBAX(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAA60", Offset = "0x8AC9660", VA = "0x188ACAA60")]
		public static long BWYODRGMCOJ(float a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAD80", Offset = "0x8AC9980", VA = "0x188ACAD80")]
		public static void TBILQTKWXMM(float a)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Quartermaster
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public interface PAJJFLDOGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TBILQTKWXMM(float a);

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		(long, long, int) MMCUWTHOGND(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class QuartermasterManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private enum WorkItemTypeEnum
		{
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			ShapesStartTreeGeneration,
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			ShapesTreeRefresh,
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			ShapesUploadMesh,
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			ShapesLod012Error
		}

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private class RQEVWBZNDCV : FJCJCPLDNXF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public WorkItemTypeEnum XWCGKVRHPNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public BatchedMeshRenderer CVRFQQBINPV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public BatchedMesh VZNQUYSYCNZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public ShapeBatch FSOATRQLZFE;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public override float QXMOTLEDGMR
			{
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x1371CD0", Offset = "0x13708D0", VA = "0x181371CD0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x1D83F30", Offset = "0x1D82B30", VA = "0x181D83F30", Slot = "6")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8AC9DC0", Offset = "0x8AC89C0", VA = "0x188AC9DC0", Slot = "7")]
			public override void YMCZYPRTVWQ([Out] bool a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
			public RQEVWBZNDCV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public static int PCFZPYVZOCZ;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public static int ITRPXHDBHMN;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public static int GRWYVVHPIJV;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public static long OVWZEUEAZAJ;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public static long GCDQQSOARGU;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public static long TQIZXWESFZJ;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public static long MDPEKGYWDLW;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public static int HDXZWAAHVVW;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public static float JGGJBGWKHFY;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public static bool YRJIDCCATDD;

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public static int TGXZNJAGKTC;

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public static int PGXOCETSOUG;

		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public static int IMCCZAEKIIM;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public static long KHHDULETWFH;

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public static int WJVGSOGWDDW;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public static bool VYGSAXQZEYA;

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private static uint LVCTXHRVWZY;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private static XGSSUWQQVKY DAGOFULUADG;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static List<uint> YYXDPQQICME;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static PAJJFLDOGIF JPGOCAKFXYB;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private static PAJJFLDOGIF IEKOSFPQGWD;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool ISXIRSWGFON
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8AC50C0", Offset = "0x8AC3CC0", VA = "0x188AC50C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5900", Offset = "0x8AC4500", VA = "0x188AC5900")]
		private static void IWUVYCBEDFN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8AC59E0", Offset = "0x8AC45E0", VA = "0x188AC59E0")]
		private static void KFKCZHYVWEG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5970", Offset = "0x8AC4570", VA = "0x188AC5970")]
		private static void IWUVYCBEDFN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5330", Offset = "0x8AC3F30", VA = "0x188AC5330")]
		public static void EYOWTZNIAHR(PAJJFLDOGIF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5890", Offset = "0x8AC4490", VA = "0x188AC5890")]
		public static void IOZJLMLFPYF(PAJJFLDOGIF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5110", Offset = "0x8AC3D10", VA = "0x188AC5110")]
		public static (long, long, long, int, int) ERLSQJZOWLA(long a)
		{
			return default((long, long, long, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8AC9710", Offset = "0x8AC8310", VA = "0x188AC9710")]
		public static void UBQURISUBLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6DA0", Offset = "0x8AC59A0", VA = "0x188AC6DA0")]
		public static void TBILQTKWXMM(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6A00", Offset = "0x8AC5600", VA = "0x188AC6A00")]
		public static void RCFYFANUBTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5A70", Offset = "0x8AC4670", VA = "0x188AC5A70")]
		public static long KZSJOELVZHX(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8AC9790", Offset = "0x8AC8390", VA = "0x188AC9790")]
		public static bool VBXAPWEKHMN(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6530", Offset = "0x8AC5130", VA = "0x188AC6530")]
		public static bool POQZHOSOEFY(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5530", Offset = "0x8AC4130", VA = "0x188AC5530")]
		public static float HQREWMRGTET(long a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5C10", Offset = "0x8AC4810", VA = "0x188AC5C10")]
		public static (long, long, int) MMCUWTHOGND(float a)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8AC62E0", Offset = "0x8AC4EE0", VA = "0x188AC62E0")]
		public static void OWYOUBWUDAE(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6080", Offset = "0x8AC4C80", VA = "0x188AC6080")]
		public static void MRSYDBEADXL(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8AC9870", Offset = "0x8AC8470", VA = "0x188AC9870")]
		public static void ZODSWMJVDWS(BatchedMesh a, BatchedMeshRenderer b, long c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6B10", Offset = "0x8AC5710", VA = "0x188AC6B10")]
		public static void RVQKAQPUAAS(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6600", Offset = "0x8AC5200", VA = "0x188AC6600")]
		private static void QXGPJIOFKFB(WorkItemTypeEnum a, ShapeBatch b, BatchedMesh c, BatchedMeshRenderer d, long e, long f, float g, bool h, bool i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5000", Offset = "0x8AC3C00", VA = "0x188AC5000")]
		public static bool BEJUNLPNCKF(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8AC53A0", Offset = "0x8AC3FA0", VA = "0x188AC53A0")]
		public static void GJGVOWCQDED(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5420", Offset = "0x8AC4020", VA = "0x188AC5420")]
		public static bool GJRTZULFUPW(float a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class FJCJCPLDNXF : IComparable
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public enum WorkItemContinuityEnum : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			Instant,
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			Persistent
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public WorkItemContinuityEnum GWPTFUEMLDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public long DIPGERVCJHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public long RNSKEUNUVCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public float BSOFWBLZAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public bool JKXUBUDJUQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public bool RSVUJRVCNRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		internal uint KGOJFCHDRGI;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public abstract float QXMOTLEDGMR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void YMCZYPRTVWQ([Out] bool a, [Out] bool b);

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6FB0", Offset = "0x8AD5BB0", VA = "0x188AD6FB0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected FJCJCPLDNXF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class XGSSUWQQVKY : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private List<FJCJCPLDNXF> NMDMCPHKXOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private List<FJCJCPLDNXF> PGTBNHALMQP;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int YDGZHCXKSNK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8AE32F0", Offset = "0x8AE1EF0", VA = "0x188AE32F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3230", Offset = "0x8AE1E30", VA = "0x188AE3230")]
		public void Add(FJCJCPLDNXF item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3830", Offset = "0x8AE2430", VA = "0x188AE3830")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3340", Offset = "0x8AE1F40", VA = "0x188AE3340")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3430", Offset = "0x8AE2030", VA = "0x188AE3430")]
		public void OFYSXEYHIWG(IEnumerable<uint> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3770", Offset = "0x8AE2370", VA = "0x188AE3770")]
		private void Remove(uint id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3890", Offset = "0x8AE2490", VA = "0x188AE3890", Slot = "4")]
		private IEnumerator ZFHLTDQPCLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8AE33D0", Offset = "0x8AE1FD0", VA = "0x188AE33D0")]
		public QuartermasterWorkItemEnumerator GetEnumerator()
		{
			return default(QuartermasterWorkItemEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3930", Offset = "0x8AE2530", VA = "0x188AE3930")]
		public XGSSUWQQVKY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public struct QuartermasterWorkItemEnumerator : IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private List<FJCJCPLDNXF> instantWorkItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private List<FJCJCPLDNXF> persistentWorkItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private int instantIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private int persistentIndex;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private object APIHCGBOWUL
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8AD7250", Offset = "0x8AD5E50", VA = "0x188AD7250", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public FJCJCPLDNXF EZFWAAOVWWO
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8AD70D0", Offset = "0x8AD5CD0", VA = "0x188AD70D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7400", Offset = "0x8AD6000", VA = "0x188AD7400")]
		public QuartermasterWorkItemEnumerator(List<FJCJCPLDNXF> instantWorkItems, List<FJCJCPLDNXF> persistentWorkItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7260", Offset = "0x8AD5E60", VA = "0x188AD7260", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8AD73F0", Offset = "0x8AD5FF0", VA = "0x188AD73F0", Slot = "6")]
		public void Reset()
		{
		}
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class BatchedMesh
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		internal enum ScalabilityStateMesh
		{
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			UninitImmediate,
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			UninitAsync,
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			NoMeshRefresh,
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			Mesh,
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			MeshFrozen,
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			MeshRefresh,
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			LAST_VALUE
		}

		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private static readonly string RLEDSTONXLP;

		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private static readonly string VMLDWYYUVLI;

		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private static readonly ProfilerMarker EQOSQELNGVY;

		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private static readonly ProfilerMarker TBNICCUWCBJ;

		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private static readonly ProfilerMarker SLRMGIWYBOF;

		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private static readonly ProfilerMarker IVGALPXLKZN;

		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private static readonly ProfilerMarker CXGCUUJFVOL;

		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static readonly ProfilerMarker JIOUAKAUVZM;

		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private static readonly ProfilerMarker YOOFKZBFKRY;

		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private static readonly ProfilerMarker BIYVOQMXCUG;

		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private static readonly ProfilerMarker TITJGUTPCTO;

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static readonly ProfilerMarker HGVJYLWJCYY;

		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private static readonly ProfilerMarker HHLEQGEBFGZ;

		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private static readonly ProfilerMarker HHFXSZKDVVQ;

		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private static readonly ProfilerMarker HHVSKTRVYDR;

		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private static readonly ProfilerMarker HHQLNMXYOSI;

		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private static readonly ProfilerMarker HIGGFHFQRAJ;

		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private static readonly ProfilerMarker HIAZIALTHPA;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private static readonly ProfilerMarker HFKNRQNBOXN;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static readonly ProfilerMarker AZXVCGARMXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		internal readonly List<ShapeBatch> IBUROUQKYMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private readonly EATWKRGETKI WZJVJTQFRQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		internal int YWYEVSYNJRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		internal int NFLECNNXQQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		internal bool ZHRIUMCWYSO;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public const bool CCUGSCAGQCQ = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public bool HXJYPCHXKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		internal string MASQKWYDDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		internal ScalabilityStateMesh LONHIUAEZKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		internal int JCGYYSSVXOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		internal int QWKATGLYRZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		internal int LIUFLWWOVOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		internal int PIAVIKMDATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		internal long LFQFQPWTYOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		internal long VEVAEDHSURY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		internal long NKICTBOFSOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private NativeMesh CYFGJTZHKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private NativeMesh TMBMNVRPMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private NativeMesh.UnityMeshFormat GZVMEJQIUUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private bool BDVGJTYMAJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private int PCLXISXACSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private BatchedMeshTessellate UMTKQCGWJTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private float3 SAVBHSLKQAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private float TARVIYWATFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private float MAKIJSJOLBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private float PXHIQUFXMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private float VKTNXZPTRYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private float XXCWYYLFWPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private float TXZFDQFWFRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private float3 BMIWGLQEBBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private float RSKQNNQWQLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private float ODLINMFCJLZ;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal Mesh TZGQPRMHTPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public MeshFilter VIHUIPYNPUC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xB13160", Offset = "0xB11D60", VA = "0x180B13160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public MeshRenderer ESUXXQKEHGW
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xB13190", Offset = "0xB11D90", VA = "0x180B13190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public List<Material> MMOIFEXYWDA
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xB13B40", Offset = "0xB12740", VA = "0x180B13B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int GZJEEXYABLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x10FC340", Offset = "0x10FAF40", VA = "0x1810FC340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int AHEYVLULPIK
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x8AD5700", Offset = "0x8AD4300", VA = "0x188AD5700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void IWUVYCBEDFN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void IWUVYCBEDFN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void KFKCZHYVWEG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void KFKCZHYVWEG(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1B20", Offset = "0x8AD0720", VA = "0x188AD1B20")]
		public void CSDHQGMLNDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5720", Offset = "0x8AD4320", VA = "0x188AD5720")]
		public bool WALQPJYHYNR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8AD65A0", Offset = "0x8AD51A0", VA = "0x188AD65A0")]
		private void YWIEKQGUGNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1690", Offset = "0x8AD0290", VA = "0x188AD1690")]
		private void BLQDQDFUBJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6E70", Offset = "0x8AD5A70", VA = "0x188AD6E70")]
		public BatchedMesh(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8AD23F0", Offset = "0x8AD0FF0", VA = "0x188AD23F0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1880", Offset = "0x8AD0480", VA = "0x188AD1880")]
		private void CASSCEKPXBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1DD0", Offset = "0x8AD09D0", VA = "0x188AD1DD0")]
		private void CreateNewUnityMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0C80", Offset = "0x8ACF880", VA = "0x188AD0C80")]
		private void BEWZNACLTGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8AD48C0", Offset = "0x8AD34C0", VA = "0x188AD48C0")]
		public Mesh RMSVBIPXDER(MeshFilter a, Transform b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5D80", Offset = "0x8AD4980", VA = "0x188AD5D80")]
		public void XNOTIKIIYGK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3B30", Offset = "0x8AD2730", VA = "0x188AD3B30")]
		private void MILVLHYHNAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2110", Offset = "0x8AD0D10", VA = "0x188AD2110")]
		public void DBQGOXCOAHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0A10", Offset = "0x8ACF610", VA = "0x188AD0A10")]
		public void AIVDSLYNVEF(WUIPFZRTCEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD37B0", Offset = "0x8AD23B0", VA = "0x188AD37B0")]
		public bool LLLEGWBPWAE(WUIPFZRTCEH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1C50", Offset = "0x8AD0850", VA = "0x188AD1C50")]
		public bool Contains(WUIPFZRTCEH meshGenerator)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3140", Offset = "0x8AD1D40", VA = "0x188AD3140", Slot = "4")]
		public virtual void ILVRBQRVUNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5840", Offset = "0x8AD4440", VA = "0x188AD5840")]
		public void WKECLDLSINZ(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3F10", Offset = "0x8AD2B10", VA = "0x188AD3F10")]
		public bool NTCQKNMVZXK(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8AD42D0", Offset = "0x8AD2ED0", VA = "0x188AD42D0")]
		public bool OVIVRNJFGDP(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1A00", Offset = "0x8AD0600", VA = "0x188AD1A00")]
		private void CJVJHOBGDRL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8AD49B0", Offset = "0x8AD35B0", VA = "0x188AD49B0")]
		public bool TBILQTKWXMM(float4x4 a, BatchedMeshRenderer b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4700", Offset = "0x8AD3300", VA = "0x188AD4700")]
		public bool PZEIKMSLVRQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0D20", Offset = "0x8ACF920", VA = "0x188AD0D20")]
		public bool BIUCJGNYLQH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8AD32D0", Offset = "0x8AD1ED0", VA = "0x188AD32D0")]
		public void INFFKLJXVIJ(NativeMesh a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8AD25B0", Offset = "0x8AD11B0", VA = "0x188AD25B0")]
		public (long, long, long) FPXFLKNPMRV()
		{
			return default((long, long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6C0", Offset = "0xB1C2C0", VA = "0x180B1D6C0")]
		public long WAPXYPSKOGT()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD47B0", Offset = "0x8AD33B0", VA = "0x188AD47B0")]
		private void QCJWTYVAGYL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3C80", Offset = "0x8AD2880", VA = "0x188AD3C80")]
		public (long, long, int) MMCUWTHOGND(float a, float4x4 b)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xE1C120", Offset = "0xE1AD20", VA = "0x180E1C120")]
		internal void DITXDUADURC(ScalabilityStateMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2750", Offset = "0x8AD1350", VA = "0x188AD2750")]
		internal (float, float, float, float) GXGUZGCFGJW(float a, float4x4 b)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD66C0", Offset = "0x8AD52C0", VA = "0x188AD66C0")]
		private void ZMSLUDPCJJS(NativeMesh a, NativeMesh.UnityMeshFormat b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3430", Offset = "0x8AD2030", VA = "0x188AD3430")]
		private void KYFZMOOHQUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8AD45F0", Offset = "0x8AD31F0", VA = "0x188AD45F0")]
		internal bool PESDECSCDCV(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8AD60D0", Offset = "0x8AD4CD0", VA = "0x188AD60D0")]
		private void YKDBPCCVOJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8AD39B0", Offset = "0x8AD25B0", VA = "0x188AD39B0")]
		private void MHJXENXGCBR(NativeMesh.UnityMeshFormat a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2220", Offset = "0x8AD0E20", VA = "0x188AD2220")]
		private void DXQZSNUKEIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3450", Offset = "0x8AD2050", VA = "0x188AD3450")]
		public long KZSJOELVZHX(long a, int b)
		{
			return default(long);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ShapeBatch
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		internal enum ScalabilityStateShapes
		{
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			UninitImmediate,
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			UninitImmediateInJob,
			[Cpp2IlInjected.Token(Token = "0x4000281")]
			UninitAsync,
			[Cpp2IlInjected.Token(Token = "0x4000282")]
			NoMeshLodDataRefresh,
			[Cpp2IlInjected.Token(Token = "0x4000283")]
			NoMeshLodDataInJob,
			[Cpp2IlInjected.Token(Token = "0x4000284")]
			MeshNoData,
			[Cpp2IlInjected.Token(Token = "0x4000285")]
			MeshNoDataFrozen,
			[Cpp2IlInjected.Token(Token = "0x4000286")]
			MeshNoDataRefresh,
			[Cpp2IlInjected.Token(Token = "0x4000287")]
			MeshLodData,
			[Cpp2IlInjected.Token(Token = "0x4000288")]
			MeshLodDataRefresh,
			[Cpp2IlInjected.Token(Token = "0x4000289")]
			MeshLodDataInJob,
			[Cpp2IlInjected.Token(Token = "0x400028A")]
			MeshAllData,
			[Cpp2IlInjected.Token(Token = "0x400028B")]
			MeshAllDataRefresh,
			[Cpp2IlInjected.Token(Token = "0x400028C")]
			MeshAllDataInJob,
			[Cpp2IlInjected.Token(Token = "0x400028D")]
			MeshAllDataInJob2,
			[Cpp2IlInjected.Token(Token = "0x400028E")]
			LAST_VALUE
		}

		[Cpp2IlInjected.Token(Token = "0x200007D")]
		public struct CollapseEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public int from;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			public int to;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000291")]
			public float cost;
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public struct ScaledMesh
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			public CompressedNativeMeshStruct mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			public int triCountGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public int triCountActual;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public long memoryBytesUnity;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public long memoryBytesLocal;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			public float errorActualLocalMeters;

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x8AD74C0", Offset = "0x8AD60C0", VA = "0x188AD74C0")]
			public void HRTIXRMSTIX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x8AD7440", Offset = "0x8AD6040", VA = "0x188AD7440")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private static readonly string RLEDSTONXLP;

		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private static readonly string VMLDWYYUVLI;

		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private static readonly ProfilerMarker EQOSQELNGVY;

		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private static readonly ProfilerMarker BNPLYNTYDCA;

		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private static readonly ProfilerMarker SLRMGIWYBOF;

		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private static readonly ProfilerMarker EIGKJVOAUOS;

		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private static readonly ProfilerMarker IVGALPXLKZN;

		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private static readonly ProfilerMarker CXGCUUJFVOL;

		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private static readonly ProfilerMarker JIOUAKAUVZM;

		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private static readonly ProfilerMarker YOOFKZBFKRY;

		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private static readonly ProfilerMarker BIYVOQMXCUG;

		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private static readonly ProfilerMarker LLPRCVAQWZI;

		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private static readonly ProfilerMarker TITJGUTPCTO;

		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private static readonly ProfilerMarker ORTIWEQJWYO;

		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private static readonly ProfilerMarker RPLVZLWYJBC;

		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private static readonly ProfilerMarker THVFCPAUXJN;

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private static readonly ProfilerMarker LTGOFWRZEWI;

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private static readonly ProfilerMarker HGVJYLWJCYY;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private static readonly ProfilerMarker HHLEQGEBFGZ;

		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private static readonly ProfilerMarker HHFXSZKDVVQ;

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private static readonly ProfilerMarker HHVSKTRVYDR;

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private static readonly ProfilerMarker HHQLNMXYOSI;

		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private static readonly ProfilerMarker HIGGFHFQRAJ;

		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private static readonly ProfilerMarker HIAZIALTHPA;

		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private static readonly ProfilerMarker HFKNRQNBOXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		internal readonly List<WUIPFZRTCEH> WPTKDGBBJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		internal BatchedMesh EQEEPFZRVXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly EATWKRGETKI WZJVJTQFRQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		internal int JARJOAPCFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		internal int XKULYXHRJUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		internal bool WZUTWYUJIXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		internal bool LINEJHGBQHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		internal string MASQKWYDDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		internal ScalabilityStateShapes XVIPJVVENUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		internal bool EMLLKADSCXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		internal float3 MNKBYBLJUCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		internal float3 QFICMNKWQYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		internal float TNJNDVZDDHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		internal int NPARFIBXNXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		internal int CGXFTDBDEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		internal int UIQGFBTQFSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		internal float ITWMZLSTGQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		internal int VZHHQCRRVDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		internal float WKSAYCECYCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		internal float XAVAEIXMTID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		internal int SVJZMTFMXLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		internal long RJXDFAFITQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public int TVDSYQDAIQR;

		[Cpp2IlInjected.Token(Token = "0x4000260")]
		internal const int JCNVGMSDAMS = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		internal float[] LWBUDPGKCGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		internal int[] PSYDTYTWQIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		internal long[] YDTHPDATQOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public List<ScaledMesh> ZTTRGVHTPLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		internal NativeMesh YIAOQZTSQTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		internal long GIASZRDJUKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		internal int BJTJLPESFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		internal float YDPJOETMCRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		internal NativeMesh.UnityMeshFormat HZMZITHMEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		internal CompressedNativeMeshStruct VQLIBYAGDOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		internal int GEHVSMNCCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		internal float KKSAWMZTRXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		internal long MKDKGKAPWSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		internal bool PYQKKGZLIYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		internal ScaleMeshToDesiredTriCountsJob HCHBBEMASTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		internal JobHandle TVSEADGGLUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		internal NativeList<CollapseEntry> WFBUXXRRUCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		internal NativeArray<long> PPGLVLNEVIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		internal bool YSLVYOGKDLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		internal JobHandle IYNLVKEPVVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		internal NativeMesh JPGTVHMNSRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		internal MWSUROXMZRO AJZZMTKKAMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		internal NativeList<CollapseEntry> CMHJICFGZMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		internal Transform HXVFYSDYCPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		internal SystemLOD OEPULAIQOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		internal long PDUQEAZYGQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		internal long NXVTQGJMNYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		internal long IGHROIESLWO;

		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private static bool CJOGYVWYTNC;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<WUIPFZRTCEH> DSKPYUQUJMY
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal int AHEYVLULPIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x8AE0810", Offset = "0x8ADF410", VA = "0x188AE0810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void IWUVYCBEDFN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void IWUVYCBEDFN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void KFKCZHYVWEG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void KFKCZHYVWEG(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7E50", Offset = "0x8AD6A50", VA = "0x188AD7E50")]
		internal void CSDHQGMLNDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE22F0", Offset = "0x8AE0EF0", VA = "0x188AE22F0")]
		internal void YWIEKQGUGNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2D50", Offset = "0x8AE1950", VA = "0x188AE2D50")]
		internal ShapeBatch(string name, BatchedMesh parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9780", Offset = "0x8AD8380", VA = "0x188AD9780")]
		internal void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB280", Offset = "0x8AD9E80", VA = "0x188ADB280")]
		internal void MILVLHYHNAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB010", Offset = "0x8AD9C10", VA = "0x188ADB010")]
		internal void MHIENABBAZM(WUIPFZRTCEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2260", Offset = "0x8AE0E60", VA = "0x188AE2260")]
		internal bool YFRCCMOWWMJ(WUIPFZRTCEH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE860", Offset = "0x8ADD460", VA = "0x188ADE860")]
		internal bool TTZCZTHCZEJ(WUIPFZRTCEH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA260", Offset = "0x8AD8E60", VA = "0x188ADA260", Slot = "4")]
		internal virtual void ILVRBQRVUNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1A20", Offset = "0x8AE0620", VA = "0x188AE1A20")]
		public float XUXBFKUEIRL(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8AD74F0", Offset = "0x8AD60F0", VA = "0x188AD74F0")]
		public bool ARLROBMITGE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7E60", Offset = "0x8AD6A60", VA = "0x188AD7E60")]
		public (CompressedNativeMeshStruct, NativeMesh.UnityMeshFormat) DLAVOOWJMZK()
		{
			return default((CompressedNativeMeshStruct, NativeMesh.UnityMeshFormat));
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD520", Offset = "0x8ADC120", VA = "0x188ADD520")]
		internal long QXSOTOAFFIR()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8ADAB20", Offset = "0x8AD9720", VA = "0x188ADAB20")]
		internal long LJBTNQEPCFK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF6A0", Offset = "0x8ADE2A0", VA = "0x188ADF6A0")]
		internal bool UNOZXAFHFHV(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBBD0", Offset = "0x8ADA7D0", VA = "0x188ADBBD0")]
		internal bool OVIVRNJFGDP(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD77A0", Offset = "0x8AD63A0", VA = "0x188AD77A0")]
		internal void CJVJHOBGDRL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD5D0", Offset = "0x8ADC1D0", VA = "0x188ADD5D0")]
		internal bool TBILQTKWXMM(float4x4 a, BatchedMeshRenderer b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0510", Offset = "0x8ADF110", VA = "0x188AE0510")]
		internal bool USHBBNDJPFE(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE22E0", Offset = "0x8AE0EE0", VA = "0x188AE22E0")]
		internal void YRTVUMUSWYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA2E0", Offset = "0x8AD8EE0", VA = "0x188ADA2E0")]
		internal void INFFKLJXVIJ(NativeMesh a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9940", Offset = "0x8AD8540", VA = "0x188AD9940")]
		internal void GALMOAAQIYU(CompressedNativeMeshStruct a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD080", Offset = "0x8ADBC80", VA = "0x188ADD080")]
		internal void QCJWTYVAGYL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB660", Offset = "0x8ADA260", VA = "0x188ADB660")]
		internal (long, long, int) MMCUWTHOGND(float a, float4x4 b, float c)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xB9A3D0", Offset = "0xB98FD0", VA = "0x180B9A3D0")]
		internal void DITXDUADURC(ScalabilityStateShapes a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9BD0", Offset = "0x8AD87D0", VA = "0x188AD9BD0")]
		public static (float, float, float, float) GXGUZGCFGJW(float3 a, float3 b, float c, float4x4 d, float e)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9FD0", Offset = "0x8AD8BD0", VA = "0x188AD9FD0")]
		internal (float, float, float, float) GXGUZGCFGJW(float a, float4x4 b, float c)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1B10", Offset = "0x8AE0710", VA = "0x188AE1B10")]
		private float XWWIWJBGULL(float a, float4x4 b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1410", Offset = "0x8AE0010", VA = "0x188AE1410")]
		private (int, int, float) XOOVQWSQPZQ(float a)
		{
			return default((int, int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8AE25D0", Offset = "0x8AE11D0", VA = "0x188AE25D0")]
		internal static float ZXZWIYHWZHU(WUIPFZRTCEH a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD85B0", Offset = "0x8AD71B0", VA = "0x188AD85B0")]
		internal void DWRRYUJQYWY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD96F0", Offset = "0x8AD82F0", VA = "0x188AD96F0")]
		internal void DXQZSNUKEIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCD50", Offset = "0x8ADB950", VA = "0x188ADCD50")]
		internal void PPHSLWTHISZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA310", Offset = "0x8AD8F10", VA = "0x188ADA310")]
		internal long KZSJOELVZHX(long a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0830", Offset = "0x8ADF430", VA = "0x188AE0830")]
		private void XDETAPWARWI(NativeMesh a, NativeList<CollapseEntry> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8ADAC40", Offset = "0x8AD9840", VA = "0x188ADAC40")]
		internal void LQREURLQEPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1B70", Offset = "0x8AE0770", VA = "0x188AE1B70")]
		public static void XZRVRWLOPFE(NativeList<CollapseEntry> a, NativeMesh b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8AE24E0", Offset = "0x8AE10E0", VA = "0x188AE24E0")]
		private float ZEESUIMHEZU(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE8C0", Offset = "0x8ADD4C0", VA = "0x188ADE8C0")]
		internal void UMGOPHWIOGQ(NativeMesh a, CompressedNativeMesh b, int c, int d, float e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[BurstCompile]
	internal struct BatchedMeshTessellateJob : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		internal struct TriToTessellate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			public int ind0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public int ind1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public int ind2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			public float length01;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public float length12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public float length20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public float edgeLengthScalerCorrected;
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		internal struct QuadToTessellate
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			public int ind0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public int ind1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public int ind2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public int ind3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public float length01;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public float length12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public float length23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			public float length30;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			public float edgeLengthScalerCorrected;
		}

		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public struct GenerateTessellatedMeshResults
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			public int completedNumVerts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			public int completedNumIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			public float longestPreTessellatedEdgeLength;
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void TessellateTri_0000025F$PostfixBurstDelegate(BatchedMeshTessellateJob bmtj, [In] TriToTessellate tri);

		[Cpp2IlInjected.Token(Token = "0x2000084")]
		internal static class OVRILMMSGVX
		{
			[Cpp2IlInjected.Token(Token = "0x40002BD")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x8AF3A40", Offset = "0x8AF2640", VA = "0x188AF3A40")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x8AF3BD0", Offset = "0x8AF27D0", VA = "0x188AF3BD0")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x8AF3840", Offset = "0x8AF2440", VA = "0x188AF3840")]
			public static void Invoke(BatchedMeshTessellateJob bmtj, [In] TriToTessellate tri)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void TessellateQuad_00000260$PostfixBurstDelegate(BatchedMeshTessellateJob bmtj, [In] QuadToTessellate quad);

		[Cpp2IlInjected.Token(Token = "0x2000086")]
		internal static class OAZHMNPWEIU
		{
			[Cpp2IlInjected.Token(Token = "0x40002BE")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x8AF3530", Offset = "0x8AF2130", VA = "0x188AF3530")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8AF36C0", Offset = "0x8AF22C0", VA = "0x188AF36C0")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8AF3330", Offset = "0x8AF1F30", VA = "0x188AF3330")]
			public static void Invoke(BatchedMeshTessellateJob bmtj, [In] QuadToTessellate quad)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void BuildNativeMesh_00000263$PostfixBurstDelegate(UnsafeList<int>* resultIndices, UnsafeList<float3>* resultVerts, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* newVerts, UnsafeList<int>* newIndices, UnsafeList<float3>* inMeshVerts, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int numIndices, int numVerts);

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		internal static class MEPGTOROYCE
		{
			[Cpp2IlInjected.Token(Token = "0x40002BF")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x8AF2AA0", Offset = "0x8AF16A0", VA = "0x188AF2AA0")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8AF2C30", Offset = "0x8AF1830", VA = "0x188AF2C30")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8AF2750", Offset = "0x8AF1350", VA = "0x188AF2750")]
			public unsafe static void Invoke(UnsafeList<int>* resultIndices, UnsafeList<float3>* resultVerts, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* newVerts, UnsafeList<int>* newIndices, UnsafeList<float3>* inMeshVerts, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int numIndices, int numVerts)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public float3 cameraInLocalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public float localToWorldScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public float desiredFactorLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public float minimumEdgeLengthLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public JKGRWLMOJHR.ScalabilityTessellationModeEnum shapesTessellateMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public bool shapesTessellateAllowQuads;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<TessVert>* newVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<int>* newIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<TriToTessellate>* trisToTessellateCurrent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<TriToTessellate>* trisToTessellateNew;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<QuadToTessellate>* quadsToTessellateCurrent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<QuadToTessellate>* quadsToTessellateNew;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public int numInVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public int numInTris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public int maxVertexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public unsafe float3* inMeshVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public unsafe int* inMeshIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public unsafe GenerateTessellatedMeshResults* results;

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void IWUVYCBEDFN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void KFKCZHYVWEG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF3C0", Offset = "0x8ACDFC0", VA = "0x188ACF3C0")]
		private static float KCYEATNWABZ([In] BatchedMeshTessellateJob bmtj, [In] float3 vertPos, float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8ACFEE0", Offset = "0x8ACEAE0", VA = "0x188ACFEE0")]
		private static int QUPGLYGEPHB(BatchedMeshTessellateJob a, [Out] TessVert b, [In] TessVert vert0, [In] TessVert vert1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0A00", Offset = "0x8ACF600", VA = "0x188AD0A00")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.TessellateTri_0000025F$PostfixBurstDelegate))]
		private static void WGERXOYKYHA(BatchedMeshTessellateJob a, [In] TriToTessellate tri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD09F0", Offset = "0x8ACF5F0", VA = "0x188AD09F0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.TessellateQuad_00000260$PostfixBurstDelegate))]
		private static void VNSTEBTEBXM(BatchedMeshTessellateJob a, [In] QuadToTessellate quad)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8ACE4B0", Offset = "0x8ACD0B0", VA = "0x188ACE4B0", Slot = "4")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACE4C0", Offset = "0x8ACD0C0", VA = "0x188ACE4C0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal void GLCRNSLCCBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8ACE400", Offset = "0x8ACD000", VA = "0x188ACE400")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.BuildNativeMesh_00000263$PostfixBurstDelegate))]
		internal unsafe static void CIOONJCATCF(UnsafeList<int>* a, UnsafeList<float3>* b, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* c, UnsafeList<int>* d, UnsafeList<float3>* e, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int f, int g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF450", Offset = "0x8ACE050", VA = "0x188ACF450")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public static void NCOMXLOXQGZ(BatchedMeshTessellateJob a, [In] TriToTessellate tri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0060", Offset = "0x8ACEC60", VA = "0x188AD0060")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public static void RNKLFZACFXD(BatchedMeshTessellateJob a, [In] QuadToTessellate quad)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8ACDC50", Offset = "0x8ACC850", VA = "0x188ACDC50")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public unsafe static void BVREMKHZTTC(UnsafeList<int>* a, UnsafeList<float3>* b, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* c, UnsafeList<int>* d, UnsafeList<float3>* e, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int f, int g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class BatchedMeshTessellate
	{
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private static readonly ProfilerMarker PCOKLIGPXIJ;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public const int LHWNNWBPPCW = 2;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private const int WVNJQUGLEYE = 1;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private static int QZVQIMTEVTO;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private static Stack<BatchedMeshTessellate> GXLVNNFMSHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private NativeMesh YOUCQUGCDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private NativeList<TessVert> TZPHIVXQRJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private NativeList<int> EAYGLHPUPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private NativeList<BatchedMeshTessellateJob.TriToTessellate> MALMQKMMZSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private NativeList<BatchedMeshTessellateJob.TriToTessellate> JXFOFNHFKBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private NativeList<BatchedMeshTessellateJob.QuadToTessellate> PJNCAXOMPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private NativeList<BatchedMeshTessellateJob.QuadToTessellate> NYTQIZPFDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private BatchedMeshTessellateJob SGFEYARREEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private JobHandle KOYYCIUAEVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private BatchedMeshTessellateJob.GenerateTessellatedMeshResults OQWAZXUBJNS;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private const int MNRGVNINXBM = 65530;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void IWUVYCBEDFN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void KFKCZHYVWEG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2410", Offset = "0x8AF1010", VA = "0x188AF2410")]
		private BatchedMeshTessellate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1160", Offset = "0x8AEFD60", VA = "0x188AF1160")]
		public void CMYXGFDOISM(NativeMesh a, float3 b, float c, float d, float e, List<ShapeBatch.CollapseEntry> f, Allocator g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1D20", Offset = "0x8AF0920", VA = "0x188AF1D20")]
		public (bool, NativeMesh, float) SKTNESPAFKV(List<ShapeBatch.CollapseEntry> a, Allocator b, bool c)
		{
			return default((bool, NativeMesh, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8AF10D0", Offset = "0x8AEFCD0", VA = "0x188AF10D0")]
		public static bool BPGGNTQJVEG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1650", Offset = "0x8AF0250", VA = "0x188AF1650")]
		public static int ITGYXJPPHDH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8AF15E0", Offset = "0x8AF01E0", VA = "0x188AF15E0")]
		public static int FWRZWFOYESD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1A20", Offset = "0x8AF0620", VA = "0x188AF1A20")]
		public static BatchedMeshTessellate PRNRDQHINOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2260", Offset = "0x8AF0E60", VA = "0x188AF2260")]
		internal static void VVHMKSSDYNP(BatchedMeshTessellate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1880", Offset = "0x8AF0480", VA = "0x188AF1880")]
		public static void OEVXHEDVNPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF16A0", Offset = "0x8AF02A0", VA = "0x188AF16A0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		public static void MQSDZVFKBNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[BurstCompile]
	internal struct TessVert
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public float3 pos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int srcIndex0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public int srcIndex1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int srcIndex2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public float srcWeight1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public float srcWeight2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public int nextIndex;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void IWUVYCBEDFN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void KFKCZHYVWEG(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8270", Offset = "0x8AF6E70", VA = "0x188AF8270")]
		public static void Create([Out] TessVert result, int srcIndex, [In] float3 posIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7F80", Offset = "0x8AF6B80", VA = "0x188AF7F80")]
		[IgnoreWarning(1371)]
		public static void Create([Out] TessVert result, [In] TessVert v1, [In] TessVert v2)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[BurstCompile]
	internal struct ScaleMeshToDesiredTriCountsJob : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		private struct ScaledMeshJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public int firstVertexNum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public int firstIndexNum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			public int countVertex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			public int countIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			public int maxCountVertex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			public int maxCountIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			public int triCountGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			public int triCountActual;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			public float errorActual;
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private struct ScaledMeshJobStaticValues
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			public JKGRWLMOJHR.ScalabilityCollapseMetricEnum shapesCollapseMetric;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			public float shapesCollapseScaleNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			public float shapesCollapseScaleUv;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			public float shapesCollapseScaleColourId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			public float shapesCollapseScaleTextureId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			public float shapesCollapseScaleCoincident;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			public float shapesCollapseScaleGuideAccum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			public float shapesCollapseScaleLod012;
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private struct NativeMeshJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			public NativeArray<float3> Verts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			public NativeArray<float3> Normals;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			public NativeArray<float4> Tangents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			public NativeArray<float4> MaterialIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			public NativeArray<float2> UVs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			public NativeArray<int> Indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			public bool hasTangents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			public int VertexCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public int IndexCount;

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x8AF3150", Offset = "0x8AF1D50", VA = "0x188AF3150")]
			public void LGCZUKOKWZK(int a, int b, Allocator c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x8AF2F10", Offset = "0x8AF1B10", VA = "0x188AF2F10")]
			public static NativeMeshJob FVEMPNHNKGG(NativeMesh a)
			{
				return default(NativeMeshJob);
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x8AF2E50", Offset = "0x8AF1A50", VA = "0x188AF2E50")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private static readonly ProfilerMarker markerFinishAndDispose;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private static readonly ProfilerMarker markerCheckConsistency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private NativeArray<ScaledMeshJob> scaledMeshList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private NativeMeshJob scaledMeshListContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private NativeMeshJob meshSrc;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private float3 shapeBatch_bboxMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private float3 shapeBatch_bboxMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private ScaledMeshJobStaticValues staticValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly long* scaleMeshJobAbortRequestRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private NativeArray<ShapeBatch.CollapseEntry> collapseListSrc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private NativeList<ShapeBatch.CollapseEntry> collapseListDst;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private NativeArray<int> newIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private NativeArray<bool> vertexUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private NativeArray<int> mapVertSrcToDst;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private NativeArray<int> vertexLowestToVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private NativeArray<float> vertexLowestToError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private NativeArray<int> vertexCollapseListToVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private NativeArray<float> vertexCollapseListToErrorMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private NativeArray<int> vertexCollapseListToRefCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private NativeArray<int> vertexLowestCoincidentToVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private NativeArray<float> vertexAccumulatedError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private NativeArray<float> vertexArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private NativeArray<int> vertexCoincidentLink;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void IWUVYCBEDFN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void IWUVYCBEDFN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[BurstDiscard]
		public static void KFKCZHYVWEG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7490", Offset = "0x8AF6090", VA = "0x188AF7490")]
		public ScaleMeshToDesiredTriCountsJob([In] List<ShapeBatch.ScaledMesh> meshListIn, NativeList<ShapeBatch.CollapseEntry> collapseListOut, [In] NativeMesh meshSrcIn, [In] NativeList<ShapeBatch.CollapseEntry> collapseListIn, [In] NativeArray<long> scaleMeshJobAbortRequest, float3 bboxMin, float3 bboxMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6A10", Offset = "0x8AF5610", VA = "0x188AF6A10")]
		public static long LXOUIHXNSKR(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4A20", Offset = "0x8AF3620", VA = "0x188AF4A20", Slot = "4")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3D70", Offset = "0x8AF2970", VA = "0x188AF3D70")]
		public void DARFXICAMFC(List<ShapeBatch.ScaledMesh> a, [In] ShapeBatch shapeBatchIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3D50", Offset = "0x8AF2950", VA = "0x188AF3D50")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private bool AbortRequested()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6A30", Offset = "0x8AF5630", VA = "0x188AF6A30")]
		private CompressedNativeMeshStruct NBBTAKKOIUR(int a, Allocator b)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4A70", Offset = "0x8AF3670", VA = "0x188AF4A70")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private void HAMKAROQOZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6C60", Offset = "0x8AF5860", VA = "0x188AF6C60")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private float YJAZTTTLGEX(int a, int b, bool c, bool d, float e, float f, float g, float h, float i, float j, float k)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF64C0", Offset = "0x8AF50C0", VA = "0x188AF64C0")]
		[IgnoreWarning(1371)]
		private ScaledMeshJob HKZDFLVUFOL([In] ScaledMeshJob scaledMeshJobSrc, int a, [In] NativeArray<int> indices, [In] NativeArray<bool> vertexUsed, NativeArray<int> b)
		{
			return default(ScaledMeshJob);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6830", Offset = "0x8AF5430", VA = "0x188AF6830")]
		public static int JUMRNITLCJN(NativeArray<int> a, NativeArray<int> b, int c, int d, int e)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class BatchedMeshRenderer : MonoBehaviour, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		private struct BoundsShape
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public long spatialIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public RRBounds bounds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public WUIPFZRTCEH shape;

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x8AF25A0", Offset = "0x8AF11A0", VA = "0x188AF25A0")]
			public BoundsShape(RRBounds inBounds, WUIPFZRTCEH inEntry)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		private class MIICGZUWRPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public RRBounds FZCJFUVFILC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public int RNWXKCRXZMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public float TNJNDVZDDHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public List<BoundsShape> IXOJHJLEYRV;

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x8AF2DB0", Offset = "0x8AF19B0", VA = "0x188AF2DB0")]
			public MIICGZUWRPN(RRBounds a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static bool OpenGLSRPBatchSupport;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private static readonly ProfilerMarker PWMDQDYGWBX;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private static readonly ProfilerMarker CWVEUSWFZBM;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private static readonly ProfilerMarker OIJMWJROWTG;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private static readonly ProfilerMarker CRIECHRHVWV;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private static readonly ProfilerMarker GRTHXXBLYLV;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private static readonly ProfilerMarker JIOUAKAUVZM;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private static readonly ProfilerMarker YPRNKYBOPVF;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		internal const int UUNWQGDWOYE = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		internal static Dictionary<Material, List<Material>> PYMFXOOTPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private Dictionary<Material, List<BatchedMesh>> YRWIONOHUMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		internal List<BatchedMesh> MASIZKMYHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private List<MeshRenderer> MFYJQHRWVZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private Transform MPCGKMLBPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private bool LXUDOMODISP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private bool MMDMGNVDATK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private int SAXXWLXFAQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private BatchedMesh FJUPCHLBEMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private Material JATZPZKIOSD;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static bool? AXACTPNJZQZ;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private const int PJGEFZDWFHS = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private static List<BoundsShape> OZXHFNZOESF;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<MeshRenderer> RPRUSAUHRPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int IBILSWQAILB
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x8AED060", Offset = "0x8AEBC60", VA = "0x188AED060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private static bool JIOIVNLQOLP
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8AE7090", Offset = "0x8AE5C90", VA = "0x188AE7090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6FA0", Offset = "0x8AE5BA0", VA = "0x188AE6FA0")]
		private static void IWUVYCBEDFN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6F30", Offset = "0x8AE5B30", VA = "0x188AE6F30")]
		private static void IWUVYCBEDFN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		private static void WFNQYBDRLYQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5EC0", Offset = "0x8AE4AC0", VA = "0x188AE5EC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8AE61D0", Offset = "0x8AE4DD0", VA = "0x188AE61D0")]
		internal bool DNDGWUDFFGV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7D00", Offset = "0x8AE6900", VA = "0x188AE7D00")]
		private Transform RYJZOYDWJDR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7A10", Offset = "0x8AE6610", VA = "0x188AE7A10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6230", Offset = "0x8AE4E30", VA = "0x188AE6230", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5AF0", Offset = "0x8AE46F0", VA = "0x188AE5AF0")]
		public BatchedMesh AddToBatchedMesh(WUIPFZRTCEH newMesh, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8AEB940", Offset = "0x8AEA540", VA = "0x188AEB940")]
		public void RemoveFromBatchedMesh(WUIPFZRTCEH mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE60A0", Offset = "0x8AE4CA0", VA = "0x188AE60A0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5EF0", Offset = "0x8AE4AF0", VA = "0x188AE5EF0")]
		private void BDWJAQHIGFP(Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7020", Offset = "0x8AE5C20", VA = "0x188AE7020")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7010", Offset = "0x8AE5C10", VA = "0x188AE7010")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC530", Offset = "0x8AEB130", VA = "0x188AEC530")]
		private void VAJYLEMYJKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7310", Offset = "0x8AE5F10", VA = "0x188AE7310")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8AE58F0", Offset = "0x8AE44F0", VA = "0x188AE58F0")]
		private BatchedMesh AAGOZKTKCSM(WUIPFZRTCEH a, Material b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7A20", Offset = "0x8AE6620", VA = "0x188AE7A20")]
		private BatchedMesh PYGUSQMZMRM(Material a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8AEBA80", Offset = "0x8AEA680", VA = "0x188AEBA80")]
		private BatchedMesh TSWKWNYYKHJ(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6E90", Offset = "0x8AE5A90", VA = "0x188AE6E90")]
		internal float4x4 HJGFKEBFIIA()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6640", Offset = "0x8AE5240", VA = "0x188AE6640")]
		public static List<Material> GenerateVertexFormatVariants(Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC430", Offset = "0x8AEB030", VA = "0x188AEC430")]
		public static void UpdateMaterialVariants(Material parentMaterial, Action<Material> updateFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xFA51C0", Offset = "0xFA3DC0", VA = "0x180FA51C0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8AE71B0", Offset = "0x8AE5DB0", VA = "0x188AE71B0")]
		public void MarkDirty(WUIPFZRTCEH mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8AE78A0", Offset = "0x8AE64A0", VA = "0x188AE78A0")]
		[Conditional("CHECK_STATE")]
		private void NDTISZKNAZX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7470", Offset = "0x8AE6070", VA = "0x188AE7470")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float scalabilityErrorControl)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5F70", Offset = "0x8AE4B70", VA = "0x188AE5F70")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8AEA0D0", Offset = "0x8AE8CD0", VA = "0x188AEA0D0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8AE67B0", Offset = "0x8AE53B0", VA = "0x188AE67B0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7F00", Offset = "0x8AE6B00", VA = "0x188AE7F00")]
		public void RebatchOptimally(int batchSizeNaughty, int batchSizeNice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7E20", Offset = "0x8AE6A20", VA = "0x188AE7E20")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8AECF50", Offset = "0x8AEBB50", VA = "0x188AECF50")]
		public BatchedMeshRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public static class BatchedMeshScalabilityManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private struct FindAndMarkAsFrozenCache
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public BatchedMeshRenderer renderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public BatchedMesh mesh;

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x20309B0", Offset = "0x202F5B0", VA = "0x1820309B0")]
			public void HVSQMUYLXYJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct BatchedMeshSortedItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public float pixelsOfError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public BatchedMesh bm;
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class WJNYECKIYAP : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			private bool DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			private long DQAMYMFBTUZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public long NRPBCEYXYQA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			private bool SCCHKNUXTBQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public bool TSEGWQKITNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private int AFVIFIORVEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			private int XEOONZJHVBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			private int WNFCLAXALIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			private int WHLLMYUYWNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			private List<BatchedMeshRenderer>.Enumerator OLHZCZSXGSZ;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			private bool STYIVUZOKDJ
			{
				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x13E8500", Offset = "0x13E7100", VA = "0x1813E8500", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x7DDDE50", Offset = "0x7DDCA50", VA = "0x187DDDE50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x1659E00", Offset = "0x1658A00", VA = "0x181659E00")]
			[DebuggerHidden]
			public WJNYECKIYAP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8AF98E0", Offset = "0x8AF84E0", VA = "0x188AF98E0", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x8AF83E0", Offset = "0x8AF6FE0", VA = "0x188AF83E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8AF97B0", Offset = "0x8AF83B0", VA = "0x188AF97B0")]
			private void QCWGZBRZQOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9760", Offset = "0x8AF8360", VA = "0x188AF9760")]
			private void QCRABUYCHCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8AF98A0", Offset = "0x8AF84A0", VA = "0x188AF98A0", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9800", Offset = "0x8AF8400", VA = "0x188AF9800", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> QDBAIOERJBS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9800", Offset = "0x8AF8400", VA = "0x188AF9800", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private static readonly ProfilerMarker JIOUAKAUVZM;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private static readonly ProfilerMarker EAJBPTVONAO;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private static readonly ProfilerMarker ZPNCNYEKSJC;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private static readonly ProfilerMarker CTIPMCFZXZO;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static float3 MBEYMKLONYV;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static int TVQVCJFUGLG;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static int RFOBEBNJXOD;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static int CBEGHFOXHJQ;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static int UULOOFBYMNZ;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static int QQNWGBLUQWB;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static float JTKJHRBRJWM;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static float PFBIBOOMPGK;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static float NGAZJPVFPQG;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static float SJLEANNIYCX;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static float QQSOKPAVHUM;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static float BXUBLDMNMYT;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static float GRMYTNUUOPP;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static float LSHHQHLODHC;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static List<BatchedMeshRenderer> WHWDUTXSBBP;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static Stack<NativeMesh> EJQNHTUXHJW;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private static Stack<MWSUROXMZRO> HYAQYPIDVHV;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static NVNPOIWJKBV DSPXDCPVDQG;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private static FindAndMarkAsFrozenCache QWYJNMCJTHI;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static int AQLWKAMLKTN;

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8AEDE40", Offset = "0x8AECA40", VA = "0x188AEDE40")]
		private static void IWUVYCBEDFN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE640", Offset = "0x8AED240", VA = "0x188AEE640")]
		private static void KFKCZHYVWEG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8AEDDD0", Offset = "0x8AEC9D0", VA = "0x188AEDDD0")]
		private static void IWUVYCBEDFN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8AEDD50", Offset = "0x8AEC950", VA = "0x188AEDD50")]
		public static void HRTIXRMSTIX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF540", Offset = "0x8AEE140", VA = "0x188AEF540")]
		public static void NDFNGHHUGET(BatchedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8AED0B0", Offset = "0x8AEBCB0", VA = "0x188AED0B0")]
		public static void AYBIYDBIHWM(BatchedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8AEDEB0", Offset = "0x8AECAB0", VA = "0x188AEDEB0")]
		public static void JGAYYVUPHKA(WUIPFZRTCEH a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AED4C0", Offset = "0x8AEC0C0", VA = "0x188AED4C0")]
		public static void GPYFMSRXIHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x8AED370", Offset = "0x8AEBF70", VA = "0x188AED370")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void FSOTSMSHFSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF8C0", Offset = "0x8AEE4C0", VA = "0x188AEF8C0")]
		public static void TBILQTKWXMM(float a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8AED850", Offset = "0x8AEC450", VA = "0x188AED850")]
		private static void GWJJXDVGCOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE820", Offset = "0x8AED420", VA = "0x188AEE820")]
		public static long KZSJOELVZHX(int a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF330", Offset = "0x8AEDF30", VA = "0x188AEF330")]
		public static (long, long, int) MMCUWTHOGND(float a)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8AF01D0", Offset = "0x8AEEDD0", VA = "0x188AF01D0")]
		[IteratorStateMachine(typeof(WJNYECKIYAP))]
		public static IEnumerable<bool> UETVSAJLSNM(long a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0A60", Offset = "0x8AEF660", VA = "0x188AF0A60")]
		public static void ZZYCSBVFSYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0700", Offset = "0x8AEF300", VA = "0x188AF0700")]
		public static void YRYGTBAWMGO(long a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8AED1E0", Offset = "0x8AEBDE0", VA = "0x188AED1E0")]
		public static int ELSDHXPZXLG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0250", Offset = "0x8AEEE50", VA = "0x188AF0250")]
		internal static NativeMesh ULFNBDPNQWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0490", Offset = "0x8AEF090", VA = "0x188AF0490")]
		internal static void VVHMKSSDYNP(NativeMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE6D0", Offset = "0x8AED2D0", VA = "0x188AEE6D0")]
		internal static MWSUROXMZRO KHJLWYJUREZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0600", Offset = "0x8AEF200", VA = "0x188AF0600")]
		internal static void VVHMKSSDYNP(MWSUROXMZRO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF6E0", Offset = "0x8AEE2E0", VA = "0x188AEF6E0")]
		public static void OEVXHEDVNPO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class WZHFGILNCDS<a> : BatchedMesh
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private readonly Dictionary<a, WUIPFZRTCEH> VFWEESBMGSG;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E550", Offset = "0x6D7D150", VA = "0x186D7E550")]
		public WZHFGILNCDS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D7DED0", Offset = "0x6D7CAD0", VA = "0x186D7DED0")]
		public void AIVDSLYNVEF(a a, WUIPFZRTCEH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E1E0", Offset = "0x6D7CDE0", VA = "0x186D7E1E0")]
		public bool GUQKGJWMXMA(a a, WUIPFZRTCEH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E4C0", Offset = "0x6D7D0C0", VA = "0x186D7E4C0")]
		public void JLWYTCDNEAT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E2A0", Offset = "0x6D7CEA0", VA = "0x186D7E2A0", Slot = "4")]
		public override void ILVRBQRVUNE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class WRVJIPOEJSB
	{
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly ProfilerCategory SUBEAENUMTW;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		internal static readonly ProfilerMarker HQREWMRGTET;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		internal static readonly RuntimeMarker TBILQTKWXMM;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private static readonly RuntimeCounterValue<float> PZXOBEQAGTV;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private static readonly RuntimeCounterValue<float> LNRQNFZFQJN;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private static readonly RuntimeCounterValue<double> WTQPNQATIXV;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private static readonly RuntimeCounterValue<double> CKJECIBIFBF;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private static readonly RuntimeCounterValue<double> BSLYYFURTQG;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private static readonly RuntimeCounterValue<int> IMOYCCBBLJQ;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private static readonly RuntimeCounterValue<int> CQFKBOIASOW;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private static readonly RuntimeCounterValue<int> CDXHQXUUXJW;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private static readonly RuntimeCounterValue<int> JXPWSRIMQMF;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private static readonly RuntimeCounterValue<int> UIMXVNTQXRG;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private static readonly RuntimeCounterValue<int> RPMSYNKZCEM;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private static readonly RuntimeCounterValue<int> DGMOIJSXRKN;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private static readonly RuntimeCounterValue<int> NGJXURLKVSY;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private static readonly RuntimeCounterValue<long> KHHXCVQDKPA;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private static readonly RuntimeCounterValue<long> ORAKCRHLRFX;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private static readonly RuntimeCounterValue<long> WGIYXBVOPLC;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static readonly RuntimeCounterValue<long> RFYUKCAIXSG;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static readonly RuntimeCounterValue<long> FITUDVYXOMW;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly RuntimeCounterValue<long> ULCZZWAOUYP;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9A40", Offset = "0x8AF8640", VA = "0x188AF9A40")]
		public static void GLGLIRWWOHR()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1169581178
{
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA750", Offset = "0x8AF9350", VA = "0x188AFA750")]
	public static void TGIQTAWGCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA740", Offset = "0x8AF9340", VA = "0x188AFA740")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9A00", Offset = "0x8AF8600", VA = "0x188AF9A00")]
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
