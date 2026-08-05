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
	public class KHR_animation_pointer : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object MBUJEIRXPZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string DDGRPQDCFWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string XOMWWARBPPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public ZMLWMRNUPSM BPMVZQXWFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer RUYFZVDLSHR;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86531C0", Offset = "0x8651BC0", VA = "0x1886531C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8653110", Offset = "0x8651B10", VA = "0x188653110", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class RCEKFQAWJFH
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 OSIDUKOGOOW;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 QCVYODGEFSV;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion BATTROLAFJH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool AYJJHFMMFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x865A580", Offset = "0x8658F80", VA = "0x18865A580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8659FE0", Offset = "0x86589E0", VA = "0x188659FE0")]
		public static void BUWDECFJNEN(this KTFAJFRQMLO a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x865C1D0", Offset = "0x865ABD0", VA = "0x18865C1D0")]
		public static void XICEXUNLJAP(this KTFAJFRQMLO a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8659C10", Offset = "0x8658610", VA = "0x188659C10")]
		public static void BAEFCPLFBUK(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x865CF70", Offset = "0x865B970", VA = "0x18865CF70")]
		public static GLTF.Math.Vector4 ZASGYZEWAGC(this VMSWBTYKHIP a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x865B200", Offset = "0x8659C00", VA = "0x18865B200")]
		public static UnityEngine.Quaternion NQNTPNJIFRX(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x865B0D0", Offset = "0x8659AD0", VA = "0x18865B0D0")]
		public static UnityEngine.Quaternion NQNTPNJIFRX(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x865BD60", Offset = "0x865A760", VA = "0x18865BD60")]
		public static GLTF.Math.Quaternion WQCYIGTWXBN(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x865AEB0", Offset = "0x86598B0", VA = "0x18865AEB0")]
		public static Matrix4x4 MRIHGTOIKXG(this VMSWBTYKHIP a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x865AA70", Offset = "0x8659470", VA = "0x18865AA70")]
		public static Matrix4x4 MRIHGTOIKXG(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x865CC30", Offset = "0x865B630", VA = "0x18865CC30")]
		public static VMSWBTYKHIP YWRVDZYZFVM(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x865BA00", Offset = "0x865A400", VA = "0x18865BA00")]
		public static UnityEngine.Vector3 VKPECATTJNT(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x865BB20", Offset = "0x865A520", VA = "0x18865BB20")]
		public static UnityEngine.Vector3 VKPECATTJNT(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x865D190", Offset = "0x865BB90", VA = "0x18865D190")]
		public static GLTF.Math.Vector3 ZUBQZPJWAXR(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x865A610", Offset = "0x8659010", VA = "0x18865A610")]
		public static GLTF.Math.Vector3 FBNOUEWKYKK(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1371B00", Offset = "0x1370500", VA = "0x181371B00")]
		public static GLTF.Math.Vector4 VQWYPUMOGWF(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x865C700", Offset = "0x865B100", VA = "0x18865C700")]
		public static Matrix4x4 YNJBOQNXHGN(this VMSWBTYKHIP a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x865C9C0", Offset = "0x865B3C0", VA = "0x18865C9C0")]
		public static Matrix4x4 YNJBOQNXHGN(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x865B6D0", Offset = "0x865A0D0", VA = "0x18865B6D0")]
		public static VMSWBTYKHIP SUIFBIRBOVN(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x865D2C0", Offset = "0x865BCC0", VA = "0x18865D2C0")]
		public static UnityEngine.Vector2 ZVQOEANCLEN(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x865D2C0", Offset = "0x865BCC0", VA = "0x18865D2C0")]
		public static UnityEngine.Vector2 ZVQOEANCLEN(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x865D2E0", Offset = "0x865BCE0", VA = "0x18865D2E0")]
		public static void ZVQOEANCLEN(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8659BB0", Offset = "0x86585B0", VA = "0x188659BB0")]
		public static UnityEngine.Vector3 AABBNOJPYYE(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B430", Offset = "0x1D79E30", VA = "0x181D7B430")]
		public static UnityEngine.Vector3 AABBNOJPYYE(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8659AC0", Offset = "0x86584C0", VA = "0x188659AC0")]
		public static void AABBNOJPYYE(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1371B00", Offset = "0x1370500", VA = "0x181371B00")]
		public static UnityEngine.Vector4 XAVJYECSSSX(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1371B00", Offset = "0x1370500", VA = "0x181371B00")]
		public static UnityEngine.Vector4 XAVJYECSSSX(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x865BFB0", Offset = "0x865A9B0", VA = "0x18865BFB0")]
		public static UnityEngine.Vector4[] XAVJYECSSSX(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x865BEA0", Offset = "0x865A8A0", VA = "0x18865BEA0")]
		public static void XAVJYECSSSX(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x865A820", Offset = "0x8659220", VA = "0x18865A820")]
		public static UnityEngine.Color JGAUGLNWXFP(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x865A8C0", Offset = "0x86592C0", VA = "0x18865A8C0")]
		public static void JGAUGLNWXFP(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x865A820", Offset = "0x8659220", VA = "0x18865A820")]
		public static UnityEngine.Color JGAUGLNWXFP(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1371B00", Offset = "0x1370500", VA = "0x181371B00")]
		public static UnityEngine.Color NWTUYKRWROU(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x865B410", Offset = "0x8659E10", VA = "0x18865B410")]
		public static void NWTUYKRWROU(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1371B00", Offset = "0x1370500", VA = "0x181371B00")]
		public static UnityEngine.Color NWTUYKRWROU(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x865A650", Offset = "0x8659050", VA = "0x18865A650")]
		public static GLTF.Math.Color FXWWGACLUAW(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x865B5A0", Offset = "0x8659FA0", VA = "0x18865B5A0")]
		public static GLTF.Math.Color RBHUOMIWUQB(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x865B390", Offset = "0x8659D90", VA = "0x18865B390")]
		public static GLTF.Math.Color NRQCDOXNKSF(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x865C0B0", Offset = "0x865AAB0", VA = "0x18865C0B0")]
		public static UnityEngine.Color[] XEFLDPGVFPK(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x865B520", Offset = "0x8659F20", VA = "0x18865B520")]
		public static int[] QRNLSMSUIVJ(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x865B620", Offset = "0x865A020", VA = "0x18865B620")]
		public static UnityEngine.Vector2[] SIYCHIISQWY(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x865B8A0", Offset = "0x865A2A0", VA = "0x18865B8A0")]
		public static void UAUGWMLHIZN(LOWENHEWMHZ a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x865BC00", Offset = "0x865A600", VA = "0x18865BC00")]
		public static UnityEngine.Vector3[] VXCHFHSNUGR(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x865A680", Offset = "0x8659080", VA = "0x18865A680")]
		public static UnityEngine.Vector4[] HRVNTMRNFTK(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x865AA00", Offset = "0x8659400", VA = "0x18865AA00")]
		public static void KNRHVTOZFBB(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x865C6D0", Offset = "0x865B0D0", VA = "0x18865C6D0")]
		public static UnityEngine.Quaternion XYAQBIZZCZF(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LOWENHEWMHZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ZIYZUENAFOS ZIYZUENAFOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray VWXHGGDQQMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8656900", Offset = "0x8655300", VA = "0x188656900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> OMOFQZYQJPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xED3CD0", Offset = "0xED26D0", VA = "0x180ED3CD0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xFBA790", Offset = "0xFB9190", VA = "0x180FBA790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint RFBIZEQGAWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCFAD50", Offset = "0xCF9750", VA = "0x180CFAD50")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCFAF30", Offset = "0xCF9930", VA = "0x180CFAF30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8656910", Offset = "0x8655310", VA = "0x188656910")]
		public LOWENHEWMHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x864BE40", Offset = "0x864A840", VA = "0x18864BE40")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x864BEA0", Offset = "0x864A8A0", VA = "0x18864BEA0")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HBEKDNMQAHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class GRUZCNMEPCV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> FNVXWZZMUDV;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public GRUZCNMEPCV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x864BFD0", Offset = "0x864A9D0", VA = "0x18864BFD0")]
			internal int? UAYFZTOESZK(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x864C050", Offset = "0x864AA50", VA = "0x18864C050")]
			internal int? UKWRQSDAXHV(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x864BF00", Offset = "0x864A900", VA = "0x18864BF00")]
			internal bool CFYVYZFIQLR(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x864CB50", Offset = "0x864B550", VA = "0x18864CB50")]
		private static void NUJBGFOADJV(NumericArray a, LOWENHEWMHZ b, LOWENHEWMHZ c, LOWENHEWMHZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x864D2B0", Offset = "0x864BCB0", VA = "0x18864D2B0")]
		public static void QYCIXDRZYCY(Dictionary<string, LOWENHEWMHZ> a, Dictionary<string, (LOWENHEWMHZ sparseIndices, LOWENHEWMHZ sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x864C670", Offset = "0x864B070", VA = "0x18864C670")]
		public static void LUSQRIYNYNW(Dictionary<string, LOWENHEWMHZ> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x864E590", Offset = "0x864CF90", VA = "0x18864E590")]
		public static void RCZSKWGXDLB(LOWENHEWMHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x864C0E0", Offset = "0x864AAE0", VA = "0x18864C0E0")]
		public static void DBPJTNBLCRR(Dictionary<string, List<LOWENHEWMHZ>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x864D0C0", Offset = "0x864BAC0", VA = "0x18864D0C0")]
		private static void QPEMMBXKBHN(LOWENHEWMHZ a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x864D1F0", Offset = "0x864BBF0", VA = "0x18864D1F0")]
		internal static void QPEMMBXKBHN(UMJJFNXSQAT a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x864E690", Offset = "0x864D090", VA = "0x18864E690")]
		public static POILAGDGQRH VHSWLEMBXFB(IEnumerable<POILAGDGQRH> a)
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
			[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF4FFA0", VA = "0x180F515A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x15BB850", Offset = "0x15BA250", VA = "0x1815BB850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30BD680", Offset = "0x30BC080", VA = "0x1830BD680")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30BD690", Offset = "0x30BC090", VA = "0x1830BD690")]
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
	public class WVYWDPONLMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint PBUCYKJXFBJ;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint WZXZUQRSHUV;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint TWUWKHVYCSJ;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8664C80", Offset = "0x8663680", VA = "0x188664C80")]
		public static void LEAESNEJRMJ(Stream a, [Out] TBEADDWHLOJ b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8665040", Offset = "0x8663A40", VA = "0x188665040")]
		public static ChunkInfo RWYYEIUQMUV(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8664E40", Offset = "0x8663840", VA = "0x188664E40")]
		public static GLBHeader OEMQEGRRFVV(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8664F80", Offset = "0x8663980", VA = "0x188664F80")]
		public static bool QGFDRUJXKIT(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8664B10", Offset = "0x8663510", VA = "0x188664B10")]
		public static ChunkInfo BPIXDSKRWEA(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x86652D0", Offset = "0x8663CD0", VA = "0x1886652D0")]
		private static void WXOMFJORFWS(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8665570", Offset = "0x8663F70", VA = "0x188665570")]
		private static uint XSVXDPNBBMR(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UFFYEYCBCXU
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
		public PathElement YLSGNFXWUZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECB10", VA = "0x180CEE110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A40", Offset = "0xCF0440", VA = "0x180CF1A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int PMHRBJOKSGI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xDDD830", Offset = "0xDDC230", VA = "0x180DDD830")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xDDD820", Offset = "0xDDC220", VA = "0x180DDD820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string MKHBVVZATXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0410", VA = "0x180CF1A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LZGUOYUJLMO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF3630", VA = "0x180CF4C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCF4340", Offset = "0xCF2D40", VA = "0x180CF4340")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public UFFYEYCBCXU NMPPREWJCYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0180", VA = "0x180CF1780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8662920", Offset = "0x8661320", VA = "0x188662920")]
		public string TEODBQXYEGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x86628C0", Offset = "0x86612C0", VA = "0x1886628C0")]
		public UFFYEYCBCXU HAREZETDTPY(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8662D30", Offset = "0x8661730", VA = "0x188662D30")]
		private UFFYEYCBCXU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8662B80", Offset = "0x8661580", VA = "0x188662B80")]
		public UFFYEYCBCXU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x53921A0", Offset = "0x5390BA0", VA = "0x1853921A0")]
		[CompilerGenerated]
		internal static string BVVVEKGXHIK(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x86628E0", Offset = "0x86612E0", VA = "0x1886628E0")]
		[CompilerGenerated]
		internal static bool PWWTDIFETOB([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x86629A0", Offset = "0x86613A0", VA = "0x1886629A0")]
		[CompilerGenerated]
		internal static UFFYEYCBCXU XYKHUVUWOJJ(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class YAQVVTAZVZJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8665B40", Offset = "0x8664540", VA = "0x188665B40")]
		public static int[] ACZXCGAOVEL(this TBEADDWHLOJ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8665DE0", Offset = "0x86647E0", VA = "0x188665DE0")]
		public static int[] VKPIGGIXKWN(this TBEADDWHLOJ a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class HGYOHGFMUCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x864FA20", Offset = "0x864E420", VA = "0x18864FA20")]
		public static uint LAMOLZLKWVG(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream EYROWNZEWAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long FNFXJWGARMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long HUTEZHGCZQO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x865DBA0", Offset = "0x865C5A0", VA = "0x18865DBA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x865DBE0", Offset = "0x865C5E0", VA = "0x18865DBE0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x865DBE0", Offset = "0x865C5E0", VA = "0x18865DBE0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x865DC00", Offset = "0x865C600", VA = "0x18865DC00", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x865DC20", Offset = "0x865C620", VA = "0x18865DC20", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x865DC40", Offset = "0x865C640", VA = "0x18865DC40", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x865D930", Offset = "0x865C330", VA = "0x18865D930")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x865D6F0", Offset = "0x865C0F0", VA = "0x18865D6F0", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x865D850", Offset = "0x865C250", VA = "0x18865D850", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x865D8B0", Offset = "0x865C2B0", VA = "0x18865D8B0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x865D7C0", Offset = "0x865C1C0", VA = "0x18865D7C0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x865D8F0", Offset = "0x865C2F0", VA = "0x18865D8F0", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x865D730", Offset = "0x865C130", VA = "0x18865D730")]
		private void NJUDCKHDOHR()
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
		public static Color NZWWYPMAQAT
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x864B7B0", Offset = "0x864A1B0", VA = "0x18864B7B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color MFLWCRZNXON
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x864B880", Offset = "0x864A280", VA = "0x18864B880")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color UZFIROHOOKR
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x864B590", Offset = "0x8649F90", VA = "0x18864B590")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2DCFAB0", Offset = "0x2DCE4B0", VA = "0x182DCFAB0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x185B540", Offset = "0x1859F40", VA = "0x18185B540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2E31710", Offset = "0x2E30110", VA = "0x182E31710")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2E31720", Offset = "0x2E30120", VA = "0x182E31720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BA91D0", Offset = "0x2BA7BD0", VA = "0x182BA91D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x32B7FD0", Offset = "0x32B69D0", VA = "0x1832B7FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1514400", Offset = "0x1512E00", VA = "0x181514400")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1514410", Offset = "0x1512E10", VA = "0x181514410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AC20", Offset = "0x2B69620", VA = "0x182B6AC20")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x864B5B0", Offset = "0x8649FB0", VA = "0x18864B5B0", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x864B660", Offset = "0x864A060", VA = "0x18864B660", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x864B700", Offset = "0x864A100", VA = "0x18864B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x864B7D0", Offset = "0x864A1D0", VA = "0x18864B7D0")]
		public static bool OOOEUMVNSLV(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class VMSWBTYKHIP : IEquatable<VMSWBTYKHIP>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly VMSWBTYKHIP PENTZHYXMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] TEFIXVJFQHU;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float MFMLIRYDQMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8663D10", Offset = "0x8662710", VA = "0x188663D10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8663920", Offset = "0x8662320", VA = "0x188663920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float FKXFFUOZXWK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x86634A0", Offset = "0x8661EA0", VA = "0x1886634A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8663AD0", Offset = "0x86624D0", VA = "0x188663AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float ZKOMOXTSMXB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x86639B0", Offset = "0x86623B0", VA = "0x1886639B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8663BC0", Offset = "0x86625C0", VA = "0x188663BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float SJMTVRXVEIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8663B00", Offset = "0x8662500", VA = "0x188663B00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x86633B0", Offset = "0x8661DB0", VA = "0x1886633B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float MEWQQXQLOEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8663CE0", Offset = "0x86626E0", VA = "0x188663CE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x86638F0", Offset = "0x86622F0", VA = "0x1886638F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float FKRYINVCOLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8663440", Offset = "0x8661E40", VA = "0x188663440")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8663A70", Offset = "0x8662470", VA = "0x188663A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float ZKTTMENPWIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8663A10", Offset = "0x8662410", VA = "0x188663A10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8663C20", Offset = "0x8662620", VA = "0x188663C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float SKCONMFNGQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8663B30", Offset = "0x8662530", VA = "0x188663B30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x86633E0", Offset = "0x8661DE0", VA = "0x1886633E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MFBXOEKIXPR
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8663CB0", Offset = "0x86626B0", VA = "0x188663CB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x86638C0", Offset = "0x86622C0", VA = "0x1886638C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float FKMRLHBFEZS
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8663470", Offset = "0x8661E70", VA = "0x188663470")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8663AA0", Offset = "0x86624A0", VA = "0x188663AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float ZKZAJLHNFTT
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x86639E0", Offset = "0x86623E0", VA = "0x1886639E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8663BF0", Offset = "0x86625F0", VA = "0x188663BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float SJXHQFLPXES
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8663B60", Offset = "0x8662560", VA = "0x188663B60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8663410", Offset = "0x8661E10", VA = "0x188663410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float MGCGAMFVSUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8663C80", Offset = "0x8662680", VA = "0x188663C80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8663950", Offset = "0x8662350", VA = "0x188663950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float FKHKOAHHVOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8663890", Offset = "0x8662290", VA = "0x188663890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8663A40", Offset = "0x8662440", VA = "0x188663A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float ZJOECPYFRSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8663980", Offset = "0x8662380", VA = "0x188663980")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8663C50", Offset = "0x8662650", VA = "0x188663C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float SKNCHZTHZMT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8663B90", Offset = "0x8662590", VA = "0x188663B90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8663380", Offset = "0x8661D80", VA = "0x188663380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8663E20", Offset = "0x8662820", VA = "0x188663E20")]
		public VMSWBTYKHIP(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x86635D0", Offset = "0x8661FD0", VA = "0x1886635D0", Slot = "4")]
		public bool Equals(VMSWBTYKHIP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x86634D0", Offset = "0x8661ED0", VA = "0x1886634D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x10C7C80", Offset = "0x10C6680", VA = "0x1810C7C80", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DCFAB0", Offset = "0x2DCE4B0", VA = "0x182DCFAB0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x185B540", Offset = "0x1859F40", VA = "0x18185B540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2E31710", Offset = "0x2E30110", VA = "0x182E31710")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2E31720", Offset = "0x2E30120", VA = "0x182E31720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2BA91D0", Offset = "0x2BA7BD0", VA = "0x182BA91D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32B7FD0", Offset = "0x32B69D0", VA = "0x1832B7FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1514400", Offset = "0x1512E00", VA = "0x181514400")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1514410", Offset = "0x1512E10", VA = "0x181514410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8659A30", Offset = "0x8658430", VA = "0x188659A30")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8659690", Offset = "0x8658090", VA = "0x188659690", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x86597B0", Offset = "0x86581B0", VA = "0x1886597B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8659860", Offset = "0x8658260", VA = "0x188659860", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8659940", Offset = "0x8658340", VA = "0x188659940")]
		public static bool OOOEUMVNSLV(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DCFAB0", Offset = "0x2DCE4B0", VA = "0x182DCFAB0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x185B540", Offset = "0x1859F40", VA = "0x18185B540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2E31710", Offset = "0x2E30110", VA = "0x182E31710")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2E31720", Offset = "0x2E30120", VA = "0x182E31720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1037C20", Offset = "0x1036620", VA = "0x181037C20")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x86642C0", Offset = "0x8662CC0", VA = "0x1886642C0")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x86640D0", Offset = "0x8662AD0", VA = "0x1886640D0", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8664130", Offset = "0x8662B30", VA = "0x188664130", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8664210", Offset = "0x8662C10", VA = "0x188664210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8664260", Offset = "0x8662C60", VA = "0x188664260")]
		public static bool OOOEUMVNSLV(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DCFAB0", Offset = "0x2DCE4B0", VA = "0x182DCFAB0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x185B540", Offset = "0x1859F40", VA = "0x18185B540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2E31710", Offset = "0x2E30110", VA = "0x182E31710")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2E31720", Offset = "0x2E30120", VA = "0x182E31720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2BA91D0", Offset = "0x2BA7BD0", VA = "0x182BA91D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32B7FD0", Offset = "0x32B69D0", VA = "0x1832B7FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8664680", Offset = "0x8663080", VA = "0x188664680")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x86642E0", Offset = "0x8662CE0", VA = "0x1886642E0", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x86643C0", Offset = "0x8662DC0", VA = "0x1886643C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8664480", Offset = "0x8662E80", VA = "0x188664480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8664530", Offset = "0x8662F30", VA = "0x188664530")]
		public static bool OOOEUMVNSLV(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2DCFAB0", Offset = "0x2DCE4B0", VA = "0x182DCFAB0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x185B540", Offset = "0x1859F40", VA = "0x18185B540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E31710", Offset = "0x2E30110", VA = "0x182E31710")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2E31720", Offset = "0x2E30120", VA = "0x182E31720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2BA91D0", Offset = "0x2BA7BD0", VA = "0x182BA91D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x32B7FD0", Offset = "0x32B69D0", VA = "0x1832B7FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1514400", Offset = "0x1512E00", VA = "0x181514400")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1514410", Offset = "0x1512E10", VA = "0x181514410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AC20", Offset = "0x2B69620", VA = "0x182B6AC20")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x864B5B0", Offset = "0x8649FB0", VA = "0x18864B5B0", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8664700", Offset = "0x8663100", VA = "0x188664700", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x864B700", Offset = "0x864A100", VA = "0x18864B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class QGCHPMQEPVV
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8659610", Offset = "0x8658010", VA = "0x188659610")]
		public static void VUQFUTFRMNU(this JObject a, string b, LIQIFNODJDV c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class HGYOHGFMUCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x864EDA0", Offset = "0x864D7A0", VA = "0x18864EDA0")]
		public static List<string> FVSTWILCMZX(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x864F110", Offset = "0x864DB10", VA = "0x18864F110")]
		public static List<double> HIELBVBYVYB(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x864EF50", Offset = "0x864D950", VA = "0x18864EF50")]
		public static List<int> HANIGQJVQYY(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0AF0", Offset = "0x3AEF4F0", VA = "0x183AF0AF0")]
		public static List<a> FLOXBPKQHYQ<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x864FB70", Offset = "0x864E570", VA = "0x18864FB70")]
		public static LIQIFNODJDV MASRQNJISUC(this JToken a, TBEADDWHLOJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x864FF50", Offset = "0x864E950", VA = "0x18864FF50")]
		public static int UDDMYPSTESA(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x864FE10", Offset = "0x864E810", VA = "0x18864FE10")]
		public static double SSYTQITCYXI(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x864F740", Offset = "0x864E140", VA = "0x18864F740")]
		public static GLTF.Math.Color HZMPBXLBMRT(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x864EB30", Offset = "0x864D530", VA = "0x18864EB30")]
		public static GLTF.Math.Color CZNFZFPQJOS(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8650090", Offset = "0x864EA90", VA = "0x188650090")]
		public static GLTF.Math.Color USNETKKXAKK(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8650330", Offset = "0x864ED30", VA = "0x188650330")]
		public static GLTF.Math.Vector3 XLVOCQTOCHC(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x864F2D0", Offset = "0x864DCD0", VA = "0x18864F2D0")]
		public static GLTF.Math.Vector2 HNNLETQKRPM(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x864F4E0", Offset = "0x864DEE0", VA = "0x18864F4E0")]
		public static GLTF.Math.Vector3 HNSSCAKIBAV(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x86505F0", Offset = "0x864EFF0", VA = "0x1886505F0")]
		public static GLTF.Math.Quaternion XVUGVWEEHCM(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0F60", Offset = "0x3AEF960", VA = "0x183AF0F60")]
		public static Dictionary<string, b> IDWOQQOZVYM<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1480", Offset = "0x3AEFE80", VA = "0x183AF1480")]
		public static c NYDAHDMKATS<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public UMJJFNXSQAT bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x864BB20", Offset = "0x864A520", VA = "0x18864BB20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x864BAA0", Offset = "0x864A4A0", VA = "0x18864BAA0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class UABEBYDKFDY : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x865DEF0", Offset = "0x865C8F0", VA = "0x18865DEF0")]
		public UABEBYDKFDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x865DE20", Offset = "0x865C820", VA = "0x18865DE20", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, ZIYZUENAFOS> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x864B960", Offset = "0x864A360", VA = "0x18864B960", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x864BA20", Offset = "0x864A420", VA = "0x18864BA20")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class WOZKECMEUHK : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TBEADDWHLOJ CNBVPAWZDFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader TFGGKYCWADF;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8662D90", Offset = "0x8661790", VA = "0x188662D90")]
			internal ZIYZUENAFOS WIMZBMUJMGL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8664AC0", Offset = "0x86634C0", VA = "0x188664AC0")]
		public WOZKECMEUHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8664930", Offset = "0x8663330", VA = "0x188664930", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NGZVCNLAQPS VMKRFHXLXDT;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9680", VA = "0x180CFAC80")]
		public EXT_texture_exr(NGZVCNLAQPS source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x864BB70", Offset = "0x864A570", VA = "0x18864BB70", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x864BBE0", Offset = "0x864A5E0", VA = "0x18864BBE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class FXEKYPGGAHD : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x864BDF0", Offset = "0x864A7F0", VA = "0x18864BDF0")]
		public FXEKYPGGAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x864BCD0", Offset = "0x864A6D0", VA = "0x18864BCD0", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
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
	public class AudioEmitterId : BUMCKPSQMDJ<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x864B0C0", Offset = "0x8649AC0", VA = "0x18864B0C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x864B080", Offset = "0x8649A80", VA = "0x18864B080")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : BUMCKPSQMDJ<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x864B250", Offset = "0x8649C50", VA = "0x18864B250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x864B210", Offset = "0x8649C10", VA = "0x18864B210")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : BUMCKPSQMDJ<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x864AF30", Offset = "0x8649930", VA = "0x18864AF30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x864AEF0", Offset = "0x86498F0", VA = "0x18864AEF0")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x864AE10", Offset = "0x8649810", VA = "0x18864AE10")]
		public static AudioDataId Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8652E30", Offset = "0x8651830", VA = "0x188652E30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8652A30", Offset = "0x8651430", VA = "0x188652A30", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8652AA0", Offset = "0x86514A0", VA = "0x188652AA0")]
		public static KHR_SceneAudioEmittersRef Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8653090", Offset = "0x8651A90", VA = "0x188653090")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x8652A00", Offset = "0x8651400", VA = "0x188652A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x86528E0", Offset = "0x86512E0", VA = "0x1886528E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x86526D0", Offset = "0x86510D0", VA = "0x1886526D0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8652740", Offset = "0x8651140", VA = "0x188652740")]
		public static KHR_NodeAudioEmitterRef Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class MTBUCSFPJXS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string BYXDVSSPQXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? FSXRDLIZYQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? DASXATETTWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? WBCXIBEYLKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? LDXGFYVNNPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? VYSQKKXVGRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? UWYIFFZHJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? WXAGLUQVYTV;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8657EA0", Offset = "0x86568A0", VA = "0x188657EA0")]
		public JObject GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x86577A0", Offset = "0x86561A0", VA = "0x1886577A0")]
		public static MTBUCSFPJXS Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public MTBUCSFPJXS()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : FKQXYNDJOFT
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
		public MTBUCSFPJXS positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8651D20", Offset = "0x8650720", VA = "0x188651D20", Slot = "5")]
		public virtual JObject GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8651820", Offset = "0x8650220", VA = "0x188651820")]
		public static KHR_AudioEmitter Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x86520C0", Offset = "0x8650AC0", VA = "0x1886520C0")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : FKQXYNDJOFT
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
		[Cpp2IlInjected.Address(RVA = "0x86524A0", Offset = "0x8650EA0", VA = "0x1886524A0")]
		public JObject GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8652140", Offset = "0x8650B40", VA = "0x188652140")]
		public static KHR_AudioSource Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8651810", Offset = "0x8650210", VA = "0x188651810")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : FKQXYNDJOFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public QJGNWPOVIOK bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x86516E0", Offset = "0x86500E0", VA = "0x1886516E0")]
		public JObject GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8651480", Offset = "0x864FE80", VA = "0x188651480")]
		public static KHR_AudioData Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8651810", Offset = "0x8650210", VA = "0x188651810")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : FIQFCBAKEMU
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
		[Cpp2IlInjected.Address(RVA = "0x8653350", Offset = "0x8651D50", VA = "0x188653350", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x86532C0", Offset = "0x8651CC0", VA = "0x1886532C0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8653A80", Offset = "0x8652480", VA = "0x188653A80")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class MBZGINWQPRR : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8657750", Offset = "0x8656150", VA = "0x188657750")]
		public MBZGINWQPRR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8656BB0", Offset = "0x86555B0", VA = "0x188656BB0", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public QJGNWPOVIOK bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8653C50", Offset = "0x8652650", VA = "0x188653C50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8653B90", Offset = "0x8652590", VA = "0x188653B90", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8653CA0", Offset = "0x86526A0", VA = "0x188653CA0")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class APHLWLGEJWN : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader TFGGKYCWADF;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8662E40", Offset = "0x8661840", VA = "0x188662E40")]
			internal int WIMZBMUJMGL()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x864ADC0", Offset = "0x86497C0", VA = "0x18864ADC0")]
		public APHLWLGEJWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x864ABB0", Offset = "0x86495B0", VA = "0x18864ABB0", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public LIQIFNODJDV anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8653DA0", Offset = "0x86527A0", VA = "0x188653DA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8653D20", Offset = "0x8652720", VA = "0x188653D20", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class PWWYGUWIVMO : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x86595C0", Offset = "0x8657FC0", VA = "0x1886595C0")]
		public PWWYGUWIVMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8659410", Offset = "0x8657E10", VA = "0x188659410", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public LIQIFNODJDV clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public LIQIFNODJDV clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public LIQIFNODJDV clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8654050", Offset = "0x8652A50", VA = "0x188654050", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8653FB0", Offset = "0x86529B0", VA = "0x188653FB0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class MWPHAZQOOHA : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8658390", Offset = "0x8656D90", VA = "0x188658390")]
		public MWPHAZQOOHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8658110", Offset = "0x8656B10", VA = "0x188658110", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x86543B0", Offset = "0x8652DB0", VA = "0x1886543B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8654340", Offset = "0x8652D40", VA = "0x188654340", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class KTRNWPKSPAA : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x86568B0", Offset = "0x86552B0", VA = "0x1886568B0")]
		public KTRNWPKSPAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x86567E0", Offset = "0x86551E0", VA = "0x1886567E0", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : DALVVYWBMJK, FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float BDPKWSRXKEC;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8654690", Offset = "0x8653090", VA = "0x188654690")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x86546E0", Offset = "0x86530E0", VA = "0x1886546E0")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, TBEADDWHLOJ root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x86544D0", Offset = "0x8652ED0", VA = "0x1886544D0", Slot = "6")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8654570", Offset = "0x8652F70", VA = "0x188654570", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class SMHIOVMBURP : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x865D6A0", Offset = "0x865C0A0", VA = "0x18865D6A0")]
		public SMHIOVMBURP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x865D5A0", Offset = "0x865BFA0", VA = "0x18865D5A0", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x86547B0", Offset = "0x86531B0", VA = "0x1886547B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8654750", Offset = "0x8653150", VA = "0x188654750", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8654900", Offset = "0x8653300", VA = "0x188654900")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class XQQCGSWZVLM : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8665890", Offset = "0x8664290", VA = "0x188665890")]
		public XQQCGSWZVLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x86657C0", Offset = "0x86641C0", VA = "0x1886657C0", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public LIQIFNODJDV iridescenceTexture;

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
		public LIQIFNODJDV iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x86549B0", Offset = "0x86533B0", VA = "0x1886549B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8654910", Offset = "0x8653310", VA = "0x188654910", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8654D70", Offset = "0x8653770", VA = "0x188654D70")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class NJWFWKKXHCA : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8659100", Offset = "0x8657B00", VA = "0x188659100")]
		public NJWFWKKXHCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8658E10", Offset = "0x8657810", VA = "0x188658E10", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class NHRKSMMCFZZ : FIQFCBAKEMU
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 ICWDRFQAVLT;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double XOHJONVNAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color OJDFPVAAEKV;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color MJKXLNZYJQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LIQIFNODJDV NYJSSJUFKAB;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly LIQIFNODJDV FQXFXBVHYTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 AAHJTPHXREG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double SEPWMNRSEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LIQIFNODJDV WCZSFNEJXPU;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly LIQIFNODJDV GKTLNCJSRGG;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8658D10", Offset = "0x8657710", VA = "0x188658D10")]
		public NHRKSMMCFZZ(GLTF.Math.Color a, LIQIFNODJDV b, GLTF.Math.Vector3 c, double d, LIQIFNODJDV e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x86583E0", Offset = "0x8656DE0", VA = "0x1886583E0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x86585A0", Offset = "0x8656FA0", VA = "0x1886585A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class JUPVOTRHJNF : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8651430", Offset = "0x864FE30", VA = "0x188651430")]
		public JUPVOTRHJNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x86510D0", Offset = "0x864FAD0", VA = "0x1886510D0", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public LIQIFNODJDV sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public LIQIFNODJDV sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8654E60", Offset = "0x8653860", VA = "0x188654E60", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8654D90", Offset = "0x8653790", VA = "0x188654D90", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8655370", Offset = "0x8653D70", VA = "0x188655370")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class ZQYVQSTPSUZ : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8666190", Offset = "0x8664B90", VA = "0x188666190")]
		public ZQYVQSTPSUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8665F30", Offset = "0x8664930", VA = "0x188665F30", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public LIQIFNODJDV specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LIQIFNODJDV specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x86554B0", Offset = "0x8653EB0", VA = "0x1886554B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x86553E0", Offset = "0x8653DE0", VA = "0x1886553E0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x86559D0", Offset = "0x86543D0", VA = "0x1886559D0")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class LXDQSGEOUVN : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8656B60", Offset = "0x8655560", VA = "0x188656B60")]
		public LXDQSGEOUVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8656940", Offset = "0x8655340", VA = "0x188656940", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LIQIFNODJDV transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8655AC0", Offset = "0x86544C0", VA = "0x188655AC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8655A40", Offset = "0x8654440", VA = "0x188655A40", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class WAJYCVZSSGW : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x86648E0", Offset = "0x86632E0", VA = "0x1886648E0")]
		public WAJYCVZSSGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x86647A0", Offset = "0x86631A0", VA = "0x1886647A0", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class PALQTJMZMFR : DALVVYWBMJK, FIQFCBAKEMU
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x86593C0", Offset = "0x8657DC0", VA = "0x1886593C0")]
		public PALQTJMZMFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8659350", Offset = "0x8657D50", VA = "0x188659350")]
		public PALQTJMZMFR(PALQTJMZMFR a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8659150", Offset = "0x8657B50", VA = "0x188659150", Slot = "6")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x86591F0", Offset = "0x8657BF0", VA = "0x1886591F0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8659280", Offset = "0x8657C80", VA = "0x188659280", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class DQOCPEGLUJV : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x864B910", Offset = "0x864A310", VA = "0x18864B910")]
		public DQOCPEGLUJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x864B890", Offset = "0x864A290", VA = "0x18864B890", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public LIQIFNODJDV thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8655CE0", Offset = "0x86546E0", VA = "0x188655CE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8655C50", Offset = "0x8654650", VA = "0x188655C50", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8656210", Offset = "0x8654C10", VA = "0x188656210")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class XSIBXCWKUDO : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8665AF0", Offset = "0x86644F0", VA = "0x188665AF0")]
		public XSIBXCWKUDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x86658E0", Offset = "0x86642E0", VA = "0x1886658E0", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8656290", Offset = "0x8654C90", VA = "0x188656290", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8656230", Offset = "0x8654C30", VA = "0x188656230", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x121F330", Offset = "0x121DD30", VA = "0x18121F330")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class TEYSOYUOBQA : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x865DD60", Offset = "0x865C760", VA = "0x18865DD60")]
		public TEYSOYUOBQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x865DC80", Offset = "0x865C680", VA = "0x18865DC80", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8656400", Offset = "0x8654E00", VA = "0x188656400", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x86563A0", Offset = "0x8654DA0", VA = "0x1886563A0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x121F330", Offset = "0x121DD30", VA = "0x18121F330")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class RUEQUWCGIVC : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x865D550", Offset = "0x865BF50", VA = "0x18865D550")]
		public RUEQUWCGIVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x865D470", Offset = "0x865BE70", VA = "0x18865D470", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8656570", Offset = "0x8654F70", VA = "0x188656570", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8656510", Offset = "0x8654F10", VA = "0x188656510", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x121F330", Offset = "0x121DD30", VA = "0x18121F330")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class ADIMQHDFTQM : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x864AB60", Offset = "0x8649560", VA = "0x18864AB60")]
		public ADIMQHDFTQM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x864AA80", Offset = "0x8649480", VA = "0x18864AA80", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NGZVCNLAQPS source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9680", VA = "0x180CFAC80")]
		public KHR_texture_basisu(NGZVCNLAQPS source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8656680", Offset = "0x8655080", VA = "0x188656680", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x86566F0", Offset = "0x86550F0", VA = "0x1886566F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class VERDBQRJSBS : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8663010", Offset = "0x8661A10", VA = "0x188663010")]
		public VERDBQRJSBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8662EB0", Offset = "0x86618B0", VA = "0x188662EB0", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class IJFKHYGUQHV : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 RFBIZEQGAWX;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 OPJWUPWTAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double KGAYDLOYNUK;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double EPEKGFAYWNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 JBTKORXHGDU;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 TGYBEUMETDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? TYHZYUEJSLU;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int UUYNSCPWNTO;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8651050", Offset = "0x864FA50", VA = "0x188651050")]
		public IJFKHYGUQHV(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8650900", Offset = "0x864F300", VA = "0x188650900", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x86509E0", Offset = "0x864F3E0", VA = "0x1886509E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class VMSIVJJGJAD : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8663330", Offset = "0x8661D30", VA = "0x188663330")]
		public VMSIVJJGJAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8663060", Offset = "0x8661A60", VA = "0x188663060", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class CXOYWSYFLTN : FIQFCBAKEMU
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> QBOENXHMTYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9680", VA = "0x180CFAC80")]
		public CXOYWSYFLTN(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x864B3A0", Offset = "0x8649DA0", VA = "0x18864B3A0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x864B4A0", Offset = "0x8649EA0", VA = "0x18864B4A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x864B410", Offset = "0x8649E10", VA = "0x18864B410")]
		public List<double> OXVZDMNOIOR(KTFAJFRQMLO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class WXJCTXEPTSD : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8665770", Offset = "0x8664170", VA = "0x188665770")]
		public WXJCTXEPTSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8665670", Offset = "0x8664070", VA = "0x188665670", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class UCTZRFDQUFN : FKQXYNDJOFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public QJGNWPOVIOK UMJJFNXSQAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint ICFGVAFWIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType QIETXSVXFCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool ZYHGJWNXJTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint LHDUJAQMHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType XYUHIEMAMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> JCVDGSLJFSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> LCEUZYBEGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public VZTDRRWUQUL EGBURYLUUOU;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8651810", Offset = "0x8650210", VA = "0x188651810")]
		public UCTZRFDQUFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x865F000", Offset = "0x865DA00", VA = "0x18865F000")]
		public static UCTZRFDQUFN Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x865F7A0", Offset = "0x865E1A0", VA = "0x18865F7A0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x865E520", Offset = "0x865CF20", VA = "0x18865E520")]
		private unsafe static sbyte OTRUGZTWZJA(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x865E4F0", Offset = "0x865CEF0", VA = "0x18865E4F0")]
		private unsafe static float2 BWHPLSPBQKY(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8660BF0", Offset = "0x865F5F0", VA = "0x188660BF0")]
		private unsafe static float3 NESBFICQJEV(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8661090", Offset = "0x865FA90", VA = "0x188661090")]
		private unsafe static float4 PMLLIKLTKFM(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x86608C0", Offset = "0x865F2C0", VA = "0x1886608C0")]
		private unsafe static float4x4 KNIAOJMHJWK(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x865E520", Offset = "0x865CF20", VA = "0x18865E520")]
		private unsafe static byte CAUOEBXHBJF(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8662890", Offset = "0x8661290", VA = "0x188662890")]
		private unsafe static float2 ZZBKLVIBNOL(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x865FD80", Offset = "0x865E780", VA = "0x18865FD80")]
		private unsafe static float3 GNGHHCAPJVY(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x865FDD0", Offset = "0x865E7D0", VA = "0x18865FDD0")]
		private unsafe static float4 HDPZCMBTQLT(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x86614B0", Offset = "0x865FEB0", VA = "0x1886614B0")]
		private unsafe static float4x4 RLPMUTQTLCF(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8660130", Offset = "0x865EB30", VA = "0x188660130")]
		private unsafe static short PQHSIOIZMBM(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x86624D0", Offset = "0x8660ED0", VA = "0x1886624D0")]
		private unsafe static float2 WWAMEPILWFS(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x86610F0", Offset = "0x865FAF0", VA = "0x1886610F0")]
		private unsafe static float3 PQBXIPGKIHL(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8661670", Offset = "0x8660070", VA = "0x188661670")]
		private unsafe static float4 TPQGGPANKXI(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x865EE60", Offset = "0x865D860", VA = "0x18865EE60")]
		private unsafe static float4x4 DSTIBLMKZZU(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8660130", Offset = "0x865EB30", VA = "0x188660130")]
		private unsafe static ushort PQXZGRWRRWV(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x86624A0", Offset = "0x8660EA0", VA = "0x1886624A0")]
		private unsafe static float2 WQFXUWIAMTP(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8660870", Offset = "0x865F270", VA = "0x188660870")]
		private unsafe static float3 JQHBHQYUEOU(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x86626F0", Offset = "0x86610F0", VA = "0x1886626F0")]
		private unsafe static float4x4 XXAAQCGOHQX(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8661E90", Offset = "0x8660890", VA = "0x188661E90")]
		private unsafe static float4 WDGOCYIFORF(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8660A60", Offset = "0x865F460", VA = "0x188660A60")]
		private unsafe static uint LIJKFERNKAM(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8660130", Offset = "0x865EB30", VA = "0x188660130")]
		private unsafe static ushort HUQDRTFZOSJ(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8660BE0", Offset = "0x865F5E0", VA = "0x188660BE0")]
		private unsafe static float MQAWETYGZYS(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8661650", Offset = "0x8660050", VA = "0x188661650")]
		private unsafe static float2 TPEEJJPDCRC(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x865EE40", Offset = "0x865D840", VA = "0x18865EE40")]
		private unsafe static float3 DRKHVXSZNRD(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8661030", Offset = "0x865FA30", VA = "0x188661030")]
		private unsafe static float4 YYOOHCXGRNA(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x86605F0", Offset = "0x865EFF0", VA = "0x1886605F0")]
		private unsafe static float4x4 IHUTZJXVRTA(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8661030", Offset = "0x865FA30", VA = "0x188661030")]
		private unsafe static float4 PIEEIJFMAIV(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8661060", Offset = "0x865FA60", VA = "0x188661060")]
		private unsafe static float4 PIEEIJFMAIV(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x865F570", Offset = "0x865DF70", VA = "0x18865F570")]
		public static float3[] FGNVIZTOEDC(UCTZRFDQUFN a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8661B80", Offset = "0x8660580", VA = "0x188661B80")]
		public static float3[] VTMHHVBHTMM(UCTZRFDQUFN a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x865E880", Offset = "0x865D280", VA = "0x18865E880")]
		public static uint[] CICJVJBUXEJ(UCTZRFDQUFN a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x86604D0", Offset = "0x865EED0", VA = "0x1886604D0")]
		internal static void HYEEDOYKOOO(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8660620", Offset = "0x865F020", VA = "0x188660620")]
		public uint[] JEZKJAXSSYF(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x865DF40", Offset = "0x865C940", VA = "0x18865DF40")]
		public float[] AMDKKFTDXFV(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x865E9F0", Offset = "0x865D3F0", VA = "0x18865E9F0")]
		public float2[] CJQBOFLKGCJ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x865FE80", Offset = "0x865E880", VA = "0x18865FE80")]
		public float2[] HOGVXKQWTBN(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8660C40", Offset = "0x865F640", VA = "0x188660C40")]
		public float3[] OZTGLACFLXW(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x865E530", Offset = "0x865CF30", VA = "0x18865E530")]
		public float3[] CDGTADPVQNO(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8661910", Offset = "0x8660310", VA = "0x188661910")]
		public float4[] VLBJQQSLFBF(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8661140", Offset = "0x865FB40", VA = "0x188661140")]
		public float4[] QVCFMWKYZHR(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8660140", Offset = "0x865EB40", VA = "0x188660140")]
		public float4[] HWFZFKOZDYQ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8661800", Offset = "0x8660200", VA = "0x188661800")]
		public float3[] UKOIEYQTMTB(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x865F460", Offset = "0x865DE60", VA = "0x18865F460")]
		public float3[] ERBKAKMXCKU(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8662500", Offset = "0x8660F00", VA = "0x188662500")]
		public float4[] XCRAHKUIBTA(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x865FE30", Offset = "0x865E830", VA = "0x18865FE30")]
		public uint[] HGIMLHLOHXT(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8661EF0", Offset = "0x86608F0", VA = "0x188661EF0")]
		public float4x4[] WHTCLTHJDRC(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x865E1B0", Offset = "0x865CBB0", VA = "0x18865E1B0")]
		private unsafe static float4 BJEHXMDXTDM(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x865E370", Offset = "0x865CD70", VA = "0x18865E370")]
		private unsafe static float4 BJEHXMDXTDM(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8660EC0", Offset = "0x865F8C0", VA = "0x188660EC0")]
		private unsafe static float4x4 PGEJZONRBBF(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x865EC80", Offset = "0x865D680", VA = "0x18865EC80")]
		private unsafe static float4 CLAKOIYTQZF(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8660A70", Offset = "0x865F470", VA = "0x188660A70")]
		private unsafe static float3 LTKBTXOBKWM(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x86616D0", Offset = "0x86600D0", VA = "0x1886616D0")]
		private unsafe static float2 TWFIFPWKSGB(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x86625D0", Offset = "0x8660FD0", VA = "0x1886625D0")]
		private unsafe static uint XWLBQBKXKMU(void* a, uint b, GLTFComponentType c)
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
	public static class LJWIRXMDQMQ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x866F580", Offset = "0x866DF80", VA = "0x18866F580")]
		public static int IQPWGRJJCSC(this GLTFAccessorAttributeType a)
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
	public class VZTDRRWUQUL : DALVVYWBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int LHDUJAQMHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public QIYRGNWXAZO KRMFVPSOCEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public LZURTIRCAJP BDAPNDJPKEO;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8679BE0", Offset = "0x86785E0", VA = "0x188679BE0")]
		public VZTDRRWUQUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x86797E0", Offset = "0x86781E0", VA = "0x1886797E0")]
		public static VZTDRRWUQUL Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8679AB0", Offset = "0x86784B0", VA = "0x188679AB0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class QIYRGNWXAZO : DALVVYWBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public QJGNWPOVIOK UMJJFNXSQAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int ICFGVAFWIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType QIETXSVXFCH;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x86735A0", Offset = "0x8671FA0", VA = "0x1886735A0")]
		public QIYRGNWXAZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8673180", Offset = "0x8671B80", VA = "0x188673180")]
		public static QIYRGNWXAZO Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8673460", Offset = "0x8671E60", VA = "0x188673460", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class LZURTIRCAJP : DALVVYWBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public QJGNWPOVIOK UMJJFNXSQAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int ICFGVAFWIKJ;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x866FD00", Offset = "0x866E700", VA = "0x18866FD00")]
		public LZURTIRCAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x866F980", Offset = "0x866E380", VA = "0x18866F980")]
		public static LZURTIRCAJP Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x866FC00", Offset = "0x866E600", VA = "0x18866FC00", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class ZQGCQEKBQWV : DALVVYWBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public HMKNBQJCTRB IMBDYAJZNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public ZMLWMRNUPSM AKTBJYBCHOB;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x867B970", Offset = "0x867A370", VA = "0x18867B970")]
		public ZQGCQEKBQWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x867B680", Offset = "0x867A080", VA = "0x18867B680")]
		public static ZQGCQEKBQWV Deserialize(TBEADDWHLOJ root, JsonReader reader, KTVCVTRZYQB anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x867B870", Offset = "0x867A270", VA = "0x18867B870", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class ZMLWMRNUPSM : DALVVYWBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public POILAGDGQRH KTFAJFRQMLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string HGXJPZZGYPB;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x867B2B0", Offset = "0x8679CB0", VA = "0x18867B2B0")]
		public static ZMLWMRNUPSM Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x867B630", Offset = "0x867A030", VA = "0x18867B630")]
		public ZMLWMRNUPSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x867B510", Offset = "0x8679F10", VA = "0x18867B510", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
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
	public class AITVUNWJGXJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(AITVUNWJGXJ data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] BNEDDYWQLKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type TTDXLQCTEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] LCYYMFOVQLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion DISDUUPKNVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string NGJHYCZJAHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string RTHMCUSNQVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public LOWENHEWMHZ XMGCMHWUGKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string UXNHSHQXDIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string IBKXKNPFPIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public LOWENHEWMHZ QFUIFXFGFTQ;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8666BC0", Offset = "0x86655C0", VA = "0x188666BC0")]
		public AITVUNWJGXJ()
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
	public class GBOWZUSEZBM : DALVVYWBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public ZIYZUENAFOS RGYJHYOQADW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType UPIKGAEYJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public ZIYZUENAFOS TTEBZZNTSUV;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x866A230", Offset = "0x8668C30", VA = "0x18866A230")]
		public GBOWZUSEZBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8669EA0", Offset = "0x86688A0", VA = "0x188669EA0")]
		public static GBOWZUSEZBM Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x866A0C0", Offset = "0x8668AC0", VA = "0x18866A0C0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class OWEWKGZSRKI : DALVVYWBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string CDLQRFIIPVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string HVNORLYCMWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string VLZMEGBXNTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string XJFIKTUHQYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> DUYDKGZKLBO;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8672760", Offset = "0x8671160", VA = "0x188672760")]
		public OWEWKGZSRKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8671C70", Offset = "0x8670670", VA = "0x188671C70")]
		public static OWEWKGZSRKI Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8672330", Offset = "0x8670D30", VA = "0x188672330", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8672750", Offset = "0x8671150", VA = "0x188672750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8671F90", Offset = "0x8670990", VA = "0x188671F90")]
		public string FXPDZKSVARC(bool a)
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
	public class UMJJFNXSQAT : FKQXYNDJOFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public CCIZODPLJBR FPLGRORLAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint ICFGVAFWIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint YEFGOHCJZWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint JFATZERTNPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget AKTBJYBCHOB;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8669DD0", Offset = "0x86687D0", VA = "0x188669DD0")]
		public UMJJFNXSQAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8678120", Offset = "0x8676B20", VA = "0x188678120")]
		public static UMJJFNXSQAT Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x86783D0", Offset = "0x8676DD0", VA = "0x1886783D0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class WHBHBBBCJPT : DALVVYWBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double KVVBHZQPRAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double BBYZALHNTSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double VFPXHVVXSUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double ZZOMFQVPARW;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x867A270", Offset = "0x8678C70", VA = "0x18867A270")]
		public WHBHBBBCJPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8679D80", Offset = "0x8678780", VA = "0x188679D80")]
		public static WHBHBBBCJPT Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x867A100", Offset = "0x8678B00", VA = "0x18867A100", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class SBSGJCAUCWP : DALVVYWBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double LCRBEPPRDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double DJYUESMBNZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double VFPXHVVXSUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double ZZOMFQVPARW;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8673C70", Offset = "0x8672670", VA = "0x188673C70")]
		public SBSGJCAUCWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8673770", Offset = "0x8672170", VA = "0x188673770")]
		public static SBSGJCAUCWP Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8673AE0", Offset = "0x86724E0", VA = "0x188673AE0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class KTVCVTRZYQB : FKQXYNDJOFT
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public TBEADDWHLOJ CNBVPAWZDFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader TFGGKYCWADF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public KTVCVTRZYQB QGYRJQNYSHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<ZQGCQEKBQWV> QKHJAEPTHFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<GBOWZUSEZBM> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8678100", Offset = "0x8676B00", VA = "0x188678100")]
			internal ZQGCQEKBQWV WIMZBMUJMGL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x86780F0", Offset = "0x8676AF0", VA = "0x1886780F0")]
			internal GBOWZUSEZBM WIHSEGAMCVC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<ZQGCQEKBQWV> CTPKLOIGNRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<GBOWZUSEZBM> XUWGDFZEZQF;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x866E570", Offset = "0x866CF70", VA = "0x18866E570")]
		public static KTVCVTRZYQB Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x866ECD0", Offset = "0x866D6D0", VA = "0x18866ECD0")]
		public KTVCVTRZYQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x866E930", Offset = "0x866D330", VA = "0x18866E930", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class XLUTOTUKWDR : FKQXYNDJOFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string ARBQFMBOOFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint YEFGOHCJZWW;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8669DD0", Offset = "0x86687D0", VA = "0x188669DD0")]
		public XLUTOTUKWDR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x867AC20", Offset = "0x8679620", VA = "0x18867AC20")]
		public static XLUTOTUKWDR Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x867ADF0", Offset = "0x86797F0", VA = "0x18867ADF0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class LUUSNAFKXGC : FKQXYNDJOFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public WHBHBBBCJPT JGQFJLCDLES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public SBSGJCAUCWP CBSRNVUXTLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType XYUHIEMAMOM;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8669DD0", Offset = "0x86687D0", VA = "0x188669DD0")]
		public LUUSNAFKXGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x866F5E0", Offset = "0x866DFE0", VA = "0x18866F5E0")]
		public static LUUSNAFKXGC Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x866F7B0", Offset = "0x866E1B0", VA = "0x18866F7B0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
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
	public class FKQXYNDJOFT : DALVVYWBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string AZGBUIWNJKT;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8669DD0", Offset = "0x86687D0", VA = "0x188669DD0")]
		public FKQXYNDJOFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8669E20", Offset = "0x8668820", VA = "0x188669E20")]
		public FKQXYNDJOFT(FKQXYNDJOFT a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8669CE0", Offset = "0x86686E0", VA = "0x188669CE0")]
		public new void XQMSTMGATJZ(TBEADDWHLOJ a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8669C50", Offset = "0x8668650", VA = "0x188669C50", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class BUMCKPSQMDJ<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int JQCTFOCWOYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public TBEADDWHLOJ OFIFJQDFJXG;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		protected BUMCKPSQMDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x4FADA60", Offset = "0x4FAC460", VA = "0x184FADA60")]
		public BUMCKPSQMDJ(BUMCKPSQMDJ<a> a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4FADA30", Offset = "0x4FAC430", VA = "0x184FADA30")]
		public void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class ZIYZUENAFOS : BUMCKPSQMDJ<UCTZRFDQUFN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override UCTZRFDQUFN Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x867B250", Offset = "0x8679C50", VA = "0x18867B250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x867B1B0", Offset = "0x8679BB0", VA = "0x18867B1B0")]
		public ZIYZUENAFOS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x867B1F0", Offset = "0x8679BF0", VA = "0x18867B1F0")]
		public ZIYZUENAFOS(ZIYZUENAFOS a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x867B0D0", Offset = "0x8679AD0", VA = "0x18867B0D0")]
		public static ZIYZUENAFOS Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class CCIZODPLJBR : BUMCKPSQMDJ<XLUTOTUKWDR>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override XLUTOTUKWDR Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x8667140", Offset = "0x8665B40", VA = "0x188667140", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8667100", Offset = "0x8665B00", VA = "0x188667100")]
		public CCIZODPLJBR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8667020", Offset = "0x8665A20", VA = "0x188667020")]
		public static CCIZODPLJBR Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class QJGNWPOVIOK : BUMCKPSQMDJ<UMJJFNXSQAT>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override UMJJFNXSQAT Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x8673710", Offset = "0x8672110", VA = "0x188673710", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x86736D0", Offset = "0x86720D0", VA = "0x1886736D0")]
		public QJGNWPOVIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x86735F0", Offset = "0x8671FF0", VA = "0x1886735F0")]
		public static QJGNWPOVIOK Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ZGJGJNHLPBE : BUMCKPSQMDJ<LUUSNAFKXGC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override LUUSNAFKXGC Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x867B070", Offset = "0x8679A70", VA = "0x18867B070", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x867B030", Offset = "0x8679A30", VA = "0x18867B030")]
		public ZGJGJNHLPBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x867AF50", Offset = "0x8679950", VA = "0x18867AF50")]
		public static ZGJGJNHLPBE Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class NGZVCNLAQPS : BUMCKPSQMDJ<UETACDQNYLA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override UETACDQNYLA Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x866FE70", Offset = "0x866E870", VA = "0x18866FE70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x866FE30", Offset = "0x866E830", VA = "0x18866FE30")]
		public NGZVCNLAQPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x866FD50", Offset = "0x866E750", VA = "0x18866FD50")]
		public static NGZVCNLAQPS Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class NXKPCLUJUNS : BUMCKPSQMDJ<AHICOKAOCWI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override AHICOKAOCWI Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x86701D0", Offset = "0x866EBD0", VA = "0x1886701D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8670130", Offset = "0x866EB30", VA = "0x188670130")]
		public NXKPCLUJUNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8670170", Offset = "0x866EB70", VA = "0x188670170")]
		public NXKPCLUJUNS(NXKPCLUJUNS a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8670050", Offset = "0x866EA50", VA = "0x188670050")]
		public static NXKPCLUJUNS Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class IUZCCLJFKFO : BUMCKPSQMDJ<KHWXUNVOHHW>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override KHWXUNVOHHW Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x866B8D0", Offset = "0x866A2D0", VA = "0x18866B8D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x866B890", Offset = "0x866A290", VA = "0x18866B890")]
		public IUZCCLJFKFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x866B7B0", Offset = "0x866A1B0", VA = "0x18866B7B0")]
		public static IUZCCLJFKFO Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class POILAGDGQRH : BUMCKPSQMDJ<KTFAJFRQMLO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override KTFAJFRQMLO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x8672D70", Offset = "0x8671770", VA = "0x188672D70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8672D30", Offset = "0x8671730", VA = "0x188672D30")]
		public POILAGDGQRH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x86729E0", Offset = "0x86713E0", VA = "0x1886729E0")]
		public static POILAGDGQRH Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8672AC0", Offset = "0x86714C0", VA = "0x188672AC0")]
		public static List<POILAGDGQRH> FLOXBPKQHYQ(TBEADDWHLOJ a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class NXJSAPWDUNT : BUMCKPSQMDJ<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x866FFF0", Offset = "0x866E9F0", VA = "0x18866FFF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x866FFB0", Offset = "0x866E9B0", VA = "0x18866FFB0")]
		public NXJSAPWDUNT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x866FED0", Offset = "0x866E8D0", VA = "0x18866FED0")]
		public static NXJSAPWDUNT Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class HMKNBQJCTRB : BUMCKPSQMDJ<GBOWZUSEZBM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public KTVCVTRZYQB KTVCVTRZYQB;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override GBOWZUSEZBM Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x866A640", Offset = "0x8669040", VA = "0x18866A640", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x866A600", Offset = "0x8669000", VA = "0x18866A600")]
		public HMKNBQJCTRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x866A500", Offset = "0x8668F00", VA = "0x18866A500")]
		public static HMKNBQJCTRB Deserialize(TBEADDWHLOJ root, KTVCVTRZYQB anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class DQIYXKVQHYZ : BUMCKPSQMDJ<ZZHEPEFHRAT>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override ZZHEPEFHRAT Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x8669BF0", Offset = "0x86685F0", VA = "0x188669BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8669BB0", Offset = "0x86685B0", VA = "0x188669BB0")]
		public DQIYXKVQHYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8669AD0", Offset = "0x86684D0", VA = "0x188669AD0")]
		public static DQIYXKVQHYZ Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class BLQLGAKNORS : BUMCKPSQMDJ<WVIQGMXWUFX>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override WVIQGMXWUFX Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x8666D80", Offset = "0x8665780", VA = "0x188666D80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8666D40", Offset = "0x8665740", VA = "0x188666D40")]
		public BLQLGAKNORS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8666C60", Offset = "0x8665660", VA = "0x188666C60")]
		public static BLQLGAKNORS Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class OWKTOJURGXA : BUMCKPSQMDJ<JQEEIHSQRHG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override JQEEIHSQRHG Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x8672980", Offset = "0x8671380", VA = "0x188672980", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8672940", Offset = "0x8671340", VA = "0x188672940")]
		public OWKTOJURGXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x86728E0", Offset = "0x86712E0", VA = "0x1886728E0")]
		public OWKTOJURGXA(OWKTOJURGXA a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8672800", Offset = "0x8671200", VA = "0x188672800")]
		public static OWKTOJURGXA Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class WFKNWWFNLGZ : BUMCKPSQMDJ<GFNUOXQYSQT>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override GFNUOXQYSQT Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x8679D20", Offset = "0x8678720", VA = "0x188679D20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8679CE0", Offset = "0x86786E0", VA = "0x188679CE0")]
		public WFKNWWFNLGZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class UETACDQNYLA : FKQXYNDJOFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string ARBQFMBOOFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string QWCZWJSQPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public QJGNWPOVIOK UMJJFNXSQAT;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8669DD0", Offset = "0x86687D0", VA = "0x188669DD0")]
		public UETACDQNYLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8677CE0", Offset = "0x86766E0", VA = "0x188677CE0")]
		public static UETACDQNYLA Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8677F20", Offset = "0x8676920", VA = "0x188677F20", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class AHICOKAOCWI : FKQXYNDJOFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public HNMBPMXVUOV HNMBPMXVUOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public IUASTIQFQVK PMRBQMFNVIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public DLLPPIABIIS HLATYILRRYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public QCXDUOOYVAQ GVBXAFWULRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public LIQIFNODJDV QRHEPUODWBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color CCPZUHVQOVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode ZGWPXVNVLLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double YTQVMVFDNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool WLBMYEQTVAK;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8666B50", Offset = "0x8665550", VA = "0x188666B50")]
		public AHICOKAOCWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x86661E0", Offset = "0x8664BE0", VA = "0x1886661E0")]
		public static AHICOKAOCWI Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x86666F0", Offset = "0x86650F0", VA = "0x1886666F0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
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
	public class KHWXUNVOHHW : FKQXYNDJOFT
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public TBEADDWHLOJ CNBVPAWZDFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader TFGGKYCWADF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<ORTIZQKCQUO> QKHJAEPTHFD;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x867AF40", Offset = "0x8679940", VA = "0x18867AF40")]
			internal ORTIZQKCQUO WIMZBMUJMGL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<ORTIZQKCQUO> WVMDHJGPZBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> ZWXTUDMSSLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> BIJKCMYKKRR;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8669DD0", Offset = "0x86687D0", VA = "0x188669DD0")]
		public KHWXUNVOHHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x866C580", Offset = "0x866AF80", VA = "0x18866C580")]
		public static KHWXUNVOHHW Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x866C940", Offset = "0x866B340", VA = "0x18866C940", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class DALVVYWBMJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, WZUSVTJTHOV> XXRDNAHGVLH;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static UWXWUMOQQYU PJJINUSXYBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, FIQFCBAKEMU> HXRZPNWOHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken IGXFZTGNJFB;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8668180", Offset = "0x8666B80", VA = "0x188668180")]
		public static WZUSVTJTHOV QUKEKYDBLNW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8667A10", Offset = "0x8666410", VA = "0x188667A10")]
		public static FIQFCBAKEMU DBMXKOBXGKW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public DALVVYWBMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x86693D0", Offset = "0x8667DD0", VA = "0x1886693D0")]
		public DALVVYWBMJK(DALVVYWBMJK a, [Optional] TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8668310", Offset = "0x8666D10", VA = "0x188668310")]
		public void XQMSTMGATJZ(TBEADDWHLOJ a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8667E80", Offset = "0x8666880", VA = "0x188667E80")]
		public void JVEWYECKUYU(string a, FIQFCBAKEMU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8668090", Offset = "0x8666A90", VA = "0x188668090")]
		private void OWGKQOBSCHO(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8667950", Offset = "0x8666350", VA = "0x188667950")]
		private void BTNZEZPVVRO(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8667FD0", Offset = "0x86669D0", VA = "0x188667FD0")]
		private void OGCBUBBXEHG(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x86685C0", Offset = "0x8666FC0", VA = "0x1886685C0")]
		internal static Dictionary<string, FIQFCBAKEMU> YCPDIXISYBP(TBEADDWHLOJ a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8667B00", Offset = "0x8666500", VA = "0x188667B00", Slot = "4")]
		public virtual void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class TBEADDWHLOJ : DALVVYWBMJK
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class BYJCWIUQJEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public TBEADDWHLOJ CNBVPAWZDFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader EPVXSLPHDAZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<UCTZRFDQUFN> QKHJAEPTHFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<KTVCVTRZYQB> QKCCCXVVXTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<XLUTOTUKWDR> QJWVFRBYOIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<UMJJFNXSQAT> QJROIKIBEXC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<LUUSNAFKXGC> QLCKPFRISYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<UETACDQNYLA> QKXDRYXLJNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<AHICOKAOCWI> QKRWUSDOABV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<KHWXUNVOHHW> QKMPXLJQQQM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<KTFAJFRQMLO> QLXMEGSYERX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> QLSFGZZAVGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<ZZHEPEFHRAT> JRAVFRRJHIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<WVIQGMXWUFX> JRGCCYLGQTX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<JQEEIHSQRHG> JQQHLEDOOLW;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public BYJCWIUQJEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8666FD0", Offset = "0x86659D0", VA = "0x188666FD0")]
			internal UCTZRFDQUFN WIMZBMUJMGL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x8666FC0", Offset = "0x86659C0", VA = "0x188666FC0")]
			internal KTVCVTRZYQB WIHSEGAMCVC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x8666FF0", Offset = "0x86659F0", VA = "0x188666FF0")]
			internal XLUTOTUKWDR WIXMWAIEFDD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x8666FE0", Offset = "0x86659E0", VA = "0x188666FE0")]
			internal UMJJFNXSQAT WISFYTOGVRU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x8666F90", Offset = "0x8665990", VA = "0x188666F90")]
			internal LUUSNAFKXGC WHRXMLSUANB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x8666F80", Offset = "0x8665980", VA = "0x188666F80")]
			internal UETACDQNYLA WHMQPEYWRBS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x8666FB0", Offset = "0x86659B0", VA = "0x188666FB0")]
			internal AHICOKAOCWI WICLGZGOTJT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x8666FA0", Offset = "0x86659A0", VA = "0x188666FA0")]
			internal KHWXUNVOHHW WHXEJSMRJYK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x8667010", Offset = "0x8665A10", VA = "0x188667010")]
			internal KTFAJFRQMLO WKDCFOXOJTF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x8667000", Offset = "0x8665A00", VA = "0x188667000")]
			internal Sampler WJXVIIDRAHW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x8666DE0", Offset = "0x86657E0", VA = "0x188666DE0")]
			internal ZZHEPEFHRAT BANXTOISTOM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x8666F60", Offset = "0x8665960", VA = "0x188666F60")]
			internal WVIQGMXWUFX BATEQVCQCZV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x8666F70", Offset = "0x8665970", VA = "0x188666F70")]
			internal JQEEIHSQRHG BAYLOBWNMLE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> JOVYPJQDUKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> TINDHBKYTEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<UCTZRFDQUFN> CMHVAODFBQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<KTVCVTRZYQB> DROKCMLLGAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public OWEWKGZSRKI OWEWKGZSRKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<XLUTOTUKWDR> RBKGKIIMVSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<UMJJFNXSQAT> FRUKTJVMKKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<LUUSNAFKXGC> PDLEQVEMUMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<UETACDQNYLA> DPPVSXPENTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<AHICOKAOCWI> HBSSSOANDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<KHWXUNVOHHW> XPCQJUHYANX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<KTFAJFRQMLO> LTAPXDGGCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> XUWGDFZEZQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public DQIYXKVQHYZ NZKDOTCPVYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<ZZHEPEFHRAT> BAASZHZKXCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<WVIQGMXWUFX> GPACEDVNRJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<JQEEIHSQRHG> NGIPMSJSGTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<GFNUOXQYSQT> CHXMYIYYBJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool QGFDRUJXKIT;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8677780", Offset = "0x8676180", VA = "0x188677780")]
		public TBEADDWHLOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x86776E0", Offset = "0x86760E0", VA = "0x1886776E0")]
		public ZZHEPEFHRAT JPLWEIOJFFB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8674CE0", Offset = "0x86736E0", VA = "0x188674CE0")]
		public static TBEADDWHLOJ Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8675B30", Offset = "0x8674530", VA = "0x188675B30")]
		public void GHRXOLGFAHI(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class ZZHEPEFHRAT : FKQXYNDJOFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<POILAGDGQRH> LTAPXDGGCIF;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8669DD0", Offset = "0x86687D0", VA = "0x188669DD0")]
		public ZZHEPEFHRAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x867BD10", Offset = "0x867A710", VA = "0x18867BD10")]
		public static ZZHEPEFHRAT Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x867BE90", Offset = "0x867A890", VA = "0x18867BE90", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class JQEEIHSQRHG : FKQXYNDJOFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public NXJSAPWDUNT IMBDYAJZNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NGZVCNLAQPS GBJCTTUXSMN;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8669DD0", Offset = "0x86687D0", VA = "0x188669DD0")]
		public JQEEIHSQRHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x866C240", Offset = "0x866AC40", VA = "0x18866C240")]
		public static JQEEIHSQRHG Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x866C410", Offset = "0x866AE10", VA = "0x18866C410", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class OKAKPSYKXAJ : GFNUOXQYSQT
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8669DD0", Offset = "0x86687D0", VA = "0x188669DD0")]
		public OKAKPSYKXAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8670230", Offset = "0x866EC30", VA = "0x188670230", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class GFNUOXQYSQT : FKQXYNDJOFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string ACBKEEQTANZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color VSAIEXCSPSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string MGNXNPFUFWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float MZIXZNZPEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float JDYGDOBOWYN;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8669DD0", Offset = "0x86687D0", VA = "0x188669DD0")]
		public GFNUOXQYSQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x866A280", Offset = "0x8668C80", VA = "0x18866A280", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class WRUZPKLGOCL : GFNUOXQYSQT
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8669DD0", Offset = "0x86687D0", VA = "0x188669DD0")]
		public WRUZPKLGOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8670230", Offset = "0x866EC30", VA = "0x188670230", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class ZWALPDDCKOP : GFNUOXQYSQT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float QYGZZRZQYTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float XFAXGMYVEHB;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x867BCC0", Offset = "0x867A6C0", VA = "0x18867BCC0")]
		public ZWALPDDCKOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x867B9C0", Offset = "0x867A3C0", VA = "0x18867B9C0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface KLTGGBCRGFU
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UIJTRVHTWGV(TBEADDWHLOJ a, UFFYEYCBCXU b, [Out] AITVUNWJGXJ c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface FIQFCBAKEMU
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FIQFCBAKEMU Clone(TBEADDWHLOJ root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class WZUSVTJTHOV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string JYCBMNEBGBU;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		protected WZUSVTJTHOV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class WASHJNLBXSK : FIQFCBAKEMU
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty JXGUFOSDWHH
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8679C30", Offset = "0x8678630", VA = "0x188679C30", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public WASHJNLBXSK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class UWXWUMOQQYU : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x86785E0", Offset = "0x8676FE0", VA = "0x1886785E0", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public UWXWUMOQQYU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class IUASTIQFQVK : DALVVYWBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color FAXREVYUSXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public LIQIFNODJDV PSNKFGQKRDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color NRCEUYXGZWN;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x866B210", Offset = "0x8669C10", VA = "0x18866B210")]
		public IUASTIQFQVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x866AD10", Offset = "0x8669710", VA = "0x18866AD10")]
		public static IUASTIQFQVK Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x866AFB0", Offset = "0x86699B0", VA = "0x18866AFB0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class DLLPPIABIIS : LIQIFNODJDV
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string NYMCNVWUQWG = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double JBTKORXHGDU;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8669A70", Offset = "0x8668470", VA = "0x188669A70")]
		public DLLPPIABIIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x86696C0", Offset = "0x86680C0", VA = "0x1886696C0")]
		public new static DLLPPIABIIS Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x86699B0", Offset = "0x86683B0", VA = "0x1886699B0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class QCXDUOOYVAQ : LIQIFNODJDV
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string IMJCIPGUZUV = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double WJLNTOUXZHP;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8669A70", Offset = "0x8668470", VA = "0x188669A70")]
		public QCXDUOOYVAQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8672DD0", Offset = "0x86717D0", VA = "0x188672DD0")]
		public new static QCXDUOOYVAQ Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x86730C0", Offset = "0x8671AC0", VA = "0x1886730C0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class HNMBPMXVUOV : DALVVYWBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color SLLIUAGFTLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public LIQIFNODJDV HLJGRKJBRVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double PJDJHUVPVLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double WYCFOLMCBBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public LIQIFNODJDV XNSWUSFUUVC;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x866ACA0", Offset = "0x86696A0", VA = "0x18866ACA0")]
		public HNMBPMXVUOV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x866A6A0", Offset = "0x86690A0", VA = "0x18866A6A0")]
		public static HNMBPMXVUOV Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x866AA10", Offset = "0x8669410", VA = "0x18866AA10", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class ORTIZQKCQUO : DALVVYWBMJK
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class VIHYUHFKEDV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader TFGGKYCWADF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public TBEADDWHLOJ CNBVPAWZDFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<ZIYZUENAFOS> QKHJAEPTHFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<ZIYZUENAFOS> QJWVFRBYOIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, ZIYZUENAFOS>> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public VIHYUHFKEDV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x8678700", Offset = "0x8677100", VA = "0x188678700")]
			internal ZIYZUENAFOS WIMZBMUJMGL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x8678650", Offset = "0x8677050", VA = "0x188678650")]
			internal Dictionary<string, ZIYZUENAFOS> WIHSEGAMCVC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x86787D0", Offset = "0x86771D0", VA = "0x1886787D0")]
			internal ZIYZUENAFOS WIXMWAIEFDD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, ZIYZUENAFOS> RCXURBHMGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public ZIYZUENAFOS KRMFVPSOCEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public NXKPCLUJUNS KSFJLDIUTJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode VCPJRYGHJXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, ZIYZUENAFOS>> FRROUIGHYTI;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8671BD0", Offset = "0x86705D0", VA = "0x188671BD0")]
		public ORTIZQKCQUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8671530", Offset = "0x866FF30", VA = "0x188671530")]
		public ORTIZQKCQUO(ORTIZQKCQUO a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x86710A0", Offset = "0x866FAA0", VA = "0x1886710A0")]
		public static int[] QEJYZYLHQKE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x86702B0", Offset = "0x866ECB0", VA = "0x1886702B0")]
		public static int[] CLKEILCUZLW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8670EE0", Offset = "0x866F8E0", VA = "0x188670EE0")]
		public static int[] MHXVOGXQLLU(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8671140", Offset = "0x866FB40", VA = "0x188671140")]
		public static int[] QRMWEJKJIZQ(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8671380", Offset = "0x866FD80", VA = "0x188671380")]
		public static int[] SJTABDZKOFD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x86714C0", Offset = "0x866FEC0", VA = "0x1886714C0")]
		public static int[] ZSAYTTLQKGY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8671430", Offset = "0x866FE30", VA = "0x188671430")]
		public static int[] XHMKPOYAKHM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8670240", Offset = "0x866EC40", VA = "0x188670240")]
		public static int[] BWNMDBBIXNL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8670E50", Offset = "0x866F850", VA = "0x188670E50")]
		public static int[] GRXLODWQKWP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8670410", Offset = "0x866EE10", VA = "0x188670410")]
		public static ORTIZQKCQUO Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8670860", Offset = "0x866F260", VA = "0x188670860", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class LCXFXHRCLBT
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] TYHZYUEJSLU;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] LPXTJPZIKIP;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] PAZRMXVIGTK;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] BZHNBQVNOPW;
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
	public class KTFAJFRQMLO : FKQXYNDJOFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool HNUBZHJVICW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public ZGJGJNHLPBE JWJSLJKTSLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<POILAGDGQRH> HVTKKGTTFZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public BLQLGAKNORS WVIQGMXWUFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public VMSWBTYKHIP RDZVXEIPRGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public IUZCCLJFKFO PQHFGASYITH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion KGAYDLOYNUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 JBTKORXHGDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 DQYWMOVJBKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> ZWXTUDMSSLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public WFKNWWFNLGZ PLFVPDAHDIA;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x866E430", Offset = "0x866CE30", VA = "0x18866E430")]
		public KTFAJFRQMLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x866CEF0", Offset = "0x866B8F0", VA = "0x18866CEF0")]
		public static KTFAJFRQMLO Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x866D830", Offset = "0x866C230", VA = "0x18866D830", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : FKQXYNDJOFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode TJQHNHUIRAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode IWZHYBVZQTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode AUVSBXSFIXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode ATKVVCIXUVW;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8674C70", Offset = "0x8673670", VA = "0x188674C70")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x86747B0", Offset = "0x86731B0", VA = "0x1886747B0")]
		public static Sampler Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8674A80", Offset = "0x8673480", VA = "0x188674A80", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
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
	public class WVIQGMXWUFX : FKQXYNDJOFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public ZIYZUENAFOS IDVZWNGNRJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public POILAGDGQRH XZHQVASHXWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<POILAGDGQRH> AYNUNADOPVP;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x867AB70", Offset = "0x8679570", VA = "0x18867AB70")]
		public WVIQGMXWUFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x867A500", Offset = "0x8678F00", VA = "0x18867A500")]
		public static WVIQGMXWUFX Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x867A860", Offset = "0x8679260", VA = "0x18867A860", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class LIQIFNODJDV : DALVVYWBMJK
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string WWYPRAKTGEE = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string ONMFULYFSGW = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public OWKTOJURGXA RNGYLFLSPNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int TYHZYUEJSLU;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x866F440", Offset = "0x866DE40", VA = "0x18866F440")]
		public LIQIFNODJDV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x866F490", Offset = "0x866DE90", VA = "0x18866F490")]
		public LIQIFNODJDV(LIQIFNODJDV a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x866F090", Offset = "0x866DA90", VA = "0x18866F090")]
		public static LIQIFNODJDV Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x866F310", Offset = "0x866DD10", VA = "0x18866F310", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x866F370", Offset = "0x866DD70", VA = "0x18866F370")]
		public void NWBGAKIAOVZ(JsonWriter a)
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
	public class CXAZVWAUMHS
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double MOFZMSFBCNU;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double PDSBVAYDVLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double WHEYMLULIRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double LNPUTJLYMOD;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x86678D0", Offset = "0x86662D0", VA = "0x1886678D0")]
		public CXAZVWAUMHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8667410", Offset = "0x8665E10", VA = "0x188667410")]
		public static CXAZVWAUMHS Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8667660", Offset = "0x8666060", VA = "0x188667660")]
		public void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class SKAMIMXDTSS : FKQXYNDJOFT
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color TESVWHXNMHX;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double VQKVXRVEBXZ;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double PCXAWHSCQJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType XYUHIEMAMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color LPXTJPZIKIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double LEKKNKQUGWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double ZBVRIGYEROF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public CXAZVWAUMHS CXAZVWAUMHS;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x86746F0", Offset = "0x86730F0", VA = "0x1886746F0")]
		public SKAMIMXDTSS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x86745C0", Offset = "0x8672FC0", VA = "0x1886745C0")]
		public SKAMIMXDTSS(SKAMIMXDTSS a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8673DF0", Offset = "0x86727F0", VA = "0x188673DF0")]
		public static SKAMIMXDTSS Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8673CD0", Offset = "0x86726D0", VA = "0x188673CD0")]
		public static SKAMIMXDTSS Deserialize(TBEADDWHLOJ root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x86741E0", Offset = "0x8672BE0", VA = "0x1886741E0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class JKAJQXYXEUM : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<GFNUOXQYSQT> SSGGYQYFJON;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9680", VA = "0x180CFAC80")]
		public JKAJQXYXEUM(IList<GFNUOXQYSQT> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x866B9A0", Offset = "0x866A3A0", VA = "0x18866B9A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x866B930", Offset = "0x866A330", VA = "0x18866B930", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class VRGNOGHOBRC : FIQFCBAKEMU, KLTGGBCRGFU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<SKAMIMXDTSS> CHXMYIYYBJX;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8679760", Offset = "0x8678160", VA = "0x188679760")]
		public VRGNOGHOBRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x86788A0", Offset = "0x86772A0", VA = "0x1886788A0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8678B30", Offset = "0x8677530", VA = "0x188678B30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x86794B0", Offset = "0x8677EB0", VA = "0x1886794B0")]
		private static string[] YGFXQPKBDYS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8679010", Offset = "0x8677A10", VA = "0x188679010")]
		private static AITVUNWJGXJ.ImportValuesConversion VHGNLPZUQQU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8678C20", Offset = "0x8677620", VA = "0x188678C20", Slot = "6")]
		public bool UIJTRVHTWGV(TBEADDWHLOJ a, UFFYEYCBCXU b, [Out] AITVUNWJGXJ c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class CVEUBEPSZNB : BUMCKPSQMDJ<SKAMIMXDTSS>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override SKAMIMXDTSS Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x86672C0", Offset = "0x8665CC0", VA = "0x1886672C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8667280", Offset = "0x8665C80", VA = "0x188667280")]
		public CVEUBEPSZNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x86671A0", Offset = "0x8665BA0", VA = "0x1886671A0")]
		public static CVEUBEPSZNB Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class WPSMMAUSHZK : FIQFCBAKEMU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public CVEUBEPSZNB WFKNWWFNLGZ;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9680", VA = "0x180CFAC80")]
		public WPSMMAUSHZK(CVEUBEPSZNB a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x867A440", Offset = "0x8678E40", VA = "0x18867A440")]
		public WPSMMAUSHZK(int a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x867A2C0", Offset = "0x8678CC0", VA = "0x18867A2C0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x867A340", Offset = "0x8678D40", VA = "0x18867A340", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class IUQILVDSKJD : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x866B760", Offset = "0x866A160", VA = "0x18866B760")]
		public IUQILVDSKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x866B280", Offset = "0x8669C80", VA = "0x18866B280", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
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
