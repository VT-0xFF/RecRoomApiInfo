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
		[Cpp2IlInjected.Address(RVA = "0x8654940", Offset = "0x8653540", VA = "0x188654940", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8654890", Offset = "0x8653490", VA = "0x188654890", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0x865BD00", Offset = "0x865A900", VA = "0x18865BD00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x865B760", Offset = "0x865A360", VA = "0x18865B760")]
		public static void BUWDECFJNEN(this KTFAJFRQMLO a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x865D950", Offset = "0x865C550", VA = "0x18865D950")]
		public static void XICEXUNLJAP(this KTFAJFRQMLO a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x865B390", Offset = "0x8659F90", VA = "0x18865B390")]
		public static void BAEFCPLFBUK(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x865E6F0", Offset = "0x865D2F0", VA = "0x18865E6F0")]
		public static GLTF.Math.Vector4 ZASGYZEWAGC(this VMSWBTYKHIP a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x865C980", Offset = "0x865B580", VA = "0x18865C980")]
		public static UnityEngine.Quaternion NQNTPNJIFRX(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x865C850", Offset = "0x865B450", VA = "0x18865C850")]
		public static UnityEngine.Quaternion NQNTPNJIFRX(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x865D4E0", Offset = "0x865C0E0", VA = "0x18865D4E0")]
		public static GLTF.Math.Quaternion WQCYIGTWXBN(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x865C630", Offset = "0x865B230", VA = "0x18865C630")]
		public static Matrix4x4 MRIHGTOIKXG(this VMSWBTYKHIP a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x865C1F0", Offset = "0x865ADF0", VA = "0x18865C1F0")]
		public static Matrix4x4 MRIHGTOIKXG(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x865E3B0", Offset = "0x865CFB0", VA = "0x18865E3B0")]
		public static VMSWBTYKHIP YWRVDZYZFVM(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x865D180", Offset = "0x865BD80", VA = "0x18865D180")]
		public static UnityEngine.Vector3 VKPECATTJNT(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x865D2A0", Offset = "0x865BEA0", VA = "0x18865D2A0")]
		public static UnityEngine.Vector3 VKPECATTJNT(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x865E910", Offset = "0x865D510", VA = "0x18865E910")]
		public static GLTF.Math.Vector3 ZUBQZPJWAXR(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x865BD90", Offset = "0x865A990", VA = "0x18865BD90")]
		public static GLTF.Math.Vector3 FBNOUEWKYKK(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1371B00", Offset = "0x1370700", VA = "0x181371B00")]
		public static GLTF.Math.Vector4 VQWYPUMOGWF(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x865DE80", Offset = "0x865CA80", VA = "0x18865DE80")]
		public static Matrix4x4 YNJBOQNXHGN(this VMSWBTYKHIP a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x865E140", Offset = "0x865CD40", VA = "0x18865E140")]
		public static Matrix4x4 YNJBOQNXHGN(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x865CE50", Offset = "0x865BA50", VA = "0x18865CE50")]
		public static VMSWBTYKHIP SUIFBIRBOVN(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x865EA40", Offset = "0x865D640", VA = "0x18865EA40")]
		public static UnityEngine.Vector2 ZVQOEANCLEN(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x865EA40", Offset = "0x865D640", VA = "0x18865EA40")]
		public static UnityEngine.Vector2 ZVQOEANCLEN(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x865EA60", Offset = "0x865D660", VA = "0x18865EA60")]
		public static void ZVQOEANCLEN(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x865B330", Offset = "0x8659F30", VA = "0x18865B330")]
		public static UnityEngine.Vector3 AABBNOJPYYE(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D7CCD0", Offset = "0x1D7B8D0", VA = "0x181D7CCD0")]
		public static UnityEngine.Vector3 AABBNOJPYYE(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x865B240", Offset = "0x8659E40", VA = "0x18865B240")]
		public static void AABBNOJPYYE(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1371B00", Offset = "0x1370700", VA = "0x181371B00")]
		public static UnityEngine.Vector4 XAVJYECSSSX(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1371B00", Offset = "0x1370700", VA = "0x181371B00")]
		public static UnityEngine.Vector4 XAVJYECSSSX(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x865D730", Offset = "0x865C330", VA = "0x18865D730")]
		public static UnityEngine.Vector4[] XAVJYECSSSX(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x865D620", Offset = "0x865C220", VA = "0x18865D620")]
		public static void XAVJYECSSSX(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x865BFA0", Offset = "0x865ABA0", VA = "0x18865BFA0")]
		public static UnityEngine.Color JGAUGLNWXFP(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x865C040", Offset = "0x865AC40", VA = "0x18865C040")]
		public static void JGAUGLNWXFP(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x865BFA0", Offset = "0x865ABA0", VA = "0x18865BFA0")]
		public static UnityEngine.Color JGAUGLNWXFP(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1371B00", Offset = "0x1370700", VA = "0x181371B00")]
		public static UnityEngine.Color NWTUYKRWROU(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x865CB90", Offset = "0x865B790", VA = "0x18865CB90")]
		public static void NWTUYKRWROU(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1371B00", Offset = "0x1370700", VA = "0x181371B00")]
		public static UnityEngine.Color NWTUYKRWROU(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x865BDD0", Offset = "0x865A9D0", VA = "0x18865BDD0")]
		public static GLTF.Math.Color FXWWGACLUAW(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x865CD20", Offset = "0x865B920", VA = "0x18865CD20")]
		public static GLTF.Math.Color RBHUOMIWUQB(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x865CB10", Offset = "0x865B710", VA = "0x18865CB10")]
		public static GLTF.Math.Color NRQCDOXNKSF(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x865D830", Offset = "0x865C430", VA = "0x18865D830")]
		public static UnityEngine.Color[] XEFLDPGVFPK(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x865CCA0", Offset = "0x865B8A0", VA = "0x18865CCA0")]
		public static int[] QRNLSMSUIVJ(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x865CDA0", Offset = "0x865B9A0", VA = "0x18865CDA0")]
		public static UnityEngine.Vector2[] SIYCHIISQWY(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x865D020", Offset = "0x865BC20", VA = "0x18865D020")]
		public static void UAUGWMLHIZN(LOWENHEWMHZ a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x865D380", Offset = "0x865BF80", VA = "0x18865D380")]
		public static UnityEngine.Vector3[] VXCHFHSNUGR(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x865BE00", Offset = "0x865AA00", VA = "0x18865BE00")]
		public static UnityEngine.Vector4[] HRVNTMRNFTK(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x865C180", Offset = "0x865AD80", VA = "0x18865C180")]
		public static void KNRHVTOZFBB(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x865DE50", Offset = "0x865CA50", VA = "0x18865DE50")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray VWXHGGDQQMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8658080", Offset = "0x8656C80", VA = "0x188658080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> OMOFQZYQJPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xED3CD0", Offset = "0xED28D0", VA = "0x180ED3CD0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xFBA790", Offset = "0xFB9390", VA = "0x180FBA790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint RFBIZEQGAWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCFAD50", Offset = "0xCF9950", VA = "0x180CFAD50")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCFAF30", Offset = "0xCF9B30", VA = "0x180CFAF30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8658090", Offset = "0x8656C90", VA = "0x188658090")]
		public LOWENHEWMHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x864D5C0", Offset = "0x864C1C0", VA = "0x18864D5C0")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x864D620", Offset = "0x864C220", VA = "0x18864D620")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public GRUZCNMEPCV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x864D750", Offset = "0x864C350", VA = "0x18864D750")]
			internal int? UAYFZTOESZK(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x864D7D0", Offset = "0x864C3D0", VA = "0x18864D7D0")]
			internal int? UKWRQSDAXHV(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x864D680", Offset = "0x864C280", VA = "0x18864D680")]
			internal bool CFYVYZFIQLR(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x864E2D0", Offset = "0x864CED0", VA = "0x18864E2D0")]
		private static void NUJBGFOADJV(NumericArray a, LOWENHEWMHZ b, LOWENHEWMHZ c, LOWENHEWMHZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x864EA30", Offset = "0x864D630", VA = "0x18864EA30")]
		public static void QYCIXDRZYCY(Dictionary<string, LOWENHEWMHZ> a, Dictionary<string, (LOWENHEWMHZ sparseIndices, LOWENHEWMHZ sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x864DDF0", Offset = "0x864C9F0", VA = "0x18864DDF0")]
		public static void LUSQRIYNYNW(Dictionary<string, LOWENHEWMHZ> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x864FD10", Offset = "0x864E910", VA = "0x18864FD10")]
		public static void RCZSKWGXDLB(LOWENHEWMHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x864D860", Offset = "0x864C460", VA = "0x18864D860")]
		public static void DBPJTNBLCRR(Dictionary<string, List<LOWENHEWMHZ>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x864E840", Offset = "0x864D440", VA = "0x18864E840")]
		private static void QPEMMBXKBHN(LOWENHEWMHZ a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x864E970", Offset = "0x864D570", VA = "0x18864E970")]
		internal static void QPEMMBXKBHN(UMJJFNXSQAT a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x864FE10", Offset = "0x864EA10", VA = "0x18864FE10")]
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
			[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30BE910", Offset = "0x30BD510", VA = "0x1830BE910")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30BE920", Offset = "0x30BD520", VA = "0x1830BE920")]
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
		[Cpp2IlInjected.Address(RVA = "0x8666400", Offset = "0x8665000", VA = "0x188666400")]
		public static void LEAESNEJRMJ(Stream a, [Out] TBEADDWHLOJ b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x86667C0", Offset = "0x86653C0", VA = "0x1886667C0")]
		public static ChunkInfo RWYYEIUQMUV(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x86665C0", Offset = "0x86651C0", VA = "0x1886665C0")]
		public static GLBHeader OEMQEGRRFVV(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8666700", Offset = "0x8665300", VA = "0x188666700")]
		public static bool QGFDRUJXKIT(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8666290", Offset = "0x8664E90", VA = "0x188666290")]
		public static ChunkInfo BPIXDSKRWEA(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8666A50", Offset = "0x8665650", VA = "0x188666A50")]
		private static void WXOMFJORFWS(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8666CF0", Offset = "0x86658F0", VA = "0x188666CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A40", Offset = "0xCF0640", VA = "0x180CF1A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int PMHRBJOKSGI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xDDD830", Offset = "0xDDC430", VA = "0x180DDD830")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xDDD820", Offset = "0xDDC420", VA = "0x180DDD820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string MKHBVVZATXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LZGUOYUJLMO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF3830", VA = "0x180CF4C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCF4340", Offset = "0xCF2F40", VA = "0x180CF4340")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public UFFYEYCBCXU NMPPREWJCYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0380", VA = "0x180CF1780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x86640A0", Offset = "0x8662CA0", VA = "0x1886640A0")]
		public string TEODBQXYEGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8664040", Offset = "0x8662C40", VA = "0x188664040")]
		public UFFYEYCBCXU HAREZETDTPY(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x86644B0", Offset = "0x86630B0", VA = "0x1886644B0")]
		private UFFYEYCBCXU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8664300", Offset = "0x8662F00", VA = "0x188664300")]
		public UFFYEYCBCXU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5393920", Offset = "0x5392520", VA = "0x185393920")]
		[CompilerGenerated]
		internal static string BVVVEKGXHIK(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8664060", Offset = "0x8662C60", VA = "0x188664060")]
		[CompilerGenerated]
		internal static bool PWWTDIFETOB([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8664120", Offset = "0x8662D20", VA = "0x188664120")]
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
		[Cpp2IlInjected.Address(RVA = "0x86672C0", Offset = "0x8665EC0", VA = "0x1886672C0")]
		public static int[] ACZXCGAOVEL(this TBEADDWHLOJ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8667560", Offset = "0x8666160", VA = "0x188667560")]
		public static int[] VKPIGGIXKWN(this TBEADDWHLOJ a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class HGYOHGFMUCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x86511A0", Offset = "0x864FDA0", VA = "0x1886511A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x865F320", Offset = "0x865DF20", VA = "0x18865F320", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x865F360", Offset = "0x865DF60", VA = "0x18865F360", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x865F360", Offset = "0x865DF60", VA = "0x18865F360", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x865F380", Offset = "0x865DF80", VA = "0x18865F380", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x865F3A0", Offset = "0x865DFA0", VA = "0x18865F3A0", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x865F3C0", Offset = "0x865DFC0", VA = "0x18865F3C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x865F0B0", Offset = "0x865DCB0", VA = "0x18865F0B0")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x865EE70", Offset = "0x865DA70", VA = "0x18865EE70", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x865EFD0", Offset = "0x865DBD0", VA = "0x18865EFD0", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x865F030", Offset = "0x865DC30", VA = "0x18865F030", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x865EF40", Offset = "0x865DB40", VA = "0x18865EF40", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x865F070", Offset = "0x865DC70", VA = "0x18865F070", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x865EEB0", Offset = "0x865DAB0", VA = "0x18865EEB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x864CF30", Offset = "0x864BB30", VA = "0x18864CF30")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color MFLWCRZNXON
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x864D000", Offset = "0x864BC00", VA = "0x18864D000")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color UZFIROHOOKR
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x864CD10", Offset = "0x864B910", VA = "0x18864CD10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2DD0D40", Offset = "0x2DCF940", VA = "0x182DD0D40")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x185CDE0", Offset = "0x185B9E0", VA = "0x18185CDE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2E329A0", Offset = "0x2E315A0", VA = "0x182E329A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2E329B0", Offset = "0x2E315B0", VA = "0x182E329B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BAA460", Offset = "0x2BA9060", VA = "0x182BAA460")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x32B9260", Offset = "0x32B7E60", VA = "0x1832B9260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1514410", Offset = "0x1513010", VA = "0x181514410")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1514420", Offset = "0x1513020", VA = "0x181514420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BEB0", Offset = "0x2B6AAB0", VA = "0x182B6BEB0")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x864CD30", Offset = "0x864B930", VA = "0x18864CD30", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x864CDE0", Offset = "0x864B9E0", VA = "0x18864CDE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x864CE80", Offset = "0x864BA80", VA = "0x18864CE80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x864CF50", Offset = "0x864BB50", VA = "0x18864CF50")]
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
			[Cpp2IlInjected.Address(RVA = "0x8665490", Offset = "0x8664090", VA = "0x188665490")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x86650A0", Offset = "0x8663CA0", VA = "0x1886650A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float FKXFFUOZXWK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8664C20", Offset = "0x8663820", VA = "0x188664C20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8665250", Offset = "0x8663E50", VA = "0x188665250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float ZKOMOXTSMXB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8665130", Offset = "0x8663D30", VA = "0x188665130")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8665340", Offset = "0x8663F40", VA = "0x188665340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float SJMTVRXVEIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8665280", Offset = "0x8663E80", VA = "0x188665280")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8664B30", Offset = "0x8663730", VA = "0x188664B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float MEWQQXQLOEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8665460", Offset = "0x8664060", VA = "0x188665460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8665070", Offset = "0x8663C70", VA = "0x188665070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float FKRYINVCOLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8664BC0", Offset = "0x86637C0", VA = "0x188664BC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x86651F0", Offset = "0x8663DF0", VA = "0x1886651F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float ZKTTMENPWIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8665190", Offset = "0x8663D90", VA = "0x188665190")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x86653A0", Offset = "0x8663FA0", VA = "0x1886653A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float SKCONMFNGQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x86652B0", Offset = "0x8663EB0", VA = "0x1886652B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8664B60", Offset = "0x8663760", VA = "0x188664B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MFBXOEKIXPR
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8665430", Offset = "0x8664030", VA = "0x188665430")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8665040", Offset = "0x8663C40", VA = "0x188665040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float FKMRLHBFEZS
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8664BF0", Offset = "0x86637F0", VA = "0x188664BF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8665220", Offset = "0x8663E20", VA = "0x188665220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float ZKZAJLHNFTT
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8665160", Offset = "0x8663D60", VA = "0x188665160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8665370", Offset = "0x8663F70", VA = "0x188665370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float SJXHQFLPXES
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x86652E0", Offset = "0x8663EE0", VA = "0x1886652E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8664B90", Offset = "0x8663790", VA = "0x188664B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float MGCGAMFVSUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8665400", Offset = "0x8664000", VA = "0x188665400")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x86650D0", Offset = "0x8663CD0", VA = "0x1886650D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float FKHKOAHHVOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8665010", Offset = "0x8663C10", VA = "0x188665010")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x86651C0", Offset = "0x8663DC0", VA = "0x1886651C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float ZJOECPYFRSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8665100", Offset = "0x8663D00", VA = "0x188665100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x86653D0", Offset = "0x8663FD0", VA = "0x1886653D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float SKNCHZTHZMT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8665310", Offset = "0x8663F10", VA = "0x188665310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8664B00", Offset = "0x8663700", VA = "0x188664B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x86655A0", Offset = "0x86641A0", VA = "0x1886655A0")]
		public VMSWBTYKHIP(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8664D50", Offset = "0x8663950", VA = "0x188664D50", Slot = "4")]
		public bool Equals(VMSWBTYKHIP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8664C50", Offset = "0x8663850", VA = "0x188664C50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x10C7C80", Offset = "0x10C6880", VA = "0x1810C7C80", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DD0D40", Offset = "0x2DCF940", VA = "0x182DD0D40")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x185CDE0", Offset = "0x185B9E0", VA = "0x18185CDE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2E329A0", Offset = "0x2E315A0", VA = "0x182E329A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2E329B0", Offset = "0x2E315B0", VA = "0x182E329B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2BAA460", Offset = "0x2BA9060", VA = "0x182BAA460")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32B9260", Offset = "0x32B7E60", VA = "0x1832B9260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1514410", Offset = "0x1513010", VA = "0x181514410")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1514420", Offset = "0x1513020", VA = "0x181514420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x865B1B0", Offset = "0x8659DB0", VA = "0x18865B1B0")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x865AE10", Offset = "0x8659A10", VA = "0x18865AE10", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x865AF30", Offset = "0x8659B30", VA = "0x18865AF30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x865AFE0", Offset = "0x8659BE0", VA = "0x18865AFE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x865B0C0", Offset = "0x8659CC0", VA = "0x18865B0C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DD0D40", Offset = "0x2DCF940", VA = "0x182DD0D40")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x185CDE0", Offset = "0x185B9E0", VA = "0x18185CDE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2E329A0", Offset = "0x2E315A0", VA = "0x182E329A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2E329B0", Offset = "0x2E315B0", VA = "0x182E329B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1037C20", Offset = "0x1036820", VA = "0x181037C20")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8665A40", Offset = "0x8664640", VA = "0x188665A40")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8665850", Offset = "0x8664450", VA = "0x188665850", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x86658B0", Offset = "0x86644B0", VA = "0x1886658B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8665990", Offset = "0x8664590", VA = "0x188665990", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x86659E0", Offset = "0x86645E0", VA = "0x1886659E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DD0D40", Offset = "0x2DCF940", VA = "0x182DD0D40")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x185CDE0", Offset = "0x185B9E0", VA = "0x18185CDE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2E329A0", Offset = "0x2E315A0", VA = "0x182E329A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2E329B0", Offset = "0x2E315B0", VA = "0x182E329B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2BAA460", Offset = "0x2BA9060", VA = "0x182BAA460")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32B9260", Offset = "0x32B7E60", VA = "0x1832B9260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8665E00", Offset = "0x8664A00", VA = "0x188665E00")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8665A60", Offset = "0x8664660", VA = "0x188665A60", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8665B40", Offset = "0x8664740", VA = "0x188665B40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8665C00", Offset = "0x8664800", VA = "0x188665C00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8665CB0", Offset = "0x86648B0", VA = "0x188665CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DD0D40", Offset = "0x2DCF940", VA = "0x182DD0D40")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x185CDE0", Offset = "0x185B9E0", VA = "0x18185CDE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E329A0", Offset = "0x2E315A0", VA = "0x182E329A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2E329B0", Offset = "0x2E315B0", VA = "0x182E329B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2BAA460", Offset = "0x2BA9060", VA = "0x182BAA460")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x32B9260", Offset = "0x32B7E60", VA = "0x1832B9260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1514410", Offset = "0x1513010", VA = "0x181514410")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1514420", Offset = "0x1513020", VA = "0x181514420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BEB0", Offset = "0x2B6AAB0", VA = "0x182B6BEB0")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x864CD30", Offset = "0x864B930", VA = "0x18864CD30", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8665E80", Offset = "0x8664A80", VA = "0x188665E80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x864CE80", Offset = "0x864BA80", VA = "0x18864CE80", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x865AD90", Offset = "0x8659990", VA = "0x18865AD90")]
		public static void VUQFUTFRMNU(this JObject a, string b, LIQIFNODJDV c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class HGYOHGFMUCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8650520", Offset = "0x864F120", VA = "0x188650520")]
		public static List<string> FVSTWILCMZX(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8650890", Offset = "0x864F490", VA = "0x188650890")]
		public static List<double> HIELBVBYVYB(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x86506D0", Offset = "0x864F2D0", VA = "0x1886506D0")]
		public static List<int> HANIGQJVQYY(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3AF21E0", Offset = "0x3AF0DE0", VA = "0x183AF21E0")]
		public static List<a> FLOXBPKQHYQ<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x86512F0", Offset = "0x864FEF0", VA = "0x1886512F0")]
		public static LIQIFNODJDV MASRQNJISUC(this JToken a, TBEADDWHLOJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x86516D0", Offset = "0x86502D0", VA = "0x1886516D0")]
		public static int UDDMYPSTESA(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8651590", Offset = "0x8650190", VA = "0x188651590")]
		public static double SSYTQITCYXI(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8650EC0", Offset = "0x864FAC0", VA = "0x188650EC0")]
		public static GLTF.Math.Color HZMPBXLBMRT(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x86502B0", Offset = "0x864EEB0", VA = "0x1886502B0")]
		public static GLTF.Math.Color CZNFZFPQJOS(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8651810", Offset = "0x8650410", VA = "0x188651810")]
		public static GLTF.Math.Color USNETKKXAKK(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8651AB0", Offset = "0x86506B0", VA = "0x188651AB0")]
		public static GLTF.Math.Vector3 XLVOCQTOCHC(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8650A50", Offset = "0x864F650", VA = "0x188650A50")]
		public static GLTF.Math.Vector2 HNNLETQKRPM(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8650C60", Offset = "0x864F860", VA = "0x188650C60")]
		public static GLTF.Math.Vector3 HNSSCAKIBAV(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8651D70", Offset = "0x8650970", VA = "0x188651D70")]
		public static GLTF.Math.Quaternion XVUGVWEEHCM(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2650", Offset = "0x3AF1250", VA = "0x183AF2650")]
		public static Dictionary<string, b> IDWOQQOZVYM<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2B70", Offset = "0x3AF1770", VA = "0x183AF2B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x864D2A0", Offset = "0x864BEA0", VA = "0x18864D2A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x864D220", Offset = "0x864BE20", VA = "0x18864D220", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class UABEBYDKFDY : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x865F670", Offset = "0x865E270", VA = "0x18865F670")]
		public UABEBYDKFDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x865F5A0", Offset = "0x865E1A0", VA = "0x18865F5A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x864D0E0", Offset = "0x864BCE0", VA = "0x18864D0E0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x864D1A0", Offset = "0x864BDA0", VA = "0x18864D1A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8664510", Offset = "0x8663110", VA = "0x188664510")]
			internal ZIYZUENAFOS WIMZBMUJMGL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8666240", Offset = "0x8664E40", VA = "0x188666240")]
		public WOZKECMEUHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x86660B0", Offset = "0x8664CB0", VA = "0x1886660B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public EXT_texture_exr(NGZVCNLAQPS source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x864D2F0", Offset = "0x864BEF0", VA = "0x18864D2F0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x864D360", Offset = "0x864BF60", VA = "0x18864D360", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class FXEKYPGGAHD : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x864D570", Offset = "0x864C170", VA = "0x18864D570")]
		public FXEKYPGGAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x864D450", Offset = "0x864C050", VA = "0x18864D450", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x864C840", Offset = "0x864B440", VA = "0x18864C840", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x864C800", Offset = "0x864B400", VA = "0x18864C800")]
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
			[Cpp2IlInjected.Address(RVA = "0x864C9D0", Offset = "0x864B5D0", VA = "0x18864C9D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x864C990", Offset = "0x864B590", VA = "0x18864C990")]
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
			[Cpp2IlInjected.Address(RVA = "0x864C6B0", Offset = "0x864B2B0", VA = "0x18864C6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x864C670", Offset = "0x864B270", VA = "0x18864C670")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x864C590", Offset = "0x864B190", VA = "0x18864C590")]
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
		[Cpp2IlInjected.Address(RVA = "0x86545B0", Offset = "0x86531B0", VA = "0x1886545B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x86541B0", Offset = "0x8652DB0", VA = "0x1886541B0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8654220", Offset = "0x8652E20", VA = "0x188654220")]
		public static KHR_SceneAudioEmittersRef Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8654810", Offset = "0x8653410", VA = "0x188654810")]
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
			[Cpp2IlInjected.Address(RVA = "0x8654180", Offset = "0x8652D80", VA = "0x188654180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8654060", Offset = "0x8652C60", VA = "0x188654060", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8653E50", Offset = "0x8652A50", VA = "0x188653E50", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8653EC0", Offset = "0x8652AC0", VA = "0x188653EC0")]
		public static KHR_NodeAudioEmitterRef Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x8659620", Offset = "0x8658220", VA = "0x188659620")]
		public JObject GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8658F20", Offset = "0x8657B20", VA = "0x188658F20")]
		public static MTBUCSFPJXS Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x86534A0", Offset = "0x86520A0", VA = "0x1886534A0", Slot = "5")]
		public virtual JObject GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8652FA0", Offset = "0x8651BA0", VA = "0x188652FA0")]
		public static KHR_AudioEmitter Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8653840", Offset = "0x8652440", VA = "0x188653840")]
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
		[Cpp2IlInjected.Address(RVA = "0x8653C20", Offset = "0x8652820", VA = "0x188653C20")]
		public JObject GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x86538C0", Offset = "0x86524C0", VA = "0x1886538C0")]
		public static KHR_AudioSource Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8652F90", Offset = "0x8651B90", VA = "0x188652F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8652E60", Offset = "0x8651A60", VA = "0x188652E60")]
		public JObject GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8652C00", Offset = "0x8651800", VA = "0x188652C00")]
		public static KHR_AudioData Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8652F90", Offset = "0x8651B90", VA = "0x188652F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8654AD0", Offset = "0x86536D0", VA = "0x188654AD0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8654A40", Offset = "0x8653640", VA = "0x188654A40", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8655200", Offset = "0x8653E00", VA = "0x188655200")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class MBZGINWQPRR : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8658ED0", Offset = "0x8657AD0", VA = "0x188658ED0")]
		public MBZGINWQPRR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8658330", Offset = "0x8656F30", VA = "0x188658330", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86553D0", Offset = "0x8653FD0", VA = "0x1886553D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8655310", Offset = "0x8653F10", VA = "0x188655310", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8655420", Offset = "0x8654020", VA = "0x188655420")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x86645C0", Offset = "0x86631C0", VA = "0x1886645C0")]
			internal int WIMZBMUJMGL()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x864C540", Offset = "0x864B140", VA = "0x18864C540")]
		public APHLWLGEJWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x864C330", Offset = "0x864AF30", VA = "0x18864C330", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8655520", Offset = "0x8654120", VA = "0x188655520", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x86554A0", Offset = "0x86540A0", VA = "0x1886554A0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class PWWYGUWIVMO : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x865AD40", Offset = "0x8659940", VA = "0x18865AD40")]
		public PWWYGUWIVMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x865AB90", Offset = "0x8659790", VA = "0x18865AB90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86557D0", Offset = "0x86543D0", VA = "0x1886557D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8655730", Offset = "0x8654330", VA = "0x188655730", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class MWPHAZQOOHA : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8659B10", Offset = "0x8658710", VA = "0x188659B10")]
		public MWPHAZQOOHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8659890", Offset = "0x8658490", VA = "0x188659890", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8655B30", Offset = "0x8654730", VA = "0x188655B30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8655AC0", Offset = "0x86546C0", VA = "0x188655AC0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class KTRNWPKSPAA : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8658030", Offset = "0x8656C30", VA = "0x188658030")]
		public KTRNWPKSPAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8657F60", Offset = "0x8656B60", VA = "0x188657F60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8655E10", Offset = "0x8654A10", VA = "0x188655E10")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8655E60", Offset = "0x8654A60", VA = "0x188655E60")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, TBEADDWHLOJ root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8655C50", Offset = "0x8654850", VA = "0x188655C50", Slot = "6")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8655CF0", Offset = "0x86548F0", VA = "0x188655CF0", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class SMHIOVMBURP : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x865EE20", Offset = "0x865DA20", VA = "0x18865EE20")]
		public SMHIOVMBURP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x865ED20", Offset = "0x865D920", VA = "0x18865ED20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8655F30", Offset = "0x8654B30", VA = "0x188655F30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8655ED0", Offset = "0x8654AD0", VA = "0x188655ED0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8656080", Offset = "0x8654C80", VA = "0x188656080")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class XQQCGSWZVLM : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8667010", Offset = "0x8665C10", VA = "0x188667010")]
		public XQQCGSWZVLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8666F40", Offset = "0x8665B40", VA = "0x188666F40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8656130", Offset = "0x8654D30", VA = "0x188656130", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8656090", Offset = "0x8654C90", VA = "0x188656090", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x86564F0", Offset = "0x86550F0", VA = "0x1886564F0")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class NJWFWKKXHCA : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x865A880", Offset = "0x8659480", VA = "0x18865A880")]
		public NJWFWKKXHCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x865A590", Offset = "0x8659190", VA = "0x18865A590", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x865A490", Offset = "0x8659090", VA = "0x18865A490")]
		public NHRKSMMCFZZ(GLTF.Math.Color a, LIQIFNODJDV b, GLTF.Math.Vector3 c, double d, LIQIFNODJDV e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8659B60", Offset = "0x8658760", VA = "0x188659B60", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8659D20", Offset = "0x8658920", VA = "0x188659D20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class JUPVOTRHJNF : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8652BB0", Offset = "0x86517B0", VA = "0x188652BB0")]
		public JUPVOTRHJNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8652850", Offset = "0x8651450", VA = "0x188652850", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86565E0", Offset = "0x86551E0", VA = "0x1886565E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8656510", Offset = "0x8655110", VA = "0x188656510", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8656AF0", Offset = "0x86556F0", VA = "0x188656AF0")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class ZQYVQSTPSUZ : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8667910", Offset = "0x8666510", VA = "0x188667910")]
		public ZQYVQSTPSUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x86676B0", Offset = "0x86662B0", VA = "0x1886676B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8656C30", Offset = "0x8655830", VA = "0x188656C30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8656B60", Offset = "0x8655760", VA = "0x188656B60", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8657150", Offset = "0x8655D50", VA = "0x188657150")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class LXDQSGEOUVN : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x86582E0", Offset = "0x8656EE0", VA = "0x1886582E0")]
		public LXDQSGEOUVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x86580C0", Offset = "0x8656CC0", VA = "0x1886580C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657240", Offset = "0x8655E40", VA = "0x188657240", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x86571C0", Offset = "0x8655DC0", VA = "0x1886571C0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class WAJYCVZSSGW : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8666060", Offset = "0x8664C60", VA = "0x188666060")]
		public WAJYCVZSSGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8665F20", Offset = "0x8664B20", VA = "0x188665F20", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class PALQTJMZMFR : DALVVYWBMJK, FIQFCBAKEMU
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x865AB40", Offset = "0x8659740", VA = "0x18865AB40")]
		public PALQTJMZMFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x865AAD0", Offset = "0x86596D0", VA = "0x18865AAD0")]
		public PALQTJMZMFR(PALQTJMZMFR a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x865A8D0", Offset = "0x86594D0", VA = "0x18865A8D0", Slot = "6")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x865A970", Offset = "0x8659570", VA = "0x18865A970", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x865AA00", Offset = "0x8659600", VA = "0x18865AA00", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class DQOCPEGLUJV : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x864D090", Offset = "0x864BC90", VA = "0x18864D090")]
		public DQOCPEGLUJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x864D010", Offset = "0x864BC10", VA = "0x18864D010", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657460", Offset = "0x8656060", VA = "0x188657460", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x86573D0", Offset = "0x8655FD0", VA = "0x1886573D0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8657990", Offset = "0x8656590", VA = "0x188657990")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class XSIBXCWKUDO : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8667270", Offset = "0x8665E70", VA = "0x188667270")]
		public XSIBXCWKUDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8667060", Offset = "0x8665C60", VA = "0x188667060", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657A10", Offset = "0x8656610", VA = "0x188657A10", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x86579B0", Offset = "0x86565B0", VA = "0x1886579B0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x121F330", Offset = "0x121DF30", VA = "0x18121F330")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class TEYSOYUOBQA : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x865F4E0", Offset = "0x865E0E0", VA = "0x18865F4E0")]
		public TEYSOYUOBQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x865F400", Offset = "0x865E000", VA = "0x18865F400", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657B80", Offset = "0x8656780", VA = "0x188657B80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8657B20", Offset = "0x8656720", VA = "0x188657B20", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x121F330", Offset = "0x121DF30", VA = "0x18121F330")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class RUEQUWCGIVC : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x865ECD0", Offset = "0x865D8D0", VA = "0x18865ECD0")]
		public RUEQUWCGIVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x865EBF0", Offset = "0x865D7F0", VA = "0x18865EBF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657CF0", Offset = "0x86568F0", VA = "0x188657CF0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8657C90", Offset = "0x8656890", VA = "0x188657C90", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x121F330", Offset = "0x121DF30", VA = "0x18121F330")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class ADIMQHDFTQM : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x864C2E0", Offset = "0x864AEE0", VA = "0x18864C2E0")]
		public ADIMQHDFTQM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x864C200", Offset = "0x864AE00", VA = "0x18864C200", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public KHR_texture_basisu(NGZVCNLAQPS source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8657E00", Offset = "0x8656A00", VA = "0x188657E00", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8657E70", Offset = "0x8656A70", VA = "0x188657E70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class VERDBQRJSBS : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8664790", Offset = "0x8663390", VA = "0x188664790")]
		public VERDBQRJSBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8664630", Offset = "0x8663230", VA = "0x188664630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86527D0", Offset = "0x86513D0", VA = "0x1886527D0")]
		public IJFKHYGUQHV(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8652080", Offset = "0x8650C80", VA = "0x188652080", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8652160", Offset = "0x8650D60", VA = "0x188652160", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class VMSIVJJGJAD : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8664AB0", Offset = "0x86636B0", VA = "0x188664AB0")]
		public VMSIVJJGJAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x86647E0", Offset = "0x86633E0", VA = "0x1886647E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public CXOYWSYFLTN(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x864CB20", Offset = "0x864B720", VA = "0x18864CB20", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x864CC20", Offset = "0x864B820", VA = "0x18864CC20", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x864CB90", Offset = "0x864B790", VA = "0x18864CB90")]
		public List<double> OXVZDMNOIOR(KTFAJFRQMLO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class WXJCTXEPTSD : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8666EF0", Offset = "0x8665AF0", VA = "0x188666EF0")]
		public WXJCTXEPTSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8666DF0", Offset = "0x86659F0", VA = "0x188666DF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8652F90", Offset = "0x8651B90", VA = "0x188652F90")]
		public UCTZRFDQUFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8660780", Offset = "0x865F380", VA = "0x188660780")]
		public static UCTZRFDQUFN Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8660F20", Offset = "0x865FB20", VA = "0x188660F20", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x865FCA0", Offset = "0x865E8A0", VA = "0x18865FCA0")]
		private unsafe static sbyte OTRUGZTWZJA(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x865FC70", Offset = "0x865E870", VA = "0x18865FC70")]
		private unsafe static float2 BWHPLSPBQKY(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8662370", Offset = "0x8660F70", VA = "0x188662370")]
		private unsafe static float3 NESBFICQJEV(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8662810", Offset = "0x8661410", VA = "0x188662810")]
		private unsafe static float4 PMLLIKLTKFM(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8662040", Offset = "0x8660C40", VA = "0x188662040")]
		private unsafe static float4x4 KNIAOJMHJWK(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x865FCA0", Offset = "0x865E8A0", VA = "0x18865FCA0")]
		private unsafe static byte CAUOEBXHBJF(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8664010", Offset = "0x8662C10", VA = "0x188664010")]
		private unsafe static float2 ZZBKLVIBNOL(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8661500", Offset = "0x8660100", VA = "0x188661500")]
		private unsafe static float3 GNGHHCAPJVY(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8661550", Offset = "0x8660150", VA = "0x188661550")]
		private unsafe static float4 HDPZCMBTQLT(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8662C30", Offset = "0x8661830", VA = "0x188662C30")]
		private unsafe static float4x4 RLPMUTQTLCF(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x86618B0", Offset = "0x86604B0", VA = "0x1886618B0")]
		private unsafe static short PQHSIOIZMBM(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8663C50", Offset = "0x8662850", VA = "0x188663C50")]
		private unsafe static float2 WWAMEPILWFS(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8662870", Offset = "0x8661470", VA = "0x188662870")]
		private unsafe static float3 PQBXIPGKIHL(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8662DF0", Offset = "0x86619F0", VA = "0x188662DF0")]
		private unsafe static float4 TPQGGPANKXI(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x86605E0", Offset = "0x865F1E0", VA = "0x1886605E0")]
		private unsafe static float4x4 DSTIBLMKZZU(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x86618B0", Offset = "0x86604B0", VA = "0x1886618B0")]
		private unsafe static ushort PQXZGRWRRWV(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8663C20", Offset = "0x8662820", VA = "0x188663C20")]
		private unsafe static float2 WQFXUWIAMTP(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8661FF0", Offset = "0x8660BF0", VA = "0x188661FF0")]
		private unsafe static float3 JQHBHQYUEOU(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8663E70", Offset = "0x8662A70", VA = "0x188663E70")]
		private unsafe static float4x4 XXAAQCGOHQX(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8663610", Offset = "0x8662210", VA = "0x188663610")]
		private unsafe static float4 WDGOCYIFORF(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x86621E0", Offset = "0x8660DE0", VA = "0x1886621E0")]
		private unsafe static uint LIJKFERNKAM(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x86618B0", Offset = "0x86604B0", VA = "0x1886618B0")]
		private unsafe static ushort HUQDRTFZOSJ(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8662360", Offset = "0x8660F60", VA = "0x188662360")]
		private unsafe static float MQAWETYGZYS(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8662DD0", Offset = "0x86619D0", VA = "0x188662DD0")]
		private unsafe static float2 TPEEJJPDCRC(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x86605C0", Offset = "0x865F1C0", VA = "0x1886605C0")]
		private unsafe static float3 DRKHVXSZNRD(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x86627B0", Offset = "0x86613B0", VA = "0x1886627B0")]
		private unsafe static float4 YYOOHCXGRNA(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8661D70", Offset = "0x8660970", VA = "0x188661D70")]
		private unsafe static float4x4 IHUTZJXVRTA(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x86627B0", Offset = "0x86613B0", VA = "0x1886627B0")]
		private unsafe static float4 PIEEIJFMAIV(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x86627E0", Offset = "0x86613E0", VA = "0x1886627E0")]
		private unsafe static float4 PIEEIJFMAIV(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8660CF0", Offset = "0x865F8F0", VA = "0x188660CF0")]
		public static float3[] FGNVIZTOEDC(UCTZRFDQUFN a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8663300", Offset = "0x8661F00", VA = "0x188663300")]
		public static float3[] VTMHHVBHTMM(UCTZRFDQUFN a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8660000", Offset = "0x865EC00", VA = "0x188660000")]
		public static uint[] CICJVJBUXEJ(UCTZRFDQUFN a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8661C50", Offset = "0x8660850", VA = "0x188661C50")]
		internal static void HYEEDOYKOOO(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8661DA0", Offset = "0x86609A0", VA = "0x188661DA0")]
		public uint[] JEZKJAXSSYF(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x865F6C0", Offset = "0x865E2C0", VA = "0x18865F6C0")]
		public float[] AMDKKFTDXFV(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8660170", Offset = "0x865ED70", VA = "0x188660170")]
		public float2[] CJQBOFLKGCJ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8661600", Offset = "0x8660200", VA = "0x188661600")]
		public float2[] HOGVXKQWTBN(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x86623C0", Offset = "0x8660FC0", VA = "0x1886623C0")]
		public float3[] OZTGLACFLXW(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x865FCB0", Offset = "0x865E8B0", VA = "0x18865FCB0")]
		public float3[] CDGTADPVQNO(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8663090", Offset = "0x8661C90", VA = "0x188663090")]
		public float4[] VLBJQQSLFBF(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x86628C0", Offset = "0x86614C0", VA = "0x1886628C0")]
		public float4[] QVCFMWKYZHR(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x86618C0", Offset = "0x86604C0", VA = "0x1886618C0")]
		public float4[] HWFZFKOZDYQ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8662F80", Offset = "0x8661B80", VA = "0x188662F80")]
		public float3[] UKOIEYQTMTB(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8660BE0", Offset = "0x865F7E0", VA = "0x188660BE0")]
		public float3[] ERBKAKMXCKU(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8663C80", Offset = "0x8662880", VA = "0x188663C80")]
		public float4[] XCRAHKUIBTA(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x86615B0", Offset = "0x86601B0", VA = "0x1886615B0")]
		public uint[] HGIMLHLOHXT(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8663670", Offset = "0x8662270", VA = "0x188663670")]
		public float4x4[] WHTCLTHJDRC(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x865F930", Offset = "0x865E530", VA = "0x18865F930")]
		private unsafe static float4 BJEHXMDXTDM(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x865FAF0", Offset = "0x865E6F0", VA = "0x18865FAF0")]
		private unsafe static float4 BJEHXMDXTDM(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8662640", Offset = "0x8661240", VA = "0x188662640")]
		private unsafe static float4x4 PGEJZONRBBF(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8660400", Offset = "0x865F000", VA = "0x188660400")]
		private unsafe static float4 CLAKOIYTQZF(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x86621F0", Offset = "0x8660DF0", VA = "0x1886621F0")]
		private unsafe static float3 LTKBTXOBKWM(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8662E50", Offset = "0x8661A50", VA = "0x188662E50")]
		private unsafe static float2 TWFIFPWKSGB(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8663D50", Offset = "0x8662950", VA = "0x188663D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8670D00", Offset = "0x866F900", VA = "0x188670D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x867B360", Offset = "0x8679F60", VA = "0x18867B360")]
		public VZTDRRWUQUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x867AF60", Offset = "0x8679B60", VA = "0x18867AF60")]
		public static VZTDRRWUQUL Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x867B230", Offset = "0x8679E30", VA = "0x18867B230", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8674D20", Offset = "0x8673920", VA = "0x188674D20")]
		public QIYRGNWXAZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8674900", Offset = "0x8673500", VA = "0x188674900")]
		public static QIYRGNWXAZO Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8674BE0", Offset = "0x86737E0", VA = "0x188674BE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8671480", Offset = "0x8670080", VA = "0x188671480")]
		public LZURTIRCAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8671100", Offset = "0x866FD00", VA = "0x188671100")]
		public static LZURTIRCAJP Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8671380", Offset = "0x866FF80", VA = "0x188671380", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x867D0F0", Offset = "0x867BCF0", VA = "0x18867D0F0")]
		public ZQGCQEKBQWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x867CE00", Offset = "0x867BA00", VA = "0x18867CE00")]
		public static ZQGCQEKBQWV Deserialize(TBEADDWHLOJ root, JsonReader reader, KTVCVTRZYQB anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x867CFF0", Offset = "0x867BBF0", VA = "0x18867CFF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x867CA30", Offset = "0x867B630", VA = "0x18867CA30")]
		public static ZMLWMRNUPSM Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x867CDB0", Offset = "0x867B9B0", VA = "0x18867CDB0")]
		public ZMLWMRNUPSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x867CC90", Offset = "0x867B890", VA = "0x18867CC90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8668340", Offset = "0x8666F40", VA = "0x188668340")]
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
		[Cpp2IlInjected.Address(RVA = "0x866B9B0", Offset = "0x866A5B0", VA = "0x18866B9B0")]
		public GBOWZUSEZBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x866B620", Offset = "0x866A220", VA = "0x18866B620")]
		public static GBOWZUSEZBM Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x866B840", Offset = "0x866A440", VA = "0x18866B840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8673EE0", Offset = "0x8672AE0", VA = "0x188673EE0")]
		public OWEWKGZSRKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x86733F0", Offset = "0x8671FF0", VA = "0x1886733F0")]
		public static OWEWKGZSRKI Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8673AB0", Offset = "0x86726B0", VA = "0x188673AB0", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8673ED0", Offset = "0x8672AD0", VA = "0x188673ED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8673710", Offset = "0x8672310", VA = "0x188673710")]
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
		[Cpp2IlInjected.Address(RVA = "0x866B550", Offset = "0x866A150", VA = "0x18866B550")]
		public UMJJFNXSQAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x86798A0", Offset = "0x86784A0", VA = "0x1886798A0")]
		public static UMJJFNXSQAT Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8679B50", Offset = "0x8678750", VA = "0x188679B50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x867B9F0", Offset = "0x867A5F0", VA = "0x18867B9F0")]
		public WHBHBBBCJPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x867B500", Offset = "0x867A100", VA = "0x18867B500")]
		public static WHBHBBBCJPT Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x867B880", Offset = "0x867A480", VA = "0x18867B880", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86753F0", Offset = "0x8673FF0", VA = "0x1886753F0")]
		public SBSGJCAUCWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8674EF0", Offset = "0x8673AF0", VA = "0x188674EF0")]
		public static SBSGJCAUCWP Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8675260", Offset = "0x8673E60", VA = "0x188675260", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8679880", Offset = "0x8678480", VA = "0x188679880")]
			internal ZQGCQEKBQWV WIMZBMUJMGL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8679870", Offset = "0x8678470", VA = "0x188679870")]
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
		[Cpp2IlInjected.Address(RVA = "0x866FCF0", Offset = "0x866E8F0", VA = "0x18866FCF0")]
		public static KTVCVTRZYQB Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8670450", Offset = "0x866F050", VA = "0x188670450")]
		public KTVCVTRZYQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x86700B0", Offset = "0x866ECB0", VA = "0x1886700B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x866B550", Offset = "0x866A150", VA = "0x18866B550")]
		public XLUTOTUKWDR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x867C3A0", Offset = "0x867AFA0", VA = "0x18867C3A0")]
		public static XLUTOTUKWDR Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x867C570", Offset = "0x867B170", VA = "0x18867C570", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x866B550", Offset = "0x866A150", VA = "0x18866B550")]
		public LUUSNAFKXGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8670D60", Offset = "0x866F960", VA = "0x188670D60")]
		public static LUUSNAFKXGC Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8670F30", Offset = "0x866FB30", VA = "0x188670F30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x866B550", Offset = "0x866A150", VA = "0x18866B550")]
		public FKQXYNDJOFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x866B5A0", Offset = "0x866A1A0", VA = "0x18866B5A0")]
		public FKQXYNDJOFT(FKQXYNDJOFT a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x866B460", Offset = "0x866A060", VA = "0x18866B460")]
		public new void XQMSTMGATJZ(TBEADDWHLOJ a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x866B3D0", Offset = "0x8669FD0", VA = "0x18866B3D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected BUMCKPSQMDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x4FAF150", Offset = "0x4FADD50", VA = "0x184FAF150")]
		public BUMCKPSQMDJ(BUMCKPSQMDJ<a> a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4FAF120", Offset = "0x4FADD20", VA = "0x184FAF120")]
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
			[Cpp2IlInjected.Address(RVA = "0x867C9D0", Offset = "0x867B5D0", VA = "0x18867C9D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x867C930", Offset = "0x867B530", VA = "0x18867C930")]
		public ZIYZUENAFOS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x867C970", Offset = "0x867B570", VA = "0x18867C970")]
		public ZIYZUENAFOS(ZIYZUENAFOS a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x867C850", Offset = "0x867B450", VA = "0x18867C850")]
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
			[Cpp2IlInjected.Address(RVA = "0x86688C0", Offset = "0x86674C0", VA = "0x1886688C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8668880", Offset = "0x8667480", VA = "0x188668880")]
		public CCIZODPLJBR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x86687A0", Offset = "0x86673A0", VA = "0x1886687A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8674E90", Offset = "0x8673A90", VA = "0x188674E90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8674E50", Offset = "0x8673A50", VA = "0x188674E50")]
		public QJGNWPOVIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8674D70", Offset = "0x8673970", VA = "0x188674D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x867C7F0", Offset = "0x867B3F0", VA = "0x18867C7F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x867C7B0", Offset = "0x867B3B0", VA = "0x18867C7B0")]
		public ZGJGJNHLPBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x867C6D0", Offset = "0x867B2D0", VA = "0x18867C6D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86715F0", Offset = "0x86701F0", VA = "0x1886715F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x86715B0", Offset = "0x86701B0", VA = "0x1886715B0")]
		public NGZVCNLAQPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x86714D0", Offset = "0x86700D0", VA = "0x1886714D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8671950", Offset = "0x8670550", VA = "0x188671950", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x86718B0", Offset = "0x86704B0", VA = "0x1886718B0")]
		public NXKPCLUJUNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x86718F0", Offset = "0x86704F0", VA = "0x1886718F0")]
		public NXKPCLUJUNS(NXKPCLUJUNS a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x86717D0", Offset = "0x86703D0", VA = "0x1886717D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x866D050", Offset = "0x866BC50", VA = "0x18866D050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x866D010", Offset = "0x866BC10", VA = "0x18866D010")]
		public IUZCCLJFKFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x866CF30", Offset = "0x866BB30", VA = "0x18866CF30")]
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
			[Cpp2IlInjected.Address(RVA = "0x86744F0", Offset = "0x86730F0", VA = "0x1886744F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x86744B0", Offset = "0x86730B0", VA = "0x1886744B0")]
		public POILAGDGQRH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8674160", Offset = "0x8672D60", VA = "0x188674160")]
		public static POILAGDGQRH Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8674240", Offset = "0x8672E40", VA = "0x188674240")]
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
			[Cpp2IlInjected.Address(RVA = "0x8671770", Offset = "0x8670370", VA = "0x188671770", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8671730", Offset = "0x8670330", VA = "0x188671730")]
		public NXJSAPWDUNT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8671650", Offset = "0x8670250", VA = "0x188671650")]
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
			[Cpp2IlInjected.Address(RVA = "0x866BDC0", Offset = "0x866A9C0", VA = "0x18866BDC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x866BD80", Offset = "0x866A980", VA = "0x18866BD80")]
		public HMKNBQJCTRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x866BC80", Offset = "0x866A880", VA = "0x18866BC80")]
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
			[Cpp2IlInjected.Address(RVA = "0x866B370", Offset = "0x8669F70", VA = "0x18866B370", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x866B330", Offset = "0x8669F30", VA = "0x18866B330")]
		public DQIYXKVQHYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x866B250", Offset = "0x8669E50", VA = "0x18866B250")]
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
			[Cpp2IlInjected.Address(RVA = "0x8668500", Offset = "0x8667100", VA = "0x188668500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x86684C0", Offset = "0x86670C0", VA = "0x1886684C0")]
		public BLQLGAKNORS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x86683E0", Offset = "0x8666FE0", VA = "0x1886683E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8674100", Offset = "0x8672D00", VA = "0x188674100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x86740C0", Offset = "0x8672CC0", VA = "0x1886740C0")]
		public OWKTOJURGXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8674060", Offset = "0x8672C60", VA = "0x188674060")]
		public OWKTOJURGXA(OWKTOJURGXA a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8673F80", Offset = "0x8672B80", VA = "0x188673F80")]
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
			[Cpp2IlInjected.Address(RVA = "0x867B4A0", Offset = "0x867A0A0", VA = "0x18867B4A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x867B460", Offset = "0x867A060", VA = "0x18867B460")]
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
		[Cpp2IlInjected.Address(RVA = "0x866B550", Offset = "0x866A150", VA = "0x18866B550")]
		public UETACDQNYLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8679460", Offset = "0x8678060", VA = "0x188679460")]
		public static UETACDQNYLA Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x86796A0", Offset = "0x86782A0", VA = "0x1886796A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86682D0", Offset = "0x8666ED0", VA = "0x1886682D0")]
		public AHICOKAOCWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8667960", Offset = "0x8666560", VA = "0x188667960")]
		public static AHICOKAOCWI Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8667E70", Offset = "0x8666A70", VA = "0x188667E70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x867C6C0", Offset = "0x867B2C0", VA = "0x18867C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x866B550", Offset = "0x866A150", VA = "0x18866B550")]
		public KHWXUNVOHHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x866DD00", Offset = "0x866C900", VA = "0x18866DD00")]
		public static KHWXUNVOHHW Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x866E0C0", Offset = "0x866CCC0", VA = "0x18866E0C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8669900", Offset = "0x8668500", VA = "0x188669900")]
		public static WZUSVTJTHOV QUKEKYDBLNW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8669190", Offset = "0x8667D90", VA = "0x188669190")]
		public static FIQFCBAKEMU DBMXKOBXGKW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public DALVVYWBMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x866AB50", Offset = "0x8669750", VA = "0x18866AB50")]
		public DALVVYWBMJK(DALVVYWBMJK a, [Optional] TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8669A90", Offset = "0x8668690", VA = "0x188669A90")]
		public void XQMSTMGATJZ(TBEADDWHLOJ a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8669600", Offset = "0x8668200", VA = "0x188669600")]
		public void JVEWYECKUYU(string a, FIQFCBAKEMU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8669810", Offset = "0x8668410", VA = "0x188669810")]
		private void OWGKQOBSCHO(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x86690D0", Offset = "0x8667CD0", VA = "0x1886690D0")]
		private void BTNZEZPVVRO(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8669750", Offset = "0x8668350", VA = "0x188669750")]
		private void OGCBUBBXEHG(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8669D40", Offset = "0x8668940", VA = "0x188669D40")]
		internal static Dictionary<string, FIQFCBAKEMU> YCPDIXISYBP(TBEADDWHLOJ a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8669280", Offset = "0x8667E80", VA = "0x188669280", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public BYJCWIUQJEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8668750", Offset = "0x8667350", VA = "0x188668750")]
			internal UCTZRFDQUFN WIMZBMUJMGL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x8668740", Offset = "0x8667340", VA = "0x188668740")]
			internal KTVCVTRZYQB WIHSEGAMCVC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x8668770", Offset = "0x8667370", VA = "0x188668770")]
			internal XLUTOTUKWDR WIXMWAIEFDD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x8668760", Offset = "0x8667360", VA = "0x188668760")]
			internal UMJJFNXSQAT WISFYTOGVRU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x8668710", Offset = "0x8667310", VA = "0x188668710")]
			internal LUUSNAFKXGC WHRXMLSUANB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x8668700", Offset = "0x8667300", VA = "0x188668700")]
			internal UETACDQNYLA WHMQPEYWRBS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x8668730", Offset = "0x8667330", VA = "0x188668730")]
			internal AHICOKAOCWI WICLGZGOTJT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x8668720", Offset = "0x8667320", VA = "0x188668720")]
			internal KHWXUNVOHHW WHXEJSMRJYK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x8668790", Offset = "0x8667390", VA = "0x188668790")]
			internal KTFAJFRQMLO WKDCFOXOJTF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x8668780", Offset = "0x8667380", VA = "0x188668780")]
			internal Sampler WJXVIIDRAHW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x8668560", Offset = "0x8667160", VA = "0x188668560")]
			internal ZZHEPEFHRAT BANXTOISTOM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x86686E0", Offset = "0x86672E0", VA = "0x1886686E0")]
			internal WVIQGMXWUFX BATEQVCQCZV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x86686F0", Offset = "0x86672F0", VA = "0x1886686F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8678F00", Offset = "0x8677B00", VA = "0x188678F00")]
		public TBEADDWHLOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8678E60", Offset = "0x8677A60", VA = "0x188678E60")]
		public ZZHEPEFHRAT JPLWEIOJFFB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8676460", Offset = "0x8675060", VA = "0x188676460")]
		public static TBEADDWHLOJ Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x86772B0", Offset = "0x8675EB0", VA = "0x1886772B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x866B550", Offset = "0x866A150", VA = "0x18866B550")]
		public ZZHEPEFHRAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x867D490", Offset = "0x867C090", VA = "0x18867D490")]
		public static ZZHEPEFHRAT Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x867D610", Offset = "0x867C210", VA = "0x18867D610", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x866B550", Offset = "0x866A150", VA = "0x18866B550")]
		public JQEEIHSQRHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x866D9C0", Offset = "0x866C5C0", VA = "0x18866D9C0")]
		public static JQEEIHSQRHG Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x866DB90", Offset = "0x866C790", VA = "0x18866DB90", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class OKAKPSYKXAJ : GFNUOXQYSQT
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x866B550", Offset = "0x866A150", VA = "0x18866B550")]
		public OKAKPSYKXAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x86719B0", Offset = "0x86705B0", VA = "0x1886719B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x866B550", Offset = "0x866A150", VA = "0x18866B550")]
		public GFNUOXQYSQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x866BA00", Offset = "0x866A600", VA = "0x18866BA00", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class WRUZPKLGOCL : GFNUOXQYSQT
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x866B550", Offset = "0x866A150", VA = "0x18866B550")]
		public WRUZPKLGOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x86719B0", Offset = "0x86705B0", VA = "0x1886719B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x867D440", Offset = "0x867C040", VA = "0x18867D440")]
		public ZWALPDDCKOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x867D140", Offset = "0x867BD40", VA = "0x18867D140", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x867B3B0", Offset = "0x8679FB0", VA = "0x18867B3B0", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public WASHJNLBXSK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class UWXWUMOQQYU : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8679D60", Offset = "0x8678960", VA = "0x188679D60", Slot = "4")]
		public override FIQFCBAKEMU Deserialize(TBEADDWHLOJ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x866C990", Offset = "0x866B590", VA = "0x18866C990")]
		public IUASTIQFQVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x866C490", Offset = "0x866B090", VA = "0x18866C490")]
		public static IUASTIQFQVK Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x866C730", Offset = "0x866B330", VA = "0x18866C730", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x866B1F0", Offset = "0x8669DF0", VA = "0x18866B1F0")]
		public DLLPPIABIIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x866AE40", Offset = "0x8669A40", VA = "0x18866AE40")]
		public new static DLLPPIABIIS Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x866B130", Offset = "0x8669D30", VA = "0x18866B130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x866B1F0", Offset = "0x8669DF0", VA = "0x18866B1F0")]
		public QCXDUOOYVAQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8674550", Offset = "0x8673150", VA = "0x188674550")]
		public new static QCXDUOOYVAQ Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8674840", Offset = "0x8673440", VA = "0x188674840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x866C420", Offset = "0x866B020", VA = "0x18866C420")]
		public HNMBPMXVUOV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x866BE20", Offset = "0x866AA20", VA = "0x18866BE20")]
		public static HNMBPMXVUOV Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x866C190", Offset = "0x866AD90", VA = "0x18866C190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public VIHYUHFKEDV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x8679E80", Offset = "0x8678A80", VA = "0x188679E80")]
			internal ZIYZUENAFOS WIMZBMUJMGL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x8679DD0", Offset = "0x86789D0", VA = "0x188679DD0")]
			internal Dictionary<string, ZIYZUENAFOS> WIHSEGAMCVC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x8679F50", Offset = "0x8678B50", VA = "0x188679F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8673350", Offset = "0x8671F50", VA = "0x188673350")]
		public ORTIZQKCQUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8672CB0", Offset = "0x86718B0", VA = "0x188672CB0")]
		public ORTIZQKCQUO(ORTIZQKCQUO a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8672820", Offset = "0x8671420", VA = "0x188672820")]
		public static int[] QEJYZYLHQKE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8671A30", Offset = "0x8670630", VA = "0x188671A30")]
		public static int[] CLKEILCUZLW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8672660", Offset = "0x8671260", VA = "0x188672660")]
		public static int[] MHXVOGXQLLU(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x86728C0", Offset = "0x86714C0", VA = "0x1886728C0")]
		public static int[] QRMWEJKJIZQ(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8672B00", Offset = "0x8671700", VA = "0x188672B00")]
		public static int[] SJTABDZKOFD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8672C40", Offset = "0x8671840", VA = "0x188672C40")]
		public static int[] ZSAYTTLQKGY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8672BB0", Offset = "0x86717B0", VA = "0x188672BB0")]
		public static int[] XHMKPOYAKHM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x86719C0", Offset = "0x86705C0", VA = "0x1886719C0")]
		public static int[] BWNMDBBIXNL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x86725D0", Offset = "0x86711D0", VA = "0x1886725D0")]
		public static int[] GRXLODWQKWP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8671B90", Offset = "0x8670790", VA = "0x188671B90")]
		public static ORTIZQKCQUO Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8671FE0", Offset = "0x8670BE0", VA = "0x188671FE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x866FBB0", Offset = "0x866E7B0", VA = "0x18866FBB0")]
		public KTFAJFRQMLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x866E670", Offset = "0x866D270", VA = "0x18866E670")]
		public static KTFAJFRQMLO Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x866EFB0", Offset = "0x866DBB0", VA = "0x18866EFB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86763F0", Offset = "0x8674FF0", VA = "0x1886763F0")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8675F30", Offset = "0x8674B30", VA = "0x188675F30")]
		public static Sampler Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8676200", Offset = "0x8674E00", VA = "0x188676200", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x867C2F0", Offset = "0x867AEF0", VA = "0x18867C2F0")]
		public WVIQGMXWUFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x867BC80", Offset = "0x867A880", VA = "0x18867BC80")]
		public static WVIQGMXWUFX Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x867BFE0", Offset = "0x867ABE0", VA = "0x18867BFE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8670BC0", Offset = "0x866F7C0", VA = "0x188670BC0")]
		public LIQIFNODJDV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8670C10", Offset = "0x866F810", VA = "0x188670C10")]
		public LIQIFNODJDV(LIQIFNODJDV a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8670810", Offset = "0x866F410", VA = "0x188670810")]
		public static LIQIFNODJDV Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8670A90", Offset = "0x866F690", VA = "0x188670A90", Slot = "4")]
		public override void GHRXOLGFAHI(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8670AF0", Offset = "0x866F6F0", VA = "0x188670AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8669050", Offset = "0x8667C50", VA = "0x188669050")]
		public CXAZVWAUMHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8668B90", Offset = "0x8667790", VA = "0x188668B90")]
		public static CXAZVWAUMHS Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8668DE0", Offset = "0x86679E0", VA = "0x188668DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8675E70", Offset = "0x8674A70", VA = "0x188675E70")]
		public SKAMIMXDTSS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8675D40", Offset = "0x8674940", VA = "0x188675D40")]
		public SKAMIMXDTSS(SKAMIMXDTSS a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8675570", Offset = "0x8674170", VA = "0x188675570")]
		public static SKAMIMXDTSS Deserialize(TBEADDWHLOJ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8675450", Offset = "0x8674050", VA = "0x188675450")]
		public static SKAMIMXDTSS Deserialize(TBEADDWHLOJ root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8675960", Offset = "0x8674560", VA = "0x188675960", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public JKAJQXYXEUM(IList<GFNUOXQYSQT> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x866D120", Offset = "0x866BD20", VA = "0x18866D120", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x866D0B0", Offset = "0x866BCB0", VA = "0x18866D0B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x867AEE0", Offset = "0x8679AE0", VA = "0x18867AEE0")]
		public VRGNOGHOBRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x867A020", Offset = "0x8678C20", VA = "0x18867A020", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x867A2B0", Offset = "0x8678EB0", VA = "0x18867A2B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x867AC30", Offset = "0x8679830", VA = "0x18867AC30")]
		private static string[] YGFXQPKBDYS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x867A790", Offset = "0x8679390", VA = "0x18867A790")]
		private static AITVUNWJGXJ.ImportValuesConversion VHGNLPZUQQU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x867A3A0", Offset = "0x8678FA0", VA = "0x18867A3A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8668A40", Offset = "0x8667640", VA = "0x188668A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8668A00", Offset = "0x8667600", VA = "0x188668A00")]
		public CVEUBEPSZNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8668920", Offset = "0x8667520", VA = "0x188668920")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public WPSMMAUSHZK(CVEUBEPSZNB a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x867BBC0", Offset = "0x867A7C0", VA = "0x18867BBC0")]
		public WPSMMAUSHZK(int a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x867BA40", Offset = "0x867A640", VA = "0x18867BA40", Slot = "5")]
		public FIQFCBAKEMU Clone(TBEADDWHLOJ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x867BAC0", Offset = "0x867A6C0", VA = "0x18867BAC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class IUQILVDSKJD : WZUSVTJTHOV
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x866CEE0", Offset = "0x866BAE0", VA = "0x18866CEE0")]
		public IUQILVDSKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x866CA00", Offset = "0x866B600", VA = "0x18866CA00", Slot = "4")]
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
