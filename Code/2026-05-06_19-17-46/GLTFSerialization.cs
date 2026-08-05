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
	public class KHR_animation_pointer : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object FEOBYYQDIXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string JVVMXONAOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string VEXVOSYOKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public ZPCBEZLKRXQ RVODXHEOGHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer JFFBMJFYOMF;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x865D150", Offset = "0x865BB50", VA = "0x18865D150", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x865D0A0", Offset = "0x865BAA0", VA = "0x18865D0A0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class UROBZBRXZPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 QDMOCDCVKME;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 QTWIBBXUVZV;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion FBBGPTVYCPV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool PULSUQFRGRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x866B7F0", Offset = "0x866A1F0", VA = "0x18866B7F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x866AB00", Offset = "0x8669500", VA = "0x18866AB00")]
		public static void KIBVJTKHKKP(this SIDFNDXEBQO a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x866C040", Offset = "0x866AA40", VA = "0x18866C040")]
		public static void SZIHWQJCUOJ(this SIDFNDXEBQO a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x866A0D0", Offset = "0x8668AD0", VA = "0x18866A0D0")]
		public static void IIOAQXMLZOI(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x866BE20", Offset = "0x866A820", VA = "0x18866BE20")]
		public static GLTF.Math.Vector4 RNCHFMYKUCM(this XAGUPSXTOGN a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8669A00", Offset = "0x8668400", VA = "0x188669A00")]
		public static UnityEngine.Quaternion CJNLEQWJBNB(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86698D0", Offset = "0x86682D0", VA = "0x1886698D0")]
		public static UnityEngine.Quaternion CJNLEQWJBNB(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86691E0", Offset = "0x8667BE0", VA = "0x1886691E0")]
		public static GLTF.Math.Quaternion AGNARMXEHUJ(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x866A4A0", Offset = "0x8668EA0", VA = "0x18866A4A0")]
		public static Matrix4x4 IPJZNIABGJU(this XAGUPSXTOGN a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x866A6C0", Offset = "0x86690C0", VA = "0x18866A6C0")]
		public static Matrix4x4 IPJZNIABGJU(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x866B4B0", Offset = "0x8669EB0", VA = "0x18866B4B0")]
		public static XAGUPSXTOGN LIYLDEAAATO(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x866B200", Offset = "0x8669C00", VA = "0x18866B200")]
		public static UnityEngine.Vector3 KSUGMOMYRFF(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x866B320", Offset = "0x8669D20", VA = "0x18866B320")]
		public static UnityEngine.Vector3 KSUGMOMYRFF(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8669B90", Offset = "0x8668590", VA = "0x188669B90")]
		public static GLTF.Math.Vector3 CNNYYEEYURP(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x866BA50", Offset = "0x866A450", VA = "0x18866BA50")]
		public static GLTF.Math.Vector3 OTILZCGTGTG(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x135FE90", Offset = "0x135E890", VA = "0x18135FE90")]
		public static GLTF.Math.Vector4 LUCUJRZWANZ(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8669610", Offset = "0x8668010", VA = "0x188669610")]
		public static Matrix4x4 BEXOOVZMNIP(this XAGUPSXTOGN a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86693A0", Offset = "0x8667DA0", VA = "0x1886693A0")]
		public static Matrix4x4 BEXOOVZMNIP(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x866B880", Offset = "0x866A280", VA = "0x18866B880")]
		public static XAGUPSXTOGN ODINYVZUUWJ(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x866C7C0", Offset = "0x866B1C0", VA = "0x18866C7C0")]
		public static UnityEngine.Vector2 XEOOMXAGDRJ(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x866C7C0", Offset = "0x866B1C0", VA = "0x18866C7C0")]
		public static UnityEngine.Vector2 XEOOMXAGDRJ(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x866C7E0", Offset = "0x866B1E0", VA = "0x18866C7E0")]
		public static void XEOOMXAGDRJ(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8669F80", Offset = "0x8668980", VA = "0x188669F80")]
		public static UnityEngine.Vector3 HKGBIFCVRFE(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D785E0", Offset = "0x1D76FE0", VA = "0x181D785E0")]
		public static UnityEngine.Vector3 HKGBIFCVRFE(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8669FE0", Offset = "0x86689E0", VA = "0x188669FE0")]
		public static void HKGBIFCVRFE(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x135FE90", Offset = "0x135E890", VA = "0x18135FE90")]
		public static UnityEngine.Vector4 DTHQJKROMOZ(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x135FE90", Offset = "0x135E890", VA = "0x18135FE90")]
		public static UnityEngine.Vector4 DTHQJKROMOZ(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8669CF0", Offset = "0x86686F0", VA = "0x188669CF0")]
		public static UnityEngine.Vector4[] DTHQJKROMOZ(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8669DF0", Offset = "0x86687F0", VA = "0x188669DF0")]
		public static void DTHQJKROMOZ(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x866BCE0", Offset = "0x866A6E0", VA = "0x18866BCE0")]
		public static UnityEngine.Color PETCUFHHRYT(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x866BBA0", Offset = "0x866A5A0", VA = "0x18866BBA0")]
		public static void PETCUFHHRYT(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x866BCE0", Offset = "0x866A6E0", VA = "0x18866BCE0")]
		public static UnityEngine.Color PETCUFHHRYT(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x135FE90", Offset = "0x135E890", VA = "0x18135FE90")]
		public static UnityEngine.Color PBQNVYWDCPM(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x866BA90", Offset = "0x866A490", VA = "0x18866BA90")]
		public static void PBQNVYWDCPM(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x135FE90", Offset = "0x135E890", VA = "0x18135FE90")]
		public static UnityEngine.Color PBQNVYWDCPM(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x866BDF0", Offset = "0x866A7F0", VA = "0x18866BDF0")]
		public static GLTF.Math.Color QQAEVVWSLJC(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x866C8B0", Offset = "0x866B2B0", VA = "0x18866C8B0")]
		public static GLTF.Math.Color XZREWGVYTIL(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8669320", Offset = "0x8667D20", VA = "0x188669320")]
		public static GLTF.Math.Color BDQUZRMEXFZ(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x866C540", Offset = "0x866AF40", VA = "0x18866C540")]
		public static UnityEngine.Color[] TSIIUEDXZXU(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8669F00", Offset = "0x8668900", VA = "0x188669F00")]
		public static int[] FBGOKADAZPL(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x866B400", Offset = "0x8669E00", VA = "0x18866B400")]
		public static UnityEngine.Vector2[] KVCIGLBTDNM(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x866B0A0", Offset = "0x8669AA0", VA = "0x18866B0A0")]
		public static void KNCSFKPORDD(MSHGOIDHWYJ a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x866C660", Offset = "0x866B060", VA = "0x18866C660")]
		public static UnityEngine.Vector3[] WYKWBKLPQML(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x866C930", Offset = "0x866B330", VA = "0x18866C930")]
		public static UnityEngine.Vector4[] ZRXHRSEZNFU(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x866BD80", Offset = "0x866A780", VA = "0x18866BD80")]
		public static void PKRAAUJRYOJ(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8669CC0", Offset = "0x86686C0", VA = "0x188669CC0")]
		public static UnityEngine.Quaternion CQVRZWEPNDP(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MSHGOIDHWYJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MYCFVKCOBHO MYCFVKCOBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray JSLUQKNFIIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8662A20", Offset = "0x8661420", VA = "0x188662A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> TKDVLCVYXME
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xECCF90", Offset = "0xECB990", VA = "0x180ECCF90")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xF9DBB0", Offset = "0xF9C5B0", VA = "0x180F9DBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint GVPRWZNHLDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCE3800", Offset = "0xCE2200", VA = "0x180CE3800")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCE3460", Offset = "0xCE1E60", VA = "0x180CE3460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8662A30", Offset = "0x8661430", VA = "0x188662A30")]
		public MSHGOIDHWYJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86598D0", Offset = "0x86582D0", VA = "0x1886598D0")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8659930", Offset = "0x8658330", VA = "0x188659930")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class ACQUZEPHKTC
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class EVIVWDLZIBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> ZDBSPCRSKMF;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public EVIVWDLZIBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x86570B0", Offset = "0x8655AB0", VA = "0x1886570B0")]
			internal int? CQKYWCAKQTI(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8657200", Offset = "0x8655C00", VA = "0x188657200")]
			internal int? LUVDDZCDBVP(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8657130", Offset = "0x8655B30", VA = "0x188657130")]
			internal bool DOSTNTECBKF(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8653ED0", Offset = "0x86528D0", VA = "0x188653ED0")]
		private static void AQNSQEBRYAN(NumericArray a, MSHGOIDHWYJ b, MSHGOIDHWYJ c, MSHGOIDHWYJ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8654440", Offset = "0x8652E40", VA = "0x188654440")]
		public static void GRIFJUZXFJU(Dictionary<string, MSHGOIDHWYJ> a, Dictionary<string, (MSHGOIDHWYJ sparseIndices, MSHGOIDHWYJ sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8655DB0", Offset = "0x86547B0", VA = "0x188655DB0")]
		public static void ZEGOJMZILDI(Dictionary<string, MSHGOIDHWYJ> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8653DD0", Offset = "0x86527D0", VA = "0x188653DD0")]
		public static void AOQVCAFQXZH(MSHGOIDHWYJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8656290", Offset = "0x8654C90", VA = "0x188656290")]
		public static void ZPINEZGXRAB(Dictionary<string, List<MSHGOIDHWYJ>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86557E0", Offset = "0x86541E0", VA = "0x1886557E0")]
		private static void KZWFKYUUGUR(MSHGOIDHWYJ a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8655720", Offset = "0x8654120", VA = "0x188655720")]
		internal static void KZWFKYUUGUR(OUKRSZNVFOZ a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8655910", Offset = "0x8654310", VA = "0x188655910")]
		public static FOKAMTZKDHN MKPCQVJSBSZ(IEnumerable<FOKAMTZKDHN> a)
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
			[Cpp2IlInjected.Address(RVA = "0xF55B50", Offset = "0xF54550", VA = "0x180F55B50")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x15B3200", Offset = "0x15B1C00", VA = "0x1815B3200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30C2C60", Offset = "0x30C1660", VA = "0x1830C2C60")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30C2C70", Offset = "0x30C1670", VA = "0x1830C2C70")]
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
	public class FJFTNZJZCAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint XGCJQBBDTPP;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint REFFECWLWBJ;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint BPODXLTILCL;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8657C90", Offset = "0x8656690", VA = "0x188657C90")]
		public static void SLIFRFMHRDN(Stream a, [Out] GZYGZQSIZFV b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8657600", Offset = "0x8656000", VA = "0x188657600")]
		public static ChunkInfo ARYZBDPRVTB(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8657890", Offset = "0x8656290", VA = "0x188657890")]
		public static GLBHeader IKASUKXCYQF(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8657BD0", Offset = "0x86565D0", VA = "0x188657BD0")]
		public static bool RYBTHNJDIAB(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x86579D0", Offset = "0x86563D0", VA = "0x1886579D0")]
		public static ChunkInfo OQSJWTKYJPU(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8657E50", Offset = "0x8656850", VA = "0x188657E50")]
		private static void VMCKLOCZIAU(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8657B40", Offset = "0x8656540", VA = "0x188657B40")]
		private static uint PYKARMHVGDB(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UZUZIWPUQCU
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
		public PathElement PGCDERKHAWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCDD360", Offset = "0xCDBD60", VA = "0x180CDD360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int ONJFVMMXRGC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xDF2410", Offset = "0xDF0E10", VA = "0x180DF2410")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xDF2300", Offset = "0xDF0D00", VA = "0x180DF2300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string NZCTGTVHMGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IXUSALOKHHK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCD7520", Offset = "0xCD5F20", VA = "0x180CD7520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C40", Offset = "0xCD5640", VA = "0x180CD6C40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public UZUZIWPUQCU SIYONDEAFUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x866CBB0", Offset = "0x866B5B0", VA = "0x18866CBB0")]
		public string GRQTCHIPINS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x866CB90", Offset = "0x866B590", VA = "0x18866CB90")]
		public UZUZIWPUQCU CMZHFKNVOUE(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x866CE50", Offset = "0x866B850", VA = "0x18866CE50")]
		private UZUZIWPUQCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x866CEB0", Offset = "0x866B8B0", VA = "0x18866CEB0")]
		public UZUZIWPUQCU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5389980", Offset = "0x5388380", VA = "0x185389980")]
		[CompilerGenerated]
		internal static string FBXBEAELJXO(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x866CE10", Offset = "0x866B810", VA = "0x18866CE10")]
		[CompilerGenerated]
		internal static bool SPVYDMBJLFN([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x866CC30", Offset = "0x866B630", VA = "0x18866CC30")]
		[CompilerGenerated]
		internal static UZUZIWPUQCU JSQRDGNGWRP(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class OXTYCWNFFBX
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8662BD0", Offset = "0x86615D0", VA = "0x188662BD0")]
		public static int[] OGLVPCHDLIV(this GZYGZQSIZFV a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8662E70", Offset = "0x8661870", VA = "0x188662E70")]
		public static int[] OHEHITAVPZR(this GZYGZQSIZFV a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class LIDQVADFRSV
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8660F00", Offset = "0x865F900", VA = "0x188660F00")]
		public static uint FESDWAXYTAW(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream INZFQYIHQLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long RGWVNLQOTPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long RLUMZHWODVK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x86645E0", Offset = "0x8662FE0", VA = "0x1886645E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8664620", Offset = "0x8663020", VA = "0x188664620", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8664620", Offset = "0x8663020", VA = "0x188664620", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8664640", Offset = "0x8663040", VA = "0x188664640", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8664660", Offset = "0x8663060", VA = "0x188664660", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8664680", Offset = "0x8663080", VA = "0x188664680", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8664370", Offset = "0x8662D70", VA = "0x188664370")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x86641C0", Offset = "0x8662BC0", VA = "0x1886641C0", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8664290", Offset = "0x8662C90", VA = "0x188664290", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x86642F0", Offset = "0x8662CF0", VA = "0x1886642F0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8664200", Offset = "0x8662C00", VA = "0x188664200", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8664330", Offset = "0x8662D30", VA = "0x188664330", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8664130", Offset = "0x8662B30", VA = "0x188664130")]
		private void AQJDONZLMMB()
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
		public static Color QKIQGGAEXJL
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8657090", Offset = "0x8655A90", VA = "0x188657090")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color IIEVTCGKBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8657080", Offset = "0x8655A80", VA = "0x188657080")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color KLNPIKZEQNR
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8656DB0", Offset = "0x86557B0", VA = "0x188656DB0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2DD7240", Offset = "0x2DD5C40", VA = "0x182DD7240")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1855CE0", Offset = "0x18546E0", VA = "0x181855CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2E35770", Offset = "0x2E34170", VA = "0x182E35770")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2E35780", Offset = "0x2E34180", VA = "0x182E35780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BACE60", Offset = "0x2BAB860", VA = "0x182BACE60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x32BACE0", Offset = "0x32B96E0", VA = "0x1832BACE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x14F72D0", Offset = "0x14F5CD0", VA = "0x1814F72D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x14F72E0", Offset = "0x14F5CE0", VA = "0x1814F72E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EDF0", Offset = "0x2B6D7F0", VA = "0x182B6EDF0")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8656E80", Offset = "0x8655880", VA = "0x188656E80", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8656F30", Offset = "0x8655930", VA = "0x188656F30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8656FD0", Offset = "0x86559D0", VA = "0x188656FD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8656DD0", Offset = "0x86557D0", VA = "0x188656DD0")]
		public static bool AIMXGJJQCKF(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class XAGUPSXTOGN : IEquatable<XAGUPSXTOGN>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly XAGUPSXTOGN UOGZNKSPHUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] BNFHWICICNC;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float FNSCZPWUKJB
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x866DF00", Offset = "0x866C900", VA = "0x18866DF00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x866E410", Offset = "0x866CE10", VA = "0x18866E410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float APHEBFHHMPK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x866E080", Offset = "0x866CA80", VA = "0x18866E080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x866DF90", Offset = "0x866C990", VA = "0x18866DF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float TPAMXAMZPTT
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x866E260", Offset = "0x866CC60", VA = "0x18866E260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x866E170", Offset = "0x866CB70", VA = "0x18866E170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float NQRPLHYMGDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x866E3E0", Offset = "0x866CDE0", VA = "0x18866E3E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x866E2F0", Offset = "0x866CCF0", VA = "0x18866E2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FNXJWWQRTUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x866DF60", Offset = "0x866C960", VA = "0x18866DF60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x866E470", Offset = "0x866CE70", VA = "0x18866E470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float APWYSZOZOXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x866E0B0", Offset = "0x866CAB0", VA = "0x18866E0B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x866DFC0", Offset = "0x866C9C0", VA = "0x18866DFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float TOKSFGFHNLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x866E230", Offset = "0x866CC30", VA = "0x18866E230")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x866E140", Offset = "0x866CB40", VA = "0x18866E140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NQMIOBEOWSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x866E380", Offset = "0x866CD80", VA = "0x18866E380")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x866E290", Offset = "0x866CC90", VA = "0x18866E290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float FOCQUDKPDFT
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x866DF30", Offset = "0x866C930", VA = "0x18866DF30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x866E440", Offset = "0x866CE40", VA = "0x18866E440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float APRRVSVCFMC
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x866E0E0", Offset = "0x866CAE0", VA = "0x18866E0E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x866DFF0", Offset = "0x866C9F0", VA = "0x18866DFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float TOPZCMZEWXB
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x866E200", Offset = "0x866CC00", VA = "0x18866E200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x866E110", Offset = "0x866CB10", VA = "0x18866E110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float NQHBQUKRNHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x866E3B0", Offset = "0x866CDB0", VA = "0x18866E3B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x866E2C0", Offset = "0x866CCC0", VA = "0x18866E2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float FOHXRKEMMRC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x866DED0", Offset = "0x866C8D0", VA = "0x18866DED0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x866E4A0", Offset = "0x866CEA0", VA = "0x18866E4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float AQHMNNCUHUD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x866E050", Offset = "0x866CA50", VA = "0x18866E050")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x866E020", Offset = "0x866CA20", VA = "0x18866E020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float TOAEKSRMUPA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x866E1D0", Offset = "0x866CBD0", VA = "0x18866E1D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x866E1A0", Offset = "0x866CBA0", VA = "0x18866E1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float NQBUTNQUDVT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x866E350", Offset = "0x866CD50", VA = "0x18866E350")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x866E320", Offset = "0x866CD20", VA = "0x18866E320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x866E5B0", Offset = "0x866CFB0", VA = "0x18866E5B0")]
		public XAGUPSXTOGN(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x866DC10", Offset = "0x866C610", VA = "0x18866DC10", Slot = "4")]
		public bool Equals(XAGUPSXTOGN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x866DB10", Offset = "0x866C510", VA = "0x18866DB10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x10C8B70", Offset = "0x10C7570", VA = "0x1810C8B70", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DD7240", Offset = "0x2DD5C40", VA = "0x182DD7240")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x1855CE0", Offset = "0x18546E0", VA = "0x181855CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2E35770", Offset = "0x2E34170", VA = "0x182E35770")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2E35780", Offset = "0x2E34180", VA = "0x182E35780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2BACE60", Offset = "0x2BAB860", VA = "0x182BACE60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32BACE0", Offset = "0x32B96E0", VA = "0x1832BACE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x14F72D0", Offset = "0x14F5CD0", VA = "0x1814F72D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x14F72E0", Offset = "0x14F5CE0", VA = "0x1814F72E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8663B30", Offset = "0x8662530", VA = "0x188663B30")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8663800", Offset = "0x8662200", VA = "0x188663800", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8663920", Offset = "0x8662320", VA = "0x188663920", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x86639D0", Offset = "0x86623D0", VA = "0x1886639D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8663790", Offset = "0x8662190", VA = "0x188663790")]
		public static bool AIMXGJJQCKF(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DD7240", Offset = "0x2DD5C40", VA = "0x182DD7240")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1855CE0", Offset = "0x18546E0", VA = "0x181855CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2E35770", Offset = "0x2E34170", VA = "0x182E35770")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2E35780", Offset = "0x2E34180", VA = "0x182E35780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x103B560", Offset = "0x1039F60", VA = "0x18103B560")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x866D370", Offset = "0x866BD70", VA = "0x18866D370")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x866D1E0", Offset = "0x866BBE0", VA = "0x18866D1E0", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x866D240", Offset = "0x866BC40", VA = "0x18866D240", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x866D320", Offset = "0x866BD20", VA = "0x18866D320", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x866D180", Offset = "0x866BB80", VA = "0x18866D180")]
		public static bool AIMXGJJQCKF(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DD7240", Offset = "0x2DD5C40", VA = "0x182DD7240")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1855CE0", Offset = "0x18546E0", VA = "0x181855CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2E35770", Offset = "0x2E34170", VA = "0x182E35770")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2E35780", Offset = "0x2E34180", VA = "0x182E35780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2BACE60", Offset = "0x2BAB860", VA = "0x182BACE60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32BACE0", Offset = "0x32B96E0", VA = "0x1832BACE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x866D730", Offset = "0x866C130", VA = "0x18866D730")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x866D400", Offset = "0x866BE00", VA = "0x18866D400", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x866D4E0", Offset = "0x866BEE0", VA = "0x18866D4E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x866D5A0", Offset = "0x866BFA0", VA = "0x18866D5A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x866D390", Offset = "0x866BD90", VA = "0x18866D390")]
		public static bool AIMXGJJQCKF(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DD7240", Offset = "0x2DD5C40", VA = "0x182DD7240")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1855CE0", Offset = "0x18546E0", VA = "0x181855CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E35770", Offset = "0x2E34170", VA = "0x182E35770")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2E35780", Offset = "0x2E34180", VA = "0x182E35780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2BACE60", Offset = "0x2BAB860", VA = "0x182BACE60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x32BACE0", Offset = "0x32B96E0", VA = "0x1832BACE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x14F72D0", Offset = "0x14F5CD0", VA = "0x1814F72D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x14F72E0", Offset = "0x14F5CE0", VA = "0x1814F72E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EDF0", Offset = "0x2B6D7F0", VA = "0x182B6EDF0")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8656E80", Offset = "0x8655880", VA = "0x188656E80", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x866D7B0", Offset = "0x866C1B0", VA = "0x18866D7B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8656FD0", Offset = "0x86559D0", VA = "0x188656FD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class IOVWSMKPNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x865A500", Offset = "0x8658F00", VA = "0x18865A500")]
		public static void IPHWZZIHEJO(this JObject a, string b, ZWTHYTPYMLD c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class LIDQVADFRSV
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8660D50", Offset = "0x865F750", VA = "0x188660D50")]
		public static List<string> EKUEJPTPTOH(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x86618D0", Offset = "0x86602D0", VA = "0x1886618D0")]
		public static List<double> UIXLZEKYHSL(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x86608B0", Offset = "0x865F2B0", VA = "0x1886608B0")]
		public static List<int> AGUIGRRDQSC(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3BD05F0", Offset = "0x3BCEFF0", VA = "0x183BD05F0")]
		public static List<a> CMARJVDOIXE<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8661050", Offset = "0x865FA50", VA = "0x188661050")]
		public static ZWTHYTPYMLD ILYGWPCRWZC(this JToken a, GZYGZQSIZFV b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8662410", Offset = "0x8660E10", VA = "0x188662410")]
		public static int YBGAJEZXCZM(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8662550", Offset = "0x8660F50", VA = "0x188662550")]
		public static double YNUDVCRQBRS(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8660A70", Offset = "0x865F470", VA = "0x188660A70")]
		public static GLTF.Math.Color BUIMUFIWYMD(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8661A90", Offset = "0x8660490", VA = "0x188661A90")]
		public static GLTF.Math.Color UOWDFYQCVRS(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8661D00", Offset = "0x8660700", VA = "0x188661D00")]
		public static GLTF.Math.Color WSFUUXIQSVW(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8661300", Offset = "0x865FD00", VA = "0x188661300")]
		public static GLTF.Math.Vector3 OXFHCSBXMYO(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8661FA0", Offset = "0x86609A0", VA = "0x188661FA0")]
		public static GLTF.Math.Vector2 XQWOZSNRZQM(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x86621B0", Offset = "0x8660BB0", VA = "0x1886621B0")]
		public static GLTF.Math.Vector3 XRBVWZHPJBV(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x86615C0", Offset = "0x865FFC0", VA = "0x1886615C0")]
		public static GLTF.Math.Quaternion REKWBJUBMFY(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0C90", Offset = "0x3BCF690", VA = "0x183BD0C90")]
		public static Dictionary<string, b> RXGXNGORAFE<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0940", Offset = "0x3BCF340", VA = "0x183BD0940")]
		public static c EUFASNPYKTA<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public OUKRSZNVFOZ bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8657450", Offset = "0x8655E50", VA = "0x188657450", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x86573D0", Offset = "0x8655DD0", VA = "0x1886573D0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class PYNUMMECXXK : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8663610", Offset = "0x8662010", VA = "0x188663610")]
		public PYNUMMECXXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8663540", Offset = "0x8661F40", VA = "0x188663540", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, MYCFVKCOBHO> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8657290", Offset = "0x8655C90", VA = "0x188657290", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8657350", Offset = "0x8655D50", VA = "0x188657350")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class YHDDRJKEDCS : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class VUGRTXXDLRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public GZYGZQSIZFV JBSQCTQPIEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader IFBKURMFJRT;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x866D060", Offset = "0x866BA60", VA = "0x18866D060")]
			internal MYCFVKCOBHO GLHKTQZGMNL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x866EE10", Offset = "0x866D810", VA = "0x18866EE10")]
		public YHDDRJKEDCS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x866EC80", Offset = "0x866D680", VA = "0x18866EC80", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public GNIRBFJHUPY CJYRBJQEHHJ;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public EXT_texture_exr(GNIRBFJHUPY source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x86574A0", Offset = "0x8655EA0", VA = "0x1886574A0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8657510", Offset = "0x8655F10", VA = "0x188657510", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class OUWOVHFEZXJ : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8662B80", Offset = "0x8661580", VA = "0x188662B80")]
		public OUWOVHFEZXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8662A60", Offset = "0x8661460", VA = "0x188662A60", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
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
	public class AudioEmitterId : WBOYLTFHPHT<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8656AD0", Offset = "0x86554D0", VA = "0x188656AD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8656A90", Offset = "0x8655490", VA = "0x188656A90")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : WBOYLTFHPHT<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8656C60", Offset = "0x8655660", VA = "0x188656C60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8656C20", Offset = "0x8655620", VA = "0x188656C20")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : WBOYLTFHPHT<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8656940", Offset = "0x8655340", VA = "0x188656940", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8656900", Offset = "0x8655300", VA = "0x188656900")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8656820", Offset = "0x8655220", VA = "0x188656820")]
		public static AudioDataId Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x865CDC0", Offset = "0x865B7C0", VA = "0x18865CDC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x865C9C0", Offset = "0x865B3C0", VA = "0x18865C9C0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x865CA30", Offset = "0x865B430", VA = "0x18865CA30")]
		public static KHR_SceneAudioEmittersRef Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x865D020", Offset = "0x865BA20", VA = "0x18865D020")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x865C990", Offset = "0x865B390", VA = "0x18865C990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x865C870", Offset = "0x865B270", VA = "0x18865C870", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x865C660", Offset = "0x865B060", VA = "0x18865C660", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x865C6D0", Offset = "0x865B0D0", VA = "0x18865C6D0")]
		public static KHR_NodeAudioEmitterRef Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class KEBSFJDWBTA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string KFVEZVVJMGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? UPJXFKUYWGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? ABNBEKPKRNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? OIRKJMSXLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? VTYAMNAWRIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? ILHLFXJNIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? IMVIGKOEGTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? IEWSJDYXVMV;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x865AAA0", Offset = "0x86594A0", VA = "0x18865AAA0")]
		public JObject BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x865AD10", Offset = "0x8659710", VA = "0x18865AD10")]
		public static KEBSFJDWBTA Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public KEBSFJDWBTA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : XMYPCEGPQJZ
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
		public KEBSFJDWBTA positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x865B7B0", Offset = "0x865A1B0", VA = "0x18865B7B0", Slot = "5")]
		public virtual JObject BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x865BB50", Offset = "0x865A550", VA = "0x18865BB50")]
		public static KHR_AudioEmitter Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x865C050", Offset = "0x865AA50", VA = "0x18865C050")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : XMYPCEGPQJZ
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
		[Cpp2IlInjected.Address(RVA = "0x865C0D0", Offset = "0x865AAD0", VA = "0x18865C0D0")]
		public JObject BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x865C300", Offset = "0x865AD00", VA = "0x18865C300")]
		public static KHR_AudioSource Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x865B7A0", Offset = "0x865A1A0", VA = "0x18865B7A0")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public OWILLSWHPZG bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x865B410", Offset = "0x8659E10", VA = "0x18865B410")]
		public JObject BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x865B540", Offset = "0x8659F40", VA = "0x18865B540")]
		public static KHR_AudioData Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x865B7A0", Offset = "0x865A1A0", VA = "0x18865B7A0")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : LOPDDMPFOVQ
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
		[Cpp2IlInjected.Address(RVA = "0x865D2E0", Offset = "0x865BCE0", VA = "0x18865D2E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x865D250", Offset = "0x865BC50", VA = "0x18865D250", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x865DA10", Offset = "0x865C410", VA = "0x18865DA10")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class FQXTBSEPWKZ : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8658D10", Offset = "0x8657710", VA = "0x188658D10")]
		public FQXTBSEPWKZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8658160", Offset = "0x8656B60", VA = "0x188658160", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public OWILLSWHPZG bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x865DBE0", Offset = "0x865C5E0", VA = "0x18865DBE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x865DB20", Offset = "0x865C520", VA = "0x18865DB20", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x865DC30", Offset = "0x865C630", VA = "0x18865DC30")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class ZGXZYSFPDWH : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class VUGRTXXDLRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader IFBKURMFJRT;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x866D110", Offset = "0x866BB10", VA = "0x18866D110")]
			internal int GLHKTQZGMNL()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x866F070", Offset = "0x866DA70", VA = "0x18866F070")]
		public ZGXZYSFPDWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x866EE60", Offset = "0x866D860", VA = "0x18866EE60", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public ZWTHYTPYMLD anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x865DD30", Offset = "0x865C730", VA = "0x18865DD30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x865DCB0", Offset = "0x865C6B0", VA = "0x18865DCB0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class LKLZEUJQUUQ : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8662840", Offset = "0x8661240", VA = "0x188662840")]
		public LKLZEUJQUUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8662690", Offset = "0x8661090", VA = "0x188662690", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public ZWTHYTPYMLD clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public ZWTHYTPYMLD clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public ZWTHYTPYMLD clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x865DFE0", Offset = "0x865C9E0", VA = "0x18865DFE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x865DF40", Offset = "0x865C940", VA = "0x18865DF40", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class PTBBUIEIYBC : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x86634F0", Offset = "0x8661EF0", VA = "0x1886634F0")]
		public PTBBUIEIYBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8663270", Offset = "0x8661C70", VA = "0x188663270", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x865E340", Offset = "0x865CD40", VA = "0x18865E340", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x865E2D0", Offset = "0x865CCD0", VA = "0x18865E2D0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class ZXWRMSOWFAG : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x866F4D0", Offset = "0x866DED0", VA = "0x18866F4D0")]
		public ZXWRMSOWFAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x866F400", Offset = "0x866DE00", VA = "0x18866F400", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : TMNXRDPPTYC, LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float MWHTUDTGRQY;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x865E690", Offset = "0x865D090", VA = "0x18865E690")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x865E620", Offset = "0x865D020", VA = "0x18865E620")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, GZYGZQSIZFV root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x865E460", Offset = "0x865CE60", VA = "0x18865E460", Slot = "6")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x865E500", Offset = "0x865CF00", VA = "0x18865E500", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class LDVQKQKWZVB : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8660860", Offset = "0x865F260", VA = "0x188660860")]
		public LDVQKQKWZVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8660760", Offset = "0x865F160", VA = "0x188660760", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x865E740", Offset = "0x865D140", VA = "0x18865E740", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x865E6E0", Offset = "0x865D0E0", VA = "0x18865E6E0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x865E890", Offset = "0x865D290", VA = "0x18865E890")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class RKNYFZMKVIQ : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8663C90", Offset = "0x8662690", VA = "0x188663C90")]
		public RKNYFZMKVIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8663BC0", Offset = "0x86625C0", VA = "0x188663BC0", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public ZWTHYTPYMLD iridescenceTexture;

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
		public ZWTHYTPYMLD iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x865E940", Offset = "0x865D340", VA = "0x18865E940", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x865E8A0", Offset = "0x865D2A0", VA = "0x18865E8A0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x865ED00", Offset = "0x865D700", VA = "0x18865ED00")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class ZHNUFUWWJKK : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x866F3B0", Offset = "0x866DDB0", VA = "0x18866F3B0")]
		public ZHNUFUWWJKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x866F0C0", Offset = "0x866DAC0", VA = "0x18866F0C0", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class HDYNHITMCGR : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 CCDTGOYJACP;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double CXNHPOUYWVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color CIPUSQFNILZ;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color LWBWBNPCVKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public ZWTHYTPYMLD IYBDHAYEGBN;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly ZWTHYTPYMLD CDCNATPDWEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 NFGVLHZTFQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double KHKKUDKUKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public ZWTHYTPYMLD KZUKJDKGDLS;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly ZWTHYTPYMLD DHMOQTVSYOI;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x865A400", Offset = "0x8658E00", VA = "0x18865A400")]
		public HDYNHITMCGR(GLTF.Math.Color a, ZWTHYTPYMLD b, GLTF.Math.Vector3 c, double d, ZWTHYTPYMLD e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8659AE0", Offset = "0x86584E0", VA = "0x188659AE0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8659CA0", Offset = "0x86586A0", VA = "0x188659CA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class GBUZWYOBVLT : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x86590C0", Offset = "0x8657AC0", VA = "0x1886590C0")]
		public GBUZWYOBVLT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8658D60", Offset = "0x8657760", VA = "0x188658D60", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public ZWTHYTPYMLD sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public ZWTHYTPYMLD sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x865EDF0", Offset = "0x865D7F0", VA = "0x18865EDF0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x865ED20", Offset = "0x865D720", VA = "0x18865ED20", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x865F300", Offset = "0x865DD00", VA = "0x18865F300")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class PFOTUENXAOD : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8663220", Offset = "0x8661C20", VA = "0x188663220")]
		public PFOTUENXAOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8662FC0", Offset = "0x86619C0", VA = "0x188662FC0", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public ZWTHYTPYMLD specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public ZWTHYTPYMLD specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x865F440", Offset = "0x865DE40", VA = "0x18865F440", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x865F370", Offset = "0x865DD70", VA = "0x18865F370", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x865F950", Offset = "0x865E350", VA = "0x18865F950")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class XXWKNJFJZVH : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x866EA80", Offset = "0x866D480", VA = "0x18866EA80")]
		public XXWKNJFJZVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x866E860", Offset = "0x866D260", VA = "0x18866E860", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public ZWTHYTPYMLD transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x865FA40", Offset = "0x865E440", VA = "0x18865FA40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x865F9C0", Offset = "0x865E3C0", VA = "0x18865F9C0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class LVMXWYFIQZW : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x86629D0", Offset = "0x86613D0", VA = "0x1886629D0")]
		public LVMXWYFIQZW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8662890", Offset = "0x8661290", VA = "0x188662890", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class WMFDSLCGQUV : TMNXRDPPTYC, LOPDDMPFOVQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x866DA50", Offset = "0x866C450", VA = "0x18866DA50")]
		public WMFDSLCGQUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x866DAA0", Offset = "0x866C4A0", VA = "0x18866DAA0")]
		public WMFDSLCGQUV(WMFDSLCGQUV a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x866D8E0", Offset = "0x866C2E0", VA = "0x18866D8E0", Slot = "6")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x866D850", Offset = "0x866C250", VA = "0x18866D850", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x866D980", Offset = "0x866C380", VA = "0x18866D980", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class IPZWLQVODPT : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x865A600", Offset = "0x8659000", VA = "0x18865A600")]
		public IPZWLQVODPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x865A580", Offset = "0x8658F80", VA = "0x18865A580", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public ZWTHYTPYMLD thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x865FC60", Offset = "0x865E660", VA = "0x18865FC60", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x865FBD0", Offset = "0x865E5D0", VA = "0x18865FBD0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8660190", Offset = "0x865EB90", VA = "0x188660190")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class SZIEIUOPCRE : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x86640E0", Offset = "0x8662AE0", VA = "0x1886640E0")]
		public SZIEIUOPCRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8663ED0", Offset = "0x86628D0", VA = "0x188663ED0", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8660210", Offset = "0x865EC10", VA = "0x188660210", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x86601B0", Offset = "0x865EBB0", VA = "0x1886601B0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x121B2A0", Offset = "0x1219CA0", VA = "0x18121B2A0")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class UANFVGMRTWK : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8664810", Offset = "0x8663210", VA = "0x188664810")]
		public UANFVGMRTWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8664730", Offset = "0x8663130", VA = "0x188664730", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8660380", Offset = "0x865ED80", VA = "0x188660380", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8660320", Offset = "0x865ED20", VA = "0x188660320", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x121B2A0", Offset = "0x1219CA0", VA = "0x18121B2A0")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class JCAQAMUYTGC : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x865A730", Offset = "0x8659130", VA = "0x18865A730")]
		public JCAQAMUYTGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x865A650", Offset = "0x8659050", VA = "0x18865A650", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x86604F0", Offset = "0x865EEF0", VA = "0x1886604F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8660490", Offset = "0x865EE90", VA = "0x188660490", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x121B2A0", Offset = "0x1219CA0", VA = "0x18121B2A0")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class QIWIWYENPXI : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8663740", Offset = "0x8662140", VA = "0x188663740")]
		public QIWIWYENPXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8663660", Offset = "0x8662060", VA = "0x188663660", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public GNIRBFJHUPY source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public KHR_texture_basisu(GNIRBFJHUPY source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8660600", Offset = "0x865F000", VA = "0x188660600", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8660670", Offset = "0x865F070", VA = "0x188660670", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class YGOMDIPINLE : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x866EC30", Offset = "0x866D630", VA = "0x18866EC30")]
		public YGOMDIPINLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x866EAD0", Offset = "0x866D4D0", VA = "0x18866EAD0", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class GEAORXGMOBL : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 GVPRWZNHLDP;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 WQIDCWVLNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double LXYOOPRPYCA;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double WDSFJOEFFQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 XOJMVANENPK;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 GMSNVYCDQEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? WPMEZSEFMAQ;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int XZCMZPFNIDI;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8659850", Offset = "0x8658250", VA = "0x188659850")]
		public GEAORXGMOBL(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8659110", Offset = "0x8657B10", VA = "0x188659110", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x86591F0", Offset = "0x8657BF0", VA = "0x1886591F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class JMLSMVEOVEJ : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x865AA50", Offset = "0x8659450", VA = "0x18865AA50")]
		public JMLSMVEOVEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x865A780", Offset = "0x8659180", VA = "0x18865A780", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class ROOCTVXZTNL : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> LZPAJLNXJKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public ROOCTVXZTNL(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8663CE0", Offset = "0x86626E0", VA = "0x188663CE0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8663DE0", Offset = "0x86627E0", VA = "0x188663DE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8663D50", Offset = "0x8662750", VA = "0x188663D50")]
		public List<double> SCXIYEBWVDN(SIDFNDXEBQO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class GYLDDGXHLQF : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8659A90", Offset = "0x8658490", VA = "0x188659A90")]
		public GYLDDGXHLQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8659990", Offset = "0x8658390", VA = "0x188659990", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class UDJEVNZXQWJ : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public OWILLSWHPZG OUKRSZNVFOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint YGITILEMUYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType SHBCRHYSWKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool ATZSLQMTHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint AGNSAISSRJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType UXYUOXCBTLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> KTBAPWAEUYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> MTFTYCRPHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public FRJLFWBSTDT JIUQVVIAZUW;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x865B7A0", Offset = "0x865A1A0", VA = "0x18865B7A0")]
		public UDJEVNZXQWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8665AD0", Offset = "0x86644D0", VA = "0x188665AD0")]
		public static UDJEVNZXQWJ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8664E10", Offset = "0x8663810", VA = "0x188664E10", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x86673E0", Offset = "0x8665DE0", VA = "0x1886673E0")]
		private unsafe static sbyte LDLTPHKLEYI(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8668030", Offset = "0x8666A30", VA = "0x188668030")]
		private unsafe static float2 PNYUXORZOKC(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x86653F0", Offset = "0x8663DF0", VA = "0x1886653F0")]
		private unsafe static float3 BSCIPADZDVN(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8667EB0", Offset = "0x86668B0", VA = "0x188667EB0")]
		private unsafe static float4 OKKYVZKIVTK(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8667240", Offset = "0x8665C40", VA = "0x188667240")]
		private unsafe static float4x4 KSUOUATTRJS(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x86673E0", Offset = "0x8665DE0", VA = "0x1886673E0")]
		private unsafe static byte ZUDBBAYBNSR(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8667090", Offset = "0x8665A90", VA = "0x188667090")]
		private unsafe static float2 JPLBDFYHIQB(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8668FF0", Offset = "0x86679F0", VA = "0x188668FF0")]
		private unsafe static float3 ZNEXQRUKXQA(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8668090", Offset = "0x8666A90", VA = "0x188668090")]
		private unsafe static float4 QOBCAIXEPIX(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8669040", Offset = "0x8667A40", VA = "0x188669040")]
		private unsafe static float4x4 ZVQKBZYLUHB(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x86663C0", Offset = "0x8664DC0", VA = "0x1886663C0")]
		private unsafe static short LPOEYDHUIAM(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x86660A0", Offset = "0x8664AA0", VA = "0x1886660A0")]
		private unsafe static float2 ESHGTLJNXCC(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8667BB0", Offset = "0x86665B0", VA = "0x188667BB0")]
		private unsafe static float3 NLVVWXCUJPN(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8667B50", Offset = "0x8666550", VA = "0x188667B50")]
		private unsafe static float4 MVKCUQOEOWU(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8667C00", Offset = "0x8666600", VA = "0x188667C00")]
		private unsafe static float4x4 NYPZDKGJQJK(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x86663C0", Offset = "0x8664DC0", VA = "0x1886663C0")]
		private unsafe static ushort FEYNPYKMGKL(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8668060", Offset = "0x8666A60", VA = "0x188668060")]
		private unsafe static float2 QCMYUWQLJFZ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8666D90", Offset = "0x8665790", VA = "0x188666D90")]
		private unsafe static float3 HZMFXSMHKHU(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x86656C0", Offset = "0x86640C0", VA = "0x1886656C0")]
		private unsafe static float4x4 DCZNWTBIJCZ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x86663D0", Offset = "0x8664DD0", VA = "0x1886663D0")]
		private unsafe static float4 FTEHSJQYSXH(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x86682A0", Offset = "0x8666CA0", VA = "0x1886682A0")]
		private unsafe static uint TAYRNYOGQHQ(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x86663C0", Offset = "0x8664DC0", VA = "0x1886663C0")]
		private unsafe static ushort RGOPTALXYVJ(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8667230", Offset = "0x8665C30", VA = "0x188667230")]
		private unsafe static float KQRKKFBYANW(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x86680F0", Offset = "0x8666AF0", VA = "0x1886680F0")]
		private unsafe static float2 QXGXSCGPNTE(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8668280", Offset = "0x8666C80", VA = "0x188668280")]
		private unsafe static float3 SJOJSBCWQMT(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8666360", Offset = "0x8664D60", VA = "0x188666360")]
		private unsafe static float4 QINTWEULEWQ(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8665690", Offset = "0x8664090", VA = "0x188665690")]
		private unsafe static float4x4 CWLUVBYFJIE(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8666360", Offset = "0x8664D60", VA = "0x188666360")]
		private unsafe static float4 FDZPHEWQKPJ(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8666390", Offset = "0x8664D90", VA = "0x188666390")]
		private unsafe static float4 FDZPHEWQKPJ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8668DC0", Offset = "0x86677C0", VA = "0x188668DC0")]
		public static float3[] ZBAOWZOMPWW(UDJEVNZXQWJ a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8668AB0", Offset = "0x86674B0", VA = "0x188668AB0")]
		public static float3[] YQLQJRBASVE(UDJEVNZXQWJ a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x86670C0", Offset = "0x8665AC0", VA = "0x1886670C0")]
		public static uint[] KIFBZJEVFRF(UDJEVNZXQWJ a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8668160", Offset = "0x8666B60", VA = "0x188668160")]
		internal static void SGKYEISOYIA(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8665440", Offset = "0x8663E40", VA = "0x188665440")]
		public uint[] CPTQXWBHGKD(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8665860", Offset = "0x8664260", VA = "0x188665860")]
		public float[] DZANRGRCLIR(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x86660D0", Offset = "0x8664AD0", VA = "0x1886660D0")]
		public float2[] FAZIAHFCTNR(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8666DE0", Offset = "0x86657E0", VA = "0x188666DE0")]
		public float2[] JDGOMBXIFNL(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8667560", Offset = "0x8665F60", VA = "0x188667560")]
		public float3[] LMHOABMPDJU(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8666540", Offset = "0x8664F40", VA = "0x188666540")]
		public float3[] HJZTFPAHRNE(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x86682B0", Offset = "0x8666CB0", VA = "0x1886682B0")]
		public float4[] VPMPWWEUSON(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x86677E0", Offset = "0x86661E0", VA = "0x1886677E0")]
		public float4[] MBMZQCUVAYJ(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x86685F0", Offset = "0x8666FF0", VA = "0x1886685F0")]
		public float4[] WWEVFUBXEKK(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8666430", Offset = "0x8664E30", VA = "0x188666430")]
		public float3[] FWJBSCYPPER(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8667DA0", Offset = "0x86667A0", VA = "0x188667DA0")]
		public float3[] NZBDIUNLZDQ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8668520", Offset = "0x8666F20", VA = "0x188668520")]
		public float4[] VUQMWXWZEDC(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8668110", Offset = "0x8666B10", VA = "0x188668110")]
		public uint[] RLYWBUJCBQH(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8664860", Offset = "0x8663260", VA = "0x188664860")]
		public float4x4[] AZDXOFFZVGG(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8666BD0", Offset = "0x86655D0", VA = "0x188666BD0")]
		private unsafe static float4 HWJMARELKAE(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8666A50", Offset = "0x8665450", VA = "0x188666A50")]
		private unsafe static float4 HWJMARELKAE(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x86673F0", Offset = "0x8665DF0", VA = "0x1886673F0")]
		private unsafe static float4x4 LDUCXBZNDBH(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8666890", Offset = "0x8665290", VA = "0x188666890")]
		private unsafe static float4 HNYGBOKWJWB(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8665F30", Offset = "0x8664930", VA = "0x188665F30")]
		private unsafe static float3 EGHJEXMTSEG(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8668980", Offset = "0x8667380", VA = "0x188668980")]
		private unsafe static float2 XFHMYHPIHHJ(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8667F10", Offset = "0x8666910", VA = "0x188667F10")]
		private unsafe static uint OZTPDPVKJOO(void* a, uint b, GLTFComponentType c)
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
	public static class MAUXAKWUKLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x86785B0", Offset = "0x8676FB0", VA = "0x1886785B0")]
		public static int YYPLHEZYOHW(this GLTFAccessorAttributeType a)
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
	public class FRJLFWBSTDT : TMNXRDPPTYC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int AGNSAISSRJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public KQFQLFEXQFA INOEKSBIJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public BYWAVRKEUYT ETEBIJCPKXW;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x86731C0", Offset = "0x8671BC0", VA = "0x1886731C0")]
		public FRJLFWBSTDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8672EF0", Offset = "0x86718F0", VA = "0x188672EF0")]
		public static FRJLFWBSTDT Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8672DC0", Offset = "0x86717C0", VA = "0x188672DC0", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class KQFQLFEXQFA : TMNXRDPPTYC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public OWILLSWHPZG OUKRSZNVFOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int YGITILEMUYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType SHBCRHYSWKB;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8677840", Offset = "0x8676240", VA = "0x188677840")]
		public KQFQLFEXQFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8677560", Offset = "0x8675F60", VA = "0x188677560")]
		public static KQFQLFEXQFA Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8677420", Offset = "0x8675E20", VA = "0x188677420", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class BYWAVRKEUYT : TMNXRDPPTYC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public OWILLSWHPZG OUKRSZNVFOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int YGITILEMUYH;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8670450", Offset = "0x866EE50", VA = "0x188670450")]
		public BYWAVRKEUYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x86701D0", Offset = "0x866EBD0", VA = "0x1886701D0")]
		public static BYWAVRKEUYT Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x86700D0", Offset = "0x866EAD0", VA = "0x1886700D0", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class KKMAFFKJDUL : TMNXRDPPTYC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public GOCJGLTGXMV LLMMZKNLQZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public ZPCBEZLKRXQ GGCNVAVUSGT;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x86773D0", Offset = "0x8675DD0", VA = "0x1886773D0")]
		public KKMAFFKJDUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x86771E0", Offset = "0x8675BE0", VA = "0x1886771E0")]
		public static KKMAFFKJDUL Deserialize(GZYGZQSIZFV root, JsonReader reader, ABAJRTCMWQH anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x86770E0", Offset = "0x8675AE0", VA = "0x1886770E0", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class ZPCBEZLKRXQ : TMNXRDPPTYC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public FOKAMTZKDHN SIDFNDXEBQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string CEZWGVWVPKV;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8684CA0", Offset = "0x86836A0", VA = "0x188684CA0")]
		public static ZPCBEZLKRXQ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8684F00", Offset = "0x8683900", VA = "0x188684F00")]
		public ZPCBEZLKRXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8684B80", Offset = "0x8683580", VA = "0x188684B80", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
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
	public class GDYMUWMMRMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(GDYMUWMMRMB data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] XOKQPQPKCSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type HBTAGNTYRWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] RBSWUAQQYET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion UPYDHHAPYYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string LHDLGYEKGZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string OSJEQHSVZRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public MSHGOIDHWYJ MCCRVXBVXYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string YZMVJECWKZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string HWYLXHIMJKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public MSHGOIDHWYJ PKKOXCBIDQE;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x86732B0", Offset = "0x8671CB0", VA = "0x1886732B0")]
		public GDYMUWMMRMB()
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
	public class HEQRHAMLLIQ : TMNXRDPPTYC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public MYCFVKCOBHO YUCIFMBZNTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType ZVLERDZQVNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public MYCFVKCOBHO PNGQLQWEQUX;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8676B00", Offset = "0x8675500", VA = "0x188676B00")]
		public HEQRHAMLLIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x86768E0", Offset = "0x86752E0", VA = "0x1886768E0")]
		public static HEQRHAMLLIQ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8676770", Offset = "0x8675170", VA = "0x188676770", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class CHJNAHMOGXE : TMNXRDPPTYC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string MRZVTWJSOTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string AOEMRHCPYID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string VQEKOCBEAXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string NLWVRJGBZBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> ORKJNYWYUVY;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8670F90", Offset = "0x866F990", VA = "0x188670F90")]
		public CHJNAHMOGXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x86708C0", Offset = "0x866F2C0", VA = "0x1886708C0")]
		public static CHJNAHMOGXE Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x86704A0", Offset = "0x866EEA0", VA = "0x1886704A0", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8670F80", Offset = "0x866F980", VA = "0x188670F80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8670BE0", Offset = "0x866F5E0", VA = "0x188670BE0")]
		public string TRIXLILWIJE(bool a)
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
	public class OUKRSZNVFOZ : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public NXEAZIBWYCJ NMLBGQOSSYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint YGITILEMUYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint QHRVYLWYVHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint PONMAXVBIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget GGCNVAVUSGT;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8671910", Offset = "0x8670310", VA = "0x188671910")]
		public OUKRSZNVFOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x867B640", Offset = "0x867A040", VA = "0x18867B640")]
		public static OUKRSZNVFOZ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x867B430", Offset = "0x8679E30", VA = "0x18867B430", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class TFHPLWDVUAT : TMNXRDPPTYC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double JFVWTFWJRFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double EGMHQHRIFUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double WDWLBGMTCTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double LMUICDFUGJE;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x867F010", Offset = "0x867DA10", VA = "0x18867F010")]
		public TFHPLWDVUAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x867EC90", Offset = "0x867D690", VA = "0x18867EC90")]
		public static TFHPLWDVUAT Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x867EB20", Offset = "0x867D520", VA = "0x18867EB20", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class GLXELVQTGAV : TMNXRDPPTYC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double ZLPFSGXRMSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double NYTBWYNOLWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double WDWLBGMTCTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double LMUICDFUGJE;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8673900", Offset = "0x8672300", VA = "0x188673900")]
		public GLXELVQTGAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8673590", Offset = "0x8671F90", VA = "0x188673590")]
		public static GLXELVQTGAV Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8673400", Offset = "0x8671E00", VA = "0x188673400", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ABAJRTCMWQH : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class VUGRTXXDLRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public GZYGZQSIZFV JBSQCTQPIEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader IFBKURMFJRT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public ABAJRTCMWQH RQVWJGLMYKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<KKMAFFKJDUL> FWBJQZATRTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<HEQRHAMLLIQ> FVWCTSGWIII;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8684110", Offset = "0x8682B10", VA = "0x188684110")]
			internal KKMAFFKJDUL GLHKTQZGMNL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8684100", Offset = "0x8682B00", VA = "0x188684100")]
			internal HEQRHAMLLIQ GLCDWKFJDCC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<KKMAFFKJDUL> ULXEJZJQRTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<HEQRHAMLLIQ> UYQYOANEFRF;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x866F8C0", Offset = "0x866E2C0", VA = "0x18866F8C0")]
		public static ABAJRTCMWQH Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x866FC80", Offset = "0x866E680", VA = "0x18866FC80")]
		public ABAJRTCMWQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x866F520", Offset = "0x866DF20", VA = "0x18866F520", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class WCYSICVUSPP : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string RKKCSRKNJPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint QHRVYLWYVHG;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8671910", Offset = "0x8670310", VA = "0x188671910")]
		public WCYSICVUSPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8684280", Offset = "0x8682C80", VA = "0x188684280")]
		public static WCYSICVUSPP Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8684130", Offset = "0x8682B30", VA = "0x188684130", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class CPICCNBPKBO : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public TFHPLWDVUAT IJWKVALXNTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public GLXELVQTGAV GEPZENUPMHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType UXYUOXCBTLU;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8671910", Offset = "0x8670310", VA = "0x188671910")]
		public CPICCNBPKBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8671740", Offset = "0x8670140", VA = "0x188671740")]
		public static CPICCNBPKBO Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8671570", Offset = "0x866FF70", VA = "0x188671570", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
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
	public class XMYPCEGPQJZ : TMNXRDPPTYC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string EREWIERIFZH;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8671910", Offset = "0x8670310", VA = "0x188671910")]
		public XMYPCEGPQJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x86845D0", Offset = "0x8682FD0", VA = "0x1886845D0")]
		public XMYPCEGPQJZ(XMYPCEGPQJZ a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x86844E0", Offset = "0x8682EE0", VA = "0x1886844E0")]
		public new void BQPNWAQSTNL(GZYGZQSIZFV a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8684450", Offset = "0x8682E50", VA = "0x188684450", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class WBOYLTFHPHT<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int SGYXLDBUDMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public GZYGZQSIZFV XJMGIEKJBLY;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected WBOYLTFHPHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x85C3300", Offset = "0x85C1D00", VA = "0x1885C3300")]
		public WBOYLTFHPHT(WBOYLTFHPHT<a> a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x85C32D0", Offset = "0x85C1CD0", VA = "0x1885C32D0")]
		public void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class MYCFVKCOBHO : WBOYLTFHPHT<UDJEVNZXQWJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override UDJEVNZXQWJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x8679280", Offset = "0x8677C80", VA = "0x188679280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8679240", Offset = "0x8677C40", VA = "0x188679240")]
		public MYCFVKCOBHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x86791E0", Offset = "0x8677BE0", VA = "0x1886791E0")]
		public MYCFVKCOBHO(MYCFVKCOBHO a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8679100", Offset = "0x8677B00", VA = "0x188679100")]
		public static MYCFVKCOBHO Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class NXEAZIBWYCJ : WBOYLTFHPHT<WCYSICVUSPP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override WCYSICVUSPP Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x86795F0", Offset = "0x8677FF0", VA = "0x1886795F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x86795B0", Offset = "0x8677FB0", VA = "0x1886795B0")]
		public NXEAZIBWYCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x86794D0", Offset = "0x8677ED0", VA = "0x1886794D0")]
		public static NXEAZIBWYCJ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class OWILLSWHPZG : WBOYLTFHPHT<OUKRSZNVFOZ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override OUKRSZNVFOZ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x867BA10", Offset = "0x867A410", VA = "0x18867BA10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x867B9D0", Offset = "0x867A3D0", VA = "0x18867B9D0")]
		public OWILLSWHPZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x867B8F0", Offset = "0x867A2F0", VA = "0x18867B8F0")]
		public static OWILLSWHPZG Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class AHXSXSGLOUY : WBOYLTFHPHT<CPICCNBPKBO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override CPICCNBPKBO Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x866FE90", Offset = "0x866E890", VA = "0x18866FE90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x866FE50", Offset = "0x866E850", VA = "0x18866FE50")]
		public AHXSXSGLOUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x866FD70", Offset = "0x866E770", VA = "0x18866FD70")]
		public static AHXSXSGLOUY Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class GNIRBFJHUPY : WBOYLTFHPHT<LIJTJBKAUDO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override LIJTJBKAUDO Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x8673A80", Offset = "0x8672480", VA = "0x188673A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8673A40", Offset = "0x8672440", VA = "0x188673A40")]
		public GNIRBFJHUPY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8673960", Offset = "0x8672360", VA = "0x188673960")]
		public static GNIRBFJHUPY Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class FMTAGVZYQQW : WBOYLTFHPHT<RLXWJRYFKUW>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override RLXWJRYFKUW Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x8672970", Offset = "0x8671370", VA = "0x188672970", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8672930", Offset = "0x8671330", VA = "0x188672930")]
		public FMTAGVZYQQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x86728D0", Offset = "0x86712D0", VA = "0x1886728D0")]
		public FMTAGVZYQQW(FMTAGVZYQQW a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x86727F0", Offset = "0x86711F0", VA = "0x1886727F0")]
		public static FMTAGVZYQQW Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class FAPFUECQVDQ : WBOYLTFHPHT<MRVNGWGPAZI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override MRVNGWGPAZI Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x8672380", Offset = "0x8670D80", VA = "0x188672380", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8672340", Offset = "0x8670D40", VA = "0x188672340")]
		public FAPFUECQVDQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x8672260", Offset = "0x8670C60", VA = "0x188672260")]
		public static FAPFUECQVDQ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class FOKAMTZKDHN : WBOYLTFHPHT<SIDFNDXEBQO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override SIDFNDXEBQO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x8672D60", Offset = "0x8671760", VA = "0x188672D60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8672D20", Offset = "0x8671720", VA = "0x188672D20")]
		public FOKAMTZKDHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8672C40", Offset = "0x8671640", VA = "0x188672C40")]
		public static FOKAMTZKDHN Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x86729D0", Offset = "0x86713D0", VA = "0x1886729D0")]
		public static List<FOKAMTZKDHN> CMARJVDOIXE(GZYGZQSIZFV a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class NVEXEGYPDWP : WBOYLTFHPHT<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x8679470", Offset = "0x8677E70", VA = "0x188679470", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8679430", Offset = "0x8677E30", VA = "0x188679430")]
		public NVEXEGYPDWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8679350", Offset = "0x8677D50", VA = "0x188679350")]
		public static NVEXEGYPDWP Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class GOCJGLTGXMV : WBOYLTFHPHT<HEQRHAMLLIQ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public ABAJRTCMWQH ABAJRTCMWQH;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override HEQRHAMLLIQ Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x8673C20", Offset = "0x8672620", VA = "0x188673C20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8673BE0", Offset = "0x86725E0", VA = "0x188673BE0")]
		public GOCJGLTGXMV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8673AE0", Offset = "0x86724E0", VA = "0x188673AE0")]
		public static GOCJGLTGXMV Deserialize(GZYGZQSIZFV root, ABAJRTCMWQH anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class LYHUNAQFDFV : WBOYLTFHPHT<TJCMXEZHJBP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override TJCMXEZHJBP Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x8678550", Offset = "0x8676F50", VA = "0x188678550", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8678510", Offset = "0x8676F10", VA = "0x188678510")]
		public LYHUNAQFDFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8678430", Offset = "0x8676E30", VA = "0x188678430")]
		public static LYHUNAQFDFV Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class MOPGZYBCXCO : WBOYLTFHPHT<VOBIMAAHYOP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override VOBIMAAHYOP Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x8678730", Offset = "0x8677130", VA = "0x188678730", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x86786F0", Offset = "0x86770F0", VA = "0x1886786F0")]
		public MOPGZYBCXCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8678610", Offset = "0x8677010", VA = "0x188678610")]
		public static MOPGZYBCXCO Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class AXTSRHKTJDS : WBOYLTFHPHT<QSDNGVTLXBY>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override QSDNGVTLXBY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x8670070", Offset = "0x866EA70", VA = "0x188670070", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x866FFD0", Offset = "0x866E9D0", VA = "0x18866FFD0")]
		public AXTSRHKTJDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8670010", Offset = "0x866EA10", VA = "0x188670010")]
		public AXTSRHKTJDS(AXTSRHKTJDS a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x866FEF0", Offset = "0x866E8F0", VA = "0x18866FEF0")]
		public static AXTSRHKTJDS Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class FTEGDPPXEYP : WBOYLTFHPHT<VUGBFJSMLDX>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override VUGBFJSMLDX Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x8673250", Offset = "0x8671C50", VA = "0x188673250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8673210", Offset = "0x8671C10", VA = "0x188673210")]
		public FTEGDPPXEYP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class LIJTJBKAUDO : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string RKKCSRKNJPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string UCQAKRSQWIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public OWILLSWHPZG OUKRSZNVFOZ;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8671910", Offset = "0x8670310", VA = "0x188671910")]
		public LIJTJBKAUDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8677FA0", Offset = "0x86769A0", VA = "0x188677FA0")]
		public static LIJTJBKAUDO Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8677DD0", Offset = "0x86767D0", VA = "0x188677DD0", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class RLXWJRYFKUW : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public TXRBWBBJWFB TXRBWBBJWFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public QPAPJZNDHHQ IFEWBLMVVCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public FAZCGRNDBGA SIZLCRXBFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public OTLVMGECVFM LUKEHCGNAIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public ZWTHYTPYMLD DEKTFGYZSQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color MOARTVLPTDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode ECZONMPFJTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double HTHGBPGSNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool PRVRWBFISPO;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x867CF00", Offset = "0x867B900", VA = "0x18867CF00")]
		public RLXWJRYFKUW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x867C9F0", Offset = "0x867B3F0", VA = "0x18867C9F0")]
		public static RLXWJRYFKUW Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x867C590", Offset = "0x867AF90", VA = "0x18867C590", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
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
	public class MRVNGWGPAZI : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class ZMZGDOYHPIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public GZYGZQSIZFV JBSQCTQPIEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader IFBKURMFJRT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<OKMUISONBMQ> FWBJQZATRTR;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ZMZGDOYHPIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x8684B70", Offset = "0x8683570", VA = "0x188684B70")]
			internal OKMUISONBMQ GLHKTQZGMNL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<OKMUISONBMQ> XOAVCJMDQTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> LBRSITXHTFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> IDVCQFFKEVD;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8671910", Offset = "0x8670310", VA = "0x188671910")]
		public MRVNGWGPAZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8678D40", Offset = "0x8677740", VA = "0x188678D40")]
		public static MRVNGWGPAZI Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8678790", Offset = "0x8677190", VA = "0x188678790", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class TMNXRDPPTYC
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, SWSIXEMFKMD> ELFMDMCRHQX;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static NDEMAERGDYO SIZZVLXDEOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, LOPDDMPFOVQ> JXKVRUFVCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken WFVSGNNIIWB;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x867FCF0", Offset = "0x867E6F0", VA = "0x18867FCF0")]
		public static SWSIXEMFKMD ONSNBLTFMMG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8680460", Offset = "0x867EE60", VA = "0x188680460")]
		public static LOPDDMPFOVQ XTVNPYEWDQE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public TMNXRDPPTYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8680ED0", Offset = "0x867F8D0", VA = "0x188680ED0")]
		public TMNXRDPPTYC(TMNXRDPPTYC a, [Optional] GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x867F7D0", Offset = "0x867E1D0", VA = "0x18867F7D0")]
		public void BQPNWAQSTNL(GZYGZQSIZFV a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8680550", Offset = "0x867EF50", VA = "0x188680550")]
		public void YGTNVAGODSK(string a, LOPDDMPFOVQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x867FC00", Offset = "0x867E600", VA = "0x18867FC00")]
		private void IINCAVOSUAS(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x867FB40", Offset = "0x867E540", VA = "0x18867FB40")]
		private void GBXOISBLQCG(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x867FA80", Offset = "0x867E480", VA = "0x18867FA80")]
		private void DBCGIPOONAK(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x867FE80", Offset = "0x867E880", VA = "0x18867FE80")]
		internal static Dictionary<string, LOPDDMPFOVQ> SVNRLEPAFYH(GZYGZQSIZFV a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x867F450", Offset = "0x867DE50", VA = "0x18867F450", Slot = "4")]
		public virtual void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class GZYGZQSIZFV : TMNXRDPPTYC
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class JLGJIUGGAQO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public GZYGZQSIZFV JBSQCTQPIEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader KCNPHMZKJTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<UDJEVNZXQWJ> FWBJQZATRTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<ABAJRTCMWQH> FVWCTSGWIII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<WCYSICVUSPP> FWLXLMOOKQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<OUKRSZNVFOZ> FWGQOFURBFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<CPICCNBPKBO> FWWLGACJDNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<LIJTJBKAUDO> FWREITILUBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<RLXWJRYFKUW> FXGZANQDWJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<MRVNGWGPAZI> FXBSDGWGMYK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<SIDFNDXEBQO> FULGMWXOUGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> FUFZPQDRKVO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<TJCMXEZHJBP> BDJTSFRXKQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<VOBIMAAHYOP> BDPAPMLUUCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<QSDNGVTLXBY> BDUHMTFSDNQ;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public JLGJIUGGAQO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8676F30", Offset = "0x8675930", VA = "0x188676F30")]
			internal UDJEVNZXQWJ GLHKTQZGMNL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x8676F20", Offset = "0x8675920", VA = "0x188676F20")]
			internal ABAJRTCMWQH GLCDWKFJDCC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x8676F10", Offset = "0x8675910", VA = "0x188676F10")]
			internal WCYSICVUSPP GKWWZDLLTQT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x8676F00", Offset = "0x8675900", VA = "0x188676F00")]
			internal OUKRSZNVFOZ GKRQBWROKFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x8676EF0", Offset = "0x86758F0", VA = "0x188676EF0")]
			internal CPICCNBPKBO GKMJEPXRAUB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x8676EE0", Offset = "0x86758E0", VA = "0x188676EE0")]
			internal LIJTJBKAUDO GKHCHJDTRIS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x8676ED0", Offset = "0x86758D0", VA = "0x188676ED0")]
			internal RLXWJRYFKUW GKBVKCJWHXJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x8676EC0", Offset = "0x86758C0", VA = "0x188676EC0")]
			internal MRVNGWGPAZI GJWOMVPYYMA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x8676EB0", Offset = "0x86758B0", VA = "0x188676EB0")]
			internal SIDFNDXEBQO GJRHPOWBPAR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x8676EA0", Offset = "0x86758A0", VA = "0x188676EA0")]
			internal Sampler GJMASICEFPI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x8676F50", Offset = "0x8675950", VA = "0x188676F50")]
			internal TJCMXEZHJBP YCWEZYZRNPM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x86770D0", Offset = "0x8675AD0", VA = "0x1886770D0")]
			internal VOBIMAAHYOP YDBLXFTOXAV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x8676F40", Offset = "0x8675940", VA = "0x188676F40")]
			internal QSDNGVTLXBY YCLRFLLWUSU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> CSQNXCIPVRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> JKUVCWONXUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<UDJEVNZXQWJ> LZFPKGNWFDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<ABAJRTCMWQH> AYHJFYOZINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public CHJNAHMOGXE CHJNAHMOGXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<WCYSICVUSPP> IKZETZGFYRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<OUKRSZNVFOZ> LMKPCGNXRDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<CPICCNBPKBO> CRZKXXORKZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<LIJTJBKAUDO> EQMHXZGVEGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<RLXWJRYFKUW> EGKCYOUEISU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<MRVNGWGPAZI> OOJNYZCMFRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<SIDFNDXEBQO> YCPLIEHAKBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> UYQYOANEFRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public LYHUNAQFDFV VBNTNOORCAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<TJCMXEZHJBP> MPVXMLVNSPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<VOBIMAAHYOP> HLSRFSNBYVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<QSDNGVTLXBY> UKQRHNKMFBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<VUGBFJSMLDX> LOVNEIASBYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool RYBTHNJDIAB;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8676720", Offset = "0x8675120", VA = "0x188676720")]
		public GZYGZQSIZFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8676680", Offset = "0x8675080", VA = "0x188676680")]
		public TJCMXEZHJBP IIQQUUJFVFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8675830", Offset = "0x8674230", VA = "0x188675830")]
		public static GZYGZQSIZFV Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8673C80", Offset = "0x8672680", VA = "0x188673C80")]
		public void BGVSXQNQAUM(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class TJCMXEZHJBP : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<FOKAMTZKDHN> YCPLIEHAKBR;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8671910", Offset = "0x8670310", VA = "0x188671910")]
		public TJCMXEZHJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x867F2D0", Offset = "0x867DCD0", VA = "0x18867F2D0")]
		public static TJCMXEZHJBP Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x867F060", Offset = "0x867DA60", VA = "0x18867F060", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class QSDNGVTLXBY : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public NVEXEGYPDWP LLMMZKNLQZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public GNIRBFJHUPY FZJVWQQYTXZ;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8671910", Offset = "0x8670310", VA = "0x188671910")]
		public QSDNGVTLXBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x867C3C0", Offset = "0x867ADC0", VA = "0x18867C3C0")]
		public static QSDNGVTLXBY Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x867C250", Offset = "0x867AC50", VA = "0x18867C250", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class YIWUATQRVRB : VUGBFJSMLDX
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8671910", Offset = "0x8670310", VA = "0x188671910")]
		public YIWUATQRVRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8684890", Offset = "0x8683290", VA = "0x188684890", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class VUGBFJSMLDX : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string QJLGCTXOMRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color CBCKDNPVLOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string EQJHIWKHCLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float XISJRVXBPQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float YNCNEAHUGOP;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8671910", Offset = "0x8670310", VA = "0x188671910")]
		public VUGBFJSMLDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8683E80", Offset = "0x8682880", VA = "0x188683E80", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class YUTNKNPDNZD : VUGBFJSMLDX
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8671910", Offset = "0x8670310", VA = "0x188671910")]
		public YUTNKNPDNZD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8684890", Offset = "0x8683290", VA = "0x188684890", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class HXKTOYRHGKF : VUGBFJSMLDX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float JOYCGKLCIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float LZQKFQCHLDP;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8676E50", Offset = "0x8675850", VA = "0x188676E50")]
		public HXKTOYRHGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8676B50", Offset = "0x8675550", VA = "0x188676B50", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface HRWOUDTNEXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CXHADNHHRJJ(GZYGZQSIZFV a, UZUZIWPUQCU b, [Out] GDYMUWMMRMB c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface LOPDDMPFOVQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LOPDDMPFOVQ Clone(GZYGZQSIZFV root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class SWSIXEMFKMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string GXBJMQFTAWY;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected SWSIXEMFKMD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class GIIDQZBZLNG : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty VKALUMMNXRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8673350", Offset = "0x8671D50", VA = "0x188673350", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public GIIDQZBZLNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class NDEMAERGDYO : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x86792E0", Offset = "0x8677CE0", VA = "0x1886792E0", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public NDEMAERGDYO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class QPAPJZNDHHQ : TMNXRDPPTYC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color KIICGJVBUEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public ZWTHYTPYMLD GYOJDUUGKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color JPCPUUMQNPV;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x867C1E0", Offset = "0x867ABE0", VA = "0x18867C1E0")]
		public QPAPJZNDHHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x867BF40", Offset = "0x867A940", VA = "0x18867BF40")]
		public static QPAPJZNDHHQ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x867BCE0", Offset = "0x867A6E0", VA = "0x18867BCE0", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class FAZCGRNDBGA : ZWTHYTPYMLD
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string HRDKCGBJZXC = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double XOJMVANENPK;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8672790", Offset = "0x8671190", VA = "0x188672790")]
		public FAZCGRNDBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x86724A0", Offset = "0x8670EA0", VA = "0x1886724A0")]
		public new static FAZCGRNDBGA Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x86723E0", Offset = "0x8670DE0", VA = "0x1886723E0", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class OTLVMGECVFM : ZWTHYTPYMLD
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string TWAFMIMXSUX = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double TJXBNQGUQDR;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8672790", Offset = "0x8671190", VA = "0x188672790")]
		public OTLVMGECVFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x867B140", Offset = "0x8679B40", VA = "0x18867B140")]
		public new static OTLVMGECVFM Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x867B080", Offset = "0x8679A80", VA = "0x18867B080", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class TXRBWBBJWFB : TMNXRDPPTYC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color INASAUYMYZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public ZWTHYTPYMLD RBTHENXJSJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double VZWVRCEXTAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double HTWHTPKKOHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public ZWTHYTPYMLD FJNBOUVGEHM;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x86817C0", Offset = "0x86801C0", VA = "0x1886817C0")]
		public TXRBWBBJWFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8681450", Offset = "0x867FE50", VA = "0x188681450")]
		public static TXRBWBBJWFB Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x86811C0", Offset = "0x867FBC0", VA = "0x1886811C0", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class OKMUISONBMQ : TMNXRDPPTYC
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class LRWMZSOUZIR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader IFBKURMFJRT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public GZYGZQSIZFV JBSQCTQPIEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<MYCFVKCOBHO> FWBJQZATRTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<MYCFVKCOBHO> FWLXLMOOKQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, MYCFVKCOBHO>> FVWCTSGWIII;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public LRWMZSOUZIR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x8678360", Offset = "0x8676D60", VA = "0x188678360")]
			internal MYCFVKCOBHO GLHKTQZGMNL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x86782B0", Offset = "0x8676CB0", VA = "0x1886782B0")]
			internal Dictionary<string, MYCFVKCOBHO> GLCDWKFJDCC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x86781E0", Offset = "0x8676BE0", VA = "0x1886781E0")]
			internal MYCFVKCOBHO GKWWZDLLTQT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, MYCFVKCOBHO> CTMEUSHPFQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public MYCFVKCOBHO INOEKSBIJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public FMTAGVZYQQW EEQKTWQVTXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode HBFTZFMHXCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, MYCFVKCOBHO>> GDKAYGPCBNG;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x867AFE0", Offset = "0x86799E0", VA = "0x18867AFE0")]
		public OKMUISONBMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x867A940", Offset = "0x8679340", VA = "0x18867A940")]
		public OKMUISONBMQ(OKMUISONBMQ a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x867A760", Offset = "0x8679160", VA = "0x18867A760")]
		public static int[] VCHXSZQTNNY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8679650", Offset = "0x8678050", VA = "0x188679650")]
		public static int[] APHWNFRFMNA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x867A5A0", Offset = "0x8678FA0", VA = "0x18867A5A0")]
		public static int[] UYXZRLPOJRO(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x867A2F0", Offset = "0x8678CF0", VA = "0x18867A2F0")]
		public static int[] NLFPDXBANAE(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x867A800", Offset = "0x8679200", VA = "0x18867A800")]
		public static int[] XNOBACDULFR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x867A530", Offset = "0x8678F30", VA = "0x18867A530")]
		public static int[] PMAPEWBIAIC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x867A260", Offset = "0x8678C60", VA = "0x18867A260")]
		public static int[] IXGYFBDOGQI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x867A1F0", Offset = "0x8678BF0", VA = "0x18867A1F0")]
		public static int[] GYKLCXBKOKP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x867A8B0", Offset = "0x86792B0", VA = "0x18867A8B0")]
		public static int[] XVYMHWZCELT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8679DA0", Offset = "0x86787A0", VA = "0x188679DA0")]
		public static OKMUISONBMQ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x86797B0", Offset = "0x86781B0", VA = "0x1886797B0", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class ZEIPTTWNPOD
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] WPMEZSEFMAQ;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] RABJBRSMCAR;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] SCAGQJSXDCG;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] THIXPPGBRFU;
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
	public class SIDFNDXEBQO : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool TXTJCFKDYYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AHXSXSGLOUY LERRNIYRSYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<FOKAMTZKDHN> HHXLXBPRSRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public MOPGZYBCXCO VOBIMAAHYOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public XAGUPSXTOGN ECGBVBFDUNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public FAPFUECQVDQ QLORZUMUMRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion LXYOOPRPYCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 XOJMVANENPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 JBUBAFBXGVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> LBRSITXHTFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public FTEGDPPXEYP FLBVCMGBHKS;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x867E4B0", Offset = "0x867CEB0", VA = "0x18867E4B0")]
		public SIDFNDXEBQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x867DB70", Offset = "0x867C570", VA = "0x18867DB70")]
		public static SIDFNDXEBQO Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x867CF70", Offset = "0x867B970", VA = "0x18867CF70", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode YJPRVQTRKJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode JPOXUQITEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode QSIOVOIZXKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode QTIXHWEMSPE;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x867EAB0", Offset = "0x867D4B0", VA = "0x18867EAB0")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x867E7E0", Offset = "0x867D1E0", VA = "0x18867E7E0")]
		public static Sampler Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x867E5F0", Offset = "0x867CFF0", VA = "0x18867E5F0", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
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
	public class VOBIMAAHYOP : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public MYCFVKCOBHO DLPOWJQVLWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public FOKAMTZKDHN YXDRJRUMSEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<FOKAMTZKDHN> LPAJNINNVKT;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x86832F0", Offset = "0x8681CF0", VA = "0x1886832F0")]
		public VOBIMAAHYOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8682F90", Offset = "0x8681990", VA = "0x188682F90")]
		public static VOBIMAAHYOP Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8682C80", Offset = "0x8681680", VA = "0x188682C80", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class ZWTHYTPYMLD : TMNXRDPPTYC
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string OPPQQHOJFGC = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string OOSXWUJAMMQ = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AXTSRHKTJDS YPLUQTQHWQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int WPMEZSEFMAQ;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8685300", Offset = "0x8683D00", VA = "0x188685300")]
		public ZWTHYTPYMLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8685350", Offset = "0x8683D50", VA = "0x188685350")]
		public ZWTHYTPYMLD(ZWTHYTPYMLD a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8684FB0", Offset = "0x86839B0", VA = "0x188684FB0")]
		public static ZWTHYTPYMLD Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8684F50", Offset = "0x8683950", VA = "0x188684F50", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8685230", Offset = "0x8683C30", VA = "0x188685230")]
		public void FQHZZVRWNKR(JsonWriter a)
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
	public class KRSHTQKOQQW
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double JKGBVZWNKOQ;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double NJKSOBYMRVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double GPVIHFVCIYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double ZRFHKLHZQKF;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8677D50", Offset = "0x8676750", VA = "0x188677D50")]
		public KRSHTQKOQQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8677AA0", Offset = "0x86764A0", VA = "0x188677AA0")]
		public static KRSHTQKOQQW Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8677890", Offset = "0x8676290", VA = "0x188677890")]
		public void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class VTDZVFVDTJC : XMYPCEGPQJZ
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color OUMEQAKGSFF;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double YUWXCMWVROR;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double GRCUONLHGSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType UXYUOXCBTLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color RABJBRSMCAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double IALILWOTLTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double KPAYZXJFJRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public KRSHTQKOQQW KRSHTQKOQQW;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x8683DC0", Offset = "0x86827C0", VA = "0x188683DC0")]
		public VTDZVFVDTJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8683C90", Offset = "0x8682690", VA = "0x188683C90")]
		public VTDZVFVDTJC(VTDZVFVDTJC a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8683700", Offset = "0x8682100", VA = "0x188683700")]
		public static VTDZVFVDTJC Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8683AF0", Offset = "0x86824F0", VA = "0x188683AF0")]
		public static VTDZVFVDTJC Deserialize(GZYGZQSIZFV root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x86833A0", Offset = "0x8681DA0", VA = "0x1886833A0", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class DJAAZOVELES : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<VUGBFJSMLDX> NHGAVSXJFWD;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public DJAAZOVELES(IList<VUGBFJSMLDX> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x86719D0", Offset = "0x86703D0", VA = "0x1886719D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8671960", Offset = "0x8670360", VA = "0x188671960", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class UPJKNCLUWXQ : LOPDDMPFOVQ, HRWOUDTNEXS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<VTDZVFVDTJC> LOVNEIASBYH;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8682C00", Offset = "0x8681600", VA = "0x188682C00")]
		public UPJKNCLUWXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8682130", Offset = "0x8680B30", VA = "0x188682130", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8682670", Offset = "0x8681070", VA = "0x188682670", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x86823C0", Offset = "0x8680DC0", VA = "0x1886823C0")]
		private static string[] JNAJDEHOQJC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8682760", Offset = "0x8681160", VA = "0x188682760")]
		private static GDYMUWMMRMB.ImportValuesConversion VRBRHZNOVRU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8681D40", Offset = "0x8680740", VA = "0x188681D40", Slot = "6")]
		public bool CXHADNHHRJJ(GZYGZQSIZFV a, UZUZIWPUQCU b, [Out] GDYMUWMMRMB c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class QDTAQPASXJH : WBOYLTFHPHT<VTDZVFVDTJC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override VTDZVFVDTJC Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x867BB90", Offset = "0x867A590", VA = "0x18867BB90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x867BB50", Offset = "0x867A550", VA = "0x18867BB50")]
		public QDTAQPASXJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x867BA70", Offset = "0x867A470", VA = "0x18867BA70")]
		public static QDTAQPASXJH Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class YHFFVQPHPRY : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public QDTAQPASXJH FTEGDPPXEYP;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public YHFFVQPHPRY(QDTAQPASXJH a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x86847D0", Offset = "0x86831D0", VA = "0x1886847D0")]
		public YHFFVQPHPRY(int a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8684650", Offset = "0x8683050", VA = "0x188684650", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x86846D0", Offset = "0x86830D0", VA = "0x1886846D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class COFSZGZUFSP : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8671520", Offset = "0x866FF20", VA = "0x188671520")]
		public COFSZGZUFSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8671030", Offset = "0x866FA30", VA = "0x188671030", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
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
