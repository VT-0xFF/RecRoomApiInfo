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
		[Cpp2IlInjected.Address(RVA = "0x8639240", Offset = "0x8638040", VA = "0x188639240", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8639190", Offset = "0x8637F90", VA = "0x188639190", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
			[Cpp2IlInjected.Address(RVA = "0x8648150", Offset = "0x8646F50", VA = "0x188648150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8646570", Offset = "0x8645370", VA = "0x188646570")]
		public static void QAWCZQRNIVA(this RHNNOHYQJTP a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8644BA0", Offset = "0x86439A0", VA = "0x188644BA0")]
		public static void BUYRZNSESMI(this RHNNOHYQJTP a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8645FD0", Offset = "0x8644DD0", VA = "0x188645FD0")]
		public static void PVKUEHOPJTN(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86456A0", Offset = "0x86444A0", VA = "0x1886456A0")]
		public static GLTF.Math.Vector4 JVVBXJDCBEV(this DSEFIPJTYMI a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8645C90", Offset = "0x8644A90", VA = "0x188645C90")]
		public static UnityEngine.Quaternion ODVQIMVTKWM(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8645E20", Offset = "0x8644C20", VA = "0x188645E20")]
		public static UnityEngine.Quaternion ODVQIMVTKWM(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8645AD0", Offset = "0x86448D0", VA = "0x188645AD0")]
		public static GLTF.Math.Quaternion LWFTBUWALEQ(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86474C0", Offset = "0x86462C0", VA = "0x1886474C0")]
		public static Matrix4x4 UVUZTSAPIUT(this DSEFIPJTYMI a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8647080", Offset = "0x8645E80", VA = "0x188647080")]
		public static Matrix4x4 UVUZTSAPIUT(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8647DA0", Offset = "0x8646BA0", VA = "0x188647DA0")]
		public static DSEFIPJTYMI WYVRWNYRMJV(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x86450A0", Offset = "0x8643EA0", VA = "0x1886450A0")]
		public static UnityEngine.Vector3 DXJMIICSUWK(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86451C0", Offset = "0x8643FC0", VA = "0x1886451C0")]
		public static UnityEngine.Vector3 DXJMIICSUWK(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8645480", Offset = "0x8644280", VA = "0x188645480")]
		public static GLTF.Math.Vector3 EIWXTOSAFRM(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8646B40", Offset = "0x8645940", VA = "0x188646B40")]
		public static GLTF.Math.Vector3 QZZLRALFJQT(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1353C10", Offset = "0x1352A10", VA = "0x181353C10")]
		public static GLTF.Math.Vector4 GXIRREFUWBO(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x86476E0", Offset = "0x86464E0", VA = "0x1886476E0")]
		public static Matrix4x4 VFVHHSALGRQ(this DSEFIPJTYMI a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86479A0", Offset = "0x86467A0", VA = "0x1886479A0")]
		public static Matrix4x4 VFVHHSALGRQ(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8646C00", Offset = "0x8645A00", VA = "0x188646C00")]
		public static DSEFIPJTYMI SBGPRKRTTRA(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86455B0", Offset = "0x86443B0", VA = "0x1886455B0")]
		public static UnityEngine.Vector2 EZOUGLTYARU(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86455B0", Offset = "0x86443B0", VA = "0x1886455B0")]
		public static UnityEngine.Vector2 EZOUGLTYARU(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86455D0", Offset = "0x86443D0", VA = "0x1886455D0")]
		public static void EZOUGLTYARU(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8644A50", Offset = "0x8643850", VA = "0x188644A50")]
		public static UnityEngine.Vector3 BTFLCMOTBJF(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D76080", Offset = "0x1D74E80", VA = "0x181D76080")]
		public static UnityEngine.Vector3 BTFLCMOTBJF(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8644AB0", Offset = "0x86438B0", VA = "0x188644AB0")]
		public static void BTFLCMOTBJF(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1353C10", Offset = "0x1352A10", VA = "0x181353C10")]
		public static UnityEngine.Vector4 KAGVEOTBYCY(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1353C10", Offset = "0x1352A10", VA = "0x181353C10")]
		public static UnityEngine.Vector4 KAGVEOTBYCY(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86459D0", Offset = "0x86447D0", VA = "0x1886459D0")]
		public static UnityEngine.Vector4[] KAGVEOTBYCY(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86458C0", Offset = "0x86446C0", VA = "0x1886458C0")]
		public static void KAGVEOTBYCY(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86453E0", Offset = "0x86441E0", VA = "0x1886453E0")]
		public static UnityEngine.Color EIFHATIXNZA(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86452A0", Offset = "0x86440A0", VA = "0x1886452A0")]
		public static void EIFHATIXNZA(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86453E0", Offset = "0x86441E0", VA = "0x1886453E0")]
		public static UnityEngine.Color EIFHATIXNZA(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1353C10", Offset = "0x1352A10", VA = "0x181353C10")]
		public static UnityEngine.Color TXGIXWWCMER(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8646F70", Offset = "0x8645D70", VA = "0x188646F70")]
		public static void TXGIXWWCMER(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1353C10", Offset = "0x1352A10", VA = "0x181353C10")]
		public static UnityEngine.Color TXGIXWWCMER(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8646B10", Offset = "0x8645910", VA = "0x188646B10")]
		public static GLTF.Math.Color QDHBIQKFMZF(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8645F50", Offset = "0x8644D50", VA = "0x188645F50")]
		public static GLTF.Math.Color PQERCZVUDFM(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8646B80", Offset = "0x8645980", VA = "0x188646B80")]
		public static GLTF.Math.Color RTORBCAQMZC(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8646450", Offset = "0x8645250", VA = "0x188646450")]
		public static UnityEngine.Color[] QAEGBSFBGZH(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8645C10", Offset = "0x8644A10", VA = "0x188645C10")]
		public static int[] MGLOBQHXJCM(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86463A0", Offset = "0x86451A0", VA = "0x1886463A0")]
		public static UnityEngine.Vector2[] PXBFCKPUSYL(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86448F0", Offset = "0x86436F0", VA = "0x1886448F0")]
		public static void AEDPOSHNMCM(WSEPZXFZGWU a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8647C10", Offset = "0x8646A10", VA = "0x188647C10")]
		public static UnityEngine.Vector3[] VYWOLUFPDCA(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8646DD0", Offset = "0x8645BD0", VA = "0x188646DD0")]
		public static UnityEngine.Vector4[] THLVZHKDOOJ(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x86480E0", Offset = "0x8646EE0", VA = "0x1886480E0")]
		public static void ZLWPTWNDYUY(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8647D70", Offset = "0x8646B70", VA = "0x188647D70")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray ZGDFAKQJVML
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x86482A0", Offset = "0x86470A0", VA = "0x1886482A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> HOOXGCCJGLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xEDC830", Offset = "0xEDB630", VA = "0x180EDC830")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xF975B0", Offset = "0xF963B0", VA = "0x180F975B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint VFZFKOJRRKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCF16B0", Offset = "0xCF04B0", VA = "0x180CF16B0")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCF1010", Offset = "0xCEFE10", VA = "0x180CF1010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x86482B0", Offset = "0x86470B0", VA = "0x1886482B0")]
		public WSEPZXFZGWU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8636DD0", Offset = "0x8635BD0", VA = "0x188636DD0")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8636E30", Offset = "0x8635C30", VA = "0x188636E30")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public LSWILDBCNNY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x863F590", Offset = "0x863E390", VA = "0x18863F590")]
			internal int? GVRSTRROTUZ(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x863F610", Offset = "0x863E410", VA = "0x18863F610")]
			internal int? OFJGHFIQVYM(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x863F6A0", Offset = "0x863E4A0", VA = "0x18863F6A0")]
			internal bool UVUZHMTERPC(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x863EED0", Offset = "0x863DCD0", VA = "0x18863EED0")]
		private static void XITALHHZCQW(NumericArray a, WSEPZXFZGWU b, WSEPZXFZGWU c, WSEPZXFZGWU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x863C9F0", Offset = "0x863B7F0", VA = "0x18863C9F0")]
		public static void CDYLAUDKGZN(Dictionary<string, WSEPZXFZGWU> a, Dictionary<string, (WSEPZXFZGWU sparseIndices, WSEPZXFZGWU sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x863DEC0", Offset = "0x863CCC0", VA = "0x18863DEC0")]
		public static void HNTOGZKHAWL(Dictionary<string, WSEPZXFZGWU> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x863EDD0", Offset = "0x863DBD0", VA = "0x18863EDD0")]
		public static void RKBPHPNBSDO(WSEPZXFZGWU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x863E3A0", Offset = "0x863D1A0", VA = "0x18863E3A0")]
		public static void LGGFOZVDHDY(Dictionary<string, List<WSEPZXFZGWU>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x863DCD0", Offset = "0x863CAD0", VA = "0x18863DCD0")]
		private static void HINFKGOVCHY(WSEPZXFZGWU a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x863DE00", Offset = "0x863CC00", VA = "0x18863DE00")]
		internal static void HINFKGOVCHY(FDLXEYELZJU a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x863E930", Offset = "0x863D730", VA = "0x18863E930")]
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
			[Cpp2IlInjected.Address(RVA = "0xF430D0", Offset = "0xF41ED0", VA = "0x180F430D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30B62E0", Offset = "0x30B50E0", VA = "0x1830B62E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30B62F0", Offset = "0x30B50F0", VA = "0x1830B62F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86498B0", Offset = "0x86486B0", VA = "0x1886498B0")]
		public static void KRNGIGMEGEC(Stream a, [Out] UMVKRBFKGWI b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8649560", Offset = "0x8648360", VA = "0x188649560")]
		public static ChunkInfo HPQITAPWKUW(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x86492B0", Offset = "0x86480B0", VA = "0x1886492B0")]
		public static GLBHeader DKJXHRBGOSO(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x86497F0", Offset = "0x86485F0", VA = "0x1886497F0")]
		public static bool JXROJANDURO(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x86493F0", Offset = "0x86481F0", VA = "0x1886493F0")]
		public static ChunkInfo DRMWGOUGNAZ(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8649A70", Offset = "0x8648870", VA = "0x188649A70")]
		private static void RILHYIOXBNZ(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8649D10", Offset = "0x8648B10", VA = "0x188649D10")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE5110", Offset = "0xCE3F10", VA = "0x180CE5110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCE8F30", Offset = "0xCE7D30", VA = "0x180CE8F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int ALPNKJZOFUT
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xDDD300", Offset = "0xDDC100", VA = "0x180DDD300")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xDDD310", Offset = "0xDDC110", VA = "0x180DDD310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string XEDOBOJWUDC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool XBKYTWSPUZD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCE7950", Offset = "0xCE6750", VA = "0x180CE7950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCE8250", Offset = "0xCE7050", VA = "0x180CE8250")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AGLIMOKANFX XFCZVAFDHXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCE7530", Offset = "0xCE6330", VA = "0x180CE7530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8633230", Offset = "0x8632030", VA = "0x188633230")]
		public string VLFRWGBXJVD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8633030", Offset = "0x8631E30", VA = "0x188633030")]
		public AGLIMOKANFX GDHNDNFOQET(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x86334A0", Offset = "0x86322A0", VA = "0x1886334A0")]
		private AGLIMOKANFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x86332F0", Offset = "0x86320F0", VA = "0x1886332F0")]
		public AGLIMOKANFX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x53037D0", Offset = "0x53025D0", VA = "0x1853037D0")]
		[CompilerGenerated]
		internal static string DGZJKIPFFON(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x86332B0", Offset = "0x86320B0", VA = "0x1886332B0")]
		[CompilerGenerated]
		internal static bool WYIIKFXPFKE([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8633050", Offset = "0x8631E50", VA = "0x188633050")]
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
		[Cpp2IlInjected.Address(RVA = "0x8641900", Offset = "0x8640700", VA = "0x188641900")]
		public static int[] MEPPIVQXQVO(this UMVKRBFKGWI a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x86417B0", Offset = "0x86405B0", VA = "0x1886417B0")]
		public static int[] CXBLYBIEDIC(this UMVKRBFKGWI a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class VLDWBDSEUQC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8642C50", Offset = "0x8641A50", VA = "0x188642C50")]
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
			[Cpp2IlInjected.Address(RVA = "0x8642300", Offset = "0x8641100", VA = "0x188642300", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8642340", Offset = "0x8641140", VA = "0x188642340", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8642340", Offset = "0x8641140", VA = "0x188642340", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8642360", Offset = "0x8641160", VA = "0x188642360", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8642380", Offset = "0x8641180", VA = "0x188642380", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x86423A0", Offset = "0x86411A0", VA = "0x1886423A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8642090", Offset = "0x8640E90", VA = "0x188642090")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8641E50", Offset = "0x8640C50", VA = "0x188641E50", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8641FB0", Offset = "0x8640DB0", VA = "0x188641FB0", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8642010", Offset = "0x8640E10", VA = "0x188642010", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8641F20", Offset = "0x8640D20", VA = "0x188641F20", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8642050", Offset = "0x8640E50", VA = "0x188642050", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8641E90", Offset = "0x8640C90", VA = "0x188641E90")]
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
			[Cpp2IlInjected.Address(RVA = "0x8634110", Offset = "0x8632F10", VA = "0x188634110")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color EXVQGZOFYLI
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8634030", Offset = "0x8632E30", VA = "0x188634030")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color NZATEIPGBIW
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x86340F0", Offset = "0x8632EF0", VA = "0x1886340F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2DCE250", Offset = "0x2DCD050", VA = "0x182DCE250")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1853DE0", Offset = "0x1852BE0", VA = "0x181853DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2E28D10", Offset = "0x2E27B10", VA = "0x182E28D10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2E28D20", Offset = "0x2E27B20", VA = "0x182E28D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BA1160", Offset = "0x2B9FF60", VA = "0x182BA1160")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x32B0D40", Offset = "0x32AFB40", VA = "0x1832B0D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x150DA60", Offset = "0x150C860", VA = "0x18150DA60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x150DA70", Offset = "0x150C870", VA = "0x18150DA70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B63170", Offset = "0x2B61F70", VA = "0x182B63170")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8633EE0", Offset = "0x8632CE0", VA = "0x188633EE0", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8633F90", Offset = "0x8632D90", VA = "0x188633F90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8634040", Offset = "0x8632E40", VA = "0x188634040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8633E30", Offset = "0x8632C30", VA = "0x188633E30")]
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
			[Cpp2IlInjected.Address(RVA = "0x8635850", Offset = "0x8634650", VA = "0x188635850")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8635E20", Offset = "0x8634C20", VA = "0x188635E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float NQTJKEARVKB
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8636060", Offset = "0x8634E60", VA = "0x188636060")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8635910", Offset = "0x8634710", VA = "0x188635910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float URAAOIUZSFS
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8635E80", Offset = "0x8634C80", VA = "0x188635E80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x86360F0", Offset = "0x8634EF0", VA = "0x1886360F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float YTEQVOPWGZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8635D30", Offset = "0x8634B30", VA = "0x188635D30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8635F40", Offset = "0x8634D40", VA = "0x188635F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float GPMJTRKXDJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x86357F0", Offset = "0x86345F0", VA = "0x1886357F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8635DC0", Offset = "0x8634BC0", VA = "0x188635DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float NQDOSJSZTCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8636030", Offset = "0x8634E30", VA = "0x188636030")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x86358E0", Offset = "0x86346E0", VA = "0x1886358E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float URPVGDCRUNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8635EB0", Offset = "0x8634CB0", VA = "0x188635EB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8636120", Offset = "0x8634F20", VA = "0x188636120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float YTJXSVJTQKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8635D90", Offset = "0x8634B90", VA = "0x188635D90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8635FA0", Offset = "0x8634DA0", VA = "0x188635FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GPHCWKQZTYI
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8635820", Offset = "0x8634620", VA = "0x188635820")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8635DF0", Offset = "0x8634BF0", VA = "0x188635DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float NQIVPQMXCNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8636000", Offset = "0x8634E00", VA = "0x188636000")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x86358B0", Offset = "0x86346B0", VA = "0x1886358B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float URKOIWIULCK
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8635EE0", Offset = "0x8634CE0", VA = "0x188635EE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8636150", Offset = "0x8634F50", VA = "0x188636150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float YTPEQCDQZWB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8635D60", Offset = "0x8634B60", VA = "0x188635D60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8635F70", Offset = "0x8634D70", VA = "0x188635F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GPBVZDXCKMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x86357C0", Offset = "0x86345C0", VA = "0x1886357C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8635E50", Offset = "0x8634C50", VA = "0x188635E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float NRJEBYIJXSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8636090", Offset = "0x8634E90", VA = "0x188636090")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8635880", Offset = "0x8634680", VA = "0x188635880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float UQKFWONHPXR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8635F10", Offset = "0x8634D10", VA = "0x188635F10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x86360C0", Offset = "0x8634EC0", VA = "0x1886360C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float YTULNIXOJHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8635D00", Offset = "0x8634B00", VA = "0x188635D00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8635FD0", Offset = "0x8634DD0", VA = "0x188635FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8636260", Offset = "0x8635060", VA = "0x188636260")]
		public DSEFIPJTYMI(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8635940", Offset = "0x8634740", VA = "0x188635940", Slot = "4")]
		public bool Equals(DSEFIPJTYMI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8635C00", Offset = "0x8634A00", VA = "0x188635C00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x10C1930", Offset = "0x10C0730", VA = "0x1810C1930", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DCE250", Offset = "0x2DCD050", VA = "0x182DCE250")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x1853DE0", Offset = "0x1852BE0", VA = "0x181853DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2E28D10", Offset = "0x2E27B10", VA = "0x182E28D10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2E28D20", Offset = "0x2E27B20", VA = "0x182E28D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2BA1160", Offset = "0x2B9FF60", VA = "0x182BA1160")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32B0D40", Offset = "0x32AFB40", VA = "0x1832B0D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x150DA60", Offset = "0x150C860", VA = "0x18150DA60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x150DA70", Offset = "0x150C870", VA = "0x18150DA70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8641110", Offset = "0x863FF10", VA = "0x188641110")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8640DE0", Offset = "0x863FBE0", VA = "0x188640DE0", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8640F00", Offset = "0x863FD00", VA = "0x188640F00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8640FB0", Offset = "0x863FDB0", VA = "0x188640FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8640D70", Offset = "0x863FB70", VA = "0x188640D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DCE250", Offset = "0x2DCD050", VA = "0x182DCE250")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1853DE0", Offset = "0x1852BE0", VA = "0x181853DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2E28D10", Offset = "0x2E27B10", VA = "0x182E28D10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2E28D20", Offset = "0x2E27B20", VA = "0x182E28D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1030660", Offset = "0x102F460", VA = "0x181030660")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8644410", Offset = "0x8643210", VA = "0x188644410")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8644280", Offset = "0x8643080", VA = "0x188644280", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x86442E0", Offset = "0x86430E0", VA = "0x1886442E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x86443C0", Offset = "0x86431C0", VA = "0x1886443C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8644220", Offset = "0x8643020", VA = "0x188644220")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DCE250", Offset = "0x2DCD050", VA = "0x182DCE250")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1853DE0", Offset = "0x1852BE0", VA = "0x181853DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2E28D10", Offset = "0x2E27B10", VA = "0x182E28D10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2E28D20", Offset = "0x2E27B20", VA = "0x182E28D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2BA1160", Offset = "0x2B9FF60", VA = "0x182BA1160")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32B0D40", Offset = "0x32AFB40", VA = "0x1832B0D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x86447D0", Offset = "0x86435D0", VA = "0x1886447D0")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x86444A0", Offset = "0x86432A0", VA = "0x1886444A0", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8644580", Offset = "0x8643380", VA = "0x188644580", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8644640", Offset = "0x8643440", VA = "0x188644640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8644430", Offset = "0x8643230", VA = "0x188644430")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DCE250", Offset = "0x2DCD050", VA = "0x182DCE250")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1853DE0", Offset = "0x1852BE0", VA = "0x181853DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E28D10", Offset = "0x2E27B10", VA = "0x182E28D10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2E28D20", Offset = "0x2E27B20", VA = "0x182E28D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2BA1160", Offset = "0x2B9FF60", VA = "0x182BA1160")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x32B0D40", Offset = "0x32AFB40", VA = "0x1832B0D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x150DA60", Offset = "0x150C860", VA = "0x18150DA60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x150DA70", Offset = "0x150C870", VA = "0x18150DA70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B63170", Offset = "0x2B61F70", VA = "0x182B63170")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8633EE0", Offset = "0x8632CE0", VA = "0x188633EE0", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8644850", Offset = "0x8643650", VA = "0x188644850", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8634040", Offset = "0x8632E40", VA = "0x188634040", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x8636E90", Offset = "0x8635C90", VA = "0x188636E90")]
		public static void BKTVREZGKOH(this JObject a, string b, NFXGIFNZSUM c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class VLDWBDSEUQC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8643950", Offset = "0x8642750", VA = "0x188643950")]
		public static List<string> QCUFJOAVLMQ(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8643790", Offset = "0x8642590", VA = "0x188643790")]
		public static List<double> OMIOQBCGGQU(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8643DE0", Offset = "0x8642BE0", VA = "0x188643DE0")]
		public static List<int> VYDJNUWFCML(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x40C1E70", Offset = "0x40C0C70", VA = "0x1840C1E70")]
		public static List<a> EYZPXMFHJON<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8642450", Offset = "0x8641250", VA = "0x188642450")]
		public static NFXGIFNZSUM ABKZGRLAWVF(this JToken a, UMVKRBFKGWI b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x86440E0", Offset = "0x8642EE0", VA = "0x1886440E0")]
		public static int WKHDAQZKVNH(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8643FA0", Offset = "0x8642DA0", VA = "0x188643FA0")]
		public static double WFZERZDEBEN(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8643B00", Offset = "0x8642900", VA = "0x188643B00")]
		public static GLTF.Math.Color RMSJCEXJZUW(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8643520", Offset = "0x8642320", VA = "0x188643520")]
		public static GLTF.Math.Color NSZZTGVXZMX(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x86429B0", Offset = "0x86417B0", VA = "0x1886429B0")]
		public static GLTF.Math.Color ESRVGKDLHAL(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x86426F0", Offset = "0x86414F0", VA = "0x1886426F0")]
		public static GLTF.Math.Vector3 CNCVVNYVKHR(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8643310", Offset = "0x8642110", VA = "0x188643310")]
		public static GLTF.Math.Vector2 IAHAKDSGJNN(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x86430B0", Offset = "0x8641EB0", VA = "0x1886430B0")]
		public static GLTF.Math.Vector3 IABTMWYJACE(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8642DA0", Offset = "0x8641BA0", VA = "0x188642DA0")]
		public static GLTF.Math.Quaternion GOWOAVWJNXX(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x40C2510", Offset = "0x40C1310", VA = "0x1840C2510")]
		public static Dictionary<string, b> WCYHUFYBAFX<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x40C21C0", Offset = "0x40C0FC0", VA = "0x1840C21C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8636840", Offset = "0x8635640", VA = "0x188636840", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x86367C0", Offset = "0x86355C0", VA = "0x1886367C0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class XDZJDBHLERL : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x86486D0", Offset = "0x86474D0", VA = "0x1886486D0")]
		public XDZJDBHLERL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8648600", Offset = "0x8647400", VA = "0x188648600", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8636680", Offset = "0x8635480", VA = "0x188636680", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8636740", Offset = "0x8635540", VA = "0x188636740")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8636A60", Offset = "0x8635860", VA = "0x188636A60")]
			internal HYHNESAJCVR SMZLQEGCTFK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8641D30", Offset = "0x8640B30", VA = "0x188641D30")]
		public SUGVMAETUAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8641BA0", Offset = "0x86409A0", VA = "0x188641BA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public EXT_texture_exr(ITQGRFRGWXV source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8636890", Offset = "0x8635690", VA = "0x188636890", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8636900", Offset = "0x8635700", VA = "0x188636900", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ECGSTXTDDIS : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8636630", Offset = "0x8635430", VA = "0x188636630")]
		public ECGSTXTDDIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8636510", Offset = "0x8635310", VA = "0x188636510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8633A20", Offset = "0x8632820", VA = "0x188633A20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x86339E0", Offset = "0x86327E0", VA = "0x1886339E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8633BB0", Offset = "0x86329B0", VA = "0x188633BB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8633B70", Offset = "0x8632970", VA = "0x188633B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x8633890", Offset = "0x8632690", VA = "0x188633890", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8633850", Offset = "0x8632650", VA = "0x188633850")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8633770", Offset = "0x8632570", VA = "0x188633770")]
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
		[Cpp2IlInjected.Address(RVA = "0x8638EB0", Offset = "0x8637CB0", VA = "0x188638EB0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8638AB0", Offset = "0x86378B0", VA = "0x188638AB0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8638B20", Offset = "0x8637920", VA = "0x188638B20")]
		public static KHR_SceneAudioEmittersRef Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8639110", Offset = "0x8637F10", VA = "0x188639110")]
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
			[Cpp2IlInjected.Address(RVA = "0x8638A80", Offset = "0x8637880", VA = "0x188638A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8638960", Offset = "0x8637760", VA = "0x188638960", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8638750", Offset = "0x8637550", VA = "0x188638750", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x86387C0", Offset = "0x86375C0", VA = "0x1886387C0")]
		public static KHR_NodeAudioEmitterRef Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
		[Cpp2IlInjected.Address(RVA = "0x863FFA0", Offset = "0x863EDA0", VA = "0x18863FFA0")]
		public JObject NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x863F8A0", Offset = "0x863E6A0", VA = "0x18863F8A0")]
		public static OIFNJZWSQUT Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8637DA0", Offset = "0x8636BA0", VA = "0x188637DA0", Slot = "5")]
		public virtual JObject NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x86378A0", Offset = "0x86366A0", VA = "0x1886378A0")]
		public static KHR_AudioEmitter Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8638140", Offset = "0x8636F40", VA = "0x188638140")]
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
		[Cpp2IlInjected.Address(RVA = "0x8638520", Offset = "0x8637320", VA = "0x188638520")]
		public JObject NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x86381C0", Offset = "0x8636FC0", VA = "0x1886381C0")]
		public static KHR_AudioSource Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8637890", Offset = "0x8636690", VA = "0x188637890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8637760", Offset = "0x8636560", VA = "0x188637760")]
		public JObject NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8637500", Offset = "0x8636300", VA = "0x188637500")]
		public static KHR_AudioData Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8637890", Offset = "0x8636690", VA = "0x188637890")]
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
		[Cpp2IlInjected.Address(RVA = "0x86393D0", Offset = "0x86381D0", VA = "0x1886393D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8639340", Offset = "0x8638140", VA = "0x188639340", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8639B00", Offset = "0x8638900", VA = "0x188639B00")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class DGMTCJGGHDU : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x86354A0", Offset = "0x86342A0", VA = "0x1886354A0")]
		public DGMTCJGGHDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8634900", Offset = "0x8633700", VA = "0x188634900", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8639CD0", Offset = "0x8638AD0", VA = "0x188639CD0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8639C10", Offset = "0x8638A10", VA = "0x188639C10", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8639D20", Offset = "0x8638B20", VA = "0x188639D20")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x86369F0", Offset = "0x86357F0", VA = "0x1886369F0")]
			internal int SMZLQEGCTFK()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8637120", Offset = "0x8635F20", VA = "0x188637120")]
		public HKZBJNKTEQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8636F10", Offset = "0x8635D10", VA = "0x188636F10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8639E20", Offset = "0x8638C20", VA = "0x188639E20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8639DA0", Offset = "0x8638BA0", VA = "0x188639DA0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class ZECFTGTOOPB : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8649260", Offset = "0x8648060", VA = "0x188649260")]
		public ZECFTGTOOPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x86490B0", Offset = "0x8647EB0", VA = "0x1886490B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863A0D0", Offset = "0x8638ED0", VA = "0x18863A0D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x863A030", Offset = "0x8638E30", VA = "0x18863A030", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class DKUMFKAZPAJ : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8635770", Offset = "0x8634570", VA = "0x188635770")]
		public DKUMFKAZPAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x86354F0", Offset = "0x86342F0", VA = "0x1886354F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863A430", Offset = "0x8639230", VA = "0x18863A430", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x863A3C0", Offset = "0x86391C0", VA = "0x18863A3C0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class ILQYJSDNIGN : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8637240", Offset = "0x8636040", VA = "0x188637240")]
		public ILQYJSDNIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8637170", Offset = "0x8635F70", VA = "0x188637170", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863A780", Offset = "0x8639580", VA = "0x18863A780")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x863A710", Offset = "0x8639510", VA = "0x18863A710")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, UMVKRBFKGWI root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x863A550", Offset = "0x8639350", VA = "0x18863A550", Slot = "6")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x863A5F0", Offset = "0x86393F0", VA = "0x18863A5F0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class KUBZDVUMOFM : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x863F540", Offset = "0x863E340", VA = "0x18863F540")]
		public KUBZDVUMOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x863F440", Offset = "0x863E240", VA = "0x18863F440", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863A830", Offset = "0x8639630", VA = "0x18863A830", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x863A7D0", Offset = "0x86395D0", VA = "0x18863A7D0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x863A980", Offset = "0x8639780", VA = "0x18863A980")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class JNKEGYMJUUN : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8637360", Offset = "0x8636160", VA = "0x188637360")]
		public JNKEGYMJUUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8637290", Offset = "0x8636090", VA = "0x188637290", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863AA30", Offset = "0x8639830", VA = "0x18863AA30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x863A990", Offset = "0x8639790", VA = "0x18863A990", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x863ADF0", Offset = "0x8639BF0", VA = "0x18863ADF0")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class XNURSQFLAKD : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8648BC0", Offset = "0x86479C0", VA = "0x188648BC0")]
		public XNURSQFLAKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x86488D0", Offset = "0x86476D0", VA = "0x1886488D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8640B40", Offset = "0x863F940", VA = "0x188640B40")]
		public PCWFEUMWEZU(GLTF.Math.Color a, NFXGIFNZSUM b, GLTF.Math.Vector3 c, double d, NFXGIFNZSUM e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8640210", Offset = "0x863F010", VA = "0x188640210", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x86403D0", Offset = "0x863F1D0", VA = "0x1886403D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class SFYDKETHSOE : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8641760", Offset = "0x8640560", VA = "0x188641760")]
		public SFYDKETHSOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8641400", Offset = "0x8640200", VA = "0x188641400", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863AEE0", Offset = "0x8639CE0", VA = "0x18863AEE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x863AE10", Offset = "0x8639C10", VA = "0x18863AE10", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x863B3F0", Offset = "0x863A1F0", VA = "0x18863B3F0")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class YSPWSHESQQO : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8649060", Offset = "0x8647E60", VA = "0x188649060")]
		public YSPWSHESQQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8648E00", Offset = "0x8647C00", VA = "0x188648E00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863B530", Offset = "0x863A330", VA = "0x18863B530", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x863B460", Offset = "0x863A260", VA = "0x18863B460", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x863BA50", Offset = "0x863A850", VA = "0x18863BA50")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ASIHGPTDISK : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8633720", Offset = "0x8632520", VA = "0x188633720")]
		public ASIHGPTDISK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8633500", Offset = "0x8632300", VA = "0x188633500", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863BB40", Offset = "0x863A940", VA = "0x18863BB40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x863BAC0", Offset = "0x863A8C0", VA = "0x18863BAC0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class KMXHUVKMVKD : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x863C9A0", Offset = "0x863B7A0", VA = "0x18863C9A0")]
		public KMXHUVKMVKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x863C860", Offset = "0x863B660", VA = "0x18863C860", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class GBIOBCCWCIE : RJDJOSOWNDL, MZWJRAYYFSV
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8636D80", Offset = "0x8635B80", VA = "0x188636D80")]
		public GBIOBCCWCIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8636D10", Offset = "0x8635B10", VA = "0x188636D10")]
		public GBIOBCCWCIE(GBIOBCCWCIE a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8636B10", Offset = "0x8635910", VA = "0x188636B10", Slot = "6")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8636BB0", Offset = "0x86359B0", VA = "0x188636BB0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8636C40", Offset = "0x8635A40", VA = "0x188636C40", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class SXVPWGLDVOS : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8641E00", Offset = "0x8640C00", VA = "0x188641E00")]
		public SXVPWGLDVOS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8641D80", Offset = "0x8640B80", VA = "0x188641D80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863BD60", Offset = "0x863AB60", VA = "0x18863BD60", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x863BCD0", Offset = "0x863AAD0", VA = "0x18863BCD0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x863C290", Offset = "0x863B090", VA = "0x18863C290")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class RCHNQNZGQFX : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x86413B0", Offset = "0x86401B0", VA = "0x1886413B0")]
		public RCHNQNZGQFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x86411A0", Offset = "0x863FFA0", VA = "0x1886411A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863C310", Offset = "0x863B110", VA = "0x18863C310", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x863C2B0", Offset = "0x863B0B0", VA = "0x18863C2B0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x12184E0", Offset = "0x12172E0", VA = "0x1812184E0")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class CSCCISBTEFV : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8633DE0", Offset = "0x8632BE0", VA = "0x188633DE0")]
		public CSCCISBTEFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8633D00", Offset = "0x8632B00", VA = "0x188633D00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863C480", Offset = "0x863B280", VA = "0x18863C480", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x863C420", Offset = "0x863B220", VA = "0x18863C420", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x12184E0", Offset = "0x12172E0", VA = "0x1812184E0")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class LVKNPCRJMDL : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x863F850", Offset = "0x863E650", VA = "0x18863F850")]
		public LVKNPCRJMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x863F770", Offset = "0x863E570", VA = "0x18863F770", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863C5F0", Offset = "0x863B3F0", VA = "0x18863C5F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x863C590", Offset = "0x863B390", VA = "0x18863C590", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x12184E0", Offset = "0x12172E0", VA = "0x1812184E0")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class PMUTFXZCCVN : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8640D20", Offset = "0x863FB20", VA = "0x188640D20")]
		public PMUTFXZCCVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8640C40", Offset = "0x863FA40", VA = "0x188640C40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public KHR_texture_basisu(ITQGRFRGWXV source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x863C700", Offset = "0x863B500", VA = "0x18863C700", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x863C770", Offset = "0x863B570", VA = "0x18863C770", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class XHAFKQAYRZT : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8648880", Offset = "0x8647680", VA = "0x188648880")]
		public XHAFKQAYRZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8648720", Offset = "0x8647520", VA = "0x188648720", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8634880", Offset = "0x8633680", VA = "0x188634880")]
		public DDUKGKHLGQS(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8634130", Offset = "0x8632F30", VA = "0x188634130", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8634210", Offset = "0x8633010", VA = "0x188634210", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class WZIYKOAYLTK : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x86485B0", Offset = "0x86473B0", VA = "0x1886485B0")]
		public WZIYKOAYLTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x86482E0", Offset = "0x86470E0", VA = "0x1886482E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public XYDKVSUSUCU(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8648C10", Offset = "0x8647A10", VA = "0x188648C10", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8648D10", Offset = "0x8647B10", VA = "0x188648D10", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8648C80", Offset = "0x8647A80", VA = "0x188648C80")]
		public List<double> FTHQVAYNFPC(RHNNOHYQJTP a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class JTBDNMQFTTE : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x86374B0", Offset = "0x86362B0", VA = "0x1886374B0")]
		public JTBDNMQFTTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x86373B0", Offset = "0x86361B0", VA = "0x1886373B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8637890", Offset = "0x8636690", VA = "0x188637890")]
		public ZUFXHFCXCIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x864AB90", Offset = "0x8649990", VA = "0x18864AB90")]
		public static ZUFXHFCXCIO Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x864C860", Offset = "0x864B660", VA = "0x18864C860", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x864E110", Offset = "0x864CF10", VA = "0x18864E110")]
		private unsafe static sbyte WQTXOUCMRFF(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x864C760", Offset = "0x864B560", VA = "0x18864C760")]
		private unsafe static float2 NBFOEAUIHCT(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x864DFF0", Offset = "0x864CDF0", VA = "0x18864DFF0")]
		private unsafe static float3 VDMFWBLXXNQ(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x864C790", Offset = "0x864B590", VA = "0x18864C790")]
		private unsafe static float4 NHNYNHPAGYR(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x864D750", Offset = "0x864C550", VA = "0x18864D750")]
		private unsafe static float4x4 TEQMSMBTVUJ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x864E110", Offset = "0x864CF10", VA = "0x18864E110")]
		private unsafe static byte XWIETDNEUAI(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x864CE40", Offset = "0x864BC40", VA = "0x18864CE40")]
		private unsafe static float2 ORQGWYPCVIK(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x864B120", Offset = "0x8649F20", VA = "0x18864B120")]
		private unsafe static float3 ETPXOBQLXCD(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x864E4C0", Offset = "0x864D2C0", VA = "0x18864E4C0")]
		private unsafe static float4 YERBDTNZGTG(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x864B420", Offset = "0x864A220", VA = "0x18864B420")]
		private unsafe static float4x4 GBFRBENPRAE(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x864A1C0", Offset = "0x8648FC0", VA = "0x18864A1C0")]
		private unsafe static short RFPCXBWAZPD(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x864DB40", Offset = "0x864C940", VA = "0x18864DB40")]
		private unsafe static float2 TOBGEMFCJON(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x864D490", Offset = "0x864C290", VA = "0x18864D490")]
		private unsafe static float3 REPNRFLWFVK(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x864E590", Offset = "0x864D390", VA = "0x18864E590")]
		private unsafe static float4 ZLEOXOESDQT(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x864E5F0", Offset = "0x864D3F0", VA = "0x18864E5F0")]
		private unsafe static float4x4 ZPKSEQFYZXJ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x864A1C0", Offset = "0x8648FC0", VA = "0x18864A1C0")]
		private unsafe static ushort AUYNQXLESXW(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x864E490", Offset = "0x864D290", VA = "0x18864E490")]
		private unsafe static float2 XBFHNCQUJIO(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x864C7F0", Offset = "0x864B5F0", VA = "0x18864C7F0")]
		private unsafe static float3 NTXNMMZTOWT(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x864A300", Offset = "0x8649100", VA = "0x18864A300")]
		private unsafe static float4x4 CUFSOCHEWEU(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x864E530", Offset = "0x864D330", VA = "0x18864E530")]
		private unsafe static float4 ZCPNLYTDFNS(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x864A1D0", Offset = "0x8648FD0", VA = "0x18864A1D0")]
		private unsafe static uint AYECNFLMJEJ(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x864A1C0", Offset = "0x8648FC0", VA = "0x18864A1C0")]
		private unsafe static ushort PXCXMRAPOUA(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x864E520", Offset = "0x864D320", VA = "0x18864E520")]
		private unsafe static float YZHJRXEEJEF(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x864A1A0", Offset = "0x8648FA0", VA = "0x18864A1A0")]
		private unsafe static float2 AICNSFNLQBH(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x864C840", Offset = "0x864B640", VA = "0x18864C840")]
		private unsafe static float3 NURWPPXNDFW(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x864BCB0", Offset = "0x864AAB0", VA = "0x18864BCB0")]
		private unsafe static float4 UFBSXNUPPHZ(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x864A4A0", Offset = "0x86492A0", VA = "0x18864A4A0")]
		private unsafe static float4x4 CZQCSIGNKGD(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x864BCB0", Offset = "0x864AAB0", VA = "0x18864BCB0")]
		private unsafe static float4 KWLSHXMKGUC(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x864BC80", Offset = "0x864AA80", VA = "0x18864BC80")]
		private unsafe static float4 KWLSHXMKGUC(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x864CFE0", Offset = "0x864BDE0", VA = "0x18864CFE0")]
		public static float3[] PBSKKFRBYDJ(ZUFXHFCXCIO a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x864DB70", Offset = "0x864C970", VA = "0x18864DB70")]
		public static float3[] TUSYXOFKISL(ZUFXHFCXCIO a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x864CE70", Offset = "0x864BC70", VA = "0x18864CE70")]
		public static uint[] OVQZPGYJGDA(ZUFXHFCXCIO a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x864D210", Offset = "0x864C010", VA = "0x18864D210")]
		internal static void PCCEZDLLUZR(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x864D8F0", Offset = "0x864C6F0", VA = "0x18864D8F0")]
		public uint[] TNURQPDGATY(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x864D4E0", Offset = "0x864C2E0", VA = "0x18864D4E0")]
		public float[] SXSMBDZTKKO(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x864B5C0", Offset = "0x864A3C0", VA = "0x18864B5C0")]
		public float2[] GTUGNZLDIGW(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x864B170", Offset = "0x8649F70", VA = "0x18864B170")]
		public float2[] FKFKDASLDTS(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x864BE50", Offset = "0x864AC50", VA = "0x18864BE50")]
		public float3[] MIBEGKETWOL(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x864C0D0", Offset = "0x864AED0", VA = "0x18864C0D0")]
		public float3[] MNTVZYZEXMD(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x864BA10", Offset = "0x864A810", VA = "0x18864BA10")]
		public float4[] KLCCFTNSRPK(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x864E120", Offset = "0x864CF20", VA = "0x18864E120")]
		public float4[] WXRGVGETTRO(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8649E10", Offset = "0x8648C10", VA = "0x188649E10")]
		public float4[] AGFMPTRZRUV(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x864A4D0", Offset = "0x86492D0", VA = "0x18864A4D0")]
		public float3[] DEEWIUJMIAI(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x864D330", Offset = "0x864C130", VA = "0x18864D330")]
		public float3[] PYMVIOUODVZ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x864E040", Offset = "0x864CE40", VA = "0x18864E040")]
		public float4[] VYXITQWXAXB(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x864D440", Offset = "0x864C240", VA = "0x18864D440")]
		public uint[] QJEDFWSGSCC(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x864A5E0", Offset = "0x86493E0", VA = "0x18864A5E0")]
		public float4x4[] DUEECDJOJQZ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x864C5A0", Offset = "0x864B3A0", VA = "0x18864C5A0")]
		private unsafe static float4 NBCKADHREAF(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x864C420", Offset = "0x864B220", VA = "0x18864C420")]
		private unsafe static float4 NBCKADHREAF(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x864BCE0", Offset = "0x864AAE0", VA = "0x18864BCE0")]
		private unsafe static float4x4 KZQJDIVCLXQ(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x864B850", Offset = "0x864A650", VA = "0x18864B850")]
		private unsafe static float4 JYZQYXQLUFE(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x864DE80", Offset = "0x864CC80", VA = "0x18864DE80")]
		private unsafe static float3 UMHMTYVDWWV(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x864AFF0", Offset = "0x8649DF0", VA = "0x18864AFF0")]
		private unsafe static float2 EEDCIYSRUXW(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x864A1E0", Offset = "0x8648FE0", VA = "0x18864A1E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8651920", Offset = "0x8650720", VA = "0x188651920")]
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
		[Cpp2IlInjected.Address(RVA = "0x865CD00", Offset = "0x865BB00", VA = "0x18865CD00")]
		public SMYCABBPIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x865C900", Offset = "0x865B700", VA = "0x18865C900")]
		public static SMYCABBPIGG Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x865CBD0", Offset = "0x865B9D0", VA = "0x18865CBD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86510D0", Offset = "0x864FED0", VA = "0x1886510D0")]
		public ENSEUJPJZID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8650CB0", Offset = "0x864FAB0", VA = "0x188650CB0")]
		public static ENSEUJPJZID Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8650F90", Offset = "0x864FD90", VA = "0x188650F90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86526F0", Offset = "0x86514F0", VA = "0x1886526F0")]
		public HOMRVGDOZXG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8652370", Offset = "0x8651170", VA = "0x188652370")]
		public static HOMRVGDOZXG Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x86525F0", Offset = "0x86513F0", VA = "0x1886525F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8651410", Offset = "0x8650210", VA = "0x188651410")]
		public FBTFVKCWNVS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8651120", Offset = "0x864FF20", VA = "0x188651120")]
		public static FBTFVKCWNVS Deserialize(UMVKRBFKGWI root, JsonReader reader, CWCKCFASOBI anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8651310", Offset = "0x8650110", VA = "0x188651310", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8651FA0", Offset = "0x8650DA0", VA = "0x188651FA0")]
		public static HNJRRZZSFHX Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8652320", Offset = "0x8651120", VA = "0x188652320")]
		public HNJRRZZSFHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8652200", Offset = "0x8651000", VA = "0x188652200", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8650A90", Offset = "0x864F890", VA = "0x188650A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657FF0", Offset = "0x8656DF0", VA = "0x188657FF0")]
		public PMXEEBFDOGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8657C60", Offset = "0x8656A60", VA = "0x188657C60")]
		public static PMXEEBFDOGP Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8657E80", Offset = "0x8656C80", VA = "0x188657E80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8656BD0", Offset = "0x86559D0", VA = "0x188656BD0")]
		public OWMJOBRTNFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x86560E0", Offset = "0x8654EE0", VA = "0x1886560E0")]
		public static OWMJOBRTNFJ Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x86567A0", Offset = "0x86555A0", VA = "0x1886567A0", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8656BC0", Offset = "0x86559C0", VA = "0x188656BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8656400", Offset = "0x8655200", VA = "0x188656400")]
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
		[Cpp2IlInjected.Address(RVA = "0x864FD90", Offset = "0x864EB90", VA = "0x18864FD90")]
		public FDLXEYELZJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8651460", Offset = "0x8650260", VA = "0x188651460")]
		public static FDLXEYELZJU Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8651710", Offset = "0x8650510", VA = "0x188651710", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x865C670", Offset = "0x865B470", VA = "0x18865C670")]
		public RLZEZCRLRKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x865C180", Offset = "0x865AF80", VA = "0x18865C180")]
		public static RLZEZCRLRKI Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x865C500", Offset = "0x865B300", VA = "0x18865C500", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8658BB0", Offset = "0x86579B0", VA = "0x188658BB0")]
		public QJOJGVEKCUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x86586B0", Offset = "0x86574B0", VA = "0x1886586B0")]
		public static QJOJGVEKCUQ Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8658A20", Offset = "0x8657820", VA = "0x188658A20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8651EF0", Offset = "0x8650CF0", VA = "0x188651EF0")]
			internal FBTFVKCWNVS SMZLQEGCTFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8651F10", Offset = "0x8650D10", VA = "0x188651F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x864F1A0", Offset = "0x864DFA0", VA = "0x18864F1A0")]
		public static CWCKCFASOBI Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x864F900", Offset = "0x864E700", VA = "0x18864F900")]
		public CWCKCFASOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x864F560", Offset = "0x864E360", VA = "0x18864F560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x864FD90", Offset = "0x864EB90", VA = "0x18864FD90")]
		public WNHMBYUWLBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8660400", Offset = "0x865F200", VA = "0x188660400")]
		public static WNHMBYUWLBQ Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x86605D0", Offset = "0x865F3D0", VA = "0x1886605D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x864FD90", Offset = "0x864EB90", VA = "0x18864FD90")]
		public DNUOVHETSIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x864F9F0", Offset = "0x864E7F0", VA = "0x18864F9F0")]
		public static DNUOVHETSIL Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x864FBC0", Offset = "0x864E9C0", VA = "0x18864FBC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x864FD90", Offset = "0x864EB90", VA = "0x18864FD90")]
		public NMRTCVGFESK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8654AF0", Offset = "0x86538F0", VA = "0x188654AF0")]
		public NMRTCVGFESK(NMRTCVGFESK a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8654A00", Offset = "0x8653800", VA = "0x188654A00")]
		public new void ONDFWRAAKYY(UMVKRBFKGWI a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8654970", Offset = "0x8653770", VA = "0x188654970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		protected KWEDGYYLVVY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x67975D0", Offset = "0x67963D0", VA = "0x1867975D0")]
		public KWEDGYYLVVY(KWEDGYYLVVY<a> a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x67975A0", Offset = "0x67963A0", VA = "0x1867975A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8652AA0", Offset = "0x86518A0", VA = "0x188652AA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8652A00", Offset = "0x8651800", VA = "0x188652A00")]
		public HYHNESAJCVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8652A40", Offset = "0x8651840", VA = "0x188652A40")]
		public HYHNESAJCVR(HYHNESAJCVR a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8652920", Offset = "0x8651720", VA = "0x188652920")]
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
			[Cpp2IlInjected.Address(RVA = "0x864EDF0", Offset = "0x864DBF0", VA = "0x18864EDF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x864EDB0", Offset = "0x864DBB0", VA = "0x18864EDB0")]
		public BJXKJBBDFYW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x864ECD0", Offset = "0x864DAD0", VA = "0x18864ECD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86613A0", Offset = "0x86601A0", VA = "0x1886613A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8661360", Offset = "0x8660160", VA = "0x188661360")]
		public XDEZBKLUTIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8661280", Offset = "0x8660080", VA = "0x188661280")]
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
			[Cpp2IlInjected.Address(RVA = "0x8650C50", Offset = "0x864FA50", VA = "0x188650C50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8650C10", Offset = "0x864FA10", VA = "0x188650C10")]
		public EIKNAPQOSTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8650B30", Offset = "0x864F930", VA = "0x188650B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x8652C20", Offset = "0x8651A20", VA = "0x188652C20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8652BE0", Offset = "0x86519E0", VA = "0x188652BE0")]
		public ITQGRFRGWXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8652B00", Offset = "0x8651900", VA = "0x188652B00")]
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
			[Cpp2IlInjected.Address(RVA = "0x8661580", Offset = "0x8660380", VA = "0x188661580", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8661540", Offset = "0x8660340", VA = "0x188661540")]
		public XJVVNMRVGLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x86614E0", Offset = "0x86602E0", VA = "0x1886614E0")]
		public XJVVNMRVGLL(XJVVNMRVGLL a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8661400", Offset = "0x8660200", VA = "0x188661400")]
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
			[Cpp2IlInjected.Address(RVA = "0x865C120", Offset = "0x865AF20", VA = "0x18865C120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x865C0E0", Offset = "0x865AEE0", VA = "0x18865C0E0")]
		public RLTDEIJDSHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x865C000", Offset = "0x865AE00", VA = "0x18865C000")]
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
			[Cpp2IlInjected.Address(RVA = "0x86556A0", Offset = "0x86544A0", VA = "0x1886556A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8655660", Offset = "0x8654460", VA = "0x188655660")]
		public OGNAAAHQAIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8655310", Offset = "0x8654110", VA = "0x188655310")]
		public static OGNAAAHQAIU Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x86553F0", Offset = "0x86541F0", VA = "0x1886553F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8661700", Offset = "0x8660500", VA = "0x188661700", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x86616C0", Offset = "0x86604C0", VA = "0x1886616C0")]
		public XTAQTHAXXES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x86615E0", Offset = "0x86603E0", VA = "0x1886615E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8650A30", Offset = "0x864F830", VA = "0x188650A30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x86509F0", Offset = "0x864F7F0", VA = "0x1886509F0")]
		public EDQVRSMWIDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x86508F0", Offset = "0x864F6F0", VA = "0x1886508F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8661880", Offset = "0x8660680", VA = "0x188661880", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8661840", Offset = "0x8660640", VA = "0x188661840")]
		public XTVXQQJFRUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8661760", Offset = "0x8660560", VA = "0x188661760")]
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
			[Cpp2IlInjected.Address(RVA = "0x865D3A0", Offset = "0x865C1A0", VA = "0x18865D3A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x865D360", Offset = "0x865C160", VA = "0x18865D360")]
		public TRYUEOTRPLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x865D280", Offset = "0x865C080", VA = "0x18865D280")]
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
			[Cpp2IlInjected.Address(RVA = "0x86528C0", Offset = "0x86516C0", VA = "0x1886528C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8652880", Offset = "0x8651680", VA = "0x188652880")]
		public HUZHYQGYCEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8652820", Offset = "0x8651620", VA = "0x188652820")]
		public HUZHYQGYCEF(HUZHYQGYCEF a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8652740", Offset = "0x8651540", VA = "0x188652740")]
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
			[Cpp2IlInjected.Address(RVA = "0x8653000", Offset = "0x8651E00", VA = "0x188653000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8652FC0", Offset = "0x8651DC0", VA = "0x188652FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x864FD90", Offset = "0x864EB90", VA = "0x18864FD90")]
		public LTEBGRWBKUR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8654070", Offset = "0x8652E70", VA = "0x188654070")]
		public static LTEBGRWBKUR Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x86542B0", Offset = "0x86530B0", VA = "0x1886542B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8656070", Offset = "0x8654E70", VA = "0x188656070")]
		public OLJOBCTZNER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8655700", Offset = "0x8654500", VA = "0x188655700")]
		public static OLJOBCTZNER Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8655C10", Offset = "0x8654A10", VA = "0x188655C10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x8653060", Offset = "0x8651E60", VA = "0x188653060")]
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
		[Cpp2IlInjected.Address(RVA = "0x864FD90", Offset = "0x864EB90", VA = "0x18864FD90")]
		public LRYEZTADGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8653700", Offset = "0x8652500", VA = "0x188653700")]
		public static LRYEZTADGEZ Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8653AC0", Offset = "0x86528C0", VA = "0x188653AC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x865ADA0", Offset = "0x8659BA0", VA = "0x18865ADA0")]
		public static HVJDTAFBXHO OFZITWIEKUX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x865A350", Offset = "0x8659150", VA = "0x18865A350")]
		public static MZWJRAYYFSV LDIRZLAJFQX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public RJDJOSOWNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x865BD10", Offset = "0x865AB10", VA = "0x18865BD10")]
		public RJDJOSOWNDL(RJDJOSOWNDL a, [Optional] UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x865AF30", Offset = "0x8659D30", VA = "0x18865AF30")]
		public void ONDFWRAAKYY(UMVKRBFKGWI a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x865B2D0", Offset = "0x865A0D0", VA = "0x18865B2D0")]
		public void WUIULCGEEWB(string a, MZWJRAYYFSV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x865B1E0", Offset = "0x8659FE0", VA = "0x18865B1E0")]
		private void ORUVVQSTZCX(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x865B420", Offset = "0x865A220", VA = "0x18865B420")]
		private void ZICCROBXXMJ(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x865A290", Offset = "0x8659090", VA = "0x18865A290")]
		private void IQIVRQYLPKX(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x865A440", Offset = "0x8659240", VA = "0x18865A440")]
		internal static Dictionary<string, MZWJRAYYFSV> NTIHLMMONMC(UMVKRBFKGWI a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x865AA20", Offset = "0x8659820", VA = "0x18865AA20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ZVHFLELJGRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8664630", Offset = "0x8663430", VA = "0x188664630")]
			internal ZUFXHFCXCIO SMZLQEGCTFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x8664640", Offset = "0x8663440", VA = "0x188664640")]
			internal CWCKCFASOBI SNESNLAACQT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x8664650", Offset = "0x8663450", VA = "0x188664650")]
			internal WNHMBYUWLBQ SNJZKRTXMCC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x8664660", Offset = "0x8663460", VA = "0x188664660")]
			internal FDLXEYELZJU SNPGHYNUVNL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x8664670", Offset = "0x8663470", VA = "0x188664670")]
			internal DNUOVHETSIL SNUNFFHSEYU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x8664680", Offset = "0x8663480", VA = "0x188664680")]
			internal LTEBGRWBKUR SNZUCMBPOKD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x8664690", Offset = "0x8663490", VA = "0x188664690")]
			internal OLJOBCTZNER SOFAZSVMXVM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x86646A0", Offset = "0x86634A0", VA = "0x1886646A0")]
			internal LRYEZTADGEZ SOKHWZPKHGV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x8664610", Offset = "0x8663410", VA = "0x188664610")]
			internal RHNNOHYQJTP SLJIMCCXVSQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x8664620", Offset = "0x8663420", VA = "0x188664620")]
			internal Sampler SLOPJIWVFDZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x8664490", Offset = "0x8663290", VA = "0x188664490")]
			internal DUBBBZCYNWU MPGLXHYDATL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x8664480", Offset = "0x8663280", VA = "0x188664480")]
			internal DQODYHYBBWM MPBFABEFRIC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x8664470", Offset = "0x8663270", VA = "0x188664470")]
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
		[Cpp2IlInjected.Address(RVA = "0x86603B0", Offset = "0x865F1B0", VA = "0x1886603B0")]
		public UMVKRBFKGWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x865E760", Offset = "0x865D560", VA = "0x18865E760")]
		public DUBBBZCYNWU IIYUPODZFQY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x865D910", Offset = "0x865C710", VA = "0x18865D910")]
		public static UMVKRBFKGWI Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x865E800", Offset = "0x865D600", VA = "0x18865E800")]
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
		[Cpp2IlInjected.Address(RVA = "0x864FD90", Offset = "0x864EB90", VA = "0x18864FD90")]
		public DUBBBZCYNWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8650500", Offset = "0x864F300", VA = "0x188650500")]
		public static DUBBBZCYNWU Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8650680", Offset = "0x864F480", VA = "0x188650680", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x864FD90", Offset = "0x864EB90", VA = "0x18864FD90")]
		public JWOCSZJSECD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8652C80", Offset = "0x8651A80", VA = "0x188652C80")]
		public static JWOCSZJSECD Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8652E50", Offset = "0x8651C50", VA = "0x188652E50", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class MYAFUAKAEEE : LLCVOVJISQY
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x864FD90", Offset = "0x864EB90", VA = "0x18864FD90")]
		public MYAFUAKAEEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8651F90", Offset = "0x8650D90", VA = "0x188651F90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x864FD90", Offset = "0x864EB90", VA = "0x18864FD90")]
		public LLCVOVJISQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8653480", Offset = "0x8652280", VA = "0x188653480", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class GWMNVMRIEKC : LLCVOVJISQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x864FD90", Offset = "0x864EB90", VA = "0x18864FD90")]
		public GWMNVMRIEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8651F90", Offset = "0x8650D90", VA = "0x188651F90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x864F150", Offset = "0x864DF50", VA = "0x18864F150")]
		public CCIDKNCSIZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x864EE50", Offset = "0x864DC50", VA = "0x18864EE50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8657BB0", Offset = "0x86569B0", VA = "0x188657BB0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public PDVPETXTNTR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class GRDTHWCPLJJ : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8651F20", Offset = "0x8650D20", VA = "0x188651F20", Slot = "4")]
		public override MZWJRAYYFSV Deserialize(UMVKRBFKGWI root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8651E80", Offset = "0x8650C80", VA = "0x188651E80")]
		public FSFYUPLVYKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8651980", Offset = "0x8650780", VA = "0x188651980")]
		public static FSFYUPLVYKJ Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8651C20", Offset = "0x8650A20", VA = "0x188651C20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8653420", Offset = "0x8652220", VA = "0x188653420")]
		public YLKXUMQBYYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x86618E0", Offset = "0x86606E0", VA = "0x1886618E0")]
		public new static YLKXUMQBYYZ Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8661BD0", Offset = "0x86609D0", VA = "0x188661BD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8653420", Offset = "0x8652220", VA = "0x188653420")]
		public LIDHDXTADIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8653070", Offset = "0x8651E70", VA = "0x188653070")]
		public new static LIDHDXTADIF Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8653360", Offset = "0x8652160", VA = "0x188653360", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8658640", Offset = "0x8657440", VA = "0x188658640")]
		public QGANMIYRXEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8658040", Offset = "0x8656E40", VA = "0x188658040")]
		public static QGANMIYRXEM Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x86583B0", Offset = "0x86571B0", VA = "0x1886583B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public XCEEGWYISVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x8661030", Offset = "0x865FE30", VA = "0x188661030")]
			internal HYHNESAJCVR SMZLQEGCTFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x8661100", Offset = "0x865FF00", VA = "0x188661100")]
			internal Dictionary<string, HYHNESAJCVR> SNESNLAACQT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x86611B0", Offset = "0x865FFB0", VA = "0x1886611B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8662F80", Offset = "0x8661D80", VA = "0x188662F80")]
		public YMAKEZFFZYF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8663020", Offset = "0x8661E20", VA = "0x188663020")]
		public YMAKEZFFZYF(YMAKEZFFZYF a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8661C90", Offset = "0x8660A90", VA = "0x188661C90")]
		public static int[] DQFKTCGYHGH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8662E20", Offset = "0x8661C20", VA = "0x188662E20")]
		public static int[] YVAOPKCYBGJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8662BF0", Offset = "0x86619F0", VA = "0x188662BF0")]
		public static int[] SDXCXQCNGZB(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x86629B0", Offset = "0x86617B0", VA = "0x1886629B0")]
		public static int[] OPUFLILESWN(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8662180", Offset = "0x8660F80", VA = "0x188662180")]
		public static int[] HZSMRLUFFTC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8662DB0", Offset = "0x8661BB0", VA = "0x188662DB0")]
		public static int[] WLUXCDHEISN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x86622A0", Offset = "0x86610A0", VA = "0x1886622A0")]
		public static int[] JXOFJIWLMGJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8662230", Offset = "0x8661030", VA = "0x188662230")]
		public static int[] IIEOBKTMZDA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8662330", Offset = "0x8661130", VA = "0x188662330")]
		public static int[] MLCRPSVKCBQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8661D30", Offset = "0x8660B30", VA = "0x188661D30")]
		public static YMAKEZFFZYF Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x86623C0", Offset = "0x86611C0", VA = "0x1886623C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x865A150", Offset = "0x8658F50", VA = "0x18865A150")]
		public RHNNOHYQJTP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8658C10", Offset = "0x8657A10", VA = "0x188658C10")]
		public static RHNNOHYQJTP Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8659550", Offset = "0x8658350", VA = "0x188659550", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x865D210", Offset = "0x865C010", VA = "0x18865D210")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x865CD50", Offset = "0x865BB50", VA = "0x18865CD50")]
		public static Sampler Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x865D020", Offset = "0x865BE20", VA = "0x18865D020", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8650450", Offset = "0x864F250", VA = "0x188650450")]
		public DQODYHYBBWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x864FDE0", Offset = "0x864EBE0", VA = "0x18864FDE0")]
		public static DQODYHYBBWM Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8650140", Offset = "0x864EF40", VA = "0x188650140", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8654920", Offset = "0x8653720", VA = "0x188654920")]
		public NFXGIFNZSUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8654830", Offset = "0x8653630", VA = "0x188654830")]
		public NFXGIFNZSUM(NFXGIFNZSUM a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8654480", Offset = "0x8653280", VA = "0x188654480")]
		public static NFXGIFNZSUM Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8654700", Offset = "0x8653500", VA = "0x188654700", Slot = "4")]
		public override void NYKTBLQYXAJ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8654760", Offset = "0x8653560", VA = "0x188654760")]
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
		[Cpp2IlInjected.Address(RVA = "0x864EC50", Offset = "0x864DA50", VA = "0x18864EC50")]
		public AFBRFWNGWKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x864E790", Offset = "0x864D590", VA = "0x18864E790")]
		public static AFBRFWNGWKV Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x864E9E0", Offset = "0x864D7E0", VA = "0x18864E9E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86640E0", Offset = "0x8662EE0", VA = "0x1886640E0")]
		public ZKUUYVHDUWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8663FB0", Offset = "0x8662DB0", VA = "0x188663FB0")]
		public ZKUUYVHDUWN(ZKUUYVHDUWN a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x86636C0", Offset = "0x86624C0", VA = "0x1886636C0")]
		public static ZKUUYVHDUWN Deserialize(UMVKRBFKGWI root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8663AB0", Offset = "0x86628B0", VA = "0x188663AB0")]
		public static ZKUUYVHDUWN Deserialize(UMVKRBFKGWI root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8663BD0", Offset = "0x86629D0", VA = "0x188663BD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public WPFMIKDYMUX(IList<LLCVOVJISQY> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8660790", Offset = "0x865F590", VA = "0x188660790", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8660720", Offset = "0x865F520", VA = "0x188660720", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657B30", Offset = "0x8656930", VA = "0x188657B30")]
		public OWSBWRCYKBR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8656C70", Offset = "0x8655A70", VA = "0x188656C70", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8657790", Offset = "0x8656590", VA = "0x188657790", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8657880", Offset = "0x8656680", VA = "0x188657880")]
		private static string[] ZFJMAHFOEVR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x86572F0", Offset = "0x86560F0", VA = "0x1886572F0")]
		private static EFASQHYZTFI.ImportValuesConversion QTZNLZJVKZR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8656F00", Offset = "0x8655D00", VA = "0x188656F00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x86551C0", Offset = "0x8653FC0", VA = "0x1886551C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8655180", Offset = "0x8653F80", VA = "0x188655180")]
		public NUXKFEEDQBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x86550A0", Offset = "0x8653EA0", VA = "0x1886550A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public RVKWKAXNCFF(NUXKFEEDQBC a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x865C840", Offset = "0x865B640", VA = "0x18865C840")]
		public RVKWKAXNCFF(int a, UMVKRBFKGWI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x865C6C0", Offset = "0x865B4C0", VA = "0x18865C6C0", Slot = "5")]
		public MZWJRAYYFSV Clone(UMVKRBFKGWI root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x865C740", Offset = "0x865B540", VA = "0x18865C740", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class NOPPHQSQLUS : HVJDTAFBXHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8655050", Offset = "0x8653E50", VA = "0x188655050")]
		public NOPPHQSQLUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8654B70", Offset = "0x8653970", VA = "0x188654B70", Slot = "4")]
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
