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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A413C0", Offset = "0x9A3FDC0", VA = "0x189A413C0", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal static class LNXMKWNINOZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly Log PMLOVPAFHVL;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly Log RWRDARDGBXO;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly Log VVFBBEZLQPI;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly Log XDBEPQIZFKF;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly Log BVSOHHKFVDI;
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
		public CompressedNativeMeshStruct GUIGHZQEUXP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int DPFYQKCZRRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD07B10", VA = "0x180D09110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		internal static class APHYRZPUXOU
		{
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9A30B50", Offset = "0x9A2F550", VA = "0x189A30B50")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9A30780", Offset = "0x9A2F180", VA = "0x189A30780")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9A30900", Offset = "0x9A2F300", VA = "0x189A30900")]
			public unsafe static void Invoke([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int vertexCount, [In] float3 vertMin, [In] float3 vertScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllVerts_0000003D$PostfixBurstDelegate([NoAlias] ushort* dstVerts, [Out] float3 vertMinimum, [Out] float3 vertScale, [In][NoAlias] float3* srcVerts, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal static class MKNFOHNDEQW
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9A41AD0", Offset = "0x9A404D0", VA = "0x189A41AD0")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9A416F0", Offset = "0x9A400F0", VA = "0x189A416F0")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9A41870", Offset = "0x9A40270", VA = "0x189A41870")]
			public unsafe static void Invoke([NoAlias] ushort* dstVerts, [Out] float3 vertMinimum, [Out] float3 vertScale, [In][NoAlias] float3* srcVerts, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllNormals_0000003F$PostfixBurstDelegate([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class EQSHNEXBFTC
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9A3EAF0", Offset = "0x9A3D4F0", VA = "0x189A3EAF0")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9A3E700", Offset = "0x9A3D100", VA = "0x189A3E700")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9A3E880", Offset = "0x9A3D280", VA = "0x189A3E880")]
			public unsafe static void Invoke([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void GetAllNormals_00000041$PostfixBurstDelegate([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		internal static class ZRUXDNZMORQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9A51F10", Offset = "0x9A50910", VA = "0x189A51F10")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9A51B20", Offset = "0x9A50520", VA = "0x189A51B20")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9A51CA0", Offset = "0x9A506A0", VA = "0x189A51CA0")]
			public unsafe static void Invoke([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllUVs_00000048$PostfixBurstDelegate([NoAlias] uint* dstUVs, [Out] float2 uvMinimum, [Out] float2 uvScale, [In][NoAlias] float2* srcUVs, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		internal static class SMVTKRXWGPL
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9A4AC50", Offset = "0x9A49650", VA = "0x189A4AC50")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9A4A870", Offset = "0x9A49270", VA = "0x189A4A870")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9A4A9F0", Offset = "0x9A493F0", VA = "0x189A4A9F0")]
			public unsafe static void Invoke([NoAlias] uint* dstUVs, [Out] float2 uvMinimum, [Out] float2 uvScale, [In][NoAlias] float2* srcUVs, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void GetUV_00000049$PostfixBurstDelegate([Out] float2 ret, uint compressed, [In] float2 uvMin, [In] float2 uvScale);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class BIFNNJQOVHW
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9A31690", Offset = "0x9A30090", VA = "0x189A31690")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9A312B0", Offset = "0x9A2FCB0", VA = "0x189A312B0")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9A31430", Offset = "0x9A2FE30", VA = "0x189A31430")]
			public static void Invoke([Out] float2 ret, uint compressed, [In] float2 uvMin, [In] float2 uvScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void GetAllUVs_0000004B$PostfixBurstDelegate([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int vertexCount, [In] float2 uvMin, [In] float2 uvScale);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		internal static class VDSSHTZCDBR
		{
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9A4D200", Offset = "0x9A4BC00", VA = "0x189A4D200")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9A4CDD0", Offset = "0x9A4B7D0", VA = "0x189A4CDD0")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9A4CF50", Offset = "0x9A4B950", VA = "0x189A4CF50")]
			public unsafe static void Invoke([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int vertexCount, [In] float2 uvMin, [In] float2 uvScale)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetAllTangents_00000052$PostfixBurstDelegate([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal static class KYBIFZLKACK
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9A40BC0", Offset = "0x9A3F5C0", VA = "0x189A40BC0")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9A407D0", Offset = "0x9A3F1D0", VA = "0x189A407D0")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9A40950", Offset = "0x9A3F350", VA = "0x189A40950")]
			public unsafe static void Invoke([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate ushort SetTangent_00000053$PostfixBurstDelegate([In] float4 newVal);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		internal static class NAKIBQNPFEV
		{
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9A425E0", Offset = "0x9A40FE0", VA = "0x189A425E0")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9A421E0", Offset = "0x9A40BE0", VA = "0x189A421E0")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9A42360", Offset = "0x9A40D60", VA = "0x189A42360")]
			public static ushort Invoke([In] float4 newVal)
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void GetAllTangents_00000055$PostfixBurstDelegate([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class VQFXAAOEJDZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9A4DE60", Offset = "0x9A4C860", VA = "0x189A4DE60")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9A4DA70", Offset = "0x9A4C470", VA = "0x189A4DA70")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9A4DBF0", Offset = "0x9A4C5F0", VA = "0x189A4DBF0")]
			public unsafe static void Invoke([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void GetTangent_0000005B$PostfixBurstDelegate([Out] float4 result, ushort compressed);

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		internal static class FWCGCDVGHCS
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9A3F950", Offset = "0x9A3E350", VA = "0x189A3F950")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9A3F530", Offset = "0x9A3DF30", VA = "0x189A3F530")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9A3F6B0", Offset = "0x9A3E0B0", VA = "0x189A3F6B0")]
			public static void Invoke([Out] float4 result, ushort compressed)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void CreateAllMaterialIndices_0000005D$PostfixBurstDelegate([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int numData, [Out] int numRLEs, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int firstIndex, int numIndices);

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		internal static class UVAECQOGFNY
		{
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9A4CC40", Offset = "0x9A4B640", VA = "0x189A4CC40")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9A4C820", Offset = "0x9A4B220", VA = "0x189A4C820")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9A4C9A0", Offset = "0x9A4B3A0", VA = "0x189A4C9A0")]
			public unsafe static void Invoke([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int numData, [Out] int numRLEs, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int firstIndex, int numIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void DecodeMaterialIndices_0000005F$PostfixBurstDelegate([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		internal static class UCEBACVPNJH
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9A4BBF0", Offset = "0x9A4A5F0", VA = "0x189A4BBF0")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9A4B760", Offset = "0x9A4A160", VA = "0x189A4B760")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9A4B8E0", Offset = "0x9A4A2E0", VA = "0x189A4B8E0")]
			public unsafe static void Invoke([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int vertexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate int EncodeIndices_00000067$PostfixBurstDelegate([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int srcIndexCount);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		internal static class ASRMVUKYHEE
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9A31120", Offset = "0x9A2FB20", VA = "0x189A31120")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9A30CE0", Offset = "0x9A2F6E0", VA = "0x189A30CE0")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9A30E60", Offset = "0x9A2F860", VA = "0x189A30E60")]
			public unsafe static int Invoke([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int srcIndexCount)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void DecodeIndices_00000069$PostfixBurstDelegate([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int indexCount);

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		internal static class OOOVKTXJPQW
		{
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9A49C00", Offset = "0x9A48600", VA = "0x189A49C00")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x9A49800", Offset = "0x9A48200", VA = "0x189A49800")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9A49980", Offset = "0x9A48380", VA = "0x189A49980")]
			public unsafe static void Invoke([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int indexCount)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void DecodeNormal_0000006B$PostfixBurstDelegate([Out] float3 ret, ushort compressed);

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		internal static class JIZMITLRGRH
		{
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9A40150", Offset = "0x9A3EB50", VA = "0x189A40150")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9A3FDC0", Offset = "0x9A3E7C0", VA = "0x189A3FDC0")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9A3FF40", Offset = "0x9A3E940", VA = "0x189A3FF40")]
			public static void Invoke([Out] float3 ret, ushort compressed)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate ushort EncodeNormal_0000006C$PostfixBurstDelegate([In] float3 newVal);

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		internal static class SGZZDYVRTXU
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9A4A6F0", Offset = "0x9A490F0", VA = "0x189A4A6F0")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9A4A360", Offset = "0x9A48D60", VA = "0x189A4A360")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9A4A4E0", Offset = "0x9A48EE0", VA = "0x189A4A4E0")]
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
		public bool GFOEGTWSQZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9A33AF0", Offset = "0x9A324F0", VA = "0x189A33AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool NGPMMHTNJWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9A33E00", Offset = "0x9A32800", VA = "0x189A33E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A32620", Offset = "0x9A31020", VA = "0x189A32620")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A32230", Offset = "0x9A30C30", VA = "0x189A32230")]
		public static CompressedNativeMeshStruct Create(Allocator allocator, NativeMesh srcMesh)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9A31C70", Offset = "0x9A30670", VA = "0x189A31C70")]
		public static CompressedNativeMeshStruct Create(Allocator allocator, NativeArray<float3> srcVerts, NativeArray<float3> srcNormals, NativeArray<float2> srcUVs, NativeArray<float4> srcMaterialIndices, bool hasTangents, NativeArray<float4> srcTangents, NativeArray<int> srcIndices, int vertexCount, int firstVertex, int indexCount, int firstIndex)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9A33070", Offset = "0x9A31A70", VA = "0x189A33070")]
		public void OFODBMEUJIC(NativeMesh a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9A32F70", Offset = "0x9A31970", VA = "0x189A32F70")]
		public long NZLLVQFWKRW()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9A33A80", Offset = "0x9A32480", VA = "0x189A33A80")]
		public long SJKBPEYLRGV(NativeMesh.UnityMeshFormat a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A32750", Offset = "0x9A31150", VA = "0x189A32750")]
		private void ERBUWECJNLH(int a, int b, Allocator c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9A31B70", Offset = "0x9A30570", VA = "0x189A31B70")]
		private void CYMMGELCPZD(NativeArray<float3> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9A31C60", Offset = "0x9A30660", VA = "0x189A31C60")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllVerts_00000036$PostfixBurstDelegate))]
		private unsafe static void CYMMGELCPZD([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int a, [In] float3 vertMin, [In] float3 vertScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9A32520", Offset = "0x9A30F20", VA = "0x189A32520")]
		private void DWPRGSOGJYJ(NativeArray<float3> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9A32510", Offset = "0x9A30F10", VA = "0x189A32510")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllVerts_0000003D$PostfixBurstDelegate))]
		private unsafe static void DWPRGSOGJYJ([NoAlias] ushort* dstVerts, [Out] float3 a, [Out] float3 b, [In][NoAlias] float3* srcVerts, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9A34070", Offset = "0x9A32A70", VA = "0x189A34070")]
		private void ZJKZKIPLEBX(NativeArray<float3> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A34150", Offset = "0x9A32B50", VA = "0x189A34150")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllNormals_0000003F$PostfixBurstDelegate))]
		private unsafe static void ZJKZKIPLEBX([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A32DB0", Offset = "0x9A317B0", VA = "0x189A32DB0")]
		private void NCELQVSPRIR(NativeArray<float3> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9A32DA0", Offset = "0x9A317A0", VA = "0x189A32DA0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllNormals_00000041$PostfixBurstDelegate))]
		private unsafe static void NCELQVSPRIR([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9A33D10", Offset = "0x9A32710", VA = "0x189A33D10")]
		private void WEXIBRAXCMB(NativeArray<float2> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9A33D00", Offset = "0x9A32700", VA = "0x189A33D00")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllUVs_00000048$PostfixBurstDelegate))]
		private unsafe static void WEXIBRAXCMB([NoAlias] uint* dstUVs, [Out] float2 a, [Out] float2 b, [In][NoAlias] float2* srcUVs, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A33980", Offset = "0x9A32380", VA = "0x189A33980")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetUV_00000049$PostfixBurstDelegate))]
		private static void RXIKBEKEYET([Out] float2 a, uint b, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9A32E70", Offset = "0x9A31870", VA = "0x189A32E70")]
		private void NUQLCQCYNKV(NativeArray<float2> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A32F60", Offset = "0x9A31960", VA = "0x189A32F60")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllUVs_0000004B$PostfixBurstDelegate))]
		private unsafe static void NUQLCQCYNKV([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int a, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A33F90", Offset = "0x9A32990", VA = "0x189A33F90")]
		private void YNBEAHVQXUZ(NativeArray<float4> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A33F80", Offset = "0x9A32980", VA = "0x189A33F80")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetAllTangents_00000052$PostfixBurstDelegate))]
		private unsafe static void YNBEAHVQXUZ([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9A32D90", Offset = "0x9A31790", VA = "0x189A32D90")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetTangent_00000053$PostfixBurstDelegate))]
		private static ushort LIDNFWMEGIV([In] float4 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9A33B30", Offset = "0x9A32530", VA = "0x189A33B30")]
		private void TTZGYCJQYQJ(NativeArray<float4> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A33BF0", Offset = "0x9A325F0", VA = "0x189A33BF0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetAllTangents_00000055$PostfixBurstDelegate))]
		private unsafe static void TTZGYCJQYQJ([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9A32A30", Offset = "0x9A31430", VA = "0x189A32A30")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.GetTangent_0000005B$PostfixBurstDelegate))]
		private static void ILTANQARXMN([Out] float4 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A333B0", Offset = "0x9A31DB0", VA = "0x189A333B0")]
		private void OIRKTQAPRSP(Allocator a, NativeArray<float4> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9A33830", Offset = "0x9A32230", VA = "0x189A33830")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.CreateAllMaterialIndices_0000005D$PostfixBurstDelegate))]
		private unsafe static void OIRKTQAPRSP([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int a, [Out] int b, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A32A50", Offset = "0x9A31450", VA = "0x189A32A50")]
		private static void INZLTMZEILC(NativeArray<float4> a, NativeArray<MaterialIndex> b, NativeArray<byte> c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9A32A40", Offset = "0x9A31440", VA = "0x189A32A40")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeMaterialIndices_0000005F$PostfixBurstDelegate))]
		private unsafe static void INZLTMZEILC([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9A33C00", Offset = "0x9A32600", VA = "0x189A33C00")]
		private void USLBCGNPMGM(Allocator a, NativeArray<int> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9A31830", Offset = "0x9A30230", VA = "0x189A31830")]
		private static NativeArray<byte> ABNSETEUHQP(Allocator a, NativeArray<int> b, int c)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9A31820", Offset = "0x9A30220", VA = "0x189A31820")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.EncodeIndices_00000067$PostfixBurstDelegate))]
		private unsafe static int ABNSETEUHQP([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9A32BF0", Offset = "0x9A315F0", VA = "0x189A32BF0")]
		private static void JIDFXBLUMYD(NativeArray<int> a, NativeArray<byte> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9A32BE0", Offset = "0x9A315E0", VA = "0x189A32BE0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeIndices_00000069$PostfixBurstDelegate))]
		private unsafe static void JIDFXBLUMYD([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9A32740", Offset = "0x9A31140", VA = "0x189A32740")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.DecodeNormal_0000006B$PostfixBurstDelegate))]
		private static void ECIJLAFUDSN([Out] float3 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9A32610", Offset = "0x9A31010", VA = "0x189A32610")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.EncodeNormal_0000006C$PostfixBurstDelegate))]
		private static ushort DZSGQUIAZPL([In] float3 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9A2ED70", Offset = "0x9A2D770", VA = "0x189A2ED70")]
		[BurstCompile]
		internal unsafe static void CZYFAHHXIRO([NoAlias] float3* dstVerts, [In][NoAlias] ushort* srcVerts, int a, [In] float3 vertMin, [In] float3 vertScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9A2F190", Offset = "0x9A2DB90", VA = "0x189A2F190")]
		[BurstCompile]
		internal unsafe static void JUCOPWKMVKU([NoAlias] ushort* dstVerts, [Out] float3 a, [Out] float3 b, [In][NoAlias] float3* srcVerts, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A338E0", Offset = "0x9A322E0", VA = "0x189A338E0")]
		[BurstCompile]
		internal unsafe static void REBGOHNXJAE([NoAlias] ushort* dstWords, [In][NoAlias] float3* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9A339D0", Offset = "0x9A323D0", VA = "0x189A339D0")]
		[BurstCompile]
		internal unsafe static void SBJCGVCRVLC([NoAlias] float3* dstNormals, [In][NoAlias] ushort* srcNormals, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9A2F5C0", Offset = "0x9A2DFC0", VA = "0x189A2F5C0")]
		[BurstCompile]
		internal unsafe static void LDUPUJVXGSM([NoAlias] uint* dstUVs, [Out] float2 a, [Out] float2 b, [In][NoAlias] float2* srcUVs, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9A33990", Offset = "0x9A32390", VA = "0x189A33990")]
		[BurstCompile]
		internal static void SASKBOWRNSK([Out] float2 a, uint b, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9A32CB0", Offset = "0x9A316B0", VA = "0x189A32CB0")]
		[BurstCompile]
		internal unsafe static void KCUXGMJYFYY([NoAlias] float2* dstUVs, [NoAlias] uint* srcUVs, int a, [In] float2 uvMin, [In] float2 uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9A31AD0", Offset = "0x9A304D0", VA = "0x189A31AD0")]
		[BurstCompile]
		internal unsafe static void BCTIIIFLJYQ([NoAlias] ushort* dstTangents, [In][NoAlias] float4* srcTangent, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9A32B50", Offset = "0x9A31550", VA = "0x189A32B50")]
		[BurstCompile]
		internal static ushort IYHNBKQVTMQ([In] float4 newVal)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A32880", Offset = "0x9A31280", VA = "0x189A32880")]
		[BurstCompile]
		internal unsafe static void GCNHPDDKFKI([NoAlias] float4* dstTangents, [In][NoAlias] ushort* srcTangents, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9A34160", Offset = "0x9A32B60", VA = "0x189A34160")]
		[BurstCompile]
		internal static void ZJRKJTLUHQE([Out] float4 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9A2F8A0", Offset = "0x9A2E2A0", VA = "0x189A2F8A0")]
		[BurstCompile]
		internal unsafe static void NPJOMQIKADI([NoAlias] float4* matIndexData, [NoAlias] byte* matRLE, [Out] int a, [Out] int b, [NoAlias] float4* quantisedMaterialIndices, [NoAlias] float4* srcMaterialIndices, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9A33E40", Offset = "0x9A32840", VA = "0x189A33E40")]
		[BurstCompile]
		internal unsafe static void YHHSWICHDJJ([NoAlias] float4* dstMaterialIndices, [In][NoAlias] MaterialIndex* srcData, [In][NoAlias] byte* srcRLE, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9A32930", Offset = "0x9A31330", VA = "0x189A32930")]
		[BurstCompile]
		internal unsafe static int HRJNOTQDOZQ([NoAlias] byte* dstBytes, [In][NoAlias] int* srcIndices, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9A33840", Offset = "0x9A32240", VA = "0x189A33840")]
		[BurstCompile]
		internal unsafe static void RDNRWPUWOTM([NoAlias] int* dstIndices, [In][NoAlias] byte* srcBytes, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9A2FDD0", Offset = "0x9A2E7D0", VA = "0x189A2FDD0")]
		[BurstCompile]
		internal static void SHCDIKTMFUQ([Out] float3 a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9A2EFD0", Offset = "0x9A2D9D0", VA = "0x189A2EFD0")]
		[BurstCompile]
		internal static ushort GASJBZOLOFS([In] float3 newVal)
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
		internal static class ERLETOKVSNL
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x9A3F2E0", Offset = "0x9A3DCE0", VA = "0x189A3F2E0")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x9A3EC80", Offset = "0x9A3D680", VA = "0x189A3EC80")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x9A3EE00", Offset = "0x9A3D800", VA = "0x189A3EE00")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate int FloatToSnorm8_00000083$PostfixBurstDelegate(float x);

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		internal static class UEBKDTPJUNL
		{
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x9A4C170", Offset = "0x9A4AB70", VA = "0x189A4C170")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9A4BD80", Offset = "0x9A4A780", VA = "0x189A4BD80")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9A4BEE0", Offset = "0x9A4A8E0", VA = "0x189A4BEE0")]
			public static int Invoke(float x)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate uint FloatToSnorm8_00000084$PostfixBurstDelegate([In] float4 v);

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		internal static class MVNDCDZRUFO
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9A42060", Offset = "0x9A40A60", VA = "0x189A42060")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9A41C60", Offset = "0x9A40660", VA = "0x189A41C60")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9A41DE0", Offset = "0x9A407E0", VA = "0x189A41DE0")]
			public static uint Invoke([In] float4 v)
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate uint FloatToSnorm8_00000085$PostfixBurstDelegate([In] float3 v);

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		internal static class TWBJNAKJKKP
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9A4B540", Offset = "0x9A49F40", VA = "0x189A4B540")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9A4B160", Offset = "0x9A49B60", VA = "0x189A4B160")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9A4B2E0", Offset = "0x9A49CE0", VA = "0x189A4B2E0")]
			public static uint Invoke([In] float3 v)
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_NormTanSn8MatF16_00000087$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		internal static class ZLHTKTWTZID
		{
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9A4F680", Offset = "0x9A4E080", VA = "0x189A4F680")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x9A4F110", Offset = "0x9A4DB10", VA = "0x189A4F110")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x9A4F290", Offset = "0x9A4DC90", VA = "0x189A4F290")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_NormTanSn8UvMatF16_00000089$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		internal static class VJVCIEYVWPO
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x9A4D8E0", Offset = "0x9A4C2E0", VA = "0x189A4D8E0")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9A4D390", Offset = "0x9A4BD90", VA = "0x189A4D390")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9A4D510", Offset = "0x9A4BF10", VA = "0x189A4D510")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_NormTanOct8MatUi_0000008C$PostfixBurstDelegate([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		internal static class YSAQEYLLJWZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x9A4EF80", Offset = "0x9A4D980", VA = "0x189A4EF80")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x9A4E9F0", Offset = "0x9A4D3F0", VA = "0x189A4E9F0")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9A4EB70", Offset = "0x9A4D570", VA = "0x189A4EB70")]
			public unsafe static void Invoke([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_PosFixedPoint16NormTanOct8MatUi_0000008E$PostfixBurstDelegate([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 positionMin, [Out] float3 positionMax);

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		internal static class SELYFQCUHXM
		{
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x9A4A1D0", Offset = "0x9A48BD0", VA = "0x189A4A1D0")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x9A49D90", Offset = "0x9A48790", VA = "0x189A49D90")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x9A49F10", Offset = "0x9A48910", VA = "0x189A49F10")]
			public unsafe static void Invoke([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int vertexCount, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 positionMin, [Out] float3 positionMax)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_FastCopyIndices_00000090$PostfixBurstDelegate(int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class LGECCZFIWXW
		{
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x9A410C0", Offset = "0x9A3FAC0", VA = "0x189A410C0")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x9A40D50", Offset = "0x9A3F750", VA = "0x189A40D50")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9A40EB0", Offset = "0x9A3F8B0", VA = "0x189A40EB0")]
			public unsafe static void Invoke(int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupVertices_FastCopyIndices_00000091$PostfixBurstDelegate(int startIndex, int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class JUJYQXARARN
		{
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x9A40660", Offset = "0x9A3F060", VA = "0x189A40660")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x9A402E0", Offset = "0x9A3ECE0", VA = "0x189A402E0")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x9A40440", Offset = "0x9A3EE40", VA = "0x189A40440")]
			public unsafe static void Invoke(int startIndex, int indexCount, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void FastAppendIndices_00000093$PostfixBurstDelegate(int destStart, int sourceCount, int indexOffset, [In][NoAlias] int* dest, [In][NoAlias] int* source);

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		internal static class ONDLHRGEKVF
		{
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9A49690", Offset = "0x9A48090", VA = "0x189A49690")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9A49300", Offset = "0x9A47D00", VA = "0x189A49300")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x9A49460", Offset = "0x9A47E60", VA = "0x189A49460")]
			public unsafe static void Invoke(int destStart, int sourceCount, int indexOffset, [In][NoAlias] int* dest, [In][NoAlias] int* source)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void FindBestUnityMeshFormat_Fast_0000009D$PostfixBurstDelegate(int vertexCount, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices);

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		internal static class UNFTIWATEMC
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x9A4C6B0", Offset = "0x9A4B0B0", VA = "0x189A4C6B0")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9A4C2E0", Offset = "0x9A4ACE0", VA = "0x189A4C2E0")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x9A4C440", Offset = "0x9A4AE40", VA = "0x189A4C440")]
			public unsafe static void Invoke(int vertexCount, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const int NNQYXXCGQMB = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public NativeList<float3> AQPSISQQBLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NativeArray<float3> FRTHDLVTDSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NativeArray<float4> OUUHHAOWUSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NativeArray<float4> IVRSTMJMEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public NativeArray<float2> LQRYAQFRXHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public NativeList<int> KUUYPZTODZL;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly VertexAttributeDescriptor[][] EHURVYEDXIF;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static bool XJLMUTSLVNG;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static UnityMeshFormatInfo[] ZKSYFEQRYWT;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static VertexAttributeDescriptor[] RJKXPOCZYNQ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool GFOEGTWSQZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9A48780", Offset = "0x9A47180", VA = "0x189A48780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int JBWZWKMXDIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9A42760", Offset = "0x9A41160", VA = "0x189A42760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int AJWLMYRLRRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9A48FA0", Offset = "0x9A479A0", VA = "0x189A48FA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NGPMMHTNJWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x9A487C0", Offset = "0x9A471C0", VA = "0x189A487C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9A44C30", Offset = "0x9A43630", VA = "0x189A44C30")]
		public static VertexFormatKeyword HBHGSPEYJDK(UnityMeshFormat a)
		{
			return default(VertexFormatKeyword);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9A432D0", Offset = "0x9A41CD0", VA = "0x189A432D0")]
		public static void DYFRJESNZKA(VertexFormatKeyword a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9A433B0", Offset = "0x9A41DB0", VA = "0x189A433B0", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9A436C0", Offset = "0x9A420C0", VA = "0x189A436C0")]
		public void ERBUWECJNLH(int a, int b, Allocator c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9A46F90", Offset = "0x9A45990", VA = "0x189A46F90")]
		public void MVXAMSVJCJQ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9A432B0", Offset = "0x9A41CB0", VA = "0x189A432B0", Slot = "6")]
		public bool CKZCPJBXWQI(Mesh a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A43EB0", Offset = "0x9A428B0", VA = "0x189A43EB0")]
		public bool FGMEZIYXCOD(Mesh a, bool b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9A442E0", Offset = "0x9A42CE0", VA = "0x189A442E0")]
		public bool FQDASDPMULJ(Mesh a, NativeMesh b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9A465D0", Offset = "0x9A44FD0", VA = "0x189A465D0")]
		public bool LRKKPROQZOA(Mesh a, NativeMesh b, UnityMeshFormat c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9A45E20", Offset = "0x9A44820", VA = "0x189A45E20")]
		private void LCBNSHPRPZT(Mesh a, NativeMesh b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9A45AD0", Offset = "0x9A444D0", VA = "0x189A45AD0")]
		public void LCBNSHPRPZT(NativeArray<ushort> a, NativeArray<VertexFormat_NormTanOct8MatUi> b, Mesh c, NativeMesh d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9A42B90", Offset = "0x9A41590", VA = "0x189A42B90")]
		public void CBTLTXFXZVX(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9A476C0", Offset = "0x9A460C0", VA = "0x189A476C0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanMatF16_00000082$PostfixBurstDelegate))]
		private unsafe static void QMFDIOPWQJJ([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9A48970", Offset = "0x9A47370", VA = "0x189A48970")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000083$PostfixBurstDelegate))]
		public static int WNEBIRALPFE(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9A48980", Offset = "0x9A47380", VA = "0x189A48980")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000084$PostfixBurstDelegate))]
		public static uint WNEBIRALPFE([In] float4 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9A48990", Offset = "0x9A47390", VA = "0x189A48990")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FloatToSnorm8_00000085$PostfixBurstDelegate))]
		public static uint WNEBIRALPFE([In] float3 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9A476E0", Offset = "0x9A460E0", VA = "0x189A476E0")]
		public void SBDLKDSCDHA(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9A47590", Offset = "0x9A45F90", VA = "0x189A47590")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanSn8MatF16_00000087$PostfixBurstDelegate))]
		private unsafe static void PGEPRLVCSSQ([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9A452A0", Offset = "0x9A43CA0", VA = "0x189A452A0")]
		public void IERWHNBCMSJ(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9A48800", Offset = "0x9A47200", VA = "0x189A48800")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanSn8UvMatF16_00000089$PostfixBurstDelegate))]
		private unsafe static void WILYHGLEKMD([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9A46B80", Offset = "0x9A45580", VA = "0x189A46B80")]
		public void MGFGIQPSLEI(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9A46760", Offset = "0x9A45160", VA = "0x189A46760")]
		public void MGFGIQPSLEI(NativeArray<ushort> a, NativeArray<VertexFormat_NormTanOct8MatUi> b, Mesh c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9A45A40", Offset = "0x9A44440", VA = "0x189A45A40")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_NormTanOct8MatUi_0000008C$PostfixBurstDelegate))]
		public unsafe static void JAXSGKPPHUK([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9A47DF0", Offset = "0x9A467F0", VA = "0x189A47DF0")]
		public void SGAHBJRCHAX(Mesh a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9A44810", Offset = "0x9A43210", VA = "0x189A44810")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_PosFixedPoint16NormTanOct8MatUi_0000008E$PostfixBurstDelegate))]
		private unsafe static void GQDVJPETYFP([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 b, [Out] float3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9A459B0", Offset = "0x9A443B0", VA = "0x189A459B0")]
		public void IRNGNMNIOCP(Mesh a, UnityMeshFormat b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9A45A50", Offset = "0x9A44450", VA = "0x189A45A50")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_FastCopyIndices_00000090$PostfixBurstDelegate))]
		private unsafe static void JYJTBFPYOUN(int a, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9A45A60", Offset = "0x9A44460", VA = "0x189A45A60")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.SetupVertices_FastCopyIndices_00000091$PostfixBurstDelegate))]
		private unsafe static void JYJTBFPYOUN(int a, int b, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9A44C80", Offset = "0x9A43680", VA = "0x189A44C80")]
		public void HSHRCEPTJZO(NativeMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9A432A0", Offset = "0x9A41CA0", VA = "0x189A432A0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FastAppendIndices_00000093$PostfixBurstDelegate))]
		private unsafe static void CJMPXJGDWDN(int a, int b, int c, [In][NoAlias] int* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9A475A0", Offset = "0x9A45FA0", VA = "0x189A475A0")]
		public void PSEZHHULQFH(NativeMesh a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9A47200", Offset = "0x9A45C00", VA = "0x189A47200")]
		public long NZLLVQFWKRW()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9A47330", Offset = "0x9A45D30", VA = "0x189A47330")]
		public static long NZLLVQFWKRW(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9A486E0", Offset = "0x9A470E0", VA = "0x189A486E0")]
		public static long SJKBPEYLRGV(int a, int b, UnityMeshFormat c)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9A48600", Offset = "0x9A47000", VA = "0x189A48600")]
		public long SJKBPEYLRGV(UnityMeshFormat a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9A45A70", Offset = "0x9A44470", VA = "0x189A45A70")]
		public void KNDRVHQQEVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9A438B0", Offset = "0x9A422B0", VA = "0x189A438B0")]
		public static void FARWXVQZMDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9A48A80", Offset = "0x9A47480", VA = "0x189A48A80")]
		public UnityMeshFormat WWCQXLOKZME()
		{
			return default(UnityMeshFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9A476D0", Offset = "0x9A460D0", VA = "0x189A476D0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.FindBestUnityMeshFormat_Fast_0000009D$PostfixBurstDelegate))]
		private unsafe static void QVLJRFHMUGL(int a, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9A48810", Offset = "0x9A47210", VA = "0x189A48810")]
		public static (int, int) WJMGJBYGOSO(Mesh a)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9A489A0", Offset = "0x9A473A0", VA = "0x189A489A0")]
		public static int WVWCFGXLSMD(Span<VertexAttributeDescriptor> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9A44A10", Offset = "0x9A43410", VA = "0x189A44A10")]
		public static long GUNSGLLSPFQ(Mesh a, int b, int c)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9A44A80", Offset = "0x9A43480", VA = "0x189A44A80")]
		public static long GUNSGLLSPFQ(Mesh a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public NativeMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9A44FE0", Offset = "0x9A439E0", VA = "0x189A44FE0")]
		[BurstCompile]
		internal unsafe static void HZAHXRNYQWW([NoAlias] VertexFormat_NormTanMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9A47150", Offset = "0x9A45B50", VA = "0x189A47150")]
		[BurstCompile]
		internal static int NSYOBYKGCDD(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9A47090", Offset = "0x9A45A90", VA = "0x189A47090")]
		[BurstCompile]
		internal static uint NSYOBYKGCDD([In] float4 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9A47010", Offset = "0x9A45A10", VA = "0x189A47010")]
		[BurstCompile]
		internal static uint NSYOBYKGCDD([In] float3 v)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9A434B0", Offset = "0x9A41EB0", VA = "0x189A434B0")]
		[BurstCompile]
		internal unsafe static void EBNKHSBNKJR([NoAlias] VertexFormat_NormTanSn8MatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9A44820", Offset = "0x9A43220", VA = "0x189A44820")]
		[BurstCompile]
		internal unsafe static void GQOKQSDUVGC([NoAlias] VertexFormat_NormTanSn8UvMatF16* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9A47390", Offset = "0x9A45D90", VA = "0x189A47390")]
		[BurstCompile]
		internal unsafe static void OWEGDWRMMMF([NoAlias] VertexFormat_NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9A427B0", Offset = "0x9A411B0", VA = "0x189A427B0")]
		[BurstCompile]
		internal unsafe static void BPUCYXCFSLC([NoAlias] VertexFormat_PosFixedPoint16NormTanOct8MatUi* dstVerts, int a, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices, [Out] float3 b, [Out] float3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9A42B60", Offset = "0x9A41560", VA = "0x189A42B60")]
		[BurstCompile]
		internal unsafe static void CASHVUNGCJK(int a, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9A42B30", Offset = "0x9A41530", VA = "0x189A42B30")]
		[BurstCompile]
		internal unsafe static void CASHVUNGCJK(int a, int b, [In][NoAlias] ushort* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9A43E60", Offset = "0x9A42860", VA = "0x189A43E60")]
		[BurstCompile]
		internal unsafe static void FBJCUPAOZFU(int a, int b, int c, [In][NoAlias] int* dest, [In][NoAlias] int* source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9A30290", Offset = "0x9A2EC90", VA = "0x189A30290")]
		[BurstCompile]
		internal unsafe static void QSGFSDVNVLU(int a, [NoAlias] bool* validFormats, [In][NoAlias] float3* positions, [In][NoAlias] float3* normals, [In][NoAlias] float4* tangents, [In][NoAlias] float2* uvs, [In][NoAlias] float4* materialIndices)
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
	public class ZLVCWNNXJOI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static CVGSXYYIMIE CVGSXYYIMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NativeList<PrimitiveShapeData> VHOSOXEAPWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NativeList<MeshPartInfo> TTKAGMHXJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public NativeList<CurveShapeRootData> TDXSZVJDYZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NativeArray<CurvePointData> CYABDFFIAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NativeList<MeshPartInfo> BXWXJILXUZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NativeList<CurvePointOffset> GLCZKNTVRIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private List<NativeArray<CurvePointData>> MCKKWZUVJYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private NativeList<OcclusionData> BCNVMZATSUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeArray<int> LNFKTIGPMPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private NativeArray<int> WAYVVHJQKLL;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private static NativeList<ShapeBatch.CollapseEntry> GVVLSVMJOCD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int JBWZWKMXDIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xD316B0", Offset = "0xD300B0", VA = "0x180D316B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x1640940", Offset = "0x163F340", VA = "0x181640940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int AJWLMYRLRRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xD31710", Offset = "0xD30110", VA = "0x180D31710")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x1640980", Offset = "0x163F380", VA = "0x181640980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9A51920", Offset = "0x9A50320", VA = "0x189A51920")]
		public ZLVCWNNXJOI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9A4FCE0", Offset = "0x9A4E6E0", VA = "0x189A4FCE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9A4FB00", Offset = "0x9A4E500", VA = "0x189A4FB00")]
		public void Dispose(JobHandle jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9A51570", Offset = "0x9A4FF70", VA = "0x189A51570")]
		public void MLMMMMHMVGU(PrimitiveShapeData a, OcclusionData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9A517F0", Offset = "0x9A501F0", VA = "0x189A517F0")]
		public void NUISVLYXYDI(CurveShapeRootData a, NativeArray<CurvePointData> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9A510B0", Offset = "0x9A4FAB0", VA = "0x189A510B0")]
		public JobHandle EZFVYUYUCGF(NativeMesh a, RBRDZIAMQDD b, float3 c, quaternion d, float e, bool f, int g = 0, int h = 0)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9A4FEB0", Offset = "0x9A4E8B0", VA = "0x189A4FEB0")]
		public JobHandle EZFVYUYUCGF(NativeMesh a, RBRDZIAMQDD b, NativeList<ShapeBatch.CollapseEntry> c, float3 d, quaternion e, float f, bool g, bool h, int i = 0, int j = 0)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9A511C0", Offset = "0x9A4FBC0", VA = "0x189A511C0")]
		public static JobHandle KSQLYMSUUVA(PrimitiveMeshGeneratorData a, NativeMesh b, NativeArray<int> c, PrimitiveShapeData d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F810", Offset = "0x9A4E210", VA = "0x189A4F810")]
		public static JobHandle DMHNJRGALNK(CurveMeshGeneratorData a, NativeMesh b, CurveShapeRootData c, NativeArray<CurvePointData> d, int e, int f, JobHandle g)
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
			public EBPVYYINUCK.MinimalMeshData meshData;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x69EF3E0", Offset = "0x69EDDE0", VA = "0x1869EF3E0")]
			public SingleMeshData(MeshRenderer renderer, EBPVYYINUCK.MinimalMeshData meshData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x9A4B0E0", Offset = "0x9A49AE0", VA = "0x189A4B0E0")]
			public static implicit operator SingleMeshData((MeshRenderer, EBPVYYINUCK.MinimalMeshData) tuple)
			{
				return default(SingleMeshData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private static readonly ProfilerMarker CBEZRVDQFQX;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly ProfilerMarker IWVLCGDGVEP;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static readonly ProfilerMarker GZXZQCYJTQA;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly ProfilerMarker NZTVUUOJEJI;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9A35990", Offset = "0x9A34390", VA = "0x189A35990")]
		internal void PIVQHQYPLCO(GameObject a, EBPVYYINUCK.CrowdAABB b, List<SingleMeshData> c, Material d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9A343C0", Offset = "0x9A32DC0", VA = "0x189A343C0")]
		internal void BVTINBLUQLO(GameObject a, EBPVYYINUCK.CrowdAABB b, List<SingleMeshData> c, List<LODGroup> d, Material e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9A371D0", Offset = "0x9A35BD0", VA = "0x189A371D0")]
		private MeshRenderer ZBTGPABZVNH(EBPVYYINUCK.CrowdAABB a, Material b, List<SingleMeshData> c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9A361D0", Offset = "0x9A34BD0", VA = "0x189A361D0")]
		private List<(List<SingleMeshData>, float)> QSIRXGTAWQZ(EBPVYYINUCK.CrowdAABB a, List<LODGroup> b, Material c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9A34BD0", Offset = "0x9A335D0", VA = "0x189A34BD0")]
		private List<List<(List<SingleMeshData>, float)>> JJSCGPRUBZC(EBPVYYINUCK.CrowdAABB a, List<LODGroup> b, Material c, [Out] int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public CrowdBatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9A37060", Offset = "0x9A35A60", VA = "0x189A37060")]
		[CompilerGenerated]
		internal static (float, int) UKAGJEBGREJ(List<List<(List<SingleMeshData> meshList, float lodTransition)>> gathered, int[] a)
		{
			return default((float, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class CrowdOptimizer
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly ProfilerMarker PHDZMEPMZOE;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly ProfilerMarker FNXKOERRWUF;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly ProfilerMarker VDHXHOMITIR;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly ProfilerMarker KIDXSFYSUDG;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static readonly ProfilerMarker IMLADSEZYUZ;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static readonly ProfilerMarker WFIAWFJVIOE;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static readonly ProfilerMarker YSSXJCBEBIE;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly Log KNJBZPDCQEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private EBPVYYINUCK LORTIRDGEBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private CrowdBatch JICSBSJKVQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Shader VYKICXQFJUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MaterialPropertyBlock PTHLCPGQHBW;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9A3A0D0", Offset = "0x9A38AD0", VA = "0x189A3A0D0")]
		public static void YWDNYRJAQTW(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9A38120", Offset = "0x9A36B20", VA = "0x189A38120")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9A38870", Offset = "0x9A37270", VA = "0x189A38870")]
		public void LZXAPARIETV(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9A37EF0", Offset = "0x9A368F0", VA = "0x189A37EF0")]
		private bool AMWMZYXJNUK(MeshRenderer a, [Out] MeshFilter b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9A38FC0", Offset = "0x9A379C0", VA = "0x189A38FC0")]
		private bool QPLYNPZUFFR(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9A39EC0", Offset = "0x9A388C0", VA = "0x189A39EC0")]
		private void YTEIXFYDNOG(GameObject a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9A391B0", Offset = "0x9A37BB0", VA = "0x189A391B0")]
		private List<CrowdBatch.SingleMeshData> VFHKYBMBDID(int a, [Out] List<LODGroup> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9A38A80", Offset = "0x9A37480", VA = "0x189A38A80")]
		private List<(int, Material)> QISJDWARIXY(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9A38070", Offset = "0x9A36A70", VA = "0x189A38070")]
		public void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9A39970", Offset = "0x9A38370", VA = "0x189A39970")]
		private bool WUUOZBCGATY(GameObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9A3A630", Offset = "0x9A39030", VA = "0x189A3A630")]
		public CrowdOptimizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[BurstCompile]
	public class EBPVYYINUCK : IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9A5AB10", Offset = "0x9A59510", VA = "0x189A5AB10")]
			public CrowdAABB(Bounds bounds)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x9A5ACC0", Offset = "0x9A596C0", VA = "0x189A5ACC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A5CFF0", Offset = "0x9A5B9F0", VA = "0x189A5CFF0")]
			private float YJISPFNCYXM(CrowdAABB a, CrowdAABB b)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9A5CDE0", Offset = "0x9A5B7E0", VA = "0x189A5CDE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly ProfilerMarker XXQLBHLOYIA;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly ProfilerMarker NNXJLGGYVXS;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static readonly ProfilerMarker KXPURMTXDGC;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static readonly ProfilerMarker QDCERFLHUUF;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly ProfilerMarker BVOPVJZWYDO;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private static readonly ProfilerMarker QSPRJIBTPQE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private static readonly ProfilerMarker OTMHUYIGFWS;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static readonly ProfilerMarker IXTROWBOPEY;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static readonly ProfilerMarker GSXKNBFZKPU;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker YDGQVVCFJTU;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker CZSTFQLWUYN;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker MXUGAVLUYQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NativeArray<Node> SGVILWNTOWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public NativeQueue<int> SQBXRNOBLMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int PJUANLQKZIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Dictionary<Material, int> CIEJPZYRHHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public List<MinimalMeshData> EHIGJGWISJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public List<LODGroup> GTJCZRYMHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Dictionary<int, MeshRenderer> FIHBEZGWMWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Queue<int> ISROIWLHXCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Shader EYGDQAMBUVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Shader NCDCZUECFFP;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9A3E390", Offset = "0x9A3CD90", VA = "0x189A3E390")]
		public EBPVYYINUCK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9A3B560", Offset = "0x9A39F60", VA = "0x189A3B560")]
		private void HHCHWKDVYZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9A3CCF0", Offset = "0x9A3B6F0", VA = "0x189A3CCF0")]
		public bool YFBMCBECDED(MeshRenderer a, MeshFilter b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9A3D160", Offset = "0x9A3BB60", VA = "0x189A3D160")]
		public bool YFBMCBECDED(LODGroup a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9A3ACA0", Offset = "0x9A396A0", VA = "0x189A3ACA0")]
		private bool Contains(MeshRenderer meshRenderer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9A3C030", Offset = "0x9A3AA30", VA = "0x189A3C030")]
		private int PTPTOEBEEBH(MeshRenderer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9A3CB10", Offset = "0x9A3B510", VA = "0x189A3CB10")]
		private int SAPNWADBWGJ(LODGroup a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9A3A810", Offset = "0x9A39210", VA = "0x189A3A810")]
		private int AXLQIQEBPSK(MeshFilter a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9A3A970", Offset = "0x9A39370", VA = "0x189A3A970")]
		private int BGHKSTAMNLC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9A3ADD0", Offset = "0x9A397D0", VA = "0x189A3ADD0")]
		private static CrowdAABB FJOHGJADBZN(CrowdAABB a, CrowdAABB b)
		{
			return default(CrowdAABB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9A3CBD0", Offset = "0x9A3B5D0", VA = "0x189A3CBD0")]
		private static float TXFSSTIUTSS(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9A3B6D0", Offset = "0x9A3A0D0", VA = "0x189A3B6D0")]
		private int IXPESPUWEUU(int a, CrowdAABB b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9A3B9E0", Offset = "0x9A3A3E0", VA = "0x189A3B9E0")]
		private void IYUAAKASDVL(CrowdAABB a, int b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9A3B0F0", Offset = "0x9A39AF0", VA = "0x189A3B0F0")]
		private void GPWEGHIGBJG(CrowdAABB a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9A3DEA0", Offset = "0x9A3C8A0", VA = "0x189A3DEA0")]
		private float YJISPFNCYXM(CrowdAABB a, CrowdAABB b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9A3BC10", Offset = "0x9A3A610", VA = "0x189A3BC10")]
		private void NYBIEQDPSMQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9A3C6E0", Offset = "0x9A3B0E0", VA = "0x189A3C6E0")]
		private void Rotate(int indexA, int indexB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9A3C150", Offset = "0x9A3AB50", VA = "0x189A3C150")]
		private void QYQFZDXVCCO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9A3AD20", Offset = "0x9A39720", VA = "0x189A3AD20", Slot = "4")]
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
	public class FDWSJPXPKUP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public NativeArray<RingVertex> RRHDAFNDJRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public NativeArray<int> LCUQWXDVOPN;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int JBWZWKMXDIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6A0", Offset = "0xD0B0A0", VA = "0x180D0C6A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int AJWLMYRLRRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6C0", Offset = "0xD0B0C0", VA = "0x180D0C6C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9A5C6C0", Offset = "0x9A5B0C0", VA = "0x189A5C6C0")]
		public FDWSJPXPKUP(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9A5C580", Offset = "0x9A5AF80", VA = "0x189A5C580", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9A5C5E0", Offset = "0x9A5AFE0", VA = "0x189A5C5E0")]
		public void HSHRCEPTJZO(FDWSJPXPKUP a, int b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class CDSKWMXJFMS
	{
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static FDWSJPXPKUP FUTSXGHWKKB;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static NativeList<MeshPartInfo> XBQEYVQGZTL;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static int[] ZUXLHTLEALC;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static bool SXCSZULSUPM;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private static Dictionary<int, FDWSJPXPKUP> DDGUTKATHTM;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static Dictionary<int, FDWSJPXPKUP> INCEVPDGJDF;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool ZULJGYDFTIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x9A531B0", Offset = "0x9A51BB0", VA = "0x189A531B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static NativeList<MeshPartInfo> PCTLLFVKQDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x9A53120", Offset = "0x9A51B20", VA = "0x189A53120")]
			get
			{
				return default(NativeList<MeshPartInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static FDWSJPXPKUP WTMREKLKBWN
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x9A53590", Offset = "0x9A51F90", VA = "0x189A53590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9A536C0", Offset = "0x9A520C0", VA = "0x189A536C0")]
		private static void ZAWRVNAMNSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9A530F0", Offset = "0x9A51AF0", VA = "0x189A530F0")]
		public static int QDITMABYZHF(bool a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9A52AB0", Offset = "0x9A514B0", VA = "0x189A52AB0")]
		private static int IKYJMNPQQLN(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9A52AA0", Offset = "0x9A514A0", VA = "0x189A52AA0")]
		private static int HXXNSKPGELI(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9A53630", Offset = "0x9A52030", VA = "0x189A53630")]
		public static int XRCEISYMWRR(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9A52BD0", Offset = "0x9A515D0", VA = "0x189A52BD0")]
		public static int MMHFVNNIVXO(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9A53620", Offset = "0x9A52020", VA = "0x189A53620")]
		public static int WWDEIQURQIN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9A52BC0", Offset = "0x9A515C0", VA = "0x189A52BC0")]
		private static int LMNRAFPWPGZ(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9A52A80", Offset = "0x9A51480", VA = "0x189A52A80")]
		private static int FOACDDPIVYO(int a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9A52770", Offset = "0x9A51170", VA = "0x189A52770")]
		public static int CNKTQLZPHRL(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9A52C60", Offset = "0x9A51660", VA = "0x189A52C60")]
		public static int NSUONOQDMHG(int a, int b, int c, bool d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9A53230", Offset = "0x9A51C30", VA = "0x189A53230")]
		public static int STSXYAKVKCH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9A52AD0", Offset = "0x9A514D0", VA = "0x189A52AD0")]
		public static FDWSJPXPKUP JPHLOAFQOMN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9A527E0", Offset = "0x9A511E0", VA = "0x189A527E0")]
		private static FDWSJPXPKUP ESNRPCFLHHD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9A53DC0", Offset = "0x9A527C0", VA = "0x189A53DC0")]
		public static FDWSJPXPKUP ZYKWPVPMOAC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9A53250", Offset = "0x9A51C50", VA = "0x189A53250")]
		private static FDWSJPXPKUP TAFCQZVOQIK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9A52CF0", Offset = "0x9A516F0", VA = "0x189A52CF0")]
		public static void PASTELJJGIU()
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
		[Cpp2IlInjected.Address(RVA = "0x9A5AEB0", Offset = "0x9A598B0", VA = "0x189A5AEB0")]
		public CurveMeshGeneratorData(NativeArray<CurvePointData> pointDatas, int size = 1, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9A5ADD0", Offset = "0x9A597D0", VA = "0x189A5ADD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A567E0", Offset = "0x9A551E0", VA = "0x189A567E0")]
		public CreateNativeMeshFromBatchedCurvesJob(ZLVCWNNXJOI batchedShapeData, NativeMesh destMesh, float3 rootPositionWS, quaternion rootRotationWS, float rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9A565E0", Offset = "0x9A54FE0", VA = "0x189A565E0")]
		public CreateNativeMeshFromBatchedCurvesJob(CurveMeshGeneratorData batchedShapeData, NativeMesh destMesh, float3 rootPositionWS, quaternion rootRotationWS, float3 rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9A564A0", Offset = "0x9A54EA0", VA = "0x189A564A0")]
		private float3 ZUZJAWTAGPE(float3 a, Matrix4x4 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9A56420", Offset = "0x9A54E20", VA = "0x189A56420")]
		private float3x3 QJRZBZSNTCN(float3x3 a, float3x3 b)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9A55A50", Offset = "0x9A54450", VA = "0x189A55A50")]
		private float KUQZGNBCICG(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9A54650", Offset = "0x9A53050", VA = "0x189A54650", Slot = "4")]
		public void Execute(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9A558E0", Offset = "0x9A542E0", VA = "0x189A558E0")]
		private void IRHGZQACXJU(int a, float3 b, float3 c, float3 d, float e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9A55FE0", Offset = "0x9A549E0", VA = "0x189A55FE0")]
		private void OHTRRUMOKNN(CurveShapeRootData a, float3 b, float3x3 c, float d, int e, int f, int g, float h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9A55A60", Offset = "0x9A54460", VA = "0x189A55A60")]
		private void OAOOHYHZUIZ(int a, int b, CurveShapeRootData c, float3 d, float3x3 e, bool f, float g, int h, int i, int j)
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
		[Cpp2IlInjected.Address(RVA = "0x9A5FA00", Offset = "0x9A5E400", VA = "0x189A5FA00")]
		public PrimitiveMeshGeneratorData(int size, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9A5F980", Offset = "0x9A5E380", VA = "0x189A5F980", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A59990", Offset = "0x9A58390", VA = "0x189A59990")]
		public CreateNativeMeshFromShapeBatchJob(ZLVCWNNXJOI batchedShapeData, NativeMesh destMesh, NativeArray<int> destVertCollapseTargetIn, float3 rootPositionWS, quaternion rootRotationWS, float rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9A59BA0", Offset = "0x9A585A0", VA = "0x189A59BA0")]
		public CreateNativeMeshFromShapeBatchJob(PrimitiveMeshGeneratorData data, NativeMesh destMesh, NativeArray<int> destVertCollapseTargetIn, float3 rootPositionWS, quaternion rootRotationWS, float3 rootSizeWS, int indexStart = 0, int vertexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9A58800", Offset = "0x9A57200", VA = "0x189A58800", Slot = "4")]
		public void Execute(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9A583C0", Offset = "0x9A56DC0", VA = "0x189A583C0")]
		private void BYIUAXNLSFE(float4x4 a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9A598D0", Offset = "0x9A582D0", VA = "0x189A598D0")]
		private ProjectionAxis ICOVHJJFQKL(float3 a)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9A59940", Offset = "0x9A58340", VA = "0x189A59940")]
		private float4 PNFPNUQOQKB(ProjectionAxis a, int b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9A59890", Offset = "0x9A58290", VA = "0x189A59890")]
		private float2 HSMPNNPLXFR(ProjectionAxis a, float3 b)
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
		[Cpp2IlInjected.Address(RVA = "0x9A58280", Offset = "0x9A56C80", VA = "0x189A58280")]
		private float3 ZUZJAWTAGPE(float3 a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9A581F0", Offset = "0x9A56BF0", VA = "0x189A581F0")]
		private float3x3 QJRZBZSNTCN(float3x3 a)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9A577A0", Offset = "0x9A561A0", VA = "0x189A577A0")]
		private float KUQZGNBCICG(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9A569C0", Offset = "0x9A553C0", VA = "0x189A569C0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9A57630", Offset = "0x9A56030", VA = "0x189A57630")]
		private void IRHGZQACXJU(int a, float3 b, float3 c, float3 d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9A57D00", Offset = "0x9A56700", VA = "0x189A57D00")]
		private void OHTRRUMOKNN(CurvePointData a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9A577B0", Offset = "0x9A561B0", VA = "0x189A577B0")]
		private void OAOOHYHZUIZ(int a, int b, float3 c, float3x3 d, bool e, float f, int g, float h)
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
		[Cpp2IlInjected.Address(RVA = "0x9A5A0D0", Offset = "0x9A58AD0", VA = "0x189A5A0D0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9A59DA0", Offset = "0x9A587A0", VA = "0x189A59DA0")]
		private void BYIUAXNLSFE(float4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9A598D0", Offset = "0x9A582D0", VA = "0x189A598D0")]
		private ProjectionAxis ICOVHJJFQKL(float3 a)
		{
			return default(ProjectionAxis);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9A59940", Offset = "0x9A58340", VA = "0x189A59940")]
		private float4 PNFPNUQOQKB(ProjectionAxis a, int b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9A59890", Offset = "0x9A58290", VA = "0x189A59890")]
		private float2 HSMPNNPLXFR(ProjectionAxis a, float3 b)
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
		public bool SFWGMFEBQCS
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9A5F4E0", Offset = "0x9A5DEE0", VA = "0x189A5F4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float3 SYRRFGENHNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9A5EED0", Offset = "0x9A5D8D0", VA = "0x189A5EED0")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9A5F890", Offset = "0x9A5E290", VA = "0x189A5F890")]
		public OcclusionData(float3 position, quaternion rotation, float3 size, OcclusionType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9A5F610", Offset = "0x9A5E010", VA = "0x189A5F610")]
		public float UWVYWOPYPZM(float3 a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9A5F3F0", Offset = "0x9A5DDF0", VA = "0x189A5F3F0")]
		public bool QXZAIZEYBIC(float3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9A5EFB0", Offset = "0x9A5D9B0", VA = "0x189A5EFB0")]
		public void JSCRFMWRTMI(float3 a, float3x3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9A5F4F0", Offset = "0x9A5DEF0", VA = "0x189A5F4F0")]
		private void TNKHQTDCGTZ(float3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x9A5F160", Offset = "0x9A5DB60", VA = "0x189A5F160")]
		public void KPSINVBNXMG()
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
		[Cpp2IlInjected.Address(RVA = "0x9A5BCB0", Offset = "0x9A5A6B0", VA = "0x189A5BCB0")]
		public DetectEnclosedTrianglesBatchedJob(NativeMesh mesh, float rootScale, int startIndex, int startVertex, NativeList<OcclusionData> data, NativeArray<int> shapeOcclusionDataIdx, NativeList<MeshPartInfo> shapeDest, RBRDZIAMQDD optimizationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9A5AFE0", Offset = "0x9A599E0", VA = "0x189A5AFE0", Slot = "4")]
		public void Execute(int shapeIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9A5BBF0", Offset = "0x9A5A5F0", VA = "0x189A5BBF0")]
		private bool SZZKXJFBDLR(OcclusionData a, OcclusionData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9A5B8B0", Offset = "0x9A5A2B0", VA = "0x189A5B8B0")]
		private bool RESCGUZQPFF(OcclusionData a, int b, int c, int d)
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
		[Cpp2IlInjected.Address(RVA = "0x9A5BD40", Offset = "0x9A5A740", VA = "0x189A5BD40", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9A5C190", Offset = "0x9A5AB90", VA = "0x189A5C190")]
		private bool LWABNQCXFGV(OcclusionData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9A5C240", Offset = "0x9A5AC40", VA = "0x189A5C240")]
		private bool RESCGUZQPFF(OcclusionData a, int b, int c, int d)
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
		[Cpp2IlInjected.Address(RVA = "0x154D400", Offset = "0x154BE00", VA = "0x18154D400")]
		public InitializeCollapseListJob(NativeArray<int> vertCollapseTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9A5E870", Offset = "0x9A5D270", VA = "0x189A5E870", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A5C830", Offset = "0x9A5B230", VA = "0x189A5C830")]
		public FinalizeNativeMeshCollapseListJob(NativeList<ShapeBatch.CollapseEntry> destCollapseList, NativeArray<int> srcVertCollapseTarget, int vertexStart = 0, int indexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A5C780", Offset = "0x9A5B180", VA = "0x189A5C780", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class RBRDZIAMQDD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public NativeArray<bool> WGNJVIRBLDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public NativeArray<int> WJKYNOVFARQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public NativeArray<bool> CGONJVUSMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public NativeArray<float> BOXENOZZELJ;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9A63C70", Offset = "0x9A62670", VA = "0x189A63C70")]
		public void ERBUWECJNLH(int a, int b, Allocator c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x9A63D90", Offset = "0x9A62790", VA = "0x189A63D90")]
		public static long HUJTUVHSGJC(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x9A63B80", Offset = "0x9A62580", VA = "0x189A63B80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9A63A90", Offset = "0x9A62490", VA = "0x189A63A90")]
		public void Dispose(JobHandle jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public RBRDZIAMQDD()
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
		[Cpp2IlInjected.Address(RVA = "0x9A5CD60", Offset = "0x9A5B760", VA = "0x189A5CD60")]
		public FinalizeNativeMeshOptimizationsJob(NativeMesh mesh, RBRDZIAMQDD optimizationData, int vertexStart = 0, int indexStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x9A5C850", Offset = "0x9A5B250", VA = "0x189A5C850", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x9A5CCF0", Offset = "0x9A5B6F0", VA = "0x189A5CCF0")]
		private void KRGCDUKZGRF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class SUEZPJCVQLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F29EC0", Offset = "0x3F288C0", VA = "0x183F29EC0")]
		public static bool FOEUYULIUDI<T>(NativeArray<T> a, int b, Allocator c, NativeArrayOptions d = NativeArrayOptions.ClearMemory, int e = 3) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A1E0", Offset = "0x3F28BE0", VA = "0x183F2A1E0")]
		public static bool FOEUYULIUDI<T>(NativeList<T> a, int b, Allocator c) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A360", Offset = "0x3F28D60", VA = "0x183F2A360")]
		public static bool FOEUYULIUDI<T>(NativeQueue<T> a, Allocator b) where T : struct
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
	public interface KQMNYWLXVWW
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GDKUMAEBULX(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int KSBJZWZPOFB(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RRBounds NCCYKOMXAWX();

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float LGWLXNAWASJ();

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WXQPGZHXWAJ(SystemLOD a, ZLVCWNNXJOI b, int c = -1);

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		int HHZHTDXQZXV(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class JRGYQXIRUHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9A5E8A0", Offset = "0x9A5D2A0", VA = "0x189A5E8A0")]
		public static void PASTELJJGIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class HOJQQLRRYOL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public NativeList<float3> AQPSISQQBLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public NativeArray<float3> FRTHDLVTDSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public NativeArray<int> XIBFRMOQLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public NativeArray<float4> UUHCEQQAHGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public NativeArray<float4> UUMJBXJXQSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public NativeArray<float4> UTWOKDCFOKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public NativeArray<int> TTDXHXDHEPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public NativeList<float3> QYEBPGCWWCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public NativeList<int> KUUYPZTODZL;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int JBWZWKMXDIF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x9A5D120", Offset = "0x9A5BB20", VA = "0x189A5D120")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int AJWLMYRLRRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x9A5E1A0", Offset = "0x9A5CBA0", VA = "0x189A5E1A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int RDXACZZWBLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x9A5D800", Offset = "0x9A5C200", VA = "0x189A5D800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9A5E1F0", Offset = "0x9A5CBF0", VA = "0x189A5E1F0")]
		public HOJQQLRRYOL(int a, int b, int c, Allocator d = Allocator.Persistent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9A5E510", Offset = "0x9A5CF10", VA = "0x189A5E510")]
		public HOJQQLRRYOL(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9A5D6F0", Offset = "0x9A5C0F0", VA = "0x189A5D6F0", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x9A5D850", Offset = "0x9A5C250", VA = "0x189A5D850")]
		public void HSHRCEPTJZO(HOJQQLRRYOL a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9A5DBE0", Offset = "0x9A5C5E0", VA = "0x189A5DBE0")]
		private void LASDOGDYZKZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9A5D170", Offset = "0x9A5BB70", VA = "0x189A5D170")]
		private void DCTUFORVWVN()
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
		[Cpp2IlInjected.Address(RVA = "0x213C500", Offset = "0x213AF00", VA = "0x18213C500")]
		public MeshPartInfo(int startVertex, int vertexCount, int startIndex, int indexCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class CVGSXYYIMIE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public NativeList<MeshPartInfo> DZHCUYMUJWW
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			[CompilerGenerated]
			get
			{
				return default(NativeList<MeshPartInfo>);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xED2460", Offset = "0xED0E60", VA = "0x180ED2460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public HOJQQLRRYOL SEPNJECHARX
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xD11E10", Offset = "0xD10810", VA = "0x180D11E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x9A54060", Offset = "0x9A52A60", VA = "0x189A54060")]
		public CVGSXYYIMIE(IEnumerable<HOJQQLRRYOL> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9A53FF0", Offset = "0x9A529F0", VA = "0x189A53FF0", Slot = "4")]
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
	public static class CCTILFFYVSX
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static NativeArray<float2> PVRUVPKUIZQ;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static NativeArray<float3> FAXGPMKNFLN;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static NativeArray<float4> CSKNOENIQLG;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static NativeArray<int> NGESANATXDB;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x9A52560", Offset = "0x9A50F60", VA = "0x189A52560")]
		public static void PASTELJJGIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9A52360", Offset = "0x9A50D60", VA = "0x189A52360")]
		public static NativeArray<float2> JMYRYPIQCIS(NativeArray<float2> a, int b, NativeArray<float2> c, int d)
		{
			return default(NativeArray<float2>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9A52670", Offset = "0x9A51070", VA = "0x189A52670")]
		public static NativeArray<float3> RJREVYVMUCD(NativeArray<float3> a, int b, NativeArray<float3> c, int d)
		{
			return default(NativeArray<float3>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9A52260", Offset = "0x9A50C60", VA = "0x189A52260")]
		public static NativeArray<float4> BUPXOQCUDYI(NativeArray<float4> a, int b, NativeArray<float4> c, int d)
		{
			return default(NativeArray<float4>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9A52460", Offset = "0x9A50E60", VA = "0x189A52460")]
		public static NativeArray<int> OOAOTVDWYEL(NativeArray<int> a, int b, NativeArray<int> c, int d)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x37F82A0", Offset = "0x37F6CA0", VA = "0x1837F82A0")]
		private static void JOQUKBOMKCN<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x37F85A0", Offset = "0x37F6FA0", VA = "0x1837F85A0")]
		private static void QSFKYWZDZAO<b>(NativeArray<b> a, int b, NativeArray<b> c, int d, NativeArray<b> e) where b : struct
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
		public static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9A66B70", Offset = "0x9A65570", VA = "0x189A66B70")]
		public static uint SYCOCYGOYEE(float a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x9A668B0", Offset = "0x9A652B0", VA = "0x189A668B0")]
		public static void NFIQJATPGLP(float4 a, float b, [Out] uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x9A667E0", Offset = "0x9A651E0", VA = "0x189A667E0")]
		public static void NFIQJATPGLP(float4 a, uint b, [Out] uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9A65F80", Offset = "0x9A64980", VA = "0x189A65F80")]
		public static void IKQGUKIKNYC(float3 a, float3 b, float4 c, float2 d, float4 e, [Out] NativeMesh.VertexFormat_NormTanOct8MatUi f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9A66220", Offset = "0x9A64C20", VA = "0x189A66220")]
		public static void IKQGUKIKNYC(float3 a, float3 b, float4 c, float2 d, float4 e, [Out] NativeMesh.VertexFormat_PosFixedPoint16NormTanOct8MatUi f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9A65F20", Offset = "0x9A64920", VA = "0x189A65F20")]
		public static byte IHXWLRMOFGU(float a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x9A66B10", Offset = "0x9A65510", VA = "0x189A66B10")]
		public static ushort NZZZHGSWUVZ(float a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x9A65EF0", Offset = "0x9A648F0", VA = "0x189A65EF0")]
		public static uint BOJQEJNBIWV(float a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x9A66B80", Offset = "0x9A65580", VA = "0x189A66B80")]
		public static float2 WCAIECPHXPY(float2 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x9A664E0", Offset = "0x9A64EE0", VA = "0x189A664E0")]
		public static float2 KKENLWDSULW(float3 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x9A669C0", Offset = "0x9A653C0", VA = "0x189A669C0")]
		public static void NXTAUHJVZTD(float3 a, [Out] float3 b, [Out] uint3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x9A66630", Offset = "0x9A65030", VA = "0x189A66630")]
		public static CompressedPositionFixedPoint16 KZCOCBVJVVD(float3 a)
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
		public static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private static readonly ProfilerMarker OZOVKQIUZDW;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public static float WBMDYTNWDLD;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		private static void IXDEBOBLJPB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x9A65B50", Offset = "0x9A64550", VA = "0x189A65B50")]
		public static float YOBGKGCUVSW(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x9A65A60", Offset = "0x9A64460", VA = "0x189A65A60")]
		public static long XSXQPVLGBYY(float a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x9A655E0", Offset = "0x9A63FE0", VA = "0x189A655E0")]
		public static void OGKHXYRZJGD(float a)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Quartermaster
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public interface ICPOGZXASGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OGKHXYRZJGD(float a);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		(long, long, int) HEBYLBPAHBG(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public static class TSDFOESZBLX
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
		private class NWDIICINVYO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public WorkItemTypeEnum XWYJJROIJCU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public BatchedMeshRenderer WRGKRGYXMTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public BatchedMesh UIMNKXHZQNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public ShapeBatch DKDXQDCNIZN;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9A5E9F0", Offset = "0x9A5D3F0", VA = "0x189A5E9F0")]
			public void DYFXDVGARWD([Out] bool a, [Out] bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public NWDIICINVYO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private static int HAAXYCKUDGU;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private static ObjectPool<NWDIICINVYO> ARDQKULKXMU;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x9A65170", Offset = "0x9A63B70", VA = "0x189A65170")]
		static TSDFOESZBLX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x9A64D60", Offset = "0x9A63760", VA = "0x189A64D60")]
		private static void VVGGHAUSIWP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x9A64F40", Offset = "0x9A63940", VA = "0x189A64F40")]
		private static void XRBBBHOGGJH([In] QuartermasterWorkItem workItem, [Out] bool a, [Out] bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x9A64BD0", Offset = "0x9A635D0", VA = "0x189A64BD0")]
		public static void SSEEVIPFGMN(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x9A64A40", Offset = "0x9A63440", VA = "0x189A64A40")]
		public static void GWEBGKNVYQQ(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x9A64FF0", Offset = "0x9A639F0", VA = "0x189A64FF0")]
		public static void ZJPYSPZHXCF(BatchedMesh a, BatchedMeshRenderer b, long c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x9A648B0", Offset = "0x9A632B0", VA = "0x189A648B0")]
		public static void GMEYRTNHSMH(ShapeBatch a, BatchedMeshRenderer b, long c, long d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9A645C0", Offset = "0x9A62FC0", VA = "0x189A645C0")]
		private static void ASAMROPGOQG(WorkItemTypeEnum a, ShapeBatch b, BatchedMesh c, BatchedMeshRenderer d, long e, long f, float g, bool h, bool i, float j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public static class QuartermasterManager
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly ProfilerMarker PBMONVXENOA;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private static readonly ProfilerMarker DYQFTIVMGSX;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private static readonly ProfilerMarker MENEFGEZVKP;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static readonly ProfilerMarker SKBSCIOMBAF;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public static int KMIJNUAQEKO;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public static int EHGRWAMGARQ;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public static int GSQZYOKEWUS;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public static long FFDNZVKUOMQ;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public static long DAOCXIGWJKF;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public static long NOTONVLRWUM;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public static long MNLFTTBEIQR;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public static int YKLEZPWIELZ;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public static float IRDKLNXEASD;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public static bool EXRIZZZOXLQ;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public static int RPTWIMPQFYH;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public static int YTBKTSJIXMT;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public static int KWIRQVGMNIB;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public static long SOWUBFCRERC;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public static int FQVODDUHRSX;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public static bool HHBDJTEEPPH;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static uint JUVPNKJGCYP;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private static SVAIEWKNQFB EMCLKTAMHIP;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static List<uint> NIIUIGLKUYF;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static List<(QuartermasterWorkItem.Execute, QuartermasterWorkItem.Release)> ZLLTUDVIZJV;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private static ICPOGZXASGI TWIPKTKEYSO;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private static ICPOGZXASGI HEFAPPBWRLY;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool IUIMLDYYVIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x9A606C0", Offset = "0x9A5F0C0", VA = "0x189A606C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		private static void RJQORAXNTIC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		private static void IXDEBOBLJPB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		private static void RJQORAXNTIC(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x9A5FBC0", Offset = "0x9A5E5C0", VA = "0x189A5FBC0")]
		public static void EHQFAEHSUCQ(ICPOGZXASGI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9A63110", Offset = "0x9A61B10", VA = "0x189A63110")]
		public static void SIFCPJOUYCI(ICPOGZXASGI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9A63440", Offset = "0x9A61E40", VA = "0x189A63440")]
		public static (long, long, long, int, int) VYBECZFKIWT(long a)
		{
			return default((long, long, long, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x9A63230", Offset = "0x9A61C30", VA = "0x189A63230")]
		public static void VKFFQPDMTUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9A60C10", Offset = "0x9A5F610", VA = "0x189A60C10")]
		public static void OGKHXYRZJGD(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9A60A70", Offset = "0x9A5F470", VA = "0x189A60A70")]
		public static void NRVIRGFTEYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9A632B0", Offset = "0x9A61CB0", VA = "0x189A632B0")]
		public static long VWXRSKDVMFK(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9A5FAF0", Offset = "0x9A5E4F0", VA = "0x189A5FAF0")]
		public static bool DLWHPEGEAWG(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9A604E0", Offset = "0x9A5EEE0", VA = "0x189A604E0")]
		public static bool HKZPBRMNAQL(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x9A60710", Offset = "0x9A5F110", VA = "0x189A60710")]
		public static float MXFMSCIPGWI(long a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x9A60080", Offset = "0x9A5EA80", VA = "0x189A60080")]
		public static (long, long, int) HEBYLBPAHBG(float a)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x9A5FD80", Offset = "0x9A5E780", VA = "0x189A5FD80")]
		public static void HBXPICYECQY(QuartermasterWorkItem a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9A5FC30", Offset = "0x9A5E630", VA = "0x189A5FC30")]
		public static int GZOBTEUUQRX(QuartermasterWorkItem.Execute a, QuartermasterWorkItem.Release b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9A63180", Offset = "0x9A61B80", VA = "0x189A63180")]
		public static bool UNZDWSCUMWG(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9A630A0", Offset = "0x9A61AA0", VA = "0x189A630A0")]
		public static void RGNUKPGEVPI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9A605B0", Offset = "0x9A5EFB0", VA = "0x189A605B0")]
		public static bool LDKEQJLKUUD(float a)
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
		[Cpp2IlInjected.Address(RVA = "0x9A63A70", Offset = "0x9A62470", VA = "0x189A63A70", Slot = "4")]
		private int UBOAHCFYRZZ(QuartermasterWorkItem a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x9A63A60", Offset = "0x9A62460", VA = "0x189A63A60", Slot = "5")]
		private bool BMKZVCHRDEC(QuartermasterWorkItem a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class SVAIEWKNQFB
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
			public QuartermasterWorkItem BSPHJBMXYAJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0x9A71EC0", Offset = "0x9A708C0", VA = "0x189A71EC0")]
				get
				{
					return default(QuartermasterWorkItem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x9A72190", Offset = "0x9A70B90", VA = "0x189A72190")]
			public QuartermasterWorkItemEnumerator(List<QuartermasterWorkItem> instantWorkItems, List<QuartermasterWorkItem> persistentWorkItems)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x9A72040", Offset = "0x9A70A40", VA = "0x189A72040")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private List<QuartermasterWorkItem> MISFWCIYZUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private List<QuartermasterWorkItem> MJCMBXGZSRW;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int KQOHZIVUHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x9A641C0", Offset = "0x9A62BC0", VA = "0x189A641C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x9A63DB0", Offset = "0x9A627B0", VA = "0x189A63DB0")]
		public void Add([In] QuartermasterWorkItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x9A64160", Offset = "0x9A62B60", VA = "0x189A64160")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9A63EA0", Offset = "0x9A628A0", VA = "0x189A63EA0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x9A64210", Offset = "0x9A62C10", VA = "0x189A64210")]
		public void WEYVKYSDHOV(IEnumerable<uint> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9A63F80", Offset = "0x9A62980", VA = "0x189A63F80")]
		private static void QVZDTOLUNRI(List<QuartermasterWorkItem> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x9A64050", Offset = "0x9A62A50", VA = "0x189A64050")]
		private void Remove(uint id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x9A63F40", Offset = "0x9A62940", VA = "0x189A63F40")]
		public QuartermasterWorkItemEnumerator GetEnumerator()
		{
			return default(QuartermasterWorkItemEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x9A64510", Offset = "0x9A62F10", VA = "0x189A64510")]
		public SVAIEWKNQFB()
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
		public static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private static readonly string KEDXCNYCNQW;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static readonly string NCQAIYFJALL;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private static readonly ProfilerMarker UXBDVHIOFWD;

		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private static readonly ProfilerMarker VVXGCDIAEEM;

		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private static readonly ProfilerMarker OZOVKQIUZDW;

		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private static readonly ProfilerMarker ZVCIPXJIDQO;

		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static readonly ProfilerMarker ENTBRIKPXVI;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static readonly ProfilerMarker WNFNVZVSUXH;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly ProfilerMarker WPQCBKZSEWH;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static readonly ProfilerMarker OFPVRDYHMTP;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static readonly ProfilerMarker SPZEGNEKARV;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static readonly ProfilerMarker HMGQUURRXBL;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly ProfilerMarker HLQWDAJZUTK;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static readonly ProfilerMarker HLWDAHDXEET;

		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private static readonly ProfilerMarker HMWLMOZJZJM;

		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private static readonly ProfilerMarker HNBSJVTHIUV;

		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private static readonly ProfilerMarker HMLXSBLPGMU;

		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private static readonly ProfilerMarker HMREPIFMPYD;

		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private static readonly ProfilerMarker HNRNBQAZLCW;

		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private static readonly ProfilerMarker JGXDDIBUJXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		internal readonly List<ShapeBatch> JLPKCYRBART;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private readonly DisposeReminder BXKGKRRXGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private int TFFJLHWINRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private int JCAFTMVEAJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private bool FXPPQAJSPUF;

		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public const bool MQZHVZHWTUZ = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public bool TNFWCDLHVJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		internal ScalabilityStateMesh OZDEYQIVBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		internal int NPOJHRXQYOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		internal int ABLZZWHVUUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		internal int VMBCHFXZLYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		internal int VJTWZWCURJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		internal long HQYSVJXBYMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		internal long XYSOUQPTUBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		internal long QRLUVRTZYDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private NativeMesh FDISQCBVUPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private NativeMesh JKGXUHEIIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private NativeMesh.UnityMeshFormat XUOWBVDIKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private bool QMVPKXPENWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private int EDHKTZAAZUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private BatchedMeshTessellate DUSGEVALWRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private float3 HQRLPEPTRPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private float HNIRXIQLYXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private float FATHOLFRSOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private float ALJSEKNTVZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private float KVMZQDXCWPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private float JFXGASMXTBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private float YHVOQBYWQJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private float3 WXBFREWOIGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private float HJWNKUIFHLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private float WZCVLDVKLXK;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal Mesh SEPNJECHARX
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xD11E20", Offset = "0xD10820", VA = "0x180D11E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xD0B7F0", Offset = "0xD0A1F0", VA = "0x180D0B7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public MeshFilter NQUFZYCCAHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCD0", Offset = "0xD0B6D0", VA = "0x180D0CCD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCE0", Offset = "0xD0B6E0", VA = "0x180D0CCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public MeshRenderer CJIDLHMGRJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xD14330", Offset = "0xD12D30", VA = "0x180D14330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xD142C0", Offset = "0xD12CC0", VA = "0x180D142C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public List<Material> DJCZHRYALPF
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xD14260", Offset = "0xD12C60", VA = "0x180D14260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xD14280", Offset = "0xD12C80", VA = "0x180D14280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int FNHFJXWEPIV
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xF1CE30", Offset = "0xF1B830", VA = "0x180F1CE30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int JBWZWKMXDIF
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x9A6D9A0", Offset = "0x9A6C3A0", VA = "0x189A6D9A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int AJWLMYRLRRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x9A71280", Offset = "0x9A6FC80", VA = "0x189A71280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x9A71520", Offset = "0x9A6FF20", VA = "0x189A71520")]
		public void ZRFCQOQEWMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x9A6E740", Offset = "0x9A6D140", VA = "0x189A6E740")]
		public bool EJINRVQWOTO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x9A70C40", Offset = "0x9A6F640", VA = "0x189A70C40")]
		private void UWQLIJODJRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x9A713F0", Offset = "0x9A6FDF0", VA = "0x189A713F0")]
		private void XIMTDSXZHHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x9A71C30", Offset = "0x9A70630", VA = "0x189A71C30")]
		public BatchedMesh(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9A6E610", Offset = "0x9A6D010", VA = "0x189A6E610")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x9A6F2A0", Offset = "0x9A6DCA0", VA = "0x189A6F2A0")]
		private void LMZEKBCUJTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DD20", Offset = "0x9A6C720", VA = "0x189A6DD20")]
		private void CreateNewUnityMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DBA0", Offset = "0x9A6C5A0", VA = "0x189A6DBA0")]
		private void CQVBOZHGLAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x9A702E0", Offset = "0x9A6ECE0", VA = "0x189A702E0")]
		public Mesh RVBDYGTVWTA(MeshFilter a, Transform b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x9A6E430", Offset = "0x9A6CE30", VA = "0x189A6E430")]
		public void DGPASXKGYRB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x9A70180", Offset = "0x9A6EB80", VA = "0x189A70180")]
		private void QVFWTFURAEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9A700E0", Offset = "0x9A6EAE0", VA = "0x189A700E0")]
		public void PDRATOZCFNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9A6EA10", Offset = "0x9A6D410", VA = "0x189A6EA10")]
		public void GPLNAWIELLI(KQMNYWLXVWW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9A715C0", Offset = "0x9A6FFC0", VA = "0x189A715C0")]
		public bool ZZSFECSQJEN(KQMNYWLXVWW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DC40", Offset = "0x9A6C640", VA = "0x189A6DC40")]
		public bool Contains(KQMNYWLXVWW meshGenerator)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9A6F660", Offset = "0x9A6E060", VA = "0x189A6F660", Slot = "4")]
		public virtual void OAFEVDUVPUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DF10", Offset = "0x9A6C910", VA = "0x189A6DF10")]
		public void DDSSNUORSFU(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x9A6E7E0", Offset = "0x9A6D1E0", VA = "0x189A6E7E0")]
		public bool ETFUPIQFIQN(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9A6F340", Offset = "0x9A6DD40", VA = "0x189A6F340")]
		public bool MQSLWSOEVFC(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9A70240", Offset = "0x9A6EC40", VA = "0x189A70240")]
		private void RQLAFIZOUHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x9A6F860", Offset = "0x9A6E260", VA = "0x189A6F860")]
		public bool OGKHXYRZJGD([In] float4x4 worldFromLocal, BatchedMeshRenderer a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x9A712A0", Offset = "0x9A6FCA0", VA = "0x189A712A0")]
		public bool XCMTIPTYCXP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x9A6CEA0", Offset = "0x9A6B8A0", VA = "0x189A6CEA0")]
		public bool ABDBDADLNIC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x9A6F770", Offset = "0x9A6E170", VA = "0x189A6F770")]
		public void OAROUCQXYGK(NativeMesh a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x9A6F560", Offset = "0x9A6DF60", VA = "0x189A6F560")]
		public (long, long, long) NZLLVQFWKRW()
		{
			return default((long, long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xD12880", Offset = "0xD11280", VA = "0x180D12880")]
		public long UCLARBOBVBW()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9A6F010", Offset = "0x9A6DA10", VA = "0x189A6F010")]
		private void KNKCEMTOLXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9A6EC00", Offset = "0x9A6D600", VA = "0x189A6EC00")]
		public (long, long, int) HEBYLBPAHBG(float a, [In] float4x4 worldFromLocal)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xD83E30", Offset = "0xD82830", VA = "0x180D83E30")]
		internal void FVJLHDBYHSR(ScalabilityStateMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x9A704D0", Offset = "0x9A6EED0", VA = "0x189A704D0")]
		internal (float, float, float, float) TDQVAGBQQEJ(float a, [In] float4x4 worldFromLocal)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x9A6EE10", Offset = "0x9A6D810", VA = "0x189A6EE10")]
		private void KBBKPHBLZER(NativeMesh a, NativeMesh.UnityMeshFormat b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x9A71500", Offset = "0x9A6FF00", VA = "0x189A71500")]
		private void YEYUVZJEHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x9A70350", Offset = "0x9A6ED50", VA = "0x189A70350")]
		internal bool SBIVNMHNKJC(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x9A70CE0", Offset = "0x9A6F6E0", VA = "0x189A70CE0")]
		private void VKEXJCDHUJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x9A71350", Offset = "0x9A6FD50", VA = "0x189A71350")]
		private void XFPKXOTSWGS(NativeMesh.UnityMeshFormat a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9A6D9C0", Offset = "0x9A6C3C0", VA = "0x189A6D9C0")]
		private void CIKCMHQWJVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9A71090", Offset = "0x9A6FA90", VA = "0x189A71090")]
		public long VWXRSKDVMFK(long a, int b)
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
			[Cpp2IlInjected.Address(RVA = "0x9A72250", Offset = "0x9A70C50", VA = "0x189A72250")]
			public void VQZGAVQPNPU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x9A721D0", Offset = "0x9A70BD0", VA = "0x189A721D0")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private static readonly string KEDXCNYCNQW;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private static readonly string NCQAIYFJALL;

		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private static readonly ProfilerMarker UXBDVHIOFWD;

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private static readonly ProfilerMarker WDVBQZNLICN;

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private static readonly ProfilerMarker OZOVKQIUZDW;

		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private static readonly ProfilerMarker FKFCBOSBOFN;

		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private static readonly ProfilerMarker ZVCIPXJIDQO;

		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private static readonly ProfilerMarker ENTBRIKPXVI;

		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private static readonly ProfilerMarker WNFNVZVSUXH;

		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private static readonly ProfilerMarker WPQCBKZSEWH;

		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private static readonly ProfilerMarker OFPVRDYHMTP;

		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private static readonly ProfilerMarker JKVFLQQHMXL;

		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private static readonly ProfilerMarker SPZEGNEKARV;

		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private static readonly ProfilerMarker QBUEFPQLPNH;

		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private static readonly ProfilerMarker TWMIXIPUKVV;

		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private static readonly ProfilerMarker QQYHGPPZMAE;

		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private static readonly ProfilerMarker ZDWQFNUBEAB;

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static readonly ProfilerMarker HMGQUURRXBL;

		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private static readonly ProfilerMarker HLQWDAJZUTK;

		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private static readonly ProfilerMarker HLWDAHDXEET;

		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private static readonly ProfilerMarker HMWLMOZJZJM;

		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private static readonly ProfilerMarker HNBSJVTHIUV;

		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private static readonly ProfilerMarker HMLXSBLPGMU;

		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private static readonly ProfilerMarker HMREPIFMPYD;

		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private static readonly ProfilerMarker HNRNBQAZLCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		internal readonly List<KQMNYWLXVWW> CWXVLSWICLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		internal BatchedMesh YIZDQOMTIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private readonly DisposeReminder BXKGKRRXGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		internal int HXMYIMYTZKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		internal int GSNNRXJLNBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		internal bool RFIASVHHEBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		internal bool LOKFLLNUCXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		internal ScalabilityStateShapes DRKTVVLGMVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		internal bool LASKHIJAGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		internal float3 BDOHJBSRMFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		internal float3 ZFUSTYGBIWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		internal float VGPURQGERST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		internal int KFYUINDPVEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		internal int MRYIENMLPCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		internal int SQODZGULOXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		internal float WXKHNUAPJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		internal int RKIYGWDUVSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		internal float SDKESAKMVJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		internal float QCZORRSPTLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		internal int SRTLJCYHIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		internal long VVMGFXVAAPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public int VIPPVSZEPOO;

		[Cpp2IlInjected.Token(Token = "0x4000270")]
		internal const int LDGGQIYKIGZ = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		internal float[] LYETGCMFWRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		internal int[] QZYWGYXBPTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		internal long[] GEPDLCPXSSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public List<ScaledMesh> BIYCWHFNVRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		internal NativeMesh ZKXOVUQZHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		internal long HYRZMUXULXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		internal int AGHDROQZKRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		internal float NDOAWUGDHPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		internal NativeMesh.UnityMeshFormat TEUPOKLQJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		internal CompressedNativeMeshStruct VDUTLTGYAYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		internal int WGAUYGBTOZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		internal float JEILIWINEYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		internal long URIGQPTFXLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		internal bool MNOHRLJLPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		internal ScaleMeshToDesiredTriCountsJob OPYRCYFCNCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		internal JobHandle QHFXMVHVSMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		internal NativeList<CollapseEntry> OCJFENDFTPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		internal NativeArray<long> LRFJDYQVAQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		internal bool GUSUDLPWCIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		internal JobHandle YJYCLWWOAFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		internal NativeMesh HKEFAUCSLXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		internal RBRDZIAMQDD LXROYGMPQFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		internal NativeList<CollapseEntry> DOAWQEUUMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		internal Transform HBWYDNDXMXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		internal SystemLOD PTSPSZCSMQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		internal long XIIFBBHPHWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		internal long FAVAPPYVLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		internal long WRIJHDRVUYD;

		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private static bool RSRJXVEIYYL;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public List<KQMNYWLXVWW> BXIZHKGPPJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal int JBWZWKMXDIF
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x9A72280", Offset = "0x9A70C80", VA = "0x189A72280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x9A7B1D0", Offset = "0x9A79BD0", VA = "0x189A7B1D0")]
		internal void ZRFCQOQEWMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A800", Offset = "0x9A79200", VA = "0x189A7A800")]
		internal void UWQLIJODJRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9A7B820", Offset = "0x9A7A220", VA = "0x189A7B820")]
		internal ShapeBatch(string name, BatchedMesh parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9A73350", Offset = "0x9A71D50", VA = "0x189A73350")]
		internal void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x9A78D70", Offset = "0x9A77770", VA = "0x189A78D70")]
		internal void QVFWTFURAEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9A73F90", Offset = "0x9A72990", VA = "0x189A73F90")]
		internal void FPEZKNUKBSH(KQMNYWLXVWW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9A78CF0", Offset = "0x9A776F0", VA = "0x189A78CF0")]
		internal bool QEXHSQIUOCS(KQMNYWLXVWW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9A76AC0", Offset = "0x9A754C0", VA = "0x189A76AC0")]
		internal bool OBJWAYKMYNY(KQMNYWLXVWW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9A76A10", Offset = "0x9A75410", VA = "0x189A76A10", Slot = "4")]
		internal virtual void OAFEVDUVPUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9A73260", Offset = "0x9A71C60", VA = "0x189A73260")]
		public float DKCYSJIFWDQ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x9A7AFD0", Offset = "0x9A799D0", VA = "0x189A7AFD0")]
		public bool XGBLFDEIOAJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9A79B20", Offset = "0x9A78520", VA = "0x189A79B20")]
		public (CompressedNativeMeshStruct, NativeMesh.UnityMeshFormat) SZSFFQWGCKT()
		{
			return default((CompressedNativeMeshStruct, NativeMesh.UnityMeshFormat));
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9A7AF20", Offset = "0x9A79920", VA = "0x189A7AF20")]
		internal long VYVPMLILFFQ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x9A73150", Offset = "0x9A71B50", VA = "0x189A73150")]
		internal long DCORPMCUARJ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x9A73480", Offset = "0x9A71E80", VA = "0x189A73480")]
		internal bool EECRAVJMMQO(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9A75B70", Offset = "0x9A74570", VA = "0x189A75B70")]
		internal bool MQSLWSOEVFC(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9A790C0", Offset = "0x9A77AC0", VA = "0x189A790C0")]
		internal void RQLAFIZOUHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9A77580", Offset = "0x9A75F80", VA = "0x189A77580")]
		internal bool OGKHXYRZJGD([In] float4x4 worldFromLocal, BatchedMeshRenderer a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9A75470", Offset = "0x9A73E70", VA = "0x189A75470")]
		internal bool JNIKITKWAXD(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A720", Offset = "0x9A79120", VA = "0x189A7A720")]
		internal void TRJTYBDMCSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9A76A90", Offset = "0x9A75490", VA = "0x189A76A90")]
		internal void OAROUCQXYGK(NativeMesh a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9A75700", Offset = "0x9A74100", VA = "0x189A75700")]
		internal void KJZUQCHXJYL(CompressedNativeMeshStruct a, int b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9A75980", Offset = "0x9A74380", VA = "0x189A75980")]
		internal void KNKCEMTOLXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9A741D0", Offset = "0x9A72BD0", VA = "0x189A741D0")]
		internal (long, long, int) HEBYLBPAHBG(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xD16820", Offset = "0xD15220", VA = "0x180D16820")]
		internal void FVJLHDBYHSR(ScalabilityStateShapes a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A350", Offset = "0x9A78D50", VA = "0x189A7A350")]
		public static (float, float, float, float) TDQVAGBQQEJ(float3 a, float3 b, float c, [In] float4x4 worldFromLocal, float d)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A150", Offset = "0x9A78B50", VA = "0x189A7A150")]
		internal (float, float, float, float) TDQVAGBQQEJ(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A7D0", Offset = "0x9A791D0", VA = "0x189A7A7D0")]
		private float UJXLJYVXNLC(float a, [In] float4x4 worldFromLocal, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9A787B0", Offset = "0x9A771B0", VA = "0x189A787B0")]
		private (int, int, float) PCCQHSYLTAZ(float a)
		{
			return default((int, int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A730", Offset = "0x9A79130", VA = "0x189A7A730")]
		internal static float TVDIIPIMQVF(KQMNYWLXVWW a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9A74650", Offset = "0x9A73050", VA = "0x189A74650")]
		internal void JKYSTVSHGJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9A722A0", Offset = "0x9A70CA0", VA = "0x189A722A0")]
		internal void CIKCMHQWJVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9A78570", Offset = "0x9A76F70", VA = "0x189A78570")]
		internal void OTHNEKHOFPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A940", Offset = "0x9A79340", VA = "0x189A7A940")]
		internal long VWXRSKDVMFK(long a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9A725D0", Offset = "0x9A70FD0", VA = "0x189A725D0")]
		private void CSTJYGRDAJF(NativeMesh a, NativeList<CollapseEntry> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9A72330", Offset = "0x9A70D30", VA = "0x189A72330")]
		internal void CKSODSVYKZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9A794C0", Offset = "0x9A77EC0", VA = "0x189A794C0")]
		public static void SDMNWCSICNF(NativeList<CollapseEntry> a, NativeMesh b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x9A76980", Offset = "0x9A75380", VA = "0x189A76980")]
		private float NMLTKTTTENP(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9A76B20", Offset = "0x9A75520", VA = "0x189A76B20")]
		internal void OCOCZHGHYZR(NativeMesh a, CompressedNativeMesh b, int c, int d, float e)
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
		internal static class WCHBZNHHFSI
		{
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x9A7C0A0", Offset = "0x9A7AAA0", VA = "0x189A7C0A0")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x9A7BF20", Offset = "0x9A7A920", VA = "0x189A7BF20")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x9A6B8E0", Offset = "0x9A6A2E0", VA = "0x189A6B8E0")]
			public static void Invoke(BatchedMeshTessellateJob bmtj, [In] TriToTessellate tri)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void TessellateQuad_00000271$PostfixBurstDelegate(BatchedMeshTessellateJob bmtj, [In] QuadToTessellate quad);

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		internal static class BVHQOFDMWYZ
		{
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x9A68B50", Offset = "0x9A67550", VA = "0x189A68B50")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x9A687E0", Offset = "0x9A671E0", VA = "0x189A687E0")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x9A68960", Offset = "0x9A67360", VA = "0x189A68960")]
			public static void Invoke(BatchedMeshTessellateJob bmtj, [In] QuadToTessellate quad)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void BuildNativeMesh_00000274$PostfixBurstDelegate(UnsafeList<int>* resultIndices, UnsafeList<float3>* resultVerts, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* newVerts, UnsafeList<int>* newIndices, UnsafeList<float3>* inMeshVerts, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int numIndices, int numVerts);

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		internal static class WVOTCPLBVND
		{
			[Cpp2IlInjected.Token(Token = "0x40002CF")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x9A7C700", Offset = "0x9A7B100", VA = "0x189A7C700")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x9A7C230", Offset = "0x9A7AC30", VA = "0x189A7C230")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x9A7C3B0", Offset = "0x9A7ADB0", VA = "0x189A7C3B0")]
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
		public EDXMTFOMWXQ.ScalabilityTessellationModeEnum shapesTessellateMode;

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
		[Cpp2IlInjected.Address(RVA = "0x9A6BAD0", Offset = "0x9A6A4D0", VA = "0x189A6BAD0")]
		private static float YRSCNPZZMEE([In] BatchedMeshTessellateJob bmtj, [In] float3 vertPos, float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9A696E0", Offset = "0x9A680E0", VA = "0x189A696E0")]
		private static int DTEJHCHLXQC(BatchedMeshTessellateJob a, [Out] TessVert b, [In] TessVert vert0, [In] TessVert vert1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B8E0", Offset = "0x9A6A2E0", VA = "0x189A6B8E0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.TessellateTri_00000270$PostfixBurstDelegate))]
		private static void XXVBCKHGPSR(BatchedMeshTessellateJob a, [In] TriToTessellate tri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9A68960", Offset = "0x9A67360", VA = "0x189A68960")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.TessellateQuad_00000271$PostfixBurstDelegate))]
		private static void DBPCEMDAGQH(BatchedMeshTessellateJob a, [In] QuadToTessellate quad)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9A69860", Offset = "0x9A68260", VA = "0x189A69860", Slot = "4")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9A6A020", Offset = "0x9A68A20", VA = "0x189A6A020")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal void IPWDVBVFKZD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9A6BB60", Offset = "0x9A6A560", VA = "0x189A6BB60")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.BuildNativeMesh_00000274$PostfixBurstDelegate))]
		internal unsafe static void ZKEJWJCSNWC(UnsafeList<int>* a, UnsafeList<float3>* b, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* c, UnsafeList<int>* d, UnsafeList<float3>* e, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int f, int g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9A6AF30", Offset = "0x9A69930", VA = "0x189A6AF30")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal static void WPUGKRTFAOU(BatchedMeshTessellateJob a, [In] TriToTessellate tri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x9A68CE0", Offset = "0x9A676E0", VA = "0x189A68CE0")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal static void BSAIOWHYMHA(BatchedMeshTessellateJob a, [In] QuadToTessellate quad)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9A69870", Offset = "0x9A68270", VA = "0x189A69870")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		internal unsafe static void GRPNLOJOFAN(UnsafeList<int>* a, UnsafeList<float3>* b, [NoAlias] float3* resultNormals, [NoAlias] float4* resultTangents, [NoAlias] float2* resultUVs, [NoAlias] float4* resultMaterialIndices, UnsafeList<TessVert>* c, UnsafeList<int>* d, UnsafeList<float3>* e, [NoAlias] float3* inMeshNormals, [NoAlias] float4* inMeshTangents, [NoAlias] float2* inMeshUVs, [NoAlias] float4* inMeshMaterialIndices, int f, int g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class BatchedMeshTessellate
	{
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private static readonly ProfilerMarker FIMPIJSFIBA;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public const int NZYPUXERRPJ = 2;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private const int WQYPJEXTSXD = 1;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private static int QHCCXEVFVWL;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private static Stack<BatchedMeshTessellate> WSAMSVYJEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private NativeMesh RTYVIBMKFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private NativeList<TessVert> QZSOBHIJFPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private NativeList<int> KHPIIGXMSAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private NativeList<BatchedMeshTessellateJob.TriToTessellate> OTSWXTEZJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private NativeList<BatchedMeshTessellateJob.TriToTessellate> CYXPCXWZHWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private NativeList<BatchedMeshTessellateJob.QuadToTessellate> JSKQTLRWWDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private NativeList<BatchedMeshTessellateJob.QuadToTessellate> JXLQCSKGZSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private BatchedMeshTessellateJob KZKYQTPCNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private JobHandle FYDIZCMWHPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private BatchedMeshTessellateJob.GenerateTessellatedMeshResults LYLNGPACQXV;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private const int YLWEUFAVKXZ = 65530;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x9A6CD10", Offset = "0x9A6B710", VA = "0x189A6CD10")]
		private BatchedMeshTessellate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C8A0", Offset = "0x9A6B2A0", VA = "0x189A6C8A0")]
		public void VOXCGBOPOLL(NativeMesh a, float3 b, float c, float d, float e, List<ShapeBatch.CollapseEntry> f, Allocator g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9A6BD10", Offset = "0x9A6A710", VA = "0x189A6BD10")]
		public (bool, NativeMesh, float) ECVXHEJVDWQ(List<ShapeBatch.CollapseEntry> a, Allocator b, bool c)
		{
			return default((bool, NativeMesh, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C4C0", Offset = "0x9A6AEC0", VA = "0x189A6C4C0")]
		public static bool MWWKHYMXVNF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C850", Offset = "0x9A6B250", VA = "0x189A6C850")]
		public static int PJOXRNZNFRS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9A6BC10", Offset = "0x9A6A610", VA = "0x189A6BC10")]
		public static int DELQFZWAUMK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C200", Offset = "0x9A6AC00", VA = "0x189A6C200")]
		public static BatchedMeshTessellate HQXMIKDRALV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9A6BC80", Offset = "0x9A6A680", VA = "0x189A6BC80")]
		internal static void EAOBGYNVBJK(BatchedMeshTessellate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C550", Offset = "0x9A6AF50", VA = "0x189A6C550")]
		public static void OBMYYGRDSSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C6B0", Offset = "0x9A6B0B0", VA = "0x189A6C6B0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		public static void PASTELJJGIU()
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
		[Cpp2IlInjected.Address(RVA = "0x9A7BED0", Offset = "0x9A7A8D0", VA = "0x189A7BED0")]
		public static void Create([Out] TessVert result, int srcIndex, [In] float3 posIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9A7BBE0", Offset = "0x9A7A5E0", VA = "0x189A7BBE0")]
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
			public EDXMTFOMWXQ.ScalabilityCollapseMetricEnum shapesCollapseMetric;

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
			[Cpp2IlInjected.Address(RVA = "0x9A87C10", Offset = "0x9A86610", VA = "0x189A87C10")]
			public void ERBUWECJNLH(int a, int b, Allocator c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x9A87DF0", Offset = "0x9A867F0", VA = "0x189A87DF0")]
			public static NativeMeshJob XGUHLIWWQKB(NativeMesh a)
			{
				return default(NativeMeshJob);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x4165300", Offset = "0x4163D00", VA = "0x184165300")]
			private static void XGGBNUDQFQJ<T>(NativeArray<T> a, NativeArray<T> b) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x9A87B50", Offset = "0x9A86550", VA = "0x189A87B50")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void Setup_FastCopyCollapse_0000028F$PostfixBurstDelegate(int numCollapses, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int vertexCount);

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		internal static class GLFKHNEPJSM
		{
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x9A879E0", Offset = "0x9A863E0", VA = "0x189A879E0")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x9A87660", Offset = "0x9A86060", VA = "0x189A87660")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x9A877C0", Offset = "0x9A861C0", VA = "0x189A877C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A8BEF0", Offset = "0x9A8A8F0", VA = "0x189A8BEF0")]
		public ScaleMeshToDesiredTriCountsJob([In] List<ShapeBatch.ScaledMesh> meshListIn, NativeList<ShapeBatch.CollapseEntry> collapseListOut, [In] NativeMesh meshSrcIn, [In] NativeList<ShapeBatch.CollapseEntry> collapseListIn, [In] NativeArray<long> scaleMeshJobAbortRequest, float3 bboxMin, float3 bboxMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x9A8BC60", Offset = "0x9A8A660", VA = "0x189A8BC60")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.Core.Creation.Shapes.Setup_FastCopyCollapse_0000028F$PostfixBurstDelegate))]
		private unsafe static void WFVFJHWRLTU(int a, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9A8AA10", Offset = "0x9A89410", VA = "0x189A8AA10")]
		public static long LSEDIVIZHSW(int a, int b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x9A8A9C0", Offset = "0x9A893C0", VA = "0x189A8A9C0", Slot = "4")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9A8AA30", Offset = "0x9A89430", VA = "0x189A8AA30")]
		public void OBBBOLDMTEB(List<ShapeBatch.ScaledMesh> a, [In] ShapeBatch shapeBatchIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x9A88F60", Offset = "0x9A87960", VA = "0x189A88F60")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private bool AbortRequested()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x9A8BA30", Offset = "0x9A8A430", VA = "0x189A8BA30")]
		private CompressedNativeMeshStruct UYSSKDQCCUC(int a, Allocator b)
		{
			return default(CompressedNativeMeshStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A88F80", Offset = "0x9A87980", VA = "0x189A88F80")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private void BONVNYKWUUR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9A8B470", Offset = "0x9A89E70", VA = "0x189A8B470")]
		[IgnoreWarning(1371)]
		[BurstCompile]
		private float OBTHTMCNMBO(int a, int b, bool c, bool d, float e, float f, float g, float h, float i, float j, float k)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x9A8A6A0", Offset = "0x9A890A0", VA = "0x189A8A6A0")]
		[IgnoreWarning(1371)]
		private ScaledMeshJob EVLNZNAPXCK([In] ScaledMeshJob scaledMeshJobSrc, int a, [In] NativeArray<int> indices, [In] NativeArray<bool> vertexUsed, NativeArray<int> b)
		{
			return default(ScaledMeshJob);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x9A8BC70", Offset = "0x9A8A670", VA = "0x189A8BC70")]
		public static int XMWQSXDILJQ(NativeArray<int> a, NativeArray<int> b, int c, int d, int e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x9A7C940", Offset = "0x9A7B340", VA = "0x189A7C940")]
		[BurstCompile]
		internal unsafe static void PIZPLKERKVL(int a, [In][NoAlias] ShapeBatch.CollapseEntry* source, [In][NoAlias] ShapeBatch.CollapseEntry* dest, int b)
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
			public KQMNYWLXVWW shape;

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x9A861F0", Offset = "0x9A84BF0", VA = "0x189A861F0")]
			public BoundsShape(RRBounds inBounds, KQMNYWLXVWW inEntry)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		private class XOFUFQLBHKW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public RRBounds ZLBHKWAGYMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			public int DPFYQKCZRRT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public float VGPURQGERST;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public List<BoundsShape> HVCGPDXHTQK;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x9A8CA00", Offset = "0x9A8B400", VA = "0x189A8CA00")]
			public XOFUFQLBHKW(RRBounds a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private static readonly ProfilerMarker GRBWASQYLYQ;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private static readonly ProfilerMarker UNGSWMUQWMF;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private static readonly ProfilerMarker IVAUYLPVHJD;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static readonly ProfilerMarker KSGBUBIOQDG;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private static readonly ProfilerMarker VPAUNANJZPI;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static readonly ProfilerMarker WNFNVZVSUXH;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private static readonly ProfilerMarker GMQZDSNSKVQ;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		internal const int BVAOLJQOWGF = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		internal static Dictionary<Material, List<Material>> GPXKOBFRKMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private Dictionary<Material, List<BatchedMesh>> RGAXGPOPQWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		internal List<BatchedMesh> JEOGLKHSRSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private List<MeshRenderer> UWUNMUGJINB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private Transform NJEFYJMPUZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private bool QNUDRJSJFCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private bool XTSYWJMMOTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private int ZKCLZKFFVTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private BatchedMesh CFMFTDMIGZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Material KMXUUFLNIFS;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private static bool? VXBAHPEKMVS;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private const int DULDCHTZHIZ = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private static List<BoundsShape> PRNDPOBJYIK;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<MeshRenderer> KCFZZPLGSNB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xD14330", Offset = "0xD12D30", VA = "0x180D14330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int NTDJPUTQRXC
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x9A82B10", Offset = "0x9A81510", VA = "0x189A82B10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private static bool SVLALSHLTZW
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x9A7E680", Offset = "0x9A7D080", VA = "0x189A7E680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		private static void RJQORAXNTIC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		private static void RJQORAXNTIC(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		private static void YPKKAIBBZVD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9A7CB90", Offset = "0x9A7B590", VA = "0x189A7CB90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9A7D610", Offset = "0x9A7C010", VA = "0x189A7D610")]
		internal bool GFGXYZCXRFW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9A7E790", Offset = "0x9A7D190", VA = "0x189A7E790")]
		private Transform OXPQZCBZAMS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9A7E810", Offset = "0x9A7D210", VA = "0x189A7E810")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9A7D200", Offset = "0x9A7BC00", VA = "0x189A7D200", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9A7C980", Offset = "0x9A7B380", VA = "0x189A7C980")]
		public BatchedMesh AddToBatchedMesh(KQMNYWLXVWW newMesh, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x9A816F0", Offset = "0x9A800F0", VA = "0x189A816F0")]
		public void RemoveFromBatchedMesh(KQMNYWLXVWW mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x9A7CFD0", Offset = "0x9A7B9D0", VA = "0x189A7CFD0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9A81E20", Offset = "0x9A80820", VA = "0x189A81E20")]
		private void TAETNYXWRVM(Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9A7DFB0", Offset = "0x9A7C9B0", VA = "0x189A7DFB0")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x9A7DFA0", Offset = "0x9A7C9A0", VA = "0x189A7DFA0")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9A81830", Offset = "0x9A80230", VA = "0x189A81830")]
		private void SXHSJACHWFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x9A7E180", Offset = "0x9A7CB80", VA = "0x189A7E180")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x9A7DDA0", Offset = "0x9A7C7A0", VA = "0x189A7DDA0")]
		private BatchedMesh IVOIQPGQWVJ(KQMNYWLXVWW a, Material b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x9A7CBC0", Offset = "0x9A7B5C0", VA = "0x189A7CBC0")]
		private BatchedMesh BAAVCMSCSLN(Material a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x9A81FA0", Offset = "0x9A809A0", VA = "0x189A81FA0")]
		private BatchedMesh ZKSCLVGXPRA(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x9A7D670", Offset = "0x9A7C070", VA = "0x189A7D670")]
		internal void GIZFOFBYHLN([Out] float4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x9A7D700", Offset = "0x9A7C100", VA = "0x189A7D700")]
		public static List<Material> GenerateVertexFormatVariants(Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x9A81EA0", Offset = "0x9A808A0", VA = "0x189A81EA0")]
		public static void UpdateMaterialVariants(Material parentMaterial, Action<Material> updateFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xF562E0", Offset = "0xF54CE0", VA = "0x180F562E0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x9A7E020", Offset = "0x9A7CA20", VA = "0x189A7E020")]
		public void MarkDirty(KQMNYWLXVWW mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x9A7D100", Offset = "0x9A7BB00", VA = "0x189A7D100")]
		[Conditional("CHECK_STATE")]
		private void DIUEQUGNUAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x9A7E2E0", Offset = "0x9A7CCE0", VA = "0x189A7E2E0")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float scalabilityErrorControl)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x9A7CEA0", Offset = "0x9A7B8A0", VA = "0x189A7CEA0")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9A804B0", Offset = "0x9A7EEB0", VA = "0x189A804B0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9A7D880", Offset = "0x9A7C280", VA = "0x189A7D880")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x9A7E8F0", Offset = "0x9A7D2F0", VA = "0x189A7E8F0")]
		public void RebatchOptimally(int batchSizeNaughty, int batchSizeNice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x9A7E820", Offset = "0x9A7D220", VA = "0x189A7E820")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x9A82A00", Offset = "0x9A81400", VA = "0x189A82A00")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D96F00", Offset = "0x1D95900", VA = "0x181D96F00")]
			public void AZBCXZQNDYG()
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
		private sealed class EUGYXHYCCRO : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			private bool AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			private long JSJNKRYNPTI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public long SHOZEPHWATT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private bool RZBFUKTRPPR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public bool UIFEHBELJRE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			private int DQYDJZYBIGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			private int PSSPBCGWPVN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			private int KPJWPSQJAOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			private int UPJQXZAZOFQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private List<BatchedMeshRenderer>.Enumerator OMUWLETHLFC;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool TSWMLMPSJFI
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0x13682A0", Offset = "0x1366CA0", VA = "0x1813682A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x8D6A740", Offset = "0x8D69140", VA = "0x188D6A740", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x15F05D0", Offset = "0x15EEFD0", VA = "0x1815F05D0")]
			[DebuggerHidden]
			public EUGYXHYCCRO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x9A862C0", Offset = "0x9A84CC0", VA = "0x189A862C0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x9A863E0", Offset = "0x9A84DE0", VA = "0x189A863E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x9A875D0", Offset = "0x9A85FD0", VA = "0x189A875D0")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9A87580", Offset = "0x9A85F80", VA = "0x189A87580")]
			private void SMGDSKUDEQA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x9A87620", Offset = "0x9A86020", VA = "0x189A87620", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x9A86220", Offset = "0x9A84C20", VA = "0x189A86220", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> STEMXKJNLJX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x9A86220", Offset = "0x9A84C20", VA = "0x189A86220", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private static readonly ProfilerMarker WNFNVZVSUXH;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly ProfilerMarker DVQCOALZYIR;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly ProfilerMarker LSBTMHFVLEX;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly ProfilerMarker LDQTPRKKBPD;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static float3 FHEIAKIFCZW;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static int NVVKEWNJIGF;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static int BTXPEZREZNQ;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static int WDERZVFNIGR;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static int FJEQLCVOJPQ;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static int YGEHBGOSIUS;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static float OBPWQGHSXVF;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static float TGEJBHEVCER;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static float RIWIACUPGCR;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static float WDYAYZQRTDK;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static float UIZCVNEMQMF;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static float PIXZZQCYKXW;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static float ZBRDOQMEEGY;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static float LBPQQQTPZRZ;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private static List<BatchedMeshRenderer> PJRHGUSBSZW;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private static Stack<NativeMesh> PYPJBVPCQWB;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private static Stack<RBRDZIAMQDD> KWZUIOTQJBM;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static SWNDSGXUJHW NPEBGIPADNB;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private static FindAndMarkAsFrozenCache KSPHMTXXJUH;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static int HJCJGHFIGJG;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		private static void RJQORAXNTIC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		private static void IXDEBOBLJPB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		private static void RJQORAXNTIC(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x9A85090", Offset = "0x9A83A90", VA = "0x189A85090")]
		public static void VQZGAVQPNPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x9A85BA0", Offset = "0x9A845A0", VA = "0x189A85BA0")]
		public static void ZIBTXKLSKTQ(BatchedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x9A84B90", Offset = "0x9A83590", VA = "0x189A84B90")]
		public static void QOVVSXYMSGP(BatchedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9A82B60", Offset = "0x9A81560", VA = "0x189A82B60")]
		public static void AKVXQBDBNIL(KQMNYWLXVWW a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9A83C20", Offset = "0x9A82620", VA = "0x189A83C20")]
		public static void MSGHRJEYWHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x9A843A0", Offset = "0x9A82DA0", VA = "0x189A843A0")]
		public static void OGKHXYRZJGD(float a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x9A835D0", Offset = "0x9A81FD0", VA = "0x189A835D0")]
		private static void IEKYGTZDCCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x9A85110", Offset = "0x9A83B10", VA = "0x189A85110")]
		public static long VWXRSKDVMFK(int a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9A833C0", Offset = "0x9A81DC0", VA = "0x189A833C0")]
		public static (long, long, int) HEBYLBPAHBG(float a)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x9A83BA0", Offset = "0x9A825A0", VA = "0x189A83BA0")]
		[IteratorStateMachine(typeof(EUGYXHYCCRO))]
		public static IEnumerable<bool> LIZEXGJKGWL(long a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9A83F90", Offset = "0x9A82990", VA = "0x189A83F90")]
		public static void NXJXPDISGEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9A84E20", Offset = "0x9A83820", VA = "0x189A84E20")]
		public static void TJOXKGYERGB(long a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x9A84CB0", Offset = "0x9A836B0", VA = "0x189A84CB0")]
		public static int TCZGPMRUVXR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9A85CE0", Offset = "0x9A846E0", VA = "0x189A85CE0")]
		internal static NativeMesh ZPKKXPIFMTX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x9A83320", Offset = "0x9A81D20", VA = "0x189A83320")]
		internal static void EAOBGYNVBJK(NativeMesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9A83A60", Offset = "0x9A82460", VA = "0x189A83A60")]
		internal static RBRDZIAMQDD KIAXVOLYQBQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9A83290", Offset = "0x9A81C90", VA = "0x189A83290")]
		internal static void EAOBGYNVBJK(RBRDZIAMQDD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9A841E0", Offset = "0x9A82BE0", VA = "0x189A841E0")]
		public static void OBMYYGRDSSL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class LWYARHEERZH<a> : BatchedMesh
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private readonly Dictionary<a, KQMNYWLXVWW> UQQWRBJURHJ;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A18900", Offset = "0x6A17300", VA = "0x186A18900")]
		public LWYARHEERZH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A18380", Offset = "0x6A16D80", VA = "0x186A18380")]
		public void GPLNAWIELLI(a a, KQMNYWLXVWW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A18760", Offset = "0x6A17160", VA = "0x186A18760")]
		public bool RPPJZCBLRAF(a a, KQMNYWLXVWW b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x6A182E0", Offset = "0x6A16CE0", VA = "0x186A182E0")]
		public void BFSUINPENKA(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x6A184F0", Offset = "0x6A16EF0", VA = "0x186A184F0", Slot = "4")]
		public override void OAFEVDUVPUT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public static class QKPUKMAAAGW
	{
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly ProfilerCategory FBQQNUXQILJ;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		internal static readonly ProfilerMarker MXFMSCIPGWI;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		internal static readonly RuntimeMarker OGKHXYRZJGD;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static readonly RuntimeCounterValue<float> KEAISAEKNFY;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static readonly RuntimeCounterValue<float> JMEJZXQPDDX;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly RuntimeCounterValue<float> NAMBTBFVAYI;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private static readonly RuntimeCounterValue<double> VZMMGNWFXPA;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private static readonly RuntimeCounterValue<double> YJJEYMBFVES;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private static readonly RuntimeCounterValue<double> KEBXYLIPKVJ;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private static readonly RuntimeCounterValue<double> NMMWUGLBTWP;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private static readonly RuntimeCounterValue<int> OBPKSUJRVZX;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private static readonly RuntimeCounterValue<int> FGRNCQXRSCP;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private static readonly RuntimeCounterValue<int> IOCPRREOMRX;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private static readonly RuntimeCounterValue<int> ISXILIOIIQO;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private static readonly RuntimeCounterValue<int> OPNMDTLSVWZ;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private static readonly RuntimeCounterValue<int> GXNZZNBTXVP;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private static readonly RuntimeCounterValue<int> GWNNHCKDBQK;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private static readonly RuntimeCounterValue<int> QYLRCLFOJCJ;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private static readonly RuntimeCounterValue<long> EIKEJLIUMYB;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static readonly RuntimeCounterValue<long> SIVTQZBKPQU;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private static readonly RuntimeCounterValue<long> SQHHANZTEGF;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private static readonly RuntimeCounterValue<long> LYBSJIUSVGL;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private static readonly RuntimeCounterValue<long> EJZVKHXPFZH;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private static readonly RuntimeCounterValue<long> AZVPRPJMMEI;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x9A88210", Offset = "0x9A86C10", VA = "0x189A88210")]
		public static void MDZSQDGGDZG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3911010459
{
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x9A8CAA0", Offset = "0x9A8B4A0", VA = "0x189A8CAA0")]
	public static void BNIWUCRKOYO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x9A8CC10", Offset = "0x9A8B610", VA = "0x189A8CC10")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x9A8C8A0", Offset = "0x9A8B2A0", VA = "0x189A8C8A0")]
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
