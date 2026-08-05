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
	public class KHR_animation_pointer : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object BYXKPDPKLPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string WXZNKMYLIRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string JKKRNUNRFZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public LGRWJKLCJVO KRUFJEJGDLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer YMPMNJWTKLR;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x735FB90", Offset = "0x735E990", VA = "0x18735FB90", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x735FAE0", Offset = "0x735E8E0", VA = "0x18735FAE0", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class LEOXZCMBQKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 SNGDESUFHAO;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 JKADCJFDCTX;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion IRHDYJTYSOJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool IOHRRVOSMLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7366620", Offset = "0x7365420", VA = "0x187366620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7365F30", Offset = "0x7364D30", VA = "0x187365F30")]
		public static void TZCJSWAYDMF(this YMNWEWAXNPC a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7363800", Offset = "0x7362600", VA = "0x187363800")]
		public static void ACPXHIGRACX(this YMNWEWAXNPC a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7364A60", Offset = "0x7363860", VA = "0x187364A60")]
		public static void KWMUIDVZERU(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7365B10", Offset = "0x7364910", VA = "0x187365B10")]
		public static GLTF.Math.Vector4 RGWADOHLZSG(this FPNBMRBYURJ a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x73667E0", Offset = "0x73655E0", VA = "0x1873667E0")]
		public static UnityEngine.Quaternion YKGLXRJPIFT(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x73666B0", Offset = "0x73654B0", VA = "0x1873666B0")]
		public static UnityEngine.Quaternion YKGLXRJPIFT(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7363F80", Offset = "0x7362D80", VA = "0x187363F80")]
		public static GLTF.Math.Quaternion BEZGWULZDSD(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x73631A0", Offset = "0x7361FA0", VA = "0x1873631A0")]
		public static Matrix4x4 ABXZJOSOGGY(this FPNBMRBYURJ a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x73633C0", Offset = "0x73621C0", VA = "0x1873633C0")]
		public static Matrix4x4 ABXZJOSOGGY(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x73641D0", Offset = "0x7362FD0", VA = "0x1873641D0")]
		public static FPNBMRBYURJ EAPEWHTOTCS(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7365E10", Offset = "0x7364C10", VA = "0x187365E10")]
		public static UnityEngine.Vector3 RLABVUNVTLX(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7365D30", Offset = "0x7364B30", VA = "0x187365D30")]
		public static UnityEngine.Vector3 RLABVUNVTLX(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7365080", Offset = "0x7363E80", VA = "0x187365080")]
		public static GLTF.Math.Vector3 MGKOXPBWINN(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7364E30", Offset = "0x7363C30", VA = "0x187364E30")]
		public static GLTF.Math.Vector3 LDUBUTNHPGW(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1145D20", Offset = "0x1144B20", VA = "0x181145D20")]
		public static GLTF.Math.Vector4 LQYYHLUIEQR(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7365400", Offset = "0x7364200", VA = "0x187365400")]
		public static Matrix4x4 PTUBPNATTAB(this FPNBMRBYURJ a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x73656C0", Offset = "0x73644C0", VA = "0x1873656C0")]
		public static Matrix4x4 PTUBPNATTAB(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7363DB0", Offset = "0x7362BB0", VA = "0x187363DB0")]
		public static FPNBMRBYURJ BESAWOYVFUD(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7364970", Offset = "0x7363770", VA = "0x187364970")]
		public static UnityEngine.Vector2 IKWSQIOHBEF(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7364970", Offset = "0x7363770", VA = "0x187364970")]
		public static UnityEngine.Vector2 IKWSQIOHBEF(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7364990", Offset = "0x7363790", VA = "0x187364990")]
		public static void IKWSQIOHBEF(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x73665C0", Offset = "0x73653C0", VA = "0x1873665C0")]
		public static UnityEngine.Vector3 TZEWQOWCCUE(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1B50FE0", Offset = "0x1B4FDE0", VA = "0x181B50FE0")]
		public static UnityEngine.Vector3 TZEWQOWCCUE(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x73664D0", Offset = "0x73652D0", VA = "0x1873664D0")]
		public static void TZEWQOWCCUE(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1145D20", Offset = "0x1144B20", VA = "0x181145D20")]
		public static UnityEngine.Vector4 LSDMOMRTGAL(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1145D20", Offset = "0x1144B20", VA = "0x181145D20")]
		public static UnityEngine.Vector4 LSDMOMRTGAL(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7364E70", Offset = "0x7363C70", VA = "0x187364E70")]
		public static UnityEngine.Vector4[] LSDMOMRTGAL(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7364F70", Offset = "0x7363D70", VA = "0x187364F70")]
		public static void LSDMOMRTGAL(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7365930", Offset = "0x7364730", VA = "0x187365930")]
		public static UnityEngine.Color QUUORRUWAVD(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x73659D0", Offset = "0x73647D0", VA = "0x1873659D0")]
		public static void QUUORRUWAVD(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7365930", Offset = "0x7364730", VA = "0x187365930")]
		public static UnityEngine.Color QUUORRUWAVD(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1145D20", Offset = "0x1144B20", VA = "0x181145D20")]
		public static UnityEngine.Color CZAMDWNYPAA(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x73640C0", Offset = "0x7362EC0", VA = "0x1873640C0")]
		public static void CZAMDWNYPAA(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1145D20", Offset = "0x1144B20", VA = "0x181145D20")]
		public static UnityEngine.Color CZAMDWNYPAA(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x73648C0", Offset = "0x73636C0", VA = "0x1873648C0")]
		public static GLTF.Math.Color GTBOIETMRXM(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7365380", Offset = "0x7364180", VA = "0x187365380")]
		public static GLTF.Math.Color PNYTIJIGUJP(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x73648F0", Offset = "0x73636F0", VA = "0x1873648F0")]
		public static GLTF.Math.Color IFPOUGQJFUN(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7366970", Offset = "0x7365770", VA = "0x187366970")]
		public static UnityEngine.Color[] ZMUNKOHBMWQ(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7364840", Offset = "0x7363640", VA = "0x187364840")]
		public static int[] GOUBXXZSMWX(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7363D00", Offset = "0x7362B00", VA = "0x187363D00")]
		public static UnityEngine.Vector2[] AGOUASEPKXW(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x73651B0", Offset = "0x7363FB0", VA = "0x1873651B0")]
		public static void NAVVTWUOYEP(PSVQJIFYJWX a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x73646E0", Offset = "0x73634E0", VA = "0x1873646E0")]
		public static UnityEngine.Vector3[] GNNVIXECEAN(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7364540", Offset = "0x7363340", VA = "0x187364540")]
		public static UnityEngine.Vector4[] FTYXXXILJYQ(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7365310", Offset = "0x7364110", VA = "0x187365310")]
		public static void PADJOYYEQTR(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7364510", Offset = "0x7363310", VA = "0x187364510")]
		public static UnityEngine.Quaternion EXSKDSKBPQD(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class PSVQJIFYJWX
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public NVYFVNDMWDU NVYFVNDMWDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray LHBAAHEHJNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x736A210", Offset = "0x7369010", VA = "0x18736A210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> KKANJEEEIAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xCC0160", Offset = "0xCBEF60", VA = "0x180CC0160")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD773B0", Offset = "0xD761B0", VA = "0x180D773B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint LLSOELETZNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xACE310", Offset = "0xACD110", VA = "0x180ACE310")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xACE320", Offset = "0xACD120", VA = "0x180ACE320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x736A220", Offset = "0x7369020", VA = "0x18736A220")]
		public PSVQJIFYJWX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x735D0C0", Offset = "0x735BEC0", VA = "0x18735D0C0")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x735D120", Offset = "0x735BF20", VA = "0x18735D120")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class CQHCDQJNXCW
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class YBXPZUZYEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> NGBNVJDUCTF;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public YBXPZUZYEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x736E010", Offset = "0x736CE10", VA = "0x18736E010")]
			internal int? FGMTNUZLQJC(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x736E090", Offset = "0x736CE90", VA = "0x18736E090")]
			internal int? GGVNWCWXUUP(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x736E120", Offset = "0x736CF20", VA = "0x18736E120")]
			internal bool IMIOITFTKHB(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x73563B0", Offset = "0x73551B0", VA = "0x1873563B0")]
		private static void YBTHLHPZKDV(NumericArray a, PSVQJIFYJWX b, PSVQJIFYJWX c, PSVQJIFYJWX d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7354470", Offset = "0x7353270", VA = "0x187354470")]
		public static void GOPJHOMCHCM(Dictionary<string, PSVQJIFYJWX> a, Dictionary<string, (PSVQJIFYJWX sparseIndices, PSVQJIFYJWX sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7355750", Offset = "0x7354550", VA = "0x187355750")]
		public static void JJJCGXGYXNK(Dictionary<string, PSVQJIFYJWX> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7356920", Offset = "0x7355720", VA = "0x187356920")]
		public static void YNCXFWKEYJB(PSVQJIFYJWX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7355E20", Offset = "0x7354C20", VA = "0x187355E20")]
		public static void PXGSAAWXDNN(Dictionary<string, List<PSVQJIFYJWX>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7355C30", Offset = "0x7354A30", VA = "0x187355C30")]
		private static void MOYOIHFGAMH(PSVQJIFYJWX a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7355D60", Offset = "0x7354B60", VA = "0x187355D60")]
		internal static void MOYOIHFGAMH(ZZKTXONUPCL a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7353FD0", Offset = "0x7352DD0", VA = "0x187353FD0")]
		public static OFMVRVAYDAN EJJLNFFFUCD(IEnumerable<OFMVRVAYDAN> a)
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
			[Cpp2IlInjected.Address(RVA = "0xD2C740", Offset = "0xD2B540", VA = "0x180D2C740")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x138ED40", Offset = "0x138DB40", VA = "0x18138ED40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2E7C400", Offset = "0x2E7B200", VA = "0x182E7C400")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2E7C410", Offset = "0x2E7B210", VA = "0x182E7C410")]
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
	public class QBJTFUGNGLY
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint WRAPJZROBFR;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint CZJEMSVIKXD;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint KUNFRYPLWZD;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x736A250", Offset = "0x7369050", VA = "0x18736A250")]
		public static void ELVRNYGIOPX(Stream a, [Out] JDAQQVNNAHD b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x736A580", Offset = "0x7369380", VA = "0x18736A580")]
		public static ChunkInfo UESTMBRUMWJ(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x736AB70", Offset = "0x7369970", VA = "0x18736AB70")]
		public static GLBHeader ZFBMVTLTIDV(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x736A810", Offset = "0x7369610", VA = "0x18736A810")]
		public static bool UFLDCULGMHF(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x736A410", Offset = "0x7369210", VA = "0x18736A410")]
		public static ChunkInfo FRUJCDRZSUI(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x736A8D0", Offset = "0x73696D0", VA = "0x18736A8D0")]
		private static void VGCMFSUFVZM(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x736ACB0", Offset = "0x7369AB0", VA = "0x18736ACB0")]
		private static uint ZLZGMXGKKHP(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MXAEAFOHWWG
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
		public PathElement AWTWXWZQJUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAC6110", Offset = "0xAC4F10", VA = "0x180AC6110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAD3D80", Offset = "0xAD2B80", VA = "0x180AD3D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int WCXSKSYEYFC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xBD3950", Offset = "0xBD2750", VA = "0x180BD3950")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xBD3960", Offset = "0xBD2760", VA = "0x180BD3960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string XAHPDLHRGTV
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xACC810", Offset = "0xACB610", VA = "0x180ACC810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MRWILFYBSEK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xACC870", Offset = "0xACB670", VA = "0x180ACC870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xACC860", Offset = "0xACB660", VA = "0x180ACC860")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MXAEAFOHWWG LBSXUUQNZFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C40", Offset = "0xAC7A40", VA = "0x180AC8C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x73671F0", Offset = "0x7365FF0", VA = "0x1873671F0")]
		public string AXITYYLSUTE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7367450", Offset = "0x7366250", VA = "0x187367450")]
		public MXAEAFOHWWG RXFOEGOHEQS(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7367660", Offset = "0x7366460", VA = "0x187367660")]
		private MXAEAFOHWWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x73674B0", Offset = "0x73662B0", VA = "0x1873674B0")]
		public MXAEAFOHWWG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4175980", Offset = "0x4174780", VA = "0x184175980")]
		[CompilerGenerated]
		internal static string HDKDCLZEJRI(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7367470", Offset = "0x7366270", VA = "0x187367470")]
		[CompilerGenerated]
		internal static bool XDWKMRCJQZP([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7367270", Offset = "0x7366070", VA = "0x187367270")]
		[CompilerGenerated]
		internal static MXAEAFOHWWG GZHKTOMFTCL(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class RCAUPGQFSPB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x736B1E0", Offset = "0x7369FE0", VA = "0x18736B1E0")]
		public static int[] EYSWWZMCIDB(this JDAQQVNNAHD a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x736B480", Offset = "0x736A280", VA = "0x18736B480")]
		public static int[] LJDUMAFRIPT(this JDAQQVNNAHD a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class MXFGPTABZZV
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x73686A0", Offset = "0x73674A0", VA = "0x1873686A0")]
		public static uint PPBXVOSRFPG(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream UMOVCHLVQYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long DUWUUGKXEKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long OAFZSTVVYDU;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x736BB50", Offset = "0x736A950", VA = "0x18736BB50", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x736BB90", Offset = "0x736A990", VA = "0x18736BB90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x736BB90", Offset = "0x736A990", VA = "0x18736BB90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x736BBB0", Offset = "0x736A9B0", VA = "0x18736BBB0", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x736BBD0", Offset = "0x736A9D0", VA = "0x18736BBD0", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x736BBF0", Offset = "0x736A9F0", VA = "0x18736BBF0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x736B8E0", Offset = "0x736A6E0", VA = "0x18736B8E0")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x736B6A0", Offset = "0x736A4A0", VA = "0x18736B6A0", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x736B770", Offset = "0x736A570", VA = "0x18736B770", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x736B7D0", Offset = "0x736A5D0", VA = "0x18736B7D0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x736B6E0", Offset = "0x736A4E0", VA = "0x18736B6E0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x736B8A0", Offset = "0x736A6A0", VA = "0x18736B8A0", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x736B810", Offset = "0x736A610", VA = "0x18736B810")]
		private void TSTDTZIADZJ()
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
		public static Color SKVVRTGYAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7356C30", Offset = "0x7355A30", VA = "0x187356C30")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color ELAJVNOGJQB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7356A20", Offset = "0x7355820", VA = "0x187356A20")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color SIZLKUXJDWF
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7356C50", Offset = "0x7355A50", VA = "0x187356C50")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B8EAA0", Offset = "0x2B8D8A0", VA = "0x182B8EAA0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1631470", Offset = "0x1630270", VA = "0x181631470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB1D0", Offset = "0x2BE9FD0", VA = "0x182BEB1D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB1E0", Offset = "0x2BE9FE0", VA = "0x182BEB1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2967190", Offset = "0x2965F90", VA = "0x182967190")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x30745F0", Offset = "0x30733F0", VA = "0x1830745F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x12ED510", Offset = "0x12EC310", VA = "0x1812ED510")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x12ED520", Offset = "0x12EC320", VA = "0x1812ED520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x29292F0", Offset = "0x29280F0", VA = "0x1829292F0")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7356A30", Offset = "0x7355830", VA = "0x187356A30", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7356AE0", Offset = "0x73558E0", VA = "0x187356AE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7356B80", Offset = "0x7355980", VA = "0x187356B80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7356C70", Offset = "0x7355A70", VA = "0x187356C70")]
		public static bool OLTCZZLLQGX(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class FPNBMRBYURJ : IEquatable<FPNBMRBYURJ>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly FPNBMRBYURJ JEPXDHPMOFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] HUVVSZDMGMK;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float LFFBXMTRLJT
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7357B40", Offset = "0x7356940", VA = "0x187357B40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7357690", Offset = "0x7356490", VA = "0x187357690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float EEDJEGXUCUS
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7357C90", Offset = "0x7356A90", VA = "0x187357C90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7357C00", Offset = "0x7356A00", VA = "0x187357C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float YDUQNKCMRVJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7357DE0", Offset = "0x7356BE0", VA = "0x187357DE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7357CF0", Offset = "0x7356AF0", VA = "0x187357CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float RCSXUEGPJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7357F30", Offset = "0x7356D30", VA = "0x187357F30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7357EA0", Offset = "0x7356CA0", VA = "0x187357EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float LEPHFSLZJBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7357B10", Offset = "0x7356910", VA = "0x187357B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7357660", Offset = "0x7356460", VA = "0x187357660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float EDYCHADWTJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7357C30", Offset = "0x7356A30", VA = "0x187357C30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7357BA0", Offset = "0x73569A0", VA = "0x187357BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float YDZXKQWKBGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7357E40", Offset = "0x7356C40", VA = "0x187357E40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7357D50", Offset = "0x7356B50", VA = "0x187357D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float RDISLYOHLOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7357F60", Offset = "0x7356D60", VA = "0x187357F60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7357ED0", Offset = "0x7356CD0", VA = "0x187357ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float LEUOCZFWSNB
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7357AE0", Offset = "0x73568E0", VA = "0x187357AE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7357630", Offset = "0x7356430", VA = "0x187357630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float EDSVJTJZJYA
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7357C60", Offset = "0x7356A60", VA = "0x187357C60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7357BD0", Offset = "0x73569D0", VA = "0x187357BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float YEFEHXQHKSB
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7357E10", Offset = "0x7356C10", VA = "0x187357E10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7357D20", Offset = "0x7356B20", VA = "0x187357D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float RDDLORUKCDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7357F90", Offset = "0x7356D90", VA = "0x187357F90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7357F00", Offset = "0x7356D00", VA = "0x187357F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float LFUWPHBJNRU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7357AB0", Offset = "0x73568B0", VA = "0x187357AB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x73576C0", Offset = "0x73564C0", VA = "0x1873576C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float EDNOMMQCAMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7357CC0", Offset = "0x7356AC0", VA = "0x187357CC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7357B70", Offset = "0x7356970", VA = "0x187357B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float YCUIBCGZWQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7357DB0", Offset = "0x7356BB0", VA = "0x187357DB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7357D80", Offset = "0x7356B80", VA = "0x187357D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float RDTGGMCCELB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7357FC0", Offset = "0x7356DC0", VA = "0x187357FC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7357E70", Offset = "0x7356C70", VA = "0x187357E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x73580D0", Offset = "0x7356ED0", VA = "0x1873580D0")]
		public FPNBMRBYURJ(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x73577F0", Offset = "0x73565F0", VA = "0x1873577F0", Slot = "4")]
		public bool Equals(FPNBMRBYURJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x73576F0", Offset = "0x73564F0", VA = "0x1873576F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xEA1050", Offset = "0xE9FE50", VA = "0x180EA1050", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8EAA0", Offset = "0x2B8D8A0", VA = "0x182B8EAA0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x1631470", Offset = "0x1630270", VA = "0x181631470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB1D0", Offset = "0x2BE9FD0", VA = "0x182BEB1D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB1E0", Offset = "0x2BE9FE0", VA = "0x182BEB1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2967190", Offset = "0x2965F90", VA = "0x182967190")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x30745F0", Offset = "0x30733F0", VA = "0x1830745F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x12ED510", Offset = "0x12EC310", VA = "0x1812ED510")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x12ED520", Offset = "0x12EC320", VA = "0x1812ED520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x736B150", Offset = "0x7369F50", VA = "0x18736B150")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x736ADB0", Offset = "0x7369BB0", VA = "0x18736ADB0", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x736AED0", Offset = "0x7369CD0", VA = "0x18736AED0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x736AF80", Offset = "0x7369D80", VA = "0x18736AF80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x736B060", Offset = "0x7369E60", VA = "0x18736B060")]
		public static bool OLTCZZLLQGX(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B8EAA0", Offset = "0x2B8D8A0", VA = "0x182B8EAA0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1631470", Offset = "0x1630270", VA = "0x181631470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB1D0", Offset = "0x2BE9FD0", VA = "0x182BEB1D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB1E0", Offset = "0x2BE9FE0", VA = "0x182BEB1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xE0FD20", Offset = "0xE0EB20", VA = "0x180E0FD20")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x736C4D0", Offset = "0x736B2D0", VA = "0x18736C4D0")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x736C2E0", Offset = "0x736B0E0", VA = "0x18736C2E0", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x736C340", Offset = "0x736B140", VA = "0x18736C340", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x736C420", Offset = "0x736B220", VA = "0x18736C420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x736C470", Offset = "0x736B270", VA = "0x18736C470")]
		public static bool OLTCZZLLQGX(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B8EAA0", Offset = "0x2B8D8A0", VA = "0x182B8EAA0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1631470", Offset = "0x1630270", VA = "0x181631470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB1D0", Offset = "0x2BE9FD0", VA = "0x182BEB1D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB1E0", Offset = "0x2BE9FE0", VA = "0x182BEB1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2967190", Offset = "0x2965F90", VA = "0x182967190")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x30745F0", Offset = "0x30733F0", VA = "0x1830745F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x736C890", Offset = "0x736B690", VA = "0x18736C890")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x736C4F0", Offset = "0x736B2F0", VA = "0x18736C4F0", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x736C5D0", Offset = "0x736B3D0", VA = "0x18736C5D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x736C690", Offset = "0x736B490", VA = "0x18736C690", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x736C740", Offset = "0x736B540", VA = "0x18736C740")]
		public static bool OLTCZZLLQGX(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B8EAA0", Offset = "0x2B8D8A0", VA = "0x182B8EAA0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1631470", Offset = "0x1630270", VA = "0x181631470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB1D0", Offset = "0x2BE9FD0", VA = "0x182BEB1D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB1E0", Offset = "0x2BE9FE0", VA = "0x182BEB1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2967190", Offset = "0x2965F90", VA = "0x182967190")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x30745F0", Offset = "0x30733F0", VA = "0x1830745F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x12ED510", Offset = "0x12EC310", VA = "0x1812ED510")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x12ED520", Offset = "0x12EC320", VA = "0x1812ED520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x29292F0", Offset = "0x29280F0", VA = "0x1829292F0")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7356A30", Offset = "0x7355830", VA = "0x187356A30", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x736C910", Offset = "0x736B710", VA = "0x18736C910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7356B80", Offset = "0x7355980", VA = "0x187356B80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class ZMMCQAZPJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x736E360", Offset = "0x736D160", VA = "0x18736E360")]
		public static void NFZIPFLTWCC(this JObject a, string b, FDRUDEHOSVN c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class MXFGPTABZZV
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7368DA0", Offset = "0x7367BA0", VA = "0x187368DA0")]
		public static List<string> TGIEJDFFLVT(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7367880", Offset = "0x7366680", VA = "0x187367880")]
		public static List<double> BZOSNILXUMN(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x73676C0", Offset = "0x73664C0", VA = "0x1873676C0")]
		public static List<int> BHRJPHDVNUE(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x38851A0", Offset = "0x3883FA0", VA = "0x1838851A0")]
		public static List<a> RJKWMAKLEKY<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7367E40", Offset = "0x7366C40", VA = "0x187367E40")]
		public static FDRUDEHOSVN KMIAKBIANQG(this JToken a, JDAQQVNNAHD b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x73680F0", Offset = "0x7366EF0", VA = "0x1873680F0")]
		public static int LKSNADETIPG(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7367A40", Offset = "0x7366840", VA = "0x187367A40")]
		public static double GAFBMASCTUS(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x73691C0", Offset = "0x7367FC0", VA = "0x1873691C0")]
		public static GLTF.Math.Color WOTTJXFRMTH(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7368F50", Offset = "0x7367D50", VA = "0x187368F50")]
		public static GLTF.Math.Color WEMXTYTXKXE(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x73687F0", Offset = "0x73675F0", VA = "0x1873687F0")]
		public static GLTF.Math.Color SJYBQTZUADA(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7367B80", Offset = "0x7366980", VA = "0x187367B80")]
		public static GLTF.Math.Vector3 HZHDNZFCZHO(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7368230", Offset = "0x7367030", VA = "0x187368230")]
		public static GLTF.Math.Vector2 OGZLEXQKXPM(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7368440", Offset = "0x7367240", VA = "0x187368440")]
		public static GLTF.Math.Vector3 OHESCEKIHAV(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7368A90", Offset = "0x7367890", VA = "0x187368A90")]
		public static GLTF.Math.Quaternion SUVQUCHVEBC(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3885610", Offset = "0x3884410", VA = "0x183885610")]
		public static Dictionary<string, b> SXDPITIJKBG<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3885B30", Offset = "0x3884930", VA = "0x183885B30")]
		public static c UTTETOJBQYQ<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public ZZKTXONUPCL bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7357350", Offset = "0x7356150", VA = "0x187357350", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x73572D0", Offset = "0x73560D0", VA = "0x1873572D0", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class MKFAZNJPGNA : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x73671A0", Offset = "0x7365FA0", VA = "0x1873671A0")]
		public MKFAZNJPGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x73670D0", Offset = "0x7365ED0", VA = "0x1873670D0", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, NVYFVNDMWDU> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7357190", Offset = "0x7355F90", VA = "0x187357190", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7357250", Offset = "0x7356050", VA = "0x187357250")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TFYXHUWHBFK : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class IOBBVAODQCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public JDAQQVNNAHD WYBQGJRULHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader HTSLCUOSHXJ;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IOBBVAODQCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x735D4C0", Offset = "0x735C2C0", VA = "0x18735D4C0")]
			internal NVYFVNDMWDU DNCCNQWBQLR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x736BDC0", Offset = "0x736ABC0", VA = "0x18736BDC0")]
		public TFYXHUWHBFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x736BC30", Offset = "0x736AA30", VA = "0x18736BC30", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public GKLGRGLVTZC VOWFJXHTEGJ;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public EXT_texture_exr(GKLGRGLVTZC source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x73573A0", Offset = "0x73561A0", VA = "0x1873573A0", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7357410", Offset = "0x7356210", VA = "0x187357410", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class YRFJDKOIPFD : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x736E310", Offset = "0x736D110", VA = "0x18736E310")]
		public YRFJDKOIPFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x736E1F0", Offset = "0x736CFF0", VA = "0x18736E1F0", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
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
	public class AudioEmitterId : RQICLVFIUHZ<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x7353B40", Offset = "0x7352940", VA = "0x187353B40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7353B00", Offset = "0x7352900", VA = "0x187353B00")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : RQICLVFIUHZ<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7353CD0", Offset = "0x7352AD0", VA = "0x187353CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7353C90", Offset = "0x7352A90", VA = "0x187353C90")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : RQICLVFIUHZ<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x73539B0", Offset = "0x73527B0", VA = "0x1873539B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7353970", Offset = "0x7352770", VA = "0x187353970")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7353890", Offset = "0x7352690", VA = "0x187353890")]
		public static AudioDataId Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x735F800", Offset = "0x735E600", VA = "0x18735F800", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x735F400", Offset = "0x735E200", VA = "0x18735F400", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x735F470", Offset = "0x735E270", VA = "0x18735F470")]
		public static KHR_SceneAudioEmittersRef Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x735FA60", Offset = "0x735E860", VA = "0x18735FA60")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x735F3D0", Offset = "0x735E1D0", VA = "0x18735F3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x735F2B0", Offset = "0x735E0B0", VA = "0x18735F2B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x735F0A0", Offset = "0x735DEA0", VA = "0x18735F0A0", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x735F110", Offset = "0x735DF10", VA = "0x18735F110")]
		public static KHR_NodeAudioEmitterRef Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class WYLWIAXEOXO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string XDBTYRCOINT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? LMUMUOKZVKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? XHUEOKRCOVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? QQPPCNKKGCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? ZXUJMPSBMNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? DOCQTHIRLAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? HTLKCBVTWWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? YSACXVKYFTR;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x736DAF0", Offset = "0x736C8F0", VA = "0x18736DAF0")]
		public JObject ZLPVCWRAQLQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x736D3F0", Offset = "0x736C1F0", VA = "0x18736D3F0")]
		public static WYLWIAXEOXO Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public WYLWIAXEOXO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : ZPLCQCTWSVD
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
		public WYLWIAXEOXO positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x735E6F0", Offset = "0x735D4F0", VA = "0x18735E6F0", Slot = "5")]
		public virtual JObject ZLPVCWRAQLQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x735E1F0", Offset = "0x735CFF0", VA = "0x18735E1F0")]
		public static KHR_AudioEmitter Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x735EA90", Offset = "0x735D890", VA = "0x18735EA90")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : ZPLCQCTWSVD
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
		[Cpp2IlInjected.Address(RVA = "0x735EE70", Offset = "0x735DC70", VA = "0x18735EE70")]
		public JObject ZLPVCWRAQLQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x735EB10", Offset = "0x735D910", VA = "0x18735EB10")]
		public static KHR_AudioSource Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x735D0B0", Offset = "0x735BEB0", VA = "0x18735D0B0")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NJUYYEWCMTY bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x735E0C0", Offset = "0x735CEC0", VA = "0x18735E0C0")]
		public JObject ZLPVCWRAQLQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x735DE60", Offset = "0x735CC60", VA = "0x18735DE60")]
		public static KHR_AudioData Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x735D0B0", Offset = "0x735BEB0", VA = "0x18735D0B0")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : OOIVUJOYGNK
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
		[Cpp2IlInjected.Address(RVA = "0x735FD20", Offset = "0x735EB20", VA = "0x18735FD20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x735FC90", Offset = "0x735EA90", VA = "0x18735FC90", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7360450", Offset = "0x735F250", VA = "0x187360450")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class AMETPVQXTPF : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7353840", Offset = "0x7352640", VA = "0x187353840")]
		public AMETPVQXTPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7352C90", Offset = "0x7351A90", VA = "0x187352C90", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NJUYYEWCMTY bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7360620", Offset = "0x735F420", VA = "0x187360620", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7360560", Offset = "0x735F360", VA = "0x187360560", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7360670", Offset = "0x735F470", VA = "0x187360670")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JDMQEGWRDYR : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class IOBBVAODQCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader HTSLCUOSHXJ;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IOBBVAODQCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x735D450", Offset = "0x735C250", VA = "0x18735D450")]
			internal int DNCCNQWBQLR()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x735DCF0", Offset = "0x735CAF0", VA = "0x18735DCF0")]
		public JDMQEGWRDYR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x735DAE0", Offset = "0x735C8E0", VA = "0x18735DAE0", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FDRUDEHOSVN anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7360770", Offset = "0x735F570", VA = "0x187360770", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x73606F0", Offset = "0x735F4F0", VA = "0x1873606F0", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class OBQAWNOGXCS : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7369650", Offset = "0x7368450", VA = "0x187369650")]
		public OBQAWNOGXCS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x73694A0", Offset = "0x73682A0", VA = "0x1873694A0", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public FDRUDEHOSVN clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public FDRUDEHOSVN clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public FDRUDEHOSVN clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7360A20", Offset = "0x735F820", VA = "0x187360A20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7360980", Offset = "0x735F780", VA = "0x187360980", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class HRFMSFYNJSW : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x735D400", Offset = "0x735C200", VA = "0x18735D400")]
		public HRFMSFYNJSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x735D180", Offset = "0x735BF80", VA = "0x18735D180", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7360D80", Offset = "0x735FB80", VA = "0x187360D80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7360D10", Offset = "0x735FB10", VA = "0x187360D10", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class IPYEJRWTMEE : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x735D7D0", Offset = "0x735C5D0", VA = "0x18735D7D0")]
		public IPYEJRWTMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x735D700", Offset = "0x735C500", VA = "0x18735D700", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : FDLRVHASUWI, OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float EYYHKCOEZAO;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x73610D0", Offset = "0x735FED0", VA = "0x1873610D0")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7361060", Offset = "0x735FE60", VA = "0x187361060")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, JDAQQVNNAHD root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7360EA0", Offset = "0x735FCA0", VA = "0x187360EA0", Slot = "6")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7360F40", Offset = "0x735FD40", VA = "0x187360F40", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class WCVIYNNOHNL : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x736CAB0", Offset = "0x736B8B0", VA = "0x18736CAB0")]
		public WCVIYNNOHNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x736C9B0", Offset = "0x736B7B0", VA = "0x18736C9B0", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7361180", Offset = "0x735FF80", VA = "0x187361180", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7361120", Offset = "0x735FF20", VA = "0x187361120", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x73612D0", Offset = "0x73600D0", VA = "0x1873612D0")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class JGDKHOVVTZQ : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x735DE10", Offset = "0x735CC10", VA = "0x18735DE10")]
		public JGDKHOVVTZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x735DD40", Offset = "0x735CB40", VA = "0x18735DD40", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public FDRUDEHOSVN iridescenceTexture;

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
		public FDRUDEHOSVN iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7361380", Offset = "0x7360180", VA = "0x187361380", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x73612E0", Offset = "0x73600E0", VA = "0x1873612E0", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7361740", Offset = "0x7360540", VA = "0x187361740")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class DWYIRPYBCIQ : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7357010", Offset = "0x7355E10", VA = "0x187357010")]
		public DWYIRPYBCIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7356D20", Offset = "0x7355B20", VA = "0x187356D20", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class OQBAXWFBDXF : OOIVUJOYGNK
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 COXZHILKKSB;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double ASEPTGTIGFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color XYVLIDXJCCN;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color DGNMHVSGUZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public FDRUDEHOSVN OOFRVKSEWYR;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly FDRUDEHOSVN YJDTIQANOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 WMWROQMWLXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double NOIQZAOVZIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public FDRUDEHOSVN PJTHELULHSO;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly FDRUDEHOSVN HUJEFILCJYK;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x736A110", Offset = "0x7368F10", VA = "0x18736A110")]
		public OQBAXWFBDXF(GLTF.Math.Color a, FDRUDEHOSVN b, GLTF.Math.Vector3 c, double d, FDRUDEHOSVN e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x73697F0", Offset = "0x73685F0", VA = "0x1873697F0", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x73699B0", Offset = "0x73687B0", VA = "0x1873699B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class FXCBXCANIAD : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x73586E0", Offset = "0x73574E0", VA = "0x1873586E0")]
		public FXCBXCANIAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7358380", Offset = "0x7357180", VA = "0x187358380", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public FDRUDEHOSVN sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public FDRUDEHOSVN sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7361830", Offset = "0x7360630", VA = "0x187361830", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7361760", Offset = "0x7360560", VA = "0x187361760", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7361D40", Offset = "0x7360B40", VA = "0x187361D40")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class YBRXGFNTFJD : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x736DFC0", Offset = "0x736CDC0", VA = "0x18736DFC0")]
		public YBRXGFNTFJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x736DD60", Offset = "0x736CB60", VA = "0x18736DD60", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public FDRUDEHOSVN specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public FDRUDEHOSVN specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7361E80", Offset = "0x7360C80", VA = "0x187361E80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7361DB0", Offset = "0x7360BB0", VA = "0x187361DB0", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7362390", Offset = "0x7361190", VA = "0x187362390")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class UFNBHCWBXAD : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x736C290", Offset = "0x736B090", VA = "0x18736C290")]
		public UFNBHCWBXAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x736C070", Offset = "0x736AE70", VA = "0x18736C070", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FDRUDEHOSVN transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7362480", Offset = "0x7361280", VA = "0x187362480", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7362400", Offset = "0x7361200", VA = "0x187362400", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class IOPFLAGOKPE : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x735D6B0", Offset = "0x735C4B0", VA = "0x18735D6B0")]
		public IOPFLAGOKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x735D570", Offset = "0x735C370", VA = "0x18735D570", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class ITKQUZOBAET : FDLRVHASUWI, OOIVUJOYGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x735DA90", Offset = "0x735C890", VA = "0x18735DA90")]
		public ITKQUZOBAET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x735DA20", Offset = "0x735C820", VA = "0x18735DA20")]
		public ITKQUZOBAET(ITKQUZOBAET a, JDAQQVNNAHD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x735D820", Offset = "0x735C620", VA = "0x18735D820", Slot = "6")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x735D990", Offset = "0x735C790", VA = "0x18735D990", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x735D8C0", Offset = "0x735C6C0", VA = "0x18735D8C0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class SSXAFBTXVLV : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x736B650", Offset = "0x736A450", VA = "0x18736B650")]
		public SSXAFBTXVLV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x736B5D0", Offset = "0x736A3D0", VA = "0x18736B5D0", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public FDRUDEHOSVN thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x73626A0", Offset = "0x73614A0", VA = "0x1873626A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7362610", Offset = "0x7361410", VA = "0x187362610", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7362BD0", Offset = "0x73619D0", VA = "0x187362BD0")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class LNKZMQUEAWY : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7366D60", Offset = "0x7365B60", VA = "0x187366D60")]
		public LNKZMQUEAWY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7366B50", Offset = "0x7365950", VA = "0x187366B50", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7362C50", Offset = "0x7361A50", VA = "0x187362C50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7362BF0", Offset = "0x73619F0", VA = "0x187362BF0", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xFF78A0", Offset = "0xFF66A0", VA = "0x180FF78A0")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class EMKDDPYGQQM : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7357140", Offset = "0x7355F40", VA = "0x187357140")]
		public EMKDDPYGQQM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7357060", Offset = "0x7355E60", VA = "0x187357060", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7362DC0", Offset = "0x7361BC0", VA = "0x187362DC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7362D60", Offset = "0x7361B60", VA = "0x187362D60", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xFF78A0", Offset = "0xFF66A0", VA = "0x180FF78A0")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class EZTRKPYHGEE : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x73575E0", Offset = "0x73563E0", VA = "0x1873575E0")]
		public EZTRKPYHGEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7357500", Offset = "0x7356300", VA = "0x187357500", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7362F30", Offset = "0x7361D30", VA = "0x187362F30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7362ED0", Offset = "0x7361CD0", VA = "0x187362ED0", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xFF78A0", Offset = "0xFF66A0", VA = "0x180FF78A0")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class WGQEJSGTABG : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x736CBE0", Offset = "0x736B9E0", VA = "0x18736CBE0")]
		public WGQEJSGTABG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x736CB00", Offset = "0x736B900", VA = "0x18736CB00", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public GKLGRGLVTZC source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public KHR_texture_basisu(GKLGRGLVTZC source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7363040", Offset = "0x7361E40", VA = "0x187363040", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x73630B0", Offset = "0x7361EB0", VA = "0x1873630B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class BOOAHHMJERS : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7353F80", Offset = "0x7352D80", VA = "0x187353F80")]
		public BOOAHHMJERS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7353E20", Offset = "0x7352C20", VA = "0x187353E20", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class WLGQLKIXLFN : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 LLSOELETZNN;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 RWEPWRUJCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double LPLELFIJVOG;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double RWAXNLKJAMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 ZMJUOEPVXPQ;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 CUYRFZTMBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? BIXLLCJTRVM;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int BVWFQUMJYOU;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x736D370", Offset = "0x736C170", VA = "0x18736D370")]
		public WLGQLKIXLFN(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x736CC30", Offset = "0x736BA30", VA = "0x18736CC30", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x736CD10", Offset = "0x736BB10", VA = "0x18736CD10", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class MAKFMEKUDQT : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7367080", Offset = "0x7365E80", VA = "0x187367080")]
		public MAKFMEKUDQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7366DB0", Offset = "0x7365BB0", VA = "0x187366DB0", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class UDVQLZGBEYP : OOIVUJOYGNK
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> EGIOMAXNLPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public UDVQLZGBEYP(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x736BE80", Offset = "0x736AC80", VA = "0x18736BE80", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x736BF80", Offset = "0x736AD80", VA = "0x18736BF80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x736BEF0", Offset = "0x736ACF0", VA = "0x18736BEF0")]
		public List<double> HRPSCJXFBJP(YMNWEWAXNPC a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class OEVUHWYZKVB : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x73697A0", Offset = "0x73685A0", VA = "0x1873697A0")]
		public OEVUHWYZKVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x73696A0", Offset = "0x73684A0", VA = "0x1873696A0", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class GCCXBATGNRZ : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public NJUYYEWCMTY ZZKTXONUPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint BQYBVSNAQMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType NSGKSZDEOQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool RHCZBOJJDWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint GREWHVQIKRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType ULTKTFGCAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> XQFJTRZGAXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> VRQTPNLALVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public BQVDBMVBPVV GABTOSSGSRW;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x735D0B0", Offset = "0x735BEB0", VA = "0x18735D0B0")]
		public GCCXBATGNRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7359080", Offset = "0x7357E80", VA = "0x187359080")]
		public static GCCXBATGNRZ Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x735CAD0", Offset = "0x735B8D0", VA = "0x18735CAD0", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x735B040", Offset = "0x7359E40", VA = "0x18735B040")]
		private unsafe static sbyte NSRFYFQYJGW(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7358B40", Offset = "0x7357940", VA = "0x187358B40")]
		private unsafe static float2 DBZHWFYEIEE(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x735AFC0", Offset = "0x7359DC0", VA = "0x18735AFC0")]
		private unsafe static float3 NEFLIUCATEF(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7359D90", Offset = "0x7358B90", VA = "0x187359D90")]
		private unsafe static float4 ILJRTZGHXAC(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x735B900", Offset = "0x735A700", VA = "0x18735B900")]
		private unsafe static float4x4 RRJGKOLPCNI(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x735B040", Offset = "0x7359E40", VA = "0x18735B040")]
		private unsafe static byte RUIGFGWUEDV(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x735C530", Offset = "0x735B330", VA = "0x18735C530")]
		private unsafe static float2 UQGIMMAVWFZ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7359DF0", Offset = "0x7358BF0", VA = "0x187359DF0")]
		private unsafe static float3 JMXGNUFTSJE(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x735CA70", Offset = "0x735B870", VA = "0x18735CA70")]
		private unsafe static float4 YWXPLNZWIWF(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x735C390", Offset = "0x735B190", VA = "0x18735C390")]
		private unsafe static float4x4 TYKGTRSTACJ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7358730", Offset = "0x7357530", VA = "0x187358730")]
		private unsafe static short QCWZNQISNIS(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x735AD00", Offset = "0x7359B00", VA = "0x18735AD00")]
		private unsafe static float2 MTAYTIGSXFO(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7359B10", Offset = "0x7358910", VA = "0x187359B10")]
		private unsafe static float3 GODFJFSDYIB(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7358AE0", Offset = "0x73578E0", VA = "0x187358AE0")]
		private unsafe static float4 CIQLCFJDWTY(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x735C8A0", Offset = "0x735B6A0", VA = "0x18735C8A0")]
		private unsafe static float4x4 WJIZZEAVEHM(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7358730", Offset = "0x7357530", VA = "0x187358730")]
		private unsafe static ushort ACHZULPYUCB(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x735B050", Offset = "0x7359E50", VA = "0x18735B050")]
		private unsafe static float2 OIMKYGYPRDL(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7358A90", Offset = "0x7357890", VA = "0x187358A90")]
		private unsafe static float3 BJGUKDAQZZK(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x735A920", Offset = "0x7359720", VA = "0x18735A920")]
		private unsafe static float4x4 LZEAJYCNJBV(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x735C6D0", Offset = "0x735B4D0", VA = "0x18735C6D0")]
		private unsafe static float4 VUUOYMWWUCT(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x735CA40", Offset = "0x735B840", VA = "0x18735CA40")]
		private unsafe static uint WTOCJOIKYVS(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7358730", Offset = "0x7357530", VA = "0x187358730")]
		private unsafe static ushort UAXHQXSZYMF(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7358740", Offset = "0x7357540", VA = "0x187358740")]
		private unsafe static float AHNBXYNPUGK(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x73589A0", Offset = "0x73577A0", VA = "0x1873589A0")]
		private unsafe static float2 AJUYXXHYFZW(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x735CA50", Offset = "0x735B850", VA = "0x18735CA50")]
		private unsafe static float3 XBLOQAIJZQF(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x735B8D0", Offset = "0x735A6D0", VA = "0x18735B8D0")]
		private unsafe static float4 QWUERCJBUPA(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x735B010", Offset = "0x7359E10", VA = "0x18735B010")]
		private unsafe static float4x4 NFMKBKZZKPM(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x735B8D0", Offset = "0x735A6D0", VA = "0x18735B8D0")]
		private unsafe static float4 TROUVGHSIWR(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x735BDB0", Offset = "0x735ABB0", VA = "0x18735BDB0")]
		private unsafe static float4 TROUVGHSIWR(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7359B60", Offset = "0x7358960", VA = "0x187359B60")]
		public static float3[] HNMREQIHMUY(GCCXBATGNRZ a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x735BAA0", Offset = "0x735A8A0", VA = "0x18735BAA0")]
		public static float3[] RXEXJTQWMLS(GCCXBATGNRZ a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x735C730", Offset = "0x735B530", VA = "0x18735C730")]
		public static uint[] WIUKAYZPXJX(GCCXBATGNRZ a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x735A220", Offset = "0x7359020", VA = "0x18735A220")]
		internal static void KOXZTVXYOTE(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7358750", Offset = "0x7357550", VA = "0x187358750")]
		public uint[] AJAZVRULTLD(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x73594E0", Offset = "0x73582E0", VA = "0x1873594E0")]
		public float[] EFGXIXSBVPR(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x735AD30", Offset = "0x7359B30", VA = "0x18735AD30")]
		public float2[] MVKVEZJBXPD(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7359750", Offset = "0x7358550", VA = "0x187359750")]
		public float2[] FFXEPLROEMT(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x735B3C0", Offset = "0x735A1C0", VA = "0x18735B3C0")]
		public float3[] PSTSQUDYLJC(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7358D30", Offset = "0x7357B30", VA = "0x187358D30")]
		public float3[] DDJFQWMWYUY(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x735A6B0", Offset = "0x73594B0", VA = "0x18735A6B0")]
		public float4[] LKCHYUNKOXF(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x735A340", Offset = "0x7359140", VA = "0x18735A340")]
		public float4[] KWQKHLZLKGX(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7359E40", Offset = "0x7358C40", VA = "0x187359E40")]
		public float4[] JSYLHDQDCRC(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x735ABF0", Offset = "0x73599F0", VA = "0x18735ABF0")]
		public float3[] MPLCTQKASIX(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7359A00", Offset = "0x7358800", VA = "0x187359A00")]
		public float3[] FQEVZJUJVYU(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x73589C0", Offset = "0x73577C0", VA = "0x1873589C0")]
		public float4[] BFMIZNSDQAS(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x735A1D0", Offset = "0x7358FD0", VA = "0x18735A1D0")]
		public uint[] KHPCBPRULEJ(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x735BDE0", Offset = "0x735ABE0", VA = "0x18735BDE0")]
		public float4x4[] TTHDYHMJUMI(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x735B200", Offset = "0x735A000", VA = "0x18735B200")]
		private unsafe static float4 ORWGIJTEHWO(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x735B080", Offset = "0x7359E80", VA = "0x18735B080")]
		private unsafe static float4 ORWGIJTEHWO(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x735B640", Offset = "0x735A440", VA = "0x18735B640")]
		private unsafe static float4x4 PVWWABETGVB(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7358B70", Offset = "0x7357970", VA = "0x187358B70")]
		private unsafe static float4 DCVYRCRRHIL(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x735C560", Offset = "0x735B360", VA = "0x18735C560")]
		private unsafe static float3 VBPFRPZSPQE(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x735AAC0", Offset = "0x73598C0", VA = "0x18735AAC0")]
		private unsafe static float2 LZLJUEDKHYR(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x735B7B0", Offset = "0x735A5B0", VA = "0x18735B7B0")]
		private unsafe static uint QFLPBPCRGIU(void* a, uint b, GLTFComponentType c)
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
	public static class ORTGJIMKRNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x737B3F0", Offset = "0x737A1F0", VA = "0x18737B3F0")]
		public static int UIAJKGBCVVY(this GLTFAccessorAttributeType a)
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
	public class BQVDBMVBPVV : FDLRVHASUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int GREWHVQIKRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public QERLVPUGJNC JUKGHIDUBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TJGZVBOLDHH HJCCZOCLBQC;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x736E890", Offset = "0x736D690", VA = "0x18736E890")]
		public BQVDBMVBPVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x736E490", Offset = "0x736D290", VA = "0x18736E490")]
		public static BQVDBMVBPVV Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x736E760", Offset = "0x736D560", VA = "0x18736E760", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class QERLVPUGJNC : FDLRVHASUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public NJUYYEWCMTY ZZKTXONUPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int BQYBVSNAQMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType NSGKSZDEOQH;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x737CA00", Offset = "0x737B800", VA = "0x18737CA00")]
		public QERLVPUGJNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x737C5E0", Offset = "0x737B3E0", VA = "0x18737C5E0")]
		public static QERLVPUGJNC Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x737C8C0", Offset = "0x737B6C0", VA = "0x18737C8C0", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class TJGZVBOLDHH : FDLRVHASUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public NJUYYEWCMTY ZZKTXONUPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int BQYBVSNAQMN;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7380380", Offset = "0x737F180", VA = "0x187380380")]
		public TJGZVBOLDHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7380000", Offset = "0x737EE00", VA = "0x187380000")]
		public static TJGZVBOLDHH Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7380280", Offset = "0x737F080", VA = "0x187380280", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class HPUJSZYHVFT : FDLRVHASUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public GBIMUMULTRB COZNLPTFVZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public LGRWJKLCJVO RYPJJNRECKV;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7374AE0", Offset = "0x73738E0", VA = "0x187374AE0")]
		public HPUJSZYHVFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x73747F0", Offset = "0x73735F0", VA = "0x1873747F0")]
		public static HPUJSZYHVFT Deserialize(JDAQQVNNAHD root, JsonReader reader, DVFBFVYZYIJ anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x73749E0", Offset = "0x73737E0", VA = "0x1873749E0", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class LGRWJKLCJVO : FDLRVHASUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public OFMVRVAYDAN YMNWEWAXNPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string XZROKQVDAAX;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7379FA0", Offset = "0x7378DA0", VA = "0x187379FA0")]
		public static LGRWJKLCJVO Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x737A320", Offset = "0x7379120", VA = "0x18737A320")]
		public LGRWJKLCJVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x737A200", Offset = "0x7379000", VA = "0x18737A200", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
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
	public class WOAPQRATMFN
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(WOAPQRATMFN data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] GNHQLCYPKLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type PSXBHNMCOLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] DEXFFSJVRCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion WAFXVAMLKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string BIAZHMULYKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string XQVPXLRELAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public PSVQJIFYJWX XYWMIYHWUFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string NHSTRCDIAWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string LVUSPHALYKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public PSVQJIFYJWX KRSRPHWGHVM;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x73812C0", Offset = "0x73800C0", VA = "0x1873812C0")]
		public WOAPQRATMFN()
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
	public class JVOMNCFQSFY : FDLRVHASUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public NVYFVNDMWDU YCMHPZEGTAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType NKEQIBHHAAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public NVYFVNDMWDU PTYGPUIEXGN;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7378F80", Offset = "0x7377D80", VA = "0x187378F80")]
		public JVOMNCFQSFY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7378BF0", Offset = "0x73779F0", VA = "0x187378BF0")]
		public static JVOMNCFQSFY Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7378E10", Offset = "0x7377C10", VA = "0x187378E10", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class PJZZABZARLW : FDLRVHASUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string HSIMXIVHZCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string PNJNLSMBUMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string GCSZPDIVSGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string HUXCUGIPWCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> KIMCWFLPVLC;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x737BFB0", Offset = "0x737ADB0", VA = "0x18737BFB0")]
		public PJZZABZARLW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x737B860", Offset = "0x737A660", VA = "0x18737B860")]
		public static PJZZABZARLW Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x737BB90", Offset = "0x737A990", VA = "0x18737BB90", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x737BB80", Offset = "0x737A980", VA = "0x18737BB80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x737B4C0", Offset = "0x737A2C0", VA = "0x18737B4C0")]
		public string BPBMUFYGUGA(bool a)
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
	public class ZZKTXONUPCL : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public KBWWMGZXTPV FMFOJBEMVKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint BQYBVSNAQMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint IABBFAVDMQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint UFOVLVVINJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget RYPJJNRECKV;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x736EFA0", Offset = "0x736DDA0", VA = "0x18736EFA0")]
		public ZZKTXONUPCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7383E50", Offset = "0x7382C50", VA = "0x187383E50")]
		public static ZZKTXONUPCL Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7384100", Offset = "0x7382F00", VA = "0x187384100", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class IOOGEXQKVOV : FDLRVHASUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double IBXJTSCPDGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double NMEFYNBRRRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double SBWIPUYSJBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double OLHYQTXPRFC;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x73753F0", Offset = "0x73741F0", VA = "0x1873753F0")]
		public IOOGEXQKVOV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7374F00", Offset = "0x7373D00", VA = "0x187374F00")]
		public static IOOGEXQKVOV Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7375280", Offset = "0x7374080", VA = "0x187375280", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ERFYFUTMYVZ : FDLRVHASUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double OOJXABGGAUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double DPBOHSIOKXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double SBWIPUYSJBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double OLHYQTXPRFC;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7371900", Offset = "0x7370700", VA = "0x187371900")]
		public ERFYFUTMYVZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7371400", Offset = "0x7370200", VA = "0x187371400")]
		public static ERFYFUTMYVZ Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7371770", Offset = "0x7370570", VA = "0x187371770", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class DVFBFVYZYIJ : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class IOBBVAODQCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public JDAQQVNNAHD WYBQGJRULHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader HTSLCUOSHXJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public DVFBFVYZYIJ JRPLGQUPFYK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<HPUJSZYHVFT> VRAKHDZHEPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<JVOMNCFQSFY> VQVDJXFJVDU;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IOBBVAODQCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x7374EE0", Offset = "0x7373CE0", VA = "0x187374EE0")]
			internal HPUJSZYHVFT DNCCNQWBQLR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x7374ED0", Offset = "0x7373CD0", VA = "0x187374ED0")]
			internal JVOMNCFQSFY DMWVQKCEHAI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<HPUJSZYHVFT> BRGDHPBVGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<JVOMNCFQSFY> UBKTHQGWOPT;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7370BA0", Offset = "0x736F9A0", VA = "0x187370BA0")]
		public static DVFBFVYZYIJ Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7371300", Offset = "0x7370100", VA = "0x187371300")]
		public DVFBFVYZYIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7370F60", Offset = "0x736FD60", VA = "0x187370F60", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class KPPNLJILLKX : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string YPHEICZAADU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint IABBFAVDMQO;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x736EFA0", Offset = "0x736DDA0", VA = "0x18736EFA0")]
		public KPPNLJILLKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x73793D0", Offset = "0x73781D0", VA = "0x1873793D0")]
		public static KPPNLJILLKX Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x73795A0", Offset = "0x73783A0", VA = "0x1873795A0", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class IKVSZEFXJAW : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public IOOGEXQKVOV WOBHDDPYARM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public ERFYFUTMYVZ FIAEXRNLXDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType ULTKTFGCAFO;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x736EFA0", Offset = "0x736DDA0", VA = "0x18736EFA0")]
		public IKVSZEFXJAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7374B30", Offset = "0x7373930", VA = "0x187374B30")]
		public static IKVSZEFXJAW Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7374D00", Offset = "0x7373B00", VA = "0x187374D00", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
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
	public class ZPLCQCTWSVD : FDLRVHASUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string CANLOGIQDOT;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x736EFA0", Offset = "0x736DDA0", VA = "0x18736EFA0")]
		public ZPLCQCTWSVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7383DD0", Offset = "0x7382BD0", VA = "0x187383DD0")]
		public ZPLCQCTWSVD(ZPLCQCTWSVD a, JDAQQVNNAHD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7383C50", Offset = "0x7382A50", VA = "0x187383C50")]
		public new void GAQLYTIBZVJ(JDAQQVNNAHD a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7383D40", Offset = "0x7382B40", VA = "0x187383D40", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class RQICLVFIUHZ<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int ZVXCDESMJGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public JDAQQVNNAHD JNMQCQBFHQM;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		protected RQICLVFIUHZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5DC1D10", Offset = "0x5DC0B10", VA = "0x185DC1D10")]
		public RQICLVFIUHZ(RQICLVFIUHZ<a> a, JDAQQVNNAHD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5DC1CE0", Offset = "0x5DC0AE0", VA = "0x185DC1CE0")]
		public void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class NVYFVNDMWDU : RQICLVFIUHZ<GCCXBATGNRZ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override GCCXBATGNRZ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x737ABB0", Offset = "0x73799B0", VA = "0x18737ABB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x737AB70", Offset = "0x7379970", VA = "0x18737AB70")]
		public NVYFVNDMWDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x737AB10", Offset = "0x7379910", VA = "0x18737AB10")]
		public NVYFVNDMWDU(NVYFVNDMWDU a, JDAQQVNNAHD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x737AA30", Offset = "0x7379830", VA = "0x18737AA30")]
		public static NVYFVNDMWDU Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class KBWWMGZXTPV : RQICLVFIUHZ<KPPNLJILLKX>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override KPPNLJILLKX Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x73790F0", Offset = "0x7377EF0", VA = "0x1873790F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x73790B0", Offset = "0x7377EB0", VA = "0x1873790B0")]
		public KBWWMGZXTPV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7378FD0", Offset = "0x7377DD0", VA = "0x187378FD0")]
		public static KBWWMGZXTPV Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class NJUYYEWCMTY : RQICLVFIUHZ<ZZKTXONUPCL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override ZZKTXONUPCL Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x737A9D0", Offset = "0x73797D0", VA = "0x18737A9D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x737A990", Offset = "0x7379790", VA = "0x18737A990")]
		public NJUYYEWCMTY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x737A8B0", Offset = "0x73796B0", VA = "0x18737A8B0")]
		public static NJUYYEWCMTY Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class EZSHZLHBYIC : RQICLVFIUHZ<IKVSZEFXJAW>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override IKVSZEFXJAW Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x7371A80", Offset = "0x7370880", VA = "0x187371A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7371A40", Offset = "0x7370840", VA = "0x187371A40")]
		public EZSHZLHBYIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7371960", Offset = "0x7370760", VA = "0x187371960")]
		public static EZSHZLHBYIC Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class GKLGRGLVTZC : RQICLVFIUHZ<PLMBHVMMJWO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override PLMBHVMMJWO Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x7374000", Offset = "0x7372E00", VA = "0x187374000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7373FC0", Offset = "0x7372DC0", VA = "0x187373FC0")]
		public GKLGRGLVTZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7373EE0", Offset = "0x7372CE0", VA = "0x187373EE0")]
		public static GKLGRGLVTZC Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class NDJFZLMCFXK : RQICLVFIUHZ<WLAKECNJBYY>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override WLAKECNJBYY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x737A6D0", Offset = "0x73794D0", VA = "0x18737A6D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x737A690", Offset = "0x7379490", VA = "0x18737A690")]
		public NDJFZLMCFXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x737A630", Offset = "0x7379430", VA = "0x18737A630")]
		public NDJFZLMCFXK(NDJFZLMCFXK a, JDAQQVNNAHD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x737A550", Offset = "0x7379350", VA = "0x18737A550")]
		public static NDJFZLMCFXK Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class DSHSRHRWLOQ : RQICLVFIUHZ<ZAOTAHCWIQQ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override ZAOTAHCWIQQ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x7370B40", Offset = "0x736F940", VA = "0x187370B40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7370B00", Offset = "0x736F900", VA = "0x187370B00")]
		public DSHSRHRWLOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7370A20", Offset = "0x736F820", VA = "0x187370A20")]
		public static DSHSRHRWLOQ Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class OFMVRVAYDAN : RQICLVFIUHZ<YMNWEWAXNPC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override YMNWEWAXNPC Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x737B2F0", Offset = "0x737A0F0", VA = "0x18737B2F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x737B2B0", Offset = "0x737A0B0", VA = "0x18737B2B0")]
		public OFMVRVAYDAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x737AF60", Offset = "0x7379D60", VA = "0x18737AF60")]
		public static OFMVRVAYDAN Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x737B040", Offset = "0x7379E40", VA = "0x18737B040")]
		public static List<OFMVRVAYDAN> RJKWMAKLEKY(JDAQQVNNAHD a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class TAKMMMSKBUZ : RQICLVFIUHZ<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x737FBF0", Offset = "0x737E9F0", VA = "0x18737FBF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x737FBB0", Offset = "0x737E9B0", VA = "0x18737FBB0")]
		public TAKMMMSKBUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x737FAD0", Offset = "0x737E8D0", VA = "0x18737FAD0")]
		public static TAKMMMSKBUZ Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class GBIMUMULTRB : RQICLVFIUHZ<JVOMNCFQSFY>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public DVFBFVYZYIJ DVFBFVYZYIJ;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override JVOMNCFQSFY Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x7373E80", Offset = "0x7372C80", VA = "0x187373E80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7373E40", Offset = "0x7372C40", VA = "0x187373E40")]
		public GBIMUMULTRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7373D40", Offset = "0x7372B40", VA = "0x187373D40")]
		public static GBIMUMULTRB Deserialize(JDAQQVNNAHD root, DVFBFVYZYIJ anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class NIMXRZHNKSZ : RQICLVFIUHZ<CKBETQYDMVN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override CKBETQYDMVN Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x737A850", Offset = "0x7379650", VA = "0x18737A850", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x737A810", Offset = "0x7379610", VA = "0x18737A810")]
		public NIMXRZHNKSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x737A730", Offset = "0x7379530", VA = "0x18737A730")]
		public static NIMXRZHNKSZ Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class QCXQSQRAZEY : RQICLVFIUHZ<RNHNQGJJOGV>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override RNHNQGJJOGV Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x737C580", Offset = "0x737B380", VA = "0x18737C580", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x737C540", Offset = "0x737B340", VA = "0x18737C540")]
		public QCXQSQRAZEY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x737C460", Offset = "0x737B260", VA = "0x18737C460")]
		public static QCXQSQRAZEY Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class LIIDGRHDUAW : RQICLVFIUHZ<IQVYZFPSFVC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override IQVYZFPSFVC Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x737A4F0", Offset = "0x73792F0", VA = "0x18737A4F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x737A4B0", Offset = "0x73792B0", VA = "0x18737A4B0")]
		public LIIDGRHDUAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x737A450", Offset = "0x7379250", VA = "0x18737A450")]
		public LIIDGRHDUAW(LIIDGRHDUAW a, JDAQQVNNAHD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x737A370", Offset = "0x7379170", VA = "0x18737A370")]
		public static LIIDGRHDUAW Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class OMXNLWGKLKR : RQICLVFIUHZ<KMVHITRYAHN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override KMVHITRYAHN Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x737B390", Offset = "0x737A190", VA = "0x18737B390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x737B350", Offset = "0x737A150", VA = "0x18737B350")]
		public OMXNLWGKLKR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class PLMBHVMMJWO : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string YPHEICZAADU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string GVPMZHZCWHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public NJUYYEWCMTY ZZKTXONUPCL;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x736EFA0", Offset = "0x736DDA0", VA = "0x18736EFA0")]
		public PLMBHVMMJWO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x737C050", Offset = "0x737AE50", VA = "0x18737C050")]
		public static PLMBHVMMJWO Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x737C290", Offset = "0x737B090", VA = "0x18737C290", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class WLAKECNJBYY : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public KXJWJGWYQSN KXJWJGWYQSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public ITKYRIBHQWI JLEQZDLWXPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ISPJQBRPYCG UOVAEWHYYCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public TEGAWRVLOXG HTGEZBCMVHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public FDRUDEHOSVN YJUYZDZCLHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color IFTFFYLPURW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode HEQBRCDTJSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double CDVFHZVTJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool TOMDNWCVWUW;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7381250", Offset = "0x7380050", VA = "0x187381250")]
		public WLAKECNJBYY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x73808E0", Offset = "0x737F6E0", VA = "0x1873808E0")]
		public static WLAKECNJBYY Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7380DF0", Offset = "0x737FBF0", VA = "0x187380DF0", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
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
	public class ZAOTAHCWIQQ : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class EFLKHXYADXP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public JDAQQVNNAHD WYBQGJRULHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader HTSLCUOSHXJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<SWWRVTHIXNA> VRAKHDZHEPD;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public EFLKHXYADXP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x73713F0", Offset = "0x73701F0", VA = "0x1873713F0")]
			internal SWWRVTHIXNA DNCCNQWBQLR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<SWWRVTHIXNA> UFIHQNVZUNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> DMCJDAUDBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> UTJPVFCRCJB;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x736EFA0", Offset = "0x736DDA0", VA = "0x18736EFA0")]
		public ZAOTAHCWIQQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x73829E0", Offset = "0x73817E0", VA = "0x1873829E0")]
		public static ZAOTAHCWIQQ Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7382DA0", Offset = "0x7381BA0", VA = "0x187382DA0", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class FDLRVHASUWI
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, VNZHPMRJBAB> ONPUXXGMZYN;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static OTWTAMHRJBG IZDQOVXNOZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, OOIVUJOYGNK> KLUJKTPAADU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken LEBUMIGPQOD;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7372760", Offset = "0x7371560", VA = "0x187372760")]
		public static VNZHPMRJBAB SLUUFQJRUIM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7371AE0", Offset = "0x73708E0", VA = "0x187371AE0")]
		public static OOIVUJOYGNK AKKWBZVKQWW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public FDLRVHASUWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7373560", Offset = "0x7372360", VA = "0x187373560")]
		public FDLRVHASUWI(FDLRVHASUWI a, [Optional] JDAQQVNNAHD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7371C90", Offset = "0x7370A90", VA = "0x187371C90")]
		public void GAQLYTIBZVJ(JDAQQVNNAHD a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7372030", Offset = "0x7370E30", VA = "0x187372030")]
		public void ODHNVZPCLQQ(string a, OOIVUJOYGNK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7371F40", Offset = "0x7370D40", VA = "0x187371F40")]
		private void HUPHIMRQRQA(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7372C70", Offset = "0x7371A70", VA = "0x187372C70")]
		private void ZWEQQEVDKWQ(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7371BD0", Offset = "0x73709D0", VA = "0x187371BD0")]
		private void AWDZZNJJZNO(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7372180", Offset = "0x7370F80", VA = "0x187372180")]
		internal static Dictionary<string, OOIVUJOYGNK> PRTBKFJJOUJ(JDAQQVNNAHD a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x73728F0", Offset = "0x73716F0", VA = "0x1873728F0", Slot = "4")]
		public virtual void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class JDAQQVNNAHD : FDLRVHASUWI
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class LAWFTANWYHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public JDAQQVNNAHD WYBQGJRULHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader JXZCVNOSVSN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<GCCXBATGNRZ> VRAKHDZHEPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<DVFBFVYZYIJ> VQVDJXFJVDU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<KPPNLJILLKX> VQPWMQLMLSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<ZZKTXONUPCL> VQKPPJRPCHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<IKVSZEFXJAW> VRVLWFAWQIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<PLMBHVMMJWO> VRQEYYGZGXE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<WLAKECNJBYY> VRKYBRNBXLV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<ZAOTAHCWIQQ> VRFREKTEOAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<YMNWEWAXNPC> VPKHDBWCHCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> VPFAFVCEXRA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<CKBETQYDMVN> TMDBJLNWIJQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<RNHNQGJJOGV> TMIIGSHTRUZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<IQVYZFPSFVC> TLSNOYABPMY;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public LAWFTANWYHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7379DD0", Offset = "0x7378BD0", VA = "0x187379DD0")]
			internal GCCXBATGNRZ DNCCNQWBQLR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7379DC0", Offset = "0x7378BC0", VA = "0x187379DC0")]
			internal DVFBFVYZYIJ DMWVQKCEHAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x7379DF0", Offset = "0x7378BF0", VA = "0x187379DF0")]
			internal KPPNLJILLKX DNMQIEJWJIJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7379DE0", Offset = "0x7378BE0", VA = "0x187379DE0")]
			internal ZZKTXONUPCL DNHJKXPYZXA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x7379D90", Offset = "0x7378B90", VA = "0x187379D90")]
			internal IKVSZEFXJAW DMHAYPUMESH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7379D80", Offset = "0x7378B80", VA = "0x187379D80")]
			internal PLMBHVMMJWO DMBUBJAOVGY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7379DB0", Offset = "0x7378BB0", VA = "0x187379DB0")]
			internal WLAKECNJBYY DMROTDIGXOZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7379DA0", Offset = "0x7378BA0", VA = "0x187379DA0")]
			internal ZAOTAHCWIQQ DMMHVWOJODQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x7379D70", Offset = "0x7378B70", VA = "0x187379D70")]
			internal YMNWEWAXNPC DLLZJOSWSYX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7379D60", Offset = "0x7378B60", VA = "0x187379D60")]
			internal Sampler DLGSMHYZJNO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7379E00", Offset = "0x7378C00", VA = "0x187379E00")]
			internal CKBETQYDMVN URENRCDGNIY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x7379F80", Offset = "0x7378D80", VA = "0x187379F80")]
			internal RNHNQGJJOGV URJUOIXDWUH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x7379F90", Offset = "0x7378D90", VA = "0x187379F90")]
			internal IQVYZFPSFVC URPBLPRBGFQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> XUZHYIRMNPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> GTRVYOHXOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<GCCXBATGNRZ> DQKRLIKHUIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<DVFBFVYZYIJ> OIEPPGSAGYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public PJZZABZARLW PJZZABZARLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<KPPNLJILLKX> UEVIWCLMYID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<ZZKTXONUPCL> IVOIFNIOYMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<IKVSZEFXJAW> ZEKCTYNJPPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<PLMBHVMMJWO> MYDMNIGDDBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<WLAKECNJBYY> MSSVCZMCJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<ZAOTAHCWIQQ> WDXCFSHWBWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<YMNWEWAXNPC> YFHJRBJSADX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> UBKTHQGWOPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public NIMXRZHNKSZ NSUBCZBTLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<CKBETQYDMVN> BPRSYYQMJSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<RNHNQGJJOGV> BTVCEIUGHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<IQVYZFPSFVC> RVVGGDWAFSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<KMVHITRYAHN> QLHZOYLUCQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool UFLDCULGMHF;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7378BA0", Offset = "0x73779A0", VA = "0x187378BA0")]
		public JDAQQVNNAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7376F50", Offset = "0x7375D50", VA = "0x187376F50")]
		public CKBETQYDMVN VEYTITNXGIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7376100", Offset = "0x7374F00", VA = "0x187376100")]
		public static JDAQQVNNAHD Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7376FF0", Offset = "0x7375DF0", VA = "0x187376FF0")]
		public void ZLPVCWRAQLQ(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class CKBETQYDMVN : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<OFMVRVAYDAN> YFHJRBJSADX;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x736EFA0", Offset = "0x736DDA0", VA = "0x18736EFA0")]
		public CKBETQYDMVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x736EBB0", Offset = "0x736D9B0", VA = "0x18736EBB0")]
		public static CKBETQYDMVN Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x736ED30", Offset = "0x736DB30", VA = "0x18736ED30", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class IQVYZFPSFVC : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TAKMMMSKBUZ COZNLPTFVZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public GKLGRGLVTZC HEJIKFGMTUJ;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x736EFA0", Offset = "0x736DDA0", VA = "0x18736EFA0")]
		public IQVYZFPSFVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7375440", Offset = "0x7374240", VA = "0x187375440")]
		public static IQVYZFPSFVC Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7375610", Offset = "0x7374410", VA = "0x187375610", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class SBVYTXBJXYJ : KMVHITRYAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x736EFA0", Offset = "0x736DDA0", VA = "0x18736EFA0")]
		public SBVYTXBJXYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7370A10", Offset = "0x736F810", VA = "0x187370A10", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class KMVHITRYAHN : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string GDOZECFRVGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color QWVIFCBLFSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string QROGATZCDZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float VWVULQYCHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float JXOCHTEBISB;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x736EFA0", Offset = "0x736DDA0", VA = "0x18736EFA0")]
		public KMVHITRYAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7379150", Offset = "0x7377F50", VA = "0x187379150", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class DNGFTANIEBV : KMVHITRYAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x736EFA0", Offset = "0x736DDA0", VA = "0x18736EFA0")]
		public DNGFTANIEBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7370A10", Offset = "0x736F810", VA = "0x187370A10", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class OAJHUMDSLTR : KMVHITRYAHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float HYRWVLLJUYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float OPHAVMQUIAH;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x737AF10", Offset = "0x7379D10", VA = "0x18737AF10")]
		public OAJHUMDSLTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x737AC10", Offset = "0x7379A10", VA = "0x18737AC10", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface FJMKRGENYEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PNAYZNATQYB(JDAQQVNNAHD a, MXAEAFOHWWG b, [Out] WOAPQRATMFN c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface OOIVUJOYGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OOIVUJOYGNK Clone(JDAQQVNNAHD root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class VNZHPMRJBAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string GKAQIVOUXIK;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		protected VNZHPMRJBAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class BQBTGPKZKBQ : OOIVUJOYGNK
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty FUQQPJZJZCF
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x736E3E0", Offset = "0x736D1E0", VA = "0x18736E3E0", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public BQBTGPKZKBQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class OTWTAMHRJBG : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x737B450", Offset = "0x737A250", VA = "0x18737B450", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public OTWTAMHRJBG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class ITKYRIBHQWI : FDLRVHASUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color PHVXEAMQWAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public FDRUDEHOSVN TKLKOZTCDWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color EGNKTTBHZER;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7376090", Offset = "0x7374E90", VA = "0x187376090")]
		public ITKYRIBHQWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7375B90", Offset = "0x7374990", VA = "0x187375B90")]
		public static ITKYRIBHQWI Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7375E30", Offset = "0x7374C30", VA = "0x187375E30", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class ISPJQBRPYCG : FDRUDEHOSVN
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string UCSDIJQVGZA = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double ZMJUOEPVXPQ;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7375B30", Offset = "0x7374930", VA = "0x187375B30")]
		public ISPJQBRPYCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7375780", Offset = "0x7374580", VA = "0x187375780")]
		public new static ISPJQBRPYCG Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7375A70", Offset = "0x7374870", VA = "0x187375A70", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class TEGAWRVLOXG : FDRUDEHOSVN
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string TOYPAVMPWYJ = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double RUMWQJYLXFT;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7375B30", Offset = "0x7374930", VA = "0x187375B30")]
		public TEGAWRVLOXG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x737FC50", Offset = "0x737EA50", VA = "0x18737FC50")]
		public new static TEGAWRVLOXG Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x737FF40", Offset = "0x737ED40", VA = "0x18737FF40", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class KXJWJGWYQSN : FDLRVHASUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color IKPYXZUYADV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public FDRUDEHOSVN LFYGZXKJLRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double XHKSGPSPPGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double DVYRDFAANEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public FDRUDEHOSVN IAYTYWHHSSI;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7379CF0", Offset = "0x7378AF0", VA = "0x187379CF0")]
		public KXJWJGWYQSN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x73796F0", Offset = "0x73784F0", VA = "0x1873796F0")]
		public static KXJWJGWYQSN Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7379A60", Offset = "0x7378860", VA = "0x187379A60", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class SWWRVTHIXNA : FDLRVHASUWI
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class HENKAPLGKWX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader HTSLCUOSHXJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public JDAQQVNNAHD WYBQGJRULHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<NVYFVNDMWDU> VRAKHDZHEPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<NVYFVNDMWDU> VQPWMQLMLSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, NVYFVNDMWDU>> VQVDJXFJVDU;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HENKAPLGKWX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x7374650", Offset = "0x7373450", VA = "0x187374650")]
			internal NVYFVNDMWDU DNCCNQWBQLR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x73745A0", Offset = "0x73733A0", VA = "0x1873745A0")]
			internal Dictionary<string, NVYFVNDMWDU> DMWVQKCEHAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x7374720", Offset = "0x7373520", VA = "0x187374720")]
			internal NVYFVNDMWDU DNMQIEJWJIJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, NVYFVNDMWDU> NSQVEWVZPOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public NVYFVNDMWDU JUKGHIDUBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public NDJFZLMCFXK IFHTWVDKOER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode YUSYSEDRHCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, NVYFVNDMWDU>> LAVNZNQITFY;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x737F500", Offset = "0x737E300", VA = "0x18737F500")]
		public SWWRVTHIXNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x737EE60", Offset = "0x737DC60", VA = "0x18737EE60")]
		public SWWRVTHIXNA(SWWRVTHIXNA a, JDAQQVNNAHD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x737DB60", Offset = "0x737C960", VA = "0x18737DB60")]
		public static int[] AEISRQDGUHC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x737E0C0", Offset = "0x737CEC0", VA = "0x18737E0C0")]
		public static int[] LWFXBUIOKNG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x737E570", Offset = "0x737D370", VA = "0x18737E570")]
		public static int[] WQSNQTHFWPA(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x737E320", Offset = "0x737D120", VA = "0x18737E320")]
		public static int[] RYGHQUFMNHA(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x737E730", Offset = "0x737D530", VA = "0x18737E730")]
		public static int[] WXCKDYUJZUB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x737DC00", Offset = "0x737CA00", VA = "0x18737DC00")]
		public static int[] CLGUPOJPOTG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x737E290", Offset = "0x737D090", VA = "0x18737E290")]
		public static int[] MWKZKGPSDEO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x737E220", Offset = "0x737D020", VA = "0x18737E220")]
		public static int[] MHMVUAVRERP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x737E7E0", Offset = "0x737D5E0", VA = "0x18737E7E0")]
		public static int[] XIHNCPKVPBN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x737DC70", Offset = "0x737CA70", VA = "0x18737DC70")]
		public static SWWRVTHIXNA Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x737E870", Offset = "0x737D670", VA = "0x18737E870", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class BXCXORFEJEV
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] BIXLLCJTRVM;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] GUSTJUYBAIH;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] IDZHWJNPRBC;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] XRBSRSLLYYM;
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
	public class YMNWEWAXNPC : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool EFAYRYCXRZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public EZSHZLHBYIC CBIEREFAIXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<OFMVRVAYDAN> WDBTAENPLDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public QCXQSQRAZEY RNHNQGJJOGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public FPNBMRBYURJ AXEFJQAREFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public DSHSRHRWLOQ IOTWTOZJGBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion LPLELFIJVOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 ZMJUOEPVXPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 PLWAWSNRRWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> DMCJDAUDBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public OMXNLWGKLKR PIITNVZVSTO;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x73828A0", Offset = "0x73816A0", VA = "0x1873828A0")]
		public YMNWEWAXNPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7381360", Offset = "0x7380160", VA = "0x187381360")]
		public static YMNWEWAXNPC Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7381CA0", Offset = "0x7380AA0", VA = "0x187381CA0", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode GAIXPMIWPVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode GFHOQNKDZPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode AFIFWFOGGVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode ADXJPKEYSUI;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x737FA60", Offset = "0x737E860", VA = "0x18737FA60")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x737F5A0", Offset = "0x737E3A0", VA = "0x18737F5A0")]
		public static Sampler Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x737F870", Offset = "0x737E670", VA = "0x18737F870", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
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
	public class RNHNQGJJOGV : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NVYFVNDMWDU CFUOSROAMLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public OFMVRVAYDAN QPQLFKIRRYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<OFMVRVAYDAN> UOFQWIXQWJD;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x737D570", Offset = "0x737C370", VA = "0x18737D570")]
		public RNHNQGJJOGV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x737CF00", Offset = "0x737BD00", VA = "0x18737CF00")]
		public static RNHNQGJJOGV Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x737D260", Offset = "0x737C060", VA = "0x18737D260", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class FDRUDEHOSVN : FDLRVHASUWI
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string ZYJKUHRNFEQ = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string JJGMAGDLEQC = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public LIIDGRHDUAW BFTLLAUIUZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int BIXLLCJTRVM;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7373CF0", Offset = "0x7372AF0", VA = "0x187373CF0")]
		public FDRUDEHOSVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7373C00", Offset = "0x7372A00", VA = "0x187373C00")]
		public FDRUDEHOSVN(FDRUDEHOSVN a, JDAQQVNNAHD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7373850", Offset = "0x7372650", VA = "0x187373850")]
		public static FDRUDEHOSVN Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7373BA0", Offset = "0x73729A0", VA = "0x187373BA0", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7373AD0", Offset = "0x73728D0", VA = "0x187373AD0")]
		public void VDPDRKSXWXF(JsonWriter a)
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
	public class GSWCCWFELDG
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double SJWJBBABDOO;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double MNJMJZVYBWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double BTJKHNSTOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double NSIZQCEUUEP;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7374520", Offset = "0x7373320", VA = "0x187374520")]
		public GSWCCWFELDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7374060", Offset = "0x7372E60", VA = "0x187374060")]
		public static GSWCCWFELDG Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x73742B0", Offset = "0x73730B0", VA = "0x1873742B0")]
		public void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class CWYNQPFUZQO : ZPLCQCTWSVD
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color YGDOYTWPXWN;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double BPRQYQFZMBJ;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double EMFNHZSJMPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType ULTKTFGCAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color GUSTJUYBAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double FQYIVQRKFFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double HDDCZTWDROV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public GSWCCWFELDG GSWCCWFELDG;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x736F8E0", Offset = "0x736E6E0", VA = "0x18736F8E0")]
		public CWYNQPFUZQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x736F9A0", Offset = "0x736E7A0", VA = "0x18736F9A0")]
		public CWYNQPFUZQO(CWYNQPFUZQO a, JDAQQVNNAHD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x736EFF0", Offset = "0x736DDF0", VA = "0x18736EFF0")]
		public static CWYNQPFUZQO Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x736F3E0", Offset = "0x736E1E0", VA = "0x18736F3E0")]
		public static CWYNQPFUZQO Deserialize(JDAQQVNNAHD root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x736F500", Offset = "0x736E300", VA = "0x18736F500", Slot = "4")]
		public override void ZLPVCWRAQLQ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class ZLZTHHHCUUM : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<KMVHITRYAHN> UATEKFMOPGV;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public ZLZTHHHCUUM(IList<KMVHITRYAHN> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x73833C0", Offset = "0x73821C0", VA = "0x1873833C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7383350", Offset = "0x7382150", VA = "0x187383350", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class DHDYPHIUCUY : OOIVUJOYGNK, FJMKRGENYEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<CWYNQPFUZQO> QLHZOYLUCQF;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7370990", Offset = "0x736F790", VA = "0x187370990")]
		public DHDYPHIUCUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x736FAD0", Offset = "0x736E8D0", VA = "0x18736FAD0", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7370400", Offset = "0x736F200", VA = "0x187370400", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7370150", Offset = "0x736EF50", VA = "0x187370150")]
		private static string[] QHTWXATQSXQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x73704F0", Offset = "0x736F2F0", VA = "0x1873704F0")]
		private static WOAPQRATMFN.ImportValuesConversion ZMTBPBJDEUM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x736FD60", Offset = "0x736EB60", VA = "0x18736FD60", Slot = "6")]
		public bool PNAYZNATQYB(JDAQQVNNAHD a, MXAEAFOHWWG b, [Out] WOAPQRATMFN c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class QPRIUYPLQMP : RQICLVFIUHZ<CWYNQPFUZQO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override CWYNQPFUZQO Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x737CB70", Offset = "0x737B970", VA = "0x18737CB70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x737CB30", Offset = "0x737B930", VA = "0x18737CB30")]
		public QPRIUYPLQMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x737CA50", Offset = "0x737B850", VA = "0x18737CA50")]
		public static QPRIUYPLQMP Deserialize(JDAQQVNNAHD root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class RGYLAIZCCWE : OOIVUJOYGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public QPRIUYPLQMP OMXNLWGKLKR;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public RGYLAIZCCWE(QPRIUYPLQMP a, JDAQQVNNAHD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x737CE40", Offset = "0x737BC40", VA = "0x18737CE40")]
		public RGYLAIZCCWE(int a, JDAQQVNNAHD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x737CCC0", Offset = "0x737BAC0", VA = "0x18737CCC0", Slot = "5")]
		public OOIVUJOYGNK Clone(JDAQQVNNAHD root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x737CD40", Offset = "0x737BB40", VA = "0x18737CD40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class SEBMDMCRCPX : VNZHPMRJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x737DB10", Offset = "0x737C910", VA = "0x18737DB10")]
		public SEBMDMCRCPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x737D620", Offset = "0x737C420", VA = "0x18737D620", Slot = "4")]
		public override OOIVUJOYGNK Deserialize(JDAQQVNNAHD root, JProperty extensionToken)
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
