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
	public class KHR_animation_pointer : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object NJTWHXMOPOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string NKZPLFPXYXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string SYMTCIPFGLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public UIHQQYDXELM CMMQVYEYQZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer TTSDYJDAVYZ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x87B00B0", Offset = "0x87AF0B0", VA = "0x1887B00B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87B0000", Offset = "0x87AF000", VA = "0x1887B0000", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class JQEVFCFGGFF
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 CFPIVWOZVEA;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 PHOSKVHFSED;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion ZWTQWCKEGTV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool PTVUENPKSHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x87ADA70", Offset = "0x87ACA70", VA = "0x1887ADA70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87AC3B0", Offset = "0x87AB3B0", VA = "0x1887AC3B0")]
		public static void RJBHGOERHLJ(this BNPRQWVLIYC a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87ABC60", Offset = "0x87AAC60", VA = "0x1887ABC60")]
		public static void NCICPQCUWCB(this BNPRQWVLIYC a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87AD070", Offset = "0x87AC070", VA = "0x1887AD070")]
		public static void WKVCQOTWHCY(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87AD6F0", Offset = "0x87AC6F0", VA = "0x1887AD6F0")]
		public static GLTF.Math.Vector4 XPVUJZGUVCA(this YBDCAOWIQBX a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87AB860", Offset = "0x87AA860", VA = "0x1887AB860")]
		public static UnityEngine.Quaternion JHPJPQPPEUX(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87AB9F0", Offset = "0x87AA9F0", VA = "0x1887AB9F0")]
		public static UnityEngine.Quaternion JHPJPQPPEUX(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x87AB3E0", Offset = "0x87AA3E0", VA = "0x1887AB3E0")]
		public static GLTF.Math.Quaternion HSNFMVRCFKN(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x87ADF40", Offset = "0x87ACF40", VA = "0x1887ADF40")]
		public static Matrix4x4 ZLHWAXLBBZA(this YBDCAOWIQBX a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x87ADB00", Offset = "0x87ACB00", VA = "0x1887ADB00")]
		public static Matrix4x4 ZLHWAXLBBZA(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x87AB520", Offset = "0x87AA520", VA = "0x1887AB520")]
		public static YBDCAOWIQBX INQWDDZLFZO(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x87AD4F0", Offset = "0x87AC4F0", VA = "0x1887AD4F0")]
		public static UnityEngine.Vector3 XLQFNVALPFN(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87AD610", Offset = "0x87AC610", VA = "0x1887AD610")]
		public static UnityEngine.Vector3 XLQFNVALPFN(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x87ACB60", Offset = "0x87ABB60", VA = "0x1887ACB60")]
		public static GLTF.Math.Vector3 RWSWJGVRSAB(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x87ABC20", Offset = "0x87AAC20", VA = "0x1887ABC20")]
		public static GLTF.Math.Vector3 LWFGSLEFJXK(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x137A3B0", Offset = "0x13793B0", VA = "0x18137A3B0")]
		public static GLTF.Math.Vector4 UGVATFOZKSP(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x87AAD40", Offset = "0x87A9D40", VA = "0x1887AAD40")]
		public static Matrix4x4 BKIWRVWHTHR(this YBDCAOWIQBX a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x87AAAD0", Offset = "0x87A9AD0", VA = "0x1887AAAD0")]
		public static Matrix4x4 BKIWRVWHTHR(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x87ACC90", Offset = "0x87ABC90", VA = "0x1887ACC90")]
		public static YBDCAOWIQBX SIMJIJXCFPD(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x87ACF30", Offset = "0x87ABF30", VA = "0x1887ACF30")]
		public static UnityEngine.Vector2 VDHRCKIUUFF(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x87ACF30", Offset = "0x87ABF30", VA = "0x1887ACF30")]
		public static UnityEngine.Vector2 VDHRCKIUUFF(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x87ACE60", Offset = "0x87ABE60", VA = "0x1887ACE60")]
		public static void VDHRCKIUUFF(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x87AE160", Offset = "0x87AD160", VA = "0x1887AE160")]
		public static UnityEngine.Vector3 ZOFBTGBRQVQ(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D81BA0", Offset = "0x1D80BA0", VA = "0x181D81BA0")]
		public static UnityEngine.Vector3 ZOFBTGBRQVQ(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x87AE1C0", Offset = "0x87AD1C0", VA = "0x1887AE1C0")]
		public static void ZOFBTGBRQVQ(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x137A3B0", Offset = "0x13793B0", VA = "0x18137A3B0")]
		public static UnityEngine.Vector4 RUDQWECVUYF(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x137A3B0", Offset = "0x13793B0", VA = "0x18137A3B0")]
		public static UnityEngine.Vector4 RUDQWECVUYF(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87AC950", Offset = "0x87AB950", VA = "0x1887AC950")]
		public static UnityEngine.Vector4[] RUDQWECVUYF(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x87ACA50", Offset = "0x87ABA50", VA = "0x1887ACA50")]
		public static void RUDQWECVUYF(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x87AB030", Offset = "0x87AA030", VA = "0x1887AB030")]
		public static UnityEngine.Color CZATCRHRKFF(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x87AB0D0", Offset = "0x87AA0D0", VA = "0x1887AB0D0")]
		public static void CZATCRHRKFF(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x87AB030", Offset = "0x87AA030", VA = "0x1887AB030")]
		public static UnityEngine.Color CZATCRHRKFF(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x137A3B0", Offset = "0x13793B0", VA = "0x18137A3B0")]
		public static UnityEngine.Color ACKTDNWOZAW(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x87AA9C0", Offset = "0x87A99C0", VA = "0x1887AA9C0")]
		public static void ACKTDNWOZAW(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x137A3B0", Offset = "0x13793B0", VA = "0x18137A3B0")]
		public static UnityEngine.Color ACKTDNWOZAW(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x87AC300", Offset = "0x87AB300", VA = "0x1887AC300")]
		public static GLTF.Math.Color PSAVWXQWTEM(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x87ABBA0", Offset = "0x87AABA0", VA = "0x1887ABBA0")]
		public static GLTF.Math.Color KARCKWRTUIX(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x87ABB20", Offset = "0x87AAB20", VA = "0x1887ABB20")]
		public static GLTF.Math.Color JRCPJTQKVZR(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87ACF50", Offset = "0x87ABF50", VA = "0x1887ACF50")]
		public static UnityEngine.Color[] VHZRCIZRXJQ(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x87AC330", Offset = "0x87AB330", VA = "0x1887AC330")]
		public static int[] QPLVZVDALPL(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x87AD440", Offset = "0x87AC440", VA = "0x1887AD440")]
		public static UnityEngine.Vector2[] XKQCRTWNVAO(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x87AD910", Offset = "0x87AC910", VA = "0x1887AD910")]
		public static void XQNFKYCEQWR(WQRQPKBXLOB a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x87AB210", Offset = "0x87AA210", VA = "0x1887AB210")]
		public static UnityEngine.Vector3[] FHREBWOQHYX(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x87AC160", Offset = "0x87AB160", VA = "0x1887AC160")]
		public static UnityEngine.Vector4[] NYPWTMKOFLY(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x87AB370", Offset = "0x87AA370", VA = "0x1887AB370")]
		public static void GCXCQFHSWVL(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x87AB000", Offset = "0x87AA000", VA = "0x1887AB000")]
		public static UnityEngine.Quaternion BTSDNMEMMGF(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class WQRQPKBXLOB
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IDGLSJLJFQE IDGLSJLJFQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray QOMFSICDRHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x87BF390", Offset = "0x87BE390", VA = "0x1887BF390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> QCQWOPLEXPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xED7510", Offset = "0xED6510", VA = "0x180ED7510")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xFC0B60", Offset = "0xFBFB60", VA = "0x180FC0B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint HHSVCYRNGMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCF4860", Offset = "0xCF3860", VA = "0x180CF4860")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4870", Offset = "0xCF3870", VA = "0x180CF4870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x87BF3A0", Offset = "0x87BE3A0", VA = "0x1887BF3A0")]
		public WQRQPKBXLOB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x87AA670", Offset = "0x87A9670", VA = "0x1887AA670")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x87AA6D0", Offset = "0x87A96D0", VA = "0x1887AA6D0")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class KIRSHPXTMWE
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class SWSVOAWLSEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> OANZDJADJAB;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public SWSVOAWLSEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x87BD330", Offset = "0x87BC330", VA = "0x1887BD330")]
			internal int? FXPFXCQSTGW(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x87BD480", Offset = "0x87BC480", VA = "0x1887BD480")]
			internal int? PABXJGOCDBP(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x87BD3B0", Offset = "0x87BC3B0", VA = "0x1887BD3B0")]
			internal bool GRPRNODZULP(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x87B48D0", Offset = "0x87B38D0", VA = "0x1887B48D0")]
		private static void WQABABQGZDL(NumericArray a, WQRQPKBXLOB b, WQRQPKBXLOB c, WQRQPKBXLOB d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x87B4E40", Offset = "0x87B3E40", VA = "0x1887B4E40")]
		public static void ZOIDKGWIGHE(Dictionary<string, WQRQPKBXLOB> a, Dictionary<string, (WQRQPKBXLOB sparseIndices, WQRQPKBXLOB sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87B42F0", Offset = "0x87B32F0", VA = "0x1887B42F0")]
		public static void RXWSZGZBKVI(Dictionary<string, WQRQPKBXLOB> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x87B47D0", Offset = "0x87B37D0", VA = "0x1887B47D0")]
		public static void VRJQDRDSCEF(WQRQPKBXLOB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x87B3D60", Offset = "0x87B2D60", VA = "0x1887B3D60")]
		public static void RIBCKSBWLQJ(Dictionary<string, List<WQRQPKBXLOB>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x87B36D0", Offset = "0x87B26D0", VA = "0x1887B36D0")]
		private static void MEOAJEANRRT(WQRQPKBXLOB a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x87B3800", Offset = "0x87B2800", VA = "0x1887B3800")]
		internal static void MEOAJEANRRT(EWTVDJXEXKJ a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x87B38C0", Offset = "0x87B28C0", VA = "0x1887B38C0")]
		public static RAEDKCMOFAT OYCMACQQXXH(IEnumerable<RAEDKCMOFAT> a)
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
			[Cpp2IlInjected.Address(RVA = "0xF58350", Offset = "0xF57350", VA = "0x180F58350")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x15C1E10", Offset = "0x15C0E10", VA = "0x1815C1E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30C0890", Offset = "0x30BF890", VA = "0x1830C0890")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30C08A0", Offset = "0x30BF8A0", VA = "0x1830C08A0")]
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
	public class NOIXFHNIPBK
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint GMZALKWQQDD;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint YZQFSOPTHNF;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint TZQVERDUUAD;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x87B68D0", Offset = "0x87B58D0", VA = "0x1887B68D0")]
		public static void WSOWORZLVVR(Stream a, [Out] UERVNJFVUCH b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x87B6640", Offset = "0x87B5640", VA = "0x1887B6640")]
		public static ChunkInfo TGELOWCERDR(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x87B6500", Offset = "0x87B5500", VA = "0x1887B6500")]
		public static GLBHeader LMOQQKWNPNH(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x87B6240", Offset = "0x87B5240", VA = "0x1887B6240")]
		public static bool BIXHFJRIFKJ(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x87B6390", Offset = "0x87B5390", VA = "0x1887B6390")]
		public static ChunkInfo GTJEKJIJEEW(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x87B6A90", Offset = "0x87B5A90", VA = "0x1887B6A90")]
		private static void YVPUKXKJXMY(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x87B6300", Offset = "0x87B5300", VA = "0x1887B6300")]
		private static uint DMSGCAXAGNN(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class EOCWOASBPZS
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
		public PathElement VUSVVURGGQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCF4110", Offset = "0xCF3110", VA = "0x180CF4110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA30", Offset = "0xCFAA30", VA = "0x180CFBA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int JEHIAJMVLLA
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xE01B10", Offset = "0xE00B10", VA = "0x180E01B10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xE01AF0", Offset = "0xE00AF0", VA = "0x180E01AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string ETZEIEGZJMB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DITMKXHLAGA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCFC420", Offset = "0xCFB420", VA = "0x180CFC420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCFC350", Offset = "0xCFB350", VA = "0x180CFC350")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EOCWOASBPZS TDJEPXFIHYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x87A8F40", Offset = "0x87A7F40", VA = "0x1887A8F40")]
		public string STPINJGHAFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x87A8D00", Offset = "0x87A7D00", VA = "0x1887A8D00")]
		public EOCWOASBPZS COBPTGIIODO(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x87A9170", Offset = "0x87A8170", VA = "0x1887A9170")]
		private EOCWOASBPZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x87A8FC0", Offset = "0x87A7FC0", VA = "0x1887A8FC0")]
		public EOCWOASBPZS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x537DBD0", Offset = "0x537CBD0", VA = "0x18537DBD0")]
		[CompilerGenerated]
		internal static string FRCWYQPBEMY(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x87A8D20", Offset = "0x87A7D20", VA = "0x1887A8D20")]
		[CompilerGenerated]
		internal static bool LOSNXKSDSCH([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x87A8D60", Offset = "0x87A7D60", VA = "0x1887A8D60")]
		[CompilerGenerated]
		internal static EOCWOASBPZS PGUFHOLPQJX(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ELYSIMGBGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x87A8A60", Offset = "0x87A7A60", VA = "0x1887A8A60")]
		public static int[] RELKPSRMJMF(this UERVNJFVUCH a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x87A8910", Offset = "0x87A7910", VA = "0x1887A8910")]
		public static int[] HULQILUMYKT(this UERVNJFVUCH a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class ZGGHFTOLRRH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x87C1210", Offset = "0x87C0210", VA = "0x1887C1210")]
		public static uint ABGVINFLAIS(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream FUAYYCFFWOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long HWSTNRRQMCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long PVRAQTAWGGM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x87BD9C0", Offset = "0x87BC9C0", VA = "0x1887BD9C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x87BDA00", Offset = "0x87BCA00", VA = "0x1887BDA00", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x87BDA00", Offset = "0x87BCA00", VA = "0x1887BDA00", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x87BDA20", Offset = "0x87BCA20", VA = "0x1887BDA20", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x87BDA40", Offset = "0x87BCA40", VA = "0x1887BDA40", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x87BDA60", Offset = "0x87BCA60", VA = "0x1887BDA60", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x87BD750", Offset = "0x87BC750", VA = "0x1887BD750")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x87BD510", Offset = "0x87BC510", VA = "0x1887BD510", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x87BD5E0", Offset = "0x87BC5E0", VA = "0x1887BD5E0", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x87BD640", Offset = "0x87BC640", VA = "0x1887BD640", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x87BD550", Offset = "0x87BC550", VA = "0x1887BD550", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x87BD680", Offset = "0x87BC680", VA = "0x1887BD680", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x87BD6C0", Offset = "0x87BC6C0", VA = "0x1887BD6C0")]
		private void YAIJCJNPARX()
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
		public static Color PKDCXAHEXMV
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x87A8610", Offset = "0x87A7610", VA = "0x1887A8610")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color OKXSIQPLPFZ
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x87A8630", Offset = "0x87A7630", VA = "0x1887A8630")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color IIXCYBJBREX
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x87A8840", Offset = "0x87A7840", VA = "0x1887A8840")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2DD64A0", Offset = "0x2DD54A0", VA = "0x182DD64A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1862330", Offset = "0x1861330", VA = "0x181862330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2E31C10", Offset = "0x2E30C10", VA = "0x182E31C10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2E31C20", Offset = "0x2E30C20", VA = "0x182E31C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BAAD20", Offset = "0x2BA9D20", VA = "0x182BAAD20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x32B7D50", Offset = "0x32B6D50", VA = "0x1832B7D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x151C780", Offset = "0x151B780", VA = "0x18151C780")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x151C790", Offset = "0x151B790", VA = "0x18151C790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C6A0", Offset = "0x2B6B6A0", VA = "0x182B6C6A0")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x87A8640", Offset = "0x87A7640", VA = "0x1887A8640", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x87A86F0", Offset = "0x87A76F0", VA = "0x1887A86F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x87A8790", Offset = "0x87A7790", VA = "0x1887A8790", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x87A8860", Offset = "0x87A7860", VA = "0x1887A8860")]
		public static bool SIHBZTKNPGZ(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class YBDCAOWIQBX : IEquatable<YBDCAOWIQBX>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly YBDCAOWIQBX DPWTJJPKGSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] YBGQMSQJXIA;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float UQCMQGGMJAH
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x87BFC40", Offset = "0x87BEC40", VA = "0x1887BFC40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x87BFCD0", Offset = "0x87BECD0", VA = "0x1887BFCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float PLFBBNEFVHO
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x87BF4C0", Offset = "0x87BE4C0", VA = "0x1887BF4C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x87BF3D0", Offset = "0x87BE3D0", VA = "0x1887BF3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float IRKWNQWROKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x87BFA60", Offset = "0x87BEA60", VA = "0x1887BFA60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x87BF970", Offset = "0x87BE970", VA = "0x1887BF970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float CMPMLPVKOVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x87BFB20", Offset = "0x87BEB20", VA = "0x1887BFB20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x87BFBB0", Offset = "0x87BEBB0", VA = "0x1887BFBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float UQHTNNAJSLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x87BFCA0", Offset = "0x87BECA0", VA = "0x1887BFCA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x87BFD30", Offset = "0x87BED30", VA = "0x1887BFD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float PLUVTHLXXPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x87BF4F0", Offset = "0x87BE4F0", VA = "0x1887BF4F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x87BF400", Offset = "0x87BE400", VA = "0x1887BF400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float IQVBVWOZMCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x87BFA30", Offset = "0x87BEA30", VA = "0x1887BFA30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x87BF940", Offset = "0x87BE940", VA = "0x1887BF940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float CMKFOJBNFKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x87BFAC0", Offset = "0x87BEAC0", VA = "0x1887BFAC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x87BFB50", Offset = "0x87BEB50", VA = "0x1887BFB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float UQNAKTUHBWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x87BFC70", Offset = "0x87BEC70", VA = "0x1887BFC70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x87BFD00", Offset = "0x87BED00", VA = "0x1887BFD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float PLPOWASAOEG
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x87BF520", Offset = "0x87BE520", VA = "0x1887BF520")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x87BF430", Offset = "0x87BE430", VA = "0x1887BF430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float IRAITDIWVOH
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x87BFA00", Offset = "0x87BEA00", VA = "0x1887BFA00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x87BF910", Offset = "0x87BE910", VA = "0x1887BF910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float CMEYRCHPVZG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x87BFAF0", Offset = "0x87BEAF0", VA = "0x1887BFAF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x87BFB80", Offset = "0x87BEB80", VA = "0x1887BFB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float UQSHIAOELII
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x87BFC10", Offset = "0x87BEC10", VA = "0x1887BFC10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x87BFD60", Offset = "0x87BED60", VA = "0x1887BFD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float PMFJNUZSQMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x87BF490", Offset = "0x87BE490", VA = "0x1887BF490")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x87BF460", Offset = "0x87BE460", VA = "0x1887BF460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float IQKOBJBETGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x87BF9D0", Offset = "0x87BE9D0", VA = "0x1887BF9D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x87BF9A0", Offset = "0x87BE9A0", VA = "0x1887BF9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float CLZRTVNSMNX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x87BFA90", Offset = "0x87BEA90", VA = "0x1887BFA90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x87BFBE0", Offset = "0x87BEBE0", VA = "0x1887BFBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x87BFE70", Offset = "0x87BEE70", VA = "0x1887BFE70")]
		public YBDCAOWIQBX(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x87BF550", Offset = "0x87BE550", VA = "0x1887BF550", Slot = "4")]
		public bool Equals(YBDCAOWIQBX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x87BF810", Offset = "0x87BE810", VA = "0x1887BF810", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x10D0050", Offset = "0x10CF050", VA = "0x1810D0050", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DD64A0", Offset = "0x2DD54A0", VA = "0x182DD64A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x1862330", Offset = "0x1861330", VA = "0x181862330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2E31C10", Offset = "0x2E30C10", VA = "0x182E31C10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2E31C20", Offset = "0x2E30C20", VA = "0x182E31C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2BAAD20", Offset = "0x2BA9D20", VA = "0x182BAAD20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32B7D50", Offset = "0x32B6D50", VA = "0x1832B7D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x151C780", Offset = "0x151B780", VA = "0x18151C780")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x151C790", Offset = "0x151B790", VA = "0x18151C790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x87B7C80", Offset = "0x87B6C80", VA = "0x1887B7C80")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x87B78E0", Offset = "0x87B68E0", VA = "0x1887B78E0", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x87B7A00", Offset = "0x87B6A00", VA = "0x1887B7A00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x87B7AB0", Offset = "0x87B6AB0", VA = "0x1887B7AB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x87B7B90", Offset = "0x87B6B90", VA = "0x1887B7B90")]
		public static bool SIHBZTKNPGZ(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DD64A0", Offset = "0x2DD54A0", VA = "0x182DD64A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1862330", Offset = "0x1861330", VA = "0x181862330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2E31C10", Offset = "0x2E30C10", VA = "0x182E31C10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2E31C20", Offset = "0x2E30C20", VA = "0x182E31C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x103F930", Offset = "0x103E930", VA = "0x18103F930")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x87BE540", Offset = "0x87BD540", VA = "0x1887BE540")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x87BE350", Offset = "0x87BD350", VA = "0x1887BE350", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x87BE3B0", Offset = "0x87BD3B0", VA = "0x1887BE3B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x87BE490", Offset = "0x87BD490", VA = "0x1887BE490", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x87BE4E0", Offset = "0x87BD4E0", VA = "0x1887BE4E0")]
		public static bool SIHBZTKNPGZ(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DD64A0", Offset = "0x2DD54A0", VA = "0x182DD64A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1862330", Offset = "0x1861330", VA = "0x181862330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2E31C10", Offset = "0x2E30C10", VA = "0x182E31C10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2E31C20", Offset = "0x2E30C20", VA = "0x182E31C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2BAAD20", Offset = "0x2BA9D20", VA = "0x182BAAD20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32B7D50", Offset = "0x32B6D50", VA = "0x1832B7D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x87BE900", Offset = "0x87BD900", VA = "0x1887BE900")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x87BE560", Offset = "0x87BD560", VA = "0x1887BE560", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x87BE640", Offset = "0x87BD640", VA = "0x1887BE640", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x87BE700", Offset = "0x87BD700", VA = "0x1887BE700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x87BE7B0", Offset = "0x87BD7B0", VA = "0x1887BE7B0")]
		public static bool SIHBZTKNPGZ(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DD64A0", Offset = "0x2DD54A0", VA = "0x182DD64A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1862330", Offset = "0x1861330", VA = "0x181862330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E31C10", Offset = "0x2E30C10", VA = "0x182E31C10")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2E31C20", Offset = "0x2E30C20", VA = "0x182E31C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2BAAD20", Offset = "0x2BA9D20", VA = "0x182BAAD20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x32B7D50", Offset = "0x32B6D50", VA = "0x1832B7D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x151C780", Offset = "0x151B780", VA = "0x18151C780")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x151C790", Offset = "0x151B790", VA = "0x18151C790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C6A0", Offset = "0x2B6B6A0", VA = "0x182B6C6A0")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x87A8640", Offset = "0x87A7640", VA = "0x1887A8640", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x87BE980", Offset = "0x87BD980", VA = "0x1887BE980", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x87A8790", Offset = "0x87A7790", VA = "0x1887A8790", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class YQESLDAZOFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x87C0590", Offset = "0x87BF590", VA = "0x1887C0590")]
		public static void VIOHUPCRRFK(this JObject a, string b, SPMHSBGNIDT c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class ZGGHFTOLRRH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x87C1660", Offset = "0x87C0660", VA = "0x1887C1660")]
		public static List<string> FIZDUOKJFTV(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x87C14A0", Offset = "0x87C04A0", VA = "0x1887C14A0")]
		public static List<double> DQTNVWDDXHZ(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x87C28B0", Offset = "0x87C18B0", VA = "0x1887C28B0")]
		public static List<int> TUHIJRZWCSK(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4121910", Offset = "0x4120910", VA = "0x184121910")]
		public static List<a> HJUEEVJVJNE<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x87C2220", Offset = "0x87C1220", VA = "0x1887C2220")]
		public static SPMHSBGNIDT PBPOBOUICHW(this JToken a, UERVNJFVUCH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x87C2770", Offset = "0x87C1770", VA = "0x1887C2770")]
		public static int TAUVJRVKOQG(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x87C1360", Offset = "0x87C0360", VA = "0x1887C1360")]
		public static double ABISKUOZGGM(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x87C1C80", Offset = "0x87C0C80", VA = "0x1887C1C80")]
		public static GLTF.Math.Color JFTSBOVYSBR(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x87C2D80", Offset = "0x87C1D80", VA = "0x1887C2D80")]
		public static GLTF.Math.Color YRXNLDXEKCM(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x87C24D0", Offset = "0x87C14D0", VA = "0x1887C24D0")]
		public static GLTF.Math.Color RXBDOLWNFAM(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x87C1F60", Offset = "0x87C0F60", VA = "0x1887C1F60")]
		public static GLTF.Math.Vector3 LIARXXBYKXA(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x87C1810", Offset = "0x87C0810", VA = "0x1887C1810")]
		public static GLTF.Math.Vector2 GPZTHVWMRLO(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x87C1A20", Offset = "0x87C0A20", VA = "0x1887C1A20")]
		public static GLTF.Math.Vector3 GQFAFCQKAWX(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x87C2A70", Offset = "0x87C1A70", VA = "0x1887C2A70")]
		public static GLTF.Math.Quaternion VQWJHYGJTEO(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4121D80", Offset = "0x4120D80", VA = "0x184121D80")]
		public static Dictionary<string, b> ZEYIAHDPZGO<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x41215F0", Offset = "0x41205F0", VA = "0x1841215F0")]
		public static c ATRDRGCDZNQ<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public EWTVDJXEXKJ bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x87A95E0", Offset = "0x87A85E0", VA = "0x1887A95E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x87A9560", Offset = "0x87A8560", VA = "0x1887A9560", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class GMONWTFHIUE : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x87AA800", Offset = "0x87A9800", VA = "0x1887AA800")]
		public GMONWTFHIUE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x87AA730", Offset = "0x87A9730", VA = "0x1887AA730", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, IDGLSJLJFQE> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x87A9420", Offset = "0x87A8420", VA = "0x1887A9420", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x87A94E0", Offset = "0x87A84E0", VA = "0x1887A94E0")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TTOSXDIQMQK : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public UERVNJFVUCH DIIJJEHZBXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader YSIFOUGOOUB;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x87B6120", Offset = "0x87B5120", VA = "0x1887B6120")]
			internal IDGLSJLJFQE LSPAUNQPBAZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x87BDEA0", Offset = "0x87BCEA0", VA = "0x1887BDEA0")]
		public TTOSXDIQMQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x87BDD10", Offset = "0x87BCD10", VA = "0x1887BDD10", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public VYMNMMRKMRE OOHGWTYDANZ;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public EXT_texture_exr(VYMNMMRKMRE source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x87A9630", Offset = "0x87A8630", VA = "0x1887A9630", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x87A96A0", Offset = "0x87A86A0", VA = "0x1887A96A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class GPXPIXPBBSL : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x87AA970", Offset = "0x87A9970", VA = "0x1887AA970")]
		public GPXPIXPBBSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x87AA850", Offset = "0x87A9850", VA = "0x1887AA850", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
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
	public class AudioEmitterId : GGGQOQDCTER<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x87A7B20", Offset = "0x87A6B20", VA = "0x1887A7B20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x87A7AE0", Offset = "0x87A6AE0", VA = "0x1887A7AE0")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : GGGQOQDCTER<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x87A7CB0", Offset = "0x87A6CB0", VA = "0x1887A7CB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x87A7C70", Offset = "0x87A6C70", VA = "0x1887A7C70")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : GGGQOQDCTER<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x87A7990", Offset = "0x87A6990", VA = "0x1887A7990", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x87A7950", Offset = "0x87A6950", VA = "0x1887A7950")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x87A7870", Offset = "0x87A6870", VA = "0x1887A7870")]
		public static AudioDataId Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x87AFD20", Offset = "0x87AED20", VA = "0x1887AFD20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x87AF920", Offset = "0x87AE920", VA = "0x1887AF920", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x87AF990", Offset = "0x87AE990", VA = "0x1887AF990")]
		public static KHR_SceneAudioEmittersRef Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x87AFF80", Offset = "0x87AEF80", VA = "0x1887AFF80")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x87AF8F0", Offset = "0x87AE8F0", VA = "0x1887AF8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x87AF7D0", Offset = "0x87AE7D0", VA = "0x1887AF7D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x87AF5C0", Offset = "0x87AE5C0", VA = "0x1887AF5C0", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x87AF630", Offset = "0x87AE630", VA = "0x1887AF630")]
		public static KHR_NodeAudioEmitterRef Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class WAVYPRMIKOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string IKDRGMWKYLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? JDLEKWOZEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? HXYANQRVMLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? VKEUMWTEYFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? OBFATBONHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? HZOYZOMUEIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? FWYTOVOPRUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? UGFYZIIVICV;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x87BEA20", Offset = "0x87BDA20", VA = "0x1887BEA20")]
		public JObject BIDIANLANQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x87BEC90", Offset = "0x87BDC90", VA = "0x1887BEC90")]
		public static WAVYPRMIKOG Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public WAVYPRMIKOG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : LDTEMUBYLUP
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
		public WAVYPRMIKOG positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x87AE710", Offset = "0x87AD710", VA = "0x1887AE710", Slot = "5")]
		public virtual JObject BIDIANLANQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x87AEAB0", Offset = "0x87ADAB0", VA = "0x1887AEAB0")]
		public static KHR_AudioEmitter Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x87AEFB0", Offset = "0x87ADFB0", VA = "0x1887AEFB0")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : LDTEMUBYLUP
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
		[Cpp2IlInjected.Address(RVA = "0x87AF030", Offset = "0x87AE030", VA = "0x1887AF030")]
		public JObject BIDIANLANQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x87AF260", Offset = "0x87AE260", VA = "0x1887AF260")]
		public static KHR_AudioSource Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x87AE700", Offset = "0x87AD700", VA = "0x1887AE700")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : LDTEMUBYLUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public GVQOJDFIKHO bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x87AE370", Offset = "0x87AD370", VA = "0x1887AE370")]
		public JObject BIDIANLANQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x87AE4A0", Offset = "0x87AD4A0", VA = "0x1887AE4A0")]
		public static KHR_AudioData Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x87AE700", Offset = "0x87AD700", VA = "0x1887AE700")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : SCANKLONFJU
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
		[Cpp2IlInjected.Address(RVA = "0x87B0240", Offset = "0x87AF240", VA = "0x1887B0240", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x87B01B0", Offset = "0x87AF1B0", VA = "0x1887B01B0", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x87B0970", Offset = "0x87AF970", VA = "0x1887B0970")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ZCCZAZLCPBP : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x87C11C0", Offset = "0x87C01C0", VA = "0x1887C11C0")]
		public ZCCZAZLCPBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x87C0610", Offset = "0x87BF610", VA = "0x1887C0610", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public GVQOJDFIKHO bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x87B0B40", Offset = "0x87AFB40", VA = "0x1887B0B40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x87B0A80", Offset = "0x87AFA80", VA = "0x1887B0A80", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x87B0B90", Offset = "0x87AFB90", VA = "0x1887B0B90")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class VJKCKTFUHDV : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader YSIFOUGOOUB;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x87B61D0", Offset = "0x87B51D0", VA = "0x1887B61D0")]
			internal int LSPAUNQPBAZ()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x87BE300", Offset = "0x87BD300", VA = "0x1887BE300")]
		public VJKCKTFUHDV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x87BE0F0", Offset = "0x87BD0F0", VA = "0x1887BE0F0", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public SPMHSBGNIDT anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x87B0C90", Offset = "0x87AFC90", VA = "0x1887B0C90", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x87B0C10", Offset = "0x87AFC10", VA = "0x1887B0C10", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class FYOZDNFCMWU : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x87A9940", Offset = "0x87A8940", VA = "0x1887A9940")]
		public FYOZDNFCMWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x87A9790", Offset = "0x87A8790", VA = "0x1887A9790", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public SPMHSBGNIDT clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public SPMHSBGNIDT clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public SPMHSBGNIDT clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x87B0F40", Offset = "0x87AFF40", VA = "0x1887B0F40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x87B0EA0", Offset = "0x87AFEA0", VA = "0x1887B0EA0", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class CBKYHOGBTVO : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x87A81D0", Offset = "0x87A71D0", VA = "0x1887A81D0")]
		public CBKYHOGBTVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x87A7F50", Offset = "0x87A6F50", VA = "0x1887A7F50", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x87B12A0", Offset = "0x87B02A0", VA = "0x1887B12A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x87B1230", Offset = "0x87B0230", VA = "0x1887B1230", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class PKDIANYGRPI : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x87B7480", Offset = "0x87B6480", VA = "0x1887B7480")]
		public PKDIANYGRPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x87B73B0", Offset = "0x87B63B0", VA = "0x1887B73B0", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : ECXWEJRESYG, SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float HHPOMNRUJRW;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x87B15F0", Offset = "0x87B05F0", VA = "0x1887B15F0")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x87B1580", Offset = "0x87B0580", VA = "0x1887B1580")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, UERVNJFVUCH root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x87B13C0", Offset = "0x87B03C0", VA = "0x1887B13C0", Slot = "6")]
		public SCANKLONFJU Clone(UERVNJFVUCH gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x87B1460", Offset = "0x87B0460", VA = "0x1887B1460", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class CAZCOATIRWP : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x87A7F00", Offset = "0x87A6F00", VA = "0x1887A7F00")]
		public CAZCOATIRWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x87A7E00", Offset = "0x87A6E00", VA = "0x1887A7E00", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x87B16A0", Offset = "0x87B06A0", VA = "0x1887B16A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x87B1640", Offset = "0x87B0640", VA = "0x1887B1640", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x87B17F0", Offset = "0x87B07F0", VA = "0x1887B17F0")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class EQLWRGOINNG : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x87A92A0", Offset = "0x87A82A0", VA = "0x1887A92A0")]
		public EQLWRGOINNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x87A91D0", Offset = "0x87A81D0", VA = "0x1887A91D0", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public SPMHSBGNIDT iridescenceTexture;

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
		public SPMHSBGNIDT iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x87B18A0", Offset = "0x87B08A0", VA = "0x1887B18A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x87B1800", Offset = "0x87B0800", VA = "0x1887B1800", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x87B1C60", Offset = "0x87B0C60", VA = "0x1887B1C60")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class PMAREJWVRHY : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x87B77C0", Offset = "0x87B67C0", VA = "0x1887B77C0")]
		public PMAREJWVRHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x87B74D0", Offset = "0x87B64D0", VA = "0x1887B74D0", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class GDLOZEEXMQF : SCANKLONFJU
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 BNSRLTGLYYL;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double RXQXPYQEJJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color WGVKXHQNPLV;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color CVBPZJBKPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public SPMHSBGNIDT SUFDHVQSJSP;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly SPMHSBGNIDT UBNOUUSOZYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 DGMZKBGUTNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double FACEHHOGZVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public SPMHSBGNIDT WIXSMFKKTSE;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly SPMHSBGNIDT ZNXBGFENNXK;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x87AA570", Offset = "0x87A9570", VA = "0x1887AA570")]
		public GDLOZEEXMQF(GLTF.Math.Color a, SPMHSBGNIDT b, GLTF.Math.Vector3 c, double d, SPMHSBGNIDT e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x87A9C40", Offset = "0x87A8C40", VA = "0x1887A9C40", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x87A9E00", Offset = "0x87A8E00", VA = "0x1887A9E00", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class PFOLAQYZUSZ : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x87B7360", Offset = "0x87B6360", VA = "0x1887B7360")]
		public PFOLAQYZUSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x87B7000", Offset = "0x87B6000", VA = "0x1887B7000", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public SPMHSBGNIDT sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public SPMHSBGNIDT sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x87B1D50", Offset = "0x87B0D50", VA = "0x1887B1D50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x87B1C80", Offset = "0x87B0C80", VA = "0x1887B1C80", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x87B2260", Offset = "0x87B1260", VA = "0x1887B2260")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class FZMUNYZQNVZ : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x87A9BF0", Offset = "0x87A8BF0", VA = "0x1887A9BF0")]
		public FZMUNYZQNVZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x87A9990", Offset = "0x87A8990", VA = "0x1887A9990", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public SPMHSBGNIDT specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public SPMHSBGNIDT specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x87B23A0", Offset = "0x87B13A0", VA = "0x1887B23A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x87B22D0", Offset = "0x87B12D0", VA = "0x1887B22D0", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x87B28C0", Offset = "0x87B18C0", VA = "0x1887B28C0")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class TNQHKUDCPJH : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x87BDCC0", Offset = "0x87BCCC0", VA = "0x1887BDCC0")]
		public TNQHKUDCPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x87BDAA0", Offset = "0x87BCAA0", VA = "0x1887BDAA0", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public SPMHSBGNIDT transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x87B29B0", Offset = "0x87B19B0", VA = "0x1887B29B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x87B2930", Offset = "0x87B1930", VA = "0x1887B2930", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class TZXDMMEKFDW : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x87BE030", Offset = "0x87BD030", VA = "0x1887BE030")]
		public TZXDMMEKFDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x87BDEF0", Offset = "0x87BCEF0", VA = "0x1887BDEF0", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class CEPDQFMQASB : ECXWEJRESYG, SCANKLONFJU
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x87A85C0", Offset = "0x87A75C0", VA = "0x1887A85C0")]
		public CEPDQFMQASB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x87A8550", Offset = "0x87A7550", VA = "0x1887A8550")]
		public CEPDQFMQASB(CEPDQFMQASB a, UERVNJFVUCH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x87A83E0", Offset = "0x87A73E0", VA = "0x1887A83E0", Slot = "6")]
		public SCANKLONFJU Clone(UERVNJFVUCH gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x87A8350", Offset = "0x87A7350", VA = "0x1887A8350", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x87A8480", Offset = "0x87A7480", VA = "0x1887A8480", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class PPLONQIAECZ : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x87B7890", Offset = "0x87B6890", VA = "0x1887B7890")]
		public PPLONQIAECZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x87B7810", Offset = "0x87B6810", VA = "0x1887B7810", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public SPMHSBGNIDT thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x87B2BD0", Offset = "0x87B1BD0", VA = "0x1887B2BD0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x87B2B40", Offset = "0x87B1B40", VA = "0x1887B2B40", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x87B3100", Offset = "0x87B2100", VA = "0x1887B3100")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class OIGATQEQKRE : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x87B6FB0", Offset = "0x87B5FB0", VA = "0x1887B6FB0")]
		public OIGATQEQKRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x87B6DA0", Offset = "0x87B5DA0", VA = "0x1887B6DA0", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x87B3180", Offset = "0x87B2180", VA = "0x1887B3180", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x87B3120", Offset = "0x87B2120", VA = "0x1887B3120", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x12275E0", Offset = "0x12265E0", VA = "0x1812275E0")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class ETPMDSJEUGW : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x87A93D0", Offset = "0x87A83D0", VA = "0x1887A93D0")]
		public ETPMDSJEUGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x87A92F0", Offset = "0x87A82F0", VA = "0x1887A92F0", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x87B32F0", Offset = "0x87B22F0", VA = "0x1887B32F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x87B3290", Offset = "0x87B2290", VA = "0x1887B3290", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x12275E0", Offset = "0x12265E0", VA = "0x1812275E0")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class CDHEMUFDOHM : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x87A8300", Offset = "0x87A7300", VA = "0x1887A8300")]
		public CDHEMUFDOHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x87A8220", Offset = "0x87A7220", VA = "0x1887A8220", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x87B3460", Offset = "0x87B2460", VA = "0x1887B3460", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x87B3400", Offset = "0x87B2400", VA = "0x1887B3400", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x12275E0", Offset = "0x12265E0", VA = "0x1812275E0")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class REUPANBBWBQ : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x87B7DF0", Offset = "0x87B6DF0", VA = "0x1887B7DF0")]
		public REUPANBBWBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x87B7D10", Offset = "0x87B6D10", VA = "0x1887B7D10", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public VYMNMMRKMRE source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public KHR_texture_basisu(VYMNMMRKMRE source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x87B3570", Offset = "0x87B2570", VA = "0x1887B3570", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x87B35E0", Offset = "0x87B25E0", VA = "0x1887B35E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class SSVRDXXQQZU : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x87B8960", Offset = "0x87B7960", VA = "0x1887B8960")]
		public SSVRDXXQQZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x87B8800", Offset = "0x87B7800", VA = "0x1887B8800", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class SGMEXDAOWFL : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 HHSVCYRNGMR;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 HFQTLSSVTQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double CDENTUISUSA;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double KQNXCWHSPVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 ZNEFDMSKVKE;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 YRWPXNVPTPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? FVDTHWPNXSI;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int IVVAWVFINRY;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x87B8780", Offset = "0x87B7780", VA = "0x1887B8780")]
		public SGMEXDAOWFL(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x87B8030", Offset = "0x87B7030", VA = "0x1887B8030", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x87B8110", Offset = "0x87B7110", VA = "0x1887B8110", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class YBEIWFPSHYR : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x87C03F0", Offset = "0x87BF3F0", VA = "0x1887C03F0")]
		public YBEIWFPSHYR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x87C0120", Offset = "0x87BF120", VA = "0x1887C0120", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class SCFKLURWVFD : SCANKLONFJU
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> RYOFDZCVUVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public SCFKLURWVFD(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x87B7E40", Offset = "0x87B6E40", VA = "0x1887B7E40", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x87B7F40", Offset = "0x87B6F40", VA = "0x1887B7F40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x87B7EB0", Offset = "0x87B6EB0", VA = "0x1887B7EB0")]
		public List<double> DPBIXGQIWGD(BNPRQWVLIYC a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class YGCLJKKPFUN : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x87C0540", Offset = "0x87BF540", VA = "0x1887C0540")]
		public YGCLJKKPFUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x87C0440", Offset = "0x87BF440", VA = "0x1887C0440", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class STKNFTIDSJL : LDTEMUBYLUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public GVQOJDFIKHO EWTVDJXEXKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint PTRNJDEOKQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType SIMRQTCECOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool XKCFPMNBVCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint XKLXOHCJQTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType AHRPWOVSMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> IBASZTLBKKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> GJTRAYLEXAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public YVYNNUPMEND YERXJYKTILE;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x87AE700", Offset = "0x87AD700", VA = "0x1887AE700")]
		public STKNFTIDSJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x87B9490", Offset = "0x87B8490", VA = "0x1887B9490")]
		public static STKNFTIDSJL Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x87B8A10", Offset = "0x87B7A10", VA = "0x1887B8A10", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x87B9A60", Offset = "0x87B8A60", VA = "0x1887B9A60")]
		private unsafe static sbyte EMIBJVMKYCU(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x87BC2D0", Offset = "0x87BB2D0", VA = "0x1887BC2D0")]
		private unsafe static float2 VRIEKTDLBDE(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x87BC7F0", Offset = "0x87BB7F0", VA = "0x1887BC7F0")]
		private unsafe static float3 XDPQKRZSDWT(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x87BC270", Offset = "0x87BB270", VA = "0x1887BC270")]
		private unsafe static float4 VCPAOVRGSGQ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x87B9E10", Offset = "0x87B8E10", VA = "0x1887B9E10")]
		private unsafe static float4x4 EZSEURZFLHG(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x87B9A60", Offset = "0x87B8A60", VA = "0x1887B9A60")]
		private unsafe static byte IKZUOLVXAHL(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x87BB120", Offset = "0x87BA120", VA = "0x1887BB120")]
		private unsafe static float2 OIXAMZZMAEZ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x87BC220", Offset = "0x87BB220", VA = "0x1887BC220")]
		private unsafe static float3 UOGXXEAFTYA(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x87B89B0", Offset = "0x87B79B0", VA = "0x1887B89B0")]
		private unsafe static float4 BDFUHMCSKGX(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x87BAD30", Offset = "0x87B9D30", VA = "0x1887BAD30")]
		private unsafe static float4x4 LFJTKGDERPN(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x87B9420", Offset = "0x87B8420", VA = "0x1887B9420")]
		private unsafe static short YYUEMIABQLO(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x87BAD00", Offset = "0x87B9D00", VA = "0x1887BAD00")]
		private unsafe static float2 LEFWGJRGTBM(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x87B9B40", Offset = "0x87B8B40", VA = "0x1887B9B40")]
		private unsafe static float3 EPFHTOHQLML(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x87BA010", Offset = "0x87B9010", VA = "0x1887BA010")]
		private unsafe static float4 JANAJWIVPMU(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x87BA580", Offset = "0x87B9580", VA = "0x1887BA580")]
		private unsafe static float4x4 KLPBYWILPEY(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x87B9420", Offset = "0x87B8420", VA = "0x1887B9420")]
		private unsafe static ushort ULKWZHSCCTJ(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x87B9FE0", Offset = "0x87B8FE0", VA = "0x1887B9FE0")]
		private unsafe static float2 IKLFKCXUSVV(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x87BA070", Offset = "0x87B9070", VA = "0x1887BA070")]
		private unsafe static float3 JEAAVBPFFHA(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x87BBE00", Offset = "0x87BAE00", VA = "0x1887BBE00")]
		private unsafe static float4x4 TLKDWQTYCQR(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x87BC0B0", Offset = "0x87BB0B0", VA = "0x1887BC0B0")]
		private unsafe static float4 UEBDPLKTGVL(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x87BBC80", Offset = "0x87BAC80", VA = "0x1887BBC80")]
		private unsafe static uint SYZJOKPSJHE(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x87B9420", Offset = "0x87B8420", VA = "0x1887B9420")]
		private unsafe static ushort BXBJHKUPLQX(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x87B9430", Offset = "0x87B8430", VA = "0x1887B9430")]
		private unsafe static float CAAYZUWGPTW(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x87BB480", Offset = "0x87BA480", VA = "0x1887BB480")]
		private unsafe static float2 QNHPVOOVCLY(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x87BB460", Offset = "0x87BA460", VA = "0x1887BB460")]
		private unsafe static float3 PSSNQVSSAID(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x87B9FB0", Offset = "0x87B8FB0", VA = "0x1887B9FB0")]
		private unsafe static float4 GLIEGQUKAWQ(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x87BC430", Offset = "0x87BB430", VA = "0x1887BC430")]
		private unsafe static float4x4 WKURZQFNUAQ(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x87B9FB0", Offset = "0x87B8FB0", VA = "0x1887B9FB0")]
		private unsafe static float4 LBJLRZTORTN(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x87BACD0", Offset = "0x87B9CD0", VA = "0x1887BACD0")]
		private unsafe static float4 LBJLRZTORTN(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x87BA0C0", Offset = "0x87B90C0", VA = "0x1887BA0C0")]
		public static float3[] JWVZXXZJWAW(STKNFTIDSJL a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x87BB150", Offset = "0x87BA150", VA = "0x1887BB150")]
		public static float3[] OUEADNGHIKK(STKNFTIDSJL a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x87BD0A0", Offset = "0x87BC0A0", VA = "0x1887BD0A0")]
		public static uint[] ZIAEJWIATLJ(STKNFTIDSJL a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x87BBB60", Offset = "0x87BAB60", VA = "0x1887BBB60")]
		internal static void SAZIERTTPAE(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x87BAED0", Offset = "0x87B9ED0", VA = "0x1887BAED0")]
		public uint[] LKPDPVQWHYD(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x87B91B0", Offset = "0x87B81B0", VA = "0x1887B91B0")]
		public float[] BLMMRNBPZQJ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x87BA2F0", Offset = "0x87B92F0", VA = "0x1887BA2F0")]
		public float2[] KIQCLDMDMTR(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x87BCAB0", Offset = "0x87BBAB0", VA = "0x1887BCAB0")]
		public float2[] XSYUVRAWZDH(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x87B9B90", Offset = "0x87B8B90", VA = "0x1887B9B90")]
		public float3[] EUJESSSMYMC(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x87BB4A0", Offset = "0x87BA4A0", VA = "0x1887BB4A0")]
		public float3[] QOHGBSTAZMO(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x87BC840", Offset = "0x87BB840", VA = "0x1887BC840")]
		public float4[] XSUDHVPTGZP(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x87BB7F0", Offset = "0x87BA7F0", VA = "0x1887BB7F0")]
		public float4[] RHRGAEZNFXH(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x87BC460", Offset = "0x87BB460", VA = "0x1887BC460")]
		public float4[] WVQSFHXODIC(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x87BC110", Offset = "0x87BB110", VA = "0x1887BC110")]
		public float3[] UHPSREAQRAR(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x87BBFA0", Offset = "0x87BAFA0", VA = "0x1887BBFA0")]
		public float3[] UCOFRSXPGGG(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x87B9A70", Offset = "0x87B8A70", VA = "0x1887B9A70")]
		public float4[] ENVMBEINVIE(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x87B9440", Offset = "0x87B8440", VA = "0x1887B9440")]
		public uint[] CZPJETOOHJN(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x87BA720", Offset = "0x87B9720", VA = "0x1887BA720")]
		public float4x4[] KSWSFTJIRZY(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x87BCD60", Offset = "0x87BBD60", VA = "0x1887BCD60")]
		private unsafe static float4 ZCJRRQXTOSI(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x87BCF20", Offset = "0x87BBF20", VA = "0x1887BCF20")]
		private unsafe static float4 ZCJRRQXTOSI(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x87B98F0", Offset = "0x87B88F0", VA = "0x1887B98F0")]
		private unsafe static float4x4 EFQIWKFFZFP(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x87B8FF0", Offset = "0x87B7FF0", VA = "0x1887B8FF0")]
		private unsafe static float4 BIINITNWZVD(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x87BBC90", Offset = "0x87BAC90", VA = "0x1887BBC90")]
		private unsafe static float3 TIMNOLEFYBE(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x87BC300", Offset = "0x87BB300", VA = "0x1887BC300")]
		private unsafe static float2 VUQUFLZADKD(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x87BD210", Offset = "0x87BC210", VA = "0x1887BD210")]
		private unsafe static uint ZXTEJNZJMZU(void* a, uint b, GLTFComponentType c)
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
	public static class ORVGHTPQFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x87CEF10", Offset = "0x87CDF10", VA = "0x1887CEF10")]
		public static int ETOHNGZROSY(this GLTFAccessorAttributeType a)
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
	public class YVYNNUPMEND : ECXWEJRESYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int XKLXOHCJQTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public XCLIXPPPZDI ZVSJRBOTCTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public OPJATKSLRDB GUWWKCOCJNO;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x87D85F0", Offset = "0x87D75F0", VA = "0x1887D85F0")]
		public YVYNNUPMEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x87D8320", Offset = "0x87D7320", VA = "0x1887D8320")]
		public static YVYNNUPMEND Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x87D81F0", Offset = "0x87D71F0", VA = "0x1887D81F0", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class XCLIXPPPZDI : ECXWEJRESYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public GVQOJDFIKHO EWTVDJXEXKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int PTRNJDEOKQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType SIMRQTCECOB;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x87D6010", Offset = "0x87D5010", VA = "0x1887D6010")]
		public XCLIXPPPZDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x87D5D30", Offset = "0x87D4D30", VA = "0x1887D5D30")]
		public static XCLIXPPPZDI Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x87D5BF0", Offset = "0x87D4BF0", VA = "0x1887D5BF0", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class OPJATKSLRDB : ECXWEJRESYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public GVQOJDFIKHO EWTVDJXEXKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int PTRNJDEOKQH;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x87CEEC0", Offset = "0x87CDEC0", VA = "0x1887CEEC0")]
		public OPJATKSLRDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x87CEC40", Offset = "0x87CDC40", VA = "0x1887CEC40")]
		public static OPJATKSLRDB Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x87CEB40", Offset = "0x87CDB40", VA = "0x1887CEB40", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class EMYPSKMNSTB : ECXWEJRESYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AXIRKDIIUDT PCPGRFMMXDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public UIHQQYDXELM INMRPJHSODZ;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x87C8CD0", Offset = "0x87C7CD0", VA = "0x1887C8CD0")]
		public EMYPSKMNSTB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x87C8AE0", Offset = "0x87C7AE0", VA = "0x1887C8AE0")]
		public static EMYPSKMNSTB Deserialize(UERVNJFVUCH root, JsonReader reader, VSSBAKDLQAP anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x87C89E0", Offset = "0x87C79E0", VA = "0x1887C89E0", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class UIHQQYDXELM : ECXWEJRESYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public RAEDKCMOFAT BNPRQWVLIYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string HGGJHTIYZTT;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x87D4770", Offset = "0x87D3770", VA = "0x1887D4770")]
		public static UIHQQYDXELM Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x87D49D0", Offset = "0x87D39D0", VA = "0x1887D49D0")]
		public UIHQQYDXELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x87D4650", Offset = "0x87D3650", VA = "0x1887D4650", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
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
	public class FATHUGIXVDL
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(FATHUGIXVDL data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] ULGLLOCSOTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type HEFJNUJPCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] TJKMXTGEFDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion WAHXVXELRHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string RMPZOYKZTQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string QDTCYPUBZUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public WQRQPKBXLOB ACKEXXBIACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string EHITOHZVDNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string EPHNVTZEZBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public WQRQPKBXLOB SZNMMGTGDZC;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x87C9460", Offset = "0x87C8460", VA = "0x1887C9460")]
		public FATHUGIXVDL()
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
	public class DESDHPZHUSQ : ECXWEJRESYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public IDGLSJLJFQE JZAQNLOYPIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType CFGAKUKJWUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public IDGLSJLJFQE XZKARMEIFVR;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x87C6130", Offset = "0x87C5130", VA = "0x1887C6130")]
		public DESDHPZHUSQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x87C5F10", Offset = "0x87C4F10", VA = "0x1887C5F10")]
		public static DESDHPZHUSQ Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x87C5DA0", Offset = "0x87C4DA0", VA = "0x1887C5DA0", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class CFOWZJVZUAC : ECXWEJRESYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string HFODJOORMUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string MBTYHLYJEPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string WZQEDLFLMPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string ZLDXLLRRQXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> QJOVAMUYJOS;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x87C57E0", Offset = "0x87C47E0", VA = "0x1887C57E0")]
		public CFOWZJVZUAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x87C5110", Offset = "0x87C4110", VA = "0x1887C5110")]
		public static CFOWZJVZUAC Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x87C4CF0", Offset = "0x87C3CF0", VA = "0x1887C4CF0", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x87C57D0", Offset = "0x87C47D0", VA = "0x1887C57D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x87C5430", Offset = "0x87C4430", VA = "0x1887C5430")]
		public string QOXGGEJDGZM(bool a)
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
	public class EWTVDJXEXKJ : LDTEMUBYLUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public DDLGXDXGOJD XEOFGXYAWIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint PTRNJDEOKQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint MNUGZUBOHCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint EKOYJYKJLMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget INMRPJHSODZ;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x87C33E0", Offset = "0x87C23E0", VA = "0x1887C33E0")]
		public EWTVDJXEXKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x87C91B0", Offset = "0x87C81B0", VA = "0x1887C91B0")]
		public static EWTVDJXEXKJ Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x87C8FA0", Offset = "0x87C7FA0", VA = "0x1887C8FA0", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class ISMUCUYLKWX : ECXWEJRESYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double JZEEFGBZMNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double CQYNYBFQOWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double XRWWWJWVZKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double HXCLOMOXWVM;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x87CB320", Offset = "0x87CA320", VA = "0x1887CB320")]
		public ISMUCUYLKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x87CAFA0", Offset = "0x87C9FA0", VA = "0x1887CAFA0")]
		public static ISMUCUYLKWX Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x87CAE30", Offset = "0x87C9E30", VA = "0x1887CAE30", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class GJOEWHMGVEB : ECXWEJRESYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double KRCIPFGBRLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double UPUQGPUANJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double XRWWWJWVZKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double HXCLOMOXWVM;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x87C9A00", Offset = "0x87C8A00", VA = "0x1887C9A00")]
		public GJOEWHMGVEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x87C9690", Offset = "0x87C8690", VA = "0x1887C9690")]
		public static GJOEWHMGVEB Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x87C9500", Offset = "0x87C8500", VA = "0x1887C9500", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class VSSBAKDLQAP : LDTEMUBYLUP
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public UERVNJFVUCH DIIJJEHZBXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader YSIFOUGOOUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public VSSBAKDLQAP ISNNBHINJFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<EMYPSKMNSTB> CTYFGCOATLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<DESDHPZHUSQ> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x87CDC40", Offset = "0x87CCC40", VA = "0x1887CDC40")]
			internal EMYPSKMNSTB LSPAUNQPBAZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x87CDC30", Offset = "0x87CCC30", VA = "0x1887CDC30")]
			internal DESDHPZHUSQ LSJTXGWRRPQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<EMYPSKMNSTB> WXFHGEPHFJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<DESDHPZHUSQ> NTZAOTIYDUH;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x87D51D0", Offset = "0x87D41D0", VA = "0x1887D51D0")]
		public static VSSBAKDLQAP Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x87D5590", Offset = "0x87D4590", VA = "0x1887D5590")]
		public VSSBAKDLQAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x87D4E30", Offset = "0x87D3E30", VA = "0x1887D4E30", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class POQORNVBAUV : LDTEMUBYLUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string KWGUSREMEMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint MNUGZUBOHCY;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x87C33E0", Offset = "0x87C23E0", VA = "0x1887C33E0")]
		public POQORNVBAUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x87CF3B0", Offset = "0x87CE3B0", VA = "0x1887CF3B0")]
		public static POQORNVBAUV Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x87CF260", Offset = "0x87CE260", VA = "0x1887CF260", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class CZKJHUNYBZS : LDTEMUBYLUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public ISMUCUYLKWX VIINRSHGMQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public GJOEWHMGVEB LKOGCAREBAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType AHRPWOVSMCK;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x87C33E0", Offset = "0x87C23E0", VA = "0x1887C33E0")]
		public CZKJHUNYBZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x87C5A50", Offset = "0x87C4A50", VA = "0x1887C5A50")]
		public static CZKJHUNYBZS Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x87C5880", Offset = "0x87C4880", VA = "0x1887C5880", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
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
	public class LDTEMUBYLUP : ECXWEJRESYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string PAVMQALYVSV;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x87C33E0", Offset = "0x87C23E0", VA = "0x1887C33E0")]
		public LDTEMUBYLUP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x87CDA30", Offset = "0x87CCA30", VA = "0x1887CDA30")]
		public LDTEMUBYLUP(LDTEMUBYLUP a, UERVNJFVUCH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x87CD940", Offset = "0x87CC940", VA = "0x1887CD940")]
		public new void NXOAIZDTFAV(UERVNJFVUCH a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x87CD8B0", Offset = "0x87CC8B0", VA = "0x1887CD8B0", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class GGGQOQDCTER<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int OSRJHZIEHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public UERVNJFVUCH OTBMMIANHVU;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		protected GGGQOQDCTER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x63C65D0", Offset = "0x63C55D0", VA = "0x1863C65D0")]
		public GGGQOQDCTER(GGGQOQDCTER<a> a, UERVNJFVUCH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x63C65A0", Offset = "0x63C55A0", VA = "0x1863C65A0")]
		public void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class IDGLSJLJFQE : GGGQOQDCTER<STKNFTIDSJL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override STKNFTIDSJL Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x87CADD0", Offset = "0x87C9DD0", VA = "0x1887CADD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x87CAD30", Offset = "0x87C9D30", VA = "0x1887CAD30")]
		public IDGLSJLJFQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x87CAD70", Offset = "0x87C9D70", VA = "0x1887CAD70")]
		public IDGLSJLJFQE(IDGLSJLJFQE a, UERVNJFVUCH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x87CAC50", Offset = "0x87C9C50", VA = "0x1887CAC50")]
		public static IDGLSJLJFQE Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class DDLGXDXGOJD : GGGQOQDCTER<POQORNVBAUV>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override POQORNVBAUV Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x87C5D40", Offset = "0x87C4D40", VA = "0x1887C5D40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x87C5D00", Offset = "0x87C4D00", VA = "0x1887C5D00")]
		public DDLGXDXGOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x87C5C20", Offset = "0x87C4C20", VA = "0x1887C5C20")]
		public static DDLGXDXGOJD Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class GVQOJDFIKHO : GGGQOQDCTER<EWTVDJXEXKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override EWTVDJXEXKJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x87C9B80", Offset = "0x87C8B80", VA = "0x1887C9B80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x87C9B40", Offset = "0x87C8B40", VA = "0x1887C9B40")]
		public GVQOJDFIKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x87C9A60", Offset = "0x87C8A60", VA = "0x1887C9A60")]
		public static GVQOJDFIKHO Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class JHIWGKURQMI : GGGQOQDCTER<CZKJHUNYBZS>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override CZKJHUNYBZS Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x87CB490", Offset = "0x87CA490", VA = "0x1887CB490", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x87CB450", Offset = "0x87CA450", VA = "0x1887CB450")]
		public JHIWGKURQMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x87CB370", Offset = "0x87CA370", VA = "0x1887CB370")]
		public static JHIWGKURQMI Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class VYMNMMRKMRE : GGGQOQDCTER<VLLZSORQYWY>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override VLLZSORQYWY Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x87D57A0", Offset = "0x87D47A0", VA = "0x1887D57A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x87D5760", Offset = "0x87D4760", VA = "0x1887D5760")]
		public VYMNMMRKMRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x87D5680", Offset = "0x87D4680", VA = "0x1887D5680")]
		public static VYMNMMRKMRE Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class XCZTLLYHLTM : GGGQOQDCTER<SLNDRLNTQSK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override SLNDRLNTQSK Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x87D61E0", Offset = "0x87D51E0", VA = "0x1887D61E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x87D6140", Offset = "0x87D5140", VA = "0x1887D6140")]
		public XCZTLLYHLTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x87D6180", Offset = "0x87D5180", VA = "0x1887D6180")]
		public XCZTLLYHLTM(XCZTLLYHLTM a, UERVNJFVUCH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x87D6060", Offset = "0x87D5060", VA = "0x1887D6060")]
		public static XCZTLLYHLTM Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class WJBLLUWLFQO : GGGQOQDCTER<KEGNTSUKHCS>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override KEGNTSUKHCS Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x87D5920", Offset = "0x87D4920", VA = "0x1887D5920", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x87D58E0", Offset = "0x87D48E0", VA = "0x1887D58E0")]
		public WJBLLUWLFQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x87D5800", Offset = "0x87D4800", VA = "0x1887D5800")]
		public static WJBLLUWLFQO Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class RAEDKCMOFAT : GGGQOQDCTER<BNPRQWVLIYC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override BNPRQWVLIYC Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x87CFCD0", Offset = "0x87CECD0", VA = "0x1887CFCD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x87CFC90", Offset = "0x87CEC90", VA = "0x1887CFC90")]
		public RAEDKCMOFAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x87CF940", Offset = "0x87CE940", VA = "0x1887CF940")]
		public static RAEDKCMOFAT Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x87CFA20", Offset = "0x87CEA20", VA = "0x1887CFA20")]
		public static List<RAEDKCMOFAT> HJUEEVJVJNE(UERVNJFVUCH a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class NRUABXMCXRB : GGGQOQDCTER<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x87CE470", Offset = "0x87CD470", VA = "0x1887CE470", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x87CE430", Offset = "0x87CD430", VA = "0x1887CE430")]
		public NRUABXMCXRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x87CE350", Offset = "0x87CD350", VA = "0x1887CE350")]
		public static NRUABXMCXRB Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class AXIRKDIIUDT : GGGQOQDCTER<DESDHPZHUSQ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public VSSBAKDLQAP VSSBAKDLQAP;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override DESDHPZHUSQ Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x87C3570", Offset = "0x87C2570", VA = "0x1887C3570", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x87C3530", Offset = "0x87C2530", VA = "0x1887C3530")]
		public AXIRKDIIUDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x87C3430", Offset = "0x87C2430", VA = "0x1887C3430")]
		public static AXIRKDIIUDT Deserialize(UERVNJFVUCH root, VSSBAKDLQAP anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class MUOKTOTIOUD : GGGQOQDCTER<AEXOKVPAWJL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override AEXOKVPAWJL Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x87CE2F0", Offset = "0x87CD2F0", VA = "0x1887CE2F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x87CE2B0", Offset = "0x87CD2B0", VA = "0x1887CE2B0")]
		public MUOKTOTIOUD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x87CE1D0", Offset = "0x87CD1D0", VA = "0x1887CE1D0")]
		public static MUOKTOTIOUD Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class LPFPFTVONNQ : GGGQOQDCTER<HVQYZLZNOUD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override HVQYZLZNOUD Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x87CDBD0", Offset = "0x87CCBD0", VA = "0x1887CDBD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x87CDB90", Offset = "0x87CCB90", VA = "0x1887CDB90")]
		public LPFPFTVONNQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x87CDAB0", Offset = "0x87CCAB0", VA = "0x1887CDAB0")]
		public static LPFPFTVONNQ Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class DNXSZXHEMYU : GGGQOQDCTER<QCAQDNLPIHA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override QCAQDNLPIHA Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x87C6300", Offset = "0x87C5300", VA = "0x1887C6300", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x87C62C0", Offset = "0x87C52C0", VA = "0x1887C62C0")]
		public DNXSZXHEMYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x87C6260", Offset = "0x87C5260", VA = "0x1887C6260")]
		public DNXSZXHEMYU(DNXSZXHEMYU a, UERVNJFVUCH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x87C6180", Offset = "0x87C5180", VA = "0x1887C6180")]
		public static DNXSZXHEMYU Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class BJOPQUCHUSD : GGGQOQDCTER<EVKNITPLLMN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override EVKNITPLLMN Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x87C3610", Offset = "0x87C2610", VA = "0x1887C3610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x87C35D0", Offset = "0x87C25D0", VA = "0x1887C35D0")]
		public BJOPQUCHUSD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class VLLZSORQYWY : LDTEMUBYLUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string KWGUSREMEMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string UQOQAKTUZVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public GVQOJDFIKHO EWTVDJXEXKJ;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x87C33E0", Offset = "0x87C23E0", VA = "0x1887C33E0")]
		public VLLZSORQYWY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x87D4BF0", Offset = "0x87D3BF0", VA = "0x1887D4BF0")]
		public static VLLZSORQYWY Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x87D4A20", Offset = "0x87D3A20", VA = "0x1887D4A20", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class SLNDRLNTQSK : LDTEMUBYLUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public NSPHLQDJVUH NSPHLQDJVUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public MQWPHPHPJDY NFUIGVFBWNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public HRUUBCADFFC CXMQQKNREAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public ZHPOYWZKNQG OOJVCBRJGBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public SPMHSBGNIDT KGJUTVYJXOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color DWZOVRCBLRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode RISQAKBURRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double FNKLQFENDUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool YPOFEZHSDMA;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x87D0BC0", Offset = "0x87CFBC0", VA = "0x1887D0BC0")]
		public SLNDRLNTQSK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x87D06B0", Offset = "0x87CF6B0", VA = "0x1887D06B0")]
		public static SLNDRLNTQSK Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x87D0250", Offset = "0x87CF250", VA = "0x1887D0250", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
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
	public class KEGNTSUKHCS : LDTEMUBYLUP
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class QBUTDWRBSPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public UERVNJFVUCH DIIJJEHZBXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader YSIFOUGOOUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<KNRAFUBCCEM> CTYFGCOATLZ;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBUTDWRBSPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x87CF5F0", Offset = "0x87CE5F0", VA = "0x1887CF5F0")]
			internal KNRAFUBCCEM LSPAUNQPBAZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<KNRAFUBCCEM> GOQABVHNXVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> TSLJRRQOXNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> FPWWQXQOBSV;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x87C33E0", Offset = "0x87C23E0", VA = "0x1887C33E0")]
		public KEGNTSUKHCS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x87CBAA0", Offset = "0x87CAAA0", VA = "0x1887CBAA0")]
		public static KEGNTSUKHCS Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x87CB4F0", Offset = "0x87CA4F0", VA = "0x1887CB4F0", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class ECXWEJRESYG
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, NLZCYZKYXSD> XMHCJFMJINZ;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static PYARDRBNPRE OFLDSBZWUKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, SCANKLONFJU> FXNGDWFXXYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken CQJJAETRKVT;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x87C7140", Offset = "0x87C6140", VA = "0x1887C7140")]
		public static NLZCYZKYXSD NJFVTNUEPFQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x87C7580", Offset = "0x87C6580", VA = "0x1887C7580")]
		public static SCANKLONFJU OPIBTNGSMGM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public ECXWEJRESYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x87C86F0", Offset = "0x87C76F0", VA = "0x1887C86F0")]
		public ECXWEJRESYG(ECXWEJRESYG a, [Optional] UERVNJFVUCH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x87C72D0", Offset = "0x87C62D0", VA = "0x1887C72D0")]
		public void NXOAIZDTFAV(UERVNJFVUCH a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x87C6FF0", Offset = "0x87C5FF0", VA = "0x1887C6FF0")]
		public void ECTIFKIBYXE(string a, SCANKLONFJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x87C7DD0", Offset = "0x87C6DD0", VA = "0x1887C7DD0")]
		private void XSDNZXDWCHM(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x87C7730", Offset = "0x87C6730", VA = "0x1887C7730")]
		private void URFKXJHMHLQ(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x87C7670", Offset = "0x87C6670", VA = "0x1887C7670")]
		private void RPWLSYHYBLU(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x87C77F0", Offset = "0x87C67F0", VA = "0x1887C77F0")]
		internal static Dictionary<string, SCANKLONFJU> WSPDLEBAEID(UERVNJFVUCH a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C70", Offset = "0x87C5C70", VA = "0x1887C6C70", Slot = "4")]
		public virtual void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class UERVNJFVUCH : ECXWEJRESYG
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class OWXPRIASNUK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public UERVNJFVUCH DIIJJEHZBXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader RXCZFKTOGZZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<STKNFTIDSJL> CTYFGCOATLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<VSSBAKDLQAP> CTSYIVUDKAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<POQORNVBAUV> CUITAQBVMIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<EWTVDJXEXKJ> CUDMDJHYCXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<CZKJHUNYBZS> CUTGVDPQFFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<VLLZSORQYWY> CUNZXWVSVUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<SLNDRLNTQSK> CVDUPRDKYCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<KEGNTSUKHCS> CUYNSKJNOQS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<BNPRQWVLIYC> CVOIKERFQYT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> CVJBMXXIHNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<AEXOKVPAWJL> IBPNQVJUAMY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<HVQYZLZNOUD> IBUUOCDRJYH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<QCAQDNLPIHA> ICABLIXOTJQ;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public OWXPRIASNUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x87CF090", Offset = "0x87CE090", VA = "0x1887CF090")]
			internal STKNFTIDSJL LSPAUNQPBAZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x87CF080", Offset = "0x87CE080", VA = "0x1887CF080")]
			internal VSSBAKDLQAP LSJTXGWRRPQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x87CF070", Offset = "0x87CE070", VA = "0x1887CF070")]
			internal POQORNVBAUV LSENAACUIEH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x87CF060", Offset = "0x87CE060", VA = "0x1887CF060")]
			internal EWTVDJXEXKJ LRZGCTIWYSY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x87CF050", Offset = "0x87CE050", VA = "0x1887CF050")]
			internal CZKJHUNYBZS LRTZFMOZPHP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x87CF040", Offset = "0x87CE040", VA = "0x1887CF040")]
			internal VLLZSORQYWY LROSIFVCFWG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x87CF030", Offset = "0x87CE030", VA = "0x1887CF030")]
			internal SLNDRLNTQSK LRJLKZBEWKX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x87CF020", Offset = "0x87CE020", VA = "0x1887CF020")]
			internal KEGNTSUKHCS LREENSHHMZO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x87CF0B0", Offset = "0x87CE0B0", VA = "0x1887CF0B0")]
			internal BNPRQWVLIYC LUFDYPTTYNT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x87CF0A0", Offset = "0x87CE0A0", VA = "0x1887CF0A0")]
			internal Sampler LTZXBIZWPCK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x87CF0D0", Offset = "0x87CE0D0", VA = "0x1887CF0D0")]
			internal AEXOKVPAWJL WYLEQERYTYK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x87CF250", Offset = "0x87CE250", VA = "0x1887CF250")]
			internal HVQYZLZNOUD WYQLNLLWDJT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x87CF0C0", Offset = "0x87CE0C0", VA = "0x1887CF0C0")]
			internal QCAQDNLPIHA WYAQVREEBBS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> CCEESNADWPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> UIOLMAJPNMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<STKNFTIDSJL> ZAXQFOJLFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<VSSBAKDLQAP> CPGFCOWNCGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public CFOWZJVZUAC CFOWZJVZUAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<POQORNVBAUV> GBDBJXINNKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<EWTVDJXEXKJ> HFHSXRKCGKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<CZKJHUNYBZS> RQLKOFKIXAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<VLLZSORQYWY> BCFEYWYCKQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<SLNDRLNTQSK> WLJIYPALFAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<KEGNTSUKHCS> BSKZCXFMKHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<BNPRQWVLIYC> EAEXVPLVXDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> NTZAOTIYDUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public MUOKTOTIOUD TMJQAQKHIQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<AEXOKVPAWJL> NHPGQOQKPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<HVQYZLZNOUD> NRFOVEUCGBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<QCAQDNLPIHA> IZNBZFPFXNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<EVKNITPLLMN> KWIMPUHOTBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool BIXHFJRIFKJ;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x87D4600", Offset = "0x87D3600", VA = "0x1887D4600")]
		public UERVNJFVUCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x87D4560", Offset = "0x87D3560", VA = "0x1887D4560")]
		public AEXOKVPAWJL NTRUCEUKYZL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x87D3710", Offset = "0x87D2710", VA = "0x1887D3710")]
		public static UERVNJFVUCH Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x87D1B60", Offset = "0x87D0B60", VA = "0x1887D1B60")]
		public void BIDIANLANQI(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class AEXOKVPAWJL : LDTEMUBYLUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<RAEDKCMOFAT> EAEXVPLVXDJ;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x87C33E0", Offset = "0x87C23E0", VA = "0x1887C33E0")]
		public AEXOKVPAWJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x87C3260", Offset = "0x87C2260", VA = "0x1887C3260")]
		public static AEXOKVPAWJL Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x87C2FF0", Offset = "0x87C1FF0", VA = "0x1887C2FF0", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class QCAQDNLPIHA : LDTEMUBYLUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public NRUABXMCXRB PCPGRFMMXDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public VYMNMMRKMRE GWJIKPBWSOP;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x87C33E0", Offset = "0x87C23E0", VA = "0x1887C33E0")]
		public QCAQDNLPIHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x87CF770", Offset = "0x87CE770", VA = "0x1887CF770")]
		public static QCAQDNLPIHA Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x87CF600", Offset = "0x87CE600", VA = "0x1887CF600", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class KEHGRHNENYL : EVKNITPLLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x87C33E0", Offset = "0x87C23E0", VA = "0x1887C33E0")]
		public KEHGRHNENYL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x87CBE60", Offset = "0x87CAE60", VA = "0x1887CBE60", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class EVKNITPLLMN : LDTEMUBYLUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string GAXOXHPQSZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color LIIEPYIPHRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string RHTSDVZKJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float JADXMWYTTNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float JDFJFZTWXOT;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x87C33E0", Offset = "0x87C23E0", VA = "0x1887C33E0")]
		public EVKNITPLLMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x87C8D20", Offset = "0x87C7D20", VA = "0x1887C8D20", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class VWJSOMEPQIJ : EVKNITPLLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x87C33E0", Offset = "0x87C23E0", VA = "0x1887C33E0")]
		public VWJSOMEPQIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x87CBE60", Offset = "0x87CAE60", VA = "0x1887CBE60", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class YHGLTJWGYBX : EVKNITPLLMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float ZVSDXMXQDZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float FEMBRIFCFJL;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x87D7480", Offset = "0x87D6480", VA = "0x1887D7480")]
		public YHGLTJWGYBX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x87D7180", Offset = "0x87D6180", VA = "0x1887D7180", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface EEDLATZCKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IKQJCGKZJYL(UERVNJFVUCH a, EOCWOASBPZS b, [Out] FATHUGIXVDL c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface SCANKLONFJU
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		SCANKLONFJU Clone(UERVNJFVUCH root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class NLZCYZKYXSD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string XOOAQURAGKI;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		protected NLZCYZKYXSD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class OWGGKOEVFFW : SCANKLONFJU
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty DHWZMEWUSJN
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x87CEF70", Offset = "0x87CDF70", VA = "0x1887CEF70", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public OWGGKOEVFFW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class PYARDRBNPRE : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x87CF580", Offset = "0x87CE580", VA = "0x1887CF580", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public PYARDRBNPRE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class MQWPHPHPJDY : ECXWEJRESYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color ONIXAMBRHRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public SPMHSBGNIDT IIVEEPCYIDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color KYHWVPGFCCT;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x87CE160", Offset = "0x87CD160", VA = "0x1887CE160")]
		public MQWPHPHPJDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x87CDEC0", Offset = "0x87CCEC0", VA = "0x1887CDEC0")]
		public static MQWPHPHPJDY Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x87CDC60", Offset = "0x87CCC60", VA = "0x1887CDC60", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class HRUUBCADFFC : SPMHSBGNIDT
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string ZPXTVBSHBEI = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double ZNEFDMSKVKE;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x87CA4D0", Offset = "0x87C94D0", VA = "0x1887CA4D0")]
		public HRUUBCADFFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x87CA1E0", Offset = "0x87C91E0", VA = "0x1887CA1E0")]
		public new static HRUUBCADFFC Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x87CA120", Offset = "0x87C9120", VA = "0x1887CA120", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ZHPOYWZKNQG : SPMHSBGNIDT
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string FISIOYAOYMP = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double THNKUFBCRID;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x87CA4D0", Offset = "0x87C94D0", VA = "0x1887CA4D0")]
		public ZHPOYWZKNQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x87D8700", Offset = "0x87D7700", VA = "0x1887D8700")]
		public new static ZHPOYWZKNQG Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x87D8640", Offset = "0x87D7640", VA = "0x1887D8640", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class NSPHLQDJVUH : ECXWEJRESYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color PPDLXBBWTAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public SPMHSBGNIDT VAWDRCXKROV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double GCVRTUZEDZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double HIGMVTTXQFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public SPMHSBGNIDT LGRGDEHRGCG;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x87CEAD0", Offset = "0x87CDAD0", VA = "0x1887CEAD0")]
		public NSPHLQDJVUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x87CE760", Offset = "0x87CD760", VA = "0x1887CE760")]
		public static NSPHLQDJVUH Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x87CE4D0", Offset = "0x87CD4D0", VA = "0x1887CE4D0", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class KNRAFUBCCEM : ECXWEJRESYG
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class RNIKRFKQYEV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader YSIFOUGOOUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public UERVNJFVUCH DIIJJEHZBXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<IDGLSJLJFQE> CTYFGCOATLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<IDGLSJLJFQE> CUITAQBVMIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, IDGLSJLJFQE>> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public RNIKRFKQYEV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x87CFEB0", Offset = "0x87CEEB0", VA = "0x1887CFEB0")]
			internal IDGLSJLJFQE LSPAUNQPBAZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x87CFE00", Offset = "0x87CEE00", VA = "0x1887CFE00")]
			internal Dictionary<string, IDGLSJLJFQE> LSJTXGWRRPQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x87CFD30", Offset = "0x87CED30", VA = "0x1887CFD30")]
			internal IDGLSJLJFQE LSENAACUIEH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, IDGLSJLJFQE> JSYNJMAAEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IDGLSJLJFQE ZVSJRBOTCTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public XCZTLLYHLTM PPDPXHUEIBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode PMVUTXWAKMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, IDGLSJLJFQE>> PABKAZJISXW;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x87CD170", Offset = "0x87CC170", VA = "0x1887CD170")]
		public KNRAFUBCCEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x87CD210", Offset = "0x87CC210", VA = "0x1887CD210")]
		public KNRAFUBCCEM(KNRAFUBCCEM a, UERVNJFVUCH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x87CBE70", Offset = "0x87CAE70", VA = "0x1887CBE70")]
		public static int[] AJSZOUZTNAC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x87CC6C0", Offset = "0x87CB6C0", VA = "0x1887CC6C0")]
		public static int[] BILEZTFFZWK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x87CBF10", Offset = "0x87CAF10", VA = "0x1887CBF10")]
		public static int[] BEXZDXYSKEE(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x87CCDE0", Offset = "0x87CBDE0", VA = "0x1887CCDE0")]
		public static int[] QDOTQGUSDDG(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x87CD0C0", Offset = "0x87CC0C0", VA = "0x1887CD0C0")]
		public static int[] YFGGEHAHGPB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x87CCC70", Offset = "0x87CBC70", VA = "0x1887CCC70")]
		public static int[] IKRAIPRBYHM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x87CD030", Offset = "0x87CC030", VA = "0x1887CD030")]
		public static int[] XMGTSEXYFWI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x87CCCE0", Offset = "0x87CBCE0", VA = "0x1887CCCE0")]
		public static int[] KCCENSCPUSH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x87CCD50", Offset = "0x87CBD50", VA = "0x1887CCD50")]
		public static int[] MTZFBSIIQHT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x87CC820", Offset = "0x87CB820", VA = "0x1887CC820")]
		public static KNRAFUBCCEM Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x87CC0D0", Offset = "0x87CB0D0", VA = "0x1887CC0D0", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class RYEONQTQVKT
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] FVDTHWPNXSI;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] OCTDXXQMYUJ;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] IQBIDXJZYPY;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] JTZUJRBTUZI;
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
	public class BNPRQWVLIYC : LDTEMUBYLUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool MZAFZQGBGLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public JHIWGKURQMI SHXCRXCGDXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<RAEDKCMOFAT> BKYSRCUXUVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public LPFPFTVONNQ HVQYZLZNOUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public YBDCAOWIQBX SXTOICIFJDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public WJBLLUWLFQO WVJADLDSKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion CDENTUISUSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 ZNEFDMSKVKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 WDYUBFHEHQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> TSLJRRQOXNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public BJOPQUCHUSD KHTMUUIBRXQ;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x87C4BB0", Offset = "0x87C3BB0", VA = "0x1887C4BB0")]
		public BNPRQWVLIYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x87C4270", Offset = "0x87C3270", VA = "0x1887C4270")]
		public static BNPRQWVLIYC Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x87C3670", Offset = "0x87C2670", VA = "0x1887C3670", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : LDTEMUBYLUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode ZALFIUIVUIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode AAZYHMZFSGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode RDPQMEOAHJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode REPYYMJNCOO;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x87D15E0", Offset = "0x87D05E0", VA = "0x1887D15E0")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x87D1310", Offset = "0x87D0310", VA = "0x1887D1310")]
		public static Sampler Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x87D1120", Offset = "0x87D0120", VA = "0x1887D1120", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
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
	public class HVQYZLZNOUD : LDTEMUBYLUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public IDGLSJLJFQE SZTSYNZVJYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public RAEDKCMOFAT MWCQHCEMRGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<RAEDKCMOFAT> DQRHDFZQTHJ;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x87CABA0", Offset = "0x87C9BA0", VA = "0x1887CABA0")]
		public HVQYZLZNOUD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x87CA840", Offset = "0x87C9840", VA = "0x1887CA840")]
		public static HVQYZLZNOUD Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x87CA530", Offset = "0x87C9530", VA = "0x1887CA530", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class SPMHSBGNIDT : ECXWEJRESYG
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string YDCOUUPTBNU = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string RIBNEXWVDPW = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public DNXSZXHEMYU TGJWVQQFQVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int FVDTHWPNXSI;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x87D10D0", Offset = "0x87D00D0", VA = "0x1887D10D0")]
		public SPMHSBGNIDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x87D0FE0", Offset = "0x87CFFE0", VA = "0x1887D0FE0")]
		public SPMHSBGNIDT(SPMHSBGNIDT a, UERVNJFVUCH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x87D0C90", Offset = "0x87CFC90", VA = "0x1887D0C90")]
		public static SPMHSBGNIDT Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x87D0C30", Offset = "0x87CFC30", VA = "0x1887D0C30", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x87D0F10", Offset = "0x87CFF10", VA = "0x1887D0F10")]
		public void EPDYJBIRUER(JsonWriter a)
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
	public class HDGGHAYUBVI
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double VGIASEKSOOQ;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double PGMDNRIYPKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double IMILNSAFRLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double FVCTDLCDSEB;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x87CA0A0", Offset = "0x87C90A0", VA = "0x1887CA0A0")]
		public HDGGHAYUBVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x87C9DF0", Offset = "0x87C8DF0", VA = "0x1887C9DF0")]
		public static HDGGHAYUBVI Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x87C9BE0", Offset = "0x87C8BE0", VA = "0x1887C9BE0")]
		public void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class YTYYONBFDJK : LDTEMUBYLUP
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color CQAADWQWXXV;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double CRJBXNBMUOV;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double FQUOVONPLPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType AHRPWOVSMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color OCTDXXQMYUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double NECFDIMDOEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double EAJQFRXTAUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public HDGGHAYUBVI HDGGHAYUBVI;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x87D8130", Offset = "0x87D7130", VA = "0x1887D8130")]
		public YTYYONBFDJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x87D8000", Offset = "0x87D7000", VA = "0x1887D8000")]
		public YTYYONBFDJK(YTYYONBFDJK a, UERVNJFVUCH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x87D7A70", Offset = "0x87D6A70", VA = "0x1887D7A70")]
		public static YTYYONBFDJK Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x87D7E60", Offset = "0x87D6E60", VA = "0x1887D7E60")]
		public static YTYYONBFDJK Deserialize(UERVNJFVUCH root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x87D7710", Offset = "0x87D6710", VA = "0x1887D7710", Slot = "4")]
		public override void BIDIANLANQI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class DZZLTTHWLFA : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<EVKNITPLLMN> HGXHUNGUGKX;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public DZZLTTHWLFA(IList<EVKNITPLLMN> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x87C63D0", Offset = "0x87C53D0", VA = "0x1887C63D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x87C6360", Offset = "0x87C5360", VA = "0x1887C6360", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class XUDNOTFCVLU : SCANKLONFJU, EEDLATZCKHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<YTYYONBFDJK> KWIMPUHOTBN;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x87D7100", Offset = "0x87D6100", VA = "0x1887D7100")]
		public XUDNOTFCVLU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x87D64F0", Offset = "0x87D54F0", VA = "0x1887D64F0", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x87D7010", Offset = "0x87D6010", VA = "0x1887D7010", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x87D6240", Offset = "0x87D5240", VA = "0x1887D6240")]
		private static string[] BELFEWCHSBK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x87D6780", Offset = "0x87D5780", VA = "0x1887D6780")]
		private static FATHUGIXVDL.ImportValuesConversion DUZXAQTHXNE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x87D6C20", Offset = "0x87D5C20", VA = "0x1887D6C20", Slot = "6")]
		public bool IKQJCGKZJYL(UERVNJFVUCH a, EOCWOASBPZS b, [Out] FATHUGIXVDL c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class WVRTREARKUN : GGGQOQDCTER<YTYYONBFDJK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override YTYYONBFDJK Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x87D5AA0", Offset = "0x87D4AA0", VA = "0x1887D5AA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x87D5A60", Offset = "0x87D4A60", VA = "0x1887D5A60")]
		public WVRTREARKUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x87D5980", Offset = "0x87D4980", VA = "0x1887D5980")]
		public static WVRTREARKUN Deserialize(UERVNJFVUCH root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class YNVLXFIMBCW : SCANKLONFJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public WVRTREARKUN BJOPQUCHUSD;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public YNVLXFIMBCW(WVRTREARKUN a, UERVNJFVUCH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x87D7650", Offset = "0x87D6650", VA = "0x1887D7650")]
		public YNVLXFIMBCW(int a, UERVNJFVUCH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x87D74D0", Offset = "0x87D64D0", VA = "0x1887D74D0", Slot = "5")]
		public SCANKLONFJU Clone(UERVNJFVUCH root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x87D7550", Offset = "0x87D6550", VA = "0x1887D7550", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class ZNYVHNNIAZV : NLZCYZKYXSD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x87D8EE0", Offset = "0x87D7EE0", VA = "0x1887D8EE0")]
		public ZNYVHNNIAZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x87D89F0", Offset = "0x87D79F0", VA = "0x1887D89F0", Slot = "4")]
		public override SCANKLONFJU Deserialize(UERVNJFVUCH root, JProperty extensionToken)
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
