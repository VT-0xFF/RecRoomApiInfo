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
	public class KHR_animation_pointer : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public object OFHXMUGGGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string TOXZEZHOWPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string EKQZZKSSZXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public VPDOWTOVCZB OHBRDEUWDHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KHR_animation_pointer BGSZQQBQWCY;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x716E760", Offset = "0x716CF60", VA = "0x18716E760", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x716E6B0", Offset = "0x716CEB0", VA = "0x18716E6B0", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public KHR_animation_pointer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class GPDYNJMHGFE
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly GLTF.Math.Vector3 FKVUIQKDHOZ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly GLTF.Math.Vector4 YNWSYTCGHGE;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal static readonly UnityEngine.Quaternion AOLFMNQLWVS;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool ZKMQOJHIXDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x716A610", Offset = "0x7168E10", VA = "0x18716A610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x716AD50", Offset = "0x7169550", VA = "0x18716AD50")]
		public static void YVWMXSLXPWI(this LBKZHWCVPSD a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71680E0", Offset = "0x71668E0", VA = "0x1871680E0")]
		public static void FPILDNCCJMK(this LBKZHWCVPSD a, Transform b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7169D10", Offset = "0x7168510", VA = "0x187169D10")]
		public static void MNNSCPPECMF(this Matrix4x4 a, [Out] UnityEngine.Vector3 b, [Out] UnityEngine.Quaternion c, [Out] UnityEngine.Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x716A1D0", Offset = "0x71689D0", VA = "0x18716A1D0")]
		public static GLTF.Math.Vector4 MWSGTVWVMKL(this NWPNRJQQBKK a, uint b)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x716B420", Offset = "0x7169C20", VA = "0x18716B420")]
		public static UnityEngine.Quaternion YZIAXHGKHSG(this GLTF.Math.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x716B2F0", Offset = "0x7169AF0", VA = "0x18716B2F0")]
		public static UnityEngine.Quaternion YZIAXHGKHSG(this float4 a)
		{
			return default(UnityEngine.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x716A880", Offset = "0x7169080", VA = "0x18716A880")]
		public static GLTF.Math.Quaternion SVRQWYNMFRU(this UnityEngine.Quaternion a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7168BF0", Offset = "0x71673F0", VA = "0x187168BF0")]
		public static Matrix4x4 GVCPCCNSACN(this NWPNRJQQBKK a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x71687B0", Offset = "0x7166FB0", VA = "0x1871687B0")]
		public static Matrix4x4 GVCPCCNSACN(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7169550", Offset = "0x7167D50", VA = "0x187169550")]
		public static NWPNRJQQBKK JQXQSAPSSUV(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x716AC30", Offset = "0x7169430", VA = "0x18716AC30")]
		public static UnityEngine.Vector3 YSUYKPTXMMU(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x716AB60", Offset = "0x7169360", VA = "0x18716AB60")]
		public static UnityEngine.Vector3 YSUYKPTXMMU(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x716B5A0", Offset = "0x7169DA0", VA = "0x18716B5A0")]
		public static GLTF.Math.Vector3 ZLKQRBQTWIY(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7169A70", Offset = "0x7168270", VA = "0x187169A70")]
		public static GLTF.Math.Vector3 KSWPPVYDYYJ(this UnityEngine.Vector3 a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x10D5E60", Offset = "0x10D4660", VA = "0x1810D5E60")]
		public static GLTF.Math.Vector4 KWBIRZUXFTM(this UnityEngine.Vector4 a)
		{
			return default(GLTF.Math.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7169020", Offset = "0x7167820", VA = "0x187169020")]
		public static Matrix4x4 JLPYLKZTIKA(this NWPNRJQQBKK a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x71692E0", Offset = "0x7167AE0", VA = "0x1871692E0")]
		public static Matrix4x4 JLPYLKZTIKA(this float4x4 a)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7167F10", Offset = "0x7166710", VA = "0x187167F10")]
		public static NWPNRJQQBKK BPVFNCMFUOM(this Matrix4x4 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x716A1B0", Offset = "0x71689B0", VA = "0x18716A1B0")]
		public static UnityEngine.Vector2 MRUQKHOCEEQ(this GLTF.Math.Vector2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x716A1B0", Offset = "0x71689B0", VA = "0x18716A1B0")]
		public static UnityEngine.Vector2 MRUQKHOCEEQ(this float2 a)
		{
			return default(UnityEngine.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x716A0E0", Offset = "0x71688E0", VA = "0x18716A0E0")]
		public static void MRUQKHOCEEQ(this float2[] a, UnityEngine.Vector2[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7169CB0", Offset = "0x71684B0", VA = "0x187169CB0")]
		public static UnityEngine.Vector3 LYMGDZYMZQJ(this GLTF.Math.Vector3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1ADE6C0", Offset = "0x1ADCEC0", VA = "0x181ADE6C0")]
		public static UnityEngine.Vector3 LYMGDZYMZQJ(this float3 a)
		{
			return default(UnityEngine.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7169BC0", Offset = "0x71683C0", VA = "0x187169BC0")]
		public static void LYMGDZYMZQJ(this float3[] a, UnityEngine.Vector3[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x10D5E60", Offset = "0x10D4660", VA = "0x1810D5E60")]
		public static UnityEngine.Vector4 IXLYWQWWXSK(this GLTF.Math.Vector4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x10D5E60", Offset = "0x10D4660", VA = "0x1810D5E60")]
		public static UnityEngine.Vector4 IXLYWQWWXSK(this float4 a)
		{
			return default(UnityEngine.Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7168F20", Offset = "0x7167720", VA = "0x187168F20")]
		public static UnityEngine.Vector4[] IXLYWQWWXSK(this float4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7168E10", Offset = "0x7167610", VA = "0x187168E10")]
		public static void IXLYWQWWXSK(this float4[] a, UnityEngine.Vector4[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7169890", Offset = "0x7168090", VA = "0x187169890")]
		public static UnityEngine.Color JVVOTLNFEJC(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7169930", Offset = "0x7168130", VA = "0x187169930")]
		public static void JVVOTLNFEJC(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7169890", Offset = "0x7168090", VA = "0x187169890")]
		public static UnityEngine.Color JVVOTLNFEJC(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x10D5E60", Offset = "0x10D4660", VA = "0x1810D5E60")]
		public static UnityEngine.Color LVZPAIPTYZJ(this GLTF.Math.Color a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7169AB0", Offset = "0x71682B0", VA = "0x187169AB0")]
		public static void LVZPAIPTYZJ(this float4[] a, UnityEngine.Color[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10D5E60", Offset = "0x10D4660", VA = "0x1810D5E60")]
		public static UnityEngine.Color LVZPAIPTYZJ(this float4 a)
		{
			return default(UnityEngine.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7167EE0", Offset = "0x71666E0", VA = "0x187167EE0")]
		public static GLTF.Math.Color AFHMCRFYISJ(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x716A9C0", Offset = "0x71691C0", VA = "0x18716A9C0")]
		public static GLTF.Math.Color WGIYQCQWMAE(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x716A590", Offset = "0x7168D90", VA = "0x18716A590")]
		public static GLTF.Math.Color PAIHNQUFEGS(this UnityEngine.Color a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x716AA40", Offset = "0x7169240", VA = "0x18716AA40")]
		public static UnityEngine.Color[] YMWVGWLEWEP(this UnityEngine.Color[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x716A800", Offset = "0x7169000", VA = "0x18716A800")]
		public static int[] SMCVPRVHZWC(this uint[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7167E30", Offset = "0x7166630", VA = "0x187167E30")]
		public static UnityEngine.Vector2[] ABDQAMESGWJ(UnityEngine.Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x716A6A0", Offset = "0x7168EA0", VA = "0x18716A6A0")]
		public static void SBKEHIJLOGW(QOTPRWEVTIC a, GLTF.Math.Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x71685E0", Offset = "0x7166DE0", VA = "0x1871685E0")]
		public static UnityEngine.Vector3[] FTPTTKWJGNI(UnityEngine.Vector3[] a, GLTF.Math.Vector3 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x716A3F0", Offset = "0x7168BF0", VA = "0x18716A3F0")]
		public static UnityEngine.Vector4[] NVGOPHAVIXJ(UnityEngine.Vector4[] a, GLTF.Math.Vector4 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7168740", Offset = "0x7166F40", VA = "0x187168740")]
		public static void GIBZAMEFFBE(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x716B6D0", Offset = "0x7169ED0", VA = "0x18716B6D0")]
		public static UnityEngine.Quaternion ZWQZETRBTDS(this UnityEngine.Quaternion a)
		{
			return default(UnityEngine.Quaternion);
		}
	}
}
namespace GLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class QOTPRWEVTIC
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LDTJWYXTGAV LDTJWYXTGAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NumericArray IJRDTWIEGWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			[CompilerGenerated]
			get
			{
				return default(NumericArray);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x71746E0", Offset = "0x7172EE0", VA = "0x1871746E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<byte> UCPEISFAAQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xC42E20", Offset = "0xC41620", VA = "0x180C42E20")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD23570", Offset = "0xD21D70", VA = "0x180D23570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public uint DBSVIGQRSKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A80", Offset = "0xAB7280", VA = "0x180AB8A80")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A70", Offset = "0xAB7270", VA = "0x180AB8A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x71746F0", Offset = "0x7172EF0", VA = "0x1871746F0")]
		public QOTPRWEVTIC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFHeaderInvalidException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7167C40", Offset = "0x7166440", VA = "0x187167C40")]
		public GLTFHeaderInvalidException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLTFParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7167CA0", Offset = "0x71664A0", VA = "0x187167CA0")]
		public GLTFParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class BXAHZVGZKAT
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class YYKNAAKSVGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Dictionary<int, int> VUVXLFWDQHQ;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public YYKNAAKSVGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7176CD0", Offset = "0x71754D0", VA = "0x187176CD0")]
			internal int? JPSXXNXBQCH(int? a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7176C40", Offset = "0x7175440", VA = "0x187176C40")]
			internal int? CTJASTFSXTI(int? a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7176D50", Offset = "0x7175550", VA = "0x187176D50")]
			internal bool TFZVBIASILI(int a, int b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x715C5B0", Offset = "0x715ADB0", VA = "0x18715C5B0")]
		private static void DYWIODMBECA(NumericArray a, QOTPRWEVTIC b, QOTPRWEVTIC c, QOTPRWEVTIC d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x715CE10", Offset = "0x715B610", VA = "0x18715CE10")]
		public static void POBTGVRLHJD(Dictionary<string, QOTPRWEVTIC> a, Dictionary<string, (QOTPRWEVTIC sparseIndices, QOTPRWEVTIC sparseValues)> sparseAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x715E560", Offset = "0x715CD60", VA = "0x18715E560")]
		public static void VZXWSENFSIV(Dictionary<string, QOTPRWEVTIC> a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x715CD10", Offset = "0x715B510", VA = "0x18715CD10")]
		public static void IUBKPSZNQKO(QOTPRWEVTIC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x715EA40", Offset = "0x715D240", VA = "0x18715EA40")]
		public static void ZMHWOAEWPDG(Dictionary<string, List<QOTPRWEVTIC>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x715CB20", Offset = "0x715B320", VA = "0x18715CB20")]
		private static void GHGZCHSUFLK(QOTPRWEVTIC a, [Out] NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x715CC50", Offset = "0x715B450", VA = "0x18715CC50")]
		internal static void GHGZCHSUFLK(HZHKBLSVYPO a, uint b, NativeArray<byte> c, [Out] NativeArray<byte> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x715E0D0", Offset = "0x715C8D0", VA = "0x18715E0D0")]
		public static KMXGEKPSBZI VYEQNZNLYCA(IEnumerable<KMXGEKPSBZI> a)
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
			[Cpp2IlInjected.Address(RVA = "0xCC9230", Offset = "0xCC7A30", VA = "0x180CC9230")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public uint FileLength
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2E1D5E0", Offset = "0x2E1BDE0", VA = "0x182E1D5E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2E1D5F0", Offset = "0x2E1BDF0", VA = "0x182E1D5F0")]
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
	public class CFTNAZKRTPX
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly uint LDEYFNIQKTQ;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly uint XPQHEWZUSFK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly uint RTYBMVOIHKC;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x715F270", Offset = "0x715DA70", VA = "0x18715F270")]
		public static void AWISMFCDRDO(Stream a, [Out] LAUAUTWBLDQ b, long c = 0L)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x715F770", Offset = "0x715DF70", VA = "0x18715F770")]
		public static ChunkInfo ZUKXGGXFJJK(Stream a, int b, long c = 0L)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x715F430", Offset = "0x715DC30", VA = "0x18715F430")]
		public static GLBHeader LPTMQTPVQUA(Stream a)
		{
			return default(GLBHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x715FA00", Offset = "0x715E200", VA = "0x18715FA00")]
		public static bool ZXJYTBKHQCO(Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x715F570", Offset = "0x715DD70", VA = "0x18715F570")]
		public static ChunkInfo PRMDYXBEFMD(Stream a)
		{
			return default(ChunkInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x715EFD0", Offset = "0x715D7D0", VA = "0x18715EFD0")]
		private static void ANLCHPSNJHT(Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x715F6E0", Offset = "0x715DEE0", VA = "0x18715F6E0")]
		private static uint QIGVSNZDBJW(Stream a)
		{
			return default(uint);
		}
	}
}
namespace GLTF.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class QCIBGCEFWCD
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
		public PathElement DJWWNSWNESA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAAC110", Offset = "0xAAA910", VA = "0x180AAC110")]
			[CompilerGenerated]
			get
			{
				return default(PathElement);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAB2560", Offset = "0xAB0D60", VA = "0x180AB2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int DWACUWIQEPL
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB5F300", Offset = "0xB5DB00", VA = "0x180B5F300")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xB5F310", Offset = "0xB5DB10", VA = "0x180B5F310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string HKLRFDGTPFI
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAACB10", Offset = "0xAAB310", VA = "0x180AACB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NHOLTJPHZVN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB290", VA = "0x180AACA90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAACB00", Offset = "0xAAB300", VA = "0x180AACB00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public QCIBGCEFWCD PHGRVDCEKUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAE970", VA = "0x180AB0170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7174230", Offset = "0x7172A30", VA = "0x187174230")]
		public string UOCIEVZBJAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7174210", Offset = "0x7172A10", VA = "0x187174210")]
		public QCIBGCEFWCD JWMFHMZWZUN(PathElement a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x71744D0", Offset = "0x7172CD0", VA = "0x1871744D0")]
		private QCIBGCEFWCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7174530", Offset = "0x7172D30", VA = "0x187174530")]
		public QCIBGCEFWCD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4109260", Offset = "0x4107A60", VA = "0x184109260")]
		[CompilerGenerated]
		internal static string DOULSYHPHAP(<>c__DisplayClass24_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x71742B0", Offset = "0x7172AB0", VA = "0x1871742B0")]
		[CompilerGenerated]
		internal static bool VRNUWHKUTMG([Out] int a, <>c__DisplayClass24_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x71742F0", Offset = "0x7172AF0", VA = "0x1871742F0")]
		[CompilerGenerated]
		internal static QCIBGCEFWCD WVJMOASKFEA(<>c__DisplayClass24_0 a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class MVIGMQXMQTS
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7172EF0", Offset = "0x71716F0", VA = "0x187172EF0")]
		public static int[] LNICIMSCIPQ(this LAUAUTWBLDQ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7173190", Offset = "0x7171990", VA = "0x187173190")]
		public static int[] VTXLNCRWNPW(this LAUAUTWBLDQ a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class CNEUANYLUQY
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x71608E0", Offset = "0x715F0E0", VA = "0x1871608E0")]
		public static uint BIADNGKDECH(this JsonReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SubStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Stream IWWXAQASEQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly long UNUPUDJWWHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long FTNEBYYIZBB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7174FF0", Offset = "0x71737F0", VA = "0x187174FF0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7175030", Offset = "0x7173830", VA = "0x187175030", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7175030", Offset = "0x7173830", VA = "0x187175030", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7175050", Offset = "0x7173850", VA = "0x187175050", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7175070", Offset = "0x7173870", VA = "0x187175070", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7175090", Offset = "0x7173890", VA = "0x187175090", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7174D80", Offset = "0x7173580", VA = "0x187174D80")]
		public SubStream(Stream baseStream, long offset, long length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7174B40", Offset = "0x7173340", VA = "0x187174B40", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7174CA0", Offset = "0x71734A0", VA = "0x187174CA0", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7174D00", Offset = "0x7173500", VA = "0x187174D00", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7174C10", Offset = "0x7173410", VA = "0x187174C10", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7174D40", Offset = "0x7173540", VA = "0x187174D40", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7174B80", Offset = "0x7173380", VA = "0x187174B80")]
		private void PXCWBMFIVIK()
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
		public static Color TSZRRXVJMVY
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7162C60", Offset = "0x7161460", VA = "0x187162C60")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Color QEMBYYETIHG
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7162BA0", Offset = "0x71613A0", VA = "0x187162BA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Color EWHNPEAUMTG
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7162D30", Offset = "0x7161530", VA = "0x187162D30")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B35210", Offset = "0x2B33A10", VA = "0x182B35210")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x15BF9C0", Offset = "0x15BE1C0", VA = "0x1815BF9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B8F8F0", Offset = "0x2B8E0F0", VA = "0x182B8F8F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2B8F900", Offset = "0x2B8E100", VA = "0x182B8F900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x290CC70", Offset = "0x290B470", VA = "0x18290CC70")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x30151F0", Offset = "0x30139F0", VA = "0x1830151F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x126B050", Offset = "0x1269850", VA = "0x18126B050")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x126B060", Offset = "0x1269860", VA = "0x18126B060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28CF440", Offset = "0x28CDC40", VA = "0x1828CF440")]
		public Color(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7162A50", Offset = "0x7161250", VA = "0x187162A50", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7162B00", Offset = "0x7161300", VA = "0x187162B00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7162BB0", Offset = "0x71613B0", VA = "0x187162BB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7162C80", Offset = "0x7161480", VA = "0x187162C80")]
		public static bool XUHFAYKFXBY(Color a, Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class NWPNRJQQBKK : IEquatable<NWPNRJQQBKK>
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly NWPNRJQQBKK KSMEKERHFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float[] KEOVOCMVGFF;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float MOPPKUQFGJO
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7173B20", Offset = "0x7172320", VA = "0x187173B20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7173A90", Offset = "0x7172290", VA = "0x187173A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float SMYMWNESPZN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x71739A0", Offset = "0x71721A0", VA = "0x1871739A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7173910", Offset = "0x7172110", VA = "0x187173910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float ZNFEARZAMVE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x71738B0", Offset = "0x71720B0", VA = "0x1871738B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7173400", Offset = "0x7171C00", VA = "0x187173400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float HKNFLCPOEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7173370", Offset = "0x7171B70", VA = "0x187173370")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7173C40", Offset = "0x7172440", VA = "0x187173C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float MPFKCOXXIRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7173B50", Offset = "0x7172350", VA = "0x187173B50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7173AC0", Offset = "0x71722C0", VA = "0x187173AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float SNDTTTYPZKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7173A00", Offset = "0x7172200", VA = "0x187173A00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7173970", Offset = "0x7172170", VA = "0x187173970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float ZMZXDLFDDJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7173850", Offset = "0x7172050", VA = "0x187173850")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x71733A0", Offset = "0x7171BA0", VA = "0x1871733A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float HJXKTIHWCCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7173340", Offset = "0x7171B40", VA = "0x187173340")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7173C10", Offset = "0x7172410", VA = "0x187173C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MPADFIDZZGG
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7173B80", Offset = "0x7172380", VA = "0x187173B80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7173AF0", Offset = "0x71722F0", VA = "0x187173AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float SNJARASNIWF
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x71739D0", Offset = "0x71721D0", VA = "0x1871739D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7173940", Offset = "0x7172140", VA = "0x187173940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float ZMUQGELFTYM
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7173880", Offset = "0x7172080", VA = "0x187173880")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x71733D0", Offset = "0x7171BD0", VA = "0x1871733D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float HKCRQPBTLNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7173310", Offset = "0x7171B10", VA = "0x187173310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7173BE0", Offset = "0x71723E0", VA = "0x187173BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float MPPXXCLSBOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7173BB0", Offset = "0x71723B0", VA = "0x187173BB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7173A60", Offset = "0x7172260", VA = "0x187173A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float SNOHOHMKSHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7173A30", Offset = "0x7172230", VA = "0x187173A30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x71738E0", Offset = "0x71720E0", VA = "0x1871738E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float ZOFMMZUNHZX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7173820", Offset = "0x7172020", VA = "0x187173820")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7173430", Offset = "0x7171C30", VA = "0x187173430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float HLDACWXGGSG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x71732E0", Offset = "0x7171AE0", VA = "0x1871732E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7173C70", Offset = "0x7172470", VA = "0x187173C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7173D70", Offset = "0x7172570", VA = "0x187173D70")]
		public NWPNRJQQBKK(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7173460", Offset = "0x7171C60", VA = "0x187173460", Slot = "4")]
		public bool Equals(NWPNRJQQBKK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7173720", Offset = "0x7171F20", VA = "0x187173720", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xE42540", Offset = "0xE40D40", VA = "0x180E42540", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B35210", Offset = "0x2B33A10", VA = "0x182B35210")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x15BF9C0", Offset = "0x15BE1C0", VA = "0x1815BF9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2B8F8F0", Offset = "0x2B8E0F0", VA = "0x182B8F8F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2B8F900", Offset = "0x2B8E100", VA = "0x182B8F900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x290CC70", Offset = "0x290B470", VA = "0x18290CC70")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x30151F0", Offset = "0x30139F0", VA = "0x1830151F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x126B050", Offset = "0x1269850", VA = "0x18126B050")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x126B060", Offset = "0x1269860", VA = "0x18126B060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7174AB0", Offset = "0x71732B0", VA = "0x187174AB0")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7174720", Offset = "0x7172F20", VA = "0x187174720", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7174840", Offset = "0x7173040", VA = "0x187174840", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x71748F0", Offset = "0x71730F0", VA = "0x1871748F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x71749D0", Offset = "0x71731D0", VA = "0x1871749D0")]
		public static bool XUHFAYKFXBY(Quaternion a, Quaternion b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B35210", Offset = "0x2B33A10", VA = "0x182B35210")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x15BF9C0", Offset = "0x15BE1C0", VA = "0x1815BF9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2B8F8F0", Offset = "0x2B8E0F0", VA = "0x182B8F8F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2B8F900", Offset = "0x2B8E100", VA = "0x182B8F900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xDB1360", Offset = "0xDAFB60", VA = "0x180DB1360")]
		public Vector2(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x71755A0", Offset = "0x7173DA0", VA = "0x1871755A0")]
		public Vector2(Vector2 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x71753B0", Offset = "0x7173BB0", VA = "0x1871753B0", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7175410", Offset = "0x7173C10", VA = "0x187175410", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x71754F0", Offset = "0x7173CF0", VA = "0x1871754F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7175540", Offset = "0x7173D40", VA = "0x187175540")]
		public static bool XUHFAYKFXBY(Vector2 a, Vector2 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B35210", Offset = "0x2B33A10", VA = "0x182B35210")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x15BF9C0", Offset = "0x15BE1C0", VA = "0x1815BF9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2B8F8F0", Offset = "0x2B8E0F0", VA = "0x182B8F8F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2B8F900", Offset = "0x2B8E100", VA = "0x182B8F900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x290CC70", Offset = "0x290B470", VA = "0x18290CC70")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x30151F0", Offset = "0x30139F0", VA = "0x1830151F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7175950", Offset = "0x7174150", VA = "0x187175950")]
		public Vector3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x71755C0", Offset = "0x7173DC0", VA = "0x1871755C0", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x71756A0", Offset = "0x7173EA0", VA = "0x1871756A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7175760", Offset = "0x7173F60", VA = "0x187175760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7175810", Offset = "0x7174010", VA = "0x187175810")]
		public static bool XUHFAYKFXBY(Vector3 a, Vector3 b)
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
			[Cpp2IlInjected.Address(RVA = "0x2B35210", Offset = "0x2B33A10", VA = "0x182B35210")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x15BF9C0", Offset = "0x15BE1C0", VA = "0x1815BF9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B8F8F0", Offset = "0x2B8E0F0", VA = "0x182B8F8F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2B8F900", Offset = "0x2B8E100", VA = "0x182B8F900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x290CC70", Offset = "0x290B470", VA = "0x18290CC70")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x30151F0", Offset = "0x30139F0", VA = "0x1830151F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x126B050", Offset = "0x1269850", VA = "0x18126B050")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x126B060", Offset = "0x1269860", VA = "0x18126B060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28CF440", Offset = "0x28CDC40", VA = "0x1828CF440")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7162A50", Offset = "0x7161250", VA = "0x187162A50", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x71759D0", Offset = "0x71741D0", VA = "0x1871759D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7162BB0", Offset = "0x71613B0", VA = "0x187162BB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace GLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class CYQUIIKDXXK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x71629D0", Offset = "0x71611D0", VA = "0x1871629D0")]
		public static void XYGTVOHACSV(this JObject a, string b, QIKLJPGCIIC c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class CNEUANYLUQY
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7160730", Offset = "0x715EF30", VA = "0x187160730")]
		public static List<string> BEXHOBFSJIS(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7161F60", Offset = "0x7160760", VA = "0x187161F60")]
		public static List<double> XXHPDASKQDQ(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7160A30", Offset = "0x715F230", VA = "0x187160A30")]
		public static List<int> CDPPAAGZWDP(this JsonReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x349C510", Offset = "0x349AD10", VA = "0x18349C510")]
		public static List<a> WESUIKQPLWH<a>(this JsonReader a, Func<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7162260", Offset = "0x7160A60", VA = "0x187162260")]
		public static QIKLJPGCIIC YOFNJRHOPGV(this JToken a, LAUAUTWBLDQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7162120", Offset = "0x7160920", VA = "0x187162120")]
		public static int XXZINMFMZOD(this JToken a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7161140", Offset = "0x715F940", VA = "0x187161140")]
		public static double JQDANURDHRJ(this JToken a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7160E60", Offset = "0x715F660", VA = "0x187160E60")]
		public static GLTF.Math.Color HFDEIZZLTQI(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7160BF0", Offset = "0x715F3F0", VA = "0x187160BF0")]
		public static GLTF.Math.Color GLQWWSKXCZD(this JToken a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x71616F0", Offset = "0x715FEF0", VA = "0x1871616F0")]
		public static GLTF.Math.Color OOMQGEUDXBH(this JsonReader a)
		{
			return default(GLTF.Math.Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7161990", Offset = "0x7160190", VA = "0x187161990")]
		public static GLTF.Math.Vector3 VNMOTRJWLYV(this JsonReader a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x71614E0", Offset = "0x715FCE0", VA = "0x1871614E0")]
		public static GLTF.Math.Vector2 JSDCZWMIQYJ(this JToken a)
		{
			return default(GLTF.Math.Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7161280", Offset = "0x715FA80", VA = "0x187161280")]
		public static GLTF.Math.Vector3 JRXWCPSLHNA(this JToken a)
		{
			return default(GLTF.Math.Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7161C50", Offset = "0x7160450", VA = "0x187161C50")]
		public static GLTF.Math.Quaternion WJPFVLGSMUT(this JsonReader a)
		{
			return default(GLTF.Math.Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x349BF00", Offset = "0x349A700", VA = "0x18349BF00")]
		public static Dictionary<string, b> GSKMUDOKWZR<b>(this JsonReader a, Func<b> b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x349BBB0", Offset = "0x349A3B0", VA = "0x18349BBB0")]
		public static c AZNJRBAEABB<c>(this JsonReader a)
		{
			return (c)null;
		}
	}
}
namespace GLTF.Schema
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class EXT_meshopt_compression : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public HZHKBLSVYPO bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isFallbackBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7163100", Offset = "0x7161900", VA = "0x187163100", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7163080", Offset = "0x7161880", VA = "0x187163080", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public EXT_meshopt_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class KRRATIOLKAT : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7172530", Offset = "0x7170D30", VA = "0x187172530")]
		public KRRATIOLKAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7172460", Offset = "0x7170C60", VA = "0x187172460", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EXT_mesh_gpu_instancing : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, LDTJWYXTGAV> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7162F40", Offset = "0x7161740", VA = "0x187162F40", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7163000", Offset = "0x7161800", VA = "0x187163000")]
		public EXT_mesh_gpu_instancing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class KKZGRIDDDPT : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class WSROETRUXZR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public LAUAUTWBLDQ GCIIEAQCVVB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JsonReader SMROOBILXEY;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public WSROETRUXZR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7175C20", Offset = "0x7174420", VA = "0x187175C20")]
			internal LDTJWYXTGAV CCVXQDNGJPA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7171EF0", Offset = "0x71706F0", VA = "0x187171EF0")]
		public KKZGRIDDDPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7171D60", Offset = "0x7170560", VA = "0x187171D60", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EXT_texture_exr : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public EMIQBIZRTNX ZDHBKYVUAZU;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public EXT_texture_exr(EMIQBIZRTNX source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7163150", Offset = "0x7161950", VA = "0x187163150", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x71631C0", Offset = "0x71619C0", VA = "0x1871631C0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ISDIOWEWRAI : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x716BB90", Offset = "0x716A390", VA = "0x18716BB90")]
		public ISDIOWEWRAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x716BA70", Offset = "0x716A270", VA = "0x18716BA70", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
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
	public class AudioEmitterId : PFBVESDYJJS<KHR_AudioEmitter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override KHR_AudioEmitter Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x715C2D0", Offset = "0x715AAD0", VA = "0x18715C2D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x715C290", Offset = "0x715AA90", VA = "0x18715C290")]
		public AudioEmitterId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AudioSourceId : PFBVESDYJJS<KHR_AudioSource>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override KHR_AudioSource Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x715C460", Offset = "0x715AC60", VA = "0x18715C460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x715C420", Offset = "0x715AC20", VA = "0x18715C420")]
		public AudioSourceId()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AudioDataId : PFBVESDYJJS<KHR_AudioData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override KHR_AudioData Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x715C140", Offset = "0x715A940", VA = "0x18715C140", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x715C100", Offset = "0x715A900", VA = "0x18715C100")]
		public AudioDataId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x715C020", Offset = "0x715A820", VA = "0x18715C020")]
		public static AudioDataId Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHR_SceneAudioEmittersRef : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<AudioEmitterId> emitters;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x716E3D0", Offset = "0x716CBD0", VA = "0x18716E3D0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x716DFD0", Offset = "0x716C7D0", VA = "0x18716DFD0", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x716E040", Offset = "0x716C840", VA = "0x18716E040")]
		public static KHR_SceneAudioEmittersRef Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x716E630", Offset = "0x716CE30", VA = "0x18716E630")]
		public KHR_SceneAudioEmittersRef()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KHR_NodeAudioEmitterRef : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AudioEmitterId emitter;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static string ExtensionName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x716DFA0", Offset = "0x716C7A0", VA = "0x18716DFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x716DE80", Offset = "0x716C680", VA = "0x18716DE80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x716DC70", Offset = "0x716C470", VA = "0x18716DC70", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x716DCE0", Offset = "0x716C4E0", VA = "0x18716DCE0")]
		public static KHR_NodeAudioEmitterRef Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public KHR_NodeAudioEmitterRef()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class KVLWEGJVRTD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string IDEDYQCEXAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float? ESZGZAUDXRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? TDUYGDNQQDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? NGXDEMTQECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PositionalAudioDistanceModel? XRPGIRZKSRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float? EEZZVRIPCPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? GYHZVFJEXLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? JOHCDHUZDAO;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7172C80", Offset = "0x7171480", VA = "0x187172C80")]
		public JObject VOPQGDPBGDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7172580", Offset = "0x7170D80", VA = "0x187172580")]
		public static KVLWEGJVRTD Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public KVLWEGJVRTD()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KHR_AudioEmitter : GDKFMQAPOKE
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
		public KVLWEGJVRTD positional;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x716D2C0", Offset = "0x716BAC0", VA = "0x18716D2C0", Slot = "5")]
		public virtual JObject VOPQGDPBGDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x716CDC0", Offset = "0x716B5C0", VA = "0x18716CDC0")]
		public static KHR_AudioEmitter Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x716D660", Offset = "0x716BE60", VA = "0x18716D660")]
		public KHR_AudioEmitter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KHR_AudioSource : GDKFMQAPOKE
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
		[Cpp2IlInjected.Address(RVA = "0x716DA40", Offset = "0x716C240", VA = "0x18716DA40")]
		public JObject VOPQGDPBGDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x716D6E0", Offset = "0x716BEE0", VA = "0x18716D6E0")]
		public static KHR_AudioSource Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7167C30", Offset = "0x7166430", VA = "0x187167C30")]
		public KHR_AudioSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KHR_AudioData : GDKFMQAPOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public ASFDPWTHLOR bufferView;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x716CC90", Offset = "0x716B490", VA = "0x18716CC90")]
		public JObject VOPQGDPBGDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x716CA30", Offset = "0x716B230", VA = "0x18716CA30")]
		public static KHR_AudioData Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7167C30", Offset = "0x7166430", VA = "0x187167C30")]
		public KHR_AudioData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KHR_audio_emitter : FSIGLUSVGTB
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
		[Cpp2IlInjected.Address(RVA = "0x716E8F0", Offset = "0x716D0F0", VA = "0x18716E8F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x716E860", Offset = "0x716D060", VA = "0x18716E860", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x716F020", Offset = "0x716D820", VA = "0x18716F020")]
		public KHR_audio_emitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class CHJMOQZTAAI : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x71606E0", Offset = "0x715EEE0", VA = "0x1871606E0")]
		public CHJMOQZTAAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x715FB20", Offset = "0x715E320", VA = "0x18715FB20", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KHR_draco_mesh_compression : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Dictionary<string, int> attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public ASFDPWTHLOR bufferView;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x716F1F0", Offset = "0x716D9F0", VA = "0x18716F1F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x716F130", Offset = "0x716D930", VA = "0x18716F130", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x716F240", Offset = "0x716DA40", VA = "0x18716F240")]
		public KHR_draco_mesh_compression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class YBKFSHCGZDQ : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class WSROETRUXZR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public JsonReader SMROOBILXEY;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public WSROETRUXZR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7175CD0", Offset = "0x71744D0", VA = "0x187175CD0")]
			internal int CCVXQDNGJPA()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x71760A0", Offset = "0x71748A0", VA = "0x1871760A0")]
		public YBKFSHCGZDQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7175E90", Offset = "0x7174690", VA = "0x187175E90", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class KHR_materials_anisotropy : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float anisotropyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public QIKLJPGCIIC anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x716F340", Offset = "0x716DB40", VA = "0x18716F340", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x716F2C0", Offset = "0x716DAC0", VA = "0x18716F2C0", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public KHR_materials_anisotropy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class ACJQAXNSGFH : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x715BA50", Offset = "0x715A250", VA = "0x18715BA50")]
		public ACJQAXNSGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x715B8A0", Offset = "0x715A0A0", VA = "0x18715B8A0", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class KHR_materials_clearcoat : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public QIKLJPGCIIC clearcoatTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public QIKLJPGCIIC clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public QIKLJPGCIIC clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x716F5F0", Offset = "0x716DDF0", VA = "0x18716F5F0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x716F550", Offset = "0x716DD50", VA = "0x18716F550", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public KHR_materials_clearcoat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ARBQQKHTHXF : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x715BFD0", Offset = "0x715A7D0", VA = "0x18715BFD0")]
		public ARBQQKHTHXF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x715BD50", Offset = "0x715A550", VA = "0x18715BD50", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHR_materials_dispersion : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float dispersion;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x716F950", Offset = "0x716E150", VA = "0x18716F950", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x716F8E0", Offset = "0x716E0E0", VA = "0x18716F8E0", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public KHR_materials_dispersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class UKUNMKIVIBJ : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7175360", Offset = "0x7173B60", VA = "0x187175360")]
		public UKUNMKIVIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7175290", Offset = "0x7173A90", VA = "0x187175290", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class KHR_materials_emissive_strength : VHZUCXUIOXF, FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float FJILJFRIABH;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x716FCA0", Offset = "0x716E4A0", VA = "0x18716FCA0")]
		public KHR_materials_emissive_strength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x716FC30", Offset = "0x716E430", VA = "0x18716FC30")]
		public KHR_materials_emissive_strength(KHR_materials_emissive_strength ext, LAUAUTWBLDQ root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x716FA70", Offset = "0x716E270", VA = "0x18716FA70", Slot = "6")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x716FB10", Offset = "0x716E310", VA = "0x18716FB10", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class TVNRJAYCDFC : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x71751D0", Offset = "0x71739D0", VA = "0x1871751D0")]
		public TVNRJAYCDFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x71750D0", Offset = "0x71738D0", VA = "0x1871750D0", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class KHR_materials_ior : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float ior;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x716FD50", Offset = "0x716E550", VA = "0x18716FD50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x716FCF0", Offset = "0x716E4F0", VA = "0x18716FCF0", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x716FEA0", Offset = "0x716E6A0", VA = "0x18716FEA0")]
		public KHR_materials_ior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class EMMMZIEGFNB : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7162EF0", Offset = "0x71616F0", VA = "0x187162EF0")]
		public EMMMZIEGFNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7162E20", Offset = "0x7161620", VA = "0x187162E20", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class KHR_materials_iridescence : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float iridescenceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public QIKLJPGCIIC iridescenceTexture;

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
		public QIKLJPGCIIC iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x716FF50", Offset = "0x716E750", VA = "0x18716FF50", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x716FEB0", Offset = "0x716E6B0", VA = "0x18716FEB0", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7170310", Offset = "0x716EB10", VA = "0x187170310")]
		public KHR_materials_iridescence()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class CTIWFONROEV : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7162980", Offset = "0x7161180", VA = "0x187162980")]
		public CTIWFONROEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7162690", Offset = "0x7160E90", VA = "0x187162690", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class IVTQZXHXVWA : FSIGLUSVGTB
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GLTF.Math.Vector3 TRTFTIAUKMQ;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly double GFDVRGZEOLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLTF.Math.Color HECMEGTEWZS;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GLTF.Math.Color SYKPPUKAVTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public QIKLJPGCIIC XBVMVONSSBY;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly QIKLJPGCIIC LLCDLDFLDEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GLTF.Math.Vector3 WUXGQLLOUZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public double REREUHJCXOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public QIKLJPGCIIC JPIFQZFKSDZ;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly QIKLJPGCIIC UTIZUJOKSOH;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x716C4F0", Offset = "0x716ACF0", VA = "0x18716C4F0")]
		public IVTQZXHXVWA(GLTF.Math.Color a, QIKLJPGCIIC b, GLTF.Math.Vector3 c, double d, QIKLJPGCIIC e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x716BBE0", Offset = "0x716A3E0", VA = "0x18716BBE0", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x716BD90", Offset = "0x716A590", VA = "0x18716BD90", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class YHBNTXILVCW : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7176440", Offset = "0x7174C40", VA = "0x187176440")]
		public YHBNTXILVCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x71760F0", Offset = "0x71748F0", VA = "0x1871760F0", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KHR_materials_sheen : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GLTF.Math.Color sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public QIKLJPGCIIC sheenColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public QIKLJPGCIIC sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7170400", Offset = "0x716EC00", VA = "0x187170400", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7170330", Offset = "0x716EB30", VA = "0x187170330", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7170910", Offset = "0x716F110", VA = "0x187170910")]
		public KHR_materials_sheen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class AFZYQLJPQXK : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x715BD00", Offset = "0x715A500", VA = "0x18715BD00")]
		public AFZYQLJPQXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x715BAA0", Offset = "0x715A2A0", VA = "0x18715BAA0", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KHR_materials_specular : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public QIKLJPGCIIC specularTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GLTF.Math.Color specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public QIKLJPGCIIC specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7170A40", Offset = "0x716F240", VA = "0x187170A40", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7170970", Offset = "0x716F170", VA = "0x187170970", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7170F50", Offset = "0x716F750", VA = "0x187170F50")]
		public KHR_materials_specular()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class KMNGXQCQYAQ : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x71721B0", Offset = "0x71709B0", VA = "0x1871721B0")]
		public KMNGXQCQYAQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7171F40", Offset = "0x7170740", VA = "0x187171F40", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KHR_materials_transmission : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public QIKLJPGCIIC transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7171040", Offset = "0x716F840", VA = "0x187171040", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7170FC0", Offset = "0x716F7C0", VA = "0x187170FC0", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public KHR_materials_transmission()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class CRHDHTBVHIB : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7162640", Offset = "0x7160E40", VA = "0x187162640")]
		public CRHDHTBVHIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7162500", Offset = "0x7160D00", VA = "0x187162500", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class HJINYJVIRZE : VHZUCXUIOXF, FSIGLUSVGTB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x716BA20", Offset = "0x716A220", VA = "0x18716BA20")]
		public HJINYJVIRZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x716B9B0", Offset = "0x716A1B0", VA = "0x18716B9B0")]
		public HJINYJVIRZE(HJINYJVIRZE a, LAUAUTWBLDQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x716B7B0", Offset = "0x7169FB0", VA = "0x18716B7B0", Slot = "6")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x716B920", Offset = "0x716A120", VA = "0x18716B920", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x716B850", Offset = "0x716A050", VA = "0x18716B850", Slot = "5")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class EDVKBNKJFXC : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7162DD0", Offset = "0x71615D0", VA = "0x187162DD0")]
		public EDVKBNKJFXC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7162D50", Offset = "0x7161550", VA = "0x187162D50", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KHR_materials_volume : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public QIKLJPGCIIC thicknessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float attenuationDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GLTF.Math.Color attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly GLTF.Math.Color COLOR_DEFAULT;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7171260", Offset = "0x716FA60", VA = "0x187171260", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x71711D0", Offset = "0x716F9D0", VA = "0x1871711D0", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7171790", Offset = "0x716FF90", VA = "0x187171790")]
		public KHR_materials_volume()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class KPSISKNAWIX : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7172410", Offset = "0x7170C10", VA = "0x187172410")]
		public KPSISKNAWIX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7172200", Offset = "0x7170A00", VA = "0x187172200", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KHR_node_hoverability : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool hoverable;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7171810", Offset = "0x7170010", VA = "0x187171810", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x71717B0", Offset = "0x716FFB0", VA = "0x1871717B0", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xF7F2F0", Offset = "0xF7DAF0", VA = "0x180F7F2F0")]
		public KHR_node_hoverability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class JGWEVKRHKHT : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x716C6C0", Offset = "0x716AEC0", VA = "0x18716C6C0")]
		public JGWEVKRHKHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x716C5E0", Offset = "0x716ADE0", VA = "0x18716C5E0", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KHR_node_selectability : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool selectable;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7171980", Offset = "0x7170180", VA = "0x187171980", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7171920", Offset = "0x7170120", VA = "0x187171920", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xF7F2F0", Offset = "0xF7DAF0", VA = "0x180F7F2F0")]
		public KHR_node_selectability()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class ZZSAKSSMRQH : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7176F00", Offset = "0x7175700", VA = "0x187176F00")]
		public ZZSAKSSMRQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7176E20", Offset = "0x7175620", VA = "0x187176E20", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class KHR_node_visibility : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7171AF0", Offset = "0x71702F0", VA = "0x187171AF0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7171A90", Offset = "0x7170290", VA = "0x187171A90", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xF7F2F0", Offset = "0xF7DAF0", VA = "0x180F7F2F0")]
		public KHR_node_visibility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class GPAXKUTMGPP : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7167DE0", Offset = "0x71665E0", VA = "0x187167DE0")]
		public GPAXKUTMGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7167D00", Offset = "0x7166500", VA = "0x187167D00", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class KHR_texture_basisu : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public EMIQBIZRTNX source;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public KHR_texture_basisu(EMIQBIZRTNX source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7171C00", Offset = "0x7170400", VA = "0x187171C00", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7171C70", Offset = "0x7170470", VA = "0x187171C70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class WFLFCYPPEXB : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7175BD0", Offset = "0x71743D0", VA = "0x187175BD0")]
		public WFLFCYPPEXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7175A70", Offset = "0x7174270", VA = "0x187175A70", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class YOJPSXZFXNS : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLTF.Math.Vector2 DBSVIGQRSKU;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GLTF.Math.Vector2 WNBOIEVTCRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public double SOURHICWKCZ;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly double EUSCXFWLSLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLTF.Math.Vector2 CEBXYJMWNDR;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GLTF.Math.Vector2 FDHITMCQMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int? HZJMGUZWJUV;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly int ZBICRNXKJRJ;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7176BC0", Offset = "0x71753C0", VA = "0x187176BC0")]
		public YOJPSXZFXNS(GLTF.Math.Vector2 a, double b, GLTF.Math.Vector2 c, int? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7176490", Offset = "0x7174C90", VA = "0x187176490", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7176570", Offset = "0x7174D70", VA = "0x187176570", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class JXGRTPVHZKG : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x716C9E0", Offset = "0x716B1E0", VA = "0x18716C9E0")]
		public JXGRTPVHZKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x716C710", Offset = "0x716AF10", VA = "0x18716C710", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class OBDJXUTZFLM : FSIGLUSVGTB
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public List<int> JKNNFUDIKLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public OBDJXUTZFLM(List<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7174020", Offset = "0x7172820", VA = "0x187174020", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ gltfRoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7174090", Offset = "0x7172890", VA = "0x187174090", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7174180", Offset = "0x7172980", VA = "0x187174180")]
		public List<double> UMLZOXOBGBI(LBKZHWCVPSD a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class YAAARSVUFAE : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7175E40", Offset = "0x7174640", VA = "0x187175E40")]
		public YAAARSVUFAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7175D40", Offset = "0x7174540", VA = "0x187175D40", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class FMPFSVIHKLK : GDKFMQAPOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public ASFDPWTHLOR HZHKBLSVYPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint MDZRPODBFUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GLTFComponentType SKEBFWYJVXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool USXVLVAUHVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint UHDSQPYTSJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLTFAccessorAttributeType QWAVKIDXYXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public List<double> ZZYJOVIPAQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public List<double> BTQQGTNFXGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AMHIBSODZXW LCGUATSIYPB;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7167C30", Offset = "0x7166430", VA = "0x187167C30")]
		public FMPFSVIHKLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7163E30", Offset = "0x7162630", VA = "0x187163E30")]
		public static FMPFSVIHKLK Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7166E70", Offset = "0x7165670", VA = "0x187166E70", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7166210", Offset = "0x7164A10", VA = "0x187166210")]
		private unsafe static sbyte POFTURFNGDD(void* a, uint b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x71663E0", Offset = "0x7164BE0", VA = "0x1871663E0")]
		private unsafe static float2 RJKDXMTXSGN(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7164AB0", Offset = "0x71632B0", VA = "0x187164AB0")]
		private unsafe static float3 HHEAKYQBHGM(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7167A00", Offset = "0x7166200", VA = "0x187167A00")]
		private unsafe static float4 YIAEUPSUYZJ(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7167A90", Offset = "0x7166290", VA = "0x187167A90")]
		private unsafe static float4x4 ZGUQZXQVDHV(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7166210", Offset = "0x7164A10", VA = "0x187166210")]
		private unsafe static byte RMYZGWELBYW(void* a, uint b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7163B40", Offset = "0x7162340", VA = "0x187163B40")]
		private unsafe static float2 CIFGKEHNACE(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7166970", Offset = "0x7165170", VA = "0x187166970")]
		private unsafe static float3 SSXHONQOLWV(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7163790", Offset = "0x7161F90", VA = "0x187163790")]
		private unsafe static float4 BOXPEKOSQHM(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7163C90", Offset = "0x7162490", VA = "0x187163C90")]
		private unsafe static float4x4 DUOIISRRSPI(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7165A70", Offset = "0x7164270", VA = "0x187165A70")]
		private unsafe static short MYXQKFGCQAX(void* a, uint b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7167A60", Offset = "0x7166260", VA = "0x187167A60")]
		private unsafe static float2 YOYBVMYHHYT(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7165BF0", Offset = "0x71643F0", VA = "0x187165BF0")]
		private unsafe static float3 NOWVWBSXVRE(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7165C40", Offset = "0x7164440", VA = "0x187165C40")]
		private unsafe static float4 OFPKSZYURQB(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7164910", Offset = "0x7163110", VA = "0x187164910")]
		private unsafe static float4x4 GVCUTMPAOAZ(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7165A70", Offset = "0x7164270", VA = "0x187165A70")]
		private unsafe static ushort OCVTKWVCDFM(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7165A40", Offset = "0x7164240", VA = "0x187165A40")]
		private unsafe static float2 MCYTQAEGSYQ(void* a, uint b, float c)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7163C40", Offset = "0x7162440", VA = "0x187163C40")]
		private unsafe static float3 DLEXCNMOYLH(void* a, uint b, float c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7165790", Offset = "0x7163F90", VA = "0x187165790")]
		private unsafe static float4x4 KSZTDFDNPWW(void* a, uint b, float c)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x71648B0", Offset = "0x71630B0", VA = "0x1871648B0")]
		private unsafe static float4 FYFSSSZOMSW(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7164290", Offset = "0x7162A90", VA = "0x187164290")]
		private unsafe static uint EKOZUMPPMJB(void* a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7165A70", Offset = "0x7164270", VA = "0x187165A70")]
		private unsafe static ushort MFEFFQLOKMK(void* a, uint b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x71679F0", Offset = "0x71661F0", VA = "0x1871679F0")]
		private unsafe static float XXRDCTIJCIX(void* a, uint b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7166950", Offset = "0x7165150", VA = "0x187166950")]
		private unsafe static float2 SDMLZVIUMYH(void* a, uint b)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7164F70", Offset = "0x7163770", VA = "0x187164F70")]
		private unsafe static float3 IHUTNJHXOMC(void* a, uint b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x71642D0", Offset = "0x7162AD0", VA = "0x1871642D0")]
		private unsafe static float4 FUTXXDUYAEN(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7166540", Offset = "0x7164D40", VA = "0x187166540")]
		private unsafe static float4x4 RQIUOAAOQDT(void* a, uint b)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x71642D0", Offset = "0x7162AD0", VA = "0x1871642D0")]
		private unsafe static float4 FKAMHXIPJQE(void* a, uint b)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x71642A0", Offset = "0x7162AA0", VA = "0x1871642A0")]
		private unsafe static float4 FKAMHXIPJQE(void* a, uint b, float c)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x71677C0", Offset = "0x7165FC0", VA = "0x1871677C0")]
		public static float3[] WWQDKAGMORX(FMPFSVIHKLK a, NumericArray b, NativeArray<byte> c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7164F90", Offset = "0x7163790", VA = "0x187164F90")]
		public static float3[] IPHVEKJXQYB(FMPFSVIHKLK a, NumericArray b, NativeArray<byte> c, float3 d, uint e = 0u, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x71667E0", Offset = "0x7164FE0", VA = "0x1871667E0")]
		public static uint[] SANFKMWSMSU(FMPFSVIHKLK a, NumericArray b, NativeArray<byte> c, uint d = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7166D50", Offset = "0x7165550", VA = "0x187166D50")]
		internal static void UGHNJLACHIB(GLTFComponentType a, [Out] uint b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x71632B0", Offset = "0x7161AB0", VA = "0x1871632B0")]
		public uint[] AHLCBVBVQJC(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7165520", Offset = "0x7163D20", VA = "0x187165520")]
		public float[] JDAVJGZCOGU(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7163500", Offset = "0x7161D00", VA = "0x187163500")]
		public float2[] BKXRKNGSNNS(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7164CC0", Offset = "0x71634C0", VA = "0x187164CC0")]
		public float2[] IGRQFQREFHM(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x71652A0", Offset = "0x7163AA0", VA = "0x1871652A0")]
		public float3[] IRQAUAWVDGN(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x71637F0", Offset = "0x7161FF0", VA = "0x1871637F0")]
		public float3[] BXVXLKDJKOB(NumericArray a, NativeArray<byte> b, float3 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7166570", Offset = "0x7164D70", VA = "0x187166570")]
		public float4[] RRYDCAVXIXI(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7167450", Offset = "0x7165C50", VA = "0x187167450")]
		public float4[] WHGCAPUEEPQ(NumericArray a, NativeArray<byte> b, float4 c, uint d = 0u, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x71669C0", Offset = "0x71651C0", VA = "0x1871669C0")]
		public float4[] SXULCKGJYIX(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7165CA0", Offset = "0x71644A0", VA = "0x187165CA0")]
		public float3[] PAQEYNXILZM(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7165930", Offset = "0x7164130", VA = "0x187165930")]
		public float3[] LDJAINNQHDD(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7163B70", Offset = "0x7162370", VA = "0x187163B70")]
		public float4[] DDNTURNLIER(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7166390", Offset = "0x7164B90", VA = "0x187166390")]
		public uint[] QWJSOCZEWUY(NumericArray a, NativeArray<byte> b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7164300", Offset = "0x7162B00", VA = "0x187164300")]
		public float4x4[] FVEXDFPMBNZ(NumericArray a, NativeArray<byte> b, uint c = 0u, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7166050", Offset = "0x7164850", VA = "0x187166050")]
		private unsafe static float4 PJUADPLIVZR(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7165ED0", Offset = "0x71646D0", VA = "0x187165ED0")]
		private unsafe static float4 PJUADPLIVZR(void* a, uint b, GLTFComponentType c, float d, float e)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7165A80", Offset = "0x7164280", VA = "0x187165A80")]
		private unsafe static float4x4 MSKUMFEERUM(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7164B00", Offset = "0x7163300", VA = "0x187164B00")]
		private unsafe static float4 HNTLTFVUERC(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7166220", Offset = "0x7164A20", VA = "0x187166220")]
		private unsafe static float3 QVDVDKUCECP(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7166410", Offset = "0x7164C10", VA = "0x187166410")]
		private unsafe static float2 RPSXIDQFGGK(void* a, uint b, GLTFComponentType c, float d)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7165DB0", Offset = "0x71645B0", VA = "0x187165DB0")]
		private unsafe static uint PBRTUCUUMTR(void* a, uint b, GLTFComponentType c)
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
	public static class ZDXYARWLEUR
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x718C620", Offset = "0x718AE20", VA = "0x18718C620")]
		public static int DKTGMNLGIND(this GLTFAccessorAttributeType a)
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
	public class AMHIBSODZXW : VHZUCXUIOXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int UHDSQPYTSJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public JBSNAEYTZYJ ZFUKKGNXURW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public XDDIAZELEKS LJOAJNOFVKB;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7178A90", Offset = "0x7177290", VA = "0x187178A90")]
		public AMHIBSODZXW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7178690", Offset = "0x7176E90", VA = "0x187178690")]
		public static AMHIBSODZXW Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7178960", Offset = "0x7177160", VA = "0x187178960", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class JBSNAEYTZYJ : VHZUCXUIOXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public ASFDPWTHLOR HZHKBLSVYPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int MDZRPODBFUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLTFComponentType SKEBFWYJVXE;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x717D7E0", Offset = "0x717BFE0", VA = "0x18717D7E0")]
		public JBSNAEYTZYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x717D3C0", Offset = "0x717BBC0", VA = "0x18717D3C0")]
		public static JBSNAEYTZYJ Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x717D6A0", Offset = "0x717BEA0", VA = "0x18717D6A0", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class XDDIAZELEKS : VHZUCXUIOXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public ASFDPWTHLOR HZHKBLSVYPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int MDZRPODBFUS;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x718B680", Offset = "0x7189E80", VA = "0x18718B680")]
		public XDDIAZELEKS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x718B300", Offset = "0x7189B00", VA = "0x18718B300")]
		public static XDDIAZELEKS Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x718B580", Offset = "0x7189D80", VA = "0x18718B580", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class XTLGJPHBRXI : VHZUCXUIOXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public HQLXKTJDUCI CVQXDGJZNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public VPDOWTOVCZB VXZCEQRCWXA;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x718BD60", Offset = "0x718A560", VA = "0x18718BD60")]
		public XTLGJPHBRXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x718BA70", Offset = "0x718A270", VA = "0x18718BA70")]
		public static XTLGJPHBRXI Deserialize(LAUAUTWBLDQ root, JsonReader reader, ABLRAUSQYOY anim)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x718BC60", Offset = "0x718A460", VA = "0x18718BC60", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class VPDOWTOVCZB : VHZUCXUIOXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public KMXGEKPSBZI LBKZHWCVPSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string QCXJTZYZGPW;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x718AF00", Offset = "0x7189700", VA = "0x18718AF00")]
		public static VPDOWTOVCZB Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x718B280", Offset = "0x7189A80", VA = "0x18718B280")]
		public VPDOWTOVCZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x718B160", Offset = "0x7189960", VA = "0x18718B160", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
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
	public class JMKSXGAKABW
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate float[] ImportValuesConversion(JMKSXGAKABW data, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string[] WYXOQEPRBWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Type CMEIWNLTOBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int[] OONIYJVYIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ImportValuesConversion ZVWHOFMKLWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string FKTQZXWMOQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string PEUYMDZHNVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public QOTPRWEVTIC RZGXCCBPYMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public string RZATJJZAEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string ANLDWBBXXZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public QOTPRWEVTIC YEDNMNZVSHB;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x717D830", Offset = "0x717C030", VA = "0x18717D830")]
		public JMKSXGAKABW()
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
	public class SYIUJCAPALL : VHZUCXUIOXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public LDTJWYXTGAV KOEKVMHDVEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public InterpolationType LYSEUSKPREX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public LDTJWYXTGAV GWYHPHYCXZA;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x71866B0", Offset = "0x7184EB0", VA = "0x1871866B0")]
		public SYIUJCAPALL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7186320", Offset = "0x7184B20", VA = "0x187186320")]
		public static SYIUJCAPALL Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7186540", Offset = "0x7184D40", VA = "0x187186540", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class UZYYUDAXIKR : VHZUCXUIOXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string SDCCVYIIHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string OZVAAIDWKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string GIOWEMQBGCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string KNQMHMIXAZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Dictionary<string, JToken> JPPXKFSVKCL;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7189110", Offset = "0x7187910", VA = "0x187189110")]
		public UZYYUDAXIKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7188620", Offset = "0x7186E20", VA = "0x187188620")]
		public static UZYYUDAXIKR Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7188CF0", Offset = "0x71874F0", VA = "0x187188CF0", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7188CE0", Offset = "0x71874E0", VA = "0x187188CE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7188940", Offset = "0x7187140", VA = "0x187188940")]
		public string KGDEWKBNWMP(bool a)
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
	public class HZHKBLSVYPO : GDKFMQAPOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public XEPAWIDVNQI HXZMNHCFLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint MDZRPODBFUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint ZSASTNQQBSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint CRGMUZCVLOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BufferViewTarget VXZCEQRCWXA;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7178C70", Offset = "0x7177470", VA = "0x187178C70")]
		public HZHKBLSVYPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x717C750", Offset = "0x717AF50", VA = "0x18717C750")]
		public static HZHKBLSVYPO Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x717CA00", Offset = "0x717B200", VA = "0x18717CA00", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class UEQGMQQENXQ : VHZUCXUIOXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public double AKVNGUNDRIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public double QRRGMQBGGMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public double AIXRGPUXPYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public double QKDGXRSDPTD;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7187CB0", Offset = "0x71864B0", VA = "0x187187CB0")]
		public UEQGMQQENXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x71877C0", Offset = "0x7185FC0", VA = "0x1871877C0")]
		public static UEQGMQQENXQ Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7187B40", Offset = "0x7186340", VA = "0x187187B40", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ILHJQWFNETA : VHZUCXUIOXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public double XGHTBXVGQOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public double WFAEGCJSZXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public double AIXRGPUXPYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public double QKDGXRSDPTD;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x717D110", Offset = "0x717B910", VA = "0x18717D110")]
		public ILHJQWFNETA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x717CC10", Offset = "0x717B410", VA = "0x18717CC10")]
		public static ILHJQWFNETA Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x717CF80", Offset = "0x717B780", VA = "0x18717CF80", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ABLRAUSQYOY : GDKFMQAPOKE
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class WSROETRUXZR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public LAUAUTWBLDQ GCIIEAQCVVB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public JsonReader SMROOBILXEY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public ABLRAUSQYOY KSVJLFUNZTZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<XTLGJPHBRXI> HHJKLVTYFOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<SYIUJCAPALL> HHORJCNVOZT;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public WSROETRUXZR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x718B2D0", Offset = "0x7189AD0", VA = "0x18718B2D0")]
			internal XTLGJPHBRXI CCVXQDNGJPA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x718B2F0", Offset = "0x7189AF0", VA = "0x18718B2F0")]
			internal SYIUJCAPALL CDBENKHDTAJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<XTLGJPHBRXI> NQTOOIWEJWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<SYIUJCAPALL> URBDSBTARTM;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7176F50", Offset = "0x7175750", VA = "0x187176F50")]
		public static ABLRAUSQYOY Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x71776B0", Offset = "0x7175EB0", VA = "0x1871776B0")]
		public ABLRAUSQYOY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7177310", Offset = "0x7175B10", VA = "0x187177310", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class BUEQRFUUNPW : GDKFMQAPOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string WNIIFKZHAYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint ZSASTNQQBSJ;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7178C70", Offset = "0x7177470", VA = "0x187178C70")]
		public BUEQRFUUNPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x717A870", Offset = "0x7179070", VA = "0x18717A870")]
		public static BUEQRFUUNPW Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x717AA40", Offset = "0x7179240", VA = "0x18717AA40", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class LYDQADIBMPH : GDKFMQAPOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public UEQGMQQENXQ CBSDEMYFXXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public ILHJQWFNETA PGQFUZIPKQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CameraType QWAVKIDXYXV;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x7178C70", Offset = "0x7177470", VA = "0x187178C70")]
		public LYDQADIBMPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7182ED0", Offset = "0x71816D0", VA = "0x187182ED0")]
		public static LYDQADIBMPH Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x71830A0", Offset = "0x71818A0", VA = "0x1871830A0", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
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
	public class GDKFMQAPOKE : VHZUCXUIOXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string TYWDEKEDEIY;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7178C70", Offset = "0x7177470", VA = "0x187178C70")]
		public GDKFMQAPOKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x717B870", Offset = "0x717A070", VA = "0x18717B870")]
		public GDKFMQAPOKE(GDKFMQAPOKE a, LAUAUTWBLDQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x717B6F0", Offset = "0x7179EF0", VA = "0x18717B6F0")]
		public new void EURAFSZFAHA(LAUAUTWBLDQ a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x717B7E0", Offset = "0x7179FE0", VA = "0x18717B7E0", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class PFBVESDYJJS<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int VXYCUIZXFBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public LAUAUTWBLDQ PUSUXZYIEUP;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		protected PFBVESDYJJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0E40", Offset = "0x5AAF640", VA = "0x185AB0E40")]
		public PFBVESDYJJS(PFBVESDYJJS<a> a, LAUAUTWBLDQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0E10", Offset = "0x5AAF610", VA = "0x185AB0E10")]
		public void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class LDTJWYXTGAV : PFBVESDYJJS<FMPFSVIHKLK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override FMPFSVIHKLK Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x7182BB0", Offset = "0x71813B0", VA = "0x187182BB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7182B10", Offset = "0x7181310", VA = "0x187182B10")]
		public LDTJWYXTGAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7182B50", Offset = "0x7181350", VA = "0x187182B50")]
		public LDTJWYXTGAV(LDTJWYXTGAV a, LAUAUTWBLDQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7182A30", Offset = "0x7181230", VA = "0x187182A30")]
		public static LDTJWYXTGAV Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class XEPAWIDVNQI : PFBVESDYJJS<BUEQRFUUNPW>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override BUEQRFUUNPW Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x718B7F0", Offset = "0x7189FF0", VA = "0x18718B7F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x718B7B0", Offset = "0x7189FB0", VA = "0x18718B7B0")]
		public XEPAWIDVNQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x718B6D0", Offset = "0x7189ED0", VA = "0x18718B6D0")]
		public static XEPAWIDVNQI Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ASFDPWTHLOR : PFBVESDYJJS<HZHKBLSVYPO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override HZHKBLSVYPO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x7178C00", Offset = "0x7177400", VA = "0x187178C00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7178BC0", Offset = "0x71773C0", VA = "0x187178BC0")]
		public ASFDPWTHLOR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7178AE0", Offset = "0x71772E0", VA = "0x187178AE0")]
		public static ASFDPWTHLOR Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class BMQKHYSLCUJ : PFBVESDYJJS<LYDQADIBMPH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override LYDQADIBMPH Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x717A810", Offset = "0x7179010", VA = "0x18717A810", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x717A7D0", Offset = "0x7178FD0", VA = "0x18717A7D0")]
		public BMQKHYSLCUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x717A6F0", Offset = "0x7178EF0", VA = "0x18717A6F0")]
		public static BMQKHYSLCUJ Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class EMIQBIZRTNX : PFBVESDYJJS<PJTWCXISEQL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override PJTWCXISEQL Value
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x717B690", Offset = "0x7179E90", VA = "0x18717B690", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x717B650", Offset = "0x7179E50", VA = "0x18717B650")]
		public EMIQBIZRTNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x717B570", Offset = "0x7179D70", VA = "0x18717B570")]
		public static EMIQBIZRTNX Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class ZZQQYECRUCT : PFBVESDYJJS<QIIWOEUREOX>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override QIIWOEUREOX Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x718CD30", Offset = "0x718B530", VA = "0x18718CD30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x718CC90", Offset = "0x718B490", VA = "0x18718CC90")]
		public ZZQQYECRUCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x718CCD0", Offset = "0x718B4D0", VA = "0x18718CCD0")]
		public ZZQQYECRUCT(ZZQQYECRUCT a, LAUAUTWBLDQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x718CBB0", Offset = "0x718B3B0", VA = "0x18718CBB0")]
		public static ZZQQYECRUCT Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class QSPKQMWNOVR : PFBVESDYJJS<HYBKYKMUQAP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override HYBKYKMUQAP Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x7185EB0", Offset = "0x71846B0", VA = "0x187185EB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7185E70", Offset = "0x7184670", VA = "0x187185E70")]
		public QSPKQMWNOVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7185D90", Offset = "0x7184590", VA = "0x187185D90")]
		public static QSPKQMWNOVR Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class KMXGEKPSBZI : PFBVESDYJJS<LBKZHWCVPSD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override LBKZHWCVPSD Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x717E8A0", Offset = "0x717D0A0", VA = "0x18717E8A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x717E860", Offset = "0x717D060", VA = "0x18717E860")]
		public KMXGEKPSBZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x717E510", Offset = "0x717CD10", VA = "0x18717E510")]
		public static KMXGEKPSBZI Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x717E5F0", Offset = "0x717CDF0", VA = "0x18717E5F0")]
		public static List<KMXGEKPSBZI> WESUIKQPLWH(LAUAUTWBLDQ a, JsonReader b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class ZAVBASFKYMU : PFBVESDYJJS<Sampler>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Sampler Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x718C5C0", Offset = "0x718ADC0", VA = "0x18718C5C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x718C580", Offset = "0x718AD80", VA = "0x18718C580")]
		public ZAVBASFKYMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x718C4A0", Offset = "0x718ACA0", VA = "0x18718C4A0")]
		public static ZAVBASFKYMU Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class HQLXKTJDUCI : PFBVESDYJJS<SYIUJCAPALL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public ABLRAUSQYOY ABLRAUSQYOY;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override SYIUJCAPALL Value
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x717BA30", Offset = "0x717A230", VA = "0x18717BA30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x717B9F0", Offset = "0x717A1F0", VA = "0x18717B9F0")]
		public HQLXKTJDUCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x717B8F0", Offset = "0x717A0F0", VA = "0x18717B8F0")]
		public static HQLXKTJDUCI Deserialize(LAUAUTWBLDQ root, ABLRAUSQYOY anim, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class EAAGPIHFNHK : PFBVESDYJJS<NIMRDGNLJOO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override NIMRDGNLJOO Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x717B510", Offset = "0x7179D10", VA = "0x18717B510", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x717B4D0", Offset = "0x7179CD0", VA = "0x18717B4D0")]
		public EAAGPIHFNHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x717B3F0", Offset = "0x7179BF0", VA = "0x18717B3F0")]
		public static EAAGPIHFNHK Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class XKDPMVLVWRN : PFBVESDYJJS<JUEAKBKICPM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override JUEAKBKICPM Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x718BA10", Offset = "0x718A210", VA = "0x18718BA10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x718B9D0", Offset = "0x718A1D0", VA = "0x18718B9D0")]
		public XKDPMVLVWRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x718B8F0", Offset = "0x718A0F0", VA = "0x18718B8F0")]
		public static XKDPMVLVWRN Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class NDXVFODIJBJ : PFBVESDYJJS<YECTCRBZHAV>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override YECTCRBZHAV Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x71845B0", Offset = "0x7182DB0", VA = "0x1871845B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7184570", Offset = "0x7182D70", VA = "0x187184570")]
		public NDXVFODIJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7184510", Offset = "0x7182D10", VA = "0x187184510")]
		public NDXVFODIJBJ(NDXVFODIJBJ a, LAUAUTWBLDQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7184430", Offset = "0x7182C30", VA = "0x187184430")]
		public static NDXVFODIJBJ Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class XFXGBCPZAYI : PFBVESDYJJS<BUIOENRKGYC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override BUIOENRKGYC Value
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x718B890", Offset = "0x718A090", VA = "0x18718B890", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x718B850", Offset = "0x718A050", VA = "0x18718B850")]
		public XFXGBCPZAYI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class PJTWCXISEQL : GDKFMQAPOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string WNIIFKZHAYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string QKWKJRFIOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public ASFDPWTHLOR HZHKBLSVYPO;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7178C70", Offset = "0x7177470", VA = "0x187178C70")]
		public PJTWCXISEQL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7184AB0", Offset = "0x71832B0", VA = "0x187184AB0")]
		public static PJTWCXISEQL Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7184CF0", Offset = "0x71834F0", VA = "0x187184CF0", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class QIIWOEUREOX : GDKFMQAPOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public TCLFOSHIVHE TCLFOSHIVHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public DMEQDXSPZZZ CMTXZXMPNWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ROLLCZTRBRF HTOXELMWZDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public YDEMZBFEQRZ HNJMPSGGJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public QIKLJPGCIIC TEJEEHIZIJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLTF.Math.Color YHOWZGUCJDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AlphaMode TDQDEKIYTGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public double JDDPNDQYTGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool ODCKOGHRIFJ;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7185830", Offset = "0x7184030", VA = "0x187185830")]
		public QIIWOEUREOX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7184EC0", Offset = "0x71836C0", VA = "0x187184EC0")]
		public static QIIWOEUREOX Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x71853D0", Offset = "0x7183BD0", VA = "0x1871853D0", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
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
	public class HYBKYKMUQAP : GDKFMQAPOKE
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class TPKTMYRKYMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public LAUAUTWBLDQ GCIIEAQCVVB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JsonReader SMROOBILXEY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public Func<BGBASGRQLOL> HHJKLVTYFOK;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public TPKTMYRKYMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x71872A0", Offset = "0x7185AA0", VA = "0x1871872A0")]
			internal BGBASGRQLOL CCVXQDNGJPA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<BGBASGRQLOL> KQIRWZWCWUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<double> PJYGDYAMSDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<string> FZMROPVKASG;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7178C70", Offset = "0x7177470", VA = "0x187178C70")]
		public HYBKYKMUQAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x717BDE0", Offset = "0x717A5E0", VA = "0x18717BDE0")]
		public static HYBKYKMUQAP Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x717C1A0", Offset = "0x717A9A0", VA = "0x18717C1A0", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class VHZUCXUIOXF
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static Dictionary<string, ETPFOIZEJRM> PAAFFFHCJUG;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static CIADOXLNUEJ YXZTDMQGEWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Dictionary<string, FSIGLUSVGTB> PMAAAHHWXZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JToken PQWVFIBOXHK;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x71891B0", Offset = "0x71879B0", VA = "0x1871891B0")]
		public static ETPFOIZEJRM AKTYCBUXXRH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7189340", Offset = "0x7187B40", VA = "0x187189340")]
		public static FSIGLUSVGTB DDIEDTBDJDL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public VHZUCXUIOXF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x718AC10", Offset = "0x7189410", VA = "0x18718AC10")]
		public VHZUCXUIOXF(VHZUCXUIOXF a, [Optional] LAUAUTWBLDQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x71894F0", Offset = "0x7187CF0", VA = "0x1871894F0")]
		public void EURAFSZFAHA(LAUAUTWBLDQ a, JsonReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x718A2A0", Offset = "0x7188AA0", VA = "0x18718A2A0")]
		public void WJRPLNNTKFV(string a, FSIGLUSVGTB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x71897A0", Offset = "0x7187FA0", VA = "0x1871897A0")]
		private void HUKVIJXLCZX(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7189430", Offset = "0x7187C30", VA = "0x187189430")]
		private void ETRWNNTLUNN(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7189890", Offset = "0x7188090", VA = "0x187189890")]
		private void NDBDLFCRGWB(JsonReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7189CD0", Offset = "0x71884D0", VA = "0x187189CD0")]
		internal static Dictionary<string, FSIGLUSVGTB> VQIFNLLRLHC(LAUAUTWBLDQ a, JsonReader b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7189950", Offset = "0x7188150", VA = "0x187189950", Slot = "4")]
		public virtual void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class LAUAUTWBLDQ : VHZUCXUIOXF
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class NAFFDINEDQF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public LAUAUTWBLDQ GCIIEAQCVVB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JsonTextReader LJLNPHBGFRU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<FMPFSVIHKLK> HHJKLVTYFOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<ABLRAUSQYOY> HHORJCNVOZT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<BUEQRFUUNPW> HGYWRIGDMRS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<HZHKBLSVYPO> HHEDOPAAWDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<LYDQADIBMPH> HGOIWUSITVA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<PJTWCXISEQL> HGTPUBMGDGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<QIIWOEUREOX> HGDVCHEOAYI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<HYBKYKMUQAP> HGJBZNYLKJR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<LBKZHWCVPSD> HFTHHTQTIBQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<Sampler> HFYOFAKQRMZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<NIMRDGNLJOO> HUZSJHMQVTF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<JUEAKBKICPM> HUULMASTMHW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<YECTCRBZHAV> HVKGDVALOPX;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public NAFFDINEDQF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7184000", Offset = "0x7182800", VA = "0x187184000")]
			internal FMPFSVIHKLK CCVXQDNGJPA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7184010", Offset = "0x7182810", VA = "0x187184010")]
			internal ABLRAUSQYOY CDBENKHDTAJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x7183FE0", Offset = "0x71827E0", VA = "0x187183FE0")]
			internal BUEQRFUUNPW CCLJVPZLQSI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7183FF0", Offset = "0x71827F0", VA = "0x187183FF0")]
			internal HZHKBLSVYPO CCQQSWTJADR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x7183FC0", Offset = "0x71827C0", VA = "0x187183FC0")]
			internal LYDQADIBMPH CCAWBCLQXVQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7183FD0", Offset = "0x71827D0", VA = "0x187183FD0")]
			internal PJTWCXISEQL CCGCYJFOHGZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7183FA0", Offset = "0x71827A0", VA = "0x187183FA0")]
			internal QIIWOEUREOX CBQIGOXWEYY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7183FB0", Offset = "0x71827B0", VA = "0x187183FB0")]
			internal HYBKYKMUQAP CBVPDVRTOKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x7183F80", Offset = "0x7182780", VA = "0x187183F80")]
			internal LBKZHWCVPSD CBFUMBKBMCG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7183F90", Offset = "0x7182790", VA = "0x187183F90")]
			internal Sampler CBLBJIDYVNP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7184030", Offset = "0x7182830", VA = "0x187184030")]
			internal NIMRDGNLJOO PWPMGWEELCX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x7184020", Offset = "0x7182820", VA = "0x187184020")]
			internal JUEAKBKICPM PWKFJPKHBRO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x71841B0", Offset = "0x71829B0", VA = "0x1871841B0")]
			internal YECTCRBZHAV PXAABJRZDZP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CanBeNull]
		public List<string> NPGZVVYRBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CanBeNull]
		public List<string> DPNTXSEHAEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CanBeNull]
		public List<FMPFSVIHKLK> IIUDYMYIDUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CanBeNull]
		public List<ABLRAUSQYOY> WTWKBSGSVOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public UZYYUDAXIKR UZYYUDAXIKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CanBeNull]
		public List<BUEQRFUUNPW> KKLPCQQLATQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CanBeNull]
		public List<HZHKBLSVYPO> XZFXJRBXLXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CanBeNull]
		public List<LYDQADIBMPH> YJYXCLIMUMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CanBeNull]
		public List<PJTWCXISEQL> JHBTOKGWXMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CanBeNull]
		public List<QIIWOEUREOX> FSKWRQWYOXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CanBeNull]
		public List<HYBKYKMUQAP> JKGTASLMCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CanBeNull]
		public List<LBKZHWCVPSD> PADVTDSVLSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CanBeNull]
		public List<Sampler> URBDSBTARTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public EAAGPIHFNHK AEQLQSNYAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CanBeNull]
		public List<NIMRDGNLJOO> ZJGFDSWEIWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CanBeNull]
		public List<JUEAKBKICPM> XAXULTYUGUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CanBeNull]
		public List<YECTCRBZHAV> SNLAYSUIPOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CanBeNull]
		public List<BUIOENRKGYC> QVWWWGZDPGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool ZXJYTBKHQCO;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7181390", Offset = "0x717FB90", VA = "0x187181390")]
		public LAUAUTWBLDQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x717F750", Offset = "0x717DF50", VA = "0x18717F750")]
		public NIMRDGNLJOO LTDEWWMPXSW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x717E900", Offset = "0x717D100", VA = "0x18717E900")]
		public static LAUAUTWBLDQ Deserialize(TextReader textReader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x717F7F0", Offset = "0x717DFF0", VA = "0x18717F7F0")]
		public void VOPQGDPBGDJ(TextWriter a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class NIMRDGNLJOO : GDKFMQAPOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public List<KMXGEKPSBZI> PADVTDSVLSQ;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7178C70", Offset = "0x7177470", VA = "0x187178C70")]
		public NIMRDGNLJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7184610", Offset = "0x7182E10", VA = "0x187184610")]
		public static NIMRDGNLJOO Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7184790", Offset = "0x7182F90", VA = "0x187184790", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class YECTCRBZHAV : GDKFMQAPOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ZAVBASFKYMU CVQXDGJZNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public EMIQBIZRTNX ZIRLVQYXIOK;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7178C70", Offset = "0x7177470", VA = "0x187178C70")]
		public YECTCRBZHAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x718C160", Offset = "0x718A960", VA = "0x18718C160")]
		public static YECTCRBZHAV Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x718C330", Offset = "0x718AB30", VA = "0x18718C330", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class BEZEOUBAROK : BUIOENRKGYC
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7178C70", Offset = "0x7177470", VA = "0x187178C70")]
		public BEZEOUBAROK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7178C60", Offset = "0x7177460", VA = "0x187178C60", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class BUIOENRKGYC : GDKFMQAPOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string IGPTJUXWXQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GLTF.Math.Color WYXNBYTABQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string FDULPSXRSFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float HOZBJTXOYSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float PGOUAKURMWM;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7178C70", Offset = "0x7177470", VA = "0x187178C70")]
		public BUIOENRKGYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x717AB90", Offset = "0x7179390", VA = "0x18717AB90", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class QAJPMTJTAQE : BUIOENRKGYC
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7178C70", Offset = "0x7177470", VA = "0x187178C70")]
		public QAJPMTJTAQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7178C60", Offset = "0x7177460", VA = "0x187178C60", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class HVFPGOXADRE : BUIOENRKGYC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float VKABXZIBTKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float LQTXMMEPLBK;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x717BD90", Offset = "0x717A590", VA = "0x18717BD90")]
		public HVFPGOXADRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x717BA90", Offset = "0x717A290", VA = "0x18717BA90", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface LBHVTJLFAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VMOSMKMOVHI(LAUAUTWBLDQ a, QCIBGCEFWCD b, [Out] JMKSXGAKABW c);
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface FSIGLUSVGTB
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JProperty Serialize();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FSIGLUSVGTB Clone(LAUAUTWBLDQ root);
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class ETPFOIZEJRM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string RTCWPHWRUXZ;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		protected ETPFOIZEJRM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class NNQHAPTMDMN : FSIGLUSVGTB
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public JProperty MJYWCAAMEHO
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7184A00", Offset = "0x7183200", VA = "0x187184A00", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public NNQHAPTMDMN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class CIADOXLNUEJ : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x717AE10", Offset = "0x7179610", VA = "0x18717AE10", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public CIADOXLNUEJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class DMEQDXSPZZZ : VHZUCXUIOXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GLTF.Math.Color TJMOWJAEBBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public QIKLJPGCIIC GYWRKHRNUPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public GLTF.Math.Color AHGWVCQQUUC;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x717B380", Offset = "0x7179B80", VA = "0x18717B380")]
		public DMEQDXSPZZZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x717AE80", Offset = "0x7179680", VA = "0x18717AE80")]
		public static DMEQDXSPZZZ Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x717B120", Offset = "0x7179920", VA = "0x18717B120", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class ROLLCZTRBRF : QIKLJPGCIIC
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const string FNXSDONWGBR = "scale";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double CEBXYJMWNDR;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x71862C0", Offset = "0x7184AC0", VA = "0x1871862C0")]
		public ROLLCZTRBRF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7185F10", Offset = "0x7184710", VA = "0x187185F10")]
		public new static ROLLCZTRBRF Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7186200", Offset = "0x7184A00", VA = "0x187186200", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class YDEMZBFEQRZ : QIKLJPGCIIC
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string ETXSEZPYSLY = "strength";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public double CCLTHEMLUGK;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x71862C0", Offset = "0x7184AC0", VA = "0x1871862C0")]
		public YDEMZBFEQRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x718BDB0", Offset = "0x718A5B0", VA = "0x18718BDB0")]
		public new static YDEMZBFEQRZ Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x718C0A0", Offset = "0x718A8A0", VA = "0x18718C0A0", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class TCLFOSHIVHE : VHZUCXUIOXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GLTF.Math.Color GSFJHNNQOES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public QIKLJPGCIIC RVIOBYVMKFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public double NZVXJUPHDFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public double HGFUFUWYXNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public QIKLJPGCIIC HVZRAKIRBTJ;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7187230", Offset = "0x7185A30", VA = "0x187187230")]
		public TCLFOSHIVHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7186C30", Offset = "0x7185430", VA = "0x187186C30")]
		public static TCLFOSHIVHE Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7186FA0", Offset = "0x71857A0", VA = "0x187186FA0", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class BGBASGRQLOL : VHZUCXUIOXF
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class IXGZENONTMW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public JsonReader SMROOBILXEY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public LAUAUTWBLDQ GCIIEAQCVVB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public Func<LDTJWYXTGAV> HHJKLVTYFOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<LDTJWYXTGAV> HGYWRIGDMRS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public Func<Dictionary<string, LDTJWYXTGAV>> HHORJCNVOZT;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public IXGZENONTMW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x717D240", Offset = "0x717BA40", VA = "0x18717D240")]
			internal LDTJWYXTGAV CCVXQDNGJPA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x717D310", Offset = "0x717BB10", VA = "0x18717D310")]
			internal Dictionary<string, LDTJWYXTGAV> CDBENKHDTAJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x717D170", Offset = "0x717B970", VA = "0x18717D170")]
			internal LDTJWYXTGAV CCLJVPZLQSI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Dictionary<string, LDTJWYXTGAV> MNYFMPYXABU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public LDTJWYXTGAV ZFUKKGNXURW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public ZZQQYECRUCT CQFBEJDCVNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DrawMode SQMPCVEDKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<Dictionary<string, LDTJWYXTGAV>> SXJGSLCBVZB;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x717A650", Offset = "0x7178E50", VA = "0x18717A650")]
		public BGBASGRQLOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7179FB0", Offset = "0x71787B0", VA = "0x187179FB0")]
		public BGBASGRQLOL(BGBASGRQLOL a, LAUAUTWBLDQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7179540", Offset = "0x7177D40", VA = "0x187179540")]
		public static int[] LYZRQLCWPMF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x71793E0", Offset = "0x7177BE0", VA = "0x1871793E0")]
		public static int[] LUJQUDLSPNB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x71796E0", Offset = "0x7177EE0", VA = "0x1871796E0")]
		public static int[] RDUPWJJXCNL(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7178CC0", Offset = "0x71774C0", VA = "0x187178CC0")]
		public static int[] DCPUYEQJPRN(int[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x71798A0", Offset = "0x71780A0", VA = "0x1871798A0")]
		public static int[] THQQIDYMDQW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7179F40", Offset = "0x7178740", VA = "0x187179F40")]
		public static int[] ZODZEDLCQSX(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7179350", Offset = "0x7177B50", VA = "0x187179350")]
		public static int[] FXLUDEZGMDB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7179670", Offset = "0x7177E70", VA = "0x187179670")]
		public static int[] PFZMUVSINOA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x71795E0", Offset = "0x7177DE0", VA = "0x1871795E0")]
		public static int[] NCDBUKWIIAM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7178F00", Offset = "0x7177700", VA = "0x187178F00")]
		public static BGBASGRQLOL Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7179950", Offset = "0x7178150", VA = "0x187179950", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class LVLNPDHAGTM
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] HZJMGUZWJUV;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] MWUYGRPPWGO;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] TTGJBFZPAZV;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] WIOVCKJVZMZ;
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
	public class LBKZHWCVPSD : GDKFMQAPOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool NKVRPTTWOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public BMQKHYSLCUJ ZVIRVPJDCJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public List<KMXGEKPSBZI> TXPQWHWYDUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public XKDPMVLVWRN JUEAKBKICPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public NWPNRJQQBKK VKMAAGZXZBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public QSPKQMWNOVR BPWNMZKOBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GLTF.Math.Quaternion SOURHICWKCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GLTF.Math.Vector3 CEBXYJMWNDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GLTF.Math.Vector3 UIRZRMLXOPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<double> PJYGDYAMSDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public XFXGBCPZAYI XHCDDZWRSIV;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7182900", Offset = "0x7181100", VA = "0x187182900")]
		public LBKZHWCVPSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x71813E0", Offset = "0x717FBE0", VA = "0x1871813E0")]
		public static LBKZHWCVPSD Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7181D10", Offset = "0x7180510", VA = "0x187181D10", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class Sampler : GDKFMQAPOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MagFilterMode LKVHFSYBKYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MinFilterMode UTHQOMWYIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public WrapMode RRLFFNWOEAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public WrapMode RSWBMJFVSCJ;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7186BC0", Offset = "0x71853C0", VA = "0x187186BC0")]
		public Sampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7186700", Offset = "0x7184F00", VA = "0x187186700")]
		public static Sampler Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x71869D0", Offset = "0x71851D0", VA = "0x1871869D0", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
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
	public class JUEAKBKICPM : GDKFMQAPOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public LDTJWYXTGAV ONLIWKEFVJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public KMXGEKPSBZI BESPOQFVKRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public List<KMXGEKPSBZI> ZTNYWMRNAIS;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x717DF40", Offset = "0x717C740", VA = "0x18717DF40")]
		public JUEAKBKICPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x717D8D0", Offset = "0x717C0D0", VA = "0x18717D8D0")]
		public static JUEAKBKICPM Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x717DC30", Offset = "0x717C430", VA = "0x18717DC30", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class QIKLJPGCIIC : VHZUCXUIOXF
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const string DTTSABHEQPL = "index";

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const string NRWUYHLSFZD = "texCoord";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public NDXVFODIJBJ TTXNZPFFZFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int HZJMGUZWJUV;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7185C50", Offset = "0x7184450", VA = "0x187185C50")]
		public QIKLJPGCIIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7185CA0", Offset = "0x71844A0", VA = "0x187185CA0")]
		public QIKLJPGCIIC(QIKLJPGCIIC a, LAUAUTWBLDQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x71858A0", Offset = "0x71840A0", VA = "0x1871858A0")]
		public static QIKLJPGCIIC Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7185BF0", Offset = "0x71843F0", VA = "0x187185BF0", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7185B20", Offset = "0x7184320", VA = "0x187185B20")]
		public void EBNUPAUKKGK(JsonWriter a)
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
	public class KGNPDNUIZNN
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly double HVYTSZDEIYD;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly double TBSUUYAMTXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public double YZCNBSTGGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public double ZMVUEBQWCWU;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x717E490", Offset = "0x717CC90", VA = "0x18717E490")]
		public KGNPDNUIZNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x717DFF0", Offset = "0x717C7F0", VA = "0x18717DFF0")]
		public static KGNPDNUIZNN Deserialize(JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x717E230", Offset = "0x717CA30", VA = "0x18717E230")]
		public void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class LYHHURXCKKP : GDKFMQAPOKE
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly GLTF.Math.Color VZXTFRDCBEM;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly double JMBZWQAXHPM;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly double YOLYYSRTTUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LightType QWAVKIDXYXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public GLTF.Math.Color MWUYGRPPWGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public double OSJXAUHFYRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public double HPHKPONNKRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public KGNPDNUIZNN KGNPDNUIZNN;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7183B60", Offset = "0x7182360", VA = "0x187183B60")]
		public LYHHURXCKKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7183C20", Offset = "0x7182420", VA = "0x187183C20")]
		public LYHHURXCKKP(LYHHURXCKKP a, LAUAUTWBLDQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7183270", Offset = "0x7181A70", VA = "0x187183270")]
		public static LYHHURXCKKP Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7183660", Offset = "0x7181E60", VA = "0x187183660")]
		public static LYHHURXCKKP Deserialize(LAUAUTWBLDQ root, JToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7183780", Offset = "0x7181F80", VA = "0x187183780", Slot = "4")]
		public override void VOPQGDPBGDJ(JsonWriter a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class UJCANHNANPT : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly IList<BUIOENRKGYC> ULIBRNZYBXI;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public UJCANHNANPT(IList<BUIOENRKGYC> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7187D70", Offset = "0x7186570", VA = "0x187187D70", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7187D00", Offset = "0x7186500", VA = "0x187187D00", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class ADUCHDASPJP : FSIGLUSVGTB, LBHVTJLFAKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<LYHHURXCKKP> QVWWWGZDPGS;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7178610", Offset = "0x7176E10", VA = "0x187178610")]
		public ADUCHDASPJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x71777A0", Offset = "0x7175FA0", VA = "0x1871777A0", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7177E80", Offset = "0x7176680", VA = "0x187177E80", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7177F70", Offset = "0x7176770", VA = "0x187177F70")]
		private static string[] TVVKSRRSDJX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7177A20", Offset = "0x7176220", VA = "0x187177A20")]
		private static JMKSXGAKABW.ImportValuesConversion NTZDYMPHAZT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7178220", Offset = "0x7176A20", VA = "0x187178220", Slot = "6")]
		public bool VMOSMKMOVHI(LAUAUTWBLDQ a, QCIBGCEFWCD b, [Out] JMKSXGAKABW c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class NDPDGUMNPRY : PFBVESDYJJS<LYHHURXCKKP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override LYHHURXCKKP Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x71842E0", Offset = "0x7182AE0", VA = "0x1871842E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x71842A0", Offset = "0x7182AA0", VA = "0x1871842A0")]
		public NDPDGUMNPRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x71841C0", Offset = "0x71829C0", VA = "0x1871841C0")]
		public static NDPDGUMNPRY Deserialize(LAUAUTWBLDQ root, JsonReader reader)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class MHPPYRRVBWR : FSIGLUSVGTB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public NDPDGUMNPRY XFXGBCPZAYI;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public MHPPYRRVBWR(NDPDGUMNPRY a, LAUAUTWBLDQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7183EC0", Offset = "0x71826C0", VA = "0x187183EC0")]
		public MHPPYRRVBWR(int a, LAUAUTWBLDQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7183D40", Offset = "0x7182540", VA = "0x187183D40", Slot = "5")]
		public FSIGLUSVGTB Clone(LAUAUTWBLDQ root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7183DC0", Offset = "0x71825C0", VA = "0x187183DC0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class ZVDBSQJTPAQ : ETPFOIZEJRM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x718CB60", Offset = "0x718B360", VA = "0x18718CB60")]
		public ZVDBSQJTPAQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x718C680", Offset = "0x718AE80", VA = "0x18718C680", Slot = "4")]
		public override FSIGLUSVGTB Deserialize(LAUAUTWBLDQ root, JProperty extensionToken)
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
