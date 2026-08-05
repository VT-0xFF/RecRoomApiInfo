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
	public class KHR_animation_pointer : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object EJIJNDDSXFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string DHJJRBHSVQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string JCDBSKRWXIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public ZTREVSYUBDC MLBLGVTTKZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer RFGILQFUAHJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7319760", Offset = "0x7317D60", VA = "0x187319760", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x73196B0", Offset = "0x7317CB0", VA = "0x1873196B0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class GZAVKIXPXPL
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 UTYKKIDFSVQ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 YSSJGRYTJMB;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion LRRFBAAOYZT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool IFOSOBJDGWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x73140F0", Offset = "0x73126F0", VA = "0x1873140F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7312080", Offset = "0x7310680", VA = "0x187312080")]
		public static void FWOMVOKXYTD(this QPBKESVYPXS a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7313770", Offset = "0x7311D70", VA = "0x187313770")]
		public static void PTWLINCVLLB(this QPBKESVYPXS a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73141B0", Offset = "0x73127B0", VA = "0x1873141B0")]
		public static void XCYBUXUCKCK(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7312FB0", Offset = "0x73115B0", VA = "0x187312FB0")]
		public static GLTF.Math.Vector4 MEOFKKXWPVI(this YKOKDFUYNEH a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7314A30", Offset = "0x7313030", VA = "0x187314A30")]
		public static UnityEngine.Quaternion YMLOSCIMJTL(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7314900", Offset = "0x7312F00", VA = "0x187314900")]
		public static UnityEngine.Quaternion YMLOSCIMJTL(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7313FB0", Offset = "0x73125B0", VA = "0x187313FB0")]
		public static GLTF.Math.Quaternion VGGRRZULJLB(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7314BB0", Offset = "0x73131B0", VA = "0x187314BB0")]
		public static Matrix4x4 ZGYIHABUFAY(this YKOKDFUYNEH a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7314DD0", Offset = "0x73133D0", VA = "0x187314DD0")]
		public static Matrix4x4 ZGYIHABUFAY(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7313C70", Offset = "0x7312270", VA = "0x187313C70")]
		public static YKOKDFUYNEH SWYDYZVNAUS(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x73152E0", Offset = "0x73138E0", VA = "0x1873152E0")]
		public static UnityEngine.Vector3 ZKTBIPSNJMV(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7315210", Offset = "0x7313810", VA = "0x187315210")]
		public static UnityEngine.Vector3 ZKTBIPSNJMV(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7311E20", Offset = "0x7310420", VA = "0x187311E20")]
		public static GLTF.Math.Vector3 CNGEPPCLDFZ(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7312620", Offset = "0x7310C20", VA = "0x187312620")]
		public static GLTF.Math.Vector3 GFVDCMBHMUW(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x13CDE70", Offset = "0x13CC470", VA = "0x1813CDE70")]
		public static GLTF.Math.Vector4 XBQZOKEELFT(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x73128F0", Offset = "0x7310EF0", VA = "0x1873128F0")]
		public static Matrix4x4 KQXQSNVIXJP(this YKOKDFUYNEH a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7312BB0", Offset = "0x73111B0", VA = "0x187312BB0")]
		public static Matrix4x4 KQXQSNVIXJP(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x73131D0", Offset = "0x73117D0", VA = "0x1873131D0")]
		public static YKOKDFUYNEH MMOIEAUYVGX(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7311D30", Offset = "0x7310330", VA = "0x187311D30")]
		public static UnityEngine.Vector2 BSDKZTCMRIV(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7311D30", Offset = "0x7310330", VA = "0x187311D30")]
		public static UnityEngine.Vector2 BSDKZTCMRIV(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7311D50", Offset = "0x7310350", VA = "0x187311D50")]
		public static void BSDKZTCMRIV(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7313490", Offset = "0x7311A90", VA = "0x187313490")]
		public static UnityEngine.Vector3 NGLOZZKHSYU(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D7CF60", Offset = "0x1D7B560", VA = "0x181D7CF60")]
		public static UnityEngine.Vector3 NGLOZZKHSYU(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x73133A0", Offset = "0x73119A0", VA = "0x1873133A0")]
		public static void NGLOZZKHSYU(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x13CDE70", Offset = "0x13CC470", VA = "0x1813CDE70")]
		public static UnityEngine.Vector4 KHFXKPDKMTN(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x13CDE70", Offset = "0x13CC470", VA = "0x1813CDE70")]
		public static UnityEngine.Vector4 KHFXKPDKMTN(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x73127F0", Offset = "0x7310DF0", VA = "0x1873127F0")]
		public static UnityEngine.Vector4[] KHFXKPDKMTN(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x73126E0", Offset = "0x7310CE0", VA = "0x1873126E0")]
		public static void KHFXKPDKMTN(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7314720", Offset = "0x7312D20", VA = "0x187314720")]
		public static UnityEngine.Color XZPDIOQVMXH(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x73147C0", Offset = "0x7312DC0", VA = "0x1873147C0")]
		public static void XZPDIOQVMXH(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7314720", Offset = "0x7312D20", VA = "0x187314720")]
		public static UnityEngine.Color XZPDIOQVMXH(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x13CDE70", Offset = "0x13CC470", VA = "0x1813CDE70")]
		public static UnityEngine.Color AFOKOJPLYSQ(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7311BB0", Offset = "0x73101B0", VA = "0x187311BB0")]
		public static void AFOKOJPLYSQ(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x13CDE70", Offset = "0x13CC470", VA = "0x1813CDE70")]
		public static UnityEngine.Color AFOKOJPLYSQ(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7312E20", Offset = "0x7311420", VA = "0x187312E20")]
		public static GLTF.Math.Color KVQZCPTNEZE(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7312660", Offset = "0x7310C60", VA = "0x187312660")]
		public static GLTF.Math.Color IAYOJFZRZKZ(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7311F50", Offset = "0x7310550", VA = "0x187311F50")]
		public static GLTF.Math.Color EYEXZHNNQZP(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7313650", Offset = "0x7311C50", VA = "0x187313650")]
		public static UnityEngine.Color[] PJOHEKTWFUY(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7315400", Offset = "0x7313A00", VA = "0x187315400")]
		public static int[] ZYOJDIWRKGX(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7311FD0", Offset = "0x73105D0", VA = "0x187311FD0")]
		public static UnityEngine.Vector2[] FRKDMGRHSSI(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7312E50", Offset = "0x7311450", VA = "0x187312E50")]
		public static void LYPBXEKVOKD(UZAMOXUXDLF a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x73134F0", Offset = "0x7311AF0", VA = "0x1873134F0")]
		public static UnityEngine.Vector3[] NTDYJBFWCKB(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7314580", Offset = "0x7312B80", VA = "0x187314580")]
		public static UnityEngine.Vector4[] XEHGZBKPXSU(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7311CC0", Offset = "0x73102C0", VA = "0x187311CC0")]
		public static void ARGOCCKHRLF(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7314180", Offset = "0x7312780", VA = "0x187314180")]
		public static UnityEngine.Quaternion WBJEBQAWIKT(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class UZAMOXUXDLF
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BGOSXQNMGFA BGOSXQNMGFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray UNZFKNIUHTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7324EB0", Offset = "0x73234B0", VA = "0x187324EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> ZMUDHYPTQUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xF331E0", Offset = "0xF317E0", VA = "0x180F331E0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1022B90", Offset = "0x1021190", VA = "0x181022B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint YKTGULEOTLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAB0750", Offset = "0xAAED50", VA = "0x180AB0750")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAB0780", Offset = "0xAAED80", VA = "0x180AB0780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7324EC0", Offset = "0x73234C0", VA = "0x187324EC0")]
		public UZAMOXUXDLF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x73119C0", Offset = "0x730FFC0", VA = "0x1873119C0")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7311A20", Offset = "0x7310020", VA = "0x187311A20")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class FUMJBBWWTLE
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class LSBTVFIYVUR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> ZADQVPMFZLB;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public LSBTVFIYVUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x731CEC0", Offset = "0x731B4C0", VA = "0x18731CEC0")]
			internal int? FXXSTAFJQKY(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x731CD60", Offset = "0x731B360", VA = "0x18731CD60")]
			internal int? AENBPAXJGZF(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x731CDF0", Offset = "0x731B3F0", VA = "0x18731CDF0")]
			internal bool DKVLBRHSNOH(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7310570", Offset = "0x730EB70", VA = "0x187310570")]
		private static void WGZOXRTAHAX(NumericArray a, UZAMOXUXDLF b, UZAMOXUXDLF c, UZAMOXUXDLF d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x730F1B0", Offset = "0x730D7B0", VA = "0x18730F1B0")]
		public static void TTFBVUNXQAE(Dictionary<string, UZAMOXUXDLF> a, Dictionary<string, (UZAMOXUXDLF sparseIndices, UZAMOXUXDLF sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7310AE0", Offset = "0x730F0E0", VA = "0x187310AE0")]
		public static void YVBPILKNGXC(Dictionary<string, UZAMOXUXDLF> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7310470", Offset = "0x730EA70", VA = "0x187310470")]
		public static void TYYQZQJSTZV(UZAMOXUXDLF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x730EC20", Offset = "0x730D220", VA = "0x18730EC20")]
		public static void ODJGPXKMFAP(Dictionary<string, List<UZAMOXUXDLF>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x730E660", Offset = "0x730CC60", VA = "0x18730E660")]
		private static void IOQSLMGPOUH(UZAMOXUXDLF a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x730E5A0", Offset = "0x730CBA0", VA = "0x18730E5A0")]
		internal static void IOQSLMGPOUH(VARYPRXVVUX a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x730E790", Offset = "0x730CD90", VA = "0x18730E790")]
		public static INANEINPBQN JRXSCKFSPLF(IEnumerable<INANEINPBQN> a)
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
			[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x303B5B0", Offset = "0x3039BB0", VA = "0x18303B5B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x303B5C0", Offset = "0x3039BC0", VA = "0x18303B5C0")]
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
	public class ATIKHTLKBIC
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint MOLNVRMMTCX;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint OSGWZSXBWAB;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint ZXKJZFTYQXH;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x730D2B0", Offset = "0x730B8B0", VA = "0x18730D2B0")]
		public static void XOKGVYNAHWN(Stream a, [Out] YBVGUQCSKJP b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x730CCC0", Offset = "0x730B2C0", VA = "0x18730CCC0")]
		public static ChunkInfo KBDWNVLMSQN(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x730CA10", Offset = "0x730B010", VA = "0x18730CA10")]
		public static GLBHeader BEOFWXIWMSX(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x730CF50", Offset = "0x730B550", VA = "0x18730CF50")]
		public static bool KYEQPBZUCKP(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x730CB50", Offset = "0x730B150", VA = "0x18730CB50")]
		public static ChunkInfo GHSVNMJNQOM(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x730D010", Offset = "0x730B610", VA = "0x18730D010")]
		private static void RUXNWQIBQCW(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x730C980", Offset = "0x730AF80", VA = "0x18730C980")]
		private static uint AKNFBOGIQWB(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IQCYHIFARIO
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
		public PathElement HVQIBTRZQBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int RQNIDISRYME
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xC071B0", Offset = "0xC057B0", VA = "0x180C071B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xC071A0", Offset = "0xC057A0", VA = "0x180C071A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string HCJWRGLUZSL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool WRTQCTYASCG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAB0F20", Offset = "0xAAF520", VA = "0x180AB0F20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAB0F00", Offset = "0xAAF500", VA = "0x180AB0F00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IQCYHIFARIO HWKUXDTODFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7315550", Offset = "0x7313B50", VA = "0x187315550")]
		public string OEUEBWIRXCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7315530", Offset = "0x7313B30", VA = "0x187315530")]
		public IQCYHIFARIO KYZNLFZWLTA(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x73157F0", Offset = "0x7313DF0", VA = "0x1873157F0")]
		private IQCYHIFARIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7315850", Offset = "0x7313E50", VA = "0x187315850")]
		public IQCYHIFARIO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x43046C0", Offset = "0x4302CC0", VA = "0x1843046C0")]
		[CompilerGenerated]
		internal static string BGTAVCYSYYW(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x73157B0", Offset = "0x7313DB0", VA = "0x1873157B0")]
		[CompilerGenerated]
		internal static bool ZDSYMEMDXVL([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x73155D0", Offset = "0x7313BD0", VA = "0x1873155D0")]
		[CompilerGenerated]
		internal static IQCYHIFARIO VYEWENGRCVB(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class SZIYHXNWWEX
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x73240B0", Offset = "0x73226B0", VA = "0x1873240B0")]
		public static int[] MMXRWTHVVBZ(this YBVGUQCSKJP a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7323F60", Offset = "0x7322560", VA = "0x187323F60")]
		public static int[] BUZTAFDWOPT(this YBVGUQCSKJP a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class IWVFQEBAFRN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x73164C0", Offset = "0x7314AC0", VA = "0x1873164C0")]
		public static uint PYLUFOBUYKU(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream HXSKKPBEMQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long CUBNGCEGECR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long FCRDTWOAPNM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7324800", Offset = "0x7322E00", VA = "0x187324800", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7324840", Offset = "0x7322E40", VA = "0x187324840", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7324840", Offset = "0x7322E40", VA = "0x187324840", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7324860", Offset = "0x7322E60", VA = "0x187324860", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7324880", Offset = "0x7322E80", VA = "0x187324880", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x73248A0", Offset = "0x7322EA0", VA = "0x1873248A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7324590", Offset = "0x7322B90", VA = "0x187324590")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7324350", Offset = "0x7322950", VA = "0x187324350", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7324420", Offset = "0x7322A20", VA = "0x187324420", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7324480", Offset = "0x7322A80", VA = "0x187324480", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7324390", Offset = "0x7322990", VA = "0x187324390", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7324550", Offset = "0x7322B50", VA = "0x187324550", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x73244C0", Offset = "0x7322AC0", VA = "0x1873244C0")]
		private void UBOWSHHXLCX()
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
		public static Color DSTZJTJDHNV
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x730DDB0", Offset = "0x730C3B0", VA = "0x18730DDB0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color KLCVAVSZZUB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x730DDA0", Offset = "0x730C3A0", VA = "0x18730DDA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color VSWKARAIACR
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x730DD80", Offset = "0x730C380", VA = "0x18730DD80")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2D563C0", Offset = "0x2D549C0", VA = "0x182D563C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2D563B0", Offset = "0x2D549B0", VA = "0x182D563B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2DB1B60", Offset = "0x2DB0160", VA = "0x182DB1B60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2DB1B70", Offset = "0x2DB0170", VA = "0x182DB1B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B307F0", Offset = "0x2B2EDF0", VA = "0x182B307F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x32312C0", Offset = "0x322F8C0", VA = "0x1832312C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x15666A0", Offset = "0x1564CA0", VA = "0x1815666A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15666B0", Offset = "0x1564CB0", VA = "0x1815666B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2E10", Offset = "0x2AF1410", VA = "0x182AF2E10")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x730DB80", Offset = "0x730C180", VA = "0x18730DB80", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x730DC30", Offset = "0x730C230", VA = "0x18730DC30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x730DCD0", Offset = "0x730C2D0", VA = "0x18730DCD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x730DDD0", Offset = "0x730C3D0", VA = "0x18730DDD0")]
		public static bool VSCIXNKBWNJ(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class YKOKDFUYNEH : IEquatable<YKOKDFUYNEH>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly YKOKDFUYNEH ILHYJJUUMFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] IKNVITSOPNM;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float GZFOMXGRYYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7326FD0", Offset = "0x73255D0", VA = "0x187326FD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7326D60", Offset = "0x7325360", VA = "0x187326D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float ZYDVTRKUQJI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7327120", Offset = "0x7325720", VA = "0x187327120")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7326F10", Offset = "0x7325510", VA = "0x187326F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float SXXEPMQMTNR
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x73268B0", Offset = "0x7324EB0", VA = "0x1873268B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7327000", Offset = "0x7325600", VA = "0x187327000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float LWVLWGUPKYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7326DC0", Offset = "0x73253C0", VA = "0x187326DC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x73271B0", Offset = "0x73257B0", VA = "0x1873271B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float GYPTVCYZWQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7326FA0", Offset = "0x73255A0", VA = "0x187326FA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7326D30", Offset = "0x7325330", VA = "0x187326D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float ZXYOWKQXGXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x73270C0", Offset = "0x73256C0", VA = "0x1873270C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7326EB0", Offset = "0x73254B0", VA = "0x187326EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float SYCLMTKKCZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7326910", Offset = "0x7324F10", VA = "0x187326910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7327060", Offset = "0x7325660", VA = "0x187327060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float LXLGOBCHNGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7326DF0", Offset = "0x73253F0", VA = "0x187326DF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x73271E0", Offset = "0x73257E0", VA = "0x1873271E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GYVASJSXGBR
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7326F70", Offset = "0x7325570", VA = "0x187326F70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7326D00", Offset = "0x7325300", VA = "0x187326D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float ZXTHZDWZXMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x73270F0", Offset = "0x73256F0", VA = "0x1873270F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7326EE0", Offset = "0x73254E0", VA = "0x187326EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float SYHSKAEHMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x73268E0", Offset = "0x7324EE0", VA = "0x1873268E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7327030", Offset = "0x7325630", VA = "0x187327030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float LXFZQUIKDVI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7326E20", Offset = "0x7325420", VA = "0x187326E20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7327210", Offset = "0x7325810", VA = "0x187327210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GZVJEROKBGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7326F40", Offset = "0x7325540", VA = "0x187326F40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7326D90", Offset = "0x7325390", VA = "0x187326D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float ZXOBBXDCOBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7327150", Offset = "0x7325750", VA = "0x187327150")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7326E80", Offset = "0x7325480", VA = "0x187326E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float SWWWDEUZYIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7326880", Offset = "0x7324E80", VA = "0x187326880")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7327090", Offset = "0x7325690", VA = "0x187327090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float LXVUIOQCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7326E50", Offset = "0x7325450", VA = "0x187326E50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7327180", Offset = "0x7325780", VA = "0x187327180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7327310", Offset = "0x7325910", VA = "0x187327310")]
		public YKOKDFUYNEH(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7326A40", Offset = "0x7325040", VA = "0x187326A40", Slot = "4")]
		public bool Equals(YKOKDFUYNEH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7326940", Offset = "0x7324F40", VA = "0x187326940", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x112C360", Offset = "0x112A960", VA = "0x18112C360", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D563C0", Offset = "0x2D549C0", VA = "0x182D563C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x2D563B0", Offset = "0x2D549B0", VA = "0x182D563B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2DB1B60", Offset = "0x2DB0160", VA = "0x182DB1B60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2DB1B70", Offset = "0x2DB0170", VA = "0x182DB1B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2B307F0", Offset = "0x2B2EDF0", VA = "0x182B307F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32312C0", Offset = "0x322F8C0", VA = "0x1832312C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x15666A0", Offset = "0x1564CA0", VA = "0x1815666A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x15666B0", Offset = "0x1564CB0", VA = "0x1815666B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7322E90", Offset = "0x7321490", VA = "0x187322E90")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7322B00", Offset = "0x7321100", VA = "0x187322B00", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7322C20", Offset = "0x7321220", VA = "0x187322C20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7322CD0", Offset = "0x73212D0", VA = "0x187322CD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7322DB0", Offset = "0x73213B0", VA = "0x187322DB0")]
		public static bool VSCIXNKBWNJ(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2D563C0", Offset = "0x2D549C0", VA = "0x182D563C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x2D563B0", Offset = "0x2D549B0", VA = "0x182D563B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2DB1B60", Offset = "0x2DB0160", VA = "0x182DB1B60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2DB1B70", Offset = "0x2DB0170", VA = "0x182DB1B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1099700", Offset = "0x1097D00", VA = "0x181099700")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x73250E0", Offset = "0x73236E0", VA = "0x1873250E0")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7324EF0", Offset = "0x73234F0", VA = "0x187324EF0", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7324F50", Offset = "0x7323550", VA = "0x187324F50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7325030", Offset = "0x7323630", VA = "0x187325030", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7325080", Offset = "0x7323680", VA = "0x187325080")]
		public static bool VSCIXNKBWNJ(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2D563C0", Offset = "0x2D549C0", VA = "0x182D563C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x2D563B0", Offset = "0x2D549B0", VA = "0x182D563B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2DB1B60", Offset = "0x2DB0160", VA = "0x182DB1B60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2DB1B70", Offset = "0x2DB0170", VA = "0x182DB1B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2B307F0", Offset = "0x2B2EDF0", VA = "0x182B307F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32312C0", Offset = "0x322F8C0", VA = "0x1832312C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7325490", Offset = "0x7323A90", VA = "0x187325490")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7325100", Offset = "0x7323700", VA = "0x187325100", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x73251E0", Offset = "0x73237E0", VA = "0x1873251E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x73252A0", Offset = "0x73238A0", VA = "0x1873252A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7325350", Offset = "0x7323950", VA = "0x187325350")]
		public static bool VSCIXNKBWNJ(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2D563C0", Offset = "0x2D549C0", VA = "0x182D563C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2D563B0", Offset = "0x2D549B0", VA = "0x182D563B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2DB1B60", Offset = "0x2DB0160", VA = "0x182DB1B60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2DB1B70", Offset = "0x2DB0170", VA = "0x182DB1B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2B307F0", Offset = "0x2B2EDF0", VA = "0x182B307F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x32312C0", Offset = "0x322F8C0", VA = "0x1832312C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x15666A0", Offset = "0x1564CA0", VA = "0x1815666A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x15666B0", Offset = "0x1564CB0", VA = "0x1815666B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2E10", Offset = "0x2AF1410", VA = "0x182AF2E10")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x730DB80", Offset = "0x730C180", VA = "0x18730DB80", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7325510", Offset = "0x7323B10", VA = "0x187325510", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x730DCD0", Offset = "0x730C2D0", VA = "0x18730DCD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class QEDQHGQYQQL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7322A80", Offset = "0x7321080", VA = "0x187322A80")]
		public static void BSVBHLABRPE(this JObject a, string b, SSGOAVDMOMX c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class IWVFQEBAFRN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7316920", Offset = "0x7314F20", VA = "0x187316920")]
		public static List<string> TTJGLJGRYIB(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7315B20", Offset = "0x7314120", VA = "0x187315B20")]
		public static List<double> AAITPKGCKBL(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7317190", Offset = "0x7315790", VA = "0x187317190")]
		public static List<int> XHTPDQYXVHW(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3942CA0", Offset = "0x39412A0", VA = "0x183942CA0")]
		public static List<a> UGGLXRCJNGM<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7315CE0", Offset = "0x73142E0", VA = "0x187315CE0")]
		public static SSGOAVDMOMX GRERYHOZTXQ(this JToken a, YBVGUQCSKJP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x73177C0", Offset = "0x7315DC0", VA = "0x1873177C0")]
		public static int ZXZCOTRDGGI(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7317050", Offset = "0x7315650", VA = "0x187317050")]
		public static double WMFAGEARXTE(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7316D70", Offset = "0x7315370", VA = "0x187316D70")]
		public static GLTF.Math.Color UXCIERGOUSJ(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7316250", Offset = "0x7314850", VA = "0x187316250")]
		public static GLTF.Math.Color IXXHRFIJKHE(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7316AD0", Offset = "0x73150D0", VA = "0x187316AD0")]
		public static GLTF.Math.Color TYOWPTOBAUO(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7315F90", Offset = "0x7314590", VA = "0x187315F90")]
		public static GLTF.Math.Vector3 IKAYWQKQAWM(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7317350", Offset = "0x7315950", VA = "0x187317350")]
		public static GLTF.Math.Vector2 XKBIWSDINSG(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7317560", Offset = "0x7315B60", VA = "0x187317560")]
		public static GLTF.Math.Vector3 XKGPTYXFXDP(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7316610", Offset = "0x7314C10", VA = "0x187316610")]
		public static GLTF.Math.Quaternion TOQYFBXQGPW(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3943340", Offset = "0x3941940", VA = "0x183943340")]
		public static Dictionary<string, b> ZIIYYHVLHKI<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3942FF0", Offset = "0x39415F0", VA = "0x183942FF0")]
		public static c VGUGVUKODKY<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public VARYPRXVVUX bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x730E190", Offset = "0x730C790", VA = "0x18730E190", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x730E110", Offset = "0x730C710", VA = "0x18730E110", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class JZAWFFHQHWK : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x73179D0", Offset = "0x7315FD0", VA = "0x1873179D0")]
		public JZAWFFHQHWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7317900", Offset = "0x7315F00", VA = "0x187317900", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, BGOSXQNMGFA> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x730DFD0", Offset = "0x730C5D0", VA = "0x18730DFD0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x730E090", Offset = "0x730C690", VA = "0x18730E090")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class UYJWAPJPKZO : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class AUWAEQXFGZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public YBVGUQCSKJP UPYDKJXZEYI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader BEMVXWUORAX;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public AUWAEQXFGZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x730D540", Offset = "0x730BB40", VA = "0x18730D540")]
			internal BGOSXQNMGFA SZECBCLDFJR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7324E60", Offset = "0x7323460", VA = "0x187324E60")]
		public UYJWAPJPKZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7324CD0", Offset = "0x73232D0", VA = "0x187324CD0", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NVYZNLYAPSA EEOYAONDPON;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public EXT_texture_exr(NVYZNLYAPSA source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x730E1E0", Offset = "0x730C7E0", VA = "0x18730E1E0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x730E250", Offset = "0x730C850", VA = "0x18730E250", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class RCSYDJVPXGB : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7323040", Offset = "0x7321640", VA = "0x187323040")]
		public RCSYDJVPXGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7322F20", Offset = "0x7321520", VA = "0x187322F20", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
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
	public class AudioEmitterId : LWYLCHRZUYX<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x730D8A0", Offset = "0x730BEA0", VA = "0x18730D8A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x730D860", Offset = "0x730BE60", VA = "0x18730D860")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : LWYLCHRZUYX<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x730DA30", Offset = "0x730C030", VA = "0x18730DA30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x730D9F0", Offset = "0x730BFF0", VA = "0x18730D9F0")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : LWYLCHRZUYX<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x730D710", Offset = "0x730BD10", VA = "0x18730D710", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x730D6D0", Offset = "0x730BCD0", VA = "0x18730D6D0")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x730D5F0", Offset = "0x730BBF0", VA = "0x18730D5F0")]
		public static AudioDataId Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x73193D0", Offset = "0x73179D0", VA = "0x1873193D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7318FD0", Offset = "0x73175D0", VA = "0x187318FD0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7319040", Offset = "0x7317640", VA = "0x187319040")]
		public static KHR_SceneAudioEmittersRef Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7319630", Offset = "0x7317C30", VA = "0x187319630")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7318FA0", Offset = "0x73175A0", VA = "0x187318FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7318E80", Offset = "0x7317480", VA = "0x187318E80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7318C70", Offset = "0x7317270", VA = "0x187318C70", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7318CE0", Offset = "0x73172E0", VA = "0x187318CE0")]
		public static KHR_NodeAudioEmitterRef Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class PNJPNYRQORK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string VAVLXPITWDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? JJCMFXPJVWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? UPXYBHRZHUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? QSBHNDHGDDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? IVBXFGAJZTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? NJNKVGLCDUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? KHFDDLQEOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? INVOZZATJOL;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7322810", Offset = "0x7320E10", VA = "0x187322810")]
		public JObject KYZOGDONURM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7322110", Offset = "0x7320710", VA = "0x187322110")]
		public static PNJPNYRQORK Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public PNJPNYRQORK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : JPKJFGPKRFH
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
		public PNJPNYRQORK positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x73182C0", Offset = "0x73168C0", VA = "0x1873182C0", Slot = "5")]
		public virtual JObject KYZOGDONURM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7317DC0", Offset = "0x73163C0", VA = "0x187317DC0")]
		public static KHR_AudioEmitter Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7318660", Offset = "0x7316C60", VA = "0x187318660")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : JPKJFGPKRFH
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
		[Cpp2IlInjected.Address(RVA = "0x7318A40", Offset = "0x7317040", VA = "0x187318A40")]
		public JObject KYZOGDONURM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x73186E0", Offset = "0x7316CE0", VA = "0x1873186E0")]
		public static KHR_AudioSource Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7317DB0", Offset = "0x73163B0", VA = "0x187317DB0")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : JPKJFGPKRFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public ZOZHHVTIIKS bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7317C80", Offset = "0x7316280", VA = "0x187317C80")]
		public JObject KYZOGDONURM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7317A20", Offset = "0x7316020", VA = "0x187317A20")]
		public static KHR_AudioData Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7317DB0", Offset = "0x73163B0", VA = "0x187317DB0")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : LEYHDTHFYUU
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
		[Cpp2IlInjected.Address(RVA = "0x73198F0", Offset = "0x7317EF0", VA = "0x1873198F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7319860", Offset = "0x7317E60", VA = "0x187319860", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x731A020", Offset = "0x7318620", VA = "0x18731A020")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class SLTYQYOCSSD : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7323C40", Offset = "0x7322240", VA = "0x187323C40")]
		public SLTYQYOCSSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7323090", Offset = "0x7321690", VA = "0x187323090", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public ZOZHHVTIIKS bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x731A1F0", Offset = "0x73187F0", VA = "0x18731A1F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x731A130", Offset = "0x7318730", VA = "0x18731A130", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x731A240", Offset = "0x7318840", VA = "0x18731A240")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class NOHCBNWAHXD : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class AUWAEQXFGZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader BEMVXWUORAX;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public AUWAEQXFGZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x730D4D0", Offset = "0x730BAD0", VA = "0x18730D4D0")]
			internal int SZECBCLDFJR()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x731D740", Offset = "0x731BD40", VA = "0x18731D740")]
		public NOHCBNWAHXD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x731D530", Offset = "0x731BB30", VA = "0x18731D530", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public SSGOAVDMOMX anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x731A340", Offset = "0x7318940", VA = "0x18731A340", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x731A2C0", Offset = "0x73188C0", VA = "0x18731A2C0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class WRFFSJOFCTU : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7325C90", Offset = "0x7324290", VA = "0x187325C90")]
		public WRFFSJOFCTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7325AE0", Offset = "0x73240E0", VA = "0x187325AE0", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public SSGOAVDMOMX clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public SSGOAVDMOMX clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public SSGOAVDMOMX clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x731A5F0", Offset = "0x7318BF0", VA = "0x18731A5F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x731A550", Offset = "0x7318B50", VA = "0x18731A550", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class SWMJOFMTWKC : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7323F10", Offset = "0x7322510", VA = "0x187323F10")]
		public SWMJOFMTWKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7323C90", Offset = "0x7322290", VA = "0x187323C90", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x731A950", Offset = "0x7318F50", VA = "0x18731A950", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x731A8E0", Offset = "0x7318EE0", VA = "0x18731A8E0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class UMGHIZFHBMQ : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7324C80", Offset = "0x7323280", VA = "0x187324C80")]
		public UMGHIZFHBMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7324BB0", Offset = "0x73231B0", VA = "0x187324BB0", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : XWGXOIOZRTK, LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float IKYKLOTLJMO;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x731AC30", Offset = "0x7319230", VA = "0x18731AC30")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x731AC80", Offset = "0x7319280", VA = "0x18731AC80")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, YBVGUQCSKJP root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x731AA70", Offset = "0x7319070", VA = "0x18731AA70", Slot = "6")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x731AB10", Offset = "0x7319110", VA = "0x18731AB10", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class XRVIGRPAJYV : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7326760", Offset = "0x7324D60", VA = "0x187326760")]
		public XRVIGRPAJYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7326660", Offset = "0x7324C60", VA = "0x187326660", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x731AD50", Offset = "0x7319350", VA = "0x18731AD50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x731ACF0", Offset = "0x73192F0", VA = "0x18731ACF0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x731AEA0", Offset = "0x73194A0", VA = "0x18731AEA0")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class IQSNNBKLGJE : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7315AD0", Offset = "0x73140D0", VA = "0x187315AD0")]
		public IQSNNBKLGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7315A00", Offset = "0x7314000", VA = "0x187315A00", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public SSGOAVDMOMX iridescenceTexture;

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
		public SSGOAVDMOMX iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x731AF50", Offset = "0x7319550", VA = "0x18731AF50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x731AEB0", Offset = "0x73194B0", VA = "0x18731AEB0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x731B310", Offset = "0x7319910", VA = "0x18731B310")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class WECPFROWEWU : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x73258A0", Offset = "0x7323EA0", VA = "0x1873258A0")]
		public WECPFROWEWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x73255B0", Offset = "0x7323BB0", VA = "0x1873255B0", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class GHSLEETSMXZ : LEYHDTHFYUU
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 QTBKDEFRJDT;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double MSRBYYMYNEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color OPKYUDYKCNX;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color UXMDXAVUATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public SSGOAVDMOMX NKQQJBIPBXH;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly SSGOAVDMOMX PWYMJDSFEVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 MFXMQHYZCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double YZEGIUBLLHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public SSGOAVDMOMX XBWFDNQNYZE;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly SSGOAVDMOMX RUXCAKZRUIG;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x73118D0", Offset = "0x730FED0", VA = "0x1873118D0")]
		public GHSLEETSMXZ(GLTF.Math.Color a, SSGOAVDMOMX b, GLTF.Math.Vector3 c, double d, SSGOAVDMOMX e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7310FC0", Offset = "0x730F5C0", VA = "0x187310FC0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7311170", Offset = "0x730F770", VA = "0x187311170", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class XFNMNMHFDIX : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7326350", Offset = "0x7324950", VA = "0x187326350")]
		public XFNMNMHFDIX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7326000", Offset = "0x7324600", VA = "0x187326000", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public SSGOAVDMOMX sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public SSGOAVDMOMX sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x731B400", Offset = "0x7319A00", VA = "0x18731B400", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x731B330", Offset = "0x7319930", VA = "0x18731B330", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x731B910", Offset = "0x7319F10", VA = "0x18731B910")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class MBIQGYBKKZX : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x731D330", Offset = "0x731B930", VA = "0x18731D330")]
		public MBIQGYBKKZX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x731D0D0", Offset = "0x731B6D0", VA = "0x18731D0D0", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public SSGOAVDMOMX specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public SSGOAVDMOMX specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x731BA40", Offset = "0x731A040", VA = "0x18731BA40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x731B970", Offset = "0x7319F70", VA = "0x18731B970", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x731BF50", Offset = "0x731A550", VA = "0x18731BF50")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class XQIKUVTERKP : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7326610", Offset = "0x7324C10", VA = "0x187326610")]
		public XQIKUVTERKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x73263A0", Offset = "0x73249A0", VA = "0x1873263A0", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public SSGOAVDMOMX transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x731C040", Offset = "0x731A640", VA = "0x18731C040", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x731BFC0", Offset = "0x731A5C0", VA = "0x18731BFC0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class LWBVTOBMXLY : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x731D080", Offset = "0x731B680", VA = "0x18731D080")]
		public LWBVTOBMXLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x731CF40", Offset = "0x731B540", VA = "0x18731CF40", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class ZKFXQYUSIUL : XWGXOIOZRTK, LEYHDTHFYUU
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7327F70", Offset = "0x7326570", VA = "0x187327F70")]
		public ZKFXQYUSIUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7327FC0", Offset = "0x73265C0", VA = "0x187327FC0")]
		public ZKFXQYUSIUL(ZKFXQYUSIUL a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7327D70", Offset = "0x7326370", VA = "0x187327D70", Slot = "6")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7327E10", Offset = "0x7326410", VA = "0x187327E10", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7327EA0", Offset = "0x73264A0", VA = "0x187327EA0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class XTUXPRVLEHB : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7326830", Offset = "0x7324E30", VA = "0x187326830")]
		public XTUXPRVLEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x73267B0", Offset = "0x7324DB0", VA = "0x1873267B0", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public SSGOAVDMOMX thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x731C260", Offset = "0x731A860", VA = "0x18731C260", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x731C1D0", Offset = "0x731A7D0", VA = "0x18731C1D0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x731C790", Offset = "0x731AD90", VA = "0x18731C790")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class TKFFMFPWKEE : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7324AF0", Offset = "0x73230F0", VA = "0x187324AF0")]
		public TKFFMFPWKEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x73248E0", Offset = "0x7322EE0", VA = "0x1873248E0", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x731C810", Offset = "0x731AE10", VA = "0x18731C810", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x731C7B0", Offset = "0x731ADB0", VA = "0x18731C7B0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x127D500", Offset = "0x127BB00", VA = "0x18127D500")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class FMXBIQLMYGQ : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x730E420", Offset = "0x730CA20", VA = "0x18730E420")]
		public FMXBIQLMYGQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x730E340", Offset = "0x730C940", VA = "0x18730E340", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x731C980", Offset = "0x731AF80", VA = "0x18731C980", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x731C920", Offset = "0x731AF20", VA = "0x18731C920", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x127D500", Offset = "0x127BB00", VA = "0x18127D500")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class FSDXSCJJGHW : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x730E550", Offset = "0x730CB50", VA = "0x18730E550")]
		public FSDXSCJJGHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x730E470", Offset = "0x730CA70", VA = "0x18730E470", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x731CAF0", Offset = "0x731B0F0", VA = "0x18731CAF0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x731CA90", Offset = "0x731B090", VA = "0x18731CA90", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x127D500", Offset = "0x127BB00", VA = "0x18127D500")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class GSVWXXGNIEI : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7311B60", Offset = "0x7310160", VA = "0x187311B60")]
		public GSVWXXGNIEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7311A80", Offset = "0x7310080", VA = "0x187311A80", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NVYZNLYAPSA source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public KHR_texture_basisu(NVYZNLYAPSA source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x731CC00", Offset = "0x731B200", VA = "0x18731CC00", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x731CC70", Offset = "0x731B270", VA = "0x18731CC70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class NHFRFRVWQXO : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x731D4E0", Offset = "0x731BAE0", VA = "0x18731D4E0")]
		public NHFRFRVWQXO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x731D380", Offset = "0x731B980", VA = "0x18731D380", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class YKTIIZGBCZZ : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 YKTGULEOTLB;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 FRYEPHTTGZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double VBLUIXJXMKS;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double IHNOTWSLBSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 ZZGGBTRPGMS;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 CTESCLVELUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? MJWETYALAFA;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int FYPBAVBGCTS;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7327CF0", Offset = "0x73262F0", VA = "0x187327CF0")]
		public YKTIIZGBCZZ(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x73275C0", Offset = "0x7325BC0", VA = "0x1873275C0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x73276A0", Offset = "0x7325CA0", VA = "0x1873276A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class XFKACWXEBFJ : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7325FB0", Offset = "0x73245B0", VA = "0x187325FB0")]
		public XFKACWXEBFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7325CE0", Offset = "0x73242E0", VA = "0x187325CE0", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class WEGURTSPULR : LEYHDTHFYUU
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> LGOWPZASCYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public WEGURTSPULR(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x73258F0", Offset = "0x7323EF0", VA = "0x1873258F0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7325960", Offset = "0x7323F60", VA = "0x187325960", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7325A50", Offset = "0x7324050", VA = "0x187325A50")]
		public List<double> UVPYRXRRAHH(QPBKESVYPXS a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class DYXSJXSSHCT : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x730DF80", Offset = "0x730C580", VA = "0x18730DF80")]
		public DYXSJXSSHCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x730DE80", Offset = "0x730C480", VA = "0x18730DE80", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class OERFMZANDAT : JPKJFGPKRFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public ZOZHHVTIIKS VARYPRXVVUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint SPDOLEFPHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType ZDOWMALPMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool YGHONFLPBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint MAXRYHRIEQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType BTZTINVWBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> SKHXVUNGCPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> QLTHRPZANNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public GLCKQYBTAIT GPSOAIZSBCQ;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7317DB0", Offset = "0x73163B0", VA = "0x187317DB0")]
		public OERFMZANDAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x731DD20", Offset = "0x731C320", VA = "0x18731DD20")]
		public static OERFMZANDAT Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x731EBC0", Offset = "0x731D1C0", VA = "0x18731EBC0", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x731E4B0", Offset = "0x731CAB0", VA = "0x18731E4B0")]
		private unsafe static sbyte UWZKYXEKEQW(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x731F200", Offset = "0x731D800", VA = "0x18731F200")]
		private unsafe static float2 LMYMMAAUUTO(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x73204C0", Offset = "0x731EAC0", VA = "0x1873204C0")]
		private unsafe static float3 UAKAFYJMYCV(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x731F1A0", Offset = "0x731D7A0", VA = "0x18731F1A0")]
		private unsafe static float4 LATPIYUWZOW(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x73208C0", Offset = "0x731EEC0", VA = "0x1873208C0")]
		private unsafe static float4x4 USSIFSKMWOG(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x731E4B0", Offset = "0x731CAB0", VA = "0x18731E4B0")]
		private unsafe static byte FVFWAGLBUNZ(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x731E510", Offset = "0x731CB10", VA = "0x18731E510")]
		private unsafe static float2 GQNUVOBMCGH(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x731DCD0", Offset = "0x731C2D0", VA = "0x18731DCD0")]
		private unsafe static float3 DWLLYLTVQHQ(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x731D8C0", Offset = "0x731BEC0", VA = "0x18731D8C0")]
		private unsafe static float4 BOSBVJKSPGZ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x731FD50", Offset = "0x731E350", VA = "0x18731FD50")]
		private unsafe static float4x4 OBWJYUHUXMR(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x731E650", Offset = "0x731CC50", VA = "0x18731E650")]
		private unsafe static short LQPNPOFVGYG(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7320490", Offset = "0x731EA90", VA = "0x187320490")]
		private unsafe static float2 TPSUCADAZQI(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x73202D0", Offset = "0x731E8D0", VA = "0x1873202D0")]
		private unsafe static float3 RXEHRPHJTQF(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x731EB60", Offset = "0x731D160", VA = "0x18731EB60")]
		private unsafe static float4 JXIHXGXSRWG(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7320100", Offset = "0x731E700", VA = "0x187320100")]
		private unsafe static float4x4 PRULBORCNHQ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x731E650", Offset = "0x731CC50", VA = "0x18731E650")]
		private unsafe static ushort HWCZAYMHHGF(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x731FD20", Offset = "0x731E320", VA = "0x18731FD20")]
		private unsafe static float2 NZVHNNRTMUV(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x731E4C0", Offset = "0x731CAC0", VA = "0x18731E4C0")]
		private unsafe static float3 FXABBVJKFLG(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x73219C0", Offset = "0x731FFC0", VA = "0x1873219C0")]
		private unsafe static float4x4 ZFOMALLTHLZ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7320CF0", Offset = "0x731F2F0", VA = "0x187320CF0")]
		private unsafe static float4 WOQJWGUCLNZ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x73219B0", Offset = "0x731FFB0", VA = "0x1873219B0")]
		private unsafe static uint YZDOZIDZZQI(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x731E650", Offset = "0x731CC50", VA = "0x18731E650")]
		private unsafe static ushort TJXLRKAAKYN(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x731FD10", Offset = "0x731E310", VA = "0x18731FD10")]
		private unsafe static float NNUDQLRURKG(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x731E180", Offset = "0x731C780", VA = "0x18731E180")]
		private unsafe static float2 ETSAVMQRWRK(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7320630", Offset = "0x731EC30", VA = "0x187320630")]
		private unsafe static float3 UQSYXFNKVJT(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x731D920", Offset = "0x731BF20", VA = "0x18731D920")]
		private unsafe static float4 YQHHVFHNXZQ(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x73202A0", Offset = "0x731E8A0", VA = "0x1873202A0")]
		private unsafe static float4x4 QVTJVNEMOKW(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x731D920", Offset = "0x731BF20", VA = "0x18731D920")]
		private unsafe static float4 BTTVICIKRUR(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x731D950", Offset = "0x731BF50", VA = "0x18731D950")]
		private unsafe static float4 BTTVICIKRUR(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7320D50", Offset = "0x731F350", VA = "0x187320D50")]
		public static float3[] XGTARRPQWNO(OERFMZANDAT a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x731E1A0", Offset = "0x731C7A0", VA = "0x18731E1A0")]
		public static float3[] EVTJUMRWDVC(OERFMZANDAT a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x731F810", Offset = "0x731DE10", VA = "0x18731F810")]
		public static uint[] MGLKXGEHMWB(OERFMZANDAT a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7320510", Offset = "0x731EB10", VA = "0x187320510")]
		internal static void ULGVBQOKIWO(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x731E910", Offset = "0x731CF10", VA = "0x18731E910")]
		public uint[] JERBDHPWSTP(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7321740", Offset = "0x731FD40", VA = "0x187321740")]
		public float[] YYRHEMKMLRN(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x731F230", Offset = "0x731D830", VA = "0x18731F230")]
		public float2[] MAHPAFSBSCZ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x731E660", Offset = "0x731CC60", VA = "0x18731E660")]
		public float2[] IXERSYWPEZJ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x731D980", Offset = "0x731BF80", VA = "0x18731D980")]
		public float3[] BWOSOLATPAU(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x731F4C0", Offset = "0x731DAC0", VA = "0x18731F4C0")]
		public float3[] MEMLEUDOWII(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7320650", Offset = "0x731EC50", VA = "0x187320650")]
		public float4[] USIYFGDBBXB(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x73213D0", Offset = "0x731F9D0", VA = "0x1873213D0")]
		public float4[] YRNVFNWIKTN(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x731F980", Offset = "0x731DF80", VA = "0x18731F980")]
		public float4[] MMPHANCCRWM(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x73212C0", Offset = "0x731F8C0", VA = "0x1873212C0")]
		public float3[] YJHSXBRHWRV(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x731E540", Offset = "0x731CB40", VA = "0x18731E540")]
		public float3[] HREKXZLETHO(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x731DC00", Offset = "0x731C200", VA = "0x18731DC00")]
		public float4[] CRKKLUCMFEO(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x731FEF0", Offset = "0x731E4F0", VA = "0x18731FEF0")]
		public uint[] OLQINUUHEAF(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7321B60", Offset = "0x7320160", VA = "0x187321B60")]
		public float4x4[] ZVCUEPGEKEI(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7321100", Offset = "0x731F700", VA = "0x187321100")]
		private unsafe static float4 YHUBGTOEUSS(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7320F80", Offset = "0x731F580", VA = "0x187320F80")]
		private unsafe static float4 YHUBGTOEUSS(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7320320", Offset = "0x731E920", VA = "0x187320320")]
		private unsafe static float4x4 SFSYFEQTFRN(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x731FF40", Offset = "0x731E540", VA = "0x18731FF40")]
		private unsafe static float4 PBAFDMPDKDR(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7320A60", Offset = "0x731F060", VA = "0x187320A60")]
		private unsafe static float3 WFOLUSUUEJG(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x731D790", Offset = "0x731BD90", VA = "0x18731D790")]
		private unsafe static float2 ADUEBHVBHYZ(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7320BD0", Offset = "0x731F1D0", VA = "0x187320BD0")]
		private unsafe static uint WISEKXCIIQE(void* a, uint b, GLTFComponentType c)
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
	public static class TWAGIMCUQLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7335DA0", Offset = "0x73343A0", VA = "0x187335DA0")]
		public static int FXYRWLTQGMO(this GLTFAccessorAttributeType a)
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
	public class GLCKQYBTAIT : XWGXOIOZRTK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int MAXRYHRIEQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public PYYXRODECEI DXXPMGDNOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public QZPWGMNNSXL LMDACHOVTPE;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x732B590", Offset = "0x7329B90", VA = "0x18732B590")]
		public GLCKQYBTAIT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x732B190", Offset = "0x7329790", VA = "0x18732B190")]
		public static GLCKQYBTAIT Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x732B460", Offset = "0x7329A60", VA = "0x18732B460", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class PYYXRODECEI : XWGXOIOZRTK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public ZOZHHVTIIKS VARYPRXVVUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int SPDOLEFPHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType ZDOWMALPMHB;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x732EBF0", Offset = "0x732D1F0", VA = "0x18732EBF0")]
		public PYYXRODECEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x732E7D0", Offset = "0x732CDD0", VA = "0x18732E7D0")]
		public static PYYXRODECEI Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x732EAB0", Offset = "0x732D0B0", VA = "0x18732EAB0", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class QZPWGMNNSXL : XWGXOIOZRTK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public ZOZHHVTIIKS VARYPRXVVUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int SPDOLEFPHIB;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7330790", Offset = "0x732ED90", VA = "0x187330790")]
		public QZPWGMNNSXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7330410", Offset = "0x732EA10", VA = "0x187330410")]
		public static QZPWGMNNSXL Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7330690", Offset = "0x732EC90", VA = "0x187330690", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class PJWNKQUOEGF : XWGXOIOZRTK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public XWTMDVLSJIL PKVHDFXMURO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public ZTREVSYUBDC HGXANSBOQFP;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x732E3A0", Offset = "0x732C9A0", VA = "0x18732E3A0")]
		public PJWNKQUOEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x732E0B0", Offset = "0x732C6B0", VA = "0x18732E0B0")]
		public static PJWNKQUOEGF Deserialize(YBVGUQCSKJP root, JsonReader reader, VJEIIZXANCJ anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x732E2A0", Offset = "0x732C8A0", VA = "0x18732E2A0", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class ZTREVSYUBDC : XWGXOIOZRTK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public INANEINPBQN QPBKESVYPXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string XJWRXVLQQQP;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x733DAA0", Offset = "0x733C0A0", VA = "0x18733DAA0")]
		public static ZTREVSYUBDC Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x733DE20", Offset = "0x733C420", VA = "0x18733DE20")]
		public ZTREVSYUBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x733DD00", Offset = "0x733C300", VA = "0x18733DD00", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
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
	public class XYFZUQCULVJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(XYFZUQCULVJ data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] LDOEJMEJIHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type MNTLMLGCFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] YYFCXKRZGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion CLUIFQNLXLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string KCDIXPAFVIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string BZXAOXRLBLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public UZAMOXUXDLF DVYIWTMLDUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string QZMVUQIBDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string REAUCBQRCRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public UZAMOXUXDLF OJMTSWAZKGO;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7339EE0", Offset = "0x73384E0", VA = "0x187339EE0")]
		public XYFZUQCULVJ()
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
	public class PWBLEBRREXU : XWGXOIOZRTK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public BGOSXQNMGFA JKKLHZGLZSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType TUCWHSFJPUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public BGOSXQNMGFA BEQTFVQCDMR;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x732E780", Offset = "0x732CD80", VA = "0x18732E780")]
		public PWBLEBRREXU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x732E3F0", Offset = "0x732C9F0", VA = "0x18732E3F0")]
		public static PWBLEBRREXU Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x732E610", Offset = "0x732CC10", VA = "0x18732E610", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class UTSUQOAALKY : XWGXOIOZRTK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string CNFSONMIPHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string HFFGQLYPMVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string QKLWEKEWKXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string KVJBWLZPZZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> NUAGJNTLKEE;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7336E00", Offset = "0x7335400", VA = "0x187336E00")]
		public UTSUQOAALKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7336310", Offset = "0x7334910", VA = "0x187336310")]
		public static UTSUQOAALKY Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7336630", Offset = "0x7334C30", VA = "0x187336630", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7336A50", Offset = "0x7335050", VA = "0x187336A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7336A60", Offset = "0x7335060", VA = "0x187336A60")]
		public string UIVTQJMHANS(bool a)
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
	public class VARYPRXVVUX : JPKJFGPKRFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public KFOQMVQOIBF GBWIURLYDVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint SPDOLEFPHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint UYPAAIMDXDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint WZKRROPQWFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget HGXANSBOQFP;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x73298C0", Offset = "0x7327EC0", VA = "0x1873298C0")]
		public VARYPRXVVUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7336EA0", Offset = "0x73354A0", VA = "0x187336EA0")]
		public static VARYPRXVVUX Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7337150", Offset = "0x7335750", VA = "0x187337150", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class OXNMEKGVQGB : XWGXOIOZRTK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double XMKBKDQXCVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double TPDLBAWMFGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double WLNSTSOPQED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double HKLRKRKFHSY;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x732E060", Offset = "0x732C660", VA = "0x18732E060")]
		public OXNMEKGVQGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x732DB70", Offset = "0x732C170", VA = "0x18732DB70")]
		public static OXNMEKGVQGB Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x732DEF0", Offset = "0x732C4F0", VA = "0x18732DEF0", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class DHDRJDIIUUT : XWGXOIOZRTK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double YTVSLGADREX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double IUWDIPAEIVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double WLNSTSOPQED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double HKLRKRKFHSY;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x732A220", Offset = "0x7328820", VA = "0x18732A220")]
		public DHDRJDIIUUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7329D20", Offset = "0x7328320", VA = "0x187329D20")]
		public static DHDRJDIIUUT Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x732A090", Offset = "0x7328690", VA = "0x18732A090", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class VJEIIZXANCJ : JPKJFGPKRFH
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class AUWAEQXFGZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public YBVGUQCSKJP UPYDKJXZEYI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader BEMVXWUORAX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public VJEIIZXANCJ JJSMLXMJLIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<PJWNKQUOEGF> LGWPYJTLUNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<PWBLEBRREXU> LGRJBCZOLCO;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public AUWAEQXFGZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x7328040", Offset = "0x7326640", VA = "0x187328040")]
			internal PJWNKQUOEGF SZECBCLDFJR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x7328030", Offset = "0x7326630", VA = "0x187328030")]
			internal PWBLEBRREXU SYYVDVRFVYI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<PJWNKQUOEGF> TMYXIKZQNAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<PWBLEBRREXU> AKJWSXDXHPX;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7337360", Offset = "0x7335960", VA = "0x187337360")]
		public static VJEIIZXANCJ Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7337AC0", Offset = "0x73360C0", VA = "0x187337AC0")]
		public VJEIIZXANCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7337720", Offset = "0x7335D20", VA = "0x187337720", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class RUEBWFIIWST : JPKJFGPKRFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string SMFCIOJVMFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint UYPAAIMDXDE;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x73298C0", Offset = "0x7327EC0", VA = "0x1873298C0")]
		public RUEBWFIIWST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7330CA0", Offset = "0x732F2A0", VA = "0x187330CA0")]
		public static RUEBWFIIWST Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7330E70", Offset = "0x732F470", VA = "0x187330E70", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class TCUKBDKUDXA : JPKJFGPKRFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public OXNMEKGVQGB YWMLGGKBYRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public DHDRJDIIUUT ATPSNIQMQVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType BTZTINVWBHG;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x73298C0", Offset = "0x7327EC0", VA = "0x1873298C0")]
		public TCUKBDKUDXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7332FC0", Offset = "0x73315C0", VA = "0x187332FC0")]
		public static TCUKBDKUDXA Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7333190", Offset = "0x7331790", VA = "0x187333190", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
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
	public class JPKJFGPKRFH : XWGXOIOZRTK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string UDAZODDRFXJ;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x73298C0", Offset = "0x7327EC0", VA = "0x1873298C0")]
		public JPKJFGPKRFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x732C4B0", Offset = "0x732AAB0", VA = "0x18732C4B0")]
		public JPKJFGPKRFH(JPKJFGPKRFH a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x732C330", Offset = "0x732A930", VA = "0x18732C330")]
		public new void GDZZBGWCWAP(YBVGUQCSKJP a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x732C420", Offset = "0x732AA20", VA = "0x18732C420", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class LWYLCHRZUYX<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int SNTOXKRGJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public YBVGUQCSKJP KXNQQKPTVYU;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected LWYLCHRZUYX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5486C60", Offset = "0x5485260", VA = "0x185486C60")]
		public LWYLCHRZUYX(LWYLCHRZUYX<a> a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5486C30", Offset = "0x5485230", VA = "0x185486C30")]
		public void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class BGOSXQNMGFA : LWYLCHRZUYX<OERFMZANDAT>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override OERFMZANDAT Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x7329A90", Offset = "0x7328090", VA = "0x187329A90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7329A50", Offset = "0x7328050", VA = "0x187329A50")]
		public BGOSXQNMGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x73299F0", Offset = "0x7327FF0", VA = "0x1873299F0")]
		public BGOSXQNMGFA(BGOSXQNMGFA a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7329910", Offset = "0x7327F10", VA = "0x187329910")]
		public static BGOSXQNMGFA Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class KFOQMVQOIBF : LWYLCHRZUYX<RUEBWFIIWST>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override RUEBWFIIWST Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x732C8C0", Offset = "0x732AEC0", VA = "0x18732C8C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x732C880", Offset = "0x732AE80", VA = "0x18732C880")]
		public KFOQMVQOIBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x732C7A0", Offset = "0x732ADA0", VA = "0x18732C7A0")]
		public static KFOQMVQOIBF Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ZOZHHVTIIKS : LWYLCHRZUYX<VARYPRXVVUX>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override VARYPRXVVUX Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x733D800", Offset = "0x733BE00", VA = "0x18733D800", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x733D7C0", Offset = "0x733BDC0", VA = "0x18733D7C0")]
		public ZOZHHVTIIKS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x733D6E0", Offset = "0x733BCE0", VA = "0x18733D6E0")]
		public static ZOZHHVTIIKS Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class DDOEZJZRPAW : LWYLCHRZUYX<TCUKBDKUDXA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override TCUKBDKUDXA Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x7329C20", Offset = "0x7328220", VA = "0x187329C20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7329BE0", Offset = "0x73281E0", VA = "0x187329BE0")]
		public DDOEZJZRPAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7329B00", Offset = "0x7328100", VA = "0x187329B00")]
		public static DDOEZJZRPAW Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class NVYZNLYAPSA : LWYLCHRZUYX<KISYKKNMMPI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override KISYKKNMMPI Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x732DB10", Offset = "0x732C110", VA = "0x18732DB10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x732DAD0", Offset = "0x732C0D0", VA = "0x18732DAD0")]
		public NVYZNLYAPSA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x732D9F0", Offset = "0x732BFF0", VA = "0x18732D9F0")]
		public static NVYZNLYAPSA Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class DLQSFWWUUNC : LWYLCHRZUYX<SWTHYRWJKEM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override SWTHYRWJKEM Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x732A400", Offset = "0x7328A00", VA = "0x18732A400", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x732A3C0", Offset = "0x73289C0", VA = "0x18732A3C0")]
		public DLQSFWWUUNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x732A360", Offset = "0x7328960", VA = "0x18732A360")]
		public DLQSFWWUUNC(DLQSFWWUUNC a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x732A280", Offset = "0x7328880", VA = "0x18732A280")]
		public static DLQSFWWUUNC Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class RDRLREPEFYU : LWYLCHRZUYX<BFGGSXOTTTO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override BFGGSXOTTTO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x7330C40", Offset = "0x732F240", VA = "0x187330C40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7330C00", Offset = "0x732F200", VA = "0x187330C00")]
		public RDRLREPEFYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7330B20", Offset = "0x732F120", VA = "0x187330B20")]
		public static RDRLREPEFYU Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class INANEINPBQN : LWYLCHRZUYX<QPBKESVYPXS>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override QPBKESVYPXS Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x732BD60", Offset = "0x732A360", VA = "0x18732BD60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x732BD20", Offset = "0x732A320", VA = "0x18732BD20")]
		public INANEINPBQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x732B9D0", Offset = "0x7329FD0", VA = "0x18732B9D0")]
		public static INANEINPBQN Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x732BAB0", Offset = "0x732A0B0", VA = "0x18732BAB0")]
		public static List<INANEINPBQN> UGGLXRCJNGM(YBVGUQCSKJP a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class QYYGORGDVXT : LWYLCHRZUYX<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x73303B0", Offset = "0x732E9B0", VA = "0x1873303B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7330370", Offset = "0x732E970", VA = "0x187330370")]
		public QYYGORGDVXT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7330290", Offset = "0x732E890", VA = "0x187330290")]
		public static QYYGORGDVXT Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class XWTMDVLSJIL : LWYLCHRZUYX<PWBLEBRREXU>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public VJEIIZXANCJ VJEIIZXANCJ;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override PWBLEBRREXU Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x7339E10", Offset = "0x7338410", VA = "0x187339E10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7339DD0", Offset = "0x73383D0", VA = "0x187339DD0")]
		public XWTMDVLSJIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7339CD0", Offset = "0x73382D0", VA = "0x187339CD0")]
		public static XWTMDVLSJIL Deserialize(YBVGUQCSKJP root, VJEIIZXANCJ anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class VUKMLPLUBJP : LWYLCHRZUYX<HFFDYZWKXSX>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override HFFDYZWKXSX Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7337CD0", Offset = "0x73362D0", VA = "0x187337CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7337C90", Offset = "0x7336290", VA = "0x187337C90")]
		public VUKMLPLUBJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7337BB0", Offset = "0x73361B0", VA = "0x187337BB0")]
		public static VUKMLPLUBJP Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class DOHJSNOITPC : LWYLCHRZUYX<SXIOEAXYCPD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override SXIOEAXYCPD Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x732A580", Offset = "0x7328B80", VA = "0x18732A580", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x732A540", Offset = "0x7328B40", VA = "0x18732A540")]
		public DOHJSNOITPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x732A460", Offset = "0x7328A60", VA = "0x18732A460")]
		public static DOHJSNOITPC Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class SXDMJXWDAIG : LWYLCHRZUYX<RAXRAOUEMWM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override RAXRAOUEMWM Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x73320C0", Offset = "0x73306C0", VA = "0x1873320C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7332020", Offset = "0x7330620", VA = "0x187332020")]
		public SXDMJXWDAIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7332060", Offset = "0x7330660", VA = "0x187332060")]
		public SXDMJXWDAIG(SXDMJXWDAIG a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7331F40", Offset = "0x7330540", VA = "0x187331F40")]
		public static SXDMJXWDAIG Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class DGCVVJOBVKR : LWYLCHRZUYX<FKCELISYDAH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override FKCELISYDAH Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7329CC0", Offset = "0x73282C0", VA = "0x187329CC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7329C80", Offset = "0x7328280", VA = "0x187329C80")]
		public DGCVVJOBVKR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class KISYKKNMMPI : JPKJFGPKRFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string SMFCIOJVMFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string WKNLYYTDJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public ZOZHHVTIIKS VARYPRXVVUX;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x73298C0", Offset = "0x7327EC0", VA = "0x1873298C0")]
		public KISYKKNMMPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x732C920", Offset = "0x732AF20", VA = "0x18732C920")]
		public static KISYKKNMMPI Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x732CB60", Offset = "0x732B160", VA = "0x18732CB60", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class SWTHYRWJKEM : JPKJFGPKRFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public YQSYAEFQCCV YQSYAEFQCCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public IQHJOZBUORK WDTPCBDVTBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public EERBVHFJWRY ZECGTXGCJIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public NOLTSBDXCXW BPRNSMXBCQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public SSGOAVDMOMX SGAZLIYIZLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color OMWIJWZWQPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode BBSJAUILMRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double VTZIWWZBIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool MDQDCETBDHE;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7331ED0", Offset = "0x73304D0", VA = "0x187331ED0")]
		public SWTHYRWJKEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7331560", Offset = "0x732FB60", VA = "0x187331560")]
		public static SWTHYRWJKEM Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7331A70", Offset = "0x7330070", VA = "0x187331A70", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
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
	public class BFGGSXOTTTO : JPKJFGPKRFH
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class XMEHEWGCGRP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public YBVGUQCSKJP UPYDKJXZEYI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader BEMVXWUORAX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<TOEZEOEVPIK> LGWPYJTLUNX;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XMEHEWGCGRP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x7337F70", Offset = "0x7336570", VA = "0x187337F70")]
			internal TOEZEOEVPIK SZECBCLDFJR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<TOEZEOEVPIK> OPYINNLVAWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> BPHGCCVKUJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> TKBBNBCLWJB;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x73298C0", Offset = "0x7327EC0", VA = "0x1873298C0")]
		public BFGGSXOTTTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7328F50", Offset = "0x7327550", VA = "0x187328F50")]
		public static BFGGSXOTTTO Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7329310", Offset = "0x7327910", VA = "0x187329310", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class XWGXOIOZRTK
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, RABZJRZYUHH> LWNOFNKNBPP;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static XXDHJMZMFMA REKLWJXTMUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, LEYHDTHFYUU> LJBVNBLBCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken KVXMUGLISDB;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7337F80", Offset = "0x7336580", VA = "0x187337F80")]
		public static RABZJRZYUHH AHCFSIDXJQY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7339010", Offset = "0x7337610", VA = "0x187339010")]
		public static LEYHDTHFYUU QQDDYXRZKLU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public XWGXOIOZRTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x73399E0", Offset = "0x7337FE0", VA = "0x1873399E0")]
		public XWGXOIOZRTK(XWGXOIOZRTK a, [Optional] YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x73386E0", Offset = "0x7336CE0", VA = "0x1873386E0")]
		public void GDZZBGWCWAP(YBVGUQCSKJP a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7338DD0", Offset = "0x73373D0", VA = "0x187338DD0")]
		public void LRPUBEZOMUE(string a, LEYHDTHFYUU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7338F20", Offset = "0x7337520", VA = "0x187338F20")]
		private void QHZWPRMAKSY(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7339100", Offset = "0x7337700", VA = "0x187339100")]
		private void REXFXJZAYPG(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7338990", Offset = "0x7336F90", VA = "0x187338990")]
		private void JJOPGSDTSQM(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7338110", Offset = "0x7336710", VA = "0x187338110")]
		internal static Dictionary<string, LEYHDTHFYUU> FATLTHTCGFH(YBVGUQCSKJP a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7338A50", Offset = "0x7337050", VA = "0x187338A50", Slot = "4")]
		public virtual void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class YBVGUQCSKJP : XWGXOIOZRTK
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class ZQYIBSVYBOY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public YBVGUQCSKJP UPYDKJXZEYI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader UIOPTEPJUGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<OERFMZANDAT> LGWPYJTLUNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<VJEIIZXANCJ> LGRJBCZOLCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<RUEBWFIIWST> LGMCDWFRBRF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<VARYPRXVVUX> LGGVGPLTSFW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<TCUKBDKUDXA> LHRRNKVBGHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<KISYKKNMMPI> LHMKQEBDWVY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<SWTHYRWJKEM> LHHDSXHGNKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<BFGGSXOTTTO> LHBWVQNJDZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<QPBKESVYPXS> LFGMUHQGXBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> LFBFXAWJNPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<HFFDYZWKXSX> FKPGYDNBMWW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<SXIOEAXYCPD> FKUNVKGYWIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<RAXRAOUEMWM> FKETDPZGUAE;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ZQYIBSVYBOY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x733DA70", Offset = "0x733C070", VA = "0x18733DA70")]
			internal OERFMZANDAT SZECBCLDFJR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x733DA60", Offset = "0x733C060", VA = "0x18733DA60")]
			internal VJEIIZXANCJ SYYVDVRFVYI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x733DA90", Offset = "0x733C090", VA = "0x18733DA90")]
			internal RUEBWFIIWST SZOPVPYXYGJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x733DA80", Offset = "0x733C080", VA = "0x18733DA80")]
			internal VARYPRXVVUX SZJIYJFAOVA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x733DA30", Offset = "0x733C030", VA = "0x18733DA30")]
			internal TCUKBDKUDXA SYJAMBJNTQH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x733DA20", Offset = "0x733C020", VA = "0x18733DA20")]
			internal KISYKKNMMPI SYDTOUPQKEY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x733DA50", Offset = "0x733C050", VA = "0x18733DA50")]
			internal SWTHYRWJKEM SYTOGOXIMMZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x733DA40", Offset = "0x733C040", VA = "0x18733DA40")]
			internal BFGGSXOTTTO SYOHJIDLDBQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x733DA10", Offset = "0x733C010", VA = "0x18733DA10")]
			internal QPBKESVYPXS SXNYXAHYHWX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x733DA00", Offset = "0x733C000", VA = "0x18733DA00")]
			internal Sampler SXIRZTOAYLO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x733D860", Offset = "0x733BE60", VA = "0x18733D860")]
			internal HFFDYZWKXSX ARROYMQYBZO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x733D9E0", Offset = "0x733BFE0", VA = "0x18733D9E0")]
			internal SXIOEAXYCPD ARWVVTKVLKX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x733D9F0", Offset = "0x733BFF0", VA = "0x18733D9F0")]
			internal RAXRAOUEMWM ASCCTAESUWG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> XRGXRBCFSSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> DXMENSBNWET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<OERFMZANDAT> OTBGHUWWLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<VJEIIZXANCJ> TLMOTSISARF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public UTSUQOAALKY UTSUQOAALKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<RUEBWFIIWST> ZPRVIMIHFXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<VARYPRXVVUX> KCYSEQEVHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<TCUKBDKUDXA> HMHCIPLJKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<KISYKKNMMPI> SKQRBVMUWOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<SWTHYRWJKEM> FNUDTOFCBZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<BFGGSXOTTTO> AGXZILUGTVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<QPBKESVYPXS> JNFNJBLXGWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> AKJWSXDXHPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public VUKMLPLUBJP GXYXDGIAFRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<HFFDYZWKXSX> NAKFOZYJPYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<SXIOEAXYCPD> WYVVFFYNZRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<RAXRAOUEMWM> VMAHSKKJCDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<FKCELISYDAH> RAYUAOTFLAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool KYEQPBZUCKP;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x733CA10", Offset = "0x733B010", VA = "0x18733CA10")]
		public YBVGUQCSKJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x733C970", Offset = "0x733AF70", VA = "0x18733C970")]
		public HFFDYZWKXSX SSTPXNVZMHZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7339F80", Offset = "0x7338580", VA = "0x187339F80")]
		public static YBVGUQCSKJP Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x733ADD0", Offset = "0x73393D0", VA = "0x18733ADD0")]
		public void KYZOGDONURM(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class HFFDYZWKXSX : JPKJFGPKRFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<INANEINPBQN> JNFNJBLXGWJ;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x73298C0", Offset = "0x7327EC0", VA = "0x1873298C0")]
		public HFFDYZWKXSX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x732B5E0", Offset = "0x7329BE0", VA = "0x18732B5E0")]
		public static HFFDYZWKXSX Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x732B760", Offset = "0x7329D60", VA = "0x18732B760", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class RAXRAOUEMWM : JPKJFGPKRFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public QYYGORGDVXT PKVHDFXMURO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NVYZNLYAPSA SPBVAGOKAAN;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x73298C0", Offset = "0x7327EC0", VA = "0x1873298C0")]
		public RAXRAOUEMWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x73307E0", Offset = "0x732EDE0", VA = "0x1873307E0")]
		public static RAXRAOUEMWM Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x73309B0", Offset = "0x732EFB0", VA = "0x1873309B0", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class TYYBBPVADRX : FKCELISYDAH
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x73298C0", Offset = "0x7327EC0", VA = "0x1873298C0")]
		public TYYBBPVADRX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7329AF0", Offset = "0x73280F0", VA = "0x187329AF0", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class FKCELISYDAH : JPKJFGPKRFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string NCYYWAFKAWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color XFMQCCWKDVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string FOEYAZCVXNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float UIBJVTXADBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float XNWZSBUMVBP;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x73298C0", Offset = "0x7327EC0", VA = "0x1873298C0")]
		public FKCELISYDAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x732A9F0", Offset = "0x7328FF0", VA = "0x18732A9F0", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class DAALXHYEMEX : FKCELISYDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x73298C0", Offset = "0x7327EC0", VA = "0x1873298C0")]
		public DAALXHYEMEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7329AF0", Offset = "0x73280F0", VA = "0x187329AF0", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class YWBIGBUYBGL : FKCELISYDAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float HBIGCDZAIXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float QDHIILJWBDV;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x733D3D0", Offset = "0x733B9D0", VA = "0x18733D3D0")]
		public YWBIGBUYBGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x733D0D0", Offset = "0x733B6D0", VA = "0x18733D0D0", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface TZGNSJROIYO
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SPEIEXFKEPT(YBVGUQCSKJP a, IQCYHIFARIO b, [Out] XYFZUQCULVJ c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface LEYHDTHFYUU
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LEYHDTHFYUU Clone(YBVGUQCSKJP root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class RABZJRZYUHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string PUNTJCAYCUG;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected RABZJRZYUHH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class SIVHLFTMCBI : LEYHDTHFYUU
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty REZQQGJOCGR
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7330FC0", Offset = "0x732F5C0", VA = "0x187330FC0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public SIVHLFTMCBI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class XXDHJMZMFMA : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7339E70", Offset = "0x7338470", VA = "0x187339E70", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public XXDHJMZMFMA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class IQHJOZBUORK : XWGXOIOZRTK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color UHLFFIXZPPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public SSGOAVDMOMX MBVVZNKVDTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color FORLXJQFLYB;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x732C2C0", Offset = "0x732A8C0", VA = "0x18732C2C0")]
		public IQHJOZBUORK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x732BDC0", Offset = "0x732A3C0", VA = "0x18732BDC0")]
		public static IQHJOZBUORK Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x732C060", Offset = "0x732A660", VA = "0x18732C060", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class EERBVHFJWRY : SSGOAVDMOMX
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string FIXXHOQPXDI = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double ZZGGBTRPGMS;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x732A990", Offset = "0x7328F90", VA = "0x18732A990")]
		public EERBVHFJWRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x732A5E0", Offset = "0x7328BE0", VA = "0x18732A5E0")]
		public new static EERBVHFJWRY Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x732A8D0", Offset = "0x7328ED0", VA = "0x18732A8D0", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class NOLTSBDXCXW : SSGOAVDMOMX
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string TRKHXBJWWLT = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double VLWAHMYAWEJ;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x732A990", Offset = "0x7328F90", VA = "0x18732A990")]
		public NOLTSBDXCXW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x732CD30", Offset = "0x732B330", VA = "0x18732CD30")]
		public new static NOLTSBDXCXW Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x732D020", Offset = "0x732B620", VA = "0x18732D020", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class YQSYAEFQCCV : XWGXOIOZRTK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color CDQIJHBSMVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public SSGOAVDMOMX XSYLITIEEUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double OADGSHAITBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double SXXFIZBAIBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public SSGOAVDMOMX AKGSAGHCXUI;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x733D060", Offset = "0x733B660", VA = "0x18733D060")]
		public YQSYAEFQCCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x733CA60", Offset = "0x733B060", VA = "0x18733CA60")]
		public static YQSYAEFQCCV Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x733CDD0", Offset = "0x733B3D0", VA = "0x18733CDD0", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class TOEZEOEVPIK : XWGXOIOZRTK
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class SXOZHASCAVJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader BEMVXWUORAX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public YBVGUQCSKJP UPYDKJXZEYI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<BGOSXQNMGFA> LGWPYJTLUNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<BGOSXQNMGFA> LGMCDWFRBRF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, BGOSXQNMGFA>> LGRJBCZOLCO;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SXOZHASCAVJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x73328F0", Offset = "0x7330EF0", VA = "0x1873328F0")]
			internal BGOSXQNMGFA SZECBCLDFJR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x7332840", Offset = "0x7330E40", VA = "0x187332840")]
			internal Dictionary<string, BGOSXQNMGFA> SYYVDVRFVYI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x73329C0", Offset = "0x7330FC0", VA = "0x1873329C0")]
			internal BGOSXQNMGFA SZOPVPYXYGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, BGOSXQNMGFA> GDKZBGNTYER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public BGOSXQNMGFA DXXPMGDNOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public DLQSFWWUUNC PRMMTXGXHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode YEYCFIUEXSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, BGOSXQNMGFA>> GNGPWHEGAOK;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7335230", Offset = "0x7333830", VA = "0x187335230")]
		public TOEZEOEVPIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7334B90", Offset = "0x7333190", VA = "0x187334B90")]
		public TOEZEOEVPIK(TOEZEOEVPIK a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7334A60", Offset = "0x7333060", VA = "0x187334A60")]
		public static int[] RNEBHTZWTTO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x73346D0", Offset = "0x7332CD0", VA = "0x1873346D0")]
		public static int[] QJGFEBHDTPW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x73348A0", Offset = "0x7332EA0", VA = "0x1873348A0")]
		public static int[] RDUXDTGMHYK(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7334490", Offset = "0x7332A90", VA = "0x187334490")]
		public static int[] QAJEQGUCRBM(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7333CF0", Offset = "0x73322F0", VA = "0x187333CF0")]
		public static int[] ERAYVWYTJSF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7334420", Offset = "0x7332A20", VA = "0x187334420")]
		public static int[] PEKBVGZVWHO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7333DA0", Offset = "0x73323A0", VA = "0x187333DA0")]
		public static int[] KSBOJCDLZNE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7334830", Offset = "0x7332E30", VA = "0x187334830")]
		public static int[] QTCKNJRKCBP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7334B00", Offset = "0x7333100", VA = "0x187334B00")]
		public static int[] ZZVCYKGRAIT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x73338A0", Offset = "0x7331EA0", VA = "0x1873338A0")]
		public static TOEZEOEVPIK Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7333E30", Offset = "0x7332430", VA = "0x187333E30", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class ZNNVUQGYKVH
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] MJWETYALAFA;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] HHPEXJZUJFJ;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] NQMMKWUHKNW;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] YDYEFHNFHVO;
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
	public class QPBKESVYPXS : JPKJFGPKRFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool UAQWOYYCVTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public DDOEZJZRPAW CQYZCUMLRHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<INANEINPBQN> RMEPSDQKBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public DOHJSNOITPC SXIOEAXYCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public YKOKDFUYNEH BMUZVGICMQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public RDRLREPEFYU MVVKJQPDHTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion VBLUIXJXMKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 ZZGGBTRPGMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 ZGEBKSEDRPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> BPHGCCVKUJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public DGCVVJOBVKR PVFFBLBPBQQ;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7330160", Offset = "0x732E760", VA = "0x187330160")]
		public QPBKESVYPXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x732EC40", Offset = "0x732D240", VA = "0x18732EC40")]
		public static QPBKESVYPXS Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x732F570", Offset = "0x732DB70", VA = "0x18732F570", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : JPKJFGPKRFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode NLFXBVKXYSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode ZDEDDVXBHBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode BFDQQLPMVQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode BDSUJQGFHPO;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7332F50", Offset = "0x7331550", VA = "0x187332F50")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7332A90", Offset = "0x7331090", VA = "0x187332A90")]
		public static Sampler Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7332D60", Offset = "0x7331360", VA = "0x187332D60", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
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
	public class SXIOEAXYCPD : JPKJFGPKRFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public BGOSXQNMGFA VCUCNHBBHVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public INANEINPBQN KLFCGWENWOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<INANEINPBQN> VDWLHZFCETX;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7332790", Offset = "0x7330D90", VA = "0x187332790")]
		public SXIOEAXYCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7332120", Offset = "0x7330720", VA = "0x187332120")]
		public static SXIOEAXYCPD Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7332480", Offset = "0x7330A80", VA = "0x187332480", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class SSGOAVDMOMX : XWGXOIOZRTK
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string SFSSEUTQSKI = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string TOLMAJGHPPA = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public SXDMJXWDAIG MNRPDAWOBRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int MJWETYALAFA;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7331510", Offset = "0x732FB10", VA = "0x187331510")]
		public SSGOAVDMOMX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7331420", Offset = "0x732FA20", VA = "0x187331420")]
		public SSGOAVDMOMX(SSGOAVDMOMX a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7331070", Offset = "0x732F670", VA = "0x187331070")]
		public static SSGOAVDMOMX Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x73312F0", Offset = "0x732F8F0", VA = "0x1873312F0", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7331350", Offset = "0x732F950", VA = "0x187331350")]
		public void YHXWRBJTBYP(JsonWriter a)
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
	public class GDBFQAVSBSY
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double LICKTRMJHUC;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double YWBWBSLIWON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double NGQSQBRQPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double TXFWQCXBCIX;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x732B110", Offset = "0x7329710", VA = "0x18732B110")]
		public GDBFQAVSBSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x732AC70", Offset = "0x7329270", VA = "0x18732AC70")]
		public static GDBFQAVSBSY Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x732AEB0", Offset = "0x73294B0", VA = "0x18732AEB0")]
		public void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class TSYWUCOIUQS : JPKJFGPKRFH
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color CHPCRICENEB;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double NSIIHAFNJMX;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double BJRPCKGAGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType BTZTINVWBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color HHPEXJZUJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double KNYVLUDSFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double AIHZABCKMEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public GDBFQAVSBSY GDBFQAVSBSY;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7335CE0", Offset = "0x73342E0", VA = "0x187335CE0")]
		public TSYWUCOIUQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7335BC0", Offset = "0x73341C0", VA = "0x187335BC0")]
		public TSYWUCOIUQS(TSYWUCOIUQS a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x73352D0", Offset = "0x73338D0", VA = "0x1873352D0")]
		public static TSYWUCOIUQS Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x73356C0", Offset = "0x7333CC0", VA = "0x1873356C0")]
		public static TSYWUCOIUQS Deserialize(YBVGUQCSKJP root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x73357E0", Offset = "0x7333DE0", VA = "0x1873357E0", Slot = "4")]
		public override void KYZOGDONURM(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class NSQLWIZIJKM : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<FKCELISYDAH> NLNPFHSKYKJ;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public NSQLWIZIJKM(IList<FKCELISYDAH> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x732D150", Offset = "0x732B750", VA = "0x18732D150", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x732D0E0", Offset = "0x732B6E0", VA = "0x18732D0E0", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class AZCWNHYVMGU : LEYHDTHFYUU, TZGNSJROIYO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<TSYWUCOIUQS> RAYUAOTFLAZ;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7328ED0", Offset = "0x73274D0", VA = "0x187328ED0")]
		public AZCWNHYVMGU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7328060", Offset = "0x7326660", VA = "0x187328060", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7328B30", Offset = "0x7327130", VA = "0x187328B30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7328C20", Offset = "0x7327220", VA = "0x187328C20")]
		private static string[] UOSRZCONJRY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x73282E0", Offset = "0x73268E0", VA = "0x1873282E0")]
		private static XYFZUQCULVJ.ImportValuesConversion FVUIOOCPMKA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7328740", Offset = "0x7326D40", VA = "0x187328740", Slot = "6")]
		public bool SPEIEXFKEPT(YBVGUQCSKJP a, IQCYHIFARIO b, [Out] XYFZUQCULVJ c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class JUQKUVGYCRN : LWYLCHRZUYX<TSYWUCOIUQS>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override TSYWUCOIUQS Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x732C650", Offset = "0x732AC50", VA = "0x18732C650", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x732C610", Offset = "0x732AC10", VA = "0x18732C610")]
		public JUQKUVGYCRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x732C530", Offset = "0x732AB30", VA = "0x18732C530")]
		public static JUQKUVGYCRN Deserialize(YBVGUQCSKJP root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class WPWGHOCYKAA : LEYHDTHFYUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public JUQKUVGYCRN DGCVVJOBVKR;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public WPWGHOCYKAA(JUQKUVGYCRN a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7337EB0", Offset = "0x73364B0", VA = "0x187337EB0")]
		public WPWGHOCYKAA(int a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7337D30", Offset = "0x7336330", VA = "0x187337D30", Slot = "5")]
		public LEYHDTHFYUU Clone(YBVGUQCSKJP root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7337DB0", Offset = "0x73363B0", VA = "0x187337DB0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class TLYICWZMGYV : RABZJRZYUHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7333850", Offset = "0x7331E50", VA = "0x187333850")]
		public TLYICWZMGYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7333360", Offset = "0x7331960", VA = "0x187333360", Slot = "4")]
		public override LEYHDTHFYUU Deserialize(YBVGUQCSKJP root, JProperty extensionToken)
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
