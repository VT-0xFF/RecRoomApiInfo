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
	public class KHR_animation_pointer : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object ZMJZNOKKZKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string PQTYMNUGDPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string JTJMCGSGBGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public SHFDGYGOMIS MIKHLXCNHCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer WILJSSGLJRX;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x87C7C80", Offset = "0x87C6680", VA = "0x1887C7C80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C7BD0", Offset = "0x87C65D0", VA = "0x1887C7BD0", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class IKNSQXZBBWH
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 EDIXYIRZSOY;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 CMDDMMKVDSD;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion KUQSCHNTCMT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool WITFDBDHHPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x87C1B10", Offset = "0x87C0510", VA = "0x1887C1B10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87C4B20", Offset = "0x87C3520", VA = "0x1887C4B20")]
		public static void ZXUHTCGQDNN(this QQDUHQODGUC a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87C1CC0", Offset = "0x87C06C0", VA = "0x1887C1CC0")]
		public static void EYOLXPFRMBL(this QQDUHQODGUC a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87C4070", Offset = "0x87C2A70", VA = "0x1887C4070")]
		public static void VDJZJEKOYXC(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87C26F0", Offset = "0x87C10F0", VA = "0x1887C26F0")]
		public static GLTF.Math.Vector4 MOBBQVLRDFC(this FFCXZMVQUPL a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87C3E70", Offset = "0x87C2870", VA = "0x1887C3E70")]
		public static UnityEngine.Quaternion TISWSOCCEIH(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87C3D40", Offset = "0x87C2740", VA = "0x1887C3D40")]
		public static UnityEngine.Quaternion TISWSOCCEIH(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x87C25B0", Offset = "0x87C0FB0", VA = "0x1887C25B0")]
		public static GLTF.Math.Quaternion LZNIFITWVDD(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x87C3100", Offset = "0x87C1B00", VA = "0x1887C3100")]
		public static Matrix4x4 QBLOSGQQEEO(this FFCXZMVQUPL a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x87C3320", Offset = "0x87C1D20", VA = "0x1887C3320")]
		public static Matrix4x4 QBLOSGQQEEO(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x87C4440", Offset = "0x87C2E40", VA = "0x1887C4440")]
		public static FFCXZMVQUPL VHDRYWOTGQE(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x87C3840", Offset = "0x87C2240", VA = "0x1887C3840")]
		public static UnityEngine.Vector3 RTFVVMEQVGT(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87C3760", Offset = "0x87C2160", VA = "0x1887C3760")]
		public static UnityEngine.Vector3 RTFVVMEQVGT(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x87C2FD0", Offset = "0x87C19D0", VA = "0x1887C2FD0")]
		public static GLTF.Math.Vector3 PULHRSXWJHH(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x87C4780", Offset = "0x87C3180", VA = "0x1887C4780")]
		public static GLTF.Math.Vector3 VUPNCBUNNGU(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x13B8890", Offset = "0x13B7290", VA = "0x1813B8890")]
		public static GLTF.Math.Vector4 LMWWQEAUCJB(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x87C2C90", Offset = "0x87C1690", VA = "0x1887C2C90")]
		public static Matrix4x4 NTHWMVLSPTB(this FFCXZMVQUPL a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x87C2A20", Offset = "0x87C1420", VA = "0x1887C2A20")]
		public static Matrix4x4 NTHWMVLSPTB(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x87C3B70", Offset = "0x87C2570", VA = "0x1887C3B70")]
		public static FFCXZMVQUPL TFGFGLNRSUV(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x87C2310", Offset = "0x87C0D10", VA = "0x1887C2310")]
		public static UnityEngine.Vector2 JCHNPTHYZCP(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x87C2310", Offset = "0x87C0D10", VA = "0x1887C2310")]
		public static UnityEngine.Vector2 JCHNPTHYZCP(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x87C2240", Offset = "0x87C0C40", VA = "0x1887C2240")]
		public static void JCHNPTHYZCP(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x87C4AC0", Offset = "0x87C34C0", VA = "0x1887C4AC0")]
		public static UnityEngine.Vector3 ZEJVHZDAKKO(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD2A0", Offset = "0x1DABCA0", VA = "0x181DAD2A0")]
		public static UnityEngine.Vector3 ZEJVHZDAKKO(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x87C49D0", Offset = "0x87C33D0", VA = "0x1887C49D0")]
		public static void ZEJVHZDAKKO(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x13B8890", Offset = "0x13B7290", VA = "0x1813B8890")]
		public static UnityEngine.Vector4 YRZZYEZRCUF(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x13B8890", Offset = "0x13B7290", VA = "0x1813B8890")]
		public static UnityEngine.Vector4 YRZZYEZRCUF(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87C47C0", Offset = "0x87C31C0", VA = "0x1887C47C0")]
		public static UnityEngine.Vector4[] YRZZYEZRCUF(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x87C48C0", Offset = "0x87C32C0", VA = "0x1887C48C0")]
		public static void YRZZYEZRCUF(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x87C1A70", Offset = "0x87C0470", VA = "0x1887C1A70")]
		public static UnityEngine.Color CZNWMRIYPZB(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x87C1930", Offset = "0x87C0330", VA = "0x1887C1930")]
		public static void CZNWMRIYPZB(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x87C1A70", Offset = "0x87C0470", VA = "0x1887C1A70")]
		public static UnityEngine.Color CZNWMRIYPZB(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x13B8890", Offset = "0x13B7290", VA = "0x1813B8890")]
		public static UnityEngine.Color NRUMPVLTANQ(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x87C2910", Offset = "0x87C1310", VA = "0x1887C2910")]
		public static void NRUMPVLTANQ(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x13B8890", Offset = "0x13B7290", VA = "0x1813B8890")]
		public static UnityEngine.Color NRUMPVLTANQ(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x87C39E0", Offset = "0x87C23E0", VA = "0x1887C39E0")]
		public static GLTF.Math.Color SDLBZDSLCUI(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x87C21C0", Offset = "0x87C0BC0", VA = "0x1887C21C0")]
		public static GLTF.Math.Color FADHSXKUKNF(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x87C2F50", Offset = "0x87C1950", VA = "0x1887C2F50")]
		public static GLTF.Math.Color OTXDGZAUVJB(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87C1BA0", Offset = "0x87C05A0", VA = "0x1887C1BA0")]
		public static UnityEngine.Color[] EXAQWAEGDVQ(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x87C3960", Offset = "0x87C2360", VA = "0x1887C3960")]
		public static int[] SBKMBOAMWFT(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x87C2330", Offset = "0x87C0D30", VA = "0x1887C2330")]
		public static UnityEngine.Vector2[] JMPRPCMZHKC(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x87C3A10", Offset = "0x87C2410", VA = "0x1887C3A10")]
		public static void SDQDNBGXONL(GLFFZJOSQQR a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x87C17D0", Offset = "0x87C01D0", VA = "0x1887C17D0")]
		public static UnityEngine.Vector3[] CYVANLWLZAH(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x87C23E0", Offset = "0x87C0DE0", VA = "0x1887C23E0")]
		public static UnityEngine.Vector4[] LIELYTMHPPA(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x87C4000", Offset = "0x87C2A00", VA = "0x1887C4000")]
		public static void TSWQPQQRQKZ(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x87C2580", Offset = "0x87C0F80", VA = "0x1887C2580")]
		public static UnityEngine.Quaternion LMOMVCFFFRL(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class GLFFZJOSQQR
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public NXKRISSFYEA NXKRISSFYEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray CAOXMFIBFAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x87C1650", Offset = "0x87C0050", VA = "0x1887C1650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> GIRYBXXAXNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xEF3310", Offset = "0xEF1D10", VA = "0x180EF3310")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xFBD0B0", Offset = "0xFBBAB0", VA = "0x180FBD0B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint UGICJWZXTTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD1A4B0", Offset = "0xD18EB0", VA = "0x180D1A4B0")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD1A690", Offset = "0xD19090", VA = "0x180D1A690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x87C1660", Offset = "0x87C0060", VA = "0x1887C1660")]
		public GLFFZJOSQQR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x87C1690", Offset = "0x87C0090", VA = "0x1887C1690")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x87C16F0", Offset = "0x87C00F0", VA = "0x1887C16F0")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class VPVQDBKXQCM
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class ZQUHYZZXPID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> MPMZUSXLOGB;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ZQUHYZZXPID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x87D5760", Offset = "0x87D4160", VA = "0x1887D5760")]
			internal int? WLYONKWEQFM(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x87D56D0", Offset = "0x87D40D0", VA = "0x1887D56D0")]
			internal int? ONJCIXXKMZL(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x87D57E0", Offset = "0x87D41E0", VA = "0x1887D57E0")]
			internal bool YXXCAWVQMJL(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x87D12F0", Offset = "0x87CFCF0", VA = "0x1887D12F0")]
		private static void TJULFMEFVUJ(NumericArray a, GLFFZJOSQQR b, GLFFZJOSQQR c, GLFFZJOSQQR d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x87D1B50", Offset = "0x87D0550", VA = "0x1887D1B50")]
		public static void WXQUEAPSXZM(Dictionary<string, GLFFZJOSQQR> a, Dictionary<string, (GLFFZJOSQQR sparseIndices, GLFFZJOSQQR sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87D32D0", Offset = "0x87D1CD0", VA = "0x1887D32D0")]
		public static void ZCGVCQZTWWO(Dictionary<string, GLFFZJOSQQR> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x87D1A50", Offset = "0x87D0450", VA = "0x1887D1A50")]
		public static void UBLMWXJHOTH(GLFFZJOSQQR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x87D0D60", Offset = "0x87CF760", VA = "0x1887D0D60")]
		public static void DNYYLEOSWFL(Dictionary<string, List<GLFFZJOSQQR>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x87D1860", Offset = "0x87D0260", VA = "0x1887D1860")]
		private static void TWABSIDWRAV(GLFFZJOSQQR a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x87D1990", Offset = "0x87D0390", VA = "0x1887D1990")]
		internal static void TWABSIDWRAV(SFMCWQKOYSV a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x87D2E30", Offset = "0x87D1830", VA = "0x1887D2E30")]
		public static SCHRROBVJVZ XIYXPSDIRQF(IEnumerable<SCHRROBVJVZ> a)
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
			[Cpp2IlInjected.Address(RVA = "0xF8BD10", Offset = "0xF8A710", VA = "0x180F8BD10")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30F7B90", Offset = "0x30F6590", VA = "0x1830F7B90")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30F7BA0", Offset = "0x30F65A0", VA = "0x1830F7BA0")]
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
	public class JZLWTFIMYEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint ZCZPITRHWYB;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint NNSMLFGWXQP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint KLCYQBDKTUP;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x87C53F0", Offset = "0x87C3DF0", VA = "0x1887C53F0")]
		public static void BHBMCULGNTN(Stream a, [Out] DHMXSGPLOHN b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x87C5C50", Offset = "0x87C4650", VA = "0x1887C5C50")]
		public static ChunkInfo TPTBYREQBGD(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x87C59C0", Offset = "0x87C43C0", VA = "0x1887C59C0")]
		public static GLBHeader GHQECUMOLRH(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x87C5B00", Offset = "0x87C4500", VA = "0x1887C5B00")]
		public static bool SQTWKKOAFOR(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x87C5850", Offset = "0x87C4250", VA = "0x1887C5850")]
		public static ChunkInfo EDLADVKEBTE(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x87C55B0", Offset = "0x87C3FB0", VA = "0x1887C55B0")]
		private static void DBKODXQGBDS(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x87C5BC0", Offset = "0x87C45C0", VA = "0x1887C5BC0")]
		private static uint TJVZPLVVSTZ(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class QGBEMVWMRGA
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
		public PathElement TBKMOFLSUJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD1C790", Offset = "0xD1B190", VA = "0x180D1C790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int SCOEDYFFAIK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xDF7E10", Offset = "0xDF6810", VA = "0x180DF7E10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xDF7E00", Offset = "0xDF6800", VA = "0x180DF7E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string RAJFVTAFNGN
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AJIJMNEVDBW
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD159F0", Offset = "0xD143F0", VA = "0x180D159F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD15880", Offset = "0xD14280", VA = "0x180D15880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public QGBEMVWMRGA NLQAGYNIMHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xD12070", Offset = "0xD10A70", VA = "0x180D12070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x87CEE50", Offset = "0x87CD850", VA = "0x1887CEE50")]
		public string ZEGPKBGQLVW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x87CEDF0", Offset = "0x87CD7F0", VA = "0x1887CEDF0")]
		public QGBEMVWMRGA LFBMUXHPDXK(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x87CF080", Offset = "0x87CDA80", VA = "0x1887CF080")]
		private QGBEMVWMRGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x87CEED0", Offset = "0x87CD8D0", VA = "0x1887CEED0")]
		public QGBEMVWMRGA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5372930", Offset = "0x5371330", VA = "0x185372930")]
		[CompilerGenerated]
		internal static string SSMYBDQBQFO(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x87CEE10", Offset = "0x87CD810", VA = "0x1887CEE10")]
		[CompilerGenerated]
		internal static bool RKTSSQOIJPR([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x87CEC10", Offset = "0x87CD610", VA = "0x1887CEC10")]
		[CompilerGenerated]
		internal static QGBEMVWMRGA HQWEDGEBYUZ(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class RHWNMNDPYKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x87CF7D0", Offset = "0x87CE1D0", VA = "0x1887CF7D0")]
		public static int[] ULOQQSAMIIB(this DHMXSGPLOHN a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x87CFA70", Offset = "0x87CE470", VA = "0x1887CFA70")]
		public static int[] WHPZVQBFBSH(this DHMXSGPLOHN a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class NITQLSZIMOR
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x87CCC80", Offset = "0x87CB680", VA = "0x1887CCC80")]
		public static uint NUPFRFDIUUC(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream HFGBMPYIQJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long GEZFVOJZXNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long UCQJNJYYXKQ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x87D02E0", Offset = "0x87CECE0", VA = "0x1887D02E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x87D0320", Offset = "0x87CED20", VA = "0x1887D0320", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x87D0320", Offset = "0x87CED20", VA = "0x1887D0320", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x87D0340", Offset = "0x87CED40", VA = "0x1887D0340", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x87D0360", Offset = "0x87CED60", VA = "0x1887D0360", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x87D0380", Offset = "0x87CED80", VA = "0x1887D0380", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x87D0070", Offset = "0x87CEA70", VA = "0x1887D0070")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x87CFE30", Offset = "0x87CE830", VA = "0x1887CFE30", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x87CFF90", Offset = "0x87CE990", VA = "0x1887CFF90", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x87CFFF0", Offset = "0x87CE9F0", VA = "0x1887CFFF0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x87CFF00", Offset = "0x87CE900", VA = "0x1887CFF00", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x87D0030", Offset = "0x87CEA30", VA = "0x1887D0030", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x87CFE70", Offset = "0x87CE870", VA = "0x1887CFE70")]
		private void NPAXPCMJDIV()
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
		public static Color TJDDFPSIDUF
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x87BF430", Offset = "0x87BDE30", VA = "0x1887BF430")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color SJXSRGAOVNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x87BF450", Offset = "0x87BDE50", VA = "0x1887BF450")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color MHXDGQUEXMH
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x87BF160", Offset = "0x87BDB60", VA = "0x1887BF160")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2E0AA30", Offset = "0x2E09430", VA = "0x182E0AA30")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x188D340", Offset = "0x188BD40", VA = "0x18188D340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2E682F0", Offset = "0x2E66CF0", VA = "0x182E682F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2E68300", Offset = "0x2E66D00", VA = "0x182E68300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BE02D0", Offset = "0x2BDECD0", VA = "0x182BE02D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x32F3D80", Offset = "0x32F2780", VA = "0x1832F3D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x152C0E0", Offset = "0x152AAE0", VA = "0x18152C0E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x152C0F0", Offset = "0x152AAF0", VA = "0x18152C0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2BA20F0", Offset = "0x2BA0AF0", VA = "0x182BA20F0")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x87BF230", Offset = "0x87BDC30", VA = "0x1887BF230", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x87BF2E0", Offset = "0x87BDCE0", VA = "0x1887BF2E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x87BF380", Offset = "0x87BDD80", VA = "0x1887BF380", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x87BF180", Offset = "0x87BDB80", VA = "0x1887BF180")]
		public static bool ENWYWLXFHXP(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class FFCXZMVQUPL : IEquatable<FFCXZMVQUPL>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly FFCXZMVQUPL IWZNYIVHXYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] XWORTRSRQVK;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float IOPNLNEJJZV
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x87C0BF0", Offset = "0x87BF5F0", VA = "0x1887C0BF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x87C0B00", Offset = "0x87BF500", VA = "0x1887C0B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float CJUDJMDCKKU
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x87C03B0", Offset = "0x87BEDB0", VA = "0x1887C03B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x87C02C0", Offset = "0x87BECC0", VA = "0x1887C02C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float VPZYVPVODOF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x87C0950", Offset = "0x87BF350", VA = "0x1887C0950")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x87C0860", Offset = "0x87BF260", VA = "0x1887C0860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float QLCNGWTHPVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x87C0AD0", Offset = "0x87BF4D0", VA = "0x1887C0AD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x87C09E0", Offset = "0x87BF3E0", VA = "0x1887C09E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float IOUUITYGTLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x87C0C50", Offset = "0x87BF650", VA = "0x1887C0C50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x87C0B60", Offset = "0x87BF560", VA = "0x1887C0B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float CKJYBGKUMSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x87C03E0", Offset = "0x87BEDE0", VA = "0x1887C03E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x87C02F0", Offset = "0x87BECF0", VA = "0x1887C02F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float VPKEDVNWBGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x87C0920", Offset = "0x87BF320", VA = "0x1887C0920")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x87C0830", Offset = "0x87BF230", VA = "0x1887C0830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float QKXGJPZKGKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x87C0A70", Offset = "0x87BF470", VA = "0x1887C0A70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x87C0980", Offset = "0x87BF380", VA = "0x1887C0980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float IPABGASECWN
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x87C0C20", Offset = "0x87BF620", VA = "0x1887C0C20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x87C0B30", Offset = "0x87BF530", VA = "0x1887C0B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float CKERDZQXDHM
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x87C0410", Offset = "0x87BEE10", VA = "0x1887C0410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x87C0320", Offset = "0x87BED20", VA = "0x1887C0320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float VPPLBCHTKRN
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x87C08F0", Offset = "0x87BF2F0", VA = "0x1887C08F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x87C0800", Offset = "0x87BF200", VA = "0x1887C0800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float QKRZMJFMWYU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x87C0AA0", Offset = "0x87BF4A0", VA = "0x1887C0AA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x87C09B0", Offset = "0x87BF3B0", VA = "0x1887C09B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float IPFIDHMBMHW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x87C0BC0", Offset = "0x87BF5C0", VA = "0x1887C0BC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x87C0B90", Offset = "0x87BF590", VA = "0x1887C0B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float CKULVTYPFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x87C0380", Offset = "0x87BED80", VA = "0x1887C0380")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x87C0350", Offset = "0x87BED50", VA = "0x1887C0350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float VOZQJIABIJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x87C08C0", Offset = "0x87BF2C0", VA = "0x1887C08C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x87C0890", Offset = "0x87BF290", VA = "0x1887C0890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float QKMSPCLPNNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x87C0A40", Offset = "0x87BF440", VA = "0x1887C0A40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x87C0A10", Offset = "0x87BF410", VA = "0x1887C0A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x87C0D60", Offset = "0x87BF760", VA = "0x1887C0D60")]
		public FFCXZMVQUPL(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x87C0440", Offset = "0x87BEE40", VA = "0x1887C0440", Slot = "4")]
		public bool Equals(FFCXZMVQUPL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x87C0700", Offset = "0x87BF100", VA = "0x1887C0700", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x11011E0", Offset = "0x10FFBE0", VA = "0x1811011E0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2E0AA30", Offset = "0x2E09430", VA = "0x182E0AA30")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x188D340", Offset = "0x188BD40", VA = "0x18188D340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2E682F0", Offset = "0x2E66CF0", VA = "0x182E682F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2E68300", Offset = "0x2E66D00", VA = "0x182E68300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2BE02D0", Offset = "0x2BDECD0", VA = "0x182BE02D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32F3D80", Offset = "0x32F2780", VA = "0x1832F3D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x152C0E0", Offset = "0x152AAE0", VA = "0x18152C0E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x152C0F0", Offset = "0x152AAF0", VA = "0x18152C0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x87CF610", Offset = "0x87CE010", VA = "0x1887CF610")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x87CF2E0", Offset = "0x87CDCE0", VA = "0x1887CF2E0", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x87CF400", Offset = "0x87CDE00", VA = "0x1887CF400", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x87CF4B0", Offset = "0x87CDEB0", VA = "0x1887CF4B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x87CF270", Offset = "0x87CDC70", VA = "0x1887CF270")]
		public static bool ENWYWLXFHXP(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2E0AA30", Offset = "0x2E09430", VA = "0x182E0AA30")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x188D340", Offset = "0x188BD40", VA = "0x18188D340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2E682F0", Offset = "0x2E66CF0", VA = "0x182E682F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2E68300", Offset = "0x2E66D00", VA = "0x182E68300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1076200", Offset = "0x1074C00", VA = "0x181076200")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x87D39A0", Offset = "0x87D23A0", VA = "0x1887D39A0")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x87D3810", Offset = "0x87D2210", VA = "0x1887D3810", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x87D3870", Offset = "0x87D2270", VA = "0x1887D3870", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x87D3950", Offset = "0x87D2350", VA = "0x1887D3950", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x87D37B0", Offset = "0x87D21B0", VA = "0x1887D37B0")]
		public static bool ENWYWLXFHXP(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2E0AA30", Offset = "0x2E09430", VA = "0x182E0AA30")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x188D340", Offset = "0x188BD40", VA = "0x18188D340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2E682F0", Offset = "0x2E66CF0", VA = "0x182E682F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2E68300", Offset = "0x2E66D00", VA = "0x182E68300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2BE02D0", Offset = "0x2BDECD0", VA = "0x182BE02D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32F3D80", Offset = "0x32F2780", VA = "0x1832F3D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x87D3D60", Offset = "0x87D2760", VA = "0x1887D3D60")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x87D3A30", Offset = "0x87D2430", VA = "0x1887D3A30", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x87D3B10", Offset = "0x87D2510", VA = "0x1887D3B10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x87D3BD0", Offset = "0x87D25D0", VA = "0x1887D3BD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x87D39C0", Offset = "0x87D23C0", VA = "0x1887D39C0")]
		public static bool ENWYWLXFHXP(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2E0AA30", Offset = "0x2E09430", VA = "0x182E0AA30")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x188D340", Offset = "0x188BD40", VA = "0x18188D340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E682F0", Offset = "0x2E66CF0", VA = "0x182E682F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2E68300", Offset = "0x2E66D00", VA = "0x182E68300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2BE02D0", Offset = "0x2BDECD0", VA = "0x182BE02D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x32F3D80", Offset = "0x32F2780", VA = "0x1832F3D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x152C0E0", Offset = "0x152AAE0", VA = "0x18152C0E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x152C0F0", Offset = "0x152AAF0", VA = "0x18152C0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2BA20F0", Offset = "0x2BA0AF0", VA = "0x182BA20F0")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x87BF230", Offset = "0x87BDC30", VA = "0x1887BF230", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x87D3DE0", Offset = "0x87D27E0", VA = "0x1887D3DE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x87BF380", Offset = "0x87BDD80", VA = "0x1887BF380", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class IBCSOUTFUEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x87C1750", Offset = "0x87C0150", VA = "0x1887C1750")]
		public static void HPLOGGFVBOQ(this JObject a, string b, YLAXURNXFQN c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class NITQLSZIMOR
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x87CC7D0", Offset = "0x87CB1D0", VA = "0x1887CC7D0")]
		public static List<string> JXVESFRPGHJ(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x87CD640", Offset = "0x87CC040", VA = "0x1887CD640")]
		public static List<double> TRFDEFZYJGD(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x87CCAC0", Offset = "0x87CB4C0", VA = "0x1887CCAC0")]
		public static List<int> NAHSZCGUXXU(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3D5CA50", Offset = "0x3D5B450", VA = "0x183D5CA50")]
		public static List<a> BIDENYGCTXA<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x87CD800", Offset = "0x87CC200", VA = "0x1887CD800")]
		public static YLAXURNXFQN WISQPKJQJNO(this JToken a, DHMXSGPLOHN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x87CC980", Offset = "0x87CB380", VA = "0x1887CC980")]
		public static int LPWEFLKEJDM(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x87CD500", Offset = "0x87CBF00", VA = "0x1887CD500")]
		public static double SSYUKTNFTMM(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x87CC4F0", Offset = "0x87CAEF0", VA = "0x1887CC4F0")]
		public static GLTF.Math.Color GFAMEZYQUYD(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x87CC280", Offset = "0x87CAC80", VA = "0x1887CC280")]
		public static GLTF.Math.Color ETJMIMTCESU(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x87CBFE0", Offset = "0x87CA9E0", VA = "0x1887CBFE0")]
		public static GLTF.Math.Color EAHQBRVUDVK(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x87CD240", Offset = "0x87CBC40", VA = "0x1887CD240")]
		public static GLTF.Math.Vector3 QGKHCJAVFQS(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x87CCDD0", Offset = "0x87CB7D0", VA = "0x1887CCDD0")]
		public static GLTF.Math.Vector2 PUFKKQOAAEI(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x87CCFE0", Offset = "0x87CB9E0", VA = "0x1887CCFE0")]
		public static GLTF.Math.Vector3 PUKRHXHXJPR(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x87CBCD0", Offset = "0x87CA6D0", VA = "0x1887CBCD0")]
		public static GLTF.Math.Quaternion DOMFZQAXAEK(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3D5D0F0", Offset = "0x3D5BAF0", VA = "0x183D5D0F0")]
		public static Dictionary<string, b> YHIJODVSGDQ<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D5CDA0", Offset = "0x3D5B7A0", VA = "0x183D5CDA0")]
		public static c FINEOXJKABE<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public SFMCWQKOYSV bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x87C0110", Offset = "0x87BEB10", VA = "0x1887C0110", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x87C0090", Offset = "0x87BEA90", VA = "0x1887C0090", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class IMNXLZCAGHG : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x87C5250", Offset = "0x87C3C50", VA = "0x1887C5250")]
		public IMNXLZCAGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x87C5180", Offset = "0x87C3B80", VA = "0x1887C5180", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, NXKRISSFYEA> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x87BFF50", Offset = "0x87BE950", VA = "0x1887BFF50", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x87C0010", Offset = "0x87BEA10", VA = "0x1887C0010")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class FNQCVMURKCW : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public DHMXSGPLOHN VQTHZPRYINY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader QAFMVBJJKQR;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x87D4AA0", Offset = "0x87D34A0", VA = "0x1887D4AA0")]
			internal NXKRISSFYEA UNLSJXCAETX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x87C1600", Offset = "0x87C0000", VA = "0x1887C1600")]
		public FNQCVMURKCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x87C1470", Offset = "0x87BFE70", VA = "0x1887C1470", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public HCLYIPZQKAW VMQMZHGPIQL;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public EXT_texture_exr(HCLYIPZQKAW source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x87C0160", Offset = "0x87BEB60", VA = "0x1887C0160", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x87C01D0", Offset = "0x87BEBD0", VA = "0x1887C01D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DVSSAAIEPSL : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x87BFE30", Offset = "0x87BE830", VA = "0x1887BFE30")]
		public DVSSAAIEPSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x87BFD10", Offset = "0x87BE710", VA = "0x1887BFD10", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
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
	public class AudioEmitterId : QIZRGVLSZGF<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x87BA3D0", Offset = "0x87B8DD0", VA = "0x1887BA3D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x87BA390", Offset = "0x87B8D90", VA = "0x1887BA390")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : QIZRGVLSZGF<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x87BA560", Offset = "0x87B8F60", VA = "0x1887BA560", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x87BA520", Offset = "0x87B8F20", VA = "0x1887BA520")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : QIZRGVLSZGF<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x87BA240", Offset = "0x87B8C40", VA = "0x1887BA240", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x87BA200", Offset = "0x87B8C00", VA = "0x1887BA200")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x87BA120", Offset = "0x87B8B20", VA = "0x1887BA120")]
		public static AudioDataId Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x87C78F0", Offset = "0x87C62F0", VA = "0x1887C78F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x87C74F0", Offset = "0x87C5EF0", VA = "0x1887C74F0", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x87C7560", Offset = "0x87C5F60", VA = "0x1887C7560")]
		public static KHR_SceneAudioEmittersRef Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x87C7B50", Offset = "0x87C6550", VA = "0x1887C7B50")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x87C74C0", Offset = "0x87C5EC0", VA = "0x1887C74C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x87C73A0", Offset = "0x87C5DA0", VA = "0x1887C73A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x87C7190", Offset = "0x87C5B90", VA = "0x1887C7190", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x87C7200", Offset = "0x87C5C00", VA = "0x1887C7200")]
		public static KHR_NodeAudioEmitterRef Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class NXHHPCHBSCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string RZRZTMBSBMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? KXBUAWKZECS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? YVMLSMEEJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? FVBIUOLBIBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? YRXNBCFHAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? MQIJUVPBRRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? JVIPPPCHCNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? RHLKIVRKQAR;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x87CE1A0", Offset = "0x87CCBA0", VA = "0x1887CE1A0")]
		public JObject NZJDRENIZKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x87CDAA0", Offset = "0x87CC4A0", VA = "0x1887CDAA0")]
		public static NXHHPCHBSCG Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public NXHHPCHBSCG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : FEXFGYBIPXR
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
		public NXHHPCHBSCG positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x87C67E0", Offset = "0x87C51E0", VA = "0x1887C67E0", Slot = "5")]
		public virtual JObject NZJDRENIZKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x87C62E0", Offset = "0x87C4CE0", VA = "0x1887C62E0")]
		public static KHR_AudioEmitter Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x87C6B80", Offset = "0x87C5580", VA = "0x1887C6B80")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : FEXFGYBIPXR
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
		[Cpp2IlInjected.Address(RVA = "0x87C6F60", Offset = "0x87C5960", VA = "0x1887C6F60")]
		public JObject NZJDRENIZKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C00", Offset = "0x87C5600", VA = "0x1887C6C00")]
		public static KHR_AudioSource Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x87BF150", Offset = "0x87BDB50", VA = "0x1887BF150")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : FEXFGYBIPXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public OLNWMRVLZRW bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x87C61B0", Offset = "0x87C4BB0", VA = "0x1887C61B0")]
		public JObject NZJDRENIZKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x87C5F50", Offset = "0x87C4950", VA = "0x1887C5F50")]
		public static KHR_AudioData Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x87BF150", Offset = "0x87BDB50", VA = "0x1887BF150")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : XEMVEUNMABQ
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
		[Cpp2IlInjected.Address(RVA = "0x87C7E10", Offset = "0x87C6810", VA = "0x1887C7E10", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x87C7D80", Offset = "0x87C6780", VA = "0x1887C7D80", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x87C8540", Offset = "0x87C6F40", VA = "0x1887C8540")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class WFFQAZTALIZ : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x87D4A50", Offset = "0x87D3450", VA = "0x1887D4A50")]
		public WFFQAZTALIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x87D3E80", Offset = "0x87D2880", VA = "0x1887D3E80", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public OLNWMRVLZRW bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x87C8710", Offset = "0x87C7110", VA = "0x1887C8710", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x87C8650", Offset = "0x87C7050", VA = "0x1887C8650", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x87C8760", Offset = "0x87C7160", VA = "0x1887C8760")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class OGLKYAUKKSD : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader QAFMVBJJKQR;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x87D4B50", Offset = "0x87D3550", VA = "0x1887D4B50")]
			internal int UNLSJXCAETX()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x87CE620", Offset = "0x87CD020", VA = "0x1887CE620")]
		public OGLKYAUKKSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x87CE410", Offset = "0x87CCE10", VA = "0x1887CE410", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public YLAXURNXFQN anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x87C8860", Offset = "0x87C7260", VA = "0x1887C8860", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x87C87E0", Offset = "0x87C71E0", VA = "0x1887C87E0", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class FFQHKXVTAOM : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x87C11C0", Offset = "0x87BFBC0", VA = "0x1887C11C0")]
		public FFQHKXVTAOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x87C1010", Offset = "0x87BFA10", VA = "0x1887C1010", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public YLAXURNXFQN clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public YLAXURNXFQN clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public YLAXURNXFQN clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x87C8B10", Offset = "0x87C7510", VA = "0x1887C8B10", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x87C8A70", Offset = "0x87C7470", VA = "0x1887C8A70", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class DBVIFYIUDVW : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x87BF6E0", Offset = "0x87BE0E0", VA = "0x1887BF6E0")]
		public DBVIFYIUDVW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x87BF460", Offset = "0x87BDE60", VA = "0x1887BF460", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x87C8E70", Offset = "0x87C7870", VA = "0x1887C8E70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x87C8E00", Offset = "0x87C7800", VA = "0x1887C8E00", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class TWSTFJFGEEK : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x87D0640", Offset = "0x87CF040", VA = "0x1887D0640")]
		public TWSTFJFGEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x87D0570", Offset = "0x87CEF70", VA = "0x1887D0570", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : XZHBEOOYVKW, XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float JEDSAABEWWA;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x87C9150", Offset = "0x87C7B50", VA = "0x1887C9150")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x87C91A0", Offset = "0x87C7BA0", VA = "0x1887C91A0")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, DHMXSGPLOHN root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x87C8F90", Offset = "0x87C7990", VA = "0x1887C8F90", Slot = "6")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x87C9030", Offset = "0x87C7A30", VA = "0x1887C9030", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class JZGNTLETVQT : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x87C53A0", Offset = "0x87C3DA0", VA = "0x1887C53A0")]
		public JZGNTLETVQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x87C52A0", Offset = "0x87C3CA0", VA = "0x1887C52A0", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x87C9270", Offset = "0x87C7C70", VA = "0x1887C9270", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x87C9210", Offset = "0x87C7C10", VA = "0x1887C9210", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x87C93C0", Offset = "0x87C7DC0", VA = "0x1887C93C0")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class BYFIQFIBXEA : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x87BA780", Offset = "0x87B9180", VA = "0x1887BA780")]
		public BYFIQFIBXEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x87BA6B0", Offset = "0x87B90B0", VA = "0x1887BA6B0", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public YLAXURNXFQN iridescenceTexture;

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
		public YLAXURNXFQN iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x87C9470", Offset = "0x87C7E70", VA = "0x1887C9470", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x87C93D0", Offset = "0x87C7DD0", VA = "0x1887C93D0", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x87C9830", Offset = "0x87C8230", VA = "0x1887C9830")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class PNCCURVIKAC : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x87CEA90", Offset = "0x87CD490", VA = "0x1887CEA90")]
		public PNCCURVIKAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x87CE7A0", Offset = "0x87CD1A0", VA = "0x1887CE7A0", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class MDXGEBBVFLD : XEMVEUNMABQ
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 TFEYXPMSPIX;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double PLXOKBVAYBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color FOTFSGCNYUH;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color SDADKBBZYMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public YLAXURNXFQN FKXYXMQEKXZ;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly YLAXURNXFQN EIUDVEMHZIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 ALRWDDZHWCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double KKFURLXNWDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public YLAXURNXFQN XDXMCYPEHSU;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly YLAXURNXFQN JFKFRZTZOWQ;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x87CBBD0", Offset = "0x87CA5D0", VA = "0x1887CBBD0")]
		public MDXGEBBVFLD(GLTF.Math.Color a, YLAXURNXFQN b, GLTF.Math.Vector3 c, double d, YLAXURNXFQN e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x87CB2A0", Offset = "0x87C9CA0", VA = "0x1887CB2A0", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x87CB460", Offset = "0x87C9E60", VA = "0x1887CB460", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class VKAJNKNMVBH : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x87D0A60", Offset = "0x87CF460", VA = "0x1887D0A60")]
		public VKAJNKNMVBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x87D0700", Offset = "0x87CF100", VA = "0x1887D0700", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public YLAXURNXFQN sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public YLAXURNXFQN sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x87C9920", Offset = "0x87C8320", VA = "0x1887C9920", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x87C9850", Offset = "0x87C8250", VA = "0x1887C9850", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x87C9E30", Offset = "0x87C8830", VA = "0x1887C9E30")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class VLOIEFUJQEP : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x87D0D10", Offset = "0x87CF710", VA = "0x1887D0D10")]
		public VLOIEFUJQEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x87D0AB0", Offset = "0x87CF4B0", VA = "0x1887D0AB0", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public YLAXURNXFQN specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public YLAXURNXFQN specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x87C9F70", Offset = "0x87C8970", VA = "0x1887C9F70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x87C9EA0", Offset = "0x87C88A0", VA = "0x1887C9EA0", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x87CA490", Offset = "0x87C8E90", VA = "0x1887CA490")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class SPATDANGSGJ : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x87CFDE0", Offset = "0x87CE7E0", VA = "0x1887CFDE0")]
		public SPATDANGSGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x87CFBC0", Offset = "0x87CE5C0", VA = "0x1887CFBC0", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public YLAXURNXFQN transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x87CA580", Offset = "0x87C8F80", VA = "0x1887CA580", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x87CA500", Offset = "0x87C8F00", VA = "0x1887CA500", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class QSCNOHMYVCA : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x87CF220", Offset = "0x87CDC20", VA = "0x1887CF220")]
		public QSCNOHMYVCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x87CF0E0", Offset = "0x87CDAE0", VA = "0x1887CF0E0", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class DMGLZPMKANT : XZHBEOOYVKW, XEMVEUNMABQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x87BFC50", Offset = "0x87BE650", VA = "0x1887BFC50")]
		public DMGLZPMKANT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x87BFCA0", Offset = "0x87BE6A0", VA = "0x1887BFCA0")]
		public DMGLZPMKANT(DMGLZPMKANT a, DHMXSGPLOHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x87BFA50", Offset = "0x87BE450", VA = "0x1887BFA50", Slot = "6")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x87BFAF0", Offset = "0x87BE4F0", VA = "0x1887BFAF0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x87BFB80", Offset = "0x87BE580", VA = "0x1887BFB80", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class DVXKGZJBWKJ : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x87BFF00", Offset = "0x87BE900", VA = "0x1887BFF00")]
		public DVXKGZJBWKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x87BFE80", Offset = "0x87BE880", VA = "0x1887BFE80", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public YLAXURNXFQN thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x87CA7A0", Offset = "0x87C91A0", VA = "0x1887CA7A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x87CA710", Offset = "0x87C9110", VA = "0x1887CA710", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x87CACD0", Offset = "0x87C96D0", VA = "0x1887CACD0")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class FKTNNVSORGW : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x87C1420", Offset = "0x87BFE20", VA = "0x1887C1420")]
		public FKTNNVSORGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x87C1210", Offset = "0x87BFC10", VA = "0x1887C1210", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x87CAD50", Offset = "0x87C9750", VA = "0x1887CAD50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x87CACF0", Offset = "0x87C96F0", VA = "0x1887CACF0", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x12537F0", Offset = "0x12521F0", VA = "0x1812537F0")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class PNRQFOAICCW : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x87CEBC0", Offset = "0x87CD5C0", VA = "0x1887CEBC0")]
		public PNRQFOAICCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x87CEAE0", Offset = "0x87CD4E0", VA = "0x1887CEAE0", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x87CAEC0", Offset = "0x87C98C0", VA = "0x1887CAEC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x87CAE60", Offset = "0x87C9860", VA = "0x1887CAE60", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x12537F0", Offset = "0x12521F0", VA = "0x1812537F0")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class OOFASJRAFWC : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x87CE750", Offset = "0x87CD150", VA = "0x1887CE750")]
		public OOFASJRAFWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x87CE670", Offset = "0x87CD070", VA = "0x1887CE670", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x87CB030", Offset = "0x87C9A30", VA = "0x1887CB030", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x87CAFD0", Offset = "0x87C99D0", VA = "0x1887CAFD0", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x12537F0", Offset = "0x12521F0", VA = "0x1812537F0")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class RGDVIEOSBXQ : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x87CF780", Offset = "0x87CE180", VA = "0x1887CF780")]
		public RGDVIEOSBXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x87CF6A0", Offset = "0x87CE0A0", VA = "0x1887CF6A0", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public HCLYIPZQKAW source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public KHR_texture_basisu(HCLYIPZQKAW source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x87CB140", Offset = "0x87C9B40", VA = "0x1887CB140", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x87CB1B0", Offset = "0x87C9BB0", VA = "0x1887CB1B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class TLWEBFWFHUC : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x87D0520", Offset = "0x87CEF20", VA = "0x1887D0520")]
		public TLWEBFWFHUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x87D03C0", Offset = "0x87CEDC0", VA = "0x1887D03C0", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class YAJRUUNSZLT : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 UGICJWZXTTX;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 KEVVKRPXEIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double MNYYIPRVPAA;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double BZVIDTJKSIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 OHFXQNDZZMY;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 EOBQKPXFMZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? JLSIGKLKTRK;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int KRHNODOVOQW;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x87D5650", Offset = "0x87D4050", VA = "0x1887D5650")]
		public YAJRUUNSZLT(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x87D4F00", Offset = "0x87D3900", VA = "0x1887D4F00", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x87D4FE0", Offset = "0x87D39E0", VA = "0x1887D4FE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class DBWXVWNWOHP : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x87BFA00", Offset = "0x87BE400", VA = "0x1887BFA00")]
		public DBWXVWNWOHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x87BF730", Offset = "0x87BE130", VA = "0x1887BF730", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class WRDNJKKBRQN : XEMVEUNMABQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> WCKCZNWHNOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public WRDNJKKBRQN(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x87D4BC0", Offset = "0x87D35C0", VA = "0x1887D4BC0", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x87D4CC0", Offset = "0x87D36C0", VA = "0x1887D4CC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x87D4C30", Offset = "0x87D3630", VA = "0x1887D4C30")]
		public List<double> SCHAFNSOIWL(QQDUHQODGUC a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class XCSRRGVWCUR : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x87D4EB0", Offset = "0x87D38B0", VA = "0x1887D4EB0")]
		public XCSRRGVWCUR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x87D4DB0", Offset = "0x87D37B0", VA = "0x1887D4DB0", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class CRTLZRZAKNL : FEXFGYBIPXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public OLNWMRVLZRW SFMCWQKOYSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint RLUAPHMOIMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType JCUCTRDLLXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool RHZNUUKBELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint DJHUXMLNUTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType AFHKRTOWHTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> UZPVHSJXZNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> TIITIXKBMDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CDAJGEQBZQJ GPIKNXMWRYW;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x87BF150", Offset = "0x87BDB50", VA = "0x1887BF150")]
		public CRTLZRZAKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x87BACC0", Offset = "0x87B96C0", VA = "0x1887BACC0")]
		public static CRTLZRZAKNL Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x87BCC00", Offset = "0x87BB600", VA = "0x1887BCC00", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x87BC840", Offset = "0x87BB240", VA = "0x1887BC840")]
		private unsafe static sbyte NDXPZYRCPWA(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x87BE6E0", Offset = "0x87BD0E0", VA = "0x1887BE6E0")]
		private unsafe static float2 SEURZKJZGUG(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x87BE970", Offset = "0x87BD370", VA = "0x1887BE970")]
		private unsafe static float3 UYXAWMRPSSX(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x87BAAE0", Offset = "0x87B94E0", VA = "0x1887BAAE0")]
		private unsafe static float4 BRQJALMBZQI(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x87BE770", Offset = "0x87BD170", VA = "0x1887BE770")]
		private unsafe static float4x4 UJSVWTAZMXS(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x87BC840", Offset = "0x87BB240", VA = "0x1887BC840")]
		private unsafe static byte XEXCLNZNTMN(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x87BA7D0", Offset = "0x87B91D0", VA = "0x1887BA7D0")]
		private unsafe static float2 AIWUFUZIKER(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x87BC7E0", Offset = "0x87BB1E0", VA = "0x1887BC7E0")]
		private unsafe static float3 MXSWXBYBVPC(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x87BE710", Offset = "0x87BD110", VA = "0x1887BE710")]
		private unsafe static float4 SLQSCWVZXTJ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x87BD410", Offset = "0x87BBE10", VA = "0x1887BD410")]
		private unsafe static float4x4 OFWBASIVSDJ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x87BACB0", Offset = "0x87B96B0", VA = "0x1887BACB0")]
		private unsafe static short VADXUATUJQA(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x87BCBD0", Offset = "0x87BB5D0", VA = "0x1887BCBD0")]
		private unsafe static float2 NSYHXBDCZGS(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x87BB4C0", Offset = "0x87B9EC0", VA = "0x1887BB4C0")]
		private unsafe static float3 FCXBUSKIKSD(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x87BB8F0", Offset = "0x87BA2F0", VA = "0x1887BB8F0")]
		private unsafe static float4 FRIHAFLKLNS(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x87BDC00", Offset = "0x87BC600", VA = "0x1887BDC00")]
		private unsafe static float4x4 QEAMKBOBQCY(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x87BACB0", Offset = "0x87B96B0", VA = "0x1887BACB0")]
		private unsafe static ushort SNIANZAMEDR(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x87BC540", Offset = "0x87BAF40", VA = "0x1887BC540")]
		private unsafe static float2 JVBFZDJKFJR(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x87BD5B0", Offset = "0x87BBFB0", VA = "0x1887BD5B0")]
		private unsafe static float3 OTIJMFUQVKK(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x87BEE40", Offset = "0x87BD840", VA = "0x1887BEE40")]
		private unsafe static float4x4 WEORYXFCBBL(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x87BE910", Offset = "0x87BD310", VA = "0x1887BE910")]
		private unsafe static float4 UXVEWYPIDEZ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x87BE110", Offset = "0x87BCB10", VA = "0x1887BE110")]
		private unsafe static uint RDSOYMYQRJQ(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x87BACB0", Offset = "0x87B96B0", VA = "0x1887BACB0")]
		private unsafe static ushort DWTPSBFIFNF(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x87BC830", Offset = "0x87BB230", VA = "0x1887BC830")]
		private unsafe static float NDJNCCTUTPO(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x87BEE20", Offset = "0x87BD820", VA = "0x1887BEE20")]
		private unsafe static float2 VZRMPQAXLNQ(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x87BBA70", Offset = "0x87BA470", VA = "0x1887BBA70")]
		private unsafe static float3 GPHLQXYRUQL(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x87BAA80", Offset = "0x87B9480", VA = "0x1887BAA80")]
		private unsafe static float4 GKCAGSYMLZG(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x87BDDA0", Offset = "0x87BC7A0", VA = "0x1887BDDA0")]
		private unsafe static float4x4 QNNDKPATEVO(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x87BAA80", Offset = "0x87B9480", VA = "0x1887BAA80")]
		private unsafe static float4 BQFNOUTNULZ(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x87BAAB0", Offset = "0x87B94B0", VA = "0x1887BAAB0")]
		private unsafe static float4 BQFNOUTNULZ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x87BD1E0", Offset = "0x87BBBE0", VA = "0x1887BD1E0")]
		public static float3[] OBAKWZWAKRE(CRTLZRZAKNL a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x87BE120", Offset = "0x87BCB20", VA = "0x1887BE120")]
		public static float3[] RFCXBLXOHNY(CRTLZRZAKNL a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x87BB780", Offset = "0x87BA180", VA = "0x1887BB780")]
		public static uint[] FPEVLGSRWFR(CRTLZRZAKNL a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x87BC200", Offset = "0x87BAC00", VA = "0x1887BC200")]
		internal static void HPJLGJAZZJS(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x87BC980", Offset = "0x87BB380", VA = "0x1887BC980")]
		public uint[] NSORTQZXZBZ(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x87BC570", Offset = "0x87BAF70", VA = "0x1887BC570")]
		public float[] MSRICFBOMKB(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x87BD970", Offset = "0x87BC370", VA = "0x1887BD970")]
		public float2[] PMXBMLPSSTR(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x87BE430", Offset = "0x87BCE30", VA = "0x1887BE430")]
		public float2[] RPVRSKWOVAF(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x87BA800", Offset = "0x87B9200", VA = "0x1887BA800")]
		public float3[] BEWFUFTELYO(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x87BB170", Offset = "0x87B9B70", VA = "0x1887BB170")]
		public float3[] ELLIAMIEQOO(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x87BB510", Offset = "0x87B9F10", VA = "0x1887BB510")]
		public float4[] FINYKTOKQHT(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x87BD600", Offset = "0x87BC000", VA = "0x1887BD600")]
		public float4[] PKPSKEZMION(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x87BE9C0", Offset = "0x87BD3C0", VA = "0x1887BE9C0")]
		public float4[] VOCRIJSIGMO(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x87BC430", Offset = "0x87BAE30", VA = "0x1887BC430")]
		public float3[] IYFWYYVWBJH(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x87BC320", Offset = "0x87BAD20", VA = "0x1887BC320")]
		public float3[] ICGEQVMGFXI(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x87BED50", Offset = "0x87BD750", VA = "0x1887BED50")]
		public float4[] VYPGFGXKSGM(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x87BB120", Offset = "0x87B9B20", VA = "0x1887BB120")]
		public uint[] EBVQZPRFPQP(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x87BBA90", Offset = "0x87BA490", VA = "0x1887BBA90")]
		public float4x4[] GWSSYFXRKYG(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x87BDF50", Offset = "0x87BC950", VA = "0x1887BDF50")]
		private unsafe static float4 QXFFAFNTRAQ(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x87BDDD0", Offset = "0x87BC7D0", VA = "0x1887BDDD0")]
		private unsafe static float4 QXFFAFNTRAQ(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x87BEFE0", Offset = "0x87BD9E0", VA = "0x1887BEFE0")]
		private unsafe static float4x4 YJVAGPRVLUB(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x87BC040", Offset = "0x87BAA40", VA = "0x1887BC040")]
		private unsafe static float4 HAYDAZNCOTD(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x87BAB40", Offset = "0x87B9540", VA = "0x1887BAB40")]
		private unsafe static float3 CVLITZECNFA(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x87BC850", Offset = "0x87BB250", VA = "0x1887BC850")]
		private unsafe static float2 NLBHVHBWWHV(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x87BB950", Offset = "0x87BA350", VA = "0x1887BB950")]
		private unsafe static uint FSDYCYEVAYO(void* a, uint b, GLTFComponentType c)
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
	public static class FFOCDQLJWDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x87DB500", Offset = "0x87D9F00", VA = "0x1887DB500")]
		public static int OCTQWBGDJRG(this GLTFAccessorAttributeType a)
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
	public class CDAJGEQBZQJ : XZHBEOOYVKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int DJHUXMLNUTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public VKPNPRCQQVA NMZIGINVPSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public ZEPCDKQLPSD MJYZWWJBCJK;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x87D5D60", Offset = "0x87D4760", VA = "0x1887D5D60")]
		public CDAJGEQBZQJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x87D5960", Offset = "0x87D4360", VA = "0x1887D5960")]
		public static CDAJGEQBZQJ Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x87D5C30", Offset = "0x87D4630", VA = "0x1887D5C30", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class VKPNPRCQQVA : XZHBEOOYVKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public OLNWMRVLZRW SFMCWQKOYSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int RLUAPHMOIMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType JCUCTRDLLXL;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x87E60C0", Offset = "0x87E4AC0", VA = "0x1887E60C0")]
		public VKPNPRCQQVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x87E5CA0", Offset = "0x87E46A0", VA = "0x1887E5CA0")]
		public static VKPNPRCQQVA Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x87E5F80", Offset = "0x87E4980", VA = "0x1887E5F80", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ZEPCDKQLPSD : XZHBEOOYVKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public OLNWMRVLZRW SFMCWQKOYSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int RLUAPHMOIMX;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x87EAA70", Offset = "0x87E9470", VA = "0x1887EAA70")]
		public ZEPCDKQLPSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x87EA6F0", Offset = "0x87E90F0", VA = "0x1887EA6F0")]
		public static ZEPCDKQLPSD Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x87EA970", Offset = "0x87E9370", VA = "0x1887EA970", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class PKZNDHEUOST : XZHBEOOYVKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public DMUHAAVBIDL YFXLDNFIGIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public SHFDGYGOMIS ZYFESKEKZAL;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x87DE9E0", Offset = "0x87DD3E0", VA = "0x1887DE9E0")]
		public PKZNDHEUOST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x87DE6F0", Offset = "0x87DD0F0", VA = "0x1887DE6F0")]
		public static PKZNDHEUOST Deserialize(DHMXSGPLOHN root, JsonReader reader, EVMLVNQTTFR anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x87DE8E0", Offset = "0x87DD2E0", VA = "0x1887DE8E0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class SHFDGYGOMIS : XZHBEOOYVKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public SCHRROBVJVZ QQDUHQODGUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string YIQIZCZRVIJ;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x87E3A30", Offset = "0x87E2430", VA = "0x1887E3A30")]
		public static SHFDGYGOMIS Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x87E3DB0", Offset = "0x87E27B0", VA = "0x1887E3DB0")]
		public SHFDGYGOMIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x87E3C90", Offset = "0x87E2690", VA = "0x1887E3C90", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
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
	public class JYXZUXAOCOB
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(JYXZUXAOCOB data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] KWWMMLMRSDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type YHPQFHHAZDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] EAGKEVPACVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion IUCTSPKDERT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string KXJVVRMEAHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string CSIZUNGWKBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public GLFFZJOSQQR PZTYNMXMXEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string MYTRIKSZZCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string BHTGKUAGCXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public GLFFZJOSQQR MMACKUMWXKI;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x87DCB60", Offset = "0x87DB560", VA = "0x1887DCB60")]
		public JYXZUXAOCOB()
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
	public class TCZFYMUKRGM : XZHBEOOYVKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public NXKRISSFYEA ASYGBBYORDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType AOXEHDJPUEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public NXKRISSFYEA VTBACVNEQYH;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x87E49C0", Offset = "0x87E33C0", VA = "0x1887E49C0")]
		public TCZFYMUKRGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x87E4630", Offset = "0x87E3030", VA = "0x1887E4630")]
		public static TCZFYMUKRGM Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x87E4850", Offset = "0x87E3250", VA = "0x1887E4850", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class GEOXHZHDAHM : XZHBEOOYVKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string QJJWJCMAPAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string OPGKTWKNCSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string VHWQLHXUYAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string WMVXFGGUCPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> OPGQAQHGQFA;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x87DC050", Offset = "0x87DAA50", VA = "0x1887DC050")]
		public GEOXHZHDAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x87DB560", Offset = "0x87D9F60", VA = "0x1887DB560")]
		public static GEOXHZHDAHM Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x87DB880", Offset = "0x87DA280", VA = "0x1887DB880", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x87DC040", Offset = "0x87DAA40", VA = "0x1887DC040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x87DBCA0", Offset = "0x87DA6A0", VA = "0x1887DBCA0")]
		public string SFXAXROLCZM(bool a)
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
	public class SFMCWQKOYSV : FEXFGYBIPXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public LBCZHGYSSJD FPESKXAEFWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint RLUAPHMOIMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint MWKTBGJUSOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint HQFXNRTVKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget ZYFESKEKZAL;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x87DB430", Offset = "0x87D9E30", VA = "0x1887DB430")]
		public SFMCWQKOYSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x87E3570", Offset = "0x87E1F70", VA = "0x1887E3570")]
		public static SFMCWQKOYSV Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x87E3820", Offset = "0x87E2220", VA = "0x1887E3820", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class JOPWHNFTHGT : XZHBEOOYVKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double VFYSIXRQATL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double XPCCCMZKUAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double BQZVMTQZZJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double YJMUKRKVXXE;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x87DC770", Offset = "0x87DB170", VA = "0x1887DC770")]
		public JOPWHNFTHGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x87DC280", Offset = "0x87DAC80", VA = "0x1887DC280")]
		public static JOPWHNFTHGT Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x87DC600", Offset = "0x87DB000", VA = "0x1887DC600", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class VWVSXFDSLNP : XZHBEOOYVKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double WPQWBMUMULP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double NOCHKLPTUVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double BQZVMTQZZJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double YJMUKRKVXXE;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x87E6950", Offset = "0x87E5350", VA = "0x1887E6950")]
		public VWVSXFDSLNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x87E6450", Offset = "0x87E4E50", VA = "0x1887E6450")]
		public static VWVSXFDSLNP Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x87E67C0", Offset = "0x87E51C0", VA = "0x1887E67C0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class EVMLVNQTTFR : FEXFGYBIPXR
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public DHMXSGPLOHN VQTHZPRYINY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader QAFMVBJJKQR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public EVMLVNQTTFR ILJKBHWAODW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<PKZNDHEUOST> XZCUBOGIXAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<TCZFYMUKRGM> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x87E69C0", Offset = "0x87E53C0", VA = "0x1887E69C0")]
			internal PKZNDHEUOST UNLSJXCAETX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x87E69B0", Offset = "0x87E53B0", VA = "0x1887E69B0")]
			internal TCZFYMUKRGM UNGLMQICVIO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<PKZNDHEUOST> MDJYMVDPOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<TCZFYMUKRGM> NJRSZDRPAGX;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x87DA530", Offset = "0x87D8F30", VA = "0x1887DA530")]
		public static EVMLVNQTTFR Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x87DAC90", Offset = "0x87D9690", VA = "0x1887DAC90")]
		public EVMLVNQTTFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x87DA8F0", Offset = "0x87D92F0", VA = "0x1887DA8F0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class PXISTOSSRMJ : FEXFGYBIPXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string XUVXAQDITQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint MWKTBGJUSOE;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x87DB430", Offset = "0x87D9E30", VA = "0x1887DB430")]
		public PXISTOSSRMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x87DEC70", Offset = "0x87DD670", VA = "0x1887DEC70")]
		public static PXISTOSSRMJ Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x87DEE40", Offset = "0x87DD840", VA = "0x1887DEE40", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class JUBJZMDKYWU : FEXFGYBIPXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public JOPWHNFTHGT DOXBSWUEKHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public VWVSXFDSLNP MSYCTUQJFVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType AFHKRTOWHTU;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x87DB430", Offset = "0x87D9E30", VA = "0x1887DB430")]
		public JUBJZMDKYWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x87DC7C0", Offset = "0x87DB1C0", VA = "0x1887DC7C0")]
		public static JUBJZMDKYWU Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x87DC990", Offset = "0x87DB390", VA = "0x1887DC990", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
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
	public class FEXFGYBIPXR : XZHBEOOYVKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string EDJPGUEQTOV;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x87DB430", Offset = "0x87D9E30", VA = "0x1887DB430")]
		public FEXFGYBIPXR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x87DB480", Offset = "0x87D9E80", VA = "0x1887DB480")]
		public FEXFGYBIPXR(FEXFGYBIPXR a, DHMXSGPLOHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x87DB2B0", Offset = "0x87D9CB0", VA = "0x1887DB2B0")]
		public new void ETCHANRQFWR(DHMXSGPLOHN a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x87DB3A0", Offset = "0x87D9DA0", VA = "0x1887DB3A0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class QIZRGVLSZGF<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int JQHSIUZOJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public DHMXSGPLOHN DVPPDBTFFRU;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected QIZRGVLSZGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7602BC0", Offset = "0x76015C0", VA = "0x187602BC0")]
		public QIZRGVLSZGF(QIZRGVLSZGF<a> a, DHMXSGPLOHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7602B90", Offset = "0x7601590", VA = "0x187602B90")]
		public void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class NXKRISSFYEA : QIZRGVLSZGF<CRTLZRZAKNL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override CRTLZRZAKNL Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x87DD300", Offset = "0x87DBD00", VA = "0x1887DD300", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x87DD2C0", Offset = "0x87DBCC0", VA = "0x1887DD2C0")]
		public NXKRISSFYEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x87DD260", Offset = "0x87DBC60", VA = "0x1887DD260")]
		public NXKRISSFYEA(NXKRISSFYEA a, DHMXSGPLOHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x87DD180", Offset = "0x87DBB80", VA = "0x1887DD180")]
		public static NXKRISSFYEA Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class LBCZHGYSSJD : QIZRGVLSZGF<PXISTOSSRMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override PXISTOSSRMJ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x87DCF00", Offset = "0x87DB900", VA = "0x1887DCF00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x87DCEC0", Offset = "0x87DB8C0", VA = "0x1887DCEC0")]
		public LBCZHGYSSJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x87DCDE0", Offset = "0x87DB7E0", VA = "0x1887DCDE0")]
		public static LBCZHGYSSJD Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class OLNWMRVLZRW : QIZRGVLSZGF<SFMCWQKOYSV>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override SFMCWQKOYSV Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x87DE410", Offset = "0x87DCE10", VA = "0x1887DE410", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x87DE3D0", Offset = "0x87DCDD0", VA = "0x1887DE3D0")]
		public OLNWMRVLZRW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x87DE2F0", Offset = "0x87DCCF0", VA = "0x1887DE2F0")]
		public static OLNWMRVLZRW Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class LJGMBHYWLEE : QIZRGVLSZGF<JUBJZMDKYWU>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override JUBJZMDKYWU Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x87DD080", Offset = "0x87DBA80", VA = "0x1887DD080", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x87DD040", Offset = "0x87DBA40", VA = "0x1887DD040")]
		public LJGMBHYWLEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x87DCF60", Offset = "0x87DB960", VA = "0x1887DCF60")]
		public static LJGMBHYWLEE Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class HCLYIPZQKAW : QIZRGVLSZGF<UTUNWJBFZGM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override UTUNWJBFZGM Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x87DC210", Offset = "0x87DAC10", VA = "0x1887DC210", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x87DC1D0", Offset = "0x87DABD0", VA = "0x1887DC1D0")]
		public HCLYIPZQKAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x87DC0F0", Offset = "0x87DAAF0", VA = "0x1887DC0F0")]
		public static HCLYIPZQKAW Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class KPOSVXLPGBE : QIZRGVLSZGF<EVIUQDSKSUG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override EVIUQDSKSUG Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x87DCD80", Offset = "0x87DB780", VA = "0x1887DCD80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x87DCCE0", Offset = "0x87DB6E0", VA = "0x1887DCCE0")]
		public KPOSVXLPGBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x87DCD20", Offset = "0x87DB720", VA = "0x1887DCD20")]
		public KPOSVXLPGBE(KPOSVXLPGBE a, DHMXSGPLOHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x87DCC00", Offset = "0x87DB600", VA = "0x1887DCC00")]
		public static KPOSVXLPGBE Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class SPUTBLGMWBI : QIZRGVLSZGF<THBPYQEABHY>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override THBPYQEABHY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x87E40A0", Offset = "0x87E2AA0", VA = "0x1887E40A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x87E4060", Offset = "0x87E2A60", VA = "0x1887E4060")]
		public SPUTBLGMWBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x87E3F80", Offset = "0x87E2980", VA = "0x1887E3F80")]
		public static SPUTBLGMWBI Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SCHRROBVJVZ : QIZRGVLSZGF<QQDUHQODGUC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override QQDUHQODGUC Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x87E3510", Offset = "0x87E1F10", VA = "0x1887E3510", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x87E34D0", Offset = "0x87E1ED0", VA = "0x1887E34D0")]
		public SCHRROBVJVZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x87E33F0", Offset = "0x87E1DF0", VA = "0x1887E33F0")]
		public static SCHRROBVJVZ Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x87E3180", Offset = "0x87E1B80", VA = "0x1887E3180")]
		public static List<SCHRROBVJVZ> BIDENYGCTXA(DHMXSGPLOHN a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class ZIXGUPAIPMT : QIZRGVLSZGF<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x87EAFF0", Offset = "0x87E99F0", VA = "0x1887EAFF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x87EAFB0", Offset = "0x87E99B0", VA = "0x1887EAFB0")]
		public ZIXGUPAIPMT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x87EAED0", Offset = "0x87E98D0", VA = "0x1887EAED0")]
		public static ZIXGUPAIPMT Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class DMUHAAVBIDL : QIZRGVLSZGF<TCZFYMUKRGM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public EVMLVNQTTFR EVMLVNQTTFR;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override TCZFYMUKRGM Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x87D9640", Offset = "0x87D8040", VA = "0x1887D9640", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x87D9600", Offset = "0x87D8000", VA = "0x1887D9600")]
		public DMUHAAVBIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x87D9500", Offset = "0x87D7F00", VA = "0x1887D9500")]
		public static DMUHAAVBIDL Deserialize(DHMXSGPLOHN root, EVMLVNQTTFR anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class SMYUXMBVAVZ : QIZRGVLSZGF<ZNGCOPYPWSZ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override ZNGCOPYPWSZ Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x87E3F20", Offset = "0x87E2920", VA = "0x1887E3F20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x87E3EE0", Offset = "0x87E28E0", VA = "0x1887E3EE0")]
		public SMYUXMBVAVZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x87E3E00", Offset = "0x87E2800", VA = "0x1887E3E00")]
		public static SMYUXMBVAVZ Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class DIEYGWIOZMK : QIZRGVLSZGF<WYFBQFSFMQD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override WYFBQFSFMQD Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x87D94A0", Offset = "0x87D7EA0", VA = "0x1887D94A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x87D9460", Offset = "0x87D7E60", VA = "0x1887D9460")]
		public DIEYGWIOZMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x87D9380", Offset = "0x87D7D80", VA = "0x1887D9380")]
		public static DIEYGWIOZMK Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class RASULIXSJAA : QIZRGVLSZGF<XKUWQZBBHKG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override XKUWQZBBHKG Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x87E07A0", Offset = "0x87DF1A0", VA = "0x1887E07A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x87E0700", Offset = "0x87DF100", VA = "0x1887E0700")]
		public RASULIXSJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x87E0740", Offset = "0x87DF140", VA = "0x1887E0740")]
		public RASULIXSJAA(RASULIXSJAA a, DHMXSGPLOHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x87E0620", Offset = "0x87DF020", VA = "0x1887E0620")]
		public static RASULIXSJAA Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class MCAJMGEKIAP : QIZRGVLSZGF<ONHCQHTIZQF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override ONHCQHTIZQF Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x87DD120", Offset = "0x87DBB20", VA = "0x1887DD120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x87DD0E0", Offset = "0x87DBAE0", VA = "0x1887DD0E0")]
		public MCAJMGEKIAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class UTUNWJBFZGM : FEXFGYBIPXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string XUVXAQDITQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string MEVBDAWSKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public OLNWMRVLZRW SFMCWQKOYSV;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x87DB430", Offset = "0x87D9E30", VA = "0x1887DB430")]
		public UTUNWJBFZGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x87E5890", Offset = "0x87E4290", VA = "0x1887E5890")]
		public static UTUNWJBFZGM Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x87E5AD0", Offset = "0x87E44D0", VA = "0x1887E5AD0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class EVIUQDSKSUG : FEXFGYBIPXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public OGKTDMWFYLV OGKTDMWFYLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public YMIVCOQPGMK VDPZYOMHZXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ZSDUAGLNAXC OKKHXKAJJJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public ZFOBVVNNDNE UKWIACEAWEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public YLAXURNXFQN SOHCXCSTELK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color HMRSGQPRAWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode MCDJCTMSSTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double SZZWNGDWCXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool OSQORVHNFXC;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x87DA4C0", Offset = "0x87D8EC0", VA = "0x1887DA4C0")]
		public EVIUQDSKSUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x87D9B50", Offset = "0x87D8550", VA = "0x1887D9B50")]
		public static EVIUQDSKSUG Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x87DA060", Offset = "0x87D8A60", VA = "0x1887DA060", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
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
	public class THBPYQEABHY : FEXFGYBIPXR
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public DHMXSGPLOHN VQTHZPRYINY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader QAFMVBJJKQR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<RNXRSEFMBIY> XZCUBOGIXAH;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x87DC270", Offset = "0x87DAC70", VA = "0x1887DC270")]
			internal RNXRSEFMBIY UNLSJXCAETX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<RNXRSEFMBIY> MJPPBKFUGUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> VOBYQRNXSLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> KWXNAMDSCGZ;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x87DB430", Offset = "0x87D9E30", VA = "0x1887DB430")]
		public THBPYQEABHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x87E4A10", Offset = "0x87E3410", VA = "0x1887E4A10")]
		public static THBPYQEABHY Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x87E4DD0", Offset = "0x87E37D0", VA = "0x1887E4DD0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class XZHBEOOYVKW
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, BECZHEOEFJV> MNKMHKLPMHF;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static VOCXHTFYCJQ KUPYPXGGBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, XEMVEUNMABQ> PTVQYPAQQVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken WWQFUKXOMKB;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x87E8950", Offset = "0x87E7350", VA = "0x1887E8950")]
		public static BECZHEOEFJV XZDSBUCOGVE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x87E8420", Offset = "0x87E6E20", VA = "0x1887E8420")]
		public static XEMVEUNMABQ NHXWQUTPSEQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public XZHBEOOYVKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x87E9460", Offset = "0x87E7E60", VA = "0x1887E9460")]
		public XZHBEOOYVKW(XZHBEOOYVKW a, [Optional] DHMXSGPLOHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x87E7FC0", Offset = "0x87E69C0", VA = "0x1887E7FC0")]
		public void ETCHANRQFWR(DHMXSGPLOHN a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x87E8AE0", Offset = "0x87E74E0", VA = "0x1887E8AE0")]
		public void YSKAKUNDPNM(string a, XEMVEUNMABQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x87E8330", Offset = "0x87E6D30", VA = "0x1887E8330")]
		private void LJSLTTCIDCK(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x87E8270", Offset = "0x87E6C70", VA = "0x1887E8270")]
		private void JQXGOCFINKS(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x87E8890", Offset = "0x87E7290", VA = "0x1887E8890")]
		private void OCREQPIVCJM(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x87E79E0", Offset = "0x87E63E0", VA = "0x1887E79E0")]
		internal static Dictionary<string, XEMVEUNMABQ> BNFUYMFFOJZ(DHMXSGPLOHN a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x87E8510", Offset = "0x87E6F10", VA = "0x1887E8510", Slot = "4")]
		public virtual void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class DHMXSGPLOHN : XZHBEOOYVKW
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class EAFIVIHKRYC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public DHMXSGPLOHN VQTHZPRYINY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader GIIVKUBHUAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<CRTLZRZAKNL> XZCUBOGIXAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<EVMLVNQTTFR> XYXNEHMLNOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<PXISTOSSRMJ> XZNHWBUDPWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<SFMCWQKOYSV> XZIAYVAGGLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<JUBJZMDKYWU> XZXVQPHYITR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<UTUNWJBFZGM> XZSOTIOAZII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<EVIUQDSKSUG> YAIJLCVTBQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<THBPYQEABHY> YADCNWBVSFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<QQDUHQODGUC> YASXFQJNUNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> YANQIJPQLBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<ZNGCOPYPWSZ> BVILBCMOOZO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<WYFBQFSFMQD> BVNRYJGLYKX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<XKUWQZBBHKG> BVSYVQAJHWG;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EAFIVIHKRYC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x87D98B0", Offset = "0x87D82B0", VA = "0x1887D98B0")]
			internal CRTLZRZAKNL UNLSJXCAETX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x87D98A0", Offset = "0x87D82A0", VA = "0x1887D98A0")]
			internal EVMLVNQTTFR UNGLMQICVIO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x87D9890", Offset = "0x87D8290", VA = "0x1887D9890")]
			internal PXISTOSSRMJ UNBEPJOFLXF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x87D9880", Offset = "0x87D8280", VA = "0x1887D9880")]
			internal SFMCWQKOYSV UMVXSCUICLW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x87D9870", Offset = "0x87D8270", VA = "0x1887D9870")]
			internal JUBJZMDKYWU UMQQUWAKTAN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x87D9860", Offset = "0x87D8260", VA = "0x1887D9860")]
			internal UTUNWJBFZGM UMLJXPGNJPE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x87D9850", Offset = "0x87D8250", VA = "0x1887D9850")]
			internal EVIUQDSKSUG UMGDAIMQADV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x87D9840", Offset = "0x87D8240", VA = "0x1887D9840")]
			internal THBPYQEABHY UMAWDBSSQSM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x87D98D0", Offset = "0x87D82D0", VA = "0x1887D98D0")]
			internal QQDUHQODGUC UPBVNZFFCGR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x87D98C0", Offset = "0x87D82C0", VA = "0x1887D98C0")]
			internal Sampler UOWOQSLHSVI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x87D96B0", Offset = "0x87D80B0", VA = "0x1887D96B0")]
			internal ZNGCOPYPWSZ GECWGWTSFZY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x87D9830", Offset = "0x87D8230", VA = "0x1887D9830")]
			internal WYFBQFSFMQD GEIDEDNPPLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x87D96A0", Offset = "0x87D80A0", VA = "0x1887D96A0")]
			internal XKUWQZBBHKG GDSIMJFXNDG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> ROLYKZHHGZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> FRFKIVBKGCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<CRTLZRZAKNL> JSHOVPNSTKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<EVMLVNQTTFR> UNHQHGVLNXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public GEOXHZHDAHM GEOXHZHDAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<PXISTOSSRMJ> EJJNRUAWYUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<SFMCWQKOYSV> GPXOYLDKUVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<JUBJZMDKYWU> KQWEJKFGRWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<UTUNWJBFZGM> BHZMNXBOQGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<EVIUQDSKSUG> DPJEXMZTJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<THBPYQEABHY> FHRFPBCKFKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<QQDUHQODGUC> HZEYEEWZDKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> NJRSZDRPAGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public SMYUXMBVAVZ IGLINQVWMTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<ZNGCOPYPWSZ> GBTUYHMWMWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<WYFBQFSFMQD> RQFPDUFFMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<XKUWQZBBHKG> CJPSDGXQDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<ONHCQHTIZQF> DEWBWNGZKTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool SQTWKKOAFOR;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x87D9330", Offset = "0x87D7D30", VA = "0x1887D9330")]
		public DHMXSGPLOHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x87D9290", Offset = "0x87D7C90", VA = "0x1887D9290")]
		public ZNGCOPYPWSZ TKOBVUUAQGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x87D6890", Offset = "0x87D5290", VA = "0x1887D6890")]
		public static DHMXSGPLOHN Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x87D76E0", Offset = "0x87D60E0", VA = "0x1887D76E0")]
		public void NZJDRENIZKU(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class ZNGCOPYPWSZ : FEXFGYBIPXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<SCHRROBVJVZ> HZEYEEWZDKT;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x87DB430", Offset = "0x87D9E30", VA = "0x1887DB430")]
		public ZNGCOPYPWSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x87EB050", Offset = "0x87E9A50", VA = "0x1887EB050")]
		public static ZNGCOPYPWSZ Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x87EB1D0", Offset = "0x87E9BD0", VA = "0x1887EB1D0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class XKUWQZBBHKG : FEXFGYBIPXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ZIXGUPAIPMT YFXLDNFIGIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public HCLYIPZQKAW OJVFMXAVMLN;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x87DB430", Offset = "0x87D9E30", VA = "0x1887DB430")]
		public XKUWQZBBHKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x87E7100", Offset = "0x87E5B00", VA = "0x1887E7100")]
		public static XKUWQZBBHKG Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x87E72D0", Offset = "0x87E5CD0", VA = "0x1887E72D0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class QDIUFJTEYGT : ONHCQHTIZQF
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x87DB430", Offset = "0x87D9E30", VA = "0x1887DB430")]
		public QDIUFJTEYGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x87DEF90", Offset = "0x87DD990", VA = "0x1887DEF90", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class ONHCQHTIZQF : FEXFGYBIPXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string AJEKOIXQXIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color MNJUFNZIYGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string ONBAXEIQBBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float DBAYEGEIXZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float XDEOAQJDJRV;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x87DB430", Offset = "0x87D9E30", VA = "0x1887DB430")]
		public ONHCQHTIZQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x87DE470", Offset = "0x87DCE70", VA = "0x1887DE470", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class ZYRCHAEWPFD : ONHCQHTIZQF
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x87DB430", Offset = "0x87D9E30", VA = "0x1887DB430")]
		public ZYRCHAEWPFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x87DEF90", Offset = "0x87DD990", VA = "0x1887DEF90", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class XUEIQPQXIYZ : ONHCQHTIZQF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float TAPOYKAIJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float FJSUKFOEMPT;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x87E7990", Offset = "0x87E6390", VA = "0x1887E7990")]
		public XUEIQPQXIYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x87E7690", Offset = "0x87E6090", VA = "0x1887E7690", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface VBLTZITKXAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NGCOMWLNHOH(DHMXSGPLOHN a, QGBEMVWMRGA b, [Out] JYXZUXAOCOB c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface XEMVEUNMABQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		XEMVEUNMABQ Clone(DHMXSGPLOHN root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class BECZHEOEFJV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string AKHFJCCDIZS;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected BECZHEOEFJV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class BTECFOGGABK : XEMVEUNMABQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty GDQEEMHXUYX
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x87D58B0", Offset = "0x87D42B0", VA = "0x1887D58B0", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public BTECFOGGABK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class VOCXHTFYCJQ : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x87E6110", Offset = "0x87E4B10", VA = "0x1887E6110", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public VOCXHTFYCJQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class YMIVCOQPGMK : XZHBEOOYVKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color NPMZSGNZZNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public YLAXURNXFQN UUMNWJTXVVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color KDIQPHWTCJN;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x87EA680", Offset = "0x87E9080", VA = "0x1887EA680")]
		public YMIVCOQPGMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x87EA180", Offset = "0x87E8B80", VA = "0x1887EA180")]
		public static YMIVCOQPGMK Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x87EA420", Offset = "0x87E8E20", VA = "0x1887EA420", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class ZSDUAGLNAXC : YLAXURNXFQN
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string WJIONXCUXQQ = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double OHFXQNDZZMY;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x87EAE70", Offset = "0x87E9870", VA = "0x1887EAE70")]
		public ZSDUAGLNAXC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x87EB440", Offset = "0x87E9E40", VA = "0x1887EB440")]
		public new static ZSDUAGLNAXC Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x87EB730", Offset = "0x87EA130", VA = "0x1887EB730", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ZFOBVVNNDNE : YLAXURNXFQN
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string ZGWTIKMAAHB = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double LIBRDDLMHLN;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x87EAE70", Offset = "0x87E9870", VA = "0x1887EAE70")]
		public ZFOBVVNNDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x87EAAC0", Offset = "0x87E94C0", VA = "0x1887EAAC0")]
		public new static ZFOBVVNNDNE Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x87EADB0", Offset = "0x87E97B0", VA = "0x1887EADB0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class OGKTDMWFYLV : XZHBEOOYVKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color FWBVXEQZKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public YLAXURNXFQN VTEKQZMWALX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double FIPMRNAVKCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double USPPIIMYDQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public YLAXURNXFQN ZIUEXMEBJLA;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x87DD960", Offset = "0x87DC360", VA = "0x1887DD960")]
		public OGKTDMWFYLV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x87DD360", Offset = "0x87DBD60", VA = "0x1887DD360")]
		public static OGKTDMWFYLV Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x87DD6D0", Offset = "0x87DC0D0", VA = "0x1887DD6D0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class RNXRSEFMBIY : XZHBEOOYVKW
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class XPQTJHQZHON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader QAFMVBJJKQR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public DHMXSGPLOHN VQTHZPRYINY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<NXKRISSFYEA> XZCUBOGIXAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<NXKRISSFYEA> XZNHWBUDPWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, NXKRISSFYEA>> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XPQTJHQZHON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x87E75C0", Offset = "0x87E5FC0", VA = "0x1887E75C0")]
			internal NXKRISSFYEA UNLSJXCAETX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x87E7510", Offset = "0x87E5F10", VA = "0x1887E7510")]
			internal Dictionary<string, NXKRISSFYEA> UNGLMQICVIO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x87E7440", Offset = "0x87E5E40", VA = "0x1887E7440")]
			internal NXKRISSFYEA UNBEPJOFLXF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, NXKRISSFYEA> QJQVGSBXVBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public NXKRISSFYEA NMZIGINVPSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public KPOSVXLPGBE HSIUGFJSEDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode EPJXKROSIIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, NXKRISSFYEA>> VEJUCFUQIYU;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x87E30E0", Offset = "0x87E1AE0", VA = "0x1887E30E0")]
		public RNXRSEFMBIY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x87E2A40", Offset = "0x87E1440", VA = "0x1887E2A40")]
		public RNXRSEFMBIY(RNXRSEFMBIY a, DHMXSGPLOHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x87E29A0", Offset = "0x87E13A0", VA = "0x1887E29A0")]
		public static int[] ZMQAMUHQUYO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x87E2610", Offset = "0x87E1010", VA = "0x1887E2610")]
		public static int[] TECHFURUSVI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x87E2770", Offset = "0x87E1170", VA = "0x1887E2770")]
		public static int[] VXATQHEDIVK(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x87E1CB0", Offset = "0x87E06B0", VA = "0x1887E1CB0")]
		public static int[] FUEJLQGHPDO(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x87E1F00", Offset = "0x87E0900", VA = "0x1887E1F00")]
		public static int[] KMCHQZHXOSD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x87E25A0", Offset = "0x87E0FA0", VA = "0x1887E25A0")]
		public static int[] SHCGEUMALMW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x87E1740", Offset = "0x87E0140", VA = "0x1887E1740")]
		public static int[] DIKYNSPIDEE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x87E2930", Offset = "0x87E1330", VA = "0x1887E2930")]
		public static int[] YNMETIRHJFV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x87E1C20", Offset = "0x87E0620", VA = "0x1887E1C20")]
		public static int[] EZJFWUWEDYN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x87E17D0", Offset = "0x87E01D0", VA = "0x1887E17D0")]
		public static RNXRSEFMBIY Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x87E1FB0", Offset = "0x87E09B0", VA = "0x1887E1FB0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class VWHGFKCWERB
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] JLSIGKLKTRK;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] SBTEGNBQFBT;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] IVVPSXNMEFU;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] ILECFOPLKSG;
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
	public class QQDUHQODGUC : FEXFGYBIPXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool SBRNGJWACSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public LJGMBHYWLEE CSJMWMCKLDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<SCHRROBVJVZ> IXEJHKRESMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public DIEYGWIOZMK WYFBQFSFMQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public FFCXZMVQUPL BIKBMBKISQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public SPUTBLGMWBI GQBKHMYYRID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion MNYYIPRVPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 OHFXQNDZZMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 PZEZNDVNDRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> VOBYQRNXSLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public MCAJMGEKIAP GZBXQBXSJXY;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x87E04E0", Offset = "0x87DEEE0", VA = "0x1887E04E0")]
		public QQDUHQODGUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x87DEFA0", Offset = "0x87DD9A0", VA = "0x1887DEFA0")]
		public static QQDUHQODGUC Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x87DF8E0", Offset = "0x87DE2E0", VA = "0x1887DF8E0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : FEXFGYBIPXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode DGBLTTHBTED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode AADKPWWYXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode WPMOOSXRFLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode WQMXBATEAQK;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x87E45C0", Offset = "0x87E2FC0", VA = "0x1887E45C0")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x87E4100", Offset = "0x87E2B00", VA = "0x1887E4100")]
		public static Sampler Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x87E43D0", Offset = "0x87E2DD0", VA = "0x1887E43D0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
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
	public class WYFBQFSFMQD : FEXFGYBIPXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NXKRISSFYEA MDDCUEFTLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public SCHRROBVJVZ ECDEOIQVXRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<SCHRROBVJVZ> MRRJWBFNYZZ;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x87E7050", Offset = "0x87E5A50", VA = "0x1887E7050")]
		public WYFBQFSFMQD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x87E69E0", Offset = "0x87E53E0", VA = "0x1887E69E0")]
		public static WYFBQFSFMQD Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x87E6D40", Offset = "0x87E5740", VA = "0x1887E6D40", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class YLAXURNXFQN : XZHBEOOYVKW
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string DDSXJNCHKFQ = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string QBNWBCABZWI = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public RASULIXSJAA IALPIRBUUYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int JLSIGKLKTRK;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x87EA130", Offset = "0x87E8B30", VA = "0x1887EA130")]
		public YLAXURNXFQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x87EA040", Offset = "0x87E8A40", VA = "0x1887EA040")]
		public YLAXURNXFQN(YLAXURNXFQN a, DHMXSGPLOHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x87E9C90", Offset = "0x87E8690", VA = "0x1887E9C90")]
		public static YLAXURNXFQN Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x87E9FE0", Offset = "0x87E89E0", VA = "0x1887E9FE0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x87E9F10", Offset = "0x87E8910", VA = "0x1887E9F10")]
		public void LFOVUFIBDEV(JsonWriter a)
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
	public class YFQFYKPMXJY
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double GULGBUMCKRS;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double ZGMSQRKQHLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double KJSODXIHWBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double TGWJPVLIHJT;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x87E9C10", Offset = "0x87E8610", VA = "0x1887E9C10")]
		public YFQFYKPMXJY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x87E9750", Offset = "0x87E8150", VA = "0x1887E9750")]
		public static YFQFYKPMXJY Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x87E99A0", Offset = "0x87E83A0", VA = "0x1887E99A0")]
		public void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class CESUOHUDFEE : FEXFGYBIPXR
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color BUDKQSEDVMT;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double OAXLNYSKMQB;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double THOZGBIZASB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType AFHKRTOWHTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color SBTEGNBQFBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double TVKHWSUCGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double HZJQOHIWHBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public YFQFYKPMXJY YFQFYKPMXJY;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x87D67D0", Offset = "0x87D51D0", VA = "0x1887D67D0")]
		public CESUOHUDFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x87D66A0", Offset = "0x87D50A0", VA = "0x1887D66A0")]
		public CESUOHUDFEE(CESUOHUDFEE a, DHMXSGPLOHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x87D5DB0", Offset = "0x87D47B0", VA = "0x1887D5DB0")]
		public static CESUOHUDFEE Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x87D61A0", Offset = "0x87D4BA0", VA = "0x1887D61A0")]
		public static CESUOHUDFEE Deserialize(DHMXSGPLOHN root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x87D62C0", Offset = "0x87D4CC0", VA = "0x1887D62C0", Slot = "4")]
		public override void NZJDRENIZKU(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class OJURAFMIHNA : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<ONHCQHTIZQF> GUHGRUHTXKL;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public OJURAFMIHNA(IList<ONHCQHTIZQF> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x87DDA40", Offset = "0x87DC440", VA = "0x1887DDA40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x87DD9D0", Offset = "0x87DC3D0", VA = "0x1887DD9D0", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class RFOHYMPHEGS : XEMVEUNMABQ, VBLTZITKXAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<CESUOHUDFEE> DEWBWNGZKTV;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x87E16C0", Offset = "0x87E00C0", VA = "0x1887E16C0")]
		public RFOHYMPHEGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x87E0800", Offset = "0x87DF200", VA = "0x1887E0800", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x87E15D0", Offset = "0x87DFFD0", VA = "0x1887E15D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x87E0A90", Offset = "0x87DF490", VA = "0x1887E0A90")]
		private static string[] FVLKFGTPSVS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x87E1130", Offset = "0x87DFB30", VA = "0x1887E1130")]
		private static JYXZUXAOCOB.ImportValuesConversion RFFZRQFPONI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x87E0D40", Offset = "0x87DF740", VA = "0x1887E0D40", Slot = "6")]
		public bool NGCOMWLNHOH(DHMXSGPLOHN a, QGBEMVWMRGA b, [Out] JYXZUXAOCOB c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class ECVBIEKHPQR : QIZRGVLSZGF<CESUOHUDFEE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override CESUOHUDFEE Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x87D9A00", Offset = "0x87D8400", VA = "0x1887D9A00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x87D99C0", Offset = "0x87D83C0", VA = "0x1887D99C0")]
		public ECVBIEKHPQR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x87D98E0", Offset = "0x87D82E0", VA = "0x1887D98E0")]
		public static ECVBIEKHPQR Deserialize(DHMXSGPLOHN root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class PTYKEMMQWLY : XEMVEUNMABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public ECVBIEKHPQR MCAJMGEKIAP;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public PTYKEMMQWLY(ECVBIEKHPQR a, DHMXSGPLOHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x87DEBB0", Offset = "0x87DD5B0", VA = "0x1887DEBB0")]
		public PTYKEMMQWLY(int a, DHMXSGPLOHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x87DEA30", Offset = "0x87DD430", VA = "0x1887DEA30", Slot = "5")]
		public XEMVEUNMABQ Clone(DHMXSGPLOHN root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x87DEAB0", Offset = "0x87DD4B0", VA = "0x1887DEAB0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class FDJYYYLYRSH : BECZHEOEFJV
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x87DB260", Offset = "0x87D9C60", VA = "0x1887DB260")]
		public FDJYYYLYRSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x87DAD80", Offset = "0x87D9780", VA = "0x1887DAD80", Slot = "4")]
		public override XEMVEUNMABQ Deserialize(DHMXSGPLOHN root, JProperty extensionToken)
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
