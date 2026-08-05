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
		[Cpp2IlInjected.Address(RVA = "0x863E680", Offset = "0x863D080", VA = "0x18863E680", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x863E5D0", Offset = "0x863CFD0", VA = "0x18863E5D0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
			[Cpp2IlInjected.Address(RVA = "0x863A460", Offset = "0x8638E60", VA = "0x18863A460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x863BD90", Offset = "0x863A790", VA = "0x18863BD90")]
		public static void YTPAMPGFMPH(this HEOTCJBJJIU a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x863B010", Offset = "0x8639A10", VA = "0x18863B010")]
		public static void ULOPFHALTZJ(this HEOTCJBJJIU a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8639EB0", Offset = "0x86388B0", VA = "0x188639EB0")]
		public static void JLLEMZGEEYS(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86392F0", Offset = "0x8637CF0", VA = "0x1886392F0")]
		public static GLTF.Math.Vector4 CJMYJBCERXQ(this AKLQENCIAHR a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8639670", Offset = "0x8638070", VA = "0x188639670")]
		public static UnityEngine.Quaternion DNOVXXXVXTH(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8639800", Offset = "0x8638200", VA = "0x188639800")]
		public static UnityEngine.Quaternion DNOVXXXVXTH(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x863A620", Offset = "0x8639020", VA = "0x18863A620")]
		public static GLTF.Math.Quaternion OUENQIFDLQT(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8638C90", Offset = "0x8637690", VA = "0x188638C90")]
		public static Matrix4x4 APIEHSPEJGQ(this AKLQENCIAHR a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8638EB0", Offset = "0x86378B0", VA = "0x188638EB0")]
		public static Matrix4x4 APIEHSPEJGQ(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x863AA60", Offset = "0x8639460", VA = "0x18863AA60")]
		public static AKLQENCIAHR RGWYLHLUBOW(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x863BB20", Offset = "0x863A520", VA = "0x18863BB20")]
		public static UnityEngine.Vector3 VNEAQAOSASZ(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x863BA40", Offset = "0x863A440", VA = "0x18863BA40")]
		public static UnityEngine.Vector3 VNEAQAOSASZ(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x863A4F0", Offset = "0x8638EF0", VA = "0x18863A4F0")]
		public static GLTF.Math.Vector3 MINPAEHSDTZ(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x863ADD0", Offset = "0x86397D0", VA = "0x18863ADD0")]
		public static GLTF.Math.Vector3 SXQVQLJOLRU(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1357A00", Offset = "0x1356400", VA = "0x181357A00")]
		public static GLTF.Math.Vector4 WOKAEYTTVIR(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x863B780", Offset = "0x863A180", VA = "0x18863B780")]
		public static Matrix4x4 VGQDEHHNNVL(this AKLQENCIAHR a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x863B510", Offset = "0x8639F10", VA = "0x18863B510")]
		public static Matrix4x4 VGQDEHHNNVL(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x863A7E0", Offset = "0x86391E0", VA = "0x18863A7E0")]
		public static AKLQENCIAHR QQOVCMPYUKX(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x863AFF0", Offset = "0x86399F0", VA = "0x18863AFF0")]
		public static UnityEngine.Vector2 ULMBWMJQUYN(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x863AFF0", Offset = "0x86399F0", VA = "0x18863AFF0")]
		public static UnityEngine.Vector2 ULMBWMJQUYN(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x863AF20", Offset = "0x8639920", VA = "0x18863AF20")]
		public static void ULMBWMJQUYN(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x863BC40", Offset = "0x863A640", VA = "0x18863BC40")]
		public static UnityEngine.Vector3 YRJFKRMVSPS(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D70920", Offset = "0x1D6F320", VA = "0x181D70920")]
		public static UnityEngine.Vector3 YRJFKRMVSPS(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x863BCA0", Offset = "0x863A6A0", VA = "0x18863BCA0")]
		public static void YRJFKRMVSPS(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1357A00", Offset = "0x1356400", VA = "0x181357A00")]
		public static UnityEngine.Vector4 GVPMOQPZOZN(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1357A00", Offset = "0x1356400", VA = "0x181357A00")]
		public static UnityEngine.Vector4 GVPMOQPZOZN(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8639D30", Offset = "0x8638730", VA = "0x188639D30")]
		public static UnityEngine.Vector4[] GVPMOQPZOZN(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8639C20", Offset = "0x8638620", VA = "0x188639C20")]
		public static void GVPMOQPZOZN(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x863A280", Offset = "0x8638C80", VA = "0x18863A280")]
		public static UnityEngine.Color KNBNWRKQSUR(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x863A320", Offset = "0x8638D20", VA = "0x18863A320")]
		public static void KNBNWRKQSUR(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x863A280", Offset = "0x8638C80", VA = "0x18863A280")]
		public static UnityEngine.Color KNBNWRKQSUR(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1357A00", Offset = "0x1356400", VA = "0x181357A00")]
		public static UnityEngine.Color TWPZFGKWASM(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x863AE10", Offset = "0x8639810", VA = "0x18863AE10")]
		public static void TWPZFGKWASM(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1357A00", Offset = "0x1356400", VA = "0x181357A00")]
		public static UnityEngine.Color TWPZFGKWASM(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8638C60", Offset = "0x8637660", VA = "0x188638C60")]
		public static GLTF.Math.Color ALJCABKSEYC(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x863A760", Offset = "0x8639160", VA = "0x18863A760")]
		public static GLTF.Math.Color PTIVIHNRYYF(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x863C4D0", Offset = "0x863AED0", VA = "0x18863C4D0")]
		public static GLTF.Math.Color ZGMHXHFVSYN(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8639930", Offset = "0x8638330", VA = "0x188639930")]
		public static UnityEngine.Color[] ENDGPBMXXSQ(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8639E30", Offset = "0x8638830", VA = "0x188639E30")]
		public static int[] HXBFINASCTJ(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x863A9B0", Offset = "0x86393B0", VA = "0x18863A9B0")]
		public static UnityEngine.Vector2[] RBUTKYAXVUE(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8639510", Offset = "0x8637F10", VA = "0x188639510")]
		public static void CTSZKISBXAH(OARRAAVFWOH a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8639A50", Offset = "0x8638450", VA = "0x188639A50")]
		public static UnityEngine.Vector3[] EYRFUWLXLJD(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x863C330", Offset = "0x863AD30", VA = "0x18863C330")]
		public static UnityEngine.Vector4[] ZFBJFHICTJK(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8639BB0", Offset = "0x86385B0", VA = "0x188639BB0")]
		public static void GQHNFUDOAXV(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x863ADA0", Offset = "0x86397A0", VA = "0x18863ADA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray UITRUXZQSJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8643DF0", Offset = "0x86427F0", VA = "0x188643DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> QBOWRLOYTQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xEAEE00", Offset = "0xEAD800", VA = "0x180EAEE00")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xFA1C70", Offset = "0xFA0670", VA = "0x180FA1C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint KJUGRAXUWPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCDD9E0", Offset = "0xCDC3E0", VA = "0x180CDD9E0")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCDD820", Offset = "0xCDC220", VA = "0x180CDD820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8643E00", Offset = "0x8642800", VA = "0x188643E00")]
		public OARRAAVFWOH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x862FFE0", Offset = "0x862E9E0", VA = "0x18862FFE0")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8630040", Offset = "0x862EA40", VA = "0x188630040")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public XXTYLPQTJDX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8647130", Offset = "0x8645B30", VA = "0x188647130")]
			internal int? XNQKCILJHAM(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8646FD0", Offset = "0x86459D0", VA = "0x188646FD0")]
			internal int? EKOJLCVOLKT(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8647060", Offset = "0x8645A60", VA = "0x188647060")]
			internal bool QHTCKXCVCNZ(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8631F90", Offset = "0x8630990", VA = "0x188631F90")]
		private static void INZWVMCKIZV(NumericArray a, OARRAAVFWOH b, OARRAAVFWOH c, OARRAAVFWOH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8630CB0", Offset = "0x862F6B0", VA = "0x188630CB0")]
		public static void IBAMCALAWNG(Dictionary<string, OARRAAVFWOH> a, Dictionary<string, (OARRAAVFWOH sparseIndices, OARRAAVFWOH sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8632500", Offset = "0x8630F00", VA = "0x188632500")]
		public static void KITITIHDZVO(Dictionary<string, OARRAAVFWOH> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8632F70", Offset = "0x8631970", VA = "0x188632F70")]
		public static void RCQXMZNSOVV(OARRAAVFWOH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86329E0", Offset = "0x86313E0", VA = "0x1886329E0")]
		public static void OBSVJNPSUDZ(Dictionary<string, List<OARRAAVFWOH>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8630AC0", Offset = "0x862F4C0", VA = "0x188630AC0")]
		private static void EVCGCRYBHXR(OARRAAVFWOH a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8630BF0", Offset = "0x862F5F0", VA = "0x188630BF0")]
		internal static void EVCGCRYBHXR(WRLZRPFBNDF a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8633070", Offset = "0x8631A70", VA = "0x188633070")]
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
			[Cpp2IlInjected.Address(RVA = "0xF535F0", Offset = "0xF51FF0", VA = "0x180F535F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x15AB7E0", Offset = "0x15AA1E0", VA = "0x1815AB7E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30B9B60", Offset = "0x30B8560", VA = "0x1830B9B60")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30B9B70", Offset = "0x30B8570", VA = "0x1830B9B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x8647A90", Offset = "0x8646490", VA = "0x188647A90")]
		public static void VPPSJHFAMVP(Stream a, [Out] HAJPTZWCSKJ b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8647800", Offset = "0x8646200", VA = "0x188647800")]
		public static ChunkInfo UDFKRSFORJT(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8647630", Offset = "0x8646030", VA = "0x188647630")]
		public static GLBHeader GYRLDXYPZAL(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8647570", Offset = "0x8645F70", VA = "0x188647570")]
		public static bool EZXSAQLELLF(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8647C50", Offset = "0x8646650", VA = "0x188647C50")]
		public static ChunkInfo YMXLFTKZYMM(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x86472D0", Offset = "0x8645CD0", VA = "0x1886472D0")]
		private static void BJXJTUQBDFQ(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8647770", Offset = "0x8646170", VA = "0x188647770")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD0110", Offset = "0xCCEB10", VA = "0x180CD0110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCDFF30", Offset = "0xCDE930", VA = "0x180CDFF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int OYCHLVRRQHS
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xDF0AD0", Offset = "0xDEF4D0", VA = "0x180DF0AD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xDF0A00", Offset = "0xDEF400", VA = "0x180DF0A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string PCGESYSELIL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EKHWLTFOGLY
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCDB270", Offset = "0xCD9C70", VA = "0x180CDB270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCDB290", Offset = "0xCD9C90", VA = "0x180CDB290")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public UZXHFFGJITY PWTAPHSZDYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCD27E0", Offset = "0xCD11E0", VA = "0x180CD27E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8646340", Offset = "0x8644D40", VA = "0x188646340")]
		public string RAJPEDXBWDY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x86465A0", Offset = "0x8644FA0", VA = "0x1886465A0")]
		public UZXHFFGJITY YRVKDHSSBTU(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x86465C0", Offset = "0x8644FC0", VA = "0x1886465C0")]
		private UZXHFFGJITY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8646620", Offset = "0x8645020", VA = "0x188646620")]
		public UZXHFFGJITY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5452010", Offset = "0x5450A10", VA = "0x185452010")]
		[CompilerGenerated]
		internal static string MMMAGPZMRGS(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8646300", Offset = "0x8644D00", VA = "0x188646300")]
		[CompilerGenerated]
		internal static bool BMRIVTPDRGV([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x86463C0", Offset = "0x8644DC0", VA = "0x1886463C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8647F80", Offset = "0x8646980", VA = "0x188647F80")]
		public static int[] UNOVRMGKXPZ(this HAJPTZWCSKJ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8647E30", Offset = "0x8646830", VA = "0x188647E30")]
		public static int[] RAUMJWHORPT(this HAJPTZWCSKJ a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class MRDMBZFLKTR
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8642A00", Offset = "0x8641400", VA = "0x188642A00")]
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
			[Cpp2IlInjected.Address(RVA = "0x8645C90", Offset = "0x8644690", VA = "0x188645C90", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8645CD0", Offset = "0x86446D0", VA = "0x188645CD0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8645CD0", Offset = "0x86446D0", VA = "0x188645CD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8645CF0", Offset = "0x86446F0", VA = "0x188645CF0", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8645D10", Offset = "0x8644710", VA = "0x188645D10", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8645D30", Offset = "0x8644730", VA = "0x188645D30", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8645A20", Offset = "0x8644420", VA = "0x188645A20")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x86457E0", Offset = "0x86441E0", VA = "0x1886457E0", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x86458B0", Offset = "0x86442B0", VA = "0x1886458B0", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8645910", Offset = "0x8644310", VA = "0x188645910", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8645820", Offset = "0x8644220", VA = "0x188645820", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x86459E0", Offset = "0x86443E0", VA = "0x1886459E0", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8645950", Offset = "0x8644350", VA = "0x188645950")]
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
			[Cpp2IlInjected.Address(RVA = "0x862F2A0", Offset = "0x862DCA0", VA = "0x18862F2A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color KWCQGBBNUIB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x862F570", Offset = "0x862DF70", VA = "0x18862F570")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color SBSOVVPTTBD
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x862F580", Offset = "0x862DF80", VA = "0x18862F580")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2DCF0E0", Offset = "0x2DCDAE0", VA = "0x182DCF0E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1850E70", Offset = "0x184F870", VA = "0x181850E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2E2CFD0", Offset = "0x2E2B9D0", VA = "0x182E2CFD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2E2CFE0", Offset = "0x2E2B9E0", VA = "0x182E2CFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7E00", Offset = "0x2BA6800", VA = "0x182BA7E00")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x32B6490", Offset = "0x32B4E90", VA = "0x1832B6490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x14EEF00", Offset = "0x14ED900", VA = "0x1814EEF00")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x14EEF10", Offset = "0x14ED910", VA = "0x1814EEF10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B69AE0", Offset = "0x2B684E0", VA = "0x182B69AE0")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x862F2C0", Offset = "0x862DCC0", VA = "0x18862F2C0", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x862F370", Offset = "0x862DD70", VA = "0x18862F370", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x862F410", Offset = "0x862DE10", VA = "0x18862F410", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x862F4C0", Offset = "0x862DEC0", VA = "0x18862F4C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x862D1F0", Offset = "0x862BBF0", VA = "0x18862D1F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x862D2E0", Offset = "0x862BCE0", VA = "0x18862D2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float QGNAXEVJPFI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x862D3A0", Offset = "0x862BDA0", VA = "0x18862D3A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x862D430", Offset = "0x862BE30", VA = "0x18862D430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float JGGJTABBSJR
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x862CAD0", Offset = "0x862B4D0", VA = "0x18862CAD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x862CF80", Offset = "0x862B980", VA = "0x18862CF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float FEBTLUGFDQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x862D100", Offset = "0x862BB00", VA = "0x18862D100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x862D010", Offset = "0x862BA10", VA = "0x18862D010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float XGYYYQJOVMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x862D1C0", Offset = "0x862BBC0", VA = "0x18862D1C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x862D2B0", Offset = "0x862BCB0", VA = "0x18862D2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float QGHTZYBMFTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x862D340", Offset = "0x862BD40", VA = "0x18862D340")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x862D3D0", Offset = "0x862BDD0", VA = "0x18862D3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JGLQQGUZBVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x862CB30", Offset = "0x862B530", VA = "0x18862CB30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x862CFE0", Offset = "0x862B9E0", VA = "0x18862CFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float FERODONXFYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x862D130", Offset = "0x862BB30", VA = "0x18862D130")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x862D040", Offset = "0x862BA40", VA = "0x18862D040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float XHEFVXDMEXR
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x862D190", Offset = "0x862BB90", VA = "0x18862D190")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x862D280", Offset = "0x862BC80", VA = "0x18862D280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float QGCNCRHOWIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x862D370", Offset = "0x862BD70", VA = "0x18862D370")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x862D400", Offset = "0x862BE00", VA = "0x18862D400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float JGQXNNOWLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x862CB00", Offset = "0x862B500", VA = "0x18862CB00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x862CFB0", Offset = "0x862B9B0", VA = "0x18862CFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float FEMHGHTZWMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x862D160", Offset = "0x862BB60", VA = "0x18862D160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x862D070", Offset = "0x862BA70", VA = "0x18862D070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float XGOLECVUCPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x862D220", Offset = "0x862BC20", VA = "0x18862D220")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x862D250", Offset = "0x862BC50", VA = "0x18862D250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float QHNJJMQWKKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x862D310", Offset = "0x862BD10", VA = "0x18862D310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x862D460", Offset = "0x862BE60", VA = "0x18862D460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float JGWEKUITURS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x862CB60", Offset = "0x862B560", VA = "0x18862CB60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x862CF50", Offset = "0x862B950", VA = "0x18862CF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float FDLYTZYNBHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x862D0D0", Offset = "0x862BAD0", VA = "0x18862D0D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x862D0A0", Offset = "0x862BAA0", VA = "0x18862D0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x862D570", Offset = "0x862BF70", VA = "0x18862D570")]
		public AKLQENCIAHR(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x862CB90", Offset = "0x862B590", VA = "0x18862CB90", Slot = "4")]
		public bool Equals(AKLQENCIAHR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x862CE50", Offset = "0x862B850", VA = "0x18862CE50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x10C7C20", Offset = "0x10C6620", VA = "0x1810C7C20", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DCF0E0", Offset = "0x2DCDAE0", VA = "0x182DCF0E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x1850E70", Offset = "0x184F870", VA = "0x181850E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2E2CFD0", Offset = "0x2E2B9D0", VA = "0x182E2CFD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2E2CFE0", Offset = "0x2E2B9E0", VA = "0x182E2CFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7E00", Offset = "0x2BA6800", VA = "0x182BA7E00")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32B6490", Offset = "0x32B4E90", VA = "0x1832B6490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x14EEF00", Offset = "0x14ED900", VA = "0x1814EEF00")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x14EEF10", Offset = "0x14ED910", VA = "0x1814EEF10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8644B90", Offset = "0x8643590", VA = "0x188644B90")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x86447F0", Offset = "0x86431F0", VA = "0x1886447F0", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8644910", Offset = "0x8643310", VA = "0x188644910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x86449C0", Offset = "0x86433C0", VA = "0x1886449C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8644AA0", Offset = "0x86434A0", VA = "0x188644AA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DCF0E0", Offset = "0x2DCDAE0", VA = "0x182DCF0E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1850E70", Offset = "0x184F870", VA = "0x181850E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2E2CFD0", Offset = "0x2E2B9D0", VA = "0x182E2CFD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2E2CFE0", Offset = "0x2E2B9E0", VA = "0x182E2CFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1039750", Offset = "0x1038150", VA = "0x181039750")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x86469C0", Offset = "0x86453C0", VA = "0x1886469C0")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x86467D0", Offset = "0x86451D0", VA = "0x1886467D0", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8646830", Offset = "0x8645230", VA = "0x188646830", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8646910", Offset = "0x8645310", VA = "0x188646910", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8646960", Offset = "0x8645360", VA = "0x188646960")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DCF0E0", Offset = "0x2DCDAE0", VA = "0x182DCF0E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1850E70", Offset = "0x184F870", VA = "0x181850E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2E2CFD0", Offset = "0x2E2B9D0", VA = "0x182E2CFD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2E2CFE0", Offset = "0x2E2B9E0", VA = "0x182E2CFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7E00", Offset = "0x2BA6800", VA = "0x182BA7E00")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32B6490", Offset = "0x32B4E90", VA = "0x1832B6490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8646D80", Offset = "0x8645780", VA = "0x188646D80")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x86469E0", Offset = "0x86453E0", VA = "0x1886469E0", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8646AC0", Offset = "0x86454C0", VA = "0x188646AC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8646B80", Offset = "0x8645580", VA = "0x188646B80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8646C30", Offset = "0x8645630", VA = "0x188646C30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DCF0E0", Offset = "0x2DCDAE0", VA = "0x182DCF0E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1850E70", Offset = "0x184F870", VA = "0x181850E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E2CFD0", Offset = "0x2E2B9D0", VA = "0x182E2CFD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2E2CFE0", Offset = "0x2E2B9E0", VA = "0x182E2CFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7E00", Offset = "0x2BA6800", VA = "0x182BA7E00")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x32B6490", Offset = "0x32B4E90", VA = "0x1832B6490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x14EEF00", Offset = "0x14ED900", VA = "0x1814EEF00")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x14EEF10", Offset = "0x14ED910", VA = "0x1814EEF10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B69AE0", Offset = "0x2B684E0", VA = "0x182B69AE0")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x862F2C0", Offset = "0x862DCC0", VA = "0x18862F2C0", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8646E00", Offset = "0x8645800", VA = "0x188646E00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x862F410", Offset = "0x862DE10", VA = "0x18862F410", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x8644450", Offset = "0x8642E50", VA = "0x188644450")]
		public static void MSBRWVQENMW(this JObject a, string b, UZHQVOUYVVV c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class MRDMBZFLKTR
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8643700", Offset = "0x8642100", VA = "0x188643700")]
		public static List<string> PUGLKMDYOVD(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8642E60", Offset = "0x8641860", VA = "0x188642E60")]
		public static List<double> KJPXXDBHIMB(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8642560", Offset = "0x8640F60", VA = "0x188642560")]
		public static List<int> FAJKNHNYHEY(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C32330", Offset = "0x3C30D30", VA = "0x183C32330")]
		public static List<a> RCXMDCUEAZW<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8642010", Offset = "0x8640A10", VA = "0x188642010")]
		public static UZHQVOUYVVV AQAYIRJBIOS(this JToken a, HAJPTZWCSKJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8643CB0", Offset = "0x86426B0", VA = "0x188643CB0")]
		public static int YIQJJJCMWSM(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8643B70", Offset = "0x8642570", VA = "0x188643B70")]
		public static double RBMXSCTJQOG(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8642720", Offset = "0x8641120", VA = "0x188642720")]
		public static GLTF.Math.Color FSJMTMXMNQN(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8643020", Offset = "0x8641A20", VA = "0x188643020")]
		public static GLTF.Math.Color MSZMEPRRYRU(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x86422C0", Offset = "0x8640CC0", VA = "0x1886422C0")]
		public static GLTF.Math.Color DTOLXVPQVAW(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x86438B0", Offset = "0x86422B0", VA = "0x1886438B0")]
		public static GLTF.Math.Vector3 QHGPOWPDQLG(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8643290", Offset = "0x8641C90", VA = "0x188643290")]
		public static GLTF.Math.Vector2 MYCRFRMVATM(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x86434A0", Offset = "0x8641EA0", VA = "0x1886434A0")]
		public static GLTF.Math.Vector3 MYHYCYGSKEV(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8642B50", Offset = "0x8641550", VA = "0x188642B50")]
		public static GLTF.Math.Quaternion IZQGNZRJNTG(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3C31D20", Offset = "0x3C30720", VA = "0x183C31D20")]
		public static Dictionary<string, b> JKBMQSRRGEU<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C32680", Offset = "0x3C31080", VA = "0x183C32680")]
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
		[Cpp2IlInjected.Address(RVA = "0x862FA60", Offset = "0x862E460", VA = "0x18862FA60", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x862F9E0", Offset = "0x862E3E0", VA = "0x18862F9E0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class OJFNNSTXVZI : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8643F00", Offset = "0x8642900", VA = "0x188643F00")]
		public OJFNNSTXVZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8643E30", Offset = "0x8642830", VA = "0x188643E30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x862F8A0", Offset = "0x862E2A0", VA = "0x18862F8A0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x862F960", Offset = "0x862E360", VA = "0x18862F960")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JOXUKJQLBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8638940", Offset = "0x8637340", VA = "0x188638940")]
			internal TULYRSXOBNY TFYPDRRXVEP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x862FF90", Offset = "0x862E990", VA = "0x18862FF90")]
		public GJXIUAVJPLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x862FE00", Offset = "0x862E800", VA = "0x18862FE00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		public EXT_texture_exr(ISFEGYUJPCM source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x862FAB0", Offset = "0x862E4B0", VA = "0x18862FAB0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x862FB20", Offset = "0x862E520", VA = "0x18862FB20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class AQHLKMBKLSF : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x862D940", Offset = "0x862C340", VA = "0x18862D940")]
		public AQHLKMBKLSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x862D820", Offset = "0x862C220", VA = "0x18862D820", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x862E840", Offset = "0x862D240", VA = "0x18862E840", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x862E800", Offset = "0x862D200", VA = "0x18862E800")]
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
			[Cpp2IlInjected.Address(RVA = "0x862E9D0", Offset = "0x862D3D0", VA = "0x18862E9D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x862E990", Offset = "0x862D390", VA = "0x18862E990")]
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
			[Cpp2IlInjected.Address(RVA = "0x862E6B0", Offset = "0x862D0B0", VA = "0x18862E6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x862E670", Offset = "0x862D070", VA = "0x18862E670")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x862E590", Offset = "0x862CF90", VA = "0x18862E590")]
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
		[Cpp2IlInjected.Address(RVA = "0x863E2F0", Offset = "0x863CCF0", VA = "0x18863E2F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x863DEF0", Offset = "0x863C8F0", VA = "0x18863DEF0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x863DF60", Offset = "0x863C960", VA = "0x18863DF60")]
		public static KHR_SceneAudioEmittersRef Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x863E550", Offset = "0x863CF50", VA = "0x18863E550")]
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
			[Cpp2IlInjected.Address(RVA = "0x863DEC0", Offset = "0x863C8C0", VA = "0x18863DEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x863DDA0", Offset = "0x863C7A0", VA = "0x18863DDA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x863DB90", Offset = "0x863C590", VA = "0x18863DB90", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x863DC00", Offset = "0x863C600", VA = "0x18863DC00")]
		public static KHR_NodeAudioEmitterRef Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
		[Cpp2IlInjected.Address(RVA = "0x8633C10", Offset = "0x8632610", VA = "0x188633C10")]
		public JObject XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8633510", Offset = "0x8631F10", VA = "0x188633510")]
		public static HCGVINBXVVS Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
		[Cpp2IlInjected.Address(RVA = "0x863D1E0", Offset = "0x863BBE0", VA = "0x18863D1E0", Slot = "5")]
		public virtual JObject XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x863CCE0", Offset = "0x863B6E0", VA = "0x18863CCE0")]
		public static KHR_AudioEmitter Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x863D580", Offset = "0x863BF80", VA = "0x18863D580")]
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
		[Cpp2IlInjected.Address(RVA = "0x863D960", Offset = "0x863C360", VA = "0x18863D960")]
		public JObject XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x863D600", Offset = "0x863C000", VA = "0x18863D600")]
		public static KHR_AudioSource Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8638800", Offset = "0x8637200", VA = "0x188638800")]
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
		[Cpp2IlInjected.Address(RVA = "0x863CBB0", Offset = "0x863B5B0", VA = "0x18863CBB0")]
		public JObject XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x863C950", Offset = "0x863B350", VA = "0x18863C950")]
		public static KHR_AudioData Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8638800", Offset = "0x8637200", VA = "0x188638800")]
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
		[Cpp2IlInjected.Address(RVA = "0x863E810", Offset = "0x863D210", VA = "0x18863E810", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x863E780", Offset = "0x863D180", VA = "0x18863E780", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x863EF40", Offset = "0x863D940", VA = "0x18863EF40")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ARGHISKFVWL : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x862E540", Offset = "0x862CF40", VA = "0x18862E540")]
		public ARGHISKFVWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x862D990", Offset = "0x862C390", VA = "0x18862D990", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863F110", Offset = "0x863DB10", VA = "0x18863F110", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x863F050", Offset = "0x863DA50", VA = "0x18863F050", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x863F160", Offset = "0x863DB60", VA = "0x18863F160")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JOXUKJQLBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x86389F0", Offset = "0x86373F0", VA = "0x1886389F0")]
			internal int TFYPDRRXVEP()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8645FF0", Offset = "0x86449F0", VA = "0x188645FF0")]
		public UGVLZOYXHJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8645DE0", Offset = "0x86447E0", VA = "0x188645DE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863F260", Offset = "0x863DC60", VA = "0x18863F260", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x863F1E0", Offset = "0x863DBE0", VA = "0x18863F1E0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class JRJNOPPGBEC : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8638C10", Offset = "0x8637610", VA = "0x188638C10")]
		public JRJNOPPGBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8638A60", Offset = "0x8637460", VA = "0x188638A60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863F510", Offset = "0x863DF10", VA = "0x18863F510", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x863F470", Offset = "0x863DE70", VA = "0x18863F470", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class SXEACMARPTI : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8645790", Offset = "0x8644190", VA = "0x188645790")]
		public SXEACMARPTI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8645510", Offset = "0x8643F10", VA = "0x188645510", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863F870", Offset = "0x863E270", VA = "0x18863F870", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x863F800", Offset = "0x863E200", VA = "0x18863F800", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class BBEMBPHEFBS : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x862EBF0", Offset = "0x862D5F0", VA = "0x18862EBF0")]
		public BBEMBPHEFBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x862EB20", Offset = "0x862D520", VA = "0x18862EB20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863FB50", Offset = "0x863E550", VA = "0x18863FB50")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x863FBA0", Offset = "0x863E5A0", VA = "0x18863FBA0")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, HAJPTZWCSKJ root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x863F990", Offset = "0x863E390", VA = "0x18863F990", Slot = "6")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x863FA30", Offset = "0x863E430", VA = "0x18863FA30", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class PHMFBYPDOCZ : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8644050", Offset = "0x8642A50", VA = "0x188644050")]
		public PHMFBYPDOCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8643F50", Offset = "0x8642950", VA = "0x188643F50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863FC70", Offset = "0x863E670", VA = "0x18863FC70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x863FC10", Offset = "0x863E610", VA = "0x18863FC10", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x863FDC0", Offset = "0x863E7C0", VA = "0x18863FDC0")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class YJTHHWPRUBI : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8647280", Offset = "0x8645C80", VA = "0x188647280")]
		public YJTHHWPRUBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x86471B0", Offset = "0x8645BB0", VA = "0x1886471B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x863FE70", Offset = "0x863E870", VA = "0x18863FE70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x863FDD0", Offset = "0x863E7D0", VA = "0x18863FDD0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8640230", Offset = "0x863EC30", VA = "0x188640230")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class KGXVRNBVIBK : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x863C900", Offset = "0x863B300", VA = "0x18863C900")]
		public KGXVRNBVIBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x863C610", Offset = "0x863B010", VA = "0x18863C610", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86309C0", Offset = "0x862F3C0", VA = "0x1886309C0")]
		public GUBDVTBQKVR(GLTF.Math.Color a, UZHQVOUYVVV b, GLTF.Math.Vector3 c, double d, UZHQVOUYVVV e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x86300A0", Offset = "0x862EAA0", VA = "0x1886300A0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8630260", Offset = "0x862EC60", VA = "0x188630260", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class PPDRJDVXGRN : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8644400", Offset = "0x8642E00", VA = "0x188644400")]
		public PPDRJDVXGRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x86440A0", Offset = "0x8642AA0", VA = "0x1886440A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8640320", Offset = "0x863ED20", VA = "0x188640320", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8640250", Offset = "0x863EC50", VA = "0x188640250", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8640830", Offset = "0x863F230", VA = "0x188640830")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class MLJDGMYXCUN : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8641FC0", Offset = "0x86409C0", VA = "0x188641FC0")]
		public MLJDGMYXCUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8641D60", Offset = "0x8640760", VA = "0x188641D60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8640970", Offset = "0x863F370", VA = "0x188640970", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x86408A0", Offset = "0x863F2A0", VA = "0x1886408A0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8640E80", Offset = "0x863F880", VA = "0x188640E80")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class CZFQGSGWSGH : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x862F250", Offset = "0x862DC50", VA = "0x18862F250")]
		public CZFQGSGWSGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x862F030", Offset = "0x862DA30", VA = "0x18862F030", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8640F70", Offset = "0x863F970", VA = "0x188640F70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8640EF0", Offset = "0x863F8F0", VA = "0x188640EF0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class BEJXGLQHZSW : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x862ED80", Offset = "0x862D780", VA = "0x18862ED80")]
		public BEJXGLQHZSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x862EC40", Offset = "0x862D640", VA = "0x18862EC40", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class UXSRDRZBGVN : KSYLFATEMGM, AVTQJTSSWFW
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x86462B0", Offset = "0x8644CB0", VA = "0x1886462B0")]
		public UXSRDRZBGVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8646240", Offset = "0x8644C40", VA = "0x188646240")]
		public UXSRDRZBGVN(UXSRDRZBGVN a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8646040", Offset = "0x8644A40", VA = "0x188646040", Slot = "6")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x86461B0", Offset = "0x8644BB0", VA = "0x1886461B0", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x86460E0", Offset = "0x8644AE0", VA = "0x1886460E0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class KTSVUXZQJFV : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8641D10", Offset = "0x8640710", VA = "0x188641D10")]
		public KTSVUXZQJFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8641C90", Offset = "0x8640690", VA = "0x188641C90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8641190", Offset = "0x863FB90", VA = "0x188641190", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8641100", Offset = "0x863FB00", VA = "0x188641100", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x86416C0", Offset = "0x86400C0", VA = "0x1886416C0")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class BEMFKLBOQTC : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x862EFE0", Offset = "0x862D9E0", VA = "0x18862EFE0")]
		public BEMFKLBOQTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x862EDD0", Offset = "0x862D7D0", VA = "0x18862EDD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8641740", Offset = "0x8640140", VA = "0x188641740", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x86416E0", Offset = "0x86400E0", VA = "0x1886416E0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1215C70", Offset = "0x1214670", VA = "0x181215C70")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class JFKPCJLBSZO : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x86388F0", Offset = "0x86372F0", VA = "0x1886388F0")]
		public JFKPCJLBSZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8638810", Offset = "0x8637210", VA = "0x188638810", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86418B0", Offset = "0x86402B0", VA = "0x1886418B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8641850", Offset = "0x8640250", VA = "0x188641850", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1215C70", Offset = "0x1214670", VA = "0x181215C70")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class XNXFLTHAMPS : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8646F80", Offset = "0x8645980", VA = "0x188646F80")]
		public XNXFLTHAMPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8646EA0", Offset = "0x86458A0", VA = "0x188646EA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8641A20", Offset = "0x8640420", VA = "0x188641A20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x86419C0", Offset = "0x86403C0", VA = "0x1886419C0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1215C70", Offset = "0x1214670", VA = "0x181215C70")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class SWZOQRGAOQM : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x86454C0", Offset = "0x8643EC0", VA = "0x1886454C0")]
		public SWZOQRGAOQM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x86453E0", Offset = "0x8643DE0", VA = "0x1886453E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		public KHR_texture_basisu(ISFEGYUJPCM source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8641B30", Offset = "0x8640530", VA = "0x188641B30", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8641BA0", Offset = "0x86405A0", VA = "0x188641BA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class DHOXIZHAPBK : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x862F700", Offset = "0x862E100", VA = "0x18862F700")]
		public DHOXIZHAPBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x862F5A0", Offset = "0x862DFA0", VA = "0x18862F5A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8645360", Offset = "0x8643D60", VA = "0x188645360")]
		public RJRRWUSHGGT(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8644C20", Offset = "0x8643620", VA = "0x188644C20", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8644D00", Offset = "0x8643700", VA = "0x188644D00", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class PUGAEGTCYZB : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x86447A0", Offset = "0x86431A0", VA = "0x1886447A0")]
		public PUGAEGTCYZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x86444D0", Offset = "0x8642ED0", VA = "0x1886444D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		public FDUJNQARLSL(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x862FC10", Offset = "0x862E610", VA = "0x18862FC10", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x862FC80", Offset = "0x862E680", VA = "0x18862FC80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x862FD70", Offset = "0x862E770", VA = "0x18862FD70")]
		public List<double> VGJWHKZTCSF(HEOTCJBJJIU a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class ESEDWXVKBSH : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x862F850", Offset = "0x862E250", VA = "0x18862F850")]
		public ESEDWXVKBSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x862F750", Offset = "0x862E150", VA = "0x18862F750", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8638800", Offset = "0x8637200", VA = "0x188638800")]
		public IEXZETSAWVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8634B30", Offset = "0x8633530", VA = "0x188634B30")]
		public static IEXZETSAWVJ Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8637E40", Offset = "0x8636840", VA = "0x188637E40", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x86366D0", Offset = "0x86350D0", VA = "0x1886366D0")]
		private unsafe static sbyte PNMLBNFBQFY(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x86387D0", Offset = "0x86371D0", VA = "0x1886387D0")]
		private unsafe static float2 ZTYAPYRELOY(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x86358B0", Offset = "0x86342B0", VA = "0x1886358B0")]
		private unsafe static float3 JEWIONGYNSV(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8638440", Offset = "0x8636E40", VA = "0x188638440")]
		private unsafe static float4 XSNURCOVPJU(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8634F90", Offset = "0x8633990", VA = "0x188634F90")]
		private unsafe static float4x4 EFNUPWDHKXY(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x86366D0", Offset = "0x86350D0", VA = "0x1886366D0")]
		private unsafe static byte OVPJRCWSLIT(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8635900", Offset = "0x8634300", VA = "0x188635900")]
		private unsafe static float2 JPLQXSVCCLZ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x86384A0", Offset = "0x8636EA0", VA = "0x1886384A0")]
		private unsafe static float3 XSQOBJSPVAG(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x86366E0", Offset = "0x86350E0", VA = "0x1886366E0")]
		private unsafe static float4 QAQIREWCNHT(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x86364E0", Offset = "0x8634EE0", VA = "0x1886364E0")]
		private unsafe static float4x4 OEPQICQNEQB(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x86341B0", Offset = "0x8632BB0", VA = "0x1886341B0")]
		private unsafe static short PHRJIZLIYHE(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x86387A0", Offset = "0x86371A0", VA = "0x1886387A0")]
		private unsafe static float2 YWWCJQRAHJS(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8634770", Offset = "0x8633170", VA = "0x188634770")]
		private unsafe static float3 DSJPYRQPAJD(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8636480", Offset = "0x8634E80", VA = "0x188636480")]
		private unsafe static float4 NWSTGELECFQ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8636AE0", Offset = "0x86354E0", VA = "0x188636AE0")]
		private unsafe static float4x4 SZRPTBHGPYK(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x86341B0", Offset = "0x8632BB0", VA = "0x1886341B0")]
		private unsafe static ushort FYVYMVDLZNL(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8635130", Offset = "0x8633B30", VA = "0x188635130")]
		private unsafe static float2 EVPFRUKPDCZ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8636680", Offset = "0x8635080", VA = "0x188636680")]
		private unsafe static float3 ONKVGUIDBEA(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8636040", Offset = "0x8634A40", VA = "0x188636040")]
		private unsafe static float4x4 LFRNTSKFLTF(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8636F90", Offset = "0x8635990", VA = "0x188636F90")]
		private unsafe static float4 UBIQMPGBDIH(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8636AD0", Offset = "0x86354D0", VA = "0x188636AD0")]
		private unsafe static uint RAXFKLXMVGI(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x86341B0", Offset = "0x8632BB0", VA = "0x1886341B0")]
		private unsafe static ushort CVEPRTLVFXP(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x86358A0", Offset = "0x86342A0", VA = "0x1886358A0")]
		private unsafe static float JBLYSPXSIDE(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8638420", Offset = "0x8636E20", VA = "0x188638420")]
		private unsafe static float2 XSCFLQROCPS(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8633E80", Offset = "0x8632880", VA = "0x188633E80")]
		private unsafe static float3 ABNXYXKUGIV(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8634150", Offset = "0x8632B50", VA = "0x188634150")]
		private unsafe static float4 FNYPNNMYXKC(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8634120", Offset = "0x8632B20", VA = "0x188634120")]
		private unsafe static float4x4 CQULAZGTTNI(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8634150", Offset = "0x8632B50", VA = "0x188634150")]
		private unsafe static float4 CTQKLEMGDBD(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8634180", Offset = "0x8632B80", VA = "0x188634180")]
		private unsafe static float4 CTQKLEMGDBD(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8637660", Offset = "0x8636060", VA = "0x188637660")]
		public static float3[] WMCBEEWTHQA(IEXZETSAWVJ a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8636C80", Offset = "0x8635680", VA = "0x188636C80")]
		public static float3[] TUMLVRBZWYM(IEXZETSAWVJ a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8636310", Offset = "0x8634D10", VA = "0x188636310")]
		public static uint[] NVIMGXDSJUN(IEXZETSAWVJ a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8634000", Offset = "0x8632A00", VA = "0x188634000")]
		internal static void CPSGKORDQXQ(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8635AA0", Offset = "0x86344A0", VA = "0x188635AA0")]
		public uint[] KGEZKBSBFTX(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8637280", Offset = "0x8635C80", VA = "0x188637280")]
		public float[] UJAHLMSGNMD(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8636FF0", Offset = "0x86359F0", VA = "0x188636FF0")]
		public float2[] UETUSFYJJDH(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x86384F0", Offset = "0x8636EF0", VA = "0x1886384F0")]
		public float2[] YAQQEFQCRFR(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8636740", Offset = "0x8635140", VA = "0x188636740")]
		public float3[] QNPOVEYODNO(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8635CF0", Offset = "0x86346F0", VA = "0x188635CF0")]
		public float3[] KJCCWRSFVCU(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8634500", Offset = "0x8632F00", VA = "0x188634500")]
		public float4[] DQGMVQYRKCL(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x86347C0", Offset = "0x86331C0", VA = "0x1886347C0")]
		public float4[] DXTYWLNPIHB(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8635280", Offset = "0x8633C80", VA = "0x188635280")]
		public float4[] FWTIXWGYLVS(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x86369C0", Offset = "0x86353C0", VA = "0x1886369C0")]
		public float3[] QQWEOTLOQDF(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8633EA0", Offset = "0x86328A0", VA = "0x188633EA0")]
		public float3[] ARVKTATGGFK(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8635610", Offset = "0x8634010", VA = "0x188635610")]
		public float4[] GBEJVROYFNA(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8633FB0", Offset = "0x86329B0", VA = "0x188633FB0")]
		public uint[] BMXMIVKHHGZ(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8637890", Offset = "0x8636290", VA = "0x188637890")]
		public float4x4[] WUFJZXDSXWM(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8634340", Offset = "0x8632D40", VA = "0x188634340")]
		private unsafe static float4 DJGRTTLELBM(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x86341C0", Offset = "0x8632BC0", VA = "0x1886341C0")]
		private unsafe static float4 DJGRTTLELBM(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8635930", Offset = "0x8634330", VA = "0x188635930")]
		private unsafe static float4x4 JZBMVZTFMYH(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x86356E0", Offset = "0x86340E0", VA = "0x1886356E0")]
		private unsafe static float4 IRBXSZKQKCX(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x86374F0", Offset = "0x8635EF0", VA = "0x1886374F0")]
		private unsafe static float3 VJKNZYRACAU(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x86361E0", Offset = "0x8634BE0", VA = "0x1886361E0")]
		private unsafe static float2 MZCJAAGJTQF(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8635160", Offset = "0x8633B60", VA = "0x188635160")]
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
		[Cpp2IlInjected.Address(RVA = "0x865DD00", Offset = "0x865C700", VA = "0x18865DD00")]
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
		[Cpp2IlInjected.Address(RVA = "0x8648F10", Offset = "0x8647910", VA = "0x188648F10")]
		public AQLCTIYKNIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8648B10", Offset = "0x8647510", VA = "0x188648B10")]
		public static AQLCTIYKNIL Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8648DE0", Offset = "0x86477E0", VA = "0x188648DE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86499E0", Offset = "0x86483E0", VA = "0x1886499E0")]
		public DZJBQMTPYTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x86495C0", Offset = "0x8647FC0", VA = "0x1886495C0")]
		public static DZJBQMTPYTG Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x86498A0", Offset = "0x86482A0", VA = "0x1886498A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x864B380", Offset = "0x8649D80", VA = "0x18864B380")]
		public FYYGRVNBIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x864B000", Offset = "0x8649A00", VA = "0x18864B000")]
		public static FYYGRVNBIKJ Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x864B280", Offset = "0x8649C80", VA = "0x18864B280", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8648870", Offset = "0x8647270", VA = "0x188648870")]
		public AMUQUOLDGLX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8648580", Offset = "0x8646F80", VA = "0x188648580")]
		public static AMUQUOLDGLX Deserialize(HAJPTZWCSKJ root, JsonReader reader, QXSDTWZKPRH anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8648770", Offset = "0x8647170", VA = "0x188648770", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x865D5E0", Offset = "0x865BFE0", VA = "0x18865D5E0")]
		public static YEDFITJDIEI Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x865D960", Offset = "0x865C360", VA = "0x18865D960")]
		public YEDFITJDIEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x865D840", Offset = "0x865C240", VA = "0x18865D840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86566C0", Offset = "0x86550C0", VA = "0x1886566C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x865E0F0", Offset = "0x865CAF0", VA = "0x18865E0F0")]
		public ZTUMJVGKYLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x865DD60", Offset = "0x865C760", VA = "0x18865DD60")]
		public static ZTUMJVGKYLA Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x865DF80", Offset = "0x865C980", VA = "0x18865DF80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8650850", Offset = "0x864F250", VA = "0x188650850")]
		public IFYMQTZUWMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x864FD60", Offset = "0x864E760", VA = "0x18864FD60")]
		public static IFYMQTZUWMM Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8650430", Offset = "0x864EE30", VA = "0x188650430", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8650420", Offset = "0x864EE20", VA = "0x188650420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8650080", Offset = "0x864EA80", VA = "0x188650080")]
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
		[Cpp2IlInjected.Address(RVA = "0x8648AC0", Offset = "0x86474C0", VA = "0x188648AC0")]
		public WRLZRPFBNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x865C980", Offset = "0x865B380", VA = "0x18865C980")]
		public static WRLZRPFBNDF Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x865CC30", Offset = "0x865B630", VA = "0x18865CC30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8658680", Offset = "0x8657080", VA = "0x188658680")]
		public RUMAJXXCJHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8658190", Offset = "0x8656B90", VA = "0x188658190")]
		public static RUMAJXXCJHX Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8658510", Offset = "0x8656F10", VA = "0x188658510", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86545C0", Offset = "0x8652FC0", VA = "0x1886545C0")]
		public LKCTYNWZVKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x86540C0", Offset = "0x8652AC0", VA = "0x1886540C0")]
		public static LKCTYNWZVKH Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8654430", Offset = "0x8652E30", VA = "0x188654430", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JOXUKJQLBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8650FD0", Offset = "0x864F9D0", VA = "0x188650FD0")]
			internal AMUQUOLDGLX TFYPDRRXVEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8650FC0", Offset = "0x864F9C0", VA = "0x188650FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8655DC0", Offset = "0x86547C0", VA = "0x188655DC0")]
		public static QXSDTWZKPRH Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8656520", Offset = "0x8654F20", VA = "0x188656520")]
		public QXSDTWZKPRH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8656180", Offset = "0x8654B80", VA = "0x188656180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8648AC0", Offset = "0x86474C0", VA = "0x188648AC0")]
		public UGLZFXIWHAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x865BC00", Offset = "0x865A600", VA = "0x18865BC00")]
		public static UGLZFXIWHAP Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x865BDD0", Offset = "0x865A7D0", VA = "0x18865BDD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8648AC0", Offset = "0x86474C0", VA = "0x188648AC0")]
		public GFLCJGQFPRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x864B3D0", Offset = "0x8649DD0", VA = "0x18864B3D0")]
		public static GFLCJGQFPRQ Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x864B5A0", Offset = "0x8649FA0", VA = "0x18864B5A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8648AC0", Offset = "0x86474C0", VA = "0x188648AC0")]
		public ANJTOSCXDAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8648A40", Offset = "0x8647440", VA = "0x188648A40")]
		public ANJTOSCXDAN(ANJTOSCXDAN a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x86488C0", Offset = "0x86472C0", VA = "0x1886488C0")]
		public new void HGHTLDPCOBZ(HAJPTZWCSKJ a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x86489B0", Offset = "0x86473B0", VA = "0x1886489B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		protected BZPQMJVKEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x4F143A0", Offset = "0x4F12DA0", VA = "0x184F143A0")]
		public BZPQMJVKEEL(BZPQMJVKEEL<a> a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4F14370", Offset = "0x4F12D70", VA = "0x184F14370")]
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
			[Cpp2IlInjected.Address(RVA = "0x865AC10", Offset = "0x8659610", VA = "0x18865AC10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x865AB70", Offset = "0x8659570", VA = "0x18865AB70")]
		public TULYRSXOBNY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x865ABB0", Offset = "0x86595B0", VA = "0x18865ABB0")]
		public TULYRSXOBNY(TULYRSXOBNY a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x865AA90", Offset = "0x8659490", VA = "0x18865AA90")]
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
			[Cpp2IlInjected.Address(RVA = "0x8655550", Offset = "0x8653F50", VA = "0x188655550", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8655510", Offset = "0x8653F10", VA = "0x188655510")]
		public OKVUXVROTUP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8655430", Offset = "0x8653E30", VA = "0x188655430")]
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
			[Cpp2IlInjected.Address(RVA = "0x8648520", Offset = "0x8646F20", VA = "0x188648520", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x86484E0", Offset = "0x8646EE0", VA = "0x1886484E0")]
		public AMFKYVJMYXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8648400", Offset = "0x8646E00", VA = "0x188648400")]
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
			[Cpp2IlInjected.Address(RVA = "0x865AD90", Offset = "0x8659790", VA = "0x18865AD90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x865AD50", Offset = "0x8659750", VA = "0x18865AD50")]
		public TYQIDDYZXQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x865AC70", Offset = "0x8659670", VA = "0x18865AC70")]
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
			[Cpp2IlInjected.Address(RVA = "0x8650A20", Offset = "0x864F420", VA = "0x188650A20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x86509E0", Offset = "0x864F3E0", VA = "0x1886509E0")]
		public ISFEGYUJPCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8650900", Offset = "0x864F300", VA = "0x188650900")]
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
			[Cpp2IlInjected.Address(RVA = "0x86522F0", Offset = "0x8650CF0", VA = "0x1886522F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8652250", Offset = "0x8650C50", VA = "0x188652250")]
		public JZJXLRFCXOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8652290", Offset = "0x8650C90", VA = "0x188652290")]
		public JZJXLRFCXOQ(JZJXLRFCXOQ a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8652170", Offset = "0x8650B70", VA = "0x188652170")]
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
			[Cpp2IlInjected.Address(RVA = "0x86592D0", Offset = "0x8657CD0", VA = "0x1886592D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8659290", Offset = "0x8657C90", VA = "0x188659290")]
		public SLVMOGNGDEY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x86591B0", Offset = "0x8657BB0", VA = "0x1886591B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x865D580", Offset = "0x865BF80", VA = "0x18865D580", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x865D540", Offset = "0x865BF40", VA = "0x18865D540")]
		public XJZDRDVDUVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x865D1F0", Offset = "0x865BBF0", VA = "0x18865D1F0")]
		public static XJZDRDVDUVD Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x865D2D0", Offset = "0x865BCD0", VA = "0x18865D2D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x865C920", Offset = "0x865B320", VA = "0x18865C920", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x865C8E0", Offset = "0x865B2E0", VA = "0x18865C8E0")]
		public WLZPKTUQMIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x865C800", Offset = "0x865B200", VA = "0x18865C800")]
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
			[Cpp2IlInjected.Address(RVA = "0x865C7A0", Offset = "0x865B1A0", VA = "0x18865C7A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x865C760", Offset = "0x865B160", VA = "0x18865C760")]
		public VKJMGSXGQNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x865C660", Offset = "0x865B060", VA = "0x18865C660")]
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
			[Cpp2IlInjected.Address(RVA = "0x864A280", Offset = "0x8648C80", VA = "0x18864A280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x864A240", Offset = "0x8648C40", VA = "0x18864A240")]
		public FEXXFFGAMHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x864A160", Offset = "0x8648B60", VA = "0x18864A160")]
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
			[Cpp2IlInjected.Address(RVA = "0x8654740", Offset = "0x8653140", VA = "0x188654740", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8654700", Offset = "0x8653100", VA = "0x188654700")]
		public LSVPPLRWNBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8654620", Offset = "0x8653020", VA = "0x188654620")]
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
			[Cpp2IlInjected.Address(RVA = "0x86483A0", Offset = "0x8646DA0", VA = "0x1886483A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8648300", Offset = "0x8646D00", VA = "0x188648300")]
		public AAUCBQWFIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8648340", Offset = "0x8646D40", VA = "0x188648340")]
		public AAUCBQWFIFI(AAUCBQWFIFI a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8648220", Offset = "0x8646C20", VA = "0x188648220")]
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
			[Cpp2IlInjected.Address(RVA = "0x8654A60", Offset = "0x8653460", VA = "0x188654A60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8654A20", Offset = "0x8653420", VA = "0x188654A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x8648AC0", Offset = "0x86474C0", VA = "0x188648AC0")]
		public HYPAYMVBZTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x864F950", Offset = "0x864E350", VA = "0x18864F950")]
		public static HYPAYMVBZTQ Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x864FB90", Offset = "0x864E590", VA = "0x18864FB90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x864AF90", Offset = "0x8649990", VA = "0x18864AF90")]
		public FVNHZHFYOAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x864A620", Offset = "0x8649020", VA = "0x18864A620")]
		public static FVNHZHFYOAY Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x864AB30", Offset = "0x8649530", VA = "0x18864AB30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ESCTXDLDNMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x864A150", Offset = "0x8648B50", VA = "0x18864A150")]
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
		[Cpp2IlInjected.Address(RVA = "0x8648AC0", Offset = "0x86474C0", VA = "0x188648AC0")]
		public NRXRJTXZNMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8654AC0", Offset = "0x86534C0", VA = "0x188654AC0")]
		public static NRXRJTXZNMY Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8654E80", Offset = "0x8653880", VA = "0x188654E80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8652350", Offset = "0x8650D50", VA = "0x188652350")]
		public static FKHFNJEUUXL AZAMREQJHEM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x86528E0", Offset = "0x86512E0", VA = "0x1886528E0")]
		public static AVTQJTSSWFW JOIXQUOJJIS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public KSYLFATEMGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8653DD0", Offset = "0x86527D0", VA = "0x188653DD0")]
		public KSYLFATEMGM(KSYLFATEMGM a, [Optional] HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8652630", Offset = "0x8651030", VA = "0x188652630")]
		public void HGHTLDPCOBZ(HAJPTZWCSKJ a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x86524E0", Offset = "0x8650EE0", VA = "0x1886524E0")]
		public void DWYNGKYASMI(string a, AVTQJTSSWFW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8652B50", Offset = "0x8651550", VA = "0x188652B50")]
		private void PRVOBYOKODC(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8652A90", Offset = "0x8651490", VA = "0x188652A90")]
		private void KYZWBYMJOJG(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x86529D0", Offset = "0x86513D0", VA = "0x1886529D0")]
		private void JRRILJKNRXO(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8652C40", Offset = "0x8651640", VA = "0x188652C40")]
		internal static Dictionary<string, AVTQJTSSWFW> REGMHJDVYQV(HAJPTZWCSKJ a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8653220", Offset = "0x8651C20", VA = "0x188653220", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JVZGIHOIAUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x86520E0", Offset = "0x8650AE0", VA = "0x1886520E0")]
			internal IEXZETSAWVJ TFYPDRRXVEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x86520D0", Offset = "0x8650AD0", VA = "0x1886520D0")]
			internal QXSDTWZKPRH TFTIGKYALTG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x8652100", Offset = "0x8650B00", VA = "0x188652100")]
			internal UGLZFXIWHAP TGJCYFFSOBH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x86520F0", Offset = "0x8650AF0", VA = "0x1886520F0")]
			internal WRLZRPFBNDF TGDWAYLVEPY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x8652120", Offset = "0x8650B20", VA = "0x188652120")]
			internal GFLCJGQFPRQ TGTQSSTNGXZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x8652110", Offset = "0x8650B10", VA = "0x188652110")]
			internal HYPAYMVBZTQ TGOJVLZPXMQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x8652140", Offset = "0x8650B40", VA = "0x188652140")]
			internal FVNHZHFYOAY THEENGHHZUR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x8652130", Offset = "0x8650B30", VA = "0x188652130")]
			internal NRXRJTXZNMY TGYXPZNKQJI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x8652160", Offset = "0x8650B60", VA = "0x188652160")]
			internal HEOTCJBJJIU THOSHTVCSRJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x8652150", Offset = "0x8650B50", VA = "0x188652150")]
			internal Sampler THJLKNBFJGA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x8651F30", Offset = "0x8650930", VA = "0x188651F30")]
			internal CZFXZURTGTF NUQYYIFIIGE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x86520B0", Offset = "0x8650AB0", VA = "0x1886520B0")]
			internal EQNDQUCXYAN NUWFVOZFRRN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x86520C0", Offset = "0x8650AC0", VA = "0x1886520C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x864E280", Offset = "0x864CC80", VA = "0x18864E280")]
		public HAJPTZWCSKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x864C630", Offset = "0x864B030", VA = "0x18864C630")]
		public CZFXZURTGTF MEZBJFZOXUH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x864B7E0", Offset = "0x864A1E0", VA = "0x18864B7E0")]
		public static HAJPTZWCSKJ Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x864C6D0", Offset = "0x864B0D0", VA = "0x18864C6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8648AC0", Offset = "0x86474C0", VA = "0x188648AC0")]
		public CZFXZURTGTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x86491D0", Offset = "0x8647BD0", VA = "0x1886491D0")]
		public static CZFXZURTGTF Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8649350", Offset = "0x8647D50", VA = "0x188649350", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8648AC0", Offset = "0x86474C0", VA = "0x188648AC0")]
		public FLUADCVEWRS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x864A2E0", Offset = "0x8648CE0", VA = "0x18864A2E0")]
		public static FLUADCVEWRS Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x864A4B0", Offset = "0x8648EB0", VA = "0x18864A4B0", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class ILGJXJPYROB : NJGYQQMXQIH
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8648AC0", Offset = "0x86474C0", VA = "0x188648AC0")]
		public ILGJXJPYROB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x86508F0", Offset = "0x864F2F0", VA = "0x1886508F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8648AC0", Offset = "0x86474C0", VA = "0x188648AC0")]
		public NJGYQQMXQIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x86547A0", Offset = "0x86531A0", VA = "0x1886547A0", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class SXXQCTNMGEL : NJGYQQMXQIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8648AC0", Offset = "0x86474C0", VA = "0x188648AC0")]
		public SXXQCTNMGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x86508F0", Offset = "0x864F2F0", VA = "0x1886508F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x865DCB0", Offset = "0x865C6B0", VA = "0x18865DCB0")]
		public YMVACQAVXCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x865D9B0", Offset = "0x865C3B0", VA = "0x18865D9B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8656610", Offset = "0x8655010", VA = "0x188656610", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public RBUOSKQYQDY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class GQCBMLCGBAE : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x864B770", Offset = "0x864A170", VA = "0x18864B770", Slot = "4")]
		public override AVTQJTSSWFW Deserialize(HAJPTZWCSKJ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
		[Cpp2IlInjected.Address(RVA = "0x8659A70", Offset = "0x8658470", VA = "0x188659A70")]
		public SVRIUCOAGLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8659570", Offset = "0x8657F70", VA = "0x188659570")]
		public static SVRIUCOAGLS Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8659810", Offset = "0x8658210", VA = "0x188659810", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x865AA30", Offset = "0x8659430", VA = "0x18865AA30")]
		public XAMVIXHDGXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x865CE40", Offset = "0x865B840", VA = "0x18865CE40")]
		public new static XAMVIXHDGXA Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x865D130", Offset = "0x865BB30", VA = "0x18865D130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x865AA30", Offset = "0x8659430", VA = "0x18865AA30")]
		public TQJCZZHPRWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x865A680", Offset = "0x8659080", VA = "0x18865A680")]
		public new static TQJCZZHPRWI Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x865A970", Offset = "0x8659370", VA = "0x18865A970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x865A610", Offset = "0x8659010", VA = "0x18865A610")]
		public TLTUODOJAHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x865A010", Offset = "0x8658A10", VA = "0x18865A010")]
		public static TLTUODOJAHP Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x865A380", Offset = "0x8658D80", VA = "0x18865A380", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public UONXUWZERAT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x865BFD0", Offset = "0x865A9D0", VA = "0x18865BFD0")]
			internal TULYRSXOBNY TFYPDRRXVEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x865BF20", Offset = "0x865A920", VA = "0x18865BF20")]
			internal Dictionary<string, TULYRSXOBNY> TFTIGKYALTG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x865C0A0", Offset = "0x865AAA0", VA = "0x18865C0A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657A50", Offset = "0x8656450", VA = "0x188657A50")]
		public RTIRXCWROQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8657AF0", Offset = "0x86564F0", VA = "0x188657AF0")]
		public RTIRXCWROQS(RTIRXCWROQS a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8657080", Offset = "0x8655A80", VA = "0x188657080")]
		public static int[] PILNREWZWVC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8656EB0", Offset = "0x86558B0", VA = "0x188656EB0")]
		public static int[] HBLFMVDDKTO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8656810", Offset = "0x8655210", VA = "0x188656810")]
		public static int[] DPKWTLTBNPQ(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8657810", Offset = "0x8656210", VA = "0x188657810")]
		public static int[] YEKLUZATETA(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8656760", Offset = "0x8655160", VA = "0x188656760")]
		public static int[] DPEBGFGLMMJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8657010", Offset = "0x8655A10", VA = "0x188657010")]
		public static int[] JIZEZATOKYQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8656E20", Offset = "0x8655820", VA = "0x188656E20")]
		public static int[] FLOWCXHZIKS(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8657120", Offset = "0x8655B20", VA = "0x188657120")]
		public static int[] VXKYHHSPLUJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8657780", Offset = "0x8656180", VA = "0x188657780")]
		public static int[] XSZQKNNKCPZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x86569D0", Offset = "0x86553D0", VA = "0x1886569D0")]
		public static RTIRXCWROQS Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8657190", Offset = "0x8655B90", VA = "0x188657190", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x864F810", Offset = "0x864E210", VA = "0x18864F810")]
		public HEOTCJBJJIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x864E2D0", Offset = "0x864CCD0", VA = "0x18864E2D0")]
		public static HEOTCJBJJIU Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x864EC10", Offset = "0x864D610", VA = "0x18864EC10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8659FA0", Offset = "0x86589A0", VA = "0x188659FA0")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8659AE0", Offset = "0x86584E0", VA = "0x188659AE0")]
		public static Sampler Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8659DB0", Offset = "0x86587B0", VA = "0x188659DB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x864A0A0", Offset = "0x8648AA0", VA = "0x18864A0A0")]
		public EQNDQUCXYAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8649A30", Offset = "0x8648430", VA = "0x188649A30")]
		public static EQNDQUCXYAN Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8649D90", Offset = "0x8648790", VA = "0x188649D90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x865C520", Offset = "0x865AF20", VA = "0x18865C520")]
		public UZHQVOUYVVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x865C570", Offset = "0x865AF70", VA = "0x18865C570")]
		public UZHQVOUYVVV(UZHQVOUYVVV a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x865C170", Offset = "0x865AB70", VA = "0x18865C170")]
		public static UZHQVOUYVVV Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x865C4C0", Offset = "0x865AEC0", VA = "0x18865C4C0", Slot = "4")]
		public override void XQIXCNAGDPI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x865C3F0", Offset = "0x865ADF0", VA = "0x18865C3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8655D40", Offset = "0x8654740", VA = "0x188655D40")]
		public PJFXFDNDRUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8655880", Offset = "0x8654280", VA = "0x188655880")]
		public static PJFXFDNDRUY Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8655AD0", Offset = "0x86544D0", VA = "0x188655AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86590F0", Offset = "0x8657AF0", VA = "0x1886590F0")]
		public RXZHUQQPPFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8658FC0", Offset = "0x86579C0", VA = "0x188658FC0")]
		public RXZHUQQPPFA(RXZHUQQPPFA a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x86586D0", Offset = "0x86570D0", VA = "0x1886586D0")]
		public static RXZHUQQPPFA Deserialize(HAJPTZWCSKJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8658AC0", Offset = "0x86574C0", VA = "0x188658AC0")]
		public static RXZHUQQPPFA Deserialize(HAJPTZWCSKJ root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8658BE0", Offset = "0x86575E0", VA = "0x188658BE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		public TZNAIYJXFZC(IList<NJGYQQMXQIH> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x865AE60", Offset = "0x8659860", VA = "0x18865AE60", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x865ADF0", Offset = "0x86597F0", VA = "0x18865ADF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8651EB0", Offset = "0x86508B0", VA = "0x188651EB0")]
		public JTMBOBAXOFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8650FF0", Offset = "0x864F9F0", VA = "0x188650FF0", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x86519D0", Offset = "0x86503D0", VA = "0x1886519D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8651280", Offset = "0x864FC80", VA = "0x188651280")]
		private static string[] GYIINDREGBA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8651530", Offset = "0x864FF30", VA = "0x188651530")]
		private static RLWBXOMGKVB.ImportValuesConversion QXCHHINEUII(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8651AC0", Offset = "0x86504C0", VA = "0x188651AC0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8649080", Offset = "0x8647A80", VA = "0x188649080", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8649040", Offset = "0x8647A40", VA = "0x188649040")]
		public AWTSAXRMNRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8648F60", Offset = "0x8647960", VA = "0x188648F60")]
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
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		public SQTNMDLFWHO(AWTSAXRMNRN a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x86594B0", Offset = "0x8657EB0", VA = "0x1886594B0")]
		public SQTNMDLFWHO(int a, HAJPTZWCSKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8659330", Offset = "0x8657D30", VA = "0x188659330", Slot = "5")]
		public AVTQJTSSWFW Clone(HAJPTZWCSKJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x86593B0", Offset = "0x8657DB0", VA = "0x1886593B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class IVXPTYYTNGB : FKHFNJEUUXL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8650F70", Offset = "0x864F970", VA = "0x188650F70")]
		public IVXPTYYTNGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8650A80", Offset = "0x864F480", VA = "0x188650A80", Slot = "4")]
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
