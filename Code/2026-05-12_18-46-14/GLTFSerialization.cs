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
	public class KHR_animation_pointer : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object JFGQHSOABWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string QNIDOXRKGSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string AMCSOEGHMNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public YEDFITJDIEI GOCYQYTWJOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer XRBUMTPOSKP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x87BAC80", Offset = "0x87B9680", VA = "0x1887BAC80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87BABD0", Offset = "0x87B95D0", VA = "0x1887BABD0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class JYUQVZPLNTX
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 IZPAGXGVXNQ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 CRFCXQSJOAR;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion JVCVXKYQDHX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool ACFIGMJACNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x87B6A80", Offset = "0x87B5480", VA = "0x1887B6A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87B83A0", Offset = "0x87B6DA0", VA = "0x1887B83A0")]
		public static void YTPAMPGFMPH(this HEOTCJBJJIU a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87B7630", Offset = "0x87B6030", VA = "0x1887B7630")]
		public static void ULOPFHALTZJ(this HEOTCJBJJIU a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87B64D0", Offset = "0x87B4ED0", VA = "0x1887B64D0")]
		public static void JLLEMZGEEYS(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87B5920", Offset = "0x87B4320", VA = "0x1887B5920")]
		public static GLTF.Math.Vector4 CJMYJBCERXQ(this AKLQENCIAHR a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87B5CA0", Offset = "0x87B46A0", VA = "0x1887B5CA0")]
		public static UnityEngine.Quaternion DNOVXXXVXTH(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87B5E20", Offset = "0x87B4820", VA = "0x1887B5E20")]
		public static UnityEngine.Quaternion DNOVXXXVXTH(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x87B6C40", Offset = "0x87B5640", VA = "0x1887B6C40")]
		public static GLTF.Math.Quaternion OUENQIFDLQT(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x87B52C0", Offset = "0x87B3CC0", VA = "0x1887B52C0")]
		public static Matrix4x4 APIEHSPEJGQ(this AKLQENCIAHR a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x87B54E0", Offset = "0x87B3EE0", VA = "0x1887B54E0")]
		public static Matrix4x4 APIEHSPEJGQ(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x87B7080", Offset = "0x87B5A80", VA = "0x1887B7080")]
		public static AKLQENCIAHR RGWYLHLUBOW(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x87B8130", Offset = "0x87B6B30", VA = "0x1887B8130")]
		public static UnityEngine.Vector3 VNEAQAOSASZ(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87B8060", Offset = "0x87B6A60", VA = "0x1887B8060")]
		public static UnityEngine.Vector3 VNEAQAOSASZ(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x87B6B10", Offset = "0x87B5510", VA = "0x1887B6B10")]
		public static GLTF.Math.Vector3 MINPAEHSDTZ(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x87B73F0", Offset = "0x87B5DF0", VA = "0x1887B73F0")]
		public static GLTF.Math.Vector3 SXQVQLJOLRU(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1382260", Offset = "0x1380C60", VA = "0x181382260")]
		public static GLTF.Math.Vector4 WOKAEYTTVIR(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x87B7DA0", Offset = "0x87B67A0", VA = "0x1887B7DA0")]
		public static Matrix4x4 VGQDEHHNNVL(this AKLQENCIAHR a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x87B7B30", Offset = "0x87B6530", VA = "0x1887B7B30")]
		public static Matrix4x4 VGQDEHHNNVL(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x87B6E00", Offset = "0x87B5800", VA = "0x1887B6E00")]
		public static AKLQENCIAHR QQOVCMPYUKX(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x87B7610", Offset = "0x87B6010", VA = "0x1887B7610")]
		public static UnityEngine.Vector2 ULMBWMJQUYN(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x87B7610", Offset = "0x87B6010", VA = "0x1887B7610")]
		public static UnityEngine.Vector2 ULMBWMJQUYN(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x87B7540", Offset = "0x87B5F40", VA = "0x1887B7540")]
		public static void ULMBWMJQUYN(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x87B8250", Offset = "0x87B6C50", VA = "0x1887B8250")]
		public static UnityEngine.Vector3 YRJFKRMVSPS(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D9A810", Offset = "0x1D99210", VA = "0x181D9A810")]
		public static UnityEngine.Vector3 YRJFKRMVSPS(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x87B82B0", Offset = "0x87B6CB0", VA = "0x1887B82B0")]
		public static void YRJFKRMVSPS(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1382260", Offset = "0x1380C60", VA = "0x181382260")]
		public static UnityEngine.Vector4 GVPMOQPZOZN(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1382260", Offset = "0x1380C60", VA = "0x181382260")]
		public static UnityEngine.Vector4 GVPMOQPZOZN(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87B6350", Offset = "0x87B4D50", VA = "0x1887B6350")]
		public static UnityEngine.Vector4[] GVPMOQPZOZN(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x87B6240", Offset = "0x87B4C40", VA = "0x1887B6240")]
		public static void GVPMOQPZOZN(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x87B68A0", Offset = "0x87B52A0", VA = "0x1887B68A0")]
		public static UnityEngine.Color KNBNWRKQSUR(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x87B6940", Offset = "0x87B5340", VA = "0x1887B6940")]
		public static void KNBNWRKQSUR(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x87B68A0", Offset = "0x87B52A0", VA = "0x1887B68A0")]
		public static UnityEngine.Color KNBNWRKQSUR(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1382260", Offset = "0x1380C60", VA = "0x181382260")]
		public static UnityEngine.Color TWPZFGKWASM(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x87B7430", Offset = "0x87B5E30", VA = "0x1887B7430")]
		public static void TWPZFGKWASM(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1382260", Offset = "0x1380C60", VA = "0x181382260")]
		public static UnityEngine.Color TWPZFGKWASM(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x87B5290", Offset = "0x87B3C90", VA = "0x1887B5290")]
		public static GLTF.Math.Color ALJCABKSEYC(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x87B6D80", Offset = "0x87B5780", VA = "0x1887B6D80")]
		public static GLTF.Math.Color PTIVIHNRYYF(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x87B8AE0", Offset = "0x87B74E0", VA = "0x1887B8AE0")]
		public static GLTF.Math.Color ZGMHXHFVSYN(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87B5F50", Offset = "0x87B4950", VA = "0x1887B5F50")]
		public static UnityEngine.Color[] ENDGPBMXXSQ(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x87B6450", Offset = "0x87B4E50", VA = "0x1887B6450")]
		public static int[] HXBFINASCTJ(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x87B6FD0", Offset = "0x87B59D0", VA = "0x1887B6FD0")]
		public static UnityEngine.Vector2[] RBUTKYAXVUE(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x87B5B40", Offset = "0x87B4540", VA = "0x1887B5B40")]
		public static void CTSZKISBXAH(OARRAAVFWOH a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x87B6070", Offset = "0x87B4A70", VA = "0x1887B6070")]
		public static UnityEngine.Vector3[] EYRFUWLXLJD(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x87B8940", Offset = "0x87B7340", VA = "0x1887B8940")]
		public static UnityEngine.Vector4[] ZFBJFHICTJK(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x87B61D0", Offset = "0x87B4BD0", VA = "0x1887B61D0")]
		public static void GQHNFUDOAXV(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x87B73C0", Offset = "0x87B5DC0", VA = "0x1887B73C0")]
		public static UnityEngine.Quaternion SBWFQMHSQNR(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class OARRAAVFWOH
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TULYRSXOBNY TULYRSXOBNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6D0", Offset = "0xD0B0D0", VA = "0x180D0C6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray UITRUXZQSJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x87C03D0", Offset = "0x87BEDD0", VA = "0x1887C03D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> QBOWRLOYTQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xEFE9D0", Offset = "0xEFD3D0", VA = "0x180EFE9D0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xFE23C0", Offset = "0xFE0DC0", VA = "0x180FE23C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint KJUGRAXUWPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD169E0", Offset = "0xD153E0", VA = "0x180D169E0")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD16820", Offset = "0xD15220", VA = "0x180D16820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x87C03E0", Offset = "0x87BEDE0", VA = "0x1887C03E0")]
		public OARRAAVFWOH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x87AC670", Offset = "0x87AB070", VA = "0x1887AC670")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x87AC6D0", Offset = "0x87AB0D0", VA = "0x1887AC6D0")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class GWHGHNXSBSC
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class XXTYLPQTJDX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> ZASEXBVXNXV;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public XXTYLPQTJDX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x87C36D0", Offset = "0x87C20D0", VA = "0x1887C36D0")]
			internal int? XNQKCILJHAM(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x87C3570", Offset = "0x87C1F70", VA = "0x1887C3570")]
			internal int? EKOJLCVOLKT(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x87C3600", Offset = "0x87C2000", VA = "0x1887C3600")]
			internal bool QHTCKXCVCNZ(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x87AE5D0", Offset = "0x87ACFD0", VA = "0x1887AE5D0")]
		private static void INZWVMCKIZV(NumericArray a, OARRAAVFWOH b, OARRAAVFWOH c, OARRAAVFWOH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x87AD310", Offset = "0x87ABD10", VA = "0x1887AD310")]
		public static void IBAMCALAWNG(Dictionary<string, OARRAAVFWOH> a, Dictionary<string, (OARRAAVFWOH sparseIndices, OARRAAVFWOH sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87AEB40", Offset = "0x87AD540", VA = "0x1887AEB40")]
		public static void KITITIHDZVO(Dictionary<string, OARRAAVFWOH> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x87AF5B0", Offset = "0x87ADFB0", VA = "0x1887AF5B0")]
		public static void RCQXMZNSOVV(OARRAAVFWOH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x87AF020", Offset = "0x87ADA20", VA = "0x1887AF020")]
		public static void OBSVJNPSUDZ(Dictionary<string, List<OARRAAVFWOH>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x87AD120", Offset = "0x87ABB20", VA = "0x1887AD120")]
		private static void EVCGCRYBHXR(OARRAAVFWOH a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x87AD250", Offset = "0x87ABC50", VA = "0x1887AD250")]
		internal static void EVCGCRYBHXR(WRLZRPFBNDF a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x87AF6B0", Offset = "0x87AE0B0", VA = "0x1887AF6B0")]
		public static XJZDRDVDUVD VZSTGXDKXIP(IEnumerable<XJZDRDVDUVD> a)
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
			[Cpp2IlInjected.Address(RVA = "0xF7A900", Offset = "0xF79300", VA = "0x180F7A900")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x15FBC00", Offset = "0x15FA600", VA = "0x1815FBC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30CEF60", Offset = "0x30CD960", VA = "0x1830CEF60")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30CEF70", Offset = "0x30CD970", VA = "0x1830CEF70")]
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
	public class YRWYBCTOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint KSPAGKJVDMH;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint RPMTHOLSANT;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint SSGDEIXEMAB;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x87C4030", Offset = "0x87C2A30", VA = "0x1887C4030")]
		public static void VPPSJHFAMVP(Stream a, [Out] HAJPTZWCSKJ b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x87C3DA0", Offset = "0x87C27A0", VA = "0x1887C3DA0")]
		public static ChunkInfo UDFKRSFORJT(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x87C3BD0", Offset = "0x87C25D0", VA = "0x1887C3BD0")]
		public static GLBHeader GYRLDXYPZAL(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x87C3B10", Offset = "0x87C2510", VA = "0x1887C3B10")]
		public static bool EZXSAQLELLF(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x87C41F0", Offset = "0x87C2BF0", VA = "0x1887C41F0")]
		public static ChunkInfo YMXLFTKZYMM(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x87C3870", Offset = "0x87C2270", VA = "0x1887C3870")]
		private static void BJXJTUQBDFQ(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x87C3D10", Offset = "0x87C2710", VA = "0x1887C3D10")]
		private static uint QFNYDFJBIIZ(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UZXHFFGJITY
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
		public PathElement HAPICGDASUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD07B10", VA = "0x180D09110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD18F30", Offset = "0xD17930", VA = "0x180D18F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int OYCHLVRRQHS
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xE26DB0", Offset = "0xE257B0", VA = "0x180E26DB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xE26CE0", Offset = "0xE256E0", VA = "0x180E26CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string PCGESYSELIL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xD11E10", Offset = "0xD10810", VA = "0x180D11E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EKHWLTFOGLY
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD14270", Offset = "0xD12C70", VA = "0x180D14270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD14290", Offset = "0xD12C90", VA = "0x180D14290")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public UZXHFFGJITY PWTAPHSZDYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD11E20", Offset = "0xD10820", VA = "0x180D11E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xD0B7F0", Offset = "0xD0A1F0", VA = "0x180D0B7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x87C28F0", Offset = "0x87C12F0", VA = "0x1887C28F0")]
		public string RAJPEDXBWDY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x87C2B50", Offset = "0x87C1550", VA = "0x1887C2B50")]
		public UZXHFFGJITY YRVKDHSSBTU(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x87C2B70", Offset = "0x87C1570", VA = "0x1887C2B70")]
		private UZXHFFGJITY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x87C2BD0", Offset = "0x87C15D0", VA = "0x1887C2BD0")]
		public UZXHFFGJITY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x54A54A0", Offset = "0x54A3EA0", VA = "0x1854A54A0")]
		[CompilerGenerated]
		internal static string MMMAGPZMRGS(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x87C28B0", Offset = "0x87C12B0", VA = "0x1887C28B0")]
		[CompilerGenerated]
		internal static bool BMRIVTPDRGV([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x87C2970", Offset = "0x87C1370", VA = "0x1887C2970")]
		[CompilerGenerated]
		internal static UZXHFFGJITY SIWMUOOGQXJ(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ZGWGGJRNKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x87C4510", Offset = "0x87C2F10", VA = "0x1887C4510")]
		public static int[] UNOVRMGKXPZ(this HAJPTZWCSKJ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x87C43C0", Offset = "0x87C2DC0", VA = "0x1887C43C0")]
		public static int[] RAUMJWHORPT(this HAJPTZWCSKJ a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class MRDMBZFLKTR
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x87BEFE0", Offset = "0x87BD9E0", VA = "0x1887BEFE0")]
		public static uint GYTTZOFPAPG(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream FNYDHRZDJEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long LHIXDXYWGYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long GRGJYHWTZPE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x87C2240", Offset = "0x87C0C40", VA = "0x1887C2240", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x87C2280", Offset = "0x87C0C80", VA = "0x1887C2280", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x87C2280", Offset = "0x87C0C80", VA = "0x1887C2280", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x87C22A0", Offset = "0x87C0CA0", VA = "0x1887C22A0", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x87C22C0", Offset = "0x87C0CC0", VA = "0x1887C22C0", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x87C22E0", Offset = "0x87C0CE0", VA = "0x1887C22E0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x87C1FD0", Offset = "0x87C09D0", VA = "0x1887C1FD0")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x87C1D90", Offset = "0x87C0790", VA = "0x1887C1D90", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x87C1E60", Offset = "0x87C0860", VA = "0x1887C1E60", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x87C1EC0", Offset = "0x87C08C0", VA = "0x1887C1EC0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x87C1DD0", Offset = "0x87C07D0", VA = "0x1887C1DD0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x87C1F90", Offset = "0x87C0990", VA = "0x1887C1F90", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x87C1F00", Offset = "0x87C0900", VA = "0x1887C1F00")]
		private void VNNWLMYUCEL()
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
		public static Color SOYMJLOTOVF
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x87AB930", Offset = "0x87AA330", VA = "0x1887AB930")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color KWCQGBBNUIB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x87ABC00", Offset = "0x87AA600", VA = "0x1887ABC00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color SBSOVVPTTBD
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x87ABC10", Offset = "0x87AA610", VA = "0x1887ABC10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2DEAF60", Offset = "0x2DE9960", VA = "0x182DEAF60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x189E8E0", Offset = "0x189D2E0", VA = "0x18189E8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2E489B0", Offset = "0x2E473B0", VA = "0x182E489B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2E489C0", Offset = "0x2E473C0", VA = "0x182E489C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BC67F0", Offset = "0x2BC51F0", VA = "0x182BC67F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x32C94F0", Offset = "0x32C7EF0", VA = "0x1832C94F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1537DC0", Offset = "0x15367C0", VA = "0x181537DC0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1537DD0", Offset = "0x15367D0", VA = "0x181537DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B88B70", Offset = "0x2B87570", VA = "0x182B88B70")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x87AB950", Offset = "0x87AA350", VA = "0x1887AB950", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x87ABA00", Offset = "0x87AA400", VA = "0x1887ABA00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x87ABAA0", Offset = "0x87AA4A0", VA = "0x1887ABAA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x87ABB50", Offset = "0x87AA550", VA = "0x1887ABB50")]
		public static bool JSGIPYLAFHN(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AKLQENCIAHR : IEquatable<AKLQENCIAHR>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly AKLQENCIAHR JAMFGMSEUFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] FZJENCRDAJM;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float XHOTQKRGXUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x87A9830", Offset = "0x87A8230", VA = "0x1887A9830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x87A9920", Offset = "0x87A8320", VA = "0x1887A9920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float QGNAXEVJPFI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x87A99E0", Offset = "0x87A83E0", VA = "0x1887A99E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x87A9A70", Offset = "0x87A8470", VA = "0x1887A9A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float JGGJTABBSJR
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x87A9110", Offset = "0x87A7B10", VA = "0x1887A9110")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x87A95C0", Offset = "0x87A7FC0", VA = "0x1887A95C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float FEBTLUGFDQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x87A9740", Offset = "0x87A8140", VA = "0x1887A9740")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x87A9650", Offset = "0x87A8050", VA = "0x1887A9650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float XGYYYQJOVMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x87A9800", Offset = "0x87A8200", VA = "0x1887A9800")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x87A98F0", Offset = "0x87A82F0", VA = "0x1887A98F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float QGHTZYBMFTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x87A9980", Offset = "0x87A8380", VA = "0x1887A9980")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x87A9A10", Offset = "0x87A8410", VA = "0x1887A9A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JGLQQGUZBVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x87A9170", Offset = "0x87A7B70", VA = "0x1887A9170")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x87A9620", Offset = "0x87A8020", VA = "0x1887A9620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float FERODONXFYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x87A9770", Offset = "0x87A8170", VA = "0x1887A9770")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x87A9680", Offset = "0x87A8080", VA = "0x1887A9680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float XHEFVXDMEXR
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x87A97D0", Offset = "0x87A81D0", VA = "0x1887A97D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x87A98C0", Offset = "0x87A82C0", VA = "0x1887A98C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float QGCNCRHOWIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x87A99B0", Offset = "0x87A83B0", VA = "0x1887A99B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x87A9A40", Offset = "0x87A8440", VA = "0x1887A9A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float JGQXNNOWLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x87A9140", Offset = "0x87A7B40", VA = "0x1887A9140")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x87A95F0", Offset = "0x87A7FF0", VA = "0x1887A95F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float FEMHGHTZWMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x87A97A0", Offset = "0x87A81A0", VA = "0x1887A97A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x87A96B0", Offset = "0x87A80B0", VA = "0x1887A96B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float XGOLECVUCPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x87A9860", Offset = "0x87A8260", VA = "0x1887A9860")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x87A9890", Offset = "0x87A8290", VA = "0x1887A9890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float QHNJJMQWKKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x87A9950", Offset = "0x87A8350", VA = "0x1887A9950")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x87A9AA0", Offset = "0x87A84A0", VA = "0x1887A9AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float JGWEKUITURS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x87A91A0", Offset = "0x87A7BA0", VA = "0x1887A91A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x87A9590", Offset = "0x87A7F90", VA = "0x1887A9590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float FDLYTZYNBHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x87A9710", Offset = "0x87A8110", VA = "0x1887A9710")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x87A96E0", Offset = "0x87A80E0", VA = "0x1887A96E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x87A9BA0", Offset = "0x87A85A0", VA = "0x1887A9BA0")]
		public AKLQENCIAHR(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x87A91D0", Offset = "0x87A7BD0", VA = "0x1887A91D0", Slot = "4")]
		public bool Equals(AKLQENCIAHR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x87A9490", Offset = "0x87A7E90", VA = "0x1887A9490", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x10F0DE0", Offset = "0x10EF7E0", VA = "0x1810F0DE0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DEAF60", Offset = "0x2DE9960", VA = "0x182DEAF60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x189E8E0", Offset = "0x189D2E0", VA = "0x18189E8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2E489B0", Offset = "0x2E473B0", VA = "0x182E489B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2E489C0", Offset = "0x2E473C0", VA = "0x182E489C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2BC67F0", Offset = "0x2BC51F0", VA = "0x182BC67F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32C94F0", Offset = "0x32C7EF0", VA = "0x1832C94F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1537DC0", Offset = "0x15367C0", VA = "0x181537DC0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1537DD0", Offset = "0x15367D0", VA = "0x181537DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x87C1150", Offset = "0x87BFB50", VA = "0x1887C1150")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x87C0DC0", Offset = "0x87BF7C0", VA = "0x1887C0DC0", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x87C0EE0", Offset = "0x87BF8E0", VA = "0x1887C0EE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x87C0F90", Offset = "0x87BF990", VA = "0x1887C0F90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x87C1070", Offset = "0x87BFA70", VA = "0x1887C1070")]
		public static bool JSGIPYLAFHN(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DEAF60", Offset = "0x2DE9960", VA = "0x182DEAF60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x189E8E0", Offset = "0x189D2E0", VA = "0x18189E8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2E489B0", Offset = "0x2E473B0", VA = "0x182E489B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2E489C0", Offset = "0x2E473C0", VA = "0x182E489C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x105F8E0", Offset = "0x105E2E0", VA = "0x18105F8E0")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x87C2F70", Offset = "0x87C1970", VA = "0x1887C2F70")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x87C2D80", Offset = "0x87C1780", VA = "0x1887C2D80", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x87C2DE0", Offset = "0x87C17E0", VA = "0x1887C2DE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x87C2EC0", Offset = "0x87C18C0", VA = "0x1887C2EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x87C2F10", Offset = "0x87C1910", VA = "0x1887C2F10")]
		public static bool JSGIPYLAFHN(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DEAF60", Offset = "0x2DE9960", VA = "0x182DEAF60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x189E8E0", Offset = "0x189D2E0", VA = "0x18189E8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2E489B0", Offset = "0x2E473B0", VA = "0x182E489B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2E489C0", Offset = "0x2E473C0", VA = "0x182E489C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2BC67F0", Offset = "0x2BC51F0", VA = "0x182BC67F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32C94F0", Offset = "0x32C7EF0", VA = "0x1832C94F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x87C3320", Offset = "0x87C1D20", VA = "0x1887C3320")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x87C2F90", Offset = "0x87C1990", VA = "0x1887C2F90", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x87C3070", Offset = "0x87C1A70", VA = "0x1887C3070", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x87C3130", Offset = "0x87C1B30", VA = "0x1887C3130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x87C31E0", Offset = "0x87C1BE0", VA = "0x1887C31E0")]
		public static bool JSGIPYLAFHN(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DEAF60", Offset = "0x2DE9960", VA = "0x182DEAF60")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x189E8E0", Offset = "0x189D2E0", VA = "0x18189E8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E489B0", Offset = "0x2E473B0", VA = "0x182E489B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2E489C0", Offset = "0x2E473C0", VA = "0x182E489C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2BC67F0", Offset = "0x2BC51F0", VA = "0x182BC67F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x32C94F0", Offset = "0x32C7EF0", VA = "0x1832C94F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1537DC0", Offset = "0x15367C0", VA = "0x181537DC0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1537DD0", Offset = "0x15367D0", VA = "0x181537DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B88B70", Offset = "0x2B87570", VA = "0x182B88B70")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x87AB950", Offset = "0x87AA350", VA = "0x1887AB950", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x87C33A0", Offset = "0x87C1DA0", VA = "0x1887C33A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x87ABAA0", Offset = "0x87AA4A0", VA = "0x1887ABAA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class PSNVFIKATCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x87C0A20", Offset = "0x87BF420", VA = "0x1887C0A20")]
		public static void MSBRWVQENMW(this JObject a, string b, UZHQVOUYVVV c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class MRDMBZFLKTR
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x87BFCE0", Offset = "0x87BE6E0", VA = "0x1887BFCE0")]
		public static List<string> PUGLKMDYOVD(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x87BF440", Offset = "0x87BDE40", VA = "0x1887BF440")]
		public static List<double> KJPXXDBHIMB(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x87BEB40", Offset = "0x87BD540", VA = "0x1887BEB40")]
		public static List<int> FAJKNHNYHEY(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C45EA0", Offset = "0x3C448A0", VA = "0x183C45EA0")]
		public static List<a> RCXMDCUEAZW<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x87BE5F0", Offset = "0x87BCFF0", VA = "0x1887BE5F0")]
		public static UZHQVOUYVVV AQAYIRJBIOS(this JToken a, HAJPTZWCSKJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x87C0290", Offset = "0x87BEC90", VA = "0x1887C0290")]
		public static int YIQJJJCMWSM(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x87C0150", Offset = "0x87BEB50", VA = "0x1887C0150")]
		public static double RBMXSCTJQOG(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x87BED00", Offset = "0x87BD700", VA = "0x1887BED00")]
		public static GLTF.Math.Color FSJMTMXMNQN(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x87BF600", Offset = "0x87BE000", VA = "0x1887BF600")]
		public static GLTF.Math.Color MSZMEPRRYRU(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x87BE8A0", Offset = "0x87BD2A0", VA = "0x1887BE8A0")]
		public static GLTF.Math.Color DTOLXVPQVAW(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x87BFE90", Offset = "0x87BE890", VA = "0x1887BFE90")]
		public static GLTF.Math.Vector3 QHGPOWPDQLG(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x87BF870", Offset = "0x87BE270", VA = "0x1887BF870")]
		public static GLTF.Math.Vector2 MYCRFRMVATM(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x87BFA80", Offset = "0x87BE480", VA = "0x1887BFA80")]
		public static GLTF.Math.Vector3 MYHYCYGSKEV(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x87BF130", Offset = "0x87BDB30", VA = "0x1887BF130")]
		public static GLTF.Math.Quaternion IZQGNZRJNTG(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3C45890", Offset = "0x3C44290", VA = "0x183C45890")]
		public static Dictionary<string, b> JKBMQSRRGEU<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C461F0", Offset = "0x3C44BF0", VA = "0x183C461F0")]
		public static c XIIDSUQJLYI<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public WRLZRPFBNDF bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x87AC0F0", Offset = "0x87AAAF0", VA = "0x1887AC0F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x87AC070", Offset = "0x87AAA70", VA = "0x1887AC070", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class OJFNNSTXVZI : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x87C04E0", Offset = "0x87BEEE0", VA = "0x1887C04E0")]
		public OJFNNSTXVZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x87C0410", Offset = "0x87BEE10", VA = "0x1887C0410", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, TULYRSXOBNY> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4D0", Offset = "0xD08ED0", VA = "0x180D0A4D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x87ABF30", Offset = "0x87AA930", VA = "0x1887ABF30", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x87ABFF0", Offset = "0x87AA9F0", VA = "0x1887ABFF0")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class GJXIUAVJPLK : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class JOXUKJQLBDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public HAJPTZWCSKJ XBKNLMWAWOQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader FDWAZTCOSCD;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JOXUKJQLBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x87B4F70", Offset = "0x87B3970", VA = "0x1887B4F70")]
			internal TULYRSXOBNY TFYPDRRXVEP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x87AC620", Offset = "0x87AB020", VA = "0x1887AC620")]
		public GJXIUAVJPLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x87AC490", Offset = "0x87AAE90", VA = "0x1887AC490", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public ISFEGYUJPCM SMSLVFIAEDD;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xD13870", Offset = "0xD12270", VA = "0x180D13870")]
		public EXT_texture_exr(ISFEGYUJPCM source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x87AC140", Offset = "0x87AAB40", VA = "0x1887AC140", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x87AC1B0", Offset = "0x87AABB0", VA = "0x1887AC1B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class AQHLKMBKLSF : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x87A9F70", Offset = "0x87A8970", VA = "0x1887A9F70")]
		public AQHLKMBKLSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x87A9E50", Offset = "0x87A8850", VA = "0x1887A9E50", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
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
	public class AudioEmitterId : BZPQMJVKEEL<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x87AAE80", Offset = "0x87A9880", VA = "0x1887AAE80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x87AAE40", Offset = "0x87A9840", VA = "0x1887AAE40")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : BZPQMJVKEEL<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x87AB010", Offset = "0x87A9A10", VA = "0x1887AB010", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x87AAFD0", Offset = "0x87A99D0", VA = "0x1887AAFD0")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : BZPQMJVKEEL<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x87AACF0", Offset = "0x87A96F0", VA = "0x1887AACF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x87AACB0", Offset = "0x87A96B0", VA = "0x1887AACB0")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x87AABD0", Offset = "0x87A95D0", VA = "0x1887AABD0")]
		public static AudioDataId Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x87BA8F0", Offset = "0x87B92F0", VA = "0x1887BA8F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x87BA4F0", Offset = "0x87B8EF0", VA = "0x1887BA4F0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x87BA560", Offset = "0x87B8F60", VA = "0x1887BA560")]
		public static KHR_SceneAudioEmittersRef Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x87BAB50", Offset = "0x87B9550", VA = "0x1887BAB50")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x87BA4C0", Offset = "0x87B8EC0", VA = "0x1887BA4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x87BA3A0", Offset = "0x87B8DA0", VA = "0x1887BA3A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x87BA190", Offset = "0x87B8B90", VA = "0x1887BA190", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x87BA200", Offset = "0x87B8C00", VA = "0x1887BA200")]
		public static KHR_NodeAudioEmitterRef Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class HCGVINBXVVS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string ETSPVRVSECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? UBHYWQPNLLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? YQEFXVEOCBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? YYETFMCMXOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? PZVUWGGSHXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? REORNAUPKTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? WNSPWIIZPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? LUKAHKENYBN;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x87B0240", Offset = "0x87AEC40", VA = "0x1887B0240")]
		public JObject XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x87AFB40", Offset = "0x87AE540", VA = "0x1887AFB40")]
		public static HCGVINBXVVS Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public HCGVINBXVVS()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : ANJTOSCXDAN
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
		public HCGVINBXVVS positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x87B97E0", Offset = "0x87B81E0", VA = "0x1887B97E0", Slot = "5")]
		public virtual JObject XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x87B92E0", Offset = "0x87B7CE0", VA = "0x1887B92E0")]
		public static KHR_AudioEmitter Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x87B9B80", Offset = "0x87B8580", VA = "0x1887B9B80")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : ANJTOSCXDAN
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
		[Cpp2IlInjected.Address(RVA = "0x87B9F60", Offset = "0x87B8960", VA = "0x1887B9F60")]
		public JObject XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x87B9C00", Offset = "0x87B8600", VA = "0x1887B9C00")]
		public static KHR_AudioSource Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x87B4E30", Offset = "0x87B3830", VA = "0x1887B4E30")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : ANJTOSCXDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AMFKYVJMYXM bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x87B91B0", Offset = "0x87B7BB0", VA = "0x1887B91B0")]
		public JObject XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x87B8F50", Offset = "0x87B7950", VA = "0x1887B8F50")]
		public static KHR_AudioData Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x87B4E30", Offset = "0x87B3830", VA = "0x1887B4E30")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : AVTQJTSSWFW
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
		[Cpp2IlInjected.Address(RVA = "0x87BAE10", Offset = "0x87B9810", VA = "0x1887BAE10", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x87BAD80", Offset = "0x87B9780", VA = "0x1887BAD80", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x87BB540", Offset = "0x87B9F40", VA = "0x1887BB540")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ARGHISKFVWL : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x87AAB80", Offset = "0x87A9580", VA = "0x1887AAB80")]
		public ARGHISKFVWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x87A9FC0", Offset = "0x87A89C0", VA = "0x1887A9FC0", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AMFKYVJMYXM bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x87BB710", Offset = "0x87BA110", VA = "0x1887BB710", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x87BB650", Offset = "0x87BA050", VA = "0x1887BB650", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x87BB760", Offset = "0x87BA160", VA = "0x1887BB760")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class UGVLZOYXHJD : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class JOXUKJQLBDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader FDWAZTCOSCD;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JOXUKJQLBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x87B5020", Offset = "0x87B3A20", VA = "0x1887B5020")]
			internal int TFYPDRRXVEP()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x87C25A0", Offset = "0x87C0FA0", VA = "0x1887C25A0")]
		public UGVLZOYXHJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x87C2390", Offset = "0x87C0D90", VA = "0x1887C2390", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public UZHQVOUYVVV anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x87BB860", Offset = "0x87BA260", VA = "0x1887BB860", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x87BB7E0", Offset = "0x87BA1E0", VA = "0x1887BB7E0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class JRJNOPPGBEC : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x87B5240", Offset = "0x87B3C40", VA = "0x1887B5240")]
		public JRJNOPPGBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x87B5090", Offset = "0x87B3A90", VA = "0x1887B5090", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public UZHQVOUYVVV clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public UZHQVOUYVVV clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public UZHQVOUYVVV clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x87BBB10", Offset = "0x87BA510", VA = "0x1887BBB10", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x87BBA70", Offset = "0x87BA470", VA = "0x1887BBA70", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class SXEACMARPTI : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x87C1D40", Offset = "0x87C0740", VA = "0x1887C1D40")]
		public SXEACMARPTI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x87C1AC0", Offset = "0x87C04C0", VA = "0x1887C1AC0", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x87BBE70", Offset = "0x87BA870", VA = "0x1887BBE70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x87BBE00", Offset = "0x87BA800", VA = "0x1887BBE00", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class BBEMBPHEFBS : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x87AB230", Offset = "0x87A9C30", VA = "0x1887AB230")]
		public BBEMBPHEFBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x87AB160", Offset = "0x87A9B60", VA = "0x1887AB160", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : KSYLFATEMGM, AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float NYKYSXOMCDQ;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x87BC150", Offset = "0x87BAB50", VA = "0x1887BC150")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x87BC1A0", Offset = "0x87BABA0", VA = "0x1887BC1A0")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, HAJPTZWCSKJ root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x87BBF90", Offset = "0x87BA990", VA = "0x1887BBF90", Slot = "6")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x87BC030", Offset = "0x87BAA30", VA = "0x1887BC030", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class PHMFBYPDOCZ : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x87C0630", Offset = "0x87BF030", VA = "0x1887C0630")]
		public PHMFBYPDOCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x87C0530", Offset = "0x87BEF30", VA = "0x1887C0530", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x87BC270", Offset = "0x87BAC70", VA = "0x1887BC270", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x87BC210", Offset = "0x87BAC10", VA = "0x1887BC210", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x87BC3C0", Offset = "0x87BADC0", VA = "0x1887BC3C0")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class YJTHHWPRUBI : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x87C3820", Offset = "0x87C2220", VA = "0x1887C3820")]
		public YJTHHWPRUBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x87C3750", Offset = "0x87C2150", VA = "0x1887C3750", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public UZHQVOUYVVV iridescenceTexture;

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
		public UZHQVOUYVVV iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x87BC470", Offset = "0x87BAE70", VA = "0x1887BC470", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x87BC3D0", Offset = "0x87BADD0", VA = "0x1887BC3D0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x87BC830", Offset = "0x87BB230", VA = "0x1887BC830")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class KGXVRNBVIBK : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x87B8F00", Offset = "0x87B7900", VA = "0x1887B8F00")]
		public KGXVRNBVIBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x87B8C10", Offset = "0x87B7610", VA = "0x1887B8C10", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class GUBDVTBQKVR : AVTQJTSSWFW
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 LBOYIUCIVGB;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double AZSNADYVZWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color YLWGCRMKJMJ;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color NOOJPSAFLQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public UZHQVOUYVVV WBCXOYIMCKZ;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly UZHQVOUYVVV NITIUVFWKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 XCASAQWBNZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double JKFHDHPFKSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public UZHQVOUYVVV AIXEPWBEDNU;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly UZHQVOUYVVV GGJUKECSUWW;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x87AD030", Offset = "0x87ABA30", VA = "0x1887AD030")]
		public GUBDVTBQKVR(GLTF.Math.Color a, UZHQVOUYVVV b, GLTF.Math.Vector3 c, double d, UZHQVOUYVVV e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x87AC730", Offset = "0x87AB130", VA = "0x1887AC730", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x87AC8E0", Offset = "0x87AB2E0", VA = "0x1887AC8E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class PPDRJDVXGRN : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x87C09D0", Offset = "0x87BF3D0", VA = "0x1887C09D0")]
		public PPDRJDVXGRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x87C0680", Offset = "0x87BF080", VA = "0x1887C0680", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public UZHQVOUYVVV sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public UZHQVOUYVVV sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x87BC920", Offset = "0x87BB320", VA = "0x1887BC920", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x87BC850", Offset = "0x87BB250", VA = "0x1887BC850", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x87BCE30", Offset = "0x87BB830", VA = "0x1887BCE30")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class MLJDGMYXCUN : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x87BE5A0", Offset = "0x87BCFA0", VA = "0x1887BE5A0")]
		public MLJDGMYXCUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x87BE340", Offset = "0x87BCD40", VA = "0x1887BE340", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public UZHQVOUYVVV specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public UZHQVOUYVVV specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x87BCF60", Offset = "0x87BB960", VA = "0x1887BCF60", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x87BCE90", Offset = "0x87BB890", VA = "0x1887BCE90", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x87BD470", Offset = "0x87BBE70", VA = "0x1887BD470")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class CZFQGSGWSGH : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x87AB8E0", Offset = "0x87AA2E0", VA = "0x1887AB8E0")]
		public CZFQGSGWSGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x87AB670", Offset = "0x87AA070", VA = "0x1887AB670", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public UZHQVOUYVVV transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x87BD560", Offset = "0x87BBF60", VA = "0x1887BD560", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x87BD4E0", Offset = "0x87BBEE0", VA = "0x1887BD4E0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class BEJXGLQHZSW : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x87AB3C0", Offset = "0x87A9DC0", VA = "0x1887AB3C0")]
		public BEJXGLQHZSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x87AB280", Offset = "0x87A9C80", VA = "0x1887AB280", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class UXSRDRZBGVN : KSYLFATEMGM, AVTQJTSSWFW
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x87C2860", Offset = "0x87C1260", VA = "0x1887C2860")]
		public UXSRDRZBGVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x87C27F0", Offset = "0x87C11F0", VA = "0x1887C27F0")]
		public UXSRDRZBGVN(UXSRDRZBGVN a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x87C25F0", Offset = "0x87C0FF0", VA = "0x1887C25F0", Slot = "6")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x87C2760", Offset = "0x87C1160", VA = "0x1887C2760", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x87C2690", Offset = "0x87C1090", VA = "0x1887C2690", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class KTSVUXZQJFV : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x87BE2F0", Offset = "0x87BCCF0", VA = "0x1887BE2F0")]
		public KTSVUXZQJFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x87BE270", Offset = "0x87BCC70", VA = "0x1887BE270", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public UZHQVOUYVVV thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x87BD780", Offset = "0x87BC180", VA = "0x1887BD780", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x87BD6F0", Offset = "0x87BC0F0", VA = "0x1887BD6F0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x87BDCA0", Offset = "0x87BC6A0", VA = "0x1887BDCA0")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class BEMFKLBOQTC : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x87AB620", Offset = "0x87AA020", VA = "0x1887AB620")]
		public BEMFKLBOQTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x87AB410", Offset = "0x87A9E10", VA = "0x1887AB410", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x87BDD20", Offset = "0x87BC720", VA = "0x1887BDD20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x87BDCC0", Offset = "0x87BC6C0", VA = "0x1887BDCC0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1246EC0", Offset = "0x12458C0", VA = "0x181246EC0")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class JFKPCJLBSZO : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x87B4F20", Offset = "0x87B3920", VA = "0x1887B4F20")]
		public JFKPCJLBSZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x87B4E40", Offset = "0x87B3840", VA = "0x1887B4E40", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x87BDE90", Offset = "0x87BC890", VA = "0x1887BDE90", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x87BDE30", Offset = "0x87BC830", VA = "0x1887BDE30", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1246EC0", Offset = "0x12458C0", VA = "0x181246EC0")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class XNXFLTHAMPS : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x87C3520", Offset = "0x87C1F20", VA = "0x1887C3520")]
		public XNXFLTHAMPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x87C3440", Offset = "0x87C1E40", VA = "0x1887C3440", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x87BE000", Offset = "0x87BCA00", VA = "0x1887BE000", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x87BDFA0", Offset = "0x87BC9A0", VA = "0x1887BDFA0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1246EC0", Offset = "0x12458C0", VA = "0x181246EC0")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class SWZOQRGAOQM : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x87C1A70", Offset = "0x87C0470", VA = "0x1887C1A70")]
		public SWZOQRGAOQM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x87C1990", Offset = "0x87C0390", VA = "0x1887C1990", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public ISFEGYUJPCM source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xD13870", Offset = "0xD12270", VA = "0x180D13870")]
		public KHR_texture_basisu(ISFEGYUJPCM source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x87BE110", Offset = "0x87BCB10", VA = "0x1887BE110", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x87BE180", Offset = "0x87BCB80", VA = "0x1887BE180", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class DHOXIZHAPBK : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x87ABD90", Offset = "0x87AA790", VA = "0x1887ABD90")]
		public DHOXIZHAPBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x87ABC30", Offset = "0x87AA630", VA = "0x1887ABC30", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class RJRRWUSHGGT : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 KJUGRAXUWPR;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 KXTCPPUMNQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double TYYYGKBREIK;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double JJUSFZUAHTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 ZGYOETDZTFY;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 BQGPTCNNWFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? QHRCINCSBKG;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int RUCANUDXQJS;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x87C1910", Offset = "0x87C0310", VA = "0x1887C1910")]
		public RJRRWUSHGGT(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x87C11E0", Offset = "0x87BFBE0", VA = "0x1887C11E0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x87C12C0", Offset = "0x87BFCC0", VA = "0x1887C12C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class PUGAEGTCYZB : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x87C0D70", Offset = "0x87BF770", VA = "0x1887C0D70")]
		public PUGAEGTCYZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x87C0AA0", Offset = "0x87BF4A0", VA = "0x1887C0AA0", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class FDUJNQARLSL : AVTQJTSSWFW
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> NQCIMTWRYSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6D0", Offset = "0xD0B0D0", VA = "0x180D0C6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xD13870", Offset = "0xD12270", VA = "0x180D13870")]
		public FDUJNQARLSL(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x87AC2A0", Offset = "0x87AACA0", VA = "0x1887AC2A0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x87AC310", Offset = "0x87AAD10", VA = "0x1887AC310", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x87AC400", Offset = "0x87AAE00", VA = "0x1887AC400")]
		public List<double> VGJWHKZTCSF(HEOTCJBJJIU a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class ESEDWXVKBSH : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x87ABEE0", Offset = "0x87AA8E0", VA = "0x1887ABEE0")]
		public ESEDWXVKBSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x87ABDE0", Offset = "0x87AA7E0", VA = "0x1887ABDE0", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class IEXZETSAWVJ : ANJTOSCXDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AMFKYVJMYXM WRLZRPFBNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint YTIBOKQQUCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType VFSUDTAUXXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool QFHFJZUNFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint KQOHZIVUHAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType MERZPCICCKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> KSXRRNRNUKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> ISSYJHADHVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AQLCTIYKNIL QOJYRAWJUXO;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x87B4E30", Offset = "0x87B3830", VA = "0x1887B4E30")]
		public IEXZETSAWVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x87B1160", Offset = "0x87AFB60", VA = "0x1887B1160")]
		public static IEXZETSAWVJ Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x87B4470", Offset = "0x87B2E70", VA = "0x1887B4470", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x87B2D00", Offset = "0x87B1700", VA = "0x1887B2D00")]
		private unsafe static sbyte PNMLBNFBQFY(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x87B4E00", Offset = "0x87B3800", VA = "0x1887B4E00")]
		private unsafe static float2 ZTYAPYRELOY(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x87B1EE0", Offset = "0x87B08E0", VA = "0x1887B1EE0")]
		private unsafe static float3 JEWIONGYNSV(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x87B4A70", Offset = "0x87B3470", VA = "0x1887B4A70")]
		private unsafe static float4 XSNURCOVPJU(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x87B15C0", Offset = "0x87AFFC0", VA = "0x1887B15C0")]
		private unsafe static float4x4 EFNUPWDHKXY(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x87B2D00", Offset = "0x87B1700", VA = "0x1887B2D00")]
		private unsafe static byte OVPJRCWSLIT(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x87B1F30", Offset = "0x87B0930", VA = "0x1887B1F30")]
		private unsafe static float2 JPLQXSVCCLZ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x87B4AD0", Offset = "0x87B34D0", VA = "0x1887B4AD0")]
		private unsafe static float3 XSQOBJSPVAG(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x87B2D10", Offset = "0x87B1710", VA = "0x1887B2D10")]
		private unsafe static float4 QAQIREWCNHT(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x87B2B10", Offset = "0x87B1510", VA = "0x1887B2B10")]
		private unsafe static float4x4 OEPQICQNEQB(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x87B07E0", Offset = "0x87AF1E0", VA = "0x1887B07E0")]
		private unsafe static short PHRJIZLIYHE(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x87B4DD0", Offset = "0x87B37D0", VA = "0x1887B4DD0")]
		private unsafe static float2 YWWCJQRAHJS(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x87B0DA0", Offset = "0x87AF7A0", VA = "0x1887B0DA0")]
		private unsafe static float3 DSJPYRQPAJD(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x87B2AB0", Offset = "0x87B14B0", VA = "0x1887B2AB0")]
		private unsafe static float4 NWSTGELECFQ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x87B3110", Offset = "0x87B1B10", VA = "0x1887B3110")]
		private unsafe static float4x4 SZRPTBHGPYK(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x87B07E0", Offset = "0x87AF1E0", VA = "0x1887B07E0")]
		private unsafe static ushort FYVYMVDLZNL(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x87B1760", Offset = "0x87B0160", VA = "0x1887B1760")]
		private unsafe static float2 EVPFRUKPDCZ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x87B2CB0", Offset = "0x87B16B0", VA = "0x1887B2CB0")]
		private unsafe static float3 ONKVGUIDBEA(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x87B2670", Offset = "0x87B1070", VA = "0x1887B2670")]
		private unsafe static float4x4 LFRNTSKFLTF(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x87B35C0", Offset = "0x87B1FC0", VA = "0x1887B35C0")]
		private unsafe static float4 UBIQMPGBDIH(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x87B3100", Offset = "0x87B1B00", VA = "0x1887B3100")]
		private unsafe static uint RAXFKLXMVGI(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x87B07E0", Offset = "0x87AF1E0", VA = "0x1887B07E0")]
		private unsafe static ushort CVEPRTLVFXP(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x87B1ED0", Offset = "0x87B08D0", VA = "0x1887B1ED0")]
		private unsafe static float JBLYSPXSIDE(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x87B4A50", Offset = "0x87B3450", VA = "0x1887B4A50")]
		private unsafe static float2 XSCFLQROCPS(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x87B04B0", Offset = "0x87AEEB0", VA = "0x1887B04B0")]
		private unsafe static float3 ABNXYXKUGIV(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x87B0780", Offset = "0x87AF180", VA = "0x1887B0780")]
		private unsafe static float4 FNYPNNMYXKC(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x87B0750", Offset = "0x87AF150", VA = "0x1887B0750")]
		private unsafe static float4x4 CQULAZGTTNI(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x87B0780", Offset = "0x87AF180", VA = "0x1887B0780")]
		private unsafe static float4 CTQKLEMGDBD(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x87B07B0", Offset = "0x87AF1B0", VA = "0x1887B07B0")]
		private unsafe static float4 CTQKLEMGDBD(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x87B3C90", Offset = "0x87B2690", VA = "0x1887B3C90")]
		public static float3[] WMCBEEWTHQA(IEXZETSAWVJ a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x87B32B0", Offset = "0x87B1CB0", VA = "0x1887B32B0")]
		public static float3[] TUMLVRBZWYM(IEXZETSAWVJ a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x87B2940", Offset = "0x87B1340", VA = "0x1887B2940")]
		public static uint[] NVIMGXDSJUN(IEXZETSAWVJ a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x87B0630", Offset = "0x87AF030", VA = "0x1887B0630")]
		internal static void CPSGKORDQXQ(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x87B20D0", Offset = "0x87B0AD0", VA = "0x1887B20D0")]
		public uint[] KGEZKBSBFTX(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x87B38B0", Offset = "0x87B22B0", VA = "0x1887B38B0")]
		public float[] UJAHLMSGNMD(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x87B3620", Offset = "0x87B2020", VA = "0x1887B3620")]
		public float2[] UETUSFYJJDH(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x87B4B20", Offset = "0x87B3520", VA = "0x1887B4B20")]
		public float2[] YAQQEFQCRFR(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x87B2D70", Offset = "0x87B1770", VA = "0x1887B2D70")]
		public float3[] QNPOVEYODNO(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x87B2320", Offset = "0x87B0D20", VA = "0x1887B2320")]
		public float3[] KJCCWRSFVCU(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x87B0B30", Offset = "0x87AF530", VA = "0x1887B0B30")]
		public float4[] DQGMVQYRKCL(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x87B0DF0", Offset = "0x87AF7F0", VA = "0x1887B0DF0")]
		public float4[] DXTYWLNPIHB(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x87B18B0", Offset = "0x87B02B0", VA = "0x1887B18B0")]
		public float4[] FWTIXWGYLVS(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x87B2FF0", Offset = "0x87B19F0", VA = "0x1887B2FF0")]
		public float3[] QQWEOTLOQDF(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x87B04D0", Offset = "0x87AEED0", VA = "0x1887B04D0")]
		public float3[] ARVKTATGGFK(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x87B1C40", Offset = "0x87B0640", VA = "0x1887B1C40")]
		public float4[] GBEJVROYFNA(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x87B05E0", Offset = "0x87AEFE0", VA = "0x1887B05E0")]
		public uint[] BMXMIVKHHGZ(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x87B3EC0", Offset = "0x87B28C0", VA = "0x1887B3EC0")]
		public float4x4[] WUFJZXDSXWM(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x87B0970", Offset = "0x87AF370", VA = "0x1887B0970")]
		private unsafe static float4 DJGRTTLELBM(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x87B07F0", Offset = "0x87AF1F0", VA = "0x1887B07F0")]
		private unsafe static float4 DJGRTTLELBM(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x87B1F60", Offset = "0x87B0960", VA = "0x1887B1F60")]
		private unsafe static float4x4 JZBMVZTFMYH(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x87B1D10", Offset = "0x87B0710", VA = "0x1887B1D10")]
		private unsafe static float4 IRBXSZKQKCX(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x87B3B20", Offset = "0x87B2520", VA = "0x1887B3B20")]
		private unsafe static float3 VJKNZYRACAU(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x87B2810", Offset = "0x87B1210", VA = "0x1887B2810")]
		private unsafe static float2 MZCJAAGJTQF(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x87B1790", Offset = "0x87B0190", VA = "0x1887B1790")]
		private unsafe static uint FHZOXNQGIBW(void* a, uint b, GLTFComponentType c)
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
	public static class ZNVNXTSWAVS
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x87DA1C0", Offset = "0x87D8BC0", VA = "0x1887DA1C0")]
		public static int KLFLQAEBVAG(this GLTFAccessorAttributeType a)
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
	public class AQLCTIYKNIL : KSYLFATEMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int KQOHZIVUHAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public DZJBQMTPYTG KUUYPZTODZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public FYYGRVNBIKJ BQHQGZKXXFU;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x87C54A0", Offset = "0x87C3EA0", VA = "0x1887C54A0")]
		public AQLCTIYKNIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x87C50A0", Offset = "0x87C3AA0", VA = "0x1887C50A0")]
		public static AQLCTIYKNIL Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x87C5370", Offset = "0x87C3D70", VA = "0x1887C5370", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class DZJBQMTPYTG : KSYLFATEMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AMFKYVJMYXM WRLZRPFBNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int YTIBOKQQUCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType VFSUDTAUXXJ;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x87C5F70", Offset = "0x87C4970", VA = "0x1887C5F70")]
		public DZJBQMTPYTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x87C5B50", Offset = "0x87C4550", VA = "0x1887C5B50")]
		public static DZJBQMTPYTG Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x87C5E30", Offset = "0x87C4830", VA = "0x1887C5E30", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class FYYGRVNBIKJ : KSYLFATEMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AMFKYVJMYXM WRLZRPFBNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int YTIBOKQQUCV;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x87C7910", Offset = "0x87C6310", VA = "0x1887C7910")]
		public FYYGRVNBIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x87C7590", Offset = "0x87C5F90", VA = "0x1887C7590")]
		public static FYYGRVNBIKJ Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x87C7810", Offset = "0x87C6210", VA = "0x1887C7810", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class AMUQUOLDGLX : KSYLFATEMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public VKJMGSXGQNB XJBRRMTFWMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public YEDFITJDIEI KGDUMRCNBAB;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x87C4E00", Offset = "0x87C3800", VA = "0x1887C4E00")]
		public AMUQUOLDGLX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x87C4B10", Offset = "0x87C3510", VA = "0x1887C4B10")]
		public static AMUQUOLDGLX Deserialize(HAJPTZWCSKJ root, JsonReader reader, QXSDTWZKPRH anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x87C4D00", Offset = "0x87C3700", VA = "0x1887C4D00", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class YEDFITJDIEI : KSYLFATEMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public XJZDRDVDUVD HEOTCJBJJIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string HMETGHEOROT;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x87D9AA0", Offset = "0x87D84A0", VA = "0x1887D9AA0")]
		public static YEDFITJDIEI Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x87D9E20", Offset = "0x87D8820", VA = "0x1887D9E20")]
		public YEDFITJDIEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x87D9D00", Offset = "0x87D8700", VA = "0x1887D9D00", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
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
	public class RLWBXOMGKVB
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(RLWBXOMGKVB data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] QJYBBRFOXLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type UVHSMIAPMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] DCXTZTAQMYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion KRWQMHKEYLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string XFIEDJEEOHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string LMIZMQWPXBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public OARRAAVFWOH AKVWZFWPEQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string PYORMZZTIOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string DBNFFFSWPHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public OARRAAVFWOH KJDOQTTWQHY;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x87D2B80", Offset = "0x87D1580", VA = "0x1887D2B80")]
		public RLWBXOMGKVB()
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
	public class ZTUMJVGKYLA : KSYLFATEMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public TULYRSXOBNY LNAXADJCLTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType SYOVHCYHUXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public TULYRSXOBNY YBIDWWVFJBT;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x87DA5B0", Offset = "0x87D8FB0", VA = "0x1887DA5B0")]
		public ZTUMJVGKYLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x87DA220", Offset = "0x87D8C20", VA = "0x1887DA220")]
		public static ZTUMJVGKYLA Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x87DA440", Offset = "0x87D8E40", VA = "0x1887DA440", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class IFYMQTZUWMM : KSYLFATEMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string YIOEAWKGGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string BAYVVCJLKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string UYZONXALEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string PBADDNTOPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> NNAQPTXOLTO;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x87CCDA0", Offset = "0x87CB7A0", VA = "0x1887CCDA0")]
		public IFYMQTZUWMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x87CC2B0", Offset = "0x87CACB0", VA = "0x1887CC2B0")]
		public static IFYMQTZUWMM Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x87CC980", Offset = "0x87CB380", VA = "0x1887CC980", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x87CC970", Offset = "0x87CB370", VA = "0x1887CC970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x87CC5D0", Offset = "0x87CAFD0", VA = "0x1887CC5D0")]
		public string ORYCYTPKZGA(bool a)
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
	public class WRLZRPFBNDF : ANJTOSCXDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public OKVUXVROTUP OHPLGLWJJAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint YTIBOKQQUCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint CAAZZQVJHZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint BWLRRLTSOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget KGDUMRCNBAB;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x87C5050", Offset = "0x87C3A50", VA = "0x1887C5050")]
		public WRLZRPFBNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x87D8E40", Offset = "0x87D7840", VA = "0x1887D8E40")]
		public static WRLZRPFBNDF Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x87D90F0", Offset = "0x87D7AF0", VA = "0x1887D90F0", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class RUMAJXXCJHX : KSYLFATEMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double DALCGDTPGRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double JYGEBLZQGYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double CRNGNWQLDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double DOIVJMBTCSQ;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x87D4B50", Offset = "0x87D3550", VA = "0x1887D4B50")]
		public RUMAJXXCJHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x87D4660", Offset = "0x87D3060", VA = "0x1887D4660")]
		public static RUMAJXXCJHX Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x87D49E0", Offset = "0x87D33E0", VA = "0x1887D49E0", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class LKCTYNWZVKH : KSYLFATEMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double QIBMFHUYSIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double QZTEOEISIFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double CRNGNWQLDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double DOIVJMBTCSQ;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x87D0AB0", Offset = "0x87CF4B0", VA = "0x1887D0AB0")]
		public LKCTYNWZVKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x87D05B0", Offset = "0x87CEFB0", VA = "0x1887D05B0")]
		public static LKCTYNWZVKH Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x87D0920", Offset = "0x87CF320", VA = "0x1887D0920", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class QXSDTWZKPRH : ANJTOSCXDAN
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class JOXUKJQLBDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public HAJPTZWCSKJ XBKNLMWAWOQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader FDWAZTCOSCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public QXSDTWZKPRH TNELIOYLUPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<AMUQUOLDGLX> LULENKICLGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<ZTUMJVGKYLA> LUFXQDOFBUW;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JOXUKJQLBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x87CD530", Offset = "0x87CBF30", VA = "0x1887CD530")]
			internal AMUQUOLDGLX TFYPDRRXVEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x87CD520", Offset = "0x87CBF20", VA = "0x1887CD520")]
			internal ZTUMJVGKYLA TFTIGKYALTG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<AMUQUOLDGLX> NAWKLZOVHMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<ZTUMJVGKYLA> HAWKCJNYTLL;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x87D2280", Offset = "0x87D0C80", VA = "0x1887D2280")]
		public static QXSDTWZKPRH Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x87D29E0", Offset = "0x87D13E0", VA = "0x1887D29E0")]
		public QXSDTWZKPRH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x87D2640", Offset = "0x87D1040", VA = "0x1887D2640", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class UGLZFXIWHAP : ANJTOSCXDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string CDXYIDBJHXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint CAAZZQVJHZM;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x87C5050", Offset = "0x87C3A50", VA = "0x1887C5050")]
		public UGLZFXIWHAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x87D80C0", Offset = "0x87D6AC0", VA = "0x1887D80C0")]
		public static UGLZFXIWHAP Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x87D8290", Offset = "0x87D6C90", VA = "0x1887D8290", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class GFLCJGQFPRQ : ANJTOSCXDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public RUMAJXXCJHX ACLZGCZAPXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public LKCTYNWZVKH QNTIWDCBLBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType MERZPCICCKQ;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x87C5050", Offset = "0x87C3A50", VA = "0x1887C5050")]
		public GFLCJGQFPRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x87C7960", Offset = "0x87C6360", VA = "0x1887C7960")]
		public static GFLCJGQFPRQ Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x87C7B30", Offset = "0x87C6530", VA = "0x1887C7B30", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
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
	public class ANJTOSCXDAN : KSYLFATEMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string KPIDBUYRLLN;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x87C5050", Offset = "0x87C3A50", VA = "0x1887C5050")]
		public ANJTOSCXDAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x87C4FD0", Offset = "0x87C39D0", VA = "0x1887C4FD0")]
		public ANJTOSCXDAN(ANJTOSCXDAN a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x87C4E50", Offset = "0x87C3850", VA = "0x1887C4E50")]
		public new void HGHTLDPCOBZ(HAJPTZWCSKJ a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x87C4F40", Offset = "0x87C3940", VA = "0x1887C4F40", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class BZPQMJVKEEL<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int LVYPECRPQWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public HAJPTZWCSKJ LJEDQXPUPWM;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		protected BZPQMJVKEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x4F579A0", Offset = "0x4F563A0", VA = "0x184F579A0")]
		public BZPQMJVKEEL(BZPQMJVKEEL<a> a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4F57970", Offset = "0x4F56370", VA = "0x184F57970")]
		public void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class TULYRSXOBNY : BZPQMJVKEEL<IEXZETSAWVJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override IEXZETSAWVJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x87D70D0", Offset = "0x87D5AD0", VA = "0x1887D70D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x87D7030", Offset = "0x87D5A30", VA = "0x1887D7030")]
		public TULYRSXOBNY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x87D7070", Offset = "0x87D5A70", VA = "0x1887D7070")]
		public TULYRSXOBNY(TULYRSXOBNY a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x87D6F50", Offset = "0x87D5950", VA = "0x1887D6F50")]
		public static TULYRSXOBNY Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class OKVUXVROTUP : BZPQMJVKEEL<UGLZFXIWHAP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override UGLZFXIWHAP Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x87D1A40", Offset = "0x87D0440", VA = "0x1887D1A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x87D1A00", Offset = "0x87D0400", VA = "0x1887D1A00")]
		public OKVUXVROTUP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x87D1920", Offset = "0x87D0320", VA = "0x1887D1920")]
		public static OKVUXVROTUP Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class AMFKYVJMYXM : BZPQMJVKEEL<WRLZRPFBNDF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override WRLZRPFBNDF Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x87C4AB0", Offset = "0x87C34B0", VA = "0x1887C4AB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x87C4A70", Offset = "0x87C3470", VA = "0x1887C4A70")]
		public AMFKYVJMYXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x87C4990", Offset = "0x87C3390", VA = "0x1887C4990")]
		public static AMFKYVJMYXM Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class TYQIDDYZXQK : BZPQMJVKEEL<GFLCJGQFPRQ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override GFLCJGQFPRQ Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x87D7250", Offset = "0x87D5C50", VA = "0x1887D7250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x87D7210", Offset = "0x87D5C10", VA = "0x1887D7210")]
		public TYQIDDYZXQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x87D7130", Offset = "0x87D5B30", VA = "0x1887D7130")]
		public static TYQIDDYZXQK Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class ISFEGYUJPCM : BZPQMJVKEEL<HYPAYMVBZTQ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override HYPAYMVBZTQ Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x87CCF70", Offset = "0x87CB970", VA = "0x1887CCF70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x87CCF30", Offset = "0x87CB930", VA = "0x1887CCF30")]
		public ISFEGYUJPCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x87CCE50", Offset = "0x87CB850", VA = "0x1887CCE50")]
		public static ISFEGYUJPCM Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class JZJXLRFCXOQ : BZPQMJVKEEL<FVNHZHFYOAY>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override FVNHZHFYOAY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x87CE800", Offset = "0x87CD200", VA = "0x1887CE800", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x87CE760", Offset = "0x87CD160", VA = "0x1887CE760")]
		public JZJXLRFCXOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x87CE7A0", Offset = "0x87CD1A0", VA = "0x1887CE7A0")]
		public JZJXLRFCXOQ(JZJXLRFCXOQ a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x87CE680", Offset = "0x87CD080", VA = "0x1887CE680")]
		public static JZJXLRFCXOQ Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class SLVMOGNGDEY : BZPQMJVKEEL<NRXRJTXZNMY>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NRXRJTXZNMY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x87D5790", Offset = "0x87D4190", VA = "0x1887D5790", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x87D5750", Offset = "0x87D4150", VA = "0x1887D5750")]
		public SLVMOGNGDEY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x87D5670", Offset = "0x87D4070", VA = "0x1887D5670")]
		public static SLVMOGNGDEY Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class XJZDRDVDUVD : BZPQMJVKEEL<HEOTCJBJJIU>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override HEOTCJBJJIU Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x87D9A40", Offset = "0x87D8440", VA = "0x1887D9A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x87D9A00", Offset = "0x87D8400", VA = "0x1887D9A00")]
		public XJZDRDVDUVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x87D96B0", Offset = "0x87D80B0", VA = "0x1887D96B0")]
		public static XJZDRDVDUVD Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x87D9790", Offset = "0x87D8190", VA = "0x1887D9790")]
		public static List<XJZDRDVDUVD> RCXMDCUEAZW(HAJPTZWCSKJ a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class WLZPKTUQMIZ : BZPQMJVKEEL<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x87D8DE0", Offset = "0x87D77E0", VA = "0x1887D8DE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x87D8DA0", Offset = "0x87D77A0", VA = "0x1887D8DA0")]
		public WLZPKTUQMIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x87D8CC0", Offset = "0x87D76C0", VA = "0x1887D8CC0")]
		public static WLZPKTUQMIZ Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class VKJMGSXGQNB : BZPQMJVKEEL<ZTUMJVGKYLA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public QXSDTWZKPRH QXSDTWZKPRH;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override ZTUMJVGKYLA Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x87D8C60", Offset = "0x87D7660", VA = "0x1887D8C60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x87D8C20", Offset = "0x87D7620", VA = "0x1887D8C20")]
		public VKJMGSXGQNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x87D8B20", Offset = "0x87D7520", VA = "0x1887D8B20")]
		public static VKJMGSXGQNB Deserialize(HAJPTZWCSKJ root, QXSDTWZKPRH anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class FEXXFFGAMHL : BZPQMJVKEEL<CZFXZURTGTF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override CZFXZURTGTF Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x87C6810", Offset = "0x87C5210", VA = "0x1887C6810", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x87C67D0", Offset = "0x87C51D0", VA = "0x1887C67D0")]
		public FEXXFFGAMHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x87C66F0", Offset = "0x87C50F0", VA = "0x1887C66F0")]
		public static FEXXFFGAMHL Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class LSVPPLRWNBS : BZPQMJVKEEL<EQNDQUCXYAN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override EQNDQUCXYAN Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x87D0C30", Offset = "0x87CF630", VA = "0x1887D0C30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x87D0BF0", Offset = "0x87CF5F0", VA = "0x1887D0BF0")]
		public LSVPPLRWNBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x87D0B10", Offset = "0x87CF510", VA = "0x1887D0B10")]
		public static LSVPPLRWNBS Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class AAUCBQWFIFI : BZPQMJVKEEL<FLUADCVEWRS>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override FLUADCVEWRS Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x87C4930", Offset = "0x87C3330", VA = "0x1887C4930", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x87C4890", Offset = "0x87C3290", VA = "0x1887C4890")]
		public AAUCBQWFIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x87C48D0", Offset = "0x87C32D0", VA = "0x1887C48D0")]
		public AAUCBQWFIFI(AAUCBQWFIFI a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x87C47B0", Offset = "0x87C31B0", VA = "0x1887C47B0")]
		public static AAUCBQWFIFI Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class NOXBSAFACPX : BZPQMJVKEEL<NJGYQQMXQIH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override NJGYQQMXQIH Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x87D0F50", Offset = "0x87CF950", VA = "0x1887D0F50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x87D0F10", Offset = "0x87CF910", VA = "0x1887D0F10")]
		public NOXBSAFACPX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class HYPAYMVBZTQ : ANJTOSCXDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string CDXYIDBJHXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string QFCYGEDVRHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public AMFKYVJMYXM WRLZRPFBNDF;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x87C5050", Offset = "0x87C3A50", VA = "0x1887C5050")]
		public HYPAYMVBZTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x87CBEA0", Offset = "0x87CA8A0", VA = "0x1887CBEA0")]
		public static HYPAYMVBZTQ Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x87CC0E0", Offset = "0x87CAAE0", VA = "0x1887CC0E0", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class FVNHZHFYOAY : ANJTOSCXDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public TLTUODOJAHP TLTUODOJAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public SVRIUCOAGLS CTFDXDCNQXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public XAMVIXHDGXA VJSDQIVKXLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public TQJCZZHPRWI EHECGRJHJUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public UZHQVOUYVVV TMFDBCIUKZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color GFBDTEIGQIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode WMKTXXFPULV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double WZBLKEWNZOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool DEUTFKPWGAK;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x87C7520", Offset = "0x87C5F20", VA = "0x1887C7520")]
		public FVNHZHFYOAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x87C6BB0", Offset = "0x87C55B0", VA = "0x1887C6BB0")]
		public static FVNHZHFYOAY Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x87C70C0", Offset = "0x87C5AC0", VA = "0x1887C70C0", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
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
	public class NRXRJTXZNMY : ANJTOSCXDAN
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class ESCTXDLDNMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public HAJPTZWCSKJ XBKNLMWAWOQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader FDWAZTCOSCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<RTIRXCWROQS> LULENKICLGF;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public ESCTXDLDNMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x87C66E0", Offset = "0x87C50E0", VA = "0x1887C66E0")]
			internal RTIRXCWROQS TFYPDRRXVEP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<RTIRXCWROQS> LEIEWXIPCMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> NSYXWMTNCNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> TGMCNZYTVBB;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x87C5050", Offset = "0x87C3A50", VA = "0x1887C5050")]
		public NRXRJTXZNMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x87D0FB0", Offset = "0x87CF9B0", VA = "0x1887D0FB0")]
		public static NRXRJTXZNMY Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x87D1370", Offset = "0x87CFD70", VA = "0x1887D1370", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class KSYLFATEMGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, FKHFNJEUUXL> BLJTIKPMXAB;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static GQCBMLCGBAE IMTVJFIYKVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, AVTQJTSSWFW> JNHRAIMNNZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken XWSFLBUVKOH;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x87CE860", Offset = "0x87CD260", VA = "0x1887CE860")]
		public static FKHFNJEUUXL AZAMREQJHEM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x87CEDF0", Offset = "0x87CD7F0", VA = "0x1887CEDF0")]
		public static AVTQJTSSWFW JOIXQUOJJIS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public KSYLFATEMGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x87D02C0", Offset = "0x87CECC0", VA = "0x1887D02C0")]
		public KSYLFATEMGM(KSYLFATEMGM a, [Optional] HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x87CEB40", Offset = "0x87CD540", VA = "0x1887CEB40")]
		public void HGHTLDPCOBZ(HAJPTZWCSKJ a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x87CE9F0", Offset = "0x87CD3F0", VA = "0x1887CE9F0")]
		public void DWYNGKYASMI(string a, AVTQJTSSWFW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x87CF060", Offset = "0x87CDA60", VA = "0x1887CF060")]
		private void PRVOBYOKODC(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x87CEFA0", Offset = "0x87CD9A0", VA = "0x1887CEFA0")]
		private void KYZWBYMJOJG(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x87CEEE0", Offset = "0x87CD8E0", VA = "0x1887CEEE0")]
		private void JRRILJKNRXO(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x87CF150", Offset = "0x87CDB50", VA = "0x1887CF150")]
		internal static Dictionary<string, AVTQJTSSWFW> REGMHJDVYQV(HAJPTZWCSKJ a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x87CF720", Offset = "0x87CE120", VA = "0x1887CF720", Slot = "4")]
		public virtual void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class HAJPTZWCSKJ : KSYLFATEMGM
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class JVZGIHOIAUE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public HAJPTZWCSKJ XBKNLMWAWOQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader ZVUKPSQKXCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<IEXZETSAWVJ> LULENKICLGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<QXSDTWZKPRH> LUFXQDOFBUW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<UGLZFXIWHAP> LUAQSWUHSJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<WRLZRPFBNDF> LTVJVQAKIYE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<GFLCJGQFPRQ> LTQCYJGMZMV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<HYPAYMVBZTQ> LTKWBCMPQBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<FVNHZHFYOAY> LTFPDVSSGQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<NRXRJTXZNMY> LTAIGOYUXEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<HEOTCJBJJIU> LSVBJIEXNTL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> LSPUMBLAEIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<CZFXZURTGTF> NJHXTIEVTIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<EQNDQUCXYAN> NJNEQOYTCTT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<FLUADCVEWRS> NIXJYURBALS;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JVZGIHOIAUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x87CE5F0", Offset = "0x87CCFF0", VA = "0x1887CE5F0")]
			internal IEXZETSAWVJ TFYPDRRXVEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x87CE5E0", Offset = "0x87CCFE0", VA = "0x1887CE5E0")]
			internal QXSDTWZKPRH TFTIGKYALTG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x87CE610", Offset = "0x87CD010", VA = "0x1887CE610")]
			internal UGLZFXIWHAP TGJCYFFSOBH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x87CE600", Offset = "0x87CD000", VA = "0x1887CE600")]
			internal WRLZRPFBNDF TGDWAYLVEPY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x87CE630", Offset = "0x87CD030", VA = "0x1887CE630")]
			internal GFLCJGQFPRQ TGTQSSTNGXZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x87CE620", Offset = "0x87CD020", VA = "0x1887CE620")]
			internal HYPAYMVBZTQ TGOJVLZPXMQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x87CE650", Offset = "0x87CD050", VA = "0x1887CE650")]
			internal FVNHZHFYOAY THEENGHHZUR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x87CE640", Offset = "0x87CD040", VA = "0x1887CE640")]
			internal NRXRJTXZNMY TGYXPZNKQJI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x87CE670", Offset = "0x87CD070", VA = "0x1887CE670")]
			internal HEOTCJBJJIU THOSHTVCSRJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x87CE660", Offset = "0x87CD060", VA = "0x1887CE660")]
			internal Sampler THJLKNBFJGA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x87CE440", Offset = "0x87CCE40", VA = "0x1887CE440")]
			internal CZFXZURTGTF NUQYYIFIIGE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x87CE5C0", Offset = "0x87CCFC0", VA = "0x1887CE5C0")]
			internal EQNDQUCXYAN NUWFVOZFRRN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x87CE5D0", Offset = "0x87CCFD0", VA = "0x1887CE5D0")]
			internal FLUADCVEWRS NVBMSVTDBCW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> XKLFCXKFDTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> EFRJLHUMMCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<IEXZETSAWVJ> DEQMJBXQPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<QXSDTWZKPRH> CSAIUYBZQYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public IFYMQTZUWMM IFYMQTZUWMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<UGLZFXIWHAP> TFYOTVHNMUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<WRLZRPFBNDF> NMWNUKNHPIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<GFLCJGQFPRQ> NRVMQUQCNQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<HYPAYMVBZTQ> LUFPLICFZXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<FVNHZHFYOAY> TRWQNLWMKIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<NRXRJTXZNMY> DSXNQMDXRMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<HEOTCJBJJIU> CIXXHDRDUGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> HAWKCJNYTLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public FEXXFFGAMHL NDFBKTYMQPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<CZFXZURTGTF> KPLUTDFFVTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<EQNDQUCXYAN> DQRFIVAZOQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<FLUADCVEWRS> VRVVSRHGLSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<NJGYQQMXQIH> AQIFCWYQBYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool EZXSAQLELLF;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x87CA800", Offset = "0x87C9200", VA = "0x1887CA800")]
		public HAJPTZWCSKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x87C8BC0", Offset = "0x87C75C0", VA = "0x1887C8BC0")]
		public CZFXZURTGTF MEZBJFZOXUH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x87C7D70", Offset = "0x87C6770", VA = "0x1887C7D70")]
		public static HAJPTZWCSKJ Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x87C8C60", Offset = "0x87C7660", VA = "0x1887C8C60")]
		public void XQIXCNAGDPI(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class CZFXZURTGTF : ANJTOSCXDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<XJZDRDVDUVD> CIXXHDRDUGV;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x87C5050", Offset = "0x87C3A50", VA = "0x1887C5050")]
		public CZFXZURTGTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x87C5760", Offset = "0x87C4160", VA = "0x1887C5760")]
		public static CZFXZURTGTF Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x87C58E0", Offset = "0x87C42E0", VA = "0x1887C58E0", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class FLUADCVEWRS : ANJTOSCXDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public WLZPKTUQMIZ XJBRRMTFWMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public ISFEGYUJPCM RGTJYRDPCJH;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x87C5050", Offset = "0x87C3A50", VA = "0x1887C5050")]
		public FLUADCVEWRS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x87C6870", Offset = "0x87C5270", VA = "0x1887C6870")]
		public static FLUADCVEWRS Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x87C6A40", Offset = "0x87C5440", VA = "0x1887C6A40", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class ILGJXJPYROB : NJGYQQMXQIH
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x87C5050", Offset = "0x87C3A50", VA = "0x1887C5050")]
		public ILGJXJPYROB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x87CCE40", Offset = "0x87CB840", VA = "0x1887CCE40", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class NJGYQQMXQIH : ANJTOSCXDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string UHSPVUGWULB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color FFMWVZKQBIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string XWYJJROIJCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float HLIRSUJLFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float MEKKBCHFWYJ;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x87C5050", Offset = "0x87C3A50", VA = "0x1887C5050")]
		public NJGYQQMXQIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x87D0C90", Offset = "0x87CF690", VA = "0x1887D0C90", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class SXXQCTNMGEL : NJGYQQMXQIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x87C5050", Offset = "0x87C3A50", VA = "0x1887C5050")]
		public SXXQCTNMGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x87CCE40", Offset = "0x87CB840", VA = "0x1887CCE40", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class YMVACQAVXCP : NJGYQQMXQIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float LOEGQWQHLNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float KILJGNGFPCT;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x87DA170", Offset = "0x87D8B70", VA = "0x1887DA170")]
		public YMVACQAVXCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x87D9E70", Offset = "0x87D8870", VA = "0x1887D9E70", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface WJIHUQWBOTE
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TPOBBAMQIDH(HAJPTZWCSKJ a, UZXHFFGJITY b, [Out] RLWBXOMGKVB c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface AVTQJTSSWFW
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AVTQJTSSWFW Clone(HAJPTZWCSKJ root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class FKHFNJEUUXL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string BHFCANLNCMK;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		protected FKHFNJEUUXL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class RBUOSKQYQDY : AVTQJTSSWFW
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty XPEVOBQMFIV
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6D0", Offset = "0xD0B0D0", VA = "0x180D0C6D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x87D2AD0", Offset = "0x87D14D0", VA = "0x1887D2AD0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public RBUOSKQYQDY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class GQCBMLCGBAE : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x87C7D00", Offset = "0x87C6700", VA = "0x1887C7D00", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public GQCBMLCGBAE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class SVRIUCOAGLS : KSYLFATEMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color XCGEHIWDYRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public UZHQVOUYVVV ZKBTDGXEQZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color TMWVVEEIBLX;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x87D5F30", Offset = "0x87D4930", VA = "0x1887D5F30")]
		public SVRIUCOAGLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x87D5A30", Offset = "0x87D4430", VA = "0x1887D5A30")]
		public static SVRIUCOAGLS Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x87D5CD0", Offset = "0x87D46D0", VA = "0x1887D5CD0", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class XAMVIXHDGXA : UZHQVOUYVVV
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string MOTYCKSCXWW = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double ZGYOETDZTFY;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x87D6EF0", Offset = "0x87D58F0", VA = "0x1887D6EF0")]
		public XAMVIXHDGXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x87D9300", Offset = "0x87D7D00", VA = "0x1887D9300")]
		public new static XAMVIXHDGXA Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x87D95F0", Offset = "0x87D7FF0", VA = "0x1887D95F0", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class TQJCZZHPRWI : UZHQVOUYVVV
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string WQXUXQEWFYZ = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double AJYIVZEWEGR;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x87D6EF0", Offset = "0x87D58F0", VA = "0x1887D6EF0")]
		public TQJCZZHPRWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x87D6B40", Offset = "0x87D5540", VA = "0x1887D6B40")]
		public new static TQJCZZHPRWI Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x87D6E30", Offset = "0x87D5830", VA = "0x1887D6E30", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class TLTUODOJAHP : KSYLFATEMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color MVDUUAPSXGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public UZHQVOUYVVV HSIIRCQMWSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double TXYDPWVHCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double FHVSKOVCNQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public UZHQVOUYVVV JVXXKCWWEUI;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x87D6AD0", Offset = "0x87D54D0", VA = "0x1887D6AD0")]
		public TLTUODOJAHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x87D64D0", Offset = "0x87D4ED0", VA = "0x1887D64D0")]
		public static TLTUODOJAHP Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x87D6840", Offset = "0x87D5240", VA = "0x1887D6840", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class RTIRXCWROQS : KSYLFATEMGM
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class UONXUWZERAT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader FDWAZTCOSCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public HAJPTZWCSKJ XBKNLMWAWOQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<TULYRSXOBNY> LULENKICLGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<TULYRSXOBNY> LUAQSWUHSJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, TULYRSXOBNY>> LUFXQDOFBUW;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public UONXUWZERAT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x87D8490", Offset = "0x87D6E90", VA = "0x1887D8490")]
			internal TULYRSXOBNY TFYPDRRXVEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x87D83E0", Offset = "0x87D6DE0", VA = "0x1887D83E0")]
			internal Dictionary<string, TULYRSXOBNY> TFTIGKYALTG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x87D8560", Offset = "0x87D6F60", VA = "0x1887D8560")]
			internal TULYRSXOBNY TGJCYFFSOBH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, TULYRSXOBNY> LFGHPHMMIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public TULYRSXOBNY KUUYPZTODZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public JZJXLRFCXOQ DMNWOMXIVEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode GJZIEZBJWHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, TULYRSXOBNY>> JWVRYPWHURY;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x87D3F20", Offset = "0x87D2920", VA = "0x1887D3F20")]
		public RTIRXCWROQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x87D3FC0", Offset = "0x87D29C0", VA = "0x1887D3FC0")]
		public RTIRXCWROQS(RTIRXCWROQS a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x87D3540", Offset = "0x87D1F40", VA = "0x1887D3540")]
		public static int[] PILNREWZWVC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x87D3370", Offset = "0x87D1D70", VA = "0x1887D3370")]
		public static int[] HBLFMVDDKTO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x87D2CD0", Offset = "0x87D16D0", VA = "0x1887D2CD0")]
		public static int[] DPKWTLTBNPQ(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x87D3CD0", Offset = "0x87D26D0", VA = "0x1887D3CD0")]
		public static int[] YEKLUZATETA(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x87D2C20", Offset = "0x87D1620", VA = "0x1887D2C20")]
		public static int[] DPEBGFGLMMJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x87D34D0", Offset = "0x87D1ED0", VA = "0x1887D34D0")]
		public static int[] JIZEZATOKYQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x87D32E0", Offset = "0x87D1CE0", VA = "0x1887D32E0")]
		public static int[] FLOWCXHZIKS(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x87D35E0", Offset = "0x87D1FE0", VA = "0x1887D35E0")]
		public static int[] VXKYHHSPLUJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x87D3C40", Offset = "0x87D2640", VA = "0x1887D3C40")]
		public static int[] XSZQKNNKCPZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x87D2E90", Offset = "0x87D1890", VA = "0x1887D2E90")]
		public static RTIRXCWROQS Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x87D3650", Offset = "0x87D2050", VA = "0x1887D3650", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class OQENZAWGVPT
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] QHRCINCSBKG;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] SEPYTNPFUCP;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] NJZBFLFTSFC;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] KFHZHMVGDNS;
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
	public class HEOTCJBJJIU : ANJTOSCXDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool EXTTZYTFRNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public TYQIDDYZXQK HMSWJTAYWFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<XJZDRDVDUVD> JDMGHFSWVRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public LSVPPLRWNBS EQNDQUCXYAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public AKLQENCIAHR CAKKXOYODZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public SLVMOGNGDEY SEPNJECHARX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion TYYYGKBREIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 ZGYOETDZTFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 ZGZTOCXFHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> NSYXWMTNCNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public NOXBSAFACPX OYPPTNTUMKE;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x87CBD70", Offset = "0x87CA770", VA = "0x1887CBD70")]
		public HEOTCJBJJIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x87CA850", Offset = "0x87C9250", VA = "0x1887CA850")]
		public static HEOTCJBJJIU Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x87CB180", Offset = "0x87C9B80", VA = "0x1887CB180", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : ANJTOSCXDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode JRLQOZNEHYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode CANAVKJGIXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode CMNUGIQYJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode CMTBDPKVSUU;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x87D6460", Offset = "0x87D4E60", VA = "0x1887D6460")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x87D5FA0", Offset = "0x87D49A0", VA = "0x1887D5FA0")]
		public static Sampler Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x87D6270", Offset = "0x87D4C70", VA = "0x1887D6270", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
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
	public class EQNDQUCXYAN : ANJTOSCXDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public TULYRSXOBNY IWXSDNXDDYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public XJZDRDVDUVD HNXNBVBZLKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<XJZDRDVDUVD> NOOJPWZAHXX;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x87C6630", Offset = "0x87C5030", VA = "0x1887C6630")]
		public EQNDQUCXYAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x87C5FC0", Offset = "0x87C49C0", VA = "0x1887C5FC0")]
		public static EQNDQUCXYAN Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x87C6320", Offset = "0x87C4D20", VA = "0x1887C6320", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class UZHQVOUYVVV : KSYLFATEMGM
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string MIVPOAAOQUI = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string JUTHUPAHQCS = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AAUCBQWFIFI UPNTWCAUUUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int QHRCINCSBKG;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x87D89E0", Offset = "0x87D73E0", VA = "0x1887D89E0")]
		public UZHQVOUYVVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x87D8A30", Offset = "0x87D7430", VA = "0x1887D8A30")]
		public UZHQVOUYVVV(UZHQVOUYVVV a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x87D8630", Offset = "0x87D7030", VA = "0x1887D8630")]
		public static UZHQVOUYVVV Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x87D8980", Offset = "0x87D7380", VA = "0x1887D8980", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x87D88B0", Offset = "0x87D72B0", VA = "0x1887D88B0")]
		public void EZTVCENAKUX(JsonWriter a)
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
	public class PJFXFDNDRUY
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double RYYLTDHVNBM;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double YUFRFPZTHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double LXWPLFADLFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double IHRVBPUTOJR;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x87D2200", Offset = "0x87D0C00", VA = "0x1887D2200")]
		public PJFXFDNDRUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x87D1D60", Offset = "0x87D0760", VA = "0x1887D1D60")]
		public static PJFXFDNDRUY Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x87D1FA0", Offset = "0x87D09A0", VA = "0x1887D1FA0")]
		public void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class RXZHUQQPPFA : ANJTOSCXDAN
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color VBVWOPFOGIJ;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double ZAXLUUMMWYH;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double ZKYHDDBIQID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType MERZPCICCKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color SEPYTNPFUCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double LPGZJFWUZYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double YGIVWZIRABH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public PJFXFDNDRUY PJFXFDNDRUY;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x87D55B0", Offset = "0x87D3FB0", VA = "0x1887D55B0")]
		public RXZHUQQPPFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x87D5490", Offset = "0x87D3E90", VA = "0x1887D5490")]
		public RXZHUQQPPFA(RXZHUQQPPFA a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x87D4BA0", Offset = "0x87D35A0", VA = "0x1887D4BA0")]
		public static RXZHUQQPPFA Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x87D4F90", Offset = "0x87D3990", VA = "0x1887D4F90")]
		public static RXZHUQQPPFA Deserialize(HAJPTZWCSKJ root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x87D50B0", Offset = "0x87D3AB0", VA = "0x1887D50B0", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class TZNAIYJXFZC : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<NJGYQQMXQIH> EIOPUXTIDOZ;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD13870", Offset = "0xD12270", VA = "0x180D13870")]
		public TZNAIYJXFZC(IList<NJGYQQMXQIH> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x87D7320", Offset = "0x87D5D20", VA = "0x1887D7320", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x87D72B0", Offset = "0x87D5CB0", VA = "0x1887D72B0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class JTMBOBAXOFS : AVTQJTSSWFW, WJIHUQWBOTE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<RXZHUQQPPFA> AQIFCWYQBYN;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x87CE3C0", Offset = "0x87CCDC0", VA = "0x1887CE3C0")]
		public JTMBOBAXOFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x87CD550", Offset = "0x87CBF50", VA = "0x1887CD550", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x87CDEE0", Offset = "0x87CC8E0", VA = "0x1887CDEE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x87CD7D0", Offset = "0x87CC1D0", VA = "0x1887CD7D0")]
		private static string[] GYIINDREGBA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x87CDA80", Offset = "0x87CC480", VA = "0x1887CDA80")]
		private static RLWBXOMGKVB.ImportValuesConversion QXCHHINEUII(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x87CDFD0", Offset = "0x87CC9D0", VA = "0x1887CDFD0", Slot = "6")]
		public bool TPOBBAMQIDH(HAJPTZWCSKJ a, UZXHFFGJITY b, [Out] RLWBXOMGKVB c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class AWTSAXRMNRN : BZPQMJVKEEL<RXZHUQQPPFA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override RXZHUQQPPFA Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x87C5610", Offset = "0x87C4010", VA = "0x1887C5610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x87C55D0", Offset = "0x87C3FD0", VA = "0x1887C55D0")]
		public AWTSAXRMNRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x87C54F0", Offset = "0x87C3EF0", VA = "0x1887C54F0")]
		public static AWTSAXRMNRN Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class SQTNMDLFWHO : AVTQJTSSWFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AWTSAXRMNRN NOXBSAFACPX;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xD13870", Offset = "0xD12270", VA = "0x180D13870")]
		public SQTNMDLFWHO(AWTSAXRMNRN a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x87D5970", Offset = "0x87D4370", VA = "0x1887D5970")]
		public SQTNMDLFWHO(int a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x87D57F0", Offset = "0x87D41F0", VA = "0x1887D57F0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x87D5870", Offset = "0x87D4270", VA = "0x1887D5870", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class IVXPTYYTNGB : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x87CD4D0", Offset = "0x87CBED0", VA = "0x1887CD4D0")]
		public IVXPTYYTNGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x87CCFD0", Offset = "0x87CB9D0", VA = "0x1887CCFD0", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
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
