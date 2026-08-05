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
	public class KHR_animation_pointer : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object XAHDPYQKACJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string QEITGKNYHET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string YODSDRFNMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public HQYCXRYQMTF IPELUBCYSNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer WBOMIKRCRLK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x70B3440", Offset = "0x70B1C40", VA = "0x1870B3440", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x70B3390", Offset = "0x70B1B90", VA = "0x1870B3390", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class WOWVLKCYMRE
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 HNRAJFUKGAZ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 FKAKPRVQRJG;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion DPCELNZYAAM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool AQHOXKQQFJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x70C3010", Offset = "0x70C1810", VA = "0x1870C3010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70C1D00", Offset = "0x70C0500", VA = "0x1870C1D00")]
		public static void OTICMVWVZMM(this BERLEXGGYBZ a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70C0920", Offset = "0x70BF120", VA = "0x1870C0920")]
		public static void HJOUNPBPSJU(this BERLEXGGYBZ a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70C28F0", Offset = "0x70C10F0", VA = "0x1870C28F0")]
		public static void RVDYOUKAWMN(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x70C0700", Offset = "0x70BEF00", VA = "0x1870C0700")]
		public static GLTF.Math.Vector4 HBWIJDMWSAH(this GJOSHKOMLSK a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x70C1920", Offset = "0x70C0120", VA = "0x1870C1920")]
		public static UnityEngine.Quaternion MTTGYZGMDVA(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x70C17F0", Offset = "0x70BFFF0", VA = "0x1870C17F0")]
		public static UnityEngine.Quaternion MTTGYZGMDVA(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70C0E20", Offset = "0x70BF620", VA = "0x1870C0E20")]
		public static GLTF.Math.Quaternion ICESFVANQTU(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x70C34E0", Offset = "0x70C1CE0", VA = "0x1870C34E0")]
		public static Matrix4x4 XVVSIOENEOV(this GJOSHKOMLSK a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x70C30A0", Offset = "0x70C18A0", VA = "0x1870C30A0")]
		public static Matrix4x4 XVVSIOENEOV(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x70C14B0", Offset = "0x70BFCB0", VA = "0x1870C14B0")]
		public static GJOSHKOMLSK LXCOZKNJDVH(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x70C0200", Offset = "0x70BEA00", VA = "0x1870C0200")]
		public static UnityEngine.Vector3 AMCEMRIRETG(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x70C0130", Offset = "0x70BE930", VA = "0x1870C0130")]
		public static UnityEngine.Vector3 AMCEMRIRETG(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x70C1380", Offset = "0x70BFB80", VA = "0x1870C1380")]
		public static GLTF.Math.Vector3 LHNUDROWBRC(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70C2FD0", Offset = "0x70C17D0", VA = "0x1870C2FD0")]
		public static GLTF.Math.Vector3 WUXROBYCUPD(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x108B070", Offset = "0x1089870", VA = "0x18108B070")]
		public static GLTF.Math.Vector4 DINUQFGTYTY(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x70C23C0", Offset = "0x70C0BC0", VA = "0x1870C23C0")]
		public static Matrix4x4 QVXIONLYUMM(this GJOSHKOMLSK a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x70C2680", Offset = "0x70C0E80", VA = "0x1870C2680")]
		public static Matrix4x4 QVXIONLYUMM(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x70C11B0", Offset = "0x70BF9B0", VA = "0x1870C11B0")]
		public static GJOSHKOMLSK KCNRZTBHAPK(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x70C0040", Offset = "0x70BE840", VA = "0x1870C0040")]
		public static UnityEngine.Vector2 AJAGCXQHTYM(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x70C0040", Offset = "0x70BE840", VA = "0x1870C0040")]
		public static UnityEngine.Vector2 AJAGCXQHTYM(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x70C0060", Offset = "0x70BE860", VA = "0x1870C0060")]
		public static void AJAGCXQHTYM(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x70C1AA0", Offset = "0x70C02A0", VA = "0x1870C1AA0")]
		public static UnityEngine.Vector3 MYCLKFQVPPL(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1A9CA80", Offset = "0x1A9B280", VA = "0x181A9CA80")]
		public static UnityEngine.Vector3 MYCLKFQVPPL(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x70C1B00", Offset = "0x70C0300", VA = "0x1870C1B00")]
		public static void MYCLKFQVPPL(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x108B070", Offset = "0x1089870", VA = "0x18108B070")]
		public static UnityEngine.Vector4 AGJWJUGGLEO(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x108B070", Offset = "0x1089870", VA = "0x18108B070")]
		public static UnityEngine.Vector4 AGJWJUGGLEO(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x70BFF40", Offset = "0x70BE740", VA = "0x1870BFF40")]
		public static UnityEngine.Vector4[] AGJWJUGGLEO(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x70BFE30", Offset = "0x70BE630", VA = "0x1870BFE30")]
		public static void AGJWJUGGLEO(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70C10A0", Offset = "0x70BF8A0", VA = "0x1870C10A0")]
		public static UnityEngine.Color IUMUJDSIOYU(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x70C0F60", Offset = "0x70BF760", VA = "0x1870C0F60")]
		public static void IUMUJDSIOYU(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x70C10A0", Offset = "0x70BF8A0", VA = "0x1870C10A0")]
		public static UnityEngine.Color IUMUJDSIOYU(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x108B070", Offset = "0x1089870", VA = "0x18108B070")]
		public static UnityEngine.Color OJWBPDZYIJJ(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x70C1BF0", Offset = "0x70C03F0", VA = "0x1870C1BF0")]
		public static void OJWBPDZYIJJ(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x108B070", Offset = "0x1089870", VA = "0x18108B070")]
		public static UnityEngine.Color OJWBPDZYIJJ(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x70C03A0", Offset = "0x70BEBA0", VA = "0x1870C03A0")]
		public static GLTF.Math.Color DQLGQZUIIYV(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x70C0320", Offset = "0x70BEB20", VA = "0x1870C0320")]
		public static GLTF.Math.Color DDZQTONPWME(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x70C2CC0", Offset = "0x70C14C0", VA = "0x1870C2CC0")]
		public static GLTF.Math.Color SLEPFBDQUXI(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x70C22A0", Offset = "0x70C0AA0", VA = "0x1870C22A0")]
		public static UnityEngine.Color[] PKOQQDEYBHN(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x70C2D40", Offset = "0x70C1540", VA = "0x1870C2D40")]
		public static int[] SYKERWNHFDY(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x70C2F20", Offset = "0x70C1720", VA = "0x1870C2F20")]
		public static UnityEngine.Vector2[] WHWLSIJIRWF(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x70C2DC0", Offset = "0x70C15C0", VA = "0x1870C2DC0")]
		public static void TFSVEFVOPIO(KGQVNKKAGMO a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x70C0570", Offset = "0x70BED70", VA = "0x1870C0570")]
		public static UnityEngine.Vector3[] EIVIKPPKPGK(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x70C03D0", Offset = "0x70BEBD0", VA = "0x1870C03D0")]
		public static UnityEngine.Vector4[] ECCUFXSLAQH(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x70C1140", Offset = "0x70BF940", VA = "0x1870C1140")]
		public static void JPBKSRMHRGK(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x70C06D0", Offset = "0x70BEED0", VA = "0x1870C06D0")]
		public static UnityEngine.Quaternion GBTSRCXJNPK(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class KGQVNKKAGMO
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ANNHZWNIYUF ANNHZWNIYUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray PXAAYOADKCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x70B16C0", Offset = "0x70AFEC0", VA = "0x1870B16C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> YUIOKUDNLEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xBEB760", Offset = "0xBE9F60", VA = "0x180BEB760")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCCCCA0", Offset = "0xCCB4A0", VA = "0x180CCCCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint VBOLXXOSKHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAADFA0", Offset = "0xAAC7A0", VA = "0x180AADFA0")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAAD940", Offset = "0xAAC140", VA = "0x180AAD940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x70B16D0", Offset = "0x70AFED0", VA = "0x1870B16D0")]
		public KGQVNKKAGMO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x70B0190", Offset = "0x70AE990", VA = "0x1870B0190")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x70B01F0", Offset = "0x70AE9F0", VA = "0x1870B01F0")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class PPQYYJGWTWT
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class DIZMVRSPJNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> JLTENBHIPPU;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public DIZMVRSPJNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x70AEB30", Offset = "0x70AD330", VA = "0x1870AEB30")]
			internal int? EGMVOELMANJ(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x70AEC80", Offset = "0x70AD480", VA = "0x1870AEC80")]
			internal int? OITZPOBBOHU(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x70AEBB0", Offset = "0x70AD3B0", VA = "0x1870AEBB0")]
			internal bool EYEDNYXVCRE(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x70B9610", Offset = "0x70B7E10", VA = "0x1870B9610")]
		private static void AIPKCUKLWWY(NumericArray a, KGQVNKKAGMO b, KGQVNKKAGMO c, KGQVNKKAGMO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x70BA350", Offset = "0x70B8B50", VA = "0x1870BA350")]
		public static void WZQHISURUYR(Dictionary<string, KGQVNKKAGMO> a, Dictionary<string, (KGQVNKKAGMO sparseIndices, KGQVNKKAGMO sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x70B9E70", Offset = "0x70B8670", VA = "0x1870B9E70")]
		public static void VAYDBOVWUGB(Dictionary<string, KGQVNKKAGMO> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x70B9D70", Offset = "0x70B8570", VA = "0x1870B9D70")]
		public static void OOGEUGUWXCS(KGQVNKKAGMO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x70B9080", Offset = "0x70B7880", VA = "0x1870B9080")]
		public static void AEGIVYAQTJS(Dictionary<string, List<KGQVNKKAGMO>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x70B9B80", Offset = "0x70B8380", VA = "0x1870B9B80")]
		private static void HHVETCLEAWI(KGQVNKKAGMO a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x70B9CB0", Offset = "0x70B84B0", VA = "0x1870B9CB0")]
		internal static void HHVETCLEAWI(TJHKYMCWPRO a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x70BB610", Offset = "0x70B9E10", VA = "0x1870BB610")]
		public static YQPLXVVAQMG XUGZSPPUVGU(IEnumerable<YQPLXVVAQMG> a)
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
			[Cpp2IlInjected.Address(RVA = "0xC9D050", Offset = "0xC9B850", VA = "0x180C9D050")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x12EB0F0", Offset = "0x12E98F0", VA = "0x1812EB0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2DF3480", Offset = "0x2DF1C80", VA = "0x182DF3480")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2DF3490", Offset = "0x2DF1C90", VA = "0x182DF3490")]
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
	public class CPGGTILCLBD
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint LTWRWJMEOTY;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint AZRUIAVKYDO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint FGXOVKJRBOS;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x70ADCE0", Offset = "0x70AC4E0", VA = "0x1870ADCE0")]
		public static void BSYUOOVVTXG(Stream a, [Out] WTVTOFLEGQC b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x70AE3D0", Offset = "0x70ACBD0", VA = "0x1870AE3D0")]
		public static ChunkInfo WRPHUIDOWJG(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x70ADEA0", Offset = "0x70AC6A0", VA = "0x1870ADEA0")]
		public static GLBHeader CLGMGPIMXJC(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x70AE070", Offset = "0x70AC870", VA = "0x1870AE070")]
		public static bool GJWRJOPXXPI(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x70AE660", Offset = "0x70ACE60", VA = "0x1870AE660")]
		public static ChunkInfo XLELHSSOMNV(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x70AE130", Offset = "0x70AC930", VA = "0x1870AE130")]
		private static void RHKYIMSZNLD(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x70ADFE0", Offset = "0x70AC7E0", VA = "0x1870ADFE0")]
		private static uint DNTBNLPSBWE(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class LOINOQVCLTV
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
		public PathElement XMZALPOMTCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA9E110", Offset = "0xA9C910", VA = "0x180A9E110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAA9530", Offset = "0xAA7D30", VA = "0x180AA9530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int SPLEGEZJYLT
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB447A0", Offset = "0xB42FA0", VA = "0x180B447A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xB446E0", Offset = "0xB42EE0", VA = "0x180B446E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string EIWXHIUAGUG
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAA1640", Offset = "0xA9FE40", VA = "0x180AA1640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JWLVWZGMDSD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAA8640", Offset = "0xAA6E40", VA = "0x180AA8640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA8650", Offset = "0xAA6E50", VA = "0x180AA8650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LOINOQVCLTV WSORJLAEAAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAA1380", Offset = "0xA9FB80", VA = "0x180AA1380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x70B6C60", Offset = "0x70B5460", VA = "0x1870B6C60")]
		public string LZQCYMWUOTR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x70B6CE0", Offset = "0x70B54E0", VA = "0x1870B6CE0")]
		public LOINOQVCLTV TAFEYQTRBBL(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x70B6D00", Offset = "0x70B5500", VA = "0x1870B6D00")]
		private LOINOQVCLTV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x70B6D60", Offset = "0x70B5560", VA = "0x1870B6D60")]
		public LOINOQVCLTV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4030F90", Offset = "0x402F790", VA = "0x184030F90")]
		[CompilerGenerated]
		internal static string JKFDRBGTWWP(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x70B6C20", Offset = "0x70B5420", VA = "0x1870B6C20")]
		[CompilerGenerated]
		internal static bool CKZBUNJFEXE([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x70B6A40", Offset = "0x70B5240", VA = "0x1870B6A40")]
		[CompilerGenerated]
		internal static LOINOQVCLTV BYMHCHMWJTC(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class GQVMKDFFPRK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x70B0250", Offset = "0x70AEA50", VA = "0x1870B0250")]
		public static int[] OEZGLRHPNJI(this WTVTOFLEGQC a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x70B04F0", Offset = "0x70AECF0", VA = "0x1870B04F0")]
		public static int[] PHITLKWAKYA(this WTVTOFLEGQC a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class TXLLBXGILNK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x70BDC10", Offset = "0x70BC410", VA = "0x1870BDC10")]
		public static uint KBPZIHIYBCT(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream XTWFYIWZQQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long OMMZNTXLCFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long NSLCHFYACDB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x70BC9E0", Offset = "0x70BB1E0", VA = "0x1870BC9E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x70BCA20", Offset = "0x70BB220", VA = "0x1870BCA20", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x70BCA20", Offset = "0x70BB220", VA = "0x1870BCA20", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x70BCA40", Offset = "0x70BB240", VA = "0x1870BCA40", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x70BCA60", Offset = "0x70BB260", VA = "0x1870BCA60", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x70BCA80", Offset = "0x70BB280", VA = "0x1870BCA80", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x70BC770", Offset = "0x70BAF70", VA = "0x1870BC770")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x70BC530", Offset = "0x70BAD30", VA = "0x1870BC530", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x70BC690", Offset = "0x70BAE90", VA = "0x1870BC690", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x70BC6F0", Offset = "0x70BAEF0", VA = "0x1870BC6F0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x70BC600", Offset = "0x70BAE00", VA = "0x1870BC600", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x70BC730", Offset = "0x70BAF30", VA = "0x1870BC730", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x70BC570", Offset = "0x70BAD70", VA = "0x1870BC570")]
		private void GDDXGWUATUC()
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
		public static Color BUENQVHMETM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x70AE830", Offset = "0x70AD030", VA = "0x1870AE830")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color LXUIIRCMVYY
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x70AEB00", Offset = "0x70AD300", VA = "0x1870AEB00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color HNOVSDBTMBK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x70AEB10", Offset = "0x70AD310", VA = "0x1870AEB10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B24420", Offset = "0x2B22C20", VA = "0x182B24420")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x157FE40", Offset = "0x157E640", VA = "0x18157FE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B665D0", Offset = "0x2B64DD0", VA = "0x182B665D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B665E0", Offset = "0x2B64DE0", VA = "0x182B665E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x28E5730", Offset = "0x28E3F30", VA = "0x1828E5730")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2FE75F0", Offset = "0x2FE5DF0", VA = "0x182FE75F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x12461A0", Offset = "0x12449A0", VA = "0x1812461A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x12461B0", Offset = "0x12449B0", VA = "0x1812461B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28A7AE0", Offset = "0x28A62E0", VA = "0x1828A7AE0")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x70AE850", Offset = "0x70AD050", VA = "0x1870AE850", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x70AE900", Offset = "0x70AD100", VA = "0x1870AE900", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x70AE9A0", Offset = "0x70AD1A0", VA = "0x1870AE9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x70AEA50", Offset = "0x70AD250", VA = "0x1870AEA50")]
		public static bool IDTAQAUODHM(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class GJOSHKOMLSK : IEquatable<GJOSHKOMLSK>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly GJOSHKOMLSK EWUYWGQBOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] DUPFDYAVVDF;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float QZWIGPAWVCI
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x70AFA50", Offset = "0x70AE250", VA = "0x1870AFA50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x70AF9C0", Offset = "0x70AE1C0", VA = "0x1870AF9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float XERSIQCDURJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x70AF510", Offset = "0x70ADD10", VA = "0x1870AF510")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x70AF480", Offset = "0x70ADC80", VA = "0x1870AF480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float EEYJMUWLRNA
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x70AFDE0", Offset = "0x70AE5E0", VA = "0x1870AFDE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x70AFCF0", Offset = "0x70AE4F0", VA = "0x1870AFCF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float MCGKXFMZJCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x70AFC60", Offset = "0x70AE460", VA = "0x1870AFC60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x70AFB70", Offset = "0x70AE370", VA = "0x1870AFB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float RAMCYJIOXKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x70AFA80", Offset = "0x70AE280", VA = "0x1870AFA80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x70AF9F0", Offset = "0x70AE1F0", VA = "0x1870AF9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float XEWZFWWBECS
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x70AF570", Offset = "0x70ADD70", VA = "0x1870AF570")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x70AF4E0", Offset = "0x70ADCE0", VA = "0x1870AF4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float EETCPOCOIBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x70AFD80", Offset = "0x70AE580", VA = "0x1870AFD80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x70AFC90", Offset = "0x70AE490", VA = "0x1870AFC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float MBQQFLFHGUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x70AFC30", Offset = "0x70AE430", VA = "0x1870AFC30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x70AFB40", Offset = "0x70AE340", VA = "0x1870AFB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float RAGWBCORNZA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x70AFAB0", Offset = "0x70AE2B0", VA = "0x1870AFAB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x70AFA20", Offset = "0x70AE220", VA = "0x1870AFA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float XFCGDDPYNOB
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x70AF540", Offset = "0x70ADD40", VA = "0x1870AF540")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x70AF4B0", Offset = "0x70ADCB0", VA = "0x1870AF4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float EENVSHIQYQI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x70AFDB0", Offset = "0x70AE5B0", VA = "0x1870AFDB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x70AFCC0", Offset = "0x70AE4C0", VA = "0x1870AFCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float MBVXCRZEQFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x70AFC00", Offset = "0x70AE400", VA = "0x1870AFC00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x70AFB10", Offset = "0x70AE310", VA = "0x1870AFB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float RAWQSWWJQHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x70AFAE0", Offset = "0x70AE2E0", VA = "0x1870AFAE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x70AF990", Offset = "0x70AE190", VA = "0x1870AF990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float XFHNAKJVWZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x70AF5A0", Offset = "0x70ADDA0", VA = "0x1870AF5A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x70AF450", Offset = "0x70ADC50", VA = "0x1870AF450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float EFYRZCRYMRT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x70AFD50", Offset = "0x70AE550", VA = "0x1870AFD50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x70AFD20", Offset = "0x70AE520", VA = "0x1870AFD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float MCWFOZURLKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x70AFBD0", Offset = "0x70AE3D0", VA = "0x1870AFBD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x70AFBA0", Offset = "0x70AE3A0", VA = "0x1870AFBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x70AFEE0", Offset = "0x70AE6E0", VA = "0x1870AFEE0")]
		public GJOSHKOMLSK(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x70AF6D0", Offset = "0x70ADED0", VA = "0x1870AF6D0", Slot = "4")]
		public bool Equals(GJOSHKOMLSK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x70AF5D0", Offset = "0x70ADDD0", VA = "0x1870AF5D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xDFC8D0", Offset = "0xDFB0D0", VA = "0x180DFC8D0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B24420", Offset = "0x2B22C20", VA = "0x182B24420")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x157FE40", Offset = "0x157E640", VA = "0x18157FE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2B665D0", Offset = "0x2B64DD0", VA = "0x182B665D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2B665E0", Offset = "0x2B64DE0", VA = "0x182B665E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x28E5730", Offset = "0x28E3F30", VA = "0x1828E5730")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x2FE75F0", Offset = "0x2FE5DF0", VA = "0x182FE75F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x12461A0", Offset = "0x12449A0", VA = "0x1812461A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x12461B0", Offset = "0x12449B0", VA = "0x1812461B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x70BBF50", Offset = "0x70BA750", VA = "0x1870BBF50")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x70BBBC0", Offset = "0x70BA3C0", VA = "0x1870BBBC0", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x70BBCE0", Offset = "0x70BA4E0", VA = "0x1870BBCE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x70BBD90", Offset = "0x70BA590", VA = "0x1870BBD90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x70BBE70", Offset = "0x70BA670", VA = "0x1870BBE70")]
		public static bool IDTAQAUODHM(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B24420", Offset = "0x2B22C20", VA = "0x182B24420")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x157FE40", Offset = "0x157E640", VA = "0x18157FE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2B665D0", Offset = "0x2B64DD0", VA = "0x182B665D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2B665E0", Offset = "0x2B64DE0", VA = "0x182B665E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xD78F10", Offset = "0xD77710", VA = "0x180D78F10")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x70BF960", Offset = "0x70BE160", VA = "0x1870BF960")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x70BF770", Offset = "0x70BDF70", VA = "0x1870BF770", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x70BF7D0", Offset = "0x70BDFD0", VA = "0x1870BF7D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x70BF8B0", Offset = "0x70BE0B0", VA = "0x1870BF8B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x70BF900", Offset = "0x70BE100", VA = "0x1870BF900")]
		public static bool IDTAQAUODHM(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B24420", Offset = "0x2B22C20", VA = "0x182B24420")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x157FE40", Offset = "0x157E640", VA = "0x18157FE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2B665D0", Offset = "0x2B64DD0", VA = "0x182B665D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2B665E0", Offset = "0x2B64DE0", VA = "0x182B665E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x28E5730", Offset = "0x28E3F30", VA = "0x1828E5730")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x2FE75F0", Offset = "0x2FE5DF0", VA = "0x182FE75F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x70BFD10", Offset = "0x70BE510", VA = "0x1870BFD10")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x70BF980", Offset = "0x70BE180", VA = "0x1870BF980", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x70BFA60", Offset = "0x70BE260", VA = "0x1870BFA60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x70BFB20", Offset = "0x70BE320", VA = "0x1870BFB20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x70BFBD0", Offset = "0x70BE3D0", VA = "0x1870BFBD0")]
		public static bool IDTAQAUODHM(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B24420", Offset = "0x2B22C20", VA = "0x182B24420")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x157FE40", Offset = "0x157E640", VA = "0x18157FE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B665D0", Offset = "0x2B64DD0", VA = "0x182B665D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2B665E0", Offset = "0x2B64DE0", VA = "0x182B665E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x28E5730", Offset = "0x28E3F30", VA = "0x1828E5730")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x2FE75F0", Offset = "0x2FE5DF0", VA = "0x182FE75F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x12461A0", Offset = "0x12449A0", VA = "0x1812461A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x12461B0", Offset = "0x12449B0", VA = "0x1812461B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28A7AE0", Offset = "0x28A62E0", VA = "0x1828A7AE0")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x70AE850", Offset = "0x70AD050", VA = "0x1870AE850", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x70BFD90", Offset = "0x70BE590", VA = "0x1870BFD90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x70AE9A0", Offset = "0x70AD1A0", VA = "0x1870AE9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class KDBVYCBULZG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x70B1640", Offset = "0x70AFE40", VA = "0x1870B1640")]
		public static void MYFDMCHHSNH(this JObject a, string b, USWQQWDREUK c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class TXLLBXGILNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x70BE610", Offset = "0x70BCE10", VA = "0x1870BE610")]
		public static List<string> VHYBTXXGZCW(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x70BE7C0", Offset = "0x70BCFC0", VA = "0x1870BE7C0")]
		public static List<double> WIANHWZKMBM(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x70BDD60", Offset = "0x70BC560", VA = "0x1870BDD60")]
		public static List<int> OELHGWYANEZ(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3A6C390", Offset = "0x3A6AB90", VA = "0x183A6C390")]
		public static List<a> QQJXUNEPPNJ<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x70BD970", Offset = "0x70BC170", VA = "0x1870BD970")]
		public static USWQQWDREUK JTNSBVBXIUV(this JToken a, WTVTOFLEGQC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x70BE4D0", Offset = "0x70BCCD0", VA = "0x1870BE4D0")]
		public static int UMPCPVOYRGL(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x70BD2E0", Offset = "0x70BBAE0", VA = "0x1870BD2E0")]
		public static double EHERIWMHWLR(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x70BD690", Offset = "0x70BBE90", VA = "0x1870BD690")]
		public static GLTF.Math.Color JEHWMEWDSBK(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x70BD420", Offset = "0x70BBC20", VA = "0x1870BD420")]
		public static GLTF.Math.Color GGZKHMBHWSR(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x70BE230", Offset = "0x70BCA30", VA = "0x1870BE230")]
		public static GLTF.Math.Color RQBKSJLWFSF(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x70BD020", Offset = "0x70BB820", VA = "0x1870BD020")]
		public static GLTF.Math.Vector3 DTPDPEWUTVL(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x70BEBE0", Offset = "0x70BD3E0", VA = "0x1870BEBE0")]
		public static GLTF.Math.Vector2 WNYQFCOUDFD(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x70BE980", Offset = "0x70BD180", VA = "0x1870BE980")]
		public static GLTF.Math.Vector3 WNTJHVUWTTU(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x70BDF20", Offset = "0x70BC720", VA = "0x1870BDF20")]
		public static GLTF.Math.Quaternion OYNBPYTJILN(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3A6BD80", Offset = "0x3A6A580", VA = "0x183A6BD80")]
		public static Dictionary<string, b> EXTNJRHBEWX<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A6BA30", Offset = "0x3A6A230", VA = "0x183A6BA30")]
		public static c EIWTSLUZMHV<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TJHKYMCWPRO bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x70AF2A0", Offset = "0x70ADAA0", VA = "0x1870AF2A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x70AF220", Offset = "0x70ADA20", VA = "0x1870AF220", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class TUPREFBUZKT : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x70BCE60", Offset = "0x70BB660", VA = "0x1870BCE60")]
		public TUPREFBUZKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x70BCD90", Offset = "0x70BB590", VA = "0x1870BCD90", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, ANNHZWNIYUF> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x70AF0E0", Offset = "0x70AD8E0", VA = "0x1870AF0E0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x70AF1A0", Offset = "0x70AD9A0", VA = "0x1870AF1A0")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class VNPXHIRUUXP : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class GZWDQNLWZKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public WTVTOFLEGQC OQYAWLRTKSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader POKMFUTOKNC;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x70B0640", Offset = "0x70AEE40", VA = "0x1870B0640")]
			internal ANNHZWNIYUF WEJZBBRRCBI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x70BF720", Offset = "0x70BDF20", VA = "0x1870BF720")]
		public VNPXHIRUUXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x70BF590", Offset = "0x70BDD90", VA = "0x1870BF590", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NTSIBZNILIJ MTREVSOVOFE;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public EXT_texture_exr(NTSIBZNILIJ source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x70AF2F0", Offset = "0x70ADAF0", VA = "0x1870AF2F0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x70AF360", Offset = "0x70ADB60", VA = "0x1870AF360", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class TWIVDZXMBAA : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x70BCFD0", Offset = "0x70BB7D0", VA = "0x1870BCFD0")]
		public TWIVDZXMBAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x70BCEB0", Offset = "0x70BB6B0", VA = "0x1870BCEB0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
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
	public class AudioEmitterId : GNNRONQTKJO<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x70ADA00", Offset = "0x70AC200", VA = "0x1870ADA00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x70AD9C0", Offset = "0x70AC1C0", VA = "0x1870AD9C0")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : GNNRONQTKJO<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x70ADB90", Offset = "0x70AC390", VA = "0x1870ADB90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x70ADB50", Offset = "0x70AC350", VA = "0x1870ADB50")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : GNNRONQTKJO<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x70AD870", Offset = "0x70AC070", VA = "0x1870AD870", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x70AD830", Offset = "0x70AC030", VA = "0x1870AD830")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x70AD750", Offset = "0x70ABF50", VA = "0x1870AD750")]
		public static AudioDataId Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x70B30B0", Offset = "0x70B18B0", VA = "0x1870B30B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x70B2CB0", Offset = "0x70B14B0", VA = "0x1870B2CB0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x70B2D20", Offset = "0x70B1520", VA = "0x1870B2D20")]
		public static KHR_SceneAudioEmittersRef Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x70B3310", Offset = "0x70B1B10", VA = "0x1870B3310")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x70B2C80", Offset = "0x70B1480", VA = "0x1870B2C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x70B2B60", Offset = "0x70B1360", VA = "0x1870B2B60", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x70B2950", Offset = "0x70B1150", VA = "0x1870B2950", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x70B29C0", Offset = "0x70B11C0", VA = "0x1870B29C0")]
		public static KHR_NodeAudioEmitterRef Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AJVHPMLPDBX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string GLZOIILYFLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? ZOQNGDLAHZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? DSVZARHOFYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? WVCKJJOYRCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? PWRIMJMWLUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? DFLVKCRFRHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? SLEJQGMSZVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? FYVIHPTIDVM;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x70AD4E0", Offset = "0x70ABCE0", VA = "0x1870AD4E0")]
		public JObject JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x70ACDE0", Offset = "0x70AB5E0", VA = "0x1870ACDE0")]
		public static AJVHPMLPDBX Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public AJVHPMLPDBX()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : HFPGWNSLYPC
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
		public AJVHPMLPDBX positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x70B1FA0", Offset = "0x70B07A0", VA = "0x1870B1FA0", Slot = "5")]
		public virtual JObject JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x70B1AA0", Offset = "0x70B02A0", VA = "0x1870B1AA0")]
		public static KHR_AudioEmitter Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x70B2340", Offset = "0x70B0B40", VA = "0x1870B2340")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : HFPGWNSLYPC
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
		[Cpp2IlInjected.Address(RVA = "0x70B2720", Offset = "0x70B0F20", VA = "0x1870B2720")]
		public JObject JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x70B23C0", Offset = "0x70B0BC0", VA = "0x1870B23C0")]
		public static KHR_AudioSource Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x70B1A90", Offset = "0x70B0290", VA = "0x1870B1A90")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public JDSZTARAOKN bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x70B1960", Offset = "0x70B0160", VA = "0x1870B1960")]
		public JObject JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x70B1700", Offset = "0x70AFF00", VA = "0x1870B1700")]
		public static KHR_AudioData Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x70B1A90", Offset = "0x70B0290", VA = "0x1870B1A90")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : RCVNBXYDJZR
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
		[Cpp2IlInjected.Address(RVA = "0x70B35D0", Offset = "0x70B1DD0", VA = "0x1870B35D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x70B3540", Offset = "0x70B1D40", VA = "0x1870B3540", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x70B3D00", Offset = "0x70B2500", VA = "0x1870B3D00")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class LOKWANARRJC : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x70B7AB0", Offset = "0x70B62B0", VA = "0x1870B7AB0")]
		public LOKWANARRJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x70B6F10", Offset = "0x70B5710", VA = "0x1870B6F10", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JDSZTARAOKN bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x70B3ED0", Offset = "0x70B26D0", VA = "0x1870B3ED0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x70B3E10", Offset = "0x70B2610", VA = "0x1870B3E10", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x70B3F20", Offset = "0x70B2720", VA = "0x1870B3F20")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class OZISQSKMTBU : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class GZWDQNLWZKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader POKMFUTOKNC;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x70B06F0", Offset = "0x70AEEF0", VA = "0x1870B06F0")]
			internal int WEJZBBRRCBI()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x70B8D70", Offset = "0x70B7570", VA = "0x1870B8D70")]
		public OZISQSKMTBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x70B8B60", Offset = "0x70B7360", VA = "0x1870B8B60", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public USWQQWDREUK anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x70B4020", Offset = "0x70B2820", VA = "0x1870B4020", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x70B3FA0", Offset = "0x70B27A0", VA = "0x1870B3FA0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class SNPPSAWRKCV : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x70BC4E0", Offset = "0x70BACE0", VA = "0x1870BC4E0")]
		public SNPPSAWRKCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x70BC330", Offset = "0x70BAB30", VA = "0x1870BC330", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public USWQQWDREUK clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public USWQQWDREUK clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public USWQQWDREUK clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x70B42D0", Offset = "0x70B2AD0", VA = "0x1870B42D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x70B4230", Offset = "0x70B2A30", VA = "0x1870B4230", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class THHNTBJJTAT : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x70BCD40", Offset = "0x70BB540", VA = "0x1870BCD40")]
		public THHNTBJJTAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x70BCAC0", Offset = "0x70BB2C0", VA = "0x1870BCAC0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x70B4630", Offset = "0x70B2E30", VA = "0x1870B4630", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x70B45C0", Offset = "0x70B2DC0", VA = "0x1870B45C0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class QPYJDVIWDOL : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x70BBB70", Offset = "0x70BA370", VA = "0x1870BBB70")]
		public QPYJDVIWDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x70BBAA0", Offset = "0x70BA2A0", VA = "0x1870BBAA0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : CKARNJIAQHV, RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float WITYPIMDKWN;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x70B4910", Offset = "0x70B3110", VA = "0x1870B4910")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x70B4960", Offset = "0x70B3160", VA = "0x1870B4960")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, WTVTOFLEGQC root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x70B4750", Offset = "0x70B2F50", VA = "0x1870B4750", Slot = "6")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x70B47F0", Offset = "0x70B2FF0", VA = "0x1870B47F0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class UPAUZLJOJUM : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x70BEF60", Offset = "0x70BD760", VA = "0x1870BEF60")]
		public UPAUZLJOJUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x70BEE60", Offset = "0x70BD660", VA = "0x1870BEE60", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x70B4A30", Offset = "0x70B3230", VA = "0x1870B4A30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x70B49D0", Offset = "0x70B31D0", VA = "0x1870B49D0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x70B4B80", Offset = "0x70B3380", VA = "0x1870B4B80")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class ECBBXILVOXJ : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x70AEDE0", Offset = "0x70AD5E0", VA = "0x1870AEDE0")]
		public ECBBXILVOXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x70AED10", Offset = "0x70AD510", VA = "0x1870AED10", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public USWQQWDREUK iridescenceTexture;

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
		public USWQQWDREUK iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x70B4C30", Offset = "0x70B3430", VA = "0x1870B4C30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x70B4B90", Offset = "0x70B3390", VA = "0x1870B4B90", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x70B4FF0", Offset = "0x70B37F0", VA = "0x1870B4FF0")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class AJEWTXETRTL : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x70ACD90", Offset = "0x70AB590", VA = "0x1870ACD90")]
		public AJEWTXETRTL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x70ACAA0", Offset = "0x70AB2A0", VA = "0x1870ACAA0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class MSHAEGPIMOE : RCVNBXYDJZR
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 IOFGZVPUYPS;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double EVZHLQVQDUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color KJQSFYKRQCA;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color WJQTIHDOCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public USWQQWDREUK ECQUMYOIXSS;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly USWQQWDREUK XJRYAZZCSOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 EJSMMTJHVDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double OEMJNEUXFDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public USWQQWDREUK SKXSQTIMKJV;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly USWQQWDREUK MUJCTONVVLZ;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x70B85A0", Offset = "0x70B6DA0", VA = "0x1870B85A0")]
		public MSHAEGPIMOE(GLTF.Math.Color a, USWQQWDREUK b, GLTF.Math.Vector3 c, double d, USWQQWDREUK e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x70B7C90", Offset = "0x70B6490", VA = "0x1870B7C90", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x70B7E40", Offset = "0x70B6640", VA = "0x1870B7E40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class ONQUVHQSFCG : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x70B8B10", Offset = "0x70B7310", VA = "0x1870B8B10")]
		public ONQUVHQSFCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x70B87C0", Offset = "0x70B6FC0", VA = "0x1870B87C0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public USWQQWDREUK sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public USWQQWDREUK sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x70B50E0", Offset = "0x70B38E0", VA = "0x1870B50E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x70B5010", Offset = "0x70B3810", VA = "0x1870B5010", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x70B55F0", Offset = "0x70B3DF0", VA = "0x1870B55F0")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class EGSVCUHVEDK : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x70AF090", Offset = "0x70AD890", VA = "0x1870AF090")]
		public EGSVCUHVEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x70AEE30", Offset = "0x70AD630", VA = "0x1870AEE30", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public USWQQWDREUK specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public USWQQWDREUK specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x70B5720", Offset = "0x70B3F20", VA = "0x1870B5720", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x70B5650", Offset = "0x70B3E50", VA = "0x1870B5650", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x70B5C30", Offset = "0x70B4430", VA = "0x1870B5C30")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class PMXNSVTVIWU : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x70B9030", Offset = "0x70B7830", VA = "0x1870B9030")]
		public PMXNSVTVIWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x70B8DC0", Offset = "0x70B75C0", VA = "0x1870B8DC0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public USWQQWDREUK transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x70B5D20", Offset = "0x70B4520", VA = "0x1870B5D20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x70B5CA0", Offset = "0x70B44A0", VA = "0x1870B5CA0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class MPUUZMDPCNL : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x70B7C40", Offset = "0x70B6440", VA = "0x1870B7C40")]
		public MPUUZMDPCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x70B7B00", Offset = "0x70B6300", VA = "0x1870B7B00", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class UWKEYAGVSUC : CKARNJIAQHV, RCVNBXYDJZR
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x70BF4D0", Offset = "0x70BDCD0", VA = "0x1870BF4D0")]
		public UWKEYAGVSUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x70BF520", Offset = "0x70BDD20", VA = "0x1870BF520")]
		public UWKEYAGVSUC(UWKEYAGVSUC a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x70BF2D0", Offset = "0x70BDAD0", VA = "0x1870BF2D0", Slot = "6")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x70BF370", Offset = "0x70BDB70", VA = "0x1870BF370", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x70BF400", Offset = "0x70BDC00", VA = "0x1870BF400", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class RUPUYIWTKJS : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x70BC190", Offset = "0x70BA990", VA = "0x1870BC190")]
		public RUPUYIWTKJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x70BC110", Offset = "0x70BA910", VA = "0x1870BC110", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public USWQQWDREUK thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x70B5F40", Offset = "0x70B4740", VA = "0x1870B5F40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x70B5EB0", Offset = "0x70B46B0", VA = "0x1870B5EB0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x70B6470", Offset = "0x70B4C70", VA = "0x1870B6470")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class ILDQYGARYCL : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x70B0D10", Offset = "0x70AF510", VA = "0x1870B0D10")]
		public ILDQYGARYCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x70B0B00", Offset = "0x70AF300", VA = "0x1870B0B00", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x70B64F0", Offset = "0x70B4CF0", VA = "0x1870B64F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x70B6490", Offset = "0x70B4C90", VA = "0x1870B6490", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xF3D820", Offset = "0xF3C020", VA = "0x180F3D820")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class IMRKWMEIWWN : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x70B0E40", Offset = "0x70AF640", VA = "0x1870B0E40")]
		public IMRKWMEIWWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x70B0D60", Offset = "0x70AF560", VA = "0x1870B0D60", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x70B6660", Offset = "0x70B4E60", VA = "0x1870B6660", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x70B6600", Offset = "0x70B4E00", VA = "0x1870B6600", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xF3D820", Offset = "0xF3C020", VA = "0x180F3D820")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class OMHKMSWSAGH : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x70B8770", Offset = "0x70B6F70", VA = "0x1870B8770")]
		public OMHKMSWSAGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x70B8690", Offset = "0x70B6E90", VA = "0x1870B8690", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x70B67D0", Offset = "0x70B4FD0", VA = "0x1870B67D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x70B6770", Offset = "0x70B4F70", VA = "0x1870B6770", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xF3D820", Offset = "0xF3C020", VA = "0x180F3D820")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class RHLVMJMCHZP : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x70BC0C0", Offset = "0x70BA8C0", VA = "0x1870BC0C0")]
		public RHLVMJMCHZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x70BBFE0", Offset = "0x70BA7E0", VA = "0x1870BBFE0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NTSIBZNILIJ source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public KHR_texture_basisu(NTSIBZNILIJ source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x70B68E0", Offset = "0x70B50E0", VA = "0x1870B68E0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x70B6950", Offset = "0x70B5150", VA = "0x1870B6950", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class HEXBUIIZRET : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x70B08C0", Offset = "0x70AF0C0", VA = "0x1870B08C0")]
		public HEXBUIIZRET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x70B0760", Offset = "0x70AEF60", VA = "0x1870B0760", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class JDONLAFOJHG : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 VBOLXXOSKHS;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 GJMMAMZEVSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double UWXJAJSPRJH;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double UJMEYWIBWUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 BDFPJJLKDEX;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 HAIKHHUVGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? VXGZDYOJIOF;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int ATZPHHEDTRB;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x70B15C0", Offset = "0x70AFDC0", VA = "0x1870B15C0")]
		public JDONLAFOJHG(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x70B0E90", Offset = "0x70AF690", VA = "0x1870B0E90", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x70B0F70", Offset = "0x70AF770", VA = "0x1870B0F70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class UTSOIUVDZFA : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x70BF280", Offset = "0x70BDA80", VA = "0x1870BF280")]
		public UTSOIUVDZFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x70BEFB0", Offset = "0x70BD7B0", VA = "0x1870BEFB0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class IDZXXQPYFYK : RCVNBXYDJZR
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> FRMRNGNXGRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public IDZXXQPYFYK(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x70B0910", Offset = "0x70AF110", VA = "0x1870B0910", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x70B0980", Offset = "0x70AF180", VA = "0x1870B0980", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x70B0A70", Offset = "0x70AF270", VA = "0x1870B0A70")]
		public List<double> ZJSOKTZTXEO(BERLEXGGYBZ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class SEFFXSILBQE : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x70BC2E0", Offset = "0x70BAAE0", VA = "0x1870BC2E0")]
		public SEFFXSILBQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x70BC1E0", Offset = "0x70BA9E0", VA = "0x1870BC1E0", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class XWLGDPDBHBS : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public JDSZTARAOKN TJHKYMCWPRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint FXFSJMAWPWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType WZXSMDVDZGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool YKWJQUPRVXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint QYQDPJWWJPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType BFJYMHQJKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> NXPNZDBXDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> LZVZJZPGZWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public DAPTVCNOKYI SWBXMRZGRPF;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x70B1A90", Offset = "0x70B0290", VA = "0x1870B1A90")]
		public XWLGDPDBHBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x70C3EC0", Offset = "0x70C26C0", VA = "0x1870C3EC0")]
		public static XWLGDPDBHBS Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x70C4950", Offset = "0x70C3150", VA = "0x1870C4950", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x70C4620", Offset = "0x70C2E20", VA = "0x1870C4620")]
		private unsafe static sbyte IQIURRBPYCN(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x70C48F0", Offset = "0x70C30F0", VA = "0x1870C48F0")]
		private unsafe static float2 JQMZPDMSDIF(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x70C70F0", Offset = "0x70C58F0", VA = "0x1870C70F0")]
		private unsafe static float3 TIIPEDKGBJG(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x70C7E90", Offset = "0x70C6690", VA = "0x1870C7E90")]
		private unsafe static float4 YWGKJYIEDNN(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x70C3A50", Offset = "0x70C2250", VA = "0x1870C3A50")]
		private unsafe static float4x4 APTXBMQYRTV(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x70C4620", Offset = "0x70C2E20", VA = "0x1870C4620")]
		private unsafe static byte GCTKJTRAWZI(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x70C4630", Offset = "0x70C2E30", VA = "0x1870C4630")]
		private unsafe static float2 IAQAPUAREHK(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x70C80E0", Offset = "0x70C68E0", VA = "0x1870C80E0")]
		private unsafe static float3 ZIWECHIZJUB(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x70C3E10", Offset = "0x70C2610", VA = "0x1870C3E10")]
		private unsafe static float4 BVWZSMVYYBQ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x70C7EF0", Offset = "0x70C66F0", VA = "0x1870C7EF0")]
		private unsafe static float4x4 ZDMLOSZYXHE(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x70C37B0", Offset = "0x70C1FB0", VA = "0x1870C37B0")]
		private unsafe static short BUYFXHNVXHF(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x70C3DE0", Offset = "0x70C25E0", VA = "0x1870C3DE0")]
		private unsafe static float2 BTBPXYNOEUX(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x70C3E70", Offset = "0x70C2670", VA = "0x1870C3E70")]
		private unsafe static float3 DUIGITXPHMG(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x70C4F30", Offset = "0x70C3730", VA = "0x1870C4F30")]
		private unsafe static float4 JYVBTMSGPGV(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x70C73A0", Offset = "0x70C5BA0", VA = "0x1870C73A0")]
		private unsafe static float4x4 UALLLNTMXUV(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x70C37B0", Offset = "0x70C1FB0", VA = "0x1870C37B0")]
		private unsafe static ushort DTAZHZYENBE(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x70C52E0", Offset = "0x70C3AE0", VA = "0x1870C52E0")]
		private unsafe static float2 KVBWFOGBGDS(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x70C3D90", Offset = "0x70C2590", VA = "0x1870C3D90")]
		private unsafe static float3 BSYAICJSYMF(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x70C3BF0", Offset = "0x70C23F0", VA = "0x1870C3BF0")]
		private unsafe static float4x4 BNHJOKIRCGS(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x70C7150", Offset = "0x70C5950", VA = "0x1870C7150")]
		private unsafe static float4 TPXKPZPKKHE(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x70C7140", Offset = "0x70C5940", VA = "0x1870C7140")]
		private unsafe static uint TODAGZABUCP(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x70C37B0", Offset = "0x70C1FB0", VA = "0x1870C37B0")]
		private unsafe static ushort AGIBUIIVUSW(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x70C4F90", Offset = "0x70C3790", VA = "0x1870C4F90")]
		private unsafe static float KKTUDXFXPDN(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x70C5690", Offset = "0x70C3E90", VA = "0x1870C5690")]
		private unsafe static float2 MFMXLBWMZIL(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x70C37C0", Offset = "0x70C1FC0", VA = "0x1870C37C0")]
		private unsafe static float3 AIRUOSUARWS(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x70C4920", Offset = "0x70C3120", VA = "0x1870C4920")]
		private unsafe static float4 JVLUASVCKBL(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x70C7370", Offset = "0x70C5B70", VA = "0x1870C7370")]
		private unsafe static float4x4 TTIJIVCMCOF(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x70C4920", Offset = "0x70C3120", VA = "0x1870C4920")]
		private unsafe static float4 SVUFTEODTYE(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x70C6F50", Offset = "0x70C5750", VA = "0x1870C6F50")]
		private unsafe static float4 SVUFTEODTYE(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x70C43F0", Offset = "0x70C2BF0", VA = "0x1870C43F0")]
		public static float3[] FLJZWVOWOBP(XWLGDPDBHBS a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x70C6440", Offset = "0x70C4C40", VA = "0x1870C6440")]
		public static float3[] OLSUOTHGVDP(XWLGDPDBHBS a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x70C5940", Offset = "0x70C4140", VA = "0x1870C5940")]
		public static uint[] NFDKITXRICE(XWLGDPDBHBS a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x70C47D0", Offset = "0x70C2FD0", VA = "0x1870C47D0")]
		internal static void IOPFSHQTTEJ(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x70C7B30", Offset = "0x70C6330", VA = "0x1870C7B30")]
		public uint[] XDMFQJCYDTS(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x70C37E0", Offset = "0x70C1FE0", VA = "0x1870C37E0")]
		public float[] ANEESZDDRKQ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x70C56B0", Offset = "0x70C3EB0", VA = "0x1870C56B0")]
		public float2[] MYMQRRUBDSI(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x70C5AB0", Offset = "0x70C42B0", VA = "0x1870C5AB0")]
		public float2[] NMKKLMEKCGK(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x70C78B0", Offset = "0x70C60B0", VA = "0x1870C78B0")]
		public float3[] VOHJOSFLSSB(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x70C6750", Offset = "0x70C4F50", VA = "0x1870C6750")]
		public float3[] PIMPSXHZFNH(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x70C5420", Offset = "0x70C3C20", VA = "0x1870C5420")]
		public float4[] LTDOYXIZFAS(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x70C7540", Offset = "0x70C5D40", VA = "0x1870C7540")]
		public float4[] VJZIJAISJAK(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x70C6AA0", Offset = "0x70C52A0", VA = "0x1870C6AA0")]
		public float4[] RPOECOPDKGL(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x70C7D80", Offset = "0x70C6580", VA = "0x1870C7D80")]
		public float3[] YSGMQYYSQFY(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x70C5310", Offset = "0x70C3B10", VA = "0x1870C5310")]
		public float3[] LQVSESNGYBL(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x70C4320", Offset = "0x70C2B20", VA = "0x1870C4320")]
		public float4[] ESYOCFARXPP(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x70C8090", Offset = "0x70C6890", VA = "0x1870C8090")]
		public uint[] ZDNKUZZGJOA(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x70C5E90", Offset = "0x70C4690", VA = "0x1870C5E90")]
		public float4x4[] NQWRRBVEHWP(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x70C5120", Offset = "0x70C3920", VA = "0x1870C5120")]
		private unsafe static float4 KONWXRNTXVB(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x70C4FA0", Offset = "0x70C37A0", VA = "0x1870C4FA0")]
		private unsafe static float4 KONWXRNTXVB(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x70C6F80", Offset = "0x70C5780", VA = "0x1870C6F80")]
		private unsafe static float4x4 TEEGRSMIJGQ(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x70C71B0", Offset = "0x70C59B0", VA = "0x1870C71B0")]
		private unsafe static float4 TTHMFFTHPTS(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x70C4660", Offset = "0x70C2E60", VA = "0x1870C4660")]
		private unsafe static float3 IGWZHPRADMX(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x70C5D60", Offset = "0x70C4560", VA = "0x1870C5D60")]
		private unsafe static float2 NPWTEYKDRBY(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x70C6E30", Offset = "0x70C5630", VA = "0x1870C6E30")]
		private unsafe static uint SVSHAMYCJAT(void* a, uint b, GLTFComponentType c)
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
	public static class UULKYIFPFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x70D67D0", Offset = "0x70D4FD0", VA = "0x1870D67D0")]
		public static int QTRWYHKYLIR(this GLTFAccessorAttributeType a)
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
	public class DAPTVCNOKYI : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int QYQDPJWWJPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public GJMJQNTARVX KQGGERXYISM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public RGKKFTNVFHE IFFINMZNWHT;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x70CD7A0", Offset = "0x70CBFA0", VA = "0x1870CD7A0")]
		public DAPTVCNOKYI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x70CD3A0", Offset = "0x70CBBA0", VA = "0x1870CD3A0")]
		public static DAPTVCNOKYI Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x70CD670", Offset = "0x70CBE70", VA = "0x1870CD670", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class GJMJQNTARVX : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public JDSZTARAOKN TJHKYMCWPRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int FXFSJMAWPWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType WZXSMDVDZGG;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x70CF010", Offset = "0x70CD810", VA = "0x1870CF010")]
		public GJMJQNTARVX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x70CEBF0", Offset = "0x70CD3F0", VA = "0x1870CEBF0")]
		public static GJMJQNTARVX Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x70CEED0", Offset = "0x70CD6D0", VA = "0x1870CEED0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class RGKKFTNVFHE : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public JDSZTARAOKN TJHKYMCWPRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int FXFSJMAWPWG;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x70D44A0", Offset = "0x70D2CA0", VA = "0x1870D44A0")]
		public RGKKFTNVFHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x70D4120", Offset = "0x70D2920", VA = "0x1870D4120")]
		public static RGKKFTNVFHE Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x70D43A0", Offset = "0x70D2BA0", VA = "0x1870D43A0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class CPFJIWONMQK : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public DXCFNBUOULO LTVNKOBTVMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public HQYCXRYQMTF FMLWCFPZQDQ;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x70CCA80", Offset = "0x70CB280", VA = "0x1870CCA80")]
		public CPFJIWONMQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x70CC790", Offset = "0x70CAF90", VA = "0x1870CC790")]
		public static CPFJIWONMQK Deserialize(WTVTOFLEGQC root, JsonReader reader, ZCPNPFGNFZG anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x70CC980", Offset = "0x70CB180", VA = "0x1870CC980", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class HQYCXRYQMTF : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public YQPLXVVAQMG BERLEXGGYBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string MVXIJBZHFMA;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x70D00D0", Offset = "0x70CE8D0", VA = "0x1870D00D0")]
		public static HQYCXRYQMTF Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x70D0450", Offset = "0x70CEC50", VA = "0x1870D0450")]
		public HQYCXRYQMTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x70D0330", Offset = "0x70CEB30", VA = "0x1870D0330", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
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
	public class WCSOTBUVZFK
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(WCSOTBUVZFK data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] KLGNLILHXHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type HAGNYPPDNHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] ZEEBWSKVCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion REHWCCOBGTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string XOEIZQBEYKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string SQMBZWDGOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public KGQVNKKAGMO RGFWIVHUIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string UIOMTOHHCYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string SNPGAOYLCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public KGQVNKKAGMO UOACOKTJWPJ;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x70D6840", Offset = "0x70D5040", VA = "0x1870D6840")]
		public WCSOTBUVZFK()
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
	public class YFTAWGGGKEJ : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public ANNHZWNIYUF UHXHDUMBWIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType NJBYTDFXEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public ANNHZWNIYUF ZYBPMWZTKGC;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x70DC840", Offset = "0x70DB040", VA = "0x1870DC840")]
		public YFTAWGGGKEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x70DC4B0", Offset = "0x70DACB0", VA = "0x1870DC4B0")]
		public static YFTAWGGGKEJ Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x70DC6D0", Offset = "0x70DAED0", VA = "0x1870DC6D0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class JPKUYULHDWV : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string GDOCZGMZOGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string HRMIJOUGJNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string VJOLSNEECRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string ZAJBTWXWCFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> POBHOAOSRYT;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x70D17F0", Offset = "0x70CFFF0", VA = "0x1870D17F0")]
		public JPKUYULHDWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x70D0D00", Offset = "0x70CF500", VA = "0x1870D0D00")]
		public static JPKUYULHDWV Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x70D13C0", Offset = "0x70CFBC0", VA = "0x1870D13C0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x70D17E0", Offset = "0x70CFFE0", VA = "0x1870D17E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x70D1020", Offset = "0x70CF820", VA = "0x1870D1020")]
		public string HMFSIWGYSAH(bool a)
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
	public class TJHKYMCWPRO : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public CPXGVJRXHMQ VDPSBGBFOKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint FXFSJMAWPWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint CQXJGQSHELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint NRLMPURQNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget FMLWCFPZQDQ;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x70C8B70", Offset = "0x70C7370", VA = "0x1870C8B70")]
		public TJHKYMCWPRO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x70D5910", Offset = "0x70D4110", VA = "0x1870D5910")]
		public static TJHKYMCWPRO Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x70D5BC0", Offset = "0x70D43C0", VA = "0x1870D5BC0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class AVQGGELEYFQ : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double RZCQKGGXOQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double SVCQCWTZGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double INEWDPWMMYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double INLOYGXHPZP;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x70C8800", Offset = "0x70C7000", VA = "0x1870C8800")]
		public AVQGGELEYFQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x70C8310", Offset = "0x70C6B10", VA = "0x1870C8310")]
		public static AVQGGELEYFQ Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x70C8690", Offset = "0x70C6E90", VA = "0x1870C8690", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class IADQMNXRALY : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double GPKSPYDRSFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double YRZQVKVZZFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double INEWDPWMMYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double INLOYGXHPZP;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x70D09A0", Offset = "0x70CF1A0", VA = "0x1870D09A0")]
		public IADQMNXRALY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x70D04A0", Offset = "0x70CECA0", VA = "0x1870D04A0")]
		public static IADQMNXRALY Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x70D0810", Offset = "0x70CF010", VA = "0x1870D0810", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ZCPNPFGNFZG : HFPGWNSLYPC
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class GZWDQNLWZKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public WTVTOFLEGQC OQYAWLRTKSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader POKMFUTOKNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public ZCPNPFGNFZG OXCQLHQOXJV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<CPFJIWONMQK> VRMPKGMRFAW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<YFTAWGGGKEJ> VRRWHNGOOMF;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x70CF2A0", Offset = "0x70CDAA0", VA = "0x1870CF2A0")]
			internal CPFJIWONMQK WEJZBBRRCBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x70CF2C0", Offset = "0x70CDAC0", VA = "0x1870CF2C0")]
			internal YFTAWGGGKEJ WEPFYILOLMR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<CPFJIWONMQK> HVHPBAHNQDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<YFTAWGGGKEJ> EKXUXTNWQZM;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x70DD710", Offset = "0x70DBF10", VA = "0x1870DD710")]
		public static ZCPNPFGNFZG Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x70DDE70", Offset = "0x70DC670", VA = "0x1870DDE70")]
		public ZCPNPFGNFZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x70DDAD0", Offset = "0x70DC2D0", VA = "0x1870DDAD0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class BBDSDFOIDBC : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string UEFVNAGPVOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint CQXJGQSHELD;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x70C8B70", Offset = "0x70C7370", VA = "0x1870C8B70")]
		public BBDSDFOIDBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x70C8850", Offset = "0x70C7050", VA = "0x1870C8850")]
		public static BBDSDFOIDBC Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x70C8A20", Offset = "0x70C7220", VA = "0x1870C8A20", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class PJNTLMSRGVL : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AVQGGELEYFQ PYVOOMWGZXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public IADQMNXRALY EBLOBFLPJVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType BFJYMHQJKIL;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x70C8B70", Offset = "0x70C7370", VA = "0x1870C8B70")]
		public PJNTLMSRGVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x70D39A0", Offset = "0x70D21A0", VA = "0x1870D39A0")]
		public static PJNTLMSRGVL Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x70D3B70", Offset = "0x70D2370", VA = "0x1870D3B70", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
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
	public class HFPGWNSLYPC : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string NRBYPZADYJW;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x70C8B70", Offset = "0x70C7370", VA = "0x1870C8B70")]
		public HFPGWNSLYPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x70CF450", Offset = "0x70CDC50", VA = "0x1870CF450")]
		public HFPGWNSLYPC(HFPGWNSLYPC a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x70CF2D0", Offset = "0x70CDAD0", VA = "0x1870CF2D0")]
		public new void DZIBRYOGCXI(WTVTOFLEGQC a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x70CF3C0", Offset = "0x70CDBC0", VA = "0x1870CF3C0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class GNNRONQTKJO<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int CXQIBDZHUDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public WTVTOFLEGQC XQVYPEOBNLV;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		protected GNNRONQTKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x4DCF6E0", Offset = "0x4DCDEE0", VA = "0x184DCF6E0")]
		public GNNRONQTKJO(GNNRONQTKJO<a> a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4DCF6B0", Offset = "0x4DCDEB0", VA = "0x184DCF6B0")]
		public void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class ANNHZWNIYUF : GNNRONQTKJO<XWLGDPDBHBS>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override XWLGDPDBHBS Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x70C82B0", Offset = "0x70C6AB0", VA = "0x1870C82B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x70C8210", Offset = "0x70C6A10", VA = "0x1870C8210")]
		public ANNHZWNIYUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x70C8250", Offset = "0x70C6A50", VA = "0x1870C8250")]
		public ANNHZWNIYUF(ANNHZWNIYUF a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x70C8130", Offset = "0x70C6930", VA = "0x1870C8130")]
		public static ANNHZWNIYUF Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class CPXGVJRXHMQ : GNNRONQTKJO<BBDSDFOIDBC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override BBDSDFOIDBC Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x70CCBF0", Offset = "0x70CB3F0", VA = "0x1870CCBF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x70CCBB0", Offset = "0x70CB3B0", VA = "0x1870CCBB0")]
		public CPXGVJRXHMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x70CCAD0", Offset = "0x70CB2D0", VA = "0x1870CCAD0")]
		public static CPXGVJRXHMQ Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class JDSZTARAOKN : GNNRONQTKJO<TJHKYMCWPRO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override TJHKYMCWPRO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x70D0CA0", Offset = "0x70CF4A0", VA = "0x1870D0CA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x70D0C60", Offset = "0x70CF460", VA = "0x1870D0C60")]
		public JDSZTARAOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x70D0B80", Offset = "0x70CF380", VA = "0x1870D0B80")]
		public static JDSZTARAOKN Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class CAHKCJZXWON : GNNRONQTKJO<PJNTLMSRGVL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override PJNTLMSRGVL Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x70CA860", Offset = "0x70C9060", VA = "0x1870CA860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x70CA820", Offset = "0x70C9020", VA = "0x1870CA820")]
		public CAHKCJZXWON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x70CA740", Offset = "0x70C8F40", VA = "0x1870CA740")]
		public static CAHKCJZXWON Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class NTSIBZNILIJ : GNNRONQTKJO<NNQENYBDRHR>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NNQENYBDRHR Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x70D2CB0", Offset = "0x70D14B0", VA = "0x1870D2CB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x70D2C70", Offset = "0x70D1470", VA = "0x1870D2C70")]
		public NTSIBZNILIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x70D2B90", Offset = "0x70D1390", VA = "0x1870D2B90")]
		public static NTSIBZNILIJ Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class HOWNCWMIGVN : GNNRONQTKJO<OFRYBPDMWCH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override OFRYBPDMWCH Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x70CFFC0", Offset = "0x70CE7C0", VA = "0x1870CFFC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x70CFF80", Offset = "0x70CE780", VA = "0x1870CFF80")]
		public HOWNCWMIGVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x70CFF20", Offset = "0x70CE720", VA = "0x1870CFF20")]
		public HOWNCWMIGVN(HOWNCWMIGVN a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x70CFE40", Offset = "0x70CE640", VA = "0x1870CFE40")]
		public static HOWNCWMIGVN Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class JDSRIUAAMBB : GNNRONQTKJO<HMCQBNAUHVJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override HMCQBNAUHVJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x70D0B20", Offset = "0x70CF320", VA = "0x1870D0B20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x70D0AE0", Offset = "0x70CF2E0", VA = "0x1870D0AE0")]
		public JDSRIUAAMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x70D0A00", Offset = "0x70CF200", VA = "0x1870D0A00")]
		public static JDSRIUAAMBB Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class YQPLXVVAQMG : GNNRONQTKJO<BERLEXGGYBZ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override BERLEXGGYBZ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x70DCC20", Offset = "0x70DB420", VA = "0x1870DCC20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x70DCBE0", Offset = "0x70DB3E0", VA = "0x1870DCBE0")]
		public YQPLXVVAQMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x70DC890", Offset = "0x70DB090", VA = "0x1870DC890")]
		public static YQPLXVVAQMG Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x70DC970", Offset = "0x70DB170", VA = "0x1870DC970")]
		public static List<YQPLXVVAQMG> QQJXUNEPPNJ(WTVTOFLEGQC a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class CLUJQPIEVOU : GNNRONQTKJO<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x70CC730", Offset = "0x70CAF30", VA = "0x1870CC730", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x70CC6F0", Offset = "0x70CAEF0", VA = "0x1870CC6F0")]
		public CLUJQPIEVOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x70CC610", Offset = "0x70CAE10", VA = "0x1870CC610")]
		public static CLUJQPIEVOU Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class DXCFNBUOULO : GNNRONQTKJO<YFTAWGGGKEJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public ZCPNPFGNFZG ZCPNPFGNFZG;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override YFTAWGGGKEJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x70CDEC0", Offset = "0x70CC6C0", VA = "0x1870CDEC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x70CDE80", Offset = "0x70CC680", VA = "0x1870CDE80")]
		public DXCFNBUOULO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x70CDD80", Offset = "0x70CC580", VA = "0x1870CDD80")]
		public static DXCFNBUOULO Deserialize(WTVTOFLEGQC root, ZCPNPFGNFZG anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class DAWXZYRRAUE : GNNRONQTKJO<FHGUWOJFITY>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override FHGUWOJFITY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x70CD910", Offset = "0x70CC110", VA = "0x1870CD910", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x70CD8D0", Offset = "0x70CC0D0", VA = "0x1870CD8D0")]
		public DAWXZYRRAUE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x70CD7F0", Offset = "0x70CBFF0", VA = "0x1870CD7F0")]
		public static DAWXZYRRAUE Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class ZBLVNRGSJCX : GNNRONQTKJO<XLGFUPUXDAO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override XLGFUPUXDAO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x70DD6B0", Offset = "0x70DBEB0", VA = "0x1870DD6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x70DD670", Offset = "0x70DBE70", VA = "0x1870DD670")]
		public ZBLVNRGSJCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x70DD590", Offset = "0x70DBD90", VA = "0x1870DD590")]
		public static ZBLVNRGSJCX Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class CUEDZTDBNVB : GNNRONQTKJO<RAWOIEBXRSB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override RAWOIEBXRSB Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x70CD340", Offset = "0x70CBB40", VA = "0x1870CD340", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x70CD2A0", Offset = "0x70CBAA0", VA = "0x1870CD2A0")]
		public CUEDZTDBNVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x70CD2E0", Offset = "0x70CBAE0", VA = "0x1870CD2E0")]
		public CUEDZTDBNVB(CUEDZTDBNVB a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x70CD1C0", Offset = "0x70CB9C0", VA = "0x1870CD1C0")]
		public static CUEDZTDBNVB Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class RAICXMWOJTG : GNNRONQTKJO<WGTBIMSOTQG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override WGTBIMSOTQG Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x70D3D80", Offset = "0x70D2580", VA = "0x1870D3D80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x70D3D40", Offset = "0x70D2540", VA = "0x1870D3D40")]
		public RAICXMWOJTG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class NNQENYBDRHR : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string UEFVNAGPVOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string JVVMBRIXGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public JDSZTARAOKN TJHKYMCWPRO;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x70C8B70", Offset = "0x70C7370", VA = "0x1870C8B70")]
		public NNQENYBDRHR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x70D2780", Offset = "0x70D0F80", VA = "0x1870D2780")]
		public static NNQENYBDRHR Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x70D29C0", Offset = "0x70D11C0", VA = "0x1870D29C0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class OFRYBPDMWCH : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public FWINARFTNES FWINARFTNES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public CTRATNJFWMP SSHIYFOBPUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public KPEFKKJMQLF FAMLFUDUFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public DKWTFROCKWH KWWDJKXRBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public USWQQWDREUK AXDZLCKHOVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color LRYBHNQNDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode GGJTCONIJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double OTKURKCCJZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool GKXCEMDFEYT;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x70D36F0", Offset = "0x70D1EF0", VA = "0x1870D36F0")]
		public OFRYBPDMWCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x70D2D80", Offset = "0x70D1580", VA = "0x1870D2D80")]
		public static OFRYBPDMWCH Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x70D3290", Offset = "0x70D1A90", VA = "0x1870D3290", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
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
	public class HMCQBNAUHVJ : HFPGWNSLYPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class KITBCUMOFKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public WTVTOFLEGQC OQYAWLRTKSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader POKMFUTOKNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<XABKJXLEVAH> VRMPKGMRFAW;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public KITBCUMOFKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x70D1BE0", Offset = "0x70D03E0", VA = "0x1870D1BE0")]
			internal XABKJXLEVAH WEJZBBRRCBI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<XABKJXLEVAH> LJNPRVWIJSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> LWNBWRIRQPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> OLIOLAMDZFU;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x70C8B70", Offset = "0x70C7370", VA = "0x1870C8B70")]
		public HMCQBNAUHVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x70CF4D0", Offset = "0x70CDCD0", VA = "0x1870CF4D0")]
		public static HMCQBNAUHVJ Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x70CF890", Offset = "0x70CE090", VA = "0x1870CF890", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class CKARNJIAQHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, VSCXGXQDKGW> YNXNCQZEWQS;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static NWFRFHMVRQF TEMAKWMPXFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, RCVNBXYDJZR> SMHHCVOUHCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken FKQVHRIUKWQ;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x70CA9B0", Offset = "0x70C91B0", VA = "0x1870CA9B0")]
		public static VSCXGXQDKGW CEQDQMUMZQJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x70CB230", Offset = "0x70C9A30", VA = "0x1870CB230")]
		public static RCVNBXYDJZR THQAOWFVIAF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public CKARNJIAQHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x70CC320", Offset = "0x70CAB20", VA = "0x1870CC320")]
		public CKARNJIAQHV(CKARNJIAQHV a, [Optional] WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x70CAB40", Offset = "0x70C9340", VA = "0x1870CAB40")]
		public void DZIBRYOGCXI(WTVTOFLEGQC a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x70CB320", Offset = "0x70C9B20", VA = "0x1870CB320")]
		public void VCBEHYYXWRV(string a, RCVNBXYDJZR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x70CA8C0", Offset = "0x70C90C0", VA = "0x1870CA8C0")]
		private void BBRJBZSTQAB(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x70CB470", Offset = "0x70C9C70", VA = "0x1870CB470")]
		private void YEEWOPQMUAP(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x70CADF0", Offset = "0x70C95F0", VA = "0x1870CADF0")]
		private void FXMHBBLBDJX(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x70CB530", Offset = "0x70C9D30", VA = "0x1870CB530")]
		internal static Dictionary<string, RCVNBXYDJZR> ZQDUEYZAKGQ(WTVTOFLEGQC a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x70CAEB0", Offset = "0x70C96B0", VA = "0x1870CAEB0", Slot = "4")]
		public virtual void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class WTVTOFLEGQC : CKARNJIAQHV
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class PDQLYVSWNTX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public WTVTOFLEGQC OQYAWLRTKSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader QEHVIILMBFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<XWLGDPDBHBS> VRMPKGMRFAW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<ZCPNPFGNFZG> VRRWHNGOOMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<BBDSDFOIDBC> VRCBPSYWMEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<TJHKYMCWPRO> VRHIMZSTVPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<PJNTLMSRGVL> VQRNVFLBTHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<NNQENYBDRHR> VQWUSMEZCSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<OFRYBPDMWCH> VQHAARXHAKU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<HMCQBNAUHVJ> VQMGXYREJWD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<BERLEXGGYBZ> VTCSOIPWCNQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> VTHZLPJTLYZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<FHGUWOJFITY> TSXUNNPOWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<XLGFUPUXDAO> TSSNQGVRNOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<RAWOIEBXRSB> TTIIIBDJPWF;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public PDQLYVSWNTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x70D3960", Offset = "0x70D2160", VA = "0x1870D3960")]
			internal XWLGDPDBHBS WEJZBBRRCBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x70D3970", Offset = "0x70D2170", VA = "0x1870D3970")]
			internal ZCPNPFGNFZG WEPFYILOLMR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x70D3940", Offset = "0x70D2140", VA = "0x1870D3940")]
			internal BBDSDFOIDBC WDZLGODWJEQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x70D3950", Offset = "0x70D2150", VA = "0x1870D3950")]
			internal TJHKYMCWPRO WEESDUXTSPZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x70D3920", Offset = "0x70D2120", VA = "0x1870D3920")]
			internal PJNTLMSRGVL WDOXMAQBQHY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x70D3930", Offset = "0x70D2130", VA = "0x1870D3930")]
			internal NNQENYBDRHR WDUEJHJYZTH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x70D3900", Offset = "0x70D2100", VA = "0x1870D3900")]
			internal OFRYBPDMWCH WDEJRNCGXLG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x70D3910", Offset = "0x70D2110", VA = "0x1870D3910")]
			internal HMCQBNAUHVJ WDJQOTWEGWP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x70D3980", Offset = "0x70D2180", VA = "0x1870D3980")]
			internal BERLEXGGYBZ WGACFDUVZOC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x70D3990", Offset = "0x70D2190", VA = "0x1870D3990")]
			internal Sampler WGFJCKOTIZL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x70D3770", Offset = "0x70D1F70", VA = "0x1870D3770")]
			internal FHGUWOJFITY PGKPQJQWYUH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x70D3760", Offset = "0x70D1F60", VA = "0x1870D3760")]
			internal XLGFUPUXDAO PGFITCWZPIY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x70D38F0", Offset = "0x70D20F0", VA = "0x1870D38F0")]
			internal RAWOIEBXRSB PGVDKXERRQZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> DJLXAZPZHPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> OCRKTCWKXJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<XWLGDPDBHBS> TJPNRDNBVJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<ZCPNPFGNFZG> TIFFEQERPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public JPKUYULHDWV JPKUYULHDWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<BBDSDFOIDBC> BAQTJTHQDQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<TJHKYMCWPRO> QXCXSTFEAAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<PJNTLMSRGVL> ZTGENRNXQSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<NNQENYBDRHR> KCRQZHWTMZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<OFRYBPDMWCH> LCIPWPXQTOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<HMCQBNAUHVJ> OVPIOUMUXAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<BERLEXGGYBZ> NCMPODZQHQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> EKXUXTNWQZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public DAWXZYRRAUE FPNDOERVAQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<FHGUWOJFITY> WUTSDPUJQTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<XLGFUPUXDAO> QYOWTHXDQGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<RAWOIEBXRSB> NLYLLOQQUJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<WGTBIMSOTQG> HZOTJZKBPVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool GJWRJOPXXPI;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x70D9840", Offset = "0x70D8040", VA = "0x1870D9840")]
		public WTVTOFLEGQC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x70D97A0", Offset = "0x70D7FA0", VA = "0x1870D97A0")]
		public FHGUWOJFITY MZPHVRNIGUG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x70D6DB0", Offset = "0x70D55B0", VA = "0x1870D6DB0")]
		public static WTVTOFLEGQC Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x70D7C00", Offset = "0x70D6400", VA = "0x1870D7C00")]
		public void JVPEYACKYLR(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class FHGUWOJFITY : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<YQPLXVVAQMG> NCMPODZQHQE;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x70C8B70", Offset = "0x70C7370", VA = "0x1870C8B70")]
		public FHGUWOJFITY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x70CDF20", Offset = "0x70CC720", VA = "0x1870CDF20")]
		public static FHGUWOJFITY Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x70CE0A0", Offset = "0x70CC8A0", VA = "0x1870CE0A0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class RAWOIEBXRSB : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public CLUJQPIEVOU LTVNKOBTVMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NTSIBZNILIJ QJCJQZPQAVU;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x70C8B70", Offset = "0x70C7370", VA = "0x1870C8B70")]
		public RAWOIEBXRSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x70D3DE0", Offset = "0x70D25E0", VA = "0x1870D3DE0")]
		public static RAWOIEBXRSB Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x70D3FB0", Offset = "0x70D27B0", VA = "0x1870D3FB0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class WBLFFZFWJGC : WGTBIMSOTQG
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x70C8B70", Offset = "0x70C7370", VA = "0x1870C8B70")]
		public WBLFFZFWJGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x70D6830", Offset = "0x70D5030", VA = "0x1870D6830", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class WGTBIMSOTQG : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string PLLGHUJCWXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color QUVGLXTQQBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string PUQVJDXVEJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float OZINGJZNDBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float WUERTKWCAJO;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x70C8B70", Offset = "0x70C7370", VA = "0x1870C8B70")]
		public WGTBIMSOTQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x70D68E0", Offset = "0x70D50E0", VA = "0x1870D68E0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class XBKEZTJIOZS : WGTBIMSOTQG
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x70C8B70", Offset = "0x70C7370", VA = "0x1870C8B70")]
		public XBKEZTJIOZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x70D6830", Offset = "0x70D5030", VA = "0x1870D6830", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class KDRACVVUETU : WGTBIMSOTQG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float LNVRDIYIZVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float GGJYWGCDJBK;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x70D1B90", Offset = "0x70D0390", VA = "0x1870D1B90")]
		public KDRACVVUETU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x70D1890", Offset = "0x70D0090", VA = "0x1870D1890", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface PQVZAMBMGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NLMJFGQKUKW(WTVTOFLEGQC a, LOINOQVCLTV b, [Out] WCSOTBUVZFK c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface RCVNBXYDJZR
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RCVNBXYDJZR Clone(WTVTOFLEGQC root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class VSCXGXQDKGW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string IBOKXSJRGOT;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		protected VSCXGXQDKGW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class HPHVODZZMGF : RCVNBXYDJZR
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty OCDZUKXDEOY
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x70D0020", Offset = "0x70CE820", VA = "0x1870D0020", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public HPHVODZZMGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class NWFRFHMVRQF : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x70D2D10", Offset = "0x70D1510", VA = "0x1870D2D10", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public NWFRFHMVRQF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class CTRATNJFWMP : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color TQPVNSBBBBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public USWQQWDREUK GTCJONQEPKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color INBUPDKZCJY;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x70CD150", Offset = "0x70CB950", VA = "0x1870CD150")]
		public CTRATNJFWMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x70CCC50", Offset = "0x70CB450", VA = "0x1870CCC50")]
		public static CTRATNJFWMP Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x70CCEF0", Offset = "0x70CB6F0", VA = "0x1870CCEF0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class KPEFKKJMQLF : USWQQWDREUK
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string VLEMHPOHMML = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double BDFPJJLKDEX;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x70CDD20", Offset = "0x70CC520", VA = "0x1870CDD20")]
		public KPEFKKJMQLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x70D2110", Offset = "0x70D0910", VA = "0x1870D2110")]
		public new static KPEFKKJMQLF Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x70D2400", Offset = "0x70D0C00", VA = "0x1870D2400", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class DKWTFROCKWH : USWQQWDREUK
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string KVIFJPFQJOW = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double GNGHIRCOPUC;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x70CDD20", Offset = "0x70CC520", VA = "0x1870CDD20")]
		public DKWTFROCKWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x70CD970", Offset = "0x70CC170", VA = "0x1870CD970")]
		public new static DKWTFROCKWH Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x70CDC60", Offset = "0x70CC460", VA = "0x1870CDC60", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class FWINARFTNES : CKARNJIAQHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color RNOGLQKPKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public USWQQWDREUK ZJNYPCYNDRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double JAGFIGDMXAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double XLRLEPGUVIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public USWQQWDREUK BFEIEVXINDZ;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x70CEB80", Offset = "0x70CD380", VA = "0x1870CEB80")]
		public FWINARFTNES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x70CE580", Offset = "0x70CCD80", VA = "0x1870CE580")]
		public static FWINARFTNES Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x70CE8F0", Offset = "0x70CD0F0", VA = "0x1870CE8F0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class XABKJXLEVAH : CKARNJIAQHV
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class WKDHTAWVSFY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader POKMFUTOKNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public WTVTOFLEGQC OQYAWLRTKSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<ANNHZWNIYUF> VRMPKGMRFAW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<ANNHZWNIYUF> VRCBPSYWMEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, ANNHZWNIYUF>> VRRWHNGOOMF;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public WKDHTAWVSFY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x70D6C30", Offset = "0x70D5430", VA = "0x1870D6C30")]
			internal ANNHZWNIYUF WEJZBBRRCBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x70D6D00", Offset = "0x70D5500", VA = "0x1870D6D00")]
			internal Dictionary<string, ANNHZWNIYUF> WEPFYILOLMR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x70D6B60", Offset = "0x70D5360", VA = "0x1870D6B60")]
			internal ANNHZWNIYUF WDZLGODWJEQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, ANNHZWNIYUF> HBWHKAHLKTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public ANNHZWNIYUF KQGGERXYISM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public HOWNCWMIGVN AZNSACCNCRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode FZFJHADPKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, ANNHZWNIYUF>> NDZKUQJMMTR;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x70DB220", Offset = "0x70D9A20", VA = "0x1870DB220")]
		public XABKJXLEVAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x70DAB80", Offset = "0x70D9380", VA = "0x1870DAB80")]
		public XABKJXLEVAH(XABKJXLEVAH a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x70DAAE0", Offset = "0x70D92E0", VA = "0x1870DAAE0")]
		public static int[] WVDHWSKKNYN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x70DA980", Offset = "0x70D9180", VA = "0x1870DA980")]
		public static int[] TTNWZWWZJTN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x70D9890", Offset = "0x70D8090", VA = "0x1870D9890")]
		public static int[] AUVNZHGPOKB(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x70D9F10", Offset = "0x70D8710", VA = "0x1870D9F10")]
		public static int[] ESOAEDBLHEX(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x70DA150", Offset = "0x70D8950", VA = "0x1870DA150")]
		public static int[] HYQFROZTQPM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x70DA7F0", Offset = "0x70D8FF0", VA = "0x1870DA7F0")]
		public static int[] LQNZIAYCFEH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x70DA8F0", Offset = "0x70D90F0", VA = "0x1870DA8F0")]
		public static int[] TBLZQIVFHBJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x70D9A50", Offset = "0x70D8250", VA = "0x1870D9A50")]
		public static int[] BZGROGRKMSE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x70DA860", Offset = "0x70D9060", VA = "0x1870DA860")]
		public static int[] PTQLAHNJWUM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x70D9AC0", Offset = "0x70D82C0", VA = "0x1870D9AC0")]
		public static XABKJXLEVAH Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x70DA200", Offset = "0x70D8A00", VA = "0x1870DA200", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class NBOJUSYUWJY
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] VXGZDYOJIOF;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] CWTSHUVBTEG;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] WBYRYOMEFUT;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] RBAYUQYANRX;
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
	public class BERLEXGGYBZ : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool WNCVVQMZBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public CAHKCJZXWON PEXYIXMHTZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<YQPLXVVAQMG> BZMLJUYVXTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public ZBLVNRGSJCX XLGFUPUXDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public GJOSHKOMLSK INCBTZHUHNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public JDSRIUAAMBB FVOMDDIMNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion UWXJAJSPRJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 BDFPJJLKDEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 MHXTLMOCDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> LWNBWRIRQPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public RAICXMWOJTG PUZVIUSYZHD;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x70CA0E0", Offset = "0x70C88E0", VA = "0x1870CA0E0")]
		public BERLEXGGYBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x70C8BC0", Offset = "0x70C73C0", VA = "0x1870C8BC0")]
		public static BERLEXGGYBZ Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x70C94F0", Offset = "0x70C7CF0", VA = "0x1870C94F0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode YIENRBEXEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode EVSIHFHVWMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode PYEDUYPWIYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode PZPABTZDWZL;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x70D58A0", Offset = "0x70D40A0", VA = "0x1870D58A0")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x70D53E0", Offset = "0x70D3BE0", VA = "0x1870D53E0")]
		public static Sampler Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x70D56B0", Offset = "0x70D3EB0", VA = "0x1870D56B0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
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
	public class XLGFUPUXDAO : HFPGWNSLYPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public ANNHZWNIYUF OYVDLNRGLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public YQPLXVVAQMG DKQHTEFTGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<YQPLXVVAQMG> URYKBCOLWJI;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x70DC400", Offset = "0x70DAC00", VA = "0x1870DC400")]
		public XLGFUPUXDAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x70DBD90", Offset = "0x70DA590", VA = "0x1870DBD90")]
		public static XLGFUPUXDAO Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x70DC0F0", Offset = "0x70DA8F0", VA = "0x1870DC0F0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class USWQQWDREUK : CKARNJIAQHV
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string LWYYUJEWECV = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string UQKVEJAOGJH = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public CUEDZTDBNVB NMPLFXDGBRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int VXGZDYOJIOF;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x70D6690", Offset = "0x70D4E90", VA = "0x1870D6690")]
		public USWQQWDREUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x70D66E0", Offset = "0x70D4EE0", VA = "0x1870D66E0")]
		public USWQQWDREUK(USWQQWDREUK a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x70D62E0", Offset = "0x70D4AE0", VA = "0x1870D62E0")]
		public static USWQQWDREUK Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x70D6630", Offset = "0x70D4E30", VA = "0x1870D6630", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x70D6560", Offset = "0x70D4D60", VA = "0x1870D6560")]
		public void JOWAYVDJKAW(JsonWriter a)
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
	public class KLWDLWUFTGL
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double MKUSZLZIBUP;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double NCTKNPUDWRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double ECOBVQJIRSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double ZJQGJLFIXTG;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x70D2090", Offset = "0x70D0890", VA = "0x1870D2090")]
		public KLWDLWUFTGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x70D1BF0", Offset = "0x70D03F0", VA = "0x1870D1BF0")]
		public static KLWDLWUFTGL Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x70D1E30", Offset = "0x70D0630", VA = "0x1870D1E30")]
		public void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class XBVKPANKNTB : HFPGWNSLYPC
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color GNIPHGWGXYE;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double IAKLBQOAQPI;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double KPKYHSAZJWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType BFJYMHQJKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color CWTSHUVBTEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double EMFLHOXHDEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double RRIYTCZYDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public KLWDLWUFTGL KLWDLWUFTGL;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x70DBCD0", Offset = "0x70DA4D0", VA = "0x1870DBCD0")]
		public XBVKPANKNTB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x70DBBB0", Offset = "0x70DA3B0", VA = "0x1870DBBB0")]
		public XBVKPANKNTB(XBVKPANKNTB a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x70DB3E0", Offset = "0x70D9BE0", VA = "0x1870DB3E0")]
		public static XBVKPANKNTB Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x70DB2C0", Offset = "0x70D9AC0", VA = "0x1870DB2C0")]
		public static XBVKPANKNTB Deserialize(WTVTOFLEGQC root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x70DB7D0", Offset = "0x70D9FD0", VA = "0x1870DB7D0", Slot = "4")]
		public override void JVPEYACKYLR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class YRBLNUHACVL : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<WGTBIMSOTQG> YWXOWZGGVXQ;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public YRBLNUHACVL(IList<WGTBIMSOTQG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x70DCCF0", Offset = "0x70DB4F0", VA = "0x1870DCCF0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x70DCC80", Offset = "0x70DB480", VA = "0x1870DCC80", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class RZZVEXPXDIJ : RCVNBXYDJZR, PQVZAMBMGMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<XBVKPANKNTB> HZOTJZKBPVE;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x70D5360", Offset = "0x70D3B60", VA = "0x1870D5360")]
		public RZZVEXPXDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x70D4950", Offset = "0x70D3150", VA = "0x1870D4950", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x70D5270", Offset = "0x70D3A70", VA = "0x1870D5270", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x70D4BD0", Offset = "0x70D33D0", VA = "0x1870D4BD0")]
		private static string[] GHZYGTDFOCR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x70D44F0", Offset = "0x70D2CF0", VA = "0x1870D44F0")]
		private static WCSOTBUVZFK.ImportValuesConversion AKJBZEHFVTT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x70D4E80", Offset = "0x70D3680", VA = "0x1870D4E80", Slot = "6")]
		public bool NLMJFGQKUKW(WTVTOFLEGQC a, LOINOQVCLTV b, [Out] WCSOTBUVZFK c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class FKZOWAHGAGS : GNNRONQTKJO<XBVKPANKNTB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override XBVKPANKNTB Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x70CE430", Offset = "0x70CCC30", VA = "0x1870CE430", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x70CE3F0", Offset = "0x70CCBF0", VA = "0x1870CE3F0")]
		public FKZOWAHGAGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x70CE310", Offset = "0x70CCB10", VA = "0x1870CE310")]
		public static FKZOWAHGAGS Deserialize(WTVTOFLEGQC root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class GJVIHVQJRLH : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public FKZOWAHGAGS RAICXMWOJTG;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public GJVIHVQJRLH(FKZOWAHGAGS a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x70CF1E0", Offset = "0x70CD9E0", VA = "0x1870CF1E0")]
		public GJVIHVQJRLH(int a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x70CF060", Offset = "0x70CD860", VA = "0x1870CF060", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x70CF0E0", Offset = "0x70CD8E0", VA = "0x1870CF0E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class BTEURAZEXOU : VSCXGXQDKGW
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x70CA6F0", Offset = "0x70C8EF0", VA = "0x1870CA6F0")]
		public BTEURAZEXOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x70CA210", Offset = "0x70C8A10", VA = "0x1870CA210", Slot = "4")]
		public override RCVNBXYDJZR Deserialize(WTVTOFLEGQC root, JProperty extensionToken)
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
