using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using GLTF;
using GLTF.Math;
using GLTF.Schema;
using GLTF.Utilities;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("1.0.0.0")]
namespace UnityGLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class KHR_animation_pointer : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object EAMWIIJISIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string OBLJWSQMGFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string OIFBGMTQUHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public HNJRRZZSFHX NGQDDMGKMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer BCIQBBJJSOO;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x87B8C30", Offset = "0x87B7630", VA = "0x1887B8C30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87B8B80", Offset = "0x87B7580", VA = "0x1887B8B80", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class WCLEYXYSRKQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 QDOAOHHTVEP;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 WQTMXOFNJCS;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion JVFCMQNNFPY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool NVRWBVESPTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x87C7B40", Offset = "0x87C6540", VA = "0x1887C7B40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87C5F60", Offset = "0x87C4960", VA = "0x1887C5F60")]
		public static void QAWCZQRNIVA(this RHNNOHYQJTP a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87C4590", Offset = "0x87C2F90", VA = "0x1887C4590")]
		public static void BUYRZNSESMI(this RHNNOHYQJTP a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87C59C0", Offset = "0x87C43C0", VA = "0x1887C59C0")]
		public static void PVKUEHOPJTN(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87C5090", Offset = "0x87C3A90", VA = "0x1887C5090")]
		public static GLTF.Math.Vector4 JVVBXJDCBEV(this DSEFIPJTYMI a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87C5680", Offset = "0x87C4080", VA = "0x1887C5680")]
		public static UnityEngine.Quaternion ODVQIMVTKWM(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87C5810", Offset = "0x87C4210", VA = "0x1887C5810")]
		public static UnityEngine.Quaternion ODVQIMVTKWM(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x87C54C0", Offset = "0x87C3EC0", VA = "0x1887C54C0")]
		public static GLTF.Math.Quaternion LWFTBUWALEQ(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x87C6EB0", Offset = "0x87C58B0", VA = "0x1887C6EB0")]
		public static Matrix4x4 UVUZTSAPIUT(this DSEFIPJTYMI a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x87C6A70", Offset = "0x87C5470", VA = "0x1887C6A70")]
		public static Matrix4x4 UVUZTSAPIUT(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x87C7790", Offset = "0x87C6190", VA = "0x1887C7790")]
		public static DSEFIPJTYMI WYVRWNYRMJV(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x87C4A90", Offset = "0x87C3490", VA = "0x1887C4A90")]
		public static UnityEngine.Vector3 DXJMIICSUWK(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87C4BB0", Offset = "0x87C35B0", VA = "0x1887C4BB0")]
		public static UnityEngine.Vector3 DXJMIICSUWK(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x87C4E70", Offset = "0x87C3870", VA = "0x1887C4E70")]
		public static GLTF.Math.Vector3 EIWXTOSAFRM(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x87C6530", Offset = "0x87C4F30", VA = "0x1887C6530")]
		public static GLTF.Math.Vector3 QZZLRALFJQT(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1394720", Offset = "0x1393120", VA = "0x181394720")]
		public static GLTF.Math.Vector4 GXIRREFUWBO(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x87C70D0", Offset = "0x87C5AD0", VA = "0x1887C70D0")]
		public static Matrix4x4 VFVHHSALGRQ(this DSEFIPJTYMI a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x87C7390", Offset = "0x87C5D90", VA = "0x1887C7390")]
		public static Matrix4x4 VFVHHSALGRQ(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x87C65F0", Offset = "0x87C4FF0", VA = "0x1887C65F0")]
		public static DSEFIPJTYMI SBGPRKRTTRA(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x87C4FA0", Offset = "0x87C39A0", VA = "0x1887C4FA0")]
		public static UnityEngine.Vector2 EZOUGLTYARU(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x87C4FA0", Offset = "0x87C39A0", VA = "0x1887C4FA0")]
		public static UnityEngine.Vector2 EZOUGLTYARU(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x87C4FC0", Offset = "0x87C39C0", VA = "0x1887C4FC0")]
		public static void EZOUGLTYARU(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x87C4440", Offset = "0x87C2E40", VA = "0x1887C4440")]
		public static UnityEngine.Vector3 BTFLCMOTBJF(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1DAE360", Offset = "0x1DACD60", VA = "0x181DAE360")]
		public static UnityEngine.Vector3 BTFLCMOTBJF(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x87C44A0", Offset = "0x87C2EA0", VA = "0x1887C44A0")]
		public static void BTFLCMOTBJF(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1394720", Offset = "0x1393120", VA = "0x181394720")]
		public static UnityEngine.Vector4 KAGVEOTBYCY(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1394720", Offset = "0x1393120", VA = "0x181394720")]
		public static UnityEngine.Vector4 KAGVEOTBYCY(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87C53C0", Offset = "0x87C3DC0", VA = "0x1887C53C0")]
		public static UnityEngine.Vector4[] KAGVEOTBYCY(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x87C52B0", Offset = "0x87C3CB0", VA = "0x1887C52B0")]
		public static void KAGVEOTBYCY(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x87C4DD0", Offset = "0x87C37D0", VA = "0x1887C4DD0")]
		public static UnityEngine.Color EIFHATIXNZA(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x87C4C90", Offset = "0x87C3690", VA = "0x1887C4C90")]
		public static void EIFHATIXNZA(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x87C4DD0", Offset = "0x87C37D0", VA = "0x1887C4DD0")]
		public static UnityEngine.Color EIFHATIXNZA(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1394720", Offset = "0x1393120", VA = "0x181394720")]
		public static UnityEngine.Color TXGIXWWCMER(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x87C6960", Offset = "0x87C5360", VA = "0x1887C6960")]
		public static void TXGIXWWCMER(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1394720", Offset = "0x1393120", VA = "0x181394720")]
		public static UnityEngine.Color TXGIXWWCMER(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x87C6500", Offset = "0x87C4F00", VA = "0x1887C6500")]
		public static GLTF.Math.Color QDHBIQKFMZF(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x87C5940", Offset = "0x87C4340", VA = "0x1887C5940")]
		public static GLTF.Math.Color PQERCZVUDFM(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x87C6570", Offset = "0x87C4F70", VA = "0x1887C6570")]
		public static GLTF.Math.Color RTORBCAQMZC(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87C5E40", Offset = "0x87C4840", VA = "0x1887C5E40")]
		public static UnityEngine.Color[] QAEGBSFBGZH(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x87C5600", Offset = "0x87C4000", VA = "0x1887C5600")]
		public static int[] MGLOBQHXJCM(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x87C5D90", Offset = "0x87C4790", VA = "0x1887C5D90")]
		public static UnityEngine.Vector2[] PXBFCKPUSYL(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x87C42E0", Offset = "0x87C2CE0", VA = "0x1887C42E0")]
		public static void AEDPOSHNMCM(WSEPZXFZGWU a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x87C7600", Offset = "0x87C6000", VA = "0x1887C7600")]
		public static UnityEngine.Vector3[] VYWOLUFPDCA(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x87C67C0", Offset = "0x87C51C0", VA = "0x1887C67C0")]
		public static UnityEngine.Vector4[] THLVZHKDOOJ(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x87C7AD0", Offset = "0x87C64D0", VA = "0x1887C7AD0")]
		public static void ZLWPTWNDYUY(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x87C7760", Offset = "0x87C6160", VA = "0x1887C7760")]
		public static UnityEngine.Quaternion WQBBNEEDEJE(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class WSEPZXFZGWU
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HYHNESAJCVR HYHNESAJCVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray ZGDFAKQJVML
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x87C7C90", Offset = "0x87C6690", VA = "0x1887C7C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> HOOXGCCJGLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xEF2E20", Offset = "0xEF1820", VA = "0x180EF2E20")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xFBBC10", Offset = "0xFBA610", VA = "0x180FBBC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint VFZFKOJRRKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A0C0", VA = "0x180D1B6C0")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD1B020", Offset = "0xD19A20", VA = "0x180D1B020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x87C7CA0", Offset = "0x87C66A0", VA = "0x1887C7CA0")]
		public WSEPZXFZGWU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x87B67C0", Offset = "0x87B51C0", VA = "0x1887B67C0")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x87B6820", Offset = "0x87B5220", VA = "0x1887B6820")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class KRWTHPNFIWB
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class LSWILDBCNNY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> BLMHJFPWJYU;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public LSWILDBCNNY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x87BEF80", Offset = "0x87BD980", VA = "0x1887BEF80")]
			internal int? GVRSTRROTUZ(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x87BF000", Offset = "0x87BDA00", VA = "0x1887BF000")]
			internal int? OFJGHFIQVYM(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x87BF090", Offset = "0x87BDA90", VA = "0x1887BF090")]
			internal bool UVUZHMTERPC(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x87BE8C0", Offset = "0x87BD2C0", VA = "0x1887BE8C0")]
		private static void XITALHHZCQW(NumericArray a, WSEPZXFZGWU b, WSEPZXFZGWU c, WSEPZXFZGWU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x87BC3E0", Offset = "0x87BADE0", VA = "0x1887BC3E0")]
		public static void CDYLAUDKGZN(Dictionary<string, WSEPZXFZGWU> a, Dictionary<string, (WSEPZXFZGWU sparseIndices, WSEPZXFZGWU sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87BD8B0", Offset = "0x87BC2B0", VA = "0x1887BD8B0")]
		public static void HNTOGZKHAWL(Dictionary<string, WSEPZXFZGWU> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x87BE7C0", Offset = "0x87BD1C0", VA = "0x1887BE7C0")]
		public static void RKBPHPNBSDO(WSEPZXFZGWU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x87BDD90", Offset = "0x87BC790", VA = "0x1887BDD90")]
		public static void LGGFOZVDHDY(Dictionary<string, List<WSEPZXFZGWU>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x87BD6C0", Offset = "0x87BC0C0", VA = "0x1887BD6C0")]
		private static void HINFKGOVCHY(WSEPZXFZGWU a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x87BD7F0", Offset = "0x87BC1F0", VA = "0x1887BD7F0")]
		internal static void HINFKGOVCHY(FDLXEYELZJU a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x87BE320", Offset = "0x87BCD20", VA = "0x1887BE320")]
		public static OGNAAAHQAIU MERNSKQYAWC(IEnumerable<OGNAAAHQAIU> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum ChunkFormat : uint
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		JSON = 1313821514u,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		BIN = 5130562u
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct GLBHeader
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public uint Version
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xF86CD0", Offset = "0xF856D0", VA = "0x180F86CD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x15E9000", Offset = "0x15E7A00", VA = "0x1815E9000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30F6F50", Offset = "0x30F5950", VA = "0x1830F6F50")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30F6F60", Offset = "0x30F5960", VA = "0x1830F6F60")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct ChunkInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long StartPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public uint Length;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ChunkFormat Type;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ZHUJEFRSRQH
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint CXFXWRVZPGI;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint UVMSWKBYVLM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint THPGYDIHBYU;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x87C92A0", Offset = "0x87C7CA0", VA = "0x1887C92A0")]
		public static void KRNGIGMEGEC(Stream a, [Out] UMVKRBFKGWI b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x87C8F50", Offset = "0x87C7950", VA = "0x1887C8F50")]
		public static ChunkInfo HPQITAPWKUW(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x87C8CA0", Offset = "0x87C76A0", VA = "0x1887C8CA0")]
		public static GLBHeader DKJXHRBGOSO(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x87C91E0", Offset = "0x87C7BE0", VA = "0x1887C91E0")]
		public static bool JXROJANDURO(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x87C8DE0", Offset = "0x87C77E0", VA = "0x1887C8DE0")]
		public static ChunkInfo DRMWGOUGNAZ(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x87C9460", Offset = "0x87C7E60", VA = "0x1887C9460")]
		private static void RILHYIOXBNZ(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x87C9700", Offset = "0x87C8100", VA = "0x1887C9700")]
		private static uint ZOUPFNKXCKS(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AGLIMOKANFX
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public enum PathElement
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			Root,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			RootExtension,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			Index,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			Extension,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			Child,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			Property
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <>c__DisplayClass24_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public string[] splittedPath;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int pathIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PathElement LHHMUKCLJSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int ALPNKJZOFUT
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string XEDOBOJWUDC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool XBKYTWSPUZD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD12250", Offset = "0xD10C50", VA = "0x180D12250")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AGLIMOKANFX XFCZVAFDHXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x87B2BF0", Offset = "0x87B15F0", VA = "0x1887B2BF0")]
		public string VLFRWGBXJVD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x87B29F0", Offset = "0x87B13F0", VA = "0x1887B29F0")]
		public AGLIMOKANFX GDHNDNFOQET(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x87B2E60", Offset = "0x87B1860", VA = "0x1887B2E60")]
		private AGLIMOKANFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x87B2CB0", Offset = "0x87B16B0", VA = "0x1887B2CB0")]
		public AGLIMOKANFX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5365F70", Offset = "0x5364970", VA = "0x185365F70")]
		[CompilerGenerated]
		internal static string DGZJKIPFFON(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x87B2C70", Offset = "0x87B1670", VA = "0x1887B2C70")]
		[CompilerGenerated]
		internal static bool WYIIKFXPFKE([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x87B2A10", Offset = "0x87B1410", VA = "0x1887B2A10")]
		[CompilerGenerated]
		internal static AGLIMOKANFX MXADRTVOMAC(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class SOJJDGYLQYO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x87C12F0", Offset = "0x87BFCF0", VA = "0x1887C12F0")]
		public static int[] MEPPIVQXQVO(this UMVKRBFKGWI a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x87C11A0", Offset = "0x87BFBA0", VA = "0x1887C11A0")]
		public static int[] CXBLYBIEDIC(this UMVKRBFKGWI a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class VLDWBDSEUQC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x87C2640", Offset = "0x87C1040", VA = "0x1887C2640")]
		public static uint EXIIXZTWLTD(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream RBOGKGSJFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long DCYMLEVPMGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long DLVANCWECHP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x87C1CF0", Offset = "0x87C06F0", VA = "0x1887C1CF0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x87C1D30", Offset = "0x87C0730", VA = "0x1887C1D30", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x87C1D30", Offset = "0x87C0730", VA = "0x1887C1D30", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x87C1D50", Offset = "0x87C0750", VA = "0x1887C1D50", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x87C1D70", Offset = "0x87C0770", VA = "0x1887C1D70", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x87C1D90", Offset = "0x87C0790", VA = "0x1887C1D90", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x87C1A80", Offset = "0x87C0480", VA = "0x1887C1A80")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x87C1840", Offset = "0x87C0240", VA = "0x1887C1840", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x87C19A0", Offset = "0x87C03A0", VA = "0x1887C19A0", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x87C1A00", Offset = "0x87C0400", VA = "0x1887C1A00", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x87C1910", Offset = "0x87C0310", VA = "0x1887C1910", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x87C1A40", Offset = "0x87C0440", VA = "0x1887C1A40", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x87C1880", Offset = "0x87C0280", VA = "0x1887C1880")]
		private void IWAOEVOWKQA()
		{
		}
	}
}
namespace GLTF.Math
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct Color : IEquatable<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static Color YIDLOVBUORG
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x87B3AD0", Offset = "0x87B24D0", VA = "0x1887B3AD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color EXVQGZOFYLI
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x87B39F0", Offset = "0x87B23F0", VA = "0x1887B39F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color NZATEIPGBIW
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x87B3AB0", Offset = "0x87B24B0", VA = "0x1887B3AB0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2E0C340", Offset = "0x2E0AD40", VA = "0x182E0C340")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x188C340", Offset = "0x188AD40", VA = "0x18188C340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2E66CD0", Offset = "0x2E656D0", VA = "0x182E66CD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2E66CE0", Offset = "0x2E656E0", VA = "0x182E66CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BDF1D0", Offset = "0x2BDDBD0", VA = "0x182BDF1D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x32F22D0", Offset = "0x32F0CD0", VA = "0x1832F22D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x152ACC0", Offset = "0x15296C0", VA = "0x18152ACC0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x152ACD0", Offset = "0x15296D0", VA = "0x18152ACD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1060", Offset = "0x2B9FA60", VA = "0x182BA1060")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x87B38A0", Offset = "0x87B22A0", VA = "0x1887B38A0", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x87B3950", Offset = "0x87B2350", VA = "0x1887B3950", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x87B3A00", Offset = "0x87B2400", VA = "0x1887B3A00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x87B37F0", Offset = "0x87B21F0", VA = "0x1887B37F0")]
		public static bool CYAUITUETAA(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class DSEFIPJTYMI : IEquatable<DSEFIPJTYMI>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly DSEFIPJTYMI VRGOTTMARJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] EEATQDYFPDX;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float GPRQQYEUMVA
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x87B5240", Offset = "0x87B3C40", VA = "0x1887B5240")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x87B5810", Offset = "0x87B4210", VA = "0x1887B5810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float NQTJKEARVKB
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x87B5A50", Offset = "0x87B4450", VA = "0x1887B5A50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x87B5300", Offset = "0x87B3D00", VA = "0x1887B5300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float URAAOIUZSFS
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x87B5870", Offset = "0x87B4270", VA = "0x1887B5870")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x87B5AE0", Offset = "0x87B44E0", VA = "0x1887B5AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float YTEQVOPWGZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x87B5720", Offset = "0x87B4120", VA = "0x1887B5720")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x87B5930", Offset = "0x87B4330", VA = "0x1887B5930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float GPMJTRKXDJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x87B51E0", Offset = "0x87B3BE0", VA = "0x1887B51E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x87B57B0", Offset = "0x87B41B0", VA = "0x1887B57B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float NQDOSJSZTCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x87B5A20", Offset = "0x87B4420", VA = "0x1887B5A20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x87B52D0", Offset = "0x87B3CD0", VA = "0x1887B52D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float URPVGDCRUNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x87B58A0", Offset = "0x87B42A0", VA = "0x1887B58A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x87B5B10", Offset = "0x87B4510", VA = "0x1887B5B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float YTJXSVJTQKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x87B5780", Offset = "0x87B4180", VA = "0x1887B5780")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x87B5990", Offset = "0x87B4390", VA = "0x1887B5990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GPHCWKQZTYI
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x87B5210", Offset = "0x87B3C10", VA = "0x1887B5210")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x87B57E0", Offset = "0x87B41E0", VA = "0x1887B57E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float NQIVPQMXCNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x87B59F0", Offset = "0x87B43F0", VA = "0x1887B59F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x87B52A0", Offset = "0x87B3CA0", VA = "0x1887B52A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float URKOIWIULCK
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x87B58D0", Offset = "0x87B42D0", VA = "0x1887B58D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x87B5B40", Offset = "0x87B4540", VA = "0x1887B5B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float YTPEQCDQZWB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x87B5750", Offset = "0x87B4150", VA = "0x1887B5750")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x87B5960", Offset = "0x87B4360", VA = "0x1887B5960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GPBVZDXCKMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x87B51B0", Offset = "0x87B3BB0", VA = "0x1887B51B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x87B5840", Offset = "0x87B4240", VA = "0x1887B5840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float NRJEBYIJXSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x87B5A80", Offset = "0x87B4480", VA = "0x1887B5A80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x87B5270", Offset = "0x87B3C70", VA = "0x1887B5270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float UQKFWONHPXR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x87B5900", Offset = "0x87B4300", VA = "0x1887B5900")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x87B5AB0", Offset = "0x87B44B0", VA = "0x1887B5AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float YTULNIXOJHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x87B56F0", Offset = "0x87B40F0", VA = "0x1887B56F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x87B59C0", Offset = "0x87B43C0", VA = "0x1887B59C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x87B5C50", Offset = "0x87B4650", VA = "0x1887B5C50")]
		public DSEFIPJTYMI(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x87B5330", Offset = "0x87B3D30", VA = "0x1887B5330", Slot = "4")]
		public bool Equals(DSEFIPJTYMI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x87B55F0", Offset = "0x87B3FF0", VA = "0x1887B55F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1105880", Offset = "0x1104280", VA = "0x181105880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Quaternion : IEquatable<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly Quaternion Identity;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x2E0C340", Offset = "0x2E0AD40", VA = "0x182E0C340")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x188C340", Offset = "0x188AD40", VA = "0x18188C340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2E66CD0", Offset = "0x2E656D0", VA = "0x182E66CD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2E66CE0", Offset = "0x2E656E0", VA = "0x182E66CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2BDF1D0", Offset = "0x2BDDBD0", VA = "0x182BDF1D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32F22D0", Offset = "0x32F0CD0", VA = "0x1832F22D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x152ACC0", Offset = "0x15296C0", VA = "0x18152ACC0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x152ACD0", Offset = "0x15296D0", VA = "0x18152ACD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x87C0B00", Offset = "0x87BF500", VA = "0x1887C0B00")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x87C07D0", Offset = "0x87BF1D0", VA = "0x1887C07D0", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x87C08F0", Offset = "0x87BF2F0", VA = "0x1887C08F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x87C09A0", Offset = "0x87BF3A0", VA = "0x1887C09A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x87C0760", Offset = "0x87BF160", VA = "0x1887C0760")]
		public static bool CYAUITUETAA(Quaternion a, Quaternion b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct Vector2 : IEquatable<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x2E0C340", Offset = "0x2E0AD40", VA = "0x182E0C340")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x188C340", Offset = "0x188AD40", VA = "0x18188C340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2E66CD0", Offset = "0x2E656D0", VA = "0x182E66CD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2E66CE0", Offset = "0x2E656E0", VA = "0x182E66CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x10741C0", Offset = "0x1072BC0", VA = "0x1810741C0")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x87C3E00", Offset = "0x87C2800", VA = "0x1887C3E00")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x87C3C70", Offset = "0x87C2670", VA = "0x1887C3C70", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x87C3CD0", Offset = "0x87C26D0", VA = "0x1887C3CD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x87C3DB0", Offset = "0x87C27B0", VA = "0x1887C3DB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x87C3C10", Offset = "0x87C2610", VA = "0x1887C3C10")]
		public static bool CYAUITUETAA(Vector2 a, Vector2 b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct Vector3 : IEquatable<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly Vector3 Zero;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly Vector3 One;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x2E0C340", Offset = "0x2E0AD40", VA = "0x182E0C340")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x188C340", Offset = "0x188AD40", VA = "0x18188C340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2E66CD0", Offset = "0x2E656D0", VA = "0x182E66CD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2E66CE0", Offset = "0x2E656E0", VA = "0x182E66CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2BDF1D0", Offset = "0x2BDDBD0", VA = "0x182BDF1D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32F22D0", Offset = "0x32F0CD0", VA = "0x1832F22D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x87C41C0", Offset = "0x87C2BC0", VA = "0x1887C41C0")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x87C3E90", Offset = "0x87C2890", VA = "0x1887C3E90", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x87C3F70", Offset = "0x87C2970", VA = "0x1887C3F70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x87C4030", Offset = "0x87C2A30", VA = "0x1887C4030", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x87C3E20", Offset = "0x87C2820", VA = "0x1887C3E20")]
		public static bool CYAUITUETAA(Vector3 a, Vector3 b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct Vector4 : IEquatable<Vector4>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x2E0C340", Offset = "0x2E0AD40", VA = "0x182E0C340")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x188C340", Offset = "0x188AD40", VA = "0x18188C340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E66CD0", Offset = "0x2E656D0", VA = "0x182E66CD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2E66CE0", Offset = "0x2E656E0", VA = "0x182E66CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2BDF1D0", Offset = "0x2BDDBD0", VA = "0x182BDF1D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x32F22D0", Offset = "0x32F0CD0", VA = "0x1832F22D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x152ACC0", Offset = "0x15296C0", VA = "0x18152ACC0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x152ACD0", Offset = "0x15296D0", VA = "0x18152ACD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1060", Offset = "0x2B9FA60", VA = "0x182BA1060")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x87B38A0", Offset = "0x87B22A0", VA = "0x1887B38A0", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x87C4240", Offset = "0x87C2C40", VA = "0x1887C4240", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x87B3A00", Offset = "0x87B2400", VA = "0x1887B3A00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class HAZTCETHZRM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x87B6880", Offset = "0x87B5280", VA = "0x1887B6880")]
		public static void BKTVREZGKOH(this JObject a, string b, NFXGIFNZSUM c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class VLDWBDSEUQC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x87C3340", Offset = "0x87C1D40", VA = "0x1887C3340")]
		public static List<string> QCUFJOAVLMQ(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x87C3180", Offset = "0x87C1B80", VA = "0x1887C3180")]
		public static List<double> OMIOQBCGGQU(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x87C37D0", Offset = "0x87C21D0", VA = "0x1887C37D0")]
		public static List<int> VYDJNUWFCML(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4112C80", Offset = "0x4111680", VA = "0x184112C80")]
		public static List<a> EYZPXMFHJON<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x87C1E40", Offset = "0x87C0840", VA = "0x1887C1E40")]
		public static NFXGIFNZSUM ABKZGRLAWVF(this JToken a, UMVKRBFKGWI b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x87C3AD0", Offset = "0x87C24D0", VA = "0x1887C3AD0")]
		public static int WKHDAQZKVNH(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x87C3990", Offset = "0x87C2390", VA = "0x1887C3990")]
		public static double WFZERZDEBEN(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x87C34F0", Offset = "0x87C1EF0", VA = "0x1887C34F0")]
		public static GLTF.Math.Color RMSJCEXJZUW(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x87C2F10", Offset = "0x87C1910", VA = "0x1887C2F10")]
		public static GLTF.Math.Color NSZZTGVXZMX(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x87C23A0", Offset = "0x87C0DA0", VA = "0x1887C23A0")]
		public static GLTF.Math.Color ESRVGKDLHAL(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x87C20E0", Offset = "0x87C0AE0", VA = "0x1887C20E0")]
		public static GLTF.Math.Vector3 CNCVVNYVKHR(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x87C2D00", Offset = "0x87C1700", VA = "0x1887C2D00")]
		public static GLTF.Math.Vector2 IAHAKDSGJNN(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x87C2AA0", Offset = "0x87C14A0", VA = "0x1887C2AA0")]
		public static GLTF.Math.Vector3 IABTMWYJACE(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x87C2790", Offset = "0x87C1190", VA = "0x1887C2790")]
		public static GLTF.Math.Quaternion GOWOAVWJNXX(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4113320", Offset = "0x4111D20", VA = "0x184113320")]
		public static Dictionary<string, b> WCYHUFYBAFX<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4112FD0", Offset = "0x41119D0", VA = "0x184112FD0")]
		public static c IHUQZGRIBWB<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public FDLXEYELZJU bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x87B6230", Offset = "0x87B4C30", VA = "0x1887B6230", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x87B61B0", Offset = "0x87B4BB0", VA = "0x1887B61B0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class XDZJDBHLERL : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x87C80C0", Offset = "0x87C6AC0", VA = "0x1887C80C0")]
		public XDZJDBHLERL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x87C7FF0", Offset = "0x87C69F0", VA = "0x1887C7FF0", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, HYHNESAJCVR> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x87B6070", Offset = "0x87B4A70", VA = "0x1887B6070", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x87B6130", Offset = "0x87B4B30", VA = "0x1887B6130")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class SUGVMAETUAP : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public UMVKRBFKGWI NEXPSVAOOPT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader SQQDARQWJCK;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x87B6450", Offset = "0x87B4E50", VA = "0x1887B6450")]
			internal HYHNESAJCVR SMZLQEGCTFK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x87C1720", Offset = "0x87C0120", VA = "0x1887C1720")]
		public SUGVMAETUAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x87C1590", Offset = "0x87BFF90", VA = "0x1887C1590", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public ITQGRFRGWXV FMJAVNDMHPS;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public EXT_texture_exr(ITQGRFRGWXV source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x87B6280", Offset = "0x87B4C80", VA = "0x1887B6280", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x87B62F0", Offset = "0x87B4CF0", VA = "0x1887B62F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ECGSTXTDDIS : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x87B6020", Offset = "0x87B4A20", VA = "0x1887B6020")]
		public ECGSTXTDDIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x87B5F00", Offset = "0x87B4900", VA = "0x1887B5F00", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum PositionalAudioDistanceModel
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		linear,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		inverse,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		exponential
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AudioEmitterId : KWEDGYYLVVY<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x87B33E0", Offset = "0x87B1DE0", VA = "0x1887B33E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x87B33A0", Offset = "0x87B1DA0", VA = "0x1887B33A0")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : KWEDGYYLVVY<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x87B3570", Offset = "0x87B1F70", VA = "0x1887B3570", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x87B3530", Offset = "0x87B1F30", VA = "0x1887B3530")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : KWEDGYYLVVY<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x87B3250", Offset = "0x87B1C50", VA = "0x1887B3250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x87B3210", Offset = "0x87B1C10", VA = "0x1887B3210")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x87B3130", Offset = "0x87B1B30", VA = "0x1887B3130")]
		public static AudioDataId Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x87B88A0", Offset = "0x87B72A0", VA = "0x1887B88A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x87B84A0", Offset = "0x87B6EA0", VA = "0x1887B84A0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x87B8510", Offset = "0x87B6F10", VA = "0x1887B8510")]
		public static KHR_SceneAudioEmittersRef Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x87B8B00", Offset = "0x87B7500", VA = "0x1887B8B00")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x87B8470", Offset = "0x87B6E70", VA = "0x1887B8470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x87B8350", Offset = "0x87B6D50", VA = "0x1887B8350", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x87B8140", Offset = "0x87B6B40", VA = "0x1887B8140", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x87B81B0", Offset = "0x87B6BB0", VA = "0x1887B81B0")]
		public static KHR_NodeAudioEmitterRef Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class OIFNJZWSQUT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string PTYYWLNSFUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? IFFBAOUPTMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? XRWRKAIFGMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? XXXYHAPAMFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? GLIXUMHACXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? MFTNRFPCAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? OJKGFEGXQWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? PFVXXILURVS;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x87BF990", Offset = "0x87BE390", VA = "0x1887BF990")]
		public JObject NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x87BF290", Offset = "0x87BDC90", VA = "0x1887BF290")]
		public static OIFNJZWSQUT Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public OIFNJZWSQUT()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public string type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float gain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public List<AudioSourceId> sources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public OIFNJZWSQUT positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x87B7790", Offset = "0x87B6190", VA = "0x1887B7790", Slot = "5")]
		public virtual JObject NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x87B7290", Offset = "0x87B5C90", VA = "0x1887B7290")]
		public static KHR_AudioEmitter Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x87B7B30", Offset = "0x87B6530", VA = "0x1887B7B30")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public bool? autoPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public float? gain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public bool? loop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AudioDataId audio;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x87B7F10", Offset = "0x87B6910", VA = "0x1887B7F10")]
		public JObject NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x87B7BB0", Offset = "0x87B65B0", VA = "0x1887B7BB0")]
		public static KHR_AudioSource Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x87B7280", Offset = "0x87B5C80", VA = "0x1887B7280")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public XDEZBKLUTIL bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x87B7150", Offset = "0x87B5B50", VA = "0x1887B7150")]
		public JObject NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x87B6EF0", Offset = "0x87B58F0", VA = "0x1887B6EF0")]
		public static KHR_AudioData Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x87B7280", Offset = "0x87B5C80", VA = "0x1887B7280")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public List<KHR_AudioData> audio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public List<KHR_AudioSource> sources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public List<KHR_AudioEmitter> emitters;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x87B8DC0", Offset = "0x87B77C0", VA = "0x1887B8DC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x87B8D30", Offset = "0x87B7730", VA = "0x1887B8D30", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x87B94F0", Offset = "0x87B7EF0", VA = "0x1887B94F0")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class DGMTCJGGHDU : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x87B4E90", Offset = "0x87B3890", VA = "0x1887B4E90")]
		public DGMTCJGGHDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x87B42C0", Offset = "0x87B2CC0", VA = "0x1887B42C0", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public XDEZBKLUTIL bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x87B96C0", Offset = "0x87B80C0", VA = "0x1887B96C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x87B9600", Offset = "0x87B8000", VA = "0x1887B9600", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x87B9710", Offset = "0x87B8110", VA = "0x1887B9710")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class HKZBJNKTEQE : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader SQQDARQWJCK;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x87B63E0", Offset = "0x87B4DE0", VA = "0x1887B63E0")]
			internal int SMZLQEGCTFK()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x87B6B10", Offset = "0x87B5510", VA = "0x1887B6B10")]
		public HKZBJNKTEQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x87B6900", Offset = "0x87B5300", VA = "0x1887B6900", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NFXGIFNZSUM anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x87B9810", Offset = "0x87B8210", VA = "0x1887B9810", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x87B9790", Offset = "0x87B8190", VA = "0x1887B9790", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class ZECFTGTOOPB : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x87C8C50", Offset = "0x87C7650", VA = "0x1887C8C50")]
		public ZECFTGTOOPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x87C8AA0", Offset = "0x87C74A0", VA = "0x1887C8AA0", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NFXGIFNZSUM clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NFXGIFNZSUM clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NFXGIFNZSUM clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x87B9AC0", Offset = "0x87B84C0", VA = "0x1887B9AC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x87B9A20", Offset = "0x87B8420", VA = "0x1887B9A20", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class DKUMFKAZPAJ : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x87B5160", Offset = "0x87B3B60", VA = "0x1887B5160")]
		public DKUMFKAZPAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x87B4EE0", Offset = "0x87B38E0", VA = "0x1887B4EE0", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x87B9E20", Offset = "0x87B8820", VA = "0x1887B9E20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x87B9DB0", Offset = "0x87B87B0", VA = "0x1887B9DB0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class ILQYJSDNIGN : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x87B6C30", Offset = "0x87B5630", VA = "0x1887B6C30")]
		public ILQYJSDNIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x87B6B60", Offset = "0x87B5560", VA = "0x1887B6B60", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : RJDJOSOWNDL, MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float WFHGDPWINJF;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x87BA170", Offset = "0x87B8B70", VA = "0x1887BA170")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x87BA100", Offset = "0x87B8B00", VA = "0x1887BA100")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, UMVKRBFKGWI root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x87B9F40", Offset = "0x87B8940", VA = "0x1887B9F40", Slot = "6")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x87B9FE0", Offset = "0x87B89E0", VA = "0x1887B9FE0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class KUBZDVUMOFM : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x87BEF30", Offset = "0x87BD930", VA = "0x1887BEF30")]
		public KUBZDVUMOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x87BEE30", Offset = "0x87BD830", VA = "0x1887BEE30", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x87BA220", Offset = "0x87B8C20", VA = "0x1887BA220", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x87BA1C0", Offset = "0x87B8BC0", VA = "0x1887BA1C0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x87BA370", Offset = "0x87B8D70", VA = "0x1887BA370")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class JNKEGYMJUUN : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x87B6D50", Offset = "0x87B5750", VA = "0x1887B6D50")]
		public JNKEGYMJUUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x87B6C80", Offset = "0x87B5680", VA = "0x1887B6C80", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public NFXGIFNZSUM iridescenceTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float iridescenceIor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public float iridescenceThicknessMinimum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public float iridescenceThicknessMaximum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public NFXGIFNZSUM iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x87BA420", Offset = "0x87B8E20", VA = "0x1887BA420", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x87BA380", Offset = "0x87B8D80", VA = "0x1887BA380", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x87BA7E0", Offset = "0x87B91E0", VA = "0x1887BA7E0")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class XNURSQFLAKD : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x87C85B0", Offset = "0x87C6FB0", VA = "0x1887C85B0")]
		public XNURSQFLAKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x87C82C0", Offset = "0x87C6CC0", VA = "0x1887C82C0", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class PCWFEUMWEZU : MZWJRAYYFSV
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 NWSEWYRLPIC;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double VZHPEUXCILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color CMMYUMZZFXI;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color UWYXRBKCUCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public NFXGIFNZSUM UIUHWYMHXVK;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly NFXGIFNZSUM BOIWVBSLYDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 LJJQEDSOXSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double HUSYPHHTBCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public NFXGIFNZSUM JULPDFURTDT;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly NFXGIFNZSUM IDLUEXNRICN;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x87C0530", Offset = "0x87BEF30", VA = "0x1887C0530")]
		public PCWFEUMWEZU(GLTF.Math.Color a, NFXGIFNZSUM b, GLTF.Math.Vector3 c, double d, NFXGIFNZSUM e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x87BFC00", Offset = "0x87BE600", VA = "0x1887BFC00", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x87BFDC0", Offset = "0x87BE7C0", VA = "0x1887BFDC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class SFYDKETHSOE : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x87C1150", Offset = "0x87BFB50", VA = "0x1887C1150")]
		public SFYDKETHSOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x87C0DF0", Offset = "0x87BF7F0", VA = "0x1887C0DF0", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public NFXGIFNZSUM sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NFXGIFNZSUM sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x87BA8D0", Offset = "0x87B92D0", VA = "0x1887BA8D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x87BA800", Offset = "0x87B9200", VA = "0x1887BA800", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x87BADE0", Offset = "0x87B97E0", VA = "0x1887BADE0")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class YSPWSHESQQO : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x87C8A50", Offset = "0x87C7450", VA = "0x1887C8A50")]
		public YSPWSHESQQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x87C87F0", Offset = "0x87C71F0", VA = "0x1887C87F0", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NFXGIFNZSUM specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NFXGIFNZSUM specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x87BAF20", Offset = "0x87B9920", VA = "0x1887BAF20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x87BAE50", Offset = "0x87B9850", VA = "0x1887BAE50", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x87BB440", Offset = "0x87B9E40", VA = "0x1887BB440")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ASIHGPTDISK : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x87B30E0", Offset = "0x87B1AE0", VA = "0x1887B30E0")]
		public ASIHGPTDISK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x87B2EC0", Offset = "0x87B18C0", VA = "0x1887B2EC0", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public NFXGIFNZSUM transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x87BB530", Offset = "0x87B9F30", VA = "0x1887BB530", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x87BB4B0", Offset = "0x87B9EB0", VA = "0x1887BB4B0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class KMXHUVKMVKD : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x87BC390", Offset = "0x87BAD90", VA = "0x1887BC390")]
		public KMXHUVKMVKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x87BC250", Offset = "0x87BAC50", VA = "0x1887BC250", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class GBIOBCCWCIE : RJDJOSOWNDL, MZWJRAYYFSV
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x87B6770", Offset = "0x87B5170", VA = "0x1887B6770")]
		public GBIOBCCWCIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x87B6700", Offset = "0x87B5100", VA = "0x1887B6700")]
		public GBIOBCCWCIE(GBIOBCCWCIE a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x87B6500", Offset = "0x87B4F00", VA = "0x1887B6500", Slot = "6")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x87B65A0", Offset = "0x87B4FA0", VA = "0x1887B65A0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x87B6630", Offset = "0x87B5030", VA = "0x1887B6630", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class SXVPWGLDVOS : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x87C17F0", Offset = "0x87C01F0", VA = "0x1887C17F0")]
		public SXVPWGLDVOS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x87C1770", Offset = "0x87C0170", VA = "0x1887C1770", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public NFXGIFNZSUM thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x87BB750", Offset = "0x87BA150", VA = "0x1887BB750", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x87BB6C0", Offset = "0x87BA0C0", VA = "0x1887BB6C0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x87BBC80", Offset = "0x87BA680", VA = "0x1887BBC80")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class RCHNQNZGQFX : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x87C0DA0", Offset = "0x87BF7A0", VA = "0x1887C0DA0")]
		public RCHNQNZGQFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x87C0B90", Offset = "0x87BF590", VA = "0x1887C0B90", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x87BBD00", Offset = "0x87BA700", VA = "0x1887BBD00", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x87BBCA0", Offset = "0x87BA6A0", VA = "0x1887BBCA0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1252F50", Offset = "0x1251950", VA = "0x181252F50")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class CSCCISBTEFV : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x87B37A0", Offset = "0x87B21A0", VA = "0x1887B37A0")]
		public CSCCISBTEFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x87B36C0", Offset = "0x87B20C0", VA = "0x1887B36C0", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x87BBE70", Offset = "0x87BA870", VA = "0x1887BBE70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x87BBE10", Offset = "0x87BA810", VA = "0x1887BBE10", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1252F50", Offset = "0x1251950", VA = "0x181252F50")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class LVKNPCRJMDL : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x87BF240", Offset = "0x87BDC40", VA = "0x1887BF240")]
		public LVKNPCRJMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x87BF160", Offset = "0x87BDB60", VA = "0x1887BF160", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x87BBFE0", Offset = "0x87BA9E0", VA = "0x1887BBFE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x87BBF80", Offset = "0x87BA980", VA = "0x1887BBF80", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1252F50", Offset = "0x1251950", VA = "0x181252F50")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class PMUTFXZCCVN : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x87C0710", Offset = "0x87BF110", VA = "0x1887C0710")]
		public PMUTFXZCCVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x87C0630", Offset = "0x87BF030", VA = "0x1887C0630", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public ITQGRFRGWXV source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public KHR_texture_basisu(ITQGRFRGWXV source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x87BC0F0", Offset = "0x87BAAF0", VA = "0x1887BC0F0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x87BC160", Offset = "0x87BAB60", VA = "0x1887BC160", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class XHAFKQAYRZT : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x87C8270", Offset = "0x87C6C70", VA = "0x1887C8270")]
		public XHAFKQAYRZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x87C8110", Offset = "0x87C6B10", VA = "0x1887C8110", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class DDUKGKHLGQS : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 VFZFKOJRRKG;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 VHGRGATDWCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double UPRTWCVGHDR;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double HLBCHTUHOWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 XGEMPETLZEZ;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 ZLXDIMFCXUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? ASHGFSSZJIT;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int TEEKLSBYVGN;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x87B4240", Offset = "0x87B2C40", VA = "0x1887B4240")]
		public DDUKGKHLGQS(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x87B3AF0", Offset = "0x87B24F0", VA = "0x1887B3AF0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x87B3BD0", Offset = "0x87B25D0", VA = "0x1887B3BD0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class WZIYKOAYLTK : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x87C7FA0", Offset = "0x87C69A0", VA = "0x1887C7FA0")]
		public WZIYKOAYLTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x87C7CD0", Offset = "0x87C66D0", VA = "0x1887C7CD0", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class XYDKVSUSUCU : MZWJRAYYFSV
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> UVEIBWLHVKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public XYDKVSUSUCU(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x87C8600", Offset = "0x87C7000", VA = "0x1887C8600", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x87C8700", Offset = "0x87C7100", VA = "0x1887C8700", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x87C8670", Offset = "0x87C7070", VA = "0x1887C8670")]
		public List<double> FTHQVAYNFPC(RHNNOHYQJTP a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class JTBDNMQFTTE : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x87B6EA0", Offset = "0x87B58A0", VA = "0x1887B6EA0")]
		public JTBDNMQFTTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x87B6DA0", Offset = "0x87B57A0", VA = "0x1887B6DA0", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class ZUFXHFCXCIO : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public XDEZBKLUTIL FDLXEYELZJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint SAURHXNZBGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType EDTPQHICLIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool QYVGUEHMIZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint PUCTPTIOQGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType YFKMMNNXMAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> UEGRDDDOCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> SEBXUWMDPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public SMYCABBPIGG MCZFGRGLBLH;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x87B7280", Offset = "0x87B5C80", VA = "0x1887B7280")]
		public ZUFXHFCXCIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x87CA580", Offset = "0x87C8F80", VA = "0x1887CA580")]
		public static ZUFXHFCXCIO Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x87CC250", Offset = "0x87CAC50", VA = "0x1887CC250", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x87CDB00", Offset = "0x87CC500", VA = "0x1887CDB00")]
		private unsafe static sbyte WQTXOUCMRFF(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x87CC150", Offset = "0x87CAB50", VA = "0x1887CC150")]
		private unsafe static float2 NBFOEAUIHCT(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x87CD9E0", Offset = "0x87CC3E0", VA = "0x1887CD9E0")]
		private unsafe static float3 VDMFWBLXXNQ(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x87CC180", Offset = "0x87CAB80", VA = "0x1887CC180")]
		private unsafe static float4 NHNYNHPAGYR(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x87CD140", Offset = "0x87CBB40", VA = "0x1887CD140")]
		private unsafe static float4x4 TEQMSMBTVUJ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x87CDB00", Offset = "0x87CC500", VA = "0x1887CDB00")]
		private unsafe static byte XWIETDNEUAI(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x87CC830", Offset = "0x87CB230", VA = "0x1887CC830")]
		private unsafe static float2 ORQGWYPCVIK(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x87CAB10", Offset = "0x87C9510", VA = "0x1887CAB10")]
		private unsafe static float3 ETPXOBQLXCD(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x87CDEB0", Offset = "0x87CC8B0", VA = "0x1887CDEB0")]
		private unsafe static float4 YERBDTNZGTG(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x87CAE10", Offset = "0x87C9810", VA = "0x1887CAE10")]
		private unsafe static float4x4 GBFRBENPRAE(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x87C9BB0", Offset = "0x87C85B0", VA = "0x1887C9BB0")]
		private unsafe static short RFPCXBWAZPD(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x87CD530", Offset = "0x87CBF30", VA = "0x1887CD530")]
		private unsafe static float2 TOBGEMFCJON(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x87CCE80", Offset = "0x87CB880", VA = "0x1887CCE80")]
		private unsafe static float3 REPNRFLWFVK(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x87CDF80", Offset = "0x87CC980", VA = "0x1887CDF80")]
		private unsafe static float4 ZLEOXOESDQT(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x87CDFE0", Offset = "0x87CC9E0", VA = "0x1887CDFE0")]
		private unsafe static float4x4 ZPKSEQFYZXJ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x87C9BB0", Offset = "0x87C85B0", VA = "0x1887C9BB0")]
		private unsafe static ushort AUYNQXLESXW(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x87CDE80", Offset = "0x87CC880", VA = "0x1887CDE80")]
		private unsafe static float2 XBFHNCQUJIO(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x87CC1E0", Offset = "0x87CABE0", VA = "0x1887CC1E0")]
		private unsafe static float3 NTXNMMZTOWT(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x87C9CF0", Offset = "0x87C86F0", VA = "0x1887C9CF0")]
		private unsafe static float4x4 CUFSOCHEWEU(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x87CDF20", Offset = "0x87CC920", VA = "0x1887CDF20")]
		private unsafe static float4 ZCPNLYTDFNS(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x87C9BC0", Offset = "0x87C85C0", VA = "0x1887C9BC0")]
		private unsafe static uint AYECNFLMJEJ(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x87C9BB0", Offset = "0x87C85B0", VA = "0x1887C9BB0")]
		private unsafe static ushort PXCXMRAPOUA(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x87CDF10", Offset = "0x87CC910", VA = "0x1887CDF10")]
		private unsafe static float YZHJRXEEJEF(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x87C9B90", Offset = "0x87C8590", VA = "0x1887C9B90")]
		private unsafe static float2 AICNSFNLQBH(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x87CC230", Offset = "0x87CAC30", VA = "0x1887CC230")]
		private unsafe static float3 NURWPPXNDFW(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x87CB6A0", Offset = "0x87CA0A0", VA = "0x1887CB6A0")]
		private unsafe static float4 UFBSXNUPPHZ(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x87C9E90", Offset = "0x87C8890", VA = "0x1887C9E90")]
		private unsafe static float4x4 CZQCSIGNKGD(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x87CB6A0", Offset = "0x87CA0A0", VA = "0x1887CB6A0")]
		private unsafe static float4 KWLSHXMKGUC(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x87CB670", Offset = "0x87CA070", VA = "0x1887CB670")]
		private unsafe static float4 KWLSHXMKGUC(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x87CC9D0", Offset = "0x87CB3D0", VA = "0x1887CC9D0")]
		public static float3[] PBSKKFRBYDJ(ZUFXHFCXCIO a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x87CD560", Offset = "0x87CBF60", VA = "0x1887CD560")]
		public static float3[] TUSYXOFKISL(ZUFXHFCXCIO a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x87CC860", Offset = "0x87CB260", VA = "0x1887CC860")]
		public static uint[] OVQZPGYJGDA(ZUFXHFCXCIO a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x87CCC00", Offset = "0x87CB600", VA = "0x1887CCC00")]
		internal static void PCCEZDLLUZR(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x87CD2E0", Offset = "0x87CBCE0", VA = "0x1887CD2E0")]
		public uint[] TNURQPDGATY(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x87CCED0", Offset = "0x87CB8D0", VA = "0x1887CCED0")]
		public float[] SXSMBDZTKKO(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x87CAFB0", Offset = "0x87C99B0", VA = "0x1887CAFB0")]
		public float2[] GTUGNZLDIGW(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x87CAB60", Offset = "0x87C9560", VA = "0x1887CAB60")]
		public float2[] FKFKDASLDTS(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x87CB840", Offset = "0x87CA240", VA = "0x1887CB840")]
		public float3[] MIBEGKETWOL(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x87CBAC0", Offset = "0x87CA4C0", VA = "0x1887CBAC0")]
		public float3[] MNTVZYZEXMD(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x87CB400", Offset = "0x87C9E00", VA = "0x1887CB400")]
		public float4[] KLCCFTNSRPK(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x87CDB10", Offset = "0x87CC510", VA = "0x1887CDB10")]
		public float4[] WXRGVGETTRO(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x87C9800", Offset = "0x87C8200", VA = "0x1887C9800")]
		public float4[] AGFMPTRZRUV(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x87C9EC0", Offset = "0x87C88C0", VA = "0x1887C9EC0")]
		public float3[] DEEWIUJMIAI(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x87CCD20", Offset = "0x87CB720", VA = "0x1887CCD20")]
		public float3[] PYMVIOUODVZ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x87CDA30", Offset = "0x87CC430", VA = "0x1887CDA30")]
		public float4[] VYXITQWXAXB(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x87CCE30", Offset = "0x87CB830", VA = "0x1887CCE30")]
		public uint[] QJEDFWSGSCC(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x87C9FD0", Offset = "0x87C89D0", VA = "0x1887C9FD0")]
		public float4x4[] DUEECDJOJQZ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x87CBF90", Offset = "0x87CA990", VA = "0x1887CBF90")]
		private unsafe static float4 NBCKADHREAF(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x87CBE10", Offset = "0x87CA810", VA = "0x1887CBE10")]
		private unsafe static float4 NBCKADHREAF(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x87CB6D0", Offset = "0x87CA0D0", VA = "0x1887CB6D0")]
		private unsafe static float4x4 KZQJDIVCLXQ(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x87CB240", Offset = "0x87C9C40", VA = "0x1887CB240")]
		private unsafe static float4 JYZQYXQLUFE(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x87CD870", Offset = "0x87CC270", VA = "0x1887CD870")]
		private unsafe static float3 UMHMTYVDWWV(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x87CA9E0", Offset = "0x87C93E0", VA = "0x1887CA9E0")]
		private unsafe static float2 EEDCIYSRUXW(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x87C9BD0", Offset = "0x87C85D0", VA = "0x1887C9BD0")]
		private unsafe static uint CILYENEDQJP(void* a, uint b, GLTFComponentType c)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public enum GLTFComponentType
	{
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		Byte = 5120,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		UnsignedByte = 5121,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		Short = 5122,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		UnsignedShort = 5123,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		UnsignedInt = 5125,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		Float = 5126
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public enum GLTFAccessorAttributeType
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		SCALAR,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		VEC2,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		VEC3,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		VEC4,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		MAT2,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		MAT3,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		MAT4
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class FDUTODVMZHV
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x87D1310", Offset = "0x87CFD10", VA = "0x1887D1310")]
		public static int RZEMYZLRNZV(this GLTFAccessorAttributeType a)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct NumericArray
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public uint[] AsUInts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public float[] AsFloats;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public float2[] AsFloat2s;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public float3[] AsFloat3s;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public float4[] AsFloat4s;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public float4x4[] AsMatrix4x4s;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public uint[] AsTriangles;
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class SMYCABBPIGG : RJDJOSOWNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int PUCTPTIOQGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public ENSEUJPJZID VHWAFBZSPMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public HOMRVGDOZXG CDQGXSVKNCH;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x87DC6F0", Offset = "0x87DB0F0", VA = "0x1887DC6F0")]
		public SMYCABBPIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x87DC2F0", Offset = "0x87DACF0", VA = "0x1887DC2F0")]
		public static SMYCABBPIGG Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x87DC5C0", Offset = "0x87DAFC0", VA = "0x1887DC5C0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class ENSEUJPJZID : RJDJOSOWNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public XDEZBKLUTIL FDLXEYELZJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int SAURHXNZBGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType EDTPQHICLIQ;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x87D0AC0", Offset = "0x87CF4C0", VA = "0x1887D0AC0")]
		public ENSEUJPJZID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x87D06A0", Offset = "0x87CF0A0", VA = "0x1887D06A0")]
		public static ENSEUJPJZID Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x87D0980", Offset = "0x87CF380", VA = "0x1887D0980", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class HOMRVGDOZXG : RJDJOSOWNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public XDEZBKLUTIL FDLXEYELZJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int SAURHXNZBGY;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x87D20E0", Offset = "0x87D0AE0", VA = "0x1887D20E0")]
		public HOMRVGDOZXG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x87D1D60", Offset = "0x87D0760", VA = "0x1887D1D60")]
		public static HOMRVGDOZXG Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x87D1FE0", Offset = "0x87D09E0", VA = "0x1887D1FE0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class FBTFVKCWNVS : RJDJOSOWNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public EDQVRSMWIDI ZLTHMRIGXHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public HNJRRZZSFHX YKILMMNATTC;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x87D0E00", Offset = "0x87CF800", VA = "0x1887D0E00")]
		public FBTFVKCWNVS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x87D0B10", Offset = "0x87CF510", VA = "0x1887D0B10")]
		public static FBTFVKCWNVS Deserialize(UMVKRBFKGWI root, JsonReader reader, CWCKCFASOBI anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x87D0D00", Offset = "0x87CF700", VA = "0x1887D0D00", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class HNJRRZZSFHX : RJDJOSOWNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public OGNAAAHQAIU RHNNOHYQJTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string AALLBBZXAZQ;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x87D1990", Offset = "0x87D0390", VA = "0x1887D1990")]
		public static HNJRRZZSFHX Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x87D1D10", Offset = "0x87D0710", VA = "0x1887D1D10")]
		public HNJRRZZSFHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x87D1BF0", Offset = "0x87D05F0", VA = "0x1887D1BF0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum GLTFAnimationChannelPath
	{
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		translation,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		rotation,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		scale,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		weights,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		pointer
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class EFASQHYZTFI
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(EFASQHYZTFI data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] HSSDJIIBNJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type EWEPOECZFGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] ITIBSMJQOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion GKAXGBKGFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string JTOUWZXZJTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string RMOWUVDSQOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public WSEPZXFZGWU PTOJHSFTWCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string SQBNYWNMCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string CNGQZSZNHXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public WSEPZXFZGWU YQBCJOVGOKB;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x87D0480", Offset = "0x87CEE80", VA = "0x1887D0480")]
		public EFASQHYZTFI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum InterpolationType
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		LINEAR,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		STEP,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		CATMULLROMSPLINE,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		CUBICSPLINE
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class PMXEEBFDOGP : RJDJOSOWNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public HYHNESAJCVR DKRWZWDPYYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType YBSEABBTMXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public HYHNESAJCVR DDBLMQQIHWY;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x87D79E0", Offset = "0x87D63E0", VA = "0x1887D79E0")]
		public PMXEEBFDOGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x87D7650", Offset = "0x87D6050", VA = "0x1887D7650")]
		public static PMXEEBFDOGP Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x87D7870", Offset = "0x87D6270", VA = "0x1887D7870", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class OWMJOBRTNFJ : RJDJOSOWNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string YJVHJTPWADU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string KUZENOPAEYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string YOEKAAIYPRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string XYRYNVLAPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> URELCNYTATP;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x87D65C0", Offset = "0x87D4FC0", VA = "0x1887D65C0")]
		public OWMJOBRTNFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x87D5AD0", Offset = "0x87D44D0", VA = "0x1887D5AD0")]
		public static OWMJOBRTNFJ Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x87D6190", Offset = "0x87D4B90", VA = "0x1887D6190", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x87D65B0", Offset = "0x87D4FB0", VA = "0x1887D65B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x87D5DF0", Offset = "0x87D47F0", VA = "0x1887D5DF0")]
		public string EZWGFCAVZCR(bool a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public enum BufferViewTarget
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		ArrayBuffer = 34962,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		ElementArrayBuffer = 34963
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class FDLXEYELZJU : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public BJXKJBBDFYW SVMFSVQCHIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint SAURHXNZBGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint EVZZDLMEZQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint WHCATYPTPOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget YKILMMNATTC;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x87CF780", Offset = "0x87CE180", VA = "0x1887CF780")]
		public FDLXEYELZJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x87D0E50", Offset = "0x87CF850", VA = "0x1887D0E50")]
		public static FDLXEYELZJU Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x87D1100", Offset = "0x87CFB00", VA = "0x1887D1100", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class RLZEZCRLRKI : RJDJOSOWNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double LPRWUUIWZOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double CSAXYWEVBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double JBYQAKHZXBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double TFKFBBUSWPV;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x87DC060", Offset = "0x87DAA60", VA = "0x1887DC060")]
		public RLZEZCRLRKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x87DBB70", Offset = "0x87DA570", VA = "0x1887DBB70")]
		public static RLZEZCRLRKI Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x87DBEF0", Offset = "0x87DA8F0", VA = "0x1887DBEF0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class QJOJGVEKCUQ : RJDJOSOWNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double HHZQFSOSRMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double WVWVGJXGYJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double JBYQAKHZXBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double TFKFBBUSWPV;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x87D85A0", Offset = "0x87D6FA0", VA = "0x1887D85A0")]
		public QJOJGVEKCUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x87D80A0", Offset = "0x87D6AA0", VA = "0x1887D80A0")]
		public static QJOJGVEKCUQ Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x87D8410", Offset = "0x87D6E10", VA = "0x1887D8410", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class CWCKCFASOBI : NMRTCVGFESK
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public UMVKRBFKGWI NEXPSVAOOPT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader SQQDARQWJCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public CWCKCFASOBI MOFEPYVVFDX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<FBTFVKCWNVS> EQAHRUTEVEQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<PMXEEBFDOGP> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x87D18E0", Offset = "0x87D02E0", VA = "0x1887D18E0")]
			internal FBTFVKCWNVS SMZLQEGCTFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x87D1900", Offset = "0x87D0300", VA = "0x1887D1900")]
			internal PMXEEBFDOGP SNESNLAACQT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<FBTFVKCWNVS> IFEMOURDRJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<PMXEEBFDOGP> GTUEKTFCWMA;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x87CEB90", Offset = "0x87CD590", VA = "0x1887CEB90")]
		public static CWCKCFASOBI Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x87CF2F0", Offset = "0x87CDCF0", VA = "0x1887CF2F0")]
		public CWCKCFASOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x87CEF50", Offset = "0x87CD950", VA = "0x1887CEF50", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class WNHMBYUWLBQ : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string TAUDZHUAFYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint EVZZDLMEZQH;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x87CF780", Offset = "0x87CE180", VA = "0x1887CF780")]
		public WNHMBYUWLBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x87DFDF0", Offset = "0x87DE7F0", VA = "0x1887DFDF0")]
		public static WNHMBYUWLBQ Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x87DFFC0", Offset = "0x87DE9C0", VA = "0x1887DFFC0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class DNUOVHETSIL : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public RLZEZCRLRKI VHKWOICVWLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public QJOJGVEKCUQ GWYJQYPMVDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType YFKMMNNXMAZ;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x87CF780", Offset = "0x87CE180", VA = "0x1887CF780")]
		public DNUOVHETSIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x87CF3E0", Offset = "0x87CDDE0", VA = "0x1887CF3E0")]
		public static DNUOVHETSIL Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x87CF5B0", Offset = "0x87CDFB0", VA = "0x1887CF5B0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum CameraType
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		perspective,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		orthographic
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class NMRTCVGFESK : RJDJOSOWNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string CTZDLOJAEUK;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x87CF780", Offset = "0x87CE180", VA = "0x1887CF780")]
		public NMRTCVGFESK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x87D44E0", Offset = "0x87D2EE0", VA = "0x1887D44E0")]
		public NMRTCVGFESK(NMRTCVGFESK a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x87D43F0", Offset = "0x87D2DF0", VA = "0x1887D43F0")]
		public new void ONDFWRAAKYY(UMVKRBFKGWI a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x87D4360", Offset = "0x87D2D60", VA = "0x1887D4360", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class KWEDGYYLVVY<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int CRWLHSKOIBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public UMVKRBFKGWI YXDZNKGUVHX;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected KWEDGYYLVVY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6872AC0", Offset = "0x68714C0", VA = "0x186872AC0")]
		public KWEDGYYLVVY(KWEDGYYLVVY<a> a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6872A90", Offset = "0x6871490", VA = "0x186872A90")]
		public void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class HYHNESAJCVR : KWEDGYYLVVY<ZUFXHFCXCIO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override ZUFXHFCXCIO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x87D2490", Offset = "0x87D0E90", VA = "0x1887D2490", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x87D23F0", Offset = "0x87D0DF0", VA = "0x1887D23F0")]
		public HYHNESAJCVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x87D2430", Offset = "0x87D0E30", VA = "0x1887D2430")]
		public HYHNESAJCVR(HYHNESAJCVR a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x87D2310", Offset = "0x87D0D10", VA = "0x1887D2310")]
		public static HYHNESAJCVR Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class BJXKJBBDFYW : KWEDGYYLVVY<WNHMBYUWLBQ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override WNHMBYUWLBQ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x87CE7E0", Offset = "0x87CD1E0", VA = "0x1887CE7E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x87CE7A0", Offset = "0x87CD1A0", VA = "0x1887CE7A0")]
		public BJXKJBBDFYW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x87CE6C0", Offset = "0x87CD0C0", VA = "0x1887CE6C0")]
		public static BJXKJBBDFYW Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class XDEZBKLUTIL : KWEDGYYLVVY<FDLXEYELZJU>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override FDLXEYELZJU Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x87E0DA0", Offset = "0x87DF7A0", VA = "0x1887E0DA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x87E0D60", Offset = "0x87DF760", VA = "0x1887E0D60")]
		public XDEZBKLUTIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x87E0C80", Offset = "0x87DF680", VA = "0x1887E0C80")]
		public static XDEZBKLUTIL Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class EIKNAPQOSTZ : KWEDGYYLVVY<DNUOVHETSIL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override DNUOVHETSIL Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x87D0640", Offset = "0x87CF040", VA = "0x1887D0640", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x87D0600", Offset = "0x87CF000", VA = "0x1887D0600")]
		public EIKNAPQOSTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x87D0520", Offset = "0x87CEF20", VA = "0x1887D0520")]
		public static EIKNAPQOSTZ Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class ITQGRFRGWXV : KWEDGYYLVVY<LTEBGRWBKUR>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override LTEBGRWBKUR Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x87D2610", Offset = "0x87D1010", VA = "0x1887D2610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x87D25D0", Offset = "0x87D0FD0", VA = "0x1887D25D0")]
		public ITQGRFRGWXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x87D24F0", Offset = "0x87D0EF0", VA = "0x1887D24F0")]
		public static ITQGRFRGWXV Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class XJVVNMRVGLL : KWEDGYYLVVY<OLJOBCTZNER>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override OLJOBCTZNER Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x87E0F80", Offset = "0x87DF980", VA = "0x1887E0F80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x87E0F40", Offset = "0x87DF940", VA = "0x1887E0F40")]
		public XJVVNMRVGLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x87E0EE0", Offset = "0x87DF8E0", VA = "0x1887E0EE0")]
		public XJVVNMRVGLL(XJVVNMRVGLL a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x87E0E00", Offset = "0x87DF800", VA = "0x1887E0E00")]
		public static XJVVNMRVGLL Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class RLTDEIJDSHH : KWEDGYYLVVY<LRYEZTADGEZ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override LRYEZTADGEZ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x87DBB10", Offset = "0x87DA510", VA = "0x1887DBB10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x87DBAD0", Offset = "0x87DA4D0", VA = "0x1887DBAD0")]
		public RLTDEIJDSHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x87DB9F0", Offset = "0x87DA3F0", VA = "0x1887DB9F0")]
		public static RLTDEIJDSHH Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class OGNAAAHQAIU : KWEDGYYLVVY<RHNNOHYQJTP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override RHNNOHYQJTP Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x87D5090", Offset = "0x87D3A90", VA = "0x1887D5090", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x87D5050", Offset = "0x87D3A50", VA = "0x1887D5050")]
		public OGNAAAHQAIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x87D4D00", Offset = "0x87D3700", VA = "0x1887D4D00")]
		public static OGNAAAHQAIU Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x87D4DE0", Offset = "0x87D37E0", VA = "0x1887D4DE0")]
		public static List<OGNAAAHQAIU> EYZPXMFHJON(UMVKRBFKGWI a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class XTAQTHAXXES : KWEDGYYLVVY<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x87E1100", Offset = "0x87DFB00", VA = "0x1887E1100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x87E10C0", Offset = "0x87DFAC0", VA = "0x1887E10C0")]
		public XTAQTHAXXES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x87E0FE0", Offset = "0x87DF9E0", VA = "0x1887E0FE0")]
		public static XTAQTHAXXES Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class EDQVRSMWIDI : KWEDGYYLVVY<PMXEEBFDOGP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public CWCKCFASOBI CWCKCFASOBI;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override PMXEEBFDOGP Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x87D0420", Offset = "0x87CEE20", VA = "0x1887D0420", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x87D03E0", Offset = "0x87CEDE0", VA = "0x1887D03E0")]
		public EDQVRSMWIDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x87D02E0", Offset = "0x87CECE0", VA = "0x1887D02E0")]
		public static EDQVRSMWIDI Deserialize(UMVKRBFKGWI root, CWCKCFASOBI anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class XTVXQQJFRUG : KWEDGYYLVVY<DUBBBZCYNWU>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override DUBBBZCYNWU Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x87E1280", Offset = "0x87DFC80", VA = "0x1887E1280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x87E1240", Offset = "0x87DFC40", VA = "0x1887E1240")]
		public XTVXQQJFRUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x87E1160", Offset = "0x87DFB60", VA = "0x1887E1160")]
		public static XTVXQQJFRUG Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class TRYUEOTRPLH : KWEDGYYLVVY<DQODYHYBBWM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override DQODYHYBBWM Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x87DCD90", Offset = "0x87DB790", VA = "0x1887DCD90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x87DCD50", Offset = "0x87DB750", VA = "0x1887DCD50")]
		public TRYUEOTRPLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x87DCC70", Offset = "0x87DB670", VA = "0x1887DCC70")]
		public static TRYUEOTRPLH Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class HUZHYQGYCEF : KWEDGYYLVVY<JWOCSZJSECD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override JWOCSZJSECD Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x87D22B0", Offset = "0x87D0CB0", VA = "0x1887D22B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x87D2270", Offset = "0x87D0C70", VA = "0x1887D2270")]
		public HUZHYQGYCEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x87D2210", Offset = "0x87D0C10", VA = "0x1887D2210")]
		public HUZHYQGYCEF(HUZHYQGYCEF a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x87D2130", Offset = "0x87D0B30", VA = "0x1887D2130")]
		public static HUZHYQGYCEF Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class KHGXDQYXEAG : KWEDGYYLVVY<LLCVOVJISQY>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override LLCVOVJISQY Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x87D29F0", Offset = "0x87D13F0", VA = "0x1887D29F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x87D29B0", Offset = "0x87D13B0", VA = "0x1887D29B0")]
		public KHGXDQYXEAG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class LTEBGRWBKUR : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string TAUDZHUAFYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string MUWRJPOAPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public XDEZBKLUTIL FDLXEYELZJU;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x87CF780", Offset = "0x87CE180", VA = "0x1887CF780")]
		public LTEBGRWBKUR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x87D3A60", Offset = "0x87D2460", VA = "0x1887D3A60")]
		public static LTEBGRWBKUR Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x87D3CA0", Offset = "0x87D26A0", VA = "0x1887D3CA0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class OLJOBCTZNER : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public QGANMIYRXEM QGANMIYRXEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public FSFYUPLVYKJ PMDZHNWJICY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public YLKXUMQBYYZ AVEWYGYKEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public LIDHDXTADIF ZGEQYOMTENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public NFXGIFNZSUM LNBMGWNGMNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color OPHCLZEXZWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode ZLXJQTGGNXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double JKCDKBRSTKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool OVCTEUYZPIN;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x87D5A60", Offset = "0x87D4460", VA = "0x1887D5A60")]
		public OLJOBCTZNER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x87D50F0", Offset = "0x87D3AF0", VA = "0x1887D50F0")]
		public static OLJOBCTZNER Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x87D5600", Offset = "0x87D4000", VA = "0x1887D5600", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public enum AlphaMode
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		OPAQUE,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		MASK,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		BLEND
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class LRYEZTADGEZ : NMRTCVGFESK
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class KRDFVZFEZPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public UMVKRBFKGWI NEXPSVAOOPT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader SQQDARQWJCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<YMAKEZFFZYF> EQAHRUTEVEQ;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x87D2A50", Offset = "0x87D1450", VA = "0x1887D2A50")]
			internal YMAKEZFFZYF SMZLQEGCTFK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<YMAKEZFFZYF> ESXJJAGTKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> VCMQIWBZQDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> FNUEGVRMSRK;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x87CF780", Offset = "0x87CE180", VA = "0x1887CF780")]
		public LRYEZTADGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x87D30F0", Offset = "0x87D1AF0", VA = "0x1887D30F0")]
		public static LRYEZTADGEZ Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x87D34B0", Offset = "0x87D1EB0", VA = "0x1887D34B0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class RJDJOSOWNDL
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, HVJDTAFBXHO> RFVHUZSICOQ;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static GRDTHWCPLJJ POKDRGXHZVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, MZWJRAYYFSV> MLEFZETHFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken KLYFLJFUCPE;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x87DA790", Offset = "0x87D9190", VA = "0x1887DA790")]
		public static HVJDTAFBXHO OFZITWIEKUX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x87D9D40", Offset = "0x87D8740", VA = "0x1887D9D40")]
		public static MZWJRAYYFSV LDIRZLAJFQX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RJDJOSOWNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x87DB700", Offset = "0x87DA100", VA = "0x1887DB700")]
		public RJDJOSOWNDL(RJDJOSOWNDL a, [Optional] UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x87DA920", Offset = "0x87D9320", VA = "0x1887DA920")]
		public void ONDFWRAAKYY(UMVKRBFKGWI a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x87DACC0", Offset = "0x87D96C0", VA = "0x1887DACC0")]
		public void WUIULCGEEWB(string a, MZWJRAYYFSV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x87DABD0", Offset = "0x87D95D0", VA = "0x1887DABD0")]
		private void ORUVVQSTZCX(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x87DAE10", Offset = "0x87D9810", VA = "0x1887DAE10")]
		private void ZICCROBXXMJ(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C80", Offset = "0x87D8680", VA = "0x1887D9C80")]
		private void IQIVRQYLPKX(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x87D9E30", Offset = "0x87D8830", VA = "0x1887D9E30")]
		internal static Dictionary<string, MZWJRAYYFSV> NTIHLMMONMC(UMVKRBFKGWI a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x87DA410", Offset = "0x87D8E10", VA = "0x1887DA410", Slot = "4")]
		public virtual void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class UMVKRBFKGWI : RJDJOSOWNDL
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class ZVHFLELJGRV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public UMVKRBFKGWI NEXPSVAOOPT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader ZWSITWJTQSM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<ZUFXHFCXCIO> EQAHRUTEVEQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<CWCKCFASOBI> EQFOPBNCEPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<WNHMBYUWLBQ> EQKVMIGZOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<FDLXEYELZJU> EQQCJPAWXMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<DNUOVHETSIL> EPFGCTRPJLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<LTEBGRWBKUR> EPKNAALMSWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<OLJOBCTZNER> EPPTXHFKCHY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<LRYEZTADGEZ> EPVAUNZHLTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<RHNNOHYQJTP> ERQKVWWJSRK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> ERVRTDQHCCT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<DUBBBZCYNWU> FQNLYFEHVMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<DQODYHYBBWM> FQIFAYKKMBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<JWOCSZJSECD> FQCYDRQNCPR;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public ZVHFLELJGRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x87E4040", Offset = "0x87E2A40", VA = "0x1887E4040")]
			internal ZUFXHFCXCIO SMZLQEGCTFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x87E4050", Offset = "0x87E2A50", VA = "0x1887E4050")]
			internal CWCKCFASOBI SNESNLAACQT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x87E4060", Offset = "0x87E2A60", VA = "0x1887E4060")]
			internal WNHMBYUWLBQ SNJZKRTXMCC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x87E4070", Offset = "0x87E2A70", VA = "0x1887E4070")]
			internal FDLXEYELZJU SNPGHYNUVNL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x87E4080", Offset = "0x87E2A80", VA = "0x1887E4080")]
			internal DNUOVHETSIL SNUNFFHSEYU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x87E4090", Offset = "0x87E2A90", VA = "0x1887E4090")]
			internal LTEBGRWBKUR SNZUCMBPOKD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x87E40A0", Offset = "0x87E2AA0", VA = "0x1887E40A0")]
			internal OLJOBCTZNER SOFAZSVMXVM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x87E40B0", Offset = "0x87E2AB0", VA = "0x1887E40B0")]
			internal LRYEZTADGEZ SOKHWZPKHGV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x87E4020", Offset = "0x87E2A20", VA = "0x1887E4020")]
			internal RHNNOHYQJTP SLJIMCCXVSQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x87E4030", Offset = "0x87E2A30", VA = "0x1887E4030")]
			internal Sampler SLOPJIWVFDZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x87E3EA0", Offset = "0x87E28A0", VA = "0x1887E3EA0")]
			internal DUBBBZCYNWU MPGLXHYDATL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x87E3E90", Offset = "0x87E2890", VA = "0x1887E3E90")]
			internal DQODYHYBBWM MPBFABEFRIC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x87E3E80", Offset = "0x87E2880", VA = "0x1887E3E80")]
			internal JWOCSZJSECD MOVYCUKIHWT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> VYXODRWXFYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> VAHYSQUSZSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<ZUFXHFCXCIO> EDZJTUABWSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<CWCKCFASOBI> OSEJLEBCABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public OWMJOBRTNFJ OWMJOBRTNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<WNHMBYUWLBQ> QIVPSBWTHYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<FDLXEYELZJU> QXKNZWGTLDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<DNUOVHETSIL> CEZGYHYBWID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<LTEBGRWBKUR> USCXGOGRPLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<OLJOBCTZNER> ULAOQRGAYCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<LRYEZTADGEZ> GCEFWCTGQTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<RHNNOHYQJTP> LSCINOQGUPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> GTUEKTFCWMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public XTVXQQJFRUG LMFIXBRONLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<DUBBBZCYNWU> AHHRAOGRTRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<DQODYHYBBWM> RZKKTIVKTZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<JWOCSZJSECD> BAVNQBXGXAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<LLCVOVJISQY> HYIVBEWGLGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool JXROJANDURO;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x87DFDA0", Offset = "0x87DE7A0", VA = "0x1887DFDA0")]
		public UMVKRBFKGWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x87DE150", Offset = "0x87DCB50", VA = "0x1887DE150")]
		public DUBBBZCYNWU IIYUPODZFQY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x87DD300", Offset = "0x87DBD00", VA = "0x1887DD300")]
		public static UMVKRBFKGWI Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x87DE1F0", Offset = "0x87DCBF0", VA = "0x1887DE1F0")]
		public void NYKTBLQYXAJ(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class DUBBBZCYNWU : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<OGNAAAHQAIU> LSCINOQGUPQ;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x87CF780", Offset = "0x87CE180", VA = "0x1887CF780")]
		public DUBBBZCYNWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x87CFEF0", Offset = "0x87CE8F0", VA = "0x1887CFEF0")]
		public static DUBBBZCYNWU Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x87D0070", Offset = "0x87CEA70", VA = "0x1887D0070", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class JWOCSZJSECD : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public XTAQTHAXXES ZLTHMRIGXHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public ITQGRFRGWXV ZXBYZQEQXGM;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x87CF780", Offset = "0x87CE180", VA = "0x1887CF780")]
		public JWOCSZJSECD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x87D2670", Offset = "0x87D1070", VA = "0x1887D2670")]
		public static JWOCSZJSECD Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x87D2840", Offset = "0x87D1240", VA = "0x1887D2840", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class MYAFUAKAEEE : LLCVOVJISQY
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x87CF780", Offset = "0x87CE180", VA = "0x1887CF780")]
		public MYAFUAKAEEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x87D1980", Offset = "0x87D0380", VA = "0x1887D1980", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class LLCVOVJISQY : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string TRYGGLEORZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color BVALNGPHNSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string XIFUWJIDDEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float SGYUEHCMMXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float MMUBLVRRLZY;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x87CF780", Offset = "0x87CE180", VA = "0x1887CF780")]
		public LLCVOVJISQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x87D2E70", Offset = "0x87D1870", VA = "0x1887D2E70", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class GWMNVMRIEKC : LLCVOVJISQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x87CF780", Offset = "0x87CE180", VA = "0x1887CF780")]
		public GWMNVMRIEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x87D1980", Offset = "0x87D0380", VA = "0x1887D1980", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class CCIDKNCSIZO : LLCVOVJISQY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float NRZZKYLRUKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float PODXUEVQRGS;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x87CEB40", Offset = "0x87CD540", VA = "0x1887CEB40")]
		public CCIDKNCSIZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x87CE840", Offset = "0x87CD240", VA = "0x1887CE840", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface YJLQWYGDLZJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LZFZMDVGXJS(UMVKRBFKGWI a, AGLIMOKANFX b, [Out] EFASQHYZTFI c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface MZWJRAYYFSV
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MZWJRAYYFSV Clone(UMVKRBFKGWI root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class HVJDTAFBXHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string VCUREUFBLWF;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected HVJDTAFBXHO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class PDVPETXTNTR : MZWJRAYYFSV
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty UVGMPTSWVOW
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x87D75A0", Offset = "0x87D5FA0", VA = "0x1887D75A0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public PDVPETXTNTR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class GRDTHWCPLJJ : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x87D1910", Offset = "0x87D0310", VA = "0x1887D1910", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GRDTHWCPLJJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class FSFYUPLVYKJ : RJDJOSOWNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color TVTGDDKBNLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public NFXGIFNZSUM TTRWRYVIEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color HBTJRMXBNEI;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x87D1870", Offset = "0x87D0270", VA = "0x1887D1870")]
		public FSFYUPLVYKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x87D1370", Offset = "0x87CFD70", VA = "0x1887D1370")]
		public static FSFYUPLVYKJ Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x87D1610", Offset = "0x87D0010", VA = "0x1887D1610", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class YLKXUMQBYYZ : NFXGIFNZSUM
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string ZKOSMMJBFYR = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double XGEMPETLZEZ;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x87D2E10", Offset = "0x87D1810", VA = "0x1887D2E10")]
		public YLKXUMQBYYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x87E12E0", Offset = "0x87DFCE0", VA = "0x1887E12E0")]
		public new static YLKXUMQBYYZ Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x87E15D0", Offset = "0x87DFFD0", VA = "0x1887E15D0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class LIDHDXTADIF : NFXGIFNZSUM
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string YHZCVXXNRTS = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double OBJJAVPDVGE;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x87D2E10", Offset = "0x87D1810", VA = "0x1887D2E10")]
		public LIDHDXTADIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x87D2A60", Offset = "0x87D1460", VA = "0x1887D2A60")]
		public new static LIDHDXTADIF Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x87D2D50", Offset = "0x87D1750", VA = "0x1887D2D50", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class QGANMIYRXEM : RJDJOSOWNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color QBEJIKKBEZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public NFXGIFNZSUM NAEGMGNQUIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double EJNHAASUVQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double UPFYPXGHVXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public NFXGIFNZSUM RYCOEWODPLX;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x87D8030", Offset = "0x87D6A30", VA = "0x1887D8030")]
		public QGANMIYRXEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x87D7A30", Offset = "0x87D6430", VA = "0x1887D7A30")]
		public static QGANMIYRXEM Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x87D7DA0", Offset = "0x87D67A0", VA = "0x1887D7DA0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class YMAKEZFFZYF : RJDJOSOWNDL
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class XCEEGWYISVS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader SQQDARQWJCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public UMVKRBFKGWI NEXPSVAOOPT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<HYHNESAJCVR> EQAHRUTEVEQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<HYHNESAJCVR> EQKVMIGZOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, HYHNESAJCVR>> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public XCEEGWYISVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x87E0A30", Offset = "0x87DF430", VA = "0x1887E0A30")]
			internal HYHNESAJCVR SMZLQEGCTFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x87E0B00", Offset = "0x87DF500", VA = "0x1887E0B00")]
			internal Dictionary<string, HYHNESAJCVR> SNESNLAACQT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x87E0BB0", Offset = "0x87DF5B0", VA = "0x1887E0BB0")]
			internal HYHNESAJCVR SNJZKRTXMCC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, HYHNESAJCVR> YWQIRSMCIFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public HYHNESAJCVR VHWAFBZSPMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public XJVVNMRVGLL KOSKITVPIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode FZKHSZNZYHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, HYHNESAJCVR>> DITMLTUQTZX;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x87E2990", Offset = "0x87E1390", VA = "0x1887E2990")]
		public YMAKEZFFZYF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x87E2A30", Offset = "0x87E1430", VA = "0x1887E2A30")]
		public YMAKEZFFZYF(YMAKEZFFZYF a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x87E1690", Offset = "0x87E0090", VA = "0x1887E1690")]
		public static int[] DQFKTCGYHGH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x87E2830", Offset = "0x87E1230", VA = "0x1887E2830")]
		public static int[] YVAOPKCYBGJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x87E2600", Offset = "0x87E1000", VA = "0x1887E2600")]
		public static int[] SDXCXQCNGZB(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x87E23B0", Offset = "0x87E0DB0", VA = "0x1887E23B0")]
		public static int[] OPUFLILESWN(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x87E1B80", Offset = "0x87E0580", VA = "0x1887E1B80")]
		public static int[] HZSMRLUFFTC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x87E27C0", Offset = "0x87E11C0", VA = "0x1887E27C0")]
		public static int[] WLUXCDHEISN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x87E1CA0", Offset = "0x87E06A0", VA = "0x1887E1CA0")]
		public static int[] JXOFJIWLMGJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x87E1C30", Offset = "0x87E0630", VA = "0x1887E1C30")]
		public static int[] IIEOBKTMZDA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x87E1D30", Offset = "0x87E0730", VA = "0x1887E1D30")]
		public static int[] MLCRPSVKCBQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x87E1730", Offset = "0x87E0130", VA = "0x1887E1730")]
		public static YMAKEZFFZYF Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x87E1DC0", Offset = "0x87E07C0", VA = "0x1887E1DC0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class ZNAGIMKHJLS
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] ASHGFSSZJIT;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] RSXWRZLXIIE;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] IWSGVXAIMMF;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] NLQTXYWNCDN;
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum DrawMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Points,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Lines,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		LineLoop,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		LineStrip,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Triangles,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		TriangleStrip,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		TriangleFan
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class RHNNOHYQJTP : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool ZUIIAGPUZEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public EIKNAPQOSTZ YBFAAJZNFWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<OGNAAAHQAIU> EHFJOPVXKEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public TRYUEOTRPLH DQODYHYBBWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public DSEFIPJTYMI NNXABRBHZLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public RLTDEIJDSHH WSNDFSGATGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion UPRTWCVGHDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 XGEMPETLZEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 QIDHBSBPDLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> VCMQIWBZQDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public KHGXDQYXEAG GWLJURJJBRN;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x87D9B40", Offset = "0x87D8540", VA = "0x1887D9B40")]
		public RHNNOHYQJTP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x87D8600", Offset = "0x87D7000", VA = "0x1887D8600")]
		public static RHNNOHYQJTP Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x87D8F40", Offset = "0x87D7940", VA = "0x1887D8F40", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode QFZYDUAILMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode IFQXGZEUCZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode LEVXFVFIVUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode LFLRXPNAYCL;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x87DCC00", Offset = "0x87DB600", VA = "0x1887DCC00")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x87DC740", Offset = "0x87DB140", VA = "0x1887DC740")]
		public static Sampler Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x87DCA10", Offset = "0x87DB410", VA = "0x1887DCA10", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public enum MagFilterMode
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		Nearest = 9728,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		Linear = 9729
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public enum MinFilterMode
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Nearest = 9728,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Linear = 9729,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		NearestMipmapNearest = 9984,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		LinearMipmapNearest = 9985,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		NearestMipmapLinear = 9986,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		LinearMipmapLinear = 9987
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public enum WrapMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		ClampToEdge = 33071,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		MirroredRepeat = 33648,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Repeat = 10497
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public class DQODYHYBBWM : NMRTCVGFESK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public HYHNESAJCVR MSMUEVVHMUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public OGNAAAHQAIU PEPEMUXLKTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<OGNAAAHQAIU> CICKAZTHSQY;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x87CFE40", Offset = "0x87CE840", VA = "0x1887CFE40")]
		public DQODYHYBBWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x87CF7D0", Offset = "0x87CE1D0", VA = "0x1887CF7D0")]
		public static DQODYHYBBWM Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x87CFB30", Offset = "0x87CE530", VA = "0x1887CFB30", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class NFXGIFNZSUM : RJDJOSOWNDL
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string LMUGPYWQPRZ = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string SZXKYTVWJWP = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public HUZHYQGYCEF QJMYPCWEAKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int ASHGFSSZJIT;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x87D4310", Offset = "0x87D2D10", VA = "0x1887D4310")]
		public NFXGIFNZSUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x87D4220", Offset = "0x87D2C20", VA = "0x1887D4220")]
		public NFXGIFNZSUM(NFXGIFNZSUM a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x87D3E70", Offset = "0x87D2870", VA = "0x1887D3E70")]
		public static NFXGIFNZSUM Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x87D40F0", Offset = "0x87D2AF0", VA = "0x1887D40F0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x87D4150", Offset = "0x87D2B50", VA = "0x1887D4150")]
		public void RJJTWYGGBLK(JsonWriter a)
		{
		}
	}
}
namespace GLTF.Schema.KHR_lights_punctual
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public enum LightType
	{
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		directional,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		point,
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		spot
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public class AFBRFWNGWKV
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double FFSNAPNTEPT;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double FTDVLNALXGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double ZXWKDBHVHTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double XGGISLAHSRI;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x87CE640", Offset = "0x87CD040", VA = "0x1887CE640")]
		public AFBRFWNGWKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x87CE180", Offset = "0x87CCB80", VA = "0x1887CE180")]
		public static AFBRFWNGWKV Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x87CE3D0", Offset = "0x87CCDD0", VA = "0x1887CE3D0")]
		public void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class ZKUUYVHDUWN : NMRTCVGFESK
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color JWBKYBMHMQC;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double OLOHMFOEYGQ;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double ZSXWEFYFXMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType YFKMMNNXMAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color RSXWRZLXIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double LIQXLNTBKVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double ZNQZOHNBTGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public AFBRFWNGWKV AFBRFWNGWKV;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x87E3AF0", Offset = "0x87E24F0", VA = "0x1887E3AF0")]
		public ZKUUYVHDUWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x87E39C0", Offset = "0x87E23C0", VA = "0x1887E39C0")]
		public ZKUUYVHDUWN(ZKUUYVHDUWN a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x87E30D0", Offset = "0x87E1AD0", VA = "0x1887E30D0")]
		public static ZKUUYVHDUWN Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x87E34C0", Offset = "0x87E1EC0", VA = "0x1887E34C0")]
		public static ZKUUYVHDUWN Deserialize(UMVKRBFKGWI root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x87E35E0", Offset = "0x87E1FE0", VA = "0x1887E35E0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class WPFMIKDYMUX : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<LLCVOVJISQY> LNTZWLXAXXO;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public WPFMIKDYMUX(IList<LLCVOVJISQY> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x87E0180", Offset = "0x87DEB80", VA = "0x1887E0180", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x87E0110", Offset = "0x87DEB10", VA = "0x1887E0110", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class OWSBWRCYKBR : MZWJRAYYFSV, YJLQWYGDLZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<ZKUUYVHDUWN> HYIVBEWGLGY;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x87D7520", Offset = "0x87D5F20", VA = "0x1887D7520")]
		public OWSBWRCYKBR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x87D6660", Offset = "0x87D5060", VA = "0x1887D6660", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x87D7180", Offset = "0x87D5B80", VA = "0x1887D7180", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x87D7270", Offset = "0x87D5C70", VA = "0x1887D7270")]
		private static string[] ZFJMAHFOEVR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x87D6CE0", Offset = "0x87D56E0", VA = "0x1887D6CE0")]
		private static EFASQHYZTFI.ImportValuesConversion QTZNLZJVKZR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x87D68F0", Offset = "0x87D52F0", VA = "0x1887D68F0", Slot = "6")]
		public bool LZFZMDVGXJS(UMVKRBFKGWI a, AGLIMOKANFX b, [Out] EFASQHYZTFI c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class NUXKFEEDQBC : KWEDGYYLVVY<ZKUUYVHDUWN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override ZKUUYVHDUWN Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x87D4BB0", Offset = "0x87D35B0", VA = "0x1887D4BB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x87D4B70", Offset = "0x87D3570", VA = "0x1887D4B70")]
		public NUXKFEEDQBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x87D4A90", Offset = "0x87D3490", VA = "0x1887D4A90")]
		public static NUXKFEEDQBC Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class RVKWKAXNCFF : MZWJRAYYFSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public NUXKFEEDQBC KHGXDQYXEAG;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public RVKWKAXNCFF(NUXKFEEDQBC a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x87DC230", Offset = "0x87DAC30", VA = "0x1887DC230")]
		public RVKWKAXNCFF(int a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x87DC0B0", Offset = "0x87DAAB0", VA = "0x1887DC0B0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x87DC130", Offset = "0x87DAB30", VA = "0x1887DC130", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class NOPPHQSQLUS : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x87D4A40", Offset = "0x87D3440", VA = "0x1887D4A40")]
		public NOPPHQSQLUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x87D4560", Offset = "0x87D2F60", VA = "0x1887D4560", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
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
