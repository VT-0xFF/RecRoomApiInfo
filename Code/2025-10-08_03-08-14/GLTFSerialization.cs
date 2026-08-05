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
	public class KHR_animation_pointer : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object CMWUKYBCLEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string RSRFYEIPMZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string VRHZLUCHVKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public TBXOMPZOVHF BIRSLHICCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer PNWEIERSSQY;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x73A9CA0", Offset = "0x73A8AA0", VA = "0x1873A9CA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x73A9BF0", Offset = "0x73A89F0", VA = "0x1873A9BF0", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class KSKNQJNKXRM
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 BHPVIPDYLCN;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 TDTJEAQBFCI;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion NTEZHGLNDFK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool ERWJBPHMPLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x73AE8A0", Offset = "0x73AD6A0", VA = "0x1873AE8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x73AD6E0", Offset = "0x73AC4E0", VA = "0x1873AD6E0")]
		public static void DMMDVVNAPNG(this FDTJOQJNBIL a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x73AE3A0", Offset = "0x73AD1A0", VA = "0x1873AE3A0")]
		public static void LRDPCEDDUDE(this FDTJOQJNBIL a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73B0700", Offset = "0x73AF500", VA = "0x1873B0700")]
		public static void WBLLRFDHXJT(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73AEFB0", Offset = "0x73ADDB0", VA = "0x1873AEFB0")]
		public static GLTF.Math.Vector4 OYKOTBAKIJR(this HGASQPLNLGW a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x73AEA60", Offset = "0x73AD860", VA = "0x1873AEA60")]
		public static UnityEngine.Quaternion MCDYRTGMSVI(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x73AE930", Offset = "0x73AD730", VA = "0x1873AE930")]
		public static UnityEngine.Quaternion MCDYRTGMSVI(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x73AEE70", Offset = "0x73ADC70", VA = "0x1873AEE70")]
		public static GLTF.Math.Quaternion NGTSXDDJOKK(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x73AFD70", Offset = "0x73AEB70", VA = "0x1873AFD70")]
		public static Matrix4x4 SCTCVKZZOND(this HGASQPLNLGW a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x73AFF90", Offset = "0x73AED90", VA = "0x1873AFF90")]
		public static Matrix4x4 SCTCVKZZOND(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x73AF1D0", Offset = "0x73ADFD0", VA = "0x1873AF1D0")]
		public static HGASQPLNLGW PTWGLLCCJCB(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x73AD430", Offset = "0x73AC230", VA = "0x1873AD430")]
		public static UnityEngine.Vector3 CKMDCJHSXGA(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x73AD550", Offset = "0x73AC350", VA = "0x1873AD550")]
		public static UnityEngine.Vector3 CKMDCJHSXGA(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x73AE270", Offset = "0x73AD070", VA = "0x1873AE270")]
		public static GLTF.Math.Vector3 LJLEGISMJYI(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x73AD620", Offset = "0x73AC420", VA = "0x1873AD620")]
		public static GLTF.Math.Vector3 CYZUDJKKYEN(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x134EC70", Offset = "0x134DA70", VA = "0x18134EC70")]
		public static GLTF.Math.Vector4 DKOGDXWKPJM(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x73AF6B0", Offset = "0x73AE4B0", VA = "0x1873AF6B0")]
		public static Matrix4x4 REGNAWLRZAU(this HGASQPLNLGW a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x73AF970", Offset = "0x73AE770", VA = "0x1873AF970")]
		public static Matrix4x4 REGNAWLRZAU(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x73ADDD0", Offset = "0x73ACBD0", VA = "0x1873ADDD0")]
		public static HGASQPLNLGW HAXDEHUOGHW(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x73ADFA0", Offset = "0x73ACDA0", VA = "0x1873ADFA0")]
		public static UnityEngine.Vector2 JFCWGUOOUHW(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x73ADFA0", Offset = "0x73ACDA0", VA = "0x1873ADFA0")]
		public static UnityEngine.Vector2 JFCWGUOOUHW(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x73ADFC0", Offset = "0x73ACDC0", VA = "0x1873ADFC0")]
		public static void JFCWGUOOUHW(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x73ADD70", Offset = "0x73ACB70", VA = "0x1873ADD70")]
		public static UnityEngine.Vector3 DURDPFDJEYZ(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D38970", Offset = "0x1D37770", VA = "0x181D38970")]
		public static UnityEngine.Vector3 DURDPFDJEYZ(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x73ADC80", Offset = "0x73ACA80", VA = "0x1873ADC80")]
		public static void DURDPFDJEYZ(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x134EC70", Offset = "0x134DA70", VA = "0x18134EC70")]
		public static UnityEngine.Vector4 MYVHDHAMGOC(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x134EC70", Offset = "0x134DA70", VA = "0x18134EC70")]
		public static UnityEngine.Vector4 MYVHDHAMGOC(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x73AED70", Offset = "0x73ADB70", VA = "0x1873AED70")]
		public static UnityEngine.Vector4[] MYVHDHAMGOC(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x73AEC60", Offset = "0x73ADA60", VA = "0x1873AEC60")]
		public static void MYVHDHAMGOC(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x73AE1D0", Offset = "0x73ACFD0", VA = "0x1873AE1D0")]
		public static UnityEngine.Color JRWSPTHUWOM(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x73AE090", Offset = "0x73ACE90", VA = "0x1873AE090")]
		public static void JRWSPTHUWOM(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x73AE1D0", Offset = "0x73ACFD0", VA = "0x1873AE1D0")]
		public static UnityEngine.Color JRWSPTHUWOM(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x134EC70", Offset = "0x134DA70", VA = "0x18134EC70")]
		public static UnityEngine.Color RNZQXGHLFJJ(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x73AFBE0", Offset = "0x73AE9E0", VA = "0x1873AFBE0")]
		public static void RNZQXGHLFJJ(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x134EC70", Offset = "0x134DA70", VA = "0x18134EC70")]
		public static UnityEngine.Color RNZQXGHLFJJ(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x73B0AD0", Offset = "0x73AF8D0", VA = "0x1873B0AD0")]
		public static GLTF.Math.Color XXNJYDGQODD(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x73AEBE0", Offset = "0x73AD9E0", VA = "0x1873AEBE0")]
		public static GLTF.Math.Color MDBPBFHUGTC(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x73AFCF0", Offset = "0x73AEAF0", VA = "0x1873AFCF0")]
		public static GLTF.Math.Color RVPFOQMYPHQ(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x73B0480", Offset = "0x73AF280", VA = "0x1873B0480")]
		public static UnityEngine.Color[] SUZDEEZRIAL(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x73AD660", Offset = "0x73AC460", VA = "0x1873AD660")]
		public static int[] CZSCBRXFGFE(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x73B03D0", Offset = "0x73AF1D0", VA = "0x1873B03D0")]
		public static UnityEngine.Vector2[] SGDGVBPTETT(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x73B05A0", Offset = "0x73AF3A0", VA = "0x1873B05A0")]
		public static void VBCNSWOCXVY(GRYQYIWVGUK a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x73AD2D0", Offset = "0x73AC0D0", VA = "0x1873AD2D0")]
		public static UnityEngine.Vector3[] CDSZZNNYEOS(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x73AF510", Offset = "0x73AE310", VA = "0x1873AF510")]
		public static UnityEngine.Vector4[] PZPZPKZRHST(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x73B0B00", Offset = "0x73AF900", VA = "0x1873B0B00")]
		public static void ZJSYSIFYNIC(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x73AD2A0", Offset = "0x73AC0A0", VA = "0x1873AD2A0")]
		public static UnityEngine.Quaternion CBVXRDLPVEM(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class GRYQYIWVGUK
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RIFMZTUJKPT RIFMZTUJKPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray TSAJYTCWSAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x73A6AD0", Offset = "0x73A58D0", VA = "0x1873A6AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> JHYYZKJLKXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xED04F0", Offset = "0xECF2F0", VA = "0x180ED04F0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xFAD4B0", Offset = "0xFAC2B0", VA = "0x180FAD4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint APVUGZXIKWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAC6560", Offset = "0xAC5360", VA = "0x180AC6560")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAC6870", Offset = "0xAC5670", VA = "0x180AC6870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x73A6AE0", Offset = "0x73A58E0", VA = "0x1873A6AE0")]
		public GRYQYIWVGUK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x73A65C0", Offset = "0x73A53C0", VA = "0x1873A65C0")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x73A6620", Offset = "0x73A5420", VA = "0x1873A6620")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class XLZPFVVALID
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class YOTMQGABZWI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> QPYUWXRTWZA;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public YOTMQGABZWI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x73BF280", Offset = "0x73BE080", VA = "0x1873BF280")]
			internal int? GVNGOVKIVRB(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x73BF300", Offset = "0x73BE100", VA = "0x1873BF300")]
			internal int? PURKPQIVBYK(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x73BF390", Offset = "0x73BE190", VA = "0x1873BF390")]
			internal bool ZODGHIBRYVA(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x73BD8A0", Offset = "0x73BC6A0", VA = "0x1873BD8A0")]
		private static void ZMRJCPKEVNC(NumericArray a, GRYQYIWVGUK b, GRYQYIWVGUK c, GRYQYIWVGUK d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x73BB3F0", Offset = "0x73BA1F0", VA = "0x1873BB3F0")]
		public static void FPXOBPIIPXT(Dictionary<string, GRYQYIWVGUK> a, Dictionary<string, (GRYQYIWVGUK sparseIndices, GRYQYIWVGUK sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x73BCD40", Offset = "0x73BBB40", VA = "0x1873BCD40")]
		public static void NJGHQLSNYXL(Dictionary<string, GRYQYIWVGUK> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x73BCC40", Offset = "0x73BBA40", VA = "0x1873BCC40")]
		public static void JSPQWRYZFTE(GRYQYIWVGUK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x73BC6B0", Offset = "0x73BB4B0", VA = "0x1873BC6B0")]
		public static void FUIGVKCIWZS(Dictionary<string, List<GRYQYIWVGUK>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x73BD6B0", Offset = "0x73BC4B0", VA = "0x1873BD6B0")]
		private static void SLWWQAMXSKU(GRYQYIWVGUK a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x73BD7E0", Offset = "0x73BC5E0", VA = "0x1873BD7E0")]
		internal static void SLWWQAMXSKU(KUARRPWGPHO a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x73BD220", Offset = "0x73BC020", VA = "0x1873BD220")]
		public static SQMEOXSHHQG RXWBUJCIGDS(IEnumerable<SQMEOXSHHQG> a)
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
			[Cpp2IlInjected.Address(RVA = "0xDB2230", Offset = "0xDB1030", VA = "0x180DB2230")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30206B0", Offset = "0x301F4B0", VA = "0x1830206B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30206C0", Offset = "0x301F4C0", VA = "0x1830206C0")]
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
	public class TOBGRWMNYSJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint ZFTZEGSGLJM;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint AFDRJSZUVEM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint AAENDMWKHCW;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x73BA660", Offset = "0x73B9460", VA = "0x1873BA660")]
		public static void WBCYCCRHZKE(Stream a, [Out] RSKHWHICBEK b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x73B9EA0", Offset = "0x73B8CA0", VA = "0x1873B9EA0")]
		public static ChunkInfo NBIZOLKRTKU(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x73BA520", Offset = "0x73B9320", VA = "0x1873BA520")]
		public static GLBHeader SAMWLDVHMOI(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x73BA130", Offset = "0x73B8F30", VA = "0x1873BA130")]
		public static bool NOJWUUXEGKC(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x73BA820", Offset = "0x73B9620", VA = "0x1873BA820")]
		public static ChunkInfo ZPWBQBHHTBN(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x73BA280", Offset = "0x73B9080", VA = "0x1873BA280")]
		private static void PJKAELWHFXX(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x73BA1F0", Offset = "0x73B8FF0", VA = "0x1873BA1F0")]
		private static uint NSJXWBHCNPW(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class YMCPNEEYTNV
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
		public PathElement XZALWAKQYXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int CVPZGQUGLTT
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xBBC340", Offset = "0xBBB140", VA = "0x180BBC340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string XORSPTWZVFU
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ACTGHNAGAFF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xAC0160", VA = "0x180AC1360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FD0", Offset = "0xABFDD0", VA = "0x180AC0FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public YMCPNEEYTNV ECWVUQIRZLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x73BEC90", Offset = "0x73BDA90", VA = "0x1873BEC90")]
		public string BEMXQORUZGT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x73BED10", Offset = "0x73BDB10", VA = "0x1873BED10")]
		public YMCPNEEYTNV KQXXAAHDEKZ(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x73BF100", Offset = "0x73BDF00", VA = "0x1873BF100")]
		private YMCPNEEYTNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x73BEF50", Offset = "0x73BDD50", VA = "0x1873BEF50")]
		public YMCPNEEYTNV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x42E98C0", Offset = "0x42E86C0", VA = "0x1842E98C0")]
		[CompilerGenerated]
		internal static string AGFUTMSRNVB(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x73BEF10", Offset = "0x73BDD10", VA = "0x1873BEF10")]
		[CompilerGenerated]
		internal static bool YLDEUMUXBNI([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x73BED30", Offset = "0x73BDB30", VA = "0x1873BED30")]
		[CompilerGenerated]
		internal static YMCPNEEYTNV RDBMODEIPEU(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class LBEJYBHDWIE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x73B0D70", Offset = "0x73AFB70", VA = "0x1873B0D70")]
		public static int[] LWRKKROPGNA(this RSKHWHICBEK a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x73B1010", Offset = "0x73AFE10", VA = "0x1873B1010")]
		public static int[] YEHBHQFLTKE(this RSKHWHICBEK a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class RCRUHTDTKTG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x73B3350", Offset = "0x73B2150", VA = "0x1873B3350")]
		public static uint GPDFPKKVWGT(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream CHIDYGLMDUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long JJQYPAGGLIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long KEDWXZSAMHF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x73B9DC0", Offset = "0x73B8BC0", VA = "0x1873B9DC0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x73B9E00", Offset = "0x73B8C00", VA = "0x1873B9E00", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x73B9E00", Offset = "0x73B8C00", VA = "0x1873B9E00", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x73B9E20", Offset = "0x73B8C20", VA = "0x1873B9E20", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x73B9E40", Offset = "0x73B8C40", VA = "0x1873B9E40", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x73B9E60", Offset = "0x73B8C60", VA = "0x1873B9E60", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x73B9B50", Offset = "0x73B8950", VA = "0x1873B9B50")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x73B9910", Offset = "0x73B8710", VA = "0x1873B9910", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x73B9A70", Offset = "0x73B8870", VA = "0x1873B9A70", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x73B9AD0", Offset = "0x73B88D0", VA = "0x1873B9AD0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x73B99E0", Offset = "0x73B87E0", VA = "0x1873B99E0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x73B9B10", Offset = "0x73B8910", VA = "0x1873B9B10", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x73B9950", Offset = "0x73B8750", VA = "0x1873B9950")]
		private void PNIBTSQIHAO()
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
		public static Color ZCIOMNRJTFI
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x73A6230", Offset = "0x73A5030", VA = "0x1873A6230")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color CIHCSXGCOWE
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x73A6220", Offset = "0x73A5020", VA = "0x1873A6220")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color IKOBVOMNMCE
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x73A5F50", Offset = "0x73A4D50", VA = "0x1873A5F50")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2D385A0", Offset = "0x2D373A0", VA = "0x182D385A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2D3A2B0", Offset = "0x2D390B0", VA = "0x182D3A2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2D94830", Offset = "0x2D93630", VA = "0x182D94830")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2D94840", Offset = "0x2D93640", VA = "0x182D94840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2B13D70", Offset = "0x2B12B70", VA = "0x182B13D70")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x3215FF0", Offset = "0x3214DF0", VA = "0x183215FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1509F80", Offset = "0x1508D80", VA = "0x181509F80")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1509F90", Offset = "0x1508D90", VA = "0x181509F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2AD5BC0", Offset = "0x2AD49C0", VA = "0x182AD5BC0")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x73A6020", Offset = "0x73A4E20", VA = "0x1873A6020", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x73A60D0", Offset = "0x73A4ED0", VA = "0x1873A60D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x73A6170", Offset = "0x73A4F70", VA = "0x1873A6170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x73A5F70", Offset = "0x73A4D70", VA = "0x1873A5F70")]
		public static bool CQBJVGKOTGK(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class HGASQPLNLGW : IEquatable<HGASQPLNLGW>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly HGASQPLNLGW HIWLSQYHTOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] SWLGDKLPDSD;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float FQTPGFXTKWI
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x73A7440", Offset = "0x73A6240", VA = "0x1873A7440")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x73A7650", Offset = "0x73A6450", VA = "0x1873A7650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float KPEOEQNGIPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x73A72C0", Offset = "0x73A60C0", VA = "0x1873A72C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x73A74D0", Offset = "0x73A62D0", VA = "0x1873A74D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float RPLFIVHOFLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x73A7770", Offset = "0x73A6570", VA = "0x1873A7770")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x73A73E0", Offset = "0x73A61E0", VA = "0x1873A73E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float XUGPKWIVFAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x73A75F0", Offset = "0x73A63F0", VA = "0x1873A75F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x73A6EA0", Offset = "0x73A5CA0", VA = "0x1873A6EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FRJJYAFLNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x73A7470", Offset = "0x73A6270", VA = "0x1873A7470")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x73A7680", Offset = "0x73A6480", VA = "0x1873A7680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float KPJVBXHDSBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x73A7320", Offset = "0x73A6120", VA = "0x1873A7320")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x73A7530", Offset = "0x73A6330", VA = "0x1873A7530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float RPFYLONQWAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x73A7710", Offset = "0x73A6510", VA = "0x1873A7710")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x73A7380", Offset = "0x73A6180", VA = "0x1873A7380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float XTQUTCBDCSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x73A75C0", Offset = "0x73A63C0", VA = "0x1873A75C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x73A6E70", Offset = "0x73A5C70", VA = "0x1873A6E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float FREDATLODTA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x73A74A0", Offset = "0x73A62A0", VA = "0x1873A74A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x73A76B0", Offset = "0x73A64B0", VA = "0x1873A76B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float KPPBZEBBBMR
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x73A72F0", Offset = "0x73A60F0", VA = "0x1873A72F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x73A7500", Offset = "0x73A6300", VA = "0x1873A7500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float RPAROHTTMOY
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x73A7740", Offset = "0x73A6540", VA = "0x1873A7740")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x73A73B0", Offset = "0x73A61B0", VA = "0x1873A73B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float XTWBQIVAMDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x73A7590", Offset = "0x73A6390", VA = "0x1873A7590")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x73A6E40", Offset = "0x73A5C40", VA = "0x1873A6E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float FQDUOLQBIOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x73A7410", Offset = "0x73A6210", VA = "0x1873A7410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x73A76E0", Offset = "0x73A64E0", VA = "0x1873A76E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float KOEFSIRTNLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x73A7290", Offset = "0x73A6090", VA = "0x1873A7290")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x73A7560", Offset = "0x73A6360", VA = "0x1873A7560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float ROVKRAZWDDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x73A6DE0", Offset = "0x73A5BE0", VA = "0x1873A6DE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x73A7350", Offset = "0x73A6150", VA = "0x1873A7350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float XTGGYONIJVY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x73A7620", Offset = "0x73A6420", VA = "0x1873A7620")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x73A6E10", Offset = "0x73A5C10", VA = "0x1873A6E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x73A7870", Offset = "0x73A6670", VA = "0x1873A7870")]
		public HGASQPLNLGW(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x73A6ED0", Offset = "0x73A5CD0", VA = "0x1873A6ED0", Slot = "4")]
		public bool Equals(HGASQPLNLGW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x73A7190", Offset = "0x73A5F90", VA = "0x1873A7190", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x10D93F0", Offset = "0x10D81F0", VA = "0x1810D93F0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D385A0", Offset = "0x2D373A0", VA = "0x182D385A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x2D3A2B0", Offset = "0x2D390B0", VA = "0x182D3A2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2D94830", Offset = "0x2D93630", VA = "0x182D94830")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2D94840", Offset = "0x2D93640", VA = "0x182D94840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2B13D70", Offset = "0x2B12B70", VA = "0x182B13D70")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x3215FF0", Offset = "0x3214DF0", VA = "0x183215FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1509F80", Offset = "0x1508D80", VA = "0x181509F80")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1509F90", Offset = "0x1508D90", VA = "0x181509F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x73B2B90", Offset = "0x73B1990", VA = "0x1873B2B90")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x73B2870", Offset = "0x73B1670", VA = "0x1873B2870", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x73B2990", Offset = "0x73B1790", VA = "0x1873B2990", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x73B2A40", Offset = "0x73B1840", VA = "0x1873B2A40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x73B2800", Offset = "0x73B1600", VA = "0x1873B2800")]
		public static bool CQBJVGKOTGK(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2D385A0", Offset = "0x2D373A0", VA = "0x182D385A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x2D3A2B0", Offset = "0x2D390B0", VA = "0x182D3A2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2D94830", Offset = "0x2D93630", VA = "0x182D94830")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2D94840", Offset = "0x2D93640", VA = "0x182D94840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x102FDC0", Offset = "0x102EBC0", VA = "0x18102FDC0")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x73BAEA0", Offset = "0x73B9CA0", VA = "0x1873BAEA0")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x73BAD10", Offset = "0x73B9B10", VA = "0x1873BAD10", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x73BAD70", Offset = "0x73B9B70", VA = "0x1873BAD70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x73BAE50", Offset = "0x73B9C50", VA = "0x1873BAE50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x73BACB0", Offset = "0x73B9AB0", VA = "0x1873BACB0")]
		public static bool CQBJVGKOTGK(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2D385A0", Offset = "0x2D373A0", VA = "0x182D385A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x2D3A2B0", Offset = "0x2D390B0", VA = "0x182D3A2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2D94830", Offset = "0x2D93630", VA = "0x182D94830")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2D94840", Offset = "0x2D93640", VA = "0x182D94840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2B13D70", Offset = "0x2B12B70", VA = "0x182B13D70")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x3215FF0", Offset = "0x3214DF0", VA = "0x183215FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x73BB250", Offset = "0x73BA050", VA = "0x1873BB250")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x73BAF30", Offset = "0x73B9D30", VA = "0x1873BAF30", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x73BB010", Offset = "0x73B9E10", VA = "0x1873BB010", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x73BB0D0", Offset = "0x73B9ED0", VA = "0x1873BB0D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x73BAEC0", Offset = "0x73B9CC0", VA = "0x1873BAEC0")]
		public static bool CQBJVGKOTGK(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2D385A0", Offset = "0x2D373A0", VA = "0x182D385A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2D3A2B0", Offset = "0x2D390B0", VA = "0x182D3A2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2D94830", Offset = "0x2D93630", VA = "0x182D94830")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2D94840", Offset = "0x2D93640", VA = "0x182D94840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2B13D70", Offset = "0x2B12B70", VA = "0x182B13D70")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x3215FF0", Offset = "0x3214DF0", VA = "0x183215FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1509F80", Offset = "0x1508D80", VA = "0x181509F80")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1509F90", Offset = "0x1508D90", VA = "0x181509F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AD5BC0", Offset = "0x2AD49C0", VA = "0x182AD5BC0")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x73A6020", Offset = "0x73A4E20", VA = "0x1873A6020", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x73BB2D0", Offset = "0x73BA0D0", VA = "0x1873BB2D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x73A6170", Offset = "0x73A4F70", VA = "0x1873A6170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class WUEPHPSYRYE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x73BB370", Offset = "0x73BA170", VA = "0x1873BB370")]
		public static void SGTBWHQIJPD(this JObject a, string b, CJAUEKHAZRY c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class RCRUHTDTKTG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x73B31A0", Offset = "0x73B1FA0", VA = "0x1873B31A0")]
		public static List<string> FCFCQEVXYGG(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x73B4590", Offset = "0x73B3390", VA = "0x1873B4590")]
		public static List<double> XASGKXYOLZM(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x73B34A0", Offset = "0x73B22A0", VA = "0x1873B34A0")]
		public static List<int> HXXWZJLQAIR(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C28580", Offset = "0x3C27380", VA = "0x183C28580")]
		public static List<a> MNKYQYWHTYP<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x73B4750", Offset = "0x73B3550", VA = "0x1873B4750")]
		public static CJAUEKHAZRY ZAFRRKZUNMN(this JToken a, RSKHWHICBEK b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x73B3EA0", Offset = "0x73B2CA0", VA = "0x1873B3EA0")]
		public static int TSLLHXEFXNR(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x73B4450", Offset = "0x73B3250", VA = "0x1873B4450")]
		public static double VBBYENVQIJR(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x73B2C20", Offset = "0x73B1A20", VA = "0x1873B2C20")]
		public static GLTF.Math.Color BXHVLJRJEMQ(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x73B3C30", Offset = "0x73B2A30", VA = "0x1873B3C30")]
		public static GLTF.Math.Color MVQNBYIYGEJ(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x73B2F00", Offset = "0x73B1D00", VA = "0x1873B2F00")]
		public static GLTF.Math.Color CPTIUTNHKHL(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x73B3660", Offset = "0x73B2460", VA = "0x1873B3660")]
		public static GLTF.Math.Vector3 JEVRVFKAJDT(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x73B4240", Offset = "0x73B3040", VA = "0x1873B4240")]
		public static GLTF.Math.Vector2 UZPOAMPLVLT(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x73B3FE0", Offset = "0x73B2DE0", VA = "0x1873B3FE0")]
		public static GLTF.Math.Vector3 UZKHDFVOMAK(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x73B3920", Offset = "0x73B2720", VA = "0x1873B3920")]
		public static GLTF.Math.Quaternion JSFKECWYAHR(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3C27D40", Offset = "0x3C26B40", VA = "0x183C27D40")]
		public static Dictionary<string, b> DYUWGUPQZRR<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C28260", Offset = "0x3C27060", VA = "0x183C28260")]
		public static c HTSSKYHHMDJ<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public KUARRPWGPHO bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x73A6410", Offset = "0x73A5210", VA = "0x1873A6410", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x73A6390", Offset = "0x73A5190", VA = "0x1873A6390", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class YVRMIGURYNF : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x73BF530", Offset = "0x73BE330", VA = "0x1873BF530")]
		public YVRMIGURYNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x73BF460", Offset = "0x73BE260", VA = "0x1873BF460", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, RIFMZTUJKPT> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x73A6250", Offset = "0x73A5050", VA = "0x1873A6250", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x73A6310", Offset = "0x73A5110", VA = "0x1873A6310")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class MEHCLGAROEJ : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class URZEQUFXAGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public RSKHWHICBEK BSGUJACPZOT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader OOFIQUZLQFO;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public URZEQUFXAGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x73BAB90", Offset = "0x73B9990", VA = "0x1873BAB90")]
			internal RIFMZTUJKPT JIDCXYPQJBI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x73B18C0", Offset = "0x73B06C0", VA = "0x1873B18C0")]
		public MEHCLGAROEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x73B1730", Offset = "0x73B0530", VA = "0x1873B1730", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NBWHDWFIUMJ JRCMGSMHIBQ;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public EXT_texture_exr(NBWHDWFIUMJ source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x73A6460", Offset = "0x73A5260", VA = "0x1873A6460", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x73A64D0", Offset = "0x73A52D0", VA = "0x1873A64D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class MALWWTQJTKY : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x73B16E0", Offset = "0x73B04E0", VA = "0x1873B16E0")]
		public MALWWTQJTKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x73B15C0", Offset = "0x73B03C0", VA = "0x1873B15C0", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
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
	public class AudioEmitterId : CFJRXTHGIZK<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x73A5270", Offset = "0x73A4070", VA = "0x1873A5270", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x73A5230", Offset = "0x73A4030", VA = "0x1873A5230")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : CFJRXTHGIZK<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x73A5400", Offset = "0x73A4200", VA = "0x1873A5400", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x73A53C0", Offset = "0x73A41C0", VA = "0x1873A53C0")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : CFJRXTHGIZK<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x73A50E0", Offset = "0x73A3EE0", VA = "0x1873A50E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x73A50A0", Offset = "0x73A3EA0", VA = "0x1873A50A0")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x73A4FC0", Offset = "0x73A3DC0", VA = "0x1873A4FC0")]
		public static AudioDataId Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x73A9910", Offset = "0x73A8710", VA = "0x1873A9910", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x73A9510", Offset = "0x73A8310", VA = "0x1873A9510", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x73A9580", Offset = "0x73A8380", VA = "0x1873A9580")]
		public static KHR_SceneAudioEmittersRef Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x73A9B70", Offset = "0x73A8970", VA = "0x1873A9B70")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x73A94E0", Offset = "0x73A82E0", VA = "0x1873A94E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x73A93C0", Offset = "0x73A81C0", VA = "0x1873A93C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x73A91B0", Offset = "0x73A7FB0", VA = "0x1873A91B0", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x73A9220", Offset = "0x73A8020", VA = "0x1873A9220")]
		public static KHR_NodeAudioEmitterRef Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class ABSTKBLITKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string LNFDCHGMGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? GGKGBUEINDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? VZHPDLYBRBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? HNKCPOBIQUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? PKRMPOLKDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? FMRGLOYADQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? IPUCYGWJGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? HBEITMJQETQ;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x73A4880", Offset = "0x73A3680", VA = "0x1873A4880")]
		public JObject VVUFAYMMXPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x73A4180", Offset = "0x73A2F80", VA = "0x1873A4180")]
		public static ABSTKBLITKB Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ABSTKBLITKB()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : ZATBRVXMRFW
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
		public ABSTKBLITKB positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x73A8800", Offset = "0x73A7600", VA = "0x1873A8800", Slot = "5")]
		public virtual JObject VVUFAYMMXPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x73A8300", Offset = "0x73A7100", VA = "0x1873A8300")]
		public static KHR_AudioEmitter Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x73A8BA0", Offset = "0x73A79A0", VA = "0x1873A8BA0")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : ZATBRVXMRFW
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
		[Cpp2IlInjected.Address(RVA = "0x73A8F80", Offset = "0x73A7D80", VA = "0x1873A8F80")]
		public JObject VVUFAYMMXPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x73A8C20", Offset = "0x73A7A20", VA = "0x1873A8C20")]
		public static KHR_AudioSource Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x73A82F0", Offset = "0x73A70F0", VA = "0x1873A82F0")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : ZATBRVXMRFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NUUXICDPVTD bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x73A81C0", Offset = "0x73A6FC0", VA = "0x1873A81C0")]
		public JObject VVUFAYMMXPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x73A7F60", Offset = "0x73A6D60", VA = "0x1873A7F60")]
		public static KHR_AudioData Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x73A82F0", Offset = "0x73A70F0", VA = "0x1873A82F0")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : HBHULYGFSIL
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
		[Cpp2IlInjected.Address(RVA = "0x73A9E30", Offset = "0x73A8C30", VA = "0x1873A9E30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x73A9DA0", Offset = "0x73A8BA0", VA = "0x1873A9DA0", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x73AA560", Offset = "0x73A9360", VA = "0x1873AA560")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class XZXDGDVSEPO : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x73BEC40", Offset = "0x73BDA40", VA = "0x1873BEC40")]
		public XZXDGDVSEPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x73BE070", Offset = "0x73BCE70", VA = "0x1873BE070", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NUUXICDPVTD bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x73AA730", Offset = "0x73A9530", VA = "0x1873AA730", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x73AA670", Offset = "0x73A9470", VA = "0x1873AA670", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x73AA780", Offset = "0x73A9580", VA = "0x1873AA780")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class GRQVZLDPOCK : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class URZEQUFXAGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader OOFIQUZLQFO;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public URZEQUFXAGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x73BAC40", Offset = "0x73B9A40", VA = "0x1873BAC40")]
			internal int JIDCXYPQJBI()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x73A6A80", Offset = "0x73A5880", VA = "0x1873A6A80")]
		public GRQVZLDPOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x73A6870", Offset = "0x73A5670", VA = "0x1873A6870", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CJAUEKHAZRY anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x73AA880", Offset = "0x73A9680", VA = "0x1873AA880", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x73AA800", Offset = "0x73A9600", VA = "0x1873AA800", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class LHTJWKXRFYB : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x73B14A0", Offset = "0x73B02A0", VA = "0x1873B14A0")]
		public LHTJWKXRFYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x73B12F0", Offset = "0x73B00F0", VA = "0x1873B12F0", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public CJAUEKHAZRY clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CJAUEKHAZRY clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CJAUEKHAZRY clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x73AAB30", Offset = "0x73A9930", VA = "0x1873AAB30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x73AAA90", Offset = "0x73A9890", VA = "0x1873AAA90", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class GSQDTLHNIMT : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x73A6D90", Offset = "0x73A5B90", VA = "0x1873A6D90")]
		public GSQDTLHNIMT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x73A6B10", Offset = "0x73A5910", VA = "0x1873A6B10", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x73AAE90", Offset = "0x73A9C90", VA = "0x1873AAE90", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x73AAE20", Offset = "0x73A9C20", VA = "0x1873AAE20", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class YMJIYLOYWOD : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x73BF230", Offset = "0x73BE030", VA = "0x1873BF230")]
		public YMJIYLOYWOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x73BF160", Offset = "0x73BDF60", VA = "0x1873BF160", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : SNIWNUMYYWL, HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float NSMNPPPHZVX;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x73AB1E0", Offset = "0x73A9FE0", VA = "0x1873AB1E0")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x73AB170", Offset = "0x73A9F70", VA = "0x1873AB170")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, RSKHWHICBEK root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x73AAFB0", Offset = "0x73A9DB0", VA = "0x1873AAFB0", Slot = "6")]
		public HBHULYGFSIL Clone(RSKHWHICBEK gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x73AB050", Offset = "0x73A9E50", VA = "0x1873AB050", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class OGKNOJHFHEY : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x73B21C0", Offset = "0x73B0FC0", VA = "0x1873B21C0")]
		public OGKNOJHFHEY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x73B20C0", Offset = "0x73B0EC0", VA = "0x1873B20C0", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x73AB290", Offset = "0x73AA090", VA = "0x1873AB290", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x73AB230", Offset = "0x73AA030", VA = "0x1873AB230", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x73AB3E0", Offset = "0x73AA1E0", VA = "0x1873AB3E0")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class JDFVAYCKOLN : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x73A7BF0", Offset = "0x73A69F0", VA = "0x1873A7BF0")]
		public JDFVAYCKOLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x73A7B20", Offset = "0x73A6920", VA = "0x1873A7B20", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CJAUEKHAZRY iridescenceTexture;

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
		public CJAUEKHAZRY iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x73AB490", Offset = "0x73AA290", VA = "0x1873AB490", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x73AB3F0", Offset = "0x73AA1F0", VA = "0x1873AB3F0", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x73AB850", Offset = "0x73AA650", VA = "0x1873AB850")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class QSNJMDPIJDX : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x73B27B0", Offset = "0x73B15B0", VA = "0x1873B27B0")]
		public QSNJMDPIJDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x73B24C0", Offset = "0x73B12C0", VA = "0x1873B24C0", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class BNYJJHCWDFW : HBHULYGFSIL
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 LPXJHOHMSHW;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double ZJZIOUJFWER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color CUAXOGUPQSM;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color TMRCPHYFKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CJAUEKHAZRY XDXQBFRGLSW;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly CJAUEKHAZRY VJWMEULQJCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 QZWNSAGJFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double QPXJRJXVJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public CJAUEKHAZRY OBGQQIPJRMH;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly CJAUEKHAZRY ANZFJUMNOXJ;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x73A5E60", Offset = "0x73A4C60", VA = "0x1873A5E60")]
		public BNYJJHCWDFW(GLTF.Math.Color a, CJAUEKHAZRY b, GLTF.Math.Vector3 c, double d, CJAUEKHAZRY e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x73A5550", Offset = "0x73A4350", VA = "0x1873A5550", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x73A5700", Offset = "0x73A4500", VA = "0x1873A5700", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class ANEJBTPSDSS : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x73A4E40", Offset = "0x73A3C40", VA = "0x1873A4E40")]
		public ANEJBTPSDSS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x73A4AF0", Offset = "0x73A38F0", VA = "0x1873A4AF0", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CJAUEKHAZRY sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CJAUEKHAZRY sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x73AB940", Offset = "0x73AA740", VA = "0x1873AB940", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x73AB870", Offset = "0x73AA670", VA = "0x1873AB870", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x73ABE50", Offset = "0x73AAC50", VA = "0x1873ABE50")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class QJXPYIANDMI : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x73B2470", Offset = "0x73B1270", VA = "0x1873B2470")]
		public QJXPYIANDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x73B2210", Offset = "0x73B1010", VA = "0x1873B2210", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CJAUEKHAZRY specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CJAUEKHAZRY specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x73ABF80", Offset = "0x73AAD80", VA = "0x1873ABF80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x73ABEB0", Offset = "0x73AACB0", VA = "0x1873ABEB0", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x73AC490", Offset = "0x73AB290", VA = "0x1873AC490")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class RODJQXPDUPG : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x73B4E10", Offset = "0x73B3C10", VA = "0x1873B4E10")]
		public RODJQXPDUPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x73B4BA0", Offset = "0x73B39A0", VA = "0x1873B4BA0", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CJAUEKHAZRY transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x73AC580", Offset = "0x73AB380", VA = "0x1873AC580", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x73AC500", Offset = "0x73AB300", VA = "0x1873AC500", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class LHGNWBULYRH : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x73B12A0", Offset = "0x73B00A0", VA = "0x1873B12A0")]
		public LHGNWBULYRH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x73B1160", Offset = "0x73AFF60", VA = "0x1873B1160", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class ZBRGDTSMROO : SNIWNUMYYWL, HBHULYGFSIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x73BF780", Offset = "0x73BE580", VA = "0x1873BF780")]
		public ZBRGDTSMROO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x73BF7D0", Offset = "0x73BE5D0", VA = "0x1873BF7D0")]
		public ZBRGDTSMROO(ZBRGDTSMROO a, RSKHWHICBEK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x73BF580", Offset = "0x73BE380", VA = "0x1873BF580", Slot = "6")]
		public HBHULYGFSIL Clone(RSKHWHICBEK gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x73BF6F0", Offset = "0x73BE4F0", VA = "0x1873BF6F0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x73BF620", Offset = "0x73BE420", VA = "0x1873BF620", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class LUNWBRSWAQQ : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x73B1570", Offset = "0x73B0370", VA = "0x1873B1570")]
		public LUNWBRSWAQQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x73B14F0", Offset = "0x73B02F0", VA = "0x1873B14F0", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CJAUEKHAZRY thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x73AC7A0", Offset = "0x73AB5A0", VA = "0x1873AC7A0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x73AC710", Offset = "0x73AB510", VA = "0x1873AC710", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x73ACCD0", Offset = "0x73ABAD0", VA = "0x1873ACCD0")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class XOBAGYGMGJZ : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x73BE020", Offset = "0x73BCE20", VA = "0x1873BE020")]
		public XOBAGYGMGJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x73BDE10", Offset = "0x73BCC10", VA = "0x1873BDE10", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x73ACD50", Offset = "0x73ABB50", VA = "0x1873ACD50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x73ACCF0", Offset = "0x73ABAF0", VA = "0x1873ACCF0", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1202150", Offset = "0x1200F50", VA = "0x181202150")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class SOKIGXGAETX : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x73B4F40", Offset = "0x73B3D40", VA = "0x1873B4F40")]
		public SOKIGXGAETX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x73B4E60", Offset = "0x73B3C60", VA = "0x1873B4E60", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x73ACEC0", Offset = "0x73ABCC0", VA = "0x1873ACEC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x73ACE60", Offset = "0x73ABC60", VA = "0x1873ACE60", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1202150", Offset = "0x1200F50", VA = "0x181202150")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class APNDMVWRWNV : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x73A4F70", Offset = "0x73A3D70", VA = "0x1873A4F70")]
		public APNDMVWRWNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x73A4E90", Offset = "0x73A3C90", VA = "0x1873A4E90", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x73AD030", Offset = "0x73ABE30", VA = "0x1873AD030", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x73ACFD0", Offset = "0x73ABDD0", VA = "0x1873ACFD0", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1202150", Offset = "0x1200F50", VA = "0x181202150")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class UOANJKMRCFX : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x73BAB40", Offset = "0x73B9940", VA = "0x1873BAB40")]
		public UOANJKMRCFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x73BAA60", Offset = "0x73B9860", VA = "0x1873BAA60", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NBWHDWFIUMJ source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public KHR_texture_basisu(NBWHDWFIUMJ source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x73AD140", Offset = "0x73ABF40", VA = "0x1873AD140", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x73AD1B0", Offset = "0x73ABFB0", VA = "0x1873AD1B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class RNQCSBPDDXB : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x73B4B50", Offset = "0x73B3950", VA = "0x1873B4B50")]
		public RNQCSBPDDXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x73B49F0", Offset = "0x73B37F0", VA = "0x1873B49F0", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class OGDGLGKXRAI : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 APVUGZXIKWY;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 AQWBZDOICTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double JZOPJQMDSFX;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double AYNXABEMMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 GLTCDKGXFXV;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 LOAEOYVUZEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? GKXKDCQNUZD;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int KEPBVHLHUYL;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x73B2040", Offset = "0x73B0E40", VA = "0x1873B2040")]
		public OGDGLGKXRAI(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x73B1910", Offset = "0x73B0710", VA = "0x1873B1910", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x73B19F0", Offset = "0x73B07F0", VA = "0x1873B19F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class JGAWJZFXDOC : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x73A7F10", Offset = "0x73A6D10", VA = "0x1873A7F10")]
		public JGAWJZFXDOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x73A7C40", Offset = "0x73A6A40", VA = "0x1873A7C40", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class GMDRPCCEKWO : HBHULYGFSIL
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> ZLNZQWOUDDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public GMDRPCCEKWO(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x73A6680", Offset = "0x73A5480", VA = "0x1873A6680", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x73A6780", Offset = "0x73A5580", VA = "0x1873A6780", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x73A66F0", Offset = "0x73A54F0", VA = "0x1873A66F0")]
		public List<double> IWSXDZKJWHA(FDTJOQJNBIL a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class KSPZSLUMEOI : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x73B0D20", Offset = "0x73AFB20", VA = "0x1873B0D20")]
		public KSPZSLUMEOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x73B0C20", Offset = "0x73AFA20", VA = "0x1873B0C20", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class SRSXGVAUNIA : ZATBRVXMRFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public NUUXICDPVTD KUARRPWGPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint ODWBURAUVDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType VDKQAIHKXSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool SPXGRLTWTPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint ODIIXCYNYBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType QCFSUOQZRCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> ITKXIFKNVQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> GUBFOZUSUUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public YZVHELLPYPO SJJDOOKATGT;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x73A82F0", Offset = "0x73A70F0", VA = "0x1873A82F0")]
		public SRSXGVAUNIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x73B55E0", Offset = "0x73B43E0", VA = "0x1873B55E0")]
		public static SRSXGVAUNIA Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x73B8CC0", Offset = "0x73B7AC0", VA = "0x1873B8CC0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x73B8190", Offset = "0x73B6F90", VA = "0x1873B8190")]
		private unsafe static sbyte RQVPHXIQHWV(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x73B81A0", Offset = "0x73B6FA0", VA = "0x1873B81A0")]
		private unsafe static float2 RXTSCYUUBYJ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x73B6B70", Offset = "0x73B5970", VA = "0x1873B6B70")]
		private unsafe static float3 IMVKEKEZZUM(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x73B8990", Offset = "0x73B7790", VA = "0x1873B8990")]
		private unsafe static float4 UHCXCRKKVUD(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x73B5440", Offset = "0x73B4240", VA = "0x1873B5440")]
		private unsafe static float4x4 DJZWOJREDXB(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x73B8190", Offset = "0x73B6F90", VA = "0x1873B8190")]
		private unsafe static byte TAQDXMASAZU(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x73B5E70", Offset = "0x73B4C70", VA = "0x1873B5E70")]
		private unsafe static float2 GNJSBMPLPOE(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x73B89F0", Offset = "0x73B77F0", VA = "0x1873B89F0")]
		private unsafe static float3 USUQXJEFVRL(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x73B8930", Offset = "0x73B7730", VA = "0x1873B8930")]
		private unsafe static float4 UDNNYEMDJIS(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x73B81D0", Offset = "0x73B6FD0", VA = "0x1873B81D0")]
		private unsafe static float4x4 SBBGEDEBDWS(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x73B5430", Offset = "0x73B4230", VA = "0x1873B5430")]
		private unsafe static short ZITBFBPTIXN(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x73B7E30", Offset = "0x73B6C30", VA = "0x1873B7E30")]
		private unsafe static float2 RDBDYYCCKMT(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x73B7E60", Offset = "0x73B6C60", VA = "0x1873B7E60")]
		private unsafe static float3 RNXKKEINSNE(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x73B9520", Offset = "0x73B8320", VA = "0x1873B9520")]
		private unsafe static float4 ZNTKEMSEUHD(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x73B69D0", Offset = "0x73B57D0", VA = "0x1873B69D0")]
		private unsafe static float4x4 IITMFRVPFQR(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x73B5430", Offset = "0x73B4230", VA = "0x1873B5430")]
		private unsafe static ushort XEKIAPKOYOC(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x73B87D0", Offset = "0x73B75D0", VA = "0x1873B87D0")]
		private unsafe static float2 TOFCGIFEFGE(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x73B6F70", Offset = "0x73B5D70", VA = "0x1873B6F70")]
		private unsafe static float3 JLGAIBBXDYN(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x73B5A40", Offset = "0x73B4840", VA = "0x1873B5A40")]
		private unsafe static float4x4 EFMPGXXWYJI(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x73B78A0", Offset = "0x73B66A0", VA = "0x1873B78A0")]
		private unsafe static float4 NKUJGAWAGOK(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x73B6BC0", Offset = "0x73B59C0", VA = "0x1873B6BC0")]
		private unsafe static uint IUSNUKPLPFR(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x73B5430", Offset = "0x73B4230", VA = "0x1873B5430")]
		private unsafe static ushort CRNATVEIDVI(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x73B7900", Offset = "0x73B6700", VA = "0x1873B7900")]
		private unsafe static float OCPHUGPRXIX(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x73B7E10", Offset = "0x73B6C10", VA = "0x1873B7E10")]
		private unsafe static float2 RARTZWQAETV(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x73B5100", Offset = "0x73B3F00", VA = "0x1873B5100")]
		private unsafe static float3 CMFMLRUEONM(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x73B5150", Offset = "0x73B3F50", VA = "0x1873B5150")]
		private unsafe static float4 KCBTCTRCYAZ(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x73B6BD0", Offset = "0x73B59D0", VA = "0x1873B6BD0")]
		private unsafe static float4x4 IZGCJRSSJRP(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x73B5150", Offset = "0x73B3F50", VA = "0x1873B5150")]
		private unsafe static float4 CNGAVOCMWZK(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x73B5120", Offset = "0x73B3F20", VA = "0x1873B5120")]
		private unsafe static float4 CNGAVOCMWZK(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x73B92F0", Offset = "0x73B80F0", VA = "0x1873B92F0")]
		public static float3[] ZEFOMZTVOOJ(SRSXGVAUNIA a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x73B66C0", Offset = "0x73B54C0", VA = "0x1873B66C0")]
		public static float3[] GXDPQVRPWCR(SRSXGVAUNIA a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x73B4F90", Offset = "0x73B3D90", VA = "0x1873B4F90")]
		public static uint[] CFFPNVUWKKQ(SRSXGVAUNIA a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x73B5BE0", Offset = "0x73B49E0", VA = "0x1873B5BE0")]
		internal static void ENOJGNTGDWJ(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x73B7540", Offset = "0x73B6340", VA = "0x1873B7540")]
		public uint[] MPXSGNUGEKM(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x73B7910", Offset = "0x73B6710", VA = "0x1873B7910")]
		public float[] OOYUAINYTAI(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x73B7B80", Offset = "0x73B6980", VA = "0x1873B7B80")]
		public float2[] QKBMLRREHYQ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x73B5180", Offset = "0x73B3F80", VA = "0x1873B5180")]
		public float2[] CPZHXHVHAUC(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x73B8A40", Offset = "0x73B7840", VA = "0x1873B8A40")]
		public float3[] VENOUWDBERP(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x73B8480", Offset = "0x73B7280", VA = "0x1873B8480")]
		public float3[] TJIDUCMIATD(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x73B5EA0", Offset = "0x73B4CA0", VA = "0x1873B5EA0")]
		public float4[] GQRKNAQOOPE(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x73B6C00", Offset = "0x73B5A00", VA = "0x1873B6C00")]
		public float4[] JAOVXKJLWCO(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x73B9580", Offset = "0x73B8380", VA = "0x1873B9580")]
		public float4[] ZQZHTCGFJDJ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x73B7790", Offset = "0x73B6590", VA = "0x1873B7790")]
		public float3[] MZGBWLYBJLM(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x73B8370", Offset = "0x73B7170", VA = "0x1873B8370")]
		public float3[] SNVILTYPIKF(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x73B6FC0", Offset = "0x73B5DC0", VA = "0x1873B6FC0")]
		public float4[] KTMDIEQZEHP(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x73B92A0", Offset = "0x73B80A0", VA = "0x1873B92A0")]
		public uint[] WXIPLNCBTTC(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x73B6110", Offset = "0x73B4F10", VA = "0x1873B6110")]
		public float4x4[] GRGQWWFYNLZ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x73B7210", Offset = "0x73B6010", VA = "0x1873B7210")]
		private unsafe static float4 LRCAJSGFOGP(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x73B7090", Offset = "0x73B5E90", VA = "0x1873B7090")]
		private unsafe static float4 LRCAJSGFOGP(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x73B73D0", Offset = "0x73B61D0", VA = "0x1873B73D0")]
		private unsafe static float4x4 LZZASUPKISA(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x73B7FD0", Offset = "0x73B6DD0", VA = "0x1873B7FD0")]
		private unsafe static float4 RPRTXZQCXVC(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x73B5D00", Offset = "0x73B4B00", VA = "0x1873B5D00")]
		private unsafe static float3 FXEVNAWRZNB(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x73B8800", Offset = "0x73B7600", VA = "0x1873B8800")]
		private unsafe static float2 UAJSQRUFSBI(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x73B7EB0", Offset = "0x73B6CB0", VA = "0x1873B7EB0")]
		private unsafe static uint ROSTOLWIZIX(void* a, uint b, GLTFComponentType c)
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
	public static class LSJJPQOOLGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x73C7D90", Offset = "0x73C6B90", VA = "0x1873C7D90")]
		public static int NGMMMPBMNZL(this GLTFAccessorAttributeType a)
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
	public class YZVHELLPYPO : SNIWNUMYYWL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int ODIIXCYNYBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public FOKFPLSXQUZ ZUWNHCPNHDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public MYWLAUJKGZQ VMKJLRZSVZP;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x73D52D0", Offset = "0x73D40D0", VA = "0x1873D52D0")]
		public YZVHELLPYPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x73D4ED0", Offset = "0x73D3CD0", VA = "0x1873D4ED0")]
		public static YZVHELLPYPO Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x73D51A0", Offset = "0x73D3FA0", VA = "0x1873D51A0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class FOKFPLSXQUZ : SNIWNUMYYWL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public NUUXICDPVTD KUARRPWGPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int ODWBURAUVDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType VDKQAIHKXSS;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x73C3E80", Offset = "0x73C2C80", VA = "0x1873C3E80")]
		public FOKFPLSXQUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x73C3A60", Offset = "0x73C2860", VA = "0x1873C3A60")]
		public static FOKFPLSXQUZ Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x73C3D40", Offset = "0x73C2B40", VA = "0x1873C3D40", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class MYWLAUJKGZQ : SNIWNUMYYWL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public NUUXICDPVTD KUARRPWGPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int ODWBURAUVDI;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x73C8A20", Offset = "0x73C7820", VA = "0x1873C8A20")]
		public MYWLAUJKGZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x73C86A0", Offset = "0x73C74A0", VA = "0x1873C86A0")]
		public static MYWLAUJKGZQ Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x73C8920", Offset = "0x73C7720", VA = "0x1873C8920", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class PXBSXRDRZOW : SNIWNUMYYWL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public MECJMYLEJHO BSBENATBAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public TBXOMPZOVHF DKPUVTGBHOK;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x73C9780", Offset = "0x73C8580", VA = "0x1873C9780")]
		public PXBSXRDRZOW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x73C9490", Offset = "0x73C8290", VA = "0x1873C9490")]
		public static PXBSXRDRZOW Deserialize(RSKHWHICBEK root, JsonReader reader, WIONDLXSZNK anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x73C9680", Offset = "0x73C8480", VA = "0x1873C9680", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class TBXOMPZOVHF : SNIWNUMYYWL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public SQMEOXSHHQG FDTJOQJNBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string ORFYTREAQJW;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x73D0B50", Offset = "0x73CF950", VA = "0x1873D0B50")]
		public static TBXOMPZOVHF Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x73D0ED0", Offset = "0x73CFCD0", VA = "0x1873D0ED0")]
		public TBXOMPZOVHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x73D0DB0", Offset = "0x73CFBB0", VA = "0x1873D0DB0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
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
	public class ALBSRFQQISA
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(ALBSRFQQISA data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] MWEZPIOJDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type LECEKKKRHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] BKLMORLDHRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion WQHMVCJSVKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string VHIWFJSUXHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string THTOOTQOVLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public GRYQYIWVGUK VMUMAGEXQYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string KTQRVHCNXYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string JPPBECXJOCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public GRYQYIWVGUK BORSCFHXUJZ;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x73BF840", Offset = "0x73BE640", VA = "0x1873BF840")]
		public ALBSRFQQISA()
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
	public class INCKDMSTVUZ : SNIWNUMYYWL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public RIFMZTUJKPT JBFBLFGUYJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType FKFYQYLBSWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public RIFMZTUJKPT MSIGXQSEQNI;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x73C5F60", Offset = "0x73C4D60", VA = "0x1873C5F60")]
		public INCKDMSTVUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x73C5BD0", Offset = "0x73C49D0", VA = "0x1873C5BD0")]
		public static INCKDMSTVUZ Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x73C5DF0", Offset = "0x73C4BF0", VA = "0x1873C5DF0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class HSOOTBXZNEN : SNIWNUMYYWL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string WZNGJKRPNVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string DOETWAEQICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string TVMQSEZQBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string BXGOGKNNOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> AURFGCKPYNR;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x73C58E0", Offset = "0x73C46E0", VA = "0x1873C58E0")]
		public HSOOTBXZNEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x73C4DF0", Offset = "0x73C3BF0", VA = "0x1873C4DF0")]
		public static HSOOTBXZNEN Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x73C54C0", Offset = "0x73C42C0", VA = "0x1873C54C0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x73C5110", Offset = "0x73C3F10", VA = "0x1873C5110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x73C5120", Offset = "0x73C3F20", VA = "0x1873C5120")]
		public string VRCYNZLPIBZ(bool a)
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
	public class KUARRPWGPHO : ZATBRVXMRFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public KDFPQAEQLHW FCRDNWDTDUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint ODWBURAUVDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint HBCTFEOZEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint LCFLKACWBXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget DKPUVTGBHOK;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x73BFC80", Offset = "0x73BEA80", VA = "0x1873BFC80")]
		public KUARRPWGPHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x73C7260", Offset = "0x73C6060", VA = "0x1873C7260")]
		public static KUARRPWGPHO Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x73C7510", Offset = "0x73C6310", VA = "0x1873C7510", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class HHWMZARYDQK : SNIWNUMYYWL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double SNHKQUWTIWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double BFURSZESYNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double AUWBWJCQVNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double CHNJBBLUKIB;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x73C4880", Offset = "0x73C3680", VA = "0x1873C4880")]
		public HHWMZARYDQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x73C4390", Offset = "0x73C3190", VA = "0x1873C4390")]
		public static HHWMZARYDQK Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x73C4710", Offset = "0x73C3510", VA = "0x1873C4710", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class UQBTFJIETVU : SNIWNUMYYWL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double VTGYUEDLXJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double LESZSZNESJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double AUWBWJCQVNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double CHNJBBLUKIB;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x73D2670", Offset = "0x73D1470", VA = "0x1873D2670")]
		public UQBTFJIETVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x73D2170", Offset = "0x73D0F70", VA = "0x1873D2170")]
		public static UQBTFJIETVU Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x73D24E0", Offset = "0x73D12E0", VA = "0x1873D24E0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class WIONDLXSZNK : ZATBRVXMRFW
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class URZEQUFXAGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public RSKHWHICBEK BSGUJACPZOT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader OOFIQUZLQFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public WIONDLXSZNK TWJVNHAHYRN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<PXBSXRDRZOW> CBANWYGKPPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<INCKDMSTVUZ> CBFUUFAHZAN;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public URZEQUFXAGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x73D26D0", Offset = "0x73D14D0", VA = "0x1873D26D0")]
			internal PXBSXRDRZOW JIDCXYPQJBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x73D26F0", Offset = "0x73D14F0", VA = "0x1873D26F0")]
			internal INCKDMSTVUZ JIIJVFJNSMR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<PXBSXRDRZOW> NMIYUGRZQDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<INCKDMSTVUZ> OPTLFUIOHWK;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x73D38F0", Offset = "0x73D26F0", VA = "0x1873D38F0")]
		public static WIONDLXSZNK Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x73D4050", Offset = "0x73D2E50", VA = "0x1873D4050")]
		public WIONDLXSZNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x73D3CB0", Offset = "0x73D2AB0", VA = "0x1873D3CB0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class NRBKQPPLJEI : ZATBRVXMRFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string RHPPNWNCNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint HBCTFEOZEIN;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x73BFC80", Offset = "0x73BEA80", VA = "0x1873BFC80")]
		public NRBKQPPLJEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x73C8BF0", Offset = "0x73C79F0", VA = "0x1873C8BF0")]
		public static NRBKQPPLJEI Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x73C8DC0", Offset = "0x73C7BC0", VA = "0x1873C8DC0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class AODQVOGYCPD : ZATBRVXMRFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public HHWMZARYDQK BCXJPIBBPWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public UQBTFJIETVU WKRFAPXIDTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType QCFSUOQZRCP;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x73BFC80", Offset = "0x73BEA80", VA = "0x1873BFC80")]
		public AODQVOGYCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x73BF8E0", Offset = "0x73BE6E0", VA = "0x1873BF8E0")]
		public static AODQVOGYCPD Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x73BFAB0", Offset = "0x73BE8B0", VA = "0x1873BFAB0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
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
	public class ZATBRVXMRFW : SNIWNUMYYWL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string JDIPTDKIYCA;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x73BFC80", Offset = "0x73BEA80", VA = "0x1873BFC80")]
		public ZATBRVXMRFW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x73D54A0", Offset = "0x73D42A0", VA = "0x1873D54A0")]
		public ZATBRVXMRFW(ZATBRVXMRFW a, RSKHWHICBEK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x73D5320", Offset = "0x73D4120", VA = "0x1873D5320")]
		public new void JLSMCAOEMYC(RSKHWHICBEK a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x73D5410", Offset = "0x73D4210", VA = "0x1873D5410", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class CFJRXTHGIZK<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int QXVQSTMOTBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public RSKHWHICBEK NKNEDPIWGGX;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected CFJRXTHGIZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7397740", Offset = "0x7396540", VA = "0x187397740")]
		public CFJRXTHGIZK(CFJRXTHGIZK<a> a, RSKHWHICBEK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7397710", Offset = "0x7396510", VA = "0x187397710")]
		public void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class RIFMZTUJKPT : CFJRXTHGIZK<SRSXGVAUNIA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override SRSXGVAUNIA Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x73CA460", Offset = "0x73C9260", VA = "0x1873CA460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x73CA420", Offset = "0x73C9220", VA = "0x1873CA420")]
		public RIFMZTUJKPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x73CA3C0", Offset = "0x73C91C0", VA = "0x1873CA3C0")]
		public RIFMZTUJKPT(RIFMZTUJKPT a, RSKHWHICBEK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x73CA2E0", Offset = "0x73C90E0", VA = "0x1873CA2E0")]
		public static RIFMZTUJKPT Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class KDFPQAEQLHW : CFJRXTHGIZK<NRBKQPPLJEI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NRBKQPPLJEI Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x73C6FC0", Offset = "0x73C5DC0", VA = "0x1873C6FC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x73C6F80", Offset = "0x73C5D80", VA = "0x1873C6F80")]
		public KDFPQAEQLHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x73C6EA0", Offset = "0x73C5CA0", VA = "0x1873C6EA0")]
		public static KDFPQAEQLHW Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class NUUXICDPVTD : CFJRXTHGIZK<KUARRPWGPHO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override KUARRPWGPHO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x73C9030", Offset = "0x73C7E30", VA = "0x1873C9030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x73C8FF0", Offset = "0x73C7DF0", VA = "0x1873C8FF0")]
		public NUUXICDPVTD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x73C8F10", Offset = "0x73C7D10", VA = "0x1873C8F10")]
		public static NUUXICDPVTD Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class PCBJFQQTXWV : CFJRXTHGIZK<AODQVOGYCPD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override AODQVOGYCPD Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x73C91B0", Offset = "0x73C7FB0", VA = "0x1873C91B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x73C9170", Offset = "0x73C7F70", VA = "0x1873C9170")]
		public PCBJFQQTXWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x73C9090", Offset = "0x73C7E90", VA = "0x1873C9090")]
		public static PCBJFQQTXWV Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class NBWHDWFIUMJ : CFJRXTHGIZK<RRJBLZLRZXF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override RRJBLZLRZXF Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x73C8B90", Offset = "0x73C7990", VA = "0x1873C8B90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x73C8B50", Offset = "0x73C7950", VA = "0x1873C8B50")]
		public NBWHDWFIUMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x73C8A70", Offset = "0x73C7870", VA = "0x1873C8A70")]
		public static NBWHDWFIUMJ Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class RZDVZENZQHF : CFJRXTHGIZK<RPFFCTAYHPF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override RPFFCTAYHPF Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x73CE480", Offset = "0x73CD280", VA = "0x1873CE480", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x73CE3E0", Offset = "0x73CD1E0", VA = "0x1873CE3E0")]
		public RZDVZENZQHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x73CE420", Offset = "0x73CD220", VA = "0x1873CE420")]
		public RZDVZENZQHF(RZDVZENZQHF a, RSKHWHICBEK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x73CE300", Offset = "0x73CD100", VA = "0x1873CE300")]
		public static RZDVZENZQHF Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class CJARLEBAFHN : CFJRXTHGIZK<UYWBCFPSOXN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override UYWBCFPSOXN Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x73C0090", Offset = "0x73BEE90", VA = "0x1873C0090", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x73C0050", Offset = "0x73BEE50", VA = "0x1873C0050")]
		public CJARLEBAFHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x73BFF70", Offset = "0x73BED70", VA = "0x1873BFF70")]
		public static CJARLEBAFHN Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SQMEOXSHHQG : CFJRXTHGIZK<FDTJOQJNBIL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override FDTJOQJNBIL Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x73D05C0", Offset = "0x73CF3C0", VA = "0x1873D05C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x73D0580", Offset = "0x73CF380", VA = "0x1873D0580")]
		public SQMEOXSHHQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x73D0230", Offset = "0x73CF030", VA = "0x1873D0230")]
		public static SQMEOXSHHQG Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x73D0310", Offset = "0x73CF110", VA = "0x1873D0310")]
		public static List<SQMEOXSHHQG> MNKYQYWHTYP(RSKHWHICBEK a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class BXVSOEPCMWE : CFJRXTHGIZK<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x73BFF10", Offset = "0x73BED10", VA = "0x1873BFF10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x73BFED0", Offset = "0x73BECD0", VA = "0x1873BFED0")]
		public BXVSOEPCMWE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x73BFDF0", Offset = "0x73BEBF0", VA = "0x1873BFDF0")]
		public static BXVSOEPCMWE Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class MECJMYLEJHO : CFJRXTHGIZK<INCKDMSTVUZ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public WIONDLXSZNK WIONDLXSZNK;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override INCKDMSTVUZ Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x73C8400", Offset = "0x73C7200", VA = "0x1873C8400", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x73C83C0", Offset = "0x73C71C0", VA = "0x1873C83C0")]
		public MECJMYLEJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x73C82C0", Offset = "0x73C70C0", VA = "0x1873C82C0")]
		public static MECJMYLEJHO Deserialize(RSKHWHICBEK root, WIONDLXSZNK anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ZTDIQRGJRQE : CFJRXTHGIZK<DVQQOHAWOVY>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override DVQQOHAWOVY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x73D5640", Offset = "0x73D4440", VA = "0x1873D5640", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x73D5600", Offset = "0x73D4400", VA = "0x1873D5600")]
		public ZTDIQRGJRQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x73D5520", Offset = "0x73D4320", VA = "0x1873D5520")]
		public static ZTDIQRGJRQE Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class LUPWUYDHQIL : CFJRXTHGIZK<XFQHINQIZFY>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override XFQHINQIZFY Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x73C7F10", Offset = "0x73C6D10", VA = "0x1873C7F10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x73C7ED0", Offset = "0x73C6CD0", VA = "0x1873C7ED0")]
		public LUPWUYDHQIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x73C7DF0", Offset = "0x73C6BF0", VA = "0x1873C7DF0")]
		public static LUPWUYDHQIL Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class QFUKSNFKKZZ : CFJRXTHGIZK<VLKOXKBBYUF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override VLKOXKBBYUF Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x73C9950", Offset = "0x73C8750", VA = "0x1873C9950", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x73C98B0", Offset = "0x73C86B0", VA = "0x1873C98B0")]
		public QFUKSNFKKZZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x73C98F0", Offset = "0x73C86F0", VA = "0x1873C98F0")]
		public QFUKSNFKKZZ(QFUKSNFKKZZ a, RSKHWHICBEK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x73C97D0", Offset = "0x73C85D0", VA = "0x1873C97D0")]
		public static QFUKSNFKKZZ Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class AWYQUFPZNFW : CFJRXTHGIZK<PPRLMDVXWFU>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override PPRLMDVXWFU Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x73BFD20", Offset = "0x73BEB20", VA = "0x1873BFD20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x73BFCE0", Offset = "0x73BEAE0", VA = "0x1873BFCE0")]
		public AWYQUFPZNFW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class RRJBLZLRZXF : ZATBRVXMRFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string RHPPNWNCNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string FOOTVQBSWKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public NUUXICDPVTD KUARRPWGPHO;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x73BFC80", Offset = "0x73BEA80", VA = "0x1873BFC80")]
		public RRJBLZLRZXF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x73CAEA0", Offset = "0x73C9CA0", VA = "0x1873CAEA0")]
		public static RRJBLZLRZXF Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x73CB0E0", Offset = "0x73C9EE0", VA = "0x1873CB0E0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class RPFFCTAYHPF : ZATBRVXMRFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public LREFUPJXZOC LREFUPJXZOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public RSHNMYWBKVJ XLVIEYHNPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public GIOAKPZCWMP MWAOBWSGRBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public YVYBJYFRZAL JWUYODBYTUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public CJAUEKHAZRY FFJOIRKLJSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color SPJNBIMJAWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode WIZJZWUFYIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double VYMXWCGGGIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool IGTDPMUIREL;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x73CAE30", Offset = "0x73C9C30", VA = "0x1873CAE30")]
		public RPFFCTAYHPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x73CA4C0", Offset = "0x73C92C0", VA = "0x1873CA4C0")]
		public static RPFFCTAYHPF Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x73CA9D0", Offset = "0x73C97D0", VA = "0x1873CA9D0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
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
	public class UYWBCFPSOXN : ZATBRVXMRFW
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class QFVEKDSMASK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public RSKHWHICBEK BSGUJACPZOT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader OOFIQUZLQFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<FFTWICBRMUH> CBANWYGKPPE;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QFVEKDSMASK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x73C99B0", Offset = "0x73C87B0", VA = "0x1873C99B0")]
			internal FFTWICBRMUH JIDCXYPQJBI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<FFTWICBRMUH> XIVXEZBMTYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> AJSQJMOLUEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> JMIKLTGHQNM;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x73BFC80", Offset = "0x73BEA80", VA = "0x1873BFC80")]
		public UYWBCFPSOXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x73D2700", Offset = "0x73D1500", VA = "0x1873D2700")]
		public static UYWBCFPSOXN Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x73D2AC0", Offset = "0x73D18C0", VA = "0x1873D2AC0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class SNIWNUMYYWL
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, XEDTKRTGFCG> OOZZBCGHGUW;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static BDSAHKHLIZT TKIDTSUWTJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, HBHULYGFSIL> FBCHQXTVJBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken LOROQWIAFSQ;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x73CF120", Offset = "0x73CDF20", VA = "0x1873CF120")]
		public static XEDTKRTGFCG LCEYPCUDGIJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x73CF2B0", Offset = "0x73CE0B0", VA = "0x1873CF2B0")]
		public static HBHULYGFSIL OXPZFZLHYPT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public SNIWNUMYYWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x73CFF40", Offset = "0x73CED40", VA = "0x1873CFF40")]
		public SNIWNUMYYWL(SNIWNUMYYWL a, [Optional] RSKHWHICBEK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x73CE8A0", Offset = "0x73CD6A0", VA = "0x1873CE8A0")]
		public void JLSMCAOEMYC(RSKHWHICBEK a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x73CE690", Offset = "0x73CD490", VA = "0x1873CE690")]
		public void DKRRITLOTIX(string a, HBHULYGFSIL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x73CE4E0", Offset = "0x73CD2E0", VA = "0x1873CE4E0")]
		private void AMKOHDFIEOJ(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x73CE5D0", Offset = "0x73CD3D0", VA = "0x1873CE5D0")]
		private void CHHNTSGKIBB(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x73CE7E0", Offset = "0x73CD5E0", VA = "0x1873CE7E0")]
		private void DLXKLRGRKOV(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x73CEB50", Offset = "0x73CD950", VA = "0x1873CEB50")]
		internal static Dictionary<string, HBHULYGFSIL> JWFQLAYBBUE(RSKHWHICBEK a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x73CF3A0", Offset = "0x73CE1A0", VA = "0x1873CF3A0", Slot = "4")]
		public virtual void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class RSKHWHICBEK : SNIWNUMYYWL
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class KPWYJSNCUCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public RSKHWHICBEK BSGUJACPZOT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader WLSNMZHFZZQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<SRSXGVAUNIA> CBANWYGKPPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<WIONDLXSZNK> CBFUUFAHZAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<NRBKQPPLJEI> CAQACKSPWSM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<KUARRPWGPHO> CAVGZRMNGDV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<AODQVOGYCPD> CBVPLZIABIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<RRJBLZLRZXF> CCAWJGBXKTX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<RPFFCTAYHPF> CBLBRLUFILW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<UYWBCFPSOXN> CBQIOSOCRXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<FDTJOQJNBIL> CCQRBAJPNBY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> CCVXYHDMWNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<DVQQOHAWOVY> AUYACGJUQSX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<XFQHINQIZFY> AUSTEZPXHHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<VLKOXKBBYUF> AVINWTXPJPP;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public KPWYJSNCUCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x73C7040", Offset = "0x73C5E40", VA = "0x1873C7040")]
			internal SRSXGVAUNIA JIDCXYPQJBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x73C7050", Offset = "0x73C5E50", VA = "0x1873C7050")]
			internal WIONDLXSZNK JIIJVFJNSMR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x73C7020", Offset = "0x73C5E20", VA = "0x1873C7020")]
			internal NRBKQPPLJEI JHSPDLBVQEQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x73C7030", Offset = "0x73C5E30", VA = "0x1873C7030")]
			internal KUARRPWGPHO JHXWARVSZPZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x73C7080", Offset = "0x73C5E80", VA = "0x1873C7080")]
			internal AODQVOGYCPD JIYEMZRFUUS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x73C7090", Offset = "0x73C5E90", VA = "0x1873C7090")]
			internal RRJBLZLRZXF JJDLKGLDEGB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x73C7060", Offset = "0x73C5E60", VA = "0x1873C7060")]
			internal RPFFCTAYHPF JINQSMDLBYA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x73C7070", Offset = "0x73C5E70", VA = "0x1873C7070")]
			internal UYWBCFPSOXN JISXPSXILJJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x73C70A0", Offset = "0x73C5EA0", VA = "0x1873C70A0")]
			internal FDTJOQJNBIL JJTGCASVGOC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x73C70B0", Offset = "0x73C5EB0", VA = "0x1873C70B0")]
			internal Sampler JJYMZHMSPZL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x73C70D0", Offset = "0x73C5ED0", VA = "0x1873C70D0")]
			internal DVQQOHAWOVY SBRZLHFYWWX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x73C70C0", Offset = "0x73C5EC0", VA = "0x1873C70C0")]
			internal XFQHINQIZFY SBMSOAMBNLO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x73C7250", Offset = "0x73C6050", VA = "0x1873C7250")]
			internal VLKOXKBBYUF SCCNFUTTPTP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> ODTMPCPMJJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> YUGAGQCMIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<SRSXGVAUNIA> NBEXAEMLDVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<WIONDLXSZNK> UBRSWEQHKLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public HSOOTBXZNEN HSOOTBXZNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<NRBKQPPLJEI> ZSEQMMUJTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<KUARRPWGPHO> DYZDDHYEPZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<AODQVOGYCPD> GTIPWOBAWRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<RRJBLZLRZXF> CJCFFZOWRCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<RPFFCTAYHPF> DFLZHQSYVNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<UYWBCFPSOXN> WRONZRCANEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<FDTJOQJNBIL> CYKVKMQPUMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> OPTLFUIOHWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public ZTDIQRGJRQE BFBURDFRFXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<DVQQOHAWOVY> RABGSXMDNAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<XFQHINQIZFY> LNEDQRDEABN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<VLKOXKBBYUF> FAMFVMVRABN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<PPRLMDVXWFU> CLAQQLQJSXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool NOJWUUXEGKC;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x73CE2B0", Offset = "0x73CD0B0", VA = "0x1873CE2B0")]
		public RSKHWHICBEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x73CB820", Offset = "0x73CA620", VA = "0x1873CB820")]
		public DVQQOHAWOVY BYJNFTGUALE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x73CB8C0", Offset = "0x73CA6C0", VA = "0x1873CB8C0")]
		public static RSKHWHICBEK Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x73CC710", Offset = "0x73CB510", VA = "0x1873CC710")]
		public void VVUFAYMMXPR(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class DVQQOHAWOVY : ZATBRVXMRFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<SQMEOXSHHQG> CYKVKMQPUMM;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x73BFC80", Offset = "0x73BEA80", VA = "0x1873BFC80")]
		public DVQQOHAWOVY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x73C05E0", Offset = "0x73BF3E0", VA = "0x1873C05E0")]
		public static DVQQOHAWOVY Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x73C0760", Offset = "0x73BF560", VA = "0x1873C0760", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class VLKOXKBBYUF : ZATBRVXMRFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public BXVSOEPCMWE BSBENATBAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NBWHDWFIUMJ RJAKSXINQBA;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x73BFC80", Offset = "0x73BEA80", VA = "0x1873BFC80")]
		public VLKOXKBBYUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x73D3070", Offset = "0x73D1E70", VA = "0x1873D3070")]
		public static VLKOXKBBYUF Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x73D3240", Offset = "0x73D2040", VA = "0x1873D3240", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class WHASGVJGXBI : PPRLMDVXWFU
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x73BFC80", Offset = "0x73BEA80", VA = "0x1873BFC80")]
		public WHASGVJGXBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x73BFCD0", Offset = "0x73BEAD0", VA = "0x1873BFCD0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class PPRLMDVXWFU : ZATBRVXMRFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string ZKYCZECDPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color EDISAYOZGLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string EJZIZZKTKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float LPOKWXVCUFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float VMLFGXEWQME;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x73BFC80", Offset = "0x73BEA80", VA = "0x1873BFC80")]
		public PPRLMDVXWFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x73C9210", Offset = "0x73C8010", VA = "0x1873C9210", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class AOSNIRJFWNG : PPRLMDVXWFU
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x73BFC80", Offset = "0x73BEA80", VA = "0x1873BFC80")]
		public AOSNIRJFWNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x73BFCD0", Offset = "0x73BEAD0", VA = "0x1873BFCD0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class MCFSFSQSKGS : PPRLMDVXWFU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float PZXZNZXEWLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float UQGIDKWBMVC;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x73C8270", Offset = "0x73C7070", VA = "0x1873C8270")]
		public MCFSFSQSKGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x73C7F70", Offset = "0x73C6D70", VA = "0x1873C7F70", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface CLSDIWZVOOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XLJPBPOBORU(RSKHWHICBEK a, YMCPNEEYTNV b, [Out] ALBSRFQQISA c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface HBHULYGFSIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HBHULYGFSIL Clone(RSKHWHICBEK root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class XEDTKRTGFCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string NIWRYIUXXXZ;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected XEDTKRTGFCG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class GUVNONJQYKZ : HBHULYGFSIL
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty RLGMYNNNVSI
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x73C42E0", Offset = "0x73C30E0", VA = "0x1873C42E0", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GUVNONJQYKZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class BDSAHKHLIZT : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x73BFD80", Offset = "0x73BEB80", VA = "0x1873BFD80", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public BDSAHKHLIZT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class RSHNMYWBKVJ : SNIWNUMYYWL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color CNPSOPFGYGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public CJAUEKHAZRY REUQGCEWIXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color AIZECFPPHTM;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x73CB7B0", Offset = "0x73CA5B0", VA = "0x1873CB7B0")]
		public RSHNMYWBKVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x73CB2B0", Offset = "0x73CA0B0", VA = "0x1873CB2B0")]
		public static RSHNMYWBKVJ Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x73CB550", Offset = "0x73CA350", VA = "0x1873CB550", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class GIOAKPZCWMP : CJAUEKHAZRY
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string UQUPZRRHTBJ = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double GLTCDKGXFXV;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x73C4280", Offset = "0x73C3080", VA = "0x1873C4280")]
		public GIOAKPZCWMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x73C3ED0", Offset = "0x73C2CD0", VA = "0x1873C3ED0")]
		public new static GIOAKPZCWMP Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x73C41C0", Offset = "0x73C2FC0", VA = "0x1873C41C0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class YVYBJYFRZAL : CJAUEKHAZRY
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string IKXXNWLESPE = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double ZHEFPZUIWFI;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x73C4280", Offset = "0x73C3080", VA = "0x1873C4280")]
		public YVYBJYFRZAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x73D4B20", Offset = "0x73D3920", VA = "0x1873D4B20")]
		public new static YVYBJYFRZAL Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x73D4E10", Offset = "0x73D3C10", VA = "0x1873D4E10", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class LREFUPJXZOC : SNIWNUMYYWL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color LECMGCHOMMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public CJAUEKHAZRY SDTHRPQIJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double NOYDKPBUAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double ZJLCYQTCZRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public CJAUEKHAZRY QVVURECNMWD;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x73C7D20", Offset = "0x73C6B20", VA = "0x1873C7D20")]
		public LREFUPJXZOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x73C7720", Offset = "0x73C6520", VA = "0x1873C7720")]
		public static LREFUPJXZOC Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x73C7A90", Offset = "0x73C6890", VA = "0x1873C7A90", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class FFTWICBRMUH : SNIWNUMYYWL
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class IJGUSUENVJY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader OOFIQUZLQFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public RSKHWHICBEK BSGUJACPZOT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<RIFMZTUJKPT> CBANWYGKPPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<RIFMZTUJKPT> CAQACKSPWSM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, RIFMZTUJKPT>> CBFUUFAHZAN;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public IJGUSUENVJY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x73C5A50", Offset = "0x73C4850", VA = "0x1873C5A50")]
			internal RIFMZTUJKPT JIDCXYPQJBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x73C5B20", Offset = "0x73C4920", VA = "0x1873C5B20")]
			internal Dictionary<string, RIFMZTUJKPT> JIIJVFJNSMR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x73C5980", Offset = "0x73C4780", VA = "0x1873C5980")]
			internal RIFMZTUJKPT JHSPDLBVQEQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, RIFMZTUJKPT> DPUWGBMYJKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public RIFMZTUJKPT ZUWNHCPNHDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public RZDVZENZQHF KDKSVXRWXGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode CPOFFPFYKSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, RIFMZTUJKPT>> WUEZEUAVBTR;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x73C3320", Offset = "0x73C2120", VA = "0x1873C3320")]
		public FFTWICBRMUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x73C33C0", Offset = "0x73C21C0", VA = "0x1873C33C0")]
		public FFTWICBRMUH(FFTWICBRMUH a, RSKHWHICBEK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x73C2B30", Offset = "0x73C1930", VA = "0x1873C2B30")]
		public static int[] VLCLJODPYCZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x73C31C0", Offset = "0x73C1FC0", VA = "0x1873C31C0")]
		public static int[] XCWFOTQGOLF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x73C2520", Offset = "0x73C1320", VA = "0x1873C2520")]
		public static int[] ITBJGTEUYUR(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x73C2770", Offset = "0x73C1570", VA = "0x1873C2770")]
		public static int[] NTVGEMSXMMH(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x73C2470", Offset = "0x73C1270", VA = "0x1873C2470")]
		public static int[] FSTEPVNOSYO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x73C2AC0", Offset = "0x73C18C0", VA = "0x1873C2AC0")]
		public static int[] UWPYYUBFCGT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x73C26E0", Offset = "0x73C14E0", VA = "0x1873C26E0")]
		public static int[] LOMXJZVFUID(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x73C29C0", Offset = "0x73C17C0", VA = "0x1873C29C0")]
		public static int[] OCJQBMUVWRK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x73C2A30", Offset = "0x73C1830", VA = "0x1873C2A30")]
		public static int[] OMVSCGXGDUE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x73C2020", Offset = "0x73C0E20", VA = "0x1873C2020")]
		public static FFTWICBRMUH Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x73C2BD0", Offset = "0x73C19D0", VA = "0x1873C2BD0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class XLYJVKSMRKW
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] GKXKDCQNUZD;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] QNWAOOGPRMS;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] VPSJVXTNWBJ;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] LTDOOOWTPLH;
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
	public class FDTJOQJNBIL : ZATBRVXMRFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool LBYBRJPYCWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public PCBJFQQTXWV ZRYGNZIGVQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<SQMEOXSHHQG> GYIVLHUMCMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public LUPWUYDHQIL XFQHINQIZFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public HGASQPLNLGW FWLQKWDRWTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CJARLEBAFHN TCKKKUXCIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion JZOPJQMDSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 GLTCDKGXFXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 KEKFNVVKZQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> AJSQJMOLUEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public AWYQUFPZNFW GZRHWLSHXNL;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x73C1EF0", Offset = "0x73C0CF0", VA = "0x1873C1EF0")]
		public FDTJOQJNBIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x73C09D0", Offset = "0x73BF7D0", VA = "0x1873C09D0")]
		public static FDTJOQJNBIL Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x73C1300", Offset = "0x73C0100", VA = "0x1873C1300", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : ZATBRVXMRFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode ORFSTDQHTYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode QYLZFHZXOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode FOUMKHAVIEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode FOPFNAGXYTL;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x73D0AE0", Offset = "0x73CF8E0", VA = "0x1873D0AE0")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x73D0620", Offset = "0x73CF420", VA = "0x1873D0620")]
		public static Sampler Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x73D08F0", Offset = "0x73CF6F0", VA = "0x1873D08F0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
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
	public class XFQHINQIZFY : ZATBRVXMRFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public RIFMZTUJKPT BOPXVARQFWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public SQMEOXSHHQG ALBJJCVVAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<SQMEOXSHHQG> NNYBSFDRYTY;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x73D47B0", Offset = "0x73D35B0", VA = "0x1873D47B0")]
		public XFQHINQIZFY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x73D4140", Offset = "0x73D2F40", VA = "0x1873D4140")]
		public static XFQHINQIZFY Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x73D44A0", Offset = "0x73D32A0", VA = "0x1873D44A0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class CJAUEKHAZRY : SNIWNUMYYWL
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string LWDMCKBYHMZ = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string WVKWNSITLGF = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public QFUKSNFKKZZ ABEZYRMIUQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int GKXKDCQNUZD;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x73C04A0", Offset = "0x73BF2A0", VA = "0x1873C04A0")]
		public CJAUEKHAZRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x73C04F0", Offset = "0x73BF2F0", VA = "0x1873C04F0")]
		public CJAUEKHAZRY(CJAUEKHAZRY a, RSKHWHICBEK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x73C00F0", Offset = "0x73BEEF0", VA = "0x1873C00F0")]
		public static CJAUEKHAZRY Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x73C0440", Offset = "0x73BF240", VA = "0x1873C0440", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x73C0370", Offset = "0x73BF170", VA = "0x1873C0370")]
		public void PBWQUCDLPSS(JsonWriter a)
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
	public class HMOWRZJEGDZ
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double BLYEIJCSLJB;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double MHZGZBIGEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double QCEKKKQUPFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double RYZLULRAWGY;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x73C4D70", Offset = "0x73C3B70", VA = "0x1873C4D70")]
		public HMOWRZJEGDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x73C48D0", Offset = "0x73C36D0", VA = "0x1873C48D0")]
		public static HMOWRZJEGDZ Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x73C4B10", Offset = "0x73C3910", VA = "0x1873C4B10")]
		public void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class UQAITWSAYZV : ZATBRVXMRFW
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color UTCXUALTAYU;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double PXQGOFMBHEO;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double KKHHSCTCQBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType QCFSUOQZRCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color QNWAOOGPRMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double XCCCCSNKLUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double INIDJJAGXSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public HMOWRZJEGDZ HMOWRZJEGDZ;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x73D20B0", Offset = "0x73D0EB0", VA = "0x1873D20B0")]
		public UQAITWSAYZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x73D1F90", Offset = "0x73D0D90", VA = "0x1873D1F90")]
		public UQAITWSAYZV(UQAITWSAYZV a, RSKHWHICBEK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x73D16A0", Offset = "0x73D04A0", VA = "0x1873D16A0")]
		public static UQAITWSAYZV Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x73D1A90", Offset = "0x73D0890", VA = "0x1873D1A90")]
		public static UQAITWSAYZV Deserialize(RSKHWHICBEK root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x73D1BB0", Offset = "0x73D09B0", VA = "0x1873D1BB0", Slot = "4")]
		public override void VVUFAYMMXPR(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class QMRNWVFPASF : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<PPRLMDVXWFU> JNVYCVWDPBY;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public QMRNWVFPASF(IList<PPRLMDVXWFU> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x73C9A30", Offset = "0x73C8830", VA = "0x1873C9A30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x73C99C0", Offset = "0x73C87C0", VA = "0x1873C99C0", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class JPCQKXSZNZL : HBHULYGFSIL, CLSDIWZVOOV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<UQAITWSAYZV> CLAQQLQJSXA;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x73C6E20", Offset = "0x73C5C20", VA = "0x1873C6E20")]
		public JPCQKXSZNZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x73C5FB0", Offset = "0x73C4DB0", VA = "0x1873C5FB0", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x73C6940", Offset = "0x73C5740", VA = "0x1873C6940", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x73C6230", Offset = "0x73C5030", VA = "0x1873C6230")]
		private static string[] LTDQNERRHKJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x73C64E0", Offset = "0x73C52E0", VA = "0x1873C64E0")]
		private static ALBSRFQQISA.ImportValuesConversion PSSXPGTWIBH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x73C6A30", Offset = "0x73C5830", VA = "0x1873C6A30", Slot = "6")]
		public bool XLJPBPOBORU(RSKHWHICBEK a, YMCPNEEYTNV b, [Out] ALBSRFQQISA c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class UJVDDGYGEOG : CFJRXTHGIZK<UQAITWSAYZV>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override UQAITWSAYZV Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x73D1550", Offset = "0x73D0350", VA = "0x1873D1550", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x73D1510", Offset = "0x73D0310", VA = "0x1873D1510")]
		public UJVDDGYGEOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x73D1430", Offset = "0x73D0230", VA = "0x1873D1430")]
		public static UJVDDGYGEOG Deserialize(RSKHWHICBEK root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class MSXLJBFZBQZ : HBHULYGFSIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public UJVDDGYGEOG AWYQUFPZNFW;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public MSXLJBFZBQZ(UJVDDGYGEOG a, RSKHWHICBEK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x73C85E0", Offset = "0x73C73E0", VA = "0x1873C85E0")]
		public MSXLJBFZBQZ(int a, RSKHWHICBEK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x73C8460", Offset = "0x73C7260", VA = "0x1873C8460", Slot = "5")]
		public HBHULYGFSIL Clone(RSKHWHICBEK root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x73C84E0", Offset = "0x73C72E0", VA = "0x1873C84E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class WBMDCDBSYIA : XEDTKRTGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x73D38A0", Offset = "0x73D26A0", VA = "0x1873D38A0")]
		public WBMDCDBSYIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x73D33B0", Offset = "0x73D21B0", VA = "0x1873D33B0", Slot = "4")]
		public override HBHULYGFSIL Deserialize(RSKHWHICBEK root, JProperty extensionToken)
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
