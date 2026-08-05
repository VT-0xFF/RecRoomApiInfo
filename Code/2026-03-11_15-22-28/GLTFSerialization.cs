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
	public class KHR_animation_pointer : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object BVQPMXJBDRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string CLILWLARRAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string HXAZDSEAZDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public QHMEKTXIFJB NHXJKJIYHSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer ABDHLAWUMPK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72E85B0", Offset = "0x72E75B0", VA = "0x1872E85B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72E8500", Offset = "0x72E7500", VA = "0x1872E8500", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class QLZVAQEVOLE
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 WWZDJXFAVNH;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 KSGZLDXMPVK;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion YPTIMOWKSAY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool SCKVDEOPQPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x72F6A90", Offset = "0x72F5A90", VA = "0x1872F6A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72F6120", Offset = "0x72F5120", VA = "0x1872F6120")]
		public static void BJXSDOWZOFC(this TYZPRJYTRRB a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72F7AD0", Offset = "0x72F6AD0", VA = "0x1872F7AD0")]
		public static void LQRWOGQBRXI(this TYZPRJYTRRB a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72F9190", Offset = "0x72F8190", VA = "0x1872F9190")]
		public static void YYRVOZFYJCZ(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72F5F00", Offset = "0x72F4F00", VA = "0x1872F5F00")]
		public static GLTF.Math.Vector4 AQYHRHWIENJ(this BJDMLQQTHFA a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72F8EE0", Offset = "0x72F7EE0", VA = "0x1872F8EE0")]
		public static UnityEngine.Quaternion YFKADAPFCOG(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72F9060", Offset = "0x72F8060", VA = "0x1872F9060")]
		public static UnityEngine.Quaternion YFKADAPFCOG(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72F8B10", Offset = "0x72F7B10", VA = "0x1872F8B10")]
		public static GLTF.Math.Quaternion QOWLPXQGIVM(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72F8750", Offset = "0x72F7750", VA = "0x1872F8750")]
		public static Matrix4x4 PTKBVWVXVAJ(this BJDMLQQTHFA a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72F8310", Offset = "0x72F7310", VA = "0x1872F8310")]
		public static Matrix4x4 PTKBVWVXVAJ(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72F7FD0", Offset = "0x72F6FD0", VA = "0x1872F7FD0")]
		public static BJDMLQQTHFA NLIRFQZHPLH(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x72F9560", Offset = "0x72F8560", VA = "0x1872F9560")]
		public static UnityEngine.Vector3 ZKMWLVQTCMA(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x72F9680", Offset = "0x72F8680", VA = "0x1872F9680")]
		public static UnityEngine.Vector3 ZKMWLVQTCMA(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x72F66C0", Offset = "0x72F56C0", VA = "0x1872F66C0")]
		public static GLTF.Math.Vector3 BTIRXFAEQGA(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72F8D80", Offset = "0x72F7D80", VA = "0x1872F8D80")]
		public static GLTF.Math.Vector3 UOSRGSNLQTP(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x10DFA00", Offset = "0x10DEA00", VA = "0x1810DFA00")]
		public static GLTF.Math.Vector4 IFJOCGAYMKO(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72F6B20", Offset = "0x72F5B20", VA = "0x1872F6B20")]
		public static Matrix4x4 GLBIFWRTWLS(this BJDMLQQTHFA a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72F6DE0", Offset = "0x72F5DE0", VA = "0x1872F6DE0")]
		public static Matrix4x4 GLBIFWRTWLS(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72F74B0", Offset = "0x72F64B0", VA = "0x1872F74B0")]
		public static BJDMLQQTHFA HVOOGMEAROE(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72F8DF0", Offset = "0x72F7DF0", VA = "0x1872F8DF0")]
		public static UnityEngine.Vector2 YCVDISTVOGA(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72F8DF0", Offset = "0x72F7DF0", VA = "0x1872F8DF0")]
		public static UnityEngine.Vector2 YCVDISTVOGA(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72F8E10", Offset = "0x72F7E10", VA = "0x1872F8E10")]
		public static void YCVDISTVOGA(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72F7860", Offset = "0x72F6860", VA = "0x1872F7860")]
		public static UnityEngine.Vector3 KUIFOZJJOLD(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1B08730", Offset = "0x1B07730", VA = "0x181B08730")]
		public static UnityEngine.Vector3 KUIFOZJJOLD(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72F7770", Offset = "0x72F6770", VA = "0x1872F7770")]
		public static void KUIFOZJJOLD(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x10DFA00", Offset = "0x10DEA00", VA = "0x1810DFA00")]
		public static UnityEngine.Vector4 KXMYRDGCVGG(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x10DFA00", Offset = "0x10DEA00", VA = "0x1810DFA00")]
		public static UnityEngine.Vector4 KXMYRDGCVGG(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72F79D0", Offset = "0x72F69D0", VA = "0x1872F79D0")]
		public static UnityEngine.Vector4[] KXMYRDGCVGG(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72F78C0", Offset = "0x72F68C0", VA = "0x1872F78C0")]
		public static void KXMYRDGCVGG(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72F72D0", Offset = "0x72F62D0", VA = "0x1872F72D0")]
		public static UnityEngine.Color HOGIXWKQZME(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72F7370", Offset = "0x72F6370", VA = "0x1872F7370")]
		public static void HOGIXWKQZME(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72F72D0", Offset = "0x72F62D0", VA = "0x1872F72D0")]
		public static UnityEngine.Color HOGIXWKQZME(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x10DFA00", Offset = "0x10DEA00", VA = "0x1810DFA00")]
		public static UnityEngine.Color CYITLHWGLJJ(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72F6950", Offset = "0x72F5950", VA = "0x1872F6950")]
		public static void CYITLHWGLJJ(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10DFA00", Offset = "0x10DEA00", VA = "0x1810DFA00")]
		public static UnityEngine.Color CYITLHWGLJJ(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x72F6A60", Offset = "0x72F5A60", VA = "0x1872F6A60")]
		public static GLTF.Math.Color EEOORGDLYXL(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x72F76F0", Offset = "0x72F66F0", VA = "0x1872F76F0")]
		public static GLTF.Math.Color JUJDTQPMZWI(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x72F8D00", Offset = "0x72F7D00", VA = "0x1872F8D00")]
		public static GLTF.Math.Color SIAFIVPWSTM(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x72F7050", Offset = "0x72F6050", VA = "0x1872F7050")]
		public static UnityEngine.Color[] GRKLXDOITKT(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72F9750", Offset = "0x72F8750", VA = "0x1872F9750")]
		public static int[] ZUVITRJQCDQ(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72F8C50", Offset = "0x72F7C50", VA = "0x1872F8C50")]
		public static UnityEngine.Vector2[] QRUXMVVPMMJ(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x72F7170", Offset = "0x72F6170", VA = "0x1872F7170")]
		public static void GWAMTRWBLAS(OBAKQCLHDHI a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x72F67F0", Offset = "0x72F57F0", VA = "0x1872F67F0")]
		public static UnityEngine.Vector3[] CPUBVFBLGPY(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x72F8970", Offset = "0x72F7970", VA = "0x1872F8970")]
		public static UnityEngine.Vector4[] QEDXEZFZRJV(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x72F7680", Offset = "0x72F6680", VA = "0x1872F7680")]
		public static void JLHRPUDPEHI(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x72F8DC0", Offset = "0x72F7DC0", VA = "0x1872F8DC0")]
		public static UnityEngine.Quaternion UYNTFNWADOY(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class OBAKQCLHDHI
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EYAPWMIFCXD EYAPWMIFCXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray OJSXATTVZWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x72EE500", Offset = "0x72ED500", VA = "0x1872EE500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> MYCQGKVXELX
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xC51700", Offset = "0xC50700", VA = "0x180C51700")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD3C8A0", Offset = "0xD3B8A0", VA = "0x180D3C8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint FPXZBOIVLKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAD6FE0", Offset = "0xAD5FE0", VA = "0x180AD6FE0")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAD7820", Offset = "0xAD6820", VA = "0x180AD7820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72EE510", Offset = "0x72ED510", VA = "0x1872EE510")]
		public OBAKQCLHDHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x72E39C0", Offset = "0x72E29C0", VA = "0x1872E39C0")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72E3A20", Offset = "0x72E2A20", VA = "0x1872E3A20")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class PATONAIPDJB
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class PNKWDOZRVIU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> IBWTZDJDKPU;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public PNKWDOZRVIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x72F11F0", Offset = "0x72F01F0", VA = "0x1872F11F0")]
			internal int? STLDLSEEABV(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x72F1340", Offset = "0x72F0340", VA = "0x1872F1340")]
			internal int? YIBGXMFFUBE(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x72F1270", Offset = "0x72F0270", VA = "0x1872F1270")]
			internal bool TCXIIXXKWIS(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x72F07A0", Offset = "0x72EF7A0", VA = "0x1872F07A0")]
		private static void TDHUHKWWQEQ(NumericArray a, OBAKQCLHDHI b, OBAKQCLHDHI c, OBAKQCLHDHI d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x72EF050", Offset = "0x72EE050", VA = "0x1872EF050")]
		public static void OJDXMRPEZFP(Dictionary<string, OBAKQCLHDHI> a, Dictionary<string, (OBAKQCLHDHI sparseIndices, OBAKQCLHDHI sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x72F0D10", Offset = "0x72EFD10", VA = "0x1872F0D10")]
		public static void VUEBYPQJTQV(Dictionary<string, OBAKQCLHDHI> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x72EE7D0", Offset = "0x72ED7D0", VA = "0x1872EE7D0")]
		public static void HBSSQGHEYZU(OBAKQCLHDHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72EEAC0", Offset = "0x72EDAC0", VA = "0x1872EEAC0")]
		public static void NNINRXVWTNW(Dictionary<string, List<OBAKQCLHDHI>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x72EE8D0", Offset = "0x72ED8D0", VA = "0x1872EE8D0")]
		private static void HQAIPBTWXGA(OBAKQCLHDHI a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x72EEA00", Offset = "0x72EDA00", VA = "0x1872EEA00")]
		internal static void HQAIPBTWXGA(FYLOPNQZFTG a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x72F0310", Offset = "0x72EF310", VA = "0x1872F0310")]
		public static WNSFDIRCAVY TCZIHVVNSDK(IEnumerable<WNSFDIRCAVY> a)
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
			[Cpp2IlInjected.Address(RVA = "0xCEC5F0", Offset = "0xCEB5F0", VA = "0x180CEC5F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x134CE70", Offset = "0x134BE70", VA = "0x18134CE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2E597D0", Offset = "0x2E587D0", VA = "0x182E597D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2E597E0", Offset = "0x2E587E0", VA = "0x182E597E0")]
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
	public class LFKVJSEQLPT
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint TXAWZMSHHMG;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint VYUNNNARENO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint MMCAWBONURE;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x72EBCE0", Offset = "0x72EACE0", VA = "0x1872EBCE0")]
		public static void GOIGXAEEQQU(Stream a, [Out] OOJQGESWHUS b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x72EBEA0", Offset = "0x72EAEA0", VA = "0x1872EBEA0")]
		public static ChunkInfo MXRWWLWKPBG(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x72EBBA0", Offset = "0x72EABA0", VA = "0x1872EBBA0")]
		public static GLBHeader BPMBGYJJRGU(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x72EC5D0", Offset = "0x72EB5D0", VA = "0x1872EC5D0")]
		public static bool ZZPJSFNKEJU(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x72EC1C0", Offset = "0x72EB1C0", VA = "0x1872EC1C0")]
		public static ChunkInfo PZQRLUUVJWT(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x72EC330", Offset = "0x72EB330", VA = "0x1872EC330")]
		private static void UWXGEQYODHH(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x72EC130", Offset = "0x72EB130", VA = "0x1872EC130")]
		private static uint OHSZIHFKNBC(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class CUDWNAWDSRZ
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
		public PathElement WMTUEDQEORO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xACA110", Offset = "0xAC9110", VA = "0x180ACA110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAD4F50", Offset = "0xAD3F50", VA = "0x180AD4F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int EGJQZYNDVNP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB7CE40", Offset = "0xB7BE40", VA = "0x180B7CE40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xB7CC80", Offset = "0xB7BC80", VA = "0x180B7CC80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string OKKNMZCLDTA
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F60", Offset = "0xAD1F60", VA = "0x180AD2F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GXWCXKWFLAD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F00", Offset = "0xAD1F00", VA = "0x180AD2F00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAD3550", Offset = "0xAD2550", VA = "0x180AD3550")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CUDWNAWDSRZ OITYLYMKFLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xACDA30", Offset = "0xACCA30", VA = "0x180ACDA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x72E2F30", Offset = "0x72E1F30", VA = "0x1872E2F30")]
		public string MCPLUWJWMWX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x72E2FB0", Offset = "0x72E1FB0", VA = "0x1872E2FB0")]
		public CUDWNAWDSRZ XWUZPCTHRFH(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x72E31C0", Offset = "0x72E21C0", VA = "0x1872E31C0")]
		private CUDWNAWDSRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x72E3010", Offset = "0x72E2010", VA = "0x1872E3010")]
		public CUDWNAWDSRZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x41724D0", Offset = "0x41714D0", VA = "0x1841724D0")]
		[CompilerGenerated]
		internal static string ZPRRIYVCXFB(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72E2FD0", Offset = "0x72E1FD0", VA = "0x1872E2FD0")]
		[CompilerGenerated]
		internal static bool YLSOVCXOHUS([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72E2D50", Offset = "0x72E1D50", VA = "0x1872E2D50")]
		[CompilerGenerated]
		internal static CUDWNAWDSRZ BSQOTLXVGBO(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ZNKSCMLIVYA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72FCA90", Offset = "0x72FBA90", VA = "0x1872FCA90")]
		public static int[] CSNTDZRCMJI(this OOJQGESWHUS a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72FC940", Offset = "0x72FB940", VA = "0x1872FC940")]
		public static int[] CFWJUMNOWMM(this OOJQGESWHUS a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class IUVTAKJGHRO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72E65E0", Offset = "0x72E55E0", VA = "0x1872E65E0")]
		public static uint UHKZLNXAWBN(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream RRYSGRSTIZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long OLAJWHHFDIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long CHKTSKZFKMT;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x72FADA0", Offset = "0x72F9DA0", VA = "0x1872FADA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x72FADE0", Offset = "0x72F9DE0", VA = "0x1872FADE0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x72FADE0", Offset = "0x72F9DE0", VA = "0x1872FADE0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x72FAE00", Offset = "0x72F9E00", VA = "0x1872FAE00", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x72FAE20", Offset = "0x72F9E20", VA = "0x1872FAE20", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x72FAE40", Offset = "0x72F9E40", VA = "0x1872FAE40", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x72FAB30", Offset = "0x72F9B30", VA = "0x1872FAB30")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x72FA8F0", Offset = "0x72F98F0", VA = "0x1872FA8F0", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x72FA9C0", Offset = "0x72F99C0", VA = "0x1872FA9C0", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x72FAA20", Offset = "0x72F9A20", VA = "0x1872FAA20", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x72FA930", Offset = "0x72F9930", VA = "0x1872FA930", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x72FAAF0", Offset = "0x72F9AF0", VA = "0x1872FAAF0", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x72FAA60", Offset = "0x72F9A60", VA = "0x1872FAA60")]
		private void WQJTHKUCXBE()
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
		public static Color LLGATNROYLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x72E34D0", Offset = "0x72E24D0", VA = "0x1872E34D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color NPEAKBFMSIA
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x72E34F0", Offset = "0x72E24F0", VA = "0x1872E34F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color WTHLDEKTPBC
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x72E3500", Offset = "0x72E2500", VA = "0x1872E3500")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B73760", Offset = "0x2B72760", VA = "0x182B73760")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x15EAB50", Offset = "0x15E9B50", VA = "0x1815EAB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1A20", Offset = "0x2BD0A20", VA = "0x182BD1A20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1A30", Offset = "0x2BD0A30", VA = "0x182BD1A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x294C440", Offset = "0x294B440", VA = "0x18294C440")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x304D700", Offset = "0x304C700", VA = "0x18304D700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x12A6DE0", Offset = "0x12A5DE0", VA = "0x1812A6DE0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x12A6DF0", Offset = "0x12A5DF0", VA = "0x1812A6DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x290EAE0", Offset = "0x290DAE0", VA = "0x18290EAE0")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x72E32D0", Offset = "0x72E22D0", VA = "0x1872E32D0", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x72E3380", Offset = "0x72E2380", VA = "0x1872E3380", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x72E3420", Offset = "0x72E2420", VA = "0x1872E3420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x72E3220", Offset = "0x72E2220", VA = "0x1872E3220")]
		public static bool EZMIFLQBTDA(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class BJDMLQQTHFA : IEquatable<BJDMLQQTHFA>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly BJDMLQQTHFA BOXXDPSGTWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] MOTYGWZFXKT;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float JEKSCJJASNK
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x72E27C0", Offset = "0x72E17C0", VA = "0x1872E27C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x72E2850", Offset = "0x72E1850", VA = "0x1872E2850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float PCTPOBXOCDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x72E2640", Offset = "0x72E1640", VA = "0x1872E2640")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x72E26D0", Offset = "0x72E16D0", VA = "0x1872E26D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float WDAGSGRVYZA
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x72E24F0", Offset = "0x72E14F0", VA = "0x1872E24F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x72E25E0", Offset = "0x72E15E0", VA = "0x1872E25E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float BHXSGZUCMRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x72E2970", Offset = "0x72E1970", VA = "0x1872E2970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x72E20A0", Offset = "0x72E10A0", VA = "0x1872E20A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float JFAMUDQSUVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x72E27F0", Offset = "0x72E17F0", VA = "0x1872E27F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x72E2880", Offset = "0x72E1880", VA = "0x1872E2880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float PCYWLIRLLOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x72E26A0", Offset = "0x72E16A0", VA = "0x1872E26A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x72E2730", Offset = "0x72E1730", VA = "0x1872E2730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float WCUZUZXYPNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x72E2490", Offset = "0x72E1490", VA = "0x1872E2490")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x72E2580", Offset = "0x72E1580", VA = "0x1872E2580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float BHHXPFMKKJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x72E2940", Offset = "0x72E1940", VA = "0x1872E2940")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x72E2070", Offset = "0x72E1070", VA = "0x1872E2070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float JEVFWWWVLKC
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x72E2820", Offset = "0x72E1820", VA = "0x1872E2820")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x72E28B0", Offset = "0x72E18B0", VA = "0x1872E28B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float PDEDIPLIVAB
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x72E2670", Offset = "0x72E1670", VA = "0x1872E2670")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x72E2700", Offset = "0x72E1700", VA = "0x1872E2700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float WCPSXTEBGCI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x72E24C0", Offset = "0x72E14C0", VA = "0x1872E24C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x72E25B0", Offset = "0x72E15B0", VA = "0x1872E25B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float BHNEMMGHTVB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x72E2910", Offset = "0x72E1910", VA = "0x1872E2910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x72E2040", Offset = "0x72E1040", VA = "0x1872E2040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float JDUXKPBIQFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x72E2790", Offset = "0x72E1790", VA = "0x1872E2790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x72E28E0", Offset = "0x72E18E0", VA = "0x1872E28E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float PBTHBUCBGYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x72E2610", Offset = "0x72E1610", VA = "0x1872E2610")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x72E2760", Offset = "0x72E1760", VA = "0x1872E2760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float WCKMAMKDWQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x72E2520", Offset = "0x72E1520", VA = "0x1872E2520")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x72E2550", Offset = "0x72E1550", VA = "0x1872E2550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float BGXJURYPRNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x72E29A0", Offset = "0x72E19A0", VA = "0x1872E29A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x72E2010", Offset = "0x72E1010", VA = "0x1872E2010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x72E2AA0", Offset = "0x72E1AA0", VA = "0x1872E2AA0")]
		public BJDMLQQTHFA(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72E21D0", Offset = "0x72E11D0", VA = "0x1872E21D0", Slot = "4")]
		public bool Equals(BJDMLQQTHFA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x72E20D0", Offset = "0x72E10D0", VA = "0x1872E20D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xE60BE0", Offset = "0xE5FBE0", VA = "0x180E60BE0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B73760", Offset = "0x2B72760", VA = "0x182B73760")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x15EAB50", Offset = "0x15E9B50", VA = "0x1815EAB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1A20", Offset = "0x2BD0A20", VA = "0x182BD1A20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1A30", Offset = "0x2BD0A30", VA = "0x182BD1A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x294C440", Offset = "0x294B440", VA = "0x18294C440")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x304D700", Offset = "0x304C700", VA = "0x18304D700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x12A6DE0", Offset = "0x12A5DE0", VA = "0x1812A6DE0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x12A6DF0", Offset = "0x12A5DF0", VA = "0x1812A6DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72F9C10", Offset = "0x72F8C10", VA = "0x1872F9C10")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72F98F0", Offset = "0x72F88F0", VA = "0x1872F98F0", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x72F9A10", Offset = "0x72F8A10", VA = "0x1872F9A10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72F9AC0", Offset = "0x72F8AC0", VA = "0x1872F9AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72F9880", Offset = "0x72F8880", VA = "0x1872F9880")]
		public static bool EZMIFLQBTDA(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B73760", Offset = "0x2B72760", VA = "0x182B73760")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x15EAB50", Offset = "0x15E9B50", VA = "0x1815EAB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1A20", Offset = "0x2BD0A20", VA = "0x182BD1A20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1A30", Offset = "0x2BD0A30", VA = "0x182BD1A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xDCF030", Offset = "0xDCE030", VA = "0x180DCF030")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x72FC100", Offset = "0x72FB100", VA = "0x1872FC100")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x72FBF70", Offset = "0x72FAF70", VA = "0x1872FBF70", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x72FBFD0", Offset = "0x72FAFD0", VA = "0x1872FBFD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x72FC0B0", Offset = "0x72FB0B0", VA = "0x1872FC0B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x72FBF10", Offset = "0x72FAF10", VA = "0x1872FBF10")]
		public static bool EZMIFLQBTDA(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B73760", Offset = "0x2B72760", VA = "0x182B73760")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x15EAB50", Offset = "0x15E9B50", VA = "0x1815EAB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1A20", Offset = "0x2BD0A20", VA = "0x182BD1A20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1A30", Offset = "0x2BD0A30", VA = "0x182BD1A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x294C440", Offset = "0x294B440", VA = "0x18294C440")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x304D700", Offset = "0x304C700", VA = "0x18304D700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x72FC4B0", Offset = "0x72FB4B0", VA = "0x1872FC4B0")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x72FC190", Offset = "0x72FB190", VA = "0x1872FC190", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x72FC270", Offset = "0x72FB270", VA = "0x1872FC270", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x72FC330", Offset = "0x72FB330", VA = "0x1872FC330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x72FC120", Offset = "0x72FB120", VA = "0x1872FC120")]
		public static bool EZMIFLQBTDA(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B73760", Offset = "0x2B72760", VA = "0x182B73760")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x15EAB50", Offset = "0x15E9B50", VA = "0x1815EAB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1A20", Offset = "0x2BD0A20", VA = "0x182BD1A20")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1A30", Offset = "0x2BD0A30", VA = "0x182BD1A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x294C440", Offset = "0x294B440", VA = "0x18294C440")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x304D700", Offset = "0x304C700", VA = "0x18304D700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x12A6DE0", Offset = "0x12A5DE0", VA = "0x1812A6DE0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x12A6DF0", Offset = "0x12A5DF0", VA = "0x1812A6DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x290EAE0", Offset = "0x290DAE0", VA = "0x18290EAE0")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x72E32D0", Offset = "0x72E22D0", VA = "0x1872E32D0", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x72FC530", Offset = "0x72FB530", VA = "0x1872FC530", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x72E3420", Offset = "0x72E2420", VA = "0x1872E3420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class QETFZNEJJSY
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x72F5E80", Offset = "0x72F4E80", VA = "0x1872F5E80")]
		public static void MVVJCCRMSWZ(this JObject a, string b, NZVXSFRUMVE c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class IUVTAKJGHRO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x72E5D20", Offset = "0x72E4D20", VA = "0x1872E5D20")]
		public static List<string> PTPUKNRKCWG(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x72E4A90", Offset = "0x72E3A90", VA = "0x1872E4A90")]
		public static List<double> CHMABOAEIRY(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x72E58B0", Offset = "0x72E48B0", VA = "0x1872E58B0")]
		public static List<int> LBZLUFXUYMJ(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x37AF5A0", Offset = "0x37AE5A0", VA = "0x1837AF5A0")]
		public static List<a> TCWMCMYZZIH<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x72E5A70", Offset = "0x72E4A70", VA = "0x1872E5A70")]
		public static NZVXSFRUMVE ORRVJXJINXP(this JToken a, OOJQGESWHUS b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x72E51F0", Offset = "0x72E41F0", VA = "0x1872E51F0")]
		public static int EDYULZJVRAL(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x72E6730", Offset = "0x72E5730", VA = "0x1872E6730")]
		public static double WTVAXVSWKKP(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x72E4F10", Offset = "0x72E3F10", VA = "0x1872E4F10")]
		public static GLTF.Math.Color CWBKTEUGWAI(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x72E5330", Offset = "0x72E4330", VA = "0x1872E5330")]
		public static GLTF.Math.Color HYZPTGENOSV(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x72E5ED0", Offset = "0x72E4ED0", VA = "0x1872E5ED0")]
		public static GLTF.Math.Color QWFLBVRTLUV(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x72E4C50", Offset = "0x72E3C50", VA = "0x1872E4C50")]
		public static GLTF.Math.Vector3 CVBKUUFNNDL(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x72E63D0", Offset = "0x72E53D0", VA = "0x1872E63D0")]
		public static GLTF.Math.Vector2 QYVISYVLYHP(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x72E6170", Offset = "0x72E5170", VA = "0x1872E6170")]
		public static GLTF.Math.Vector3 QYQBVSBOOWG(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x72E55A0", Offset = "0x72E45A0", VA = "0x1872E55A0")]
		public static GLTF.Math.Quaternion IEIMHDMTNIL(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x37AEF90", Offset = "0x37ADF90", VA = "0x1837AEF90")]
		public static Dictionary<string, b> QKJFNAXGHOX<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x37AEC40", Offset = "0x37ADC40", VA = "0x1837AEC40")]
		public static c NDHRSPFIAEX<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public FYLOPNQZFTG bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x72E3810", Offset = "0x72E2810", VA = "0x1872E3810", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x72E3790", Offset = "0x72E2790", VA = "0x1872E3790", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class OTVRZFYGMWD : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x72EE780", Offset = "0x72ED780", VA = "0x1872EE780")]
		public OTVRZFYGMWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x72EE6B0", Offset = "0x72ED6B0", VA = "0x1872EE6B0", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, EYAPWMIFCXD> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x72E3650", Offset = "0x72E2650", VA = "0x1872E3650", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x72E3710", Offset = "0x72E2710", VA = "0x1872E3710")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class XWWHTWFYJIN : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class MJLEUFQBZLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public OOJQGESWHUS EQMHNAKVRHZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader XQUHCHGKMCE;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public MJLEUFQBZLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x72ED780", Offset = "0x72EC780", VA = "0x1872ED780")]
			internal EYAPWMIFCXD NDWSYKVTFHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x72FC8F0", Offset = "0x72FB8F0", VA = "0x1872FC8F0")]
		public XWWHTWFYJIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x72FC760", Offset = "0x72FB760", VA = "0x1872FC760", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TVZOCOZDSJH EWTGXHTYGPU;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public EXT_texture_exr(TVZOCOZDSJH source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x72E3860", Offset = "0x72E2860", VA = "0x1872E3860", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x72E38D0", Offset = "0x72E28D0", VA = "0x1872E38D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class OOBHMGXAPQE : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x72EE660", Offset = "0x72ED660", VA = "0x1872EE660")]
		public OOBHMGXAPQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x72EE540", Offset = "0x72ED540", VA = "0x1872EE540", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
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
	public class AudioEmitterId : XLBMFMPGHOM<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x72E1C10", Offset = "0x72E0C10", VA = "0x1872E1C10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x72E1BD0", Offset = "0x72E0BD0", VA = "0x1872E1BD0")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : XLBMFMPGHOM<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x72E1DA0", Offset = "0x72E0DA0", VA = "0x1872E1DA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x72E1D60", Offset = "0x72E0D60", VA = "0x1872E1D60")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : XLBMFMPGHOM<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x72E1A80", Offset = "0x72E0A80", VA = "0x1872E1A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x72E1A40", Offset = "0x72E0A40", VA = "0x1872E1A40")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x72E1960", Offset = "0x72E0960", VA = "0x1872E1960")]
		public static AudioDataId Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x72E8220", Offset = "0x72E7220", VA = "0x1872E8220", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x72E7E20", Offset = "0x72E6E20", VA = "0x1872E7E20", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x72E7E90", Offset = "0x72E6E90", VA = "0x1872E7E90")]
		public static KHR_SceneAudioEmittersRef Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x72E8480", Offset = "0x72E7480", VA = "0x1872E8480")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x72E7DF0", Offset = "0x72E6DF0", VA = "0x1872E7DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x72E7CD0", Offset = "0x72E6CD0", VA = "0x1872E7CD0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x72E7AC0", Offset = "0x72E6AC0", VA = "0x1872E7AC0", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x72E7B30", Offset = "0x72E6B30", VA = "0x1872E7B30")]
		public static KHR_NodeAudioEmitterRef Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class UNMCOQKKSSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string VBKGSMZFFWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? QMEJXQNXVOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? SLZBLWWUIWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? IFBVCTLDXUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? TJVZBUOLARL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? NDJDITHHXDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? BKAMVSPCNPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? KBLOBCYELZI;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x72FBA40", Offset = "0x72FAA40", VA = "0x1872FBA40")]
		public JObject XRHSQBYDVHR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x72FB340", Offset = "0x72FA340", VA = "0x1872FB340")]
		public static UNMCOQKKSSV Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public UNMCOQKKSSV()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : WWKHVVRBHHC
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
		public UNMCOQKKSSV positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x72E7110", Offset = "0x72E6110", VA = "0x1872E7110", Slot = "5")]
		public virtual JObject XRHSQBYDVHR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x72E6C10", Offset = "0x72E5C10", VA = "0x1872E6C10")]
		public static KHR_AudioEmitter Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x72E74B0", Offset = "0x72E64B0", VA = "0x1872E74B0")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : WWKHVVRBHHC
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
		[Cpp2IlInjected.Address(RVA = "0x72E7890", Offset = "0x72E6890", VA = "0x1872E7890")]
		public JObject XRHSQBYDVHR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x72E7530", Offset = "0x72E6530", VA = "0x1872E7530")]
		public static KHR_AudioSource Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x72E6C00", Offset = "0x72E5C00", VA = "0x1872E6C00")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : WWKHVVRBHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public JTDIVYFLNOF bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x72E6AD0", Offset = "0x72E5AD0", VA = "0x1872E6AD0")]
		public JObject XRHSQBYDVHR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x72E6870", Offset = "0x72E5870", VA = "0x1872E6870")]
		public static KHR_AudioData Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x72E6C00", Offset = "0x72E5C00", VA = "0x1872E6C00")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : PGQGJSOHBMX
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
		[Cpp2IlInjected.Address(RVA = "0x72E8740", Offset = "0x72E7740", VA = "0x1872E8740", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x72E86B0", Offset = "0x72E76B0", VA = "0x1872E86B0", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x72E8E70", Offset = "0x72E7E70", VA = "0x1872E8E70")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class LGNLHSVADKE : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x72ED2B0", Offset = "0x72EC2B0", VA = "0x1872ED2B0")]
		public LGNLHSVADKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x72EC6F0", Offset = "0x72EB6F0", VA = "0x1872EC6F0", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JTDIVYFLNOF bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x72E9040", Offset = "0x72E8040", VA = "0x1872E9040", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x72E8F80", Offset = "0x72E7F80", VA = "0x1872E8F80", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x72E9090", Offset = "0x72E8090", VA = "0x1872E9090")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class NUKZSUHFXZA : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class MJLEUFQBZLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader XQUHCHGKMCE;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public MJLEUFQBZLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x72ED710", Offset = "0x72EC710", VA = "0x1872ED710")]
			internal int NDWSYKVTFHE()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x72EE1F0", Offset = "0x72ED1F0", VA = "0x1872EE1F0")]
		public NUKZSUHFXZA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x72EDFE0", Offset = "0x72ECFE0", VA = "0x1872EDFE0", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NZVXSFRUMVE anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x72E9190", Offset = "0x72E8190", VA = "0x1872E9190", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x72E9110", Offset = "0x72E8110", VA = "0x1872E9110", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class ITKTHZVEKGJ : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x72E4A40", Offset = "0x72E3A40", VA = "0x1872E4A40")]
		public ITKTHZVEKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x72E4890", Offset = "0x72E3890", VA = "0x1872E4890", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NZVXSFRUMVE clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NZVXSFRUMVE clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NZVXSFRUMVE clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x72E9440", Offset = "0x72E8440", VA = "0x1872E9440", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x72E93A0", Offset = "0x72E83A0", VA = "0x1872E93A0", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class AKLULRTCINR : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x72E1910", Offset = "0x72E0910", VA = "0x1872E1910")]
		public AKLULRTCINR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x72E1690", Offset = "0x72E0690", VA = "0x1872E1690", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x72E97A0", Offset = "0x72E87A0", VA = "0x1872E97A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x72E9730", Offset = "0x72E8730", VA = "0x1872E9730", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class BDKFMQLUDVJ : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x72E1FC0", Offset = "0x72E0FC0", VA = "0x1872E1FC0")]
		public BDKFMQLUDVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x72E1EF0", Offset = "0x72E0EF0", VA = "0x1872E1EF0", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : XTKYYAYTVNJ, PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float LPWTVKZBCCR;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x72E9A80", Offset = "0x72E8A80", VA = "0x1872E9A80")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x72E9AD0", Offset = "0x72E8AD0", VA = "0x1872E9AD0")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, OOJQGESWHUS root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x72E98C0", Offset = "0x72E88C0", VA = "0x1872E98C0", Slot = "6")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x72E9960", Offset = "0x72E8960", VA = "0x1872E9960", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class GXXXCFGOPBO : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x72E3D30", Offset = "0x72E2D30", VA = "0x1872E3D30")]
		public GXXXCFGOPBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x72E3C30", Offset = "0x72E2C30", VA = "0x1872E3C30", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x72E9BA0", Offset = "0x72E8BA0", VA = "0x1872E9BA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x72E9B40", Offset = "0x72E8B40", VA = "0x1872E9B40", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x72E9CF0", Offset = "0x72E8CF0", VA = "0x1872E9CF0")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class HWZURKSGFOD : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x72E4840", Offset = "0x72E3840", VA = "0x1872E4840")]
		public HWZURKSGFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x72E4770", Offset = "0x72E3770", VA = "0x1872E4770", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public NZVXSFRUMVE iridescenceTexture;

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
		public NZVXSFRUMVE iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x72E9DA0", Offset = "0x72E8DA0", VA = "0x1872E9DA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x72E9D00", Offset = "0x72E8D00", VA = "0x1872E9D00", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x72EA160", Offset = "0x72E9160", VA = "0x1872EA160")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class RWBSCSPQYFH : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x72FA240", Offset = "0x72F9240", VA = "0x1872FA240")]
		public RWBSCSPQYFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x72F9F50", Offset = "0x72F8F50", VA = "0x1872F9F50", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class HSTPFJNOVTS : PGQGJSOHBMX
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 OLNAXKXDEFK;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double SDWZGITPWNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color TKJHBFHKTUE;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color CMXFMAFDMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public NZVXSFRUMVE BZUOSQKJVOO;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly NZVXSFRUMVE PBWLMJZOQER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 UEWEQNHQWEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double RCQGQQLXMTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public NZVXSFRUMVE UFPWIRGUTFN;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly NZVXSFRUMVE KDICPBRPJBZ;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x72E4680", Offset = "0x72E3680", VA = "0x1872E4680")]
		public HSTPFJNOVTS(GLTF.Math.Color a, NZVXSFRUMVE b, GLTF.Math.Vector3 c, double d, NZVXSFRUMVE e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x72E3D80", Offset = "0x72E2D80", VA = "0x1872E3D80", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x72E3F30", Offset = "0x72E2F30", VA = "0x1872E3F30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class SNYWNENWNMG : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x72FA7D0", Offset = "0x72F97D0", VA = "0x1872FA7D0")]
		public SNYWNENWNMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x72FA480", Offset = "0x72F9480", VA = "0x1872FA480", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public NZVXSFRUMVE sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NZVXSFRUMVE sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x72EA250", Offset = "0x72E9250", VA = "0x1872EA250", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x72EA180", Offset = "0x72E9180", VA = "0x1872EA180", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x72EA760", Offset = "0x72E9760", VA = "0x1872EA760")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class RMRTLDBFEFK : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x72F9F00", Offset = "0x72F8F00", VA = "0x1872F9F00")]
		public RMRTLDBFEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x72F9CA0", Offset = "0x72F8CA0", VA = "0x1872F9CA0", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NZVXSFRUMVE specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NZVXSFRUMVE specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x72EA890", Offset = "0x72E9890", VA = "0x1872EA890", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x72EA7C0", Offset = "0x72E97C0", VA = "0x1872EA7C0", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x72EADA0", Offset = "0x72E9DA0", VA = "0x1872EADA0")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class OANCMQMSAOI : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x72EE4B0", Offset = "0x72ED4B0", VA = "0x1872EE4B0")]
		public OANCMQMSAOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x72EE240", Offset = "0x72ED240", VA = "0x1872EE240", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public NZVXSFRUMVE transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x72EAE90", Offset = "0x72E9E90", VA = "0x1872EAE90", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x72EAE10", Offset = "0x72E9E10", VA = "0x1872EAE10", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class XDJCOMNDAWV : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x72FC710", Offset = "0x72FB710", VA = "0x1872FC710")]
		public XDJCOMNDAWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x72FC5D0", Offset = "0x72FB5D0", VA = "0x1872FC5D0", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class MCLATEBKCLY : XTKYYAYTVNJ, PGQGJSOHBMX
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x72ED570", Offset = "0x72EC570", VA = "0x1872ED570")]
		public MCLATEBKCLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x72ED500", Offset = "0x72EC500", VA = "0x1872ED500")]
		public MCLATEBKCLY(MCLATEBKCLY a, OOJQGESWHUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x72ED300", Offset = "0x72EC300", VA = "0x1872ED300", Slot = "6")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x72ED470", Offset = "0x72EC470", VA = "0x1872ED470", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x72ED3A0", Offset = "0x72EC3A0", VA = "0x1872ED3A0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class SSFBZQNSHDW : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x72FA8A0", Offset = "0x72F98A0", VA = "0x1872FA8A0")]
		public SSFBZQNSHDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x72FA820", Offset = "0x72F9820", VA = "0x1872FA820", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public NZVXSFRUMVE thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x72EB0B0", Offset = "0x72EA0B0", VA = "0x1872EB0B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x72EB020", Offset = "0x72EA020", VA = "0x1872EB020", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x72EB5D0", Offset = "0x72EA5D0", VA = "0x1872EB5D0")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class VKHSEXTNJGD : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x72FBEC0", Offset = "0x72FAEC0", VA = "0x1872FBEC0")]
		public VKHSEXTNJGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x72FBCB0", Offset = "0x72FACB0", VA = "0x1872FBCB0", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x72EB650", Offset = "0x72EA650", VA = "0x1872EB650", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x72EB5F0", Offset = "0x72EA5F0", VA = "0x1872EB5F0", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xF9F6F0", Offset = "0xF9E6F0", VA = "0x180F9F6F0")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class PUKXVUUIBMZ : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x72F5E30", Offset = "0x72F4E30", VA = "0x1872F5E30")]
		public PUKXVUUIBMZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x72F5D50", Offset = "0x72F4D50", VA = "0x1872F5D50", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x72EB7C0", Offset = "0x72EA7C0", VA = "0x1872EB7C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x72EB760", Offset = "0x72EA760", VA = "0x1872EB760", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xF9F6F0", Offset = "0xF9E6F0", VA = "0x180F9F6F0")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class DDTJOMDAQPR : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x72E3600", Offset = "0x72E2600", VA = "0x1872E3600")]
		public DDTJOMDAQPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x72E3520", Offset = "0x72E2520", VA = "0x1872E3520", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x72EB930", Offset = "0x72EA930", VA = "0x1872EB930", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x72EB8D0", Offset = "0x72EA8D0", VA = "0x1872EB8D0", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xF9F6F0", Offset = "0xF9E6F0", VA = "0x180F9F6F0")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class UFZRPTJVRMV : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x72FB2F0", Offset = "0x72FA2F0", VA = "0x1872FB2F0")]
		public UFZRPTJVRMV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x72FB210", Offset = "0x72FA210", VA = "0x1872FB210", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public TVZOCOZDSJH source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public KHR_texture_basisu(TVZOCOZDSJH source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x72EBA40", Offset = "0x72EAA40", VA = "0x1872EBA40", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x72EBAB0", Offset = "0x72EAAB0", VA = "0x1872EBAB0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class GVKTTRTUHJV : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x72E3BE0", Offset = "0x72E2BE0", VA = "0x1872E3BE0")]
		public GVKTTRTUHJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x72E3A80", Offset = "0x72E2A80", VA = "0x1872E3A80", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class NJXLBQDKRSM : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 FPXZBOIVLKU;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 IDQMYVQBFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double YRTIXTFJRMF;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double HBQVQYMSEXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 ZFDNWAZKJUL;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 OPTIUQOJOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? GQLOGVQCUCR;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int CYLJABFSUML;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x72EDF60", Offset = "0x72ECF60", VA = "0x1872EDF60")]
		public NJXLBQDKRSM(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x72ED830", Offset = "0x72EC830", VA = "0x1872ED830", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x72ED910", Offset = "0x72EC910", VA = "0x1872ED910", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class TOHSKDBYZMW : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x72FB150", Offset = "0x72FA150", VA = "0x1872FB150")]
		public TOHSKDBYZMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x72FAE80", Offset = "0x72F9E80", VA = "0x1872FAE80", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class SHWCXMWKGMS : PGQGJSOHBMX
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> WTBPFCUHXFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public SHWCXMWKGMS(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x72FA290", Offset = "0x72F9290", VA = "0x1872FA290", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x72FA300", Offset = "0x72F9300", VA = "0x1872FA300", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x72FA3F0", Offset = "0x72F93F0", VA = "0x1872FA3F0")]
		public List<double> UGHXVGWTWQG(TYZPRJYTRRB a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class MGWCQZMOIEM : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x72ED6C0", Offset = "0x72EC6C0", VA = "0x1872ED6C0")]
		public MGWCQZMOIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x72ED5C0", Offset = "0x72EC5C0", VA = "0x1872ED5C0", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class PUGHACPVTUY : WWKHVVRBHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public JTDIVYFLNOF FYLOPNQZFTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint VWNZGROYVYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType PVEVIVQZWBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool UDSNQEIMFWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint WNETLZWSODY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType GLAENVNETGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> WQEDXZXCHZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> UQUMEUHHHEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public VRSGIZWOILO MZXHFJBFGAL;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x72E6C00", Offset = "0x72E5C00", VA = "0x1872E6C00")]
		public PUGHACPVTUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x72F1810", Offset = "0x72F0810", VA = "0x1872F1810")]
		public static PUGHACPVTUY Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x72F5080", Offset = "0x72F4080", VA = "0x1872F5080", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x72F4980", Offset = "0x72F3980", VA = "0x1872F4980")]
		private unsafe static sbyte TVDCMFIEZPD(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x72F1420", Offset = "0x72F0420", VA = "0x1872F1420")]
		private unsafe static float2 ATEZMKSJHPT(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x72F1450", Offset = "0x72F0450", VA = "0x1872F1450")]
		private unsafe static float3 BGTUBLAIRGA(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x72F2F90", Offset = "0x72F1F90", VA = "0x1872F2F90")]
		private unsafe static float4 JNIVHTTEPBJ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x72F38F0", Offset = "0x72F28F0", VA = "0x1872F38F0")]
		private unsafe static float4x4 QLBHRPGNSXN(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x72F4980", Offset = "0x72F3980", VA = "0x1872F4980")]
		private unsafe static byte UZWEYXUJVDE(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x72F5D20", Offset = "0x72F4D20", VA = "0x1872F5D20")]
		private unsafe static float2 ZYTFTDAQCBS(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x72F56C0", Offset = "0x72F46C0", VA = "0x1872F56C0")]
		private unsafe static float3 ZEOFAGQTMDL(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x72F3690", Offset = "0x72F2690", VA = "0x1872F3690")]
		private unsafe static float4 MROJETXWIZU(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x72F3740", Offset = "0x72F2740", VA = "0x1872F3740")]
		private unsafe static float4x4 NPKVYSFMMYS(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x72F38E0", Offset = "0x72F28E0", VA = "0x1872F38E0")]
		private unsafe static short QHEDVCDEGJZ(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x72F3630", Offset = "0x72F2630", VA = "0x1872F3630")]
		private unsafe static float2 LFWCZSPFNOL(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x72F13D0", Offset = "0x72F03D0", VA = "0x1872F13D0")]
		private unsafe static float3 AQGDYKRLELQ(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x72F1C70", Offset = "0x72F0C70", VA = "0x1872F1C70")]
		private unsafe static float4 EVSYFLALFZT(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x72F2480", Offset = "0x72F1480", VA = "0x1872F2480")]
		private unsafe static float4x4 GOCSNERUYYN(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x72F38E0", Offset = "0x72F28E0", VA = "0x1872F38E0")]
		private unsafe static ushort OIGGKANEBZA(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x72F5980", Offset = "0x72F4980", VA = "0x1872F5980")]
		private unsafe static float2 ZMQJAPTFEOQ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x72F36F0", Offset = "0x72F26F0", VA = "0x1872F36F0")]
		private unsafe static float3 NLNUXLLBMQJ(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x72F1DE0", Offset = "0x72F0DE0", VA = "0x1872F1DE0")]
		private unsafe static float4x4 FLFJGJEPOOW(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x72F5660", Offset = "0x72F4660", VA = "0x1872F5660")]
		private unsafe static float4 YYCBPPBOJQK(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x72F4800", Offset = "0x72F3800", VA = "0x1872F4800")]
		private unsafe static uint TEENXZYXEVN(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x72F38E0", Offset = "0x72F28E0", VA = "0x1872F38E0")]
		private unsafe static ushort YKZHYROLZNI(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x72F4550", Offset = "0x72F3550", VA = "0x1872F4550")]
		private unsafe static float SBBYJZLGFBN(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x72F4F30", Offset = "0x72F3F30", VA = "0x1872F4F30")]
		private unsafe static float2 WPBYHFROYYD(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x72F2FF0", Offset = "0x72F1FF0", VA = "0x1872F2FF0")]
		private unsafe static float3 KKYKPUFPJMS(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x72F17E0", Offset = "0x72F07E0", VA = "0x1872F17E0")]
		private unsafe static float4 DUCWQNONVUV(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x72F3660", Offset = "0x72F2660", VA = "0x1872F3660")]
		private unsafe static float4x4 MJHXVOXOGCR(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x72F17E0", Offset = "0x72F07E0", VA = "0x1872F17E0")]
		private unsafe static float4 SLNGCAIAZAI(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x72F47D0", Offset = "0x72F37D0", VA = "0x1872F47D0")]
		private unsafe static float4 SLNGCAIAZAI(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x72F15B0", Offset = "0x72F05B0", VA = "0x1872F15B0")]
		public static float3[] BPSJAPTZCIV(PUGHACPVTUY a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x72F4990", Offset = "0x72F3990", VA = "0x1872F4990")]
		public static float3[] UUAMEMYPCBL(PUGHACPVTUY a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x72F1FD0", Offset = "0x72F0FD0", VA = "0x1872F1FD0")]
		public static uint[] GABTLYKTFSM(PUGHACPVTUY a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x72F3C00", Offset = "0x72F2C00", VA = "0x1872F3C00")]
		internal static void RMXUSFVDCGF(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x72F28D0", Offset = "0x72F18D0", VA = "0x1872F28D0")]
		public uint[] HXXXAVTKQEI(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x72F5710", Offset = "0x72F4710", VA = "0x1872F5710")]
		public float[] ZFMMDUDIVOU(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x72F3010", Offset = "0x72F2010", VA = "0x1872F3010")]
		public float2[] KQSTYLDJMCQ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x72F2620", Offset = "0x72F1620", VA = "0x1872F2620")]
		public float2[] HWCPKSACWCW(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x72F3D20", Offset = "0x72F2D20", VA = "0x1872F3D20")]
		public float3[] RWRSJFKIMDT(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x72F2B20", Offset = "0x72F1B20", VA = "0x1872F2B20")]
		public float3[] IKPKDAPXMSF(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x72F4560", Offset = "0x72F3560", VA = "0x1872F4560")]
		public float4[] SJBOIKJFKNA(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x72F59B0", Offset = "0x72F49B0", VA = "0x1872F59B0")]
		public float4[] ZVBUTTDTLEG(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x72F32A0", Offset = "0x72F22A0", VA = "0x1872F32A0")]
		public float4[] KTAQXFBSVTB(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x72F14A0", Offset = "0x72F04A0", VA = "0x1872F14A0")]
		public float3[] BMWFBJKNSCS(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x72F1CD0", Offset = "0x72F0CD0", VA = "0x1872F1CD0")]
		public float3[] FDOURCKMVKJ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x72F4CA0", Offset = "0x72F3CA0", VA = "0x1872F4CA0")]
		public float4[] VHTAGVZWYUV(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x72F1F80", Offset = "0x72F0F80", VA = "0x1872F1F80")]
		public uint[] FTXFESSPMOQ(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x72F3FA0", Offset = "0x72F2FA0", VA = "0x1872F3FA0")]
		public float4x4[] RXCDDPSRROD(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x72F2140", Offset = "0x72F1140", VA = "0x1872F2140")]
		private unsafe static float4 GJCCMEFMDRV(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x72F2300", Offset = "0x72F1300", VA = "0x1872F2300")]
		private unsafe static float4 GJCCMEFMDRV(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x72F4810", Offset = "0x72F3810", VA = "0x1872F4810")]
		private unsafe static float4x4 TQCLGYIBTHK(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x72F4D70", Offset = "0x72F3D70", VA = "0x1872F4D70")]
		private unsafe static float4 VMNKNNSXSKM(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x72F3A90", Offset = "0x72F2A90", VA = "0x1872F3A90")]
		private unsafe static float3 RBFRXFRSOKD(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x72F4F50", Offset = "0x72F3F50", VA = "0x1872F4F50")]
		private unsafe static float2 XQGGKBBIVZE(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x72F2E70", Offset = "0x72F1E70", VA = "0x1872F2E70")]
		private unsafe static uint IQXFOYIOVXR(void* a, uint b, GLTFComponentType c)
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
	public static class DONFLPCXSCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x72FE290", Offset = "0x72FD290", VA = "0x1872FE290")]
		public static int VSSIVVVOZOJ(this GLTFAccessorAttributeType a)
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
	public class VRSGIZWOILO : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int WNETLZWSODY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public DWWQEYCSXSZ TXADXCVTNUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public XLMTUOWDJZM BJREHXOKMEF;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x730E720", Offset = "0x730D720", VA = "0x18730E720")]
		public VRSGIZWOILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x730E320", Offset = "0x730D320", VA = "0x18730E320")]
		public static VRSGIZWOILO Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x730E5F0", Offset = "0x730D5F0", VA = "0x18730E5F0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class DWWQEYCSXSZ : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public JTDIVYFLNOF FYLOPNQZFTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int VWNZGROYVYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType PVEVIVQZWBI;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x72FE710", Offset = "0x72FD710", VA = "0x1872FE710")]
		public DWWQEYCSXSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x72FE2F0", Offset = "0x72FD2F0", VA = "0x1872FE2F0")]
		public static DWWQEYCSXSZ Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x72FE5D0", Offset = "0x72FD5D0", VA = "0x1872FE5D0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class XLMTUOWDJZM : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public JTDIVYFLNOF FYLOPNQZFTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int VWNZGROYVYG;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x730FB60", Offset = "0x730EB60", VA = "0x18730FB60")]
		public XLMTUOWDJZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x730F7E0", Offset = "0x730E7E0", VA = "0x18730F7E0")]
		public static XLMTUOWDJZM Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x730FA60", Offset = "0x730EA60", VA = "0x18730FA60", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class LLVOAWIFWWC : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public MPOGOWGASUI MSYAPBTOWJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public QHMEKTXIFJB WBIBLXZEWPM;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x73015F0", Offset = "0x73005F0", VA = "0x1873015F0")]
		public LLVOAWIFWWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7301300", Offset = "0x7300300", VA = "0x187301300")]
		public static LLVOAWIFWWC Deserialize(OOJQGESWHUS root, JsonReader reader, LLMDCQSRDJC anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x73014F0", Offset = "0x73004F0", VA = "0x1873014F0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class QHMEKTXIFJB : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public WNSFDIRCAVY TYZPRJYTRRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string WEUPJCXUSLK;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x73076C0", Offset = "0x73066C0", VA = "0x1873076C0")]
		public static QHMEKTXIFJB Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7307A40", Offset = "0x7306A40", VA = "0x187307A40")]
		public QHMEKTXIFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7307920", Offset = "0x7306920", VA = "0x187307920", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
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
	public class ZWCVOXHWWDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(ZWCVOXHWWDO data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] FBULLDSYEUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type SZUWZMUYLTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] BGOKBPUJVJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion TBDXEDUQUIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string SQLUGYHILCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string YLLUKVCBXSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public OBAKQCLHDHI UVTHCKRMCMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string TZQJMEFXUBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string XIPOAUOBCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public OBAKQCLHDHI KURJTCLHQNB;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7312AE0", Offset = "0x7311AE0", VA = "0x187312AE0")]
		public ZWCVOXHWWDO()
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
	public class HPGHXVCHCQN : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public EYAPWMIFCXD HNEJXIHSGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType IBPQFQUQOUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public EYAPWMIFCXD PSOORPFQTIO;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7300100", Offset = "0x72FF100", VA = "0x187300100")]
		public HPGHXVCHCQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x72FFD70", Offset = "0x72FED70", VA = "0x1872FFD70")]
		public static HPGHXVCHCQN Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x72FFF90", Offset = "0x72FEF90", VA = "0x1872FFF90", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class YWWHRXDKGVH : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string CXJLSWSXUTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string WVDGCSBYHSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string JFMIJAIUOSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string XPGHGOFDQYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> QDVEUHWUCYD;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x73123F0", Offset = "0x73113F0", VA = "0x1873123F0")]
		public YWWHRXDKGVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7311900", Offset = "0x7310900", VA = "0x187311900")]
		public static YWWHRXDKGVH Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7311FD0", Offset = "0x7310FD0", VA = "0x187311FD0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7311C20", Offset = "0x7310C20", VA = "0x187311C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7311C30", Offset = "0x7310C30", VA = "0x187311C30")]
		public string XFSPYUTNRHJ(bool a)
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
	public class FYLOPNQZFTG : WWKHVVRBHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public ZTPAXRCUVQE ZTFHEQUXQOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint VWNZGROYVYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint ABDTYRADZTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint FEHHAKJJOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget WBIBLXZEWPM;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x72FDA00", Offset = "0x72FCA00", VA = "0x1872FDA00")]
		public FYLOPNQZFTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x72FF060", Offset = "0x72FE060", VA = "0x1872FF060")]
		public static FYLOPNQZFTG Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x72FF310", Offset = "0x72FE310", VA = "0x1872FF310", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class FBMJDMRSOGS : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double FWLMTYRPSHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double KVVBWWWRDSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double NHWZCNVUOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double QITLRFWIMNH;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x72FF010", Offset = "0x72FE010", VA = "0x1872FF010")]
		public FBMJDMRSOGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x72FEB20", Offset = "0x72FDB20", VA = "0x1872FEB20")]
		public static FBMJDMRSOGS Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x72FEEA0", Offset = "0x72FDEA0", VA = "0x1872FEEA0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class OVQAVIVSFEG : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double NFJAOSTQTVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double UUTJWXFCXNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double NHWZCNVUOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double QITLRFWIMNH;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7306CC0", Offset = "0x7305CC0", VA = "0x187306CC0")]
		public OVQAVIVSFEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x73067C0", Offset = "0x73057C0", VA = "0x1873067C0")]
		public static OVQAVIVSFEG Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7306B30", Offset = "0x7305B30", VA = "0x187306B30", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class LLMDCQSRDJC : WWKHVVRBHHC
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class MJLEUFQBZLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public OOJQGESWHUS EQMHNAKVRHZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader XQUHCHGKMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public LLMDCQSRDJC VTWUBIWDXBR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<LLVOAWIFWWC> VCDQVGJNMTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<HPGHXVCHCQN> VCIXSNDKWEJ;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public MJLEUFQBZLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x7301640", Offset = "0x7300640", VA = "0x187301640")]
			internal LLVOAWIFWWC NDWSYKVTFHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x7301660", Offset = "0x7300660", VA = "0x187301660")]
			internal HPGHXVCHCQN NEBZVRPQOSN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<LLVOAWIFWWC> NQPSGTNEDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<HPGHXVCHCQN> UXUAQHVVPTQ;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7300AB0", Offset = "0x72FFAB0", VA = "0x187300AB0")]
		public static LLMDCQSRDJC Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7301210", Offset = "0x7300210", VA = "0x187301210")]
		public LLMDCQSRDJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7300E70", Offset = "0x72FFE70", VA = "0x187300E70", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class DNLHDCBQZPC : WWKHVVRBHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string KMEOQIXCQGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint ABDTYRADZTL;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x72FDA00", Offset = "0x72FCA00", VA = "0x1872FDA00")]
		public DNLHDCBQZPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x72FDF70", Offset = "0x72FCF70", VA = "0x1872FDF70")]
		public static DNLHDCBQZPC Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x72FE140", Offset = "0x72FD140", VA = "0x1872FE140", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class UFJCNZXBNFD : WWKHVVRBHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public FBMJDMRSOGS SRABRNEOQQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public OVQAVIVSFEG QBMFFRWTXNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType GLAENVNETGX;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x72FDA00", Offset = "0x72FCA00", VA = "0x1872FDA00")]
		public UFJCNZXBNFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x730D8F0", Offset = "0x730C8F0", VA = "0x18730D8F0")]
		public static UFJCNZXBNFD Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x730DAC0", Offset = "0x730CAC0", VA = "0x18730DAC0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
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
	public class WWKHVVRBHHC : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string QQXGIPEDADO;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x72FDA00", Offset = "0x72FCA00", VA = "0x1872FDA00")]
		public WWKHVVRBHHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x730F760", Offset = "0x730E760", VA = "0x18730F760")]
		public WWKHVVRBHHC(WWKHVVRBHHC a, OOJQGESWHUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x730F5E0", Offset = "0x730E5E0", VA = "0x18730F5E0")]
		public new void ASHESFAGAOG(OOJQGESWHUS a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x730F6D0", Offset = "0x730E6D0", VA = "0x18730F6D0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class XLBMFMPGHOM<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int TXKKVYGLDVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public OOJQGESWHUS SYFXSLEPKPV;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected XLBMFMPGHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3E973B0", Offset = "0x3E963B0", VA = "0x183E973B0")]
		public XLBMFMPGHOM(XLBMFMPGHOM<a> a, OOJQGESWHUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E97380", Offset = "0x3E96380", VA = "0x183E97380")]
		public void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class EYAPWMIFCXD : XLBMFMPGHOM<PUGHACPVTUY>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override PUGHACPVTUY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x72FEAC0", Offset = "0x72FDAC0", VA = "0x1872FEAC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x72FEA20", Offset = "0x72FDA20", VA = "0x1872FEA20")]
		public EYAPWMIFCXD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x72FEA60", Offset = "0x72FDA60", VA = "0x1872FEA60")]
		public EYAPWMIFCXD(EYAPWMIFCXD a, OOJQGESWHUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x72FE940", Offset = "0x72FD940", VA = "0x1872FE940")]
		public static EYAPWMIFCXD Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class ZTPAXRCUVQE : XLBMFMPGHOM<DNLHDCBQZPC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override DNLHDCBQZPC Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x7312A80", Offset = "0x7311A80", VA = "0x187312A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7312A40", Offset = "0x7311A40", VA = "0x187312A40")]
		public ZTPAXRCUVQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7312960", Offset = "0x7311960", VA = "0x187312960")]
		public static ZTPAXRCUVQE Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class JTDIVYFLNOF : XLBMFMPGHOM<FYLOPNQZFTG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override FYLOPNQZFTG Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x7300460", Offset = "0x72FF460", VA = "0x187300460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7300420", Offset = "0x72FF420", VA = "0x187300420")]
		public JTDIVYFLNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7300340", Offset = "0x72FF340", VA = "0x187300340")]
		public static JTDIVYFLNOF Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class IFSONZVQOMF : XLBMFMPGHOM<UFJCNZXBNFD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override UFJCNZXBNFD Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x7300270", Offset = "0x72FF270", VA = "0x187300270", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7300230", Offset = "0x72FF230", VA = "0x187300230")]
		public IFSONZVQOMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7300150", Offset = "0x72FF150", VA = "0x187300150")]
		public static IFSONZVQOMF Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class TVZOCOZDSJH : XLBMFMPGHOM<OKLSXQTOJZJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override OKLSXQTOJZJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x730BD30", Offset = "0x730AD30", VA = "0x18730BD30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x730BCF0", Offset = "0x730ACF0", VA = "0x18730BCF0")]
		public TVZOCOZDSJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x730BC10", Offset = "0x730AC10", VA = "0x18730BC10")]
		public static TVZOCOZDSJH Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class GRCFDQSOVFN : XLBMFMPGHOM<MMVBRURQXJR>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override MMVBRURQXJR Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x72FFD10", Offset = "0x72FED10", VA = "0x1872FFD10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x72FFCD0", Offset = "0x72FECD0", VA = "0x1872FFCD0")]
		public GRCFDQSOVFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x72FFC70", Offset = "0x72FEC70", VA = "0x1872FFC70")]
		public GRCFDQSOVFN(GRCFDQSOVFN a, OOJQGESWHUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x72FFB90", Offset = "0x72FEB90", VA = "0x1872FFB90")]
		public static GRCFDQSOVFN Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class VMVYURCPWQX : XLBMFMPGHOM<RUVJMDAMVNV>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override RUVJMDAMVNV Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x730E2B0", Offset = "0x730D2B0", VA = "0x18730E2B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x730E270", Offset = "0x730D270", VA = "0x18730E270")]
		public VMVYURCPWQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x730E190", Offset = "0x730D190", VA = "0x18730E190")]
		public static VMVYURCPWQX Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class WNSFDIRCAVY : XLBMFMPGHOM<TYZPRJYTRRB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override TYZPRJYTRRB Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x730F580", Offset = "0x730E580", VA = "0x18730F580", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x730F540", Offset = "0x730E540", VA = "0x18730F540")]
		public WNSFDIRCAVY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x730F1F0", Offset = "0x730E1F0", VA = "0x18730F1F0")]
		public static WNSFDIRCAVY Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x730F2D0", Offset = "0x730E2D0", VA = "0x18730F2D0")]
		public static List<WNSFDIRCAVY> TCWMCMYZZIH(OOJQGESWHUS a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class ZRSUAESCANO : XLBMFMPGHOM<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x7312900", Offset = "0x7311900", VA = "0x187312900", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x73128C0", Offset = "0x73118C0", VA = "0x1873128C0")]
		public ZRSUAESCANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x73127E0", Offset = "0x73117E0", VA = "0x1873127E0")]
		public static ZRSUAESCANO Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class MPOGOWGASUI : XLBMFMPGHOM<HPGHXVCHCQN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public LLMDCQSRDJC LLMDCQSRDJC;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override HPGHXVCHCQN Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x7302190", Offset = "0x7301190", VA = "0x187302190", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7302150", Offset = "0x7301150", VA = "0x187302150")]
		public MPOGOWGASUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7302050", Offset = "0x7301050", VA = "0x187302050")]
		public static MPOGOWGASUI Deserialize(OOJQGESWHUS root, LLMDCQSRDJC anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class WACIDIWGZYM : XLBMFMPGHOM<BQTWPUJOASO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override BQTWPUJOASO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x730E890", Offset = "0x730D890", VA = "0x18730E890", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x730E850", Offset = "0x730D850", VA = "0x18730E850")]
		public WACIDIWGZYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x730E770", Offset = "0x730D770", VA = "0x18730E770")]
		public static WACIDIWGZYM Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class ADAXMPZRTHJ : XLBMFMPGHOM<POGQCKKOZCW>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override POGQCKKOZCW Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x72FCE50", Offset = "0x72FBE50", VA = "0x1872FCE50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x72FCE10", Offset = "0x72FBE10", VA = "0x1872FCE10")]
		public ADAXMPZRTHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x72FCD30", Offset = "0x72FBD30", VA = "0x1872FCD30")]
		public static ADAXMPZRTHJ Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class EVJXWKDQYSH : XLBMFMPGHOM<ZHIOVMWNSWZ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override ZHIOVMWNSWZ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x72FE8E0", Offset = "0x72FD8E0", VA = "0x1872FE8E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x72FE840", Offset = "0x72FD840", VA = "0x1872FE840")]
		public EVJXWKDQYSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x72FE880", Offset = "0x72FD880", VA = "0x1872FE880")]
		public EVJXWKDQYSH(EVJXWKDQYSH a, OOJQGESWHUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x72FE760", Offset = "0x72FD760", VA = "0x1872FE760")]
		public static EVJXWKDQYSH Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class TABZZXKCBRW : XLBMFMPGHOM<PWEFOYITPWG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override PWEFOYITPWG Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x730B3D0", Offset = "0x730A3D0", VA = "0x18730B3D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x730B390", Offset = "0x730A390", VA = "0x18730B390")]
		public TABZZXKCBRW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class OKLSXQTOJZJ : WWKHVVRBHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string KMEOQIXCQGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string USPIPPSTZVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public JTDIVYFLNOF FYLOPNQZFTG;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x72FDA00", Offset = "0x72FCA00", VA = "0x1872FDA00")]
		public OKLSXQTOJZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7302790", Offset = "0x7301790", VA = "0x187302790")]
		public static OKLSXQTOJZJ Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x73029D0", Offset = "0x73019D0", VA = "0x1873029D0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class MMVBRURQXJR : WWKHVVRBHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public GEQAAHXQDBE GEQAAHXQDBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public TBTIEDPZIQD SNWZBTMPBFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public KQVKSVQGYKL YXRYHRPJDAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public ADWVKPNGKUX VDOCFZXRPOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public NZVXSFRUMVE OSFMEOMTFZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color QEPGZRWPHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode RTHDWJIUIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double NFVVCLJIPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool RNZHJXPGCOD;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7301FE0", Offset = "0x7300FE0", VA = "0x187301FE0")]
		public MMVBRURQXJR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7301670", Offset = "0x7300670", VA = "0x187301670")]
		public static MMVBRURQXJR Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7301B80", Offset = "0x7300B80", VA = "0x187301B80", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
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
	public class RUVJMDAMVNV : WWKHVVRBHHC
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class ZOAXUNZKSXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public OOJQGESWHUS EQMHNAKVRHZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader XQUHCHGKMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<QSROSLSABBZ> VCDQVGJNMTA;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ZOAXUNZKSXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x73127D0", Offset = "0x73117D0", VA = "0x1873127D0")]
			internal QSROSLSABBZ NDWSYKVTFHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<QSROSLSABBZ> NBXSPGTZVFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> VGJZBESSKNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> XZPHSFUGQMO;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x72FDA00", Offset = "0x72FCA00", VA = "0x1872FDA00")]
		public RUVJMDAMVNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7309FA0", Offset = "0x7308FA0", VA = "0x187309FA0")]
		public static RUVJMDAMVNV Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x730A360", Offset = "0x7309360", VA = "0x18730A360", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class XTKYYAYTVNJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, DRQVDUGDAHA> RQRVVNFJESS;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static IROAOPFQEYV JIYAWECEIRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, PGQGJSOHBMX> EGJERDMFRBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken VKEADFYSUQY;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x73106A0", Offset = "0x730F6A0", VA = "0x1873106A0")]
		public static DRQVDUGDAHA LUGFQYDASUJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x730FF20", Offset = "0x730EF20", VA = "0x18730FF20")]
		public static PGQGJSOHBMX EZRVAGFLAVX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public XTKYYAYTVNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7311610", Offset = "0x7310610", VA = "0x187311610")]
		public XTKYYAYTVNJ(XTKYYAYTVNJ a, [Optional] OOJQGESWHUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x730FBB0", Offset = "0x730EBB0", VA = "0x18730FBB0")]
		public void ASHESFAGAOG(OOJQGESWHUS a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7310920", Offset = "0x730F920", VA = "0x187310920")]
		public void WSWLTURVYET(string a, PGQGJSOHBMX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7310830", Offset = "0x730F830", VA = "0x187310830")]
		private void RQSYUZSNYQN(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x73105E0", Offset = "0x730F5E0", VA = "0x1873105E0")]
		private void JLBYQMPVOBB(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x730FE60", Offset = "0x730EE60", VA = "0x18730FE60")]
		private void COHABRTDPCZ(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7310010", Offset = "0x730F010", VA = "0x187310010")]
		internal static Dictionary<string, PGQGJSOHBMX> GDCRCSJJGGM(OOJQGESWHUS a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7310A70", Offset = "0x730FA70", VA = "0x187310A70", Slot = "4")]
		public virtual void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class OOJQGESWHUS : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class UGWSJTRGBHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public OOJQGESWHUS EQMHNAKVRHZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader TDRMLOUSYSS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<PUGHACPVTUY> VCDQVGJNMTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<LLMDCQSRDJC> VCIXSNDKWEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<DNLHDCBQZPC> VBTDASVSTWI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<FYLOPNQZFTG> VBYJXZPQDHR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<UFJCNZXBNFD> VCYSKHLCYMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<OKLSXQTOJZJ> VDDZHOFAHXT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<MMVBRURQXJR> VCOEPTXIFPS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<RUVJMDAMVNV> VCTLNARFPBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<TYZPRJYTRRB> VDTTZIMSKFU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> VDZAWPGPTRD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<BQTWPUJOASO> OUHHLPNCWNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<POGQCKKOZCW> OUCAOITFNCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<ZHIOVMWNSWZ> OURVGDAXPKJ;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public UGWSJTRGBHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x730DCB0", Offset = "0x730CCB0", VA = "0x18730DCB0")]
			internal PUGHACPVTUY NDWSYKVTFHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x730DCC0", Offset = "0x730CCC0", VA = "0x18730DCC0")]
			internal LLMDCQSRDJC NEBZVRPQOSN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x730DC90", Offset = "0x730CC90", VA = "0x18730DC90")]
			internal DNLHDCBQZPC NDMFDXHYMKM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x730DCA0", Offset = "0x730CCA0", VA = "0x18730DCA0")]
			internal FYLOPNQZFTG NDRMBEBVVVV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x730DCF0", Offset = "0x730CCF0", VA = "0x18730DCF0")]
			internal UFJCNZXBNFD NERUNLXIRAO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x730DD00", Offset = "0x730CD00", VA = "0x18730DD00")]
			internal OKLSXQTOJZJ NEXBKSRGALX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x730DCD0", Offset = "0x730CCD0", VA = "0x18730DCD0")]
			internal MMVBRURQXJR NEHGSYJNYDW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x730DCE0", Offset = "0x730CCE0", VA = "0x18730DCE0")]
			internal RUVJMDAMVNV NEMNQFDLHPF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x730DD10", Offset = "0x730CD10", VA = "0x18730DD10")]
			internal TYZPRJYTRRB NFMWCMYYCTY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x730DD20", Offset = "0x730CD20", VA = "0x18730DD20")]
			internal Sampler NFSCZTSVMFH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x730DD40", Offset = "0x730CD40", VA = "0x18730DD40")]
			internal BQTWPUJOASO WFVECREDFEH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x730DD30", Offset = "0x730CD30", VA = "0x18730DD30")]
			internal POGQCKKOZCW WFPXFKKFVSY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x730DEC0", Offset = "0x730CEC0", VA = "0x18730DEC0")]
			internal ZHIOVMWNSWZ WGFRXERXYAZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> FRZDXAQFALG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> SVVAXEKJMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<PUGHACPVTUY> GXEHAMSSGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<LLMDCQSRDJC> USIJTGBSHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public YWWHRXDKGVH YWWHRXDKGVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<DNLHDCBQZPC> KTBMONUXPKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<FYLOPNQZFTG> ZLTXORTCOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<UFJCNZXBNFD> PODDFCKGISN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<OKLSXQTOJZJ> QQRQHJZJONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<MMVBRURQXJR> GQBZJNXEOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<RUVJMDAMVNV> GNAZMASTCCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<TYZPRJYTRRB> UCSOJHWAODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> UXUAQHVVPTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public WACIDIWGZYM NNZGYDFWLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<BQTWPUJOASO> DHVBATTDBVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<POGQCKKOZCW> WYWZWAAEPRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<ZHIOVMWNSWZ> HCQHJWILLTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<PWEFOYITPWG> VPMLUTADBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool ZZPJSFNKEJU;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7305630", Offset = "0x7304630", VA = "0x187305630")]
		public OOJQGESWHUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x73039F0", Offset = "0x73029F0", VA = "0x1873039F0")]
		public BQTWPUJOASO SCYQPZKDYRQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7302BA0", Offset = "0x7301BA0", VA = "0x187302BA0")]
		public static OOJQGESWHUS Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7303A90", Offset = "0x7302A90", VA = "0x187303A90")]
		public void XRHSQBYDVHR(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class BQTWPUJOASO : WWKHVVRBHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<WNSFDIRCAVY> UCSOJHWAODG;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x72FDA00", Offset = "0x72FCA00", VA = "0x1872FDA00")]
		public BQTWPUJOASO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x72FD610", Offset = "0x72FC610", VA = "0x1872FD610")]
		public static BQTWPUJOASO Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x72FD790", Offset = "0x72FC790", VA = "0x1872FD790", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class ZHIOVMWNSWZ : WWKHVVRBHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ZRSUAESCANO MSYAPBTOWJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TVZOCOZDSJH LJEYUVVYGPU;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x72FDA00", Offset = "0x72FCA00", VA = "0x1872FDA00")]
		public ZHIOVMWNSWZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7312490", Offset = "0x7311490", VA = "0x187312490")]
		public static ZHIOVMWNSWZ Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7312660", Offset = "0x7311660", VA = "0x187312660", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class VPHNDFRQPAS : PWEFOYITPWG
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x72FDA00", Offset = "0x72FCA00", VA = "0x1872FDA00")]
		public VPHNDFRQPAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x730E310", Offset = "0x730D310", VA = "0x18730E310", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class PWEFOYITPWG : WWKHVVRBHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string CJDQDEKJGVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color FOCJUGHWQFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string HIEWDZSZCDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float UUSYYHMLGWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float WXEXAEXUAGA;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x72FDA00", Offset = "0x72FCA00", VA = "0x1872FDA00")]
		public PWEFOYITPWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7307440", Offset = "0x7306440", VA = "0x187307440", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class WOAQUMITHUM : PWEFOYITPWG
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x72FDA00", Offset = "0x72FCA00", VA = "0x1872FDA00")]
		public WOAQUMITHUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x730E310", Offset = "0x730D310", VA = "0x18730E310", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class AGEVYIRRJZA : PWEFOYITPWG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float IGPAHTRTMYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float EAYOBTMUAYM;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x72FD5C0", Offset = "0x72FC5C0", VA = "0x1872FD5C0")]
		public AGEVYIRRJZA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x72FD2C0", Offset = "0x72FC2C0", VA = "0x1872FD2C0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface AJICKOZGYZH
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KCHLSLEZFDE(OOJQGESWHUS a, CUDWNAWDSRZ b, [Out] ZWCVOXHWWDO c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface PGQGJSOHBMX
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PGQGJSOHBMX Clone(OOJQGESWHUS root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class DRQVDUGDAHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string MYZBLEIZVKD;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected DRQVDUGDAHA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class MQOWCRNKBBP : PGQGJSOHBMX
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty AIWIZGVDFEE
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x73021F0", Offset = "0x73011F0", VA = "0x1873021F0", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public MQOWCRNKBBP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class IROAOPFQEYV : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x73002D0", Offset = "0x72FF2D0", VA = "0x1873002D0", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public IROAOPFQEYV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class TBTIEDPZIQD : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color EUYNIJADFEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public NZVXSFRUMVE LRBHWJWTGWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color LYQZFKMXHGO;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x730B930", Offset = "0x730A930", VA = "0x18730B930")]
		public TBTIEDPZIQD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x730B430", Offset = "0x730A430", VA = "0x18730B430")]
		public static TBTIEDPZIQD Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x730B6D0", Offset = "0x730A6D0", VA = "0x18730B6D0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class KQVKSVQGYKL : NZVXSFRUMVE
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string MZXXAJNAUJN = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double ZFDNWAZKJUL;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x72FD260", Offset = "0x72FC260", VA = "0x1872FD260")]
		public KQVKSVQGYKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7300700", Offset = "0x72FF700", VA = "0x187300700")]
		public new static KQVKSVQGYKL Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x73009F0", Offset = "0x72FF9F0", VA = "0x1873009F0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ADWVKPNGKUX : NZVXSFRUMVE
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string TEHMEKFCKMC = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double CIBECGVYGVY;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x72FD260", Offset = "0x72FC260", VA = "0x1872FD260")]
		public ADWVKPNGKUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x72FCEB0", Offset = "0x72FBEB0", VA = "0x1872FCEB0")]
		public new static ADWVKPNGKUX Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x72FD1A0", Offset = "0x72FC1A0", VA = "0x1872FD1A0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class GEQAAHXQDBE : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color PCNNOMHSBSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public NZVXSFRUMVE NWFOKXRXPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double USIVZCLJBMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double JVSZOZBQZHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public NZVXSFRUMVE RGEVMBHUDFZ;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x72FFB20", Offset = "0x72FEB20", VA = "0x1872FFB20")]
		public GEQAAHXQDBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x72FF520", Offset = "0x72FE520", VA = "0x1872FF520")]
		public static GEQAAHXQDBE Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x72FF890", Offset = "0x72FE890", VA = "0x1872FF890", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class QSROSLSABBZ : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class OVBGWDFORDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader XQUHCHGKMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public OOJQGESWHUS EQMHNAKVRHZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<EYAPWMIFCXD> VCDQVGJNMTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<EYAPWMIFCXD> VBTDASVSTWI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, EYAPWMIFCXD>> VCIXSNDKWEJ;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public OVBGWDFORDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x7306640", Offset = "0x7305640", VA = "0x187306640")]
			internal EYAPWMIFCXD NDWSYKVTFHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x7306710", Offset = "0x7305710", VA = "0x187306710")]
			internal Dictionary<string, EYAPWMIFCXD> NEBZVRPQOSN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x7306570", Offset = "0x7305570", VA = "0x187306570")]
			internal EYAPWMIFCXD NDMFDXHYMKM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, EYAPWMIFCXD> VRWLURKAHZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public EYAPWMIFCXD TXADXCVTNUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public GRCFDQSOVFN XAQMOSFDGUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode ZIVQKMULLMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, EYAPWMIFCXD>> NCXNTMYUOJJ;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7308D90", Offset = "0x7307D90", VA = "0x187308D90")]
		public QSROSLSABBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7308E30", Offset = "0x7307E30", VA = "0x187308E30")]
		public QSROSLSABBZ(QSROSLSABBZ a, OOJQGESWHUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7308160", Offset = "0x7307160", VA = "0x187308160")]
		public static int[] GTZUDZWJEUV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7307A90", Offset = "0x7306A90", VA = "0x187307A90")]
		public static int[] CKMUMJBVVNN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7308290", Offset = "0x7307290", VA = "0x187308290")]
		public static int[] JWXODGNWWMJ(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7308450", Offset = "0x7307450", VA = "0x187308450")]
		public static int[] NHFKKVYVEKL(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7307BF0", Offset = "0x7306BF0", VA = "0x187307BF0")]
		public static int[] COZKZPQGJJI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x73080F0", Offset = "0x73070F0", VA = "0x1873080F0")]
		public static int[] FZVJHDMBSXJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x73086A0", Offset = "0x73076A0", VA = "0x1873086A0")]
		public static int[] NIHKPTBSFKD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7308730", Offset = "0x7307730", VA = "0x187308730")]
		public static int[] OPLZOCLLWMM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7308200", Offset = "0x7307200", VA = "0x187308200")]
		public static int[] IFESGENCYYI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7307CA0", Offset = "0x7306CA0", VA = "0x187307CA0")]
		public static QSROSLSABBZ Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x73087A0", Offset = "0x73077A0", VA = "0x1873087A0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class VAPQMZKUQOS
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] GQLOGVQCUCR;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] RQAVQDJHTIC;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] APUOQMFAWPF;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] WOMVFBQAIVX;
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
	public class TYZPRJYTRRB : WWKHVVRBHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool RXLGMNNDDIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public IFSONZVQOMF PZJOPZQUQUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<WNSFDIRCAVY> JZQCABQWCXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public ADAXMPZRTHJ POGQCKKOZCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public BJDMLQQTHFA KWNVFKPEXHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public VMVYURCPWQX QSWLRJOTYLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion YRTIXTFJRMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 ZFDNWAZKJUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 HYOWJSEUAXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> VGJZBESSKNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public TABZZXKCBRW IBWCYAUZZIV;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x730D2B0", Offset = "0x730C2B0", VA = "0x18730D2B0")]
		public TYZPRJYTRRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x730BD90", Offset = "0x730AD90", VA = "0x18730BD90")]
		public static TYZPRJYTRRB Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x730C6C0", Offset = "0x730B6C0", VA = "0x18730C6C0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : WWKHVVRBHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode LVJACDBUBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode TEHPFJIGSVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode TKOWLFZOFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode TKJPNZFQVUF;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x730B320", Offset = "0x730A320", VA = "0x18730B320")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x730AE60", Offset = "0x7309E60", VA = "0x18730AE60")]
		public static Sampler Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x730B130", Offset = "0x730A130", VA = "0x18730B130", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
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
	public class POGQCKKOZCW : WWKHVVRBHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public EYAPWMIFCXD YJCPXWJKGRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public WNSFDIRCAVY YPQGJJGCEMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<WNSFDIRCAVY> XJKNEOUKNSG;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7307390", Offset = "0x7306390", VA = "0x187307390")]
		public POGQCKKOZCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7306D20", Offset = "0x7305D20", VA = "0x187306D20")]
		public static POGQCKKOZCW Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7307080", Offset = "0x7306080", VA = "0x187307080", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class NZVXSFRUMVE : XTKYYAYTVNJ
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string FKOGTUCEBKV = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string QFYBWFXXDVP = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public EVJXWKDQYSH RFMSXMRTOHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int GQLOGVQCUCR;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7302650", Offset = "0x7301650", VA = "0x187302650")]
		public NZVXSFRUMVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x73026A0", Offset = "0x73016A0", VA = "0x1873026A0")]
		public NZVXSFRUMVE(NZVXSFRUMVE a, OOJQGESWHUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x73022A0", Offset = "0x73012A0", VA = "0x1873022A0")]
		public static NZVXSFRUMVE Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x73025F0", Offset = "0x73015F0", VA = "0x1873025F0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7302520", Offset = "0x7301520", VA = "0x187302520")]
		public void MDEJVFJFOPU(JsonWriter a)
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
	public class CGAKWGZQJFZ
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double KIVHYYCWYJN;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double ASSGAYTSOSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double SEFBXAYUFSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double WQRFNQPMBIY;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x72FDEF0", Offset = "0x72FCEF0", VA = "0x1872FDEF0")]
		public CGAKWGZQJFZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x72FDA50", Offset = "0x72FCA50", VA = "0x1872FDA50")]
		public static CGAKWGZQJFZ Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x72FDC90", Offset = "0x72FCC90", VA = "0x1872FDC90")]
		public void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class RUFSDYIHMHB : WWKHVVRBHHC
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color DHNOLGQMBKE;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double BWLYXEPJOMS;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double XIGAPQHYTDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType GLAENVNETGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color RQAVQDJHTIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double PXKMATUCQXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double GZHLVMBEFQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public CGAKWGZQJFZ CGAKWGZQJFZ;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7309EE0", Offset = "0x7308EE0", VA = "0x187309EE0")]
		public RUFSDYIHMHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7309DC0", Offset = "0x7308DC0", VA = "0x187309DC0")]
		public RUFSDYIHMHB(RUFSDYIHMHB a, OOJQGESWHUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x73095F0", Offset = "0x73085F0", VA = "0x1873095F0")]
		public static RUFSDYIHMHB Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x73094D0", Offset = "0x73084D0", VA = "0x1873094D0")]
		public static RUFSDYIHMHB Deserialize(OOJQGESWHUS root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x73099E0", Offset = "0x73089E0", VA = "0x1873099E0", Slot = "4")]
		public override void XRHSQBYDVHR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class WAHKWBJPPBD : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<PWEFOYITPWG> FQRIVCGZDGW;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public WAHKWBJPPBD(IList<PWEFOYITPWG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x730E960", Offset = "0x730D960", VA = "0x18730E960", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x730E8F0", Offset = "0x730D8F0", VA = "0x18730E8F0", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class OQORXHUEJXX : PGQGJSOHBMX, AJICKOZGYZH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<RUFSDYIHMHB> VPMLUTADBKG;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x73064F0", Offset = "0x73054F0", VA = "0x1873064F0")]
		public OQORXHUEJXX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7305680", Offset = "0x7304680", VA = "0x187305680", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7306400", Offset = "0x7305400", VA = "0x187306400", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7306150", Offset = "0x7305150", VA = "0x187306150")]
		private static string[] SOAKVYRDVQF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7305CF0", Offset = "0x7304CF0", VA = "0x187305CF0")]
		private static ZWCVOXHWWDO.ImportValuesConversion NLJOGZTQNNL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7305900", Offset = "0x7304900", VA = "0x187305900", Slot = "6")]
		public bool KCHLSLEZFDE(OOJQGESWHUS a, CUDWNAWDSRZ b, [Out] ZWCVOXHWWDO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class TDQLQQFEKTM : XLBMFMPGHOM<RUFSDYIHMHB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override RUFSDYIHMHB Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x730BAC0", Offset = "0x730AAC0", VA = "0x18730BAC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x730BA80", Offset = "0x730AA80", VA = "0x18730BA80")]
		public TDQLQQFEKTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x730B9A0", Offset = "0x730A9A0", VA = "0x18730B9A0")]
		public static TDQLQQFEKTM Deserialize(OOJQGESWHUS root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class JUBZFPTQFKN : PGQGJSOHBMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public TDQLQQFEKTM TABZZXKCBRW;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public JUBZFPTQFKN(TDQLQQFEKTM a, OOJQGESWHUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7300640", Offset = "0x72FF640", VA = "0x187300640")]
		public JUBZFPTQFKN(int a, OOJQGESWHUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x73004C0", Offset = "0x72FF4C0", VA = "0x1873004C0", Slot = "5")]
		public PGQGJSOHBMX Clone(OOJQGESWHUS root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7300540", Offset = "0x72FF540", VA = "0x187300540", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class SOQSCLHSPKQ : DRQVDUGDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x730AE10", Offset = "0x7309E10", VA = "0x18730AE10")]
		public SOQSCLHSPKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x730A910", Offset = "0x7309910", VA = "0x18730A910", Slot = "4")]
		public override PGQGJSOHBMX Deserialize(OOJQGESWHUS root, JProperty extensionToken)
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
