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
	public class KHR_animation_pointer : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object UBRLADRRHTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string GDJDRRZCJEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string GIONKQMMPTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public RXJYREPLVAW IPNKVKJXKAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer YOFERHVCXDT;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x706F610", Offset = "0x706EA10", VA = "0x18706F610", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x706F560", Offset = "0x706E960", VA = "0x18706F560", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class FQBKVGTUEHZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 HVUDUIJUMQU;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 NWJNSWUOLPZ;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion DVOHRYOJSMD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool CTIMVSGRGTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7067E40", Offset = "0x7067240", VA = "0x187067E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7069A30", Offset = "0x7068E30", VA = "0x187069A30")]
		public static void VDTCPXQVQRZ(this CFDTQFFCTZU a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7068850", Offset = "0x7067C50", VA = "0x187068850")]
		public static void LGNAMKHWJIJ(this CFDTQFFCTZU a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7067ED0", Offset = "0x70672D0", VA = "0x187067ED0")]
		public static void HBZZJODXOII(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7066D50", Offset = "0x7066150", VA = "0x187066D50")]
		public static GLTF.Math.Vector4 AYNSCBGOUXC(this LUXQQMJINMF a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7069000", Offset = "0x7068400", VA = "0x187069000")]
		public static UnityEngine.Quaternion QEMPDLHSIPB(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7069180", Offset = "0x7068580", VA = "0x187069180")]
		public static UnityEngine.Quaternion QEMPDLHSIPB(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x706A4E0", Offset = "0x70698E0", VA = "0x18706A4E0")]
		public static GLTF.Math.Quaternion YNQUHKSBXEJ(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x70676F0", Offset = "0x7066AF0", VA = "0x1870676F0")]
		public static Matrix4x4 EJMEUVQLFUC(this LUXQQMJINMF a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x70672B0", Offset = "0x70666B0", VA = "0x1870672B0")]
		public static Matrix4x4 EJMEUVQLFUC(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7067B00", Offset = "0x7066F00", VA = "0x187067B00")]
		public static LUXQQMJINMF GJFAFPHAOOQ(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x70679E0", Offset = "0x7066DE0", VA = "0x1870679E0")]
		public static UnityEngine.Vector3 EOGIVCOWQQD(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7067910", Offset = "0x7066D10", VA = "0x187067910")]
		public static UnityEngine.Vector3 EOGIVCOWQQD(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7067100", Offset = "0x7066500", VA = "0x187067100")]
		public static GLTF.Math.Vector3 DDZYYYYJRCR(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x706A2C0", Offset = "0x70696C0", VA = "0x18706A2C0")]
		public static GLTF.Math.Vector3 YEZYGVXPRVO(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x104A180", Offset = "0x1049580", VA = "0x18104A180")]
		public static GLTF.Math.Vector4 PXYOETTGVBV(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7068510", Offset = "0x7067910", VA = "0x187068510")]
		public static Matrix4x4 HKMPCQXPDNV(this LUXQQMJINMF a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x70682A0", Offset = "0x70676A0", VA = "0x1870682A0")]
		public static Matrix4x4 HKMPCQXPDNV(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x70692B0", Offset = "0x70686B0", VA = "0x1870692B0")]
		public static LUXQQMJINMF RYMYTONDNBX(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x706A120", Offset = "0x7069520", VA = "0x18706A120")]
		public static UnityEngine.Vector2 XJYEDTJCAKD(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x706A120", Offset = "0x7069520", VA = "0x18706A120")]
		public static UnityEngine.Vector2 XJYEDTJCAKD(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x706A140", Offset = "0x7069540", VA = "0x18706A140")]
		public static void XJYEDTJCAKD(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7068FA0", Offset = "0x70683A0", VA = "0x187068FA0")]
		public static UnityEngine.Vector3 NNAMGSRSECW(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1A3CF30", Offset = "0x1A3C330", VA = "0x181A3CF30")]
		public static UnityEngine.Vector3 NNAMGSRSECW(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7068EB0", Offset = "0x70682B0", VA = "0x187068EB0")]
		public static void NNAMGSRSECW(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x104A180", Offset = "0x1049580", VA = "0x18104A180")]
		public static UnityEngine.Vector4 UAUDXNDDBDD(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x104A180", Offset = "0x1049580", VA = "0x18104A180")]
		public static UnityEngine.Vector4 UAUDXNDDBDD(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x70698B0", Offset = "0x7068CB0", VA = "0x1870698B0")]
		public static UnityEngine.Vector4[] UAUDXNDDBDD(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x70697A0", Offset = "0x7068BA0", VA = "0x1870697A0")]
		public static void UAUDXNDDBDD(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x706A440", Offset = "0x7069840", VA = "0x18706A440")]
		public static UnityEngine.Color YFVFGCWYINF(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x706A300", Offset = "0x7069700", VA = "0x18706A300")]
		public static void YFVFGCWYINF(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x706A440", Offset = "0x7069840", VA = "0x18706A440")]
		public static UnityEngine.Color YFVFGCWYINF(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x104A180", Offset = "0x1049580", VA = "0x18104A180")]
		public static UnityEngine.Color SMTYVIUKPFM(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7069480", Offset = "0x7068880", VA = "0x187069480")]
		public static void SMTYVIUKPFM(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x104A180", Offset = "0x1049580", VA = "0x18104A180")]
		public static UnityEngine.Color SMTYVIUKPFM(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7066F70", Offset = "0x7066370", VA = "0x187066F70")]
		public static GLTF.Math.Color BBNRPEPQLHO(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x70699B0", Offset = "0x7068DB0", VA = "0x1870699B0")]
		public static GLTF.Math.Color UBSJWJZFQSD(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7067230", Offset = "0x7066630", VA = "0x187067230")]
		public static GLTF.Math.Color DTHUXZILPIL(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x706A000", Offset = "0x7069400", VA = "0x18706A000")]
		public static UnityEngine.Color[] XDKHICKNKDA(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x70687D0", Offset = "0x7067BD0", VA = "0x1870687D0")]
		public static int[] LDQXJSBQZMR(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x706A210", Offset = "0x7069610", VA = "0x18706A210")]
		public static UnityEngine.Vector2[] XKPZWLOHOAK(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7068D50", Offset = "0x7068150", VA = "0x187068D50")]
		public static void LNLOMVYMVAJ(WCFAQEMIIMZ a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7066FA0", Offset = "0x70663A0", VA = "0x187066FA0")]
		public static UnityEngine.Vector3[] CRKKROJRNST(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7069600", Offset = "0x7068A00", VA = "0x187069600")]
		public static UnityEngine.Vector4[] STWFDACOIUS(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7069590", Offset = "0x7068990", VA = "0x187069590")]
		public static void SNGYJODEEZL(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7069FD0", Offset = "0x70693D0", VA = "0x187069FD0")]
		public static UnityEngine.Quaternion WCKXBMFZIBP(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class WCFAQEMIIMZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ZIHJPSCCEDS ZIHJPSCCEDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray ZCSSSXIPXVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x707ACB0", Offset = "0x707A0B0", VA = "0x18707ACB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> MKXTZJAAAVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xBB85E0", Offset = "0xBB79E0", VA = "0x180BB85E0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xC99FF0", Offset = "0xC993F0", VA = "0x180C99FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint TSALMPZNIUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAAF800", Offset = "0xAAEC00", VA = "0x180AAF800")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAAF7F0", Offset = "0xAAEBF0", VA = "0x180AAF7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x707ACC0", Offset = "0x707A0C0", VA = "0x18707ACC0")]
		public WCFAQEMIIMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x706A6D0", Offset = "0x7069AD0", VA = "0x18706A6D0")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x706A730", Offset = "0x7069B30", VA = "0x18706A730")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class PJDREQOARMM
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class AAMLVDACMDZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> ZKOGRNDREQF;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public AAMLVDACMDZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x705F860", Offset = "0x705EC60", VA = "0x18705F860")]
			internal int? PINNTQRIMPY(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x705F9B0", Offset = "0x705EDB0", VA = "0x18705F9B0")]
			internal int? XIEGPCZKELH(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x705F8E0", Offset = "0x705ECE0", VA = "0x18705F8E0")]
			internal bool QXXXNZMXPFP(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7077C40", Offset = "0x7077040", VA = "0x187077C40")]
		private static void WUHLWULHUSR(NumericArray a, WCFAQEMIIMZ b, WCFAQEMIIMZ c, WCFAQEMIIMZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7076980", Offset = "0x7075D80", VA = "0x187076980")]
		public static void MVHSFAFLQHE(Dictionary<string, WCFAQEMIIMZ> a, Dictionary<string, (WCFAQEMIIMZ sparseIndices, WCFAQEMIIMZ sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x70764A0", Offset = "0x70758A0", VA = "0x1870764A0")]
		public static void MKNQXOVZTJM(Dictionary<string, WCFAQEMIIMZ> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7075F10", Offset = "0x7075310", VA = "0x187075F10")]
		public static void EIPMYJTSWAN(WCFAQEMIIMZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7075980", Offset = "0x7074D80", VA = "0x187075980")]
		public static void EFEDZAOZBER(Dictionary<string, List<WCFAQEMIIMZ>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x70781B0", Offset = "0x70775B0", VA = "0x1870781B0")]
		private static void YIFXLXWCZWZ(WCFAQEMIIMZ a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x70782E0", Offset = "0x70776E0", VA = "0x1870782E0")]
		internal static void YIFXLXWCZWZ(SAALMDNJRJD a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7076010", Offset = "0x7075410", VA = "0x187076010")]
		public static GDEBWNCDUBF LUQOTLIUHXX(IEnumerable<GDEBWNCDUBF> a)
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
			[Cpp2IlInjected.Address(RVA = "0xC6C430", Offset = "0xC6B830", VA = "0x180C6C430")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2DAC240", Offset = "0x2DAB640", VA = "0x182DAC240")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2DAC250", Offset = "0x2DAB650", VA = "0x182DAC250")]
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
	public class BEDUBDSRUPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint MXDZKCLAWTL;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint WDMMLZAEBST;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint UANKOPKWOLN;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7060DE0", Offset = "0x70601E0", VA = "0x187060DE0")]
		public static void VBDXUIUQHLF(Stream a, [Out] FZUMGSVMSUT b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x70608A0", Offset = "0x705FCA0", VA = "0x1870608A0")]
		public static ChunkInfo GVSEJMWGTVV(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7060B30", Offset = "0x705FF30", VA = "0x187060B30")]
		public static GLBHeader OUNXEIEKVCV(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7060FA0", Offset = "0x70603A0", VA = "0x187060FA0")]
		public static bool XFDAHEVXMRP(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7060C70", Offset = "0x7060070", VA = "0x187060C70")]
		public static ChunkInfo QMJSSKIAUHA(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7060600", Offset = "0x705FA00", VA = "0x187060600")]
		private static void ETLPZCLYFZW(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7060570", Offset = "0x705F970", VA = "0x187060570")]
		private static uint BMEWWYPAQST(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class VHNTIPKVFGY
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
		public PathElement IEXHMQIQUAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int LJHVHRDBFNE
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xC4E2B0", Offset = "0xC4D6B0", VA = "0x180C4E2B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCDF260", Offset = "0xCDE660", VA = "0x180CDF260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string FDQRKIZQYHP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool YVVTLYAECUE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA010", Offset = "0xAA9410", VA = "0x180AAA010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAAA830", Offset = "0xAA9C30", VA = "0x180AAA830")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public VHNTIPKVFGY FZQNFCVVTFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x707A160", Offset = "0x7079560", VA = "0x18707A160")]
		public string CLCWHRFCMYU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x707A3C0", Offset = "0x70797C0", VA = "0x18707A3C0")]
		public VHNTIPKVFGY NHTEEMJMKOA(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x707A3E0", Offset = "0x70797E0", VA = "0x18707A3E0")]
		private VHNTIPKVFGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x707A440", Offset = "0x7079840", VA = "0x18707A440")]
		public VHNTIPKVFGY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x412F590", Offset = "0x412E990", VA = "0x18412F590")]
		[CompilerGenerated]
		internal static string JXYCZNCUKJW(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x707A120", Offset = "0x7079520", VA = "0x18707A120")]
		[CompilerGenerated]
		internal static bool CKCTMVPFYDF([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x707A1E0", Offset = "0x70795E0", VA = "0x18707A1E0")]
		[CompilerGenerated]
		internal static VHNTIPKVFGY ETFEZZSTGYZ(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class EUPDZLXTBFX
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7066740", Offset = "0x7065B40", VA = "0x187066740")]
		public static int[] QRZWGXHQKAJ(this FZUMGSVMSUT a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x70665F0", Offset = "0x70659F0", VA = "0x1870665F0")]
		public static int[] FKLSXIZVLAD(this FZUMGSVMSUT a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class JIUFMCVQLAR
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x706C3B0", Offset = "0x706B7B0", VA = "0x18706C3B0")]
		public static uint VYGBHNGLCIK(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream OPLGWAIWWDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long APRWZDDZGVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long OMQJCZUIPSQ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7079BD0", Offset = "0x7078FD0", VA = "0x187079BD0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7079C10", Offset = "0x7079010", VA = "0x187079C10", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7079C10", Offset = "0x7079010", VA = "0x187079C10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7079C30", Offset = "0x7079030", VA = "0x187079C30", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7079C50", Offset = "0x7079050", VA = "0x187079C50", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7079C70", Offset = "0x7079070", VA = "0x187079C70", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7079960", Offset = "0x7078D60", VA = "0x187079960")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x70797B0", Offset = "0x7078BB0", VA = "0x1870797B0", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7079880", Offset = "0x7078C80", VA = "0x187079880", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x70798E0", Offset = "0x7078CE0", VA = "0x1870798E0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x70797F0", Offset = "0x7078BF0", VA = "0x1870797F0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7079920", Offset = "0x7078D20", VA = "0x187079920", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7079720", Offset = "0x7078B20", VA = "0x187079720")]
		private void AWXLOWNMTVL()
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
		public static Color JVIESKVLPWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x70615B0", Offset = "0x70609B0", VA = "0x1870615B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color BJLRGUINIXR
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x70615A0", Offset = "0x70609A0", VA = "0x1870615A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color OMQAZCQSOJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7061580", Offset = "0x7060980", VA = "0x187061580")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC76B0", Offset = "0x2AC6AB0", VA = "0x182AC76B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC92B0", Offset = "0x2AC86B0", VA = "0x182AC92B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B226C0", Offset = "0x2B21AC0", VA = "0x182B226C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B226D0", Offset = "0x2B21AD0", VA = "0x182B226D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x28A2280", Offset = "0x28A1680", VA = "0x1828A2280")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2FA05C0", Offset = "0x2F9F9C0", VA = "0x182FA05C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x11F8460", Offset = "0x11F7860", VA = "0x1811F8460")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x11F8470", Offset = "0x11F7870", VA = "0x1811F8470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28643A0", Offset = "0x28637A0", VA = "0x1828643A0")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7061380", Offset = "0x7060780", VA = "0x187061380", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7061430", Offset = "0x7060830", VA = "0x187061430", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x70614D0", Offset = "0x70608D0", VA = "0x1870614D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x70615D0", Offset = "0x70609D0", VA = "0x1870615D0")]
		public static bool ZPGHGHNXRJT(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class LUXQQMJINMF : IEquatable<LUXQQMJINMF>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly LUXQQMJINMF CVYDPLSSLYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] WZEVWWQIZSM;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float AJDKJUKWJKD
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7073530", Offset = "0x7072930", VA = "0x187073530")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7073140", Offset = "0x7072540", VA = "0x187073140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float UEIAHTJPJVC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7072C30", Offset = "0x7072030", VA = "0x187072C30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x70732C0", Offset = "0x70726C0", VA = "0x1870732C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float NKNVTXCBCYN
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7073290", Offset = "0x7072690", VA = "0x187073290")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x70734A0", Offset = "0x70728A0", VA = "0x1870734A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float IFQKFDZUPFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7073410", Offset = "0x7072810", VA = "0x187073410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7072D20", Offset = "0x7072120", VA = "0x187072D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float AJIRHBETSVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7073590", Offset = "0x7072990", VA = "0x187073590")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x70731A0", Offset = "0x70725A0", VA = "0x1870731A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float UEXUZNRHMDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7072C60", Offset = "0x7072060", VA = "0x187072C60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x70732F0", Offset = "0x70726F0", VA = "0x1870732F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float NJYBCCUJAQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7073260", Offset = "0x7072660", VA = "0x187073260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7073470", Offset = "0x7072870", VA = "0x187073470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float IFLDHXFXFUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x70733B0", Offset = "0x70727B0", VA = "0x1870733B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7072CC0", Offset = "0x70720C0", VA = "0x187072CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float AJNYEHYRCGV
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7073560", Offset = "0x7072960", VA = "0x187073560")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7073170", Offset = "0x7072570", VA = "0x187073170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float UESOCGXKCRU
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7072C90", Offset = "0x7072090", VA = "0x187072C90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7073320", Offset = "0x7072720", VA = "0x187073320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float NKDHZJOGKBV
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7073230", Offset = "0x7072630", VA = "0x187073230")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7073440", Offset = "0x7072840", VA = "0x187073440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float IFFWKQLZWJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x70733E0", Offset = "0x70727E0", VA = "0x1870733E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7072CF0", Offset = "0x70720F0", VA = "0x187072CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float AJTFBOSOLSE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7073500", Offset = "0x7072900", VA = "0x187073500")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x70731D0", Offset = "0x70725D0", VA = "0x1870731D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float UFIIUBFCEZV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7072C00", Offset = "0x7072000", VA = "0x187072C00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7073350", Offset = "0x7072750", VA = "0x187073350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float NJNNHPGOHTU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7073200", Offset = "0x7072600", VA = "0x187073200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x70734D0", Offset = "0x70728D0", VA = "0x1870734D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float IFAPNJSCMXT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7073380", Offset = "0x7072780", VA = "0x187073380")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7072D50", Offset = "0x7072150", VA = "0x187072D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7073690", Offset = "0x7072A90", VA = "0x187073690")]
		public LUXQQMJINMF(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7072D80", Offset = "0x7072180", VA = "0x187072D80", Slot = "4")]
		public bool Equals(LUXQQMJINMF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7073040", Offset = "0x7072440", VA = "0x187073040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xDC9C80", Offset = "0xDC9080", VA = "0x180DC9C80", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AC76B0", Offset = "0x2AC6AB0", VA = "0x182AC76B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x2AC92B0", Offset = "0x2AC86B0", VA = "0x182AC92B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2B226C0", Offset = "0x2B21AC0", VA = "0x182B226C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2B226D0", Offset = "0x2B21AD0", VA = "0x182B226D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x28A2280", Offset = "0x28A1680", VA = "0x1828A2280")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x2FA05C0", Offset = "0x2F9F9C0", VA = "0x182FA05C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x11F8460", Offset = "0x11F7860", VA = "0x1811F8460")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x11F8470", Offset = "0x11F7870", VA = "0x1811F8470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7078C00", Offset = "0x7078000", VA = "0x187078C00")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7078870", Offset = "0x7077C70", VA = "0x187078870", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7078990", Offset = "0x7077D90", VA = "0x187078990", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7078A40", Offset = "0x7077E40", VA = "0x187078A40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7078B20", Offset = "0x7077F20", VA = "0x187078B20")]
		public static bool ZPGHGHNXRJT(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2AC76B0", Offset = "0x2AC6AB0", VA = "0x182AC76B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x2AC92B0", Offset = "0x2AC86B0", VA = "0x182AC92B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2B226C0", Offset = "0x2B21AC0", VA = "0x182B226C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2B226D0", Offset = "0x2B21AD0", VA = "0x182B226D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xD38970", Offset = "0xD37D70", VA = "0x180D38970")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x707A7E0", Offset = "0x7079BE0", VA = "0x18707A7E0")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x707A5F0", Offset = "0x70799F0", VA = "0x18707A5F0", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x707A650", Offset = "0x7079A50", VA = "0x18707A650", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x707A730", Offset = "0x7079B30", VA = "0x18707A730", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x707A780", Offset = "0x7079B80", VA = "0x18707A780")]
		public static bool ZPGHGHNXRJT(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2AC76B0", Offset = "0x2AC6AB0", VA = "0x182AC76B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x2AC92B0", Offset = "0x2AC86B0", VA = "0x182AC92B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2B226C0", Offset = "0x2B21AC0", VA = "0x182B226C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2B226D0", Offset = "0x2B21AD0", VA = "0x182B226D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x28A2280", Offset = "0x28A1680", VA = "0x1828A2280")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x2FA05C0", Offset = "0x2F9F9C0", VA = "0x182FA05C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x707AB90", Offset = "0x7079F90", VA = "0x18707AB90")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x707A800", Offset = "0x7079C00", VA = "0x18707A800", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x707A8E0", Offset = "0x7079CE0", VA = "0x18707A8E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x707A9A0", Offset = "0x7079DA0", VA = "0x18707A9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x707AA50", Offset = "0x7079E50", VA = "0x18707AA50")]
		public static bool ZPGHGHNXRJT(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2AC76B0", Offset = "0x2AC6AB0", VA = "0x182AC76B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2AC92B0", Offset = "0x2AC86B0", VA = "0x182AC92B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B226C0", Offset = "0x2B21AC0", VA = "0x182B226C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2B226D0", Offset = "0x2B21AD0", VA = "0x182B226D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x28A2280", Offset = "0x28A1680", VA = "0x1828A2280")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x2FA05C0", Offset = "0x2F9F9C0", VA = "0x182FA05C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x11F8460", Offset = "0x11F7860", VA = "0x1811F8460")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x11F8470", Offset = "0x11F7870", VA = "0x1811F8470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28643A0", Offset = "0x28637A0", VA = "0x1828643A0")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7061380", Offset = "0x7060780", VA = "0x187061380", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x707AC10", Offset = "0x707A010", VA = "0x18707AC10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x70614D0", Offset = "0x70608D0", VA = "0x1870614D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class DKTATBIBFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7061AC0", Offset = "0x7060EC0", VA = "0x187061AC0")]
		public static void JQJXFUIIGYA(this JObject a, string b, GQTAFWBMEER c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class JIUFMCVQLAR
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x706CC10", Offset = "0x706C010", VA = "0x18706CC10")]
		public static List<string> ZBTXBDJSKRN(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x706B830", Offset = "0x706AC30", VA = "0x18706B830")]
		public static List<double> KGRUJSEXMXF(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x706C500", Offset = "0x706B900", VA = "0x18706C500")]
		public static List<int> XLLFCMFYRSO(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x36CC5A0", Offset = "0x36CB9A0", VA = "0x1836CC5A0")]
		public static List<a> FGWJYPBWSHE<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x706C960", Offset = "0x706BD60", VA = "0x18706C960")]
		public static GQTAFWBMEER YUNFEBDIJWU(this JToken a, FZUMGSVMSUT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x706AFE0", Offset = "0x706A3E0", VA = "0x18706AFE0")]
		public static int ECNFXTOFYTY(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x706B120", Offset = "0x706A520", VA = "0x18706B120")]
		public static double FZDWVLKAGGE(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x706B9F0", Offset = "0x706ADF0", VA = "0x18706B9F0")]
		public static GLTF.Math.Color NXMBZHBIZPZ(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x706BCD0", Offset = "0x706B0D0", VA = "0x18706BCD0")]
		public static GLTF.Math.Color UAFAHWVZJSY(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x706C6C0", Offset = "0x706BAC0", VA = "0x18706C6C0")]
		public static GLTF.Math.Color XVUUWKKHHMM(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x706B570", Offset = "0x706A970", VA = "0x18706B570")]
		public static GLTF.Math.Vector3 IRRTRZKJWYO(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x706BF40", Offset = "0x706B340", VA = "0x18706BF40")]
		public static GLTF.Math.Vector2 UGKFKKTTDKI(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x706C150", Offset = "0x706B550", VA = "0x18706C150")]
		public static GLTF.Math.Vector3 UGPMHRNQMVR(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x706B260", Offset = "0x706A660", VA = "0x18706B260")]
		public static GLTF.Math.Quaternion HBSJJEITPTY(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x36CCC40", Offset = "0x36CC040", VA = "0x1836CCC40")]
		public static Dictionary<string, b> TPRSANAVVHU<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x36CC8F0", Offset = "0x36CBCF0", VA = "0x1836CC8F0")]
		public static c QXEVBBLFKUG<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public SAALMDNJRJD bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7066BA0", Offset = "0x7065FA0", VA = "0x187066BA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7066B20", Offset = "0x7065F20", VA = "0x187066B20", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class USGJIXXOLPS : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x707A0D0", Offset = "0x70794D0", VA = "0x18707A0D0")]
		public USGJIXXOLPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x707A000", Offset = "0x7079400", VA = "0x18707A000", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, ZIHJPSCCEDS> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x70669E0", Offset = "0x7065DE0", VA = "0x1870669E0", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7066AA0", Offset = "0x7065EA0", VA = "0x187066AA0")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class IBXDNRSVYQC : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class OFEBALTHFAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public FZUMGSVMSUT XUVHPHBAVDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader IZDTMXKHPZD;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OFEBALTHFAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7074F80", Offset = "0x7074380", VA = "0x187074F80")]
			internal ZIHJPSCCEDS NJQFYZWQOAN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x706AB80", Offset = "0x7069F80", VA = "0x18706AB80")]
		public IBXDNRSVYQC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x706A9F0", Offset = "0x7069DF0", VA = "0x18706A9F0", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public OEAGHAUWJNY GHDQVXYJJAH;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public EXT_texture_exr(OEAGHAUWJNY source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7066BF0", Offset = "0x7065FF0", VA = "0x187066BF0", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7066C60", Offset = "0x7066060", VA = "0x187066C60", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class SFIMZXTEFAH : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7079150", Offset = "0x7078550", VA = "0x187079150")]
		public SFIMZXTEFAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7079030", Offset = "0x7078430", VA = "0x187079030", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
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
	public class AudioEmitterId : KRZMTUYAXDL<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x7060290", Offset = "0x705F690", VA = "0x187060290", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7060250", Offset = "0x705F650", VA = "0x187060250")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : KRZMTUYAXDL<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7060420", Offset = "0x705F820", VA = "0x187060420", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x70603E0", Offset = "0x705F7E0", VA = "0x1870603E0")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : KRZMTUYAXDL<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7060100", Offset = "0x705F500", VA = "0x187060100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x70600C0", Offset = "0x705F4C0", VA = "0x1870600C0")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x705FFE0", Offset = "0x705F3E0", VA = "0x18705FFE0")]
		public static AudioDataId Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x706F280", Offset = "0x706E680", VA = "0x18706F280", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x706EE80", Offset = "0x706E280", VA = "0x18706EE80", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x706EEF0", Offset = "0x706E2F0", VA = "0x18706EEF0")]
		public static KHR_SceneAudioEmittersRef Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x706F4E0", Offset = "0x706E8E0", VA = "0x18706F4E0")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x706EE50", Offset = "0x706E250", VA = "0x18706EE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x706ED30", Offset = "0x706E130", VA = "0x18706ED30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x706EB20", Offset = "0x706DF20", VA = "0x18706EB20", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x706EB90", Offset = "0x706DF90", VA = "0x18706EB90")]
		public static KHR_NodeAudioEmitterRef Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class NQHXROQMSRI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string ANYKPRAPRCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? WEDIBHDUEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? SFVLCGTMBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? RIVIUIXDQMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? BAPRIERHGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? HMHIXAWWNKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? HEHYUCXKXRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? IXVXNEOGQZH;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7074610", Offset = "0x7073A10", VA = "0x187074610")]
		public JObject CQVTSUWTJSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7074880", Offset = "0x7073C80", VA = "0x187074880")]
		public static NQHXROQMSRI Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public NQHXROQMSRI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : TTMGPQQKCWP
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
		public NQHXROQMSRI positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x706DC70", Offset = "0x706D070", VA = "0x18706DC70", Slot = "5")]
		public virtual JObject CQVTSUWTJSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x706E010", Offset = "0x706D410", VA = "0x18706E010")]
		public static KHR_AudioEmitter Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x706E510", Offset = "0x706D910", VA = "0x18706E510")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : TTMGPQQKCWP
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
		[Cpp2IlInjected.Address(RVA = "0x706E590", Offset = "0x706D990", VA = "0x18706E590")]
		public JObject CQVTSUWTJSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x706E7C0", Offset = "0x706DBC0", VA = "0x18706E7C0")]
		public static KHR_AudioSource Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x70665E0", Offset = "0x70659E0", VA = "0x1870665E0")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : TTMGPQQKCWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AUBFOGSNMLW bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x706D8E0", Offset = "0x706CCE0", VA = "0x18706D8E0")]
		public JObject CQVTSUWTJSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x706DA10", Offset = "0x706CE10", VA = "0x18706DA10")]
		public static KHR_AudioData Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x70665E0", Offset = "0x70659E0", VA = "0x1870665E0")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : CWFORSLEVMO
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
		[Cpp2IlInjected.Address(RVA = "0x706F7A0", Offset = "0x706EBA0", VA = "0x18706F7A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x706F710", Offset = "0x706EB10", VA = "0x18706F710", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x706FED0", Offset = "0x706F2D0", VA = "0x18706FED0")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class NBFKXHDEUFT : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x70745C0", Offset = "0x70739C0", VA = "0x1870745C0")]
		public NBFKXHDEUFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7073A10", Offset = "0x7072E10", VA = "0x187073A10", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AUBFOGSNMLW bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x70700A0", Offset = "0x706F4A0", VA = "0x1870700A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x706FFE0", Offset = "0x706F3E0", VA = "0x18706FFE0", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x70700F0", Offset = "0x706F4F0", VA = "0x1870700F0")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class HHFRLLFTJOH : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class OFEBALTHFAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader IZDTMXKHPZD;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OFEBALTHFAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7075030", Offset = "0x7074430", VA = "0x187075030")]
			internal int NJQFYZWQOAN()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x706A9A0", Offset = "0x7069DA0", VA = "0x18706A9A0")]
		public HHFRLLFTJOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x706A790", Offset = "0x7069B90", VA = "0x18706A790", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public GQTAFWBMEER anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x70701F0", Offset = "0x706F5F0", VA = "0x1870701F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7070170", Offset = "0x706F570", VA = "0x187070170", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class XFWODXYZRQE : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x707AEA0", Offset = "0x707A2A0", VA = "0x18707AEA0")]
		public XFWODXYZRQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x707ACF0", Offset = "0x707A0F0", VA = "0x18707ACF0", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public GQTAFWBMEER clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public GQTAFWBMEER clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public GQTAFWBMEER clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x70704A0", Offset = "0x706F8A0", VA = "0x1870704A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7070400", Offset = "0x706F800", VA = "0x187070400", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class SRDTANONEKY : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x70796D0", Offset = "0x7078AD0", VA = "0x1870796D0")]
		public SRDTANONEKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7079450", Offset = "0x7078850", VA = "0x187079450", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7070800", Offset = "0x706FC00", VA = "0x187070800", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7070790", Offset = "0x706FB90", VA = "0x187070790", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class DNAAADHGYAS : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7061C10", Offset = "0x7061010", VA = "0x187061C10")]
		public DNAAADHGYAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7061B40", Offset = "0x7060F40", VA = "0x187061B40", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : RNTVAREHKRE, CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float LDKEBQAAOTO;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7070AE0", Offset = "0x706FEE0", VA = "0x187070AE0")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7070B30", Offset = "0x706FF30", VA = "0x187070B30")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, FZUMGSVMSUT root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7070920", Offset = "0x706FD20", VA = "0x187070920", Slot = "6")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x70709C0", Offset = "0x706FDC0", VA = "0x1870709C0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class QVALRPFPZLF : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7078820", Offset = "0x7077C20", VA = "0x187078820")]
		public QVALRPFPZLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7078720", Offset = "0x7077B20", VA = "0x187078720", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7070C00", Offset = "0x7070000", VA = "0x187070C00", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7070BA0", Offset = "0x706FFA0", VA = "0x187070BA0", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7070D50", Offset = "0x7070150", VA = "0x187070D50")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class DIUCHFWKCQE : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7061A70", Offset = "0x7060E70", VA = "0x187061A70")]
		public DIUCHFWKCQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x70619A0", Offset = "0x7060DA0", VA = "0x1870619A0", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public GQTAFWBMEER iridescenceTexture;

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
		public GQTAFWBMEER iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7070E00", Offset = "0x7070200", VA = "0x187070E00", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7070D60", Offset = "0x7070160", VA = "0x187070D60", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x70711C0", Offset = "0x70705C0", VA = "0x1870711C0")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class AOABYDCMGUK : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x705FD30", Offset = "0x705F130", VA = "0x18705FD30")]
		public AOABYDCMGUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x705FA40", Offset = "0x705EE40", VA = "0x18705FA40", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class JUONWFCJJIB : CWFORSLEVMO
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 BAYXKHPUJOD;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double HVLAHSKNHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color ZSMRNEWGTPF;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color THOVPUUTRSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public GQTAFWBMEER WRESFTJMFZZ;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly GQTAFWBMEER TUHPTCFEURE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 DFDTMVYWXFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double GNXBQDHXMTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public GQTAFWBMEER GIHOJMFAUVC;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly GQTAFWBMEER XGRGNFYICFC;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x706D6C0", Offset = "0x706CAC0", VA = "0x18706D6C0")]
		public JUONWFCJJIB(GLTF.Math.Color a, GQTAFWBMEER b, GLTF.Math.Vector3 c, double d, GQTAFWBMEER e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x706CDC0", Offset = "0x706C1C0", VA = "0x18706CDC0", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x706CF70", Offset = "0x706C370", VA = "0x18706CF70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class RSLRYDRKDWN : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7078FE0", Offset = "0x70783E0", VA = "0x187078FE0")]
		public RSLRYDRKDWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7078C90", Offset = "0x7078090", VA = "0x187078C90", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public GQTAFWBMEER sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public GQTAFWBMEER sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x70712B0", Offset = "0x70706B0", VA = "0x1870712B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x70711E0", Offset = "0x70705E0", VA = "0x1870711E0", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x70717C0", Offset = "0x7070BC0", VA = "0x1870717C0")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class SHRUSTNCIQP : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7079400", Offset = "0x7078800", VA = "0x187079400")]
		public SHRUSTNCIQP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x70791A0", Offset = "0x70785A0", VA = "0x1870791A0", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GQTAFWBMEER specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public GQTAFWBMEER specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x70718F0", Offset = "0x7070CF0", VA = "0x1870718F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7071820", Offset = "0x7070C20", VA = "0x187071820", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7071E00", Offset = "0x7071200", VA = "0x187071E00")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class JDUHDRKGSCR : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x706AF90", Offset = "0x706A390", VA = "0x18706AF90")]
		public JDUHDRKGSCR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x706AD20", Offset = "0x706A120", VA = "0x18706AD20", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public GQTAFWBMEER transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7071EF0", Offset = "0x70712F0", VA = "0x187071EF0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7071E70", Offset = "0x7071270", VA = "0x187071E70", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class QLAOKPHWBAU : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x70786D0", Offset = "0x7077AD0", VA = "0x1870786D0")]
		public QLAOKPHWBAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7078590", Offset = "0x7077990", VA = "0x187078590", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class CKVYGNPBLRH : RNTVAREHKRE, CWFORSLEVMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7061330", Offset = "0x7060730", VA = "0x187061330")]
		public CKVYGNPBLRH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x70612C0", Offset = "0x70606C0", VA = "0x1870612C0")]
		public CKVYGNPBLRH(CKVYGNPBLRH a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7061150", Offset = "0x7060550", VA = "0x187061150", Slot = "6")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x70610C0", Offset = "0x70604C0", VA = "0x1870610C0", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x70611F0", Offset = "0x70605F0", VA = "0x1870611F0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class LZYSVWKIRVH : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x70739C0", Offset = "0x7072DC0", VA = "0x1870739C0")]
		public LZYSVWKIRVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7073940", Offset = "0x7072D40", VA = "0x187073940", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public GQTAFWBMEER thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7072110", Offset = "0x7071510", VA = "0x187072110", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7072080", Offset = "0x7071480", VA = "0x187072080", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7072630", Offset = "0x7071A30", VA = "0x187072630")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class ATXWRHUZADA : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x705FF90", Offset = "0x705F390", VA = "0x18705FF90")]
		public ATXWRHUZADA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x705FD80", Offset = "0x705F180", VA = "0x18705FD80", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x70726B0", Offset = "0x7071AB0", VA = "0x1870726B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7072650", Offset = "0x7071A50", VA = "0x187072650", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xF05860", Offset = "0xF04C60", VA = "0x180F05860")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class OPXKJAKKWXE : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7075180", Offset = "0x7074580", VA = "0x187075180")]
		public OPXKJAKKWXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x70750A0", Offset = "0x70744A0", VA = "0x1870750A0", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7072820", Offset = "0x7071C20", VA = "0x187072820", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x70727C0", Offset = "0x7071BC0", VA = "0x1870727C0", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xF05860", Offset = "0xF04C60", VA = "0x180F05860")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class JYNFHSCPFXQ : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x706D890", Offset = "0x706CC90", VA = "0x18706D890")]
		public JYNFHSCPFXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x706D7B0", Offset = "0x706CBB0", VA = "0x18706D7B0", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7072990", Offset = "0x7071D90", VA = "0x187072990", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7072930", Offset = "0x7071D30", VA = "0x187072930", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xF05860", Offset = "0xF04C60", VA = "0x180F05860")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class UIQNNFIEOFQ : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7079FB0", Offset = "0x70793B0", VA = "0x187079FB0")]
		public UIQNNFIEOFQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7079ED0", Offset = "0x70792D0", VA = "0x187079ED0", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public OEAGHAUWJNY source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public KHR_texture_basisu(OEAGHAUWJNY source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7072AA0", Offset = "0x7071EA0", VA = "0x187072AA0", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7072B10", Offset = "0x7071F10", VA = "0x187072B10", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class UHOAMACTQNU : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7079E80", Offset = "0x7079280", VA = "0x187079E80")]
		public UHOAMACTQNU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7079D20", Offset = "0x7079120", VA = "0x187079D20", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class OYZLRQXQNSN : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 TSALMPZNIUJ;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 YKZDNROHAEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double GYPOFJPFDYQ;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double BOPOTSNNHSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 UATJXLHWCDG;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 FWTOFNTVNPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? NZUUEVBHGCM;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int QYZDGLDNFHE;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7075900", Offset = "0x7074D00", VA = "0x187075900")]
		public OYZLRQXQNSN(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x70751D0", Offset = "0x70745D0", VA = "0x1870751D0", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x70752B0", Offset = "0x70746B0", VA = "0x1870752B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class DDAQNLUKRCF : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7061950", Offset = "0x7060D50", VA = "0x187061950")]
		public DDAQNLUKRCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7061680", Offset = "0x7060A80", VA = "0x187061680", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class QCSEZVJOTMF : CWFORSLEVMO
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> YMHCYPMDJSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public QCSEZVJOTMF(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x70783A0", Offset = "0x70777A0", VA = "0x1870783A0", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7078410", Offset = "0x7077810", VA = "0x187078410", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7078500", Offset = "0x7077900", VA = "0x187078500")]
		public List<double> VDXXKGYWQIH(CFDTQFFCTZU a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class IEOYGBLRZWZ : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x706ACD0", Offset = "0x706A0D0", VA = "0x18706ACD0")]
		public IEOYGBLRZWZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x706ABD0", Offset = "0x7069FD0", VA = "0x18706ABD0", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class DPGOAWAAUSB : TTMGPQQKCWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AUBFOGSNMLW SAALMDNJRJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint RJDOJBBIGWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType YQBQRYCDEXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool RRBFNGUEULF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint ULFDSOUXGUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType IRYCWFFEKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> MUOJXPMCUDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> KWUVILZMQUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public XBCTJLLFDTT VEWCLWFWHDA;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x70665E0", Offset = "0x70659E0", VA = "0x1870665E0")]
		public DPGOAWAAUSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7062570", Offset = "0x7061970", VA = "0x187062570")]
		public static DPGOAWAAUSB Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7061D10", Offset = "0x7061110", VA = "0x187061D10", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x70650A0", Offset = "0x70644A0", VA = "0x1870650A0")]
		private unsafe static sbyte RYJJDHRDXGI(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7063EE0", Offset = "0x70632E0", VA = "0x187063EE0")]
		private unsafe static float2 MXAGHLVELZI(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7063010", Offset = "0x7062410", VA = "0x187063010")]
		private unsafe static float3 HOAMKDCAYKH(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7065220", Offset = "0x7064620", VA = "0x187065220")]
		private unsafe static float4 TAKZHTEIKRC(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7064960", Offset = "0x7063D60", VA = "0x187064960")]
		private unsafe static float4x4 PVMBHRKHYEQ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x70650A0", Offset = "0x70644A0", VA = "0x1870650A0")]
		private unsafe static byte SHFJUGLQJCR(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7063F10", Offset = "0x7063310", VA = "0x187063F10")]
		private unsafe static float2 NEHNSULZLPX(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7063F40", Offset = "0x7063340", VA = "0x187063F40")]
		private unsafe static float3 NYMOLQVWBOE(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7063E50", Offset = "0x7063250", VA = "0x187063E50")]
		private unsafe static float4 LUQTVZOEMJB(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x70629D0", Offset = "0x7061DD0", VA = "0x1870629D0")]
		private unsafe static float4x4 EVKLYOKPUJF(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7062FD0", Offset = "0x70623D0", VA = "0x187062FD0")]
		private unsafe static short KRYYIQWCQSA(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7062FE0", Offset = "0x70623E0", VA = "0x187062FE0")]
		private unsafe static float2 HBOBRKIHQUC(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7061CC0", Offset = "0x70610C0", VA = "0x187061CC0")]
		private unsafe static float3 CDGYEHXBATJ(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x70631E0", Offset = "0x70625E0", VA = "0x1870631E0")]
		private unsafe static float4 JHVEVOCRUYY(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7062DE0", Offset = "0x70621E0", VA = "0x187062DE0")]
		private unsafe static float4x4 GHRDZTTHJXC(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7062FD0", Offset = "0x70623D0", VA = "0x187062FD0")]
		private unsafe static ushort HVYPAEJECYX(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7063EB0", Offset = "0x70632B0", VA = "0x187063EB0")]
		private unsafe static float2 MCFNMLGEGCT(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7061C60", Offset = "0x7061060", VA = "0x187061C60")]
		private unsafe static float3 AFKKQCDRYRA(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x70640A0", Offset = "0x70634A0", VA = "0x1870640A0")]
		private unsafe static float4x4 ODXLQVMLLLX(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x70636D0", Offset = "0x7062AD0", VA = "0x1870636D0")]
		private unsafe static float4 JSEKCCETQVT(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7061CB0", Offset = "0x70610B0", VA = "0x187061CB0")]
		private unsafe static uint BNMYFAQUUEW(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7062FD0", Offset = "0x70623D0", VA = "0x187062FD0")]
		private unsafe static ushort GVAELYEJZSL(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7063060", Offset = "0x7062460", VA = "0x187063060")]
		private unsafe static float IYKOSDDHGDS(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7064D70", Offset = "0x7064170", VA = "0x187064D70")]
		private unsafe static float2 QEGOJFZOFJY(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x70636B0", Offset = "0x7062AB0", VA = "0x1870636B0")]
		private unsafe static float3 JQBRNZHAJCL(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7064310", Offset = "0x7063710", VA = "0x187064310")]
		private unsafe static float4 OKJCSUODQOI(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7065640", Offset = "0x7064A40", VA = "0x187065640")]
		private unsafe static float4x4 WGSAAWRGZQE(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7064310", Offset = "0x7063710", VA = "0x187064310")]
		private unsafe static float4 VJPJOAZZSFN(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7065610", Offset = "0x7064A10", VA = "0x187065610")]
		private unsafe static float4 VJPJOAZZSFN(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7063730", Offset = "0x7062B30", VA = "0x187063730")]
		public static float3[] KEHGVFZEQTY(DPGOAWAAUSB a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7064D90", Offset = "0x7064190", VA = "0x187064D90")]
		public static float3[] RHYXZGPDSMO(DPGOAWAAUSB a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x70650B0", Offset = "0x70644B0", VA = "0x1870650B0")]
		public static uint[] SPTZBPIXEBB(DPGOAWAAUSB a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7063240", Offset = "0x7062640", VA = "0x187063240")]
		internal static void JNEFTBXZEAQ(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7065900", Offset = "0x7064D00", VA = "0x187065900")]
		public uint[] WQZSPBIGIDR(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7064B00", Offset = "0x7063F00", VA = "0x187064B00")]
		public float[] PZMYSJXKPWN(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7065670", Offset = "0x7064A70", VA = "0x187065670")]
		public float2[] WIEIUNWTLAT(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7063960", Offset = "0x7062D60", VA = "0x187063960")]
		public float2[] KIJAZEMTURX(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x70622F0", Offset = "0x70616F0", VA = "0x1870622F0")]
		public float3[] DECSPSMVYRI(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7063360", Offset = "0x7062760", VA = "0x187063360")]
		public float3[] JNUDBNHXTSC(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7062B70", Offset = "0x7061F70", VA = "0x187062B70")]
		public float4[] GHFTUKGUIVH(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7065CC0", Offset = "0x70650C0", VA = "0x187065CC0")]
		public float4[] YWDBYCCPHXP(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7065280", Offset = "0x7064680", VA = "0x187065280")]
		public float4[] TXBPQYWITJY(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7063D40", Offset = "0x7063140", VA = "0x187063D40")]
		public float3[] LSKHDAXXJCF(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7063F90", Offset = "0x7063390", VA = "0x187063F90")]
		public float3[] OBIUVCBQIOW(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7064240", Offset = "0x7063640", VA = "0x187064240")]
		public float4[] OFXXKEGXLYM(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7062F80", Offset = "0x7062380", VA = "0x187062F80")]
		public uint[] GKBVBWVGCVJ(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7066030", Offset = "0x7065430", VA = "0x187066030")]
		public float4x4[] ZYBHSLOMRGG(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x70644C0", Offset = "0x70638C0", VA = "0x1870644C0")]
		private unsafe static float4 OYTNXRTRZPK(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7064340", Offset = "0x7063740", VA = "0x187064340")]
		private unsafe static float4 OYTNXRTRZPK(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7065B50", Offset = "0x7064F50", VA = "0x187065B50")]
		private unsafe static float4x4 XIJDTCACLUZ(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x70647A0", Offset = "0x7063BA0", VA = "0x1870647A0")]
		private unsafe static float4 PGYUBTRMYIZ(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7063070", Offset = "0x7062470", VA = "0x187063070")]
		private unsafe static float3 JEIWHBECNEK(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7063C10", Offset = "0x7063010", VA = "0x187063C10")]
		private unsafe static float2 LKZMNCTFBFV(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7064680", Offset = "0x7063A80", VA = "0x187064680")]
		private unsafe static uint PELVULWNRMS(void* a, uint b, GLTFComponentType c)
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
	public static class VTRCFUEMCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x708E620", Offset = "0x708DA20", VA = "0x18708E620")]
		public static int CIOHSVJFODO(this GLTFAccessorAttributeType a)
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
	public class XBCTJLLFDTT : RNTVAREHKRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int ULFDSOUXGUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public SAHCLGGECWO SNTSIHYPTRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public CHTCONSLNBV KYESJTZRVXC;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x708F460", Offset = "0x708E860", VA = "0x18708F460")]
		public XBCTJLLFDTT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x708F190", Offset = "0x708E590", VA = "0x18708F190")]
		public static XBCTJLLFDTT Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x708F060", Offset = "0x708E460", VA = "0x18708F060", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class SAHCLGGECWO : RNTVAREHKRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AUBFOGSNMLW SAALMDNJRJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int RJDOJBBIGWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType YQBQRYCDEXH;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x708AF40", Offset = "0x708A340", VA = "0x18708AF40")]
		public SAHCLGGECWO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x708AC60", Offset = "0x708A060", VA = "0x18708AC60")]
		public static SAHCLGGECWO Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x708AB20", Offset = "0x7089F20", VA = "0x18708AB20", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class CHTCONSLNBV : RNTVAREHKRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AUBFOGSNMLW SAALMDNJRJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int RJDOJBBIGWL;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x707D5D0", Offset = "0x707C9D0", VA = "0x18707D5D0")]
		public CHTCONSLNBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x707D350", Offset = "0x707C750", VA = "0x18707D350")]
		public static CHTCONSLNBV Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x707D250", Offset = "0x707C650", VA = "0x18707D250", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class JUFJRVKRBML : RNTVAREHKRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public ZNNPNSAFTHX EYIIVULAZAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public RXJYREPLVAW XAKJVVUODWX;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7086280", Offset = "0x7085680", VA = "0x187086280")]
		public JUFJRVKRBML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7086090", Offset = "0x7085490", VA = "0x187086090")]
		public static JUFJRVKRBML Deserialize(FZUMGSVMSUT root, JsonReader reader, PTLIBJBFTSP anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7085F90", Offset = "0x7085390", VA = "0x187085F90", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class RXJYREPLVAW : RNTVAREHKRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public GDEBWNCDUBF CFDTQFFCTZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string XIQPRXQENAB;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x708A3B0", Offset = "0x70897B0", VA = "0x18708A3B0")]
		public static RXJYREPLVAW Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x708A610", Offset = "0x7089A10", VA = "0x18708A610")]
		public RXJYREPLVAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x708A290", Offset = "0x7089690", VA = "0x18708A290", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
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
	public class OSDKPJWNUNL
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(OSDKPJWNUNL data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] OQGFHLBFDSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type IKEJIRGMQDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] ZAHZRPETQED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion KCSLHVSIHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string XEWZZCEQGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string GWLJLHQPOMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public WCFAQEMIIMZ USHOAWAMGZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string LPJJDJOHWVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string UUTMANCSWTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public WCFAQEMIIMZ SRPIVUXRRLO;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7087AD0", Offset = "0x7086ED0", VA = "0x187087AD0")]
		public OSDKPJWNUNL()
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
	public class KANTXWFPHCU : RNTVAREHKRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public ZIHJPSCCEDS KRZBOKTBHHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType SSLNURCQVRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public ZIHJPSCCEDS PEMGZHTKGOT;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7086660", Offset = "0x7085A60", VA = "0x187086660")]
		public KANTXWFPHCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7086440", Offset = "0x7085840", VA = "0x187086440")]
		public static KANTXWFPHCU Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x70862D0", Offset = "0x70856D0", VA = "0x1870862D0", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class SHBLUUHPVLA : RNTVAREHKRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string GBOIZQIENQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string YIQMUWTPYOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string ZRFAADGABRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string FEQGHSTLNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> VBKGZEULVKC;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x708BA80", Offset = "0x708AE80", VA = "0x18708BA80")]
		public SHBLUUHPVLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x708B3B0", Offset = "0x708A7B0", VA = "0x18708B3B0")]
		public static SHBLUUHPVLA Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x708AF90", Offset = "0x708A390", VA = "0x18708AF90", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x708B6D0", Offset = "0x708AAD0", VA = "0x18708B6D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x708B6E0", Offset = "0x708AAE0", VA = "0x18708B6E0")]
		public string XHULETXXDPM(bool a)
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
	public class SAALMDNJRJD : TTMGPQQKCWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public HGPMTRNOTAJ HBRAIILFZZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint RJDOJBBIGWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint DBOOFBQACQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint OEQSXVUSIIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget XAKJVVUODWX;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x707EAB0", Offset = "0x707DEB0", VA = "0x18707EAB0")]
		public SAALMDNJRJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x708A870", Offset = "0x7089C70", VA = "0x18708A870")]
		public static SAALMDNJRJD Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x708A660", Offset = "0x7089A60", VA = "0x18708A660", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class LNNHHGAFYKX : RNTVAREHKRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double TCWKWHEIJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double XRLFLXZDYVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double SLXBTYDPTKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double BSJAJRMCIMG;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7086BB0", Offset = "0x7085FB0", VA = "0x187086BB0")]
		public LNNHHGAFYKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7086830", Offset = "0x7085C30", VA = "0x187086830")]
		public static LNNHHGAFYKX Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x70866C0", Offset = "0x7085AC0", VA = "0x1870866C0", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class MWDIGMEWWND : RNTVAREHKRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double IMARYNEVNGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double MMUIBWZOUAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double SLXBTYDPTKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double BSJAJRMCIMG;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7087350", Offset = "0x7086750", VA = "0x187087350")]
		public MWDIGMEWWND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7086FE0", Offset = "0x70863E0", VA = "0x187086FE0")]
		public static MWDIGMEWWND Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7086E50", Offset = "0x7086250", VA = "0x187086E50", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class PTLIBJBFTSP : TTMGPQQKCWP
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class OFEBALTHFAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public FZUMGSVMSUT XUVHPHBAVDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader IZDTMXKHPZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public PTLIBJBFTSP PGAOFZJXWFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<JUFJRVKRBML> GRJPJADMRTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<KANTXWFPHCU> GREILTJPIII;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OFEBALTHFAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x7087AB0", Offset = "0x7086EB0", VA = "0x187087AB0")]
			internal JUFJRVKRBML NJQFYZWQOAN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x7087AA0", Offset = "0x7086EA0", VA = "0x187087AA0")]
			internal KANTXWFPHCU NJKZBTCTEPE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<JUFJRVKRBML> KCKWUMOZVAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<KANTXWFPHCU> HCGECLGAZPB;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7087F10", Offset = "0x7087310", VA = "0x187087F10")]
		public static PTLIBJBFTSP Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x70882D0", Offset = "0x70876D0", VA = "0x1870882D0")]
		public PTLIBJBFTSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7087B70", Offset = "0x7086F70", VA = "0x187087B70", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class SHEUFKKLCGJ : TTMGPQQKCWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string GKFFZLXCKVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint DBOOFBQACQQ;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x707EAB0", Offset = "0x707DEB0", VA = "0x18707EAB0")]
		public SHEUFKKLCGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x708BC70", Offset = "0x708B070", VA = "0x18708BC70")]
		public static SHEUFKKLCGJ Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x708BB20", Offset = "0x708AF20", VA = "0x18708BB20", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class DZDMIBRZFJK : TTMGPQQKCWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public LNNHHGAFYKX GHQPGSBDCUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public MWDIGMEWWND EJROGTHTXTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType IRYCWFFEKLI;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x707EAB0", Offset = "0x707DEB0", VA = "0x18707EAB0")]
		public DZDMIBRZFJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x707EF10", Offset = "0x707E310", VA = "0x18707EF10")]
		public static DZDMIBRZFJK Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x707ED40", Offset = "0x707E140", VA = "0x18707ED40", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
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
	public class TTMGPQQKCWP : RNTVAREHKRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string NSNROSXPJBX;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x707EAB0", Offset = "0x707DEB0", VA = "0x18707EAB0")]
		public TTMGPQQKCWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x708C8C0", Offset = "0x708BCC0", VA = "0x18708C8C0")]
		public TTMGPQQKCWP(TTMGPQQKCWP a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x708C7D0", Offset = "0x708BBD0", VA = "0x18708C7D0")]
		public new void PPPKVSZNVPP(FZUMGSVMSUT a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x708C740", Offset = "0x708BB40", VA = "0x18708C740", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class KRZMTUYAXDL<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int OQGVUCEGDTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public FZUMGSVMSUT JNBRJWHHBWC;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected KRZMTUYAXDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5250F80", Offset = "0x5250380", VA = "0x185250F80")]
		public KRZMTUYAXDL(KRZMTUYAXDL<a> a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5250F50", Offset = "0x5250350", VA = "0x185250F50")]
		public void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class ZIHJPSCCEDS : KRZMTUYAXDL<DPGOAWAAUSB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override DPGOAWAAUSB Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x7090B20", Offset = "0x708FF20", VA = "0x187090B20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7090A80", Offset = "0x708FE80", VA = "0x187090A80")]
		public ZIHJPSCCEDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7090AC0", Offset = "0x708FEC0", VA = "0x187090AC0")]
		public ZIHJPSCCEDS(ZIHJPSCCEDS a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x70909A0", Offset = "0x708FDA0", VA = "0x1870909A0")]
		public static ZIHJPSCCEDS Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class HGPMTRNOTAJ : KRZMTUYAXDL<SHEUFKKLCGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override SHEUFKKLCGJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x7082840", Offset = "0x7081C40", VA = "0x187082840", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7082800", Offset = "0x7081C00", VA = "0x187082800")]
		public HGPMTRNOTAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7082720", Offset = "0x7081B20", VA = "0x187082720")]
		public static HGPMTRNOTAJ Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class AUBFOGSNMLW : KRZMTUYAXDL<SAALMDNJRJD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override SAALMDNJRJD Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x707B1F0", Offset = "0x707A5F0", VA = "0x18707B1F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x707B1B0", Offset = "0x707A5B0", VA = "0x18707B1B0")]
		public AUBFOGSNMLW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x707B0D0", Offset = "0x707A4D0", VA = "0x18707B0D0")]
		public static AUBFOGSNMLW Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class IWYNEKCFAPK : KRZMTUYAXDL<DZDMIBRZFJK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override DZDMIBRZFJK Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x7083C10", Offset = "0x7083010", VA = "0x187083C10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7083BD0", Offset = "0x7082FD0", VA = "0x187083BD0")]
		public IWYNEKCFAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7083AF0", Offset = "0x7082EF0", VA = "0x187083AF0")]
		public static IWYNEKCFAPK Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class OEAGHAUWJNY : KRZMTUYAXDL<HWSSUNICCRC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override HWSSUNICCRC Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x7087A40", Offset = "0x7086E40", VA = "0x187087A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7087A00", Offset = "0x7086E00", VA = "0x187087A00")]
		public OEAGHAUWJNY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7087920", Offset = "0x7086D20", VA = "0x187087920")]
		public static OEAGHAUWJNY Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class AOGCDBYZIFE : KRZMTUYAXDL<WKXGTXFNJNI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override WKXGTXFNJNI Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x707B070", Offset = "0x707A470", VA = "0x18707B070", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x707B030", Offset = "0x707A430", VA = "0x18707B030")]
		public AOGCDBYZIFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x707AFD0", Offset = "0x707A3D0", VA = "0x18707AFD0")]
		public AOGCDBYZIFE(AOGCDBYZIFE a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x707AEF0", Offset = "0x707A2F0", VA = "0x18707AEF0")]
		public static AOGCDBYZIFE Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class HXARMPGUANY : KRZMTUYAXDL<DERQUSIAPDY>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override DERQUSIAPDY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x7083440", Offset = "0x7082840", VA = "0x187083440", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7083400", Offset = "0x7082800", VA = "0x187083400")]
		public HXARMPGUANY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7083320", Offset = "0x7082720", VA = "0x187083320")]
		public static HXARMPGUANY Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class GDEBWNCDUBF : KRZMTUYAXDL<CFDTQFFCTZU>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override CFDTQFFCTZU Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x7081F50", Offset = "0x7081350", VA = "0x187081F50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7081F10", Offset = "0x7081310", VA = "0x187081F10")]
		public GDEBWNCDUBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7081BC0", Offset = "0x7080FC0", VA = "0x187081BC0")]
		public static GDEBWNCDUBF Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7081CA0", Offset = "0x70810A0", VA = "0x187081CA0")]
		public static List<GDEBWNCDUBF> FGWJYPBWSHE(FZUMGSVMSUT a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class TVGWPUDKMGL : KRZMTUYAXDL<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x708CA60", Offset = "0x708BE60", VA = "0x18708CA60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x708CA20", Offset = "0x708BE20", VA = "0x18708CA20")]
		public TVGWPUDKMGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x708C940", Offset = "0x708BD40", VA = "0x18708C940")]
		public static TVGWPUDKMGL Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ZNNPNSAFTHX : KRZMTUYAXDL<KANTXWFPHCU>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public PTLIBJBFTSP PTLIBJBFTSP;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override KANTXWFPHCU Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x7090CC0", Offset = "0x70900C0", VA = "0x187090CC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7090C80", Offset = "0x7090080", VA = "0x187090C80")]
		public ZNNPNSAFTHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7090B80", Offset = "0x708FF80", VA = "0x187090B80")]
		public static ZNNPNSAFTHX Deserialize(FZUMGSVMSUT root, PTLIBJBFTSP anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class RNZJRTZBRDZ : KRZMTUYAXDL<VNYFQYNHQCR>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override VNYFQYNHQCR Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x708A230", Offset = "0x7089630", VA = "0x18708A230", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x708A1F0", Offset = "0x70895F0", VA = "0x18708A1F0")]
		public RNZJRTZBRDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x708A110", Offset = "0x7089510", VA = "0x18708A110")]
		public static RNZJRTZBRDZ Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class TEQZLCFAZUK : KRZMTUYAXDL<CRODCQRPSXF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override CRODCQRPSXF Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x708C670", Offset = "0x708BA70", VA = "0x18708C670", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x708C630", Offset = "0x708BA30", VA = "0x18708C630")]
		public TEQZLCFAZUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x708C550", Offset = "0x708B950", VA = "0x18708C550")]
		public static TEQZLCFAZUK Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class SNZWXCMIXSE : KRZMTUYAXDL<XRKEDLFRQLY>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override XRKEDLFRQLY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x708BFC0", Offset = "0x708B3C0", VA = "0x18708BFC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x708BF80", Offset = "0x708B380", VA = "0x18708BF80")]
		public SNZWXCMIXSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x708BF20", Offset = "0x708B320", VA = "0x18708BF20")]
		public SNZWXCMIXSE(SNZWXCMIXSE a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x708BE40", Offset = "0x708B240", VA = "0x18708BE40")]
		public static SNZWXCMIXSE Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class BXYDSMGQXTF : KRZMTUYAXDL<HEMXCPXEDZD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override HEMXCPXEDZD Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x707B2A0", Offset = "0x707A6A0", VA = "0x18707B2A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x707B260", Offset = "0x707A660", VA = "0x18707B260")]
		public BXYDSMGQXTF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class HWSSUNICCRC : TTMGPQQKCWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string GKFFZLXCKVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string JJNLKPXDNLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public AUBFOGSNMLW SAALMDNJRJD;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x707EAB0", Offset = "0x707DEB0", VA = "0x18707EAB0")]
		public HWSSUNICCRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x70830E0", Offset = "0x70824E0", VA = "0x1870830E0")]
		public static HWSSUNICCRC Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7082F10", Offset = "0x7082310", VA = "0x187082F10", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class WKXGTXFNJNI : TTMGPQQKCWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public HOITQIKWFGL HOITQIKWFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public NXOKLBUFARA AXVZUWLIDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public HXDZCZNDUHS XVSSISCCBCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public IXMOGGFTQGG BHPWZUVBJCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public GQTAFWBMEER TPBHOOPPTAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color FVXPWTMNCKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode OIFUOCHYQZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double NCRNFAAGSQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool TQOVUOYGESA;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x708EFF0", Offset = "0x708E3F0", VA = "0x18708EFF0")]
		public WKXGTXFNJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x708EAE0", Offset = "0x708DEE0", VA = "0x18708EAE0")]
		public static WKXGTXFNJNI Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x708E680", Offset = "0x708DA80", VA = "0x18708E680", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
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
	public class DERQUSIAPDY : TTMGPQQKCWP
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class AZSYQXSOVDR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public FZUMGSVMSUT XUVHPHBAVDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader IZDTMXKHPZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<JRRIGPAJAOY> GRJPJADMRTR;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public AZSYQXSOVDR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x707B250", Offset = "0x707A650", VA = "0x18707B250")]
			internal JRRIGPAJAOY NJQFYZWQOAN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<JRRIGPAJAOY> SCAGWIAUUXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> YXYJCETWYFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> JKMGYYFEOCR;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x707EAB0", Offset = "0x707DEB0", VA = "0x18707EAB0")]
		public DERQUSIAPDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x707E6F0", Offset = "0x707DAF0", VA = "0x18707E6F0")]
		public static DERQUSIAPDY Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x707E140", Offset = "0x707D540", VA = "0x18707E140", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class RNTVAREHKRE
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, PGIJNLLFEXF> EBYUUDBTGBJ;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static TOWNSICSLLI ZUMHSFXATIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, CWFORSLEVMO> KTWOUHNRYDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken TGIATZSBBAZ;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7089470", Offset = "0x7088870", VA = "0x187089470")]
		public static PGIJNLLFEXF ZAPBRNUQQOS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x70892C0", Offset = "0x70886C0", VA = "0x1870892C0")]
		public static CWFORSLEVMO XQRMHDOZGII(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RNTVAREHKRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7089E20", Offset = "0x7089220", VA = "0x187089E20")]
		public RNTVAREHKRE(RNTVAREHKRE a, [Optional] FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x70888F0", Offset = "0x7087CF0", VA = "0x1870888F0")]
		public void PPPKVSZNVPP(FZUMGSVMSUT a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7088BA0", Offset = "0x7087FA0", VA = "0x187088BA0")]
		public void TAIIZYYJNJM(string a, CWFORSLEVMO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7088740", Offset = "0x7087B40", VA = "0x187088740")]
		private void EBIXWCMASZI(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7088830", Offset = "0x7087C30", VA = "0x187088830")]
		private void LXPWZFDAXSK(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x70893B0", Offset = "0x70887B0", VA = "0x1870893B0")]
		private void YQFAFELPKMO(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7088CF0", Offset = "0x70880F0", VA = "0x187088CF0")]
		internal static Dictionary<string, CWFORSLEVMO> XGBZQXMCWUT(FZUMGSVMSUT a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x70883C0", Offset = "0x70877C0", VA = "0x1870883C0", Slot = "4")]
		public virtual void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class FZUMGSVMSUT : RNTVAREHKRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class DJEEUXRFMMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public FZUMGSVMSUT XUVHPHBAVDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader LPAODKEQBPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<DPGOAWAAUSB> GRJPJADMRTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<PTLIBJBFTSP> GREILTJPIII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<SHEUFKKLCGJ> GRUDDNRHKQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<SAALMDNJRJD> GROWGGXKBFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<DZDMIBRZFJK> GSEQYBFCDNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<HWSSUNICCRC> GRZKAULEUBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<WKXGTXFNJNI> GSPESOSWWJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<DERQUSIAPDY> GSJXVHYZMYK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<CFDTQFFCTZU> GSZSNCGRPGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> GSULPVMUFVC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<VNYFQYNHQCR> HMOZBFKUQQQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<CRODCQRPSXF> HMUFYMESABZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<XRKEDLFRQLY> HMZMVSYPJNI;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public DJEEUXRFMMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x707EB70", Offset = "0x707DF70", VA = "0x18707EB70")]
			internal DPGOAWAAUSB NJQFYZWQOAN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x707EB60", Offset = "0x707DF60", VA = "0x18707EB60")]
			internal PTLIBJBFTSP NJKZBTCTEPE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x707EB50", Offset = "0x707DF50", VA = "0x18707EB50")]
			internal SHEUFKKLCGJ NJFSEMIVVDV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x707EB40", Offset = "0x707DF40", VA = "0x18707EB40")]
			internal SAALMDNJRJD NJALHFOYLSM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x707EB30", Offset = "0x707DF30", VA = "0x18707EB30")]
			internal DZDMIBRZFJK NIVEJYVBCHD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x707EB20", Offset = "0x707DF20", VA = "0x18707EB20")]
			internal HWSSUNICCRC NIPXMSBDSVU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x707EB10", Offset = "0x707DF10", VA = "0x18707EB10")]
			internal WKXGTXFNJNI NIKQPLHGJKL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x707EB00", Offset = "0x707DF00", VA = "0x18707EB00")]
			internal DERQUSIAPDY NIFJSENIZZC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x707EB90", Offset = "0x707DF90", VA = "0x18707EB90")]
			internal CFDTQFFCTZU NLGJDBZVLNH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x707EB80", Offset = "0x707DF80", VA = "0x18707EB80")]
			internal Sampler NLBCFVFYCBY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x707EBB0", Offset = "0x707DFB0", VA = "0x18707EBB0")]
			internal VNYFQYNHQCR SCWGOUUMSIO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x707ED30", Offset = "0x707E130", VA = "0x18707ED30")]
			internal CRODCQRPSXF SDBNMBOKBTX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x707EBA0", Offset = "0x707DFA0", VA = "0x18707EBA0")]
			internal XRKEDLFRQLY SCLSUHGRZLW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> TLBBHYBTGMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> QRYAKVDKURL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<DPGOAWAAUSB> LUJCBXELUES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<PTLIBJBFTSP> KXXITNPWXWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public SHBLUUHPVLA SHBLUUHPVLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<SHEUFKKLCGJ> ANZOAHQEFMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<SAALMDNJRJD> FMBBWIEFXNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<DZDMIBRZFJK> QHOOYGONGFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<HWSSUNICCRC> BGBUCKXZEII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<WKXGTXFNJNI> PNHCXWYSGVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<DERQUSIAPDY> WVFNRDNLXPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<CFDTQFFCTZU> KOHLFBFSLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> HCGECLGAZPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public RNZJRTZBRDZ DHMJPDMDRJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<VNYFQYNHQCR> RQTTCUCVWSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<CRODCQRPSXF> FBHTWNVOJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<XRKEDLFRQLY> CNQSIEHFBCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<HEMXCPXEDZD> HMFQJBKPFZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool XFDAHEVXMRP;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7081B70", Offset = "0x7080F70", VA = "0x187081B70")]
		public FZUMGSVMSUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7081AD0", Offset = "0x7080ED0", VA = "0x187081AD0")]
		public VNYFQYNHQCR IFFGAZDNHOV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7080C80", Offset = "0x7080080", VA = "0x187080C80")]
		public static FZUMGSVMSUT Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x707F0E0", Offset = "0x707E4E0", VA = "0x18707F0E0")]
		public void CQVTSUWTJSM(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class VNYFQYNHQCR : TTMGPQQKCWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<GDEBWNCDUBF> KOHLFBFSLAP;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x707EAB0", Offset = "0x707DEB0", VA = "0x18707EAB0")]
		public VNYFQYNHQCR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x708DF80", Offset = "0x708D380", VA = "0x18708DF80")]
		public static VNYFQYNHQCR Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x708DD10", Offset = "0x708D110", VA = "0x18708DD10", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class XRKEDLFRQLY : TTMGPQQKCWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TVGWPUDKMGL EYIIVULAZAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public OEAGHAUWJNY TGXHUUSBHOD;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x707EAB0", Offset = "0x707DEB0", VA = "0x18707EAB0")]
		public XRKEDLFRQLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x708F8E0", Offset = "0x708ECE0", VA = "0x18708F8E0")]
		public static XRKEDLFRQLY Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x708F770", Offset = "0x708EB70", VA = "0x18708F770", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class OBSWFMGFQLJ : HEMXCPXEDZD
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x707EAB0", Offset = "0x707DEB0", VA = "0x18707EAB0")]
		public OBSWFMGFQLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x70866B0", Offset = "0x7085AB0", VA = "0x1870866B0", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class HEMXCPXEDZD : TTMGPQQKCWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string BDCRSMOEMSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color LDJRRIMYXWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string UCRFZIXSQJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float LTPUUXKHBRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float MXHMNXAGDLR;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x707EAB0", Offset = "0x707DEB0", VA = "0x18707EAB0")]
		public HEMXCPXEDZD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x70824A0", Offset = "0x70818A0", VA = "0x1870824A0", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class LKBLQOKSOHD : HEMXCPXEDZD
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x707EAB0", Offset = "0x707DEB0", VA = "0x18707EAB0")]
		public LKBLQOKSOHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x70866B0", Offset = "0x7085AB0", VA = "0x1870866B0", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class CZVCWPJDWJH : HEMXCPXEDZD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float ASHKZIJLLCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float LLUYXJHIXZD;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x707E0F0", Offset = "0x707D4F0", VA = "0x18707E0F0")]
		public CZVCWPJDWJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x707DDF0", Offset = "0x707D1F0", VA = "0x18707DDF0", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface YMXMLUAPMMY
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VMDXXVORXAT(FZUMGSVMSUT a, VHNTIPKVFGY b, [Out] OSDKPJWNUNL c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface CWFORSLEVMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CWFORSLEVMO Clone(FZUMGSVMSUT root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class PGIJNLLFEXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string UHGEOMJGOJC;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected PGIJNLLFEXF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class CRSDLSVBQSY : CWFORSLEVMO
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty MFIILBIPSDB
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x707DD40", Offset = "0x707D140", VA = "0x18707DD40", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CRSDLSVBQSY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class TOWNSICSLLI : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x708C6D0", Offset = "0x708BAD0", VA = "0x18708C6D0", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public TOWNSICSLLI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class NXOKLBUFARA : RNTVAREHKRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color FDRGXYYZPQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public GQTAFWBMEER SYKLLPHKMFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color HVQGXZTKKCL;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x70878B0", Offset = "0x7086CB0", VA = "0x1870878B0")]
		public NXOKLBUFARA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7087610", Offset = "0x7086A10", VA = "0x187087610")]
		public static NXOKLBUFARA Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x70873B0", Offset = "0x70867B0", VA = "0x1870873B0", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class HXDZCZNDUHS : GQTAFWBMEER
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string GSXZZTTSXMI = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double UATJXLHWCDG;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7083850", Offset = "0x7082C50", VA = "0x187083850")]
		public HXDZCZNDUHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7083560", Offset = "0x7082960", VA = "0x187083560")]
		public new static HXDZCZNDUHS Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x70834A0", Offset = "0x70828A0", VA = "0x1870834A0", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class IXMOGGFTQGG : GQTAFWBMEER
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string CJSBBUDOSGD = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double EUOEWBLDKHB;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7083850", Offset = "0x7082C50", VA = "0x187083850")]
		public IXMOGGFTQGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7083D30", Offset = "0x7083130", VA = "0x187083D30")]
		public new static IXMOGGFTQGG Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7083C70", Offset = "0x7083070", VA = "0x187083C70", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class HOITQIKWFGL : RNTVAREHKRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color YMHAAWWQZRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public GQTAFWBMEER UCGPGETGTVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double MXKILPKNNGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double CGEKVQSHBXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public GQTAFWBMEER NKWTCQIAYHE;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7082EA0", Offset = "0x70822A0", VA = "0x187082EA0")]
		public HOITQIKWFGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7082B30", Offset = "0x7081F30", VA = "0x187082B30")]
		public static HOITQIKWFGL Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x70828A0", Offset = "0x7081CA0", VA = "0x1870828A0", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class JRRIGPAJAOY : RNTVAREHKRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class MTCDKCMSKAV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader IZDTMXKHPZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public FZUMGSVMSUT XUVHPHBAVDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<ZIHJPSCCEDS> GRJPJADMRTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<ZIHJPSCCEDS> GRUDDNRHKQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, ZIHJPSCCEDS>> GREILTJPIII;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public MTCDKCMSKAV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x7086D80", Offset = "0x7086180", VA = "0x187086D80")]
			internal ZIHJPSCCEDS NJQFYZWQOAN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x7086CD0", Offset = "0x70860D0", VA = "0x187086CD0")]
			internal Dictionary<string, ZIHJPSCCEDS> NJKZBTCTEPE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x7086C00", Offset = "0x7086000", VA = "0x187086C00")]
			internal ZIHJPSCCEDS NJFSEMIVVDV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, ZIHJPSCCEDS> TLFJOOEAPRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public ZIHJPSCCEDS SNTSIHYPTRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public AOGCDBYZIFE UIIQDVLKWCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode BALPIKTSLUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, ZIHJPSCCEDS>> WSWWGRSUBLS;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7085EF0", Offset = "0x70852F0", VA = "0x187085EF0")]
		public JRRIGPAJAOY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7085850", Offset = "0x7084C50", VA = "0x187085850")]
		public JRRIGPAJAOY(JRRIGPAJAOY a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7085370", Offset = "0x7084770", VA = "0x187085370")]
		public static int[] GTMLDPJSFZQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x70854A0", Offset = "0x70848A0", VA = "0x1870854A0")]
		public static int[] JZNPLKDWWDM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7085600", Offset = "0x7084A00", VA = "0x187085600")]
		public static int[] NKAPMRICEEM(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7084610", Offset = "0x7083A10", VA = "0x187084610")]
		public static int[] BSFNYVZIFZS(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7084560", Offset = "0x7083960", VA = "0x187084560")]
		public static int[] BISTZUVXMAP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7085300", Offset = "0x7084700", VA = "0x187085300")]
		public static int[] GHNKGBQJHYW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7085410", Offset = "0x7084810", VA = "0x187085410")]
		public static int[] HWBLBIUWVOI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7084E40", Offset = "0x7084240", VA = "0x187084E40")]
		public static int[] DHJDEMKANWD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x70857C0", Offset = "0x7084BC0", VA = "0x1870857C0")]
		public static int[] RBAXIFKPTFT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7084EB0", Offset = "0x70842B0", VA = "0x187084EB0")]
		public static JRRIGPAJAOY Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7084850", Offset = "0x7083C50", VA = "0x187084850", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class XDDQYRDFJFN
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] NZUUEVBHGCM;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] BBHCWBJOSMB;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] GZWDJAEEYWK;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] FYOGPJBHVCK;
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
	public class CFDTQFFCTZU : TTMGPQQKCWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool CAEGAWPSZZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public IWYNEKCFAPK SNAOOIOJQKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<GDEBWNCDUBF> BBQMLARKSHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public TEQZLCFAZUK CRODCQRPSXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public LUXQQMJINMF NTFIYSVIEZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public HXARMPGUANY RIIAUWVRPRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion GYPOFJPFDYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 UATJXLHWCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 NBUHMHFTNGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> YXYJCETWYFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public BXYDSMGQXTF UGYQBBVNCGG;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x707D120", Offset = "0x707C520", VA = "0x18707D120")]
		public CFDTQFFCTZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x707C7F0", Offset = "0x707BBF0", VA = "0x18707C7F0")]
		public static CFDTQFFCTZU Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x707BC00", Offset = "0x707B000", VA = "0x18707BC00", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : TTMGPQQKCWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode IDVFFLBGJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode CDJSUOVESQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode QNTALLKDPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode QOTIXTFQKRY;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x708C4E0", Offset = "0x708B8E0", VA = "0x18708C4E0")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x708C210", Offset = "0x708B610", VA = "0x18708C210")]
		public static Sampler Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x708C020", Offset = "0x708B420", VA = "0x18708C020", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
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
	public class CRODCQRPSXF : TTMGPQQKCWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public ZIHJPSCCEDS VLRUYNWQYBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public GDEBWNCDUBF DPOTCTDZWAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<GDEBWNCDUBF> NDHJVNGCKPN;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x707DC90", Offset = "0x707D090", VA = "0x18707DC90")]
		public CRODCQRPSXF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x707D930", Offset = "0x707CD30", VA = "0x18707D930")]
		public static CRODCQRPSXF Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x707D620", Offset = "0x707CA20", VA = "0x18707D620", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class GQTAFWBMEER : RNTVAREHKRE
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string SGZUQQZWNMW = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string QKKYDRHMQOE = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public SNZWXCMIXSE NKHCRNAJCUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int NZUUEVBHGCM;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7082360", Offset = "0x7081760", VA = "0x187082360")]
		public GQTAFWBMEER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x70823B0", Offset = "0x70817B0", VA = "0x1870823B0")]
		public GQTAFWBMEER(GQTAFWBMEER a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7082010", Offset = "0x7081410", VA = "0x187082010")]
		public static GQTAFWBMEER Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7081FB0", Offset = "0x70813B0", VA = "0x187081FB0", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7082290", Offset = "0x7081690", VA = "0x187082290")]
		public void HQCXIHJVHMV(JsonWriter a)
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
	public class VQEADVNYURE
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double IZRQAQKBMOQ;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double SFYWQPOGIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double LRIUOQUMPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double VIUTDUNRHFD;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x708E5A0", Offset = "0x708D9A0", VA = "0x18708E5A0")]
		public VQEADVNYURE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x708E310", Offset = "0x708D710", VA = "0x18708E310")]
		public static VQEADVNYURE Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x708E100", Offset = "0x708D500", VA = "0x18708E100")]
		public void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class UZWRGJIJSHC : TTMGPQQKCWP
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color VJBHMLUKNNR;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double ORSCECTJEHT;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double KDVOYCTCYFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType IRYCWFFEKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color BBHCWBJOSMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double CMDTHHIJDYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double CVEXSPWVYBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public VQEADVNYURE VQEADVNYURE;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x708DB30", Offset = "0x708CF30", VA = "0x18708DB30")]
		public UZWRGJIJSHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x708DBF0", Offset = "0x708CFF0", VA = "0x18708DBF0")]
		public UZWRGJIJSHC(UZWRGJIJSHC a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x708D5A0", Offset = "0x708C9A0", VA = "0x18708D5A0")]
		public static UZWRGJIJSHC Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x708D990", Offset = "0x708CD90", VA = "0x18708D990")]
		public static UZWRGJIJSHC Deserialize(FZUMGSVMSUT root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x708D240", Offset = "0x708C640", VA = "0x18708D240", Slot = "4")]
		public override void CQVTSUWTJSM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class CBIVIRPYNDM : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<HEMXCPXEDZD> ZUHRWWOIYAD;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public CBIVIRPYNDM(IList<HEMXCPXEDZD> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x707B370", Offset = "0x707A770", VA = "0x18707B370", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x707B300", Offset = "0x707A700", VA = "0x18707B300", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class YWANYYTWEBM : CWFORSLEVMO, YMXMLUAPMMY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<UZWRGJIJSHC> HMFQJBKPFZN;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7090920", Offset = "0x708FD20", VA = "0x187090920")]
		public YWANYYTWEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x708FD60", Offset = "0x708F160", VA = "0x18708FD60", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7090440", Offset = "0x708F840", VA = "0x187090440", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x708FAB0", Offset = "0x708EEB0", VA = "0x18708FAB0")]
		private static string[] BKACDSSDIDO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x708FFE0", Offset = "0x708F3E0", VA = "0x18708FFE0")]
		private static OSDKPJWNUNL.ImportValuesConversion LCCRIGTLXAG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7090530", Offset = "0x708F930", VA = "0x187090530", Slot = "6")]
		public bool VMDXXVORXAT(FZUMGSVMSUT a, VHNTIPKVFGY b, [Out] OSDKPJWNUNL c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class UMXUYEGRVIJ : KRZMTUYAXDL<UZWRGJIJSHC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override UZWRGJIJSHC Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x708D0F0", Offset = "0x708C4F0", VA = "0x18708D0F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x708D0B0", Offset = "0x708C4B0", VA = "0x18708D0B0")]
		public UMXUYEGRVIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x708CFD0", Offset = "0x708C3D0", VA = "0x18708CFD0")]
		public static UMXUYEGRVIJ Deserialize(FZUMGSVMSUT root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class IRIPAZLBUNE : CWFORSLEVMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public UMXUYEGRVIJ BXYDSMGQXTF;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public IRIPAZLBUNE(UMXUYEGRVIJ a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7083A30", Offset = "0x7082E30", VA = "0x187083A30")]
		public IRIPAZLBUNE(int a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x70838B0", Offset = "0x7082CB0", VA = "0x1870838B0", Slot = "5")]
		public CWFORSLEVMO Clone(FZUMGSVMSUT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7083930", Offset = "0x7082D30", VA = "0x187083930", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class JDSPJOPLWTR : PGIJNLLFEXF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7084510", Offset = "0x7083910", VA = "0x187084510")]
		public JDSPJOPLWTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7084020", Offset = "0x7083420", VA = "0x187084020", Slot = "4")]
		public override CWFORSLEVMO Deserialize(FZUMGSVMSUT root, JProperty extensionToken)
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
