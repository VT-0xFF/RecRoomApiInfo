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
		[Cpp2IlInjected.Address(RVA = "0x85ACBA0", Offset = "0x85ABFA0", VA = "0x1885ACBA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x85ACAF0", Offset = "0x85ABEF0", VA = "0x1885ACAF0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85BB1F0", Offset = "0x85BA5F0", VA = "0x1885BB1F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85BA510", Offset = "0x85B9910", VA = "0x1885BA510")]
		public static void KIBVJTKHKKP(this SIDFNDXEBQO a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85BBA40", Offset = "0x85BAE40", VA = "0x1885BBA40")]
		public static void SZIHWQJCUOJ(this SIDFNDXEBQO a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85B9AE0", Offset = "0x85B8EE0", VA = "0x1885B9AE0")]
		public static void IIOAQXMLZOI(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85BB820", Offset = "0x85BAC20", VA = "0x1885BB820")]
		public static GLTF.Math.Vector4 RNCHFMYKUCM(this XAGUPSXTOGN a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85B9420", Offset = "0x85B8820", VA = "0x1885B9420")]
		public static UnityEngine.Quaternion CJNLEQWJBNB(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85B92F0", Offset = "0x85B86F0", VA = "0x1885B92F0")]
		public static UnityEngine.Quaternion CJNLEQWJBNB(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85B8C00", Offset = "0x85B8000", VA = "0x1885B8C00")]
		public static GLTF.Math.Quaternion AGNARMXEHUJ(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85B9EB0", Offset = "0x85B92B0", VA = "0x1885B9EB0")]
		public static Matrix4x4 IPJZNIABGJU(this XAGUPSXTOGN a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85BA0D0", Offset = "0x85B94D0", VA = "0x1885BA0D0")]
		public static Matrix4x4 IPJZNIABGJU(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85BAEB0", Offset = "0x85BA2B0", VA = "0x1885BAEB0")]
		public static XAGUPSXTOGN LIYLDEAAATO(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85BAC10", Offset = "0x85BA010", VA = "0x1885BAC10")]
		public static UnityEngine.Vector3 KSUGMOMYRFF(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85BAD30", Offset = "0x85BA130", VA = "0x1885BAD30")]
		public static UnityEngine.Vector3 KSUGMOMYRFF(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x85B95A0", Offset = "0x85B89A0", VA = "0x1885B95A0")]
		public static GLTF.Math.Vector3 CNNYYEEYURP(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85BB450", Offset = "0x85BA850", VA = "0x1885BB450")]
		public static GLTF.Math.Vector3 OTILZCGTGTG(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x13731E0", Offset = "0x13725E0", VA = "0x1813731E0")]
		public static GLTF.Math.Vector4 LUCUJRZWANZ(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85B9030", Offset = "0x85B8430", VA = "0x1885B9030")]
		public static Matrix4x4 BEXOOVZMNIP(this XAGUPSXTOGN a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x85B8DC0", Offset = "0x85B81C0", VA = "0x1885B8DC0")]
		public static Matrix4x4 BEXOOVZMNIP(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85BB280", Offset = "0x85BA680", VA = "0x1885BB280")]
		public static XAGUPSXTOGN ODINYVZUUWJ(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85BC1C0", Offset = "0x85BB5C0", VA = "0x1885BC1C0")]
		public static UnityEngine.Vector2 XEOOMXAGDRJ(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85BC1C0", Offset = "0x85BB5C0", VA = "0x1885BC1C0")]
		public static UnityEngine.Vector2 XEOOMXAGDRJ(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85BC1E0", Offset = "0x85BB5E0", VA = "0x1885BC1E0")]
		public static void XEOOMXAGDRJ(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85B9990", Offset = "0x85B8D90", VA = "0x1885B9990")]
		public static UnityEngine.Vector3 HKGBIFCVRFE(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D828A0", Offset = "0x1D81CA0", VA = "0x181D828A0")]
		public static UnityEngine.Vector3 HKGBIFCVRFE(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85B99F0", Offset = "0x85B8DF0", VA = "0x1885B99F0")]
		public static void HKGBIFCVRFE(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x13731E0", Offset = "0x13725E0", VA = "0x1813731E0")]
		public static UnityEngine.Vector4 DTHQJKROMOZ(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x13731E0", Offset = "0x13725E0", VA = "0x1813731E0")]
		public static UnityEngine.Vector4 DTHQJKROMOZ(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85B9700", Offset = "0x85B8B00", VA = "0x1885B9700")]
		public static UnityEngine.Vector4[] DTHQJKROMOZ(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85B9800", Offset = "0x85B8C00", VA = "0x1885B9800")]
		public static void DTHQJKROMOZ(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85BB6E0", Offset = "0x85BAAE0", VA = "0x1885BB6E0")]
		public static UnityEngine.Color PETCUFHHRYT(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85BB5A0", Offset = "0x85BA9A0", VA = "0x1885BB5A0")]
		public static void PETCUFHHRYT(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85BB6E0", Offset = "0x85BAAE0", VA = "0x1885BB6E0")]
		public static UnityEngine.Color PETCUFHHRYT(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x13731E0", Offset = "0x13725E0", VA = "0x1813731E0")]
		public static UnityEngine.Color PBQNVYWDCPM(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85BB490", Offset = "0x85BA890", VA = "0x1885BB490")]
		public static void PBQNVYWDCPM(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x13731E0", Offset = "0x13725E0", VA = "0x1813731E0")]
		public static UnityEngine.Color PBQNVYWDCPM(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85BB7F0", Offset = "0x85BABF0", VA = "0x1885BB7F0")]
		public static GLTF.Math.Color QQAEVVWSLJC(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85BC2B0", Offset = "0x85BB6B0", VA = "0x1885BC2B0")]
		public static GLTF.Math.Color XZREWGVYTIL(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85B8D40", Offset = "0x85B8140", VA = "0x1885B8D40")]
		public static GLTF.Math.Color BDQUZRMEXFZ(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85BBF40", Offset = "0x85BB340", VA = "0x1885BBF40")]
		public static UnityEngine.Color[] TSIIUEDXZXU(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85B9910", Offset = "0x85B8D10", VA = "0x1885B9910")]
		public static int[] FBGOKADAZPL(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85BAE00", Offset = "0x85BA200", VA = "0x1885BAE00")]
		public static UnityEngine.Vector2[] KVCIGLBTDNM(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85BAAB0", Offset = "0x85B9EB0", VA = "0x1885BAAB0")]
		public static void KNCSFKPORDD(MSHGOIDHWYJ a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85BC060", Offset = "0x85BB460", VA = "0x1885BC060")]
		public static UnityEngine.Vector3[] WYKWBKLPQML(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85BC330", Offset = "0x85BB730", VA = "0x1885BC330")]
		public static UnityEngine.Vector4[] ZRXHRSEZNFU(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85BB780", Offset = "0x85BAB80", VA = "0x1885BB780")]
		public static void PKRAAUJRYOJ(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85B96D0", Offset = "0x85B8AD0", VA = "0x1885B96D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray JSLUQKNFIIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x85B2450", Offset = "0x85B1850", VA = "0x1885B2450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> TKDVLCVYXME
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xEE4720", Offset = "0xEE3B20", VA = "0x180EE4720")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xFB3DA0", Offset = "0xFB31A0", VA = "0x180FB3DA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint GVPRWZNHLDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD01820", Offset = "0xD00C20", VA = "0x180D01820")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD01480", Offset = "0xD00880", VA = "0x180D01480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85B2460", Offset = "0x85B1860", VA = "0x1885B2460")]
		public MSHGOIDHWYJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85A9350", Offset = "0x85A8750", VA = "0x1885A9350")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85A93B0", Offset = "0x85A87B0", VA = "0x1885A93B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public EVIVWDLZIBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x85A6B40", Offset = "0x85A5F40", VA = "0x1885A6B40")]
			internal int? CQKYWCAKQTI(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x85A6C90", Offset = "0x85A6090", VA = "0x1885A6C90")]
			internal int? LUVDDZCDBVP(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x85A6BC0", Offset = "0x85A5FC0", VA = "0x1885A6BC0")]
			internal bool DOSTNTECBKF(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85A3990", Offset = "0x85A2D90", VA = "0x1885A3990")]
		private static void AQNSQEBRYAN(NumericArray a, MSHGOIDHWYJ b, MSHGOIDHWYJ c, MSHGOIDHWYJ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85A3F00", Offset = "0x85A3300", VA = "0x1885A3F00")]
		public static void GRIFJUZXFJU(Dictionary<string, MSHGOIDHWYJ> a, Dictionary<string, (MSHGOIDHWYJ sparseIndices, MSHGOIDHWYJ sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85A5840", Offset = "0x85A4C40", VA = "0x1885A5840")]
		public static void ZEGOJMZILDI(Dictionary<string, MSHGOIDHWYJ> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85A3890", Offset = "0x85A2C90", VA = "0x1885A3890")]
		public static void AOQVCAFQXZH(MSHGOIDHWYJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85A5D20", Offset = "0x85A5120", VA = "0x1885A5D20")]
		public static void ZPINEZGXRAB(Dictionary<string, List<MSHGOIDHWYJ>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85A5280", Offset = "0x85A4680", VA = "0x1885A5280")]
		private static void KZWFKYUUGUR(MSHGOIDHWYJ a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85A51C0", Offset = "0x85A45C0", VA = "0x1885A51C0")]
		internal static void KZWFKYUUGUR(OUKRSZNVFOZ a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85A53B0", Offset = "0x85A47B0", VA = "0x1885A53B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF6C9A0", Offset = "0xF6BDA0", VA = "0x180F6C9A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x15C4A60", Offset = "0x15C3E60", VA = "0x1815C4A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30BC770", Offset = "0x30BBB70", VA = "0x1830BC770")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30BC780", Offset = "0x30BBB80", VA = "0x1830BC780")]
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
		[Cpp2IlInjected.Address(RVA = "0x85A7720", Offset = "0x85A6B20", VA = "0x1885A7720")]
		public static void SLIFRFMHRDN(Stream a, [Out] GZYGZQSIZFV b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85A7090", Offset = "0x85A6490", VA = "0x1885A7090")]
		public static ChunkInfo ARYZBDPRVTB(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85A7320", Offset = "0x85A6720", VA = "0x1885A7320")]
		public static GLBHeader IKASUKXCYQF(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x85A7660", Offset = "0x85A6A60", VA = "0x1885A7660")]
		public static bool RYBTHNJDIAB(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x85A7460", Offset = "0x85A6860", VA = "0x1885A7460")]
		public static ChunkInfo OQSJWTKYJPU(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x85A78E0", Offset = "0x85A6CE0", VA = "0x1885A78E0")]
		private static void VMCKLOCZIAU(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x85A75D0", Offset = "0x85A69D0", VA = "0x1885A75D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF3110", Offset = "0xCF2510", VA = "0x180CF3110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCFB380", Offset = "0xCFA780", VA = "0x180CFB380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int ONJFVMMXRGC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xDE68B0", Offset = "0xDE5CB0", VA = "0x180DE68B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xDE67A0", Offset = "0xDE5BA0", VA = "0x180DE67A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string NZCTGTVHMGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C10", Offset = "0xCF4010", VA = "0x180CF4C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IXUSALOKHHK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCF5530", Offset = "0xCF4930", VA = "0x180CF5530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C50", Offset = "0xCF4050", VA = "0x180CF4C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public UZUZIWPUQCU SIYONDEAFUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCF6640", Offset = "0xCF5A40", VA = "0x180CF6640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x85BC5A0", Offset = "0x85BB9A0", VA = "0x1885BC5A0")]
		public string GRQTCHIPINS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x85BC580", Offset = "0x85BB980", VA = "0x1885BC580")]
		public UZUZIWPUQCU CMZHFKNVOUE(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x85BC840", Offset = "0x85BBC40", VA = "0x1885BC840")]
		private UZUZIWPUQCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x85BC8A0", Offset = "0x85BBCA0", VA = "0x1885BC8A0")]
		public UZUZIWPUQCU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x53089F0", Offset = "0x5307DF0", VA = "0x1853089F0")]
		[CompilerGenerated]
		internal static string FBXBEAELJXO(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x85BC800", Offset = "0x85BBC00", VA = "0x1885BC800")]
		[CompilerGenerated]
		internal static bool SPVYDMBJLFN([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x85BC620", Offset = "0x85BBA20", VA = "0x1885BC620")]
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
		[Cpp2IlInjected.Address(RVA = "0x85B2600", Offset = "0x85B1A00", VA = "0x1885B2600")]
		public static int[] OGLVPCHDLIV(this GZYGZQSIZFV a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x85B28A0", Offset = "0x85B1CA0", VA = "0x1885B28A0")]
		public static int[] OHEHITAVPZR(this GZYGZQSIZFV a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class LIDQVADFRSV
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x85B0930", Offset = "0x85AFD30", VA = "0x1885B0930")]
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
			[Cpp2IlInjected.Address(RVA = "0x85B4000", Offset = "0x85B3400", VA = "0x1885B4000", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x85B4040", Offset = "0x85B3440", VA = "0x1885B4040", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x85B4040", Offset = "0x85B3440", VA = "0x1885B4040", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x85B4060", Offset = "0x85B3460", VA = "0x1885B4060", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x85B4080", Offset = "0x85B3480", VA = "0x1885B4080", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x85B40A0", Offset = "0x85B34A0", VA = "0x1885B40A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85B3D90", Offset = "0x85B3190", VA = "0x1885B3D90")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85B3BE0", Offset = "0x85B2FE0", VA = "0x1885B3BE0", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85B3CB0", Offset = "0x85B30B0", VA = "0x1885B3CB0", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x85B3D10", Offset = "0x85B3110", VA = "0x1885B3D10", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85B3C20", Offset = "0x85B3020", VA = "0x1885B3C20", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x85B3D50", Offset = "0x85B3150", VA = "0x1885B3D50", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85B3B50", Offset = "0x85B2F50", VA = "0x1885B3B50")]
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
			[Cpp2IlInjected.Address(RVA = "0x85A6B20", Offset = "0x85A5F20", VA = "0x1885A6B20")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color IIEVTCGKBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x85A6B10", Offset = "0x85A5F10", VA = "0x1885A6B10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color KLNPIKZEQNR
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x85A6840", Offset = "0x85A5C40", VA = "0x1885A6840")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2DD4660", Offset = "0x2DD3A60", VA = "0x182DD4660")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x18651A0", Offset = "0x18645A0", VA = "0x1818651A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2E32520", Offset = "0x2E31920", VA = "0x182E32520")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2E32530", Offset = "0x2E31930", VA = "0x182E32530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BACE60", Offset = "0x2BAC260", VA = "0x182BACE60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x32B2FE0", Offset = "0x32B23E0", VA = "0x1832B2FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1509AF0", Offset = "0x1508EF0", VA = "0x181509AF0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1509B00", Offset = "0x1508F00", VA = "0x181509B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F350", Offset = "0x2B6E750", VA = "0x182B6F350")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85A6910", Offset = "0x85A5D10", VA = "0x1885A6910", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85A69C0", Offset = "0x85A5DC0", VA = "0x1885A69C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x85A6A60", Offset = "0x85A5E60", VA = "0x1885A6A60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x85A6860", Offset = "0x85A5C60", VA = "0x1885A6860")]
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
			[Cpp2IlInjected.Address(RVA = "0x85BD8E0", Offset = "0x85BCCE0", VA = "0x1885BD8E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x85BDDF0", Offset = "0x85BD1F0", VA = "0x1885BDDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float APHEBFHHMPK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x85BDA60", Offset = "0x85BCE60", VA = "0x1885BDA60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x85BD970", Offset = "0x85BCD70", VA = "0x1885BD970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float TPAMXAMZPTT
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x85BDC40", Offset = "0x85BD040", VA = "0x1885BDC40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x85BDB50", Offset = "0x85BCF50", VA = "0x1885BDB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float NQRPLHYMGDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x85BDDC0", Offset = "0x85BD1C0", VA = "0x1885BDDC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x85BDCD0", Offset = "0x85BD0D0", VA = "0x1885BDCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FNXJWWQRTUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x85BD940", Offset = "0x85BCD40", VA = "0x1885BD940")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x85BDE50", Offset = "0x85BD250", VA = "0x1885BDE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float APWYSZOZOXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x85BDA90", Offset = "0x85BCE90", VA = "0x1885BDA90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x85BD9A0", Offset = "0x85BCDA0", VA = "0x1885BD9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float TOKSFGFHNLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x85BDC10", Offset = "0x85BD010", VA = "0x1885BDC10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x85BDB20", Offset = "0x85BCF20", VA = "0x1885BDB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NQMIOBEOWSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x85BDD60", Offset = "0x85BD160", VA = "0x1885BDD60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x85BDC70", Offset = "0x85BD070", VA = "0x1885BDC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float FOCQUDKPDFT
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x85BD910", Offset = "0x85BCD10", VA = "0x1885BD910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x85BDE20", Offset = "0x85BD220", VA = "0x1885BDE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float APRRVSVCFMC
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x85BDAC0", Offset = "0x85BCEC0", VA = "0x1885BDAC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x85BD9D0", Offset = "0x85BCDD0", VA = "0x1885BD9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float TOPZCMZEWXB
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x85BDBE0", Offset = "0x85BCFE0", VA = "0x1885BDBE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x85BDAF0", Offset = "0x85BCEF0", VA = "0x1885BDAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float NQHBQUKRNHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x85BDD90", Offset = "0x85BD190", VA = "0x1885BDD90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x85BDCA0", Offset = "0x85BD0A0", VA = "0x1885BDCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float FOHXRKEMMRC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x85BD8B0", Offset = "0x85BCCB0", VA = "0x1885BD8B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x85BDE80", Offset = "0x85BD280", VA = "0x1885BDE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float AQHMNNCUHUD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x85BDA30", Offset = "0x85BCE30", VA = "0x1885BDA30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x85BDA00", Offset = "0x85BCE00", VA = "0x1885BDA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float TOAEKSRMUPA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x85BDBB0", Offset = "0x85BCFB0", VA = "0x1885BDBB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x85BDB80", Offset = "0x85BCF80", VA = "0x1885BDB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float NQBUTNQUDVT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x85BDD30", Offset = "0x85BD130", VA = "0x1885BDD30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x85BDD00", Offset = "0x85BD100", VA = "0x1885BDD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85BDF80", Offset = "0x85BD380", VA = "0x1885BDF80")]
		public XAGUPSXTOGN(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85BD5F0", Offset = "0x85BC9F0", VA = "0x1885BD5F0", Slot = "4")]
		public bool Equals(XAGUPSXTOGN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85BD4F0", Offset = "0x85BC8F0", VA = "0x1885BD4F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x10DE3B0", Offset = "0x10DD7B0", VA = "0x1810DE3B0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DD4660", Offset = "0x2DD3A60", VA = "0x182DD4660")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x18651A0", Offset = "0x18645A0", VA = "0x1818651A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2E32520", Offset = "0x2E31920", VA = "0x182E32520")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2E32530", Offset = "0x2E31930", VA = "0x182E32530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2BACE60", Offset = "0x2BAC260", VA = "0x182BACE60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32B2FE0", Offset = "0x32B23E0", VA = "0x1832B2FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1509AF0", Offset = "0x1508EF0", VA = "0x181509AF0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1509B00", Offset = "0x1508F00", VA = "0x181509B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x85B3550", Offset = "0x85B2950", VA = "0x1885B3550")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x85B3230", Offset = "0x85B2630", VA = "0x1885B3230", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x85B3350", Offset = "0x85B2750", VA = "0x1885B3350", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85B3400", Offset = "0x85B2800", VA = "0x1885B3400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x85B31C0", Offset = "0x85B25C0", VA = "0x1885B31C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DD4660", Offset = "0x2DD3A60", VA = "0x182DD4660")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x18651A0", Offset = "0x18645A0", VA = "0x1818651A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2E32520", Offset = "0x2E31920", VA = "0x182E32520")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2E32530", Offset = "0x2E31930", VA = "0x182E32530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1051050", Offset = "0x1050450", VA = "0x181051050")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85BCD60", Offset = "0x85BC160", VA = "0x1885BCD60")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x85BCBD0", Offset = "0x85BBFD0", VA = "0x1885BCBD0", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x85BCC30", Offset = "0x85BC030", VA = "0x1885BCC30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x85BCD10", Offset = "0x85BC110", VA = "0x1885BCD10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x85BCB70", Offset = "0x85BBF70", VA = "0x1885BCB70")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DD4660", Offset = "0x2DD3A60", VA = "0x182DD4660")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x18651A0", Offset = "0x18645A0", VA = "0x1818651A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2E32520", Offset = "0x2E31920", VA = "0x182E32520")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2E32530", Offset = "0x2E31930", VA = "0x182E32530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2BACE60", Offset = "0x2BAC260", VA = "0x182BACE60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32B2FE0", Offset = "0x32B23E0", VA = "0x1832B2FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x85BD110", Offset = "0x85BC510", VA = "0x1885BD110")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x85BCDF0", Offset = "0x85BC1F0", VA = "0x1885BCDF0", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85BCED0", Offset = "0x85BC2D0", VA = "0x1885BCED0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x85BCF90", Offset = "0x85BC390", VA = "0x1885BCF90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x85BCD80", Offset = "0x85BC180", VA = "0x1885BCD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DD4660", Offset = "0x2DD3A60", VA = "0x182DD4660")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x18651A0", Offset = "0x18645A0", VA = "0x1818651A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E32520", Offset = "0x2E31920", VA = "0x182E32520")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2E32530", Offset = "0x2E31930", VA = "0x182E32530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2BACE60", Offset = "0x2BAC260", VA = "0x182BACE60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x32B2FE0", Offset = "0x32B23E0", VA = "0x1832B2FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1509AF0", Offset = "0x1508EF0", VA = "0x181509AF0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1509B00", Offset = "0x1508F00", VA = "0x181509B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F350", Offset = "0x2B6E750", VA = "0x182B6F350")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x85A6910", Offset = "0x85A5D10", VA = "0x1885A6910", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x85BD190", Offset = "0x85BC590", VA = "0x1885BD190", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x85A6A60", Offset = "0x85A5E60", VA = "0x1885A6A60", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x85A9F50", Offset = "0x85A9350", VA = "0x1885A9F50")]
		public static void IPHWZZIHEJO(this JObject a, string b, ZWTHYTPYMLD c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class LIDQVADFRSV
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x85B0780", Offset = "0x85AFB80", VA = "0x1885B0780")]
		public static List<string> EKUEJPTPTOH(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x85B1300", Offset = "0x85B0700", VA = "0x1885B1300")]
		public static List<double> UIXLZEKYHSL(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x85B02E0", Offset = "0x85AF6E0", VA = "0x1885B02E0")]
		public static List<int> AGUIGRRDQSC(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5050", Offset = "0x3BC4450", VA = "0x183BC5050")]
		public static List<a> CMARJVDOIXE<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x85B0A80", Offset = "0x85AFE80", VA = "0x1885B0A80")]
		public static ZWTHYTPYMLD ILYGWPCRWZC(this JToken a, GZYGZQSIZFV b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x85B1E40", Offset = "0x85B1240", VA = "0x1885B1E40")]
		public static int YBGAJEZXCZM(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85B1F80", Offset = "0x85B1380", VA = "0x1885B1F80")]
		public static double YNUDVCRQBRS(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x85B04A0", Offset = "0x85AF8A0", VA = "0x1885B04A0")]
		public static GLTF.Math.Color BUIMUFIWYMD(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x85B14C0", Offset = "0x85B08C0", VA = "0x1885B14C0")]
		public static GLTF.Math.Color UOWDFYQCVRS(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x85B1730", Offset = "0x85B0B30", VA = "0x1885B1730")]
		public static GLTF.Math.Color WSFUUXIQSVW(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x85B0D30", Offset = "0x85B0130", VA = "0x1885B0D30")]
		public static GLTF.Math.Vector3 OXFHCSBXMYO(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x85B19D0", Offset = "0x85B0DD0", VA = "0x1885B19D0")]
		public static GLTF.Math.Vector2 XQWOZSNRZQM(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85B1BE0", Offset = "0x85B0FE0", VA = "0x1885B1BE0")]
		public static GLTF.Math.Vector3 XRBVWZHPJBV(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x85B0FF0", Offset = "0x85B03F0", VA = "0x1885B0FF0")]
		public static GLTF.Math.Quaternion REKWBJUBMFY(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3BC56F0", Offset = "0x3BC4AF0", VA = "0x183BC56F0")]
		public static Dictionary<string, b> RXGXNGORAFE<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3BC53A0", Offset = "0x3BC47A0", VA = "0x183BC53A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85A6EE0", Offset = "0x85A62E0", VA = "0x1885A6EE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E60", Offset = "0x85A6260", VA = "0x1885A6E60", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class PYNUMMECXXK : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x85B3040", Offset = "0x85B2440", VA = "0x1885B3040")]
		public PYNUMMECXXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85B2F70", Offset = "0x85B2370", VA = "0x1885B2F70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x85A6D20", Offset = "0x85A6120", VA = "0x1885A6D20", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x85A6DE0", Offset = "0x85A61E0", VA = "0x1885A6DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x85BCA50", Offset = "0x85BBE50", VA = "0x1885BCA50")]
			internal MYCFVKCOBHO GLHKTQZGMNL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x85BE830", Offset = "0x85BDC30", VA = "0x1885BE830")]
		public YHDDRJKEDCS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x85BE6A0", Offset = "0x85BDAA0", VA = "0x1885BE6A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public EXT_texture_exr(GNIRBFJHUPY source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x85A6F30", Offset = "0x85A6330", VA = "0x1885A6F30", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x85A6FA0", Offset = "0x85A63A0", VA = "0x1885A6FA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class OUWOVHFEZXJ : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x85B25B0", Offset = "0x85B19B0", VA = "0x1885B25B0")]
		public OUWOVHFEZXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x85B2490", Offset = "0x85B1890", VA = "0x1885B2490", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x85A6560", Offset = "0x85A5960", VA = "0x1885A6560", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x85A6520", Offset = "0x85A5920", VA = "0x1885A6520")]
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
			[Cpp2IlInjected.Address(RVA = "0x85A66F0", Offset = "0x85A5AF0", VA = "0x1885A66F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x85A66B0", Offset = "0x85A5AB0", VA = "0x1885A66B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85A63D0", Offset = "0x85A57D0", VA = "0x1885A63D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x85A6390", Offset = "0x85A5790", VA = "0x1885A6390")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x85A62B0", Offset = "0x85A56B0", VA = "0x1885A62B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AC810", Offset = "0x85ABC10", VA = "0x1885AC810", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x85AC410", Offset = "0x85AB810", VA = "0x1885AC410", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x85AC480", Offset = "0x85AB880", VA = "0x1885AC480")]
		public static KHR_SceneAudioEmittersRef Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x85ACA70", Offset = "0x85ABE70", VA = "0x1885ACA70")]
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
			[Cpp2IlInjected.Address(RVA = "0x85AC3E0", Offset = "0x85AB7E0", VA = "0x1885AC3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x85AC2C0", Offset = "0x85AB6C0", VA = "0x1885AC2C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x85AC0B0", Offset = "0x85AB4B0", VA = "0x1885AC0B0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x85AC120", Offset = "0x85AB520", VA = "0x1885AC120")]
		public static KHR_NodeAudioEmitterRef Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AA4F0", Offset = "0x85A98F0", VA = "0x1885AA4F0")]
		public JObject BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x85AA760", Offset = "0x85A9B60", VA = "0x1885AA760")]
		public static KEBSFJDWBTA Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AB200", Offset = "0x85AA600", VA = "0x1885AB200", Slot = "5")]
		public virtual JObject BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x85AB5A0", Offset = "0x85AA9A0", VA = "0x1885AB5A0")]
		public static KHR_AudioEmitter Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x85ABAA0", Offset = "0x85AAEA0", VA = "0x1885ABAA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85ABB20", Offset = "0x85AAF20", VA = "0x1885ABB20")]
		public JObject BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x85ABD50", Offset = "0x85AB150", VA = "0x1885ABD50")]
		public static KHR_AudioSource Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x85AB1F0", Offset = "0x85AA5F0", VA = "0x1885AB1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AAE60", Offset = "0x85AA260", VA = "0x1885AAE60")]
		public JObject BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x85AAF90", Offset = "0x85AA390", VA = "0x1885AAF90")]
		public static KHR_AudioData Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x85AB1F0", Offset = "0x85AA5F0", VA = "0x1885AB1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85ACD30", Offset = "0x85AC130", VA = "0x1885ACD30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x85ACCA0", Offset = "0x85AC0A0", VA = "0x1885ACCA0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD460", Offset = "0x85AC860", VA = "0x1885AD460")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class FQXTBSEPWKZ : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x85A87B0", Offset = "0x85A7BB0", VA = "0x1885A87B0")]
		public FQXTBSEPWKZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x85A7BE0", Offset = "0x85A6FE0", VA = "0x1885A7BE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD630", Offset = "0x85ACA30", VA = "0x1885AD630", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x85AD570", Offset = "0x85AC970", VA = "0x1885AD570", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x85AD680", Offset = "0x85ACA80", VA = "0x1885AD680")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x85BCB00", Offset = "0x85BBF00", VA = "0x1885BCB00")]
			internal int GLHKTQZGMNL()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x85BEA90", Offset = "0x85BDE90", VA = "0x1885BEA90")]
		public ZGXZYSFPDWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x85BE880", Offset = "0x85BDC80", VA = "0x1885BE880", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD780", Offset = "0x85ACB80", VA = "0x1885AD780", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD700", Offset = "0x85ACB00", VA = "0x1885AD700", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class LKLZEUJQUUQ : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x85B2270", Offset = "0x85B1670", VA = "0x1885B2270")]
		public LKLZEUJQUUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x85B20C0", Offset = "0x85B14C0", VA = "0x1885B20C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85ADA30", Offset = "0x85ACE30", VA = "0x1885ADA30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD990", Offset = "0x85ACD90", VA = "0x1885AD990", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class PTBBUIEIYBC : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x85B2F20", Offset = "0x85B2320", VA = "0x1885B2F20")]
		public PTBBUIEIYBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x85B2CA0", Offset = "0x85B20A0", VA = "0x1885B2CA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85ADD90", Offset = "0x85AD190", VA = "0x1885ADD90", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x85ADD20", Offset = "0x85AD120", VA = "0x1885ADD20", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class ZXWRMSOWFAG : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x85BEEF0", Offset = "0x85BE2F0", VA = "0x1885BEEF0")]
		public ZXWRMSOWFAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x85BEE20", Offset = "0x85BE220", VA = "0x1885BEE20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AE0E0", Offset = "0x85AD4E0", VA = "0x1885AE0E0")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x85AE070", Offset = "0x85AD470", VA = "0x1885AE070")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, GZYGZQSIZFV root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x85ADEB0", Offset = "0x85AD2B0", VA = "0x1885ADEB0", Slot = "6")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x85ADF50", Offset = "0x85AD350", VA = "0x1885ADF50", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class LDVQKQKWZVB : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x85B0290", Offset = "0x85AF690", VA = "0x1885B0290")]
		public LDVQKQKWZVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x85B0190", Offset = "0x85AF590", VA = "0x1885B0190", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AE190", Offset = "0x85AD590", VA = "0x1885AE190", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x85AE130", Offset = "0x85AD530", VA = "0x1885AE130", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x85AE2E0", Offset = "0x85AD6E0", VA = "0x1885AE2E0")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class RKNYFZMKVIQ : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x85B36B0", Offset = "0x85B2AB0", VA = "0x1885B36B0")]
		public RKNYFZMKVIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x85B35E0", Offset = "0x85B29E0", VA = "0x1885B35E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AE390", Offset = "0x85AD790", VA = "0x1885AE390", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x85AE2F0", Offset = "0x85AD6F0", VA = "0x1885AE2F0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x85AE750", Offset = "0x85ADB50", VA = "0x1885AE750")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class ZHNUFUWWJKK : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x85BEDD0", Offset = "0x85BE1D0", VA = "0x1885BEDD0")]
		public ZHNUFUWWJKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x85BEAE0", Offset = "0x85BDEE0", VA = "0x1885BEAE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85A9E60", Offset = "0x85A9260", VA = "0x1885A9E60")]
		public HDYNHITMCGR(GLTF.Math.Color a, ZWTHYTPYMLD b, GLTF.Math.Vector3 c, double d, ZWTHYTPYMLD e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x85A9560", Offset = "0x85A8960", VA = "0x1885A9560", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x85A9710", Offset = "0x85A8B10", VA = "0x1885A9710", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class GBUZWYOBVLT : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x85A8B50", Offset = "0x85A7F50", VA = "0x1885A8B50")]
		public GBUZWYOBVLT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x85A8800", Offset = "0x85A7C00", VA = "0x1885A8800", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AE840", Offset = "0x85ADC40", VA = "0x1885AE840", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x85AE770", Offset = "0x85ADB70", VA = "0x1885AE770", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x85AED50", Offset = "0x85AE150", VA = "0x1885AED50")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class PFOTUENXAOD : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x85B2C50", Offset = "0x85B2050", VA = "0x1885B2C50")]
		public PFOTUENXAOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x85B29F0", Offset = "0x85B1DF0", VA = "0x1885B29F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AEE80", Offset = "0x85AE280", VA = "0x1885AEE80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x85AEDB0", Offset = "0x85AE1B0", VA = "0x1885AEDB0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x85AF390", Offset = "0x85AE790", VA = "0x1885AF390")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class XXWKNJFJZVH : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x85BE4A0", Offset = "0x85BD8A0", VA = "0x1885BE4A0")]
		public XXWKNJFJZVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x85BE230", Offset = "0x85BD630", VA = "0x1885BE230", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AF480", Offset = "0x85AE880", VA = "0x1885AF480", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x85AF400", Offset = "0x85AE800", VA = "0x1885AF400", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class LVMXWYFIQZW : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x85B2400", Offset = "0x85B1800", VA = "0x1885B2400")]
		public LVMXWYFIQZW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x85B22C0", Offset = "0x85B16C0", VA = "0x1885B22C0", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class WMFDSLCGQUV : TMNXRDPPTYC, LOPDDMPFOVQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x85BD430", Offset = "0x85BC830", VA = "0x1885BD430")]
		public WMFDSLCGQUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x85BD480", Offset = "0x85BC880", VA = "0x1885BD480")]
		public WMFDSLCGQUV(WMFDSLCGQUV a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x85BD2C0", Offset = "0x85BC6C0", VA = "0x1885BD2C0", Slot = "6")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x85BD230", Offset = "0x85BC630", VA = "0x1885BD230", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x85BD360", Offset = "0x85BC760", VA = "0x1885BD360", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class IPZWLQVODPT : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x85AA050", Offset = "0x85A9450", VA = "0x1885AA050")]
		public IPZWLQVODPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x85A9FD0", Offset = "0x85A93D0", VA = "0x1885A9FD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AF6A0", Offset = "0x85AEAA0", VA = "0x1885AF6A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x85AF610", Offset = "0x85AEA10", VA = "0x1885AF610", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x85AFBC0", Offset = "0x85AEFC0", VA = "0x1885AFBC0")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class SZIEIUOPCRE : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x85B3B00", Offset = "0x85B2F00", VA = "0x1885B3B00")]
		public SZIEIUOPCRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x85B38F0", Offset = "0x85B2CF0", VA = "0x1885B38F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AFC40", Offset = "0x85AF040", VA = "0x1885AFC40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x85AFBE0", Offset = "0x85AEFE0", VA = "0x1885AFBE0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x122FDB0", Offset = "0x122F1B0", VA = "0x18122FDB0")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class UANFVGMRTWK : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x85B4230", Offset = "0x85B3630", VA = "0x1885B4230")]
		public UANFVGMRTWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x85B4150", Offset = "0x85B3550", VA = "0x1885B4150", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AFDB0", Offset = "0x85AF1B0", VA = "0x1885AFDB0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x85AFD50", Offset = "0x85AF150", VA = "0x1885AFD50", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x122FDB0", Offset = "0x122F1B0", VA = "0x18122FDB0")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class JCAQAMUYTGC : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x85AA180", Offset = "0x85A9580", VA = "0x1885AA180")]
		public JCAQAMUYTGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x85AA0A0", Offset = "0x85A94A0", VA = "0x1885AA0A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AFF20", Offset = "0x85AF320", VA = "0x1885AFF20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x85AFEC0", Offset = "0x85AF2C0", VA = "0x1885AFEC0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x122FDB0", Offset = "0x122F1B0", VA = "0x18122FDB0")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class QIWIWYENPXI : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x85B3170", Offset = "0x85B2570", VA = "0x1885B3170")]
		public QIWIWYENPXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x85B3090", Offset = "0x85B2490", VA = "0x1885B3090", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public KHR_texture_basisu(GNIRBFJHUPY source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x85B0030", Offset = "0x85AF430", VA = "0x1885B0030", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x85B00A0", Offset = "0x85AF4A0", VA = "0x1885B00A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class YGOMDIPINLE : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x85BE650", Offset = "0x85BDA50", VA = "0x1885BE650")]
		public YGOMDIPINLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x85BE4F0", Offset = "0x85BD8F0", VA = "0x1885BE4F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85A92D0", Offset = "0x85A86D0", VA = "0x1885A92D0")]
		public GEAORXGMOBL(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x85A8BA0", Offset = "0x85A7FA0", VA = "0x1885A8BA0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x85A8C80", Offset = "0x85A8080", VA = "0x1885A8C80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class JMLSMVEOVEJ : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x85AA4A0", Offset = "0x85A98A0", VA = "0x1885AA4A0")]
		public JMLSMVEOVEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x85AA1D0", Offset = "0x85A95D0", VA = "0x1885AA1D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public ROOCTVXZTNL(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x85B3700", Offset = "0x85B2B00", VA = "0x1885B3700", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x85B3800", Offset = "0x85B2C00", VA = "0x1885B3800", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x85B3770", Offset = "0x85B2B70", VA = "0x1885B3770")]
		public List<double> SCXIYEBWVDN(SIDFNDXEBQO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class GYLDDGXHLQF : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x85A9510", Offset = "0x85A8910", VA = "0x1885A9510")]
		public GYLDDGXHLQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x85A9410", Offset = "0x85A8810", VA = "0x1885A9410", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AB1F0", Offset = "0x85AA5F0", VA = "0x1885AB1F0")]
		public UDJEVNZXQWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x85B54F0", Offset = "0x85B48F0", VA = "0x1885B54F0")]
		public static UDJEVNZXQWJ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x85B4830", Offset = "0x85B3C30", VA = "0x1885B4830", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x85B6E00", Offset = "0x85B6200", VA = "0x1885B6E00")]
		private unsafe static sbyte LDLTPHKLEYI(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x85B7A50", Offset = "0x85B6E50", VA = "0x1885B7A50")]
		private unsafe static float2 PNYUXORZOKC(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x85B4E10", Offset = "0x85B4210", VA = "0x1885B4E10")]
		private unsafe static float3 BSCIPADZDVN(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x85B78D0", Offset = "0x85B6CD0", VA = "0x1885B78D0")]
		private unsafe static float4 OKKYVZKIVTK(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x85B6C60", Offset = "0x85B6060", VA = "0x1885B6C60")]
		private unsafe static float4x4 KSUOUATTRJS(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x85B6E00", Offset = "0x85B6200", VA = "0x1885B6E00")]
		private unsafe static byte ZUDBBAYBNSR(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x85B6AB0", Offset = "0x85B5EB0", VA = "0x1885B6AB0")]
		private unsafe static float2 JPLBDFYHIQB(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x85B8A10", Offset = "0x85B7E10", VA = "0x1885B8A10")]
		private unsafe static float3 ZNEXQRUKXQA(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x85B7AB0", Offset = "0x85B6EB0", VA = "0x1885B7AB0")]
		private unsafe static float4 QOBCAIXEPIX(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x85B8A60", Offset = "0x85B7E60", VA = "0x1885B8A60")]
		private unsafe static float4x4 ZVQKBZYLUHB(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x85B5DE0", Offset = "0x85B51E0", VA = "0x1885B5DE0")]
		private unsafe static short LPOEYDHUIAM(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x85B5AC0", Offset = "0x85B4EC0", VA = "0x1885B5AC0")]
		private unsafe static float2 ESHGTLJNXCC(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x85B75D0", Offset = "0x85B69D0", VA = "0x1885B75D0")]
		private unsafe static float3 NLVVWXCUJPN(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x85B7570", Offset = "0x85B6970", VA = "0x1885B7570")]
		private unsafe static float4 MVKCUQOEOWU(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x85B7620", Offset = "0x85B6A20", VA = "0x1885B7620")]
		private unsafe static float4x4 NYPZDKGJQJK(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x85B5DE0", Offset = "0x85B51E0", VA = "0x1885B5DE0")]
		private unsafe static ushort FEYNPYKMGKL(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x85B7A80", Offset = "0x85B6E80", VA = "0x1885B7A80")]
		private unsafe static float2 QCMYUWQLJFZ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x85B67B0", Offset = "0x85B5BB0", VA = "0x1885B67B0")]
		private unsafe static float3 HZMFXSMHKHU(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x85B50E0", Offset = "0x85B44E0", VA = "0x1885B50E0")]
		private unsafe static float4x4 DCZNWTBIJCZ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x85B5DF0", Offset = "0x85B51F0", VA = "0x1885B5DF0")]
		private unsafe static float4 FTEHSJQYSXH(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x85B7CC0", Offset = "0x85B70C0", VA = "0x1885B7CC0")]
		private unsafe static uint TAYRNYOGQHQ(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x85B5DE0", Offset = "0x85B51E0", VA = "0x1885B5DE0")]
		private unsafe static ushort RGOPTALXYVJ(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x85B6C50", Offset = "0x85B6050", VA = "0x1885B6C50")]
		private unsafe static float KQRKKFBYANW(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x85B7B10", Offset = "0x85B6F10", VA = "0x1885B7B10")]
		private unsafe static float2 QXGXSCGPNTE(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x85B7CA0", Offset = "0x85B70A0", VA = "0x1885B7CA0")]
		private unsafe static float3 SJOJSBCWQMT(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x85B5D80", Offset = "0x85B5180", VA = "0x1885B5D80")]
		private unsafe static float4 QINTWEULEWQ(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x85B50B0", Offset = "0x85B44B0", VA = "0x1885B50B0")]
		private unsafe static float4x4 CWLUVBYFJIE(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x85B5D80", Offset = "0x85B5180", VA = "0x1885B5D80")]
		private unsafe static float4 FDZPHEWQKPJ(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x85B5DB0", Offset = "0x85B51B0", VA = "0x1885B5DB0")]
		private unsafe static float4 FDZPHEWQKPJ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x85B87E0", Offset = "0x85B7BE0", VA = "0x1885B87E0")]
		public static float3[] ZBAOWZOMPWW(UDJEVNZXQWJ a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x85B84D0", Offset = "0x85B78D0", VA = "0x1885B84D0")]
		public static float3[] YQLQJRBASVE(UDJEVNZXQWJ a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x85B6AE0", Offset = "0x85B5EE0", VA = "0x1885B6AE0")]
		public static uint[] KIFBZJEVFRF(UDJEVNZXQWJ a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x85B7B80", Offset = "0x85B6F80", VA = "0x1885B7B80")]
		internal static void SGKYEISOYIA(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x85B4E60", Offset = "0x85B4260", VA = "0x1885B4E60")]
		public uint[] CPTQXWBHGKD(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x85B5280", Offset = "0x85B4680", VA = "0x1885B5280")]
		public float[] DZANRGRCLIR(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x85B5AF0", Offset = "0x85B4EF0", VA = "0x1885B5AF0")]
		public float2[] FAZIAHFCTNR(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x85B6800", Offset = "0x85B5C00", VA = "0x1885B6800")]
		public float2[] JDGOMBXIFNL(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x85B6F80", Offset = "0x85B6380", VA = "0x1885B6F80")]
		public float3[] LMHOABMPDJU(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x85B5F60", Offset = "0x85B5360", VA = "0x1885B5F60")]
		public float3[] HJZTFPAHRNE(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x85B7CD0", Offset = "0x85B70D0", VA = "0x1885B7CD0")]
		public float4[] VPMPWWEUSON(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x85B7200", Offset = "0x85B6600", VA = "0x1885B7200")]
		public float4[] MBMZQCUVAYJ(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x85B8010", Offset = "0x85B7410", VA = "0x1885B8010")]
		public float4[] WWEVFUBXEKK(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x85B5E50", Offset = "0x85B5250", VA = "0x1885B5E50")]
		public float3[] FWJBSCYPPER(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x85B77C0", Offset = "0x85B6BC0", VA = "0x1885B77C0")]
		public float3[] NZBDIUNLZDQ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x85B7F40", Offset = "0x85B7340", VA = "0x1885B7F40")]
		public float4[] VUQMWXWZEDC(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x85B7B30", Offset = "0x85B6F30", VA = "0x1885B7B30")]
		public uint[] RLYWBUJCBQH(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x85B4280", Offset = "0x85B3680", VA = "0x1885B4280")]
		public float4x4[] AZDXOFFZVGG(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x85B65F0", Offset = "0x85B59F0", VA = "0x1885B65F0")]
		private unsafe static float4 HWJMARELKAE(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x85B6470", Offset = "0x85B5870", VA = "0x1885B6470")]
		private unsafe static float4 HWJMARELKAE(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x85B6E10", Offset = "0x85B6210", VA = "0x1885B6E10")]
		private unsafe static float4x4 LDUCXBZNDBH(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x85B62B0", Offset = "0x85B56B0", VA = "0x1885B62B0")]
		private unsafe static float4 HNYGBOKWJWB(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x85B5950", Offset = "0x85B4D50", VA = "0x1885B5950")]
		private unsafe static float3 EGHJEXMTSEG(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x85B83A0", Offset = "0x85B77A0", VA = "0x1885B83A0")]
		private unsafe static float2 XFHMYHPIHHJ(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x85B7930", Offset = "0x85B6D30", VA = "0x1885B7930")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C7FB0", Offset = "0x85C73B0", VA = "0x1885C7FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C2BF0", Offset = "0x85C1FF0", VA = "0x1885C2BF0")]
		public FRJLFWBSTDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x85C2920", Offset = "0x85C1D20", VA = "0x1885C2920")]
		public static FRJLFWBSTDT Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x85C27F0", Offset = "0x85C1BF0", VA = "0x1885C27F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C7260", Offset = "0x85C6660", VA = "0x1885C7260")]
		public KQFQLFEXQFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x85C6F80", Offset = "0x85C6380", VA = "0x1885C6F80")]
		public static KQFQLFEXQFA Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x85C6E40", Offset = "0x85C6240", VA = "0x1885C6E40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85BFE70", Offset = "0x85BF270", VA = "0x1885BFE70")]
		public BYWAVRKEUYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x85BFBF0", Offset = "0x85BEFF0", VA = "0x1885BFBF0")]
		public static BYWAVRKEUYT Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x85BFAF0", Offset = "0x85BEEF0", VA = "0x1885BFAF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C6DF0", Offset = "0x85C61F0", VA = "0x1885C6DF0")]
		public KKMAFFKJDUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x85C6C00", Offset = "0x85C6000", VA = "0x1885C6C00")]
		public static KKMAFFKJDUL Deserialize(GZYGZQSIZFV root, JsonReader reader, ABAJRTCMWQH anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x85C6B00", Offset = "0x85C5F00", VA = "0x1885C6B00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D45E0", Offset = "0x85D39E0", VA = "0x1885D45E0")]
		public static ZPCBEZLKRXQ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x85D4840", Offset = "0x85D3C40", VA = "0x1885D4840")]
		public ZPCBEZLKRXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x85D44C0", Offset = "0x85D38C0", VA = "0x1885D44C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C2CE0", Offset = "0x85C20E0", VA = "0x1885C2CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C6520", Offset = "0x85C5920", VA = "0x1885C6520")]
		public HEQRHAMLLIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x85C6300", Offset = "0x85C5700", VA = "0x1885C6300")]
		public static HEQRHAMLLIQ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x85C6190", Offset = "0x85C5590", VA = "0x1885C6190", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C09B0", Offset = "0x85BFDB0", VA = "0x1885C09B0")]
		public CHJNAHMOGXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x85C02E0", Offset = "0x85BF6E0", VA = "0x1885C02E0")]
		public static CHJNAHMOGXE Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x85BFEC0", Offset = "0x85BF2C0", VA = "0x1885BFEC0", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x85C09A0", Offset = "0x85BFDA0", VA = "0x1885C09A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x85C0600", Offset = "0x85BFA00", VA = "0x1885C0600")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C1330", Offset = "0x85C0730", VA = "0x1885C1330")]
		public OUKRSZNVFOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x85CB040", Offset = "0x85CA440", VA = "0x1885CB040")]
		public static OUKRSZNVFOZ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x85CAE30", Offset = "0x85CA230", VA = "0x1885CAE30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85CE9E0", Offset = "0x85CDDE0", VA = "0x1885CE9E0")]
		public TFHPLWDVUAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x85CE660", Offset = "0x85CDA60", VA = "0x1885CE660")]
		public static TFHPLWDVUAT Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x85CE4F0", Offset = "0x85CD8F0", VA = "0x1885CE4F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C3330", Offset = "0x85C2730", VA = "0x1885C3330")]
		public GLXELVQTGAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x85C2FC0", Offset = "0x85C23C0", VA = "0x1885C2FC0")]
		public static GLXELVQTGAV Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x85C2E30", Offset = "0x85C2230", VA = "0x1885C2E30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x85D3A60", Offset = "0x85D2E60", VA = "0x1885D3A60")]
			internal KKMAFFKJDUL GLHKTQZGMNL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x85D3A50", Offset = "0x85D2E50", VA = "0x1885D3A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x85BF2E0", Offset = "0x85BE6E0", VA = "0x1885BF2E0")]
		public static ABAJRTCMWQH Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x85BF6A0", Offset = "0x85BEAA0", VA = "0x1885BF6A0")]
		public ABAJRTCMWQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x85BEF40", Offset = "0x85BE340", VA = "0x1885BEF40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C1330", Offset = "0x85C0730", VA = "0x1885C1330")]
		public WCYSICVUSPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x85D3BD0", Offset = "0x85D2FD0", VA = "0x1885D3BD0")]
		public static WCYSICVUSPP Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x85D3A80", Offset = "0x85D2E80", VA = "0x1885D3A80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C1330", Offset = "0x85C0730", VA = "0x1885C1330")]
		public CPICCNBPKBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x85C1160", Offset = "0x85C0560", VA = "0x1885C1160")]
		public static CPICCNBPKBO Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x85C0F90", Offset = "0x85C0390", VA = "0x1885C0F90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C1330", Offset = "0x85C0730", VA = "0x1885C1330")]
		public XMYPCEGPQJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x85D3F20", Offset = "0x85D3320", VA = "0x1885D3F20")]
		public XMYPCEGPQJZ(XMYPCEGPQJZ a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x85D3E30", Offset = "0x85D3230", VA = "0x1885D3E30")]
		public new void BQPNWAQSTNL(GZYGZQSIZFV a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x85D3DA0", Offset = "0x85D31A0", VA = "0x1885D3DA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		protected WBOYLTFHPHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8516CF0", Offset = "0x85160F0", VA = "0x188516CF0")]
		public WBOYLTFHPHT(WBOYLTFHPHT<a> a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8516CC0", Offset = "0x85160C0", VA = "0x188516CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85C8C80", Offset = "0x85C8080", VA = "0x1885C8C80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x85C8C40", Offset = "0x85C8040", VA = "0x1885C8C40")]
		public MYCFVKCOBHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x85C8BE0", Offset = "0x85C7FE0", VA = "0x1885C8BE0")]
		public MYCFVKCOBHO(MYCFVKCOBHO a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x85C8B00", Offset = "0x85C7F00", VA = "0x1885C8B00")]
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
			[Cpp2IlInjected.Address(RVA = "0x85C8FF0", Offset = "0x85C83F0", VA = "0x1885C8FF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x85C8FB0", Offset = "0x85C83B0", VA = "0x1885C8FB0")]
		public NXEAZIBWYCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x85C8ED0", Offset = "0x85C82D0", VA = "0x1885C8ED0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85CB410", Offset = "0x85CA810", VA = "0x1885CB410", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x85CB3D0", Offset = "0x85CA7D0", VA = "0x1885CB3D0")]
		public OWILLSWHPZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x85CB2F0", Offset = "0x85CA6F0", VA = "0x1885CB2F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85BF8B0", Offset = "0x85BECB0", VA = "0x1885BF8B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x85BF870", Offset = "0x85BEC70", VA = "0x1885BF870")]
		public AHXSXSGLOUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x85BF790", Offset = "0x85BEB90", VA = "0x1885BF790")]
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
			[Cpp2IlInjected.Address(RVA = "0x85C34B0", Offset = "0x85C28B0", VA = "0x1885C34B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x85C3470", Offset = "0x85C2870", VA = "0x1885C3470")]
		public GNIRBFJHUPY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x85C3390", Offset = "0x85C2790", VA = "0x1885C3390")]
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
			[Cpp2IlInjected.Address(RVA = "0x85C23A0", Offset = "0x85C17A0", VA = "0x1885C23A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x85C2360", Offset = "0x85C1760", VA = "0x1885C2360")]
		public FMTAGVZYQQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x85C2300", Offset = "0x85C1700", VA = "0x1885C2300")]
		public FMTAGVZYQQW(FMTAGVZYQQW a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x85C2220", Offset = "0x85C1620", VA = "0x1885C2220")]
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
			[Cpp2IlInjected.Address(RVA = "0x85C1DB0", Offset = "0x85C11B0", VA = "0x1885C1DB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D70", Offset = "0x85C1170", VA = "0x1885C1D70")]
		public FAPFUECQVDQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x85C1C90", Offset = "0x85C1090", VA = "0x1885C1C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x85C2790", Offset = "0x85C1B90", VA = "0x1885C2790", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x85C2750", Offset = "0x85C1B50", VA = "0x1885C2750")]
		public FOKAMTZKDHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x85C2670", Offset = "0x85C1A70", VA = "0x1885C2670")]
		public static FOKAMTZKDHN Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x85C2400", Offset = "0x85C1800", VA = "0x1885C2400")]
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
			[Cpp2IlInjected.Address(RVA = "0x85C8E70", Offset = "0x85C8270", VA = "0x1885C8E70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x85C8E30", Offset = "0x85C8230", VA = "0x1885C8E30")]
		public NVEXEGYPDWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x85C8D50", Offset = "0x85C8150", VA = "0x1885C8D50")]
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
			[Cpp2IlInjected.Address(RVA = "0x85C3650", Offset = "0x85C2A50", VA = "0x1885C3650", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x85C3610", Offset = "0x85C2A10", VA = "0x1885C3610")]
		public GOCJGLTGXMV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x85C3510", Offset = "0x85C2910", VA = "0x1885C3510")]
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
			[Cpp2IlInjected.Address(RVA = "0x85C7F50", Offset = "0x85C7350", VA = "0x1885C7F50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x85C7F10", Offset = "0x85C7310", VA = "0x1885C7F10")]
		public LYHUNAQFDFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x85C7E30", Offset = "0x85C7230", VA = "0x1885C7E30")]
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
			[Cpp2IlInjected.Address(RVA = "0x85C8130", Offset = "0x85C7530", VA = "0x1885C8130", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x85C80F0", Offset = "0x85C74F0", VA = "0x1885C80F0")]
		public MOPGZYBCXCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x85C8010", Offset = "0x85C7410", VA = "0x1885C8010")]
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
			[Cpp2IlInjected.Address(RVA = "0x85BFA90", Offset = "0x85BEE90", VA = "0x1885BFA90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x85BF9F0", Offset = "0x85BEDF0", VA = "0x1885BF9F0")]
		public AXTSRHKTJDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x85BFA30", Offset = "0x85BEE30", VA = "0x1885BFA30")]
		public AXTSRHKTJDS(AXTSRHKTJDS a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x85BF910", Offset = "0x85BED10", VA = "0x1885BF910")]
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
			[Cpp2IlInjected.Address(RVA = "0x85C2C80", Offset = "0x85C2080", VA = "0x1885C2C80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x85C2C40", Offset = "0x85C2040", VA = "0x1885C2C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C1330", Offset = "0x85C0730", VA = "0x1885C1330")]
		public LIJTJBKAUDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x85C79A0", Offset = "0x85C6DA0", VA = "0x1885C79A0")]
		public static LIJTJBKAUDO Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x85C77D0", Offset = "0x85C6BD0", VA = "0x1885C77D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85CC900", Offset = "0x85CBD00", VA = "0x1885CC900")]
		public RLXWJRYFKUW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x85CC3F0", Offset = "0x85CB7F0", VA = "0x1885CC3F0")]
		public static RLXWJRYFKUW Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x85CBF90", Offset = "0x85CB390", VA = "0x1885CBF90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public ZMZGDOYHPIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x85D44B0", Offset = "0x85D38B0", VA = "0x1885D44B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C1330", Offset = "0x85C0730", VA = "0x1885C1330")]
		public MRVNGWGPAZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x85C8740", Offset = "0x85C7B40", VA = "0x1885C8740")]
		public static MRVNGWGPAZI Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x85C8190", Offset = "0x85C7590", VA = "0x1885C8190", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85CF6C0", Offset = "0x85CEAC0", VA = "0x1885CF6C0")]
		public static SWSIXEMFKMD ONSNBLTFMMG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x85CFE20", Offset = "0x85CF220", VA = "0x1885CFE20")]
		public static LOPDDMPFOVQ XTVNPYEWDQE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public TMNXRDPPTYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x85D0880", Offset = "0x85CFC80", VA = "0x1885D0880")]
		public TMNXRDPPTYC(TMNXRDPPTYC a, [Optional] GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x85CF1A0", Offset = "0x85CE5A0", VA = "0x1885CF1A0")]
		public void BQPNWAQSTNL(GZYGZQSIZFV a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x85CFF10", Offset = "0x85CF310", VA = "0x1885CFF10")]
		public void YGTNVAGODSK(string a, LOPDDMPFOVQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x85CF5D0", Offset = "0x85CE9D0", VA = "0x1885CF5D0")]
		private void IINCAVOSUAS(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x85CF510", Offset = "0x85CE910", VA = "0x1885CF510")]
		private void GBXOISBLQCG(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x85CF450", Offset = "0x85CE850", VA = "0x1885CF450")]
		private void DBCGIPOONAK(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x85CF850", Offset = "0x85CEC50", VA = "0x1885CF850")]
		internal static Dictionary<string, LOPDDMPFOVQ> SVNRLEPAFYH(GZYGZQSIZFV a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x85CEE20", Offset = "0x85CE220", VA = "0x1885CEE20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public JLGJIUGGAQO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x85C6950", Offset = "0x85C5D50", VA = "0x1885C6950")]
			internal UDJEVNZXQWJ GLHKTQZGMNL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x85C6940", Offset = "0x85C5D40", VA = "0x1885C6940")]
			internal ABAJRTCMWQH GLCDWKFJDCC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x85C6930", Offset = "0x85C5D30", VA = "0x1885C6930")]
			internal WCYSICVUSPP GKWWZDLLTQT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x85C6920", Offset = "0x85C5D20", VA = "0x1885C6920")]
			internal OUKRSZNVFOZ GKRQBWROKFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x85C6910", Offset = "0x85C5D10", VA = "0x1885C6910")]
			internal CPICCNBPKBO GKMJEPXRAUB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x85C6900", Offset = "0x85C5D00", VA = "0x1885C6900")]
			internal LIJTJBKAUDO GKHCHJDTRIS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x85C68F0", Offset = "0x85C5CF0", VA = "0x1885C68F0")]
			internal RLXWJRYFKUW GKBVKCJWHXJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x85C68E0", Offset = "0x85C5CE0", VA = "0x1885C68E0")]
			internal MRVNGWGPAZI GJWOMVPYYMA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x85C68D0", Offset = "0x85C5CD0", VA = "0x1885C68D0")]
			internal SIDFNDXEBQO GJRHPOWBPAR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x85C68C0", Offset = "0x85C5CC0", VA = "0x1885C68C0")]
			internal Sampler GJMASICEFPI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x85C6970", Offset = "0x85C5D70", VA = "0x1885C6970")]
			internal TJCMXEZHJBP YCWEZYZRNPM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x85C6AF0", Offset = "0x85C5EF0", VA = "0x1885C6AF0")]
			internal VOBIMAAHYOP YDBLXFTOXAV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x85C6960", Offset = "0x85C5D60", VA = "0x1885C6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C6140", Offset = "0x85C5540", VA = "0x1885C6140")]
		public GZYGZQSIZFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x85C60A0", Offset = "0x85C54A0", VA = "0x1885C60A0")]
		public TJCMXEZHJBP IIQQUUJFVFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x85C5250", Offset = "0x85C4650", VA = "0x1885C5250")]
		public static GZYGZQSIZFV Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x85C36B0", Offset = "0x85C2AB0", VA = "0x1885C36B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C1330", Offset = "0x85C0730", VA = "0x1885C1330")]
		public TJCMXEZHJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x85CECA0", Offset = "0x85CE0A0", VA = "0x1885CECA0")]
		public static TJCMXEZHJBP Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x85CEA30", Offset = "0x85CDE30", VA = "0x1885CEA30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C1330", Offset = "0x85C0730", VA = "0x1885C1330")]
		public QSDNGVTLXBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x85CBDC0", Offset = "0x85CB1C0", VA = "0x1885CBDC0")]
		public static QSDNGVTLXBY Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x85CBC50", Offset = "0x85CB050", VA = "0x1885CBC50", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class YIWUATQRVRB : VUGBFJSMLDX
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x85C1330", Offset = "0x85C0730", VA = "0x1885C1330")]
		public YIWUATQRVRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x85D41E0", Offset = "0x85D35E0", VA = "0x1885D41E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C1330", Offset = "0x85C0730", VA = "0x1885C1330")]
		public VUGBFJSMLDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x85D37D0", Offset = "0x85D2BD0", VA = "0x1885D37D0", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class YUTNKNPDNZD : VUGBFJSMLDX
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x85C1330", Offset = "0x85C0730", VA = "0x1885C1330")]
		public YUTNKNPDNZD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x85D41E0", Offset = "0x85D35E0", VA = "0x1885D41E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C6870", Offset = "0x85C5C70", VA = "0x1885C6870")]
		public HXKTOYRHGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x85C6570", Offset = "0x85C5970", VA = "0x1885C6570", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x85C2D80", Offset = "0x85C2180", VA = "0x1885C2D80", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public GIIDQZBZLNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class NDEMAERGDYO : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x85C8CE0", Offset = "0x85C80E0", VA = "0x1885C8CE0", Slot = "4")]
		public override LOPDDMPFOVQ Deserialize(GZYGZQSIZFV root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85CBBE0", Offset = "0x85CAFE0", VA = "0x1885CBBE0")]
		public QPAPJZNDHHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x85CB940", Offset = "0x85CAD40", VA = "0x1885CB940")]
		public static QPAPJZNDHHQ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x85CB6E0", Offset = "0x85CAAE0", VA = "0x1885CB6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C21C0", Offset = "0x85C15C0", VA = "0x1885C21C0")]
		public FAZCGRNDBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x85C1ED0", Offset = "0x85C12D0", VA = "0x1885C1ED0")]
		public new static FAZCGRNDBGA Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x85C1E10", Offset = "0x85C1210", VA = "0x1885C1E10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C21C0", Offset = "0x85C15C0", VA = "0x1885C21C0")]
		public OTLVMGECVFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x85CAB40", Offset = "0x85C9F40", VA = "0x1885CAB40")]
		public new static OTLVMGECVFM Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x85CAA80", Offset = "0x85C9E80", VA = "0x1885CAA80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D1170", Offset = "0x85D0570", VA = "0x1885D1170")]
		public TXRBWBBJWFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x85D0E00", Offset = "0x85D0200", VA = "0x1885D0E00")]
		public static TXRBWBBJWFB Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x85D0B70", Offset = "0x85CFF70", VA = "0x1885D0B70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public LRWMZSOUZIR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x85C7D60", Offset = "0x85C7160", VA = "0x1885C7D60")]
			internal MYCFVKCOBHO GLHKTQZGMNL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x85C7CB0", Offset = "0x85C70B0", VA = "0x1885C7CB0")]
			internal Dictionary<string, MYCFVKCOBHO> GLCDWKFJDCC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x85C7BE0", Offset = "0x85C6FE0", VA = "0x1885C7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85CA9E0", Offset = "0x85C9DE0", VA = "0x1885CA9E0")]
		public OKMUISONBMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x85CA340", Offset = "0x85C9740", VA = "0x1885CA340")]
		public OKMUISONBMQ(OKMUISONBMQ a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x85CA160", Offset = "0x85C9560", VA = "0x1885CA160")]
		public static int[] VCHXSZQTNNY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x85C9050", Offset = "0x85C8450", VA = "0x1885C9050")]
		public static int[] APHWNFRFMNA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x85C9FA0", Offset = "0x85C93A0", VA = "0x1885C9FA0")]
		public static int[] UYXZRLPOJRO(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x85C9CF0", Offset = "0x85C90F0", VA = "0x1885C9CF0")]
		public static int[] NLFPDXBANAE(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x85CA200", Offset = "0x85C9600", VA = "0x1885CA200")]
		public static int[] XNOBACDULFR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x85C9F30", Offset = "0x85C9330", VA = "0x1885C9F30")]
		public static int[] PMAPEWBIAIC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x85C9C60", Offset = "0x85C9060", VA = "0x1885C9C60")]
		public static int[] IXGYFBDOGQI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x85C9BF0", Offset = "0x85C8FF0", VA = "0x1885C9BF0")]
		public static int[] GYKLCXBKOKP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x85CA2B0", Offset = "0x85C96B0", VA = "0x1885CA2B0")]
		public static int[] XVYMHWZCELT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x85C97A0", Offset = "0x85C8BA0", VA = "0x1885C97A0")]
		public static OKMUISONBMQ Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x85C91B0", Offset = "0x85C85B0", VA = "0x1885C91B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85CDE90", Offset = "0x85CD290", VA = "0x1885CDE90")]
		public SIDFNDXEBQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x85CD560", Offset = "0x85CC960", VA = "0x1885CD560")]
		public static SIDFNDXEBQO Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x85CC970", Offset = "0x85CBD70", VA = "0x1885CC970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85CE480", Offset = "0x85CD880", VA = "0x1885CE480")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x85CE1B0", Offset = "0x85CD5B0", VA = "0x1885CE1B0")]
		public static Sampler Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x85CDFC0", Offset = "0x85CD3C0", VA = "0x1885CDFC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D2C50", Offset = "0x85D2050", VA = "0x1885D2C50")]
		public VOBIMAAHYOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x85D28F0", Offset = "0x85D1CF0", VA = "0x1885D28F0")]
		public static VOBIMAAHYOP Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x85D25E0", Offset = "0x85D19E0", VA = "0x1885D25E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D4C40", Offset = "0x85D4040", VA = "0x1885D4C40")]
		public ZWTHYTPYMLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x85D4C90", Offset = "0x85D4090", VA = "0x1885D4C90")]
		public ZWTHYTPYMLD(ZWTHYTPYMLD a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x85D48F0", Offset = "0x85D3CF0", VA = "0x1885D48F0")]
		public static ZWTHYTPYMLD Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x85D4890", Offset = "0x85D3C90", VA = "0x1885D4890", Slot = "4")]
		public override void BGVSXQNQAUM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x85D4B70", Offset = "0x85D3F70", VA = "0x1885D4B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x85C7750", Offset = "0x85C6B50", VA = "0x1885C7750")]
		public KRSHTQKOQQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x85C74C0", Offset = "0x85C68C0", VA = "0x1885C74C0")]
		public static KRSHTQKOQQW Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x85C72B0", Offset = "0x85C66B0", VA = "0x1885C72B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D3710", Offset = "0x85D2B10", VA = "0x1885D3710")]
		public VTDZVFVDTJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x85D35F0", Offset = "0x85D29F0", VA = "0x1885D35F0")]
		public VTDZVFVDTJC(VTDZVFVDTJC a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x85D3060", Offset = "0x85D2460", VA = "0x1885D3060")]
		public static VTDZVFVDTJC Deserialize(GZYGZQSIZFV root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x85D3450", Offset = "0x85D2850", VA = "0x1885D3450")]
		public static VTDZVFVDTJC Deserialize(GZYGZQSIZFV root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x85D2D00", Offset = "0x85D2100", VA = "0x1885D2D00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public DJAAZOVELES(IList<VUGBFJSMLDX> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x85C13F0", Offset = "0x85C07F0", VA = "0x1885C13F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x85C1380", Offset = "0x85C0780", VA = "0x1885C1380", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D2560", Offset = "0x85D1960", VA = "0x1885D2560")]
		public UPJKNCLUWXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x85D1AE0", Offset = "0x85D0EE0", VA = "0x1885D1AE0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x85D2010", Offset = "0x85D1410", VA = "0x1885D2010", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x85D1D60", Offset = "0x85D1160", VA = "0x1885D1D60")]
		private static string[] JNAJDEHOQJC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x85D2100", Offset = "0x85D1500", VA = "0x1885D2100")]
		private static GDYMUWMMRMB.ImportValuesConversion VRBRHZNOVRU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x85D16F0", Offset = "0x85D0AF0", VA = "0x1885D16F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x85CB590", Offset = "0x85CA990", VA = "0x1885CB590", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x85CB550", Offset = "0x85CA950", VA = "0x1885CB550")]
		public QDTAQPASXJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x85CB470", Offset = "0x85CA870", VA = "0x1885CB470")]
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
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public YHFFVQPHPRY(QDTAQPASXJH a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x85D4120", Offset = "0x85D3520", VA = "0x1885D4120")]
		public YHFFVQPHPRY(int a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x85D3FA0", Offset = "0x85D33A0", VA = "0x1885D3FA0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x85D4020", Offset = "0x85D3420", VA = "0x1885D4020", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class COFSZGZUFSP : SWSIXEMFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x85C0F40", Offset = "0x85C0340", VA = "0x1885C0F40")]
		public COFSZGZUFSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x85C0A50", Offset = "0x85BFE50", VA = "0x1885C0A50", Slot = "4")]
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
